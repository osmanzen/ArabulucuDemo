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
using ZenSoftDAL.EntityFramework;
using Arabulucu.MessageForms;

namespace Arabulucu.ArabulucuUC
{
    public partial class BasvurucuUC : UserControl
    {
        public BasvurucuUC()
        {
            InitializeComponent();
            ArabulucuHelper.ButtonImageSearchIcon(txtBtnBasvurucu);
            ArabulucuHelper.ButtonImageSearchIcon(txtBtnVekili);
        }

        public Dava dava;
        public void FillDava(Dava gelenDava)
        {
            dava = gelenDava;
            secilenBasvurucu = gelenDava.Basvurucu;
            secilenVekil = gelenDava.BasvurucuVekili;
            txtBtnBasvurucu.DataBindings.Clear();
            txtBtnVekili.DataBindings.Clear();
            txtCalisilanYer.DataBindings.Clear();
            txtNot.DataBindings.Clear();

            txtBtnBasvurucu.DataBindings.Add("Text", dava.Basvurucu, "TarafAdi", true, DataSourceUpdateMode.Never);
            if (dava.BasvurucuVekili != null)
            {
                txtBtnVekili.DataBindings.Add("Text", dava.BasvurucuVekili, "AdiSoyadi", true, DataSourceUpdateMode.Never);
            }
            txtCalisilanYer.DataBindings.Add("Text", dava, "CalisilanYer", true, DataSourceUpdateMode.Never);
            txtNot.DataBindings.Add("Text", dava, "BasvurucuNot", true, DataSourceUpdateMode.Never);
        }

        TarafSecimForm trfForm;
        Taraf secilenBasvurucu;
        private void txtBtnBasvurucu_Click(object sender, EventArgs e)
        {
            trfForm = new TarafSecimForm(0);
            if (trfForm.ShowDialog() == DialogResult.OK)
            {
                secilenBasvurucu = trfForm.secilenTaraf;
                txtBtnBasvurucu.DataBindings.Clear();
                txtBtnBasvurucu.DataBindings.Add("Text", secilenBasvurucu, "TarafAdi", true, DataSourceUpdateMode.Never);
            }
        }

        VekilSecimForm vklForm;
        Vekil secilenVekil;
        private void txtBtnVekili_Click(object sender, EventArgs e)
        {
            vklForm = new VekilSecimForm();
            if (vklForm.ShowDialog() == DialogResult.OK)
            {
                secilenVekil = vklForm.secilenVekil;
                txtBtnVekili.DataBindings.Clear();
                txtBtnVekili.DataBindings.Add("Text", secilenVekil, "AdiSoyadi", true, DataSourceUpdateMode.Never);
            }
        }

        public void UpdateDava(Dava gelenDava)
        {
            gelenDava.Basvurucu = secilenBasvurucu;
            gelenDava.BasvurucuVekili = secilenVekil;
            gelenDava.CalisilanYer = txtCalisilanYer.Text;
            gelenDava.BasvurucuNot = txtNot.Text;
        }
    }
}