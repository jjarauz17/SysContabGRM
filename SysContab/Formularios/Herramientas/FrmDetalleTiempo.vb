Public Class FrmDetalleTiempo
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Location = New System.Drawing.Point(8, 9)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(480, 243)
        Me.Grid.TabIndex = 0
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
        Me.cmdsalir.Location = New System.Drawing.Point(408, 293)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(75, 25)
        Me.cmdsalir.TabIndex = 1
        Me.cmdsalir.Text = "&Salir"
        '
        'FrmDetalleTiempo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(496, 314)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.Grid)
        Me.Name = "FrmDetalleTiempo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Auditoria"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _StrWhere As String = ""

    Public Property StrWhere()
        Get
            Return _StrWhere
        End Get
        Set(ByVal Value)
            _StrWhere = Value
        End Set
    End Property

    Private Sub FrmDetalleTiempo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarGrid()
        For i As Integer = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Next
    End Sub

    Private Sub LlenarGrid()
        Grid.DataSource = ObtieneDatos("SELECT Usuario,COUNT(Empresa) AS [Documentos Realizados] " & _
        "FROM " & _
        "(select  usuario,Empresa,datepart(month,fecha) as mes,op1,count(op1) as filas " & _
        "from auditoria where  empresa <>0  and evento='I' and op3 <> '' " & StrWhere & " " & _
        "group by Usuario, Empresa, DatePart(Month, fecha), op1) DT GROUP BY usuario")
    End Sub
    Private Sub Grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick
        Dim Forma As New FrmDetalleA1
        Forma.Usuario = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, "Usuario")
        Forma.StrWhere = StrWhere
        Forma.ShowDialog()
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Public Sub Mostrar()
        Me.ShowDialog()
    End Sub

    Private Sub cmdsalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub
End Class
