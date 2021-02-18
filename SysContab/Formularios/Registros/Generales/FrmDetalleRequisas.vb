Imports Entities
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
    Friend WithEvents cmdcancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents rMonto As RepositoryItemTextEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lblTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetalleRequisas))
        Me.cmdaceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdcancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lblTotal = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaceptar
        '
        Me.cmdaceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdaceptar.ImageOptions.SvgImage = CType(resources.GetObject("cmdaceptar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdaceptar.Location = New System.Drawing.Point(563, 390)
        Me.cmdaceptar.Name = "cmdaceptar"
        Me.cmdaceptar.Size = New System.Drawing.Size(106, 36)
        Me.cmdaceptar.StyleController = Me.LayoutControl1
        Me.cmdaceptar.TabIndex = 3
        Me.cmdaceptar.Text = "&Aceptar"
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdcancelar.ImageOptions.SvgImage = CType(resources.GetObject("cmdcancelar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdcancelar.Location = New System.Drawing.Point(453, 390)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(106, 36)
        Me.cmdcancelar.StyleController = Me.LayoutControl1
        Me.cmdcancelar.TabIndex = 2
        Me.cmdcancelar.Text = "&Cancelar"
        Me.cmdcancelar.Visible = False
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(12, 12)
        Me.GridDetalle.MainView = Me.GridView1
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rMonto})
        Me.GridDetalle.Size = New System.Drawing.Size(657, 354)
        Me.GridDetalle.TabIndex = 0
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
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
        'rMonto
        '
        Me.rMonto.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rMonto.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMonto.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rMonto.Appearance.Options.UseBackColor = True
        Me.rMonto.Appearance.Options.UseFont = True
        Me.rMonto.Appearance.Options.UseForeColor = True
        Me.rMonto.Appearance.Options.UseTextOptions = True
        Me.rMonto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rMonto.AutoHeight = False
        Me.rMonto.Mask.EditMask = "n4"
        Me.rMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rMonto.Name = "rMonto"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.lblTotal)
        Me.LayoutControl1.Controls.Add(Me.cmdaceptar)
        Me.LayoutControl1.Controls.Add(Me.cmdcancelar)
        Me.LayoutControl1.Controls.Add(Me.GridDetalle)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(729, 190, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(681, 438)
        Me.LayoutControl1.TabIndex = 6
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem5})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(681, 438)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridDetalle
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(661, 358)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdcancelar
        Me.LayoutControlItem3.Location = New System.Drawing.Point(441, 378)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(110, 40)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(110, 40)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(110, 40)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        Me.LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdaceptar
        Me.LayoutControlItem4.Location = New System.Drawing.Point(551, 378)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(110, 40)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(110, 40)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(110, 40)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 378)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(441, 40)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lblTotal
        '
        Me.lblTotal.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotal.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Appearance.Options.UseBackColor = True
        Me.lblTotal.Appearance.Options.UseFont = True
        Me.lblTotal.Appearance.Options.UseForeColor = True
        Me.lblTotal.Location = New System.Drawing.Point(12, 370)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(657, 16)
        Me.lblTotal.StyleController = Me.LayoutControl1
        Me.lblTotal.TabIndex = 8
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.lblTotal
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 358)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(661, 20)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'FrmDetalleRequisas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(681, 438)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.SvgImage = CType(resources.GetObject("FrmDetalleRequisas.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDetalleRequisas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Distribucion"
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
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

            GridView1.Columns("Valor").ColumnEdit = rMonto
            GridView1.Columns("Valor").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns("Valor").DisplayFormat.FormatString = "n4"

            'Dim Rubros As New RepositoryItemLookUpEdit
            'Dim DT1 As New DataTable
            'DT1 = ObtieneDatos("SELECT Codigo,Nombre FROM RubrosGastos WHERE CuentaContable = '" & Cuenta & "' AND Empresa = " & EmpresaActual)            

            Dim _dt As DataTable =
                ObtieneDatos("sp_sel_RubroGastos", Cuenta, EmpresaActual)

            If _dt.Rows.Count = 0 Then
                XtraMsg($"La cuenta {Cuenta} no se encuentra en Rubros de Distribución",
                        MessageBoxIcon.Error)
                Close()
                Exit Sub
            End If

            Rubro = _dt.Rows(0).Item("Codigo")
            'lblrubro.Text = "Rubro : " & _dt.Rows(0).Item("Nombre")
            FormatoGridNew(GridView1, 4, 0, False, True, False, True, $"Rubro : {_dt.Rows(0).Item("Nombre")}")

            .Columns("IdEmpresa").Visible = False
            .Columns("NoComp").Visible = False
            .Columns("Mes").Visible = False
            .Columns("Per_Id").Visible = False
            .Columns("IdRubroGasto").Visible = False

            Try
                .Columns("Rubro").Visible = False
                .Columns("Centro").Visible = False
            Catch ex As Exception
            End Try

            GridView1.Columns("IdDetalle").Visible = False
            GridView1.Columns("IdSubCentro").Visible = False

            Dim cbCentros As New RepositoryItemLookUpEdit
            cbCentros.ShowFooter = False

            RepositoryItemLookUpEdit(
                cbCentros,
                ObtieneDatos("sp_sel_CentroDeCosto", 0, 0, EmpresaActual),
                "Nombre",
                "Codigo",
                0, 2)

            'Dim DT2 As DataTable = ObtieneDatos("SELECT Codigo,Nombre FROM CentroDeCosto WHERE Activo = 1 AND Empresa = " & EmpresaActual)
            'Centros.DataSource = DT2
            'Centros.DisplayMember = "Nombre"
            'Centros.ValueMember = "Codigo"
            'Centros.ShowFooter = False
            'Centros.ShowHeader = False
            ''Centros.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
            'Centros.PopulateColumns()
            'Centros.Columns(0).Visible = False
            'Centros.NullText = ""

            .Columns("IdCentroCosto").ColumnEdit = cbCentros
            .Columns("IdCentroCosto").Caption = "Centro de Costo"
            .Columns("IdCentroCosto").Width = 280

            .Columns("Valor").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            .Columns("Valor").SummaryItem.FieldName = "Valor"
            .Columns("Valor").SummaryItem.DisplayFormat = "Total Procesado : {0:#,0.00}"
            .Columns("Valor").AppearanceCell.BackColor = Color.FromArgb(192, 255, 192)
            .Columns("Valor").AppearanceCell.Font = New Font("Tahoma", 9.75, FontStyle.Bold)
            .Columns("Valor").AppearanceCell.ForeColor = Color.FromArgb(192, 0, 0)

            .Columns("Tipo").Visible = False
            .Columns("Cuenta").Visible = False
        End With
        lblTotal.Text = "Total : " & Format(Monto, "#,#0.00")
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
