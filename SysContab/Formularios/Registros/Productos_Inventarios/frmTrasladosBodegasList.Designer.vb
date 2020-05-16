<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrasladosBodegasList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrasladosBodegasList))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bTrasladar = New DevExpress.XtraEditors.SimpleButton()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bDiseno = New DevExpress.XtraEditors.SimpleButton()
        Me.bBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.Desde = New DevExpress.XtraEditors.DateEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bTrasladar)
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.bExportar)
        Me.LayoutControl1.Controls.Add(Me.bDiseno)
        Me.LayoutControl1.Controls.Add(Me.bBorrar)
        Me.LayoutControl1.Controls.Add(Me.bImprimir)
        Me.LayoutControl1.Controls.Add(Me.bNuevo)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.Hasta)
        Me.LayoutControl1.Controls.Add(Me.Desde)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1138, 299, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(898, 323)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bTrasladar
        '
        Me.bTrasladar.Appearance.Options.UseTextOptions = True
        Me.bTrasladar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bTrasladar.Enabled = False
        Me.bTrasladar.ImageOptions.Image = CType(resources.GetObject("bTrasladar.ImageOptions.Image"), System.Drawing.Image)
        Me.bTrasladar.Location = New System.Drawing.Point(342, 273)
        Me.bTrasladar.Name = "bTrasladar"
        Me.bTrasladar.Size = New System.Drawing.Size(107, 38)
        Me.bTrasladar.StyleController = Me.LayoutControl1
        Me.bTrasladar.TabIndex = 9
        Me.bTrasladar.Text = "&Trasladar a Movimientos"
        '
        'bSalir
        '
        Me.bSalir.ImageOptions.Image = CType(resources.GetObject("bSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(781, 273)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(105, 38)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 10
        Me.bSalir.Text = "&Salir"
        '
        'bExportar
        '
        Me.bExportar.Enabled = False
        Me.bExportar.ImageOptions.Image = CType(resources.GetObject("bExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(673, 273)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(104, 38)
        Me.bExportar.StyleController = Me.LayoutControl1
        Me.bExportar.TabIndex = 10
        Me.bExportar.Text = "E&xportar"
        '
        'bDiseno
        '
        Me.bDiseno.Enabled = False
        Me.bDiseno.ImageOptions.Image = CType(resources.GetObject("bDiseno.ImageOptions.Image"), System.Drawing.Image)
        Me.bDiseno.Location = New System.Drawing.Point(564, 273)
        Me.bDiseno.Name = "bDiseno"
        Me.bDiseno.Size = New System.Drawing.Size(105, 38)
        Me.bDiseno.StyleController = Me.LayoutControl1
        Me.bDiseno.TabIndex = 9
        Me.bDiseno.Text = "&Diseño"
        '
        'bBorrar
        '
        Me.bBorrar.Enabled = False
        Me.bBorrar.ImageOptions.Image = CType(resources.GetObject("bBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.bBorrar.Location = New System.Drawing.Point(232, 273)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(106, 38)
        Me.bBorrar.StyleController = Me.LayoutControl1
        Me.bBorrar.TabIndex = 8
        Me.bBorrar.Text = "&Borrar"
        '
        'bImprimir
        '
        Me.bImprimir.Enabled = False
        Me.bImprimir.ImageOptions.Image = CType(resources.GetObject("bImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(122, 273)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(106, 38)
        Me.bImprimir.StyleController = Me.LayoutControl1
        Me.bImprimir.TabIndex = 8
        Me.bImprimir.Text = "&Imprimir"
        '
        'bNuevo
        '
        Me.bNuevo.Enabled = False
        Me.bNuevo.ImageOptions.Image = CType(resources.GetObject("bNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bNuevo.Location = New System.Drawing.Point(12, 273)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(106, 38)
        Me.bNuevo.StyleController = Me.LayoutControl1
        Me.bNuevo.TabIndex = 8
        Me.bNuevo.Text = "&Nuevo"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(175, 22)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(114, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "&Buscar"
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Location = New System.Drawing.Point(49, 36)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Size = New System.Drawing.Size(122, 20)
        Me.Hasta.StyleController = Me.LayoutControl1
        Me.Hasta.TabIndex = 6
        '
        'Desde
        '
        Me.Desde.EditValue = Nothing
        Me.Desde.Location = New System.Drawing.Point(49, 12)
        Me.Desde.Name = "Desde"
        Me.Desde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Properties.Appearance.Options.UseFont = True
        Me.Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Size = New System.Drawing.Size(122, 20)
        Me.Desde.StyleController = Me.LayoutControl1
        Me.Desde.TabIndex = 5
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 64)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(874, 205)
        Me.iGrid.TabIndex = 4
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
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem4, Me.EmptySpaceItem2, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem3, Me.LayoutControlItem11})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(898, 323)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(878, 209)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Desde
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(163, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(163, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(163, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Desde:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Hasta
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(163, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(163, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(163, 28)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Hasta:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(34, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(281, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(597, 52)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(163, 10)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(163, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(118, 10)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bNuevo
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 261)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bImprimir
        Me.LayoutControlItem6.Location = New System.Drawing.Point(110, 261)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bBorrar
        Me.LayoutControlItem7.Location = New System.Drawing.Point(220, 261)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.bDiseno
        Me.LayoutControlItem8.Location = New System.Drawing.Point(552, 261)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.bExportar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(661, 261)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.bSalir
        Me.LayoutControlItem10.Location = New System.Drawing.Point(769, 261)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(109, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(441, 261)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(111, 42)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.bTrasladar
        Me.LayoutControlItem11.Location = New System.Drawing.Point(330, 261)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'frmTrasladosBodegasList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 323)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmTrasladosBodegasList"
        Me.Text = "frmTrasladosBodegasList"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bDiseno As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bTrasladar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
End Class
