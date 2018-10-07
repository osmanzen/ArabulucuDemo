namespace Arabulucu.ArabulucuUC
{
    partial class KarsiTarafUC
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtNotlar = new DevExpress.XtraEditors.MemoEdit();
            this.txtTaraf = new DevExpress.XtraEditors.ButtonEdit();
            this.txtVekili = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotlar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaraf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVekili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtNotlar);
            this.layoutControl1.Controls.Add(this.txtTaraf);
            this.layoutControl1.Controls.Add(this.txtVekili);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.LookAndFeel.SkinName = "The Bezier";
            this.layoutControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(319, 192, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(400, 200);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(14, 103);
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(372, 83);
            this.txtNotlar.StyleController = this.layoutControl1;
            this.txtNotlar.TabIndex = 9;
            // 
            // txtTaraf
            // 
            this.txtTaraf.Location = new System.Drawing.Point(102, 39);
            this.txtTaraf.Name = "txtTaraf";
            this.txtTaraf.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtTaraf.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtTaraf.Size = new System.Drawing.Size(284, 20);
            this.txtTaraf.StyleController = this.layoutControl1;
            this.txtTaraf.TabIndex = 4;
            this.txtTaraf.Click += new System.EventHandler(this.txtTaraf_Click);
            // 
            // txtVekili
            // 
            this.txtVekili.Location = new System.Drawing.Point(102, 63);
            this.txtVekili.Name = "txtVekili";
            this.txtVekili.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtVekili.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtVekili.Size = new System.Drawing.Size(284, 20);
            this.txtVekili.StyleController = this.layoutControl1;
            this.txtVekili.TabIndex = 5;
            this.txtVekili.Click += new System.EventHandler(this.txtVekili_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(400, 200);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.layoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.AppearanceGroup.Options.UseForeColor = true;
            buttonImageOptions1.SvgImage = global::Arabulucu.Properties.Resources.close3;
            buttonImageOptions1.SvgImageSize = new System.Drawing.Size(16, 16);
            this.layoutControlGroup2.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", false, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.layoutControlGroup2.CustomizationFormText = "Başvurucu Bilgileri";
            this.layoutControlGroup2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(400, 200);
            this.layoutControlGroup2.Text = "Karşı Taraf Bilgileri";
            this.layoutControlGroup2.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.layoutControlGroup2_CustomButtonClick);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTaraf;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem1.Text = "Karşı Taraf :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtVekili;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem2.Text = "Karşı Taraf Vekili :";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtNotlar;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(376, 103);
            this.layoutControlItem6.Text = "Notlar :";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(85, 13);
            // 
            // KarsiTarafUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "KarsiTarafUC";
            this.Size = new System.Drawing.Size(400, 200);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNotlar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaraf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVekili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit txtNotlar;
        private DevExpress.XtraEditors.ButtonEdit txtTaraf;
        private DevExpress.XtraEditors.ButtonEdit txtVekili;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
