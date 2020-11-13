using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KMiSOIB
{
    class HashFunction
    {
        private string message;
        public int p { get; }
        public int q { get; }
        public int n { get; }
        public int h0 { get; }
        private int hash;
        public HashFunction(string message, int p, int q, int h0)
        {
            this.message = message;
            this.p = p;
            this.q = q;
            this.h0 = h0;

            n = p * q;
        }

        private int f(int a, int b) 
        {
            return (int)BigInteger.ModPow(a + b, 2, n);
        }

        public int Hash()
        {
            hash = f(h0, Alphabet.GetCharCodeRSA(message[0]));

            foreach(var ch in message.Substring(1))
            {
                hash = f(hash, Alphabet.GetCharCodeRSA(ch));
            }
            return hash;
        }
    }
}
