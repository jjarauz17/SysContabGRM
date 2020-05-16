
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_Prod_ProduccionDevoluciones
    Inherits ClComun
    Dim vProd_ProduccionDevolucionesTabla As New Prod_ProduccionDevoluciones
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Prod_ProduccionDevolucionesTabla() As Prod_ProduccionDevoluciones
        Get
            Return vProd_ProduccionDevolucionesTabla
        End Get
        Set(ByVal value As Prod_ProduccionDevoluciones)
            vProd_ProduccionDevolucionesTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Prod_ProduccionDevoluciones As Prod_ProduccionDevoluciones, Optional Tran As Boolean = False)
        Dim ObjParameter(10) As String
        ObjParameter(0) = Prod_ProduccionDevoluciones.IdProduccion
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = Prod_ProduccionDevoluciones.Tipo
        ObjParameter(3) = Prod_ProduccionDevoluciones.Producto
        ObjParameter(4) = Prod_ProduccionDevoluciones.IdTipoProducto
        ObjParameter(5) = Prod_ProduccionDevoluciones.Unidad
        ObjParameter(6) = Prod_ProduccionDevoluciones.Presentacion
        ObjParameter(7) = Prod_ProduccionDevoluciones.Bodega
        ObjParameter(8) = Prod_ProduccionDevoluciones.Cantidad
        ObjParameter(9) = Prod_ProduccionDevoluciones.Costo

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Prod_ProduccionDevoluciones", ObjParameter)
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
    Public Sub Actualizar(ByVal Prod_ProduccionDevoluciones As Prod_ProduccionDevoluciones, Optional Tran As Boolean = False)
        Dim ObjParameter(11) As String
        ObjParameter(0) = Prod_ProduccionDevoluciones.IdDetalle
        ObjParameter(1) = Prod_ProduccionDevoluciones.IdProduccion
        ObjParameter(2) = EmpresaA
        ObjParameter(3) = Prod_ProduccionDevoluciones.Tipo
        ObjParameter(4) = Prod_ProduccionDevoluciones.Producto
        ObjParameter(5) = Prod_ProduccionDevoluciones.IdTipoProducto
        ObjParameter(6) = Prod_ProduccionDevoluciones.Unidad
        ObjParameter(7) = Prod_ProduccionDevoluciones.Presentacion
        ObjParameter(8) = Prod_ProduccionDevoluciones.Bodega
        ObjParameter(9) = Prod_ProduccionDevoluciones.Cantidad
        ObjParameter(10) = Prod_ProduccionDevoluciones.Costo

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Prod_ProduccionDevoluciones", ObjParameter)
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

        Return ObtieneDatos("sp_sel_Prod_ProduccionDevoluciones", Id, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Prod_ProduccionDevoluciones As Prod_ProduccionDevoluciones, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Prod_ProduccionDevoluciones.IdProduccion
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Prod_ProduccionDevoluciones", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As Prod_ProduccionDevoluciones
        Dim dt As DataTable = ObtieneDatos("sp_sel_Prod_ProduccionDevoluciones", Id, EmpresaA)
        Dim det As New Prod_ProduccionDevoluciones

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdDetalle = .Item("IdDetalle")
                det.IdProduccion = .Item("IdProduccion")
                det.Empresa = .Item("Empresa")
                det.Tipo = .Item("Tipo")
                det.Producto = .Item("Producto")
                det.IdTipoProducto = .Item("IdTipoProducto")
                det.Unidad = .Item("Unidad")
                det.Presentacion = .Item("Presentacion")
                det.Bodega = .Item("Bodega")
                det.Cantidad = .Item("Cantidad")
                det.Costo = .Item("Costo")
            End With
        End If
        Return det
    End Function
End Class
