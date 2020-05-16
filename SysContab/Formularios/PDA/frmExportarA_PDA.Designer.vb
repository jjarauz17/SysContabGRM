<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportarA_PDA
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExportarA_PDA))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bTest = New DevExpress.XtraEditors.SimpleButton()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbBodegas = New DevExpress.XtraEditors.LookUpEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCatalogos = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbBodegas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bTest)
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.bExportar)
        Me.LayoutControl1.Controls.Add(Me.bBuscar)
        Me.LayoutControl1.Controls.Add(Me.cbBodegas)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.cbCatalogos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(426, 295, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(750, 676)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bTest
        '
        Me.bTest.Image = CType(resources.GetObject("bTest.Image"), System.Drawing.Image)
        Me.bTest.Location = New System.Drawing.Point(386, 60)
        Me.bTest.Name = "bTest"
        Me.bTest.Size = New System.Drawing.Size(121, 22)
        Me.bTest.StyleController = Me.LayoutControl1
        Me.bTest.TabIndex = 14
        Me.bTest.Text = "&Test de Conexión"
        '
        'bSalir
        '
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(645, 60)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(93, 22)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 14
        Me.bSalir.Text = "&Salir"
        '
        'bExportar
        '
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(511, 60)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(130, 22)
        Me.bExportar.StyleController = Me.LayoutControl1
        Me.bExportar.TabIndex = 14
        Me.bExportar.Text = "E&xportar a Movil ->"
        '
        'bBuscar
        '
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(12, 60)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(108, 22)
        Me.bBuscar.StyleController = Me.LayoutControl1
        Me.bBuscar.TabIndex = 13
        Me.bBuscar.Text = "&Buscar"
        '
        'cbBodegas
        '
        Me.cbBodegas.Location = New System.Drawing.Point(186, 36)
        Me.cbBodegas.Name = "cbBodegas"
        Me.cbBodegas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodegas.Properties.Appearance.Options.UseFont = True
        Me.cbBodegas.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodegas.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbBodegas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBodegas.Size = New System.Drawing.Size(552, 20)
        Me.cbBodegas.StyleController = Me.LayoutControl1
        Me.cbBodegas.TabIndex = 5
        Me.cbBodegas.Tag = ""
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 102)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(726, 562)
        Me.iGrid.TabIndex = 12
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista, Me.GridView2})
        '
        'iVista
        '
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsBehavior.Editable = False
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.iGrid
        Me.GridView2.Name = "GridView2"
        '
        'cbCatalogos
        '
        Me.cbCatalogos.Location = New System.Drawing.Point(186, 12)
        Me.cbCatalogos.Name = "cbCatalogos"
        Me.cbCatalogos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogos.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogos.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogos.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbCatalogos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogos.Size = New System.Drawing.Size(552, 20)
        Me.cbCatalogos.StyleController = Me.LayoutControl1
        Me.cbCatalogos.TabIndex = 4
        Me.cbCatalogos.Tag = "True"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(750, 676)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbCatalogos
        Me.LayoutControlItem1.CustomizationFormText = "Catalogo Exportar:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(730, 24)
        Me.LayoutControlItem1.Text = "Catalogo Exportar:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(171, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.iGrid
        Me.LayoutControlItem2.CustomizationFormText = "Vista Previa de los datos a Importar"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(730, 582)
        Me.LayoutControlItem2.Text = "Vista Previa de los datos a Importar"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(171, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbBodegas
        Me.LayoutControlItem3.CustomizationFormText = "Bodega:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(730, 24)
        Me.LayoutControlItem3.Text = "Bodega:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(171, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.bBuscar
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(112, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(112, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(112, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(112, 48)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(262, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bExportar
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(499, 48)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(134, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(134, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(134, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bSalir
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(633, 48)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(97, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(97, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(97, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bTest
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(374, 48)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(125, 26)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(125, 26)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(125, 26)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'frmExportarA_PDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 676)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmExportarA_PDA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar Datos a Movil PDA"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbBodegas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cbCatalogos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbBodegas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bTest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
