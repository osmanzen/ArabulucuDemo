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

namespace Arabulucu.MessageForms
{
    public partial class ToplantıDavetForm : DevExpress.XtraEditors.XtraForm
    {
        public Taraf karsiTaraf;
        public Guid davetEdilenID;
        public DateTime toplantiTarihi;
        public bool vekilMi = false;
        Dava gelenDava;
        public ToplantıDavetForm(Dava _gelenDava)
        {
            InitializeComponent();
            gelenDava = _gelenDava;
        }

        private void ToplantıDavetForm_Load(object sender, EventArgs e)
        {
            cboxDavetEdilen.DisplayMember = "adi";
            cboxKarsiTaraf.DisplayMember = "TarafAdi";

            cboxDavetEdilen.ValueMember = "id";
            cboxKarsiTaraf.ValueMember = "ID";

            dtpTarih.DateTime = DateTime.Now;
            spinSaat.Text = "12";
            spinDakika.Text = "00";

            foreach (var karsiTaraf in gelenDava.KarsiTaraflar)
            {
                cboxKarsiTaraf.Items.Add(karsiTaraf.Taraf);
            }
            cboxKarsiTaraf.SelectedIndex = 0;

            cboxDavetEdilen.Items.Add(new CboxItem { adi = "(Başvurucu) - " + gelenDava.Basvurucu.TarafAdi, id = gelenDava.Basvurucu.ID });
            cboxDavetEdilen.Items.Add(new CboxItem { adi = "(Başvurucu Vekili) - " + gelenDava.BasvurucuVekili.AdiSoyadi, id = gelenDava.BasvurucuVekili.ID, vekilMi = true });

            foreach (var karsiTaraf in gelenDava.KarsiTaraflar)
            {
                cboxDavetEdilen.Items.Add(new CboxItem { adi = "(Karşı Taraf) - " + karsiTaraf.Taraf.TarafAdi, id = karsiTaraf.Taraf.ID });

                if (karsiTaraf.Taraf.KisiSirketKurum == TarafTipi.Kurum)
                {
                    foreach (var ilgili in karsiTaraf.IlgiliKurumlari)
                    {
                        cboxDavetEdilen.Items.Add(new CboxItem{ adi = "(İlgili Taraf) - " + ilgili.TarafAdi, id = ilgili.ID });
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
            toplantiTarihi = new DateTime(dtpTarih.DateTime.Year, dtpTarih.DateTime.Month, dtpTarih.DateTime.Day, int.Parse(spinSaat.Text), int.Parse(spinDakika.Text), 0);
            try
            {
                karsiTaraf = cboxKarsiTaraf.SelectedItem as Taraf;
            }
            catch (Exception)
            {

                karsiTaraf = (cboxKarsiTaraf.SelectedItem as KarsiTaraf).Taraf;
            }

            this.DialogResult = DialogResult.OK;
        }

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