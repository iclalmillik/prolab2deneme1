namespace prolab2deneme1
{
    partial class FirmaGoruntulePaneli
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
            this.FirmaListesi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FirmaListesi
            // 
            this.FirmaListesi.FormattingEnabled = true;
            this.FirmaListesi.ItemHeight = 16;
            this.FirmaListesi.Location = new System.Drawing.Point(237, 28);
            this.FirmaListesi.Name = "FirmaListesi";
            this.FirmaListesi.Size = new System.Drawing.Size(198, 356);
            this.FirmaListesi.TabIndex = 0;
            this.FirmaListesi.SelectedIndexChanged += new System.EventHandler(this.FirmaListesi_SelectedIndexChanged);
            // 
            // FirmaGoruntulePaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FirmaListesi);
            this.Name = "FirmaGoruntulePaneli";
            this.Text = "FirmaGoruntulePaneli";
            this.Load += new System.EventHandler(this.FirmaGoruntulePaneli_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FirmaListesi;
    }
}