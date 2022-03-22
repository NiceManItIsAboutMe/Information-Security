using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using System.Collections;
using System.IO;

namespace IB_2
{
    public static class Methods
    {
        public static int[] num_convert(ulong[] X) // перевод массива чисел ulong в int массив 0 и 1
        {
            int[] bin_seq = new int[X.Length * 64]; // результирующий массив длиной в 64*число элементов во входном массиве
            int k = 0;
            for (int i = 0; i < X.Length; i++)
            {
                BitArray buf = new BitArray(BitConverter.GetBytes(X[i])); // превод элемента массива ulong в масив байтов, а затем в массив битов
                for (int j = 0; j < buf.Length; j++)
                {
                    if (buf[j])
                        bin_seq[k] = 1;
                    else
                        bin_seq[k] = 0;
                    k++;
                }
            }
            return bin_seq;
        } 
        public static void Write(string fileName, string[] outw)  // Запись входной строки и ключа в файл
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (string str in outw)
                    sw.WriteLine(str);
            }
        }
        public static int[] zero_invert(int[] X) // функция замены нулей на -1
        {
            int[] bin_seq = new int[X.Length];

            for (int i = 0; i < bin_seq.Length; i++)
            {
                bin_seq[i] = X[i];
                if (bin_seq[i] == 0)
                    bin_seq[i] = -1;
            }

            return bin_seq;
        }
        //public static double Rav(double X, double a, double b)
        //{
        //    return (X - a) / (b - a);
        //}

        //public static double crit(double S, int r) // вычисление статистики
        //{
        //    double coef = 1 / (Math.Pow(2, (r / 2)) * SpecialFunctions.Gamma(r / 2));
        //    double f = MathNet.Numerics.Integration.NewtonCotesTrapeziumRule.IntegrateAdaptive(x => Math.Pow(x, (r / 2) - 1) * Math.Pow(Math.E, -x / 2), S, 10000000, 1e-5);
        //    return coef * f;
        //}

        //public static int Peroid(int[] seq) //Вычисление периода
        //{
        //    int per = 1;
        //    int step = 0;
        //    while (step + per != seq.Length)
        //    {
        //        if (seq[step] != seq[per + step])
        //        {
        //            ++per;
        //            step = 0;
        //        }
        //        else
        //        {
        //            ++step;
        //        }
        //    }
        //    return per;
        //}

        //public static double[] hi_2(int[] Seq) // Критерий согласия хи-квадрат Пирсона
        //{
        //    double[] res = new double[3];
        //    int Max = 1;
        //    int Min = -1;

        //    double K = 5 * Math.Log10(Seq.Length);
        //    double[] P = new double[1];
        //    double[] v = new double[(int)K];
        //    double[] inter = new double[(int)K + 1];
        //    double u = Min;
        //    for (int i = 0; i < (int)K + 1; i++)
        //    {
        //        inter[i] = u;
        //        u += ((Max - Min) / K);
        //    }

        //    for (int i = 0; i < Seq.Length; i++)
        //        for (int j = 0; j < inter.Length - 1; j++)
        //        {
        //            if (Seq[i] >= inter[j] && Seq[i] <= inter[j + 1])
        //                v[j]++;
        //        }

        //    for (int i = 0; i < v.Length; i++)
        //        v[i] /= Seq.Length;

        //    for (int i = 1; i < inter.Length; i++)
        //    {
        //        P[i - 1] = Rav(inter[i], 0, 1) - Rav(inter[i - 1], 0, 1);
        //        Array.Resize(ref P, P.Length + 1);
        //    }
        //    Array.Resize(ref P, P.Length - 1);
        //    double summ = 0;
        //    for (int i = 0; i < (int)K; i++)
        //        summ += Math.Pow(v[i] - P[i], 2) / P[i];

        //    summ *= Seq.Length;
        //    res[0] = summ;

        //    double S_t = crit(summ, (int)K - 2);
        //    res[1] = S_t;
        //    if (S_t <= summ)
        //        res[2] = 1;
        //    else
        //        res[2] = 0;
        //    return res;
        //}


    }
}

