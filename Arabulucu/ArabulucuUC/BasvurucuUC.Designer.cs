namespace Arabulucu.ArabulucuUC
{
    partial class BasvurucuUC
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtCalisilanYer = new DevExpress.XtraEditors.TextEdit();
            this.txtNot = new DevExpress.XtraEditors.MemoEdit();
            this.txtBtnBasvurucu = new DevExpress.XtraEditors.ButtonEdit();
            this.txtBtnVekili = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalisilanYer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnBasvurucu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnVekili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtCalisilanYer);
            this.layoutControl1.Controls.Add(this.txtNot);
            this.layoutControl1.Controls.Add(this.txtBtnBasvurucu);
            this.layoutControl1.Controls.Add(this.txtBtnVekili);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.LookAndFeel.SkinName = "The Bezier";
            this.layoutControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(205, 218, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(400, 220);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtCalisilanYer
            // 
            this.txtCalisilanYer.Location = new System.Drawing.Point(103, 87);
            this.txtCalisilanYer.Name = "txtCalisilanYer";
            this.txtCalisilanYer.Properties.NullText = "(Şehir)";
            this.txtCalisilanYer.Size = new System.Drawing.Size(283, 20);
            this.txtCalisilanYer.StyleController = this.layoutControl1;
            this.txtCalisilanYer.TabIndex = 6;
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(14, 127);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(372, 79);
            this.txtNot.StyleController = this.layoutControl1;
            this.txtNot.TabIndex = 9;
            // 
            // txtBtnBasvurucu
            // 
            this.txtBtnBasvurucu.Location = new System.Drawing.Point(103, 39);
            this.txtBtnBasvurucu.Name = "txtBtnBasvurucu";
            this.txtBtnBasvurucu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtBtnBasvurucu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtBtnBasvurucu.Size = new System.Drawing.Size(283, 20);
            this.txtBtnBasvurucu.StyleController = this.layoutControl1;
            this.txtBtnBasvurucu.TabIndex = 4;
            this.txtBtnBasvurucu.Click += new System.EventHandler(this.txtBtnBasvurucu_Click);
            // 
            // txtBtnVekili
            // 
            this.txtBtnVekili.Location = new System.Drawing.Point(103, 63);
            this.txtBtnVekili.Name = "txtBtnVekili";
            this.txtBtnVekili.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtBtnVekili.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtBtnVekili.Size = new System.Drawing.Size(283, 20);
            this.txtBtnVekili.StyleController = this.layoutControl1;
            this.txtBtnVekili.TabIndex = 5;
            this.txtBtnVekili.Click += new System.EventHandler(this.txtBtnVekili_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(400, 220);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.layoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.AppearanceGroup.Options.UseForeColor = true;
            this.layoutControlGroup2.AppearanceTabPage.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.layoutControlGroup2.AppearanceTabPage.Header.Options.UseFont = true;
            this.layoutControlGroup2.CustomizationFormText = "Başvurucu Bilgileri";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(400, 220);
            this.layoutControlGroup2.Text = "Başvurucu Bilgileri";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtBtnBasvurucu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem1.Text = "Başvurucu Taraf :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(86, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtBtnVekili;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem2.Text = "Başvurucu Vekili :";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(86, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtCalisilanYer;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem3.Text = "Çalışılan Yer :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(86, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtNot;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(376, 99);
            this.layoutControlItem6.Text = "Notlar :";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(86, 13);
            // 
            // BasvurucuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "BasvurucuUC";
            this.Size = new System.Drawing.Size(400, 220);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCalisilanYer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnBasvurucu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnVekili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtCalisilanYer;
        private DevExpress.XtraEditors.MemoEdit txtNot;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.ButtonEdit txtBtnBasvurucu;
        private DevExpress.XtraEditors.ButtonEdit txtBtnVekili;
    }
}
