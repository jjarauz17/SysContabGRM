Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Localization

Public Class frmActivos
    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As frmActivos = Nothing

    Public Shared Function Instance() As frmActivos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmActivos()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region "Variables"
    Dim Iniciado As Boolean = False
    Dim Filtro As New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[Estado] not like '%Baja%' and [Estado] not like '%Vendido%'")
    Dim Mes1 As String
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Dim Mes2 As String
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Private Sub New()
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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAsignarActivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDepreciacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUMCD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dgActivos_Fijos As DevExpress.XtraGrid.GridControl
    Friend WithEvents VActivos As DevExpress.XtraGrid.Views.Grid.GridView
    'Friend WithEvents cbCuentaGastos As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    'Friend WithEvents cbCuentaDepreciacion As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbMes As DevExpress.XtraEditors.LookUpEdit
    'Friend WithEvents cbCuentaActivo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents chkFiltro As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbMes2 As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivos))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.chkFiltro = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.txtUMCD = New DevExpress.XtraEditors.TextEdit()
        Me.cbMes2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdDepreciacion = New DevExpress.XtraEditors.SimpleButton()
        Me.cbMes = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdAsignarActivo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgActivos_Fijos = New DevExpress.XtraGrid.GridControl()
        Me.VActivos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkFiltro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUMCD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMes2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgActivos_Fijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.SimpleButton1.Location = New System.Drawing.Point(602, 303)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(110, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 23
        Me.SimpleButton1.Text = "E&xportar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.chkFiltro)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.txtUMCD)
        Me.LayoutControl1.Controls.Add(Me.cbMes2)
        Me.LayoutControl1.Controls.Add(Me.cmdDepreciacion)
        Me.LayoutControl1.Controls.Add(Me.cbMes)
        Me.LayoutControl1.Controls.Add(Me.cmdAsignarActivo)
        Me.LayoutControl1.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl1.Controls.Add(Me.dgActivos_Fijos)
        Me.LayoutControl1.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl1.Controls.Add(Me.cmdModificar)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1151, 247, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(834, 353)
        Me.LayoutControl1.TabIndex = 23
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdSalir.Location = New System.Drawing.Point(716, 303)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(106, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'chkFiltro
        '
        Me.chkFiltro.Location = New System.Drawing.Point(12, 36)
        Me.chkFiltro.Name = "chkFiltro"
        Me.chkFiltro.Properties.Caption = "Mostrar Todos los AF"
        Me.chkFiltro.Size = New System.Drawing.Size(214, 19)
        Me.chkFiltro.StyleController = Me.LayoutControl1
        Me.chkFiltro.TabIndex = 20
        Me.chkFiltro.ToolTip = "Mostrar activos vendidos o dados de baja."
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 12)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Mostrar Datos"
        Me.CheckEdit1.Size = New System.Drawing.Size(214, 19)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 16
        '
        'txtUMCD
        '
        Me.txtUMCD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUMCD.EditValue = ""
        Me.txtUMCD.Location = New System.Drawing.Point(675, 12)
        Me.txtUMCD.Name = "txtUMCD"
        Me.txtUMCD.Size = New System.Drawing.Size(147, 20)
        Me.txtUMCD.StyleController = Me.LayoutControl1
        Me.txtUMCD.TabIndex = 15
        '
        'cbMes2
        '
        Me.cbMes2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMes2.Location = New System.Drawing.Point(389, 36)
        Me.cbMes2.Name = "cbMes2"
        Me.cbMes2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMes2.Properties.NullText = ""
        Me.cbMes2.Size = New System.Drawing.Size(123, 20)
        Me.cbMes2.StyleController = Me.LayoutControl1
        Me.cbMes2.TabIndex = 21
        '
        'cmdDepreciacion
        '
        Me.cmdDepreciacion.Appearance.Options.UseTextOptions = True
        Me.cmdDepreciacion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdDepreciacion.ImageOptions.Image = CType(resources.GetObject("cmdDepreciacion.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdDepreciacion.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdDepreciacion.Location = New System.Drawing.Point(437, 303)
        Me.cmdDepreciacion.Name = "cmdDepreciacion"
        Me.cmdDepreciacion.Size = New System.Drawing.Size(106, 38)
        Me.cmdDepreciacion.StyleController = Me.LayoutControl1
        Me.cmdDepreciacion.TabIndex = 8
        Me.cmdDepreciacion.Text = "&Calcular Depreciación"
        '
        'cbMes
        '
        Me.cbMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMes.Location = New System.Drawing.Point(389, 12)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMes.Properties.NullText = ""
        Me.cbMes.Size = New System.Drawing.Size(123, 20)
        Me.cbMes.StyleController = Me.LayoutControl1
        Me.cbMes.TabIndex = 18
        '
        'cmdAsignarActivo
        '
        Me.cmdAsignarActivo.Appearance.Options.UseTextOptions = True
        Me.cmdAsignarActivo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAsignarActivo.ImageOptions.Image = CType(resources.GetObject("cmdAsignarActivo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAsignarActivo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdAsignarActivo.Location = New System.Drawing.Point(327, 303)
        Me.cmdAsignarActivo.Name = "cmdAsignarActivo"
        Me.cmdAsignarActivo.Size = New System.Drawing.Size(106, 38)
        Me.cmdAsignarActivo.StyleController = Me.LayoutControl1
        Me.cmdAsignarActivo.TabIndex = 7
        Me.cmdAsignarActivo.Text = "&Asignar Activos"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.ImageOptions.Image = CType(resources.GetObject("cmdBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBorrar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdBorrar.Location = New System.Drawing.Point(222, 303)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(101, 38)
        Me.cmdBorrar.StyleController = Me.LayoutControl1
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'dgActivos_Fijos
        '
        Me.dgActivos_Fijos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgActivos_Fijos.Location = New System.Drawing.Point(12, 60)
        Me.dgActivos_Fijos.MainView = Me.VActivos
        Me.dgActivos_Fijos.Name = "dgActivos_Fijos"
        Me.dgActivos_Fijos.Size = New System.Drawing.Size(810, 239)
        Me.dgActivos_Fijos.TabIndex = 17
        Me.dgActivos_Fijos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VActivos})
        '
        'VActivos
        '
        Me.VActivos.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VActivos.Appearance.FooterPanel.Options.UseFont = True
        Me.VActivos.Appearance.GroupFooter.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.VActivos.Appearance.GroupFooter.Options.UseFont = True
        Me.VActivos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.VActivos.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.VActivos.ColumnPanelRowHeight = 40
        Me.VActivos.GridControl = Me.dgActivos_Fijos
        Me.VActivos.Name = "VActivos"
        Me.VActivos.OptionsBehavior.Editable = False
        Me.VActivos.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.VActivos.OptionsView.ShowAutoFilterRow = True
        Me.VActivos.OptionsView.ShowChildrenInGroupPanel = True
        Me.VActivos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VActivos.OptionsView.ShowFooter = True
        Me.VActivos.OptionsView.ShowGroupPanel = False
        '
        'cmdNuevo
        '
        Me.cmdNuevo.ImageOptions.Image = CType(resources.GetObject("cmdNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNuevo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 303)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(101, 38)
        Me.cmdNuevo.StyleController = Me.LayoutControl1
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'cmdModificar
        '
        Me.cmdModificar.ImageOptions.Image = CType(resources.GetObject("cmdModificar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdModificar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdModificar.Location = New System.Drawing.Point(117, 303)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(101, 38)
        Me.cmdModificar.StyleController = Me.LayoutControl1
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem11, Me.LayoutControlItem10, Me.EmptySpaceItem2, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(834, 353)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgActivos_Fijos
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(814, 243)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdNuevo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 291)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdModificar
        Me.LayoutControlItem3.Location = New System.Drawing.Point(105, 291)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdBorrar
        Me.LayoutControlItem4.Location = New System.Drawing.Point(210, 291)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdAsignarActivo
        Me.LayoutControlItem5.Location = New System.Drawing.Point(315, 291)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdDepreciacion
        Me.LayoutControlItem6.Location = New System.Drawing.Point(425, 291)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(590, 291)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(114, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(114, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(114, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdSalir
        Me.LayoutControlItem8.Location = New System.Drawing.Point(704, 291)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbMes
        Me.LayoutControlItem9.Location = New System.Drawing.Point(218, 0)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Ver Depreciado Desde:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(156, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.chkFiltro
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(218, 24)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.CheckEdit1
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(218, 24)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cbMes2
        Me.LayoutControlItem11.Location = New System.Drawing.Point(218, 24)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(286, 24)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "Hasta:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(156, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtUMCD
        Me.LayoutControlItem10.Location = New System.Drawing.Point(504, 0)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(310, 24)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(310, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(310, 24)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Calcular Depreciación para Mes :"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(156, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(504, 24)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(310, 24)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(310, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(310, 24)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(535, 291)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(55, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmActivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(834, 353)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmActivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkFiltro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUMCD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMes2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgActivos_Fijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VActivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub frmActivos_Fijos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Mes As String

        Mes = VB.SysContab.Activo_FijosDB.GetListUMCD()
        Dim ProximoMes As Date = DateAdd(DateInterval.Month, 1, CDate("01/" & Microsoft.VisualBasic.Right(Mes, 2) & "/" & Microsoft.VisualBasic.Left(Mes, 4)))
        Me.txtUMCD.Text = ProximoMes.Date.Year.ToString & ProximoMes.Date.Month.ToString.PadLeft(2, "0")

        Me.cbMes.Properties.DataSource =
            VB.SysContab.Activo_FijosDB.GetList_Meses("%").Tables(0)
        Me.cbMes.Properties.ValueMember = "mes_depreciacion"
        Me.cbMes.Properties.DisplayMember = "mes_depreciacion"

        Me.cbMes2.Properties.DataSource =
            VB.SysContab.Activo_FijosDB.GetList_Meses("%").Tables(0)
        Me.cbMes2.Properties.ValueMember = "mes_depreciacion"
        Me.cbMes2.Properties.DisplayMember = "mes_depreciacion"

        If Me.cbMes.Properties.DataSource.rows.count = 0 Then
            Me.cbMes.EditValue = ""
        Else
            Me.cbMes.EditValue = Me.cbMes.Properties.DataSource.rows(Me.cbMes.Properties.DataSource.rows.count - 1)("mes_depreciacion")
        End If

        If Me.cbMes2.Properties.DataSource.rows.count = 0 Then
            Me.cbMes2.EditValue = ""
        Else
            Me.cbMes2.EditValue = Me.cbMes2.Properties.DataSource.rows(Me.cbMes2.Properties.DataSource.rows.count - 1)("mes_depreciacion")
        End If

        Mes1 = Me.cbMes.EditValue
        Mes2 = Me.cbMes2.EditValue

        Me.Cargar()
        Me.Formato()

        Iniciado = True
        Me.Text = "Mantenimiento de Activos Fijos"
        Me.Refresh()
    End Sub

    Public Sub Formato()

        Me.VActivos.Columns("Codigo").Width = 100

        Me.VActivos.Columns("Descripcion").Width = 200
        Me.VActivos.Columns("Fecha Entrada").Width = 80
        Me.VActivos.Columns("Fecha Factura").Width = 100

        Me.VActivos.Columns("Precio").Width = 100
        Me.VActivos.Columns("Precio").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VActivos.Columns("Precio").DisplayFormat.FormatString = "n2"
        Me.VActivos.Columns("Precio").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VActivos.Columns("Precio").SummaryItem.DisplayFormat = "{0:n2}"

        Me.VActivos.Columns("Valor en Libros").Width = 100
        Me.VActivos.Columns("Valor en Libros").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VActivos.Columns("Valor en Libros").DisplayFormat.FormatString = "n2"
        Me.VActivos.Columns("Valor en Libros").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VActivos.Columns("Valor en Libros").SummaryItem.DisplayFormat = "{0:n2}"

        Me.VActivos.Columns("Depreciación Acumulada").Width = 100
        Me.VActivos.Columns("Depreciación Acumulada").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VActivos.Columns("Depreciación Acumulada").DisplayFormat.FormatString = "n2"
        Me.VActivos.Columns("Depreciación Acumulada").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VActivos.Columns("Depreciación Acumulada").SummaryItem.DisplayFormat = "{0:n2}"

        Me.VActivos.Columns("Depreciado del Mes").Width = 100
        Me.VActivos.Columns("Depreciado del Mes").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VActivos.Columns("Depreciado del Mes").DisplayFormat.FormatString = "n2"
        Me.VActivos.Columns("Depreciado del Mes").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VActivos.Columns("Depreciado del Mes").SummaryItem.DisplayFormat = "{0:n2}"

        Me.VActivos.Columns("Depreciación Mensual").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VActivos.Columns("Depreciación Mensual").DisplayFormat.FormatString = "n2"
        Me.VActivos.Columns("Depreciación Mensual").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.VActivos.Columns("Depreciación Mensual").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.VActivos.Columns("Cuenta de Gastos").ColumnEdit = Me.cbCuentaGastos
        'Me.VActivos.Columns("Cuenta de Depreciación").ColumnEdit = Me.cbCuentaDepreciacion
        'Me.VActivos.Columns("Cuenta Activo").ColumnEdit = Me.cbCuentaActivo

        VActivos.Columns("Cuenta de Gastos").Width = 200
        VActivos.Columns("Cuenta de Depreciación").Width = 200
        VActivos.Columns("Cuenta Activo").Width = 200

        VActivos.Columns("Cuenta de Gastos").Visible = False
        VActivos.Columns("Cuenta de Gastos").OptionsColumn.ShowInCustomizationForm = True

        VActivos.Columns("Cuenta de Depreciación").Visible = False
        VActivos.Columns("Cuenta de Depreciación").OptionsColumn.ShowInCustomizationForm = True

        VActivos.Columns("Cuenta Activo").Visible = False
        VActivos.Columns("Cuenta Activo").OptionsColumn.ShowInCustomizationForm = True

        VActivos.Columns("Cuenta Inventario").Visible = False
        VActivos.Columns("Cuenta Inventario").OptionsColumn.ShowInCustomizationForm = True

        VActivos.Columns("Estado").Visible = False
        VActivos.Columns("Estado").OptionsColumn.ShowInCustomizationForm = True
        VActivos.Columns("Estado").FilterInfo = Filtro

        VActivos.Columns("Ult. Mes Depreciado").Visible = False
        VActivos.Columns("Ult. Mes Depreciado").OptionsColumn.ShowInCustomizationForm = True

        VActivos.Columns("Asignado").Visible = False
        VActivos.Columns("Asignado").OptionsColumn.ShowInCustomizationForm = True

        VActivos.Columns("Depreciado del Mes").Visible = False

        VActivos.GroupSummary.Add(DevExpress.Data.SummaryItemType.Count, "Codigo", VActivos.Columns("Codigo"), "{0:n0}")
        VActivos.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "Precio", VActivos.Columns("Precio"), "{0:n2}")
        VActivos.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "Valor en Libros", VActivos.Columns("Valor en Libros"), "{0:n2}")
        VActivos.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "Depreciación Acumulada", VActivos.Columns("Depreciación Acumulada"), "{0:n2}")

    End Sub

    Public Sub CargarCombos()

        Me.cbMes.Properties.DataSource = VB.SysContab.Activo_FijosDB.GetList_Meses("%").Tables(0)
        Me.cbMes.Properties.ValueMember = "mes_depreciacion"
        Me.cbMes.Properties.DisplayMember = "mes_depreciacion"

        Me.cbMes2.Properties.DataSource = VB.SysContab.Activo_FijosDB.GetList_Meses("%").Tables(0)
        Me.cbMes2.Properties.ValueMember = "mes_depreciacion"
        Me.cbMes2.Properties.DisplayMember = "mes_depreciacion"

        If Me.cbMes.Properties.DataSource.rows.count = 0 Then
            Me.cbMes.EditValue = ""
        Else
            Me.cbMes.EditValue = Mes1
        End If

        If Me.cbMes2.Properties.DataSource.rows.count = 0 Then
            Me.cbMes2.EditValue = ""
        Else
            Me.cbMes2.EditValue = Mes2
        End If

    End Sub

    Public Sub Cargar()

        'cbCuentaGastos.DataSource = VB.SysContab.CatalogoDB.CuentasGastos()
        'cbCuentaGastos.ValueMember = "CUENTA"
        'cbCuentaGastos.DisplayMember = "NOMBRE"

        'cbCuentaDepreciacion.DataSource = VB.SysContab.CatalogoDB.CuentasDepreciacion()
        'cbCuentaDepreciacion.ValueMember = "CUENTA"
        'cbCuentaDepreciacion.DisplayMember = "NOMBRE"

        'cbCuentaActivo.DataSource = VB.SysContab.CatalogoDB.CuentasActivo()
        'cbCuentaActivo.ValueMember = "CUENTA"
        'cbCuentaActivo.DisplayMember = "NOMBRE"

        If Me.cbMes.EditValue = "" Or Me.cbMes.EditValue = "" Then
            dgActivos_Fijos.DataSource = VB.SysContab.Activo_FijosDB.GetList("%", "%", "%").Tables("Activo_Fijos")
        Else
            dgActivos_Fijos.DataSource = VB.SysContab.Activo_FijosDB.GetList("%",
            IIf(Me.cbMes.EditValue.ToString.Substring(0, 1) = "%", "%", Me.cbMes.EditValue),
            IIf(Me.cbMes2.EditValue.ToString.Substring(0, 1) = "%", "%", Me.cbMes2.EditValue)).Tables("Activo_Fijos")
        End If

        If Me.VActivos.DataRowCount <> 0 Then
            Registro = Me.VActivos.GetFocusedRowCellValue("Codigo")
        Else
            Registro = "Vacio"
        End If

        FormatoGrid(VActivos)
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        ShowSplash()
        Dim frm As frmAgregarActivo = frmAgregarActivo.Instance
        frm.Dispose()

        Dim f As frmAgregarActivo = frmAgregarActivo.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Text = "Nuevo Activo Fijo"
        f.Show()
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.VActivos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If

        Registro = Me.VActivos.GetFocusedRowCellValue("Codigo")

        ShowSplash()
        Dim frm As frmAgregarActivo = frmAgregarActivo.Instance
        frm.Dispose()

        Dim f As frmAgregarActivo = frmAgregarActivo.Instance
        Nuevo = "NO"
        If VActivos.GetFocusedRowCellValue("Vida Transcurrida") = 0 Then
            f.dtpFecha_Compra.Enabled = True
            f.dtpFecha_entrada.Enabled = True
        Else
            f.dtpFecha_entrada.Enabled = False
            f.dtpFecha_Compra.Enabled = False
        End If
        f.MdiParent = Me.MdiParent
        f.Text = "Editar Activo Fijo"
        f.Show()
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        'If Me.VActivos.DataRowCount = 0 Then
        '    MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.ActFij")
        '    Exit Sub
        'End If

        If VActivos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro")
            Exit Sub
        End If

        Registro = Me.VActivos.GetFocusedRowCellValue("Codigo")

        If VActivos.GetFocusedRowCellValue("") <> 0 Then
            XtraMsg("El activo no puede ser borrado ya que contiene depreciaciones contabilizadas.", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not XtraMsg2("Esta seguro que dese borrar el Activos_Fijo: " & Me.VActivos.GetFocusedRowCellValue("Descripcion")) Then
            Exit Sub
        End If

        'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        'DBConnFacturas.Open()
        'transaccionFacturas = DBConnFacturas.BeginTransaction
        Try
            Dim msg As String = ""
            msg = VB.SysContab.Activo_FijosDB.Delete2(Me.VActivos.GetFocusedRowCellValue("Codigo")).ToString

            'If msg <> "" Then
            '    XtraMsg(msg, MessageBoxIcon.Error)
            'End If

            '    VB.SysContab.Rutinas.okTransaccion()

            Me.Cargar()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            'VB.SysContab.Rutinas.ErrorTransaccion()
            'Exit Sub
        End Try

    End Sub

    Private Sub cmdAsignarActivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAsignarActivo.Click
        ShowSplash()
        Dim frm As frmAsignarActivo = frmAsignarActivo.Instance
        frm.Dispose()
        '
        Dim f As frmAsignarActivo = frmAsignarActivo.Instance
        f.MdiParent = Me.MdiParent
        f.Text = "Asignar Activo"
        f.Show()
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub frmActivos_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim f As frmReportesActivos = f.Instance
        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.cbEmpleados.SelectedIndex = 0
        'f.cbDepartamentos.SelectedIndex = 0
        'f.cbCargos.SelectedIndex = 0
        'f.cbStatus.SelectedIndex = 0
        'f.cbSituacion.SelectedIndex = 0

        'Dim forma As New frmexportaciongrid
        'forma.Mostrar(Me.dgActivos_Fijos)

        frmExportarImprimir.Mostrar(dgActivos_Fijos, Me.Text)

    End Sub

    Private Sub cmdDepreciacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDepreciacion.Click

        Dim f As New frmDepreciacion
        f.WindowState = FormWindowState.Normal
        f.StartPosition = FormStartPosition.CenterScreen
        f.ShowDialog()
        f.Dispose()

        Mes1 = cbMes.EditValue
        Mes2 = cbMes2.EditValue

        CargarCombos()
        Cargar()

        Dim ProximoMes As Date = DateAdd(DateInterval.Month, 1,
                                         CDate("01/" & Microsoft.VisualBasic.Right(VB.SysContab.Activo_FijosDB.GetListUMCD(), 2) & "/" &
                                         Microsoft.VisualBasic.Left(VB.SysContab.Activo_FijosDB.GetListUMCD(), 4)))

        Me.txtUMCD.Text = ProximoMes.Date.Year.ToString & ProximoMes.Date.Month.ToString.PadLeft(2, "0")
    End Sub

    Private Sub VActivos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VActivos.FocusedRowChanged
        Registro = Me.VActivos.GetFocusedRowCellValue("Codigo")
    End Sub

    Private Sub Vista_GridMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs) Handles VActivos.GridMenuItemClick
        Dim sumFormat As String
        Dim subSumFormat As Integer
        If e.MenuType <> GridMenuType.Summary Or e.DXMenuItem.Tag.Equals(GridStringId.MenuFooterCount) Then Exit Sub
        sumFormat = e.SummaryFormat
        subSumFormat = sumFormat.IndexOf("0")
        If subSumFormat > 0 Then sumFormat = sumFormat.Substring(0, subSumFormat) + "0:n2}"
        e.SummaryFormat = sumFormat
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If Me.CheckEdit1.Checked = True Then Me.VActivos.ColumnsCustomization() Else Me.VActivos.DestroyCustomization()
    End Sub

    Private Sub cbMes_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMes.EditValueChanged
        If Iniciado Then
            Me.Cargar()
        End If
    End Sub

    Private Sub cbMes2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMes2.EditValueChanged
        If Iniciado Then
            Me.Cargar()
        End If
    End Sub

    Private Sub chkFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltro.CheckedChanged
        If Me.chkFiltro.Checked Then
            Me.VActivos.Columns("Estado").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "")
        Else : Me.VActivos.Columns("Estado").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[Estado] not like '%Baja%' and [Estado] not like '%Vendido%'")
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'frmexportaciongrid.Mostrar(dgActivos_Fijos)
        frmExportarImprimir.Mostrar(dgActivos_Fijos, Me.Text)
    End Sub
End Class
