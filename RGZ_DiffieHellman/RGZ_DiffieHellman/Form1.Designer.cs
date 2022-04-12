namespace RGZ_DiffieHellman
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rabinMillerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countBitsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.primeNumber10Box = new System.Windows.Forms.TextBox();
            this.primeNumber2Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minBitBox = new System.Windows.Forms.TextBox();
            this.maxBitBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rabinMillerNumsBox = new System.Windows.Forms.TextBox();
            this.primeNumbers10Box = new System.Windows.Forms.TextBox();
            this.primeNumbers2Box = new System.Windows.Forms.TextBox();
            this.generatePrimeNumButton = new System.Windows.Forms.Button();
            this.generatePrimeNumsButton = new System.Windows.Forms.Button();
            this.timeIterationBox = new System.Windows.Forms.TextBox();
            this.timeRootsBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.countPrimitiveRootBox = new System.Windows.Forms.TextBox();
            this.generatePrimeRootsButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.XaBox = new System.Windows.Forms.TextBox();
            this.XbBox = new System.Windows.Forms.TextBox();
            this.NBox = new System.Windows.Forms.TextBox();
            this.timeIterationNumsBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.diffieHellmanButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.diffieHellmanRandomButton = new System.Windows.Forms.Button();
            this.primeRootsBox = new System.Windows.Forms.TextBox();
            this.gBox = new System.Windows.Forms.TextBox();
            this.YaBox = new System.Windows.Forms.TextBox();
            this.YbBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.KaBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.KbBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rabinMillerBox
            // 
            this.rabinMillerBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rabinMillerBox.Location = new System.Drawing.Point(12, 37);
            this.rabinMillerBox.Name = "rabinMillerBox";
            this.rabinMillerBox.Size = new System.Drawing.Size(360, 25);
            this.rabinMillerBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество проверок в тесте Рабина-Миллера (t)";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество бит";
            // 
            // countBitsBox
            // 
            this.countBitsBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.countBitsBox.Location = new System.Drawing.Point(12, 102);
            this.countBitsBox.Name = "countBitsBox";
            this.countBitsBox.Size = new System.Drawing.Size(360, 25);
            this.countBitsBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Простое число в 10 системе";
            // 
            // primeNumber10Box
            // 
            this.primeNumber10Box.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.primeNumber10Box.Location = new System.Drawing.Point(12, 173);
            this.primeNumber10Box.Multiline = true;
            this.primeNumber10Box.Name = "primeNumber10Box";
            this.primeNumber10Box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.primeNumber10Box.Size = new System.Drawing.Size(667, 62);
            this.primeNumber10Box.TabIndex = 5;
            this.primeNumber10Box.TextChanged += new System.EventHandler(this.primeNumber10Box_TextChanged);
            // 
            // primeNumber2Box
            // 
            this.primeNumber2Box.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.primeNumber2Box.Location = new System.Drawing.Point(15, 266);
            this.primeNumber2Box.Multiline = true;
            this.primeNumber2Box.Name = "primeNumber2Box";
            this.primeNumber2Box.ReadOnly = true;
            this.primeNumber2Box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.primeNumber2Box.Size = new System.Drawing.Size(664, 62);
            this.primeNumber2Box.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Простое число в 2 системе";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Количество проверок в тесте Рабина-Миллера (t)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Минимальное и Максимальное чило бит";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minBitBox
            // 
            this.minBitBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minBitBox.Location = new System.Drawing.Point(12, 415);
            this.minBitBox.Name = "minBitBox";
            this.minBitBox.Size = new System.Drawing.Size(173, 25);
            this.minBitBox.TabIndex = 10;
            // 
            // maxBitBox
            // 
            this.maxBitBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxBitBox.Location = new System.Drawing.Point(199, 415);
            this.maxBitBox.Name = "maxBitBox";
            this.maxBitBox.Size = new System.Drawing.Size(173, 25);
            this.maxBitBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Простые числа в 10 системе";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 569);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(363, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Простые числа в 2 системе";
            // 
            // rabinMillerNumsBox
            // 
            this.rabinMillerNumsBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rabinMillerNumsBox.Location = new System.Drawing.Point(12, 359);
            this.rabinMillerNumsBox.Name = "rabinMillerNumsBox";
            this.rabinMillerNumsBox.Size = new System.Drawing.Size(360, 25);
            this.rabinMillerNumsBox.TabIndex = 14;
            // 
            // primeNumbers10Box
            // 
            this.primeNumbers10Box.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.primeNumbers10Box.Location = new System.Drawing.Point(15, 492);
            this.primeNumbers10Box.Multiline = true;
            this.primeNumbers10Box.Name = "primeNumbers10Box";
            this.primeNumbers10Box.ReadOnly = true;
            this.primeNumbers10Box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.primeNumbers10Box.Size = new System.Drawing.Size(664, 62);
            this.primeNumbers10Box.TabIndex = 15;
            // 
            // primeNumbers2Box
            // 
            this.primeNumbers2Box.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.primeNumbers2Box.Location = new System.Drawing.Point(15, 597);
            this.primeNumbers2Box.Multiline = true;
            this.primeNumbers2Box.Name = "primeNumbers2Box";
            this.primeNumbers2Box.ReadOnly = true;
            this.primeNumbers2Box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.primeNumbers2Box.Size = new System.Drawing.Size(664, 62);
            this.primeNumbers2Box.TabIndex = 16;
            // 
            // generatePrimeNumButton
            // 
            this.generatePrimeNumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePrimeNumButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generatePrimeNumButton.Location = new System.Drawing.Point(234, 133);
            this.generatePrimeNumButton.Name = "generatePrimeNumButton";
            this.generatePrimeNumButton.Size = new System.Drawing.Size(141, 34);
            this.generatePrimeNumButton.TabIndex = 17;
            this.generatePrimeNumButton.Text = "Генерировать";
            this.generatePrimeNumButton.UseVisualStyleBackColor = true;
            this.generatePrimeNumButton.Click += new System.EventHandler(this.generatePrimeNumButton_Click);
            // 
            // generatePrimeNumsButton
            // 
            this.generatePrimeNumsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePrimeNumsButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generatePrimeNumsButton.Location = new System.Drawing.Point(231, 452);
            this.generatePrimeNumsButton.Name = "generatePrimeNumsButton";
            this.generatePrimeNumsButton.Size = new System.Drawing.Size(141, 34);
            this.generatePrimeNumsButton.TabIndex = 18;
            this.generatePrimeNumsButton.Text = "Генерировать";
            this.generatePrimeNumsButton.UseVisualStyleBackColor = true;
            this.generatePrimeNumsButton.Click += new System.EventHandler(this.generatePrimeNumsButton_Click);
            // 
            // timeIterationBox
            // 
            this.timeIterationBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeIterationBox.Location = new System.Drawing.Point(404, 79);
            this.timeIterationBox.Multiline = true;
            this.timeIterationBox.Name = "timeIterationBox";
            this.timeIterationBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.timeIterationBox.Size = new System.Drawing.Size(141, 88);
            this.timeIterationBox.TabIndex = 19;
            // 
            // timeRootsBox
            // 
            this.timeRootsBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeRootsBox.Location = new System.Drawing.Point(563, 79);
            this.timeRootsBox.Multiline = true;
            this.timeRootsBox.Name = "timeRootsBox";
            this.timeRootsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.timeRootsBox.Size = new System.Drawing.Size(149, 88);
            this.timeRootsBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(404, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 62);
            this.label9.TabIndex = 21;
            this.label9.Text = "Время и количество итераций при генерации простого числа(слева) и первообразных к" +
    "орней(справа)";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(756, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(516, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Количество первообразных корней";
            // 
            // countPrimitiveRootBox
            // 
            this.countPrimitiveRootBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.countPrimitiveRootBox.Location = new System.Drawing.Point(756, 37);
            this.countPrimitiveRootBox.Name = "countPrimitiveRootBox";
            this.countPrimitiveRootBox.Size = new System.Drawing.Size(516, 25);
            this.countPrimitiveRootBox.TabIndex = 23;
            // 
            // generatePrimeRootsButton
            // 
            this.generatePrimeRootsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePrimeRootsButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generatePrimeRootsButton.Location = new System.Drawing.Point(756, 68);
            this.generatePrimeRootsButton.Name = "generatePrimeRootsButton";
            this.generatePrimeRootsButton.Size = new System.Drawing.Size(516, 34);
            this.generatePrimeRootsButton.TabIndex = 24;
            this.generatePrimeRootsButton.Text = "Генерировать";
            this.generatePrimeRootsButton.UseVisualStyleBackColor = true;
            this.generatePrimeRootsButton.Click += new System.EventHandler(this.generatePrimeRootsButton_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(756, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(516, 29);
            this.label11.TabIndex = 25;
            this.label11.Text = "Первообразные корни";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(756, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(516, 29);
            this.label12.TabIndex = 27;
            this.label12.Text = "Схема Диффи-Хеллмана";
            // 
            // XaBox
            // 
            this.XaBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.XaBox.Location = new System.Drawing.Point(756, 373);
            this.XaBox.Name = "XaBox";
            this.XaBox.Size = new System.Drawing.Size(516, 25);
            this.XaBox.TabIndex = 28;
            this.XaBox.Text = "36";
            // 
            // XbBox
            // 
            this.XbBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.XbBox.Location = new System.Drawing.Point(756, 415);
            this.XbBox.Name = "XbBox";
            this.XbBox.Size = new System.Drawing.Size(516, 25);
            this.XbBox.TabIndex = 29;
            this.XbBox.Text = "58";
            // 
            // NBox
            // 
            this.NBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NBox.Location = new System.Drawing.Point(756, 452);
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(516, 25);
            this.NBox.TabIndex = 30;
            this.NBox.Text = "97";
            // 
            // timeIterationNumsBox
            // 
            this.timeIterationNumsBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeIterationNumsBox.Location = new System.Drawing.Point(394, 405);
            this.timeIterationNumsBox.Multiline = true;
            this.timeIterationNumsBox.Name = "timeIterationNumsBox";
            this.timeIterationNumsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.timeIterationNumsBox.Size = new System.Drawing.Size(285, 81);
            this.timeIterationNumsBox.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(394, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(284, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Время при генерации простых чисел";
            // 
            // diffieHellmanButton
            // 
            this.diffieHellmanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diffieHellmanButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.diffieHellmanButton.Location = new System.Drawing.Point(756, 520);
            this.diffieHellmanButton.Name = "diffieHellmanButton";
            this.diffieHellmanButton.Size = new System.Drawing.Size(516, 34);
            this.diffieHellmanButton.TabIndex = 33;
            this.diffieHellmanButton.Text = "Генерировать";
            this.diffieHellmanButton.UseVisualStyleBackColor = true;
            this.diffieHellmanButton.Click += new System.EventHandler(this.diffieHellmanButton_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(717, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 26);
            this.label14.TabIndex = 34;
            this.label14.Text = "Xa";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(717, 415);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 25);
            this.label15.TabIndex = 35;
            this.label15.Text = "Xb";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(717, 452);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 25);
            this.label16.TabIndex = 36;
            this.label16.Text = "N";
            // 
            // diffieHellmanRandomButton
            // 
            this.diffieHellmanRandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diffieHellmanRandomButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.diffieHellmanRandomButton.Location = new System.Drawing.Point(936, 326);
            this.diffieHellmanRandomButton.Name = "diffieHellmanRandomButton";
            this.diffieHellmanRandomButton.Size = new System.Drawing.Size(336, 34);
            this.diffieHellmanRandomButton.TabIndex = 38;
            this.diffieHellmanRandomButton.Text = "Случайная генерация";
            this.diffieHellmanRandomButton.UseVisualStyleBackColor = true;
            this.diffieHellmanRandomButton.Click += new System.EventHandler(this.diffieHellmanRandomButton_Click);
            // 
            // primeRootsBox
            // 
            this.primeRootsBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.primeRootsBox.Location = new System.Drawing.Point(756, 133);
            this.primeRootsBox.Multiline = true;
            this.primeRootsBox.Name = "primeRootsBox";
            this.primeRootsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.primeRootsBox.Size = new System.Drawing.Size(516, 185);
            this.primeRootsBox.TabIndex = 26;
            // 
            // gBox
            // 
            this.gBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBox.Location = new System.Drawing.Point(756, 483);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(516, 25);
            this.gBox.TabIndex = 39;
            this.gBox.Text = "5";
            // 
            // YaBox
            // 
            this.YaBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YaBox.Location = new System.Drawing.Point(756, 560);
            this.YaBox.Name = "YaBox";
            this.YaBox.Size = new System.Drawing.Size(516, 25);
            this.YaBox.TabIndex = 40;
            // 
            // YbBox
            // 
            this.YbBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YbBox.Location = new System.Drawing.Point(756, 591);
            this.YbBox.Name = "YbBox";
            this.YbBox.Size = new System.Drawing.Size(516, 25);
            this.YbBox.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(717, 483);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 26);
            this.label17.TabIndex = 42;
            this.label17.Text = "g";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(717, 563);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 26);
            this.label18.TabIndex = 43;
            this.label18.Text = "Ya";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(717, 589);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 26);
            this.label19.TabIndex = 44;
            this.label19.Text = "Yb";
            // 
            // KaBox
            // 
            this.KaBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KaBox.Location = new System.Drawing.Point(756, 622);
            this.KaBox.Name = "KaBox";
            this.KaBox.Size = new System.Drawing.Size(516, 25);
            this.KaBox.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(717, 622);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 26);
            this.label20.TabIndex = 46;
            this.label20.Text = "Ka";
            // 
            // KbBox
            // 
            this.KbBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KbBox.Location = new System.Drawing.Point(756, 653);
            this.KbBox.Name = "KbBox";
            this.KbBox.Size = new System.Drawing.Size(516, 25);
            this.KbBox.TabIndex = 47;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(717, 652);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 26);
            this.label21.TabIndex = 48;
            this.label21.Text = "Kb";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 681);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.KbBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.KaBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.YbBox);
            this.Controls.Add(this.YaBox);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.diffieHellmanRandomButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.diffieHellmanButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.timeIterationNumsBox);
            this.Controls.Add(this.NBox);
            this.Controls.Add(this.XbBox);
            this.Controls.Add(this.XaBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.primeRootsBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.generatePrimeRootsButton);
            this.Controls.Add(this.countPrimitiveRootBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.timeRootsBox);
            this.Controls.Add(this.timeIterationBox);
            this.Controls.Add(this.generatePrimeNumsButton);
            this.Controls.Add(this.generatePrimeNumButton);
            this.Controls.Add(this.primeNumbers2Box);
            this.Controls.Add(this.primeNumbers10Box);
            this.Controls.Add(this.rabinMillerNumsBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maxBitBox);
            this.Controls.Add(this.minBitBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.primeNumber2Box);
            this.Controls.Add(this.primeNumber10Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countBitsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rabinMillerBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox rabinMillerBox;
        private Label label1;
        private Label label2;
        private TextBox countBitsBox;
        private Label label3;
        private TextBox primeNumber10Box;
        private TextBox primeNumber2Box;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox minBitBox;
        private TextBox maxBitBox;
        private Label label7;
        private Label label8;
        private TextBox rabinMillerNumsBox;
        private TextBox primeNumbers10Box;
        private TextBox primeNumbers2Box;
        private Button generatePrimeNumButton;
        private Button generatePrimeNumsButton;
        private TextBox timeIterationBox;
        private TextBox timeRootsBox;
        private Label label9;
        private Label label10;
        private TextBox countPrimitiveRootBox;
        private Button generatePrimeRootsButton;
        private Label label11;
        private Label label12;
        private TextBox XaBox;
        private TextBox XbBox;
        private TextBox NBox;
        private TextBox timeIterationNumsBox;
        private Label label13;
        private Button diffieHellmanButton;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button diffieHellmanRandomButton;
        private TextBox primeRootsBox;
        private TextBox gBox;
        private TextBox YaBox;
        private TextBox YbBox;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox KaBox;
        private Label label20;
        private TextBox KbBox;
        private Label label21;
    }
}