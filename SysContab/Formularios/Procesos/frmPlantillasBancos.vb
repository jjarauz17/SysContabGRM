Public Class frmPlantillasBancos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmPlantillasBancos = Nothing
    Private Catalogo As New VB.SysContab.CatalogoDB()
    Private Catalogo_Bancos As New VB.SysContab.Catalogo_BancosDB()
    Private Bancos As New VB.SysContab.BancosDB()
    Private DetalleBanco As New VB.SysContab.BancosDetails()
    Private r As New VB.SysContab.Rutinas()
    Private Tabla As DataTable
    Private ds As DataSet
    Public Origen As Integer = 0


    Public Comp_No, Mes, Per_ID, FormaPago As String
    Public ComprasCredito, SubTotal As String
    Public Monto_IR_Pagado, Monto_IR_Pagado_Alcaldia, MontoIVAasumido, MontoIRxPagar, SubTotalIRxPagar As Double
    Public IR_Pagado_Alcaldia, IRPagado, IVAAsumido, SegundoIR As Boolean

    Public CompFact As String


    Public Shared Function Instance() As frmPlantillasBancos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPlantillasBancos()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
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
    Friend WithEvents etFecha As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
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
        Me.etFecha = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCatalogoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(88, 12)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(384, 20)
        Me.txtBuscar.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdAyuda)
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Controls.Add(Me.cmdImprimir)
        Me.GroupBox2.Controls.Add(Me.cmdModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 440)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 57)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(200, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(296, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(112, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(16, 17)
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
        Me.dgBancos.Location = New System.Drawing.Point(8, 39)
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
        Me.lblProv.Location = New System.Drawing.Point(528, 9)
        Me.lblProv.Name = "lblProv"
        Me.lblProv.Size = New System.Drawing.Size(100, 24)
        Me.lblProv.TabIndex = 11
        Me.lblProv.Text = "Nombre Proveedor"
        Me.lblProv.Visible = False
        '
        'lblProvID
        '
        Me.lblProvID.Location = New System.Drawing.Point(616, 9)
        Me.lblProvID.Name = "lblProvID"
        Me.lblProvID.Size = New System.Drawing.Size(100, 24)
        Me.lblProvID.TabIndex = 12
        Me.lblProvID.Text = "Cuenta Proveedor"
        Me.lblProvID.Visible = False
        '
        'lblFact
        '
        Me.lblFact.Location = New System.Drawing.Point(840, 17)
        Me.lblFact.Name = "lblFact"
        Me.lblFact.Size = New System.Drawing.Size(100, 25)
        Me.lblFact.TabIndex = 13
        Me.lblFact.Text = "Factura"
        Me.lblFact.Visible = False
        '
        'lblFactMonto
        '
        Me.lblFactMonto.Location = New System.Drawing.Point(912, 517)
        Me.lblFactMonto.Name = "lblFactMonto"
        Me.lblFactMonto.Size = New System.Drawing.Size(100, 25)
        Me.lblFactMonto.TabIndex = 14
        Me.lblFactMonto.Text = "Monto"
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
        Me.dgCatalogoBancos.Location = New System.Drawing.Point(8, 241)
        Me.dgCatalogoBancos.Name = "dgCatalogoBancos"
        Me.dgCatalogoBancos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgCatalogoBancos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCatalogoBancos.ReadOnly = True
        Me.dgCatalogoBancos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgCatalogoBancos.SelectionForeColor = System.Drawing.Color.White
        Me.dgCatalogoBancos.Size = New System.Drawing.Size(976, 203)
        Me.dgCatalogoBancos.TabIndex = 141
        '
        'etCodigoProveedor
        '
        Me.etCodigoProveedor.Location = New System.Drawing.Point(824, 482)
        Me.etCodigoProveedor.Name = "etCodigoProveedor"
        Me.etCodigoProveedor.Size = New System.Drawing.Size(100, 25)
        Me.etCodigoProveedor.TabIndex = 142
        Me.etCodigoProveedor.Text = "Codigo Proveedor"
        Me.etCodigoProveedor.Visible = False
        '
        'etFecha
        '
        Me.etFecha.Location = New System.Drawing.Point(792, 517)
        Me.etFecha.Name = "etFecha"
        Me.etFecha.Size = New System.Drawing.Size(100, 25)
        Me.etFecha.TabIndex = 143
        Me.etFecha.Text = "Fecha"
        Me.etFecha.Visible = False
        '
        'frmPlantillasBancos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 502)
        Me.Controls.Add(Me.etFecha)
        Me.Controls.Add(Me.etCodigoProveedor)
        Me.Controls.Add(Me.dgCatalogoBancos)
        Me.Controls.Add(Me.lblFactMonto)
        Me.Controls.Add(Me.lblFact)
        Me.Controls.Add(Me.lblProvID)
        Me.Controls.Add(Me.lblProv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgBancos)
        Me.Name = "frmPlantillasBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgBancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCatalogoBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmBancos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Bancos As New VB.SysContab.BancosDB()
        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As DataTable
        Dim ds As DataSet

        'r.CambiarEstilo(Me)
        ds = Bancos.GetList

        dgBancos.DataSource = Bancos.GetListActivos().Tables("BANCOS").DefaultView
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

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As frmAgregarBanco = f.Instance

        Nuevo = "SI"

        f.MdiParent = Me.MdiParent
        f.Show()

        f.cbCatalogo.SelectedValue = -1

    End Sub

    'Private Sub dgBancos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgBancos.CurrentCellChanged
    '    Registro = dgBancos.Item(dgBancos.CurrentRowIndex, 0)

    'End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim Bancos As New VB.SysContab.BancosDB()

        dgBancos.DataSource = Bancos.GetListBuscar(txtBuscar.Text).Tables("Bancos").DefaultView


        If Bancos.GetListBuscar(txtBuscar.Text).Tables("Bancos").Rows.Count = 0 Then
            Exit Sub

        End If
        Registro = dgBancos.Item(dgBancos.CurrentRowIndex, 0)
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True

        End If
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
        If Origen = 2 Then
            Dim f As frmIRxFactura = f.Instance
            f.txtBanID.text = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1)
            f.Show()
            Me.Close()
            Exit Sub
        End If


        If Origen = 1 Then
            Dim f As frmReporteIVA = f.Instance
            f.txtBanID.Text = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1).ToString
            f.Show()
            Me.Close()
            Exit Sub

        Else

            Dim f As DataGridTextBox.frmComprobanteTipo1 = f.Instance

            Dim CatBancos As New VB.SysContab.Catalogo_BancosDB


            f.Comp_No = Me.Comp_No
            f.MesNo = Me.Mes
            f.Per_ID = Me.Per_ID
            f.FormaPago = Me.FormaPago

            f.txtProv.Text = lblProv.Text
            f.txtChequeNombre.text = lblProv.Text
            f.txtChequeNombre.SelectAll()
            f.txtProvID.Text = lblProvID.Text
            f.txtCodigoProveedor.Text = Me.etCodigoProveedor.Text
            f.Banco = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1)
            f.BancoID = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 0)
            f.txtBanco.Text = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1)
            f.SubTotal = Me.SubTotal
            f.Monto_IR_Pagado_Alcaldia = Me.Monto_IR_Pagado_Alcaldia
            f.Monto_IR_Pagado = Me.Monto_IR_Pagado
            F.MontoIRxPagar = Me.MontoIRxPagar

            f.IRPagado = Me.IRPagado
            f.IVAAsumido = Me.IVAAsumido

            f.SegundoIR = SegundoIR

            f.CompFact = Me.CompFact

            f.SubTotalIRxPagar = SubTotalIRxPagar


            F.MontoIRxPagar = Me.MontoIRxPagar
            f.MontoIVAasumido = Me.MontoIVAasumido

            f.Moneda = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 7)



            f.txtFact.Text = lblFact.Text
            f.txtValor.Text = CDbl(lblFactMonto.Text).ToString(Round)
            'f.dtFecha.Value = Me.etFecha.Text

            F.FechaFactura = Me.etFecha.Text

            f.txtCheque.Text = CatBancos.GetCheque(Registro, dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 3))
            f.MdiParent = Me.MdiParent
            f.Show()
            Exit Sub

        End If





    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim resp As DialogResult
        Dim Bancos As New VB.SysContab.BancosDB()

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Banco que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que dese borrar el Banco: " & dgBancos.Item(dgBancos.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = DialogResult.No Then
            Exit Sub
        End If

        Bancos.Delete(dgBancos.Item(dgBancos.CurrentRowIndex, 0))

        MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As New DataTable()
        'Dim f As New frmGrupos()
        Dim ds As New DataSet()

        ds = Bancos.GetList

        dgBancos.DataSource = Bancos.GetList().Tables("Bancos").DefaultView
        Tabla = ds.Tables("Bancos")

        If ds.Tables("Bancos").Rows.Count = 0 Then
            Registro = "Vacio"

        End If

        r.FormatGenerico(dgBancos, Tabla)

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

    Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.MouseEnter
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

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes()
        'Dim rBancos As New rptBancos()
        Dim rBancos As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rBancos.Load(Application.StartupPath & "\Reportes\rptBancos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        '
        Dim Bancos As New VB.SysContab.BancosDB()
        Dim r As New VB.SysContab.Rutinas()

        rBancos.SetDataSource(Bancos.GetListReporte(txtBuscar.Text, EmpresaActual))
        fReportes.crvReportes.ReportSource = rBancos
        fReportes.Show()

    End Sub

End Class
