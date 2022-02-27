using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WPF_INotifyPropertyChanged1
{
    public class JuntarNombre: INotifyPropertyChanged
    {
        private string nombre, apellido, nombreCompleto;

        public event PropertyChangedEventHandler PropertyChanged;

        //ESTE SERÁ EL METODO QUE SE DESENCADENE CADA VEZ QUE CAMBIE EL VALOR DE UNA PROPIEDAD DE CUALQUIERA DE LOS COMPONENTES
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(sender: this, e: new PropertyChangedEventArgs(propertyName: property));
            }
        }

        public string Nombre
        {
            get { return nombre; }

            set
            {
                nombre = value;
                OnPropertyChanged("NombreCompleto");
            }
        }

        public string Apellido
        {
            get { return apellido; }

            set
            {
                apellido = value;
                OnPropertyChanged("NombreCompleto");
            }
        }

        public string NombreCompleto
        {
            get
            {
                nombreCompleto = Nombre + " " + Apellido;
                return nombreCompleto;
            }

            set { }
        }
    }
}
