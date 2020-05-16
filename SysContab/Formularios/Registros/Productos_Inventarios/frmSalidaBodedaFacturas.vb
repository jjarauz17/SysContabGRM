
Public Class frmSalidaBodedaFacturas
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmSalidaBodedaFacturas = Nothing

    Public Shared Function Instance() As frmSalidaBodedaFacturas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmSalidaBodedaFacturas()
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
    Friend WithEvents dgFacturasClientes As System.Windows.Forms.DataGrid
    Friend WithEvents cmdPagos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents checkBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents cmdSalidaBodega As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdDevoluciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBuscar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdPagos = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalidaBodega = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFactura = New System.Windows.Forms.TextBox
        Me.dgFacturasClientes = New System.Windows.Forms.DataGrid
        Me.checkBoxFecha = New System.Windows.Forms.CheckBox
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker
        Me.cbClientes = New System.Windows.Forms.ComboBox
        Me.etInicio = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdDevoluciones = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgFacturasClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdPagos)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Controls.Add(Me.cmdSalidaBodega)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 454)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 60)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdPagos
        '
        Me.cmdPagos.Location = New System.Drawing.Point(328, 17)
        Me.cmdPagos.Name = "cmdPagos"
        Me.cmdPagos.Size = New System.Drawing.Size(72, 35)
        Me.cmdPagos.TabIndex = 7
        Me.cmdPagos.Text = "Ver &Pagos"
        Me.cmdPagos.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(172, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(406, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Reporte"
        Me.cmdImprimir.Visible = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(484, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        Me.cmdBorrar.Visible = False
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(250, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Ver"
        Me.cmdModificar.Visible = False
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(94, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Ver Salidas"
        '
        'cmdSalidaBodega
        '
        Me.cmdSalidaBodega.Appearance.Options.UseTextOptions = True
        Me.cmdSalidaBodega.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdSalidaBodega.Location = New System.Drawing.Point(16, 17)
        Me.cmdSalidaBodega.Name = "cmdSalidaBodega"
        Me.cmdSalidaBodega.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalidaBodega.TabIndex = 159
        Me.cmdSalidaBodega.Text = "Sali&da de Bodega"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cliente:"
        '
        'txtFactura
        '
        Me.txtFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(120, 9)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(160, 22)
        Me.txtFactura.TabIndex = 0
        '
        'dgFacturasClientes
        '
        Me.dgFacturasClientes.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgFacturasClientes.BackColor = System.Drawing.Color.Gainsboro
        Me.dgFacturasClientes.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgFacturasClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgFacturasClientes.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgFacturasClientes.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturasClientes.CaptionForeColor = System.Drawing.Color.Black
        Me.dgFacturasClientes.DataMember = ""
        Me.dgFacturasClientes.FlatMode = True
        Me.dgFacturasClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturasClientes.ForeColor = System.Drawing.Color.Black
        Me.dgFacturasClientes.GridLineColor = System.Drawing.Color.Silver
        Me.dgFacturasClientes.HeaderBackColor = System.Drawing.Color.Black
        Me.dgFacturasClientes.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturasClientes.HeaderForeColor = System.Drawing.Color.White
        Me.dgFacturasClientes.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgFacturasClientes.Location = New System.Drawing.Point(8, 86)
        Me.dgFacturasClientes.Name = "dgFacturasClientes"
        Me.dgFacturasClientes.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgFacturasClientes.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgFacturasClientes.ReadOnly = True
        Me.dgFacturasClientes.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgFacturasClientes.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturasClientes.Size = New System.Drawing.Size(1000, 370)
        Me.dgFacturasClientes.TabIndex = 8
        '
        'checkBoxFecha
        '
        Me.checkBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.checkBoxFecha.Location = New System.Drawing.Point(424, 9)
        Me.checkBoxFecha.Name = "checkBoxFecha"
        Me.checkBoxFecha.Size = New System.Drawing.Size(96, 25)
        Me.checkBoxFecha.TabIndex = 150
        Me.checkBoxFecha.Text = "Por Fecha:"
        Me.checkBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(592, 9)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaDesde.TabIndex = 152
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(528, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 25)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Desde:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(696, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 25)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "Hasta:"
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(760, 9)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaHasta.TabIndex = 154
        Me.dtpFechaHasta.Value = New Date(2005, 12, 6, 8, 56, 2, 62)
        '
        'cbClientes
        '
        Me.cbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.Items.AddRange(New Object() {"Todas", "Canceladas", "Pendientes", "Vencidas"})
        Me.cbClientes.Location = New System.Drawing.Point(120, 52)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(480, 23)
        Me.cbClientes.TabIndex = 157
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(616, 480)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(32, 26)
        Me.etInicio.TabIndex = 158
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 25)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "No. Factura:"
        '
        'cmdDevoluciones
        '
        Me.cmdDevoluciones.Location = New System.Drawing.Point(616, 471)
        Me.cmdDevoluciones.Name = "cmdDevoluciones"
        Me.cmdDevoluciones.Size = New System.Drawing.Size(88, 35)
        Me.cmdDevoluciones.TabIndex = 160
        Me.cmdDevoluciones.Text = "Devoluciones"
        Me.cmdDevoluciones.Visible = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(296, 9)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(56, 25)
        Me.cmdBuscar.TabIndex = 161
        Me.cmdBuscar.Text = "B&uscar"
        '
        'frmSalidaBodedaFacturas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 518)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdDevoluciones)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.cbClientes)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.checkBoxFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.dgFacturasClientes)
        Me.Name = "frmSalidaBodedaFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgFacturasClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim Cajas As New VB.SysContab.CajasDB()
    Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim ds As DataSet

    'Public Inicio As Boolean

    Dim BuscarPor As Integer

    Public Fecha1 As String
    Public Fecha2 As String

    Private Sub frmListaFacturaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabla As DataTable

        Dim dsFormaPago As DataSet
        Dim i As Integer

        ''r.CambiarEstilo(Me)
        r.FormularioColor(Me)

        BuscarPor = 1

        Fecha1 = ""
        Fecha2 = ""

        Me.dtpFechaDesde.Value = r.Fecha
        Me.dtpFechaHasta.Value = r.Fecha

        dtpFechaDesde.Enabled = False
        dtpFechaHasta.Enabled = False

        cbClientes.DataSource = Clientes.GetList.Tables("Clientes")
        cbClientes.ValueMember = "Codigo"
        cbClientes.DisplayMember = "Nombre"

        ds = Clientes.DevolucionesFacturas(Me.txtFactura.Text, "", 0, 0, 0, "", "", BuscarPor)

        dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
        Tabla = ds.Tables("Facturas_Ventas")

        r.FormatGenerico(dgFacturasClientes, Tabla)

        If ds.Tables("Facturas_Ventas").Rows.Count <> 0 Then
            Registro = dgFacturasClientes.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        dgFacturasClientes.CaptionText = "Información de Facturas Clientes"

        r.ComboAutoComplete(Me.cbClientes)

        Me.Text = "F a c t u r a s  C l i e n t e s"
        Me.Refresh()

    End Sub

    'Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
    '    Dim f As DataGridTextBoxCombo.frmFacturacionCliente = f.Instance

    '    f.etCaja.Text = Cajas.PcNombre(Environment.MachineName.ToString).Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

    '    NuevaFactura = "SI"

    '    f.MdiParent = Me.MdiParent
    '    f.WindowState = FormWindowState.Maximized
    '    f.Show()

    'End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.dgFacturasClientes.CurrentRowIndex = ds.Tables("Facturas_Ventas").Rows.Count - 1 Then
            MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As DataGridTextBoxCombo.frmFacturacionClienteVer = f.Instance

        Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)

        If Registro = "Vacio" Then
            MsgBox("Seleccione la Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized

    End Sub

    'Private Sub dgFacturasClientes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturasClientes.CurrentCellChanged
    '    Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)
    'End Sub

    Private Sub frmListaFacturaClientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '

    End Sub

    Private Sub dgFacturasClientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturasClientes.MouseEnter
        '
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult
        Dim clientes As New VB.SysContab.ClientesDB()

        Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)

        If Registro = "Vacio" Then
            MsgBox("Seleccione la Factura que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que dese borrar la Factura: " & dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = DialogResult.No Then
            Exit Sub
        End If

        Try
            clientes.FacturaDelete(dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try


        MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As New DataTable()
        'Dim f As New frmGrupos()
        Dim ds As New DataSet()

        'ds = clientes.DevolucionesFacturas("", cbTipoFactura.SelectedValue, cbMeses.SelectedIndex, cbEstado.SelectedIndex)

        dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
        Tabla = ds.Tables("Facturas_Ventas")

        If ds.Tables("Facturas_Ventas").Rows.Count = 0 Then
            Registro = "Vacio"

        End If

        r.FormatGenerico(dgFacturasClientes, Tabla)
    End Sub

    'Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
    '    'Dim fReportes As New frmReportes()
    '    'Dim rFacturas As New rptFacturas()
    '    'Dim Clientes As New VB.SysContab.ClientesDB()

    '    'rFacturas.SetDataSource(Clientes.FacturasPrint(Registro))
    '    'fReportes.crvReportes.ReportSource = rFacturas

    '    'freportes.Show()
    '    Dim f As frmReportesFactura = f.Instance
    '    f.MdiParent = Me.MdiParent
    '    f.WindowState = FormWindowState.Maximized
    '    f.Show()


    'End Sub

    'Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar1.TextChanged
    '    Try
    '        'If cbTipoFactura.Enabled = True Then
    '        dgFacturasClientes.DataSource = Clientes.DevolucionesFacturas(txtBuscar.Text, cbTFCodigo.Text, cbMeses.SelectedIndex, cbEstado.SelectedIndex).Tables("Facturas_Ventas").DefaultView

    '        If Clientes.DevolucionesFacturas(txtBuscar.Text, cbTFCodigo.Text, cbMeses.SelectedIndex, cbEstado.SelectedIndex).Tables("Facturas_Ventas").Rows.Count = 0 Then
    '            Registro = "Vacio"
    '            Exit Sub

    '        End If
    '        'Else
    '        '    dgFacturasClientes.DataSource = Clientes.ListFacturas(txtBuscar.Text).Tables("Facturas_Ventas").DefaultView

    '        '    If Clientes.ListFacturas(txtBuscar.Text).Tables("Facturas_Ventas").Rows.Count = 0 Then
    '        '        Registro = "Vacio"
    '        '        Exit Sub

    '        '    End If
    '        'End If
    '        Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub dgFacturasClientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturasClientes.DoubleClick
        If Me.dgFacturasClientes.CurrentRowIndex = ds.Tables("Facturas_Ventas").Rows.Count - 1 Then
            MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As DataGridTextBoxCombo.frmFacturacionClienteVer = f.Instance
        Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)

        If Registro = "Vacio" Then
            MsgBox("Seleccione la Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub cmdPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPagos.Click
        Dim ds As DataSet
        Registro = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)
        If Registro = "Vacio" Then
            MsgBox("Seleccione la Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        ds = Clientes.CobrosHistorial(Registro)

        If ds.Tables("Cobros").Rows.Count = 0 Then
            MsgBox("La Factura seleccionada no tiene ningún pago", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As frmHistorialCobros = f.Instance

        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()

    End Sub

    'Private Sub cbTipoFactura_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoFactura.SelectedValueChanged
    '    Try
    '        If IsNumeric(cbTipoFactura.SelectedValue) And cbTipoFactura.Enabled = True Then
    '            dgFacturasClientes.DataSource = Clientes.FacturasXTipo(txtBuscar.Text, cbTipoFactura.SelectedValue.ToString, cbMeses.SelectedIndex).Tables("Facturas_Ventas").DefaultView
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub cbTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipo.CheckedChanged
    '    If cbTipo.Checked = True Then
    '        dgFacturasClientes.DataSource = Clientes.FacturasXTipo(txtBuscar.Text, cbTipoFactura.SelectedValue.ToString, cbMeses.SelectedIndex).Tables("Facturas_Ventas").DefaultView
    '        cbTipoFactura.Enabled = True
    '    Else
    '        cbTipoFactura.Enabled = False
    '        dgFacturasClientes.DataSource = Clientes.ListFacturas("").Tables("Facturas_Ventas").DefaultView
    '    End If
    'End Sub


    Private Sub checkBoxFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBoxFecha.CheckedChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            If checkBoxFecha.Checked = True Then
                dtpFechaDesde.Enabled = True
                dtpFechaHasta.Enabled = True
                Fecha1 = dtpFechaDesde.Value.Date
                Fecha2 = dtpFechaHasta.Value.Date

                BuscarPor = 2
            Else
                Fecha1 = ""
                Fecha2 = ""

                BuscarPor = 1

                dtpFechaDesde.Enabled = False
                dtpFechaHasta.Enabled = False
            End If
            ds = Clientes.DevolucionesFacturas(Me.txtFactura.Text, cbClientes.Text, 0, 0, 0, Fecha1, Fecha2, BuscarPor)
            dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
        Catch ex As ExecutionEngineException
            MsgBox(ex.Message & " checkBoxFecha_CheckedChanged")
        End Try
    End Sub

    Private Sub dtpFechaDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            If checkBoxFecha.Checked = True Then
                Fecha1 = dtpFechaDesde.Value.Date
                Fecha2 = dtpFechaHasta.Value.Date
                ds = Clientes.DevolucionesFacturas(cbClientes.Text, 0, dtpFechaDesde.Value.ToShortDateString, dtpFechaHasta.Value.ToShortDateString, 0, Fecha1, Fecha2, BuscarPor)
                dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " dtpFechaDesde_ValueChanged1")
        End Try
    End Sub

    Private Sub dtpFechaHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaHasta.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            If checkBoxFecha.Checked = True Then
                Fecha1 = dtpFechaDesde.Value.Date
                Fecha2 = dtpFechaHasta.Value.Date
                ds = Clientes.DevolucionesFacturas(cbClientes.Text, 0, dtpFechaDesde.Value.ToShortDateString, dtpFechaHasta.Value.ToShortDateString, 0, Fecha1, Fecha2, BuscarPor)
                dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " dtpFechaDesde_ValueChanged2")
        End Try
    End Sub

    'Dim dsBuscar As DataSet
    'Private Sub cbClientes_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbClientes.TextChanged
    '    If Not IsNumeric(Me.cbTipoFactura.SelectedValue) Or Not IsNumeric(Me.cbMeses.SelectedIndex) Or Not IsNumeric(cbClientes.SelectedValue) Or Not IsNumeric(Me.cbEstado.SelectedIndex) Then
    '        Exit Sub
    '    End If

    '    Try
    '        If checkBoxFecha.Checked = True Then
    '            ds = Clientes.FacturasXFecha(cbClientes.Text, cbTipoFactura.SelectedValue, dtpFechaDesde.Value.ToShortDateString, dtpFechaHasta.Value.ToShortDateString, cbEstado.SelectedIndex)
    '        Else
    '            ds = Clientes.DevolucionesFacturas(cbClientes.Text, cbTipoFactura.SelectedValue, cbMeses.SelectedIndex, cbEstado.SelectedIndex)
    '        End If

    '        dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView

    '        If ds.Tables("Facturas_Ventas").Rows.Count = 0 Then
    '            Registro = "Vacio"
    '            Exit Sub
    '        End If

    '        Registro = dgFacturasClientes.Item(0, 0)
    '    Catch ex As Exception
    '        MsgBox(ex.Message & " cbClientes_TextChanged")

    '    End Try
    'End Sub

    Private Sub cbClientes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbClientes.SelectedValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            'If checkBoxFecha.Checked = True Then
            '    ds = Clientes.FacturasXFecha(cbClientes.Text, 0, dtpFechaDesde.Value.ToShortDateString, dtpFechaHasta.Value.ToShortDateString, 0)
            'Else
            ds = Clientes.DevolucionesFacturas(Me.txtFactura.Text, cbClientes.Text, 0, 0, 0, Fecha1, Fecha2, BuscarPor)
            'End If

            dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView

            If ds.Tables("Facturas_Ventas").Rows.Count = 0 Then
                Registro = "Vacio"
                Exit Sub
            End If

            Registro = dgFacturasClientes.Item(0, 0)
        Catch ex As Exception
            MsgBox(ex.Message & " cbClientes_SelectedValueChanged")

        End Try
    End Sub

    Private Sub cmdSalidaBodega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalidaBodega.Click
        Dim ds As New DataSet
        ds = Clientes.FacturaDetalleSalida(dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0))

        If ds.Tables("Facturas_Ventas").Rows.Count = 0 Then
            MsgBox("Esta Factura ya fue totalmente entregada", MsgBoxStyle.Information, "STS-Contab")
            ds.Dispose()
            Exit Sub
        End If

        Dim f As DataGridTextBoxCombo.frmSalidaBodega = f.Instance
        Me.etInicio.Text = "1"
        f.txtFactura.Text = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdDevoluciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDevoluciones.Click


        Dim f As frmDevolucionCliente = frmDevolucionCliente.Instance()
        'Me.etInicio.Text = "1"
        'f.etInicio.Text = "1"
        f.txtFactura.Text = dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub txtFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFactura.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.cmdBuscar.Focus()
        End If
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmSalidaBodegaList = f.Instance
        Me.etInicio.Text = "1"
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            ds = Clientes.DevolucionesFacturas(Me.txtFactura.Text, cbClientes.Text, 0, 0, 0, Fecha1, Fecha2, BuscarPor)
            dgFacturasClientes.DataSource = ds.Tables("Facturas_Ventas").DefaultView

        Catch ex As Exception
            MsgBox(ex.Message & " cbClientes_SelectedValueChanged")

        End Try
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

    End Sub
End Class
