Public Class frmFacturasComprasLista
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmFacturasComprasLista = Nothing

    Public Shared Function Instance() As frmFacturasComprasLista
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmFacturasComprasLista()
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
    Friend WithEvents dgFacturasClientes As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents etProveedor As System.Windows.Forms.Label
    Friend WithEvents etTipoPago As System.Windows.Forms.Label
    Friend WithEvents etFecha1 As System.Windows.Forms.Label
    Friend WithEvents etFecha2 As System.Windows.Forms.Label
    Friend WithEvents etEstado As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents etEstado1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgFacturasClientes = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.etTipoPago = New System.Windows.Forms.Label()
        Me.etProveedor = New System.Windows.Forms.Label()
        Me.etEstado = New System.Windows.Forms.Label()
        Me.etFecha2 = New System.Windows.Forms.Label()
        Me.etFecha1 = New System.Windows.Forms.Label()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.etEstado1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgFacturasClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgFacturasClientes
        '
        Me.dgFacturasClientes.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgFacturasClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFacturasClientes.BackColor = System.Drawing.Color.Gainsboro
        Me.dgFacturasClientes.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgFacturasClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgFacturasClientes.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgFacturasClientes.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturasClientes.CaptionForeColor = System.Drawing.Color.Black
        Me.dgFacturasClientes.DataMember = ""
        Me.dgFacturasClientes.FlatMode = True
        Me.dgFacturasClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturasClientes.ForeColor = System.Drawing.Color.Black
        Me.dgFacturasClientes.GridLineColor = System.Drawing.Color.Silver
        Me.dgFacturasClientes.HeaderBackColor = System.Drawing.Color.Black
        Me.dgFacturasClientes.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturasClientes.HeaderForeColor = System.Drawing.Color.White
        Me.dgFacturasClientes.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgFacturasClientes.Location = New System.Drawing.Point(8, 9)
        Me.dgFacturasClientes.Name = "dgFacturasClientes"
        Me.dgFacturasClientes.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgFacturasClientes.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgFacturasClientes.ReadOnly = True
        Me.dgFacturasClientes.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgFacturasClientes.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturasClientes.Size = New System.Drawing.Size(976, 183)
        Me.dgFacturasClientes.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.etTipoPago)
        Me.GroupBox1.Controls.Add(Me.etProveedor)
        Me.GroupBox1.Controls.Add(Me.dgFacturasClientes)
        Me.GroupBox1.Controls.Add(Me.etEstado)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 227)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'etTipoPago
        '
        Me.etTipoPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTipoPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etTipoPago.Location = New System.Drawing.Point(264, 195)
        Me.etTipoPago.Name = "etTipoPago"
        Me.etTipoPago.Size = New System.Drawing.Size(136, 22)
        Me.etTipoPago.TabIndex = 117
        Me.etTipoPago.Text = "Tipo Pago"
        Me.etTipoPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etTipoPago.Visible = False
        '
        'etProveedor
        '
        Me.etProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etProveedor.Location = New System.Drawing.Point(120, 195)
        Me.etProveedor.Name = "etProveedor"
        Me.etProveedor.Size = New System.Drawing.Size(136, 22)
        Me.etProveedor.TabIndex = 116
        Me.etProveedor.Text = "Proveedor"
        Me.etProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etProveedor.Visible = False
        '
        'etEstado
        '
        Me.etEstado.BackColor = System.Drawing.SystemColors.Control
        Me.etEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etEstado.ForeColor = System.Drawing.Color.Black
        Me.etEstado.Location = New System.Drawing.Point(416, 195)
        Me.etEstado.Name = "etEstado"
        Me.etEstado.Size = New System.Drawing.Size(184, 22)
        Me.etEstado.TabIndex = 120
        Me.etEstado.Text = "Estado"
        Me.etEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etEstado.Visible = False
        '
        'etFecha2
        '
        Me.etFecha2.BackColor = System.Drawing.SystemColors.Control
        Me.etFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etFecha2.ForeColor = System.Drawing.Color.Black
        Me.etFecha2.Location = New System.Drawing.Point(280, 43)
        Me.etFecha2.Name = "etFecha2"
        Me.etFecha2.Size = New System.Drawing.Size(136, 26)
        Me.etFecha2.TabIndex = 119
        Me.etFecha2.Text = "Fecha2"
        '
        'etFecha1
        '
        Me.etFecha1.BackColor = System.Drawing.SystemColors.Control
        Me.etFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etFecha1.ForeColor = System.Drawing.Color.Black
        Me.etFecha1.Location = New System.Drawing.Point(72, 43)
        Me.etFecha1.Name = "etFecha1"
        Me.etFecha1.Size = New System.Drawing.Size(136, 26)
        Me.etFecha1.TabIndex = 118
        Me.etFecha1.Text = "Fecha1"
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etDescripcion.Location = New System.Drawing.Point(16, 9)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(776, 21)
        Me.etDescripcion.TabIndex = 115
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(224, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 26)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Hasta:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 26)
        Me.Label4.TabIndex = 158
        Me.Label4.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(432, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 26)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Estado:"
        '
        'etEstado1
        '
        Me.etEstado1.BackColor = System.Drawing.SystemColors.Control
        Me.etEstado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etEstado1.ForeColor = System.Drawing.Color.Black
        Me.etEstado1.Location = New System.Drawing.Point(496, 43)
        Me.etEstado1.Name = "etEstado1"
        Me.etEstado1.Size = New System.Drawing.Size(208, 26)
        Me.etEstado1.TabIndex = 161
        Me.etEstado1.Text = "Estado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmdAyuda)
        Me.GroupBox2.Controls.Add(Me.cmdModificar)
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1000, 60)
        Me.GroupBox2.TabIndex = 162
        Me.GroupBox2.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(96, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 8
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(8, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 10
        Me.cmdModificar.Text = "&Ver Factura"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(192, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'frmFacturasComprasLista
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 368)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.etEstado1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.etDescripcion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.etFecha1)
        Me.Controls.Add(Me.etFecha2)
        Me.Name = "frmFacturasComprasLista"
        CType(Me.dgFacturasClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Dim Proveedor As New VB.SysContab.ProveedoresDB()
    Dim ProveedorDetalle As New VB.SysContab.ProveedoresDetails()
    Dim Facturas As New VB.SysContab.Facturas_ComprasDB()
    'Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim ds As DataSet

    Private Sub frmFacturasComprasLista_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabla As DataTable
        'Dim dsFormaPago As DataSet
        Dim i As Integer

        r.FormularioColor(Me)
        'r.CambiarEstilo(Me)

        'dsFormaPago = FormaPago.FormaPagoList()
        Try
            ProveedorDetalle = VB.SysContab.ProveedoresDB.GetDetails(Me.etProveedor.Text)

            ds = Facturas.FacturasList(Me.etProveedor.Text, Me.etTipoPago.Text, Me.etFecha1.Text, Me.etFecha2.Text, Me.etEstado.Text)

            dgFacturasClientes.DataSource = ds.Tables("Facturas_Compras").DefaultView
            Tabla = ds.Tables("Facturas_Compras")

            r.FormatGenerico(dgFacturasClientes, Tabla)

            dgFacturasClientes.CaptionText = "          Información de Facturas de Proveedor"

            If Me.etEstado.Text = "T" Then
                Me.etEstado1.Text = "Todas"
            ElseIf Me.etEstado.Text = "P" Then
                Me.etEstado1.Text = "Pendientes"
            ElseIf Me.etEstado.Text = "V" Then
                Me.etEstado1.Text = "Vencidas"
            End If

            etDescripcion.Text = "Facturas del Proveedor:  " & ProveedorDetalle.Nombre
            etDescripcion.BackColor = Color.FromArgb(102, 153, 153)
            etDescripcion.ForeColor = etDescripcion.ForeColor.White

            Me.Text = "F a c t u r a s  de  P r o v e e d o r e s"
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        'If Me.dgFacturasClientes.CurrentRowIndex = ds.Tables("Facturas_Compras").Rows.Count - 1 Then
        '    MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
        '    Exit Sub
        'End If


        'Dim f As DataGridTextBoxCombo.frmFacturasCompraVer = f.Instance

        'f.txtFactura.Text = Me.dgFacturasClientes.Item(Me.dgFacturasClientes.CurrentRowIndex, 0)
        'f.txtProveedor.Text = Me.dgFacturasClientes.Item(Me.dgFacturasClientes.CurrentRowIndex, 10)
        'f.etDestino.Text = "1"
        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdAyuda_Click(sender As Object, e As EventArgs) Handles cmdAyuda.Click

    End Sub
End Class
