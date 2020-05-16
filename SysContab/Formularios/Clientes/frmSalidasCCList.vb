Public Class frmSalidasCCList
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmSalidasCCList = Nothing

    Public Shared Function Instance() As frmSalidasCCList
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmSalidasCCList()
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
    Friend WithEvents cBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgSalidas As System.Windows.Forms.DataGrid
    Friend WithEvents cbArea As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents etInicio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label24 = New System.Windows.Forms.Label
        Me.cbArea = New System.Windows.Forms.ComboBox
        Me.dgSalidas = New System.Windows.Forms.DataGrid
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.cBoxFecha = New System.Windows.Forms.CheckBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.etInicio = New DevExpress.XtraEditors.LabelControl
        CType(Me.dgSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label24.Text = "Area:"
        '
        'cbArea
        '
        Me.cbArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbArea.Location = New System.Drawing.Point(96, 9)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(304, 21)
        Me.cbArea.TabIndex = 146
        '
        'dgSalidas
        '
        Me.dgSalidas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgSalidas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgSalidas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgSalidas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgSalidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgSalidas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgSalidas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgSalidas.CaptionForeColor = System.Drawing.Color.Black
        Me.dgSalidas.DataMember = ""
        Me.dgSalidas.FlatMode = True
        Me.dgSalidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgSalidas.ForeColor = System.Drawing.Color.Black
        Me.dgSalidas.GridLineColor = System.Drawing.Color.Silver
        Me.dgSalidas.HeaderBackColor = System.Drawing.Color.Black
        Me.dgSalidas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgSalidas.HeaderForeColor = System.Drawing.Color.White
        Me.dgSalidas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgSalidas.Location = New System.Drawing.Point(11, 40)
        Me.dgSalidas.Name = "dgSalidas"
        Me.dgSalidas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgSalidas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgSalidas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgSalidas.SelectionForeColor = System.Drawing.Color.White
        Me.dgSalidas.Size = New System.Drawing.Size(722, 217)
        Me.dgSalidas.TabIndex = 26
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(528, 9)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha1.TabIndex = 154
        '
        'cBoxFecha
        '
        Me.cBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cBoxFecha.Location = New System.Drawing.Point(408, 9)
        Me.cBoxFecha.Name = "cBoxFecha"
        Me.cBoxFecha.Size = New System.Drawing.Size(96, 25)
        Me.cBoxFecha.TabIndex = 153
        Me.cBoxFecha.Text = "Por Fecha:"
        Me.cBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(245, 7)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 8
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(323, 7)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(167, 7)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Reporte"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(661, 7)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        Me.cmdBorrar.Visible = False
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(89, 7)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Ver"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(11, 7)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha2.Location = New System.Drawing.Point(632, 9)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha2.TabIndex = 158
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdNuevo)
        Me.PanelControl1.Controls.Add(Me.cmdAyuda)
        Me.PanelControl1.Controls.Add(Me.cmdModificar)
        Me.PanelControl1.Controls.Add(Me.cmdSalir)
        Me.PanelControl1.Controls.Add(Me.cmdBorrar)
        Me.PanelControl1.Controls.Add(Me.cmdImprimir)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 263)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(745, 51)
        Me.PanelControl1.TabIndex = 159
        '
        'etInicio
        '
        Me.etInicio.Location = New System.Drawing.Point(430, 126)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(6, 13)
        Me.etInicio.TabIndex = 160
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'frmSalidasCCList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(745, 314)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.dgSalidas)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.cBoxFecha)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cbArea)
        Me.Name = "frmSalidasCCList"
        CType(Me.dgSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Dim Proveedores As New VB.SysContab.ProveedoresDB()
    'Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    'Public Ordenes As New VB.SysContab.Ordenes_ComprasDB()
    Public Salidas As New VB.SysContab.GruposCCDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As DataTable
    Dim ds As DataSet
    Public Fecha1 As String
    Public Fecha2 As String

    Private Sub frmSalidasCCList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(PanelControl1)
        ''
        r.FormularioColor(Me)

        Me.dtpFecha1.Value = r.Fecha
        Me.dtpFecha2.Value = r.Fecha

        Fecha1 = ""
        Fecha2 = ""

        Me.cbArea.DataSource = Salidas.AreasList1().Tables("GruposCC")
        Me.cbArea.ValueMember = "Código"
        Me.cbArea.DisplayMember = "Nombre"
        Me.cbArea.SelectedValue = 0

        'cbTipo.DataSource = FormaPago.FormaPagoListAll().Tables("Forma_Pago")
        'cbTipo.ValueMember = "Codigo"
        'cbTipo.DisplayMember = "Nombre"

        ds = Salidas.SalidasList(Me.cbArea.SelectedValue, Fecha1, Fecha2)
        Me.dgSalidas.DataSource = ds.Tables("Tabla").DefaultView

        Tabla = ds.Tables("Tabla")

        r.FormatGenerico(Me.dgSalidas, Tabla)
        r.ComboAutoComplete(Me.cbArea)

        Me.dgSalidas.CaptionText = "           Salidas..."
        Me.dgSalidas.ReadOnly = True
        Me.dtpFecha1.Enabled = False
        Me.dtpFecha2.Enabled = False
        Me.Text = "Salidas..."

        Me.Refresh()
    End Sub

    Private Sub cbArea_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbArea.SelectedValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        ds = Salidas.SalidasList(Me.cbArea.SelectedValue, Fecha1, Fecha2)
        Me.dgSalidas.DataSource = ds.Tables("Tabla").DefaultView
    End Sub

    Private Sub cBoxFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBoxFecha.CheckedChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        If cBoxFecha.Checked = True Then
            Fecha1 = dtpFecha1.Value.Date
            Fecha2 = dtpFecha2.Value.Date
            dtpFecha1.Enabled = True
            dtpFecha2.Enabled = True
        Else
            dtpFecha1.Enabled = False
            dtpFecha2.Enabled = False
            Fecha1 = ""
            Fecha2 = ""
        End If

        ds = Salidas.SalidasList(Me.cbArea.SelectedValue, Fecha1, Fecha2)
        Me.dgSalidas.DataSource = ds.Tables("Tabla").DefaultView
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Fecha1 = dtpFecha1.Value.Date
        Me.dtpFecha2.MinDate = dtpFecha1.Value.Date
        ds = Salidas.SalidasList(Me.cbArea.SelectedValue, Fecha1, Fecha2)
        Me.dgSalidas.DataSource = ds.Tables("Tabla").DefaultView
    End Sub

    Private Sub dtpFecha2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha2.ValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        Fecha2 = dtpFecha2.Value.Date
        Me.dtpFecha1.MaxDate = dtpFecha2.Value.Date
        ds = Salidas.SalidasList(Me.cbArea.SelectedValue, Fecha1, Fecha2)
        Me.dgSalidas.DataSource = ds.Tables("Tabla").DefaultView
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As DataGridTextBoxCombo.frmSalidaCC = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/CientesSalidas.chm")
    End Sub

    Private Sub cmdEntradaAlmacen_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'If dgOrdenes.CurrentRowIndex = ds.Tables("Ordenes_Compra").Rows.Count - 1 Then
        '    MsgBox("Seleccione una Orden de Compra", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If dgOrdenes.Item(dgOrdenes.CurrentRowIndex, 8) = "Facturada" Then
        '    MsgBox("La Orden de Compra ya fue facturada", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'Inicio = True
        'Dim f As DataGridTextBoxCombo.frmFacturarCompra = f.Instance
        'f.txtOrden.Text = dgOrdenes.Item(dgOrdenes.CurrentRowIndex, 0)
        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
        'Inicio = False
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim f As frmSalidasCCReportes = f.Instance
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click

    End Sub
End Class
