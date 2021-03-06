﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.17929
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Negocios2015")>  _
Partial Public Class Negocios2015DataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Definiciones de métodos de extensibilidad"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertempleados(instance As empleados)
    End Sub
  Partial Private Sub Updateempleados(instance As empleados)
    End Sub
  Partial Private Sub Deleteempleados(instance As empleados)
    End Sub
  Partial Private Sub InsertCargos(instance As Cargos)
    End Sub
  Partial Private Sub UpdateCargos(instance As Cargos)
    End Sub
  Partial Private Sub DeleteCargos(instance As Cargos)
    End Sub
  Partial Private Sub InsertDistritos(instance As Distritos)
    End Sub
  Partial Private Sub UpdateDistritos(instance As Distritos)
    End Sub
  Partial Private Sub DeleteDistritos(instance As Distritos)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.APP_MANTENIMIENTO.My.MySettings.Default.Negocios2015ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property empleados() As System.Data.Linq.Table(Of empleados)
		Get
			Return Me.GetTable(Of empleados)
		End Get
	End Property
	
	Public ReadOnly Property Cargos() As System.Data.Linq.Table(Of Cargos)
		Get
			Return Me.GetTable(Of Cargos)
		End Get
	End Property
	
	Public ReadOnly Property Distritos() As System.Data.Linq.Table(Of Distritos)
		Get
			Return Me.GetTable(Of Distritos)
		End Get
	End Property
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.usp_CargoListar")>  _
	Public Function usp_CargoListar() As ISingleResult(Of usp_CargoListarResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,ISingleResult(Of usp_CargoListarResult))
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.usp_DistritoListar")>  _
	Public Function usp_DistritoListar() As ISingleResult(Of usp_DistritoListarResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,ISingleResult(Of usp_DistritoListarResult))
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.usp_EmpleadoListar")>  _
	Public Function usp_EmpleadoListar() As ISingleResult(Of usp_EmpleadoListarResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,ISingleResult(Of usp_EmpleadoListarResult))
	End Function
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="RRHH.empleados")>  _
Partial Public Class empleados
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _IdEmpleado As Integer
	
	Private _ApeEmpleado As String
	
	Private _NomEmpleado As String
	
	Private _FecNac As Date
	
	Private _DirEmpleado As String
	
	Private _idDistrito As System.Nullable(Of Integer)
	
	Private _fonoEmpleado As String
	
	Private _idCargo As System.Nullable(Of Integer)
	
	Private _FecContrata As Date
	
	Private _Activo As System.Nullable(Of Boolean)
	
	Private _Cargos As EntityRef(Of Cargos)
	
	Private _Distritos As EntityRef(Of Distritos)
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdEmpleadoChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdEmpleadoChanged()
    End Sub
    Partial Private Sub OnApeEmpleadoChanging(value As String)
    End Sub
    Partial Private Sub OnApeEmpleadoChanged()
    End Sub
    Partial Private Sub OnNomEmpleadoChanging(value As String)
    End Sub
    Partial Private Sub OnNomEmpleadoChanged()
    End Sub
    Partial Private Sub OnFecNacChanging(value As Date)
    End Sub
    Partial Private Sub OnFecNacChanged()
    End Sub
    Partial Private Sub OnDirEmpleadoChanging(value As String)
    End Sub
    Partial Private Sub OnDirEmpleadoChanged()
    End Sub
    Partial Private Sub OnidDistritoChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnidDistritoChanged()
    End Sub
    Partial Private Sub OnfonoEmpleadoChanging(value As String)
    End Sub
    Partial Private Sub OnfonoEmpleadoChanged()
    End Sub
    Partial Private Sub OnidCargoChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnidCargoChanged()
    End Sub
    Partial Private Sub OnFecContrataChanging(value As Date)
    End Sub
    Partial Private Sub OnFecContrataChanged()
    End Sub
    Partial Private Sub OnActivoChanging(value As System.Nullable(Of Boolean))
    End Sub
    Partial Private Sub OnActivoChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Cargos = CType(Nothing, EntityRef(Of Cargos))
		Me._Distritos = CType(Nothing, EntityRef(Of Distritos))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IdEmpleado", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property IdEmpleado() As Integer
		Get
			Return Me._IdEmpleado
		End Get
		Set
			If ((Me._IdEmpleado = value)  _
						= false) Then
				Me.OnIdEmpleadoChanging(value)
				Me.SendPropertyChanging
				Me._IdEmpleado = value
				Me.SendPropertyChanged("IdEmpleado")
				Me.OnIdEmpleadoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ApeEmpleado", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property ApeEmpleado() As String
		Get
			Return Me._ApeEmpleado
		End Get
		Set
			If (String.Equals(Me._ApeEmpleado, value) = false) Then
				Me.OnApeEmpleadoChanging(value)
				Me.SendPropertyChanging
				Me._ApeEmpleado = value
				Me.SendPropertyChanged("ApeEmpleado")
				Me.OnApeEmpleadoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NomEmpleado", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property NomEmpleado() As String
		Get
			Return Me._NomEmpleado
		End Get
		Set
			If (String.Equals(Me._NomEmpleado, value) = false) Then
				Me.OnNomEmpleadoChanging(value)
				Me.SendPropertyChanging
				Me._NomEmpleado = value
				Me.SendPropertyChanged("NomEmpleado")
				Me.OnNomEmpleadoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FecNac", DbType:="DateTime NOT NULL")>  _
	Public Property FecNac() As Date
		Get
			Return Me._FecNac
		End Get
		Set
			If ((Me._FecNac = value)  _
						= false) Then
				Me.OnFecNacChanging(value)
				Me.SendPropertyChanging
				Me._FecNac = value
				Me.SendPropertyChanged("FecNac")
				Me.OnFecNacChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DirEmpleado", DbType:="VarChar(60) NOT NULL", CanBeNull:=false)>  _
	Public Property DirEmpleado() As String
		Get
			Return Me._DirEmpleado
		End Get
		Set
			If (String.Equals(Me._DirEmpleado, value) = false) Then
				Me.OnDirEmpleadoChanging(value)
				Me.SendPropertyChanging
				Me._DirEmpleado = value
				Me.SendPropertyChanged("DirEmpleado")
				Me.OnDirEmpleadoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_idDistrito", DbType:="Int")>  _
	Public Property idDistrito() As System.Nullable(Of Integer)
		Get
			Return Me._idDistrito
		End Get
		Set
			If (Me._idDistrito.Equals(value) = false) Then
				If Me._Distritos.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnidDistritoChanging(value)
				Me.SendPropertyChanging
				Me._idDistrito = value
				Me.SendPropertyChanged("idDistrito")
				Me.OnidDistritoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_fonoEmpleado", DbType:="VarChar(15)")>  _
	Public Property fonoEmpleado() As String
		Get
			Return Me._fonoEmpleado
		End Get
		Set
			If (String.Equals(Me._fonoEmpleado, value) = false) Then
				Me.OnfonoEmpleadoChanging(value)
				Me.SendPropertyChanging
				Me._fonoEmpleado = value
				Me.SendPropertyChanged("fonoEmpleado")
				Me.OnfonoEmpleadoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_idCargo", DbType:="Int")>  _
	Public Property idCargo() As System.Nullable(Of Integer)
		Get
			Return Me._idCargo
		End Get
		Set
			If (Me._idCargo.Equals(value) = false) Then
				If Me._Cargos.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnidCargoChanging(value)
				Me.SendPropertyChanging
				Me._idCargo = value
				Me.SendPropertyChanged("idCargo")
				Me.OnidCargoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FecContrata", DbType:="DateTime NOT NULL")>  _
	Public Property FecContrata() As Date
		Get
			Return Me._FecContrata
		End Get
		Set
			If ((Me._FecContrata = value)  _
						= false) Then
				Me.OnFecContrataChanging(value)
				Me.SendPropertyChanging
				Me._FecContrata = value
				Me.SendPropertyChanged("FecContrata")
				Me.OnFecContrataChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Activo", DbType:="Bit")>  _
	Public Property Activo() As System.Nullable(Of Boolean)
		Get
			Return Me._Activo
		End Get
		Set
			If (Me._Activo.Equals(value) = false) Then
				Me.OnActivoChanging(value)
				Me.SendPropertyChanging
				Me._Activo = value
				Me.SendPropertyChanged("Activo")
				Me.OnActivoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Cargos_empleados", Storage:="_Cargos", ThisKey:="idCargo", OtherKey:="idcargo", IsForeignKey:=true)>  _
	Public Property Cargos() As Cargos
		Get
			Return Me._Cargos.Entity
		End Get
		Set
			Dim previousValue As Cargos = Me._Cargos.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Cargos.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Cargos.Entity = Nothing
					previousValue.empleados.Remove(Me)
				End If
				Me._Cargos.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.empleados.Add(Me)
					Me._idCargo = value.idcargo
				Else
					Me._idCargo = CType(Nothing, Nullable(Of Integer))
				End If
				Me.SendPropertyChanged("Cargos")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Distritos_empleados", Storage:="_Distritos", ThisKey:="idDistrito", OtherKey:="idDistrito", IsForeignKey:=true)>  _
	Public Property Distritos() As Distritos
		Get
			Return Me._Distritos.Entity
		End Get
		Set
			Dim previousValue As Distritos = Me._Distritos.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Distritos.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Distritos.Entity = Nothing
					previousValue.empleados.Remove(Me)
				End If
				Me._Distritos.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.empleados.Add(Me)
					Me._idDistrito = value.idDistrito
				Else
					Me._idDistrito = CType(Nothing, Nullable(Of Integer))
				End If
				Me.SendPropertyChanged("Distritos")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="RRHH.Cargos")>  _
