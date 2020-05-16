
Public Class frmDevolucionesClienteBodegaList
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmDevolucionesClienteBodegaList = Nothing

    Public Shared Function Instance() As frmDevolucionesClienteBodegaList
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmDevolucionesClienteBodegaList()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgFacturasClientes As System.Windows.Forms.DataGrid
    Friend WithEvents checkBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdDevoluciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdEntradaBodega As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdEntradaBodega = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDevoluciones = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFactura = New System.Windows.Forms.TextBox
        Me.dgFacturasClientes = New System.Windows.Forms.DataGrid
        Me.checkBoxFecha = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.cbClientes = New System.Windows.Forms.ComboBox
        Me.etInicio = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgFacturasClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdEntradaBodega)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdDevoluciones)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 451)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 60)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdEntradaBodega
        '
        Me.cmdEntradaBodega.Appearance.Options.UseTextOptions = True
        Me.cmdEntradaBodega.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdEntradaBodega.Location = New System.Drawing.Point(480, 17)
        Me.cmdEntradaBodega.Name = "cmdEntradaBodega"
        Me.cmdEntradaBodega.Size = New System.Drawing.Size(80, 35)
        Me.cmdEntradaBodega.TabIndex = 161
        Me.cmdEntradaBodega.Text = "&Entrada a Bodega"
        Me.cmdEntradaBodega.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(120, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdDevoluciones
        '
        Me.cmdDevoluciones.Location = New System.Drawing.Point(16, 17)
        Me.cmdDevoluciones.Name = "cmdDevoluciones"
        Me.cmdDevoluciones.Size = New System.Drawing.Size(80, 35)
        Me.cmdDevoluciones.TabIndex = 160
        Me.cmdDevoluciones.Text = "&Ver Entrada"
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
        Me.dgFacturasClientes.Location = New System.Drawing.Point(12, 84)
        Me.dgFacturasClientes.Name = "dgFacturasClientes"
        Me.dgFacturasClientes.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgFacturasClientes.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgFacturasClientes.ReadOnly = True
        Me.dgFacturasClientes.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgFacturasClientes.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturasClientes.Size = New System.Drawing.Size(1000, 361)
        Me.dgFacturasClientes.TabIndex = 8
        '
        'checkBoxFecha
        '
        Me.checkBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.checkBoxFecha.Location = New System.Drawing.Point(296, 9)
        Me.checkBoxFecha.Name = "checkBoxFecha"
        Me.checkBoxFecha.Size = New System.Drawing.Size(96, 25)
        Me.checkBoxFecha.TabIndex = 150
        Me.checkBoxFecha.Text = "Por Fecha:"
        Me.checkBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(400, 9)
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
        Me.Label5.Location = New System.Drawing.Point(568, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 25)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "Hasta:"
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(464, 9)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha1.TabIndex = 160
        Me.dtpFecha1.Value = New Date(2005, 12, 6, 8, 56, 2, 62)
        '
        'cbClientes
        '
        Me.cbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.Location = New System.Drawing.Point(120, 52)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(480, 23)
        Me.cbClientes.TabIndex = 157
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(616, 517)
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
        'dtpFecha2
        '
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha2.Location = New System.Drawing.Point(632, 9)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha2.TabIndex = 154
        Me.dtpFecha2.Value = New Date(2005, 12, 6, 8, 56, 2, 62)
        '
        'frmDevolucionesClienteBodegaList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 518)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.cbClientes)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.checkBoxFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.dgFacturasClientes)
        Me.Name = "frmDevolucionesClienteBodegaList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgFacturasClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim Clientes As New VB.SysContab.ClientesDB()
    'Dim Cajas As New VB.SysContab.CajasDB()
    'Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim ds As DataSet

    Dim Devoluciones As New VB.SysContab.DevolucionesClienteDB()
    Dim DevolucionBodega As New VB.SysContab.DevolucionesClienteBodegaDB()
    Dim Fecha1 As String
    Dim Fecha2 As String

    Private Sub frmListaFacturaClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabla As DataTable

        Dim dsFormaPago As DataSet
        Dim i As Integer

        ''r.CambiarEstilo(Me)
        r.FormularioColor(Me)

        dtpFecha1.Enabled = False
        dtpFecha2.Enabled = False

        dtpFecha1.Value = CDate(r.Fecha)
        dtpFecha2.Value = CDate(r.Fecha)

        Fecha1 = ""
        Fecha2 = ""

        cbClientes.DataSource = Clientes.GetList.Tables("Clientes")
        cbClientes.ValueMember = "Codigo"
        cbClientes.DisplayMember = "Nombre"

        cbClientes.SelectedValue = 0

        ds = Devoluciones.GetListDevolucionesBodega("", 0, "", "")

        dgFacturasClientes.DataSource = ds.Tables("DevolucionesCliente").DefaultView
        Tabla = ds.Tables("DevolucionesCliente")

        r.FormatGenerico(dgFacturasClientes, Tabla)

        dgFacturasClientes.CaptionText = "Entradas a Bodega por Devoluciones"

        r.ComboAutoComplete(Me.cbClientes)

        Me.Text = "Entradas a Bodega por Devoluciones"
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

    Private Sub frmListaFacturaClientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter


    End Sub

    Private Sub dgFacturasClientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturasClientes.MouseEnter

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
                dtpFecha1.Enabled = True
                dtpFecha2.Enabled = True
                Fecha1 = dtpFecha1.Value.Date
                Fecha2 = dtpFecha2.Value.Date
            Else
                dtpFecha1.Enabled = False
                dtpFecha2.Enabled = False
                Fecha1 = ""
                Fecha2 = ""

            End If
            ds = Devoluciones.GetListDevolucionesBodega(Me.txtFactura.Text, Me.cbClientes.SelectedValue, Fecha1, Fecha2)
            dgFacturasClientes.DataSource = ds.Tables("DevolucionesCliente").DefaultView
        Catch ex As ExecutionEngineException
            MsgBox(ex.Message & " checkBoxFecha_CheckedChanged")
        End Try
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            Fecha1 = dtpFecha1.Value.Date
            Fecha2 = dtpFecha2.Value.Date
            ds = Devoluciones.GetListDevolucionesBodega(Me.txtFactura.Text, Me.cbClientes.SelectedValue, Fecha1, Fecha2)
            dgFacturasClientes.DataSource = ds.Tables("DevolucionesCliente").DefaultView
        Catch ex As Exception
            'MsgBox(ex.Message & " dtpFechaDesde_ValueChanged1")
        End Try
    End Sub

    Private Sub dtpFecha2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha2.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            Fecha1 = dtpFecha1.Value.Date
            Fecha2 = dtpFecha2.Value.Date
            ds = Devoluciones.GetListDevolucionesBodega(Me.txtFactura.Text, Me.cbClientes.SelectedValue, Fecha1, Fecha2)
            dgFacturasClientes.DataSource = ds.Tables("DevolucionesCliente").DefaultView
        Catch ex As Exception
            'MsgBox(ex.Message & " dtpFechaDesde_ValueChanged2")
        End Try
    End Sub

    Private Sub cbClientes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbClientes.SelectedValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            ds = Devoluciones.GetListDevolucionesBodega(Me.txtFactura.Text, Me.cbClientes.SelectedValue, Fecha1, Fecha2)
            dgFacturasClientes.DataSource = ds.Tables("DevolucionesCliente").DefaultView
        Catch ex As Exception
            MsgBox(ex.Message & " cbClientes_SelectedValueChanged")

        End Try
    End Sub

    Private Sub cmdDevoluciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDevoluciones.Click
        'If Clientes.FacturaDetalleDevolucion(dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0)).Tables("Facturas_Ventas").Rows.Count = 0 Then
        '    MsgBox("La Factura no tiene productos para devolución", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'Mostrar la Lista de Facturas

        If Me.dgFacturasClientes.CurrentRowIndex = ds.Tables("DevolucionesCliente").Rows.Count - 1 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As DataGridTextBoxCombo.frmDevolucionClienteBodegaVer = f.Instance
        f.txtDevolucion.Text = Me.dgFacturasClientes.Item(Me.dgFacturasClientes.CurrentRowIndex, 0)
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub txtFactura_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFactura.Leave
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            ds = Devoluciones.GetListDevolucionesBodega(Me.txtFactura.Text, Me.cbClientes.SelectedValue, Fecha1, Fecha2)
            dgFacturasClientes.DataSource = ds.Tables("DevolucionesCliente").DefaultView
        Catch ex As Exception
            MsgBox(ex.Message & " cbClientes_SelectedValueChanged")
        End Try
    End Sub

    Private Sub txtFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFactura.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.cbClientes.Focus()
        End If
    End Sub

    Private Sub cmdEntradaBodega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntradaBodega.Click
        If DevolucionBodega.DevolucionDetalleNew(dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 0), dgFacturasClientes.Item(dgFacturasClientes.CurrentRowIndex, 1)).Tables("Facturas_Ventas").Rows.Count = 0 Then
            MsgBox("La devolucion ya fue procesada...", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As DataGridTextBoxCombo.frmDevolucionClienteBodega = f.Instance
        f.txtDevolucion.Text = Me.dgFacturasClientes.Item(Me.dgFacturasClientes.CurrentRowIndex, 0)
        f.txtFactura.Text = Me.dgFacturasClientes.Item(Me.dgFacturasClientes.CurrentRowIndex, 1)

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmDevolucionesClienteList_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim f As frmDevolucionesClienteList = f.Instance
        f.etInicio.Text = "0"
    End Sub

End Class
