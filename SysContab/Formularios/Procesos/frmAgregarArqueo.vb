Imports System.Data.SqlClient

Public Class frmAgregarArqueo
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarArqueo = Nothing

    Public Shared Function Instance() As frmAgregarArqueo
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarArqueo()
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
    Friend WithEvents dgDepositos As System.Windows.Forms.DataGrid
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents etTotalT As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents etArqueoNumero As System.Windows.Forms.Label
    Friend WithEvents cmdBuscarArqueos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents etTotalXDia As System.Windows.Forms.Label
    Friend WithEvents etTotalContado As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents etTotalCredito As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents etTotalAbonos As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents etTotalAdelantos As System.Windows.Forms.Label
    Friend WithEvents etTotalCuentasXCobrar As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents etTotal1 As System.Windows.Forms.Label
    Friend WithEvents etTotal As System.Windows.Forms.LinkLabel
    Friend WithEvents etOtrosIngresos As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etRetenciones As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgDepositos = New System.Windows.Forms.DataGrid()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBuscarArqueos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.etTotal1 = New System.Windows.Forms.Label()
        Me.etTotalT = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.etArqueoNumero = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.etTotalXDia = New System.Windows.Forms.Label()
        Me.etTotalContado = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.etTotalCredito = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.etTotalAbonos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.etTotalAdelantos = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.etTotalCuentasXCobrar = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.etTotal = New System.Windows.Forms.LinkLabel()
        Me.etOtrosIngresos = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.etRetenciones = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgDepositos)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 420)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'dgDepositos
        '
        Me.dgDepositos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgDepositos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgDepositos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgDepositos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgDepositos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgDepositos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgDepositos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgDepositos.DataMember = ""
        Me.dgDepositos.FlatMode = True
        Me.dgDepositos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDepositos.ForeColor = System.Drawing.Color.Black
        Me.dgDepositos.GridLineColor = System.Drawing.Color.Silver
        Me.dgDepositos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgDepositos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgDepositos.HeaderForeColor = System.Drawing.Color.White
        Me.dgDepositos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDepositos.Location = New System.Drawing.Point(8, 9)
        Me.dgDepositos.Name = "dgDepositos"
        Me.dgDepositos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgDepositos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgDepositos.ReadOnly = True
        Me.dgDepositos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgDepositos.SelectionForeColor = System.Drawing.Color.White
        Me.dgDepositos.Size = New System.Drawing.Size(760, 405)
        Me.dgDepositos.TabIndex = 12
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Location = New System.Drawing.Point(272, 17)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 35)
        Me.cmdCancelar.TabIndex = 25
        Me.cmdCancelar.Text = "&Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdAyuda)
        Me.GroupBox2.Controls.Add(Me.cmdBuscarArqueos)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 453)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 60)
        Me.GroupBox2.TabIndex = 154
        Me.GroupBox2.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAyuda.Appearance.Options.UseFont = True
        Me.cmdAyuda.Location = New System.Drawing.Point(184, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 28
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdBuscarArqueos
        '
        Me.cmdBuscarArqueos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscarArqueos.Appearance.Options.UseFont = True
        Me.cmdBuscarArqueos.Location = New System.Drawing.Point(96, 17)
        Me.cmdBuscarArqueos.Name = "cmdBuscarArqueos"
        Me.cmdBuscarArqueos.Size = New System.Drawing.Size(72, 35)
        Me.cmdBuscarArqueos.TabIndex = 27
        Me.cmdBuscarArqueos.Text = "&Ver Arqueos"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 17)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 35)
        Me.cmdAceptar.TabIndex = 26
        Me.cmdAceptar.Text = "&Guardar"
        '
        'etTotal1
        '
        Me.etTotal1.BackColor = System.Drawing.SystemColors.Control
        Me.etTotal1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotal1.ForeColor = System.Drawing.Color.Maroon
        Me.etTotal1.Location = New System.Drawing.Point(520, 465)
        Me.etTotal1.Name = "etTotal1"
        Me.etTotal1.Size = New System.Drawing.Size(200, 34)
        Me.etTotal1.TabIndex = 157
        Me.etTotal1.Text = "0.00"
        Me.etTotal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.etTotal1.Visible = False
        '
        'etTotalT
        '
        Me.etTotalT.BackColor = System.Drawing.SystemColors.Control
        Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etTotalT.Location = New System.Drawing.Point(816, 457)
        Me.etTotalT.Name = "etTotalT"
        Me.etTotalT.Size = New System.Drawing.Size(184, 25)
        Me.etTotalT.TabIndex = 156
        Me.etTotalT.Text = "Total Ingresos del día:"
        Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(184, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "No. Arqueo:"
        '
        'etArqueoNumero
        '
        Me.etArqueoNumero.BackColor = System.Drawing.SystemColors.Control
        Me.etArqueoNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etArqueoNumero.ForeColor = System.Drawing.Color.White
        Me.etArqueoNumero.Location = New System.Drawing.Point(288, 9)
        Me.etArqueoNumero.Name = "etArqueoNumero"
        Me.etArqueoNumero.Size = New System.Drawing.Size(272, 21)
        Me.etArqueoNumero.TabIndex = 158
        Me.etArqueoNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(72, 9)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 160
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(840, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 17)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Facturación del día:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'etTotalXDia
        '
        Me.etTotalXDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalXDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalXDia.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalXDia.Location = New System.Drawing.Point(800, 60)
        Me.etTotalXDia.Name = "etTotalXDia"
        Me.etTotalXDia.Size = New System.Drawing.Size(200, 26)
        Me.etTotalXDia.TabIndex = 162
        Me.etTotalXDia.Text = "0.00"
        Me.etTotalXDia.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'etTotalContado
        '
        Me.etTotalContado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalContado.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalContado.Location = New System.Drawing.Point(800, 112)
        Me.etTotalContado.Name = "etTotalContado"
        Me.etTotalContado.Size = New System.Drawing.Size(200, 26)
        Me.etTotalContado.TabIndex = 164
        Me.etTotalContado.Text = "0.00"
        Me.etTotalContado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(904, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 163
        Me.Label6.Text = "Contado:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'etTotalCredito
        '
        Me.etTotalCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalCredito.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalCredito.Location = New System.Drawing.Point(800, 164)
        Me.etTotalCredito.Name = "etTotalCredito"
        Me.etTotalCredito.Size = New System.Drawing.Size(200, 26)
        Me.etTotalCredito.TabIndex = 166
        Me.etTotalCredito.Text = "0.00"
        Me.etTotalCredito.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(904, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 18)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Crédito:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'etTotalAbonos
        '
        Me.etTotalAbonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalAbonos.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalAbonos.Location = New System.Drawing.Point(800, 267)
        Me.etTotalAbonos.Name = "etTotalAbonos"
        Me.etTotalAbonos.Size = New System.Drawing.Size(200, 26)
        Me.etTotalAbonos.TabIndex = 168
        Me.etTotalAbonos.Text = "0.00"
        Me.etTotalAbonos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(904, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 167
        Me.Label7.Text = "Abonos:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'etTotalAdelantos
        '
        Me.etTotalAdelantos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalAdelantos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalAdelantos.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalAdelantos.Location = New System.Drawing.Point(800, 215)
        Me.etTotalAdelantos.Name = "etTotalAdelantos"
        Me.etTotalAdelantos.Size = New System.Drawing.Size(200, 26)
        Me.etTotalAdelantos.TabIndex = 170
        Me.etTotalAdelantos.Text = "0.00"
        Me.etTotalAdelantos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(904, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 17)
        Me.Label8.TabIndex = 169
        Me.Label8.Text = "Adelantos:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'etTotalCuentasXCobrar
        '
        Me.etTotalCuentasXCobrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalCuentasXCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalCuentasXCobrar.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalCuentasXCobrar.Location = New System.Drawing.Point(800, 319)
        Me.etTotalCuentasXCobrar.Name = "etTotalCuentasXCobrar"
        Me.etTotalCuentasXCobrar.Size = New System.Drawing.Size(200, 26)
        Me.etTotalCuentasXCobrar.TabIndex = 172
        Me.etTotalCuentasXCobrar.Text = "0.00"
        Me.etTotalCuentasXCobrar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(832, 302)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 17)
        Me.Label9.TabIndex = 171
        Me.Label9.Text = "Cuentas X Cobrar:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'etTotal
        '
        Me.etTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotal.LinkColor = System.Drawing.Color.Maroon
        Me.etTotal.Location = New System.Drawing.Point(800, 482)
        Me.etTotal.Name = "etTotal"
        Me.etTotal.Size = New System.Drawing.Size(200, 35)
        Me.etTotal.TabIndex = 173
        Me.etTotal.TabStop = True
        Me.etTotal.Text = "0.00"
        Me.etTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'etOtrosIngresos
        '
        Me.etOtrosIngresos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etOtrosIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etOtrosIngresos.ForeColor = System.Drawing.Color.Maroon
        Me.etOtrosIngresos.Location = New System.Drawing.Point(800, 370)
        Me.etOtrosIngresos.Name = "etOtrosIngresos"
        Me.etOtrosIngresos.Size = New System.Drawing.Size(200, 26)
        Me.etOtrosIngresos.TabIndex = 175
        Me.etOtrosIngresos.Text = "0.00"
        Me.etOtrosIngresos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(832, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 17)
        Me.Label10.TabIndex = 174
        Me.Label10.Text = "Otros Ingresos"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'etRetenciones
        '
        Me.etRetenciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etRetenciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etRetenciones.ForeColor = System.Drawing.Color.Maroon
        Me.etRetenciones.Location = New System.Drawing.Point(800, 422)
        Me.etRetenciones.Name = "etRetenciones"
        Me.etRetenciones.Size = New System.Drawing.Size(200, 26)
        Me.etRetenciones.TabIndex = 177
        Me.etRetenciones.Text = "0.00"
        Me.etRetenciones.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(832, 405)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(168, 17)
        Me.Label11.TabIndex = 176
        Me.Label11.Text = "Retenciones - Impuestos"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'frmAgregarArqueo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 527)
        Me.Controls.Add(Me.etRetenciones)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.etOtrosIngresos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.etTotal)
        Me.Controls.Add(Me.etTotalCuentasXCobrar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.etTotalAdelantos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.etTotalAbonos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.etTotalCredito)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.etTotalContado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.etTotalXDia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.etArqueoNumero)
        Me.Controls.Add(Me.etTotal1)
        Me.Controls.Add(Me.etTotalT)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmAgregarArqueo"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim Depositos As New VB.SysContab.DepositosDB
    Dim Bancos As New VB.SysContab.BancosDB
    Dim Clientes As New VB.SysContab.ClientesDB
    Dim TotalXDia As New VB.SysContab.FacturacionXDia

    Dim BancoDetalle As New VB.SysContab.BancosDetails

    Private WithEvents myDataSet As DataSet
    Dim tCust As DataTable

    Dim MontoAsignar As New DataGridTextBoxColumn

    Dim ValorActualMonto As Double
    Dim ds As DataSet

    Private myCheckBoxCol As Integer = 5 'my checkbox column 

    Dim r As New VB.SysContab.Rutinas

    Dim i As Integer
    Dim k As Integer

    Dim Fecha As String
    Dim Inicio As Boolean

    Dim newRow1 As DataRow

    Dim Total As Double

    Dim Arqueo As Integer
