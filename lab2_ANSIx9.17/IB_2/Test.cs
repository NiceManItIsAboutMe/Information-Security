﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace IB_2
{
    public class Test
    {
        const double F_S = 1.82138636; // значение статистики для частотного теста
        double[] Stat = new double[16] { 3.841, 5.991, 7.815, 9.488, 11.070, 12.592, 14.067, 15.507,
                                        16.919, 18.307, 19.675, 21.026, 22.362, 23.685, 24.996, 26.296 };

        // ------------------------------------частотный тест-----------------------------------------
        //Входные данные: последовательность из -1 и 1 
        //Выходные данные: шаги выполнения - статистика, сумма элементов, результат прохождения теста.
        public double[] freq_test(int[] Seq)
        {
            int S = 0; // сумма всех элементов последовательности
            double[] res = new double[3]; // результирующий массив (нужет для регистрации всех шагов теста)

            for (int i = 0; i < Seq.Length; i++) // получаем сумму элементов последовательности
                S += Seq[i];

            double Stat = Math.Abs(S) / Math.Sqrt(Seq.Length); // находим статистику
            res[0] = S; // сохраняем сумму
            res[1] = Stat; // сохраняем статистику
            if (Stat <= F_S) // если статистика меньше или равна тестовой - тест пройден
                res[2] = 1;
            else
                res[2] = 0;

            return res;
        }
        //---------------------------------------------------------------------------------------------


        //-------------------------------тест на последовательность одинаковых бит----------------------
        //Входные данные: последовательность из 0 и 1
        //Выходные данные: частота встреч единиц в последовательности, значение Vn (все ситуации, когда соседние элементы не равны друг другу), результат теста 

        //Тест определяет, является ли количество цепочек из нулей
        //и единиц различной длины в последовательности приблизительно таким же, как должно быть в истинно случайной последовательности
        public double[] same_bits_test(int[] Seq)
        {
            double pi = 0; // частота появленяи единиц в последовательности
            int V = 1; // количество ситуаций, при которых соседние числа последовательности не равны друг другу 

            double[] res = new double[4]; // результирующий массив (нужет для регистрации всех шагов теста)

            // находим частоту встречи единиц в последовательности
            for (int i = 0; i < Seq.Length; i++)
                pi += Seq[i];
            pi /= Seq.Length;

            // находим все ситуации, когда соседние элементы не равны друг другу
            for (int i = 0; i < Seq.Length - 1; i++)
                if (Seq[i] != Seq[i + 1])
                    V += 1;

            double Stat = Math.Abs(V - 2 * pi * Seq.Length * (1 - pi)) /
                          (2 * pi * (1 - pi) * Math.Sqrt(2 * Seq.Length)); // статистика
            res[0] = pi;
            res[1] = V;
            res[2] = Stat;

            if (Stat <= F_S)
                res[3] = 1;
            else
                res[3] = 0;

            return res;
        }
        //-----------------------------------------------------------------------------------------------


        //--------------------------расширенный тест на произвольные отклонения---------------------------
        //-подсчёт количества встреч чисел от -9 до 9 (кроме 0) в последовательности
        public int[] state_check(int[] S, int[] eps)
        {
            for (int i = -9; i < 0; i++)
                for (int j = 0; j < S.Length; j++)
                    if (S[j] == i)
                        eps[i + 9]++;

            for (int i = 1; i < 10; i++)
                for (int j = 0; j < S.Length; j++)
                    if (S[j] == i)
                        eps[i + 8]++;
            return eps;
        }
        // получение статистик для ситуаций, полученных в state_check
        public bool Y_check(double[] Y)
        {
            for (int i = 0; i < Y.Length; i++)
                if (Y[i] > F_S)
                    return false;
            return true;
        }

        //Входные данные: последовательность из -1 и 1
        //Выходные данные: возрастающие суммы, число встреч, статистики, число нулей, результат прохождения етста

        //Этот тест оценивает общее число посещений определенного состояния при произвольном обходе кумулятивной суммы. Цель этого теста
        //– определить отклонения от ожидаемого числа посещений различных
        //состояний при произвольном обходе.Фактически данный тест состоит
        //из 18 тестов, по одному для каждого состояния: –9, –8, …, –1, 1, 2, …,9. 
        public double[] rand_dev_test(int[] Seq)
        {
            int[] S = new int[Seq.Length + 2]; // новая последовательность возростающих сумм (содержит 0 в начальном и последнем элементах)
            int[] eps = new int[18]; // количество встреч чисел от -9 до 9 (кроме 0) в S
            double[] Y = new double[18]; // статистики для eps             
            int k = 0; // число нулей в S 
            int L = 0; // число нулей - 1 в S

            // получаем возростающие суммы
            for (int i = 1; i < Seq.Length + 1; i++)
                S[i] += S[i - 1] + Seq[i - 1];

            // получаем число нулей
            for (int i = 0; i < S.Length; i++)
                if (S[i] == 0)
                    k++;

            L = k - 1;

            eps = state_check(S, eps); // получаем число встреч чисел

            // получаем статистики для чисел от -9 до -1
            for (int i = -9; i < 0; i++)
                Y[i + 9] = Math.Abs(eps[i + 9] - L) / Math.Sqrt(2 * L * (4 * Math.Abs(i) - 2));

            // получаем статистики для чисел от 1 до 9
            for (int i = 1; i < 10; i++)
                Y[i + 8] = Math.Abs(eps[i + 8] - L) / Math.Sqrt(2 * L * (4 * Math.Abs(i) - 2));

            // результирующий массив (нужет для регистрации всех шагов теста)
            double[] res = new double[S.Length + 2 * eps.Length + 2];

            // сохраняем возростающие суммы
            for (int i = 0; i < S.Length; i++)
                res[i] = S[i];
            // сохраняем число встреч
            for (int i = 0; i < eps.Length; i++)
                res[i + S.Length] = eps[i];
            // сохраняем статистики
            for (int i = 0; i < eps.Length; i++)
                res[i + S.Length + eps.Length] = Y[i];

            res[S.Length + 2 * eps.Length] = L; //число нулей в новой последовательности

            //проверяем все 18 статистик
            //если каждая из статистик менше определенного числа, то тест пройден
            if (Y_check(Y))
                res[S.Length + 2 * eps.Length + 1] = 1;
            else
                res[S.Length + 2 * eps.Length + 1] = 0;

            return res;
        }
        //-------------------------------------------------------------------------------------------------

    }
}