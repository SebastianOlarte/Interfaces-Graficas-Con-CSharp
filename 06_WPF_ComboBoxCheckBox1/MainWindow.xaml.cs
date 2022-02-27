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

namespace _06_WPF_ComboBoxCheckBox1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> listaCapitales = new List<Capitales>();

            listaCapitales.Add(new Capitales { NombreCapital = "Madrid" });
            listaCapitales.Add(new Capitales { NombreCapital = "Bogotá" });
            listaCapitales.Add(new Capitales { NombreCapital = "París" });
            listaCapitales.Add(new Capitales { NombreCapital = "Berlín" });
            listaCapitales.Add(new Capitales { NombreCapital = "Lima" });
            listaCapitales.Add(new Capitales { NombreCapital = "Buenos Aires" });
            listaCapitales.Add(new Capitales { NombreCapital = "Santiago" });

            Capitales.ItemsSource = listaCapitales;
        }

        private void TodasCapitales_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Bogota.IsChecked = true;
            Paris.IsChecked = true;
            Berlin.IsChecked = true;
            Lima.IsChecked = true;
            BuenosAires.IsChecked = true;
            Santiago.IsChecked = true;

            if (true)
            {
                
            }
            else
            {

            }
        }

        private void TodasCapitales_Unchecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Bogota.IsChecked = false;
            Paris.IsChecked = false;
            Berlin.IsChecked = false;
            Lima.IsChecked = false;
            BuenosAires.IsChecked = false;
            Santiago.IsChecked = false;
        }

        private void One_Capital_Checked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == true
              && Bogota.IsChecked == true
              && Paris.IsChecked == true
              && Berlin.IsChecked == true
              && Lima.IsChecked == true
              && BuenosAires.IsChecked == true
              && Santiago.IsChecked == true)
            {
                TodasCapitales.IsChecked = true;
            }
            else
            {
                TodasCapitales.IsChecked = null;
            }
        }

        private void One_Capital_UnChecked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == false
              && Bogota.IsChecked == false
              && Paris.IsChecked == false
              && Berlin.IsChecked == false
              && Lima.IsChecked == false
              && BuenosAires.IsChecked == false
              && Santiago.IsChecked == false)
            {
                TodasCapitales.IsChecked = false;
            }
            else
            {
                TodasCapitales.IsChecked = null;
            }
        }
    }
}
