using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Numerics;
using System.Windows.Forms;

namespace ImageFiltering
{
    public partial class MainWindow : Form
    {
        ImageGeneration generator;

        SpectrImage spectrImage;

        LogSpectr logSpectr;

        private int[][] _inputPixels;
        private double[][] _noisePixels;
        private Complex[][] spectrPixels;

        Random rand;

        private int N, M;

        private int XShift1, YShift1,
                    XShift2, YShift2,
                    XShift3, YShift3;


        private double amplitude_1,
                       amplitude_2,
                       amplitude_3,

                       Sigma_X,
                       Sigma_Y;

        private void buttonDrawNoisyImage_Click(object sender, EventArgs e)
        {
            NoisyImage noisyImage = new NoisyImage(_inputPixels.Length, _inputPixels[0].Length);
            noisyImage.Size = new Size(_inputPixels.Length + 40, _inputPixels[0].Length + 60);

            int[][] noisePixels = ImageGeneration.NoisePicture(_inputPixels, 10, rand);  // 2 параметр - % шума
            _noisePixels = Converter.ConvertToDoubleArray2Dim(noisePixels);

            textBoxSignalNoiseDelta.Text = DeltaSignalNoise(_inputPixels, noisePixels).ToString("F3");
            noisyImage.FillImage(noisePixels);
            noisyImage.Show();
        }

        public MainWindow()
        {
            InitializeComponent();
            groupBoxHowComplement.Enabled = false;
            rand = new Random(DateTime.Now.Millisecond);
            openFileDialogLoadImageInput.Filter = "Image Files(*.BMP;*.PNG)|*.BMP;*.PNG|All files (*.*)|*.*";
            openFileDialogLoadImageInput.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (checkBoxChoiceImage.Checked == false)
            {
                groupBoxHowComplement.Enabled = false;
            }
        }

