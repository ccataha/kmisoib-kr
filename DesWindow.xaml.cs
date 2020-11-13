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
    /// Логика взаимодействия для DesWindow.xaml
    /// </summary>
    public partial class DesWindow : Window
    {
        public DesWindow()
        {
            InitializeComponent();
        }

        private void Proceed_Button_Click(object sender, RoutedEventArgs e)
        {
            string message = MessageTB.Text;
            string key = KeyTB.Text;
            Des des = new Des(message, key);

            MessageBinaryTB.Text = Utills.BinaryFormat(des.msgBinary, 8);
            SubstituteTB.Text = Utills.BinaryFormat(des.sbstMsg, 8);
            LBlockTB.Text = Utills.BinaryFormat(des.l, 4);
            RBlockTB.Text = Utills.BinaryFormat(des.r, 4);
            ExtenderRTB.Text = Utills.BinaryFormat(des.extendedBlockR, 6);
            KeyBinaryTB.Text = Utills.BinaryFormat(des.keyBinary, 6);
            SumTB.Text = Utills.BinaryFormat(des.sumKeyAndExtR, 6);
            Substitute2TB.Text = Utills.BinaryFormat(des.anotherSubstitute, 4);
            ConcatAndSumTB.Text = Utills.BinaryFormat(des.substSum, 8);
        }
        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void KeyTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
