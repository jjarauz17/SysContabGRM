Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace DataGridTextBoxCombo
    Public Class frmEntradaAlmacenVer
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmEntradaAlmacenVer= Nothing

        Public Shared Function Instance() As frmEntradaAlmacenVer
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmEntradaAlmacenVer()
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
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
        Friend WithEvents rbProductos As System.Windows.Forms.RadioButton
        Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
        Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
        Friend WithEvents txtDepartamento As System.Windows.Forms.TextBox
        Friend WithEvents txtPais As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
        Friend WithEvents txtRuc As System.Windows.Forms.TextBox
        Friend WithEvents cbMunicipios As System.Windows.Forms.ComboBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cbDepartamentos As System.Windows.Forms.ComboBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents etTotal As System.Windows.Forms.Label
        Friend WithEvents etTotalT As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
        Friend WithEvents txtFactura As System.Windows.Forms.TextBox
        Friend WithEvents dgFacturas As System.Windows.Forms.DataGrid
        Friend WithEvents etSubTotal As System.Windows.Forms.Label
        Friend WithEvents etSubTotalT As System.Windows.Forms.Label
        Friend WithEvents etIva As System.Windows.Forms.Label
        Friend WithEvents etIvaT As System.Windows.Forms.Label
        Friend WithEvents cbTipoFactura As System.Windows.Forms.ComboBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmdConsultaProveedores As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents txtOrden As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents rbActivo As System.Windows.Forms.RadioButton
        Friend WithEvents rbInventario As System.Windows.Forms.RadioButton
        Friend WithEvents etInicio As System.Windows.Forms.Label
        Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
        Friend WithEvents etDestino As System.Windows.Forms.Label
        Friend WithEvents rbServicios As System.Windows.Forms.RadioButton
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents dFechaE As DevExpress.XtraEditors.DateEdit
        Friend WithEvents rbProdInvet As System.Windows.Forms.RadioButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtFactura = New System.Windows.Forms.TextBox()
            Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.dFechaE = New DevExpress.XtraEditors.DateEdit()
            Me.txtProveedor = New System.Windows.Forms.TextBox()
            Me.etInicio = New System.Windows.Forms.Label()
            Me.txtOrden = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.cbTipoFactura = New System.Windows.Forms.ComboBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.etSubTotal = New System.Windows.Forms.Label()
            Me.etSubTotalT = New System.Windows.Forms.Label()
            Me.etIva = New System.Windows.Forms.Label()
            Me.etIvaT = New System.Windows.Forms.Label()
            Me.gbTipo = New System.Windows.Forms.GroupBox()
            Me.rbProdInvet = New System.Windows.Forms.RadioButton()
            Me.rbServicios = New System.Windows.Forms.RadioButton()
            Me.rbActivo = New System.Windows.Forms.RadioButton()
            Me.rbInventario = New System.Windows.Forms.RadioButton()
            Me.rbProductos = New System.Windows.Forms.RadioButton()
            Me.TextBox6 = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.gbBotones = New System.Windows.Forms.GroupBox()
            Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdConsultaProveedores = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
            Me.txtMunicipio = New System.Windows.Forms.TextBox()
            Me.txtDepartamento = New System.Windows.Forms.TextBox()
            Me.txtPais = New System.Windows.Forms.TextBox()
            Me.txtDireccion = New System.Windows.Forms.TextBox()
            Me.txtTelefono = New System.Windows.Forms.TextBox()
            Me.txtRuc = New System.Windows.Forms.TextBox()
            Me.cbMunicipios = New System.Windows.Forms.ComboBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.cbDepartamentos = New System.Windows.Forms.ComboBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.etTotal = New System.Windows.Forms.Label()
            Me.etTotalT = New System.Windows.Forms.Label()
            Me.dgFacturas = New System.Windows.Forms.DataGrid()
            Me.etDestino = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cbProveedor = New System.Windows.Forms.ComboBox()
            Me.GroupBox3.SuspendLayout()
            CType(Me.dFechaE.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dFechaE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbTipo.SuspendLayout()
            Me.gbBotones.SuspendLayout()
            CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.Transparent
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label24.Location = New System.Drawing.Point(8, 8)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(88, 25)
            Me.Label24.TabIndex = 145
            Me.Label24.Text = "Proveedor:"
            '
            'dtpFecha
            '
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(704, 9)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 151
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(808, 9)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(96, 25)
            Me.Label11.TabIndex = 150
            Me.Label11.Text = "Fecha Pago:"
            '
            'txtFactura
            '
            Me.txtFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Location = New System.Drawing.Point(512, 8)
            Me.txtFactura.MaxLength = 50
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.Size = New System.Drawing.Size(120, 20)
            Me.txtFactura.TabIndex = 149
            '
            'dtpFechaPago
            '
            Me.dtpFechaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaPago.Location = New System.Drawing.Point(912, 9)
            Me.dtpFechaPago.Name = "dtpFechaPago"
            Me.dtpFechaPago.Size = New System.Drawing.Size(96, 20)
            Me.dtpFechaPago.TabIndex = 152
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox3.Controls.Add(Me.dFechaE)
            Me.GroupBox3.Controls.Add(Me.txtProveedor)
            Me.GroupBox3.Controls.Add(Me.etInicio)
            Me.GroupBox3.Controls.Add(Me.txtOrden)
            Me.GroupBox3.Controls.Add(Me.Label8)
            Me.GroupBox3.Controls.Add(Me.cbTipoFactura)
            Me.GroupBox3.Controls.Add(Me.Label10)
            Me.GroupBox3.Controls.Add(Me.Label25)
            Me.GroupBox3.Controls.Add(Me.etSubTotal)
            Me.GroupBox3.Controls.Add(Me.etSubTotalT)
            Me.GroupBox3.Controls.Add(Me.etIva)
            Me.GroupBox3.Controls.Add(Me.etIvaT)
            Me.GroupBox3.Controls.Add(Me.gbTipo)
            Me.GroupBox3.Controls.Add(Me.gbBotones)
            Me.GroupBox3.Controls.Add(Me.txtMunicipio)
            Me.GroupBox3.Controls.Add(Me.txtDepartamento)
            Me.GroupBox3.Controls.Add(Me.txtPais)
            Me.GroupBox3.Controls.Add(Me.txtDireccion)
            Me.GroupBox3.Controls.Add(Me.txtTelefono)
            Me.GroupBox3.Controls.Add(Me.txtRuc)
            Me.GroupBox3.Controls.Add(Me.cbMunicipios)
            Me.GroupBox3.Controls.Add(Me.Label5)
            Me.GroupBox3.Controls.Add(Me.cbDepartamentos)
            Me.GroupBox3.Controls.Add(Me.Label6)
            Me.GroupBox3.Controls.Add(Me.Label2)
            Me.GroupBox3.Controls.Add(Me.Label9)
            Me.GroupBox3.Controls.Add(Me.Label4)
            Me.GroupBox3.Controls.Add(Me.Label3)
            Me.GroupBox3.Controls.Add(Me.etTotal)
            Me.GroupBox3.Controls.Add(Me.etTotalT)
            Me.GroupBox3.Controls.Add(Me.dgFacturas)
            Me.GroupBox3.Controls.Add(Me.etDestino)
            Me.GroupBox3.Location = New System.Drawing.Point(8, 33)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(1000, 481)
            Me.GroupBox3.TabIndex = 147
            Me.GroupBox3.TabStop = False
            '
            'dFechaE
            '
            Me.dFechaE.EditValue = Nothing
            Me.dFechaE.Location = New System.Drawing.Point(624, 118)
            Me.dFechaE.Name = "dFechaE"
            Me.dFechaE.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
            Me.dFechaE.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dFechaE.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.dFechaE.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.dFechaE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dFechaE.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.dFechaE.Properties.ReadOnly = True
            Me.dFechaE.Size = New System.Drawing.Size(171, 22)
            Me.dFechaE.TabIndex = 168
            '
            'txtProveedor
            '
            Me.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtProveedor.Location = New System.Drawing.Point(440, 252)
            Me.txtProveedor.MaxLength = 50
            Me.txtProveedor.Name = "txtProveedor"
            Me.txtProveedor.Size = New System.Drawing.Size(120, 20)
            Me.txtProveedor.TabIndex = 160
            Me.txtProveedor.Text = "Proveedor"
            Me.txtProveedor.Visible = False
            '
            'etInicio
            '
            Me.etInicio.BackColor = System.Drawing.Color.Transparent
            Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etInicio.Location = New System.Drawing.Point(912, 82)
            Me.etInicio.Name = "etInicio"
            Me.etInicio.Size = New System.Drawing.Size(80, 26)
            Me.etInicio.TabIndex = 159
            Me.etInicio.Text = "1"
            Me.etInicio.Visible = False
            '
            'txtOrden
            '
            Me.txtOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOrden.Location = New System.Drawing.Point(544, 379)
            Me.txtOrden.MaxLength = 50
            Me.txtOrden.Name = "txtOrden"
            Me.txtOrden.ReadOnly = True
            Me.txtOrden.Size = New System.Drawing.Size(120, 20)
            Me.txtOrden.TabIndex = 151
            Me.txtOrden.Visible = False
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(464, 379)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(72, 26)
            Me.Label8.TabIndex = 150
            Me.Label8.Text = "No. Orden:"
            Me.Label8.Visible = False
            '
            'cbTipoFactura
            '
            Me.cbTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTipoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoFactura.Location = New System.Drawing.Point(624, 94)
            Me.cbTipoFactura.Name = "cbTipoFactura"
            Me.cbTipoFactura.Size = New System.Drawing.Size(272, 21)
            Me.cbTipoFactura.TabIndex = 142
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(506, 125)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(112, 13)
            Me.Label10.TabIndex = 143
            Me.Label10.Text = "Fecha de Entrada:"
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.BackColor = System.Drawing.Color.Transparent
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(522, 102)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(96, 13)
            Me.Label25.TabIndex = 143
            Me.Label25.Text = "Forma de Pago:"
            '
            'etSubTotal
            '
            Me.etSubTotal.BackColor = System.Drawing.Color.Transparent
            Me.etSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etSubTotal.Location = New System.Drawing.Point(272, 443)
            Me.etSubTotal.Name = "etSubTotal"
            Me.etSubTotal.Size = New System.Drawing.Size(112, 26)
            Me.etSubTotal.TabIndex = 138
            Me.etSubTotal.Text = "0.00"
            Me.etSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etSubTotalT
            '
            Me.etSubTotalT.BackColor = System.Drawing.Color.Transparent
            Me.etSubTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etSubTotalT.Location = New System.Drawing.Point(184, 443)
            Me.etSubTotalT.Name = "etSubTotalT"
            Me.etSubTotalT.Size = New System.Drawing.Size(80, 26)
            Me.etSubTotalT.TabIndex = 137
            Me.etSubTotalT.Text = "Sub Total:"
            Me.etSubTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etIva
            '
            Me.etIva.BackColor = System.Drawing.Color.Transparent
            Me.etIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIva.ForeColor = System.Drawing.Color.Maroon
            Me.etIva.Location = New System.Drawing.Point(496, 443)
            Me.etIva.Name = "etIva"
            Me.etIva.Size = New System.Drawing.Size(104, 26)
            Me.etIva.TabIndex = 136
            Me.etIva.Text = "0.00"
            Me.etIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etIvaT
            '
            Me.etIvaT.BackColor = System.Drawing.Color.Transparent
            Me.etIvaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIvaT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etIvaT.Location = New System.Drawing.Point(392, 443)
            Me.etIvaT.Name = "etIvaT"
            Me.etIvaT.Size = New System.Drawing.Size(96, 26)
            Me.etIvaT.TabIndex = 135
            Me.etIvaT.Text = "IVA:"
            Me.etIvaT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'gbTipo
            '
            Me.gbTipo.BackColor = System.Drawing.Color.Transparent
            Me.gbTipo.Controls.Add(Me.rbProdInvet)
            Me.gbTipo.Controls.Add(Me.rbServicios)
            Me.gbTipo.Controls.Add(Me.rbActivo)
            Me.gbTipo.Controls.Add(Me.rbInventario)
            Me.gbTipo.Controls.Add(Me.rbProductos)
            Me.gbTipo.Controls.Add(Me.TextBox6)
            Me.gbTipo.Controls.Add(Me.Label12)
            Me.gbTipo.Controls.Add(Me.Label17)
            Me.gbTipo.Controls.Add(Me.Label18)
            Me.gbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo.ForeColor = System.Drawing.Color.Maroon
            Me.gbTipo.Location = New System.Drawing.Point(8, 78)
            Me.gbTipo.Name = "gbTipo"
            Me.gbTipo.Size = New System.Drawing.Size(360, 60)
            Me.gbTipo.TabIndex = 131
            Me.gbTipo.TabStop = False
            '
            'rbProdInvet
            '
            Me.rbProdInvet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProdInvet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbProdInvet.Location = New System.Drawing.Point(8, 34)
            Me.rbProdInvet.Name = "rbProdInvet"
            Me.rbProdInvet.Size = New System.Drawing.Size(152, 18)
            Me.rbProdInvet.TabIndex = 156
            Me.rbProdInvet.Text = "Producto/Inventario"
            '
            'rbServicios
            '
            Me.rbServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbServicios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbServicios.Location = New System.Drawing.Point(104, 13)
            Me.rbServicios.Name = "rbServicios"
            Me.rbServicios.Size = New System.Drawing.Size(80, 17)
            Me.rbServicios.TabIndex = 129
            Me.rbServicios.Text = "Servicios"
            '
            'rbActivo
            '
            Me.rbActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbActivo.Location = New System.Drawing.Point(288, 9)
            Me.rbActivo.Name = "rbActivo"
            Me.rbActivo.Size = New System.Drawing.Size(64, 25)
            Me.rbActivo.TabIndex = 126
            Me.rbActivo.Text = "Activo"
            Me.rbActivo.Visible = False
            '
            'rbInventario
            '
            Me.rbInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbInventario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbInventario.Location = New System.Drawing.Point(192, 9)
            Me.rbInventario.Name = "rbInventario"
            Me.rbInventario.Size = New System.Drawing.Size(88, 25)
            Me.rbInventario.TabIndex = 125
            Me.rbInventario.Text = "Inventario"
            '
            'rbProductos
            '
            Me.rbProductos.Checked = True
            Me.rbProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbProductos.Location = New System.Drawing.Point(8, 9)
            Me.rbProductos.Name = "rbProductos"
            Me.rbProductos.Size = New System.Drawing.Size(88, 25)
            Me.rbProductos.TabIndex = 124
            Me.rbProductos.TabStop = True
            Me.rbProductos.Text = "Productos"
            '
            'TextBox6
            '
            Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox6.Location = New System.Drawing.Point(832, 17)
            Me.TextBox6.MaxLength = 50
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.ReadOnly = True
            Me.TextBox6.Size = New System.Drawing.Size(136, 20)
            Me.TextBox6.TabIndex = 123
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(752, 17)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(72, 26)
            Me.Label12.TabIndex = 103
            Me.Label12.Text = "Teléfono:"
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.Color.Maroon
            Me.Label17.Location = New System.Drawing.Point(632, 474)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(112, 26)
            Me.Label17.TabIndex = 110
            Me.Label17.Text = "0.00"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label18.Location = New System.Drawing.Point(536, 474)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(96, 26)
            Me.Label18.TabIndex = 109
            Me.Label18.Text = "Total:"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'gbBotones
            '
            Me.gbBotones.BackColor = System.Drawing.Color.Transparent
            Me.gbBotones.Controls.Add(Me.cmdAyuda)
            Me.gbBotones.Controls.Add(Me.cmdConsultaProveedores)
            Me.gbBotones.Controls.Add(Me.cmdImprimir)
            Me.gbBotones.Controls.Add(Me.cmdCancelar)
            Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBotones.ForeColor = System.Drawing.Color.Maroon
            Me.gbBotones.Location = New System.Drawing.Point(904, 146)
            Me.gbBotones.Name = "gbBotones"
            Me.gbBotones.Size = New System.Drawing.Size(88, 287)
            Me.gbBotones.TabIndex = 130
            Me.gbBotones.TabStop = False
            '
            'cmdAyuda
            '
            Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAyuda.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdAyuda.Appearance.Options.UseFont = True
            Me.cmdAyuda.Appearance.Options.UseForeColor = True
            Me.cmdAyuda.Location = New System.Drawing.Point(8, 121)
            Me.cmdAyuda.Name = "cmdAyuda"
            Me.cmdAyuda.Size = New System.Drawing.Size(72, 34)
            Me.cmdAyuda.TabIndex = 34
            Me.cmdAyuda.Text = "&Ayuda"
            Me.cmdAyuda.Visible = False
            '
            'cmdConsultaProveedores
            '
            Me.cmdConsultaProveedores.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsultaProveedores.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsultaProveedores.Appearance.Options.UseFont = True
            Me.cmdConsultaProveedores.Appearance.Options.UseForeColor = True
            Me.cmdConsultaProveedores.Location = New System.Drawing.Point(8, 69)
            Me.cmdConsultaProveedores.Name = "cmdConsultaProveedores"
            Me.cmdConsultaProveedores.Size = New System.Drawing.Size(72, 34)
            Me.cmdConsultaProveedores.TabIndex = 33
            Me.cmdConsultaProveedores.Text = "&Proveedor"
            Me.cmdConsultaProveedores.Visible = False
            '
            'cmdImprimir
            '
            Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdImprimir.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdImprimir.Appearance.Options.UseFont = True
            Me.cmdImprimir.Appearance.Options.UseForeColor = True
            Me.cmdImprimir.Location = New System.Drawing.Point(8, 17)
            Me.cmdImprimir.Name = "cmdImprimir"
            Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
            Me.cmdImprimir.TabIndex = 31
            Me.cmdImprimir.Text = "&Imprimir"
            Me.cmdImprimir.Visible = False
            '
            'cmdCancelar
            '
            Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar.Appearance.Options.UseFont = True
            Me.cmdCancelar.Appearance.Options.UseForeColor = True
            Me.cmdCancelar.Location = New System.Drawing.Point(6, 241)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(72, 34)
            Me.cmdCancelar.TabIndex = 29
            Me.cmdCancelar.Text = "&Salir"
            '
            'txtMunicipio
            '
            Me.txtMunicipio.BackColor = System.Drawing.SystemColors.Info
            Me.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMunicipio.Location = New System.Drawing.Point(752, 43)
            Me.txtMunicipio.MaxLength = 50
            Me.txtMunicipio.Name = "txtMunicipio"
            Me.txtMunicipio.ReadOnly = True
            Me.txtMunicipio.Size = New System.Drawing.Size(240, 20)
            Me.txtMunicipio.TabIndex = 127
            '
            'txtDepartamento
            '
            Me.txtDepartamento.BackColor = System.Drawing.SystemColors.Info
            Me.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDepartamento.Location = New System.Drawing.Point(376, 60)
            Me.txtDepartamento.MaxLength = 50
            Me.txtDepartamento.Name = "txtDepartamento"
            Me.txtDepartamento.ReadOnly = True
            Me.txtDepartamento.Size = New System.Drawing.Size(280, 20)
            Me.txtDepartamento.TabIndex = 126
            '
            'txtPais
            '
            Me.txtPais.BackColor = System.Drawing.SystemColors.Info
            Me.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPais.Location = New System.Drawing.Point(48, 46)
            Me.txtPais.MaxLength = 50
            Me.txtPais.Name = "txtPais"
            Me.txtPais.ReadOnly = True
            Me.txtPais.Size = New System.Drawing.Size(216, 20)
            Me.txtPais.TabIndex = 125
            '
            'txtDireccion
            '
            Me.txtDireccion.BackColor = System.Drawing.SystemColors.Info
            Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(376, 17)
            Me.txtDireccion.MaxLength = 50
            Me.txtDireccion.Multiline = True
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.ReadOnly = True
            Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDireccion.Size = New System.Drawing.Size(280, 35)
            Me.txtDireccion.TabIndex = 124
            '
            'txtTelefono
            '
            Me.txtTelefono.BackColor = System.Drawing.SystemColors.Info
            Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono.Location = New System.Drawing.Point(752, 17)
            Me.txtTelefono.MaxLength = 50
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.ReadOnly = True
            Me.txtTelefono.Size = New System.Drawing.Size(240, 20)
            Me.txtTelefono.TabIndex = 123
            '
            'txtRuc
            '
            Me.txtRuc.BackColor = System.Drawing.SystemColors.Info
            Me.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRuc.Location = New System.Drawing.Point(48, 17)
            Me.txtRuc.MaxLength = 50
            Me.txtRuc.Name = "txtRuc"
            Me.txtRuc.ReadOnly = True
            Me.txtRuc.Size = New System.Drawing.Size(216, 20)
            Me.txtRuc.TabIndex = 122
            '
            'cbMunicipios
            '
            Me.cbMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
            Me.cbMunicipios.Enabled = False
            Me.cbMunicipios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbMunicipios.Location = New System.Drawing.Point(448, 319)
            Me.cbMunicipios.Name = "cbMunicipios"
            Me.cbMunicipios.Size = New System.Drawing.Size(224, 22)
            Me.cbMunicipios.TabIndex = 121
            Me.cbMunicipios.Visible = False
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(674, 45)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(72, 26)
            Me.Label5.TabIndex = 120
            Me.Label5.Text = "Municipio:"
            '
            'cbDepartamentos
            '
            Me.cbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
            Me.cbDepartamentos.Enabled = False
            Me.cbDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbDepartamentos.Location = New System.Drawing.Point(448, 284)
            Me.cbDepartamentos.Name = "cbDepartamentos"
            Me.cbDepartamentos.Size = New System.Drawing.Size(224, 23)
            Me.cbDepartamentos.TabIndex = 119
            Me.cbDepartamentos.Visible = False
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(8, 52)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(40, 26)
            Me.Label6.TabIndex = 115
            Me.Label6.Text = "País:"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(282, 26)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(88, 26)
            Me.Label2.TabIndex = 101
            Me.Label2.Text = "Dirección:"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(8, 17)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(40, 26)
            Me.Label9.TabIndex = 100
            Me.Label9.Text = "RUC:"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(274, 62)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(96, 26)
            Me.Label4.TabIndex = 102
            Me.Label4.Text = "Departamento:"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(675, 21)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(72, 26)
            Me.Label3.TabIndex = 103
            Me.Label3.Text = "Teléfono:"
            '
            'etTotal
            '
            Me.etTotal.BackColor = System.Drawing.Color.Transparent
            Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etTotal.Location = New System.Drawing.Point(680, 434)
            Me.etTotal.Name = "etTotal"
            Me.etTotal.Size = New System.Drawing.Size(184, 35)
            Me.etTotal.TabIndex = 110
            Me.etTotal.Text = "0.00"
            Me.etTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etTotalT
            '
            Me.etTotalT.BackColor = System.Drawing.Color.Transparent
            Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etTotalT.Location = New System.Drawing.Point(608, 443)
            Me.etTotalT.Name = "etTotalT"
            Me.etTotalT.Size = New System.Drawing.Size(56, 26)
            Me.etTotalT.TabIndex = 109
            Me.etTotalT.Text = "Total:"
            Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dgFacturas
            '
            Me.dgFacturas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
            Me.dgFacturas.BackColor = System.Drawing.Color.Gainsboro
            Me.dgFacturas.BackgroundColor = System.Drawing.Color.DarkGray
            Me.dgFacturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgFacturas.CaptionBackColor = System.Drawing.Color.DarkKhaki
            Me.dgFacturas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgFacturas.CaptionForeColor = System.Drawing.Color.Black
            Me.dgFacturas.DataMember = ""
            Me.dgFacturas.FlatMode = True
            Me.dgFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgFacturas.ForeColor = System.Drawing.Color.Black
            Me.dgFacturas.GridLineColor = System.Drawing.Color.Silver
            Me.dgFacturas.HeaderBackColor = System.Drawing.Color.Black
            Me.dgFacturas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgFacturas.HeaderForeColor = System.Drawing.Color.White
            Me.dgFacturas.LinkColor = System.Drawing.Color.DarkSlateBlue
            Me.dgFacturas.Location = New System.Drawing.Point(8, 146)
            Me.dgFacturas.Name = "dgFacturas"
            Me.dgFacturas.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgFacturas.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgFacturas.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgFacturas.SelectionForeColor = System.Drawing.Color.White
            Me.dgFacturas.Size = New System.Drawing.Size(888, 287)
            Me.dgFacturas.TabIndex = 27
            '
            'etDestino
            '
            Me.etDestino.BackColor = System.Drawing.Color.Transparent
            Me.etDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etDestino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etDestino.Location = New System.Drawing.Point(936, 66)
            Me.etDestino.Name = "etDestino"
            Me.etDestino.Size = New System.Drawing.Size(56, 26)
            Me.etDestino.TabIndex = 155
            Me.etDestino.Text = "Destino"
            Me.etDestino.Visible = False
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(640, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 25)
            Me.Label1.TabIndex = 146
            Me.Label1.Text = "Fecha:"
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(424, 8)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(80, 25)
            Me.Label7.TabIndex = 148
            Me.Label7.Text = "No. Factura:"
            '
            'cbProveedor
            '
            Me.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbProveedor.Location = New System.Drawing.Point(96, 8)
            Me.cbProveedor.Name = "cbProveedor"
            Me.cbProveedor.Size = New System.Drawing.Size(320, 21)
            Me.cbProveedor.TabIndex = 144
            '
            'frmEntradaAlmacenVer
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1016, 526)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.dtpFecha)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.txtFactura)
            Me.Controls.Add(Me.dtpFechaPago)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.cbProveedor)
            Me.Name = "frmEntradaAlmacenVer"
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            CType(Me.dFechaE.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dFechaE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbTipo.ResumeLayout(False)
            Me.gbTipo.PerformLayout()
            Me.gbBotones.ResumeLayout(False)
            CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet
        Dim ds As DataSet
        'Dim ds1 As DataSet

        Dim i As Integer
        Dim Tipo As Integer

        'Dim Cantidad As DataGridTextBoxColumn
        'Dim Descuento As DataGridTextBoxColumn
        'Dim Precio As DataGridTextBoxColumn
        'Dim WithEvents ItemTipo As DataGridComboBoxColumn

        'Dim ValorActualCantidad As Double
        'Dim ValorActualPrecio As Double
        'Dim ValorActualDescuento As Double

        Dim Facturas As New VB.SysContab.Facturas_ComprasDB()
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()
        Dim Proveedores As New VB.SysContab.ProveedoresDB()
        Dim DetallesProveedor As New VB.SysContab.ProveedoresDetails()
        'Dim Articulos As New VB.SysContab.ArticulosDB()
        'Dim DetallesProducto As New VB.SysContab.ArticulosDetails()
        Dim r As New VB.SysContab.Rutinas()

        Dim OrdenesCompra As New VB.SysContab.Ordenes_ComprasDB()

        Dim Config As New VB.SysContab.ConfiguracionDB()
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()

        Public Nuevo As Boolean

        Dim dsItems As DataSet

        Private Sub frmFacturasCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'r.CambiarEstilo(Me)
            r.FormularioColor(Me)

            ConfigDetalles = Config.GetConfigDetails

            Me.dtpFecha.Value = r.Fecha
            Me.dtpFechaPago.Value = r.Fecha

            cbProveedor.DataSource = Proveedores.ProveedoresList(3).Tables("Proveedores")
            cbProveedor.ValueMember = "Codigo"
            cbProveedor.DisplayMember = "Nombre"

            cbTipoFactura.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
            cbTipoFactura.ValueMember = "Codigo"
            cbTipoFactura.DisplayMember = "Nombre"

            cbProveedor.SelectedValue = 0

            Me.cbProveedor.SelectedValue = Me.txtProveedor.Text

            If Me.rbProdInvet.Checked Then  'Entrada a Almacen Productos/Inventarios
                ds = Facturas.EntradaAlmacenDetalle(txtFactura.Text, Me.txtProveedor.Text, 3)
            Else
                ds = Facturas.EntradaAlmacenDetalle(txtFactura.Text, Me.txtProveedor.Text, Me.etDestino.Text)
            End If

            If ds.Tables("Facturas_Compras").Rows.Count <> 0 Then
                cbProveedor.SelectedValue = ds.Tables("Facturas_Compras").Rows(0).Item("Proveedor_ID")
                cbTipoFactura.SelectedValue = ds.Tables("Facturas_Compras").Rows(0).Item("FormaPago_ID")
                dtpFecha.Value = ds.Tables("Facturas_Compras").Rows(0).Item("Factura_Fecha")
                dtpFechaPago.Value = ds.Tables("Facturas_Compras").Rows(0).Item("Factura_FechaPago")
                Try
                    Me.dFechaE.DateTime = ds.Tables("Facturas_Compras").Rows(0).Item("Factura_FechaAlmacen")
                Catch ex As Exception
                    Me.dFechaE.DateTime = ds.Tables("Facturas_Compras").Rows(0).Item("Factura_Fecha")
                End Try
            End If

            MakeDataSet()
            dgFacturas.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            Me.cbProveedor.Enabled = False
            Me.dtpFecha.Enabled = False
            Me.dtpFechaPago.Enabled = False
            Me.cbTipoFactura.Enabled = False
            Me.txtFactura.ReadOnly = True

            'Me.cbProveedor.BackColor = Color.White
            'Me.cbProveedor.ForeColor = Color.Black
            'Me.dtpFecha.BackColor = Color.White
            'Me.dtpFechaPago.BackColor = Color.White
            'Me.cbTipoFactura.BackColor = Color.White
            'Me.txtFactura.BackColor = Color.White
            'Me.txtDepartamento.BackColor = Color.White
            'Me.txtDireccion.BackColor = Color.White
            'Me.txtMunicipio.BackColor = Color.White
            'Me.txtOrden.BackColor = Color.White
            'Me.txtPais.BackColor = Color.White
            'Me.txtRuc.BackColor = Color.White
            'Me.txtTelefono.BackColor = Color.White

            LeaveCommit = False
            BuscarCombo = True

            TipoItem = "P"

            Indice = -1

            Tipo = 0

            Me.dgFacturas.ReadOnly = True

            ' Me.Text = "E n t r a d a  a  A l m a c é n"
            Me.Text = "Entrada a Bodega"
            Me.Refresh()
        End Sub

        Private Sub cbProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.SelectedValueChanged
            If Not IsNumeric(cbProveedor.SelectedValue) Then
                Exit Sub

            End If

            If cbProveedor.SelectedValue = 0 Or Trim(cbProveedor.Text) = "" Then
                txtRuc.Text = ""
                txtDireccion.Text = ""
                txtTelefono.Text = ""
                txtDepartamento.Text = ""
                txtMunicipio.Text = ""
                Exit Sub
            End If

            DetallesProveedor = VB.SysContab.ProveedoresDB.GetDetails(cbProveedor.SelectedValue)

            txtRuc.Text = DetallesProveedor.Ruc
            txtDireccion.Text = DetallesProveedor.Direccion
            txtTelefono.Text = DetallesProveedor.Telefono
        End Sub

        Private Sub MakeDataSet()

            myDataSet = New DataSet("myDataSet")

            tCust = New DataTable("Articulos")

            Dim cArticuloCodigo As DataColumn
            cArticuloCodigo = New DataColumn("ArticuloCodigo")

            Dim cArticulo As DataColumn
            cArticulo = New DataColumn("Articulo")

            Dim cCantidad As DataColumn
            cCantidad = New DataColumn("Cantidad")

            Dim cPrecio As DataColumn
            cPrecio = New DataColumn("Precio")

            Dim cDescuento As DataColumn
            cDescuento = New DataColumn("Descuento")

            Dim cSubTotal As DataColumn
            cSubTotal = New DataColumn("SubTotal")

            Dim cCodigoTemporal As DataColumn
            cCodigoTemporal = New DataColumn("CodigoTemporal")

            Dim cItemTipo As DataColumn
            cItemTipo = New DataColumn("Tipo")

            tCust.Columns.Add(cArticuloCodigo)
            tCust.Columns.Add(cArticulo)
            tCust.Columns.Add(cCantidad)
            tCust.Columns.Add(cPrecio)
            tCust.Columns.Add(cDescuento)
            tCust.Columns.Add(cSubTotal)
            tCust.Columns.Add(cCodigoTemporal)
            tCust.Columns.Add(cItemTipo)

            myDataSet.Tables.Add(tCust)

            Dim newRow1 As DataRow

            Dim j As Integer

            Dim SubTotal As Double
            Dim Iva As Double

            Dim Descuento As Double

            SubTotal = 0
            Iva = 0

            For j = 0 To ds.Tables("Facturas_Compras").Rows.Count - 1
                newRow1 = tCust.NewRow
                newRow1("ArticuloCodigo") = ds.Tables("Facturas_Compras").Rows(j).Item("Item_ID")

                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("CodigoTemporal") = ds.Tables("Facturas_Compras").Rows(j).Item("Item_ID")
                tCust.Rows(j)("Articulo") = ds.Tables("Facturas_Compras").Rows(j).Item("Nombre")
                tCust.Rows(j)("Cantidad") = ds.Tables("Facturas_Compras").Rows(j).Item("Item_Cantidad_Almacen")
                tCust.Rows(j)("Precio") = CDbl(ds.Tables("Facturas_Compras").Rows(j).Item("Item_Costo")).ToString(Round)
                tCust.Rows(j)("Descuento") = CDbl(ds.Tables("Facturas_Compras").Rows(j).Item("Item_Descuento")).ToString(Round)
                tCust.Rows(j)("Tipo") = ds.Tables("Facturas_Compras").Rows(j).Item("Item_Tipo")

                'e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * 
                'CDbl(e.Row.Item(3)) - Descuento).ToString(Round)

                Descuento = (CDbl(tCust.Rows(j)("Descuento")) * CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio"))) / 100.0
                tCust.Rows(j)("SubTotal") = CDbl((CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio"))) - tCust.Rows(j)("Descuento")).ToString(Round)

                SubTotal = SubTotal + tCust.Rows(j)("SubTotal") '(CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio"))) - tCust.Rows(j)("Descuento")
                Iva = Iva + CDbl(ds.Tables("Facturas_Compras").Rows(j).Item("Item_Iva_Almacen"))

                'etSubTotal.Text = SubTotal + ""
                'etIva.Text = (SubTotalFacturaNoDescuentos * (ConfigDetalles.IVA / 100.0)).ToString(Round)
                'etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)

                'TotalFactura = etTotal.Text
            Next

            Me.etSubTotal.Text = CDbl(SubTotal).ToString(Round)
            Me.etIva.Text = CDbl(Iva).ToString(Round) 'CDbl(CDbl(SubTotal) * (ConfigDetalles.IVA / 100.0)).ToString(Round)
            Me.etTotal.Text = (CDbl(SubTotal).ToString(Round) + CDbl(Iva)).ToString(Round)

        End Sub

        Private Sub AddCustomDataTableStyle()
            Dim ts1 As DataGridTableStyle
            ts1 = New DataGridTableStyle()
            ts1.MappingName = "Articulos"
            ts1.AlternatingBackColor = Color.LightBlue
            Dim colCount As Integer
            colCount = 0

            Dim ArticuloCodigo As DataGridTextBoxColumn
            ArticuloCodigo = New DataGridTextBoxColumn()
            ArticuloCodigo.MappingName = "ArticuloCodigo"
            ArticuloCodigo.HeaderText = "Código"
            ArticuloCodigo.Width = 100
            ArticuloCodigo.ReadOnly = True

            ts1.GridColumnStyles.Add(ArticuloCodigo)
            ts1.PreferredRowHeight = (ArticuloCodigo.TextBox.Height + 3)

            ArticuloCodigo.NullText = ""

            colCount = (colCount + 1)

            Dim Articulo As DataGridTextBoxColumn
            Articulo = New DataGridTextBoxColumn()
            Articulo.MappingName = "Articulo"
            Articulo.HeaderText = "Descripción"
            Articulo.Width = 300
            Articulo.ReadOnly = True

            ts1.GridColumnStyles.Add(Articulo)
            ts1.PreferredRowHeight = (Articulo.TextBox.Height + 3)

            Articulo.NullText = ""
            colCount = (colCount + 1)

            Dim Cantidad As DataGridTextBoxColumn
            Cantidad = New DataGridTextBoxColumn()
            Cantidad.MappingName = "Cantidad"
            Cantidad.HeaderText = "Cantidad"
            Cantidad.Width = 100
            Cantidad.Alignment = HorizontalAlignment.Right
            Cantidad.ReadOnly = True

            ts1.GridColumnStyles.Add(Cantidad)
            colCount = (colCount + 1)

            Cantidad.NullText = ""

            Dim Precio As DataGridTextBoxColumn
            Precio = New DataGridTextBoxColumn()
            Precio.MappingName = "Precio"
            Precio.HeaderText = "Precio"
            Precio.Width = 100
            Precio.Alignment = HorizontalAlignment.Right
            Precio.ReadOnly = True
            Precio.Format = "##,###0.00"

            ts1.GridColumnStyles.Add(Precio)
            colCount = (colCount + 1)

            Precio.NullText = (0).ToString(Round)

            Dim Descuento As DataGridTextBoxColumn
            Descuento = New DataGridTextBoxColumn()
            Descuento.MappingName = "Descuento"
            Descuento.HeaderText = "Descuento %"
            Descuento.Width = 100
            Descuento.Alignment = HorizontalAlignment.Right
            Descuento.ReadOnly = True
            Descuento.Format = "##,###0.00"

            ts1.GridColumnStyles.Add(Descuento)
            colCount = (colCount + 1)

            Descuento.NullText = "0"

            Dim SubTotal As DataGridTextBoxColumn
            SubTotal = New DataGridTextBoxColumn()
            SubTotal.MappingName = "SubTotal"
            SubTotal.HeaderText = "Sub Total"
            SubTotal.Width = 100
            SubTotal.Alignment = HorizontalAlignment.Right
            SubTotal.ReadOnly = True
            SubTotal.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(SubTotal)
            colCount = (colCount + 1)

            SubTotal.NullText = (0).ToString(Round)

            Dim CodigoTemporal As DataGridTextBoxColumn
            CodigoTemporal = New DataGridTextBoxColumn()
            CodigoTemporal.MappingName = "CodigoTemporal"
            CodigoTemporal.HeaderText = "CodigoTemporal"
            CodigoTemporal.Width = 0
            CodigoTemporal.Alignment = HorizontalAlignment.Left
            CodigoTemporal.ReadOnly = True
            ts1.GridColumnStyles.Add(CodigoTemporal)
            colCount = (colCount + 1)

            CodigoTemporal.NullText = ""

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''Tipo = P: Producto S: Servicio'''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim ItemTipo As DataGridTextBoxColumn
            ItemTipo = New DataGridTextBoxColumn()
            ItemTipo.MappingName = "Tipo"
            ItemTipo.HeaderText = "Tipo"
            ItemTipo.Width = 0
            ItemTipo.ReadOnly = True

            ts1.GridColumnStyles.Add(ItemTipo)
            ts1.PreferredRowHeight = (ItemTipo.TextBox.Height + 3)

            ItemTipo.NullText = ""

            colCount = (colCount + 1)

            ts1.AllowSorting = False
            ts1.HeaderFont = dgFacturas.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue

            dgFacturas.CaptionVisible = False

            dgFacturas.TableStyles.Clear()
            dgFacturas.TableStyles.Add(ts1)

        End Sub

        Private Sub tCust_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tCust.ColumnChanged
            'Dim Descuento As Double

            'If e.Column.Ordinal = 2 Or e.Column.Ordinal = 3 Or e.Column.Ordinal = 4 Then
            '    If e.Row.Item(2) Is DBNull.Value Or e.Row.Item(3) Is DBNull.Value Then

            '    Else
            '        If e.Row.Item(4) Is DBNull.Value Then
            '            If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) Then
            '                e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))).ToString(Round)
            '            End If

            '        Else
            '            If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) And IsNumeric(e.Row.Item(4)) Then
            '                Descuento = (CDbl(e.Row.Item(4)) * CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))) / 100.0
            '                e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3)) - Descuento).ToString(Round)
            '            End If


            '        End If

            '    End If

            'End If

            'SubTotalFacturaCliente = 0
            'SubTotalFacturaNoDescuentos = 0
            'TotalFacturaCliente = 0
            'TotalDescuento = 0

            'For i = 0 To tCust.Rows.Count - 1

            '    If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

            '    ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
            '        Try
            '            SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
            '            SubTotalFacturaNoDescuentos = SubTotalFacturaNoDescuentos + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
            '            TotalDescuento = TotalDescuento + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)
            '        Catch ex As Exception
            '            MsgBox(ex.Message)

            '        End Try

            '    End If

            'Next

            'etSubTotal.Text = SubTotalFacturaNoDescuentos.ToString(Round)
            'etIva.Text = (SubTotalFacturaNoDescuentos * (ConfigDetalles.IVA / 100.0)).ToString(Round)
            'etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)

            'TotalFactura = etTotal.Text

        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

        Private Sub frmFacturacionCliente_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            'If MsgBox("Desea salir de Facturación?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            '    e.Cancel = True
            '    Exit Sub
            'End If

            'Try
            '    LoadFacturaTemporal = False
            '    FacturarCotizacion = False
            '    LoadOrden = False

            '    Clientes.DeleteReciboCheques("00000")
            '    Clientes.DeleteReciboTarjetas("00000")
            'Catch ex As Exception
            'End Try


        End Sub

        Private Sub dgFacturas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturas.DoubleClick
            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione el Producto o Servicio", MsgBoxStyle.Information)
                Exit Sub
            End If

            If dgFacturas.Item(dgFacturas.CurrentRowIndex, 0) Is DBNull.Value Then
                MsgBox("Seleccione el Producto o Servicio", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim f As frmDetalleArticulo = f.Instance

            Registro = dgFacturas.Item(dgFacturas.CurrentRowIndex, 0)

            f.MdiParent = Me.MdiParent
            f.Show()
        End Sub

        Private Sub etTotalT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etTotalT.MouseEnter

        End Sub

        Private Sub frmFacturasCompra_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

        End Sub

        Private Sub dgFacturas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturas.MouseEnter

        End Sub

        Private Sub txtDireccion_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseEnter

        End Sub

        Private Sub cbProveedor_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.MouseEnter

        End Sub

        Private Sub gbBotones_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles gbBotones.MouseEnter

        End Sub

        Private Sub GroupBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox3.MouseEnter

        End Sub

        Private Sub cmdConsultaProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaProveedores.Click
            If Me.cbProveedor.Text = "" Then
                MsgBox("Seleccione el Proveedor", MsgBoxStyle.Information)
                Me.cbProveedor.Focus()
                Exit Sub
            End If

            If Me.cbProveedor.SelectedValue = Nothing Then
                MsgBox("El Proveedor no está registrado", MsgBoxStyle.Information)
                Me.cbProveedor.Focus()
                Exit Sub
            End If

            Dim f As frmAcumuladosProveedor = f.Instance

            f.Proveedor = Me.cbProveedor.SelectedValue

            f.MdiParent = Me.MdiParent
            f.Show()

        End Sub

        Private Sub frmFacturasCompra_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
            'Dim f As frmFacturasComprasList = f.Instance
            'ds = f.Facturas.FacturasCompraLista(f.cbProveedor.SelectedValue, f.Fecha, f.cbEstado.SelectedIndex, f.cbTipo.SelectedValue)
            'f.dgOrdenes.DataSource = ds.Tables("Facturas_Compra").DefaultView
        End Sub

        Private Sub cmdImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
            Dim fReportes As New frmReportes()
            'Dim rEntradaAlmacen As New rptEntradaAlmacen()
            'Dim PuntoVenta As New VB.SysContab.PuntosVentasDB()
            Dim r As New VB.SysContab.Rutinas()

            Dim rEntradaAlmacen As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rEntradaAlmacen.Load(Application.StartupPath & "\Reportes\rptEntradaAlmacen.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            rEntradaAlmacen.SetDataSource(Facturas.EntradaAlmacenDetalle(Me.txtFactura.Text, Me.cbProveedor.SelectedValue, Me.etDestino.Text))
            fReportes.crvReportes.ReportSource = rEntradaAlmacen
            freportes.Show()
        End Sub
    End Class

End Namespace

'Economart.
'Plaza españa
'DBA 

'Economart. Managua, Rotonda el Güegüense, 1/2c al lago, (505) 268-3499.
'Eduardo Internacional. Masaya, Barrio el Repliegue. Escuela Hermanos del Japón, ...

