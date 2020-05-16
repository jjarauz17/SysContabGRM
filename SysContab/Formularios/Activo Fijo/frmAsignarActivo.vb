Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmAsignarActivo
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAsignarActivo = Nothing

    Public Shared Function Instance() As frmAsignarActivo
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAsignarActivo()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents VActivos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dtAsignacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbCentroCosto2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbEmpleado2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbEmpleados As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbCentroCosto As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents dgActivos_Fijos As DevExpress.XtraGrid.GridControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarActivo))
        Me.dtAsignacion = New DevExpress.XtraEditors.DateEdit()
        Me.cbCentroCosto2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbEmpleado2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.dgActivos_Fijos = New DevExpress.XtraGrid.GridControl()
        Me.VActivos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbEmpleados = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbCentroCosto = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.dtAsignacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAsignacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentroCosto2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmpleado2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgActivos_Fijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtAsignacion
        '
        Me.dtAsignacion.EditValue = Nothing
        Me.dtAsignacion.Location = New System.Drawing.Point(118, 60)
        Me.dtAsignacion.Name = "dtAsignacion"
        Me.dtAsignacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAsignacion.Properties.Appearance.Options.UseFont = True
        Me.dtAsignacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtAsignacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtAsignacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtAsignacion.Size = New System.Drawing.Size(139, 20)
        Me.dtAsignacion.StyleController = Me.LayoutControl1
        Me.dtAsignacion.TabIndex = 18
        '
        'cbCentroCosto2
        '
        Me.cbCentroCosto2.Location = New System.Drawing.Point(118, 36)
        Me.cbCentroCosto2.Name = "cbCentroCosto2"
        Me.cbCentroCosto2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentroCosto2.Size = New System.Drawing.Size(718, 20)
        Me.cbCentroCosto2.StyleController = Me.LayoutControl1
        Me.cbCentroCosto2.TabIndex = 17
        '
        'cbEmpleado2
        '
        Me.cbEmpleado2.Location = New System.Drawing.Point(118, 12)
        Me.cbEmpleado2.Name = "cbEmpleado2"
        Me.cbEmpleado2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpleado2.Size = New System.Drawing.Size(718, 20)
        Me.cbEmpleado2.StyleController = Me.LayoutControl1
        Me.cbEmpleado2.TabIndex = 15
        '
        'dgActivos_Fijos
        '
        Me.dgActivos_Fijos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgActivos_Fijos.Location = New System.Drawing.Point(12, 86)
        Me.dgActivos_Fijos.MainView = Me.VActivos
        Me.dgActivos_Fijos.Name = "dgActivos_Fijos"
        Me.dgActivos_Fijos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbEmpleados, Me.cbCentroCosto})
        Me.dgActivos_Fijos.Size = New System.Drawing.Size(824, 549)
        Me.dgActivos_Fijos.TabIndex = 13
        Me.dgActivos_Fijos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VActivos})
        '
        'VActivos
        '
        Me.VActivos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VActivos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.VActivos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VActivos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.VActivos.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VActivos.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.VActivos.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.VActivos.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.VActivos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VActivos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.VActivos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VActivos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.VActivos.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VActivos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.VActivos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.VActivos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.VActivos.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.VActivos.Appearance.Empty.Options.UseBackColor = True
        Me.VActivos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VActivos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.VActivos.Appearance.EvenRow.Options.UseBackColor = True
        Me.VActivos.Appearance.EvenRow.Options.UseForeColor = True
        Me.VActivos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VActivos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.VActivos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VActivos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.VActivos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VActivos.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.VActivos.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.VActivos.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.VActivos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VActivos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.VActivos.Appearance.FilterPanel.Options.UseBackColor = True
        Me.VActivos.Appearance.FilterPanel.Options.UseForeColor = True
        Me.VActivos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.VActivos.Appearance.FixedLine.Options.UseBackColor = True
        Me.VActivos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.VActivos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.VActivos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.VActivos.Appearance.FocusedCell.Options.UseForeColor = True
        Me.VActivos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.VActivos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.VActivos.Appearance.FocusedRow.Options.UseBackColor = True
        Me.VActivos.Appearance.FocusedRow.Options.UseForeColor = True
        Me.VActivos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VActivos.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.VActivos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VActivos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.VActivos.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VActivos.Appearance.FooterPanel.Options.UseBackColor = True
        Me.VActivos.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.VActivos.Appearance.FooterPanel.Options.UseForeColor = True
        Me.VActivos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.VActivos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.VActivos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.VActivos.Appearance.GroupButton.Options.UseBackColor = True
        Me.VActivos.Appearance.GroupButton.Options.UseBorderColor = True
        Me.VActivos.Appearance.GroupButton.Options.UseForeColor = True
        Me.VActivos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.VActivos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.VActivos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.VActivos.Appearance.GroupFooter.Options.UseBackColor = True
        Me.VActivos.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.VActivos.Appearance.GroupFooter.Options.UseForeColor = True
        Me.VActivos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VActivos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VActivos.Appearance.GroupPanel.Options.UseBackColor = True
        Me.VActivos.Appearance.GroupPanel.Options.UseForeColor = True
        Me.VActivos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.VActivos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.VActivos.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VActivos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.VActivos.Appearance.GroupRow.Options.UseBackColor = True
        Me.VActivos.Appearance.GroupRow.Options.UseBorderColor = True
        Me.VActivos.Appearance.GroupRow.Options.UseFont = True
        Me.VActivos.Appearance.GroupRow.Options.UseForeColor = True
        Me.VActivos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VActivos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.VActivos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.VActivos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.VActivos.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VActivos.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.VActivos.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.VActivos.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.VActivos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.VActivos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.VActivos.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VActivos.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VActivos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.VActivos.Appearance.HorzLine.Options.UseBackColor = True
        Me.VActivos.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.VActivos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.VActivos.Appearance.OddRow.Options.UseBackColor = True
        Me.VActivos.Appearance.OddRow.Options.UseForeColor = True
        Me.VActivos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VActivos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VActivos.Appearance.Preview.Options.UseBackColor = True
        Me.VActivos.Appearance.Preview.Options.UseForeColor = True
        Me.VActivos.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.VActivos.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.VActivos.Appearance.Row.Options.UseBackColor = True
        Me.VActivos.Appearance.Row.Options.UseForeColor = True
        Me.VActivos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.VActivos.Appearance.RowSeparator.Options.UseBackColor = True
        Me.VActivos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.VActivos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.VActivos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.VActivos.Appearance.SelectedRow.Options.UseForeColor = True
        Me.VActivos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.VActivos.Appearance.VertLine.Options.UseBackColor = True
        Me.VActivos.GridControl = Me.dgActivos_Fijos
        Me.VActivos.Name = "VActivos"
        Me.VActivos.OptionsView.EnableAppearanceEvenRow = True
        Me.VActivos.OptionsView.EnableAppearanceOddRow = True
        Me.VActivos.OptionsView.ShowAutoFilterRow = True
        Me.VActivos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VActivos.OptionsView.ShowFooter = True
        Me.VActivos.OptionsView.ShowGroupPanel = False
        '
        'cbEmpleados
        '
        Me.cbEmpleados.AutoHeight = False
        Me.cbEmpleados.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpleados.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 200, "Nombre")})
        Me.cbEmpleados.Name = "cbEmpleados"
        '
        'cbCentroCosto
        '
        Me.cbCentroCosto.AutoHeight = False
        Me.cbCentroCosto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentroCosto.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 200, "Descripcion")})
        Me.cbCentroCosto.Name = "cbCentroCosto"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.dtAsignacion)
        Me.LayoutControl1.Controls.Add(Me.dgActivos_Fijos)
        Me.LayoutControl1.Controls.Add(Me.cbCentroCosto2)
        Me.LayoutControl1.Controls.Add(Me.cbEmpleado2)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(945, 213, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(848, 647)
        Me.LayoutControl1.TabIndex = 14
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(848, 647)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgActivos_Fijos
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(828, 553)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbEmpleado2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(828, 24)
        Me.LayoutControlItem2.Text = "Empleado:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbCentroCosto2
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(828, 24)
        Me.LayoutControlItem3.Text = "Centro de  Costo:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dtAsignacion
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(249, 26)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(249, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(249, 26)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Fecha de Asignación:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(102, 13)
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(640, 60)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(96, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 19
        Me.SimpleButton1.Text = "&Asignar"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButton1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(628, 48)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(100, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(100, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(100, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(740, 60)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(96, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 20
        Me.SimpleButton2.Text = "&Salir"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton2
        Me.LayoutControlItem6.Location = New System.Drawing.Point(728, 48)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(100, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(100, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(100, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(249, 48)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(379, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmAsignarActivo
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(848, 647)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmAsignarActivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtAsignacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAsignacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentroCosto2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmpleado2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgActivos_Fijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VActivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAsignarActivo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cbEmpleados.DataSource = VB.SysContab.EmpleadosDB.GetListDepto("%")
        Me.cbEmpleados.DisplayMember = "Nombre"
        Me.cbEmpleados.ValueMember = "Codigo"

        Me.cbCentroCosto.DataSource = VB.SysContab.RubrosGastosDB.CentrosCosto_Listar()
        Me.cbCentroCosto.DisplayMember = "Nombre"
        Me.cbCentroCosto.ValueMember = "Codigo"


        Me.cbEmpleado2.Properties.DataSource = VB.SysContab.EmpleadosDB.GetListDepto("%").Tables(0)
        Me.cbEmpleado2.Properties.DisplayMember = "Nombre"
        Me.cbEmpleado2.Properties.ValueMember = "Codigo"

        Me.cbCentroCosto2.Properties.DataSource = VB.SysContab.RubrosGastosDB.CentrosCosto_Listar()
        Me.cbCentroCosto2.Properties.DisplayMember = "Nombre"
        Me.cbCentroCosto2.Properties.ValueMember = "Codigo"

        Me.dgActivos_Fijos.DataSource = VB.SysContab.Activo_FijosDB.GetListAsignados("%", "0")
        Me.VActivos.Columns("Codigo").OptionsColumn.ReadOnly = True
        Me.VActivos.Columns("Descripcion").OptionsColumn.ReadOnly = True
        Me.VActivos.Columns("Empleado").OptionsColumn.ReadOnly = True
        Me.VActivos.Columns("Empleado").ColumnEdit = Me.cbEmpleados
        Me.VActivos.Columns("Centro").OptionsColumn.ReadOnly = True
        Me.VActivos.Columns("Centro").ColumnEdit = Me.cbCentroCosto
        Me.Text = "Asignar Activos Fijos"
        Me.Refresh()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If Me.VActivos.DataRowCount = 0 Then
            XtraMsg("No hay registros en la lista")
            Exit Sub
        End If

        Dim empleado, ccosto As String
        empleado = ""
        ccosto = ""

        If Me.cbEmpleado2.EditValue = Nothing Then
            empleado = ""
        ElseIf Me.cbEmpleado2.EditValue = "%" Then
            empleado = ""
        Else
            empleado = Me.cbEmpleado2.EditValue
        End If

        If Me.cbCentroCosto2.EditValue Is Nothing Then
            ccosto = ""
        ElseIf Me.cbCentroCosto2.EditValue = "0" Then
            ccosto = ""
        Else
            ccosto = Me.cbCentroCosto2.EditValue.ToString
        End If

        If empleado = "" And ccosto = "" Then
            XtraMsg("Debe seleccionar un empleado o un centro de costo para asignar el activo")
            Exit Sub
        End If

        If Me.dtAsignacion.EditValue Is Nothing Then
            XtraMsg("Digite una fecha de asignacion")
            Exit Sub
        End If

        For i As Integer = 0 To Me.VActivos.DataRowCount - 1
            If Me.VActivos.GetRowCellValue(i, "Asignado") = True Then
                VB.SysContab.RubrosGastosDB.Asignacion_Add(Me.VActivos.GetRowCellValue(i, "Codigo"),
                empleado, ccosto, Me.dtAsignacion.EditValue)
            End If
        Next
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dispose()
    End Sub
End Class
