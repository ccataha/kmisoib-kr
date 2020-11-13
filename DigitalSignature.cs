using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KMiSOIB
{
    class DigitalSignature
    {
        public int hash { get; }
        public int[] privateKey;
        public int[] publicKey;
        private int s;
        private int h;

        public DigitalSignature(int hash, string privateKey, string publicKey)
        {
            this.hash = hash;
            this.privateKey = Array.ConvertAll(privateKey.Split(' '), int.Parse);
            this.publicKey = Array.ConvertAll(publicKey.Split(' '), int.Parse);
        }

        public int Encrypt()
        {
            s = (int)BigInteger.ModPow(hash, privateKey[0], privateKey[1]);

            return s;
        }

        public int Decrypt()
        {
            h = (int)BigInteger.ModPow(s, publicKey[0], publicKey[1]);

            return h;
        }
    }
}
