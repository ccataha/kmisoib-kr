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
    /// Логика взаимодействия для HashFunction.xaml
    /// </summary>
    public partial class HashFunctionWindow : Window
    {
        public HashFunctionWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HashFunction hashFunction = new HashFunction(MessageTB.Text, int.Parse(pTB.Text), int.Parse(qTB.Text), int.Parse(H0TB.Text));
            resTB.Text = hashFunction.Hash().ToString();
        }
        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
