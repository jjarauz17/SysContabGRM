<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventarioList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventarioList))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.cAplicado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bFormato = New DevExpress.XtraEditors.SimpleButton()
        Me.bAplicar = New DevExpress.XtraEditors.SimpleButton()
        Me.bEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cAplicado
        '
        Me.cAplicado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cAplicado.AppearanceHeader.Options.UseFont = True
        Me.cAplicado.AppearanceHeader.Options.UseTextOptions = True
        Me.cAplicado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cAplicado.Caption = "Aplicado"
        Me.cAplicado.FieldName = "Autorizado"
        Me.cAplicado.Name = "cAplicado"
        Me.cAplicado.Visible = True
        Me.cAplicado.VisibleIndex = 4
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bFormato)
        Me.LayoutControl1.Controls.Add(Me.bAplicar)
        Me.LayoutControl1.Controls.Add(Me.bEliminar)
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.bNuevo)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.bModificar)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(718, 435)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bFormato
        '
        Me.bFormato.Appearance.Options.UseTextOptions = True
        Me.bFormato.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bFormato.Enabled = False
        Me.bFormato.ImageOptions.Image = CType(resources.GetObject("bFormato.ImageOptions.Image"), System.Drawing.Image)
        Me.bFormato.Location = New System.Drawing.Point(120, 385)
        Me.bFormato.Name = "bFormato"
        Me.bFormato.Size = New System.Drawing.Size(93, 38)
        Me.bFormato.StyleController = Me.LayoutControl1
        Me.bFormato.TabIndex = 13
        Me.bFormato.Text = "&Formato Impreso"
        '
        'bAplicar
        '
        Me.bAplicar.Appearance.Options.UseTextOptions = True
        Me.bAplicar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bAplicar.Enabled = False
        Me.bAplicar.ImageOptions.Image = CType(resources.GetObject("bAplicar.ImageOptions.Image"), System.Drawing.Image)
        Me.bAplicar.Location = New System.Drawing.Point(12, 385)
        Me.bAplicar.Name = "bAplicar"
        Me.bAplicar.Size = New System.Drawing.Size(104, 38)
        Me.bAplicar.StyleController = Me.LayoutControl1
        Me.bAplicar.TabIndex = 6
        Me.bAplicar.Text = "&Aplicar Inventario"
        '
        'bEliminar
        '
        Me.bEliminar.Enabled = False
        Me.bEliminar.ImageOptions.Image = CType(resources.GetObject("bEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.bEliminar.Location = New System.Drawing.Point(521, 385)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(95, 38)
        Me.bEliminar.StyleController = Me.LayoutControl1
        Me.bEliminar.TabIndex = 6
        Me.bEliminar.Text = "&Eliminar"
        '
        'bSalir
        '
        Me.bSalir.ImageOptions.Image = CType(resources.GetObject("bSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(620, 385)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(86, 38)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 8
        Me.bSalir.Text = "&Salir"
        '
        'bNuevo
        '
        Me.bNuevo.Enabled = False
        Me.bNuevo.ImageOptions.Image = CType(resources.GetObject("bNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bNuevo.Location = New System.Drawing.Point(320, 385)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(91, 38)
        Me.bNuevo.StyleController = Me.LayoutControl1
        Me.bNuevo.TabIndex = 5
        Me.bNuevo.Text = "&Nuevo"
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 12)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(694, 369)
        Me.iGrid.TabIndex = 4
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.cAplicado, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.cAplicado
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = True
        StyleFormatCondition1.Value2 = True
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Salmon
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.cAplicado
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = False
        StyleFormatCondition2.Value2 = False
        Me.iVista.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsBehavior.Editable = False
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "IdInventario"
        Me.GridColumn1.FieldName = "IdInventario"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Bodega"
        Me.GridColumn3.FieldName = "Bodega"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Realizado por"
        Me.GridColumn4.FieldName = "Realizado"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Tipo"
        Me.GridColumn6.FieldName = "Tipo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "codigo_bodega"
        Me.GridColumn7.FieldName = "codigo_bodega"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Origen"
        Me.GridColumn8.FieldName = "Origen"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Numero"
        Me.GridColumn9.FieldName = "Numero"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.AllowFocus = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        '
        'bModificar
        '
        Me.bModificar.Enabled = False
        Me.bModificar.ImageOptions.Image = CType(resources.GetObject("bModificar.ImageOptions.Image"), System.Drawing.Image)
        Me.bModificar.Location = New System.Drawing.Point(415, 385)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(102, 38)
        Me.bModificar.StyleController = Me.LayoutControl1
        Me.bModificar.TabIndex = 6
        Me.bModificar.Text = "&Modificar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(718, 435)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(698, 373)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.bNuevo
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(308, 373)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(95, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.bModificar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(403, 373)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bSalir
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(608, 373)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(90, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(205, 373)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(103, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bEliminar
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(509, 373)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bAplicar
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 373)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.bFormato
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(108, 373)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'FrmInventarioList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 435)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "FrmInventarioList"
        Me.Text = "Lista de Inventarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cAplicado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bAplicar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bFormato As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
End Class
