using DevExpress.XtraSplashScreen;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using ZenSoftDAL.EntityFramework;
using ZenSoftModel.DTO;
using ZenSoftModel.Entities;

namespace Arabulucu
{
    public partial class VekillerForm : DevExpress.XtraEditors.XtraForm
    {
        public VekillerForm(ObservableCollection<Vekil> gelenVekilSource)
        {
            InitializeComponent();

            vekilDB = new Repository<Vekil>();
            vekilSource = gelenVekilSource;
            gridControlVekil.DataSource = vekilSource;
        }

        Repository<Vekil> vekilDB;
        ObservableCollection<Vekil> vekilSource;

        Vekil secilenVekil, yeniVekil;
        TelefonBilgileri telefonBilgisi;

        private void VekillerForm_Load(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
        }

        private void gridViewVekil_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                int secilenRow = e.RowHandle;
                layoutSil.ContentVisible = true;
                layoutGuncelle.ContentVisible = true;
                btnYeniVekil.Text = "Yeni Vekil Olarak Ekle";
                secilenVekil = (Vekil)gridViewVekil.GetRow(secilenRow);

                txtSicil.DataBindings.Clear();
                txtTC.DataBindings.Clear();
                txtAdSoyad.DataBindings.Clear();
                txtCep.DataBindings.Clear();
                txtTel.DataBindings.Clear();
                txtFax.DataBindings.Clear();
                txtEposta.DataBindings.Clear();
                txtAdres.DataBindings.Clear();
                txtBuroIl.DataBindings.Clear();
                txtBuroIlce.DataBindings.Clear();

                txtSicil.DataBindings.Add("Text", secilenVekil, "SicilNo", true, DataSourceUpdateMode.Never);
                txtTC.DataBindings.Add("Text", secilenVekil, "TCKimlikNo", true, DataSourceUpdateMode.Never);
                txtAdSoyad.DataBindings.Add("Text", secilenVekil, "AdiSoyadi", true, DataSourceUpdateMode.Never);
                txtCep.DataBindings.Add("Text", secilenVekil.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Cep).FirstOrDefault(), "Numara", true, DataSourceUpdateMode.Never);
                txtTel.DataBindings.Add("Text", secilenVekil.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Sabit).FirstOrDefault(), "Numara", true, DataSourceUpdateMode.Never);
                txtFax.DataBindings.Add("Text", secilenVekil.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Fax).FirstOrDefault(), "Numara", true, DataSourceUpdateMode.Never);
                txtEposta.DataBindings.Add("Text", secilenVekil, "Eposta", true, DataSourceUpdateMode.Never);
                txtAdres.DataBindings.Add("Text", secilenVekil, "Adres", true, DataSourceUpdateMode.Never);
                txtBuroIl.DataBindings.Add("Text", secilenVekil, "BuroIl", true, DataSourceUpdateMode.Never);
                txtBuroIlce.DataBindings.Add("Text", secilenVekil, "BuroIlce", true, DataSourceUpdateMode.Never);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secilenVekil.SicilNo = txtSicil.Text;
            secilenVekil.TCKimlikNo = txtTC.Text;
            secilenVekil.AdiSoyadi = txtAdSoyad.Text;
            secilenVekil.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Cep).FirstOrDefault().Numara = txtCep.Text;
            secilenVekil.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Sabit).FirstOrDefault().Numara = txtTel.Text;
            secilenVekil.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Fax).FirstOrDefault().Numara = txtFax.Text;
            secilenVekil.Eposta = txtEposta.Text;
            secilenVekil.Adres = txtAdres.Text;
            secilenVekil.BuroIl = txtBuroIl.Text;
            secilenVekil.BuroIlce = txtBuroIlce.Text;

            vekilDB.Update(secilenVekil);
            ArabulucuHelper.KayitBasariliFormGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            vekilDB.Delete(secilenVekil);
            vekilSource.Remove(secilenVekil);
        }

        private void btnYeniVekil_Click(object sender, EventArgs e)
        {
            yeniVekil = new Vekil()
            {
                SicilNo = txtSicil.Text,
                TCKimlikNo = txtTC.Text,
                AdiSoyadi = txtAdSoyad.Text,
                Eposta = txtEposta.Text,
                Adres = txtAdres.Text,
                BuroIl = txtBuroIl.Text,
                BuroIlce = txtBuroIlce.Text
            };

            telefonBilgisi = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Sabit,
                VekilID = yeniVekil.ID,
                Numara = txtTel.Text,
            };

            yeniVekil.TelefonBilgileri.Add(telefonBilgisi);

            telefonBilgisi = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Cep,
                VekilID = yeniVekil.ID,
                Numara = txtCep.Text,
            };

            yeniVekil.TelefonBilgileri.Add(telefonBilgisi);

            telefonBilgisi = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Fax,
                VekilID = yeniVekil.ID,
                Numara = txtFax.Text,
            };

            yeniVekil.TelefonBilgileri.Add(telefonBilgisi);

            if (vekilDB.Insert(yeniVekil) > 0)
            {
                vekilSource.Add(yeniVekil);
                ArabulucuHelper.KayitBasariliFormGetir();
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu. Lüften Bilgileri Kontrol Edip Tekrar Deneyiniz.");
            }
        }
    }
}