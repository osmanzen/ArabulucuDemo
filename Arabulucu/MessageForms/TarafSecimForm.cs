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
using ZenSoftDAL.EntityFramework;
using ZenSoftModel.DTO;

namespace Arabulucu.MessageForms
{
    public partial class TarafSecimForm : DevExpress.XtraEditors.XtraForm
    {
        public TarafSecimForm(int aktifTab=3)
        {
            InitializeComponent();

            if (aktifTab == 0)
            {
                tabPageKisi.PageVisible = true;
                tabPageSirket.PageVisible = false;
                tabPageKurum.PageVisible = false;
            }
            else if(aktifTab==1)
            {
                tabPageKisi.PageVisible = false;
                tabPageSirket.PageVisible = true;
                tabPageKurum.PageVisible = false;
            }
            else if(aktifTab==2)
            {
                tabPageKisi.PageVisible = false;
                tabPageSirket.PageVisible = false;
                tabPageKurum.PageVisible = true;
            }
            else if (aktifTab == 3)
            {
                tabPageKisi.PageVisible = true;
                tabPageSirket.PageVisible = true;
                tabPageKurum.PageVisible = true;
            }

            tarafDB = new Repository<Taraf>();

            tarafSource = new BindingSource();
            tarafSource.DataSource = tarafDB.List();

            gridControlKisi.DataSource = tarafSource;
            gridControlSirket.DataSource = tarafSource;
            gridControlKurum.DataSource = tarafSource;
        }

        Repository<Taraf> tarafDB;
        BindingSource tarafSource;

        public Taraf secilenTaraf;

        private void gridViewKisi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                secilenTaraf = (Taraf)gridViewKisi.GetRow(e.RowHandle);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void gridViewSirket_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                secilenTaraf = (Taraf)gridViewSirket.GetRow(e.RowHandle);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void gridViewKurum_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                secilenTaraf = (Taraf)gridViewKurum.GetRow(e.RowHandle);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}