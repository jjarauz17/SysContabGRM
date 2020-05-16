
Imports System.Data.SqlClient

Public Class db_PNR_ClientesAdicionales
    Inherits ClComun
    Dim vPNR_ClientesAdicionalesTabla As New PNR_ClientesAdicionales
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property PNR_ClientesAdicionalesTabla() As PNR_ClientesAdicionales
        Get
            Return vPNR_ClientesAdicionalesTabla
        End Get
        Set(ByVal value As PNR_ClientesAdicionales)
            vPNR_ClientesAdicionalesTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal PNR_ClientesAdicionales As PNR_ClientesAdicionales, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = PNR_ClientesAdicionales.IdCliente
        ObjParameter(1) = PNR_ClientesAdicionales.IdPlanNegocio

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_PNR_ClientesAdicionales", ObjParameter)
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
    Public Sub Actualizar(ByVal PNR_ClientesAdicionales As PNR_ClientesAdicionales, Optional Tran As Boolean = False)
        Dim ObjParameter(3) As String
        ObjParameter(0) = PNR_ClientesAdicionales.IdDetalle
        ObjParameter(1) = PNR_ClientesAdicionales.IdCliente
        ObjParameter(2) = PNR_ClientesAdicionales.IdPlanNegocio

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_PNR_ClientesAdicionales", ObjParameter)
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
    Public Shared Function Listar(ByVal Id As Integer, IdPlanNegocio As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_PNR_ClientesAdicionales", Id, IdPlanNegocio)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal PNR_ClientesAdicionales As PNR_ClientesAdicionales, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = PNR_ClientesAdicionales.IdPlanNegocio
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_PNR_ClientesAdicionales", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As PNR_ClientesAdicionales
        Dim dt As DataTable = ObtieneDatos("sp_sel_PNR_ClientesAdicionales", Id)
        Dim det As New PNR_ClientesAdicionales

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdDetalle = .item("IdDetalle")
                det.IdCliente = .item("IdCliente")
                det.IdPlanNegocio = .item("IdPlanNegocio")
            End With
        End If
        Return det
    End Function
End Class
