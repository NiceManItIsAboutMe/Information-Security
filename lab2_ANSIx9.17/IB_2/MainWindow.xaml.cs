using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IB_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        const string writePath = @"out.txt";
        public MainWindow()
        {
            InitializeComponent();
        }

        //запускаем генерацию последовательности
        private void WordCountButton_Click(object sender, RoutedEventArgs e)
        {
            string mess = WordCountTextBox.Text; // получаем количество 64-битных чисел

            if (mess == "" || Convert.ToInt32(mess) == 0) // проверка на корректное количество чисел
                MessageBox.Show("Введите количество чисел больше 0.");
            else
            {
                ANSI_X9_17 aNSI_X9_17 = new ANSI_X9_17();
                Test test = new Test();

                //очищаем все поля
                ResultingSequenceTextBox_1.Clear();
                ResultingSequenceTextBox_2.Clear();

                ResultTest_1.Clear();
                ResultTest_2.Clear();
                ResultTest_3.Clear();

                ProgressTextBox_1.Clear();
                ProgressTextBox_2.Clear();
                SequenceSumTextBox.Clear();
                StateValueTextBox.Clear();

                StateStatisticsTextBox.Clear();
                ZerousTextBox.Clear();


                ulong[] ansi = aNSI_X9_17.ANSI(Convert.ToInt32(mess)); // массив псевдослучайных чисел
                int[] Seq = Methods.num_convert(ansi); // последовательность из 0 и 1
                string[] out_seq = new string[1]; // выходной массив для записи строки двоичных чисел в файл

                // получение строки двоичных чисел
                for (int i = 0; i < Seq.Length; i++)
                    out_seq[0] += Seq[i].ToString();

                string binary = "";
                // вывод чисел в hex и в двоичном формате
                for (int i = 0; i < ansi.Length; i++)
                {
                    ResultingSequenceTextBox_1.Text += ansi[i].ToString("x") + " ";
                    binary += Convert.ToString((long)ansi[i], toBase: 2);
                }
                ResultingSequenceTextBox_2.Text = binary; // выводим двоичную сгенерированную последовательность


                Methods.Write(writePath, out_seq); // запись в файл выходной двоичной последовательности
                int[] Seq_m = Methods.zero_invert(Seq); // получение массива значений -1 и 1

                //записываем период последовательсности псевдослучайных чисел в результат выполннения теста частот
                //ProgressTextBox_1.Text = aNSI_X9_17.Peroid(Seq).ToString(); (для хиквадрат)


                // ЧАСТОТНЫЙ ТЕСТ
                double[] Freq_res = test.freq_test(Seq_m);

                // вывод шагов теста
                ProgressTextBox_1.Text += "Сумма элементов " + Freq_res[0].ToString() + Environment.NewLine;
                ProgressTextBox_1.Text += "Статистика " + Freq_res[1].ToString() + Environment.NewLine;

                // если частотный тест не пройден, то нет смысла в других тестах
                if (Freq_res[2] == 1)
                {
                    ResultTest_1.Text = "Пройден "; //первый тест пройден

                    // тест на последовательность одинаковых бит
                    double[] same_res = test.same_bits_test(Seq); 

                    // ---------------------------------------вывод шагов теста 2----------------------------------------
                    ProgressTextBox_2.Text += "Частота появления единиц " + same_res[0].ToString() + Environment.NewLine;
                    ProgressTextBox_2.Text += "Vn " + same_res[1].ToString() + Environment.NewLine;
                    ProgressTextBox_2.Text += "Статистика " + same_res[2].ToString() + Environment.NewLine;
                    // проверка прохождения теста
                    if (same_res[3] == 1)
                        ResultTest_2.Text = "Пройден";
                    else
                        ResultTest_2.Text = "Не пройден";
                    //----------------------------------------------------------------------------------------------------


                    // расширенный тест на произвольные отклонения
                    double[] rand_res = test.rand_dev_test(Seq_m);

                    // ----------------------------------------вывод шагов теста 3---------------------------------------
                    string rt = "";

                    for (int i = 0; i < rand_res.Length - 2 - 2 * 18; i++)
                        rt += rand_res[i].ToString() + Environment.NewLine;
                    SequenceSumTextBox.Text = rt;

                    rt = "";
                    for (int i = rand_res.Length - 2 - 2 * 18; i < rand_res.Length - 2 - 18; i++)
                        rt += rand_res[i].ToString() + Environment.NewLine;
                    StateValueTextBox.Text = rt;

                    rt = "";
                    for (int i = rand_res.Length - 2 - 18; i < rand_res.Length - 2; i++)
                        rt += rand_res[i].ToString() + Environment.NewLine;
                    StateStatisticsTextBox.Text = rt;

                    ZerousTextBox.Text = rand_res[rand_res.Length - 2].ToString();
                    // проверка прохождения теста
                    if (rand_res[rand_res.Length - 1] == 1)
                        ResultTest_3.Text = "Пройден";
                    else
                        ResultTest_3.Text = "Не пройден";
                    //-------------------------------------------------------------------------------------------------
                    //этого пока нет
                    //double[] hi_2 = Cr.hi_2(Seq_m);
                    //if (hi_2[2] == 1)
                    //    textBox13.Text = "Пройден";
                    //else
                    //    textBox13.Text = "Не пройден";
                }
                else
                {
                    ResultTest_1.Text = "Не пройден ";
                    MessageBox.Show("Дальнейшие тесты не требуются, последовательность не случайная.");
                }
            }
        }
    }
}
