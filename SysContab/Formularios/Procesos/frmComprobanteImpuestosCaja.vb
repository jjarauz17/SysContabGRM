Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace DataGridTextBox
    Public Class frmComprobanteImpuestosCaja
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmComprobanteImpuestosCaja = Nothing

        Public Shared Function Instance() As frmComprobanteImpuestosCaja
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmComprobanteImpuestosCaja()
            End If
            ChildInstance.BringToFront()

            Return ChildInstance
        End Function

        Dim Tasa As New VB.SysContab.Tasa_CambioDB()
        Dim Plantilla As New VB.SysContab.PlantillaDB()
        Dim CatalogoDB As New VB.SysContab.CatalogoDB()
        Dim CatalogoDetalle As New VB.SysContab.CatalogoDetails()
        Dim Rutinas As New VB.SysContab.Rutinas()
        Dim Conf As New VB.SysContab.ConfiguracionDB()
        Dim Comprobantes As New VB.SysContab.ComprobanteDB()
        Private WithEvents myDataSet As DataSet
        Dim WithEvents tCust As DataTable

        Dim WithEvents ProdServ As DataGridTextBoxColumn
        Dim WithEvents Cuenta As DataGridTextBoxColumn
        Dim WithEvents Catalogo As DataGridTextBoxColumn
        Dim WithEvents Monto As DataGridTextBoxColumn
        Dim WithEvents Descripcion As DataGridTextBoxColumn
        Dim WithEvents DC As DataGridTextBoxColumn
        Dim EmpresasDB As New VB.SysContab.EmpresasDB()
        Dim MonedaDB As New VB.SysContab.MonedaDB()
        Dim PeriodosDB As New VB.SysContab.PeriodosDB()

        Dim Facturas As New VB.SysContab.Facturas_ComprasDB()
        Dim Articulos As New VB.SysContab.ArticulosDB()

        Dim ds As DataSet
        Dim i As Integer
        Dim j As Integer
        Public Banco As String
        Public BancoID As String
        Public VarProv As String
        Public VarProvID As String
        Public EsqID As String
        Public TipoCompr As String

        Dim TipoCuenta As String

        Dim Proveedores As New VB.SysContab.ProveedoresDB()

