

Public Class frmAgrupaciones
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgrupaciones = Nothing


    Public Shared Function Instance() As frmAgrupaciones
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgrupaciones
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgAgrupaciones As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.dgAgrupaciones = New System.Windows.Forms.DataGrid
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.dgAgrupaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(104, 17)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(384, 20)
        Me.txtBuscar.TabIndex = 7
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(401, 6)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(497, 6)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(209, 6)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(305, 6)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(113, 6)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(15, 6)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'dgAgrupaciones
        '
        Me.dgAgrupaciones.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgAgrupaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAgrupaciones.BackColor = System.Drawing.Color.Gainsboro
        Me.dgAgrupaciones.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgAgrupaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgAgrupaciones.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgAgrupaciones.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgAgrupaciones.CaptionForeColor = System.Drawing.Color.Black
        Me.dgAgrupaciones.DataMember = ""
        Me.dgAgrupaciones.FlatMode = True
        Me.dgAgrupaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgAgrupaciones.ForeColor = System.Drawing.Color.Black
        Me.dgAgrupaciones.GridLineColor = System.Drawing.Color.Silver
        Me.dgAgrupaciones.HeaderBackColor = System.Drawing.Color.Black
        Me.dgAgrupaciones.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgAgrupaciones.HeaderForeColor = System.Drawing.Color.White
        Me.dgAgrupaciones.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgAgrupaciones.Location = New System.Drawing.Point(12, 52)
        Me.dgAgrupaciones.Name = "dgAgrupaciones"
        Me.dgAgrupaciones.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgAgrupaciones.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgAgrupaciones.ReadOnly = True
        Me.dgAgrupaciones.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgAgrupaciones.SelectionForeColor = System.Drawing.Color.White
        Me.dgAgrupaciones.Size = New System.Drawing.Size(619, 191)
        Me.dgAgrupaciones.TabIndex = 5
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdAyuda)
        Me.PanelControl1.Controls.Add(Me.cmdModificar)
        Me.PanelControl1.Controls.Add(Me.cmdSalir)
        Me.PanelControl1.Controls.Add(Me.cmdNuevo)
        Me.PanelControl1.Controls.Add(Me.cmdImprimir)
        Me.PanelControl1.Controls.Add(Me.cmdBorrar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 249)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(641, 53)
        Me.PanelControl1.TabIndex = 9
        '
        'frmAgrupaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(641, 302)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgAgrupaciones)
        Me.Name = "frmAgrupaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgAgrupaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmAgrupaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(PanelControl1)
        Dim Agrupaciones As New VB.SysContab.AgrupacionesDB
        Dim r As New VB.SysContab.Rutinas
        Dim Tabla As DataTable
        Dim ds As DataSet

        ''r.CambiarEstilo(Me)

        ds = Agrupaciones.GetList

        dgAgrupaciones.DataSource = Agrupaciones.GetList().Tables("Agrupaciones").DefaultView
        Tabla = ds.Tables("Agrupaciones")

        r.FormatGenerico(dgAgrupaciones, Tabla)

        If ds.Tables("Agrupaciones").Rows.Count <> 0 Then
            Registro = dgAgrupaciones.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        dgAgrupaciones.CaptionText = "Información de Agrupaciones"
        Me.Text = "Mantenimiento de Agrupaciones"
        Me.Refresh()

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim Agrupaciones As New VB.SysContab.AgrupacionesDB

        dgAgrupaciones.DataSource = Agrupaciones.GetListBuscar(txtBuscar.Text).Tables("Agrupaciones").DefaultView


        If Agrupaciones.GetListBuscar(txtBuscar.Text).Tables("Agrupaciones").Rows.Count = 0 Then
            Exit Sub

        End If

        Registro = dgAgrupaciones.Item(dgAgrupaciones.CurrentRowIndex, 0)

    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True

        End If

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmAgregarAgrupacion = f.Instance

        Nuevo = "NO"

        If Registro = "Vacio" Then
            MsgBox("Seleccione la Agrupación que desea Editar", MsgBoxStyle.Information)
            Exit Sub

        End If

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult
        Dim Agrupaciones As New VB.SysContab.AgrupacionesDB

        If Registro = "Vacio" Then
            MsgBox("Seleccione la Agrupación que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que dese borrar la Agrupación: " & dgAgrupaciones.Item(dgAgrupaciones.CurrentRowIndex, 0) & " - " & dgAgrupaciones.Item(dgAgrupaciones.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = DialogResult.No Then
            Exit Sub
        End If

        Agrupaciones.Delete(dgAgrupaciones.Item(dgAgrupaciones.CurrentRowIndex, 0))

        MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        Dim r As New VB.SysContab.Rutinas
        Dim Tabla As New DataTable
        'Dim f As New frmGrupos()
        Dim ds As New DataSet

        ds = Agrupaciones.GetList

        dgAgrupaciones.DataSource = Agrupaciones.GetList().Tables("Agrupaciones").DefaultView
        Tabla = ds.Tables("Agrupaciones")

        If ds.Tables("Agrupaciones").Rows.Count = 0 Then
            Registro = "Vacio"

        End If

        r.FormatGenerico(dgAgrupaciones, Tabla)

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub



    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarAgrupacion = f.Instance

        Nuevo = "SI"

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub dgAgrupaciones_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgAgrupaciones.CurrentCellChanged
        Registro = dgAgrupaciones.Item(dgAgrupaciones.CurrentRowIndex, 0)

    End Sub

    Private Sub frmAgrupaciones_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        ''
        'FormPrincipal.IsMdiContainer = False
        'FormPrincipal.Text = NombreEmpresaActual
        'FormPrincipal.Refresh()

    End Sub

    Private Sub frmAgrupaciones_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        'FormPrincipal.menuRegistros.Visible = False
        'FormPrincipal.menu1.Visible = False
        'FormPrincipal.menuContabilidad.Visible = False
        'FormPrincipal.menuGrupos.Visible = False
        'FormPrincipal.menuInventario.Visible = False

        ''Menu Herramientas
        'FormPrincipal.menuHerramientas.Visible = False

    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.MouseEnter
        'FormPrincipal.menuRegistros.Visible = False
        'FormPrincipal.menu1.Visible = False
        'FormPrincipal.menuContabilidad.Visible = False
        'FormPrincipal.menuGrupos.Visible = False
        'FormPrincipal.menuInventario.Visible = False

        ''Menu Herramientas
        'FormPrincipal.menuHerramientas.Visible = False

    End Sub

    Private Sub dgAgrupaciones_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgAgrupaciones.MouseEnter
        'FormPrincipal.menuRegistros.Visible = False
        'FormPrincipal.menu1.Visible = False
        'FormPrincipal.menuContabilidad.Visible = False
        'FormPrincipal.menuGrupos.Visible = False
        'FormPrincipal.menuInventario.Visible = False

        ''Menu Herramientas
        'FormPrincipal.menuHerramientas.Visible = False
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes
        'Dim Reporte As New rptAgrupaciones

        Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Reporte.Load(Application.StartupPath & "\Reportes\rptAgrupaciones.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Dim ds As New DataSet

        ds = VB.SysContab.AgrupacionesDB.GetListReporte(txtBuscar.Text, EmpresaActual)
        ds.WriteXml(Application.StartupPath & "\xml\Agrupaciones.xml", XmlWriteMode.WriteSchema)

        Reporte.Database.Tables("_GetListAgrupacionesReporte;1").Location = Application.StartupPath & "\xml\Agrupaciones.xml"

        fReportes.crvReportes.ReportSource = Reporte
        fReportes.Show()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "Agrupaciones")
    End Sub
End Class
