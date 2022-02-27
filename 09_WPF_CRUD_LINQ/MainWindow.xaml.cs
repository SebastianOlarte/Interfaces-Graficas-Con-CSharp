using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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

namespace _09_WPF_CRUD_LINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext miDataContext;


        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["Crud_Linq_Sql"].ConnectionString;
            string nombreMiConexion = ConfigurationManager.ConnectionStrings["Crud_Linq_Sql"].Name;
            string proveedorMiConexion = ConfigurationManager.ConnectionStrings["Crud_Linq_Sql"].ProviderName;

            miDataContext = new DataClasses1DataContext(connection: miConexion);

            ////INSERTANDO LA 1RA EMPRESA
            //string empresa1 = "Píldoras Informáticas";
            //InsertarEmpresa(nomEmpresa: empresa1);

            ////INSERTANDO LA 2DA EMPRESA
            //string empresa2 = "Google";
            //InsertarEmpresa(nomEmpresa: empresa2);


            ////EJEMPLO DE EJECUCÓN DE COMANDOS SQL DIRECTAMENET EN LAS TABLAS DE LA BD
            //miDataContext.ExecuteCommand("DELETE FROM EMPRESA");


            ////INSERTANDO UN LISTADO INICIAL DE EMPLEADOS A TRAVES DE ESTE UNICO METODO
            //InsertarEmpleados();


            ////INSERTANDO EL 1ER CARGO
            //string cargo1 = "Director/a";
            //InsertarCargos(nomCargo: cargo1);

            ////INSERTANDO EL 2DO CARGO
            //string cargo2 = "Administrativo/a";
            //InsertarCargos(nomCargo: cargo2);

            ////INSERTANDO EL 3er CARGO
            //string cargo3 = "Supervisor/a";
            //InsertarCargos(nomCargo: cargo3);


            ////INSERTANDO UN LISTADO INICIAL DE CARGOS_EMPLEADOS A TRAVES DE ESTE UNICO METODO
            //InsertarCargoEmpleado();


            ////ACTUALIZANDO EL NOMBRE DE LA EMPLEADA IRINA
            //ActualizaEmpleado("Irina", "Irina Maria");

            ////ACTUALIZANDO EL NOMBRE DEL EMPLEADO STEFANO
            //ActualizaEmpleado("Stefano", "Jose Stefano");

            ////ELIMINANDO REGISTROS DE LA TABLA EMPLEADOS
            //EliminaEmpleado(nomEmpl: "Carlos");
        }

        public void InsertarEmpresa(string nomEmpresa)
        {
            Empresa nuevaEmpresa = new Empresa();

            nuevaEmpresa.Nombre = nomEmpresa;

            miDataContext.Empresas.InsertOnSubmit(entity: nuevaEmpresa);

            miDataContext.SubmitChanges();

            Principal.ItemsSource = miDataContext.Empresas;
        }

        public void InsertarEmpleados()
        {
            Empresa emprPildorasInformaticas = miDataContext.Empresas.First(emp => emp.Nombre.Equals("Píldoras Informáticas"));
            
            Empresa empGoogle = miDataContext.Empresas.First(emp => emp.Nombre.Equals("Google"));

            List<Empleado> listaEmpleados = new List<Empleado>();

            listaEmpleados.Add(new Empleado { Nombre = "Sergey", Apellido = "Brin", EmpresaId = emprPildorasInformaticas.Id});
            listaEmpleados.Add(new Empleado { Nombre = "Juan", Apellido = "Diaz", EmpresaId = emprPildorasInformaticas.Id});
            listaEmpleados.Add(new Empleado { Nombre = "Luis", Apellido = "Stiven", EmpresaId = emprPildorasInformaticas.Id});
            listaEmpleados.Add(new Empleado { Nombre = "Brendam", Apellido = "Jackman", EmpresaId = emprPildorasInformaticas.Id});
            listaEmpleados.Add(new Empleado { Nombre = "Carl", Apellido = "White", EmpresaId = emprPildorasInformaticas.Id});
            listaEmpleados.Add(new Empleado { Nombre = "Carlos", Apellido = "Blanco", EmpresaId = emprPildorasInformaticas.Id});

            listaEmpleados.Add(new Empleado { Nombre = "Larry", Apellido = "Page", EmpresaId = empGoogle.Id});
            listaEmpleados.Add(new Empleado { Nombre = "Irina", Apellido = "Shayk", EmpresaId = empGoogle.Id});
            listaEmpleados.Add(new Empleado { Nombre = "Andrew", Apellido = "Jota", EmpresaId = empGoogle.Id});
            listaEmpleados.Add(new Empleado { Nombre = "Claudio", Apellido = "Lopez", EmpresaId = empGoogle.Id});
            listaEmpleados.Add(new Empleado { Nombre = "Felipe", Apellido = "Anderson", EmpresaId = empGoogle.Id});
            listaEmpleados.Add(new Empleado { Nombre = "Julia", Apellido = "Suárez", EmpresaId = empGoogle.Id});
            listaEmpleados.Add(new Empleado { Nombre = "Stefano", Apellido = "Perrón", EmpresaId = empGoogle.Id});

            miDataContext.Empleados.InsertAllOnSubmit(entities: listaEmpleados);

            miDataContext.SubmitChanges();

            Principal.ItemsSource = miDataContext.Empleados;
        }

        public void InsertarCargos(string nomCargo)
        {
            miDataContext.Cargos.InsertOnSubmit(entity: new Cargo { NombreCargo = nomCargo});

            miDataContext.SubmitChanges();

            Principal.ItemsSource = miDataContext.Cargos;
        }

        public void InsertarCargoEmpleado() 
        {
            Empleado empl1 = miDataContext.Empleados.First(empl => empl.Nombre.Equals("Juan"));
            Empleado empl2 = miDataContext.Empleados.First(empl => empl.Nombre.Equals("Sergey"));
            Empleado empl3 = miDataContext.Empleados.First(empl => empl.Nombre.Equals("Larry"));
            Empleado empl4 = miDataContext.Empleados.First(empl => empl.Nombre.Equals("Irina"));
            Empleado empl5 = miDataContext.Empleados.First(empl => empl.Nombre.Equals("Felipe"));
            Empleado empl6 = miDataContext.Empleados.First(empl => empl.Nombre.Equals("Andrew"));
            Empleado empl7 = miDataContext.Empleados.First(empl => empl.Nombre.Equals("Claudio"));
            Empleado empl8 = miDataContext.Empleados.First(empl => empl.Nombre.Equals("Luis"));
            Empleado empl9 = miDataContext.Empleados.First(empl => empl.Nombre.Equals("Brendam"));
            Empleado empl10 = miDataContext.Empleados.First(empl => empl.Nombre.Equals("Julia"));
            Empleado empl11 = miDataContext.Empleados.First(empl => empl.Nombre.Equals("Stefano"));

            Cargo cargoDirector = miDataContext.Cargos.First(cargo => cargo.NombreCargo.Equals("Director/a"));
            Cargo cargoAdministrativo = miDataContext.Cargos.First(cargo => cargo.NombreCargo.Equals("Administrativo/a"));
            Cargo cargoSupervisor = miDataContext.Cargos.First(cargo => cargo.NombreCargo.Equals("Supervisor/a"));

            List<CargoEmpleado> listaCargosEmpleados = new List<CargoEmpleado>();

            //PRIMERA FORMA DE LLENAR LA LISTA: USANDO LOS IDS DE LOS ELEMENTOS QUE COMPONEN LA TABLA
            //listaCargosEmpleados.Add(new CargoEmpleado { EmpleadoId = empl1.Id, CargoId = cargoDirector.Id });
            //listaCargosEmpleados.Add(new CargoEmpleado { EmpleadoId = empl2.Id, CargoId = cargoDirector.Id });
            //listaCargosEmpleados.Add(new CargoEmpleado { EmpleadoId = empl3.Id, CargoId = cargoAdministrativo.Id });
            //listaCargosEmpleados.Add(new CargoEmpleado { EmpleadoId = empl4.Id, CargoId = cargoAdministrativo.Id });
            //listaCargosEmpleados.Add(new CargoEmpleado { EmpleadoId = empl5.Id, CargoId = cargoAdministrativo.Id });
            //listaCargosEmpleados.Add(new CargoEmpleado { EmpleadoId = empl6.Id, CargoId = cargoAdministrativo.Id });
            //listaCargosEmpleados.Add(new CargoEmpleado { EmpleadoId = empl7.Id, CargoId = cargoSupervisor.Id});
            //listaCargosEmpleados.Add(new CargoEmpleado { EmpleadoId = empl8.Id, CargoId = cargoSupervisor.Id});
            //listaCargosEmpleados.Add(new CargoEmpleado { EmpleadoId = empl9.Id, CargoId = cargoSupervisor.Id});
            //listaCargosEmpleados.Add(new CargoEmpleado { EmpleadoId = empl10.Id, CargoId = cargoSupervisor.Id });
            //listaCargosEmpleados.Add(new CargoEmpleado { EmpleadoId = empl11.Id, CargoId = cargoSupervisor.Id });

            //SEGUNDA FORMA DE LLENAR LA LISTA: USANDO LOS OBJETOS EN VEZ DE LOS IDS. TODO ESTO GRACIAS AL MAPEO RELACIONAL QUE HACE EL ORM
            listaCargosEmpleados.Add(new CargoEmpleado { Empleado = empl1, Cargo = cargoDirector });
            listaCargosEmpleados.Add(new CargoEmpleado { Empleado = empl2, Cargo = cargoDirector });
            listaCargosEmpleados.Add(new CargoEmpleado { Empleado = empl3, Cargo = cargoAdministrativo });
            listaCargosEmpleados.Add(new CargoEmpleado { Empleado = empl4, Cargo = cargoAdministrativo });
            listaCargosEmpleados.Add(new CargoEmpleado { Empleado = empl5, Cargo = cargoAdministrativo });
            listaCargosEmpleados.Add(new CargoEmpleado { Empleado = empl6, Cargo = cargoAdministrativo });
            listaCargosEmpleados.Add(new CargoEmpleado { Empleado = empl7, Cargo = cargoSupervisor });
            listaCargosEmpleados.Add(new CargoEmpleado { Empleado = empl8, Cargo = cargoSupervisor });
            listaCargosEmpleados.Add(new CargoEmpleado { Empleado = empl9, Cargo = cargoSupervisor });
            listaCargosEmpleados.Add(new CargoEmpleado { Empleado = empl11, Cargo  = cargoSupervisor });
            listaCargosEmpleados.Add(new CargoEmpleado { Empleado = empl10, Cargo  = cargoSupervisor });

            miDataContext.CargoEmpleados.InsertAllOnSubmit(entities: listaCargosEmpleados);

            miDataContext.SubmitChanges();

            Principal.ItemsSource = miDataContext.CargoEmpleados;
        }

        public void ActualizaEmpleado(string nomEmpl, string newNomEmple)
        {
            Empleado empleado = miDataContext.Empleados.First(empl => empl.Nombre.Equals(nomEmpl));

            empleado.Nombre = newNomEmple;

            miDataContext.SubmitChanges();

            Principal.ItemsSource = miDataContext.Empleados;
        }

        public void EliminaEmpleado(string nomEmpl)
        {
            Empleado empleado = miDataContext.Empleados.First(empl => empl.Nombre.Equals(nomEmpl));

            miDataContext.Empleados.DeleteOnSubmit(entity: empleado);

            miDataContext.SubmitChanges();

            Principal.ItemsSource = miDataContext.Empleados;
        }
    }
}
