Public Class frmCobrosNotasDebito
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
    Friend WithEvents txtBanID As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgNotasDebitos As System.Windows.Forms.DataGrid
    Friend WithEvents dgNotasCreditos As System.Windows.Forms.DataGrid
    Friend WithEvents cbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdContabilizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents nudAnio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtBanID = New System.Windows.Forms.TextBox
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.dgNotasCreditos = New System.Windows.Forms.DataGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgNotasDebitos = New System.Windows.Forms.DataGrid
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdContabilizar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.nudAnio = New System.Windows.Forms.NumericUpDown
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbMeses = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.dgNotasCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgNotasDebitos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nudAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBanID
        '
        Me.txtBanID.Location = New System.Drawing.Point(16, 258)
        Me.txtBanID.Name = "txtBanID"
        Me.txtBanID.Size = New System.Drawing.Size(100, 21)
        Me.txtBanID.TabIndex = 165
        Me.txtBanID.Text = "0"
        Me.txtBanID.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(912, 19)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(80, 18)
        Me.LinkLabel2.TabIndex = 163
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Ver Detalles"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(912, 216)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(80, 18)
        Me.LinkLabel1.TabIndex = 164
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ver Detalles"
        '
        'dgNotasCreditos
        '
        Me.dgNotasCreditos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgNotasCreditos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgNotasCreditos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgNotasCreditos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgNotasCreditos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgNotasCreditos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgNotasCreditos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgNotasCreditos.DataMember = ""
        Me.dgNotasCreditos.FlatMode = True
        Me.dgNotasCreditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgNotasCreditos.ForeColor = System.Drawing.Color.Black
        Me.dgNotasCreditos.GridLineColor = System.Drawing.Color.Silver
        Me.dgNotasCreditos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgNotasCreditos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgNotasCreditos.HeaderForeColor = System.Drawing.Color.White
        Me.dgNotasCreditos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgNotasCreditos.Location = New System.Drawing.Point(288, 213)
        Me.dgNotasCreditos.Name = "dgNotasCreditos"
        Me.dgNotasCreditos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgNotasCreditos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgNotasCreditos.ReadOnly = True
        Me.dgNotasCreditos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgNotasCreditos.SelectionForeColor = System.Drawing.Color.White
        Me.dgNotasCreditos.Size = New System.Drawing.Size(712, 259)
        Me.dgNotasCreditos.TabIndex = 145
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(288, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(712, 22)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "COMPRAS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(288, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(712, 22)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "NOTAS DE DEBITOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgNotasDebitos
        '
        Me.dgNotasDebitos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgNotasDebitos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgNotasDebitos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgNotasDebitos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgNotasDebitos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgNotasDebitos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgNotasDebitos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgNotasDebitos.DataMember = ""
        Me.dgNotasDebitos.FlatMode = True
        Me.dgNotasDebitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgNotasDebitos.ForeColor = System.Drawing.Color.Black
        Me.dgNotasDebitos.GridLineColor = System.Drawing.Color.Silver
        Me.dgNotasDebitos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgNotasDebitos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgNotasDebitos.HeaderForeColor = System.Drawing.Color.White
        Me.dgNotasDebitos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgNotasDebitos.Location = New System.Drawing.Point(288, 17)
        Me.dgNotasDebitos.Name = "dgNotasDebitos"
        Me.dgNotasDebitos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgNotasDebitos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgNotasDebitos.ReadOnly = True
        Me.dgNotasDebitos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgNotasDebitos.SelectionForeColor = System.Drawing.Color.White
        Me.dgNotasDebitos.Size = New System.Drawing.Size(712, 190)
        Me.dgNotasDebitos.TabIndex = 143
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button1)
        Me.GroupBox9.Controls.Add(Me.cmdContabilizar)
        Me.GroupBox9.Controls.Add(Me.cmdCancelar)
        Me.GroupBox9.Location = New System.Drawing.Point(16, 129)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(264, 61)
        Me.GroupBox9.TabIndex = 142
        Me.GroupBox9.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Ayuda"
        '
        'cmdContabilizar
        '
        Me.cmdContabilizar.Location = New System.Drawing.Point(8, 17)
        Me.cmdContabilizar.Name = "cmdContabilizar"
        Me.cmdContabilizar.Size = New System.Drawing.Size(76, 35)
        Me.cmdContabilizar.TabIndex = 2
        Me.cmdContabilizar.Text = "C&ontabilizar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(184, 17)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 35)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.nudAnio)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cbMeses)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 104)
        Me.GroupBox3.TabIndex = 141
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TIEMPO"
        '
        'nudAnio
        '
        Me.nudAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudAnio.Location = New System.Drawing.Point(64, 69)
        Me.nudAnio.Maximum = New Decimal(New Integer() {9998, 0, 0, 0})
        Me.nudAnio.Minimum = New Decimal(New Integer() {1753, 0, 0, 0})
        Me.nudAnio.Name = "nudAnio"
        Me.nudAnio.Size = New System.Drawing.Size(72, 20)
        Me.nudAnio.TabIndex = 150
        Me.nudAnio.Value = New Decimal(New Integer() {1753, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(8, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 26)
        Me.Label15.TabIndex = 149
        Me.Label15.Text = "Año:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 25)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "Mes:"
        '
        'cbMeses
        '
        Me.cbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMeses.Items.AddRange(New Object() {"Todos", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMeses.Location = New System.Drawing.Point(64, 23)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Size = New System.Drawing.Size(192, 23)
        Me.cbMeses.TabIndex = 147
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(288, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(712, 22)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "NOTAS DE CREDITOS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCobrosNotasDebito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 484)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBanID)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.dgNotasCreditos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgNotasDebitos)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmCobrosNotasDebito"
        Me.Text = "FrmIVAContabilizado"
        CType(Me.dgNotasCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgNotasDebitos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.nudAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Shared ChildInstance As frmCobrosNotasDebito = Nothing

    Public Shared Function Instance() As frmCobrosNotasDebito
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmCobrosNotasDebito()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim ds As DataSet
    Dim ds1 As DataSet

    Private Sub frmCobrosNotasDebito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabla As DataTable
        Dim Tabla1 As DataTable

        Me.cbMeses.SelectedIndex = 0
        Me.nudAnio.Value = CDate(r.Fecha).Year

        ds = Clientes.CobrosNotasDebito(Me.cbMeses.SelectedIndex, Me.nudAnio.Value)
        ds1 = Proveedores.NotasCredito(Me.cbMeses.SelectedIndex, Me.nudAnio.Value)

        Me.dgNotasDebitos.DataSource = ds.Tables("Cobros").DefaultView
        Tabla = ds.Tables("Cobros")

        r.FormatGenerico(Me.dgNotasDebitos, Tabla)

        Me.dgNotasCreditos.DataSource = ds1.Tables("Cobros").DefaultView
        Tabla1 = ds1.Tables("Cobros")

        r.FormatGenerico(Me.dgNotasCreditos, Tabla1)

        Me.dgNotasDebitos.CaptionText = "Notas de Débitos"
        Me.Text = "Notas de Débitos y Créditos"
        Me.Refresh()


    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cbMeses_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMeses.SelectedIndexChanged
        ds = Clientes.CobrosNotasDebito(Me.cbMeses.SelectedIndex, Me.nudAnio.Value)
        Me.dgNotasDebitos.DataSource = ds.Tables("Cobros").DefaultView

        ds1 = Proveedores.NotasCredito(Me.cbMeses.SelectedIndex, Me.nudAnio.Value)
        Me.dgNotasCreditos.DataSource = ds1.Tables("Cobros").DefaultView
    End Sub

    Private Sub nudAnio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudAnio.ValueChanged
        ds = Clientes.CobrosNotasDebito(Me.cbMeses.SelectedIndex, Me.nudAnio.Value)
        Me.dgNotasDebitos.DataSource = ds.Tables("Cobros").DefaultView

        ds1 = Proveedores.NotasCredito(Me.cbMeses.SelectedIndex, Me.nudAnio.Value)
        Me.dgNotasCreditos.DataSource = ds1.Tables("Cobros").DefaultView
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Help.ShowHelp(Me, "ayuda/Procesos/ProcesosContab.chm", HelpNavigator.KeywordIndex, "Sec1.6")
    End Sub
End Class
