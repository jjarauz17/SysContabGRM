<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMetodosEnvio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMetodosEnvio))
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridView4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.frmConsignatariosConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmConsignatariosConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmConsignatariosConvertedLayout.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDatos
        '
        Me.dgDatos.Location = New System.Drawing.Point(12, 12)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(507, 165)
        Me.dgDatos.TabIndex = 3
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos, Me.GridView1, Me.BandedGridView1, Me.BandedGridView2, Me.BandedGridView4})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsBehavior.Editable = False
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgDatos
        Me.GridView1.GroupPanelText = "Arrastre aqui para agrupar Columna"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.BandedGridView1.GridControl = Me.dgDatos
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.Editable = False
        Me.BandedGridView1.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView1.OptionsView.ShowFooter = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        '
        'BandedGridView2
        '
        Me.BandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.BandedGridView2.GridControl = Me.dgDatos
        Me.BandedGridView2.Name = "BandedGridView2"
        Me.BandedGridView2.OptionsBehavior.Editable = False
        Me.BandedGridView2.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView2.OptionsView.ShowFooter = True
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "GridBand1"
        Me.GridBand2.MinWidth = 20
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.VisibleIndex = 0
        '
        'BandedGridView4
        '
        Me.BandedGridView4.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand4})
        Me.BandedGridView4.GridControl = Me.dgDatos
        Me.BandedGridView4.Name = "BandedGridView4"
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "GridBand4"
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.VisibleIndex = 0
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(308, 181)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(95, 38)
        Me.btnExportar.StyleController = Me.frmConsignatariosConvertedLayout
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.Text = "&Exportar"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Image = Global.SysContab.My.Resources.Resources._115
        Me.btnSalir.Location = New System.Drawing.Point(426, 181)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(93, 38)
        Me.btnSalir.StyleController = Me.frmConsignatariosConvertedLayout
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "&Salir"
        '
        'btnBorrar
        '
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(209, 181)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(95, 38)
        Me.btnBorrar.StyleController = Me.frmConsignatariosConvertedLayout
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "&Borrar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(111, 181)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(94, 38)
        Me.btnEditar.StyleController = Me.frmConsignatariosConvertedLayout
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "&Editar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(12, 181)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(95, 38)
        Me.btnNuevo.StyleController = Me.frmConsignatariosConvertedLayout
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "&Nuevo"
        '
        'frmConsignatariosConvertedLayout
        '
        Me.frmConsignatariosConvertedLayout.Controls.Add(Me.btnSalir)
        Me.frmConsignatariosConvertedLayout.Controls.Add(Me.btnExportar)
        Me.frmConsignatariosConvertedLayout.Controls.Add(Me.btnEditar)
        Me.frmConsignatariosConvertedLayout.Controls.Add(Me.btnBorrar)
        Me.frmConsignatariosConvertedLayout.Controls.Add(Me.btnNuevo)
        Me.frmConsignatariosConvertedLayout.Controls.Add(Me.dgDatos)
        Me.frmConsignatariosConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmConsignatariosConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmConsignatariosConvertedLayout.Name = "frmConsignatariosConvertedLayout"
        Me.frmConsignatariosConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(830, 92, 250, 350)
        Me.frmConsignatariosConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmConsignatariosConvertedLayout.Size = New System.Drawing.Size(531, 231)
        Me.frmConsignatariosConvertedLayout.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem1, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(531, 231)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgDatos
        Me.LayoutControlItem1.CustomizationFormText = "dgDatositem"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "dgDatositem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(511, 169)
        Me.LayoutControlItem1.Text = "dgDatositem"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnNuevo
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 169)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnEditar
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(99, 169)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnBorrar
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(197, 169)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnExportar
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(296, 169)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnSalir
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(414, 169)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(395, 169)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(19, 42)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmConsignatarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 231)
        Me.Controls.Add(Me.frmConsignatariosConvertedLayout)
        Me.Name = "frmConsignatarios"
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmConsignatariosConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmConsignatariosConvertedLayout.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridView4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents frmConsignatariosConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
End Class
