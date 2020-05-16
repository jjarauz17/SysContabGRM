Public Class frmComisionesServicios
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmComisionesServicios = Nothing

    Public Shared Function Instance() As frmComisionesServicios
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmComisionesServicios()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

    'Dim servicio As String
    'Dim Cod_Servicio As String

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
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents etNombreProveedor As System.Windows.Forms.Label
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtComision As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgComisionServicio As System.Windows.Forms.DataGrid
    Friend WithEvents cbServicios As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.etNombreProveedor = New System.Windows.Forms.Label
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtComision = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgComisionServicio = New System.Windows.Forms.DataGrid
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.cbServicios = New System.Windows.Forms.ComboBox
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgComisionServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox7.Controls.Add(Me.etNombreProveedor)
        Me.GroupBox7.Controls.Add(Me.etDescripcion)
        Me.GroupBox7.Location = New System.Drawing.Point(40, 9)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(656, 34)
        Me.GroupBox7.TabIndex = 118
        Me.GroupBox7.TabStop = False
        '
        'etNombreProveedor
        '
        Me.etNombreProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etNombreProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNombreProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etNombreProveedor.Location = New System.Drawing.Point(296, 9)
        Me.etNombreProveedor.Name = "etNombreProveedor"
        Me.etNombreProveedor.Size = New System.Drawing.Size(344, 21)
        Me.etNombreProveedor.TabIndex = 114
        Me.etNombreProveedor.Text = "VENDEDOR"
        Me.etNombreProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(0, 9)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(656, 21)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.Text = "COMISIONES POR SERVICIO DEL VENDEDOR: "
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 434)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 52)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(208, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 26)
        Me.cmdAyuda.TabIndex = 5
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(304, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(112, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 26)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(16, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 26)
        Me.cmdBorrar.TabIndex = 3
        Me.cmdBorrar.Text = "Borrar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtComision)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgComisionServicio)
        Me.GroupBox2.Controls.Add(Me.cmdAgregar)
        Me.GroupBox2.Controls.Add(Me.cbServicios)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 385)
        Me.GroupBox2.TabIndex = 116
        Me.GroupBox2.TabStop = False
        '
        'txtComision
        '
        Me.txtComision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComision.Location = New System.Drawing.Point(120, 60)
        Me.txtComision.MaxLength = 5
        Me.txtComision.Name = "txtComision"
        Me.txtComision.Size = New System.Drawing.Size(64, 21)
        Me.txtComision.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(16, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 26)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Comisión %:"
        '
        'dgComisionServicio
        '
        Me.dgComisionServicio.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgComisionServicio.BackColor = System.Drawing.Color.Gainsboro
        Me.dgComisionServicio.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgComisionServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgComisionServicio.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgComisionServicio.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgComisionServicio.CaptionForeColor = System.Drawing.Color.Black
        Me.dgComisionServicio.DataMember = ""
        Me.dgComisionServicio.FlatMode = True
        Me.dgComisionServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgComisionServicio.ForeColor = System.Drawing.Color.Black
        Me.dgComisionServicio.GridLineColor = System.Drawing.Color.Silver
        Me.dgComisionServicio.HeaderBackColor = System.Drawing.Color.Black
        Me.dgComisionServicio.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgComisionServicio.HeaderForeColor = System.Drawing.Color.White
        Me.dgComisionServicio.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgComisionServicio.Location = New System.Drawing.Point(16, 103)
        Me.dgComisionServicio.Name = "dgComisionServicio"
        Me.dgComisionServicio.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgComisionServicio.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgComisionServicio.ReadOnly = True
        Me.dgComisionServicio.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgComisionServicio.SelectionForeColor = System.Drawing.Color.White
        Me.dgComisionServicio.Size = New System.Drawing.Size(632, 268)
        Me.dgComisionServicio.TabIndex = 7
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Appearance.Options.UseFont = True
        Me.cmdAgregar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAgregar.Location = New System.Drawing.Point(368, 26)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAgregar.TabIndex = 2
        Me.cmdAgregar.Text = "Agregar"
        '
        'cbServicios
        '
        Me.cbServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbServicios.Location = New System.Drawing.Point(16, 26)
        Me.cbServicios.Name = "cbServicios"
        Me.cbServicios.Size = New System.Drawing.Size(344, 21)
        Me.cbServicios.TabIndex = 0
        '
        'frmComisionesServicios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(736, 497)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmComisionesServicios"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgComisionServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas()
    Dim Comision As New VB.SysContab.ComisionDB()

    Private Sub frmComisionesServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim Servicio As New VB.SysContab.ServiciosDB()
        Dim Articulos As New VB.SysContab.ArticulosDB()
        'Dim Comision_Servicio As New VB.SysContab.Comisiones_ServiciosDB()

        Dim Vend As New VB.SysContab.VendedoresDB()
        Dim DetalleVendedor As New VB.SysContab.VendedoresDetails()

        Dim Tabla As DataTable
        Dim ds As DataSet

        r.FormularioColor(Me)

        Me.etDescripcion.BackColor = Color.FromArgb(102, 153, 153)
        Me.etNombreProveedor.BackColor = Color.FromArgb(102, 153, 153)

        Articulos.ProductosGetAll("S")

        cbServicios.DataSource = Articulos.ProductosGetAll("S").Tables("Articulos")
        cbServicios.ValueMember = "Codigo"
        cbServicios.DisplayMember = "Nombre"

        'cbServicios.DataSource = Servicio.GetListBuscarCombo("%", EmpresaActual).Tables("SERVICIOS")
        'cbServicios.ValueMember = "CODIGO_SERVICIO"
        'cbServicios.DisplayMember = "NOMBRE"

        DetalleVendedor = Vend.GetDetails(VendedorP)

        ds = Comision.GetList(VendedorP, "S")

        dgComisionServicio.DataSource = ds.Tables("COMISIONES").DefaultView
        Tabla = ds.Tables("COMISIONES")

        r.FormatGenerico(dgComisionServicio, Tabla)

        Me.Text = "Agregar Comisiones por Servicio a Vendedores"

        dgComisionServicio.CaptionText = "Comisiones de Servicios a Vendedores"

        If Comision.GetList(VendedorP, "S").Tables("COMISIONES").Rows.Count = 0 Then
            ComisionServicioP = "Vacio"
        Else
            ComisionServicioP = dgComisionServicio.Item(0, 0)
        End If

        Me.etNombreProveedor.Text = DetalleVendedor.Nombre
        r.ComboAutoComplete(Me.cbServicios)

    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        'Dim cs As New VB.SysContab.Comisiones_ServiciosDB()
        Dim c As New VB.SysContab.ComisionDB()

        If Trim(cbServicios.Text) = "" Then
            MsgBox("Seleccione el Servicio", MsgBoxStyle.Information)
            cbServicios.Focus()
            cbServicios.SelectAll()
            Exit Sub
        End If

        If Me.cbServicios.SelectedValue = Nothing Then
            MsgBox("Servicio no existe", MsgBoxStyle.Information)
            Me.cbServicios.Focus()
            Me.cbServicios.SelectAll()
            Exit Sub
        End If

        If c.GetListNuevo(VendedorP, Me.cbServicios.SelectedValue, "S").Tables("COMISIONES").Rows.Count <> 0 Then
            MsgBox("La comisión de este Servicio ya fue asignada a este vendedor", MsgBoxStyle.Information)
            cbServicios.Focus()
            cbServicios.SelectAll()
            Exit Sub

        End If

        If Trim(txtComision.Text) = "" Then
            MsgBox("Introduzca el porcentaje de Comisión", MsgBoxStyle.Information)
            txtComision.Focus()
            txtComision.SelectAll()
            Exit Sub

        End If

        c.AddItem(VendedorP, Me.cbServicios.SelectedValue, txtComision.Text, "S")
        'c.AddItem(VendedorP, cbArticulos.SelectedValue, txtComision.Text)

        txtComision.Text = ""

        'Dim Comision_Servicio As New VB.SysContab.Comisiones_ServiciosDB()

        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As DataTable
        Dim ds As DataSet

        ds = Comision.GetList(VendedorP, "S")

        dgComisionServicio.DataSource = Comision.GetList(VendedorP, "S").Tables("COMISIONES").DefaultView
        Tabla = ds.Tables("COMISIONES")

        r.FormatGenerico(dgComisionServicio, Tabla)

        ComisionServicioP = dgComisionServicio.Item(dgComisionServicio.CurrentRowIndex, 0)

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub dgComisionServicio_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgComisionServicio.CurrentCellChanged
        ComisionServicioP = dgComisionServicio.Item(dgComisionServicio.CurrentRowIndex, 0)
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult
        'Dim Comision_Servicio As New VB.SysContab.Comisiones_ServiciosDB()

        If ComisionServicioP = "Vacio" Then
            MsgBox("Seleccione el registro que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que desea borrar la comisión del " & dgComisionServicio.Item(dgComisionServicio.CurrentRowIndex, 2) & "% del Servicio: " & dgComisionServicio.Item(dgComisionServicio.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = DialogResult.No Then
            Exit Sub
        End If

        Try
            Comision.Delete(dgComisionServicio.Item(dgComisionServicio.CurrentRowIndex, 0), "S")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As New DataTable()
        'Dim f As New frmGrupos()
        Dim ds As New DataSet()

        ds = Comision.GetList(VendedorP, "P")

        dgComisionServicio.DataSource = Comision.GetList(VendedorP, "S").Tables("Comisiones").DefaultView
        Tabla = ds.Tables("Comisiones")

        If ds.Tables("Comisiones").Rows.Count = 0 Then
            ComisionServicioP = "Vacio"

        Else
            ComisionServicioP = dgComisionServicio.Item(0, 0)
        End If

        r.FormatGenerico(dgComisionServicio, Tabla)
    End Sub

    Private Sub cbServicios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbServicios.KeyPress

        'Dim s As New VB.SysContab.ServiciosDB()
        'If e.KeyChar = "'" Then
        '    e.Handled = True
        '    Exit Sub

        'End If

        'If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
        '    If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
        '        servicio = ""
        '        cbServicios.SelectAll()
        '        Exit Sub

        '    End If

        '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
        '        Exit Sub

        '    End If
        'End If

        'If cbServicios.Text = "" Then
        '    servicio = ""
        '    Exit Sub
        'End If

        'If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
        '    If servicio.Length = 1 Then
        '        servicio = ""
        '    End If

        '    If servicio.Length > 1 Then
        '        servicio = Mid(servicio, 1, servicio.Length - 1)
        '    End If

        '    If cbServicios.Text = "" Then
        '        servicio = ""
        '        Exit Sub

        '    End If

        'Else
        '    servicio = servicio & e.KeyChar

        'End If

        'If s.GetListBuscarCombo(servicio, EmpresaActual).Tables("SERVICIOS").Rows.Count = 0 Then
        '    '
        'Else
        '    cbServicios.SelectedValue = s.GetListBuscarCombo(servicio, EmpresaActual).Tables("SERVICIOS").Rows(0).Item("CODIGO_SERVICIO")
        '    e.Handled = True
        '    cbServicios.SelectionStart = servicio.Length
        '    cbServicios.Select(servicio.Length, cbServicios.Text.Length)

        'End If

    End Sub

    Private Sub cbServicios_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbServicios.Leave
        'Dim S As New VB.SysContab.ServiciosDB()

        'If Trim(cbServicios.Text) = "" Then
        '    servicio = ""
        '    Exit Sub
        'End If

        'If S.GetListBuscarCombo(cbServicios.Text, EmpresaActual).Tables("SERVICIOS").Rows.Count = 0 Then
        '    MsgBox("Servicio no Existe", MsgBoxStyle.Information)
        '    servicio = ""
        '    cbServicios.Focus()
        '    Exit Sub

        'End If

        'cbServicios.SelectedValue = S.GetListBuscarCombo(cbServicios.Text, EmpresaActual).Tables("SERVICIOS").Rows(0).Item("CODIGO_SERVICIO")
        'Cod_Servicio = S.GetListBuscarCombo(cbServicios.Text, EmpresaActual).Tables("SERVICIOS").Rows(0).Item("CODIGO_SERVICIO")

        'servicio = ""

    End Sub

    Private Sub cbServicios_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbServicios.SelectedValueChanged
        'servicio = ""
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes()
        'Dim rComisionesServicios As New rptComisionesServicios()
        'Dim ComisionesServicios As New VB.SysContab.Comisiones_ServiciosDB()
        Dim r As New VB.SysContab.Rutinas()

        Dim rComisionesServicios As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rComisionesServicios.Load(Application.StartupPath & "\Reportes\rptComisionesServicios.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        rComisionesServicios.SetDataSource(Comision.GetListReporte(VendedorP, "S"))
        fReportes.crvReportes.ReportSource = rComisionesServicios
        freportes.Show()

    End Sub

End Class