Partial Public Class Cargos
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _idcargo As Integer
	
	Private _desCargo As String
	
	Private _empleados As EntitySet(Of empleados)
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnidcargoChanging(value As Integer)
    End Sub
    Partial Private Sub OnidcargoChanged()
    End Sub
    Partial Private Sub OndesCargoChanging(value As String)
    End Sub
    Partial Private Sub OndesCargoChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._empleados = New EntitySet(Of empleados)(AddressOf Me.attach_empleados, AddressOf Me.detach_empleados)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_idcargo", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property idcargo() As Integer
		Get
			Return Me._idcargo
		End Get
		Set
			If ((Me._idcargo = value)  _
						= false) Then
				Me.OnidcargoChanging(value)
				Me.SendPropertyChanging
				Me._idcargo = value
				Me.SendPropertyChanged("idcargo")
				Me.OnidcargoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_desCargo", DbType:="VarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property desCargo() As String
		Get
			Return Me._desCargo
		End Get
		Set
			If (String.Equals(Me._desCargo, value) = false) Then
				Me.OndesCargoChanging(value)
				Me.SendPropertyChanging
				Me._desCargo = value
				Me.SendPropertyChanged("desCargo")
				Me.OndesCargoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Cargos_empleados", Storage:="_empleados", ThisKey:="idcargo", OtherKey:="idCargo")>  _
	Public Property empleados() As EntitySet(Of empleados)
		Get
			Return Me._empleados
		End Get
		Set
			Me._empleados.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_empleados(ByVal entity As empleados)
		Me.SendPropertyChanging
		entity.Cargos = Me
	End Sub
	
	Private Sub detach_empleados(ByVal entity As empleados)
		Me.SendPropertyChanging
		entity.Cargos = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="RRHH.Distritos")>  _
