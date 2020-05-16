Imports System.Diagnostics.Process
Public Class frmServicios
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmServicios = Nothing

    Public Shared Function Instance() As frmServicios
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmServicios
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
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicios))
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExportar
        '
        Me.btnExportar.Enabled = False
        Me.btnExportar.ImageOptions.Image = CType(resources.GetObject("btnExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(495, 283)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(101, 38)
        Me.btnExportar.StyleController = Me.LayoutControl1
        Me.btnExportar.TabIndex = 8
        Me.btnExportar.Text = "&Exportar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.btnExportar)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.cmdModificar)
        Me.LayoutControl1.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(783, 194, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(716, 333)
        Me.LayoutControl1.TabIndex = 15
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(600, 283)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(104, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(412, 283)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(65, 22)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "Ayuda"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 42)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(692, 237)
        Me.GridControl1.TabIndex = 14
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.ImageOptions.Image = CType(resources.GetObject("cmdBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(312, 283)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(96, 38)
        Me.cmdBorrar.StyleController = Me.LayoutControl1
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.ImageOptions.Image = CType(resources.GetObject("cmdImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(212, 283)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(96, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.ImageOptions.Image = CType(resources.GetObject("cmdModificar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(112, 283)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(96, 38)
        Me.cmdModificar.StyleController = Me.LayoutControl1
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.ImageOptions.Image = CType(resources.GetObject("cmdNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 283)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(96, 38)
        Me.cmdNuevo.StyleController = Me.LayoutControl1
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Nuevo"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem2, Me.LayoutControlItem11})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(716, 333)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GridControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(696, 241)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdNuevo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 271)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdModificar
        Me.LayoutControlItem5.Location = New System.Drawing.Point(100, 271)
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
        Me.LayoutControlItem6.Control = Me.cmdImprimir
        Me.LayoutControlItem6.Location = New System.Drawing.Point(200, 271)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdBorrar
        Me.LayoutControlItem7.Location = New System.Drawing.Point(300, 271)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdAyuda
        Me.LayoutControlItem8.Location = New System.Drawing.Point(400, 271)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(69, 42)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        Me.LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.btnExportar
        Me.LayoutControlItem9.Location = New System.Drawing.Point(483, 271)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdSalir
        Me.LayoutControlItem10.Location = New System.Drawing.Point(588, 271)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(108, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(469, 271)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(14, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = "P"
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 12)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.ForeColor = System.Drawing.Color.OrangeRed
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Appearance.Options.UseForeColor = True
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Servicios a Proveedores"), New DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Servicios a Clientes")})
        Me.RadioGroup1.Size = New System.Drawing.Size(692, 26)
        Me.RadioGroup1.StyleController = Me.LayoutControl1
        Me.RadioGroup1.TabIndex = 15
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.RadioGroup1
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(0, 30)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(54, 30)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(696, 30)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'frmServicios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(716, 333)
        Me.Controls.Add(Me.LayoutControl1)
        Me.KeyPreview = True
        Me.Name = "frmServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Function PC() As String

        Return RadioGroup1.EditValue

        'If Me.rbClientes.Checked = True Then
        '    Return "C"
        '    Exit Function
        'End If

        'If Me.rbProveedores.Checked = True Then
        '    Return "P"
        '    Exit Function
        'End If

    End Function

    Private Sub frmServicios_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then Cargar()
    End Sub

    Private Sub frmServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)
        Cargar()
        Grid()
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
    End Sub
    Public Sub Cargar()
        Me.GridControl1.DataSource =
            ObtieneDatos("sp_GetLisServicios",
                         PC(),
                         EmpresaActual)
    End Sub

    Sub Grid()
        Me.GridView1.PopulateColumns()
        FormatoGrid(Me.GridView1)
        Me.GridView1.BestFitColumns()

        Me.GridView1.Columns("COSTO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridView1.Columns("COSTO").DisplayFormat.FormatString = "{0:" & Round & "}"
        Me.GridView1.Columns("COSTO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridView1.Columns("COSTO").SummaryItem.DisplayFormat = "{0:" & Round & "}"

        If Me.GridView1.DataRowCount <> 0 Then
            Registro = Me.GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Código")
        Else
            Registro = "Vacio"
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        If Me.GridView1.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.GridView1.GetFocusedRowCellValue("Código")
        End If

        'Dim Servicios As New VB.SysContab.ServiciosDB
        Dim Item As New VB.SysContab.ArticulosDB

        If Not XtraMsg2("Esta seguro que dese borrar el Servicio: " & Registro & " - " & Me.GridView1.GetFocusedRowCellValue("Nombre") + " ?") Then
            Exit Sub
        End If
        '
        Try
            VB.SysContab.ArticulosDB.Delete(
                Registro,
                "S",
                GridView1.GetFocusedRowCellValue("PC"))
            '
            Me.cargar()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As New FrmAgregarServicios '= FrmAgregarServicios.Instance

        Nuevo = "SI"

        f.PC = PC()

        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Nuevo Servicio"
        f.WindowState = FormWindowState.Maximized


        f.cbProveedor.EditValue = Nothing
        f.cbLinea.SelectedValue = -1
        f.cbGrupo.SelectedValue = -1
        f.cbSubGrupo.SelectedValue = -1
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.GridView1.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.GridView1.GetFocusedRowCellValue("Código")
        End If
        '
        Dim f As FrmAgregarServicios = FrmAgregarServicios.Instance()
        Nuevo = "NO"
        f.PC = GridView1.GetFocusedRowCellValue("PC")
        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Modificar Servicio"
        f.WindowState = FormWindowState.Maximized
        'Me.cargar()
    End Sub

    Private Sub frmServicios_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim f As frmReportesServicios = frmReportesServicios.Instance()
        f.MdiParent = Me.MdiParent
        f.Text = "Reporte Servicios"
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmServicios_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        '
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Start(Application.StartupPath & "\Ayuda\RegISServicios.chm")
    End Sub


    'Private Sub rbClientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbClientes.CheckedChanged
    '    Cargar()
    'End Sub

    'Private Sub rbProveedores_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbProveedores.CheckedChanged
    '    Cargar()
    'End Sub

    Private Sub Vista_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Registro = Me.GridView1.GetFocusedRowCellValue("Código")
    End Sub

    Private Sub GridControl1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.cargar()
        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.GridControl1)
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Cargar()
    End Sub
End Class
