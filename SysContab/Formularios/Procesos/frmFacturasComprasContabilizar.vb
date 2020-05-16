Public Class frmFacturasComprasContabilizar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmFacturasComprasContabilizar = Nothing

    Public Shared Function Instance() As frmFacturasComprasContabilizar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmFacturasComprasContabilizar()
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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoProv As System.Windows.Forms.Label
    Friend WithEvents dgProveedores As System.Windows.Forms.DataGrid
    Friend WithEvents etPlantilla As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgProveedores = New System.Windows.Forms.DataGrid()
        Me.lblTipoProv = New System.Windows.Forms.Label()
        Me.etPlantilla = New System.Windows.Forms.Label()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(208, 488)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(112, 488)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 24)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Ayuda"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(16, 488)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(80, 24)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Contabilizar"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(96, 8)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(512, 20)
        Me.txtBuscar.TabIndex = 13
        Me.txtBuscar.Text = ""
        '
        'dgProveedores
        '
        Me.dgProveedores.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgProveedores.BackColor = System.Drawing.Color.Gainsboro
        Me.dgProveedores.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgProveedores.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgProveedores.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgProveedores.CaptionForeColor = System.Drawing.Color.Black
        Me.dgProveedores.DataMember = ""
        Me.dgProveedores.FlatMode = True
        Me.dgProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgProveedores.ForeColor = System.Drawing.Color.Black
        Me.dgProveedores.GridLineColor = System.Drawing.Color.Silver
        Me.dgProveedores.HeaderBackColor = System.Drawing.Color.Black
        Me.dgProveedores.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgProveedores.HeaderForeColor = System.Drawing.Color.White
        Me.dgProveedores.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgProveedores.Location = New System.Drawing.Point(16, 32)
        Me.dgProveedores.Name = "dgProveedores"
        Me.dgProveedores.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgProveedores.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgProveedores.ReadOnly = True
        Me.dgProveedores.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgProveedores.SelectionForeColor = System.Drawing.Color.White
        Me.dgProveedores.Size = New System.Drawing.Size(992, 448)
        Me.dgProveedores.TabIndex = 12
        '
        'lblTipoProv
        '
        Me.lblTipoProv.Location = New System.Drawing.Point(800, 496)
        Me.lblTipoProv.Name = "lblTipoProv"
        Me.lblTipoProv.Size = New System.Drawing.Size(48, 23)
        Me.lblTipoProv.TabIndex = 16
        Me.lblTipoProv.Text = "Label2"
        Me.lblTipoProv.Visible = False
        '
        'etPlantilla
        '
        Me.etPlantilla.Location = New System.Drawing.Point(688, 496)
        Me.etPlantilla.Name = "etPlantilla"
        Me.etPlantilla.TabIndex = 17
        Me.etPlantilla.Text = "Plantilla"
        Me.etPlantilla.Visible = False
        '
        'frmFacturasComprasContabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.etPlantilla, Me.lblTipoProv, Me.Label1, Me.txtBuscar, Me.dgProveedores, Me.cmdSalir, Me.cmdNuevo, Me.cmdBorrar})
        Me.Name = "frmFacturasComprasContabilizar"
        Me.StartPosition = FormStartPosition.CenterScreen
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas()
    Public Fact As String
    Public FactValor As String

    Dim Tabla As DataTable
    Public ds As DataSet

    Private Sub frmFacturasComprasContabilizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim FacturasDB As New VB.SysContab.Facturas_ComprasDB()


        'r.CambiarEstilo(Me)
        r.FormularioColor(Me)

        ds = FacturasDB.GetListxTipoProducto(lblTipoProv.Text)

        dgProveedores.DataSource = ds.Tables("Tablas").DefaultView
        Tabla = ds.Tables("Tablas")

        r.FormatGenerico(dgProveedores, Tabla)

        If ds.Tables("Tablas").Rows.Count <> 0 Then
            Registro = dgProveedores.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        dgProveedores.CaptionText = "Información de Facturas"
        Me.Text = "Facturas"
        Me.Refresh()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        If dgProveedores.Item(dgProveedores.CurrentRowIndex, 2) = "" Then
            MsgBox("Debe asignar una cuenta al Proveedor", MsgBoxStyle.Information)
            Exit Sub
        End If

        Fact = dgProveedores.Item(dgProveedores.CurrentRowIndex, 0)
        FactValor = dgProveedores.Item(dgProveedores.CurrentRowIndex, 9)

        Dim f As DataGridTextBox.frmComprobanteFC = f.Instance
        Dim CatBancos As New VB.SysContab.Catalogo_BancosDB()

        f.etPlantilla.Text = Me.etPlantilla.Text
        f.txtProv.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 3)
        f.txtProvID.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 2)
        f.txtCodigoProveedor.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 10)
        'f.Banco = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1)
        'f.BancoID = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 0)
        'f.txtBanco.Text = Me.dgBancos.Item(Me.dgBancos.CurrentRowIndex, 2)
        f.txtBanco.Visible = False
        ''''f.txtBanco.Text = dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 1)
        f.txtFact.Text = Fact
        f.txtValor.Text = CDbl(FactValor).ToString(Round)
        'f.txtCheque.Text = CatBancos.GetCheque(Registro, dgCatalogoBancos.Item(dgCatalogoBancos.CurrentRowIndex, 3))
        f.txtCheque.Visible = False
        f.MdiParent = Me.MdiParent
        f.etIva.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 8)
        f.etSubTotal.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 7)
        f.Show()
        Exit Sub

        'Dim fr As frmBancosContabilizar = fr.Instance
        'fr.MdiParent = Me.MdiParent

        'fr.etPlantilla.Text = Me.etPlantilla.Text
        'fr.lblProv.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 3)
        'fr.lblProvID.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 2)
        'fr.etCodigoProveedor.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 10)
        'fr.lblFact.Text = Fact
        'fr.lblFactMonto.Text = FactValor
        'fr.etIva.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 8)
        'fr.etSubTotal.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 7)
        'fr.Show()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmListaFacturaProveedores_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

    End Sub

    Private Sub dgFacturasProveedores_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgProveedores.MouseEnter

    End Sub

    Private Sub dgFacturasProveedores_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgProveedores.CurrentCellChanged
        Registro = dgProveedores.Item(dgProveedores.CurrentRowIndex, 0)
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Help.ShowHelp(Me, "ayuda/Procesos/ProcesosContab.chm", HelpNavigator.KeywordIndex, "Sec2.2")
    End Sub
End Class
