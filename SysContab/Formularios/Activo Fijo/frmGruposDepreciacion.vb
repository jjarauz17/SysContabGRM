Public Class frmGruposDepreciacion
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmGruposDepreciacion = Nothing

    Public Shared Function Instance() As frmGruposDepreciacion
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmGruposDepreciacion()
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
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGruposDepreciacion))
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAyuda
        '
        Me.cmdAyuda.ImageOptions.Image = CType(resources.GetObject("cmdAyuda.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAyuda.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdAyuda.Location = New System.Drawing.Point(630, 476)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(102, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "E&xportar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl1.Controls.Add(Me.cmdModificar)
        Me.LayoutControl1.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(903, 279, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(848, 526)
        Me.LayoutControl1.TabIndex = 188
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdSalir
        '
        Me.cmdSalir.ImageOptions.Image = CType(resources.GetObject("cmdSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdSalir.Location = New System.Drawing.Point(736, 476)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(100, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'iGrid
        '
        Me.iGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iGrid.Location = New System.Drawing.Point(12, 12)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(824, 460)
        Me.iGrid.TabIndex = 187
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista, Me.GridView2})
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
        'GridView2
        '
        Me.GridView2.GridControl = Me.iGrid
        Me.GridView2.Name = "GridView2"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.ImageOptions.Image = CType(resources.GetObject("cmdBorrar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdBorrar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdBorrar.Location = New System.Drawing.Point(220, 476)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(100, 38)
        Me.cmdBorrar.StyleController = Me.LayoutControl1
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.ImageOptions.Image = CType(resources.GetObject("cmdModificar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdModificar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdModificar.Location = New System.Drawing.Point(116, 476)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(100, 38)
        Me.cmdModificar.StyleController = Me.LayoutControl1
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.ImageOptions.Image = CType(resources.GetObject("cmdNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNuevo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 476)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(100, 38)
        Me.cmdNuevo.StyleController = Me.LayoutControl1
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem5, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(848, 526)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(828, 464)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdNuevo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 464)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdModificar
        Me.LayoutControlItem3.Location = New System.Drawing.Point(104, 464)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdAyuda
        Me.LayoutControlItem6.Location = New System.Drawing.Point(618, 464)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdSalir
        Me.LayoutControlItem7.Location = New System.Drawing.Point(724, 464)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdBorrar
        Me.LayoutControlItem5.Location = New System.Drawing.Point(208, 464)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(312, 464)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(306, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmGruposDepreciacion
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(848, 526)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmGruposDepreciacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Dim r As New VB.SysContab.Rutinas()
    Dim Grupos_Depreciacion As New VB.SysContab.Grupos_DepreciacionDB()

    Private Sub frmGrupos_Depreciacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim Grupos_Depreciacion As New VB.SysContab.Grupos_DepreciacionDB()
        'Dim Tabla As New DataTable()


        'VB.SysContab.RutinasNomina.CambiarEstilo(Me)

        'dgGrupos_Depreciacion.DataSource = Grupos_Depreciacion.GetList().Tables("Grupos_Depreciacion").DefaultView
        'Tabla = ds.Tables("Grupos_Depreciacion")
        'r.FormatGenerico(dgGrupos_Depreciacion, Tabla)

        'If ds.Tables("Grupos_Depreciacion").Rows.Count <> 0 Then
        '    Registro = dgGrupos_Depreciacion.Item(0, 0)
        'Else
        '    Registro = "Vacio"
        'End If

        'dgGrupos_Depreciacion.CaptionText = "Información de Grupos de Depreciación"

        'Me.Text = "Mantenimiento de Grupos de Depreciación"
        'Me.Refresh()

        Cargar()
        '
        iVista.PopulateColumns()
        FormatoGrid(iVista)
    End Sub

    Sub Cargar()

        Dim ds As New DataSet()

        ds = Grupos_Depreciacion.GetList()
        iGrid.DataSource = ds.Tables("Grupos_Depreciacion")

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarGrupoDepreciacion = frmAgregarGrupoDepreciacion.Instance()
        Nuevo = "SI"

        With f
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
            .Dispose()
        End With

    End Sub

    'Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim Grupos_Depreciacion As New VB.SysContab.Grupos_DepreciacionDB()
    '    dgGrupos_Depreciacion.DataSource = Grupos_Depreciacion.GetListBuscar(txtBuscar.Text).Tables("Grupos_Depreciacion").DefaultView

    '    If Grupos_Depreciacion.GetListBuscar(txtBuscar.Text).Tables("Grupos_Depreciacion").Rows.Count = 0 Then
    '        Exit Sub
    '    End If
    '    Registro = dgGrupos_Depreciacion.Item(dgGrupos_Depreciacion.CurrentRowIndex, 0)
    'End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmAgregarGrupoDepreciacion = frmAgregarGrupoDepreciacion.Instance
        'Dim Grupos_Depreciacion As New VB.SysContab.Grupos_DepreciacionDB()

        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro.")
            Exit Sub
        End If

        Nuevo = "NO"
        Registro = iVista.GetRowCellValue(iVista.FocusedRowHandle, "CODIGO")
        With f
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub dgGrupos_Depreciacion_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Registro = dgGrupos_Depreciacion.Item(dgGrupos_Depreciacion.CurrentRowIndex, 0)
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        '    Dim resp As DialogResult
        'Dim Grupos_Depreciacion As New VB.SysContab.Grupos_DepreciacionDB()

        '    If Registro = "Vacio" Then
        '        MsgBox("Seleccione el Grupo de Depreciación que desea Borrar", MsgBoxStyle.Information)
        '        Exit Sub
        '    End If

        '    resp = MsgBox("Esta seguro que dese borrar el Grupo de Depreciación: " & dgGrupos_Depreciacion.Item(dgGrupos_Depreciacion.CurrentRowIndex, 0) & " - " & dgGrupos_Depreciacion.Item(dgGrupos_Depreciacion.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        '    If resp = DialogResult.No Then
        '        Exit Sub
        '    End If

        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro.")
            Exit Sub
        End If

        If Not XtraMsg2("Está seguro de la Acción Solicitada ?") Then
            Exit Sub
        End If

        Try
            Grupos_Depreciacion.Delete(iVista.GetRowCellValue(iVista.FocusedRowHandle, "CODIGO"))

            XtraMsg("El registro ha sido borrado.")

            Cargar()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try

        'Try
        '    Grupos_Depreciacion.Delete(dgGrupos_Depreciacion.Item(dgGrupos_Depreciacion.CurrentRowIndex, 0))
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Exit Sub

        'End Try

        'MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        'Dim Tabla As New DataTable()
        ''Dim f As New frmGrupos()
        'Dim ds As New DataSet()

        ''VB.SysContab.RutinasNomina.CambiarEstilo(Me)

        'ds = Grupos_Depreciacion.GetList

        'dgGrupos_Depreciacion.DataSource = Grupos_Depreciacion.GetList().Tables("Grupos_Depreciacion").DefaultView
        'Tabla = ds.Tables("Grupos_Depreciacion")

        'If ds.Tables("Grupos_Depreciacion").Rows.Count = 0 Then
        '    Registro = "Vacio"
        'Else
        '    Registro = dgGrupos_Depreciacion.Item(0, 0)
        'End If
        'r.FormatGenerico(dgGrupos_Depreciacion, Tabla)
    End Sub

    'Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = "'" Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub frmGruposDepreciacion_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
    '    VB.SysContab.Rutinas.OcultarMenu(FormPrincipal)
    'End Sub

    'Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.MouseEnter
    '    VB.SysContab.Rutinas.OcultarMenu(FormPrincipal)
    'End Sub

    'Private Sub dgGrupos_Depreciacion_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGrupos_Depreciacion.MouseEnter
    '    VB.SysContab.Rutinas.OcultarMenu(FormPrincipal)
    'End Sub

    'Private Sub frmGruposDepreciacion_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    '    Opened = "NO"
    '    FormPrincipal.StatusBar1.Panels(3).Text = ""
    'End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        'Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "Depreciacion")
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

End Class
