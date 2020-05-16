Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration

Public Class FrmVentasCrossTab
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
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents iPivotGrid As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField13 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField14 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField15 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents cmdabrir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGrafico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdguardare As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdcargare As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdnewgrap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdexportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Abrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PivotGridField16 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField17 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField18 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField19 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField20 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PivotGridField21 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField22 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField23 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents cbMonedaCambio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PivotGridField24 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField25 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField26 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField27 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField28 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField29 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField30 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField31 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField32 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyVerGrafico As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PivotGridField33 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField34 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField35 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField36 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PivotGridField37 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField38 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField39 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField40 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents cbCliente As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbProducto As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCultivo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sel1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sel3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Guardar As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentasCrossTab))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit4 = New DevExpress.XtraEditors.CheckEdit()
        Me.cbCultivo = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbProducto = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCliente = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.iPivotGrid = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField17 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField18 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField19 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField20 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField21 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField22 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField23 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField24 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField25 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField26 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField30 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField27 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField28 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField29 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField31 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField32 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField33 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField34 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField35 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField36 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField37 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField38 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField39 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField40 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cbMonedaCambio = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.sel3 = New DevExpress.XtraEditors.DateEdit()
        Me.sel1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGrafico = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdnewgrap = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdabrir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdcargare = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdguardare = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdexportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyVerGrafico = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Guardar = New System.Windows.Forms.SaveFileDialog()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCultivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iPivotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMonedaCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.sel3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sel3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sel1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sel1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyVerGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckEdit2)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit3)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit4)
        Me.LayoutControl1.Controls.Add(Me.cbCultivo)
        Me.LayoutControl1.Controls.Add(Me.cbProducto)
        Me.LayoutControl1.Controls.Add(Me.cbCliente)
        Me.LayoutControl1.Controls.Add(Me.iPivotGrid)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(981, 198, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(856, 600)
        Me.LayoutControl1.TabIndex = 164
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(719, 38)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "Mostrar más Campos"
        Me.CheckEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit2.Size = New System.Drawing.Size(125, 22)
        Me.CheckEdit2.StyleController = Me.LayoutControl1
        Me.CheckEdit2.TabIndex = 192
        '
        'CheckEdit3
        '
        Me.CheckEdit3.Location = New System.Drawing.Point(601, 38)
        Me.CheckEdit3.Name = "CheckEdit3"
        Me.CheckEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckEdit3.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit3.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit3.Properties.Caption = "Quitar Gran Total"
        Me.CheckEdit3.Size = New System.Drawing.Size(114, 19)
        Me.CheckEdit3.StyleController = Me.LayoutControl1
        Me.CheckEdit3.TabIndex = 184
        '
        'CheckEdit4
        '
        Me.CheckEdit4.Location = New System.Drawing.Point(485, 38)
        Me.CheckEdit4.Name = "CheckEdit4"
        Me.CheckEdit4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckEdit4.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit4.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit4.Properties.Caption = "Quitar Sub Totales"
        Me.CheckEdit4.Size = New System.Drawing.Size(112, 19)
        Me.CheckEdit4.StyleController = Me.LayoutControl1
        Me.CheckEdit4.TabIndex = 183
        '
        'cbCultivo
        '
        Me.cbCultivo.Location = New System.Drawing.Point(554, 12)
        Me.cbCultivo.Name = "cbCultivo"
        Me.cbCultivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbCultivo.Properties.Appearance.Options.UseFont = True
        Me.cbCultivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCultivo.Size = New System.Drawing.Size(290, 20)
        Me.cbCultivo.StyleController = Me.LayoutControl1
        Me.cbCultivo.TabIndex = 191
        '
        'cbProducto
        '
        Me.cbProducto.Location = New System.Drawing.Point(81, 38)
        Me.cbProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProducto.Properties.Appearance.Options.UseFont = True
        Me.cbProducto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbProducto.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProducto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.cbProducto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cbProducto.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cbProducto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cbProducto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProducto.Properties.View = Me.GridView1
        Me.cbProducto.Size = New System.Drawing.Size(400, 20)
        Me.cbProducto.StyleController = Me.LayoutControl1
        Me.cbProducto.TabIndex = 167
        Me.cbProducto.Tag = "True"
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cbCliente
        '
        Me.cbCliente.Enabled = False
        Me.cbCliente.Location = New System.Drawing.Point(127, 12)
        Me.cbCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCliente.Properties.Appearance.Options.UseFont = True
        Me.cbCliente.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbCliente.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCliente.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.cbCliente.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cbCliente.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cbCliente.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cbCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCliente.Properties.View = Me.GridLookUpEdit1View
        Me.cbCliente.Size = New System.Drawing.Size(354, 20)
        Me.cbCliente.StyleController = Me.LayoutControl1
        Me.cbCliente.TabIndex = 166
        Me.cbCliente.Tag = "True"
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'iPivotGrid
        '
        Me.iPivotGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iPivotGrid.Appearance.FieldHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iPivotGrid.Appearance.FieldHeader.Options.UseFont = True
        Me.iPivotGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.iPivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField12, Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField13, Me.PivotGridField14, Me.PivotGridField5, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField15, Me.PivotGridField10, Me.PivotGridField11, Me.PivotGridField16, Me.PivotGridField17, Me.PivotGridField18, Me.PivotGridField19, Me.PivotGridField20, Me.PivotGridField21, Me.PivotGridField22, Me.PivotGridField23, Me.PivotGridField24, Me.PivotGridField25, Me.PivotGridField26, Me.PivotGridField30, Me.PivotGridField27, Me.PivotGridField28, Me.PivotGridField29, Me.PivotGridField31, Me.PivotGridField32, Me.PivotGridField33, Me.PivotGridField34, Me.PivotGridField35, Me.PivotGridField36, Me.PivotGridField37, Me.PivotGridField38, Me.PivotGridField39, Me.PivotGridField40})
        Me.iPivotGrid.Location = New System.Drawing.Point(12, 64)
        Me.iPivotGrid.Name = "iPivotGrid"
        Me.iPivotGrid.Size = New System.Drawing.Size(832, 524)
        Me.iPivotGrid.TabIndex = 161
        '
        'PivotGridField12
        '
        Me.PivotGridField12.AreaIndex = 6
        Me.PivotGridField12.FieldName = "Cliente"
        Me.PivotGridField12.Name = "PivotGridField12"
        Me.PivotGridField12.Width = 200
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField1.AreaIndex = 1
        Me.PivotGridField1.CellFormat.FormatString = "{0:n4}"
        Me.PivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField1.FieldName = "Precio"
        Me.PivotGridField1.Name = "PivotGridField1"
        Me.PivotGridField1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField2.AreaIndex = 2
        Me.PivotGridField2.FieldName = "Item"
        Me.PivotGridField2.Name = "PivotGridField2"
        Me.PivotGridField2.Width = 200
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField3.AreaIndex = 1
        Me.PivotGridField3.FieldName = "Codigo"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField4.AreaIndex = 0
        Me.PivotGridField4.CellFormat.FormatString = "{0:n4}"
        Me.PivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField4.FieldName = "Cantidad"
        Me.PivotGridField4.Name = "PivotGridField4"
        '
        'PivotGridField6
        '
        Me.PivotGridField6.AreaIndex = 1
        Me.PivotGridField6.FieldName = "Vendedor"
        Me.PivotGridField6.Name = "PivotGridField6"
        '
        'PivotGridField7
        '
        Me.PivotGridField7.AreaIndex = 2
        Me.PivotGridField7.CellFormat.FormatString = "{0:N}"
        Me.PivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField7.FieldName = "Descuento"
        Me.PivotGridField7.Name = "PivotGridField7"
        '
        'PivotGridField13
        '
        Me.PivotGridField13.AreaIndex = 4
        Me.PivotGridField13.FieldName = "Forma Pago"
        Me.PivotGridField13.Name = "PivotGridField13"
        '
        'PivotGridField14
        '
        Me.PivotGridField14.AreaIndex = 3
        Me.PivotGridField14.FieldName = "Fecha"
        Me.PivotGridField14.Name = "PivotGridField14"
        Me.PivotGridField14.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        '
        'PivotGridField5
        '
        Me.PivotGridField5.AreaIndex = 0
        Me.PivotGridField5.Caption = "Trimestre"
        Me.PivotGridField5.FieldName = "Trimestre"
        Me.PivotGridField5.Name = "PivotGridField5"
        '
        'PivotGridField8
        '
        Me.PivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField8.AreaIndex = 2
        Me.PivotGridField8.CellFormat.FormatString = "{0:n2}"
        Me.PivotGridField8.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField8.FieldName = "Sub Total"
        Me.PivotGridField8.Name = "PivotGridField8"
        '
        'PivotGridField9
        '
        Me.PivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField9.AreaIndex = 3
        Me.PivotGridField9.CellFormat.FormatString = "{0:N}"
        Me.PivotGridField9.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField9.FieldName = "IVA"
        Me.PivotGridField9.Name = "PivotGridField9"
        '
        'PivotGridField15
        '
        Me.PivotGridField15.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField15.AreaIndex = 4
        Me.PivotGridField15.CellFormat.FormatString = "{0:N}"
        Me.PivotGridField15.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField15.FieldName = "Total"
        Me.PivotGridField15.Name = "PivotGridField15"
        '
        'PivotGridField10
        '
        Me.PivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField10.AreaIndex = 0
        Me.PivotGridField10.Caption = "Año"
        Me.PivotGridField10.FieldName = "Anno"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField11.AreaIndex = 1
        Me.PivotGridField11.FieldName = "Mes"
        Me.PivotGridField11.Name = "PivotGridField11"
        '
        'PivotGridField16
        '
        Me.PivotGridField16.AreaIndex = 28
        Me.PivotGridField16.FieldName = "Factura"
        Me.PivotGridField16.Name = "PivotGridField16"
        '
        'PivotGridField17
        '
        Me.PivotGridField17.AreaIndex = 5
        Me.PivotGridField17.FieldName = "Caja"
        Me.PivotGridField17.Name = "PivotGridField17"
        '
        'PivotGridField18
        '
        Me.PivotGridField18.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField18.AreaIndex = 0
        Me.PivotGridField18.FieldName = "Bodega"
        Me.PivotGridField18.Name = "PivotGridField18"
        Me.PivotGridField18.Width = 200
        '
        'PivotGridField19
        '
        Me.PivotGridField19.AreaIndex = 29
        Me.PivotGridField19.FieldName = "U/M"
        Me.PivotGridField19.Name = "PivotGridField19"
        '
        'PivotGridField20
        '
        Me.PivotGridField20.AreaIndex = 8
        Me.PivotGridField20.FieldName = "Presentacion"
        Me.PivotGridField20.Name = "PivotGridField20"
        '
        'PivotGridField21
        '
        Me.PivotGridField21.AreaIndex = 9
        Me.PivotGridField21.FieldName = "Cultivo"
        Me.PivotGridField21.Name = "PivotGridField21"
        '
        'PivotGridField22
        '
        Me.PivotGridField22.AreaIndex = 7
        Me.PivotGridField22.Caption = "Codigo Cliente"
        Me.PivotGridField22.FieldName = "CodigoLetra"
        Me.PivotGridField22.Name = "PivotGridField22"
        '
        'PivotGridField23
        '
        Me.PivotGridField23.AreaIndex = 10
        Me.PivotGridField23.Caption = "Trans_Id"
        Me.PivotGridField23.FieldName = "NUMERO"
        Me.PivotGridField23.Name = "PivotGridField23"
        '
        'PivotGridField24
        '
        Me.PivotGridField24.AreaIndex = 11
        Me.PivotGridField24.FieldName = "Serie"
        Me.PivotGridField24.Name = "PivotGridField24"
        '
        'PivotGridField25
        '
        Me.PivotGridField25.AreaIndex = 12
        Me.PivotGridField25.FieldName = "Clase"
        Me.PivotGridField25.Name = "PivotGridField25"
        '
        'PivotGridField26
        '
        Me.PivotGridField26.AreaIndex = 13
        Me.PivotGridField26.FieldName = "Grupo"
        Me.PivotGridField26.Name = "PivotGridField26"
        '
        'PivotGridField30
        '
        Me.PivotGridField30.AreaIndex = 14
        Me.PivotGridField30.FieldName = "Sub Grupo"
        Me.PivotGridField30.Name = "PivotGridField30"
        '
        'PivotGridField27
        '
        Me.PivotGridField27.AreaIndex = 15
        Me.PivotGridField27.FieldName = "Despacho"
        Me.PivotGridField27.Name = "PivotGridField27"
        '
        'PivotGridField28
        '
        Me.PivotGridField28.AreaIndex = 16
        Me.PivotGridField28.FieldName = "Proveedor"
        Me.PivotGridField28.Name = "PivotGridField28"
        '
        'PivotGridField29
        '
        Me.PivotGridField29.AreaIndex = 17
        Me.PivotGridField29.FieldName = "Remision"
        Me.PivotGridField29.Name = "PivotGridField29"
        '
        'PivotGridField31
        '
        Me.PivotGridField31.AreaIndex = 18
        Me.PivotGridField31.FieldName = "Casa"
        Me.PivotGridField31.Name = "PivotGridField31"
        '
        'PivotGridField32
        '
        Me.PivotGridField32.AreaIndex = 19
        Me.PivotGridField32.CellFormat.FormatString = "{0:n2}"
        Me.PivotGridField32.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField32.FieldName = "Costo Venta"
        Me.PivotGridField32.Name = "PivotGridField32"
        '
        'PivotGridField33
        '
        Me.PivotGridField33.AreaIndex = 21
        Me.PivotGridField33.Caption = "Margen"
        Me.PivotGridField33.CellFormat.FormatString = "{0:n2}"
        Me.PivotGridField33.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField33.FieldName = "Margen"
        Me.PivotGridField33.Name = "PivotGridField33"
        Me.PivotGridField33.TotalValueFormat.FormatString = "{0:n2}"
        Me.PivotGridField33.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField34
        '
        Me.PivotGridField34.AreaIndex = 20
        Me.PivotGridField34.Caption = "Costo Unitario"
        Me.PivotGridField34.CellFormat.FormatString = "{0:n2}"
        Me.PivotGridField34.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField34.FieldName = "Costo Unitario"
        Me.PivotGridField34.Name = "PivotGridField34"
        Me.PivotGridField34.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        Me.PivotGridField34.TotalValueFormat.FormatString = "{0:n2}"
        Me.PivotGridField34.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'PivotGridField35
        '
        Me.PivotGridField35.AreaIndex = 22
        Me.PivotGridField35.Caption = "Margen %"
        Me.PivotGridField35.CellFormat.FormatString = "{0:p2}"
        Me.PivotGridField35.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField35.FieldName = "MargenP"
        Me.PivotGridField35.Name = "PivotGridField35"
        Me.PivotGridField35.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        '
        'PivotGridField36
        '
        Me.PivotGridField36.AreaIndex = 23
        Me.PivotGridField36.Caption = "Margen % Item"
        Me.PivotGridField36.CellFormat.FormatString = "{0:p2}"
        Me.PivotGridField36.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField36.FieldName = "MargenProd"
        Me.PivotGridField36.Name = "PivotGridField36"
        Me.PivotGridField36.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        '
        'PivotGridField37
        '
        Me.PivotGridField37.AreaIndex = 24
        Me.PivotGridField37.Caption = "SubTotal Con Descuento"
        Me.PivotGridField37.CellFormat.FormatString = "{0:n2}"
        Me.PivotGridField37.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField37.FieldName = "SubTotalConDesc"
        Me.PivotGridField37.Name = "PivotGridField37"
        '
        'PivotGridField38
        '
        Me.PivotGridField38.AreaIndex = 25
        Me.PivotGridField38.Caption = "#Devolución"
        Me.PivotGridField38.FieldName = "#Devolución"
        Me.PivotGridField38.Name = "PivotGridField38"
        '
        'PivotGridField39
        '
        Me.PivotGridField39.AreaIndex = 27
        Me.PivotGridField39.Caption = "Dias de Credito"
        Me.PivotGridField39.FieldName = "Dias"
        Me.PivotGridField39.Name = "PivotGridField39"
        '
        'PivotGridField40
        '
        Me.PivotGridField40.AreaIndex = 26
        Me.PivotGridField40.Caption = "Vencimiento"
        Me.PivotGridField40.FieldName = "Vencimiento"
        Me.PivotGridField40.Name = "PivotGridField40"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 12)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Por Cliente:"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(111, 22)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 188
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem23, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem17})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(856, 600)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iPivotGrid
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(836, 528)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CheckEdit1
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(115, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(115, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(115, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cbCliente
        Me.LayoutControlItem23.Location = New System.Drawing.Point(115, 0)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(358, 26)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbProducto
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(473, 26)
        Me.LayoutControlItem3.Text = "Por Producto:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbCultivo
        Me.LayoutControlItem5.Location = New System.Drawing.Point(473, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(363, 26)
        Me.LayoutControlItem5.Text = "Por Cultivo:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.CheckEdit4
        Me.LayoutControlItem7.Location = New System.Drawing.Point(473, 26)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(116, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(116, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(116, 26)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CheckEdit3
        Me.LayoutControlItem8.Location = New System.Drawing.Point(589, 26)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(118, 24)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(118, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(118, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.CheckEdit2
        Me.LayoutControlItem17.Location = New System.Drawing.Point(707, 26)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(129, 26)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(129, 26)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(129, 26)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMonedaCambio.EnterMoveNextControl = True
        Me.cbMonedaCambio.Location = New System.Drawing.Point(12, 108)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMonedaCambio.Properties.NullText = ""
        Me.cbMonedaCambio.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cbMonedaCambio.Properties.ShowFooter = False
        Me.cbMonedaCambio.Properties.ShowHeader = False
        Me.cbMonedaCambio.Size = New System.Drawing.Size(117, 20)
        Me.cbMonedaCambio.StyleController = Me.LayoutControl2
        Me.cbMonedaCambio.TabIndex = 189
        Me.cbMonedaCambio.TabStop = False
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.sel3)
        Me.LayoutControl2.Controls.Add(Me.sel1)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.cbMonedaCambio)
        Me.LayoutControl2.Controls.Add(Me.cmdGrafico)
        Me.LayoutControl2.Controls.Add(Me.cmdnewgrap)
        Me.LayoutControl2.Controls.Add(Me.cmdabrir)
        Me.LayoutControl2.Controls.Add(Me.cmdguardar)
        Me.LayoutControl2.Controls.Add(Me.cmdcargare)
        Me.LayoutControl2.Controls.Add(Me.cmdguardare)
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.cmdexportar)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14, Me.LayoutControlItem15, Me.lyVerGrafico})
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1172, 209, 250, 588)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(141, 573)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'sel3
        '
        Me.sel3.EditValue = New Date(2016, 8, 3, 9, 4, 9, 0)
        Me.sel3.Location = New System.Drawing.Point(12, 68)
        Me.sel3.Name = "sel3"
        Me.sel3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sel3.Properties.Appearance.Options.UseFont = True
        Me.sel3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sel3.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sel3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.sel3.Size = New System.Drawing.Size(117, 20)
        Me.sel3.StyleController = Me.LayoutControl2
        Me.sel3.TabIndex = 191
        '
        'sel1
        '
        Me.sel1.EditValue = New Date(2016, 8, 3, 9, 4, 9, 0)
        Me.sel1.Location = New System.Drawing.Point(12, 28)
        Me.sel1.Name = "sel1"
        Me.sel1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sel1.Properties.Appearance.Options.UseFont = True
        Me.sel1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sel1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sel1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.sel1.Size = New System.Drawing.Size(117, 20)
        Me.sel1.StyleController = Me.LayoutControl2
        Me.sel1.TabIndex = 190
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Options.UseTextOptions = True
        Me.SimpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(12, 216)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(117, 38)
        Me.SimpleButton3.StyleController = Me.LayoutControl2
        Me.SimpleButton3.TabIndex = 167
        Me.SimpleButton3.Text = "&Rebajas"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Options.UseTextOptions = True
        Me.SimpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 174)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(117, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 166
        Me.SimpleButton2.Text = "&Devoluciones"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 258)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(117, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 183
        Me.SimpleButton1.Text = "&Actualizar Campos"
        '
        'cmdGrafico
        '
        Me.cmdGrafico.Appearance.Options.UseTextOptions = True
        Me.cmdGrafico.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdGrafico.Location = New System.Drawing.Point(12, 371)
        Me.cmdGrafico.Name = "cmdGrafico"
        Me.cmdGrafico.Size = New System.Drawing.Size(117, 22)
        Me.cmdGrafico.StyleController = Me.LayoutControl2
        Me.cmdGrafico.TabIndex = 181
        Me.cmdGrafico.Text = "&Ver Gráfico"
        '
        'cmdnewgrap
        '
        Me.cmdnewgrap.Appearance.Options.UseTextOptions = True
        Me.cmdnewgrap.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdnewgrap.ImageOptions.Image = CType(resources.GetObject("cmdnewgrap.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdnewgrap.Location = New System.Drawing.Point(12, 355)
        Me.cmdnewgrap.Name = "cmdnewgrap"
        Me.cmdnewgrap.Size = New System.Drawing.Size(117, 38)
        Me.cmdnewgrap.StyleController = Me.LayoutControl2
        Me.cmdnewgrap.TabIndex = 182
        Me.cmdnewgrap.Text = "&Gráfico"
        '
        'cmdabrir
        '
        Me.cmdabrir.Appearance.Options.UseTextOptions = True
        Me.cmdabrir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdabrir.Location = New System.Drawing.Point(12, 439)
        Me.cmdabrir.Name = "cmdabrir"
        Me.cmdabrir.Size = New System.Drawing.Size(118, 38)
        Me.cmdabrir.StyleController = Me.LayoutControl2
        Me.cmdabrir.TabIndex = 185
        Me.cmdabrir.Text = "C&argar Datos"
        '
        'cmdguardar
        '
        Me.cmdguardar.Appearance.Options.UseTextOptions = True
        Me.cmdguardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdguardar.Location = New System.Drawing.Point(12, 355)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(118, 38)
        Me.cmdguardar.StyleController = Me.LayoutControl2
        Me.cmdguardar.TabIndex = 184
        Me.cmdguardar.Text = "Guardar &Datos"
        '
        'cmdcargare
        '
        Me.cmdcargare.Appearance.Options.UseTextOptions = True
        Me.cmdcargare.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdcargare.ImageOptions.Image = CType(resources.GetObject("cmdcargare.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdcargare.Location = New System.Drawing.Point(12, 439)
        Me.cmdcargare.Name = "cmdcargare"
        Me.cmdcargare.Size = New System.Drawing.Size(117, 38)
        Me.cmdcargare.StyleController = Me.LayoutControl2
        Me.cmdcargare.TabIndex = 186
        Me.cmdcargare.Text = "&Restaurar Esquema"
        '
        'cmdguardare
        '
        Me.cmdguardare.Appearance.Options.UseTextOptions = True
        Me.cmdguardare.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdguardare.ImageOptions.Image = CType(resources.GetObject("cmdguardare.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdguardare.Location = New System.Drawing.Point(12, 397)
        Me.cmdguardare.Name = "cmdguardare"
        Me.cmdguardare.Size = New System.Drawing.Size(117, 38)
        Me.cmdguardare.StyleController = Me.LayoutControl2
        Me.cmdguardare.TabIndex = 183
        Me.cmdguardare.Text = "Guardar &Esquema"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 523)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(117, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        '
        'cmdexportar
        '
        Me.cmdexportar.Appearance.Options.UseTextOptions = True
        Me.cmdexportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdexportar.ImageOptions.Image = CType(resources.GetObject("cmdexportar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdexportar.Location = New System.Drawing.Point(12, 481)
        Me.cmdexportar.Name = "cmdexportar"
        Me.cmdexportar.Size = New System.Drawing.Size(117, 38)
        Me.cmdexportar.StyleController = Me.LayoutControl2
        Me.cmdexportar.TabIndex = 8
        Me.cmdexportar.Text = "E&xportar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Options.UseTextOptions = True
        Me.cmdImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 132)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(117, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl2
        Me.cmdImprimir.TabIndex = 0
        Me.cmdImprimir.Text = "&Buscar"
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmdguardar
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 343)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cmdabrir
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 427)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'lyVerGrafico
        '
        Me.lyVerGrafico.Control = Me.cmdGrafico
        Me.lyVerGrafico.CustomizationFormText = "Ver Gráfico"
        Me.lyVerGrafico.Location = New System.Drawing.Point(0, 359)
        Me.lyVerGrafico.Name = "lyVerGrafico"
        Me.lyVerGrafico.Size = New System.Drawing.Size(121, 26)
        Me.lyVerGrafico.Text = "Ver Gráfico"
        Me.lyVerGrafico.TextSize = New System.Drawing.Size(0, 0)
        Me.lyVerGrafico.TextVisible = False
        Me.lyVerGrafico.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.EmptySpaceItem1, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem16, Me.LayoutControlItem18, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem4, Me.LayoutControlItem6})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(141, 573)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdImprimir
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdSalir
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 511)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdexportar
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 469)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 288)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(121, 55)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdguardare
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 385)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdcargare
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 427)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cmdnewgrap
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 343)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cbMonedaCambio
        Me.LayoutControlItem18.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(121, 40)
        Me.LayoutControlItem18.Text = "Moneda:"
        Me.LayoutControlItem18.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(42, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.SimpleButton1
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 246)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.SimpleButton2
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 162)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.SimpleButton3
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 204)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(121, 42)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.sel1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(121, 40)
        Me.LayoutControlItem4.Text = "Desde:"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(42, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.sel3
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(121, 40)
        Me.LayoutControlItem6.Text = "Hasta:"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(42, 13)
        '
        'Abrir
        '
        Me.Abrir.DefaultExt = "*.xml"
        Me.Abrir.Filter = "(*.xml)|*.xml"
        '
        'Guardar
        '
        Me.Guardar.DefaultExt = "*.xml"
        Me.Guardar.Filter = "(*.xml)|*.xml"
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("af32b507-ae9d-4a44-acd9-356b6ce997ee")
        Me.DockPanel1.Location = New System.Drawing.Point(856, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 600)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(141, 573)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'FrmVentasCrossTab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1006, 600)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "FrmVentasCrossTab"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCultivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iPivotGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMonedaCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.sel3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sel3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sel1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sel1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyVerGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared ChildInstance As FrmVentasCrossTab = Nothing

    Public Shared Function Instance() As FrmVentasCrossTab
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmVentasCrossTab
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim r As New VB.SysContab.Rutinas

    Sub GetData()
        iPivotGrid.DataSource = ObtieneDatos("JAR_FacturasVentasCrossTab", sel1.DateTime.Date,
                                             sel3.DateTime.Date,
                                             cbProducto.EditValue,
                                              IIf(CheckEdit1.Checked, cbCliente.EditValue, "0"),
                                             cbCultivo.EditValue,
                                             cbMonedaCambio.EditValue,
                                             EmpresaActual)

        'Dsa = VB.SysContab.ReportesCrossTabDB.GetList(EmpresaActual, 0 _
        '           sel1.Value, sel3.Value, Codigo, Articulo, Vendedor, Cliente, cbMonedaCambio.EditValue)
        'Return Dsa
    End Sub

    'Public Function MyDataset() As DataSet
    '    'Dim Empresa As String = EmpresaActual
    '' Dim Dsa As New DataSet
    '    'Dim Codigo As String
    '    'Dim Articulo As String
    '    'Dim Vendedor As String
    '    'Dim Cliente As Integer

    '    'Codigo = ""
    '    'Articulo = ""
    '    'Vendedor = ""

    '    'If Me.CheckEdit1.Checked Then
    '    '    Cliente = IIf(ddlCliente.EditValue Is Nothing, 0, Me.ddlCliente.EditValue)
    '    'Else
    '    '    Cliente = 0
    '    'End If

    '    'If cbProducto.SelectedValue = 0 And txtPor.Text <> "" Then
    '    '    Codigo = txtPor.Text
    '    'End If

    '    'If cbProducto.SelectedValue = 1 And txtPor.Text <> "" Then
    '    '    Articulo = txtPor.Text
    '    'End If

    '    'If cbProducto.SelectedValue = 2 And txtPor.Text <> "" Then
    '    '    Vendedor = txtPor.Text
    '    'End If

    ''   VB.SysContab.ReportesCrossTabDB.GetList(, cbCultivos.SelectedValue, _
    '    '            sel1.Value, sel3.Value, Codigo, Articulo, Vendedor, Cliente, cbMonedaCambio.EditValue)
    '    'Return Dsa
    'End Function

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If CheckEdit1.Checked Then
            If cbCliente.EditValue Is Nothing Then
                XtraMsg("Seleccione el Cliente")
                cbCliente.Focus()
                Exit Sub
            End If
        End If
        '
        Try
            ShowSplash()
            'iPivotGrid.DataSource = MyDataset().Tables(0)
            GetData()
            HideSplash()
        Catch ex As Exception
            HideSplash()
        End Try

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmEstadoSituacionCrossTab_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'r.CambiarEstilo(Me)

        Dim Tasa As New VB.SysContab.Tasa_CambioDB

        'cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        'cbMonedaCambio.ValueMember = "MonedaCambio"
        'cbMonedaCambio.DisplayMember = "Nombre"

        Application.DoEvents()
        GetMonedasList(cbMonedaCambio)

        Dim Cli As New VB.SysContab.ClientesDB
        Dim FormPago As New VB.SysContab.Forma_PagoDB

        'ddlCliente.DataSource = Cli.GetList().Tables(0)
        'ddlCliente.ValueMember = "Codigo"
        'ddlCliente.DisplayMember = "Nombre"
        'LoadClients()

        'Application.DoEvents()
        'ddlTipoVenta.DataSource = FormPago.GetListTodosparaVentas().Tables(0)
        'ddlTipoVenta.ValueMember = "Codigo"
        'ddlTipoVenta.DisplayMember = "Nombre"

        Application.DoEvents()
        Combo(cbCultivo, ObtieneDatos("JAR_GetCultivos", EmpresaActual))
        cbCultivo.ItemIndex = 0

        Application.DoEvents()
        GridLookUp(cbProducto, ObtieneDatos("JAR_ProductosList", EmpresaActual), "NOMBRE", "CODIGO", 4, 3, 2, 1, 0)
        cbProducto.EditValue = "0"

        Application.DoEvents()
        GridLookUp(cbCliente, VB.SysContab.ClientesDB.ListaClientes("%", 0).Tables("CLIENTES"),
                "NOMBRE", "CODIGO", 3, 1, 0)
        cbCliente.Properties.PopupFormSize = New Point(1000, 0)

        Application.DoEvents()
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        sel1.DateTime = New DateTime(f.Year, f.Month, 1).Date
        sel3.DateTime = UltimoDiaDelMes(f.Date).Date            'New DateTime(f.Year, f.Month, Date.DaysInMonth(f.Year, f.Month))

        'Fill de los Campos del Informe
        LlenarGrid(sel1.DateTime, sel3.DateTime.AddMonths(-2).Date)
        FormatoPivot(iPivotGrid)

        'Application.DoEvents()
        'LlenarGrid(sel1.Value.AddMonths(2).Date, sel3.Value.Date)
        'Application.DoEvents()
        'FormatoPivot(iPivotGrid)
        'If MyDataset.Tables(0).Rows.Count > 0 Then
        '    PivotGrid.DataSource = MyDataset().Tables(0)
        '    Exit Sub
        'Else
        '    sel1.Value = New DateTime(Now.Year, Month(Now.AddMonths(-1)), 1) '"01/" & Month(Now.AddMonths(-1)) & "/" & Now.Year
        'End If
        'If MyDataset.Tables(0).Rows.Count > 0 Then
        '    PivotGrid.DataSource = MyDataset().Tables(0)
        '    Exit Sub
        'Else
        '    sel1.Value = New DateTime(Now.Year, Month(Now.AddMonths(-2)), 1) '"01/" & Month(Now.AddMonths(-2)) & "/" & Now.Year
        'End If
        'If MyDataset.Tables(0).Rows.Count > 0 Then
        '    PivotGrid.DataSource = MyDataset().Tables(0)
        '    Exit Sub
        'Else
        '    sel1.Value = New DateTime(Now.Year, Month(Now.AddMonths(-3)), 1) '"01/" & Month(Now.AddMonths(-3)) & "/" & Now.Year
        'End If
    End Sub

    Private Sub LlenarGrid(Desde As Date, Hasta As Date)
        ' Dim DT As DataTable = ObtieneDatos("_FacturasVentasCrossTab", EmpresaActual, _
        '                                                                cbCultivos.SelectedValue, Desde, _
        '                                                                Hasta, "", "", "", 0, cbMonedaCambio.EditValue, Usuario_ID)

        Dim DT As DataTable = ObtieneDatos("JAR_FacturasVentasCrossTab", Desde.Date,
                                             Hasta.Date,
                                             cbProducto.EditValue,
                                             IIf(CheckEdit1.Checked, cbCliente.EditValue, "0"),
                                             cbCultivo.EditValue,
                                             cbMonedaCambio.EditValue,
                                             EmpresaActual)

        iPivotGrid.DataSource = DT
        iPivotGrid.OptionsSelection.MultiSelect = True
        iPivotGrid.Fields.Clear()

        For i As Integer = 0 To DT.Columns.Count - 1
            Dim Campo As New DevExpress.XtraPivotGrid.PivotGridField
            iPivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Campo})
            Campo.FieldName = DT.Columns(i).Caption.ToString
            Campo.Caption = DT.Columns(i).Caption.ToString
            Campo.Name = "Field" & DT.Columns(i).Caption.ToString
            Campo.Visible = False
        Next

        iPivotGrid.Fields("Bodega").Visible = True
        iPivotGrid.Fields("Item").Visible = True
        iPivotGrid.Fields("Bodega").Visible = True
        iPivotGrid.Fields("Codigo").Visible = True
        iPivotGrid.Fields("Item").Visible = True
        iPivotGrid.Fields("Cantidad").Visible = True
        iPivotGrid.Fields("Precio").Visible = True
        iPivotGrid.Fields("Sub Total").Visible = True
        iPivotGrid.Fields("IVA").Visible = True
        iPivotGrid.Fields("Total").Visible = True
        iPivotGrid.Fields("Anno").Visible = True
        iPivotGrid.Fields("Mes").Visible = True
        '
        iPivotGrid.Fields("SubTotalConDesc").Visible = True
        iPivotGrid.Fields("Factura").Visible = True
        iPivotGrid.Fields("Cliente").Visible = True
        iPivotGrid.Fields("Fecha").Visible = True
        iPivotGrid.Fields("Vendedor").Visible = True
        iPivotGrid.Fields("Forma Pago").Visible = True
        iPivotGrid.Fields("Descuento").Visible = True
        iPivotGrid.Fields("Linea").Visible = True
        'iPivotGrid.Fields("Clase").Visible = True
        iPivotGrid.Fields("Grupo").Visible = True
        iPivotGrid.Fields("Sub Grupo").Visible = True
        iPivotGrid.Fields("Proveedor").Visible = True
        iPivotGrid.Fields("Costo Venta").Visible = True
        iPivotGrid.Fields("Margen").Visible = True
        iPivotGrid.Fields("Proyecto").Visible = True
        iPivotGrid.Fields("Departamento").Visible = True
        iPivotGrid.Fields("Cuenta Ingresos").Visible = True
        iPivotGrid.Fields("Tipo").Visible = True
        iPivotGrid.Fields("Fabricante").Visible = True
        '
        iPivotGrid.Fields("Bodega").Width = 200
        iPivotGrid.Fields("Item").Width = 200
        '
        iPivotGrid.Fields("Bodega").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Codigo").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        iPivotGrid.Fields("Item").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        '
        iPivotGrid.Fields("Cantidad").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Precio").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Sub Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("IVA").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        iPivotGrid.Fields("Total").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        '
        iPivotGrid.Fields("Anno").Caption = "Año"
        iPivotGrid.Fields("Anno").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        iPivotGrid.Fields("Mes").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        '
        iPivotGrid.Fields("Bodega").Caption = IIf(EmpresaActual = 1, "Sucursal", "Bodega")
        iPivotGrid.Fields("CodigoLetra").Caption = "Codigo Cliente"
        iPivotGrid.Fields("SubTotalConDesc").Caption = "Sub. con Descuento"
        iPivotGrid.Fields("Dias").Caption = "Días de Credito"
        iPivotGrid.Fields("MargenP").Caption = "Margen %"
        iPivotGrid.Fields("MargenProd").Caption = "Margen % Item"
        iPivotGrid.Fields("NUMERO").Caption = "Transacción"
        '
        iPivotGrid.Fields("Precio").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        iPivotGrid.Fields("MargenP").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        iPivotGrid.Fields("MargenProd").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        iPivotGrid.Fields("Costo Unitario").SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
    End Sub

    'Private Sub LoadClients()
    '    GetClientesList(ddlCliente)
    '    ddlCliente.Properties.Columns(0).Visible = True : ddlCliente.Properties.ShowHeader = True 'Para radioshack
    '    ddlCliente.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch 'Para radioshack
    'End Sub


    Private Sub pivotGridControl1_CellDoubleClick(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles iPivotGrid.CellDoubleClick

        Dim form As New FrmDetalleCrossTab
        form.Text = "Detalle de Ventas"
        form.StartPosition = FormStartPosition.CenterParent

        form.Grid.Parent = form
        form.Grid.Dock = DockStyle.Fill
        form.Grid.DataSource = e.CreateDrillDownDataSource()
        FormatoGrid(form.GridView1)
        form.Width = 800
        form.Height = 300
        form.ShowDialog()
        form.Dispose()
    End Sub
    Private Sub cmdexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexportar.Click
        My.Forms.frmExportarImprimir.Mostrar(
            iPivotGrid,
            NombreEmpresaActual,
            $"Reporte de Ventas del {sel1.DateTime.Date.ToShortDateString} Al {sel3.DateTime.Date.ToShortDateString}")
    End Sub

    Private Sub cmdGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrafico.Click
        'Dim forma As New frmgraficosxtra
        'forma.Mostrar(frmgraficosxtra.TipoGrafico.Ventas, iPivotGrid.CreateSummaryDataSource, False, iPivotGrid)
    End Sub

    Private Sub cmdguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdguardar.Click
        'If Guardar.ShowDialog = DialogResult.Cancel Then Exit Sub
        'MyDataset.WriteXml(Guardar.FileName)
    End Sub

    Private Sub cmdguardare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdguardare.Click
        If Guardar.ShowDialog = DialogResult.Cancel Then Exit Sub
        iPivotGrid.SaveLayoutToXml(Guardar.FileName)
    End Sub

    Private Sub cmdcargare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcargare.Click
        If Abrir.ShowDialog = DialogResult.Cancel Then Exit Sub
        iPivotGrid.RestoreLayoutFromXml(Abrir.FileName)
        iPivotGrid.Refresh()
    End Sub

    Private Sub cmdabrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdabrir.Click
        'If Abrir.ShowDialog = DialogResult.Cancel Then Exit Sub
        'MyDataset.ReadXml(Abrir.FileName)
        'iPivotGrid.Refresh()
        'iPivotGrid.RefreshData()
    End Sub

    Private Sub cmdnewgrap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnewgrap.Click
        frmGraficosDinamicos.Dispose()
        '
        With frmGraficosDinamicos

            .iGrafico.DataSource = iPivotGrid
            .iGrafico.SeriesDataMember = "Series"
            .iGrafico.SeriesTemplate.ArgumentDataMember = "Arguments"
            .iGrafico.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
            .iGrafico.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Bar)
            .etTitulo.Text = "Gráfico Dinámico de Ventas"
            '.MdiParent = Me.MdiParent

            .Show()
        End With

        'Dim forma As New frmgraficosxtra
        'forma.Mostrar(frmgraficosxtra.TipoGrafico.BalanzaComprobacion, PivotGrid.CreateSummaryDataSource, True, PivotGrid)
    End Sub


    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged

        cbCliente.Enabled = CheckEdit1.Checked


        'If Me.CheckEdit1.Checked Then
        '    LoadClients()
        '    Me.ddlCliente.Enabled = True
        'Else
        '    Me.ddlCliente.Properties.DataSource = Nothing
        '    Me.ddlCliente.Enabled = False
        'End If
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash()
        LlenarGrid(sel1.DateTime.Date, sel3.DateTime.Date)
        FormatoPivot(iPivotGrid)
        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ShowSplash()
        frmDinamicoDevoluciones.Dispose()
        frmDinamicoDevoluciones.etInicio.Text = "0"
        frmDinamicoDevoluciones.MdiParent = Me.MdiParent
        frmDinamicoDevoluciones.Show()
        frmDinamicoDevoluciones.WindowState = FormWindowState.Maximized
        frmDinamicoDevoluciones.etInicio.Text = "1"
        HideSplash()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        ShowSplash()
        frmDinamicoRebajas.Dispose()
        frmDinamicoRebajas.etInicio.Text = "0"
        frmDinamicoRebajas.MdiParent = Me.MdiParent
        frmDinamicoRebajas.Show()
        frmDinamicoRebajas.WindowState = FormWindowState.Maximized
        frmDinamicoDevoluciones.etInicio.Text = "1"
        HideSplash()
    End Sub


    'Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
    '    Me.iPivotGrid.OptionsView.ShowRowTotals = Not Me.CheckEdit2.Checked

    '    If CheckEdit2.Checked Then
    '        CheckEdit2.Text = "Mostrar Sub Totales en Filas"
    '    Else
    '        CheckEdit2.Text = "Ocultar Sub Totales en Filas"
    '    End If
    'End Sub

    Private Sub CheckEdit4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit4.CheckedChanged
        iPivotGrid.OptionsView.ShowRowTotals = Not CheckEdit4.Checked
        '
        If CheckEdit4.Checked Then
            CheckEdit4.Text = "Mostrar Sub Totales"
        Else
            CheckEdit4.Text = "Quitar Sub Totales"
        End If

    End Sub

    Private Sub CheckEdit3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit3.CheckedChanged
        iPivotGrid.OptionsView.ShowRowGrandTotals = Not CheckEdit3.Checked
        '
        If CheckEdit3.Checked Then
            CheckEdit3.Text = "Mostrar Gran Total"
        Else
            CheckEdit3.Text = "Quitar Gran Total"
        End If

    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        If CheckEdit2.Checked Then iPivotGrid.ShowCustomization()
        If Not CheckEdit2.Checked Then iPivotGrid.HideCustomization()
    End Sub

    Private Sub iPivotGrid_HideCustomizationForm(sender As Object, e As EventArgs) Handles iPivotGrid.HideCustomizationForm
        CheckEdit2.Checked = False
    End Sub

End Class

