Public Class frmComision
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmComision = Nothing

    Public Shared Function Instance() As frmComision
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmComision()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

    'Dim articulo As String
    'Dim Cod_Articulo As String

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
    Friend WithEvents dgComision As System.Windows.Forms.DataGrid
    Friend WithEvents cbArticulos As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtComision As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents etNombreProveedor As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgComision = New System.Windows.Forms.DataGrid
        Me.cbArticulos = New System.Windows.Forms.ComboBox
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.txtComision = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.etNombreProveedor = New System.Windows.Forms.Label
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.dgComision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgComision
        '
        Me.dgComision.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgComision.BackColor = System.Drawing.Color.Gainsboro
        Me.dgComision.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgComision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgComision.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgComision.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgComision.CaptionForeColor = System.Drawing.Color.Black
        Me.dgComision.DataMember = ""
        Me.dgComision.FlatMode = True
        Me.dgComision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgComision.ForeColor = System.Drawing.Color.Black
        Me.dgComision.GridLineColor = System.Drawing.Color.Silver
        Me.dgComision.HeaderBackColor = System.Drawing.Color.Black
        Me.dgComision.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgComision.HeaderForeColor = System.Drawing.Color.White
        Me.dgComision.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgComision.Location = New System.Drawing.Point(16, 95)
        Me.dgComision.Name = "dgComision"
        Me.dgComision.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgComision.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgComision.ReadOnly = True
        Me.dgComision.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgComision.SelectionForeColor = System.Drawing.Color.White
        Me.dgComision.Size = New System.Drawing.Size(632, 281)
        Me.dgComision.TabIndex = 7
        '
        'cbArticulos
        '
        Me.cbArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbArticulos.Location = New System.Drawing.Point(16, 26)
        Me.cbArticulos.Name = "cbArticulos"
        Me.cbArticulos.Size = New System.Drawing.Size(344, 21)
        Me.cbArticulos.TabIndex = 0
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 436)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 52)
        Me.GroupBox1.TabIndex = 1
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
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox7.Controls.Add(Me.etNombreProveedor)
        Me.GroupBox7.Controls.Add(Me.etDescripcion)
        Me.GroupBox7.Location = New System.Drawing.Point(40, 9)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(656, 34)
        Me.GroupBox7.TabIndex = 115
        Me.GroupBox7.TabStop = False
        '
        'etNombreProveedor
        '
        Me.etNombreProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etNombreProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNombreProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etNombreProveedor.Location = New System.Drawing.Point(312, 9)
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
        Me.etDescripcion.Text = "COMISIONES POR PRODUCTO DEL VENDEDOR: "
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtComision)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dgComision)
        Me.GroupBox2.Controls.Add(Me.cmdAgregar)
        Me.GroupBox2.Controls.Add(Me.cbArticulos)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 387)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'frmComision
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(736, 497)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmComision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgComision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmComision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Articulo As New VB.SysContab.ArticulosDB()
        Dim Comision As New VB.SysContab.ComisionDB()
        Dim Vend As New VB.SysContab.VendedoresDB()
        Dim DetalleVendedor As New VB.SysContab.VendedoresDetails()

        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As DataTable
        Dim ds As DataSet

        r.FormularioColor(Me)

        Me.etDescripcion.BackColor = Color.FromArgb(102, 153, 153)
        Me.etNombreProveedor.BackColor = Color.FromArgb(102, 153, 153)

        'dsItems = Articulos.ProductosGetAll("P")

        cbArticulos.DataSource = Articulo.ProductosGetAll("P").Tables("Articulos") 'Articulo.GetListBuscarCombo("%", EmpresaActual).Tables("ARTICULOS")
        cbArticulos.ValueMember = "Codigo"
        cbArticulos.DisplayMember = "Nombre"

        DetalleVendedor = Vend.GetDetails(VendedorP)

        ds = Comision.GetList(VendedorP, "P")

        'dgComision.DataSource = Comision.GetList(VendedorP).Tables("COMISIONES").DefaultView
        dgComision.DataSource = ds.Tables("COMISIONES").DefaultView
        Tabla = ds.Tables("COMISIONES")

        r.FormatGenerico(dgComision, Tabla)

        Me.Text = "Agregar Comisiones por Producto a Vendedores"

        dgComision.CaptionText = "Comisiones a Vendedores"

        If Comision.GetList(VendedorP, "P").Tables("COMISIONES").Rows.Count = 0 Then
            ComisionP = "Vacio"
        Else
            ComisionP = dgComision.Item(0, 0)

        End If

        Me.etNombreProveedor.Text = DetalleVendedor.Nombre

        r.ComboAutoComplete(Me.cbArticulos)

    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim c As New VB.SysContab.ComisionDB()

        If Trim(cbArticulos.Text) = "" Then
            MsgBox("Seleccione el producto", MsgBoxStyle.Information)
            cbArticulos.Focus()
            cbArticulos.SelectAll()
            Exit Sub
        End If

        If cbArticulos.SelectedValue = Nothing Then
            MsgBox("Producto no existe", MsgBoxStyle.Information)
            cbArticulos.Focus()
            cbArticulos.SelectAll()
            Exit Sub
        End If

        If c.GetListNuevo(VendedorP, Me.cbArticulos.SelectedValue, "P").Tables("COMISIONES").Rows.Count <> 0 Then
            MsgBox("La comisión de este producto ya fue asignada a este vendedor", MsgBoxStyle.Information)
            cbArticulos.Focus()
            cbArticulos.SelectAll()
            Exit Sub

        End If

        If Trim(txtComision.Text) = "" Then
            MsgBox("Introduzca el porcentaje de Comision", MsgBoxStyle.Information)
            txtComision.Focus()
            txtComision.SelectAll()
            Exit Sub

        End If

        c.AddItem(VendedorP, Me.cbArticulos.SelectedValue, txtComision.Text, "P")
        'c.AddItem(VendedorP, cbArticulos.SelectedValue, txtComision.Text)

        txtComision.Text = ""

        Dim Comision As New VB.SysContab.ComisionDB()

        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As DataTable
        Dim ds As DataSet

        ds = Comision.GetList(VendedorP, "P")

        dgComision.DataSource = Comision.GetList(VendedorP, "P").Tables("COMISIONES").DefaultView
        Tabla = ds.Tables("COMISIONES")

        r.FormatGenerico(dgComision, Tabla)

        ComisionP = dgComision.Item(dgComision.CurrentRowIndex, 0)

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub dgComision_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgComision.CurrentCellChanged
        ComisionP = dgComision.Item(dgComision.CurrentRowIndex, 0)

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult
        Dim Comision As New VB.SysContab.ComisionDB()

        If ComisionP = "Vacio" Then
            MsgBox("Seleccione el registro que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que desea borrar la comisión del " & dgComision.Item(dgComision.CurrentRowIndex, 2) & "% del Producto: " & dgComision.Item(dgComision.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = DialogResult.No Then
            Exit Sub
        End If

        Comision.Delete(dgComision.Item(dgComision.CurrentRowIndex, 0), "P")

        'MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As New DataTable()
        'Dim f As New frmGrupos()
        Dim ds As New DataSet()

        ds = Comision.GetList(VendedorP, "P")

        dgComision.DataSource = Comision.GetList(VendedorP, "P").Tables("Comisiones").DefaultView
        Tabla = ds.Tables("Comisiones")

        If ds.Tables("Comisiones").Rows.Count = 0 Then
            ComisionP = "Vacio"
        Else
            ComisionP = dgComision.Item(0, 0)

        End If

        r.FormatGenerico(dgComision, Tabla)

    End Sub

    Private Sub cbArticulos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbArticulos.KeyPress

        'Dim a As New VB.SysContab.ArticulosDB()
        'If e.KeyChar = "'" Then
        '    e.Handled = True
        '    Exit Sub

        'End If

        'If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
        '    If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
        '        articulo = ""
        '        cbArticulos.SelectAll()
        '        Exit Sub

        '    End If

        '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
        '        Exit Sub

        '    End If
        'End If

        'If cbArticulos.Text = "" Then
        '    articulo = ""
        '    Exit Sub
        'End If

        'If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
        '    If articulo.Length = 1 Then
        '        articulo = ""
        '    End If

        '    If articulo.Length > 1 Then
        '        articulo = Mid(articulo, 1, articulo.Length - 1)
        '    End If

        '    If cbArticulos.Text = "" Then
        '        articulo = ""
        '        Exit Sub

        '    End If

        'Else
        '    articulo = articulo & e.KeyChar

        'End If

        'If a.GetListBuscarCombo(articulo, EmpresaActual).Tables("ARTICULOS").Rows.Count = 0 Then
        '    '
        'Else
        '    cbArticulos.SelectedValue = a.GetListBuscarCombo(articulo, EmpresaActual).Tables("ARTICULOS").Rows(0).Item("CODIGO_ARTICULO")
        '    e.Handled = True
        '    cbArticulos.SelectionStart = articulo.Length
        '    cbArticulos.Select(articulo.Length, cbArticulos.Text.Length)

        'End If

    End Sub

    Private Sub cbArticulos_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbArticulos.Leave
        'Dim a As New VB.SysContab.ArticulosDB()

        'If Trim(cbArticulos.Text) = "" Then
        '    articulo = ""
        '    Exit Sub
        'End If

        'If a.GetListBuscarCombo(cbArticulos.Text, EmpresaActual).Tables("ARTICULOS").Rows.Count = 0 Then
        '    MsgBox("Producto no Existe", MsgBoxStyle.Information)
        '    articulo = ""
        '    cbArticulos.Focus()
        '    Exit Sub

        'End If

        'cbArticulos.SelectedValue = a.GetListBuscarCombo(cbArticulos.Text, EmpresaActual).Tables("ARTICULOS").Rows(0).Item("CODIGO_ARTICULO")
        'Cod_Articulo = a.GetListBuscarCombo(cbArticulos.Text, EmpresaActual).Tables("ARTICULOS").Rows(0).Item("CODIGO_ARTICULO")

        'articulo = ""
        'Cod_Articulo = Me.cbArticulos.SelectedValue
    End Sub

    Private Sub cbArticulos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbArticulos.SelectedValueChanged
        'articulo = ""
    End Sub

    Private Sub frmComision_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'Dim vendedor As New VB.SysContab.VendedoresDB()
        If Nuevo = "SI" Then
            Dim frmChildInstance As frmComisionesServicios = frmComisionesServicios.Instance
            frmChildInstance.MdiParent = Me.MdiParent
            frmChildInstance.Show()
            frmChildInstance.Refresh()
        End If
        'VendedorP = vendedor.GetListComision().Tables("VENDEDORES").Rows(0).Item("Codigo")
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes()
        'Dim rComisiones As New rptComisiones()
        Dim Comisiones As New VB.SysContab.ComisionDB()
        Dim r As New VB.SysContab.Rutinas()

        Dim rComisiones As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rComisiones.Load(Application.StartupPath & "\Reportes\rptComisiones.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        rComisiones.SetDataSource(Comisiones.GetListReporte(VendedorP, "P"))
        fReportes.crvReportes.ReportSource = rComisiones
        freportes.Show()
    End Sub

End Class
