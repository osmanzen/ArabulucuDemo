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
    public partial class KarsiTarafKurumUC : UserControl
    {
        public KarsiTarafKurumUC()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            tabbedControlGroup1.SelectedTabPageIndex = 0;


            heyetleriSource = new List<Heyet>();
            gridControlKurumHeyet.DataSource = heyetleriSource;

            ilgiliKurumlarSource = new List<Taraf>();
            gridControlIlgiliKurum.DataSource = ilgiliKurumlarSource;

            ArabulucuHelper.ButtonImageSearchIcon(txtTaraf);
            ArabulucuHelper.ButtonImageSearchIcon(txtVekili);
        }

        KarsiTaraf taraf;

        List<Heyet> heyetleriSource;
        List<Taraf> ilgiliKurumlarSource;

        private void layoutControlGroup2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            this.Dispose();
        }

        public void FillTaraf(KarsiTaraf gelenTaraf)
        {
            taraf = gelenTaraf;
            secilenTaraf = gelenTaraf.Taraf;
            secilenVekil = gelenTaraf.Vekil;
            txtTaraf.DataBindings.Clear();
            txtVekili.DataBindings.Clear();
            txtNotlar.DataBindings.Clear();

            txtTaraf.DataBindings.Add("Text", taraf.Taraf, "TarafAdi", true, DataSourceUpdateMode.Never);
            if (gelenTaraf.Vekil != null)
            {
                txtVekili.DataBindings.Add("Text", taraf.Vekil, "AdiSoyadi", true, DataSourceUpdateMode.Never);
            }
            txtNotlar.DataBindings.Add("Text", taraf, "KarsiTarafNot", true, DataSourceUpdateMode.Never);

            foreach (Heyet heyet in gelenTaraf.Heyetleri)
            {
                heyetleriSource.Add(heyet);
            }
            gridControlKurumHeyet.RefreshDataSource();

            foreach (Taraf ilgiliKurum in gelenTaraf.IlgiliKurumlari.Where(x => x.AktifMi))
            {
                ilgiliKurumlarSource.Add(ilgiliKurum);
            }
            gridControlIlgiliKurum.RefreshDataSource();
        }

        Taraf secilenTaraf;
        public void TarafSecici(Taraf gelenTaraf)
        {
            secilenTaraf = gelenTaraf;
            txtTaraf.DataBindings.Add("Text", secilenTaraf, "TarafAdi", true, DataSourceUpdateMode.Never);
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

        TarafSecimForm trfForm;
        private void txtTaraf_Click(object sender, EventArgs e)
        {
            trfForm = new TarafSecimForm(2);
            if (trfForm.ShowDialog() == DialogResult.OK)
            {
                secilenTaraf = trfForm.secilenTaraf;
                txtTaraf.DataBindings.Clear();
                txtTaraf.DataBindings.Add("Text", secilenTaraf, "TarafAdi", true, DataSourceUpdateMode.Never);
            }
        }

        HeyetEkleForm hytForm;
        private void btnHeyetEkle_Click(object sender, EventArgs e)
        {
            hytForm = new HeyetEkleForm();
            if (hytForm.ShowDialog() == DialogResult.OK)
            {
                heyetleriSource.Add(hytForm.yeniHeyet);
                gridControlKurumHeyet.RefreshDataSource();
            }
        }

        private void btnHeyetSil_Click(object sender, EventArgs e)
        {
            if (heyetleriSource.Count > 0)
            {
                List<Heyet> silinecekListe = new List<Heyet>();

                foreach (var item in gridViewHeyetleri.GetSelectedRows())
                {
                    silinecekListe.Add((Heyet)gridViewHeyetleri.GetRow(item));
                }

                foreach (var item in silinecekListe)
                {
                    heyetleriSource.Remove(item);
                    gridControlKurumHeyet.RefreshDataSource();
                }
            }
        }

        private void btnIlgiliEkle_Click(object sender, EventArgs e)
        {
            trfForm = new TarafSecimForm(2);
            if (trfForm.ShowDialog() == DialogResult.OK)
            {
                ilgiliKurumlarSource.Add(trfForm.secilenTaraf);
                gridControlIlgiliKurum.RefreshDataSource();
            }
        }

        private void btnIlgiliSil_Click(object sender, EventArgs e)
        {
            if (ilgiliKurumlarSource.Count > 0)
            {
                List<Taraf> silinecekListe = new List<Taraf>();

                foreach (var item in gridViewIlgiliKurum.GetSelectedRows())
                {
                    silinecekListe.Add((Taraf)gridViewIlgiliKurum.GetRow(item));
                }

                foreach (var item in silinecekListe)
                {
                    ilgiliKurumlarSource.Remove(item);
                    gridControlIlgiliKurum.RefreshDataSource();
                }
            }
        }

        KarsiTaraf yeniKarsiTaraf;
        public void UpdateKarsiTaraf(Dava gelenDava)
        {
            if (gelenDava.KarsiTaraflar == null)
                gelenDava.KarsiTaraflar = new HashSet<KarsiTaraf>();

            yeniKarsiTaraf = new KarsiTaraf()
            {
                DavaID = gelenDava.ID,
                KarsiTarafNot = txtNotlar.Text,
                TarafID = secilenTaraf.ID
            };

            if (secilenVekil != null)
            {
                yeniKarsiTaraf.VekilID = secilenVekil.ID;
            }

            yeniKarsiTaraf.Heyetleri = new HashSet<Heyet>();
            foreach (Heyet item in heyetleriSource)
            {
                yeniKarsiTaraf.Heyetleri.Add(item);
            }

            yeniKarsiTaraf.IlgiliKurumlari = new HashSet<Taraf>();
            foreach (Taraf item in ilgiliKurumlarSource)
            {
                yeniKarsiTaraf.IlgiliKurumlari.Add(item);
            }

            gelenDava.KarsiTaraflar.Add(yeniKarsiTaraf);
        }
    }
}
