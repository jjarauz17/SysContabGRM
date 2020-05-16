Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmLibroEstadoSituacion
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmLibroEstadoSituacion = Nothing
    Private i As Integer


    Dim Periodos As New VB.SysContab.PeriodosDB()
    Dim Libros As New VB.SysContab.LibrosDB()
    Dim r As New VB.SysContab.Rutinas()
    Private Empresa As New VB.SysContab.EmpresasDetails()
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents chkCtaDist As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCuenta As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkOrden As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPorc As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSAnterior As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkZeros As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbMonedaCambio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtpHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtTitulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents chkAnexos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Private Empresas As New VB.SysContab.EmpresasDB()


    Public Shared Function Instance() As frmLibroEstadoSituacion
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmLibroEstadoSituacion()
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
    Friend WithEvents cbGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents cbNiveles As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibroEstadoSituacion))
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cbNiveles = New System.Windows.Forms.ComboBox()
        Me.cbGrupos = New System.Windows.Forms.ComboBox()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkAnexos = New DevExpress.XtraEditors.CheckEdit()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.txtTitulo = New DevExpress.XtraEditors.TextEdit()
        Me.dtpHasta = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDesde = New DevExpress.XtraEditors.DateEdit()
        Me.cbMonedaCambio = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkSAnterior = New DevExpress.XtraEditors.CheckEdit()
        Me.chkZeros = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCuenta = New DevExpress.XtraEditors.CheckEdit()
        Me.chkOrden = New DevExpress.XtraEditors.CheckEdit()
        Me.chkPorc = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCtaDist = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkAnexos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMonedaCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkZeros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPorc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCtaDist.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 54)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(107, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(131, 264)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 12)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(107, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl2
        Me.cmdImprimir.TabIndex = 0
        Me.cmdImprimir.Text = "Imprimir"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14, Me.LayoutControlItem15})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(131, 264)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmdImprimir
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cmdSalir
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(111, 202)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'cbNiveles
        '
        Me.cbNiveles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNiveles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNiveles.Location = New System.Drawing.Point(93, 72)
        Me.cbNiveles.Name = "cbNiveles"
        Me.cbNiveles.Size = New System.Drawing.Size(360, 23)
        Me.cbNiveles.TabIndex = 29
        '
        'cbGrupos
        '
        Me.cbGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupos.Location = New System.Drawing.Point(93, 46)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.Size = New System.Drawing.Size(360, 23)
        Me.cbGrupos.TabIndex = 8
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkAnexos)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.Hasta)
        Me.LayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.LayoutControl1.Controls.Add(Me.txtTitulo)
        Me.LayoutControl1.Controls.Add(Me.dtpHasta)
        Me.LayoutControl1.Controls.Add(Me.dtpDesde)
        Me.LayoutControl1.Controls.Add(Me.cbMonedaCambio)
        Me.LayoutControl1.Controls.Add(Me.chkSAnterior)
        Me.LayoutControl1.Controls.Add(Me.chkZeros)
        Me.LayoutControl1.Controls.Add(Me.chkCuenta)
        Me.LayoutControl1.Controls.Add(Me.chkOrden)
        Me.LayoutControl1.Controls.Add(Me.chkPorc)
        Me.LayoutControl1.Controls.Add(Me.chkCtaDist)
        Me.LayoutControl1.Controls.Add(Me.cbGrupos)
        Me.LayoutControl1.Controls.Add(Me.cbNiveles)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1066, 280, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(644, 291)
        Me.LayoutControl1.TabIndex = 29
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkAnexos
        '
        Me.chkAnexos.Location = New System.Drawing.Point(24, 96)
        Me.chkAnexos.Name = "chkAnexos"
        Me.chkAnexos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnexos.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkAnexos.Properties.Appearance.Options.UseFont = True
        Me.chkAnexos.Properties.Appearance.Options.UseForeColor = True
        Me.chkAnexos.Properties.Caption = "Imprimir con Anexos"
        Me.chkAnexos.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkAnexos.Size = New System.Drawing.Size(596, 22)
        Me.chkAnexos.StyleController = Me.LayoutControl1
        Me.chkAnexos.TabIndex = 31
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(93, 70)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Size = New System.Drawing.Size(527, 22)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 36
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Location = New System.Drawing.Point(93, 46)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Size = New System.Drawing.Size(145, 20)
        Me.Hasta.StyleController = Me.LayoutControl1
        Me.Hasta.TabIndex = 38
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = 1
        Me.RadioGroup1.Location = New System.Drawing.Point(93, 224)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Vertical"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Regla T")})
        Me.RadioGroup1.Size = New System.Drawing.Size(527, 43)
        Me.RadioGroup1.StyleController = Me.LayoutControl1
        Me.RadioGroup1.TabIndex = 39
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(93, 200)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(527, 20)
        Me.txtTitulo.StyleController = Me.LayoutControl1
        Me.txtTitulo.TabIndex = 38
        '
        'dtpHasta
        '
        Me.dtpHasta.EditValue = Nothing
        Me.dtpHasta.Location = New System.Drawing.Point(392, 176)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Properties.Appearance.Options.UseFont = True
        Me.dtpHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHasta.Size = New System.Drawing.Size(228, 20)
        Me.dtpHasta.StyleController = Me.LayoutControl1
        Me.dtpHasta.TabIndex = 37
        '
        'dtpDesde
        '
        Me.dtpDesde.EditValue = Nothing
        Me.dtpDesde.Location = New System.Drawing.Point(93, 176)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Properties.Appearance.Options.UseFont = True
        Me.dtpDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDesde.Size = New System.Drawing.Size(226, 20)
        Me.dtpDesde.StyleController = Me.LayoutControl1
        Me.dtpDesde.TabIndex = 36
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.Location = New System.Drawing.Point(93, 150)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbMonedaCambio.Properties.Appearance.Options.UseFont = True
        Me.cbMonedaCambio.Properties.Appearance.Options.UseForeColor = True
        Me.cbMonedaCambio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMonedaCambio.Size = New System.Drawing.Size(527, 22)
        Me.cbMonedaCambio.StyleController = Me.LayoutControl1
        Me.cbMonedaCambio.TabIndex = 35
        '
        'chkSAnterior
        '
        Me.chkSAnterior.Location = New System.Drawing.Point(457, 72)
        Me.chkSAnterior.Name = "chkSAnterior"
        Me.chkSAnterior.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSAnterior.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkSAnterior.Properties.Appearance.Options.UseFont = True
        Me.chkSAnterior.Properties.Appearance.Options.UseForeColor = True
        Me.chkSAnterior.Properties.Caption = "Saldo Anterior"
        Me.chkSAnterior.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkSAnterior.Size = New System.Drawing.Size(163, 22)
        Me.chkSAnterior.StyleController = Me.LayoutControl1
        Me.chkSAnterior.TabIndex = 33
        '
        'chkZeros
        '
        Me.chkZeros.Location = New System.Drawing.Point(457, 46)
        Me.chkZeros.Name = "chkZeros"
        Me.chkZeros.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkZeros.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkZeros.Properties.Appearance.Options.UseFont = True
        Me.chkZeros.Properties.Appearance.Options.UseForeColor = True
        Me.chkZeros.Properties.Caption = "Eliminar Ceros?"
        Me.chkZeros.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkZeros.Size = New System.Drawing.Size(163, 22)
        Me.chkZeros.StyleController = Me.LayoutControl1
        Me.chkZeros.TabIndex = 34
        '
        'chkCuenta
        '
        Me.chkCuenta.Location = New System.Drawing.Point(457, 124)
        Me.chkCuenta.Name = "chkCuenta"
        Me.chkCuenta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCuenta.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkCuenta.Properties.Appearance.Options.UseFont = True
        Me.chkCuenta.Properties.Appearance.Options.UseForeColor = True
        Me.chkCuenta.Properties.Caption = "Ocultar Cuentas"
        Me.chkCuenta.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkCuenta.Size = New System.Drawing.Size(163, 22)
        Me.chkCuenta.StyleController = Me.LayoutControl1
        Me.chkCuenta.TabIndex = 32
        '
        'chkOrden
        '
        Me.chkOrden.Location = New System.Drawing.Point(457, 98)
        Me.chkOrden.Name = "chkOrden"
        Me.chkOrden.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOrden.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkOrden.Properties.Appearance.Options.UseFont = True
        Me.chkOrden.Properties.Appearance.Options.UseForeColor = True
        Me.chkOrden.Properties.Caption = "Presentar Ctas Orden?"
        Me.chkOrden.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkOrden.Size = New System.Drawing.Size(163, 22)
        Me.chkOrden.StyleController = Me.LayoutControl1
        Me.chkOrden.TabIndex = 31
        '
        'chkPorc
        '
        Me.chkPorc.Location = New System.Drawing.Point(24, 124)
        Me.chkPorc.Name = "chkPorc"
        Me.chkPorc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPorc.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkPorc.Properties.Appearance.Options.UseFont = True
        Me.chkPorc.Properties.Appearance.Options.UseForeColor = True
        Me.chkPorc.Properties.Caption = "Mostrar Porcentajes"
        Me.chkPorc.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkPorc.Size = New System.Drawing.Size(429, 22)
        Me.chkPorc.StyleController = Me.LayoutControl1
        Me.chkPorc.TabIndex = 31
        '
        'chkCtaDist
        '
        Me.chkCtaDist.Location = New System.Drawing.Point(24, 98)
        Me.chkCtaDist.Name = "chkCtaDist"
        Me.chkCtaDist.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCtaDist.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkCtaDist.Properties.Appearance.Options.UseFont = True
        Me.chkCtaDist.Properties.Appearance.Options.UseForeColor = True
        Me.chkCtaDist.Properties.Caption = "Incluir Ctas Distribución?"
        Me.chkCtaDist.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkCtaDist.Size = New System.Drawing.Size(429, 22)
        Me.chkCtaDist.StyleController = Me.LayoutControl1
        Me.chkCtaDist.TabIndex = 30
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(644, 291)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup3
        Me.TabbedControlGroup1.SelectedTabPageIndex = 0
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(624, 271)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4})
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem6, Me.LayoutControlItem5, Me.LayoutControlItem8, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(600, 225)
        Me.LayoutControlGroup3.Text = "BALANCE GENERAL TRADICIONAL"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbGrupos
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(433, 26)
        Me.LayoutControlItem1.Text = "Grupos:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbNiveles
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(433, 26)
        Me.LayoutControlItem2.Text = "Niveles:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.chkPorc
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(433, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.chkCtaDist
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(433, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.chkCuenta
        Me.LayoutControlItem6.Location = New System.Drawing.Point(433, 78)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(167, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(167, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(167, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.chkOrden
        Me.LayoutControlItem5.Location = New System.Drawing.Point(433, 52)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(167, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(167, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(167, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.chkSAnterior
        Me.LayoutControlItem8.Location = New System.Drawing.Point(433, 26)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(167, 26)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(167, 26)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(167, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.chkZeros
        Me.LayoutControlItem7.Location = New System.Drawing.Point(433, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(167, 26)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(167, 26)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(167, 26)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbMonedaCambio
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(600, 26)
        Me.LayoutControlItem9.Text = "Moneda:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.dtpDesde
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 130)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(299, 24)
        Me.LayoutControlItem10.Text = "Desde:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtTitulo
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 154)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(600, 24)
        Me.LayoutControlItem11.Text = "Titulo:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.dtpHasta
        Me.LayoutControlItem12.Location = New System.Drawing.Point(299, 130)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(301, 24)
        Me.LayoutControlItem12.Text = "Hasta:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.RadioGroup1
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 178)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(600, 47)
        Me.LayoutControlItem13.Text = "Presentación:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem16, Me.LayoutControlItem17, Me.EmptySpaceItem1, Me.LayoutControlItem18})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(600, 225)
        Me.LayoutControlGroup4.Text = "BALANCE GENERAL GERENCIAL"
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.Hasta
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(218, 24)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(218, 24)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(218, 24)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "A la Fecha:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(66, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cbMoneda
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(600, 26)
        Me.LayoutControlItem17.Text = "Moneda:"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(66, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(218, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(382, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.chkAnexos
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(600, 175)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("b83e0ae1-52eb-49b8-b277-ed1b78296eee")
        Me.DockPanel1.Location = New System.Drawing.Point(644, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 291)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 264)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmLibroEstadoSituacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(784, 291)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLibroEstadoSituacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes - Estado de Situación"
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkAnexos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMonedaCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkZeros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPorc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCtaDist.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Per_Detail As New VB.SysContab.PeriodoDetails
    Dim Fechas As New VB.SysContab.FechasdeOperacion

    Private Sub frmLibroEstadoSituacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim Tasa As New VB.SysContab.Tasa_CambioDB()

        'r.CambiarEstilo(Me)
        'i = 0

        'cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        'cbMonedaCambio.ValueMember = "MonedaCambio"
        'cbMonedaCambio.DisplayMember = "Nombre"

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        GetMonedasList(cbMonedaCambio)

        cbGrupos.DataSource = Libros.Grupos("1", "B").Tables("Grupos")
        cbGrupos.ValueMember = "CGrupo"
        cbGrupos.DisplayMember = "Nombre"

        'Me.cbNivelGrupo.DataSource = Libros.NivelesGrupos("%", "B").Tables("NivelesGrupos")
        'Me.cbNivelGrupo.ValueMember = "Nivel"
        'Me.cbNivelGrupo.DisplayMember = "Nombre"

        cbNiveles.DataSource = Libros.Niveles().Tables("Niveles") 'Grupos.GetList_SP("%").Tables("Niveles")
        cbNiveles.ValueMember = "Nivel"
        cbNiveles.DisplayMember = "Descripcion"
        chkSAnterior.Checked = False
        chkZeros.Checked = True

        'Me.chkVertical.Checked = True
        chkCtaDist.Checked = True
        chkOrden.Checked = True

        dtpDesde.Properties.MinValue = Fechas.FechaMinima
        dtpDesde.Properties.MaxValue = Fechas.FechaMaxima
        dtpHasta.Properties.MinValue = Fechas.FechaMinima
        dtpHasta.Properties.MaxValue = Fechas.FechaMaxima

        dtpDesde.DateTime = New DateTime(f.Year, f.Month, 1)
        dtpHasta.DateTime = UltimoDiaDelMes(f.Date).Date
        Hasta.DateTime = UltimoDiaDelMes(f.Date).Date

        Me.txtTitulo.Text = "Estado de Situación"

        'Me.cbMonedaCambio.SelectedValue = MonedaBase
        Me.chkCuenta.Checked = True
        Me.chkPorc.Checked = True
    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click


        If TabbedControlGroup1.SelectedTabPageIndex = 0 Then

            Dim fReportes As New frmReportes()
            Dim Periodo As New VB.SysContab.PeriodoDetails()
            Dim DetalleNivel As New VB.SysContab.NivelDetailsDB()
            Dim dsBalanza As New DataSet
            Dim dsOrden As New DataSet
            Dim ds As New DataSet()
            Dim rds As New DataSet
            Dim rNivel As Integer

            Empresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)


            ShowSplash()
            'If Not Me.ChkColumnas.Checked Then
            'If Me.chkVertical.Checked Then
            If RadioGroup1.EditValue = 1 Then

                If Me.chkSAnterior.Checked = False Then
                    'Pasar el DataSet Original
                    Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument

                    If EmpresaActual = 1 Then
                        Reporte.Load(Application.StartupPath & "\Reportes\rptESituacionVertical_RAMAC.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                    Else
                        Reporte.Load(Application.StartupPath & "\Reportes\rptESituacionVertical.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                    End If

                    'Datos de Estado de Situacion
                    Libros.Imprimir_LibroBalanza(0, Me.dtpDesde.DateTime.Date,
                        Me.dtpHasta.DateTime.Date, Login, Me.txtTitulo.Text, "%", "%",
                        IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue),
                        Me.chkCuenta.Checked, Empresa.MonedaBase, Me.cbMonedaCambio.EditValue, Me.chkZeros.Checked,
                        "%", "%", "S", Me.chkSAnterior.Checked, dsBalanza, False, Empresa.Nombre, "%", "%", 0, 0, 0)

                    'Cuentas de orden
                    Libros.Imprimir_LibroBalanza(0, Me.dtpDesde.DateTime.Date, _
                        Me.dtpHasta.DateTime.Date, Login, Me.txtTitulo.Text, "%", "%", _
                        IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue), _
                         Me.chkCuenta.Checked, Empresa.MonedaBase, Me.cbMonedaCambio.EditValue, Me.chkZeros.Checked, _
                        "%", "%", "O", Me.chkSAnterior.Checked, dsOrden, False, Empresa.Nombre, "%", IIf(Me.chkOrden.Checked, "1", "0"), 0, 0, 0)

                    'Datos para el detalle
                    ds = Libros.Detalle_Apie(Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date, 0, Me.cbMonedaCambio.EditValue)

                    'Firmas
                    Dim ldt As New DataSet
                    ldt.Tables.Add(Libros.GetFirmasContables())
                    ldt.WriteXml(Application.StartupPath & "\xml\FirmasContables.xml", XmlWriteMode.WriteSchema)


                    dsBalanza.WriteXml(Application.StartupPath & "\xml\balanza.xml", XmlWriteMode.WriteSchema)
                    dsOrden.WriteXml(Application.StartupPath & "\xml\Orden.xml", XmlWriteMode.WriteSchema)
                    ds.WriteXml(Application.StartupPath & "\xml\detalleES.xml", XmlWriteMode.WriteSchema)

                    Reporte.Database.Tables("vcd").Location = Application.StartupPath & "\xml\balanza.xml"
                    'reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\logoempresa.xml"
                    Dim i As Integer
                    For i = 0 To Reporte.Subreports.Count - 1
                        If Reporte.Subreports.Item(i).Name = "DeOrden" Then
                            Reporte.Subreports.Item(i).Database.Tables("vcd").Location = Application.StartupPath & "\xml\Orden.xml"
                        ElseIf Reporte.Subreports.Item(i).Name = "Firmas1" Or Reporte.Subreports.Item(i).Name = "Firmas2" Or Reporte.Subreports.Item(i).Name = "Firmas3" Then
                            Reporte.Subreports.Item(i).Database.Tables("FirmasContables").Location = Application.StartupPath & "\xml\FirmasContables.xml"
                        Else
                            Reporte.Subreports.Item(i).Database.Tables("_GetDetalleApie;1").Location = Application.StartupPath & "\xml\detalleES.xml"
                        End If

                    Next

                    fReportes.crvReportes.ReportSource = Reporte
                Else
                    'Dim reporte As New rptESSubReportes_NGrup
                    'Datos de Estado de Situacion
                    Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    If Me.chkPorc.Checked Then
                        Reporte.Load(Application.StartupPath & "\Reportes\rptBalanceGeneral_Porcentajes.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                    Else
                        Reporte.Load(Application.StartupPath & "\Reportes\rptEstadoSituacionconSubreportesXML.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                    End If

                    '
                    Libros.Imprimir_LibroBalanza(0, Me.dtpDesde.DateTime.Date, _
                        Me.dtpHasta.DateTime.Date, Login, Me.txtTitulo.Text, "%", "%", _
                        IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue), _
                        False, Empresa.MonedaBase, Me.cbMonedaCambio.EditValue, Me.chkZeros.Checked, _
                        "%", "%", "S", Me.chkSAnterior.Checked, dsBalanza, False, Empresa.Nombre, "%", "%", 0, 0, 0)

                    'Cuentas de orden
                    Libros.Imprimir_LibroBalanza(0, Me.dtpDesde.DateTime.Date, _
                        Me.dtpHasta.DateTime.Date, Login, Me.txtTitulo.Text, "%", "%", _
                        IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue), _
                        Me.chkCuenta.Checked, Empresa.MonedaBase, Me.cbMonedaCambio.EditValue, Me.chkZeros.Checked, _
                        "%", "%", "O", Me.chkSAnterior.Checked, dsOrden, False, Empresa.Nombre, "%", IIf(Me.chkOrden.Checked, "1", "0"), 0, 0, 0)

                    'Datos para el detalle
                    ds = Libros.Detalle_Apie(Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date, 0, Me.cbMonedaCambio.EditValue)
                    'Firmas
                    Dim ldt As New DataSet
                    ldt.Tables.Add(Libros.GetFirmasContables())
                    ldt.WriteXml(Application.StartupPath & "\xml\FirmasContables.xml", XmlWriteMode.WriteSchema)


                    dsBalanza.WriteXml(Application.StartupPath & "\xml\balanza.xml", XmlWriteMode.WriteSchema)
                    dsOrden.WriteXml(Application.StartupPath & "\xml\Orden.xml", XmlWriteMode.WriteSchema)
                    ds.WriteXml(Application.StartupPath & "\xml\detalleES.xml", XmlWriteMode.WriteSchema)

                    Reporte.Database.Tables("vcd").Location = Application.StartupPath & "\xml\balanza.xml"
                    'reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\logoempresa.xml"
                    Dim i As Integer
                    For i = 0 To Reporte.Subreports.Count - 1
                        If Reporte.Subreports.Item(i).Name = "DeOrden" Then
                            Reporte.Subreports.Item(i).Database.Tables("vcd").Location = Application.StartupPath & "\xml\Orden.xml"
                        ElseIf Reporte.Subreports.Item(i).Name = "Firmas1" Or Reporte.Subreports.Item(i).Name = "Firmas2" Or Reporte.Subreports.Item(i).Name = "Firmas3" Then
                            Reporte.Subreports.Item(i).Database.Tables("FirmasContables").Location = Application.StartupPath & "\xml\FirmasContables.xml"
                        Else
                            Reporte.Subreports.Item(i).Database.Tables("_GetDetalleApie;1").Location = Application.StartupPath & "\xml\detalleES.xml"
                        End If

                    Next

                    fReportes.crvReportes.ReportSource = Reporte

                End If

            Else

                'Regla T
                'Dim rT As New rptEstadoSituacionTxml
                Dim rT As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                If Me.chkPorc.Checked = True Then
                    rT.Load(Application.StartupPath & "\Reportes\rptBalanceGeneralT_Porcentaje.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                Else
                    rT.Load(Application.StartupPath & "\Reportes\rptEstadoSituacionTxml.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                End If

                '
                Libros.Imprimir_LibroBalanza(0, Me.dtpDesde.DateTime.Date, _
                    Me.dtpHasta.DateTime.Date, Usuario, Me.txtTitulo.Text, "%", "%", IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue), _
                     Me.chkCuenta.Checked, Empresa.MonedaBase, Me.cbMonedaCambio.EditValue, Me.chkZeros.Checked, "%", _
                      0, "S", Me.chkSAnterior.Checked, dsBalanza, False, Empresa.Nombre, "%", "%", 0, 0, 0)

                Libros.Imprimir_LibroEstadoSituacionT(0, Me.dtpDesde.DateTime.Date, _
                    Me.dtpHasta.DateTime.Date, Usuario, Me.txtTitulo.Text, "%", Me.chkSAnterior.Checked, _
                    Empresa.MonedaBase, Me.cbMonedaCambio.EditValue, ds)


                dsBalanza.WriteXml(Application.StartupPath & "\xml\ESTDetalle.xml", XmlWriteMode.WriteSchema)
                ds.WriteXml(Application.StartupPath & "\xml\EST.xml", XmlWriteMode.WriteSchema)

                'Firmas
                Dim ldt As New DataSet
                ldt.Tables.Add(Libros.GetFirmasContables())
                ldt.WriteXml(Application.StartupPath & "\xml\FirmasContables.xml", XmlWriteMode.WriteSchema)

                rT.Database.Tables(0).Location = Application.StartupPath & "\xml\EST.xml"
                rT.Subreports("Activos").Database.Tables(0).Location = Application.StartupPath & "\xml\ESTDetalle.xml"
                rT.Subreports("Pasivos").Database.Tables(0).Location = Application.StartupPath & "\xml\ESTDetalle.xml"
                rT.Subreports("Firmas1").Database.Tables(0).Location = Application.StartupPath & "\xml\FirmasContables.xml"
                rT.Subreports("Firmas2").Database.Tables(0).Location = Application.StartupPath & "\xml\FirmasContables.xml"
                rT.Subreports("Firmas3").Database.Tables(0).Location = Application.StartupPath & "\xml\FirmasContables.xml"
                fReportes.crvReportes.ReportSource = rT
            End If

            fReportes.crvReportes.Zoom(91)
            fReportes.Show()
            HideSplash()
        ElseIf TabbedControlGroup1.SelectedTabPageIndex = 1 Then

            ShowSplash("Generando Balance...")

            Dim rpt As New rptBalanceGeneral
            Dim rptActivos As New rptBalanceActivos

            Dim DT_ACTIVO As DataTable = ObtieneDatos("JAR_BalanceGeneralActivos", Hasta.DateTime.Date, cbMoneda.EditValue, "A", EmpresaActual)

            If DT_ACTIVO.Rows.Count = 0 Then
                HideSplash()
                XtraMsg("Se debe configurar el Balance primero, para poder generar este informe.", MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim DT_PASIVO As DataTable = ObtieneDatos("JAR_BalanceGeneralPasivo", Hasta.DateTime.Date, cbMoneda.EditValue, "P", EmpresaActual)

            'rpt.DataSource = DT_ACTIVO
            rptActivos.DataSource = DT_PASIVO
            rpt.XrSubreport1.ReportSource = rptActivos
            rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
            '
            VistaPreviaDX(rpt, DT_ACTIVO, "Balance General Gerencial")
            '
            HideSplash()

            'rpt.ShowPrintMarginsWarning = False
            'rpt.BringToFront()
            'HideSplash()
            'rpt.ShowRibbonPreview()

            'Imprimir Anexos del Balance
            If chkAnexos.Checked Then
                ShowSplash("Generando Anexos...")
                Dim rptAnexos As New rptAnexosEEFF

                Dim Desde As Date = New DateTime(Hasta.DateTime.Year, Hasta.DateTime.Month, 1)
                rptAnexos.pLogo.Image = frmPrincipalRibbon.pLogo.Image

                'rptAnexos.DataSource = ObtieneDatos("JAR_GetBalanceAnexos", Desde, Hasta.DateTime.Date, cbMoneda.EditValue, EmpresaActual)

                VistaPreviaDX(rptAnexos,
                              ObtieneDatos("JAR_GetBalanceAnexos", Desde, Hasta.DateTime.Date, cbMoneda.EditValue, EmpresaActual),
                              "Anexos al Balance General")

                HideSplash()

                'rptAnexos.ShowPrintMarginsWarning = False
                'rptAnexos.BringToFront()
                'rptAnexos.ShowRibbonPreview()
            End If
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub TabbedControlGroup1_SelectedPageChanged(sender As Object, e As DevExpress.XtraLayout.LayoutTabPageChangedEventArgs) Handles TabbedControlGroup1.SelectedPageChanged
        GetMonedasList(cbMoneda)
    End Sub
End Class
