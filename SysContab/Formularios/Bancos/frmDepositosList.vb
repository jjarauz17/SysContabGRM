Imports DevExpress.XtraEditors

Public Class frmDepositosList
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmDepositosList = Nothing

    Public Shared Function Instance() As frmDepositosList
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmDepositosList()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Código generado por el Diseñador de Windows Forms "

    Private Sub New()
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
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents cbFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cmdVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.cbFecha = New System.Windows.Forms.CheckBox()
        Me.cmdVer = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Location = New System.Drawing.Point(193, 11)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(85, 34)
        Me.cmdCancelar.TabIndex = 26
        Me.cmdCancelar.Text = "Salir"
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(592, 9)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha1.TabIndex = 147
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 25)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Banco:"
        '
        'cbBancos
        '
        Me.cbBancos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Location = New System.Drawing.Point(88, 9)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(392, 21)
        Me.cbBancos.TabIndex = 149
        '
        'cbFecha
        '
        Me.cbFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbFecha.Location = New System.Drawing.Point(488, 9)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(96, 25)
        Me.cbFecha.TabIndex = 152
        Me.cbFecha.Text = "Por Fecha:"
        Me.cbFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cmdVer
        '
        Me.cmdVer.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVer.Appearance.Options.UseFont = True
        Me.cmdVer.Location = New System.Drawing.Point(11, 11)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(85, 34)
        Me.cmdVer.TabIndex = 153
        Me.cmdVer.Text = "&Mostrar"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Appearance.Options.UseFont = True
        Me.cmdAgregar.Appearance.Options.UseTextOptions = True
        Me.cmdAgregar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAgregar.Location = New System.Drawing.Point(284, 11)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(88, 34)
        Me.cmdAgregar.TabIndex = 154
        Me.cmdAgregar.Text = "Agregar a Deposito"
        Me.cmdAgregar.Visible = False
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha2.Location = New System.Drawing.Point(704, 9)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha2.TabIndex = 156
        '
        'dgDatos
        '
        Me.dgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDatos.Location = New System.Drawing.Point(8, 40)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(792, 197)
        Me.dgDatos.TabIndex = 157
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsBehavior.Editable = False
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.btnExportar)
        Me.PanelControl1.Controls.Add(Me.cmdVer)
        Me.PanelControl1.Controls.Add(Me.cmdAgregar)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Location = New System.Drawing.Point(8, 243)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(790, 54)
        Me.PanelControl1.TabIndex = 158
        '
        'btnExportar
        '
        Me.btnExportar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Appearance.Options.UseFont = True
        Me.btnExportar.Location = New System.Drawing.Point(102, 11)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(85, 34)
        Me.btnExportar.TabIndex = 155
        Me.btnExportar.Text = "&Exportar"
        '
        'frmDepositosList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(809, 309)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.dgDatos)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.cbFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbBancos)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Name = "frmDepositosList"
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas()
    Dim Depositos As New VB.SysContab.DepositosDB()
    Dim Bancos As New VB.SysContab.BancosDB()
    Dim ds As DataSet
    Dim Fecha1 As String
    Dim Fecha2 As String

    Private Sub frmDepositosList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim i As Integer

        ''r.CambiarEstilo(Me)
        'r.FormularioColor(Me)
        'dsFormaPago = FormaPago.FormaPagoList()

        Me.dtpFecha1.Value = r.Fecha
        Me.dtpFecha2.Value = r.Fecha

        Fecha1 = ""
        Fecha2 = ""

        'If ds.Tables("Depositos").Rows.Count <> 0 Then
        '    Registro = dgDepositos.Item(0, 0)
        'Else
        '    Registro = "Vacio"
        'End If

        cbBancos.DataSource = Bancos.List.Tables("Bancos")
        cbBancos.ValueMember = "Codigo"
        cbBancos.DisplayMember = "Nombre"

        dtpFecha1.Enabled = False
        dtpFecha2.Enabled = False

        Me.Text = "H o j a s  d e  D e p o s i t o"

        Cargar(0)
        '
        Me.Refresh()
    End Sub

    Public Sub Cargar(ByVal Banco As Integer)
        Dim Tabla As DataTable

        ds = Depositos.List(Banco, Fecha1, Fecha2, 2)
        'dgDepositos.DataSource = ds.Tables("Depositos").DefaultView
        Tabla = ds.Tables("Depositos")
        'r.FormatGenerico(dgDepositos, Tabla)
        'dgDepositos.CaptionText = "Hojas de Deposito"

        Me.dgDatos.DataSource = ds.Tables("Depositos").DefaultView
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)

        Me.vDatos.Columns("DisplayMember").Visible = False
        Me.vDatos.Columns("Deposito_ID").Visible = False
        Me.vDatos.BestFitColumns()

        Me.vDatos.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"

        Me.vDatos.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click        
        Me.Close()
    End Sub

    Private Sub dgDepositos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim f As frmDepositosVer = f.Instance

        'Deposito = dgDepositos.Item(dgDepositos.CurrentRowIndex, 0)
        'f.etDescripcion.Text = "No. Hoja: " & dgDepositos.Item(dgDepositos.CurrentRowIndex, 4) & "   Fecha: " & dgDepositos.Item(dgDepositos.CurrentRowIndex, 2) & "   Banco: " & dgDepositos.Item(dgDepositos.CurrentRowIndex, 1) & "   Cuenta: " & dgDepositos.Item(dgDepositos.CurrentRowIndex, 1)
        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    'Private Sub cbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFecha.CheckedChanged
    '    If cbFecha.Checked = True Then
    '        dtpFecha.Enabled = True
    '        Fecha = dtpFecha.Value.Date
    '    Else
    '        dtpFecha.Enabled = False
    '        Fecha = ""
    '    End If
    'End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        Try
            If cbFecha.Checked = True Then
                Fecha1 = dtpFecha1.Value.Date
                dtpFecha2.MinDate = dtpFecha1.Value
            Else
                Fecha1 = ""
            End If
            '
            Cargar(IIf(Me.cbBancos.SelectedValue Is Nothing, 0, Me.cbBancos.SelectedValue))
        Catch ex As Exception
        End Try


        'If IsNumeric(cbBancos.SelectedValue) Then
        '    ds = Depositos.List(cbBancos.SelectedValue, Fecha1, Fecha2, 2)
        '    dgDepositos.DataSource = ds.Tables("Depositos").DefaultView
        'End If
    End Sub

    Private Sub dtpFecha2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha2.ValueChanged
        'If cbFecha.Checked = True Then
        '    Fecha1 = dtpFecha1.Value.Date
        'Else
        '    Fecha1 = ""
        'End If

        Try
            Fecha2 = dtpFecha2.Value.Date
            '
            Cargar(IIf(Me.cbBancos.SelectedValue Is Nothing, 0, Me.cbBancos.SelectedValue))
        Catch ex As Exception
        End Try



        'If IsNumeric(cbBancos.SelectedValue) Then
        '    ds = Depositos.List(cbBancos.SelectedValue, Fecha1, Fecha2, 2)
        '    dgDepositos.DataSource = ds.Tables("Depositos").DefaultView
        'End If
    End Sub

    Private Sub cbBancos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBancos.SelectedValueChanged
        If IsNumeric(cbBancos.SelectedValue) Then
            'If cbFecha.Checked = True Then
            '    Fecha1 = dtpFecha1.Value.Date
            'Else
            '    Fecha2 = ""
            'End If
            'ds = Depositos.List(cbBancos.SelectedValue, Fecha)
            'dgDepositos.DataSource = Depositos.List(cbBancos.SelectedValue, Fecha1, Fecha2, 2).Tables("Depositos").DefaultView

            Cargar(Me.cbBancos.SelectedValue)
        Else
            Exit Sub
        End If

    End Sub

    Private Sub cbFecha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFecha.Click
        If cbFecha.Checked = True Then
            dtpFecha1.Enabled = True
            dtpFecha2.Enabled = True
            Fecha1 = dtpFecha1.Value.Date
            Fecha2 = dtpFecha2.Value.Date
            dtpFecha2.MinDate = dtpFecha1.Value
        Else
            dtpFecha1.Enabled = False
            dtpFecha2.Enabled = False
            Fecha1 = ""
            Fecha2 = ""
        End If
        '
        Cargar(IIf(Me.cbBancos.SelectedValue Is Nothing, 0, Me.cbBancos.SelectedValue))

        'dgDepositos.DataSource = Depositos.List(cbBancos.SelectedValue, Fecha1, Fecha2, 2).Tables("Depositos").DefaultView
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        'Deposito = dgDepositos.Item(dgDepositos.CurrentRowIndex, 0)

        Deposito = Me.vDatos.GetFocusedRowCellValue("Deposito_ID")
        Dim f As frmAsignarDepositos = f.Instance
        f.cbDepositos.SelectedValue = Deposito
        Me.Close()
    End Sub

    Private Sub cmdVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdVer.Click
        If Me.vDatos.DataRowCount = 0 Then
            XtraMessageBox.Show("Seleccione un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMessageBox.Show("Seleccione un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        Dim f As frmDepositosVer = f.Instance
        'Deposito = dgDepositos.Item(dgDepositos.CurrentRowIndex, 0)
        Deposito = Me.vDatos.GetFocusedRowCellValue("Deposito_ID")

        f.etDescripcion.Text = "No. Deposito: " & Me.vDatos.GetFocusedRowCellValue("Deposito_ID") & " Documento: " & IsNull(Me.vDatos.GetFocusedRowCellValue("Documento"), "**") & "   Fecha: " & _
        Me.vDatos.GetFocusedRowCellValue("Fecha Deposito") & "   Banco: " & Me.vDatos.GetFocusedRowCellValue("Banco") & _
        "   Cuenta: " & Me.vDatos.GetFocusedRowCellValue("Cuenta")

        f.MdiParent = Me.MdiParent

        f.lblFecha.Text = Me.vDatos.GetFocusedRowCellValue("Fecha Deposito")
        f.lblDepositoNo.Text = Me.vDatos.GetFocusedRowCellValue("Deposito_ID")
        f.lblCuentaBanco.Text = Me.vDatos.GetFocusedRowCellValue("Cuenta")
        f.Documento = IsNull(Me.vDatos.GetFocusedRowCellValue("Documento"), "")

        f.Show()
        f.WindowState = FormWindowState.Maximized

        'f.lblFecha.Text = dgDepositos.Item(dgDepositos.CurrentRowIndex, 3)
        'f.lblDepositoNo.Text = dgDepositos.Item(dgDepositos.CurrentRowIndex, 0)
        'f.lblCuentaBanco.Text = dgDepositos.Item(dgDepositos.CurrentRowIndex, 2)
    End Sub

    Private Sub vDatos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vDatos.DoubleClick
        cmdVer_Click(Nothing, Nothing)
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.dgDatos)
    End Sub
End Class
