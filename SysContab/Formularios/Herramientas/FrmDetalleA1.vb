Public Class FrmDetalleA1
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Grid.Location = New System.Drawing.Point(8, 48)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(448, 208)
        Me.Grid.TabIndex = 1
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
        Me.cmdsalir.Location = New System.Drawing.Point(384, 264)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.TabIndex = 2
        Me.cmdsalir.Text = "&Salir"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 23)
        Me.Label1.TabIndex = 3
        '
        'FrmDetalleA1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(464, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.Grid)
        Me.Name = "FrmDetalleA1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Detalle Auditoria"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private _Usuario As String
    Private _StrWhere As String


#Region "Propiedades"
    Public Property StrWhere()
        Get
            Return _StrWhere
        End Get
        Set(ByVal Value)
            _StrWhere = Value
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

    Private Sub FrmDetalleA1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ItemEmpresa As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        ItemEmpresa.DataSource = ObtieneDatos("Select codigo,nombre From empresas")
        ItemEmpresa.DisplayMember = "nombre"
        ItemEmpresa.ValueMember = "codigo"

        LlenarGrid()

        For i As Integer = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            'GridView1.Columns(i).AppearanceHeader.Font = New System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, FontStyle.Bold)
        Next
        GridView1.Columns("Empresa").ColumnEdit = ItemEmpresa
        GridView1.Columns("Nombre Usuario").Visible = False
        Label1.Text = "Documentos procesados por el usuario : " & Usuario
    End Sub

    Private Sub LlenarGrid()
        Grid.DataSource = ObtieneDatos("select  usuario AS [Nombre Usuario],Empresa,datepart(month,fecha) as Mes,op1 AS [No Comprobante],count(op1) as Registros " & _
        "from auditoria where  empresa <>0  and evento='I' and op3 <> '' " & StrWhere & " " & _
        "and usuario = '" & Usuario & "' " & _
        "group by Usuario, Empresa, DatePart(Month, fecha), op1")
    End Sub
    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.Click

    End Sub

    Private Sub Grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick
        Dim Forma As New FrmDetalleA2
        Forma.Usuario = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, "Nombre Usuario")
        Forma.Empresa = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Empresa")
        Forma.Mes = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, "Mes")
        Forma.Comprobante = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, "No Comprobante")
        Forma.ShowDialog()
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub
End Class
