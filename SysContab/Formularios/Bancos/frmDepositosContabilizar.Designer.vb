<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepositosContabilizar
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
        Me.txtComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.gridDatos = New DevExpress.XtraGrid.GridControl()
        Me.vComprobante = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.vCat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtDebito = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtCredito = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTasa = New DevExpress.XtraEditors.TextEdit()
        Me.cbTipoComp = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtComentarios
        '
        Me.txtComentarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentarios.Location = New System.Drawing.Point(139, 70)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtComentarios.Properties.Appearance.Options.UseFont = True
        Me.txtComentarios.Properties.Appearance.Options.UseForeColor = True
        Me.txtComentarios.Size = New System.Drawing.Size(719, 61)
        Me.txtComentarios.TabIndex = 3
        '
        'gridDatos
        '
        Me.gridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatos.Location = New System.Drawing.Point(9, 153)
        Me.gridDatos.MainView = Me.vComprobante
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCatalogo, Me.txtDebito, Me.txtCredito})
        Me.gridDatos.Size = New System.Drawing.Size(863, 297)
        Me.gridDatos.TabIndex = 1
        Me.gridDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vComprobante})
        '
        'vComprobante
        '
        Me.vComprobante.GridControl = Me.gridDatos
        Me.vComprobante.Name = "vComprobante"
        Me.vComprobante.OptionsCustomization.AllowColumnMoving = False
        Me.vComprobante.OptionsCustomization.AllowFilter = False
        Me.vComprobante.OptionsCustomization.AllowGroup = False
        Me.vComprobante.OptionsCustomization.AllowRowSizing = True
        Me.vComprobante.OptionsCustomization.AllowSort = False
        Me.vComprobante.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vComprobante.OptionsView.ShowFooter = True
        Me.vComprobante.OptionsView.ShowGroupPanel = False
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.NullText = "*** Nueva Cuenta ***"
        Me.cbCatalogo.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbCatalogo.View = Me.vCat
        '
        'vCat
        '
        Me.vCat.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCat.Name = "vCat"
        Me.vCat.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCat.OptionsView.ShowAutoFilterRow = True
        Me.vCat.OptionsView.ShowGroupPanel = False
        '
        'txtDebito
        '
        Me.txtDebito.AutoHeight = False
        Me.txtDebito.Mask.EditMask = "n2"
        Me.txtDebito.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDebito.Mask.UseMaskAsDisplayFormat = True
        Me.txtDebito.Name = "txtDebito"
        '
        'txtCredito
        '
        Me.txtCredito.AutoHeight = False
        Me.txtCredito.Mask.EditMask = "n2"
        Me.txtCredito.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCredito.Mask.UseMaskAsDisplayFormat = True
        Me.txtCredito.Name = "txtCredito"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtTasa)
        Me.PanelControl1.Controls.Add(Me.txtComentarios)
        Me.PanelControl1.Controls.Add(Me.cbTipoComp)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.Fecha)
        Me.PanelControl1.Controls.Add(Me.btnGuardar)
        Me.PanelControl1.Controls.Add(Me.btnQuit)
        Me.PanelControl1.Location = New System.Drawing.Point(9, 5)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(863, 142)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(73, 91)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl5.TabIndex = 71
        Me.LabelControl5.Text = "Concepto:"
        '
        'txtTasa
        '
        Me.txtTasa.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtTasa.Location = New System.Drawing.Point(486, 42)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTasa.Properties.Appearance.Options.UseFont = True
        Me.txtTasa.Properties.Appearance.Options.UseForeColor = True
        Me.txtTasa.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.txtTasa.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTasa.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtTasa.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtTasa.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtTasa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTasa.Properties.Mask.EditMask = "n4"
        Me.txtTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTasa.Properties.ReadOnly = True
        Me.txtTasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTasa.Size = New System.Drawing.Size(88, 22)
        Me.txtTasa.TabIndex = 1
        Me.txtTasa.Visible = False
        '
        'cbTipoComp
        '
        Me.cbTipoComp.Location = New System.Drawing.Point(139, 42)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoComp.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbTipoComp.Properties.Appearance.Options.UseFont = True
        Me.cbTipoComp.Properties.Appearance.Options.UseForeColor = True
        Me.cbTipoComp.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.cbTipoComp.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoComp.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.cbTipoComp.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cbTipoComp.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cbTipoComp.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cbTipoComp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoComp.Properties.ShowFooter = False
        Me.cbTipoComp.Properties.ShowHeader = False
        Me.cbTipoComp.Size = New System.Drawing.Size(277, 22)
        Me.cbTipoComp.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(5, 51)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(124, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Tipo de Comprobante:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(422, 47)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "T/Cambio:"
        Me.LabelControl4.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(93, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Fecha:"
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(139, 18)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.Appearance.Options.UseForeColor = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Size = New System.Drawing.Size(119, 20)
        Me.Fecha.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_SaveFileLarge
        Me.btnGuardar.Location = New System.Drawing.Point(663, 29)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(97, 35)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "&Guardar"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Image = Global.SysContab.My.Resources.Resources.SalirFrm
        Me.btnQuit.Location = New System.Drawing.Point(766, 29)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(92, 35)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "&Salir"
        '
        'frmDepositosContabilizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.gridDatos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDepositosContabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "*** CONTABILIZAR HOJA DE DEPOSITO ***"
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents gridDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vComprobante As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents vCat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDebito As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCredito As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbTipoComp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
