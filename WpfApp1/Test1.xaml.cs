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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Test1.xaml
    /// </summary>
    public partial class Test1 : Window
    {
        public Test1()
        {
            InitializeComponent();
        }

        private void Polygon_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Polygon_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Wrong.Background = new SolidColorBrush(Colors.Red);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Right.Background = new SolidColorBrush(Colors.Green);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var m = new Main();
            m.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var m = new MainWindow();
            m.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var m = new Test_Main();
            m.Show();
            this.Close();
        }
    }
}
