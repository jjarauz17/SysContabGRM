Public Class frmMovimientos
    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As frmMovimientos = Nothing

    Public Shared Function Instance() As frmMovimientos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmMovimientos
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
    Friend WithEvents dgMovimientos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vMovimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdVerDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdContabilizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkFiltro As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos))
        Me.dgMovimientos = New DevExpress.XtraGrid.GridControl()
        Me.vMovimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdContabilizar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVerDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.chkFiltro = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.dgMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFiltro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgMovimientos
        '
        Me.dgMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMovimientos.Location = New System.Drawing.Point(12, 35)
        Me.dgMovimientos.MainView = Me.vMovimientos
        Me.dgMovimientos.Name = "dgMovimientos"
        Me.dgMovimientos.Size = New System.Drawing.Size(651, 209)
        Me.dgMovimientos.TabIndex = 0
        Me.dgMovimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vMovimientos})
        '
        'vMovimientos
        '
        Me.vMovimientos.GridControl = Me.dgMovimientos
        Me.vMovimientos.Name = "vMovimientos"
        Me.vMovimientos.OptionsBehavior.Editable = False
        Me.vMovimientos.OptionsView.ShowAutoFilterRow = True
        Me.vMovimientos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vMovimientos.OptionsView.ShowFooter = True
        Me.vMovimientos.OptionsView.ShowGroupPanel = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(659, 53)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmdAnular
        '
        Me.cmdAnular.ImageOptions.Image = CType(resources.GetObject("cmdAnular.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAnular.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdAnular.Location = New System.Drawing.Point(223, 248)
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(96, 38)
        Me.cmdAnular.StyleController = Me.LayoutControl1
        Me.cmdAnular.TabIndex = 3
        Me.cmdAnular.Text = "&Anular"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdSalir.Location = New System.Drawing.Point(569, 248)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(94, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 2
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdContabilizar
        '
        Me.cmdContabilizar.ImageOptions.Image = CType(resources.GetObject("cmdContabilizar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdContabilizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdContabilizar.Location = New System.Drawing.Point(112, 248)
        Me.cmdContabilizar.Name = "cmdContabilizar"
        Me.cmdContabilizar.Size = New System.Drawing.Size(107, 38)
        Me.cmdContabilizar.StyleController = Me.LayoutControl1
        Me.cmdContabilizar.TabIndex = 1
        Me.cmdContabilizar.Text = "&Contabilizar"
        '
        'cmdVerDetalle
        '
        Me.cmdVerDetalle.ImageOptions.Image = CType(resources.GetObject("cmdVerDetalle.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdVerDetalle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdVerDetalle.Location = New System.Drawing.Point(12, 248)
        Me.cmdVerDetalle.Name = "cmdVerDetalle"
        Me.cmdVerDetalle.Size = New System.Drawing.Size(96, 38)
        Me.cmdVerDetalle.StyleController = Me.LayoutControl1
        Me.cmdVerDetalle.TabIndex = 0
        Me.cmdVerDetalle.Text = "&Detalle"
        '
        'chkFiltro
        '
        Me.chkFiltro.Location = New System.Drawing.Point(12, 12)
        Me.chkFiltro.Name = "chkFiltro"
        Me.chkFiltro.Properties.Caption = "Mostrar Todo"
        Me.chkFiltro.Size = New System.Drawing.Size(651, 19)
        Me.chkFiltro.StyleController = Me.LayoutControl1
        Me.chkFiltro.TabIndex = 21
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdAnular)
        Me.LayoutControl1.Controls.Add(Me.chkFiltro)
        Me.LayoutControl1.Controls.Add(Me.cmdContabilizar)
        Me.LayoutControl1.Controls.Add(Me.dgMovimientos)
        Me.LayoutControl1.Controls.Add(Me.cmdVerDetalle)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2828, 206, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(675, 298)
        Me.LayoutControl1.TabIndex = 22
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(675, 298)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.chkFiltro
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(655, 23)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dgMovimientos
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 23)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(655, 213)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdVerDetalle
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 236)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdContabilizar
        Me.LayoutControlItem4.Location = New System.Drawing.Point(100, 236)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdAnular
        Me.LayoutControlItem5.Location = New System.Drawing.Point(211, 236)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdSalir
        Me.LayoutControlItem6.Location = New System.Drawing.Point(557, 236)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(311, 236)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(143, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.SimpleButton1.Location = New System.Drawing.Point(466, 248)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(99, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 23
        Me.SimpleButton1.Text = "E&xportar"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(454, 236)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(103, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(103, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(103, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'frmMovimientos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(675, 298)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMovimientos"
        Me.Text = "Listado de Movimientos Pendientes de Contabilizar"
        CType(Me.dgMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFiltro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim Iniciado As Boolean = False
    Dim Filtro As New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[Anulado] = 0")
#End Region
    Private Sub cmdVerDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerDetalle.Click
        Dim f As New frmAgregarMovimientos
        frmAgregarMovimientos.Consecutivo = Me.vMovimientos.GetFocusedRowCellValue("Consecutivo")
        frmAgregarMovimientos.Modo = "V"
        f.ShowDialog()
    End Sub

    Private Sub frmMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
    End Sub
    Public Sub Cargar()
        Me.dgMovimientos.DataSource = VB.SysContab.Activo_FijosDB.GetMovimientos("%", "0")
        Me.vMovimientos.Columns("Tipo").Visible = False
        Me.vMovimientos.BestFitColumns()
        Me.vMovimientos.Columns("Anulado").FilterInfo = Filtro
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click

        If vMovimientos.GetFocusedRowCellValue("Anulado") = True Then
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta seguro de anular este movimiento?") Then
            Exit Sub
        End If
        '
        VB.SysContab.Activo_FijosDB.TranValor_Anular(Me.vMovimientos.GetFocusedRowCellValue("Consecutivo"))
        Me.Cargar()
    End Sub

    Private Sub chkFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltro.CheckedChanged
        If Me.chkFiltro.Checked Then
            Me.vMovimientos.Columns("Anulado").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "")
        Else : Me.vMovimientos.Columns("Anulado").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Custom, "[Anulado] = 0")
        End If
    End Sub

    Private Sub cmdContabilizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdContabilizar.Click
        If Me.vMovimientos.GetFocusedRowCellValue("Anulado") = True Then
            XtraMsg("Este movimiento ha sido anulado", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Me.vMovimientos.GetFocusedRowCellValue("Contabilizado") = True Then
            XtraMsg("Este movimiento ha sido Contabilizado", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        Dim f As New frmMovimientos_Contabilizar
        f.Tipo = Me.vMovimientos.GetFocusedRowCellValue("Tipo")
        f.DetalleActivo = VB.SysContab.Activo_FijosDB.GetDetails(Me.vMovimientos.GetFocusedRowCellValue("Codigo Activo"))
        f.dtpFecha.EditValue = Me.vMovimientos.GetFocusedRowCellValue("Fecha")
        f.Valor = Math.Abs(Me.vMovimientos.GetFocusedRowCellValue("Valor"))
        f.Consecutivo = Me.vMovimientos.GetFocusedRowCellValue("Consecutivo")
        'f.MdiParent = Me.MdiParent
        'f.WindowState = FormWindowState.Maximized
        f.StartPosition = FormStartPosition.CenterScreen
        f.ShowDialog()
    End Sub

    Private Sub frmMovimientos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Cargar()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(dgMovimientos, Me.Text)
    End Sub
End Class
