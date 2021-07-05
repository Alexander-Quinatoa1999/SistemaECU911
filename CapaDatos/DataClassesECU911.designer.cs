﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SistemaECU911")]
	public partial class DataClassesECU911DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertTbl_TipoUsuario(Tbl_TipoUsuario instance);
    partial void UpdateTbl_TipoUsuario(Tbl_TipoUsuario instance);
    partial void DeleteTbl_TipoUsuario(Tbl_TipoUsuario instance);
    partial void InsertTbl_Usuario(Tbl_Usuario instance);
    partial void UpdateTbl_Usuario(Tbl_Usuario instance);
    partial void DeleteTbl_Usuario(Tbl_Usuario instance);
    #endregion
		
		public DataClassesECU911DataContext() : 
				base(global::CapaDatos.Properties.Settings.Default.SistemaECU911ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesECU911DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesECU911DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesECU911DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesECU911DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tbl_TipoUsuario> Tbl_TipoUsuario
		{
			get
			{
				return this.GetTable<Tbl_TipoUsuario>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_Usuario> Tbl_Usuario
		{
			get
			{
				return this.GetTable<Tbl_Usuario>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Autentificacion_Usuario")]
		public ISingleResult<Autentificacion_UsuarioResult> Autentificacion_Usuario([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string pass)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, pass);
			return ((ISingleResult<Autentificacion_UsuarioResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Validar_Existencia")]
		public ISingleResult<Validar_ExistenciaResult> Validar_Existencia([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string usuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario);
			return ((ISingleResult<Validar_ExistenciaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Identificar_rol")]
		public ISingleResult<Identificar_rolResult> Identificar_rol([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> tusu)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tusu);
			return ((ISingleResult<Identificar_rolResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_TipoUsuario")]
	public partial class Tbl_TipoUsuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _tusu_id;
		
		private string _tusu_nombre;
		
		private System.Nullable<char> _tusu_estado;
		
		private EntitySet<Tbl_Usuario> _Tbl_Usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ontusu_idChanging(int value);
    partial void Ontusu_idChanged();
    partial void Ontusu_nombreChanging(string value);
    partial void Ontusu_nombreChanged();
    partial void Ontusu_estadoChanging(System.Nullable<char> value);
    partial void Ontusu_estadoChanged();
    #endregion
		
		public Tbl_TipoUsuario()
		{
			this._Tbl_Usuario = new EntitySet<Tbl_Usuario>(new Action<Tbl_Usuario>(this.attach_Tbl_Usuario), new Action<Tbl_Usuario>(this.detach_Tbl_Usuario));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int tusu_id
		{
			get
			{
				return this._tusu_id;
			}
			set
			{
				if ((this._tusu_id != value))
				{
					this.Ontusu_idChanging(value);
					this.SendPropertyChanging();
					this._tusu_id = value;
					this.SendPropertyChanged("tusu_id");
					this.Ontusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_nombre", DbType="VarChar(100)")]
		public string tusu_nombre
		{
			get
			{
				return this._tusu_nombre;
			}
			set
			{
				if ((this._tusu_nombre != value))
				{
					this.Ontusu_nombreChanging(value);
					this.SendPropertyChanging();
					this._tusu_nombre = value;
					this.SendPropertyChanged("tusu_nombre");
					this.Ontusu_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_estado", DbType="Char(1)")]
		public System.Nullable<char> tusu_estado
		{
			get
			{
				return this._tusu_estado;
			}
			set
			{
				if ((this._tusu_estado != value))
				{
					this.Ontusu_estadoChanging(value);
					this.SendPropertyChanging();
					this._tusu_estado = value;
					this.SendPropertyChanged("tusu_estado");
					this.Ontusu_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_TipoUsuario_Tbl_Usuario", Storage="_Tbl_Usuario", ThisKey="tusu_id", OtherKey="tusu_id")]
		public EntitySet<Tbl_Usuario> Tbl_Usuario
		{
			get
			{
				return this._Tbl_Usuario;
			}
			set
			{
				this._Tbl_Usuario.Assign(value);
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
		
		private void attach_Tbl_Usuario(Tbl_Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_TipoUsuario = this;
		}
		
		private void detach_Tbl_Usuario(Tbl_Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_TipoUsuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Usuario")]
	public partial class Tbl_Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _usu_id;
		
		private string _usu_nombre;
		
		private string _usu_apellido;
		
		private string _usu_direccion;
		
		private string _usu_telefono;
		
		private string _usu_nomlogin;
		
		private string _usu_pass;
		
		private string _usu_correo;
		
		private System.Nullable<System.DateTime> _usu_fechacreacion;
		
		private System.Nullable<char> _usu_estado;
		
		private System.Nullable<int> _tusu_id;
		
		private EntityRef<Tbl_TipoUsuario> _Tbl_TipoUsuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onusu_idChanging(int value);
    partial void Onusu_idChanged();
    partial void Onusu_nombreChanging(string value);
    partial void Onusu_nombreChanged();
    partial void Onusu_apellidoChanging(string value);
    partial void Onusu_apellidoChanged();
    partial void Onusu_direccionChanging(string value);
    partial void Onusu_direccionChanged();
    partial void Onusu_telefonoChanging(string value);
    partial void Onusu_telefonoChanged();
    partial void Onusu_nomloginChanging(string value);
    partial void Onusu_nomloginChanged();
    partial void Onusu_passChanging(string value);
    partial void Onusu_passChanged();
    partial void Onusu_correoChanging(string value);
    partial void Onusu_correoChanged();
    partial void Onusu_fechacreacionChanging(System.Nullable<System.DateTime> value);
    partial void Onusu_fechacreacionChanged();
    partial void Onusu_estadoChanging(System.Nullable<char> value);
    partial void Onusu_estadoChanged();
    partial void Ontusu_idChanging(System.Nullable<int> value);
    partial void Ontusu_idChanged();
    #endregion
		
		public Tbl_Usuario()
		{
			this._Tbl_TipoUsuario = default(EntityRef<Tbl_TipoUsuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int usu_id
		{
			get
			{
				return this._usu_id;
			}
			set
			{
				if ((this._usu_id != value))
				{
					this.Onusu_idChanging(value);
					this.SendPropertyChanging();
					this._usu_id = value;
					this.SendPropertyChanged("usu_id");
					this.Onusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_nombre", DbType="VarChar(150)")]
		public string usu_nombre
		{
			get
			{
				return this._usu_nombre;
			}
			set
			{
				if ((this._usu_nombre != value))
				{
					this.Onusu_nombreChanging(value);
					this.SendPropertyChanging();
					this._usu_nombre = value;
					this.SendPropertyChanged("usu_nombre");
					this.Onusu_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_apellido", DbType="VarChar(150)")]
		public string usu_apellido
		{
			get
			{
				return this._usu_apellido;
			}
			set
			{
				if ((this._usu_apellido != value))
				{
					this.Onusu_apellidoChanging(value);
					this.SendPropertyChanging();
					this._usu_apellido = value;
					this.SendPropertyChanged("usu_apellido");
					this.Onusu_apellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_direccion", DbType="VarChar(250)")]
		public string usu_direccion
		{
			get
			{
				return this._usu_direccion;
			}
			set
			{
				if ((this._usu_direccion != value))
				{
					this.Onusu_direccionChanging(value);
					this.SendPropertyChanging();
					this._usu_direccion = value;
					this.SendPropertyChanged("usu_direccion");
					this.Onusu_direccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_telefono", DbType="VarChar(15)")]
		public string usu_telefono
		{
			get
			{
				return this._usu_telefono;
			}
			set
			{
				if ((this._usu_telefono != value))
				{
					this.Onusu_telefonoChanging(value);
					this.SendPropertyChanging();
					this._usu_telefono = value;
					this.SendPropertyChanged("usu_telefono");
					this.Onusu_telefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_nomlogin", DbType="VarChar(100)")]
		public string usu_nomlogin
		{
			get
			{
				return this._usu_nomlogin;
			}
			set
			{
				if ((this._usu_nomlogin != value))
				{
					this.Onusu_nomloginChanging(value);
					this.SendPropertyChanging();
					this._usu_nomlogin = value;
					this.SendPropertyChanged("usu_nomlogin");
					this.Onusu_nomloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_pass", DbType="VarChar(100)")]
		public string usu_pass
		{
			get
			{
				return this._usu_pass;
			}
			set
			{
				if ((this._usu_pass != value))
				{
					this.Onusu_passChanging(value);
					this.SendPropertyChanging();
					this._usu_pass = value;
					this.SendPropertyChanged("usu_pass");
					this.Onusu_passChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_correo", DbType="VarChar(250)")]
		public string usu_correo
		{
			get
			{
				return this._usu_correo;
			}
			set
			{
				if ((this._usu_correo != value))
				{
					this.Onusu_correoChanging(value);
					this.SendPropertyChanging();
					this._usu_correo = value;
					this.SendPropertyChanged("usu_correo");
					this.Onusu_correoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_fechacreacion", DbType="DateTime")]
		public System.Nullable<System.DateTime> usu_fechacreacion
		{
			get
			{
				return this._usu_fechacreacion;
			}
			set
			{
				if ((this._usu_fechacreacion != value))
				{
					this.Onusu_fechacreacionChanging(value);
					this.SendPropertyChanging();
					this._usu_fechacreacion = value;
					this.SendPropertyChanged("usu_fechacreacion");
					this.Onusu_fechacreacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_estado", DbType="Char(1)")]
		public System.Nullable<char> usu_estado
		{
			get
			{
				return this._usu_estado;
			}
			set
			{
				if ((this._usu_estado != value))
				{
					this.Onusu_estadoChanging(value);
					this.SendPropertyChanging();
					this._usu_estado = value;
					this.SendPropertyChanged("usu_estado");
					this.Onusu_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_id", DbType="Int")]
		public System.Nullable<int> tusu_id
		{
			get
			{
				return this._tusu_id;
			}
			set
			{
				if ((this._tusu_id != value))
				{
					if (this._Tbl_TipoUsuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ontusu_idChanging(value);
					this.SendPropertyChanging();
					this._tusu_id = value;
					this.SendPropertyChanged("tusu_id");
					this.Ontusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_TipoUsuario_Tbl_Usuario", Storage="_Tbl_TipoUsuario", ThisKey="tusu_id", OtherKey="tusu_id", IsForeignKey=true, DeleteRule="CASCADE")]
		public Tbl_TipoUsuario Tbl_TipoUsuario
		{
			get
			{
				return this._Tbl_TipoUsuario.Entity;
			}
			set
			{
				Tbl_TipoUsuario previousValue = this._Tbl_TipoUsuario.Entity;
				if (((previousValue != value) 
							|| (this._Tbl_TipoUsuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tbl_TipoUsuario.Entity = null;
						previousValue.Tbl_Usuario.Remove(this);
					}
					this._Tbl_TipoUsuario.Entity = value;
					if ((value != null))
					{
						value.Tbl_Usuario.Add(this);
						this._tusu_id = value.tusu_id;
					}
					else
					{
						this._tusu_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Tbl_TipoUsuario");
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
	
	public partial class Autentificacion_UsuarioResult
	{
		
		private string _usu_nombre;
		
		private System.Nullable<int> _tusu_id;
		
		public Autentificacion_UsuarioResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_nombre", DbType="VarChar(150)")]
		public string usu_nombre
		{
			get
			{
				return this._usu_nombre;
			}
			set
			{
				if ((this._usu_nombre != value))
				{
					this._usu_nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_id", DbType="Int")]
		public System.Nullable<int> tusu_id
		{
			get
			{
				return this._tusu_id;
			}
			set
			{
				if ((this._tusu_id != value))
				{
					this._tusu_id = value;
				}
			}
		}
	}
	
	public partial class Validar_ExistenciaResult
	{
		
		private string _usu_nombre;
		
		private System.Nullable<int> _tusu_id;
		
		public Validar_ExistenciaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_nombre", DbType="VarChar(150)")]
		public string usu_nombre
		{
			get
			{
				return this._usu_nombre;
			}
			set
			{
				if ((this._usu_nombre != value))
				{
					this._usu_nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_id", DbType="Int")]
		public System.Nullable<int> tusu_id
		{
			get
			{
				return this._tusu_id;
			}
			set
			{
				if ((this._tusu_id != value))
				{
					this._tusu_id = value;
				}
			}
		}
	}
	
	public partial class Identificar_rolResult
	{
		
		private string _usu_nombre;
		
		public Identificar_rolResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_nombre", DbType="VarChar(150)")]
		public string usu_nombre
		{
			get
			{
				return this._usu_nombre;
			}
			set
			{
				if ((this._usu_nombre != value))
				{
					this._usu_nombre = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
