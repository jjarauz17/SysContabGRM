Public Class FrmListaPlanillasContables
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmListaPlanillasContables = Nothing

    Public Shared Function Instance() As FrmListaPlanillasContables
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmListaPlanillasContables()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Windows Form Designer generated code "

    Private Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FrmListaPlanillasContablesConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents dgplanillas As DevExpress.XtraGrid.GridControl
    Friend WithEvents vLista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cmdSeleccionaritem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdSaliritem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdSeleccionar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaPlanillasContables))
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.FrmListaPlanillasContablesConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.dgplanillas = New DevExpress.XtraGrid.GridControl()
        Me.vLista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdSeleccionar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.cmdSeleccionaritem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmdSaliritem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.FrmListaPlanillasContablesConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmListaPlanillasContablesConvertedLayout.SuspendLayout()
        CType(Me.dgplanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSeleccionaritem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSaliritem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(907, 483)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(97, 38)
        Me.cmdSalir.StyleController = Me.FrmListaPlanillasContablesConvertedLayout
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "&Salir"
        '
        'FrmListaPlanillasContablesConvertedLayout
        '
        Me.FrmListaPlanillasContablesConvertedLayout.Controls.Add(Me.SimpleButton1)
        Me.FrmListaPlanillasContablesConvertedLayout.Controls.Add(Me.dgplanillas)
        Me.FrmListaPlanillasContablesConvertedLayout.Controls.Add(Me.cmdSalir)
        Me.FrmListaPlanillasContablesConvertedLayout.Controls.Add(Me.cmdSeleccionar)
        Me.FrmListaPlanillasContablesConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmListaPlanillasContablesConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.FrmListaPlanillasContablesConvertedLayout.Name = "FrmListaPlanillasContablesConvertedLayout"
        Me.FrmListaPlanillasContablesConvertedLayout.Root = Me.LayoutControlGroup1
        Me.FrmListaPlanillasContablesConvertedLayout.Size = New System.Drawing.Size(1016, 533)
        Me.FrmListaPlanillasContablesConvertedLayout.TabIndex = 142
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(808, 483)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(95, 38)
        Me.SimpleButton1.StyleController = Me.FrmListaPlanillasContablesConvertedLayout
        Me.SimpleButton1.TabIndex = 143
        Me.SimpleButton1.Text = "E&xportar"
        '
        'dgplanillas
        '
        Me.dgplanillas.Location = New System.Drawing.Point(12, 12)
        Me.dgplanillas.MainView = Me.vLista
        Me.dgplanillas.Name = "dgplanillas"
        Me.dgplanillas.Size = New System.Drawing.Size(992, 467)
        Me.dgplanillas.TabIndex = 4
        Me.dgplanillas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vLista})
        '
        'vLista
        '
        Me.vLista.GridControl = Me.dgplanillas
        Me.vLista.Name = "vLista"
        Me.vLista.OptionsBehavior.Editable = False
        Me.vLista.OptionsView.ShowAutoFilterRow = True
        Me.vLista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vLista.OptionsView.ShowGroupPanel = False
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Image = CType(resources.GetObject("cmdSeleccionar.Image"), System.Drawing.Image)
        Me.cmdSeleccionar.Location = New System.Drawing.Point(696, 483)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(108, 38)
        Me.cmdSeleccionar.StyleController = Me.FrmListaPlanillasContablesConvertedLayout
        Me.cmdSeleccionar.TabIndex = 0
        Me.cmdSeleccionar.Text = "Se&leccionar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.cmdSeleccionaritem, Me.LayoutControlItem1, Me.cmdSaliritem, Me.EmptySpaceItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1016, 533)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'cmdSeleccionaritem
        '
        Me.cmdSeleccionaritem.Control = Me.cmdSeleccionar
        Me.cmdSeleccionaritem.CustomizationFormText = "cmdSeleccionaritem"
        Me.cmdSeleccionaritem.Location = New System.Drawing.Point(684, 471)
        Me.cmdSeleccionaritem.MaxSize = New System.Drawing.Size(112, 42)
        Me.cmdSeleccionaritem.MinSize = New System.Drawing.Size(112, 42)
        Me.cmdSeleccionaritem.Name = "cmdSeleccionaritem"
        Me.cmdSeleccionaritem.Size = New System.Drawing.Size(112, 42)
        Me.cmdSeleccionaritem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.cmdSeleccionaritem.TextSize = New System.Drawing.Size(0, 0)
        Me.cmdSeleccionaritem.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgplanillas
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(996, 471)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'cmdSaliritem
        '
        Me.cmdSaliritem.Control = Me.cmdSalir
        Me.cmdSaliritem.CustomizationFormText = "cmdSaliritem"
        Me.cmdSaliritem.Location = New System.Drawing.Point(895, 471)
        Me.cmdSaliritem.MaxSize = New System.Drawing.Size(101, 42)
        Me.cmdSaliritem.MinSize = New System.Drawing.Size(101, 42)
        Me.cmdSaliritem.Name = "cmdSaliritem"
        Me.cmdSaliritem.Size = New System.Drawing.Size(101, 42)
        Me.cmdSaliritem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.cmdSaliritem.TextSize = New System.Drawing.Size(0, 0)
        Me.cmdSaliritem.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 471)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(684, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(796, 471)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FrmListaPlanillasContables
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 533)
        Me.Controls.Add(Me.FrmListaPlanillasContablesConvertedLayout)
        Me.Name = "FrmListaPlanillasContables"
        Me.Text = "Listado de Planillas a Contabilizar"
        CType(Me.FrmListaPlanillasContablesConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmListaPlanillasContablesConvertedLayout.ResumeLayout(False)
        CType(Me.dgplanillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSeleccionaritem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSaliritem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmListaPlanillasContables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        vLista.PopulateColumns()
        FormatoGrid(vLista, 2, 0, False)
    End Sub

    Sub Cargar()
        Dim Ds As New DataSet()
        Ds = VB.SysContab.PeriodoNominaDB.GetListContabilizado(False, True, True, True)
        dgplanillas.DataSource = Ds.Tables(0)       
    End Sub


    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        If vLista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        If vLista.GetFocusedRowCellValue("Contabilizado") Then
            XtraMsg("La Planilla ya se encuentra Contabilizada!", MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim F As FrmPlanillaxContabilizar = FrmPlanillaxContabilizar.Instance()

        F.MdiParent = Me.MdiParent
        F.Codigo = vLista.GetFocusedRowCellValue("Codigo")
        F.Show()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(dgplanillas, Me.Text)
    End Sub

    Private Sub vLista_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles vLista.RowCellStyle
        If e.Column.FieldName = "Contabilizado" Then
            If vLista.GetRowCellValue(e.RowHandle, "Contabilizado") Then
                e.Appearance.BackColor = Color.LightGreen
            Else
                e.Appearance.BackColor = Color.Salmon
            End If
        End If
    End Sub
End Class
