Public Class frmBuscarItem
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmBuscarItem = Nothing

    Public Shared Function Instance() As frmBuscarItem
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmBuscarItem()
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
    Friend WithEvents cmdBuscar As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbFabricantes As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgArticulos = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.cbDescripcion = New System.Windows.Forms.ComboBox
        Me.cmdBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdTodos = New DevExpress.XtraEditors.SimpleButton
        Me.cmdZ = New DevExpress.XtraEditors.SimpleButton
        Me.cmdY = New DevExpress.XtraEditors.SimpleButton
        Me.cmdX = New DevExpress.XtraEditors.SimpleButton
        Me.cmdW = New DevExpress.XtraEditors.SimpleButton
        Me.cmdV = New DevExpress.XtraEditors.SimpleButton
        Me.cmdU = New DevExpress.XtraEditors.SimpleButton
        Me.cmdT = New DevExpress.XtraEditors.SimpleButton
        Me.cmdS = New DevExpress.XtraEditors.SimpleButton
        Me.cmdR = New DevExpress.XtraEditors.SimpleButton
        Me.cmdQ = New DevExpress.XtraEditors.SimpleButton
        Me.cmdH = New DevExpress.XtraEditors.SimpleButton
        Me.cmdG = New DevExpress.XtraEditors.SimpleButton
        Me.cmdF = New DevExpress.XtraEditors.SimpleButton
        Me.cmdE = New DevExpress.XtraEditors.SimpleButton
        Me.cmdD = New DevExpress.XtraEditors.SimpleButton
        Me.cmdC = New DevExpress.XtraEditors.SimpleButton
        Me.cmdB = New DevExpress.XtraEditors.SimpleButton
        Me.cmdA = New DevExpress.XtraEditors.SimpleButton
        Me.cmdP = New DevExpress.XtraEditors.SimpleButton
        Me.cmdO = New DevExpress.XtraEditors.SimpleButton
        Me.cmdN = New DevExpress.XtraEditors.SimpleButton
        Me.cmdM = New DevExpress.XtraEditors.SimpleButton
        Me.cmdL = New DevExpress.XtraEditors.SimpleButton
        Me.cmdK = New DevExpress.XtraEditors.SimpleButton
        Me.cmdJ = New DevExpress.XtraEditors.SimpleButton
        Me.cmdI = New DevExpress.XtraEditors.SimpleButton
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbLineas = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbProveedores = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbGrupos = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbFabricantes = New System.Windows.Forms.ComboBox
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
        Me.dgArticulos.Location = New System.Drawing.Point(8, 17)
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgArticulos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgArticulos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgArticulos.SelectionForeColor = System.Drawing.Color.White
        Me.dgArticulos.Size = New System.Drawing.Size(968, 341)
        Me.dgArticulos.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdAgregar)
        Me.GroupBox1.Controls.Add(Me.dgArticulos)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 402)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(120, 364)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Regresar"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(16, 364)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAgregar.TabIndex = 1
        Me.cmdAgregar.Text = "&Agregar"
        '
        'cbDescripcion
        '
        Me.cbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDescripcion.Location = New System.Drawing.Point(96, 43)
        Me.cbDescripcion.Name = "cbDescripcion"
        Me.cbDescripcion.Size = New System.Drawing.Size(256, 21)
        Me.cbDescripcion.TabIndex = 112
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(928, 78)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(72, 25)
        Me.cmdBuscar.TabIndex = 132
        Me.cmdBuscar.Text = "Buscar"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmdTodos)
        Me.GroupBox3.Controls.Add(Me.cmdZ)
        Me.GroupBox3.Controls.Add(Me.cmdY)
        Me.GroupBox3.Controls.Add(Me.cmdX)
        Me.GroupBox3.Controls.Add(Me.cmdW)
        Me.GroupBox3.Controls.Add(Me.cmdV)
        Me.GroupBox3.Controls.Add(Me.cmdU)
        Me.GroupBox3.Controls.Add(Me.cmdT)
        Me.GroupBox3.Controls.Add(Me.cmdS)
        Me.GroupBox3.Controls.Add(Me.cmdR)
        Me.GroupBox3.Controls.Add(Me.cmdQ)
        Me.GroupBox3.Controls.Add(Me.cmdH)
        Me.GroupBox3.Controls.Add(Me.cmdG)
        Me.GroupBox3.Controls.Add(Me.cmdF)
        Me.GroupBox3.Controls.Add(Me.cmdE)
        Me.GroupBox3.Controls.Add(Me.cmdD)
        Me.GroupBox3.Controls.Add(Me.cmdC)
        Me.GroupBox3.Controls.Add(Me.cmdB)
        Me.GroupBox3.Controls.Add(Me.cmdA)
        Me.GroupBox3.Controls.Add(Me.cmdP)
        Me.GroupBox3.Controls.Add(Me.cmdO)
        Me.GroupBox3.Controls.Add(Me.cmdN)
        Me.GroupBox3.Controls.Add(Me.cmdM)
        Me.GroupBox3.Controls.Add(Me.cmdL)
        Me.GroupBox3.Controls.Add(Me.cmdK)
        Me.GroupBox3.Controls.Add(Me.cmdJ)
        Me.GroupBox3.Controls.Add(Me.cmdI)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(16, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(696, 43)
        Me.GroupBox3.TabIndex = 133
        Me.GroupBox3.TabStop = False
        '
        'cmdTodos
        '
        Me.cmdTodos.Location = New System.Drawing.Point(632, 13)
        Me.cmdTodos.Name = "cmdTodos"
        Me.cmdTodos.Size = New System.Drawing.Size(56, 26)
        Me.cmdTodos.TabIndex = 166
        Me.cmdTodos.Text = "Todos"
        '
        'cmdZ
        '
        Me.cmdZ.Location = New System.Drawing.Point(608, 13)
        Me.cmdZ.Name = "cmdZ"
        Me.cmdZ.Size = New System.Drawing.Size(24, 26)
        Me.cmdZ.TabIndex = 165
        Me.cmdZ.Text = "Z"
        '
        'cmdY
        '
        Me.cmdY.Location = New System.Drawing.Point(584, 13)
        Me.cmdY.Name = "cmdY"
        Me.cmdY.Size = New System.Drawing.Size(24, 26)
        Me.cmdY.TabIndex = 164
        Me.cmdY.Text = "Y"
        '
        'cmdX
        '
        Me.cmdX.Location = New System.Drawing.Point(560, 13)
        Me.cmdX.Name = "cmdX"
        Me.cmdX.Size = New System.Drawing.Size(24, 26)
        Me.cmdX.TabIndex = 163
        Me.cmdX.Text = "X"
        '
        'cmdW
        '
        Me.cmdW.Location = New System.Drawing.Point(536, 13)
        Me.cmdW.Name = "cmdW"
        Me.cmdW.Size = New System.Drawing.Size(24, 26)
        Me.cmdW.TabIndex = 162
        Me.cmdW.Text = "W"
        '
        'cmdV
        '
        Me.cmdV.Location = New System.Drawing.Point(512, 13)
        Me.cmdV.Name = "cmdV"
        Me.cmdV.Size = New System.Drawing.Size(24, 26)
        Me.cmdV.TabIndex = 161
        Me.cmdV.Text = "V"
        '
        'cmdU
        '
        Me.cmdU.Location = New System.Drawing.Point(488, 13)
        Me.cmdU.Name = "cmdU"
        Me.cmdU.Size = New System.Drawing.Size(24, 26)
        Me.cmdU.TabIndex = 160
        Me.cmdU.Text = "U"
        '
        'cmdT
        '
        Me.cmdT.Location = New System.Drawing.Point(464, 13)
        Me.cmdT.Name = "cmdT"
        Me.cmdT.Size = New System.Drawing.Size(24, 26)
        Me.cmdT.TabIndex = 159
        Me.cmdT.Text = "T"
        '
        'cmdS
        '
        Me.cmdS.Location = New System.Drawing.Point(440, 13)
        Me.cmdS.Name = "cmdS"
        Me.cmdS.Size = New System.Drawing.Size(24, 26)
        Me.cmdS.TabIndex = 158
        Me.cmdS.Text = "S"
        '
        'cmdR
        '
        Me.cmdR.Location = New System.Drawing.Point(416, 13)
        Me.cmdR.Name = "cmdR"
        Me.cmdR.Size = New System.Drawing.Size(24, 26)
        Me.cmdR.TabIndex = 157
        Me.cmdR.Text = "R"
        '
        'cmdQ
        '
        Me.cmdQ.Location = New System.Drawing.Point(392, 13)
        Me.cmdQ.Name = "cmdQ"
        Me.cmdQ.Size = New System.Drawing.Size(24, 26)
        Me.cmdQ.TabIndex = 156
        Me.cmdQ.Text = "Q"
        '
        'cmdH
        '
        Me.cmdH.Location = New System.Drawing.Point(176, 13)
        Me.cmdH.Name = "cmdH"
        Me.cmdH.Size = New System.Drawing.Size(24, 26)
        Me.cmdH.TabIndex = 147
        Me.cmdH.Text = "H"
        '
        'cmdG
        '
        Me.cmdG.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdG.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.cmdG.Appearance.Options.UseFont = True
        Me.cmdG.Appearance.Options.UseForeColor = True
        Me.cmdG.Location = New System.Drawing.Point(152, 13)
        Me.cmdG.Name = "cmdG"
        Me.cmdG.Size = New System.Drawing.Size(24, 26)
        Me.cmdG.TabIndex = 146
        Me.cmdG.Text = "G"
        '
        'cmdF
        '
        Me.cmdF.Location = New System.Drawing.Point(128, 13)
        Me.cmdF.Name = "cmdF"
        Me.cmdF.Size = New System.Drawing.Size(24, 26)
        Me.cmdF.TabIndex = 145
        Me.cmdF.Text = "F"
        '
        'cmdE
        '
        Me.cmdE.Location = New System.Drawing.Point(104, 13)
        Me.cmdE.Name = "cmdE"
        Me.cmdE.Size = New System.Drawing.Size(24, 26)
        Me.cmdE.TabIndex = 144
        Me.cmdE.Text = "E"
        '
        'cmdD
        '
        Me.cmdD.Location = New System.Drawing.Point(80, 13)
        Me.cmdD.Name = "cmdD"
        Me.cmdD.Size = New System.Drawing.Size(24, 26)
        Me.cmdD.TabIndex = 143
        Me.cmdD.Text = "D"
        '
        'cmdC
        '
        Me.cmdC.Location = New System.Drawing.Point(56, 13)
        Me.cmdC.Name = "cmdC"
        Me.cmdC.Size = New System.Drawing.Size(24, 26)
        Me.cmdC.TabIndex = 142
        Me.cmdC.Text = "C"
        '
        'cmdB
        '
        Me.cmdB.Location = New System.Drawing.Point(32, 13)
        Me.cmdB.Name = "cmdB"
        Me.cmdB.Size = New System.Drawing.Size(24, 26)
        Me.cmdB.TabIndex = 141
        Me.cmdB.Text = "B"
        '
        'cmdA
        '
        Me.cmdA.Location = New System.Drawing.Point(8, 13)
        Me.cmdA.Name = "cmdA"
        Me.cmdA.Size = New System.Drawing.Size(24, 26)
        Me.cmdA.TabIndex = 140
        Me.cmdA.Text = "A"
        '
        'cmdP
        '
        Me.cmdP.Location = New System.Drawing.Point(368, 13)
        Me.cmdP.Name = "cmdP"
        Me.cmdP.Size = New System.Drawing.Size(24, 26)
        Me.cmdP.TabIndex = 155
        Me.cmdP.Text = "P"
        '
        'cmdO
        '
        Me.cmdO.Location = New System.Drawing.Point(344, 13)
        Me.cmdO.Name = "cmdO"
        Me.cmdO.Size = New System.Drawing.Size(24, 26)
        Me.cmdO.TabIndex = 154
        Me.cmdO.Text = "O"
        '
        'cmdN
        '
        Me.cmdN.Location = New System.Drawing.Point(320, 13)
        Me.cmdN.Name = "cmdN"
        Me.cmdN.Size = New System.Drawing.Size(24, 26)
        Me.cmdN.TabIndex = 153
        Me.cmdN.Text = "N"
        '
        'cmdM
        '
        Me.cmdM.Location = New System.Drawing.Point(296, 13)
        Me.cmdM.Name = "cmdM"
        Me.cmdM.Size = New System.Drawing.Size(24, 26)
        Me.cmdM.TabIndex = 152
        Me.cmdM.Text = "M"
        '
        'cmdL
        '
        Me.cmdL.Location = New System.Drawing.Point(272, 13)
        Me.cmdL.Name = "cmdL"
        Me.cmdL.Size = New System.Drawing.Size(24, 26)
        Me.cmdL.TabIndex = 151
        Me.cmdL.Text = "L"
        '
        'cmdK
        '
        Me.cmdK.Location = New System.Drawing.Point(248, 13)
        Me.cmdK.Name = "cmdK"
        Me.cmdK.Size = New System.Drawing.Size(24, 26)
        Me.cmdK.TabIndex = 150
        Me.cmdK.Text = "K"
        '
        'cmdJ
        '
        Me.cmdJ.Location = New System.Drawing.Point(224, 13)
        Me.cmdJ.Name = "cmdJ"
        Me.cmdJ.Size = New System.Drawing.Size(24, 26)
        Me.cmdJ.TabIndex = 149
        Me.cmdJ.Text = "J"
        '
        'cmdI
        '
        Me.cmdI.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdI.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.cmdI.Appearance.Options.UseFont = True
        Me.cmdI.Appearance.Options.UseForeColor = True
        Me.cmdI.Location = New System.Drawing.Point(200, 13)
        Me.cmdI.Name = "cmdI"
        Me.cmdI.Size = New System.Drawing.Size(24, 26)
        Me.cmdI.TabIndex = 148
        Me.cmdI.Text = "I"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(832, 17)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(136, 20)
        Me.TextBox1.TabIndex = 123
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(752, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 26)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Teléfono:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(632, 474)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 26)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "0.00"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(536, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 26)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Total:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(96, 9)
        Me.txtCodigo.MaxLength = 50
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(136, 20)
        Me.txtCodigo.TabIndex = 135
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 25)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Código"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 26)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Descripción"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(704, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 25)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "Línea"
        '
        'cbLineas
        '
        Me.cbLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLineas.Location = New System.Drawing.Point(752, 9)
        Me.cbLineas.Name = "cbLineas"
        Me.cbLineas.Size = New System.Drawing.Size(248, 21)
        Me.cbLineas.TabIndex = 137
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(360, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 25)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "Proveedor"
        '
        'cbProveedores
        '
        Me.cbProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedores.Location = New System.Drawing.Point(432, 9)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(264, 21)
        Me.cbProveedores.TabIndex = 139
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(704, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 26)
        Me.Label8.TabIndex = 142
        Me.Label8.Text = "Grupo"
        '
        'cbGrupos
        '
        Me.cbGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupos.Location = New System.Drawing.Point(752, 43)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.Size = New System.Drawing.Size(248, 21)
        Me.cbGrupos.TabIndex = 141
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(360, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 26)
        Me.Label9.TabIndex = 144
        Me.Label9.Text = "Fabricante"
        '
        'cbFabricantes
        '
        Me.cbFabricantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFabricantes.Location = New System.Drawing.Point(432, 43)
        Me.cbFabricantes.Name = "cbFabricantes"
        Me.cbFabricantes.Size = New System.Drawing.Size(264, 21)
        Me.cbFabricantes.TabIndex = 143
        '
        'frmBuscarItem
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 526)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbFabricantes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbGrupos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbProveedores)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbLineas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cbDescripcion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBuscarItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Public tItem As DataTable

    Dim Cantidad As New DataGridTextBoxColumn()
    Dim ValorActualCantidad As Double

    Dim DetallesProducto As New VB.SysContab.ArticulosDetails()

    Public Inicio As Boolean
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

        'Dim i As Integer
        'For i = 0 To n - 1
        '    MsgBox(tItem.Rows(i)("Codigo"))
        'Next

    End Sub

    Private Sub frmBuscarItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Tabla As New DataTable()

        'r.CambiarEstilo(Me)
        r.FormularioColor(Me)

        ds = Articulos.ArticulosConsulta(txtCodigo.Text, "", "", "")

        'cbDescripcion.DataSource = Articulos.ArticulosList.Tables("Articulos")
        'cbDescripcion.ValueMember = "CODIGO_ARTICULO"
        'cbDescripcion.DisplayMember = "NOMBRE"

        'cbProveedores.DataSource = Proveedores.ProveedoresListCombo().Tables("Proveedores")
        'cbProveedores.ValueMember = "CODIGO"
        'cbProveedores.DisplayMember = "NOMBRE"

        cbDescripcion.DataSource = Articulos.ArticulosListAll.Tables("Articulos")
        cbDescripcion.ValueMember = "Codigo"
        cbDescripcion.DisplayMember = "Nombre"
        cbDescripcion.SelectedValue = 0

        cbProveedores.DataSource = Proveedores.ProveedoresList(3).Tables("PROVEEDORES")
        cbProveedores.ValueMember = "Codigo"
        cbProveedores.DisplayMember = "Nombre"
        cbProveedores.SelectedValue = 0

        cbLineas.DataSource = Grupos.ListLineasProductos("%").Tables("Grupos_Inventario")
        cbLineas.ValueMember = "CODIGO_GRUPO"
        cbLineas.DisplayMember = "NOMBRE"

        cbGrupos.DataSource = Grupos.ListGruposxLineasProductos("%").Tables("Grupos_Inventario")
        cbGrupos.ValueMember = "CODIGO_GRUPO"
        cbGrupos.DisplayMember = "NOMBRE"

        dgArticulos.ReadOnly = False

        dgArticulos.CaptionText = "Lista de Productos"

        Me.Text = "B u s c a r  P r o d u c t o s"

        MakeDataSet()
        dgArticulos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()

        ''''''''''''''''''''''''''''''

        MakeDataSetTemporal()
        'dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
        AddCustomDataTableStyleTemporal()

        Me.Refresh()

        txtCodigo.Text = ""
        cbDescripcion.SelectedValue = -1
        cbLineas.SelectedValue = -1
        cbProveedores.SelectedValue = -1

        cbDescripcion.Text = ""
        cbLineas.Text = ""
        cbProveedores.Text = ""

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

        Dim cCustPrecio As DataColumn
        cCustPrecio = New DataColumn("Precio")

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
        tCust.Columns.Add(cCustPrecio)
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

        For i = 0 To ds.Tables("Articulos").Rows.Count - 1
            newRow1 = tCust.NewRow
            newRow1("Codigo") = ds.Tables("Articulos").Rows(i).Item("Codigo")
            tCust.Rows.Add(newRow1)

            tCust.Rows(i)("Cantidad") = "1"

            tCust.Rows(i)("Detalle") = "Mostrar Detalles"
            tCust.Rows(i)("Descripcion") = ds.Tables("Articulos").Rows(i).Item("Nombre")
            tCust.Rows(i)("Proveedor") = ds.Tables("Articulos").Rows(i).Item("Proveedor")
            tCust.Rows(i)("Precio") = CDbl(ds.Tables("Articulos").Rows(i).Item("Precio")).ToString(Round)
            tCust.Rows(i)("Costo") = CDbl(ds.Tables("Articulos").Rows(i).Item("Costo")).ToString(Round)
            tCust.Rows(i)("Existencias") = ds.Tables("Articulos").Rows(i).Item("Existencias")
            tCust.Rows(i)("Tipo") = ds.Tables("Articulos").Rows(i).Item("Tipo")
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
        Try
            Dim f As frmDetalleArticulo = f.Instance
            f.Tipo = "P"
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
            Else
                'If CDbl(Cantidad.TextBox.Text) > tCust.Rows(Me.dgArticulos.CurrentRowIndex)("Existencias") Then
                '    MsgBox("La existencia actual es: " & tCust.Rows(Me.dgArticulos.CurrentRowIndex)("Existencias"), MsgBoxStyle.Information)
                '    Cantidad.TextBox.Text = tCust.Rows(Me.dgArticulos.CurrentRowIndex)("Existencias")
                'End If

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

        Dim Precio As DataGridColumnStyle
        Precio = New DataGridTextBoxColumn()
        Precio.MappingName = "Precio"
        'from dataset table
        Precio.HeaderText = "Precio"
        Precio.Width = 70
        Precio.ReadOnly = True
        Precio.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(Precio)
        colCount = (colCount + 1)

        Precio.NullText = ""

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
        Descuento.HeaderText = "Descuento"
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
                    tItem.Rows(n)("Precio") = tCust.Rows(i)("Precio")
                    tItem.Rows(n)("Costo") = tCust.Rows(i)("Costo")

                    tItem.Rows(n)("Tipo") = tCust.Rows(i)("Tipo")

                    n = n + 1

                End If

            End If

        Next

    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        '''''If Trim(cbBuscar.Text) = "" Then
        '''''    ds = Articulos.ProductosGetAll("A")
        '''''Else
        '''''    If rbDescripcion.Checked = True Then
        '''''        ds = Articulos.ArticulosConsulta(cbBuscar.Text.ToString, Campo)
        '''''    Else
        ds = Articulos.ArticulosConsulta(txtCodigo.Text, cbDescripcion.Text, cbLineas.Text, cbProveedores.Text)

        '''''    End If

        '''''End If

        If ds.Tables("Articulos").Rows.Count = 0 Then
            MsgBox("No se encontraron datos...", MsgBoxStyle.Information)
            cmdBuscar.Focus()
            Exit Sub
        End If

        MakeDataSet()
        dgArticulos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()

    End Sub
    'Dim i As Integer
    Private Sub cmdA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdA.Click
        BuscarXLetra(cmdA.Text)
        'For i = 0 To GroupBox3.Controls.Count - 1
        '    GroupBox3.Controls(i).ForeColor = Color.Black
        'Next
        'cmdA.ForeColor = Color.Red
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
        'cbBuscar.Text = ""
        txtCodigo.Text = ""
        cbDescripcion.SelectedValue = -1
        cbLineas.SelectedValue = -1
        cbProveedores.SelectedValue = -1
        cbFabricantes.SelectedValue = -1
        cbGrupos.SelectedValue = -1

        cbDescripcion.Text = ""
        cbLineas.Text = ""
        cbProveedores.Text = ""
        cbFabricantes.Text = ""
        cbGrupos.Text = ""

        cbDescripcion.Refresh()
        cbLineas.Refresh()
        cbProveedores.Refresh()
        cbFabricantes.Refresh()
        cbGrupos.Refresh()

        'cbBuscar.SelectedIndex = -1
        BuscarXLetra("Todos")

    End Sub

    'Buscar por letra
    Private Sub BuscarXLetra(ByVal Letra As String)
        If Letra = "Todos" Then
            'ds = Articulos.ArticulosConsultaLetra("", txtCodigo.Text, cbDescripcion.Text, cbLineas.Text, cbProveedores.Text)
            ds = Articulos.ArticulosConsultaLetra("", "", "", "", "", 0)
        Else
            ds = Articulos.ArticulosConsultaLetra(Letra, txtCodigo.Text, cbDescripcion.Text, cbLineas.Text, cbProveedores.Text, 0)

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

    Private Sub frmBuscarItem_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

    End Sub

    Private Sub dgArticulos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgArticulos.MouseEnter

    End Sub

    Private Sub cbLineas_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLineas.SelectedValueChanged
        If Me.Inicio = True Then
            Exit Sub
        End If

        cbGrupos.DataSource = Grupos.ListGruposxLineasProductos(cbLineas.SelectedValue.ToString).Tables("Grupos_Inventario")
        cbGrupos.ValueMember = "CODIGO_GRUPO"
        cbGrupos.DisplayMember = "NOMBRE"

        If Grupos.ListGruposxLineasProductos(cbLineas.SelectedValue.ToString).Tables("Grupos_Inventario").Rows.Count = 0 Then
            cbGrupos.Text = ""
        End If

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