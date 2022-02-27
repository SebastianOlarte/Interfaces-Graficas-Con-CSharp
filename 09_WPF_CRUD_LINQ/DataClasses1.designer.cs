﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _09_WPF_CRUD_LINQ
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PildorasInformaticas")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmpresa(Empresa instance);
    partial void UpdateEmpresa(Empresa instance);
    partial void DeleteEmpresa(Empresa instance);
    partial void InsertEmpleado(Empleado instance);
    partial void UpdateEmpleado(Empleado instance);
    partial void DeleteEmpleado(Empleado instance);
    partial void InsertCargo(Cargo instance);
    partial void UpdateCargo(Cargo instance);
    partial void DeleteCargo(Cargo instance);
    partial void InsertCargoEmpleado(CargoEmpleado instance);
    partial void UpdateCargoEmpleado(CargoEmpleado instance);
    partial void DeleteCargoEmpleado(CargoEmpleado instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::_09_WPF_CRUD_LINQ.Properties.Settings.Default.Crud_Linq_Sql, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Empresa> Empresas
		{
			get
			{
				return this.GetTable<Empresa>();
			}
		}
		
		public System.Data.Linq.Table<Empleado> Empleados
		{
			get
			{
				return this.GetTable<Empleado>();
			}
		}
		
		public System.Data.Linq.Table<Cargo> Cargos
		{
			get
			{
				return this.GetTable<Cargo>();
			}
		}
		
		public System.Data.Linq.Table<CargoEmpleado> CargoEmpleados
		{
			get
			{
				return this.GetTable<CargoEmpleado>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Empresa")]
	public partial class Empresa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private EntitySet<Empleado> _Empleados;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    #endregion
		
		public Empresa()
		{
			this._Empleados = new EntitySet<Empleado>(new Action<Empleado>(this.attach_Empleados), new Action<Empleado>(this.detach_Empleados));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Empresa_Empleado", Storage="_Empleados", ThisKey="Id", OtherKey="EmpresaId")]
		public EntitySet<Empleado> Empleados
		{
			get
			{
				return this._Empleados;
			}
			set
			{
				this._Empleados.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Empleados(Empleado entity)
		{
			this.SendPropertyChanging();
			entity.Empresa = this;
		}
		
		private void detach_Empleados(Empleado entity)
		{
			this.SendPropertyChanging();
			entity.Empresa = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Empleado")]
	public partial class Empleado : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private int _EmpresaId;
		
		private EntitySet<CargoEmpleado> _CargoEmpleados;
		
		private EntityRef<Empresa> _Empresa;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnEmpresaIdChanging(int value);
    partial void OnEmpresaIdChanged();
    #endregion
		
		public Empleado()
		{
			this._CargoEmpleados = new EntitySet<CargoEmpleado>(new Action<CargoEmpleado>(this.attach_CargoEmpleados), new Action<CargoEmpleado>(this.detach_CargoEmpleados));
			this._Empresa = default(EntityRef<Empresa>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this.OnApellidoChanging(value);
					this.SendPropertyChanging();
					this._Apellido = value;
					this.SendPropertyChanged("Apellido");
					this.OnApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpresaId", DbType="Int NOT NULL")]
		public int EmpresaId
		{
			get
			{
				return this._EmpresaId;
			}
			set
			{
				if ((this._EmpresaId != value))
				{
					if (this._Empresa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmpresaIdChanging(value);
					this.SendPropertyChanging();
					this._EmpresaId = value;
					this.SendPropertyChanged("EmpresaId");
					this.OnEmpresaIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Empleado_CargoEmpleado", Storage="_CargoEmpleados", ThisKey="Id", OtherKey="EmpleadoId")]
		public EntitySet<CargoEmpleado> CargoEmpleados
		{
			get
			{
				return this._CargoEmpleados;
			}
			set
			{
				this._CargoEmpleados.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Empresa_Empleado", Storage="_Empresa", ThisKey="EmpresaId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Empresa Empresa
		{
			get
			{
				return this._Empresa.Entity;
			}
			set
			{
				Empresa previousValue = this._Empresa.Entity;
				if (((previousValue != value) 
							|| (this._Empresa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Empresa.Entity = null;
						previousValue.Empleados.Remove(this);
					}
					this._Empresa.Entity = value;
					if ((value != null))
					{
						value.Empleados.Add(this);
						this._EmpresaId = value.Id;
					}
					else
					{
						this._EmpresaId = default(int);
					}
					this.SendPropertyChanged("Empresa");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_CargoEmpleados(CargoEmpleado entity)
		{
			this.SendPropertyChanging();
			entity.Empleado = this;
		}
		
		private void detach_CargoEmpleados(CargoEmpleado entity)
		{
			this.SendPropertyChanging();
			entity.Empleado = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cargo")]
	public partial class Cargo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _NombreCargo;
		
		private EntitySet<CargoEmpleado> _CargoEmpleados;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreCargoChanging(string value);
    partial void OnNombreCargoChanged();
    #endregion
		
		public Cargo()
		{
			this._CargoEmpleados = new EntitySet<CargoEmpleado>(new Action<CargoEmpleado>(this.attach_CargoEmpleados), new Action<CargoEmpleado>(this.detach_CargoEmpleados));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreCargo", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NombreCargo
		{
			get
			{
				return this._NombreCargo;
			}
			set
			{
				if ((this._NombreCargo != value))
				{
					this.OnNombreCargoChanging(value);
					this.SendPropertyChanging();
					this._NombreCargo = value;
					this.SendPropertyChanged("NombreCargo");
					this.OnNombreCargoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cargo_CargoEmpleado", Storage="_CargoEmpleados", ThisKey="Id", OtherKey="CargoId")]
		public EntitySet<CargoEmpleado> CargoEmpleados
		{
			get
			{
				return this._CargoEmpleados;
			}
			set
			{
				this._CargoEmpleados.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_CargoEmpleados(CargoEmpleado entity)
		{
			this.SendPropertyChanging();
			entity.Cargo = this;
		}
		
		private void detach_CargoEmpleados(CargoEmpleado entity)
		{
			this.SendPropertyChanging();
			entity.Cargo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CargoEmpleado")]
	public partial class CargoEmpleado : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _EmpleadoId;
		
		private int _CargoId;
		
		private EntityRef<Cargo> _Cargo;
		
		private EntityRef<Empleado> _Empleado;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmpleadoIdChanging(int value);
    partial void OnEmpleadoIdChanged();
    partial void OnCargoIdChanging(int value);
    partial void OnCargoIdChanged();
    #endregion
		
		public CargoEmpleado()
		{
			this._Cargo = default(EntityRef<Cargo>);
			this._Empleado = default(EntityRef<Empleado>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpleadoId", DbType="Int NOT NULL")]
		public int EmpleadoId
		{
			get
			{
				return this._EmpleadoId;
			}
			set
			{
				if ((this._EmpleadoId != value))
				{
					if (this._Empleado.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmpleadoIdChanging(value);
					this.SendPropertyChanging();
					this._EmpleadoId = value;
					this.SendPropertyChanged("EmpleadoId");
					this.OnEmpleadoIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CargoId", DbType="Int NOT NULL")]
		public int CargoId
		{
			get
			{
				return this._CargoId;
			}
			set
			{
				if ((this._CargoId != value))
				{
					if (this._Cargo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCargoIdChanging(value);
					this.SendPropertyChanging();
					this._CargoId = value;
					this.SendPropertyChanged("CargoId");
					this.OnCargoIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cargo_CargoEmpleado", Storage="_Cargo", ThisKey="CargoId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Cargo Cargo
		{
			get
			{
				return this._Cargo.Entity;
			}
			set
			{
				Cargo previousValue = this._Cargo.Entity;
				if (((previousValue != value) 
							|| (this._Cargo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cargo.Entity = null;
						previousValue.CargoEmpleados.Remove(this);
					}
					this._Cargo.Entity = value;
					if ((value != null))
					{
						value.CargoEmpleados.Add(this);
						this._CargoId = value.Id;
					}
					else
					{
						this._CargoId = default(int);
					}
					this.SendPropertyChanged("Cargo");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Empleado_CargoEmpleado", Storage="_Empleado", ThisKey="EmpleadoId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Empleado Empleado
		{
			get
			{
				return this._Empleado.Entity;
			}
			set
			{
				Empleado previousValue = this._Empleado.Entity;
				if (((previousValue != value) 
							|| (this._Empleado.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Empleado.Entity = null;
						previousValue.CargoEmpleados.Remove(this);
					}
					this._Empleado.Entity = value;
					if ((value != null))
					{
						value.CargoEmpleados.Add(this);
						this._EmpleadoId = value.Id;
					}
					else
					{
						this._EmpleadoId = default(int);
					}
					this.SendPropertyChanged("Empleado");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
