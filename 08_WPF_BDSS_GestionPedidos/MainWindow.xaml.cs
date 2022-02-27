using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Data.SqlClient;
using System.Data;

namespace _08_WPF_BDSS_GestionPedidos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection miConexionSql;

        public MainWindow()
        {
            InitializeComponent();

            string miCadenaConexion = ConfigurationManager.ConnectionStrings["PildorasInformaticasConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(connectionString: miCadenaConexion);

            MuestraClientes();

            MuestraTodosPedidos();
        }

        private void MuestraClientes()
        {
            try
            {
                string consulta = "SELECT * FROM CLIENTE";

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(selectCommandText: consulta, selectConnection: miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable clientesTabla = new DataTable();

                    miAdaptadorSql.Fill(dataTable: clientesTabla);

                    listaClientes.ItemsSource = clientesTabla.DefaultView;
                    listaClientes.DisplayMemberPath = "nombre";
                    listaClientes.SelectedValuePath = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MuestraPedidos()
        {
            try
            {
                string consulta = @"SELECT * FROM PEDIDO P INNER JOIN CLIENTE C ON C.Id = P.codCliente " +
                                "WHERE C.Id = @ClienteId ORDER BY FECHAPEDIDO";

                SqlCommand miComandoSql = new SqlCommand(cmdText: consulta, connection: miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(selectCommand: miComandoSql);

                using (miAdaptadorSql)
                {
                    miComandoSql.Parameters.AddWithValue(parameterName: "@ClienteId", value: listaClientes.SelectedValue);

                    DataTable pedidosCliente = new DataTable();

                    miAdaptadorSql.Fill(dataTable: pedidosCliente);

                    listaPedidosCliente.ItemsSource = pedidosCliente.DefaultView;
                    listaPedidosCliente.DisplayMemberPath = "fechaPedido";
                    listaPedidosCliente.SelectedValuePath = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MuestraTodosPedidos()
        {
            try
            {
                //string consulta = "SELECT * FROM PEDIDO";

                //SE USARÁ UN CAMPO CALCULADO PARA ASÍ PODER MOSTRAR TODOS LOS CAMPOS DE LA TABLA PEDIDOS USANDO LA 
                //PROPIEDAD DisplayMemberPath
                string consulta = "SELECT *, CONCAT('| Cliente ',CODCLIENTE,' | ',FECHAPEDIDO,' | ',FORMAPAGO,' |') AS INFO_TOTAL FROM PEDIDO "
                                + "ORDER BY CODCLIENTE";

                //PRIMERA FORMA DE INSTANCIAR Y USAR EL APADTADOR DE SQL
                //SqlCommand miComandoSql = new SqlCommand(cmdText: consulta, connection: miConexionSql);
                //SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(selectCommand: miComandoSql);

                //OTRA FORMA DE INSTANCIAR Y USAR EL ADAPTADOR DE SQL
                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(selectCommandText: consulta, selectConnection: miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable todosLosPedidos = new DataTable();

                    miAdaptadorSql.Fill(dataTable: todosLosPedidos);

                    listaTodosPedidos.ItemsSource = todosLosPedidos.DefaultView;
                    listaTodosPedidos.DisplayMemberPath = "INFO_TOTAL";
                    listaTodosPedidos.SelectedValuePath = "Id";
                    //listaTodosPedidos.SelectedValuePath = "codCliente";
                    //listaTodosPedidos.SelectedValuePath = "fechaPedido";
                    //listaTodosPedidos.SelectedValuePath = "formaPago";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    MuestraPedidos();
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("HAS SELECCIONADO EL BOTON DE ELIMINAR PARA EL REGISTRO CON EL ID = "+
                                 listaTodosPedidos.SelectedValue.ToString());

                string consulta = "DELETE FROM PEDIDO WHERE ID = @IdPedido";

                SqlCommand miSqlCommand = new SqlCommand(cmdText: consulta, connection: miConexionSql);

                miConexionSql.Open();

                miSqlCommand.Parameters.AddWithValue(parameterName: "@IdPedido", value: listaTodosPedidos.SelectedValue);

                int pedidosEliminados = miSqlCommand.ExecuteNonQuery();

                MessageBox.Show($"SE HAN ELIMINADO {pedidosEliminados} PEDIDOS DE LA BASE DE DATOS. EL PEDIDO CON ID = {listaTodosPedidos.SelectedValue.ToString()}");

                MuestraTodosPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                miConexionSql.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "INSERT INTO CLIENTE (nombre) VALUES (@nombre)";

                SqlCommand miSqlCommand = new SqlCommand(cmdText: consulta, connection: miConexionSql);

                miConexionSql.Open();

                miSqlCommand.Parameters.AddWithValue(parameterName: "@nombre", value: txtInsertaCliente.Text);

                int clientesIngresados = miSqlCommand.ExecuteNonQuery();

                if (clientesIngresados > 0)
                {
                    MessageBox.Show($"SE HA INGRESADO EL NUEVO CLIENTE -- {txtInsertaCliente.Text} -- CORRECTAMENTE");

                    txtInsertaCliente.Text = "";
                }
                else
                {
                    MessageBox.Show($"NO SE HA PODIDO INGRESAR EL CLIENTE -- {txtInsertaCliente.Text} -- EN EL SISTEMA");
                }

                MuestraClientes();
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "DELETE FROM CLIENTE WHERE ID = @IdCliente";

                SqlCommand miSqlcommand = new SqlCommand(cmdText: consulta, connection: miConexionSql);

                miConexionSql.Open();

                miSqlcommand.Parameters.AddWithValue(parameterName: "@IdCliente", value: listaClientes.SelectedValue);

                int clientesEliminados = miSqlcommand.ExecuteNonQuery();

                if (clientesEliminados > 0)
                {
                    MessageBox.Show($"SE HAN ELIMINADO {clientesEliminados} CLIENTES DE LA BASE DE DATOS. EL CLIENTE CON ID = {listaClientes.SelectedValue.ToString()}");
                }
                else
                {
                    MessageBox.Show("NO SE HA PODIDO ELIMINAR EL CLIENTE SELECCIONADO");
                }

                MuestraClientes();
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

        private void listaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MuestraPedidos();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Actualiza ventanaActualizar = new Actualiza(elIDcliente: Convert.ToInt32(listaClientes.SelectedValue));

            ventanaActualizar.Show();

            try
            {
                string consulta = "SELECT NOMBRE, DIRECCION, POBLACION, TELEFONO FROM CLIENTE WHERE ID = @ClId";

                SqlCommand miSqlCommand = new SqlCommand(cmdText: consulta, connection: miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(selectCommand: miSqlCommand);

                using (miAdaptadorSql)
                {
                    miSqlCommand.Parameters.AddWithValue(parameterName: "@ClId", value: listaClientes.SelectedValue);

                    DataTable clientesTabla = new DataTable();

                    miAdaptadorSql.Fill(dataTable: clientesTabla);
                    
                    ventanaActualizar.cuadroActualizaNombre.Text = clientesTabla.Rows[0]["NOMBRE"].ToString();
                    ventanaActualizar.cuadroActualizaDireccion.Text = clientesTabla.Rows[0]["DIRECCION"].ToString();
                    ventanaActualizar.cuadroActualizaPoblacion.Text = clientesTabla.Rows[0]["POBLACION"].ToString();
                    ventanaActualizar.cuadroActualizaTelefono.Text = clientesTabla.Rows[0]["TELEFONO"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // 1RA FORMA DE MOSTRAR LOS CLIENTES ACTUALIZADOS: USANDO ESTAS DOS LINEAS DE CÓDIGO CONSEGUIMOS MOSTRAR LOS CLIENTES DESPUÉS DE ACTUALIZAR
            //ventanaActualizar.ShowDialog();
            //MuestraClientes();
        }

        private void Principal_Window_Activated(object sender, EventArgs e)
        {
            // 2DA FORMA DE MOSTRAR LOS CLIENTES ACTUALIZADOS: USANDO UNA FUNCIÓN QUE SE EJECUTA CUANDO EL EVENTO Activated DE LA VENTANA PRINCIPAL SUCEDE
            MuestraClientes();
        }
    }
}
