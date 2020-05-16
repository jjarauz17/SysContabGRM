
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Namespace DataGridTextBox

    Public Class frmComprobanteTipoServicios
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmComprobanteTipoServicios = Nothing

        Public Shared Function Instance() As frmComprobanteTipoServicios
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmComprobanteTipoServicios
            End If
            ChildInstance.BringToFront()

            Return ChildInstance
        End Function


        Dim Tasa As New VB.SysContab.Tasa_CambioDB
        Dim Plantilla As New VB.SysContab.PlantillaDB
        Dim CatalogoDB As New VB.SysContab.CatalogoDB
        Dim Rutinas As New VB.SysContab.Rutinas
        Dim Conf As New VB.SysContab.ConfiguracionDB
        Dim Comprobantes As New VB.SysContab.ComprobanteDB
        Private WithEvents myDataSet As DataSet
        Dim WithEvents tCust As DataTable

        Dim WithEvents ProdServ As DataGridTextBoxColumn
        Dim WithEvents Cuenta As DataGridTextBoxColumn
        Dim WithEvents Catalogo As DataGridTextBoxColumn
        Dim WithEvents Monto As DataGridTextBoxColumn
        Dim WithEvents Descripcion As DataGridTextBoxColumn
        Dim WithEvents DC As DataGridTextBoxColumn
        Dim EmpresasDB As New VB.SysContab.EmpresasDB
        Dim MonedaDB As New VB.SysContab.MonedaDB
        Dim PeriodosDB As New VB.SysContab.PeriodosDB


        Dim compDet As New VB.SysContab.ComprobantesDetails
        Dim r As New VB.SysContab.Rutinas
        Dim Mes As New VB.SysContab.MesesDB
        Dim PerDB As New VB.SysContab.PeriodosDB
        Dim CatalogoBancos As New VB.SysContab.Catalogo_BancosDB

        Dim ds As DataSet
        Dim i As Integer
        Dim j As Integer
        Public Banco As String
        Public BancoID As String
        Public VarProv As String
        Public VarProvID As String
        Public EsqID As String
        Public TipoCompr As String
        Dim CuentaProveedor As String

        Dim TipoCuenta As String

        Dim Proveedores As New VB.SysContab.ProveedoresDB
        Dim DPROV As New VB.SysContab.ProveedoresDetails
        Public Basico As String = ""
        Public Consecutivo As String = ""
        Public Servicio As String = ""
        Public SUBTOTAL As Double
        Public compFact As Integer = 0
        Public compMes As Integer = 0
        Public compPerID As Integer = 0

        Dim RetIR As Double
        Dim Valor As Double
        Dim Config As New VB.SysContab.ConfiguracionDB
        Dim ConfigDet As VB.SysContab.ConfiguracionDetails = Config.GetConfigDetails()
        Dim Fechas As New VB.SysContab.FechasdeTrabajo

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
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents txtTasaCambio As System.Windows.Forms.TextBox
        Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents NoComprobante As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dgFacturacionCliente As System.Windows.Forms.DataGrid
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtFact As System.Windows.Forms.TextBox
        Friend WithEvents lblFact As System.Windows.Forms.Label
        Friend WithEvents txtCheque As System.Windows.Forms.TextBox
        Friend WithEvents lblCheque As System.Windows.Forms.Label
        Friend WithEvents lblProv As System.Windows.Forms.Label
        Friend WithEvents lblBanco As System.Windows.Forms.Label
        Friend WithEvents txtValor As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtTipo As System.Windows.Forms.TextBox
        Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
        Friend WithEvents lblDebTotal As System.Windows.Forms.Label
        Friend WithEvents lblCredTotal As System.Windows.Forms.Label
        Friend WithEvents etTotalT As System.Windows.Forms.Label
        Friend WithEvents Label39 As System.Windows.Forms.Label
        Friend WithEvents Label38 As System.Windows.Forms.Label
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents txtProv As System.Windows.Forms.TextBox
        Friend WithEvents txtBanco As System.Windows.Forms.TextBox
        Friend WithEvents txtProvID As System.Windows.Forms.TextBox
        Friend WithEvents xddlBanco As System.Windows.Forms.ComboBox
        Friend WithEvents xddlProv As System.Windows.Forms.ComboBox
        Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtNotaCredito As System.Windows.Forms.TextBox
        Friend WithEvents txtCodigoProveedor As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtChequeNombre As System.Windows.Forms.TextBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label25 = New System.Windows.Forms.Label
            Me.txtTasaCambio = New System.Windows.Forms.TextBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.NoComprobante = New System.Windows.Forms.TextBox
            Me.Label7 = New System.Windows.Forms.Label
            Me.txtConcepto = New System.Windows.Forms.TextBox
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.txtChequeNombre = New System.Windows.Forms.TextBox
            Me.Label8 = New System.Windows.Forms.Label
            Me.txtCodigoProveedor = New System.Windows.Forms.TextBox
            Me.txtNotaCredito = New System.Windows.Forms.TextBox
            Me.Label5 = New System.Windows.Forms.Label
            Me.txtProvID = New System.Windows.Forms.TextBox
            Me.txtBanco = New System.Windows.Forms.TextBox
            Me.txtProv = New System.Windows.Forms.TextBox
            Me.lblTotal = New System.Windows.Forms.Label
            Me.Label39 = New System.Windows.Forms.Label
            Me.Label38 = New System.Windows.Forms.Label
            Me.lblDebTotal = New System.Windows.Forms.Label
            Me.lblCredTotal = New System.Windows.Forms.Label
            Me.etTotalT = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.lblProv = New System.Windows.Forms.Label
            Me.lblBanco = New System.Windows.Forms.Label
            Me.xddlBanco = New System.Windows.Forms.ComboBox
            Me.xddlProv = New System.Windows.Forms.ComboBox
            Me.txtValor = New System.Windows.Forms.TextBox
            Me.Label6 = New System.Windows.Forms.Label
            Me.dgFacturacionCliente = New System.Windows.Forms.DataGrid
            Me.txtFact = New System.Windows.Forms.TextBox
            Me.lblFact = New System.Windows.Forms.Label
            Me.txtCheque = New System.Windows.Forms.TextBox
            Me.lblCheque = New System.Windows.Forms.Label
            Me.dtFecha = New System.Windows.Forms.DateTimePicker
            Me.txtMoneda = New System.Windows.Forms.TextBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.txtTipo = New System.Windows.Forms.TextBox
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label1.Location = New System.Drawing.Point(80, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 24)
            Me.Label1.TabIndex = 114
            Me.Label1.Text = "Fecha :"
            '
            'Label25
            '
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label25.Location = New System.Drawing.Point(672, 8)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(80, 24)
            Me.Label25.TabIndex = 141
            Me.Label25.Text = "Tipo:"
            '
            'txtTasaCambio
            '
            Me.txtTasaCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTasaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTasaCambio.Location = New System.Drawing.Point(352, 8)
            Me.txtTasaCambio.MaxLength = 50
            Me.txtTasaCambio.Name = "txtTasaCambio"
            Me.txtTasaCambio.Size = New System.Drawing.Size(120, 20)
            Me.txtTasaCambio.TabIndex = 0
            Me.txtTasaCambio.Text = ""
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label3.Location = New System.Drawing.Point(256, 8)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(88, 24)
            Me.Label3.TabIndex = 103
            Me.Label3.Text = "Tasa Cambio"
            '
            'NoComprobante
            '
            Me.NoComprobante.BackColor = System.Drawing.Color.White
            Me.NoComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.NoComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NoComprobante.Location = New System.Drawing.Point(120, 8)
            Me.NoComprobante.MaxLength = 50
            Me.NoComprobante.Name = "NoComprobante"
            Me.NoComprobante.ReadOnly = True
            Me.NoComprobante.Size = New System.Drawing.Size(120, 20)
            Me.NoComprobante.TabIndex = 0
            Me.NoComprobante.Text = ""
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label7.Location = New System.Drawing.Point(16, 8)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(104, 24)
            Me.Label7.TabIndex = 124
            Me.Label7.Text = "No. Comprobante"
            '
            'txtConcepto
            '
            Me.txtConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
            Me.txtConcepto.Location = New System.Drawing.Point(8, 392)
            Me.txtConcepto.Multiline = True
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtConcepto.Size = New System.Drawing.Size(872, 40)
            Me.txtConcepto.TabIndex = 6
            Me.txtConcepto.Text = ""
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(189, Byte), CType(210, Byte), CType(210, Byte))
            Me.GroupBox1.Controls.Add(Me.txtChequeNombre)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.txtCodigoProveedor)
            Me.GroupBox1.Controls.Add(Me.txtNotaCredito)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.txtProvID)
            Me.GroupBox1.Controls.Add(Me.txtBanco)
            Me.GroupBox1.Controls.Add(Me.txtProv)
            Me.GroupBox1.Controls.Add(Me.lblTotal)
            Me.GroupBox1.Controls.Add(Me.Label39)
            Me.GroupBox1.Controls.Add(Me.Label38)
            Me.GroupBox1.Controls.Add(Me.lblDebTotal)
            Me.GroupBox1.Controls.Add(Me.lblCredTotal)
            Me.GroupBox1.Controls.Add(Me.etTotalT)
            Me.GroupBox1.Controls.Add(Me.txtConcepto)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.lblProv)
            Me.GroupBox1.Controls.Add(Me.lblBanco)
            Me.GroupBox1.Controls.Add(Me.xddlBanco)
            Me.GroupBox1.Controls.Add(Me.xddlProv)
            Me.GroupBox1.Controls.Add(Me.txtValor)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.dgFacturacionCliente)
            Me.GroupBox1.Controls.Add(Me.txtFact)
            Me.GroupBox1.Controls.Add(Me.lblFact)
            Me.GroupBox1.Controls.Add(Me.txtCheque)
            Me.GroupBox1.Controls.Add(Me.lblCheque)
            Me.GroupBox1.Controls.Add(Me.dtFecha)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(888, 448)
            Me.GroupBox1.TabIndex = 148
            Me.GroupBox1.TabStop = False
            '
            'txtChequeNombre
            '
            Me.txtChequeNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtChequeNombre.Location = New System.Drawing.Point(16, 336)
            Me.txtChequeNombre.Name = "txtChequeNombre"
            Me.txtChequeNombre.Size = New System.Drawing.Size(360, 20)
            Me.txtChequeNombre.TabIndex = 5
            Me.txtChequeNombre.Text = ""
            '
            'Label8
            '
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label8.Location = New System.Drawing.Point(16, 320)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(184, 24)
            Me.Label8.TabIndex = 1014
            Me.Label8.Text = "Pagar cheque a nombre:"
            '
            'txtCodigoProveedor
            '
            Me.txtCodigoProveedor.BackColor = System.Drawing.Color.White
            Me.txtCodigoProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCodigoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCodigoProveedor.Location = New System.Drawing.Point(680, 48)
            Me.txtCodigoProveedor.MaxLength = 50
            Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
            Me.txtCodigoProveedor.ReadOnly = True
            Me.txtCodigoProveedor.Size = New System.Drawing.Size(136, 20)
            Me.txtCodigoProveedor.TabIndex = 1013
            Me.txtCodigoProveedor.Text = "Codigo Proveedor"
            Me.txtCodigoProveedor.Visible = False
            '
            'txtNotaCredito
            '
            Me.txtNotaCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtNotaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNotaCredito.Location = New System.Drawing.Point(736, 80)
            Me.txtNotaCredito.MaxLength = 13
            Me.txtNotaCredito.Name = "txtNotaCredito"
            Me.txtNotaCredito.Size = New System.Drawing.Size(144, 22)
            Me.txtNotaCredito.TabIndex = 1012
            Me.txtNotaCredito.Text = ""
            Me.txtNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(189, Byte), CType(210, Byte), CType(210, Byte))
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label5.Location = New System.Drawing.Point(624, 80)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(120, 24)
            Me.Label5.TabIndex = 1011
            Me.Label5.Text = "Nota de Crédito:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtProvID
            '
            Me.txtProvID.BackColor = System.Drawing.Color.White
            Me.txtProvID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtProvID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtProvID.Location = New System.Drawing.Point(680, 16)
            Me.txtProvID.MaxLength = 50
            Me.txtProvID.Name = "txtProvID"
            Me.txtProvID.ReadOnly = True
            Me.txtProvID.Size = New System.Drawing.Size(200, 20)
            Me.txtProvID.TabIndex = 1010
            Me.txtProvID.Text = ""
            Me.txtProvID.Visible = False
            '
            'txtBanco
            '
            Me.txtBanco.BackColor = System.Drawing.Color.White
            Me.txtBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBanco.Location = New System.Drawing.Point(128, 80)
            Me.txtBanco.MaxLength = 50
            Me.txtBanco.Name = "txtBanco"
            Me.txtBanco.ReadOnly = True
            Me.txtBanco.Size = New System.Drawing.Size(200, 20)
            Me.txtBanco.TabIndex = 1009
            Me.txtBanco.Text = ""
            '
            'txtProv
            '
            Me.txtProv.BackColor = System.Drawing.Color.White
            Me.txtProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtProv.Location = New System.Drawing.Point(128, 48)
            Me.txtProv.MaxLength = 50
            Me.txtProv.Name = "txtProv"
            Me.txtProv.ReadOnly = True
            Me.txtProv.Size = New System.Drawing.Size(200, 20)
            Me.txtProv.TabIndex = 1007
            Me.txtProv.Text = ""
            '
            'lblTotal
            '
            Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.ForeColor = System.Drawing.Color.Maroon
            Me.lblTotal.Location = New System.Drawing.Point(720, 352)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(120, 16)
            Me.lblTotal.TabIndex = 1006
            Me.lblTotal.Text = "0.00"
            Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label39
            '
            Me.Label39.BackColor = System.Drawing.Color.Transparent
            Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
            Me.Label39.Location = New System.Drawing.Point(616, 312)
            Me.Label39.Name = "Label39"
            Me.Label39.Size = New System.Drawing.Size(96, 23)
            Me.Label39.TabIndex = 1005
            Me.Label39.Text = "CREDITO"
            '
            'Label38
            '
            Me.Label38.BackColor = System.Drawing.Color.Transparent
            Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
            Me.Label38.Location = New System.Drawing.Point(488, 312)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(80, 23)
            Me.Label38.TabIndex = 1004
            Me.Label38.Text = "DEBITO"
            '
            'lblDebTotal
            '
            Me.lblDebTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDebTotal.ForeColor = System.Drawing.Color.Maroon
            Me.lblDebTotal.Location = New System.Drawing.Point(440, 352)
            Me.lblDebTotal.Name = "lblDebTotal"
            Me.lblDebTotal.Size = New System.Drawing.Size(120, 16)
            Me.lblDebTotal.TabIndex = 1003
            Me.lblDebTotal.Text = "0.00"
            Me.lblDebTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblCredTotal
            '
            Me.lblCredTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCredTotal.ForeColor = System.Drawing.Color.Maroon
            Me.lblCredTotal.Location = New System.Drawing.Point(584, 352)
            Me.lblCredTotal.Name = "lblCredTotal"
            Me.lblCredTotal.Size = New System.Drawing.Size(120, 16)
            Me.lblCredTotal.TabIndex = 1002
            Me.lblCredTotal.Text = "0.00"
            Me.lblCredTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etTotalT
            '
            Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etTotalT.Location = New System.Drawing.Point(736, 312)
            Me.etTotalT.Name = "etTotalT"
            Me.etTotalT.Size = New System.Drawing.Size(128, 24)
            Me.etTotalT.TabIndex = 1001
            Me.etTotalT.Text = "DIFERENCIA"
            Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label4.Location = New System.Drawing.Point(16, 376)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(128, 24)
            Me.Label4.TabIndex = 161
            Me.Label4.Text = "Comentario:"
            '
            'lblProv
            '
            Me.lblProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblProv.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.lblProv.Location = New System.Drawing.Point(16, 48)
            Me.lblProv.Name = "lblProv"
            Me.lblProv.Size = New System.Drawing.Size(104, 24)
            Me.lblProv.TabIndex = 160
            Me.lblProv.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblBanco
            '
            Me.lblBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBanco.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.lblBanco.Location = New System.Drawing.Point(16, 80)
            Me.lblBanco.Name = "lblBanco"
            Me.lblBanco.Size = New System.Drawing.Size(104, 24)
            Me.lblBanco.TabIndex = 159
            Me.lblBanco.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'xddlBanco
            '
            Me.xddlBanco.Location = New System.Drawing.Point(128, 80)
            Me.xddlBanco.Name = "xddlBanco"
            Me.xddlBanco.Size = New System.Drawing.Size(200, 21)
            Me.xddlBanco.TabIndex = 2
            Me.xddlBanco.Text = "ComboBox2"
            '
            'xddlProv
            '
            Me.xddlProv.Location = New System.Drawing.Point(128, 48)
            Me.xddlProv.Name = "xddlProv"
            Me.xddlProv.Size = New System.Drawing.Size(200, 21)
            Me.xddlProv.TabIndex = 1
            '
            'txtValor
            '
            Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValor.Location = New System.Drawing.Point(480, 80)
            Me.txtValor.Name = "txtValor"
            Me.txtValor.ReadOnly = True
            Me.txtValor.Size = New System.Drawing.Size(128, 20)
            Me.txtValor.TabIndex = 5
            Me.txtValor.Text = ""
            '
            'Label6
            '
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label6.Location = New System.Drawing.Point(440, 80)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(104, 24)
            Me.Label6.TabIndex = 153
            Me.Label6.Text = "Valor:"
            '
            'dgFacturacionCliente
            '
            Me.dgFacturacionCliente.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
            Me.dgFacturacionCliente.BackColor = System.Drawing.Color.Gainsboro
            Me.dgFacturacionCliente.BackgroundColor = System.Drawing.Color.DarkGray
            Me.dgFacturacionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgFacturacionCliente.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgFacturacionCliente.CaptionForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.DataMember = ""
            Me.dgFacturacionCliente.FlatMode = True
            Me.dgFacturacionCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgFacturacionCliente.ForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.GridLineColor = System.Drawing.Color.Silver
            Me.dgFacturacionCliente.HeaderBackColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgFacturacionCliente.HeaderForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.LinkColor = System.Drawing.Color.DarkSlateBlue
            Me.dgFacturacionCliente.Location = New System.Drawing.Point(8, 112)
            Me.dgFacturacionCliente.Name = "dgFacturacionCliente"
            Me.dgFacturacionCliente.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgFacturacionCliente.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgFacturacionCliente.SelectionForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.Size = New System.Drawing.Size(872, 192)
            Me.dgFacturacionCliente.TabIndex = 1000
            '
            'txtFact
            '
            Me.txtFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFact.Location = New System.Drawing.Point(480, 16)
            Me.txtFact.Name = "txtFact"
            Me.txtFact.ReadOnly = True
            Me.txtFact.Size = New System.Drawing.Size(128, 20)
            Me.txtFact.TabIndex = 3
            Me.txtFact.Text = ""
            '
            'lblFact
            '
            Me.lblFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFact.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.lblFact.Location = New System.Drawing.Point(376, 24)
            Me.lblFact.Name = "lblFact"
            Me.lblFact.Size = New System.Drawing.Size(104, 24)
            Me.lblFact.TabIndex = 149
            Me.lblFact.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtCheque
            '
            Me.txtCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCheque.Location = New System.Drawing.Point(480, 48)
            Me.txtCheque.Name = "txtCheque"
            Me.txtCheque.Size = New System.Drawing.Size(128, 20)
            Me.txtCheque.TabIndex = 4
            Me.txtCheque.Text = ""
            '
            'lblCheque
            '
            Me.lblCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCheque.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.lblCheque.Location = New System.Drawing.Point(376, 56)
            Me.lblCheque.Name = "lblCheque"
            Me.lblCheque.Size = New System.Drawing.Size(104, 24)
            Me.lblCheque.TabIndex = 147
            Me.lblCheque.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtFecha
            '
            Me.dtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtFecha.Location = New System.Drawing.Point(128, 16)
            Me.dtFecha.Name = "dtFecha"
            Me.dtFecha.Size = New System.Drawing.Size(104, 20)
            Me.dtFecha.TabIndex = 0
            '
            'txtMoneda
            '
            Me.txtMoneda.BackColor = System.Drawing.Color.White
            Me.txtMoneda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMoneda.Location = New System.Drawing.Point(544, 8)
            Me.txtMoneda.MaxLength = 50
            Me.txtMoneda.Name = "txtMoneda"
            Me.txtMoneda.ReadOnly = True
            Me.txtMoneda.Size = New System.Drawing.Size(120, 20)
            Me.txtMoneda.TabIndex = 0
            Me.txtMoneda.Text = ""
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label2.Location = New System.Drawing.Point(472, 8)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(80, 24)
            Me.Label2.TabIndex = 145
            Me.Label2.Text = "Moneda:"
            '
            'txtTipo
            '
            Me.txtTipo.BackColor = System.Drawing.Color.White
            Me.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipo.Location = New System.Drawing.Point(712, 8)
            Me.txtTipo.MaxLength = 50
            Me.txtTipo.Name = "txtTipo"
            Me.txtTipo.ReadOnly = True
            Me.txtTipo.Size = New System.Drawing.Size(280, 20)
            Me.txtTipo.TabIndex = 0
            Me.txtTipo.Text = ""
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.cmdAceptar)
            Me.GroupBox2.Controls.Add(Me.cmdCancelar)
            Me.GroupBox2.Location = New System.Drawing.Point(904, 40)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(104, 448)
            Me.GroupBox2.TabIndex = 149
            Me.GroupBox2.TabStop = False
            '
            'cmdAceptar
            '
            Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.Location = New System.Drawing.Point(8, 16)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(88, 32)
            Me.cmdAceptar.TabIndex = 7
            Me.cmdAceptar.Text = "Aceptar"
            '
            'cmdCancelar
            '
            Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.Location = New System.Drawing.Point(8, 64)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(88, 32)
            Me.cmdCancelar.TabIndex = 3
            Me.cmdCancelar.Text = "Salir"
            '
            'frmComprobanteTipo1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(236, Byte), CType(236, Byte))
            Me.ClientSize = New System.Drawing.Size(1016, 526)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.txtMoneda)
            Me.Controls.Add(Me.txtTasaCambio)
            Me.Controls.Add(Me.NoComprobante)
            Me.Controls.Add(Me.txtTipo)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label25)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
            Me.Name = "frmComprobanteTipo1"
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region


        Private Sub frmComprobantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.Text = "Comprobante Diario"
            DPROV = VB.SysContab.ProveedoresDB.GetDetails(Me.txtCodigoProveedor.Text)
            CuentaProveedor = DPROV.Cuenta

            LeaveCommit = False

            Me.txtNotaCredito.Text = CDbl(0).ToString(Round)
            Me.txtConcepto.CharacterCasing = CharacterCasing.Upper


            If Tasa.GetTasaCambioDia(Today.Month, Today.Year, Today.Day).Tables("Tasa_Cambio").Rows.Count = 0 Then
                txtTasaCambio.Text = 0
            Else
                txtTasaCambio.Text = Tasa.GetTasaCambioDia(Today.Month, Today.Year, Today.Day).Tables("Tasa_Cambio").Rows(0).Item("Tasa_Cambio")
            End If

            dtFecha.MinDate = Fechas.FechaMinima 'PeriodosDB.GetDetails(PeriodosDB.Activo).Inicio
            dtFecha.MaxDate = Fechas.FechaMaxima 'PeriodosDB.GetDetails(PeriodosDB.Activo).Final


            lblFact.Text = "Factura"
            lblCheque.Text = "No. Cheque"

            lblProv.Text = "Proveedor"
            lblBanco.Text = "Bancos"

            EsqID = ""

            MakeDataSet()
            dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()
            txtBanco.Text = CatalogoDB.GetDetails(Banco).Nombre
            txtMoneda.Text = MonedaDB.GetDetails(EmpresasDB.GetDetails(EmpresaActual).MonedaBase).Descripcion

        End Sub



        Private Sub MakeDataSet()

            ' Create a DataSet.
            myDataSet = New DataSet("myDataSet")

            ' Create two DataTables.
            'Dim tCust As DataTable
            tCust = New DataTable("Articulos")

            ' Add them to the first table.
            Dim cCuenta As DataColumn
            cCuenta = New DataColumn("Cuenta")
            tCust.Columns.Add(cCuenta)

            Dim cProdServ As DataColumn
            cProdServ = New DataColumn("ProdServ")
            tCust.Columns.Add(cProdServ)

            Dim cCatalogo As DataColumn
            cCatalogo = New DataColumn("Catalogo")
            tCust.Columns.Add(cCatalogo)

            Dim cDescripcion As DataColumn
            cDescripcion = New DataColumn("Descripcion")
            tCust.Columns.Add(cDescripcion)


            Dim cMonto As DataColumn
            cMonto = New DataColumn("Monto")
            tCust.Columns.Add(cMonto)


            Dim cDC As DataColumn
            cDC = New DataColumn("DC")
            tCust.Columns.Add(cDC)

            'tCust.Columns.Add(cCurrent2)
            ' Add the tables to the DataSet.
            myDataSet.Tables.Add(tCust)

            Dim newRow1 As DataRow
            j = 0
            'Agregar la cuenta del Proveedor
            newRow1 = tCust.NewRow
            tCust.Rows.Add(newRow1)
            tCust.Rows(j)("ProdServ") = Me.Basico
            If CatalogoDB.GetDetails(CuentaProveedor).Tipo = "A" Then
                tCust.Rows(j)("Cuenta") = CuentaProveedor
                tCust.Rows(j)("Catalogo") = CuentaProveedor
                tCust.Rows(j)("Monto") = Me.txtValor.Text
                tCust.Rows(j)("Descripcion") = Me.Consecutivo
            Else
                tCust.Rows(j)("Catalogo") = ""
            End If
            tCust.Rows(j)("DC") = "Débito"

            lblDebTotal.Text = CDbl(Me.txtValor.Text).ToString(Round)
            lblCredTotal.Text = CDbl(Me.txtValor.Text).ToString(Round)
            lblTotal.Text = (CDbl(lblDebTotal.Text) - CDbl(lblCredTotal.Text)).ToString(Round)

        End Sub


        Private Sub AddCustomDataTableStyle()

            Dim ts1 As DataGridTableStyle
            ts1 = New DataGridTableStyle
            ts1.MappingName = "Articulos"
            ts1.AlternatingBackColor = Color.LightBlue
            Dim colCount As Integer
            colCount = 0

            ' Producto / Servicio
            ProdServ = New DataGridTextBoxColumn
            ProdServ.MappingName = "ProdServ"
            ProdServ.HeaderText = "Producto/Servicio"
            ProdServ.Width = 120
            ProdServ.ReadOnly = True
            ts1.GridColumnStyles.Add(ProdServ)
            ts1.PreferredRowHeight = (ProdServ.TextBox.Height + 3)
            ProdServ.NullText = ""
            colCount = (colCount + 1)


            ' CUENTA
            Cuenta = New DataGridTextBoxColumn
            Cuenta.MappingName = "Cuenta"
            Cuenta.HeaderText = "Cuenta"
            Cuenta.Width = 0
            Cuenta.ReadOnly = True
            ts1.GridColumnStyles.Add(Cuenta)
            ts1.PreferredRowHeight = (Cuenta.TextBox.Height + 3)
            Cuenta.NullText = ""
            colCount = (colCount + 1)


            ' CATALOGO
            Catalogo = New DataGridTextBoxColumn
            Catalogo.MappingName = "Catalogo"
            Catalogo.HeaderText = "Catalogo"
            Catalogo.Width = 200
            ts1.GridColumnStyles.Add(Catalogo)
            ts1.PreferredRowHeight = (Catalogo.TextBox.Height + 3)
            Catalogo.ReadOnly = False
            Catalogo.NullText = ""
            colCount = (colCount + 1)

            ' DESCRIPCION
            Descripcion = New DataGridTextBoxColumn
            Descripcion.MappingName = "Descripcion"
            Descripcion.HeaderText = "Descripcion"
            Descripcion.Width = 300
            Descripcion.ReadOnly = False
            ts1.GridColumnStyles.Add(Descripcion)
            ts1.PreferredRowHeight = (Descripcion.TextBox.Height + 3)
            Descripcion.NullText = ""
            colCount = (colCount + 1)


            ' MONTO
            Dim Monto As DataGridTextBoxColumn
            Monto = New DataGridTextBoxColumn
            Monto.MappingName = "Monto"
            Monto.HeaderText = "Importe."
            Monto.Width = 100
            Monto.Alignment = HorizontalAlignment.Right
            Monto.ReadOnly = False
            Monto.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(Monto)
            colCount = (colCount + 1)
            Monto.NullText = "0"


            ' DEBITO / CREDITO --- 0 / 1 
            DC = New DataGridTextBoxColumn
            DC.MappingName = "DC"
            DC.HeaderText = "Débito/Crédito"
            DC.Width = 120
            DC.Alignment = HorizontalAlignment.Center
            DC.ReadOnly = True

            ts1.GridColumnStyles.Add(DC)
            colCount = (colCount + 1)
            DC.NullText = "-Seleccione-"


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'STEP 6: Add the tablestyle to your datagrids tablestlye collection
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            dgFacturacionCliente.ReadOnly = True

            ts1.AllowSorting = False
            ts1.HeaderFont = dgFacturacionCliente.HeaderFont
            dgFacturacionCliente.CaptionVisible = False
            dgFacturacionCliente.TableStyles.Clear()
            dgFacturacionCliente.TableStyles.Add(ts1)

        End Sub

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

            Dim Config As New VB.SysContab.ConfiguracionDB
            Dim ConfigDet As VB.SysContab.ConfiguracionDetails = Config.GetConfigDetails()

            'Buscar el tipo de comprobante de cheques
            Dim TComp As Integer
            Dim lds As New DataSet
            lds = VB.SysContab.ComprobanteDB.GetTComprobantes("CK")
            If lds.Tables(0).Rows.Count >= 1 Then
                'Se toma el primero, por efectos de dejarlo automatico
                TComp = lds.Tables(0).Rows(0).Item("TipComp_ID")
                lds.Dispose()
            Else
                MsgBox("No existen tipos de comprobantes de Cheques configurados", MsgBoxStyle.Critical, "STS-Contab")
                lds.Dispose()
                Exit Sub
            End If

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Dim ComprNo As String
            Try
                'Agregar el encabezado
                ComprNo = VB.SysContab.ComprobanteDB.AddComprobante(TComp, 1, _
                                   txtConcepto.Text, VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, _
                                   VB.SysContab.PeriodosDB.Activo(Me.dtFecha.Value), Me.dtFecha.Value, 0, txtChequeNombre.Text, False, _
                                   Me.txtCodigoProveedor.Text, DPROV.Ruc.ToString, 0, txtBanco.Text, Me.dtFecha.Value, _
                                   0, OrigenComprobantes.CHEQUE)
                'Agregar los detalles
                'Agregar el Banco
                VB.SysContab.ComprobanteDB.AddComprobanteDetalles(ComprNo, _
                                Me.Banco, "", Me.txtValor.Text, Me.txtCheque.Text, TComp, "C", 0, 0, _
                                Me.dtFecha.Value, 1)
                'Agregar el proveedor
                VB.SysContab.ComprobanteDB.AddComprobanteDetalles(ComprNo, _
                                CuentaProveedor, Me.Basico & "-" & Me.Consecutivo, _
                                Me.txtValor.Text, Me.txtCheque.Text, TComp, "D", 0, 0, _
                                Me.dtFecha.Value, 0)
                '
                Comprobantes.CancelarFactura(Me.txtFact.Text, DPROV.Codigo, 1)
                '
                Comprobantes.PagosFactura(Me.compFact, _
                                Me.compPerID, _
                                New DateTime(2007, Me.compMes, 1), _
                                Me.txtValor.Text, _
                                ComprNo, _
                                VB.SysContab.PeriodosDB.Activo(Me.dtFecha.Value), _
                                dtFecha.Value, Me.txtFact.Text, DPROV.Codigo, 0)
                VB.SysContab.Rutinas.okTransaccion()
            Catch ex As Exception
                MsgBox(ex.Message)
                VB.SysContab.Rutinas.ErrorTransaccion()
            End Try

            Dim f As frmPlantillasBancos = f.Instance
            Dim f1 As frmPlantillasCuentasBancos = f1.Instance
            Dim F2 As frmListaFacturas = F2.Instance
            Dim F3 As frmPlantillasPagoProveedores = F3.Instance
            F3.Close()
            F2.Close()
            f1.Close()
            f.Close()

            If CDbl(Me.txtNotaCredito.Text) <> 0 Then
                Dim Proveedores As New VB.SysContab.ProveedoresDB
                Proveedores.NotasCreditoAdd(Me.txtCodigoProveedor.Text, Me.dtFecha.Value, txtFact.Text, Me.txtNotaCredito.Text)
            End If

            Dim Frm As New FrmComprobantesConfirmarImprimir

            Frm.CompNo.Text = ComprNo
            Frm.Valorletras.Text = r.Letras(txtValor.Text)
            Frm.Fecha.Text = dtFecha.Value
            Frm.Monto.Text = txtValor.Text
            Frm.PerID.Text = PeriodosDB.Activo(Me.dtFecha.Value)

            Me.Hide()

            Frm.StartPosition = FormStartPosition.CenterScreen

            Frm.ShowDialog()

            Me.Close()


        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

        Public Function Validar() As Boolean

            If (txtProv.Text.ToString = "") Then
                MsgBox("Por favor seleccione una cuenta para " & ds.Tables("PlantillasDetalles").Rows(0).Item("Etiqueta"))
                Return False
                Exit Function
            End If

            If (BancoID = "") Then
                MsgBox("Por favor seleccione una cuenta para el Banco")
                Return False
                Exit Function
            End If

            If (txtFact.Text = "") Or (txtFact.Text Is DBNull.Value) Then
                MsgBox("Por favor ingrese " & ds.Tables("PlantillasDetalles").Rows(0).Item("Var"))
                Return False
                Exit Function
            End If

            If (txtCheque.Text = "") Or (txtCheque.Text Is DBNull.Value) Then
                MsgBox("Por favor ingrese el número de cheque")
                Return False
                Exit Function
            End If

            If (txtValor.Text = "") Or (txtValor.Text Is DBNull.Value) Then
                MsgBox("Por favor ingrese el valor del " & ds.Tables("PlantillasDetalles").Rows(0).Item("Var"))
                Return False
                Exit Function
            End If

            Try
                txtValor.Text = CDbl(txtValor.Text).ToString(Round)
            Catch e As Exception
                MsgBox("Por favor digite un Valor Númerico")
                Return False
            End Try


            If txtConcepto.Text = "" Then
                MsgBox("Por favor escriba un Comentario para el Comprobante")
                Return False
                Exit Function
            End If

            Return True

        End Function

        'Private Sub txtNotaCredito_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNotaCredito.Leave

        '    Dim Config As New VB.SysContab.ConfiguracionDB
        '    Dim ConfigDet As VB.SysContab.ConfiguracionDetails = Config.GetConfigDetails()


        '    If Trim(Me.txtNotaCredito.Text) = "" Then
        '        Me.txtNotaCredito.Text = CDbl(0).ToString(Round)
        '    Else
        '        If Not IsNumeric(Me.txtNotaCredito.Text) Then
        '            MsgBox("Introduzca un valor numérico", MsgBoxStyle.Information)
        '            Me.txtNotaCredito.Focus()
        '            Exit Sub
        '        Else
        '            If CDbl(Me.txtNotaCredito.Text) > Valor Then
        '                MsgBox("El monto debe ser menor que el total de la Factura", MsgBoxStyle.Information)
        '                Me.txtNotaCredito.Focus()
        '                Exit Sub
        '            End If
        '            Me.txtNotaCredito.Text = CDbl(Me.txtNotaCredito.Text).ToString(Round)
        '        End If
        '    End If

        '    txtValor.Text = CDbl(Valor - CDbl(Me.txtNotaCredito.Text)).ToString(Round)

        '    MakeDataSet()
        '    dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
        '    AddCustomDataTableStyle()

        '    For j = 0 To ds.Tables("PlantillasDetalles").Rows.Count - 1

        '        If ds.Tables("PlantillasDetalles").Rows(j).Item("Etiqueta") = lblProv.Text Then
        '            dgFacturacionCliente.Item(j, 2) = txtProv.Text.ToString
        '        End If

        '        ' CAMBIO
        '        If ds.Tables("PlantillasDetalles").Rows(j).Item("Etiqueta") = lblBanco.Text Then
        '            dgFacturacionCliente.Item(j, 2) = CatalogoDB.GetDetails(Banco).Nombre
        '        End If

        '    Next

        '    'CalculaMontos()

        '    For j = 0 To ds.Tables("PlantillasDetalles").Rows.Count - 1
        '        If ds.Tables("PlantillasDetalles").Rows(j).Item("Var") = lblFact.Text Then
        '            dgFacturacionCliente.Item(j, 3) = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto") & " " & txtFact.Text
        '        End If
        '    Next


        '    For j = 0 To ds.Tables("PlantillasDetalles").Rows.Count - 1
        '        If ds.Tables("PlantillasDetalles").Rows(j).Item("Var") = lblCheque.Text Then
        '            dgFacturacionCliente.Item(j, 3) = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto") & " No. Cheque " & txtCheque.Text
        '        End If

        '        If ds.Tables("PlantillasDetalles").Rows(j).Item("Var") = lblBanco.Text Then
        '            If j = 3 Then
        '                If txtValor.Text < ConfigDet.MontoIR And EsqID = 1 Then
        '                    dgFacturacionCliente.Item(j - 1, 3) = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto") & " Banco " & txtBanco.Text
        '                Else
        '                    dgFacturacionCliente.Item(j, 3) = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto") & " Banco " & txtBanco.Text
        '                End If
        '            End If
        '        End If
        '    Next

        '    If txtValor.Text < ConfigDet.MontoIR And EsqID = 1 Then
        '        tCust.Rows(3).Delete()
        '    End If

        'End Sub

        'Private Sub txtNotaCredito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNotaCredito.KeyPress
        '    If e.KeyChar = "-" Then
        '        e.Handled = True
        '    End If

        'End Sub



    End Class

End Namespace
