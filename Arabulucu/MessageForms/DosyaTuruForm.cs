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

namespace Arabulucu.MessageForms
{
    public partial class DosyaTuruForm : DevExpress.XtraEditors.XtraForm
    {
        public DosyaTuruForm()
        {
            InitializeComponent();
            davaTuruDB = new Repository<DavaTuru>();
            davaTuruSource = new BindingSource();
            davaTuruSource.DataSource = davaTuruDB.List();

            gridControlDavaTur.DataSource = davaTuruSource;
        }

        Repository<DavaTuru> davaTuruDB;
        BindingSource davaTuruSource;

        public DavaTuru secilenTur;

        DavaTuru yeniTur;
        private void btnBasvuruTuruEkle_Click(object sender, EventArgs e)
        {
            if (txtBasvuruTuru.Text != "")
            {
                yeniTur = new DavaTuru() { TurAdi = txtBasvuruTuru.Text };
                davaTuruDB.Insert(yeniTur);
                davaTuruSource.Add(yeniTur);
            }
        }

        private void btnTurSil_Click(object sender, EventArgs e)
        {
            if (davaTuruSource.Count > 0)
            {
                List<DavaTuru> silinecekListe = new List<DavaTuru>();

                foreach (var item in gridViewDavaTur.GetSelectedRows())
                {
                    silinecekListe.Add((DavaTuru)gridViewDavaTur.GetRow(item));
                }

                foreach (var item in silinecekListe)
                {
                    davaTuruDB.Delete(item);
                    davaTuruSource.Remove(item);
                }
            }
        }

        private void gridViewDavaTur_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                secilenTur = (DavaTuru)gridViewDavaTur.GetRow(e.RowHandle);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            secilenTur =gridViewDavaTur.GetFocusedRow() as DavaTuru;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}