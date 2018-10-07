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

namespace Arabulucu.MessageForms.BelgeForm
{
    public partial class ToplantiErtelemeForm : DevExpress.XtraEditors.XtraForm
    {
        public ToplantiErtelemeForm()
        {
            InitializeComponent();
        }
        public DateTime yeniTarih;
        private void btnHeyetKaydet_Click(object sender, EventArgs e)
        {
            yeniTarih = new DateTime(dtpTarih.DateTime.Year, dtpTarih.DateTime.Month, dtpTarih.DateTime.Day, int.Parse(spinSaat.Text), int.Parse(spinDakika.Text), 0);
            this.DialogResult = DialogResult.OK;
        }

        private void ToplantiErtelemeForm_Load(object sender, EventArgs e)
        {
            dtpTarih.Text = DateTime.Now.ToShortDateString();
            spinSaat.Text = "12";
        }
    }
}