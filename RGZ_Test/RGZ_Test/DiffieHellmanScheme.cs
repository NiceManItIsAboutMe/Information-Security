using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_Test
{
    internal class DiffieHellmanScheme
    {
        /// <summary>
        /// случайное большое число
        /// </summary>
        public BigInteger N;
        /// <summary>
        /// первообразный корень N
        /// </summary>
        public BigInteger G;
        /// <summary>
        /// Большое секретное число Xa<N
        /// </summary>
        public BigInteger Xa;
        /// <summary>
        /// Открытое значение Ya=G^(Xa) mod N
        /// </summary>
        public BigInteger Ya;
        /// <summary>
        /// Большое секретное число Xb<N
        /// </summary>
        public BigInteger Xb;
        /// <summary>
        /// Открытое значение Yb=G^(Xb) mod N
        /// </summary>
        public BigInteger Yb;
        /// <summary>
        /// K=Yb^(Xa) mod N ;
        /// K=Ya^(Xb) mod N ;
        /// Ka==kb
        /// </summary>
        public BigInteger Ka;
        public BigInteger Kb;

        
        public DiffieHellmanScheme(int countBits)
        {
            N = LargePrimeGenertor.Next(countBits);
            G = PrimitiveRoot.GetRoots(N,1)[0];
            while ((Xa = LargePrimeGenertor.Next(countBits)) >= N) ;
            while ((Xb = LargePrimeGenertor.Next(countBits)) >= N) ;
            Ya = BigInteger.ModPow(G, Xa, N);
            Yb = BigInteger.ModPow(G, Xb, N);
            Ka= BigInteger.ModPow(Yb, Xa, N);
            Kb= BigInteger.ModPow(Ya, Xb, N);

        }
        public DiffieHellmanScheme(BigInteger N, BigInteger Xa, BigInteger Xb)
        {
            this.N = N;
            G = PrimitiveRoot.GetRoots(N, 1)[0];
            this.Xa = Xa;
            this.Xb = Xb;
            Ya = BigInteger.ModPow(G, Xa, N);
            Yb = BigInteger.ModPow(G, Xb, N);
            Ka = BigInteger.ModPow(Yb, Xa, N);
            Kb = BigInteger.ModPow(Ya, Xb, N);

        }

        public override string ToString()
        {

            return "n=" + N + "\t" + LargePrimeGenertor.GetBinary(N)
                + "\ng=" + G + "\t" + LargePrimeGenertor.GetBinary(G)
                + "\nXa=" + Xa + "\t" + LargePrimeGenertor.GetBinary(Xa)
                + "\nXb=" + Xb + "\t" + LargePrimeGenertor.GetBinary(Xb)
                + "\nYa=" + Ya + "\t" + LargePrimeGenertor.GetBinary(Ya)
                + "\nYb=" + Yb + "\t" + LargePrimeGenertor.GetBinary(Yb)
                + "\nKa=" + Ka + "\t" + LargePrimeGenertor.GetBinary(Ka)
                + "\nKb=" + Kb + "\t" + LargePrimeGenertor.GetBinary(Kb);
        }
    }
}
