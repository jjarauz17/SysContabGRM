Imports System.Data.SqlClient
Public Class frmCobrosTotales
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmCobrosTotales = Nothing

    Public Shared Function Instance() As frmCobrosTotales
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmCobrosTotales()
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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
    Friend WithEvents cmdVerHojas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAsignarDepositos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDepositos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbDepositos As System.Windows.Forms.ComboBox
    Friend WithEvents dgCobrosTotales As System.Windows.Forms.DataGrid
    Friend WithEvents cmdArqueo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cBoxFecha = New System.Windows.Forms.CheckBox
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbDepositos = New System.Windows.Forms.ComboBox
        Me.dgCobrosTotales = New System.Windows.Forms.DataGrid
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbBotones = New System.Windows.Forms.GroupBox
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdArqueo = New DevExpress.XtraEditors.SimpleButton
        Me.cmdVerHojas = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAsignarDepositos = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDepositos = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCobrosTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cBoxFecha)
        Me.GroupBox1.Controls.Add(Me.dtpFecha1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbDepositos)
        Me.GroupBox1.Controls.Add(Me.dgCobrosTotales)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(793, 307)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        '
        'cBoxFecha
        '
        Me.cBoxFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cBoxFecha.Location = New System.Drawing.Point(586, 273)
        Me.cBoxFecha.Name = "cBoxFecha"
        Me.cBoxFecha.Size = New System.Drawing.Size(96, 26)
        Me.cBoxFecha.TabIndex = 154
        Me.cBoxFecha.Text = "Por Fecha:"
        Me.cBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha1.Enabled = False
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(690, 273)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha1.TabIndex = 150
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 26)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "Hoja de Deposito:"
        '
        'cbDepositos
        '
        Me.cbDepositos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbDepositos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepositos.Location = New System.Drawing.Point(146, 273)
        Me.cbDepositos.Name = "cbDepositos"
        Me.cbDepositos.Size = New System.Drawing.Size(432, 21)
        Me.cbDepositos.TabIndex = 148
        '
        'dgCobrosTotales
        '
        Me.dgCobrosTotales.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgCobrosTotales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCobrosTotales.BackColor = System.Drawing.Color.Gainsboro
        Me.dgCobrosTotales.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgCobrosTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCobrosTotales.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgCobrosTotales.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgCobrosTotales.CaptionForeColor = System.Drawing.Color.Black
        Me.dgCobrosTotales.DataMember = ""
        Me.dgCobrosTotales.FlatMode = True
        Me.dgCobrosTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCobrosTotales.ForeColor = System.Drawing.Color.Black
        Me.dgCobrosTotales.GridLineColor = System.Drawing.Color.Silver
        Me.dgCobrosTotales.HeaderBackColor = System.Drawing.Color.Black
        Me.dgCobrosTotales.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgCobrosTotales.HeaderForeColor = System.Drawing.Color.White
        Me.dgCobrosTotales.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgCobrosTotales.Location = New System.Drawing.Point(8, 17)
        Me.dgCobrosTotales.Name = "dgCobrosTotales"
        Me.dgCobrosTotales.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgCobrosTotales.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCobrosTotales.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgCobrosTotales.SelectionForeColor = System.Drawing.Color.White
        Me.dgCobrosTotales.Size = New System.Drawing.Size(777, 250)
        Me.dgCobrosTotales.TabIndex = 12
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(78, 5)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 147
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "Fecha:"
        '
        'gbBotones
        '
        Me.gbBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBotones.BackColor = System.Drawing.Color.Transparent
        Me.gbBotones.Controls.Add(Me.cmdGuardar)
        Me.gbBotones.Controls.Add(Me.cmdArqueo)
        Me.gbBotones.Controls.Add(Me.cmdVerHojas)
        Me.gbBotones.Controls.Add(Me.cmdAsignarDepositos)
        Me.gbBotones.Controls.Add(Me.cmdDepositos)
        Me.gbBotones.Controls.Add(Me.cmdSalir)
        Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBotones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbBotones.Location = New System.Drawing.Point(809, 31)
        Me.gbBotones.Name = "gbBotones"
        Me.gbBotones.Size = New System.Drawing.Size(96, 307)
        Me.gbBotones.TabIndex = 149
        Me.gbBotones.TabStop = False
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Appearance.Options.UseTextOptions = True
        Me.cmdGuardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdGuardar.Location = New System.Drawing.Point(8, 106)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 35)
        Me.cmdGuardar.TabIndex = 12
        Me.cmdGuardar.Text = "&Guardar"
        '
        'cmdArqueo
        '
        Me.cmdArqueo.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdArqueo.Appearance.Options.UseFont = True
        Me.cmdArqueo.Location = New System.Drawing.Point(8, 187)
        Me.cmdArqueo.Name = "cmdArqueo"
        Me.cmdArqueo.Size = New System.Drawing.Size(80, 35)
        Me.cmdArqueo.TabIndex = 11
        Me.cmdArqueo.Text = "&Arqueo"
        Me.cmdArqueo.Visible = False
        '
        'cmdVerHojas
        '
        Me.cmdVerHojas.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerHojas.Appearance.Options.UseFont = True
        Me.cmdVerHojas.Appearance.Options.UseTextOptions = True
        Me.cmdVerHojas.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdVerHojas.Location = New System.Drawing.Point(8, 66)
        Me.cmdVerHojas.Name = "cmdVerHojas"
        Me.cmdVerHojas.Size = New System.Drawing.Size(80, 34)
        Me.cmdVerHojas.TabIndex = 10
        Me.cmdVerHojas.Text = "&Ver Hojas de Depositos"
        '
        'cmdAsignarDepositos
        '
        Me.cmdAsignarDepositos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAsignarDepositos.Appearance.Options.UseFont = True
        Me.cmdAsignarDepositos.Appearance.Options.UseTextOptions = True
        Me.cmdAsignarDepositos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAsignarDepositos.Location = New System.Drawing.Point(8, 147)
        Me.cmdAsignarDepositos.Name = "cmdAsignarDepositos"
        Me.cmdAsignarDepositos.Size = New System.Drawing.Size(80, 34)
        Me.cmdAsignarDepositos.TabIndex = 8
        Me.cmdAsignarDepositos.Text = "&Asignar Depositos"
        '
        'cmdDepositos
        '
        Me.cmdDepositos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDepositos.Appearance.Options.UseFont = True
        Me.cmdDepositos.Appearance.Options.UseTextOptions = True
        Me.cmdDepositos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdDepositos.Location = New System.Drawing.Point(8, 26)
        Me.cmdDepositos.Name = "cmdDepositos"
        Me.cmdDepositos.Size = New System.Drawing.Size(80, 34)
        Me.cmdDepositos.TabIndex = 7
        Me.cmdDepositos.Text = "&Crear Hojas de Depositos"
        '
        'cmdSalir
        '
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.Location = New System.Drawing.Point(8, 228)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'frmCobrosTotales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(905, 350)
        Me.Controls.Add(Me.gbBotones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Name = "frmCobrosTotales"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgCobrosTotales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim Depositos As New VB.SysContab.DepositosDB()
    Private Comprobantes As New VB.SysContab.ComprobanteDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As New DataTable()
    Public ds As New DataSet()

    Private WithEvents myDataSet As DataSet
    Public tCust As DataTable
    Dim i As Integer
    Private myCheckBoxCol As Integer = 6 'my checkbox column 

    Private Sub frmCobrosTotales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            r.FormularioColor(Me)
            'r.CambiarEstilo(Me)

            Me.dtpFecha.Value = r.Fecha

            FechaCobro = dtpFecha.Value.Date

            ds = Clientes.CobrosXTotales(dtpFecha.Value.Date)

            'ListView1.Items.Add("Esta es una prueba")

            'cbDepositos.DataSource = Depositos.List(0, dtpFecha.Value.Date, dtpFecha.Value.Date).Tables("Depositos")
            cbDepositos.DataSource = Depositos.List(0, "", "", 0).Tables("Depositos")
            cbDepositos.ValueMember = "Deposito_ID"
            cbDepositos.DisplayMember = "DisplayMember"

            cbDepositos.DropDownStyle = ComboBoxStyle.DropDownList
            cbDepositos.SelectedIndex = cbDepositos.Items.Count - 1

            dgCobrosTotales.DataSource = ds.Tables("Cobros").DefaultView
            'Tabla = ds.Tables("Cobros")

            'r.FormatGenerico(dgCobrosTotales, Tabla)

            If ds.Tables("Cobros").Rows.Count <> 0 Then
                Registro = dgCobrosTotales.Item(0, 0)
            Else
                Registro = "Vacio"
            End If

            MakeDataSet()
            dgCobrosTotales.SetDataBinding(myDataSet, "Item")
            AddCustomDataTableStyle()

            For i = 0 To ds.Tables("Cobros").Rows.Count - 1
                If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 4 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 7 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 6 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 10 Then 'Título y Totales
                    dgCobrosTotales.Select(i)
                End If
            Next

            'dgCobrosTotales.SelectionBackColor = Color.LightBlue

            'dgCobrosTotales.CaptionText = "Ingresos por día"

            Me.Text = "Ingresos por día"
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        ds = Clientes.CobrosXTotales(dtpFecha.Value.Date)
        'dgCobrosTotales.DataSource = ds.Tables("Cobros").DefaultView
        FechaCobro = dtpFecha.Value.Date

        MakeDataSet()
        dgCobrosTotales.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()

        For i = 0 To ds.Tables("Cobros").Rows.Count - 1
            If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 4 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 7 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 6 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 10 Then 'Título y Totales
                dgCobrosTotales.Select(i)
            End If
        Next

    End Sub

    Private Sub cmdDepositos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDepositos.Click
        Dim f As frmAgregarDeposito = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.txtCodigo.Focus()

    End Sub

    Private Sub cmdVerHojas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerHojas.Click
        Dim f As frmDepositosList = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAsignarDepositos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAsignarDepositos.Click
        If ds.Tables("Cobros").Rows.Count <= 5 Then
            MsgBox("No hay ingresos de la fecha seleccionada", MsgBoxStyle.Information)
            Exit Sub
        End If

        If cbDepositos.Items.Count = 0 Then
            MsgBox("Seleccione la Hoja de Deposito", MsgBoxStyle.Information)
            cbDepositos.Focus()
            Exit Sub
        End If

        If Clientes.ChequesXBanco(0, dtpFecha.Value.Date, 0, 0).Tables("Cobros").Rows.Count <> 0 Then
            If MsgBox("Arqueo no completado Desea Continuar", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        FechaCobro = dtpFecha.Value.Date
        Banco = dgCobrosTotales.Item(dgCobrosTotales.CurrentRowIndex, 0)
        Checked = True

        Seleccionar = False

        Deposito = cbDepositos.SelectedValue

        Inicio = True

        Dim f As frmAsignarDepositos = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()

        Inicio = False

    End Sub

    Private Sub TextBoxMouseEnterHandler(ByVal sender As Object, ByVal e As EventArgs)
        Try
            'Dim f As frmDetalleArticulo = f.Instance

            'Registro = Me.dgCobrosTotales.Item(Me.dgCobrosTotales.CurrentRowIndex, 0)

            Banco = dgCobrosTotales.Item(dgCobrosTotales.CurrentRowIndex, 0)

            MsgBox("Codigo Banco: " & Banco)

            'f.MdiParent = Me.MdiParent
            'f.Show()
            'Me.seleccionar()
        Catch ex As Exception
            'MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub MakeDataSet()
        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")

        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust = New DataTable("Item")

        ' Create two columns, and add them to the first table.
        'For i = 0 To ds1.Tables("Depositos").Rows.Count ' - 1
        '    Dim cAgregar As DataColumn
        '    cAgregar = New DataColumn(i, GetType(System.Boolean))
        '    tCust.Columns.Add(cAgregar)
        'Next

        'Dim cLinea As DataColumn
        'cLinea = New DataColumn("Linea")
        'tCust.Columns.Add(cLinea)

        Dim cCodigo As DataColumn
        cCodigo = New DataColumn("Codigo")
        tCust.Columns.Add(cCodigo)

        Dim cBanco As DataColumn
        cBanco = New DataColumn("Banco")
        tCust.Columns.Add(cBanco)

        Dim cNoCheque As DataColumn
        cNoCheque = New DataColumn("NoCheques")
        tCust.Columns.Add(cNoCheque)

        Dim cValor As DataColumn
        cValor = New DataColumn("Valor")
        tCust.Columns.Add(cValor)

        Dim cAsignados As DataColumn
        cAsignados = New DataColumn("Asignados")
        tCust.Columns.Add(cAsignados)

        Dim cPendientes As DataColumn
        cPendientes = New DataColumn("Pendientes")
        tCust.Columns.Add(cPendientes)

        Dim cAgregar As DataColumn
        cAgregar = New DataColumn("Agregar", GetType(System.Boolean))
        tCust.Columns.Add(cAgregar)

        Dim cDetalle As DataColumn
        cDetalle = New DataColumn("Detalle")
        tCust.Columns.Add(cDetalle)

        tCust.DefaultView.AllowDelete = False
        tCust.DefaultView.AllowNew = False
        tCust.DefaultView.AllowEdit = False

        'tCust.Columns.Add(cCurrent2)
        ' Add the tables to the DataSet.
        myDataSet.Tables.Add(tCust)

        'creates two DataRow variables. 
        Dim newRow1 As DataRow
        ' Create three customers in the Customers Table.
        'newRow1 = tCust.NewRow
        'newRow1(i) = False
        'tCust.Rows.Add(newRow1)

        'newRow1 = tCust.NewRow
        ''newRow1(i) = False
        'tCust.Rows.Add(newRow1)

        'i = 0
        'Dim j As Integer
        'If Checked = True Then
        '    tCust.Rows(0)("Agregar") = True
        'Else
        '    tCust.Rows(0)("Agregar") = False
        'End If

        For i = 0 To ds.Tables("Cobros").Rows.Count - 1
            newRow1 = tCust.NewRow
            'newRow1(i) = False
            tCust.Rows.Add(newRow1)


            'tCust.Rows(i + 1)("Linea") = i + 1
            If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Then 'BANCOS DE LA EMPRESA
                'dgCobrosTotales.Select(i)
                tCust.Rows(i)("Codigo") = ""
                tCust.Rows(i)("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
                tCust.Rows(i)("NoCheques") = ""
                tCust.Rows(i)("Valor") = ""
                tCust.Rows(i)("Asignados") = ""
                tCust.Rows(i)("Pendientes") = ""
            ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 4 Then 'OTROS BANCOS
                tCust.Rows(i)("Codigo") = ""
                tCust.Rows(i)("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
                tCust.Rows(i)("NoCheques") = ""
                tCust.Rows(i)("Valor") = ""
                tCust.Rows(i)("Asignados") = ""
                tCust.Rows(i)("Pendientes") = ""
            ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 7 Then 'Efectivo
                tCust.Rows(i)("Codigo") = ds.Tables("Cobros").Rows(i).Item("Codigo")
                tCust.Rows(i)("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
                tCust.Rows(i)("NoCheques") = ""
                tCust.Rows(i)("Valor") = CDbl(ds.Tables("Cobros").Rows(i).Item("Valor")).ToString(Round)
                tCust.Rows(i)("Asignados") = CDbl(ds.Tables("Cobros").Rows(i).Item("Asignados")).ToString(Round)
                tCust.Rows(i)("Pendientes") = CDbl(ds.Tables("Cobros").Rows(i).Item("Pendientes")).ToString(Round)
            ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 6 Then 'TOTALES
                tCust.Rows(i)("Codigo") = ds.Tables("Cobros").Rows(i).Item("Codigo")
                tCust.Rows(i)("Banco") = "            " & ds.Tables("Cobros").Rows(i).Item("Banco")
                tCust.Rows(i)("NoCheques") = ds.Tables("Cobros").Rows(i).Item("Cant. CKs")
                tCust.Rows(i)("Valor") = CDbl(ds.Tables("Cobros").Rows(i).Item("Valor")).ToString(Round)
                tCust.Rows(i)("Asignados") = ds.Tables("Cobros").Rows(i).Item("Asignados")
                tCust.Rows(i)("Pendientes") = ds.Tables("Cobros").Rows(i).Item("Pendientes")
            ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 8 Then 'LINEA EN BLANCO
                tCust.Rows(i)("Codigo") = ds.Tables("Cobros").Rows(i).Item("Codigo")
                tCust.Rows(i)("Banco") = ""
                tCust.Rows(i)("NoCheques") = ""
                tCust.Rows(i)("Valor") = ""
                tCust.Rows(i)("Asignados") = ""
                tCust.Rows(i)("Pendientes") = ""
            ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 10 Then 'TOTALES
                tCust.Rows(i)("Codigo") = ds.Tables("Cobros").Rows(i).Item("Codigo")
                tCust.Rows(i)("Banco") = "            " & ds.Tables("Cobros").Rows(i).Item("Banco")
                tCust.Rows(i)("NoCheques") = ""
                tCust.Rows(i)("Valor") = CDbl(ds.Tables("Cobros").Rows(i).Item("Valor")).ToString(Round)
                tCust.Rows(i)("Asignados") = ""
                tCust.Rows(i)("Pendientes") = ""
                'tCust.Rows(i)("Detalle") = "Mostrar Detalles"
            ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 9 Then 'Otros Ingresos
                'Valor.Alignment = HorizontalAlignment.Center
                tCust.Rows(i)("Codigo") = ds.Tables("Cobros").Rows(i).Item("Codigo")
                tCust.Rows(i)("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
                tCust.Rows(i)("NoCheques") = ds.Tables("Cobros").Rows(i).Item("Cant. CKs")
                tCust.Rows(i)("Valor") = CDbl(ds.Tables("Cobros").Rows(i).Item("Valor")).ToString(Round)
                tCust.Rows(i)("Asignados") = CDbl(ds.Tables("Cobros").Rows(i).Item("Asignados")).ToString(Round)
                tCust.Rows(i)("Pendientes") = CDbl(ds.Tables("Cobros").Rows(i).Item("Pendientes")).ToString(Round)
                'tCust.Rows(i)("Detalle") = "Mostrar Detalles"
            Else 'Datos
                'Valor.Alignment = HorizontalAlignment.Center
                tCust.Rows(i)("Codigo") = ds.Tables("Cobros").Rows(i).Item("Codigo")
                tCust.Rows(i)("Banco") = "    " & ds.Tables("Cobros").Rows(i).Item("Banco")
                tCust.Rows(i)("NoCheques") = ds.Tables("Cobros").Rows(i).Item("Cant. CKs")
                tCust.Rows(i)("Valor") = CDbl(ds.Tables("Cobros").Rows(i).Item("Valor")).ToString(Round)
                tCust.Rows(i)("Asignados") = ds.Tables("Cobros").Rows(i).Item("Asignados")
                tCust.Rows(i)("Pendientes") = ds.Tables("Cobros").Rows(i).Item("Pendientes")
                tCust.Rows(i)("Detalle") = "Mostrar Detalles"
            End If

            tCust.Rows(i)("Agregar") = False

            'If Checked = True Then
            '    tCust.Rows(i + 1)("Agregar") = True
            'Else
            '    tCust.Rows(i + 1)("Agregar") = False
            'End If

            'For j = 0 To ds.Tables("Depositos").Rows.Count - 1
            '    tCust.Rows(i)(ds.Tables("Depositos").Rows(j).Item("Deposito_ID") & "D") = False
            'Next
        Next
        myDataSet.Tables("Item").DefaultView.AllowDelete = False
    End Sub

    Public Sub AddCustomDataTableStyle()

        'STEP 1: Create a DataTable style object and set properties if required.
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle()
        'specify the table from dataset (required step)
        ts1.MappingName = "Item"
        ' Set other properties (optional step)
        'ts1.AlternatingBackColor = Color.LightBlue
        'ts1.BackColor = Color.LightBlue

        ts1.SelectionBackColor = Color.LightBlue
        ts1.SelectionForeColor = Color.DarkRed
        'DGCOBROSTOtales. = Color.LightBlue

        Dim colCount As Integer
        colCount = 0

        'Dim Linea As New DataGridTextBoxColumn()
        'Linea.MappingName = "Linea"
        'Linea.HeaderText = ""
        'Linea.ReadOnly = True
        'Linea.Alignment = HorizontalAlignment.Left
        'Linea.Width = 25
        'Linea.NullText = ""

        'ts1.GridColumnStyles.Add(Linea)
        'colCount = (colCount + 1)

        Dim Codigo As New DataGridTextBoxColumn()
        Codigo.MappingName = "Codigo"
        Codigo.HeaderText = "Codigo"
        Codigo.ReadOnly = True
        Codigo.Alignment = HorizontalAlignment.Left
        Codigo.Width = 0
        Codigo.NullText = ""

        ts1.GridColumnStyles.Add(Codigo)
        colCount = (colCount + 1)

        Dim Banco As New DataGridTextBoxColumn()
        Banco.MappingName = "Banco"
        Banco.HeaderText = "Banco"
        Banco.ReadOnly = True
        Banco.Alignment = HorizontalAlignment.Left
        Banco.Width = 320
        Banco.NullText = ""

        ts1.GridColumnStyles.Add(Banco)
        colCount = (colCount + 1)

        Dim NoCheques As New DataGridTextBoxColumn()
        NoCheques.MappingName = "NoCheques"
        NoCheques.HeaderText = "Cant. CKs"
        NoCheques.ReadOnly = True
        NoCheques.Alignment = HorizontalAlignment.Right
        NoCheques.Width = 65
        NoCheques.NullText = ""

        ts1.GridColumnStyles.Add(NoCheques)
        colCount = (colCount + 1)

        Dim Valor As New DataGridTextBoxColumn()
        Valor.MappingName = "Valor"
        Valor.HeaderText = "Monto"
        Valor.ReadOnly = True
        Valor.Alignment = HorizontalAlignment.Right
        Valor.Width = 90
        Valor.NullText = ""

        ts1.GridColumnStyles.Add(Valor)
        colCount = (colCount + 1)

        Dim Asignados As New DataGridTextBoxColumn()
        Asignados.MappingName = "Asignados"
        Asignados.HeaderText = "Asignados"
        Asignados.ReadOnly = True
        Asignados.Alignment = HorizontalAlignment.Right
        Asignados.Width = 90
        Asignados.NullText = "0.00"

        ts1.GridColumnStyles.Add(Asignados)
        colCount = (colCount + 1)

        Dim Pendientes As New DataGridTextBoxColumn()
        Pendientes.MappingName = "Pendientes"
        Pendientes.HeaderText = "Pendientes"
        Pendientes.ReadOnly = True
        Pendientes.Alignment = HorizontalAlignment.Right
        Pendientes.Width = 90
        Pendientes.NullText = "0.00"

        ts1.GridColumnStyles.Add(Pendientes)
        colCount = (colCount + 1)

        Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        boolCol.MappingName = "Agregar"
        boolCol.HeaderText = "Seleccionar"
        boolCol.Alignment = HorizontalAlignment.Center
        'uncomment this line to get a two-state checkbox
        CType(boolCol, DataGridBoolColumn).AllowNull = False

        boolCol.Width = 70
        boolCol.ReadOnly = False

        boolCol.NullText = ""

        'hook the new event to our handler in the grid
        AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
        'AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
        'AddHandler boolCol. , AddressOf CheckedChanged
        ts1.GridColumnStyles.Add(boolCol)
        colCount = (colCount + 1)

        Dim Detalle As New DataGridTextBoxColumn()
        Detalle.MappingName = "Detalle"
        Detalle.HeaderText = "Mostrar Detalles"
        Detalle.ReadOnly = True
        Detalle.Alignment = HorizontalAlignment.Center
        Detalle.Width = 115
        Detalle.NullText = ""


        ''''AddHandler Detalle.TextBox.MouseEnter, New EventHandler(AddressOf TextBoxMouseEnterHandler)

        'tableStyle.GridColumnStyles.Add(column)
        ts1.GridColumnStyles.Add(Detalle)
        colCount = (colCount + 1)

        ''STEP 5: Add a second checkbox

        'STEP 6: Add the tablestyle to your datagrids tablestlye collection
        ts1.AllowSorting = False
        ts1.HeaderFont = dgCobrosTotales.HeaderFont
        ts1.PreferredRowHeight = 25
        'ts1.ReadOnly = True

        'tCust.DefaultView.AllowDelete = False
        'tCust.DefaultView.AllowNew = False
        'tCust.DefaultView.AllowEdit = False

        dgCobrosTotales.ReadOnly = True

        myDataSet.Tables("Item").DefaultView.AllowDelete = False
        myDataSet.Tables("Item").DefaultView.AllowNew = False
        myDataSet.Tables("Item").DefaultView.AllowEdit = True

        dgCobrosTotales.TableStyles.Clear()
        dgCobrosTotales.TableStyles.Add(ts1)

    End Sub

    Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
        Dim s As String
        s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
        Console.WriteLine(s)
    End Sub

    Private Sub dgCobrosTotales_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgCobrosTotales.MouseUp
        Dim hti As DataGrid.HitTestInfo = Me.dgCobrosTotales.HitTest(e.X, e.Y)
        If hti.Row = -1 Then
            Exit Sub
        End If

        If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = 7 And (ds.Tables("Cobros").Rows(hti.Row).Item("Orden") = 2 Or ds.Tables("Cobros").Rows(hti.Row).Item("Orden") = 5) Then
            Banco = dgCobrosTotales.Item(dgCobrosTotales.CurrentRowIndex, 0)
            Dim f As frmChuequesXBanco = frmChuequesXBanco.Instance
            f.MdiParent = Me.MdiParent
            f.Show()
            Exit Sub
        End If

        Try
            If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
                If ds.Tables("Cobros").Rows(hti.Row).Item("Orden") = 3 Or ds.Tables("Cobros").Rows(hti.Row).Item("Orden") = 6 Or ds.Tables("Cobros").Rows(hti.Row).Item("Orden") = 8 Or ds.Tables("Cobros").Rows(hti.Row).Item("Orden") = 10 Then   'Título
                    'MsgBox(ds.Tables("Cobros").Rows(hti.Row).Item("Pendientes"), MsgBoxStyle.Exclamation)
                    Me.dgCobrosTotales(hti.Row, hti.Column) = False
                    Exit Sub
                ElseIf IsNumeric(tCust.Rows(hti.Row)("Pendientes")) Then
                    If CDbl(tCust.Rows(hti.Row)("Pendientes")) <> 0 Then
                        'Cambiar el Check
                    Else
                        Me.dgCobrosTotales(hti.Row, hti.Column) = False
                        Exit Sub
                    End If
                Else

                End If

                Me.dgCobrosTotales(hti.Row, hti.Column) = Not CBool(Me.dgCobrosTotales(hti.Row, hti.Column))
                Dim Cantidad As Integer
                Cantidad = 0
                If ds.Tables("Cobros").Rows(dgCobrosTotales.CurrentRowIndex).Item("Orden") = 1 Then
                    If tCust.Rows(dgCobrosTotales.CurrentRowIndex)("Agregar") = True Then
                        For i = dgCobrosTotales.CurrentRowIndex + 1 To tCust.Rows.Count - 1
                            If ds.Tables("Cobros").Rows(i).Item("Orden") <> 2 Then
                                If Cantidad = 0 Then
                                    Me.dgCobrosTotales(hti.Row, hti.Column) = False
                                    'Exit Sub
                                End If
                                Exit Sub

                            ElseIf CDbl(ds.Tables("Cobros").Rows(i)("Pendientes")) <> 0 Then
                                tCust.Rows(i)("Agregar") = True
                                Cantidad = 1
                            End If
                        Next

                    Else
                        For i = dgCobrosTotales.CurrentRowIndex + 1 To tCust.Rows.Count - 1
                            If ds.Tables("Cobros").Rows(i).Item("Orden") <> 2 Then
                                Exit Sub
                            End If
                            tCust.Rows(i)("Agregar") = False
                        Next
                    End If
                End If

                Dim j As Integer

                'If ds.Tables("Cobros").Rows(dgCobrosTotales.CurrentRowIndex).Item("Orden") = 2 Then
                '    For i = 0 To tCust.Rows.Count - 1
                '        If tCust.Rows(i)("Agregar") = False Then
                '            For j = 0 To tCust.Rows.Count - 1
                '                If ds.Tables("Cobros").Rows(j).Item("Orden") = 1 Then
                '                    tCust.Rows(j)("Agregar") = False
                '                    Exit Sub
                '                End If
                '            Next
                '        End If

                '        For j = 0 To tCust.Rows.Count - 1
                '            If ds.Tables("Cobros").Rows(j).Item("Orden") = 1 Then
                '                tCust.Rows(j)("Agregar") = True
                '            End If
                '        Next

                '    Next
                'End If

                If ds.Tables("Cobros").Rows(dgCobrosTotales.CurrentRowIndex).Item("Orden") = 2 Then
                    For i = 0 To tCust.Rows.Count - 1
                        If tCust.Rows(i)("Agregar") = False Then
                            For j = 0 To tCust.Rows.Count - 1
                                If ds.Tables("Cobros").Rows(j).Item("Orden") = 1 Then
                                    tCust.Rows(j)("Agregar") = False
                                    Exit Sub
                                End If
                            Next
                        End If
                    Next
                End If

                If ds.Tables("Cobros").Rows(dgCobrosTotales.CurrentRowIndex).Item("Orden") = 5 Then
                    For i = 0 To tCust.Rows.Count - 1
                        If tCust.Rows(i)("Agregar") = False Then
                            For j = 0 To tCust.Rows.Count - 1
                                If ds.Tables("Cobros").Rows(j).Item("Orden") = 4 Then
                                    tCust.Rows(j)("Agregar") = False
                                    Exit Sub
                                End If
                            Next
                        End If
                    Next
                End If
                Cantidad = 0
                If ds.Tables("Cobros").Rows(dgCobrosTotales.CurrentRowIndex).Item("Orden") = 4 Then
                    If tCust.Rows(dgCobrosTotales.CurrentRowIndex)("Agregar") = True Then
                        For i = dgCobrosTotales.CurrentRowIndex + 1 To tCust.Rows.Count - 1
                            If ds.Tables("Cobros").Rows(i).Item("Orden") <> 5 Then
                                If Cantidad = 0 Then
                                    Me.dgCobrosTotales(hti.Row, hti.Column) = False
                                    'Exit Sub
                                End If
                                Exit Sub

                            ElseIf CDbl(ds.Tables("Cobros").Rows(i)("Pendientes")) <> 0 Then
                                tCust.Rows(i)("Agregar") = True
                                Cantidad = 1
                            End If
                        Next
                    Else
                        For i = dgCobrosTotales.CurrentRowIndex + 1 To tCust.Rows.Count - 1
                            If ds.Tables("Cobros").Rows(i).Item("Orden") <> 5 Then
                                Exit Sub
                            End If
                            tCust.Rows(i)("Agregar") = False
                        Next
                    End If
                End If

            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try

        'If dgDepositos.CurrentRowIndex <> 0 And hti.Column = myCheckBoxCol Then
        '    If tCust.Rows(0)("Agregar") = True Then
        '        For i = 1 To tCust.Rows.Count - 1
        '            If tCust.Rows(i)("Agregar") = False Then
        '                tCust.Rows(0)("Agregar") = False
        '            End If
        '        Next
        '    ElseIf tCust.Rows(0)("Agregar") = False Then
        '        For i = 1 To tCust.Rows.Count - 1
        '            If tCust.Rows(i)("Agregar") = False Then
        '                Exit For
        '            End If
        '        Next
        '        If i = tCust.Rows.Count Then
        '            tCust.Rows(0)("Agregar") = True
        '        End If
        '    End If
        '    'Me.dgDepositos(0, hti.Column) = False 'Not CBool(Me.dgDepositos(0, hti.Column))
        'End If

        'If dgDepositos.CurrentRowIndex = 0 And tCust.Rows(0)("Agregar") = True And hti.Column = myCheckBoxCol Then
        '    For i = 1 To tCust.Rows.Count - 1
        '        tCust.Rows(i)("Agregar") = True
        '    Next
        'ElseIf dgDepositos.CurrentRowIndex = 0 And tCust.Rows(0)("Agregar") = False And hti.Column = myCheckBoxCol Then
        '    For i = 1 To tCust.Rows.Count - 1
        '        tCust.Rows(i)("Agregar") = False
        '    Next
        'End If
    End Sub 'dataGrid2_MouseUp 

    Private Sub dgCobrosTotales_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCobrosTotales.CurrentCellChanged
        For i = 0 To ds.Tables("Cobros").Rows.Count - 1
            If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 4 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 7 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 6 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 10 Then 'Título y Totales
                dgCobrosTotales.Select(i)
            Else
                dgCobrosTotales.UnSelect(i)
            End If
        Next
    End Sub

    Private Sub dgCobrosTotales_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCobrosTotales.Click
        For i = 0 To ds.Tables("Cobros").Rows.Count - 1
            If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 4 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 7 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 6 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 10 Then 'Título y Totales
                dgCobrosTotales.Select(i)
            Else
                dgCobrosTotales.UnSelect(i)
            End If
        Next
    End Sub

    'Private Sub dgCobrosTotales_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgCobrosTotales.MouseDown
    '    dgCobrosTotales.UnSelect(dgCobrosTotales.CurrentRowIndex)
    '    For i = 0 To ds.Tables("Cobros").Rows.Count - 1
    '        If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 5 Then 'Título
    '            dgCobrosTotales.Select(i)
    '        Else
    '            dgCobrosTotales.UnSelect(i)
    '        End If
    '    Next
    'End Sub

    Private Sub cmdArqueo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdArqueo.Click
        'Dim f As frmArqueo = f.Instance
        'f.MdiParent = Me.MdiParent
        'f.Show()

        'Dim f As frmAgregarArqueo = f.Instance
        'f.MdiParent = Me.MdiParent
        'f.Show()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        'ds = Clientes.ChequesXBanco(Banco, dtpFecha.Value.Date, 1, 1)
        'Dim ds1 As DataSet
        If Me.cbDepositos.SelectedValue = Nothing Then
            MsgBox("Seleccione una hoja de Deposito", MsgBoxStyle.Information)
            Me.cbDepositos.Focus()
            Exit Sub
        End If
        Dim dsCobrosxFecha As DataSet
        Dim dsCompxFecha As DataSet
        Dim j As Integer
        Dim MontoAsignar As Double
        Try
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Agregar") = True Then
                    If ds.Tables("Cobros").Rows(i).Item("Orden") = 2 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 5 Then 'Cheques
                        dsCobrosxFecha = Clientes.ChequesXBancoEstado(tCust.Rows(i)("Codigo"), dtpFecha.Value.Date, 0)
                        For j = 0 To dsCobrosxFecha.Tables("Cobros").Rows.Count - 1
                            Depositos.AddItemDetalles(cbDepositos.SelectedValue, dsCobrosxFecha.Tables("Cobros").Rows(j)("Numero"), dsCobrosxFecha.Tables("Cobros").Rows(j)("Monto"))
                            Clientes.CobrosUpdateEstado(dsCobrosxFecha.Tables("Cobros").Rows(j)("Numero"), 1)
                            Clientes.CobrosUpdateMontoDepositado(dsCobrosxFecha.Tables("Cobros").Rows(j)("Numero"), dsCobrosxFecha.Tables("Cobros").Rows(j)("Monto"))
                            'MsgBox(ds1.Tables("Cobros").Rows(j)("Numero") & " - " & ds1.Tables("Cobros").Rows(j)("No Cheque"))
                        Next
                    ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 7 Then 'Efectivo
                        dsCobrosxFecha = Clientes.CobrosXFecha(dtpFecha.Value.Date)
                        MontoAsignar = tCust.Rows(i)("Pendientes")
                        For j = 0 To dsCobrosxFecha.Tables("Cobros").Rows.Count - 1
                            If MontoAsignar = dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo") Then
                                Depositos.AddItemDetalles(cbDepositos.SelectedValue, dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), MontoAsignar)
                                Clientes.CobrosUpdateMontoDepositado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), MontoAsignar)
                                Clientes.CobrosUpdateEstado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), 1)
                                Exit For
                            ElseIf MontoAsignar < dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo") Then
                                Depositos.AddItemDetalles(cbDepositos.SelectedValue, dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), MontoAsignar)
                                Clientes.CobrosUpdateMontoDepositado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), MontoAsignar)
                                Exit For
                            ElseIf MontoAsignar > dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo") Then
                                Depositos.AddItemDetalles(cbDepositos.SelectedValue, dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo"))
                                Clientes.CobrosUpdateMontoDepositado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo"))
                                Clientes.CobrosUpdateEstado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), 1)
                                MontoAsignar = MontoAsignar - dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo")
                            End If
                        Next
                    ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 9 Then 'Efectivo
                        'Buscar todos los comprobantes de esa fecha
                        dsCompxFecha = Comprobantes.ComprobanteBuscarXFecha(Me.dtpFecha.Value.Date)
                        For j = 0 To dsCompxFecha.Tables("Comp").Rows.Count - 1
                            Depositos.OtrosIngresosDelete(dsCompxFecha.Tables("Comp").Rows(j).Item("Comp_No"), dsCompxFecha.Tables("Comp").Rows(j).Item("Per_ID"), dsCompxFecha.Tables("Comp").Rows(j).Item("Comp_Fecha"))
                            Comprobantes.PagosFactura(dsCompxFecha.Tables("Comp").Rows(j).Item("Comp_No"), dsCompxFecha.Tables("Comp").Rows(j).Item("Per_ID"), dsCompxFecha.Tables("Comp").Rows(j).Item("Comp_Fecha"), dsCompxFecha.Tables("Comp").Rows(j).Item("Monto"), dsCompxFecha.Tables("Comp").Rows(j).Item("Comp_No"), dsCompxFecha.Tables("Comp").Rows(j).Item("Per_ID"), dsCompxFecha.Tables("Comp").Rows(j).Item("Comp_Fecha"), cbDepositos.SelectedValue, 0, 0)
                        Next

                    End If
                End If
            Next

            VB.SysContab.Rutinas.okTransaccion()

            ds = Clientes.CobrosXTotales(dtpFecha.Value.Date)

            MakeDataSet()
            dgCobrosTotales.SetDataBinding(myDataSet, "Item")
            AddCustomDataTableStyle()

            For i = 0 To ds.Tables("Cobros").Rows.Count - 1
                If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 4 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 7 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 6 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 10 Then 'Título y Totales
                    dgCobrosTotales.Select(i)
                End If
            Next
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox(ex.Message & "Aceptar")
            Exit Sub
        End Try


    End Sub

    Public Fecha1 As String
    Public Fecha2 As String

    Private Sub cBoxFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBoxFecha.CheckedChanged
        If cBoxFecha.Checked = True Then
            Fecha1 = dtpFecha1.Value.Date
            Fecha2 = dtpFecha1.Value.Date
            dtpFecha1.Enabled = True
        Else
            dtpFecha1.Enabled = False
            Fecha1 = ""
            Fecha2 = ""
        End If

        cbDepositos.DataSource = Depositos.List(0, Fecha1, Fecha2, 0).Tables("Depositos")
        cbDepositos.ValueMember = "Deposito_ID"
        cbDepositos.DisplayMember = "DisplayMember"
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        'If Fecha1 = Nothing Then
        '    Exit Sub
        'End If

        Fecha1 = dtpFecha1.Value.Date
        Fecha2 = dtpFecha1.Value.Date

        cbDepositos.DataSource = Depositos.List(0, Fecha1, Fecha2, 0).Tables("Depositos")
        cbDepositos.ValueMember = "Deposito_ID"
        cbDepositos.DisplayMember = "DisplayMember"
    End Sub

End Class
