Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace DataGridTextBox
    Public Class frmComprobanteBuscar1
        Inherits DevExpress.XtraEditors.XtraForm

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
        Friend WithEvents cbTipoComp As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents lblNumero As System.Windows.Forms.Label
        Friend WithEvents txtNo As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
        Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents CbMeses As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpInicial As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cbPeriodos As System.Windows.Forms.ComboBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtAnno As System.Windows.Forms.TextBox
        Friend WithEvents cmdVer As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents dgComprobantes As System.Windows.Forms.DataGrid
        Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdOrdenar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdSeleccionar As DevExpress.XtraEditors.SimpleButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.dgComprobantes = New System.Windows.Forms.DataGrid
            Me.lblNumero = New System.Windows.Forms.Label
            Me.cbTipoComp = New System.Windows.Forms.ComboBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label25 = New System.Windows.Forms.Label
            Me.txtNo = New System.Windows.Forms.TextBox
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            Me.cmdSeleccionar = New DevExpress.XtraEditors.SimpleButton
            Me.cmdOrdenar = New DevExpress.XtraEditors.SimpleButton
            Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
            Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
            Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
            Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
            Me.cmdVer = New DevExpress.XtraEditors.SimpleButton
            Me.TextBox1 = New System.Windows.Forms.TextBox
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker
            Me.CheckBox1 = New System.Windows.Forms.CheckBox
            Me.txtCuenta = New System.Windows.Forms.TextBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.CbMeses = New System.Windows.Forms.ComboBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.dtpInicial = New System.Windows.Forms.DateTimePicker
            Me.Label5 = New System.Windows.Forms.Label
            Me.dtpFinal = New System.Windows.Forms.DateTimePicker
            Me.Label6 = New System.Windows.Forms.Label
            Me.CheckBox2 = New System.Windows.Forms.CheckBox
            Me.cbPeriodos = New System.Windows.Forms.ComboBox
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.txtAnno = New System.Windows.Forms.TextBox
            CType(Me.dgComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgComprobantes
            '
            Me.dgComprobantes.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
            Me.dgComprobantes.BackColor = System.Drawing.Color.Gainsboro
            Me.dgComprobantes.BackgroundColor = System.Drawing.Color.DarkGray
            Me.dgComprobantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgComprobantes.CaptionBackColor = System.Drawing.Color.DarkKhaki
            Me.dgComprobantes.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgComprobantes.CaptionForeColor = System.Drawing.Color.Black
            Me.dgComprobantes.DataMember = ""
            Me.dgComprobantes.FlatMode = True
            Me.dgComprobantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgComprobantes.ForeColor = System.Drawing.Color.Black
            Me.dgComprobantes.GridLineColor = System.Drawing.Color.Silver
            Me.dgComprobantes.HeaderBackColor = System.Drawing.Color.Black
            Me.dgComprobantes.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgComprobantes.HeaderForeColor = System.Drawing.Color.White
            Me.dgComprobantes.LinkColor = System.Drawing.Color.DarkSlateBlue
            Me.dgComprobantes.Location = New System.Drawing.Point(16, 146)
            Me.dgComprobantes.Name = "dgComprobantes"
            Me.dgComprobantes.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgComprobantes.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgComprobantes.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgComprobantes.SelectionForeColor = System.Drawing.Color.White
            Me.dgComprobantes.Size = New System.Drawing.Size(880, 303)
            Me.dgComprobantes.TabIndex = 150
            '
            'lblNumero
            '
            Me.lblNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.lblNumero.Location = New System.Drawing.Point(16, 78)
            Me.lblNumero.Name = "lblNumero"
            Me.lblNumero.Size = New System.Drawing.Size(72, 17)
            Me.lblNumero.TabIndex = 156
            Me.lblNumero.Text = "Número:"
            Me.lblNumero.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cbTipoComp
            '
            Me.cbTipoComp.Location = New System.Drawing.Point(96, 112)
            Me.cbTipoComp.Name = "cbTipoComp"
            Me.cbTipoComp.Size = New System.Drawing.Size(248, 21)
            Me.cbTipoComp.TabIndex = 155
            Me.cbTipoComp.Text = "ComboBox1"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(16, 112)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(72, 17)
            Me.Label1.TabIndex = 154
            Me.Label1.Text = "Tipo:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label25
            '
            Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label25.Location = New System.Drawing.Point(16, 9)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(72, 17)
            Me.Label25.TabIndex = 152
            Me.Label25.Text = "Fecha:"
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtNo
            '
            Me.txtNo.Location = New System.Drawing.Point(96, 78)
            Me.txtNo.Name = "txtNo"
            Me.txtNo.Size = New System.Drawing.Size(248, 21)
            Me.txtNo.TabIndex = 157
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.GroupBox2.Controls.Add(Me.cmdSeleccionar)
            Me.GroupBox2.Controls.Add(Me.cmdOrdenar)
            Me.GroupBox2.Controls.Add(Me.cmdBorrar)
            Me.GroupBox2.Controls.Add(Me.cmdAyuda)
            Me.GroupBox2.Controls.Add(Me.cmdSalir)
            Me.GroupBox2.Controls.Add(Me.cmdAceptar)
            Me.GroupBox2.Controls.Add(Me.cmdVer)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
            Me.GroupBox2.Location = New System.Drawing.Point(902, 27)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(104, 422)
            Me.GroupBox2.TabIndex = 142
            Me.GroupBox2.TabStop = False
            '
            'cmdSeleccionar
            '
            Me.cmdSeleccionar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.cmdSeleccionar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdSeleccionar.Appearance.Options.UseFont = True
            Me.cmdSeleccionar.Appearance.Options.UseForeColor = True
            Me.cmdSeleccionar.Location = New System.Drawing.Point(8, 78)
            Me.cmdSeleccionar.Name = "cmdSeleccionar"
            Me.cmdSeleccionar.Size = New System.Drawing.Size(88, 34)
            Me.cmdSeleccionar.TabIndex = 163
            Me.cmdSeleccionar.Text = "&Seleccionar"
            '
            'cmdOrdenar
            '
            Me.cmdOrdenar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.cmdOrdenar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdOrdenar.Appearance.Options.UseFont = True
            Me.cmdOrdenar.Appearance.Options.UseForeColor = True
            Me.cmdOrdenar.Location = New System.Drawing.Point(8, 362)
            Me.cmdOrdenar.Name = "cmdOrdenar"
            Me.cmdOrdenar.Size = New System.Drawing.Size(88, 34)
            Me.cmdOrdenar.TabIndex = 162
            Me.cmdOrdenar.Text = "&Ordenar"
            Me.cmdOrdenar.Visible = False
            '
            'cmdBorrar
            '
            Me.cmdBorrar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.cmdBorrar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdBorrar.Appearance.Options.UseFont = True
            Me.cmdBorrar.Appearance.Options.UseForeColor = True
            Me.cmdBorrar.Location = New System.Drawing.Point(8, 310)
            Me.cmdBorrar.Name = "cmdBorrar"
            Me.cmdBorrar.Size = New System.Drawing.Size(88, 35)
            Me.cmdBorrar.TabIndex = 161
            Me.cmdBorrar.Text = "A&nular"
            Me.cmdBorrar.Visible = False
            '
            'cmdAyuda
            '
            Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.cmdAyuda.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdAyuda.Appearance.Options.UseFont = True
            Me.cmdAyuda.Appearance.Options.UseForeColor = True
            Me.cmdAyuda.Location = New System.Drawing.Point(8, 129)
            Me.cmdAyuda.Name = "cmdAyuda"
            Me.cmdAyuda.Size = New System.Drawing.Size(88, 35)
            Me.cmdAyuda.TabIndex = 30
            Me.cmdAyuda.Text = "&Ayuda"
            '
            'cmdSalir
            '
            Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.cmdSalir.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdSalir.Appearance.Options.UseFont = True
            Me.cmdSalir.Appearance.Options.UseForeColor = True
            Me.cmdSalir.Location = New System.Drawing.Point(8, 181)
            Me.cmdSalir.Name = "cmdSalir"
            Me.cmdSalir.Size = New System.Drawing.Size(88, 34)
            Me.cmdSalir.TabIndex = 29
            Me.cmdSalir.Text = "&Salir"
            '
            'cmdAceptar
            '
            Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdAceptar.Appearance.Options.UseFont = True
            Me.cmdAceptar.Appearance.Options.UseForeColor = True
            Me.cmdAceptar.Location = New System.Drawing.Point(8, 26)
            Me.cmdAceptar.Name = "cmdAceptar"
            Me.cmdAceptar.Size = New System.Drawing.Size(88, 34)
            Me.cmdAceptar.TabIndex = 28
            Me.cmdAceptar.Text = "&Buscar"
            '
            'cmdVer
            '
            Me.cmdVer.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.cmdVer.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdVer.Appearance.Options.UseFont = True
            Me.cmdVer.Appearance.Options.UseForeColor = True
            Me.cmdVer.Location = New System.Drawing.Point(8, 258)
            Me.cmdVer.Name = "cmdVer"
            Me.cmdVer.Size = New System.Drawing.Size(88, 35)
            Me.cmdVer.TabIndex = 160
            Me.cmdVer.Text = "&Ver Comprobante"
            Me.cmdVer.Visible = False
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(96, 32)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(100, 20)
            Me.TextBox1.TabIndex = 0
            '
            'dtpFecha
            '
            Me.dtpFecha.Enabled = False
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(96, 9)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 21)
            Me.dtpFecha.TabIndex = 158
            '
            'CheckBox1
            '
            Me.CheckBox1.Location = New System.Drawing.Point(200, 9)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(144, 25)
            Me.CheckBox1.TabIndex = 159
            Me.CheckBox1.Text = "Buscar por una Fecha"
            '
            'txtCuenta
            '
            Me.txtCuenta.Location = New System.Drawing.Point(456, 78)
            Me.txtCuenta.Name = "txtCuenta"
            Me.txtCuenta.Size = New System.Drawing.Size(104, 21)
            Me.txtCuenta.TabIndex = 161
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label2.Location = New System.Drawing.Point(368, 78)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(80, 17)
            Me.Label2.TabIndex = 160
            Me.Label2.Text = "Cuenta:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'CbMeses
            '
            Me.CbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CbMeses.Location = New System.Drawing.Point(96, 43)
            Me.CbMeses.Name = "CbMeses"
            Me.CbMeses.Size = New System.Drawing.Size(136, 21)
            Me.CbMeses.TabIndex = 163
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label3.Location = New System.Drawing.Point(16, 43)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(72, 17)
            Me.Label3.TabIndex = 162
            Me.Label3.Text = "Mes:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpInicial
            '
            Me.dtpInicial.Enabled = False
            Me.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpInicial.Location = New System.Drawing.Point(456, 9)
            Me.dtpInicial.Name = "dtpInicial"
            Me.dtpInicial.Size = New System.Drawing.Size(104, 21)
            Me.dtpInicial.TabIndex = 167
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(368, 9)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(80, 17)
            Me.Label5.TabIndex = 166
            Me.Label5.Text = "Fecha Inicial:"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpFinal
            '
            Me.dtpFinal.Enabled = False
            Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFinal.Location = New System.Drawing.Point(456, 43)
            Me.dtpFinal.Name = "dtpFinal"
            Me.dtpFinal.Size = New System.Drawing.Size(104, 21)
            Me.dtpFinal.TabIndex = 169
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label6.Location = New System.Drawing.Point(368, 43)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(80, 17)
            Me.Label6.TabIndex = 168
            Me.Label6.Text = "Fecha Final:"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'CheckBox2
            '
            Me.CheckBox2.Location = New System.Drawing.Point(568, 9)
            Me.CheckBox2.Name = "CheckBox2"
            Me.CheckBox2.Size = New System.Drawing.Size(176, 25)
            Me.CheckBox2.TabIndex = 170
            Me.CheckBox2.Text = "Buscar por Rango de Fechas"
            '
            'cbPeriodos
            '
            Me.cbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbPeriodos.Location = New System.Drawing.Point(456, 112)
            Me.cbPeriodos.Name = "cbPeriodos"
            Me.cbPeriodos.Size = New System.Drawing.Size(248, 21)
            Me.cbPeriodos.TabIndex = 172
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label7.Location = New System.Drawing.Point(368, 112)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(80, 17)
            Me.Label7.TabIndex = 171
            Me.Label7.Text = "Periodo:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(240, 43)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(32, 17)
            Me.Label4.TabIndex = 164
            Me.Label4.Text = "Año:"
            Me.Label4.Visible = False
            '
            'txtAnno
            '
            Me.txtAnno.Location = New System.Drawing.Point(272, 43)
            Me.txtAnno.Name = "txtAnno"
            Me.txtAnno.Size = New System.Drawing.Size(72, 21)
            Me.txtAnno.TabIndex = 165
            Me.txtAnno.Visible = False
            '
            'frmComprobanteBuscar1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1016, 464)
            Me.Controls.Add(Me.cbPeriodos)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.CheckBox2)
            Me.Controls.Add(Me.dtpFinal)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.dtpInicial)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.txtAnno)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.CbMeses)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtCuenta)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.CheckBox1)
            Me.Controls.Add(Me.dtpFecha)
            Me.Controls.Add(Me.txtNo)
            Me.Controls.Add(Me.lblNumero)
            Me.Controls.Add(Me.cbTipoComp)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label25)
            Me.Controls.Add(Me.dgComprobantes)
            Me.Controls.Add(Me.GroupBox2)
            Me.Name = "frmComprobanteBuscar1"
            CType(Me.dgComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Dim Comp As New VB.SysContab.ComprobanteDB()
        Dim compDet As New VB.SysContab.ComprobantesDetails()
        Dim r As New VB.SysContab.Rutinas()
        Dim Mes As New VB.SysContab.MesesDB()
        Dim PerDB As New VB.SysContab.PeriodosDB()
        Dim Catalogo As New VB.SysContab.CatalogoDB()

        Dim ds As DataSet

        Dim i As Integer
        Public Aceptar As Boolean

        Private Sub frmComprobanteBuscar1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            cbTipoComp.DataSource = Comp.GetTiposComprobantes.Tables("TipoComprobantes")
            cbTipoComp.ValueMember = "TipComp_Id"
            cbTipoComp.DisplayMember = "TipComp_Nombre"

            CbMeses.DataSource = Mes.GetList().Tables("Meses")
            CbMeses.ValueMember = "Numero"
            CbMeses.DisplayMember = "Mes"

            Dim DSTipos As New DataSet()
            Dim i As Integer

            Aceptar = False

            cbPeriodos.DataSource = PerDB.GetList().Tables("Periodos")
            cbPeriodos.ValueMember = "codigo"
            cbPeriodos.DisplayMember = "descripcion"

            Me.txtAnno.MaxLength = 4

            Me.dtpInicial.Value = r.Fecha
            Me.dtpFinal.Value = r.Fecha

            Me.dtpFinal.MinDate = Me.dtpFinal.Value

            Dim Periodo
            Periodo = VB.SysContab.PeriodosDB.Actual
            If Periodo <> 0 Then
                Me.cbPeriodos.SelectedValue = Periodo
            End If
            Dim Ds As New DataSet
            ''Buscar como quitar el acceso de Recibos Cobros 27052008 OV
            'Ds = Comp.GetComprobantesList("", "", "", "", 0, 0, "", "", cbPeriodos.SelectedValue.ToString)
            Me.dgComprobantes.DataSource = Ds.Tables("Comprobantes").DefaultView

            r.FormatGenerico(Me.dgComprobantes, Ds.Tables("Comprobantes"))

            Me.dgComprobantes.ReadOnly = True
        End Sub

        Private Sub dgComprobantes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgComprobantes.DoubleClick
            Aceptar = True
            Me.Close()

            'If Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 5) = 1 Then
            '    MostrarFactura()
            'ElseIf Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 5) = 2 Then
            '    MostrarCheque()
            'Else
            'MostrarComprobante()
            'End If
        End Sub

        Public Function Validar() As Boolean
            'If txtAnno.Text <> "" Then
            '    If CbMeses.SelectedValue > 0 Then
            '        Try
            '            CInt(txtAnno.Text).ToString()
            '        Catch
            '            MsgBox("Por favor ingrese un año valido")
            '            Return False
            '        End Try
            '    Else
            '        MsgBox("Por Favor Seleccione un Mes")
            '        Return False
            '    End If
            'Else
            '    If Me.CbMeses.SelectedValue > 0 Then
            '        MsgBox("Por favor ingrese un año válido")
            '    End If
            'End If


            If CDate(dtpInicial.Value).ToShortDateString > CDate(dtpFinal.Value).ToShortDateString Then
                MsgBox("La Fecha Final debe ser Mayor o Igual a la Fecha Inicial")
                Return False
            End If
            Return True
        End Function

        Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
            Buscar()
        End Sub

        Private Sub cmdProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
            Aceptar = False
            Me.Close()
        End Sub

        Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
            If CheckBox1.Checked = True Then
                dtpFecha.Enabled = True
                CbMeses.Enabled = False
                txtAnno.Enabled = False
                CheckBox2.Checked = False
                txtAnno.Text = ""
            Else
                dtpFecha.Enabled = False
                CbMeses.Enabled = True
                txtAnno.Enabled = True
                CbMeses.SelectedIndex = 0
                'txtAnno.Text = ""
            End If
        End Sub

        Private Sub txtNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNo.TextChanged

        End Sub

        Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

            dtpFecha.Enabled = False
            CbMeses.Enabled = False

            If CheckBox2.Checked = True Then
                dtpInicial.Enabled = True
                dtpFinal.Enabled = True
                dtpFecha.Enabled = False
                CheckBox1.Checked = False
                CbMeses.Enabled = False
                txtAnno.Enabled = False
                txtAnno.Text = ""
                CbMeses.SelectedIndex = 0
            Else
                dtpFecha.Enabled = False
                dtpInicial.Enabled = False
                dtpFinal.Enabled = False
                CbMeses.Enabled = True
                txtAnno.Enabled = True
            End If
        End Sub


        Private Sub MostrarComprobante()
            Dim f As frmComprobantesDetalles = frmComprobantesDetalles.Instance
            f.lblNoComprobante.Text = Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0)
            f.lblPeriodo.Text = cbPeriodos.SelectedValue
            f.txtFecha.Text = Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1)
            f.MdiParent = Me.MdiParent
            f.Show()



            '''Dim compDet As VB.SysContab.ComprobantesDetails = Comp.GetComprobanteDetails(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0), cbPeriodos.SelectedValue)

            '''Dim ds As DataSet = compDet.Detalles
            ''ds1 = compDet.Detalles

            '''f.dgFacturacionCliente.DataSource = Ds.Tables("ComprobantesDetalles").DefaultView
            ''MakeDataSet()
            ''f.dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            ''AddCustomDataTableStyle()

            ''f.dgFacturacionCliente.CaptionVisible = False
            ''f.dgFacturacionCliente.TableStyles.Clear()
            ''f.dgFacturacionCliente.TableStyles.Add(ts1)

            ''f.dgFacturacionCliente.ReadOnly = False

            ''f.dtpFecha.Text = CDate(compDet.Fecha).ToShortDateString
            '''f.lblMonedas.Text = compDet.
            '''f.lblNoComprobante.Text= CompDet.
            ''f.txtConcepto.Text = compDet.Concepto
            ''f.lblNoComprobante.Text = compDet.Numero
            ''f.lblTipo.Text = compDet.Tipo
            ''f.cbTipoComp.SelectedValue = compDet.Tipo1
            ''f.ddlMoneda.SelectedValue = compDet.Moneda
            ''f.lblTasaCambio.Text = compDet.TasaCambio
            ''f.lblDescrip.Text = compDet.Descripcion
            ''f.lblPeriodo.Text = cbPeriodos.SelectedValue
            ''f.lblChequeNombre.Text = compDet.ChequeNombre

            ''f.etFactura.Text = compDet.Factura
            ''f.etRecibo.Text = compDet.Recibo

            ''Dim i As Integer

            '''f.lblCredito.Text = 0
            '''f.lblDebito.Text = 0

            '''For i = 0 To ds1.Tables("ComprobantesDetalles").Rows.Count - 1
            '''    If f.dgFacturacionCliente.Item(i, 4) = "Crédito" Then
            '''        f.lblCredito.Text = CDbl(CDbl(f.lblCredito.Text) + CDbl(f.dgFacturacionCliente.Item(i, 3))).ToString(Round)
            '''    Else
            '''        f.lblDebito.Text = CDbl(CDbl(f.lblDebito.Text) + CDbl(f.dgFacturacionCliente.Item(i, 3))).ToString(Round)
            '''    End If
            '''Next

            ''f.lblDiferencia.Text = CDbl(CDbl(f.lblDebito.Text) - CDbl(f.lblCredito.Text)).ToString(Round)

            '''Rutinas.FormatGenerico(f.dgFacturacionCliente, ds1.Tables("ComprobantesDetalles"))

            ''f.lblCheque.Text = compDet.Cheque
            ''If f.lblCheque.Text = "0" Then
            ''    f.etCheque.Visible = False
            ''    f.lblCheque.Visible = False
            ''    f.lblChequeNombre.Visible = False
            ''    f.etchequeNombre.Visible = False
            ''Else
            ''    f.etCheque.Visible = True
            ''    f.lblCheque.Visible = True
            ''    f.lblChequeNombre.Visible = True
            ''    f.etchequeNombre.Visible = True
            ''End If

            '''Me.Hide()
        End Sub

        Private Sub cmdVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdVer.Click
            'If Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 5) = 1 Then
            '    MostrarFactura()
            'ElseIf Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 5) = 2 Then
            '    MostrarCheque()
            'Else
            MostrarComprobante()
            'End If
        End Sub

        'Dim ts1 As DataGridTableStyle



        '''
        '''Private Sub AddCustomDataTableStyle()
        '''    ' CODIGO
        '''    ts1 = New DataGridTableStyle()
        '''    ts1.MappingName = "Articulos"
        '''    ts1.AlternatingBackColor = Color.LightBlue
        '''    Dim colCount As Integer
        '''    colCount = 0

        '''    Codigo = New DataGridTextBoxColumn()
        '''    Codigo.MappingName = "Codigo"
        '''    Codigo.HeaderText = "Código"
        '''    Codigo.Width = 100
        '''    Codigo.ReadOnly = False
        '''    ts1.GridColumnStyles.Add(Codigo)
        '''    ts1.PreferredRowHeight = (Codigo.TextBox.Height + 3)
        '''    Codigo.NullText = ""
        '''    colCount = (colCount + 1)
        '''    AddHandler Codigo.TextBox.DoubleClick, New EventHandler(AddressOf ObtieneDato)
        '''    AddHandler Codigo.TextBox.Leave, New EventHandler(AddressOf CodigoLeaveHandler)
        '''    'AddHandler Codigo.TextBox.Enter, New EventHandler(AddressOf CodigoEnterHandler)

        '''    ' CATALOGO
        '''    Dim Nombre As DataGridTextBoxColumn
        '''    Nombre = New DataGridTextBoxColumn()
        '''    Nombre.MappingName = "Nombre"
        '''    Nombre.HeaderText = "Catalogo"
        '''    Nombre.Width = 300
        '''    Nombre.ReadOnly = True
        '''    ts1.GridColumnStyles.Add(Nombre)
        '''    ts1.PreferredRowHeight = (Nombre.TextBox.Height + 3)
        '''    Nombre.NullText = ""
        '''    colCount = (colCount + 1)

        '''    ' CONCEPTO
        '''    Dim Concepto As DataGridTextBoxColumn
        '''    Concepto = New DataGridTextBoxColumn()
        '''    Concepto.MappingName = "Concepto"
        '''    Concepto.HeaderText = "Concepto"
        '''    Concepto.Width = 250
        '''    Concepto.Alignment = HorizontalAlignment.Left
        '''    Concepto.ReadOnly = False
        '''    'Concepto.Format = "##,###0.00"
        '''    ts1.GridColumnStyles.Add(Concepto)
        '''    colCount = (colCount + 1)
        '''    Concepto.NullText = ""

        '''    ' IMPORTE ---------
        '''    'Dim Monto As DataGridTextBoxColumn
        '''    Monto = New DataGridTextBoxColumn()
        '''    Monto.MappingName = "Monto"
        '''    Monto.HeaderText = "Monto"
        '''    Monto.Width = 100
        '''    Monto.Alignment = HorizontalAlignment.Right
        '''    Monto.ReadOnly = False
        '''    Monto.Format = "##,###0.00"
        '''    ts1.GridColumnStyles.Add(Monto)
        '''    colCount = (colCount + 1)
        '''    Monto.NullText = CDbl(0).ToString(Round)

        '''    ' DEBITO / CREDITO --- 0 / 1
        '''    'Dim Proceso As DataGridComboBox
        '''    Proceso = New DataGridComboBox(New ComboValueChanged(AddressOf MyComboCredito))
        '''    Proceso.MappingName = "Proceso"
        '''    Proceso.HeaderText = "Débito/Crédito"
        '''    Proceso.Width = 90
        '''    Proceso.Alignment = HorizontalAlignment.Center
        '''    Proceso.ReadOnly = True
        '''    Proceso.ColumnComboBox.Items.Add("Débito")
        '''    Proceso.ColumnComboBox.Items.Add("Crédito")

        '''    ts1.GridColumnStyles.Add(Proceso)
        '''    colCount = (colCount + 1)
        '''    Proceso.NullText = "-Seleccione-"

        '''    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''    'STEP 6: Add the tablestyle to your datagrids tablestlye collection
        '''    ts1.AllowSorting = False
        '''    ts1.HeaderFont = dgFacturacionCliente.HeaderFont

        '''    'dgFacturacionCliente.CaptionVisible = False
        '''    'dgFacturacionCliente.TableStyles.Clear()
        '''    'dgFacturacionCliente.TableStyles.Add(ts1)
        '''End Sub

        '''Private Sub MakeDataSet()
        '''    ' Create a DataSet.
        '''    myDataSet = New DataSet("myDataSet")

        '''    ' Create two DataTables.
        '''    'Dim tCust As DataTable
        '''    tCust = New DataTable("Articulos")

        '''    ' Create two columns, and add them to the first table.

        '''    Dim cCodigo As DataColumn
        '''    cCodigo = New DataColumn("Codigo")


        '''    Dim cNombre As DataColumn
        '''    cNombre = New DataColumn("Nombre")

        '''    Dim cConcepto As DataColumn
        '''    cConcepto = New DataColumn("Concepto")

        '''    Dim cMonto As DataColumn
        '''    cMonto = New DataColumn("Monto")

        '''    Dim cProceso As DataColumn
        '''    cProceso = New DataColumn("Proceso")


        '''    tCust.Columns.Add(cCodigo)
        '''    tCust.Columns.Add(cNombre)
        '''    tCust.Columns.Add(cConcepto)
        '''    tCust.Columns.Add(cMonto)
        '''    tCust.Columns.Add(cProceso)

        '''    'tCust.Columns.Add(cCurrent2)
        '''    ' Add the tables to the DataSet.
        '''    myDataSet.Tables.Add(tCust)
        '''    Dim newRow1 As DataRow
        '''    Dim j As Integer

        '''    For j = 0 To ds1.Tables("ComprobantesDetalles").Rows.Count - 1
        '''        newRow1 = tCust.NewRow
        '''        newRow1("Codigo") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Cuenta")
        '''        tCust.Rows.Add(newRow1)

        '''        tCust.Rows(j)("Nombre") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Nombre")
        '''        tCust.Rows(j)("Concepto") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Concepto")
        '''        tCust.Rows(j)("Monto") = CDbl(ds1.Tables("ComprobantesDetalles").Rows(j).Item("Monto")).ToString(Round)
        '''        tCust.Rows(j)("Proceso") = ds1.Tables("ComprobantesDetalles").Rows(j).Item("Proceso")

        '''    Next
        '''End Sub

        '''Public Sub MyComboCredito(ByVal rowChanging As Integer, ByVal newValue As Object)
        '''    Try
        '''        If Indice >= 0 Then
        '''            If tCust.Rows.Count < rowChanging + 1 Then
        '''                Dim newRow1 As DataRow
        '''                newRow1 = tCust.NewRow
        '''                tCust.Rows.Add(newRow1)
        '''                newRow1("Proceso") = Proceso.ColumnComboBox.Items.Item(Indice)
        '''            Else
        '''                tCust.Rows(rowChanging)("Proceso") = Proceso.ColumnComboBox.Items.Item(Indice)
        '''            End If
        '''        End If
        '''    Catch ex As Exception
        '''        MsgBox(ex.Message & "MyComboValueChanged")
        '''    End Try
        '''End Sub

        '''Private Sub ObtieneDato(ByVal sender As Object, ByVal e As EventArgs)
        '''    Dim F As New frmCuentasBuscar()
        '''    F.ShowDialog()

        '''    Dim f1 As frmComprobantesDetalles = f1.Instance

        '''    'ArticuloCodigo.TextBox.ReadOnly = True
        '''    If F.lblSalir.Text = 0 Then
        '''        Exit Sub
        '''    End If

        '''    If tCust.Rows.Count < f1.dgFacturacionCliente.CurrentRowIndex + 1 Then
        '''        Dim newRow1 As DataRow
        '''        newRow1 = tCust.NewRow
        '''        tCust.Rows.Add(newRow1)
        '''        newRow1("Codigo") = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
        '''        newRow1("Nombre") = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        '''    Else
        '''        tCust.Rows(f1.dgFacturacionCliente.CurrentRowIndex)("Codigo") = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
        '''        tCust.Rows(f1.dgFacturacionCliente.CurrentRowIndex)("Nombre") = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        '''    End If
        '''End Sub

        '''Private Sub CodigoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
        '''    Dim dsCatalogo As DataSet
        '''    Dim f1 As frmComprobantesDetalles = f1.Instance
        '''    If Codigo.TextBox.Text = "" Then
        '''        Exit Sub
        '''    Else
        '''        dsCatalogo = Catalogo.CatalogoXCuenta(Me.Codigo.TextBox.Text)
        '''        If dsCatalogo.Tables("Catalogo").Rows.Count = 0 Then
        '''            MsgBox("Cuenta no existe", MsgBoxStyle.Information)
        '''            Me.Codigo.TextBox.Focus()
        '''            'Me.Codigo.TextBox.Text = Me.CodigoAnterior.ToString
        '''            Exit Sub
        '''        Else
        '''            If dsCatalogo.Tables("Catalogo").Rows(0).Item("Tipo") <> "A" Then
        '''                MsgBox("Esta Cuenta no es de tipo AUXILIAR")
        '''                Exit Sub
        '''            Else
        '''                Me.tCust.Rows(f1.dgFacturacionCliente.CurrentRowIndex)("Codigo") = dsCatalogo.Tables("Catalogo").Rows(0).Item("Cuenta")
        '''                Me.tCust.Rows(f1.dgFacturacionCliente.CurrentRowIndex)("Nombre") = dsCatalogo.Tables("Catalogo").Rows(0).Item("Nombre")
        '''            End If
        '''        End If
        '''    End If
        '''    'If Not IsNumeric(Descuento.TextBox.Text) Then
        '''    '    Descuento.TextBox.Text = ValorActualDescuento.ToString(Round)

        '''    '    If CDbl(Descuento.TextBox.Text) < 0 Then
        '''    '        MsgBox("El Descuento debe ser mayor o igual a Cero (0)", MsgBoxStyle.Information)
        '''    '        Descuento.TextBox.Text = ValorActualDescuento.ToString(Round)
        '''    '        Exit Sub
        '''    '    ElseIf CDbl(Descuento.TextBox.Text >= 100) Then
        '''    '        MsgBox("El Descuento debe ser menor que 100%", MsgBoxStyle.Information)
        '''    '        Descuento.TextBox.Text = ValorActualDescuento.ToString(Round)
        '''    '        Exit Sub
        '''    '    Else
        '''    '        Descuento.TextBox.Text = CDbl(Descuento.TextBox.Text).ToString(Round)
        '''    '    End If
        '''    'End If
        '''End Sub

        '''Dim CodigoAnterior As String
        '''Private Sub CodigoEnterHandler(ByVal sender As Object, ByVal e As EventArgs)
        '''    'CodigoAnterior = Codigo.TextBox.Text.ToString
        '''End Sub

        Private Sub cbPeriodos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPeriodos.SelectedValueChanged
            If Not IsNumeric(Me.cbPeriodos.SelectedValue) Then
                Exit Sub
            End If
            Buscar()
        End Sub

        Public Sub Buscar()
            Dim Ds As New DataSet()
            Dim Fechas As String
            Dim Inicial As String
            Dim Final As String

            If dtpFecha.Enabled = True Then
                Fechas = CDate(dtpFecha.Value).ToShortDateString
            Else
                Fechas = ""
            End If

            If dtpInicial.Enabled = True And dtpFinal.Enabled = True Then
                Inicial = CDate(dtpInicial.Value).ToShortDateString
                Final = CDate(dtpFinal.Value).ToShortDateString
            Else
                Inicial = ""
                Final = ""
            End If

            If Validar() = True Then
                'Ds = Comp.GetComprobantesList(Fechas, cbTipoComp.SelectedValue, txtNo.Text, txtCuenta.Text, CbMeses.SelectedValue, txtAnno.Text, r.FechaANSIComp(Inicial), r.FechaANSIComp(Final), cbPeriodos.SelectedValue)
                Me.dgComprobantes.DataSource = Ds.Tables("Comprobantes").DefaultView
            End If
        End Sub

        Private Sub txtAnno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnno.KeyPress
            If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
                If Char.IsDigit(e.KeyChar) = False Then
                    e.Handled = True
                    Exit Sub
                End If
            End If
        End Sub

        Private Sub dtpInicial_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpInicial.ValueChanged
            Me.dtpFinal.MinDate = Me.dtpInicial.Value
        End Sub

        'Private Sub dtpFinal_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFinal.ValueChanged
        '    Me.dtpFinal.MinDate = Me.dtpFinal
        'End Sub

        Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
            Dim Registros As Integer

            Registros = Comp.ComprobanteAnularBuscar(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0), cbPeriodos.SelectedValue, Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1))

            If Registros > 0 Then
                MsgBox("El comprobante ya fue anulado", MsgBoxStyle.Information)
                Exit Sub
            End If

            If MsgBox("¿Esta seguro que desea anular el comprobante No.: " & Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0) & " de la fecha: " & Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                Exit Sub
            End If

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Try
                Comp.ComprobanteAnular(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0), cbPeriodos.SelectedValue, Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1))
                VB.SysContab.Rutinas.okTransaccion()
            Catch ex As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(ex.Message, MsgBoxStyle.Information)
                Exit Sub
            End Try

            Buscar()

            'If MsgBox("Esta seguro que quiere borrar el comprobante No.: " & Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0) & " de la fecha: " & Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            '    Exit Sub
            'End If

            'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            'DBConnFacturas.Open()
            'transaccionFacturas = DBConnFacturas.BeginTransaction

            'Try
            '    Comp.ComprobanteBorrar(Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0), cbPeriodos.SelectedValue, Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1))
            '    transaccionFacturas.Commit()
            '    DBConnFacturas.Close()
            'Catch ex As Exception
            '    transaccionFacturas.Rollback()
            '    DBConnFacturas.Close()
            '    MsgBox(ex.Message, MsgBoxStyle.Information)
            '    Exit Sub
            'End Try

            'Buscar()
        End Sub

        Private Sub cmdOrdenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrdenar.Click
            Exit Sub

            If Me.CbMeses.SelectedValue = 0 Then
                MsgBox("Seleccione el mes", MsgBoxStyle.Information)
                Me.CbMeses.Focus()
                Exit Sub
            End If

            Dim dsComp As DataSet
            Dim i As Integer

            dsComp = Comp.ComprobantesOrdenarXFecha(cbPeriodos.SelectedValue, Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1))

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                For i = 0 To dsComp.Tables("Comprobantes").Rows.Count - 1
                    Comp.ComprobantesOrdenarUpdate(dsComp.Tables("Comprobantes").Rows(i).Item("Comp_No"), cbPeriodos.SelectedValue, Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1), i + 1)
                Next

                Comp.ComprobantesOrdenar(cbPeriodos.SelectedValue, Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1))
                VB.SysContab.Rutinas.okTransaccion()

            Catch ex As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Buscar()
        End Sub

        Private Sub MostrarFactura()
            Dim f As DataGridTextBoxCombo.frmFacturaProveedorEditar = f.Instance
            f.Comp = Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0)
            f.Per = cbPeriodos.SelectedValue
            f.Fecha = Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1)
            f.MdiParent = Me.MdiParent
            f.Show()
        End Sub

        Private Sub MostrarCheque()
            Dim f As DataGridTextBoxCombo.frmChequesEditar = f.Instance
            f.MdiParent = Me.MdiParent
            f.etInicio.Text = "1"
            f.etComprobante.Text = Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0)
            f.etFecha.Text = Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1)
            f.etPeriodo.Text = cbPeriodos.SelectedValue
            f.Show()
            f.WindowState = FormWindowState.Maximized
            f.etInicio.Text = "0"
        End Sub

        Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
            Aceptar = True
            Me.Close()
        End Sub

    End Class

End Namespace
