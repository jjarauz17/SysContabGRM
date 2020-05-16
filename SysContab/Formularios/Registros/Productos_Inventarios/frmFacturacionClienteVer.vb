Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraReports.UI

Namespace DataGridTextBoxCombo
    Public Class frmFacturacionClienteVer
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmFacturacionClienteVer = Nothing

        Public Shared Function Instance() As frmFacturacionClienteVer
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmFacturacionClienteVer()
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
        Friend WithEvents txtCliente As System.Windows.Forms.TextBox
        Friend WithEvents cbCliente As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents cbTipoFactura As System.Windows.Forms.ComboBox
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents etSaldoT As System.Windows.Forms.Label
        Friend WithEvents etSaldo As System.Windows.Forms.Label
        Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents etSubTotal As System.Windows.Forms.Label
        Friend WithEvents etSubTotalT As System.Windows.Forms.Label
        Friend WithEvents etIva As System.Windows.Forms.Label
        Friend WithEvents etIvaT As System.Windows.Forms.Label
        Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
        Friend WithEvents cmdConsultaClientes As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdVerPagos As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents rbAmbos As System.Windows.Forms.RadioButton
        Friend WithEvents rbServicios As System.Windows.Forms.RadioButton
        Friend WithEvents rbProductos As System.Windows.Forms.RadioButton
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
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtFactura As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents dgFactura As DevExpress.XtraGrid.GridControl
        Friend WithEvents vFactura As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents cmbmoneda As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents cbCultivos As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents txtCondiciones As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label31 As System.Windows.Forms.Label
        Friend WithEvents txtremision As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents txtorden As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents etTasa As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents txtNoEntrega As DevExpress.XtraEditors.TextEdit
        Friend WithEvents etTotalU As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents cbBodega As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturacionClienteVer))
            Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Me.txtCliente = New System.Windows.Forms.TextBox()
            Me.cbCliente = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.cbBodega = New DevExpress.XtraEditors.LookUpEdit()
            Me.txtTelefono = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
            Me.txtNoEntrega = New DevExpress.XtraEditors.TextEdit()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.etTasa = New DevExpress.XtraEditors.TextEdit()
            Me.txtCondiciones = New DevExpress.XtraEditors.TextEdit()
            Me.Label31 = New System.Windows.Forms.Label()
            Me.txtremision = New DevExpress.XtraEditors.TextEdit()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.txtorden = New DevExpress.XtraEditors.TextEdit()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.cbCultivos = New DevExpress.XtraEditors.LookUpEdit()
            Me.cmbmoneda = New DevExpress.XtraEditors.LookUpEdit()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.rbAmbos = New System.Windows.Forms.RadioButton()
            Me.rbProductos = New System.Windows.Forms.RadioButton()
            Me.rbServicios = New System.Windows.Forms.RadioButton()
            Me.cbMunicipios = New System.Windows.Forms.ComboBox()
            Me.cbDepartamentos = New System.Windows.Forms.ComboBox()
            Me.dgFactura = New DevExpress.XtraGrid.GridControl()
            Me.vFactura = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.cbTipoFactura = New System.Windows.Forms.ComboBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.etSaldoT = New System.Windows.Forms.Label()
            Me.etSaldo = New System.Windows.Forms.Label()
            Me.txtVendedor = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.etSubTotal = New System.Windows.Forms.Label()
            Me.etSubTotalT = New System.Windows.Forms.Label()
            Me.etIva = New System.Windows.Forms.Label()
            Me.etIvaT = New System.Windows.Forms.Label()
            Me.gbBotones = New System.Windows.Forms.GroupBox()
            Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdConsultaClientes = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdVerPagos = New DevExpress.XtraEditors.SimpleButton()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtDescuentoServicio = New System.Windows.Forms.TextBox()
            Me.txtDescuentoProducto = New System.Windows.Forms.TextBox()
            Me.TextBox5 = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.txtMunicipio = New System.Windows.Forms.TextBox()
            Me.txtDepartamento = New System.Windows.Forms.TextBox()
            Me.txtPais = New System.Windows.Forms.TextBox()
            Me.txtDireccion = New System.Windows.Forms.TextBox()
            Me.txtRuc = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.etTotalU = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.etTotal = New System.Windows.Forms.Label()
            Me.etTotalT = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtFactura = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox3.SuspendLayout()
            CType(Me.cbBodega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNoEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtCondiciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtremision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtorden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbCultivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.dgFactura, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vFactura, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbBotones.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtCliente
            '
            Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente.Location = New System.Drawing.Point(82, 8)
            Me.txtCliente.MaxLength = 50
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.ReadOnly = True
            Me.txtCliente.Size = New System.Drawing.Size(312, 20)
            Me.txtCliente.TabIndex = 155
            Me.txtCliente.Visible = False
            '
            'cbCliente
            '
            Me.cbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbCliente.Location = New System.Drawing.Point(82, 8)
            Me.cbCliente.Name = "cbCliente"
            Me.cbCliente.Size = New System.Drawing.Size(312, 21)
            Me.cbCliente.TabIndex = 146
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(616, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 25)
            Me.Label1.TabIndex = 148
            Me.Label1.Text = "Fecha:"
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.BackColor = System.Drawing.Color.Transparent
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label24.Location = New System.Drawing.Point(16, 8)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(60, 16)
            Me.Label24.TabIndex = 147
            Me.Label24.Text = "Cliente:"
            '
            'GroupBox3
            '
            Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox3.Controls.Add(Me.cbBodega)
            Me.GroupBox3.Controls.Add(Me.txtTelefono)
            Me.GroupBox3.Controls.Add(Me.Label3)
            Me.GroupBox3.Controls.Add(Me.Label17)
            Me.GroupBox3.Controls.Add(Me.cmdCancelar)
            Me.GroupBox3.Controls.Add(Me.txtNoEntrega)
            Me.GroupBox3.Controls.Add(Me.Label29)
            Me.GroupBox3.Controls.Add(Me.etTasa)
            Me.GroupBox3.Controls.Add(Me.txtCondiciones)
            Me.GroupBox3.Controls.Add(Me.Label31)
            Me.GroupBox3.Controls.Add(Me.txtremision)
            Me.GroupBox3.Controls.Add(Me.Label30)
            Me.GroupBox3.Controls.Add(Me.Label26)
            Me.GroupBox3.Controls.Add(Me.txtorden)
            Me.GroupBox3.Controls.Add(Me.Label28)
            Me.GroupBox3.Controls.Add(Me.cbCultivos)
            Me.GroupBox3.Controls.Add(Me.cmbmoneda)
            Me.GroupBox3.Controls.Add(Me.Label12)
            Me.GroupBox3.Controls.Add(Me.PanelControl1)
            Me.GroupBox3.Controls.Add(Me.cbMunicipios)
            Me.GroupBox3.Controls.Add(Me.cbDepartamentos)
            Me.GroupBox3.Controls.Add(Me.dgFactura)
            Me.GroupBox3.Controls.Add(Me.cbTipoFactura)
            Me.GroupBox3.Controls.Add(Me.Label19)
            Me.GroupBox3.Controls.Add(Me.Label25)
            Me.GroupBox3.Controls.Add(Me.etSaldoT)
            Me.GroupBox3.Controls.Add(Me.etSaldo)
            Me.GroupBox3.Controls.Add(Me.txtVendedor)
            Me.GroupBox3.Controls.Add(Me.Label10)
            Me.GroupBox3.Controls.Add(Me.etSubTotal)
            Me.GroupBox3.Controls.Add(Me.etSubTotalT)
            Me.GroupBox3.Controls.Add(Me.etIva)
            Me.GroupBox3.Controls.Add(Me.etIvaT)
            Me.GroupBox3.Controls.Add(Me.gbBotones)
            Me.GroupBox3.Controls.Add(Me.GroupBox1)
            Me.GroupBox3.Controls.Add(Me.txtMunicipio)
            Me.GroupBox3.Controls.Add(Me.txtDepartamento)
            Me.GroupBox3.Controls.Add(Me.txtPais)
            Me.GroupBox3.Controls.Add(Me.txtDireccion)
            Me.GroupBox3.Controls.Add(Me.txtRuc)
            Me.GroupBox3.Controls.Add(Me.Label5)
            Me.GroupBox3.Controls.Add(Me.Label6)
            Me.GroupBox3.Controls.Add(Me.Label2)
            Me.GroupBox3.Controls.Add(Me.Label9)
            Me.GroupBox3.Controls.Add(Me.Label4)
            Me.GroupBox3.Controls.Add(Me.etTotalU)
            Me.GroupBox3.Controls.Add(Me.Label18)
            Me.GroupBox3.Controls.Add(Me.etTotal)
            Me.GroupBox3.Controls.Add(Me.etTotalT)
            Me.GroupBox3.Location = New System.Drawing.Point(16, 27)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(992, 527)
            Me.GroupBox3.TabIndex = 149
            Me.GroupBox3.TabStop = False
            '
            'cbBodega
            '
            Me.cbBodega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbBodega.EnterMoveNextControl = True
            Me.cbBodega.Location = New System.Drawing.Point(759, 92)
            Me.cbBodega.Name = "cbBodega"
            Me.cbBodega.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
            Me.cbBodega.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.cbBodega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbBodega.Properties.NullText = ""
            Me.cbBodega.Properties.ReadOnly = True
            Me.cbBodega.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
            Me.cbBodega.Properties.ShowFooter = False
            Me.cbBodega.Properties.ShowHeader = False
            Me.cbBodega.Size = New System.Drawing.Size(224, 20)
            Me.cbBodega.TabIndex = 196
            '
            'txtTelefono
            '
            Me.txtTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono.Location = New System.Drawing.Point(176, 264)
            Me.txtTelefono.MaxLength = 50
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.ReadOnly = True
            Me.txtTelefono.Size = New System.Drawing.Size(224, 20)
            Me.txtTelefono.TabIndex = 123
            Me.txtTelefono.Visible = False
            '
            'Label3
            '
            Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(109, 271)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(61, 13)
            Me.Label3.TabIndex = 103
            Me.Label3.Text = "Teléfono:"
            Me.Label3.Visible = False
            '
            'Label17
            '
            Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.Label17.Location = New System.Drawing.Point(662, 144)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(93, 13)
            Me.Label17.TabIndex = 194
            Me.Label17.Text = "Orden Entrega:"
            '
            'cmdCancelar
            '
            Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar.Appearance.Options.UseFont = True
            Me.cmdCancelar.Appearance.Options.UseForeColor = True
            Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
            Me.cmdCancelar.Location = New System.Drawing.Point(888, 435)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(95, 35)
            Me.cmdCancelar.TabIndex = 29
            Me.cmdCancelar.Text = "&Salir"
            '
            'txtNoEntrega
            '
            Me.txtNoEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtNoEntrega.EnterMoveNextControl = True
            Me.txtNoEntrega.Location = New System.Drawing.Point(759, 139)
            Me.txtNoEntrega.Name = "txtNoEntrega"
            Me.txtNoEntrega.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
            Me.txtNoEntrega.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtNoEntrega.Properties.MaxLength = 254
            Me.txtNoEntrega.Properties.ReadOnly = True
            Me.txtNoEntrega.Size = New System.Drawing.Size(120, 20)
            Me.txtNoEntrega.TabIndex = 195
            Me.txtNoEntrega.TabStop = False
            '
            'Label29
            '
            Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label29.AutoSize = True
            Me.Label29.BackColor = System.Drawing.Color.Transparent
            Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label29.Location = New System.Drawing.Point(885, 125)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(66, 13)
            Me.Label29.TabIndex = 193
            Me.Label29.Text = "T/Cambio:"
            '
            'etTasa
            '
            Me.etTasa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.etTasa.EditValue = 1
            Me.etTasa.EnterMoveNextControl = True
            Me.etTasa.Location = New System.Drawing.Point(888, 141)
            Me.etTasa.Name = "etTasa"
            Me.etTasa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
            Me.etTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTasa.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
            Me.etTasa.Properties.Appearance.Options.UseBackColor = True
            Me.etTasa.Properties.Appearance.Options.UseFont = True
            Me.etTasa.Properties.Appearance.Options.UseForeColor = True
            Me.etTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
            Me.etTasa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTasa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
            Me.etTasa.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.etTasa.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.etTasa.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.etTasa.Properties.Mask.EditMask = "n4"
            Me.etTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.etTasa.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.etTasa.Properties.ReadOnly = True
            Me.etTasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.etTasa.Size = New System.Drawing.Size(95, 20)
            Me.etTasa.TabIndex = 192
            '
            'txtCondiciones
            '
            Me.txtCondiciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtCondiciones.EnterMoveNextControl = True
            Me.txtCondiciones.Location = New System.Drawing.Point(759, 116)
            Me.txtCondiciones.Name = "txtCondiciones"
            Me.txtCondiciones.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
            Me.txtCondiciones.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtCondiciones.Properties.MaxLength = 254
            Me.txtCondiciones.Properties.ReadOnly = True
            Me.txtCondiciones.Size = New System.Drawing.Size(120, 20)
            Me.txtCondiciones.TabIndex = 191
            Me.txtCondiciones.TabStop = False
            '
            'Label31
            '
            Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label31.AutoSize = True
            Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.Label31.Location = New System.Drawing.Point(675, 123)
            Me.Label31.Name = "Label31"
            Me.Label31.Size = New System.Drawing.Size(80, 13)
            Me.Label31.TabIndex = 188
            Me.Label31.Text = "Condiciones:"
            '
            'txtremision
            '
            Me.txtremision.EnterMoveNextControl = True
            Me.txtremision.Location = New System.Drawing.Point(376, 139)
            Me.txtremision.Name = "txtremision"
            Me.txtremision.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
            Me.txtremision.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtremision.Properties.MaxLength = 254
            Me.txtremision.Properties.ReadOnly = True
            Me.txtremision.Size = New System.Drawing.Size(88, 20)
            Me.txtremision.TabIndex = 189
            Me.txtremision.TabStop = False
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.Label30.Location = New System.Drawing.Point(305, 146)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(62, 13)
            Me.Label30.TabIndex = 187
            Me.Label30.Text = "Remisión:"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.Label26.Location = New System.Drawing.Point(474, 146)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(38, 13)
            Me.Label26.TabIndex = 186
            Me.Label26.Text = "O/C :"
            '
            'txtorden
            '
            Me.txtorden.EnterMoveNextControl = True
            Me.txtorden.Location = New System.Drawing.Point(518, 139)
            Me.txtorden.Name = "txtorden"
            Me.txtorden.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
            Me.txtorden.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtorden.Properties.MaxLength = 254
            Me.txtorden.Properties.ReadOnly = True
            Me.txtorden.Size = New System.Drawing.Size(88, 20)
            Me.txtorden.TabIndex = 190
            Me.txtorden.TabStop = False
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.Label28.Location = New System.Drawing.Point(288, 121)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(79, 13)
            Me.Label28.TabIndex = 185
            Me.Label28.Text = "Tipo Cultivo:"
            '
            'cbCultivos
            '
            Me.cbCultivos.EnterMoveNextControl = True
            Me.cbCultivos.Location = New System.Drawing.Point(376, 114)
            Me.cbCultivos.Name = "cbCultivos"
            Me.cbCultivos.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
            Me.cbCultivos.Properties.AppearanceReadOnly.Options.UseBackColor = True
            EditorButtonImageOptions1.EnableTransparency = False
            ToolTipItem1.Text = "Agrear Tipo de Cultivo"
            SuperToolTip1.Items.Add(ToolTipItem1)
            Me.cbCultivos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, SuperToolTip1)})
            Me.cbCultivos.Properties.NullText = ""
            Me.cbCultivos.Properties.ReadOnly = True
            Me.cbCultivos.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
            Me.cbCultivos.Properties.ShowFooter = False
            Me.cbCultivos.Properties.ShowHeader = False
            Me.cbCultivos.Size = New System.Drawing.Size(280, 20)
            Me.cbCultivos.TabIndex = 184
            '
            'cmbmoneda
            '
            Me.cmbmoneda.EnterMoveNextControl = True
            Me.cmbmoneda.Location = New System.Drawing.Point(376, 88)
            Me.cmbmoneda.Name = "cmbmoneda"
            Me.cmbmoneda.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
            Me.cmbmoneda.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.cmbmoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbmoneda.Properties.NullText = ""
            Me.cmbmoneda.Properties.ReadOnly = True
            Me.cmbmoneda.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
            Me.cmbmoneda.Properties.ShowFooter = False
            Me.cmbmoneda.Properties.ShowHeader = False
            Me.cmbmoneda.Size = New System.Drawing.Size(280, 20)
            Me.cmbmoneda.TabIndex = 145
            Me.cmbmoneda.TabStop = False
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
            Me.Label12.Location = New System.Drawing.Point(314, 95)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(56, 13)
            Me.Label12.TabIndex = 144
            Me.Label12.Text = "Moneda:"
            '
            'PanelControl1
            '
            Me.PanelControl1.Controls.Add(Me.rbAmbos)
            Me.PanelControl1.Controls.Add(Me.rbProductos)
            Me.PanelControl1.Controls.Add(Me.rbServicios)
            Me.PanelControl1.Location = New System.Drawing.Point(11, 111)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(256, 28)
            Me.PanelControl1.TabIndex = 143
            '
            'rbAmbos
            '
            Me.rbAmbos.AutoSize = True
            Me.rbAmbos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbAmbos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbAmbos.Location = New System.Drawing.Point(185, 5)
            Me.rbAmbos.Name = "rbAmbos"
            Me.rbAmbos.Size = New System.Drawing.Size(68, 19)
            Me.rbAmbos.TabIndex = 126
            Me.rbAmbos.Text = "Ambos"
            '
            'rbProductos
            '
            Me.rbProductos.AutoSize = True
            Me.rbProductos.Checked = True
            Me.rbProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbProductos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbProductos.Location = New System.Drawing.Point(5, 5)
            Me.rbProductos.Name = "rbProductos"
            Me.rbProductos.Size = New System.Drawing.Size(89, 19)
            Me.rbProductos.TabIndex = 124
            Me.rbProductos.TabStop = True
            Me.rbProductos.Text = "Productos"
            '
            'rbServicios
            '
            Me.rbServicios.AutoSize = True
            Me.rbServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbServicios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.rbServicios.Location = New System.Drawing.Point(95, 5)
            Me.rbServicios.Name = "rbServicios"
            Me.rbServicios.Size = New System.Drawing.Size(83, 19)
            Me.rbServicios.TabIndex = 125
            Me.rbServicios.Text = "Servicios"
            '
            'cbMunicipios
            '
            Me.cbMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
            Me.cbMunicipios.Enabled = False
            Me.cbMunicipios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbMunicipios.Location = New System.Drawing.Point(597, 248)
            Me.cbMunicipios.Name = "cbMunicipios"
            Me.cbMunicipios.Size = New System.Drawing.Size(45, 23)
            Me.cbMunicipios.TabIndex = 121
            Me.cbMunicipios.Visible = False
            '
            'cbDepartamentos
            '
            Me.cbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
            Me.cbDepartamentos.Enabled = False
            Me.cbDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbDepartamentos.Location = New System.Drawing.Point(648, 249)
            Me.cbDepartamentos.Name = "cbDepartamentos"
            Me.cbDepartamentos.Size = New System.Drawing.Size(56, 22)
            Me.cbDepartamentos.TabIndex = 119
            Me.cbDepartamentos.Visible = False
            '
            'dgFactura
            '
            Me.dgFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgFactura.Location = New System.Drawing.Point(11, 165)
            Me.dgFactura.MainView = Me.vFactura
            Me.dgFactura.Name = "dgFactura"
            Me.dgFactura.Size = New System.Drawing.Size(868, 305)
            Me.dgFactura.TabIndex = 142
            Me.dgFactura.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vFactura})
            '
            'vFactura
            '
            Me.vFactura.GridControl = Me.dgFactura
            Me.vFactura.Name = "vFactura"
            Me.vFactura.OptionsView.ShowFooter = True
            Me.vFactura.OptionsView.ShowGroupPanel = False
            '
            'cbTipoFactura
            '
            Me.cbTipoFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbTipoFactura.Enabled = False
            Me.cbTipoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbTipoFactura.Location = New System.Drawing.Point(759, 66)
            Me.cbTipoFactura.Name = "cbTipoFactura"
            Me.cbTipoFactura.Size = New System.Drawing.Size(224, 21)
            Me.cbTipoFactura.TabIndex = 140
            '
            'Label19
            '
            Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label19.AutoSize = True
            Me.Label19.BackColor = System.Drawing.Color.Transparent
            Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label19.Location = New System.Drawing.Point(699, 99)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(54, 13)
            Me.Label19.TabIndex = 141
            Me.Label19.Text = "Bodega:"
            '
            'Label25
            '
            Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label25.AutoSize = True
            Me.Label25.BackColor = System.Drawing.Color.Transparent
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(657, 72)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(96, 13)
            Me.Label25.TabIndex = 141
            Me.Label25.Text = "Forma de Pago:"
            '
            'etSaldoT
            '
            Me.etSaldoT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.etSaldoT.BackColor = System.Drawing.Color.Transparent
            Me.etSaldoT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSaldoT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etSaldoT.Location = New System.Drawing.Point(14, 473)
            Me.etSaldoT.Name = "etSaldoT"
            Me.etSaldoT.Size = New System.Drawing.Size(56, 26)
            Me.etSaldoT.TabIndex = 139
            Me.etSaldoT.Text = "Saldo:"
            Me.etSaldoT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etSaldo
            '
            Me.etSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.etSaldo.BackColor = System.Drawing.Color.Transparent
            Me.etSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSaldo.ForeColor = System.Drawing.Color.Black
            Me.etSaldo.Location = New System.Drawing.Point(78, 473)
            Me.etSaldo.Name = "etSaldo"
            Me.etSaldo.Size = New System.Drawing.Size(96, 26)
            Me.etSaldo.TabIndex = 138
            Me.etSaldo.Text = "0.00"
            Me.etSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtVendedor
            '
            Me.txtVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtVendedor.Location = New System.Drawing.Point(759, 40)
            Me.txtVendedor.MaxLength = 50
            Me.txtVendedor.Name = "txtVendedor"
            Me.txtVendedor.ReadOnly = True
            Me.txtVendedor.Size = New System.Drawing.Size(224, 20)
            Me.txtVendedor.TabIndex = 136
            '
            'Label10
            '
            Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label10.AutoSize = True
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label10.Location = New System.Drawing.Point(688, 47)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(65, 13)
            Me.Label10.TabIndex = 135
            Me.Label10.Text = "Vendedor:"
            '
            'etSubTotal
            '
            Me.etSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.etSubTotal.BackColor = System.Drawing.Color.Transparent
            Me.etSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etSubTotal.Location = New System.Drawing.Point(278, 473)
            Me.etSubTotal.Name = "etSubTotal"
            Me.etSubTotal.Size = New System.Drawing.Size(112, 26)
            Me.etSubTotal.TabIndex = 134
            Me.etSubTotal.Text = "0.00"
            Me.etSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etSubTotalT
            '
            Me.etSubTotalT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.etSubTotalT.BackColor = System.Drawing.Color.Transparent
            Me.etSubTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etSubTotalT.Location = New System.Drawing.Point(190, 473)
            Me.etSubTotalT.Name = "etSubTotalT"
            Me.etSubTotalT.Size = New System.Drawing.Size(80, 26)
            Me.etSubTotalT.TabIndex = 133
            Me.etSubTotalT.Text = "Sub Total:"
            Me.etSubTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etIva
            '
            Me.etIva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.etIva.BackColor = System.Drawing.Color.Transparent
            Me.etIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIva.ForeColor = System.Drawing.Color.Maroon
            Me.etIva.Location = New System.Drawing.Point(502, 473)
            Me.etIva.Name = "etIva"
            Me.etIva.Size = New System.Drawing.Size(112, 26)
            Me.etIva.TabIndex = 132
            Me.etIva.Text = "0.00"
            Me.etIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etIvaT
            '
            Me.etIvaT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.etIvaT.BackColor = System.Drawing.Color.Transparent
            Me.etIvaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIvaT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etIvaT.Location = New System.Drawing.Point(398, 473)
            Me.etIvaT.Name = "etIvaT"
            Me.etIvaT.Size = New System.Drawing.Size(96, 26)
            Me.etIvaT.TabIndex = 131
            Me.etIvaT.Text = "IVA:"
            Me.etIvaT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'gbBotones
            '
            Me.gbBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gbBotones.BackColor = System.Drawing.Color.Transparent
            Me.gbBotones.Controls.Add(Me.cmdGuardar)
            Me.gbBotones.Controls.Add(Me.cmdAyuda)
            Me.gbBotones.Controls.Add(Me.cmdConsultaClientes)
            Me.gbBotones.Controls.Add(Me.cmdImprimir)
            Me.gbBotones.Controls.Add(Me.cmdVerPagos)
            Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBotones.ForeColor = System.Drawing.Color.Maroon
            Me.gbBotones.Location = New System.Drawing.Point(888, 165)
            Me.gbBotones.Name = "gbBotones"
            Me.gbBotones.Size = New System.Drawing.Size(88, 259)
            Me.gbBotones.TabIndex = 130
            Me.gbBotones.TabStop = False
            Me.gbBotones.Visible = False
            '
            'cmdGuardar
            '
            Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdGuardar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdGuardar.Appearance.Options.UseFont = True
            Me.cmdGuardar.Appearance.Options.UseForeColor = True
            Me.cmdGuardar.Location = New System.Drawing.Point(8, 17)
            Me.cmdGuardar.Name = "cmdGuardar"
            Me.cmdGuardar.Size = New System.Drawing.Size(72, 35)
            Me.cmdGuardar.TabIndex = 128
            Me.cmdGuardar.Text = "&Guardar"
            '
            'cmdAyuda
            '
            Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAyuda.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdAyuda.Appearance.Options.UseFont = True
            Me.cmdAyuda.Appearance.Options.UseForeColor = True
            Me.cmdAyuda.Location = New System.Drawing.Point(8, 99)
            Me.cmdAyuda.Name = "cmdAyuda"
            Me.cmdAyuda.Size = New System.Drawing.Size(72, 34)
            Me.cmdAyuda.TabIndex = 127
            Me.cmdAyuda.Text = "&Ayuda"
            '
            'cmdConsultaClientes
            '
            Me.cmdConsultaClientes.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdConsultaClientes.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdConsultaClientes.Appearance.Options.UseFont = True
            Me.cmdConsultaClientes.Appearance.Options.UseForeColor = True
            Me.cmdConsultaClientes.Location = New System.Drawing.Point(8, 179)
            Me.cmdConsultaClientes.Name = "cmdConsultaClientes"
            Me.cmdConsultaClientes.Size = New System.Drawing.Size(72, 34)
            Me.cmdConsultaClientes.TabIndex = 33
            Me.cmdConsultaClientes.Text = "C&lientes"
            Me.cmdConsultaClientes.Visible = False
            '
            'cmdImprimir
            '
            Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdImprimir.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdImprimir.Appearance.Options.UseFont = True
            Me.cmdImprimir.Appearance.Options.UseForeColor = True
            Me.cmdImprimir.Location = New System.Drawing.Point(8, 139)
            Me.cmdImprimir.Name = "cmdImprimir"
            Me.cmdImprimir.Size = New System.Drawing.Size(72, 34)
            Me.cmdImprimir.TabIndex = 30
            Me.cmdImprimir.Text = "&Imprimir"
            Me.cmdImprimir.Visible = False
            '
            'cmdVerPagos
            '
            Me.cmdVerPagos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdVerPagos.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdVerPagos.Appearance.Options.UseFont = True
            Me.cmdVerPagos.Appearance.Options.UseForeColor = True
            Me.cmdVerPagos.Location = New System.Drawing.Point(8, 58)
            Me.cmdVerPagos.Name = "cmdVerPagos"
            Me.cmdVerPagos.Size = New System.Drawing.Size(72, 35)
            Me.cmdVerPagos.TabIndex = 126
            Me.cmdVerPagos.Text = "&Ver Pagos"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
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
            Me.GroupBox1.Location = New System.Drawing.Point(11, 62)
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
            Me.txtDescuentoServicio.Location = New System.Drawing.Point(208, 17)
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
            Me.txtDescuentoProducto.Location = New System.Drawing.Point(96, 17)
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
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label8.Location = New System.Drawing.Point(8, 17)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(72, 17)
            Me.Label8.TabIndex = 115
            Me.Label8.Text = "Productos"
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.Transparent
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label13.Location = New System.Drawing.Point(144, 17)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(64, 17)
            Me.Label13.TabIndex = 102
            Me.Label13.Text = "Servicios"
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
            Me.txtMunicipio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMunicipio.Location = New System.Drawing.Point(759, 14)
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
            Me.txtDepartamento.Location = New System.Drawing.Point(376, 62)
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
            Me.txtPais.Location = New System.Drawing.Point(51, 36)
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
            Me.txtDireccion.Location = New System.Drawing.Point(376, 13)
            Me.txtDireccion.MaxLength = 50
            Me.txtDireccion.Multiline = True
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.ReadOnly = True
            Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDireccion.Size = New System.Drawing.Size(280, 43)
            Me.txtDireccion.TabIndex = 124
            '
            'txtRuc
            '
            Me.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRuc.Location = New System.Drawing.Point(51, 10)
            Me.txtRuc.MaxLength = 50
            Me.txtRuc.Name = "txtRuc"
            Me.txtRuc.ReadOnly = True
            Me.txtRuc.Size = New System.Drawing.Size(216, 20)
            Me.txtRuc.TabIndex = 122
            '
            'Label5
            '
            Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(688, 21)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(65, 13)
            Me.Label5.TabIndex = 120
            Me.Label5.Text = "Municipio:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(8, 43)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(37, 13)
            Me.Label6.TabIndex = 115
            Me.Label6.Text = "País:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(305, 24)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(65, 13)
            Me.Label2.TabIndex = 101
            Me.Label2.Text = "Dirección:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label9.Location = New System.Drawing.Point(8, 17)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(37, 13)
            Me.Label9.TabIndex = 100
            Me.Label9.Text = "RUC:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(280, 69)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(90, 13)
            Me.Label4.TabIndex = 102
            Me.Label4.Text = "Departamento:"
            '
            'etTotalU
            '
            Me.etTotalU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.etTotalU.BackColor = System.Drawing.Color.Transparent
            Me.etTotalU.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalU.ForeColor = System.Drawing.Color.Maroon
            Me.etTotalU.Location = New System.Drawing.Point(690, 496)
            Me.etTotalU.Name = "etTotalU"
            Me.etTotalU.Size = New System.Drawing.Size(166, 26)
            Me.etTotalU.TabIndex = 110
            Me.etTotalU.Text = "0.00"
            Me.etTotalU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label18
            '
            Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label18.BackColor = System.Drawing.Color.Transparent
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label18.Location = New System.Drawing.Point(592, 499)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(88, 26)
            Me.Label18.TabIndex = 109
            Me.Label18.Text = "Total U$:"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etTotal
            '
            Me.etTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.etTotal.BackColor = System.Drawing.Color.Transparent
            Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etTotal.Location = New System.Drawing.Point(688, 470)
            Me.etTotal.Name = "etTotal"
            Me.etTotal.Size = New System.Drawing.Size(168, 26)
            Me.etTotal.TabIndex = 110
            Me.etTotal.Text = "0.00"
            Me.etTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etTotalT
            '
            Me.etTotalT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.etTotalT.BackColor = System.Drawing.Color.Transparent
            Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etTotalT.Location = New System.Drawing.Point(622, 473)
            Me.etTotalT.Name = "etTotalT"
            Me.etTotalT.Size = New System.Drawing.Size(56, 26)
            Me.etTotalT.TabIndex = 109
            Me.etTotalT.Text = "Total:"
            Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label11.Location = New System.Drawing.Point(792, 8)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(119, 25)
            Me.Label11.TabIndex = 152
            Me.Label11.Text = "Fecha de Pago:"
            '
            'txtFactura
            '
            Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Location = New System.Drawing.Point(480, 8)
            Me.txtFactura.MaxLength = 50
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.ReadOnly = True
            Me.txtFactura.Size = New System.Drawing.Size(128, 20)
            Me.txtFactura.TabIndex = 151
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(400, 10)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(74, 13)
            Me.Label7.TabIndex = 150
            Me.Label7.Text = "No. Factura"
            '
            'dtpFechaPago
            '
            Me.dtpFechaPago.Enabled = False
            Me.dtpFechaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaPago.Location = New System.Drawing.Point(912, 8)
            Me.dtpFechaPago.Name = "dtpFechaPago"
            Me.dtpFechaPago.Size = New System.Drawing.Size(96, 20)
            Me.dtpFechaPago.TabIndex = 154
            '
            'dtpFecha
            '
            Me.dtpFecha.Enabled = False
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(680, 8)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 153
            '
            'frmFacturacionClienteVer
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1024, 561)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtCliente)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.txtFactura)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.dtpFechaPago)
            Me.Controls.Add(Me.dtpFecha)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.cbCliente)
            Me.KeyPreview = True
            Me.Name = "frmFacturacionClienteVer"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            CType(Me.cbBodega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNoEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtCondiciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtremision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtorden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbCultivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.dgFactura, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vFactura, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbBotones.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Dim Clientes As New VB.SysContab.ClientesDB()
        Dim DetallesCliente As New VB.SysContab.ClientesDetails()
        Dim DetallesVendedor As New VB.SysContab.VendedoresDetails()
        Dim Vendedor As New VB.SysContab.VendedoresDB()
        Dim Departamentos As New VB.SysContab.DepartamentosCDB()
        Dim Municipios As New VB.SysContab.MunicipiosDB()
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()
        Dim r As New VB.SysContab.Rutinas()

        Dim ds As DataTable

        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet

        Dim i As Integer

        Dim SubTotalFacturaClienteV As Double = 0
        Dim SubTotalFacturaNoDescuentosV As Double = 0
        Dim TotalFacturaClienteV As Double = 0
        Dim TotalDescuentoV As Double = 0
        Dim Iva As Double = 0

        Private Sub frmFacturacionClienteVer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
            If e.KeyCode = Keys.Escape Then Close()
            If e.KeyCode = Keys.F3 Then vFactura.ShowCustomization()
        End Sub


        Private Sub frmFacturacionClienteVer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' r.FormularioColor(Me)

            Me.Text = "Factura de Venta Detalle"

            GetMonedasList(cmbmoneda)
            GetTipoCultivo(Me.cbCultivos)
            GetBodegasList(cbBodega)

            'ds = Clientes.FacturaDetalle(Registro)
            ds = ObtieneDatos("_FacturaDetalle '" & Registro & "'," & EmpresaActual)

            cbCliente.DataSource = Clientes.ClientesList().Tables("Clientes")
            cbCliente.ValueMember = "Codigo"
            cbCliente.DisplayMember = "Nombre"

            cbTipoFactura.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
            cbTipoFactura.ValueMember = "Codigo"
            cbTipoFactura.DisplayMember = "Nombre"

            'dgFacturacionCliente.ReadOnly = True
            cbCliente.Enabled = False

            If ds.Rows(0).Item("Cliente") = "9999" Then
                txtCliente.Text = ds.Rows(0).Item("Nombre_Cliente").ToString
                txtCliente.Visible = True
            Else
                txtCliente.Visible = False
                cbCliente.SelectedValue = ds.Rows(0).Item("Cliente")
                Me.cbCliente_SelectedValueChanged(Nothing, Nothing)
            End If

            cbTipoFactura.SelectedValue = ds.Rows(0).Item("Tipo_Factura")
            'cbTipoFactura.Enabled = False

            Cod_Cliente = ds.Rows(0).Item("Cliente")
            dtpFecha.Value = ds.Rows(0).Item("Fecha")
            'dtpFecha.Enabled = False

            dtpFechaPago.Value = ds.Rows(0).Item("Fecha Pago")
            'dtpFechaPago.Enabled = False

            txtFactura.Text = ds.Rows(0).Item("Factura")
            txtFactura.ReadOnly = True

            If ds.Rows(0).Item("Tipo") = 0 Then
                rbProductos.Checked = True
            ElseIf ds.Rows(0).Item("Tipo") = 1 Then
                rbServicios.Checked = True
            Else
                rbAmbos.Checked = True
            End If

            PanelControl1.Enabled = False

            SubTotalFacturaClienteV = 0
            SubTotalFacturaNoDescuentosV = 0
            TotalFacturaClienteV = 0
            TotalDescuentoV = 0

            Cargar()

            'MakeDataSet()
            'dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            'AddCustomDataTableStyle()

            '

            'For i = 0 To tCust.Rows.Count - 1

            '    If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then

            '    ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
            '        Try
            '            SubTotalFacturaClienteV = SubTotalFacturaClienteV + tCust.Rows(i)("SubTotal")
            '            SubTotalFacturaNoDescuentosV = SubTotalFacturaNoDescuentosV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
            '            TotalDescuentoV = TotalDescuentoV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)
            '            Iva = Iva + tCust.Rows(i)("Iva")
            '        Catch ex As Exception
            '            MsgBox(ex.Message)

            '        End Try

            '    End If

            'Next

            'etSubTotal.Text = SubTotalFacturaClienteV.ToString(Round)
            'etIva.Text = Iva.ToString(Round) '(SubTotalFacturaNoDescuentosV * 0.15).ToString(Round)
            'etTotal.Text = (SubTotalFacturaClienteV + CDbl(etIva.Text)).ToString(Round)

            'etSaldo.Text = (CDbl(etTotal.Text) - TotalGlobal).ToString(Round)
            '
            etSaldo.Text = CDbl(ds.Rows(0).Item("Saldo")).ToString(Round)
            etSaldo.Refresh()
        End Sub

        Sub Cargar()

            Me.dgFactura.DataSource = ds
            Me.vFactura.PopulateColumns()
            FormatoGrid(Me.vFactura, 4, 0, False, False, False)
            '
            For i As Integer = 0 To Me.vFactura.Columns.Count - 1
                Me.vFactura.Columns(i).Visible = False
            Next
            '
            Me.vFactura.Columns("Item").Visible = True
            Me.vFactura.Columns("Descripcion").Visible = True
            Me.vFactura.Columns("Cantidad").Visible = True
            Me.vFactura.Columns("Precio").Visible = True
            Me.vFactura.Columns("Iva").Visible = True
            Me.vFactura.Columns("Descuento").Visible = True
            Me.vFactura.Columns("Total").Visible = True
            '
            Me.vFactura.Columns("Item").VisibleIndex = 0
            Me.vFactura.Columns("Descripcion").VisibleIndex = 1
            Me.vFactura.Columns("Comentario").VisibleIndex = 2
            Me.vFactura.Columns("Cantidad").VisibleIndex = 3
            Me.vFactura.Columns("Precio").VisibleIndex = 4
            Me.vFactura.Columns("Iva").VisibleIndex = 5
            Me.vFactura.Columns("Descuento").VisibleIndex = 6
            Me.vFactura.Columns("Total").VisibleIndex = 7

            Me.vFactura.Columns("Descripcion").Caption = "Descripción"
            Me.vFactura.Columns("Iva").Caption = "IVA"
            Me.vFactura.Columns("Total").Caption = "Sub Total"
            '
            Me.vFactura.Columns("Cantidad").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vFactura.Columns("Cantidad").DisplayFormat.FormatString = "{0:n4}"
            '
            Me.vFactura.Columns("Precio").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vFactura.Columns("Precio").DisplayFormat.FormatString = "{0:n6}"
            '
            Me.vFactura.Columns("Iva").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vFactura.Columns("Iva").DisplayFormat.FormatString = "{0:n2}"
            Me.vFactura.Columns("Iva").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vFactura.Columns("Iva").SummaryItem.DisplayFormat = "{0:n2}"
            '
            Me.vFactura.Columns("Descuento").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vFactura.Columns("Descuento").DisplayFormat.FormatString = "{0:n2}"
            Me.vFactura.Columns("Descuento").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vFactura.Columns("Descuento").SummaryItem.DisplayFormat = "{0:n2}"
            '
            Me.vFactura.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vFactura.Columns("Total").DisplayFormat.FormatString = "{0:n2}"
            Me.vFactura.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vFactura.Columns("Total").SummaryItem.DisplayFormat = "{0:n2}"

            Me.vFactura.OptionsBehavior.Editable = False
            Me.vFactura.BestFitColumns()
            '
            etSubTotal.Text = CDbl(Me.vFactura.Columns("Total").SummaryItem.SummaryValue).ToString(Round)
            etIva.Text = CDbl(Me.vFactura.Columns("Iva").SummaryItem.SummaryValue).ToString(Round)
            etTotal.Text = CDbl(CDbl(etSubTotal.Text) + CDbl(etIva.Text)).ToString(Round)
            '
            SubTotalFacturaClienteV = CDbl(etSubTotal.Text)
            SubTotalFacturaNoDescuentosV = CDbl(etSubTotal.Text) 'SubTotalFacturaNoDescuentosV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
            TotalDescuentoV = CDbl(Me.vFactura.Columns("Descuento").SummaryItem.SummaryValue).ToString(Round) 'TotalDescuentoV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)
            Iva = CDbl(Me.vFactura.Columns("Iva").SummaryItem.SummaryValue).ToString(Round)
            ''
            cmbmoneda.EditValue = ds.Rows.Item(0)("mon_mtto")
            cbCultivos.EditValue = ds.Rows.Item(0)("Cultivo")
            cbBodega.EditValue = ds.Rows.Item(0)("Bodega")
            txtremision.Text = IsNull(ds.Rows.Item(0)("Remision"), "")
            txtorden.Text = IsNull(ds.Rows.Item(0)("Orden"), "")
            txtNoEntrega.Text = IsNull(ds.Rows.Item(0)("OrdenEntrega"), "")
            txtCondiciones.Text = IsNull(ds.Rows.Item(0)("Condiciones"), "")
            etTasa.Text = CDbl(ds.Rows.Item(0)("TASA_CAMBIO")).ToString("n4")

            ''
            etTotalU.Text = CDbl(CDbl(etTotal.Text) / CDbl(etTasa.Text)).ToString(Round)
        End Sub

        'Private Sub MakeDataSet()

        '    myDataSet = New DataSet("myDataSet")

        '    tCust = New DataTable("Articulos")

        '    Dim cArticuloCodigo As DataColumn
        '    cArticuloCodigo = New DataColumn("ArticuloCodigo")

        '    Dim cArticulo As DataColumn
        '    cArticulo = New DataColumn("Articulo")

        '    Dim cCantidad As DataColumn
        '    cCantidad = New DataColumn("Cantidad")

        '    Dim cPrecio As DataColumn
        '    cPrecio = New DataColumn("Precio")

        '    Dim cDescuento As DataColumn
        '    cDescuento = New DataColumn("Descuento")

        '    Dim cSubTotal As DataColumn
        '    cSubTotal = New DataColumn("SubTotal")

        '    Dim cCodigoTemporal As DataColumn
        '    cCodigoTemporal = New DataColumn("CodigoTemporal")

        '    Dim cItemTipo As DataColumn
        '    cItemTipo = New DataColumn("Tipo")

        '    Dim cIva As DataColumn
        '    cIva = New DataColumn("Iva")

        '    tCust.Columns.Add(cArticuloCodigo)
        '    tCust.Columns.Add(cArticulo)
        '    tCust.Columns.Add(cCantidad)
        '    tCust.Columns.Add(cPrecio)
        '    tCust.Columns.Add(cDescuento)
        '    tCust.Columns.Add(cSubTotal)
        '    tCust.Columns.Add(cCodigoTemporal)
        '    tCust.Columns.Add(cItemTipo)
        '    tCust.Columns.Add(cIva)

        '    myDataSet.Tables.Add(tCust)

        '    Dim newRow1 As DataRow

        '    Dim j As Integer

        '    For j = 0 To ds.Tables("Facturas_Ventas").Rows.Count - 1
        '        newRow1 = tCust.NewRow
        '        newRow1("ArticuloCodigo") = ds.Tables("Facturas_Ventas").Rows(j).Item("Item")
        '        tCust.Rows.Add(newRow1)

        '        tCust.Rows(j)("CodigoTemporal") = ds.Tables("Facturas_Ventas").Rows(j).Item("Item")
        '        tCust.Rows(j)("Articulo") = ds.Tables("Facturas_Ventas").Rows(j).Item("Descripcion")
        '        tCust.Rows(j)("Cantidad") = ds.Tables("Facturas_Ventas").Rows(j).Item("Cantidad")
        '        tCust.Rows(j)("Precio") = CDbl(ds.Tables("Facturas_Ventas").Rows(j).Item("Precio")) '.ToString(Round)
        '        tCust.Rows(j)("Descuento") = CDbl(ds.Tables("Facturas_Ventas").Rows(j).Item("Descuento")) '.ToString(Round)
        '        tCust.Rows(j)("SubTotal") = (CDbl(CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio"))) - CDbl(CDbl(CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio")) * (CDbl(tCust.Rows(j)("Descuento")))) / 100.0)).ToString(Round)
        '        tCust.Rows(j)("Tipo") = ds.Tables("Facturas_Ventas").Rows(j).Item("Tipo_Item")
        '        tCust.Rows(j)("Iva") = CDbl(ds.Tables("Facturas_Ventas").Rows(j).Item("Iva")).ToString(Round)

        '        SubTotalFacturaClienteV = SubTotalFacturaClienteV + tCust.Rows(j)("SubTotal")
        '        SubTotalFacturaNoDescuentosV = SubTotalFacturaNoDescuentosV + (tCust.Rows(j)("Cantidad") * tCust.Rows(j)("Precio"))
        '        TotalDescuentoV = TotalDescuentoV + (tCust.Rows(j)("Cantidad") * tCust.Rows(j)("Precio") * tCust.Rows(j)("Descuento") / 100.0)

        '        Iva = Iva + tCust.Rows(j)("Iva")

        '    Next

        'End Sub


        'Private Sub AddCustomDataTableStyle()
        '    Dim ts1 As DataGridTableStyle
        '    ts1 = New DataGridTableStyle()

        '    ts1.MappingName = "Articulos"
        '    ts1.AlternatingBackColor = Color.LightBlue
        '    Dim colCount As Integer
        '    colCount = 0

        '    Dim ArticuloCodigo As DataGridTextBoxColumn
        '    ArticuloCodigo = New DataGridTextBoxColumn()
        '    ArticuloCodigo.MappingName = "ArticuloCodigo"
        '    ArticuloCodigo.HeaderText = "Código"
        '    ArticuloCodigo.Width = 100
        '    ArticuloCodigo.Alignment = HorizontalAlignment.Left
        '    ArticuloCodigo.ReadOnly = True
        '    ArticuloCodigo.Format = "##,###0.00"
        '    ts1.GridColumnStyles.Add(ArticuloCodigo)
        '    colCount = (colCount + 1)

        '    ArticuloCodigo.NullText = "0.00"


        '    Dim Articulo As DataGridTextBoxColumn
        '    Articulo = New DataGridTextBoxColumn()
        '    Articulo.MappingName = "Articulo"
        '    Articulo.HeaderText = "Descripcion"
        '    Articulo.Width = 300
        '    Articulo.Alignment = HorizontalAlignment.Left
        '    Articulo.ReadOnly = True
        '    Articulo.Format = "##,###0.00"
        '    ts1.GridColumnStyles.Add(Articulo)
        '    colCount = (colCount + 1)

        '    Articulo.NullText = "0.00"

        '    Dim Cantidad As DataGridTextBoxColumn
        '    Cantidad = New DataGridTextBoxColumn()
        '    Cantidad.MappingName = "Cantidad"
        '    Cantidad.HeaderText = "Cantidad"
        '    Cantidad.Width = 100
        '    Cantidad.Alignment = HorizontalAlignment.Right
        '    Cantidad.ReadOnly = False

        '    ts1.GridColumnStyles.Add(Cantidad)
        '    colCount = (colCount + 1)

        '    Cantidad.NullText = ""

        '    Dim Precio As DataGridTextBoxColumn
        '    Precio = New DataGridTextBoxColumn()
        '    Precio.MappingName = "Precio"
        '    Precio.HeaderText = "Precio"
        '    Precio.Width = 100
        '    Precio.Alignment = HorizontalAlignment.Right
        '    Precio.ReadOnly = True
        '    Precio.Format = "##,###0.00"
        '    ts1.GridColumnStyles.Add(Precio)
        '    colCount = (colCount + 1)

        '    Precio.NullText = "0.00"

        '    Dim Descuento As DataGridTextBoxColumn
        '    Descuento = New DataGridTextBoxColumn()
        '    Descuento.MappingName = "Descuento"
        '    Descuento.HeaderText = "Descuento %"
        '    Descuento.Width = 100
        '    Descuento.Alignment = HorizontalAlignment.Right
        '    Descuento.ReadOnly = False
        '    Descuento.Format = "##,###0.00"

        '    ts1.GridColumnStyles.Add(Descuento)
        '    colCount = (colCount + 1)

        '    Descuento.NullText = "0.00"

        '    Dim SubTotal As DataGridTextBoxColumn
        '    SubTotal = New DataGridTextBoxColumn()
        '    SubTotal.MappingName = "SubTotal"
        '    SubTotal.HeaderText = "Sub Total"
        '    SubTotal.Width = 100
        '    SubTotal.Alignment = HorizontalAlignment.Right
        '    SubTotal.ReadOnly = True
        '    SubTotal.Format = "##,###0.00"
        '    ts1.GridColumnStyles.Add(SubTotal)
        '    colCount = (colCount + 1)

        '    SubTotal.NullText = "0.00"

        '    Dim CodigoTemporal As DataGridTextBoxColumn
        '    CodigoTemporal = New DataGridTextBoxColumn()
        '    CodigoTemporal.MappingName = "CodigoTemporal"
        '    CodigoTemporal.HeaderText = "CodigoTemporal"
        '    CodigoTemporal.Width = 0
        '    CodigoTemporal.Alignment = HorizontalAlignment.Left
        '    CodigoTemporal.ReadOnly = True
        '    ts1.GridColumnStyles.Add(CodigoTemporal)
        '    colCount = (colCount + 1)

        '    CodigoTemporal.NullText = ""

        '    Dim ItemTipo As DataGridTextBoxColumn
        '    ItemTipo = New DataGridTextBoxColumn()
        '    ItemTipo.MappingName = "Tipo"
        '    ItemTipo.HeaderText = "Tipo"
        '    ItemTipo.Width = 0
        '    ItemTipo.ReadOnly = True

        '    ts1.GridColumnStyles.Add(ItemTipo)
        '    colCount = (colCount + 1)

        '    ItemTipo.NullText = ""

        '    Dim Iva As DataGridTextBoxColumn
        '    Iva = New DataGridTextBoxColumn()
        '    Iva.MappingName = "Iva"
        '    Iva.HeaderText = ""
        '    Iva.Width = 0
        '    Iva.ReadOnly = True

        '    ts1.GridColumnStyles.Add(Iva)
        '    colCount = (colCount + 1)

        '    Iva.NullText = "0.00"

        '    ts1.AllowSorting = False
        '    ts1.GridLineColor = Color.FromArgb(70, 130, 180)
        '    ts1.HeaderFont = dgFacturacionCliente.HeaderFont
        '    ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
        '    ts1.PreferredRowHeight = 25

        '    dgFacturacionCliente.CaptionVisible = False

        '    dgFacturacionCliente.TableStyles.Clear()
        '    dgFacturacionCliente.TableStyles.Add(ts1)

        'End Sub

        Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

        Private Sub cmdConsultaClientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdConsultaClientes.Click
            'If cbCliente.Text = "" Then
            '    MsgBox("Seleccione el Cliente", MsgBoxStyle.Information)
            '    Exit Sub
            'End If

            'If cbCliente.SelectedValue = Nothing Then
            '    MsgBox("El cliente no está registrado", MsgBoxStyle.Information)
            '    Exit Sub
            'End If

            If txtCliente.Visible = True Then
                MsgBox("El cliente no está registrado", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim f As frmAcumulados = f.Instance

            RegistroCliente = cbCliente.SelectedValue

            f.MdiParent = Me.MdiParent
            f.Show()
        End Sub

        Private Sub cmdVerPagos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdVerPagos.Click
            Registro = txtFactura.Text
            If Clientes.CobrosHistorial(txtFactura.Text).Tables("Cobros").Rows.Count = 0 Then
                MsgBox("La Factura seleccionada no tiene ningún pago", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim f As frmHistorialCobros = frmHistorialCobros.Instance()

            f.MdiParent = Me.MdiParent
            f.WindowState = FormWindowState.Maximized
            f.Show()
        End Sub

        Private Sub cbCliente_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCliente.SelectedValueChanged
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

            DetallesVendedor = Vendedor.GetDetails(ds.Rows(0).Item("Vendedor").ToString)
            txtVendedor.Text = DetallesVendedor.Nombre
            'TipoDescuento = DetallesCliente.Desc_Prod
        End Sub

        Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Try
                Clientes.FacturaUpdate(txtFactura.Text, dtpFecha.Value, Cod_Cliente, txtRuc.Text, etSubTotal.Text, _
                                    etTotal.Text, TotalDescuento, etIva.Text, "0", "0", etTotal.Text, etSaldo.Text, _
                                    DetallesCliente.Vendedor, dtpFechaPago.Value, dtpFechaPago.Value, 1, cbTipoFactura.SelectedValue, "")
                'TotalFactura - TotalGlobal, 
                VB.SysContab.Rutinas.okTransaccion()
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                VB.SysContab.Rutinas.ErrorTransaccion()
            End Try
        End Sub

        Private Sub cbTipoFactura_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoFactura.SelectedValueChanged
            Try
                If IsNumeric(cbTipoFactura.SelectedValue) Then
                    If Inicio = True Then
                        Exit Sub
                    End If

                    If cbTipoFactura.SelectedValue = 0 Then
                        'Dim f As New frmAgregarFormaPagoQuick()
                        'f.WindowState = FormWindowState.Normal
                        'f.StartPosition = FormStartPosition.CenterScreen
                        'f.ShowDialog()

                        'If Trim(f.txtNombre.Text <> "") Then
                        '    Inicio = True
                        '    cbTipoFactura.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
                        '    cbTipoFactura.ValueMember = "Codigo"
                        '    cbTipoFactura.DisplayMember = "Nombre"
                        '    Inicio = False
                        'Else
                        'End If

                    Else
                        TipoFactura = cbTipoFactura.SelectedValue.ToString
                        dtpFechaPago.Value = dtpFecha.Value.AddDays(FormaPago.FormaPagoDias(cbTipoFactura.SelectedValue))
                    End If
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try

        End Sub

        Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
            'Contab Real
            Dim Cadena As String
            Dim Temp As Boolean = False
            Dim Data() As Byte
            Try
                'Dim Datas() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
                Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 2").Rows(0).Item(0), Byte())
                Temp = True
                Dim Tamano As Integer
                Tamano = Data.GetUpperBound(0)
                Cadena = Application.StartupPath & "\RptFactura.repx"
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
                Rep = XtraReport.FromFile(Application.StartupPath & "\RptFactura.repx", True)
            Else
                Rep = New RptFacturaNew
            End If

            'Rep.DataSource = ObtieneDatos("SPGetRptFactura " & EmpresaActual & ",'" & txtfactura.Text & "'")
            'Rep.ShowRibbonPreview()

            Rep.DataSource = ObtieneDatos("SPGetRptFactura " & EmpresaActual & ",'" & txtFactura.Text & "'")

            Rep.ShowPrintMarginsWarning = False
            Rep.BringToFront()
            Rep.ShowRibbonPreview()




            'Para Don luis y sus locuras
            'Dim fReportes As New frmReportes
            ''Dim rFactura As New rptFactura
            'Dim rfactura As New rptFacturaXML
            'Dim r As New VB.SysContab.Rutinas
            'Dim Facturas As New VB.SysContab.Facturas_VentasDB
            'Dim ds As New DataSet
            'ds = Facturas.GetImprimirFact(txtFactura.Text, False)
            'ds.WriteXml(Application.StartupPath & "\xml\xmlFactura.xml", XmlWriteMode.WriteSchema)

            'rfactura.Database.Tables("_FacturasVentasFormulario").Location = Application.StartupPath & "\xml\xmlFactura.xml"
            'rfactura.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"

            ''rFactura.SetDataSource(ds)
            'fReportes.crvReportes.ReportSource = rfactura
            'fReportes.Show()
        End Sub
    End Class

End Namespace
