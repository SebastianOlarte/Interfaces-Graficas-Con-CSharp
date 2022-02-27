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

namespace _05_WPF_ListBox1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listaPob = new List<Poblaciones>();

            listaPob.Add(new Poblaciones { Poblacion1 = "Madrid", Poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = 17, DiferenciaTemp = Math.Abs(15-17)});
            listaPob.Add(new Poblaciones { Poblacion1 = "Medellín", Poblacion2 = "Manizales", Temperatura1 = 20, Temperatura2 = 18, DiferenciaTemp = Math.Abs(20 - 18) });
            listaPob.Add(new Poblaciones { Poblacion1 = "Sevilla", Poblacion2 = "Coruña", Temperatura1 = 9, Temperatura2 = 22, DiferenciaTemp = Math.Abs(9 - 22) });
            listaPob.Add(new Poblaciones { Poblacion1 = "Málaga", Poblacion2 = "Valencia", Temperatura1 = 30, Temperatura2 = 10, DiferenciaTemp = Math.Abs(30 - 10) });

            listaPoblaciones.ItemsSource = listaPob;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " °C " +
                                (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " °C ");
            }
            else
            {
                MessageBox.Show(messageBoxText: "NO HAY UN ELEMENTO SELECCIONADO");
            }
            
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " °C " +
                                (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " °C ");
            }
            else
            {
                MessageBox.Show(messageBoxText: "NO HAY UN ELEMENTO SELECCIONADO");
            }
        }
    }
}
