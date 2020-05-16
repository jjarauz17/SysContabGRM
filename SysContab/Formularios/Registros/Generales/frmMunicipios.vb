Public Class frmMunicipios
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Windows Form Designer generated code "

    Public Sub New()
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
    Friend WithEvents Vista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Departamento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbDepartamentos As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Municipio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Impuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMunicipios As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMunicipios))
        Me.gcMunicipios = New DevExpress.XtraGrid.GridControl()
        Me.Vista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Departamento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbDepartamentos = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Municipio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Impuesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.gcMunicipios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'gcMunicipios
        '
        Me.gcMunicipios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcMunicipios.Location = New System.Drawing.Point(12, 12)
        Me.gcMunicipios.MainView = Me.Vista
        Me.gcMunicipios.Name = "gcMunicipios"
        Me.gcMunicipios.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbDepartamentos})
        Me.gcMunicipios.Size = New System.Drawing.Size(325, 254)
        Me.gcMunicipios.TabIndex = 0
        Me.gcMunicipios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vista})
        '
        'Vista
        '
        Me.Vista.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Departamento, Me.Municipio, Me.Nombre, Me.Impuesto})
        Me.Vista.GridControl = Me.gcMunicipios
        Me.Vista.GroupCount = 1
        Me.Vista.Name = "Vista"
        Me.Vista.OptionsView.ShowFooter = True
        Me.Vista.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.Departamento, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'Departamento
        '
        Me.Departamento.Caption = "Departamento"
        Me.Departamento.ColumnEdit = Me.cbDepartamentos
        Me.Departamento.FieldName = "Departamento"
        Me.Departamento.Name = "Departamento"
        Me.Departamento.OptionsColumn.AllowEdit = False
        Me.Departamento.Visible = True
        Me.Departamento.VisibleIndex = 0
        '
        'cbDepartamentos
        '
        Me.cbDepartamentos.AutoHeight = False
        Me.cbDepartamentos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDepartamentos.Name = "cbDepartamentos"
        '
        'Municipio
        '
        Me.Municipio.Caption = "Municipio"
        Me.Municipio.FieldName = "Municipio"
        Me.Municipio.Name = "Municipio"
        Me.Municipio.OptionsColumn.AllowEdit = False
        Me.Municipio.Visible = True
        Me.Municipio.VisibleIndex = 1
        '
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 2
        '
        'Impuesto
        '
        Me.Impuesto.Caption = "Impuesto"
        Me.Impuesto.FieldName = "Impuesto"
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.Visible = True
        Me.Impuesto.VisibleIndex = 3
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(108, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl2
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "Actualizar"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl2.Controls.Add(Me.btnExportar)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(540, 535, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(132, 251)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 201)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(108, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 2
        Me.cmdSalir.Text = "Salir"
        '
        'btnExportar
        '
        Me.btnExportar.Enabled = False
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(12, 159)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(108, 38)
        Me.btnExportar.StyleController = Me.LayoutControl2
        Me.btnExportar.TabIndex = 2
        Me.btnExportar.Text = "&Exportar"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(132, 251)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdAceptar
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnExportar
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 147)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdSalir
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 189)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 42)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(112, 105)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.gcMunicipios)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(349, 278)
        Me.LayoutControl1.TabIndex = 4
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(349, 278)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gcMunicipios
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(329, 258)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("a374e0b5-6fed-434e-a030-7fcc174df1c6")
        Me.DockPanel1.Location = New System.Drawing.Point(349, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 278)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(132, 251)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmMunicipios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(489, 278)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmMunicipios"
        Me.Text = "División Pólitica"
        CType(Me.gcMunicipios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Iniciado As Boolean
    Private Shared ChildInstance As frmMunicipios = Nothing

    Public Shared Function Instance() As frmMunicipios
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmMunicipios
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
    Private Sub frmMunicipios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl2)
        ''

        Cargar()

        Vista.PopulateColumns()
        FormatoGrid(Vista)
        '
        Vista.Columns("Departamento").Group()
        Vista.ExpandAllGroups()

        Vista.Columns("ID_Depa").Visible = False
        Vista.Columns("Municipio").Visible = False
        Vista.Columns("Nombre").Caption = "Municipio"
        'Me.gcMunicipios.DataSource = ObtieneDatos("select Codigo_Departamento as Departamento, Codigo_Municipio as Municipio, Nombre_Municipio as Nombre , Impuesto_SVEntas as Impuesto from Municipios ")
        ''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        Iniciado = True
    End Sub

    Sub Cargar()
        'Me.cbDepartamentos.DataSource = ObtieneDatos("select Codigo_Departamento as Departamento, Nombre_Departamento as Nombre from Departamentosc where empresa = " & EmpresaActual)
        'Me.cbDepartamentos.DisplayMember = "Nombre"
        'Me.cbDepartamentos.ValueMember = "Departamento"

        Me.gcMunicipios.DataSource = ObtieneDatos("sp_GetMunicipiosList " & EmpresaActual)
        Vista.ExpandAllGroups()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim i As Integer

        ShowSplash("Actualizando...")
        '
        For i = 0 To Me.Vista.DataRowCount - 1

            GuardaDatos("UPDATE Municipios SET Nombre_Municipio= '" & Me.Vista.GetRow(i).row("Nombre") & "' , " & _
                "Impuesto_SVentas = " & Me.Vista.GetRow(i).row("Impuesto").ToString & " Where Codigo_Departamento = " & _
                Me.Vista.GetRow(i).row("ID_Depa") & " and Codigo_Municipio = " & Me.Vista.GetRow(i).row("Municipio") & " and Empresa = " & EmpresaActual)
        Next
        HideSplash()

        XtraMsg("Datos Actualizados con éxito!")
        Cargar()
    End Sub

    Private Sub Vista_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles Vista.CellValueChanged
        If Iniciado Then
            If e.Column.Name = "Nombre" Then
                If e.Value = "" Then
                    XtraMsg("No se debe dejar en blanco el nombre del municipio", MessageBoxIcon.Error)
                    sender.SetFocusedRowCellValue(sender.Columns("Nombre"), sender.Columns("Nombre"))
                Else
                    Exit Sub
                End If

            ElseIf e.Column.Name = "Impuesto" Then
                If e.Value < 0 Or e.Value > 100 Then
                    XtraMsg("Valor incorrecto para el porcentaje del Impuesto Sobre Ventas", MessageBoxIcon.Error)
                    sender.SetFocusedRowCellValue(sender.Columns("Impuesto"), 0)
                End If
            End If
        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.gcMunicipios, Me.Text)
    End Sub
End Class
