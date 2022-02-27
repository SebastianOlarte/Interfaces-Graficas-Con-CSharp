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

namespace _01_WPF_InterfacesGraficas2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid miGrid = new Grid();

            this.Content = miGrid;

            Button miBoton1 = new Button();

            miBoton1.Height = 35;
            miBoton1.Width = 350;
            miBoton1.Background = Brushes.Aquamarine;


            WrapPanel miWrap = new WrapPanel();

            TextBlock txt1 = new TextBlock();

            txt1.FontSize = 16;
            txt1.Foreground = Brushes.Red;
            txt1.Text = "Clickeame!!! - ";

            miWrap.Children.Add(element: txt1);

            TextBlock txt2 = new TextBlock();

            txt2.Foreground = Brushes.Blue;
            txt2.FontSize = 16;
            txt2.Text = "Enviar - ";

            miWrap.Children.Add(element: txt2);

            TextBlock txt3 = new TextBlock();

            txt3.Foreground = Brushes.Yellow;
            txt3.FontSize = 16;
            txt3.Text = "Estoy Aprendiendo WPF";

            miWrap.Children.Add(element: txt3);



            miBoton1.Content = miWrap;

            miGrid.Children.Add(element: miBoton1);
        }
    }
}
