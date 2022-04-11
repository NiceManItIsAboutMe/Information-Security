using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_Test
{
    internal class LargePrimeGenertor
    {
        /// <summary>
        /// количество итераций для последнего сгенерированного числа
        /// </summary>
        static public int countIteration = 0;
        /// <summary>
        /// простые числа до 2000
        /// </summary>
        public static int[] PRIME_NUMBERS = {
            2,3,5,7,11,13,17,19,23,29,31,37,
            41,43,47,53,59,61,67,71,73,79,83,89,
            97,101,103,107,109,113,127,131,137,139,149,151,
            157,163,167,173,179,181,191,193,197,199,211,223,
            227,229,233,239,241,251,257,263,269,271,277,281,
            283,293,307,311,313,317,331,337,347,349,353,359,
            367,373,379,383,389,397,401,409,419,421,431,433,
            439,443,449,457,461,463,467,479,487,491,499,503,
            509,521,523,541,547,557,563,569,571,577,587,593,
            599,601,607,613,617,619,631,641,643,647,653,659,
            661,673,677,683,691,701,709,719,727,733,739,743,
            751,757,761,769,773,787,797,809,811,821,823,827,
            829,839,853,857,859,863,877,881,883,887,907,911,
            919,929,937,941,947,953,967,971,977,983,991,997,
            1009,1013,1019,1021,1031,1033,1039,1049,1051,1061,1063,1069,
            1087,1091,1093,1097,1103,1109,1117,1123,1129,1151,1153,1163,
            1171,1181,1187,1193,1201,1213,1217,1223,1229,1231,1237,1249,
            1259,1277,1279,1283,1289,1291,1297,1301,1303,1307,1319,1321,
            1327,1361,1367,1373,1381,1399,1409,1423,1427,1429,1433,1439,
            1447,1451,1453,1459,1471,1481,1483,1487,1489,1493,1499,1511,
            1523,1531,1543,1549,1553,1559,1567,1571,1579,1583,1597,1601,
            1607,1609,1613,1619,1621,1627,1637,1657,1663,1667,1669,1693,
            1697,1699,1709,1721,1723,1733,1741,1747,1753,1759,1777,1783,
            1787,1789,1801,1811,1823,1831,1847,1861,1867,1871,1873,1877,
            1879,1889,1901,1907,1913,1931,1933,1949,1951,1973,1979,1987,
            1993,1997,1999,2003};

        
        static public BigInteger NextRandom(int countBitsMin,int countBitsMax, int countRabbinMillerTest = 5)
        {
            return Next(new Random().Next(countBitsMin, countBitsMax));
        }
        /// <summary>
        /// Возвращает простое число размером countBits бит
        /// </summary>
        /// <param name="countBits">размер в битах</param>
        /// <param name="countRabbinMillerTest">количество тестов Миллера-Робина</param>
        /// <returns>Простое число</returns>
        static public BigInteger Next(int countBits,int countRabbinMillerTest=5)
        {
            BigInteger result = BigInteger.Zero;
            bool isBreak;
            countIteration = 0;
            do
            {
                //Проверяем делится ли число на простые числа до 2000
                do
                {
                    isBreak = false;
                    result = NextBigInteger(countBits);

                    //количество итераций для нахождения простого числа
                    countIteration++;

                    foreach (var item in PRIME_NUMBERS)
                    {
                        if (result == item)
                            return result;

                        if (result % item == 0)
                        {
                            isBreak = true;
                            break;
                        }
                    }

                } while (isBreak);
            //проверяем тестом Рабина-Миллера   
            } while (!RabinMillerTest(result, countRabbinMillerTest));

            return result;
        }

        /// <summary>
        /// создает следующее число с определенным количеством битов
        /// </summary>
        /// <param name="countBits">количество битов в следующем числе</param>
        /// <returns>число BigInteger</returns>
        static public BigInteger NextBigInteger(int countBits)
        {
            Random rand = new Random();
            if (countBits==1)
                return rand.Next(2);
            if (countBits < 1)
                throw new Exception("Число бит не может быть меньше 1");
            BigInteger result = BigInteger.Zero;
            //первый бит равен 1
            result += BigInteger.Pow(2,countBits-1);
            
            for (int i = 0; i < countBits-2; i++)
            {
                //генерируем следующий бит (0 или 1 ) и переводим его в 10 форму (умножаем на 2 в степени текущего разряда числа)
                result += rand.Next(2) * BigInteger.Pow(2, countBits - 2 - i);
            }
            //последний бит равен 1
            result += BigInteger.One;

            return result;
        }
        

        /// <summary>
        /// Тест Робина-Миллера
        /// </summary>
        /// <param name="num">Проверяемое число</param>
        /// <param name="countChecks">число проверок</param>
        /// <returns>Если пройден true</returns>
        static public bool RabinMillerTest(BigInteger num, int countChecks=5)
        {
            

            //b - степень 2 на которую число num - 1 делится без остатка
            int powerOf2 = 1;

            // m=(p-1)/2^b - нечетное число получаемое при делении числа num-1 на 2 в степени b
            BigInteger m;

            //a<p - любое число a меньшее чем num
            BigInteger a;

            //z=a^m%p или z=a^m%num
            BigInteger z;

            //находим b
            for (int i = (int) num.GetBitLength(); i > 0; i--)
            {
                if ((num - 1) % BigInteger.Pow(2, i) == 0)
                {
                    powerOf2 = i;
                    break;
                }
            }

            //находим m
           
            m = (num - 1) / (BigInteger.Pow(2, powerOf2));

            //проверяем столько раз сколько countChecks, по умолчанию 5
            for (int i = 0; i < countChecks; i++)
            {


                //находим a (пункт 1)
                Random rand = new Random();
                do
                {
                    a = NextBigInteger(rand.Next(1,(int)num.GetBitLength() + 1));
                } while (a > num);

                //находим z=a^m%p или z=a^m%num(пункт 2)
                z = BigInteger.ModPow(a, m, num);
                //если z=1 или z=num-1 то это число прошло проверку начинаем новую (пункт 3) j==0
                if (z == 1 || z == num - 1)
                    continue;
                //начинаем с 1, тк первая итерация была выше (проверка z)
                for (int j = 1; j < powerOf2; j++)
                {
                    //не простое число (пункт 4)
                    if (z == 1)
                        return false;
                    //пункт 5.1 z=z^2%p 
                    if (z < num - 1)
                        z = BigInteger.ModPow(z, 2,num);
                    //пункт 5.1 (этап пройден)
                    if (z == num - 1)
                        break;
                }
                //j==b
                if (z != num - 1)
                    return false;
            }


            //если все этапы прошли успешно то тест пройден
            return true;

        }

        /// <summary>
        /// Возвращает все простые числа из диапазона
        /// </summary>
        /// <param name="countBitsMin">минимальное количество бит</param>
        /// <param name="countBitsMax">максимальное количество бит</param>
        /// <param name="countRabbinMillerTest">количество тестов Робина-Миллера</param>
        /// <returns>Лист простых чисел</returns>
        public static List<BigInteger> Next(int countBitsMin, int countBitsMax, int countRabbinMillerTest)
        {
            List<BigInteger> result = new List<BigInteger>();
            List<BigInteger> listBigIntegers = NextBigInteger(countBitsMin,countBitsMax);
            int isPrime;
            foreach (var bigInteger in listBigIntegers)
            {
                isPrime = 1;
                foreach (var item in PRIME_NUMBERS)
                {
                    //если число простое то не проверяем тестом Рабина-Миллера
                    if (bigInteger == item || bigInteger == 0 || bigInteger == 1 || bigInteger == 2)
                    {
                        isPrime = 2;
                        break;
                    }
                    //если делится без остатка это не наше число
                    if (bigInteger % item == 0)
                    {
                        isPrime = 0;
                        break;
                    }
                }
                if (isPrime == 2)
                    result.Add(bigInteger);
                else if (isPrime == 1)
                    if (RabinMillerTest(bigInteger,countRabbinMillerTest))
                        result.Add(bigInteger);
            }
            
            return result;
        }
        /// <summary>
        /// Возвращает все нечетные числа из диапазона
        /// </summary>
        /// <param name="countBitsMin">минимальное количество бит</param>
        /// <param name="countBitsMax">максимальное количество бит</param>
        /// <returns>Лист чисел</returns>
        /// <exception cref="Exception"></exception>
        static public List<BigInteger> NextBigInteger(int countBitsMin, int countBitsMax)
        {
            List<BigInteger> result = new List<BigInteger>();
            //минимальное и максимальное значение
            if (countBitsMin > countBitsMax)
                throw new Exception("Максимальное значение диапазона не может быть меньше минимального");
            if (countBitsMin == 0 || countBitsMax == 0)
                throw new Exception("Количество бит не может быть меньше 1");
            BigInteger min = BigInteger.Pow(2, countBitsMin - 1) + 1;
            BigInteger max = BigInteger.Pow(2, countBitsMax - 1) + 1;

            if (countBitsMin == 1)
            {
                result.Add(0);
                result.Add(1);
                min = 3;
                if (countBitsMax == 1)
                    return result;
                result.Add(2);
            }

            result.Add(min);
            while (true)
            {
                min += 2;
                if (min >= max)
                    break;
                result.Add(min);
            }
            if (countBitsMax != countBitsMin)
                result.Add(max);

            return result;
        }
        /// <summary>
        /// Возвращает все простые числа из диапазона
        /// </summary>
        /// <param name="min">минимальное число</param>
        /// <param name="max">максимальное число</param>
        /// <param name="countRabbinMillerTest"></param>
        /// <returns>Лист простых чисел</returns>
        public static List<BigInteger> Next(BigInteger min, BigInteger max, int countRabbinMillerTest = 5)
        {
            List<BigInteger> result = new List<BigInteger>();
            List<BigInteger> listBigIntegers = NextBigInteger(min, max);
            int isPrime;
            foreach (var bigInteger in listBigIntegers)
            {
                isPrime = 1;
                foreach (var item in PRIME_NUMBERS)
                {
                    //если число простое то не проверяем тестом Рабина-Миллера
                    if (bigInteger == item || bigInteger == 0 || bigInteger == 1 || bigInteger == 2)
                    {
                        isPrime = 2;
                        break;
                    }
                    //если делится без остатка это не наше число
                    if (bigInteger % item == 0)
                    {
                        isPrime = 0;
                        break;
                    }
                }
                if (isPrime == 2)
                    result.Add(bigInteger);
                else if (isPrime == 1)
                    if (RabinMillerTest(bigInteger, countRabbinMillerTest))
                        result.Add(bigInteger);
            }

            return result;
        }
        /// <summary>
        /// Возвращает все нечетные числа из диапазона
        /// </summary>
        /// <param name="min">минимальное число</param>
        /// <param name="max">максимальное число</param>
        /// <returns>Лист чисел</returns>
        /// <exception cref="Exception"></exception>
        static public List<BigInteger> NextBigInteger(BigInteger min, BigInteger max)
        {
            List<BigInteger> result = new List<BigInteger>();

            if (min == max) 
            {
                result.Add(min);
                return result;
            }
            if (min > max)
                throw new Exception("Максимальное значение диапазона не может быть меньше минимального");
            if (min < 0 || max < 0)
                throw new Exception("Значениями диапазона могут быть только положительные числа");
            if (min % 2 == 0)
                min += 1;

            if (min == 0)
            {
                result.Add(0);
                result.Add(1);
                min = 3;
                if (max == 1)
                    return result;
                result.Add(2);
            }else if (min == 1)
            {
                result.Add(1);
                min = 3;
                result.Add(2);
            }

            result.Add(min);
            while (true)
            {
                min += 2;
                if (min >= max)
                    break;
                result.Add(min);
            }

            result.Add(max);

            return result;
        }

        static public bool IsPrime(BigInteger num, int countRabbinMillerTest = 5)
        {
            foreach (var item in PRIME_NUMBERS)
            {
                //если число простое то не проверяем тестом Рабина-Миллера
                if (num == item || num == 0 || num == 1)
                {
                    return true;
                }
                //если делится без остатка это не наше число
                if (num % item == 0)
                {
                    return false;
                }
            }
            if (RabinMillerTest(num, countRabbinMillerTest))
                return true;
            return false;
        }

        static public string GetBinary(BigInteger num)
        {
            return string.Concat(num.ToByteArray().Select(b => Convert.ToString(b, 2).PadLeft(8, '0')).Reverse());
        }
        

    }
}
