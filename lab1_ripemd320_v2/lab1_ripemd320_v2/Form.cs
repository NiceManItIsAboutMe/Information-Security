using lab1_ripemd320;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab1_ripemd320_v2
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Для хэш-кода
        Ripemd320 ripemd1; 
        //Для исследования лавинного эффекта
        Ripemd320 ripemd2; 
        public Form()
        {
            InitializeComponent();
        }

        //Хэширование
        private void hashButton_Click(object sender, EventArgs e)
        {
            ripemd1 = new Ripemd320(text.Text);
            hashText.Text = ripemd1.ToString();
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            string str = "";
            DialogResult dialogResult=DialogResult.None;
            if (!string.IsNullOrEmpty(text.Text))
            {
                dialogResult = MessageBox.Show(
                                 "Поле текста для хэширования будет перезаписано данными из файла, продолжить?",
                                 "Сообщение",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Information,
                                 MessageBoxDefaultButton.Button1,
                                 MessageBoxOptions.DefaultDesktopOnly);
                if (dialogResult != DialogResult.Yes)
                    return;
            }
           

            str = readFileText.Text;
            if (string.IsNullOrEmpty(str))
                str = "defalt.txt";
            try
            {
                using(StreamReader reader=new StreamReader(str))
                {
                    text.Text=reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не правильно указано имя файла\nИнформация об ошибке "+ex.Message);
            }
        }

        private void writeFileButton_Click(object sender, EventArgs e)
        {
            string str = writeFileText.Text;
            if (string.IsNullOrEmpty(str))
                str = "defaltWrite.txt";
            try
            {
                using (StreamWriter writer=new StreamWriter(str))
                {
                    writer.WriteLine(hashText.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не правильно указано имя файла\nИнформация об ошибке " + ex.Message);
            }
        }

        private void paintButton_Click(object sender, EventArgs e)
        {
            string str = bitText.Text;
            if (string.IsNullOrEmpty(str))
                str = "0";
            int numBit = 0;
            if (!Int32.TryParse(str, out numBit))
                MessageBox.Show("Некорректный ввод, введите число");
            try
            {
                ripemd2 = new Ripemd320(ripemd1.GetOriginalStr(), numBit);
                int[] changedBits=ripemd2.getChangedBits(ripemd1);
                chart1.Series.Clear();
                for (int i = 0; i < changedBits.Length; i++)
                {
                    // Add series.
                    chart1.Series.Add(Convert.ToString(i));
                    chart1.Series[0].Points.AddXY(i + 1, changedBits[i]);

                }
                chart1.Series[0].ChartType = SeriesChartType.Line;
                chart1.Legends.Clear();
                hashText.Text += "\nХэш-код текста с измененным битом "+bitText.Text+ Environment.NewLine + ripemd2.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
