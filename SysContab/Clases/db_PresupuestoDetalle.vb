
Imports System.Data.SqlClient

Public Class db_PresupuestoDetalle
    Inherits ClComun
    Dim vPresupuestoDetalleTabla As New PresupuestoDetalle
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property PresupuestoDetalleTabla() As PresupuestoDetalle
        Get
            Return vPresupuestoDetalleTabla
        End Get
        Set(ByVal value As PresupuestoDetalle)
            vPresupuestoDetalleTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal PresupuestoDetalle As PresupuestoDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(18) As String
        ObjParameter(0) = PresupuestoDetalle.IdPresupuesto
        ObjParameter(1) = EmpresaActual
        ObjParameter(2) = PresupuestoDetalle.Producto
        ObjParameter(3) = PresupuestoDetalle.Presentacion
        ObjParameter(4) = PresupuestoDetalle.Unidad
        ObjParameter(5) = PresupuestoDetalle.Precio
        ObjParameter(6) = PresupuestoDetalle.Cantidad1
        ObjParameter(7) = PresupuestoDetalle.Cantidad2
        ObjParameter(8) = PresupuestoDetalle.Cantidad3
        ObjParameter(9) = PresupuestoDetalle.Cantidad4
        ObjParameter(10) = PresupuestoDetalle.Cantidad5
        ObjParameter(11) = PresupuestoDetalle.Cantidad6
        ObjParameter(12) = PresupuestoDetalle.Cantidad7
        ObjParameter(13) = PresupuestoDetalle.Cantidad8
        ObjParameter(14) = PresupuestoDetalle.Cantidad9
        ObjParameter(15) = PresupuestoDetalle.Cantidad10
        ObjParameter(16) = PresupuestoDetalle.Cantidad11
        ObjParameter(17) = PresupuestoDetalle.Cantidad12

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_PresupuestoDetalle", ObjParameter)
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
    Public Sub Actualizar(ByVal PresupuestoDetalle As PresupuestoDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(19) As String
        ObjParameter(0) = PresupuestoDetalle.IdDetalle
        ObjParameter(1) = PresupuestoDetalle.IdPresupuesto
        ObjParameter(2) = EmpresaActual
        ObjParameter(3) = PresupuestoDetalle.Producto
        ObjParameter(4) = PresupuestoDetalle.Presentacion
        ObjParameter(5) = PresupuestoDetalle.Unidad
        ObjParameter(6) = PresupuestoDetalle.Precio
        ObjParameter(7) = PresupuestoDetalle.Cantidad1
        ObjParameter(8) = PresupuestoDetalle.Cantidad2
        ObjParameter(9) = PresupuestoDetalle.Cantidad3
        ObjParameter(10) = PresupuestoDetalle.Cantidad4
        ObjParameter(11) = PresupuestoDetalle.Cantidad5
        ObjParameter(12) = PresupuestoDetalle.Cantidad6
        ObjParameter(13) = PresupuestoDetalle.Cantidad7
        ObjParameter(14) = PresupuestoDetalle.Cantidad8
        ObjParameter(15) = PresupuestoDetalle.Cantidad9
        ObjParameter(16) = PresupuestoDetalle.Cantidad10
        ObjParameter(17) = PresupuestoDetalle.Cantidad11
        ObjParameter(18) = PresupuestoDetalle.Cantidad12

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_PresupuestoDetalle", ObjParameter)
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
    Public Shared Function Listar(IdPresupuesto As Integer, Sucursal As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_PresupuestoDetalle", IdPresupuesto, EmpresaActual, Sucursal)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal PresupuestoDetalle As PresupuestoDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = PresupuestoDetalle.IdDetalle
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_PresupuestoDetalle", ObjParameter)
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
    Public Shared Function Detalles(ByVal IdPresupuesto As String) As PresupuestoDetalle
        Dim dt As DataTable = ObtieneDatos("sp_sel_PresupuestoDetalle", IdPresupuesto, EmpresaActual)
        Dim det As New PresupuestoDetalle

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdDetalle = .Item("IdDetalle")
                det.IdPresupuesto = .Item("IdPresupuesto")
                det.Empresa = .Item("Empresa")
                det.Producto = .Item("Producto")
                det.Presentacion = .Item("Presentacion")
                det.Unidad = .Item("Unidad")
                det.Precio = .Item("Precio")
                det.Cantidad1 = .Item("Cantidad1")
                det.Cantidad2 = .Item("Cantidad2")
                det.Cantidad3 = .Item("Cantidad3")
                det.Cantidad4 = .Item("Cantidad4")
                det.Cantidad5 = .Item("Cantidad5")
                det.Cantidad6 = .Item("Cantidad6")
                det.Cantidad7 = .Item("Cantidad7")
                det.Cantidad8 = .Item("Cantidad8")
                det.Cantidad9 = .Item("Cantidad9")
                det.Cantidad10 = .Item("Cantidad10")
                det.Cantidad11 = .Item("Cantidad11")
                det.Cantidad12 = .Item("Cantidad12")
            End With
        End If
        Return det
    End Function
End Class
