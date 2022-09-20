namespace ImageFiltering
{
    partial class SpectrImage
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
            this.pictureBoxSpectrImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpectrImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSpectrImage
            // 
            this.pictureBoxSpectrImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxSpectrImage.Name = "pictureBoxSpectrImage";
            this.pictureBoxSpectrImage.Size = new System.Drawing.Size(512, 512);
            this.pictureBoxSpectrImage.TabIndex = 2;
            this.pictureBoxSpectrImage.TabStop = false;
            // 
            // SpectrImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 530);
            this.Controls.Add(this.pictureBoxSpectrImage);
            this.Name = "SpectrImage";
            this.Text = "SpectrImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpectrImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSpectrImage;
    }
}