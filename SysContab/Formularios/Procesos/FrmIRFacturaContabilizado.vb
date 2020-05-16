Public Class FrmIRFacturaContabilizado
    Inherits DevExpress.XtraEditors.XtraForm

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
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMesAnt As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalIR As System.Windows.Forms.TextBox
    Friend WithEvents txtIRVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIRPagado As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgCompras As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGVentas As System.Windows.Forms.DataGrid
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents rbMes As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMesAnt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalIR = New System.Windows.Forms.TextBox()
        Me.txtIRVenta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIRPagado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCredito = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgCompras = New System.Windows.Forms.DataGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVentas = New System.Windows.Forms.DataGrid()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.rbMes = New System.Windows.Forms.RadioButton()
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(896, 183)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(80, 17)
        Me.LinkLabel1.TabIndex = 213
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ver Detalles"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(896, 19)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(80, 18)
        Me.LinkLabel2.TabIndex = 212
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Ver Detalles"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(872, 526)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 21)
        Me.txtTotal.TabIndex = 210
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(760, 517)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(176, 17)
        Me.Label14.TabIndex = 211
        Me.Label14.Text = "TOTAL A PAGAR"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMesAnt
        '
        Me.txtMesAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMesAnt.Location = New System.Drawing.Point(872, 491)
        Me.txtMesAnt.Name = "txtMesAnt"
        Me.txtMesAnt.ReadOnly = True
        Me.txtMesAnt.Size = New System.Drawing.Size(100, 21)
        Me.txtMesAnt.TabIndex = 209
        Me.txtMesAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(704, 491)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 17)
        Me.Label13.TabIndex = 208
        Me.Label13.Text = "CREDITO MES ANTERIOR"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(896, 448)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 17)
        Me.Label12.TabIndex = 207
        Me.Label12.Text = "TOTAL"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalIR
        '
        Me.txtTotalIR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalIR.Location = New System.Drawing.Point(872, 465)
        Me.txtTotalIR.Name = "txtTotalIR"
        Me.txtTotalIR.ReadOnly = True
        Me.txtTotalIR.Size = New System.Drawing.Size(100, 21)
        Me.txtTotalIR.TabIndex = 206
        Me.txtTotalIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIRVenta
        '
        Me.txtIRVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRVenta.Location = New System.Drawing.Point(480, 465)
        Me.txtIRVenta.Name = "txtIRVenta"
        Me.txtIRVenta.ReadOnly = True
        Me.txtIRVenta.Size = New System.Drawing.Size(100, 21)
        Me.txtIRVenta.TabIndex = 205
        Me.txtIRVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(656, 448)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 17)
        Me.Label11.TabIndex = 204
        Me.Label11.Text = "I.R. PAGADO X ANTICIPADO"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIRPagado
        '
        Me.txtIRPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRPagado.Location = New System.Drawing.Point(704, 465)
        Me.txtIRPagado.Name = "txtIRPagado"
        Me.txtIRPagado.ReadOnly = True
        Me.txtIRPagado.Size = New System.Drawing.Size(100, 21)
        Me.txtIRPagado.TabIndex = 202
        Me.txtIRPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(464, 448)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 17)
        Me.Label8.TabIndex = 201
        Me.Label8.Text = "I.R. SOBRE VENTAS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(272, 422)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(712, 22)
        Me.Label9.TabIndex = 200
        Me.Label9.Text = "DECLARACION DEL MES"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(272, 439)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(712, 112)
        Me.Label10.TabIndex = 203
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCredito
        '
        Me.txtCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredito.Location = New System.Drawing.Point(608, 379)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.ReadOnly = True
        Me.txtCredito.Size = New System.Drawing.Size(100, 21)
        Me.txtCredito.TabIndex = 198
        Me.txtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(536, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 197
        Me.Label4.Text = "CREDITO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(272, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(712, 21)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "SALDO MES ANTERIOR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(272, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(712, 21)
        Me.Label2.TabIndex = 195
        Me.Label2.Text = "I.R. PAGADO POR ANTICIPADO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgCompras
        '
        Me.dgCompras.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgCompras.BackColor = System.Drawing.Color.Gainsboro
        Me.dgCompras.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCompras.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgCompras.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgCompras.CaptionForeColor = System.Drawing.Color.Black
        Me.dgCompras.DataMember = ""
        Me.dgCompras.FlatMode = True
        Me.dgCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCompras.ForeColor = System.Drawing.Color.Black
        Me.dgCompras.GridLineColor = System.Drawing.Color.Silver
        Me.dgCompras.HeaderBackColor = System.Drawing.Color.Black
        Me.dgCompras.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgCompras.HeaderForeColor = System.Drawing.Color.White
        Me.dgCompras.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgCompras.Location = New System.Drawing.Point(272, 181)
        Me.dgCompras.Name = "dgCompras"
        Me.dgCompras.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgCompras.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCompras.ReadOnly = True
        Me.dgCompras.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgCompras.SelectionForeColor = System.Drawing.Color.White
        Me.dgCompras.Size = New System.Drawing.Size(712, 155)
        Me.dgCompras.TabIndex = 194
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(272, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(712, 22)
        Me.Label1.TabIndex = 193
        Me.Label1.Text = "I.R. SOBRE VENTAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGVentas
        '
        Me.DGVentas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DGVentas.BackColor = System.Drawing.Color.Gainsboro
        Me.DGVentas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DGVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DGVentas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.DGVentas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DGVentas.CaptionForeColor = System.Drawing.Color.Black
        Me.DGVentas.DataMember = ""
        Me.DGVentas.FlatMode = True
        Me.DGVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVentas.ForeColor = System.Drawing.Color.Black
        Me.DGVentas.GridLineColor = System.Drawing.Color.Silver
        Me.DGVentas.HeaderBackColor = System.Drawing.Color.Black
        Me.DGVentas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DGVentas.HeaderForeColor = System.Drawing.Color.White
        Me.DGVentas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DGVentas.Location = New System.Drawing.Point(272, 17)
        Me.DGVentas.Name = "DGVentas"
        Me.DGVentas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.DGVentas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGVentas.ReadOnly = True
        Me.DGVentas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.DGVentas.SelectionForeColor = System.Drawing.Color.White
        Me.DGVentas.Size = New System.Drawing.Size(712, 155)
        Me.DGVentas.TabIndex = 192
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(272, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(712, 52)
        Me.Label7.TabIndex = 199
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button1)
        Me.GroupBox9.Controls.Add(Me.Cancel)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(240, 121)
        Me.GroupBox9.TabIndex = 190
        Me.GroupBox9.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Contabilizar"
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(64, 69)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(112, 25)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "Cancelar"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cbMes)
        Me.GroupBox3.Controls.Add(Me.rbMes)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(8, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 86)
        Me.GroupBox3.TabIndex = 189
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TIEMPO"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.ItemHeight = 15
        Me.cbMes.Location = New System.Drawing.Point(72, 34)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(144, 23)
        Me.cbMes.TabIndex = 4
        '
        'rbMes
        '
        Me.rbMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.rbMes.Checked = True
        Me.rbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbMes.Location = New System.Drawing.Point(8, 34)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(72, 26)
        Me.rbMes.TabIndex = 1
        Me.rbMes.TabStop = True
        Me.rbMes.Text = "Mes"
        Me.rbMes.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbMes.UseVisualStyleBackColor = False
        '
        'FrmIRFacturaContabilizado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1000, 734)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtMesAnt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotalIR)
        Me.Controls.Add(Me.txtIRVenta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtIRPagado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCredito)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgCompras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVentas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "FrmIRFacturaContabilizado"
        Me.Text = "Contabilizar I.R."
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Shared ChildInstance As FrmIRFacturaContabilizado = Nothing

    Public Shared Function Instance() As FrmIRFacturaContabilizado
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmIRFacturaContabilizado()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim PeriodosDB As New VB.SysContab.PeriodosDB()
    Dim Meses As New VB.SysContab.MesesDB()
    Dim FactVentasDB As New VB.SysContab.Facturas_VentasDB()
    Dim FactComprasDB As New VB.SysContab.Facturas_ComprasDB()
    Dim PlantillasDB As New VB.SysContab.PlantillaDB()
    Dim ComprobantesDB As New VB.SysContab.ComprobanteDB()
    Dim ConfDB As New VB.SysContab.ConfiguracionDB()

    Dim r As New VB.SysContab.Rutinas()
    Dim TablaVentas As DataTable
    Dim TablaCompras As DataTable
    Dim dsVentas As DataSet
    Dim dsCompras As DataSet
    Dim I As Integer


    Dim Mes As String
    Dim MesAnterior As String
    Dim FechaDesde As String
    Dim FechaHasta As String
    Dim IVASoportadoAnterior As String
    Dim IVARepercutidoAnterior As String
    Dim MesConcepto As String

    Private Sub frmIRxFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        cbMes.DataSource = VB.SysContab.MesesDB.MesexPeriodo.Tables("Meses")
        cbMes.ValueMember = "Mes"
        cbMes.DisplayMember = "MesAnno"
        cbMes.SelectedValue = 0


        CalculaTotal()


    End Sub


    Sub CalculaTotal()

        MesAnterior = 0
        txtCredito.Text = 0
        IVARepercutidoAnterior = 0
        IVASoportadoAnterior = 0

        If rbMes.Checked = True Then
            If Not IsNumeric(cbMes.SelectedValue) Then
                Exit Sub
            End If
            Mes = cbMes.SelectedValue
            FechaDesde = ""
            FechaHasta = ""
            If IsNumeric(Mes) = True And Mes > 0 Then
                MesAnterior = Month((New DateTime(Today.Year, Mes, 1)).AddMonths(-1)) 'Month(CDate("01/" & Mes & "/" & Today().Year).AddMonths(-1))
            End If
            MesConcepto = Mes

        End If

        dsVentas = FactVentasDB.GetIRVentas(FechaDesde, FechaHasta, Mes, 0, (ConfDB.GetConfigDetails().IR_Ventas / 100), 0)
        dsCompras = FactComprasDB.GetIRCompras(FechaDesde, FechaHasta, Mes, 0, 0, ConfDB.GetConfigDetails().MontoIR, ConfDB.GetConfigDetails().IRProd / 100, ConfDB.GetConfigDetails().IRServ / 100)

        DGVentas.DataSource = dsVentas.Tables("Tablas").DefaultView
        dgCompras.DataSource = dsCompras.Tables("Tablas").DefaultView

        TablaVentas = dsVentas.Tables("Tablas")
        TablaCompras = dsCompras.Tables("Tablas")

        r.FormatGenerico(DGVentas, TablaVentas)
        r.FormatGenerico(dgCompras, TablaCompras)

        DGVentas.ReadOnly = True
        dgCompras.ReadOnly = True

        txtIRVenta.Text = 0
        txtIRPagado.Text = 0


        For I = 0 To dsVentas.Tables("Tablas").Rows.Count - 1
            txtIRVenta.Text = CDbl(dsVentas.Tables("Tablas").Rows(I).Item("I.R.") + txtIRVenta.Text).ToString(Round)
        Next

        For I = 0 To dsCompras.Tables("Tablas").Rows.Count - 1
            txtIRPagado.Text = CDbl(dsCompras.Tables("Tablas").Rows(I).Item("I.R.") + txtIRPagado.Text).ToString(Round)
        Next


        ' Calculo del Mes Anterior
        If IsNumeric(Mes) = True And Mes > 0 Then
            dsVentas = FactVentasDB.GetIRVentas("", "", MesAnterior, 0, (ConfDB.GetConfigDetails().IR_Ventas / 100.0), 0)
            dsCompras = FactComprasDB.GetIRCompras("", "", MesAnterior, 0, 0, ConfDB.GetConfigDetails().MontoIR, ConfDB.GetConfigDetails().IRProd / 100.0, ConfDB.GetConfigDetails().IRServ / 100.0)

            For I = 0 To dsVentas.Tables("Tablas").Rows.Count - 1
                IVARepercutidoAnterior = CDbl(dsVentas.Tables("Tablas").Rows(I).Item("I.R.") + IVARepercutidoAnterior).ToString(Round)
            Next

            For I = 0 To dsCompras.Tables("Tablas").Rows.Count - 1
                IVASoportadoAnterior = CDbl(dsCompras.Tables("Tablas").Rows(I).Item("I.R.") + IVASoportadoAnterior).ToString(Round)
            Next


            If (IVASoportadoAnterior - IVARepercutidoAnterior) >= 0 Then
                txtCredito.Text = IVARepercutidoAnterior - IVASoportadoAnterior
            Else
                txtCredito.Text = 0
            End If


        End If


        txtTotalIR.Text = CDbl(txtIRVenta.Text - txtIRPagado.Text).ToString(Round)
        txtMesAnt.Text = CDbl(txtCredito.Text).ToString(Round)
        txtTotal.Text = CDbl(txtTotalIR.Text - txtMesAnt.Text).ToString(Round)



    End Sub


    Private Sub cbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMes.SelectedIndexChanged

        CalculaTotal()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim CuentaIRVenta As String
        Dim CuentaIVPagado As String
        Dim CajaIR As String

        Dim TipoCOmpr As String = PlantillasDB.GetPlantillasDetails(3, 2).TipoCompr

        If PlantillasDB.GetPlantillasDetails(3, 2).PlaID Is DBNull.Value Or PlantillasDB.GetPlantillasDetails(3, 2).PlaID <> "" Or Not PlantillasDB.GetPlantillasDetails(3, 2).PlaID Is Nothing Then


            Dim DsPlantillas As DataSet = PlantillasDB.GetPlantillasDetails(3, 2).Detalles

            CuentaIVPagado = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
            CuentaIRVenta = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
            CajaIR = DsPlantillas.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")


            ' FALTA LA TASA DE CAMBIO y MONEDA

            If VB.SysContab.ComprobanteDB.Contabilizar(CajaIR, txtTotal.Text, "Total de IR para Bancos en el mes " & MesConcepto, CuentaIVPagado, txtIRPagado.Text, "Total de IR de Compras del mes de " & MesConcepto, _
                               CuentaIRVenta, txtIRVenta.Text, "Total de IR de Ventas del mes de " & MesConcepto, _
                                  TipoCOmpr, 1, 1, "Comprobante de IR de Venta", TipoCOmpr, Today) = True Then

0:
                MsgBox("Se ha contabilizado correctamente el IR")

            Else

                MsgBox("No se ha podido contabilizar el IR")

            End If

        End If



    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        Dim fr As frmIRFacturaDetalles = frmIRFacturaDetalles.Instance()
        fr.MdiParent = Me.MdiParent

        fr.Mes = Mes
        fr.FechaDesde = FechaDesde
        fr.FechaHasta = FechaHasta
        fr.Tipo = 1
        fr.Show()


    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim fr As frmReporteIVADetalles = frmReporteIVADetalles.Instance
        fr.MdiParent = Me.MdiParent
        fr.Mes = Mes
        fr.FechaDesde = FechaDesde
        fr.FechaHasta = FechaHasta
        fr.Tipo = 2
        fr.Show()

    End Sub
End Class
