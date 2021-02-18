Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors

Public Class frmChequesList
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmChequesList = Nothing

    Public Shared Function Instance() As frmChequesList
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmChequesList()
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
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cbPagar As System.Windows.Forms.ComboBox
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridCheques As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cAnulado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdretenciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdimprretencion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbbancos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bAnularProcesado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents etBalance As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdconfret As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequesList))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.cAnulado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bAnularProcesado = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdimprretencion = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdconfret = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdretenciones = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVer = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dtpInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.cbPagar = New System.Windows.Forms.ComboBox()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.GridCheques = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbbancos = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.etBalance = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbbancos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'cAnulado
        '
        Me.cAnulado.Caption = "Anulado"
        Me.cAnulado.FieldName = "Anulado"
        Me.cAnulado.Name = "cAnulado"
        Me.cAnulado.OptionsColumn.AllowEdit = False
        Me.cAnulado.OptionsColumn.AllowFocus = False
        Me.cAnulado.OptionsColumn.ReadOnly = True
        '
        'bAnularProcesado
        '
        Me.bAnularProcesado.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.bAnularProcesado.Appearance.ForeColor = System.Drawing.Color.Black
        Me.bAnularProcesado.Appearance.Options.UseFont = True
        Me.bAnularProcesado.Appearance.Options.UseForeColor = True
        Me.bAnularProcesado.Appearance.Options.UseTextOptions = True
        Me.bAnularProcesado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bAnularProcesado.Enabled = False
        Me.bAnularProcesado.ImageOptions.Image = CType(resources.GetObject("bAnularProcesado.ImageOptions.Image"), System.Drawing.Image)
        Me.bAnularProcesado.Location = New System.Drawing.Point(12, 222)
        Me.bAnularProcesado.Name = "bAnularProcesado"
        Me.bAnularProcesado.Size = New System.Drawing.Size(108, 38)
        Me.bAnularProcesado.StyleController = Me.LayoutControl2
        Me.bAnularProcesado.TabIndex = 165
        Me.bAnularProcesado.Text = "A&nular Procesado"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdSalir)
        Me.LayoutControl2.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl2.Controls.Add(Me.btnExportar)
        Me.LayoutControl2.Controls.Add(Me.bBorrar)
        Me.LayoutControl2.Controls.Add(Me.bAnularProcesado)
        Me.LayoutControl2.Controls.Add(Me.cmdimprretencion)
        Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl2.Controls.Add(Me.cmdconfret)
        Me.LayoutControl2.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl2.Controls.Add(Me.cmdretenciones)
        Me.LayoutControl2.Controls.Add(Me.cmdVer)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1059, 175, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(131, 568)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSalir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.Appearance.Options.UseForeColor = True
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(12, 501)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(108, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl2
        Me.cmdSalir.TabIndex = 29
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAyuda.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAyuda.Appearance.Options.UseFont = True
        Me.cmdAyuda.Appearance.Options.UseForeColor = True
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.ImageOptions.Image = CType(resources.GetObject("cmdAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAyuda.Location = New System.Drawing.Point(12, 459)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(108, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl2
        Me.cmdAyuda.TabIndex = 30
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnExportar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnExportar.Appearance.Options.UseFont = True
        Me.btnExportar.Appearance.Options.UseForeColor = True
        Me.btnExportar.Appearance.Options.UseTextOptions = True
        Me.btnExportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnExportar.Enabled = False
        Me.btnExportar.ImageOptions.Image = CType(resources.GetObject("btnExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(12, 417)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(108, 38)
        Me.btnExportar.StyleController = Me.LayoutControl2
        Me.btnExportar.TabIndex = 163
        Me.btnExportar.Text = "Exportar"
        '
        'bBorrar
        '
        Me.bBorrar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.bBorrar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.bBorrar.Appearance.Options.UseFont = True
        Me.bBorrar.Appearance.Options.UseForeColor = True
        Me.bBorrar.Enabled = False
        Me.bBorrar.ImageOptions.Image = CType(resources.GetObject("bBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.bBorrar.Location = New System.Drawing.Point(12, 264)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(108, 38)
        Me.bBorrar.StyleController = Me.LayoutControl2
        Me.bBorrar.TabIndex = 164
        Me.bBorrar.Text = "B&orrar"
        '
        'cmdimprretencion
        '
        Me.cmdimprretencion.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdimprretencion.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdimprretencion.Appearance.Options.UseFont = True
        Me.cmdimprretencion.Appearance.Options.UseForeColor = True
        Me.cmdimprretencion.Appearance.Options.UseTextOptions = True
        Me.cmdimprretencion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdimprretencion.Enabled = False
        Me.cmdimprretencion.ImageOptions.Image = CType(resources.GetObject("cmdimprretencion.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdimprretencion.Location = New System.Drawing.Point(12, 348)
        Me.cmdimprretencion.Name = "cmdimprretencion"
        Me.cmdimprretencion.Size = New System.Drawing.Size(108, 38)
        Me.cmdimprretencion.StyleController = Me.LayoutControl2
        Me.cmdimprretencion.TabIndex = 163
        Me.cmdimprretencion.Text = "&Imprimir Retención"
        Me.cmdimprretencion.Visible = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdImprimir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Appearance.Options.UseForeColor = True
        Me.cmdImprimir.Appearance.Options.UseTextOptions = True
        Me.cmdImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 96)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(108, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl2
        Me.cmdImprimir.TabIndex = 162
        Me.cmdImprimir.Text = "&Vista  Previa Cheque"
        '
        'cmdconfret
        '
        Me.cmdconfret.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdconfret.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdconfret.Appearance.Options.UseFont = True
        Me.cmdconfret.Appearance.Options.UseForeColor = True
        Me.cmdconfret.Appearance.Options.UseTextOptions = True
        Me.cmdconfret.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdconfret.Enabled = False
        Me.cmdconfret.ImageOptions.Image = CType(resources.GetObject("cmdconfret.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdconfret.Location = New System.Drawing.Point(12, 306)
        Me.cmdconfret.Name = "cmdconfret"
        Me.cmdconfret.Size = New System.Drawing.Size(108, 38)
        Me.cmdconfret.StyleController = Me.LayoutControl2
        Me.cmdconfret.TabIndex = 161
        Me.cmdconfret.Text = "&Configurar Retención"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdBorrar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdBorrar.Appearance.Options.UseFont = True
        Me.cmdBorrar.Appearance.Options.UseForeColor = True
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.ImageOptions.Image = CType(resources.GetObject("cmdBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(12, 180)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(108, 38)
        Me.cmdBorrar.StyleController = Me.LayoutControl2
        Me.cmdBorrar.TabIndex = 161
        Me.cmdBorrar.Text = "A&nular"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(108, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl2
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "&Buscar"
        '
        'cmdretenciones
        '
        Me.cmdretenciones.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdretenciones.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdretenciones.Appearance.Options.UseFont = True
        Me.cmdretenciones.Appearance.Options.UseForeColor = True
        Me.cmdretenciones.Appearance.Options.UseTextOptions = True
        Me.cmdretenciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdretenciones.Enabled = False
        Me.cmdretenciones.ImageOptions.Image = CType(resources.GetObject("cmdretenciones.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdretenciones.Location = New System.Drawing.Point(12, 138)
        Me.cmdretenciones.Name = "cmdretenciones"
        Me.cmdretenciones.Size = New System.Drawing.Size(108, 38)
        Me.cmdretenciones.StyleController = Me.LayoutControl2
        Me.cmdretenciones.TabIndex = 162
        Me.cmdretenciones.Text = "Vista Previa &Retención"
        '
        'cmdVer
        '
        Me.cmdVer.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdVer.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdVer.Appearance.Options.UseFont = True
        Me.cmdVer.Appearance.Options.UseForeColor = True
        Me.cmdVer.Enabled = False
        Me.cmdVer.ImageOptions.Image = CType(resources.GetObject("cmdVer.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdVer.Location = New System.Drawing.Point(12, 54)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(108, 38)
        Me.cmdVer.StyleController = Me.LayoutControl2
        Me.cmdVer.TabIndex = 160
        Me.cmdVer.Text = "&Ver Cheque"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(132, 551)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdAceptar
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdVer
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdImprimir
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdretenciones
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmdBorrar
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.bAnularProcesado
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.bBorrar
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cmdconfret
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cmdimprretencion
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 336)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        Me.LayoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.btnExportar
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 405)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cmdAyuda
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 447)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.cmdSalir
        Me.LayoutControlItem21.CustomizationFormText = "LayoutControlItem21"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 489)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 378)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(112, 27)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'dtpInicial
        '
        Me.dtpInicial.Enabled = False
        Me.dtpInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicial.Location = New System.Drawing.Point(171, 563)
        Me.dtpInicial.Name = "dtpInicial"
        Me.dtpInicial.Size = New System.Drawing.Size(99, 20)
        Me.dtpInicial.TabIndex = 167
        Me.dtpInicial.Visible = False
        '
        'dtpFinal
        '
        Me.dtpFinal.Enabled = False
        Me.dtpFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFinal.Location = New System.Drawing.Point(348, 563)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(95, 20)
        Me.dtpFinal.TabIndex = 169
        Me.dtpFinal.Visible = False
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(582, 563)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(79, 20)
        Me.etInicio.TabIndex = 174
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'chkFecha
        '
        Me.chkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkFecha.Location = New System.Drawing.Point(12, 563)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(81, 20)
        Me.chkFecha.TabIndex = 175
        Me.chkFecha.Text = "Por Fecha:"
        Me.chkFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkFecha.Visible = False
        '
        'cbPagar
        '
        Me.cbPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPagar.Location = New System.Drawing.Point(86, 36)
        Me.cbPagar.Name = "cbPagar"
        Me.cbPagar.Size = New System.Drawing.Size(575, 21)
        Me.cbPagar.TabIndex = 176
        '
        'txtCheque
        '
        Me.txtCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Location = New System.Drawing.Point(521, 563)
        Me.txtCheque.MaxLength = 13
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(57, 20)
        Me.txtCheque.TabIndex = 178
        Me.txtCheque.Visible = False
        '
        'GridCheques
        '
        Me.GridCheques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCheques.Location = New System.Drawing.Point(12, 61)
        Me.GridCheques.MainView = Me.GridView1
        Me.GridCheques.Name = "GridCheques"
        Me.GridCheques.Size = New System.Drawing.Size(649, 473)
        Me.GridCheques.TabIndex = 180
        Me.GridCheques.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.cAnulado, Me.GridColumn15, Me.GridColumn16, Me.GridColumn14})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.cAnulado
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = True
        StyleFormatCondition1.Value2 = True
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView1.GridControl = Me.GridCheques
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Imprimir"
        Me.GridColumn1.FieldName = "Imprimir"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Comprobante"
        Me.GridColumn2.FieldName = "Comp_No"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Cheque"
        Me.GridColumn3.FieldName = "Número"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 78
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Fecha"
        Me.GridColumn4.DisplayFormat.FormatString = "d"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "Fecha"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.AllowFocus = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 60
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Pagar A"
        Me.GridColumn5.FieldName = "Pagar A"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 150
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Monto"
        Me.GridColumn6.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Monto"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.AllowFocus = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto", "{0:n2}")})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 78
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Periodo"
        Me.GridColumn7.FieldName = "Per_ID"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.AllowFocus = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "No. Cuenta"
        Me.GridColumn8.FieldName = "No. Cuenta"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.AllowFocus = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        Me.GridColumn8.Width = 81
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Moneda"
        Me.GridColumn9.FieldName = "Moneda"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.AllowFocus = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        Me.GridColumn9.Width = 82
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn10.AppearanceHeader.Options.UseFont = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Moneda Codigo"
        Me.GridColumn10.FieldName = "Mon_Codigo"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.AllowFocus = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Factura"
        Me.GridColumn11.FieldName = "Factura"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.AllowFocus = False
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn12.AppearanceHeader.Options.UseFont = True
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "Proveedor"
        Me.GridColumn12.FieldName = "Proveedor"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.AllowFocus = False
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Banco"
        Me.GridColumn13.FieldName = "Banco"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.AllowFocus = False
        Me.GridColumn13.OptionsColumn.ReadOnly = True
        Me.GridColumn13.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "Anticipo"
        Me.GridColumn15.FieldName = "Anticipo"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.AllowFocus = False
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 7
        Me.GridColumn15.Width = 51
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Concepto"
        Me.GridColumn16.FieldName = "Concepto"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        '
        'cmbbancos
        '
        Me.cmbbancos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbbancos.Location = New System.Drawing.Point(86, 12)
        Me.cmbbancos.Name = "cmbbancos"
        Me.cmbbancos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbbancos.Properties.NullText = ""
        Me.cmbbancos.Size = New System.Drawing.Size(373, 20)
        Me.cmbbancos.StyleController = Me.LayoutControl1
        Me.cmbbancos.TabIndex = 181
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me.etBalance)
        Me.LayoutControl1.Controls.Add(Me.txtCheque)
        Me.LayoutControl1.Controls.Add(Me.chkFecha)
        Me.LayoutControl1.Controls.Add(Me.dtpInicial)
        Me.LayoutControl1.Controls.Add(Me.dtpFinal)
        Me.LayoutControl1.Controls.Add(Me.cmbbancos)
        Me.LayoutControl1.Controls.Add(Me.GridCheques)
        Me.LayoutControl1.Controls.Add(Me.cbPagar)
        Me.LayoutControl1.Controls.Add(Me.etInicio)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1161, 169, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(673, 595)
        Me.LayoutControl1.TabIndex = 182
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 538)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Mostrar más datos"
        Me.CheckEdit1.Size = New System.Drawing.Size(145, 19)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 183
        '
        'etBalance
        '
        Me.etBalance.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etBalance.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.etBalance.Appearance.Options.UseFont = True
        Me.etBalance.Appearance.Options.UseForeColor = True
        Me.etBalance.Appearance.Options.UseTextOptions = True
        Me.etBalance.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.etBalance.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.etBalance.Location = New System.Drawing.Point(537, 12)
        Me.etBalance.Name = "etBalance"
        Me.etBalance.Size = New System.Drawing.Size(124, 20)
        Me.etBalance.StyleController = Me.LayoutControl1
        Me.etBalance.TabIndex = 182
        Me.etBalance.Text = "0.00"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem22, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(673, 595)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmbbancos
        Me.LayoutControlItem1.CustomizationFormText = "Cuenta Banco:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(451, 24)
        Me.LayoutControlItem1.Text = "Cuenta Banco:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cbPagar
        Me.LayoutControlItem2.CustomizationFormText = "Pagar a:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(653, 25)
        Me.LayoutControlItem2.Text = "Pagar a:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(71, 13)
        Me.LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.etBalance
        Me.LayoutControlItem4.CustomizationFormText = "Balance:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(451, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(202, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(202, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(202, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Balance:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(71, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.GridCheques
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(653, 477)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.chkFecha
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 551)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(85, 24)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        Me.LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.dtpInicial
        Me.LayoutControlItem7.CustomizationFormText = "Desde:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(85, 551)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(177, 24)
        Me.LayoutControlItem7.Text = "Desde:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(71, 13)
        Me.LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.dtpFinal
        Me.LayoutControlItem8.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(262, 551)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem8.Text = "Hasta:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(71, 13)
        Me.LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtCheque
        Me.LayoutControlItem9.CustomizationFormText = "No. Cheque"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(435, 551)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(135, 24)
        Me.LayoutControlItem9.Text = "No. Cheque"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(71, 13)
        Me.LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.CheckEdit1
        Me.LayoutControlItem22.CustomizationFormText = "LayoutControlItem22"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 526)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(149, 25)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(149, 25)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(653, 25)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.etInicio
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(570, 551)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(83, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        Me.LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
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
        Me.DockPanel1.ID = New System.Guid("3793e2a0-ed07-43a2-8bc8-e284f9a14d90")
        Me.DockPanel1.Location = New System.Drawing.Point(673, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 595)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 568)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Vencimiento"
        Me.GridColumn14.DisplayFormat.FormatString = "d"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn14.FieldName = "Vencimiento"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 2
        Me.GridColumn14.Width = 51
        '
        'frmChequesList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(813, 595)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmChequesList"
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbbancos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Comp As New VB.SysContab.ComprobanteDB()
    Dim compDet As New VB.SysContab.ComprobantesDetails()
    Dim r As New VB.SysContab.Rutinas()
    Dim Mes As New VB.SysContab.MesesDB()
    Dim PerDB As New VB.SysContab.PeriodosDB()
    Dim Catalogo As New VB.SysContab.CatalogoDB()
    Dim CatalogoBancos As New VB.SysContab.Catalogo_BancosDB()
    Dim Proveedores As New VB.SysContab.ProveedoresDB()

    Dim Fecha1 As String
    Dim Fecha2 As String

    Dim ds As DataSet

    Dim i As Integer
    Dim Cheques As String
    Dim Facturas As String

    Private Sub frmChequesList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl2)
        ''
        Me.dtpInicial.Value = r.Fecha
        Me.dtpFinal.Value = r.Fecha

        Me.dtpFinal.MinDate = Me.dtpFinal.Value
        Fecha1 = ""
        Fecha2 = ""

        Me.dtpInicial.Enabled = False
        Me.dtpFinal.Enabled = False

        Me.cmbbancos.Properties.DataSource = ObtieneDatos("SP_GetCatalogoBancos " & EmpresaActual)
        Me.cmbbancos.Properties.ValueMember = "Cuenta"
        Me.cmbbancos.Properties.DisplayMember = "Nombre"
        Me.cmbbancos.Properties.PopulateColumns()
        Me.cmbbancos.Properties.Columns("Codigo").Visible = False
        Me.cmbbancos.Properties.Columns("Cod").Visible = False
        Me.cmbbancos.Properties.Columns("Orden").Visible = False

        Me.cbPagar.DataSource = Proveedores.PagarList().Tables("Proveedores")
        Me.cbPagar.ValueMember = "Codigo"
        Me.cbPagar.DisplayMember = "Nombre"

        Dim ds As New DataSet

        'Dim Registros As Integer
        'Registros = Comprobantes.ComprobanteAnularBuscar(Me.etComprobante.Text, Me.etPeriodo.Text, Me.etFecha.Text)

        'If Registros > 0 Then
        '    'Me.dgCatalogo.ReadOnly = True
        '    'Me.txtConcepto.ReadOnly = True
        '    'Me.dtpFecha.Enabled = False
        '    'Me.cbTipoComp.Enabled = False
        '    'Me.cmdAceptar.Enabled = False
        '    'Me.cmdAceptar.Enabled = False
        '    'Me.cmdRecalcular.Enabled = False
        '    'Me.etAnulado.Visible = True
        '    ds = Comp.ChequesAnuladosList(Me.etComprobante.Text, Me.etPeriodo.Text, Me.etFecha.Text)
        'Else
        '    'Me.dgCatalogo.ReadOnly = False
        '    ds = Comp.ChequesList(0, Fecha1, Fecha2)
        'End If

        ds = Comp.ChequesList(0, Fecha1, Fecha2, 0, "")
        GridCheques.DataSource = ds.Tables("Comprobantes").DefaultView
        FormatoGrid(Me.GridView1)
        'Me.dgComprobantes.DataSource = ds.Tables("Comprobantes").DefaultView
        'r.FormatGenerico(Me.dgComprobantes, ds.Tables("Comprobantes"))
        'Me.dgComprobantes.ReadOnly = True
        r.ComboAutoComplete(Me.cbPagar)

        cmbbancos.ItemIndex = 0

        Saldo()
        Buscar()
    End Sub

    'Private Sub dgComprobantes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    MostrarComprobante()
    'End Sub

    Public Function Validar() As Boolean
        If CDate(dtpInicial.Value).ToShortDateString > CDate(dtpFinal.Value).ToShortDateString Then
            MsgBox("La Fecha Final debe ser Mayor o Igual a la Fecha Inicial")
            Return False
        End If
        Return True
    End Function

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        ShowSplash()
        '
        Buscar()
        '
        HideSplash()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub MostrarComprobante()
        If GridView1.DataRowCount - 1 < 0 Then
            MsgBox("Seleccione el cheque", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As FrmHacerCheques = FrmHacerCheques.Instance()
        f.MdiParent = Me.MdiParent
        f.NBanco = cmbbancos.GetColumnValue("Cod")
        f.NCheque = GridView1.GetFocusedRowCellValue("Número")
        f.cmdguardar.Enabled = False
        f.Show()
        f.WindowState = FormWindowState.Maximized


        'Dim f As DataGridTextBoxCombo.frmChequesEditar = f.Instance
        'f.MdiParent = Me.MdiParent
        'f.etInicio.Text = "1"
        'f.etComprobante.Text = GridView1.GetFocusedRowCellValue("Comp_No")
        'f.etFecha.Text = GridView1.GetFocusedRowCellValue("Fecha")
        'f.etPeriodo.Text = GridView1.GetFocusedRowCellValue("Per_ID")
        ''f.etPeriod.Text = Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 4)
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
        'f.etInicio.Text = "0"
        'Dim f As frmComprobantesDetalles = f.Instance
        'f.lblNoComprobante.Text = Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 0)
        'f.lblPeriodo.Text = cbPeriodos.SelectedValue
        'f.txtFecha.Text = Me.dgComprobantes.Item(Me.dgComprobantes.CurrentRowIndex, 1)
        'f.MdiParent = Me.MdiParent
        'f.Show()
    End Sub

    Private Sub cmdVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdVer.Click
        MostrarComprobante()
    End Sub

    'Public Sub Buscar()
    '    Dim Ds As New DataSet()
    '    Dim Fechas As String
    '    Dim Inicial As String
    '    Dim Final As String

    '    If dtpFecha.Enabled = True Then
    '        Fechas = CDate(dtpFecha.Value).ToShortDateString
    '    Else
    '        Fechas = ""
    '    End If

    '    If dtpInicial.Enabled = True And dtpFinal.Enabled = True Then
    '        Inicial = CDate(dtpInicial.Value).ToShortDateString
    '        Final = CDate(dtpFinal.Value).ToShortDateString
    '    Else
    '        Inicial = ""
    '        Final = ""
    '    End If

    '    If Validar() = True Then
    '        Ds = Comp.ChequesList()
    '        Me.dgComprobantes.DataSource = Ds.Tables("Comprobantes").DefaultView
    '    End If
    'End Sub

    Private Sub dtpInicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicial.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If
        Me.dtpFinal.MinDate = Me.dtpInicial.Value.Date
        Fecha1 = Me.dtpInicial.Value.Date
        Buscar()
    End Sub

    Private Sub dtpFinal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFinal.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If
        '
        Me.dtpInicial.MaxDate = Me.dtpFinal.Value.Date
        Fecha2 = Me.dtpFinal.Value.Date
        Buscar()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If GridView1.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione el cheque que desea Anular")
            Exit Sub
        End If

        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(CDate(GridView1.GetFocusedRowCellValue("Fecha")).Date) Then
            Exit Sub
        End If
        '--------------------------------------------------------------------

        Dim dt As DataTable
        Dim cont As Integer

        Dim compNo As Integer = GridView1.GetFocusedRowCellValue("Comp_No")
        Dim perID As Integer = GridView1.GetFocusedRowCellValue("Per_ID")
        Dim Mes As Integer = CDate(GridView1.GetFocusedRowCellValue("Fecha")).Month


        dt = ObtieneDatos("SELECT * FROM PagosFacturas pf WHERE pf.Comp_No1 = " & compNo & " AND pf.PerID1 = " & perID & " AND pf.Mes1 = " & Mes & " AND Empresa_ID = " & EmpresaActual)
        cont = ObtieneDatos("SELECT DISTINCT pf.Proveedor FROM PagosFacturas pf WHERE pf.Comp_No1 = " & compNo & " AND pf.PerID1 = " & perID & " AND pf.Mes1 = " & Mes & " AND Empresa_ID = " & EmpresaActual).Rows.Count

        Dim Registros As Integer
        Registros = Comp.ComprobanteAnularBuscar(compNo, perID, GridView1.GetFocusedRowCellValue("Fecha"))

        If Registros > 0 Then
            XtraMsg("El cheque ya fue anulado", MessageBoxIcon.Error)
            Exit Sub
        End If

        'Revisar si el CK esta conciliado
        Dim Conciliado As Integer = 0
        Try
            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

            Conn.AddParameter("Comp_No", SqlDbType.Int, 5, ParameterDirection.Input, compNo)
            Conn.AddParameter("Per_Id", SqlDbType.Int, 5, ParameterDirection.Input, perID)
            Conn.AddParameter("Mes", SqlDbType.Int, 5, ParameterDirection.Input, Mes)
            Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 100, ParameterDirection.Input, cmbbancos.EditValue)
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Conciliado", SqlDbType.Int, 5, ParameterDirection.Output, 0)

            Conn.EjecutarComando("JAR_ValidarChequeConciliado")

            Conciliado = Conn.GetParameter("Conciliado").Valor
        Catch ex As Exception
            Conciliado = 0
        End Try

        If Conciliado = 1 Then
            XtraMsg("El Cheque No.: " & GridView1.GetFocusedRowCellValue("Número") & " Ya se encuentra Conciliado!", MessageBoxIcon.Warning)
            Exit Sub
        End If


        If Not XtraMsg2("¿Esta seguro que desea anular el Cheque No.: " & GridView1.GetFocusedRowCellValue("Número") & " de la fecha: " & GridView1.GetFocusedRowCellValue("Fecha")) Then
            Exit Sub
        End If

        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction

        Try
            VB.SysContab.ComprobanteDB.ComprobanteAnular(compNo, perID, GridView1.GetFocusedRowCellValue("Fecha"))

            For i As Integer = 0 To dt.Rows.Count - 1
                VB.SysContab.ComprobanteDB.CancelarFactura(dt.Rows.Item(i)("Factura"), dt.Rows.Item(i)("Proveedor"), 0)
            Next

            'If cont = 1 Then    ' El cheque Paga Solo Facturas del Mismo Proveedor
            '    Comp.CancelarFactura(GridView1.GetFocusedRowCellValue("Factura"), GridView1.GetFocusedRowCellValue("Proveedor"), 0)
            'Else    ' Es Cheque de Caja Chica, Paga Facturas de Diferentes Proveedores
            '    For i As Integer = 0 To dt.Rows.Count - 1
            '        Comp.CancelarFactura(dt.Rows.Item(i)("Factura"), dt.Rows.Item(i)("Proveedor"), 0)
            '    Next
            'End If

            VB.SysContab.ComprobanteDB.PagosFacturasBorrar(compNo, Month(GridView1.GetFocusedRowCellValue("Fecha")), perID)
            'EliminaDistribucionTrans(compNo, perID, Mes)

            VB.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Buscar()
    End Sub

    Private Sub Saldo()

        'If Me.cmbbancos.SelectedValue = "0" Then
        '    Me.Label8.Visible = False
        '    Me.etBalance.Text = 0
        '    Me.etBalance.Visible = False
        '    'Me.txtCheque.Text = ""
        'Else

        Try
            'Me.Label8.Visible = True
            'Me.etBalance.Visible = True
            Me.etBalance.Text = CDbl(Comp.SaldoxCuenta(Me.cmbbancos.EditValue, VB.SysContab.PeriodosDB.Actual)).ToString(Round)
        Catch ex As Exception
            etBalance.Text = "0.00"
        End Try

        'Me.Label8.Visible = Truebm
        'Me.etBalance.Visible = True
        ''BancosDetalles = Bancos.GetDetails(Me.cbBancos.SelectedValue)
        ''
        ''dsCB = CatalogoBancos.CatalogoBancosXCuenta(Me.cbBancos.SelectedValue)
        ''Me.txtCheque.Text = CatBancos.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
        'Me.etBalance.Text = CDbl(Comp.SaldoxCuenta(Me.cmbbancos.EditValue, VB.SysContab.PeriodosDB.Actual)).ToString(Round)
        'Me.etBalance.Text = CDbl(Comprobantes.SaldoxCuenta(Me.cbBancos.SelectedValue)).ToString(Round)
        'End If
    End Sub

    Private Sub Buscar()
        'Me.dgComprobantes.DataSource = Comp.ChequesList(Me.cbBancos.SelectedValue, Fecha1, Fecha2, Me.cbPagar.SelectedValue, Me.txtCheque.Text).Tables("Comprobantes").DefaultView
        GridCheques.DataSource =
            Comp.ChequesList(
            cmbbancos.EditValue,
            Fecha1,
            Fecha2,
            0,
            txtCheque.Text) _
            .Tables("Comprobantes").DefaultView

        FormatoGrid(Me.GridView1)
    End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        If chkFecha.Checked = True Then
            Me.dtpInicial.Enabled = True
            Me.dtpFinal.Enabled = True
            Fecha1 = Me.dtpInicial.Value.Date
            Fecha2 = Me.dtpFinal.Value.Date
            Me.dtpFinal.MinDate = Me.dtpInicial.Value
        Else
            Me.dtpInicial.Enabled = False
            Me.dtpFinal.Enabled = False
            Fecha1 = ""
            Fecha2 = ""
        End If
        Buscar()
    End Sub

    Private Sub cbPagar_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPagar.SelectedValueChanged
        'If Me.etInicio.Text = "1" Then
        '    Exit Sub
        'End If
        ''Saldo()
        'Buscar()
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    'Vista previa de la página
    '    Dim PVistaPrevia As New PrintPreviewDialog()
    '    PVistaPrevia.Document = PDoc
    '    PVistaPrevia.ShowDialog()
    'End Sub

    'Private Sub PDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
    '    'Declarar una variable para el número del caracter impreso
    '    Static cCaracter As Int32
    '    Dim miLetra = New Font("Arial", 12, FontStyle.Regular) 'La Letra
    '    'Definir el area a imprimir
    '    Dim vAreaAlto, vAreaAncho, vMargenIzquiedo, vMargenDerecho As Int32
    '    'Opciones por defecto - de PageSettings
    '    'Definiendo el área de impresion
    '    With PDoc.DefaultPageSettings()
    '        'Altura del papel menos márgenes
    '        vAreaAlto = .PaperSize.Height - .Margins.Top - .Margins.Bottom
    '        'Ancho del papel menos márgenes
    '        vAreaAncho = .PaperSize.Width - .Margins.Left - .Margins.Right
    '        'Márgenes
    '        vMargenDerecho = .Margins.Right
    '        vMargenIzquiedo = .Margins.Left
    '    End With

    '    'si la impresion es Horizontal cambiar ancho por alto
    '    If PDoc.DefaultPageSettings.Landscape Then
    '        Dim vCambio As Int32
    '        vCambio = vAreaAlto
    '        vAreaAlto = vAreaAncho
    '        vAreaAncho = vCambio
    '    End If

    '    'Calcular el número de lineas
    '    Dim vNLineas As Int32 = CInt(vAreaAlto / miLetra.Height)

    '    'Si es una boleta o factura u otro documento en papel pre-impreso
    '    'solamente se podría realizar esta parte
    '    'LA PARTE DEL ENCABEZADO Y LA DEL CLIENTE
    '    e.Graphics.DrawString("Me.txtNombre.Text", miLetra, Brushes.Black, 130, 50)
    '    e.Graphics.DrawString("Me.txtDire.Text", miLetra, Brushes.Black, 130, 70)
    '    e.Graphics.DrawString("Me.txtEmail.Text", miLetra, Brushes.Black, 130, 90)
    '    e.Graphics.DrawString("Me.txtWeb.Text", miLetra, Brushes.Black, 130, 120)
    '    e.Graphics.DrawString("Me.txtRuc.Text", miLetra, Brushes.Black, 530, 50)
    '    e.Graphics.DrawString("Me.cboProfesion.Text", miLetra, Brushes.Black, 530, 120)

    '    'PARA EL DETALLE
    '    Dim i As Integer
    '    Dim MiLetraDetalle As New Font("Arial", 9, FontStyle.Regular)
    '    Dim comienzo As Int32 = 220

    '    For i = 0 To 10 'lvProductos.Items.Count - 1
    '        e.Graphics.DrawString(" Linea " & i, MiLetraDetalle, Brushes.Black, 130, comienzo)
    '        e.Graphics.DrawString(" Linea 1 " & i, MiLetraDetalle, Brushes.Black, 130 + i * 10, comienzo)
    '    Next
    'End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If GridView1.DataRowCount - 1 < 0 Then
            XtraMsg("Seleccione el cheque")
            Exit Sub
        End If

        ImprimeCheque(False)

        'If GridView1.DataRowCount - 1 < 0 Then
        '    MsgBox("Seleccione el cheque", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        'Cheques = vbNullString
        'Dim Temp As Boolean = False
        'Dim Cont As Integer = 0
        'For i As Integer = 0 To GridView1.DataRowCount - 1
        '    If GridView1.GetRowCellValue(i, "Imprimir") = True Then
        '        Cont += 1
        '    End If
        'Next
        'For i As Integer = 0 To GridView1.DataRowCount - 1
        '    If GridView1.GetRowCellValue(i, "Imprimir") = True Then
        '        If Cont > 1 Then
        '            Cheques += IIf(Cheques = vbNullString, "", ",") & "'" & GridView1.GetRowCellValue(i, "Número") & "'"
        '        Else
        '            Cheques = GridView1.GetRowCellValue(i, "Número")
        '        End If

        '        Temp = True
        '    End If
        'Next

        'If Not Temp Then
        '    MsgBox("Marque los cheques a imprimir", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        'If Cont > 1 Then Cheques = Cheques Else Cheques = "'" & Cheques & "'"

        'ImprimeCheque(IIf(sender.name = "cmdImprimirComp", True, False))
    End Sub

    Function GetFacturas(ByVal NoCheque As String)

        'Dim Facturas As String() = Factura.Split(New Char() {"|"})
        'Dim s As String

        'For Each s In Facturas

        '    Dim cmd As New SqlCommand("_FacturasComprasCancelar", DBConnFacturas)

        '    ' Mark the Command as a SPROC
        '    cmd.CommandType = CommandType.StoredProcedure

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    cmd.Parameters.Add(pEmpresa)

        '    Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
        '    _Factura.Value = Trim(s)
        '    cmd.Parameters.Add(_Factura)

        '    Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar, 50)
        '    _Proveedor.Value = Proveedor
        '    cmd.Parameters.Add(_Proveedor)

        '    Dim _Estado As New SqlParameter("@Estado", SqlDbType.Int)
        '    _Estado.Value = Estado
        '    cmd.Parameters.Add(_Estado)

        '    cmd.Connection = DBConnFacturas
        '    cmd.Transaction = transaccionFacturas
        '    cmd.ExecuteNonQuery()
        'Next
    End Function

    Private Sub ImprimeCheque(Optional ByVal Directo As Boolean = False)

        Dim Cadena As String
        Dim Data() As Byte
        Dim Cod As Integer = ObtieneDatos("SPGetCodigoBanco " & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Per_ID") & "," & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Comp_No") & "," & EmpresaActual & "," & CDate(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Fecha")).Month).Rows(0).Item(0)
        Dim TMoneda As String = ""

        If Cod = 0 Then
            XtraMsg("No hay configurado ningun cheque para esta cuenta", MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            'Dim Datas() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod & " AND EMPRESA = " & EmpresaActual).Rows(0).Item(0), Byte())
            TMoneda = ObtieneDatos("SELECT cb.MONEDA FROM CATALOGO_BANCOS cb WHERE cb.CODIGO = " & Cod & " AND cb.EMPRESA = " & EmpresaActual).Rows.Item(0)("MONEDA")

        Catch ex As Exception
            XtraMsg("No hay formato de cheque definido", MessageBoxIcon.Warning)
            Exit Sub
        End Try

        Dim ValorLetras As String = r.Letras(CDbl(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Monto")), GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Moneda")) 'VB.SysContab.Rutinas.ConversionDecimales( CDbl(lblDebito.Text).ToString(Round))

        'Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
        Dim Tamano As Integer
        Tamano = Data.GetUpperBound(0)
        Cadena = Application.StartupPath & "\RptCheque.repx"

        If File.Exists(Cadena) Then Kill(Cadena)
        Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        Archivo.Write(Data, 0, Tamano)
        Archivo.Close()

        Dim Rep As XtraReport = XtraReport.FromFile(Application.StartupPath & "\RptCheque.repx", True)
        Rep.DataSource = GetChequeDb(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Per_ID"),
                                     GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Comp_No"),
                                     GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Fecha"),
                                     ValorLetras)
        If Directo Then
            Rep.PrintDialog()
        Else
            Rep.ShowPrintMarginsWarning = False
            Rep.BringToFront()
            Rep.ShowRibbonPreview()
        End If

        'Dim ValorLetras As String = r.Letras(CDbl(GridView1.GetFocusedRowCellValue("Monto")))  'VB.SysContab.Rutinas.ConversionDecimales( CDbl(lblDebito.Text).ToString(Round))
        'Dim Cadena As String
        'Dim Data() As Byte
        'Dim Cod As Integer = ObtieneDatos("SPGetCodigoBanco " & GridView1.GetFocusedRowCellValue("Per_ID") & "," & GridView1.GetFocusedRowCellValue("Comp_No") & "," & EmpresaActual & "," & CDate(GridView1.GetFocusedRowCellValue("Fecha")).Month).Rows(0).Item(0)
        'If Cod = 0 Then
        '    MsgBox("No hay configurado ningun cheque para esta cuenta", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        'Try
        '    'Dim Datas() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
        '    Data = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
        'Catch ex As Exception
        '    MsgBox("No hay formato de cheque definido", MsgBoxStyle.Critical)
        '    Exit Sub
        'End Try
        ''Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
        'Dim Tamano As Integer
        'Tamano = Data.GetUpperBound(0)
        'Cadena = Application.StartupPath & "\RptCheque.repx"
        'If File.Exists(Cadena) Then Kill(Cadena)
        'Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        'Archivo.Write(Data, 0, Tamano)
        'Archivo.Close()

        'Dim Rep As XtraReport
        'Try
        '    Rep = XtraReport.FromFile(Application.StartupPath & "\RptCheque.repx", True)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


        'Dim Datos As New ArrayList
        'Dim Variables As New ArrayList

        'Variables.Add("Cheque")
        'Variables.Add("Empresa")
        'Variables.Add("Banco")

        'Datos.Add(Cheques)
        'Datos.Add(CInt(EmpresaActual))
        'Datos.Add(CInt(cmbbancos.GetColumnValue("Cod")))
        ''Datos.Add(IIf(cbBancos.SelectedIndex <= 0, CInt(GridView1.GetFocusedRowCellValue("Banco")), CInt(cbBancos.SelectedValue)))

        'Rep.DataSource = ProcedureParameters(Datos, Variables, "SP_GetCheques")
        ''Rep.DataSource = GetChequeDb(GridView1.GetFocusedRowCellValue("Per_ID"), GridView1.GetFocusedRowCellValue("Comp_No"), GridView1.GetFocusedRowCellValue("Fecha"), "")
        'If Directo Then Rep.PrintDialog() Else Rep.ShowRibbonPreview()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/BancosLista.chm")
    End Sub

    Private Sub GridCheques_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCheques.DoubleClick
        MostrarComprobante()
    End Sub

    Private Sub GridView1_HideCustomizationForm(sender As Object, e As EventArgs) Handles GridView1.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

    Private Sub GridView1_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridView1.ShowingEditor
        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Anulado") = True Then e.Cancel = True
    End Sub

    Private Sub cmdretenciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdretenciones.Click, cmdimprretencion.Click
        If GridView1.DataRowCount - 1 < 0 Then
            MsgBox("Seleccione el cheque", MsgBoxStyle.Information)
            Exit Sub
        End If

        Cheques = vbNullString

        Dim Temp As Boolean = False
        Dim Cont As Integer = 0

        Dim tRet As New DataTable

        Dim da As New SqlDataAdapter("SP_GetRetenciones", r.AbrirConexion)
        da.SelectCommand.CommandType = CommandType.StoredProcedure

        da.SelectCommand.Parameters.Add("@Cheque", SqlDbType.NVarChar)
        da.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int)
        da.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int)
        da.SelectCommand.Parameters.Add("@Factura", SqlDbType.NVarChar)

        da.SelectCommand.Parameters("@Empresa").Value = CInt(EmpresaActual)
        da.SelectCommand.Parameters("@Banco").Value = CInt(cmbbancos.GetColumnValue("Cod"))


        'For i As Integer = 0 To GridView1.DataRowCount - 1
        'If GridView1.GetRowCellValue(i, "Imprimir") = True Then
        da.SelectCommand.Parameters("@Cheque").Value = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Número")
        da.SelectCommand.Parameters("@Factura").Value = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Factura")

        da.Fill(tRet)
        'If Cont > 1 Then
        '    Cheques += IIf(Cheques = vbNullString, "", ",") & "'" & GridView1.GetRowCellValue(i, "Número") & "'"
        'Else
        '    Cheques = GridView1.GetRowCellValue(i, "Número")
        'End If
        'Temp = True
        'End If
        'Next
        'If Not Temp Then
        '    MsgBox("Marque los cheques a imprimir", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Cont > 1 Then Cheques = Cheques Else Cheques = "'" & Cheques & "'"

        ImprimeRetencion(tRet, IIf(sender.name = "cmdimprretencion", True, False))
    End Sub

    Private Sub ImprimeRetencion(ByVal tRet As DataTable, Optional ByVal Directo As Boolean = False)
        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte
        Try
            'Dim Datas() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 5 AND Empresa =" & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True

            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\RptRetencion.repx"

            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

        Catch ex As Exception
            Temp = False
            'Exit Sub
        End Try
        'Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
        Dim Rep As XtraReport
        If Temp = True Then
            Rep = XtraReport.FromFile(Application.StartupPath & "\RptRetencion.repx", True)
        Else
            Rep = New RptRetencion
        End If

        'Dim Datos As New ArrayList
        'Dim Variables As New ArrayList

        'Variables.Add("Cheque")
        'Variables.Add("Empresa")
        'Variables.Add("Banco")

        'Datos.Add(Cheques)
        'Datos.Add(CInt(EmpresaActual))
        'Datos.Add(CInt(cmbbancos.GetColumnValue("Cod")))
        'Datos.Add(IIf(cbBancos.SelectedIndex <= 0, CInt(GridView1.GetFocusedRowCellValue("Banco")), CInt(cbBancos.SelectedValue)))

        Rep.DataSource = tRet  'ProcedureParameters(Datos, Variables, "SP_GetRetenciones")
        'Rep.DataSource = GetChequeDb(GridView1.GetFocusedRowCellValue("Per_ID"), GridView1.GetFocusedRowCellValue("Comp_No"), GridView1.GetFocusedRowCellValue("Fecha"), "")
        If Directo Then
            Rep.PrintDialog()
        Else
            Rep.ShowPrintMarginsWarning = False
            Rep.BringToFront()
            Rep.ShowRibbonPreview()
        End If

    End Sub

    Private Sub cmbbancos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbancos.EditValueChanged
        If Me.etInicio.Text = "1" Then Exit Sub

        ShowSplash()
        '
        Saldo()
        Buscar()
        '
        HideSplash()
    End Sub

    Private Sub cmdconfret_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdconfret.Click
        Dim Forma As New FrmConfiguraCheque
        Forma.Tipo = 5
        Forma.Text = "Formato Retenciones"
        Forma.ShowDialog()
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'Actualizar Nombre del Beneficiario
        If e.Column.FieldName = "Pagar A" Then
            GuardaDatos("UPDATE Comprobantes SET ChequeNombre = '" & Me.GridView1.GetRowCellValue(e.RowHandle, "Pagar A") & "'" _
                        + " WHERE Comp_No = '" & Me.GridView1.GetRowCellValue(e.RowHandle, "Comp_No") & "' AND" _
                        + " Per_Id = '" & Me.GridView1.GetRowCellValue(e.RowHandle, "Per_ID") & "' AND" _
                        + " Mes = '" & CDate(Me.GridView1.GetRowCellValue(e.RowHandle, "Fecha")).Month & "' AND Empresa = " & EmpresaActual)
        End If
        '        
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        My.Forms.frmExportarImprimir.Mostrar(GridCheques)
    End Sub

    Private Sub bBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBorrar.Click
        If GridView1.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione el cheque que desea Borrar")
            Exit Sub
        End If
        '

        Dim compNo As Integer = GridView1.GetFocusedRowCellValue("Comp_No")
        Dim perID As Integer = GridView1.GetFocusedRowCellValue("Per_ID")
        Dim Mes As Integer = CDate(GridView1.GetFocusedRowCellValue("Fecha")).Month
        Dim Registros As Integer = Comp.ComprobanteAnularBuscar(compNo, perID, GridView1.GetFocusedRowCellValue("Fecha"))

        If Registros = 0 Then
            XtraMsg("Debe Anular el Cheque primero...", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not XtraMsg2("¿Esta seguro que desea Borrar el Cheque No.: " & GridView1.GetFocusedRowCellValue("Número") & " de la fecha: " & GridView1.GetFocusedRowCellValue("Fecha")) Then
            Exit Sub
        End If
        '
        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()

        Try
            Conn.AddParameter("ComprNO", SqlDbType.Int, 5, ParameterDirection.Input, compNo)
            Conn.AddParameter("PerID", SqlDbType.Int, 5, ParameterDirection.Input, perID)
            Conn.AddParameter("Mes", SqlDbType.Int, 5, ParameterDirection.Input, Mes)
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.EjecutarComando("JAR_BorrarCheque")
            '
            Conn.CompletarTransaccion()
            '
            Buscar()
        Catch ex As Exception
            XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)
            Conn.AnularTransaccion()
        End Try
    End Sub

    Private Sub bAnularProcesado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAnularProcesado.Click
        If GridView1.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione el cheque que desea Anular")
            Exit Sub
        End If

        Dim dt As DataTable
        Dim cont As Integer

        Dim compNo As Integer = GridView1.GetFocusedRowCellValue("Comp_No")
        Dim perID As Integer = GridView1.GetFocusedRowCellValue("Per_ID")
        Dim Fecha As Date = CDate(GridView1.GetFocusedRowCellValue("Fecha")).Date

        'dt = ObtieneDatos("SELECT * FROM PagosFacturas pf WHERE pf.Comp_No1= " & compNo & " AND pf.PerID1 = " & perID & " AND pf.Mes1 = " & Mes & " AND Empresa_ID = " & EmpresaActual)
        'cont = ObtieneDatos("SELECT DISTINCT pf.Proveedor FROM PagosFacturas pf WHERE pf.Comp_No1 = " & compNo & " AND pf.PerID1 = " & perID & " AND pf.Mes1 = " & Mes & " AND Empresa_ID = " & EmpresaActual).Rows.Count

        Dim Registros As Integer
        Registros = Comp.ComprobanteAnularBuscar(compNo, perID, GridView1.GetFocusedRowCellValue("Fecha"))

        If Registros > 0 Then
            MsgBox("El cheque ya fue anulado", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Not XtraMsg2("¿Esta seguro que desea anular el Cheque No.: " & GridView1.GetFocusedRowCellValue("Número") & " de la fecha: " & GridView1.GetFocusedRowCellValue("Fecha")) Then
            Exit Sub
        End If

        With frmAnularChequeProcesado
            .txtNoCheque.Text = GridView1.GetFocusedRowCellValue("Número")
            .txtBanco.Text = cmbbancos.Text
            .txtNombre.Text = GridView1.GetFocusedRowCellValue("Pagar A")
            .txtMonto.EditValue = GridView1.GetFocusedRowCellValue("Monto")
            .txtMoneda.Text = GridView1.GetFocusedRowCellValue("Moneda")
            .NoCheque = GridView1.GetFocusedRowCellValue("Número")
            .CodBanco = cmbbancos.GetColumnValue("Cod")
            .NoCompr = compNo
            .Per_Id = perID
            .Fecha = Fecha
            .ShowDialog()
            If .Ok = "SI" Then Buscar()
            .Dispose()
            'Buscar()
        End With

        'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        'DBConnFacturas.Open()
        'transaccionFacturas = DBConnFacturas.BeginTransaction

        'Try
        '    Comp.ComprobanteAnular(compNo, perID, GridView1.GetFocusedRowCellValue("Fecha"))

        '    For i As Integer = 0 To dt.Rows.Count - 1
        '        Comp.CancelarFactura(dt.Rows.Item(i)("Factura"), dt.Rows.Item(i)("Proveedor"), 0)
        '    Next

        '    'If cont = 1 Then    ' El cheque Paga Solo Facturas del Mismo Proveedor
        '    '    Comp.CancelarFactura(GridView1.GetFocusedRowCellValue("Factura"), GridView1.GetFocusedRowCellValue("Proveedor"), 0)
        '    'Else    ' Es Cheque de Caja Chica, Paga Facturas de Diferentes Proveedores
        '    '    For i As Integer = 0 To dt.Rows.Count - 1
        '    '        Comp.CancelarFactura(dt.Rows.Item(i)("Factura"), dt.Rows.Item(i)("Proveedor"), 0)
        '    '    Next
        '    'End If

        '    Comp.PagosFacturasBorrar(compNo, Month(GridView1.GetFocusedRowCellValue("Fecha")), perID)
        '    EliminaDistribucion(compNo, perID, Mes)

        '    VB.SysContab.Rutinas.okTransaccion()
        'Catch ex As Exception
        '    VB.SysContab.Rutinas.ErrorTransaccion()
        '    MsgBox(ex.Message, MsgBoxStyle.Information)
        '    Exit Sub
        'End Try
        'Buscar()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then GridView1.ShowCustomization()
        If Not CheckEdit1.Checked Then GridView1.DestroyCustomization()
    End Sub

    Private Sub cbPagar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPagar.SelectedIndexChanged

    End Sub
End Class













