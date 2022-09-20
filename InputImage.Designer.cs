namespace ImageFiltering
{
    partial class InputImage
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
            this.pictureBoxInputImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInputImage
            // 
            this.pictureBoxInputImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxInputImage.Name = "pictureBoxInputImage";
            this.pictureBoxInputImage.Size = new System.Drawing.Size(512, 512);
            this.pictureBoxInputImage.TabIndex = 1;
            this.pictureBoxInputImage.TabStop = false;
            // 
            // InputImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 533);
            this.Controls.Add(this.pictureBoxInputImage);
            this.Name = "InputImage";
            this.Text = "InputImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInputImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInputImage;
    }
}