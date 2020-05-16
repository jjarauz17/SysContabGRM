Public Class frmVentasPerdidasLista
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmVentasPerdidasLista = Nothing

    Public Shared Function Instance() As frmVentasPerdidasLista
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmVentasPerdidasLista()
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
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgVentasPerdidas As System.Windows.Forms.DataGrid
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents etInicio As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgVentasPerdidas = New System.Windows.Forms.DataGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cBoxFecha = New System.Windows.Forms.CheckBox()
        Me.cbClientes = New System.Windows.Forms.ComboBox()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgVentasPerdidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdSalir, Me.cmdImprimir, Me.cmdModificar})
        Me.GroupBox1.Location = New System.Drawing.Point(16, 464)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 56)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(200, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 32)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(104, 16)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 32)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdModificar
        '
        Me.cmdModificar.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdModificar.Location = New System.Drawing.Point(8, 16)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 32)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Ver"
        '
        'dgVentasPerdidas
        '
        Me.dgVentasPerdidas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
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
        Me.dgVentasPerdidas.Location = New System.Drawing.Point(16, 48)
        Me.dgVentasPerdidas.Name = "dgVentasPerdidas"
        Me.dgVentasPerdidas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgVentasPerdidas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgVentasPerdidas.ReadOnly = True
        Me.dgVentasPerdidas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgVentasPerdidas.SelectionForeColor = System.Drawing.Color.White
        Me.dgVentasPerdidas.Size = New System.Drawing.Size(976, 408)
        Me.dgVentasPerdidas.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Cliente:"
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha1.Location = New System.Drawing.Point(832, 16)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha1.TabIndex = 170
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha.Location = New System.Drawing.Point(728, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 169
        '
        'cBoxFecha
        '
        Me.cBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.cBoxFecha.Location = New System.Drawing.Point(624, 16)
        Me.cBoxFecha.Name = "cBoxFecha"
        Me.cBoxFecha.Size = New System.Drawing.Size(96, 24)
        Me.cBoxFecha.TabIndex = 168
        Me.cBoxFecha.Text = "Por Fecha:"
        Me.cBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbClientes
        '
        Me.cbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.Items.AddRange(New Object() {"Todas", "Canceladas", "Pendientes", "Vencidas"})
        Me.cbClientes.Location = New System.Drawing.Point(96, 16)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(456, 23)
        Me.cbClientes.TabIndex = 171
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etInicio.Location = New System.Drawing.Point(344, 480)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(32, 24)
        Me.etInicio.TabIndex = 172
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'frmVentasPerdidasLista
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1028, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.etInicio, Me.cbClientes, Me.dtpFecha1, Me.dtpFecha, Me.cBoxFecha, Me.GroupBox1, Me.dgVentasPerdidas, Me.Label1})
        Me.Name = "frmVentasPerdidasLista"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgVentasPerdidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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

            ds = Clientes.VentasPerdidasList(0, "", "")
            dgVentasPerdidas.DataSource = ds.Tables("VentasPerdidas").DefaultView

            Tabla = ds.Tables("VentasPerdidas")

            r.FormatGenerico(dgVentasPerdidas, Tabla)
            r.ComboAutoComplete(Me.cbClientes)

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

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.dgVentasPerdidas.Item(Me.dgVentasPerdidas.CurrentRowIndex, 3) = "TOTAL" Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As DataGridTextBoxCombo.frmVentasPerdidasVer = DataGridTextBoxCombo.frmVentasPerdidasVer.Instance
        f.txtNumero.Text = Me.dgVentasPerdidas.Item(Me.dgVentasPerdidas.CurrentRowIndex, 0)

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
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

        ds = Clientes.VentasPerdidasList(Me.cbClientes.SelectedValue, Fecha, Fecha1)
        Me.dgVentasPerdidas.DataSource = ds.Tables("VentasPerdidas").DefaultView
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        If Fecha = Nothing Then
            Exit Sub
        End If

        Fecha = dtpFecha.Value.Date
        ds = Clientes.VentasPerdidasList(Me.cbClientes.SelectedValue, Fecha, Fecha1)
        Me.dgVentasPerdidas.DataSource = ds.Tables("VentasPerdidas").DefaultView
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        If Fecha1 = Nothing Then
            Exit Sub
        End If

        Fecha1 = dtpFecha1.Value.Date
        ds = Clientes.VentasPerdidasList(Me.cbClientes.SelectedValue, Fecha, Fecha1)
        Me.dgVentasPerdidas.DataSource = ds.Tables("VentasPerdidas").DefaultView
    End Sub

    Private Sub cbClientes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbClientes.SelectedValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Try
            ds = Clientes.VentasPerdidasList(Me.cbClientes.SelectedValue, Fecha, Fecha1)
            Me.dgVentasPerdidas.DataSource = ds.Tables("VentasPerdidas").DefaultView
        Catch ex As Exception
            MsgBox(ex.Message & " cbClientes_SelectedValueChanged")
        End Try
    End Sub

End Class
