
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_OrdenesEntregaDetalle
    Inherits ClComun
    Dim vOrdenesEntregaDetalleTabla As New OrdenesEntregaDetalle
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property OrdenesEntregaDetalleTabla() As OrdenesEntregaDetalle
        Get
            Return vOrdenesEntregaDetalleTabla
        End Get
        Set(ByVal value As OrdenesEntregaDetalle)
            vOrdenesEntregaDetalleTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal OrdenesEntregaDetalle As OrdenesEntregaDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(14) As String
        ObjParameter(0) = OrdenesEntregaDetalle.IdOrden
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = OrdenesEntregaDetalle.Tipo
        ObjParameter(3) = OrdenesEntregaDetalle.Producto
        ObjParameter(4) = OrdenesEntregaDetalle.Cantidad
        ObjParameter(5) = OrdenesEntregaDetalle.Fisico
        ObjParameter(6) = OrdenesEntregaDetalle.Autorizado
        ObjParameter(7) = OrdenesEntregaDetalle.Entregado
        ObjParameter(8) = OrdenesEntregaDetalle.Precio
        ObjParameter(9) = OrdenesEntregaDetalle.IVA
        ObjParameter(10) = OrdenesEntregaDetalle.Descuento
        ObjParameter(11) = OrdenesEntregaDetalle.Total
        ObjParameter(12) = OrdenesEntregaDetalle.Nombre
        ObjParameter(13) = OrdenesEntregaDetalle.Agrupar

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_OrdenesEntregaDetalle", ObjParameter)
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
    Public Sub Actualizar(ByVal OrdenesEntregaDetalle As OrdenesEntregaDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(15) As String
        ObjParameter(0) = OrdenesEntregaDetalle.IdDetalle
        ObjParameter(1) = OrdenesEntregaDetalle.IdOrden
        ObjParameter(2) = EmpresaA
        ObjParameter(3) = OrdenesEntregaDetalle.Tipo
        ObjParameter(4) = OrdenesEntregaDetalle.Producto
        ObjParameter(5) = OrdenesEntregaDetalle.Cantidad
        ObjParameter(6) = OrdenesEntregaDetalle.Fisico
        ObjParameter(7) = OrdenesEntregaDetalle.Autorizado
        ObjParameter(8) = OrdenesEntregaDetalle.Entregado
        ObjParameter(9) = OrdenesEntregaDetalle.Precio
        ObjParameter(10) = OrdenesEntregaDetalle.IVA
        ObjParameter(11) = OrdenesEntregaDetalle.Descuento
        ObjParameter(12) = OrdenesEntregaDetalle.Total
        ObjParameter(13) = OrdenesEntregaDetalle.Nombre
        ObjParameter(14) = OrdenesEntregaDetalle.Agrupar

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_OrdenesEntregaDetalle", ObjParameter)
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

        Return ObtieneDatos("sp_sel_OrdenesEntregaDetalle", Id, EmpresaA)

    End Function

    Public Shared Function ListarEntrega(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_OrdenesEntregaDetalle_Entrega", Id, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal OrdenesEntregaDetalle As OrdenesEntregaDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = OrdenesEntregaDetalle.IdDetalle
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_OrdenesEntregaDetalle", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As OrdenesEntregaDetalle
        Dim dt As DataTable = ObtieneDatos("sp_sel_OrdenesEntregaDetalle", Id, EmpresaA)
        Dim det As New OrdenesEntregaDetalle

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdDetalle = .Item("IdDetalle")
                det.IdOrden = .Item("IdOrden")
                det.Empresa = .Item("Empresa")
                det.Tipo = .Item("Tipo")
                det.Producto = .Item("Producto")
                det.Cantidad = .Item("Cantidad")
                det.Fisico = .Item("Fisico")
                det.Autorizado = .Item("Autorizado")
                det.Entregado = .Item("Entregado")
                det.Precio = .Item("Precio")
                det.IVA = .Item("IVA")
                det.Descuento = .Item("Descuento")
                det.Total = .Item("Total")
            End With
        End If
        Return det
    End Function
End Class
