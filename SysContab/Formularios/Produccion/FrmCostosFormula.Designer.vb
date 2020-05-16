<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCostosFormula
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCostosFormula))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.Datos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MonedaReporitory = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CostoRepoitory = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CostoValorRepository = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.FrmCostosFormulaConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.BtnGuardarDatos = New DevExpress.XtraNavBar.NavBarItem()
        Me.CmdEliminarFila = New DevExpress.XtraNavBar.NavBarItem()
        Me.CmdCerrar = New DevExpress.XtraNavBar.NavBarItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonedaReporitory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostoRepoitory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostoValorRepository, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmCostosFormulaConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmCostosFormulaConvertedLayout.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Datos
        '
        Me.Datos.Location = New System.Drawing.Point(158, 12)
        Me.Datos.MainView = Me.GridView1
        Me.Datos.Name = "Datos"
        Me.Datos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.MonedaReporitory, Me.CostoRepoitory, Me.CostoValorRepository})
        Me.Datos.Size = New System.Drawing.Size(597, 445)
        Me.Datos.TabIndex = 2
        Me.Datos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Datos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'MonedaReporitory
        '
        Me.MonedaReporitory.AutoHeight = False
        Me.MonedaReporitory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MonedaReporitory.Name = "MonedaReporitory"
        Me.MonedaReporitory.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'CostoRepoitory
        '
        Me.CostoRepoitory.AutoHeight = False
        Me.CostoRepoitory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("CostoRepoitory.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.CostoRepoitory.Name = "CostoRepoitory"
        Me.CostoRepoitory.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'CostoValorRepository
        '
        Me.CostoValorRepository.AutoHeight = False
        Me.CostoValorRepository.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CostoValorRepository.Name = "CostoValorRepository"
        Me.CostoValorRepository.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'FrmCostosFormulaConvertedLayout
        '
        Me.FrmCostosFormulaConvertedLayout.Controls.Add(Me.NavBarControl1)
        Me.FrmCostosFormulaConvertedLayout.Controls.Add(Me.Datos)
        Me.FrmCostosFormulaConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmCostosFormulaConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.FrmCostosFormulaConvertedLayout.Name = "FrmCostosFormulaConvertedLayout"
        Me.FrmCostosFormulaConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1854, 136, 250, 350)
        Me.FrmCostosFormulaConvertedLayout.Root = Me.LayoutControlGroup1
        Me.FrmCostosFormulaConvertedLayout.Size = New System.Drawing.Size(767, 469)
        Me.FrmCostosFormulaConvertedLayout.TabIndex = 6
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.BtnGuardarDatos, Me.CmdEliminarFila, Me.CmdCerrar})
        Me.NavBarControl1.Location = New System.Drawing.Point(12, 12)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 142
        Me.NavBarControl1.Size = New System.Drawing.Size(142, 445)
        Me.NavBarControl1.TabIndex = 4
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = ""
        Me.NavBarGroup1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.BtnGuardarDatos), New DevExpress.XtraNavBar.NavBarItemLink(Me.CmdEliminarFila), New DevExpress.XtraNavBar.NavBarItemLink(Me.CmdCerrar)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        Me.NavBarGroup1.NavigationPaneVisible = False
        '
        'BtnGuardarDatos
        '
        Me.BtnGuardarDatos.Caption = "Guardar Datos"
        Me.BtnGuardarDatos.Name = "BtnGuardarDatos"
        '
        'CmdEliminarFila
        '
        Me.CmdEliminarFila.Caption = "Eliminar Registro"
        Me.CmdEliminarFila.Name = "CmdEliminarFila"
        '
        'CmdCerrar
        '
        Me.CmdCerrar.Caption = "Cerrar Ventana"
        Me.CmdCerrar.Name = "CmdCerrar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(767, 469)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Datos
        Me.LayoutControlItem2.CustomizationFormText = "Datositem"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(146, 0)
        Me.LayoutControlItem2.Name = "Datositem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(601, 449)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.NavBarControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(146, 0)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(146, 14)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(146, 449)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'FrmCostosFormula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 469)
        Me.Controls.Add(Me.FrmCostosFormulaConvertedLayout)
        Me.Name = "FrmCostosFormula"
        Me.Text = "FrmCostosFormula"
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonedaReporitory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostoRepoitory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostoValorRepository, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmCostosFormulaConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmCostosFormulaConvertedLayout.ResumeLayout(False)
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Datos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents FrmCostosFormulaConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents BtnGuardarDatos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents CmdEliminarFila As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents CmdCerrar As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents MonedaReporitory As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CostoRepoitory As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CostoValorRepository As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
