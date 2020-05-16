Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DAL

Public Class db_Depositos
    Inherits ClComun

    Dim vDepositosTabla As New Depositos
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property DepositosTabla() As Depositos
        Get
            Return vDepositosTabla
        End Get
        Set(ByVal value As Depositos)
            vDepositosTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Depositos As Depositos, Optional Tran As Boolean = False)
        Dim ObjParameter(14) As String
        ObjParameter(0) = Depositos.Deposito_ID
        ObjParameter(1) = Depositos.Empresa
        ObjParameter(2) = Depositos.Fecha
        ObjParameter(3) = Depositos.Sucursal
        ObjParameter(4) = Depositos.Documento
        ObjParameter(5) = Depositos.Comentario
        ObjParameter(6) = Depositos.Banco
        ObjParameter(7) = Depositos.NoCuenta
        ObjParameter(8) = Depositos.Estado
        ObjParameter(9) = Depositos.Contabilizado
        ObjParameter(10) = Depositos.Fecha_Creacion
        ObjParameter(11) = Depositos.Usuario
        ObjParameter(12) = Depositos.Fecha_Modificacion
        ObjParameter(13) = Depositos.Usuario_Modificacion

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Depositos", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal Depositos As Depositos, Optional Tran As Boolean = False)
        Dim ObjParameter(15) As String
        ObjParameter(0) = Depositos.IdDeposito
        ObjParameter(1) = Depositos.Deposito_ID
        ObjParameter(2) = Depositos.Empresa
        ObjParameter(3) = Depositos.Fecha
        ObjParameter(4) = Depositos.Sucursal
        ObjParameter(5) = Depositos.Documento
        ObjParameter(6) = Depositos.Comentario
        ObjParameter(7) = Depositos.Banco
        ObjParameter(8) = Depositos.NoCuenta
        ObjParameter(9) = Depositos.Estado
        ObjParameter(10) = Depositos.Contabilizado
        ObjParameter(11) = Depositos.Fecha_Creacion
        ObjParameter(12) = Depositos.Usuario
        ObjParameter(13) = Depositos.Fecha_Modificacion
        ObjParameter(14) = Depositos.Usuario_Modificacion

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Depositos", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar(ByVal Id As Integer, Desde As Date, Hasta As Date) As Data.DataTable

        Return ObtieneDatos("sp_sel_Depositos",
                            Id,
                            Desde,
                            Hasta,
                            EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Ingresos(Sucursal As String,
                                    IdUsuario As Integer,
                                    IdDeposito As Integer,
                                    Fecha As Date) As Data.DataTable

        Return ObtieneDatos("sp_sel_DepositosIngresos",
                            Sucursal,
                            IdUsuario,
                            IdDeposito,
                            Fecha,
                            EmpresaA)

    End Function

    Public Shared Function IngresosResumen(Sucursal As String,
                                           IdUsuario As Integer,
                                           IdDeposito As Integer,
                                           Fecha As Date) As Data.DataTable


        Return ObtieneDatos("sp_sel_DepositosIngresosResumen",
                            Sucursal,
                            IdUsuario,
                            IdDeposito,
                            Fecha,
                            EmpresaA)

    End Function

    Public Shared Function Numero(Sucursal As String) As String

        Return ObtieneDatos("sp_sel_DepositosNumero",
                            Sucursal,
                            EmpresaA).Rows.Item(0)("Numero").ToString()

    End Function

    Public Shared Function Documento(Fecha As Date,
                                     Sucursal As String,
                                     IdDeposito As Integer) As String

        Return ObtieneDatos("sp_sel_DepositosDocumento",
                            Fecha,
                            Sucursal,
                            IdDeposito,
                            EmpresaA).Rows.Item(0)("Documento").ToString()

    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Depositos As Depositos, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Depositos.IdDeposito
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Depositos", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Id As Integer) As Depositos
        Dim dt As DataTable = ObtieneDatos("sp_sel_Depositos", Id, EmpresaA)
        Dim det As New Depositos

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdDeposito = .Item("IdDeposito")
                det.Deposito_ID = .Item("Deposito_ID")
                det.Empresa = .Item("Empresa")
                det.Fecha = .Item("Fecha")
                det.Sucursal = .Item("Sucursal")
                det.Documento = .Item("Documento")
                det.Comentario = .Item("Comentario")
                det.Banco = .Item("Banco")
                det.NoCuenta = .Item("NoCuenta")
                det.Estado = .Item("Estado")
                det.Contabilizado = .Item("Contabilizado")
                det.Fecha_Creacion = .Item("Fecha_Creacion")
                det.Usuario = .Item("Usuario")
                det.Fecha_Modificacion = .Item("Fecha_Modificacion")
                det.Usuario_Modificacion = .Item("Usuario_Modificacion")
            End With
        End If
        Return det
    End Function
End Class
