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
    public partial class HesapEkleForm : DevExpress.XtraEditors.XtraForm
    {
        public HesapEkleForm()
        {
            InitializeComponent();
            yeniHesap = new HesapBilgileri();
        }

        public HesapBilgileri yeniHesap;

        private void btnBuroKaydet_Click(object sender, EventArgs e)
        {
            yeniHesap.BankaAdi = txtBankaAdi.Text;
            yeniHesap.SubeAdi = txtSubeAdi.Text;
            yeniHesap.IBAN = txtIBAN.Text;
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}