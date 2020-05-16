
Imports System.Data.SqlClient

Public Class db_Prod_ProduccionDetalle
    Inherits ClComun
    Dim vProd_ProduccionDetalleTabla As New Prod_ProduccionDetalle
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Prod_ProduccionDetalleTabla() As Prod_ProduccionDetalle
        Get
            Return vProd_ProduccionDetalleTabla
        End Get
        Set(ByVal value As Prod_ProduccionDetalle)
            vProd_ProduccionDetalleTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Prod_ProduccionDetalle As Prod_ProduccionDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(15) As String
        ObjParameter(0) = Prod_ProduccionDetalle.IdSysProduccion
        ObjParameter(1) = Prod_ProduccionDetalle.IdSysArticulosFormula
        ObjParameter(2) = Prod_ProduccionDetalle.EMPRESA
        ObjParameter(3) = Prod_ProduccionDetalle.TIPO
        ObjParameter(4) = Prod_ProduccionDetalle.CODIGO_ARTICULO
        ObjParameter(5) = Prod_ProduccionDetalle.Unidad
        ObjParameter(6) = Prod_ProduccionDetalle.Presentacion
        ObjParameter(7) = Prod_ProduccionDetalle.Cantidad
        ObjParameter(8) = Prod_ProduccionDetalle.CantidadProduccion
        ObjParameter(9) = Prod_ProduccionDetalle.COSTO
        ObjParameter(10) = Prod_ProduccionDetalle.CodTipoProd
        ObjParameter(11) = Prod_ProduccionDetalle.CODIGO_BODEGA
        ObjParameter(12) = Prod_ProduccionDetalle.Factor
        ObjParameter(13) = Prod_ProduccionDetalle.Cantidad_Unidad
        ObjParameter(14) = Prod_ProduccionDetalle.Unidad_Factor

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Prod_ProduccionDetalle", ObjParameter)
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
    Public Sub Actualizar(ByVal Prod_ProduccionDetalle As Prod_ProduccionDetalle, Optional Tran As Boolean = False)

        Dim ObjParameter(16) As String
        ObjParameter(0) = Prod_ProduccionDetalle.IdSysArticulosFormulaDetalle
        ObjParameter(1) = Prod_ProduccionDetalle.IdSysProduccion
        ObjParameter(2) = Prod_ProduccionDetalle.IdSysArticulosFormula
        ObjParameter(3) = Prod_ProduccionDetalle.EMPRESA
        ObjParameter(4) = Prod_ProduccionDetalle.TIPO
        ObjParameter(5) = Prod_ProduccionDetalle.CODIGO_ARTICULO
        ObjParameter(6) = Prod_ProduccionDetalle.Unidad
        ObjParameter(7) = Prod_ProduccionDetalle.Presentacion
        ObjParameter(8) = Prod_ProduccionDetalle.Cantidad
        ObjParameter(9) = Prod_ProduccionDetalle.CantidadProduccion
        ObjParameter(10) = Prod_ProduccionDetalle.COSTO
        ObjParameter(11) = Prod_ProduccionDetalle.CodTipoProd
        ObjParameter(12) = Prod_ProduccionDetalle.CODIGO_BODEGA
        ObjParameter(13) = Prod_ProduccionDetalle.Factor
        ObjParameter(14) = Prod_ProduccionDetalle.Cantidad_Unidad
        ObjParameter(15) = Prod_ProduccionDetalle.Unidad_Factor

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Prod_ProduccionDetalle", ObjParameter)
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

        Return ObtieneDatos("sp_sel_Prod_ProduccionDetalle2", Id)

    End Function

    Public Shared Function MateriaPrima(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_get_MateriaPrimaConsolidado", Id, EmpresaActual)

    End Function

    Public Shared Function ProductoTerminado(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_get_ProdTerminadoConsolidado", Id, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Prod_ProduccionDetalle As Prod_ProduccionDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Prod_ProduccionDetalle.IdSysArticulosFormulaDetalle
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Prod_ProduccionDetalle", ObjParameter)
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

    Public Sub BorrarProduccion(ByVal Prod_ProduccionDetalle As Prod_ProduccionDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Prod_ProduccionDetalle.IdSysProduccion
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "JAR_BorrarDetalleProduccion", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As Prod_ProduccionDetalle
        Dim dt As DataTable = ObtieneDatos("sp_sel_Prod_ProduccionDetalle", Id)
        Dim det As New Prod_ProduccionDetalle

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdSysArticulosFormulaDetalle = .item("IdSysArticulosFormulaDetalle")
                det.IdSysProduccion = .item("IdSysProduccion")
                det.IdSysArticulosFormula = .item("IdSysArticulosFormula")
                det.EMPRESA = .item("EMPRESA")
                det.TIPO = .item("TIPO")
                det.CODIGO_ARTICULO = .item("CODIGO_ARTICULO")
                det.Unidad = .item("Unidad")
                det.Presentacion = .item("Presentacion")
                det.Cantidad = .item("Cantidad")
                det.CantidadProduccion = .item("CantidadProduccion")
                det.COSTO = .item("COSTO")
                det.COSTO_PROM = .item("COSTO_PROM")
                det.COSTO_ULTIMO = .item("COSTO_ULTIMO")
                det.CodTipoProd = .item("CodTipoProd")
                det.CODIGO_BODEGA = .item("CODIGO_BODEGA")
            End With
        End If
        Return det
    End Function
End Class
