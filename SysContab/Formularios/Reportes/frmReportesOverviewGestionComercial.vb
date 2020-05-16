Public Class frmReportesOverviewGestionComercial
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReportesOverviewGestionComercial = Nothing

    Public Shared Function Instance() As frmReportesOverviewGestionComercial
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportesOverviewGestionComercial()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents Button6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bAntiguedadPagos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnIVA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnIR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAmortiza As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaldosInvent As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bAntiguedadVentas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bAntiguedadInventario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bProximasVencerP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bProximasVencerC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bSaldoPeriodo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bRecuperacionxSaldo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bKardex As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
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
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bComisiones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bBosla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bAnalisisCartera As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Button9 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportesOverviewGestionComercial))
        Me.btnIR = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bAnalisisCartera = New DevExpress.XtraEditors.SimpleButton()
        Me.bBosla = New DevExpress.XtraEditors.SimpleButton()
        Me.bComisiones = New DevExpress.XtraEditors.SimpleButton()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button6 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIVA = New DevExpress.XtraEditors.SimpleButton()
        Me.Button7 = New DevExpress.XtraEditors.SimpleButton()
        Me.bRecuperacionxSaldo = New DevExpress.XtraEditors.SimpleButton()
        Me.bKardex = New DevExpress.XtraEditors.SimpleButton()
        Me.bAntiguedadInventario = New DevExpress.XtraEditors.SimpleButton()
        Me.bSaldoPeriodo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaldosInvent = New DevExpress.XtraEditors.SimpleButton()
        Me.bAntiguedadVentas = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAmortiza = New DevExpress.XtraEditors.SimpleButton()
        Me.bProximasVencerC = New DevExpress.XtraEditors.SimpleButton()
        Me.bProximasVencerP = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.bAntiguedadPagos = New DevExpress.XtraEditors.SimpleButton()
        Me.Button9 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button8 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button4 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Button3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIR
        '
        Me.btnIR.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIR.Appearance.Options.UseFont = True
        Me.btnIR.Location = New System.Drawing.Point(643, 241)
        Me.btnIR.Name = "btnIR"
        Me.btnIR.Size = New System.Drawing.Size(54, 22)
        Me.btnIR.StyleController = Me.LayoutControl1
        Me.btnIR.TabIndex = 9
        Me.btnIR.Text = "I.R."
        Me.btnIR.Visible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bAnalisisCartera)
        Me.LayoutControl1.Controls.Add(Me.bBosla)
        Me.LayoutControl1.Controls.Add(Me.bComisiones)
        Me.LayoutControl1.Controls.Add(Me.Button2)
        Me.LayoutControl1.Controls.Add(Me.Button6)
        Me.LayoutControl1.Controls.Add(Me.btnIR)
        Me.LayoutControl1.Controls.Add(Me.btnIVA)
        Me.LayoutControl1.Controls.Add(Me.Button7)
        Me.LayoutControl1.Controls.Add(Me.bRecuperacionxSaldo)
        Me.LayoutControl1.Controls.Add(Me.bKardex)
        Me.LayoutControl1.Controls.Add(Me.bAntiguedadInventario)
        Me.LayoutControl1.Controls.Add(Me.bSaldoPeriodo)
        Me.LayoutControl1.Controls.Add(Me.btnSaldosInvent)
        Me.LayoutControl1.Controls.Add(Me.bAntiguedadVentas)
        Me.LayoutControl1.Controls.Add(Me.btnAmortiza)
        Me.LayoutControl1.Controls.Add(Me.bProximasVencerC)
        Me.LayoutControl1.Controls.Add(Me.bProximasVencerP)
        Me.LayoutControl1.Controls.Add(Me.PictureBox1)
        Me.LayoutControl1.Controls.Add(Me.Button1)
        Me.LayoutControl1.Controls.Add(Me.bAntiguedadPagos)
        Me.LayoutControl1.Controls.Add(Me.Button9)
        Me.LayoutControl1.Controls.Add(Me.Button8)
        Me.LayoutControl1.Controls.Add(Me.Button4)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1058, 325, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(878, 600)
        Me.LayoutControl1.TabIndex = 160
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bAnalisisCartera
        '
        Me.bAnalisisCartera.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAnalisisCartera.Appearance.Options.UseFont = True
        Me.bAnalisisCartera.Enabled = False
        Me.bAnalisisCartera.ImageOptions.Image = CType(resources.GetObject("bAnalisisCartera.ImageOptions.Image"), System.Drawing.Image)
        Me.bAnalisisCartera.Location = New System.Drawing.Point(614, 503)
        Me.bAnalisisCartera.Name = "bAnalisisCartera"
        Me.bAnalisisCartera.Size = New System.Drawing.Size(219, 36)
        Me.bAnalisisCartera.StyleController = Me.LayoutControl1
        Me.bAnalisisCartera.TabIndex = 162
        Me.bAnalisisCartera.Text = "ANALISIS DE CARTERA"
        '
        'bBosla
        '
        Me.bBosla.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBosla.Appearance.Options.UseFont = True
        Me.bBosla.Enabled = False
        Me.bBosla.ImageOptions.Image = CType(resources.GetObject("bBosla.ImageOptions.Image"), System.Drawing.Image)
        Me.bBosla.Location = New System.Drawing.Point(614, 463)
        Me.bBosla.Name = "bBosla"
        Me.bBosla.Size = New System.Drawing.Size(219, 36)
        Me.bBosla.StyleController = Me.LayoutControl1
        Me.bBosla.TabIndex = 22
        Me.bBosla.Text = "BOLSA AGROPECUARIA"
        '
        'bComisiones
        '
        Me.bComisiones.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bComisiones.Appearance.Options.UseFont = True
        Me.bComisiones.Enabled = False
        Me.bComisiones.ImageOptions.Image = CType(resources.GetObject("bComisiones.ImageOptions.Image"), System.Drawing.Image)
        Me.bComisiones.Location = New System.Drawing.Point(614, 423)
        Me.bComisiones.Name = "bComisiones"
        Me.bComisiones.Size = New System.Drawing.Size(219, 36)
        Me.bComisiones.StyleController = Me.LayoutControl1
        Me.bComisiones.TabIndex = 21
        Me.bComisiones.Text = "COMISIONES DE VENTA"
        '
        'Button2
        '
        Me.Button2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Appearance.Options.UseFont = True
        Me.Button2.Enabled = False
        Me.Button2.ImageOptions.Image = CType(resources.GetObject("Button2.ImageOptions.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(567, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 65)
        Me.Button2.StyleController = Me.LayoutControl1
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "COMPRAS      "
        Me.Button2.Visible = False
        '
        'Button6
        '
        Me.Button6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Appearance.Options.UseFont = True
        Me.Button6.Enabled = False
        Me.Button6.ImageOptions.Image = CType(resources.GetObject("Button6.ImageOptions.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(555, 241)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(142, 61)
        Me.Button6.StyleController = Me.LayoutControl1
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "VENTAS          "
        Me.Button6.Visible = False
        '
        'btnIVA
        '
        Me.btnIVA.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIVA.Appearance.Options.UseFont = True
        Me.btnIVA.Location = New System.Drawing.Point(611, 241)
        Me.btnIVA.Name = "btnIVA"
        Me.btnIVA.Size = New System.Drawing.Size(86, 22)
        Me.btnIVA.StyleController = Me.LayoutControl1
        Me.btnIVA.TabIndex = 8
        Me.btnIVA.Text = "I.V.A."
        Me.btnIVA.Visible = False
        '
        'Button7
        '
        Me.Button7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Appearance.Options.UseFont = True
        Me.Button7.Enabled = False
        Me.Button7.ImageOptions.Image = CType(resources.GetObject("Button7.ImageOptions.Image"), System.Drawing.Image)
        Me.Button7.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.Button7.Location = New System.Drawing.Point(588, 241)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(109, 41)
        Me.Button7.StyleController = Me.LayoutControl1
        Me.Button7.TabIndex = 7
        Me.Button7.Visible = False
        '
        'bRecuperacionxSaldo
        '
        Me.bRecuperacionxSaldo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRecuperacionxSaldo.Appearance.Options.UseFont = True
        Me.bRecuperacionxSaldo.Appearance.Options.UseTextOptions = True
        Me.bRecuperacionxSaldo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bRecuperacionxSaldo.Enabled = False
        Me.bRecuperacionxSaldo.ImageOptions.Image = CType(resources.GetObject("bRecuperacionxSaldo.ImageOptions.Image"), System.Drawing.Image)
        Me.bRecuperacionxSaldo.Location = New System.Drawing.Point(332, 509)
        Me.bRecuperacionxSaldo.Name = "bRecuperacionxSaldo"
        Me.bRecuperacionxSaldo.Size = New System.Drawing.Size(254, 36)
        Me.bRecuperacionxSaldo.StyleController = Me.LayoutControl1
        Me.bRecuperacionxSaldo.TabIndex = 19
        Me.bRecuperacionxSaldo.Text = "RECUPERACION POR SALDOS"
        '
        'bKardex
        '
        Me.bKardex.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bKardex.Appearance.Options.UseFont = True
        Me.bKardex.Appearance.Options.UseTextOptions = True
        Me.bKardex.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bKardex.Enabled = False
        Me.bKardex.ImageOptions.Image = CType(resources.GetObject("bKardex.ImageOptions.Image"), System.Drawing.Image)
        Me.bKardex.Location = New System.Drawing.Point(614, 341)
        Me.bKardex.Name = "bKardex"
        Me.bKardex.Size = New System.Drawing.Size(219, 38)
        Me.bKardex.StyleController = Me.LayoutControl1
        Me.bKardex.TabIndex = 20
        Me.bKardex.Text = "&KARDEX GENERAL DE INVENTARIO"
        '
        'bAntiguedadInventario
        '
        Me.bAntiguedadInventario.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAntiguedadInventario.Appearance.Options.UseFont = True
        Me.bAntiguedadInventario.Enabled = False
        Me.bAntiguedadInventario.ImageOptions.Image = CType(resources.GetObject("bAntiguedadInventario.ImageOptions.Image"), System.Drawing.Image)
        Me.bAntiguedadInventario.Location = New System.Drawing.Point(614, 299)
        Me.bAntiguedadInventario.Name = "bAntiguedadInventario"
        Me.bAntiguedadInventario.Size = New System.Drawing.Size(219, 38)
        Me.bAntiguedadInventario.StyleController = Me.LayoutControl1
        Me.bAntiguedadInventario.TabIndex = 15
        Me.bAntiguedadInventario.Text = "ANTIGUEDAD DEL INVENTARIO"
        '
        'bSaldoPeriodo
        '
        Me.bSaldoPeriodo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSaldoPeriodo.Appearance.Options.UseFont = True
        Me.bSaldoPeriodo.Enabled = False
        Me.bSaldoPeriodo.ImageOptions.Image = CType(resources.GetObject("bSaldoPeriodo.ImageOptions.Image"), System.Drawing.Image)
        Me.bSaldoPeriodo.Location = New System.Drawing.Point(332, 383)
        Me.bSaldoPeriodo.Name = "bSaldoPeriodo"
        Me.bSaldoPeriodo.Size = New System.Drawing.Size(254, 38)
        Me.bSaldoPeriodo.StyleController = Me.LayoutControl1
        Me.bSaldoPeriodo.TabIndex = 18
        Me.bSaldoPeriodo.Text = "SALDOS DE CLIENTE POR PERIODO"
        '
        'btnSaldosInvent
        '
        Me.btnSaldosInvent.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaldosInvent.Appearance.Options.UseFont = True
        Me.btnSaldosInvent.Enabled = False
        Me.btnSaldosInvent.ImageOptions.Image = CType(resources.GetObject("btnSaldosInvent.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSaldosInvent.Location = New System.Drawing.Point(614, 257)
        Me.btnSaldosInvent.Name = "btnSaldosInvent"
        Me.btnSaldosInvent.Size = New System.Drawing.Size(219, 38)
        Me.btnSaldosInvent.StyleController = Me.LayoutControl1
        Me.btnSaldosInvent.TabIndex = 13
        Me.btnSaldosInvent.Text = "SALDOS DE INVENTARIO"
        '
        'bAntiguedadVentas
        '
        Me.bAntiguedadVentas.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAntiguedadVentas.Appearance.Options.UseFont = True
        Me.bAntiguedadVentas.Enabled = False
        Me.bAntiguedadVentas.ImageOptions.Image = CType(resources.GetObject("bAntiguedadVentas.ImageOptions.Image"), System.Drawing.Image)
        Me.bAntiguedadVentas.Location = New System.Drawing.Point(332, 467)
        Me.bAntiguedadVentas.Name = "bAntiguedadVentas"
        Me.bAntiguedadVentas.Size = New System.Drawing.Size(254, 38)
        Me.bAntiguedadVentas.StyleController = Me.LayoutControl1
        Me.bAntiguedadVentas.TabIndex = 14
        Me.bAntiguedadVentas.Text = "ANTIGUEDAD DE LO VENDIDO"
        '
        'btnAmortiza
        '
        Me.btnAmortiza.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmortiza.Appearance.Options.UseFont = True
        Me.btnAmortiza.Enabled = False
        Me.btnAmortiza.ImageOptions.Image = CType(resources.GetObject("btnAmortiza.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAmortiza.Location = New System.Drawing.Point(614, 383)
        Me.btnAmortiza.Name = "btnAmortiza"
        Me.btnAmortiza.Size = New System.Drawing.Size(219, 36)
        Me.btnAmortiza.StyleController = Me.LayoutControl1
        Me.btnAmortiza.TabIndex = 12
        Me.btnAmortiza.Text = "AMORTIZACIONES"
        '
        'bProximasVencerC
        '
        Me.bProximasVencerC.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bProximasVencerC.Appearance.Options.UseFont = True
        Me.bProximasVencerC.Appearance.Options.UseTextOptions = True
        Me.bProximasVencerC.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bProximasVencerC.Enabled = False
        Me.bProximasVencerC.ImageOptions.Image = CType(resources.GetObject("bProximasVencerC.ImageOptions.Image"), System.Drawing.Image)
        Me.bProximasVencerC.Location = New System.Drawing.Point(332, 341)
        Me.bProximasVencerC.Name = "bProximasVencerC"
        Me.bProximasVencerC.Size = New System.Drawing.Size(254, 38)
        Me.bProximasVencerC.StyleController = Me.LayoutControl1
        Me.bProximasVencerC.TabIndex = 17
        Me.bProximasVencerC.Text = "FACTURAS PROXIMAS A VENCER CLIENTES"
        '
        'bProximasVencerP
        '
        Me.bProximasVencerP.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bProximasVencerP.Appearance.Options.UseFont = True
        Me.bProximasVencerP.Appearance.Options.UseTextOptions = True
        Me.bProximasVencerP.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bProximasVencerP.Enabled = False
        Me.bProximasVencerP.ImageOptions.Image = CType(resources.GetObject("bProximasVencerP.ImageOptions.Image"), System.Drawing.Image)
        Me.bProximasVencerP.Location = New System.Drawing.Point(24, 341)
        Me.bProximasVencerP.Name = "bProximasVencerP"
        Me.bProximasVencerP.Size = New System.Drawing.Size(280, 36)
        Me.bProximasVencerP.StyleController = Me.LayoutControl1
        Me.bProximasVencerP.TabIndex = 16
        Me.bProximasVencerP.Text = "FACTURAS PROXIMAS A VENCER PROVEEDORES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SysContab.My.Resources.Resources.banner_Asistente_Gestión_Comercial_Ventas
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(833, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Appearance.Options.UseFont = True
        Me.Button1.Enabled = False
        Me.Button1.ImageOptions.Image = CType(resources.GetObject("Button1.ImageOptions.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(24, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(280, 38)
        Me.Button1.StyleController = Me.LayoutControl1
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CTAS X PAGAR      "
        '
        'bAntiguedadPagos
        '
        Me.bAntiguedadPagos.Appearance.Options.UseTextOptions = True
        Me.bAntiguedadPagos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bAntiguedadPagos.Enabled = False
        Me.bAntiguedadPagos.ImageOptions.Image = CType(resources.GetObject("bAntiguedadPagos.ImageOptions.Image"), System.Drawing.Image)
        Me.bAntiguedadPagos.Location = New System.Drawing.Point(332, 425)
        Me.bAntiguedadPagos.Name = "bAntiguedadPagos"
        Me.bAntiguedadPagos.Size = New System.Drawing.Size(254, 38)
        Me.bAntiguedadPagos.StyleController = Me.LayoutControl1
        Me.bAntiguedadPagos.TabIndex = 5
        Me.bAntiguedadPagos.Text = "ANTIGUEDAD DE PAGOS DE CLIENTES"
        '
        'Button9
        '
        Me.Button9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Appearance.Options.UseFont = True
        Me.Button9.Enabled = False
        Me.Button9.ImageOptions.Image = CType(resources.GetObject("Button9.ImageOptions.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(24, 299)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(280, 38)
        Me.Button9.StyleController = Me.LayoutControl1
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "SALDOS PROVEEDORES"
        '
        'Button8
        '
        Me.Button8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Appearance.Options.UseFont = True
        Me.Button8.Enabled = False
        Me.Button8.ImageOptions.Image = CType(resources.GetObject("Button8.ImageOptions.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(332, 299)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(254, 38)
        Me.Button8.StyleController = Me.LayoutControl1
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "SALDOS DE CLIENTES"
        '
        'Button4
        '
        Me.Button4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Appearance.Options.UseFont = True
        Me.Button4.Enabled = False
        Me.Button4.ImageOptions.Image = CType(resources.GetObject("Button4.ImageOptions.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(332, 257)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(254, 38)
        Me.Button4.StyleController = Me.LayoutControl1
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "CTAS X COBRAR     "
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.Button7
        Me.LayoutControlItem16.Location = New System.Drawing.Point(729, 229)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(113, 83)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.btnIVA
        Me.LayoutControlItem17.Location = New System.Drawing.Point(752, 229)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(90, 83)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.btnIR
        Me.LayoutControlItem18.Location = New System.Drawing.Point(784, 229)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(58, 83)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.Button6
        Me.LayoutControlItem19.Location = New System.Drawing.Point(696, 229)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(146, 83)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.Button2
        Me.LayoutControlItem20.Location = New System.Drawing.Point(708, 229)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(134, 83)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlItem1, Me.LayoutControlGroup5, Me.EmptySpaceItem2, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(878, 600)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseBackColor = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 212)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(308, 337)
        Me.LayoutControlGroup2.Text = "PROVEEDORES"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Button1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(284, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(284, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(284, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.bProximasVencerP
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(284, 208)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Button9
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(284, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(284, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(284, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlGroup3.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup3.AppearanceGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseBackColor = True
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem15})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(308, 212)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(282, 337)
        Me.LayoutControlGroup3.Text = "CLIENTES"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Button4
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Button8
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bProximasVencerC
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.bSaldoPeriodo
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.bAntiguedadPagos
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.bAntiguedadVentas
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(258, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.bRecuperacionxSaldo
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(258, 40)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PictureBox1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(0, 212)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(104, 212)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(837, 212)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlGroup5.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup5.AppearanceGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.LayoutControlGroup5.AppearanceGroup.Options.UseBackColor = True
        Me.LayoutControlGroup5.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup5.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup5.CustomizationFormText = "INVENTARIO Y OTROS"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem11, Me.LayoutControlItem14, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(590, 212)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(247, 337)
        Me.LayoutControlGroup5.Text = "INVENTARIO Y OTROS"
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.btnSaldosInvent
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(223, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(223, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(223, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.bAntiguedadInventario
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(223, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(223, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(223, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnAmortiza
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(223, 40)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.bKardex
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(223, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(223, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(223, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.bComisiones
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 166)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(223, 40)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.bBosla
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 206)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(223, 40)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.bAnalisisCartera
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 246)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(223, 46)
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 549)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(837, 31)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(837, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(21, 580)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'Button3
        '
        Me.Button3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Appearance.Options.UseFont = True
        Me.Button3.ImageOptions.Image = CType(resources.GetObject("Button3.ImageOptions.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(12, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 36)
        Me.Button3.StyleController = Me.LayoutControl2
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "&SALIR"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.Button3)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup4
        Me.LayoutControl2.Size = New System.Drawing.Size(193, 571)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem21, Me.EmptySpaceItem1})
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(193, 571)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.Button3
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(173, 40)
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 40)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(173, 511)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("571f5295-6aae-4043-94a3-bd67636cfd1e")
        Me.DockPanel1.Location = New System.Drawing.Point(878, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(200, 600)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 571)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'frmReportesOverviewGestionComercial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1078, 600)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("frmReportesOverviewGestionComercial.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportesOverviewGestionComercial"
        Me.Text = "Reportes de Gestión Comercial"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim DT_ROL As DataTable = Nothing

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        btnIVA.Visible = False
        btnIR.Visible = False

        Dim f As frmReporteCuentasxPagar = frmReporteCuentasxPagar.Instance()

        'f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Gestion Comercial - Cuentas por Pagar"
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        btnIVA.Visible = False
        btnIR.Visible = False

        Dim f As frmReporteEstadoCuenta = frmReporteEstadoCuenta.Instance()

        ''f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Gestión Comercial - Cuentas por Cobrar"

        ''f.Dispose()
        ''f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        btnIVA.Visible = False
        btnIR.Visible = False

        Dim f As frmReportesFacturasCompras = frmReportesFacturasCompras.Instance

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        btnIVA.Visible = False
        btnIR.Visible = False

        Dim f As frmReportesFactura = frmReportesFactura.Instance

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Close()

        'btnIVA.Visible = False
        'btnIR.Visible = False

        'Dim f As frmReportesInventario = frmReportesInventario.Instance

        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAntiguedadPagos.Click
        ShowSplash()
        frmAntiguedadPagosClientes.Dispose()
        frmAntiguedadPagosClientes.MdiParent = Me.MdiParent
        frmAntiguedadPagosClientes.Show()
        frmAntiguedadPagosClientes.Text = "Antiguedad de lo Pagado"
        frmAntiguedadPagosClientes.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        btnIVA.Visible = True
        btnIR.Visible = True


    End Sub

    Private Sub btnIVA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIVA.Click

        Dim f As frmReporteIVAxFacturavb = frmReporteIVAxFacturavb.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIR.Click
        Dim f As frmIRxFacturaReporte = frmIRxFacturaReporte.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ShowSplash("Saldos de Proveedores...")
        Dim frm As frmRptBalanceClientes = frmRptBalanceClientes.Instance()
        frm.Dispose()

        Dim f As frmRptBalanceClientes = frmRptBalanceClientes.Instance
        f.TReporte = "P"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ShowSplash("Saldos de Clientes...")
        Dim frm As frmRptBalanceClientes = frmRptBalanceClientes.Instance()
        frm.Dispose()
        '
        'Verificar si tiene activa las alertas
        Dim dr() As DataRow = DT_ROL.Select("Control = 'Alertas'")

        Dim f As frmRptBalanceClientes = frmRptBalanceClientes.Instance()
        f.TReporte = "C"
        f.Alerta = IIf(dr.Length > 0, True, False)
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub btnAmortiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmortiza.Click
        'frmAmoritizacionesSelecRpt.MdiParent = Me.MdiParent
        frmAmoritizacionesSelecRpt.Text = "Reporte de Amortizaciones"
        frmAmoritizacionesSelecRpt.ShowDialog()
        frmAmoritizacionesSelecRpt.Dispose()
        'frmAmoritizacionesSelecRpt.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnSaldosInvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaldosInvent.Click
        ShowSplash("Cargando...")
        frmSaldoInventarios.Dispose()
        frmSaldoInventarios.MdiParent = Me.MdiParent
        frmSaldoInventarios.Show()
        frmSaldoInventarios.Text = "Saldos de Inventario"
        frmSaldoInventarios.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub frmReportesOverviewGestionComercial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DT_ROL = RolesDB.UsuarioAcciones(Me.LayoutControl1)
    End Sub

    Private Sub bAntiguedadInventario_Click(sender As Object, e As EventArgs) Handles bAntiguedadInventario.Click
        ShowSplash()
        frmReporteAntiguedadInventarios.Dispose()
        frmReporteAntiguedadInventarios.MdiParent = Me.MdiParent
        frmReporteAntiguedadInventarios.Show()
        frmReporteAntiguedadInventarios.Text = "Antiguedad del Inventario"
        frmReporteAntiguedadInventarios.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bAntiguedadVentas_Click(sender As Object, e As EventArgs) Handles bAntiguedadVentas.Click
        ShowSplash()
        frmReporteAntiguedadVentas.Dispose()
        frmReporteAntiguedadVentas.MdiParent = Me.MdiParent
        frmReporteAntiguedadVentas.Show()
        frmReporteAntiguedadVentas.Text = "Antiguedad de lo Vendido"
        frmReporteAntiguedadVentas.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bProximasVencerP.Click
        ShowSplash("Cargando Reporte...")

        frmReporteAntiguedadProvProximasVencer.Dispose()
        frmReporteAntiguedadProvProximasVencer.etInicio.Text = "0"
        frmReporteAntiguedadProvProximasVencer.MdiParent = Me.MdiParent
        frmReporteAntiguedadProvProximasVencer.Hasta.DateTime = VB.SysContab.Rutinas.Fecha().Date
        frmReporteAntiguedadProvProximasVencer.Rubro = ""
        frmReporteAntiguedadProvProximasVencer.Moneda = MonedaBase
        frmReporteAntiguedadProvProximasVencer.Show()
        frmReporteAntiguedadProvProximasVencer.Text = "Facturas Proximas a Vencer Proveedores"
        frmReporteAntiguedadProvProximasVencer.WindowState = FormWindowState.Maximized
        frmReporteAntiguedadProvProximasVencer.etInicio.Text = "1"

        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles bProximasVencerC.Click
        ShowSplash("Cargando Reporte...")

        frmReporteAntiguedadClientesProximasVencer.Dispose()
        frmReporteAntiguedadClientesProximasVencer.etInicio.Text = "0"
        frmReporteAntiguedadClientesProximasVencer.MdiParent = Me.MdiParent
        frmReporteAntiguedadClientesProximasVencer.Hasta.DateTime = VB.SysContab.Rutinas.Fecha().Date
        frmReporteAntiguedadClientesProximasVencer.Moneda = MonedaBase
        frmReporteAntiguedadClientesProximasVencer.SucID = "XX" 'cbCheckSucursal.EditValue   ' cbSucursal.EditValue
        frmReporteAntiguedadClientesProximasVencer.Show()
        frmReporteAntiguedadClientesProximasVencer.Text = "Facturas Proximas a Vencer Clientes"
        frmReporteAntiguedadClientesProximasVencer.WindowState = FormWindowState.Maximized
        frmReporteAntiguedadClientesProximasVencer.etInicio.Text = "1"

        HideSplash()
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles bSaldoPeriodo.Click
        ShowSplash("Cargando Reporte...")

        frmAntiguedadClientesPeriodo.Dispose()
        frmAntiguedadClientesPeriodo.etInicio.Text = "0"
        frmAntiguedadClientesPeriodo.MdiParent = Me.MdiParent
        frmAntiguedadClientesPeriodo.Corte.DateTime = VB.SysContab.Rutinas.Fecha().Date
        frmAntiguedadClientesPeriodo.Moneda = MonedaBase
        frmAntiguedadClientesPeriodo.SucID = "XX" 'cbCheckSucursal.EditValue   ' cbSucursal.EditValue
        frmAntiguedadClientesPeriodo.Show()
        frmAntiguedadClientesPeriodo.Text = "Saldos de Clientes por Periodo"
        frmAntiguedadClientesPeriodo.WindowState = FormWindowState.Maximized
        frmAntiguedadClientesPeriodo.etInicio.Text = "1"

        HideSplash()
    End Sub

    Private Sub bRecuperacionxSaldo_Click(sender As Object, e As EventArgs) Handles bRecuperacionxSaldo.Click
        ShowSplash()
        frmRecuperacionSegunSaldo.Dispose()
        frmRecuperacionSegunSaldo.MdiParent = Me.MdiParent
        frmRecuperacionSegunSaldo.Show()
        frmRecuperacionSegunSaldo.Text = "Recuperación por Saldo"
        frmRecuperacionSegunSaldo.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bBosla_Click(sender As Object, e As EventArgs) Handles bBosla.Click
        ShowSplash()
        frmBolsa.Dispose()
        frmBolsa.MdiParent = Me.MdiParent
        frmBolsa.Show()
        frmBolsa.Text = "Bolsa Agropecuaria"
        frmBolsa.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bComisiones_Click(sender As Object, e As EventArgs) Handles bComisiones.Click

    End Sub

    Private Sub SimpleButton1_Click_2(sender As Object, e As EventArgs) Handles bAnalisisCartera.Click
        ShowSplash()
        frmReportesClientes.Dispose()
        frmReportesClientes.MdiParent = Me.MdiParent
        frmReportesClientes.Show()
        frmReportesClientes.Text = "Analisis de Cartera"
        frmReportesClientes.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub
End Class
