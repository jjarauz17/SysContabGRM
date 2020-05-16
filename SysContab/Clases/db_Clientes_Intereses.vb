
Imports System.Data.SqlClient

Public Class db_Clientes_Intereses
    Inherits ClComun
    Dim vClientes_InteresesTabla As New Clientes_Intereses
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Clientes_InteresesTabla() As Clientes_Intereses
        Get
            Return vClientes_InteresesTabla
        End Get
        Set(ByVal value As Clientes_Intereses)
            vClientes_InteresesTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Clientes_Intereses As Clientes_Intereses, Optional Tran As Boolean = False)
        Dim ObjParameter(5) As String
        ObjParameter(0) = Clientes_Intereses.Empresa
        ObjParameter(1) = Clientes_Intereses.Corriente
        ObjParameter(2) = Clientes_Intereses.Moratorio
        ObjParameter(3) = Clientes_Intereses.Cuenta_Corriente
        ObjParameter(4) = Clientes_Intereses.Cuenta_Morosidad

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Clientes_Intereses", ObjParameter)
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
    Public Sub Actualizar(ByVal Clientes_Intereses As Clientes_Intereses, Optional Tran As Boolean = False)
        Dim ObjParameter(6) As String
        ObjParameter(0) = Clientes_Intereses.IdInteres
        ObjParameter(1) = Clientes_Intereses.Empresa
        ObjParameter(2) = Clientes_Intereses.Corriente
        ObjParameter(3) = Clientes_Intereses.Moratorio
        ObjParameter(4) = Clientes_Intereses.Cuenta_Corriente
        ObjParameter(5) = Clientes_Intereses.Cuenta_Morosidad

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Clientes_Intereses", ObjParameter)
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
    Public Shared Function Listar() As Data.DataTable

        Return ObtieneDatos("sp_sel_Clientes_Intereses", EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Clientes_Intereses As Clientes_Intereses, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Clientes_Intereses.IdInteres
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Clientes_Intereses", ObjParameter)
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
    Public Shared Function Detalles() As Clientes_Intereses
        Dim dt As DataTable = ObtieneDatos("sp_sel_Clientes_Intereses", EmpresaActual)
        Dim det As New Clientes_Intereses

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdInteres = .Item("IdInteres")
                ' det.Empresa = .Item("Empresa")
                det.Corriente = .Item("Corriente")
                det.Moratorio = .Item("Moratorio")
                det.Cuenta_Corriente = .Item("Cuenta_Corriente")
                det.Cuenta_Morosidad = .Item("Cuenta_Morosidad")
            End With
        End If
        Return det
    End Function
End Class
