
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_OrdenesTrabajoDetalle
    Inherits ClComun
    Dim vOrdenesTrabajoDetalleTabla As New OrdenesTrabajoDetalle
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property OrdenesTrabajoDetalleTabla() As OrdenesTrabajoDetalle
        Get
            Return vOrdenesTrabajoDetalleTabla
        End Get
        Set(ByVal value As OrdenesTrabajoDetalle)
            vOrdenesTrabajoDetalleTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal OrdenesTrabajoDetalle As OrdenesTrabajoDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(10) As String
        ObjParameter(0) = OrdenesTrabajoDetalle.IdOrden
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = OrdenesTrabajoDetalle.Tipo
        ObjParameter(3) = OrdenesTrabajoDetalle.Producto
        ObjParameter(4) = OrdenesTrabajoDetalle.Cantidad
        ObjParameter(5) = OrdenesTrabajoDetalle.Precio
        ObjParameter(6) = OrdenesTrabajoDetalle.IVA
        ObjParameter(7) = OrdenesTrabajoDetalle.Descuento
        ObjParameter(8) = OrdenesTrabajoDetalle.Total
        ObjParameter(9) = OrdenesTrabajoDetalle.Descripcion

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_OrdenesTrabajoDetalle", ObjParameter)
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
    Public Sub Actualizar(ByVal OrdenesTrabajoDetalle As OrdenesTrabajoDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(11) As String
        ObjParameter(0) = OrdenesTrabajoDetalle.IdDetalle
        ObjParameter(1) = OrdenesTrabajoDetalle.IdOrden
        ObjParameter(2) = EmpresaA
        ObjParameter(3) = OrdenesTrabajoDetalle.Tipo
        ObjParameter(4) = OrdenesTrabajoDetalle.Producto
        ObjParameter(5) = OrdenesTrabajoDetalle.Cantidad
        ObjParameter(6) = OrdenesTrabajoDetalle.Precio
        ObjParameter(7) = OrdenesTrabajoDetalle.IVA
        ObjParameter(8) = OrdenesTrabajoDetalle.Descuento
        ObjParameter(9) = OrdenesTrabajoDetalle.Total
        ObjParameter(10) = OrdenesTrabajoDetalle.Descripcion

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_OrdenesTrabajoDetalle", ObjParameter)
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

        Return ObtieneDatos("sp_sel_OrdenesTrabajoDetalle", Id, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalle_Movimiento(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_OrdenesTrabajoDetalleMovimiento", Id, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

    Public Shared Function Facturar(IdOrden As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_OrdenesTrabajoDetallePendiente", IdOrden, EmpresaA)

    End Function

    Public Sub Borrar(ByVal OrdenesTrabajoDetalle As OrdenesTrabajoDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = OrdenesTrabajoDetalle.IdDetalle
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_OrdenesTrabajoDetalle", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As OrdenesTrabajoDetalle
        Dim dt As DataTable = ObtieneDatos("sp_sel_OrdenesTrabajoDetalle", Id, EmpresaA)
        Dim det As New OrdenesTrabajoDetalle

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdDetalle = .Item("IdDetalle")
                det.IdOrden = .Item("IdOrden")
                det.Empresa = .Item("Empresa")
                det.Tipo = .Item("Tipo")
                det.Producto = .Item("Producto")
                det.Cantidad = .Item("Cantidad")
                det.Precio = .Item("Precio")
                det.IVA = .Item("IVA")
                det.Descuento = .Item("Descuento")
                det.Total = .Item("Total")
            End With
        End If
        Return det
    End Function
End Class
