<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeExoneraciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformeExoneraciones))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdContabilizar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEntradaBodegaList = New DevExpress.XtraEditors.SimpleButton()
        Me.fHasta = New DevExpress.XtraEditors.DateEdit()
        Me.cmdEntradaBodega = New DevExpress.XtraEditors.SimpleButton()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.fDesde = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.fHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bExportar)
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.cmdContabilizar)
        Me.LayoutControl1.Controls.Add(Me.cmdEntradaBodegaList)
        Me.LayoutControl1.Controls.Add(Me.fHasta)
        Me.LayoutControl1.Controls.Add(Me.cmdEntradaBodega)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.fDesde)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(831, 161, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(745, 590)
        Me.LayoutControl1.TabIndex = 168
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bExportar
        '
        Me.bExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(530, 540)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(95, 38)
        Me.bExportar.StyleController = Me.LayoutControl1
        Me.bExportar.TabIndex = 170
        Me.bExportar.Text = "&Exportar"
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(629, 540)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(104, 38)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 169
        Me.bSalir.Text = "&Salir"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(176, 22)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(94, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 169
        Me.SimpleButton1.Text = "&Buscar"
        '
        'cmdContabilizar
        '
        Me.cmdContabilizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdContabilizar.Location = New System.Drawing.Point(12, 343)
        Me.cmdContabilizar.Name = "cmdContabilizar"
        Me.cmdContabilizar.Size = New System.Drawing.Size(503, 22)
        Me.cmdContabilizar.StyleController = Me.LayoutControl1
        Me.cmdContabilizar.TabIndex = 163
        Me.cmdContabilizar.Text = "&Contabilizar"
        Me.cmdContabilizar.Visible = False
        '
        'cmdEntradaBodegaList
        '
        Me.cmdEntradaBodegaList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEntradaBodegaList.Appearance.Options.UseTextOptions = True
        Me.cmdEntradaBodegaList.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdEntradaBodegaList.Location = New System.Drawing.Point(12, 343)
        Me.cmdEntradaBodegaList.Name = "cmdEntradaBodegaList"
        Me.cmdEntradaBodegaList.Size = New System.Drawing.Size(387, 22)
        Me.cmdEntradaBodegaList.StyleController = Me.LayoutControl1
        Me.cmdEntradaBodegaList.TabIndex = 162
        Me.cmdEntradaBodegaList.Text = "Ver Entradas a &Bodegas"
        Me.cmdEntradaBodegaList.Visible = False
        '
        'fHasta
        '
        Me.fHasta.EditValue = Nothing
        Me.fHasta.Location = New System.Drawing.Point(49, 36)
        Me.fHasta.Name = "fHasta"
        Me.fHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fHasta.Properties.Appearance.Options.UseFont = True
        Me.fHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.fHasta.Size = New System.Drawing.Size(123, 20)
        Me.fHasta.StyleController = Me.LayoutControl1
        Me.fHasta.TabIndex = 168
        '
        'cmdEntradaBodega
        '
        Me.cmdEntradaBodega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEntradaBodega.Appearance.Options.UseTextOptions = True
        Me.cmdEntradaBodega.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdEntradaBodega.Location = New System.Drawing.Point(12, 343)
        Me.cmdEntradaBodega.Name = "cmdEntradaBodega"
        Me.cmdEntradaBodega.Size = New System.Drawing.Size(250, 22)
        Me.cmdEntradaBodega.StyleController = Me.LayoutControl1
        Me.cmdEntradaBodega.TabIndex = 161
        Me.cmdEntradaBodega.Text = "&Entrada a Bodega"
        Me.cmdEntradaBodega.Visible = False
        '
        'iGrid
        '
        Me.iGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iGrid.Location = New System.Drawing.Point(12, 64)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(721, 472)
        Me.iGrid.TabIndex = 164
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
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
        'fDesde
        '
        Me.fDesde.EditValue = Nothing
        Me.fDesde.Location = New System.Drawing.Point(49, 12)
        Me.fDesde.Name = "fDesde"
        Me.fDesde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fDesde.Properties.Appearance.Options.UseFont = True
        Me.fDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.fDesde.Size = New System.Drawing.Size(123, 20)
        Me.fDesde.StyleController = Me.LayoutControl1
        Me.fDesde.TabIndex = 4
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdEntradaBodega
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 331)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(254, 26)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdEntradaBodegaList
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 331)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(391, 26)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdContabilizar
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 331)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(507, 26)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.LayoutControlItem11, Me.EmptySpaceItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(745, 590)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.fDesde
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(164, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(164, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(164, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Desde:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.fHasta
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(164, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(164, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(164, 28)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Hasta:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.iGrid
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(725, 476)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(262, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(463, 52)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SimpleButton1
        Me.LayoutControlItem11.Location = New System.Drawing.Point(164, 10)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(164, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(98, 10)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.bSalir
        Me.LayoutControlItem4.Location = New System.Drawing.Point(617, 528)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bExportar
        Me.LayoutControlItem5.Location = New System.Drawing.Point(518, 528)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 528)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(518, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmInformeExoneraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 590)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmInformeExoneraciones"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.fHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdContabilizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEntradaBodegaList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdEntradaBodega As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents fDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
