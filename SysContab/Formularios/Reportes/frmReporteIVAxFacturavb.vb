
Public Class frmReporteIVAxFacturavb
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReporteIVAxFacturavb = Nothing

    Public Shared Function Instance() As frmReporteIVAxFacturavb
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReporteIVAxFacturavb
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
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtMesAnt As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtIVAReper As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIVASoport As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgCompras As System.Windows.Forms.DataGrid
    Friend WithEvents DGVentas As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DTPickerDe As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPickerHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents rbRango As System.Windows.Forms.RadioButton
    Friend WithEvents rbMes As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ckbServ2 As System.Windows.Forms.CheckBox
    Friend WithEvents ckbProd2 As System.Windows.Forms.CheckBox
    Friend WithEvents ckbServ1 As System.Windows.Forms.CheckBox
    Friend WithEvents ckbProd1 As System.Windows.Forms.CheckBox
    Friend WithEvents rbPagado As System.Windows.Forms.RadioButton
    Friend WithEvents rbCobrado As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents lblCompras As System.Windows.Forms.Label
    Friend WithEvents lblVentas As System.Windows.Forms.Label
    Friend WithEvents dgTodos As System.Windows.Forms.DataGrid
    Friend WithEvents lblTodos As System.Windows.Forms.Label
    Friend WithEvents ckbServBas As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.txtMesAnt = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTotalIVA = New System.Windows.Forms.TextBox
        Me.txtIVAReper = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtIVASoport = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCredito = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblCompras = New System.Windows.Forms.Label
        Me.dgCompras = New System.Windows.Forms.DataGrid
        Me.lblVentas = New System.Windows.Forms.Label
        Me.DGVentas = New System.Windows.Forms.DataGrid
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.Cancel = New DevExpress.XtraEditors.SimpleButton
        Me.Print = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DTPickerDe = New System.Windows.Forms.DateTimePicker
        Me.DTPickerHasta = New System.Windows.Forms.DateTimePicker
        Me.cbMes = New System.Windows.Forms.ComboBox
        Me.rbRango = New System.Windows.Forms.RadioButton
        Me.rbMes = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ckbServBas = New System.Windows.Forms.CheckBox
        Me.rbTodos = New System.Windows.Forms.RadioButton
        Me.ckbServ2 = New System.Windows.Forms.CheckBox
        Me.ckbProd2 = New System.Windows.Forms.CheckBox
        Me.ckbServ1 = New System.Windows.Forms.CheckBox
        Me.ckbProd1 = New System.Windows.Forms.CheckBox
        Me.rbPagado = New System.Windows.Forms.RadioButton
        Me.rbCobrado = New System.Windows.Forms.RadioButton
        Me.dgTodos = New System.Windows.Forms.DataGrid
        Me.lblTodos = New System.Windows.Forms.Label
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgTodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(888, 19)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(80, 16)
        Me.LinkLabel2.TabIndex = 162
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Ver Detalles"
        '
        'txtMesAnt
        '
        Me.txtMesAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMesAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMesAnt.Location = New System.Drawing.Point(840, 456)
        Me.txtMesAnt.Name = "txtMesAnt"
        Me.txtMesAnt.ReadOnly = True
        Me.txtMesAnt.Size = New System.Drawing.Size(128, 20)
        Me.txtMesAnt.TabIndex = 159
        Me.txtMesAnt.Text = ""
        Me.txtMesAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(840, 480)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(128, 20)
        Me.txtTotal.TabIndex = 160
        Me.txtTotal.Text = ""
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(888, 171)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(80, 16)
        Me.LinkLabel1.TabIndex = 163
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ver Detalles"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label14.Location = New System.Drawing.Point(648, 480)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(176, 16)
        Me.Label14.TabIndex = 161
        Me.Label14.Text = "TOTAL A PAGAR"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(648, 456)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 16)
        Me.Label13.TabIndex = 158
        Me.Label13.Text = "CREDITO MES ANTERIOR"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(888, 416)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "TOTAL"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalIVA
        '
        Me.txtTotalIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalIVA.Location = New System.Drawing.Point(840, 432)
        Me.txtTotalIVA.Name = "txtTotalIVA"
        Me.txtTotalIVA.ReadOnly = True
        Me.txtTotalIVA.Size = New System.Drawing.Size(128, 20)
        Me.txtTotalIVA.TabIndex = 156
        Me.txtTotalIVA.Text = ""
        Me.txtTotalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVAReper
        '
        Me.txtIVAReper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVAReper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVAReper.Location = New System.Drawing.Point(672, 432)
        Me.txtIVAReper.Name = "txtIVAReper"
        Me.txtIVAReper.ReadOnly = True
        Me.txtIVAReper.Size = New System.Drawing.Size(128, 20)
        Me.txtIVAReper.TabIndex = 155
        Me.txtIVAReper.Text = ""
        Me.txtIVAReper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(664, 416)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 16)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "I.V.A   REPERCUTIDO"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIVASoport
        '
        Me.txtIVASoport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVASoport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVASoport.Location = New System.Drawing.Point(448, 432)
        Me.txtIVASoport.Name = "txtIVASoport"
        Me.txtIVASoport.ReadOnly = True
        Me.txtIVASoport.Size = New System.Drawing.Size(128, 20)
        Me.txtIVASoport.TabIndex = 152
        Me.txtIVASoport.Text = ""
        Me.txtIVASoport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(456, 416)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "I.V.A SOPORTADO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(264, 392)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(712, 20)
        Me.Label9.TabIndex = 150
        Me.Label9.Text = "DECLARACION DEL MES"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(264, 408)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(712, 104)
        Me.Label10.TabIndex = 153
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCredito
        '
        Me.txtCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredito.Location = New System.Drawing.Point(600, 352)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.ReadOnly = True
        Me.txtCredito.TabIndex = 148
        Me.txtCredito.Text = ""
        Me.txtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(528, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "CREDITO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(264, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(712, 20)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "SALDO MES ANTERIOR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCompras
        '
        Me.lblCompras.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.lblCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompras.ForeColor = System.Drawing.Color.White
        Me.lblCompras.Location = New System.Drawing.Point(264, 168)
        Me.lblCompras.Name = "lblCompras"
        Me.lblCompras.Size = New System.Drawing.Size(712, 20)
        Me.lblCompras.TabIndex = 145
        Me.lblCompras.Text = "I.V.A. PAGADO"
        Me.lblCompras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.dgCompras.Location = New System.Drawing.Point(264, 168)
        Me.dgCompras.Name = "dgCompras"
        Me.dgCompras.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgCompras.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCompras.ReadOnly = True
        Me.dgCompras.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgCompras.SelectionForeColor = System.Drawing.Color.White
        Me.dgCompras.Size = New System.Drawing.Size(712, 144)
        Me.dgCompras.TabIndex = 144
        '
        'lblVentas
        '
        Me.lblVentas.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.lblVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentas.ForeColor = System.Drawing.Color.White
        Me.lblVentas.Location = New System.Drawing.Point(264, 16)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(712, 20)
        Me.lblVentas.TabIndex = 143
        Me.lblVentas.Text = "I.V.A. COBRADO"
        Me.lblVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.DGVentas.Location = New System.Drawing.Point(264, 16)
        Me.DGVentas.Name = "DGVentas"
        Me.DGVentas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.DGVentas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGVentas.ReadOnly = True
        Me.DGVentas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.DGVentas.SelectionForeColor = System.Drawing.Color.White
        Me.DGVentas.Size = New System.Drawing.Size(712, 144)
        Me.DGVentas.TabIndex = 142
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button1)
        Me.GroupBox9.Controls.Add(Me.cmdAyuda)
        Me.GroupBox9.Controls.Add(Me.Cancel)
        Me.GroupBox9.Controls.Add(Me.Print)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 424)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(240, 88)
        Me.GroupBox9.TabIndex = 141
        Me.GroupBox9.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.cmdAyuda.Location = New System.Drawing.Point(48, 48)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(64, 23)
        Me.cmdAyuda.TabIndex = 2
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Cancel.Location = New System.Drawing.Point(136, 48)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(64, 23)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "&Cancelar"
        '
        'Print
        '
        Me.Print.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Print.Location = New System.Drawing.Point(48, 16)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(64, 23)
        Me.Print.TabIndex = 0
        Me.Print.Text = "&Buscar"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.Add(Me.DTPickerDe)
        Me.GroupBox3.Controls.Add(Me.DTPickerHasta)
        Me.GroupBox3.Controls.Add(Me.cbMes)
        Me.GroupBox3.Controls.Add(Me.rbRango)
        Me.GroupBox3.Controls.Add(Me.rbMes)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 144)
        Me.GroupBox3.TabIndex = 140
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TIEMPO"
        '
        'DTPickerDe
        '
        Me.DTPickerDe.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPickerDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPickerDe.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTPickerDe.Location = New System.Drawing.Point(96, 80)
        Me.DTPickerDe.Name = "DTPickerDe"
        Me.DTPickerDe.Size = New System.Drawing.Size(120, 21)
        Me.DTPickerDe.TabIndex = 15
        Me.DTPickerDe.Value = New Date(2006, 2, 23, 10, 46, 3, 140)
        '
        'DTPickerHasta
        '
        Me.DTPickerHasta.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPickerHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTPickerHasta.Location = New System.Drawing.Point(96, 104)
        Me.DTPickerHasta.Name = "DTPickerHasta"
        Me.DTPickerHasta.Size = New System.Drawing.Size(120, 21)
        Me.DTPickerHasta.TabIndex = 14
        Me.DTPickerHasta.Value = New Date(2006, 2, 23, 10, 46, 3, 156)
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.ItemHeight = 15
        Me.cbMes.Location = New System.Drawing.Point(96, 24)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(120, 23)
        Me.cbMes.TabIndex = 4
        '
        'rbRango
        '
        Me.rbRango.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.rbRango.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRango.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbRango.Location = New System.Drawing.Point(8, 56)
        Me.rbRango.Name = "rbRango"
        Me.rbRango.Size = New System.Drawing.Size(88, 24)
        Me.rbRango.TabIndex = 3
        Me.rbRango.Text = "RANGO"
        Me.rbRango.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbMes
        '
        Me.rbMes.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.rbMes.Checked = True
        Me.rbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMes.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbMes.Location = New System.Drawing.Point(8, 24)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(72, 24)
        Me.rbMes.TabIndex = 1
        Me.rbMes.TabStop = True
        Me.rbMes.Text = "Mes"
        Me.rbMes.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Hasta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "De"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(264, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(712, 48)
        Me.Label7.TabIndex = 149
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox1.Controls.Add(Me.ckbServBas)
        Me.GroupBox1.Controls.Add(Me.rbTodos)
        Me.GroupBox1.Controls.Add(Me.ckbServ2)
        Me.GroupBox1.Controls.Add(Me.ckbProd2)
        Me.GroupBox1.Controls.Add(Me.ckbServ1)
        Me.GroupBox1.Controls.Add(Me.ckbProd1)
        Me.GroupBox1.Controls.Add(Me.rbPagado)
        Me.GroupBox1.Controls.Add(Me.rbCobrado)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 256)
        Me.GroupBox1.TabIndex = 164
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "I.V.A."
        '
        'ckbServBas
        '
        Me.ckbServBas.Enabled = False
        Me.ckbServBas.Location = New System.Drawing.Point(64, 216)
        Me.ckbServBas.Name = "ckbServBas"
        Me.ckbServBas.Size = New System.Drawing.Size(136, 24)
        Me.ckbServBas.TabIndex = 8
        Me.ckbServBas.Text = "Servicios Básicos"
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.rbTodos.Checked = True
        Me.rbTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodos.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbTodos.Location = New System.Drawing.Point(32, 32)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(120, 24)
        Me.rbTodos.TabIndex = 1
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'ckbServ2
        '
        Me.ckbServ2.Enabled = False
        Me.ckbServ2.Location = New System.Drawing.Point(64, 192)
        Me.ckbServ2.Name = "ckbServ2"
        Me.ckbServ2.TabIndex = 7
        Me.ckbServ2.Text = "Servicios"
        '
        'ckbProd2
        '
        Me.ckbProd2.Enabled = False
        Me.ckbProd2.Location = New System.Drawing.Point(64, 168)
        Me.ckbProd2.Name = "ckbProd2"
        Me.ckbProd2.TabIndex = 6
        Me.ckbProd2.Text = "Productos"
        '
        'ckbServ1
        '
        Me.ckbServ1.Enabled = False
        Me.ckbServ1.Location = New System.Drawing.Point(64, 112)
        Me.ckbServ1.Name = "ckbServ1"
        Me.ckbServ1.TabIndex = 5
        Me.ckbServ1.Text = "Servicios"
        '
        'ckbProd1
        '
        Me.ckbProd1.Enabled = False
        Me.ckbProd1.Location = New System.Drawing.Point(64, 88)
        Me.ckbProd1.Name = "ckbProd1"
        Me.ckbProd1.TabIndex = 4
        Me.ckbProd1.Text = "Productos"
        '
        'rbPagado
        '
        Me.rbPagado.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.rbPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPagado.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbPagado.Location = New System.Drawing.Point(32, 144)
        Me.rbPagado.Name = "rbPagado"
        Me.rbPagado.Size = New System.Drawing.Size(128, 24)
        Me.rbPagado.TabIndex = 3
        Me.rbPagado.Text = "I.V.A. Pagado"
        Me.rbPagado.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbCobrado
        '
        Me.rbCobrado.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.rbCobrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCobrado.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbCobrado.Location = New System.Drawing.Point(32, 64)
        Me.rbCobrado.Name = "rbCobrado"
        Me.rbCobrado.Size = New System.Drawing.Size(120, 24)
        Me.rbCobrado.TabIndex = 2
        Me.rbCobrado.Text = "I.V.A. Cobrado"
        Me.rbCobrado.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'dgTodos
        '
        Me.dgTodos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgTodos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgTodos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgTodos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgTodos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgTodos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgTodos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgTodos.DataMember = ""
        Me.dgTodos.FlatMode = True
        Me.dgTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTodos.ForeColor = System.Drawing.Color.Black
        Me.dgTodos.GridLineColor = System.Drawing.Color.Silver
        Me.dgTodos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgTodos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgTodos.HeaderForeColor = System.Drawing.Color.White
        Me.dgTodos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgTodos.Location = New System.Drawing.Point(264, 16)
        Me.dgTodos.Name = "dgTodos"
        Me.dgTodos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgTodos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgTodos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgTodos.SelectionForeColor = System.Drawing.Color.White
        Me.dgTodos.Size = New System.Drawing.Size(712, 296)
        Me.dgTodos.TabIndex = 165
        '
        'lblTodos
        '
        Me.lblTodos.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.lblTodos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodos.ForeColor = System.Drawing.Color.White
        Me.lblTodos.Location = New System.Drawing.Point(264, 0)
        Me.lblTodos.Name = "lblTodos"
        Me.lblTodos.Size = New System.Drawing.Size(712, 20)
        Me.lblTodos.TabIndex = 167
        Me.lblTodos.Text = "I.V.A. PAGADO"
        Me.lblTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Button1.Location = New System.Drawing.Point(136, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Imprimir"
        '
        'frmReporteIVAxFacturavb
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1024, 550)
        Me.Controls.Add(Me.lblTodos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.txtMesAnt)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtTotalIVA)
        Me.Controls.Add(Me.txtIVAReper)
        Me.Controls.Add(Me.txtIVASoport)
        Me.Controls.Add(Me.txtCredito)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCompras)
        Me.Controls.Add(Me.dgCompras)
        Me.Controls.Add(Me.lblVentas)
        Me.Controls.Add(Me.DGVentas)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgTodos)
        Me.Name = "frmReporteIVAxFacturavb"
        Me.Text = "Reporte de I.V.A."
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgTodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim PeriodosDB As New VB.SysContab.PeriodosDB
    Dim Meses As New VB.SysContab.MesesDB
    Dim FactVentasDB As New VB.SysContab.Facturas_VentasDB
    Dim FactComprasDB As New VB.SysContab.Facturas_ComprasDB

    Dim r As New VB.SysContab.Rutinas
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
    Dim ProdServ As Integer
    Dim ServBas As Integer
    Dim Fechas As New VB.SysContab.FechasdeTrabajo


    Private Sub frmReporteIVAxFacturavb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTPickerDe.MinDate = Fechas.FechaMinima 'PeriodosDB.GetDetails(PeriodosDB.Activo()).Inicio
        DTPickerDe.MaxDate = Fechas.FechaMaxima 'PeriodosDB.GetDetails(PeriodosDB.Activo()).Final
        DTPickerHasta.MinDate = Fechas.FechaMinima 'PeriodosDB.GetDetails(PeriodosDB.Activo()).Inicio
        DTPickerHasta.MaxDate = Fechas.FechaMaxima 'PeriodosDB.GetDetails(PeriodosDB.Activo()).Final

        cbMes.DataSource = VB.SysContab.MesesDB.MesexPeriodo.Tables("Meses")
        cbMes.ValueMember = "Mes"
        cbMes.DisplayMember = "MesAnno"
        cbMes.SelectedIndex = 0

        CalculaTotal()
    End Sub


    Sub CalculaTotal()

        ProdServ = 0

        txtTotalIVA.Text = 0
        txtMesAnt.Text = 0
        txtTotal.Text = 0

        If ckbProd1.Checked = True And ckbServ1.Checked = False Then
            ProdServ = 1
        End If

        If ckbProd1.Checked = False And ckbServ1.Checked = True Then
            ProdServ = 2
        End If

        If ckbProd2.Checked = True And ckbServ2.Checked = False And ckbServBas.Checked = False Then
            ProdServ = 1
        End If

        If ckbProd2.Checked = False And ckbServ2.Checked = True And ckbServBas.Checked = False Then
            ProdServ = 2
            ServBas = 0
        End If

        If ckbProd2.Checked = False And ckbServ2.Checked = False And ckbServBas.Checked = True Then
            ProdServ = 3
            ServBas = 3
        End If

        If ckbProd2.Checked = False And ckbServ2.Checked = True And ckbServBas.Checked = True Then
            ProdServ = 2
            ServBas = 3
        End If

        If ckbProd2.Checked = True And ckbServ2.Checked = False And ckbServBas.Checked = True Then
            ProdServ = 1
            ServBas = 3
        End If

        If ckbProd2.Checked = True And ckbServ2.Checked = True And ckbServBas.Checked = False Then
            ProdServ = 1
            ServBas = 2
        End If



        If rbMes.Checked = True Then
            If Not IsNumeric(cbMes.SelectedValue) Then
                Exit Sub
            End If
            Mes = cbMes.SelectedValue
            FechaDesde = ""
            FechaHasta = ""
            If IsNumeric(Mes) = True And Mes > 0 Then
                MesAnterior = Month((New DateTime(Today.Year, Mes, 1)).AddMonths(-1)) 'CDate("01/" & Mes & "/" & Today().Year)
            End If

        End If

        If rbRango.Checked = True Then
            Mes = 0
            FechaDesde = DTPickerDe.Value.Date
            FechaHasta = DTPickerHasta.Value.Date
            MesAnterior = Month(CDate(DTPickerDe.Value.Date).AddMonths(-1))
        End If

        If rbTodos.Checked = True Then
            dsVentas = FactVentasDB.GetIVAxTipo(FechaDesde, FechaHasta, Mes, ProdServ, Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4))
            dsCompras = FactComprasDB.GetIVAxTipo(FechaDesde, FechaHasta, Mes, ProdServ, ServBas, Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4))

            DGVentas.DataSource = dsVentas.Tables("Tablas").DefaultView
            dgCompras.DataSource = dsCompras.Tables("Tablas").DefaultView

            TablaVentas = dsVentas.Tables("Tablas")
            TablaCompras = dsCompras.Tables("Tablas")

            r.FormatGenerico(DGVentas, TablaVentas)
            r.FormatGenerico(dgCompras, TablaCompras)

            DGVentas.ReadOnly = True
            dgCompras.ReadOnly = True

            txtIVAReper.Text = "0.00"
            txtIVASoport.Text = "0.00"
            txtCredito.Text = "0.00"

            For I = 0 To dsVentas.Tables("Tablas").Rows.Count - 1
                txtIVAReper.Text = CDbl(dsVentas.Tables("Tablas").Rows(I).Item("IVA") + txtIVAReper.Text).ToString(Round)
            Next

            For I = 0 To dsCompras.Tables("Tablas").Rows.Count - 1
                txtIVASoport.Text = CDbl(dsCompras.Tables("Tablas").Rows(I).Item("IVA") + txtIVASoport.Text).ToString(Round)
            Next

            ' Calculo del Mes Anterior

            If IsNumeric(Mes) = True And Mes > 0 Then
                dsVentas = FactVentasDB.GetIVAxTipo("", "", MesAnterior, ProdServ, Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4))
                dsCompras = FactComprasDB.GetIVAxTipo("", "", MesAnterior, ProdServ, ServBas, Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4))

                For I = 0 To dsVentas.Tables("Tablas").Rows.Count - 1
                    IVARepercutidoAnterior = CDbl(dsVentas.Tables("Tablas").Rows(I).Item("IVA") + IVARepercutidoAnterior).ToString(Round)
                Next

                For I = 0 To dsCompras.Tables("Tablas").Rows.Count - 1
                    IVASoportadoAnterior = CDbl(dsCompras.Tables("Tablas").Rows(I).Item("IVA") + IVASoportadoAnterior).ToString(Round)
                Next
                If (IVARepercutidoAnterior - IVASoportadoAnterior) >= 0 Then
                    txtCredito.Text = CDbl(IVARepercutidoAnterior - IVASoportadoAnterior).ToString(Round)
                Else
                    txtCredito.Text = "0.00"
                End If
            Else
                txtCredito.Text = "0.00"
            End If


            txtTotalIVA.Text = CDbl(txtIVAReper.Text - txtIVASoport.Text).ToString(Round)
            txtMesAnt.Text = CDbl(txtCredito.Text).ToString(Round)
            txtTotal.Text = CDbl(txtTotalIVA.Text - txtMesAnt.Text).ToString(Round)

        End If



        If rbCobrado.Checked = True Then

            dsVentas = FactVentasDB.GetIVAxTipo(FechaDesde, FechaHasta, Mes, ProdServ, Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4))
            dgTodos.DataSource = dsVentas.Tables("Tablas").DefaultView

            TablaVentas = dsVentas.Tables("Tablas")

            r.FormatGenerico(dgTodos, TablaVentas)

            dgTodos.ReadOnly = True

            txtIVAReper.Text = 0
            txtIVASoport.Text = 0

            For I = 0 To dsVentas.Tables("Tablas").Rows.Count - 1
                txtIVAReper.Text = CDbl(dsVentas.Tables("Tablas").Rows(I).Item("IVA") + txtIVAReper.Text).ToString(Round)
            Next

            ' Calculo del Mes Anterior
            If IsNumeric(Mes) = True And Mes > 0 Then
                dsVentas = FactVentasDB.GetIVAxTipo("", "", MesAnterior, ProdServ, Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4))

                For I = 0 To dsVentas.Tables("Tablas").Rows.Count - 1
                    IVARepercutidoAnterior = CDbl(dsVentas.Tables("Tablas").Rows(I).Item("IVA") + IVARepercutidoAnterior).ToString(Round)
                Next


                If (IVARepercutidoAnterior - IVASoportadoAnterior) >= 0 Then
                    txtCredito.Text = CDbl(IVARepercutidoAnterior - IVASoportadoAnterior).ToString(Round)
                Else
                    txtCredito.Text = "0.00"
                End If
            Else
                txtCredito.Text = "0.00"
            End If


            txtTotalIVA.Text = CDbl(txtIVAReper.Text - txtIVASoport.Text).ToString(Round)
            txtMesAnt.Text = CDbl(txtCredito.Text).ToString(Round)
            txtTotal.Text = CDbl(txtTotalIVA.Text - txtMesAnt.Text).ToString(Round)

        End If


        If rbPagado.Checked = True Then

            dsCompras = FactComprasDB.GetIVAxTipo(FechaDesde, FechaHasta, Mes, ProdServ, ServBas, Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4))

            dgTodos.DataSource = dsCompras.Tables("Tablas").DefaultView

            TablaCompras = dsCompras.Tables("Tablas")

            r.FormatGenerico(dgTodos, TablaCompras)

            DGVentas.ReadOnly = True
            dgCompras.ReadOnly = True

            txtIVAReper.Text = 0
            txtIVASoport.Text = 0


            For I = 0 To dsCompras.Tables("Tablas").Rows.Count - 1
                txtIVASoport.Text = CDbl(dsCompras.Tables("Tablas").Rows(I).Item("IVA") + txtIVASoport.Text).ToString(Round)
            Next

            ' Calculo del Mes Anterior

            If IsNumeric(Mes) = True And Mes > 0 Then
                dsCompras = FactComprasDB.GetIVAxTipo("", "", MesAnterior, ProdServ, ServBas, Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4))

                For I = 0 To dsCompras.Tables("Tablas").Rows.Count - 1
                    IVASoportadoAnterior = CDbl(dsCompras.Tables("Tablas").Rows(I).Item("IVA") + IVASoportadoAnterior).ToString(Round)
                Next

                If (IVARepercutidoAnterior - IVASoportadoAnterior) >= 0 Then
                    txtCredito.Text = CDbl(IVARepercutidoAnterior - IVASoportadoAnterior).ToString(Round)
                Else
                    txtCredito.Text = "0.00"
                End If
            Else
                txtCredito.Text = "0.00"
            End If


            txtTotalIVA.Text = CDbl(txtIVAReper.Text - txtIVASoport.Text).ToString(Round)
            txtMesAnt.Text = CDbl(txtCredito.Text).ToString(Round)
            txtTotal.Text = CDbl(txtTotalIVA.Text - txtMesAnt.Text).ToString(Round)

        End If


    End Sub


    Private Sub rbTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cbMes.SelectedIndex = 0
        cbMes.Enabled = False
        DTPickerDe.Enabled = False
        DTPickerHasta.Enabled = False
    End Sub

    Private Sub rbMes_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMes.CheckedChanged
        cbMes.Enabled = True

        DTPickerDe.Enabled = False
        DTPickerHasta.Enabled = False
    End Sub


    Private Sub rbRango_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRango.CheckedChanged
        cbMes.SelectedIndex = 0
        cbMes.Enabled = False

        DTPickerDe.Enabled = True
        DTPickerHasta.Enabled = True
    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click

        CalculaTotal()

    End Sub


    Private Sub cbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMes.SelectedIndexChanged

        CalculaTotal()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        Dim fr As frmReporteIVADetalles = fr.Instance
        fr.MdiParent = Me.MdiParent

        fr.Mes = Mes
        fr.FechaDesde = FechaDesde
        fr.FechaHasta = FechaHasta
        fr.Tipo = 1
        fr.Show()


    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim fr As frmReporteIVADetalles = fr.Instance
        fr.MdiParent = Me.MdiParent
        fr.Mes = Mes
        fr.FechaDesde = FechaDesde
        fr.FechaHasta = FechaHasta
        fr.Tipo = 2
        fr.Show()

    End Sub

    Private Sub rbCobrado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCobrado.CheckedChanged

        If rbCobrado.Checked = True Then
            ckbProd1.Checked = True
            ckbServ1.Checked = True
            ckbProd2.Checked = False
            ckbServ2.Checked = False
            ckbServBas.Checked = False
            dgTodos.Visible = True
            lblTodos.Visible = True
            lblTodos.Text = "I.V.A. COBRADO"

            ckbProd1.Enabled = True
            ckbServ1.Enabled = True
            ckbProd2.Enabled = False
            ckbServ2.Enabled = False
            ckbServBas.Enabled = False
        End If

    End Sub

    Private Sub rbPagado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPagado.CheckedChanged

        If rbPagado.Checked = True Then
            ckbProd1.Checked = False
            ckbServ1.Checked = False
            ckbProd2.Checked = True
            ckbServ2.Checked = True
            ckbServBas.Checked = True
            dgTodos.Visible = True
            lblTodos.Visible = True
            lblTodos.Text = "I.V.A. PAGADO"

            ckbProd1.Enabled = False
            ckbServ1.Enabled = False
            ckbProd2.Enabled = True
            ckbServ2.Enabled = True
            ckbServBas.Enabled = True

        End If

    End Sub

    Private Sub rbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTodos.CheckedChanged

        dgTodos.Visible = False
        lblTodos.Visible = False
        ckbProd1.Checked = False
        ckbServ1.Checked = False
        ckbProd2.Checked = False
        ckbServ2.Checked = False

        ckbProd1.Enabled = False
        ckbServ1.Enabled = False
        ckbProd2.Enabled = False
        ckbServ2.Enabled = False
        ckbServBas.Enabled = False

    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/Reportes/ReportesGestion.chm")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim crReportDocument As New rptIVA
        Dim crReportDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        crReportDocument.Load(Application.StartupPath & "\Reportes\rptIVA.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Dim C As New VB.SysContab.ConfiguracionDetails
        Dim config As New VB.SysContab.ConfiguracionDB
        Dim Facturas As New VB.SysContab.Facturas_VentasDB
        Dim MesAnterior As Integer
        Dim ds As New DataSet
        C = config.GetConfigDetails()

        Dim fReportes As New frmReportes

        MesAnterior = Month(DateAdd(DateInterval.Month, -1, _
            New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedValue, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedValue, 2), 1)))
        ds = Facturas.IVA(IIf(Me.rbMes.Checked, Microsoft.VisualBasic.Right(Me.cbMes.SelectedValue, 2), 0), _
             IIf(Me.rbMes.Checked, "", Me.DTPickerDe.Value.Date), _
            IIf(Me.rbMes.Checked, "", Me.DTPickerHasta.Value.Date), EmpresaActual, _
            C.MontoIR, C.IRProd, C.IRServ, MesAnterior, C.IR_Ventas)

        ds.WriteXml(Application.StartupPath & "\xml\rptIVA.xml", XmlWriteMode.WriteSchema)

        crReportDocument.Database.Tables(0).Location = Application.StartupPath & "\xml\rptIVA.xml"
        crReportDocument.Subreports(0).Database.Tables(0).Location = Application.StartupPath & "\xml\rptIVA.xml"


        'crReportDocument.SetDataSource(ds.Tables(1))
        'crReportDocument.Subreports(0).SetDataSource(ds.Tables(0))
        fReportes.crvReportes.ReportSource = crReportDocument
        fReportes.Show()
    End Sub
End Class

