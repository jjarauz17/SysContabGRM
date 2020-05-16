Public Class frmBancosImpuestos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmBancosImpuestos = Nothing
    Private Catalogo As New VB.SysContab.CatalogoDB()
    Private Catalogo_Bancos As New VB.SysContab.Catalogo_BancosDB()
    Private Bancos As New VB.SysContab.BancosDB()
    Private DetalleBanco As New VB.SysContab.BancosDetails()
    Private r As New VB.SysContab.Rutinas()
    Private Tabla As DataTable
    Private ds As DataSet
    Public Origen As Integer = 0

    Public IRAnticipo As Boolean
    Public IRGeneral As Boolean
    Public IRProfesional As Boolean
    Public IRResidente As Boolean


    Public MontoAnticipo As Double
    Public MontoGeneral As Double
    Public MontoProfesional As Double
    Public MontoResidente As Double

    Public Mes As Integer
    Public Year As Integer

    Public Shared Function Instance() As frmBancosImpuestos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmBancosImpuestos()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.etIva = New System.Windows.Forms.Label
        Me.etPlantilla = New System.Windows.Forms.Label
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.dgBancos = New System.Windows.Forms.DataGrid
        Me.lblProv = New System.Windows.Forms.Label
        Me.lblProvID = New System.Windows.Forms.Label
        Me.lblFact = New System.Windows.Forms.Label
        Me.lblFactMonto = New System.Windows.Forms.Label
        Me.dgCatalogoBancos = New System.Windows.Forms.DataGrid
        Me.etCodigoProveedor = New System.Windows.Forms.Label
        Me.etSubTotal = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCatalogoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.etIva)
        Me.GroupBox2.Controls.Add(Me.etPlantilla)
        Me.GroupBox2.Controls.Add(Me.cmdAyuda)
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Controls.Add(Me.cmdImprimir)
        Me.GroupBox2.Controls.Add(Me.cmdModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 324)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 57)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'etIva
        '
        Me.etIva.Location = New System.Drawing.Point(448, 17)
        Me.etIva.Name = "etIva"
        Me.etIva.Size = New System.Drawing.Size(100, 25)
        Me.etIva.TabIndex = 144
        Me.etIva.Text = "Iva"
        Me.etIva.Visible = False
        '
        'etPlantilla
        '
        Me.etPlantilla.Location = New System.Drawing.Point(592, 17)
        Me.etPlantilla.Name = "etPlantilla"
        Me.etPlantilla.Size = New System.Drawing.Size(100, 25)
        Me.etPlantilla.TabIndex = 143
        Me.etPlantilla.Text = "Plantilla"
        Me.etPlantilla.Visible = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(197, 13)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(293, 13)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(109, 13)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(13, 13)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
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
        Me.dgBancos.Location = New System.Drawing.Point(8, 9)
        Me.dgBancos.Name = "dgBancos"
        Me.dgBancos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgBancos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgBancos.ReadOnly = True
        Me.dgBancos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgBancos.SelectionForeColor = System.Drawing.Color.White
        Me.dgBancos.Size = New System.Drawing.Size(976, 193)
        Me.dgBancos.TabIndex = 7
        '
        'lblProv
        '
        Me.lblProv.Location = New System.Drawing.Point(544, 155)
        Me.lblProv.Name = "lblProv"
        Me.lblProv.Size = New System.Drawing.Size(100, 25)
        Me.lblProv.TabIndex = 11
        Me.lblProv.Visible = False
        '
        'lblProvID
        '
        Me.lblProvID.Location = New System.Drawing.Point(704, 155)
        Me.lblProvID.Name = "lblProvID"
        Me.lblProvID.Size = New System.Drawing.Size(100, 25)
        Me.lblProvID.TabIndex = 12
        Me.lblProvID.Visible = False
        '
        'lblFact
        '
        Me.lblFact.Location = New System.Drawing.Point(848, 155)
        Me.lblFact.Name = "lblFact"
        Me.lblFact.Size = New System.Drawing.Size(100, 25)
        Me.lblFact.TabIndex = 13
        Me.lblFact.Text = "Label2"
        Me.lblFact.Visible = False
        '
        'lblFactMonto
        '
        Me.lblFactMonto.Location = New System.Drawing.Point(879, 359)
        Me.lblFactMonto.Name = "lblFactMonto"
        Me.lblFactMonto.Size = New System.Drawing.Size(100, 25)
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
        Me.dgCatalogoBancos.Location = New System.Drawing.Point(8, 202)
        Me.dgCatalogoBancos.Name = "dgCatalogoBancos"
        Me.dgCatalogoBancos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgCatalogoBancos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCatalogoBancos.ReadOnly = True
        Me.dgCatalogoBancos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgCatalogoBancos.SelectionForeColor = System.Drawing.Color.White
        Me.dgCatalogoBancos.Size = New System.Drawing.Size(976, 116)
        Me.dgCatalogoBancos.TabIndex = 141
        '
        'etCodigoProveedor
        '
        Me.etCodigoProveedor.Location = New System.Drawing.Point(791, 324)
        Me.etCodigoProveedor.Name = "etCodigoProveedor"
        Me.etCodigoProveedor.Size = New System.Drawing.Size(100, 25)
        Me.etCodigoProveedor.TabIndex = 142
        Me.etCodigoProveedor.Text = "Codigo Proveedor"
        Me.etCodigoProveedor.Visible = False
        '
        'etSubTotal
        '
        Me.etSubTotal.Location = New System.Drawing.Point(751, 359)
        Me.etSubTotal.Name = "etSubTotal"
        Me.etSubTotal.Size = New System.Drawing.Size(100, 25)
        Me.etSubTotal.TabIndex = 145
        Me.etSubTotal.Text = "SubTotal"
        Me.etSubTotal.Visible = False
        '
        'frmBancosImpuestos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 397)
        Me.Controls.Add(Me.etSubTotal)
        Me.Controls.Add(Me.etCodigoProveedor)
        Me.Controls.Add(Me.dgCatalogoBancos)
        Me.Controls.Add(Me.lblFactMonto)
        Me.Controls.Add(Me.lblFact)
        Me.Controls.Add(Me.lblProvID)
        Me.Controls.Add(Me.lblProv)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgBancos)
        Me.Name = "frmBancosImpuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgBancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCatalogoBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub frmBancosImpuestos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        Dim f As DataGridTextBox.frmComprobanteImpuestos = DataGridTextBox.frmComprobanteImpuestos.Instance
        Dim CatBancos As New VB.SysContab.Catalogo_BancosDB()

        f.IRAnticipo = Me.IRAnticipo
        f.IRGeneral = Me.IRGeneral
        f.IRProfesional = Me.IRProfesional
        f.IRResidente = Me.IRResidente

        f.MontoAnticipo = Me.MontoAnticipo
        f.MontoGeneral = Me.MontoGeneral
        f.MontoProfesional = Me.MontoProfesional
        f.MontoResidente = Me.MontoResidente


        f.Mes = Me.Mes
        f.Year = Me.Year

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
