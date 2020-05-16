Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors.Repository

Public Class FrmDetalleRequisas
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdcancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblrubro As System.Windows.Forms.Label
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdaceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdcancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.lblrubro = New System.Windows.Forms.Label()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaceptar
        '
        Me.cmdaceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdaceptar.Location = New System.Drawing.Point(433, 296)
        Me.cmdaceptar.Name = "cmdaceptar"
        Me.cmdaceptar.Size = New System.Drawing.Size(75, 25)
        Me.cmdaceptar.TabIndex = 1
        Me.cmdaceptar.Text = "&Aceptar"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 25)
        Me.Label1.TabIndex = 3
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdcancelar.Location = New System.Drawing.Point(352, 296)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(75, 25)
        Me.cmdcancelar.TabIndex = 1
        Me.cmdcancelar.Text = "&Cancelar"
        Me.cmdcancelar.Visible = False
        '
        'lblrubro
        '
        Me.lblrubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrubro.Location = New System.Drawing.Point(16, 9)
        Me.lblrubro.Name = "lblrubro"
        Me.lblrubro.Size = New System.Drawing.Size(376, 24)
        Me.lblrubro.TabIndex = 4
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(0, 48)
        Me.GridDetalle.MainView = Me.GridView1
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.Size = New System.Drawing.Size(520, 242)
        Me.GridDetalle.TabIndex = 5
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'FrmDetalleRequisas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(520, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.GridDetalle)
        Me.Controls.Add(Me.lblrubro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdaceptar)
        Me.Controls.Add(Me.cmdcancelar)
        Me.Name = "FrmDetalleRequisas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Distribucion"
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private DT As DataTable
    Private _Monto As Double
    Private Vista As New Views.Grid.GridView
    Private _Cuenta As String
    Private _Tipo As String
    Private _CompNo As String
    Private _Periodo As String
    Private _Rubro As String
    Private _Mes As Integer

    Public Property Mes() As Integer
        Get
            Return _Mes
        End Get
        Set(ByVal Value As Integer)
            _Mes = Value
        End Set
    End Property

    Private Property Rubro() As String
        Get
            Return _Rubro
        End Get
        Set(ByVal Value As String)
            _Rubro = Value
        End Set
    End Property

    Public Property Periodo() As String
        Get
            Return _Periodo
        End Get
        Set(ByVal Value As String)
            _Periodo = Value
        End Set
    End Property

    Public Property CompNo() As String
        Get
            Return _CompNo
        End Get
        Set(ByVal Value As String)
            _CompNo = Value
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

    Public Property Monto() As Double
        Get
            Return _Monto
        End Get
        Set(ByVal Value As Double)
            _Monto = Value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal Value As String)
            _Tipo = Value
        End Set
    End Property

    Private Sub FrmDetalleRequisas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Vista = GridDetalle.MainView
        With Vista

            DT.DefaultView.RowFilter = "Cuenta = '" & Cuenta & "' AND NoComp = " & CompNo & " AND Per_Id = " & Periodo & " AND IdEmpresa = " & EmpresaActual & " AND Mes = " & Mes & " AND Tipo = '" & Tipo & "'"
            GridDetalle.DataSource = DT
            GridView1.PopulateColumns()
            GridView1.Columns("Valor").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns("Valor").DisplayFormat.FormatString = "n2"
            'Dim Rubros As New RepositoryItemLookUpEdit
            Dim DT1 As New DataTable
            DT1 = ObtieneDatos("SELECT Codigo,Nombre FROM RubrosGastos WHERE CuentaContable = '" & Cuenta & "' AND Empresa = " & EmpresaActual)

            If DT1.Rows.Count <= 0 Then
                XtraMsg("No hay definidos rubros", MessageBoxIcon.Error)
                Close()
                Exit Sub
            End If

            Rubro = DT1.Rows(0).Item("Codigo")
            lblrubro.Text = "Rubro : " & DT1.Rows(0).Item("Nombre")

            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            Try
                .Columns("Rubro").Visible = False
                .Columns("Centro").Visible = False
            Catch ex As Exception
            End Try

            GridView1.Columns("IdDetalle").Visible = False
            GridView1.Columns("IdSubCentro").Visible = False

            Dim Centros As New RepositoryItemLookUpEdit
            Dim DT2 As New DataTable
            DT2 = ObtieneDatos("SELECT Codigo,Nombre FROM CentroDeCosto WHERE Activo = 1 AND Empresa = " & EmpresaActual)
            Centros.DataSource = DT2
            Centros.DisplayMember = "Nombre"
            Centros.ValueMember = "Codigo"
            Centros.ShowFooter = False
            Centros.ShowHeader = False
            'Centros.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
            Centros.PopulateColumns()
            Centros.Columns(0).Visible = False
            Centros.NullText = ""
            .Columns(5).ColumnEdit = Centros
            .Columns(5).Caption = "Centro de Costo"
            .Columns(6).DisplayFormat.FormatString = "{0:#,0.00}"
            .Columns(6).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns(6).SummaryItem.FieldName = "Valor"
            .Columns(6).SummaryItem.DisplayFormat = "Total Procesado : {0:#,0.00}"
            .Columns(7).Visible = False
            .Columns(8).Visible = False
        End With
        Label1.Text = "Total : " & Format(Monto, "#,#0.00")
    End Sub

    Public Sub Mostrar(ByRef DS As DataTable)
        DT = DS
        Me.ShowDialog()
    End Sub

    Private Sub GridDetalle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridDetalle.KeyDown
        If e.KeyCode = Keys.Delete Then
            'If Not IsDBNull(GridView1.GetFocusedRowCellValue("IdDetalle")) Then
            '    GuardaDatos("DELETE FROM Distribucion WHERE IdDetalle = " & GridView1.GetFocusedRowCellValue("IdDetalle"))
            'End If
            Vista.DeleteSelectedRows()
        End If
    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaceptar.Click
        Dim Sum As Double

        For i As Integer = 0 To GridView1.DataRowCount - 1
            Sum += GridView1.GetRowCellValue(i, "Valor")
        Next

        'If CDbl(Format(Sum, "###,##0.00")) <> CDbl(Format(Monto, "###,##0.00")) And (GridView1.DataRowCount - 1) >= 0 Then
        '    MsgBox("El total no corresponde al monto seleccionado", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        'DT.AcceptChanges()
        Close()
    End Sub

    Private Sub GridView1_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Me.GridView1.SetRowCellValue(e.RowHandle, "IdEmpresa", EmpresaActual)
        Me.GridView1.SetRowCellValue(e.RowHandle, "NoComp", CompNo)
        Me.GridView1.SetRowCellValue(e.RowHandle, "Per_Id", Periodo)
        Me.GridView1.SetRowCellValue(e.RowHandle, "Cuenta", Cuenta)
        Me.GridView1.SetRowCellValue(e.RowHandle, "Tipo", Tipo)
        Me.GridView1.SetRowCellValue(e.RowHandle, "IdRubroGasto", Rubro)
        Me.GridView1.SetRowCellValue(e.RowHandle, "Mes", Mes)
    End Sub

    Private Sub GridView1_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        Dim Fila As DataRow = GridView1.GetDataRow(e.RowHandle)
        If IsDBNull(Fila.Item("IdRubroGasto")) Or IsDBNull(Fila.Item("IdCentroCosto")) Or IsDBNull(Fila.Item("Valor")) Then
            e.ErrorText = "Complete la informacion" & vbCrLf
            e.Valid = False
        End If
    End Sub

    Private Sub cmdcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancelar.Click
        'DT.RejectChanges()
        'DT.AcceptChanges()
        Me.Close()
    End Sub
End Class
