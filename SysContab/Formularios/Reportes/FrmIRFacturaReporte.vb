Public Class frmIRxFacturaReporte
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmIRxFacturaReporte = Nothing

    Public Shared Function Instance() As frmIRxFacturaReporte
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmIRxFacturaReporte()
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMesAnt As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalIR As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIRVenta As System.Windows.Forms.TextBox
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
    Friend WithEvents txtBanID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents rbMes As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMesAnt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalIR = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIRVenta = New System.Windows.Forms.TextBox()
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
        Me.txtBanID = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.rbMes = New System.Windows.Forms.RadioButton()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label14.Location = New System.Drawing.Point(704, 472)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 16)
        Me.Label14.TabIndex = 211
        Me.Label14.Text = "TOTAL A PAGAR"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMesAnt
        '
        Me.txtMesAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMesAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMesAnt.Location = New System.Drawing.Point(848, 448)
        Me.txtMesAnt.Name = "txtMesAnt"
        Me.txtMesAnt.ReadOnly = True
        Me.txtMesAnt.Size = New System.Drawing.Size(128, 20)
        Me.txtMesAnt.TabIndex = 209
        Me.txtMesAnt.Text = ""
        Me.txtMesAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(656, 448)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 16)
        Me.Label13.TabIndex = 208
        Me.Label13.Text = "CREDITO MES ANTERIOR"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(896, 408)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 207
        Me.Label12.Text = "TOTAL"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalIR
        '
        Me.txtTotalIR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalIR.Location = New System.Drawing.Point(848, 424)
        Me.txtTotalIR.Name = "txtTotalIR"
        Me.txtTotalIR.ReadOnly = True
        Me.txtTotalIR.Size = New System.Drawing.Size(128, 20)
        Me.txtTotalIR.TabIndex = 206
        Me.txtTotalIR.Text = ""
        Me.txtTotalIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(656, 408)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 16)
        Me.Label11.TabIndex = 204
        Me.Label11.Text = "I.R. PAGADO X ANTICIPADO"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(896, 162)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(80, 16)
        Me.LinkLabel1.TabIndex = 213
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ver Detalles"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(896, 10)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(80, 16)
        Me.LinkLabel2.TabIndex = 212
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Ver Detalles"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(848, 472)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(128, 20)
        Me.txtTotal.TabIndex = 210
        Me.txtTotal.Text = ""
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIRVenta
        '
        Me.txtIRVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRVenta.Location = New System.Drawing.Point(464, 424)
        Me.txtIRVenta.Name = "txtIRVenta"
        Me.txtIRVenta.ReadOnly = True
        Me.txtIRVenta.Size = New System.Drawing.Size(128, 20)
        Me.txtIRVenta.TabIndex = 205
        Me.txtIRVenta.Text = ""
        Me.txtIRVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIRPagado
        '
        Me.txtIRPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRPagado.Location = New System.Drawing.Point(704, 424)
        Me.txtIRPagado.Name = "txtIRPagado"
        Me.txtIRPagado.ReadOnly = True
        Me.txtIRPagado.Size = New System.Drawing.Size(128, 20)
        Me.txtIRPagado.TabIndex = 202
        Me.txtIRPagado.Text = ""
        Me.txtIRPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(464, 408)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 201
        Me.Label8.Text = "I.R. SOBRE VENTAS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(272, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(712, 20)
        Me.Label9.TabIndex = 200
        Me.Label9.Text = "DECLARACION DEL MES"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(272, 400)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(712, 104)
        Me.Label10.TabIndex = 203
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCredito
        '
        Me.txtCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredito.Location = New System.Drawing.Point(608, 344)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.ReadOnly = True
        Me.txtCredito.TabIndex = 198
        Me.txtCredito.Text = ""
        Me.txtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(536, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 197
        Me.Label4.Text = "CREDITO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(272, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(712, 20)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "SALDO MES ANTERIOR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(272, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(712, 20)
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
        Me.dgCompras.Location = New System.Drawing.Point(272, 160)
        Me.dgCompras.Name = "dgCompras"
        Me.dgCompras.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgCompras.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCompras.ReadOnly = True
        Me.dgCompras.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgCompras.SelectionForeColor = System.Drawing.Color.White
        Me.dgCompras.Size = New System.Drawing.Size(712, 144)
        Me.dgCompras.TabIndex = 194
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
        Me.DGVentas.Location = New System.Drawing.Point(272, 8)
        Me.DGVentas.Name = "DGVentas"
        Me.DGVentas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.DGVentas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGVentas.ReadOnly = True
        Me.DGVentas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.DGVentas.SelectionForeColor = System.Drawing.Color.White
        Me.DGVentas.Size = New System.Drawing.Size(712, 144)
        Me.DGVentas.TabIndex = 192
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(272, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(712, 48)
        Me.Label7.TabIndex = 199
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBanID
        '
        Me.txtBanID.Location = New System.Drawing.Point(48, 472)
        Me.txtBanID.Name = "txtBanID"
        Me.txtBanID.TabIndex = 191
        Me.txtBanID.Text = "0"
        Me.txtBanID.Visible = False
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox9.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button2, Me.Button1, Me.Cancel})
        Me.GroupBox9.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(240, 80)
        Me.GroupBox9.TabIndex = 190
        Me.GroupBox9.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Buscar"
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Cancel.Location = New System.Drawing.Point(160, 32)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(64, 23)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "&Cancelar"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbMes, Me.rbMes})
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 80)
        Me.GroupBox3.TabIndex = 189
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TIEMPO"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.ItemHeight = 15
        Me.cbMes.Location = New System.Drawing.Point(72, 32)
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
        Me.rbMes.Location = New System.Drawing.Point(8, 32)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(72, 24)
        Me.rbMes.TabIndex = 1
        Me.rbMes.TabStop = True
        Me.rbMes.Text = "Mes"
        Me.rbMes.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Button2.Location = New System.Drawing.Point(84, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Ayuda"
        '
        'frmIRxFacturaReporte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1000, 534)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtTotal, Me.Label14, Me.txtMesAnt, Me.Label13, Me.Label12, Me.txtTotalIR, Me.Label11, Me.LinkLabel1, Me.LinkLabel2, Me.txtIRVenta, Me.txtIRPagado, Me.Label8, Me.Label9, Me.Label10, Me.txtCredito, Me.Label4, Me.Label3, Me.Label2, Me.dgCompras, Me.Label1, Me.DGVentas, Me.Label7, Me.txtBanID, Me.GroupBox9, Me.GroupBox3})
        Me.Name = "frmIRxFacturaReporte"
        Me.Text = "Reportes de Contabilidad"
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        CalculaTotal()

    End Sub

    Sub CalculaTotal()

        MesAnterior = 0
        txtCredito.Text = "0.00"
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
                txtCredito.Text = CDbl(IVARepercutidoAnterior - IVASoportadoAnterior).ToString(Round)
            Else
                txtCredito.Text = "0.00"
            End If
        End If

        txtTotalIR.Text = CDbl(txtIRVenta.Text - txtIRPagado.Text).ToString(Round)
        txtMesAnt.Text = CDbl(txtCredito.Text).ToString(Round)
        txtTotal.Text = CDbl(txtTotalIR.Text - txtMesAnt.Text).ToString(Round)



    End Sub


    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        Dim fr As frmIRFacturaDetalles = frmIRFacturaDetalles.Instance
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

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Help.ShowHelp(Me, "ayuda/Reportes/ReportesGestion.chm")
    End Sub
End Class
