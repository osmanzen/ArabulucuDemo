using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenSoftModel.Entities;
using Arabulucu.MessageForms;

namespace Arabulucu.ArabulucuUC
{
    public partial class DosyaBilgileriUC : UserControl
    {
        public DosyaBilgileriUC()
        {
            InitializeComponent();
            ArabulucuHelper.ButtonImageSearchIcon(txtDosyaTuru);
            ArabulucuHelper.ButtonImageSearchIcon(txtDosyaKonulari);
        }

        Dava dava;

        public void FillDava(Dava gelenDava)
        {
            dava = gelenDava;
            secilenTur = gelenDava.DavaKonulari.FirstOrDefault().DavaTuru;

            secilenKonular = new List<DavaKonusu>();
            secilenKonular.AddRange(gelenDava.DavaKonulari);
            txtDosyaKonulari.Text = "";
            for (int i = 0; i < secilenKonular.Count; i++)
            {
                if (i > 0)
                {
                    txtDosyaKonulari.Text += ",";
                }
                txtDosyaKonulari.Text += secilenKonular[i].KonuAdi;
            }

            txtArabulucuDosyaNo.DataBindings.Clear();
            txtBuroDosyaNo.DataBindings.Clear();
            txtArabuluculukBurosu.DataBindings.Clear();
            dtpBasvuruTarihi.DataBindings.Clear();

            txtArabulucuDosyaNo.DataBindings.Add("Text", dava, "ArabuluculukDosyaNo", true, DataSourceUpdateMode.Never);
            txtBuroDosyaNo.DataBindings.Add("Text", dava, "BuroDosyaNo", true, DataSourceUpdateMode.Never);
            txtArabuluculukBurosu.DataBindings.Add("Text", dava, "ArabuluculukBurosu", true, DataSourceUpdateMode.Never);
            dtpBasvuruTarihi.DataBindings.Add("Text", dava, "BasvuruTarihi", true, DataSourceUpdateMode.Never);

            txtDosyaTuru.Text = secilenTur.TurAdi;
        }

        public void UpdateDava(Dava gelenDava)
        {
            gelenDava.ArabuluculukDosyaNo = txtArabulucuDosyaNo.Text;
            gelenDava.BuroDosyaNo = txtBuroDosyaNo.Text;
            gelenDava.ArabuluculukBurosu = txtArabuluculukBurosu.Text;
            gelenDava.BasvuruTarihi = Convert.ToDateTime(dtpBasvuruTarihi.Text);

            gelenDava.DavaKonulari.Clear();
            foreach (DavaKonusu item in secilenKonular)
            {
                gelenDava.DavaKonulari.Add(item);
            }
        }

        DavaTuru secilenTur;
        DosyaTuruForm dosyaTuruFrm;
        private void txtDosyaTuru_Click(object sender, EventArgs e)
        {
            dosyaTuruFrm = new DosyaTuruForm();
            if (dosyaTuruFrm.ShowDialog() == DialogResult.OK)
            {
                secilenTur = dosyaTuruFrm.secilenTur;
                txtDosyaTuru.Text = secilenTur.TurAdi;
                secilenKonular = new List<DavaKonusu>();
                txtDosyaKonulari.Text = "";
            }
        }

        List<DavaKonusu> secilenKonular;
        DosyaKonulariForm dosyaKonuFrm;
        private void txtDosyaKonulari_Click(object sender, EventArgs e)
        {
            dosyaKonuFrm = new DosyaKonulariForm(secilenTur);
            if (dosyaKonuFrm.ShowDialog() == DialogResult.OK)
            {
                secilenKonular = dosyaKonuFrm.secilenKonuList;

                txtDosyaKonulari.Text = "";

                for (int i = 0; i < secilenKonular.Count; i++)
                {
                    if (i > 0)
                    {
                        txtDosyaKonulari.Text += ",";
                    }
                    txtDosyaKonulari.Text += secilenKonular[i].KonuAdi;
                }
            }
        }
    }
}
