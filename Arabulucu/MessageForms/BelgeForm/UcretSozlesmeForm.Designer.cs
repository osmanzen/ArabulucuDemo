namespace Arabulucu.MessageForms.BelgeForm
{
    partial class UcretSozlesmeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlHesapSec = new DevExpress.XtraGrid.GridControl();
            this.gridViewHesapSec = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vekilColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BankaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubeAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vekilColumnAktif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnHeyetKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem39 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHesapSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHesapSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.layoutControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(392, 184);
            this.panelControl1.TabIndex = 1;
            // 
            // layoutControl3
            // 
            this.layoutControl3.AllowCustomization = false;
            this.layoutControl3.Controls.Add(this.gridControlHesapSec);
            this.layoutControl3.Controls.Add(this.btnHeyetKaydet);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1045, 207, 650, 400);
            this.layoutControl3.Root = this.layoutControlGroup7;
            this.layoutControl3.Size = new System.Drawing.Size(392, 184);
            this.layoutControl3.TabIndex = 7;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // gridControlHesapSec
            // 
            this.gridControlHesapSec.Location = new System.Drawing.Point(12, 12);
            this.gridControlHesapSec.LookAndFeel.SkinName = "The Bezier";
            this.gridControlHesapSec.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlHesapSec.MainView = this.gridViewHesapSec;
            this.gridControlHesapSec.Name = "gridControlHesapSec";
            this.gridControlHesapSec.Size = new System.Drawing.Size(368, 119);
            this.gridControlHesapSec.TabIndex = 12;
            this.gridControlHesapSec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHesapSec});
            // 
            // gridViewHesapSec
            // 
            this.gridViewHesapSec.ActiveFilterString = "[AktifMi] = \'true\'";
            this.gridViewHesapSec.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.gridViewHesapSec.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this.gridViewHesapSec.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewHesapSec.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewHesapSec.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewHesapSec.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewHesapSec.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewHesapSec.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.gridViewHesapSec.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewHesapSec.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewHesapSec.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewHesapSec.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewHesapSec.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewHesapSec.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridViewHesapSec.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.vekilColumnID,
            this.BankaAdi,
            this.SubeAdi,
            this.IBAN,
            this.vekilColumnAktif});
            this.gridViewHesapSec.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewHesapSec.GridControl = this.gridControlHesapSec;
            this.gridViewHesapSec.Name = "gridViewHesapSec";
            this.gridViewHesapSec.OptionsBehavior.Editable = false;
            this.gridViewHesapSec.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewHesapSec.OptionsCustomization.AllowFilter = false;
            this.gridViewHesapSec.OptionsCustomization.AllowGroup = false;
            this.gridViewHesapSec.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewHesapSec.OptionsDetail.SmartDetailHeight = true;
            this.gridViewHesapSec.OptionsFind.AllowFindPanel = false;
            this.gridViewHesapSec.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridViewHesapSec.OptionsFind.FindNullPrompt = "Metin Giriniz...";
            this.gridViewHesapSec.OptionsFind.ShowCloseButton = false;
            this.gridViewHesapSec.OptionsMenu.EnableColumnMenu = false;
            this.gridViewHesapSec.OptionsMenu.EnableFooterMenu = false;
            this.gridViewHesapSec.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewHesapSec.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewHesapSec.OptionsView.AllowGlyphSkinning = true;
            this.gridViewHesapSec.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewHesapSec.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridViewHesapSec.OptionsView.ShowDetailButtons = false;
            this.gridViewHesapSec.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewHesapSec.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridViewHesapSec.OptionsView.ShowGroupPanel = false;
            this.gridViewHesapSec.OptionsView.ShowIndicator = false;
            this.gridViewHesapSec.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // vekilColumnID
            // 
            this.vekilColumnID.Caption = "ID";
            this.vekilColumnID.FieldName = "ID";
            this.vekilColumnID.Name = "vekilColumnID";
            // 
            // BankaAdi
            // 
            this.BankaAdi.Caption = "Banka Adı";
            this.BankaAdi.FieldName = "BankaAdi";
            this.BankaAdi.Name = "BankaAdi";
            this.BankaAdi.Visible = true;
            this.BankaAdi.VisibleIndex = 0;
            // 
            // SubeAdi
            // 
            this.SubeAdi.Caption = "Şube Adı";
            this.SubeAdi.FieldName = "SubeAdi";
            this.SubeAdi.Name = "SubeAdi";
            this.SubeAdi.Visible = true;
            this.SubeAdi.VisibleIndex = 1;
            // 
            // IBAN
            // 
            this.IBAN.Caption = "IBAN";
            this.IBAN.FieldName = "IBAN";
            this.IBAN.Name = "IBAN";
            this.IBAN.Visible = true;
            this.IBAN.VisibleIndex = 2;
            // 
            // vekilColumnAktif
            // 
            this.vekilColumnAktif.Caption = "Aktif Mi";
            this.vekilColumnAktif.FieldName = "AktifMi";
            this.vekilColumnAktif.Name = "vekilColumnAktif";
            // 
            // btnHeyetKaydet
            // 
            this.btnHeyetKaydet.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnHeyetKaydet.Appearance.Options.UseForeColor = true;
            this.btnHeyetKaydet.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Control;
            this.btnHeyetKaydet.AppearanceDisabled.Options.UseBackColor = true;
            this.btnHeyetKaydet.AppearanceHovered.BackColor = System.Drawing.SystemColors.Control;
            this.btnHeyetKaydet.AppearanceHovered.Options.UseBackColor = true;
            this.btnHeyetKaydet.AppearancePressed.BackColor = System.Drawing.SystemColors.Control;
            this.btnHeyetKaydet.AppearancePressed.Options.UseBackColor = true;
            this.btnHeyetKaydet.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnHeyetKaydet.ImageOptions.Image = global::Arabulucu.Properties.Resources.apply_16x16;
            this.btnHeyetKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnHeyetKaydet.Location = new System.Drawing.Point(282, 135);
            this.btnHeyetKaydet.Name = "btnHeyetKaydet";
            this.btnHeyetKaydet.Size = new System.Drawing.Size(98, 37);
            this.btnHeyetKaydet.StyleController = this.layoutControl3;
            this.btnHeyetKaydet.TabIndex = 11;
            this.btnHeyetKaydet.Text = "Belgeyi Oluştur";
            this.btnHeyetKaydet.Click += new System.EventHandler(this.btnHeyetKaydet_Click);
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup7.GroupBordersVisible = false;
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem39,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup7.Name = "Root";
            this.layoutControlGroup7.Size = new System.Drawing.Size(392, 184);
            this.layoutControlGroup7.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlHesapSec;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(372, 123);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem39
            // 
            this.layoutControlItem39.Control = this.btnHeyetKaydet;
            this.layoutControlItem39.CustomizationFormText = "layoutControlItem11";
            this.layoutControlItem39.Location = new System.Drawing.Point(270, 123);
            this.layoutControlItem39.Name = "layoutControlItem39";
            this.layoutControlItem39.Size = new System.Drawing.Size(102, 41);
            this.layoutControlItem39.Text = "layoutControlItem11";
            this.layoutControlItem39.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem39.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 123);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(186, 41);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(186, 123);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(84, 41);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // UcretSozlesmeForm
            // 
            this.AcceptButton = this.btnHeyetKaydet;
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 184);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UcretSozlesmeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Belge Oluştur";
            this.Load += new System.EventHandler(this.UcretSozlesmeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHesapSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHesapSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.SimpleButton btnHeyetKaydet;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem39;
        private DevExpress.XtraGrid.GridControl gridControlHesapSec;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHesapSec;
        private DevExpress.XtraGrid.Columns.GridColumn vekilColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn BankaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn SubeAdi;
        private DevExpress.XtraGrid.Columns.GridColumn IBAN;
        private DevExpress.XtraGrid.Columns.GridColumn vekilColumnAktif;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}