using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMiSOIB
{
    static class Utills
    {
        public static string Shift(string msg, int offset)
        {
            char[] shiftedMsg = new char[msg.Length];

            for (int i = 0; i < msg.Length; i++)
            {
                int newPos = (i + offset) % msg.Length;
                if (newPos < 0) newPos = msg.Length + newPos;
                shiftedMsg[newPos] = msg[i];
            }

            return new string(shiftedMsg);
        }
        public static string ConverToBase2(int num) { return Convert.ToString(num, 2).PadLeft(8, '0'); }

        public static string StickedBinaryMsg(string msg)
        {
            StringBuilder stickedBinaryMsg = new StringBuilder();

            foreach (char ch in msg)
                stickedBinaryMsg.Append(ConverToBase2(Alphabet.GetCharCode(ch)));
            return stickedBinaryMsg.ToString();
        }
        public static string BinaryFormat(string binaryStr, int blockSize)
        {
            StringBuilder formattedBinaryStr = new StringBuilder(binaryStr);

            if (binaryStr.Length < blockSize)
            {
                for (int i = 0; i < blockSize - binaryStr.Length; i++)
                    formattedBinaryStr.Insert(0, '0');
            }
            else
                for (int i = 0; i < formattedBinaryStr.Length; i += blockSize + 1)
                    formattedBinaryStr.Insert(i, ' ');
            return formattedBinaryStr.ToString().Trim();
        }
        public static string Modulo2Pow32(string x, string y)
        {
            int len = 32;
            int num1 = Convert.ToInt32(x, 2);
            int num2 = Convert.ToInt32(y, 2);
            int sum = num1 + num2;
            string result = Convert.ToString(sum, 2);
            result = result.Substring(result.Length - len, len);
            return result;
        }
        public static string Modulo2(string x, string y, int pad = 32)
        {
            long num1 = Convert.ToInt64(x, 2);
            long num2 = Convert.ToInt64(y, 2);
            long sum = num1 ^ num2;
            string result = Convert.ToString(sum, 2).PadLeft(pad, '0');

            return result;
        }
    }
}
