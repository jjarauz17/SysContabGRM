Public Class XtraForm1

    Private Data As DataTable = New DataTable("Requisa")

    Private Sub XtraForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ListaArticulos()
        CargarCatalogo()

        Data = ObtieneDatos("SP_GetBodegasArticulos " & EmpresaActual & ",'001','P',1,3")
        GridDetalle.DataSource = Data
        vDatos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        'GridView1.Columns("Existencia").OptionsColumn.AllowEdit = False
        'GridView1.Columns("Existencia").OptionsColumn.ReadOnly = True
        'GridView1.Columns("Existencia").OptionsColumn.AllowFocus = False
        vDatos.Columns("Cantidad").Caption = "Cantidad a Ingresar"
        ''
        Dim Config As New VB.SysContab.ConfiguracionDB
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
        ConfigDetalles = Config.GetConfigDetails

        Me.txtCosto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCosto.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

        Me.vDatos.Columns("Costo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Costo").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"

        

        GridControl1.DataSource = Data
        GridView1.PopulateColumns()
        FormatoGrid(GridView1)
        ''GridView1.Columns("Codigo").ColumnEdit = Item1
    End Sub

    Private Sub ListaArticulos()
        Dim DT As DataTable
        DT = ObtieneDatos("SP_GetArticulo " & EmpresaActual & ",'P'")
        ItemProducto.DataSource = DT
        ItemProducto.DisplayMember = "Codigo"
        ItemProducto.ValueMember = "Codigo"
        ItemProducto.PopulateColumns()
        ItemProductoD.DataSource = DT
        ItemProductoD.DisplayMember = "Nombre"
        ItemProductoD.ValueMember = "Codigo"
        ItemProductoD.PopulateColumns()

        Item1.DataSource = DT
        Item1.DisplayMember = "Nombre"
        Item1.ValueMember = "Codigo"
        Item1.PopulateColumns()
    End Sub

    Sub CargarCatalogo()
        Me.cbCatalogo.DataSource = ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual).DefaultView
        Me.cbCatalogo.ValueMember = "Cuenta"
        Me.cbCatalogo.DisplayMember = "Display"
        cbCatalogo.PopulateViewColumns()
        'Me.vCatalogo.PopulateColumns()
        FormatoGrid(Me.vCatalogo)

        Me.vCatalogo.Columns("Display").Visible = False
        Me.vCatalogo.Columns("Cuenta").VisibleIndex = 0
        Me.vCatalogo.Columns("Nombre").VisibleIndex = 1
        Me.vCatalogo.Columns("NombreCompleto").VisibleIndex = 2

        Me.vCatalogo.BestFitColumns()
    End Sub
End Class