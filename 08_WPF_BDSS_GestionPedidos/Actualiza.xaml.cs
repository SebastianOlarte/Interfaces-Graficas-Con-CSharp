using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Windows.Shapes;
using System.Configuration;

namespace _08_WPF_BDSS_GestionPedidos
{
    /// <summary>
    /// Interaction logic for Actualiza.xaml
    /// </summary>
    public partial class Actualiza : Window
    {
        SqlConnection miConexionSql;

        private int ID_Cliente;

        public Actualiza(int elIDcliente)
        {
            InitializeComponent();

            string miCadenaConexion = ConfigurationManager.ConnectionStrings["PildorasInformaticasConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(connectionString: miCadenaConexion);

            ID_Cliente = elIDcliente;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "UPDATE CLIENTE SET NOMBRE = @nombre, DIRECCION = @direccion, POBLACION = @poblacion, TELEFONO = @telefono " +
                                  "WHERE ID = " + ID_Cliente;

                SqlCommand miSqlCommand = new SqlCommand(cmdText: consulta, connection: miConexionSql);

                miConexionSql.Open();

                miSqlCommand.Parameters.AddWithValue(parameterName: "@nombre", value: cuadroActualizaNombre.Text);
                miSqlCommand.Parameters.AddWithValue(parameterName: "@direccion", value: cuadroActualizaDireccion.Text);
                miSqlCommand.Parameters.AddWithValue(parameterName: "@poblacion", value: cuadroActualizaPoblacion.Text);
                miSqlCommand.Parameters.AddWithValue(parameterName: "@telefono", value: cuadroActualizaTelefono.Text);

                int clientesActualizados = miSqlCommand.ExecuteNonQuery();

                if (clientesActualizados > 0)
                {
                    MessageBox.Show($"SE HA ACTUALIZADO EL CLIENTE -- {cuadroActualizaNombre.Text} -- CORRECTAMENTE");

                    cuadroActualizaNombre.Text = "";
                    cuadroActualizaDireccion.Text = "";
                    cuadroActualizaPoblacion.Text = "";
                    cuadroActualizaTelefono.Text = "";
                 }
                else
                {
                    MessageBox.Show($"NO SE HA PODIDO ACTUALIZAR EL CLIENTE CON SU NUEVO NOMBRE -- {cuadroActualizaNombre.Text} -- EN EL SISTEMA");
                }

                Close();
                //this.Close();//El codigo de arriba puede ser reemplazado por esta linea de codigo. Ambas lineas hacen exactamente lo mismo.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                miConexionSql.Close();
            }
        }
    }
}
