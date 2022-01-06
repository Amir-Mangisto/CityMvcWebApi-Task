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

namespace CityMvcWebApi.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CityDB")]
	public partial class CityContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCitizen(Citizen instance);
    partial void UpdateCitizen(Citizen instance);
    partial void DeleteCitizen(Citizen instance);
    #endregion
		
		public CityContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CityDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CityContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CityContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CityContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CityContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Citizen> Citizens
		{
			get
			{
				return this.GetTable<Citizen>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Citizens")]
	public partial class Citizen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FirstName;
		
		private string _LastName;
		
		private System.Nullable<System.DateTime> _Birth;
		
		private string _Adress;
		
		private System.Nullable<int> _YearsInCity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnBirthChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthChanged();
    partial void OnAdressChanging(string value);
    partial void OnAdressChanged();
    partial void OnYearsInCityChanging(System.Nullable<int> value);
    partial void OnYearsInCityChanged();
    #endregion
		
		public Citizen()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(10)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birth", DbType="Date")]
		public System.Nullable<System.DateTime> Birth
		{
			get
			{
				return this._Birth;
			}
			set
			{
				if ((this._Birth != value))
				{
					this.OnBirthChanging(value);
					this.SendPropertyChanging();
					this._Birth = value;
					this.SendPropertyChanged("Birth");
					this.OnBirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adress", DbType="VarChar(50)")]
		public string Adress
		{
			get
			{
				return this._Adress;
			}
			set
			{
				if ((this._Adress != value))
				{
					this.OnAdressChanging(value);
					this.SendPropertyChanging();
					this._Adress = value;
					this.SendPropertyChanged("Adress");
					this.OnAdressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearsInCity", DbType="Int")]
		public System.Nullable<int> YearsInCity
		{
			get
			{
				return this._YearsInCity;
			}
			set
			{
				if ((this._YearsInCity != value))
				{
					this.OnYearsInCityChanging(value);
					this.SendPropertyChanging();
					this._YearsInCity = value;
					this.SendPropertyChanged("YearsInCity");
					this.OnYearsInCityChanged();
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