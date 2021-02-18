Imports DevExpress.XtraEditors

Public Class frmCajas
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmCajas = Nothing

    Public Shared Function Instance() As frmCajas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmCajas()
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
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(319, 9)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(515, 9)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(241, 9)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(163, 9)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(85, 9)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(7, 9)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'dgDatos
        '
        Me.dgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDatos.Location = New System.Drawing.Point(12, 12)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(576, 255)
        Me.dgDatos.TabIndex = 21
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos, Me.GridView2})
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
        'GridView2
        '
        Me.GridView2.GridControl = Me.dgDatos
        Me.GridView2.Name = "GridView2"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdAyuda)
        Me.PanelControl1.Controls.Add(Me.cmdBorrar)
        Me.PanelControl1.Controls.Add(Me.cmdSalir)
        Me.PanelControl1.Controls.Add(Me.cmdNuevo)
        Me.PanelControl1.Controls.Add(Me.cmdImprimir)
        Me.PanelControl1.Controls.Add(Me.cmdModificar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 273)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(599, 53)
        Me.PanelControl1.TabIndex = 22
        '
        'frmCajas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(599, 326)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.dgDatos)
        Me.Name = "frmCajas"
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Cajas As New VB.SysContab.CajasDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As New DataTable()
    Dim ds As New DataSet()

    Private Sub frmCajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(PanelControl1)
        '
        Cargar()
        '
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)
        '

        vDatos.Columns("HoraCorte Fijo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        vDatos.Columns("HoraCorte Fijo").DisplayFormat.FormatString = "{0:hh:mm tt}"
        ''
        vDatos.Columns("HoraCorte").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        vDatos.Columns("HoraCorte").DisplayFormat.FormatString = "{0:hh:mm tt}"

        'Try
        '    RolesDB.UsuarioAcciones(PanelControl1)
        '    ''r.FormularioColor(Me)
        '    ''  '''r.CambiarEstilo(Me)



        '    '''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        '    'Me.Text = "C.A.J.A.S"
        '    'Me.Refresh()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Public Sub Cargar()
        ds = Cajas.List()
        dgDatos.DataSource = ds.Tables("Cajas").DefaultView

        'Me.vDatos.PopulateColumns()
        'FormatoGrid(Me.vDatos)
        ''

        'vDatos.Columns("HoraCorte Fijo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        'vDatos.Columns("HoraCorte Fijo").DisplayFormat.FormatString = "{0:hh:mm tt}"
        ' ''
        'vDatos.Columns("HoraCorte").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        'vDatos.Columns("HoraCorte").DisplayFormat.FormatString = "{0:hh:mm tt}"

        ' Me.vDatos.BestFitColumns()
        'dgCajas.DataSource = ds.Tables("Cajas").DefaultView
        'Tabla = ds.Tables("Cajas")
        'r.FormatGenerico(dgCajas, Tabla)
        'If ds.Tables("Cajas").Rows.Count <> 0 Then
        '    Registro = dgCajas.Item(0, 0)
        'Else
        '    Registro = "Vacio"
        'End If
        'dgCajas.CaptionText = "Información de Cajas"
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        If Cajas.PcNombre(Environment.MachineName.ToString).Tables("Cajas").Rows.Count > 0 Then
            XtraMsg("Esta PC: " & Environment.MachineName.ToString & ", Ya esta configurada como Caja!", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        'ShowSplash()
        Dim f As frmAgregarCaja = frmAgregarCaja.Instance()
        Nuevo = "SI"
        'f.MdiParent = Me.MdiParent
        f.Text = "Agregar Caja"
        f.ShowDialog()
        'f.txtNombre.Focus()
        'HideSplash()
        f.Dispose()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/RegCajas.chm")
        'Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "Cajas")
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.dgDatos)

        'Dim fReportes As New frmReportes()
        'Dim rCajas As New rptCajas()
        'Dim Cajas As New VB.SysContab.CajasDB()
        'Dim r As New VB.SysContab.Rutinas()

        'rCajas.SetDataSource(Cajas.GetList2(EmpresaActual))
        'fReportes.crvReportes.ReportSource = rCajas
        'fReportes.Show()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If

        'ShowSplash()
        Dim f As frmAgregarCaja = frmAgregarCaja.Instance()
        Nuevo = "NO"
        f.Caja = Me.vDatos.GetFocusedRowCellValue("Código")
        'f.MdiParent = Me.MdiParent
        f.Text = "Modificar Caja"
        f.ShowDialog()
        'f.WindowState = FormWindowState.Maximized
        'f.txtNombre.Focus()
        ' HideSplash()
        f.Dispose()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.vDatos.FocusedRowHandle < 0 Then
            XtraMessageBox.Show("Seleccione un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Try
            If ObtieneDatos("SELECT * FROM FACTURAS_VENTAS fv WHERE fv.Caja = '" & Me.vDatos.GetFocusedRowCellValue("Código") & "' AND fv.EMPRESA = " & EmpresaActual).Rows.Count > 0 Then
                MsgBox("La Caja Seleccionada Contiene Transacciones, NO puede ser Borrada", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If MessageBox.Show("¿ Seguro de la Operación Solicitada ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            If GuardaDatos("DELETE FROM CAJAS WHERE cj_Codigo = '" & Me.vDatos.GetFocusedRowCellValue("Código") & "' AND Empresa_ID = " & EmpresaActual) Then
                Cargar()
            End If

        Catch ex As Exception
        End Try
    End Sub
End Class