Partial Public Class Distritos
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _idDistrito As Integer
	
	Private _nomDistrito As String
	
	Private _empleados As EntitySet(Of empleados)
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnidDistritoChanging(value As Integer)
    End Sub
    Partial Private Sub OnidDistritoChanged()
    End Sub
    Partial Private Sub OnnomDistritoChanging(value As String)
    End Sub
    Partial Private Sub OnnomDistritoChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._empleados = New EntitySet(Of empleados)(AddressOf Me.attach_empleados, AddressOf Me.detach_empleados)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_idDistrito", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property idDistrito() As Integer
		Get
			Return Me._idDistrito
		End Get
		Set
			If ((Me._idDistrito = value)  _
						= false) Then
				Me.OnidDistritoChanging(value)
				Me.SendPropertyChanging
				Me._idDistrito = value
				Me.SendPropertyChanged("idDistrito")
				Me.OnidDistritoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_nomDistrito", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property nomDistrito() As String
		Get
			Return Me._nomDistrito
		End Get
		Set
			If (String.Equals(Me._nomDistrito, value) = false) Then
				Me.OnnomDistritoChanging(value)
				Me.SendPropertyChanging
				Me._nomDistrito = value
				Me.SendPropertyChanged("nomDistrito")
				Me.OnnomDistritoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Distritos_empleados", Storage:="_empleados", ThisKey:="idDistrito", OtherKey:="idDistrito")>  _
	Public Property empleados() As EntitySet(Of empleados)
		Get
			Return Me._empleados
		End Get
		Set
			Me._empleados.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_empleados(ByVal entity As empleados)
		Me.SendPropertyChanging
		entity.Distritos = Me
	End Sub
	
	Private Sub detach_empleados(ByVal entity As empleados)
		Me.SendPropertyChanging
		entity.Distritos = Nothing
	End Sub
