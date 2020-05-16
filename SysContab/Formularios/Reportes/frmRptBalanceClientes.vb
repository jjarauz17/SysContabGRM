Imports DevExpress.XtraReports.UI
Imports System.IO

Public Class frmRptBalanceClientes
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmRptBalanceClientes = Nothing
    Public TReporte As String  ' "C" para Clientes "P" para Proveedores

    Dim r As New VB.SysContab.RutinasNomina()
    Dim TC As New VB.SysContab.Tasa_CambioDB()
    Private Empresa As New VB.SysContab.EmpresasDetails()
    Friend WithEvents dtpHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Desde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents chkRetencion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lyRet As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCategoria As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lyCategoria As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkdetalle As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lyDetalle As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkCorte As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents AlertControl2 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents cbRubro As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lyRubro As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lyProximasVencer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lyGarantias As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCheckSucursal As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents lySucursales As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCliente As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lyCliente As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkPorCliente As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lyPorCliente As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkDistribuidor As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lyDistribuidores As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbVendedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bRestaurarEsquema As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardarEsquema As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Guardar As SaveFileDialog
    Friend WithEvents Abrir As OpenFileDialog
    Private Empresas As New VB.SysContab.EmpresasDB()

    Public Shared Function Instance() As frmRptBalanceClientes
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmRptBalanceClientes
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptBalanceClientes))
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbVendedor = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkDistribuidor = New DevExpress.XtraEditors.CheckEdit()
        Me.chkPorCliente = New DevExpress.XtraEditors.CheckEdit()
        Me.cbCliente = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCheckSucursal = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.cbRubro = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkCorte = New DevExpress.XtraEditors.CheckEdit()
        Me.chkdetalle = New DevExpress.XtraEditors.CheckEdit()
        Me.cbCategoria = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkRetencion = New DevExpress.XtraEditors.CheckEdit()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Desde = New DevExpress.XtraEditors.DateEdit()
        Me.dtpHasta = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyRet = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyDetalle = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lyCliente = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyPorCliente = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyRubro = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lySucursales = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyCategoria = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyGarantias = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyDistribuidores = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.bRestaurarEsquema = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardarEsquema = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyProximasVencer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.AlertControl2 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.Guardar = New System.Windows.Forms.SaveFileDialog()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbVendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDistribuidor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPorCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCheckSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRubro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCorte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkdetalle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRetencion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyRet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyPorCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyRubro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lySucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyGarantias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyDistribuidores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyProximasVencer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Enabled = False
        Me.Hasta.Location = New System.Drawing.Point(233, 62)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Hasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Hasta.Size = New System.Drawing.Size(123, 20)
        Me.Hasta.StyleController = Me.LayoutControl1
        Me.Hasta.TabIndex = 31
        Me.Hasta.Visible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbVendedor)
        Me.LayoutControl1.Controls.Add(Me.chkDistribuidor)
        Me.LayoutControl1.Controls.Add(Me.chkPorCliente)
        Me.LayoutControl1.Controls.Add(Me.cbCliente)
        Me.LayoutControl1.Controls.Add(Me.cbCheckSucursal)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.cbRubro)
        Me.LayoutControl1.Controls.Add(Me.chkCorte)
        Me.LayoutControl1.Controls.Add(Me.chkdetalle)
        Me.LayoutControl1.Controls.Add(Me.cbCategoria)
        Me.LayoutControl1.Controls.Add(Me.chkRetencion)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.dgDatos)
        Me.LayoutControl1.Controls.Add(Me.Desde)
        Me.LayoutControl1.Controls.Add(Me.Hasta)
        Me.LayoutControl1.Controls.Add(Me.dtpHasta)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(634, 278, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(848, 476)
        Me.LayoutControl1.TabIndex = 7
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbVendedor
        '
        Me.cbVendedor.Location = New System.Drawing.Point(442, 38)
        Me.cbVendedor.Name = "cbVendedor"
        Me.cbVendedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbVendedor.Size = New System.Drawing.Size(250, 20)
        Me.cbVendedor.StyleController = Me.LayoutControl1
        Me.cbVendedor.TabIndex = 33
        '
        'chkDistribuidor
        '
        Me.chkDistribuidor.Location = New System.Drawing.Point(679, 88)
        Me.chkDistribuidor.Name = "chkDistribuidor"
        Me.chkDistribuidor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDistribuidor.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkDistribuidor.Properties.Appearance.Options.UseFont = True
        Me.chkDistribuidor.Properties.Appearance.Options.UseForeColor = True
        Me.chkDistribuidor.Properties.Caption = "&Solo Distribuidores"
        Me.chkDistribuidor.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkDistribuidor.Size = New System.Drawing.Size(157, 22)
        Me.chkDistribuidor.StyleController = Me.LayoutControl1
        Me.chkDistribuidor.TabIndex = 35
        '
        'chkPorCliente
        '
        Me.chkPorCliente.Location = New System.Drawing.Point(12, 114)
        Me.chkPorCliente.Name = "chkPorCliente"
        Me.chkPorCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPorCliente.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkPorCliente.Properties.Appearance.Options.UseFont = True
        Me.chkPorCliente.Properties.Appearance.Options.UseForeColor = True
        Me.chkPorCliente.Properties.Caption = "&Por Cliente:"
        Me.chkPorCliente.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkPorCliente.Size = New System.Drawing.Size(104, 22)
        Me.chkPorCliente.StyleController = Me.LayoutControl1
        Me.chkPorCliente.TabIndex = 36
        '
        'cbCliente
        '
        Me.cbCliente.Enabled = False
        Me.cbCliente.Location = New System.Drawing.Point(120, 114)
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
        Me.cbCliente.Properties.PopupView = Me.GridLookUpEdit1View
        Me.cbCliente.Size = New System.Drawing.Size(555, 20)
        Me.cbCliente.StyleController = Me.LayoutControl1
        Me.cbCliente.TabIndex = 9
        Me.cbCliente.Tag = "True"
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'cbCheckSucursal
        '
        Me.cbCheckSucursal.Location = New System.Drawing.Point(102, 64)
        Me.cbCheckSucursal.Name = "cbCheckSucursal"
        Me.cbCheckSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCheckSucursal.Properties.Appearance.Options.UseFont = True
        Me.cbCheckSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCheckSucursal.Size = New System.Drawing.Size(320, 20)
        Me.cbCheckSucursal.StyleController = Me.LayoutControl1
        Me.cbCheckSucursal.TabIndex = 36
        '
        'CheckEdit1
        '
        Me.CheckEdit1.EditValue = True
        Me.CheckEdit1.Location = New System.Drawing.Point(679, 114)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "&Quitar Garantias"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(157, 22)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 34
        '
        'cbRubro
        '
        Me.cbRubro.Location = New System.Drawing.Point(102, 88)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRubro.Properties.Appearance.Options.UseFont = True
        Me.cbRubro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbRubro.Properties.ShowFooter = False
        Me.cbRubro.Properties.ShowHeader = False
        Me.cbRubro.Size = New System.Drawing.Size(573, 22)
        Me.cbRubro.StyleController = Me.LayoutControl1
        Me.cbRubro.TabIndex = 9
        '
        'chkCorte
        '
        Me.chkCorte.EditValue = True
        Me.chkCorte.Location = New System.Drawing.Point(260, 12)
        Me.chkCorte.Name = "chkCorte"
        Me.chkCorte.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCorte.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkCorte.Properties.Appearance.Options.UseFont = True
        Me.chkCorte.Properties.Appearance.Options.UseForeColor = True
        Me.chkCorte.Properties.Caption = "&Al Corte"
        Me.chkCorte.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkCorte.Size = New System.Drawing.Size(78, 22)
        Me.chkCorte.StyleController = Me.LayoutControl1
        Me.chkCorte.TabIndex = 35
        '
        'chkdetalle
        '
        Me.chkdetalle.Location = New System.Drawing.Point(696, 38)
        Me.chkdetalle.Name = "chkdetalle"
        Me.chkdetalle.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkdetalle.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkdetalle.Properties.Appearance.Options.UseFont = True
        Me.chkdetalle.Properties.Appearance.Options.UseForeColor = True
        Me.chkdetalle.Properties.Caption = "&Ver Detalle"
        Me.chkdetalle.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkdetalle.Size = New System.Drawing.Size(140, 22)
        Me.chkdetalle.StyleController = Me.LayoutControl1
        Me.chkdetalle.TabIndex = 34
        '
        'cbCategoria
        '
        Me.cbCategoria.Location = New System.Drawing.Point(516, 64)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCategoria.Size = New System.Drawing.Size(320, 20)
        Me.cbCategoria.StyleController = Me.LayoutControl1
        Me.cbCategoria.TabIndex = 33
        '
        'chkRetencion
        '
        Me.chkRetencion.Location = New System.Drawing.Point(696, 12)
        Me.chkRetencion.Name = "chkRetencion"
        Me.chkRetencion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRetencion.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkRetencion.Properties.Appearance.Options.UseFont = True
        Me.chkRetencion.Properties.Appearance.Options.UseForeColor = True
        Me.chkRetencion.Properties.Caption = "&Quitar Retenciones"
        Me.chkRetencion.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkRetencion.Size = New System.Drawing.Size(140, 22)
        Me.chkRetencion.StyleController = Me.LayoutControl1
        Me.chkRetencion.TabIndex = 33
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(102, 38)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Size = New System.Drawing.Size(246, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 32
        '
        'dgDatos
        '
        Me.dgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDatos.Location = New System.Drawing.Point(12, 140)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(824, 324)
        Me.dgDatos.TabIndex = 6
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.GroupPanelText = "Arrastrar Columna Para Agrupar"
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsBehavior.Editable = False
        Me.vDatos.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowChildrenInGroupPanel = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupedColumns = True
        '
        'Desde
        '
        Me.Desde.EditValue = Nothing
        Me.Desde.Enabled = False
        Me.Desde.Location = New System.Drawing.Point(59, 88)
        Me.Desde.Name = "Desde"
        Me.Desde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desde.Properties.Appearance.Options.UseFont = True
        Me.Desde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Desde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Desde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.Desde.Size = New System.Drawing.Size(297, 20)
        Me.Desde.StyleController = Me.LayoutControl1
        Me.Desde.TabIndex = 30
        Me.Desde.Visible = False
        '
        'dtpHasta
        '
        Me.dtpHasta.EditValue = Nothing
        Me.dtpHasta.Location = New System.Drawing.Point(102, 12)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Properties.Appearance.Options.UseFont = True
        Me.dtpHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpHasta.Size = New System.Drawing.Size(154, 20)
        Me.dtpHasta.StyleController = Me.LayoutControl1
        Me.dtpHasta.TabIndex = 28
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Hasta
        Me.LayoutControlItem3.CustomizationFormText = "Desde"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(174, 50)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(174, 26)
        Me.LayoutControlItem3.Text = "Desde"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Desde
        Me.LayoutControlItem4.CustomizationFormText = "Hasta"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(348, 69)
        Me.LayoutControlItem4.Text = "Hasta"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem8, Me.LayoutControlItem2, Me.lyRet, Me.lyDetalle, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.lyCliente, Me.lyPorCliente, Me.lyRubro, Me.lySucursales, Me.lyCategoria, Me.lyGarantias, Me.lyDistribuidores, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(848, 476)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbMoneda
        Me.LayoutControlItem5.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(340, 26)
        Me.LayoutControlItem5.Text = "Moneda:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.dgDatos
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 128)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(828, 328)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtpHasta
        Me.LayoutControlItem2.CustomizationFormText = "Al Corte:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(248, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(248, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(248, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Al Corte:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(87, 13)
        '
        'lyRet
        '
        Me.lyRet.Control = Me.chkRetencion
        Me.lyRet.CustomizationFormText = "lyRet"
        Me.lyRet.Location = New System.Drawing.Point(684, 0)
        Me.lyRet.MaxSize = New System.Drawing.Size(144, 26)
        Me.lyRet.MinSize = New System.Drawing.Size(144, 26)
        Me.lyRet.Name = "lyRet"
        Me.lyRet.Size = New System.Drawing.Size(144, 26)
        Me.lyRet.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyRet.TextSize = New System.Drawing.Size(0, 0)
        Me.lyRet.TextVisible = False
        '
        'lyDetalle
        '
        Me.lyDetalle.Control = Me.chkdetalle
        Me.lyDetalle.CustomizationFormText = "lyDetalle"
        Me.lyDetalle.Location = New System.Drawing.Point(684, 26)
        Me.lyDetalle.MaxSize = New System.Drawing.Size(144, 26)
        Me.lyDetalle.MinSize = New System.Drawing.Size(144, 26)
        Me.lyDetalle.Name = "lyDetalle"
        Me.lyDetalle.Size = New System.Drawing.Size(144, 26)
        Me.lyDetalle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyDetalle.TextSize = New System.Drawing.Size(0, 0)
        Me.lyDetalle.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.chkCorte
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(248, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(82, 26)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(82, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(82, 26)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(330, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(354, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lyCliente
        '
        Me.lyCliente.Control = Me.cbCliente
        Me.lyCliente.Location = New System.Drawing.Point(108, 102)
        Me.lyCliente.Name = "lyCliente"
        Me.lyCliente.Size = New System.Drawing.Size(559, 26)
        Me.lyCliente.Text = "Cliente:"
        Me.lyCliente.TextSize = New System.Drawing.Size(0, 0)
        Me.lyCliente.TextVisible = False
        '
        'lyPorCliente
        '
        Me.lyPorCliente.Control = Me.chkPorCliente
        Me.lyPorCliente.Location = New System.Drawing.Point(0, 102)
        Me.lyPorCliente.MaxSize = New System.Drawing.Size(108, 26)
        Me.lyPorCliente.MinSize = New System.Drawing.Size(108, 26)
        Me.lyPorCliente.Name = "lyPorCliente"
        Me.lyPorCliente.Size = New System.Drawing.Size(108, 26)
        Me.lyPorCliente.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyPorCliente.TextSize = New System.Drawing.Size(0, 0)
        Me.lyPorCliente.TextVisible = False
        '
        'lyRubro
        '
        Me.lyRubro.Control = Me.cbRubro
        Me.lyRubro.CustomizationFormText = "Rubro:"
        Me.lyRubro.Location = New System.Drawing.Point(0, 76)
        Me.lyRubro.Name = "lyRubro"
        Me.lyRubro.Size = New System.Drawing.Size(667, 26)
        Me.lyRubro.Text = "Rubro:"
        Me.lyRubro.TextSize = New System.Drawing.Size(87, 13)
        '
        'lySucursales
        '
        Me.lySucursales.Control = Me.cbCheckSucursal
        Me.lySucursales.Location = New System.Drawing.Point(0, 52)
        Me.lySucursales.Name = "lySucursales"
        Me.lySucursales.Size = New System.Drawing.Size(414, 24)
        Me.lySucursales.Text = "Sucursal:"
        Me.lySucursales.TextSize = New System.Drawing.Size(87, 13)
        '
        'lyCategoria
        '
        Me.lyCategoria.Control = Me.cbCategoria
        Me.lyCategoria.CustomizationFormText = "Categoria Cliente:"
        Me.lyCategoria.Location = New System.Drawing.Point(414, 52)
        Me.lyCategoria.Name = "lyCategoria"
        Me.lyCategoria.Size = New System.Drawing.Size(414, 24)
        Me.lyCategoria.Text = "Categoria Cliente:"
        Me.lyCategoria.TextSize = New System.Drawing.Size(87, 13)
        '
        'lyGarantias
        '
        Me.lyGarantias.Control = Me.CheckEdit1
        Me.lyGarantias.Location = New System.Drawing.Point(667, 102)
        Me.lyGarantias.MaxSize = New System.Drawing.Size(161, 26)
        Me.lyGarantias.MinSize = New System.Drawing.Size(161, 26)
        Me.lyGarantias.Name = "lyGarantias"
        Me.lyGarantias.Size = New System.Drawing.Size(161, 26)
        Me.lyGarantias.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyGarantias.TextSize = New System.Drawing.Size(0, 0)
        Me.lyGarantias.TextVisible = False
        '
        'lyDistribuidores
        '
        Me.lyDistribuidores.Control = Me.chkDistribuidor
        Me.lyDistribuidores.Location = New System.Drawing.Point(667, 76)
        Me.lyDistribuidores.MaxSize = New System.Drawing.Size(161, 26)
        Me.lyDistribuidores.MinSize = New System.Drawing.Size(161, 26)
        Me.lyDistribuidores.Name = "lyDistribuidores"
        Me.lyDistribuidores.Size = New System.Drawing.Size(161, 26)
        Me.lyDistribuidores.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyDistribuidores.TextSize = New System.Drawing.Size(0, 0)
        Me.lyDistribuidores.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbVendedor
        Me.LayoutControlItem6.Location = New System.Drawing.Point(340, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(344, 26)
        Me.LayoutControlItem6.Text = "Asesor de Venta:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(87, 13)
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 359)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(114, 36)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "&Diseño"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.bRestaurarEsquema)
        Me.LayoutControl2.Controls.Add(Me.bGuardarEsquema)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1020, 176, 450, 400)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(138, 447)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'bRestaurarEsquema
        '
        Me.bRestaurarEsquema.Appearance.Options.UseTextOptions = True
        Me.bRestaurarEsquema.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bRestaurarEsquema.ImageOptions.Image = CType(resources.GetObject("bRestaurarEsquema.ImageOptions.Image"), System.Drawing.Image)
        Me.bRestaurarEsquema.Location = New System.Drawing.Point(12, 136)
        Me.bRestaurarEsquema.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bRestaurarEsquema.Name = "bRestaurarEsquema"
        Me.bRestaurarEsquema.Size = New System.Drawing.Size(112, 38)
        Me.bRestaurarEsquema.StyleController = Me.LayoutControl2
        Me.bRestaurarEsquema.TabIndex = 10
        Me.bRestaurarEsquema.Text = "&Restaurar Esquema"
        '
        'bGuardarEsquema
        '
        Me.bGuardarEsquema.Appearance.Options.UseTextOptions = True
        Me.bGuardarEsquema.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bGuardarEsquema.ImageOptions.Image = CType(resources.GetObject("bGuardarEsquema.ImageOptions.Image"), System.Drawing.Image)
        Me.bGuardarEsquema.Location = New System.Drawing.Point(12, 94)
        Me.bGuardarEsquema.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bGuardarEsquema.Name = "bGuardarEsquema"
        Me.bGuardarEsquema.Size = New System.Drawing.Size(112, 38)
        Me.bGuardarEsquema.StyleController = Me.LayoutControl2
        Me.bGuardarEsquema.TabIndex = 9
        Me.bGuardarEsquema.Text = "&Guardar Esquema"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Options.UseTextOptions = True
        Me.SimpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 52)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(112, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl2
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "&Próximas a Vencer"
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 399)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(114, 36)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 12)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(114, 36)
        Me.cmdImprimir.StyleController = Me.LayoutControl2
        Me.cmdImprimir.TabIndex = 0
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.ImageOptions.Image = CType(resources.GetObject("cmdAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAyuda.Location = New System.Drawing.Point(12, 319)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(114, 36)
        Me.cmdAyuda.StyleController = Me.LayoutControl2
        Me.cmdAyuda.TabIndex = 2
        Me.cmdAyuda.Text = "&Exportar"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.lyProximasVencer, Me.EmptySpaceItem2, Me.LayoutControlItem7, Me.LayoutControlItem13})
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(138, 447)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdImprimir
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(118, 40)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdAyuda
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 307)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(118, 40)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SimpleButton1
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 347)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(118, 40)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdSalir
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 387)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(118, 40)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'lyProximasVencer
        '
        Me.lyProximasVencer.Control = Me.SimpleButton2
        Me.lyProximasVencer.CustomizationFormText = "lyProximasVencer"
        Me.lyProximasVencer.Location = New System.Drawing.Point(0, 40)
        Me.lyProximasVencer.MaxSize = New System.Drawing.Size(116, 42)
        Me.lyProximasVencer.MinSize = New System.Drawing.Size(116, 42)
        Me.lyProximasVencer.Name = "lyProximasVencer"
        Me.lyProximasVencer.Size = New System.Drawing.Size(118, 42)
        Me.lyProximasVencer.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyProximasVencer.TextSize = New System.Drawing.Size(0, 0)
        Me.lyProximasVencer.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 166)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(118, 141)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bGuardarEsquema
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 82)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.bRestaurarEsquema
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("00bb3b74-1774-4ae4-b660-fcf3e35d842f")
        Me.DockPanel1.Location = New System.Drawing.Point(848, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(145, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(145, 476)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(138, 447)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'AlertControl1
        '
        Me.AlertControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red
        Me.AlertControl1.AppearanceCaption.Options.UseFont = True
        Me.AlertControl1.AppearanceCaption.Options.UseForeColor = True
        Me.AlertControl1.AppearanceText.ForeColor = System.Drawing.Color.MediumBlue
        Me.AlertControl1.AppearanceText.Options.UseForeColor = True
        Me.AlertControl1.AutoFormDelay = 10000
        Me.AlertControl1.AutoHeight = True
        Me.AlertControl1.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Slow
        Me.AlertControl1.FormMaxCount = 2
        '
        'AlertControl2
        '
        Me.AlertControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertControl2.AppearanceCaption.ForeColor = System.Drawing.Color.LightCoral
        Me.AlertControl2.AppearanceCaption.Options.UseFont = True
        Me.AlertControl2.AppearanceCaption.Options.UseForeColor = True
        Me.AlertControl2.AppearanceText.ForeColor = System.Drawing.Color.MediumBlue
        Me.AlertControl2.AppearanceText.Options.UseForeColor = True
        Me.AlertControl2.AutoHeight = True
        Me.AlertControl2.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Slow
        Me.AlertControl2.FormMaxCount = 2
        '
        'Guardar
        '
        Me.Guardar.Filter = "(*.xml)|*.xml"
        '
        'Abrir
        '
        Me.Abrir.DefaultExt = "*.xml"
        Me.Abrir.Filter = "(*.xml)|*.xml"
        '
        'frmRptBalanceClientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(993, 476)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmRptBalanceClientes"
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbVendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDistribuidor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPorCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCheckSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRubro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCorte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkdetalle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRetencion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyRet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyPorCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyRubro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lySucursales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyGarantias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyDistribuidores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyProximasVencer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FacturasVencidas As Integer = 0
    Dim FvProximasVencer As Integer = 0
    Public Alerta As Boolean = False

    Private Sub frmRptPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Empresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        Dim Fecha As Date = VB.SysContab.Rutinas.Fecha().Date

        Me.dtpHasta.DateTime = Fecha
        Desde.DateTime = Fecha
        Hasta.DateTime = Fecha

        Application.DoEvents()
        GetMonedasList(cbMoneda)
        Application.DoEvents()
        GetVendedores(cbVendedor, 1)
        cbVendedor.ItemIndex = 0
        Application.DoEvents()
        'Combo(cbCategoria, ObtieneDatos("JAR_GetClienteCategoria", EmpresaActual))
        LookUp(cbCategoria, ObtieneDatos("JAR_GetClienteCategoria", EmpresaActual), "Nombre", "Codigo", "[Categoria de Cliente]", 0)
        cbCategoria.ItemIndex = 0
        Application.DoEvents()
        GridLookUp(cbCliente, ObtieneDatos("PNR_GetClientes", EmpresaActual),
                   "Nombre", "Codigo", 0, 1, 2)
        cbCliente.Properties.PopupFormSize = New Point(1000, 0)
        Application.DoEvents()

        If TReporte = "C" Then
            FacturasVencidas = ObtieneDatos("JAR_GetFacturasVencidas", EmpresaActual, 2).Rows.Item(0)("CANTIDAD")
            FvProximasVencer = ObtieneDatos("JAR_GetFacturasProximasAVencer", EmpresaActual, 2).Rows.Item(0)("CANTIDAD")

            ' lyProximasVencer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

            If Alerta Then IniciaContador(1000)

            If EmpresaActual <> "1" Then
                lySucursales.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                lyGarantias.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                lyDistribuidores.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Else
                'Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesClientes", EmpresaActual))
                'cbSucursal.ItemIndex = 0

                Combo(cbCheckSucursal, ObtieneDatos("JAR_GetSucursalesxUsuario", EmpresaActual))
                cbCheckSucursal.CheckAll()

                'lyCategoria.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            End If

            lyPorCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lyCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

            LookUp(cbRubro, ObtieneDatos("JAR_GetRubrosClientesxUsuario", EmpresaActual), "Display", "Cuenta", "[Seleccione Rubro]", 2)
            cbRubro.ItemIndex = 0

            Me.Text = "Balance de Saldos de Clientes"

            Dim dtRpt As DataTable = ObtieneDatos("SPRptAnalisisAntiguedad_x_Sucursal", 0, IIf(chkPorCliente.Checked, cbCliente.EditValue, 0), cbVendedor.EditValue,
                                          dtpHasta.DateTime.Date,
                                          cbMoneda.EditValue,
                                          "XXXX",
                                          IIf(chkRetencion.Checked, 1, 0),
                                          cbCategoria.EditValue,
                                          1, 0,
                                          cbRubro.EditValue, IIf(chkDistribuidor.Checked, 1, 0))
            dgDatos.DataSource = dtRpt
            vDatos.PopulateColumns()
            FormatoGrid(Me.vDatos, 2, 0, False)
            ''
            vDatos.Columns("Direccion").Visible = False
            vDatos.Columns("Limite").Visible = False
            vDatos.Columns("Titulo").Visible = False
            vDatos.Columns("Empresa").Visible = False
            vDatos.Columns("Credito").Visible = False
            vDatos.Columns("Ruc").Visible = False
            vDatos.Columns("Cedula").Visible = False
            vDatos.Columns("Contacto 1").Visible = False
            vDatos.Columns("Contacto 2").Visible = False
            vDatos.Columns("Tel. Contacto 1").Visible = False
            vDatos.Columns("Tel. Contacto 2").Visible = False
            vDatos.Columns("Departamento").Visible = False
            vDatos.Columns("Municipio").Visible = False
            vDatos.Columns("Tipo").Visible = False
            vDatos.Columns("Telefono").Visible = False
            vDatos.Columns("Correo").Visible = False
            '
            vDatos.Columns("Treinta").Caption = "[A 30 Días]"
            vDatos.Columns("Sesenta").Caption = "[A 60 Días]"
            vDatos.Columns("Noventa").Caption = "[A 90 Días]"
            vDatos.Columns("120").Caption = "[A 120 Días]"
            vDatos.Columns("150").Caption = "[A 150 Días]"
            vDatos.Columns("180").Caption = "[A 180 Días]"
            vDatos.Columns("Mas180").Caption = "[Más 180 Días]"
            vDatos.Columns("270").Caption = "[A 270 Días]"
            vDatos.Columns("365").Caption = "[A 365 Días]"
            vDatos.Columns("1Año").Caption = "[1 Años]"
            vDatos.Columns("2Años").Caption = "[2 Años]"
            vDatos.Columns("3Años").Caption = "[3 Años]"
            vDatos.Columns("4Años").Caption = "[4 Años]"
            vDatos.Columns("Mas 4Años").Caption = "[Más 4 Años]"
            'vDatos.Columns("5Años").Caption = "5 Años"
            'vDatos.Columns("Mas 5Años").Caption = "Mas 5 Años"
        Else
            lyCategoria.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyRet.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            'lySucursal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lySucursales.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyGarantias.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '  lyDetalle.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            'lyRubro.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lyDistribuidores.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            Me.cbRubro.Properties.DataSource = ObtieneDatos("sp_GetTiposProveedores " & EmpresaActual)
            Me.cbRubro.Properties.ValueMember = "CUENTA"
            Me.cbRubro.Properties.DisplayMember = "Display"
            Me.cbRubro.Properties.PopulateColumns()
            Me.cbRubro.Properties.Columns("Display").Visible = False
            Me.cbRubro.ItemIndex = 0

            lyPorCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            ' lyProximasVencer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            Me.Text = "Balance de Saldos de Proveedores"

            Dim dtRpt As DataTable = ObtieneDatos("SPRptAnalisisAntiguedad_CxP", dtpHasta.DateTime.Date,
                                                 cbRubro.EditValue, 0, cbMoneda.EditValue)


            dgDatos.DataSource = dtRpt
            vDatos.PopulateColumns()
            FormatoGrid(Me.vDatos, 2, 0, False)
            ''
            vDatos.Columns("Empresa").Visible = False
            vDatos.Columns("TipoProveedor").Visible = False
            vDatos.Columns("Titulo").Visible = False
            vDatos.Columns("Encabezado").Visible = False
        End If

        LeerEsquemaInicial()

        'Me.cbSucursal.Properties.DataSource = ObtieneDatos("sp_GetSucursalesClientes " & EmpresaActual)
        'Me.cbSucursal.Properties.ValueMember = "Cliente"
        'Me.cbSucursal.Properties.DisplayMember = "Cliente"
        'Me.cbSucursal.Properties.PopulateColumns()
        'Me.cbSucursal.ItemIndex = 0
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'Dim TCambio As Double
        'Dim ds As New DataSet

        'Dim fReportes As New frmReportes
        'ds = TC.GetTasaCambio(Empresa.MonedaBase, cbMoneda.EditValue, Me.dtpHasta.DateTime.Date)

        'If IsNothing(ds) Or ds.Tables(0).Rows.Count = 0 Then
        '    XtraMsg("Error al buscar la tasa de cambio del dia", MessageBoxIcon.Error)
        '    Exit Sub
        'Else
        '    TCambio = 1 / IIf(ds.Tables(0).Rows(0)("TCambio") = 0, 1, ds.Tables(0).Rows(0)("TCambio"))
        'End If

        'Solo para Ramac
        If EmpresaActual = "1" And
            TReporte = "C" Then
            If cbCheckSucursal.EditValue = "" Or
                cbCheckSucursal.EditValue Is Nothing Then
                XtraMsg("Seleccione la Sucursal")
                cbCheckSucursal.Focus()
                Exit Sub
            End If
        End If

        ShowSplash()
        ''
        If Me.TReporte = "C" Then
            If chkPorCliente.Checked Then
                If cbCliente.EditValue Is Nothing Then
                    XtraMsg("Seleccione el Cliente")
                    cbCliente.Focus()
                    Exit Sub
                End If
            End If


            If chkCorte.Checked Then    'Antiguedad de Saldos al Corte

                'Dim Rep As New RptAnalisisAntiguedad
                'Dim Variables As New ArrayList
                'Dim Datos As New ArrayList
                'Variables.Add("Fecha")
                'Variables.Add("Empresa")
                'Variables.Add("Moneda")
                'Variables.Add("Sucursal")
                'Datos.Add(IsNull(dtpHasta.DateTime.Date, Now.Date))
                'Datos.Add(EmpresaActual)
                'Datos.Add(cbMonedaCambio.SelectedIndex)
                'Datos.Add(IIf(Me.cbSucursal.ItemIndex = 0, "%", Me.cbSucursal.EditValue))

                'Dim Cadena As String
                'Dim Temp As Boolean = False
                'Dim Data() As Byte

                ShowSplash("Imprimiendo...")

                'Try
                '    Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 22 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
                '    Temp = True
                '    Dim Tamano As Integer
                '    Tamano = Data.GetUpperBound(0)
                '    Cadena = Application.StartupPath & "\rptAntiguedad.repx"
                '    If File.Exists(Cadena) Then Kill(Cadena)
                '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
                '    Archivo.Write(Data, 0, Tamano)
                '    Archivo.Close()
                'Catch ex As Exception
                '    Temp = False
                'End Try

                Dim Temp As Boolean = db_Formatos.FormatoImpreso(22, "rptAntiguedad")

                Dim rpt As RptAnalisisAntiguedad

                If Temp = True Then
                    rpt = XtraReport.FromFile(Application.StartupPath & "\rptAntiguedad.repx", True)
                Else
                    rpt = New RptAnalisisAntiguedad
                End If

                rpt.Detalle = chkdetalle.Checked
                rpt.Encabezado.Text = "ANTIGUEDAD DE SALDO DE CLIENTES" & vbCrLf & IIf(cbRubro.ItemIndex = 0, "", cbRubro.Text)

                'Dim dtRpt As DataTable = ObtieneDatos("SPRptAnalisisAntiguedad", EmpresaActual, 0, 0, _
                '                              dtpHasta.DateTime.Date, cbMoneda.EditValue, _
                '                              IIf(Me.cbSucursal.ItemIndex = 0, "%", Me.cbSucursal.EditValue), _
                '                              IIf(chkRetencion.Checked, 1, 0), cbCategoria.EditValue, _
                '                              IIf(chkdetalle.Checked, 1, 0), IIf(CheckEdit1.Checked, 0, 1))

                Dim Suc As String = IIf(EmpresaActual <> "1", "%", cbCheckSucursal.EditValue)

                Dim dtRpt As DataTable = ObtieneDatos("SPRptAnalisisAntiguedad_x_Sucursal", EmpresaActual,
                                                      IIf(chkPorCliente.Checked, cbCliente.EditValue, 0),
                                                      cbVendedor.EditValue,
                                                      dtpHasta.DateTime.Date,
                                                      cbMoneda.EditValue,
                                                      Suc,
                                                      IIf(chkRetencion.Checked, 1, 0),
                                                      cbCategoria.EditValue,
                                                      IIf(chkdetalle.Checked, 1, 0), IIf(CheckEdit1.Checked, 0, 1),
                                                      cbRubro.EditValue, IIf(chkDistribuidor.Checked, 1, 0))

                rpt.XrPictureBox1.Image = frmPrincipalRibbon.pLogo.Image
                VistaPreviaDX(rpt, dtRpt, "Antiguedad de Saldos de Clientes")

                'rpt.DataSource = dtRpt
                'rpt.ShowPrintMarginsWarning = False
                'rpt.BringToFront()
                'rpt.ShowRibbonPreview()
                ''
                dgDatos.DataSource = dtRpt


                'Me.vDatos.PopulateColumns()
                'FormatoGrid(Me.vDatos, 2, 0, False)
                '''
                'Me.vDatos.Columns("Direccion").Visible = False
                'Me.vDatos.Columns("Limite").Visible = False
                'Me.vDatos.Columns("Titulo").Visible = False
                'Me.vDatos.Columns("Empresa").Visible = False
                'Me.vDatos.Columns("Credito").Visible = False

                'vDatos.Columns("Treinta").Caption = "1-30 Días"
                'vDatos.Columns("Sesenta").Caption = "31-60 Días"
                'vDatos.Columns("Noventa").Caption = "61-90 Días"
                'vDatos.Columns("120").Caption = "91-120 Días"
                'vDatos.Columns("150").Caption = "121-150 Días"
                'vDatos.Columns("180").Caption = "151-180 Días"
                'vDatos.Columns("Mas180").Caption = "Mas 180 Días"
                'vDatos.Columns("270").Caption = "181-270 Días"
                'vDatos.Columns("365").Caption = "1 Año"
                'vDatos.Columns("2Años").Caption = "2 Años"
                'vDatos.Columns("3Años").Caption = "3 Años"
                'vDatos.Columns("4Años").Caption = "4 Años"
                'vDatos.Columns("5Años").Caption = "5 Años"
                'vDatos.Columns("Mas 5Años").Caption = "Mas 5 Años"


                'Me.vDatos.Columns("Original").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                'Me.vDatos.Columns("Original").DisplayFormat.FormatString = "{0:n2}"
                'Me.vDatos.Columns("Original").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                'Me.vDatos.Columns("Original").SummaryItem.DisplayFormat = "{0:n2}"

                'Me.vDatos.Columns("Abono").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                'Me.vDatos.Columns("Abono").DisplayFormat.FormatString = "{0:n2}"
                'Me.vDatos.Columns("Abono").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                'Me.vDatos.Columns("Abono").SummaryItem.DisplayFormat = "{0:n2}"
                ' ''
                'Me.vDatos.Columns("Corriente").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                'Me.vDatos.Columns("Corriente").DisplayFormat.FormatString = "{0:n2}"
                'Me.vDatos.Columns("Corriente").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                'Me.vDatos.Columns("Corriente").SummaryItem.DisplayFormat = "{0:n2}"
                ' ''
                'Me.vDatos.Columns("Treinta").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                'Me.vDatos.Columns("Treinta").DisplayFormat.FormatString = "{0:n2}"
                'Me.vDatos.Columns("Treinta").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                'Me.vDatos.Columns("Treinta").SummaryItem.DisplayFormat = "{0:n2}"
                ' ''
                'Me.vDatos.Columns("Sesenta").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                'Me.vDatos.Columns("Sesenta").DisplayFormat.FormatString = "{0:n2}"
                'Me.vDatos.Columns("Sesenta").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                'Me.vDatos.Columns("Sesenta").SummaryItem.DisplayFormat = "{0:n2}"
                ' ''
                'Me.vDatos.Columns("Noventa").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                'Me.vDatos.Columns("Noventa").DisplayFormat.FormatString = "{0:n2}"
                'Me.vDatos.Columns("Noventa").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                'Me.vDatos.Columns("Noventa").SummaryItem.DisplayFormat = "{0:n2}"
                ' ''
                ''Me.vDatos.Columns("MasNoventa").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                ''Me.vDatos.Columns("MasNoventa").DisplayFormat.FormatString = "{0:n2}"
                ''Me.vDatos.Columns("MasNoventa").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                ''Me.vDatos.Columns("MasNoventa").SummaryItem.DisplayFormat = "{0:n2}"
                ' ''
                'Me.vDatos.Columns("Corte").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                'Me.vDatos.Columns("Corte").DisplayFormat.FormatString = "{0:n2}"
                'Me.vDatos.Columns("Corte").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                'Me.vDatos.Columns("Corte").SummaryItem.DisplayFormat = "{0:n2}"
                ' ''
                ''Me.vDatos.Columns("Credito").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                ''Me.vDatos.Columns("Credito").DisplayFormat.FormatString = "{0:n2}"
                ''Me.vDatos.Columns("Credito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                ''Me.vDatos.Columns("Credito").SummaryItem.DisplayFormat = "{0:n2}"

                HideSplash()

            Else    'Antiguedad de Saldos Entre Fecha con Saldo Inicial
                Dim Variables As New ArrayList
                Dim Datos As New ArrayList

                Variables.Add("Empresa")
                Variables.Add("Desde")
                Variables.Add("Hasta")
                Variables.Add("Moneda")
                Variables.Add("Sucursal")

                Datos.Add(EmpresaActual)
                Datos.Add(Desde.DateTime.Date)
                Datos.Add(Hasta.DateTime.Date)
                Datos.Add(cbMoneda.EditValue)
                Datos.Add("%")
                'Datos.Add(IIf(Me.cbSucursal.ItemIndex = 0, "%", Me.cbSucursal.EditValue))

                Me.dgDatos.DataSource =
                    ProcedureParameters(Datos, Variables, "SPRptAnalisisAntiguedad_SInicial")
                Me.vDatos.PopulateColumns()
                FormatoGrid(Me.vDatos)
                '
                Me.vDatos.Columns("Saldo Inicial").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.vDatos.Columns("Saldo Inicial").DisplayFormat.FormatString = "{0:n2}"
                Me.vDatos.Columns("Saldo Inicial").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.vDatos.Columns("Saldo Inicial").SummaryItem.DisplayFormat = "{0:n2}"
                ''
                Me.vDatos.Columns("Monto Compras").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.vDatos.Columns("Monto Compras").DisplayFormat.FormatString = "{0:n2}"
                Me.vDatos.Columns("Monto Compras").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.vDatos.Columns("Monto Compras").SummaryItem.DisplayFormat = "{0:n2}"
                ''
                Me.vDatos.Columns("Monto ND").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.vDatos.Columns("Monto ND").DisplayFormat.FormatString = "{0:n2}"
                Me.vDatos.Columns("Monto ND").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.vDatos.Columns("Monto ND").SummaryItem.DisplayFormat = "{0:n2}"
                ''
                Me.vDatos.Columns("Abonos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.vDatos.Columns("Abonos").DisplayFormat.FormatString = "{0:n2}"
                Me.vDatos.Columns("Abonos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.vDatos.Columns("Abonos").SummaryItem.DisplayFormat = "{0:n2}"
                ''
                Me.vDatos.Columns("Monto NC").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.vDatos.Columns("Monto NC").DisplayFormat.FormatString = "{0:n2}"
                Me.vDatos.Columns("Monto NC").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.vDatos.Columns("Monto NC").SummaryItem.DisplayFormat = "{0:n2}"
                ''
                Me.vDatos.Columns("Saldo Final").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                Me.vDatos.Columns("Saldo Final").DisplayFormat.FormatString = "{0:n2}"
                Me.vDatos.Columns("Saldo Final").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                Me.vDatos.Columns("Saldo Final").SummaryItem.DisplayFormat = "{0:n2}"
                ''Me.vDatos.BestFitColumns()
            End If


            'Dim Report As New rptBalanceClientes
            'Dim DsBal As DataSet = VB.SysContab.ClientesDB.GetFacturasVentasPendientes(Me.dtpHasta.Value.Date, Me.cbMonedaCambio.Text, _
            '                                       TCambio, False, "")
            'DsBal.WriteXml(Application.StartupPath & "\xml\rptBalanceClientes.xml", XmlWriteMode.WriteSchema)

            'If dsbal.Tables(0).Rows.Count = 0 Then
            '    MsgBox("No hay datos que mostrar", MsgBoxStyle.Information, "STS-Contab")
            '    Exit Sub
            'End If

            'Report.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoEmpresa.xml"
            'Report.Database.Tables("Facturas_Ventas_Pendientes").Location = Application.StartupPath & "\xml\rptBalanceClientes.xml"
            'fReportes.crvReportes.ReportSource = Report
            'fReportes.Show()
        Else

            'Dim Cadena As String
            'Dim Temp As Boolean = False
            'Dim Data() As Byte

            ShowSplash("Imprimiendo...")

            'Try
            '    Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 23 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            '    Temp = True
            '    Dim Tamano As Integer
            '    Tamano = Data.GetUpperBound(0)
            '    Cadena = Application.StartupPath & "\rptAntiguedad.repx"
            '    If File.Exists(Cadena) Then Kill(Cadena)
            '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            '    Archivo.Write(Data, 0, Tamano)
            '    Archivo.Close()
            'Catch ex As Exception
            '    Temp = False
            'End Try

            Dim Temp As Boolean = db_Formatos.FormatoImpreso(23, "rptAntiguedad")

            Dim rpt As RptAnalisisAntiguedadCxP

            If Temp = True Then
                rpt = XtraReport.FromFile(Application.StartupPath & "\rptAntiguedad.repx", True)
            Else
                rpt = New RptAnalisisAntiguedadCxP
            End If

            rpt.Detalle = chkdetalle.Checked


            Dim dtRpt As DataTable = ObtieneDatos("SPRptAnalisisAntiguedad_CxP",
                                                  dtpHasta.DateTime.Date,
                                                  cbRubro.EditValue,
                                                  EmpresaActual,
                                                  cbMoneda.EditValue)


            VistaPreviaDX(rpt, dtRpt, "Antiguedad de Saldos de Proveedores")

            'rpt.DataSource = dtRpt
            'rpt.ShowPrintMarginsWarning = False
            'rpt.BringToFront()
            'rpt.ShowRibbonPreview()
            ''
            dgDatos.DataSource = dtRpt
            'Me.vDatos.PopulateColumns()
            'FormatoGrid(Me.vDatos)
            '''
            'Me.vDatos.Columns("Empresa").Visible = False
            'Me.vDatos.Columns("TipoProveedor").Visible = False
            'Me.vDatos.Columns("Titulo").Visible = False
            'Me.vDatos.Columns("Encabezado").Visible = False

            'Dim Report As New rptBalanceProveedores
            '' Formatear el reporte
            'Dim Report As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'Report.Load(Application.StartupPath & "\Reportes\rptBalanceProveedores.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            ''
            'Dim DsBal As DataSet = VB.SysContab.ProveedoresDB.GetFacturasVentasPendientes(Me.dtpHasta.DateTime.Date, cbMoneda.EditValue, _
            '                                                 TCambio, False, "")
            'If DsBal.Tables(0).Rows.Count = 0 Then
            '    XtraMsg("No hay datos que mostrar")
            '    HideSplash()
            '    Exit Sub
            'End If
            'DsBal.WriteXml(Application.StartupPath & "\xml\rptBalanceProveedores.xml", XmlWriteMode.WriteSchema)
            'Report.Database.Tables("EMPRESAS").Location = Application.StartupPath & "\xml\logoempresa.xml"
            'Report.Database.Tables("Facturas_Ventas_Pendientes").Location = Application.StartupPath & "\xml\rptBalanceProveedores.xml"
            'fReportes.crvReportes.ReportSource = Report
            'fReportes.Show()
            '
            HideSplash()
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        frmExportarImprimir.Mostrar(dgDatos)

        'If Me.TReporte = "C" Then
        '    Help.ShowHelp(Me, "ayuda/Reportes/ReportesGestion.chm", HelpNavigator.KeywordIndex, "4")
        'Else
        '    Help.ShowHelp(Me, "ayuda/Reportes/ReportesGestion.chm", HelpNavigator.KeywordIndex, "7")
        'End If
    End Sub

    Private Sub dtpHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkCorte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dtpHasta.Enabled = chkCorte.Checked
        Desde.Enabled = Not chkCorte.Checked
        Hasta.Enabled = Not chkCorte.Checked
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        With FrmConfiguraCheque
            .Tipo = IIf(TReporte = "C", 22, 23)
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub IniciaContador(Intervalo As Integer)
        Timer1.Enabled = True
        Timer1.Interval = Intervalo
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Mostrar Notificacion si se encuentran facturas Vencidas
        If FacturasVencidas > 0 Then
            AlertControl1.Show(Me, "Alerta  de Facturas Vencidas!", "Existen " & FacturasVencidas.ToString & " Facturas Vencidas al día de Hoy." & vbCrLf & vbCrLf & vbCrLf &
                               "Clic Aqui para Ver Reporte")

            IniciaContador(300000)
        End If
        '
        'Mostrar Notificacion si se encuentran facturas Proximas a Vencer
        If FvProximasVencer > 0 Then
            AlertControl2.Show(Me, "Alerta  de Facturas Próximas a Vencer!", "Existen " & FvProximasVencer.ToString & " Facturas Próximas a Vencer." & vbCrLf & vbCrLf & vbCrLf &
                               "Clic Aqui para Ver Reporte")

            IniciaContador(300000)
        End If
    End Sub

    Private Sub AlertControl1_AlertClick(sender As Object, e As DevExpress.XtraBars.Alerter.AlertClickEventArgs) Handles AlertControl1.AlertClick
        With frmFacturasVentasVencidas
            .Text = "Facturas Vencidas"
            .sProc = "JAR_GetFacturasVencidas"
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub AlertControl2_AlertClick(sender As Object, e As DevExpress.XtraBars.Alerter.AlertClickEventArgs) Handles AlertControl2.AlertClick
        With frmFacturasVentasVencidas
            .Text = "Facturas Proximas a Vencer"
            .sProc = "JAR_GetFacturasProximasAVencer"
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        ShowSplash("Cargando Reporte...")
        If Me.TReporte = "C" Then
            frmReporteAntiguedadClientesProximasVencer.Dispose()
            frmReporteAntiguedadClientesProximasVencer.etInicio.Text = "0"
            frmReporteAntiguedadClientesProximasVencer.MdiParent = Me.MdiParent
            frmReporteAntiguedadClientesProximasVencer.Hasta.DateTime = dtpHasta.DateTime.Date
            frmReporteAntiguedadClientesProximasVencer.Moneda = cbMoneda.EditValue
            frmReporteAntiguedadClientesProximasVencer.SucID = "XX" 'cbCheckSucursal.EditValue   ' cbSucursal.EditValue
            frmReporteAntiguedadClientesProximasVencer.Show()
            frmReporteAntiguedadClientesProximasVencer.Text = "Facturas Proximas a Vencer Clientes"
            frmReporteAntiguedadClientesProximasVencer.WindowState = FormWindowState.Maximized
            frmReporteAntiguedadClientesProximasVencer.etInicio.Text = "1"
        Else
            frmReporteAntiguedadProvProximasVencer.Dispose()
            frmReporteAntiguedadProvProximasVencer.etInicio.Text = "0"
            frmReporteAntiguedadProvProximasVencer.MdiParent = Me.MdiParent
            frmReporteAntiguedadProvProximasVencer.Hasta.DateTime = dtpHasta.DateTime.Date
            frmReporteAntiguedadProvProximasVencer.Rubro = cbRubro.EditValue
            frmReporteAntiguedadProvProximasVencer.Moneda = cbMoneda.EditValue
            frmReporteAntiguedadProvProximasVencer.Show()
            frmReporteAntiguedadProvProximasVencer.Text = "Facturas Proximas a Vencer Proveedores"
            frmReporteAntiguedadProvProximasVencer.WindowState = FormWindowState.Maximized
            frmReporteAntiguedadProvProximasVencer.etInicio.Text = "1"
        End If
        HideSplash()
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles chkPorCliente.CheckedChanged
        cbCliente.Enabled = chkPorCliente.Checked
    End Sub

    Sub LeerEsquemaInicial()
        ''Borrar Archivo, para evitar cache
        If IO.File.Exists(Application.StartupPath & "\xml\xml_" & Me.Name & "_" & TReporte & ".xml") Then
            Kill(Application.StartupPath & "\xml\xml_" & Me.Name & "_" & TReporte & ".xml")
        End If
        '
        ''Guardar Configuracion Inicial
        vDatos.SaveLayoutToXml(Application.StartupPath & "\xml\xml_" & Me.Name & "_" & TReporte & ".xml")
        db_Esquemas.GuardarInicial(Me.Name, Me.Text, Application.StartupPath & "\xml\xml_" & Me.Name & "_" & TReporte & ".xml")
        '
        ValidarGridSchema(vDatos, Me.Name & "_" & TReporte)
    End Sub

    Private Sub bGuardarEsquema_Click(sender As Object, e As EventArgs) Handles bGuardarEsquema.Click
        Try
            ''Borrar Archivo, para evitar cache
            If IO.File.Exists(Application.StartupPath & "\xml\xml_" & Me.Name & "_" & TReporte & ".xml") Then
                Kill(Application.StartupPath & "\xml\xml_" & Me.Name & "_" & TReporte & ".xml")
            End If

            ''Verificar Configuracion Inicial
            If db_Esquemas.GetEsquema(Me.Name, 1).Rows.Count = 0 Then
                ''Guardar Configuracion Inicial
                vDatos.SaveLayoutToXml(Application.StartupPath & "\xml\xml_" & Me.Name & "_" & TReporte & ".xml")
                db_Esquemas.Guardar(Me.Name, Me.Text, Application.StartupPath & "\xml\xml_" & Me.Name & "_" & TReporte & ".xml", 1)
            Else
                vDatos.SaveLayoutToXml(Application.StartupPath & "\xml\xml_" & Me.Name & "_" & TReporte & ".xml")
                db_Esquemas.Guardar(Me.Name, Me.Text, Application.StartupPath & "\xml\xml_" & Me.Name & "_" & TReporte & ".xml", 0)
            End If

            XtraMsg("Esquema Guardado!")
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bRestaurarEsquema_Click(sender As Object, e As EventArgs) Handles bRestaurarEsquema.Click
        db_Esquemas.Borrar(Me.Name, 0)
        ValidarGridSchema(vDatos, Me.Name & "_" & TReporte)
    End Sub
End Class
