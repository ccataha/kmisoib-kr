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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class RsaWindow : Window
    {
        public RsaWindow()
        {
            InitializeComponent();
        }

        private void RraTB_Click(object sender, RoutedEventArgs e)
        {
            ClearTextBox(nTB, phiTB, eTB, PublicKeyTB, PrivateKeyTB, EncryptedTB, DecryptTB);

            RSA rsa = new RSA(MessageTB.Text, int.Parse(pTB.Text), int.Parse(qTB.Text), int.Parse(dTB.Text));
            nTB.Text = rsa.n.ToString();
            phiTB.Text = rsa.phi.ToString();
            eTB.Text = rsa.e.ToString();
            PublicKeyTB.Text = rsa.GetPublicKey();
            PrivateKeyTB.Text = rsa.GetPrivateKey();
            EncryptedTB.Text = rsa.Encrypt();
            DecryptTB.Text = rsa.Decrypt();
        }
        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ClearTextBox(params TextBox[] elements)
        {
            foreach (var e in elements) { e.Clear(); }
        }
    }
}
