Public Class frmBancosImpuestosIVA
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmBancosImpuestosIVA = Nothing
    Private Catalogo As New VB.SysContab.CatalogoDB()
    Private Catalogo_Bancos As New VB.SysContab.Catalogo_BancosDB()
    Private Bancos As New VB.SysContab.BancosDB()
    Private DetalleBanco As New VB.SysContab.BancosDetails()
    Private r As New VB.SysContab.Rutinas()
    Private Tabla As DataTable
    Private ds As DataSet
    Public Origen As Integer = 0

    Public MontoIVAVentas As Double
    Public MontoIVACompras As Double

    Public Mes As Integer
    Public Year As Integer

    Public Shared Function Instance() As frmBancosImpuestosIVA
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmBancosImpuestosIVA()
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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgBancos As System.Windows.Forms.DataGrid
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblProv As System.Windows.Forms.Label
    Friend WithEvents lblProvID As System.Windows.Forms.Label
    Friend WithEvents lblFact As System.Windows.Forms.Label
    Friend WithEvents lblFactMonto As System.Windows.Forms.Label
    Friend WithEvents dgCatalogoBancos As System.Windows.Forms.DataGrid
    Friend WithEvents etCodigoProveedor As System.Windows.Forms.Label
    Friend WithEvents etPlantilla As System.Windows.Forms.Label
    Friend WithEvents etIva As System.Windows.Forms.Label
    Friend WithEvents etSubTotal As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.etIva = New System.Windows.Forms.Label()
        Me.etPlantilla = New System.Windows.Forms.Label()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgBancos = New System.Windows.Forms.DataGrid()
        Me.lblProv = New System.Windows.Forms.Label()
        Me.lblProvID = New System.Windows.Forms.Label()
        Me.lblFact = New System.Windows.Forms.Label()
        Me.lblFactMonto = New System.Windows.Forms.Label()
        Me.dgCatalogoBancos = New System.Windows.Forms.DataGrid()
        Me.etCodigoProveedor = New System.Windows.Forms.Label()
        Me.etSubTotal = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCatalogoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.etIva, Me.etPlantilla, Me.cmdAyuda, Me.cmdSalir, Me.cmdImprimir, Me.cmdModificar})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 459)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 53)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'etIva
        '
        Me.etIva.Location = New System.Drawing.Point(448, 16)
        Me.etIva.Name = "etIva"
        Me.etIva.TabIndex = 144
        Me.etIva.Text = "Iva"
        Me.etIva.Visible = False
        '
        'etPlantilla
        '
        Me.etPlantilla.Location = New System.Drawing.Point(592, 16)
        Me.etPlantilla.Name = "etPlantilla"
        Me.etPlantilla.TabIndex = 143
        Me.etPlantilla.Text = "Plantilla"
        Me.etPlantilla.Visible = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdAyuda.Location = New System.Drawing.Point(200, 16)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 32)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(296, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 32)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(112, 16)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 32)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(16, 16)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 32)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Seleccionar"
        '
        'dgBancos
        '
        Me.dgBancos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgBancos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgBancos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgBancos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgBancos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgBancos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgBancos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgBancos.DataMember = ""
        Me.dgBancos.FlatMode = True
        Me.dgBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBancos.ForeColor = System.Drawing.Color.Black
        Me.dgBancos.GridLineColor = System.Drawing.Color.Silver
        Me.dgBancos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgBancos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgBancos.HeaderForeColor = System.Drawing.Color.White
        Me.dgBancos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgBancos.Location = New System.Drawing.Point(8, 8)
        Me.dgBancos.Name = "dgBancos"
        Me.dgBancos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgBancos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgBancos.ReadOnly = True
        Me.dgBancos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgBancos.SelectionForeColor = System.Drawing.Color.White
        Me.dgBancos.Size = New System.Drawing.Size(976, 232)
        Me.dgBancos.TabIndex = 7
        '
        'lblProv
        '
        Me.lblProv.Location = New System.Drawing.Point(544, 144)
        Me.lblProv.Name = "lblProv"
        Me.lblProv.TabIndex = 11
        Me.lblProv.Visible = False
        '
        'lblProvID
        '
        Me.lblProvID.Location = New System.Drawing.Point(704, 144)
        Me.lblProvID.Name = "lblProvID"
        Me.lblProvID.TabIndex = 12
        Me.lblProvID.Visible = False
        '
        'lblFact
        '
        Me.lblFact.Location = New System.Drawing.Point(848, 144)
        Me.lblFact.Name = "lblFact"
        Me.lblFact.TabIndex = 13
        Me.lblFact.Text = "Label2"
        Me.lblFact.Visible = False
        '
        'lblFactMonto
        '
        Me.lblFactMonto.Location = New System.Drawing.Point(912, 480)
        Me.lblFactMonto.Name = "lblFactMonto"
        Me.lblFactMonto.TabIndex = 14
        Me.lblFactMonto.Text = "Label3"
        Me.lblFactMonto.Visible = False
        '
        'dgCatalogoBancos
        '
        Me.dgCatalogoBancos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgCatalogoBancos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgCatalogoBancos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgCatalogoBancos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCatalogoBancos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgCatalogoBancos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgCatalogoBancos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgCatalogoBancos.DataMember = ""
        Me.dgCatalogoBancos.FlatMode = True
        Me.dgCatalogoBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCatalogoBancos.ForeColor = System.Drawing.Color.Black
        Me.dgCatalogoBancos.GridLineColor = System.Drawing.Color.Silver
        Me.dgCatalogoBancos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgCatalogoBancos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgCatalogoBancos.HeaderForeColor = System.Drawing.Color.White
        Me.dgCatalogoBancos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgCatalogoBancos.Location = New System.Drawing.Point(8, 248)
        Me.dgCatalogoBancos.Name = "dgCatalogoBancos"
        Me.dgCatalogoBancos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgCatalogoBancos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCatalogoBancos.ReadOnly = True
        Me.dgCatalogoBancos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgCatalogoBancos.SelectionForeColor = System.Drawing.Color.White
        Me.dgCatalogoBancos.Size = New System.Drawing.Size(976, 200)
        Me.dgCatalogoBancos.TabIndex = 141
        '
        'etCodigoProveedor
        '
        Me.etCodigoProveedor.Location = New System.Drawing.Point(824, 448)
        Me.etCodigoProveedor.Name = "etCodigoProveedor"
        Me.etCodigoProveedor.TabIndex = 142
        Me.etCodigoProveedor.Text = "Codigo Proveedor"
        Me.etCodigoProveedor.Visible = False
        '
        'etSubTotal
        '
        Me.etSubTotal.Location = New System.Drawing.Point(784, 480)
        Me.etSubTotal.Name = "etSubTotal"
        Me.etSubTotal.TabIndex = 145
        Me.etSubTotal.Text = "SubTotal"
        Me.etSubTotal.Visible = False
        '
        'frmBancosContabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.etSubTotal, Me.etCodigoProveedor, Me.dgCatalogoBancos, Me.lblFactMonto, Me.lblFact, Me.lblProvID, Me.lblProv, Me.GroupBox2, Me.dgBancos})
        Me.Name = "frmBancosContabilizar"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgBancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCatalogoBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub frmBancosImpuestosIVA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Bancos As New VB.SysContab.BancosDB()
        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As DataTable
        Dim ds As DataSet

        'r.CambiarEstilo(Me)
        ds = Bancos.GetList

        dgBancos.DataSource = Bancos.GetListActivos().Tables("Bancos").DefaultView
        Tabla = ds.Tables("BANCOS")
        r.FormatGenerico(dgBancos, Tabla)
        If ds.Tables("Bancos").Rows.Count <> 0 Then
            Registro = dgBancos.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        dgBancos.CaptionText = "Información de Bancos"
        Me.Text = "Seleccionar un Banco"

        '***
        If Registro <> "Vacio" Then
            DetalleBanco = Bancos.GetDetails(Registro)

            ds = Catalogo_Bancos.GetList(Registro)
            dgCatalogoBancos.DataSource = Catalogo_Bancos.GetList(Registro).Tables("CATALOGO_BANCOS").DefaultView
            Tabla = ds.Tables("CATALOGO_BANCOS")
            r.FormatGenerico(dgCatalogoBancos, Tabla)
            dgCatalogoBancos.CaptionText = "Cuentas de Banco"

            If Catalogo_Bancos.GetList(Registro).Tables("CATALOGO_BANCOS").Rows.Count = 0 Then
                CatalogoBancosP = "Vacio"
            Else
                CatalogoBancosP = dgCatalogoBancos.Item(0, 0)
            End If
        End If

        '***

        Me.Refresh()

    End Sub

    Private Sub frmBancos_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Opened = "NO"


    End Sub

    Private Sub dgBancos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgBancos.CurrentCellChanged
        Registro = dgBancos.Item(dgBancos.CurrentRowIndex, 0)
        If Registro <> "Vacio" Then
            DetalleBanco = Bancos.GetDetails(Registro)

            ds = Catalogo_Bancos.GetList(Registro)
            dgCatalogoBancos.DataSource = Catalogo_Bancos.GetList(Registro).Tables("CATALOGO_BANCOS").DefaultView
            Tabla = ds.Tables("CATALOGO_BANCOS")
            r.FormatGenerico(dgCatalogoBancos, Tabla)
            dgCatalogoBancos.CaptionText = "Cuentas de Banco"

            If Catalogo_Bancos.GetList(Registro).Tables("CATALOGO_BANCOS").Rows.Count = 0 Then
                CatalogoBancosP = "Vacio"
            Else
                CatalogoBancosP = dgCatalogoBancos.Item(0, 0)
            End If
        End If
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        'If Origen = 2 Then
        '    Dim f As frmIRxFactura = f.Instance
        '    f.txtBanID.text = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1)
        '    f.Show()
        '    Me.Close()
        '    Exit Sub
        'End If

        'If Origen = 1 Then
        '    Dim f As frmReporteIVA = f.Instance
        '    f.txtBanID.Text = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1).ToString
        '    f.Show()
        '    Me.Close()
        '    Exit Sub

        'Else

        Dim f As DataGridTextBox.frmComprobanteImpuestosIVA = f.Instance
        Dim CatBancos As New VB.SysContab.Catalogo_BancosDB()

        'f.IRAnticipo = Me.IRAnticipo
        'f.IRGeneral = Me.IRGeneral
        'f.IRProfesional = Me.IRProfesional
        'f.IRResidente = Me.IRResidente

        'f.MontoAnticipo = Me.MontoAnticipo
        'f.MontoGeneral = Me.MontoGeneral
        'f.MontoProfesional = Me.MontoProfesional
        'f.MontoResidente = Me.MontoResidente
        f.Mes = Me.Mes
        f.Year = Me.Year

        f.MontoIVAVentas = Me.MontoIVAVentas
        f.MontoIVACompras = Me.MontoIVACompras

        'f.TipoPago = Me.TipoPago

        f.etPlantilla.Text = Me.etPlantilla.Text
        f.txtProv.Text = lblProv.Text
        f.txtProvID.Text = lblProvID.Text
        f.txtCodigoProveedor.Text = Me.etCodigoProveedor.Text
        f.Banco = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1)
        f.BancoID = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 0)
        f.txtBanco.Text = Me.dgBancos.Item(Me.dgBancos.CurrentRowIndex, 2)
        'f.txtBanco.Text = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1)
        f.txtFact.Text = lblFact.Text
        f.txtValor.Text = CDbl(lblFactMonto.Text).ToString(Round)
        f.txtCheque.Text = CatBancos.GetCheque(Registro, dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 3))
        f.MdiParent = Me.MdiParent
        f.etIva.Text = Me.etIva.Text
        f.etSubTotal.Text = Me.etSubTotal.Text
        f.Show()
        Exit Sub
        'End If
    End Sub

    Private Sub frmBancos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        'FormPrincipal.menuRegistros.Visible = False
        'FormPrincipal.menu1.Visible = False
        'FormPrincipal.menuContabilidad.Visible = False
        'FormPrincipal.menuGrupos.Visible = False
        'FormPrincipal.menuInventario.Visible = False

        ''Menu Herramientas
        'FormPrincipal.menuHerramientas.Visible = False

    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FormPrincipal.menuRegistros.Visible = False
        'FormPrincipal.menu1.Visible = False
        'FormPrincipal.menuContabilidad.Visible = False
        'FormPrincipal.menuGrupos.Visible = False

        ''Menu Herramientas
        'FormPrincipal.menuHerramientas.Visible = False

    End Sub

    Private Sub dgBancos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgBancos.MouseEnter
        'FormPrincipal.menuRegistros.Visible = False
        'FormPrincipal.menu1.Visible = False
        'FormPrincipal.menuContabilidad.Visible = False
        'FormPrincipal.menuGrupos.Visible = False
        'FormPrincipal.menuInventario.Visible = False

        ''Menu Herramientas
        'FormPrincipal.menuHerramientas.Visible = False

    End Sub

End Class
