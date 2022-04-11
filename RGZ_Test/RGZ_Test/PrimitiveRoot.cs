using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_Test
{
    internal class PrimitiveRoot
    {

        static public List<BigInteger> GetRoots(BigInteger num, int countRoots=100)
        {
            List<BigInteger> result = new List<BigInteger>();
            // fi = c
            BigInteger fi=EulerF(num);
            //fact=q
            Dictionary<BigInteger, int> fact = Factorization(num-1);

            //i=a
            BigInteger i = 2;
            BigInteger count;
            if (num > long.MaxValue)
                count = EulerF(EulerF(num - 1));
            else
                count = long.MaxValue;

            //пока не найдены количество корней указанных пользователем, либо всех возможных корней
            while (result.Count != countRoots && result.Count!=count)
            {
                foreach (var item in fact)
                {
                    //a^c/q mod num
                    if (BigInteger.ModPow(i, fi / item.Key, num) == 1 % num)
                    {
                        result.Add(i);
                        break;
                    }

                } 
                i++;
            }
            return result;
        }

        /// <summary>
        /// Факторизация
        /// </summary>
        /// <param name="number">число</param>
        /// <param name="algorithm">1-перебор, 2-поллард</param>
        /// <returns>Словарь ключ-простое число, значение-степень</returns>
        static public Dictionary<BigInteger,int> Factorization(BigInteger number,int algorithm=2)
        {
            Dictionary<BigInteger, int> result = new Dictionary<BigInteger, int>();
            result.Add(1,1);
            if (LargePrimeGenertor.IsPrime(number))
            {
                result.Add(number,1);
                return result;
            }
            //Перебор
            if (algorithm == 1)
            {
                for (int i = 0; number % 2 == 0; number /= 2)
                {
                    if (!result.ContainsKey(2))
                        result.Add(2, 1);
                    else
                        result[2]++;
                }
                for (BigInteger i = 3; i <= number;)
                {
                    if (number % i == 0)
                    {
                        if (!result.ContainsKey(i))
                            result.Add(i, 1);
                        else
                            result[i]++;
                        number /= i;
                    }
                    else
                    {
                        i += 2;
                    }
                    
                    
                }
            }
            //Поллард
            else if (algorithm == 2)
            {
                BigInteger num1;
                //BigInteger num2;
                while (number != 1)
                {
                    //num1 = number;
                    num1 = number;
                    while (!LargePrimeGenertor.IsPrime(num1))
                    {
                        num1 = RoPollard(num1);
                    }

                    if (!result.ContainsKey(num1))
                        result.Add(num1, 1);
                    else
                        result[num1]++;
                    number /= num1;
                    
                    
                } 

            }
            result.Remove(1);
            return result;
        }

        /// <summary>
        /// Факторизация Ро-алгоритм Полларда
        /// </summary>
        /// <param name="num">число</param>
        /// <returns>1 из делителей числа</returns>
        static public BigInteger RoPollard(BigInteger num)
        {
            Random random = new Random();
            BigInteger x;
            if (num == 4)
                return 2;
            if (num > long.MaxValue)
                x = LargePrimeGenertor.NextRandom(1, (int)num.GetBitLength() - 1);
            else
                x = random.NextInt64(1, (long)(num - 2));
            BigInteger y = 1;
            BigInteger i = 0;
            BigInteger stage = 2;
            while (BinaryGCD(num, BigInteger.Abs(x - y)) == 1)
            {
                if (i == stage)
                {
                    y = x;
                    stage = stage * 2;
                }
                x = (x * x + 1) % num;
                i = i + 1;
            }
            return BinaryGCD(num, BigInteger.Abs(x - y));
        }

        /// <summary>
        /// Бинарный алгоритм Эвклида (Нахождение Наибольшего общего делителя)
        /// </summary>
        /// <param name="u">1 число</param>
        /// <param name="v">2 число</param>
        /// <returns>НОД</returns>
        static BigInteger BinaryGCD(BigInteger u, BigInteger v)
        {
            int  shift = 0;

            if (u == 0) return v;
            if (v == 0) return u;

            while (((u | v) & 1) == 0)
            {
                shift++;
                u >>= 1;
                v >>= 1;
            }

            while ((u & 1) == 0)
                u >>= 1;

            do
            {
                while ((v & 1) == 0)
                    v >>= 1;

                if (u > v)
                {
                    (v, u) = (u, v);
                }

                v -= u;
            } while (v != 0);

            return u << shift;
        }

        /// <summary>
        /// Функция Эйлера
        /// </summary>
        /// <param name="num">число</param>
        /// <returns>количество натуральных чисел, не превышающих num и взаимно простых с ним </returns>
        static public BigInteger EulerF(BigInteger num)
        {
            if (LargePrimeGenertor.IsPrime(num))
                return num - 1;
            BigInteger result = 1;
            // fi=fi(p^n-p^(n-1)) p -простое число, то есть мы раскладываем на простые множители число и по этой формуле считаем
            //пример: fi(36)=fi(2^3)*fi(3^2)=(2^2-2)*(3^2-3)=12
            foreach (var item in Factorization(num))
            {
                result *= BigInteger.Pow(item.Key, item.Value) - BigInteger.Pow(item.Key, item.Value - 1);
            }
            return result;

        }


    }
}
