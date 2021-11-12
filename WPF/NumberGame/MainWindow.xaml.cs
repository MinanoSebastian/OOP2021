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

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Num1_Click(object sender, RoutedEventArgs e)
        {
            Num1.Background = new SolidColorBrush(Colors.Blue);
        }

        private void Num2_Click(object sender, RoutedEventArgs e)
        {
            Num2.Background = new SolidColorBrush(Colors.Red);
        }

        private void Num3_Click(object sender, RoutedEventArgs e)
        {
            Num3.Background = new SolidColorBrush(Colors.PeachPuff);
        }

        private void Num4_Click(object sender, RoutedEventArgs e)
        {
            Num4.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void Num5_Click(object sender, RoutedEventArgs e)
        {
            Num5.Background = new SolidColorBrush(Colors.Green);
        }

        private void Num6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("あ");
        }
    }
}