End Class

Partial Public Class usp_CargoListarResult
	
	Private _idcargo As Integer
	
	Private _desCargo As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_idcargo", DbType:="Int NOT NULL")>  _
	Public Property idcargo() As Integer
		Get
			Return Me._idcargo
		End Get
		Set
			If ((Me._idcargo = value)  _
						= false) Then
				Me._idcargo = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_desCargo", DbType:="VarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property desCargo() As String
		Get
			Return Me._desCargo
		End Get
		Set
			If (String.Equals(Me._desCargo, value) = false) Then
				Me._desCargo = value
			End If
		End Set
	End Property
End Class

Partial Public Class usp_DistritoListarResult
	
	Private _idDistrito As Integer
	
	Private _nomDistrito As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_idDistrito", DbType:="Int NOT NULL")>  _
	Public Property idDistrito() As Integer
		Get
			Return Me._idDistrito
		End Get
		Set
			If ((Me._idDistrito = value)  _
						= false) Then
				Me._idDistrito = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_nomDistrito", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property nomDistrito() As String
		Get
			Return Me._nomDistrito
		End Get
		Set
			If (String.Equals(Me._nomDistrito, value) = false) Then
				Me._nomDistrito = value
			End If
		End Set
	End Property
End Class

Partial Public Class usp_EmpleadoListarResult
	
	Private _IdEmpleado As Integer
	
	Private _ApeEmpleado As String
	
	Private _NomEmpleado As String
	
	Private _nomDistrito As String
	
	Private _DirEmpleado As String
	
	Private _desCargo As String
	
	Private _fonoEmpleado As String
	
	Private _FecContrata As Date
	
	Private _FecNac As Date
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IdEmpleado", DbType:="Int NOT NULL")>  _
	Public Property IdEmpleado() As Integer
		Get
			Return Me._IdEmpleado
		End Get
		Set
			If ((Me._IdEmpleado = value)  _
						= false) Then
				Me._IdEmpleado = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ApeEmpleado", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property ApeEmpleado() As String
		Get
			Return Me._ApeEmpleado
		End Get
		Set
			If (String.Equals(Me._ApeEmpleado, value) = false) Then
				Me._ApeEmpleado = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NomEmpleado", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property NomEmpleado() As String
		Get
			Return Me._NomEmpleado
		End Get
		Set
			If (String.Equals(Me._NomEmpleado, value) = false) Then
				Me._NomEmpleado = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_nomDistrito", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property nomDistrito() As String
		Get
			Return Me._nomDistrito
		End Get
		Set
			If (String.Equals(Me._nomDistrito, value) = false) Then
				Me._nomDistrito = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DirEmpleado", DbType:="VarChar(60) NOT NULL", CanBeNull:=false)>  _
	Public Property DirEmpleado() As String
		Get
			Return Me._DirEmpleado
		End Get
		Set
			If (String.Equals(Me._DirEmpleado, value) = false) Then
				Me._DirEmpleado = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_desCargo", DbType:="VarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property desCargo() As String
		Get
			Return Me._desCargo
		End Get
		Set
			If (String.Equals(Me._desCargo, value) = false) Then
				Me._desCargo = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_fonoEmpleado", DbType:="VarChar(15)")>  _
	Public Property fonoEmpleado() As String
		Get
			Return Me._fonoEmpleado
		End Get
		Set
			If (String.Equals(Me._fonoEmpleado, value) = false) Then
				Me._fonoEmpleado = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FecContrata", DbType:="DateTime NOT NULL")>  _
	Public Property FecContrata() As Date
		Get
			Return Me._FecContrata
		End Get
		Set
			If ((Me._FecContrata = value)  _
						= false) Then
				Me._FecContrata = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FecNac", DbType:="DateTime NOT NULL")>  _
	Public Property FecNac() As Date
		Get
			Return Me._FecNac
		End Get
		Set
			If ((Me._FecNac = value)  _
						= false) Then
				Me._FecNac = value
			End If
		End Set
	End Property
End Class
