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

namespace Arabulucu.MessageForms
{
    public partial class KayitBasariliForm : DevExpress.XtraEditors.XtraForm
    {
        public KayitBasariliForm()
        {
            InitializeComponent();
        }

        private void KayitBasariliForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int time = 0;
        private void timerKapat_Tick(object sender, EventArgs e)
        {
            time++;
            if (time >= 12)
                this.Close();
        }

        private void lblKayit_Click(object sender, EventArgs e)
        {
            time = 16;
        }
    }
}