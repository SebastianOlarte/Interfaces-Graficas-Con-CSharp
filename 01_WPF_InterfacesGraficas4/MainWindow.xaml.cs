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

namespace _01_WPF_InterfacesGraficas4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// EN ESTA APLICACION SE PONE EN PRACTICA EL CONCEPTO DE GRID O GRILLA
    /// EL GRID ES EL CONTENEDOR WPF MÁS VERSATIL. CONSISTE EN UNA DIVISION DEL CONTENEDOR EN FILAS Y COLUMNAS. CADA COLUMNA Y FILA PUEDEN TOMAR
    /// DIFERENTES VALORES DE TAMAÑO
    ///     - ABSOLUTO: VALORES EN PIXELES
    ///     - AUTOMATICO: VALOR QUE NECESITA DEL ELEMENTO ANTERIOR
    ///     - PROPORCIONAL: VALOR DISPONIBLE ASIGNADO DE FORMA PROPORCIONAL
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
