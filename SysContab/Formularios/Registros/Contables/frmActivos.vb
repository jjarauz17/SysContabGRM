
Public Class frmActivos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmActivos = Nothing

    Public Shared Function Instance() As frmActivos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmActivos()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgActivos_Fijos As System.Windows.Forms.DataGrid
    Friend WithEvents cmdAsignarActivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDepreciacion As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdDepreciacion = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAsignarActivo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgActivos_Fijos = New System.Windows.Forms.DataGrid()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgActivos_Fijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdDepreciacion, Me.cmdAsignarActivo, Me.cmdSalir, Me.cmdImprimir, Me.cmdBorrar, Me.cmdModificar, Me.cmdNuevo})
        Me.GroupBox1.Location = New System.Drawing.Point(872, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 472)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdDepreciacion
        '
        Me.cmdDepreciacion.Location = New System.Drawing.Point(8, 176)
        Me.cmdDepreciacion.Name = "cmdDepreciacion"
        Me.cmdDepreciacion.Size = New System.Drawing.Size(120, 24)
        Me.cmdDepreciacion.TabIndex = 8
        Me.cmdDepreciacion.Text = "&Calc. Depreciacion"
        '
        'cmdAsignarActivo
        '
        Me.cmdAsignarActivo.Location = New System.Drawing.Point(8, 144)
        Me.cmdAsignarActivo.Name = "cmdAsignarActivo"
        Me.cmdAsignarActivo.Size = New System.Drawing.Size(120, 24)
        Me.cmdAsignarActivo.TabIndex = 7
        Me.cmdAsignarActivo.Text = "&Asignar Activo"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(8, 208)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(8, 80)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(120, 24)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(8, 112)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(120, 24)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(8, 48)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(120, 24)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 16)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 24)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(88, 8)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(512, 20)
        Me.txtBuscar.TabIndex = 9
        Me.txtBuscar.Text = ""
        '
        'dgActivos_Fijos
        '
        Me.dgActivos_Fijos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgActivos_Fijos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgActivos_Fijos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgActivos_Fijos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgActivos_Fijos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgActivos_Fijos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgActivos_Fijos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgActivos_Fijos.DataMember = ""
        Me.dgActivos_Fijos.FlatMode = True
        Me.dgActivos_Fijos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgActivos_Fijos.ForeColor = System.Drawing.Color.Black
        Me.dgActivos_Fijos.GridLineColor = System.Drawing.Color.Silver
        Me.dgActivos_Fijos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgActivos_Fijos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgActivos_Fijos.HeaderForeColor = System.Drawing.Color.White
        Me.dgActivos_Fijos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgActivos_Fijos.Location = New System.Drawing.Point(8, 40)
        Me.dgActivos_Fijos.Name = "dgActivos_Fijos"
        Me.dgActivos_Fijos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgActivos_Fijos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgActivos_Fijos.ReadOnly = True
        Me.dgActivos_Fijos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgActivos_Fijos.SelectionForeColor = System.Drawing.Color.White
        Me.dgActivos_Fijos.Size = New System.Drawing.Size(856, 472)
        Me.dgActivos_Fijos.TabIndex = 8
        '
        'frmActivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.Label1, Me.txtBuscar, Me.dgActivos_Fijos})
        Me.Name = "frmActivos"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgActivos_Fijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmActivos_Fijos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Activos_Fijos As New VB.SysContab.Activo_FijosDB()
        Dim ds As DataSet

        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As DataTable


        '''r.CambiarEstilo(Me)

        ds = Activos_Fijos.GetList("%")

        dgActivos_Fijos.DataSource = Activos_Fijos.GetList("%").Tables("Activo_Fijos").DefaultView
        Tabla = ds.Tables("Activo_Fijos")

        r.FormatGenerico(dgActivos_Fijos, Tabla)

        If ds.Tables("Activo_Fijos").Rows.Count <> 0 Then
            Registro = dgActivos_Fijos.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        dgActivos_Fijos.CaptionText = "Información de Activos Fijos"
        Me.Text = "Mantenimiento de Activos Fijos"
        Me.Refresh()

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim Activos_Fijos As New VB.SysContab.Activo_FijosDB()

        dgActivos_Fijos.DataSource = Activos_Fijos.GetListBuscar(txtBuscar.Text).Tables("Activo_Fijos").DefaultView


        If Activos_Fijos.GetListBuscar(txtBuscar.Text).Tables("Activo_Fijos").Rows.Count = 0 Then
            Exit Sub

        End If

        Registro = dgActivos_Fijos.Item(dgActivos_Fijos.CurrentRowIndex, 0)

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarActivo = f.Instance

        Nuevo = "SI"

        f.MdiParent = Me.MdiParent
        f.Show()

        f.cbCuentaDepreciacion.SelectedValue = -1
        f.cbCuentaGastos.SelectedValue = -1
        f.cbGrupoDepreciacion.SelectedValue = -1

        'f.cbZona.SelectedValue = -1
        'f.cbVendedor.SelectedValue = -1
        'f.cbCatalogo.SelectedValue = -1

    End Sub


    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmAgregarActivo = f.Instance

        Nuevo = "NO"

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Activos_Fijo que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult
        Dim Activos_Fijos As New VB.SysContab.Activo_FijosDB()

        If Registro = "Vacio" Then
            MsgBox("Seleccione el Activos_Fijo que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que dese borrar el Activos_Fijo: " & dgActivos_Fijos.Item(dgActivos_Fijos.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = DialogResult.No Then
            Exit Sub
        End If

        Activos_Fijos.Delete(dgActivos_Fijos.Item(dgActivos_Fijos.CurrentRowIndex, 0))

        MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As New DataTable()
        'Dim f As New frmGrupos()
        Dim ds As New DataSet()

        ds = Activos_Fijos.GetList("%")

        dgActivos_Fijos.DataSource = Activos_Fijos.GetList("%").Tables("Activo_Fijos").DefaultView
        Tabla = ds.Tables("Activo_Fijos")

        If ds.Tables("Activo_Fijos").Rows.Count = 0 Then
            Registro = "Vacio"

        End If

        r.FormatGenerico(dgActivos_Fijos, Tabla)

    End Sub


    Private Sub dgActivos_Fijos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgActivos_Fijos.CurrentCellChanged
        Registro = dgActivos_Fijos.Item(dgActivos_Fijos.CurrentRowIndex, 0)
        'dgActivos_Fijos.Select(dgActivos_Fijos.CurrentRowIndex)

    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True

        End If

    End Sub

    Private Sub cmdAsignarActivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAsignarActivo.Click
        Dim f As frmAsignarActivo = f.Instance

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub frmActivos_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        ''
        'FormPrincipal.IsMdiContainer = False
        'FormPrincipal.Text = NombreEmpresaActual
        'FormPrincipal.Refresh()

    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim f As frmReportesActivos = f.Instance

        f.MdiParent = Me.MdiParent
        f.Show()

        f.cbEmpleados.SelectedValue = 0
        f.cbDepartamentos.SelectedValue = 0
        f.cbCargos.SelectedValue = 0
        f.cbStatus.SelectedIndex = 0

        'f.cbEmpleados.SelectedValue = 0

    End Sub

    Private Sub cmdDepreciacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDepreciacion.Click
        'Dim Activos As New VB.SysContab.Activo_FijosDB()
        'Dim Fecha As Date, Actualizado As Integer
        'Dim fReportes As New frmReportes()
        'Dim Reporte As New rptActivosDepreciacion()
        'Dim ds As New DataSet()
        'Fecha = Now.Date

        'Actualizado = Activos.Calc_Depreciacion(Fecha)

        'If Actualizado = 1 Then
        '    'Imprimir reporte del calculo de la depreciacion
        '    ds = Activos.Depreciacion_Imprimir(Fecha, Fecha)
        '    Reporte.SetDataSource(ds.Tables("Depreciacion_Imprimir"))
        '    fReportes.crvReportes.ReportSource = Reporte
        '    freportes.Show()
        '    MsgBox("Calcula realizado", MsgBoxStyle.Information)
        'Else
        '    MsgBox("El calculo de la depreciación ya se ha realizado con anterioridad", MsgBoxStyle.Exclamation)
        'End If
    End Sub


End Class
