// See https://aka.ms/new-console-template for more information
using RGZ_Test;
using System.Numerics;
using System.Text;


DiffieHellmanScheme dhs = new DiffieHellmanScheme(65);
Console.WriteLine(dhs.ToString());

//Console.WriteLine(LargePrimeGenertor.Next(150).ToString());

//BigInteger a = Convert.ToInt64("1", 2)*BigInteger.Pow(2,2) + Convert.ToInt64("01", 2);
//Console.WriteLine(string.Concat(a.ToByteArray().Select(b => Convert.ToString(b, 2).PadLeft(8, '0')).Reverse()));