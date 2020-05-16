Public Class frmBuscarItemCC
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmBuscarItemCC = Nothing

    Public Shared Function Instance() As frmBuscarItemCC
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmBuscarItemCC()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents dgArticulos As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdTodos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdZ As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdY As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdX As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdW As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdV As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdU As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdS As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdQ As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdH As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdG As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdO As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdM As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdJ As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdI As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbDescripcion As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbLineas As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbSubGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents etInicio As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgArticulos = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbDescripcion = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdTodos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdZ = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdY = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdX = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdW = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdV = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdU = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdT = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdS = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdR = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdQ = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdH = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdG = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdF = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdE = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdD = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdC = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdB = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdA = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdP = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdO = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdN = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdM = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdL = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdK = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdJ = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdI = New DevExpress.XtraEditors.SimpleButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbLineas = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbGrupos = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbSubGrupos = New System.Windows.Forms.ComboBox()
        Me.etInicio = New System.Windows.Forms.Label()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgArticulos
        '
        Me.dgArticulos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgArticulos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgArticulos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgArticulos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgArticulos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgArticulos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgArticulos.DataMember = ""
        Me.dgArticulos.FlatMode = True
        Me.dgArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgArticulos.ForeColor = System.Drawing.Color.Black
        Me.dgArticulos.GridLineColor = System.Drawing.Color.Silver
        Me.dgArticulos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgArticulos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgArticulos.HeaderForeColor = System.Drawing.Color.White
        Me.dgArticulos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgArticulos.Location = New System.Drawing.Point(8, 16)
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgArticulos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgArticulos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgArticulos.SelectionForeColor = System.Drawing.Color.White
        Me.dgArticulos.Size = New System.Drawing.Size(984, 352)
        Me.dgArticulos.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdSalir, Me.cmdAgregar, Me.dgArticulos})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 408)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(120, 376)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Regresar"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(16, 376)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAgregar.TabIndex = 1
        Me.cmdAgregar.Text = "&Agregar"
        '
        'cbDescripcion
        '
        Me.cbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDescripcion.Location = New System.Drawing.Point(88, 40)
        Me.cbDescripcion.Name = "cbDescripcion"
        Me.cbDescripcion.Size = New System.Drawing.Size(256, 21)
        Me.cbDescripcion.TabIndex = 112
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdTodos, Me.cmdZ, Me.cmdY, Me.cmdX, Me.cmdW, Me.cmdV, Me.cmdU, Me.cmdT, Me.cmdS, Me.cmdR, Me.cmdQ, Me.cmdH, Me.cmdG, Me.cmdF, Me.cmdE, Me.cmdD, Me.cmdC, Me.cmdB, Me.cmdA, Me.cmdP, Me.cmdO, Me.cmdN, Me.cmdM, Me.cmdL, Me.cmdK, Me.cmdJ, Me.cmdI, Me.TextBox1, Me.Label1, Me.Label2, Me.Label3})
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(696, 40)
        Me.GroupBox3.TabIndex = 133
        Me.GroupBox3.TabStop = False
        '
        'cmdTodos
        '
        Me.cmdTodos.Location = New System.Drawing.Point(632, 12)
        Me.cmdTodos.Name = "cmdTodos"
        Me.cmdTodos.Size = New System.Drawing.Size(56, 24)
        Me.cmdTodos.TabIndex = 166
        Me.cmdTodos.Text = "Todos"
        '
        'cmdZ
        '
        Me.cmdZ.Location = New System.Drawing.Point(608, 12)
        Me.cmdZ.Name = "cmdZ"
        Me.cmdZ.Size = New System.Drawing.Size(24, 24)
        Me.cmdZ.TabIndex = 165
        Me.cmdZ.Text = "Z"
        '
        'cmdY
        '
        Me.cmdY.Location = New System.Drawing.Point(584, 12)
        Me.cmdY.Name = "cmdY"
        Me.cmdY.Size = New System.Drawing.Size(24, 24)
        Me.cmdY.TabIndex = 164
        Me.cmdY.Text = "Y"
        '
        'cmdX
        '
        Me.cmdX.Location = New System.Drawing.Point(560, 12)
        Me.cmdX.Name = "cmdX"
        Me.cmdX.Size = New System.Drawing.Size(24, 24)
        Me.cmdX.TabIndex = 163
        Me.cmdX.Text = "X"
        '
        'cmdW
        '
        Me.cmdW.Location = New System.Drawing.Point(536, 12)
        Me.cmdW.Name = "cmdW"
        Me.cmdW.Size = New System.Drawing.Size(24, 24)
        Me.cmdW.TabIndex = 162
        Me.cmdW.Text = "W"
        '
        'cmdV
        '
        Me.cmdV.Location = New System.Drawing.Point(512, 12)
        Me.cmdV.Name = "cmdV"
        Me.cmdV.Size = New System.Drawing.Size(24, 24)
        Me.cmdV.TabIndex = 161
        Me.cmdV.Text = "V"
        '
        'cmdU
        '
        Me.cmdU.Location = New System.Drawing.Point(488, 12)
        Me.cmdU.Name = "cmdU"
        Me.cmdU.Size = New System.Drawing.Size(24, 24)
        Me.cmdU.TabIndex = 160
        Me.cmdU.Text = "U"
        '
        'cmdT
        '
        Me.cmdT.Location = New System.Drawing.Point(464, 12)
        Me.cmdT.Name = "cmdT"
        Me.cmdT.Size = New System.Drawing.Size(24, 24)
        Me.cmdT.TabIndex = 159
        Me.cmdT.Text = "T"
        '
        'cmdS
        '
        Me.cmdS.Location = New System.Drawing.Point(440, 12)
        Me.cmdS.Name = "cmdS"
        Me.cmdS.Size = New System.Drawing.Size(24, 24)
        Me.cmdS.TabIndex = 158
        Me.cmdS.Text = "S"
        '
        'cmdR
        '
        Me.cmdR.Location = New System.Drawing.Point(416, 12)
        Me.cmdR.Name = "cmdR"
        Me.cmdR.Size = New System.Drawing.Size(24, 24)
        Me.cmdR.TabIndex = 157
        Me.cmdR.Text = "R"
        '
        'cmdQ
        '
        Me.cmdQ.Location = New System.Drawing.Point(392, 12)
        Me.cmdQ.Name = "cmdQ"
        Me.cmdQ.Size = New System.Drawing.Size(24, 24)
        Me.cmdQ.TabIndex = 156
        Me.cmdQ.Text = "Q"
        '
        'cmdH
        '
        Me.cmdH.Location = New System.Drawing.Point(176, 12)
        Me.cmdH.Name = "cmdH"
        Me.cmdH.Size = New System.Drawing.Size(24, 24)
        Me.cmdH.TabIndex = 147
        Me.cmdH.Text = "H"
        '
        'cmdG
        '
        Me.cmdG.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdG.ForeColor = System.Drawing.Color.Maroon
        Me.cmdG.Location = New System.Drawing.Point(152, 12)
        Me.cmdG.Name = "cmdG"
        Me.cmdG.Size = New System.Drawing.Size(24, 24)
        Me.cmdG.TabIndex = 146
        Me.cmdG.Text = "G"
        '
        'cmdF
        '
        Me.cmdF.Location = New System.Drawing.Point(128, 12)
        Me.cmdF.Name = "cmdF"
        Me.cmdF.Size = New System.Drawing.Size(24, 24)
        Me.cmdF.TabIndex = 145
        Me.cmdF.Text = "F"
        '
        'cmdE
        '
        Me.cmdE.Location = New System.Drawing.Point(104, 12)
        Me.cmdE.Name = "cmdE"
        Me.cmdE.Size = New System.Drawing.Size(24, 24)
        Me.cmdE.TabIndex = 144
        Me.cmdE.Text = "E"
        '
        'cmdD
        '
        Me.cmdD.Location = New System.Drawing.Point(80, 12)
        Me.cmdD.Name = "cmdD"
        Me.cmdD.Size = New System.Drawing.Size(24, 24)
        Me.cmdD.TabIndex = 143
        Me.cmdD.Text = "D"
        '
        'cmdC
        '
        Me.cmdC.Location = New System.Drawing.Point(56, 12)
        Me.cmdC.Name = "cmdC"
        Me.cmdC.Size = New System.Drawing.Size(24, 24)
        Me.cmdC.TabIndex = 142
        Me.cmdC.Text = "C"
        '
        'cmdB
        '
        Me.cmdB.Location = New System.Drawing.Point(32, 12)
        Me.cmdB.Name = "cmdB"
        Me.cmdB.Size = New System.Drawing.Size(24, 24)
        Me.cmdB.TabIndex = 141
        Me.cmdB.Text = "B"
        '
        'cmdA
        '
        Me.cmdA.Location = New System.Drawing.Point(8, 12)
        Me.cmdA.Name = "cmdA"
        Me.cmdA.Size = New System.Drawing.Size(24, 24)
        Me.cmdA.TabIndex = 140
        Me.cmdA.Text = "A"
        '
        'cmdP
        '
        Me.cmdP.Location = New System.Drawing.Point(368, 12)
        Me.cmdP.Name = "cmdP"
        Me.cmdP.Size = New System.Drawing.Size(24, 24)
        Me.cmdP.TabIndex = 155
        Me.cmdP.Text = "P"
        '
        'cmdO
        '
        Me.cmdO.Location = New System.Drawing.Point(344, 12)
        Me.cmdO.Name = "cmdO"
        Me.cmdO.Size = New System.Drawing.Size(24, 24)
        Me.cmdO.TabIndex = 154
        Me.cmdO.Text = "O"
        '
        'cmdN
        '
        Me.cmdN.Location = New System.Drawing.Point(320, 12)
        Me.cmdN.Name = "cmdN"
        Me.cmdN.Size = New System.Drawing.Size(24, 24)
        Me.cmdN.TabIndex = 153
        Me.cmdN.Text = "N"
        '
        'cmdM
        '
        Me.cmdM.Location = New System.Drawing.Point(296, 12)
        Me.cmdM.Name = "cmdM"
        Me.cmdM.Size = New System.Drawing.Size(24, 24)
        Me.cmdM.TabIndex = 152
        Me.cmdM.Text = "M"
        '
        'cmdL
        '
        Me.cmdL.Location = New System.Drawing.Point(272, 12)
        Me.cmdL.Name = "cmdL"
        Me.cmdL.Size = New System.Drawing.Size(24, 24)
        Me.cmdL.TabIndex = 151
        Me.cmdL.Text = "L"
        '
        'cmdK
        '
        Me.cmdK.Location = New System.Drawing.Point(248, 12)
        Me.cmdK.Name = "cmdK"
        Me.cmdK.Size = New System.Drawing.Size(24, 24)
        Me.cmdK.TabIndex = 150
        Me.cmdK.Text = "K"
        '
        'cmdJ
        '
        Me.cmdJ.Location = New System.Drawing.Point(224, 12)
        Me.cmdJ.Name = "cmdJ"
        Me.cmdJ.Size = New System.Drawing.Size(24, 24)
        Me.cmdJ.TabIndex = 149
        Me.cmdJ.Text = "J"
        '
        'cmdI
        '
        Me.cmdI.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdI.ForeColor = System.Drawing.Color.Maroon
        Me.cmdI.Location = New System.Drawing.Point(200, 12)
        Me.cmdI.Name = "cmdI"
        Me.cmdI.Size = New System.Drawing.Size(24, 24)
        Me.cmdI.TabIndex = 148
        Me.cmdI.Text = "I"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(832, 16)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(136, 20)
        Me.TextBox1.TabIndex = 123
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(752, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Teléfono:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(632, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "0.00"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(536, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Total:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(88, 8)
        Me.txtCodigo.MaxLength = 50
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(136, 20)
        Me.txtCodigo.TabIndex = 135
        Me.txtCodigo.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 24)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Código"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label5.Location = New System.Drawing.Point(712, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 24)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "Línea"
        '
        'cbLineas
        '
        Me.cbLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLineas.Location = New System.Drawing.Point(776, 8)
        Me.cbLineas.Name = "cbLineas"
        Me.cbLineas.Size = New System.Drawing.Size(232, 21)
        Me.cbLineas.TabIndex = 137
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label6.Location = New System.Drawing.Point(352, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "Proveedor"
        '
        'cbProveedores
        '
        Me.cbProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedores.Location = New System.Drawing.Point(424, 8)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(264, 21)
        Me.cbProveedores.TabIndex = 139
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label8.Location = New System.Drawing.Point(712, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 24)
        Me.Label8.TabIndex = 142
        Me.Label8.Text = "Grupo"
        '
        'cbGrupos
        '
        Me.cbGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupos.Location = New System.Drawing.Point(776, 40)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.Size = New System.Drawing.Size(232, 21)
        Me.cbGrupos.TabIndex = 141
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label10.Location = New System.Drawing.Point(712, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 24)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "SubGrupo"
        '
        'cbSubGrupos
        '
        Me.cbSubGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubGrupos.Location = New System.Drawing.Point(776, 72)
        Me.cbSubGrupos.Name = "cbSubGrupos"
        Me.cbSubGrupos.Size = New System.Drawing.Size(232, 21)
        Me.cbSubGrupos.TabIndex = 164
        '
        'etInicio
        '
        Me.etInicio.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etInicio.Location = New System.Drawing.Point(240, 8)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(72, 24)
        Me.etInicio.TabIndex = 166
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'frmBuscarItemCC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.etInicio, Me.Label10, Me.cbSubGrupos, Me.Label8, Me.cbGrupos, Me.Label6, Me.cbProveedores, Me.Label5, Me.cbLineas, Me.Label4, Me.txtCodigo, Me.Label7, Me.GroupBox3, Me.cbDescripcion, Me.GroupBox1})
        Me.Name = "frmBuscarItemCC"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Articulos As New VB.SysContab.ArticulosDB()
    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Dim Grupos As New VB.SysContab.Grupos_InventarioDB()

    Dim r As New VB.SysContab.Rutinas()
    Dim n As Integer

    Private WithEvents myDataSet As DataSet
    Dim tCust As DataTable
    Dim ds As DataSet

    Dim Cantidad As New DataGridTextBoxColumn()
    Dim ValorActualCantidad As Double

    Dim DetallesProducto As New VB.SysContab.ArticulosDetails()

    Public GruposCC As New VB.SysContab.GruposCCDB()
    'Public Tabla As New DataTable()

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

        'Dim i As Integer
        'For i = 0 To n - 1
        '    MsgBox(tItem.Rows(i)("Codigo"))
        'Next

    End Sub

    Private Sub frmBuscarItemCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        r.FormularioColor(Me)

        cbLineas.DataSource = GruposCC.Lineas().Tables("GruposCC")
        cbLineas.ValueMember = "Código"
        cbLineas.DisplayMember = "Nombre"
        cbLineas.SelectedValue = 0

        cbGrupos.DataSource = GruposCC.Grupos(Me.cbLineas.SelectedValue).Tables("GruposCC")
        cbGrupos.ValueMember = "Código"
        cbGrupos.DisplayMember = "Nombre"
        cbGrupos.SelectedValue = 0

        cbSubGrupos.DataSource = GruposCC.SubGrupos(Me.cbGrupos.SelectedValue).Tables("GruposCC")
        cbSubGrupos.ValueMember = "Código"
        cbSubGrupos.DisplayMember = "Nombre"
        cbSubGrupos.SelectedValue = 0

        cbProveedores.DataSource = Proveedores.ListAll().Tables("Proveedores")
        cbProveedores.ValueMember = "Codigo"
        cbProveedores.DisplayMember = "Nombre"

        cbProveedores.SelectedValue = 0

        r.ComboAutoComplete(Me.cbLineas)
        r.ComboAutoComplete(Me.cbGrupos)
        r.ComboAutoComplete(Me.cbSubGrupos)

        r.ComboAutoComplete(Me.cbProveedores)

        ds = GruposCC.ArticulosCCList("", Me.cbProveedores.SelectedValue.ToString, Me.cbLineas.SelectedValue.ToString, Me.cbGrupos.SelectedValue.ToString, Me.cbSubGrupos.SelectedValue.ToString)

        Me.dgArticulos.DataSource = ds.Tables("GruposCC").DefaultView
        'Tabla = ds.Tables("GruposCC")

        'r.FormatGenerico(Me.dgArticulos, Tabla)

        'Me.dgArticulos.CaptionText = "..."

        MakeDataSet()
        dgArticulos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()

        MakeDataSetTemporal()
        'dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
        AddCustomDataTableStyleTemporal()

        Me.Text = "..."

        Me.Refresh()

        n = 0

    End Sub

    Private Sub dgArticulos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgArticulos.CurrentCellChanged
        Try
            Registro = dgArticulos.Item(dgArticulos.CurrentRowIndex, 2)
            ValorActualCantidad = tCust.Rows(dgArticulos.CurrentRowIndex)("Cantidad")
        Catch
            Exit Sub
        End Try

    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        'tItem.Clear()
        AgregarItemTemporal()

    End Sub

    Private Sub MakeDataSet()

        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")


        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust = New DataTable("Item")

        ' Create two columns, and add them to the first table.
        Dim cCustID As DataColumn
        cCustID = New DataColumn("Codigo")

        Dim cCantidad As DataColumn
        cCantidad = New DataColumn("Cantidad")

        Dim cCustName As DataColumn
        cCustName = New DataColumn("Descripcion")

        Dim cCustProveedor As DataColumn
        cCustProveedor = New DataColumn("Proveedor")

        'Dim cCustPrecio As DataColumn
        'cCustPrecio = New DataColumn("Precio")

        Dim cCustExistencias As DataColumn
        cCustExistencias = New DataColumn("Existencias")

        Dim cCustTipo As DataColumn
        cCustTipo = New DataColumn("Tipo")

        Dim cCustCosto As DataColumn
        cCustCosto = New DataColumn("Costo")

        Dim cAgregar As DataColumn
        cAgregar = New DataColumn("Agregar", GetType(System.Boolean))

        Dim cDetalle As DataColumn
        cDetalle = New DataColumn("Detalle")

        'Dim cCurrent2 As DataColumn
        'cCurrent2 = New DataColumn("Current2", GetType(System.Boolean))
        tCust.Columns.Add(cAgregar)
        tCust.Columns.Add(cCustID)
        tCust.Columns.Add(cCantidad)
        tCust.Columns.Add(cCustName)
        tCust.Columns.Add(cCustProveedor)
        'tCust.Columns.Add(cCustPrecio)
        tCust.Columns.Add(cCustExistencias)
        tCust.Columns.Add(cCustTipo)
        tCust.Columns.Add(cCustCosto)
        tCust.Columns.Add(cDetalle)

        tCust.DefaultView.AllowDelete = False
        tCust.DefaultView.AllowNew = False
        tCust.DefaultView.AllowEdit = False

        'tCust.Columns.Add(cCurrent2)
        ' Add the tables to the DataSet.
        myDataSet.Tables.Add(tCust)

        ' Populates the tables. For each customer and order, 
        'creates two DataRow variables. 
        Dim newRow1 As DataRow
        ' Create three customers in the Customers Table.
        Dim i As Integer
        i = 0

        'Do While (i < ds.Tables("Articulos").Rows.Count)
        '    newRow1 = tCust.NewRow
        '    newRow1("Codigo") = ds.Tables("Articulos").Rows(i).Item("Codigo")
        '    ' Add the row to the Customers table.
        '    tCust.Rows.Add(newRow1)
        '    i = (i + 1)

        'Loop
        ' Give each customer a distinct name.

        For i = 0 To ds.Tables("GruposCC").Rows.Count - 1
            newRow1 = tCust.NewRow
            newRow1("Codigo") = ds.Tables("GruposCC").Rows(i).Item("Código")
            tCust.Rows.Add(newRow1)

            tCust.Rows(i)("Cantidad") = "1"

            tCust.Rows(i)("Detalle") = "Mostrar Detalles"
            tCust.Rows(i)("Descripcion") = ds.Tables("GruposCC").Rows(i).Item("Nombre")
            tCust.Rows(i)("Proveedor") = ds.Tables("GruposCC").Rows(i).Item("Proveedor")
            'tCust.Rows(i)("Precio") = CDbl(ds.Tables("Articulos").Rows(i).Item("Precio")).ToString(Round)
            tCust.Rows(i)("Costo") = CDbl(ds.Tables("GruposCC").Rows(i).Item("Costo")).ToString(Round)
            tCust.Rows(i)("Existencias") = 1 'ds.Tables("Articulos").Rows(i).Item("Existencias")
            tCust.Rows(i)("Tipo") = "I" 'ds.Tables("Articulos").Rows(i).Item("Tipo")
            tCust.Rows(i)("Agregar") = False

        Next

        myDataSet.Tables("Item").DefaultView.AllowDelete = False
        'myDataSet.Tables("EastCoastSales").DefaultView.AllowNew = False
        'myDataSet.Tables("EastCoastSales").DefaultView.AllowEdit = False

        'tCust.DefaultView.AllowDelete = False
        'tCust.DefaultView.AllowEdit = False
        'tCust.DefaultView.AllowNew = False


        'tCust.Rows(0)("custName") = ds.Tables("Activo_Fijos").Rows(0).Item("CODIGO ")
        'tCust.Rows(1)("custName") = ds.Tables("Activo_Fijos").Rows(0).Item("DESCRIPCION")
        'tCust.Rows(2)("custName") = "Omega"
        '' Give the Current column a value.
        'tCust.Rows(0)("Current") = True
        'tCust.Rows(1)("Current") = True
        'tCust.Rows(2)("Current") = False
        'tCust.Rows(0)("Current2") = False
        'tCust.Rows(1)("Current2") = True
        'tCust.Rows(2)("Current2") = False

    End Sub

    'Private Sub TextBoxDoubleClickHandler(ByVal sender As Object, ByVal e As EventArgs)
    Private Sub TextBoxMouseEnterHandler(ByVal sender As Object, ByVal e As EventArgs)
        Exit Sub
        Try
            Dim f As frmDetalleArticulo = f.Instance

            Registro = dgArticulos.Item(dgArticulos.CurrentRowIndex, 3)

            f.MdiParent = Me.MdiParent
            f.Show()
            'Me.seleccionar()
        Catch ex As Exception
            'MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub TextBoxCantidadLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsNumeric(Cantidad.TextBox.Text) Then
            Cantidad.TextBox.Text = ValorActualCantidad 'ValorActualCantidad '.ToString(Round)
        Else
            If CDbl(Cantidad.TextBox.Text) <= 0 Then
                MsgBox("La cantidad debe ser mayor que Cero (0)", MsgBoxStyle.Information)
                Cantidad.TextBox.Text = ValorActualCantidad 'ValorActualCantidad '.ToString(Round)
                'Cantidad.TextBox.Focus()

                Exit Sub
            End If

        End If

        'If dgFacturacionCliente.CurrentRowIndex >= tCust.Rows.Count Then
        '    Exit Sub
        'End If

        'If tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo").ToString = "" Or tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("ArticuloCodigo") Is DBNull.Value Then
        '    Exit Sub
        'End If

        'If TipoItem = "S" Then
        '    Exit Sub
        'ElseIf TipoItem = "A" Then
        '    If tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Tipo").ToString = "S" Then
        '        Exit Sub
        '    End If
        'End If

        DetallesProducto = VB.SysContab.ArticulosDB.GetDetails(tCust.Rows(Me.dgArticulos.CurrentRowIndex)("Codigo"), "P")
        If DetallesProducto.Existencia Is Nothing Or DetallesProducto.Existencia Is DBNull.Value Then
            '
        ElseIf DetallesProducto.Existencia = 0 Then
            MsgBox("No hay existencias", MsgBoxStyle.Critical)
            Cantidad.TextBox.Text = ValorActualCantidad
            'Cantidad.TextBox.Focus()
            Exit Sub
        ElseIf CDbl(Cantidad.TextBox.Text) > CDbl(DetallesProducto.Existencia) Then
            MsgBox("La cantidad es mayor que la existencia actual", MsgBoxStyle.Critical)
            Cantidad.TextBox.Text = ValorActualCantidad
            'Cantidad.TextBox.Focus()
            Exit Sub
        End If

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

        'STEP 4: Add the checkbox
        Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        boolCol.MappingName = "Agregar"
        boolCol.HeaderText = "Agregar"
        boolCol.Alignment = HorizontalAlignment.Center
        'uncomment this line to get a two-state checkbox
        CType(boolCol, DataGridBoolColumn).AllowNull = False

        boolCol.Width = 80
        boolCol.ReadOnly = False

        boolCol.NullText = ""

        'hook the new event to our handler in the grid
        AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
        ts1.GridColumnStyles.Add(boolCol)
        colCount = (colCount + 1)

        'Dim Cantidad As New DataGridTextBoxColumn()
        Cantidad.MappingName = "Cantidad"
        Cantidad.HeaderText = "Cantidad"
        Cantidad.ReadOnly = False
        Cantidad.Alignment = HorizontalAlignment.Right
        'Cantidad.TextBox.BorderStyle = BorderStyle.FixedSingle
        Cantidad.Width = 80
        Cantidad.NullText = ""

        AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxCantidadLeaveHandler)
        'AddHandler column.TextBox.DoubleClick, New EventHandler(AddressOf TextBoxDoubleClickHandler)

        'AddHandler Detalle.TextBox.MouseEnter, New EventHandler(AddressOf TextBoxMouseEnterHandler)

        'tableStyle.GridColumnStyles.Add(column)
        ts1.GridColumnStyles.Add(Cantidad)
        colCount = (colCount + 1)

        'Dim tableStyle As New DataGridTableStyle()
        'tableStyle.MappingName = "Inventario"
        'Dim column As New TextBoxColumn
        Dim Detalle As New DataGridTextBoxColumn()
        Detalle.MappingName = "Detalle"
        Detalle.HeaderText = "Mostrar Detalles"
        Detalle.ReadOnly = True
        Detalle.Alignment = HorizontalAlignment.Center
        Detalle.Width = 115
        Detalle.NullText = ""

        'AddHandler ColumnComboBox.Leave, New EventHandler(AddressOf LeaveComboBox)
        'AddHandler column.TextBox.DoubleClick, New EventHandler(AddressOf TextBoxDoubleClickHandler)

        AddHandler Detalle.TextBox.MouseEnter, New EventHandler(AddressOf TextBoxMouseEnterHandler)

        'tableStyle.GridColumnStyles.Add(column)
        ts1.GridColumnStyles.Add(Detalle)
        colCount = (colCount + 1)


        'STEP 3: Create an int column style and add it to the tablestyle
        'this requires setting the format for the column through its property descriptor
        '''''Dim pdc As PropertyDescriptorCollection
        '''''pdc = Me.BindingContext(myDataSet, "EastCoastSales").GetItemProperties
        'now created a formated column using the pdc
        Dim Codigo As DataGridColumnStyle
        Codigo = New DataGridTextBoxColumn()
        Codigo.MappingName = "Codigo"
        'from dataset table
        Codigo.HeaderText = "Código"
        Codigo.Width = 100
        Codigo.ReadOnly = True
        ts1.GridColumnStyles.Add(Codigo)
        colCount = (colCount + 1)

        Codigo.NullText = ""


        'STEP 2: Create a string column and add it to the tablestyle
        Dim TextCol As DataGridColumnStyle
        TextCol = New DataGridTextBoxColumn()
        'TextCol = New DataGridboo
        TextCol.MappingName = "Descripcion"
        'from dataset table
        TextCol.HeaderText = "Descripción"
        TextCol.Width = 350
        'addhandler textcol.
        TextCol.ReadOnly = True
        ts1.GridColumnStyles.Add(TextCol)
        colCount = (colCount + 1)

        TextCol.NullText = ""

        Dim Proveedor As DataGridColumnStyle
        Proveedor = New DataGridTextBoxColumn()
        Proveedor.MappingName = "Proveedor"
        'from dataset table
        Proveedor.HeaderText = "Proveedor"
        Proveedor.Width = 300
        Proveedor.ReadOnly = True
        ts1.GridColumnStyles.Add(Proveedor)
        colCount = (colCount + 1)

        Proveedor.NullText = ""

        'Dim Precio As DataGridColumnStyle
        'Precio = New DataGridTextBoxColumn()
        'Precio.MappingName = "Precio"
        ''from dataset table
        'Precio.HeaderText = "Precio"
        'Precio.Width = 70
        'Precio.ReadOnly = True
        'Precio.Alignment = HorizontalAlignment.Right
        'ts1.GridColumnStyles.Add(Precio)
        'colCount = (colCount + 1)

        'Precio.NullText = ""

        Dim Existencias As DataGridColumnStyle
        Existencias = New DataGridTextBoxColumn()
        Existencias.MappingName = "Existencias"
        'from dataset table
        Existencias.HeaderText = "Existencias"
        Existencias.Width = 75
        Existencias.ReadOnly = True
        Existencias.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(Existencias)
        colCount = (colCount + 1)

        Existencias.NullText = ""

        Dim Tipo As DataGridColumnStyle
        Tipo = New DataGridTextBoxColumn()
        Tipo.MappingName = "Tipo"
        'from dataset table
        Tipo.HeaderText = "Tipo"
        Tipo.Width = 0
        Tipo.ReadOnly = True
        ts1.GridColumnStyles.Add(Tipo)
        colCount = (colCount + 1)

        Tipo.NullText = ""


        Dim Costo As DataGridColumnStyle
        Costo = New DataGridTextBoxColumn()
        Costo.MappingName = "Costo"
        'from dataset table
        Costo.HeaderText = "Costo"
        Costo.Width = 70
        Costo.ReadOnly = True
        Costo.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(Costo)
        colCount = (colCount + 1)

        Costo.NullText = ""


        ''STEP 5: Add a second checkbox

        'boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        'boolCol.MappingName = "Current2"
        'boolCol.HeaderText = "Info Current2"
        'CType(boolCol, DataGridBoolColumn).AllowNull = False
        'boolCol.Width = 70
        ''hook the new event to our handler in the grid
        'AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
        'ts1.GridColumnStyles.Add(boolCol)
        'colCount = (colCount + 1)

        'STEP 6: Add the tablestyle to your datagrids tablestlye collection
        ts1.AllowSorting = False
        ts1.HeaderFont = dgArticulos.HeaderFont
        ts1.PreferredRowHeight = 25

        tCust.DefaultView.AllowDelete = False
        tCust.DefaultView.AllowNew = False
        tCust.DefaultView.AllowEdit = True

        myDataSet.Tables("Item").DefaultView.AllowDelete = False
        myDataSet.Tables("Item").DefaultView.AllowNew = False
        myDataSet.Tables("Item").DefaultView.AllowEdit = True

        dgArticulos.TableStyles.Clear()
        dgArticulos.TableStyles.Add(ts1)

    End Sub

    Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
        Dim s As String
        s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
        Console.WriteLine(s)
    End Sub

    Private Sub MakeDataSetTemporal()

        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")

        ' Create two DataTables.
        'Dim tItem As DataTable
        tItem = New DataTable("Articulos")

        ' Create two columns, and add them to the first table.

        Dim cArticuloCodigo As DataColumn
        cArticuloCodigo = New DataColumn("Codigo")

        Dim cArticulo As DataColumn
        cArticulo = New DataColumn("Descripcion")

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

        Dim cCustCosto As DataColumn
        cCustCosto = New DataColumn("Costo")

        tItem.Columns.Add(cArticuloCodigo)
        tItem.Columns.Add(cArticulo)
        tItem.Columns.Add(cCantidad)
        tItem.Columns.Add(cPrecio)
        tItem.Columns.Add(cDescuento)
        tItem.Columns.Add(cSubTotal)
        tItem.Columns.Add(cCodigoTemporal)
        tItem.Columns.Add(cCustCosto)
        tItem.Columns.Add(cItemTipo)

        'tItem.Columns.Add(cCurrent2)
        ' Add the tables to the DataSet.
        myDataSet.Tables.Add(tItem)

        ' Populates the tables. For each customer and order, 
        'creates two DataRow variables. 
        'Dim newRow1 As DataRow
        ' Create three customers in the Customers Table.

        'i = 0

        'Do While (i < ds.Tables("Recibo_Cheques").Rows.Count)
        '    newRow1 = tItem.NewRow
        '    newRow1("Articulo") = ds.Tables("Articulos").Rows(i).Item("Articulo")
        '    ' Add the row to the Customers table.
        '    tItem.Rows.Add(newRow1)
        '    i = (i + 1)

        'Loop
        '' Give each customer a distinct name.

        'For i = 0 To ds.Tables("Recibo_Cheques").Rows.Count - 1
        '    'tItem.Rows(i)("Cantidad") = ds.Tables("Recibo_Cheques").Rows(i).Item("Banco")
        '    tItem.Rows(i)("Precio") = ds.Tables("Recibo_Cheques").Rows(i).Item("Cuenta")
        '    tItem.Rows(i)("Monto") = Format(ds.Tables("Recibo_Cheques").Rows(i).Item("Monto"), "##,###0.00")
        '    tItem.Rows(i)("Moneda") = ds.Tables("Recibo_Cheques").Rows(i).Item("Moneda")

        'Next

        'Do While (i < 4)
        '    newRow1 = tItem.NewRow
        '    newRow1("Articulo") = ""
        '    ' Add the row to the Customers table.
        '    tItem.Rows.Add(newRow1)
        '    i = (i + 1)

        'Loop

        'Dim x As Integer

        'For x = 0 To 3
        '    'tItem.Rows(rowChanging)("Codigo") = ArticuloCodigo.ColumnComboBox.Items.Item(Articulo.ColumnComboBox.SelectedIndex)
        '    tItem.Rows(x)("CodigoTemporal") = ""
        '    tItem.Rows(x)("Codigo") = ""
        '    tItem.Rows(x)("Articulo") = ""
        '    tItem.Rows(x)("Cantidad") = ""
        '    tItem.Rows(x)("Precio") = ""

        'Next

    End Sub

    Private Sub AddCustomDataTableStyleTemporal()

        'STEP 1: Create a DataTable style object and set properties if required.
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle()
        'specify the table from dataset (required step)
        ts1.MappingName = "Articulos"
        ' Set other properties (optional step)
        ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount As Integer
        colCount = 0


        'Dim Articulo As DataGridComboBoxColumn

        Dim Codigo As DataGridColumnStyle
        Codigo = New DataGridTextBoxColumn()
        Codigo.MappingName = "Codigo"
        'from dataset table
        Codigo.HeaderText = "Codigo"
        Codigo.Width = 100
        Codigo.Alignment = HorizontalAlignment.Right
        Codigo.ReadOnly = False
        ts1.GridColumnStyles.Add(Codigo)
        colCount = (colCount + 1)

        Codigo.NullText = ""


        colCount = (colCount + 1)

        Dim Articulo As DataGridColumnStyle
        Articulo = New DataGridTextBoxColumn()
        Articulo.MappingName = "Descripcion"
        'from dataset table
        Articulo.HeaderText = "Descripcion"
        Articulo.Width = 100
        Articulo.Alignment = HorizontalAlignment.Right
        Articulo.ReadOnly = False
        ts1.GridColumnStyles.Add(Articulo)
        colCount = (colCount + 1)

        Articulo.NullText = ""

        colCount = (colCount + 1)

        Dim Cantidad As DataGridColumnStyle
        Cantidad = New DataGridTextBoxColumn()
        Cantidad.MappingName = "Cantidad"
        'from dataset table
        Cantidad.HeaderText = "Cantidad"
        Cantidad.Width = 100
        Cantidad.Alignment = HorizontalAlignment.Right
        Cantidad.ReadOnly = False
        ts1.GridColumnStyles.Add(Cantidad)
        colCount = (colCount + 1)

        Cantidad.NullText = ""

        Dim Precio As DataGridTextBoxColumn
        Precio = New DataGridTextBoxColumn()
        Precio.MappingName = "Precio"
        Precio.HeaderText = "Precio."
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
        Descuento.HeaderText = "Descuento."
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
        SubTotal.HeaderText = "Sub Total."
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

        Dim Tipo As DataGridColumnStyle
        Tipo = New DataGridTextBoxColumn()
        Tipo.MappingName = "Tipo"
        'from dataset table
        Tipo.HeaderText = "Tipo"
        Tipo.Width = 100
        Tipo.Alignment = HorizontalAlignment.Right
        Tipo.ReadOnly = False
        ts1.GridColumnStyles.Add(Tipo)
        colCount = (colCount + 1)

        Tipo.NullText = ""

        colCount = (colCount + 1)

        Dim Costo As DataGridColumnStyle
        Costo = New DataGridTextBoxColumn()
        Costo.MappingName = "Costo"
        'from dataset table
        Costo.HeaderText = "Costo"
        Costo.Width = 70
        Costo.ReadOnly = True
        Costo.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(Costo)
        colCount = (colCount + 1)

        Costo.NullText = ""


        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        'STEP 6: Add the tablestyle to your datagrids tablestlye collection
        ''ts1.AllowSorting = False
        ''ts1.HeaderFont = dgFacturacionCliente.HeaderFont

        ''dgFacturacionCliente.CaptionVisible = False

        ''dgFacturacionCliente.TableStyles.Clear()
        ''dgFacturacionCliente.TableStyles.Add(ts1)

    End Sub

    Private Sub AgregarItemTemporal()
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim c As Integer
        c = 0

        For k = 0 To tCust.Rows.Count - 1
            If tCust.Rows(k)("Agregar") = True Then
                c = 1
                Exit For
            End If
        Next

        If c = 0 Then
            MsgBox("Seleccione al menos un Producto", MsgBoxStyle.Information)
            Exit Sub
        End If

        For i = 0 To tCust.Rows.Count - 1
            If tCust.Rows(i)("Agregar") = True Then

                For j = 0 To tItem.Rows.Count - 1
                    If tCust.Rows(i)("Codigo") = tItem.Rows(j)("Codigo") Then
                        Exit For
                    End If
                Next

                If j = tItem.Rows.Count Then
                    Dim newRow1 As DataRow
                    newRow1 = tItem.NewRow

                    newRow1("CodigoTemporal") = tCust.Rows(i)("Codigo")
                    ' Add the row to the Customers table.
                    tItem.Rows.Add(newRow1)

                    tItem.Rows(n)("Codigo") = tCust.Rows(i)("Codigo")
                    tItem.Rows(n)("Descripcion") = tCust.Rows(i)("Descripcion")
                    tItem.Rows(n)("Cantidad") = tCust.Rows(i)("Cantidad")
                    'tItem.Rows(n)("Precio") = tCust.Rows(i)("Precio")
                    tItem.Rows(n)("Costo") = tCust.Rows(i)("Costo")

                    tItem.Rows(n)("Tipo") = tCust.Rows(i)("Tipo")

                    n = n + 1

                End If

            End If

        Next

    End Sub

    Private Sub cmdA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdA.Click
        BuscarXLetra(cmdA.Text)
    End Sub

    Private Sub cmdB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdB.Click
        BuscarXLetra(cmdB.Text)
    End Sub

    Private Sub cmdC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdC.Click
        BuscarXLetra(cmdC.Text)
    End Sub

    Private Sub cmdD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdD.Click
        BuscarXLetra(cmdD.Text)
    End Sub

    Private Sub cmdE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdE.Click
        BuscarXLetra(cmdE.Text)
    End Sub

    Private Sub cmdF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdF.Click
        BuscarXLetra(cmdF.Text)
    End Sub

    Private Sub cmdG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdG.Click
        BuscarXLetra(cmdG.Text)
    End Sub

    Private Sub cmdH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdH.Click
        BuscarXLetra(cmdH.Text)
    End Sub

    Private Sub cmdI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdI.Click
        BuscarXLetra(cmdI.Text)
    End Sub

    Private Sub cmdJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdJ.Click
        BuscarXLetra(cmdJ.Text)
    End Sub

    Private Sub cmdK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdK.Click
        BuscarXLetra(cmdK.Text)
    End Sub

    Private Sub cmdL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdL.Click
        BuscarXLetra(cmdL.Text)
    End Sub

    Private Sub cmdM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdM.Click
        BuscarXLetra(cmdM.Text)
    End Sub

    Private Sub cmdN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdN.Click
        BuscarXLetra(cmdN.Text)
    End Sub

    Private Sub cmdO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdO.Click
        BuscarXLetra(cmdO.Text)
    End Sub

    Private Sub cmdP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdP.Click
        BuscarXLetra(cmdP.Text)
    End Sub

    Private Sub cmdQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQ.Click
        BuscarXLetra(cmdQ.Text)
    End Sub

    Private Sub cmdR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdR.Click
        BuscarXLetra(cmdR.Text)
    End Sub

    Private Sub cmdS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdS.Click
        BuscarXLetra(cmdS.Text)
    End Sub

    Private Sub cmdT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdT.Click
        BuscarXLetra(cmdT.Text)
    End Sub

    Private Sub cmdU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdU.Click
        BuscarXLetra(cmdU.Text)
    End Sub

    Private Sub cmdV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdV.Click
        BuscarXLetra(cmdV.Text)
    End Sub

    Private Sub cmdW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdW.Click
        BuscarXLetra(cmdW.Text)
    End Sub

    Private Sub cmdX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdX.Click
        BuscarXLetra(cmdX.Text)
    End Sub

    Private Sub cmdY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdY.Click
        BuscarXLetra(cmdY.Text)
    End Sub

    Private Sub cmdZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdZ.Click
        BuscarXLetra(cmdZ.Text)
    End Sub

    Private Sub cmdTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTodos.Click
        txtCodigo.Text = ""
        cbDescripcion.SelectedValue = 0
        cbLineas.SelectedValue = 0
        cbProveedores.SelectedValue = 0
        cbGrupos.SelectedValue = 0
        cbSubGrupos.SelectedValue = 0

        BuscarXLetra("Todos")
    End Sub

    'Buscar por letra
    Private Sub BuscarXLetra(ByVal Letra As String)
        If Letra = "Todos" Then
            ds = GruposCC.ArticulosCCList("", Me.cbProveedores.SelectedValue.ToString, Me.cbLineas.SelectedValue.ToString, Me.cbGrupos.SelectedValue.ToString, Me.cbSubGrupos.SelectedValue.ToString)
            Me.dgArticulos.DataSource = ds.Tables("GruposCC").DefaultView
        Else
            ds = GruposCC.ArticulosCCList(Letra, Me.cbProveedores.SelectedValue.ToString, Me.cbLineas.SelectedValue.ToString, Me.cbGrupos.SelectedValue.ToString, Me.cbSubGrupos.SelectedValue.ToString)
            Me.dgArticulos.DataSource = ds.Tables("GruposCC").DefaultView
        End If

        MakeDataSet()
        dgArticulos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
    End Sub

    Private Sub dgArticulos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgArticulos.KeyDown
        'If e.KeyData = Keys.F3 Then
        '    Dim f As frmDetalleArticulo = f.Instance

        '    Registro = dgArticulos.Item(dgArticulos.CurrentRowIndex, 1)

        '    f.MdiParent = Me.MdiParent
        '    f.Show()
        'End If
    End Sub

    Private Sub frmBuscarItemCC_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

    End Sub

    Private Sub dgArticulos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgArticulos.MouseEnter

    End Sub

    Private Sub cbLinea_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLineas.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If

        cbGrupos.DataSource = GruposCC.Grupos(Me.cbLineas.SelectedValue).Tables("GruposCC")
        cbGrupos.ValueMember = "Código"
        cbGrupos.DisplayMember = "Nombre"
        cbGrupos.SelectedValue = 0

        ds = GruposCC.ArticulosCCList("", Me.cbProveedores.SelectedValue.ToString, Me.cbLineas.SelectedValue, Me.cbGrupos.SelectedValue, Me.cbSubGrupos.SelectedValue)
        'Me.dgArticulos.DataSource = ds.Tables("GruposCC").DefaultView
        MakeDataSet()
        dgArticulos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
    End Sub

    Private Sub cbGrupo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrupos.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If

        cbSubGrupos.DataSource = GruposCC.SubGrupos(Me.cbGrupos.SelectedValue).Tables("GruposCC")
        cbSubGrupos.ValueMember = "Código"
        cbSubGrupos.DisplayMember = "Nombre"
        cbSubGrupos.SelectedValue = 0

        ds = GruposCC.ArticulosCCList("", Me.cbProveedores.SelectedValue.ToString, Me.cbLineas.SelectedValue, Me.cbGrupos.SelectedValue, Me.cbSubGrupos.SelectedValue)
        'Me.dgArticulos.DataSource = ds.Tables("GruposCC").DefaultView
        MakeDataSet()
        dgArticulos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
    End Sub

    Private Sub cbProveedores_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedores.SelectedValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If

        If Not IsNumeric(Me.cbProveedores.SelectedValue.ToString) Then
            Exit Sub
        End If
        ds = GruposCC.ArticulosCCList("", Me.cbProveedores.SelectedValue.ToString, Me.cbLineas.SelectedValue.ToString, Me.cbGrupos.SelectedValue.ToString, Me.cbSubGrupos.SelectedValue.ToString)
        'Me.dgArticulos.DataSource = ds.Tables("GruposCC").DefaultView
        MakeDataSet()
        dgArticulos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
    End Sub

    Private myCheckBoxCol As Integer = 0 'my checkbox column 

    Private Sub dgArticulos_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgArticulos.MouseUp
        Dim hti As DataGrid.HitTestInfo = Me.dgArticulos.HitTest(e.X, e.Y)
        Try
            If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
                Me.dgArticulos(hti.Row, hti.Column) = Not CBool(Me.dgArticulos(hti.Row, hti.Column))
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try
    End Sub 'dataGrid2_MouseUp 

    'Private Sub dgArticulos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgArticulos.MouseMove
    '    Dim toolTip As New System.Windows.Forms.ToolTip()
    '    toolTip.SetToolTip(Me.dgArticulos, "Esta es una prueba")
    '    toolTip.Active = True
    'End Sub

End Class


'''Public Class DataGridCellTips
'''    Inherits DataGrid
'''    Private hitRow As Integer
'''    Private hitCol As Integer
'''    Private toolTip1 As System.Windows.Forms.ToolTip

'''    Public Sub New()
'''        hitRow = -1
'''        hitCol = -1
'''        Me.toolTip1 = New System.Windows.Forms.ToolTip()
'''        Me.toolTip1.InitialDelay = 1000
'''        AddHandler Me.MouseMove, AddressOf HandleMouseMove
'''    End Sub

'''    Private Sub HandleMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
'''        Dim hti As DataGrid.HitTestInfo = Me.HitTest(New Point(e.X, e.Y))
'''        If hti.Type = DataGrid.HitTestType.Cell AndAlso (Not (hti.Row = hitRow) OrElse Not (hti.Column = hitCol)) Then
'''            hitRow = hti.Row
'''            hitCol = hti.Column
'''            If Not (Me.toolTip1 Is Nothing) AndAlso Me.toolTip1.Active Then
'''                Me.toolTip1.Active = False
'''            End If
'''            Me.toolTip1.SetToolTip(Me, Me(hitRow, hitCol).ToString)
'''            Me.toolTip1.Active = True

'''        End If
'''    End Sub
'''End Class