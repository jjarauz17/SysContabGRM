Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmFacturasComprasSB
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmFacturasComprasSB = Nothing

    Public Shared Function Instance() As frmFacturasComprasSB
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmFacturasComprasSB()
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
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents dgFacturas As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAnular As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label24 = New System.Windows.Forms.Label
        Me.cbProveedor = New System.Windows.Forms.ComboBox
        Me.dgFacturas = New System.Windows.Forms.DataGrid
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.cBoxFecha = New System.Windows.Forms.CheckBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAnular = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbEstado = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbTipo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbMeses = New System.Windows.Forms.ComboBox
        Me.etInicio = New System.Windows.Forms.Label
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(8, 9)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 25)
        Me.Label24.TabIndex = 147
        Me.Label24.Text = "Proveedor:"
        '
        'cbProveedor
        '
        Me.cbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.Location = New System.Drawing.Point(96, 9)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(320, 21)
        Me.cbProveedor.TabIndex = 146
        '
        'dgFacturas
        '
        Me.dgFacturas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFacturas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgFacturas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgFacturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgFacturas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgFacturas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturas.CaptionForeColor = System.Drawing.Color.Black
        Me.dgFacturas.DataMember = ""
        Me.dgFacturas.FlatMode = True
        Me.dgFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturas.ForeColor = System.Drawing.Color.Black
        Me.dgFacturas.GridLineColor = System.Drawing.Color.Silver
        Me.dgFacturas.HeaderBackColor = System.Drawing.Color.Black
        Me.dgFacturas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturas.HeaderForeColor = System.Drawing.Color.White
        Me.dgFacturas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgFacturas.Location = New System.Drawing.Point(11, 72)
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgFacturas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgFacturas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgFacturas.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturas.Size = New System.Drawing.Size(903, 190)
        Me.dgFacturas.TabIndex = 26
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(816, 9)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 154
        '
        'cBoxFecha
        '
        Me.cBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cBoxFecha.Location = New System.Drawing.Point(712, 9)
        Me.cBoxFecha.Name = "cBoxFecha"
        Me.cBoxFecha.Size = New System.Drawing.Size(96, 25)
        Me.cBoxFecha.TabIndex = 153
        Me.cBoxFecha.Text = "Por Fecha:"
        Me.cBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(396, 5)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 8
        Me.cmdAyuda.Text = "A&yuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(492, 5)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(204, 5)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Reportes"
        '
        'cmdAnular
        '
        Me.cmdAnular.Enabled = False
        Me.cmdAnular.Location = New System.Drawing.Point(300, 5)
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(72, 35)
        Me.cmdAnular.TabIndex = 5
        Me.cmdAnular.Text = "&Anular"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(108, 5)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Ver"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 5)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 26)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "Estado:"
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.Items.AddRange(New Object() {"--Todas--", "Pendientes de Pago", "Canceladas"})
        Me.cbEstado.Location = New System.Drawing.Point(96, 43)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(320, 21)
        Me.cbEstado.TabIndex = 156
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(424, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "Tipo:"
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Items.AddRange(New Object() {"--Todas--", "Pendientes", "Confirmadas", "Anuladas"})
        Me.cbTipo.Location = New System.Drawing.Point(488, 43)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(320, 21)
        Me.cbTipo.TabIndex = 158
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(424, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 25)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "Mes:"
        '
        'cbMeses
        '
        Me.cbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMeses.Items.AddRange(New Object() {"Todos", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMeses.Location = New System.Drawing.Point(488, 9)
        Me.cbMeses.Name = "cbMeses"
        Me.cbMeses.Size = New System.Drawing.Size(192, 23)
        Me.cbMeses.TabIndex = 163
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(709, 161)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(32, 26)
        Me.etInicio.TabIndex = 165
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(816, 43)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha1.TabIndex = 166
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdAyuda)
        Me.PanelControl1.Controls.Add(Me.cmdNuevo)
        Me.PanelControl1.Controls.Add(Me.cmdSalir)
        Me.PanelControl1.Controls.Add(Me.cmdModificar)
        Me.PanelControl1.Controls.Add(Me.cmdImprimir)
        Me.PanelControl1.Controls.Add(Me.cmdAnular)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 268)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(926, 47)
        Me.PanelControl1.TabIndex = 167
        '
        'frmFacturasComprasSB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(926, 315)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.dgFacturas)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbMeses)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cBoxFecha)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cbProveedor)
        Me.Name = "frmFacturasComprasSB"
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    Public Facturas As New VB.SysContab.Facturas_ComprasDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As DataTable
    Dim ds As DataSet
    Public Fecha As String
    Public Fecha1 As String

    Private Sub frmFacturasComprasList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(PanelControl1)
        r.FormularioColor(Me)

        Fecha = ""
        Fecha1 = ""

        cbEstado.SelectedIndex = 0
        Me.cbMeses.SelectedIndex = 0

        Me.dtpFecha.Value = r.Fecha
        Me.dtpFecha1.Value = r.Fecha

        Me.dtpFecha.Enabled = False
        Me.dtpFecha1.Enabled = False
        'Me.dtpFechaPago.Value = r.Fecha

        'If Me.cbEstado.Visible = False Then
        '    Me.cbEstado.SelectedIndex = 1
        'End If

        cbProveedor.DataSource = Proveedores.ProveedoresServiciosList().Tables("Proveedores")
        cbProveedor.ValueMember = "Codigo"
        cbProveedor.DisplayMember = "Nombre"

        cbTipo.DataSource = FormaPago.FormaPagoListAll().Tables("Forma_Pago")
        cbTipo.ValueMember = "Codigo"
        cbTipo.DisplayMember = "Nombre"

        ds = Facturas.FacturasServiciosBasicos(cbProveedor.SelectedValue, Fecha, Fecha1, 0, cbEstado.SelectedIndex, cbTipo.SelectedValue, 3)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView

        Tabla = ds.Tables("Facturas_Compra")

        r.FormatGenerico(Me.dgFacturas, Tabla)

        r.ComboAutoComplete(Me.cbProveedor)

        Me.dgFacturas.CaptionText = "           Facturas de Servicios Básicos"
        Me.dgFacturas.ReadOnly = True
        dtpFecha.Enabled = False
        Me.Text = "F a c t u r a s  d e  S e r v i c i o s  B á s i c o s"

        Me.Refresh()
    End Sub

    Private Sub cbProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.SelectedValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        ds = Facturas.FacturasServiciosBasicos(cbProveedor.SelectedValue, Fecha, Fecha1, Me.cbMeses.SelectedIndex, cbEstado.SelectedIndex, cbTipo.SelectedValue, 3)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub cBoxFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBoxFecha.CheckedChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        If cBoxFecha.Checked = True Then
            cbMeses.SelectedIndex = 0
            Fecha = dtpFecha.Value.Date
            Fecha1 = dtpFecha1.Value.Date

            dtpFecha.Enabled = True
            dtpFecha1.Enabled = True

            cbMeses.Enabled = False
        Else
            dtpFecha.Enabled = False
            dtpFecha1.Enabled = False

            cbMeses.Enabled = True
            Fecha = ""
            Fecha1 = ""
        End If

        ds = Facturas.FacturasServiciosBasicos(cbProveedor.SelectedValue, Fecha, Fecha1, Me.cbMeses.SelectedIndex, cbEstado.SelectedIndex, cbTipo.SelectedValue, 3)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Fecha = dtpFecha.Value.Date
        ds = Facturas.FacturasServiciosBasicos(cbProveedor.SelectedValue, Fecha, Fecha1, Me.cbMeses.SelectedIndex, cbEstado.SelectedIndex, cbTipo.SelectedValue, 3)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Fecha1 = dtpFecha1.Value.Date
        ds = Facturas.FacturasServiciosBasicos(cbProveedor.SelectedValue, Fecha, Fecha1, Me.cbMeses.SelectedIndex, cbEstado.SelectedIndex, cbTipo.SelectedValue, 3)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Inicio = True

        Dim f As frmFacturaProveedores = f.Instance

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized

        f.cbProveedor.Focus()
        Inicio = False
    End Sub

    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbEstado.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If
        ds = Facturas.FacturasServiciosBasicos(cbProveedor.SelectedValue, Fecha, Fecha1, Me.cbMeses.SelectedIndex, cbEstado.SelectedIndex, cbTipo.SelectedValue, 3)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView

    End Sub

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipo.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If
        ds = Facturas.FacturasServiciosBasicos(cbProveedor.SelectedValue, Fecha, Fecha1, Me.cbMeses.SelectedIndex, cbEstado.SelectedIndex, cbTipo.SelectedValue, 3)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/ProvFacServ.chm")
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim f As frmReportesFacturasCompras = frmReportesFacturasCompras.Instance
        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub frmFacturasComprasSB_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    End Sub

    Private Sub cbMeses_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMeses.SelectedIndexChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'If IsNumeric(cbProveedor.SelectedValue) And IsNumeric(cbEstado.SelectedIndex) And IsNumeric(cbTipo.SelectedValue) Then
        ds = Facturas.FacturasServiciosBasicos(cbProveedor.SelectedValue, Fecha, Fecha1, Me.cbMeses.SelectedIndex, cbEstado.SelectedIndex, cbTipo.SelectedValue, 3)
        Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
        'End If
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Inicio = True

        Dim f As frmFacturaProveedores = frmFacturaProveedores.Instance 'frmFacturaProveedoresVer = f.Instance
        f.txtFactura.Text = Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 0)
        f.cbProveedor.EditValue = Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 9)
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized

        f.cbProveedor.Focus()
        Inicio = False
    End Sub

    Private Sub cmdAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnular.Click
        Dim dsFactura As DataSet
        Dim Articulos As New VB.SysContab.ArticulosDB()
        Dim i As Integer

        If Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 0).ToString = "" Then
            MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try

            If Me.dgFacturas.CurrentRowIndex = ds.Tables("Facturas_Compra").Rows.Count - 1 Then
                MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
                Exit Sub
            End If

            'If Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 8) = "Facturada" Then
            '    MsgBox("La factura no puede ser anulada", MsgBoxStyle.Information)
            '    transaccionFacturas.Rollback()
            '    DBConnFacturas.Close()
            '    Exit Sub
            'End If

            If Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 8) = "Anulada" Then
                MsgBox("La factura ya fue anulada", MsgBoxStyle.Information)
                Exit Sub
            End If

            'dsFactura = Facturas.FacturaDetalle(Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 0), Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 9), Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 10))

            If MsgBox("Desea Anular la Factura: " & Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 0) & " del proveedor: " & Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 2) & ".?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                Exit Sub
            End If

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Facturas.UpdateEstado(Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 0), "A", r.Fecha, Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 9))

            Dim DT As DataTable
            DT = ObtieneDatos("SELECT * FROM Comprobantes WHERE Factura = '" & Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 0) & "' AND Proveedor = " & Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 9) & " AND Empresa = " & EmpresaActual)
            If Not DT Is Nothing Then
                With DT.Rows(0)
                    EliminaDistribucion(.Item("Comp_No"), .Item("Per_Id"), .Item("Mes"))
                End With
            End If
            If VB.SysContab.ServiciosBasicos.AnularFactura(Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 0), Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 9)) <> 1 Then
                MsgBox("Hay mas de una factura con el numero " & Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 0) & "para el proveedor " & Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 2), MsgBoxStyle.Critical, "STS-Contab")
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If

            VB.SysContab.Rutinas.okTransaccion()
            ds = Facturas.FacturasServiciosBasicos(cbProveedor.SelectedValue, Fecha, Fecha1, Me.cbMeses.SelectedIndex, cbEstado.SelectedIndex, cbTipo.SelectedValue, 3)
            Me.dgFacturas.DataSource = ds.Tables("Facturas_Compra").DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
            VB.SysContab.Rutinas.ErrorTransaccion()
        End Try
    End Sub
End Class
