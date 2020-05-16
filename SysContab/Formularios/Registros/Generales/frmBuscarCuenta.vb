Public Class frmCuentasAsignar
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgCatalogo As System.Windows.Forms.DataGrid
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents lblSalir As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgCatalogo = New System.Windows.Forms.DataGrid()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblSalir = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.txtCodigo)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(288, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(240, 51)
        Me.GroupBox4.TabIndex = 146
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Codigo de Cuenta"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(16, 17)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(200, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(832, 17)
        Me.TextBox2.MaxLength = 50
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(136, 20)
        Me.TextBox2.TabIndex = 123
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(752, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 26)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Teléfono:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(632, 474)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 26)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "0.00"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(536, 474)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 26)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Total:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(16, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 51)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nombre de Cuenta"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(16, 17)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(224, 20)
        Me.txtNombre.TabIndex = 1
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(832, 17)
        Me.TextBox4.MaxLength = 50
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(136, 20)
        Me.TextBox4.TabIndex = 123
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
        'dgCatalogo
        '
        Me.dgCatalogo.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgCatalogo.BackColor = System.Drawing.Color.Gainsboro
        Me.dgCatalogo.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCatalogo.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgCatalogo.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgCatalogo.CaptionForeColor = System.Drawing.Color.Black
        Me.dgCatalogo.DataMember = ""
        Me.dgCatalogo.FlatMode = True
        Me.dgCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCatalogo.ForeColor = System.Drawing.Color.Black
        Me.dgCatalogo.GridLineColor = System.Drawing.Color.Silver
        Me.dgCatalogo.HeaderBackColor = System.Drawing.Color.Black
        Me.dgCatalogo.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgCatalogo.HeaderForeColor = System.Drawing.Color.White
        Me.dgCatalogo.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgCatalogo.Location = New System.Drawing.Point(8, 95)
        Me.dgCatalogo.Name = "dgCatalogo"
        Me.dgCatalogo.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgCatalogo.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCatalogo.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgCatalogo.SelectionForeColor = System.Drawing.Color.White
        Me.dgCatalogo.Size = New System.Drawing.Size(784, 482)
        Me.dgCatalogo.TabIndex = 148
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(232, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(360, 25)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "SELECCIONE UNA CUENTA DE TIPO AUXILIAR"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Controls.Add(Me.cmdAyuda)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(800, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(88, 568)
        Me.GroupBox2.TabIndex = 150
        Me.GroupBox2.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(7, 112)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 25)
        Me.cmdSalir.TabIndex = 126
        Me.cmdSalir.Text = "Salir"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(7, 69)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(75, 25)
        Me.cmdAyuda.TabIndex = 125
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 26)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 25)
        Me.cmdAceptar.TabIndex = 124
        Me.cmdAceptar.Text = "Aceptar"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(832, 17)
        Me.TextBox3.MaxLength = 50
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(136, 20)
        Me.TextBox3.TabIndex = 123
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(752, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 26)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Teléfono:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(632, 474)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 26)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "0.00"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(536, 474)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 26)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Total:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrupo
        '
        Me.lblGrupo.Location = New System.Drawing.Point(600, 26)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(100, 25)
        Me.lblGrupo.TabIndex = 151
        Me.lblGrupo.Text = "Label11"
        Me.lblGrupo.Visible = False
        '
        'lblSalir
        '
        Me.lblSalir.Location = New System.Drawing.Point(600, 52)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Size = New System.Drawing.Size(100, 24)
        Me.lblSalir.TabIndex = 152
        Me.lblSalir.Text = "0"
        Me.lblSalir.Visible = False
        '
        'frmCuentasAsignar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(894, 597)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSalir)
        Me.Controls.Add(Me.lblGrupo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgCatalogo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCuentasAsignar"
        Me.Text = "Buscar Cuenta en Catalogo"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Cuentas As New VB.SysContab.CatalogoDB()
    Dim Rutinas As New VB.SysContab.Rutinas()

    Private Sub frmCuentasBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As DataSet
        ds = Cuentas.GetList("")
        dgCatalogo.DataSource = ds.Tables("CATALOGO").DefaultView
        Dim Tabla As DataTable
        Tabla = ds.Tables("CATALOGO")
        Rutinas.FormatGenerico(dgCatalogo, Tabla)
        Me.dgCatalogo.ReadOnly = True
        lblSalir.Text = 0
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        dgCatalogo.DataSource = Cuentas.GetListCodigoBuscar(txtCodigo.Text, EmpresaActual).Tables("CATALOGO").DefaultView
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        dgCatalogo.DataSource = Cuentas.GetListBuscarCombo(txtNombre.Text, EmpresaActual).Tables("CATALOGO").DefaultView
    End Sub


    Private Sub dgCatalogo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCatalogo.DoubleClick

        'Dim f As DataGridTextBox.frmComprobantes

        RegistroFacturaTemporal = dgCatalogo.Item(dgCatalogo.CurrentRowIndex, 1)
        LoadFacturaTemporal = True

        If dgCatalogo.Item(dgCatalogo.CurrentRowIndex, 2) = "A" Then
            lblSalir.Text = 1
            Me.Close()
        Else
            MsgBox("Esta Cuenta no es de tipo AUXILIAR")
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click

        lblSalir.Text = 0
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Mid(dgCatalogo.Item(dgCatalogo.CurrentRowIndex, 2).ToString, 1, 1) = "A" Then
            lblSalir.Text = 1
            Me.Close()
        Else
            MsgBox("Esta Cuenta no es de tipo AUXILIAR")
        End If
    End Sub
End Class
