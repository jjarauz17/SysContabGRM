Public Class frmAgregarClienteQuick
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkRetenedorAlcaldia As System.Windows.Forms.CheckBox
    Friend WithEvents chkRetenedor As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoLetra As System.Windows.Forms.TextBox
    Friend WithEvents cbCuentas As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkExcento As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbCuentas = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtCodigoLetra = New System.Windows.Forms.TextBox
        Me.chkRetenedorAlcaldia = New System.Windows.Forms.CheckBox
        Me.chkRetenedor = New System.Windows.Forms.CheckBox
        Me.chkExcento = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRuc = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAddAll = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3.SuspendLayout()
        CType(Me.cbCuentas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cbCuentas)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtCodigoLetra)
        Me.GroupBox3.Controls.Add(Me.chkRetenedorAlcaldia)
        Me.GroupBox3.Controls.Add(Me.chkRetenedor)
        Me.GroupBox3.Controls.Add(Me.chkExcento)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtRuc)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.txtCodigo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtNombre)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(489, 179)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'cbCuentas
        '
        Me.cbCuentas.Location = New System.Drawing.Point(96, 94)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentas.Properties.Appearance.Options.UseFont = True
        Me.cbCuentas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCuentas.Properties.DisplayMember = "Display"
        Me.cbCuentas.Properties.NullText = ""
        Me.cbCuentas.Properties.PopupFormMinSize = New System.Drawing.Size(500, 0)
        Me.cbCuentas.Properties.ValueMember = "Cuenta"
        Me.cbCuentas.Properties.View = Me.GridLookUpEdit1View
        Me.cbCuentas.Size = New System.Drawing.Size(374, 20)
        Me.cbCuentas.TabIndex = 4
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cuenta"
        Me.GridColumn1.FieldName = "Cuenta"
        Me.GridColumn1.MinWidth = 150
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 150
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre"
        Me.GridColumn2.FieldName = "Nombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 231
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Display"
        Me.GridColumn3.FieldName = "Display"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(30, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 212
        Me.Label3.Text = "Cuenta:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(211, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 16)
        Me.Label21.TabIndex = 210
        Me.Label21.Text = "Código Letra:"
        '
        'txtCodigoLetra
        '
        Me.txtCodigoLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoLetra.Location = New System.Drawing.Point(318, 16)
        Me.txtCodigoLetra.MaxLength = 10
        Me.txtCodigoLetra.Name = "txtCodigoLetra"
        Me.txtCodigoLetra.Size = New System.Drawing.Size(152, 20)
        Me.txtCodigoLetra.TabIndex = 1
        '
        'chkRetenedorAlcaldia
        '
        Me.chkRetenedorAlcaldia.AutoSize = True
        Me.chkRetenedorAlcaldia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRetenedorAlcaldia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkRetenedorAlcaldia.Location = New System.Drawing.Point(288, 120)
        Me.chkRetenedorAlcaldia.Name = "chkRetenedorAlcaldia"
        Me.chkRetenedorAlcaldia.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkRetenedorAlcaldia.Size = New System.Drawing.Size(182, 20)
        Me.chkRetenedorAlcaldia.TabIndex = 7
        Me.chkRetenedorAlcaldia.Text = "Retenedor IR Alcaldia:"
        Me.chkRetenedorAlcaldia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkRetenedor
        '
        Me.chkRetenedor.AutoSize = True
        Me.chkRetenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRetenedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkRetenedor.Location = New System.Drawing.Point(96, 120)
        Me.chkRetenedor.Name = "chkRetenedor"
        Me.chkRetenedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkRetenedor.Size = New System.Drawing.Size(121, 20)
        Me.chkRetenedor.TabIndex = 5
        Me.chkRetenedor.Text = "Retenedor IR:"
        Me.chkRetenedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkExcento
        '
        Me.chkExcento.AutoSize = True
        Me.chkExcento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExcento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkExcento.Location = New System.Drawing.Point(96, 146)
        Me.chkExcento.Name = "chkExcento"
        Me.chkExcento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkExcento.Size = New System.Drawing.Size(104, 20)
        Me.chkExcento.TabIndex = 6
        Me.chkExcento.Text = "Exento IVA:"
        Me.chkExcento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(51, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Ruc:"
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(96, 68)
        Me.txtRuc.MaxLength = 50
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(176, 20)
        Me.txtRuc.TabIndex = 3
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(28, 20)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(62, 16)
        Me.Label29.TabIndex = 135
        Me.Label29.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(96, 16)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(104, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(96, 42)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(374, 20)
        Me.txtNombre.TabIndex = 2
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(398, 13)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 34)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 13)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 34)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdAddAll
        '
        Me.cmdAddAll.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddAll.Appearance.Options.UseFont = True
        Me.cmdAddAll.Appearance.Options.UseTextOptions = True
        Me.cmdAddAll.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAddAll.Location = New System.Drawing.Point(86, 13)
        Me.cmdAddAll.Name = "cmdAddAll"
        Me.cmdAddAll.Size = New System.Drawing.Size(96, 34)
        Me.cmdAddAll.TabIndex = 1
        Me.cmdAddAll.Text = "Agregar toda la información"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.cmdAddAll)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'frmAgregarClienteQuick
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(507, 251)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarClienteQuick"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.cbCuentas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim rutinas As New VB.SysContab.Rutinas()

    Private Sub frmAgregarClienteQuick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VB.SysContab.Rutinas.CambiarEstilo(Me)
        Me.Text = "Agregar Cliente"
        If Clientes.GenerarCodigo().Tables("Clientes").Rows.Count <> 0 Then
            Me.txtCodigo.Text = Clientes.GenerarCodigo().Tables("Clientes").Rows(0).Item("Codigo") + 1
        Else
            Me.txtCodigo.Text = ""
        End If

        txtNombre.Text = NombreCliente.ToUpper
        Me.cbCuentas.Properties.DataSource = ObtieneDatos("SELECT Cuenta,Nombre,(cuenta + ' - ' + nombre) as Display FROM catalogo WHERE  Tipo = 'A' AND Empresa = " & EmpresaActual)
        Me.Refresh()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Trim(txtCodigo.Text) = "" Then
            MsgBox("Introduzca el Código del Cliente", MsgBoxStyle.Information)
            txtCodigo.Focus()
            Exit Sub
        End If

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el Nombre del Cliente", MsgBoxStyle.Information)
            txtNombre.Focus()
            Exit Sub
        End If

        'If Trim(txtRuc.Text) = "" Then
        '    MsgBox("Introduzca el No. Ruc del Cliente", MsgBoxStyle.Information)
        '    txtRuc.Focus()
        '    Exit Sub
        'End If

        If Clientes.GenerarCodigo().Tables("Clientes").Rows.Count <> 0 Then
            Me.txtCodigo.Text = Clientes.GenerarCodigo().Tables("Clientes").Rows(0).Item("Codigo") + 1
        Else
            Me.txtCodigo.Text = ""
        End If

        Clientes.AddItem(txtCodigo.Text, txtNombre.Text, "", "", "", "", "", "", "", "", "", "", "", "", "", "",
            6, 51, "", "", "", "", Me.txtRuc.Text, 0, 0, "", "", 0, 0, 0, IIf(Me.cbCuentas.EditValue Is Nothing, "", Me.cbCuentas.EditValue),
            Me.chkExcento.Checked, 2, Me.chkRetenedor.Checked, 0, Me.chkRetenedorAlcaldia.Checked, "", Me.txtCodigoLetra.Text, False, 0, MonedaBase, 0, 0, "", 1, 0, "")
        Cod_Cliente = txtCodigo.Text

        Me.Close()

    End Sub

    Private Sub cmdAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddAll.Click
        Me.Close()

        Dim frm As frmAgregarCliente = frmAgregarCliente.Instance()
        frm.Dispose()

        Dim form As frmAgregarCliente = frmAgregarCliente.Instance()
        'Se quito el02062008, revisar la nueva pantalla de facturacion
        'Dim fp As DataGridTextBoxCombo.frmFacturacionCliente = fp.Instance

        With form
            Nuevo = "SI"
            AgregarClienteQuick = True
            '.MdiParent = fp.MdiParent

            .Show()

            '.cbZona.SelectedValue = -1
            '.cbVendedor.SelectedValue = -1
            '.cbCatalogo.SelectedValue = -1
            .txtNombre.Text = NombreCliente.ToUpper
        End With

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
        Cod_Cliente = "9999" 'Clientes Varios

    End Sub

End Class
