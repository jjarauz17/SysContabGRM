Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace DataGridTextBoxCombo
    Public Class frmDevolucionClienteVer
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmDevolucionClienteVer = Nothing

        Public Shared Function Instance() As frmDevolucionClienteVer
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmDevolucionClienteVer()
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
        Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents txtCliente As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
        Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txtDevolucion As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
        Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents etTotal As DevExpress.XtraEditors.TextEdit
        Friend WithEvents etIva As DevExpress.XtraEditors.TextEdit
        Friend WithEvents etSubTotal As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents rDescuento As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolucionClienteVer))
            Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
            Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
            Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.etTotal = New DevExpress.XtraEditors.TextEdit()
            Me.etIva = New DevExpress.XtraEditors.TextEdit()
            Me.etSubTotal = New DevExpress.XtraEditors.TextEdit()
            Me.iGrid = New DevExpress.XtraGrid.GridControl()
            Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.rDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
            Me.txtFactura = New DevExpress.XtraEditors.TextEdit()
            Me.txtDevolucion = New DevExpress.XtraEditors.TextEdit()
            Me.txtCliente = New DevExpress.XtraEditors.TextEdit()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl2.SuspendLayout()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl1.SuspendLayout()
            CType(Me.etTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.etIva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.etSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtDevolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.SuspendLayout()
            '
            'cmdImprimir
            '
            Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdImprimir.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdImprimir.Appearance.Options.UseFont = True
            Me.cmdImprimir.Appearance.Options.UseForeColor = True
            Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
            Me.cmdImprimir.Location = New System.Drawing.Point(12, 12)
            Me.cmdImprimir.Name = "cmdImprimir"
            Me.cmdImprimir.Size = New System.Drawing.Size(109, 36)
            Me.cmdImprimir.StyleController = Me.LayoutControl2
            Me.cmdImprimir.TabIndex = 30
            Me.cmdImprimir.Text = "&Imprimir"
            Me.cmdImprimir.Visible = False
            '
            'LayoutControl2
            '
            Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
            Me.LayoutControl2.Controls.Add(Me.cmdImprimir)
            Me.LayoutControl2.Controls.Add(Me.cmdCancelar)
            Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl2.Name = "LayoutControl2"
            Me.LayoutControl2.Root = Me.LayoutControlGroup2
            Me.LayoutControl2.Size = New System.Drawing.Size(133, 410)
            Me.LayoutControl2.TabIndex = 0
            Me.LayoutControl2.Text = "LayoutControl2"
            '
            'SimpleButton1
            '
            Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
            Me.SimpleButton1.Appearance.Options.UseFont = True
            Me.SimpleButton1.Appearance.Options.UseForeColor = True
            Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
            Me.SimpleButton1.Location = New System.Drawing.Point(12, 52)
            Me.SimpleButton1.Name = "SimpleButton1"
            Me.SimpleButton1.Size = New System.Drawing.Size(109, 36)
            Me.SimpleButton1.StyleController = Me.LayoutControl2
            Me.SimpleButton1.TabIndex = 160
            Me.SimpleButton1.Text = "E&xportar"
            Me.SimpleButton1.Visible = False
            '
            'cmdCancelar
            '
            Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar.Appearance.Options.UseFont = True
            Me.cmdCancelar.Appearance.Options.UseForeColor = True
            Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
            Me.cmdCancelar.Location = New System.Drawing.Point(12, 92)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(109, 36)
            Me.cmdCancelar.StyleController = Me.LayoutControl2
            Me.cmdCancelar.TabIndex = 29
            Me.cmdCancelar.Text = "&Salir"
            '
            'LayoutControlGroup2
            '
            Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup2.GroupBordersVisible = False
            Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem9, Me.LayoutControlItem11})
            Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
            Me.LayoutControlGroup2.Size = New System.Drawing.Size(133, 410)
            Me.LayoutControlGroup2.TextVisible = False
            '
            'LayoutControlItem10
            '
            Me.LayoutControlItem10.Control = Me.cmdCancelar
            Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 80)
            Me.LayoutControlItem10.Name = "LayoutControlItem10"
            Me.LayoutControlItem10.Size = New System.Drawing.Size(113, 310)
            Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem10.TextVisible = False
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.cmdImprimir
            Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(113, 40)
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem9.TextVisible = False
            '
            'LayoutControlItem11
            '
            Me.LayoutControlItem11.Control = Me.SimpleButton1
            Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 40)
            Me.LayoutControlItem11.Name = "LayoutControlItem11"
            Me.LayoutControlItem11.Size = New System.Drawing.Size(113, 40)
            Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem11.TextVisible = False
            '
            'LayoutControl1
            '
            Me.LayoutControl1.Controls.Add(Me.etTotal)
            Me.LayoutControl1.Controls.Add(Me.etIva)
            Me.LayoutControl1.Controls.Add(Me.etSubTotal)
            Me.LayoutControl1.Controls.Add(Me.iGrid)
            Me.LayoutControl1.Controls.Add(Me.dtpFecha)
            Me.LayoutControl1.Controls.Add(Me.txtFactura)
            Me.LayoutControl1.Controls.Add(Me.txtDevolucion)
            Me.LayoutControl1.Controls.Add(Me.txtCliente)
            Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl1.Name = "LayoutControl1"
            Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(566, 241, 250, 350)
            Me.LayoutControl1.Root = Me.LayoutControlGroup1
            Me.LayoutControl1.Size = New System.Drawing.Size(868, 439)
            Me.LayoutControl1.TabIndex = 158
            Me.LayoutControl1.Text = "LayoutControl1"
            '
            'etTotal
            '
            Me.etTotal.Location = New System.Drawing.Point(684, 405)
            Me.etTotal.Name = "etTotal"
            Me.etTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etTotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.etTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.etTotal.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.etTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.etTotal.Properties.AppearanceReadOnly.Options.UseTextOptions = True
            Me.etTotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.etTotal.Properties.Mask.EditMask = "n2"
            Me.etTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.etTotal.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.etTotal.Properties.ReadOnly = True
            Me.etTotal.Size = New System.Drawing.Size(172, 22)
            Me.etTotal.StyleController = Me.LayoutControl1
            Me.etTotal.TabIndex = 163
            '
            'etIva
            '
            Me.etIva.Location = New System.Drawing.Point(451, 405)
            Me.etIva.Name = "etIva"
            Me.etIva.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etIva.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etIva.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.etIva.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.etIva.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.etIva.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.etIva.Properties.AppearanceReadOnly.Options.UseTextOptions = True
            Me.etIva.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.etIva.Properties.Mask.EditMask = "n2"
            Me.etIva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.etIva.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.etIva.Properties.ReadOnly = True
            Me.etIva.Size = New System.Drawing.Size(150, 22)
            Me.etIva.StyleController = Me.LayoutControl1
            Me.etIva.TabIndex = 163
            '
            'etSubTotal
            '
            Me.etSubTotal.Location = New System.Drawing.Point(223, 405)
            Me.etSubTotal.Name = "etSubTotal"
            Me.etSubTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.etSubTotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etSubTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.etSubTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.etSubTotal.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.etSubTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.etSubTotal.Properties.AppearanceReadOnly.Options.UseTextOptions = True
            Me.etSubTotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.etSubTotal.Properties.Mask.EditMask = "n2"
            Me.etSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.etSubTotal.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.etSubTotal.Properties.ReadOnly = True
            Me.etSubTotal.Size = New System.Drawing.Size(145, 22)
            Me.etSubTotal.StyleController = Me.LayoutControl1
            Me.etSubTotal.TabIndex = 162
            '
            'iGrid
            '
            Me.iGrid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.iGrid.Location = New System.Drawing.Point(12, 64)
            Me.iGrid.MainView = Me.iVista
            Me.iGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.iGrid.Name = "iGrid"
            Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rDescuento})
            Me.iGrid.Size = New System.Drawing.Size(844, 337)
            Me.iGrid.TabIndex = 159
            Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
            '
            'iVista
            '
            Me.iVista.GridControl = Me.iGrid
            Me.iVista.Name = "iVista"
            Me.iVista.OptionsBehavior.Editable = False
            Me.iVista.OptionsView.ShowAutoFilterRow = True
            Me.iVista.OptionsView.ShowFooter = True
            Me.iVista.OptionsView.ShowGroupPanel = False
            '
            'rDescuento
            '
            Me.rDescuento.AutoHeight = False
            Me.rDescuento.Mask.EditMask = "P2"
            Me.rDescuento.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.rDescuento.Mask.UseMaskAsDisplayFormat = True
            Me.rDescuento.Name = "rDescuento"
            '
            'dtpFecha
            '
            Me.dtpFecha.EditValue = Nothing
            Me.dtpFecha.Location = New System.Drawing.Point(733, 12)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dtpFecha.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.dtpFecha.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.dtpFecha.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.dtpFecha.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dtpFecha.Properties.ReadOnly = True
            Me.dtpFecha.Size = New System.Drawing.Size(123, 20)
            Me.dtpFecha.StyleController = Me.LayoutControl1
            Me.dtpFecha.TabIndex = 161
            '
            'txtFactura
            '
            Me.txtFactura.Location = New System.Drawing.Point(339, 38)
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.txtFactura.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtFactura.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtFactura.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.txtFactura.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.txtFactura.Properties.ReadOnly = True
            Me.txtFactura.Size = New System.Drawing.Size(219, 22)
            Me.txtFactura.StyleController = Me.LayoutControl1
            Me.txtFactura.TabIndex = 160
            '
            'txtDevolucion
            '
            Me.txtDevolucion.Location = New System.Drawing.Point(91, 38)
            Me.txtDevolucion.Name = "txtDevolucion"
            Me.txtDevolucion.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.txtDevolucion.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDevolucion.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtDevolucion.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtDevolucion.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.txtDevolucion.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.txtDevolucion.Properties.ReadOnly = True
            Me.txtDevolucion.Size = New System.Drawing.Size(165, 22)
            Me.txtDevolucion.StyleController = Me.LayoutControl1
            Me.txtDevolucion.TabIndex = 159
            '
            'txtCliente
            '
            Me.txtCliente.Location = New System.Drawing.Point(91, 12)
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.txtCliente.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtCliente.Properties.AppearanceReadOnly.Options.UseBackColor = True
            Me.txtCliente.Properties.AppearanceReadOnly.Options.UseFont = True
            Me.txtCliente.Properties.AppearanceReadOnly.Options.UseForeColor = True
            Me.txtCliente.Properties.ReadOnly = True
            Me.txtCliente.Size = New System.Drawing.Size(559, 22)
            Me.txtCliente.StyleController = Me.LayoutControl1
            Me.txtCliente.TabIndex = 4
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.EmptySpaceItem2})
            Me.LayoutControlGroup1.Name = "Root"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(868, 439)
            Me.LayoutControlGroup1.TextVisible = False
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.txtDevolucion
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
            Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(248, 26)
            Me.LayoutControlItem2.MinSize = New System.Drawing.Size(248, 26)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(248, 26)
            Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem2.Text = "No. Devolución:"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(76, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.txtFactura
            Me.LayoutControlItem3.Location = New System.Drawing.Point(248, 26)
            Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(302, 26)
            Me.LayoutControlItem3.MinSize = New System.Drawing.Size(302, 26)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(302, 26)
            Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem3.Text = "No. Factura:"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(76, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.iGrid
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 52)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(848, 341)
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem5.TextVisible = False
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem6.Control = Me.etSubTotal
            Me.LayoutControlItem6.Location = New System.Drawing.Point(132, 393)
            Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(228, 26)
            Me.LayoutControlItem6.MinSize = New System.Drawing.Size(228, 26)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(228, 26)
            Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem6.Text = "Sub Total:"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(76, 14)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem7.Control = Me.etIva
            Me.LayoutControlItem7.Location = New System.Drawing.Point(360, 393)
            Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(233, 26)
            Me.LayoutControlItem7.MinSize = New System.Drawing.Size(233, 26)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(233, 26)
            Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem7.Text = "IVA:"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(76, 14)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LayoutControlItem8.AppearanceItemCaption.Options.UseFont = True
            Me.LayoutControlItem8.Control = Me.etTotal
            Me.LayoutControlItem8.Location = New System.Drawing.Point(593, 393)
            Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(255, 26)
            Me.LayoutControlItem8.MinSize = New System.Drawing.Size(255, 26)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(255, 26)
            Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem8.Text = "Total:"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(76, 14)
            '
            'EmptySpaceItem1
            '
            Me.EmptySpaceItem1.AllowHotTrack = False
            Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 393)
            Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
            Me.EmptySpaceItem1.Size = New System.Drawing.Size(132, 26)
            Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.txtCliente
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(642, 26)
            Me.LayoutControlItem1.Text = "Cliente:"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(76, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.dtpFecha
            Me.LayoutControlItem4.Location = New System.Drawing.Point(642, 0)
            Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(206, 26)
            Me.LayoutControlItem4.MinSize = New System.Drawing.Size(206, 26)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(206, 26)
            Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem4.Text = "Fecha:"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(76, 13)
            '
            'EmptySpaceItem2
            '
            Me.EmptySpaceItem2.AllowHotTrack = False
            Me.EmptySpaceItem2.Location = New System.Drawing.Point(550, 26)
            Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
            Me.EmptySpaceItem2.Size = New System.Drawing.Size(298, 26)
            Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
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
            Me.DockPanel1.ID = New System.Guid("5be2005e-12df-4416-96fc-13fe58d8a554")
            Me.DockPanel1.Location = New System.Drawing.Point(868, 0)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.Options.ShowCloseButton = False
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
            Me.DockPanel1.Size = New System.Drawing.Size(140, 439)
            Me.DockPanel1.Text = "Opciones"
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(133, 410)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'frmDevolucionClienteVer
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(1008, 439)
            Me.Controls.Add(Me.LayoutControl1)
            Me.Controls.Add(Me.DockPanel1)
            Me.Name = "frmDevolucionClienteVer"
            CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl2.ResumeLayout(False)
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl1.ResumeLayout(False)
            CType(Me.etTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.etIva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.etSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rDescuento, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtDevolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Dim Clientes As New VB.SysContab.ClientesDB()
        Dim FormaPago As New VB.SysContab.Forma_PagoDB()
        Dim Devolucion As New VB.SysContab.DevolucionesClienteDB()
        Dim r As New VB.SysContab.Rutinas()

        Dim ds As DataSet

        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet

        Dim Cantidad As DataGridTextBoxColumn
        Dim ValorActualCantidad As Double

        Dim i As Integer

        Dim SubTotalFacturaClienteV As Double
        Dim SubTotalFacturaNoDescuentosV As Double
        Dim TotalFacturaClienteV As Double
        Dim TotalDescuentoV As Double
        Dim Totaliva As Double

        Private myCheckBoxCol As Integer = 8 'my checkbox column 
        Dim Config As New VB.SysContab.ConfiguracionDB()
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()

        Public Comp_No As Integer = 0, Per_Id As Integer = 0

        Private Sub frmFacturacionClienteVer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ''r.CambiarEstilo(Me)
            'r.FormularioColor(Me)

            'cbCliente.DataSource = Clientes.ClientesList().Tables("Clientes")
            'cbCliente.ValueMember = "Codigo"
            'cbCliente.DisplayMember = "Nombre"

            'ConfigDetalles = Config.GetConfigDetails
            'ds = Devolucion.DevolucionDetalle(Me.txtDevolucion.Text) 'Clientes.FacturaDetalleDevolucion(txtFactura.Text)

            'dgFacturacionCliente.ReadOnly = True

            'cbCliente.Enabled = False

            'If ds.Tables("Facturas_Ventas").Rows(0).Item("Cliente") = "9999" Then
            '    txtCliente.Text = ds.Tables("Facturas_Ventas").Rows(0).Item("Nombre_Cliente").ToString
            '    txtCliente.Visible = True
            'Else
            '    txtCliente.Visible = False
            '    cbCliente.SelectedValue = ds.Tables("Facturas_Ventas").Rows(0).Item("Cliente")
            'End If

            'dtpFecha.Value = ds.Tables("Facturas_Ventas").Rows(0).Item("Fecha")
            'dtpFecha.Enabled = False

            'txtFactura.Text = ds.Tables("Facturas_Ventas").Rows(0).Item("Factura")
            'txtFactura.ReadOnly = True

            ''txtDevolucion.Text = ds.Tables("Facturas_Ventas").Rows(0).Item("Devolucion")
            'txtDevolucion.ReadOnly = True

            'MakeDataSet()
            'dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            'AddCustomDataTableStyle()
            '
            'SubTotalFacturaClienteV = 0
            'SubTotalFacturaNoDescuentosV = 0
            'TotalFacturaClienteV = 0
            'TotalDescuentoV = 0

            'For i = 0 To tCust.Rows.Count - 1
            '    If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then
            '        '
            '    ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
            '        Try
            '            SubTotalFacturaClienteV = SubTotalFacturaClienteV + tCust.Rows(i)("SubTotal")
            '            SubTotalFacturaNoDescuentosV = SubTotalFacturaNoDescuentosV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
            '            TotalDescuentoV = TotalDescuentoV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)
            '            Totaliva = Totaliva + tCust.Rows(i)("Iva")
            '        Catch ex As Exception
            '            MsgBox(ex.Message)

            '        End Try
            '    End If
            'Next

            'etSubTotal.Visible = False
            'etIva.Visible = False
            'etSaldo.Visible = False
            'etSaldoT.Visible = False

            'etSubTotal.Text = SubTotalFacturaClienteV.ToString(Round)
            'etIva.Text = Totaliva.ToString(Round) '(SubTotalFacturaClienteV * (ConfigDetalles.IVA / 100.0)).ToString(Round)
            'etTotal.Text = (SubTotalFacturaClienteV + CDbl(etIva.Text)).ToString(Round)

            'etSaldo.Text = CDbl(ds.Tables("Facturas_Ventas").Rows(0).Item("Saldo")).ToString(Round)
            'etSaldo.Refresh()
            'Me.Text = "Devolución"

            Cargar()
        End Sub

        Sub Cargar()
            iGrid.DataSource = ObtieneDatos("JAR_DevolucionClienteDetalle",
                                            txtDevolucion.Text,
                                            EmpresaActual)
            iVista.PopulateColumns()
            FormatoGrid(iVista, 2, 0, False, False, False)

            iVista.Columns("Tipo").Visible = False
            iVista.Columns("IVA").Visible = False
            iVista.Columns("Descuento").ColumnEdit = rDescuento
            iVista.Columns("Cantidad").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None
            iVista.Columns("Precio").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None
            iVista.Columns("Descuento").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None

            etSubTotal.EditValue = CDbl(iVista.Columns("SubTotal").SummaryItem.SummaryValue)  '    SubTotalFacturaClienteV.ToString(Round)
            etIva.EditValue = CDbl(iVista.Columns("IVA").SummaryItem.SummaryValue)  ' Totaliva.ToString(Round) '(SubTotalFacturaClienteV * (ConfigDetalles.IVA / 100.0)).ToString(Round)
            etTotal.EditValue = etSubTotal.EditValue + etIva.EditValue   '(SubTotalFacturaClienteV + CDbl(etIva.Text)).ToString(Round)
        End Sub

        'Private Sub MakeDataSet()

        '    myDataSet = New DataSet("myDataSet")

        '    tCust = New DataTable("Articulos")

        '    Dim cArticuloCodigo As DataColumn
        '    cArticuloCodigo = New DataColumn("ArticuloCodigo")

        '    Dim cArticulo As DataColumn
        '    cArticulo = New DataColumn("Articulo")

        '    Dim cCantidad As DataColumn
        '    cCantidad = New DataColumn("Cantidad")

        '    Dim cPrecio As DataColumn
        '    cPrecio = New DataColumn("Precio")

        '    Dim cDescuento As DataColumn
        '    cDescuento = New DataColumn("Descuento")

        '    Dim cIva As DataColumn
        '    cIva = New DataColumn("Iva")

        '    Dim cSubTotal As DataColumn
        '    cSubTotal = New DataColumn("SubTotal")

        '    Dim cCodigoTemporal As DataColumn
        '    cCodigoTemporal = New DataColumn("CodigoTemporal")

        '    Dim cItemTipo As DataColumn
        '    cItemTipo = New DataColumn("Tipo")

        '    'Dim cAgregar As DataColumn
        '    'cAgregar = New DataColumn("Agregar", GetType(System.Boolean))

        '    tCust.Columns.Add(cArticuloCodigo)
        '    tCust.Columns.Add(cArticulo)
        '    tCust.Columns.Add(cCantidad)
        '    tCust.Columns.Add(cPrecio)
        '    tCust.Columns.Add(cDescuento)
        '    tCust.Columns.Add(cIva)
        '    tCust.Columns.Add(cSubTotal)
        '    tCust.Columns.Add(cCodigoTemporal)
        '    tCust.Columns.Add(cItemTipo)
        '    'tCust.Columns.Add(cAgregar)

        '    tCust.DefaultView.AllowDelete = False
        '    tCust.DefaultView.AllowNew = False

        '    myDataSet.Tables.Add(tCust)

        '    myDataSet.Tables("Articulos").DefaultView.AllowDelete = False
        '    myDataSet.Tables("Articulos").DefaultView.AllowNew = False

        '    Dim newRow1 As DataRow

        '    Dim j As Integer

        '    For j = 0 To ds.Tables("Facturas_Ventas").Rows.Count - 1
        '        newRow1 = tCust.NewRow
        '        newRow1("ArticuloCodigo") = ds.Tables("Facturas_Ventas").Rows(j).Item("Item")
        '        tCust.Rows.Add(newRow1)

        '        tCust.Rows(j)("CodigoTemporal") = ds.Tables("Facturas_Ventas").Rows(j).Item("Item")
        '        tCust.Rows(j)("Articulo") = ds.Tables("Facturas_Ventas").Rows(j).Item("Descripcion")
        '        tCust.Rows(j)("Cantidad") = ds.Tables("Facturas_Ventas").Rows(j).Item("Cantidad")
        '        tCust.Rows(j)("Precio") = CDbl(ds.Tables("Facturas_Ventas").Rows(j).Item("Precio")).ToString(Round)
        '        tCust.Rows(j)("Iva") = CDbl(ds.Tables("Facturas_Ventas").Rows(j).Item("Iva")).ToString(Round)
        '        tCust.Rows(j)("Descuento") = CDbl(ds.Tables("Facturas_Ventas").Rows(j).Item("Descuento")).ToString(Round)
        '        tCust.Rows(j)("SubTotal") = (CDbl(CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio"))) - CDbl(CDbl(CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio")) * (CDbl(tCust.Rows(j)("Descuento")))) / 100.0)).ToString(Round)
        '        tCust.Rows(j)("Tipo") = ds.Tables("Facturas_Ventas").Rows(j).Item("Tipo_Item")
        '        'tCust.Rows(j)("Agregar") = False
        '    Next

        'End Sub

        'Private Sub TextBoxCantidadLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)

        '    If Not IsNumeric(Cantidad.TextBox.Text) Then
        '        Cantidad.TextBox.Text = ValorActualCantidad
        '    Else
        '        If CDbl(Cantidad.TextBox.Text) <= 0 Then
        '            MsgBox("La cantidad debe ser mayor que Cero (0)", MsgBoxStyle.Information)
        '            Cantidad.TextBox.Text = ValorActualCantidad
        '            Exit Sub
        '        End If
        '    End If

        'End Sub

        'Private Sub AddCustomDataTableStyle()
        '    Dim ts1 As DataGridTableStyle
        '    ts1 = New DataGridTableStyle()

        '    ts1.MappingName = "Articulos"
        '    ts1.AlternatingBackColor = Color.LightBlue
        '    Dim colCount As Integer
        '    colCount = 0

        '    Dim ArticuloCodigo As DataGridTextBoxColumn
        '    ArticuloCodigo = New DataGridTextBoxColumn()
        '    ArticuloCodigo.MappingName = "ArticuloCodigo"
        '    ArticuloCodigo.HeaderText = "Código"
        '    ArticuloCodigo.Width = 100
        '    ArticuloCodigo.Alignment = HorizontalAlignment.Left
        '    ArticuloCodigo.ReadOnly = True
        '    ArticuloCodigo.Format = "##,###0.00"
        '    ts1.GridColumnStyles.Add(ArticuloCodigo)
        '    colCount = (colCount + 1)

        '    ArticuloCodigo.NullText = ""


        '    Dim Articulo As DataGridTextBoxColumn
        '    Articulo = New DataGridTextBoxColumn()
        '    Articulo.MappingName = "Articulo"
        '    Articulo.HeaderText = "Descripción"
        '    Articulo.Width = 300
        '    Articulo.Alignment = HorizontalAlignment.Left
        '    Articulo.ReadOnly = True
        '    Articulo.Format = "##,###0.00"
        '    ts1.GridColumnStyles.Add(Articulo)
        '    colCount = (colCount + 1)

        '    Articulo.NullText = ""

        '    'Dim Cantidad As DataGridTextBoxColumn
        '    Cantidad = New DataGridTextBoxColumn()
        '    Cantidad.MappingName = "Cantidad"
        '    Cantidad.HeaderText = "Cantidad"
        '    Cantidad.Width = 100
        '    Cantidad.Alignment = HorizontalAlignment.Right
        '    Cantidad.ReadOnly = False

        '    AddHandler Cantidad.TextBox.Leave, New EventHandler(AddressOf TextBoxCantidadLeaveHandler)

        '    ts1.GridColumnStyles.Add(Cantidad)
        '    colCount = (colCount + 1)

        '    Cantidad.NullText = ""

        '    Dim Precio As DataGridTextBoxColumn
        '    Precio = New DataGridTextBoxColumn()
        '    Precio.MappingName = "Precio"
        '    Precio.HeaderText = "Precio"
        '    Precio.Width = 100
        '    Precio.Alignment = HorizontalAlignment.Right
        '    Precio.ReadOnly = True
        '    Precio.Format = "##,###0.00"
        '    ts1.GridColumnStyles.Add(Precio)
        '    colCount = (colCount + 1)

        '    Precio.NullText = (0).ToString(Round)

        '    Dim Descuento As DataGridTextBoxColumn
        '    Descuento = New DataGridTextBoxColumn()
        '    Descuento.MappingName = "Descuento"
        '    Descuento.HeaderText = "Descuento %"
        '    Descuento.Width = 100
        '    Descuento.Alignment = HorizontalAlignment.Right
        '    Descuento.ReadOnly = True
        '    Descuento.Format = "##,###0.00"

        '    ts1.GridColumnStyles.Add(Descuento)
        '    colCount = (colCount + 1)

        '    Descuento.NullText = (0).ToString(Round)

        '    Dim SubTotal As DataGridTextBoxColumn
        '    SubTotal = New DataGridTextBoxColumn()
        '    SubTotal.MappingName = "SubTotal"
        '    SubTotal.HeaderText = "Sub Total"
        '    SubTotal.Width = 120
        '    SubTotal.Alignment = HorizontalAlignment.Right
        '    SubTotal.ReadOnly = True
        '    SubTotal.Format = "##,###0.00"
        '    ts1.GridColumnStyles.Add(SubTotal)
        '    colCount = (colCount + 1)

        '    SubTotal.NullText = (0).ToString(Round)

        '    Dim CodigoTemporal As DataGridTextBoxColumn
        '    CodigoTemporal = New DataGridTextBoxColumn()
        '    CodigoTemporal.MappingName = "CodigoTemporal"
        '    CodigoTemporal.HeaderText = "CodigoTemporal"
        '    CodigoTemporal.Width = 0
        '    CodigoTemporal.Alignment = HorizontalAlignment.Left
        '    CodigoTemporal.ReadOnly = True
        '    ts1.GridColumnStyles.Add(CodigoTemporal)
        '    colCount = (colCount + 1)

        '    CodigoTemporal.NullText = ""

        '    Dim ItemTipo As DataGridTextBoxColumn
        '    ItemTipo = New DataGridTextBoxColumn()
        '    ItemTipo.MappingName = "Tipo"
        '    ItemTipo.HeaderText = "Tipo"
        '    ItemTipo.Width = 0
        '    ItemTipo.ReadOnly = True

        '    ts1.GridColumnStyles.Add(ItemTipo)
        '    colCount = (colCount + 1)

        '    ItemTipo.NullText = ""

        '    'Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        '    'boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        '    'boolCol.MappingName = "Agregar"
        '    'boolCol.HeaderText = "Seleccionar"
        '    'boolCol.Alignment = HorizontalAlignment.Center
        '    ''uncomment this line to get a two-state checkbox
        '    'CType(boolCol, DataGridBoolColumn).AllowNull = False

        '    'boolCol.Width = 70
        '    'boolCol.ReadOnly = False

        '    'boolCol.NullText = ""

        '    ''hook the new event to our handler in the grid
        '    'AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)

        '    'ts1.GridColumnStyles.Add(boolCol)
        '    'colCount = (colCount + 1)

        '    ts1.AllowSorting = False
        '    ts1.HeaderFont = dgFacturacionCliente.HeaderFont
        '    ts1.HeaderBackColor = Color.LightSteelBlue
        '    ts1.GridLineColor = Color.FromArgb(70, 130, 180)

        '    dgFacturacionCliente.CaptionVisible = False

        '    ts1.PreferredRowHeight = 25

        '    'TS1.DefaultTableStyl
        '    myDataSet.Tables("Articulos").DefaultView.AllowDelete = False
        '    'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowEdit = True
        '    'ts1.ReadOnly = True
        '    tCust.DefaultView.AllowDelete = False

        '    dgFacturacionCliente.CaptionVisible = False

        '    dgFacturacionCliente.TableStyles.Clear()
        '    dgFacturacionCliente.TableStyles.Add(ts1)

        'End Sub

        'Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
        '    Dim s As String
        '    s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
        '    Console.WriteLine(s)
        'End Sub

        Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

        'Private Sub cmdConsultaClientes_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        '    'If cbCliente.Text = "" Then
        '    '    MsgBox("Seleccione el Cliente", MsgBoxStyle.Information)
        '    '    Exit Sub
        '    'End If

        '    'If cbCliente.SelectedValue = Nothing Then
        '    '    MsgBox("El cliente no está registrado", MsgBoxStyle.Information)
        '    '    Exit Sub
        '    'End If

        '    If txtCliente.Visible = True Then
        '        MsgBox("El cliente no está registrado", MsgBoxStyle.Information)
        '        Exit Sub
        '    End If

        '    Dim f As frmAcumulados = f.Instance

        '    RegistroCliente = cbCliente.SelectedValue

        '    f.MdiParent = Me.MdiParent
        '    f.Show()
        'End Sub

        'Private Sub cmdVerPagos_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        '    Registro = txtFactura.Text
        '    If Clientes.CobrosHistorial(txtFactura.Text).Tables("Cobros").Rows.Count = 0 Then
        '        MsgBox("La Factura seleccionada no tiene ningún pago", MsgBoxStyle.Information)
        '        Exit Sub
        '    End If

        '    Dim f As frmHistorialCobros = f.Instance

        '    f.MdiParent = Me.MdiParent
        '    f.WindowState = FormWindowState.Maximized
        '    f.Show()
        'End Sub

        'Private Sub dgFacturacionCliente_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        '    Dim hti As DataGrid.HitTestInfo = Me.dgFacturacionCliente.HitTest(e.X, e.Y)
        '    Try
        '        If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
        '            Me.dgFacturacionCliente(hti.Row, hti.Column) = Not CBool(Me.dgFacturacionCliente(hti.Row, hti.Column))
        '        Else
        '            Exit Sub
        '        End If
        '    Catch ex As Exception
        '        'MessageBox.Show(ex.ToString())
        '    End Try
        'End Sub 'dataGrid2_MouseUp

        'Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        '    Exit Sub
        '    Dim Cantidad As Integer
        '    Cantidad = 0

        '    If tCust.Rows.Count = 0 Then
        '        MsgBox("Seleccione al menos un Producto", MsgBoxStyle.Critical)
        '        dgFacturacionCliente.Focus()
        '        Exit Sub
        '    End If

        '    For i = 0 To tCust.Rows.Count - 1
        '        If tCust.Rows(i)("Agregar") = True Then
        '            Cantidad = 1
        '            Exit For
        '        End If
        '    Next

        '    If Cantidad = 0 Then
        '        MsgBox("Seleccione al menos un Producto", MsgBoxStyle.Critical)
        '        dgFacturacionCliente.Focus()
        '        Exit Sub
        '    End If

        '    DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        '    DBConnFacturas.Open()
        '    transaccionFacturas = DBConnFacturas.BeginTransaction

        '    Dim Numero As String
        '    Dim Iva As Double

        '    Numero = Devolucion.Numero

        '    Try
        '        Devolucion.AddItem(Numero, Me.txtFactura.Text, "", 0, 0, 0)
        '        For i = 0 To tCust.Rows.Count - 1
        '            If tCust.Rows(i)("Agregar") = True Then
        '                Iva = (CDbl(tCust.Rows(i)("Precio")) * CDbl(tCust.Rows(i)("Cantidad"))) * (ConfigDetalles.IVA / 100.0)
        '                Devolucion.AddItemDetalle(Numero, tCust.Rows(i)("CodigoTemporal"), tCust.Rows(i)("Tipo"), tCust.Rows(i)("Cantidad"), Iva)
        '                Devolucion.UpdateItem(Me.txtFactura.Text, tCust.Rows(i)("CodigoTemporal"), "P", 1)
        '            End If
        '        Next
        '        VB.SysContab.Rutinas.okTransaccion()
        '        Me.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.Message & " Guardar")
        '        VB.SysContab.Rutinas.ErrorTransaccion()
        '        Exit Sub
        '    End Try
        'End Sub

        'Private Sub dgFacturacionCliente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        '    'Try
        '    '    If Me.dgFacturacionCliente.CurrentRowIndex = tCust.Rows.Count Then
        '    '        Me.dgFacturacionCliente.ReadOnly = True
        '    '        Exit Sub
        '    '    Else
        '    '        Me.dgFacturacionCliente.ReadOnly = False
        '    '    End If

        '    '    ValorActualCantidad = tCust.Rows(dgFacturacionCliente.CurrentRowIndex)("Cantidad")

        '    'Catch ex As Exception
        '    '    'MsgBox(ex.Message)
        '    '    Exit Sub
        '    'End Try
        'End Sub

        'Private Sub cbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    If Me.cbTodos.Checked = True Then
        '        For i = 0 To tCust.Rows.Count - 1
        '            tCust.Rows(i)("Agregar") = True
        '        Next
        '    Else
        '        For i = 0 To tCust.Rows.Count - 1
        '            tCust.Rows(i)("Agregar") = False
        '        Next
        '    End If
        'End Sub

        Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
            'ShowSplash("Imprimiendo...")
            VB.SysContab.ComprobanteDB.ImprimirComprobante(Comp_No, Per_Id, _
                                              dtpFecha.DateTime.Date)
            'HideSplash()
        End Sub

        Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
            frmExportarImprimir.Mostrar(iGrid, "Detalle de Devolución de Factura " & txtFactura.Text & " No. " & txtDevolucion.Text)
        End Sub
    End Class

End Namespace
