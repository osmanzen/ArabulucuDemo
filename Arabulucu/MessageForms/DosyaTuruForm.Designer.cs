namespace Arabulucu.MessageForms
{
    partial class DosyaTuruForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DosyaTuruForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlDavaTur = new DevExpress.XtraGrid.GridControl();
            this.gridViewDavaTur = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtBasvuruTuru = new DevExpress.XtraEditors.TextEdit();
            this.btnBasvuruTuruEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup12 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDavaTur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDavaTur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBasvuruTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(334, 257);
            this.panelControl1.TabIndex = 1;
            // 
            // layoutControl3
            // 
            this.layoutControl3.AllowCustomization = false;
            this.layoutControl3.Controls.Add(this.btnSil);
            this.layoutControl3.Controls.Add(this.gridControlDavaTur);
            this.layoutControl3.Controls.Add(this.txtBasvuruTuru);
            this.layoutControl3.Controls.Add(this.btnBasvuruTuruEkle);
            this.layoutControl3.Controls.Add(this.btnSec);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1045, 207, 650, 400);
            this.layoutControl3.Root = this.layoutControlGroup7;
            this.layoutControl3.Size = new System.Drawing.Size(334, 257);
            this.layoutControl3.TabIndex = 7;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // gridControlDavaTur
            // 
            this.gridControlDavaTur.Location = new System.Drawing.Point(12, 38);
            this.gridControlDavaTur.MainView = this.gridViewDavaTur;
            this.gridControlDavaTur.Name = "gridControlDavaTur";
            this.gridControlDavaTur.Size = new System.Drawing.Size(310, 181);
            this.gridControlDavaTur.TabIndex = 16;
            this.gridControlDavaTur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDavaTur});
            // 
            // gridViewDavaTur
            // 
            this.gridViewDavaTur.ActiveFilterString = "[AktifMi] = \'true\'";
            this.gridViewDavaTur.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.gridViewDavaTur.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this.gridViewDavaTur.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewDavaTur.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewDavaTur.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewDavaTur.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewDavaTur.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewDavaTur.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.gridViewDavaTur.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewDavaTur.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewDavaTur.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewDavaTur.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewDavaTur.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewDavaTur.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridViewDavaTur.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13,
            this.colTurAdi,
            this.gridColumn19});
            this.gridViewDavaTur.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewDavaTur.GridControl = this.gridControlDavaTur;
            this.gridViewDavaTur.Name = "gridViewDavaTur";
            this.gridViewDavaTur.OptionsBehavior.Editable = false;
            this.gridViewDavaTur.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewDavaTur.OptionsCustomization.AllowFilter = false;
            this.gridViewDavaTur.OptionsCustomization.AllowGroup = false;
            this.gridViewDavaTur.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewDavaTur.OptionsDetail.SmartDetailHeight = true;
            this.gridViewDavaTur.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridViewDavaTur.OptionsFind.FindNullPrompt = "Metin Giriniz...";
            this.gridViewDavaTur.OptionsFind.ShowCloseButton = false;
            this.gridViewDavaTur.OptionsMenu.EnableColumnMenu = false;
            this.gridViewDavaTur.OptionsMenu.EnableFooterMenu = false;
            this.gridViewDavaTur.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewDavaTur.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewDavaTur.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewDavaTur.OptionsView.AllowGlyphSkinning = true;
            this.gridViewDavaTur.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridViewDavaTur.OptionsView.ShowDetailButtons = false;
            this.gridViewDavaTur.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewDavaTur.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridViewDavaTur.OptionsView.ShowGroupPanel = false;
            this.gridViewDavaTur.OptionsView.ShowIndicator = false;
            this.gridViewDavaTur.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewDavaTur.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTurAdi, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewDavaTur.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewDavaTur_RowClick);
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "ID";
            this.gridColumn13.FieldName = "ID";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // colTurAdi
            // 
            this.colTurAdi.Caption = "Tür Adı";
            this.colTurAdi.FieldName = "TurAdi";
            this.colTurAdi.Name = "colTurAdi";
            this.colTurAdi.Visible = true;
            this.colTurAdi.VisibleIndex = 0;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Aktif Mi";
            this.gridColumn19.FieldName = "AktifMi";
            this.gridColumn19.Name = "gridColumn19";
            // 
            // txtBasvuruTuru
            // 
            this.txtBasvuruTuru.Location = new System.Drawing.Point(77, 12);
            this.txtBasvuruTuru.Name = "txtBasvuruTuru";
            this.txtBasvuruTuru.Size = new System.Drawing.Size(192, 20);
            this.txtBasvuruTuru.StyleController = this.layoutControl3;
            this.txtBasvuruTuru.TabIndex = 4;
            // 
            // btnBasvuruTuruEkle
            // 
            this.btnBasvuruTuruEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasvuruTuruEkle.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btnBasvuruTuruEkle.Appearance.Options.UseFont = true;
            this.btnBasvuruTuruEkle.Appearance.Options.UseForeColor = true;
            this.btnBasvuruTuruEkle.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnBasvuruTuruEkle.ImageOptions.Image = global::Arabulucu.Properties.Resources.add_16x16;
            this.btnBasvuruTuruEkle.Location = new System.Drawing.Point(273, 12);
            this.btnBasvuruTuruEkle.Name = "btnBasvuruTuruEkle";
            this.btnBasvuruTuruEkle.Size = new System.Drawing.Size(49, 22);
            this.btnBasvuruTuruEkle.StyleController = this.layoutControl3;
            this.btnBasvuruTuruEkle.TabIndex = 17;
            this.btnBasvuruTuruEkle.Text = "Ekle";
            this.btnBasvuruTuruEkle.Click += new System.EventHandler(this.btnBasvuruTuruEkle_Click);
            // 
            // btnSec
            // 
            this.btnSec.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSec.Appearance.Options.UseFont = true;
            this.btnSec.Appearance.Options.UseForeColor = true;
            this.btnSec.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnSec.ImageOptions.Image = global::Arabulucu.Properties.Resources.apply_16x16;
            this.btnSec.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSec.Location = new System.Drawing.Point(169, 223);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(153, 22);
            this.btnSec.StyleController = this.layoutControl3;
            this.btnSec.TabIndex = 18;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup7.GroupBordersVisible = false;
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup12,
            this.layoutControlItem5,
            this.layoutControlItem4});
            this.layoutControlGroup7.Name = "Root";
            this.layoutControlGroup7.Size = new System.Drawing.Size(334, 257);
            this.layoutControlGroup7.TextVisible = false;
            // 
            // layoutControlGroup12
            // 
            this.layoutControlGroup12.CustomizationFormText = "Root";
            this.layoutControlGroup12.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup12.GroupBordersVisible = false;
            this.layoutControlGroup12.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup12.Name = "layoutControlGroup12";
            this.layoutControlGroup12.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup12.Size = new System.Drawing.Size(314, 211);
            this.layoutControlGroup12.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup12.Text = "Root";
            this.layoutControlGroup12.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtBasvuruTuru;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(261, 26);
            this.layoutControlItem1.Text = "Dosya Türü :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlDavaTur;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(314, 185);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnBasvuruTuruEkle;
            this.layoutControlItem3.Location = new System.Drawing.Point(261, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(53, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSec;
            this.layoutControlItem4.Location = new System.Drawing.Point(157, 211);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(157, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Appearance.Options.UseForeColor = true;
            this.btnSil.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnSil.ImageOptions.Image = global::Arabulucu.Properties.Resources.cancel_16x16;
            this.btnSil.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSil.Location = new System.Drawing.Point(12, 223);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(153, 22);
            this.btnSil.StyleController = this.layoutControl3;
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnTurSil_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnSil;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 211);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(157, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // DosyaTuruForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 257);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DosyaTuruForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dosya Türü";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDavaTur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDavaTur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBasvuruTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup12;
        private DevExpress.XtraEditors.TextEdit txtBasvuruTuru;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControlDavaTur;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDavaTur;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn colTurAdi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraEditors.SimpleButton btnBasvuruTuruEkle;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}