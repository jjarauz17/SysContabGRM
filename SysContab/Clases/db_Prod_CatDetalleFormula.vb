
Imports System.Data.SqlClient

Public Class db_Prod_CatDetalleFormula
    Inherits ClComun
    Dim vProd_CatDetalleFormulaTabla As New Prod_CatDetalleFormula
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Prod_CatDetalleFormulaTabla() As Prod_CatDetalleFormula
        Get
            Return vProd_CatDetalleFormulaTabla
        End Get
        Set(ByVal value As Prod_CatDetalleFormula)
            vProd_CatDetalleFormulaTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Prod_CatDetalleFormula As Prod_CatDetalleFormula, Optional Tran As Boolean = False)
        Dim ObjParameter(13) As String
        ObjParameter(0) = Prod_CatDetalleFormula.IdSysArticulosFormula
        ObjParameter(1) = Prod_CatDetalleFormula.EMPRESA
        ObjParameter(2) = Prod_CatDetalleFormula.TIPO
        ObjParameter(3) = Prod_CatDetalleFormula.CODIGO_ARTICULO
        ObjParameter(4) = Prod_CatDetalleFormula.Unidad
        ObjParameter(5) = Prod_CatDetalleFormula.Presentacion
        ObjParameter(6) = Prod_CatDetalleFormula.Cantidad
        ObjParameter(7) = Prod_CatDetalleFormula.CodTipoProd
        ObjParameter(8) = Prod_CatDetalleFormula.CODIGO_BODEGA
        ObjParameter(9) = Prod_CatDetalleFormula.Costo
        ObjParameter(10) = Prod_CatDetalleFormula.Factor
        ObjParameter(11) = Prod_CatDetalleFormula.Cantidad_Unidad
        ObjParameter(12) = Prod_CatDetalleFormula.Unidad_Factor

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Prod_CatDetalleFormula", ObjParameter)
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
    Public Sub Actualizar(ByVal Prod_CatDetalleFormula As Prod_CatDetalleFormula, Optional Tran As Boolean = False)
        Dim ObjParameter(14) As String
        ObjParameter(0) = Prod_CatDetalleFormula.IdSysArticulosFormulaDetalle
        ObjParameter(1) = Prod_CatDetalleFormula.IdSysArticulosFormula
        ObjParameter(2) = Prod_CatDetalleFormula.EMPRESA
        ObjParameter(3) = Prod_CatDetalleFormula.TIPO
        ObjParameter(4) = Prod_CatDetalleFormula.CODIGO_ARTICULO
        ObjParameter(5) = Prod_CatDetalleFormula.Unidad
        ObjParameter(6) = Prod_CatDetalleFormula.Presentacion
        ObjParameter(7) = Prod_CatDetalleFormula.Cantidad
        ObjParameter(8) = Prod_CatDetalleFormula.CodTipoProd
        ObjParameter(9) = Prod_CatDetalleFormula.CODIGO_BODEGA
        ObjParameter(10) = Prod_CatDetalleFormula.Costo
        ObjParameter(11) = Prod_CatDetalleFormula.Factor
        ObjParameter(12) = Prod_CatDetalleFormula.Cantidad_Unidad
        ObjParameter(13) = Prod_CatDetalleFormula.Unidad_Factor

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Prod_CatDetalleFormula", ObjParameter)
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

        Return ObtieneDatos("sp_sel_Prod_CatDetalleFormula2", Id)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Prod_CatDetalleFormula As Prod_CatDetalleFormula, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Prod_CatDetalleFormula.IdSysArticulosFormulaDetalle
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Prod_CatDetalleFormula", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As Prod_CatDetalleFormula
        Dim dt As DataTable = ObtieneDatos("sp_sel_Prod_CatDetalleFormula", Id)
        Dim det As New Prod_CatDetalleFormula

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdSysArticulosFormulaDetalle = .item("IdSysArticulosFormulaDetalle")
                det.IdSysArticulosFormula = .item("IdSysArticulosFormula")
                det.EMPRESA = .item("EMPRESA")
                det.TIPO = .item("TIPO")
                det.CODIGO_ARTICULO = .item("CODIGO_ARTICULO")
                det.Unidad = .item("Unidad")
                det.Presentacion = .item("Presentacion")
                det.Cantidad = .item("Cantidad")
                det.CodTipoProd = .item("CodTipoProd")
                det.CODIGO_BODEGA = .item("CODIGO_BODEGA")
            End With
        End If
        Return det
    End Function
End Class
