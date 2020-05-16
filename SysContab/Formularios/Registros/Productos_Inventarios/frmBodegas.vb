Imports System.Diagnostics.Process
Public Class frmBodegas
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmBodegas = Nothing

    Public Shared Function Instance() As frmBodegas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmBodegas
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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBodegas))
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Image = CType(resources.GetObject("cmdAyuda.Image"), System.Drawing.Image)
        Me.cmdAyuda.Location = New System.Drawing.Point(432, 275)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(97, 38)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 9
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.dgDatos)
        Me.LayoutControl1.Controls.Add(Me.cmdModificar)
        Me.LayoutControl1.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(842, 281, 250, 343)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(641, 325)
        Me.LayoutControl1.TabIndex = 13
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(533, 275)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(96, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'dgDatos
        '
        Me.dgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDatos.Location = New System.Drawing.Point(12, 12)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(617, 259)
        Me.dgDatos.TabIndex = 12
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsBehavior.Editable = False
        Me.vDatos.OptionsFind.AlwaysVisible = True
        Me.vDatos.OptionsFind.ShowClearButton = False
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Image = CType(resources.GetObject("cmdModificar.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(112, 275)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(96, 38)
        Me.cmdModificar.StyleController = Me.LayoutControl1
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Image = CType(resources.GetObject("cmdBorrar.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(212, 275)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(96, 38)
        Me.cmdBorrar.StyleController = Me.LayoutControl1
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(312, 275)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(96, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 275)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(96, 38)
        Me.cmdNuevo.StyleController = Me.LayoutControl1
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(641, 325)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgDatos
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(621, 263)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdNuevo
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 263)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdModificar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(100, 263)
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
        Me.LayoutControlItem4.Control = Me.cmdImprimir
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(300, 263)
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
        Me.LayoutControlItem5.Control = Me.cmdBorrar
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(200, 263)
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
        Me.LayoutControlItem6.Control = Me.cmdAyuda
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(420, 263)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(101, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdSalir
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(521, 263)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(400, 263)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(20, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmBodegas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(641, 325)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmBodegas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas

    Private Sub frmBodegas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)

        Cargar()
        ''Me.Text = "Mantenimiento de Bodegas"
        Me.Refresh()
    End Sub

    Sub Cargar()
        Dim Bodegas As New VB.SysContab.BodegasDB


        Dim Tabla As DataTable = Bodegas.Lista()
        dgDatos.DataSource = Tabla.DefaultView
        vDatos.PopulateColumns()
        FormatoGrid(vDatos)

        If Tabla.Rows.Count <> 0 Then
            Registro = vDatos.GetRowCellValue(0, 0)
        Else
            Registro = "Vacio"
        End If
        ''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        ''dgBodegas.CaptionText = "Información de Bodegas"
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim Bodegas As New VB.SysContab.BodegasDB

        'dgBodegas.DataSource = Bodegas.GetListBuscar(txtBuscar.Text).Tables("Bodegas").DefaultView


        'If Bodegas.GetListBuscar(txtBuscar.Text).Tables("Bodegas").Rows.Count = 0 Then
        '    Exit Sub

        'End If
        'Registro = dgBodegas.Item(dgBodegas.CurrentRowIndex, 0)
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarBodega = frmAgregarBodega.Instance()

        Nuevo = "SI"

        ''f.MdiParent = Me.MdiParent
        f.cbEncargado.SelectedValue = -1
        f.ShowDialog()
        f.Dispose()
        Cargar()
        'f.cbZona.SelectedValue = -1
        'f.cbVendedor.SelectedValue = -1
        'f.cbCatalogo.SelectedValue = -1
    End Sub

    Private Sub frmBodegas_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Opened = "NO"
        ''
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione el Bodega que desea Editar")
            Exit Sub
        End If


        Dim f As frmAgregarBodega = frmAgregarBodega.Instance

        Nuevo = "NO"
        Registro = vDatos.GetFocusedRowCellValue("CODIGO")

        'If Registro = "Vacio" Then
        '    XtraMsg("Seleccione el Bodega que desea Editar")
        '    Exit Sub
        'End If

        ''f.MdiParent = Me.MdiParent
        f.ShowDialog()
        f.Dispose()
        Cargar()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        '' Dim resp As DialogResult
        Dim Bodegas As New VB.SysContab.BodegasDB

        'If Registro = "Vacio" Then
        '    MsgBox("Seleccione la Bodega que desea Borrar", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione el Bodega que desea Editar")
            Exit Sub
        End If

        If Not XtraMsg2("Esta seguro que dese borrar la Bodega: " & vDatos.GetFocusedRowCellValue("CODIGO") & " - " & vDatos.GetFocusedRowCellValue("UBICACION")) Then
            Exit Sub
        End If

        'resp = MsgBox("Esta seguro que dese borrar la Bodega: " & dgBodegas.Item(dgBodegas.CurrentRowIndex, 0) & " - " & dgBodegas.Item(dgBodegas.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        'If resp = DialogResult.No Then
        '    Exit Sub
        'End If

        Try
            Bodegas.Delete(vDatos.GetFocusedRowCellValue("CODIGO"))

            Cargar()
        Catch ex As Exception
        End Try

        'Dim Tabla As New DataTable
        ''Dim f As New frmGrupos()
        'Dim ds As New DataSet
        'ds = Bodegas.GetList
        'dgBodegas.DataSource = Bodegas.GetList().Tables("Bodegas").DefaultView
        'Tabla = ds.Tables("Bodegas")

        'If ds.Tables("Bodegas").Rows.Count = 0 Then
        '    Registro = "Vacio"
        'End If
        'r.FormatGenerico(dgBodegas, Tabla)
    End Sub


    Private Sub dgBodegas_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' Registro = dgBodegas.Item(dgBodegas.CurrentRowIndex, 0)
        'dgBodegas.Select(dgBodegas.CurrentRowIndex)
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If e.KeyChar = "'" Then
        '    e.Handled = True
        'End If

    End Sub

    Private Sub frmBodegas_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        ''
    End Sub

    Private Sub frmBodegas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '
    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        '
    End Sub

    Private Sub dgBodegas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        '
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        VistaPrevia(dgDatos, Me.Text)

        'Dim fReportes As New frmReportes
        ''Dim rBodegas As New rptBodegas
        'Dim Bodegas As New VB.SysContab.BodegasDB
        'Dim r As New VB.SysContab.Rutinas

        'Dim rBodegas As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'rBodegas.Load(Application.StartupPath & "\Reportes\rptBodegas.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        'rBodegas.SetDataSource(Bodegas.GetListReporte("%", EmpresaActual))
        'fReportes.crvReportes.ReportSource = rBodegas
        'fReportes.Show()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Start(Application.StartupPath & "\Ayuda\RegISBodegas.chm")
        'Help.ShowHelp(Me, Application.StartupPath & "ayuda/RegISBodegas.chm")
    End Sub
End Class
