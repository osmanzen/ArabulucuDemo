using Arabulucu.MessageForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZenSoftDAL.EntityFramework;
using ZenSoftModel.DTO;
using ZenSoftModel.Entities;

namespace Arabulucu
{
    public partial class BuroKayitForm : DevExpress.XtraEditors.XtraForm
    {
        public BuroKayitForm()
        {
            InitializeComponent();

            bankaDB = new Repository<HesapBilgileri>();
            buroDB = new Repository<Buro>();

            yeniBuro = new Buro();

            hesapSource = new BindingSource();
            gridControlBanka.DataSource = hesapSource;
        }

        Buro yeniBuro;
        HesapBilgileri yeniHesap;
        TelefonBilgileri yeniTel;

        BindingSource hesapSource;

        Repository<HesapBilgileri> bankaDB;
        Repository<Buro> buroDB;

        HesapEkleForm hesapEkleForm;

        private void btnBuroKaydet_Click(object sender, EventArgs e)
        {
            yeniBuro.SicilNo = txtSicil.Text;
            yeniBuro.TcKimlikNo = txtTC.Text;
            yeniBuro.VergiNumarsi = txtTC.Text;
            yeniBuro.AdSoyad = txtAd.Text;
            yeniBuro.KomisyonIl = txtIl.Text;
            yeniBuro.KomisyonIlce = txtIlce.Text;
            yeniBuro.EPosta = txtEposta.Text;
            yeniBuro.Adres = txtEposta.Text;

            //SABİT
            yeniTel = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Sabit,
                BuroID = yeniBuro.ID,
                Numara = txtSabit.Text,
            };
            yeniBuro.TelefonBilgileri.Add(yeniTel);

            //CEP
            yeniTel = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Cep,
                BuroID = yeniBuro.ID,
                Numara = txtCep.Text,
            };
            yeniBuro.TelefonBilgileri.Add(yeniTel);

            //FAX
            yeniTel = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Fax,
                BuroID = yeniBuro.ID,
                Numara = txtFax.Text,
            };

            yeniBuro.TelefonBilgileri.Add(yeniTel);

            if (((HesapBilgileri)gridViewBanka.GetRow(0)) != null)
            {
                for (int i = 0; i < gridViewBanka.RowCount; i++)
                {
                    yeniHesap = ((HesapBilgileri)gridViewBanka.GetRow(i));
                    yeniBuro.HesapBilgileri.Add(yeniHesap);
                }
            }

            if (buroDB.Insert(yeniBuro) > 0)
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
            hesapEkleForm = new HesapEkleForm();

            if (hesapEkleForm.ShowDialog() == DialogResult.OK)
            {
                hesapSource.Add(hesapEkleForm.yeniHesap);
            }
        }

        private void btnBankaSil_Click(object sender, EventArgs e)
        {
            if (hesapSource.Count > 0)
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
            }
        }
    }
}