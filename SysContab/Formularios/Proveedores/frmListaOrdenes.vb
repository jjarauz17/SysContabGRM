Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class frmListaOrdenes
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmListaOrdenes = Nothing

    Public Shared Function Instance() As frmListaOrdenes
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmListaOrdenes()
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
    Friend WithEvents cmdFacturar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rbTodas As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacturadas As System.Windows.Forms.RadioButton
    Friend WithEvents rbPendientes As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents gridOrdenes As DevExpress.XtraGrid.GridControl
    Friend WithEvents vOrdenes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDesign As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnDesign = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdFacturar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbTodas = New System.Windows.Forms.RadioButton()
        Me.rbFacturadas = New System.Windows.Forms.RadioButton()
        Me.rbPendientes = New System.Windows.Forms.RadioButton()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbClientes = New System.Windows.Forms.ComboBox()
        Me.gridOrdenes = New DevExpress.XtraGrid.GridControl()
        Me.vOrdenes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.gbTipo.SuspendLayout()
        CType(Me.gridOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDesign
        '
        Me.btnDesign.Enabled = False
        Me.btnDesign.Location = New System.Drawing.Point(449, 5)
        Me.btnDesign.Name = "btnDesign"
        Me.btnDesign.Size = New System.Drawing.Size(80, 35)
        Me.btnDesign.TabIndex = 8
        Me.btnDesign.Text = "&Diseño"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(363, 5)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(80, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(535, 5)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(191, 5)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(80, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(277, 5)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(80, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(105, 5)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(80, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdFacturar
        '
        Me.cmdFacturar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdFacturar.Location = New System.Drawing.Point(673, 9)
        Me.cmdFacturar.Name = "cmdFacturar"
        Me.cmdFacturar.Size = New System.Drawing.Size(72, 35)
        Me.cmdFacturar.TabIndex = 7
        Me.cmdFacturar.Text = "&Facturar"
        Me.cmdFacturar.Visible = False
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 5)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(80, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Cliente:"
        Me.Label1.Visible = False
        '
        'gbTipo
        '
        Me.gbTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTipo.BackColor = System.Drawing.Color.Transparent
        Me.gbTipo.Controls.Add(Me.rbTodas)
        Me.gbTipo.Controls.Add(Me.rbFacturadas)
        Me.gbTipo.Controls.Add(Me.rbPendientes)
        Me.gbTipo.Controls.Add(Me.TextBox6)
        Me.gbTipo.Controls.Add(Me.Label12)
        Me.gbTipo.Controls.Add(Me.Label17)
        Me.gbTipo.Controls.Add(Me.Label18)
        Me.gbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipo.ForeColor = System.Drawing.Color.Maroon
        Me.gbTipo.Location = New System.Drawing.Point(390, 3)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(376, 43)
        Me.gbTipo.TabIndex = 130
        Me.gbTipo.TabStop = False
        '
        'rbTodas
        '
        Me.rbTodas.Checked = True
        Me.rbTodas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbTodas.Location = New System.Drawing.Point(288, 17)
        Me.rbTodas.Name = "rbTodas"
        Me.rbTodas.Size = New System.Drawing.Size(72, 17)
        Me.rbTodas.TabIndex = 126
        Me.rbTodas.TabStop = True
        Me.rbTodas.Text = "Todas"
        '
        'rbFacturadas
        '
        Me.rbFacturadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFacturadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbFacturadas.Location = New System.Drawing.Point(152, 17)
        Me.rbFacturadas.Name = "rbFacturadas"
        Me.rbFacturadas.Size = New System.Drawing.Size(104, 17)
        Me.rbFacturadas.TabIndex = 125
        Me.rbFacturadas.Text = "Facturadas"
        '
        'rbPendientes
        '
        Me.rbPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPendientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbPendientes.Location = New System.Drawing.Point(16, 17)
        Me.rbPendientes.Name = "rbPendientes"
        Me.rbPendientes.Size = New System.Drawing.Size(104, 17)
        Me.rbPendientes.TabIndex = 124
        Me.rbPendientes.Text = "Pendientes"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(832, 17)
        Me.TextBox6.MaxLength = 50
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(136, 20)
        Me.TextBox6.TabIndex = 123
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(752, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 26)
        Me.Label12.TabIndex = 103
        Me.Label12.Text = "Teléfono:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Maroon
        Me.Label17.Location = New System.Drawing.Point(632, 474)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 26)
        Me.Label17.TabIndex = 110
        Me.Label17.Text = "0.00"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(536, 474)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 26)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "Total:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbClientes
        '
        Me.cbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.Items.AddRange(New Object() {"Todas", "Canceladas", "Pendientes", "Vencidas"})
        Me.cbClientes.Location = New System.Drawing.Point(96, 17)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(288, 23)
        Me.cbClientes.TabIndex = 158
        Me.cbClientes.Visible = False
        '
        'gridOrdenes
        '
        Me.gridOrdenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridOrdenes.Location = New System.Drawing.Point(12, 52)
        Me.gridOrdenes.MainView = Me.vOrdenes
        Me.gridOrdenes.Name = "gridOrdenes"
        Me.gridOrdenes.Size = New System.Drawing.Size(754, 214)
        Me.gridOrdenes.TabIndex = 159
        Me.gridOrdenes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vOrdenes})
        '
        'vOrdenes
        '
        Me.vOrdenes.GridControl = Me.gridOrdenes
        Me.vOrdenes.Name = "vOrdenes"
        Me.vOrdenes.OptionsBehavior.Editable = False
        Me.vOrdenes.OptionsView.ShowAutoFilterRow = True
        Me.vOrdenes.OptionsView.ShowFooter = True
        Me.vOrdenes.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnDesign)
        Me.PanelControl1.Controls.Add(Me.cmdNuevo)
        Me.PanelControl1.Controls.Add(Me.cmdAyuda)
        Me.PanelControl1.Controls.Add(Me.cmdFacturar)
        Me.PanelControl1.Controls.Add(Me.cmdSalir)
        Me.PanelControl1.Controls.Add(Me.cmdModificar)
        Me.PanelControl1.Controls.Add(Me.cmdImprimir)
        Me.PanelControl1.Controls.Add(Me.cmdBorrar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 272)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(778, 51)
        Me.PanelControl1.TabIndex = 160
        '
        'frmListaOrdenes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(778, 323)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.gridOrdenes)
        Me.Controls.Add(Me.gbTipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbClientes)
        Me.Name = "frmListaOrdenes"
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        CType(Me.gridOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Dim Facturas As New VB.SysContab.Facturas_Ventas_TemporalDB()
    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim Ordenes As New VB.SysContab.OrdenesDB()
    Dim r As New VB.SysContab.Rutinas()


    Dim Tabla As DataTable
    Dim ds As DataSet

    Dim Estado As String

    Private Sub frmListaOrdenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(PanelControl1)
        ''
        Cargar()

        'If ds.Tables("Ordenes").Rows.Count <> 0 Then
        '    RegistroOrdenVer = Me.vOrdenes.GetRowCellValue(0, "No. Orden")
        'Else
        '    RegistroOrdenVer = "Vacio"
        'End If

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        'dgFacturas.CaptionText = "Información de Ordenes"
        'Me.Text = "O r d e n e s  d e   C l i e n t e s"
        'r.ComboAutoComplete(Me.cbClientes)
        Me.Refresh()
    End Sub

    Public Sub Cargar()
        Try
            If rbPendientes.Checked = True Then
                Estado = "P"
            ElseIf rbFacturadas.Checked = True Then
                Estado = "F"
            Else
                Estado = "T"
            End If

            'cbClientes.DataSource = Clientes.GetList.Tables("Clientes")
            'cbClientes.ValueMember = "Codigo"
            'cbClientes.DisplayMember = "Nombre"
            'Me.cbClientes.SelectedValue = 0
            'ds = Ordenes.ListOrdenes("", Estado)
            'dgFacturas.DataSource = ds.Tables("Ordenes").DefaultView

            Me.gridOrdenes.DataSource = ObtieneDatos("sp_OrdenesEntregaList '" & Estado & "'," & EmpresaActual)
            FormatoGrid(Me.vOrdenes)

            'Tabla = ds.Tables("Ordenes")
            'r.FormatGenerico(dgFacturas, Tabla)

            Me.vOrdenes.Columns("Numero").Visible = False
            Me.vOrdenes.Columns("TIPO").Visible = False
            Me.vOrdenes.Columns("P. Venta").Visible = False
            Me.vOrdenes.Columns("Sucursal").Width = 120
            Me.vOrdenes.Columns("Cliente").Width = 200


            Me.vOrdenes.Columns("Sub Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vOrdenes.Columns("Sub Total").DisplayFormat.FormatString = "{0:n2}"
            Me.vOrdenes.Columns("Sub Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vOrdenes.Columns("Sub Total").SummaryItem.DisplayFormat = "{0:n2}"

            Me.vOrdenes.Columns("IVA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vOrdenes.Columns("IVA").DisplayFormat.FormatString = "{0:n2}"
            Me.vOrdenes.Columns("IVA").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vOrdenes.Columns("IVA").SummaryItem.DisplayFormat = "{0:n2}"

            Me.vOrdenes.Columns("Descuento").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vOrdenes.Columns("Descuento").DisplayFormat.FormatString = "{0:n2}"
            Me.vOrdenes.Columns("Descuento").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vOrdenes.Columns("Descuento").SummaryItem.DisplayFormat = "{0:n2}"

            Me.vOrdenes.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.vOrdenes.Columns("Total").DisplayFormat.FormatString = "{0:n2}"
            Me.vOrdenes.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.vOrdenes.Columns("Total").SummaryItem.DisplayFormat = "{0:n2}"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        'Dim f As DataGridTextBoxCombo.frmFacturasPuntosVenta = f.Instance
        Dim f As FrmOrdenesNew = FrmOrdenesNew.Instance
        f.Nuevo = "SI"
        f.Factura = 0
        f.Tipo = "P"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.vOrdenes.DataRowCount = 0 Then
            Exit Sub
        End If

        If Me.vOrdenes.FocusedRowHandle < 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Information)
            Exit Sub
        End If

        'If dgFacturas.Item(dgFacturas.CurrentRowIndex, 1).ToString = "" Then
        '    MsgBox("Seleccione la orden", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'Dim f As DataGridTextBoxCombo.frmOrdenesVer = f.Instance
        'RegistroOrdenVer = dgFacturas.Item(dgFacturas.CurrentRowIndex, 1).ToString
        RegistroOrdenVer = Me.vOrdenes.GetFocusedRowCellValue("No. Orden")

        Dim f As New FrmOrdenesNew
        Dim Tipo As String = ""

        If Me.vOrdenes.GetFocusedRowCellValue("TIPO") = 0 Then
            Tipo = "P"
        ElseIf Me.vOrdenes.GetFocusedRowCellValue("TIPO") = 1 Then
            Tipo = "S"
        ElseIf Me.vOrdenes.GetFocusedRowCellValue("TIPO") = 2 Then
            Tipo = "A"
        End If

        With f
            .Nuevo = "NO"
            .Factura = Me.vOrdenes.GetFocusedRowCellValue("No. Orden")
            .Tipo = Tipo
            .Estado = Me.vOrdenes.GetFocusedRowCellValue("Estado")
            .MdiParent = Me.MdiParent
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub frmListaOrdenes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter

    End Sub

    Private Sub dgFacturasClientes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

        'If MsgBox("Esta seguro que dese borrar la Orden: " & dgFacturas.Item(dgFacturas.CurrentRowIndex, 0), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = DialogResult.No Then
        '    Exit Sub
        'End If

        If Me.vOrdenes.DataRowCount = 0 Then
            Exit Sub
        End If

        If Me.vOrdenes.FocusedRowHandle < 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MsgBox("Esta seguro que dese borrar la Orden #: " & Me.vOrdenes.GetFocusedRowCellValue("No. Orden").ToString, MsgBoxStyle.YesNo + MsgBoxStyle.Question) = DialogResult.No Then
            Exit Sub
        End If

        If Ordenes.OrdenDelete(Me.vOrdenes.GetFocusedRowCellValue("No. Orden")) Then
            MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

            ds = Ordenes.ListOrdenes("", Estado)
            Cargar()
        End If

        'If resp = DialogResult.No Then
        '    Exit Sub
        'End If

        'Try
        '    clientes.FacturaDelete(dgFacturas.Item(dgFacturas.CurrentRowIndex, 0))
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Exit Sub
        'End Try
        'Dim r As New VB.SysContab.Rutinas()
        'Dim Tabla As New DataTable()
        'Dim ds As New DataSet()

        'ds = clientes.ListFacturas("")

        'dgFacturas.DataSource = clientes.ListFacturas("").Tables("Facturas_Ventas").DefaultView
        'Tabla = ds.Tables("Facturas_Ventas")

        'If ds.Tables("Facturas_Ventas").Rows.Count = 0 Then
        '    Registro = "Vacio"

        'End If

        'r.FormatGenerico(dgFacturasClientes, Tabla)
    End Sub

    Private Sub rbTodas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbTodas.Click
        Estado = "T"
        'ds = Ordenes.ListOrdenes("", Estado)
        'dgFacturas.DataSource = ds.Tables("Ordenes").DefaultView

        'dgFacturas.DataSource = Ordenes.ListOrdenes(Me.cbClientes.Text, Estado).Tables("Ordenes").DefaultView
        Cargar()
    End Sub

    Private Sub rbFacturadas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFacturadas.Click
        Estado = "F"
        'dgFacturas.DataSource = Ordenes.ListOrdenes(Me.cbClientes.Text, Estado).Tables("Ordenes").DefaultView
        Cargar()
    End Sub

    Private Sub rbPendientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPendientes.Click
        Estado = "P"
        'dgFacturas.DataSource = Ordenes.ListOrdenes(Me.cbClientes.Text, Estado).Tables("Ordenes").DefaultView
        Cargar()
    End Sub

    'Private Sub dgFacturas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgFacturas.CurrentCellChanged
    '    RegistroOrdenVer = dgFacturas.Item(dgFacturas.CurrentRowIndex, 1)
    'End Sub

    Private Sub cbClientes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbClientes.SelectedValueChanged
        'If etInicio.Text = "1" Then
        '    Exit Sub
        'End If

        'Try
        '    dgFacturas.DataSource = Ordenes.ListOrdenes(Me.cbClientes.Text, Estado).Tables("Ordenes").DefaultView
        'Catch ex As Exception
        '    MsgBox(ex.Message & " cbClientes_SelectedValueChanged")
        'End Try
    End Sub

    Private Sub Ayuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/ClientesOrdenes.chm")
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ruta As String = ""
        Try
            ruta = "\" + ObtieneDatos("_GetLogoEmpresa " & EmpresaActual).Rows.Item(0)("Logo")
        Catch ex As Exception
            ruta = ""
        End Try

        Dim rpt As New rptOrdenEntrega
        rpt.pLogo.ImageUrl = Application.StartupPath + ruta
        rpt.DataSource = ObtieneDatos("_ReporteOrdenEntrega 1,3").DefaultView

        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        rpt.ShowRibbonPreview()

    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        If Me.vOrdenes.DataRowCount = 0 Then
            Exit Sub
        End If

        If Me.vOrdenes.FocusedRowHandle < 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Information)
            Exit Sub
        End If


        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        Try
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 12 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)

            Cadena = Application.StartupPath & "\RptOrdenEntrega.repx"

            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()
        Catch ex As Exception
            Temp = False
        End Try

        'Dim ruta As String = ""
        'Try
        '    ruta = "\" + ObtieneDatos("_GetLogoEmpresa " & EmpresaActual).Rows.Item(0)("Logo")
        'Catch ex As Exception
        '    ruta = ""
        'End Try

        Dim rpt As XtraReport

        If Temp Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\RptOrdenEntrega.repx", True)
        Else
            rpt = New rptOrdenEntrega
        End If

        'Dim rpt As New rptOrdenEntrega
        'rpt.pLogo.ImageUrl = Application.StartupPath + ruta
        rpt.DataSource = ObtieneDatos("_ReporteOrdenEntrega " & Me.vOrdenes.GetFocusedRowCellValue("No. Orden") & "," & EmpresaActual).DefaultView

        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        rpt.ShowRibbonPreview()

        'Dim ds As DataSet
        ''ds = Ordenes.ImprimirOrden(dgFacturas.Item(dgFacturas.CurrentRowIndex, 1))
        'ds = Ordenes.ImprimirOrden(Me.vOrdenes.GetFocusedRowCellValue("No. Orden"))
        'ds.WriteXml(Application.StartupPath & "\xml\RepOrdenes.xml", XmlWriteMode.WriteSchema)
        'Dim fReportes As New frmReportes
        'Dim rOrdenes As New rptClientesOrdenesCompra
        'rOrdenes.Database.Tables("_OrdenesComprasClientesRep;1").Location = Application.StartupPath & "\xml\RepOrdenes.xml"
        'rOrdenes.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
        'fReportes.crvReportes.ReportSource = rOrdenes
        'fReportes.crvReportes.Zoom(91)
        'fReportes.Show()
    End Sub

    Private Sub btnDesign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesign.Click
        Dim forma As New FrmConfiguraCheque

        forma.Tipo = 12
        forma.Text = "Diseño Orden de Entrega"
        forma.Show()
    End Sub
End Class
