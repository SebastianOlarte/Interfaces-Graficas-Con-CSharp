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

namespace _01_WPF_InterfacesGraficas3
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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HAS DADO CLICK EN EL BOTÓN NUMERO 1");
            //Console.WriteLine("HAS DADO CLICK EN EL BOTÓN NUMERO 1");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HAS DADO CLICK EN EL BOTÓN NUMERO 2");
            //Console.WriteLine("HAS DADO CLICK EN EL BOTÓN NUMERO 2");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HAS DADO CLICK EN EL BOTÓN NUMERO 3");
            //Console.WriteLine("HAS DADO CLICK EN EL BOTÓN NUMERO 3");
        }

        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HAS DADO CLICK EN EL STACK PANEL");
            //Console.WriteLine("HAS DADO CLICK EN EL STACK PANEL");
        }
    }
}
