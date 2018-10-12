using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenSoftModel.Entities;
using Arabulucu.MessageForms;

namespace Arabulucu.ArabulucuUC
{
    public partial class KarsiTarafSirketUC : UserControl
    {
        public KarsiTarafSirketUC()
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            ArabulucuHelper.ButtonImageSearchIcon(txtTaraf);
            ArabulucuHelper.ButtonImageSearchIcon(txtVekili);
            ArabulucuHelper.ButtonImageSearchIcon(txtSirketYetkili);
        }

        KarsiTaraf taraf;
        Taraf secilenTaraf;
        Vekil secilenVekil;
        SirketYetkilisi secilenYetkili;
        VekilSecimForm vklForm;
        TarafSecimForm trfForm;
        SirketYetkiliForm yetkiliForm;

        private void layoutControlGroup2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            this.Dispose();
        }

        public void TarafSecici(Taraf taraf)
        {
            secilenTaraf = taraf;
            txtTaraf.DataBindings.Add("Text", secilenTaraf, "TarafAdi", true, DataSourceUpdateMode.Never);
        }

        public void YetkiliSecici(SirketYetkilisi yetkili)
        {
            secilenYetkili = yetkili;
            txtSirketYetkili.DataBindings.Add("Text", taraf.Yetkili, "YetkiliAdi", true, DataSourceUpdateMode.Never);
        }

        public void FillTaraf(KarsiTaraf gelenTaraf)
        {
            taraf = gelenTaraf;
            secilenTaraf = gelenTaraf.Taraf;
            secilenVekil = gelenTaraf.Vekil;
            secilenYetkili = gelenTaraf.Yetkili;

            txtTaraf.DataBindings.Add("Text", taraf.Taraf, "TarafAdi", true, DataSourceUpdateMode.Never);
            if (taraf.Vekil != null)
            {
                txtVekili.DataBindings.Add("Text", taraf.Vekil, "AdiSoyadi", true, DataSourceUpdateMode.Never);
            }
            if (taraf.Yetkili != null)
            {
                txtSirketYetkili.DataBindings.Add("Text", taraf.Yetkili, "YetkiliAdi", true, DataSourceUpdateMode.Never);
            }
            txtNotlar.DataBindings.Add("Text", taraf, "KarsiTarafNot", true, DataSourceUpdateMode.Never);
        }

        private void txtTaraf_Click(object sender, EventArgs e)
        {
            trfForm = new TarafSecimForm(1);
            if (trfForm.ShowDialog() == DialogResult.OK)
            {
                secilenTaraf = trfForm.secilenTaraf;
                txtTaraf.DataBindings.Clear();
                txtTaraf.DataBindings.Add("Text", secilenTaraf, "TarafAdi", true, DataSourceUpdateMode.Never);
            }
        }

        private void txtVekili_Click(object sender, EventArgs e)
        {
            vklForm = new VekilSecimForm();
            if (vklForm.ShowDialog() == DialogResult.OK)
            {
                secilenVekil = vklForm.secilenVekil;
                txtVekili.DataBindings.Clear();
                txtVekili.DataBindings.Add("Text", secilenVekil, "AdiSoyadi", true, DataSourceUpdateMode.Never);
            }
        }

        SirketYetkilisi yetkili;
        private void txtSirketYetkili_Click(object sender, EventArgs e)
        {
            if (taraf == null)
                yetkili = new SirketYetkilisi();
            else if(taraf.Yetkili==null)
            {
                yetkili = new SirketYetkilisi();
            }
            else
                yetkili = new SirketYetkilisi() { YetkiliAdi = taraf.Yetkili.YetkiliAdi, Gorevi = taraf.Yetkili.Gorevi, TCKimlikNo = taraf.Yetkili.TCKimlikNo };

            yetkiliForm = new SirketYetkiliForm(yetkili);
            if (yetkiliForm.ShowDialog() == DialogResult.OK)
            {
                secilenYetkili = yetkiliForm.yetkili;
                txtSirketYetkili.DataBindings.Clear();
                txtSirketYetkili.DataBindings.Add("Text", secilenYetkili, "YetkiliAdi", true, DataSourceUpdateMode.Never);
            }
        }

        KarsiTaraf yeniKarsiTaraf;
        public void UpdateKarsiTaraf(Dava gelenDava)
        {
            yeniKarsiTaraf = new KarsiTaraf()
            {
                DavaID = gelenDava.ID,
                KarsiTarafNot = txtNotlar.Text,
                TarafID = secilenTaraf.ID
            };

            if (secilenYetkili != null)
            {
                yeniKarsiTaraf.Yetkili = secilenYetkili;
            }

            if (secilenVekil != null)
            {
                yeniKarsiTaraf.Vekil = secilenVekil;
            }

            gelenDava.KarsiTaraflar.Add(yeniKarsiTaraf);
        }
    }
}
