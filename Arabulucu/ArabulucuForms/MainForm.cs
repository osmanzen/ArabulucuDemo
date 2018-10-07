using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ZenSoftDAL.EntityFramework;
using ZenSoftModel.Entities;
using Arabulucu.ArabulucuUC;
using ZenSoftModel.DTO;
using DevExpress.XtraSplashScreen;
using System.Collections.ObjectModel;
using Arabulucu.MessageForms;
using Arabulucu.ArabulucuHelpers;
using Microsoft.Office.Interop.Word;
using Arabulucu.MessageForms.BelgeForm;

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
        ObservableCollection<Gorusme> gorusmeSource;

        Buro kayitliBuro;
        Dava secilenDava;
        Guid secilenDavaID;
        int secilenRowIndex;

        KarsiTarafUC karsiTarafUC;
        KarsiTarafKurumUC karsiTarafKurumUC;

        private void MainForm_Load(object sender, EventArgs e)
        {
            buroDB = new Repository<Buro>();
            BuroKayitFormGetir();

            davaDB = new Repository<Dava>();
            davaList = new ObservableCollection<Dava>(davaDB.List());
            gridControlMainDava.DataSource = davaList;

            tarafDB = new Repository<Taraf>();
            tarafSource = new ObservableCollection<Taraf>(tarafDB.List(x => x.AktifMi));

            vekilDB = new Repository<Vekil>();
            vekilSource = new ObservableCollection<Vekil>(vekilDB.List(x => x.AktifMi));

            karsiTarafDB = new Repository<KarsiTaraf>();
            heyetDB = new Repository<Heyet>();

            gorusmeDB = new Repository<Gorusme>();

            panel2.Enabled = false;

            cmbEvraklar.ValueMember = "EvrakTipi";
            cmbEvraklar.DisplayMember = "EvrakAdi";
            cmbEvraklar.DataSource = ArabulucuHelper.EvrakListesi();
        }

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

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            splitGrid.SplitterPosition = this.Width / 4;
            sidePanel3.Width = this.Width / 8;

            if (this.Width > 1400)
            {
                sidePanel3.Visible = true;
            }
            else
            {
                sidePanel3.Visible = false;
            }
        }

        TarafSecimForm trfSecimForm;
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

        private void pnlKarsiTaraf_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void gridViewMainDava_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                panel2.Enabled = true;
                secilenRowIndex = e.RowHandle;
                secilenDavaID = (Guid)gridViewMainDava.GetRowCellValue(secilenRowIndex, "ID");
                secilenDava = davaDB.Find(x => x.ID == secilenDavaID);
                FillMainDavaPanel(secilenDava);

                gorusmeSource = new ObservableCollection<Gorusme>(gorusmeDB.List(x => x.DavaID == secilenDavaID));
                gridControlGorusme.DataSource = gorusmeSource;
            }
        }

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
                    if (kTaraf.Taraf.KisiSirketKurum != TarafTipi.Kurum)
                    {
                        karsiTarafUC = new KarsiTarafUC();
                        karsiTarafUC.FillTaraf(kTaraf);
                        pnlKarsiTaraf.Controls.Add(karsiTarafUC);
                    }
                    else
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

        private void btnDavaSil_Click(object sender, EventArgs e)
        {
            davaDB.Delete(secilenDava);
            panel2.Enabled = false;
            gridViewMainDava.RefreshData();
        }

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

        private void btnBurom_Click(object sender, EventArgs e)
        {
            BuroDuzenleFormGetir();
        }

        static BuroGuncelleForm buroGuncelleForm;
        public void BuroDuzenleFormGetir()
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

        private void btnTaraflar_Click(object sender, EventArgs e)
        {
            TaraflarFormGetir();
        }

        static TaraflarForm taraflarForm;
        public void TaraflarFormGetir()
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

        static VekillerForm vekillerForm;
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

        static DosyaEkleForm dosyaEkleForm;
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

        Evrak secilenEvrak;
        string belgeYolu;

        static Microsoft.Office.Interop.Word.Application wordApp;
        private void btnBelgeDuzenle_Click(object sender, EventArgs e)
        {
            if (belgeYolu != null)
            {
                wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Application.Documents.Open(belgeYolu + ".docx");
                wordApp.Visible = true;
                wordApp.Activate();
            }
        }

        private void bntBelgeYenile_Click(object sender, EventArgs e)
        {
            pdfViewer1.DocumentFilePath = "";

            EvrakOlusturucu.Yenile(belgeYolu);
            pdfViewer1.DocumentFilePath = belgeYolu + ".pdf";
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (cmbEvraklar.SelectedIndex != -1 && secilenDava != null)
            {
                secilenEvrak = (Evrak)cmbEvraklar.SelectedItem;

                if (secilenEvrak.EvrakTipi == EvrakTipi.DosyaKapakSayfasi)
                {
                    SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                    belgeYolu = EvrakOlusturucu.dosyaKapakSayfasi(secilenDava);
                    SplashScreenManager.CloseForm();

                }

                else if (secilenEvrak.EvrakTipi == EvrakTipi.ToplantiDavet)
                {
                    ToplantıDavetForm frm = new ToplantıDavetForm(secilenDava);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                        if (!frm.vekilMi)
                        {
                            Taraf davetEdilenTaraf = tarafDB.Find(x => x.ID == frm.davetEdilenID);
                            belgeYolu = EvrakOlusturucu.ToplantiyaDavet(secilenDava, frm.karsiTaraf, davetEdilenTaraf, frm.toplantiTarihi);
                        }
                        else
                        {
                            Vekil davetEdilenTaraf = vekilDB.Find(x => x.ID == frm.davetEdilenID);
                            belgeYolu = EvrakOlusturucu.ToplantiyaDavet(secilenDava, frm.karsiTaraf, davetEdilenTaraf, frm.toplantiTarihi);
                        }
                        SplashScreenManager.CloseForm();
                    }
                }

                else if (secilenEvrak.EvrakTipi == EvrakTipi.UcretSozlesmesi)
                {
                    UcretSozlesmeForm frm = new UcretSozlesmeForm(secilenDava.Burosu.HesapBilgileri.Where(x => x.AktifMi).ToList());

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                        belgeYolu = EvrakOlusturucu.UcretSozlesmesi(secilenDava, frm.secilenHesap, DateTime.Now);
                        SplashScreenManager.CloseForm();
                    }
                }

                else if (secilenEvrak.EvrakTipi == EvrakTipi.ToplantiTutanagi)
                {
                    SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                    belgeYolu = EvrakOlusturucu.ToplantiTutanagi(secilenDava);
                    SplashScreenManager.CloseForm();
                }


                else if (secilenEvrak.EvrakTipi == EvrakTipi.ToplantiErtelemeTutanagi)
                {
                    ToplantiErtelemeForm frm = new ToplantiErtelemeForm();

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                        belgeYolu = EvrakOlusturucu.ToplantiErtelemeTutanagi(secilenDava, frm.yeniTarih);
                        SplashScreenManager.CloseForm();
                    }
                }

                else if (secilenEvrak.EvrakTipi == EvrakTipi.AnlasmaTutanagi)
                {
                    AnlasmaTutanagiForm frm = new AnlasmaTutanagiForm(secilenDava);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                        if (frm.formdanGelenler != null)
                        {
                            if (frm.formdanGelenler.KismiAnlasma)
                            {
                                belgeYolu = EvrakOlusturucu.KismiAnlasmaTutanagi(secilenDava, frm.formdanGelenler);
                            }
                            else
                            {
                                belgeYolu = EvrakOlusturucu.BirdenFazlaAnlasmaTutanagi(secilenDava, frm.formdanGelenler);
                            }
                        }
                        else
                        {
                            belgeYolu = EvrakOlusturucu.AnlasmaTutanagi(secilenDava, frm.anlasmaMetni, frm.bitisTarihi, frm.odemeTarihi);
                        }
                        SplashScreenManager.CloseForm();
                    }
                }

                if (belgeYolu != null)
                {
                    pdfViewer1.DocumentFilePath = belgeYolu + ".pdf";
                }
            }
        }

        private void btnBelgeYeniPencere_Click(object sender, EventArgs e)
        {
            if (belgeYolu != null && belgeYolu != "")
            {
                BelgeTamEkranForm frm = new BelgeTamEkranForm(belgeYolu);
                frm.Show();
            }
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            pdfViewer1.Print();
        }
    }
}