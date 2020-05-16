Public Class frmVentasPerdidasListaDetalle
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmVentasPerdidasListaDetalle = Nothing

    Public Shared Function Instance() As frmVentasPerdidasListaDetalle
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmVentasPerdidasListaDetalle()
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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgVentasPerdidas As System.Windows.Forms.DataGrid
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents cmdVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdVer = New DevExpress.XtraEditors.SimpleButton
        Me.dgVentasPerdidas = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.cBoxFecha = New System.Windows.Forms.CheckBox
        Me.cbClientes = New System.Windows.Forms.ComboBox
        Me.etInicio = New System.Windows.Forms.Label
        Me.cbTipo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtProducto = New System.Windows.Forms.TextBox
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.dgVentasPerdidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(190, 9)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(268, 9)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(112, 9)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdVer
        '
        Me.cmdVer.Enabled = False
        Me.cmdVer.Location = New System.Drawing.Point(16, 9)
        Me.cmdVer.Name = "cmdVer"
        Me.cmdVer.Size = New System.Drawing.Size(90, 35)
        Me.cmdVer.TabIndex = 2
        Me.cmdVer.Text = "&Ver Agrupadas"
        '
        'dgVentasPerdidas
        '
        Me.dgVentasPerdidas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgVentasPerdidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgVentasPerdidas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgVentasPerdidas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgVentasPerdidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgVentasPerdidas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgVentasPerdidas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgVentasPerdidas.CaptionForeColor = System.Drawing.Color.Black
        Me.dgVentasPerdidas.DataMember = ""
        Me.dgVentasPerdidas.FlatMode = True
        Me.dgVentasPerdidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgVentasPerdidas.ForeColor = System.Drawing.Color.Black
        Me.dgVentasPerdidas.GridLineColor = System.Drawing.Color.Silver
        Me.dgVentasPerdidas.HeaderBackColor = System.Drawing.Color.Black
        Me.dgVentasPerdidas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgVentasPerdidas.HeaderForeColor = System.Drawing.Color.White
        Me.dgVentasPerdidas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgVentasPerdidas.Location = New System.Drawing.Point(12, 86)
        Me.dgVentasPerdidas.Name = "dgVentasPerdidas"
        Me.dgVentasPerdidas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgVentasPerdidas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgVentasPerdidas.ReadOnly = True
        Me.dgVentasPerdidas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgVentasPerdidas.SelectionForeColor = System.Drawing.Color.White
        Me.dgVentasPerdidas.Size = New System.Drawing.Size(852, 217)
        Me.dgVentasPerdidas.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 26)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Cliente"
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(768, 17)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha1.TabIndex = 170
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(664, 17)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 169
        '
        'cBoxFecha
        '
        Me.cBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cBoxFecha.Location = New System.Drawing.Point(560, 17)
        Me.cBoxFecha.Name = "cBoxFecha"
        Me.cBoxFecha.Size = New System.Drawing.Size(96, 26)
        Me.cBoxFecha.TabIndex = 168
        Me.cBoxFecha.Text = "Por Fecha"
        Me.cBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbClientes
        '
        Me.cbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.Location = New System.Drawing.Point(96, 17)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(408, 23)
        Me.cbClientes.TabIndex = 171
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(608, 267)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(32, 26)
        Me.etInicio.TabIndex = 172
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Items.AddRange(New Object() {"Todas", "Sin Stock", "Stock Insuficiente"})
        Me.cbTipo.Location = New System.Drawing.Point(664, 52)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(200, 23)
        Me.cbTipo.TabIndex = 174
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(512, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 26)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "Tipo de Vta. Perdida"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 26)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Producto"
        '
        'txtProducto
        '
        Me.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(96, 52)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(408, 22)
        Me.txtProducto.TabIndex = 176
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdAyuda)
        Me.PanelControl1.Controls.Add(Me.cmdImprimir)
        Me.PanelControl1.Controls.Add(Me.cmdSalir)
        Me.PanelControl1.Controls.Add(Me.cmdVer)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 309)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(869, 57)
        Me.PanelControl1.TabIndex = 177
        '
        'frmVentasPerdidasListaDetalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(869, 366)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.cbClientes)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cBoxFecha)
        Me.Controls.Add(Me.dgVentasPerdidas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmVentasPerdidasListaDetalle"
        CType(Me.dgVentasPerdidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    'Dim Facturas As New VB.SysContab.Facturas_Ventas_TemporalDB()
    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim r As New VB.SysContab.Rutinas()

    Dim Tabla As DataTable
    Dim ds As DataSet

    Dim Estado As String

    Public Fecha As String
    Public Fecha1 As String

    Private Sub frmListaOrdenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            RolesDB.UsuarioAcciones(PanelControl1)
            r.FormularioColor(Me)

            Fecha = ""
            Fecha1 = ""

            Me.dtpFecha.Value = r.Fecha
            Me.dtpFecha1.Value = r.Fecha

            Me.dtpFecha.Enabled = False
            Me.dtpFecha1.Enabled = False

            cbClientes.DataSource = Clientes.GetList.Tables("Clientes")
            cbClientes.ValueMember = "Codigo"
            cbClientes.DisplayMember = "Nombre"

            Me.cbTipo.SelectedIndex = 0

            ds = Clientes.VentasPerdidasListDetalle(0, "", "", "", 0)
            dgVentasPerdidas.DataSource = ds.Tables("VentasPerdidas").DefaultView

            Tabla = ds.Tables("VentasPerdidas")

            r.FormatGenerico(dgVentasPerdidas, Tabla)
            r.ComboAutoComplete(Me.cbClientes)

            ' VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

            dgVentasPerdidas.CaptionText = "Ventas Perdidas"
            Me.Text = "Ventas Perdidas"
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmListaOrdenes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

    End Sub

    Private Sub dgVentasPerdidasClientes_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgVentasPerdidas.MouseEnter

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVer.Click
        'If Me.dgVentasPerdidas.Item(Me.dgVentasPerdidas.CurrentRowIndex, 4) = "TOTAL" Then
        '    MsgBox("Seleccione un Registro", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        Dim f As frmVentasPerdidasLista = f.Instance
        'f.txtNumero.Text = Me.dgVentasPerdidas.Item(Me.dgVentasPerdidas.CurrentRowIndex, 0)
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub cBoxFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBoxFecha.CheckedChanged
        If cBoxFecha.Checked = True Then

            Fecha = dtpFecha.Value.Date
            Fecha1 = dtpFecha1.Value.Date
            dtpFecha.Enabled = True
            dtpFecha1.Enabled = True
        Else
            dtpFecha.Enabled = False
            dtpFecha1.Enabled = False
            Fecha = ""
            Fecha1 = ""
        End If

        ds = Clientes.VentasPerdidasListDetalle(Me.cbClientes.SelectedValue, Fecha, Fecha1, Me.txtProducto.Text, Me.cbTipo.SelectedIndex)
        Me.dgVentasPerdidas.DataSource = ds.Tables("VentasPerdidas").DefaultView
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        If Fecha = Nothing Then
            Exit Sub
        End If

        Fecha = dtpFecha.Value.Date
        ds = Clientes.VentasPerdidasListDetalle(Me.cbClientes.SelectedValue, Fecha, Fecha1, Me.txtProducto.Text, Me.cbTipo.SelectedIndex)
        Me.dgVentasPerdidas.DataSource = ds.Tables("VentasPerdidas").DefaultView
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        If Fecha1 = Nothing Then
            Exit Sub
        End If

        Fecha1 = dtpFecha1.Value.Date
        ds = Clientes.VentasPerdidasListDetalle(Me.cbClientes.SelectedValue, Fecha, Fecha1, Me.txtProducto.Text, Me.cbTipo.SelectedIndex)
        Me.dgVentasPerdidas.DataSource = ds.Tables("VentasPerdidas").DefaultView
    End Sub

    Private Sub cbClientes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbClientes.SelectedValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            ds = Clientes.VentasPerdidasListDetalle(Me.cbClientes.SelectedValue, Fecha, Fecha1, Me.txtProducto.Text, Me.cbTipo.SelectedIndex)
            Me.dgVentasPerdidas.DataSource = ds.Tables("VentasPerdidas").DefaultView
        Catch ex As Exception
            MsgBox(ex.Message & " cbClientes_SelectedValueChanged")
        End Try
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipo.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            ds = Clientes.VentasPerdidasListDetalle(Me.cbClientes.SelectedValue, Fecha, Fecha1, Me.txtProducto.Text, Me.cbTipo.SelectedIndex)
            Me.dgVentasPerdidas.DataSource = ds.Tables("VentasPerdidas").DefaultView
        Catch ex As Exception
            MsgBox(ex.Message & " cbClientes_SelectedValueChanged")
        End Try
    End Sub

    Private Sub txtProducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProducto.TextChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            ds = Clientes.VentasPerdidasListDetalle(Me.cbClientes.SelectedValue, Fecha, Fecha1, Me.txtProducto.Text, Me.cbTipo.SelectedIndex)
            Me.dgVentasPerdidas.DataSource = ds.Tables("VentasPerdidas").DefaultView
        Catch ex As Exception
            MsgBox(ex.Message & " cbClientes_SelectedValueChanged")
        End Try
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/ClientesVentasPerdidas.chm")
    End Sub
End Class
