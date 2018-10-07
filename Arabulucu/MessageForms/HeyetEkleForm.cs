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
    public partial class HeyetEkleForm : DevExpress.XtraEditors.XtraForm
    {
        public HeyetEkleForm()
        {
            InitializeComponent();
        }

        public Heyet yeniHeyet;
        private void btnHeyetKaydet_Click(object sender, EventArgs e)
        {
            yeniHeyet = new Heyet() {
                AdiSoyadi = txtAdi.Text,
                Görevi=txtGorevi.Text,
                TCKimlikNo=txtTC.Text
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}