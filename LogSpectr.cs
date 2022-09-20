using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFiltering
{
    public partial class LogSpectr : Form
    {
        public LogSpectr(int N, int M)
        {
            pictureBoxLogSpectrImage = new PictureBox();
            pictureBoxLogSpectrImage.Image = new Bitmap(N, M);
            InitializeComponent();
        }
        public void FillImage(int[][] pixels)
        {
            pictureBoxLogSpectrImage.Image = new Bitmap(pictureBoxLogSpectrImage.Width, pictureBoxLogSpectrImage.Height);
            for (int i = 0; i < pixels.Length; i++)
            {
                for (int j = 0; j < pixels[i].Length; j++)
                {
                    ((Bitmap)pictureBoxLogSpectrImage.Image).
                    SetPixel(i, j, Color.FromArgb(pixels[i][j], pixels[i][j], pixels[i][j]));
                }
            }
            pictureBoxLogSpectrImage.Refresh();
        }
    }
}
