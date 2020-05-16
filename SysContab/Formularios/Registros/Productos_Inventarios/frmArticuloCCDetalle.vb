Public Class frmArticuloCCDetalle
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmArticuloCCDetalle = Nothing

    Public Shared Function Instance() As frmArticuloCCDetalle
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmArticuloCCDetalle()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents etCodigo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents etUltimaVenta As System.Windows.Forms.Label
    Friend WithEvents etUltimaCompra As System.Windows.Forms.Label
    Friend WithEvents etStockMax As System.Windows.Forms.Label
    Friend WithEvents etStockMin As System.Windows.Forms.Label
    Friend WithEvents etExistencias As System.Windows.Forms.Label
    Friend WithEvents etPrecio As System.Windows.Forms.Label
    Friend WithEvents etLinea As System.Windows.Forms.Label
    Friend WithEvents etProveedor As System.Windows.Forms.Label
    Friend WithEvents etNombre As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbGrafico As System.Windows.Forms.GroupBox
    Friend WithEvents cmdOcultarGrafico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chtAcumulados As AxMSChart20Lib.AxMSChart
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgArticuloCCAcumulado As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticuloCCDetalle))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.etUltimaVenta = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.etUltimaCompra = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.etStockMax = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.etStockMin = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.etExistencias = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.etPrecio = New System.Windows.Forms.Label
        Me.etLinea = New System.Windows.Forms.Label
        Me.etProveedor = New System.Windows.Forms.Label
        Me.etNombre = New System.Windows.Forms.Label
        Me.etCodigo = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgArticuloCCAcumulado = New System.Windows.Forms.DataGrid
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.gbGrafico = New System.Windows.Forms.GroupBox
        Me.cmdOcultarGrafico = New DevExpress.XtraEditors.SimpleButton
        Me.chtAcumulados = New AxMSChart20Lib.AxMSChart
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgArticuloCCAcumulado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGrafico.SuspendLayout()
        CType(Me.chtAcumulados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.etUltimaVenta)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.etUltimaCompra)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.etStockMax)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.etStockMin)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.etExistencias)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.etPrecio)
        Me.GroupBox1.Controls.Add(Me.etLinea)
        Me.GroupBox1.Controls.Add(Me.etProveedor)
        Me.GroupBox1.Controls.Add(Me.etNombre)
        Me.GroupBox1.Controls.Add(Me.etCodigo)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'etUltimaVenta
        '
        Me.etUltimaVenta.BackColor = System.Drawing.Color.Transparent
        Me.etUltimaVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etUltimaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etUltimaVenta.ForeColor = System.Drawing.Color.Black
        Me.etUltimaVenta.Location = New System.Drawing.Point(584, 112)
        Me.etUltimaVenta.Name = "etUltimaVenta"
        Me.etUltimaVenta.Size = New System.Drawing.Size(192, 22)
        Me.etUltimaVenta.TabIndex = 185
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(464, 112)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 17)
        Me.Label20.TabIndex = 184
        Me.Label20.Text = "Ultima Venta"
        '
        'etUltimaCompra
        '
        Me.etUltimaCompra.BackColor = System.Drawing.Color.Transparent
        Me.etUltimaCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etUltimaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etUltimaCompra.ForeColor = System.Drawing.Color.Black
        Me.etUltimaCompra.Location = New System.Drawing.Point(584, 86)
        Me.etUltimaCompra.Name = "etUltimaCompra"
        Me.etUltimaCompra.Size = New System.Drawing.Size(192, 22)
        Me.etUltimaCompra.TabIndex = 183
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(464, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 26)
        Me.Label18.TabIndex = 182
        Me.Label18.Text = "Ultima Compra"
        '
        'etStockMax
        '
        Me.etStockMax.BackColor = System.Drawing.Color.Transparent
        Me.etStockMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etStockMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etStockMax.ForeColor = System.Drawing.Color.Black
        Me.etStockMax.Location = New System.Drawing.Point(584, 60)
        Me.etStockMax.Name = "etStockMax"
        Me.etStockMax.Size = New System.Drawing.Size(88, 22)
        Me.etStockMax.TabIndex = 175
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(464, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 26)
        Me.Label11.TabIndex = 174
        Me.Label11.Text = "Stock Máximo"
        '
        'etStockMin
        '
        Me.etStockMin.BackColor = System.Drawing.Color.Transparent
        Me.etStockMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etStockMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etStockMin.ForeColor = System.Drawing.Color.Black
        Me.etStockMin.Location = New System.Drawing.Point(584, 34)
        Me.etStockMin.Name = "etStockMin"
        Me.etStockMin.Size = New System.Drawing.Size(88, 22)
        Me.etStockMin.TabIndex = 173
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(464, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 26)
        Me.Label9.TabIndex = 172
        Me.Label9.Text = "Stock Mínimo"
        '
        'etExistencias
        '
        Me.etExistencias.BackColor = System.Drawing.Color.Transparent
        Me.etExistencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etExistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etExistencias.ForeColor = System.Drawing.Color.Black
        Me.etExistencias.Location = New System.Drawing.Point(584, 9)
        Me.etExistencias.Name = "etExistencias"
        Me.etExistencias.Size = New System.Drawing.Size(88, 21)
        Me.etExistencias.TabIndex = 171
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(464, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 25)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "Existencias"
        '
        'etPrecio
        '
        Me.etPrecio.BackColor = System.Drawing.Color.Transparent
        Me.etPrecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etPrecio.ForeColor = System.Drawing.Color.Black
        Me.etPrecio.Location = New System.Drawing.Point(112, 112)
        Me.etPrecio.Name = "etPrecio"
        Me.etPrecio.Size = New System.Drawing.Size(112, 22)
        Me.etPrecio.TabIndex = 169
        '
        'etLinea
        '
        Me.etLinea.BackColor = System.Drawing.Color.Transparent
        Me.etLinea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etLinea.ForeColor = System.Drawing.Color.Black
        Me.etLinea.Location = New System.Drawing.Point(112, 86)
        Me.etLinea.Name = "etLinea"
        Me.etLinea.Size = New System.Drawing.Size(336, 22)
        Me.etLinea.TabIndex = 167
        '
        'etProveedor
        '
        Me.etProveedor.BackColor = System.Drawing.Color.Transparent
        Me.etProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etProveedor.ForeColor = System.Drawing.Color.Black
        Me.etProveedor.Location = New System.Drawing.Point(112, 60)
        Me.etProveedor.Name = "etProveedor"
        Me.etProveedor.Size = New System.Drawing.Size(336, 22)
        Me.etProveedor.TabIndex = 166
        '
        'etNombre
        '
        Me.etNombre.BackColor = System.Drawing.Color.Transparent
        Me.etNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNombre.ForeColor = System.Drawing.Color.Black
        Me.etNombre.Location = New System.Drawing.Point(112, 34)
        Me.etNombre.Name = "etNombre"
        Me.etNombre.Size = New System.Drawing.Size(336, 22)
        Me.etNombre.TabIndex = 165
        '
        'etCodigo
        '
        Me.etCodigo.BackColor = System.Drawing.Color.Transparent
        Me.etCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCodigo.ForeColor = System.Drawing.Color.Black
        Me.etCodigo.Location = New System.Drawing.Point(112, 9)
        Me.etCodigo.Name = "etCodigo"
        Me.etCodigo.Size = New System.Drawing.Size(128, 21)
        Me.etCodigo.TabIndex = 162
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(16, 112)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 17)
        Me.Label27.TabIndex = 158
        Me.Label27.Text = "Precio"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(16, 86)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 26)
        Me.Label25.TabIndex = 154
        Me.Label25.Text = "Línea"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(16, 60)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 26)
        Me.Label24.TabIndex = 152
        Me.Label24.Text = "Proveedor"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(16, 34)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 26)
        Me.Label23.TabIndex = 150
        Me.Label23.Text = "Descripción"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(16, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 25)
        Me.Label22.TabIndex = 148
        Me.Label22.Text = "Código"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dgArticuloCCAcumulado)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 376)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(72, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 17)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "                            ENTRADAS                     SALIDAS"
        Me.Label2.Visible = False
        '
        'dgArticuloCCAcumulado
        '
        Me.dgArticuloCCAcumulado.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgArticuloCCAcumulado.BackColor = System.Drawing.Color.Gainsboro
        Me.dgArticuloCCAcumulado.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgArticuloCCAcumulado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgArticuloCCAcumulado.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgArticuloCCAcumulado.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgArticuloCCAcumulado.CaptionForeColor = System.Drawing.Color.Black
        Me.dgArticuloCCAcumulado.DataMember = ""
        Me.dgArticuloCCAcumulado.FlatMode = True
        Me.dgArticuloCCAcumulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgArticuloCCAcumulado.ForeColor = System.Drawing.Color.Black
        Me.dgArticuloCCAcumulado.GridLineColor = System.Drawing.Color.Silver
        Me.dgArticuloCCAcumulado.HeaderBackColor = System.Drawing.Color.Black
        Me.dgArticuloCCAcumulado.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgArticuloCCAcumulado.HeaderForeColor = System.Drawing.Color.White
        Me.dgArticuloCCAcumulado.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgArticuloCCAcumulado.Location = New System.Drawing.Point(8, 9)
        Me.dgArticuloCCAcumulado.Name = "dgArticuloCCAcumulado"
        Me.dgArticuloCCAcumulado.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgArticuloCCAcumulado.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgArticuloCCAcumulado.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgArticuloCCAcumulado.SelectionForeColor = System.Drawing.Color.White
        Me.dgArticuloCCAcumulado.Size = New System.Drawing.Size(416, 342)
        Me.dgArticuloCCAcumulado.TabIndex = 119
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Location = New System.Drawing.Point(464, 342)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 22
        Me.cmdCancelar.Text = "Salir"
        '
        'gbGrafico
        '
        Me.gbGrafico.Controls.Add(Me.cmdCancelar)
        Me.gbGrafico.Controls.Add(Me.cmdOcultarGrafico)
        Me.gbGrafico.Controls.Add(Me.chtAcumulados)
        Me.gbGrafico.Location = New System.Drawing.Point(448, 138)
        Me.gbGrafico.Name = "gbGrafico"
        Me.gbGrafico.Size = New System.Drawing.Size(568, 376)
        Me.gbGrafico.TabIndex = 121
        Me.gbGrafico.TabStop = False
        '
        'cmdOcultarGrafico
        '
        Me.cmdOcultarGrafico.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOcultarGrafico.Appearance.Options.UseFont = True
        Me.cmdOcultarGrafico.Location = New System.Drawing.Point(400, 465)
        Me.cmdOcultarGrafico.Name = "cmdOcultarGrafico"
        Me.cmdOcultarGrafico.Size = New System.Drawing.Size(72, 26)
        Me.cmdOcultarGrafico.TabIndex = 120
        Me.cmdOcultarGrafico.Text = "Salir"
        '
        'chtAcumulados
        '
        Me.chtAcumulados.DataSource = Nothing
        Me.chtAcumulados.Location = New System.Drawing.Point(3, 17)
        Me.chtAcumulados.Name = "chtAcumulados"
        Me.chtAcumulados.OcxState = CType(resources.GetObject("chtAcumulados.OcxState"), System.Windows.Forms.AxHost.State)
        Me.chtAcumulados.Size = New System.Drawing.Size(557, 334)
        Me.chtAcumulados.TabIndex = 119
        '
        'frmArticuloCCDetalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1032, 518)
        Me.Controls.Add(Me.gbGrafico)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmArticuloCCDetalle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgArticuloCCAcumulado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGrafico.ResumeLayout(False)
        CType(Me.chtAcumulados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Dim Articulos As New VB.SysContab.ArticulosDB()
    'Dim ArticulosDetalles As New VB.SysContab.ArticulosDetails()

    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Dim ProveedoresDetalles As New VB.SysContab.ProveedoresDetails()

    Dim Grupos As New VB.SysContab.Grupos_InventarioDB()
    Dim GruposDetalles As New VB.SysContab.Grupos_InventarioDetails()

    Dim r As New VB.SysContab.Rutinas()
    Dim ds As DataSet

    Public GruposCC As New VB.SysContab.GruposCCDB()
    Private Sub frmArticuloCCDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ArticulosDetalles = VB.SysContab.ArticulosDB.GetDetails(Registro, "P", EmpresaActual)
        'etCodigo.Text = ArticulosDetalles.Codigo
        'etNombre.Text = ArticulosDetalles.Nombre

        'ProveedoresDetalles = VB.SysContab.ProveedoresDB.GetDetails(ArticulosDetalles.Proveedor)
        'etProveedor.Text = ProveedoresDetalles.Nombre

        'GruposDetalles = Grupos.GetDetails(ArticulosDetalles.Linea, ArticulosDetalles.Tipo)
        'etLinea.Text = GruposDetalles.Nombre

        'etPrecio.Text = CDbl(ArticulosDetalles.Precio_Venta_Cordobas).ToString(Round)

        'etExistencias.Text = ArticulosDetalles.Existencia
        'etStockMin.Text = ArticulosDetalles.Stock_Min
        'etStockMax.Text = ArticulosDetalles.Stock_Max

        'etDescuentoA.Text = ArticulosDetalles.Descuento_A & "%"
        'etDescuentoB.Text = ArticulosDetalles.Descuento_B & "%"
        'etDescuentoC.Text = ArticulosDetalles.Descuento_C & "%"

        ''etUltimaCompra.Text = ""

        'If Articulos.ArticulosUltimaCompra(ArticulosDetalles.Codigo, ArticulosDetalles.Tipo).Tables("Facturas_Compras_Lineas").Rows.Count > 0 Then
        '    etUltimaCompra.Text = Articulos.ArticulosUltimaCompra(ArticulosDetalles.Codigo, ArticulosDetalles.Tipo).Tables("Facturas_Compras_Lineas").Rows(0).Item("Fecha")
        'Else
        '    etUltimaCompra.Text = ""
        'End If

        'If Articulos.ArticulosUltimaVenta(ArticulosDetalles.Codigo, ArticulosDetalles.Tipo).Tables("Facturas_Ventas_Lineas").Rows.Count > 0 Then
        '    etUltimaVenta.Text = Articulos.ArticulosUltimaVenta(ArticulosDetalles.Codigo, ArticulosDetalles.Tipo).Tables("Facturas_Ventas_Lineas").Rows(0).Item("Fecha")
        'Else
        '    etUltimaVenta.Text = ""
        'End If

        Dim Tabla As DataTable

        'Detalles = Producto.GetDetails(Registro, EmpresaActual)
        'dgAcumuladosProductos1.CaptionText = "Acumulados por Producto"
        'Me.Text = "Detalle"
        'etDescripcion.Text = Detalles.Nombre.ToUpper

        'r.CambiarEstilo(Me)

        ds = GruposCC.ArticuloAcumulado(Me.etCodigo.Text)

        'ds.Tables("Ventas").DefaultView.AllowDelete = False
        'ds.Tables("Ventas").DefaultView.AllowNew = False
        'ds.Tables("Ventas").DefaultView.AllowEdit = False

        dgArticuloCCAcumulado.DataSource = ds.Tables("GruposCC").DefaultView 'Acumulados.GetList(Registro).Tables("Acumulados").DefaultView
        Tabla = ds.Tables("GruposCC")

        r.FormatGenerico(dgArticuloCCAcumulado, Tabla)

        dgArticuloCCAcumulado.Refresh()

        Me.dgArticuloCCAcumulado.ReadOnly = True
        Me.dgArticuloCCAcumulado.CaptionVisible = False

        dgArticuloCCAcumulado.AllowSorting = False

        MostrarGrafico()

        Me.Refresh()

    End Sub

    Private Sub frmDetalleArticulo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Registro = "Vacio"
    End Sub

    Private Sub MostrarGrafico()
        Dim i As Integer

        'Monto_Mes.Clear()
        'Debe.Clear()
        'Haber.Clear()
        'Saldo.Clear()

        'For i = 0 To dgCatalogoAcumulados.VisibleRowCount - 2
        '    'Monto_Mes.Add(dgCatalogoAcumulados.Item(i, 2))
        '    Debe.Add(dgCatalogoAcumulados.Item(i, 2))
        '    Haber.Add(dgCatalogoAcumulados.Item(i, 3))
        '    Saldo.Add(dgCatalogoAcumulados.Item(i, 4))

        'Next

        chtAcumulados.Visible = True

        Dim AcumuladosGrafico(,) As Object = New Object(,) _
            {{"CP", "Entradas", "Salidas"}, _
            {ds.Tables("GruposCC").Rows(0).Item("Mes"), ds.Tables("GruposCC").Rows(0).Item("Entradas"), ds.Tables("GruposCC").Rows(0).Item("Salidas")}, _
            {ds.Tables("GruposCC").Rows(1).Item("Mes"), ds.Tables("GruposCC").Rows(1).Item("Entradas"), ds.Tables("GruposCC").Rows(1).Item("Salidas")}, _
            {ds.Tables("GruposCC").Rows(2).Item("Mes"), ds.Tables("GruposCC").Rows(2).Item("Entradas"), ds.Tables("GruposCC").Rows(2).Item("Salidas")}, _
            {ds.Tables("GruposCC").Rows(3).Item("Mes"), ds.Tables("GruposCC").Rows(3).Item("Entradas"), ds.Tables("GruposCC").Rows(3).Item("Salidas")}, _
            {ds.Tables("GruposCC").Rows(4).Item("Mes"), ds.Tables("GruposCC").Rows(4).Item("Entradas"), ds.Tables("GruposCC").Rows(4).Item("Salidas")}, _
            {ds.Tables("GruposCC").Rows(5).Item("Mes"), ds.Tables("GruposCC").Rows(5).Item("Entradas"), ds.Tables("GruposCC").Rows(5).Item("Salidas")}, _
            {ds.Tables("GruposCC").Rows(6).Item("Mes"), ds.Tables("GruposCC").Rows(6).Item("Entradas"), ds.Tables("GruposCC").Rows(6).Item("Salidas")}, _
            {ds.Tables("GruposCC").Rows(7).Item("Mes"), ds.Tables("GruposCC").Rows(7).Item("Entradas"), ds.Tables("GruposCC").Rows(7).Item("Salidas")}, _
            {ds.Tables("GruposCC").Rows(8).Item("Mes"), ds.Tables("GruposCC").Rows(8).Item("Entradas"), ds.Tables("GruposCC").Rows(8).Item("Salidas")}, _
            {ds.Tables("GruposCC").Rows(9).Item("Mes"), ds.Tables("GruposCC").Rows(9).Item("Entradas"), ds.Tables("GruposCC").Rows(9).Item("Salidas")}, _
            {ds.Tables("GruposCC").Rows(10).Item("Mes"), ds.Tables("GruposCC").Rows(10).Item("Entradas"), ds.Tables("GruposCC").Rows(10).Item("Salidas")}, _
            {ds.Tables("GruposCC").Rows(11).Item("Mes"), ds.Tables("GruposCC").Rows(11).Item("Entradas"), ds.Tables("GruposCC").Rows(11).Item("Salidas")}}

        'ds.Tables("Ventas")

        chtAcumulados.ChartData = AcumuladosGrafico

        chtAcumulados.ShowLegend = True

        'Add a title and legend.
        With Me.chtAcumulados
            '.Title.VtFont.Size = 8
            '.Title.Text = "Entrada y Salida del Producto: " & etNombre.Text
            .Legend.Location.LocationType = _
               MSChart20Lib.VtChLocationType.VtChLocationTypeRight
            .Legend.Location.Visible = True
            '.chartType = MSChart20Lib.VtChChartType.VtChChartType3dBar
            .chartType = MSChart20Lib.VtChChartType.VtChChartType2dBar
            '.SeriesType = MSChart20Lib.VtChSeriesType.VtChSeriesType2dPie
            .Enabled = False
            .ShowLegend = True

        End With

        'Add titles to the axes.
        With Me.chtAcumulados.Plot
            '.Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).AxisTitle.VtFont.Size = 12
            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdY).AxisTitle.VtFont.Size = 12
            '.View3d.Elevation = 0
            '.View3d.Rotation = 90
            .UniformAxis = True

            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdX).AxisTitle.Text = "Mes"
            .Axis(MSChart20Lib.VtChAxisId.VtChAxisIdY).AxisTitle.Text = "Monto"

            .SeriesCollection(1).DataPoints(-1).Brush.FillColor.Set(150, 0, 0)
            .SeriesCollection(2).DataPoints(-1).Brush.FillColor.Set(0, 150, 0)
            '.SeriesCollection(3).DataPoints(-1).Brush.FillColor.Set(0, 0, 150)

            '.SeriesCollection(3).DataPoints(-1).Brush.FillColor.Set(0, 0, 150)

        End With
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

End Class
