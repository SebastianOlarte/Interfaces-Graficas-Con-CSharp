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

namespace _04_WPF_INotifyPropertyChanged1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// EN ESTA APLICACION SE VERÁ EL USO DE LA INTERFAZ INotifyPropertyChanged
    /// ESTA INTERFAZ ES CAPAZ DE REUNIR TODOS LOS EVENTOS QUE PUEDE DESENCADENAR UN OBJETO EN UNO SOLO. LO CUAL ES MUY UTIL SI NECESITAMOS
    /// DETECTAR ALGÚN CAMBIO EN ALGUNA PROPIEDAD DEL OBJETO EN CUESTIÓN Y ASÍ PROCEDER A REALIZAR ALGUNA ACCIÓN.
    /// ESTA INTERFAZ PERMITE NOTIFICAR QUE HA HABIDO UN CAMBIO EN UNA PROPIEDAD EN CONCRETO, SIN NECESIDAD DE CREAR UN METODO ESPECIFICO 
    /// QUE SE ENCARGARÍA DE MANEJAR EL EVENTO DE CAMBIO EN ESA PROPIEDAD.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            juntaNombreyApellido = new JuntarNombre { Nombre = "SEBASTIÁN",  Apellido = "OLARTE"};

            this.DataContext = juntaNombreyApellido;
        }

        public JuntarNombre juntaNombreyApellido;
    }
}
