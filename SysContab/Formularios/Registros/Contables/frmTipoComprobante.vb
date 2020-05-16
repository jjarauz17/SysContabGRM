Public Class frmTipoComprobante
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmTipoComprobante = Nothing

    Public Shared Function Instance() As frmTipoComprobante
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmTipoComprobante()
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
    Friend WithEvents dgTipoComprobante As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.dgTipoComprobante = New System.Windows.Forms.DataGrid
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.dgTipoComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(104, 9)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(384, 20)
        Me.txtBuscar.TabIndex = 13
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(392, 12)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(488, 12)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(200, 12)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(296, 12)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(104, 12)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 12)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'dgTipoComprobante
        '
        Me.dgTipoComprobante.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgTipoComprobante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTipoComprobante.BackColor = System.Drawing.Color.Gainsboro
        Me.dgTipoComprobante.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgTipoComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgTipoComprobante.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgTipoComprobante.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgTipoComprobante.CaptionForeColor = System.Drawing.Color.Black
        Me.dgTipoComprobante.DataMember = ""
        Me.dgTipoComprobante.FlatMode = True
        Me.dgTipoComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTipoComprobante.ForeColor = System.Drawing.Color.Black
        Me.dgTipoComprobante.GridLineColor = System.Drawing.Color.Silver
        Me.dgTipoComprobante.HeaderBackColor = System.Drawing.Color.Black
        Me.dgTipoComprobante.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgTipoComprobante.HeaderForeColor = System.Drawing.Color.White
        Me.dgTipoComprobante.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgTipoComprobante.Location = New System.Drawing.Point(8, 43)
        Me.dgTipoComprobante.Name = "dgTipoComprobante"
        Me.dgTipoComprobante.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgTipoComprobante.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgTipoComprobante.ReadOnly = True
        Me.dgTipoComprobante.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgTipoComprobante.SelectionForeColor = System.Drawing.Color.White
        Me.dgTipoComprobante.Size = New System.Drawing.Size(557, 97)
        Me.dgTipoComprobante.TabIndex = 11
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdAyuda)
        Me.PanelControl1.Controls.Add(Me.cmdNuevo)
        Me.PanelControl1.Controls.Add(Me.cmdSalir)
        Me.PanelControl1.Controls.Add(Me.cmdModificar)
        Me.PanelControl1.Controls.Add(Me.cmdImprimir)
        Me.PanelControl1.Controls.Add(Me.cmdBorrar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 146)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(577, 56)
        Me.PanelControl1.TabIndex = 15
        '
        'frmTipoComprobante
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(577, 202)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgTipoComprobante)
        Me.Name = "frmTipoComprobante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgTipoComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas()

    Private Sub frmTipoComprobante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(PanelControl1)
        ''
        Dim Tipo_Comprobante As New VB.SysContab.Tipo_ComprobanteDB()
        Dim Tabla As New DataTable()
        Dim ds As New DataSet()

        ''r.CambiarEstilo(Me)

        ds = Tipo_Comprobante.GetList()

        dgTipoComprobante.DataSource = Tipo_Comprobante.GetList().Tables("Tipo_Comprobantes").DefaultView
        Tabla = ds.Tables("Tipo_Comprobantes")

        r.FormatGenerico(dgTipoComprobante, Tabla)

        If ds.Tables("Tipo_Comprobantes").Rows.Count <> 0 Then
            Registro = dgTipoComprobante.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        dgTipoComprobante.CaptionText = "Información de Tipo de Comprobantes"
        Me.Text = "Mantenimiento de Tipo de Comprobantes"
        Me.Refresh()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim t As frmAgregarTipoComprobante = t.Instance
        t.Inicio = True
        Nuevo = "SI"
        t.MdiParent = Me.MdiParent
        t.Show()
        t.Inicio = False
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmAgregarTipoComprobante = f.Instance

        Nuevo = "NO"

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Tipo de Comprobante que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult
        Dim Tipo_Comprobante As New VB.SysContab.Tipo_ComprobanteDB()

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Tipo de Comprobante que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que desea borrar el Tipo de Comprobante: " & dgTipoComprobante.Item(dgTipoComprobante.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = DialogResult.No Then
            Exit Sub
        End If

        Try
            Tipo_Comprobante.Delete(dgTipoComprobante.Item(dgTipoComprobante.CurrentRowIndex, 0))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try

        'MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        'Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As New DataTable()
        'Dim f As New frmGrupos()
        Dim ds As New DataSet()

        '''r.CambiarEstilo(Me)

        ds = Tipo_Comprobante.GetList

        dgTipoComprobante.DataSource = Tipo_Comprobante.GetList().Tables("Tipo_Comprobantes").DefaultView
        Tabla = ds.Tables("Tipo_Comprobantes")

        If ds.Tables("Tipo_Comprobantes").Rows.Count = 0 Then
            Registro = "Vacio"
        Else
            Registro = dgTipoComprobante.Item(0, 0)

        End If

        r.FormatGenerico(dgTipoComprobante, Tabla)

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub dgTipoComprobante_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTipoComprobante.CurrentCellChanged
        Registro = dgTipoComprobante.Item(dgTipoComprobante.CurrentRowIndex, 0)

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim Tipo_Comprobante As New VB.SysContab.Tipo_ComprobanteDB()

        dgTipoComprobante.DataSource = Tipo_Comprobante.GetListBuscar(txtBuscar.Text).Tables("Tipo_Comprobantes").DefaultView


        If Tipo_Comprobante.GetListBuscar(txtBuscar.Text).Tables("Tipo_Comprobantes").Rows.Count = 0 Then
            Exit Sub

        End If

        Registro = dgTipoComprobante.Item(dgTipoComprobante.CurrentRowIndex, 0)

    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmTipoComprobante_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        ''
        'FormPrincipal.IsMdiContainer = False
        'FormPrincipal.Text = NombreEmpresaActual
        'FormPrincipal.Refresh()
    End Sub

    Private Sub frmTipoComprobante_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '''
    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.MouseEnter
        ''
    End Sub

    Private Sub dgTipoComprobante_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTipoComprobante.MouseEnter
        ''
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes()
        'Dim rTipoComprobante As New rptTipoComprobante()
        Dim TipoComprobante As New VB.SysContab.Tipo_ComprobanteDB()

        Dim rTipoComprobante As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rTipoComprobante.Load(Application.StartupPath & "\Reportes\rptTipoComprobante.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        rTipoComprobante.SetDataSource(TipoComprobante.GetListReporte(txtBuscar.Text, EmpresaActual))
        fReportes.crvReportes.ReportSource = rTipoComprobante
        fReportes.Show()

    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "TipoComprobantes")
    End Sub
End Class
