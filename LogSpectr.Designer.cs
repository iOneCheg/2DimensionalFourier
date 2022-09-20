namespace ImageFiltering
{
    partial class LogSpectr
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
            this.pictureBoxLogSpectrImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogSpectrImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogSpectrImage
            // 
            this.pictureBoxLogSpectrImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogSpectrImage.Name = "pictureBoxLogSpectrImage";
            this.pictureBoxLogSpectrImage.Size = new System.Drawing.Size(512, 512);
            this.pictureBoxLogSpectrImage.TabIndex = 3;
            this.pictureBoxLogSpectrImage.TabStop = false;
            // 
            // LogSpectr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 530);
            this.Controls.Add(this.pictureBoxLogSpectrImage);
            this.Name = "LogSpectr";
            this.Text = "LogSpectr";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogSpectrImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogSpectrImage;
    }
}