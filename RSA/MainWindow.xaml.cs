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
using System.Windows.Navigation;
using System.Windows.Shapes;
using RSAEncryptionDecryption_Name;

namespace RSA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public RSAEncryptionDecryption RSA = new RSAEncryptionDecryption();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // encrypt
        {
            cipherTextBox.Text = RSA.Encrypt(long.Parse(plainTextBox.Text)).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // decrypt
        {
            plainTextBox.Text = RSA.Decrypt(long.Parse(cipherTextBox.Text)).ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // key generation
        {
            RSA.GenerateKeys();

            pTextBox.Text = RSA.publicKeys[2].ToString();
            qTextBox.Text = RSA.publicKeys[3].ToString();
            nTextBox.Text = RSA.publicKeys[1].ToString();
            oTextBox.Text = RSA.publicKeys[4].ToString();
            eTextBox.Text = RSA.publicKeys[0].ToString();
            dTextBox.Text = RSA.publicKeys[5].ToString();
        }        
    }
}