#End Region
    Dim Cajas As New VB.SysContab.CajasDB
    Dim Caj As Integer

    Private Sub frmAsignarDepositos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabla As DataTable
        'r.CambiarEstilo(Me)
        r.FormularioColor(Me)
        Caj = Cajas.PcNombre(Environment.MachineName.ToString).Tables("Cajas").Rows(0).Item("cj_codigo").ToString()
        Fecha = dtpFecha.Value.Date

        Arqueo = 1

        TotalXDia = Clientes.FacturacionXDia(Fecha)

        Me.etTotalXDia.Text = CDbl(TotalXDia.Total).ToString(Round)
        Me.etTotalContado.Text = CDbl(TotalXDia.TotalContado).ToString(Round)
        Me.etTotalCredito.Text = CDbl(TotalXDia.TotalCredito).ToString(Round)
        Me.etTotalAbonos.Text = CDbl(TotalXDia.TotalCobros).ToString(Round)
        Me.etTotalAdelantos.Text = CDbl(TotalXDia.TotalAdelantos).ToString(Round)
        Me.etRetenciones.Text = (CDbl(TotalXDia.TotalRetenciones) * -1).ToString(Round)

        '''Me.etTotal.Text = CDbl(CDbl(TotalXDia.TotalContado) + CDbl(TotalXDia.TotalCobros) + CDbl(TotalXDia.TotalAdelantos)).ToString(Round)
        Me.etTotalCuentasXCobrar.Text = CDbl(CDbl(TotalXDia.TotalCredito) - CDbl(TotalXDia.TotalAdelantos)).ToString(Round)

        ds = Clientes.CobrosArquear(Fecha, Caj)
        etArqueoNumero.Text = Clientes.ArqueoNumero(Fecha) & "-" & Fecha
        etArqueoNumero.ForeColor = Color.Black
        'etArqueoNumero.BackColor = Color.FromKnownColor(KnownColor.Window) 'FromArgb(102, 153, 153)

        'BancoDetalle = Bancos.GetDetails(Banco)

        'etDescripcion.Text = "Arqueo de Caja del día:   " & Fecha
        'etDescripcion.BackColor = Color.FromArgb(102, 153, 153)
        dgDepositos.CaptionText = "Ingresos por Cheques y Efectivo"

        MakeDataSet()
        dgDepositos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()

        Me.etTotal.Text = CDbl(CDbl(TotalXDia.TotalContado) + CDbl(TotalXDia.TotalCobros) + CDbl(TotalXDia.TotalAdelantos) + CDbl(Me.etOtrosIngresos.Text) + CDbl(Me.etRetenciones.Text)).ToString(Round)

        'dgDepositos.Text = "Lista de Cheques"

        dgDepositos.ReadOnly = True

        Me.Refresh()

    End Sub

    Private Sub AddCustomDataTableStyle()

        'STEP 1: Create a DataTable style object and set properties if required.
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle
        'specify the table from dataset (required step)
        ts1.MappingName = "Item"
        ' Set other properties (optional step)
        ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount As Integer
        colCount = 0

        'Dim Linea As New DataGridTextBoxColumn()
        'Linea.MappingName = "Linea"
        'Linea.HeaderText = ""
        'Linea.ReadOnly = True
        'Linea.Alignment = HorizontalAlignment.Left
        'Linea.Width = 30
        'Linea.NullText = ""

        'ts1.GridColumnStyles.Add(Linea)
        'colCount = (colCount + 1)

        Dim Numero As New DataGridTextBoxColumn
        Numero.MappingName = "Numero"
        Numero.HeaderText = "Numero"
        Numero.ReadOnly = True
        Numero.Alignment = HorizontalAlignment.Left
        Numero.Width = 0
        Numero.NullText = ""

        ts1.GridColumnStyles.Add(Numero)
        colCount = (colCount + 1)

        Dim Cheque As New DataGridTextBoxColumn
        Cheque.MappingName = "Cheque"
        Cheque.HeaderText = "No.Cheque - Tarjeta"
        Cheque.ReadOnly = True
        Cheque.Alignment = HorizontalAlignment.Left
        Cheque.Width = 150
        Cheque.NullText = ""

        ts1.GridColumnStyles.Add(Cheque)
        colCount = (colCount + 1)

        Dim Banco As New DataGridTextBoxColumn
        Banco.MappingName = "Banco"
        Banco.HeaderText = "Banco - Emisor"
        Banco.ReadOnly = True
        Banco.Alignment = HorizontalAlignment.Left
        Banco.Width = 300
        Banco.NullText = ""

        ts1.GridColumnStyles.Add(Banco)
        colCount = (colCount + 1)

        Dim MontoCheque As New DataGridTextBoxColumn
        MontoCheque.MappingName = "MontoCheque"
        MontoCheque.HeaderText = "Monto"
        MontoCheque.ReadOnly = True
        MontoCheque.Alignment = HorizontalAlignment.Right
        MontoCheque.Width = 100
        MontoCheque.NullText = ""

        ts1.GridColumnStyles.Add(MontoCheque)
        colCount = (colCount + 1)

        Dim Fecha As New DataGridTextBoxColumn
        Fecha.MappingName = "Fecha"
        Fecha.HeaderText = "Fecha"
        Fecha.ReadOnly = True
        Fecha.Alignment = HorizontalAlignment.Left
        Fecha.Width = 80
        Fecha.NullText = ""

        ts1.GridColumnStyles.Add(Fecha)
        colCount = (colCount + 1)

        Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        boolCol.MappingName = "Agregar"
        boolCol.HeaderText = "Arquear"
        boolCol.Alignment = HorizontalAlignment.Center

        CType(boolCol, DataGridBoolColumn).AllowNull = False

        boolCol.Width = 70
        boolCol.ReadOnly = False

        boolCol.NullText = ""


        AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)

        ts1.GridColumnStyles.Add(boolCol)
        colCount = (colCount + 1)

        ts1.AllowSorting = False
        ts1.GridLineColor = Color.FromArgb(70, 130, 180)
        ts1.HeaderFont = Me.dgDepositos.HeaderFont
        ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
        ts1.PreferredRowHeight = 25

        myDataSet.Tables("Item").DefaultView.AllowDelete = False
        myDataSet.Tables("Item").DefaultView.AllowNew = False
        myDataSet.Tables("Item").DefaultView.AllowEdit = False

        dgDepositos.TableStyles.Clear()
        dgDepositos.TableStyles.Add(ts1)

    End Sub

    Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
        Dim s As String
        s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
        Console.WriteLine(s)
    End Sub

    Private Sub MakeDataSet()
        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")

        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust = New DataTable("Item")

        'Dim cLinea As DataColumn
        'cLinea = New DataColumn("Linea")
        'tCust.Columns.Add(cLinea)

        Dim cNumero As DataColumn
        cNumero = New DataColumn("Numero")
        tCust.Columns.Add(cNumero)

        Dim cCheque As DataColumn
        cCheque = New DataColumn("Cheque")
        tCust.Columns.Add(cCheque)

        Dim cBanco As DataColumn
        cBanco = New DataColumn("Banco")
        tCust.Columns.Add(cBanco)

        Dim cMontoCheque As DataColumn
        cMontoCheque = New DataColumn("MontoCheque")
        tCust.Columns.Add(cMontoCheque)

        Dim cFecha As DataColumn
        cFecha = New DataColumn("Fecha")
        tCust.Columns.Add(cFecha)

        Dim cAgregar As DataColumn
        cAgregar = New DataColumn("Agregar", GetType(System.Boolean))
        tCust.Columns.Add(cAgregar)

        tCust.DefaultView.AllowDelete = False
        tCust.DefaultView.AllowNew = False
        tCust.DefaultView.AllowEdit = False

        myDataSet.Tables.Add(tCust)

        Dim newRow1 As DataRow
        Total = 0
        For i = 0 To ds.Tables("Cobros").Rows.Count - 1
            newRow1 = tCust.NewRow
            tCust.Rows.Add(newRow1)

            'tCust.Rows(i)("Linea") = i + 1
            tCust.Rows(i)("Numero") = ds.Tables("Cobros").Rows(i).Item("Numero")
            tCust.Rows(i)("Cheque") = ds.Tables("Cobros").Rows(i).Item("No Cheque")
            tCust.Rows(i)("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
            tCust.Rows(i)("MontoCheque") = CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)
            tCust.Rows(i)("Fecha") = ds.Tables("Cobros").Rows(i).Item("Fecha")
            tCust.Rows(i)("Agregar") = False 'ds.Tables("Cobros").Rows(i).Item("Arqueado")

            If ds.Tables("Cobros").Rows(i).Item("Orden") = 6 Then
                Me.etOtrosIngresos.Text = CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)
            End If

            'If ds.Tables("Cobros").Rows(i).Item("Orden") = 2 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Then
            '    Total = Total + tCust.Rows(i)("MontoCheque")
            'End If
        Next
        'etTotal.Text = Total.ToString(Round)
        myDataSet.Tables("Item").DefaultView.AllowDelete = False
    End Sub

    Private Sub dgDepositos_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgDepositos.MouseUp
        Dim hti As DataGrid.HitTestInfo = Me.dgDepositos.HitTest(e.X, e.Y)
        Try
            If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
                If ds.Tables("Cobros").Rows(dgDepositos.CurrentRowIndex).Item("Orden") = 2 Or ds.Tables("Cobros").Rows(dgDepositos.CurrentRowIndex).Item("Orden") = 4 Or ds.Tables("Cobros").Rows(dgDepositos.CurrentRowIndex).Item("Orden") = 8 Then
                    Me.dgDepositos(dgDepositos.CurrentRowIndex, hti.Column) = False
                    Exit Sub
                End If
                Me.dgDepositos(hti.Row, hti.Column) = Not CBool(Me.dgDepositos(hti.Row, hti.Column))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim Cantidad As Integer

        'If MsgBox("Desea guardar los datos?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
        '    Exit Sub
        'End If

        Dim ArqueoNumero As Long
        Try
            Cantidad = 0
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            ArqueoNumero = Clientes.ArqueoNumero(Fecha)

            Clientes.ArqueosAdd(ArqueoNumero, Fecha)

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Agregar") = True Then
                    If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Then
                        Clientes.ArqueosDetallesAdd(ArqueoNumero, Fecha, tCust.Rows(i)("Numero"))
                    ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 5 Then
                        Clientes.ArqueosDetallesEfectivoAdd(ArqueoNumero, Fecha)
                    ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 7 Then
                        Clientes.ArqueosDetallesNotaDebitoAdd(ArqueoNumero, Fecha)
                    End If
                    Cantidad = 1
                    'Else
                    '    If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Then
                    '        Clientes.CobrosUpdateArqueoCheque(tCust.Rows(i)("Numero"), 0)
                    '    ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Then
                    '        Clientes.CobrosUpdateArqueoEfectivo(0, Fecha)
                    '    End If
                End If
            Next

            If Cantidad = 0 Then
                MsgBox("Debe seleccionar al menos un registro", MsgBoxStyle.Information)
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If

            VB.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox(ex.Message & "Aceptar")
            Exit Sub
        End Try

        ds = Clientes.CobrosArquear(Fecha)
        etArqueoNumero.Text = Clientes.ArqueoNumero(Fecha) & "-" & Fecha

        MakeDataSet()
        dgDepositos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
    End Sub

    '''''Private Sub chkArqueados_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkArqueados.CheckedChanged
    '''''    If chkArqueados.Checked = True Then
    '''''        Arqueo = 1
    '''''        Me.chkNoArqueados.Checked = False
    '''''        Me.chkTodos.Checked = False
    '''''    ElseIf chkArqueados.Checked = False And Me.chkTodos.Checked = False Then
    '''''        Me.chkNoArqueados.Checked = True
    '''''        Arqueo = 0
    '''''    End If
    '''''End Sub

    '''''Private Sub chkNoArqueados_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNoArqueados.CheckedChanged
    '''''    If chkNoArqueados.Checked = True Then
    '''''        Arqueo = 0
    '''''        Me.chkArqueados.Checked = False
    '''''        Me.chkTodos.Checked = False

    '''''        ds = Clientes.ChequesXBanco(0, Fecha, Arqueo)
    '''''        MakeDataSet()
    '''''        dgDepositos.SetDataBinding(myDataSet, "Item")
    '''''        AddCustomDataTableStyle()
    '''''    ElseIf chkNoArqueados.Checked = False And Me.chkTodos.Checked = False Then
    '''''        Arqueo = 1
    '''''        Me.chkArqueados.Checked = True
    '''''        ds = Clientes.ChequesXBanco(0, Fecha, Arqueo)
    '''''        MakeDataSet()
    '''''        dgDepositos.SetDataBinding(myDataSet, "Item")
    '''''        AddCustomDataTableStyle()
    '''''    End If
    '''''End Sub

    '''''Private Sub chkTodos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
    '''''    If chkTodos.Checked = True Then
    '''''        Arqueo = 2
    '''''        Me.chkArqueados.Checked = False
    '''''        Me.chkNoArqueados.Checked = False

    '''''        ds = Clientes.ChequesXBanco(0, Fecha, Arqueo)
    '''''        MakeDataSet()
    '''''        dgDepositos.SetDataBinding(myDataSet, "Item")
    '''''        AddCustomDataTableStyle()
    '''''    ElseIf chkTodos.Checked = False And Me.chkNoArqueados.Checked = False Then
    '''''        Arqueo = 1
    '''''        Me.chkArqueados.Checked = True

    '''''        ds = Clientes.ChequesXBanco(0, Fecha, Arqueo)
    '''''        MakeDataSet()
    '''''        dgDepositos.SetDataBinding(myDataSet, "Item")
    '''''        AddCustomDataTableStyle()
    '''''    End If
    '''''End Sub

    Private Sub cmdBuscarArqueos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBuscarArqueos.Click
        If Clientes.ArqueosList.Tables("Cobros").Rows.Count = 0 Then
            MsgBox("No hay Arqueos realizados", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As frmArqueosList = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
       
        Fecha = dtpFecha.Value.Date
        ds = Clientes.CobrosArquear(Fecha, Caj)
        etArqueoNumero.Text = Clientes.ArqueoNumero(Fecha) & "-" & Fecha

        TotalXDia = Clientes.FacturacionXDia(Fecha, Caj)
        Me.etOtrosIngresos.Text = "0.00"

        Me.etTotalXDia.Text = CDbl(TotalXDia.Total).ToString(Round)
        Me.etTotalContado.Text = CDbl(TotalXDia.TotalContado).ToString(Round)
        Me.etTotalCredito.Text = CDbl(TotalXDia.TotalCredito).ToString(Round)
        Me.etTotalAbonos.Text = CDbl(TotalXDia.TotalCobros).ToString(Round)
        Me.etTotalAdelantos.Text = CDbl(TotalXDia.TotalAdelantos).ToString(Round)
        Me.etRetenciones.Text = (CDbl(TotalXDia.TotalRetenciones) * -1).ToString(Round)

        Me.etTotalCuentasXCobrar.Text = CDbl(CDbl(TotalXDia.TotalCredito) - CDbl(TotalXDia.TotalAdelantos)).ToString(Round)

        MakeDataSet()
        dgDepositos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()

        Me.etTotal.Text = CDbl(CDbl(TotalXDia.TotalContado) + CDbl(TotalXDia.TotalCobros) + CDbl(TotalXDia.TotalAdelantos) + CDbl(Me.etOtrosIngresos.Text) + CDbl(Me.etRetenciones.Text)).ToString(Round)

    End Sub

    Private Sub etTotal_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles etTotal.LinkClicked
        'MsgBox("Link Clicked", MsgBoxStyle.Information)
        Dim f As frmIngresosResumen = f.Instance
        f.MdiParent = Me.MdiParent

        'Contado
        f.etTotalChequesContado.Text = CDbl(TotalXDia.TotalChequesContado).ToString(Round)
        f.etTotalTarjetasContado.Text = CDbl(TotalXDia.TotalTarjetasContado).ToString(Round)
        f.etTotalEfectivoContado.Text = CDbl(TotalXDia.TotalEfectivoContado).ToString(Round)
        f.etTotalNotasDebitoContado.Text = CDbl(TotalXDia.TotalNotasDebitoContado).ToString(Round)

        'Credito
        f.etTotalChequesCredito.Text = CDbl(TotalXDia.TotalChequesCredito).ToString(Round)
        f.etTotalTarjetasCredito.Text = CDbl(TotalXDia.TotalTarjetasCredito).ToString(Round)
        f.etTotalEfectivoCredito.Text = CDbl(TotalXDia.TotalEfectivoCredito).ToString(Round)
        f.etTotalNotasDebitoCredito.Text = CDbl(TotalXDia.TotalNotasDebitoCredito).ToString(Round)

        'Abonos
        f.etTotalChequesAbonos.Text = CDbl(TotalXDia.TotalChequesAbonos).ToString(Round)
        f.etTotalTarjetasAbonos.Text = CDbl(TotalXDia.TotalTarjetasAbonos).ToString(Round)
        f.etTotalEfectivoAbonos.Text = CDbl(TotalXDia.TotalEfectivoAbonos).ToString(Round)
        f.etTotalNotasDebitoAbonos.Text = CDbl(TotalXDia.TotalNotasDebitoAbonos).ToString(Round)

        'Total
        f.etTotalCheques.Text = CDbl(CDbl(TotalXDia.TotalChequesContado) + CDbl(TotalXDia.TotalChequesCredito) + CDbl(TotalXDia.TotalChequesAbonos)).ToString(Round)
        f.etTotalTarjetas.Text = CDbl(CDbl(TotalXDia.TotalTarjetasContado) + CDbl(TotalXDia.TotalTarjetasCredito) + CDbl(TotalXDia.TotalTarjetasAbonos)).ToString(Round)
        f.etTotalEfectivo.Text = CDbl(CDbl(TotalXDia.TotalEfectivoContado) + CDbl(TotalXDia.TotalEfectivoCredito) + CDbl(TotalXDia.TotalEfectivoAbonos)).ToString(Round)
        f.etTotalNotasDebito.Text = CDbl(CDbl(TotalXDia.TotalNotasDebitoContado) + CDbl(TotalXDia.TotalNotasDebitoCredito) + CDbl(TotalXDia.TotalNotasDebitoAbonos)).ToString(Round)

        f.etTotal.Text = CDbl(CDbl(f.etTotalCheques.Text) + CDbl(f.etTotalTarjetas.Text) + CDbl(f.etTotalEfectivo.Text) + CDbl(f.etTotalNotasDebito.Text)).ToString(Round)


        f.Show()

    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/Procesos/ProcesosArqueo.chm")
    End Sub
End Class
