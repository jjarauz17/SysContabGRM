Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports SysContab.VB.SysContab


Namespace DataGridTextBoxCombo

    Public Class frmCotizacionVer
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmCotizacionVer = Nothing

        Public Shared Function Instance() As frmCotizacionVer
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmCotizacionVer()
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
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents etSubTotal As System.Windows.Forms.Label
        Friend WithEvents etSubTotalT As System.Windows.Forms.Label
        Friend WithEvents etIva As System.Windows.Forms.Label
        Friend WithEvents etIvaT As System.Windows.Forms.Label
        Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
        Friend WithEvents cmdConsultaClientes As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdConsulta As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
        Friend WithEvents rbAmbos As System.Windows.Forms.RadioButton
        Friend WithEvents rbServicios As System.Windows.Forms.RadioButton
        Friend WithEvents rbProductos As System.Windows.Forms.RadioButton
        Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtDescuentoServicio As System.Windows.Forms.TextBox
        Friend WithEvents txtDescuentoProducto As System.Windows.Forms.TextBox
        Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
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
        Friend WithEvents Label24 As System.Windows.Forms.Label
        'Friend WithEvents txtFecha As AxMSMask.AxMaskEdBox
        Friend WithEvents cbCliente As System.Windows.Forms.ComboBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dgCotizaciones As System.Windows.Forms.DataGrid
        Friend WithEvents txtCotizacion As System.Windows.Forms.TextBox
        Friend WithEvents txtFactura As System.Windows.Forms.TextBox
        Friend WithEvents etFactura As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.txtCotizacion = New System.Windows.Forms.TextBox
            Me.GroupBox3 = New System.Windows.Forms.GroupBox
            Me.txtVendedor = New System.Windows.Forms.TextBox
            Me.Label10 = New System.Windows.Forms.Label
            Me.etSubTotal = New System.Windows.Forms.Label
            Me.etSubTotalT = New System.Windows.Forms.Label
            Me.etIva = New System.Windows.Forms.Label
            Me.etIvaT = New System.Windows.Forms.Label
            Me.gbBotones = New System.Windows.Forms.GroupBox
            Me.cmdConsultaClientes = New DevExpress.XtraEditors.SimpleButton
            Me.cmdConsulta = New DevExpress.XtraEditors.SimpleButton
            Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
            Me.gbTipo = New System.Windows.Forms.GroupBox
            Me.rbAmbos = New System.Windows.Forms.RadioButton
            Me.rbServicios = New System.Windows.Forms.RadioButton
            Me.rbProductos = New System.Windows.Forms.RadioButton
            Me.TextBox6 = New System.Windows.Forms.TextBox
            Me.Label12 = New System.Windows.Forms.Label
            Me.Label17 = New System.Windows.Forms.Label
            Me.Label18 = New System.Windows.Forms.Label
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.txtDescuentoServicio = New System.Windows.Forms.TextBox
            Me.txtDescuentoProducto = New System.Windows.Forms.TextBox
            Me.TextBox5 = New System.Windows.Forms.TextBox
            Me.Label8 = New System.Windows.Forms.Label
            Me.Label13 = New System.Windows.Forms.Label
            Me.Label14 = New System.Windows.Forms.Label
            Me.Label15 = New System.Windows.Forms.Label
            Me.Label16 = New System.Windows.Forms.Label
            Me.txtMunicipio = New System.Windows.Forms.TextBox
            Me.txtDepartamento = New System.Windows.Forms.TextBox
            Me.txtPais = New System.Windows.Forms.TextBox
            Me.txtDireccion = New System.Windows.Forms.TextBox
            Me.txtTelefono = New System.Windows.Forms.TextBox
            Me.txtRuc = New System.Windows.Forms.TextBox
            Me.cbMunicipios = New System.Windows.Forms.ComboBox
            Me.Label5 = New System.Windows.Forms.Label
            Me.cbDepartamentos = New System.Windows.Forms.ComboBox
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.etTotal = New System.Windows.Forms.Label
            Me.etTotalT = New System.Windows.Forms.Label
            Me.dgCotizaciones = New System.Windows.Forms.DataGrid
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label24 = New System.Windows.Forms.Label
            Me.cbCliente = New System.Windows.Forms.ComboBox
            Me.Label7 = New System.Windows.Forms.Label
            Me.txtFactura = New System.Windows.Forms.TextBox
            Me.etFactura = New System.Windows.Forms.Label
            Me.GroupBox3.SuspendLayout()
            Me.gbBotones.SuspendLayout()
            Me.gbTipo.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtCotizacion
            '
            Me.txtCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCotizacion.Location = New System.Drawing.Point(512, 8)
            Me.txtCotizacion.MaxLength = 50
            Me.txtCotizacion.Name = "txtCotizacion"
            Me.txtCotizacion.ReadOnly = True
            Me.txtCotizacion.Size = New System.Drawing.Size(136, 20)
            Me.txtCotizacion.TabIndex = 132
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox3.Controls.Add(Me.txtVendedor)
            Me.GroupBox3.Controls.Add(Me.Label10)
            Me.GroupBox3.Controls.Add(Me.etSubTotal)
            Me.GroupBox3.Controls.Add(Me.etSubTotalT)
            Me.GroupBox3.Controls.Add(Me.etIva)
            Me.GroupBox3.Controls.Add(Me.etIvaT)
            Me.GroupBox3.Controls.Add(Me.gbBotones)
            Me.GroupBox3.Controls.Add(Me.gbTipo)
            Me.GroupBox3.Controls.Add(Me.GroupBox1)
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
            Me.GroupBox3.Controls.Add(Me.dgCotizaciones)
            Me.GroupBox3.Location = New System.Drawing.Point(16, 37)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(992, 483)
            Me.GroupBox3.TabIndex = 130
            Me.GroupBox3.TabStop = False
            '
            'txtVendedor
            '
            Me.txtVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtVendedor.Location = New System.Drawing.Point(752, 112)
            Me.txtVendedor.MaxLength = 50
            Me.txtVendedor.Name = "txtVendedor"
            Me.txtVendedor.ReadOnly = True
            Me.txtVendedor.Size = New System.Drawing.Size(224, 20)
            Me.txtVendedor.TabIndex = 136
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(672, 112)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(72, 26)
            Me.Label10.TabIndex = 135
            Me.Label10.Text = "Vendedor:"
            '
            'etSubTotal
            '
            Me.etSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etSubTotal.Location = New System.Drawing.Point(296, 453)
            Me.etSubTotal.Name = "etSubTotal"
            Me.etSubTotal.Size = New System.Drawing.Size(112, 26)
            Me.etSubTotal.TabIndex = 134
            Me.etSubTotal.Text = "0.00"
            Me.etSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etSubTotalT
            '
            Me.etSubTotalT.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etSubTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etSubTotalT.Location = New System.Drawing.Point(192, 453)
            Me.etSubTotalT.Name = "etSubTotalT"
            Me.etSubTotalT.Size = New System.Drawing.Size(96, 26)
            Me.etSubTotalT.TabIndex = 133
            Me.etSubTotalT.Text = "Sub Total:"
            Me.etSubTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etIva
            '
            Me.etIva.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIva.ForeColor = System.Drawing.Color.Maroon
            Me.etIva.Location = New System.Drawing.Point(520, 453)
            Me.etIva.Name = "etIva"
            Me.etIva.Size = New System.Drawing.Size(112, 26)
            Me.etIva.TabIndex = 132
            Me.etIva.Text = "0.00"
            Me.etIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etIvaT
            '
            Me.etIvaT.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etIvaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIvaT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etIvaT.Location = New System.Drawing.Point(416, 453)
            Me.etIvaT.Name = "etIvaT"
            Me.etIvaT.Size = New System.Drawing.Size(96, 26)
            Me.etIvaT.TabIndex = 131
            Me.etIvaT.Text = "IVA:"
            Me.etIvaT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'gbBotones
            '
            Me.gbBotones.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.gbBotones.Controls.Add(Me.cmdConsultaClientes)
            Me.gbBotones.Controls.Add(Me.cmdConsulta)
            Me.gbBotones.Controls.Add(Me.cmdImprimir)
            Me.gbBotones.Controls.Add(Me.cmdAceptar)
            Me.gbBotones.Controls.Add(Me.cmdCancelar)
            Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBotones.ForeColor = System.Drawing.Color.Maroon
            Me.gbBotones.Location = New System.Drawing.Point(896, 141)
            Me.gbBotones.Name = "gbBotones"
            Me.gbBotones.Size = New System.Drawing.Size(88, 301)
            Me.gbBotones.TabIndex = 130
            Me.gbBotones.TabStop = False
            '
            'cmdConsultaClientes
            '
            Me.cmdConsultaClientes.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsultaClientes.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsultaClientes.Appearance.Options.UseFont = True
            Me.cmdConsultaClientes.Appearance.Options.UseForeColor = True
            Me.cmdConsultaClientes.Location = New System.Drawing.Point(8, 146)
            Me.cmdConsultaClientes.Name = "cmdConsultaClientes"
            Me.cmdConsultaClientes.Size = New System.Drawing.Size(72, 26)
            Me.cmdConsultaClientes.TabIndex = 33
            Me.cmdConsultaClientes.Text = "Clientes"
            '
            'cmdConsulta
            '
            Me.cmdConsulta.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsulta.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsulta.Appearance.Options.UseFont = True
            Me.cmdConsulta.Appearance.Options.UseForeColor = True
            Me.cmdConsulta.Location = New System.Drawing.Point(8, 103)
            Me.cmdConsulta.Name = "cmdConsulta"
            Me.cmdConsulta.Size = New System.Drawing.Size(72, 26)
            Me.cmdConsulta.TabIndex = 31
            Me.cmdConsulta.Text = "Consulta"
            '
            'cmdImprimir
            '
            Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdImprimir.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdImprimir.Appearance.Options.UseFont = True
            Me.cmdImprimir.Appearance.Options.UseForeColor = True
            Me.cmdImprimir.Location = New System.Drawing.Point(8, 60)
            Me.cmdImprimir.Name = "cmdImprimir"
            Me.cmdImprimir.Size = New System.Drawing.Size(72, 26)
            Me.cmdImprimir.TabIndex = 30
            Me.cmdImprimir.Text = "Imprimir"
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdAceptar.Appearance.Options.UseFont = True
            Me.cmdAceptar.Appearance.Options.UseForeColor = True
            Me.cmdAceptar.Location = New System.Drawing.Point(8, 17)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
            Me.cmdAceptar.TabIndex = 28
            Me.cmdAceptar.Text = "Aceptar"
            '
            'cmdCancelar
            '
            Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar.Appearance.Options.UseFont = True
            Me.cmdCancelar.Appearance.Options.UseForeColor = True
            Me.cmdCancelar.Location = New System.Drawing.Point(8, 259)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(72, 25)
            Me.cmdCancelar.TabIndex = 29
            Me.cmdCancelar.Text = "Salir"
            '
            'gbTipo
            '
            Me.gbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.gbTipo.Controls.Add(Me.rbAmbos)
            Me.gbTipo.Controls.Add(Me.rbServicios)
            Me.gbTipo.Controls.Add(Me.rbProductos)
            Me.gbTipo.Controls.Add(Me.TextBox6)
            Me.gbTipo.Controls.Add(Me.Label12)
            Me.gbTipo.Controls.Add(Me.Label17)
            Me.gbTipo.Controls.Add(Me.Label18)
            Me.gbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbTipo.ForeColor = System.Drawing.Color.Maroon
            Me.gbTipo.Location = New System.Drawing.Point(280, 95)
            Me.gbTipo.Name = "gbTipo"
            Me.gbTipo.Size = New System.Drawing.Size(256, 43)
            Me.gbTipo.TabIndex = 129
            Me.gbTipo.TabStop = False
            '
            'rbAmbos
            '
            Me.rbAmbos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbAmbos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbAmbos.Location = New System.Drawing.Point(184, 17)
            Me.rbAmbos.Name = "rbAmbos"
            Me.rbAmbos.Size = New System.Drawing.Size(64, 17)
            Me.rbAmbos.TabIndex = 126
            Me.rbAmbos.Text = "Ambos"
            '
            'rbServicios
            '
            Me.rbServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbServicios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbServicios.Location = New System.Drawing.Point(104, 17)
            Me.rbServicios.Name = "rbServicios"
            Me.rbServicios.Size = New System.Drawing.Size(80, 17)
            Me.rbServicios.TabIndex = 125
            Me.rbServicios.Text = "Servicios"
            '
            'rbProductos
            '
            Me.rbProductos.Checked = True
            Me.rbProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbProductos.Location = New System.Drawing.Point(16, 17)
            Me.rbProductos.Name = "rbProductos"
            Me.rbProductos.Size = New System.Drawing.Size(88, 17)
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
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox1.Controls.Add(Me.txtDescuentoServicio)
            Me.GroupBox1.Controls.Add(Me.txtDescuentoProducto)
            Me.GroupBox1.Controls.Add(Me.TextBox5)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.Label13)
            Me.GroupBox1.Controls.Add(Me.Label14)
            Me.GroupBox1.Controls.Add(Me.Label15)
            Me.GroupBox1.Controls.Add(Me.Label16)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox1.Location = New System.Drawing.Point(8, 95)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(256, 43)
            Me.GroupBox1.TabIndex = 128
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Tipo de Cliente"
            '
            'txtDescuentoServicio
            '
            Me.txtDescuentoServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDescuentoServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuentoServicio.Location = New System.Drawing.Point(192, 17)
            Me.txtDescuentoServicio.MaxLength = 50
            Me.txtDescuentoServicio.Name = "txtDescuentoServicio"
            Me.txtDescuentoServicio.ReadOnly = True
            Me.txtDescuentoServicio.Size = New System.Drawing.Size(32, 20)
            Me.txtDescuentoServicio.TabIndex = 126
            '
            'txtDescuentoProducto
            '
            Me.txtDescuentoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDescuentoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuentoProducto.Location = New System.Drawing.Point(80, 17)
            Me.txtDescuentoProducto.MaxLength = 50
            Me.txtDescuentoProducto.Name = "txtDescuentoProducto"
            Me.txtDescuentoProducto.ReadOnly = True
            Me.txtDescuentoProducto.Size = New System.Drawing.Size(32, 20)
            Me.txtDescuentoProducto.TabIndex = 125
            '
            'TextBox5
            '
            Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox5.Location = New System.Drawing.Point(832, 17)
            Me.TextBox5.MaxLength = 50
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.ReadOnly = True
            Me.TextBox5.Size = New System.Drawing.Size(136, 20)
            Me.TextBox5.TabIndex = 123
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(8, 17)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(72, 17)
            Me.Label8.TabIndex = 115
            Me.Label8.Text = "Productos:"
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label13.Location = New System.Drawing.Point(128, 17)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(64, 17)
            Me.Label13.TabIndex = 102
            Me.Label13.Text = "Servicios:"
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label14.Location = New System.Drawing.Point(752, 17)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(72, 26)
            Me.Label14.TabIndex = 103
            Me.Label14.Text = "Teléfono:"
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.Color.Maroon
            Me.Label15.Location = New System.Drawing.Point(632, 474)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(112, 26)
            Me.Label15.TabIndex = 110
            Me.Label15.Text = "0.00"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label16.Location = New System.Drawing.Point(536, 474)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(96, 26)
            Me.Label16.TabIndex = 109
            Me.Label16.Text = "Total:"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtMunicipio
            '
            Me.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMunicipio.Location = New System.Drawing.Point(752, 69)
            Me.txtMunicipio.MaxLength = 50
            Me.txtMunicipio.Name = "txtMunicipio"
            Me.txtMunicipio.ReadOnly = True
            Me.txtMunicipio.Size = New System.Drawing.Size(224, 20)
            Me.txtMunicipio.TabIndex = 127
            '
            'txtDepartamento
            '
            Me.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDepartamento.Location = New System.Drawing.Point(376, 69)
            Me.txtDepartamento.MaxLength = 50
            Me.txtDepartamento.Name = "txtDepartamento"
            Me.txtDepartamento.ReadOnly = True
            Me.txtDepartamento.Size = New System.Drawing.Size(280, 20)
            Me.txtDepartamento.TabIndex = 126
            '
            'txtPais
            '
            Me.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPais.Location = New System.Drawing.Point(48, 69)
            Me.txtPais.MaxLength = 50
            Me.txtPais.Name = "txtPais"
            Me.txtPais.ReadOnly = True
            Me.txtPais.Size = New System.Drawing.Size(216, 20)
            Me.txtPais.TabIndex = 125
            '
            'txtDireccion
            '
            Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(376, 17)
            Me.txtDireccion.MaxLength = 50
            Me.txtDireccion.Multiline = True
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.ReadOnly = True
            Me.txtDireccion.Size = New System.Drawing.Size(280, 43)
            Me.txtDireccion.TabIndex = 124
            '
            'txtTelefono
            '
            Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono.Location = New System.Drawing.Point(752, 17)
            Me.txtTelefono.MaxLength = 50
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.ReadOnly = True
            Me.txtTelefono.Size = New System.Drawing.Size(224, 20)
            Me.txtTelefono.TabIndex = 123
            '
            'txtRuc
            '
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
            Me.cbMunicipios.Location = New System.Drawing.Point(496, 310)
            Me.cbMunicipios.Name = "cbMunicipios"
            Me.cbMunicipios.Size = New System.Drawing.Size(224, 23)
            Me.cbMunicipios.TabIndex = 121
            Me.cbMunicipios.Visible = False
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(672, 69)
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
            Me.cbDepartamentos.Location = New System.Drawing.Point(448, 310)
            Me.cbDepartamentos.Name = "cbDepartamentos"
            Me.cbDepartamentos.Size = New System.Drawing.Size(224, 23)
            Me.cbDepartamentos.TabIndex = 119
            Me.cbDepartamentos.Visible = False
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(8, 69)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(40, 26)
            Me.Label6.TabIndex = 115
            Me.Label6.Text = "País:"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(280, 17)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(88, 26)
            Me.Label2.TabIndex = 101
            Me.Label2.Text = "Dirección:"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
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
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(280, 69)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(96, 26)
            Me.Label4.TabIndex = 102
            Me.Label4.Text = "Departamento:"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(672, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(72, 26)
            Me.Label3.TabIndex = 103
            Me.Label3.Text = "Teléfono:"
            '
            'etTotal
            '
            Me.etTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etTotal.Location = New System.Drawing.Point(728, 444)
            Me.etTotal.Name = "etTotal"
            Me.etTotal.Size = New System.Drawing.Size(128, 35)
            Me.etTotal.TabIndex = 110
            Me.etTotal.Text = "0.00"
            Me.etTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etTotalT
            '
            Me.etTotalT.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etTotalT.Location = New System.Drawing.Point(640, 453)
            Me.etTotalT.Name = "etTotalT"
            Me.etTotalT.Size = New System.Drawing.Size(80, 26)
            Me.etTotalT.TabIndex = 109
            Me.etTotalT.Text = "Total:"
            Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dgCotizaciones
            '
            Me.dgCotizaciones.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
            Me.dgCotizaciones.BackColor = System.Drawing.Color.Gainsboro
            Me.dgCotizaciones.BackgroundColor = System.Drawing.Color.DarkGray
            Me.dgCotizaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgCotizaciones.CaptionBackColor = System.Drawing.Color.DarkKhaki
            Me.dgCotizaciones.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgCotizaciones.CaptionForeColor = System.Drawing.Color.Black
            Me.dgCotizaciones.DataMember = ""
            Me.dgCotizaciones.FlatMode = True
            Me.dgCotizaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgCotizaciones.ForeColor = System.Drawing.Color.Black
            Me.dgCotizaciones.GridLineColor = System.Drawing.Color.Silver
            Me.dgCotizaciones.HeaderBackColor = System.Drawing.Color.Black
            Me.dgCotizaciones.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgCotizaciones.HeaderForeColor = System.Drawing.Color.White
            Me.dgCotizaciones.LinkColor = System.Drawing.Color.DarkSlateBlue
            Me.dgCotizaciones.Location = New System.Drawing.Point(8, 146)
            Me.dgCotizaciones.Name = "dgCotizaciones"
            Me.dgCotizaciones.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgCotizaciones.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgCotizaciones.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgCotizaciones.SelectionForeColor = System.Drawing.Color.White
            Me.dgCotizaciones.Size = New System.Drawing.Size(872, 296)
            Me.dgCotizaciones.TabIndex = 27
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(432, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 25)
            Me.Label1.TabIndex = 129
            Me.Label1.Text = "Fecha:"
            Me.Label1.Visible = False
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label24.Location = New System.Drawing.Point(16, 8)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(64, 25)
            Me.Label24.TabIndex = 127
            Me.Label24.Text = "Cliente:"
            '
            'cbCliente
            '
            Me.cbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbCliente.Location = New System.Drawing.Point(80, 8)
            Me.cbCliente.Name = "cbCliente"
            Me.cbCliente.Size = New System.Drawing.Size(320, 21)
            Me.cbCliente.TabIndex = 126
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(408, 8)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(96, 25)
            Me.Label7.TabIndex = 131
            Me.Label7.Text = "No. Cotización"
            '
            'txtFactura
            '
            Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Location = New System.Drawing.Point(768, 9)
            Me.txtFactura.MaxLength = 50
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.ReadOnly = True
            Me.txtFactura.Size = New System.Drawing.Size(136, 20)
            Me.txtFactura.TabIndex = 134
            '
            'etFactura
            '
            Me.etFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.etFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etFactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etFactura.Location = New System.Drawing.Point(664, 9)
            Me.etFactura.Name = "etFactura"
            Me.etFactura.Size = New System.Drawing.Size(96, 25)
            Me.etFactura.TabIndex = 133
            Me.etFactura.Text = "No. Factura"
            '
            'frmCotizacionVer
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1024, 526)
            Me.Controls.Add(Me.txtFactura)
            Me.Controls.Add(Me.etFactura)
            Me.Controls.Add(Me.txtCotizacion)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.cbCliente)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label1)
            Me.Name = "frmCotizacionVer"
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.gbBotones.ResumeLayout(False)
            Me.gbTipo.ResumeLayout(False)
            Me.gbTipo.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Dim r As New VB.SysContab.Rutinas()
        Dim Clientes As New VB.SysContab.ClientesDB()
        Dim Departamentos As New VB.SysContab.DepartamentosCDB()
        Dim Municipios As New VB.SysContab.MunicipiosDB()
        Dim Cotizaciones As New VB.SysContab.CotizacionesDB()
        Dim Articulos As New VB.SysContab.ArticulosDB()

        Dim ds As DataSet
        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet
        Dim i As Integer

        Dim WithEvents Articulo As DataGridComboBoxColumn
        Dim WithEvents ArticuloCodigo As DataGridComboBoxColumn
        Dim Cantidad As DataGridTextBoxColumn
        Dim WithEvents ItemTipo As DataGridComboBoxColumn

        Dim DetallesProducto As New VB.SysContab.ArticulosDetails()
        Dim DetallesCliente As New VB.SysContab.ClientesDetails()
        Dim DetallesVendedor As New VB.SysContab.VendedoresDetails()
        Dim Vendedor As New VB.SysContab.VendedoresDB()

        Dim ValorActualCantidad As Double
        Dim ValorActualPrecio As Double
        Dim ValorActualDescuento As Double

        Dim TipoDescuento As String ' A, B, C , P

        Dim Cliente As String

        Dim dsItems As DataSet

        Dim Config As New VB.SysContab.ConfiguracionDB()
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()

        Private Sub frmCotizacionVer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            r.FormularioColor(Me)
            'r.CambiarEstilo(Me)

            ConfigDetalles = Config.GetConfigDetails

            ds = Cotizaciones.CotizacionDetalle(RegistroCotizacion)

            cbCliente.DataSource = Clientes.GetList().Tables("Clientes")
            cbCliente.ValueMember = "Codigo"
            cbCliente.DisplayMember = "Nombre"

            r.ComboAutoComplete(Me.cbCliente)

            cbCliente.SelectedValue = ds.Tables("Cotizaciones").Rows(0).Item("Cliente_ID")

            'txtFecha.CtlText = CDate(ds.Tables("Cotizaciones").Rows(0).Item("Cot_Fecha")).ToShortDateString
            'txtFecha.Enabled = False

            txtCotizacion.Text = ds.Tables("Cotizaciones").Rows(0).Item("Cot_ID")
            txtCotizacion.ReadOnly = True

            TipoItem = "P"

            Indice = -1

            TipoDescuento = "P"

            dsItems = Articulos.ProductosGetAll("P")

            MakeDataSet()
            dgCotizaciones.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            If ds.Tables("Cotizaciones").Rows(0).Item("Cot_Estado") = "F" Then
                dgCotizaciones.ReadOnly = True
                cbCliente.Enabled = False
                cmdAceptar.Enabled = False
                cmdConsulta.Enabled = False
                txtFactura.Text = ds.Tables("Cotizaciones").Rows(0).Item("Factura_ID")
            Else
                etFactura.Visible = False
                txtFactura.Visible = False

                r.ComboAutoComplete(Articulo.ColumnComboBox)
                r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
            End If

            'TipoItem = "P"

            'Indice = -1

            'TipoDescuento = "P"

            'dsItems = Articulos.ProductosGetAll("P")

            'MakeDataSet()
            'dgCotizaciones.SetDataBinding(myDataSet, "Articulos")
            'AddCustomDataTableStyle()

            'If ds.Tables("Cotizaciones").Rows(0).Item("Cot_Estado") = "P" Then
            '    r.ComboAutoComplete(Articulo.ColumnComboBox)
            '    r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
            'End If

            Me.Text = "C o t i z a c i o n e s"
            Me.Refresh()

        End Sub

        Private Sub MakeDataSet()

            ' Create a DataSet.
            myDataSet = New DataSet("myDataSet")

            ' Create two DataTables.
            'Dim tCust As DataTable
            tCust = New DataTable("Articulos")

            ' Create two columns, and add them to the first table.

            Dim cArticuloCodigo As DataColumn
            cArticuloCodigo = New DataColumn("Codigo")

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

            Dim cExento As DataColumn
            cExento = New DataColumn("Exento")

            Dim cLinea As DataColumn
            cLinea = New DataColumn("Linea")

            tCust.Columns.Add(cArticuloCodigo)
            tCust.Columns.Add(cArticulo)
            tCust.Columns.Add(cCantidad)
            tCust.Columns.Add(cPrecio)
            tCust.Columns.Add(cDescuento)
            tCust.Columns.Add(cSubTotal)
            tCust.Columns.Add(cCodigoTemporal)
            tCust.Columns.Add(cItemTipo)
            tCust.Columns.Add(cExento)
            tCust.Columns.Add(cLinea)


            'tCust.Columns.Add(cCurrent2)
            ' Add the tables to the DataSet.
            myDataSet.Tables.Add(tCust)

            ' Populates the tables. For each customer and order, 
            'creates two DataRow variables. 
            Dim newRow1 As DataRow
            '''''''' Create three customers in the Customers Table.


            i = 0

            Do While (i < ds.Tables("Cotizaciones").Rows.Count)
                newRow1 = tCust.NewRow
                newRow1("Codigo") = ds.Tables("Cotizaciones").Rows(i).Item("Item_ID")
                ' Add the row to the Customers table.
                tCust.Rows.Add(newRow1)
                i = (i + 1)

            Loop

            Dim j As Integer

            Dim Iva As Double
            Iva = 0

            For j = 0 To ds.Tables("Cotizaciones").Rows.Count - 1
                'tCust.Rows(i)("Cantidad") = ds.Tables("Recibo_Cheques").Rows(i).Item("Banco")
                tCust.Rows(j)("CodigoTemporal") = ds.Tables("Cotizaciones").Rows(j).Item("Item_ID")
                tCust.Rows(j)("Articulo") = ds.Tables("Cotizaciones").Rows(j).Item("Nombre")
                tCust.Rows(j)("Cantidad") = ds.Tables("Cotizaciones").Rows(j).Item("Cot_Lin_Cantidad")
                tCust.Rows(j)("Precio") = CDbl(ds.Tables("Cotizaciones").Rows(j).Item("Item_Precio")).ToString(Round)
                tCust.Rows(j)("Descuento") = CDbl(ds.Tables("Cotizaciones").Rows(j).Item("Cot_Lin_Descuento")).ToString(Round)
                tCust.Rows(j)("Tipo") = ds.Tables("Cotizaciones").Rows(j).Item("Item_Tipo")
                tCust.Rows(j)("Linea") = ds.Tables("Cotizaciones").Rows(j).Item("Cot_Lin_Numero")

                Iva = Iva + CDbl(ds.Tables("Cotizaciones").Rows(j).Item("Item_Iva"))

                If CDbl(ds.Tables("Cotizaciones").Rows(j).Item("Item_Iva")) = 0 Then
                    tCust.Rows(j)("Exento") = True
                Else
                    tCust.Rows(j)("Exento") = False
                End If

            Next

            Me.etIva.Text = Iva.ToString(Round)

        End Sub

        Private Sub TextBoxLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsNumeric(Cantidad.TextBox.Text) Then
                Cantidad.TextBox.Text = ValorActualCantidad.ToString(Round)
            End If

            If dgCotizaciones.CurrentRowIndex >= tCust.Rows.Count Then
                Exit Sub
            End If

            If tCust.Rows(dgCotizaciones.CurrentRowIndex)("Codigo").ToString = "" Or tCust.Rows(dgCotizaciones.CurrentRowIndex)("Codigo") Is DBNull.Value Then
                Exit Sub
            End If

            If TipoItem = "S" Then
                Exit Sub
            ElseIf TipoItem = "A" Then
                If tCust.Rows(dgCotizaciones.CurrentRowIndex)("Tipo").ToString = "S" Then
                    Exit Sub
                End If
            End If

            DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(dgCotizaciones.CurrentRowIndex)("Codigo"), tCust.Rows(dgCotizaciones.CurrentRowIndex)("Tipo"), EmpresaActual)
            If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
                '
            ElseIf DetallesProducto.Existencia = 0 Then
                MsgBox("No hay existencias...", MsgBoxStyle.Critical)
                Cantidad.TextBox.Focus()
                Exit Sub
            ElseIf CDbl(Cantidad.TextBox.Text) > CDbl(DetallesProducto.Existencia) Then
                MsgBox("La cantidad es mayor que la existencia actual", MsgBoxStyle.Critical)
                Exit Sub
            End If

            'MsgBox(Cantidad.TextBox.Text)
        End Sub

        Dim Servicio As Boolean

        Private Sub Evento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            '''If e.KeyCode = Keys.Enter Then
            '''    SendKeys.Send("{Right}")
            '''    'Articulo.ColumnComboBox.Focus()
            '''    Exit Sub
            '''End If

            If rbAmbos.Checked = False Then
                Exit Sub
            End If

            If e.KeyCode = Keys.F9 Then

                If Servicio = True Then
                    Exit Sub
                End If

                Servicio = True

                dsItems = Articulos.ProductosGetAll("S")

                ArticuloCodigo.ColumnComboBox.Items.Clear()
                Articulo.ColumnComboBox.Items.Clear()
                ItemTipo.ColumnComboBox.Items.Clear()

                For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                    ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

                Next

                'For i = 0 To Articulos.ProductosGetAll("S").Tables("Articulos").Rows.Count - 1
                '    Articulo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("S").Tables("Articulos").Rows(i).Item("Nombre"))

                'Next

                'For i = 0 To Articulos.ProductosGetAll("S").Tables("Articulos").Rows.Count - 1
                '    ItemTipo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("S").Tables("Articulos").Rows(i).Item("Tipo"))

                'Next

            ElseIf e.KeyCode = Keys.F10 Then

                If Servicio = False Then
                    Exit Sub
                End If

                Servicio = False

                dsItems = Articulos.ProductosGetAll("P")

                ArticuloCodigo.ColumnComboBox.Items.Clear()
                Articulo.ColumnComboBox.Items.Clear()
                ItemTipo.ColumnComboBox.Items.Clear()

                For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                    ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

                Next

                'For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
                '    Articulo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Nombre"))

                'Next

                'For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
                '    ItemTipo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Tipo"))

                'Next

            End If

        End Sub

        Private Sub AddCustomDataTableStyle()

            'STEP 1: Create a DataTable style object and set properties if required.
            Dim ts1 As DataGridTableStyle
            ts1 = New DataGridTableStyle()
            'specify the table from dataset (required step)
            ts1.MappingName = "Articulos"
            ' Set other properties (optional step)
            ts1.AlternatingBackColor = Color.LightBlue
            Dim colCount As Integer
            colCount = 0

            If ds.Tables("Cotizaciones").Rows(0).Item("Cot_Estado") = "F" Then
                Dim ArticuloCodigo As DataGridTextBoxColumn
                ArticuloCodigo = New DataGridTextBoxColumn()
                ArticuloCodigo.MappingName = "Codigo"
                ArticuloCodigo.HeaderText = "Código"
                ArticuloCodigo.Width = 100
                ArticuloCodigo.Alignment = HorizontalAlignment.Left
                ArticuloCodigo.ReadOnly = True
                ArticuloCodigo.Format = "##,###0.00"
                ts1.GridColumnStyles.Add(ArticuloCodigo)
                'colCount = (colCount + 1)

                ArticuloCodigo.NullText = "0.00"

                ts1.PreferredRowHeight = (ArticuloCodigo.TextBox.Height + 3)

            Else
                'Dim Articulo As DataGridComboBoxColumn
                ArticuloCodigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
                ArticuloCodigo.MappingName = "Codigo"
                ArticuloCodigo.HeaderText = "Código"
                ArticuloCodigo.Width = 100

                'ArticuloCodigo.ColumnComboBox.Enabled = False

                AddHandler ArticuloCodigo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress

                ts1.GridColumnStyles.Add(ArticuloCodigo)
                ts1.PreferredRowHeight = (ArticuloCodigo.ColumnComboBox.Height + 3)

                ArticuloCodigo.NullText = ""

                'articulo.ColumnComboBox.SelectAl

                '10/10/2005
                'If rbProductos.Checked = True Then
                '    For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
                '        ArticuloCodigo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Codigo"))

                '    Next
                'ElseIf rbServicios.Checked = True Then
                '    For i = 0 To Articulos.ProductosGetAll("S").Tables("Articulos").Rows.Count - 1
                '        ArticuloCodigo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("S").Tables("Articulos").Rows(i).Item("Codigo"))

                '    Next
                'Else
                '    For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
                '        ArticuloCodigo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Codigo"))

                '    Next

                'End If

                'ArticuloCodigo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown

                'ArticuloCodigo.ColumnComboBox.SelectedValue = -1

            End If

            colCount = (colCount + 1)

            If ds.Tables("Cotizaciones").Rows(0).Item("Cot_Estado") = "F" Then
                Dim Articulo As DataGridTextBoxColumn
                Articulo = New DataGridTextBoxColumn()
                Articulo.MappingName = "Articulo"
                Articulo.HeaderText = "Descripcion"
                Articulo.Width = 300
                Articulo.Alignment = HorizontalAlignment.Left
                Articulo.ReadOnly = True
                Articulo.Format = "##,###0.00"
                ts1.GridColumnStyles.Add(Articulo)
                'colCount = (colCount + 1)

                Articulo.NullText = "0.00"

            Else
                'Dim Articulo As DataGridComboBoxColumn
                Articulo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
                Articulo.MappingName = "Articulo"
                Articulo.HeaderText = "Descripción"
                Articulo.Width = 300

                AddHandler Articulo.ColumnComboBox.KeyDown, AddressOf Evento_KeyPress

                ts1.GridColumnStyles.Add(Articulo)
                ts1.PreferredRowHeight = (Articulo.ColumnComboBox.Height + 3)

                Articulo.NullText = ""


                'If rbProductos.Checked = True Then
                '    For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
                '        Articulo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Nombre"))

                '    Next
                'ElseIf rbServicios.Checked = True Then
                '    For i = 0 To Articulos.ProductosGetAll("S").Tables("Articulos").Rows.Count - 1
                '        Articulo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("S").Tables("Articulos").Rows(i).Item("Nombre"))

                '    Next
                'Else
                '    For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
                '        Articulo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Nombre"))

                '    Next

                'End If

                'Articulo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown

                'Articulo.ColumnComboBox.SelectedValue = -1

            End If


            colCount = (colCount + 1)

            Cantidad = New DataGridTextBoxColumn()
            Cantidad.MappingName = "Cantidad"
            'from dataset table
            Cantidad.HeaderText = "Cantidad"
            Cantidad.Width = 100
            Cantidad.Alignment = HorizontalAlignment.Right
            Cantidad.ReadOnly = False

            AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxLeaveHandler)

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

            Precio.NullText = "0.00"

            Dim Descuento As DataGridTextBoxColumn
            Descuento = New DataGridTextBoxColumn()
            Descuento.MappingName = "Descuento"
            Descuento.HeaderText = "Descuento %"
            Descuento.Width = 100
            Descuento.Alignment = HorizontalAlignment.Right
            Descuento.ReadOnly = False
            Descuento.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(Descuento)
            colCount = (colCount + 1)

            Descuento.NullText = "0.00"

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

            SubTotal.NullText = "0.00"

            Dim CodigoTemporal As DataGridTextBoxColumn
            CodigoTemporal = New DataGridTextBoxColumn()
            CodigoTemporal.MappingName = "CodigoTemporal"
            CodigoTemporal.HeaderText = "CodigoTemporal"
            CodigoTemporal.Width = 0
            CodigoTemporal.Alignment = HorizontalAlignment.Left
            CodigoTemporal.ReadOnly = True
            'CodigoTemporal.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(CodigoTemporal)
            colCount = (colCount + 1)

            CodigoTemporal.NullText = ""


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''Tipo = P: Producto S: Servicio'''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            If ds.Tables("Cotizaciones").Rows(0).Item("Cot_Estado") = "F" Then
                Dim ItemTipo As DataGridTextBoxColumn
                ItemTipo = New DataGridTextBoxColumn()
                ItemTipo.MappingName = "Tipo"
                ItemTipo.HeaderText = "Tipo"
                ItemTipo.Width = 0
                ItemTipo.ReadOnly = True

                ts1.GridColumnStyles.Add(ItemTipo)
                colCount = (colCount + 1)

                ItemTipo.NullText = ""

            Else
                ItemTipo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))
                ItemTipo.MappingName = "Tipo"
                ItemTipo.HeaderText = "Tipo"
                ItemTipo.Width = 0
                ItemTipo.ReadOnly = True

                ts1.GridColumnStyles.Add(ItemTipo)
                ts1.PreferredRowHeight = (ItemTipo.ColumnComboBox.Height + 3)

                ItemTipo.NullText = ""

                If rbProductos.Checked = True Then
                    For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                        ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))
                    Next
                    'ElseIf rbServicios.Checked = True Then
                    '    For i = 0 To Articulos.ProductosGetAll("S").Tables("Articulos").Rows.Count - 1
                    '        ItemTipo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("S").Tables("Articulos").Rows(i).Item("Tipo"))

                    '    Next
                    'Else
                    '    For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
                    '        ItemTipo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Tipo"))

                    '    Next

                End If

                ArticuloCodigo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
                ArticuloCodigo.ColumnComboBox.SelectedValue = -1

                Articulo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
                Articulo.ColumnComboBox.SelectedValue = -1

                ItemTipo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
                ItemTipo.ColumnComboBox.SelectedValue = -1

                colCount = (colCount + 1)

            End If

            Dim Exento As DataGridTextBoxColumn
            Exento = New DataGridTextBoxColumn()
            Exento.MappingName = "Exento"
            Exento.HeaderText = ""
            Exento.Width = 0
            Exento.Alignment = HorizontalAlignment.Right
            Exento.ReadOnly = True
            Exento.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(Exento)
            colCount = (colCount + 1)

            Exento.NullText = "0.00"

            Dim Linea As DataGridTextBoxColumn
            Linea = New DataGridTextBoxColumn
            Linea.MappingName = "Linea"
            Linea.HeaderText = "Linea"
            Linea.Width = 0
            Linea.Alignment = HorizontalAlignment.Left
            Linea.ReadOnly = True
            'CodigoTemporal.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(Linea)
            colCount = (colCount + 1)

            Linea.NullText = ""

            ts1.AllowSorting = False
            ts1.GridLineColor = Color.FromArgb(70, 130, 180)
            ts1.HeaderFont = Me.dgCotizaciones.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue
            ts1.PreferredRowHeight = 25

            dgCotizaciones.CaptionVisible = False

            dgCotizaciones.TableStyles.Clear()
            dgCotizaciones.TableStyles.Add(ts1)

        End Sub

        Public Sub MyComboValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
            Console.WriteLine("index changed {0} {1}", rowChanging, newValue)


            Try
                If Indice >= 0 Then
                    DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString, ItemTipo.ColumnComboBox.Items.Item(Indice).ToString, EmpresaActual)

                    If tCust.Rows.Count < rowChanging + 1 Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        'newRow1("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
                        newRow1("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        ' Add the row to the Customers table.
                        tCust.Rows.Add(newRow1)

                        tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Exento") = DetallesProducto.Exento

                        'tCust.Rows(rowChanging)("Codigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
                        tCust.Rows(rowChanging)("Codigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Cantidad") = 1
                        tCust.Rows(rowChanging)("Precio") = CDbl(DetallesProducto.Precio_Venta_Cordobas).ToString(Round)

                        If TipoDescuento = "A" Then
                            tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
                        ElseIf TipoDescuento = "B" Then
                            tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
                        ElseIf TipoDescuento = "C" Then
                            tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
                        Else
                            tCust.Rows(rowChanging)("Descuento") = "0.00"

                        End If

                        'tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
                    Else
                        'tCust.Rows(rowChanging)("Codigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
                        tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Exento") = DetallesProducto.Exento
                        tCust.Rows(rowChanging)("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Codigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        'tCust.Rows(rowChanging)("Cantidad") = 1
                        tCust.Rows(rowChanging)("Precio") = CDbl(DetallesProducto.Precio_Venta_Cordobas).ToString(Round)

                        If TipoDescuento = "A" Then
                            tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
                        ElseIf TipoDescuento = "B" Then
                            tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
                        ElseIf TipoDescuento = "C" Then
                            tCust.Rows(rowChanging)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
                        Else
                            tCust.Rows(rowChanging)("Descuento") = "0.00"

                        End If

                        'tCust.Rows(rowChanging)("Tipo") = ItemTipo.ColumnComboBox.Items.Item(Indice)
                    End If
                    If tCust.Rows(rowChanging)("Tipo") = "P" Then
                        DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(rowChanging)("Codigo"), tCust.Rows(rowChanging)("Tipo"), EmpresaActual)
                        If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
                            '
                        ElseIf DetallesProducto.Existencia = 0 Then
                            MsgBox("No hay existencias...", MsgBoxStyle.Critical)
                            Exit Sub
                        ElseIf CDbl(tCust.Rows(rowChanging)("Cantidad")) > CDbl(DetallesProducto.Existencia) Then
                            MsgBox("La cantidad es mayor que la existencia actual.", MsgBoxStyle.Critical)
                            Exit Sub
                        End If

                    Else
                        '

                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message & "MyComboValueChanged")
            End Try

        End Sub

        Private Sub tCust_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tCust.ColumnChanged

            Dim Descuento As Double


            If Not IsNumeric(e.Row.Item(2)) Then
                e.Row.Item(2) = ValorActualCantidad
                'Else
                '    If CDbl(e.Row.Item(2)) <= 0 Then
                '        e.Row.Item(2) = ValorActualCantidad
                '    End If
            End If

            If Not IsNumeric(e.Row.Item(3)) Then
                e.Row.Item(3) = ValorActualPrecio.ToString(Round)
            End If

            If Not IsNumeric(e.Row.Item(4)) Then
                e.Row.Item(4) = ValorActualDescuento.ToString(Round)
            End If

            If e.Column.Ordinal = 2 Or e.Column.Ordinal = 3 Or e.Column.Ordinal = 4 Then
                If e.Row.Item(2) Is DBNull.Value Or e.Row.Item(3) Is DBNull.Value Then

                Else
                    If e.Row.Item(4) Is DBNull.Value Then
                        If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) Then
                            e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))).ToString(Round)
                        End If

                    Else
                        If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) And IsNumeric(e.Row.Item(4)) Then
                            Descuento = (CDbl(e.Row.Item(4)) * CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))) / 100.0
                            e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3)) - Descuento).ToString(Round)
                        End If


                    End If

                End If

            End If

            Dim TotalIva As Double

            SubTotalFacturaCliente = 0
            SubTotalFacturaNoDescuentos = 0
            TotalFacturaCliente = 0
            TotalDescuento = 0

            TotalIva = 0

            For i = 0 To tCust.Rows.Count - 1

                If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Or tCust.Rows(i)("Exento") Is DBNull.Value Or tCust.Rows(i)("Tipo") Is DBNull.Value Then

                ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                    Try
                        SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
                        SubTotalFacturaNoDescuentos = SubTotalFacturaNoDescuentos + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
                        TotalDescuento = TotalDescuento + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)

                        If DetallesCliente.Excento = True Then
                            TotalIva = 0
                        Else
                            If tCust.Rows(i)("Exento") = False Then
                                TotalIva = TotalIva + (tCust.Rows(i)("SubTotal") * (ConfigDetalles.IVA / 100.0))
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)

                    End Try

                End If

            Next

            'etSubTotal.Text = SubTotalFacturaNoDescuentos.ToString(Round)
            'etIva.Text = (SubTotalFacturaNoDescuentos * 0.15).ToString(Round)
            'etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)
            'TotalFactura = etTotal.Text

            etSubTotal.Text = SubTotalFacturaCliente.ToString(Round)
            etIva.Text = TotalIva.ToString(Round)
            etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)
            TotalFactura = etTotal.Text

        End Sub

        Private Sub cbCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCliente.SelectedIndexChanged

            If Not IsNumeric(cbCliente.SelectedValue) Then
                Exit Sub

            End If

            If cbCliente.SelectedValue = 0 Or Trim(cbCliente.Text) = "" Then
                txtRuc.Text = ""
                txtDireccion.Text = ""
                txtTelefono.Text = ""
                txtDepartamento.Text = ""
                txtMunicipio.Text = ""
                txtDescuentoProducto.Text = ""
                txtDescuentoServicio.Text = ""
                txtVendedor.Text = ""
                'CodigoVendedor = ""
                Exit Sub
            End If

            DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbCliente.SelectedValue)

            cbDepartamentos.DataSource = Departamentos.GetList().Tables("DepartamentosC")
            cbDepartamentos.ValueMember = "Codigo"
            cbDepartamentos.DisplayMember = "Nombre"

            cbDepartamentos.SelectedValue = DetallesCliente.Departamento

            cbMunicipios.DataSource = Municipios.GetList(cbDepartamentos.SelectedValue).Tables("Municipios")
            cbMunicipios.ValueMember = "Codigo"
            cbMunicipios.DisplayMember = "Nombre"

            cbMunicipios.SelectedValue = DetallesCliente.Municipio

            txtRuc.Text = DetallesCliente.Ruc
            txtDireccion.Text = DetallesCliente.Direccion
            txtTelefono.Text = DetallesCliente.Telefono

            If DetallesCliente.Departamento = "0" Then
                txtDepartamento.Text = ""
                txtMunicipio.Text = ""
            Else
                txtDepartamento.Text = cbDepartamentos.Text
                txtMunicipio.Text = cbMunicipios.Text
            End If

            txtDescuentoProducto.Text = DetallesCliente.Desc_Prod
            txtDescuentoServicio.Text = DetallesCliente.Desc_Serv

            TipoDescuento = DetallesCliente.Desc_Prod

            DetallesVendedor = Vendedor.GetDetails(DetallesCliente.Vendedor)
            txtVendedor.Text = DetallesVendedor.Nombre

            'codigovendedor

        End Sub

        Private Sub cbCliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCliente.Leave

            If Trim(cbCliente.Text) = "" Then
                txtRuc.Text = ""
                txtDireccion.Text = ""
                txtTelefono.Text = ""
                txtDepartamento.Text = ""
                txtMunicipio.Text = ""
                txtDescuentoProducto.Text = ""
                txtDescuentoServicio.Text = ""
                txtVendedor.Text = ""
                'CodigoVendedor = ""
                Cliente = ""
                Exit Sub
            End If

            If Clientes.ClientesBuscar(Trim(cbCliente.Text)).Tables("Clientes").Rows.Count = 0 Then
                cbCliente.Text = cbCliente.Text.ToUpper

                txtRuc.Text = ""
                txtDireccion.Text = ""
                txtTelefono.Text = ""
                txtDepartamento.Text = ""
                txtMunicipio.Text = ""
                txtDescuentoProducto.Text = ""
                txtDescuentoServicio.Text = ""
                txtVendedor.Text = ""
                'CodigoVendedor = ""
                Cliente = ""

                If (MsgBox("Cliente no existe. Desea agregarlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)) = MsgBoxResult.No Then
                    'Exit Sub
                Else
                    Dim f As New frmAgregarClienteQuick()
                    f.WindowState = FormWindowState.Normal
                    f.StartPosition = FormStartPosition.CenterScreen
                    NombreCliente = cbCliente.Text.ToUpper
                    'cbCliente.Text = cbCliente.Text.ToUpper

                    f.ShowDialog()

                End If

                Cliente = ""
                Cod_Cliente = "9999" 'Clientes Varios
                'cbCliente.Focus()
                Exit Sub

            End If


            cbCliente.Refresh()
            Cod_Cliente = Clientes.ClientesBuscar(Trim(cbCliente.Text)).Tables("Clientes").Rows(0).Item("Codigo")

            cbCliente.SelectedValue = Cod_Cliente

            Cliente = ""

        End Sub

        Private Sub rbProductos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbProductos.Click
            dsItems = Articulos.ProductosGetAll("P")

            ArticuloCodigo.ColumnComboBox.Items.Clear()
            Articulo.ColumnComboBox.Items.Clear()
            ItemTipo.ColumnComboBox.Items.Clear()

            For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

            Next

            TipoItem = "P"


        End Sub

        Private Sub rbServicios_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbServicios.Click
            dsItems = Articulos.ProductosGetAll("S")

            ArticuloCodigo.ColumnComboBox.Items.Clear()
            Articulo.ColumnComboBox.Items.Clear()
            ItemTipo.ColumnComboBox.Items.Clear()

            For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

            Next

            TipoItem = "S"

        End Sub

        Private Sub rbAmbos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbAmbos.Click

            dsItems = Articulos.ProductosGetAll("P")

            ArticuloCodigo.ColumnComboBox.Items.Clear()
            Articulo.ColumnComboBox.Items.Clear()
            ItemTipo.ColumnComboBox.Items.Clear()

            For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))
            Next

            TipoItem = "A"

            'ArticuloCodigo.ColumnComboBox.Items.Clear()
            'Articulo.ColumnComboBox.Items.Clear()
            'ItemTipo.ColumnComboBox.Items.Clear()

            'For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
            '    ArticuloCodigo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Codigo"))

            'Next

            'For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
            '    Articulo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Nombre"))

            'Next

            'For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
            '    ItemTipo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Tipo"))

            'Next



        End Sub

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
            'MsgBox(Cod_Cliente)
            'Exit Sub
            If tCust.Rows.Count > 0 Then
                If tCust.Rows(tCust.Rows.Count - 1)("Codigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Precio") Is DBNull.Value Then
                    tCust.Rows(tCust.Rows.Count - 1).Delete()
                End If
            End If

            'Guardar los datos de la Factura
            If Guardar() = False Then
                Exit Sub
            End If

            '15/11/2005
            'txtCotizacion.Text = Clientes.CotizacionNumero
            'etSubTotal.Text = "0.00"
            'etIva.Text = "0.00"
            'etTotal.Text = "0.00"

            '15/11/2005
            ''MakeDataSet()
            ''dgCotizaciones.SetDataBinding(myDataSet, "Articulos")
            ''AddCustomDataTableStyle()

        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

        Private Sub cmdImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
            ImprimirCotizacion()
        End Sub

        Private Sub ImprimirCotizacion()
            'If MsgBox("¿Desea imprimir la Factura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'Contab Real
            Dim Cadena As String
            Dim Temp As Boolean = False
            Dim Data() As Byte
            Try
                'Dim Datas() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
                Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 4").Rows(0).Item(0), Byte())
                Temp = True
                Dim Tamano As Integer
                Tamano = Data.GetUpperBound(0)
                Cadena = Application.StartupPath & "\RptCotizacion.repx"
                If File.Exists(Cadena) Then Kill(Cadena)
                Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
                Archivo.Write(Data, 0, Tamano)
                Archivo.Close()
            Catch ex As Exception
                Temp = False
                'Exit Sub
            End Try
            'Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
            Dim Rep As XtraReport
            If Temp = True Then
                Rep = XtraReport.FromFile(Application.StartupPath & "\RptCotizacion.repx", True)
            Else
                Rep = New RptFacturaNew
            End If
            'Rep.DataSource = ObtieneDatos("SPGetRptFactura " & EmpresaActual & ",'" & txtfactura.Text & "'")
            'Rep.ShowRibbonPreview()

            Rep.DataSource = ObtieneDatos("SPGetRptCotizacion " & EmpresaActual & ",'" & txtCotizacion.Text & "'")

            Rep.ShowPrintMarginsWarning = False
            Rep.BringToFront()
            Rep.ShowRibbonPreview()
            'Rep.Print()
        End Sub

        'Funcion para guradar los datos de la factura
        Private Function Guardar() As Boolean
            If Trim(cbCliente.Text) = "" Then
                MsgBox("Seleccione el Cliente", MsgBoxStyle.Critical)
                cbCliente.Focus()
                Return False
                Exit Function
            End If

            If Trim(txtCotizacion.Text) = "" Then
                MsgBox("Introduzca el No. de Factura", MsgBoxStyle.Critical)
                txtCotizacion.Focus()
                Return False
                Exit Function
            End If

            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione al menos un Producto o Servicio", MsgBoxStyle.Critical)
                dgCotizaciones.Focus()
                Articulo.ColumnComboBox.Focus()
                Return False
                Exit Function
            End If

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Articulo").ToString = "" Or tCust.Rows(i)("Articulo") Is DBNull.Value Or tCust.Rows(i)("Codigo").ToString = "" Or tCust.Rows(i)("Codigo") Is DBNull.Value Then
                    MsgBox("Elija el Producto o Servicio", MsgBoxStyle.Critical)
                    dgCotizaciones.Select(i)
                    Return False
                    Exit Function
                End If

                'MsgBox("Codigo: " & tCust.Rows(i)("CodigoTemporal"))
            Next

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Articulo").ToString = "" Or tCust.Rows(i)("Articulo") Is DBNull.Value Or tCust.Rows(i)("Codigo").ToString = "" Or tCust.Rows(i)("Codigo") Is DBNull.Value Then
                    If tCust.Rows(i)("Tipo") = "P" Then
                        MsgBox("Elija el Producto", MsgBoxStyle.Critical)
                    ElseIf tCust.Rows(i)("Tipo") = "S" Then
                        MsgBox("Elija el Servicio", MsgBoxStyle.Critical)
                    Else
                        MsgBox("Elija el Producto o Servicio", MsgBoxStyle.Critical)
                    End If

                    dgCotizaciones.Select(i)
                    Return False
                    Exit Function
                End If

                If tCust.Rows(i)("Tipo") = "P" Then
                    DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(i)("Codigo"), tCust.Rows(i)("Tipo"), EmpresaActual)
                    If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
                        '
                    ElseIf DetallesProducto.Existencia = 0 Then
                        MsgBox("No hay existencias Para el Producto: " & tCust.Rows(i)("Codigo") & " - " & tCust.Rows(i)("Articulo"), MsgBoxStyle.Critical)
                        dgCotizaciones.Select(i)
                        Exit Function
                    ElseIf CDbl(tCust.Rows(i)("Cantidad")) > CDbl(DetallesProducto.Existencia) Then
                        MsgBox("La cantidad del producto: " & tCust.Rows(i)("Codigo") & " - " & tCust.Rows(i)("Articulo") & " es mayor que la existencia actual.", MsgBoxStyle.Critical)
                        dgCotizaciones.Select(i)
                        Exit Function
                    End If

                End If

                'MsgBox("Codigo: " & tCust.Rows(i)("CodigoTemporal"))
            Next


            'If MsgBox("Desea guardar los datos?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            '    Return False
            '    Exit Function
            'End If

            ''Transacciones''

            Dim conexion As New VB.SysContab.Rutinas

            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            'txtCotizacion.Text = Clientes.CotizacionNumero

            ''Else
            ''    'txtFactura.Text = "00001"
            ''End If

            'MsgBox(txtFactura.Text)

            Dim Tipo As String
            If rbProductos.Checked = True Then
                Tipo = 0
            ElseIf rbServicios.Checked = True Then
                Tipo = 1
            Else
                Tipo = 2
            End If

            Try
                'Clientes.AddCotizacion(txtCotizacion.Text, "Esta es una prueba", Cod_Cliente, etSubTotal.Text, _
                '                       TotalDescuento, etIva.Text, etTotal.Text, DetallesCliente.Vendedor)
                Cotizaciones.UpdateCotizacion(txtCotizacion.Text, "Esta es una prueba", Cod_Cliente, etSubTotal.Text, _
                                              TotalDescuento, etIva.Text, etTotal.Text, DetallesCliente.Vendedor)


                Cotizaciones.DeleteCotizacionDetalle(txtCotizacion.Text)

                Dim Iva As Double
                Dim Descuento As Double
                Dim Comision As Double
                Dim Comisiones As New VB.SysContab.ComisionDB
                For i = 0 To tCust.Rows.Count - 1

                    If tCust.Rows(i)("Descuento") Is DBNull.Value Then
                        Descuento = 0
                    Else
                        Descuento = tCust.Rows(i)("Descuento")
                    End If

                    If Comisiones.GetComisionItemVendedor(DetallesCliente.Vendedor, tCust.Rows(i)("CodigoTemporal"), "P").Tables("Comisiones").Rows.Count <> 0 Then
                        Comision = Comisiones.GetComisionItemVendedor(DetallesCliente.Vendedor, tCust.Rows(i)("CodigoTemporal"), "P").Tables("Comisiones").Rows(0).Item("Comision")
                    Else
                        Comision = 0
                    End If

                    'Agrear las lineas de la Factura

                    If DetallesCliente.Excento = True Then
                        Iva = 0
                    Else
                        If tCust.Rows(i)("Exento") = True Then
                            Iva = 0
                        Else
                            Iva = ConfigDetalles.IVA
                        End If
                    End If

                    Clientes.AddCotizacionLineas(txtCotizacion.Text, tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Cantidad"), tCust.Rows(i)("Precio"), Descuento, CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")), Comision, tCust.Rows(i)("Tipo"), (CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")) - ((CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")) * (Descuento / 100.0)))) * Iva / 100.0)

                    'Actualizar la Existencia del Item
                    ''''Articulos.RestarExistencias(tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Cantidad"))
                Next

            Catch ex As Exception
                MsgBox(ex.Message)
                VB.SysContab.Rutinas.ErrorTransaccion()
                ''''transaccionFacturasLineas.Rollback()
                ''''DBConnFacturasLineas.Close()

                ''''transaccionExistencia.Rollback()
                ''''DBConnExistencia.Close()

                Return False

                Exit Function

            End Try
            VB.SysContab.Rutinas.okTransaccion()
            ''''transaccionFacturasLineas.Commit()
            ''''DBConnFacturasLineas.Close()

            ''''transaccionExistencia.Commit()
            ''''DBConnExistencia.Close()

            'MsgBox("Los datos se guardaron correctamente", MsgBoxStyle.Information)

            'cbCliente.SelectedValue = 0
            'txtFactura.Text = Format(CInt(txtFactura.Text) + 1, "00000")
            'txtCotizacion.Text = Clientes.CotizacionNumero

            'etSubTotal.Text = "0.00"
            'etIva.Text = "0.00"
            'etTotal.Text = "0.00"

            ''''''''''TotalCheques = 0
            ''''''''''TotalTarjetas = 0
            ''''''''''TotalEfectivo = 0
            ''''''''''TotalFactura = 0

            ''''''''''TotalGlobal = 0

            ''''''''''etTotalPagado.Text = "0.00"

            ''''''''''MakeDataSet()
            ''''''''''dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            ''''''''''AddCustomDataTableStyle()
            Return True

        End Function

        Private Sub dgCotizaciones_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCotizaciones.CurrentCellChanged
            '21/11/2005
            'Try
            '    ValorActualCantidad = tCust.Rows(dgCotizaciones.CurrentRowIndex)("Cantidad")
            '    ValorActualPrecio = tCust.Rows(dgCotizaciones.CurrentRowIndex)("Precio")
            '    ValorActualDescuento = tCust.Rows(dgCotizaciones.CurrentRowIndex)("Descuento")

            '    If Servicio = False Or rbAmbos.Checked = False Then
            '        Exit Sub
            '    End If

            '    ArticuloCodigo.ColumnComboBox.Items.Clear()
            '    Articulo.ColumnComboBox.Items.Clear()
            '    ItemTipo.ColumnComboBox.Items.Clear()

            '    For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
            '        ArticuloCodigo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Codigo"))

            '    Next

            '    For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
            '        Articulo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Nombre"))
            '        'ArticuloCodigo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll.Tables("Articulos").Rows(i).Item("Codigo_Articulo"))

            '    Next

            '    For i = 0 To Articulos.ProductosGetAll("P").Tables("Articulos").Rows.Count - 1
            '        ItemTipo.ColumnComboBox.Items.Add(Articulos.ProductosGetAll("P").Tables("Articulos").Rows(i).Item("Tipo"))

            '    Next

            '    Servicio = False

            'Catch
            '    Exit Sub
            'End Try

            Try

                ValorActualCantidad = tCust.Rows(dgCotizaciones.CurrentRowIndex)("Cantidad")
                ValorActualPrecio = tCust.Rows(dgCotizaciones.CurrentRowIndex)("Precio")
                ValorActualDescuento = tCust.Rows(dgCotizaciones.CurrentRowIndex)("Descuento")

                If Servicio = False Or rbAmbos.Checked = False Then
                    Exit Sub
                End If

                Dim dsItems As DataSet
                dsItems = Articulos.ProductosGetAll("P")

                ArticuloCodigo.ColumnComboBox.Items.Clear()
                Articulo.ColumnComboBox.Items.Clear()
                ItemTipo.ColumnComboBox.Items.Clear()

                For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
                    ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
                    Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
                    ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

                Next

                Servicio = False

            Catch ex As Exception
                Exit Sub
            End Try
        End Sub

        Private Sub tCust_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles tCust.RowDeleted
            SubTotalFacturaCliente = 0
            SubTotalFacturaNoDescuentos = 0
            TotalFacturaCliente = 0
            TotalDescuento = 0

            Dim TotalIva As Double
            TotalIva = 0

            For i = 0 To tCust.Rows.Count - 1
                'If e.Row.Item(5) Is DBNull.Value Or e.Row.Item(5).ToString = "" Or e.Row.Item(5).ToString = "0.00" Then

                'ElseIf IsNumeric(e.Row.Item(5)) And e.Row.Item(5).ToString <> "" Then
                '    Try 'MsgBox(tCust.Rows(i)("SubTotal").ToString)
                '        SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
                '    Catch
                '        'e.Row.Delete()
                '    End Try

                'End If

                If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

                ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
                    Try 'MsgBox(tCust.Rows(i)("SubTotal").ToString)
                        SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
                        SubTotalFacturaNoDescuentos = SubTotalFacturaNoDescuentos + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
                        TotalDescuento = TotalDescuento + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)

                        If DetallesCliente.Excento = True Then
                            TotalIva = 0
                        Else
                            If tCust.Rows(i)("Exento") = False Then
                                TotalIva = TotalIva + (tCust.Rows(i)("SubTotal") * (ConfigDetalles.IVA / 100.0))
                            End If
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'e.Row.Delete()
                    End Try

                End If

            Next

            etSubTotal.Text = SubTotalFacturaCliente.ToString(Round)
            etIva.Text = TotalIva.ToString(Round)
            etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)
            TotalFactura = etTotal.Text

        End Sub

        Private Sub frmCotizaciones_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            'If MsgBox("Desea salir de Cotizaciones?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            '    e.Cancel = True
            '    Exit Sub
            'End If
            Dim Estado As String
            Try
                Dim f As frmListaCotizaciones = frmListaCotizaciones.Instance()
                f.Cargar()

                'If f.rbPendientes.Checked = True Then
                '    Estado = "P"
                'ElseIf f.rbFacturadas.Checked = True Then
                '    Estado = "F"
                'Else
                '    Estado = "T"
                'End If

                'f.dgCotizaciones.DataSource = Cotizaciones.CotizacionesBuscar("", Estado).Tables("Cotizaciones").DefaultView
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
            End Try

            'Clientes.DeleteReciboCheques("00000")
            'Clientes.DeleteReciboTarjetas("00000")
        End Sub

        Private Sub frmCotizaciones_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

            'Try
            'If NuevaFactura = "SI" Then
            AgregarItem()
            'End If

            'Catch

            'End Try
            'MsgBox("xxx")

        End Sub

        Private Sub dgCotizaciones_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCotizaciones.MouseEnter

            'Try
            'If NuevaFactura = "SI" Then
            AgregarItem()
            'End If
            'Catch
            '    Exit Sub
            'End Try

        End Sub

        Private Sub txtDireccion_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseEnter

            'Try
            'If NuevaFactura = "SI" Then
            AgregarItem()
            'End If

            'Catch

            'End Try

        End Sub

        Private Sub cmdAceptar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.MouseEnter

            'Try

            'If NuevaFactura = "SI" Then
            AgregarItem()
            'End If
            'Catch

            'End Try
        End Sub

        Private Sub cbCliente_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCliente.MouseEnter

            'Try
            'If NuevaFactura = "SI" Then
            AgregarItem()
            'End If
            'Catch

            'End Try
        End Sub


        Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click
            Dim f As frmBuscarItem = f.Instance

            If tCust.Rows.Count > 0 Then
                If tCust.Rows(tCust.Rows.Count - 1)("Codigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Precio") Is DBNull.Value Then
                    tCust.Rows(tCust.Rows.Count - 1).Delete()
                End If
            End If

            f.MdiParent = Me.MdiParent
            f.Show()
        End Sub

        Private Sub AgregarItem()
            Dim k As Integer
            Dim t As Integer

            If tItem.Rows.Count <> 0 Then
                For k = 0 To tItem.Rows.Count - 1

                    For t = 0 To tCust.Rows.Count - 1
                        ''MsgBox(tCust.Rows(t)("Codigo") & " Codigo tCust")
                        ''MsgBox(tItem.Rows(k)("Codigo") & " Codigo tItem")
                        ''MsgBox(tCust.Rows(t)("Tipo") & " Tipo tCust")
                        ''MsgBox(tItem.Rows(k)("Tipo") & " Tipo tItem")

                        If tCust.Rows(t)("Codigo") = tItem.Rows(k)("Codigo") And tCust.Rows(t)("Tipo") = tItem.Rows(k)("Tipo") Then
                            tCust.Rows(t)("Cantidad") = CDbl(tCust.Rows(t)("Cantidad")) + CDbl(tItem.Rows(k)("Cantidad"))
                            Exit For

                        End If

                    Next

                    If t = tCust.Rows.Count Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        'newRow1("CodigoTemporal") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
                        newRow1("CodigoTemporal") = tItem.Rows(k)("Codigo")
                        ' Add the row to the Customers table.
                        tCust.Rows.Add(newRow1)

                        'Articulo.ColumnComboBox.SelectedValue = tItem.Rows(k)("Codigo")
                        'ArticuloCodigo.ColumnComboBox.SelectedValue = tItem.Rows(k)("Codigo")
                        'ItemTipo.ColumnComboBox.SelectedValue = tItem.Rows(k)("Tipo")

                        DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tItem.Rows(k)("Codigo").ToString, tItem.Rows(k)("Tipo").ToString, EmpresaActual)

                        tCust.Rows(tCust.Rows.Count - 1)("Tipo") = tItem.Rows(k)("Tipo")
                        tCust.Rows(tCust.Rows.Count - 1)("Exento") = DetallesProducto.Exento

                        'tCust.Rows(rowChanging)("Codigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
                        tCust.Rows(tCust.Rows.Count - 1)("Codigo") = tItem.Rows(k)("Codigo")
                        tCust.Rows(tCust.Rows.Count - 1)("Articulo") = tItem.Rows(k)("Descripcion")
                        tCust.Rows(tCust.Rows.Count - 1)("Cantidad") = tItem.Rows(k)("Cantidad")
                        tCust.Rows(tCust.Rows.Count - 1)("Precio") = CDbl(tItem.Rows(k)("Precio")).ToString(Round)

                        If TipoDescuento = "A" Then
                            tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
                        ElseIf TipoDescuento = "B" Then
                            tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
                        ElseIf TipoDescuento = "C" Then
                            tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
                        Else
                            tCust.Rows(tCust.Rows.Count - 1)("Descuento") = "0.00"

                        End If

                    End If
                Next
            End If

            tItem.Clear()
        End Sub

        Private Sub cmdConsultaClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaClientes.Click
            If cbCliente.Text = "" Then
                MsgBox("Seleccione el Cliente", MsgBoxStyle.Information)
                Exit Sub
            End If

            If cbCliente.SelectedValue = Nothing Then
                MsgBox("El cliente no está registrado", MsgBoxStyle.Information)
                Exit Sub
            End If


            RegistroCliente = cbCliente.SelectedValue
            TipoAcumulado = ""
            Dim f As frmAcumulados = f.Instance
            f.MdiParent = Me.MdiParent
            f.Show()

        End Sub

        Private Sub dgCotizaciones_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCotizaciones.DoubleClick

        End Sub

        Private Sub etTotalT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etTotalT.MouseEnter
            'If NuevaFactura = "SI" Then
            '    etSaldo.Text = (TotalFactura - TotalGlobal).ToString(Round)
            AgregarItem()
            'End If
        End Sub

        Private Sub etSubTotalT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etSubTotalT.MouseEnter
            'If NuevaFactura = "SI" Then
            '    etSaldo.Text = (TotalFactura - TotalGlobal).ToString(Round)
            AgregarItem()
            'End If
        End Sub

        Private Sub etIvaT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etIvaT.MouseEnter
            'If NuevaFactura = "SI" Then
            '    etSaldo.Text = (TotalFactura - TotalGlobal).ToString(Round)
            AgregarItem()
            'End If
        End Sub

        Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

        End Sub

        Private Sub dgCotizaciones_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgCotizaciones.Navigate

        End Sub
    End Class

End Namespace
