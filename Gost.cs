using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMiSOIB
{
    class Gost
    {
        private string message;
        private string key;

        //Подстановочная таблица
        private readonly int[,] substituteTable = new int[,]
        {
           // 0  1   2  3  4  5  6   7
            { 1, 13, 4, 6, 7, 5, 14, 4 },       //0
            { 15, 11, 11, 12, 13, 8, 11, 10 },  //1
            { 13, 4, 10, 7, 10, 4, 4, 9 },      //2
            { 0, 1, 0, 1, 1, 13, 12, 2 },       //3
            { 5, 3, 7, 5, 0, 10, 6, 13 },       //4
            { 7, 15, 2, 15, 8, 3, 13, 8 },      //5
            { 10, 5, 1, 13, 9, 4, 15, 0 },      //6
            { 4, 9, 13, 8, 15, 2, 10, 14 },     //7
            { 9, 0, 3, 4, 14, 14, 2, 6 },       //8
            { 2, 10, 6, 10, 4, 15, 3, 11 },     //9
            { 3, 14, 8, 9, 6, 12, 8, 1 },       //10
            { 14, 7, 5, 14, 12, 7, 1, 12 },     //11
            { 6, 6, 9, 0, 11, 6, 0, 7 },        //12
            { 11, 8, 12, 3, 2, 0, 7, 15 },      //13
            { 8, 2, 15, 11, 5, 9, 5, 5 },       //14
            { 12, 12, 14, 2, 3, 11, 9, 3 }     //15
        };

        public string l0, r0, x0, fR0X0, filled, shifted, r1;
        public Gost(string message, string key)
        {
            this.message = message;
            this.key = key;
            Init();
        }
        private void Init()
        {
            var r0_str = message.Substring(message.Length / 2, message.Length / 2);
            r0 = Utills.StickedBinaryMsg(r0_str);

            var x0_str = key;
            x0 = Utills.StickedBinaryMsg(x0_str);

            fR0X0 = Utills.Modulo2Pow32(r0, x0);

            filled = SubstituteElements(fR0X0);

            shifted = Utills.Shift(filled, -11);

            var l0_str = message.Substring(0, message.Length / 2);
            l0 = Utills.StickedBinaryMsg(l0_str);

            r1 = Utills.Modulo2(l0, shifted);
        }
        //Функция подстановки
        private string SubstituteElements(string str)
        {
            StringBuilder substitutedStr = new StringBuilder();
            string[] blocks = Utills.BinaryFormat(str, 4).Split(' ');
            int col = 0;
            int row;
            foreach (var b in blocks)
            {
                row = Convert.ToInt32(b, 2);
                substitutedStr.Append(Utills.BinaryFormat(Convert.ToString(substituteTable[row, col], 2), 4));
                col++;
            }
            return substitutedStr.ToString();
        }
    }
}
