
Imports System.Data.SqlClient

Public Class db_SolicitudesVencimientoDetalle
    Inherits ClComun
    Dim vSolicitudesVencimientoDetalleTabla As New SolicitudesVencimientoDetalle
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property SolicitudesVencimientoDetalleTabla() As SolicitudesVencimientoDetalle
        Get
            Return vSolicitudesVencimientoDetalleTabla
        End Get
        Set(ByVal value As SolicitudesVencimientoDetalle)
            vSolicitudesVencimientoDetalleTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal SolicitudesVencimientoDetalle As SolicitudesVencimientoDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(7) As String
        ObjParameter(0) = SolicitudesVencimientoDetalle.IdSolicitud
        ObjParameter(1) = EmpresaActual
        ObjParameter(2) = SolicitudesVencimientoDetalle.Factura
        ObjParameter(3) = SolicitudesVencimientoDetalle.Vencimiento
        ObjParameter(4) = SolicitudesVencimientoDetalle.Solicitada
        ObjParameter(5) = SolicitudesVencimientoDetalle.Aprobada
        ObjParameter(6) = SolicitudesVencimientoDetalle.Comentario

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_SolicitudesVencimientoDetalle", ObjParameter)
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
    Public Sub Actualizar(ByVal SolicitudesVencimientoDetalle As SolicitudesVencimientoDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(8) As String
        ObjParameter(0) = SolicitudesVencimientoDetalle.IdDetalle
        ObjParameter(1) = SolicitudesVencimientoDetalle.IdSolicitud
        ObjParameter(2) = EmpresaActual
        ObjParameter(3) = SolicitudesVencimientoDetalle.Factura
        ObjParameter(4) = SolicitudesVencimientoDetalle.Vencimiento
        ObjParameter(5) = SolicitudesVencimientoDetalle.Solicitada
        ObjParameter(6) = SolicitudesVencimientoDetalle.Aprobada
        ObjParameter(7) = SolicitudesVencimientoDetalle.Comentario

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_SolicitudesVencimientoDetalle", ObjParameter)
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
    Public Shared Function Listar(ByVal Id As String, IdSolicitud As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_SolicitudesVencimientoDetalle", Id, IdSolicitud, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal SolicitudesVencimientoDetalle As SolicitudesVencimientoDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = SolicitudesVencimientoDetalle.IdDetalle
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_SolicitudesVencimientoDetalle", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As SolicitudesVencimientoDetalle
        Dim dt As DataTable = ObtieneDatos("sp_sel_SolicitudesVencimientoDetalle", Id, 0, EmpresaActual)
        Dim det As New SolicitudesVencimientoDetalle

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdDetalle = .item("IdDetalle")
                det.IdSolicitud = .item("IdSolicitud")
                det.Empresa = .item("Empresa")
                det.Factura = .item("Factura")
                det.Vencimiento = .item("Vencimiento")
                det.Solicitada = .item("Solicitada")
                det.Aprobada = .item("Aprobada")
                det.Comentario = .item("Comentario")
            End With
        End If
        Return det
    End Function
End Class
