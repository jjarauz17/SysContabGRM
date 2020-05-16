<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnviarEmailCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnviarEmailCliente))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Admin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.FechaCorte = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaCorte.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaCorte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.lblTitulo)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.FechaCorte)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(849, 169, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(487, 540)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 82)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(463, 379)
        Me.iGrid.TabIndex = 16
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iVista.Appearance.HeaderPanel.Options.UseFont = True
        Me.iVista.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.iVista.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iVista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.Admin})
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.NewItemRowText = "Agregar Nuevo Correo!"
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "IdCorreo"
        Me.GridColumn1.FieldName = "IdCorreo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Correo"
        Me.GridColumn2.FieldName = "Correo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 362
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Enviar"
        Me.GridColumn3.FieldName = "Enviar"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 83
        '
        'Admin
        '
        Me.Admin.Caption = "Admin"
        Me.Admin.FieldName = "Admin"
        Me.Admin.Name = "Admin"
        Me.Admin.OptionsColumn.AllowEdit = False
        Me.Admin.OptionsColumn.AllowFocus = False
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(133, 41)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Size = New System.Drawing.Size(342, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 9
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Appearance.Options.UseForeColor = True
        Me.lblTitulo.Appearance.Options.UseTextOptions = True
        Me.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(463, 1)
        Me.lblTitulo.StyleController = Me.LayoutControl1
        Me.lblTitulo.TabIndex = 8
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(371, 490)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(104, 38)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 7
        Me.SimpleButton3.Text = "&Salir"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Options.UseTextOptions = True
        Me.SimpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(125, 490)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(109, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "&Enviar por E-Mail"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 490)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(109, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "&Vista Previa"
        '
        'FechaCorte
        '
        Me.FechaCorte.EditValue = Nothing
        Me.FechaCorte.Location = New System.Drawing.Point(133, 17)
        Me.FechaCorte.Name = "FechaCorte"
        Me.FechaCorte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaCorte.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaCorte.Size = New System.Drawing.Size(100, 20)
        Me.FechaCorte.StyleController = Me.LayoutControl1
        Me.FechaCorte.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(487, 540)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.FechaCorte
        Me.LayoutControlItem1.CustomizationFormText = "Fecha de Corte:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 5)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(225, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(225, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(225, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Fecha de Corte:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 478)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton2
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(113, 478)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton3
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(359, 478)
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
        Me.LayoutControlItem5.Control = Me.lblTitulo
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(467, 5)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(226, 478)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(133, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(225, 5)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(242, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbMoneda
        Me.LayoutControlItem6.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 29)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(467, 24)
        Me.LayoutControlItem6.Text = "Moneda:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(118, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem7.Control = Me.iGrid
        Me.LayoutControlItem7.CustomizationFormText = "Correo con copia a:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 53)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(467, 400)
        Me.LayoutControlItem7.Text = "Correo con copia a:"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(118, 14)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 453)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(467, 25)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmEnviarEmailCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.LayoutControl1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEnviarEmailCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de Cuenta de Cliente"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaCorte.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaCorte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents FechaCorte As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Admin As DevExpress.XtraGrid.Columns.GridColumn
End Class
