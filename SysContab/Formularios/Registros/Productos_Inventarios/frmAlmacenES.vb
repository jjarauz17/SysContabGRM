Public Class frmAlmacenES
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAlmacenES = Nothing

    Public Shared Function Instance() As frmAlmacenES
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAlmacenES()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalidaVenta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalidaDevolucion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEntradaDevolucion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEntradaCompra As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents etSalidas As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents etEntradas As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents etDestino As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlmacenES))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.etEntradas = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.etSalidas = New System.Windows.Forms.Label
        Me.cmdSalidaDevolucion = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalidaVenta = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEntradaDevolucion = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEntradaCompra = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.etDestino = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.cmdSalidaDevolucion)
        Me.GroupBox1.Controls.Add(Me.cmdSalidaVenta)
        Me.GroupBox1.Controls.Add(Me.cmdEntradaDevolucion)
        Me.GroupBox1.Controls.Add(Me.cmdEntradaCompra)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(200, 198)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 316)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(152, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 94)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 157
        Me.PictureBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.etEntradas)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 34)
        Me.GroupBox2.TabIndex = 156
        Me.GroupBox2.TabStop = False
        '
        'etEntradas
        '
        Me.etEntradas.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etEntradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etEntradas.ForeColor = System.Drawing.Color.White
        Me.etEntradas.Location = New System.Drawing.Point(0, 9)
        Me.etEntradas.Name = "etEntradas"
        Me.etEntradas.Size = New System.Drawing.Size(128, 21)
        Me.etEntradas.TabIndex = 113
        Me.etEntradas.Text = "ENTRADAS"
        Me.etEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.etSalidas)
        Me.GroupBox5.Location = New System.Drawing.Point(312, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(128, 34)
        Me.GroupBox5.TabIndex = 155
        Me.GroupBox5.TabStop = False
        '
        'etSalidas
        '
        Me.etSalidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etSalidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etSalidas.ForeColor = System.Drawing.Color.White
        Me.etSalidas.Location = New System.Drawing.Point(0, 9)
        Me.etSalidas.Name = "etSalidas"
        Me.etSalidas.Size = New System.Drawing.Size(128, 21)
        Me.etSalidas.TabIndex = 113
        Me.etSalidas.Text = "SALIDAS"
        Me.etSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdSalidaDevolucion
        '
        Me.cmdSalidaDevolucion.Location = New System.Drawing.Point(312, 182)
        Me.cmdSalidaDevolucion.Name = "cmdSalidaDevolucion"
        Me.cmdSalidaDevolucion.Size = New System.Drawing.Size(248, 51)
        Me.cmdSalidaDevolucion.TabIndex = 2
        Me.cmdSalidaDevolucion.Text = "SALIDA POR DEVOLUCIONES A PROVEEDORES"
        '
        'cmdSalidaVenta
        '
        Me.cmdSalidaVenta.Location = New System.Drawing.Point(312, 112)
        Me.cmdSalidaVenta.Name = "cmdSalidaVenta"
        Me.cmdSalidaVenta.Size = New System.Drawing.Size(248, 52)
        Me.cmdSalidaVenta.TabIndex = 1
        Me.cmdSalidaVenta.Text = "SALIDA POR VENTAS"
        '
        'cmdEntradaDevolucion
        '
        Me.cmdEntradaDevolucion.Location = New System.Drawing.Point(16, 182)
        Me.cmdEntradaDevolucion.Name = "cmdEntradaDevolucion"
        Me.cmdEntradaDevolucion.Size = New System.Drawing.Size(248, 51)
        Me.cmdEntradaDevolucion.TabIndex = 2
        Me.cmdEntradaDevolucion.Text = "ENTRADA POR DEVOLUCIONES DE CLIENTES"
        '
        'cmdEntradaCompra
        '
        Me.cmdEntradaCompra.Location = New System.Drawing.Point(16, 112)
        Me.cmdEntradaCompra.Name = "cmdEntradaCompra"
        Me.cmdEntradaCompra.Size = New System.Drawing.Size(248, 52)
        Me.cmdEntradaCompra.TabIndex = 1
        Me.cmdEntradaCompra.Text = "ENTRADA POR COMPRAS"
        '
        'cmdSalir
        '
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.Appearance.Options.UseForeColor = True
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(160, 250)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(248, 52)
        Me.cmdSalir.TabIndex = 154
        Me.cmdSalir.Text = "SALIR"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(448, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 156
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(200, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(568, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 155
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(200, 164)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(568, 34)
        Me.GroupBox3.TabIndex = 158
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(568, 21)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "ALMACEN E/S"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etDestino
        '
        Me.etDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDestino.ForeColor = System.Drawing.Color.White
        Me.etDestino.Location = New System.Drawing.Point(32, 52)
        Me.etDestino.Name = "etDestino"
        Me.etDestino.Size = New System.Drawing.Size(128, 21)
        Me.etDestino.TabIndex = 159
        Me.etDestino.Text = "Destino"
        Me.etDestino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.etDestino.Visible = False
        '
        'frmAlmacenES
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.etDestino)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAlmacenES"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdEntradaDevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntradaDevolucion.Click
        Dim f As frmDevolucionesClienteList = f.Instance
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdSalidaVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalidaVenta.Click
        Dim f As frmSalidaBodedaFacturas = frmSalidaBodedaFacturas.Instance
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdEntradaCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntradaCompra.Click
        Dim f As frmFacturasComprasEntrada = frmFacturasComprasEntrada.Instance
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.Destino = Me.etDestino.Text
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdSalidaDevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalidaDevolucion.Click
        Dim f As frmDevolucionesProveedorList = frmDevolucionesProveedorList.Instance
        f.Proveedor = 0
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmAlmacenES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
    End Sub

End Class
