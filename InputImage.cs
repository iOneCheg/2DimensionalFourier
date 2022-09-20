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
    public partial class InputImage : Form
    {
        public InputImage(int N,int M)
        {
            InitializeComponent();
            pictureBoxInputImage.Image = new Bitmap(N, M);
        }
        public InputImage(Bitmap bmp)
        {
            InitializeComponent();
            pictureBoxInputImage.Image = new Bitmap(bmp);
        }
        public void FillImage(int[][] pixels)
        {
            pictureBoxInputImage.Image = new Bitmap(pixels.Length, pixels[0].Length);
            for (int i = 0; i < pixels.Length; i++)
            {
                for (int j = 0; j < pixels[i].Length; j++)
                {
                    ((Bitmap)pictureBoxInputImage.Image).
                    SetPixel(i, j, Color.FromArgb(pixels[i][j], pixels[i][j], pixels[i][j]));
                }
            }
            pictureBoxInputImage.Refresh();
        }
    }
}
