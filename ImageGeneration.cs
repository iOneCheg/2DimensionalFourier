using System;

namespace ImageFiltering
{
    class ImageGeneration
    {
        private readonly double _sigmaX, _sigmaY;

        public ImageGeneration(int countDome, double sigmaX, double sigmaY)
        {
            _sigmaX = sigmaX; _sigmaY = sigmaY;
        }
        private double GaussDome(double amplitude, int x, int y, int xShift, int yShift)
        {
            double degree = -((x - xShift) * (x - xShift) / (_sigmaX * _sigmaX) + (y - yShift) * (y - yShift) / (_sigmaY * _sigmaY));
            return amplitude * Math.Exp(degree);
        }
        public double[][] SumGaussDome(int Width, int Height, double[] amplitude, int[] xShift, int[] yShift)
        {
            double[][] pixels = new double[Width][];
            for (int i = 0; i < pixels.Length; i++)
            {
                pixels[i] = new double[Height];
                for (int j = 0; j < pixels[i].Length; j++)
                {
                    pixels[i][j] = GaussDome(amplitude[0], i, j, xShift[0], yShift[0]) +
                        GaussDome(amplitude[1], i, j, xShift[1], yShift[1]) +
                        GaussDome(amplitude[2], i, j, xShift[2], yShift[2]);
                }
            }
            return pixels;
        }


        public static int[][] NoisePicture(int[][] pixelsFromImage, int intensity, Random rnd)
        {
            int length = pixelsFromImage.GetLength(0);
            int[][] noisePicture = new int[length][];

            // Генерация последовательности нормально распределённых случайных чисел.
            double[][] massRand = new double[length][];                   // Массив случайных чисел. 
            double energyRandMass = 0;                               // Энергия последовательности.
            for (int i = 0; i < length; i++)
            {
                massRand[i] = new double[pixelsFromImage[i].Length];
                for (int j = 0; j < pixelsFromImage[i].Length; j++)
                {
                    massRand[i][j] = 0;
                    for (int n = 0; n < 12; n++)
                        massRand[i][j] += rnd.Next(-100, 100);
                    massRand[i][j] /= 12;
                    energyRandMass += massRand[i][j] * massRand[i][j];
                }
            }

            // Подсчёт энергии шума относительно энергии сигнала.
            float energySignal = 0;                                 // Полная энергия сигнала.
            for (int i = 0; i < length; i++)
                for (int j = 0; j < pixelsFromImage[i].Length; j++)
                    energySignal += pixelsFromImage[i][j] * pixelsFromImage[i][j];
            float energyNoise = energySignal * (intensity / 100f);  // Энергия шума относительно энергии сигнала.

            // Нормировка случайной последовательности.
            for (int i = 0; i < length; i++)
                for (int j = 0; j < pixelsFromImage[i].Length; j++)
                    massRand[i][j] = massRand[i][j] * Math.Sqrt(energyNoise / energyRandMass);


            for (int i = 0; i < massRand.Length; i++)
            {
                for (int j = 0; j < massRand[i].Length; j++)
                {
                    if (massRand[i][j] < 0)
                    {
                        massRand[i][j] = -massRand[i][j];
                    }
                }
            }

            // Накладывание шума на исходный сигнал.
            for (int i = 0; i < length; i++)
            {
                noisePicture[i] = new int[pixelsFromImage[i].Length];
                for (int j = 0; j < pixelsFromImage[i].Length; j++)
                {
                    noisePicture[i][j] = pixelsFromImage[i][j] + Convert.ToInt32(massRand[i][j]);
                    if (noisePicture[i][j] > 255)
                    {
                        noisePicture[i][j] = noisePicture[i][j] - Convert.ToInt32(massRand[i][j]);
                    }
                }
            }
            return noisePicture;
        }
    }
}
