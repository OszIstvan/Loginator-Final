namespace LOGINATOR___ProjectMunka
{
    partial class KiszallitasFrm
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
            this.aruOsszekeszitesBtn = new System.Windows.Forms.Button();
            this.szamlazasBtn = new System.Windows.Forms.Button();
            this.megseBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gongyolegBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aruOsszekeszitesBtn
            // 
            this.aruOsszekeszitesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aruOsszekeszitesBtn.Location = new System.Drawing.Point(36, 289);
            this.aruOsszekeszitesBtn.Name = "aruOsszekeszitesBtn";
            this.aruOsszekeszitesBtn.Size = new System.Drawing.Size(174, 46);
            this.aruOsszekeszitesBtn.TabIndex = 1;
            this.aruOsszekeszitesBtn.Text = "Áru Összekészítés";
            this.aruOsszekeszitesBtn.UseVisualStyleBackColor = true;
            this.aruOsszekeszitesBtn.Click += new System.EventHandler(this.aruOsszekeszitesBtn_Click);
            // 
            // szamlazasBtn
            // 
            this.szamlazasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szamlazasBtn.Location = new System.Drawing.Point(264, 289);
            this.szamlazasBtn.Name = "szamlazasBtn";
            this.szamlazasBtn.Size = new System.Drawing.Size(174, 46);
            this.szamlazasBtn.TabIndex = 2;
            this.szamlazasBtn.Text = "Számlázás";
            this.szamlazasBtn.UseVisualStyleBackColor = true;
            this.szamlazasBtn.Click += new System.EventHandler(this.szamlazasBtn_Click);
            // 
            // megseBtn
            // 
            this.megseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megseBtn.Location = new System.Drawing.Point(264, 359);
            this.megseBtn.Name = "megseBtn";
            this.megseBtn.Size = new System.Drawing.Size(174, 46);
            this.megseBtn.TabIndex = 3;
            this.megseBtn.Text = "Kilépés";
            this.megseBtn.UseVisualStyleBackColor = true;
            this.megseBtn.Click += new System.EventHandler(this.megseBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOGINATOR___ProjectMunka.Properties.Resources.Kiszallitas;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gongyolegBtn
            // 
            this.gongyolegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gongyolegBtn.Location = new System.Drawing.Point(36, 359);
            this.gongyolegBtn.Name = "gongyolegBtn";
            this.gongyolegBtn.Size = new System.Drawing.Size(174, 46);
            this.gongyolegBtn.TabIndex = 4;
            this.gongyolegBtn.Text = "Göngyöleg";
            this.gongyolegBtn.UseVisualStyleBackColor = true;
            this.gongyolegBtn.Click += new System.EventHandler(this.gongyolegBtn_Click);
            // 
            // KiszallitasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 440);
            this.Controls.Add(this.gongyolegBtn);
            this.Controls.Add(this.megseBtn);
            this.Controls.Add(this.szamlazasBtn);
            this.Controls.Add(this.aruOsszekeszitesBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KiszallitasFrm";
            this.Text = "Kiszállitás Menü";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button aruOsszekeszitesBtn;
        private System.Windows.Forms.Button szamlazasBtn;
        private System.Windows.Forms.Button megseBtn;
        private System.Windows.Forms.Button gongyolegBtn;
    }
}