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
using ZenSoftModel.DTO;
using Arabulucu.MessageForms;

namespace Arabulucu.ArabulucuUC
{
    public partial class KarsiTarafUC : UserControl
    {
        public KarsiTarafUC()
        {
            InitializeComponent();
            Dock = DockStyle.Top;

            ArabulucuHelper.ButtonImageSearchIcon(txtTaraf);
            ArabulucuHelper.ButtonImageSearchIcon(txtVekili);
        }

        KarsiTaraf taraf;

        private void layoutControlGroup2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            this.Dispose();
        }

        public void FillTaraf(KarsiTaraf gelenTaraf)
        {
            taraf = gelenTaraf;
            secilenTaraf = gelenTaraf.Taraf;
            secilenVekil = gelenTaraf.Vekil;

            txtTaraf.DataBindings.Add("Text", taraf.Taraf, "TarafAdi", true, DataSourceUpdateMode.Never);
            if (taraf.Vekil != null)
            {
                txtVekili.DataBindings.Add("Text", taraf.Vekil, "AdiSoyadi", true, DataSourceUpdateMode.Never);
            }
            txtNotlar.DataBindings.Add("Text", taraf, "KarsiTarafNot", true, DataSourceUpdateMode.Never);
        }

        Taraf secilenTaraf;
        public void TarafSecici(Taraf taraf)
        {
            secilenTaraf = taraf;
            txtTaraf.DataBindings.Add("Text", secilenTaraf, "TarafAdi", true, DataSourceUpdateMode.Never);
        }

        TarafSecimForm trfForm;
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

        Vekil secilenVekil;
        VekilSecimForm vklForm;
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

        KarsiTaraf yeniKarsiTaraf;
        public void UpdateKarsiTaraf(Dava gelenDava)
        {
            yeniKarsiTaraf = new KarsiTaraf()
            {
                DavaID = gelenDava.ID,
                KarsiTarafNot = txtNotlar.Text,
                TarafID = secilenTaraf.ID,
            };

            if (secilenVekil != null)
            {
                yeniKarsiTaraf.VekilID = secilenVekil.ID;
            }


            gelenDava.KarsiTaraflar.Add(yeniKarsiTaraf);
        }
    }
}
