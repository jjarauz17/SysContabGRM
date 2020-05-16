Imports System.IO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmLibroEstadoResultado
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmLibroEstadoResultado = Nothing
    Private i As Integer


    Dim Periodos As New VB.SysContab.PeriodosDB()
    Dim Libros As New VB.SysContab.LibrosDB()
    Dim r As New VB.SysContab.Rutinas()
    Private Empresa As New VB.SysContab.EmpresasDetails()
    Private Empresas As New VB.SysContab.EmpresasDB()
    Friend WithEvents bNuevoER As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bFormato As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents chkZeros As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSAnterior As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCuenta As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTitulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbMonedaCambio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtpHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Hasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents chkComparativo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkUtilidadLinea As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Dim Comprobantes As New VB.SysContab.ComprobanteDB()

    Public Shared Function Instance() As frmLibroEstadoResultado
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmLibroEstadoResultado()
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
    Friend WithEvents cbNivelGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents cbNiveles As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibroEstadoResultado))
        Me.bFormato = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevoER = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cbNiveles = New System.Windows.Forms.ComboBox()
        Me.cbGrupos = New System.Windows.Forms.ComboBox()
        Me.cbNivelGrupo = New System.Windows.Forms.ComboBox()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkUtilidadLinea = New DevExpress.XtraEditors.CheckEdit()
        Me.chkComparativo = New DevExpress.XtraEditors.CheckEdit()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.Hasta = New DevExpress.XtraEditors.DateEdit()
        Me.dtpHasta = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDesde = New DevExpress.XtraEditors.DateEdit()
        Me.cbMonedaCambio = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTitulo = New DevExpress.XtraEditors.TextEdit()
        Me.chkCuenta = New DevExpress.XtraEditors.CheckEdit()
        Me.chkSAnterior = New DevExpress.XtraEditors.CheckEdit()
        Me.chkZeros = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkUtilidadLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkComparativo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMonedaCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkZeros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'bFormato
        '
        Me.bFormato.Location = New System.Drawing.Point(12, 96)
        Me.bFormato.Name = "bFormato"
        Me.bFormato.Size = New System.Drawing.Size(107, 22)
        Me.bFormato.StyleController = Me.LayoutControl2
        Me.bFormato.TabIndex = 3
        Me.bFormato.Text = "Diseño"
        Me.bFormato.Visible = False
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.bFormato)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Controls.Add(Me.bNuevoER)
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
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
        'bNuevoER
        '
        Me.bNuevoER.Location = New System.Drawing.Point(12, 122)
        Me.bNuevoER.Name = "bNuevoER"
        Me.bNuevoER.Size = New System.Drawing.Size(107, 22)
        Me.bNuevoER.StyleController = Me.LayoutControl2
        Me.bNuevoER.TabIndex = 2
        Me.bNuevoER.Text = "Nuevo ER"
        Me.bNuevoER.Visible = False
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
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem11, Me.LayoutControlItem14, Me.LayoutControlItem13})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(131, 264)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdSalir
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdImprimir
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.bFormato
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(111, 26)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        Me.LayoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.bNuevoER
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 110)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(111, 134)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        Me.LayoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'cbNiveles
        '
        Me.cbNiveles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNiveles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNiveles.Location = New System.Drawing.Point(126, 98)
        Me.cbNiveles.Name = "cbNiveles"
        Me.cbNiveles.Size = New System.Drawing.Size(333, 23)
        Me.cbNiveles.TabIndex = 29
        '
        'cbGrupos
        '
        Me.cbGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupos.Location = New System.Drawing.Point(126, 46)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.Size = New System.Drawing.Size(333, 23)
        Me.cbGrupos.TabIndex = 8
        '
        'cbNivelGrupo
        '
        Me.cbNivelGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNivelGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNivelGrupo.Location = New System.Drawing.Point(126, 72)
        Me.cbNivelGrupo.Name = "cbNivelGrupo"
        Me.cbNivelGrupo.Size = New System.Drawing.Size(333, 23)
        Me.cbNivelGrupo.TabIndex = 21
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkUtilidadLinea)
        Me.LayoutControl1.Controls.Add(Me.chkComparativo)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.LayoutControl1.Controls.Add(Me.Hasta)
        Me.LayoutControl1.Controls.Add(Me.dtpHasta)
        Me.LayoutControl1.Controls.Add(Me.dtpDesde)
        Me.LayoutControl1.Controls.Add(Me.cbMonedaCambio)
        Me.LayoutControl1.Controls.Add(Me.txtTitulo)
        Me.LayoutControl1.Controls.Add(Me.chkCuenta)
        Me.LayoutControl1.Controls.Add(Me.chkSAnterior)
        Me.LayoutControl1.Controls.Add(Me.chkZeros)
        Me.LayoutControl1.Controls.Add(Me.cbGrupos)
        Me.LayoutControl1.Controls.Add(Me.cbNivelGrupo)
        Me.LayoutControl1.Controls.Add(Me.cbNiveles)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(337, 358, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(644, 291)
        Me.LayoutControl1.TabIndex = 19
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkUtilidadLinea
        '
        Me.chkUtilidadLinea.Location = New System.Drawing.Point(24, 119)
        Me.chkUtilidadLinea.Name = "chkUtilidadLinea"
        Me.chkUtilidadLinea.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUtilidadLinea.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkUtilidadLinea.Properties.Appearance.Options.UseFont = True
        Me.chkUtilidadLinea.Properties.Appearance.Options.UseForeColor = True
        Me.chkUtilidadLinea.Properties.Caption = "Imprimir Utilidad Bruta por Linea"
        Me.chkUtilidadLinea.Size = New System.Drawing.Size(596, 19)
        Me.chkUtilidadLinea.StyleController = Me.LayoutControl1
        Me.chkUtilidadLinea.TabIndex = 42
        '
        'chkComparativo
        '
        Me.chkComparativo.Location = New System.Drawing.Point(24, 96)
        Me.chkComparativo.Name = "chkComparativo"
        Me.chkComparativo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComparativo.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.chkComparativo.Properties.Appearance.Options.UseFont = True
        Me.chkComparativo.Properties.Appearance.Options.UseForeColor = True
        Me.chkComparativo.Properties.Caption = "Imprimir Comparativo"
        Me.chkComparativo.Size = New System.Drawing.Size(596, 19)
        Me.chkComparativo.StyleController = Me.LayoutControl1
        Me.chkComparativo.TabIndex = 41
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(126, 70)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMoneda.Properties.Appearance.Options.UseFont = True
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Size = New System.Drawing.Size(494, 22)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 39
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = 2
        Me.RadioGroup1.Location = New System.Drawing.Point(126, 198)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Porcentajes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Tradicional"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Interactivo")})
        Me.RadioGroup1.Size = New System.Drawing.Size(494, 55)
        Me.RadioGroup1.StyleController = Me.LayoutControl1
        Me.RadioGroup1.TabIndex = 40
        '
        'Hasta
        '
        Me.Hasta.EditValue = Nothing
        Me.Hasta.Location = New System.Drawing.Point(126, 46)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hasta.Properties.Appearance.Options.UseFont = True
        Me.Hasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Hasta.Size = New System.Drawing.Size(144, 20)
        Me.Hasta.StyleController = Me.LayoutControl1
        Me.Hasta.TabIndex = 40
        '
        'dtpHasta
        '
        Me.dtpHasta.EditValue = Nothing
        Me.dtpHasta.Location = New System.Drawing.Point(425, 174)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Properties.Appearance.Options.UseFont = True
        Me.dtpHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHasta.Size = New System.Drawing.Size(195, 20)
        Me.dtpHasta.StyleController = Me.LayoutControl1
        Me.dtpHasta.TabIndex = 39
        '
        'dtpDesde
        '
        Me.dtpDesde.EditValue = Nothing
        Me.dtpDesde.Location = New System.Drawing.Point(126, 174)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Properties.Appearance.Options.UseFont = True
        Me.dtpDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDesde.Size = New System.Drawing.Size(193, 20)
        Me.dtpDesde.StyleController = Me.LayoutControl1
        Me.dtpDesde.TabIndex = 38
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.Location = New System.Drawing.Point(126, 148)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbMonedaCambio.Properties.Appearance.Options.UseFont = True
        Me.cbMonedaCambio.Properties.Appearance.Options.UseForeColor = True
        Me.cbMonedaCambio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMonedaCambio.Size = New System.Drawing.Size(494, 22)
        Me.cbMonedaCambio.StyleController = Me.LayoutControl1
        Me.cbMonedaCambio.TabIndex = 36
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(126, 124)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(494, 20)
        Me.txtTitulo.StyleController = Me.LayoutControl1
        Me.txtTitulo.TabIndex = 39
        '
        'chkCuenta
        '
        Me.chkCuenta.Location = New System.Drawing.Point(463, 98)
        Me.chkCuenta.Name = "chkCuenta"
        Me.chkCuenta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCuenta.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkCuenta.Properties.Appearance.Options.UseFont = True
        Me.chkCuenta.Properties.Appearance.Options.UseForeColor = True
        Me.chkCuenta.Properties.Caption = "Ocultar Cuentas"
        Me.chkCuenta.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkCuenta.Size = New System.Drawing.Size(157, 22)
        Me.chkCuenta.StyleController = Me.LayoutControl1
        Me.chkCuenta.TabIndex = 33
        '
        'chkSAnterior
        '
        Me.chkSAnterior.Location = New System.Drawing.Point(463, 72)
        Me.chkSAnterior.Name = "chkSAnterior"
        Me.chkSAnterior.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSAnterior.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkSAnterior.Properties.Appearance.Options.UseFont = True
        Me.chkSAnterior.Properties.Appearance.Options.UseForeColor = True
        Me.chkSAnterior.Properties.Caption = "Saldo Anterior"
        Me.chkSAnterior.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkSAnterior.Size = New System.Drawing.Size(157, 22)
        Me.chkSAnterior.StyleController = Me.LayoutControl1
        Me.chkSAnterior.TabIndex = 34
        '
        'chkZeros
        '
        Me.chkZeros.Location = New System.Drawing.Point(463, 46)
        Me.chkZeros.Name = "chkZeros"
        Me.chkZeros.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkZeros.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkZeros.Properties.Appearance.Options.UseFont = True
        Me.chkZeros.Properties.Appearance.Options.UseForeColor = True
        Me.chkZeros.Properties.Caption = "Eliminar Ceros?"
        Me.chkZeros.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkZeros.Size = New System.Drawing.Size(157, 22)
        Me.chkZeros.StyleController = Me.LayoutControl1
        Me.chkZeros.TabIndex = 35
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.TabbedControlGroup1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(644, 291)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 257)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(624, 14)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup3
        Me.TabbedControlGroup1.SelectedTabPageIndex = 0
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(624, 257)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4})
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem7, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem15})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(600, 211)
        Me.LayoutControlGroup3.Text = "ESTADO DE RESULTADO TRADICIONAL"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbGrupos
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(439, 26)
        Me.LayoutControlItem1.Text = "Grupos:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbNivelGrupo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(439, 26)
        Me.LayoutControlItem2.Text = "Nivel de Agrupación:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbNiveles
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(439, 26)
        Me.LayoutControlItem3.Text = "Niveles:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtTitulo
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(600, 24)
        Me.LayoutControlItem7.Text = "Tituilo"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbMonedaCambio
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 102)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(600, 26)
        Me.LayoutControlItem4.Text = "Moneda:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dtpDesde
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 128)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(299, 24)
        Me.LayoutControlItem5.Text = "Desde:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.RadioGroup1
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 152)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(0, 59)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(156, 59)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(600, 59)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Presentación:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(99, 13)
        Me.LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.dtpHasta
        Me.LayoutControlItem8.Location = New System.Drawing.Point(299, 128)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(301, 24)
        Me.LayoutControlItem8.Text = "Hasta:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.chkCuenta
        Me.LayoutControlItem9.Location = New System.Drawing.Point(439, 52)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(161, 26)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.chkSAnterior
        Me.LayoutControlItem10.Location = New System.Drawing.Point(439, 26)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(161, 26)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.chkZeros
        Me.LayoutControlItem15.Location = New System.Drawing.Point(439, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(161, 26)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem16, Me.LayoutControlItem17, Me.EmptySpaceItem2, Me.LayoutControlItem18, Me.LayoutControlItem19})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(600, 211)
        Me.LayoutControlGroup4.Text = "ESTADO DE RESULTADO GERENCIAL"
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.Hasta
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(250, 24)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(250, 24)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(250, 24)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "A la Fecha:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cbMoneda
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(600, 26)
        Me.LayoutControlItem17.Text = "Moneda:"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(99, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(250, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(350, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.chkComparativo
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(600, 23)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.chkUtilidadLinea
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 73)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(600, 138)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        Me.LayoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
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
        Me.DockPanel1.ID = New System.Guid("9147d4e1-c8f3-47b3-b990-822b43581b71")
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
        'frmLibroEstadoResultado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(784, 291)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmLibroEstadoResultado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes - Estado de Resultado"
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkUtilidadLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkComparativo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMonedaCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkZeros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Per_Detail As New VB.SysContab.PeriodoDetails
    Dim Fechas As New VB.SysContab.FechasdeOperacion

    Private Sub frmLibroEstadoResultado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim Tasa As New VB.SysContab.Tasa_CambioDB()
        ' 'r.CambiarEstilo(Me)
        'i = 0

        GetMonedasList(cbMonedaCambio)

        'cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        'cbMonedaCambio.ValueMember = "MonedaCambio"
        'cbMonedaCambio.DisplayMember = "Nombre"
        '
        cbGrupos.DataSource = Libros.Grupos("1", "R").Tables("Grupos")
        cbGrupos.ValueMember = "CGrupo"
        cbGrupos.DisplayMember = "Nombre"
        cbGrupos.SelectedIndex = 0
        '
        cbNivelGrupo.DataSource = Libros.NivelesGrupos("%", "R").Tables("NivelesGrupos")
        cbNivelGrupo.ValueMember = "Nivel"
        cbNivelGrupo.DisplayMember = "Nombre"
        '
        cbNiveles.DataSource = Libros.Niveles().Tables("Niveles") 'Grupos.GetList_SP("%").Tables("Niveles")
        cbNiveles.ValueMember = "Nivel"
        cbNiveles.DisplayMember = "Descripcion"
        '
        Me.chkSAnterior.Checked = True
        Me.chkZeros.Checked = True
        RadioGroup1.EditValue = 2

        'Me.rbTrad.Checked = True
        'Me.cbCtaDistribucion.SelectedIndex = 0

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        '
        dtpDesde.Properties.MinValue = Fechas.FechaMinima
        dtpDesde.Properties.MaxValue = Fechas.FechaMaxima
        dtpHasta.Properties.MinValue = Fechas.FechaMinima
        dtpHasta.Properties.MaxValue = Fechas.FechaMaxima
        '
        dtpDesde.DateTime = New DateTime(f.Year, f.Month, 1)
        dtpHasta.DateTime = UltimoDiaDelMes(f.Date).Date
        Hasta.DateTime = UltimoDiaDelMes(f.Date).Date

        Me.txtTitulo.Text = "Estado de Resultado"

        '
        'Me.cbMonedaCambio.SelectedValue = MonedaBase
        Me.chkCuenta.Checked = True
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If TabbedControlGroup1.SelectedTabPageIndex = 0 Then


            'Dim fReportes As New frmReportes()
            'Dim Periodo As New VB.SysContab.PeriodoDetails()
            'Dim DetalleNivel As New VB.SysContab.NivelDetailsDB()
            'Dim dsBalanza As New DataSet()
            'Dim DS As New DataSet
            'Dim DsDistribucion As New DataSet
            'Dim rNivel As Integer
            'Empresa = Empresas.GetDetails(EmpresaActual)

            'ShowSplash()
            ''Crear el Catalogo
            'Libros.Imprimir_LibroBalanza(0, Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date, _
            '    Login, Me.txtTitulo.Text, "R", "%", _
            '    IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue), _
            '     Me.chkCuenta.Checked, Empresa.MonedaBase, Me.cbMonedaCambio.EditValue, _
            '    Me.chkZeros.Checked, Me.cbGrupos.SelectedValue, Me.cbNivelGrupo.SelectedValue, "S", Me.chkSAnterior.Checked, dsBalanza, False, Empresa.Nombre, _
            '    "%", "%", 0, 0, 0)

            ''Agregar las formulas
            'If Me.cbGrupos.SelectedValue = "%" And dsBalanza.Tables("LibroBalanza").Rows.Count > 0 Then
            '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '    'Buscar los Grupos que son resultado de una formula
            '    Dim Formulas As New DataSet, Formula() As Char
            '    Dim arreglo() As Object
            '    Dim j As Integer, rMayor As String
            '    Dim SAnterior, Debitos, Creditos As Double
            '    Dim Saldo As Object

            '    Dim First As Double
            '    Dim Last As Double
            '    First = 0
            '    Last = 0

            '    Formulas = Libros.Grupos("0", "R")
            '    arreglo = dsBalanza.Tables("LibroBalanza").Rows(0).ItemArray
            '    Try

            '        For i = 0 To Formulas.Tables(0).Rows.Count - 1
            '            Formula = Formulas.Tables(0).Rows(i)("Total")
            '            SAnterior = 0
            '            Debitos = 0
            '            Creditos = 0
            '            j = 0
            '            For j = 0 To (Formulas.Tables(0).Rows(i)("Total").split(",").GetUpperBound(0))
            '                Saldo = dsBalanza.Tables("LibroBalanza").Compute("Sum(SaldoAnterior)", "Balres= 'R' and MayorGrupo = '" & Formulas.Tables(0).Rows(i)("Total").split(",")(j) & "'")
            '                SAnterior += IIf(IsNothing(Saldo) Or IsDBNull(Saldo), 0, Saldo)
            '                Saldo = dsBalanza.Tables("LibroBalanza").Compute("Sum(Debitos)", "Balres= 'R'  and MayorGrupo = '" & Formulas.Tables(0).Rows(i)("Total").split(",")(j) & "'")
            '                Debitos += IIf(IsNothing(Saldo) Or IsDBNull(Saldo), 0, Saldo)
            '                Saldo = dsBalanza.Tables("LibroBalanza").Compute("Sum(Creditos)", "Balres= 'R'  and MayorGrupo = '" & Formulas.Tables(0).Rows(i)("Total").split(",")(j) & "'")
            '                Creditos += IIf(IsNothing(Saldo) Or IsDBNull(Saldo), 0, Saldo)
            '            Next

            '            'Evaluar
            '            If Formulas.Tables(0).Rows(i)("Operacion") = "+" Then
            '                SAnterior += Formulas.Tables(0).Rows(i)("factor")
            '                Debitos += Formulas.Tables(0).Rows(i)("factor")
            '                Creditos += Formulas.Tables(0).Rows(i)("factor")
            '            ElseIf Formulas.Tables(0).Rows(i)("Operacion") = "-" Then
            '                SAnterior -= Formulas.Tables(0).Rows(i)("factor")
            '                Debitos -= Formulas.Tables(0).Rows(i)("factor")
            '                Creditos -= Formulas.Tables(0).Rows(i)("factor")
            '            ElseIf Formulas.Tables(0).Rows(i)("Operacion") = "*" Then
            '                SAnterior *= Formulas.Tables(0).Rows(i)("factor")
            '                Debitos *= Formulas.Tables(0).Rows(i)("factor")
            '                Creditos *= Formulas.Tables(0).Rows(i)("factor")
            '            ElseIf Formulas.Tables(0).Rows(i)("Operacion") = "/" Then
            '                SAnterior /= Formulas.Tables(0).Rows(i)("factor")
            '                Debitos /= Formulas.Tables(0).Rows(i)("factor")
            '                Creditos /= Formulas.Tables(0).Rows(i)("factor")
            '            End If

            '            'Agregar el registro
            '            arreglo(2) = Formulas.Tables(0).Rows(i)("CGrupo") & "XXX"  'Libros.GruposCTA(Formula(Formula.GetUpperBound(0)), "R") & "XXX" 'Cuenta
            '            arreglo(6) = "M"
            '            arreglo(8) = "00"
            '            arreglo(16) = Formulas.Tables(0).Rows(i)("Nombre")
            '            arreglo(3) = SAnterior '* -1
            '            arreglo(4) = Debitos '* -1
            '            arreglo(5) = Creditos '* -1
            '            arreglo(17) = Formulas.Tables(0).Rows(i)("CGrupo")
            '            arreglo(18) = 0
            '            arreglo(19) = Formulas.Tables(0).Rows(i)("Nombre")
            '            arreglo(20) = Formulas.Tables(0).Rows(i)("CGrupo")
            '            arreglo(21) = Formulas.Tables(0).Rows(i)("Nombre")


            '            arreglo(47) = Formulas.Tables(0).Rows(i)("CGrupo")
            '            arreglo(48) = Formulas.Tables(0).Rows(i)("Nombre")
            '            arreglo(51) = Formulas.Tables(0).Rows(i)("CGrupo")
            '            arreglo(52) = Formulas.Tables(0).Rows(i)("Nombre")

            '            arreglo(37) = "2"

            '            dsBalanza.Tables("LibroBalanza").Rows.Add(arreglo)


            '        Next

            '        dsBalanza.Tables("LibroBalanza").Rows.RemoveAt(dsBalanza.Tables("LibroBalanza").Rows.Count - 1)

            '        'Agregar el registro
            '        arreglo(2) = Formulas.Tables(0).Rows(i - 1)("CGrupo") & "XXX" 'Cuenta
            '        arreglo(6) = "M"
            '        arreglo(8) = "00"
            '        arreglo(16) = Formulas.Tables(0).Rows(i - 1)("Nombre")
            '        arreglo(3) = SAnterior '* -1
            '        arreglo(4) = Debitos '* -1
            '        arreglo(5) = Creditos '* -1
            '        arreglo(17) = Formulas.Tables(0).Rows(i - 1)("CGrupo")
            '        arreglo(18) = 0
            '        arreglo(19) = Formulas.Tables(0).Rows(i - 1)("Nombre")
            '        arreglo(20) = Formulas.Tables(0).Rows(i - 1)("CGrupo")
            '        arreglo(21) = Formulas.Tables(0).Rows(i - 1)("Nombre")

            '        arreglo(47) = Formulas.Tables(0).Rows(i - 1)("CGrupo")
            '        arreglo(48) = Formulas.Tables(0).Rows(i - 1)("Nombre")
            '        arreglo(51) = Formulas.Tables(0).Rows(i - 1)("CGrupo")
            '        arreglo(52) = Formulas.Tables(0).Rows(i - 1)("Nombre")


            '        arreglo(37) = "2"
            '        dsBalanza.Tables("LibroBalanza").Rows.Add(arreglo)

            '        ''''''''Last = Last - (SAnterior + Debitos + Creditos)
            '        '''''''''MsgBox(Last)
            '        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '        ''''''''arreglo(2) = Libros.GruposCTA(Formula(Formula.GetUpperBound(0)), "R") & "XXX" 'Cuenta
            '        ''''''''arreglo(6) = "M"
            '        ''''''''arreglo(8) = "00"
            '        ''''''''arreglo(16) = Formulas.Tables(0).Rows(i - 1)("Nombre")
            '        ''''''''arreglo(3) = 0 'SAnterior
            '        ''''''''' Si el periodo ya fue cerrado ....
            '        ''''''''arreglo(4) = CDbl(Comprobantes.SaldoxCuenta(Periodos.CuentaUtilidadPerdida(), Me.cbPeriodos.SelectedValue)).ToString(Round) 'First - Last 'Debitos
            '        ''''''''arreglo(5) = 0 'Creditos
            '        ''''''''arreglo(17) = Formulas.Tables(0).Rows(i - 1)("CGrupo")
            '        ''''''''arreglo(18) = 0
            '        ''''''''arreglo(19) = Formulas.Tables(0).Rows(i - 1)("Nombre")
            '        ''''''''arreglo(20) = Formulas.Tables(0).Rows(i - 1)("CGrupo")
            '        ''''''''arreglo(21) = Formulas.Tables(0).Rows(i - 1)("Nombre")

            '        ''''''''dsBalanza.Tables("LibroBalanza").Rows.Add(arreglo)
            '        ''''''''''''''''''''''''''''''''''''''''''''''''''''
            '        'Last = Last - (SAnterior + Debitos + Creditos)
            '        'MsgBox(First - Last)

            '    Catch ex As Exception
            '        XtraMsg(ex.Message, MessageBoxIcon.Error)
            '        HideSplash()
            '    End Try

            'End If
            ''Firmas
            'Dim ldt As New DataSet
            'ldt.Tables.Add(Libros.GetFirmasContables())
            'ldt.WriteXml(Application.StartupPath & "\xml\FirmasContables.xml", XmlWriteMode.WriteSchema)

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Pasar el DataSet Original
            'If Me.rbDeta.Checked Then
            If RadioGroup1.EditValue = 3 Then   'Interactivo

                ''Dim rColilla As New rptEstadoResultadoconsubreportesxml()
                ''Dim rColilla As New rptEstadoResultadoconsubreportesxml_Distribucion
                'Dim rColilla As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                'rColilla.Load(Application.StartupPath & "\Reportes\rptEstadoResultadoconsubreportesxml_Distribucion.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                ''
                'DS = Libros.Detalle_Apie(Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date, 0, cbMonedaCambio.EditValue)
                'DsDistribucion = VB.SysContab.LibrosDB.Detalle_Distribucion(Me.dtpDesde.DateTime.Date, Me.dtpHasta.DateTime.Date, Me.cbMonedaCambio.EditValue)

                'dsBalanza.WriteXml(Application.StartupPath & "\xml\ER.xml", XmlWriteMode.WriteSchema)
                'DS.WriteXml(Application.StartupPath & "\xml\ERDetalle.xml", XmlWriteMode.WriteSchema)
                'DsDistribucion.WriteXml(Application.StartupPath & "\xml\dDistribucion.xml", XmlWriteMode.WriteSchema)

                'rColilla.Database.Tables("vcd").Location = Application.StartupPath & "\xml\ER.xml"
                'rColilla.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
                'Dim i As Integer
                'For i = 0 To rColilla.Subreports.Count - 1
                '    rColilla.Subreports.Item(i).Database.Tables("_GetDetalleApie;1").Location = Application.StartupPath & "\xml\ERDetalle.xml"
                '    If rColilla.Subreports.Item(i).Database.Tables.Count > 1 Then
                '        rColilla.Subreports.Item(i).Database.Tables("DetalleApie").Location = Application.StartupPath & "\xml\dDistribucion.xml"
                '    End If
                'Next
                'fReportes.crvReportes.ReportSource = rColilla
                ' ElseIf Me.rbTrad.Checked Then

            ElseIf RadioGroup1.EditValue = 2 Then   'Tradicional

                ShowSplash("Generando Informe...")

                Dim DT_ER As DataTable = ObtieneDatos("JAR_EstadoDeResultado_V2",
                                                      dtpDesde.DateTime.Date,
                                                      dtpHasta.DateTime.Date,
                                                      cbMonedaCambio.EditValue,
                                                      EmpresaActual)

                Dim rpt As New rptEstadoResultadoTrandicional
                rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image

                'Try
                '    Dim DT_LOGO As DataTable = VB.SysContab.EmpresasDB.GetLogoEmpresa().Tables(0)
                '    Dim _logo As Byte() = DirectCast(DT_LOGO.Rows.Item(0)("Logo"), Byte())
                '    Dim ms As New System.IO.MemoryStream(_logo)
                '    rpt.pLogo.Image = Image.FromStream(ms)
                'Catch ex As Exception
                'End Try

                'rpt.DataSource = DT_ER
                'HideSplash()
                'rpt.ShowPrintMarginsWarning = False
                'rpt.BringToFront()
                'rpt.ShowRibbonPreview()

                frmMDIReporte.Dispose()
                '
                With frmMDIReporte
                    .Show()
                    .Text = Me.Text
                    .WindowState = FormWindowState.Maximized
                End With
                '
                VistaPreviaDX(rpt, DT_ER, "Estado de Resultado Tradicional", True)
                '
                HideSplash()

                'frmManejadorReporte.Dispose()
                ''
                'With frmManejadorReporte
                '    .DocumentViewer1.PrintingSystem = rpt.PrintingSystem
                '    rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
                '    rpt.DataSource = DT_ER
                '    rpt.ShowPrintMarginsWarning = False
                '    rpt.CreateDocument()
                '    .MdiParent = frmMDIReporte
                '    .CerrarMDI = True
                '    .Show()
                '    .Text = "Estado de Resultado " & NombreEmpresaActual
                '    .WindowState = FormWindowState.Maximized
                'End With


                'frmManejadorReporte.Dispose()
                ''
                'With frmManejadorReporte
                '    .DocumentViewer1.PrintingSystem = rpt.PrintingSystem
                '    rpt.DataSource = DT_ER
                '    rpt.ShowPrintMarginsWarning = False
                '    rpt.CreateDocument()
                '    .Show()
                '    .WindowState = FormWindowState.Maximized
                'End With       


                'Dim rColilla As New CrystalDecisions.CrystalReports.Engine.ReportDocument

                'If EmpresaActual = 1 Then
                '    rColilla.Load(Application.StartupPath & "\Reportes\rptEstadoResultadoTradicional_RAMAC.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                'Else
                '    rColilla.Load(Application.StartupPath & "\Reportes\rptEstadoResultadoTradicional.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                'End If


                'dsBalanza.WriteXml(Application.StartupPath & "\xml\ER.xml", XmlWriteMode.WriteSchema)
                'rColilla.Database.Tables("vcd").Location = Application.StartupPath & "\xml\ER.xml"
                'For i = 0 To rColilla.Subreports.Count - 1
                '    If rColilla.Subreports.Item(i).Name = "Firmas1" Or rColilla.Subreports.Item(i).Name = "Firmas2" Or rColilla.Subreports.Item(i).Name = "Firmas3" Then
                '        rColilla.Subreports.Item(i).Database.Tables("FirmasContables").Location = Application.StartupPath & "\xml\FirmasContables.xml"
                '    End If

                'Next
                'fReportes.crvReportes.ReportSource = rColilla
                ' Else
            ElseIf RadioGroup1.EditValue = 2 Then   'Porcentajes

                '    Dim rColilla As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                '    rColilla.Load(Application.StartupPath & "\Reportes\rptEstadoResultado_Porcentaje.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                '    dsBalanza.WriteXml(Application.StartupPath & "\xml\ER.xml", XmlWriteMode.WriteSchema)
                '    rColilla.Database.Tables("vcd").Location = Application.StartupPath & "\xml\ER.xml"
                '    For i = 0 To rColilla.Subreports.Count - 1
                '        If rColilla.Subreports.Item(i).Name = "Firmas1" Or rColilla.Subreports.Item(i).Name = "Firmas2" Or rColilla.Subreports.Item(i).Name = "Firmas3" Then
                '            rColilla.Subreports.Item(i).Database.Tables("FirmasContables").Location = Application.StartupPath & "\xml\FirmasContables.xml"
                '        End If

                '    Next
                '    fReportes.crvReportes.ReportSource = rColilla
                'End If

                'fReportes.crvReportes.Zoom(91)
                'fReportes.Show()
                'HideSplash()
            End If
        Else

            ShowSplash("Generando Informe...")

            Dim DT_ER As DataTable = ObtieneDatos("JAR_EstadoDeResultado",
                                                  Hasta.DateTime.Date,
                                                  cbMoneda.EditValue,
                                                  EmpresaActual,
                                                  IIf(chkComparativo.Checked, 1, 0))

            If chkComparativo.Checked Then
                Dim rpt As New rptEstadoResultado
                rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image

                'rpt.DataSource = DT_ER  'ObtieneDatos("JAR_EstadoDeResultado", Hasta.DateTime.Date, cbMoneda.EditValue, EmpresaActual, IIf(chkComparativo.Checked, 1, 0))
                'HideSplash()

                'rpt.ShowPrintMarginsWarning = False                
                'rpt.BringToFront()
                'rpt.ShowRibbonPreview()

                VistaPreviaDX(rpt, DT_ER, "Estado de Resultado Gerencial Comparativo")
                HideSplash()
                '
                If chkUtilidadLinea.Checked Then
                    Dim rptUL As New rptEstadoResultadoPorLinea
                    rptUL.DataSource = DT_ER
                    rptUL.BringToFront()
                    rptUL.ShowRibbonPreview()
                End If
            Else
                Dim rpt As New rptEstadoResultadoGeneral
                rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image

                rpt.DataSource = DT_ER  'ObtieneDatos("JAR_EstadoDeResultado", Hasta.DateTime.Date, cbMoneda.EditValue, EmpresaActual, IIf(chkComparativo.Checked, 1, 0))
                'HideSplash()

                'rpt.ShowPrintMarginsWarning = False
                'rpt.BringToFront()
                'rpt.ShowRibbonPreview()

                VistaPreviaDX(rpt, DT_ER, "Estado de Resultado Gerencial")
                HideSplash()

                If chkUtilidadLinea.Checked Then
                    Dim rptUL As New rptEstadoResultadoPorLinea
                    rptUL.DT = DT_ER
                    rptUL.DataSource = DT_ER
                    rptUL.BringToFront()
                    rptUL.ShowRibbonPreview()
                End If
            End If

        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub bFormato_Click(sender As Object, e As EventArgs) Handles bFormato.Click
        With My.Forms.FrmConfiguraCheque
            .Tipo = 20
            .Text = "Diseñar Estado de Resultado"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub bNuevoER_Click(sender As Object, e As EventArgs) Handles bNuevoER.Click
        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        ShowSplash("Generando Reporte...")

        Try
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 20 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)

            Cadena = Application.StartupPath & "\rptEstadoResultado.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

        Catch ex As Exception
            Temp = False
        End Try

        Dim rpt As rptEstadoResultado

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptEstadoResultado.repx", True)
        Else
            rpt = New rptEstadoResultado
        End If

        '  rpt.lblPeriodo.Text = "AL: " & dtpHasta.Value.Date.ToShortDateString

        rpt.DataSource = VB.SysContab.LibrosDB.ReporteEstadoSituacion_JAR(New DateTime(dtpHasta.DateTime.Year, dtpHasta.DateTime.Month, 1).Date, dtpHasta.DateTime.Date, cbMonedaCambio.EditValue)
        HideSplash()

        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        rpt.ShowRibbonPreview()
    End Sub

    Private Sub rbPorc_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabbedControlGroup1_SelectedPageChanged(sender As Object, e As DevExpress.XtraLayout.LayoutTabPageChangedEventArgs) Handles TabbedControlGroup1.SelectedPageChanged
        GetMonedasList(cbMoneda)
    End Sub
End Class
