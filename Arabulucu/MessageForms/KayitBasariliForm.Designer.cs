namespace Arabulucu.MessageForms
{
    partial class KayitBasariliForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kayıt İşlemi Başarılı.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.lblKayit_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.EditValue = global::Arabulucu.Properties.Resources.OkGif;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(276, 181);
            this.pictureEdit1.TabIndex = 0;
            this.pictureEdit1.Click += new System.EventHandler(this.lblKayit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timerKapat_Tick);
            // 
            // KayitBasariliForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "KayitBasariliForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitBasariliForm";
            this.Load += new System.EventHandler(this.KayitBasariliForm_Load);
            this.Click += new System.EventHandler(this.lblKayit_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Timer timer1;
    }
}