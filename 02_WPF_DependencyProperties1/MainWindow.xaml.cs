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

namespace _02_WPF_DependencyProperties1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// EN ESTA APLICACION SE PONE EN PRACTICA EL CONCEPT DE DEPENDENCY PROPERTIES (PROPIEDADES DE DEPENDENCIA).
    /// SE ESTUDIARÁ QUÉ ES Y CÓMO CONSTRUIR NUESTRA PORPIA DEPENDENCY PROPERTIES.
    /// LAS DEPENDENCY PROPERTIES SON PROPIEDADES QUE DEPENDEN DEL SISTEMA DE PROPIEDADES DE WPF PARA SU COMPLETO FUNCIONAMIENTO.
    /// PERO ¿QUÉ ES EL SISTEMA DE PROPIEDADES DE WPF?:
    ///     ES UN CONJUNTO DE SERVICIOS QUE SE PUEDEN UTILIZAR PARA AMPLIAR LA FUNCIONALIDAD DE UNA PROPIEDAD. PODEMOS HACER QUE UNA PROPIEDAD
    ///     DE UN DETERMINADO OBJETO EXTIENDA SU FUNCIONAMIENTO, ES DECIR, QUE SEA MÁS FUNCIONAL, QUE HAGA MÁS COSAS.
    /// EL SISTEMA DE PROPIEDADES LE PROPORCIONA A ESTAS PROPIEDADES TODO LO QUE ESTAS NECESITAN PARA PODER EXTENDER SU FUNCIONAMIENTO.
    /// POR ELLO SON PROPIEDADES DEPENDIENTES, YA QUE DEPENDEN/NECESITAN DEL SISTEMA DE PROPIEDADES DE WPF.
    /// ¿POR QUÉ UTILIZAR ESTE SISTEMA DE DEPENDENCIA?:
    ///     PARA PODER ESTABLECER LAS PROPIEDADES DE UN CONTROL EN FUNCION DE OTROS PARAMETROS QUE PUEDEN CAMBIAR (JUST IN TIME).
    /// ¿QUÉ PARAMETROS PUEDEN CAMBIAR PARA ESTABLECER LA PROPIEDAD DE UN CONTROL? - ¿POR QUÉ SON NECESARIAS ESTAS DEPENDENCY PROPERTIES?
    ///     - PROPIEDADES DEL SISTEMA (TEMAS Y PREFERENCIAS DE USUARIO)
    ///     - DATA BINDING (JUST IN TIME)
    ///     - ANIMACIONES
    ///     - ESTILOS
    ///     - ETC
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        //PROPIEDAD QUE VAMOS A CREAR
        public int MiProperty
        {
            get { return (int)GetValue(dp: MiDependencyProperty); }
            set { SetValue(dp: MiDependencyProperty, value: value); }
        }

        //SE REGISTRA LA DEPENDENCY PROPERTIE QUE VAMOS A CREAR, PARA QUE NUESTRA APLICACION SEA CAPAZ DE RECONOCER ESTA DEPENDENCY PROPERTIE
        public static readonly DependencyProperty MiDependencyProperty =
            DependencyProperty.Register(name: "MiProperty", propertyType: typeof(int), ownerType: typeof(MainWindow), typeMetadata: new PropertyMetadata(0));


        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
