Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmFacturaProveedores
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmFacturaProveedores = Nothing

    Public Shared Function Instance() As frmFacturaProveedores
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmFacturaProveedores()
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRecargo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSubtotal As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtIVA As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdentificacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chkConsolidarIVA As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbdistribucion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents ckIR As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckIVA As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
    Friend WithEvents cbProveedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbServicios As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbTipoComp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtpFechaPago As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFechaRecepcion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkConsolidarIVA = New DevExpress.XtraEditors.CheckEdit
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit
        Me.txtIVA = New DevExpress.XtraEditors.CalcEdit
        Me.txtSubtotal = New DevExpress.XtraEditors.CalcEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtRecargo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtpFecha = New DevExpress.XtraEditors.DateEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtIdentificacion = New DevExpress.XtraEditors.TextEdit
        Me.txtFactura = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbFormaPago = New DevExpress.XtraEditors.LookUpEdit
        Me.dtpFechaPago = New DevExpress.XtraEditors.DateEdit
        Me.dtpFechaRecepcion = New DevExpress.XtraEditors.DateEdit
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cbProveedor = New DevExpress.XtraEditors.LookUpEdit
        Me.gbTipo = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.ckIVA = New DevExpress.XtraEditors.CheckEdit
        Me.ckIR = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cbServicios = New DevExpress.XtraEditors.LookUpEdit
        Me.cbTipoComp = New DevExpress.XtraEditors.LookUpEdit
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.cmbdistribucion = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.chkConsolidarIVA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIVA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtpFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdentificacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRecepcion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaRecepcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTipo.SuspendLayout()
        CType(Me.ckIVA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckIR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbServicios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(536, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 26)
        Me.Label15.TabIndex = 133
        Me.Label15.Text = "Fecha de Pago:"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(8, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 26)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Forma de Pago:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.chkConsolidarIVA)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtIVA)
        Me.GroupBox1.Controls.Add(Me.txtSubtotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtRecargo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 173)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'chkConsolidarIVA
        '
        Me.chkConsolidarIVA.Location = New System.Drawing.Point(16, 138)
        Me.chkConsolidarIVA.Name = "chkConsolidarIVA"
        Me.chkConsolidarIVA.Properties.Caption = "Consolidar IVA"
        Me.chkConsolidarIVA.Size = New System.Drawing.Size(184, 19)
        Me.chkConsolidarIVA.TabIndex = 148
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(8, 43)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(576, 86)
        Me.txtObservaciones.TabIndex = 0
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(688, 52)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(112, 20)
        Me.txtIVA.TabIndex = 2
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(688, 26)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(112, 20)
        Me.txtSubtotal.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 26)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "Obervaciones:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(592, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 17)
        Me.Label13.TabIndex = 145
        Me.Label13.Text = "Total:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(592, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 17)
        Me.Label14.TabIndex = 143
        Me.Label14.Text = "Sub Total:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(600, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 26)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "Recargo:"
        Me.Label7.Visible = False
        '
        'txtRecargo
        '
        Me.txtRecargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecargo.Location = New System.Drawing.Point(688, 112)
        Me.txtRecargo.MaxLength = 13
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.Size = New System.Drawing.Size(112, 20)
        Me.txtRecargo.TabIndex = 4
        Me.txtRecargo.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(592, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "IVA:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(688, 78)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(112, 20)
        Me.txtTotal.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.dtpFecha)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtIdentificacion)
        Me.GroupBox3.Controls.Add(Me.txtFactura)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.cbFormaPago)
        Me.GroupBox3.Controls.Add(Me.dtpFechaPago)
        Me.GroupBox3.Controls.Add(Me.dtpFechaRecepcion)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 129)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(824, 112)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.EditValue = New Date(2009, 8, 14, 0, 0, 0, 0)
        Me.dtpFecha.Location = New System.Drawing.Point(688, 17)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpFecha.Size = New System.Drawing.Size(128, 20)
        Me.dtpFecha.TabIndex = 159
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(536, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 26)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Fecha de Recepción:"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(144, 69)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(200, 20)
        Me.txtIdentificacion.TabIndex = 2
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(144, 17)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(200, 20)
        Me.txtFactura.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 26)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "No. Identificación:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(536, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 26)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Fecha:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 26)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "No. Factura:"
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Location = New System.Drawing.Point(144, 43)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFormaPago.Properties.NullText = ""
        Me.cbFormaPago.Size = New System.Drawing.Size(200, 20)
        Me.cbFormaPago.TabIndex = 143
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.EditValue = New Date(2009, 8, 14, 0, 0, 0, 0)
        Me.dtpFechaPago.Location = New System.Drawing.Point(688, 43)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaPago.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpFechaPago.Size = New System.Drawing.Size(128, 20)
        Me.dtpFechaPago.TabIndex = 159
        '
        'dtpFechaRecepcion
        '
        Me.dtpFechaRecepcion.EditValue = New Date(2009, 8, 14, 0, 0, 0, 0)
        Me.dtpFechaRecepcion.Location = New System.Drawing.Point(688, 69)
        Me.dtpFechaRecepcion.Name = "dtpFechaRecepcion"
        Me.dtpFechaRecepcion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaRecepcion.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpFechaRecepcion.Size = New System.Drawing.Size(128, 20)
        Me.dtpFechaRecepcion.TabIndex = 159
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.cbProveedor)
        Me.GroupBox4.Controls.Add(Me.gbTipo)
        Me.GroupBox4.Controls.Add(Me.ckIVA)
        Me.GroupBox4.Controls.Add(Me.ckIR)
        Me.GroupBox4.Controls.Add(Me.LabelControl3)
        Me.GroupBox4.Controls.Add(Me.LabelControl2)
        Me.GroupBox4.Controls.Add(Me.LabelControl1)
        Me.GroupBox4.Controls.Add(Me.cbServicios)
        Me.GroupBox4.Controls.Add(Me.cbTipoComp)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(824, 120)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'cbProveedor
        '
        Me.cbProveedor.Location = New System.Drawing.Point(152, 17)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedor.Properties.NullText = ""
        Me.cbProveedor.Size = New System.Drawing.Size(216, 20)
        Me.cbProveedor.TabIndex = 143
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.RadioButton1)
        Me.gbTipo.Controls.Add(Me.RadioButton2)
        Me.gbTipo.Location = New System.Drawing.Point(640, 0)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(120, 60)
        Me.gbTipo.TabIndex = 142
        Me.gbTipo.TabStop = False
        Me.gbTipo.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Location = New System.Drawing.Point(24, 9)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(80, 25)
        Me.RadioButton1.TabIndex = 140
        Me.RadioButton1.Text = "Servicios"
        '
        'RadioButton2
        '
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.Location = New System.Drawing.Point(24, 34)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(72, 18)
        Me.RadioButton2.TabIndex = 141
        Me.RadioButton2.Text = "Productos"
        '
        'ckIVA
        '
        Me.ckIVA.EditValue = True
        Me.ckIVA.Location = New System.Drawing.Point(544, 34)
        Me.ckIVA.Name = "ckIVA"
        Me.ckIVA.Properties.Caption = "IVA"
        Me.ckIVA.Size = New System.Drawing.Size(104, 19)
        Me.ckIVA.TabIndex = 139
        '
        'ckIR
        '
        Me.ckIR.EditValue = True
        Me.ckIR.Location = New System.Drawing.Point(544, 9)
        Me.ckIR.Name = "ckIR"
        Me.ckIR.Properties.Caption = "IR"
        Me.ckIR.Size = New System.Drawing.Size(104, 19)
        Me.ckIR.TabIndex = 138
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(8, 69)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(133, 16)
        Me.LabelControl3.TabIndex = 137
        Me.LabelControl3.Text = "Tipo Comprobante:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(8, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 16)
        Me.LabelControl2.TabIndex = 135
        Me.LabelControl2.Text = "Servicios:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(8, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(77, 16)
        Me.LabelControl1.TabIndex = 133
        Me.LabelControl1.Text = "Proveedor:"
        '
        'cbServicios
        '
        Me.cbServicios.Location = New System.Drawing.Point(152, 43)
        Me.cbServicios.Name = "cbServicios"
        Me.cbServicios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbServicios.Properties.NullText = ""
        Me.cbServicios.Size = New System.Drawing.Size(296, 20)
        Me.cbServicios.TabIndex = 143
        '
        'cbTipoComp
        '
        Me.cbTipoComp.Location = New System.Drawing.Point(152, 69)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoComp.Properties.NullText = ""
        Me.cbTipoComp.Size = New System.Drawing.Size(216, 20)
        Me.cbTipoComp.TabIndex = 143
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.cmbdistribucion)
        Me.GroupBox5.Controls.Add(Me.cmdAceptar)
        Me.GroupBox5.Controls.Add(Me.cmdCancelar)
        Me.GroupBox5.Location = New System.Drawing.Point(840, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(104, 405)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'cmbdistribucion
        '
        Me.cmbdistribucion.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdistribucion.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmbdistribucion.Appearance.Options.UseFont = True
        Me.cmbdistribucion.Appearance.Options.UseForeColor = True
        Me.cmbdistribucion.Location = New System.Drawing.Point(16, 103)
        Me.cmbdistribucion.Name = "cmbdistribucion"
        Me.cmbdistribucion.Size = New System.Drawing.Size(80, 25)
        Me.cmbdistribucion.TabIndex = 151
        Me.cmbdistribucion.Text = "&Distribucion"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(16, 17)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 26)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(16, 60)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(80, 26)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "Salir"
        '
        'frmFacturaProveedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(960, 430)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFacturaProveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.chkConsolidarIVA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIVA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dtpFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdentificacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRecepcion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaRecepcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTipo.ResumeLayout(False)
        CType(Me.ckIVA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckIR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbServicios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim Proveedores As New VB.SysContab.ProveedoresDB
    Dim FormaPago As New VB.SysContab.Forma_PagoDB
    Dim ProveedorDetalle As New VB.SysContab.ProveedoresDetails
    Dim Facturas As New VB.SysContab.Facturas_ComprasDB
    Dim Plantilla As New VB.SysContab.PlantillaDB
    Dim r As New VB.SysContab.Rutinas

    Dim Detalles As New VB.SysContab.FacturasComprasDetails

    Dim Config As New VB.SysContab.ConfiguracionDB
    Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
    Dim DetalleSB As New VB.SysContab.ServiciosBasicosDetail
    Dim Comp As New VB.SysContab.ComprobanteDB
#End Region

    Private DT_Distribucion As DataTable = New DataTable("Distribucion")

    Private Function VerificaDistribucion() As Boolean
        Dim Total As Double = 0
        If Not DT_Distribucion Is Nothing Then
            For i As Integer = 0 To DT_Distribucion.Rows.Count - 1
                If DT_Distribucion.Rows(i).RowState <> DataRowState.Deleted Then Total += DT_Distribucion.Rows(i).Item("Valor")
            Next
            If Total <> CDbl(txtSubtotal.Text) Then
                Return False
            End If
            Return True
        End If
    End Function

    Private Sub frmFacturaProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''r.CambiarEstilo(Me)
        DT_Distribucion = CargaDistribucion(0, 0, 0)
        Dim ds As New DataSet

        ConfigDetalles = Config.GetConfigDetails

        Me.cbProveedor.Properties.DataSource = Proveedores.ProveedoresServiciosList().Tables("Proveedores")
        With cbProveedor.Properties
            .ValueMember = "Codigo"
            .DisplayMember = "Nombre"
            .ForceInitialize()
            .PopulateColumns()
            .Columns(0).Visible = False
            .ShowHeader = False
        End With

        Me.cbServicios.Properties.DataSource = VB.SysContab.ServiciosBasicos.GetList(2).Tables(0)
        With cbServicios.Properties
            .ValueMember = "Codigo"
            .DisplayMember = "Basico"
            .ForceInitialize()
            .PopulateColumns()
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .ShowHeader = False
        End With
        cbTipoComp.Properties.DataSource = Comp.GetTiposComprobantes(0).Tables("TipoComprobantes")
        With cbTipoComp.Properties
            .ValueMember = "TipComp_Id"
            .DisplayMember = "TipComp_Nombre"
            .ForceInitialize()
            .PopulateColumns()
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .ShowHeader = False
        End With
        Me.cbFormaPago.Properties.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
        With cbFormaPago.Properties
            .ValueMember = "Codigo"
            .DisplayMember = "Nombre"
            .ForceInitialize()
            .PopulateColumns()
            .Columns(0).Visible = False
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .ShowHeader = False
        End With

        If Me.txtFactura.Text = "" Then 'Nueva Factura

            Me.txtIVA.Text = (0).ToString(Round)
            Me.txtRecargo.Text = (0).ToString(Round)
            Me.txtTotal.Text = (0).ToString(Round)
            Me.txtSubtotal.Text = (0).ToString(Round)

            Me.dtpFecha.DateTime = r.Fecha
            Me.dtpFechaPago.DateTime = Me.dtpFecha.DateTime
            Me.dtpFechaRecepcion.DateTime = Me.dtpFecha.DateTime
            Me.cmdAceptar.Enabled = True
        Else
            ds = VB.SysContab.Facturas_ComprasDB.FacturaSBDetalle(Me.txtFactura.Text, Me.cbProveedor.EditValue)
            If ds.Tables(0).Rows.Count = 1 Then

                'Me.cbTipo.SelectedValue = ds.Tables("Facturas_Compras").Rows(0).Item("Esq_ID").ToString
                Me.cbServicios.EditValue = ds.Tables("Facturas_Compras").Rows(0).Item("Basico_ID") & "-" & ds.Tables("Facturas_Compras").Rows(0).Item("Consecutivo_ID")
                Me.cbTipoComp.EditValue = ds.Tables("Facturas_Compras").Rows(0).Item("comp_tipo")
                Me.cbFormaPago.EditValue = ds.Tables("Facturas_Compras").Rows(0).Item("formapago_ID")
                Me.dtpFecha.DateTime = ds.Tables("Facturas_Compras").Rows(0).Item("Factura_Fecha")
                Me.dtpFechaPago.DateTime = ds.Tables("Facturas_Compras").Rows(0).Item("Factura_FechaPago")

                Me.txtIVA.Text = CDbl(ds.Tables("Facturas_Compras").Rows(0).Item("Item_Iva")).ToString(Round)

                If CDbl(ds.Tables("Facturas_Compras").Rows(0).Item("Item_Iva")).ToString(Round) > 0 Then
                    Me.ckIVA.Checked = True
                Else
                    Me.ckIVA.Checked = False
                End If

                Me.txtRecargo.Text = (0).ToString(Round)
                Me.txtIdentificacion.Text = ds.Tables("Facturas_Compras").Rows(0).Item("Ident").ToString
                Me.txtObservaciones.Text = ds.Tables("Facturas_Compras").Rows(0).Item("Observaciones").ToString
                Me.txtSubtotal.Text = CDbl(ds.Tables("Facturas_Compras").Rows(0).Item("Item_Costo")).ToString(Round)
                Me.txtTotal.Text = CDbl(CDbl(Me.txtSubtotal.Text) + CDbl(Me.txtIVA.Text)).ToString(Round) 'CDbl(ds.Tables("Facturas_Compras").Rows(0).Item("Total")).ToString(Round)
                If Not (ds.Tables(0).Rows(0).Item("Fecha_Recepcion") Is DBNull.Value Or ds.Tables(0).Rows(0).Item("Fecha_Recepcion") Is Nothing) Then
                    Me.dtpFechaRecepcion.EditValue = ds.Tables(0).Rows(0).Item("Fecha_Recepcion")
                Else
                    Me.dtpFechaRecepcion.EditValue = Nothing
                End If
            Else
                MsgBox("No se ha encontrado el detalle de la factura seleccionada, favor llamar al Administrador", MsgBoxStyle.Critical, "STS-Contab")
            End If
            Me.cmdAceptar.Enabled = False
        End If
        Me.Text = "Facturas de Servicios Básicos"
        SetTiempos(OrigenComprobantes.FACTURA_PROVEEDOR, Funciones.Tiempos.TiempoInicio, Now, Funciones.Eventos.Inicia, Me.txtFactura.Text)

    End Sub

    Private Sub cbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cbProveedor.SelectedValue.ToString = "System.Data.DataRowView" Then
        '    Exit Sub
        'End If

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub


    Private Sub txtIVA_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIVA.Leave
        If Trim(txtIVA.Text) = "" Then
            txtIVA.Text = (0).ToString(Round)
        ElseIf Not IsNumeric(txtIVA.Text) Then
            MsgBox("Valor no valido", MsgBoxStyle.Information)
            txtIVA.Focus()
            Exit Sub
        End If

        If DetalleSB.CuentaIVA Is Nothing Or DetalleSB.CuentaIVA = "" Then
            txtIVA.Text = 0
        Else
            txtIVA.Text = CDbl(txtIVA.Text).ToString(Round)
        End If
        CalcularTotal()
    End Sub

    Private Sub txtRecargo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRecargo.Leave
        If Trim(txtRecargo.Text) = "" Then
            txtRecargo.Text = (0).ToString(Round)
        ElseIf Not IsNumeric(txtRecargo.Text) Then
            MsgBox("Valor no valido", MsgBoxStyle.Information)
            txtRecargo.Focus()
            Exit Sub
        End If

        txtRecargo.Text = CDbl(txtRecargo.Text).ToString(Round)
        CalcularTotal()
    End Sub

    Public Sub CalcularTotal()
        txtTotal.Text = ""
        txtTotal.Text = (CDbl(txtSubtotal.Text) + CDbl(txtIVA.Text) + CDbl(txtRecargo.Text)).ToString(Round)
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            If Me.dtpFechaRecepcion.EditValue Is DBNull.Value Or Me.dtpFechaRecepcion.EditValue Is Nothing Then
                MsgBox("Debe seleccionar la fecha de recepción de la factura", MsgBoxStyle.Critical, "STS-Contab")
                Me.dtpFechaRecepcion.Focus()
                Exit Sub
            End If
            If Me.cbProveedor.EditValue = 0 Then
                MsgBox("Seleccione el Proveedor", MsgBoxStyle.Information)
                Me.cbProveedor.Focus()
                Exit Sub
            End If

            If Trim(txtFactura.Text) = "" Then
                MsgBox("Introduzca el Número de Factura", MsgBoxStyle.Information)
                txtFactura.Focus()
                Exit Sub
            End If

            If Me.cbFormaPago.EditValue = 0 Then
                MsgBox("Seleccione la Forma de Pago", MsgBoxStyle.Information)
                Me.cbFormaPago.Focus()
                Exit Sub
            End If
            If Me.cbTipoComp.EditValue = 0 Or Me.cbTipoComp.EditValue Is DBNull.Value Then
                MsgBox("Seleccione el tipo de comprobante", MsgBoxStyle.Critical, "STS-Contab")
                Exit Sub
            End If
            If DetalleSB.CuentaProvision = "" Then
                MsgBox("No hay cuenta contable para hacer la provisión de esta factura", MsgBoxStyle.Critical, "STS-Contab")
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If

            Dim CtaProveedor As String
            CtaProveedor = VB.SysContab.ProveedoresDB.GetDetails(Me.cbProveedor.EditValue).Cuenta
            If CtaProveedor = "" Or CtaProveedor Is DBNull.Value Then
                MsgBox("La Cuenta del Proveedor no esta configurada", MsgBoxStyle.Critical, "STS-Contab")
                Exit Sub
            End If

            'If Me.cbTipo.SelectedValue = 0 Then
            '    MsgBox("Seleccione el Tipo de Factura", MsgBoxStyle.Information)
            '    Me.cbTipo.Focus()
            '    Exit Sub
            'End If

            Dim CTemp As String
            Try
                CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND CuentaContable = '" & DetalleSB.CuentaProvision & "' AND Empresa = " & EmpresaActual).Rows(0).Item(0)
            Catch ex As Exception
                CTemp = ""
            End Try
            If CTemp <> Nothing Then
                If VerificaDistribucion() = False And ObligarDistribucion = True Then
                    MsgBox("La cuenta de este servicio es de Distribucion, por favor distribuya la factura")
                    Exit Sub
                End If
            End If

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            'cbTipo.SelectedValue
            Facturas.AddItem(txtFactura.Text, dtpFecha.DateTime, dtpFechaPago.DateTime, _
                    cbProveedor.EditValue, txtTotal.Text, cbFormaPago.EditValue, 3, _
                    DetalleSB.Basico_ID, DetalleSB.Consecutivo_ID, txtIdentificacion.Text.ToString, _
                    0, 1, 0, Me.txtObservaciones.Text, "F")
            Facturas.AddFacturaLineas(txtFactura.Text, "SB", 1, txtSubtotal.Text, 0, txtIVA.Text, "SB", 0, 0, 0, cbProveedor.EditValue)

            Dim DC As String
            Dim noComprob As Integer
            noComprob = VB.SysContab.ComprobanteDB.AddComprobante(Me.cbTipoComp.EditValue, 1, _
                    txtObservaciones.Text, VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, _
                    VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.DateTime), Me.dtpFecha.DateTime, 0, "", False, _
                     Me.cbProveedor.EditValue, "", 1, Me.txtFactura.Text, Me.dtpFechaPago.DateTime, _
                    Me.cbFormaPago.EditValue, OrigenComprobantes.FACTURA_PROVEEDOR)
            Dim ValorProveedor As Double = 0

            If Not Me.chkConsolidarIVA.Checked Then
                ValorProveedor = Me.txtSubtotal.Text
            Else
                ValorProveedor = Me.txtTotal.Text
            End If

            Dim porcRet, RetIR As Double

            RetIR = 0

            'Agregar la cuenta del IR

            If Me.ckIR.Checked Then


                If Not ProveedorDetalle.Exento Then
                    If Me.txtSubtotal.Text >= ConfigDetalles.MontoIR Then
                        If VB.SysContab.ServiciosBasicos.GetDetails(DetalleSB.Basico_ID, DetalleSB.Consecutivo_ID).CuentaIR <> "" Then
                            porcRet = IIf(ProveedorDetalle.TipoProveedor = TipoProveedor.Juridico, ConfigDetalles.IRProd, ConfigDetalles.IRServ)
                            porcRet = (porcRet / 100.0).ToString(Round)
                            RetIR = (Me.txtSubtotal.Text * porcRet).ToString(Round)
                        Else
                            MsgBox("El Servicio no tiene configurada la cuenta de retencion de IR", MsgBoxStyle.Critical, "STS-Contab")
                            VB.SysContab.Rutinas.ErrorTransaccion()
                            Exit Sub
                        End If
                    End If
                End If

            End If

            If Me.ckIR.Checked Then

                'Agregar la cuenta del IR
                If RetIR > 0 Then
                    VB.SysContab.ComprobanteDB.AddComprobanteDetalles(noComprob, _
                                    VB.SysContab.ServiciosBasicos.GetDetails(DetalleSB.Basico_ID, DetalleSB.Consecutivo_ID).CuentaIR, _
                                    "Retencion IR Serv", RetIR, "", Me.cbTipoComp.EditValue, "C", 0, 0, _
                                   Me.dtpFecha.DateTime, 1)
                End If

            End If


            'Cuenta del Proveedor
            VB.SysContab.ComprobanteDB.AddComprobanteDetalles(noComprob, _
                CtaProveedor, "", Me.txtTotal.Text - RetIR, "", Me.cbTipoComp.EditValue, "C", 0, 0, _
                Me.dtpFecha.DateTime, 0)

            'Cuenta del Gasto
            VB.SysContab.ComprobanteDB.AddComprobanteDetalles(noComprob, _
                 DetalleSB.CuentaProvision, "", ValorProveedor, "", Me.cbTipoComp.EditValue, "D", 0, 0, _
                 Me.dtpFecha.DateTime, 1)

            If Me.ckIVA.Checked Then

                If Not Me.chkConsolidarIVA.Checked Then
                    If Not (DetalleSB.CuentaIVA Is Nothing Or DetalleSB.CuentaIVA = "") Then
                        'Cuenta del IVA
                        VB.SysContab.ComprobanteDB.AddComprobanteDetalles(noComprob, _
                                         DetalleSB.CuentaIVA, "", Me.txtIVA.Text, "", Me.cbTipoComp.EditValue, "D", 0, 0, _
                                         Me.dtpFecha.DateTime, 1)
                    Else
                        MsgBox("No existe la cuenta de IVA para el servicio seleccionado", MsgBoxStyle.Critical, "STS-Contab")
                        VB.SysContab.Rutinas.ErrorTransaccion()
                        Exit Sub
                    End If
                End If

            End If

            VB.SysContab.ComprobanteDB.AddFacturaFecha(Me.cbProveedor.EditValue, Me.txtFactura.Text, Me.dtpFechaRecepcion.DateTime)

            '----------------------
            'Guarda la Distribucion
            '----------------------
            VerificaDistribucion()
            GuardaDistribucion(DT_Distribucion, dtpFecha.DateTime.Date, noComprob)
            DT_Distribucion = CargaDistribucion(0, 0, 0)
            '--------------------------
            'Fin de Guarda Distribucion
            '--------------------------

            VB.SysContab.Rutinas.okTransaccion()
            SetTiempos(OrigenComprobantes.FACTURA_PROVEEDOR, Funciones.Tiempos.TiempoFin, Now, Funciones.Eventos.Guarda, Me.txtFactura.Text)
        Catch ex As Exception
            MsgBox(ex.Message & "Guardar", MsgBoxStyle.Information)
            VB.SysContab.Rutinas.ErrorTransaccion()
            SetTiempos(OrigenComprobantes.FACTURA_PROVEEDOR, Funciones.Tiempos.TiempoFin, Now, Funciones.Eventos.Error1, Me.txtFactura.Text)
            Exit Sub
        End Try

        r.EstablecerCero(GroupBox1)
        r.LimpiarControles(GroupBox3)
        r.LimpiarControles(GroupBox4)

        Me.cbProveedor.EditValue = 0
        Me.cbFormaPago.EditValue = 0
        Me.txtObservaciones.Text = ""

        cbProveedor.Focus()
        Me.Close()
    End Sub

    Private Sub frmFacturaProveedores_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

    End Sub

    Private Sub txtTotal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.Leave
        'If Not IsNumeric(txtTotal.Text) Then
        '    MsgBox("Valor no valido")
        '    txtTotal.Focus()
        '    Exit Sub
        'End If

        'txtTotal.Text = CDbl(txtTotal.Text).ToString(Round)
    End Sub

    Private Sub txtSubtotal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubtotal.Leave
        If Trim(txtSubtotal.Text) = "" Then
            txtSubtotal.Text = (0).ToString(Round)
        ElseIf Not IsNumeric(txtSubtotal.Text) Then
            MsgBox("Valor no valido")
            txtSubtotal.Focus()
            Exit Sub
        End If


        If Me.ckIVA.Checked Then
            If Me.txtFactura.Text = "" Then 'Nueva Factura
                txtSubtotal.Text = CDbl(txtSubtotal.Text).ToString(Round)
                CalcularIva()
                CalcularTotal()
            End If

        End If


    End Sub

    Private Sub CalcularIva()
        If ProveedorDetalle.Retenedor Is Nothing Then
            Exit Sub
        Else
            If ProveedorDetalle.Retenedor Then
                If DetalleSB.CuentaIVA Is Nothing Or DetalleSB.CuentaIVA = "" Then
                    txtIVA.Text = 0.0
                Else
                    txtIVA.Text = ((CDbl(txtSubtotal.Text) * (ConfigDetalles.IVA / 100.0))).ToString(Round)
                End If
            Else
                txtIVA.Text = 0.0
            End If

        End If

    End Sub


    Private Sub cbServicios_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbServicios.EditValueChanged
        Dim Codigo As String
        Codigo = Me.cbServicios.EditValue
        DetalleSB = VB.SysContab.ServiciosBasicos.GetDetails(Codigo.Substring(0, 2), Codigo.Substring(3, 10))
    End Sub

    Private Sub cbProveedor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProveedor.EditValueChanged
        If Not (Me.cbProveedor.EditValue Is DBNull.Value Or Me.cbProveedor.EditValue Is Nothing) Then
            ProveedorDetalle = VB.SysContab.ProveedoresDB.GetDetails(Me.cbProveedor.EditValue)
        End If
    End Sub

    Private Sub txtSubtotal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubtotal.EditValueChanged
        If Trim(txtSubtotal.Text) = "" Then
            txtSubtotal.Text = (0).ToString(Round)
        ElseIf Not IsNumeric(txtSubtotal.Text) Then
            MsgBox("Valor no valido")
            txtSubtotal.Focus()
            Exit Sub
        End If




        If Me.ckIVA.Checked Then
            If Me.txtFactura.Text = "" Then 'Nueva Factura
                txtSubtotal.Text = CDbl(txtSubtotal.Text).ToString(Round)
                CalcularIva()
                CalcularTotal()
            End If
        Else
            Me.txtIVA.Text = 0
            Me.txtTotal.Text = 0
        End If



    End Sub

    Private Sub cbFormaPago_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFormaPago.EditValueChanged
        Try
            If IsNumeric(cbFormaPago.EditValue) Then
                If Inicio = True Then
                    Exit Sub
                End If

                If cbFormaPago.EditValue <> 0 Then
                    dtpFechaPago.DateTime = dtpFecha.DateTime.AddDays(FormaPago.FormaPagoDias(cbFormaPago.EditValue))
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmFacturaProveedores_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        SetTiempos(OrigenComprobantes.FACTURA_PROVEEDOR, Funciones.Tiempos.TiempoFin, Now, Funciones.Eventos.Salir, Me.txtFactura.Text)
    End Sub

    Private Sub cmbdistribucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdistribucion.Click
        If DetalleSB.CuentaProvision = "" Or DetalleSB.CuentaProvision Is DBNull.Value Then
            MsgBox("La Cuenta del gasto no esta configurada", MsgBoxStyle.Critical, "STS-Contab")
            Exit Sub
        End If
        If CDbl(txtSubtotal.Text) <= 0 Then Exit Sub
        Try
            Dim forma As New FrmDetalleRequisas

            forma.Monto = IIf(chkConsolidarIVA.Checked, txtTotal.Text, txtSubtotal.Text)
            forma.Tipo = "D"
            forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.DateTime.Date)
            forma.CompNo = 0
            forma.Cuenta = DetalleSB.CuentaProvision
            forma.Mes = dtpFecha.DateTime.Date.Month

            'MsgBox(forma.Tipo)
            forma.Mostrar(DT_Distribucion)
            Me.DT_Distribucion.DefaultView.RowFilter = ""


        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.Source)
        End Try
    End Sub


    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckIR.CheckedChanged

        If Me.ckIR.Checked Then
            Me.gbTipo.Visible = False
        Else
            Me.gbTipo.Visible = False
        End If

    End Sub

    Private Sub ckIVA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckIVA.CheckedChanged

        If Me.ckIVA.Checked Then
            CalcularIva()
            CalcularTotal()
        Else
            Me.txtIVA.Text = 0
            Me.txtTotal.Text = Me.txtSubtotal.Text
        End If

    End Sub


End Class
