namespace ImageFiltering
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Draw = new System.Windows.Forms.Button();
            this.button_DrawSpectrImage = new System.Windows.Forms.Button();
            this.button_Recovery = new System.Windows.Forms.Button();
            this.groupBoxInputParameters = new System.Windows.Forms.GroupBox();
            this.buttonDrawNoisyImage = new System.Windows.Forms.Button();
            this.groupBoxHowComplement = new System.Windows.Forms.GroupBox();
            this.checkBoxBilinearInterpolation = new System.Windows.Forms.CheckBox();
            this.checkBoxZeroCoplement = new System.Windows.Forms.CheckBox();
            this.groupBoxGaussParameters = new System.Windows.Forms.GroupBox();
            this.groupBoxInputSize = new System.Windows.Forms.GroupBox();
            this.comboBoxMSize = new System.Windows.Forms.ComboBox();
            this.labelM = new System.Windows.Forms.Label();
            this.comboBoxNSize = new System.Windows.Forms.ComboBox();
            this.labelN = new System.Windows.Forms.Label();
            this.groupBoxGaussDomeParameters = new System.Windows.Forms.GroupBox();
            this.numericUpDownSigmaY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSigmaX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxThirdDome = new System.Windows.Forms.GroupBox();
            this.numericUpDownYShift3 = new System.Windows.Forms.NumericUpDown();
            this.labelYShift3 = new System.Windows.Forms.Label();
            this.numericUpDownXShift3 = new System.Windows.Forms.NumericUpDown();
            this.labelXShift3 = new System.Windows.Forms.Label();
            this.numericUpDownAmplitude3 = new System.Windows.Forms.NumericUpDown();
            this.labelAmplitude3 = new System.Windows.Forms.Label();
            this.groupBoxSecondDome = new System.Windows.Forms.GroupBox();
            this.numericUpDownYShift2 = new System.Windows.Forms.NumericUpDown();
            this.labelYShift2 = new System.Windows.Forms.Label();
            this.numericUpDownXShift2 = new System.Windows.Forms.NumericUpDown();
            this.labelXShift2 = new System.Windows.Forms.Label();
            this.numericUpDownAmplitude2 = new System.Windows.Forms.NumericUpDown();
            this.labelAmplitude2 = new System.Windows.Forms.Label();
            this.groupBoxFirstDome = new System.Windows.Forms.GroupBox();
            this.numericUpDownYShift1 = new System.Windows.Forms.NumericUpDown();
            this.labelYShift1 = new System.Windows.Forms.Label();
            this.numericUpDownXShift1 = new System.Windows.Forms.NumericUpDown();
            this.labelXShift1 = new System.Windows.Forms.Label();
            this.numericUpDownAmplitude1 = new System.Windows.Forms.NumericUpDown();
            this.labelAmplitude1 = new System.Windows.Forms.Label();
            this.checkBoxChoiceImage = new System.Windows.Forms.CheckBox();
            this.groupBoxOutputParameters = new System.Windows.Forms.GroupBox();
            this.textBoxSignalRecoveryDelta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSignalNoiseDelta = new System.Windows.Forms.TextBox();
            this.labelSKOSignalNoise = new System.Windows.Forms.Label();
            this.openFileDialogLoadImageInput = new System.Windows.Forms.OpenFileDialog();
            this.button_Restart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_NoiseProcent = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRecoveryProcent = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxInputParameters.SuspendLayout();
            this.groupBoxHowComplement.SuspendLayout();
            this.groupBoxGaussParameters.SuspendLayout();
            this.groupBoxInputSize.SuspendLayout();
            this.groupBoxGaussDomeParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigmaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigmaX)).BeginInit();
            this.groupBoxThirdDome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYShift3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXShift3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude3)).BeginInit();
            this.groupBoxSecondDome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYShift2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXShift2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude2)).BeginInit();
            this.groupBoxFirstDome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYShift1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXShift1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude1)).BeginInit();
            this.groupBoxOutputParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NoiseProcent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecoveryProcent)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Draw
            // 
            this.button_Draw.Location = new System.Drawing.Point(6, 507);
            this.button_Draw.Name = "button_Draw";
            this.button_Draw.Size = new System.Drawing.Size(133, 42);
            this.button_Draw.TabIndex = 1;
            this.button_Draw.Text = "Сгенерировать картинку";
            this.button_Draw.UseVisualStyleBackColor = true;
            this.button_Draw.Click += new System.EventHandler(this.button_Draw_Click);
            // 
            // button_DrawSpectrImage
            // 
            this.button_DrawSpectrImage.Enabled = false;
            this.button_DrawSpectrImage.Location = new System.Drawing.Point(12, 600);
            this.button_DrawSpectrImage.Name = "button_DrawSpectrImage";
            this.button_DrawSpectrImage.Size = new System.Drawing.Size(145, 42);
            this.button_DrawSpectrImage.TabIndex = 3;
            this.button_DrawSpectrImage.Text = "Нарисовать спектр изображения";
            this.button_DrawSpectrImage.UseVisualStyleBackColor = true;
            this.button_DrawSpectrImage.Click += new System.EventHandler(this.button_DrawSpectrImage_Click);
            // 
            // button_Recovery
            // 
            this.button_Recovery.Enabled = false;
            this.button_Recovery.Location = new System.Drawing.Point(163, 600);
            this.button_Recovery.Name = "button_Recovery";
            this.button_Recovery.Size = new System.Drawing.Size(145, 42);
            this.button_Recovery.TabIndex = 5;
            this.button_Recovery.Text = "Восстановить изображение";
            this.button_Recovery.UseVisualStyleBackColor = true;
            this.button_Recovery.Click += new System.EventHandler(this.button_Recovery_Click);
            // 
            // groupBoxInputParameters
            // 
            this.groupBoxInputParameters.Controls.Add(this.numericUpDownRecoveryProcent);
            this.groupBoxInputParameters.Controls.Add(this.label5);
            this.groupBoxInputParameters.Controls.Add(this.numericUpDown_NoiseProcent);
            this.groupBoxInputParameters.Controls.Add(this.label4);
            this.groupBoxInputParameters.Controls.Add(this.buttonDrawNoisyImage);
            this.groupBoxInputParameters.Controls.Add(this.groupBoxHowComplement);
            this.groupBoxInputParameters.Controls.Add(this.groupBoxGaussParameters);
            this.groupBoxInputParameters.Controls.Add(this.checkBoxChoiceImage);
            this.groupBoxInputParameters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInputParameters.Name = "groupBoxInputParameters";
            this.groupBoxInputParameters.Size = new System.Drawing.Size(454, 582);
            this.groupBoxInputParameters.TabIndex = 6;
            this.groupBoxInputParameters.TabStop = false;
            this.groupBoxInputParameters.Text = "Входные параметры";
            // 
            // buttonDrawNoisyImage
            // 
            this.buttonDrawNoisyImage.Enabled = false;
            this.buttonDrawNoisyImage.Location = new System.Drawing.Point(267, 496);
            this.buttonDrawNoisyImage.Name = "buttonDrawNoisyImage";
            this.buttonDrawNoisyImage.Size = new System.Drawing.Size(145, 65);
            this.buttonDrawNoisyImage.TabIndex = 8;
            this.buttonDrawNoisyImage.Text = "Нарисовать зашумлённое изображение";
            this.buttonDrawNoisyImage.UseVisualStyleBackColor = true;
            this.buttonDrawNoisyImage.Click += new System.EventHandler(this.buttonDrawNoisyImage_Click);
            // 
            // groupBoxHowComplement
            // 
            this.groupBoxHowComplement.Controls.Add(this.checkBoxBilinearInterpolation);
            this.groupBoxHowComplement.Controls.Add(this.checkBoxZeroCoplement);
            this.groupBoxHowComplement.Location = new System.Drawing.Point(245, 42);
            this.groupBoxHowComplement.Name = "groupBoxHowComplement";
            this.groupBoxHowComplement.Size = new System.Drawing.Size(200, 71);
            this.groupBoxHowComplement.TabIndex = 4;
            this.groupBoxHowComplement.TabStop = false;
            this.groupBoxHowComplement.Text = "Как дополнить изображение?";
            // 
            // checkBoxBilinearInterpolation
            // 
            this.checkBoxBilinearInterpolation.AutoSize = true;
            this.checkBoxBilinearInterpolation.Location = new System.Drawing.Point(6, 43);
            this.checkBoxBilinearInterpolation.Name = "checkBoxBilinearInterpolation";
            this.checkBoxBilinearInterpolation.Size = new System.Drawing.Size(161, 17);
            this.checkBoxBilinearInterpolation.TabIndex = 1;
            this.checkBoxBilinearInterpolation.Text = "Билинейная интерполяция";
            this.checkBoxBilinearInterpolation.UseVisualStyleBackColor = true;
            this.checkBoxBilinearInterpolation.CheckedChanged += new System.EventHandler(this.checkBoxBilinearInterpolation_CheckedChanged);
            // 
            // checkBoxZeroCoplement
            // 
            this.checkBoxZeroCoplement.AutoSize = true;
            this.checkBoxZeroCoplement.Location = new System.Drawing.Point(6, 20);
            this.checkBoxZeroCoplement.Name = "checkBoxZeroCoplement";
            this.checkBoxZeroCoplement.Size = new System.Drawing.Size(122, 17);
            this.checkBoxZeroCoplement.TabIndex = 0;
            this.checkBoxZeroCoplement.Text = "Дополнить нулями";
            this.checkBoxZeroCoplement.UseVisualStyleBackColor = true;
            this.checkBoxZeroCoplement.CheckedChanged += new System.EventHandler(this.checkBoxZeroCoplement_CheckedChanged);
            // 
            // groupBoxGaussParameters
            // 
            this.groupBoxGaussParameters.Controls.Add(this.groupBoxInputSize);
            this.groupBoxGaussParameters.Controls.Add(this.groupBoxGaussDomeParameters);
            this.groupBoxGaussParameters.Controls.Add(this.button_Draw);
            this.groupBoxGaussParameters.Location = new System.Drawing.Point(6, 19);
            this.groupBoxGaussParameters.Name = "groupBoxGaussParameters";
            this.groupBoxGaussParameters.Size = new System.Drawing.Size(233, 557);
            this.groupBoxGaussParameters.TabIndex = 3;
            this.groupBoxGaussParameters.TabStop = false;
            this.groupBoxGaussParameters.Text = "Параметры генерируемого изображения";
            // 
            // groupBoxInputSize
            // 
            this.groupBoxInputSize.Controls.Add(this.comboBoxMSize);
            this.groupBoxInputSize.Controls.Add(this.labelM);
            this.groupBoxInputSize.Controls.Add(this.comboBoxNSize);
            this.groupBoxInputSize.Controls.Add(this.labelN);
            this.groupBoxInputSize.Location = new System.Drawing.Point(6, 19);
            this.groupBoxInputSize.Name = "groupBoxInputSize";
            this.groupBoxInputSize.Size = new System.Drawing.Size(201, 67);
            this.groupBoxInputSize.TabIndex = 0;
            this.groupBoxInputSize.TabStop = false;
            this.groupBoxInputSize.Text = "Размер изображения";
            // 
            // comboBoxMSize
            // 
            this.comboBoxMSize.FormattingEnabled = true;
            this.comboBoxMSize.Items.AddRange(new object[] {
            "256",
            "512",
            "1024"});
            this.comboBoxMSize.Location = new System.Drawing.Point(121, 26);
            this.comboBoxMSize.Name = "comboBoxMSize";
            this.comboBoxMSize.Size = new System.Drawing.Size(61, 21);
            this.comboBoxMSize.TabIndex = 3;
            this.comboBoxMSize.Text = "512";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(97, 29);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(19, 13);
            this.labelM.TabIndex = 2;
            this.labelM.Text = "M:";
            // 
            // comboBoxNSize
            // 
            this.comboBoxNSize.FormattingEnabled = true;
            this.comboBoxNSize.Items.AddRange(new object[] {
            "256",
            "512",
            "1024"});
            this.comboBoxNSize.Location = new System.Drawing.Point(30, 26);
            this.comboBoxNSize.Name = "comboBoxNSize";
            this.comboBoxNSize.Size = new System.Drawing.Size(61, 21);
            this.comboBoxNSize.TabIndex = 1;
            this.comboBoxNSize.Text = "512";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(6, 29);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(18, 13);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "N:";
            // 
            // groupBoxGaussDomeParameters
            // 
            this.groupBoxGaussDomeParameters.Controls.Add(this.numericUpDownSigmaY);
            this.groupBoxGaussDomeParameters.Controls.Add(this.label2);
            this.groupBoxGaussDomeParameters.Controls.Add(this.numericUpDownSigmaX);
            this.groupBoxGaussDomeParameters.Controls.Add(this.label1);
            this.groupBoxGaussDomeParameters.Controls.Add(this.groupBoxThirdDome);
            this.groupBoxGaussDomeParameters.Controls.Add(this.groupBoxSecondDome);
            this.groupBoxGaussDomeParameters.Controls.Add(this.groupBoxFirstDome);
            this.groupBoxGaussDomeParameters.Location = new System.Drawing.Point(6, 92);
            this.groupBoxGaussDomeParameters.Name = "groupBoxGaussDomeParameters";
            this.groupBoxGaussDomeParameters.Size = new System.Drawing.Size(201, 409);
            this.groupBoxGaussDomeParameters.TabIndex = 1;
            this.groupBoxGaussDomeParameters.TabStop = false;
            this.groupBoxGaussDomeParameters.Text = "Параметры Гауссовых куполов";
            // 
            // numericUpDownSigmaY
            // 
            this.numericUpDownSigmaY.DecimalPlaces = 1;
            this.numericUpDownSigmaY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSigmaY.Location = new System.Drawing.Point(65, 378);
            this.numericUpDownSigmaY.Name = "numericUpDownSigmaY";
            this.numericUpDownSigmaY.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownSigmaY.TabIndex = 6;
            this.numericUpDownSigmaY.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SigmaY:";
            // 
            // numericUpDownSigmaX
            // 
            this.numericUpDownSigmaX.DecimalPlaces = 1;
            this.numericUpDownSigmaX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSigmaX.Location = new System.Drawing.Point(65, 352);
            this.numericUpDownSigmaX.Name = "numericUpDownSigmaX";
            this.numericUpDownSigmaX.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownSigmaX.TabIndex = 4;
            this.numericUpDownSigmaX.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SigmaX:";
            // 
            // groupBoxThirdDome
            // 
            this.groupBoxThirdDome.Controls.Add(this.numericUpDownYShift3);
            this.groupBoxThirdDome.Controls.Add(this.labelYShift3);
            this.groupBoxThirdDome.Controls.Add(this.numericUpDownXShift3);
            this.groupBoxThirdDome.Controls.Add(this.labelXShift3);
            this.groupBoxThirdDome.Controls.Add(this.numericUpDownAmplitude3);
            this.groupBoxThirdDome.Controls.Add(this.labelAmplitude3);
            this.groupBoxThirdDome.Location = new System.Drawing.Point(6, 235);
            this.groupBoxThirdDome.Name = "groupBoxThirdDome";
            this.groupBoxThirdDome.Size = new System.Drawing.Size(189, 102);
            this.groupBoxThirdDome.TabIndex = 2;
            this.groupBoxThirdDome.TabStop = false;
            this.groupBoxThirdDome.Text = "3-ий купол";
            // 
            // numericUpDownYShift3
            // 
            this.numericUpDownYShift3.Location = new System.Drawing.Point(78, 70);
            this.numericUpDownYShift3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownYShift3.Name = "numericUpDownYShift3";
            this.numericUpDownYShift3.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownYShift3.TabIndex = 5;
            this.numericUpDownYShift3.Value = new decimal(new int[] {
            260,
            0,
            0,
            0});
            // 
            // labelYShift3
            // 
            this.labelYShift3.AutoSize = true;
            this.labelYShift3.Location = new System.Drawing.Point(7, 72);
            this.labelYShift3.Name = "labelYShift3";
            this.labelYShift3.Size = new System.Drawing.Size(65, 13);
            this.labelYShift3.TabIndex = 4;
            this.labelYShift3.Text = "Сдвиг по Y:";
            // 
            // numericUpDownXShift3
            // 
            this.numericUpDownXShift3.Location = new System.Drawing.Point(78, 44);
            this.numericUpDownXShift3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownXShift3.Name = "numericUpDownXShift3";
            this.numericUpDownXShift3.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownXShift3.TabIndex = 3;
            this.numericUpDownXShift3.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            // 
            // labelXShift3
            // 
            this.labelXShift3.AutoSize = true;
            this.labelXShift3.Location = new System.Drawing.Point(7, 46);
            this.labelXShift3.Name = "labelXShift3";
            this.labelXShift3.Size = new System.Drawing.Size(65, 13);
            this.labelXShift3.TabIndex = 2;
            this.labelXShift3.Text = "Сдвиг по X:";
            // 
            // numericUpDownAmplitude3
            // 
            this.numericUpDownAmplitude3.DecimalPlaces = 3;
            this.numericUpDownAmplitude3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownAmplitude3.Location = new System.Drawing.Point(78, 18);
            this.numericUpDownAmplitude3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmplitude3.Name = "numericUpDownAmplitude3";
            this.numericUpDownAmplitude3.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownAmplitude3.TabIndex = 1;
            this.numericUpDownAmplitude3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelAmplitude3
            // 
            this.labelAmplitude3.AutoSize = true;
            this.labelAmplitude3.Location = new System.Drawing.Point(7, 20);
            this.labelAmplitude3.Name = "labelAmplitude3";
            this.labelAmplitude3.Size = new System.Drawing.Size(65, 13);
            this.labelAmplitude3.TabIndex = 0;
            this.labelAmplitude3.Text = "Амплитуда:";
            // 
            // groupBoxSecondDome
            // 
            this.groupBoxSecondDome.Controls.Add(this.numericUpDownYShift2);
            this.groupBoxSecondDome.Controls.Add(this.labelYShift2);
            this.groupBoxSecondDome.Controls.Add(this.numericUpDownXShift2);
            this.groupBoxSecondDome.Controls.Add(this.labelXShift2);
            this.groupBoxSecondDome.Controls.Add(this.numericUpDownAmplitude2);
            this.groupBoxSecondDome.Controls.Add(this.labelAmplitude2);
            this.groupBoxSecondDome.Location = new System.Drawing.Point(6, 127);
            this.groupBoxSecondDome.Name = "groupBoxSecondDome";
            this.groupBoxSecondDome.Size = new System.Drawing.Size(189, 102);
            this.groupBoxSecondDome.TabIndex = 1;
            this.groupBoxSecondDome.TabStop = false;
            this.groupBoxSecondDome.Text = "2-ой купол";
            // 
            // numericUpDownYShift2
            // 
            this.numericUpDownYShift2.Location = new System.Drawing.Point(78, 70);
            this.numericUpDownYShift2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownYShift2.Name = "numericUpDownYShift2";
            this.numericUpDownYShift2.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownYShift2.TabIndex = 5;
            this.numericUpDownYShift2.Value = new decimal(new int[] {
            260,
            0,
            0,
            0});
            // 
            // labelYShift2
            // 
            this.labelYShift2.AutoSize = true;
            this.labelYShift2.Location = new System.Drawing.Point(7, 72);
            this.labelYShift2.Name = "labelYShift2";
            this.labelYShift2.Size = new System.Drawing.Size(65, 13);
            this.labelYShift2.TabIndex = 4;
            this.labelYShift2.Text = "Сдвиг по Y:";
            // 
            // numericUpDownXShift2
            // 
            this.numericUpDownXShift2.Location = new System.Drawing.Point(78, 44);
            this.numericUpDownXShift2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownXShift2.Name = "numericUpDownXShift2";
            this.numericUpDownXShift2.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownXShift2.TabIndex = 3;
            this.numericUpDownXShift2.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // labelXShift2
            // 
            this.labelXShift2.AutoSize = true;
            this.labelXShift2.Location = new System.Drawing.Point(7, 46);
            this.labelXShift2.Name = "labelXShift2";
            this.labelXShift2.Size = new System.Drawing.Size(65, 13);
            this.labelXShift2.TabIndex = 2;
            this.labelXShift2.Text = "Сдвиг по X:";
            // 
            // numericUpDownAmplitude2
            // 
            this.numericUpDownAmplitude2.DecimalPlaces = 3;
            this.numericUpDownAmplitude2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownAmplitude2.Location = new System.Drawing.Point(78, 18);
            this.numericUpDownAmplitude2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmplitude2.Name = "numericUpDownAmplitude2";
            this.numericUpDownAmplitude2.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownAmplitude2.TabIndex = 1;
            this.numericUpDownAmplitude2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelAmplitude2
            // 
            this.labelAmplitude2.AutoSize = true;
            this.labelAmplitude2.Location = new System.Drawing.Point(7, 20);
            this.labelAmplitude2.Name = "labelAmplitude2";
            this.labelAmplitude2.Size = new System.Drawing.Size(65, 13);
            this.labelAmplitude2.TabIndex = 0;
            this.labelAmplitude2.Text = "Амплитуда:";
            // 
            // groupBoxFirstDome
            // 
            this.groupBoxFirstDome.Controls.Add(this.numericUpDownYShift1);
            this.groupBoxFirstDome.Controls.Add(this.labelYShift1);
            this.groupBoxFirstDome.Controls.Add(this.numericUpDownXShift1);
            this.groupBoxFirstDome.Controls.Add(this.labelXShift1);
            this.groupBoxFirstDome.Controls.Add(this.numericUpDownAmplitude1);
            this.groupBoxFirstDome.Controls.Add(this.labelAmplitude1);
            this.groupBoxFirstDome.Location = new System.Drawing.Point(6, 19);
            this.groupBoxFirstDome.Name = "groupBoxFirstDome";
            this.groupBoxFirstDome.Size = new System.Drawing.Size(189, 102);
            this.groupBoxFirstDome.TabIndex = 0;
            this.groupBoxFirstDome.TabStop = false;
            this.groupBoxFirstDome.Text = "1-ый купол";
            // 
            // numericUpDownYShift1
            // 
            this.numericUpDownYShift1.Location = new System.Drawing.Point(78, 70);
            this.numericUpDownYShift1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownYShift1.Name = "numericUpDownYShift1";
            this.numericUpDownYShift1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownYShift1.TabIndex = 5;
            this.numericUpDownYShift1.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // labelYShift1
            // 
            this.labelYShift1.AutoSize = true;
            this.labelYShift1.Location = new System.Drawing.Point(7, 72);
            this.labelYShift1.Name = "labelYShift1";
            this.labelYShift1.Size = new System.Drawing.Size(65, 13);
            this.labelYShift1.TabIndex = 4;
            this.labelYShift1.Text = "Сдвиг по Y:";
            // 
            // numericUpDownXShift1
            // 
            this.numericUpDownXShift1.Location = new System.Drawing.Point(78, 44);
            this.numericUpDownXShift1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownXShift1.Name = "numericUpDownXShift1";
            this.numericUpDownXShift1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownXShift1.TabIndex = 3;
            this.numericUpDownXShift1.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // labelXShift1
            // 
            this.labelXShift1.AutoSize = true;
            this.labelXShift1.Location = new System.Drawing.Point(7, 46);
            this.labelXShift1.Name = "labelXShift1";
            this.labelXShift1.Size = new System.Drawing.Size(65, 13);
            this.labelXShift1.TabIndex = 2;
            this.labelXShift1.Text = "Сдвиг по X:";
            // 
            // numericUpDownAmplitude1
            // 
            this.numericUpDownAmplitude1.DecimalPlaces = 3;
            this.numericUpDownAmplitude1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownAmplitude1.Location = new System.Drawing.Point(78, 18);
            this.numericUpDownAmplitude1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmplitude1.Name = "numericUpDownAmplitude1";
            this.numericUpDownAmplitude1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownAmplitude1.TabIndex = 1;
            this.numericUpDownAmplitude1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelAmplitude1
            // 
            this.labelAmplitude1.AutoSize = true;
            this.labelAmplitude1.Location = new System.Drawing.Point(7, 20);
            this.labelAmplitude1.Name = "labelAmplitude1";
            this.labelAmplitude1.Size = new System.Drawing.Size(65, 13);
            this.labelAmplitude1.TabIndex = 0;
            this.labelAmplitude1.Text = "Амплитуда:";
            // 
            // checkBoxChoiceImage
            // 
            this.checkBoxChoiceImage.AutoSize = true;
            this.checkBoxChoiceImage.Location = new System.Drawing.Point(245, 19);
            this.checkBoxChoiceImage.Name = "checkBoxChoiceImage";
            this.checkBoxChoiceImage.Size = new System.Drawing.Size(149, 17);
            this.checkBoxChoiceImage.TabIndex = 2;
            this.checkBoxChoiceImage.Text = "Загрузить изображение";
            this.checkBoxChoiceImage.UseVisualStyleBackColor = true;
            this.checkBoxChoiceImage.CheckedChanged += new System.EventHandler(this.checkBoxChoiceImage_CheckedChanged);
            // 
            // groupBoxOutputParameters
            // 
            this.groupBoxOutputParameters.Controls.Add(this.textBoxSignalRecoveryDelta);
            this.groupBoxOutputParameters.Controls.Add(this.label3);
            this.groupBoxOutputParameters.Controls.Add(this.textBoxSignalNoiseDelta);
            this.groupBoxOutputParameters.Controls.Add(this.labelSKOSignalNoise);
            this.groupBoxOutputParameters.Location = new System.Drawing.Point(472, 12);
            this.groupBoxOutputParameters.Name = "groupBoxOutputParameters";
            this.groupBoxOutputParameters.Size = new System.Drawing.Size(348, 86);
            this.groupBoxOutputParameters.TabIndex = 7;
            this.groupBoxOutputParameters.TabStop = false;
            this.groupBoxOutputParameters.Text = "Выходные параметры";
            // 
            // textBoxSignalRecoveryDelta
            // 
            this.textBoxSignalRecoveryDelta.Location = new System.Drawing.Point(255, 45);
            this.textBoxSignalRecoveryDelta.Name = "textBoxSignalRecoveryDelta";
            this.textBoxSignalRecoveryDelta.ReadOnly = true;
            this.textBoxSignalRecoveryDelta.Size = new System.Drawing.Size(84, 20);
            this.textBoxSignalRecoveryDelta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "СКО ( исходного сигнала и восстановленного):";
            // 
            // textBoxSignalNoiseDelta
            // 
            this.textBoxSignalNoiseDelta.Location = new System.Drawing.Point(255, 19);
            this.textBoxSignalNoiseDelta.Name = "textBoxSignalNoiseDelta";
            this.textBoxSignalNoiseDelta.ReadOnly = true;
            this.textBoxSignalNoiseDelta.Size = new System.Drawing.Size(84, 20);
            this.textBoxSignalNoiseDelta.TabIndex = 1;
            // 
            // labelSKOSignalNoise
            // 
            this.labelSKOSignalNoise.AutoSize = true;
            this.labelSKOSignalNoise.Location = new System.Drawing.Point(6, 22);
            this.labelSKOSignalNoise.Name = "labelSKOSignalNoise";
            this.labelSKOSignalNoise.Size = new System.Drawing.Size(226, 13);
            this.labelSKOSignalNoise.TabIndex = 0;
            this.labelSKOSignalNoise.Text = "СКО ( исходного сигнала и зашумленного):";
            // 
            // openFileDialogLoadImageInput
            // 
            this.openFileDialogLoadImageInput.FileName = "openFileDialog1";
            // 
            // button_Restart
            // 
            this.button_Restart.Location = new System.Drawing.Point(314, 600);
            this.button_Restart.Name = "button_Restart";
            this.button_Restart.Size = new System.Drawing.Size(145, 42);
            this.button_Restart.TabIndex = 8;
            this.button_Restart.Text = "Начать заново";
            this.button_Restart.UseVisualStyleBackColor = true;
            this.button_Restart.Click += new System.EventHandler(this.button_Restart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Энергия шума(%):";
            // 
            // numericUpDown_NoiseProcent
            // 
            this.numericUpDown_NoiseProcent.Enabled = false;
            this.numericUpDown_NoiseProcent.Location = new System.Drawing.Point(398, 118);
            this.numericUpDown_NoiseProcent.Name = "numericUpDown_NoiseProcent";
            this.numericUpDown_NoiseProcent.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown_NoiseProcent.TabIndex = 10;
            this.numericUpDown_NoiseProcent.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownRecoveryProcent
            // 
            this.numericUpDownRecoveryProcent.Enabled = false;
            this.numericUpDownRecoveryProcent.Location = new System.Drawing.Point(398, 143);
            this.numericUpDownRecoveryProcent.Name = "numericUpDownRecoveryProcent";
            this.numericUpDownRecoveryProcent.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownRecoveryProcent.TabIndex = 12;
            this.numericUpDownRecoveryProcent.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Энергия восстановления(%):";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 735);
            this.Controls.Add(this.button_Restart);
            this.Controls.Add(this.groupBoxOutputParameters);
            this.Controls.Add(this.groupBoxInputParameters);
            this.Controls.Add(this.button_Recovery);
            this.Controls.Add(this.button_DrawSpectrImage);
            this.Name = "MainWindow";
            this.Text = "ННГУ ИТФИ | Обработка изображения двумерным преобразованием Фурье";
            this.groupBoxInputParameters.ResumeLayout(false);
            this.groupBoxInputParameters.PerformLayout();
            this.groupBoxHowComplement.ResumeLayout(false);
            this.groupBoxHowComplement.PerformLayout();
            this.groupBoxGaussParameters.ResumeLayout(false);
            this.groupBoxInputSize.ResumeLayout(false);
            this.groupBoxInputSize.PerformLayout();
            this.groupBoxGaussDomeParameters.ResumeLayout(false);
            this.groupBoxGaussDomeParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigmaY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigmaX)).EndInit();
            this.groupBoxThirdDome.ResumeLayout(false);
            this.groupBoxThirdDome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYShift3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXShift3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude3)).EndInit();
            this.groupBoxSecondDome.ResumeLayout(false);
            this.groupBoxSecondDome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYShift2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXShift2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude2)).EndInit();
            this.groupBoxFirstDome.ResumeLayout(false);
            this.groupBoxFirstDome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYShift1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXShift1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude1)).EndInit();
            this.groupBoxOutputParameters.ResumeLayout(false);
            this.groupBoxOutputParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NoiseProcent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecoveryProcent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Draw;
        private System.Windows.Forms.Button button_DrawSpectrImage;
        private System.Windows.Forms.Button button_Recovery;
        private System.Windows.Forms.GroupBox groupBoxInputParameters;
        private System.Windows.Forms.GroupBox groupBoxInputSize;
        private System.Windows.Forms.ComboBox comboBoxMSize;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.ComboBox comboBoxNSize;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.GroupBox groupBoxGaussDomeParameters;
        private System.Windows.Forms.GroupBox groupBoxFirstDome;
        private System.Windows.Forms.NumericUpDown numericUpDownSigmaY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSigmaX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxThirdDome;
        private System.Windows.Forms.NumericUpDown numericUpDownYShift3;
        private System.Windows.Forms.Label labelYShift3;
        private System.Windows.Forms.NumericUpDown numericUpDownXShift3;
        private System.Windows.Forms.Label labelXShift3;
        private System.Windows.Forms.NumericUpDown numericUpDownAmplitude3;
        private System.Windows.Forms.Label labelAmplitude3;
        private System.Windows.Forms.GroupBox groupBoxSecondDome;
        private System.Windows.Forms.NumericUpDown numericUpDownYShift2;
        private System.Windows.Forms.Label labelYShift2;
        private System.Windows.Forms.NumericUpDown numericUpDownXShift2;
        private System.Windows.Forms.Label labelXShift2;
        private System.Windows.Forms.NumericUpDown numericUpDownAmplitude2;
        private System.Windows.Forms.Label labelAmplitude2;
        private System.Windows.Forms.NumericUpDown numericUpDownYShift1;
        private System.Windows.Forms.Label labelYShift1;
        private System.Windows.Forms.NumericUpDown numericUpDownXShift1;
        private System.Windows.Forms.Label labelXShift1;
        private System.Windows.Forms.NumericUpDown numericUpDownAmplitude1;
        private System.Windows.Forms.Label labelAmplitude1;
        private System.Windows.Forms.GroupBox groupBoxOutputParameters;
        private System.Windows.Forms.TextBox textBoxSignalRecoveryDelta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSignalNoiseDelta;
        private System.Windows.Forms.Label labelSKOSignalNoise;
        private System.Windows.Forms.CheckBox checkBoxChoiceImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoadImageInput;
        private System.Windows.Forms.GroupBox groupBoxGaussParameters;
        private System.Windows.Forms.GroupBox groupBoxHowComplement;
        private System.Windows.Forms.CheckBox checkBoxBilinearInterpolation;
        private System.Windows.Forms.CheckBox checkBoxZeroCoplement;
        private System.Windows.Forms.Button buttonDrawNoisyImage;
        private System.Windows.Forms.Button button_Restart;
        private System.Windows.Forms.NumericUpDown numericUpDown_NoiseProcent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownRecoveryProcent;
        private System.Windows.Forms.Label label5;
    }
}

