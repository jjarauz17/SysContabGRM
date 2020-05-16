
Imports System.IO
Imports System.Data.SqlClient

Public Class frmCargadeInventarioBodega_Justificar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmCargadeInventarioBodega_Justificar = Nothing

    Public Shared Function Instance() As frmCargadeInventarioBodega_Justificar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmCargadeInventarioBodega_Justificar()
        End If
        ChildInstance.BringToFront()
        Return ChildInstance
    End Function

    Public CodigoBodega As String
    Public Fecha As Date
    Public TipoArticulo As String

    Dim r As New VB.SysContab.Rutinas()
    Dim Bodega As New VB.SysContab.BodegasDB()

    Dim WithEvents tCust As DataTable
    Private WithEvents ds As DataSet

    Dim Fisico As DataGridTextBoxColumn
    Dim Diferencias As DataGridTextBoxColumn
    Dim Existencias As DataGridTextBoxColumn

    Dim ValorFisicoActual As Double

    Dim Articulos As New VB.SysContab.ArticulosDetails()
    Dim fArticulos As New VB.SysContab.ArticulosDB()
    Dim custDV As DataView

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
    Friend WithEvents cbBodega As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgArticulos As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAutorizadoPor As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbBodega = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.dgArticulos = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.txtAutorizadoPor = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbBodega
        '
        Me.cbBodega.Location = New System.Drawing.Point(128, 8)
        Me.cbBodega.Name = "cbBodega"
        Me.cbBodega.Size = New System.Drawing.Size(216, 21)
        Me.cbBodega.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Bodega:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha.Location = New System.Drawing.Point(128, 32)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(120, 20)
        Me.dtpFecha.TabIndex = 95
        '
        'dgArticulos
        '
        Me.dgArticulos.DataMember = ""
        Me.dgArticulos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgArticulos.Location = New System.Drawing.Point(16, 96)
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.Size = New System.Drawing.Size(856, 416)
        Me.dgArticulos.TabIndex = 96
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdGuardar)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 520)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(856, 56)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Imprimir Documento"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(8, 16)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(96, 32)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Text = "Guardar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(752, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(96, 32)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Salir"
        '
        'txtAutorizadoPor
        '
        Me.txtAutorizadoPor.Location = New System.Drawing.Point(128, 56)
        Me.txtAutorizadoPor.MaxLength = 50
        Me.txtAutorizadoPor.Name = "txtAutorizadoPor"
        Me.txtAutorizadoPor.Size = New System.Drawing.Size(328, 20)
        Me.txtAutorizadoPor.TabIndex = 100
        Me.txtAutorizadoPor.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Autorizado Por:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(16, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(856, 72)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda:"
        Me.GroupBox2.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label7.Location = New System.Drawing.Point(408, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Articulo:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(128, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 24)
        Me.ComboBox1.TabIndex = 106
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label6.Location = New System.Drawing.Point(408, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 24)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Subgrupo:"
        '
        'ComboBox2
        '
        Me.ComboBox2.Location = New System.Drawing.Point(128, 40)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(216, 24)
        Me.ComboBox2.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 24)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Linea:"
        '
        'ComboBox3
        '
        Me.ComboBox3.Location = New System.Drawing.Point(520, 16)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(216, 24)
        Me.ComboBox3.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Grupo:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(520, 40)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(328, 22)
        Me.TextBox1.TabIndex = 109
        Me.TextBox1.Text = ""
        '
        'frmCargadeInventarioBodega_Justificar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(888, 613)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAutorizadoPor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgArticulos)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbBodega)
        Me.Name = "frmCargadeInventarioBodega_Justificar"
        Me.Text = "Carga de Inventario de Bodega"
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private myCheckBoxCol As Integer = 5 'my checkbox column 

    Private Sub frmCargaDeInventarioBodega_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        VB.SysContab.Rutinas.CambiarEstilo(Me)

        Me.cbBodega.DataSource = Bodega.GetList().Tables(0)
        Me.cbBodega.ValueMember = "CODIGO"
        Me.cbBodega.DisplayMember = "UBICACION"

        Me.txtAutorizadoPor.Text = Usuario

        'Cargar el dato

        Me.cbBodega.SelectedValue = Me.CodigoBodega
        Me.dtpFecha.Value = Me.Fecha

        Me.cbBodega.Enabled = False
        Me.dtpFecha.Enabled = False
        Me.txtAutorizadoPor.Enabled = False


        tCust = New DataTable("Articulos")
        ds = New DataSet("dsArticulos")
        ds.Tables.Add(tCust)
        VB.SysContab.BodegasDB.GetList_InventarioFisico_Detalle(Me.CodigoBodega, Me.Fecha, ds, Me.TipoArticulo)
        custDV = New DataView(tCust, "", "Codigo", DataViewRowState.CurrentRows)
        Me.dgArticulos.DataSource = ds.Tables(0).DefaultView
        r.FormatGenerico(dgArticulos, ds.Tables(0))

        AddCustomDataTableStyle()
        'Me.lblErrores.Text = "Ver Errores de Importación"
        Me.Refresh()

    End Sub


    Private Sub AddCustomDataTableStyle()

        'STEP 1: Create a DataTable style object and set properties if required.
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle()
        'specify the table from dataset (required step)
        ts1.MappingName = "Articulos"
        ' Set other properties (optional step)
        ts1.AlternatingBackColor = Color.LightBlue
        ts1.SelectionBackColor = Color.RosyBrown


        Dim colCount As Integer
        colCount = 0

        Dim CArticulo As New DataGridTextBoxColumn()
        CArticulo.MappingName = "Codigo"
        CArticulo.HeaderText = "Código"
        CArticulo.ReadOnly = True
        CArticulo.Alignment = HorizontalAlignment.Left
        CArticulo.Width = 80
        CArticulo.NullText = ""

        ts1.GridColumnStyles.Add(CArticulo)
        colCount = (colCount + 1)



        Dim nArticulo As New DataGridTextBoxColumn()
        nArticulo.MappingName = "Nombre"
        nArticulo.HeaderText = "Nombre"
        nArticulo.ReadOnly = True
        nArticulo.Alignment = HorizontalAlignment.Left
        nArticulo.Width = 200
        nArticulo.NullText = ""

        ts1.GridColumnStyles.Add(nArticulo)
        colCount = (colCount + 1)


        Existencias = New DataGridTextBoxColumn()
        Existencias.MappingName = "Existencias"
        Existencias.HeaderText = "Existencias"
        Existencias.ReadOnly = True
        Existencias.Alignment = HorizontalAlignment.Left
        Existencias.Width = 50
        Existencias.NullText = ""
        Existencias.Format = "##,###0.00"

        ts1.GridColumnStyles.Add(Existencias)
        colCount = (colCount + 1)
        Existencias.NullText = "0"

        Fisico = New DataGridTextBoxColumn()
        Fisico.MappingName = "Fisico"
        Fisico.HeaderText = "Físico"
        Fisico.Width = 50
        Fisico.Alignment = HorizontalAlignment.Right
        Fisico.ReadOnly = False
        Fisico.Format = "##,###0.00"

        AddHandler Fisico.TextBox.Leave, New EventHandler(AddressOf TextBoxFisicoLeaveHandler)

        ts1.GridColumnStyles.Add(Fisico)
        colCount = (colCount + 1)

        Fisico.NullText = "0"

        Diferencias = New DataGridTextBoxColumn()
        Diferencias.MappingName = "Diferencias"
        Diferencias.HeaderText = "Diferencias"
        Diferencias.ReadOnly = True
        Diferencias.Alignment = HorizontalAlignment.Left
        Diferencias.Width = 50
        Diferencias.NullText = ""
        Diferencias.Format = "##,###0.00"

        ts1.GridColumnStyles.Add(Diferencias)
        colCount = (colCount + 1)
        Diferencias.NullText = "0"

        Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        boolCol.MappingName = "Justificar"
        boolCol.HeaderText = "Justificar"
        boolCol.Alignment = HorizontalAlignment.Center

        CType(boolCol, DataGridBoolColumn).AllowNull = False

        boolCol.Width = 70
        boolCol.ReadOnly = False

        boolCol.NullText = ""
        myCheckBoxCol = colCount

        AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)

        ts1.GridColumnStyles.Add(boolCol)
        colCount = (colCount + 1)

        Dim nComentario As New DataGridTextBoxColumn()
        nComentario.MappingName = "Comentarios"
        nComentario.HeaderText = "Comentarios"
        nComentario.ReadOnly = True
        nComentario.Alignment = HorizontalAlignment.Left
        nComentario.Width = 200
        nComentario.NullText = ""

        ts1.GridColumnStyles.Add(nComentario)
        colCount = (colCount + 1)

        Dim JComentario As New DataGridTextBoxColumn()
        JComentario.MappingName = "Comentarios_Justificar"
        JComentario.HeaderText = "Comentarios de Justificación"
        JComentario.ReadOnly = False
        JComentario.Alignment = HorizontalAlignment.Left
        JComentario.Width = 200
        JComentario.NullText = ""

        ts1.GridColumnStyles.Add(JComentario)
        colCount = (colCount + 1)

        ts1.AllowSorting = False
        ts1.GridLineColor = Color.FromArgb(70, 130, 180)
        ts1.HeaderFont = Me.dgArticulos.HeaderFont
        ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
        ts1.PreferredRowHeight = 25

        ds.Tables("Articulos").DefaultView.AllowDelete = False
        ds.Tables("Articulos").DefaultView.AllowNew = False
        ds.Tables("Articulos").DefaultView.AllowEdit = True

        dgArticulos.TableStyles.Clear()
        dgArticulos.TableStyles.Add(ts1)

    End Sub

    Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
        Dim s As String
        s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
        Console.WriteLine(s)
    End Sub

    Private Sub TextBoxFisicoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)

        If Not IsNumeric(Fisico.TextBox.Text) Then
            Fisico.TextBox.Text = ValorFisicoActual.ToString(Round)
        Else
            If CDbl(Fisico.TextBox.Text) < 0 Then
                MsgBox("La cantidad debe ser mayor o igual a Cero (0)", MsgBoxStyle.Information)
                Fisico.TextBox.Text = ValorFisicoActual.ToString(Round)
                Exit Sub
            Else
                Fisico.TextBox.Text = CDbl(Fisico.TextBox.Text).ToString(Round)
            End If
        End If
    End Sub

    Private Sub tCust_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tCust.ColumnChanged
        If e.Column.Ordinal = 4 Then
            If Not IsNumeric(e.Row.Item(4)) Then
                e.Row.Item(4) = ValorFisicoActual
            End If

            If Not (e.Row.Item(4) Is DBNull.Value) And Not (e.Row.Item(3) Is DBNull.Value) Then
                e.Row.Item(5) = e.Row.Item(3) - e.Row.Item(4)
            End If
            e.Row.Item(6) = IIf(e.Row.Item(5) <> 0, True, False)
            e.Row.Item(7) = IIf(e.Row.Item(0), "Diferencias en el Físico", "No existe Producto en el registro de la Bodega")
        End If
    End Sub

    Private Sub tCust_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles tCust.RowDeleted

    End Sub

    Private Sub dgArticulos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgArticulos.CurrentCellChanged
        ValorFisicoActual = tCust.Rows(dgArticulos.CurrentRowIndex)("fisico")
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    

    

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim i As Integer
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()
        Try
            'If hay mas de un registro que procesar
            If tCust.Compute("Count(Justificar)", "Justificar= 1") = 0 Then
                MsgBox("No se han marcado registros para Justificar en el Inventario Fisico", MsgBoxStyle.Information, "STS-Contab")
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If
            'Agregar la Transaccion de Bodega
            Dim cAjuste As String
            Dim nJustificar As Integer
            cAjuste = VB.SysContab.BodegasDB.GetDocumento_CodigoNuevo("A")
            VB.SysContab.BodegasDB.TransaccionBodega_Add(Me.cbBodega.SelectedValue, "A", cAjuste, Me.dtpFecha.Value, 0)

            'Actualizar el Detalle
            For i = 0 To tCust.Rows.Count - 1
                nJustificar = 1
                If tCust.Rows(i)("Diferencias") <> 0 Then
                    If tCust.Rows(i)("Justificar") = True Then
                        nJustificar = 2
                    Else
                        nJustificar = 3
                    End If
                Else
                    nJustificar = 0
                End If

                '                If tCust.Rows(i)("Diferencias") <> 0 Then
                '                    If tCust.Rows(i)("Justificar") Then
                'Actualizar la Cantidad Justificada, El Comentario de Justificacion en Fisico_Detalle
                VB.SysContab.BodegasDB.InventarioFisicoDetalle_UpdateJustificacion(Me.cbBodega.SelectedValue, Me.dtpFecha.Value, _
                         tCust.Rows(i)("Codigo"), tCust.Rows(i)("Fisico"), tCust.Rows(i)("Diferencias"), _
                         nJustificar, tCust.Rows(i)("Comentarios_Justificar"))

                        'Agregar el detalle de transaccion de bodega
                VB.SysContab.BodegasDB.TransaccionBodegaDetalle_Add(Me.cbBodega.SelectedValue, _
                    tCust.Rows(i)("Codigo"), "A", cAjuste, _
                    IIf(tCust.Rows(i)("diferencias") < 0, "E", "S"), Math.Abs(tCust.Rows(i)("Diferencias")), _
                    tCust.Rows(i)("Costo"), 0, "")
                '    End If
                'End If
            Next
            'Actualizar el Encabezado del Inventario Fisico
            VB.SysContab.BodegasDB.InventarioFisico_Autorizar(Me.cbBodega.SelectedValue, Me.dtpFecha.Value, _
                True, Me.txtAutorizadoPor.Text, cAjuste)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
            VB.SysContab.Rutinas.ErrorTransaccion()
        End Try
        VB.SysContab.Rutinas.okTransaccion()
        Me.Close()
    End Sub

    Private Sub frmCargadeInventarioBodega_Justificar_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim d As frmCargadeInventarioBodega_List = frmCargadeInventarioBodega_List.Instance

        Dim ds As New DataSet
        ds = VB.SysContab.BodegasDB.GetList_InventarioFisico(Microsoft.VisualBasic.Left(d.cbFiltro.Text, 1), d.cbbodega.SelectedValue)
        d.dgInventariosFisicos.DataSource = ds.Tables(0).DefaultView
        r.FormatGenerico(d.dgInventariosFisicos, ds.Tables(0))
    End Sub
End Class
