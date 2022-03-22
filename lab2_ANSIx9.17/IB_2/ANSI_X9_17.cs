using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using MathNet.Numerics;

namespace IB_2
{
    public class ANSI_X9_17
    {
       
        public byte[] TriDES(byte[] Data, byte[] Key, byte[] IV)
        {
            MemoryStream mStream = new MemoryStream();  // создаём поток памяти

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider(); // объект класса 3DES
            tdes.Padding = PaddingMode.None; //отключаем дополнение выходного шифротекства справа
            tdes.Mode = CipherMode.CFB; // включаепм режим CFB, чтобы установить длину шифротекста в 64 бита

            CryptoStream cStream = new CryptoStream(mStream,
                tdes.CreateEncryptor(Key, IV),
                CryptoStreamMode.Write); // создаём поток для шифрования

            byte[] toEncrypt = Data;

            cStream.Write(toEncrypt, 0, toEncrypt.Length); // помещаем данные в поток шифрования
            cStream.FlushFinalBlock();

            byte[] ret = mStream.ToArray(); // извлекаем шифротекст

            cStream.Close(); // закрываем потоки
            mStream.Close();

            return ret;
        }

        public byte[] key_gen() // генератор 128-битного ключа
        {
            byte[] key = new byte[128]; // основной ключ
            byte[] b1 = new byte[64]; // 64-битная часть ключа
            byte[] b2 = new byte[64]; // 64-битная часть ключа
            byte[] xor = new byte[64]; // 64-битная блок случайных бит для равномерного преобразования ключа
            byte[] bit = new byte[1]; // случайный бит для выбора совмещения двух частей ключа (1 - !b1 + b2, 0 - b2 + !b1)
            var rand = new Random(); // структура для рандома

            rand.NextBytes(b1); // создаём случайную половину ключа
            rand.NextBytes(b2); // создаём случайную половину ключа
            rand.NextBytes(xor); // создаём случайную последовательность для оперции xor с половинами ключа
            ulong k1 = BitConverter.ToUInt64(b1, 0); // переводим в ulong формат
            ulong k2 = BitConverter.ToUInt64(b2, 0); // переводим в ulong формат

            ulong xr = BitConverter.ToUInt64(xor, 0); // переводим в ulong формат
            k1 ^= xr; // приводим к равномерному виду
            xr = BitConverter.ToUInt64(xor, 0);
            k2 ^= xr; // приводим к равномерному виду

            rand.NextBytes(bit); // создаём случайное число (0 или 1), чтобы выбрать, какую половину ключа поставить первой и какую инвертировать
            if (bit[0] == 1)
            {
                b1 = BitConverter.GetBytes(~k1); // обрачаем число
                b2 = BitConverter.GetBytes(k2);
                key = b1.Concat(b2).ToArray(); // соединяем половины 128-битного ключа
            }
            else
            {
                b1 = BitConverter.GetBytes(k1);
                b2 = BitConverter.GetBytes(~k2); // обрачаем число
                key = b2.Concat(b1).ToArray(); // соединяем половины 128-битного ключа
            }

            return key;
        }

        public ulong[] ANSI(int m) // алгоритм ANSI X9.17
        {
            ulong[] X = new ulong[m]; // результирующая последовательность из m 64-битных чисел

            DateTime date1 = DateTime.Now; // структура для извлечения даты и времени
            var rand = new Random(); // структура для получения рандомных чисел

            byte[] s_0 = new byte[64]; // начальное случайное секретное 64-битное число
            rand.NextBytes(s_0); // 	 Заполняет элементы указанного массива байтов случайными числами.

            for (int i = 0; i < m; i++) // основной цикл
            {
                //---------------------Для алгоритма 3DES----------------------------------------------------------------
                byte[] d = BitConverter.GetBytes((ulong)date1.ToBinary()); // получаем дату и время в 64-битном формате
                byte[] IV = new byte[128]; // 128-битный вектор инициализации для шифрования чисел 3DES
                rand.NextBytes(IV); // получаем случайный вектор (использование случайного вектора позволяет избежать дублирующихся блоков в шифротексте)
                byte[] buf = TriDES(d, key_gen(), IV); // key_gen - генерирует составной 128 битный ключ
                //-------------------------------------------------------------------------------------------------------

                ulong b1 = BitConverter.ToUInt64(buf, 0); // преобразуем зашифрованную дату и время в ulong для битовых операций
                ulong s = BitConverter.ToUInt64(s_0, 0); //  преобразуем секретное число в ulong для битовых операций

                //---------------------вычисляем новое значение параметра Si---------------------------------------------
                s ^= b1; // проводим xor операцию с секретным числом и зашифрованными датой, временем
                //-------------------------------------------------------------------------------------------------------

                buf = BitConverter.GetBytes(s); // переводим результат xor обратно в массив байтов для повторного шифрования

                rand.NextBytes(IV); // получаем новый случайный вектор инициализации
                buf = TriDES(buf, key_gen(), IV); // шифруем результат xor

                //----------------------Вычисляем значение i-го выходного слова-------------------------------------------
                X[i] = BitConverter.ToUInt64(buf, 0); // получаем одно из результирующих псевдослучайных чисел
                b1 ^= X[i]; // проводим операцию xor с результирующим числом и предыдущим xor
                //---------------------------------------------------------------------------------------------------------

                buf = BitConverter.GetBytes(b1); // переводим xor в массив байтов
                rand.NextBytes(IV); // шифруем результат второго xor чтобы получить новое начальное случайное число для следующей итерации цикла
            }
            return X;
        }

    }
}
