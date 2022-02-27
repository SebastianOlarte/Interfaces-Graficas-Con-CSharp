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

namespace _03_WPF_DataBinding1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// EN ESTA APLICACIÓN SE ESTUDIA QUÉ ES EL DATA BINDING Y SE PONE EN PRACTICA ESTE CONCEPTO.
    /// VEREMOS:
    ///     - ¿QUÉ ES DATA BINDING?:
    ///     PARA CONTROLES WPF UN DATA BINDING ES UN PUENTE O ENLACE, A TRAVES DEL CUAL EL CONTROL WPF ES CAPAZ DE ENVIAR Y DE RECIBIR INFORMACIÓN.
    ///     UN CONTROL WPF ES CAPAZ DE RECIBIR MUCHOS DATOS EN TIEMPO REAL, Y PARA RECBIR ESOS DATOS HACE USO DE UN DATA BINDING.
    ///     LAS FUENTES DE LAS QUE UN CONTROL WPF RECIBE INFORMACIÓN PUEDEN SER MUCHAS. UNA BBDD, OTROS OBJETOS, U OTROS CONTROLES WPF.
    ///     
    ///     - TIPOS DE DATA BINDING.
    ///         * DATA BINDING ONEWAY <---- UNA SOLA DIRECCIÓN. DESDE EL SOURCE (BBDD, OBJETOS, CONTROLES WPF) HASTA EL TARGET (EL CONTROL WPF).
    ///         * DATA BINDING ONEWAYTOSOURCE ----> UNA SOLA DIRECCION. DESDE EL SOURCE (EL CONTROL WPF) HASTA EL TARGET (BBDD, OBJETOS, CONTROLES WPF).
    ///         * DATA BINDING TWOWAYS <----> EN LAS DOS DIRECCIONES, BIDIRECCIONAL. DEL SOURCE AL TARGET Y DEL TARGET AL SOURCE.
    ///         * DATA BINDING ONETIME ----> OCURRE UNA SOLA VEZ (BBDD, OBJETOS, CONTROLES WPF). DESDE EL SOURCE HASTA EL TARGET (EL CONTROL WPF).
    ///
    ///     - EJEMPLO DE DATA BINDING ENTRE DOS CONTROLES WPF.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
