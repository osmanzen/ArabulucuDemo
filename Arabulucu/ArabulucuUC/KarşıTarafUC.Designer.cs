namespace Arabulucu.ArabulucuUC
{
    partial class KarşıTarafUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KarşıTarafUC));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit8 = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.textEdit6);
            this.layoutControl1.Controls.Add(this.textEdit7);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.textEdit8);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.LookAndFeel.SkinName = "The Asphalt World";
            this.layoutControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(937, 357, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(404, 250);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(125, 44);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.ReadOnly = true;
            this.textEdit6.Size = new System.Drawing.Size(215, 20);
            this.textEdit6.StyleController = this.layoutControl1;
            this.textEdit6.TabIndex = 10;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(125, 68);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.ReadOnly = true;
            this.textEdit7.Size = new System.Drawing.Size(215, 20);
            this.textEdit7.StyleController = this.layoutControl1;
            this.textEdit7.TabIndex = 11;
            // 
            // textEdit8
            // 
            this.textEdit8.Location = new System.Drawing.Point(24, 112);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Size = new System.Drawing.Size(356, 114);
            this.textEdit8.StyleController = this.layoutControl1;
            this.textEdit8.TabIndex = 14;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(404, 250);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.layoutControlItem8,
            this.layoutControlItem10,
            this.layoutControlItem11});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(384, 230);
            this.layoutControlGroup4.Text = "Karşı Taraf";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textEdit6;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(320, 24);
            this.layoutControlItem7.Text = "Taraf :";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(98, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.textEdit7;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(320, 28);
            this.layoutControlItem8.Text = "Taraf Vekili :";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(98, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.textEdit8;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(360, 134);
            this.layoutControlItem11.Text = "Başvurucu Talepler :";
            this.layoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(98, 13);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(344, 70);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(36, 22);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 13;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(344, 44);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(36, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 12;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.simpleButton1;
            this.layoutControlItem9.Location = new System.Drawing.Point(320, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(40, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.simpleButton2;
            this.layoutControlItem10.Location = new System.Drawing.Point(320, 26);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(40, 26);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // KarşıTarafUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "KarşıTarafUC";
            this.Size = new System.Drawing.Size(404, 250);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.MemoEdit textEdit8;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
    }
}
