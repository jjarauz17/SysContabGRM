
Public Class frmOrdenes
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 498)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(952, 51)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(859, 511)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(113, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.GridDetalle)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(789, 363, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(984, 561)
        Me.LayoutControl1.TabIndex = 21
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(12, 12)
        Me.GridDetalle.MainView = Me.GridView1
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.Size = New System.Drawing.Size(960, 495)
        Me.GridDetalle.TabIndex = 20
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(741, 511)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(114, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(984, 561)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridDetalle
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(964, 499)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdAceptar
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(729, 499)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdSalir
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(847, 499)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 499)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(729, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmOrdenes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmOrdenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas()
    'Dim FacturaTemporal As New VB.SysContab.Facturas_Ventas_TemporalDB()
    Dim Ordenes As New VB.SysContab.OrdenesDB
    Public Cliente As Integer
    Dim DT As New DataTable("OT")
    Public Ok As String = "NO", IdOrden As String, Comentario As String, Documento As String, Bodega As String = "0"

    Private Sub frmOrdenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Me.Text = "Ordenes de Clientes"
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'Dim Tabla As DataTable
        'Dim ds As DataSet

        DT = ObtieneDatos("SP_OrdenesList",
                          EmpresaActual,
                          Cliente)

        GridDetalle.DataSource = DT
        GridView1.PopulateColumns()
        FormatoGrid(GridView1, 2, 0, False)

        GridView1.OptionsBehavior.Editable = True

        For i As Integer = 1 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
            GridView1.Columns(i).OptionsColumn.AllowFocus = False
        Next

        GridView1.Columns("Cliente").Width = 170
        GridView1.Columns("Seleccionar").OptionsColumn.AllowEdit = True
        GridView1.Columns("Seleccionar").OptionsColumn.AllowFocus = True

        Try
            GridView1.Columns("IdOrden").Visible = False
            GridView1.Columns("CODIGO_BODEGA").Visible = False
            GridView1.Columns("Trabajo_Realizado").Visible = False
        Catch ex As Exception
        End Try
        '
        Try
            'GridView1.Columns("Pv_Codigo").Visible = False
            'GridView1.Columns("Numero").Visible = False
        Catch ex As Exception
        End Try



        'Me.GridView1.Columns("Sub Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.GridView1.Columns("Sub Total").DisplayFormat.FormatString = "{0:n2}"
        'Me.GridView1.Columns("Sub Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.GridView1.Columns("Sub Total").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.GridView1.Columns("IVA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.GridView1.Columns("IVA").DisplayFormat.FormatString = "{0:n2}"
        'Me.GridView1.Columns("IVA").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.GridView1.Columns("IVA").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.GridView1.Columns("Descuento").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.GridView1.Columns("Descuento").DisplayFormat.FormatString = "{0:n2}"
        'Me.GridView1.Columns("Descuento").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.GridView1.Columns("Descuento").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.GridView1.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.GridView1.Columns("Total").DisplayFormat.FormatString = "{0:n2}"
        'Me.GridView1.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.GridView1.Columns("Total").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Ok = "NO"
        LoadOrden = False
        Close()
        'If LoadOrden = True Then
        '    Exit Sub
        'Else
        '    LoadOrden = False
        'End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        'If GridView1.FocusedRowHandle < 0 Then
        '    XtraMsg("Seleccione un Registro")
        '    Exit Sub
        'End If

        'Dim Temp As Boolean = False
        'RegistroOrden = vbNullString

        'For i As Integer = 0 To GridView1.DataRowCount - 1
        '    'If GridView1.GetRowCellValue(i, "Facturar") = True Then
        '    'RegistroOrden += IIf(RegistroOrden = vbNullString, "", ",") & GridView1.GetRowCellValue(i, "No. Orden")
        '    RegistroOrden = GridView1.GetRowCellValue(i, "No. Orden")
        '    Temp = True
        '    'End If
        'Next
        ' Dim DT_SELECT = DT.Select("Seleccionar = 1").CopyToDataTable

        Dim dr() As DataRow = DT.Select("Seleccionar = 1")

        If dr.Length = 0 Then
            XtraMsg("Debe seleccionar al menos 1 Orden de Trabajo", MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim DT_SELECT = DT.Select("Seleccionar = 1").CopyToDataTable

        IdOrden = "" : Comentario = "" : Documento = ""

        For i As Integer = 0 To DT_SELECT.Rows.Count - 1
            IdOrden = DT_SELECT.Rows.Item(i)("IdOrden").ToString() + ", " + IdOrden
            Comentario = DT_SELECT.Rows.Item(i)("Trabajo_Realizado").ToString() + ", " + Comentario
            Documento = DT_SELECT.Rows.Item(i)("Documento").ToString() + ", " + Documento
            Bodega = DT_SELECT.Rows.Item(i)("CODIGO_BODEGA").ToString()
        Next

        IdOrden = Mid(IdOrden, 1, IdOrden.Length - 2)
        Comentario = Mid(Comentario, 1, Comentario.Length - 2)
        Documento = Mid(Documento, 1, Documento.Length - 2)

        RegistroOrden = IdOrden 'GridView1.GetFocusedRowCellValue("No. Orden")
        LoadOrden = True
        Ok = "OK"
        Close()

        'If Temp Then
        '    LoadOrden = True
        '    Me.Close()
        'End If
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        cmdAceptar_Click(Nothing, Nothing)
    End Sub
End Class
