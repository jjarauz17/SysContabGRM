
Imports System.Data.SqlClient

Public Class db_Prod_EstadoProduccion
    Inherits ClComun
    Dim vProd_EstadoProduccionTabla As New Prod_EstadoProduccion
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Prod_EstadoProduccionTabla() As Prod_EstadoProduccion
        Get
            Return vProd_EstadoProduccionTabla
        End Get
        Set(ByVal value As Prod_EstadoProduccion)
            vProd_EstadoProduccionTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Prod_EstadoProduccion As Prod_EstadoProduccion, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = Prod_EstadoProduccion.Estado
        ObjParameter(1) = Prod_EstadoProduccion.Empresa

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Prod_EstadoProduccion", ObjParameter)
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
    Public Sub Actualizar(ByVal Prod_EstadoProduccion As Prod_EstadoProduccion, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = Prod_EstadoProduccion.IdSysEstadoPRoduccion
        ObjParameter(1) = Prod_EstadoProduccion.Estado

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Prod_EstadoProduccion", ObjParameter)
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
    Public Shared Function Listar(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_Prod_EstadoProduccion", Id, EmpresaActual)

    End Function

    Public Function GetTipoEstadoOrden(TipoEstado As Integer, _
                                       Optional Tran As Boolean = False) As Integer

        Dim ObjParameter(3) As String

        ObjParameter(0) = 0
        ObjParameter(1) = EmpresaActual
        ObjParameter(2) = TipoEstado

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_sel_Prod_EstadoPendiente", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If

            Return cmd.Parameters(1).Value
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

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Prod_EstadoProduccion As Prod_EstadoProduccion, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Prod_EstadoProduccion.IdSysEstadoPRoduccion
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Prod_EstadoProduccion", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As Prod_EstadoProduccion
        Dim dt As DataTable = ObtieneDatos("sp_sel_Prod_EstadoProduccion", Id, EmpresaActual)
        Dim det As New Prod_EstadoProduccion

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdSysEstadoPRoduccion = .item("IdSysEstadoPRoduccion")
                det.Estado = .item("Estado")
                det.Empresa = .item("Empresa")
            End With
        End If
        Return det
    End Function
End Class
