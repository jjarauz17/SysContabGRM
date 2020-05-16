Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmNuevaCuenta
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmNuevaCuenta = Nothing

    Public Shared Function Instance() As frmNuevaCuenta
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmNuevaCuenta()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim Empresa As New VB.SysContab.EmpresasDB()
    Dim Detalles As New VB.SysContab.EmpresasDetails()
    Dim grupos As String
    Dim Cod_Grupo As String
    Dim Cod_Agrupacion As String
    Dim TG As String
    Dim CB As String
    Friend WithEvents chkRetencion As System.Windows.Forms.CheckBox
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyGrupoSuperior As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkRebajas As System.Windows.Forms.CheckBox
    Friend WithEvents chkDevolucion As System.Windows.Forms.CheckBox
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkMnto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkRendicion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkActiva As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkProyecto As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Dim Agrupaciones As String

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents cmdAcumulados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSaldoDolar1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoIniDolar As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoActual As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoInicial As System.Windows.Forms.TextBox
    Friend WithEvents cbCuentaDe As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents lbGruposSup As System.Windows.Forms.ListBox
    Friend WithEvents cbGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtPresupuestoAnual As System.Windows.Forms.TextBox
    Friend WithEvents lbCuenta As System.Windows.Forms.ListBox
    Friend WithEvents cbClase As System.Windows.Forms.ComboBox
    Friend WithEvents cbAgrupaciones As System.Windows.Forms.ComboBox
    Friend WithEvents cbGpo_Presupuesto As System.Windows.Forms.ComboBox
    Friend WithEvents chkProveedor As System.Windows.Forms.CheckBox
    Friend WithEvents chkCajaChica As System.Windows.Forms.CheckBox
    Friend WithEvents chkInventario As System.Windows.Forms.CheckBox
    Friend WithEvents chkDistribucion As System.Windows.Forms.CheckBox
    Friend WithEvents chkDeOrden As System.Windows.Forms.CheckBox
    Friend WithEvents ChkUP As System.Windows.Forms.CheckBox
    Friend WithEvents ChkUA As System.Windows.Forms.CheckBox
    Friend WithEvents chkchica As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuevaCuenta))
        Me.cmdAcumulados = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.chkRetencion = New System.Windows.Forms.CheckBox()
        Me.chkchica = New System.Windows.Forms.CheckBox()
        Me.ChkUA = New System.Windows.Forms.CheckBox()
        Me.ChkUP = New System.Windows.Forms.CheckBox()
        Me.chkDeOrden = New System.Windows.Forms.CheckBox()
        Me.chkDistribucion = New System.Windows.Forms.CheckBox()
        Me.chkInventario = New System.Windows.Forms.CheckBox()
        Me.chkProveedor = New System.Windows.Forms.CheckBox()
        Me.chkCajaChica = New System.Windows.Forms.CheckBox()
        Me.cbGpo_Presupuesto = New System.Windows.Forms.ComboBox()
        Me.cbAgrupaciones = New System.Windows.Forms.ComboBox()
        Me.cbClase = New System.Windows.Forms.ComboBox()
        Me.lbCuenta = New System.Windows.Forms.ListBox()
        Me.cbGrupos = New System.Windows.Forms.ComboBox()
        Me.lbGruposSup = New System.Windows.Forms.ListBox()
        Me.txtSaldoDolar1 = New System.Windows.Forms.TextBox()
        Me.txtSaldoIniDolar = New System.Windows.Forms.TextBox()
        Me.txtPresupuestoAnual = New System.Windows.Forms.TextBox()
        Me.txtSaldoActual = New System.Windows.Forms.TextBox()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.cbCuentaDe = New System.Windows.Forms.ComboBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkActiva = New DevExpress.XtraEditors.CheckEdit()
        Me.chkMnto = New DevExpress.XtraEditors.CheckEdit()
        Me.chkRendicion = New DevExpress.XtraEditors.CheckEdit()
        Me.chkRebajas = New System.Windows.Forms.CheckBox()
        Me.chkDevolucion = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyGrupoSuperior = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.chkProyecto = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkActiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMnto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRendicion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyGrupoSuperior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.chkProyecto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAcumulados
        '
        Me.cmdAcumulados.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulados.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAcumulados.Appearance.Options.UseFont = True
        Me.cmdAcumulados.Appearance.Options.UseForeColor = True
        Me.cmdAcumulados.ImageOptions.Image = CType(resources.GetObject("cmdAcumulados.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAcumulados.Location = New System.Drawing.Point(12, 54)
        Me.cmdAcumulados.Name = "cmdAcumulados"
        Me.cmdAcumulados.Size = New System.Drawing.Size(107, 38)
        Me.cmdAcumulados.StyleController = Me.LayoutControl2
        Me.cmdAcumulados.TabIndex = 10
        Me.cmdAcumulados.Text = "Acumulados"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl2.Controls.Add(Me.cmdAcumulados)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1011, 175, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(131, 434)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(12, 384)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(107, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl2
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(107, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl2
        Me.cmdAceptar.TabIndex = 9
        Me.cmdAceptar.Text = "&Guardar"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem27, Me.LayoutControlItem28, Me.EmptySpaceItem2, Me.LayoutControlItem26})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(131, 434)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.cmdAcumulados
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem27.TextVisible = False
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.cmdCancelar
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 372)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem28.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 84)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(111, 288)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.cmdAceptar
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'chkRetencion
        '
        Me.chkRetencion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRetencion.Enabled = False
        Me.chkRetencion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRetencion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkRetencion.Location = New System.Drawing.Point(631, 228)
        Me.chkRetencion.Name = "chkRetencion"
        Me.chkRetencion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkRetencion.Size = New System.Drawing.Size(191, 20)
        Me.chkRetencion.TabIndex = 128
        Me.chkRetencion.Text = "Retención"
        Me.chkRetencion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkchica
        '
        Me.chkchica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkchica.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkchica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkchica.Location = New System.Drawing.Point(631, 204)
        Me.chkchica.Name = "chkchica"
        Me.chkchica.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkchica.Size = New System.Drawing.Size(191, 20)
        Me.chkchica.TabIndex = 127
        Me.chkchica.Text = "Caja Chica"
        Me.chkchica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkUA
        '
        Me.ChkUA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkUA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkUA.Location = New System.Drawing.Point(631, 156)
        Me.ChkUA.Name = "ChkUA"
        Me.ChkUA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkUA.Size = New System.Drawing.Size(191, 20)
        Me.ChkUA.TabIndex = 126
        Me.ChkUA.Text = "Util/Acumulada"
        Me.ChkUA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkUP
        '
        Me.ChkUP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkUP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkUP.Location = New System.Drawing.Point(631, 132)
        Me.ChkUP.Name = "ChkUP"
        Me.ChkUP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkUP.Size = New System.Drawing.Size(191, 20)
        Me.ChkUP.TabIndex = 125
        Me.ChkUP.Text = "Util / Perdida"
        Me.ChkUP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkDeOrden
        '
        Me.chkDeOrden.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDeOrden.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeOrden.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkDeOrden.Location = New System.Drawing.Point(631, 180)
        Me.chkDeOrden.Name = "chkDeOrden"
        Me.chkDeOrden.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkDeOrden.Size = New System.Drawing.Size(191, 20)
        Me.chkDeOrden.TabIndex = 124
        Me.chkDeOrden.Text = "De Orden"
        Me.chkDeOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDeOrden.Visible = False
        '
        'chkDistribucion
        '
        Me.chkDistribucion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDistribucion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDistribucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkDistribucion.Location = New System.Drawing.Point(631, 108)
        Me.chkDistribucion.Name = "chkDistribucion"
        Me.chkDistribucion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkDistribucion.Size = New System.Drawing.Size(191, 20)
        Me.chkDistribucion.TabIndex = 123
        Me.chkDistribucion.Text = "Distribución"
        Me.chkDistribucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkInventario
        '
        Me.chkInventario.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkInventario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInventario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkInventario.Location = New System.Drawing.Point(631, 84)
        Me.chkInventario.Name = "chkInventario"
        Me.chkInventario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkInventario.Size = New System.Drawing.Size(191, 20)
        Me.chkInventario.TabIndex = 122
        Me.chkInventario.Text = "Inventario"
        Me.chkInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkProveedor
        '
        Me.chkProveedor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkProveedor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkProveedor.Location = New System.Drawing.Point(631, 36)
        Me.chkProveedor.Name = "chkProveedor"
        Me.chkProveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkProveedor.Size = New System.Drawing.Size(191, 20)
        Me.chkProveedor.TabIndex = 120
        Me.chkProveedor.Text = "Proveedor"
        Me.chkProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkCajaChica
        '
        Me.chkCajaChica.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCajaChica.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCajaChica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkCajaChica.Location = New System.Drawing.Point(631, 60)
        Me.chkCajaChica.Name = "chkCajaChica"
        Me.chkCajaChica.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkCajaChica.Size = New System.Drawing.Size(191, 20)
        Me.chkCajaChica.TabIndex = 121
        Me.chkCajaChica.Text = "Caja y Banco"
        Me.chkCajaChica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbGpo_Presupuesto
        '
        Me.cbGpo_Presupuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGpo_Presupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGpo_Presupuesto.Items.AddRange(New Object() {"Tipo de Cuenta", "Débito", "Crédito"})
        Me.cbGpo_Presupuesto.Location = New System.Drawing.Point(524, 184)
        Me.cbGpo_Presupuesto.Name = "cbGpo_Presupuesto"
        Me.cbGpo_Presupuesto.Size = New System.Drawing.Size(92, 23)
        Me.cbGpo_Presupuesto.TabIndex = 118
        '
        'cbAgrupaciones
        '
        Me.cbAgrupaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAgrupaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAgrupaciones.Location = New System.Drawing.Point(147, 209)
        Me.cbAgrupaciones.Name = "cbAgrupaciones"
        Me.cbAgrupaciones.Size = New System.Drawing.Size(469, 23)
        Me.cbAgrupaciones.TabIndex = 5
        '
        'cbClase
        '
        Me.cbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClase.Items.AddRange(New Object() {"Tipo de Cuenta", "Débito", "Crédito"})
        Me.cbClase.Location = New System.Drawing.Point(147, 134)
        Me.cbClase.Name = "cbClase"
        Me.cbClase.Size = New System.Drawing.Size(238, 23)
        Me.cbClase.TabIndex = 8
        '
        'lbCuenta
        '
        Me.lbCuenta.Location = New System.Drawing.Point(12, 282)
        Me.lbCuenta.Name = "lbCuenta"
        Me.lbCuenta.Size = New System.Drawing.Size(604, 17)
        Me.lbCuenta.TabIndex = 113
        Me.lbCuenta.Visible = False
        '
        'cbGrupos
        '
        Me.cbGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupos.Location = New System.Drawing.Point(147, 159)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.Size = New System.Drawing.Size(469, 23)
        Me.cbGrupos.TabIndex = 4
        '
        'lbGruposSup
        '
        Me.lbGruposSup.BackColor = System.Drawing.SystemColors.Control
        Me.lbGruposSup.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbGruposSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGruposSup.ItemHeight = 16
        Me.lbGruposSup.Location = New System.Drawing.Point(12, 325)
        Me.lbGruposSup.Name = "lbGruposSup"
        Me.lbGruposSup.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lbGruposSup.Size = New System.Drawing.Size(604, 112)
        Me.lbGruposSup.TabIndex = 112
        Me.lbGruposSup.Visible = False
        '
        'txtSaldoDolar1
        '
        Me.txtSaldoDolar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDolar1.Location = New System.Drawing.Point(446, 258)
        Me.txtSaldoDolar1.Name = "txtSaldoDolar1"
        Me.txtSaldoDolar1.Size = New System.Drawing.Size(20, 20)
        Me.txtSaldoDolar1.TabIndex = 108
        Me.txtSaldoDolar1.Visible = False
        '
        'txtSaldoIniDolar
        '
        Me.txtSaldoIniDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoIniDolar.Location = New System.Drawing.Point(470, 258)
        Me.txtSaldoIniDolar.Name = "txtSaldoIniDolar"
        Me.txtSaldoIniDolar.Size = New System.Drawing.Size(146, 20)
        Me.txtSaldoIniDolar.TabIndex = 106
        Me.txtSaldoIniDolar.Visible = False
        '
        'txtPresupuestoAnual
        '
        Me.txtPresupuestoAnual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresupuestoAnual.Location = New System.Drawing.Point(147, 258)
        Me.txtPresupuestoAnual.Name = "txtPresupuestoAnual"
        Me.txtPresupuestoAnual.Size = New System.Drawing.Size(295, 20)
        Me.txtPresupuestoAnual.TabIndex = 7
        Me.txtPresupuestoAnual.Visible = False
        '
        'txtSaldoActual
        '
        Me.txtSaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoActual.Location = New System.Drawing.Point(147, 234)
        Me.txtSaldoActual.Name = "txtSaldoActual"
        Me.txtSaldoActual.ReadOnly = True
        Me.txtSaldoActual.Size = New System.Drawing.Size(469, 20)
        Me.txtSaldoActual.TabIndex = 102
        Me.txtSaldoActual.Visible = False
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoInicial.Location = New System.Drawing.Point(147, 184)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(238, 21)
        Me.txtSaldoInicial.TabIndex = 6
        '
        'cbCuentaDe
        '
        Me.cbCuentaDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentaDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentaDe.Items.AddRange(New Object() {"Balance", "Resultado", "Presupuesto", "Orden"})
        Me.cbCuentaDe.Location = New System.Drawing.Point(147, 109)
        Me.cbCuentaDe.Name = "cbCuentaDe"
        Me.cbCuentaDe.Size = New System.Drawing.Size(238, 23)
        Me.cbCuentaDe.TabIndex = 3
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Location = New System.Drawing.Point(147, 84)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(238, 23)
        Me.cbTipo.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(147, 36)
        Me.txtCodigo.MaxLength = 16
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(238, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(12, 12)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(810, 20)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkProyecto)
        Me.LayoutControl1.Controls.Add(Me.chkActiva)
        Me.LayoutControl1.Controls.Add(Me.chkMnto)
        Me.LayoutControl1.Controls.Add(Me.chkRendicion)
        Me.LayoutControl1.Controls.Add(Me.chkRebajas)
        Me.LayoutControl1.Controls.Add(Me.chkDevolucion)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.chkRetencion)
        Me.LayoutControl1.Controls.Add(Me.chkchica)
        Me.LayoutControl1.Controls.Add(Me.etDescripcion)
        Me.LayoutControl1.Controls.Add(Me.chkDeOrden)
        Me.LayoutControl1.Controls.Add(Me.ChkUA)
        Me.LayoutControl1.Controls.Add(Me.cbGpo_Presupuesto)
        Me.LayoutControl1.Controls.Add(Me.ChkUP)
        Me.LayoutControl1.Controls.Add(Me.lbCuenta)
        Me.LayoutControl1.Controls.Add(Me.lbGruposSup)
        Me.LayoutControl1.Controls.Add(Me.chkDistribucion)
        Me.LayoutControl1.Controls.Add(Me.chkProveedor)
        Me.LayoutControl1.Controls.Add(Me.chkInventario)
        Me.LayoutControl1.Controls.Add(Me.chkCajaChica)
        Me.LayoutControl1.Controls.Add(Me.txtCodigo)
        Me.LayoutControl1.Controls.Add(Me.txtSaldoDolar1)
        Me.LayoutControl1.Controls.Add(Me.txtSaldoIniDolar)
        Me.LayoutControl1.Controls.Add(Me.cbClase)
        Me.LayoutControl1.Controls.Add(Me.cbAgrupaciones)
        Me.LayoutControl1.Controls.Add(Me.cbTipo)
        Me.LayoutControl1.Controls.Add(Me.txtPresupuestoAnual)
        Me.LayoutControl1.Controls.Add(Me.cbCuentaDe)
        Me.LayoutControl1.Controls.Add(Me.cbGrupos)
        Me.LayoutControl1.Controls.Add(Me.txtSaldoInicial)
        Me.LayoutControl1.Controls.Add(Me.txtSaldoActual)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1132, 283, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(834, 461)
        Me.LayoutControl1.TabIndex = 126
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkActiva
        '
        Me.chkActiva.Location = New System.Drawing.Point(631, 378)
        Me.chkActiva.Name = "chkActiva"
        Me.chkActiva.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActiva.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkActiva.Properties.Appearance.Options.UseFont = True
        Me.chkActiva.Properties.Appearance.Options.UseForeColor = True
        Me.chkActiva.Properties.Caption = "Cuenta Activa"
        Me.chkActiva.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkActiva.Size = New System.Drawing.Size(191, 22)
        Me.chkActiva.StyleController = Me.LayoutControl1
        Me.chkActiva.TabIndex = 132
        '
        'chkMnto
        '
        Me.chkMnto.Enabled = False
        Me.chkMnto.Location = New System.Drawing.Point(631, 300)
        Me.chkMnto.Name = "chkMnto"
        Me.chkMnto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMnto.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkMnto.Properties.Appearance.Options.UseFont = True
        Me.chkMnto.Properties.Appearance.Options.UseForeColor = True
        Me.chkMnto.Properties.Caption = "Mantenimiento de Valor"
        Me.chkMnto.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkMnto.Size = New System.Drawing.Size(191, 22)
        Me.chkMnto.StyleController = Me.LayoutControl1
        Me.chkMnto.TabIndex = 132
        '
        'chkRendicion
        '
        Me.chkRendicion.Enabled = False
        Me.chkRendicion.Location = New System.Drawing.Point(631, 326)
        Me.chkRendicion.Name = "chkRendicion"
        Me.chkRendicion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRendicion.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkRendicion.Properties.Appearance.Options.UseFont = True
        Me.chkRendicion.Properties.Appearance.Options.UseForeColor = True
        Me.chkRendicion.Properties.Caption = "Rendición de Cuenta"
        Me.chkRendicion.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkRendicion.Size = New System.Drawing.Size(191, 22)
        Me.chkRendicion.StyleController = Me.LayoutControl1
        Me.chkRendicion.TabIndex = 131
        '
        'chkRebajas
        '
        Me.chkRebajas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRebajas.Enabled = False
        Me.chkRebajas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRebajas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkRebajas.Location = New System.Drawing.Point(631, 276)
        Me.chkRebajas.Name = "chkRebajas"
        Me.chkRebajas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkRebajas.Size = New System.Drawing.Size(191, 20)
        Me.chkRebajas.TabIndex = 130
        Me.chkRebajas.Text = "Rebajas"
        Me.chkRebajas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkDevolucion
        '
        Me.chkDevolucion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDevolucion.Enabled = False
        Me.chkDevolucion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDevolucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkDevolucion.Location = New System.Drawing.Point(631, 252)
        Me.chkDevolucion.Name = "chkDevolucion"
        Me.chkDevolucion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkDevolucion.Size = New System.Drawing.Size(191, 20)
        Me.chkDevolucion.TabIndex = 129
        Me.chkDevolucion.Text = "Devolución"
        Me.chkDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(147, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(469, 20)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 129
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.lyGrupoSuperior, Me.EmptySpaceItem1, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem10, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.LayoutControlItem8, Me.EmptySpaceItem5, Me.LayoutControlItem11, Me.LayoutControlItem9, Me.LayoutControlItem6, Me.EmptySpaceItem6, Me.LayoutControlItem7, Me.EmptySpaceItem7, Me.LayoutControlItem16, Me.LayoutControlItem2, Me.LayoutControlItem29, Me.LayoutControlItem31, Me.LayoutControlItem30, Me.LayoutControlItem32, Me.LayoutControlItem33})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(834, 461)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtCodigo
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(377, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(377, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(377, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Cuenta:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(132, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbTipo
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(377, 25)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(377, 25)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(377, 25)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Nivel:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(132, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cbCuentaDe
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 97)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(377, 25)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(377, 25)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(377, 25)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Cuenta de:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(132, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbGrupos
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 147)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(608, 25)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(608, 25)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(608, 25)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Grupo:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(132, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtPresupuestoAnual
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 246)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(434, 24)
        Me.LayoutControlItem12.Text = "Presupuesto Anual:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(132, 13)
        Me.LayoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtSaldoDolar1
        Me.LayoutControlItem13.Location = New System.Drawing.Point(434, 246)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(24, 24)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        Me.LayoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtSaldoIniDolar
        Me.LayoutControlItem14.Location = New System.Drawing.Point(458, 246)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(150, 24)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        Me.LayoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.lbCuenta
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 270)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(24, 24)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(608, 24)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        Me.LayoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lyGrupoSuperior
        '
        Me.lyGrupoSuperior.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lyGrupoSuperior.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon
        Me.lyGrupoSuperior.AppearanceItemCaption.Options.UseFont = True
        Me.lyGrupoSuperior.AppearanceItemCaption.Options.UseForeColor = True
        Me.lyGrupoSuperior.Control = Me.lbGruposSup
        Me.lyGrupoSuperior.Location = New System.Drawing.Point(0, 294)
        Me.lyGrupoSuperior.Name = "lyGrupoSuperior"
        Me.lyGrupoSuperior.Size = New System.Drawing.Size(608, 147)
        Me.lyGrupoSuperior.Text = "Cuentas Superiores:"
        Me.lyGrupoSuperior.TextLocation = DevExpress.Utils.Locations.Top
        Me.lyGrupoSuperior.TextSize = New System.Drawing.Size(132, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(619, 392)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(195, 49)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.chkProveedor
        Me.LayoutControlItem17.Location = New System.Drawing.Point(619, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.chkCajaChica
        Me.LayoutControlItem18.Location = New System.Drawing.Point(619, 48)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.chkInventario
        Me.LayoutControlItem19.Location = New System.Drawing.Point(619, 72)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.chkDistribucion
        Me.LayoutControlItem20.Location = New System.Drawing.Point(619, 96)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.ChkUP
        Me.LayoutControlItem21.Location = New System.Drawing.Point(619, 120)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.ChkUA
        Me.LayoutControlItem22.Location = New System.Drawing.Point(619, 144)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.chkDeOrden
        Me.LayoutControlItem23.Location = New System.Drawing.Point(619, 168)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        Me.LayoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.chkchica
        Me.LayoutControlItem24.Location = New System.Drawing.Point(619, 192)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.chkRetencion
        Me.LayoutControlItem25.Location = New System.Drawing.Point(619, 216)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.etDescripcion
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(24, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(814, 24)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(377, 72)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(231, 25)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(377, 97)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(231, 25)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cbClase
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(377, 25)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(377, 25)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(377, 25)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Tipo:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(132, 13)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(377, 122)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(231, 25)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cbGpo_Presupuesto
        Me.LayoutControlItem11.Location = New System.Drawing.Point(377, 172)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(231, 25)
        Me.LayoutControlItem11.Text = "Presupuesto Anual:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(132, 13)
        Me.LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtSaldoActual
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 222)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(608, 24)
        Me.LayoutControlItem9.Text = "Saldo Act. C$:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(132, 13)
        Me.LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbAgrupaciones
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 197)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(608, 25)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(608, 25)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(608, 25)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Agrupación:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(132, 13)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(377, 24)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(231, 24)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtSaldoInicial
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 172)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(377, 25)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(377, 25)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(377, 25)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Saldo Inicial:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(132, 13)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(608, 24)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(11, 417)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtNombre
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(608, 24)
        Me.LayoutControlItem16.Text = "Nombre:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(132, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.chkDevolucion
        Me.LayoutControlItem2.Location = New System.Drawing.Point(619, 240)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.chkRebajas
        Me.LayoutControlItem29.Location = New System.Drawing.Point(619, 264)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextVisible = False
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.chkMnto
        Me.LayoutControlItem31.Location = New System.Drawing.Point(619, 288)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(195, 26)
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem31.TextVisible = False
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.chkRendicion
        Me.LayoutControlItem30.Location = New System.Drawing.Point(619, 314)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(195, 26)
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem30.TextVisible = False
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.chkActiva
        Me.LayoutControlItem32.Location = New System.Drawing.Point(619, 366)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(195, 26)
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem32.TextVisible = False
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
        Me.DockPanel1.ID = New System.Guid("4470f5c2-bfec-46b2-8bbc-3270a3117fcb")
        Me.DockPanel1.Location = New System.Drawing.Point(834, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 461)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 434)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'chkProyecto
        '
        Me.chkProyecto.Enabled = False
        Me.chkProyecto.Location = New System.Drawing.Point(631, 352)
        Me.chkProyecto.Name = "chkProyecto"
        Me.chkProyecto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProyecto.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkProyecto.Properties.Appearance.Options.UseFont = True
        Me.chkProyecto.Properties.Appearance.Options.UseForeColor = True
        Me.chkProyecto.Properties.Caption = "Proyecto"
        Me.chkProyecto.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkProyecto.Size = New System.Drawing.Size(191, 22)
        Me.chkProyecto.StyleController = Me.LayoutControl1
        Me.chkProyecto.TabIndex = 132
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.chkProyecto
        Me.LayoutControlItem33.Location = New System.Drawing.Point(619, 340)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(195, 26)
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem33.TextVisible = False
        '
        'frmNuevaCuenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(974, 461)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmNuevaCuenta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkActiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMnto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRendicion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyGrupoSuperior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.chkProyecto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmNuevaCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As New VB.SysContab.Rutinas()
        Dim Catalogo As New VB.SysContab.CatalogoDB()
        Dim Agrupacion As New VB.SysContab.AgrupacionesDB()
        Dim Grupo As New VB.SysContab.GruposDB()

        cbAgrupaciones.DataSource = Agrupacion.GetListBuscarCombo("%").Tables("AGRUPACIONES")
        cbAgrupaciones.ValueMember = "CODIGO_AGRUPACION"
        cbAgrupaciones.DisplayMember = "NOMBRE"

        Me.cbGpo_Presupuesto.DataSource = Grupo.GetList_Presupuesto().Tables("GRUPOS")
        Me.cbGpo_Presupuesto.ValueMember = "CODIGO_GRUPO"
        Me.cbGpo_Presupuesto.DisplayMember = "Nombre"

        CB = ""

        Detalles =
            Empresa.GetDetails(EmpresaActual)

        If Detalles.Mayor <> 0 Then
            txtCodigo.MaxLength = Detalles.Mayor
        End If

        If Detalles.SC01 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC01 ' + 1
        End If

        If Detalles.SC02 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC02 ' + 2
        End If

        If Detalles.SC03 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC03 ' + 3
        End If

        If Detalles.SC04 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC04 ' + 4
        End If

        If Detalles.SC05 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC05 ' + 5
        End If

        If Detalles.SC06 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC06 ' + 6
        End If

        If Detalles.SC07 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC07 ' + 7
        End If

        If Detalles.SC08 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC08 ' + 8
        End If

        If Detalles.SC09 <> 0 Then
            txtCodigo.MaxLength = Detalles.SC09 ' + 9
        End If

        chkActiva.Checked = True
        chkActiva.Enabled = False

        If Nuevo = "NO" Then

            Me.etDescripcion.Text = "Editar Cuenta".ToUpper
            Me.Text = "Editar Cuenta"

            Dim Detalles As VB.SysContab.CatalogoDetails = Catalogo.GetDetails(Registro)
            Me.cbAgrupaciones.SelectedValue = Detalles.Agrupacion

            Me.chkProveedor.Checked = Detalles.Proveedor
            Me.chkCajaChica.Checked = Detalles.CajaBanco
            Me.chkInventario.Checked = Detalles.Inventario
            Me.chkDistribucion.Checked = Detalles.Distribucion
            Me.chkDeOrden.Checked = Detalles.DeOrden
            Me.ChkUP.Checked = Detalles.UtilidadPerdida
            Me.ChkUA.Checked = Detalles.UtilidadAcumulada
            Me.chkchica.Checked = Detalles.CChica
            Me.chkRetencion.Checked = Detalles.Retencion
            chkDevolucion.Checked = Detalles.Devolucion
            chkRebajas.Checked = Detalles.Rebajas
            chkMnto.Checked = Detalles.MntoValor
            chkRendicion.Checked = Detalles.Rendicion
            chkActiva.Checked = Detalles.Activo
            chkProyecto.Checked = Detalles.EsProyecto

            Me.txtCodigo.ReadOnly = True
            'Nombre = Detalles.Nombre
            Me.txtNombre.Text = Detalles.Nombre
            Me.txtCodigo.Text = Detalles.Cuenta
            Me.txtSaldoInicial.Text = CDbl(Detalles.Saldo_Inicial).ToString(Round)
            Me.txtPresupuestoAnual.Text = CDbl(Detalles.Presupuesto_Anual).ToString(Round)
            Me.cbGpo_Presupuesto.SelectedValue = Detalles.Gpo_Presupuesto.ToString

            If Detalles.Cuenta_De = "B" Then
                Me.cbCuentaDe.SelectedIndex = 0
            ElseIf Detalles.Cuenta_De = "R" Then
                Me.cbCuentaDe.SelectedIndex = 1
            ElseIf Detalles.Cuenta_De = "P" Then
                Me.cbCuentaDe.SelectedIndex = 2
            ElseIf Detalles.Cuenta_De = "O" Then
                Me.cbCuentaDe.SelectedIndex = 3
            End If

            Me.cbGrupos.SelectedValue = Detalles.Grupo

            If Detalles.SubCuenta.ToString.ToUpper = "XXXX" Then
                cbTipo.Items.Clear()
                cbTipo.Items.Add("Mayor")
                cbTipo.SelectedIndex = 0
                'Me.txtSaldoInicial.ReadOnly = True
                Me.txtPresupuestoAnual.ReadOnly = True


            ElseIf Catalogo.GetListSubCuenta(Detalles.Cuenta, EmpresaActual).Tables("Catalogo").Rows.Count <> 0 Then
                cbTipo.Items.Clear()
                cbTipo.Items.Add("SubCuenta")
                cbTipo.SelectedIndex = 0
                'Me.txtSaldoInicial.ReadOnly = True
                Me.txtPresupuestoAnual.ReadOnly = True

            Else

                cbTipo.Items.Clear()
                cbTipo.Items.Add("SubCuenta")
                cbTipo.Items.Add("Auxiliar")

                If Detalles.Tipo = "S" Then
                    Me.cbTipo.SelectedIndex = 0
                    Me.txtSaldoActual.ReadOnly = True
                ElseIf Detalles.Tipo = "A" Then
                    Me.cbTipo.SelectedIndex = 1

                End If
            End If

            cbClase.SelectedIndex = Detalles.Clase


            Dim Catal As New VB.SysContab.CatalogoDB
            Dim longitud As Integer
            Dim CuentaTitulo, Cuenta, Tipo As String
            Dim i As Integer

            longitud = Registro.Length

            If longitud = 1 Then
                Exit Sub
            Else
                lbGruposSup.Items.Clear()
                lbCuenta.Items.Clear()
                For i = 0 To longitud - 2
                    'If Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("Catalogo").Rows.Count <> 0 Then
                    '    lbGruposSup.Items.Add(Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("Catalogo").Rows(0).Item("Cuenta") & " - " & Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Catalogo").Rows(0).Item("Nombre"))
                    'End If
                    Cuenta = ""
                    CuentaTitulo = ""
                    Tipo = Catal.GetListCodigo(Detalles.Cuenta, EmpresaActual).Tables("CATALOGO").Rows(0).Item("Tipo")

                    If Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows.Count <> 0 And txtCodigo.Text.Substring(i, 1) <> " " Then

                        Cuenta = Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("Cuenta")

                        Select Case Tipo

                            Case "A"
                                If Catal.GetListCodigo(Cuenta, EmpresaActual).Tables("Catalogo").Rows(0).Item("Tipo") <> "A" Then
                                    CuentaTitulo = Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA") & " - " & Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("Nombre")
                                    lbGruposSup.Items.Add(CuentaTitulo)
                                    lbCuenta.Items.Add(Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA"))
                                End If

                            Case "S"
                                If Catal.GetListCodigo(Cuenta, EmpresaActual).Tables("Catalogo").Rows(0).Item("Tipo") = "M" Or Catal.GetListCodigo(Cuenta, EmpresaActual).Tables("Catalogo").Rows(0).Item("Tipo") = "S" Then
                                    CuentaTitulo = Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA") & " - " & Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("Nombre")
                                    lbGruposSup.Items.Add(CuentaTitulo)
                                    lbCuenta.Items.Add(Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA"))
                                End If

                            Case "M"
                                If Catal.GetListCodigo(Cuenta, EmpresaActual).Tables("Catalogo").Rows(0).Item("Tipo") = "M" Then
                                    CuentaTitulo = Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA") & " - " & Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("Nombre")
                                    lbGruposSup.Items.Add(CuentaTitulo)
                                    lbCuenta.Items.Add(Catal.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA"))
                                End If

                        End Select

                    End If

                Next

                If lbGruposSup.Items.Count <> 0 Then
                    lyGrupoSuperior.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    'etGruposSup.Visible = True
                    'lbGruposSup.Visible = True
                End If

            End If

            If Detalles.Tipo = "A" Then
                Me.chkRetencion.Enabled = True
                chkDevolucion.Enabled = True
                chkRebajas.Enabled = True
                chkMnto.Enabled = True
                chkRendicion.Enabled = True
                chkActiva.Enabled = True
                chkProyecto.Enabled = True
            End If
        Else
            Me.Text = "Agregar cuenta contable"
            Me.etDescripcion.Text = "Agregar cuenta contable".ToUpper

            Me.txtSaldoInicial.Text = "0.00"
            Me.txtPresupuestoAnual.Text = "0.00"

            Me.cbClase.SelectedIndex = 0
        End If
        ''r.CambiarEstilo(Me)
        Me.Refresh()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCodigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Leave
        Dim c As New VB.SysContab.CatalogoDB()
        Dim longitud As Integer
        Dim i As Integer

        If Nuevo = "NO" Then
            If Clipboard.GetDataObject.GetDataPresent(System.Windows.Forms.DataFormats.Text) = True Then
                Clipboard.SetDataObject(CB)
            End If
            Exit Sub
        End If

        If Trim(txtCodigo.Text) <> "" Then
            If Detalles.Espacio = True Then
                If txtCodigo.TextLength < Detalles.Mayor Then
                    MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                    txtCodigo.Focus()
                    Exit Sub

                End If

                If Detalles.SC01 <> 0 Then
                    If txtCodigo.TextLength > Detalles.Mayor And txtCodigo.TextLength < Detalles.SC01 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC02 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC01 + 1 And txtCodigo.TextLength < Detalles.SC02 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC03 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC02 + 2 And txtCodigo.TextLength < Detalles.SC03 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC04 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC03 + 3 And txtCodigo.TextLength < Detalles.SC04 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC05 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC04 + 4 And txtCodigo.TextLength < Detalles.SC05 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC06 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC05 + 5 And txtCodigo.TextLength < Detalles.SC06 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC07 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC06 + 6 And txtCodigo.TextLength < Detalles.SC07 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC08 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC07 + 7 And txtCodigo.TextLength < Detalles.SC08 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC09 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC08 + 8 And txtCodigo.TextLength < Detalles.SC09 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If
            Else
                '''''''Aqui
                If Detalles.SC01 + 1 <> 0 Then
                    If txtCodigo.TextLength > Detalles.Mayor And txtCodigo.TextLength < Detalles.SC01 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC02 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC01 And txtCodigo.TextLength < Detalles.SC02 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC03 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC02 And txtCodigo.TextLength < Detalles.SC03 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC04 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC03 And txtCodigo.TextLength < Detalles.SC04 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC05 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC04 And txtCodigo.TextLength < Detalles.SC05 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC06 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC05 And txtCodigo.TextLength < Detalles.SC06 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC07 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC06 And txtCodigo.TextLength < Detalles.SC07 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC08 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC07 And txtCodigo.TextLength < Detalles.SC08 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If

                If Detalles.SC09 <> 0 Then
                    If txtCodigo.TextLength > Detalles.SC08 And txtCodigo.TextLength < Detalles.SC09 Then
                        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
                        txtCodigo.Focus()
                        Exit Sub

                    End If
                End If
                '''''''Aqui
            End If

            'If Detalles.SC01 + 1 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.Mayor And txtCodigo.TextLength < Detalles.SC01 + 1 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC02 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC01 + 1 And txtCodigo.TextLength < Detalles.SC02 + 2 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC03 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC02 + 2 And txtCodigo.TextLength < Detalles.SC03 + 3 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC04 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC03 + 3 And txtCodigo.TextLength < Detalles.SC04 + 4 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC05 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC04 + 4 And txtCodigo.TextLength < Detalles.SC05 + 5 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC06 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC05 + 5 And txtCodigo.TextLength < Detalles.SC06 + 6 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC07 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC06 + 6 And txtCodigo.TextLength < Detalles.SC07 + 7 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC08 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC07 + 7 And txtCodigo.TextLength < Detalles.SC08 + 8 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If

            'If Detalles.SC09 <> 0 Then
            '    If txtCodigo.TextLength > Detalles.SC08 + 8 And txtCodigo.TextLength < Detalles.SC09 + 9 Then
            '        MsgBox("Numero de Cuenta incorrecto - " & txtCodigo.Text, MsgBoxStyle.Information)
            '        txtCodigo.Focus()
            '        Exit Sub

            '    End If
            'End If




            longitud = txtCodigo.Text.Length
            c.GetListCodigo(txtCodigo.Text, EmpresaActual)

            If longitud = 1 Then
                If c.GetListCodigo(txtCodigo.Text, EmpresaActual).Tables("CATALOGO").Rows.Count <> 0 Then
                    MsgBox("Cuenta ya existe", MsgBoxStyle.Information)
                    txtCodigo.Focus()
                    Exit Sub

                End If
            Else
                If c.GetListCodigo(txtCodigo.Text, EmpresaActual).Tables("CATALOGO").Rows.Count <> 0 Then
                    MsgBox("Cuenta ya existe", MsgBoxStyle.Information)
                    txtCodigo.Focus()
                    Exit Sub

                End If

                lbGruposSup.Items.Clear()
                lbCuenta.Items.Clear()
                For i = 0 To longitud - 2

                    If c.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows.Count <> 0 And txtCodigo.Text.Substring(i, 1) <> " " Then
                        lbGruposSup.Items.Add(c.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA") & " - " & c.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("Nombre"))
                        lbCuenta.Items.Add(c.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA"))

                        If c.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("TIPO").ToString.ToUpper = "A" Then
                            MsgBox("La sub cuenta es Auxiliar", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If


                    End If

                Next

                If Detalles.SC01 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC01 Then
                        If lbGruposSup.Items.Count < 1 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If
                    End If
                End If

                If Detalles.SC02 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC02 Then
                        If lbGruposSup.Items.Count < 2 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                If Detalles.SC03 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC03 Then
                        If lbGruposSup.Items.Count < 3 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If


                If Detalles.SC04 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC04 Then
                        If lbGruposSup.Items.Count < 4 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                If Detalles.SC05 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC05 Then
                        If lbGruposSup.Items.Count < 5 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                If Detalles.SC06 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC06 Then
                        If lbGruposSup.Items.Count < 6 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                If Detalles.SC07 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC07 Then
                        If lbGruposSup.Items.Count < 7 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                If Detalles.SC08 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC08 Then
                        If lbGruposSup.Items.Count < 8 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                If Detalles.SC09 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC09 Then
                        If lbGruposSup.Items.Count < 9 Then
                            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                            txtCodigo.Focus()
                            Exit Sub

                        End If

                    End If
                End If

                'If Detalles.SC01 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC01 + 1 Then
                '        If lbGruposSup.Items.Count < 1 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If
                '    End If
                'End If

                'If Detalles.SC02 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC02 + 2 Then
                '        If lbGruposSup.Items.Count < 2 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                'If Detalles.SC03 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC03 + 3 Then
                '        If lbGruposSup.Items.Count < 3 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If


                'If Detalles.SC04 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC04 + 4 Then
                '        If lbGruposSup.Items.Count < 4 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                'If Detalles.SC05 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC05 + 5 Then
                '        If lbGruposSup.Items.Count < 5 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                'If Detalles.SC06 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC06 + 6 Then
                '        If lbGruposSup.Items.Count < 6 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                'If Detalles.SC07 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC07 + 7 Then
                '        If lbGruposSup.Items.Count < 7 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                'If Detalles.SC08 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC08 + 8 Then
                '        If lbGruposSup.Items.Count < 8 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                'If Detalles.SC09 <> 0 Then
                '    If txtCodigo.TextLength = Detalles.SC09 + 9 Then
                '        If lbGruposSup.Items.Count < 9 Then
                '            MsgBox("No hay cuenta superior", MsgBoxStyle.Information)
                '            txtCodigo.Focus()
                '            Exit Sub

                '        End If

                '    End If
                'End If

                If lbGruposSup.Items.Count <> 0 Then
                    'MsgBox(lbGruposSup.Items.Item(lbGruposSup.Items.Count - 1))
                    lyGrupoSuperior.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    'etGruposSup.Visible = True
                    'lbGruposSup.Visible = True

                    cbTipo.Items.Clear()
                    cbTipo.Items.Add("SubCuenta")
                    cbTipo.Items.Add("Auxiliar")

                    cbClase.SelectedIndex = c.GetListCodigo(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("CATALOGO").Rows(0).Item("Clase")
                    cbClase.Enabled = False

                Else
                    cbTipo.Items.Clear()
                    cbTipo.Items.Add("Mayor")

                    cbClase.SelectedIndex = 0
                    cbClase.Enabled = True

                End If

            End If

        End If

        If Clipboard.GetDataObject.GetDataPresent(System.Windows.Forms.DataFormats.Text) = True Then
            Clipboard.SetDataObject(CB)

        End If

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        lbGruposSup.Items.Clear()
        lbCuenta.Items.Clear()

        lyGrupoSuperior.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

        'lbGruposSup.Visible = False
        'etGruposSup.Visible = False

        cbClase.SelectedIndex = 0
        cbClase.Enabled = True

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress

        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
                Exit Sub

            End If

            If txtCodigo.TextLength = txtCodigo.MaxLength Then
                e.Handled = True
                Exit Sub

            End If

            If Detalles.Espacio = True Then
                If Detalles.Mayor <> 0 Then
                    If txtCodigo.TextLength = Detalles.Mayor Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC01 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC01 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC02 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC02 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC03 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC03 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC04 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC04 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC05 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC05 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC06 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC06 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC07 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC07 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC08 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC08 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

                If Detalles.SC09 <> 0 Then
                    If txtCodigo.TextLength = Detalles.SC09 Then
                        txtCodigo.Text = txtCodigo.Text & " "
                        txtCodigo.SelectionStart = txtCodigo.TextLength
                        Exit Sub

                    End If

                End If

            End If


        End If

        '    If Detalles.SC01 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC01 + 1 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC02 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC02 + 2 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC03 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC03 + 3 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC04 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC04 + 4 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC05 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC05 + 5 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC06 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC06 + 6 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC07 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC07 + 7 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC08 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC08 + 8 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If

        '    If Detalles.SC09 <> 0 Then
        '        If txtCodigo.TextLength = Detalles.SC09 + 9 Then
        '            txtCodigo.Text = txtCodigo.Text & " "
        '            txtCodigo.SelectionStart = txtCodigo.TextLength
        '            Exit Sub

        '        End If

        '    End If
        'End If

    End Sub

    Private Sub cbCuentaDe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCuentaDe.SelectedIndexChanged
        Dim grupos As New VB.SysContab.GruposDB()

        cbGrupos.Text = ""

        If cbCuentaDe.Text = "Balance" Then
            cbGrupos.DataSource = grupos.GetListBuscarCombo("%", "B").Tables("GRUPOS")
            cbGrupos.ValueMember = "CODIGO_GRUPO"
            cbGrupos.DisplayMember = "Nombre"
            TG = "B"
        ElseIf cbCuentaDe.Text = "Resultado" Then
            cbGrupos.DataSource = grupos.GetListBuscarCombo("%", "R").Tables("GRUPOS")
            cbGrupos.ValueMember = "CODIGO_GRUPO"
            cbGrupos.DisplayMember = "Nombre"
            TG = "R"
        ElseIf cbCuentaDe.Text.ToUpper = "ORDEN" Then
            cbGrupos.DataSource = grupos.GetListBuscarCombo("%", "O").Tables("GRUPOS")
            cbGrupos.ValueMember = "CODIGO_GRUPO"
            cbGrupos.DisplayMember = "Nombre"
            TG = "O"
        Else
            cbGrupos.DataSource = grupos.GetListBuscarCombo("%", "P").Tables("GRUPOS")
            cbGrupos.ValueMember = "CODIGO_GRUPO"
            cbGrupos.DisplayMember = "Nombre"
            TG = "P"

        End If

    End Sub

    Private Sub cbGrupos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbGrupos.KeyPress
        Dim g As New VB.SysContab.GruposDB()

        If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
            If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
                grupos = ""
                cbGrupos.SelectAll()
                Exit Sub

            End If

            If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
                Exit Sub

            End If
        End If

        If cbGrupos.Text = "" Then
            grupos = ""
            Exit Sub
        End If

        If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
            If grupos.Length = 1 Then
                grupos = ""
            End If

            If grupos.Length > 1 Then
                grupos = Mid(grupos, 1, grupos.Length - 1)
            End If

            If cbGrupos.Text = "" Then
                grupos = ""
                Exit Sub

            End If

        Else
            grupos = grupos & e.KeyChar

        End If

        If g.GetListBuscarCombo(grupos, TG).Tables("GRUPOS").Rows.Count = 0 Then
            '
        Else
            cbGrupos.SelectedValue = g.GetListBuscarCombo(grupos, TG).Tables("GRUPOS").Rows(0).Item("CODIGO_GRUPO")
            cbGrupos.SelectionStart = grupos.Length
            cbGrupos.Select(grupos.Length, cbGrupos.Text.Length)

        End If

    End Sub

    Private Sub cbGrupos_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrupos.Leave
        'Dim g As New VB.SysContab.GruposDB()

        If Trim(cbGrupos.Text) = "" Then
            grupos = ""
            Exit Sub
        End If

        'If g.GetListBuscarCombo(cbGrupos.Text, TG).Tables("Grupos").Rows.Count = 0 Then
        '    MsgBox("Grupo no Existe", MsgBoxStyle.Information)
        '    grupos = ""
        '    cbGrupos.Focus()
        '    Exit Sub

        'End If

        'cbGrupos.SelectedValue = g.GetListBuscarCombo(cbGrupos.Text, TG).Tables("GRUPOS").Rows(0).Item("CODIGO_GRUPO")
        Cod_Grupo = Me.cbGrupos.SelectedValue 'g.GetListBuscarCombo(cbGrupos.Text, TG).Tables("GRUPOS").Rows(0).Item("CODIGO_GRUPO")

        grupos = ""

    End Sub

    Private Sub cbGrupos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrupos.SelectedValueChanged
        grupos = ""

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim catalogo As New VB.SysContab.CatalogoDB()
        Dim grp As New VB.SysContab.GruposDB()
        Dim r As New VB.SysContab.Rutinas()
        Dim Tipo As String
        Dim CuentaD As String

        Dim i As Integer
        Dim j As Integer

        Dim saldo As Double


        If Trim(txtCodigo.Text) = "" Then
            XtraMsg("Introduzca el número de la Cuenta")
            txtCodigo.Focus()
            txtCodigo.SelectAll()
            Exit Sub
        End If

        If Trim(txtNombre.Text) = "" Then
            XtraMsg("Introduzca el Nombre de la Cuenta")
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub
        End If

        If cbTipo.Text = "" Then
            XtraMsg("Seleccione el Nivel de la Cuenta")
            cbTipo.Focus()
            Exit Sub
        End If

        If Trim(cbCuentaDe.Text) = "" Then
            XtraMsg("Seleccione C....")
            cbCuentaDe.Focus()
            Exit Sub
        End If

        If Trim(cbGrupos.Text) = "" Then
            XtraMsg("Seleccione el Grupo de la Cuenta")
            cbGrupos.Focus()
            Exit Sub

        End If

        If Trim(txtSaldoInicial.Text) = "" Then
            XtraMsg("Introduzca el Saldo Inicial")
            txtSaldoInicial.Focus()
            txtSaldoInicial.SelectAll()
            Exit Sub

        End If

        If Trim(txtPresupuestoAnual.Text) = "" Then
            XtraMsg("Introduzca el Presupuesto Anual Inicial")
            txtPresupuestoAnual.Focus()
            txtPresupuestoAnual.SelectAll()
            Exit Sub

        End If

        If cbClase.SelectedIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Cuenta")
            cbClase.Focus()
            Exit Sub

        End If

        If cbTipo.Text = "Mayor" Then
            Tipo = "M"
        ElseIf cbTipo.Text = "SubCuenta" Then
            Tipo = "S"
        Else
            Tipo = "A"
        End If

        If cbCuentaDe.Text.ToUpper = "BALANCE" Then
            CuentaD = "B"
        ElseIf cbCuentaDe.Text.ToUpper = "RESULTADO" Then
            CuentaD = "R"
        ElseIf cbCuentaDe.Text.ToUpper = "ORDEN" Then
            CuentaD = "O"
        Else
            CuentaD = "P"
        End If

        Dim SaldoInicial As Double
        Dim PresupuestoAnual As Double
        Dim Debito As Double
        Dim Credito As Double

        SaldoInicial = txtSaldoInicial.Text
        PresupuestoAnual = txtPresupuestoAnual.Text

        If cbClase.SelectedIndex = 1 Then
            Debito = SaldoInicial
            Credito = 0
        Else
            Debito = 0
            Credito = SaldoInicial
        End If
        Dim Proveedor As Integer
        Dim Caja As Integer


        If Me.chkProveedor.Checked = True Then
            Proveedor = 1
        Else
            Proveedor = 0
        End If

        If Me.chkCajaChica.Checked = True Then
            Caja = 1
        Else
            Caja = 0
        End If



        If Nuevo = "SI" Then

            'Si se esta agregando una cuenta de Acumulados en el Capital
            If Me.ChkUA.Checked Or Me.ChkUP.Checked Then
                VB.SysContab.CatalogoDB.Update_UP_UA(IIf(Me.ChkUP.Checked = True, "UP", IIf(Me.ChkUA.Checked = True, "UA", "")))
            End If

            If lbCuenta.Items.Count = 0 Then
                catalogo.AddItem(
                    Trim(txtCodigo.Text),
                    txtNombre.Text,
                    Tipo,
                    CuentaD,
                    SaldoInicial,
                    PresupuestoAnual,
                    cbGrupos.SelectedValue,
                    EmpresaActual,
                    "XXXX",
                    cbClase.SelectedIndex,
                    Debito,
                    Credito,
                    cbGpo_Presupuesto.SelectedValue,
                    Proveedor,
                    Caja,
                    cbAgrupaciones.SelectedValue,
                    IIf(Me.chkInventario.Checked, 1, 0),
                    IIf(Me.chkDistribucion.Checked, 1, 0),
                    IIf(Me.chkDeOrden.Checked, 1, 0),
                    IIf(Me.ChkUP.Checked, 1, 0),
                    IIf(Me.ChkUA.Checked, 1, 0),
                    chkchica.Checked,
                    chkRetencion.Checked,
                    chkDevolucion.Checked,
                    chkRebajas.Checked,
                    chkMnto.Checked,
                    chkRendicion.Checked,
                    chkActiva.Checked,
                    chkProyecto.Checked)
            Else
                catalogo.AddItem(
                    Trim(txtCodigo.Text),
                    txtNombre.Text,
                    Tipo,
                    CuentaD,
                    SaldoInicial,
                    PresupuestoAnual,
                    cbGrupos.SelectedValue,
                    EmpresaActual,
                    lbCuenta.Items.Item(lbCuenta.Items.Count - 1),
                    cbClase.SelectedIndex,
                    Debito,
                    Credito,
                    cbGpo_Presupuesto.SelectedValue,
                    Proveedor,
                    Caja,
                    cbAgrupaciones.SelectedValue,
                    IIf(Me.chkInventario.Checked, 1, 0),
                    IIf(Me.chkDistribucion.Checked, 1, 0),
                    IIf(Me.chkDeOrden.Checked, 1, 0),
                    IIf(Me.ChkUP.Checked, 1, 0),
                    IIf(Me.ChkUA.Checked, 1, 0),
                    Me.chkchica.Checked,
                    Me.chkRetencion.Checked,
                    chkDevolucion.Checked,
                    chkRebajas.Checked,
                    chkMnto.Checked,
                    chkRendicion.Checked,
                    chkActiva.Checked,
                    chkProyecto.Checked)
            End If

            If CDbl(Me.txtSaldoInicial.Text) <> 0 Then
                DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
                DBConnFacturas.Open()
                transaccionFacturas = DBConnFacturas.BeginTransaction
                Try
                    catalogo.SaldoInicialAdd(Me.txtCodigo.Text, VB.SysContab.PeriodosDB.Actual, Me.txtSaldoInicial.Text)
                    catalogo.SaldoInicialActualizar(Me.txtCodigo.Text, VB.SysContab.PeriodosDB.Actual, Me.txtSaldoInicial.Text, 1)
                    VB.SysContab.Rutinas.okTransaccion()
                Catch ex As Exception
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    XtraMsg(ex.Message, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            Else
                'Borrar la cuenta de Catalogo Saldo
            End If

            'catalogo.AddItem(Trim(txtCodigo.Text), txtNombre.Text, Tipo, CuentaD, txtSaldoInicial.Text, txtPresupuestoAnual.Text, cbGrupos.SelectedValue, EmpresaActual, lbCuenta.Items.Item(lbCuenta.Items.Count - 1))

            'For i = 0 To lbCuenta.Items.Count - 1
            '    catalogo.UpdateSaldos(lbCuenta.Items.Item(i), catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SALDO_INICIAL"), txtSaldoInicial.Text, EmpresaActual)

            'Next

            If lbCuenta.Items.Count <> 0 Then
                saldo = 0
                For i = 0 To catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("Catalogo").Rows.Count - 1
                    saldo = saldo + catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("Catalogo").Rows(i).Item("SALDO_INICIAL")
                Next

                catalogo.UpdateSaldosEdit(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), saldo, cbClase.SelectedIndex)

                i = lbCuenta.Items.Count - 1
                While i >= 0
                    saldo = 0

                    For j = 0 To catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows.Count - 1
                        'MsgBox(catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows(j).Item("Cuenta"))
                        saldo = saldo + catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows(j).Item("SALDO_INICIAL")

                    Next
                    If i > 0 Then
                        catalogo.UpdateSaldosEdit(lbCuenta.Items(i - 1), saldo, cbClase.SelectedIndex)
                    End If

                    i = i - 1

                End While

            End If

            'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)

            'r.LimpiarControles(GroupBox1)

            LimpiarControles(LayoutControl1)

            Me.txtSaldoInicial.Text = "0.00"
            Me.txtPresupuestoAnual.Text = "0.00"

            cbTipo.SelectedIndex = -1
            cbCuentaDe.SelectedIndex = -1
            cbClase.SelectedIndex = 0
            cbAgrupaciones.SelectedValue = -1

            'cbGrupos.Items.Clear()

            'cbGrupos.DataSource = grp.GetListBuscarCombo("%", "Y").Tables("GRUPOS")
            'cbGrupos.ValueMember = "CODIGO_GRUPO"
            'cbGrupos.DisplayMember = "Nombre"

            txtCodigo.Focus()
        Else
            'Si se esta actualizando una cuenta de Acumulados en el Capital
            If Me.ChkUA.Checked Or Me.ChkUP.Checked Then
                VB.SysContab.CatalogoDB.Update_UP_UA(IIf(Me.ChkUP.Checked = True, "UP", IIf(Me.ChkUA.Checked = True, "UA", "")))
            End If

            catalogo.Update(
                Trim(txtCodigo.Text),
                txtNombre.Text,
                Tipo,
                CuentaD,
                SaldoInicial,
                PresupuestoAnual,
                cbGrupos.SelectedValue,
                EmpresaActual,
                cbClase.SelectedIndex,
                Me.cbGpo_Presupuesto.SelectedValue,
                Proveedor,
                Caja,
                Me.cbAgrupaciones.SelectedValue,
                IIf(Me.chkInventario.Checked, 1, 0),
                IIf(Me.chkDistribucion.Checked, 1, 0),
                IIf(Me.chkDeOrden.Checked, 1, 0),
                IIf(Me.ChkUP.Checked, 1, 0),
                IIf(Me.ChkUA.Checked, 1, 0),
                Me.chkchica.Checked,
                Me.chkRetencion.Checked,
                chkDevolucion.Checked,
                chkRebajas.Checked,
                chkMnto.Checked,
                chkRendicion.Checked,
                chkActiva.Checked,
                chkProyecto.Checked)

            ''If CDbl(Me.txtSaldoInicial.Text) <> 0 Then
            ''    DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            ''    DBConnFacturas.Open()
            ''    transaccionFacturas = DBConnFacturas.BeginTransaction
            ''    Try
            ''        catalogo.SaldoInicialAdd(Me.txtCodigo.Text, VB.SysContab.PeriodosDB.Activo, Me.txtSaldoInicial.Text)
            ''        catalogo.SaldoInicialActualizar(Me.txtCodigo.Text, VB.SysContab.PeriodosDB.Activo, Me.txtSaldoInicial.Text, 1)
            ''        VB.SysContab.Rutinas.okTransaccion()
            ''    Catch ex As Exception
            ''        VB.SysContab.Rutinas.ErrorTransaccion()
            ''        MsgBox(ex.Message)
            ''        Exit Sub
            ''    End Try
            ''Else
            ''    'Borrar la cuenta de Catalogo Saldo
            ''End If

            'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)

            'catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual)
            'lbCuenta.Items.Count - 1
            'For i = 0 To catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("Catalogo").Rows.Count - 1

            If lbCuenta.Items.Count <> 0 Then
                saldo = 0
                For i = 0 To catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("Catalogo").Rows.Count - 1
                    saldo = saldo + catalogo.GetListCodigoBorrar(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), EmpresaActual).Tables("Catalogo").Rows(i).Item("SALDO_INICIAL")

                Next

                catalogo.UpdateSaldosEdit(lbCuenta.Items.Item(lbCuenta.Items.Count - 1), saldo, cbClase.SelectedIndex)

                i = lbCuenta.Items.Count - 1
                While i >= 0
                    saldo = 0

                    Try
                        For j = 0 To catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows.Count - 1
                            'MsgBox(catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows(j).Item("Cuenta"))
                            saldo = saldo + catalogo.GetListSubCuenta(catalogo.GetListCodigo(lbCuenta.Items.Item(i), EmpresaActual).Tables("Catalogo").Rows(0).Item("SUBCUENTA"), EmpresaActual).Tables("Catalogo").Rows(j).Item("SALDO_INICIAL")
                        Next
                    Catch ex As Exception

                    End Try
                    If i > 0 Then
                        catalogo.UpdateSaldosEdit(lbCuenta.Items(i - 1), saldo, cbClase.SelectedIndex)
                    End If

                    i = i - 1

                End While

            End If


            Me.Close()

        End If

    End Sub

    Private Sub frmNuevaCuenta_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim cat As frmCatalogo = cat.Instance
        cat.cargar()

    End Sub

    Private Sub txtCodigo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Enter
        Dim data As DataObject
        If Clipboard.GetDataObject.GetDataPresent(System.Windows.Forms.DataFormats.Text) = True Then
            CB = Clipboard.GetDataObject.GetData(System.Windows.Forms.DataFormats.Text)
            Clipboard.SetDataObject("")

        End If

    End Sub

    Private Sub cbAgrupaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbAgrupaciones.KeyPress
        Dim a As New VB.SysContab.AgrupacionesDB()

        If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
            If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
                Agrupaciones = ""
                cbAgrupaciones.SelectAll()
                Exit Sub

            End If

            If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
                Exit Sub

            End If
        End If

        If cbAgrupaciones.Text = "" Then
            Agrupaciones = ""
            Exit Sub
        End If

        If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
            If Agrupaciones.Length = 1 Then
                Agrupaciones = ""
            End If

            If Agrupaciones.Length > 1 Then
                Agrupaciones = Mid(Agrupaciones, 1, Agrupaciones.Length - 1)
            End If

            If cbAgrupaciones.Text = "" Then
                Agrupaciones = ""
                Exit Sub

            End If

        Else
            Agrupaciones = Agrupaciones & e.KeyChar

        End If

        If a.GetListBuscarCombo(Agrupaciones).Tables("Agrupaciones").Rows.Count = 0 Then
            '
        Else
            cbAgrupaciones.SelectedValue = a.GetListBuscarCombo(grupos).Tables("Agrupaciones").Rows(0).Item("CODIGO_AGRUPACION")
            cbAgrupaciones.SelectionStart = Agrupaciones.Length
            cbAgrupaciones.Select(Agrupaciones.Length, cbAgrupaciones.Text.Length)

        End If
    End Sub

    Private Sub cbAgrupaciones_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAgrupaciones.Leave
        Dim a As New VB.SysContab.AgrupacionesDB()

        If Trim(cbAgrupaciones.Text) = "" Then
            Agrupaciones = ""
            Exit Sub
        End If

        If a.GetListBuscarCombo(cbAgrupaciones.Text).Tables("Agrupaciones").Rows.Count = 0 Then
            MsgBox("Agrupación no Existe", MsgBoxStyle.Information)
            Agrupaciones = ""
            cbAgrupaciones.Focus()
            Exit Sub

        End If

        cbAgrupaciones.SelectedValue = a.GetListBuscarCombo(cbAgrupaciones.Text).Tables("Agrupaciones").Rows(0).Item("CODIGO_AGRUPACION")
        Cod_Agrupacion = a.GetListBuscarCombo(cbAgrupaciones.Text).Tables("Agrupaciones").Rows(0).Item("CODIGO_AGRUPACION")

        Agrupaciones = ""

    End Sub

    Private Sub cbAgrupaciones_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAgrupaciones.SelectedValueChanged
        Agrupaciones = ""
    End Sub

    Private Sub cmdAcumulados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulados.Click
        Dim f As frmAcumuladosCuenta = f.Instance

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub txtSaldoInicial_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSaldoInicial.Leave
        Try
            txtSaldoInicial.Text = CDbl(txtSaldoInicial.Text).ToString(Round)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPresupuestoAnual_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPresupuestoAnual.Leave
        Try
            txtPresupuestoAnual.Text = CDbl(txtPresupuestoAnual.Text).ToString(Round)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipo.SelectedIndexChanged
        If Me.cbTipo.Text <> "Auxiliar" Then
            Me.cbGpo_Presupuesto.SelectedValue = 0
            Me.cbGpo_Presupuesto.Enabled = False
        Else
            Me.cbGpo_Presupuesto.Enabled = True
            chkRetencion.Enabled = True
            chkDevolucion.Enabled = True
            chkRebajas.Enabled = True
            chkMnto.Enabled = True
            chkRendicion.Enabled = True
            chkActiva.Enabled = True
            chkProyecto.Enabled = True
        End If
    End Sub
End Class
