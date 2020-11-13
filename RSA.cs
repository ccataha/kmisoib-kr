using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KMiSOIB
{
    class RSA
    {
        string message, encryptedMessage, decryptedMessage;
        public int p { get; }
        public int q { get; }
        public int d { get; }
        public int k { get; }
        public int n { get; }
        public int phi { get; }
        public int e { get; }
        private int maxCharCode;

        public RSA(string message, int p, int q, int d)
        {
            this.message = message;
            this.p = p;
            this.q = q;
            this.d = d;

            maxCharCode = 0;

            n = p * q;
            phi = (p - 1) * (q - 1);
            e = FindE();

            FindE();
        }

        public string GetPublicKey() { return e + " " + n ; }
        public string GetPrivateKey() { return d + " " + n; }
        public string Encrypt()
        {
            foreach(var ch in message)
            {
                int charIndex = Alphabet.GetCharCodeRSA(ch);
                maxCharCode = charIndex > maxCharCode ? charIndex : maxCharCode;
                if (maxCharCode >= n) throw new Exception($"Индекс буквы {Alphabet.GetCharRSA(maxCharCode)} = {maxCharCode} больше/равно n = {n}");
                var res = BigInteger.ModPow(charIndex, e, n);
                encryptedMessage += res + " ";
            }
            return encryptedMessage;
        }
        public string Decrypt()
        {
            foreach (var ch in encryptedMessage.Trim().Split(' '))
            {
                var res = BigInteger.ModPow(int.Parse(ch), d, n);
                decryptedMessage += Alphabet.GetCharRSA(((int)res + n) % n);
            }
            return decryptedMessage;
        }
        private int FindE()
        {
            int e = 0;
            while ((d * e - 1) % phi != 0)
            {
                e++;
            }
            return e;
        }
    }
}
