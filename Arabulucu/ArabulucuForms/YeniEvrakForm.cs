using Arabulucu.ArabulucuHelpers;
using Arabulucu.MessageForms;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZenSoftDAL.EntityFramework;
using ZenSoftModel.DTO;
using ZenSoftModel.Entities;

namespace Arabulucu.ArabulucuForms
{
    public partial class YeniEvrakForm : DevExpress.XtraEditors.XtraForm
    {
        public YeniEvrakForm(Dava _secilenDava, int locX, int locY)
        {
            InitializeComponent();

            layoutControl1.Location = (new System.Drawing.Point(locX, locY));

            davaDAL = new Repository<Dava>();
            tarafDAL = new Repository<Taraf>();
            vekilDAL = new Repository<Vekil>();

            secilenDava = _secilenDava;
        }

        Repository<Dava> davaDAL;
        Repository<Taraf> tarafDAL;
        Repository<Vekil> vekilDAL;

        Dava secilenDava;

        List<Taraf> karsiTarafListesi;

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnDosyaKapak_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnToplantiyaDavet_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (ToplantıDavetForm frm = new ToplantıDavetForm(secilenDava))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);

                    karsiTarafListesi = new List<Taraf>();
                    foreach (var item in frm.gorusmeVerisi.karsiTarafCheckedListBoxItems)
                    {
                        karsiTarafListesi.Add(tarafDAL.Find(x => x.ID == item.tarafID));
                    }

                    if (!frm.vekilMi)
                    {
                        BelgeOlusturucu.ToplantiyaDavetMektubu(secilenDava, karsiTarafListesi, tarafDAL.Find(x => x.ID == frm.davetEdilenID));
                    }
                    else
                    {
                        BelgeOlusturucu.ToplantiyaDavetMektubu(secilenDava, karsiTarafListesi, vekilDAL.Find(x => x.ID == frm.davetEdilenID));
                    }
                    SplashScreenManager.CloseForm();

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void btnArabuluculukUcret_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnToplantiTutanagi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnToplantiErteleme_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAnlasmaTutanagi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAnlasamamaTutanagi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSonTutanak_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnBassavciSon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        //ESC FORM KAPAT
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void YeniEvrakForm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}