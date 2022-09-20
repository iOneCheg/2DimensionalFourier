﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFiltering
{
    
    class Converter
    {
        public static int[][] ConvertImageToInt(Bitmap img)
        {
            ImageConverter converter = new ImageConverter();
            return (int[][])converter.ConvertTo(img, typeof(int[][]));
        }
        public static int[][] ConvertToIntArray2Dim(double[][] pixels)
        {
            int[][] pixelInt = new int[pixels.Length][];
            for (int i = 0; i < pixelInt.Length; i++)
            {
                pixelInt[i] = new int[pixels[i].Length];
                for (int j = 0; j < pixelInt[i].Length; j++)
                {
                    pixelInt[i][j] = Convert.ToInt32(pixels[i][j] * 255);
                    if (pixelInt[i][j] > 255) pixelInt[i][j] = 255;
                }
            }
            return pixelInt;
        }

        public static int[][] ConvertToLogIntArray2Dim(double[][] pixels)
        {
            int[][] pixelInt = new int[pixels.Length][];
            for (int i = 0; i < pixelInt.Length; i++)
            {
                pixelInt[i] = new int[pixels[i].Length];
                for (int j = 0; j < pixelInt[i].Length; j++)
                {
                    pixelInt[i][j] = Convert.ToInt32(Math.Log10(1 + pixels[i][j]) * 255);
                    if (pixelInt[i][j] > 255) pixelInt[i][j] = 255;
                }
            }
            return pixelInt;
        }
        public static double[][] ConvertToDoubleArray2Dim(int[][] pixels)
        {
            double[][] pixelD = new double[pixels.Length][];
            for (int i = 0; i < pixelD.Length; i++)
            {
                pixelD[i] = new double[pixels[i].Length];
                for (int j = 0; j < pixelD[i].Length; j++)
                {
                    pixelD[i][j] = (double)pixels[i][j] / 255.0;
                }
            }
            return pixelD;
        }
    }
}
