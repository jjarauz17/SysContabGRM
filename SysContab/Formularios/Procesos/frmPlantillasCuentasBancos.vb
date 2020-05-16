Public Class frmPlantillasCuentasBancos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmPlantillasCuentasBancos = Nothing

    Public Shared Function Instance() As frmPlantillasCuentasBancos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPlantillasCuentasBancos()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

    Dim cuenta As String
    Dim Cod_Cuenta As String

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgCatalogoBancos As System.Windows.Forms.DataGrid
    Friend WithEvents etNombreBanco As System.Windows.Forms.Label
    Friend WithEvents lblProvID As System.Windows.Forms.Label
    Friend WithEvents lblProv As System.Windows.Forms.Label
    Friend WithEvents lblFactMonto As System.Windows.Forms.Label
    Friend WithEvents lblFact As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgCatalogoBancos = New System.Windows.Forms.DataGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.etNombreBanco = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.lblProvID = New System.Windows.Forms.Label()
        Me.lblProv = New System.Windows.Forms.Label()
        Me.lblFactMonto = New System.Windows.Forms.Label()
        Me.lblFact = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCatalogoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgCatalogoBancos})
        Me.GroupBox1.Location = New System.Drawing.Point(16, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 432)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
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
        Me.dgCatalogoBancos.Location = New System.Drawing.Point(8, 16)
        Me.dgCatalogoBancos.Name = "dgCatalogoBancos"
        Me.dgCatalogoBancos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgCatalogoBancos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCatalogoBancos.ReadOnly = True
        Me.dgCatalogoBancos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgCatalogoBancos.SelectionForeColor = System.Drawing.Color.White
        Me.dgCatalogoBancos.Size = New System.Drawing.Size(888, 408)
        Me.dgCatalogoBancos.TabIndex = 140
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.etNombreBanco, Me.lblFactMonto, Me.lblFact})
        Me.GroupBox2.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(904, 32)
        Me.GroupBox2.TabIndex = 141
        Me.GroupBox2.TabStop = False
        '
        'etNombreBanco
        '
        Me.etNombreBanco.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.etNombreBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNombreBanco.ForeColor = System.Drawing.Color.White
        Me.etNombreBanco.Location = New System.Drawing.Point(0, 8)
        Me.etNombreBanco.Name = "etNombreBanco"
        Me.etNombreBanco.Size = New System.Drawing.Size(896, 20)
        Me.etNombreBanco.TabIndex = 113
        Me.etNombreBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdAyuda, Me.cmdSalir, Me.cmdImprimir, Me.cmdBorrar, Me.lblProvID, Me.lblProv})
        Me.GroupBox3.Location = New System.Drawing.Point(16, 480)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(904, 48)
        Me.GroupBox3.TabIndex = 142
        Me.GroupBox3.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(208, 16)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 24)
        Me.cmdAyuda.TabIndex = 5
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(304, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(112, 16)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 24)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(16, 16)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 24)
        Me.cmdBorrar.TabIndex = 3
        Me.cmdBorrar.Text = "Seleccionar"
        '
        'lblProvID
        '
        Me.lblProvID.Location = New System.Drawing.Point(680, 16)
        Me.lblProvID.Name = "lblProvID"
        Me.lblProvID.TabIndex = 144
        Me.lblProvID.Visible = False
        '
        'lblProv
        '
        Me.lblProv.Location = New System.Drawing.Point(592, 16)
        Me.lblProv.Name = "lblProv"
        Me.lblProv.TabIndex = 143
        Me.lblProv.Visible = False
        '
        'lblFactMonto
        '
        Me.lblFactMonto.Location = New System.Drawing.Point(840, 472)
        Me.lblFactMonto.Name = "lblFactMonto"
        Me.lblFactMonto.TabIndex = 144
        Me.lblFactMonto.Text = "Label3"
        Me.lblFactMonto.Visible = False
        '
        'lblFact
        '
        Me.lblFact.Location = New System.Drawing.Point(768, 8)
        Me.lblFact.Name = "lblFact"
        Me.lblFact.TabIndex = 143
        Me.lblFact.Text = "Label2"
        Me.lblFact.Visible = False
        '
        'frmPlantillasCuentasBancos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox2, Me.GroupBox1})
        Me.Name = "frmPlantillasCuentasBancos"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgCatalogoBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCatalogoBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Catalogo As New VB.SysContab.CatalogoDB()
        Dim Formato_Cheques As New VB.SysContab.Formato_ChequesDB()
        Dim Catalogo_Bancos As New VB.SysContab.Catalogo_BancosDB()
        Dim Banco As New VB.SysContab.BancosDB()
        Dim DetalleBanco As New VB.SysContab.BancosDetails()

        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As DataTable
        Dim ds As DataSet

        'r.CambiarEstilo(Me)

        Me.Text = "Cuentas Contables de Bancos"

        DetalleBanco = Banco.GetDetails(Registro)

        ds = Catalogo_Bancos.GetLista(Registro)

        dgCatalogoBancos.DataSource = Catalogo_Bancos.GetLista(Registro).Tables("CATALOGO_BANCOS").DefaultView
        Tabla = ds.Tables("CATALOGO_BANCOS")

        r.FormatGenerico(dgCatalogoBancos, Tabla)

        Me.Text = "Seleccionar Cuentas de Bancos"

        dgCatalogoBancos.CaptionText = "Cuentas de Banco"

        If Catalogo_Bancos.GetLista(Registro).Tables("CATALOGO_BANCOS").Rows.Count = 0 Then
            CatalogoBancosP = "Vacio"
        Else
            CatalogoBancosP = dgCatalogoBancos.Item(0, 0)

        End If

        Me.etNombreBanco.Text = DetalleBanco.Nombre

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub



    Private Sub cbCatalogo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


    End Sub



    Private Sub cbCatalogo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cuenta = ""

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click


        
        Dim f As DataGridTextBox.frmComprobanteTipo1 = f.Instance

        Dim CatBancos As New VB.SysContab.Catalogo_BancosDB()

        f.txtProv.Text = lblProv.Text
        f.txtProvID.Text = lblProvID.Text
        f.Banco = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1)
        f.BancoID = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 0)
        f.txtBanco.Text = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1)
        f.txtFact.Text = lblFact.Text
        f.txtValor.Text = lblFactMonto.Text
        f.txtCheque.Text = CatBancos.GetCheque(Registro, dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 3))
        f.MdiParent = Me.MdiParent
        f.Show()



        'Dim resp As DialogResult
        'Dim CatalogoBancos As New VB.SysContab.Catalogo_BancosDB()

        'If CatalogoBancosP = "Vacio" Then
        '    MsgBox("Seleccione el registro que desea Borrar", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'resp = MsgBox("Esta seguro que desea borrar la Cuenta Contable " & dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1) & " con No. de Cuenta: " & dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 3), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        'If resp = DialogResult.No Then
        '    Exit Sub
        'End If

        'CatalogoBancos.Delete(dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 0))

        'MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        'Dim r As New VB.SysContab.Rutinas()
        'Dim Tabla As New DataTable()
        ''Dim f As New frmGrupos()
        'Dim ds As New DataSet()

        'ds = CatalogoBancos.GetList(Registro)

        'dgCatalogoBancos.DataSource = CatalogoBancos.GetList(Registro).Tables("CATALOGO_BANCOS").DefaultView
        'Tabla = ds.Tables("CATALOGO_BANCOS")

        'If ds.Tables("CATALOGO_BANCOS").Rows.Count = 0 Then
        '    CatalogoBancosP = "Vacio"
        'Else
        '    CatalogoBancosP = dgCatalogoBancos.Item(0, 0)

        'End If

        'r.FormatGenerico(dgCatalogoBancos, Tabla)

    End Sub

End Class
