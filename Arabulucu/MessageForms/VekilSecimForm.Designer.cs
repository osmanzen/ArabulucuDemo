namespace Arabulucu.MessageForms
{
    partial class VekilSecimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VekilSecimForm));
            this.gridControlVekilSec = new DevExpress.XtraGrid.GridControl();
            this.gridViewVekilSec = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vekilColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vekilColumnSicilNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vekilColumnAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vekilColumnBuroIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vekilColumnBuroIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vekilColumnAktif = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVekilSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVekilSec)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlVekilSec
            // 
            this.gridControlVekilSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlVekilSec.Location = new System.Drawing.Point(0, 0);
            this.gridControlVekilSec.LookAndFeel.SkinName = "The Bezier";
            this.gridControlVekilSec.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlVekilSec.MainView = this.gridViewVekilSec;
            this.gridControlVekilSec.Name = "gridControlVekilSec";
            this.gridControlVekilSec.Size = new System.Drawing.Size(381, 316);
            this.gridControlVekilSec.TabIndex = 5;
            this.gridControlVekilSec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVekilSec});
            // 
            // gridViewVekilSec
            // 
            this.gridViewVekilSec.ActiveFilterString = "[KisiSirketKurum] = \'0\' And [AktifMi] = \'true\'";
            this.gridViewVekilSec.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.gridViewVekilSec.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this.gridViewVekilSec.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewVekilSec.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewVekilSec.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewVekilSec.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewVekilSec.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewVekilSec.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.gridViewVekilSec.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewVekilSec.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewVekilSec.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewVekilSec.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewVekilSec.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewVekilSec.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridViewVekilSec.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.vekilColumnID,
            this.vekilColumnSicilNo,
            this.vekilColumnAdiSoyadi,
            this.vekilColumnBuroIl,
            this.vekilColumnBuroIlce,
            this.vekilColumnAktif});
            this.gridViewVekilSec.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewVekilSec.GridControl = this.gridControlVekilSec;
            this.gridViewVekilSec.Name = "gridViewVekilSec";
            this.gridViewVekilSec.OptionsBehavior.Editable = false;
            this.gridViewVekilSec.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewVekilSec.OptionsCustomization.AllowFilter = false;
            this.gridViewVekilSec.OptionsCustomization.AllowGroup = false;
            this.gridViewVekilSec.OptionsCustomization.AllowMergedGrouping = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewVekilSec.OptionsDetail.SmartDetailHeight = true;
            this.gridViewVekilSec.OptionsFind.AlwaysVisible = true;
            this.gridViewVekilSec.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridViewVekilSec.OptionsFind.FindNullPrompt = "Metin Giriniz...";
            this.gridViewVekilSec.OptionsFind.ShowCloseButton = false;
            this.gridViewVekilSec.OptionsMenu.EnableColumnMenu = false;
            this.gridViewVekilSec.OptionsMenu.EnableFooterMenu = false;
            this.gridViewVekilSec.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewVekilSec.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewVekilSec.OptionsView.AllowGlyphSkinning = true;
            this.gridViewVekilSec.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewVekilSec.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridViewVekilSec.OptionsView.ShowDetailButtons = false;
            this.gridViewVekilSec.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewVekilSec.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridViewVekilSec.OptionsView.ShowGroupPanel = false;
            this.gridViewVekilSec.OptionsView.ShowIndicator = false;
            this.gridViewVekilSec.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewVekilSec.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewVekilSec_RowClick);
            // 
            // vekilColumnID
            // 
            this.vekilColumnID.Caption = "ID";
            this.vekilColumnID.FieldName = "ID";
            this.vekilColumnID.Name = "vekilColumnID";
            // 
            // vekilColumnSicilNo
            // 
            this.vekilColumnSicilNo.Caption = "Sicil No.";
            this.vekilColumnSicilNo.FieldName = "SicilNo";
            this.vekilColumnSicilNo.Name = "vekilColumnSicilNo";
            this.vekilColumnSicilNo.Visible = true;
            this.vekilColumnSicilNo.VisibleIndex = 0;
            // 
            // vekilColumnAdiSoyadi
            // 
            this.vekilColumnAdiSoyadi.Caption = "Adı Soyadı";
            this.vekilColumnAdiSoyadi.FieldName = "AdiSoyadi";
            this.vekilColumnAdiSoyadi.Name = "vekilColumnAdiSoyadi";
            this.vekilColumnAdiSoyadi.Visible = true;
            this.vekilColumnAdiSoyadi.VisibleIndex = 1;
            // 
            // vekilColumnBuroIl
            // 
            this.vekilColumnBuroIl.Caption = "Büro İl";
            this.vekilColumnBuroIl.FieldName = "BuroIl";
            this.vekilColumnBuroIl.Name = "vekilColumnBuroIl";
            this.vekilColumnBuroIl.Visible = true;
            this.vekilColumnBuroIl.VisibleIndex = 3;
            // 
            // vekilColumnBuroIlce
            // 
            this.vekilColumnBuroIlce.Caption = "Büro İlçe";
            this.vekilColumnBuroIlce.FieldName = "BuroIlce";
            this.vekilColumnBuroIlce.Name = "vekilColumnBuroIlce";
            this.vekilColumnBuroIlce.Visible = true;
            this.vekilColumnBuroIlce.VisibleIndex = 2;
            // 
            // vekilColumnAktif
            // 
            this.vekilColumnAktif.Caption = "Aktif Mi";
            this.vekilColumnAktif.FieldName = "AktifMi";
            this.vekilColumnAktif.Name = "vekilColumnAktif";
            // 
            // VekilSecimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 316);
            this.Controls.Add(this.gridControlVekilSec);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VekilSecimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vekil Seçimi";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVekilSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVekilSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlVekilSec;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVekilSec;
        private DevExpress.XtraGrid.Columns.GridColumn vekilColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn vekilColumnSicilNo;
        private DevExpress.XtraGrid.Columns.GridColumn vekilColumnAdiSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn vekilColumnBuroIl;
        private DevExpress.XtraGrid.Columns.GridColumn vekilColumnAktif;
        private DevExpress.XtraGrid.Columns.GridColumn vekilColumnBuroIlce;
    }
}