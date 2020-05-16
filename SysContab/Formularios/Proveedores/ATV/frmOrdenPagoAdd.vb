Imports SysContab.VB.SysContab

Public Class frmOrdenPagoAdd

    Dim fp As New Forma_PagoDB
    Dim fc As New Facturas_ComprasDB
    Dim Articulos As New ArticulosDB
    Dim ArticulosCC As New GruposCCDB
    Dim DetalleEmpresa As New EmpresasDetails
    Dim ConfigDetalle As New ConfiguracionDetails
    Dim OrdenesCompra As New Ordenes_ComprasDB
    Dim Plantilla As New PlantillaDB
    Dim plan As String = Plantilla.GetTipoPlantilla(1, 9)
    Dim PlantillaDetalle As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)

    Public IdFactura As Integer = 0

    Private Sub frmOrdenPagoAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Fecha.DateTime = f.Date
        FechaPago.DateTime = f.Date
        '
        DetalleEmpresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        ConfigDetalle = VB.SysContab.ConfiguracionDB.GetConfigDetails()
        '
        CargarCombos()
        Cargar()
    End Sub

    Sub Cargar()
        iGrid.DataSource = OrdenesCompra.OrdenComprasDetalle(0, 99)
        iVista.PopulateColumns()
        FormatoGrid(iVista, 6, 0, False, True, False)
        '
        iVista.Columns("Codigo").ColumnEdit = cbItems
        iVista.Columns("Cuenta").ColumnEdit = cbCatalogo
        iVista.Columns("IdProyecto").ColumnEdit = cbProyectos

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).Visible = False
        Next

        iVista.Columns("Codigo").Visible = True
        iVista.Columns("Cuenta").Visible = True
        iVista.Columns("Cantidad").Visible = True
        iVista.Columns("Precio").Visible = True
        iVista.Columns("PrecioU").Visible = True
        iVista.Columns("descuento").Visible = True
        iVista.Columns("SubTotal").Visible = True
        iVista.Columns("Comentarios").Visible = True
        iVista.Columns("IdProyecto").Visible = True
    End Sub

    Sub CargarCombos()
        SearchLookUp(cbProveedor, VB.SysContab.ProveedoresDB.ProveedoresList(1).Tables("Proveedores"), "Nombre", "Codigo")
        GetFormaPagoList(cbFormaPago)
        cbFormaPago.ItemIndex = 0
        '
        RepositorySearchLook(
            cbCatalogo,
            ObtieneDatos("_GetCatalogo_Cuenta", EmpresaActual),
            "Display",
            "Cuenta",
            2)

        RepositorySearchLook(
            cbProyectos,
            db_Proyectos.Fill(),
            "Nombre",
            "IdProyecto",
            0, 4, 5, 6, 7, 8)

        GetMonedasList(cbMoneda)
        GetBodegasList(cbBodega)
        cbBodega.EditValue = ConfigDetalle.Bodega
    End Sub

    Sub LoadItems()
        If gbTipo.EditValue = "I" Then
            RepositorySearchLook(
                cbItems,
                ArticulosCC.ArticulosCCInvent().Tables("GruposCC"),
                "Display",
                "Codigo",
                3, 4, 5, 6, 7, 8, 9)
        Else
            RepositorySearchLook(
                cbItems,
                Articulos.ProductosGetLista(gbTipo.EditValue).Tables("Articulos"),
                "Display",
                "Codigo",
                3, 4, 5, 6, 7, 8, 9, 10)
        End If
    End Sub
End Class