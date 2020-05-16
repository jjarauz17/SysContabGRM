Public Class frmReporteIVA
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReporteIVA = Nothing

    Public Shared Function Instance() As frmReporteIVA
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReporteIVA()
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents rbMes As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DGVentas As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgCompras As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtIVASoport As System.Windows.Forms.TextBox
    Friend WithEvents txtIVAReper As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMesAnt As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtBanID As System.Windows.Forms.TextBox
    Friend WithEvents etPlantilla As System.Windows.Forms.Label
    Friend WithEvents txtIvaVentas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIvaCompras As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPagar As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCheque As System.Windows.Forms.CheckBox
    Friend WithEvents chkEfectivo As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbMes = New System.Windows.Forms.ComboBox
        Me.rbMes = New System.Windows.Forms.RadioButton
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.Print = New DevExpress.XtraEditors.SimpleButton
        Me.DGVentas = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgCompras = New System.Windows.Forms.DataGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCredito = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtIVASoport = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtIVAReper = New System.Windows.Forms.TextBox
        Me.txtTotalIVA = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtMesAnt = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.txtBanID = New System.Windows.Forms.TextBox
        Me.etPlantilla = New System.Windows.Forms.Label
        Me.txtIvaVentas = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtIvaCompras = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTotalPagar = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkCheque = New System.Windows.Forms.CheckBox
        Me.chkEfectivo = New System.Windows.Forms.CheckBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.DGVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.Add(Me.cbMes)
        Me.GroupBox3.Controls.Add(Me.rbMes)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 64)
        Me.GroupBox3.TabIndex = 115
        Me.GroupBox3.TabStop = False
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.ItemHeight = 15
        Me.cbMes.Location = New System.Drawing.Point(72, 24)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(144, 23)
        Me.cbMes.TabIndex = 4
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
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cmdAyuda)
        Me.GroupBox9.Controls.Add(Me.cmdAceptar)
        Me.GroupBox9.Controls.Add(Me.cmdSalir)
        Me.GroupBox9.Controls.Add(Me.Print)
        Me.GroupBox9.Location = New System.Drawing.Point(16, 208)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(240, 104)
        Me.GroupBox9.TabIndex = 116
        Me.GroupBox9.TabStop = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(80, 24)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "&Pagar"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(160, 64)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "&Salir"
        '
        'Print
        '
        Me.Print.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Print.Location = New System.Drawing.Point(160, 24)
        Me.Print.Name = "Print"
        Me.Print.TabIndex = 0
        Me.Print.Text = "&Buscar"
        Me.Print.Visible = False
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
        Me.DGVentas.Location = New System.Drawing.Point(272, 8)
        Me.DGVentas.Name = "DGVentas"
        Me.DGVentas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.DGVentas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGVentas.ReadOnly = True
        Me.DGVentas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.DGVentas.SelectionForeColor = System.Drawing.Color.White
        Me.DGVentas.Size = New System.Drawing.Size(712, 176)
        Me.DGVentas.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(272, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(712, 20)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "VENTAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(272, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(712, 20)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "COMPRAS"
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
        Me.dgCompras.Location = New System.Drawing.Point(272, 200)
        Me.dgCompras.Name = "dgCompras"
        Me.dgCompras.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgCompras.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCompras.ReadOnly = True
        Me.dgCompras.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgCompras.SelectionForeColor = System.Drawing.Color.White
        Me.dgCompras.Size = New System.Drawing.Size(712, 176)
        Me.dgCompras.TabIndex = 119
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(712, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(712, 20)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "SALDO MES ANTERIOR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(976, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "CREDITO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'txtCredito
        '
        Me.txtCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredito.Location = New System.Drawing.Point(1048, 376)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.ReadOnly = True
        Me.txtCredito.TabIndex = 123
        Me.txtCredito.Text = ""
        Me.txtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCredito.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(712, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(712, 48)
        Me.Label7.TabIndex = 124
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'txtIVASoport
        '
        Me.txtIVASoport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVASoport.Location = New System.Drawing.Point(912, 456)
        Me.txtIVASoport.Name = "txtIVASoport"
        Me.txtIVASoport.ReadOnly = True
        Me.txtIVASoport.TabIndex = 127
        Me.txtIVASoport.Text = ""
        Me.txtIVASoport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIVASoport.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(904, 440)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "I.V.A SOPORTADO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(712, 416)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(712, 20)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "DECLARACION DEL MES"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(712, 432)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(712, 104)
        Me.Label10.TabIndex = 128
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(1112, 440)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 16)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "I.V.A   REPERCUTIDO"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Visible = False
        '
        'txtIVAReper
        '
        Me.txtIVAReper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIVAReper.Location = New System.Drawing.Point(1128, 456)
        Me.txtIVAReper.Name = "txtIVAReper"
        Me.txtIVAReper.ReadOnly = True
        Me.txtIVAReper.TabIndex = 130
        Me.txtIVAReper.Text = ""
        Me.txtIVAReper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIVAReper.Visible = False
        '
        'txtTotalIVA
        '
        Me.txtTotalIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalIVA.Location = New System.Drawing.Point(1312, 456)
        Me.txtTotalIVA.Name = "txtTotalIVA"
        Me.txtTotalIVA.ReadOnly = True
        Me.txtTotalIVA.TabIndex = 131
        Me.txtTotalIVA.Text = ""
        Me.txtTotalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalIVA.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(1336, 440)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 132
        Me.Label12.Text = "TOTAL"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(1144, 480)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 16)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "CREDITO MES ANTERIOR"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.Visible = False
        '
        'txtMesAnt
        '
        Me.txtMesAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMesAnt.Location = New System.Drawing.Point(1312, 480)
        Me.txtMesAnt.Name = "txtMesAnt"
        Me.txtMesAnt.ReadOnly = True
        Me.txtMesAnt.TabIndex = 134
        Me.txtMesAnt.Text = ""
        Me.txtMesAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMesAnt.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(1312, 504)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.TabIndex = 135
        Me.txtTotal.Text = ""
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.Visible = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label14.Location = New System.Drawing.Point(1200, 504)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(176, 16)
        Me.Label14.TabIndex = 136
        Me.Label14.Text = "TOTAL A PAGAR"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(896, 9)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(80, 16)
        Me.LinkLabel2.TabIndex = 138
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Ver Detalles"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(896, 201)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(80, 16)
        Me.LinkLabel1.TabIndex = 139
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ver Detalles"
        '
        'txtBanID
        '
        Me.txtBanID.Location = New System.Drawing.Point(72, 480)
        Me.txtBanID.Name = "txtBanID"
        Me.txtBanID.TabIndex = 140
        Me.txtBanID.Text = "0"
        Me.txtBanID.Visible = False
        '
        'etPlantilla
        '
        Me.etPlantilla.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.etPlantilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etPlantilla.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.etPlantilla.Location = New System.Drawing.Point(32, 440)
        Me.etPlantilla.Name = "etPlantilla"
        Me.etPlantilla.Size = New System.Drawing.Size(72, 16)
        Me.etPlantilla.TabIndex = 191
        Me.etPlantilla.Text = "Plantilla"
        Me.etPlantilla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etPlantilla.Visible = False
        '
        'txtIvaVentas
        '
        Me.txtIvaVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIvaVentas.Location = New System.Drawing.Point(400, 392)
        Me.txtIvaVentas.Name = "txtIvaVentas"
        Me.txtIvaVentas.ReadOnly = True
        Me.txtIvaVentas.Size = New System.Drawing.Size(136, 20)
        Me.txtIvaVentas.TabIndex = 192
        Me.txtIvaVentas.Text = ""
        Me.txtIvaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(272, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "IVA de Ventas:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIvaCompras
        '
        Me.txtIvaCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIvaCompras.Location = New System.Drawing.Point(400, 424)
        Me.txtIvaCompras.Name = "txtIvaCompras"
        Me.txtIvaCompras.ReadOnly = True
        Me.txtIvaCompras.Size = New System.Drawing.Size(136, 20)
        Me.txtIvaCompras.TabIndex = 194
        Me.txtIvaCompras.Text = ""
        Me.txtIvaCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(272, 424)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 195
        Me.Label6.Text = "IVA de Compras:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPagar.Location = New System.Drawing.Point(400, 456)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.ReadOnly = True
        Me.txtTotalPagar.Size = New System.Drawing.Size(136, 20)
        Me.txtTotalPagar.TabIndex = 196
        Me.txtTotalPagar.Text = ""
        Me.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label15.Location = New System.Drawing.Point(272, 456)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 16)
        Me.Label15.TabIndex = 197
        Me.Label15.Text = "Total a Pagar:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkCheque)
        Me.GroupBox1.Controls.Add(Me.chkEfectivo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(16, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 104)
        Me.GroupBox1.TabIndex = 198
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMA DE PAGO"
        '
        'chkCheque
        '
        Me.chkCheque.Checked = True
        Me.chkCheque.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheque.Location = New System.Drawing.Point(16, 24)
        Me.chkCheque.Name = "chkCheque"
        Me.chkCheque.Size = New System.Drawing.Size(160, 24)
        Me.chkCheque.TabIndex = 26
        Me.chkCheque.Text = "Cheque"
        '
        'chkEfectivo
        '
        Me.chkEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEfectivo.Location = New System.Drawing.Point(16, 64)
        Me.chkEfectivo.Name = "chkEfectivo"
        Me.chkEfectivo.Size = New System.Drawing.Size(120, 24)
        Me.chkEfectivo.TabIndex = 25
        Me.chkEfectivo.Text = "Efectivo"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.cmdAyuda.Location = New System.Drawing.Point(83, 64)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.TabIndex = 3
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'frmReporteIVA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTotalPagar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtIvaCompras)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIvaVentas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.etPlantilla)
        Me.Controls.Add(Me.txtBanID)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtMesAnt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotalIVA)
        Me.Controls.Add(Me.txtIVAReper)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtIVASoport)
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
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label7)
        Me.Name = "frmReporteIVA"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.DGVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim PeriodosDB As New VB.SysContab.PeriodosDB()
    Dim Meses As New VB.SysContab.MesesDB()
    Dim FactVentasDB As New VB.SysContab.Facturas_VentasDB()
    Dim FactComprasDB As New VB.SysContab.Facturas_ComprasDB()
    Dim PlantillasDB As New VB.SysContab.PlantillaDB()
    Dim ComprobantesDB As New VB.SysContab.ComprobanteDB()

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


    Dim Anio As String
    'Dim DsPlantillas As DataSet

    Private Sub frmReporteIVA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'DTPickerDe.MinDate = PeriodosDB.GetDetails(PeriodosDB.Activo()).Inicio
        'DTPickerDe.MaxDate = PeriodosDB.GetDetails(PeriodosDB.Activo()).Final
        'DTPickerHasta.MinDate = PeriodosDB.GetDetails(PeriodosDB.Activo()).Inicio
        'DTPickerHasta.MaxDate = PeriodosDB.GetDetails(PeriodosDB.Activo()).Final

        cbMes.DataSource = VB.SysContab.MesesDB.MesexPeriodo.Tables("Meses")
        cbMes.ValueMember = "Mes"
        cbMes.DisplayMember = "MesAnno"
        cbMes.SelectedValue = 0

        'DsPlantillas = PlantillasDB.GetPlantillasDetails(3, 1).Detalles

        'Dim FechaControl As DateTime = PeriodosDB.GetDetails(PeriodosDB.Activo).Inicio

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

        'If rbRango.Checked = True Then
        '    Mes = 0
        '    FechaDesde = DTPickerDe.Value.Date
        '    FechaHasta = DTPickerHasta.Value.Date
        '    MesAnterior = Month(CDate(DTPickerDe.Value.Date).AddMonths(-1))
        '    MesConcepto = Month(CDate(DTPickerDe.Value.Date))
        'End If

        dsVentas = FactVentasDB.GetIVAxTipo(FechaDesde, FechaHasta, Mes, 0, Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4))
        dsCompras = FactComprasDB.GetIVAxTipo(FechaDesde, FechaHasta, Mes, 0, 0, Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4))

        DGVentas.DataSource = dsVentas.Tables("Tablas").DefaultView
        dgCompras.DataSource = dsCompras.Tables("Tablas").DefaultView

        TablaVentas = dsVentas.Tables("Tablas")
        TablaCompras = dsCompras.Tables("Tablas")

        r.FormatGenerico(DGVentas, TablaVentas)
        r.FormatGenerico(dgCompras, TablaCompras)

        DGVentas.ReadOnly = True
        dgCompras.ReadOnly = True

        txtIVAReper.Text = 0
        txtIVASoport.Text = 0


        ''For I = 0 To dsVentas.Tables("Tablas").Rows.Count - 1
        ''    txtIVAReper.Text = CDbl(dsVentas.Tables("Tablas").Rows(I).Item("IVA") + txtIVAReper.Text).ToString(Round)
        ''Next

        ''For I = 0 To dsCompras.Tables("Tablas").Rows.Count - 1
        ''    txtIVASoport.Text = CDbl(dsCompras.Tables("Tablas").Rows(I).Item("IVA") + txtIVASoport.Text).ToString(Round)
        ''Next

        If dsVentas.Tables("Tablas").Rows.Count > 0 Then
            Me.txtIvaVentas.Text = CDbl(dsVentas.Tables("Tablas").Rows(dsVentas.Tables("Tablas").Rows.Count - 1).Item("IVA").ToString).ToString(Round)
        Else
            Me.txtIvaVentas.Text = CDbl(0).ToString(Round)
        End If

        If Me.dsCompras.Tables("Tablas").Rows.Count > 0 Then
            Me.txtIvaCompras.Text = CDbl(Me.dsCompras.Tables("Tablas").Rows(Me.dsCompras.Tables("Tablas").Rows.Count - 1).Item("IVA").ToString).ToString(Round)
        Else
            Me.txtIvaCompras.Text = CDbl(0).ToString(Round)
        End If


        If CDbl(Me.txtIvaVentas.Text) - CDbl(Me.txtIvaCompras.Text) <= 0 Then
            Me.txtTotalPagar.Text = CDbl(0).ToString(Round)
        Else
            Me.txtTotalPagar.Text = CDbl(CDbl(Me.txtIvaVentas.Text) - CDbl(Me.txtIvaCompras.Text)).ToString(Round)
        End If


        ' Calculo del Mes Anterior
        'If IsNumeric(Mes) = True And Mes > 0 Then
        '    dsVentas = FactVentasDB.GetIVAxTipo("", "", MesAnterior, 0)
        '    dsCompras = FactComprasDB.GetIVAxTipo("", "", MesAnterior, 0, 0)

        '    For I = 0 To dsVentas.Tables("Tablas").Rows.Count - 1
        '        IVARepercutidoAnterior = CDbl(dsVentas.Tables("Tablas").Rows(I).Item("IVA") + IVARepercutidoAnterior).ToString(Round)
        '    Next

        '    For I = 0 To dsCompras.Tables("Tablas").Rows.Count - 1
        '        IVASoportadoAnterior = CDbl(dsCompras.Tables("Tablas").Rows(I).Item("IVA") + IVASoportadoAnterior).ToString(Round)
        '    Next

        '    If (IVASoportadoAnterior - IVARepercutidoAnterior) >= 0 Then
        '        txtCredito.Text = IVARepercutidoAnterior - IVASoportadoAnterior
        '    Else
        '        txtCredito.Text = 0
        '    End If
        'End If
        Dim dsSaldo As DataSet


        'Dim DsPlantillas As DataSet = PlantillasDB.GetPlantillasDetails(3, 1).Detalles

        'CuentaIVASoport = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        'CuentaIVARepert = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")

        'dsSaldo = ComprobantesDB.SaldoCuenta(DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta"))

        ''''dsSaldo = ComprobantesDB.SaldoCuenta(PlantillasDB.GetPlantillasDetails(3, 1).Detalles.Tables("PlantillasDetalles").Rows(0).Item("Cuenta"))

        ''''If dsSaldo.Tables("Tabla").Rows.Count = 0 Then
        ''''    Me.txtCredito.Text = "0.00"
        ''''Else
        ''''    Me.txtCredito.Text = CDbl(dsSaldo.Tables("Tabla").Rows(0).Item("Saldo")).ToString(Round)
        ''''End If

        ''''txtTotalIVA.Text = CDbl(txtIVAReper.Text - txtIVASoport.Text).ToString(Round)
        ''''txtMesAnt.Text = CDbl(txtCredito.Text).ToString(Round)
        ''''txtTotal.Text = CDbl(txtTotalIVA.Text - txtMesAnt.Text).ToString(Round)
    End Sub

    Private Sub rbMes_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMes.CheckedChanged
        cbMes.Enabled = True
    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click
        Anio = Microsoft.VisualBasic.Right(Me.cbMes.Text, 4)
        If Me.cbMes.SelectedIndex = 0 Then
            MsgBox("Seleccione el mes", MsgBoxStyle.Information)
            Me.cbMes.Focus()
            Exit Sub
        End If
        CalculaTotal()
    End Sub

    Private Sub cbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMes.SelectedIndexChanged
        Anio = Microsoft.VisualBasic.Right(Me.cbMes.Text, 4)
        CalculaTotal()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'If Me.cbMes.SelectedIndex = 0 Then
        '    MsgBox("Seleccione el mes", MsgBoxStyle.Information)
        '    Me.cbMes.Focus()
        '    Exit Sub
        'End If

        If CDbl(Me.txtTotalPagar.Text) = 0 And CDbl(Me.txtIvaVentas.Text) = 0 And CDbl(Me.txtIvaCompras.Text) = 0 Then
            MsgBox("No hay ningún Monto a Pagar", MsgBoxStyle.Information)
            Exit Sub
        End If

        If CDbl(Me.txtTotalPagar.Text) = 0 Then
            Dim f1 As DataGridTextBox.frmComprobanteImpuestosIVA1 = f1.Instance
            f1.etPlantilla.Text = Me.etPlantilla.Text

            f1.MontoIVAVentas = CDbl(Me.txtIvaVentas.Text)
            f1.MontoIVACompras = CDbl(Me.txtIvaVentas.Text)

            f1.Mes = cbMes.SelectedValue
            f1.Year = Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4)

            f1.MdiParent = Me.MdiParent
            f1.txtValor.Text = Me.txtTotalPagar.Text 'IIf(Me.chkAnticipo.Checked, CDbl(Me.txtTotal.Text), 0) + IIf(Me.chkGeneral.Checked, CDbl(Me.txtMontoServicioGeneral.Text), 0) + IIf(Me.chkProfesional.Checked, CDbl(Me.txtIRProfesionales.Text), 0) + IIf(Me.chkResidente.Checked, CDbl(Me.txtIRResidentes.Text), 0)
            f1.Show()
        Else
            If Me.chkCheque.Checked = True Then
                Dim f As frmBancosImpuestosIVA = f.Instance
                f.etPlantilla.Text = Me.etPlantilla.Text

                f.MontoIVAVentas = CDbl(Me.txtIvaVentas.Text)
                f.MontoIVACompras = CDbl(Me.txtIvaCompras.Text)

                f.Mes = cbMes.SelectedValue
                f.Year = Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4)

                f.MdiParent = Me.MdiParent
                f.lblFactMonto.Text = Me.txtTotalPagar.Text 'IIf(Me.chkAnticipo.Checked, CDbl(Me.txtTotal.Text), 0) + IIf(Me.chkGeneral.Checked, CDbl(Me.txtMontoServicioGeneral.Text), 0) + IIf(Me.chkProfesional.Checked, CDbl(Me.txtIRProfesionales.Text), 0) + IIf(Me.chkResidente.Checked, CDbl(Me.txtIRResidentes.Text), 0)
                f.Show()
            ElseIf Me.chkEfectivo.Checked = True Then
                'Dim f1 As DataGridTextBox.frmComprobanteImpuestosIVACaja = f1.Instance
                'f1.etPlantilla.Text = Me.etPlantilla.Text

                'f1.MontoIVAVentas = CDbl(Me.txtIvaVentas.Text)
                'f1.MontoIVACompras = CDbl(Me.txtIvaCompras.Text)

                'f1.Mes = cbMes.SelectedValue
                'f1.Year = Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4)

                'f1.MdiParent = Me.MdiParent
                'f1.txtValor.Text = Me.txtTotalPagar.Text 'IIf(Me.chkAnticipo.Checked, CDbl(Me.txtTotal.Text), 0) + IIf(Me.chkGeneral.Checked, CDbl(Me.txtMontoServicioGeneral.Text), 0) + IIf(Me.chkProfesional.Checked, CDbl(Me.txtIRProfesionales.Text), 0) + IIf(Me.chkResidente.Checked, CDbl(Me.txtIRResidentes.Text), 0)
                'f1.Show()
            End If

        End If

        ''If Me.cbMes.SelectedIndex = 0 Then
        ''    MsgBox("Seleccione el mes", MsgBoxStyle.Information)
        ''    Me.cbMes.Focus()
        ''    Exit Sub
        ''End If

        ''Anio = Microsoft.VisualBasic.Right(Me.cbMes.Text, 4)
        '''MsgBox(Anio)
        '''Exit Sub

        ''If CDbl(txtTotal.Text) > 0 Then
        ''    Dim fr As frmPlantillasBancos = fr.Instance
        ''    fr.MdiParent = Me.MdiParent
        ''    fr.Origen = 1
        ''    fr.Show()
        ''Else
        ''    Dim CuentaIVASoport As String
        ''    Dim CuentaIVARepert As String

        ''    Dim TipoCOmpr As String = PlantillasDB.GetPlantillasDetails(3, 1).TipoCompr

        ''    If PlantillasDB.GetPlantillasDetails(3, 1).PlaID Is DBNull.Value Or PlantillasDB.GetPlantillasDetails(3, 1).PlaID <> "" Or Not PlantillasDB.GetPlantillasDetails(3, 1).PlaID Is Nothing Then

        ''        Dim DsPlantillas As DataSet = PlantillasDB.GetPlantillasDetails(3, 1).Detalles

        ''        CuentaIVASoport = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        ''        CuentaIVARepert = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")

        ''        ' FALTA LA TASA DE CAMBIO y MONEDA

        ''        If ComprobantesDB.GeneraComprobanteIVA(0, txtTotal.Text, "Total de IVA del mes de " & MesConcepto, _
        ''                        CuentaIVASoport, CDbl(txtIVAReper.Text), "IVA Soportado del mes " & MesConcepto, CuentaIVARepert, CDbl(txtIVAReper.Text), _
        ''                         "IVA Repercutido del mes " & Mes, TipoCOmpr, 1, 1, "Comprobante de IVA", TipoCOmpr, Today, Mes, Anio, Math.Abs(CDbl(Me.txtTotal.Text))) = True Then

        ''            MsgBox("Se ha contabilizado correctamente la Factura")
        ''        Else
        ''            MsgBox("No se ha podido contabilizar la Factura")
        ''        End If
        ''    End If

        ''End If

    End Sub

    Private Sub txtBanID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBanID.TextChanged
        'If (Not txtBanID.Text Is DBNull.Value Or txtBanID.Text <> "" Or Not txtBanID.Text Is Nothing) And txtBanID.Text <> "0" Then

        '    Dim CuentaIVASoport As String
        '    Dim CuentaIVARepert As String

        '    Dim TipoCOmpr As String = PlantillasDB.GetPlantillasDetails(3, 1).TipoCompr

        '    If PlantillasDB.GetPlantillasDetails(3, 1).PlaID Is DBNull.Value Or PlantillasDB.GetPlantillasDetails(3, 1).PlaID <> "" Or Not PlantillasDB.GetPlantillasDetails(3, 1).PlaID Is Nothing Then


        '        Dim DsPlantillas As DataSet = PlantillasDB.GetPlantillasDetails(3, 1).Detalles

        '        CuentaIVASoport = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        '        CuentaIVARepert = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")

        '        ' FALTA LA TASA DE CAMBIO y MONEDA

        '        If ComprobantesDB.GeneraComprobanteIVA(txtBanID.Text, txtTotal.Text, "Total de IVA del mes de " & MesConcepto, _
        '                        CuentaIVASoport, CDbl(txtIVASoport.Text), "IVA Soportado del mes " & MesConcepto, CuentaIVARepert, CDbl(txtIVAReper.Text), _
        '                         "IVA Repercutido del mes " & Mes, TipoCOmpr, 1, 1, "Comprobante de IVA", TipoCOmpr, Today, Mes, Anio, Math.Abs(CDbl(Me.txtTotal.Text))) = True Then

        '            MsgBox("Se ha contabilizado correctamente la Factura")

        '        Else

        '            MsgBox("No se ha podido contabilizar la Factura")

        '        End If

        '    End If

        'End If

    End Sub

    Private Sub chkEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEfectivo.CheckedChanged
        Me.chkCheque.Checked = Not Me.chkEfectivo.Checked
    End Sub

    Private Sub chkCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheque.CheckedChanged
        Me.chkEfectivo.Checked = Not Me.chkCheque.Checked
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/ProcesosEfectuarPagos.chm", HelpNavigator.KeywordIndex, "IVA")
    End Sub
End Class