#Region " C�digo generado por el Dise�ador de Windows Forms "

        Private Sub New()
            MyBase.New()

            'El Dise�ador de Windows Forms requiere esta llamada.
            InitializeComponent()

            'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

        'Requerido por el Dise�ador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
        'Puede modificarse utilizando el Dise�ador de Windows Forms. 
        'No lo modifique con el editor de c�digo.
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
        Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents etPlantilla As System.Windows.Forms.Label
        Friend WithEvents etIva As System.Windows.Forms.Label
        Friend WithEvents etSubTotal As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.txtTasaCambio = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.NoComprobante = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtConcepto = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.etSubTotal = New System.Windows.Forms.Label()
            Me.etIva = New System.Windows.Forms.Label()
            Me.etPlantilla = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.Label39 = New System.Windows.Forms.Label()
            Me.Label38 = New System.Windows.Forms.Label()
            Me.lblDebTotal = New System.Windows.Forms.Label()
            Me.lblCredTotal = New System.Windows.Forms.Label()
            Me.etTotalT = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtValor = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dgFacturacionCliente = New System.Windows.Forms.DataGrid()
            Me.dtFecha = New System.Windows.Forms.DateTimePicker()
            Me.txtMoneda = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtTipo = New System.Windows.Forms.TextBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label1.Location = New System.Drawing.Point(64, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(56, 24)
            Me.Label1.TabIndex = 114
            Me.Label1.Text = "Fecha :"
            '
            'Label25
            '
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label25.Location = New System.Drawing.Point(432, 8)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(40, 24)
            Me.Label25.TabIndex = 141
            Me.Label25.Text = "Tipo:"
            '
            'txtTasaCambio
            '
            Me.txtTasaCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTasaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTasaCambio.Location = New System.Drawing.Point(104, 8)
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
            Me.Label3.Location = New System.Drawing.Point(8, 8)
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
            Me.NoComprobante.Location = New System.Drawing.Point(360, 496)
            Me.NoComprobante.MaxLength = 50
            Me.NoComprobante.Name = "NoComprobante"
            Me.NoComprobante.ReadOnly = True
            Me.NoComprobante.Size = New System.Drawing.Size(120, 20)
            Me.NoComprobante.TabIndex = 0
            Me.NoComprobante.Text = ""
            Me.NoComprobante.Visible = False
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label7.Location = New System.Drawing.Point(256, 496)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(104, 24)
            Me.Label7.TabIndex = 124
            Me.Label7.Text = "No. Comprobante"
            Me.Label7.Visible = False
            '
            'txtConcepto
            '
            Me.txtConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
            Me.txtConcepto.Location = New System.Drawing.Point(16, 392)
            Me.txtConcepto.Multiline = True
            Me.txtConcepto.Name = "txtConcepto"
            Me.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtConcepto.Size = New System.Drawing.Size(880, 40)
            Me.txtConcepto.TabIndex = 6
            Me.txtConcepto.Text = ""
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(189, Byte), CType(210, Byte), CType(210, Byte))
            Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.etSubTotal, Me.etIva, Me.etPlantilla, Me.lblTotal, Me.Label39, Me.Label38, Me.lblDebTotal, Me.lblCredTotal, Me.etTotalT, Me.txtConcepto, Me.Label4, Me.txtValor, Me.Label6, Me.dgFacturacionCliente, Me.dtFecha, Me.Label1})
            Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(904, 448)
            Me.GroupBox1.TabIndex = 148
            Me.GroupBox1.TabStop = False
            '
            'etSubTotal
            '
            Me.etSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(189, Byte), CType(210, Byte), CType(210, Byte))
            Me.etSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etSubTotal.Location = New System.Drawing.Point(184, 352)
            Me.etSubTotal.Name = "etSubTotal"
            Me.etSubTotal.Size = New System.Drawing.Size(120, 24)
            Me.etSubTotal.TabIndex = 1016
            Me.etSubTotal.Text = "Sub Total"
            Me.etSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.etSubTotal.Visible = False
            '
            'etIva
            '
            Me.etIva.BackColor = System.Drawing.Color.FromArgb(CType(189, Byte), CType(210, Byte), CType(210, Byte))
            Me.etIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIva.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etIva.Location = New System.Drawing.Point(120, 320)
            Me.etIva.Name = "etIva"
            Me.etIva.Size = New System.Drawing.Size(120, 24)
            Me.etIva.TabIndex = 1015
            Me.etIva.Text = "Iva"
            Me.etIva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.etIva.Visible = False
            '
            'etPlantilla
            '
            Me.etPlantilla.BackColor = System.Drawing.Color.FromArgb(CType(189, Byte), CType(210, Byte), CType(210, Byte))
            Me.etPlantilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etPlantilla.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etPlantilla.Location = New System.Drawing.Point(320, 328)
            Me.etPlantilla.Name = "etPlantilla"
            Me.etPlantilla.Size = New System.Drawing.Size(120, 24)
            Me.etPlantilla.TabIndex = 1014
            Me.etPlantilla.Text = "Plantilla"
            Me.etPlantilla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.etPlantilla.Visible = False
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
            Me.Label4.Location = New System.Drawing.Point(24, 376)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(128, 24)
            Me.Label4.TabIndex = 161
            Me.Label4.Text = "Comentario:"
            '
            'txtValor
            '
            Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValor.Location = New System.Drawing.Point(480, 16)
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
            Me.Label6.Location = New System.Drawing.Point(368, 16)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(104, 24)
            Me.Label6.TabIndex = 153
            Me.Label6.Text = "Monto:"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
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
            Me.dgFacturacionCliente.Location = New System.Drawing.Point(12, 56)
            Me.dgFacturacionCliente.Name = "dgFacturacionCliente"
            Me.dgFacturacionCliente.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgFacturacionCliente.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgFacturacionCliente.SelectionForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.Size = New System.Drawing.Size(884, 248)
            Me.dgFacturacionCliente.TabIndex = 1000
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
            Me.txtMoneda.Location = New System.Drawing.Point(304, 8)
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
            Me.Label2.Location = New System.Drawing.Point(232, 8)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(64, 24)
            Me.Label2.TabIndex = 145
            Me.Label2.Text = "Moneda:"
            '
            'txtTipo
            '
            Me.txtTipo.BackColor = System.Drawing.Color.White
            Me.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipo.Location = New System.Drawing.Point(480, 8)
            Me.txtTipo.MaxLength = 50
            Me.txtTipo.Name = "txtTipo"
            Me.txtTipo.ReadOnly = True
            Me.txtTipo.Size = New System.Drawing.Size(440, 20)
            Me.txtTipo.TabIndex = 0
            Me.txtTipo.Text = ""
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdAceptar, Me.cmdCancelar})
            Me.GroupBox2.Location = New System.Drawing.Point(920, 40)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(88, 448)
            Me.GroupBox2.TabIndex = 149
            Me.GroupBox2.TabStop = False
            '
            'cmdAceptar
            '
            Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.Location = New System.Drawing.Point(8, 16)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
            Me.cmdAceptar.TabIndex = 7
            Me.cmdAceptar.Text = "Aceptar"
            '
            'cmdCancelar
            '
            Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.Location = New System.Drawing.Point(8, 48)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
            Me.cmdCancelar.TabIndex = 3
            Me.cmdCancelar.Text = "Salir"
            '
            'frmComprobanteImpuestosCaja
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(236, Byte), CType(236, Byte))
            Me.ClientSize = New System.Drawing.Size(1016, 526)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.txtMoneda, Me.txtTasaCambio, Me.GroupBox1, Me.NoComprobante, Me.Label7, Me.Label3, Me.Label2, Me.txtTipo, Me.Label25})
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
            Me.Name = "frmComprobanteImpuestosCaja"
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Dim Valor As Double
        '''''Dim dsDetalle As DataSet

        Public IRAnticipo As Boolean
        Public IRGeneral As Boolean
        Public IRProfesional As Boolean
        Public IRResidente As Boolean

        Public MontoAnticipo As Double
        Public MontoGeneral As Double
        Public MontoProfesional As Double
        Public MontoResidente As Double

        Dim Config As New VB.SysContab.ConfiguracionDB()
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()

        Public Mes As Integer
        Public Year As Integer
        Dim Fechas As New VB.SysContab.FechasdeTrabajo

        Private Sub frmComprobanteImpuestosCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Me.Text = "Comprobante Diario"
            Dim filas As Integer

            LeaveCommit = False

            ConfigDetalles = Config.GetConfigDetails

            Me.txtConcepto.CharacterCasing = CharacterCasing.Upper

            Valor = Me.txtValor.Text

            txtTasaCambio.Text = Tasa.GetTasaCambioDia(Today.Month, Today.Year, Today.Day).Tables("Tasa_Cambio").Rows(0).Item("Tasa_Cambio")

            dtFecha.MinDate = Fechas.FechaMinima 'PeriodosDB.GetDetails(PeriodosDB.Activo).Inicio
            dtFecha.MaxDate = Fechas.FechaMaxima 'PeriodosDB.GetDetails(PeriodosDB.Activo).Final

            Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(Me.etPlantilla.Text)
            ds = Detalles.Detalles

            'NoComprobante.Text = VB.SysContab.ComprobanteDB.GetNoComprobante(Me.dtFecha.Value)

            txtTipo.Text = Comprobantes.GetDetails(Detalles.TipoCompr).Nombre

            TipoCompr = Detalles.TipoCompr

            EsqID = Detalles.EsquemaID

            MakeDataSet()
            dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

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
            Dim i As Integer
            j = 0

            'For j = 0 To ds.Tables("PlantillasDetalles").Rows.Count - 3
            '    If j = 0 And Me.IRAnticipo = False Then

            '    End If
            '    newRow1 = tCust.NewRow
            '    tCust.Rows.Add(newRow1)

            '    tCust.Rows(j)("ProdServ") = ds.Tables("PlantillasDetalles").Rows(j).Item("Etiqueta")
            '    'tCust.Rows(j)("Descripcion") = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto")

            '    If CatalogoDB.GetDetails(ds.Tables("PlantillasDetalles").Rows(j).Item("Cuenta")).Tipo = "A" Then
            '        tCust.Rows(j)("Cuenta") = ds.Tables("PlantillasDetalles").Rows(j).Item("Cuenta")
            '        tCust.Rows(j)("Catalogo") = ds.Tables("PlantillasDetalles").Rows(j).Item("Catalogo")
            '    Else
            '        tCust.Rows(j)("Catalogo") = ""
            '    End If

            '    If ds.Tables("PlantillasDetalles").Rows(j).Item("D�bito") = 1 Then
            '        tCust.Rows(j)("DC") = "D�bito"
            '    Else
            '        tCust.Rows(j)("DC") = "Cr�dito"
            '    End If
            'Next

            Dim DebitoTotal As Double
            Dim CreditoTotal As Double

            DebitoTotal = 0
            CreditoTotal = 0

            'lblTotal.Text = (CDbl(lblDebTotal.Text) - CDbl(lblCredTotal.Text)).ToString(Round)

            '''''''''''
            If Me.IRAnticipo = True Then
                newRow1 = tCust.NewRow
                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("ProdServ") = ds.Tables("PlantillasDetalles").Rows(0).Item("Etiqueta")
                'tCust.Rows(j)("Descripcion") = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto")

                If CatalogoDB.GetDetails(ds.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")).Tipo = "A" Then
                    tCust.Rows(j)("Cuenta") = ds.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                    tCust.Rows(j)("Catalogo") = ds.Tables("PlantillasDetalles").Rows(0).Item("Catalogo")
                Else
                    tCust.Rows(j)("Catalogo") = ""
                End If

                tCust.Rows(j)("Monto") = CDbl(Me.MontoAnticipo).ToString(Round)

                If ds.Tables("PlantillasDetalles").Rows(0).Item("D�bito") = 1 Then
                    tCust.Rows(j)("DC") = "D�bito"
                    DebitoTotal = DebitoTotal + CDbl(Me.MontoAnticipo)
                Else
                    tCust.Rows(j)("DC") = "Cr�dito"
                    CreditoTotal = CreditoTotal + CDbl(Me.MontoAnticipo)
                End If

                j = j + 1
            End If

            'IR General
            If Me.IRGeneral = True Then
                newRow1 = tCust.NewRow
                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("ProdServ") = ds.Tables("PlantillasDetalles").Rows(1).Item("Etiqueta")
                'tCust.Rows(j)("Descripcion") = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto")

                If CatalogoDB.GetDetails(ds.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")).Tipo = "A" Then
                    tCust.Rows(j)("Cuenta") = ds.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
                    tCust.Rows(j)("Catalogo") = ds.Tables("PlantillasDetalles").Rows(1).Item("Catalogo")
                Else
                    tCust.Rows(j)("Catalogo") = ""
                End If

                tCust.Rows(j)("Monto") = CDbl(Me.MontoGeneral).ToString(Round)

                If ds.Tables("PlantillasDetalles").Rows(1).Item("D�bito") = 1 Then
                    tCust.Rows(j)("DC") = "D�bito"
                    DebitoTotal = DebitoTotal + CDbl(Me.MontoGeneral)
                Else
                    tCust.Rows(j)("DC") = "Cr�dito"
                    CreditoTotal = CreditoTotal + CDbl(Me.MontoGeneral)
                End If

                j = j + 1
            End If

            'IR Servicios Profesionales
            If Me.IRProfesional = True Then
                newRow1 = tCust.NewRow
                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("ProdServ") = ds.Tables("PlantillasDetalles").Rows(2).Item("Etiqueta")
                'tCust.Rows(j)("Descripcion") = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto")

                If CatalogoDB.GetDetails(ds.Tables("PlantillasDetalles").Rows(2).Item("Cuenta")).Tipo = "A" Then
                    tCust.Rows(j)("Cuenta") = ds.Tables("PlantillasDetalles").Rows(2).Item("Cuenta")
                    tCust.Rows(j)("Catalogo") = ds.Tables("PlantillasDetalles").Rows(2).Item("Catalogo")
                Else
                    tCust.Rows(j)("Catalogo") = ""
                End If

                tCust.Rows(j)("Monto") = CDbl(Me.MontoProfesional).ToString(Round)

                If ds.Tables("PlantillasDetalles").Rows(2).Item("D�bito") = 1 Then
                    tCust.Rows(j)("DC") = "D�bito"
                    DebitoTotal = DebitoTotal + CDbl(Me.MontoProfesional)
                Else
                    tCust.Rows(j)("DC") = "Cr�dito"
                    CreditoTotal = CreditoTotal + CDbl(Me.MontoProfesional)
                End If

                j = j + 1
            End If

            'IR Sobre Residentes
            If Me.IRResidente = True Then
                newRow1 = tCust.NewRow
                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("ProdServ") = ds.Tables("PlantillasDetalles").Rows(3).Item("Etiqueta")
                'tCust.Rows(j)("Descripcion") = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto")

                If CatalogoDB.GetDetails(ds.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")).Tipo = "A" Then
                    tCust.Rows(j)("Cuenta") = ds.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")
                    tCust.Rows(j)("Catalogo") = ds.Tables("PlantillasDetalles").Rows(3).Item("Catalogo")
                Else
                    tCust.Rows(j)("Catalogo") = ""
                End If

                tCust.Rows(j)("Monto") = CDbl(Me.MontoResidente).ToString(Round)

                If ds.Tables("PlantillasDetalles").Rows(3).Item("D�bito") = 1 Then
                    tCust.Rows(j)("DC") = "D�bito"
                    DebitoTotal = DebitoTotal + CDbl(Me.MontoResidente)
                Else
                    tCust.Rows(j)("DC") = "Cr�dito"
                    CreditoTotal = CreditoTotal + CDbl(Me.MontoResidente)
                End If

                j = j + 1
            End If

            '''''''''''

            'Caja General
            newRow1 = tCust.NewRow
            tCust.Rows.Add(newRow1)

            tCust.Rows(j)("ProdServ") = ds.Tables("PlantillasDetalles").Rows(7).Item("Etiqueta")
            'tCust.Rows(j)("Descripcion") = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto")

            If CatalogoDB.GetDetails(ds.Tables("PlantillasDetalles").Rows(7).Item("Cuenta")).Tipo = "A" Then
                tCust.Rows(j)("Cuenta") = ds.Tables("PlantillasDetalles").Rows(7).Item("Cuenta")
                tCust.Rows(j)("Catalogo") = ds.Tables("PlantillasDetalles").Rows(7).Item("Catalogo")
            Else
                tCust.Rows(j)("Catalogo") = ""
            End If

            tCust.Rows(j)("Monto") = CDbl(Me.txtValor.Text).ToString(Round)

            If ds.Tables("PlantillasDetalles").Rows(7).Item("D�bito") = 1 Then
                tCust.Rows(j)("DC") = "D�bito"
                DebitoTotal = DebitoTotal + CDbl(Me.txtValor.Text).ToString(Round)
            Else
                tCust.Rows(j)("DC") = "Cr�dito"
                CreditoTotal = CreditoTotal + CDbl(Me.txtValor.Text).ToString(Round)
            End If

            j = j + 1


            '''''Banco
            ''''newRow1 = tCust.NewRow
            ''''tCust.Rows.Add(newRow1)
            ''''tCust.Rows(j)("ProdServ") = "Banco"

            '''''dsDetalleArticulo = VB.SysContab.ArticulosDB.GetDetails(dsDetalle.Tables("Facturas_Compras").Rows(0).Item("Item_ID"), "P", EmpresaActual)
            ''''CatalogoDetalle = CatalogoDB.GetDetails(Me.Banco)
            ''''tCust.Rows(j)("Cuenta") = Me.Banco
            ''''tCust.Rows(j)("Catalogo") = CatalogoDetalle.Nombre

            '''''Monto = CDbl(dsDetalle.Tables("Facturas_Compras").Rows(0).Item("Item_Cantidad_Almacen")) * CDbl(dsDetalle.Tables("Facturas_Compras").Rows(0).Item("Item_Costo")) - CDbl(dsDetalle.Tables("Facturas_Compras").Rows(0).Item("Item_Descuento"))

            '''''tCust.Rows(j)("Monto") = CDbl(Me.txtValor.Text).ToString(Round)

            ''''tCust.Rows(j)("Monto") = CDbl(Me.txtValor.Text).ToString(Round)

            ''''tCust.Rows(j)("DC") = "Cr�dito"
            ''''CreditoTotal = CreditoTotal + CDbl(Me.txtValor.Text)
            ''''j = j + 1


            Me.lblDebTotal.Text = CDbl(DebitoTotal).ToString(Round)
            Me.lblCredTotal.Text = CDbl(CreditoTotal).ToString(Round)
            lblTotal.Text = CDbl(DebitoTotal - CreditoTotal).ToString(Round)

            Dim k As Integer
            Dim c As Integer
            Dim dsDetalleArticulo As VB.SysContab.ArticulosDetails
            Dim Monto As Double

            '''''''k = 0
            '''''''c = 0
            '''''''Monto = 0

            '''''''newRow1 = tCust.NewRow
            '''''''tCust.Rows.Add(newRow1)
            '''''''tCust.Rows(j)("ProdServ") = "Inventario"

            '''''''dsDetalleArticulo = VB.SysContab.ArticulosDB.GetDetails(dsDetalle.Tables("Facturas_Compras").Rows(0).Item("Item_ID"), "P", EmpresaActual)
            '''''''CatalogoDetalle = CatalogoDB.GetDetails(dsDetalleArticulo.Cuenta)
            '''''''tCust.Rows(j)("Cuenta") = dsDetalleArticulo.Cuenta
            '''''''tCust.Rows(j)("Catalogo") = CatalogoDetalle.Nombre

            '''''''Monto = CDbl(dsDetalle.Tables("Facturas_Compras").Rows(0).Item("Item_Cantidad_Almacen")) * CDbl(dsDetalle.Tables("Facturas_Compras").Rows(0).Item("Item_Costo")) - CDbl(dsDetalle.Tables("Facturas_Compras").Rows(0).Item("Item_Descuento"))

            '''''''tCust.Rows(j)("Monto") = CDbl(Monto).ToString(Round)

            '''''''tCust.Rows(j)("DC") = "D�bito"
            '''''''j = j + 1

            '''''''For i = 1 To dsDetalle.Tables("Facturas_Compras").Rows.Count - 1
            '''''''    dsDetalleArticulo = VB.SysContab.ArticulosDB.GetDetails(dsDetalle.Tables("Facturas_Compras").Rows(i).Item("Item_ID"), "P", EmpresaActual)
            '''''''    Monto = CDbl(dsDetalle.Tables("Facturas_Compras").Rows(i).Item("Item_Cantidad_Almacen")) * CDbl(dsDetalle.Tables("Facturas_Compras").Rows(i).Item("Item_Costo")) - CDbl(dsDetalle.Tables("Facturas_Compras").Rows(i).Item("Item_Descuento"))
            '''''''    'tCust.Rows(i)("Monto") = CDbl(Monto).ToString(Round)

            '''''''    For k = 3 To tCust.Rows.Count - 1
            '''''''        If tCust.Rows(k)("Cuenta") = dsDetalleArticulo.Cuenta Then
            '''''''            c = 0
            '''''''            tCust.Rows(k)("Monto") = CDbl(CDbl(tCust.Rows(k)("Monto")) + Monto).ToString(Round)
            '''''''            Exit For
            '''''''        Else
            '''''''            c = 1
            '''''''        End If
            '''''''    Next

            '''''''    If c = 0 Then
            '''''''        '
            '''''''    Else
            '''''''        'Monto = 0
            '''''''        newRow1 = tCust.NewRow
            '''''''        tCust.Rows.Add(newRow1)
            '''''''        tCust.Rows(j)("ProdServ") = "Inventario" 'dsDetalle.Tables("PlantillasDetalles").Rows(j).Item("Etiqueta")
            '''''''        'tCust.Rows(j)("Descripcion") = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto")

            '''''''        'If CatalogoDB.GetDetails(dsDetalle.Tables("PlantillasDetalles").Rows(j).Item("Cuenta")).Tipo = "A" Then
            '''''''        '    tCust.Rows(i)("Cuenta") = dsDetalle.Tables("PlantillasDetalles").Rows(j).Item("Cuenta")
            '''''''        '    tCust.Rows(i)("Catalogo") = dsDetalle.Tables("PlantillasDetalles").Rows(j).Item("Catalogo")
            '''''''        'Else
            '''''''        '    tCust.Rows(i)("Catalogo") = ""
            '''''''        'End If
            '''''''        CatalogoDetalle = CatalogoDB.GetDetails(dsDetalleArticulo.Cuenta)

            '''''''        tCust.Rows(j)("Cuenta") = dsDetalleArticulo.Cuenta
            '''''''        tCust.Rows(j)("Catalogo") = CatalogoDetalle.Nombre

            '''''''        tCust.Rows(j)("Monto") = CDbl(Monto).ToString(Round)

            '''''''        tCust.Rows(j)("DC") = "D�bito"

            '''''''        'If ds.Tables("PlantillasDetalles").Rows(j).Item("D�bito") = 1 Then
            '''''''        '    tCust.Rows(i)("DC") = "D�bito"
            '''''''        'Else
            '''''''        '    tCust.Rows(i)("DC") = "Cr�dito"
            '''''''        'End If

            '''''''        '''''''If tCust.Rows(j - 1)("Cuenta") = dsDetalleArticulo.Cuenta Then
            '''''''        '''''''    tCust.Rows(j).Delete()
            '''''''        '''''''Else
            '''''''        j = j + 1
            '''''''        '''''''End If
            '''''''    End If
            '''''''Next
            'k = 2
            'For i = 0 To dsDetalle.Tables("Facturas_Compras").Rows.Count - 1
            '    If tCust.Rows(k)("Cuenta") = tCust.Rows(k - 1)("Cuenta") Then
            '        tCust.Rows(k).Delete()
            '    End If
            'Next
        End Sub

        Private Sub AddCustomDataTableStyle()
            Dim ts1 As DataGridTableStyle
            ts1 = New DataGridTableStyle()
            ts1.MappingName = "Articulos"
            ts1.AlternatingBackColor = Color.LightBlue
            Dim colCount As Integer
            colCount = 0

            ' Producto / Servicio
            ProdServ = New DataGridTextBoxColumn()
            ProdServ.MappingName = "ProdServ"
            ProdServ.HeaderText = "Producto/Servicio"
            ProdServ.Width = 0
            ProdServ.ReadOnly = True
            ts1.GridColumnStyles.Add(ProdServ)
            ts1.PreferredRowHeight = (ProdServ.TextBox.Height + 3)
            ProdServ.NullText = ""
            colCount = (colCount + 1)

            ' CUENTA
            Cuenta = New DataGridTextBoxColumn()
            Cuenta.MappingName = "Cuenta"
            Cuenta.HeaderText = "Cuenta"
            Cuenta.Width = 120
            Cuenta.ReadOnly = True
            ts1.GridColumnStyles.Add(Cuenta)
            ts1.PreferredRowHeight = (Cuenta.TextBox.Height + 3)
            Cuenta.NullText = ""
            colCount = (colCount + 1)

            ' CATALOGO
            Catalogo = New DataGridTextBoxColumn()
            Catalogo.MappingName = "Catalogo"
            Catalogo.HeaderText = "Nombre"
            Catalogo.Width = 270
            ts1.GridColumnStyles.Add(Catalogo)
            ts1.PreferredRowHeight = (Catalogo.TextBox.Height + 3)
            Catalogo.ReadOnly = False
            Catalogo.NullText = ""
            colCount = (colCount + 1)

            ' DESCRIPCION
            Descripcion = New DataGridTextBoxColumn()
            Descripcion.MappingName = "Descripcion"
            Descripcion.HeaderText = "Concepto"
            Descripcion.Width = 270
            Descripcion.ReadOnly = False
            ts1.GridColumnStyles.Add(Descripcion)
            ts1.PreferredRowHeight = (Descripcion.TextBox.Height + 3)
            Descripcion.NullText = ""
            colCount = (colCount + 1)

            ' MONTO
            Dim Monto As DataGridTextBoxColumn
            Monto = New DataGridTextBoxColumn()
            Monto.MappingName = "Monto"
            Monto.HeaderText = "Importe"
            Monto.Width = 100
            Monto.Alignment = HorizontalAlignment.Right
            Monto.ReadOnly = False
            Monto.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(Monto)
            colCount = (colCount + 1)
            Monto.NullText = "0"


            ' DEBITO / CREDITO --- 0 / 1 
            DC = New DataGridTextBoxColumn()
            DC.MappingName = "DC"
            DC.HeaderText = "Tipo"
            DC.Width = 80
            DC.Alignment = HorizontalAlignment.Center
            DC.ReadOnly = True

            ts1.GridColumnStyles.Add(DC)
            colCount = (colCount + 1)
            DC.NullText = "--Seleccione--"

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


        Private Sub txtFact_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

            'For j = 0 To ds.Tables("PlantillasDetalles").Rows.Count - 1

            '    If ds.Tables("PlantillasDetalles").Rows(j).Item("Var") = lblFact.Text Then

            '        dgFacturacionCliente.Item(j, 3) = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto") & " " & txtFact.Text

            '    End If

            'Next

        End Sub


        Private Sub txtCheque_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

            'For j = 0 To ds.Tables("PlantillasDetalles").Rows.Count - 1

            '    If ds.Tables("PlantillasDetalles").Rows(j).Item("Var") = lblCheque.Text Then

            '        dgFacturacionCliente.Item(j, 3) = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto") & " " & txtCheque.Text

            '    End If

            '    If ds.Tables("PlantillasDetalles").Rows(j).Item("Var") = lblBanco.Text Then

            '        dgFacturacionCliente.Item(j, 3) = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto") & " " & txtBanco.Text

            '    End If

            'Next


        End Sub

        Private Sub txtValor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor.Leave
            'CalculaMontos()
        End Sub

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
            'Dim Catalogo As New CatalogoDB()
            Dim filas As Integer
            Dim CompNo As String
            If Validar() = True Then
                Try

                    Dim conexion As New VB.SysContab.Rutinas()
                    DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
                    DBConnFacturas.Open()
                    transaccionFacturas = DBConnFacturas.BeginTransaction()

                    CompNo = Comprobantes.AddComprobante(TipoCompr, txtTasaCambio.Text, txtConcepto.Text, EmpresasDB.GetDetails(EmpresaActual).MonedaBase, PeriodosDB.Activo(dtFecha.Value), dtFecha.Value, 0, "", False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.CHEQUE)
                    If Me.IRAnticipo = True Then
                        Comprobantes.FacturaVentasTransaccionesAdd(1, CompNo, PeriodosDB.Activo(dtFecha.Value), dtFecha.Value, Me.Mes, Me.Year)
                    End If

                    If Me.IRGeneral = True Then
                        Comprobantes.FacturaComprasTransaccionesAdd(4, CompNo, PeriodosDB.Activo(dtFecha.Value), dtFecha.Value, Me.Mes, Me.Year)
                    End If

                    'Comprobantes.ActualizarCheque(Me.Banco)
                    'Comprobantes.CancelarFactura(Me.txtFact.Text, Me.txtCodigoProveedor.Text)
                    Dim Tipo As String
                    For filas = 0 To tCust.Rows.Count - 1
                        If tCust.Rows(filas)("DC") = "D�bito" Then
                            'Debito = Debito + tCust.Rows(filas)("Monto")
                            'Comprobantes.AddCatalogoTrans(tCust.Rows(filas)("Cuenta"), tCust.Rows(filas)("Monto"), 0, tCust.Rows(filas)("Descripcion").ToString)
                            'CatalogoDB.ActualizarCuentas(tCust.Rows(filas)("Cuenta"), tCust.Rows(filas)("Monto"), 1)
                            Tipo = "D"
                        Else
                            'Credito = Credito + tCust.Rows(filas)("Monto")
                            Tipo = "C"
                            'Comprobantes.AddCatalogoTrans(tCust.Rows(filas)("Cuenta"), 0, tCust.Rows(filas)("Monto"), tCust.Rows(filas)("Descripcion").ToString)
                            'CatalogoDB.ActualizarCuentas(tCust.Rows(filas)("Cuenta"), tCust.Rows(filas)("Monto"), 2)
                        End If

                        Comprobantes.AddComprobanteDetalles(CompNo, tCust.Rows(filas)("Cuenta"), tCust.Rows(filas)("Descripcion").ToString, tCust.Rows(filas)("Monto"), 0, TipoCompr, Tipo, 0, 0, Me.dtFecha.Value, 1)
                        'Comprobantes.AddCatalogoTrans(tCust.Rows(filas)("Cuenta"), DebeProv, HaberProv, ConceptoProv)
                        'CatalogoDB.ActualizarCuentas(CuentaProv, DebeProv, 2) ' Se va a Restar de la Cuenta
                    Next

                    VB.SysContab.Rutinas.okTransaccion()

                Catch ex As Exception
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    MsgBox(ex.Message)
                End Try

                Me.Close()
                'Dim f As frmBancosImpuestos = f.Instance
                Dim f1 As frmIRxFactura = f1.Instance
                f1.CalculaTotal()
                'f.Close()

                ''''If EsqID = 1 Then
                ''''    ' FAlTA LA MONEDA
                ''''    'If txtValor.Text > 1000.0 Then
                ''''    'Comprobantes.GeneraComprobantePPC(txtProvID.Text, dgFacturacionCliente.Item(0, 4), 0, dgFacturacionCliente.Item(0, 3), txtCheque.Text, _
                ''''    '                                           dgFacturacionCliente.Item(2, 1), dgFacturacionCliente.Item(2, 4), 0, dgFacturacionCliente.Item(2, 3), _
                ''''    '                                        Banco, 0, dgFacturacionCliente.Item(1, 4), dgFacturacionCliente.Item(1, 3), _
                ''''    '                                        dgFacturacionCliente.Item(3, 1), 0, dgFacturacionCliente.Item(3, 4), dgFacturacionCliente.Item(3, 3).ToString, _
                ''''    '                                       TipoCompr, txtTasaCambio.Text, EmpresasDB.GetDetails(EmpresaActual).MonedaBase, txtConcepto.Text, TipoCompr, dtFecha.Value, txtFact.Text, Me.txtCodigoProveedor.Text)

                ''''    'Else
                ''''    '    Comprobantes.GeneraComprobantePPC(txtProvID.Text, dgFacturacionCliente.Item(0, 4), 0, dgFacturacionCliente.Item(0, 3), txtCheque.Text, _
                ''''    '                                               dgFacturacionCliente.Item(2, 1), dgFacturacionCliente.Item(2, 4), 0, dgFacturacionCliente.Item(2, 3), _
                ''''    '                                            Banco, 0, dgFacturacionCliente.Item(1, 4), dgFacturacionCliente.Item(1, 3), _
                ''''    '                                             0, 0, 0, 0, _
                ''''    '                                           TipoCompr, txtTasaCambio.Text, EmpresasDB.GetDetails(EmpresaActual).MonedaBase, txtConcepto.Text, TipoCompr, dtFecha.Value, txtFact.Text, Me.txtCodigoProveedor.Text)
                ''''    'End If

                ''''    'MsgBox("El Registro se Guardo Satisfactoriamente", MsgBoxStyle.Information)

                ''''    Me.Close()

                ''''    Dim f As frmBancosContabilizar = f.Instance
                ''''    'Dim f1 As frmPlantillasCuentasBancos = f1.Instance
                ''''    'Dim F2 As frmListaFacturas = F2.Instance
                ''''    'Dim F3 As frmPlantillasPagoProveedores = F3.Instance
                ''''    'F3.Close()
                ''''    'F2.Close()
                ''''    'f1.Close()
                ''''    f.Close()
                ''''End If


                ''''''If EsqID = 2 Then
                ''''''    ' FAlTA LA MONEDA
                ''''''    Comprobantes.GeneraComprobanteInstalacion(txtProvID.Text, dgFacturacionCliente.Item(0, 4), 0, dgFacturacionCliente.Item(0, 3), txtCheque.Text, _
                ''''''                                             Banco, 0, dgFacturacionCliente.Item(1, 4), dgFacturacionCliente.Item(1, 3), _
                ''''''                                          TipoCompr, txtTasaCambio.Text, EmpresasDB.GetDetails(EmpresaActual).MonedaBase, txtConcepto.Text, TipoCompr, dtFecha.Value, txtFact.Text, Me.txtCodigoProveedor.Text)

                ''''''    'MsgBox("El Registro se Guardo Satisfactoriamente", MsgBoxStyle.Information)

                ''''''    Me.Close()

                ''''''    Dim f As frmPlantillasBancos = f.Instance
                ''''''    Dim f1 As frmPlantillasCuentasBancos = f1.Instance
                ''''''    Dim F2 As frmListaFacturas = F2.Instance
                ''''''    F2.Close()
                ''''''    f1.Close()
                ''''''    f.Close()

                ''''''End If


                ''''''If EsqID = 3 Then
                ''''''    ' FAlTA LA MONEDA

                ''''''    Comprobantes.GeneraComprobanteReconexion(txtProvID.Text, dgFacturacionCliente.Item(0, 4), 0, dgFacturacionCliente.Item(0, 3), txtCheque.Text, _
                ''''''                                                     dgFacturacionCliente.Item(1, 1), dgFacturacionCliente.Item(1, 4), 0, dgFacturacionCliente.Item(1, 3), _
                ''''''                                             Banco, 0, dgFacturacionCliente.Item(2, 4), dgFacturacionCliente.Item(2, 3), _
                ''''''                                           TipoCompr, txtTasaCambio.Text, EmpresasDB.GetDetails(EmpresaActual).MonedaBase, txtConcepto.Text, TipoCompr, dtFecha.Value, txtFact.Text, Me.txtCodigoProveedor.Text)


                ''''''    'MsgBox("El Registro se Guardo Satisfactoriamente", MsgBoxStyle.Information)

                ''''''    Me.Close()

                ''''''    Dim f As frmPlantillasBancos = f.Instance
                ''''''    Dim f1 As frmPlantillasCuentasBancos = f1.Instance
                ''''''    Dim F2 As frmListaFacturas = F2.Instance
                ''''''    F2.Close()
                ''''''    f1.Close()
                ''''''    f.Close()

                ''''''End If


                ''''''If EsqID = 4 Then
                ''''''    ' FAlTA LA MONEDA

                ''''''    Comprobantes.GeneraComprobanteDepositoServPublicos(txtProvID.Text, dgFacturacionCliente.Item(0, 4), 0, dgFacturacionCliente.Item(0, 3), txtCheque.Text, _
                ''''''                                                      Banco, 0, dgFacturacionCliente.Item(1, 4), dgFacturacionCliente.Item(1, 3), _
                ''''''                                             TipoCompr, txtTasaCambio.Text, EmpresasDB.GetDetails(EmpresaActual).MonedaBase, txtConcepto.Text, TipoCompr, dtFecha.Value, txtFact.Text, Me.txtCodigoProveedor.Text)

                ''''''    'MsgBox("El Registro se Guardo Satisfactoriamente", MsgBoxStyle.Information)

                ''''''    Me.Close()

                ''''''    Dim f As frmPlantillasBancos = f.Instance
                ''''''    Dim f1 As frmPlantillasCuentasBancos = f1.Instance
                ''''''    Dim F2 As frmListaFacturas = F2.Instance
                ''''''    F2.Close()
                ''''''    f1.Close()
                ''''''    f.Close()

                ''''''End If


                ''''''If EsqID = 6 Then
                ''''''    ' FAlTA LA MONEDA

                ''''''    Comprobantes.GeneraComprobanteDepositoServPublicos(txtProvID.Text, dgFacturacionCliente.Item(0, 4), 0, dgFacturacionCliente.Item(0, 3), txtCheque.Text, _
                ''''''                                                      Banco, 0, dgFacturacionCliente.Item(1, 4), dgFacturacionCliente.Item(1, 3), _
                ''''''                                             TipoCompr, txtTasaCambio.Text, EmpresasDB.GetDetails(EmpresaActual).MonedaBase, txtConcepto.Text, TipoCompr, dtFecha.Value, txtFact.Text, Me.txtCodigoProveedor.Text)

                ''''''    'MsgBox("El Registro se Guardo Satisfactoriamente", MsgBoxStyle.Information)

                ''''''    Me.Close()

                ''''''    Dim f As frmPlantillasBancos = f.Instance
                ''''''    Dim f1 As frmPlantillasCuentasBancos = f1.Instance
                ''''''    Dim F2 As frmListaFacturas = F2.Instance
                ''''''    F2.Close()
                ''''''    f1.Close()
                ''''''    f.Close()

                ''''''End If

                ''''''If CDbl(Me.txtNotaCredito.Text) <> 0 Then
                ''''''    Dim Proveedores As New VB.SysContab.ProveedoresDB()
                ''''''    Proveedores.NotasCreditoAdd(Me.txtCodigoProveedor.Text, Me.dtFecha.Value, txtFact.Text, Me.txtNotaCredito.Text)
                ''''''End If

            End If

        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

        Public Function Validar() As Boolean

            'If (ddlProv.SelectedValue.ToString = 0) Then
            '    MsgBox("Por favor seleccione una cuenta para " & ds.Tables("PlantillasDetalles").Rows(0).Item("Etiqueta"))
            '    Return False
            '    Exit Function
            'End If

            'If (txtProv.Text.ToString = "") Then
            '    MsgBox("Por favor seleccione una cuenta para " & ds.Tables("PlantillasDetalles").Rows(0).Item("Etiqueta"))
            '    Return False
            '    Exit Function
            'End If


            'If (ddlBanco.SelectedValue.ToString = 0) Then
            '    MsgBox("Por favor seleccione una cuenta para " & ds.Tables("PlantillasDetalles").Rows(1).Item("Etiqueta"))
            '    Return False
            '    Exit Function
            'End If

            'If (txtFact.Text = "") Or (txtFact.Text Is DBNull.Value) Then
            '    MsgBox("Por favor ingrese " & ds.Tables("PlantillasDetalles").Rows(0).Item("Var"))
            '    Return False
            '    Exit Function
            'End If

            'If (txtValor.Text = "") Or (txtValor.Text Is DBNull.Value) Then
            '    MsgBox("Por favor ingrese el valor del " & ds.Tables("PlantillasDetalles").Rows(0).Item("Var"))
            '    Return False
            '    Exit Function
            'End If

            'Try
            '    txtValor.Text = CDbl(txtValor.Text).ToString(Round)
            'Catch e As Exception
            '    MsgBox("Por favor digite un Valor N�merico")
            '    Return False
            'End Try


            'If txtConcepto.Text = "" Then
            '    MsgBox("Por favor escriba un Concepto para el Comprobante")
            '    Return False
            '    Exit Function
            'End If

            Return True

        End Function

        Private Sub txtProv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
            '            dgFacturacionCliente.Item(0, 2) = txtProv.Text.ToString
        End Sub

        Private Sub txtCheque_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End Sub

        Private Sub etTotalT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etTotalT.Click

        End Sub

        Private Sub txtNotaCredito_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = "-" Then
                e.Handled = True
            End If
            'If IsNumeric(e.KeyChar) = False Then
            '    e.Handled = True
            '    Exit Sub
            'End If

        End Sub

        Private Sub dtFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtFecha.ValueChanged
            NoComprobante.Text = VB.SysContab.ComprobanteDB.GetNoComprobante(Me.dtFecha.Value)
        End Sub
    End Class

End Namespace
