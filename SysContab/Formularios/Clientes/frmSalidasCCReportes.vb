Public Class frmSalidasCCReportes
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmSalidasCCReportes = Nothing

    Public Shared Function Instance() As frmSalidasCCReportes
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmSalidasCCReportes()
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
    Friend WithEvents cbArea As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbSubGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents cbGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFile As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrint As System.Windows.Forms.RadioButton
    Friend WithEvents rbScreen As System.Windows.Forms.RadioButton
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents cmdEntradaAlmacen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbLinear As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label24 = New System.Windows.Forms.Label
        Me.cbArea = New System.Windows.Forms.ComboBox
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.cBoxFecha = New System.Windows.Forms.CheckBox
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker
        Me.etInicio = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cbLinear = New DevExpress.XtraEditors.LookUpEdit
        Me.txtArticulo = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.cbSubGrupos = New System.Windows.Forms.ComboBox
        Me.cbGrupos = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbProveedores = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.rbFile = New System.Windows.Forms.RadioButton
        Me.rbPrint = New System.Windows.Forms.RadioButton
        Me.rbScreen = New System.Windows.Forms.RadioButton
        Me.cmdEntradaAlmacen = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4.SuspendLayout()
        CType(Me.cbLinear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(8, 43)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 26)
        Me.Label24.TabIndex = 147
        Me.Label24.Text = "Area:"
        '
        'cbArea
        '
        Me.cbArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbArea.Location = New System.Drawing.Point(112, 43)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(312, 21)
        Me.cbArea.TabIndex = 1
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(112, 78)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha1.TabIndex = 3
        '
        'cBoxFecha
        '
        Me.cBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cBoxFecha.Location = New System.Drawing.Point(8, 78)
        Me.cBoxFecha.Name = "cBoxFecha"
        Me.cBoxFecha.Size = New System.Drawing.Size(96, 25)
        Me.cBoxFecha.TabIndex = 2
        Me.cBoxFecha.Text = "Por Fecha:"
        Me.cBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha2.Location = New System.Drawing.Point(216, 78)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha2.TabIndex = 4
        '
        'etInicio
        '
        Me.etInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(592, 491)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(88, 26)
        Me.etInicio.TabIndex = 159
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbLinear)
        Me.GroupBox4.Controls.Add(Me.txtArticulo)
        Me.GroupBox4.Controls.Add(Me.txtCodigo)
        Me.GroupBox4.Controls.Add(Me.cbSubGrupos)
        Me.GroupBox4.Controls.Add(Me.cbGrupos)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.cbProveedores)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.cBoxFecha)
        Me.GroupBox4.Controls.Add(Me.dtpFecha1)
        Me.GroupBox4.Controls.Add(Me.dtpFecha2)
        Me.GroupBox4.Controls.Add(Me.cbArea)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(440, 328)
        Me.GroupBox4.TabIndex = 160
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CRITERIOS DE SELECCION"
        '
        'cbLinear
        '
        Me.cbLinear.Location = New System.Drawing.Point(112, 215)
        Me.cbLinear.Name = "cbLinear"
        Me.cbLinear.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbLinear.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cbLinear.Properties.Appearance.Options.UseBackColor = True
        Me.cbLinear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLinear.Properties.LookAndFeel.UseDefaultLookAndFeel = True
        Me.cbLinear.Properties.LookAndFeel.UseWindowsXPTheme = False
        Me.cbLinear.Properties.NullText = ""
        Me.cbLinear.Size = New System.Drawing.Size(312, 20)
        Me.cbLinear.TabIndex = 8
        '
        'txtArticulo
        '
        Me.txtArticulo.Location = New System.Drawing.Point(112, 181)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(312, 21)
        Me.txtArticulo.TabIndex = 7
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(112, 146)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(160, 21)
        Me.txtCodigo.TabIndex = 6
        '
        'cbSubGrupos
        '
        Me.cbSubGrupos.Location = New System.Drawing.Point(112, 284)
        Me.cbSubGrupos.Name = "cbSubGrupos"
        Me.cbSubGrupos.Size = New System.Drawing.Size(312, 23)
        Me.cbSubGrupos.TabIndex = 10
        '
        'cbGrupos
        '
        Me.cbGrupos.Location = New System.Drawing.Point(112, 250)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.Size = New System.Drawing.Size(312, 23)
        Me.cbGrupos.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(8, 284)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 25)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Sub Grupo"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbProveedores
        '
        Me.cbProveedores.Location = New System.Drawing.Point(112, 112)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(312, 23)
        Me.cbProveedores.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 250)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 25)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Grupo"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(8, 215)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 25)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Linea"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 25)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Articulo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Código"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Proveedor"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.rbFile)
        Me.GroupBox8.Controls.Add(Me.rbPrint)
        Me.GroupBox8.Controls.Add(Me.rbScreen)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox8.Location = New System.Drawing.Point(16, 353)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(176, 112)
        Me.GroupBox8.TabIndex = 11
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "SALIDA"
        '
        'rbFile
        '
        Me.rbFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbFile.Location = New System.Drawing.Point(6, 78)
        Me.rbFile.Name = "rbFile"
        Me.rbFile.Size = New System.Drawing.Size(154, 25)
        Me.rbFile.TabIndex = 2
        Me.rbFile.Text = "Archivo"
        Me.rbFile.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbPrint
        '
        Me.rbPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbPrint.Location = New System.Drawing.Point(6, 52)
        Me.rbPrint.Name = "rbPrint"
        Me.rbPrint.Size = New System.Drawing.Size(154, 26)
        Me.rbPrint.TabIndex = 1
        Me.rbPrint.Text = "Impresora"
        Me.rbPrint.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbScreen
        '
        Me.rbScreen.Checked = True
        Me.rbScreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbScreen.Location = New System.Drawing.Point(6, 26)
        Me.rbScreen.Name = "rbScreen"
        Me.rbScreen.Size = New System.Drawing.Size(152, 26)
        Me.rbScreen.TabIndex = 0
        Me.rbScreen.TabStop = True
        Me.rbScreen.Text = "Pantalla"
        Me.rbScreen.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cmdEntradaAlmacen
        '
        Me.cmdEntradaAlmacen.Location = New System.Drawing.Point(1424, 17)
        Me.cmdEntradaAlmacen.Name = "cmdEntradaAlmacen"
        Me.cmdEntradaAlmacen.Size = New System.Drawing.Size(72, 35)
        Me.cmdEntradaAlmacen.TabIndex = 9
        Me.cmdEntradaAlmacen.Text = "&Entrada a Almacen"
        Me.cmdEntradaAlmacen.Visible = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(104, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 13
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(192, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 14
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(16, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 12
        Me.cmdImprimir.Text = "&Aceptar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdEntradaAlmacen)
        Me.GroupBox2.Controls.Add(Me.cmdAyuda)
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Controls.Add(Me.cmdImprimir)
        Me.GroupBox2.Location = New System.Drawing.Point(198, 405)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 60)
        Me.GroupBox2.TabIndex = 155
        Me.GroupBox2.TabStop = False
        '
        'frmSalidasCCReportes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 502)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmSalidasCCReportes"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.cbLinear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Dim Proveedores As New VB.SysContab.ProveedoresDB()
    'Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    'Public Ordenes As New VB.SysContab.Ordenes_ComprasDB()
    Public Salidas As New VB.SysContab.GruposCCDB()
    Dim Proveedor As New VB.SysContab.ProveedoresDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As DataTable
    Dim ds As DataSet
    Public Fecha1 As String
    Public Fecha2 As String

    Private Sub frmSalidasCCReportes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r.FormularioColor(Me)

        Me.dtpFecha1.Value = r.Fecha
        Me.dtpFecha2.Value = r.Fecha

        Fecha1 = ""
        Fecha2 = ""

        Me.cbArea.DataSource = Salidas.AreasList1().Tables("GruposCC")
        Me.cbArea.ValueMember = "Código"
        Me.cbArea.DisplayMember = "Nombre"
        Me.cbArea.SelectedValue = 0

        Me.cbProveedores.DataSource = Proveedor.ProveedoresList(-1).Tables("PROVEEDORES")
        Me.cbProveedores.ValueMember = "Codigo"
        Me.cbProveedores.DisplayMember = "Nombre"
        Me.cbProveedores.SelectedValue = 0

        cbLinear.Properties.DataSource = Salidas.Lineas().Tables(0)
        cbLinear.Properties.PopulateColumns()
        cbLinear.Properties.ValueMember = "Código"
        cbLinear.Properties.DisplayMember = "Nombre"
        cbLinear.Properties.Columns("Código").Visible = False

        'cbTipo.DataSource = FormaPago.FormaPagoListAll().Tables("Forma_Pago")
        'cbTipo.ValueMember = "Codigo"
        'cbTipo.DisplayMember = "Nombre"
        'ds = Salidas.SalidasListReporte(Me.cbArea.SelectedValue, Fecha1, Fecha2)
        'Me.dgSalidas.DataSource = ds.Tables("Tabla").DefaultView
        'Tabla = ds.Tables("Tabla")
        'r.FormatGenerico(Me.dgSalidas, Tabla)
        'r.ComboAutoComplete(Me.cbArea)
        'Me.dgSalidas.CaptionText = "           Salidas..."
        'Me.dgSalidas.ReadOnly = True

        Me.dtpFecha1.Enabled = False
        Me.dtpFecha2.Enabled = False
        Me.Text = "Salidas..."

        Me.Refresh()
    End Sub

    Private Sub cbArea_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbArea.SelectedValueChanged
        If etInicio.Text = "1" Then
            Exit Sub
        End If

        'ds = Salidas.SalidasListReporte(Me.cbArea.SelectedValue, Fecha1, Fecha2)
        'Me.dgSalidas.DataSource = ds.Tables("Tabla").DefaultView
    End Sub

    Private Sub cBoxFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBoxFecha.CheckedChanged
        'Desactivado el 010307 porque no deja hacer busqueda por fecha.
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        If cBoxFecha.Checked = True Then
            dtpFecha1.Enabled = True
            dtpFecha2.Enabled = True
            Fecha1 = dtpFecha1.Value.Date
            Fecha2 = dtpFecha2.Value.Date
        ElseIf cBoxFecha.Checked = False Then
            dtpFecha1.Enabled = False
            dtpFecha2.Enabled = False
            Fecha1 = ""
            Fecha2 = ""
        End If

        'ds = Salidas.SalidasListReporte(Me.cbArea.SelectedValue, Fecha1, Fecha2)
        'Me.dgSalidas.DataSource = ds.Tables("Tabla").DefaultView
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        'Desactivado el 010307 porque no deja hacer busqueda por fecha.
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        Fecha1 = dtpFecha1.Value.Date
        Me.dtpFecha2.MinDate = dtpFecha1.Value.Date
        'ds = Salidas.SalidasListReporte(Me.cbArea.SelectedValue, Fecha1, Fecha2)
        'Me.dgSalidas.DataSource = ds.Tables("Tabla").DefaultView
    End Sub

    Private Sub dtpFecha2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha2.ValueChanged
        'Desactivado el 010307 porque no deja hacer busqueda por fecha.
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        Fecha2 = dtpFecha2.Value.Date
        Me.dtpFecha1.MaxDate = dtpFecha2.Value.Date
        'ds = Salidas.SalidasListReporte(Me.cbArea.SelectedValue, Fecha1, Fecha2)
        'Me.dgSalidas.DataSource = ds.Tables("Tabla").DefaultView
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    'Private Sub cmdEntradaAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntradaAlmacen.Click
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
    'End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes
        'Dim rSalidas As New rptSalidasCC

        Dim rSalidas As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rSalidas.Load(Application.StartupPath & "\Reportes\rptSalidasCC.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        ds = Salidas.SalidasListReporte(cbArea.SelectedValue, Fecha1, Fecha2, cbProveedores.SelectedValue, txtCodigo.Text, _
             txtArticulo.Text, IIf(cbLinear.EditValue Is Nothing, 0, cbLinear.EditValue), IIf(cbGrupos.SelectedValue Is Nothing, _
             0, cbGrupos.SelectedValue), IIf(cbSubGrupos.SelectedValue Is Nothing, 0, cbSubGrupos.SelectedValue))
        ds.WriteXml(Application.StartupPath & "\xml\RepSalidas.xml", XmlWriteMode.WriteSchema)
        rSalidas.Database.Tables("_SalidasCCReportes").Location = Application.StartupPath & "\xml\RepSalidas.xml"
        rSalidas.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
        'rSalidas.SetDataSource(ds)
        fReportes.crvReportes.ReportSource = rSalidas

        If rbScreen.Checked = True Then
            fReportes.Show()
        ElseIf rbPrint.Checked = True Then
            fReportes.crvReportes.PrintReport()
        Else
            fReportes.crvReportes.ExportReport()
        End If
    End Sub

    Private Sub cbLineas_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cbGrupos.DataSource = Salidas.Grupos(IIf(cbLinear.EditValue Is Nothing, 0, cbLinear.EditValue)).Tables("GruposCC")
        cbGrupos.ValueMember = "Código"
        cbGrupos.DisplayMember = "Nombre"
    End Sub

    Private Sub cbGrupos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrupos.SelectedValueChanged
        cbSubGrupos.DataSource = Salidas.SubGrupos(Me.cbGrupos.SelectedValue).Tables("GruposCC")
        cbSubGrupos.ValueMember = "Código"
        cbSubGrupos.DisplayMember = "Nombre"
    End Sub
End Class
