
Imports System.Data.SqlClient

Public Class db_PNR_PlanNegocioDetalle
    Inherits ClComun
    Dim vPNR_PlanNegocioDetalleTabla As New PNR_PlanNegocioDetalle
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property PNR_PlanNegocioDetalleTabla() As PNR_PlanNegocioDetalle
        Get
            Return vPNR_PlanNegocioDetalleTabla
        End Get
        Set(ByVal value As PNR_PlanNegocioDetalle)
            vPNR_PlanNegocioDetalleTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal PNR_PlanNegocioDetalle As PNR_PlanNegocioDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(33) As String

        ObjParameter(0) = PNR_PlanNegocioDetalle.IdPlanNegocio
        ObjParameter(1) = PNR_PlanNegocioDetalle.Presentacion
        ObjParameter(2) = PNR_PlanNegocioDetalle.Producto
        ObjParameter(3) = PNR_PlanNegocioDetalle.Unidad
        ObjParameter(4) = PNR_PlanNegocioDetalle.Tipo
        ObjParameter(5) = PNR_PlanNegocioDetalle.Cantidad_Anterior
        ObjParameter(6) = PNR_PlanNegocioDetalle.Cantidad
        ObjParameter(7) = PNR_PlanNegocioDetalle.CantidadQ1
        ObjParameter(8) = PNR_PlanNegocioDetalle.VentasQ1
        ObjParameter(9) = PNR_PlanNegocioDetalle.CantidadQ2
        ObjParameter(10) = PNR_PlanNegocioDetalle.VentasQ2
        ObjParameter(11) = PNR_PlanNegocioDetalle.CantidadQ3
        ObjParameter(12) = PNR_PlanNegocioDetalle.VentasQ3
        ObjParameter(13) = PNR_PlanNegocioDetalle.CantidadQ4
        ObjParameter(14) = PNR_PlanNegocioDetalle.VentasQ4
        ObjParameter(15) = PNR_PlanNegocioDetalle.Enero
        ObjParameter(16) = PNR_PlanNegocioDetalle.Febrero
        ObjParameter(17) = PNR_PlanNegocioDetalle.Marzo
        ObjParameter(18) = PNR_PlanNegocioDetalle.Abril
        ObjParameter(19) = PNR_PlanNegocioDetalle.Mayo
        ObjParameter(20) = PNR_PlanNegocioDetalle.Junio
        ObjParameter(21) = PNR_PlanNegocioDetalle.Julio
        ObjParameter(22) = PNR_PlanNegocioDetalle.Agosto
        ObjParameter(23) = PNR_PlanNegocioDetalle.Septiembre
        ObjParameter(24) = PNR_PlanNegocioDetalle.Octubre
        ObjParameter(25) = PNR_PlanNegocioDetalle.Noviembre
        ObjParameter(26) = PNR_PlanNegocioDetalle.Diciembre
        ObjParameter(27) = PNR_PlanNegocioDetalle.Venta_Anterior
        ObjParameter(28) = PNR_PlanNegocioDetalle.Precio
        ObjParameter(29) = PNR_PlanNegocioDetalle.ProyeccionQ1
        ObjParameter(30) = PNR_PlanNegocioDetalle.ProyeccionQ2
        ObjParameter(31) = PNR_PlanNegocioDetalle.ProyeccionQ3
        ObjParameter(32) = PNR_PlanNegocioDetalle.ProyeccionQ4

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_PNR_PlanNegocioDetalle", ObjParameter)
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
    Public Sub Actualizar(ByVal PNR_PlanNegocioDetalle As PNR_PlanNegocioDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(34) As String

        ObjParameter(0) = PNR_PlanNegocioDetalle.IdDetalle
        ObjParameter(1) = PNR_PlanNegocioDetalle.IdPlanNegocio
        ObjParameter(2) = PNR_PlanNegocioDetalle.Presentacion
        ObjParameter(3) = PNR_PlanNegocioDetalle.Producto
        ObjParameter(4) = PNR_PlanNegocioDetalle.Unidad
        ObjParameter(5) = PNR_PlanNegocioDetalle.Tipo
        ObjParameter(6) = PNR_PlanNegocioDetalle.Cantidad_Anterior
        ObjParameter(7) = PNR_PlanNegocioDetalle.Cantidad
        ObjParameter(8) = PNR_PlanNegocioDetalle.CantidadQ1
        ObjParameter(9) = PNR_PlanNegocioDetalle.VentasQ1
        ObjParameter(10) = PNR_PlanNegocioDetalle.CantidadQ2
        ObjParameter(11) = PNR_PlanNegocioDetalle.VentasQ2
        ObjParameter(12) = PNR_PlanNegocioDetalle.CantidadQ3
        ObjParameter(13) = PNR_PlanNegocioDetalle.VentasQ3
        ObjParameter(14) = PNR_PlanNegocioDetalle.CantidadQ4
        ObjParameter(15) = PNR_PlanNegocioDetalle.VentasQ4
        ObjParameter(16) = PNR_PlanNegocioDetalle.Enero
        ObjParameter(17) = PNR_PlanNegocioDetalle.Febrero
        ObjParameter(18) = PNR_PlanNegocioDetalle.Marzo
        ObjParameter(19) = PNR_PlanNegocioDetalle.Abril
        ObjParameter(20) = PNR_PlanNegocioDetalle.Mayo
        ObjParameter(21) = PNR_PlanNegocioDetalle.Junio
        ObjParameter(22) = PNR_PlanNegocioDetalle.Julio
        ObjParameter(23) = PNR_PlanNegocioDetalle.Agosto
        ObjParameter(24) = PNR_PlanNegocioDetalle.Septiembre
        ObjParameter(25) = PNR_PlanNegocioDetalle.Octubre
        ObjParameter(26) = PNR_PlanNegocioDetalle.Noviembre
        ObjParameter(27) = PNR_PlanNegocioDetalle.Diciembre
        ObjParameter(28) = PNR_PlanNegocioDetalle.Venta_Anterior
        ObjParameter(29) = PNR_PlanNegocioDetalle.Precio
        ObjParameter(30) = PNR_PlanNegocioDetalle.ProyeccionQ1
        ObjParameter(31) = PNR_PlanNegocioDetalle.ProyeccionQ2
        ObjParameter(32) = PNR_PlanNegocioDetalle.ProyeccionQ3
        ObjParameter(33) = PNR_PlanNegocioDetalle.ProyeccionQ4

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_PNR_PlanNegocioDetalle", ObjParameter)
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
    Public Shared Function Listar(ByVal Id As String, IdPlanNegocio As Integer, Presentacion As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_PNR_PlanNegocioDetalle", Id, IdPlanNegocio, Presentacion)

    End Function

    Public Shared Function ReporteImpreso(IdPlanNegocio As Integer) As Data.DataTable

        Return ObtieneDatos("PNR_PlanNegocioReporteImpreso_Detalle", IdPlanNegocio, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal PNR_PlanNegocioDetalle As PNR_PlanNegocioDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = PNR_PlanNegocioDetalle.IdDetalle
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_PNR_PlanNegocioDetalle", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String, IdPlanNegocio As Integer) As PNR_PlanNegocioDetalle
        Dim dt As DataTable = ObtieneDatos("sp_sel_PNR_PlanNegocioDetalle", Id, IdPlanNegocio)
        Dim det As New PNR_PlanNegocioDetalle

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdDetalle = .Item("IdDetalle")
                det.IdPlanNegocio = .Item("IdPlanNegocio")
                det.Presentacion = .Item("Presentacion")
                det.Cantidad_Anterior = .Item("Cantidad_Aterior")
                det.Cantidad = .Item("Cantidad")
                det.CantidadQ1 = .Item("CantidadQ1")
                det.CantidadQ2 = .Item("CantidadQ2")
                det.CantidadQ3 = .Item("CantidadQ3")
                det.CantidadQ4 = .Item("CantidadQ4")
                det.Enero = .Item("Enero")
                det.Febrero = .Item("Febrero")
                det.Marzo = .Item("Marzo")
                det.Abril = .Item("Abril")
                det.Mayo = .Item("Mayo")
                det.Junio = .Item("Junio")
                det.Julio = .Item("Julio")
                det.Agosto = .Item("Agosto")
                det.Septiembre = .Item("Septiembre")
                det.Octubre = .Item("Octubre")
                det.Noviembre = .Item("Noviembre")
                det.Diciembre = .Item("Diciembre")
            End With
        End If
        Return det
    End Function
End Class
