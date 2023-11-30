namespace prolab2deneme1
{
    partial class Giris
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
            this.kullaniciPaneli = new System.Windows.Forms.Button();
            this.AdminPaneli = new System.Windows.Forms.Button();
            this.FirmaPaneli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciPaneli
            // 
            this.kullaniciPaneli.Location = new System.Drawing.Point(228, 48);
            this.kullaniciPaneli.Name = "kullaniciPaneli";
            this.kullaniciPaneli.Size = new System.Drawing.Size(281, 102);
            this.kullaniciPaneli.TabIndex = 0;
            this.kullaniciPaneli.Text = "Kullanıcı Paneli";
            this.kullaniciPaneli.UseVisualStyleBackColor = true;
            // 
            // AdminPaneli
            // 
            this.AdminPaneli.Location = new System.Drawing.Point(228, 170);
            this.AdminPaneli.Name = "AdminPaneli";
            this.AdminPaneli.Size = new System.Drawing.Size(281, 111);
            this.AdminPaneli.TabIndex = 1;
            this.AdminPaneli.Text = "Admin Paneli";
            this.AdminPaneli.UseVisualStyleBackColor = true;
            this.AdminPaneli.Click += new System.EventHandler(this.AdminPaneli_Click);
            // 
            // FirmaPaneli
            // 
            this.FirmaPaneli.Location = new System.Drawing.Point(228, 308);
            this.FirmaPaneli.Name = "FirmaPaneli";
            this.FirmaPaneli.Size = new System.Drawing.Size(281, 118);
            this.FirmaPaneli.TabIndex = 2;
            this.FirmaPaneli.Text = "FİrmaPaneli";
            this.FirmaPaneli.UseVisualStyleBackColor = true;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FirmaPaneli);
            this.Controls.Add(this.AdminPaneli);
            this.Controls.Add(this.kullaniciPaneli);
            this.Name = "Giris";
            this.Text = "Giris";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kullaniciPaneli;
        private System.Windows.Forms.Button AdminPaneli;
        private System.Windows.Forms.Button FirmaPaneli;
    }
}