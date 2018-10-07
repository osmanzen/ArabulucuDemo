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

namespace Arabulucu.MessageForms.BelgeForm
{
    public partial class AnlasmaTutanagiForm : DevExpress.XtraEditors.XtraForm
    {
        public AnlasmaTutanagiForm(Dava _gelenDava)
        {
            InitializeComponent();
            gelenDava = _gelenDava;
        }

        Dava gelenDava;
        public string anlasmaTipi;
        public string anlasmaMetni;
        public DateTime bitisTarihi;
        public DateTime odemeTarihi;
        public AnlasmaMetniGerekenler formdanGelenler;

        private void btnAnlasmaOlustur_Click(object sender, EventArgs e)
        {
            anlasmaTipi = "anlaşma";
            anlasmaMetni = richTextBox1.Text;
            this.DialogResult = DialogResult.OK;
            bitisTarihi = new DateTime(dtpTarih.DateTime.Year, dtpTarih.DateTime.Month, dtpTarih.DateTime.Day, int.Parse(spinSaat.Text), int.Parse(spinDakika.Text), 0);
            odemeTarihi = dtpTarih.DateTime;
        }


        private void AnlasmaTutanagiForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "\t\tİşveren-İdare " + gelenDava.KarsiTaraflar.FirstOrDefault().Taraf.TarafAdi + " Başvurucunun Kıdem Tazminatı tutarı olarak net ***NET ÜCRET*** yi Başvurucuya ödemeyi ve bu bedeli ***ÖDEME TARİHİ*** tarihinde başvurucunun ***IBAN*** İban Nolu Hesabına Aktarmayı Kabul Etmiştir.\n\t\tBaşvurucu, İşvereni işbu bedelin .....";

            dtpTarih.DateTime = DateTime.Now;
            spinSaat.Text = DateTime.Now.Hour.ToString();
            spinDakika.Text = DateTime.Now.Minute.ToString();

            dtpBAnlasmaTar.DateTime = DateTime.Now;
            spinBanlasmaSaat.Text = DateTime.Now.Hour.ToString();
            spinBanlasmaDakika.Text = DateTime.Now.Minute.ToString();

            dtpBbelgeTar.DateTime = DateTime.Now;

            dtpKanlasmaTarihi.DateTime = DateTime.Now;
            spinKanlasmaSaat.Text = DateTime.Now.Hour.ToString();
            spinKanlasmaDakika.Text = DateTime.Now.Minute.ToString();

            dtpKBelgeTarih.DateTime = DateTime.Now;
        }

        private void btnBirdenFazla_Click(object sender, EventArgs e)
        {
            formdanGelenler = new AnlasmaMetniGerekenler()
            {
                AnlasmaTarihi = new DateTime(dtpBAnlasmaTar.DateTime.Year, dtpBAnlasmaTar.DateTime.Month, dtpBAnlasmaTar.DateTime.Day, int.Parse(spinBanlasmaSaat.Text), int.Parse(spinBanlasmaDakika.Text), 0),
                OdemeTarihi = new DateTime(dtpBbelgeTar.DateTime.Year, dtpBbelgeTar.DateTime.Month, dtpBbelgeTar.DateTime.Day),
                NetKidemTazminati = Convert.ToDecimal(txtBKidem.Text),
                NetIhbarTazminati = Convert.ToDecimal(txtBIhbarTazminat.Text),
                NetUcretAlacagi = Convert.ToDecimal(txtBnetUcretAlacagi.Text),
                NetYillikIzinAlacagi = Convert.ToDecimal(txtBYillikIzin.Text),
                FazlaCalismaAlacagi = Convert.ToDecimal(txtBFazlaCalisma.Text),
                ResmiTatilCalisma = Convert.ToDecimal(txtBResmiTatil.Text),
                NetTutar = Convert.ToDecimal(txtBTutar.Text),
                IBAN = txtBIban.Text,
                KismiAnlasma = false
            };

            this.DialogResult = DialogResult.OK;
        }

        private void btnKismi_Click(object sender, EventArgs e)
        {
            formdanGelenler = new AnlasmaMetniGerekenler()
            {
                AnlasmaTarihi = new DateTime(dtpKanlasmaTarihi.DateTime.Year, dtpKanlasmaTarihi.DateTime.Month, dtpKanlasmaTarihi.DateTime.Day, int.Parse(spinKanlasmaSaat.Text), int.Parse(spinKanlasmaDakika.Text), 0),
                OdemeTarihi = new DateTime(dtpKBelgeTarih.DateTime.Year, dtpKBelgeTarih.DateTime.Month, dtpKBelgeTarih.DateTime.Day),
                NetKidemTazminati = Convert.ToDecimal(txtKNetKidem.Text),
                NetIhbarTazminati = Convert.ToDecimal(txtKIhbarTazminat.Text),
                NetUcretAlacagi = Convert.ToDecimal(txtKNetUcret.Text),
                NetYillikIzinAlacagi = Convert.ToDecimal(txtKYillikIzin.Text),
                FazlaCalismaAlacagi = Convert.ToDecimal(txtKFazlaCalisma.Text),
                ResmiTatilCalisma = Convert.ToDecimal(txtKResmiTatil.Text),
                NetTutar = Convert.ToDecimal(txtKTutar.Text),
                IBAN = txtKIban.Text,
                KismiAnlasma = true
            };

            this.DialogResult = DialogResult.OK;
        }

        decimal kTotal;
        private void txtKNetKidem_Leave(object sender, EventArgs e)
        {
            kTotal = (Convert.ToDecimal(txtKNetKidem.Text) + Convert.ToDecimal(txtKIhbarTazminat.Text) + Convert.ToDecimal(txtKNetUcret.Text) + Convert.ToDecimal(txtKYillikIzin.Text) + Convert.ToDecimal(txtKFazlaCalisma.Text) + Convert.ToDecimal(txtKResmiTatil.Text));
            txtKTutar.Text = kTotal.ToString();
        }

        decimal bTotal;
        private void txtBKidem_Leave(object sender, EventArgs e)
        {
            bTotal = (Convert.ToDecimal(txtBKidem.Text) + Convert.ToDecimal(txtBIhbarTazminat.Text) + Convert.ToDecimal(txtBnetUcretAlacagi.Text) + Convert.ToDecimal(txtBYillikIzin.Text) + Convert.ToDecimal(txtBFazlaCalisma.Text) + Convert.ToDecimal(txtBResmiTatil.Text));
            txtBTutar.Text = bTotal.ToString();
        }
    }
}