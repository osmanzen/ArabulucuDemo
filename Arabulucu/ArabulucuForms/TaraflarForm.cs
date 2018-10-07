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
using DevExpress.XtraSplashScreen;
using ZenSoftModel.DTO;
using System.Collections.ObjectModel;

namespace Arabulucu
{
    public partial class TaraflarForm : DevExpress.XtraEditors.XtraForm
    {
        public TaraflarForm(ObservableCollection<Taraf> gelenTaraflarSource)
        {
            InitializeComponent();

            tarafDB = new Repository<Taraf>();
            taraflarSource = gelenTaraflarSource;

            gridControlKisi.DataSource = taraflarSource;

            gridControlSirket.DataSource = taraflarSource;

            gridControlKurum.DataSource = taraflarSource;
        }

        Repository<Taraf> tarafDB;
        ObservableCollection<Taraf> taraflarSource;

        Taraf yeniTaraf, secilenKisi, secilenSirket, secilenKurum;
        TelefonBilgileri yeniTel;

        private void TaraflarForm_Load(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm();
        }

        #region Yeni Kişi Şirket Kurum Ekle

        private void btnYeniKisi_Click(object sender, EventArgs e)
        {
            yeniTaraf = new Taraf()
            {
                TarafAdi = txtKisiAdSoyad.Text,
                Adres = txtKisiAdres.Text,
                KisiSirketKurum = TarafTipi.Kisi,
                TCKimlikNo = txtKisiTc.Text,
                Eposta = txtKisiEposta.Text,
            };

            yeniTel = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Sabit,
                TarafID = yeniTaraf.ID,
                Numara = txtKisiTel.Text,
            };

            yeniTaraf.TelefonBilgileri.Add(yeniTel);

            yeniTel = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Cep,
                TarafID = yeniTaraf.ID,
                Numara = txtKisiCep.Text,
            };

            yeniTaraf.TelefonBilgileri.Add(yeniTel);


