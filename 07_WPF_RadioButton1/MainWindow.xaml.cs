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

namespace _07_WPF_RadioButton1
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

        private void RBcolorRojo_Checked(object sender, RoutedEventArgs e)
        {
            ElipseRojo.Visibility = Visibility.Visible;
            ElipseVerde.Visibility = Visibility.Hidden;
            ElipseAmarrilla.Visibility = Visibility.Hidden;
        }

        private void RBcolorAmarillo_Checked(object sender, RoutedEventArgs e)
        {
            ElipseAmarrilla.Visibility = Visibility.Visible;
            ElipseRojo.Visibility = Visibility.Hidden;
            ElipseVerde.Visibility = Visibility.Hidden;
        }

        private void RBcolorVerde_Checked(object sender, RoutedEventArgs e)
        {
            ElipseVerde.Visibility = Visibility.Visible;
            ElipseAmarrilla.Visibility = Visibility.Hidden;
            ElipseRojo.Visibility = Visibility.Hidden;
        }
    }
}
