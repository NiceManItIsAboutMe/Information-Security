namespace lab1_ripemd320_v2
{
    partial class Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.readFileText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hashButton = new System.Windows.Forms.Button();
            this.readFileButton = new System.Windows.Forms.Button();
            this.hashText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.writeFileText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.writeFileButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bitText = new System.Windows.Forms.TextBox();
            this.paintButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите текст для хэширования";
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(12, 36);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text.Size = new System.Drawing.Size(664, 325);
            this.text.TabIndex = 3;
            // 
            // readFileText
            // 
            this.readFileText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readFileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readFileText.Location = new System.Drawing.Point(697, 36);
            this.readFileText.Multiline = true;
            this.readFileText.Name = "readFileText";
            this.readFileText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.readFileText.Size = new System.Drawing.Size(475, 31);
            this.readFileText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(701, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите имя файла для чтения";
            // 
            // hashButton
            // 
            this.hashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hashButton.Location = new System.Drawing.Point(12, 367);
            this.hashButton.Name = "hashButton";
            this.hashButton.Size = new System.Drawing.Size(664, 23);
            this.hashButton.TabIndex = 4;
            this.hashButton.Text = "Хэшировать";
            this.hashButton.UseVisualStyleBackColor = true;
            this.hashButton.Click += new System.EventHandler(this.hashButton_Click);
            // 
            // readFileButton
            // 
            this.readFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readFileButton.Location = new System.Drawing.Point(697, 73);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(475, 23);
            this.readFileButton.TabIndex = 2;
            this.readFileButton.Text = "Читать файл";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // hashText
            // 
            this.hashText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hashText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hashText.Location = new System.Drawing.Point(12, 430);
            this.hashText.Multiline = true;
            this.hashText.Name = "hashText";
            this.hashText.ReadOnly = true;
            this.hashText.Size = new System.Drawing.Size(664, 43);
            this.hashText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Хэш-код";
            // 
            // writeFileText
            // 
            this.writeFileText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.writeFileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeFileText.Location = new System.Drawing.Point(12, 520);
            this.writeFileText.Multiline = true;
            this.writeFileText.Name = "writeFileText";
            this.writeFileText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.writeFileText.Size = new System.Drawing.Size(664, 25);
            this.writeFileText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Имя файла для записи";
            // 
            // writeFileButton
            // 
            this.writeFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.writeFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeFileButton.Location = new System.Drawing.Point(12, 551);
            this.writeFileButton.Name = "writeFileButton";
            this.writeFileButton.Size = new System.Drawing.Size(664, 23);
            this.writeFileButton.TabIndex = 6;
            this.writeFileButton.Text = "Запись в файл";
            this.writeFileButton.UseVisualStyleBackColor = true;
            this.writeFileButton.Click += new System.EventHandler(this.writeFileButton_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(697, 205);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(475, 394);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart";
            // 
            // bitText
            // 
            this.bitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bitText.Location = new System.Drawing.Point(697, 161);
            this.bitText.Multiline = true;
            this.bitText.Name = "bitText";
            this.bitText.Size = new System.Drawing.Size(48, 27);
            this.bitText.TabIndex = 7;
            // 
            // paintButton
            // 
            this.paintButton.Location = new System.Drawing.Point(759, 161);
            this.paintButton.Name = "paintButton";
            this.paintButton.Size = new System.Drawing.Size(190, 27);
            this.paintButton.TabIndex = 8;
            this.paintButton.Text = "Построить график";
            this.paintButton.UseVisualStyleBackColor = true;
            this.paintButton.Click += new System.EventHandler(this.paintButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(701, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Номер изменяемого бита";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paintButton);
            this.Controls.Add(this.bitText);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.writeFileButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.writeFileText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hashText);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.hashButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.readFileText);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ripemd320";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.TextBox readFileText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hashButton;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.TextBox hashText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox writeFileText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button writeFileButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox bitText;
        private System.Windows.Forms.Button paintButton;
        private System.Windows.Forms.Label label5;
    }
}

