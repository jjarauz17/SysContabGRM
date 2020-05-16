Imports System.Drawing
Imports DBConnect
Imports DevExpress.XtraEditors
'Imports DbConnect
Public Class ProformaEstadoCLS
    'Inherits ClConexion
    Implements IDisposable

#Region " Private variables "
    Private _CodConsecutEstadoProforma As Integer
    Private _Nombre As String
    Private _Facturada As Boolean
    Private _Caducada As Boolean
    ' Private _IdEtiqueta As Integer
    Dim Conn As New DbConnect.Connect(Conexion())
#End Region


#Region " Properties "
    Public Property CodConsecutEstadoProforma() As Integer
        Get
            Return _CodConsecutEstadoProforma
        End Get
        Set(ByVal Value As Integer)
            _CodConsecutEstadoProforma = Value
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

    Public Property Facturada() As Boolean
        Get
            Return _Facturada
        End Get
        Set(ByVal Value As Boolean)
            _Facturada = Value
        End Set
    End Property

    Public Property Caducada() As Boolean
        Get
            Return _Caducada
        End Get
        Set(ByVal Value As Boolean)
            _Caducada = Value
        End Set
    End Property

    'Public Property IdEtiqueta() As Integer
    '    Get
    '        Return _IdEtiqueta
    '    End Get
    '    Set(ByVal Value As Integer)
    '        _IdEtiqueta = Value
    '    End Set
    'End Property

#End Region

    Sub New()
        MyBase.New()
        _CodConsecutEstadoProforma = 0
        _Nombre = String.Empty
        '  _IdEtiqueta = 0
    End Sub

    Public Function List(Optional Todo As Integer = 0) As DataTable
        _CodConsecutEstadoProforma = Todo
        Conn = New Connect(Conexion())
        Conn.AddParameter("CodConsecutEstadoProforma", SqlDbType.Int, 4, ParameterDirection.Input, CodConsecutEstadoProforma)
        Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
        Return (Conn.EjecutarComando("JAR_ProformaEstadoList"))
    End Function

    Public Sub Load(ByVal vCodConsecutEstadoProforma As Integer)
        _CodConsecutEstadoProforma = vCodConsecutEstadoProforma
        If CodConsecutEstadoProforma = 0 Then Exit Sub
        Conn = New Connect(Conexion)
        Conn.AddParameter("CodConsecutEstadoProforma", SqlDbType.Int, 4, ParameterDirection.Input, CodConsecutEstadoProforma)
        Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
        Dim Tabla As DataTable = Conn.EjecutarComando("JAR_ProformaEstadoList")
        If Tabla.Rows.Count = 0 Then Exit Sub

        _CodConsecutEstadoProforma = Tabla.Rows(0).Item("IdCotizacion")
        _Nombre = Tabla.Rows(0).Item("Nombre")
        _Facturada = Tabla.Rows(0).Item("Facturada")
        _Caducada = Tabla.Rows(0).Item("Caducada")
    End Sub

    Public Sub FillCombo(ByRef Combo As DevExpress.XtraEditors.LookUpEdit, _
                         Optional Todo As Integer = 0)
        Combo.Properties.DataSource = List(Todo)
        Combo.Properties.DisplayMember = "Nombre"
        Combo.Properties.ValueMember = "IdCotizacion"
        Combo.Properties.NullText = "[Seleccione Estado]"

        Combo.Properties.ShowFooter = False
        Combo.Properties.ShowHeader = False
        Combo.Properties.ForceInitialize()
        Combo.Properties.PopulateColumns()

        Combo.Properties.SearchMode = Controls.SearchMode.AutoFilter

        Combo.Properties.Columns("IdCotizacion").Visible = False
        Combo.Properties.Columns("Facturada").Visible = False
        Combo.Properties.Columns("Caducada").Visible = False
        Combo.ItemIndex = 0


        'For i As Integer = 0 To Combo.Properties.Columns.Count - 1
        '    If Combo.Properties.Columns(i).FieldName <> Combo.Properties.DisplayMember Then Combo.Properties.Columns(i).Visible = False
        'Next
    End Sub

    Public Sub FillCombo(ByRef Combo As DevExpress.XtraEditors.CheckedComboBoxEdit, _
                        Optional Todo As Integer = 0)

        Combo.Properties.DataSource = List(Todo)
        Combo.Properties.DisplayMember = "Nombre"
        Combo.Properties.ValueMember = "IdCotizacion"
        Combo.Properties.NullText = "[Seleccione Estado]"
        Combo.SetEditValue("1, 3, 6")
    End Sub


    Public Sub FillCombo(ByRef Combo As DevExpress.XtraEditors.SearchLookUpEdit)
        Combo.Properties.DataSource = List()
        Combo.Properties.DisplayMember = "Nombre"
        Combo.Properties.ValueMember = "IdCotizacion"
        Combo.Properties.NullText = "[Seleccione el estado de la Cotizacion]"
        Combo.Properties.ShowFooter = False
        Combo.Properties.PopulateViewColumns()
        For i As Integer = 0 To Combo.Properties.View.Columns.Count - 1
            If Combo.Properties.View.Columns.Item(i).FieldName <> Combo.Properties.DisplayMember Then Combo.Properties.View.Columns.Item(i).Visible = False
        Next
    End Sub

    Public Function Save() As Boolean
        Dim Conn As New DbConnect.Connect(Conexion)
        Conn.AddParameter("CodConsecutEstadoProforma", SqlDbType.Int, 4, ParameterDirection.Input, CodConsecutEstadoProforma)
        Conn.AddParameter("Nombre", SqlDbType.NVarChar, 512, ParameterDirection.Input, Nombre)
        Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
        Conn.AddParameter("Facturada", SqlDbType.Bit, 4, ParameterDirection.Input, Facturada)
        Conn.AddParameter("Caducada", SqlDbType.Bit, 4, ParameterDirection.Input, Caducada)
        ' Conn.AddParameter("IdEtiqueta", SqlDbType.Int, 4, ParameterDirection.Input, IdEtiqueta)
        Conn.IniciarTransaccion()
        Try
            Conn.EjecutarComando("JAR_Proc_ProformaEstado")
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
        Conn.AddParameter("CodConsecutEstadoProforma", SqlDbType.Int, 4, ParameterDirection.InputOutput, IdCotizacion)

        Conn.IniciarTransaccion()
        Try
            Conn.EjecutarComando("sp_del_CotizacionEstado")
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