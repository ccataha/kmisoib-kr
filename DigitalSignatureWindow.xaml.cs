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
    /// Логика взаимодействия для DsWindow.xaml
    /// </summary>
    public partial class DigitalSignatureWindow : Window
    {
        public DigitalSignatureWindow()
        {
            InitializeComponent();
        }

        private void Proceed_Button_Click(object sender, RoutedEventArgs e)
        {
            DigitalSignature ds = new DigitalSignature(int.Parse(HashTB.Text), PrivateKeyTB.Text, PublicKeyTB.Text);
            EncryptedTB.Text = ds.Encrypt().ToString();
            DecryptedTB.Text = ds.Decrypt().ToString();
        }
        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
