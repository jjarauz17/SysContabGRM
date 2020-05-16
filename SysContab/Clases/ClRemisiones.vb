Imports System.Data.SqlClient
'Namespace NombreSistema.Transacciones

Public Class ClRemisiones

    Inherits SysContab.ClComun
    Dim vRemisionesTabla As New Remisiones
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property RemisionesTabla() As Remisiones
        Get
            Return vRemisionesTabla
        End Get
        Set(ByVal value As Remisiones)
            vRemisionesTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub ins_Remisiones(ByVal Remisiones As Remisiones)
        Dim ObjParameter(10) As String
        ObjParameter(0) = Remisiones.Empresa
        ObjParameter(1) = Remisiones.Remision
        ObjParameter(2) = Remisiones.Fecha
        ObjParameter(3) = Remisiones.Sucursal
        ObjParameter(4) = Remisiones.Cliente
        ObjParameter(5) = Remisiones.Transaportista
        ObjParameter(6) = Remisiones.Conductor
        ObjParameter(7) = Remisiones.NoPlaca
        ObjParameter(8) = Remisiones.Orden
        ObjParameter(9) = Remisiones.Traslado

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            vRemisionesTabla.Remision = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Remisiones", ObjParameter).ExecuteNonQuery()
            Me.Commit()
        Catch ex As Exception
            Me.CodigoError = -1
            Me.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            'Me.MensajeError = ex.Message
            Me.SendEmail(ex.Message)
        Finally
            Me.CloseSqlBD()
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub upd_Remisiones(ByVal Remisiones As Remisiones)
        Dim ObjParameter(10) As String
        ObjParameter(0) = Remisiones.Empresa
        ObjParameter(1) = Remisiones.Remision
        ObjParameter(2) = Remisiones.Fecha
        ObjParameter(3) = Remisiones.Sucursal
        ObjParameter(4) = Remisiones.Cliente
        ObjParameter(5) = Remisiones.Transaportista
        ObjParameter(6) = Remisiones.Conductor
        ObjParameter(7) = Remisiones.NoPlaca
        ObjParameter(8) = Remisiones.Orden
        ObjParameter(9) = Remisiones.Traslado

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            vRemisionesTabla.Remision = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Remisiones", ObjParameter).ExecuteNonQuery()
            Me.Commit()
        Catch ex As Exception
            Me.CodigoError = -1
            Me.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            'Me.MensajeError = ex.Message
            'Me.SendEmail(ex.Message)
        Finally
            Me.CloseSqlBD()
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function sel_Remisiones() As Data.DataTable
        Dim dt As New Data.DataTable
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            dt.Load(Me.ConfigurarComando("sp_sel_Remisiones").ExecuteReader)
        Catch ex As Exception
            Me.CodigoError = -1
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            'Me.MensajeError = ex.Message
            'Me.SendEmail(ex.Message)
        Finally
            Me.CloseSqlBD()
        End Try
        Return dt
    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub del_Remisiones(ByVal Remisiones As Remisiones)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Remisiones.Empresa
        ObjParameter(2) = Remisiones.Remision

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Remisiones", ObjParameter).ExecuteNonQuery()
            Me.Commit()
        Catch ex As Exception
            Me.CodigoError = -1
            Me.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            'Me.MensajeError = ex.Message
            'Me.SendEmail(ex.Message)
        Finally
            Me.CloseSqlBD()
        End Try
    End Sub


End Class

'End Namespace
