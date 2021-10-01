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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button_Cab_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Lesson_Click(object sender, RoutedEventArgs e)
        {
            var m = new Lessons();
            m.Show();
            this.Close();
        }

        private void Button_Test_Click(object sender, RoutedEventArgs e)
        {
            var m = new Test_Main();
            m.Show();
            this.Close();
        }

        private void Button_Spravka_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
