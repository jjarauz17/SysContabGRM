Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Namespace DataGridTextBoxCombo
    Public Class frmSalidaCC
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmSalidaCC = Nothing

        Public Shared Function Instance() As frmSalidaCC
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmSalidaCC()
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

        Friend WithEvents dgFacturacionCliente As System.Windows.Forms.DataGrid
        Friend WithEvents etTotal As System.Windows.Forms.Label
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cbDepartamentos As System.Windows.Forms.ComboBox
        Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents cbMunicipios As System.Windows.Forms.ComboBox
        Friend WithEvents txtDepartamento As System.Windows.Forms.TextBox
        Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents txtFactura As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents etIva As System.Windows.Forms.Label
        Friend WithEvents cmdConsulta As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdConsultaClientes As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
        Friend WithEvents etTotalT As System.Windows.Forms.Label
        Friend WithEvents cmdFacturasTemporales As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmdCancelar1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdCotizacion As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents etCaja As System.Windows.Forms.Label
        Friend WithEvents cbAreas As System.Windows.Forms.ComboBox
        Friend WithEvents etIvaT As System.Windows.Forms.Label
        Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.dgFacturacionCliente = New System.Windows.Forms.DataGrid()
            Me.etTotal = New System.Windows.Forms.Label()
            Me.etTotalT = New System.Windows.Forms.Label()
            Me.cbAreas = New System.Windows.Forms.ComboBox()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.etCaja = New System.Windows.Forms.Label()
            Me.etIva = New System.Windows.Forms.Label()
            Me.etIvaT = New System.Windows.Forms.Label()
            Me.gbBotones = New System.Windows.Forms.GroupBox()
            Me.cmdCotizacion = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdCancelar1 = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdFacturasTemporales = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdConsultaClientes = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdConsulta = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.txtDepartamento = New System.Windows.Forms.TextBox()
            Me.txtDireccion = New System.Windows.Forms.TextBox()
            Me.txtTelefono = New System.Windows.Forms.TextBox()
            Me.txtResponsable = New System.Windows.Forms.TextBox()
            Me.cbMunicipios = New System.Windows.Forms.ComboBox()
            Me.cbDepartamentos = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtFactura = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.gbBotones.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgFacturacionCliente
            '
            Me.dgFacturacionCliente.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
            Me.dgFacturacionCliente.BackColor = System.Drawing.Color.Gainsboro
            Me.dgFacturacionCliente.BackgroundColor = System.Drawing.Color.DarkGray
            Me.dgFacturacionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgFacturacionCliente.CaptionBackColor = System.Drawing.Color.DarkKhaki
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
            Me.dgFacturacionCliente.Location = New System.Drawing.Point(8, 104)
            Me.dgFacturacionCliente.Name = "dgFacturacionCliente"
            Me.dgFacturacionCliente.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgFacturacionCliente.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgFacturacionCliente.SelectionForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.Size = New System.Drawing.Size(872, 336)
            Me.dgFacturacionCliente.TabIndex = 27
            '
            'etTotal
            '
            Me.etTotal.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etTotal.Location = New System.Drawing.Point(680, 448)
            Me.etTotal.Name = "etTotal"
            Me.etTotal.Size = New System.Drawing.Size(176, 32)
            Me.etTotal.TabIndex = 110
            Me.etTotal.Text = "0.00"
            Me.etTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etTotal.Visible = False
            '
            'etTotalT
            '
            Me.etTotalT.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etTotalT.Location = New System.Drawing.Point(616, 456)
            Me.etTotalT.Name = "etTotalT"
            Me.etTotalT.Size = New System.Drawing.Size(56, 24)
            Me.etTotalT.TabIndex = 109
            Me.etTotalT.Text = "Total:"
            Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etTotalT.Visible = False
            '
            'cbAreas
            '
            Me.cbAreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbAreas.Location = New System.Drawing.Point(80, 8)
            Me.cbAreas.Name = "cbAreas"
            Me.cbAreas.Size = New System.Drawing.Size(320, 21)
            Me.cbAreas.TabIndex = 111
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label24.Location = New System.Drawing.Point(16, 8)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(64, 24)
            Me.Label24.TabIndex = 112
            Me.Label24.Text = "Areas:"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label1.Location = New System.Drawing.Point(664, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 24)
            Me.Label1.TabIndex = 114
            Me.Label1.Text = "Fecha:"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.etCaja, Me.etIva, Me.etIvaT, Me.gbBotones, Me.txtDepartamento, Me.txtDireccion, Me.txtTelefono, Me.txtResponsable, Me.cbMunicipios, Me.cbDepartamentos, Me.Label2, Me.Label9, Me.Label4, Me.Label3, Me.etTotal, Me.etTotalT, Me.dgFacturacionCliente})
            Me.GroupBox3.Location = New System.Drawing.Point(16, 32)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(992, 488)
            Me.GroupBox3.TabIndex = 115
            Me.GroupBox3.TabStop = False
            '
            'etCaja
            '
            Me.etCaja.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etCaja.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etCaja.Location = New System.Drawing.Point(800, 200)
            Me.etCaja.Name = "etCaja"
            Me.etCaja.Size = New System.Drawing.Size(32, 24)
            Me.etCaja.TabIndex = 146
            Me.etCaja.Text = "Caja"
            Me.etCaja.Visible = False
            '
            'etIva
            '
            Me.etIva.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIva.ForeColor = System.Drawing.Color.Maroon
            Me.etIva.Location = New System.Drawing.Point(504, 456)
            Me.etIva.Name = "etIva"
            Me.etIva.Size = New System.Drawing.Size(104, 24)
            Me.etIva.TabIndex = 132
            Me.etIva.Text = "0.00"
            Me.etIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etIva.Visible = False
            '
            'etIvaT
            '
            Me.etIvaT.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etIvaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIvaT.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etIvaT.Location = New System.Drawing.Point(400, 456)
            Me.etIvaT.Name = "etIvaT"
            Me.etIvaT.Size = New System.Drawing.Size(96, 24)
            Me.etIvaT.TabIndex = 131
            Me.etIvaT.Text = "IVA:"
            Me.etIvaT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.etIvaT.Visible = False
            '
            'gbBotones
            '
            Me.gbBotones.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.gbBotones.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdCotizacion, Me.cmdCancelar1, Me.cmdFacturasTemporales, Me.cmdConsultaClientes, Me.cmdConsulta, Me.cmdCancelar, Me.cmdAceptar, Me.Label19, Me.Label20, Me.Label23})
            Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBotones.ForeColor = System.Drawing.Color.Maroon
            Me.gbBotones.Location = New System.Drawing.Point(888, 104)
            Me.gbBotones.Name = "gbBotones"
            Me.gbBotones.Size = New System.Drawing.Size(90, 376)
            Me.gbBotones.TabIndex = 130
            Me.gbBotones.TabStop = False
            '
            'cmdCotizacion
            '
            Me.cmdCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCotizacion.ForeColor = System.Drawing.Color.Black
            Me.cmdCotizacion.Location = New System.Drawing.Point(8, 176)
            Me.cmdCotizacion.Name = "cmdCotizacion"
            Me.cmdCotizacion.Size = New System.Drawing.Size(72, 30)
            Me.cmdCotizacion.TabIndex = 145
            Me.cmdCotizacion.Text = "Salida en Proceso"
            Me.cmdCotizacion.Visible = False
            '
            'cmdCancelar1
            '
            Me.cmdCancelar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar1.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar1.Location = New System.Drawing.Point(8, 240)
            Me.cmdCancelar1.Name = "cmdCancelar1"
            Me.cmdCancelar1.Size = New System.Drawing.Size(72, 24)
            Me.cmdCancelar1.TabIndex = 144
            Me.cmdCancelar1.Text = "C&ancelar"
            '
            'cmdFacturasTemporales
            '
            Me.cmdFacturasTemporales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdFacturasTemporales.ForeColor = System.Drawing.Color.Black
            Me.cmdFacturasTemporales.Location = New System.Drawing.Point(8, 80)
            Me.cmdFacturasTemporales.Name = "cmdFacturasTemporales"
            Me.cmdFacturasTemporales.Size = New System.Drawing.Size(72, 30)
            Me.cmdFacturasTemporales.TabIndex = 143
            Me.cmdFacturasTemporales.Text = "Salidas en Proceso"
            Me.cmdFacturasTemporales.Visible = False
            '
            'cmdConsultaClientes
            '
            Me.cmdConsultaClientes.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.cmdConsultaClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsultaClientes.ForeColor = System.Drawing.Color.Black
            Me.cmdConsultaClientes.Location = New System.Drawing.Point(8, 14)
            Me.cmdConsultaClientes.Name = "cmdConsultaClientes"
            Me.cmdConsultaClientes.Size = New System.Drawing.Size(72, 24)
            Me.cmdConsultaClientes.TabIndex = 33
            Me.cmdConsultaClientes.Text = "&Areas"
            '
            'cmdConsulta
            '
            Me.cmdConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsulta.ForeColor = System.Drawing.Color.Black
            Me.cmdConsulta.Location = New System.Drawing.Point(8, 48)
            Me.cmdConsulta.Name = "cmdConsulta"
            Me.cmdConsulta.Size = New System.Drawing.Size(72, 24)
            Me.cmdConsulta.TabIndex = 31
            Me.cmdConsulta.Text = "&Productos"
            '
            'cmdCancelar
            '
            Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar.Location = New System.Drawing.Point(8, 272)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
            Me.cmdCancelar.TabIndex = 29
            Me.cmdCancelar.Text = "&Salir"
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAceptar.ForeColor = System.Drawing.Color.Black
            Me.cmdAceptar.Location = New System.Drawing.Point(8, 144)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
            Me.cmdAceptar.TabIndex = 28
            Me.cmdAceptar.Text = "&Salida"
            '
            'Label19
            '
            Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.ForeColor = System.Drawing.Color.Maroon
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(88, 120)
            Me.Label19.TabIndex = 146
            Me.Label19.Text = "Consulta"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label20.ForeColor = System.Drawing.Color.Maroon
            Me.Label20.Location = New System.Drawing.Point(0, 128)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(88, 96)
            Me.Label20.TabIndex = 147
            Me.Label20.Text = "Guardar"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label23
            '
            Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.ForeColor = System.Drawing.Color.Maroon
            Me.Label23.Location = New System.Drawing.Point(1, 232)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(88, 72)
            Me.Label23.TabIndex = 151
            Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtDepartamento
            '
            Me.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDepartamento.Location = New System.Drawing.Point(96, 64)
            Me.txtDepartamento.MaxLength = 50
            Me.txtDepartamento.Name = "txtDepartamento"
            Me.txtDepartamento.ReadOnly = True
            Me.txtDepartamento.Size = New System.Drawing.Size(216, 20)
            Me.txtDepartamento.TabIndex = 126
            Me.txtDepartamento.Text = ""
            '
            'txtDireccion
            '
            Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(392, 16)
            Me.txtDireccion.MaxLength = 50
            Me.txtDireccion.Multiline = True
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.ReadOnly = True
            Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDireccion.Size = New System.Drawing.Size(280, 40)
            Me.txtDireccion.TabIndex = 124
            Me.txtDireccion.Text = ""
            '
            'txtTelefono
            '
            Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono.Location = New System.Drawing.Point(784, 16)
            Me.txtTelefono.MaxLength = 50
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.ReadOnly = True
            Me.txtTelefono.Size = New System.Drawing.Size(192, 20)
            Me.txtTelefono.TabIndex = 123
            Me.txtTelefono.Text = ""
            '
            'txtResponsable
            '
            Me.txtResponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtResponsable.Location = New System.Drawing.Point(96, 16)
            Me.txtResponsable.MaxLength = 50
            Me.txtResponsable.Name = "txtResponsable"
            Me.txtResponsable.ReadOnly = True
            Me.txtResponsable.Size = New System.Drawing.Size(216, 20)
            Me.txtResponsable.TabIndex = 122
            Me.txtResponsable.Text = ""
            '
            'cbMunicipios
            '
            Me.cbMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
            Me.cbMunicipios.Enabled = False
            Me.cbMunicipios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbMunicipios.Location = New System.Drawing.Point(448, 288)
            Me.cbMunicipios.Name = "cbMunicipios"
            Me.cbMunicipios.Size = New System.Drawing.Size(224, 21)
            Me.cbMunicipios.TabIndex = 121
            Me.cbMunicipios.Visible = False
            '
            'cbDepartamentos
            '
            Me.cbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
            Me.cbDepartamentos.Enabled = False
            Me.cbDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbDepartamentos.Location = New System.Drawing.Point(448, 256)
            Me.cbDepartamentos.Name = "cbDepartamentos"
            Me.cbDepartamentos.Size = New System.Drawing.Size(224, 21)
            Me.cbDepartamentos.TabIndex = 119
            Me.cbDepartamentos.Visible = False
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label2.Location = New System.Drawing.Point(320, 16)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(72, 24)
            Me.Label2.TabIndex = 101
            Me.Label2.Text = "Dirección:"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label9.Location = New System.Drawing.Point(8, 16)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(80, 24)
            Me.Label9.TabIndex = 100
            Me.Label9.Text = "Responsable:"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label4.Location = New System.Drawing.Point(8, 64)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(88, 24)
            Me.Label4.TabIndex = 102
            Me.Label4.Text = "Departamento:"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label3.Location = New System.Drawing.Point(704, 16)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(64, 24)
            Me.Label3.TabIndex = 103
            Me.Label3.Text = "Teléfono:"
            '
            'txtFactura
            '
            Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Location = New System.Drawing.Point(504, 8)
            Me.txtFactura.MaxLength = 50
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.ReadOnly = True
            Me.txtFactura.Size = New System.Drawing.Size(128, 20)
            Me.txtFactura.TabIndex = 125
            Me.txtFactura.Text = ""
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label7.Location = New System.Drawing.Point(432, 8)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(72, 24)
            Me.Label7.TabIndex = 124
            Me.Label7.Text = "No. Salida:"
            '
            'dtpFecha
            '
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtpFecha.Location = New System.Drawing.Point(728, 8)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 143
            '
            'frmSalidaCC
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(226, Byte), CType(236, Byte), CType(236, Byte))
            Me.ClientSize = New System.Drawing.Size(1024, 526)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpFecha, Me.txtFactura, Me.Label7, Me.GroupBox3, Me.Label1, Me.cbAreas, Me.Label24})
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
            Me.KeyPreview = True
            Me.Name = "frmSalidaCC"
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.gbBotones.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        'Dim Inicio As Boolean
        'Dim FacturasCompras As New VB.SysContab.Facturas_ComprasDB()

        'Dim dsProveedoresTemporales As DataSet
        'Dim dsItemTemporales As DataSet

        'Dim Ordenes As New VB.SysContab.OrdenesDB()

        'Dim Ordenes_Compras As New VB.SysContab.Ordenes_ComprasDB()

        'Dim FacturaTemporal As New VB.SysContab.Facturas_Ventas_TemporalDB()
        'Dim Clientes As New VB.SysContab.ClientesDB()
        Dim Departamentos As New VB.SysContab.DepartamentosCDB()
        Dim Municipios As New VB.SysContab.MunicipiosDB()
        'Dim Articulos As New VB.SysContab.ArticulosDB()
        'Dim Servicios As New VB.SysContab.ServiciosDB()
        'Dim DetallesProducto As New VB.SysContab.ArticulosDetails()
        'Dim DetallesCliente As New VB.SysContab.ClientesDetails()

        'Dim FormaPago As New VB.SysContab.Forma_PagoDB()

        'Dim Cotizaciones As New VB.SysContab.CotizacionesDB()

        'Dim DetallesVendedor As New VB.SysContab.VendedoresDetails()
        'Dim Vendedor As New VB.SysContab.VendedoresDB()

        Dim Config As New VB.SysContab.ConfiguracionDB()
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()

        'Dim CodigoVendedor As String

        Dim r As New VB.SysContab.Rutinas()
        Dim ds As DataSet

        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet

        Dim i As Integer

        Dim WithEvents Articulo As DataGridComboBoxColumn
        Dim WithEvents ArticuloCodigo As DataGridComboBoxColumn
        Dim Cantidad As DataGridTextBoxColumn
        'Dim Descuento As DataGridTextBoxColumn
        'ArticuloCodigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboValueChanged))

        'Dim WithEvents ItemTipo As DataGridComboBoxColumn

        Dim ValorActualCantidad As Double
        Dim ValorActualPrecio As Double
        Dim ValorActualDescuento As Double

        Dim TipoCambio As Double

        Dim TotalCordobas As Double

        Dim TipoDescuento As String

        ''''''''''Variables para buscar en el combo Cliente''''''''''
        Dim Cliente As String
        'Dim Cod_Cliente As String
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim Factura As String
        Dim Moneda As String
        Dim dsItems As DataSet
        Public Codigo As String

        Dim VentaPerdidaNumero As Long

        Dim CantidadPerdida As Double

        Dim Iva As Double
        Dim SubTotal As Double

        Public GruposCC As New VB.SysContab.GruposCCDB()
        Dim dsExistencias As DataSet

        Private Sub frmSalidaCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ''r.CambiarEstilo(Me)
            r.FormularioColor(Me)

            VentaPerdidaNumero = 0

            ConfigDetalles = Config.GetConfigDetails

            txtFactura.Text = GruposCC.SalidasCCNumero

            Me.cbAreas.DataSource = GruposCC.AreasList1().Tables("GruposCC")
            Me.cbAreas.ValueMember = "Código"
            Me.cbAreas.DisplayMember = "Nombre"

            r.ComboAutoComplete(Me.cbAreas)

            Me.dtpFecha.Value = r.Fecha

            MakeDataSet()
            dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            LeaveCommit = False
            BuscarCombo = False

            r.ComboAutoComplete(Articulo.ColumnComboBox)
            r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)

            Me.Text = "S a l i d a ..."

        End Sub

        Private Sub MakeDataSet()

            myDataSet = New DataSet("myDataSet")
            tCust = New DataTable("Articulos")

            'myDataSet = Articulos.SalidaCC

            'MsgBox(myDataSet.Tables("Articulos").Rows(0).Item("Tipo"))

            Dim cArticuloCodigo As DataColumn
            cArticuloCodigo = New DataColumn("ArticuloCodigo")

            Dim cArticulo As DataColumn
            cArticulo = New DataColumn("Articulo")

            Dim cCantidad As DataColumn
            cCantidad = New DataColumn("Cantidad")

            Dim cCosto As DataColumn
            cCosto = New DataColumn("Costo")

            Dim cSubTotal As DataColumn
            cSubTotal = New DataColumn("SubTotal")

            tCust.Columns.Add(cArticuloCodigo)
            tCust.Columns.Add(cArticulo)
            tCust.Columns.Add(cCantidad)
            tCust.Columns.Add(cCosto)
            tCust.Columns.Add(cSubTotal)

            myDataSet.Tables.Add(tCust)

        End Sub

        Private Sub TextBoxLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            If dgFacturacionCliente.CurrentRowIndex >= tCust.Rows.Count Then
                Exit Sub
            End If

            If tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo").ToString = "" Or tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo") Is DBNull.Value Then
                Exit Sub
            End If

            If Not IsNumeric(Cantidad.TextBox.Text) Then
                Cantidad.TextBox.Text = ValorActualCantidad
            Else
                If CDbl(Cantidad.TextBox.Text) <= 0 Then
                    MsgBox("La cantidad debe ser mayor que Cero (0)", MsgBoxStyle.Information)
                    Cantidad.TextBox.Text = ValorActualCantidad
                    Exit Sub
                End If

                dsExistencias = GruposCC.ArticulosCCExistencias(tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"))

                If dsExistencias.Tables("GruposCC").Rows.Count = 0 Then
                    MsgBox("No hay existencias...", MsgBoxStyle.Critical)
                    Cantidad.TextBox.Text = ValorActualCantidad
                Else
                    If dsExistencias.Tables("GruposCC").Rows(0).Item("Existencias") = 0 Then
                        MsgBox("No hay existencias...", MsgBoxStyle.Critical)
                        Cantidad.TextBox.Text = ValorActualCantidad
                    ElseIf dsExistencias.Tables("GruposCC").Rows(0).Item("Existencias") < Cantidad.TextBox.Text Then
                        MsgBox("La existencia no es suficiente", MsgBoxStyle.Critical)
                        Cantidad.TextBox.Text = ValorActualCantidad
                    End If

                End If

                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Cantidad") = Cantidad.TextBox.Text
                tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("SubTotal") = CDbl(CDbl(Cantidad.TextBox.Text) * CDbl(tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Costo"))).ToString(Round)

                'If Articulos.ItemTemporalBuscar(tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "C" & etCaja.Text).Tables("Articulos").Rows.Count <> 0 Then
                '    Exit Sub
                'End If

            End If

            'If TipoItem = "S" Then
            '    Exit Sub
            'ElseIf TipoItem = "A" Then
            '    If tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Tipo").ToString = "S" Then
            '        Exit Sub
            '    End If
            'End If

            'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Tipo"), EmpresaActual)

            'If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
            '    '
            'ElseIf DetallesProducto.Existencia = 0 Then
            '    MsgBox("No hay existencias...", MsgBoxStyle.Critical)
            '    CantidadPerdida = Cantidad.TextBox.Text
            '    If VentaPerdidaNumero = 0 Then
            '        VentaPerdidaNumero = Clientes.VentaPerdidaNumero
            '    End If
            '    If Clientes.VentasPerdidasBuscar(VentaPerdidaNumero, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "C" & etCaja.Text).Tables("VentasPerdidas").Rows.Count = 0 Then
            '        Clientes.VentasPerdidasAddItem(VentaPerdidaNumero, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "C" & etCaja.Text, Me.cbCliente.SelectedValue, DetallesCliente.Vendedor, CantidadPerdida, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Precio"), 1)
            '    End If
            '    'MsgBox(CantidadPerdida)
            '    'Cantidad.TextBox.Focus()
            '    Exit Sub
            'ElseIf CDbl(Cantidad.TextBox.Text) > CDbl(DetallesProducto.Existencia) Then
            '    If VentaPerdidaNumero = 0 Then
            '        VentaPerdidaNumero = Clientes.VentaPerdidaNumero
            '    End If

            '    If MsgBox("La existencia actual es de: " & DetallesProducto.Existencia & "." & Chr(13) & "Desea Adquirirlas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '        CantidadPerdida = Cantidad.TextBox.Text
            '        Cantidad.TextBox.Text = DetallesProducto.Existencia
            '        CantidadPerdida = CantidadPerdida - Cantidad.TextBox.Text
            '        If Clientes.VentasPerdidasBuscar(VentaPerdidaNumero, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "C" & etCaja.Text).Tables("VentasPerdidas").Rows.Count = 0 Then
            '            Clientes.VentasPerdidasAddItem(VentaPerdidaNumero, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "C" & etCaja.Text, Me.cbCliente.SelectedValue, DetallesCliente.Vendedor, CantidadPerdida, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Precio"), 2)
            '        End If
            '    Else
            '        CantidadPerdida = Cantidad.TextBox.Text
            '        If Clientes.VentasPerdidasBuscar(VentaPerdidaNumero, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "C" & etCaja.Text).Tables("VentasPerdidas").Rows.Count = 0 Then
            '            Clientes.VentasPerdidasAddItem(VentaPerdidaNumero, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo"), "C" & etCaja.Text, Me.cbCliente.SelectedValue, DetallesCliente.Vendedor, CantidadPerdida, tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Precio"), 2)
            '        End If
            '        tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex).Delete()
            '    End If
            '    Exit Sub
            'End If
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

            'Dim ArticuloCodigo As DataGridComboBoxColumn
            ArticuloCodigo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboCodigoValueChanged))
            ArticuloCodigo.MappingName = "ArticuloCodigo"
            ArticuloCodigo.HeaderText = "Código"
            ArticuloCodigo.Width = 120
            ts1.GridColumnStyles.Add(ArticuloCodigo)
            ArticuloCodigo.NullText = ""
            colCount = (colCount + 1)


            'Dim Articulo As DataGridComboBoxColumn
            Articulo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboDescripcionValueChanged))
            Articulo.MappingName = "Articulo"
            Articulo.HeaderText = "Descripción"
            Articulo.Width = 300
            ts1.GridColumnStyles.Add(Articulo)
            Articulo.NullText = ""
            colCount = (colCount + 1)

            'Dim Cantidad As DataGridTextBoxColumn
            Cantidad = New DataGridTextBoxColumn()
            Cantidad.MappingName = "Cantidad"
            'from dataset table
            Cantidad.HeaderText = "Cantidad"
            'Cantidad.Format = "d3"
            Cantidad.Width = 100
            Cantidad.Alignment = HorizontalAlignment.Right
            Cantidad.ReadOnly = False
            AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxLeaveHandler)
            'AddHandler Cantidad.TextBox.KeyDown, AddressOf Evento_KeyPress
            ts1.GridColumnStyles.Add(Cantidad)
            colCount = (colCount + 1)
            Cantidad.NullText = ""

            'Dim Precio As DataGridTextBoxColumn
            'Precio = New DataGridTextBoxColumn()
            'Precio.MappingName = "Precio"
            'Precio.HeaderText = "Precio"
            'Precio.Width = 100
            'Precio.Alignment = HorizontalAlignment.Right
            'Precio.ReadOnly = True
            'Precio.Format = "##,###0.00"
            'ts1.GridColumnStyles.Add(Precio)
            'colCount = (colCount + 1)

            'Precio.NullText = "0.00"

            ''Dim Descuento As DataGridTextBoxColumn
            'Descuento = New DataGridTextBoxColumn()
            'Descuento.MappingName = "Descuento"
            'Descuento.HeaderText = "Descuento %"
            'Descuento.Width = 100
            'Descuento.Alignment = HorizontalAlignment.Right
            'Descuento.ReadOnly = False
            'Descuento.Format = "##,###0.00"
            'ts1.GridColumnStyles.Add(Descuento)
            'colCount = (colCount + 1)
            'Descuento.NullText = "" 'CDbl(0).ToString(Round)

            Dim Costo As DataGridTextBoxColumn
            Costo = New DataGridTextBoxColumn()
            Costo.MappingName = "Costo"
            Costo.HeaderText = "P.C.M"
            Costo.Width = 100
            Costo.Alignment = HorizontalAlignment.Right
            Costo.ReadOnly = True
            Costo.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(Costo)
            colCount = (colCount + 1)
            Costo.NullText = "0.00"

            Dim SubTotal As DataGridTextBoxColumn
            SubTotal = New DataGridTextBoxColumn()
            SubTotal.MappingName = "SubTotal"
            SubTotal.HeaderText = "Importe"
            SubTotal.Width = 100
            SubTotal.Alignment = HorizontalAlignment.Right
            SubTotal.ReadOnly = True
            SubTotal.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(SubTotal)
            colCount = (colCount + 1)
            SubTotal.NullText = "0.00"

            'Dim CodigoTemporal As DataGridTextBoxColumn
            'CodigoTemporal = New DataGridTextBoxColumn()
            'CodigoTemporal.MappingName = "CodigoTemporal"
            'CodigoTemporal.HeaderText = "CodigoTemporal"
            'CodigoTemporal.Width = 0
            'CodigoTemporal.Alignment = HorizontalAlignment.Left
            'CodigoTemporal.ReadOnly = True
            ''CodigoTemporal.Format = "##,###0.00"
            'ts1.GridColumnStyles.Add(CodigoTemporal)
            'colCount = (colCount + 1)
            'CodigoTemporal.NullText = ""


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''Tipo = P: Producto S: Servicio'''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'ItemTipo = New DataGridComboBoxColumn(New ComboValueChanged(AddressOf MyComboCodigoValueChanged))
            'ItemTipo.MappingName = "Tipo"
            'ItemTipo.HeaderText = "Tipo"
            'ItemTipo.Width = 0
            'ItemTipo.ReadOnly = True

            'ts1.GridColumnStyles.Add(ItemTipo)

            'ItemTipo.NullText = ""
            'ds = GruposCC.ArticulosCCList("", Me.cbProveedores.SelectedValue.ToString, Me.cbLineas.SelectedValue.ToString, Me.cbGrupos.SelectedValue.ToString, Me.cbSubGrupos.SelectedValue.ToString)
            dsItems = GruposCC.ArticulosCCList("", 0, 0, 0, 0)

            For i = 0 To dsItems.Tables("GruposCC").Rows.Count - 1
                ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("GruposCC").Rows(i).Item("Código"))
                Articulo.ColumnComboBox.Items.Add(dsItems.Tables("GruposCC").Rows(i).Item("Nombre"))
            Next

            'ArticuloCodigo.ColumnComboBox.DataSource = Articulos.ProductosGetAll("P").Tables("Articulos")
            'ArticuloCodigo.ColumnComboBox.ValueMember = "Codigo"
            'ArticuloCodigo.ColumnComboBox.DisplayMember = "Codigo"

            'Articulo.ColumnComboBox.DataSource = Articulos.ProductosGetAll("P").Tables("Articulos")
            'Articulo.ColumnComboBox.ValueMember = "Codigo"
            'Articulo.ColumnComboBox.DisplayMember = "Nombre"

            ArticuloCodigo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
            ArticuloCodigo.ColumnComboBox.SelectedValue = -1

            Articulo.ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDown
            Articulo.ColumnComboBox.SelectedValue = -1
            colCount = (colCount + 1)

            'Dim Exento As DataGridTextBoxColumn
            'Exento = New DataGridTextBoxColumn()
            'Exento.MappingName = "Exento"
            'Exento.HeaderText = ""
            'Exento.Width = 0
            'Exento.Alignment = HorizontalAlignment.Right
            'Exento.ReadOnly = True
            'Exento.Format = "##,###0.00"
            'ts1.GridColumnStyles.Add(Exento)
            'colCount = (colCount + 1)

            'Exento.NullText = "0.00"

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'STEP 6: Add the tablestyle to your datagrids tablestlye collection

            ts1.AllowSorting = False
            ts1.GridLineColor = Color.FromArgb(70, 130, 180)
            ts1.HeaderFont = dgFacturacionCliente.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
            ts1.PreferredRowHeight = 25

            dgFacturacionCliente.CaptionVisible = False

            dgFacturacionCliente.TableStyles.Clear()
            dgFacturacionCliente.TableStyles.Add(ts1)

        End Sub

        Public Sub MyComboCodigoValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
            Console.WriteLine("index changed {0} {1}", rowChanging, newValue)
            Try
                If ArticuloCodigo.ColumnComboBox.SelectedIndex >= 0 Then
                    If tCust.Rows.Count < rowChanging + 1 Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        tCust.Rows.Add(newRow1)


                        'tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items(ArticuloCodigo.ColumnComboBox.SelectedIndex).row("Codigo") 'ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        'tCust.Rows(rowChanging)("Articulo") = ArticuloCodigo.ColumnComboBox.Items(ArticuloCodigo.ColumnComboBox.SelectedIndex).row("Nombre") 'Articulo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Cantidad") = 1
                        tCust.Rows(rowChanging)("Costo") = CDbl(GruposCC.ArticulosCCDetalles(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString).Tables("Tabla").Rows(0).Item("Articulo_Costo")).ToString(Round)
                        tCust.Rows(rowChanging)("SubTotal") = CDbl(CDbl(tCust.Rows(rowChanging)("Cantidad")) * CDbl(tCust.Rows(rowChanging)("Costo"))).ToString(Round)
                    Else
                        tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Cantidad") = 1
                        tCust.Rows(rowChanging)("Costo") = CDbl(GruposCC.ArticulosCCDetalles(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString).Tables("Tabla").Rows(0).Item("Articulo_Costo")).ToString(Round)
                        tCust.Rows(rowChanging)("SubTotal") = CDbl(CDbl(tCust.Rows(rowChanging)("Cantidad")) * CDbl(tCust.Rows(rowChanging)("Costo"))).ToString(Round)
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message & "MyComboValueChanged")
            End Try

        End Sub

        Public Sub MyComboDescripcionValueChanged(ByVal rowChanging As Integer, ByVal newValue As Object)
            Console.WriteLine("index changed {0} {1}", rowChanging, newValue)

            Try
                If Articulo.ColumnComboBox.SelectedIndex >= 0 Then
                    If tCust.Rows.Count < rowChanging + 1 Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        tCust.Rows.Add(newRow1)

                        tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Cantidad") = 1
                        tCust.Rows(rowChanging)("Costo") = CDbl(GruposCC.ArticulosCCDetalles(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString).Tables("Tabla").Rows(0).Item("Articulo_Costo")).ToString(Round)

                        tCust.Rows(rowChanging)("SubTotal") = CDbl(CDbl(tCust.Rows(rowChanging)("Cantidad")) * CDbl(tCust.Rows(rowChanging)("Costo"))).ToString(Round)
                    Else
                        tCust.Rows(rowChanging)("ArticuloCodigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Articulo") = Articulo.ColumnComboBox.Items.Item(Indice)
                        tCust.Rows(rowChanging)("Cantidad") = 1
                        tCust.Rows(rowChanging)("Costo") = CDbl(GruposCC.ArticulosCCDetalles(ArticuloCodigo.ColumnComboBox.Items.Item(Indice).ToString).Tables("Tabla").Rows(0).Item("Articulo_Costo")).ToString(Round)
                        tCust.Rows(rowChanging)("SubTotal") = CDbl(CDbl(tCust.Rows(rowChanging)("Cantidad")) * CDbl(tCust.Rows(rowChanging)("Costo"))).ToString(Round)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message & "MyComboValueChanged")
            End Try
        End Sub

        Private Sub tCust_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tCust.ColumnChanged
            'Exit Sub
            'Dim Descuento As Double

            If Not IsNumeric(e.Row.Item(2)) Then
                e.Row.Item(2) = ValorActualCantidad
            End If

            If Not IsNumeric(e.Row.Item(3)) Then
                e.Row.Item(3) = ValorActualPrecio.ToString(Round)
            End If

            If Not IsNumeric(e.Row.Item(4)) Then
                e.Row.Item(4) = ValorActualDescuento.ToString(Round)
            End If

            'If e.Column.Ordinal = 2 Or e.Column.Ordinal = 3 Or e.Column.Ordinal = 4 Then
            '    If e.Row.Item(2) Is DBNull.Value Or e.Row.Item(3) Is DBNull.Value Then
            '    Else
            '        If e.Row.Item(4) Is DBNull.Value Then
            '            If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) Then
            '                e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))).ToString(Round)
            '            End If
            '        Else
            '            If IsNumeric(e.Row.Item(2)) And IsNumeric(e.Row.Item(3)) And IsNumeric(e.Row.Item(4)) Then
            '                'Descuento = (CDbl(e.Row.Item(4)) * CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3))) / 100.0
            '                e.Row.Item(5) = CDbl(CDbl(e.Row.Item(2)) * CDbl(e.Row.Item(3)) - Descuento).ToString(Round)
            '            End If
            '        End If
            '    End If
            'End If

            'Dim TotalIva As Double
            'SubTotalFacturaCliente = 0
            'SubTotalFacturaNoDescuentos = 0
            'TotalFacturaCliente = 0
            'TotalDescuento = 0
            'TotalIva = 0

            'For i = 0 To tCust.Rows.Count - 1

            '    If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Or tCust.Rows(i)("Exento") Is DBNull.Value Or tCust.Rows(i)("Tipo") Is DBNull.Value Then

            '    ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
            '        Try
            '            SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
            '            SubTotalFacturaNoDescuentos = SubTotalFacturaNoDescuentos + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
            '            TotalDescuento = TotalDescuento + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)

            '            If DetallesCliente.Excento = True Then
            '                TotalIva = 0
            '            Else
            '                If tCust.Rows(i)("Exento") = False Then
            '                    TotalIva = TotalIva + (tCust.Rows(i)("SubTotal") * (ConfigDetalles.IVA / 100.0))
            '                End If
            '            End If

            '        Catch ex As Exception
            '            MsgBox(ex.Message)

            '        End Try

            '    End If

            'Next

            'etIva.Text = TotalIva.ToString(Round)
            etTotal.Text = (SubTotalFacturaCliente + CDbl(etIva.Text)).ToString(Round)

        End Sub

        Private Sub cbAreas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAreas.SelectedIndexChanged
            'If Not IsNumeric(cbAreas.SelectedValue) Then
            '    Exit Sub
            'End If

            'If cbAreas.SelectedValue = 0 Or Trim(cbAreas.Text) = "" Then
            '    txtDireccion.Text = ""
            '    txtTelefono.Text = ""
            '    txtDepartamento.Text = ""
            '    txtMunicipio.Text = ""
            '    Exit Sub
            'End If


            'DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cbAreas.SelectedValue)

            'cbDepartamentos.DataSource = Departamentos.GetList().Tables("DepartamentosC")
            'cbDepartamentos.ValueMember = "Codigo"
            'cbDepartamentos.DisplayMember = "Nombre"

            'cbDepartamentos.SelectedValue = DetallesCliente.Departamento

            'cbMunicipios.DataSource = Municipios.GetList(cbDepartamentos.SelectedValue).Tables("Municipios")
            'cbMunicipios.ValueMember = "Codigo"
            'cbMunicipios.DisplayMember = "Nombre"

            'cbMunicipios.SelectedValue = DetallesCliente.Municipio

            'txtRuc.Text = DetallesCliente.Ruc
            'txtDireccion.Text = DetallesCliente.Direccion
            'txtTelefono.Text = DetallesCliente.Telefono

            'If DetallesCliente.Departamento = "0" Then
            '    txtDepartamento.Text = ""
            'Else
            '    txtDepartamento.Text = cbDepartamentos.Text
            'End If

            'DetallesVendedor = Vendedor.GetDetails(DetallesCliente.Vendedor.ToString)
            'txtVendedor.Text = DetallesVendedor.Nombre

        End Sub

        Private Sub cbCliente_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAreas.Leave

            'If Trim(cbAreas.Text) = "" Then
            '    txtDireccion.Text = ""
            '    txtTelefono.Text = ""
            '    txtDepartamento.Text = ""
            '    txtVendedor.Text = ""
            '    Cliente = ""
            '    Exit Sub
            'End If

            'If Clientes.ClientesBuscar(Trim(cbAreas.Text)).Tables("Clientes").Rows.Count = 0 Then
            '    cbAreas.Text = cbAreas.Text.ToUpper

            '    txtRuc.Text = ""
            '    txtDireccion.Text = ""
            '    txtTelefono.Text = ""
            '    txtDepartamento.Text = ""
            '    txtVendedor.Text = ""
            '    Cliente = ""

            '    If (MsgBox("Cliente no existe. Desea agregarlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)) = MsgBoxResult.No Then
            '        Cliente = cbAreas.Text.ToUpper
            '        Cod_Cliente = "9999"
            '        DetallesCliente = VB.SysContab.ClientesDB.GetDetails(Cod_Cliente)
            '        DetallesVendedor = Vendedor.GetDetails(DetallesCliente.Vendedor)
            '    Else
            '        Dim f As New frmAgregarClienteQuick()
            '        f.WindowState = FormWindowState.Normal
            '        f.StartPosition = FormStartPosition.CenterScreen
            '        NombreCliente = cbAreas.Text.ToUpper

            '        f.ShowDialog()

            '        cbAreas.DataSource = Clientes.GetList().Tables("Clientes")
            '        cbAreas.ValueMember = "Codigo"
            '        cbAreas.DisplayMember = "Nombre"

            '        cbAreas.SelectedValue = f.txtCodigo.Text

            '    End If

            '    Exit Sub
            'End If
        End Sub

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

            Try
                If Guardar() = False Then
                    Exit Sub
                End If

                LimpiarControles()
                VB.SysContab.Rutinas.okTransaccion()
                RestablecerDataset()
            Catch ex As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(ex.Message & "Aceptar")
                Exit Sub
            End Try

        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            If tCust.Rows.Count <> 0 Then
                If MsgBox("La información no ha sido guardada. Desea salir sin guardar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            Me.Close()
        End Sub

        Private Function Guardar() As Boolean

            If Trim(cbAreas.Text) = "" Then
                MsgBox("Seleccione el Area", MsgBoxStyle.Critical)
                cbAreas.Focus()
                Return False
                Exit Function
            End If

            If Trim(txtFactura.Text) = "" Then
                MsgBox("Introduzca el No. de Factura", MsgBoxStyle.Critical)
                txtFactura.Focus()
                Return False
                Exit Function
            End If

            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione al menos un Producto", MsgBoxStyle.Critical)
                Me.dgFacturacionCliente.Focus()
                Articulo.ColumnComboBox.Focus()
                Return False
                Exit Function
            End If

            ''
            If tCust.Rows.Count > 0 Then
                If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Costo") Is DBNull.Value Then
                    tCust.Rows(tCust.Rows.Count - 1).Delete()
                End If
            End If
            ''
            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Articulo").ToString = "" Or tCust.Rows(i)("Articulo") Is DBNull.Value Or tCust.Rows(i)("ArticuloCodigo").ToString = "" Or tCust.Rows(i)("ArticuloCodigo") Is DBNull.Value Then
                    MsgBox("Seleccione el Producto", MsgBoxStyle.Critical)
                    dgFacturacionCliente.Select(i)
                    Return False
                    Exit Function
                End If
            Next

            For i = 0 To tCust.Rows.Count - 1
                dsExistencias = GruposCC.ArticulosCCExistencias(tCust.Rows(i)("ArticuloCodigo"))

                If dsExistencias.Tables("GruposCC").Rows.Count = 0 Then
                    MsgBox("No hay existencias Para el Producto: " & tCust.Rows(i)("ArticuloCodigo") & " - " & tCust.Rows(i)("Articulo"), MsgBoxStyle.Critical)
                    dgFacturacionCliente.Select(i)
                    Exit Function
                Else
                    If dsExistencias.Tables("GruposCC").Rows(0).Item("Existencias") = 0 Then
                        MsgBox("No hay existencias Para el Producto: " & tCust.Rows(i)("ArticuloCodigo") & " - " & tCust.Rows(i)("Articulo"), MsgBoxStyle.Critical)
                        dgFacturacionCliente.Select(i)
                        Exit Function
                    ElseIf CDbl(dsExistencias.Tables("GruposCC").Rows(0).Item("Existencias")) < CDbl(tCust.Rows(i)("Cantidad")) Then
                        'f dsExistencias.Tables("GruposCC").Rows(0).Item("Existencias") < Cantidad.TextBox.Text Then
                        MsgBox("La existencia no es suficiente para el Producto: " & tCust.Rows(i)("ArticuloCodigo") & " - " & tCust.Rows(i)("Articulo"), MsgBoxStyle.Critical)
                        dgFacturacionCliente.Select(i)
                        Exit Function
                    End If

                End If
            Next

            'For i = 0 To tCust.Rows.Count - 1
            '    If tCust.Rows(i)("Articulo").ToString = "" Or tCust.Rows(i)("Articulo") Is DBNull.Value Or tCust.Rows(i)("ArticuloCodigo").ToString = "" Or tCust.Rows(i)("ArticuloCodigo") Is DBNull.Value Then
            '        If tCust.Rows(i)("Tipo") = "P" Then
            '            MsgBox("Elija el Producto", MsgBoxStyle.Critical)
            '        ElseIf tCust.Rows(i)("Tipo") = "S" Then
            '            MsgBox("Elija el Servicio", MsgBoxStyle.Critical)
            '        Else
            '            MsgBox("Elija el Producto o Servicio", MsgBoxStyle.Critical)
            '        End If

            '        dgFacturacionCliente.Select(i)
            '        Return False
            '        Exit Function
            '    End If

            '    If tCust.Rows(i)("Tipo") = "P" Then
            '        If Articulos.ItemTemporalBuscar(tCust.Rows(i)("ArticuloCodigo"), "C" & etCaja.Text).Tables("Articulos").Rows.Count <> 0 Then
            '        Else
            '            DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Tipo"), EmpresaActual)
            '            If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
            '                '
            '            ElseIf DetallesProducto.Existencia = 0 Then
            '                MsgBox("No hay existencias Para el Producto: " & tCust.Rows(i)("ArticuloCodigo") & " - " & tCust.Rows(i)("Articulo"), MsgBoxStyle.Critical)
            '                dgFacturacionCliente.Select(i)
            '                Exit Function
            '            ElseIf CDbl(tCust.Rows(i)("Cantidad")) > CDbl(DetallesProducto.Existencia) Then
            '                MsgBox("La cantidad del producto: " & tCust.Rows(i)("ArticuloCodigo") & " - " & tCust.Rows(i)("Articulo") & " es mayor que la existencia actual.", MsgBoxStyle.Critical)
            '                dgFacturacionCliente.Select(i)
            '                Exit Function
            '            End If
            '        End If
            '    End If
            'Next

            'If CDbl(TotalGlobal.ToString(Round)) > CDbl(TotalFactura.ToString(Round)) Then
            '    MsgBox("El monto es mayor que el saldo de la factura", MsgBoxStyle.Information)
            '    Return False
            '    Exit Function
            'End If

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Try
                txtFactura.Text = GruposCC.SalidasCCNumero

                Dim OrdenCompra As String
                Dim Proveedor As String

                Dim NumeroTemporal As String

                GruposCC.SalidasCCAddItem(txtFactura.Text, dtpFecha.Value, Me.cbAreas.SelectedValue)

                For i = 0 To tCust.Rows.Count - 1
                    GruposCC.SalidasCCDetallesAddItem(txtFactura.Text, tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Cantidad"), tCust.Rows(i)("Costo"))
                Next
                'VB.SysContab.Rutinas.okTransaccion()
            Catch ex As Exception
                MsgBox(ex.Message & "Guardar")
                VB.SysContab.Rutinas.ErrorTransaccion()
                Return False
                Exit Function
            End Try

            Return True
        End Function

        Private Sub dgFacturacionCliente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturacionCliente.CurrentCellChanged
            Try
                'Dim Codigo, Descripcion As String

                'If Me.dgFacturacionCliente.CurrentRowIndex >= 0 Then
                '    Codigo = tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo")
                '    Descripcion = tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Articulo")

                '    ArticuloCodigo.ColumnComboBox.DataSource = Articulos.ProductosGetAll("P").Tables("Articulos")
                '    ArticuloCodigo.ColumnComboBox.ValueMember = "Codigo"
                '    ArticuloCodigo.ColumnComboBox.DisplayMember = "Codigo"

                '    Articulo.ColumnComboBox.DataSource = Articulos.ProductosGetAll("P").Tables("Articulos")
                '    Articulo.ColumnComboBox.ValueMember = "Codigo"
                '    Articulo.ColumnComboBox.DisplayMember = "Nombre"

                '    ArticuloCodigo.ColumnComboBox.SelectedValue = Codigo
                '    Articulo.ColumnComboBox.SelectedValue = Codigo

                '    'tcust.Rows(me.dgFacturacionCliente.CurrentRowIndex)("Codigo")

                '    'tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo") = Codigo 'ArticuloCodigo.ColumnComboBox.Items(ArticuloCodigo.ColumnComboBox.SelectedIndex).row("Codigo") 'Articulo.ColumnComboBox.Items.Item(Indice)
                '    'tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Articulo") = Descripcion 'Articulo.ColumnComboBox.Items(Articulo.ColumnComboBox.SelectedIndex).row("Nombre") 'Articulo.ColumnComboBox.Items.Item(Indice)
                'End If

                ValorActualCantidad = tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Cantidad")
                ValorActualPrecio = tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Precio")
                ValorActualDescuento = tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Descuento")
            Catch ex As Exception
                Exit Sub
            End Try
        End Sub

        Private Sub tCust_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles tCust.RowDeleted
            'SubTotalFacturaCliente = 0
            'SubTotalFacturaNoDescuentos = 0
            'TotalFacturaCliente = 0
            'TotalDescuento = 0

            'Dim TotalIva As Double
            'TotalIva = 0

            'For i = 0 To tCust.Rows.Count - 1

            '    If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Or tCust.Rows(i)("Exento") Is DBNull.Value Or tCust.Rows(i)("Tipo") Is DBNull.Value Then

            '    ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
            '        Try
            '            SubTotalFacturaCliente = SubTotalFacturaCliente + tCust.Rows(i)("SubTotal")
            '            SubTotalFacturaNoDescuentos = SubTotalFacturaNoDescuentos + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
            '            TotalDescuento = TotalDescuento + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)

            '            If DetallesCliente.Excento = True Then
            '                TotalIva = 0
            '            Else
            '                If tCust.Rows(i)("Exento") = False Then
            '                    TotalIva = TotalIva + (tCust.Rows(i)("SubTotal") * (ConfigDetalles.IVA / 100.0))
            '                End If
            '            End If
            '        Catch ex As Exception
            '            MsgBox(ex.Message)
            '        End Try
            '    End If
            'Next
        End Sub

        Private Sub frmSalidaCC_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

            AgregarItem()
        End Sub

        Private Sub dgFacturacionCliente_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturacionCliente.MouseEnter

            AgregarItem()
        End Sub

        Private Sub txtDireccion_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseEnter

            AgregarItem()
        End Sub

        Private Sub cmdAceptar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.MouseEnter

            AgregarItem()
        End Sub

        Private Sub cbAreas_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAreas.MouseEnter

            AgregarItem()
        End Sub

        Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click
            Dim f As frmBuscarItemCC = f.Instance

            If tCust.Rows.Count > 0 Then
                If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Costo") Is DBNull.Value Then
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

                        If tCust.Rows(t)("ArticuloCodigo") = tItem.Rows(k)("Codigo") Then
                            tCust.Rows(t)("Cantidad") = CDbl(tCust.Rows(t)("Cantidad")) + CDbl(tItem.Rows(k)("Cantidad"))
                            Exit For

                        End If

                    Next

                    If t = tCust.Rows.Count Then
                        Dim newRow1 As DataRow
                        newRow1 = tCust.NewRow
                        'newRow1("CodigoTemporal") = tItem.Rows(k)("Codigo")
                        tCust.Rows.Add(newRow1)

                        'DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tItem.Rows(k)("Codigo").ToString, tItem.Rows(k)("Tipo").ToString, EmpresaActual)

                        'tCust.Rows(tCust.Rows.Count - 1)("Tipo") = tItem.Rows(k)("Tipo")
                        'tCust.Rows(tCust.Rows.Count - 1)("Exento") = DetallesProducto.Exento

                        tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") = tItem.Rows(k)("Codigo")
                        tCust.Rows(tCust.Rows.Count - 1)("Articulo") = tItem.Rows(k)("Descripcion")
                        tCust.Rows(tCust.Rows.Count - 1)("Cantidad") = tItem.Rows(k)("Cantidad")
                        tCust.Rows(tCust.Rows.Count - 1)("Costo") = CDbl(tItem.Rows(k)("Costo")).ToString(Round)

                        'If TipoDescuento = "A" Then
                        '    tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_A).ToString(Round)
                        'ElseIf TipoDescuento = "B" Then
                        '    tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_B).ToString(Round)
                        'ElseIf TipoDescuento = "C" Then
                        '    tCust.Rows(tCust.Rows.Count - 1)("Descuento") = CDbl(DetallesProducto.Descuento_C).ToString(Round)
                        'Else
                        '    tCust.Rows(tCust.Rows.Count - 1)("Descuento") = "0.00"

                        'End If
                    End If
                Next
                tItem.Clear()
                ArticuloCodigo.ColumnComboBox.Focus()

            End If

        End Sub

        Private Sub cmdConsultaClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaClientes.Click
            If cbAreas.Text = "" Then
                MsgBox("Seleccione el Area", MsgBoxStyle.Information)
                Me.cbAreas.Focus()
                Exit Sub
            End If

            'If cbAreas.SelectedValue = Nothing Then
            '    MsgBox("El cliente no está registrado", MsgBoxStyle.Information)
            '    Exit Sub
            'End If

            Dim f As frmAreasCCAcumulados = f.Instance
            f.MdiParent = Me.MdiParent
            f.etCodigo.Text = Me.cbAreas.SelectedValue
            f.Show()
        End Sub

        Private Sub dgFacturacionCliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturacionCliente.DoubleClick
            'If dgFacturacionCliente.Item(dgFacturacionCliente.CurrentRowIndex, 0) Is DBNull.Value Then
            '    MsgBox("Seleccione el Producto o Servicio", MsgBoxStyle.Information)
            '    Exit Sub
            'End If

            If tCust.Rows.Count = 0 Then
                MsgBox("Seleccione el Producto", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim f As frmArticuloCCDetalle = f.Instance
            f.etCodigo.Text = dgFacturacionCliente.Item(dgFacturacionCliente.CurrentRowIndex, 0)
            'Registro = dgFacturacionCliente.Item(dgFacturacionCliente.CurrentRowIndex, 0)
            f.MdiParent = Me.MdiParent
            f.Show()
        End Sub


        Private Sub etTotalT_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles etTotalT.MouseEnter
            AgregarItem()
        End Sub

        Private Sub etSaldoT_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
            AgregarItem()
        End Sub

        Private Sub etSubTotalT_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
            AgregarItem()
        End Sub

        Private Sub etIvaT_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etIvaT.MouseEnter
            AgregarItem()
        End Sub

        Private Sub LimpiarControles()
        End Sub

        Private Sub cmdProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Exit Sub
            '    If LoadFacturaTemporal = True Then
            '        MsgBox("La factura ya está en Proceso", MsgBoxStyle.Information)
            '        Exit Sub
            '    End If

            '    Try
            '        'Guardar los datos de la Factura
            '        If GuardarTemporal() = False Then
            '            Exit Sub
            '        End If
            '        LimpiarControles()
            '        VB.SysContab.Rutinas.okTransaccion()
            '        LoadFacturaTemporal = False
            '        RestablecerDataset()
            '    Catch ex As Exception
            '        VB.SysContab.Rutinas.ErrorTransaccion()
            '        MsgBox(ex.Message & "Guardar Factura Temporal")
            '        Exit Sub
            '    End Try
            'End Sub


            'Private Function GuardarTemporal() As Boolean
            '    If Trim(cbAreas.Text) = "" Then
            '        MsgBox("Seleccione el Area", MsgBoxStyle.Critical)
            '        cbAreas.Focus()
            '        Return False
            '        Exit Function
            '    End If

            '    If Trim(txtFactura.Text) = "" Then
            '        MsgBox("Introduzca el No. de Factura", MsgBoxStyle.Critical)
            '        txtFactura.Focus()
            '        Return False
            '        Exit Function
            '    End If

            '    If tCust.Rows.Count = 0 Then
            '        MsgBox("Seleccione al menos un Producto o Servicio", MsgBoxStyle.Critical)
            '        dgFacturacionCliente.Focus()
            '        Articulo.ColumnComboBox.Focus()
            '        Return False
            '        Exit Function
            '    End If

            '    '
            '    If tCust.Rows.Count > 0 Then
            '        If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Precio") Is DBNull.Value Then
            '            tCust.Rows(tCust.Rows.Count - 1).Delete()
            '        End If
            '    End If
            '    '
            '    For i = 0 To tCust.Rows.Count - 1
            '        If tCust.Rows(i)("Articulo").ToString = "" Or tCust.Rows(i)("Articulo") Is DBNull.Value Or tCust.Rows(i)("ArticuloCodigo").ToString = "" Or tCust.Rows(i)("ArticuloCodigo") Is DBNull.Value Then
            '            MsgBox("Elija el Producto o Servicio", MsgBoxStyle.Critical)
            '            dgFacturacionCliente.Select(i)
            '            Return False
            '            Exit Function
            '        End If

            '    Next

            '    For i = 0 To tCust.Rows.Count - 1
            '        If tCust.Rows(i)("Articulo").ToString = "" Or tCust.Rows(i)("Articulo") Is DBNull.Value Or tCust.Rows(i)("ArticuloCodigo").ToString = "" Or tCust.Rows(i)("ArticuloCodigo") Is DBNull.Value Then
            '            If tCust.Rows(i)("Tipo") = "P" Then
            '                MsgBox("Elija el Producto", MsgBoxStyle.Critical)
            '            ElseIf tCust.Rows(i)("Tipo") = "S" Then
            '                MsgBox("Elija el Servicio", MsgBoxStyle.Critical)
            '            Else
            '                MsgBox("Elija el Producto o Servicio", MsgBoxStyle.Critical)
            '            End If

            '            dgFacturacionCliente.Select(i)
            '            Return False
            '            Exit Function
            '        End If

            '        If tCust.Rows(i)("Tipo") = "P" Then
            '            DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Tipo"), EmpresaActual)
            '            If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
            '                '
            '            ElseIf DetallesProducto.Existencia = 0 Then
            '                MsgBox("No hay existencias Para el Producto: " & tCust.Rows(i)("ArticuloCodigo") & " - " & tCust.Rows(i)("Articulo"), MsgBoxStyle.Critical)
            '                dgFacturacionCliente.Select(i)
            '                Exit Function
            '            ElseIf CDbl(tCust.Rows(i)("Cantidad")) > CDbl(DetallesProducto.Existencia) Then
            '                MsgBox("La cantidad del producto: " & tCust.Rows(i)("ArticuloCodigo") & " - " & tCust.Rows(i)("Articulo") & " es mayor que la existencia actual.", MsgBoxStyle.Critical)
            '                dgFacturacionCliente.Select(i)
            '                Exit Function
            '            End If

            '        End If

            '    Next

            '    If CDbl(TotalGlobal.ToString(Round)) > CDbl(TotalFactura.ToString(Round)) Then
            '        MsgBox("El monto es mayor que el saldo de la factura", MsgBoxStyle.Information)
            '        Return False
            '        Exit Function
            '    End If

            '    DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            '    DBConnFacturas.Open()
            '    transaccionFacturas = DBConnFacturas.BeginTransaction

            '    Dim Factura As String

            '    Factura = FacturaTemporal.Numero

            '    FacturaTemporal.AddFacturaTemporal(Factura, dtpFecha.Value, Cod_Cliente, txtRuc.Text, etSubTotal.Text, _
            '               etTotal.Text, TotalDescuento, etIva.Text, "0", "0", etTotal.Text, TotalFactura - TotalGlobal, DetallesCliente.Vendedor, _
            '               dtpFechaPago.Value, dtpFechaPago.Value, Tipo, cbTipoFactura.SelectedValue, 3, Cliente)

            '    Dim Descuento As Double
            '    Dim Comision As Double
            '    Dim Comisiones As New VB.SysContab.ComisionDB()
            '    For i = 0 To tCust.Rows.Count - 1
            '        If tCust.Rows(i)("Descuento") Is DBNull.Value Then
            '            Descuento = 0
            '        Else
            '            Descuento = tCust.Rows(i)("Descuento")
            '        End If

            '        If Comisiones.GetComisionItemVendedor(DetallesCliente.Vendedor, tCust.Rows(i)("CodigoTemporal"), "P").Tables("Comisiones").Rows.Count <> 0 Then
            '            Comision = Comisiones.GetComisionItemVendedor(DetallesCliente.Vendedor, tCust.Rows(i)("CodigoTemporal"), "P").Tables("Comisiones").Rows(0).Item("Comision")
            '        Else
            '            Comision = 0
            '        End If
            '        FacturaTemporal.AddFacturaLineasTemporal(Factura, tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Cantidad"), tCust.Rows(i)("Precio"), Descuento, CDbl(tCust.Rows(i)("Cantidad")) * CDbl(tCust.Rows(i)("Precio")), Comision, tCust.Rows(i)("Tipo"))

            '    Next

            '    Return True

            'End Function

            'Private Sub cmdFacturasTemporales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFacturasTemporales.Click
            '    Dim f As New frmFacturasTemporal()
            '    f.WindowState = FormWindowState.Normal
            '    f.StartPosition = FormStartPosition.CenterScreen
            '    f.ShowDialog()

            '    If LoadFacturaTemporal = True Then

            '        ds = FacturaTemporal.FacturaDetalle(RegistroFacturaTemporal)

            '        If ds.Tables("Facturas_Ventas").Rows.Count = 0 Then
            '            Exit Sub
            '        End If

            '        'If ds.Tables("Facturas_Ventas").Rows(0).Item("Cliente").ToString = "9999" Then
            '        '    cbCliente.SelectedIndex = -1
            '        '    cbCliente.Text = ds.Tables("Facturas_Ventas").Rows(0).Item("Nombre_Cliente").ToString
            '        '    Cliente = ds.Tables("Facturas_Ventas").Rows(0).Item("Nombre_Cliente").ToString
            '        '    Cod_Cliente = ds.Tables("Facturas_Ventas").Rows(0).Item("Cliente")
            '        '    DetallesCliente.Vendedor = 0
            '        'Else
            '        '    cbCliente.SelectedValue = ds.Tables("Facturas_Ventas").Rows(0).Item("Cliente")
            '        '    Cod_Cliente = cbCliente.SelectedValue
            '        'End If

            '        MakeDataSet()
            '        dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            '        AddCustomDataTableStyle()

            '        r.ComboAutoComplete(Articulo.ColumnComboBox)
            '        r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)

            '    End If
        End Sub

        Private Sub cmdCancelar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar1.Click
            If MsgBox("Desea cancelar la Operación Actual?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                Exit Sub
            End If
            Inicio = True
            Cancelar()
            Inicio = False
            cbAreas.Focus()
            
        End Sub

        Private Sub Cancelar()
            etIva.Text = "0.00"
            etTotal.Text = "0.00"

            Me.txtDepartamento.Text = ""
            Me.txtDireccion.Text = ""
            Me.txtResponsable.Text = ""
            Me.txtTelefono.Text = ""

            Me.cbAreas.SelectedValue = 0
            txtFactura.Text = GruposCC.SalidasCCNumero

            MakeDataSet()
            dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            r.ComboAutoComplete(Articulo.ColumnComboBox)
            r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
        End Sub

        Private Sub RestablecerDataset()
            VentaPerdidaNumero = 0
            Factura = txtFactura.Text
            txtFactura.Text = GruposCC.SalidasCCNumero

            MakeDataSet()
            dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            Inicio = True
            Inicio = False

            r.ComboAutoComplete(Articulo.ColumnComboBox)
            r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
        End Sub

        Private Sub frmSalidaCC_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed            
        End Sub

        Private Sub cbAreas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbAreas.KeyDown
            If e.KeyData = Keys.Enter Then
                Me.dgFacturacionCliente.Focus()
            End If
        End Sub

        Private Sub cbAreas_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAreas.SelectedValueChanged
            If Not IsNumeric(Me.cbAreas.SelectedValue) Then
                Exit Sub
            End If
            Dim ds As DataSet
            ds = GruposCC.AreasDetalles(Me.cbAreas.SelectedValue)
            If ds.Tables("GruposCC").Rows.Count = 0 Then
                Exit Sub
            End If
            Me.txtDepartamento.Text = ds.Tables("GruposCC").Rows(0).Item("Dep_Nombre").ToString
            Me.txtResponsable.Text = ds.Tables("GruposCC").Rows(0).Item("Emp_PNombre").ToString & " " & ds.Tables("GruposCC").Rows(0).Item("Emp_SNombre").ToString & " " & ds.Tables("GruposCC").Rows(0).Item("Emp_PApellido").ToString & " " & ds.Tables("GruposCC").Rows(0).Item("Emp_SApellido").ToString
            Me.txtDireccion.Text = ds.Tables("GruposCC").Rows(0).Item("Area_Direccion").ToString
            Me.txtTelefono.Text = ds.Tables("GruposCC").Rows(0).Item("Area_Telefono").ToString
        End Sub
    End Class

End Namespace
