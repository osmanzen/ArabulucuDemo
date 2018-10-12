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
using ZenSoftModel.Entities;
using ZenSoftModel.DTO;
using DevExpress.XtraEditors.Controls;
using Newtonsoft.Json;
using ZenSoftDAL.EntityFramework;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace Arabulucu.MessageForms
{
    public partial class ToplantıDavetForm : DevExpress.XtraEditors.XtraForm
    {
        public Taraf karsiTaraf;
        public Guid davetEdilenID;
        public DateTime toplantiTarihi;
        public bool vekilMi = false;
        Dava gelenDava;
        Gorusme gorusme;
        public GorusmeVerisi gorusmeVerisi;
        CheckedListBoxItem cbListItem;
        Repository<Dava> davaDB;
        Repository<Taraf> tarafDB;

        public ToplantıDavetForm(Dava _gelenDava)
        {
            InitializeComponent();

            gelenDava = _gelenDava;

            davaDB = new Repository<Dava>();
            tarafDB = new Repository<Taraf>();

            GorusmeVerisiGetir();

            cboxDavetEdilen.DisplayMember = "adi";
            cboxDavetEdilen.ValueMember = "id";

            TarihSaatDoldur();
        }

        private void ToplantıDavetForm_Load(object sender, EventArgs e)
        {
            cboxDavetEdilen.Items.Add(new CboxItem { adi = "(Başvurucu) - " + gelenDava.Basvurucu.TarafAdi, id = gelenDava.Basvurucu.ID });
            cboxDavetEdilen.Items.Add(new CboxItem { adi = "(Başvurucu Vekili) - " + gelenDava.BasvurucuVekili.AdiSoyadi, id = gelenDava.BasvurucuVekili.ID, vekilMi = true });

            foreach (var karsiTaraf in gelenDava.KarsiTaraflar)
            {
                cboxDavetEdilen.Items.Add(new CboxItem { adi = "(Karşı Taraf) - " + karsiTaraf.Taraf.TarafAdi, id = karsiTaraf.Taraf.ID });

                if (karsiTaraf.Taraf.KisiSirketKurum == TarafTipi.Kurum)
                {
                    foreach (var ilgili in karsiTaraf.IlgiliKurumlari)
                    {
                        cboxDavetEdilen.Items.Add(new CboxItem { adi = "(İlgili Taraf) - " + ilgili.TarafAdi, id = ilgili.ID });
                    }
                }
            }

            if (cboxDavetEdilen.Items.Count > 0)
            {
                cboxDavetEdilen.SelectedIndex = 0;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Lütfen Karşı Taraf Seçiniz.\nKarşı Taraf Kurum ise İlgili Kurumlar Alanına Ekleme Yapıldığını Kontrol Ediniz.");
            }
        }

        private void BelgeOlustur_Click(object sender, EventArgs e)
        {
            davetEdilenID = (cboxDavetEdilen.SelectedItem as CboxItem).id;
            if ((cboxDavetEdilen.SelectedItem as CboxItem).vekilMi)
            {
                vekilMi = true;
            }

            GorusmeVerisiYaz();

            ToplantiTarihiAyarla();

            davaDB.Update(gelenDava);

            this.DialogResult = DialogResult.OK;
        }

        //Form Açılırken Tarih Saat Alanlarını Olan/Olmayan Veriye Göre Doldurur
        private void TarihSaatDoldur()
        {
            if (gorusme == null)
            {
                dtpTarih.DateTime = DateTime.Now;
                spinSaat.Text = "12";
                spinDakika.Text = "00";
            }
            else
            {
                dtpTarih.DateTime = gorusme.GorusmeTarihi.Value.Date;
                spinSaat.Text = gorusme.GorusmeTarihi.Value.Hour.ToString();
                spinDakika.Text = gorusme.GorusmeTarihi.Value.Minute.ToString();
            }
        }

        //Toplantı Tarihini Oluşturur yada Günceller
        private void ToplantiTarihiAyarla()
        {
            toplantiTarihi = new DateTime(dtpTarih.DateTime.Year, dtpTarih.DateTime.Month, dtpTarih.DateTime.Day, int.Parse(spinSaat.Text), int.Parse(spinDakika.Text), 0);
            gorusme.GorusmeTarihi = toplantiTarihi;
        }

        //Gorusme Verisine Göre Karşı Taraf Listesini Doldurur
        private void GorusmeVerisiGetir()
        {
            gorusme = gelenDava.Gorusmeler.FirstOrDefault(x => x.AktifMi && x.GorusmeYapildi == false);

            if (gorusme != null)
            {
                if (gorusme.GorusmeVeri != null)
                {
                    gorusmeVerisi = JsonConvert.DeserializeObject<GorusmeVerisi>(gorusme.GorusmeVeri);

                    foreach (var item in gorusmeVerisi.karsiTarafCheckedListBoxItems)
                    {
                        karsiTaraf = tarafDB.Find(x => x.ID == item.tarafID);
                        cbListItem = new CheckedListBoxItem(karsiTaraf, karsiTaraf.TarafAdi, item.checkState);
                        cboxListKarsiTaraf.Items.Add(cbListItem);
                    }
                }
            }
            else
            {
                foreach (var karsiTaraf in gelenDava.KarsiTaraflar)
                {
                    cbListItem = new CheckedListBoxItem();
                    cbListItem.Value = karsiTaraf.Taraf;
                    cbListItem.Description = karsiTaraf.Taraf.TarafAdi;
                    cbListItem.CheckState = CheckState.Checked;

                    cboxListKarsiTaraf.Items.Add(cbListItem);

                    if (karsiTaraf.Taraf.KisiSirketKurum == TarafTipi.Kurum)
                    {
                        foreach (var kurum in karsiTaraf.IlgiliKurumlari)
                        {
                            cbListItem = new CheckedListBoxItem();
                            cbListItem.Value = kurum;
                            cbListItem.Description = kurum.TarafAdi;
                            cbListItem.CheckState = CheckState.Checked;

                            cboxListKarsiTaraf.Items.Add(cbListItem);
                        }
                    }
                }
            }
        }

        //Belgeyi Oluşturduktan Sonra Form Bilgisini Kaydeder
        private void GorusmeVerisiYaz()
        {
            if (gorusme == null)
            {
                gorusmeVerisi = new GorusmeVerisi();

                gorusmeVerisi.karsiTarafCheckedListBoxItems = new List<CBoxListItem>();

                foreach (CheckedListBoxItem item in cboxListKarsiTaraf.Items)
                {
                    gorusmeVerisi.karsiTarafCheckedListBoxItems.Add(new CBoxListItem((item.Value as Taraf).ID, item.CheckState));
                }

                string json = JsonConvert.SerializeObject(gorusmeVerisi);

                gorusme = new Gorusme() { GorusmeAdi = "İlk Toplantı", GorusmeYapildi = false, GorusmeTarihi = toplantiTarihi, Aciklama = "", GorusmeVeri = json };
                gelenDava.Gorusmeler.Add(gorusme);

            }
            else
            {
                gorusmeVerisi.karsiTarafCheckedListBoxItems = new List<CBoxListItem>();

                foreach (CheckedListBoxItem item in cboxListKarsiTaraf.Items)
                {
                    gorusmeVerisi.karsiTarafCheckedListBoxItems.Add(new CBoxListItem((item.Value as Taraf).ID, item.CheckState));
                }

                string json = JsonConvert.SerializeObject(gorusmeVerisi);

                gorusme.GorusmeVeri = json;
            }
        }

        //ListBoxItem Yukarı
        private void btnTarafYukari_Click(object sender, EventArgs e)
        {
            var seciliItem = cboxListKarsiTaraf.SelectedItem;
            if (seciliItem != null)
            {
                int index = cboxListKarsiTaraf.Items.IndexOf(seciliItem);

                if (index != 0)
                {
                    var secilenUstItem = cboxListKarsiTaraf.Items[index - 1];
                    cboxListKarsiTaraf.Items[index - 1] = seciliItem as CheckedListBoxItem;
                    cboxListKarsiTaraf.Items[index] = secilenUstItem;
                    cboxListKarsiTaraf.SelectedItem = seciliItem;
                }
            }
        }

        //ListBoxItem Aşağı
        private void btnTarafAsagi_Click(object sender, EventArgs e)
        {
            var seciliItem = cboxListKarsiTaraf.SelectedItem;
            if (seciliItem != null)
            {
                int index = cboxListKarsiTaraf.Items.IndexOf(seciliItem);

                if (index != cboxListKarsiTaraf.Items.Count - 1)
                {
                    var secilenAltItem = cboxListKarsiTaraf.Items[index + 1];
                    cboxListKarsiTaraf.Items[index + 1] = seciliItem as CheckedListBoxItem;
                    cboxListKarsiTaraf.Items[index] = secilenAltItem;
                    cboxListKarsiTaraf.SelectedItem = seciliItem;
                }
            }
        }

        //Davet Edilen Kişi/Şirket/Kurum/VEKİL
        private class CboxItem
        {
            public CboxItem()
            {
                vekilMi = false;
            }
            public Guid id { get; set; }
            public string adi { get; set; }
            public bool vekilMi { get; set; }
        }
    }
}