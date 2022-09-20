namespace ImageFiltering
{
    partial class NoisyImage
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
            this.pictureBoxNoisyImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoisyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxNoisyImage
            // 
            this.pictureBoxNoisyImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxNoisyImage.Name = "pictureBoxNoisyImage";
            this.pictureBoxNoisyImage.Size = new System.Drawing.Size(512, 512);
            this.pictureBoxNoisyImage.TabIndex = 2;
            this.pictureBoxNoisyImage.TabStop = false;
            // 
            // NoisyImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 533);
            this.Controls.Add(this.pictureBoxNoisyImage);
            this.Name = "NoisyImage";
            this.Text = "NoisyImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoisyImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxNoisyImage;
    }
}