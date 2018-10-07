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

namespace Arabulucu.MessageForms.BelgeForm
{
    public partial class UcretSozlesmeForm : DevExpress.XtraEditors.XtraForm
    {
        public UcretSozlesmeForm(List<HesapBilgileri> _hesapBilgileri)
        {
            InitializeComponent();
            hesapBilgileri = _hesapBilgileri;
        }

        List<HesapBilgileri> hesapBilgileri;
        public HesapBilgileri secilenHesap;

        private void UcretSozlesmeForm_Load(object sender, EventArgs e)
        {
            gridControlHesapSec.DataSource = hesapBilgileri;
        }

        private void btnHeyetKaydet_Click(object sender, EventArgs e)
        {
            string txt = gridViewHesapSec.GetFocusedRowCellValue("ID").ToString();
            secilenHesap = hesapBilgileri.Find(x => x.ID == new Guid(txt));

            this.DialogResult = DialogResult.OK;
        }
    }
}