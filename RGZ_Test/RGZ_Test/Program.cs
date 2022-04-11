// See https://aka.ms/new-console-template for more information
using RGZ_Test;
using System.Numerics;
using System.Text;


BigInteger test = LargePrimeGenertor.Next(32,50);
Console.WriteLine(test.ToString());
Console.WriteLine(LargePrimeGenertor.GetBinary(test));
Console.WriteLine(PrimitiveRoot.EulerF(PrimitiveRoot.EulerF(test-1)));
foreach (var item in PrimitiveRoot.GetRoots(test,100))
{
    //Console.WriteLine(item.Key+" "+item.Value);
    Console.WriteLine(item);
}

//Console.WriteLine(LargePrimeGenertor.Next(150).ToString());

//BigInteger a = Convert.ToInt64("1", 2)*BigInteger.Pow(2,2) + Convert.ToInt64("01", 2);
//Console.WriteLine(string.Concat(a.ToByteArray().Select(b => Convert.ToString(b, 2).PadLeft(8, '0')).Reverse()));