namespace prolab2deneme1
{
    partial class AdminPaneli
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
            this.KullanıcıAdı = new System.Windows.Forms.Label();
            this.Sifre = new System.Windows.Forms.Label();
            this.KullanıcıAdıText = new System.Windows.Forms.TextBox();
            this.SifreText = new System.Windows.Forms.TextBox();
            this.girisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KullanıcıAdı
            // 
            this.KullanıcıAdı.AutoSize = true;
            this.KullanıcıAdı.Location = new System.Drawing.Point(184, 101);
            this.KullanıcıAdı.Name = "KullanıcıAdı";
            this.KullanıcıAdı.Size = new System.Drawing.Size(79, 16);
            this.KullanıcıAdı.TabIndex = 0;
            this.KullanıcıAdı.Text = "Kullanıcı Adı";
            // 
            // Sifre
            // 
            this.Sifre.AutoSize = true;
            this.Sifre.Location = new System.Drawing.Point(184, 150);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(34, 16);
            this.Sifre.TabIndex = 1;
            this.Sifre.Text = "Sifre";
            // 
            // KullanıcıAdıText
            // 
            this.KullanıcıAdıText.Location = new System.Drawing.Point(362, 94);
            this.KullanıcıAdıText.Name = "KullanıcıAdıText";
            this.KullanıcıAdıText.Size = new System.Drawing.Size(152, 22);
            this.KullanıcıAdıText.TabIndex = 2;
            // 
            // SifreText
            // 
            this.SifreText.Location = new System.Drawing.Point(362, 150);
            this.SifreText.Name = "SifreText";
            this.SifreText.Size = new System.Drawing.Size(152, 22);
            this.SifreText.TabIndex = 3;
            // 
            // girisYap
            // 
            this.girisYap.Location = new System.Drawing.Point(187, 229);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(327, 156);
            this.girisYap.TabIndex = 4;
            this.girisYap.Text = "Giris Yap";
            this.girisYap.UseVisualStyleBackColor = true;
            this.girisYap.Click += new System.EventHandler(this.girisYap_Click);
            // 
            // AdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.girisYap);
            this.Controls.Add(this.SifreText);
            this.Controls.Add(this.KullanıcıAdıText);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.KullanıcıAdı);
            this.Name = "AdminPaneli";
            this.Text = "AdminPaneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KullanıcıAdı;
        private System.Windows.Forms.Label Sifre;
        private System.Windows.Forms.TextBox KullanıcıAdıText;
        private System.Windows.Forms.TextBox SifreText;
        private System.Windows.Forms.Button girisYap;
    }
}