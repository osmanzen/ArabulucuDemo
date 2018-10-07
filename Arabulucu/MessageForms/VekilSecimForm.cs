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
using ZenSoftDAL.EntityFramework;
using ZenSoftModel.Entities;

namespace Arabulucu.MessageForms
{
    public partial class VekilSecimForm : DevExpress.XtraEditors.XtraForm
    {
        public VekilSecimForm()
        {
            InitializeComponent();

            vekilDB = new Repository<Vekil>();

            gridControlVekilSec.DataSource = vekilDB.List(x=>x.AktifMi);
        }
        Repository<Vekil> vekilDB;
        public Vekil secilenVekil;

        private void gridViewVekilSec_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                secilenVekil = (Vekil)gridViewVekilSec.GetRow(e.RowHandle);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}