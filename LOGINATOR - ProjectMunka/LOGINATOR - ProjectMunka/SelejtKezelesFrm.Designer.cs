namespace LOGINATOR___ProjectMunka
{
    partial class SelejtKezelesFrm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selejtFelvetelBtn = new System.Windows.Forms.Button();
            this.megseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOGINATOR___ProjectMunka.Properties.Resources.Selejt;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // selejtFelvetelBtn
            // 
            this.selejtFelvetelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selejtFelvetelBtn.Location = new System.Drawing.Point(28, 216);
            this.selejtFelvetelBtn.Name = "selejtFelvetelBtn";
            this.selejtFelvetelBtn.Size = new System.Drawing.Size(140, 40);
            this.selejtFelvetelBtn.TabIndex = 1;
            this.selejtFelvetelBtn.Text = "Selejt felvétele";
            this.selejtFelvetelBtn.UseVisualStyleBackColor = true;
            this.selejtFelvetelBtn.Click += new System.EventHandler(this.selejtFelvetelBtn_Click);
            // 
            // megseBtn
            // 
            this.megseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megseBtn.Location = new System.Drawing.Point(193, 216);
            this.megseBtn.Name = "megseBtn";
            this.megseBtn.Size = new System.Drawing.Size(140, 40);
            this.megseBtn.TabIndex = 2;
            this.megseBtn.Text = "Kilépés";
            this.megseBtn.UseVisualStyleBackColor = true;
            this.megseBtn.Click += new System.EventHandler(this.megseBtn_Click);
            // 
            // SelejtKezelesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 293);
            this.Controls.Add(this.megseBtn);
            this.Controls.Add(this.selejtFelvetelBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SelejtKezelesFrm";
            this.Text = "Selejtkezelés Menü";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button selejtFelvetelBtn;
        private System.Windows.Forms.Button megseBtn;
    }
}