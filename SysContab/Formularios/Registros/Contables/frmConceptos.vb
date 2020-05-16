Public Class frmConceptos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmConceptos = Nothing

    Public Shared Function Instance() As frmConceptos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmConceptos()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgConceptos As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.dgConceptos = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(104, 9)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(384, 20)
        Me.txtBuscar.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 454)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 60)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(392, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(488, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(200, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(296, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(104, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'dgConceptos
        '
        Me.dgConceptos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgConceptos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgConceptos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgConceptos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgConceptos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgConceptos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgConceptos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgConceptos.DataMember = ""
        Me.dgConceptos.FlatMode = True
        Me.dgConceptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgConceptos.ForeColor = System.Drawing.Color.Black
        Me.dgConceptos.GridLineColor = System.Drawing.Color.Silver
        Me.dgConceptos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgConceptos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgConceptos.HeaderForeColor = System.Drawing.Color.White
        Me.dgConceptos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgConceptos.Location = New System.Drawing.Point(24, 43)
        Me.dgConceptos.Name = "dgConceptos"
        Me.dgConceptos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgConceptos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgConceptos.ReadOnly = True
        Me.dgConceptos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgConceptos.SelectionForeColor = System.Drawing.Color.White
        Me.dgConceptos.Size = New System.Drawing.Size(976, 404)
        Me.dgConceptos.TabIndex = 7
        '
        'frmConceptos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgConceptos)
        Me.Name = "frmConceptos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim Conceptos As New VB.SysContab.ConceptosDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As New DataTable()
    Dim ds As New DataSet()

    Private Sub frmConceptos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        r.FormularioColor(Me)

        ds = Conceptos.GetListAll()

        dgConceptos.DataSource = ds.Tables("Conceptos").DefaultView
        Tabla = ds.Tables("Conceptos")

        r.FormatGenerico(dgConceptos, Tabla)

        If ds.Tables("Conceptos").Rows.Count <> 0 Then
            Registro = dgConceptos.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        dgConceptos.CaptionText = "Información de Conceptos Contables"

        Me.Text = "Mantenimiento de Conceptos Contables"
        Me.Refresh()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim c As frmAgregarConcepto = c.Instance
        Nuevo = "SI"
        c.MdiParent = Me.MdiParent
        c.Show()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmAgregarConcepto = f.Instance

        Nuevo = "NO"

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Concepto Contable que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub dgConceptos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgConceptos.CurrentCellChanged
        Registro = dgConceptos.Item(dgConceptos.CurrentRowIndex, 0)

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult
        Dim Conceptos As New VB.SysContab.ConceptosDB()

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Concepto Contable que Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que desea borrar el Concepto Contable: " & dgConceptos.Item(dgConceptos.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = DialogResult.No Then
            Exit Sub
        End If

        Try
            Conceptos.Delete(dgConceptos.Item(dgConceptos.CurrentRowIndex, 0))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try

        ds = Conceptos.GetListAll

        dgConceptos.DataSource = ds.Tables("Conceptos").DefaultView
        Tabla = ds.Tables("Conceptos")

        If ds.Tables("Conceptos").Rows.Count = 0 Then
            Registro = "Vacio"
        Else
            Registro = dgConceptos.Item(0, 0)

        End If

        r.FormatGenerico(dgConceptos, Tabla)

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        dgConceptos.DataSource = Conceptos.GetListBuscar(txtBuscar.Text).Tables("Conceptos").DefaultView

        If Conceptos.GetListBuscar(txtBuscar.Text).Tables("Conceptos").Rows.Count = 0 Then
            Exit Sub
        End If

        Registro = dgConceptos.Item(dgConceptos.CurrentRowIndex, 0)
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmConceptos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        ''
    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.MouseEnter
        ''
    End Sub

    Private Sub dgConceptos_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgConceptos.MouseEnter
        ''
    End Sub

    Private Sub frmConceptos_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes()
        'Dim rConceptos As New rptConceptos()

        Dim rConceptos As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rConceptos.Load(Application.StartupPath & "\Reportes\rptConceptos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        rConceptos.SetDataSource(Conceptos.GetListReporte(txtBuscar.Text, EmpresaActual))
        fReportes.crvReportes.ReportSource = rConceptos
        freportes.Show()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "ConceptosContables")
    End Sub
End Class
