
Imports System.Data.SqlClient

Public Class db_Clientes_Exoneraciones
    Inherits ClComun
    Dim vClientes_ExoneracionesTabla As New Clientes_Exoneraciones
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Clientes_ExoneracionesTabla() As Clientes_Exoneraciones
        Get
            Return vClientes_ExoneracionesTabla
        End Get
        Set(ByVal value As Clientes_Exoneraciones)
            vClientes_ExoneracionesTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Clientes_Exoneraciones As Clientes_Exoneraciones, Optional Tran As Boolean = False)
        Dim ObjParameter(5) As String
        ObjParameter(0) = Clientes_Exoneraciones.Empresa
        ObjParameter(1) = Clientes_Exoneraciones.Factura
        ObjParameter(2) = Clientes_Exoneraciones.IdCliente
        ObjParameter(3) = Clientes_Exoneraciones.Referencia
        ObjParameter(4) = Clientes_Exoneraciones.Comentarios

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Clientes_Exoneraciones", ObjParameter)
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
    Public Sub Actualizar(ByVal Clientes_Exoneraciones As Clientes_Exoneraciones, Optional Tran As Boolean = False)
        Dim ObjParameter(6) As String
        ObjParameter(0) = Clientes_Exoneraciones.IdExonera
        ObjParameter(1) = Clientes_Exoneraciones.Empresa
        ObjParameter(2) = Clientes_Exoneraciones.Factura
        ObjParameter(3) = Clientes_Exoneraciones.IdCliente
        ObjParameter(4) = Clientes_Exoneraciones.Referencia
        ObjParameter(5) = Clientes_Exoneraciones.Comentarios

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Clientes_Exoneraciones", ObjParameter)
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

        Return ObtieneDatos("sp_sel_Clientes_Exoneraciones", Id, Desde, Hasta, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Clientes_Exoneraciones As Clientes_Exoneraciones, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = Clientes_Exoneraciones.Factura
        ObjParameter(1) = Clientes_Exoneraciones.Empresa
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Clientes_Exoneraciones", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As Clientes_Exoneraciones
        Dim dt As DataTable = ObtieneDatos("sp_sel_Clientes_Exoneraciones", Id, EmpresaActual)
        Dim det As New Clientes_Exoneraciones

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdExonera = .Item("IdExonera")
                det.Empresa = .Item("Empresa")
                det.Factura = .Item("Factura")
                det.IdCliente = .Item("IdCliente")
                det.Referencia = .Item("Referencia")
                det.Comentarios = .Item("Comentarios")
            End With
        End If
        Return det
    End Function
End Class
