<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleMovimientosCxP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleMovimientosCxP))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.cbRubro = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.Salir = New DevExpress.XtraEditors.SimpleButton()
        Me.Desde = New DevExpress.XtraEditors.DateEdit()
        Me.Exportar = New DevExpress.XtraEditors.SimpleButton()
        Me.Imprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRubro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.cbRubro)
        Me.LayoutControl1.Controls.Add(Me.btnBuscar)
        Me.LayoutControl1.Controls.Add(Me.Hasta)
        Me.LayoutControl1.Controls.Add(Me.Salir)
        Me.LayoutControl1.Controls.Add(Me.Desde)
        Me.LayoutControl1.Controls.Add(Me.Exportar)
        Me.LayoutControl1.Controls.Add(Me.Imprimir)
        Me.LayoutControl1.Controls.Add(Me.dgDatos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1066, 235, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(894, 342)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 292)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Mas Datos"
        Me.CheckEdit1.Size = New System.Drawing.Size(599, 19)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 12
        '
        'cbRubro
        '
        Me.cbRubro.Location = New System.Drawing.Point(107, 64)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbRubro.Size = New System.Drawing.Size(775, 20)
        Me.cbRubro.StyleController = Me.LayoutControl1
        Me.cbRubro.TabIndex = 11
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageOptions.Image = CType(resources.GetObject("btnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(258, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 38)
        Me.btnBuscar.StyleController = Me.LayoutControl1
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "&Buscar"
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Location = New System.Drawing.Point(107, 38)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Hasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Hasta.Size = New System.Drawing.Size(147, 20)
        Me.Hasta.StyleController = Me.LayoutControl1
        Me.Hasta.TabIndex = 6
        '
        'Salir
        '
        Me.Salir.ImageOptions.Image = CType(resources.GetObject("Salir.ImageOptions.Image"), System.Drawing.Image)
        Me.Salir.Location = New System.Drawing.Point(809, 292)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(73, 38)
        Me.Salir.StyleController = Me.LayoutControl1
        Me.Salir.TabIndex = 10
        Me.Salir.Text = "&Salir"
        '
        'Desde
        '
        Me.Desde.EditValue = Nothing
        Me.Desde.Location = New System.Drawing.Point(107, 12)
        Me.Desde.Name = "Desde"
        Me.Desde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Properties.Appearance.Options.UseFont = True
        Me.Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Desde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Desde.Size = New System.Drawing.Size(147, 20)
        Me.Desde.StyleController = Me.LayoutControl1
        Me.Desde.TabIndex = 5
        '
        'Exportar
        '
        Me.Exportar.ImageOptions.Image = CType(resources.GetObject("Exportar.ImageOptions.Image"), System.Drawing.Image)
        Me.Exportar.Location = New System.Drawing.Point(710, 292)
        Me.Exportar.Name = "Exportar"
        Me.Exportar.Size = New System.Drawing.Size(95, 38)
        Me.Exportar.StyleController = Me.LayoutControl1
        Me.Exportar.TabIndex = 9
        Me.Exportar.Text = "&Exportar"
        '
        'Imprimir
        '
        Me.Imprimir.ImageOptions.Image = CType(resources.GetObject("Imprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.Imprimir.Location = New System.Drawing.Point(615, 292)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(91, 38)
        Me.Imprimir.StyleController = Me.LayoutControl1
        Me.Imprimir.TabIndex = 8
        Me.Imprimir.Text = "&Imprimir"
        '
        'dgDatos
        '
        Me.dgDatos.Location = New System.Drawing.Point(12, 88)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(870, 200)
        Me.dgDatos.TabIndex = 6
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.GroupPanelText = "Arrastre Columna para Agrugar Datos"
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsBehavior.Editable = False
        Me.vDatos.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowChildrenInGroupPanel = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupedColumns = True
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.LayoutControlItem9})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(894, 342)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dgDatos
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(874, 204)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Imprimir
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(603, 280)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Exportar
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(698, 280)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Salir
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(797, 280)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(77, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(77, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(77, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Desde
        Me.LayoutControlItem1.CustomizationFormText = "Desde:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(246, 26)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(246, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(246, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Desde:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Hasta
        Me.LayoutControlItem2.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(246, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(246, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(246, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Hasta:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbRubro
        Me.LayoutControlItem5.CustomizationFormText = "Tipo de Proveedor:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(874, 24)
        Me.LayoutControlItem5.Text = "Tipo de Proveedor:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(92, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 303)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(603, 19)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnBuscar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(246, 10)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(246, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(628, 10)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(344, 10)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(530, 42)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.CheckEdit1
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 280)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(603, 23)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'frmDetalleMovimientosCxP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 342)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDetalleMovimientosCxP"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRubro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Salir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Exportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Imprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbRubro As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
End Class
