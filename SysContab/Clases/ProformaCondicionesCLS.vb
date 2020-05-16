Imports System.Drawing
Imports DbConnect
Imports DevExpress.XtraEditors
'Imports DbConnect
Public Class ProformaCondicionesCLS
    'Inherits ClConexion
    Implements IDisposable

#Region " Private variables "
    Private _IdCondicion As Integer
    Private _Nombre As String
    Dim Conn As New DbConnect.Connect(Conexion())
#End Region


#Region " Properties "
    Public Property IdCondicion() As Integer
        Get
            Return _IdCondicion
        End Get
        Set(ByVal Value As Integer)
            _IdCondicion = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal Value As String)
            _Nombre = Value
        End Set
    End Property

#End Region

    Sub New()
        MyBase.New()
        _IdCondicion = 0
        _Nombre = String.Empty
    End Sub

    Public Function List() As DataTable
        _IdCondicion = 0
        Conn = New Connect(Conexion())
        Conn.AddParameter("IdCondicion", SqlDbType.Int, 4, ParameterDirection.Input, IdCondicion)
        Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
        Return (Conn.EjecutarComando("JAR_ProformaCondicionesList"))
    End Function

    Public Sub Load(ByVal vCodConsecutEstadoProforma As Integer)
        _IdCondicion = vCodConsecutEstadoProforma
        If IdCondicion = 0 Then Exit Sub
        Conn = New Connect(Conexion)
        Conn.AddParameter("IdCondicion", SqlDbType.Int, 4, ParameterDirection.Input, IdCondicion)
        Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
        Dim Tabla As DataTable = Conn.EjecutarComando("JAR_ProformaCondicionesList")
        If Tabla.Rows.Count = 0 Then Exit Sub

        _IdCondicion = Tabla.Rows(0).Item("IdCondicion")
        _Nombre = Tabla.Rows(0).Item("Nombre")    
    End Sub

    Public Sub FillCombo(ByRef Combo As DevExpress.XtraEditors.LookUpEdit)
        Combo.Properties.DataSource = List()
        Combo.Properties.DisplayMember = "Nombre"
        Combo.Properties.ValueMember = "IdCondicion"
        Combo.Properties.NullText = "[Seleccione Condición]"

        Combo.Properties.ShowFooter = False
        Combo.Properties.ShowHeader = False
        Combo.Properties.ForceInitialize()
        Combo.Properties.PopulateColumns()

        Combo.Properties.Columns("IdCondicion").Visible = False
        Combo.Properties.SearchMode = Controls.SearchMode.AutoFilter
        Combo.ItemIndex = 0


        'For i As Integer = 0 To Combo.Properties.Columns.Count - 1
        '    If Combo.Properties.Columns(i).FieldName <> Combo.Properties.DisplayMember Then Combo.Properties.Columns(i).Visible = False
        'Next
    End Sub

    Public Sub FillCombo(ByRef Combo As DevExpress.XtraEditors.SearchLookUpEdit)
        Combo.Properties.DataSource = List()
        Combo.Properties.DisplayMember = "Nombre"
        Combo.Properties.ValueMember = "IdCondicion"
        Combo.Properties.NullText = "[Seleccione Condición]"
        Combo.Properties.ShowFooter = False
        Combo.Properties.PopulateViewColumns()
        For i As Integer = 0 To Combo.Properties.View.Columns.Count - 1
            If Combo.Properties.View.Columns.Item(i).FieldName <> Combo.Properties.DisplayMember Then Combo.Properties.View.Columns.Item(i).Visible = False
        Next
    End Sub

    Public Function Save() As Boolean
        Dim Conn As New DbConnect.Connect(Conexion)
        Conn.AddParameter("IdCondicion", SqlDbType.Int, 4, ParameterDirection.Input, IdCondicion)
        Conn.AddParameter("Nombre", SqlDbType.NVarChar, 512, ParameterDirection.Input, Nombre)
        Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)        
        ' Conn.AddParameter("IdEtiqueta", SqlDbType.Int, 4, ParameterDirection.Input, IdEtiqueta)
        Conn.IniciarTransaccion()
        Try
            Conn.EjecutarComando("JAR_Proc_ProformaCondiciones")
            ' If CodConsecutEstadoProforma = 0 Then '_CodConsecutEstadoProforma = Conn.GetParameter("CodConsecutEstadoProforma").Valor
            Conn.CompletarTransaccion()
            Return True
        Catch ex As Exception
            Conn.AnularTransaccion()
            XtraMessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function Borrar(IdCotizacion As Integer) As Boolean
        Dim Conn As New DbConnect.Connect(Conexion)
        Conn.AddParameter("IdCondicion", SqlDbType.Int, 4, ParameterDirection.Input, IdCotizacion)

        Conn.IniciarTransaccion()
        Try
            Conn.EjecutarComando("sp_del_CotizacionCondiciones")
            Conn.CompletarTransaccion()

            Return True
        Catch ex As Exception
            Conn.AnularTransaccion()
            XtraMessageBox.Show(ex.Message)
            Return False
        End Try

    End Function

#Region " IDisposable Support "
    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                MyBase.Finalize()
            End If
        End If
        Me.disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class