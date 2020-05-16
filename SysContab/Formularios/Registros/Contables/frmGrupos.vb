Public Class frmGrupos

    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmGrupos = Nothing

    Public Shared Function Instance() As frmGrupos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmGrupos()
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
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Vista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgGrupos As DevExpress.XtraGrid.GridControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdOrden As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.cmdOrden = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.dgGrupos = New DevExpress.XtraGrid.GridControl
        Me.Vista = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.dgGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(11, 5)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'cmdOrden
        '
        Me.cmdOrden.Enabled = False
        Me.cmdOrden.Location = New System.Drawing.Point(395, 5)
        Me.cmdOrden.Name = "cmdOrden"
        Me.cmdOrden.Size = New System.Drawing.Size(72, 35)
        Me.cmdOrden.TabIndex = 8
        Me.cmdOrden.Text = "&Orden"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(507, 5)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(587, 5)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(203, 5)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(299, 5)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(107, 5)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'dgGrupos
        '
        Me.dgGrupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgGrupos.Location = New System.Drawing.Point(8, 12)
        Me.dgGrupos.MainView = Me.Vista
        Me.dgGrupos.Name = "dgGrupos"
        Me.dgGrupos.Size = New System.Drawing.Size(660, 293)
        Me.dgGrupos.TabIndex = 3
        Me.dgGrupos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vista})
        '
        'Vista
        '
        Me.Vista.GridControl = Me.dgGrupos
        Me.Vista.Name = "Vista"
        Me.Vista.OptionsBehavior.Editable = False
        Me.Vista.OptionsView.ShowAutoFilterRow = True
        Me.Vista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vista.OptionsView.ShowFooter = True
        Me.Vista.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdOrden)
        Me.PanelControl1.Controls.Add(Me.cmdSalir)
        Me.PanelControl1.Controls.Add(Me.cmdAyuda)
        Me.PanelControl1.Controls.Add(Me.cmdNuevo)
        Me.PanelControl1.Controls.Add(Me.cmdModificar)
        Me.PanelControl1.Controls.Add(Me.cmdImprimir)
        Me.PanelControl1.Controls.Add(Me.cmdBorrar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 311)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(680, 46)
        Me.PanelControl1.TabIndex = 4
        '
        'frmGrupos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(680, 357)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.dgGrupos)
        Me.Name = "frmGrupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas()
    Public Tipo As String
    Private Sub frmGrupos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(PanelControl1)
        ''
        Me.cargar()
        ''
        Me.Text = Titulo
        ''
        Me.Refresh()
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name & Tipo)
    End Sub

    Public Sub cargar()
        Dim Grupos As New VB.SysContab.GruposDB
        dgGrupos.DataSource = Grupos.GetList(TipoGrupo).Tables("GRUPOS")
        FormatoGrid(Vista)
        Vista.PopulateColumns()
        '
        If Me.Vista.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.Vista.GetRowCellValue(0, "Código")
            'Vista.Columns(0).Width = 30
            'Vista.Columns(1).Width = 200
            Vista.Columns(1).AppearanceHeader.Options.UseTextOptions = True
            Vista.Columns(1).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Vista.Columns(2).AppearanceHeader.Options.UseTextOptions = True
            Vista.Columns(2).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Vista.Columns(2).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Vista.Columns(3).AppearanceHeader.Options.UseTextOptions = True
            Vista.Columns(3).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        End If
    End Sub
    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmNuevoGrupoBalance = f.Instance
        Dim f1 As frmNuevoGrupoResultado = f1.Instance
        Dim f2 As frmNuevoGrupoPresupuesto = f2.Instance
        Dim f3 As frmNuevoGrupoOrden = f3.Instance

        Nuevo = "SI"

        If TipoGrupo = "B" Then
            f.MdiParent = Me.MdiParent
            f.txtCodigo.Focus()
            f.txtCodigo.SelectAll()
            f.Show()
        ElseIf TipoGrupo = "R" Then
            f1.MdiParent = Me.MdiParent
            f1.Show()
        ElseIf TipoGrupo = "O" Then
            f3.MdiParent = Me.MdiParent
            f3.Show()
        Else
            f2.MdiParent = Me.MdiParent
            f2.Show()
        End If

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

        If Me.Vista.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Contab")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.Vista.GetFocusedRowCellValue("Código")
        End If
        Dim f As frmNuevoGrupoBalance = f.Instance
        Dim f1 As frmNuevoGrupoResultado = f1.Instance
        Dim f2 As frmNuevoGrupoPresupuesto = f2.Instance
        Dim f3 As frmNuevoGrupoOrden = f3.Instance

        Nuevo = "NO"

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Grupo que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If

        If TipoGrupo = "B" Then
            f.MdiParent = Me.MdiParent
            f.Show()
        ElseIf TipoGrupo = "R" Then
            f1.MdiParent = Me.MdiParent
            f1.Show()
        ElseIf TipoGrupo = "O" Then
            f3.MdiParent = Me.MdiParent
            f3.Show()
        Else
            f2.MdiParent = Me.MdiParent
            f2.Show()
        End If

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub


    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click


        If Me.Vista.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Contab")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.Vista.GetFocusedRowCellValue("Código")
        End If

        Dim grupos As New VB.SysContab.GruposDB

        If MsgBox("Esta seguro que dese borrar el Grupo: " & Registro & " - " & Me.Vista.GetFocusedRowCellValue("Nombre"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        grupos.Delete(Registro, TipoGrupo)

        Me.cargar()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        If TipoGrupo = "B" Then
            Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "Balance")
        ElseIf TipoGrupo = "R" Then
            Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "Resultado")
        Else
            Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "Presupuesto")
        End If
    End Sub

    Private Sub frmGrupos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        ''
    End Sub

    Private Sub dgGrupos_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''
    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''
    End Sub

    Private Sub frmGrupos_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        TipoGrupo = "Vacio"
        ''
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes
        'Dim rGrupos As New rptGrupos

        Dim rGrupos As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rGrupos.Load(Application.StartupPath & "\Reportes\rptGrupos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Dim Grupos As New VB.SysContab.GruposDB
        Dim lds As New DataSet
        lds = Grupos.GetListReporte("", EmpresaActual, TipoGrupo)
        lds.WriteXml(Application.StartupPath & "\xml\Grupos.xml", XmlWriteMode.WriteSchema)
        rGrupos.Database.Tables(0).Location = Application.StartupPath & "\xml\Grupos.xml"
        'rGrupos.SetDataSource()
        fReportes.crvReportes.ReportSource = rGrupos
        fReportes.Show()
    End Sub

    Private Sub Vista_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles Vista.FocusedRowChanged
        Registro = Me.Vista.GetFocusedRowCellValue("Código")
    End Sub

    Private Sub cmdOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrden.Click
        Dim f As frmOrdenGrupos = f.Instance
        f.Tipo = TipoGrupo
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub
End Class
