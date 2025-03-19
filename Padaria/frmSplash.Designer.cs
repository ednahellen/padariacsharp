namespace Padaria
{
    partial class pboxLogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pboxLogo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.lporcen = new System.Windows.Forms.Label();
            this.progbar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(343, 270);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(18, 20);
            this.lblnum.TabIndex = 1;
            this.lblnum.Text = "0";
            this.lblnum.Click += new System.EventHandler(this.label1_Click);
            // 
            // lporcen
            // 
            this.lporcen.AutoSize = true;
            this.lporcen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lporcen.Location = new System.Drawing.Point(367, 270);
            this.lporcen.Name = "lporcen";
            this.lporcen.Size = new System.Drawing.Size(23, 20);
            this.lporcen.TabIndex = 2;
            this.lporcen.Text = "%";
            // 
            // progbar
            // 
            this.progbar.Location = new System.Drawing.Point(286, 293);
            this.progbar.Name = "progbar";
            this.progbar.Size = new System.Drawing.Size(166, 22);
            this.progbar.TabIndex = 3;
            // 
            // pboxLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.progbar);
            this.Controls.Add(this.lporcen);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "pboxLogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria - Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lporcen;
        private System.Windows.Forms.ProgressBar progbar;
    }
}