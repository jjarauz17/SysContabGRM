Public Class frmIRxFactura
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmIRxFactura = Nothing

    Public Shared Function Instance() As frmIRxFactura
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmIRxFactura()
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
    Dim i As Integer


    Dim Mes As String
    Dim MesAnterior As String
    Dim FechaDesde As String
    Dim FechaHasta As String
    Dim IVASoportadoAnterior As String
    Dim IVARepercutidoAnterior As String
    Dim MesConcepto As String


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
    Friend WithEvents txtBanID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents rbMes As System.Windows.Forms.RadioButton
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMesAnt As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgCompras As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DGVentas As System.Windows.Forms.DataGrid
    Friend WithEvents txtTotalIR As System.Windows.Forms.TextBox
    Friend WithEvents txtIRVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtIRPagado As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAnticipo As System.Windows.Forms.CheckBox
    Friend WithEvents chkGeneral As System.Windows.Forms.CheckBox
    Friend WithEvents chkProfesional As System.Windows.Forms.CheckBox
    Friend WithEvents chkResidente As System.Windows.Forms.CheckBox
    Friend WithEvents etPlantilla As System.Windows.Forms.Label
    Friend WithEvents etCuentaIRProfesional As System.Windows.Forms.Label
    Friend WithEvents txtIRProfesionales As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents etCuentaIRResidente As System.Windows.Forms.Label
    Friend WithEvents txtIRResidentes As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtMontoServicioGeneral As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCheque As System.Windows.Forms.CheckBox
    Friend WithEvents chkEfectivo As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtBanID = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.rbMes = New System.Windows.Forms.RadioButton()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkResidente = New System.Windows.Forms.CheckBox()
        Me.chkProfesional = New System.Windows.Forms.CheckBox()
        Me.chkGeneral = New System.Windows.Forms.CheckBox()
        Me.chkAnticipo = New System.Windows.Forms.CheckBox()
        Me.etPlantilla = New System.Windows.Forms.Label()
        Me.etCuentaIRProfesional = New System.Windows.Forms.Label()
        Me.txtIRProfesionales = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.etCuentaIRResidente = New System.Windows.Forms.Label()
        Me.txtIRResidentes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMontoServicioGeneral = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkCheque = New System.Windows.Forms.CheckBox()
        Me.chkEfectivo = New System.Windows.Forms.CheckBox()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBanID
        '
        Me.txtBanID.Location = New System.Drawing.Point(8, 440)
        Me.txtBanID.Name = "txtBanID"
        Me.txtBanID.TabIndex = 165
        Me.txtBanID.Text = "0"
        Me.txtBanID.Visible = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.Cancel})
        Me.GroupBox9.Location = New System.Drawing.Point(24, 336)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(240, 88)
        Me.GroupBox9.TabIndex = 142
        Me.GroupBox9.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Button1.Location = New System.Drawing.Point(64, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Pagar"
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Cancel.Location = New System.Drawing.Point(64, 56)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(112, 23)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "Cancelar"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbMes, Me.rbMes})
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(24, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 56)
        Me.GroupBox3.TabIndex = 141
        Me.GroupBox3.TabStop = False
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.ItemHeight = 15
        Me.cbMes.Location = New System.Drawing.Point(72, 16)
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
        Me.rbMes.Location = New System.Drawing.Point(8, 16)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(72, 24)
        Me.rbMes.TabIndex = 1
        Me.rbMes.TabStop = True
        Me.rbMes.Text = "Mes"
        Me.rbMes.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(912, 201)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(80, 16)
        Me.LinkLabel1.TabIndex = 188
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ver Detalles"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(912, 9)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(80, 16)
        Me.LinkLabel2.TabIndex = 187
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Ver Detalles"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(504, 384)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(136, 20)
        Me.txtTotal.TabIndex = 185
        Me.txtTotal.Text = ""
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label14.Location = New System.Drawing.Point(288, 384)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(200, 16)
        Me.Label14.TabIndex = 186
        Me.Label14.Text = "Monto IR Anticipo:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMesAnt
        '
        Me.txtMesAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMesAnt.Location = New System.Drawing.Point(888, 504)
        Me.txtMesAnt.Name = "txtMesAnt"
        Me.txtMesAnt.ReadOnly = True
        Me.txtMesAnt.TabIndex = 184
        Me.txtMesAnt.Text = ""
        Me.txtMesAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMesAnt.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(720, 504)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 16)
        Me.Label13.TabIndex = 183
        Me.Label13.Text = "CREDITO MES ANTERIOR"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(912, 464)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 182
        Me.Label12.Text = "TOTAL"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'txtTotalIR
        '
        Me.txtTotalIR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalIR.Location = New System.Drawing.Point(888, 480)
        Me.txtTotalIR.Name = "txtTotalIR"
        Me.txtTotalIR.ReadOnly = True
        Me.txtTotalIR.TabIndex = 181
        Me.txtTotalIR.Text = ""
        Me.txtTotalIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalIR.Visible = False
        '
        'txtIRVenta
        '
        Me.txtIRVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRVenta.Location = New System.Drawing.Point(496, 480)
        Me.txtIRVenta.Name = "txtIRVenta"
        Me.txtIRVenta.ReadOnly = True
        Me.txtIRVenta.TabIndex = 180
        Me.txtIRVenta.Text = ""
        Me.txtIRVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIRVenta.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(672, 464)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 16)
        Me.Label11.TabIndex = 179
        Me.Label11.Text = "I.R. PAGADO X ANTICIPADO"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Visible = False
        '
        'txtIRPagado
        '
        Me.txtIRPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRPagado.Location = New System.Drawing.Point(720, 480)
        Me.txtIRPagado.Name = "txtIRPagado"
        Me.txtIRPagado.ReadOnly = True
        Me.txtIRPagado.TabIndex = 177
        Me.txtIRPagado.Text = ""
        Me.txtIRPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIRPagado.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(480, 464)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "I.R. SOBRE VENTAS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(288, 440)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(712, 20)
        Me.Label9.TabIndex = 175
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
        Me.Label10.Location = New System.Drawing.Point(288, 456)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(712, 96)
        Me.Label10.TabIndex = 178
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label10.Visible = False
        '
        'txtCredito
        '
        Me.txtCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredito.Location = New System.Drawing.Point(200, 496)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.ReadOnly = True
        Me.txtCredito.TabIndex = 173
        Me.txtCredito.Text = ""
        Me.txtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCredito.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 464)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "CREDITO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-136, 464)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(712, 20)
        Me.Label3.TabIndex = 171
        Me.Label3.Text = "SALDO MES ANTERIOR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(288, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(712, 20)
        Me.Label2.TabIndex = 170
        Me.Label2.Text = "I.R. POR PAGAR"
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
        Me.dgCompras.Location = New System.Drawing.Point(288, 200)
        Me.dgCompras.Name = "dgCompras"
        Me.dgCompras.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgCompras.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCompras.ReadOnly = True
        Me.dgCompras.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgCompras.SelectionForeColor = System.Drawing.Color.White
        Me.dgCompras.Size = New System.Drawing.Size(712, 176)
        Me.dgCompras.TabIndex = 169
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(288, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(712, 20)
        Me.Label1.TabIndex = 168
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
        Me.DGVentas.Location = New System.Drawing.Point(288, 8)
        Me.DGVentas.Name = "DGVentas"
        Me.DGVentas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.DGVentas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGVentas.ReadOnly = True
        Me.DGVentas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.DGVentas.SelectionForeColor = System.Drawing.Color.White
        Me.DGVentas.Size = New System.Drawing.Size(712, 176)
        Me.DGVentas.TabIndex = 167
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(-136, 480)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(712, 48)
        Me.Label7.TabIndex = 174
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkResidente, Me.chkProfesional, Me.chkGeneral, Me.chkAnticipo})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(24, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 160)
        Me.GroupBox1.TabIndex = 189
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleecione IR a Pagar:"
        '
        'chkResidente
        '
        Me.chkResidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResidente.Location = New System.Drawing.Point(16, 120)
        Me.chkResidente.Name = "chkResidente"
        Me.chkResidente.Size = New System.Drawing.Size(216, 24)
        Me.chkResidente.TabIndex = 28
        Me.chkResidente.Text = "Retencion Sobre Residentes"
        '
        'chkProfesional
        '
        Me.chkProfesional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProfesional.Location = New System.Drawing.Point(16, 88)
        Me.chkProfesional.Name = "chkProfesional"
        Me.chkProfesional.Size = New System.Drawing.Size(200, 24)
        Me.chkProfesional.TabIndex = 27
        Me.chkProfesional.Text = "IR Servicios Profesionales"
        '
        'chkGeneral
        '
        Me.chkGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGeneral.Location = New System.Drawing.Point(16, 56)
        Me.chkGeneral.Name = "chkGeneral"
        Me.chkGeneral.Size = New System.Drawing.Size(160, 24)
        Me.chkGeneral.TabIndex = 26
        Me.chkGeneral.Text = "IR Servicio General"
        '
        'chkAnticipo
        '
        Me.chkAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnticipo.Location = New System.Drawing.Point(16, 24)
        Me.chkAnticipo.Name = "chkAnticipo"
        Me.chkAnticipo.Size = New System.Drawing.Size(120, 24)
        Me.chkAnticipo.TabIndex = 25
        Me.chkAnticipo.Text = "IR Anticipo"
        '
        'etPlantilla
        '
        Me.etPlantilla.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.etPlantilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etPlantilla.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.etPlantilla.Location = New System.Drawing.Point(24, 424)
        Me.etPlantilla.Name = "etPlantilla"
        Me.etPlantilla.Size = New System.Drawing.Size(72, 16)
        Me.etPlantilla.TabIndex = 190
        Me.etPlantilla.Text = "Plantilla"
        Me.etPlantilla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etPlantilla.Visible = False
        '
        'etCuentaIRProfesional
        '
        Me.etCuentaIRProfesional.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.etCuentaIRProfesional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCuentaIRProfesional.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.etCuentaIRProfesional.Location = New System.Drawing.Point(88, 424)
        Me.etCuentaIRProfesional.Name = "etCuentaIRProfesional"
        Me.etCuentaIRProfesional.Size = New System.Drawing.Size(144, 16)
        Me.etCuentaIRProfesional.TabIndex = 191
        Me.etCuentaIRProfesional.Text = "Cuenta IR Profesionales"
        Me.etCuentaIRProfesional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etCuentaIRProfesional.Visible = False
        '
        'txtIRProfesionales
        '
        Me.txtIRProfesionales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRProfesionales.Location = New System.Drawing.Point(504, 416)
        Me.txtIRProfesionales.Name = "txtIRProfesionales"
        Me.txtIRProfesionales.ReadOnly = True
        Me.txtIRProfesionales.Size = New System.Drawing.Size(136, 20)
        Me.txtIRProfesionales.TabIndex = 193
        Me.txtIRProfesionales.Text = ""
        Me.txtIRProfesionales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(288, 416)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 16)
        Me.Label5.TabIndex = 192
        Me.Label5.Text = "Monto IR Servicios Profesionales:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etCuentaIRResidente
        '
        Me.etCuentaIRResidente.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.etCuentaIRResidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCuentaIRResidente.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.etCuentaIRResidente.Location = New System.Drawing.Point(88, 448)
        Me.etCuentaIRResidente.Name = "etCuentaIRResidente"
        Me.etCuentaIRResidente.Size = New System.Drawing.Size(144, 16)
        Me.etCuentaIRResidente.TabIndex = 194
        Me.etCuentaIRResidente.Text = "Cuenta IR Profesionales"
        Me.etCuentaIRResidente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etCuentaIRResidente.Visible = False
        '
        'txtIRResidentes
        '
        Me.txtIRResidentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIRResidentes.Location = New System.Drawing.Point(856, 416)
        Me.txtIRResidentes.Name = "txtIRResidentes"
        Me.txtIRResidentes.ReadOnly = True
        Me.txtIRResidentes.Size = New System.Drawing.Size(136, 20)
        Me.txtIRResidentes.TabIndex = 196
        Me.txtIRResidentes.Text = ""
        Me.txtIRResidentes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(656, 416)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 16)
        Me.Label6.TabIndex = 195
        Me.Label6.Text = "Monto IR Sobre Residentes:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoServicioGeneral
        '
        Me.txtMontoServicioGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoServicioGeneral.Location = New System.Drawing.Point(856, 384)
        Me.txtMontoServicioGeneral.Name = "txtMontoServicioGeneral"
        Me.txtMontoServicioGeneral.ReadOnly = True
        Me.txtMontoServicioGeneral.Size = New System.Drawing.Size(136, 20)
        Me.txtMontoServicioGeneral.TabIndex = 197
        Me.txtMontoServicioGeneral.Text = ""
        Me.txtMontoServicioGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label15.Location = New System.Drawing.Point(656, 384)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(192, 16)
        Me.Label15.TabIndex = 198
        Me.Label15.Text = "Monto IR Servicios Generales:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkCheque, Me.chkEfectivo})
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(24, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 96)
        Me.GroupBox2.TabIndex = 199
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FORMA DE PAGO"
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
        Me.chkEfectivo.Location = New System.Drawing.Point(16, 56)
        Me.chkEfectivo.Name = "chkEfectivo"
        Me.chkEfectivo.Size = New System.Drawing.Size(120, 24)
        Me.chkEfectivo.TabIndex = 25
        Me.chkEfectivo.Text = "Efectivo"
        '
        'frmIRxFactura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.txtMontoServicioGeneral, Me.Label15, Me.txtIRResidentes, Me.Label6, Me.etCuentaIRResidente, Me.txtIRProfesionales, Me.Label5, Me.etCuentaIRProfesional, Me.etPlantilla, Me.GroupBox1, Me.LinkLabel1, Me.LinkLabel2, Me.txtTotal, Me.Label14, Me.txtMesAnt, Me.Label13, Me.Label12, Me.txtTotalIR, Me.txtIRVenta, Me.Label11, Me.txtIRPagado, Me.Label8, Me.Label9, Me.Label10, Me.Label2, Me.dgCompras, Me.Label1, Me.DGVentas, Me.txtBanID, Me.GroupBox9, Me.GroupBox3, Me.txtCredito, Me.Label4, Me.Label3, Me.Label7})
        Me.Name = "frmIRxFactura"
        Me.Text = "Contabilización de I.R."
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

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

        'f.Mes = cbMes.SelectedValue
        'f.Year = Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4)

        dsVentas = FactVentasDB.GetIRVentas(FechaDesde, FechaHasta, Mes, 0, (ConfDB.GetConfigDetails().IR_Ventas / 100.0), Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4))
        dsCompras = FactComprasDB.IRComprasMes(Mes, ConfDB.GetConfigDetails().IRServ / 100.0, ConfDB.GetConfigDetails().MontoIR, ConfDB.GetConfigDetails().IRProd / 100.0, ConfDB.GetConfigDetails().IRServ / 100.0, Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4))
        'dsCompras = FactComprasDB.GetIRCompras(FechaDesde, FechaHasta, Mes, 0, 0, ConfDB.GetConfigDetails().MontoIR, ConfDB.GetConfigDetails().IRProd / 100.0, ConfDB.GetConfigDetails().IRServ / 100.0)

        Me.txtIRProfesionales.Text = CDbl(FactComprasDB.ServiciosProfesionales(Mes, Me.etCuentaIRProfesional.Text).Tables("Tablas").Rows(0).Item("IR")).ToString(Round)
        Me.txtIRResidentes.Text = CDbl(FactComprasDB.ServiciosProfesionales(Mes, Me.etCuentaIRResidente.Text).Tables("Tablas").Rows(0).Item("IR")).ToString(Round)

        DGVentas.DataSource = dsVentas.Tables("Tablas").DefaultView
        dgCompras.DataSource = dsCompras.Tables("Tablas").DefaultView

        TablaVentas = dsVentas.Tables("Tablas")
        TablaCompras = dsCompras.Tables("Tablas")

        Dim Valor As Double
        Dim IR As Double
        Dim Saldo As Double

        Valor = 0
        IR = 0
        Saldo = 0

        For i = 0 To dsCompras.Tables("Tablas").Rows.Count - 1
            Valor = Valor + dsCompras.Tables("Tablas").Rows(i).Item("Valor")
            IR = IR + dsCompras.Tables("Tablas").Rows(i).Item("I.R.")
            Saldo = Saldo + dsCompras.Tables("Tablas").Rows(i).Item("Saldo")
        Next

        Dim fila As DataRow = TablaCompras.NewRow()
        fila("Tipo") = "Total Compras"
        fila("Valor") = Valor
        fila("I.R.") = IR
        fila("Saldo") = Saldo
        TablaCompras.Rows.Add(fila)

        r.FormatGenerico(DGVentas, TablaVentas)
        r.FormatGenerico(dgCompras, TablaCompras)

        DGVentas.ReadOnly = True
        dgCompras.ReadOnly = True

        txtIRVenta.Text = 0
        txtIRPagado.Text = 0

        If dsVentas.Tables("Tablas").Rows.Count > 0 Then
            txtTotal.Text = CDbl(dsVentas.Tables("Tablas").Rows(dsVentas.Tables("Tablas").Rows.Count - 1).Item("Saldo")).ToString(Round)
        Else
            txtTotal.Text = CDbl(0).ToString(Round)
        End If

        If Me.dsCompras.Tables("Tablas").Rows.Count > 0 Then
            Me.txtMontoServicioGeneral.Text = CDbl(Me.dsCompras.Tables("Tablas").Rows(Me.dsCompras.Tables("Tablas").Rows.Count - 1).Item("I.R.")).ToString(Round)
        Else
            Me.txtMontoServicioGeneral.Text = CDbl(0).ToString(Round)
        End If

        txtTotalIR.Text = CDbl(txtIRVenta.Text - txtIRPagado.Text).ToString(Round)
        txtMesAnt.Text = CDbl(txtCredito.Text).ToString(Round)
    End Sub

    Private Sub cbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMes.SelectedIndexChanged
        CalculaTotal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ''Dim plan As String
        ''Dim Plantilla As New VB.SysContab.PlantillaDB()

        ''plan = Plantilla.GetTipoPlantilla(3, 3).ToString

        ''If plan = "" Or plan Is DBNull.Value Then
        ''    MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
        ''    Exit Sub
        ''End If

        If Me.chkAnticipo.Checked = False And Me.chkGeneral.Checked = False _
        And Me.chkProfesional.Checked = False And Me.chkResidente.Checked = False Then
            MsgBox("Seleccione el I.R que desea pagar", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Verificar si el monto a pagar de cada IR Seleccionado es > 0
        If Me.chkAnticipo.Checked = True And CDbl(Me.txtTotal.Text) <= 0 Then
            MsgBox("El Monto del IR Anticipo debe ser mayor que Cero", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.chkGeneral.Checked = True And CDbl(Me.txtMontoServicioGeneral.Text) <= 0 Then
            MsgBox("El Monto del IR de Servicios Generales debe ser mayor que Cero", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.chkProfesional.Checked = True And CDbl(Me.txtIRProfesionales.Text) <= 0 Then
            MsgBox("El Monto del IR de Servicios Profesionales debe ser mayor queCero", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.chkResidente.Checked = True And CDbl(Me.txtIRResidentes.Text) <= 0 Then
            MsgBox("El Monto del IR de Residentes debe ser mayor que Cero", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.chkCheque.Checked = True Then
            Dim f As frmBancosImpuestos = f.Instance
            f.etPlantilla.Text = Me.etPlantilla.Text

            f.Mes = cbMes.SelectedValue
            f.Year = Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4)

            f.IRAnticipo = Me.chkAnticipo.Checked
            f.IRGeneral = Me.chkGeneral.Checked
            f.IRProfesional = Me.chkProfesional.Checked
            f.IRResidente = Me.chkResidente.Checked

            f.MontoAnticipo = CDbl(Me.txtTotal.Text)
            f.MontoGeneral = CDbl(Me.txtMontoServicioGeneral.Text)
            f.MontoProfesional = CDbl(Me.txtIRProfesionales.Text)
            f.MontoResidente = CDbl(Me.txtIRResidentes.Text)

            f.MdiParent = Me.MdiParent
            'fr.Origen = 2
            'f.lblFactMonto.Text = CDbl(Me.txtTotal.Text) + CDbl(Me.txtMontoServicioGeneral.Text) + CDbl(Me.txtIRProfesionales.Text) + CDbl(Me.txtIRResidentes.Text)
            f.lblFactMonto.Text = IIf(Me.chkAnticipo.Checked, CDbl(Me.txtTotal.Text), 0) + IIf(Me.chkGeneral.Checked, CDbl(Me.txtMontoServicioGeneral.Text), 0) + IIf(Me.chkProfesional.Checked, CDbl(Me.txtIRProfesionales.Text), 0) + IIf(Me.chkResidente.Checked, CDbl(Me.txtIRResidentes.Text), 0)
            'MsgBox(IIf(Me.chkAnticipo.Checked, CDbl(Me.txtTotal.Text), 0))
            f.Show()

        Else

            Dim f As DataGridTextBox.frmComprobanteImpuestosCaja = f.Instance
            f.etPlantilla.Text = Me.etPlantilla.Text

            f.Mes = cbMes.SelectedValue
            f.Year = Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4)

            f.IRAnticipo = Me.chkAnticipo.Checked
            f.IRGeneral = Me.chkGeneral.Checked
            f.IRProfesional = Me.chkProfesional.Checked
            f.IRResidente = Me.chkResidente.Checked

            f.MontoAnticipo = CDbl(Me.txtTotal.Text)
            f.MontoGeneral = CDbl(Me.txtMontoServicioGeneral.Text)
            f.MontoProfesional = CDbl(Me.txtIRProfesionales.Text)
            f.MontoResidente = CDbl(Me.txtIRResidentes.Text)

            f.MdiParent = Me.MdiParent
            'fr.Origen = 2
            'f.lblFactMonto.Text = CDbl(Me.txtTotal.Text) + CDbl(Me.txtMontoServicioGeneral.Text) + CDbl(Me.txtIRProfesionales.Text) + CDbl(Me.txtIRResidentes.Text)
            'f.lblFactMonto.Text = IIf(Me.chkAnticipo.Checked, CDbl(Me.txtTotal.Text), 0) + IIf(Me.chkGeneral.Checked, CDbl(Me.txtMontoServicioGeneral.Text), 0) + IIf(Me.chkProfesional.Checked, CDbl(Me.txtIRProfesionales.Text), 0) + IIf(Me.chkResidente.Checked, CDbl(Me.txtIRResidentes.Text), 0)
            f.txtValor.Text = IIf(Me.chkAnticipo.Checked, CDbl(Me.txtTotal.Text), 0) + IIf(Me.chkGeneral.Checked, CDbl(Me.txtMontoServicioGeneral.Text), 0) + IIf(Me.chkProfesional.Checked, CDbl(Me.txtIRProfesionales.Text), 0) + IIf(Me.chkResidente.Checked, CDbl(Me.txtIRResidentes.Text), 0)
            f.txtValor.Text = CDbl(f.txtValor.Text).ToString(Round)
            'MsgBox(IIf(Me.chkAnticipo.Checked, CDbl(Me.txtTotal.Text), 0))
            f.Show()

        End If



        'If CDbl(txtTotal.Text) > 0 Then
        '    Dim fr As frmPlantillasBancos = fr.Instance
        '    fr.MdiParent = Me.MdiParent
        '    fr.Origen = 2
        '    fr.lblFactMonto.Text = Me.txtTotal.Text
        '    fr.Show()
        'Else
        '    Dim CuentaIRVenta As String
        '    Dim CuentaIVPagado As String

        '    Dim plan As String
        '    plan = PlantillasDB.GetTipoPlantilla(2, 3).ToString

        '    If plan = "" Or plan Is DBNull.Value Then
        '        MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
        '        Exit Sub
        '    End If

        '    Dim TipoCOmpr As String = PlantillasDB.GetPlantillasDetails(3, 2).TipoCompr

        '    If PlantillasDB.GetPlantillasDetails(3, 2).PlaID Is DBNull.Value Or PlantillasDB.GetPlantillasDetails(3, 2).PlaID <> "" Or Not PlantillasDB.GetPlantillasDetails(3, 2).PlaID Is Nothing Then

        '        Dim DsPlantillas As DataSet = PlantillasDB.GetPlantillasDetails(3, 2).Detalles

        '        CuentaIVPagado = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        '        CuentaIRVenta = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")

        '        ' FALTA LA TASA DE CAMBIO y MONEDA

        '        If ComprobantesDB.GeneraComprobanteIR(0, txtTotal.Text, "Total de IVA del mes de " & MesConcepto, _
        '                         CuentaIRVenta, CDbl(txtIRVenta.Text), "IVA Soportado del mes " & MesConcepto, CuentaIVPagado, CDbl(txtIRPagado.Text), _
        '                         "IVA Repercutido del mes " & Mes, TipoCOmpr, 1, 1, "Comprobante de IVA", TipoCOmpr, Today) = True Then

        '            MsgBox("Se ha pagado correctamente la Factura")

        '        Else
        '            MsgBox("No se ha podido contabilizar la Factura")
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub txtBanID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBanID.TextChanged

        'If (Not txtBanID.Text Is DBNull.Value Or txtBanID.Text <> "" Or Not txtBanID.Text Is Nothing) And txtBanID.Text <> "0" Then

        '    Dim CuentaIRVenta As String
        '    Dim CuentaIVPagado As String

        '    Dim TipoCOmpr As String = PlantillasDB.GetPlantillasDetails(3, 2).TipoCompr

        '    If PlantillasDB.GetPlantillasDetails(3, 2).PlaID Is DBNull.Value Or PlantillasDB.GetPlantillasDetails(3, 2).PlaID <> "" Or Not PlantillasDB.GetPlantillasDetails(3, 2).PlaID Is Nothing Then


        '        Dim DsPlantillas As DataSet = PlantillasDB.GetPlantillasDetails(3, 2).Detalles

        '        CuentaIVPagado = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        '        CuentaIRVenta = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")

        '        ' FALTA LA TASA DE CAMBIO y MONEDA

        '        If ComprobantesDB.GeneraComprobanteIR(txtBanID.Text, txtTotal.Text, "Total de IVA del mes de " & MesConcepto, _
        '                         CuentaIRVenta, CDbl(txtIRVenta.Text), "IVA Soportado del mes " & MesConcepto, CuentaIVPagado, CDbl(txtIRPagado.Text), _
        '                         "IVA Repercutido del mes " & Mes, TipoCOmpr, 1, 1, "Comprobante de IVA", TipoCOmpr, Today) = True Then


        '            MsgBox("Se ha contabilizado correctamente la Factura")

        '        Else

        '            MsgBox("No se ha podido contabilizar la Factura")

        '        End If

        '    End If


        'End If

    End Sub


    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim fr As frmIRFacturaDetalles = fr.Instance
        fr.MdiParent = Me.MdiParent

        fr.Mes = Mes
        fr.FechaDesde = FechaDesde
        fr.FechaHasta = FechaHasta
        fr.Tipo = 1
        fr.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim fr As frmReporteIVADetalles = fr.Instance
        fr.MdiParent = Me.MdiParent
        fr.Mes = Mes
        fr.FechaDesde = FechaDesde
        fr.FechaHasta = FechaHasta
        fr.Tipo = 2
        fr.Show()
    End Sub

    Private Sub chkEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEfectivo.CheckedChanged
        Me.chkCheque.Checked = Not Me.chkEfectivo.Checked
    End Sub

    Private Sub chkCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheque.CheckedChanged
        Me.chkEfectivo.Checked = Not Me.chkCheque.Checked
    End Sub
End Class
