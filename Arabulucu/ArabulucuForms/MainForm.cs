using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ZenSoftDAL.EntityFramework;
using ZenSoftModel.Entities;
using Arabulucu.ArabulucuUC;
using ZenSoftModel.DTO;
using DevExpress.XtraSplashScreen;
using System.Collections.ObjectModel;
using Arabulucu.MessageForms;
using Arabulucu.ArabulucuHelpers;
using Arabulucu.MessageForms.BelgeForm;
using System.IO;
using DevExpress.XtraTreeList.Nodes;
using System.Diagnostics;
using System.Collections;
using Arabulucu.ArabulucuForms;

namespace Arabulucu
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Repository<Dava> davaDB;
        Repository<Buro> buroDB;
        Repository<Taraf> tarafDB;
        Repository<Vekil> vekilDB;
        Repository<Heyet> heyetDB;
        Repository<KarsiTaraf> karsiTarafDB;
        Repository<Gorusme> gorusmeDB;

        ObservableCollection<Dava> davaList;
        ObservableCollection<Taraf> tarafSource;
        ObservableCollection<Vekil> vekilSource;

        Buro kayitliBuro;
        Dava secilenDava;
        Guid secilenDavaID;
        int secilenRowIndex;

        KarsiTarafUC karsiTarafUC;
        KarsiTarafSirketUC karsiTarafSirketUC;
        KarsiTarafKurumUC karsiTarafKurumUC;

        TarafSecimForm trfSecimForm;
        static BuroGuncelleForm buroGuncelleForm;
        static TaraflarForm taraflarForm;
        static VekillerForm vekillerForm;
        static DosyaEkleForm dosyaEkleForm;
        static YeniEvrakForm yeniEvrakForm;

        TreeListNode baslikNode, turNode;
        String fPath;
        DirectoryInfo dInfo;
        FileInfo fInfo;

        //ANASAYFA YÜKLENİRKEN
        private void MainForm_Load(object sender, EventArgs e)
        {
            buroDB = new Repository<Buro>();
            BuroKayitFormGetir();

            davaDB = new Repository<Dava>();
            tarafDB = new Repository<Taraf>();
            karsiTarafDB = new Repository<KarsiTaraf>();
            heyetDB = new Repository<Heyet>();
            gorusmeDB = new Repository<Gorusme>();
            vekilDB = new Repository<Vekil>();

            davaList = new ObservableCollection<Dava>(davaDB.List());
            tarafSource = new ObservableCollection<Taraf>(tarafDB.List(x => x.AktifMi));
            vekilSource = new ObservableCollection<Vekil>(vekilDB.List(x => x.AktifMi));

            gridControlMainDava.DataSource = davaList;

            pnlDetailFill.Enabled = false;
            panel2.Enabled = false;
        }

        //İLK AÇILIŞ KAYITLI BÜRO YOKSA
        private void BuroKayitFormGetir()
        {
            kayitliBuro = buroDB.Find(x => x.AktifMi);

            if (kayitliBuro == null)
            {
                BuroKayitForm bkForm = new BuroKayitForm();
                if (bkForm.ShowDialog() != DialogResult.OK)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        //DAVA PANELİNE KARŞI TARAF EKLEME
        private void btnKarsiTarafEkle_Click(object sender, EventArgs e)
        {
            trfSecimForm = new TarafSecimForm();
            if (trfSecimForm.ShowDialog() == DialogResult.OK)
            {
                if (trfSecimForm.secilenTaraf.KisiSirketKurum == TarafTipi.Kurum)
                {
                    karsiTarafKurumUC = new KarsiTarafKurumUC() { Height = 360 };
                    karsiTarafKurumUC.TarafSecici(trfSecimForm.secilenTaraf);
                    karsiTarafKurumUC.Dock = DockStyle.Bottom;
                    pnlKarsiTaraf.Controls.Add(karsiTarafKurumUC);
                    karsiTarafKurumUC.SendToBack();
                }
                else if (trfSecimForm.secilenTaraf.KisiSirketKurum == TarafTipi.Sirket)
                {
                    karsiTarafSirketUC = new KarsiTarafSirketUC() { Height = 180 };
                    karsiTarafSirketUC.TarafSecici(trfSecimForm.secilenTaraf);
                    karsiTarafSirketUC.Dock = DockStyle.Bottom;
                    pnlKarsiTaraf.Controls.Add(karsiTarafSirketUC);
                    karsiTarafSirketUC.SendToBack();
                }
                else
                {
                    karsiTarafUC = new KarsiTarafUC() { Height = 165 };
                    karsiTarafUC.TarafSecici(trfSecimForm.secilenTaraf);
                    karsiTarafUC.Dock = DockStyle.Bottom;
                    pnlKarsiTaraf.Controls.Add(karsiTarafUC);
                    karsiTarafUC.SendToBack();
                }
            }
            pnlDosyaDetay.ScrollControlIntoView(btnKarsiTarafEkle);
        }

        //DAVA PANELİ GÖRÜNTÜ BOZULMALARINA KARŞI YENİLEME
        private void pnlKarsiTaraf_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        //DAVA GRID DAVA SECME İŞLEMİ
        private void gridViewMainDava_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                panel2.Enabled = true;
                pnlDetailFill.Enabled = true;
                secilenRowIndex = e.RowHandle;
                secilenDavaID = (Guid)gridViewMainDava.GetRowCellValue(secilenRowIndex, "ID");
                secilenDava = davaDB.Find(x => x.ID == secilenDavaID);

                FillMainDavaPanel(secilenDava);
                FillDosyaYonetici();
                FillGorusmeler();
            }
        }

        //DAVA PANELİ DOLDUR
        private void FillMainDavaPanel(Dava gelenDava)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
            dosyaBilgileriUC1.FillDava(gelenDava);
            basvurucuUC1.FillDava(gelenDava);

            pnlKarsiTaraf.Controls.Clear();

            foreach (KarsiTaraf kTaraf in gelenDava.KarsiTaraflar)
            {
                if (kTaraf.Taraf != null)
                {
                    if (kTaraf.Taraf.KisiSirketKurum == TarafTipi.Kisi)
                    {
                        karsiTarafUC = new KarsiTarafUC();
                        karsiTarafUC.FillTaraf(kTaraf);
                        pnlKarsiTaraf.Controls.Add(karsiTarafUC);
                    }
                    else if (kTaraf.Taraf.KisiSirketKurum == TarafTipi.Sirket)
                    {
                        karsiTarafSirketUC = new KarsiTarafSirketUC();
                        karsiTarafSirketUC.FillTaraf(kTaraf);
                        pnlKarsiTaraf.Controls.Add(karsiTarafSirketUC);
                    }
                    else if (kTaraf.Taraf.KisiSirketKurum == TarafTipi.Kurum)
                    {
                        karsiTarafKurumUC = new KarsiTarafKurumUC();
                        karsiTarafKurumUC.FillTaraf(kTaraf);
                        pnlKarsiTaraf.Controls.Add(karsiTarafKurumUC);
                    }
                }
            }

            splitMenu.Panel2.Enabled = true;

            SplashScreenManager.CloseForm();
        }

        //DOSYA YÖNETİCİSİ DOLDUR
        private void FillDosyaYonetici()
        {
            treeListFolder.ClearNodes();

            fPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Arabulucu Evraklar\" + secilenDava.ID;
            dInfo = new DirectoryInfo(fPath);

            treeListFolder.BeginUnboundLoad();

            baslikNode = treeListFolder.AppendNode(new object[] { secilenDava.ArabuluculukDosyaNo, dInfo.LastWriteTime, "", dInfo.FullName }, -1);

            if (dInfo.Exists)
            {
                foreach (var folder in dInfo.GetDirectories())
                {
                    turNode = treeListFolder.AppendNode(new object[] { folder.Name, folder.LastWriteTime, "", folder.FullName }, baslikNode.Id, 1, 1, -1);

                    foreach (var file in folder.GetFiles())
                    {
                        treeListFolder.AppendNode(new object[] { file.Name, file.LastWriteTime, file.FullName, file.FullName }, turNode.Id, 2, 2, -1);
                    }
                }
            }
            treeListFolder.EndUnboundLoad();

            treeListFolder.ExpandAll();
        }

        //DAVA SİL
        private void btnDavaSil_Click(object sender, EventArgs e)
        {
            davaDB.Delete(secilenDava);
            panel2.Enabled = false;
            gridViewMainDava.RefreshData();
        }

        //DAVA GÜNCELLE
        private void btnDavaGuncelle_Click(object sender, EventArgs e)
        {
            dosyaBilgileriUC1.UpdateDava(secilenDava);
            basvurucuUC1.UpdateDava(secilenDava);

            if (secilenDava.KarsiTaraflar != null)
            {
                foreach (var item in secilenDava.KarsiTaraflar)
                {
                    if (item.Heyetleri != null)
                    {
                        heyetDB.HardDeleteList(item.Heyetleri);
                    }
                }

                karsiTarafDB.HardDeleteList(secilenDava.KarsiTaraflar);
            }

            foreach (Control item in pnlKarsiTaraf.Controls)
            {
                if (item.IsDisposed == false)
                {
                    if (item.GetType() == typeof(KarsiTarafUC))
                    {
                        (item as KarsiTarafUC).UpdateKarsiTaraf(secilenDava);
                    }
                    else if (item.GetType() == typeof(KarsiTarafSirketUC))
                    {
                        (item as KarsiTarafSirketUC).UpdateKarsiTaraf(secilenDava);
                    }
                    else if (item.GetType() == typeof(KarsiTarafKurumUC))
                    {
                        (item as KarsiTarafKurumUC).UpdateKarsiTaraf(secilenDava);
                    }
                }
            }

            davaDB.Update(secilenDava);
            gridViewMainDava.RefreshData();
            FillMainDavaPanel(secilenDava);
            ArabulucuHelper.KayitBasariliFormGetir();
        }

        //BÜRO GÜNCELLEME FORMU
        private void btnBurom_Click(object sender, EventArgs e)
        {
            if (buroGuncelleForm == null || buroGuncelleForm.IsDisposed == true)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                buroGuncelleForm = new BuroGuncelleForm(buroDB.Find(x => x.AktifMi));
                buroGuncelleForm.Owner = this;
                buroGuncelleForm.Show();
            }
            else
            {
                buroGuncelleForm.WindowState = FormWindowState.Normal;
                buroGuncelleForm.Activate();
            }
        }

        //TARAFLAR FORM
        private void btnTaraflar_Click(object sender, EventArgs e)
        {
            if (taraflarForm == null || taraflarForm.IsDisposed == true)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                taraflarForm = new TaraflarForm(tarafSource);
                taraflarForm.Owner = this;
                taraflarForm.Show();
            }
            else
            {
                taraflarForm.WindowState = FormWindowState.Normal;
                taraflarForm.Activate();
            }
        }

        //VEKİLLER FORM
        private void btnVekiller_Click(object sender, EventArgs e)
        {
            if (vekillerForm == null || vekillerForm.IsDisposed == true)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                vekillerForm = new VekillerForm(vekilSource);
                vekillerForm.Owner = this;
                vekillerForm.Show();
            }
            else
            {
                vekillerForm.WindowState = FormWindowState.Normal;
                vekillerForm.Activate();
            }
        }

        //DAVA EKLE FORM
        private void btnDavaEkle_Click(object sender, EventArgs e)
        {
            if (dosyaEkleForm == null || dosyaEkleForm.IsDisposed == true)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                dosyaEkleForm = new DosyaEkleForm(davaList);
                dosyaEkleForm.Owner = this;
                dosyaEkleForm.Show();
            }
            else
            {
                dosyaEkleForm.WindowState = FormWindowState.Normal;
                dosyaEkleForm.Activate();
            }
        }

        //DOSYA YÖNETİCİSİ YENİLE
        private void bntBelgeYenile_Click(object sender, EventArgs e)
        {
            FillDosyaYonetici();
        }

        //TREELIST DOSYA,KLASÖR İSİM DEĞİŞTİRME
        private void treeListFolder_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            if (e.Value as String != "" && !e.Node.HasChildren)
            {
                fInfo = new FileInfo(e.Node[3] as String);
                fInfo.MoveTo(fInfo.DirectoryName + "\\" + e.Value);
            }
            else
            {
                MessageBox.Show("Ana Dizinlerin Adı Değiştirilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            FillDosyaYonetici();
        }

        //DOSYA, KLASÖR SİLME
        private void btnSil_Click(object sender, EventArgs e)
        {
            ArrayList rowDatas = treeListFolder.GetFocusedRow() as ArrayList;
            fInfo = new FileInfo(rowDatas[3].ToString());

            if (rowDatas[0].ToString() == secilenDava.ArabuluculukDosyaNo)
            {
                MessageBox.Show("Ana Dizin Silinemez.");
            }
            else if (fInfo.Exists)
            {
                if (MessageBox.Show("'" + rowDatas[0] + "' İsimli Dosyayı Silmek İstediğinizden Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    fInfo.Delete();
                }
            }
            else
            {
                dInfo = new DirectoryInfo(rowDatas[3].ToString());
                if (MessageBox.Show("'" + rowDatas[0] + "' İsimli Dosyayı Silmek İstediğinizden Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (var file in dInfo.GetFiles())
                    {
                        file.Delete();
                    }

                    dInfo.Delete();
                }
            }

            FillDosyaYonetici();
        }

        //DOSYA,KLASÖR YENİ PENCERE
        private void btnBelgeYeniPencere_Click(object sender, EventArgs e)
        {
            ArrayList rowDatas = treeListFolder.GetFocusedRow() as ArrayList;
            Process pr = new Process();
            pr.StartInfo = new ProcessStartInfo(rowDatas[3].ToString());
            pr.Start();
        }

        private void btnGorusmeSil_Click(object sender, EventArgs e)
        {
            if (gridViewGorusme.SelectedRowsCount > 0)
            {
                var secilenRow = gridViewGorusme.GetSelectedRows().FirstOrDefault();

                Gorusme secilenGorusme = gridViewGorusme.GetRow(secilenRow) as Gorusme;

                if (MessageBox.Show(secilenGorusme.GorusmeAdi + "\n" + secilenGorusme.GorusmeTarihi + "\n Seçilen Görüşmeyi Silmeyi Onaylıyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    secilenDava.Gorusmeler.Remove(secilenGorusme);
                    davaDB.Update(secilenDava);
                    FillGorusmeler();
                }
            }
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {

        }

        private void btnBildirimler_Click(object sender, EventArgs e)
        {

        }

        private void btnYeniEvrak_Click(object sender, EventArgs e)
        {
            using (yeniEvrakForm = new YeniEvrakForm(secilenDava, Cursor.Position.X - 259, Cursor.Position.Y))
            {
                if (yeniEvrakForm.ShowDialog() == DialogResult.OK)
                {
                    yeniEvrakForm.Activate();

                    FillDosyaYonetici();
                    FillGorusmeler();
                }
            }
        }


        //GÖRÜŞMELER GRID DOLDUR
        private void FillGorusmeler()
        {
            gridControlGorusme.DataSource = secilenDava.Gorusmeler.ToList();
            gridControlGorusme.RefreshDataSource();
        }
    }
}