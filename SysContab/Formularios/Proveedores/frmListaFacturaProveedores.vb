Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmListaFacturaProveedores
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmListaFacturaProveedores = Nothing

    Public Shared Function Instance() As frmListaFacturaProveedores
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmListaFacturaProveedores()
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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTipoProv As System.Windows.Forms.Label
    Friend WithEvents dgFacturasP As System.Windows.Forms.DataGrid
    Friend WithEvents etTotalPagar As System.Windows.Forms.Label
    Friend WithEvents etTotales As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbTipoComp As System.Windows.Forms.ComboBox
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents etBalance As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents etMonto As System.Windows.Forms.Label
    Friend WithEvents etMontoPagado As System.Windows.Forms.Label
    Friend WithEvents etMontoPendiente As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents txtconcepto As DevExpress.XtraEditors.MemoEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.dgFacturasP = New System.Windows.Forms.DataGrid
        Me.lblTipoProv = New System.Windows.Forms.Label
        Me.etTotalPagar = New System.Windows.Forms.Label
        Me.etTotales = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbTipoComp = New System.Windows.Forms.ComboBox
        Me.etInicio = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCheque = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.etBalance = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbBancos = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.etMonto = New System.Windows.Forms.Label
        Me.etMontoPagado = New System.Windows.Forms.Label
        Me.etMontoPendiente = New System.Windows.Forms.Label
        Me.lbl = New System.Windows.Forms.Label
        Me.txtconcepto = New DevExpress.XtraEditors.MemoEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgFacturasP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 440)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 52)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(216, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(120, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 26)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Ayuda"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(96, 26)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Pagar Factura"
        '
        'dgFacturasP
        '
        Me.dgFacturasP.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgFacturasP.BackColor = System.Drawing.Color.Gainsboro
        Me.dgFacturasP.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgFacturasP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgFacturasP.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgFacturasP.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturasP.CaptionForeColor = System.Drawing.Color.Black
        Me.dgFacturasP.DataMember = ""
        Me.dgFacturasP.FlatMode = True
        Me.dgFacturasP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturasP.ForeColor = System.Drawing.Color.Black
        Me.dgFacturasP.GridLineColor = System.Drawing.Color.Silver
        Me.dgFacturasP.HeaderBackColor = System.Drawing.Color.Black
        Me.dgFacturasP.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturasP.HeaderForeColor = System.Drawing.Color.White
        Me.dgFacturasP.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgFacturasP.Location = New System.Drawing.Point(8, 103)
        Me.dgFacturasP.Name = "dgFacturasP"
        Me.dgFacturasP.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgFacturasP.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgFacturasP.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgFacturasP.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturasP.Size = New System.Drawing.Size(989, 330)
        Me.dgFacturasP.TabIndex = 12
        '
        'lblTipoProv
        '
        Me.lblTipoProv.Location = New System.Drawing.Point(342, 78)
        Me.lblTipoProv.Name = "lblTipoProv"
        Me.lblTipoProv.Size = New System.Drawing.Size(100, 24)
        Me.lblTipoProv.TabIndex = 16
        Me.lblTipoProv.Text = "Label2"
        Me.lblTipoProv.Visible = False
        '
        'etTotalPagar
        '
        Me.etTotalPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalPagar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etTotalPagar.Location = New System.Drawing.Point(896, 449)
        Me.etTotalPagar.Name = "etTotalPagar"
        Me.etTotalPagar.Size = New System.Drawing.Size(88, 26)
        Me.etTotalPagar.TabIndex = 167
        Me.etTotalPagar.Text = "0.00"
        Me.etTotalPagar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'etTotales
        '
        Me.etTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etTotales.Location = New System.Drawing.Point(456, 449)
        Me.etTotales.Name = "etTotales"
        Me.etTotales.Size = New System.Drawing.Size(120, 26)
        Me.etTotales.TabIndex = 166
        Me.etTotales.Text = "Totales:"
        Me.etTotales.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(294, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 26)
        Me.Label9.TabIndex = 178
        Me.Label9.Text = "Tipo:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Visible = False
        '
        'cbTipoComp
        '
        Me.cbTipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoComp.Location = New System.Drawing.Point(342, 43)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Size = New System.Drawing.Size(231, 21)
        Me.cbTipoComp.TabIndex = 177
        Me.cbTipoComp.Visible = False
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(454, 78)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(64, 25)
        Me.etInicio.TabIndex = 176
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(30, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 26)
        Me.Label5.TabIndex = 175
        Me.Label5.Text = "No. de Cheque:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCheque
        '
        Me.txtCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Location = New System.Drawing.Point(144, 43)
        Me.txtCheque.MaxLength = 13
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(132, 20)
        Me.txtCheque.TabIndex = 172
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 17)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Fecha de Pago:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(144, 78)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 173
        Me.dtpFecha.Value = New Date(2006, 8, 10, 10, 38, 43, 562)
        '
        'etBalance
        '
        Me.etBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etBalance.Location = New System.Drawing.Point(687, 9)
        Me.etBalance.Name = "etBalance"
        Me.etBalance.Size = New System.Drawing.Size(200, 25)
        Me.etBalance.TabIndex = 171
        Me.etBalance.Text = "0"
        Me.etBalance.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(615, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 25)
        Me.Label8.TabIndex = 170
        Me.Label8.Text = "Balance:"
        Me.Label8.Visible = False
        '
        'cbBancos
        '
        Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Location = New System.Drawing.Point(144, 9)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(429, 21)
        Me.cbBancos.TabIndex = 168
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(8, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(128, 25)
        Me.Label25.TabIndex = 169
        Me.Label25.Text = "Cuentas de Bancos:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'etMonto
        '
        Me.etMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etMonto.Location = New System.Drawing.Point(584, 449)
        Me.etMonto.Name = "etMonto"
        Me.etMonto.Size = New System.Drawing.Size(100, 26)
        Me.etMonto.TabIndex = 179
        Me.etMonto.Text = "0.00"
        Me.etMonto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'etMontoPagado
        '
        Me.etMontoPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMontoPagado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etMontoPagado.Location = New System.Drawing.Point(696, 449)
        Me.etMontoPagado.Name = "etMontoPagado"
        Me.etMontoPagado.Size = New System.Drawing.Size(88, 26)
        Me.etMontoPagado.TabIndex = 180
        Me.etMontoPagado.Text = "0.00"
        Me.etMontoPagado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'etMontoPendiente
        '
        Me.etMontoPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMontoPendiente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etMontoPendiente.Location = New System.Drawing.Point(792, 449)
        Me.etMontoPendiente.Name = "etMontoPendiente"
        Me.etMontoPendiente.Size = New System.Drawing.Size(96, 26)
        Me.etMontoPendiente.TabIndex = 181
        Me.etMontoPendiente.Text = "0.00"
        Me.etMontoPendiente.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl
        '
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl.Location = New System.Drawing.Point(615, 43)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(69, 26)
        Me.lbl.TabIndex = 170
        Me.lbl.Text = "Concepto :"
        '
        'txtconcepto
        '
        Me.txtconcepto.Location = New System.Drawing.Point(687, 43)
        Me.txtconcepto.Name = "txtconcepto"
        Me.txtconcepto.Size = New System.Drawing.Size(310, 52)
        Me.txtconcepto.TabIndex = 182
        '
        'frmListaFacturaProveedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1001, 501)
        Me.Controls.Add(Me.txtconcepto)
        Me.Controls.Add(Me.etMontoPendiente)
        Me.Controls.Add(Me.etMontoPagado)
        Me.Controls.Add(Me.etMonto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbTipoComp)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCheque)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.etBalance)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbBancos)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.etTotalPagar)
        Me.Controls.Add(Me.etTotales)
        Me.Controls.Add(Me.lblTipoProv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgFacturasP)
        Me.Controls.Add(Me.lbl)
        Me.Name = "frmListaFacturaProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgFacturasP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Comprobantes As New VB.SysContab.ComprobanteDB()
    Dim CatalogoBancos As New VB.SysContab.Catalogo_BancosDB()
    Dim FacturasDB As New VB.SysContab.Facturas_ComprasDB()
    Dim r As New VB.SysContab.Rutinas()
    Public Fact As String
    Public FactValor As String
    Public WithEvents tCust1 As New DataTable()
    Public WithEvents myDataSet As DataSet
    Public ds As DataSet
    Dim dsCB As DataSet

    Dim Monto As Double
    Dim MontoPagado As Double
    Dim MontoPendiente As Double

    Dim TotalPagar As Double
    Dim NoComprob As Double
    Dim c As Integer

    Private Sub frmListaFacturaProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabla As DataTable
        Dim ds As DataSet

        ''r.CambiarEstilo(Me)
        'r.FormularioColor(Me)

        Me.cbBancos.DataSource = CatalogoBancos.CatalogoBancos().Tables("Tabla")
        Me.cbBancos.ValueMember = "Cuenta"
        Me.cbBancos.DisplayMember = "Nombre"

        Me.cbTipoComp.DataSource = Comprobantes.TiposComprobantesCheques().Tables("TipoComprobantes")
        Me.cbTipoComp.ValueMember = "TipComp_Id"
        Me.cbTipoComp.DisplayMember = "TipComp_Nombre"

        Me.dtpFecha.Value = r.Fecha

        'ds = FacturasDB.GetListxTipoProducto(lblTipoProv.Text)
        ds = FacturasDB.FacturasComprasPendientes

        ds.Tables("Tablas").DefaultView.AllowDelete = False
        ds.Tables("Tablas").DefaultView.AllowNew = False
        ds.Tables("Tablas").DefaultView.AllowEdit = True

        dgFacturasP.DataSource = ds.Tables("Tablas").DefaultView
        Tabla = ds.Tables("Tablas")

        FormatGenerico(dgFacturasP, Tabla)

        If ds.Tables("Tablas").Rows.Count <> 0 Then
            Registro = dgFacturasP.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        dgFacturasP.CaptionText = "Información de Facturas"
        Me.Text = "Facturas"
        'dgFacturasP.ReadOnly = True
        Totales()

        Me.Refresh()

        'CType(Me.dgFacturasP.Item(2, 11), TextBox).Focus()

    End Sub

    Dim Count, i As Integer
    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        'Exit Sub

        'For i = 0 To tCust1.Rows.Count - 1
        '    MsgBox(tCust1.Rows(i)("ProveedorCodigo") & " " & tCust1.Rows(i)("ProveedorCuenta") & " " & tCust1.Rows(i)("ProveedorNombre") & " " & tCust1.Rows(i)("MontoPagar"))
        'Next

        'For i = 0 To Count - 1
        '    If CType(dgFacturasP.Item(i, 0), Boolean) = True Then
        '        MsgBox(dgFacturasP.Item(i, 1))
        '    End If
        'Next

        If Me.cbBancos.SelectedValue = "0" Then
            MsgBox("Seleccione el Banco", MsgBoxStyle.Information)
            Me.cbBancos.Focus()
            Exit Sub
        End If

        If Me.cbTipoComp.SelectedValue = "0" Or Me.cbTipoComp.SelectedValue = Nothing Then
            MsgBox("Seleccione el Tipo de Comprobante", MsgBoxStyle.Information)
            Me.cbTipoComp.Focus()
            Exit Sub
        End If

        MakeDataSet1()
        AddCustomDataTableStyle1()
        AgregarItemTemporal()

        Count = Me.cuentaLineas()

        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction

        Dim DC As String
        Dim Opera As Integer
        Dim Cheque As Long
        Cheque = Me.txtCheque.Text
        Dim Linea As Integer
        Linea = 0
        NoComprob = 0


        Dim Moneda As String

        Moneda = Funciones.ObtieneDatos("Select Moneda from catalogo_bancos where Cuenta = '" & cbBancos.SelectedValue & "' AND Empresa = " & EmpresaActual).Rows(0).Item("Moneda").ToString

        Try
            For i = 0 To tCust1.Rows.Count - 1
                Linea = 1
                NoComprob = Comprobantes.AddComprobante(Me.cbTipoComp.SelectedValue, 1, txtconcepto.Text, Moneda, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value), dtpFecha.Value, 0, tCust1.Rows(i)("ProveedorNombre"), False, tCust1.Rows(i)("ProveedorCodigo"), "", 2, "", VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.CHEQUE)

                For c = i To Count - 1
                    If i = dgFacturasP.Item(c, 10) And CType(dgFacturasP.Item(c, 0), Boolean) = True Then
                        'Comprobantes.PagosFactura(ds.Tables("Facturas").Rows(c).Item("Comp_No"), ds.Tables("Facturas").Rows(c).Item("Per_ID"), ds.Tables("Facturas").Rows(c).Item("Fecha"), tCust.Rows(c)("MontoPagar"), NoComprob, VB.SysContab.PeriodosDB.Activo, dtpFecha.Value)
                        Comprobantes.PagosFactura(dgFacturasP.Item(c, 11), dgFacturasP.Item(c, 13), dgFacturasP.Item(c, 2), dgFacturasP.Item(c, 7), NoComprob, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value), dtpFecha.Value, dgFacturasP.Item(c, 1), dgFacturasP.Item(c, 8), 0)
                        'Comprobantes.CancelarFactura(dgFacturasP.Item(c, 1), dgFacturasP.Item(c, 8))
                        'Comprobantes.CancelarFactura(FacturaNo, Proveedor)
                    End If
                Next

                DC = "C"

                If Trim(Me.txtCheque.Text) <> "" Then
                    Comprobantes.ActualizarCheque(Me.cbBancos.SelectedValue, Cheque)
                End If

                Comprobantes.AddComprobanteDetalles(NoComprob, Me.cbBancos.SelectedValue, "", tCust1.Rows(i)("MontoPagar"), Cheque, Me.cbTipoComp.SelectedValue, DC, 0, 0, Me.dtpFecha.Value, 0)
                'Comprobantes.AddCatalogoTrans(Me.cbBancos.SelectedValue, 0, tCust1.Rows(i)("MontoPagar"), "")

                DC = "D"
                Opera = 1

                Comprobantes.AddComprobanteDetalles(NoComprob, tCust1.Rows(i)("ProveedorCuenta"), "", tCust1.Rows(i)("MontoPagar"), Cheque, Me.cbTipoComp.SelectedValue, DC, 0, 0, Me.dtpFecha.Value, 1)
                'Comprobantes.AddCatalogoTrans(tCust1.Rows(i)("ProveedorCuenta"), tCust1.Rows(i)("MontoPagar"), 0, "")

                Cheque = Cheque + 1

            Next

            VB.SysContab.Rutinas.okTransaccion()

            dsCB = CatalogoBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
            Me.txtCheque.Text = CatalogoBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
            Me.etBalance.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbBancos.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value))).ToString(Round)


            'Fact = dgFacturasP.Item(dgFacturasP.CurrentRowIndex, 1)
            'FactValor = dgFacturasP.Item(dgFacturasP.CurrentRowIndex, 10)

            'Dim fr As frmPlantillasBancos = fr.Instance
            'fr.MdiParent = Me.MdiParent

            'fr.lblProv.Text = dgFacturasP.Item(dgFacturasP.CurrentRowIndex, 4)
            'fr.lblProvID.Text = dgFacturasP.Item(dgFacturasP.CurrentRowIndex, 3)
            'fr.etCodigoProveedor.Text = dgFacturasP.Item(dgFacturasP.CurrentRowIndex, 11)
            'fr.etFecha.Text = dgFacturasP.Item(dgFacturasP.CurrentRowIndex, 2)
            'fr.lblFact.Text = Fact
            'fr.lblFactMonto.Text = FactValor
            'fr.Show()
            txtconcepto.Text = ""
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Sub
        End Try

        ds = FacturasDB.FacturasComprasPendientes
        dgFacturasP.DataSource = ds.Tables("Tablas").DefaultView

        Totales()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmListaFacturaProveedores_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

    End Sub

    Private Sub dgFacturasProveedores_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgFacturasP.MouseEnter

    End Sub

    'Private Sub dgFacturasProveedores_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgFacturasP.CurrentCellChanged
    '    'Me.dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 11).focus()
    '    Registro = dgFacturasP.Item(dgFacturasP.CurrentRowIndex, 0)
    'End Sub

    Private myCheckBoxCol As Integer = 0
    Private Sub dgFacturasP_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgFacturasP.MouseUp
        Dim hti As DataGrid.HitTestInfo = Me.dgFacturasP.HitTest(e.X, e.Y)
        Try
            If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
                Me.dgFacturasP(hti.Row, hti.Column) = Not CBool(Me.dgFacturasP(hti.Row, hti.Column))
                If Me.dgFacturasP(hti.Row, hti.Column) = True Then
                    If dgFacturasP.Item(hti.Row, 7) = "" Then
                        dgFacturasP.Item(hti.Row, 7) = CDbl(dgFacturasP.Item(hti.Row, 6)).ToString(Round)
                    End If
                Else
                    dgFacturasP.Item(hti.Row, 7) = ""
                End If
                'Me.dgFacturasP.Refresh()
                CalcularTotalPagar()
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Function cuentaLineas() As Integer
        Dim cont As Integer = 0
        Dim indiceActual As Integer = 0
        Dim indiceAnterior As Integer = -1
        Dim indiceRID As Integer = Me.dgFacturasP.CurrentRowIndex

        Try
            If (Me.dgFacturasP.CurrentRowIndex <> -1) Then
                If (Me.dgFacturasP.VisibleRowCount <> -1) Then
                    Me.dgFacturasP.CurrentRowIndex = 0

                    While (indiceActual <> indiceAnterior)
                        indiceAnterior = indiceActual

                        Me.dgFacturasP.CurrentRowIndex = Me.dgFacturasP.CurrentRowIndex + 1
                        indiceActual = Me.dgFacturasP.CurrentRowIndex
                        cont = cont + 1
                    End While

                    Me.dgFacturasP.CurrentRowIndex = indiceRID
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return cont
    End Function

    Dim n As Integer

    Private Sub AgregarItemTemporal()
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim c As Integer
        c = 0

        For k = 0 To Count - 1 ' tCust.Rows.Count - 1
            If CType(dgFacturasP.Item(k, 0), Boolean) = True Then
                c = 1
                Exit For
            End If

            'If tCust.Rows(k)("Agregar") = True Then
            '    c = 1
            '    Exit For
            'End If
        Next

        n = 0

        For i = 0 To Count - 1 'tCust.Rows.Count - 1
            If CType(dgFacturasP.Item(i, 0), Boolean) = True Then 'If tCust.Rows(i)("Agregar") = True Then
                For j = 0 To tCust1.Rows.Count - 1
                    If dgFacturasP.Item(i, 8) = tCust1.Rows(j)("ProveedorCodigo") Then
                        'tCust.Rows(i)("Numero") = j
                        dgFacturasP.Item(i, 10) = j
                        tCust1.Rows(j)("MontoPagar") = CDbl(tCust1.Rows(j)("MontoPagar")) + CDbl(dgFacturasP.Item(i, 7)) 'CDbl(tCust.Rows(i)("MontoPagar"))
                        Exit For
                    End If
                Next

                If j = tCust1.Rows.Count Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust1.NewRow

                    newRow1("ProveedorCodigo") = dgFacturasP.Item(i, 8) ' ds.Tables("Facturas").Rows(i).Item("Codigo")
                    tCust1.Rows.Add(newRow1)

                    tCust1.Rows(n)("ProveedorCuenta") = dgFacturasP.Item(i, 9)
                    tCust1.Rows(n)("ProveedorNombre") = dgFacturasP.Item(i, 3)
                    tCust1.Rows(n)("MontoPagar") = dgFacturasP.Item(i, 7)

                    n = n + 1
                End If
            Else

            End If

        Next

        For i = 0 To Count - 1 ' tCust.Rows.Count - 1
            For j = 0 To tCust1.Rows.Count - 1
                If dgFacturasP.Item(i, 8) = tCust1.Rows(j)("ProveedorCodigo") Then
                    dgFacturasP.Item(i, 10) = j
                End If
            Next
        Next

    End Sub

    Public Sub AddCustomDataTableStyle1()
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle()
        ts1.MappingName = "Item1"
        ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount As Integer
        colCount = 0

        'Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        'boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        'boolCol.MappingName = "Agregar"
        'boolCol.HeaderText = "Pagar"
        'boolCol.Alignment = HorizontalAlignment.Center
        'CType(boolCol, DataGridBoolColumn).AllowNull = False
        'boolCol.Width = 50
        'boolCol.ReadOnly = False
        'boolCol.NullText = ""
        'AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
        'ts1.GridColumnStyles.Add(boolCol)
        'colCount = (colCount + 1)

        'Dim Fecha As DataGridTextBoxColumn
        'Fecha = New DataGridTextBoxColumn()
        'Fecha.MappingName = "Fecha"
        'Fecha.HeaderText = "Fecha"
        'Fecha.Width = 85
        'Fecha.ReadOnly = True
        'Fecha.Format = "dd/MM/yyyy"
        'ts1.GridColumnStyles.Add(Fecha)
        'colCount = (colCount + 1)
        'Fecha.NullText = ""


        Dim ProveedorCodigo As DataGridColumnStyle
        ProveedorCodigo = New DataGridTextBoxColumn()
        ProveedorCodigo.MappingName = "ProveedorCodigo"
        ProveedorCodigo.HeaderText = "ProveedorCodigo"
        ProveedorCodigo.Width = 300
        ProveedorCodigo.ReadOnly = True
        ts1.GridColumnStyles.Add(ProveedorCodigo)
        colCount = (colCount + 1)
        ProveedorCodigo.NullText = ""

        Dim ProveedorCuenta As DataGridColumnStyle
        ProveedorCuenta = New DataGridTextBoxColumn()
        ProveedorCuenta.MappingName = "ProveedorCuenta"
        ProveedorCuenta.HeaderText = "ProveedorCuenta"
        ProveedorCuenta.Width = 300
        ProveedorCuenta.ReadOnly = True
        ts1.GridColumnStyles.Add(ProveedorCuenta)
        colCount = (colCount + 1)
        ProveedorCuenta.NullText = ""

        Dim ProveedorNombre As DataGridColumnStyle
        ProveedorNombre = New DataGridTextBoxColumn()
        ProveedorNombre.MappingName = "ProveedorNombre"
        ProveedorNombre.HeaderText = "ProveedorNombre"
        ProveedorNombre.Width = 300
        ProveedorNombre.ReadOnly = True
        ts1.GridColumnStyles.Add(ProveedorNombre)
        colCount = (colCount + 1)
        ProveedorNombre.NullText = ""

        'Dim Factura As DataGridColumnStyle
        'Factura = New DataGridTextBoxColumn()
        'Factura.MappingName = "Factura"
        'Factura.HeaderText = "Factura"
        'Factura.Width = 75
        'Factura.ReadOnly = True
        'Factura.Alignment = HorizontalAlignment.Left
        'ts1.GridColumnStyles.Add(Factura)
        'colCount = (colCount + 1)
        'Factura.NullText = ""

        'Dim Codigo As DataGridColumnStyle
        'Codigo = New DataGridTextBoxColumn()
        'Codigo.MappingName = "Codigo"
        'Codigo.HeaderText = "Codigo"
        'Codigo.Width = 100
        'Codigo.ReadOnly = True
        'Codigo.Alignment = HorizontalAlignment.Right
        'ts1.GridColumnStyles.Add(Codigo)
        'colCount = (colCount + 1)
        'Codigo.NullText = ""

        'Dim Cuenta As DataGridColumnStyle
        'Cuenta = New DataGridTextBoxColumn()
        'Cuenta.MappingName = "Cuenta"
        'Cuenta.HeaderText = "Cuenta"
        'Cuenta.Width = 100
        'Cuenta.ReadOnly = True
        'Cuenta.Alignment = HorizontalAlignment.Right
        'ts1.GridColumnStyles.Add(Cuenta)
        'colCount = (colCount + 1)
        'Cuenta.NullText = ""

        'Dim Comp_No As DataGridColumnStyle
        'Comp_No = New DataGridTextBoxColumn()
        'Comp_No.MappingName = "Comp_No"
        'Comp_No.HeaderText = "Comp_No"
        'Comp_No.Width = 100
        'Comp_No.ReadOnly = True
        'Comp_No.Alignment = HorizontalAlignment.Right
        'ts1.GridColumnStyles.Add(Comp_No)
        'colCount = (colCount + 1)
        'Comp_No.NullText = ""

        'Dim Per_ID As DataGridColumnStyle
        'Per_ID = New DataGridTextBoxColumn()
        'Per_ID.MappingName = "Per_ID"
        'Per_ID.HeaderText = "Per_ID"
        'Per_ID.Width = 100
        'Per_ID.ReadOnly = True
        'Per_ID.Alignment = HorizontalAlignment.Right
        'ts1.GridColumnStyles.Add(Per_ID)
        'colCount = (colCount + 1)
        'Per_ID.NullText = ""

        Dim MontoPagar As New DataGridTextBoxColumn()
        MontoPagar.MappingName = "MontoPagar"
        MontoPagar.HeaderText = "Monto a Pagar"
        MontoPagar.ReadOnly = False
        MontoPagar.Alignment = HorizontalAlignment.Right
        MontoPagar.Width = 100
        MontoPagar.NullText = ""
        ts1.GridColumnStyles.Add(MontoPagar)
        colCount = (colCount + 1)

    End Sub

    Public Sub MakeDataSet1()
        myDataSet = New DataSet("myDataSet")

        tCust1 = New DataTable("Item1")

        'Dim cAgregar As DataColumn
        'cAgregar = New DataColumn("Agregar", GetType(System.Boolean))

        'Dim cFecha As DataColumn
        'cFecha = New DataColumn("Fecha")

        Dim cProveedorCodigo As DataColumn
        cProveedorCodigo = New DataColumn("ProveedorCodigo")

        Dim cProveedorCuenta As DataColumn
        cProveedorCuenta = New DataColumn("ProveedorCuenta")

        Dim cProveedorNombre As DataColumn
        cProveedorNombre = New DataColumn("ProveedorNombre")

        'Dim cFactura As DataColumn
        'cFactura = New DataColumn("Factura")

        'Dim cCodigo As DataColumn
        'cCodigo = New DataColumn("Codigo")

        'Dim cCuenta As DataColumn
        'cCuenta = New DataColumn("Cuenta")

        'Dim cComp_No As DataColumn
        'cComp_No = New DataColumn("Comp_No")

        'Dim cPer_ID As DataColumn
        'cPer_ID = New DataColumn("Per_ID")

        Dim cMontoPagar As DataColumn
        cMontoPagar = New DataColumn("MontoPagar")

        tCust1.Columns.Add(cProveedorCodigo)
        tCust1.Columns.Add(cProveedorCuenta)
        tCust1.Columns.Add(cProveedorNombre)
        tCust1.Columns.Add(cMontoPagar)

        myDataSet.Tables.Add(tCust1)

    End Sub

    Public Function FormatGenerico(ByVal Grilla As DataGrid, ByVal fuente As DataTable) As Boolean
        Dim i As Integer = 0
        Grilla.TableStyles.Clear()
        Dim EstiloGrilla As New DataGridTableStyle()

        EstiloGrilla.MappingName = fuente.TableName()             'Estilo de la Grilla, para la tabla maestra de terceros de facturación
        Dim column As New DataGridTextBoxColumn()

        Dim fila1 As DataRow = fuente.NewRow()
        EstiloGrilla.PreferredRowHeight = 25
        While i < fuente.Columns.Count
            If Grilla.Name = "dgFacturasP" And fuente.Columns(i).Caption = "Seleccionar" Then
                Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
                boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(0)
                boolCol.MappingName = fuente.Columns(i).ColumnName
                boolCol.HeaderText = fuente.Columns(i).Caption
                boolCol.Alignment = HorizontalAlignment.Center
                CType(boolCol, DataGridBoolColumn).AllowNull = False

                boolCol.Width = 75
                boolCol.ReadOnly = False

                boolCol.NullText = ""

                AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)

                EstiloGrilla.GridColumnStyles.Add(boolCol)
                EstiloGrilla.ReadOnly = False

            Else

                If fuente.Columns(i).Caption <> "." Then
                    column = New DataGridTextBoxColumn()
                    column.MappingName = fuente.Columns(i).ColumnName
                    column.HeaderText = fuente.Columns(i).Caption
                    column.ReadOnly = True

                    column.NullText = ""

                    If Grilla.Name = "dgFacturasP" Then
                        If column.MappingName = "Forma de Pago" Then
                            column.Width = 100
                        ElseIf column.MappingName = "Cuenta" Or column.MappingName = "Codigo" Or column.MappingName = "Descuento" Or column.MappingName = "Sub Total" Or column.MappingName = "IVA" Or column.MappingName = "Linea" Or column.MappingName = "Comp_No" Or column.MappingName = "Empresa" Or column.MappingName = "Per_ID" Or column.MappingName = "Mes" Or column.MappingName = "Destino" Then
                            column.Width = 0
                            column.HeaderText = ""
                        ElseIf column.MappingName = "Monto a Pagar" Then
                            'column.Format = "##,###0.00"
                            column.Alignment = HorizontalAlignment.Right
                            column.Width = 100
                            column.ReadOnly = False
                            AddHandler column.TextBox.Leave, New EventHandler(AddressOf TextBoxMontoLeaveHandler)
                        ElseIf column.MappingName = "Monto" Or column.MappingName = "Monto Pagado" Or column.MappingName = "Monto Pendiente" Then
                            column.Format = "##,###0.00"
                            column.Alignment = HorizontalAlignment.Right
                            column.Width = 100
                        ElseIf column.MappingName = "Nombre" Then
                            column.HeaderText = "Proveedor"
                            column.Width = 290
                        ElseIf column.MappingName = "Fecha" Then
                            column.Format = "dd/MM/yyyy"
                            column.Width = 90
                        ElseIf column.MappingName = "Factura" Then
                            column.Width = 90
                        ElseIf column.MappingName = "Total" Then
                            column.Format = "##,###0.00"
                            column.Alignment = HorizontalAlignment.Right
                            column.Width = 100
                        End If
                    End If
                End If

                EstiloGrilla.HeaderFont = Grilla.HeaderFont
                EstiloGrilla.GridColumnStyles.Add(column)

            End If
            i += 1
        End While

        'EstiloGrilla.DataGrid.se
        EstiloGrilla.AlternatingBackColor = Color.LightBlue
        Grilla.TableStyles.Add(EstiloGrilla)

        Grilla.TableStyles.Item(0).GridLineColor = Grilla.BackColor.SteelBlue
        Grilla.TableStyles.Item(0).HeaderBackColor = Grilla.BackColor.LightSteelBlue

    End Function

    Private Sub TextBoxMontoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
        If CType(sender, System.Windows.Forms.DataGridTextBox).Text = "" Then
            dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 0) = False
            CalcularTotalPagar()
            Exit Sub
        End If

        If Not IsNumeric(CType(sender, System.Windows.Forms.DataGridTextBox).Text) Then
            MsgBox("Introduzca un valor númerico", MsgBoxStyle.Information)
            CType(sender, System.Windows.Forms.DataGridTextBox).Focus()
            Exit Sub
        Else
            If CDbl(CType(sender, System.Windows.Forms.DataGridTextBox).Text) = 0 Then
                dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 7) = ""
                dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 0) = False
            Else
                CType(sender, System.Windows.Forms.DataGridTextBox).Text = CDbl(CType(sender, System.Windows.Forms.DataGridTextBox).Text).ToString(Round)
                dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 7) = CDbl(CType(sender, System.Windows.Forms.DataGridTextBox).Text).ToString(Round)
                dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 0) = True
            End If
        End If

        dgFacturasP.Refresh()

        CalcularTotalPagar()

    End Sub

    Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
        'MsgBox(e.BoolValue.ToString)

        'Dim hti As DataGrid.HitTestInfo = Me.dgFacturasP.HitTest(e.X, e.Y)
        'Try
        '    If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
        '        Me.dgFacturasP(hti.Row, hti.Column) = Not CBool(Me.dgFacturasP(hti.Row, hti.Column))
        '        If Me.dgFacturasP(hti.Row, hti.Column) = True Then
        '            If dgFacturasP.Item(hti.Row, 12) = "" Then
        '                dgFacturasP.Item(hti.Row, 12) = CDbl(dgFacturasP.Item(hti.Row, 10)).ToString(Round)
        '            End If
        '        Else
        '            dgFacturasP.Item(hti.Row, 12) = ""
        '        End If
        '        'Me.dgFacturasP.Refresh()
        '        CalcularTotalPagar()
        '    End If
        'Catch ex As Exception
        '    'MessageBox.Show(ex.ToString())
        'End Try
        'If e.BoolValue = True Then
        '    If dgFacturasP.Item(e.Row, 12) = "" Then
        '        dgFacturasP.Item(e.Row, 12) = CDbl(dgFacturasP.Item(e.Row, 10)).ToString(Round)
        '    End If
        'Else
        '    dgFacturasP.Item(e.Row, 12) = ""
        'End If
        'Me.dgFacturasP.Refresh()

        'CalcularTotalPagar()

        Dim s As String
        s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
        Console.WriteLine(s)

    End Sub

    Private Sub CalcularTotalPagar()
        TotalPagar = 0

        For i = 0 To Count - 1
            If CType(dgFacturasP.Item(i, 0), Boolean) = True Then
                TotalPagar = TotalPagar + CDbl(dgFacturasP.Item(i, 7))
            End If
        Next
        Me.etTotalPagar.Text = TotalPagar.ToString(Round)
    End Sub

    Private Sub cbBancos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBancos.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If

        If Me.cbBancos.SelectedValue = "0" Then
            Me.Label8.Visible = False
            Me.etBalance.Text = 0
            Me.etBalance.Visible = False
            Me.txtCheque.Text = ""
        Else
            Me.Label8.Visible = True
            Me.etBalance.Visible = True
            dsCB = CatalogoBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
            Me.txtCheque.Text = CatalogoBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
            Me.etBalance.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbBancos.SelectedValue, VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value))).ToString(Round)
        End If
    End Sub

    Private Sub Totales()
        Count = 0
        Count = Me.cuentaLineas()

        Monto = 0
        MontoPendiente = 0
        MontoPagado = 0

        For i = 0 To Count - 1
            Me.dgFacturasP.Item(i, 10) = i + 1
            Monto = Monto + CDbl(Me.dgFacturasP.Item(i, 4))
            MontoPagado = MontoPagado + CDbl(Me.dgFacturasP.Item(i, 5))
            MontoPendiente = MontoPendiente + CDbl(Me.dgFacturasP.Item(i, 6))
        Next

        If Count >= 1 Then
            Me.dgFacturasP.CurrentRowIndex = 0
        End If

        Me.etMonto.Text = CDbl(Monto).ToString(Round)
        Me.etMontoPagado.Text = CDbl(MontoPagado).ToString(Round)
        Me.etMontoPendiente.Text = CDbl(MontoPendiente).ToString(Round)

        Me.etTotalPagar.Text = "0.00"
    End Sub

    Private Sub dgFacturasP_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturasP.DoubleClick
        If Me.dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 15) = 4 Then
            Dim f1 As DataGridTextBoxCombo.frmFacturaProveedorEditarFP = DataGridTextBoxCombo.frmFacturaProveedorEditarFP.Instance
            f1.Comp = Me.dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 11)
            f1.Per = Me.dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 13)
            f1.Fecha = Me.dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 2)
            f1.MdiParent = Me.MdiParent
            f1.Show()
        ElseIf Me.dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 15) = 3 Then
            Inicio = True
            Dim f2 As frmFacturaProveedores = frmFacturaProveedores.Instance
            f2.txtFactura.Text = Me.dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 1)
            f2.cbProveedor.EditValue = Me.dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 8)
            f2.MdiParent = Me.MdiParent
            f2.Show()
            f2.WindowState = FormWindowState.Maximized

            f2.cbProveedor.Focus()
            Inicio = False
        Else
            Dim f As DataGridTextBoxCombo.frmFacturasCompraVer = f.Instance
            f.txtFactura.Text = Me.dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 1)
            f.txtProveedor.Text = Me.dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 8)
            f.etDestino.Text = Me.dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 15)

            f.gbTipo.Enabled = False
            f.MdiParent = Me.MdiParent
            f.Show()
            f.WindowState = FormWindowState.Maximized
        End If
    End Sub


    Private Sub dgFacturasP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgFacturasP.KeyDown
        'If Me.dgFacturasP.CurrentCell.ColumnNumber = 0 Then
        '    Me.dgFacturasP.Refresh()
        '    If Me.dgFacturasP(Me.dgFacturasP.CurrentRowIndex, 0) = True Then
        '        If dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 7) = "" Then
        '            dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 7) = CDbl(dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 6)).ToString(Round)
        '        End If
        '    Else
        '        dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 7) = ""
        '    End If

        'End If
    End Sub

    Private Sub dgFacturasP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgFacturasP.KeyPress
        If Me.dgFacturasP.CurrentCell.ColumnNumber = 0 Then
            Me.dgFacturasP.Refresh()
            If Me.dgFacturasP(Me.dgFacturasP.CurrentRowIndex, 0) = True Then
                If dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 7) = "" Then
                    dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 7) = CDbl(dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 6)).ToString(Round)
                End If
            Else
                dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 7) = ""
            End If

        End If
    End Sub

    Private Sub dgFacturasP_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgFacturasP.KeyUp
        If Me.dgFacturasP.CurrentCell.ColumnNumber = 0 Then
            Me.dgFacturasP.Refresh()
            If Me.dgFacturasP(Me.dgFacturasP.CurrentRowIndex, 0) = True Then
                If dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 7) = "" Then
                    dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 7) = CDbl(dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 6)).ToString(Round)
                End If
            Else
                dgFacturasP.Item(Me.dgFacturasP.CurrentRowIndex, 7) = ""
            End If

        End If
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Help.ShowHelp(Me, "Ayuda/Procesos/ProcesoPagarFact.chm")
    End Sub
End Class
