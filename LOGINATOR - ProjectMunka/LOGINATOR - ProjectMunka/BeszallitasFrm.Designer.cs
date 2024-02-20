namespace LOGINATOR___ProjectMunka
{
    partial class BeszallitasFrm
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
            this.erkeztetesBtn = new System.Windows.Forms.Button();
            this.aruFelvetelBtn = new System.Windows.Forms.Button();
            this.megseBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // erkeztetesBtn
            // 
            this.erkeztetesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.erkeztetesBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.erkeztetesBtn.Location = new System.Drawing.Point(33, 283);
            this.erkeztetesBtn.Name = "erkeztetesBtn";
            this.erkeztetesBtn.Size = new System.Drawing.Size(159, 38);
            this.erkeztetesBtn.TabIndex = 1;
            this.erkeztetesBtn.Text = "Érkeztetés";
            this.erkeztetesBtn.UseVisualStyleBackColor = true;
            this.erkeztetesBtn.Click += new System.EventHandler(this.erkeztetesBtn_Click);
            // 
            // aruFelvetelBtn
            // 
            this.aruFelvetelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aruFelvetelBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aruFelvetelBtn.Location = new System.Drawing.Point(33, 340);
            this.aruFelvetelBtn.Name = "aruFelvetelBtn";
            this.aruFelvetelBtn.Size = new System.Drawing.Size(159, 38);
            this.aruFelvetelBtn.TabIndex = 2;
            this.aruFelvetelBtn.Text = "Áru Felvétel";
            this.aruFelvetelBtn.UseVisualStyleBackColor = true;
            this.aruFelvetelBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // megseBtn
            // 
            this.megseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megseBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.megseBtn.Location = new System.Drawing.Point(304, 340);
            this.megseBtn.Name = "megseBtn";
            this.megseBtn.Size = new System.Drawing.Size(159, 38);
            this.megseBtn.TabIndex = 3;
            this.megseBtn.Text = "Kilépés";
            this.megseBtn.UseVisualStyleBackColor = true;
            this.megseBtn.Click += new System.EventHandler(this.megseBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(304, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Számlázás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOGINATOR___ProjectMunka.Properties.Resources.LoadingBay;
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BeszallitasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.megseBtn);
            this.Controls.Add(this.aruFelvetelBtn);
            this.Controls.Add(this.erkeztetesBtn);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "BeszallitasFrm";
            this.Text = "Beszállitás Menü";
            this.Load += new System.EventHandler(this.BeszallitasFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button erkeztetesBtn;
        private System.Windows.Forms.Button aruFelvetelBtn;
        private System.Windows.Forms.Button megseBtn;
        private System.Windows.Forms.Button button1;
    }
}