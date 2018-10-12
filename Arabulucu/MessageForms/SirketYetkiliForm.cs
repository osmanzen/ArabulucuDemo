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

namespace Arabulucu.MessageForms
{
    public partial class SirketYetkiliForm : DevExpress.XtraEditors.XtraForm
    {
        public SirketYetkiliForm(SirketYetkilisi _yetkili)
        {
            InitializeComponent();
            yetkili = _yetkili;
        }

        public SirketYetkilisi yetkili { get; set; }
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

            yetkili.Gorevi = txtGorevi.Text;
            yetkili.TCKimlikNo = txtTC.Text;
            yetkili.YetkiliAdi = txtAdSoyad.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void SirketYetkiliForm_Load(object sender, EventArgs e)
        {
            if (yetkili.YetkiliAdi != "" || yetkili.TCKimlikNo != "" || yetkili.Gorevi != "")
            {
                txtAdSoyad.Text = yetkili.YetkiliAdi;
                txtGorevi.Text = yetkili.Gorevi;
                txtTC.Text = yetkili.TCKimlikNo;
                this.simpleButton1.ImageOptions.Image = global::Arabulucu.Properties.Resources.icons8_available_updates_16;
                this.simpleButton1.Text = "Yetkili Güncelle";
                this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
                this.Text = "Yetkili Güncelle";
            }
        }
    }
}