Public Class frmOrdenesCompraList
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgOrdenes As System.Windows.Forms.DataGrid
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cBoxFecha = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgOrdenes = New System.Windows.Forms.DataGrid()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdAyuda)
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 454)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1000, 51)
        Me.GroupBox2.TabIndex = 161
        Me.GroupBox2.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(96, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 26)
        Me.cmdAyuda.TabIndex = 8
        Me.cmdAyuda.Text = "A&yuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(184, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 17)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(536, 12)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 160
        '
        'cBoxFecha
        '
        Me.cBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cBoxFecha.Location = New System.Drawing.Point(424, 12)
        Me.cBoxFecha.Name = "cBoxFecha"
        Me.cBoxFecha.Size = New System.Drawing.Size(104, 26)
        Me.cBoxFecha.TabIndex = 159
        Me.cBoxFecha.Text = "Por Fecha:"
        Me.cBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgOrdenes)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(976, 404)
        Me.GroupBox1.TabIndex = 158
        Me.GroupBox1.TabStop = False
        '
        'dgOrdenes
        '
        Me.dgOrdenes.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgOrdenes.BackColor = System.Drawing.Color.Gainsboro
        Me.dgOrdenes.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgOrdenes.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgOrdenes.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgOrdenes.CaptionForeColor = System.Drawing.Color.Black
        Me.dgOrdenes.DataMember = ""
        Me.dgOrdenes.FlatMode = True
        Me.dgOrdenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgOrdenes.ForeColor = System.Drawing.Color.Black
        Me.dgOrdenes.GridLineColor = System.Drawing.Color.Silver
        Me.dgOrdenes.HeaderBackColor = System.Drawing.Color.Black
        Me.dgOrdenes.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgOrdenes.HeaderForeColor = System.Drawing.Color.White
        Me.dgOrdenes.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgOrdenes.Location = New System.Drawing.Point(8, 17)
        Me.dgOrdenes.Name = "dgOrdenes"
        Me.dgOrdenes.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgOrdenes.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgOrdenes.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgOrdenes.SelectionForeColor = System.Drawing.Color.White
        Me.dgOrdenes.Size = New System.Drawing.Size(960, 381)
        Me.dgOrdenes.TabIndex = 26
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(8, 12)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 26)
        Me.Label24.TabIndex = 157
        Me.Label24.Text = "Proveedor:"
        '
        'cbProveedor
        '
        Me.cbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.Location = New System.Drawing.Point(96, 12)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(320, 21)
        Me.cbProveedor.TabIndex = 156
        '
        'frmOrdenesCompraList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(992, 514)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cBoxFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cbProveedor)
        Me.Name = "frmOrdenesCompraList"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Public Ordenes As New VB.SysContab.Ordenes_ComprasDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As DataTable
    Dim ds As DataSet
    Public Fecha As String

    Public Salir As Boolean

    'Public Proveedor As String
    '

    Private Sub frmOrdenesCompraList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r.FormularioColor(Me)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        Me.dtpFecha.Value = r.Fecha
        'Me.dtpFechaDesde.Value = r.Fecha

        Salir = True

        Fecha = ""

        cbProveedor.DataSource = Proveedores.ProveedoresList(3).Tables("Proveedores")
        cbProveedor.ValueMember = "Codigo"
        cbProveedor.DisplayMember = "Nombre"

        ds = Ordenes.OrdenesCompraXProveedor(cbProveedor.SelectedValue, Fecha, 1, 0, 0, 0)
        dgOrdenes.DataSource = ds.Tables("Ordenes_Compra").DefaultView

        Tabla = ds.Tables("Ordenes_Compra")

        r.FormatGenerico(dgOrdenes, Tabla)

        dgOrdenes.CaptionText = "           Ordenes de Compra"
        dgOrdenes.ReadOnly = True
        dtpFecha.Enabled = False

        r.ComboAutoComplete(Me.cbProveedor)

        Me.Text = "O r d e n e s  d e  C o m p r a"

        Me.Refresh()
    End Sub

    Private Sub cbProveedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.SelectedValueChanged
        If IsNumeric(cbProveedor.SelectedValue) Then
            dgOrdenes.DataSource = Ordenes.OrdenesCompraXProveedor(cbProveedor.SelectedValue, Fecha, 1, 0, 1, 0).Tables("Ordenes_Compra").DefaultView
        End If
    End Sub

    Private Sub cBoxFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBoxFecha.CheckedChanged
        dtpFecha.Enabled = cBoxFecha.Checked
        If cBoxFecha.Checked = True Then
            Fecha = dtpFecha.Value.Date
        Else
            Fecha = ""
        End If
        dgOrdenes.DataSource = Ordenes.OrdenesCompraXProveedor(cbProveedor.SelectedValue, Fecha, 1, 0, 1, 0).Tables("Ordenes_Compra").DefaultView
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        If Fecha = Nothing Then
            Exit Sub
        End If

        Fecha = dtpFecha.Value.Date
        dgOrdenes.DataSource = Ordenes.OrdenesCompraXProveedor(cbProveedor.SelectedValue, Fecha, 1, 0, 1, 0).Tables("Ordenes_Compra").DefaultView
    End Sub

    Private Sub dgOrdenes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgOrdenes.DoubleClick
        'If dgOrdenes.CurrentRowIndex = ds.Tables("Ordenes_Compra").Rows.Count - 1 Then
        '    MsgBox("Seleccione una Orden de Compra", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If dgOrdenes.CurrentRowIndex < 0 Then
            MsgBox("Seleccione una Orden de Compra", MsgBoxStyle.Information)
            Exit Sub
        End If

        If dgOrdenes.Item(dgOrdenes.CurrentRowIndex, 8) = "Facturada" Then
            MsgBox("La Orden de Compra ya fue facturada", MsgBoxStyle.Information)
            Exit Sub
        End If
        Salir = False
        Me.Close()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Salir = True
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'If dgOrdenes.CurrentRowIndex = ds.Tables("Ordenes_Compra").Rows.Count - 1 Then
        '    MsgBox("Seleccione una Orden de Compra", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If dgOrdenes.CurrentRowIndex < 0 Then
            MsgBox("Seleccione una Orden de Compra", MsgBoxStyle.Information)
            Exit Sub
        End If


        If dgOrdenes.Item(dgOrdenes.CurrentRowIndex, 8) = "Facturada" Then
            MsgBox("La Orden de Compra ya fue facturada", MsgBoxStyle.Information)
            Exit Sub
        End If
        Salir = False
        Me.Close()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/ProvFacturas.chm")
    End Sub

    Private Sub dgOrdenes_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgOrdenes.Navigate

    End Sub
End Class
