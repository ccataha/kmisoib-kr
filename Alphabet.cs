using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMiSOIB
{
    static class Alphabet
    {
        private static int spaceNum = 32;
        public static int GetCharCode(char ch)
        {
            int chBase10;

            if (ch >= 'а' && ch <= 'я') chBase10 = ch % 1072 + 224;
            else if (ch >= 'А' && ch <= 'Я') chBase10 = ch % 1040 + 192;
            else if (ch == ' ') chBase10 = spaceNum;
            else throw new Exception($"Неподдерживаемый символ {ch}");

            return chBase10;
        }

        public static char GetChar(int num)
        {
            if (num >= 192 && num <= 223) return (char)(num % 32 + 1040);
            else if (num >= 224 && num <= 255) return (char)(num % 32 + 1072);
            else return ' ';
        }

        public static int GetCharCodeRSA(char ch)
        {
            int chBase10;

            if (ch == 'А' || ch == 'а') chBase10 = 1;
            else if (ch == 'Б' || ch == 'б') chBase10 = 2;
            else if (ch == 'В' || ch == 'в') chBase10 = 3;
            else if (ch == 'Г' || ch == 'г') chBase10 = 4;
            else if (ch == 'Д' || ch == 'д') chBase10 = 5;
            else if (ch == 'Е' || ch == 'е') chBase10 = 6;
            else if (ch == 'Ж' || ch == 'ж') chBase10 = 7;
            else if (ch == 'З' || ch == 'з') chBase10 = 8;
            else if (ch == 'И' || ch == 'и') chBase10 = 9;
            else if (ch == 'Й' || ch == 'й') chBase10 = 10;
            else if (ch == 'К' || ch == 'к') chBase10 = 11;
            else if (ch == 'Л' || ch == 'л') chBase10 = 12;
            else if (ch == 'М' || ch == 'м') chBase10 = 13;
            else if (ch == 'Н' || ch == 'н') chBase10 = 14;
            else if (ch == 'О' || ch == 'о') chBase10 = 15;
            else if (ch == 'П' || ch == 'п') chBase10 = 16;
            else if (ch == 'Р' || ch == 'р') chBase10 = 17;
            else if (ch == 'С' || ch == 'с') chBase10 = 18;
            else if (ch == 'Т' || ch == 'т') chBase10 = 19;
            else if (ch == 'У' || ch == 'у') chBase10 = 20;
            else if (ch == 'Ф' || ch == 'ф') chBase10 = 21;
            else if (ch == 'Х' || ch == 'х') chBase10 = 22;
            else if (ch == 'Ц' || ch == 'ц') chBase10 = 23;
            else if (ch == 'Ч' || ch == 'ч') chBase10 = 24;
            else if (ch == 'Ш' || ch == 'ш') chBase10 = 25;
            else if (ch == 'Щ' || ch == 'щ') chBase10 = 26;
            else if (ch == 'Ъ' || ch == 'ъ') chBase10 = 27;
            else if (ch == 'Ы' || ch == 'ы') chBase10 = 28;
            else if (ch == 'Ь' || ch == 'ь') chBase10 = 29;
            else if (ch == 'Э' || ch == 'э') chBase10 = 30;
            else if (ch == 'Ю' || ch == 'ю') chBase10 = 31;
            else if (ch == 'Я' || ch == 'я') chBase10 = 32;
            else throw new Exception($"Неподдерживаемый символ {ch}");
            return chBase10;
        }

        public static char GetCharRSA(int num)
        {
            if (num == 1) return 'А';
            if (num == 2) return 'Б';
            if (num == 3) return 'В';
            if (num == 4) return 'Г';
            if (num == 5) return 'Д';
            if (num == 6) return 'Е';
            if (num == 7) return 'Ж';
            if (num == 8) return 'З';
            if (num == 9) return 'И';
            if (num == 10) return 'Й';
            if (num == 11) return 'К';
            if (num == 12) return 'Л';
            if (num == 13) return 'М';
            if (num == 14) return 'Н';
            if (num == 15) return 'О';
            if (num == 16) return 'П';
            if (num == 17) return 'Р';
            if (num == 18) return 'С';
            if (num == 19) return 'Т';
            if (num == 20) return 'У';
            if (num == 21) return 'Ф';
            if (num == 22) return 'Х';
            if (num == 23) return 'Ц';
            if (num == 24) return 'Ч';
            if (num == 25) return 'Ш';
            if (num == 26) return 'Щ';
            if (num == 27) return 'Ъ';
            if (num == 28) return 'Ы';
            if (num == 29) return 'Ь';
            if (num == 30) return 'Э';
            if (num == 31) return 'Ю';
            else if (num == 32) return 'Я';
            else return ' ';
        }
    }
}
