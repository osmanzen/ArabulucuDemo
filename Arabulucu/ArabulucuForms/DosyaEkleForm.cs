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
using Arabulucu.MessageForms;
using Arabulucu.ArabulucuUC;
using ZenSoftModel.DTO;
using DevExpress.XtraSplashScreen;
using ZenSoftModel.Entities;
using ZenSoftDAL.EntityFramework;
using System.Collections.ObjectModel;

namespace Arabulucu
{
    public partial class DosyaEkleForm : DevExpress.XtraEditors.XtraForm
    {
        public DosyaEkleForm(ObservableCollection<Dava> gelenDavaSource)
        {
            InitializeComponent();
            davaSource = gelenDavaSource;
            buroDB = new Repository<Buro>();
            kayitliBuro = buroDB.Find(x => x.AktifMi);
            davaDB = new Repository<Dava>();

            dtpBasvuruTarihi.DateTime = DateTime.Now;
        }
        ObservableCollection<Dava> davaSource;

        Repository<Buro> buroDB;
        Repository<Dava> davaDB;
        Buro kayitliBuro;

        TarafSecimForm trfSecimForm;
        KarsiTarafUC karsiTarafUC;
        KarsiTarafKurumUC karsiTarafKurumUC;

        Dava yeniDava;

        private void DosyaEkleForm_Load(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
        }

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
                }
                else
                {
                    karsiTarafUC = new KarsiTarafUC() { Height = 165 };
                    karsiTarafUC.TarafSecici(trfSecimForm.secilenTaraf);
                    karsiTarafUC.Dock = DockStyle.Bottom;
                    pnlKarsiTaraf.Controls.Add(karsiTarafUC);
                }
                btnKarsiTarafEkle.SendToBack();
                pnlDosya.ScrollControlIntoView(btnKarsiTarafEkle);
            }
        }

        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            yeniDava = new Dava()
            {
                BuroID = kayitliBuro.ID,
                BuroDosyaNo = txtBuroDosyaNo.Text,
                ArabuluculukDosyaNo = txtArabulucuDosyaNo.Text,
                ArabuluculukBurosu = txtArabuluculukBurosu.Text,
                BasvuruTarihi = Convert.ToDateTime(dtpBasvuruTarihi.Text),
                Durum = "",
                Sonuc = ""
            };

            yeniDava.DavaKonulari = new List<DavaKonusu>();
            foreach (DavaKonusu item in secilenKonular)
            {
                yeniDava.DavaKonulari.Add(item);
            }

            basvurucuUC1.UpdateDava(yeniDava);

            foreach (Control item in pnlKarsiTaraf.Controls)
            {
                if (item.IsDisposed == false)
                {
                    if (item.GetType() == typeof(KarsiTarafUC))
                    {
                        (item as KarsiTarafUC).UpdateKarsiTaraf(yeniDava);
                    }
                    else if (item.GetType() == typeof(KarsiTarafKurumUC))
                    {
                        (item as KarsiTarafKurumUC).UpdateKarsiTaraf(yeniDava);
                    }
                }
            }
            davaDB.Insert(yeniDava);
            davaSource.Add(yeniDava);
        }

        DosyaTuruForm dosyaTuruFrm;
        DavaTuru secilenTur;
        private void txtBasvuruTuru_Click(object sender, EventArgs e)
        {
            dosyaTuruFrm = new DosyaTuruForm();
            if (dosyaTuruFrm.ShowDialog() == DialogResult.OK)
            {
                secilenTur = dosyaTuruFrm.secilenTur;
                txtBasvuruTuru.Text = secilenTur.TurAdi;
            }
        }

        DosyaKonulariForm dosyaKonuFrm;
        List<DavaKonusu> secilenKonular;
        private void txtBasvuruKonulari_Click(object sender, EventArgs e)
        {
            dosyaKonuFrm = new DosyaKonulariForm(secilenTur);
            if (dosyaKonuFrm.ShowDialog() == DialogResult.OK)
            {
                secilenKonular = dosyaKonuFrm.secilenKonuList;

                txtBasvuruKonulari.Text = "";

                for (int i = 0; i < secilenKonular.Count; i++)
                {
                    if (i > 0)
                    {
                        txtBasvuruKonulari.Text += ",";
                    }
                    txtBasvuruKonulari.Text += secilenKonular[i].KonuAdi;
                }
            }
        }
    }
}