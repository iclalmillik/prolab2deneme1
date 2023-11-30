namespace prolab2deneme1
{
    partial class AdminPaneliİslemler
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
            this.FirmaGorButton = new System.Windows.Forms.Button();
            this.FirmaEkleButton = new System.Windows.Forms.Button();
            this.FirmaSilButton = new System.Windows.Forms.Button();
            this.HizmetBedeliButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirmaGorButton
            // 
            this.FirmaGorButton.Location = new System.Drawing.Point(328, 57);
            this.FirmaGorButton.Name = "FirmaGorButton";
            this.FirmaGorButton.Size = new System.Drawing.Size(160, 63);
            this.FirmaGorButton.TabIndex = 0;
            this.FirmaGorButton.Text = "Firmaları Görüntüle";
            this.FirmaGorButton.UseVisualStyleBackColor = true;
            this.FirmaGorButton.Click += new System.EventHandler(this.FirmaGorButton_Click);
            // 
            // FirmaEkleButton
            // 
            this.FirmaEkleButton.Location = new System.Drawing.Point(328, 154);
            this.FirmaEkleButton.Name = "FirmaEkleButton";
            this.FirmaEkleButton.Size = new System.Drawing.Size(160, 62);
            this.FirmaEkleButton.TabIndex = 1;
            this.FirmaEkleButton.Text = "Firma Ekleme";
            this.FirmaEkleButton.UseVisualStyleBackColor = true;
            // 
            // FirmaSilButton
            // 
            this.FirmaSilButton.Location = new System.Drawing.Point(328, 248);
            this.FirmaSilButton.Name = "FirmaSilButton";
            this.FirmaSilButton.Size = new System.Drawing.Size(160, 61);
            this.FirmaSilButton.TabIndex = 2;
            this.FirmaSilButton.Text = "Firma Silme";
            this.FirmaSilButton.UseVisualStyleBackColor = true;
            // 
            // HizmetBedeliButton
            // 
            this.HizmetBedeliButton.Location = new System.Drawing.Point(328, 335);
            this.HizmetBedeliButton.Name = "HizmetBedeliButton";
            this.HizmetBedeliButton.Size = new System.Drawing.Size(160, 55);
            this.HizmetBedeliButton.TabIndex = 3;
            this.HizmetBedeliButton.Text = "Hizmet Bedeli Hesaplama";
            this.HizmetBedeliButton.UseVisualStyleBackColor = true;
            // 
            // AdminPaneliİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HizmetBedeliButton);
            this.Controls.Add(this.FirmaSilButton);
            this.Controls.Add(this.FirmaEkleButton);
            this.Controls.Add(this.FirmaGorButton);
            this.Name = "AdminPaneliİslemler";
            this.Text = "AdminPaneliİslemler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FirmaGorButton;
        private System.Windows.Forms.Button FirmaEkleButton;
        private System.Windows.Forms.Button FirmaSilButton;
        private System.Windows.Forms.Button HizmetBedeliButton;
    }
}