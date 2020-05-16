Public Class FrmPresupuestoRubros
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
    Friend WithEvents cmdaceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LblRubro As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdaceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LblRubro = New System.Windows.Forms.Label
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaceptar
        '
        Me.cmdaceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdaceptar.Location = New System.Drawing.Point(464, 360)
        Me.cmdaceptar.Name = "cmdaceptar"
        Me.cmdaceptar.TabIndex = 1
        Me.cmdaceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(552, 360)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'GridDetalle.EmbeddedNavigator
        '
        Me.GridDetalle.EmbeddedNavigator.Name = ""
        Me.GridDetalle.Location = New System.Drawing.Point(0, 40)
        Me.GridDetalle.MainView = Me.GridView1
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.Size = New System.Drawing.Size(632, 312)
        Me.GridDetalle.TabIndex = 2
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridDetalle
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False

        '
        'LblRubro
        '
        Me.LblRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRubro.Location = New System.Drawing.Point(16, 8)
        Me.LblRubro.Name = "LblRubro"
        Me.LblRubro.Size = New System.Drawing.Size(384, 23)
        Me.LblRubro.TabIndex = 3
        '
        'FrmPresupuestoRubros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(632, 394)
        Me.Controls.Add(Me.LblRubro)
        Me.Controls.Add(Me.GridDetalle)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdaceptar)
        Me.Name = "FrmPresupuestoRubros"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "FrmPresupuestoRubros"
        Me.WindowState = FormWindowState.Maximized
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _Presupuesto As String
    Private _Cuenta As String
    Private DT As New DataTable
    Private _Rubro As String

    Private Property Rubro() As String
        Get
            Return _Rubro
        End Get
        Set(ByVal Value As String)
            _Rubro = Value
        End Set
    End Property

    Public Property Presupuesto() As String
        Get
            Return _Presupuesto
        End Get
        Set(ByVal Value As String)
            _Presupuesto = Value
        End Set
    End Property

    Public Property Cuenta() As String
        Get
            Return _Cuenta
        End Get
        Set(ByVal Value As String)
            _Cuenta = Value
        End Set
    End Property

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub FrmPresupuestoRubros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DT = ObtieneDatos("SPPivotPresupuesto")
        DT.Columns.Add("IdRubro", System.Type.GetType("System.String"))
        DT.Clear()
        DT.AcceptChanges()
        Dim DT_Rubro As DataTable = ObtieneDatos("SPPivotRubro '" & EmpresaActual & "','" & Presupuesto & "','" & Cuenta & "'")
        Dim Fila As DataRow
        For i As Integer = 0 To DT_Rubro.Rows.Count - 1
            Fila = DT.NewRow
            Fila.Item("empr_codigo") = EmpresaActual
            Fila.Item("pre_codigo") = Presupuesto
            Fila.Item("pre_cuenta") = Cuenta
            Fila.Item("IdRubro") = DT_Rubro.Rows(i).Item("IdRubroGasto")
            For j As Integer = 4 To DT_Rubro.Columns.Count - 1
                Fila.Item(DT_Rubro.Columns(j).ColumnName) = DT_Rubro.Rows(i).Item(j)
            Next j
            DT.Rows.Add(Fila)
        Next i
        GridDetalle.DataSource = DT

        For i As Integer = 3 To GridView1.Columns.Count - 2
            GridView1.Columns(i).Caption = Format(CDate(GridView1.Columns(i).Caption), "y")
            GridView1.Columns(i).Width = 100
            GridView1.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            GridView1.Columns(i).SummaryItem.FieldName = GridView1.Columns(i).FieldName
            GridView1.Columns(i).SummaryItem.DisplayFormat = "{0:N}"
        Next
        GridView1.Columns("empr_codigo").Visible = False
        GridView1.Columns("pre_codigo").Visible = False
        GridView1.Columns("pre_cuenta").Visible = False
        'GridView1.Columns("Id_Rubro").Visible = False
        GridView1.Columns("IdRubro").Caption = "Rubro"
        GridView1.Columns("IdRubro").Width = 200
        GridView1.Columns("IdRubro").VisibleIndex = 0
        Dim DT1 As New DataTable
        DT1 = ObtieneDatos("SELECT Codigo,Nombre FROM RubrosGastos WHERE Empresa = " & EmpresaActual & " AND CuentaContable = '" & Cuenta & "'")
        If DT1.Rows.Count <= 0 Then
            MsgBox("No hay definidos rubros", MsgBoxStyle.Critical)
            Close()
            Exit Sub
        End If
        Rubro = DT1.Rows(0).Item("Codigo")
        LblRubro.Text = "Rubro : " & DT1.Rows(0).Item("Nombre")
        Dim ItemRubro As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        ItemRubro.DataSource = ObtieneDatos("SELECT Codigo,Nombre FROM RubrosGastos WHERE Empresa = " & EmpresaActual & " AND CuentaContable = '" & Cuenta & "'")
        ItemRubro.DisplayMember = "Nombre"
        ItemRubro.ValueMember = "Codigo"
        ItemRubro.ShowHeader = False
        ItemRubro.ShowFooter = False
        ItemRubro.NullText = ""
        ItemRubro.PopulateColumns()
        ItemRubro.Columns(0).Visible = False
        GridView1.Columns("IdRubro").ColumnEdit = ItemRubro
        GridView1.Columns("IdRubro").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    End Sub

    Private Sub GridView1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Me.GridView1.SetRowCellValue(e.RowHandle, "empr_codigo", EmpresaActual)
        Me.GridView1.SetRowCellValue(e.RowHandle, "pre_codigo", Presupuesto)
        Me.GridView1.SetRowCellValue(e.RowHandle, "pre_cuenta", Cuenta)
        Me.GridView1.SetRowCellValue(e.RowHandle, "IdRubro", Rubro)
        For i As Integer = 3 To GridView1.Columns.Count - 2
            Me.GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns(i), 0)
        Next
    End Sub

    Private Sub GridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        Dim Fila As DataRow = GridView1.GetDataRow(e.RowHandle)
        If IsDBNull(Fila.Item("IdRubro")) Or Fila.Item("IdRubro") = vbNullString Or Fila.Item("IdRubro") = 0 Then
            e.ErrorText = "No se ha ingresado el Rubro, complete la informacion" & vbCrLf
            e.Valid = False
        End If
    End Sub

    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            GridView1.DeleteSelectedRows()
        End If
    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaceptar.Click
        DT.AcceptChanges()
        GuardaDatos("DELETE FROM PresupuestoDetallePorRubro WHERE empresa = " & EmpresaActual & " AND idpresupuesto = '" & Presupuesto & "' AND cuenta='" & Cuenta & "'")
        For i As Integer = 0 To DT.Rows.Count - 1
            If IsDBNull(DT.Rows(i).Item("IdRubro")) Then Exit For
            For j As Integer = 3 To DT.Columns.Count - 2
                If IsDBNull(DT.Rows(i).Item(DT.Columns(j).ColumnName)) = False Then If DT.Rows(i).Item(DT.Columns(j).ColumnName) > 0 Then GuardaDatos("SPGuardaRubroPresupuesto " & EmpresaActual & ",'" & Presupuesto & "','" & Cuenta & "','" & Format(CDate(DT.Columns(j).ColumnName), "yyyyMM") & "'," & DT.Rows(i).Item(DT.Columns(j).ColumnName) & "," & DT.Rows(i).Item("IdRubro"))
            Next j
        Next i
        GuardaDatos("SPActualizaPresupuestoDetalle")
        Close()
    End Sub

End Class
