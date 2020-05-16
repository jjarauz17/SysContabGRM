Public Class frmFacturasVencidas
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmFacturasVencidas = Nothing

    Public Shared Function Instance() As frmFacturasVencidas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmFacturasVencidas()
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
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgFacturasClientes As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.dgFacturasClientes = New System.Windows.Forms.DataGrid()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgFacturasClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etDescripcion.Location = New System.Drawing.Point(14, 17)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(776, 22)
        Me.etDescripcion.TabIndex = 119
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.dgFacturasClientes)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 508)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(16, 465)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'dgFacturasClientes
        '
        Me.dgFacturasClientes.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
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
        Me.dgFacturasClientes.Location = New System.Drawing.Point(8, 17)
        Me.dgFacturasClientes.Name = "dgFacturasClientes"
        Me.dgFacturasClientes.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgFacturasClientes.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgFacturasClientes.ReadOnly = True
        Me.dgFacturasClientes.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgFacturasClientes.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturasClientes.Size = New System.Drawing.Size(976, 440)
        Me.dgFacturasClientes.TabIndex = 9
        '
        'frmFacturasVencidas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 550)
        Me.Controls.Add(Me.etDescripcion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFacturasVencidas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgFacturasClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim DetallesCliente As New VB.SysContab.ClientesDetails()
    'Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    Dim r As New VB.SysContab.Rutinas()

    Private Sub frmFacturasVencidas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabla As DataTable
        Dim ds As DataSet
        'Dim dsFormaPago As DataSet
        Dim i As Integer

        r.FormularioColor(Me)
        'r.CambiarEstilo(Me)

        'dsFormaPago = FormaPago.FormaPagoList()

        DetallesCliente = VB.SysContab.ClientesDB.GetDetails(RegistroCliente)
        etDescripcion.Text = "Facturas Vencidas del Cliente:  " & DetallesCliente.Nombre
        etDescripcion.BackColor = Color.FromArgb(102, 153, 153)
        etDescripcion.ForeColor = etDescripcion.ForeColor.White

        ds = Clientes.FacturasVencidas(RegistroCliente, TipoFacturaCliente, Fecha1, Fecha2)

        dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
        Tabla = ds.Tables("Facturas_Ventas")

        r.FormatGenerico(dgFacturasClientes, Tabla)

        dgFacturasClientes.CaptionText = "          Información de Facturas Vencidas"
        Me.Text = "Facturas Vencidas de Clientes"
        Me.Refresh()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub dgFacturasClientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturasClientes.DoubleClick
        Dim f As DataGridTextBoxCombo.frmFacturacionClienteVer = f.Instance
        Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)

        If Registro = "Vacio" Then
            MsgBox("Seleccione la Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub
End Class
