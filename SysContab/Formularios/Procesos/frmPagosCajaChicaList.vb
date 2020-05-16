Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmPagosCajaChicaList
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmPagosCajaChicaList = Nothing

    Public Shared Function Instance() As frmPagosCajaChicaList
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPagosCajaChicaList()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgComprobantes As System.Windows.Forms.DataGrid
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cbPagar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etBalance As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgComprobantes = New System.Windows.Forms.DataGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVer = New DevExpress.XtraEditors.SimpleButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dtpInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.cbPagar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.etBalance = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        CType(Me.dgComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgComprobantes
        '
        Me.dgComprobantes.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgComprobantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgComprobantes.BackColor = System.Drawing.Color.Gainsboro
        Me.dgComprobantes.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgComprobantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgComprobantes.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgComprobantes.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgComprobantes.CaptionForeColor = System.Drawing.Color.Black
        Me.dgComprobantes.DataMember = ""
        Me.dgComprobantes.FlatMode = True
        Me.dgComprobantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgComprobantes.ForeColor = System.Drawing.Color.Black
        Me.dgComprobantes.GridLineColor = System.Drawing.Color.Silver
        Me.dgComprobantes.HeaderBackColor = System.Drawing.Color.Black
        Me.dgComprobantes.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgComprobantes.HeaderForeColor = System.Drawing.Color.White
        Me.dgComprobantes.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgComprobantes.Location = New System.Drawing.Point(16, 112)
        Me.dgComprobantes.Name = "dgComprobantes"
        Me.dgComprobantes.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgComprobantes.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgComprobantes.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgComprobantes.SelectionForeColor = System.Drawing.Color.White
        Me.dgComprobantes.Size = New System.Drawing.Size(828, 385)
        Me.dgComprobantes.TabIndex = 150
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdNuevo)
        Me.GroupBox2.Controls.Add(Me.cmdBorrar)
        Me.GroupBox2.Controls.Add(Me.cmdAyuda)
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Controls.Add(Me.cmdVer)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(859, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 504)
        Me.GroupBox2.TabIndex = 142
        Me.GroupBox2.TabStop = False
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdNuevo.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdNuevo.Appearance.Options.UseFont = True
        Me.cmdNuevo.Appearance.Options.UseForeColor = True
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(88, 35)
        Me.cmdNuevo.TabIndex = 164
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdBorrar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdBorrar.Appearance.Options.UseFont = True
        Me.cmdBorrar.Appearance.Options.UseForeColor = True
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(8, 172)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(88, 35)
        Me.cmdBorrar.TabIndex = 161
        Me.cmdBorrar.Text = "A&nular"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAyuda.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAyuda.Appearance.Options.UseFont = True
        Me.cmdAyuda.Appearance.Options.UseForeColor = True
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(8, 224)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(88, 34)
        Me.cmdAyuda.TabIndex = 30
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSalir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.Appearance.Options.UseForeColor = True
        Me.cmdSalir.Location = New System.Drawing.Point(8, 276)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(88, 34)
        Me.cmdSalir.TabIndex = 29
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 69)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(88, 34)
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "&Buscar"
        '
        'cmdVer
        '
        Me.cmdVer.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdVer.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdVer.Appearance.Options.UseFont = True
        Me.cmdVer.Appearance.Options.UseForeColor = True
        Me.cmdVer.Enabled = False
        Me.cmdVer.Location = New System.Drawing.Point(8, 121)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(88, 34)
        Me.cmdVer.TabIndex = 160
        Me.cmdVer.Text = "&Ver"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'dtpInicial
        '
        Me.dtpInicial.Enabled = False
        Me.dtpInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicial.Location = New System.Drawing.Point(120, 86)
        Me.dtpInicial.Name = "dtpInicial"
        Me.dtpInicial.Size = New System.Drawing.Size(104, 20)
        Me.dtpInicial.TabIndex = 167
        '
        'dtpFinal
        '
        Me.dtpFinal.Enabled = False
        Me.dtpFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFinal.Location = New System.Drawing.Point(232, 86)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtpFinal.TabIndex = 169
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(648, 43)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(64, 26)
        Me.etInicio.TabIndex = 174
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'chkFecha
        '
        Me.chkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkFecha.Location = New System.Drawing.Point(16, 86)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(96, 26)
        Me.chkFecha.TabIndex = 175
        Me.chkFecha.Text = "Por Fecha:"
        Me.chkFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbPagar
        '
        Me.cbPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPagar.Location = New System.Drawing.Point(112, 43)
        Me.cbPagar.Name = "cbPagar"
        Me.cbPagar.Size = New System.Drawing.Size(496, 21)
        Me.cbPagar.TabIndex = 176
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Pagado a:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(352, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 26)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "Factura:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFactura
        '
        Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(424, 86)
        Me.txtFactura.MaxLength = 13
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(136, 20)
        Me.txtFactura.TabIndex = 180
        '
        'etBalance
        '
        Me.etBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etBalance.Location = New System.Drawing.Point(684, 5)
        Me.etBalance.Name = "etBalance"
        Me.etBalance.Size = New System.Drawing.Size(160, 25)
        Me.etBalance.TabIndex = 185
        Me.etBalance.Text = "0"
        Me.etBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etBalance.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(624, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 25)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "Balance:"
        Me.Label8.Visible = False
        '
        'cbBancos
        '
        Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Location = New System.Drawing.Point(112, 9)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(496, 21)
        Me.cbBancos.TabIndex = 182
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(16, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 25)
        Me.Label25.TabIndex = 183
        Me.Label25.Text = "Caja:"
        '
        'frmPagosCajaChicaList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(963, 504)
        Me.Controls.Add(Me.etBalance)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbBancos)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.cbPagar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkFecha)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.dtpFinal)
        Me.Controls.Add(Me.dtpInicial)
        Me.Controls.Add(Me.dgComprobantes)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmPagosCajaChicaList"
        CType(Me.dgComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim Comp As New VB.SysContab.ComprobanteDB()
    Dim compDet As New VB.SysContab.ComprobantesDetails()
    Dim r As New VB.SysContab.Rutinas()
    Dim PerDB As New VB.SysContab.PeriodosDB()
    Dim Catalogo As New VB.SysContab.CatalogoDB()
    Dim CatalogoBancos As New VB.SysContab.Catalogo_BancosDB()
    Dim Proveedores As New VB.SysContab.ProveedoresDB()

    Dim Fecha1 As String
    Dim Fecha2 As String

    Dim ds As DataSet

    Dim i As Integer

    Private Sub frmPagosCajaChicaList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(GroupBox2)
        ''
        Me.dtpInicial.Value = r.Fecha
        Me.dtpFinal.Value = r.Fecha

        Me.dtpFinal.MinDate = Me.dtpFinal.Value
        Fecha1 = ""
        Fecha2 = ""

        Me.dtpInicial.Enabled = False
        Me.dtpFinal.Enabled = False

        'Me.cbBancos.DataSource = Catalogo.CatalogoList("A", 1).Tables("CATALOGO")
        Me.cbBancos.DataSource = ObtieneDatos("SELECT Cuenta, Cuenta + '-' + Nombre as Nombre, Cuenta + '-' + Nombre as Nombre2, 1 AS Orden " & _
            "FROM Catalogo WHERE Empresa = " & EmpresaActual & "AND Tipo = 'A' and CChica = 1 ORDER BY Orden, CUENTA")
        Me.cbBancos.ValueMember = "Cuenta"
        Me.cbBancos.DisplayMember = "Nombre"

        Me.cbPagar.DataSource = Proveedores.PagarList().Tables("Proveedores")
        Me.cbPagar.ValueMember = "Codigo"
        Me.cbPagar.DisplayMember = "Nombre"

        Dim ds As New DataSet()
        'Me.cbBancos.SelectedValue
        ds = Comp.CajaChicaPagosList(0, Fecha1, Fecha2, 0, "")
        Me.dgComprobantes.DataSource = ds.Tables("Comprobantes").DefaultView
        r.FormatGenerico(Me.dgComprobantes, ds.Tables("Comprobantes"))
        Me.dgComprobantes.ReadOnly = True
        r.ComboAutoComplete(Me.cbPagar)
    End Sub

    'Private Sub dgComprobantes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgComprobantes.DoubleClick
    '    MostrarComprobante()
    'End Sub

    Public Function Validar() As Boolean
        If CDate(dtpInicial.Value).ToShortDateString > CDate(dtpFinal.Value).ToShortDateString Then
            MsgBox("La Fecha Final debe ser Mayor o Igual a la Fecha Inicial")
            Return False
        End If
        Return True
    End Function

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Buscar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub MostrarComprobante()
        If Me.dgComprobantes.CurrentRowIndex < 0 Then
            MsgBox("Seleccione el cheque", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As DataGridTextBoxCombo.frmPagosCajaChicaVer = f.Instance
        f.MdiParent = Me.MdiParent
        f.Inicio = True
        f.etComprobante.Text = Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0)
        f.etFecha.Text = Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 2)
        f.etPeriodo.Text = Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 5)
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.Inicio = False
        If f.Pagara = "0" Then
            f.cbPagar.Text = f.Nombre
        End If

    End Sub

    Private Sub cmdVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdVer.Click
        MostrarComprobante()
    End Sub

    Private Sub dtpInicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicial.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If
        Me.dtpFinal.MinDate = Me.dtpInicial.Value.Date
        Fecha1 = Me.dtpInicial.Value.Date
        Buscar()
    End Sub

    Private Sub dtpFinal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFinal.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If
        Me.dtpInicial.MaxDate = Me.dtpFinal.Value.Date
        Fecha2 = Me.dtpFinal.Value.Date
        Buscar()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.dgComprobantes.CurrentRowIndex < 0 Then
            MsgBox("Seleccione el registro que desea Anular", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim Registros As Integer

        Registros = Comp.ComprobanteAnularBuscar(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0), Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 5), Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 2))

        If Registros > 0 Then
            MsgBox("El registro ya fue anulado", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("¿Esta seguro que desea anular el registro", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction

        Try
            Comp.ComprobanteAnular(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0), Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 5), Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 2))
            vb.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try

        Buscar()

    End Sub

    Private Sub Buscar()
        Me.dgComprobantes.DataSource = Comp.CajaChicaPagosList(Me.cbBancos.SelectedValue, Fecha1, Fecha2, Me.cbPagar.SelectedValue, Me.txtFactura.Text).Tables("Comprobantes").DefaultView
    End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        If chkFecha.Checked = True Then
            Me.dtpInicial.Enabled = True
            Me.dtpFinal.Enabled = True
            Fecha1 = Me.dtpInicial.Value.Date
            Fecha2 = Me.dtpFinal.Value.Date
            Me.dtpFinal.MinDate = Me.dtpInicial.Value
        Else
            Me.dtpInicial.Enabled = False
            Me.dtpFinal.Enabled = False
            Fecha1 = ""
            Fecha2 = ""
        End If
        Buscar()
    End Sub

    Private Sub cbPagar_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPagar.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If
        Buscar()
    End Sub

    'Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
    '    If Me.dgComprobantes.CurrentRowIndex < 0 Then
    '        MsgBox("Seleccione el cheque", MsgBoxStyle.Information)
    '        Exit Sub
    '    End If

    '    Dim ValorLetras As String = r.ConversionDecimales(CDbl(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 4)))  'VB.SysContab.Rutinas.ConversionDecimales( CDbl(lblDebito.Text).ToString(Round))
    '    Dim fReportes As New frmReportes()
    '    Dim rFactura As New rptComprobanteCKDinamico()
    '    rFactura.SetDataSource(Comp.ImprimirCombrobante(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0), Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 5), ValorLetras, Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 2), CDbl(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 4))))
    '    fReportes.crvReportes.ReportSource = rFactura
    '    fReportes.Show()
    'End Sub

    'Private Sub cmdImprimirComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimirComp.Click
    '    If Me.dgComprobantes.CurrentRowIndex < 0 Then
    '        MsgBox("Seleccione el cheque", MsgBoxStyle.Information)
    '        Exit Sub
    '    End If

    '    Dim ValorLetras As String = r.ConversionDecimales(CDbl(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 4)))  'VB.SysContab.Rutinas.ConversionDecimales( CDbl(lblDebito.Text).ToString(Round))
    '    Dim fReportes As New frmReportes()
    '    Dim rFactura As New rptComprobanteCheque2()
    '    rFactura.SetDataSource(Comp.ImprimirCombrobante(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0), Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 5), ValorLetras, Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 2), CDbl(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 4))))
    '    fReportes.crvReportes.ReportSource = rFactura
    '    fReportes.Show()
    'End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As DataGridTextBoxCombo.frmPagosCajaChica = f.Instance
        f.MdiParent = Me.MdiParent
        f.Inicio = True
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.Inicio = False
    End Sub

    Private Sub cbBancos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBancos.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If
        Saldo()
        Buscar()
    End Sub

    Private Sub Saldo()
        If Me.cbBancos.SelectedValue = "0" Then
            Me.Label8.Visible = False
            Me.etBalance.Text = 0
            Me.etBalance.Visible = False
        Else
            Me.Label8.Visible = True
            Me.etBalance.Visible = True

            Me.etBalance.Text = CDbl(Comp.SaldoxCuenta(Me.cbBancos.SelectedValue, VB.SysContab.PeriodosDB.Actual)).ToString(Round)
        End If
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "Ayuda/Procesos/ProcesosPagosCC.chm")
    End Sub
End Class
