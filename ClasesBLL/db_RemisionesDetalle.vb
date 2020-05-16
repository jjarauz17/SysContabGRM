
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_RemisionesDetalle
    Inherits ClComun
    Dim vRemisionesDetalleTabla As New RemisionesDetalle
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property RemisionesDetalleTabla() As RemisionesDetalle
        Get
            Return vRemisionesDetalleTabla
        End Get
        Set(ByVal value As RemisionesDetalle)
            vRemisionesDetalleTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal RemisionesDetalle As RemisionesDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(10) As String
        ObjParameter(0) = EmpresaA
        ObjParameter(1) = RemisionesDetalle.IdRemision
        ObjParameter(2) = RemisionesDetalle.Tipo
        ObjParameter(3) = RemisionesDetalle.Producto
        ObjParameter(4) = RemisionesDetalle.Cantidad
        ObjParameter(5) = RemisionesDetalle.Precio
        ObjParameter(6) = RemisionesDetalle.IVA
        ObjParameter(7) = RemisionesDetalle.Descuento
        ObjParameter(8) = RemisionesDetalle.Total
        ObjParameter(9) = RemisionesDetalle.Agrupar

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_RemisionesDetalle", ObjParameter)
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
    Public Sub Actualizar(ByVal RemisionesDetalle As RemisionesDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(11) As String
        ObjParameter(0) = RemisionesDetalle.IdDetalle
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = RemisionesDetalle.IdRemision
        ObjParameter(3) = RemisionesDetalle.Tipo
        ObjParameter(4) = RemisionesDetalle.Producto
        ObjParameter(5) = RemisionesDetalle.Cantidad
        ObjParameter(6) = RemisionesDetalle.Precio
        ObjParameter(7) = RemisionesDetalle.IVA
        ObjParameter(8) = RemisionesDetalle.Descuento
        ObjParameter(9) = RemisionesDetalle.Total
        ObjParameter(10) = RemisionesDetalle.Agrupar

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_RemisionesDetalle", ObjParameter)
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

    Public Sub Actualizar_Detalle_Entregado(ByVal RemisionesDetalle As RemisionesDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(3) As String
        ObjParameter(0) = RemisionesDetalle.IdDetalle
        ObjParameter(1) = RemisionesDetalle.Cantidad
        ObjParameter(2) = EmpresaA

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_OrdenesEntregaDetalle_Entregado", ObjParameter)
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
    Public Shared Function Listar(IdRemision As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_RemisionesDetalle", IdRemision, EmpresaA)

    End Function

    Public Shared Function Listar2(IdRemision As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_RemisionesDetalleParcelas", IdRemision, EmpresaA)

    End Function

    Public Shared Function Facturar(IdRemision As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_RemisionesDetalle_Facturar", IdRemision, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function ListarOT(IdRemision As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_RemisionesDetalle_OT", IdRemision, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal RemisionesDetalle As RemisionesDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = RemisionesDetalle.IdDetalle
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_RemisionesDetalle", ObjParameter)
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
    'Public Shared Function Detalles(ByVal Id As String) As RemisionesDetalle
    '    Dim dt As DataTable = ObtieneDatos("sp_sel_RemisionesDetalle", Id)
    '    Dim det As New RemisionesDetalle

    '    If dt.Rows.Count > 0 Then
    '        With dt.Rows(0)
    '            det.IdDetalle = .Item("IdDetalle")
    '            det.Empresa = .Item("Empresa")
    '            det.IdRemision = .Item("IdRemision")
    '            det.Tipo = .Item("Tipo")
    '            det.Producto = .Item("Producto")
    '            det.Cantidad = .Item("Cantidad")
    '            det.Precio = .Item("Precio")
    '            det.IVA = .Item("IVA")
    '            det.Descuento = .Item("Descuento")
    '            det.Total = .Item("Total")
    '        End With
    '    End If
    '    Return det
    'End Function
End Class
