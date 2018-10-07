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
    public partial class DosyaKonulariForm : DevExpress.XtraEditors.XtraForm
    {
        public DosyaKonulariForm(DavaTuru gelenTur)
        {
            InitializeComponent();

            davaKonuDB = new Repository<DavaKonusu>();
            konuSource = new BindingSource();

            davaTuru = gelenTur;

            konuSource.DataSource = davaKonuDB.List(x => x.DavaTuruID == davaTuru.ID && x.AktifMi);

            gridControlDavaKonu.DataSource = konuSource;
        }

        Repository<DavaKonusu> davaKonuDB;
        BindingSource konuSource;

        DavaKonusu yeniKonu;
        DavaTuru davaTuru;

        public List<DavaKonusu> secilenKonuList;

        private void btnBasvuruKonusuEkle_Click(object sender, EventArgs e)
        {
            yeniKonu = new DavaKonusu() { DavaTuruID = davaTuru.ID, KonuAdi = txtBasvuruKonu.Text };

            davaKonuDB.Insert(yeniKonu);
            konuSource.Add(yeniKonu);
        }

        private void btnKonuSil_Click(object sender, EventArgs e)
        {
            if (konuSource.Count > 0)
            {
                List<DavaKonusu> silinecekListe = new List<DavaKonusu>();

                foreach (var item in gridViewDavaKonu.GetSelectedRows())
                {
                    silinecekListe.Add((DavaKonusu)gridViewDavaKonu.GetRow(item));
                }

                foreach (var item in silinecekListe)
                {
                    konuSource.Remove(item);
                    davaKonuDB.HardDelete(item);
                }
            }
        }

        private void btnKonuSec_Click(object sender, EventArgs e)
        {
            if (konuSource.Count > 0)
            {
                secilenKonuList = new List<DavaKonusu>();

                foreach (var item in gridViewDavaKonu.GetSelectedRows())
                {
                    secilenKonuList.Add((DavaKonusu)gridViewDavaKonu.GetRow(item));
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}