using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KMiSOIB
{
    /// <summary>
    /// Логика взаимодействия для GostWindow.xaml
    /// </summary>
    public partial class GostWindow : Window
    {
        public GostWindow()
        {
            InitializeComponent();
            //MessageTB.CharacterCasing = CharacterCasing.Upper;
            //KeyTB.CharacterCasing = CharacterCasing.Upper;
        }
        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            string message = MessageTB.Text;
            string key = KeyTB.Text;
            Gost gost = new Gost(message, key);

            var r0_str = message.Substring(message.Length / 2, message.Length / 2);
            var r0_dex = gost.ConvertToDex(r0_str);
            var r0 = string.Join("", r0_dex.Select(i => gost.AddFrontZero(Convert.ToString(i, 2), 8)));
            Console.WriteLine("r0: + " + r0_str + ",  " + gost.DivideByBlock(r0, 4) + ", " + r0.Length);

            var x0_str = key;
            var x0_dex = gost.ConvertToDex(x0_str);
            var x0 = string.Join("", x0_dex.Select(i => gost.AddFrontZero(Convert.ToString(i, 2), 8)));
            Console.WriteLine("x0: " + x0_str + ",  " + gost.DivideByBlock(x0, 4) + ", " + x0.Length);

            var r0x0 = gost.SumMod2Pow32(r0, x0);
            Console.WriteLine("f(r0, x0): " + gost.DivideByBlock(r0x0, 4));

            var filled = gost.Fill(r0x0);
            //Console.WriteLine(gost.DivideByBlock(filled, 4));
            Console.WriteLine("filled: " + gost.DivideByBlock(filled, 4));

            var shifted = gost.Shift(filled, -11);
            Console.WriteLine("shifted: " + gost.DivideByBlock(shifted, 4));

            var l0_str = TB.Text.Substring(0, TB.Text.Length / 2);
            var l0_dex = gost.ConvertToDex(l0_str);
            var l0 = string.Join("", l0_dex.Select(i => gost.AddFrontZero(Convert.ToString(i, 2), 8)));
            var r1 = gost.SumMod2(l0, shifted);
            Console.WriteLine("l0:      " + gost.DivideByBlock(l0, 4));
            Console.WriteLine("r1       " + gost.DivideByBlock(r1, 4));*/
            string message = MessageTB.Text;
            string key = KeyTB.Text;
            Gost gost = new Gost(message, key);

            /*L0TB.Text = Utills.DivideIntoBlocks(gost.l0, 4);
            R0TB.Text = Utills.DivideIntoBlocks(gost.r0, 4);
            R0TB.Text = Utills2.BinaryFormat(gost.r0, 4);
            X0TB.Text = Utills.DivideIntoBlocks(gost.x0, 4);
            fR0X0TB.Text = Utills.DivideIntoBlocks(gost.fR0X0, 4);
            SubstitutionTB.Text = Utills.DivideIntoBlocks(gost.filled, 4);
            ShiftTB.Text = Utills.DivideIntoBlocks(gost.shifted, 4);
            R1TB.Text = Utills.DivideIntoBlocks(gost.r1, 4);*/

            L0TB.Text = Utills.BinaryFormat(gost.l0, 4);
            R0TB.Text = Utills.BinaryFormat(gost.r0, 4);
            R0TB.Text = Utills.BinaryFormat(gost.r0, 4);
            X0TB.Text = Utills.BinaryFormat(gost.x0, 4);
            fR0X0TB.Text = Utills.BinaryFormat(gost.fR0X0, 4);
            SubstitutionTB.Text = Utills.BinaryFormat(gost.filled, 4);
            ShiftTB.Text = Utills.BinaryFormat(gost.shifted, 4);
            R1TB.Text = Utills.BinaryFormat(gost.r1, 4);
        }
    }
}