        private void checkBoxZeroCoplement_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxZeroCoplement.Checked == true)
            {
                _inputPixels = ZerosAdding(_inputPixels);
                N = _inputPixels.Length; M = _inputPixels[0].Length;
                InputImage inp = new InputImage(N, M);
                inp.Size = new Size(N + 40, M + 60);
                inp.FillImage(_inputPixels);
                inp.Show();
            }
        }

        public int[][] BilinearScale(int[][] inputImage, double scaleX, double scaleY)
        {
            int srcH = inputImage[0].Length;
            int srcW = inputImage.Length;
            int maxWidth = (int)(scaleX * inputImage.Length);
            int maxHeight = (int)(scaleY * inputImage[0].Length);
            int[][] outputImage = new int[maxHeight][];
            float rowRatio = ((float)inputImage[0].Length) / ((float)maxHeight);
            float colRatio = ((float)inputImage.Length) / ((float)maxWidth);
            for (int row = 0; row < maxHeight; row++)
            {
                // convert to three dimension data  
                outputImage[row] = new int[maxWidth];
                double srcRow = ((float)row) * rowRatio;
                double j = Math.Floor(srcRow);
                double t = srcRow - j;
                for (int col = 0; col < maxWidth; col++)
                {
                    double srcCol = ((float)col) * colRatio;
                    double k = Math.Floor(srcCol);
                    double u = srcCol - k;
                    double coffiecent1 = (1.0d - t) * (1.0d - u);
                    double coffiecent2 = (t) * (1.0d - u);
                    double coffiecent3 = t * u;
                    double coffiecent4 = (1.0d - t) * u;

                    outputImage[row][col] = (int)(coffiecent1 * inputImage[getClip((int)j, srcH - 1, 0)][getClip((int)k, srcW - 1, 0)] +
                    coffiecent2 * inputImage[getClip((int)(j + 1), srcH - 1, 0)][getClip((int)k, srcW - 1, 0)] +
                    coffiecent3 * inputImage[getClip((int)(j + 1), srcH - 1, 0)][getClip((int)(k + 1), srcW - 1, 0)] +
                    coffiecent4 * inputImage[getClip((int)j, srcH - 1, 0)][getClip((int)(k + 1), srcW - 1, 0)]);
                }
            }
            return outputImage;
        }
        private int getClip(int x, int max, int min)
        {
            return x > max ? max : x < min ? min : x;
        }

        private void checkBoxBilinearInterpolation_CheckedChanged(object sender, EventArgs e)
        {
            double scaleX = GetLengthForPower2(_inputPixels.Length) / (double)_inputPixels.Length,
                   scaleY = GetLengthForPower2(_inputPixels[0].Length) / (double)_inputPixels[0].Length;

            _inputPixels = BilinearScale(_inputPixels, scaleX, scaleY);
            N = _inputPixels.Length; M = _inputPixels[0].Length;

            InputImage inputImage = new InputImage(N, M);
            inputImage.Size = new Size(N + 40, M + 60);
            inputImage.FillImage(_inputPixels);
            inputImage.Show();
        }

        private double GetLengthForPower2(int length)
        {
            for (double x = 2; ; x *= 2)
                if (x > length) return x;
        }
        /// <summary>
        /// Проверка на то что сторона равна по длине степени 2
        /// </summary>
        /// <returns> true если сторона равна 2^x </returns>
        private bool CheckLengthForPower2(int length)
        {
            for (double x = 2; ; x *= 2)
                if (x > length) break;
                else if (x == length) return true;
            return false;
        }
        private int[][] ZerosAdding(int[][] inputPixels)
        {
            int N = 0, M = 0;
            for (int x = 2; ; x *= 2)
                if (x > inputPixels.Length)
                { N = x; break; }
            for (int y = 2; ; y *= 2)
                if (y > inputPixels[0].Length)
                { M = y; break; }
            int[][] newPixels = new int[N][];
            for (int i = 0; i < N; i++)
            {
                newPixels[i] = new int[M];
                for (int j = 0; j < M; j++)
                {
                    if (i < inputPixels.Length && j < inputPixels[0].Length)
                    {
                        newPixels[i][j] = inputPixels[i][j];
                    }
                    else newPixels[i][j] = 0;
                }
            }
            return newPixels;
        }

        private void checkBoxChoiceImage_CheckedChanged(object sender, EventArgs e)
        {
            InitialData();
            if (checkBoxChoiceImage.Checked == true)
            {
                button_Draw.Enabled = false;
                groupBoxGaussParameters.Enabled = false;
            }
            else
            {
                button_Draw.Enabled = true;
                groupBoxGaussParameters.Enabled = true;
                groupBoxHowComplement.Enabled = false;
            }

        }
        public static int[][] GetBrightnessArray(Bitmap srcImage)
        {
            Debug.Assert(srcImage != null);

            var result = new int[srcImage.Width][];


            for (var x = 0; x < srcImage.Width; x++)
            {
                result[x] = new int[srcImage.Height];
                for (var y = 0; y < srcImage.Height; y++)
                {
                    var srcPixel = srcImage.GetPixel(x, y);
                    result[x][y] = (int)(0.299 * srcPixel.R + 0.587 * srcPixel.G + 0.114 * srcPixel.B);

                }
            }
            return result;
        }
        private void InitialData()
        {
            if (checkBoxChoiceImage.Checked == true)
            {
                if (openFileDialogLoadImageInput.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
                {
                    try
                    {
                        Bitmap bmp = new Bitmap(openFileDialogLoadImageInput.FileName);
                        _inputPixels = GetBrightnessArray(bmp);
                        InputImage inputImage = new InputImage(_inputPixels.Length, _inputPixels[0].Length);
                        inputImage.Size = new Size(_inputPixels.Length + 40, _inputPixels[0].Length + 60);
                        if (CheckLengthForPower2(_inputPixels.Length) && CheckLengthForPower2(_inputPixels[0].Length))
                        {
                            groupBoxHowComplement.Enabled = false;
                        }
                        else
                        {
                            groupBoxHowComplement.Enabled = true;
                        }
                        inputImage.FillImage(_inputPixels);

                        inputImage.Show();
                    }
                    catch
                    {
                        DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                N = Convert.ToInt32(comboBoxNSize.Text);
                M = Convert.ToInt32(comboBoxMSize.Text);

                XShift1 = Convert.ToInt32(numericUpDownXShift1.Value);
                YShift1 = Convert.ToInt32(numericUpDownYShift1.Value);

                XShift2 = Convert.ToInt32(numericUpDownXShift2.Value);
                YShift2 = Convert.ToInt32(numericUpDownYShift2.Value);

                XShift3 = Convert.ToInt32(numericUpDownXShift3.Value);
                YShift3 = Convert.ToInt32(numericUpDownYShift3.Value);

                amplitude_1 = Convert.ToInt32(numericUpDownAmplitude1.Value);
                amplitude_2 = Convert.ToInt32(numericUpDownAmplitude2.Value);
                amplitude_3 = Convert.ToInt32(numericUpDownAmplitude3.Value);

                Sigma_X = Convert.ToDouble(numericUpDownSigmaX.Value);
                Sigma_Y = Convert.ToDouble(numericUpDownSigmaY.Value);
            }

        }


        private void button_Draw_Click(object sender, EventArgs e)
        {
            InitialData();

            InputImage inputImage = new InputImage(N, M);
            inputImage.Size = new Size(N + 40, M + 60);


            generator = new ImageGeneration(1, Sigma_X, Sigma_Y);

            double[] ampl = new double[] { amplitude_1, amplitude_2, amplitude_3 };
            int[] xSh = new int[] { XShift1, XShift2, XShift3 };
            int[] ySh = new int[] { YShift1, YShift2, YShift3 };

            double[][] pixelInputImage = generator.SumGaussDome(N, M, ampl, xSh, ySh);
            _inputPixels = Converter.ConvertToIntArray2Dim(pixelInputImage);

            inputImage.FillImage(_inputPixels);
            inputImage.Show();
        }
        private double DeltaSignalNoise(int[][] Signal, int[][] NoiseSignal)
        {
            double epsilon = 0, epsAssist = 0;
            for (int i = 0; i < Signal.Length; i++)
            {
                for (int j = 0; j < Signal[i].Length; j++)
                {
                    epsilon += Math.Pow(Signal[i][j] - NoiseSignal[i][j], 2);
                }
            }
            for (int i = 0; i < Signal.Length; i++)
            {
                for (int j = 0; j < Signal[i].Length; j++)
                {
                    epsAssist += Signal[i][j] * Signal[i][j];
                }
            }
            return epsilon / epsAssist;
        }
        private double DeltaSignalRecovery(int[][] Signal, int[][] RecoverySignal)
        {
            double epsilon = 0, epsAssist = 0;
            for (int i = 0; i < Signal.Length; i++)
            {
                for (int j = 0; j < Signal[i].Length; j++)
                {
                    epsilon += Math.Pow(Signal[i][j] - RecoverySignal[i][j], 2);
                }
            }
            for (int i = 0; i < Signal.Length; i++)
            {
                for (int j = 0; j < Signal[i].Length; j++)
                {
                    epsAssist += Signal[i][j] * Signal[i][j];
                }
            }
            return epsilon / epsAssist;
        }

        private void button_Recovery_Click(object sender, EventArgs e)
        {
            RecoveryImage recoryImage = new RecoveryImage(N, M);
            recoryImage.Size = new Size(N + 40, M + 60);

            int procentRecovery = 50;
            Complex[][] spectrToRecovery = new Complex[N][];

            double Min = Math.Min(N / 2, M / 2);
            double radius = (Min / 100) * procentRecovery;
            for (int i = 0; i < N; i++)
            {
                spectrToRecovery[i] = new Complex[M];
                for (int j = 0; j < M; j++)
                {
                    if (Math.Pow((i - N / 2), 2) + Math.Pow((j - M / 2), 2) <= radius * radius)
                    {
                        spectrToRecovery[i][j] = spectrPixels[i][j];
                    }
                    else
                    {
                        spectrToRecovery[i][j] = new Complex(0, 0);
                    }
                }
            }

            double[][] pixelsSpectr = new double[spectrToRecovery.Length][];
            for (int i = 0; i < spectrToRecovery.Length; i++)
            {
                pixelsSpectr[i] = new double[spectrToRecovery[i].Length];
                pixelsSpectr[i] = FFT.SpectrumPoints(spectrToRecovery[i]);
            }
            int[][] spectrPixelsToImage = Converter.ConvertToIntArray2Dim(pixelsSpectr);

            spectrImage.FillImage(spectrPixelsToImage);

            Complex[][] recoveryCompl = FFT.TwoDimensionalTransform(spectrToRecovery, false);
            double[][] pixelRecovery = FFT.RecoveryPoints(recoveryCompl);
            int[][] spectr = Converter.ConvertToIntArray2Dim(pixelRecovery);
            textBoxSignalRecoveryDelta.Text = DeltaSignalRecovery(_inputPixels, spectr).ToString("F3");

            recoryImage.FillImage(spectr);
            recoryImage.Show();

        }

        private void button_DrawSpectrImage_Click(object sender, EventArgs e)
        {
            spectrImage = new SpectrImage(N, M);
            spectrImage.Size = new Size(N + 40, M + 60);

            logSpectr = new LogSpectr(N, M);
            logSpectr.Size = new Size(N + 40, M + 60);

            Complex[][] complexPixels = new Complex[N][];

            for (int i = 0; i < complexPixels.Length; i++)
            {
                complexPixels[i] = new Complex[M];
                for (int j = 0; j < complexPixels[i].Length; j++)
                {
                    complexPixels[i][j] = new Complex(_noisePixels[i][j], 0);
                }
            }

            spectrPixels = FFT.TwoDimensionalTransform(complexPixels, true);

            double[][] pixelsSpectr = new double[spectrPixels.GetLength(0)][];
            for (int i = 0; i < spectrPixels.GetLength(0); i++)
            {
                pixelsSpectr[i] = new double[spectrPixels[i].Length];
                pixelsSpectr[i] = FFT.SpectrumPoints(spectrPixels[i]);
            }
            pixelsSpectr[N / 2][M / 2] = 0;
            int[][] spectrPixelsToImage = Converter.ConvertToIntArray2Dim(pixelsSpectr);

            int[][] logSpectrImagePixels = Converter.ConvertToLogIntArray2Dim(pixelsSpectr);

            logSpectr.FillImage(logSpectrImagePixels);
            logSpectr.Show();

            spectrImage.FillImage(spectrPixelsToImage);
            spectrImage.Show();
        }

    }
}
