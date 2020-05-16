Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports SysContab.VB.SysContab
Imports DevExpress.XtraEditors

Public Class frmRecibos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmRecibos = Nothing

    Public Shared Function Instance() As frmRecibos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmRecibos
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents chkAdelantos As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbonos As System.Windows.Forms.CheckBox
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkIR As System.Windows.Forms.CheckBox
    Friend WithEvents chkIva As System.Windows.Forms.CheckBox
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VRecibos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtpFecha2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFecha1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dgRecibos As DevExpress.XtraGrid.GridControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecibos))
        Me.chkAdelantos = New System.Windows.Forms.CheckBox()
        Me.chkAbonos = New System.Windows.Forms.CheckBox()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.dtpFecha2 = New DevExpress.XtraEditors.DateEdit()
        Me.dtpFecha1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.chkIva = New System.Windows.Forms.CheckBox()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.chkIR = New System.Windows.Forms.CheckBox()
        Me.cmdEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.dgRecibos = New DevExpress.XtraGrid.GridControl()
        Me.VRecibos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dtpFecha2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VRecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAdelantos
        '
        Me.chkAdelantos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdelantos.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkAdelantos.Location = New System.Drawing.Point(653, 36)
        Me.chkAdelantos.Name = "chkAdelantos"
        Me.chkAdelantos.Size = New System.Drawing.Size(238, 20)
        Me.chkAdelantos.TabIndex = 1
        Me.chkAdelantos.Text = "Adelantos"
        '
        'chkAbonos
        '
        Me.chkAbonos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAbonos.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkAbonos.Location = New System.Drawing.Point(653, 12)
        Me.chkAbonos.Name = "chkAbonos"
        Me.chkAbonos.Size = New System.Drawing.Size(238, 20)
        Me.chkAbonos.TabIndex = 0
        Me.chkAbonos.Text = "Abonos a Facturas de Crédito"
        '
        'etInicio
        '
        Me.etInicio.AutoSize = True
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(858, 37)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(16, 16)
        Me.etInicio.TabIndex = 161
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(790, 271)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(101, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 163
        Me.cmdSalir.Text = "&Salir"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dtpFecha2)
        Me.LayoutControl1.Controls.Add(Me.dtpFecha1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.chkIva)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.chkIR)
        Me.LayoutControl1.Controls.Add(Me.cmdEditar)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.btnExportar)
        Me.LayoutControl1.Controls.Add(Me.btnBorrar)
        Me.LayoutControl1.Controls.Add(Me.btnBuscar)
        Me.LayoutControl1.Controls.Add(Me.cmdAnular)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.dgRecibos)
        Me.LayoutControl1.Controls.Add(Me.chkAbonos)
        Me.LayoutControl1.Controls.Add(Me.chkAdelantos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13, Me.LayoutControlItem14})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1087, 338, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(903, 321)
        Me.LayoutControl1.TabIndex = 173
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.EditValue = Nothing
        Me.dtpFecha2.Location = New System.Drawing.Point(49, 36)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Properties.Appearance.Options.UseFont = True
        Me.dtpFecha2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha2.Size = New System.Drawing.Size(124, 20)
        Me.dtpFecha2.StyleController = Me.LayoutControl1
        Me.dtpFecha2.TabIndex = 176
        '
        'dtpFecha1
        '
        Me.dtpFecha1.EditValue = Nothing
        Me.dtpFecha1.Location = New System.Drawing.Point(49, 12)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Properties.Appearance.Options.UseFont = True
        Me.dtpFecha1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha1.Size = New System.Drawing.Size(124, 20)
        Me.dtpFecha1.StyleController = Me.LayoutControl1
        Me.dtpFecha1.TabIndex = 175
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(589, 271)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(95, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 174
        Me.SimpleButton1.Text = "&Diseño"
        '
        'chkIva
        '
        Me.chkIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkIva.Location = New System.Drawing.Point(425, 271)
        Me.chkIva.Name = "chkIva"
        Me.chkIva.Size = New System.Drawing.Size(40, 20)
        Me.chkIva.TabIndex = 165
        Me.chkIva.Text = "Aplicar IVA"
        Me.chkIva.Visible = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_ParametersLarge
        Me.cmdAyuda.Location = New System.Drawing.Point(682, 433)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(180, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 168
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'chkIR
        '
        Me.chkIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkIR.Location = New System.Drawing.Point(469, 271)
        Me.chkIR.Name = "chkIR"
        Me.chkIR.Size = New System.Drawing.Size(38, 20)
        Me.chkIR.TabIndex = 164
        Me.chkIR.Text = "Aplicar IR"
        Me.chkIR.Visible = False
        '
        'cmdEditar
        '
        Me.cmdEditar.Location = New System.Drawing.Point(682, 433)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(180, 22)
        Me.cmdEditar.StyleController = Me.LayoutControl1
        Me.cmdEditar.TabIndex = 167
        Me.cmdEditar.Text = "&Editar"
        Me.cmdEditar.Visible = False
        '
        'btnExportar
        '
        Me.btnExportar.Enabled = False
        Me.btnExportar.ImageOptions.Image = CType(resources.GetObject("btnExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(688, 271)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(98, 38)
        Me.btnExportar.StyleController = Me.LayoutControl1
        Me.btnExportar.TabIndex = 171
        Me.btnExportar.Text = "&Exportar"
        '
        'btnBorrar
        '
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.ImageOptions.Image = CType(resources.GetObject("btnBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(325, 271)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(96, 38)
        Me.btnBorrar.StyleController = Me.LayoutControl1
        Me.btnBorrar.TabIndex = 170
        Me.btnBorrar.Text = "&Borrar"
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageOptions.Image = CType(resources.GetObject("btnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(177, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 38)
        Me.btnBuscar.StyleController = Me.LayoutControl1
        Me.btnBuscar.TabIndex = 173
        Me.btnBuscar.Text = "&Buscar"
        '
        'cmdAnular
        '
        Me.cmdAnular.Enabled = False
        Me.cmdAnular.ImageOptions.Image = CType(resources.GetObject("cmdAnular.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAnular.Location = New System.Drawing.Point(225, 271)
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(96, 38)
        Me.cmdAnular.StyleController = Me.LayoutControl1
        Me.cmdAnular.TabIndex = 169
        Me.cmdAnular.Text = "A&nular"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 271)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(109, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 162
        Me.cmdAceptar.Text = "&Contabilizar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(125, 271)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(96, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 166
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'dgRecibos
        '
        Me.dgRecibos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgRecibos.Location = New System.Drawing.Point(12, 64)
        Me.dgRecibos.MainView = Me.VRecibos
        Me.dgRecibos.Name = "dgRecibos"
        Me.dgRecibos.Size = New System.Drawing.Size(879, 203)
        Me.dgRecibos.TabIndex = 170
        Me.dgRecibos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.VRecibos})
        '
        'VRecibos
        '
        Me.VRecibos.GridControl = Me.dgRecibos
        Me.VRecibos.Name = "VRecibos"
        Me.VRecibos.OptionsBehavior.Editable = False
        Me.VRecibos.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.VRecibos.OptionsView.ShowAutoFilterRow = True
        Me.VRecibos.OptionsView.ShowChildrenInGroupPanel = True
        Me.VRecibos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.VRecibos.OptionsView.ShowFooter = True
        Me.VRecibos.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdEditar
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(670, 421)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(184, 42)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmdAyuda
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(670, 421)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(184, 42)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem15, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem17, Me.LayoutControlItem16, Me.EmptySpaceItem3, Me.LayoutControlItem7, Me.LayoutControlItem18, Me.LayoutControlItem19})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(903, 321)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dgRecibos
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(883, 207)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnBuscar
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(165, 10)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdAceptar
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 259)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(113, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdImprimir
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(113, 259)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdAnular
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(213, 259)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnBorrar
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(313, 259)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.btnExportar
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(676, 259)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cmdSalir
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(778, 259)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.chkAbonos
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(641, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(242, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(242, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(242, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        Me.LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.chkAdelantos
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(641, 24)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(242, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(242, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(242, 28)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        Me.LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(271, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(370, 52)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(165, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(106, 10)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.chkIva
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(413, 259)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(44, 42)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        Me.LayoutControlItem17.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.chkIR
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(457, 259)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(42, 42)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        Me.LayoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(499, 259)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(78, 42)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(577, 259)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.dtpFecha1
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.Text = "Desde:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(34, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.dtpFecha2
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(165, 28)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(165, 28)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(165, 28)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "Hasta:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(34, 13)
        '
        'frmRecibos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(903, 321)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.etInicio)
        Me.Name = "frmRecibos"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dtpFecha2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRecibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VRecibos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim Clientes As New VB.SysContab.ClientesDB
    Dim Depositos As New VB.SysContab.DepositosDB
    Dim Bancos As New VB.SysContab.BancosDB
    Dim Emisores As New VB.SysContab.EmisoresDB

    Dim Fecha1 As String
    Dim Fecha2 As String
    Dim Tipo As Integer

    Dim Config As New VB.SysContab.ConfiguracionDB
    Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
    Dim Comprobantes As New VB.SysContab.ComprobanteDB

    Public Recibo As String
    Public Cliente As String
    Public Begin As Boolean = False

    Private Sub frmRecibos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)
        ''
        ConfigDetalles = Config.GetConfigDetails

        ''chkFecha.Checked = False
        ''Me.chkFecha.Enabled = IIf(Me.Recibo <> "", False, True)

        Dim f As Date = VB.SysContab.Rutinas.Fecha()

        dtpFecha1.DateTime = New DateTime(f.Year, f.Month, 1).Date
        dtpFecha2.DateTime = UltimoDiaDelMes(f.Date).Date

        ''dtpFecha1.Enabled = False
        ''dtpFecha2.Enabled = False
        ''Fecha1 = ""
        ''Fecha2 = ""

        Tipo = 0

        'cbCliente.DataSource = Clientes.GetList().Tables("Clientes")
        'cbCliente.ValueMember = "Codigo"
        'cbCliente.DisplayMember = "Nombre"

        'cbCliente.SelectedValue = IIf(Me.Cliente = "", 0, Me.Cliente)
        'cbCliente.Enabled = IIf(Me.Cliente = "", True, False)

        ' Me.Text = "M.A.E.S.T.R.O DE R.E.C.I.B.O.S"
        Cargar()

        Me.VRecibos.PopulateColumns()
        FormatoGrid(Me.VRecibos)

        'Me.VRecibos.Columns("Recibo").Width = 80
        'Me.VRecibos.Columns("Fecha").Width = 80
        'Me.VRecibos.Columns("Cliente").Width = 150
        'Me.VRecibos.Columns("Monto").Width = 100

        'Me.VRecibos.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VRecibos.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"
        'Me.VRecibos.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VRecibos.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.VRecibos.Columns("Mtto").Caption = "Mantenimiento"
        'Me.VRecibos.Columns("Mtto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VRecibos.Columns("Mtto").DisplayFormat.FormatString = "{0:n2}"
        'Me.VRecibos.Columns("Mtto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VRecibos.Columns("Mtto").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.VRecibos.Columns("MontoIR").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VRecibos.Columns("MontoIR").DisplayFormat.FormatString = "{0:n2}"
        'Me.VRecibos.Columns("MontoIR").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VRecibos.Columns("MontoIR").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.VRecibos.Columns("IR_Alcaldia").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VRecibos.Columns("IR_Alcaldia").DisplayFormat.FormatString = "{0:n2}"
        'Me.VRecibos.Columns("IR_Alcaldia").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VRecibos.Columns("IR_Alcaldia").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.VRecibos.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VRecibos.Columns("Total").DisplayFormat.FormatString = "{0:n2}"
        'Me.VRecibos.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VRecibos.Columns("Total").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.VRecibos.Columns("Total U$").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.VRecibos.Columns("Total U$").DisplayFormat.FormatString = "{0:n2}"
        'Me.VRecibos.Columns("Total U$").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.VRecibos.Columns("Total U$").SummaryItem.DisplayFormat = "{0:n2}"

        VRecibos.Columns("Código").Visible = False
        VRecibos.Columns("Transaccion").Visible = False
        VRecibos.Columns("CCaja").Visible = False
        VRecibos.Columns("Anulado").Visible = False
        VRecibos.Columns("Comp_No").Visible = False
        VRecibos.Columns("Per_Id").Visible = False
        VRecibos.Columns("Mes").Visible = False

        'Me.VRecibos.Columns("Cliente").Width = 150

        If Not Begin Then HideSplash()
    End Sub

    Public Sub Cargar()
        If Not Begin Then ShowSplash()
        '
        dgRecibos.DataSource = Clientes.RecibosCobros(0,
                                                      dtpFecha1.DateTime.Date,
                                                      dtpFecha2.DateTime.Date,
                                                      Tipo,
                                                      Recibo) _
                                                      .Tables("Cobros")

        If Not Begin Then HideSplash()
    End Sub
    Private Sub chkAdelantos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAdelantos.CheckedChanged
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        If Me.chkAdelantos.Checked = True And Me.chkAbonos.Checked = False Then
            Tipo = 1
        ElseIf Me.chkAdelantos.Checked = True And Me.chkAbonos.Checked = True Then
            Tipo = 0
        ElseIf Me.chkAdelantos.Checked = False And Me.chkAbonos.Checked = False Then
            Tipo = 0
        ElseIf Me.chkAdelantos.Checked = False And Me.chkAbonos.Checked = True Then
            Tipo = 2
        End If
        Me.Cargar()
    End Sub

    Private Sub chkAbonos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAbonos.CheckedChanged
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        If Me.chkAdelantos.Checked = True And Me.chkAbonos.Checked = False Then
            Tipo = 1
        ElseIf Me.chkAdelantos.Checked = True And Me.chkAbonos.Checked = True Then
            Tipo = 0
        ElseIf Me.chkAdelantos.Checked = False And Me.chkAbonos.Checked = False Then
            Tipo = 0
        ElseIf Me.chkAdelantos.Checked = False And Me.chkAbonos.Checked = True Then
            Tipo = 2
        End If
        Me.Cargar()
    End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        'If chkFecha.Checked = True Then
        '    Me.dtpFecha1.Enabled = True
        '    Me.dtpFecha2.Enabled = True
        '    Fecha1 = Me.dtpFecha1.Value.Date
        '    Fecha2 = Me.dtpFecha2.Value.Date
        'Else
        '    Me.dtpFecha1.Enabled = False
        '    Me.dtpFecha2.Enabled = False
        '    Fecha1 = ""
        '    Fecha2 = ""
        'End If

        'Me.Cargar()
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        'Me.dtpFecha2.MinDate = Me.dtpFecha1.Value
        'Fecha1 = Me.dtpFecha1.Value.Date

        'Me.Cargar()
    End Sub

    Private Sub dtpFecha2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        'Fecha2 = Me.dtpFecha2.Value.Date

        'Me.Cargar()
    End Sub

    Private Sub cbCliente_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        'Me.Cargar()
    End Sub

    Private Sub cbCliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        'If Me.cbCliente.SelectedValue = Nothing Then
        '    Me.cbCliente.SelectedValue = 0
        'End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If VRecibos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(CDate(Me.VRecibos.GetFocusedRowCellValue("Fecha")).Date) Then
            Exit Sub
        End If
        '--------------------------------------------------------------------
        '
        Dim dsCobros As DataSet

        If Clientes.ReciboComprobante(
            VRecibos.GetFocusedRowCellValue("Recibo"),
            VRecibos.GetFocusedRowCellValue("Serie")) _
            .Tables("Recibos") _
            .Rows.Count <> 0 Then
            XtraMsg("El Recibo Ya Fue Contabilizado", MessageBoxIcon.Error)
            Exit Sub
        End If

        dsCobros = Clientes.CobrosReciboCaja(
            VRecibos.GetFocusedRowCellValue("Recibo"),
            VRecibos.GetFocusedRowCellValue("Serie"))

        Dim Config As New VB.SysContab.ConfiguracionDB
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails

        ConfigDetalles = Config.GetConfigDetails

        Dim Factura As String
        Dim Recibo As String
        Dim Cliente As String
        Dim ReciboMonto As Double
        Dim ChequeMonto As Double
        Dim EfectivoMonto As Double
        Dim TarjetaMonto As Double
        Dim MttoMonto As Double
        Dim Total As Double
        Dim TCambio As Double = 1.0
        Dim Moneda As String = MonedaBase

        Dim IRMonto As Double
        Dim ClienteMonto As Double

        Dim IRMonto1 As Double

        Recibo = Me.VRecibos.GetFocusedRowCellValue("Recibo")
        'Factura = Me.dgRecibos.Item(Me.dgRecibos.CurrentRowIndex, 1)
        Dim dt As DataTable
        dt = ObtieneDatos("Select Factura From Cobros where recibo = " & Recibo & " AND Transaccion = " & Me.VRecibos.GetFocusedRowCellValue("Transaccion"))

        For x As Integer = 0 To dt.Rows.Count - 1
            If Factura = vbNullString Then
                Factura += dt.Rows(x).Item(0)
            Else
                Factura += "-" & dt.Rows(x).Item(0)
            End If
        Next

        Cliente = Me.VRecibos.GetFocusedRowCellValue("Código")

        Dim dsDetalle As DataSet
        Dim dsIR As DataSet

        Dim CuentaCaja As String
        Dim CuentaIR As String
        Dim CuentaIMtto As String
        Dim CuentaEMtto As String

        'Agregado el 28022008 RMPR
        Dim CuentaIR_Alcaldia As String
        Dim IR_Alcaldia As Double = 0

        Dim Plantilla As New VB.SysContab.PlantillaDB
        Dim TasaCambio As New VB.SysContab.Tasa_CambioDB

        Dim i As Integer

        Dim TipoCOmpr As String = Plantilla.GetPlantillasDetails(4, 3).TipoCompr

        ReciboMonto = 0
        ChequeMonto = 0
        EfectivoMonto = 0
        TarjetaMonto = 0
        MttoMonto = 0
        Total = 0

        Dim ConceptoCheque As String

        For i = 0 To dsCobros.Tables("Cobros").Rows.Count - 1
            If dsCobros.Tables("Cobros").Rows(i).Item("Tipo") = 1 Then
                EfectivoMonto = EfectivoMonto + CDbl(CDbl(dsCobros.Tables("Cobros").Rows(i).Item("Efectivo")).ToString(Round))
                'Total = Total + EfectivoMonto
            ElseIf dsCobros.Tables("Cobros").Rows(i).Item("Tipo") = 2 Then
                ChequeMonto = ChequeMonto + CDbl(CDbl(dsCobros.Tables("Cobros").Rows(i).Item("Cheque")).ToString(Round))
                ConceptoCheque = ConceptoCheque & dsCobros.Tables("Cobros").Rows(i).Item("NoCheque") & ", "
                'Total = Total + ChequeMonto
            ElseIf dsCobros.Tables("Cobros").Rows(i).Item("Tipo") = 3 Then
                TarjetaMonto = TarjetaMonto + CDbl(CDbl(dsCobros.Tables("Cobros").Rows(i).Item("Tarjeta")).ToString(Round))
                'total = 
            End If

            TCambio = dsCobros.Tables("Cobros").Rows(i).Item("TCambio")
            Moneda = dsCobros.Tables("Cobros").Rows(i).Item("Moneda")

            MttoMonto += dsCobros.Tables("Cobros").Rows(i).Item("mtto")

            '------------------------------------------------------
            'No cobrar IR a Facturas Cobros Menores de 1000            
            If EfectivoMonto < ConfigDetalles.MontoIR Then
                'Lo quite pq solamente deberia obviarse el monto en el proceso de acumulacion 28022008 RMPR
                'IRMonto = 0
            Else
                IRMonto += dsCobros.Tables("Cobros").Rows(i).Item("MontoIR")
            End If

            IR_Alcaldia += dsCobros.Tables("Cobros").Rows(i).Item("Monto_IR_Alcaldia")
            '-------------------------
        Next

        Total = EfectivoMonto + ChequeMonto + TarjetaMonto

        If Plantilla.GetPlantillasDetails(4, 3).PlaID Is DBNull.Value Or Plantilla.GetPlantillasDetails(4, 3).PlaID Is Nothing Or Plantilla.GetPlantillasDetails(4, 3).PlaID = "" Then
            XtraMsg("No existen plantilla del tipo Abono de Cliente.", MessageBoxIcon.Error)
        Else
            Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(4, 3).Detalles
            If DsPlantillas.Tables(0).Rows.Count <> 3 Then
                XtraMsg("La plantilla de Abono de Clientes no tiene los registros suficientes para completar la operación.", MessageBoxIcon.Error)
                Exit Sub
            End If
            '
            Try
                CuentaCaja = ObtieneDatos("sp_GetCuentaCaja '" & Me.VRecibos.GetFocusedRowCellValue("CCaja") & "'," & EmpresaActual).Rows.Item(0)("Cuenta")
            Catch ex As Exception
                XtraMsg("No se ha Configurado la Cuenta de la Caja.", MessageBoxIcon.Warning)
                Exit Sub
            End Try

            'CuentaCaja = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
            CuentaIR = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
            CuentaIR_Alcaldia = DsPlantillas.Tables("PlantillasDetalles").Rows(2).Item("Cuenta")
            'dsDetalle = Clientes.FacturaDetalleCalc(Me.VRecibos.GetFocusedRowCellValue("Factura"))

            Dim CuentaMtto, TipoDC As String

            If MttoMonto <> 0 Then
                Try
                    'Buscar las Cuentas de Matto Valor
                    DsPlantillas = Plantilla.GetPlantillasDetails(7, 1).Detalles

                    CuentaIMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                    CuentaEMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
                Catch ex As Exception
                    XtraMsg("Hace Falta la Plantilla de Mantenimiento de Valor.", MessageBoxIcon.Error)
                    Exit Sub
                End Try

                CuentaMtto = IIf(MttoMonto > 0, CuentaIMtto, CuentaEMtto)
                TipoDC = IIf(MttoMonto > 0, "C", "D")   'DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("DC")
            Else
                CuentaMtto = ""
                TipoDC = ""
            End If

            'Buscar si ya se realizo el IR
            ' dsIR = Comprobantes.IRBuscar(Me.VRecibos.GetFocusedRowCellValue("Factura"), CuentaIR)
            '
            ClienteMonto = Total
            '
            Total = Total - IRMonto - IR_Alcaldia
            '            
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            If Comprobantes.GeneraComprobanteRecibo(CuentaCaja, Total, "Por Recibo No. " & Recibo,
                        CuentaIR, IRMonto, "IR de Factura: " & Factura,
                        VB.SysContab.ClientesDB.GetDetails(Cliente).Cuenta, ClienteMonto, "Abono Recibo No. " & Recibo, TipoCOmpr,
                        TCambio, Moneda,
                        "Comprobante de Recibo No. " & Recibo, TipoCOmpr, Me.VRecibos.GetFocusedRowCellValue("Fecha"), Factura,
                        CuentaMtto, MttoMonto, TipoDC, Recibo, IR_Alcaldia, CuentaIR_Alcaldia, "Por Recibo No." & Recibo,
                                                    VRecibos.GetFocusedRowCellValue("Serie")) = True Then

                VB.SysContab.Rutinas.okTransaccion()
                XtraMsg("Se ha Contabilizado Correctamente el Recibo.")
                Me.chkIR.Checked = False

                Cargar()
            Else
                XtraMsg("No se ha podido contabilizar el Recibo.", MessageBoxIcon.Error)
                VB.SysContab.Rutinas.ErrorTransaccion()
            End If
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Dim f As FrmCobrosNew = FrmCobrosNew.Instance()

        If Not f.Visible Then
            Dispose()
            Exit Sub
        End If
        ''
        Dim Cajas As New VB.SysContab.CajasDB
        '' Dim f As FrmCobrosNew = FrmCobrosNew.Instance()
        Dim dsCajas As DataSet
        dsCajas = Cajas.PcNombre(Environment.MachineName.ToString)

        If dsCajas.Tables("Cajas").Rows.Count = 0 Then
            MsgBox("La Computadora " & Environment.MachineName.ToString & " no está configurada como Caja", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.txtCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        Dispose()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If VRecibos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If

        VB.SysContab.ClientesDB.ImprimirRecibo(
            VRecibos.GetFocusedRowCellValue("Recibo"),
            VRecibos.GetFocusedRowCellValue("Serie"), 0)
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click

    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/Procesos/ProcesosContab.chm", HelpNavigator.KeywordIndex, "Sec1.3")
    End Sub

    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        If VRecibos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        If VRecibos.GetFocusedRowCellValue("Anulado") Then
            XtraMsg("El Recibo ya esta Anulado.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(CDate(Me.VRecibos.GetFocusedRowCellValue("Fecha")).Date) Then
            Exit Sub
        End If
        '--------------------------------------------------------------------

        'Dim conexion As New VB.SysContab.Rutinas
        'Verificar si el recibo es parte de un Deposito
        If VB.SysContab.ClientesDB.BuscarRecibosDepositos(
            VRecibos.GetFocusedRowCellValue("Recibo"),
            VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Serie")) > 0 Then
            XtraMsg("El recibo ya es parte de un depósito, favor verificar sus datos.", MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not XtraMsg2("Desea Anular el Recibo#: " &
                        VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Serie") +
                        VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Recibo").ToString()) Then
            Exit Sub
        End If

        If Guardar("sp_del_COBROS",
                   VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Comp_No"),
                   VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Per_Id"),
                   VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Mes"),
                   VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Serie"),
                   VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Recibo"),
                   EmpresaActual) Then Cargar()

        'Dim DTR As DataTable = ObtieneDatos("SELECT DISTINCT c.RECIBO FROM COBROS c WHERE c.RECIBO <> 0 AND c.EMPRESA = " & EmpresaActual)
        'DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        'DBConnFacturas.Open()
        'transaccionFacturas = DBConnFacturas.BeginTransaction()

        'Try
        '    'For i As Integer = 0 To DTR.Rows.Count - 1
        '    '    VB.SysContab.ClientesDB.AnularRecibo(DTR.Rows.Item(i)("RECIBO"))
        '    'Next

        '    VB.SysContab.ClientesDB.AnularRecibo(Me.VRecibos.GetFocusedRowCellValue("Recibo"))

        '    ''For i As Integer = 0 To Me.VRecibos.DataRowCount - 1
        '    ''VB.SysContab.ClientesDB.AnularRecibo(Me.VRecibos.GetRowCellValue(i, "Recibo"))
        '    ''Next
        '    VB.SysContab.Rutinas.okTransaccion()
        '    Me.Cargar()
        'Catch ex As Exception
        '    XtraMsg(ex.Message, MessageBoxIcon.Error)
        '    VB.SysContab.Rutinas.ErrorTransaccion()
        'End Try
    End Sub

    Private Sub VRecibos_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles VRecibos.RowCellStyle
        Dim cadena As String, Estado As Boolean

        If e.Column.FieldName = "Cliente" Then
            If Not VRecibos.GetRowCellValue(e.RowHandle, "Cliente") Is Nothing Then
                cadena = VRecibos.GetRowCellValue(e.RowHandle, "Cliente")
                If cadena.EndsWith("(*** ANULADO ***)") Then
                    e.Appearance.BackColor = Color.Salmon
                End If
            End If
        End If

        If e.Column.FieldName = "Contabilizado" Then
            If Not VRecibos.GetRowCellValue(e.RowHandle, "Contabilizado") Is Nothing Then
                Estado = VRecibos.GetRowCellValue(e.RowHandle, "Contabilizado")
                If Estado Then
                    e.Appearance.BackColor = Color.DarkSalmon
                End If
            End If
        End If

    End Sub

    Private Sub VRecibos_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles VRecibos.FocusedRowChanged
        If VRecibos.GetFocusedRowCellValue("Cliente") Is Nothing Then
            Exit Sub
        End If

        ''Me.cmdAceptar.Enabled = Not VRecibos.GetFocusedRowCellValue("Contabilizado")
        ''
        If VRecibos.GetFocusedRowCellValue("Cliente").endswith("(*** ANULADO ***)") Or
            VRecibos.GetFocusedRowCellValue("Contabilizado") Then
            Me.cmdAceptar.Enabled = False
        Else
            Me.cmdAceptar.Enabled = True
        End If
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If VRecibos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro")
            Exit Sub
        End If
        '
        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(CDate(Me.VRecibos.GetFocusedRowCellValue("Fecha")).Date) Then
            Exit Sub
        End If
        '--------------------------------------------------------------------
        '
        If Not VRecibos.GetFocusedRowCellValue("Anulado") Then
            XtraMsg("Debe Anular primero el Recibo para Borrarlo.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        'Dim DTR As DataTable = ObtieneDatos("SELECT DISTINCT c.RECIBO FROM COBROS_ANULADOS c WHERE c.RECIBO <> 0 AND c.EMPRESA = " & EmpresaActual)
        'For i As Integer = 0 To DTR.Rows.Count - 1
        '    ObtieneDatos("SP_BorrarCobro '" & DTR.Rows.Item(i)("RECIBO") & "'," & EmpresaActual)
        'Next
        'Cargar()

        If Not XtraMsg2("Desea Borrar el Registro Completo del Recibo#: " &
                    VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Serie") &
                    VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Recibo")) Then
            Exit Sub

            'ObtieneDatos("SP_BorrarCobro '" & VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Recibo") & "'," & EmpresaActual)
            ''For i As Integer = 0 To Me.VRecibos.DataRowCount - 1
            ''ObtieneDatos("SP_BorrarCobro '" & VRecibos.GetRowCellValue(i, "Recibo") & "'," & EmpresaActual)
            ''Next
            'Cargar()
        End If
        '
        If Guardar("sp_del_Cobros_Anulados",
                   VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Comp_No"),
                   VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Per_Id"),
                   VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Mes"),
                   VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Serie"),
                   VRecibos.GetRowCellValue(VRecibos.FocusedRowHandle, "Recibo"),
                   EmpresaActual) Then Cargar()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        frmExportarImprimir.Mostrar(dgRecibos)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Cargar()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        FrmConfiguraCheque.Dispose()
        With FrmConfiguraCheque
            .Tipo = 3
            .Nombre = "Recibo Oficial de Caja (R.O.C)"
            .Text = "Configurar Recibo Oficial de Caja (R.O.C)"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With        
    End Sub
End Class