            yeniTel = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Fax,
                TarafID = yeniTaraf.ID,
                Numara = txtKisiFax.Text,
            };
            yeniTaraf.TelefonBilgileri.Add(yeniTel);

            tarafDB.Insert(yeniTaraf);
            secilenKisi = yeniTaraf;
            taraflarSource.Add(yeniTaraf);
            ArabulucuHelper.KayitBasariliFormGetir();
        }

        private void btnYeniSirket_Click(object sender, EventArgs e)
        {
            yeniTaraf = new Taraf()
            {
                TarafAdi = txtSirketUnvani.Text,
                Adres = txtSirketAdres.Text,
                KisiSirketKurum = TarafTipi.Sirket,
                Eposta = txtSirketEposta.Text
            };
            yeniTel = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Sabit,
                TarafID = yeniTaraf.ID,
                Numara = txtSirketTel.Text,
            };

            yeniTaraf.TelefonBilgileri.Add(yeniTel);


            yeniTel = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Cep,
                TarafID = yeniTaraf.ID,
                Numara = txtSirketCep.Text,
            };

            yeniTaraf.TelefonBilgileri.Add(yeniTel);


            yeniTel = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Fax,
                TarafID = yeniTaraf.ID,
                Numara = txtSirketFax.Text,
            };

            yeniTaraf.TelefonBilgileri.Add(yeniTel);

            tarafDB.Insert(yeniTaraf);
            secilenSirket = yeniTaraf;
            taraflarSource.Add(yeniTaraf);
            ArabulucuHelper.KayitBasariliFormGetir();
        }

        private void btnYeniKurum_Click(object sender, EventArgs e)
        {
            yeniTaraf = new Taraf()
            {
                TarafAdi = txtKurumUnvani.Text,
                Adres = txtKurumAdres.Text,
                KisiSirketKurum = TarafTipi.Kurum,
                Eposta = txtKurumEposta.Text
            };


            yeniTel = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Sabit,
                TarafID = yeniTaraf.ID,
                Numara = txtKurumTel.Text,
            };

            yeniTaraf.TelefonBilgileri.Add(yeniTel);



            yeniTel = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Cep,
                TarafID = yeniTaraf.ID,
                Numara = txtKurumCep.Text,
            };

            yeniTaraf.TelefonBilgileri.Add(yeniTel);



            yeniTel = new TelefonBilgileri()
            {
                SabitCepFax = TelefonTipi.Fax,
                TarafID = yeniTaraf.ID,
                Numara = txtKurumFax.Text,
            };

            yeniTaraf.TelefonBilgileri.Add(yeniTel);
            tarafDB.Insert(yeniTaraf);
            taraflarSource.Add(yeniTaraf);
            secilenKisi = secilenKurum;
            ArabulucuHelper.KayitBasariliFormGetir();
        }

        #endregion

        #region Kişi Şirket Kurum Sil

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            tarafDB.Delete(secilenKisi);
            taraflarSource.Remove(secilenKisi);
            ArabulucuHelper.KayitBasariliFormGetir();
        }

        private void btnSirketSil_Click(object sender, EventArgs e)
        {
            tarafDB.Delete(secilenSirket);
            taraflarSource.Remove(secilenSirket);
            ArabulucuHelper.KayitBasariliFormGetir();
        }

        private void btnKurumSil_Click(object sender, EventArgs e)
        {
            tarafDB.Delete(secilenKurum);
            taraflarSource.Remove(secilenKurum);
            ArabulucuHelper.KayitBasariliFormGetir();
        }

        #endregion

        #region Kişi Şirket Kurum Güncelle

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {
            secilenKisi.TarafAdi = txtKisiAdSoyad.Text;
            secilenKisi.TCKimlikNo = txtKisiTc.Text;
            secilenKisi.Adres = txtKisiAdres.Text;
            secilenKisi.Eposta = txtKisiEposta.Text;
            secilenKisi.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Sabit).Numara = txtKisiTel.Text;
            secilenKisi.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Cep).Numara = txtKisiCep.Text;
            secilenKisi.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Fax).Numara = txtKisiFax.Text;
            tarafDB.Update(secilenKisi);
            ArabulucuHelper.KayitBasariliFormGetir();
        }

        private void btnSirketGuncelle_Click(object sender, EventArgs e)
        {
            secilenSirket.TarafAdi = txtSirketUnvani.Text;
            secilenSirket.Adres = txtSirketAdres.Text;
            secilenSirket.Eposta = txtSirketEposta.Text;
            secilenSirket.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Sabit).Numara = txtSirketTel.Text;
            secilenSirket.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Cep).Numara = txtSirketCep.Text;
            secilenSirket.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Fax).Numara = txtSirketFax.Text;
            tarafDB.Update(secilenSirket);
            ArabulucuHelper.KayitBasariliFormGetir();
        }

        private void btnKurumGuncelle_Click(object sender, EventArgs e)
        {
            secilenKurum.TarafAdi = txtKurumUnvani.Text;
            secilenKurum.Adres = txtKurumAdres.Text;
            secilenKurum.Eposta = txtKurumEposta.Text;
            secilenKurum.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Sabit).Numara = txtKurumTel.Text;
            secilenKurum.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Cep).Numara = txtKurumCep.Text;
            secilenKurum.TelefonBilgileri.FirstOrDefault(x => x.SabitCepFax == TelefonTipi.Fax).Numara = txtKurumFax.Text;
            tarafDB.Update(secilenKurum);
            ArabulucuHelper.KayitBasariliFormGetir();
        }

        #endregion

        #region Grid Row Click Events

        private void gridViewKisi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            if (e.Clicks == 2)
            {
                txtKisiTc.DataBindings.Clear();
                txtKisiAdSoyad.DataBindings.Clear();
                txtKisiTel.DataBindings.Clear();
                txtKisiCep.DataBindings.Clear();
                txtKisiFax.DataBindings.Clear();
                txtKisiEposta.DataBindings.Clear();
                txtKisiAdres.DataBindings.Clear();

                int secilenRow = e.RowHandle;
                layoutKisiSil.ContentVisible = true;
                layoutKisiGuncelle.ContentVisible = true;
                btnYeniKisi.Text = "Yeni Kişi Olarak Ekle";
                secilenKisi = (Taraf)gridViewKisi.GetRow(secilenRow);
                txtKisiTc.DataBindings.Add("Text", secilenKisi, "TcKimlikNo", true, DataSourceUpdateMode.Never);
                txtKisiAdSoyad.DataBindings.Add("Text", secilenKisi, "TarafAdi", true, DataSourceUpdateMode.Never);
                txtKisiTel.DataBindings.Add("Text", secilenKisi.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Sabit).FirstOrDefault(), "Numara", true, DataSourceUpdateMode.Never);
                txtKisiCep.DataBindings.Add("Text", secilenKisi.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Cep).FirstOrDefault(), "Numara", true, DataSourceUpdateMode.Never);
                txtKisiFax.DataBindings.Add("Text", secilenKisi.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Fax).FirstOrDefault(), "Numara", true, DataSourceUpdateMode.Never);
                txtKisiEposta.DataBindings.Add("Text", secilenKisi, "Eposta", true, DataSourceUpdateMode.Never);
                txtKisiAdres.DataBindings.Add("Text", secilenKisi, "Adres", true, DataSourceUpdateMode.Never);
                gridViewKisi.SelectRow(secilenRow);
            }
        }

        private void gridViewSirket_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                txtSirketUnvani.DataBindings.Clear();
                txtSirketTel.DataBindings.Clear();
                txtSirketCep.DataBindings.Clear();
                txtSirketFax.DataBindings.Clear();
                txtSirketEposta.DataBindings.Clear();
                txtSirketAdres.DataBindings.Clear();

                int secilenRow = e.RowHandle;
                layoutSirketSil.ContentVisible = true;
                layoutSirketGuncelle.ContentVisible = true;
                btnYeniSirket.Text = "Yeni Şirket Olarak Ekle";
                secilenSirket = (Taraf)gridViewSirket.GetRow(secilenRow);
                txtSirketUnvani.DataBindings.Add("Text", secilenSirket, "TarafAdi", true, DataSourceUpdateMode.Never);
                txtSirketTel.DataBindings.Add("Text", secilenSirket.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Sabit).FirstOrDefault(), "Numara", true, DataSourceUpdateMode.Never);
                txtSirketCep.DataBindings.Add("Text", secilenSirket.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Cep).FirstOrDefault(), "Numara", true, DataSourceUpdateMode.Never);
                txtSirketFax.DataBindings.Add("Text", secilenSirket.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Fax).FirstOrDefault(), "Numara", true, DataSourceUpdateMode.Never);
                txtSirketEposta.DataBindings.Add("Text", secilenSirket, "Eposta", true, DataSourceUpdateMode.Never);
                txtSirketAdres.DataBindings.Add("Text", secilenSirket, "Adres", true, DataSourceUpdateMode.Never);
                gridViewSirket.SelectRow(secilenRow);
            }
        }

        private void gridViewKurum_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                txtKurumUnvani.DataBindings.Clear();
                txtKurumTel.DataBindings.Clear();
                txtKurumCep.DataBindings.Clear();
                txtKurumFax.DataBindings.Clear();
                txtKurumEposta.DataBindings.Clear();
                txtKurumAdres.DataBindings.Clear();

                int secilenRow = e.RowHandle;
                layoutKurumSil.ContentVisible = true;
                layoutKurumGuncelle.ContentVisible = true;
                btnYeniKurum.Text = "Yeni Kişi Olarak Ekle";
                secilenKurum = (Taraf)gridViewKurum.GetRow(secilenRow);
                txtKurumUnvani.DataBindings.Add("Text", secilenKurum, "TarafAdi", true, DataSourceUpdateMode.Never);
                txtKurumTel.DataBindings.Add("Text", secilenKurum.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Sabit).FirstOrDefault(), "Numara", true, DataSourceUpdateMode.Never);
                txtKurumCep.DataBindings.Add("Text", secilenKurum.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Cep).FirstOrDefault(), "Numara", true, DataSourceUpdateMode.Never);
                txtKurumFax.DataBindings.Add("Text", secilenKurum.TelefonBilgileri.Where(x => x.SabitCepFax == TelefonTipi.Fax).FirstOrDefault(), "Numara", true, DataSourceUpdateMode.Never);
                txtKurumEposta.DataBindings.Add("Text", secilenKurum, "Eposta", true, DataSourceUpdateMode.Never);
                txtKurumAdres.DataBindings.Add("Text", secilenKurum, "Adres", true, DataSourceUpdateMode.Never);
                gridViewKurum.SelectRow(secilenRow);
            }
        }

        #endregion
    }
}