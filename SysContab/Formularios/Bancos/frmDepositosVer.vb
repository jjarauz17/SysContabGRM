Imports System.Data.SqlClient
Imports SysContab.VB.SysContab

Public Class frmDepositosVer
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmDepositosVer = Nothing

    Public Shared Function Instance() As frmDepositosVer
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmDepositosVer()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Public Documento As String

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
    Friend WithEvents rbNoAsignadas As System.Windows.Forms.RadioButton
    Friend WithEvents rbAsignadas As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents cbFecha As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblDepositoNo As System.Windows.Forms.Label
    Friend WithEvents lblCuentaBanco As System.Windows.Forms.Label
    Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rbEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbCheques As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label18 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbEfectivo = New System.Windows.Forms.RadioButton()
        Me.rbCheques = New System.Windows.Forms.RadioButton()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblCuentaBanco = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblDepositoNo = New System.Windows.Forms.Label()
        Me.dgDepositos = New System.Windows.Forms.DataGrid()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFecha = New System.Windows.Forms.CheckBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.rbNoAsignadas = New System.Windows.Forms.RadioButton()
        Me.rbAsignadas = New System.Windows.Forms.RadioButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        Me.gbTipo.SuspendLayout()
        CType(Me.dgDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.gbTipo)
        Me.GroupBox1.Controls.Add(Me.lblCuentaBanco)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.lblDepositoNo)
        Me.GroupBox1.Controls.Add(Me.dgDepositos)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(874, 184)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'gbTipo
        '
        Me.gbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.gbTipo.Controls.Add(Me.rbEfectivo)
        Me.gbTipo.Controls.Add(Me.rbCheques)
        Me.gbTipo.Controls.Add(Me.TextBox6)
        Me.gbTipo.Controls.Add(Me.Label12)
        Me.gbTipo.Controls.Add(Me.Label17)
        Me.gbTipo.Controls.Add(Me.Label18)
        Me.gbTipo.Enabled = False
        Me.gbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipo.ForeColor = System.Drawing.Color.Maroon
        Me.gbTipo.Location = New System.Drawing.Point(404, 43)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(200, 35)
        Me.gbTipo.TabIndex = 160
        Me.gbTipo.TabStop = False
        Me.gbTipo.Visible = False
        '
        'rbEfectivo
        '
        Me.rbEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEfectivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbEfectivo.Location = New System.Drawing.Point(112, 11)
        Me.rbEfectivo.Name = "rbEfectivo"
        Me.rbEfectivo.Size = New System.Drawing.Size(80, 17)
        Me.rbEfectivo.TabIndex = 125
        Me.rbEfectivo.Text = "Efectivo"
        '
        'rbCheques
        '
        Me.rbCheques.Checked = True
        Me.rbCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCheques.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbCheques.Location = New System.Drawing.Point(8, 11)
        Me.rbCheques.Name = "rbCheques"
        Me.rbCheques.Size = New System.Drawing.Size(88, 17)
        Me.rbCheques.TabIndex = 124
        Me.rbCheques.TabStop = True
        Me.rbCheques.Text = "Cheques"
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
        'lblCuentaBanco
        '
        Me.lblCuentaBanco.Location = New System.Drawing.Point(442, 94)
        Me.lblCuentaBanco.Name = "lblCuentaBanco"
        Me.lblCuentaBanco.Size = New System.Drawing.Size(100, 25)
        Me.lblCuentaBanco.TabIndex = 118
        Me.lblCuentaBanco.Text = "Label2"
        Me.lblCuentaBanco.Visible = False
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(330, 94)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(100, 25)
        Me.lblFecha.TabIndex = 116
        Me.lblFecha.Text = "Label2"
        Me.lblFecha.Visible = False
        '
        'lblDepositoNo
        '
        Me.lblDepositoNo.Location = New System.Drawing.Point(562, 94)
        Me.lblDepositoNo.Name = "lblDepositoNo"
        Me.lblDepositoNo.Size = New System.Drawing.Size(100, 25)
        Me.lblDepositoNo.TabIndex = 117
        Me.lblDepositoNo.Text = "Label2"
        Me.lblDepositoNo.Visible = False
        '
        'dgDepositos
        '
        Me.dgDepositos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgDepositos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDepositos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgDepositos.BackgroundColor = System.Drawing.Color.AliceBlue
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
        Me.dgDepositos.Location = New System.Drawing.Point(6, 11)
        Me.dgDepositos.Name = "dgDepositos"
        Me.dgDepositos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgDepositos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgDepositos.ReadOnly = True
        Me.dgDepositos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgDepositos.SelectionForeColor = System.Drawing.Color.White
        Me.dgDepositos.Size = New System.Drawing.Size(859, 167)
        Me.dgDepositos.TabIndex = 12
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotal.Location = New System.Drawing.Point(701, 12)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(164, 25)
        Me.lblTotal.TabIndex = 158
        Me.lblTotal.Text = "Label2"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(642, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "TOTAL:"
        '
        'cbFecha
        '
        Me.cbFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbFecha.AutoSize = True
        Me.cbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbFecha.Location = New System.Drawing.Point(528, 2)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(95, 19)
        Me.cbFecha.TabIndex = 156
        Me.cbFecha.Text = "Por Fecha:"
        Me.cbFecha.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.cbFecha.Visible = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(528, 22)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(107, 20)
        Me.dtpFecha.TabIndex = 147
        Me.dtpFecha.Visible = False
        '
        'rbNoAsignadas
        '
        Me.rbNoAsignadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbNoAsignadas.AutoSize = True
        Me.rbNoAsignadas.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNoAsignadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbNoAsignadas.Location = New System.Drawing.Point(401, 15)
        Me.rbNoAsignadas.Name = "rbNoAsignadas"
        Me.rbNoAsignadas.Size = New System.Drawing.Size(113, 20)
        Me.rbNoAsignadas.TabIndex = 128
        Me.rbNoAsignadas.Text = "No Asignadas"
        '
        'rbAsignadas
        '
        Me.rbAsignadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbAsignadas.AutoSize = True
        Me.rbAsignadas.Checked = True
        Me.rbAsignadas.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAsignadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbAsignadas.Location = New System.Drawing.Point(304, 15)
        Me.rbAsignadas.Name = "rbAsignadas"
        Me.rbAsignadas.Size = New System.Drawing.Size(93, 20)
        Me.rbAsignadas.TabIndex = 127
        Me.rbAsignadas.TabStop = True
        Me.rbAsignadas.Text = "Asignadas"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Location = New System.Drawing.Point(212, 8)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(86, 35)
        Me.cmdCancelar.TabIndex = 26
        Me.cmdCancelar.Text = "Salir"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.etDescripcion)
        Me.GroupBox3.Location = New System.Drawing.Point(8, -2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(874, 34)
        Me.GroupBox3.TabIndex = 115
        Me.GroupBox3.TabStop = False
        '
        'etDescripcion
        '
        Me.etDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etDescripcion.Location = New System.Drawing.Point(7, 9)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(858, 21)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Controls.Add(Me.Button1)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.rbNoAsignadas)
        Me.PanelControl1.Controls.Add(Me.lblTotal)
        Me.PanelControl1.Controls.Add(Me.rbAsignadas)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.cbFecha)
        Me.PanelControl1.Controls.Add(Me.dtpFecha)
        Me.PanelControl1.Location = New System.Drawing.Point(8, 212)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(873, 48)
        Me.PanelControl1.TabIndex = 116
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = Global.SysContab.My.Resources.Resources.Ok
        Me.cmdAceptar.Location = New System.Drawing.Point(10, 8)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(90, 35)
        Me.cmdAceptar.TabIndex = 148
        Me.cmdAceptar.Text = "Aceptar"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Appearance.Options.UseFont = True
        Me.Button1.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_SaveFileLarge
        Me.Button1.Location = New System.Drawing.Point(106, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 159
        Me.Button1.Text = "Contabilizar"
        '
        'frmDepositosVer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(892, 272)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDepositosVer"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        CType(Me.dgDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Depositos As New VB.SysContab.DepositosDB()

    Private WithEvents myDataSet As DataSet
    Dim tCust As DataTable
    Dim r As New VB.SysContab.Rutinas()
    Dim ds As DataSet

    Private myCheckBoxCol As Integer = 7 'my checkbox column 

    Dim i As Integer

    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim ComprobantesDB As New VB.SysContab.ComprobanteDB()
    Dim PlantillasDB As New VB.SysContab.PlantillaDB()
    Dim CatalogoDB As New VB.SysContab.CatalogoDB()

    Dim Fecha As String

    Private Sub frmDepositosVer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabla As DataTable
        'r.CambiarEstilo(Me)
        r.FormularioColor(Me)
        Fecha = ""
        cbFecha.Enabled = False
        dtpFecha.Enabled = False

        etDescripcion.BackColor = Color.FromArgb(102, 153, 153)

        ds = Depositos.DepositosDetalles(Deposito)

        dgDepositos.CaptionText = ""

        MakeDataSet()
        dgDepositos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()

        If ds.Tables("Cobros").Rows.Count = 0 Then
            dgDepositos.ReadOnly = False
        Else
            If ds.Tables("Cobros").Rows(0).Item("Estado") = 1 Then
                'MsgBox("La hoja de Depositos ya fue contabilizada", MsgBoxStyle.Exclamation)
                dgDepositos.ReadOnly = True
                Me.cmdAceptar.Enabled = False
                Me.cbFecha.Enabled = False
                Me.rbAsignadas.Enabled = False
                Me.rbNoAsignadas.Enabled = False
            Else
                dgDepositos.ReadOnly = False
            End If
        End If

        Me.Refresh()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Dim f As frmDepositosList = frmDepositosList.Instance()
        f.Cargar(IIf(f.cbBancos.SelectedValue Is Nothing, 0, f.cbBancos.SelectedValue))
        Me.Close()
    End Sub

    Private Sub AddCustomDataTableStyle()

        'STEP 1: Create a DataTable style object and set properties if required.
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle()
        'specify the table from dataset (required step)
        ts1.MappingName = "Item"
        ' Set other properties (optional step)
        ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount As Integer
        colCount = 0

        Dim Numero As New DataGridTextBoxColumn()
        Numero.MappingName = "Numero"
        Numero.HeaderText = "Numero"
        Numero.ReadOnly = True
        Numero.Alignment = HorizontalAlignment.Left
        Numero.Width = 0
        Numero.NullText = ""

        ts1.GridColumnStyles.Add(Numero)
        colCount = (colCount + 1)

        Dim Cliente As New DataGridTextBoxColumn()
        Cliente.MappingName = "Cliente"
        Cliente.HeaderText = "Cliente"
        Cliente.ReadOnly = True
        Cliente.Alignment = HorizontalAlignment.Left
        Cliente.Width = 250
        Cliente.NullText = ""

        ts1.GridColumnStyles.Add(Cliente)
        colCount = (colCount + 1)

        Dim Cheque As New DataGridTextBoxColumn()
        Cheque.MappingName = "Cheque"
        Cheque.HeaderText = "Cheque"
        Cheque.ReadOnly = True
        Cheque.Alignment = HorizontalAlignment.Left
        Cheque.Width = 80
        Cheque.NullText = ""

        ts1.GridColumnStyles.Add(Cheque)
        colCount = (colCount + 1)

        Dim Banco As New DataGridTextBoxColumn()
        Banco.MappingName = "Banco"
        Banco.HeaderText = "Banco"
        Banco.ReadOnly = True
        Banco.Alignment = HorizontalAlignment.Left
        Banco.Width = 250
        Banco.NullText = ""

        ts1.GridColumnStyles.Add(Banco)
        colCount = (colCount + 1)

        Dim MontoCheque As New DataGridTextBoxColumn()
        MontoCheque.MappingName = "MontoCheque"
        MontoCheque.HeaderText = "Monto"
        MontoCheque.ReadOnly = True
        MontoCheque.Alignment = HorizontalAlignment.Right
        MontoCheque.Width = 100
        MontoCheque.NullText = ""

        ts1.GridColumnStyles.Add(MontoCheque)
        colCount = (colCount + 1)

        Dim Fecha As New DataGridTextBoxColumn()
        Fecha.MappingName = "Fecha"
        Fecha.HeaderText = "Fecha"
        Fecha.ReadOnly = True
        Fecha.Alignment = HorizontalAlignment.Left
        Fecha.Width = 80
        Fecha.NullText = ""

        ts1.GridColumnStyles.Add(Fecha)
        colCount = (colCount + 1)

        Dim Tipo As New DataGridTextBoxColumn()
        Tipo.MappingName = "Tipo"
        Tipo.HeaderText = "Tipo"
        Tipo.ReadOnly = True
        Tipo.Alignment = HorizontalAlignment.Left
        Tipo.Width = 80
        Tipo.NullText = ""

        ts1.GridColumnStyles.Add(Tipo)
        colCount = (colCount + 1)

        Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        boolCol.MappingName = "Agregar"
        boolCol.HeaderText = "Agregar"
        boolCol.Alignment = HorizontalAlignment.Center
        'uncomment this line to get a two-state checkbox
        CType(boolCol, DataGridBoolColumn).AllowNull = False

        boolCol.Width = 65

        boolCol.ReadOnly = False

        boolCol.NullText = ""

        'hook the new event to our handler in the grid
        AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
        'AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
        'AddHandler boolCol. , AddressOf CheckedChanged
        ts1.GridColumnStyles.Add(boolCol)
        colCount = (colCount + 1)

        'STEP 6: Add the tablestyle to your datagrids tablestlye collection
        'ts1.AllowSorting = False
        'ts1.HeaderFont = dgDepositos.HeaderFont
        'ts1.PreferredRowHeight = 25

        Dim Comp As New DataGridTextBoxColumn()
        Comp.MappingName = "Comp"
        Comp.HeaderText = ""
        Comp.ReadOnly = True
        Comp.Alignment = HorizontalAlignment.Right
        Comp.Width = 0
        Comp.NullText = ""
        ts1.GridColumnStyles.Add(Comp)
        colCount = (colCount + 1)

        Dim Empresa As New DataGridTextBoxColumn()
        Empresa.MappingName = "Empresa"
        Empresa.HeaderText = ""
        Empresa.ReadOnly = True
        Empresa.Alignment = HorizontalAlignment.Right
        Empresa.Width = 0
        Empresa.NullText = ""
        ts1.GridColumnStyles.Add(Empresa)
        colCount = (colCount + 1)

        Dim Periodo As New DataGridTextBoxColumn()
        Periodo.MappingName = "Periodo"
        Periodo.HeaderText = ""
        Periodo.ReadOnly = True
        Periodo.Alignment = HorizontalAlignment.Right
        Periodo.Width = 0
        Periodo.NullText = ""
        ts1.GridColumnStyles.Add(Periodo)
        colCount = (colCount + 1)

        Dim Mes As New DataGridTextBoxColumn()
        Mes.MappingName = "Mes"
        Mes.HeaderText = ""
        Mes.ReadOnly = True
        Mes.Alignment = HorizontalAlignment.Right
        Mes.Width = 0
        Mes.NullText = ""
        ts1.GridColumnStyles.Add(Mes)
        colCount = (colCount + 1)

        ts1.AllowSorting = False
        ts1.GridLineColor = Color.FromArgb(70, 130, 180)
        ts1.HeaderFont = dgDepositos.HeaderFont
        ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
        ts1.PreferredRowHeight = 25

        tCust.DefaultView.AllowDelete = False
        tCust.DefaultView.AllowNew = False
        tCust.DefaultView.AllowEdit = False

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

        ' Create two columns, and add them to the first table.
        Dim i As Integer

        'For i = 0 To ds1.Tables("Depositos").Rows.Count ' - 1
        '    Dim cAgregar As DataColumn
        '    cAgregar = New DataColumn(i, GetType(System.Boolean))
        '    tCust.Columns.Add(cAgregar)
        'Next

        Dim cNumero As DataColumn
        cNumero = New DataColumn("Numero")
        tCust.Columns.Add(cNumero)

        Dim cCliente As DataColumn
        cCliente = New DataColumn("Cliente")
        tCust.Columns.Add(cCliente)

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

        Dim cTipo As DataColumn
        cTipo = New DataColumn("Tipo")
        tCust.Columns.Add(cTipo)

        Dim cAgregar As DataColumn
        cAgregar = New DataColumn("Agregar", GetType(System.Boolean))
        tCust.Columns.Add(cAgregar)

        Dim cComp As DataColumn
        cComp = New DataColumn("Comp")
        tCust.Columns.Add(cComp)

        Dim cEmpresa As DataColumn
        cEmpresa = New DataColumn("Empresa")
        tCust.Columns.Add(cEmpresa)

        Dim cPeriodo As DataColumn
        cPeriodo = New DataColumn("Periodo")
        tCust.Columns.Add(cPeriodo)

        Dim cMes As DataColumn
        cMes = New DataColumn("Mes")
        tCust.Columns.Add(cMes)

        'For i = 0 To ds.Tables("Depositos").Rows.Count - 1
        '    Dim cAgregar As DataColumn
        '    'cAgregar = New DataColumn(ds.Tables("Depositos").Rows(i).Item("Deposito_ID") & "D", GetType(System.Boolean))
        '    cAgregar = New DataColumn(ds.Tables("Depositos").Rows(i).Item("Deposito_ID") & "D", GetType(System.Boolean))
        '    tCust.Columns.Add(cAgregar)
        'Next


        tCust.DefaultView.AllowDelete = False
        tCust.DefaultView.AllowNew = False
        tCust.DefaultView.AllowEdit = False

        'tCust.Columns.Add(cCurrent2)
        ' Add the tables to the DataSet.
        myDataSet.Tables.Add(tCust)

        'creates two DataRow variables. 
        Dim newRow1 As DataRow
        ' Create three customers in the Customers Table.
        'newRow1 = tCust.NewRow
        'newRow1(i) = False
        'tCust.Rows.Add(newRow1)

        newRow1 = tCust.NewRow
        'newRow1(i) = False
        tCust.Rows.Add(newRow1)

        If rbNoAsignadas.Checked = True Then
            tCust.Rows(0)("Agregar") = False
        Else
            tCust.Rows(0)("Agregar") = True
        End If

        'i = 0
        Dim j As Integer
        j = 1

        Dim Total As Double = 0

        For i = 0 To ds.Tables("Cobros").Rows.Count - 1

            If rbNoAsignadas.Checked = True Then
                If ds.Tables("Cobros").Rows(i).Item("Estado") = 1 Then 'Ya fue asignado
                    'Ya fue asignado
                Else

                    newRow1 = tCust.NewRow
                    'newRow1(i) = False
                    tCust.Rows.Add(newRow1)

                    tCust.Rows(j)("Numero") = ds.Tables("Cobros").Rows(i).Item("Numero")
                    tCust.Rows(j)("Cliente") = ds.Tables("Cobros").Rows(i).Item("Cliente")
                    tCust.Rows(j)("Cheque") = ds.Tables("Cobros").Rows(i).Item("No Cheque")
                    tCust.Rows(j)("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
                    tCust.Rows(j)("MontoCheque") = CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)
                    tCust.Rows(j)("Fecha") = ds.Tables("Cobros").Rows(i).Item("Fecha")
                    'tCust.Rows(i + 1)("Fecha") = Format(ds.Tables("Cobros").Rows(i).Item("Fecha"), "dd/MM/yyyy")
                    tCust.Rows(j)("Tipo") = ds.Tables("Cobros").Rows(i).Item("Tipo")

                    tCust.Rows(j)("Comp") = ds.Tables("Cobros").Rows(i).Item("Comp_No")
                    tCust.Rows(j)("Empresa") = ds.Tables("Cobros").Rows(i).Item("Empresa")
                    tCust.Rows(j)("Periodo") = ds.Tables("Cobros").Rows(i).Item("Per_ID")
                    tCust.Rows(j)("Mes") = ds.Tables("Cobros").Rows(i).Item("Mes")

                    'column.Format = "dd/MM/yyyy"
                    If Me.rbAsignadas.Checked = True Then
                        tCust.Rows(j)("Agregar") = True
                    Else
                        tCust.Rows(j)("Agregar") = False
                    End If

                    Total = CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round) + Total

                    'For j = 0 To ds.Tables("Depositos").Rows.Count - 1
                    '    tCust.Rows(i)(ds.Tables("Depositos").Rows(j).Item("Deposito_ID") & "D") = False
                    'Next

                    j = j + 1

                End If
            Else

                newRow1 = tCust.NewRow
                'newRow1(i) = False
                tCust.Rows.Add(newRow1)

                tCust.Rows(i + 1)("Numero") = ds.Tables("Cobros").Rows(i).Item("Numero")
                tCust.Rows(i + 1)("Cliente") = ds.Tables("Cobros").Rows(i).Item("Cliente")
                tCust.Rows(i + 1)("Cheque") = ds.Tables("Cobros").Rows(i).Item("No Cheque")
                tCust.Rows(i + 1)("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
                tCust.Rows(i + 1)("MontoCheque") = CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)
                tCust.Rows(i + 1)("Fecha") = ds.Tables("Cobros").Rows(i).Item("Fecha")
                'tCust.Rows(i + 1)("Fecha") = Format(ds.Tables("Cobros").Rows(i).Item("Fecha"), "dd/MM/yyyy")
                tCust.Rows(i + 1)("Tipo") = ds.Tables("Cobros").Rows(i).Item("Tipo")
                'column.Format = "dd/MM/yyyy"

                tCust.Rows(i + 1)("Comp") = ds.Tables("Cobros").Rows(i).Item("Comp_No")
                tCust.Rows(i + 1)("Empresa") = ds.Tables("Cobros").Rows(i).Item("Empresa")
                tCust.Rows(i + 1)("Periodo") = ds.Tables("Cobros").Rows(i).Item("Per_ID")
                tCust.Rows(i + 1)("Mes") = ds.Tables("Cobros").Rows(i).Item("Mes")

                If Me.rbAsignadas.Checked = True Then
                    tCust.Rows(i + 1)("Agregar") = True
                Else
                    tCust.Rows(i + 1)("Agregar") = False
                End If


                Total = CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round) + Total

                'For j = 0 To ds.Tables("Depositos").Rows.Count - 1
                '    tCust.Rows(i)(ds.Tables("Depositos").Rows(j).Item("Deposito_ID") & "D") = False
                'Next

                'j = j + 1
            End If

        Next

        lblTotal.Text = Total.ToString(Round)

        myDataSet.Tables("Item").DefaultView.AllowDelete = False

    End Sub



    Private Sub dgDepositos_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgDepositos.MouseUp
        If ds.Tables("Cobros").Rows.Count = 0 Then
        Else
            If ds.Tables("Cobros").Rows(0).Item("Estado") = 1 Then
                Exit Sub
            Else
            End If
        End If

        Dim hti As DataGrid.HitTestInfo = Me.dgDepositos.HitTest(e.X, e.Y)
        Try
            If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
                Me.dgDepositos(hti.Row, hti.Column) = Not CBool(Me.dgDepositos(hti.Row, hti.Column))
            End If

        Catch ex As Exception
        End Try

        If hti.Column = 7 Then
            If dgDepositos.CurrentRowIndex = 0 And tCust.Rows(0)("Agregar") = True Then
                For i = 1 To tCust.Rows.Count - 1
                    tCust.Rows(i)("Agregar") = True
                Next
            ElseIf dgDepositos.CurrentRowIndex = 0 And tCust.Rows(0)("Agregar") = False Then
                For i = 1 To tCust.Rows.Count - 1
                    tCust.Rows(i)("Agregar") = False
                Next
            End If
        End If
    End Sub 'dataGrid2_MouseUp

    Private Sub rbAsignadas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbAsignadas.Click
        cbFecha.Enabled = False
        ds = Depositos.DepositosDetalles(Deposito)

        MakeDataSet()
        dgDepositos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
    End Sub

    Private Sub rbNoAsignadas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbNoAsignadas.Click
        cbFecha.Enabled = True
        ds = Clientes.Depositos(2, 0, Fecha, 0, 0)

        MakeDataSet()
        dgDepositos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        If cbFecha.Checked = True Then
            Fecha = dtpFecha.Value.Date
        Else
            Fecha = ""
        End If

        ds = Clientes.Depositos(2, 0, Fecha, 0, 0)

        MakeDataSet()
        dgDepositos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim Cantidad As Integer = 0  

        Try            
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            For i = 1 To tCust.Rows.Count - 1
                If rbAsignadas.Checked = True Then
                    If tCust.Rows(i)("Agregar") = True Then
                    Else
                        If tCust.Rows(i)("Comp") <> "0" Then 'Otros Ingresos
                            Depositos.OtrosIngresosDelete(tCust.Rows(i)("Comp"), tCust.Rows(i)("Periodo"), tCust.Rows(i)("Mes"))
                        Else
                            'MsgBox(ds.Tables("Cobros").Rows(i - 1).Item("DepositoDet_Numero"))
                            Depositos.DepositosDetallesDelete(Deposito, tCust.Rows(i)("Numero"), ds.Tables("Cobros").Rows(i - 1).Item("DepositoDet_Numero"))
                            Clientes.CobrosUpdateMontoDepositadoRestar(tCust.Rows(i)("Numero"), tCust.Rows(i)("MontoCheque"))
                            Clientes.CobrosUpdateEstado(tCust.Rows(i)("Numero"), 0)
                        End If
                    End If
                ElseIf rbNoAsignadas.Checked = True Then
                    If tCust.Rows(i)("Agregar") = True Then
                        If tCust.Rows(i)("Comp") <> "0" Then 'Otros Ingresos
                            ComprobantesDB.PagosFactura(tCust.Rows(i)("Comp"), tCust.Rows(i)("Periodo"), tCust.Rows(i)("Mes"), tCust.Rows(i)("MontoCheque"), tCust.Rows(i)("Comp"), tCust.Rows(i)("Periodo"), tCust.Rows(i)("Mes"), Deposito, 0, 0)
                        Else
                            Depositos.AddItemDetalles(Deposito, tCust.Rows(i)("Numero"), tCust.Rows(i)("MontoCheque"))
                            Clientes.CobrosUpdateEstado(tCust.Rows(i)("Numero"), 1)
                        End If
                    End If
                    'ElseIf rbTodas.Checked = True Then
                    '    If Depositos.DepositosDetallesBuscar(Deposito, tCust.Rows(i)("Numero")).Tables("cobros").Rows.Count <> 0 Then
                    '        If tCust.Rows(i)("Agregar") = True Then
                    '        Else
                    '            Depositos.DepositosDetallesDelete(Deposito, tCust.Rows(i)("Numero"))
                    '            Clientes.CobrosUpdateEstado(tCust.Rows(i)("Numero"), 0)
                    '        End If
                    '    Else
                    '        If tCust.Rows(i)("Agregar") = True Then
                    '            Depositos.AddItemDetalles(Deposito, tCust.Rows(i)("Numero"))
                    '            Clientes.CobrosUpdateEstado(tCust.Rows(i)("Numero"), 1)
                    '        End If
                    '    End If
                End If
            Next

            'If Cantidad = 0 Then
            '    MsgBox("Debe seleccionar al menos un registro", MsgBoxStyle.Information)
            '    Exit Sub
            'End If

            VB.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox(ex.Message & "Aceptar")
            Exit Sub
        End Try

        rbAsignadas.Checked = True

        ds = Depositos.DepositosDetalles(Deposito)

        MakeDataSet()
        dgDepositos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
    End Sub

    Private Sub cbFecha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFecha.Click
        If cbFecha.Checked = True Then
            dtpFecha.Enabled = True
            Fecha = dtpFecha.Value.Date
        Else
            dtpFecha.Enabled = False
            Fecha = ""
        End If

        ds = Clientes.Depositos(2, 0, Fecha, 0, 0)

        MakeDataSet()
        dgDepositos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      

        If ds.Tables("Cobros").Rows.Count = 0 Then
            MsgBox("La hoja de Deposito no tiene registros", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim DetalleDeposito As New VB.SysContab.DepositosDetails
        DetalleDeposito = VB.SysContab.DepositosDB.DepositosgetDetalles(Deposito)

        If DetalleDeposito Is Nothing Then
            MsgBox("No se pudo obtener detalle del encabezado de deposito", MsgBoxStyle.Critical, "STS-Contab")
            Exit Sub
        End If

        If DetalleDeposito.Estado = True Then
            MsgBox("La hoja de Depositos ya fue contabilizada", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'Antes se confiaba en el contenido del dataset, es mejor volver a consultar el estado, ya que
        'alguien mas puede estar actualizando el mismo registro. RMPR18062007

        'If ds.Tables("Cobros").Rows(0).Item("Estado") = 1 Then
        '    MsgBox("La hoja de Depositos ya fue contabilizada", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If

        Dim plan As String
        'Dim Plantilla As New VB.SysContab.PlantillaDB()
        plan = PlantillasDB.GetTipoPlantilla(1, 5).ToString

        If plan = "" Or plan Is DBNull.Value Then
            MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim dsPlantillas As DataSet = PlantillasDB.GetPlantillasDetails(5, 1).Detalles
        'If dsPlantillas.Tables("PlantillasDetalles").Rows.Count = 0 Then
        '    MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        Dim CuentaCaja As String = dsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")

        Dim CatBanco As New VB.SysContab.Catalogo_BancosDB
        Dim DepositoDB As New VB.SysContab.DepositosDB

        Dim CuentaBanco As String = CatBanco.GetCuentaContable(DepositoDB.GetBancoDeposito(Deposito), lblCuentaBanco.Text)
        Dim TipoCOmpr As String = PlantillasDB.GetPlantillasDetails(5, 1).TipoCompr  ' Tipo 54


        ''-------------------------------------------------------------
        DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()
        ''-------------------------------------------------------------

        With My.Forms.frmDepositosContabilizar
            .Monto = lblTotal.Text
            .CuentaD = CuentaBanco
            .CuentaC = CuentaCaja
            .txtComentarios.Text = "Deposito del dia " & lblFecha.Text & " No. " & lblDepositoNo.Text & IIf(Documento.Length = 0, "", " Documento: " & Documento)
            .Fecha.DateTime = DetalleDeposito.Fecha
            .TipoCOmpr = TipoCOmpr
            .HojaDeposito = lblDepositoNo.Text
            .Documento = Documento
            .ShowDialog()
            If .Ok = "SI" Then
                Try
                    Depositos.UpdateEstado(lblDepositoNo.Text, 1)
                    VB.SysContab.Rutinas.okTransaccion()
                    '
                    ds = Depositos.DepositosDetalles(Deposito)
                    If ds.Tables("Cobros").Rows(0).Item("Estado") = 1 Then
                        dgDepositos.ReadOnly = True
                        Me.cmdAceptar.Enabled = False
                        Me.cbFecha.Enabled = False
                        Me.rbAsignadas.Enabled = False
                        Me.rbNoAsignadas.Enabled = False
                    End If
                Catch ex As Exception
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                    Exit Sub
                End Try                
            Else
                VB.SysContab.Rutinas.ErrorTransaccion()
            End If

            .Dispose()
        End With
        'Try
        '    ' REVISAR EL TIPO DE MONEDA y TASACAMBIO
        'ComprobantesDB.GeneraComprobanteDeposito(CuentaCaja, 0, lblTotal.Text, _
        '                                         "Deposito del dia " & lblFecha.Text & " No. " & lblDepositoNo.Text, _
        '                                          0, CuentaBanco, lblTotal.Text, 0, _
        '                                         "Deposito del dia " & lblFecha.Text & " No. " & lblDepositoNo.Text, _
        '                                          TipoCOmpr, 1, 1, _
        '                                        "Deposito del dia " & lblFecha.Text & " No. " & lblDepositoNo.Text, _
        '                                         TipoCOmpr, DetalleDeposito.Fecha, lblDepositoNo.Text)  'r.Fecha

        '    Depositos.UpdateEstado(lblDepositoNo.Text, 1)
        '    VB.SysContab.Rutinas.okTransaccion()


        '    ds = Depositos.DepositosDetalles(Deposito)

        '    If ds.Tables("Cobros").Rows(0).Item("Estado") = 1 Then
        '        dgDepositos.ReadOnly = True
        '        Me.cmdAceptar.Enabled = False
        '        Me.cbFecha.Enabled = False
        '        Me.rbAsignadas.Enabled = False
        '        Me.rbNoAsignadas.Enabled = False
        '    End If
        'Catch ex As Exception
        '    VB.SysContab.Rutinas.ErrorTransaccion()
        '    MsgBox(ex.Message, MsgBoxStyle.Critical)
        '    Exit Sub
        'End Try
    End Sub

End Class
