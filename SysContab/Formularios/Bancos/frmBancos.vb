Public Class frmBancos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmBancos = Nothing

    Public Shared Function Instance() As frmBancos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmBancos()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgbancos As DevExpress.XtraGrid.GridControl
    Friend WithEvents Vista As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.dgbancos = New DevExpress.XtraGrid.GridControl()
        Me.Vista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgbancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdAyuda)
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Controls.Add(Me.cmdImprimir)
        Me.GroupBox2.Controls.Add(Me.cmdBorrar)
        Me.GroupBox2.Controls.Add(Me.cmdModificar)
        Me.GroupBox2.Controls.Add(Me.cmdNuevo)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 436)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(711, 57)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(392, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 6
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(488, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 7
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(200, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(296, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(104, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 3
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 2
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'dgbancos
        '
        Me.dgbancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgbancos.Location = New System.Drawing.Point(0, 0)
        Me.dgbancos.MainView = Me.Vista
        Me.dgbancos.Name = "dgbancos"
        Me.dgbancos.Size = New System.Drawing.Size(711, 436)
        Me.dgbancos.TabIndex = 9
        Me.dgbancos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vista})
        '
        'Vista
        '
        Me.Vista.GridControl = Me.dgbancos
        Me.Vista.Name = "Vista"
        Me.Vista.OptionsBehavior.Editable = False
        Me.Vista.OptionsView.ShowAutoFilterRow = True
        Me.Vista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vista.OptionsView.ShowFooter = True
        Me.Vista.OptionsView.ShowGroupPanel = False
        '
        'frmBancos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(711, 493)
        Me.Controls.Add(Me.dgbancos)
        Me.Controls.Add(Me.GroupBox2)
        Me.KeyPreview = True
        Me.Name = "frmBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgbancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmBancos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then cargar()
    End Sub

    Private Sub frmBancos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(GroupBox2)
        Me.cargar()
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Text = "Mantenimiento de Bancos"
        Me.Refresh()
    End Sub
    Public Sub cargar()
        Try
            dgbancos.DataSource = VB.SysContab.BancosDB.GetList().Tables("Bancos")
            If Me.Vista.DataRowCount = 0 Then
                Registro = Me.Vista.GetRowCellValue(0, "Codigo")
            Else
                Registro = "Vacio"
            End If
        Catch ex As Exception
        End Try        
    End Sub

    Private Sub frmBancos_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Opened = "NO"
        '
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarBanco = f.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.cbCatalogo.SelectedValue = -1

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.Vista.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Contab")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.Vista.GetFocusedRowCellValue("Codigo")
        End If

        Dim f As frmAgregarBanco = f.Instance
        Nuevo = "NO"
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.Vista.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Contab")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.Vista.GetFocusedRowCellValue("Codigo")
        End If
        If MsgBox("Esta seguro que dese borrar el Banco: " & Registro & Me.Vista.GetFocusedRowCellValue("Nombre"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If
        VB.SysContab.BancosDB.Delete(Registro)
        Me.cargar()
    End Sub

    Private Sub frmBancos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        'FormPrincipal.menuRegistros.Visible = False
        'FormPrincipal.menu1.Visible = False
        'FormPrincipal.menuContabilidad.Visible = False
        'FormPrincipal.menuGrupos.Visible = False
        'FormPrincipal.menuInventario.Visible = False
        ''Menu Herramientas
        'FormPrincipal.menuHerramientas.Visible = False
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim ldt As New DataSet
        ldt.Tables.Add(VB.SysContab.BancosDB.GetListReporte2(EmpresaActual))
        If Not ldt Is Nothing Then
            Dim fReportes As New frmReportes
            'Dim rBancos As New rptBancos
            Dim rBancos As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rBancos.Load(Application.StartupPath & "\Reportes\rptBancos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            ldt.WriteXml(Application.StartupPath & "\xml\lb.xml", XmlWriteMode.WriteSchema)
            rBancos.Database.Tables(0).Location = Application.StartupPath & "\xml\lb.xml"
            fReportes.crvReportes.ReportSource = rBancos
            fReportes.Show()
            ldt.Dispose()
        End If        
    End Sub
    '
    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/RegBancos.chm")
        'Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "Bancos")
    End Sub


    Private Sub Vista_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles Vista.FocusedRowChanged
        Registro = Me.Vista.GetFocusedRowCellValue("Codigo")
    End Sub
End Class
