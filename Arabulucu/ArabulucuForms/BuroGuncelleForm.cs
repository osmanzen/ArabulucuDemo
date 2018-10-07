using Arabulucu.MessageForms;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ZenSoftDAL.EntityFramework;
using ZenSoftModel.DTO;
using ZenSoftModel.Entities;

namespace Arabulucu
{
    public partial class BuroGuncelleForm : DevExpress.XtraEditors.XtraForm
    {
        public BuroGuncelleForm(Buro gelenBuro)
        {
            InitializeComponent();

            buroDB = new Repository<Buro>();
            telefonDB = new Repository<TelefonBilgileri>();
            hesapDB = new Repository<HesapBilgileri>();

            buro = gelenBuro;

            hesapSource = new List<HesapBilgileri>();

            gridControlBanka.DataSource = hesapSource;
        }

        Repository<Buro> buroDB;
        Repository<TelefonBilgileri> telefonDB;
        Repository<HesapBilgileri> hesapDB;

        Buro buro;

        List<HesapBilgileri> hesapSource;

        HesapEkleForm hesapForm;

        private void BuroGuncelleForm_Load(object sender, EventArgs e)
        {
            txtSicil.DataBindings.Add("Text", buro, "SicilNo", true, DataSourceUpdateMode.Never);
            txtTC.DataBindings.Add("Text", buro, "TcKimlikNo", true, DataSourceUpdateMode.Never);
            txtVergi.DataBindings.Add("Text", buro, "VergiNumarsi", true, DataSourceUpdateMode.Never);
            txtAd.DataBindings.Add("Text", buro, "AdSoyad", true, DataSourceUpdateMode.Never);
            txtIl.DataBindings.Add("Text", buro, "KomisyonIl", true, DataSourceUpdateMode.Never);
            txtIlce.DataBindings.Add("Text", buro, "KomisyonIlce", true, DataSourceUpdateMode.Never);
            txtSabit.DataBindings.Add("Text", buro.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Sabit), "Numara", true, DataSourceUpdateMode.Never);
            txtCep.DataBindings.Add("Text", buro.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Cep), "Numara", true, DataSourceUpdateMode.Never);
            txtFax.DataBindings.Add("Text", buro.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Fax), "Numara", true, DataSourceUpdateMode.Never);
            txtAdres.DataBindings.Add("Text", buro, "Adres", true, DataSourceUpdateMode.Never);
            txtEposta.DataBindings.Add("Text", buro, "EPosta", true, DataSourceUpdateMode.Never);

            foreach (HesapBilgileri hsp in buro.HesapBilgileri)
            {
                hesapSource.Add(hsp);
            }
            gridControlBanka.RefreshDataSource();

            SplashScreenManager.CloseForm();
        }

        private void btnBuroKaydet_Click(object sender, EventArgs e)
        {
            buro.SicilNo = txtSicil.Text;
            buro.TcKimlikNo = txtTC.Text;
            buro.VergiNumarsi = txtVergi.Text;
            buro.AdSoyad = txtAd.Text;
            buro.KomisyonIl = txtIl.Text;
            buro.KomisyonIlce = txtIlce.Text;
            buro.Adres = txtAdres.Text;
            buro.EPosta = txtEposta.Text;
            buro.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Sabit).Numara = txtSabit.Text;
            buro.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Cep).Numara = txtCep.Text;
            buro.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Fax).Numara = txtFax.Text;

            buro.HesapBilgileri = hesapSource;

            if (buroDB.Save() > 0)
            {
                ArabulucuHelper.KayitBasariliFormGetir();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu. Lütfen Bilgileri Kontrol Edip Tekrar Deneyiniz.");
            }
        }

        private void btnBankaEkle_Click(object sender, EventArgs e)
        {
            hesapForm = new HesapEkleForm();
            hesapForm.yeniHesap.BuroID = buro.ID;

            if (hesapForm.ShowDialog() == DialogResult.OK)
            {
                hesapSource.Add(hesapForm.yeniHesap);
                gridControlBanka.RefreshDataSource();
            }
        }

        private void btnBankaSil_Click(object sender, EventArgs e)
        {
            List<HesapBilgileri> silinecekListe = new List<HesapBilgileri>();

            foreach (var item in gridViewBanka.GetSelectedRows())
            {
                silinecekListe.Add((HesapBilgileri)gridViewBanka.GetRow(item));
            }

            foreach (var item in silinecekListe)
            {
                hesapSource.Remove(item);
            }

            gridControlBanka.RefreshDataSource();
        }
    }
}