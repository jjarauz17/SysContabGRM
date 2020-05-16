Imports System.Data.SqlClient
Public Class db_Prod_CatalogoProductos
    Inherits ClComun
    Dim vProd_CatalogoProductosTabla As New Prod_CatalogoProductos
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Prod_CatalogoProductosTabla() As Prod_CatalogoProductos
        Get
            Return vProd_CatalogoProductosTabla
        End Get
        Set(ByVal value As Prod_CatalogoProductos)
            vProd_CatalogoProductosTabla = value
        End Set
    End Property

    Public Shared Function Detalles(ByVal Id As String) As Prod_CatalogoProductos
        Dim dt As DataTable = ObtieneDatos("sp_GetProductos_Forumlas", EmpresaActual, 1, Id)
        Dim det As New Prod_CatalogoProductos

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.Codigo = .Item("Codigo")
                det.Nombre = .Item("Descripción")
                det.Tipo = .Item("Tipo")
                det.Unidad = IsNull(.Item("Unidad"), "")
                det.Presentacion = IsNull(.Item("Presentacion"), "")
            End With
        End If
        Return det
    End Function

End Class
