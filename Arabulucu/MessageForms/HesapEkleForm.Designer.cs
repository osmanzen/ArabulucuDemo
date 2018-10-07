using System;

namespace Arabulucu.MessageForms
{
    partial class HesapEkleForm
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
            this.txtSubeAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtBankaAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtIBAN = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup12 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup13 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnBuroKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem39 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubeAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(372, 182);
            this.panelControl1.TabIndex = 1;
            // 
            // layoutControl3
            // 
            this.layoutControl3.AllowCustomization = false;
            this.layoutControl3.Controls.Add(this.txtSubeAdi);
            this.layoutControl3.Controls.Add(this.btnBuroKaydet);
            this.layoutControl3.Controls.Add(this.txtBankaAdi);
            this.layoutControl3.Controls.Add(this.txtIBAN);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1045, 207, 650, 400);
            this.layoutControl3.Root = this.layoutControlGroup7;
            this.layoutControl3.Size = new System.Drawing.Size(372, 182);
            this.layoutControl3.TabIndex = 7;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // txtSubeAdi
            // 
            this.txtSubeAdi.Location = new System.Drawing.Point(81, 73);
            this.txtSubeAdi.Name = "txtSubeAdi";
            this.txtSubeAdi.Size = new System.Drawing.Size(267, 20);
            this.txtSubeAdi.StyleController = this.layoutControl3;
            this.txtSubeAdi.TabIndex = 1;
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.Location = new System.Drawing.Point(81, 49);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Size = new System.Drawing.Size(267, 20);
            this.txtBankaAdi.StyleController = this.layoutControl3;
            this.txtBankaAdi.TabIndex = 14;
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(81, 97);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(267, 20);
            this.txtIBAN.StyleController = this.layoutControl3;
            this.txtIBAN.TabIndex = 15;
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup7.GroupBordersVisible = false;
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup12});
            this.layoutControlGroup7.Name = "Root";
            this.layoutControlGroup7.Size = new System.Drawing.Size(372, 182);
            this.layoutControlGroup7.TextVisible = false;
            // 
            // layoutControlGroup12
            // 
            this.layoutControlGroup12.CustomizationFormText = "Root";
            this.layoutControlGroup12.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup12.GroupBordersVisible = false;
            this.layoutControlGroup12.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup13,
            this.emptySpaceItem1,
            this.layoutControlItem39,
            this.emptySpaceItem2});
            this.layoutControlGroup12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup12.Name = "layoutControlGroup12";
            this.layoutControlGroup12.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup12.Size = new System.Drawing.Size(352, 162);
            this.layoutControlGroup12.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup12.Text = "Root";
            this.layoutControlGroup12.TextVisible = false;
            // 
            // layoutControlGroup13
            // 
            this.layoutControlGroup13.CustomizationFormText = "Kişisel Bilgiler";
            this.layoutControlGroup13.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem27,
            this.layoutControlItem3});
            this.layoutControlGroup13.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup13.Name = "layoutControlGroup13";
            this.layoutControlGroup13.Size = new System.Drawing.Size(352, 121);
            this.layoutControlGroup13.Text = "Hesap Bilgileri";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtBankaAdi;
            this.layoutControlItem2.CustomizationFormText = "Banka Adı :";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(328, 24);
            this.layoutControlItem2.Text = "Banka Adı :";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.Control = this.txtSubeAdi;
            this.layoutControlItem27.CustomizationFormText = "Tc Kimlik Numarası :";
            this.layoutControlItem27.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem27.Name = "layoutControlItem27";
            this.layoutControlItem27.Size = new System.Drawing.Size(328, 24);
            this.layoutControlItem27.Text = "Şube Adı :";
            this.layoutControlItem27.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtIBAN;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(328, 24);
            this.layoutControlItem3.Text = "IBAN :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(54, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 121);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(117, 41);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(117, 121);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(118, 41);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnBuroKaydet
            // 
            this.btnBuroKaydet.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBuroKaydet.Appearance.Options.UseForeColor = true;
            this.btnBuroKaydet.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnBuroKaydet.ImageOptions.Image = global::Arabulucu.Properties.Resources.add_16x16;
            this.btnBuroKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBuroKaydet.Location = new System.Drawing.Point(247, 133);
            this.btnBuroKaydet.Name = "btnBuroKaydet";
            this.btnBuroKaydet.Size = new System.Drawing.Size(113, 37);
            this.btnBuroKaydet.StyleController = this.layoutControl3;
            this.btnBuroKaydet.TabIndex = 11;
            this.btnBuroKaydet.Text = "Hesap Ekle";
            this.btnBuroKaydet.Click += new System.EventHandler(this.btnBuroKaydet_Click);
            // 
            // layoutControlItem39
            // 
            this.layoutControlItem39.Control = this.btnBuroKaydet;
            this.layoutControlItem39.CustomizationFormText = "layoutControlItem11";
            this.layoutControlItem39.Location = new System.Drawing.Point(235, 121);
            this.layoutControlItem39.Name = "layoutControlItem39";
            this.layoutControlItem39.Size = new System.Drawing.Size(117, 41);
            this.layoutControlItem39.Text = "layoutControlItem11";
            this.layoutControlItem39.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem39.TextVisible = false;
            // 
            // HesapEkleForm
            // 
            this.AcceptButton = this.btnBuroKaydet;
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 182);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HesapEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taraflar";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSubeAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.TextEdit txtSubeAdi;
        private DevExpress.XtraEditors.SimpleButton btnBuroKaydet;
        private DevExpress.XtraEditors.TextEdit txtBankaAdi;
        private DevExpress.XtraEditors.TextEdit txtIBAN;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup12;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem27;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem39;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}