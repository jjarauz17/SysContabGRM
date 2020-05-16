<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiqBankRates
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.tbName = New DevExpress.XtraEditors.TextEdit
        Me.cbProveedor = New DevExpress.XtraEditors.LookUpEdit
        Me.cbCuenta = New DevExpress.XtraEditors.LookUpEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LiqGastoID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GastoNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ProveedorID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Cuenta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Monto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Liquidacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Prestamos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rbTipo = New DevExpress.XtraEditors.RadioGroup
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.tbMonto = New DevExpress.XtraEditors.TextEdit
        CType(Me.tbName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nombre"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Proveedor"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(340, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Cuenta"
        '
        'tbName
        '
        Me.tbName.Enabled = False
        Me.tbName.EnterMoveNextControl = True
        Me.tbName.Location = New System.Drawing.Point(84, 12)
        Me.tbName.Name = "tbName"
        Me.tbName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tbName.Properties.Appearance.Options.UseFont = True
        Me.tbName.Size = New System.Drawing.Size(238, 21)
        Me.tbName.TabIndex = 0
        '
        'cbProveedor
        '
        Me.cbProveedor.Enabled = False
        Me.cbProveedor.EnterMoveNextControl = True
        Me.cbProveedor.Location = New System.Drawing.Point(84, 38)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbProveedor.Properties.Appearance.Options.UseFont = True
        Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO", "CODIGO"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "Nombre")})
        Me.cbProveedor.Properties.NullText = ""
        Me.cbProveedor.Size = New System.Drawing.Size(238, 21)
        Me.cbProveedor.TabIndex = 2
        '
        'cbCuenta
        '
        Me.cbCuenta.Enabled = False
        Me.cbCuenta.EnterMoveNextControl = True
        Me.cbCuenta.Location = New System.Drawing.Point(381, 38)
        Me.cbCuenta.Name = "cbCuenta"
        Me.cbCuenta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbCuenta.Properties.Appearance.Options.UseFont = True
        Me.cbCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCuenta.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cuenta", "Cuenta")})
        Me.cbCuenta.Properties.NullText = ""
        Me.cbCuenta.Size = New System.Drawing.Size(238, 21)
        Me.cbCuenta.TabIndex = 3
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 98)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(800, 368)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.LiqGastoID, Me.GastoNombre, Me.ProveedorID, Me.NOMBRE, Me.Cuenta, Me.Monto, Me.Liquidacion, Me.Prestamos})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LiqGastoID
        '
        Me.LiqGastoID.Caption = "LiqGastoID"
        Me.LiqGastoID.FieldName = "LiqGastoID"
        Me.LiqGastoID.Name = "LiqGastoID"
        '
        'GastoNombre
        '
        Me.GastoNombre.Caption = "Nombre"
        Me.GastoNombre.FieldName = "GastoNombre"
        Me.GastoNombre.Name = "GastoNombre"
        Me.GastoNombre.Visible = True
        Me.GastoNombre.VisibleIndex = 0
        Me.GastoNombre.Width = 163
        '
        'ProveedorID
        '
        Me.ProveedorID.Caption = "ProveedorID"
        Me.ProveedorID.FieldName = "ProveedorID"
        Me.ProveedorID.Name = "ProveedorID"
        '
        'NOMBRE
        '
        Me.NOMBRE.Caption = "Proveedor"
        Me.NOMBRE.FieldName = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Visible = True
        Me.NOMBRE.VisibleIndex = 1
        Me.NOMBRE.Width = 258
        '
        'Cuenta
        '
        Me.Cuenta.Caption = "Cuenta"
        Me.Cuenta.FieldName = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Visible = True
        Me.Cuenta.VisibleIndex = 2
        Me.Cuenta.Width = 127
        '
        'Monto
        '
        Me.Monto.AppearanceCell.Options.UseTextOptions = True
        Me.Monto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Monto.Caption = "Monto"
        Me.Monto.DisplayFormat.FormatString = "n2"
        Me.Monto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Monto.FieldName = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.Visible = True
        Me.Monto.VisibleIndex = 3
        Me.Monto.Width = 65
        '
        'Liquidacion
        '
        Me.Liquidacion.Caption = "Liquidación"
        Me.Liquidacion.FieldName = "Liquidacion"
        Me.Liquidacion.Name = "Liquidacion"
        Me.Liquidacion.Visible = True
        Me.Liquidacion.VisibleIndex = 4
        Me.Liquidacion.Width = 73
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AccessibleName = "Liquidacion"
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'Prestamos
        '
        Me.Prestamos.Caption = "Préstamos"
        Me.Prestamos.FieldName = "Prestamos"
        Me.Prestamos.Name = "Prestamos"
        Me.Prestamos.Visible = True
        Me.Prestamos.VisibleIndex = 5
        Me.Prestamos.Width = 93
        '
        'rbTipo
        '
        Me.rbTipo.EditValue = True
        Me.rbTipo.Enabled = False
        Me.rbTipo.Location = New System.Drawing.Point(381, 11)
        Me.rbTipo.Name = "rbTipo"
        Me.rbTipo.Properties.Columns = 2
        Me.rbTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Liquidaciones"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Préstamos")})
        Me.rbTipo.Size = New System.Drawing.Size(192, 21)
        Me.rbTipo.TabIndex = 1
        '
        'cmdNew
        '
        Me.cmdNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNew.Location = New System.Drawing.Point(737, 5)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 23)
        Me.cmdNew.TabIndex = 6
        Me.cmdNew.Text = "&Nuevo"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Location = New System.Drawing.Point(737, 60)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 8
        Me.cmdExit.Text = "&Salir"
        '
        'cmdEdit
        '
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Location = New System.Drawing.Point(737, 31)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 7
        Me.cmdEdit.Text = "&Editar"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Monto C$"
        '
        'tbMonto
        '
        Me.tbMonto.EditValue = "0.00"
        Me.tbMonto.Enabled = False
        Me.tbMonto.EnterMoveNextControl = True
        Me.tbMonto.Location = New System.Drawing.Point(84, 64)
        Me.tbMonto.Name = "tbMonto"
        Me.tbMonto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tbMonto.Properties.Appearance.Options.UseFont = True
        Me.tbMonto.Properties.Mask.EditMask = "N2"
        Me.tbMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbMonto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbMonto.Size = New System.Drawing.Size(69, 21)
        Me.tbMonto.TabIndex = 4
        '
        'frmLiqBankRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 478)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.rbTipo)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.cbCuenta)
        Me.Controls.Add(Me.cbProveedor)
        Me.Controls.Add(Me.tbMonto)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmLiqBankRates"
        Me.Text = "Listado de Tarifas"
        CType(Me.tbName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbProveedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rbTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LiqGastoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GastoNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProveedorID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Monto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Liquidacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Prestamos As DevExpress.XtraGrid.Columns.GridColumn
End Class
