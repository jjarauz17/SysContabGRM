Public Class FrmDetalleA2
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
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents txtempresa As System.Windows.Forms.TextBox
    Friend WithEvents txtmes As System.Windows.Forms.TextBox
    Friend WithEvents txtcomp As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtempresa = New System.Windows.Forms.TextBox
        Me.txtusuario = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtmes = New System.Windows.Forms.TextBox
        Me.txtcomp = New System.Windows.Forms.TextBox
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'Grid.EmbeddedNavigator
        '
        Me.Grid.EmbeddedNavigator.Name = ""
        Me.Grid.Location = New System.Drawing.Point(8, 104)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(472, 168)
        Me.Grid.TabIndex = 2
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False

        '
        'cmdsalir
        '
        Me.cmdsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdsalir.Location = New System.Drawing.Point(400, 280)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.TabIndex = 3
        Me.cmdsalir.Text = "&Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtempresa)
        Me.GroupBox1.Controls.Add(Me.txtusuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtmes)
        Me.GroupBox1.Controls.Add(Me.txtcomp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 88)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Documento"
        '
        'txtempresa
        '
        Me.txtempresa.Location = New System.Drawing.Point(96, 56)
        Me.txtempresa.Name = "txtempresa"
        Me.txtempresa.ReadOnly = True
        Me.txtempresa.TabIndex = 6
        Me.txtempresa.Text = ""
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(96, 24)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.ReadOnly = True
        Me.txtusuario.TabIndex = 6
        Me.txtusuario.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usuario:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Empresa:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(240, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mes:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(240, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Comprobante No:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmes
        '
        Me.txtmes.Location = New System.Drawing.Point(352, 24)
        Me.txtmes.Name = "txtmes"
        Me.txtmes.ReadOnly = True
        Me.txtmes.TabIndex = 6
        Me.txtmes.Text = ""
        '
        'txtcomp
        '
        Me.txtcomp.Location = New System.Drawing.Point(352, 56)
        Me.txtcomp.Name = "txtcomp"
        Me.txtcomp.ReadOnly = True
        Me.txtcomp.TabIndex = 6
        Me.txtcomp.Text = ""
        '
        'FrmDetalleA2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(488, 314)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.Grid)
        Me.Name = "FrmDetalleA2"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Detalle Auditoria"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private _Usuario As String
    Private _Empresa As String
    Private _Mes As String
    Private _Comp As String

#Region "Propiedades"
    Public Property Comprobante()
        Get
            Return _Comp
        End Get
        Set(ByVal Value)
            _Comp = Value
        End Set
    End Property
    Public Property Mes()
        Get
            Return _Mes
        End Get
        Set(ByVal Value)
            _Mes = Value
        End Set
    End Property
    Public Property Empresa()
        Get
            Return _Empresa
        End Get
        Set(ByVal Value)
            _Empresa = Value
        End Set
    End Property
    Public Property Usuario()
        Get
            Return _Usuario
        End Get
        Set(ByVal Value)
            _Usuario = Value
        End Set
    End Property
#End Region

    Private Sub FrmDetalleA2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid.DataSource = ObtieneDatos("select  usuario AS Usuario,Empresa,datepart(month,fecha) as Mes,op1 as NoComprobante,op2 as Cuenta,op3 as Valor,op4 as Concepto " & _
        "from auditoria where  empresa <>0  and evento='I' and op3 <> '' and usuario ='" & Usuario & "' and empresa = " & Empresa & " and datepart(month,fecha) = " & Mes & " and op1= " & Comprobante)
        GridView1.Columns("Usuario").Visible = False
        GridView1.Columns("Empresa").Visible = False
        GridView1.Columns("Mes").Visible = False
        GridView1.Columns("NoComprobante").Visible = False
        For i As Integer = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            'GridView1.Columns(i).AppearanceHeader.Font = New System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, FontStyle.Bold)
        Next
        txtusuario.Text = Usuario
        txtcomp.Text = Comprobante

        txtempresa.Text = ObtieneDatos("Select Nombre from empresas where codigo = " & Empresa).Rows(0).Item(0)
        txtmes.Text = Format(CDate("01/" & Mes & "/2007"), "MMMM")
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub
End Class
