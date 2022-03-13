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

namespace WpfHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            string s;

            if (txtName.Text.Length < 3)
            {
                MessageBox.Show("Name should be at least 2 characters long.");
            }
            else
            {
                // MessageBox.Show("Hello. " + txtName.Text + "\nThis is something, I guess...");
                foreach (var item in mainGrid.Children)
                {
                    if (item is TextBox)
                    {
                        s = ((TextBox)item).Text;
                        s = s + '\n';
                        MessageBox.Show("Hello. " + s + "\nThis is something, I guess...");
                    }
                }
            }

        }
    }
}
