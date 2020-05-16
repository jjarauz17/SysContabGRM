
Imports System.Data.SqlClient
Public Class ClRemisiones_Lineas
    Inherits SysContab.ClComun
    Dim vRemisiones_LineasTabla As New Remisiones
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Remisiones_LineasTabla() As Remisiones
        Get
            Return vRemisiones_LineasTabla
        End Get
        Set(ByVal value As Remisiones)
            vRemisiones_LineasTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub ins_Remisiones_Lineas(ByVal Remisiones_Lineas As Remisiones)
        Dim ObjParameter(7) As String
        ObjParameter(0) = Remisiones_Lineas.Empresa
        ObjParameter(1) = Remisiones_Lineas.Remision
        ObjParameter(2) = Remisiones_Lineas.Item
        ObjParameter(3) = Remisiones_Lineas.Cantidad
        ObjParameter(4) = Remisiones_Lineas.Precio
        ObjParameter(5) = Remisiones_Lineas.IVA
        ObjParameter(6) = Remisiones_Lineas.SubTotal

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            vRemisiones_LineasTabla.Remision = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Remisiones_Lineas", ObjParameter).ExecuteNonQuery()
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
    Public Sub upd_Remisiones_Lineas(ByVal Remisiones_Lineas As Remisiones)
        'Dim ObjParameter(8) As String

        'ObjParameter(0) = Remisiones_Lineas.IdDetalle
        'ObjParameter(1) = Remisiones_Lineas.Empresa
        'ObjParameter(2) = Remisiones_Lineas.Remision
        'ObjParameter(3) = Remisiones_Lineas.Item
        'ObjParameter(4) = Remisiones_Lineas.Cantidad
        'ObjParameter(5) = Remisiones_Lineas.Precio
        'ObjParameter(6) = Remisiones_Lineas.IVA
        'ObjParameter(7) = Remisiones_Lineas.SubTotal

        'Try
        '    Me.InicializarMensajeError()
        '    Me.OpenSqlBD()
        '    vRemisiones_LineasTabla.IdDetalle = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Remisiones_Lineas", ObjParameter).ExecuteNonQuery()
        '    Me.Commit()
        'Catch ex As Exception
        '    Me.CodigoError = -1
        '    Me.Rollback()
        '    Me.MensajeError = ex.Message
        '    Me.SendEmail(ex.Message)
        'Finally
        '    Me.CloseSqlBD()
        'End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function sel_Remisiones_Lineas() As Data.DataTable
        Dim dt As New Data.DataTable
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            dt.Load(Me.ConfigurarComando("sp_sel_Remisiones_Lineas").ExecuteReader)
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
    Public Sub del_Remisiones_Lineas(ByVal Remisiones_Lineas As Remisiones)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Remisiones_Lineas.Remision
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Remisiones_Lineas", ObjParameter).ExecuteNonQuery()
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

