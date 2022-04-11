using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace IB_4
{
    public static class Crypto
    {
        public static byte[] SHA_512(byte[] data) // генератор хэша на основе SHA512
        {
            byte[] res = new byte[1];

            SHA512 SHA = new SHA512Managed();

            res = SHA.ComputeHash(data);
            return res;
        }
    }
}
