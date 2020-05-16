<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmoritizacionesSelecRpt
    Inherits DevExpress.XtraEditors.XtraForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAmoritizacionesSelecRpt))
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.frmAmoritizacionesSelecRptConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.cbAmorizaciones = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.rgOpciones = New DevExpress.XtraEditors.RadioGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        CType(Me.frmAmoritizacionesSelecRptConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmAmoritizacionesSelecRptConvertedLayout.SuspendLayout()
        CType(Me.cbAmorizaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgOpciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.ImageOptions.Image = CType(resources.GetObject("btnSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(524, 253)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(106, 38)
        Me.btnSalir.StyleController = Me.frmAmoritizacionesSelecRptConvertedLayout
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        '
        'frmAmoritizacionesSelecRptConvertedLayout
        '
        Me.frmAmoritizacionesSelecRptConvertedLayout.Controls.Add(Me.btnSalir)
        Me.frmAmoritizacionesSelecRptConvertedLayout.Controls.Add(Me.cbAmorizaciones)
        Me.frmAmoritizacionesSelecRptConvertedLayout.Controls.Add(Me.btnImprimir)
        Me.frmAmoritizacionesSelecRptConvertedLayout.Controls.Add(Me.rgOpciones)
        Me.frmAmoritizacionesSelecRptConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmAmoritizacionesSelecRptConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmAmoritizacionesSelecRptConvertedLayout.Name = "frmAmoritizacionesSelecRptConvertedLayout"
        Me.frmAmoritizacionesSelecRptConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(983, 183, 250, 350)
        Me.frmAmoritizacionesSelecRptConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmAmoritizacionesSelecRptConvertedLayout.Size = New System.Drawing.Size(642, 303)
        Me.frmAmoritizacionesSelecRptConvertedLayout.TabIndex = 3
        '
        'cbAmorizaciones
        '
        Me.cbAmorizaciones.Location = New System.Drawing.Point(92, 177)
        Me.cbAmorizaciones.Name = "cbAmorizaciones"
        Me.cbAmorizaciones.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAmorizaciones.Properties.Appearance.Options.UseFont = True
        Me.cbAmorizaciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAmorizaciones.Properties.View = Me.SearchLookUpEdit1View
        Me.cbAmorizaciones.Size = New System.Drawing.Size(526, 20)
        Me.cbAmorizaciones.StyleController = Me.frmAmoritizacionesSelecRptConvertedLayout
        Me.cbAmorizaciones.TabIndex = 25
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.ImageOptions.Image = CType(resources.GetObject("btnImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(411, 253)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(109, 38)
        Me.btnImprimir.StyleController = Me.frmAmoritizacionesSelecRptConvertedLayout
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "&Imprimir"
        '
        'rgOpciones
        '
        Me.rgOpciones.Location = New System.Drawing.Point(24, 42)
        Me.rgOpciones.Name = "rgOpciones"
        Me.rgOpciones.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgOpciones.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgOpciones.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.rgOpciones.Properties.Appearance.Options.UseBackColor = True
        Me.rgOpciones.Properties.Appearance.Options.UseFont = True
        Me.rgOpciones.Properties.Appearance.Options.UseForeColor = True
        Me.rgOpciones.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "INDIVIDUAL"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "PENDIENTES DE AMORTIZAR"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "REPORTE AUXILIAR")})
        Me.rgOpciones.Size = New System.Drawing.Size(594, 101)
        Me.rgOpciones.StyleController = Me.frmAmoritizacionesSelecRptConvertedLayout
        Me.rgOpciones.TabIndex = 0
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.EmptySpaceItem2, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(642, 303)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "SELECCIONE REPORTE"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "GroupControl1item"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(622, 201)
        Me.LayoutControlGroup2.Text = "SELECCIONE REPORTE"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.rgOpciones
        Me.LayoutControlItem3.CustomizationFormText = "rgOpcionesitem"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "rgOpcionesitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(598, 105)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 105)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(598, 30)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbAmorizaciones
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 135)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(598, 24)
        Me.LayoutControlItem4.Text = "Amortización:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(65, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 201)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(622, 40)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnImprimir
        Me.LayoutControlItem2.Location = New System.Drawing.Point(399, 241)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnSalir
        Me.LayoutControlItem5.Location = New System.Drawing.Point(512, 241)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 241)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(399, 42)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmAmoritizacionesSelecRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 303)
        Me.Controls.Add(Me.frmAmoritizacionesSelecRptConvertedLayout)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAmoritizacionesSelecRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Amortizaciones"
        CType(Me.frmAmoritizacionesSelecRptConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmAmoritizacionesSelecRptConvertedLayout.ResumeLayout(False)
        CType(Me.cbAmorizaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgOpciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rgOpciones As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents frmAmoritizacionesSelecRptConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents cbAmorizaciones As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
End Class
