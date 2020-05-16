
Imports System.IO
Imports System.Data.SqlClient

Public Class frmCargaInventarioBodega_Edit
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmCargaInventarioBodega_Edit = Nothing

    Public Shared Function Instance() As frmCargaInventarioBodega_Edit
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmCargaInventarioBodega_Edit
        End If
        ChildInstance.BringToFront()
        Return ChildInstance
    End Function
    Dim r As New VB.SysContab.Rutinas
    Dim Bodega As New VB.SysContab.BodegasDB

    Dim WithEvents tCust As DataTable
    Private WithEvents ds As DataSet

    Dim Fisico As DataGridTextBoxColumn
    Dim Diferencias As DataGridTextBoxColumn
    Dim Existencias As DataGridTextBoxColumn

    Dim ValorFisicoActual As Double

    Dim Articulos As New VB.SysContab.ArticulosDetails
    Dim fArticulos As New VB.SysContab.ArticulosDB


    Dim GruposP As New VB.SysContab.Grupos_InventarioDB
    Dim GruposCC As New VB.SysContab.GruposCCDB

    Public CBodega As String
    Public dFecha As Date
    Public TipoArticulo As String


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
    Friend WithEvents cmdImportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Exportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgErrores As System.Windows.Forms.DataGrid
    Friend WithEvents lblErrores As System.Windows.Forms.Label
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRealizadoPor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbOrigenInventario As System.Windows.Forms.ComboBox
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents cbLineas As System.Windows.Forms.ComboBox
    Friend WithEvents cbGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents cbSubGrupos As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbBodega = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.dgArticulos = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.Exportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImportar = New DevExpress.XtraEditors.SimpleButton()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.dgErrores = New System.Windows.Forms.DataGrid()
        Me.lblErrores = New System.Windows.Forms.Label()
        Me.txtRealizadoPor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbLineas = New System.Windows.Forms.ComboBox()
        Me.cbGrupos = New System.Windows.Forms.ComboBox()
        Me.cbSubGrupos = New System.Windows.Forms.ComboBox()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbOrigenInventario = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbBodega
        '
        Me.cbBodega.Enabled = False
        Me.cbBodega.Location = New System.Drawing.Point(144, 9)
        Me.cbBodega.Name = "cbBodega"
        Me.cbBodega.Size = New System.Drawing.Size(216, 21)
        Me.cbBodega.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 25)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Bodega:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(144, 34)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(120, 21)
        Me.dtpFecha.TabIndex = 95
        '
        'dgArticulos
        '
        Me.dgArticulos.DataMember = ""
        Me.dgArticulos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgArticulos.Location = New System.Drawing.Point(16, 172)
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.Size = New System.Drawing.Size(856, 379)
        Me.dgArticulos.TabIndex = 96
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdGuardar)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.Exportar)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdImportar)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 560)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(856, 60)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(648, 17)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(96, 35)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Text = "Guardar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(752, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(96, 35)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "Salir"
        '
        'Exportar
        '
        Me.Exportar.Location = New System.Drawing.Point(216, 17)
        Me.Exportar.Name = "Exportar"
        Me.Exportar.Size = New System.Drawing.Size(96, 35)
        Me.Exportar.TabIndex = 2
        Me.Exportar.Text = "Exportar Formato Carga"
        Me.Exportar.Visible = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(112, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(96, 35)
        Me.cmdImprimir.TabIndex = 1
        Me.cmdImprimir.Text = "Imprimir Formato Carga"
        Me.cmdImprimir.Visible = False
        '
        'cmdImportar
        '
        Me.cmdImportar.Location = New System.Drawing.Point(8, 17)
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.Size = New System.Drawing.Size(96, 35)
        Me.cmdImportar.TabIndex = 0
        Me.cmdImportar.Text = "Importar Archivo Inventario Fisico"
        Me.cmdImportar.Visible = False
        '
        'dgErrores
        '
        Me.dgErrores.DataMember = ""
        Me.dgErrores.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgErrores.Location = New System.Drawing.Point(16, 103)
        Me.dgErrores.Name = "dgErrores"
        Me.dgErrores.Size = New System.Drawing.Size(856, 448)
        Me.dgErrores.TabIndex = 98
        Me.dgErrores.Visible = False
        '
        'lblErrores
        '
        Me.lblErrores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrores.ForeColor = System.Drawing.Color.Firebrick
        Me.lblErrores.Location = New System.Drawing.Point(664, 69)
        Me.lblErrores.Name = "lblErrores"
        Me.lblErrores.Size = New System.Drawing.Size(200, 17)
        Me.lblErrores.TabIndex = 99
        Me.lblErrores.Text = "Ver Errores de Importación"
        Me.lblErrores.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblErrores.Visible = False
        '
        'txtRealizadoPor
        '
        Me.txtRealizadoPor.Enabled = False
        Me.txtRealizadoPor.Location = New System.Drawing.Point(144, 60)
        Me.txtRealizadoPor.MaxLength = 50
        Me.txtRealizadoPor.Name = "txtRealizadoPor"
        Me.txtRealizadoPor.Size = New System.Drawing.Size(328, 21)
        Me.txtRealizadoPor.TabIndex = 100
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 18)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Realizado Por:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(24, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 26)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Linea:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(24, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Grupo:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(408, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 26)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Subgrupo:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(408, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Articulo:"
        '
        'cbLineas
        '
        Me.cbLineas.Location = New System.Drawing.Point(128, 17)
        Me.cbLineas.Name = "cbLineas"
        Me.cbLineas.Size = New System.Drawing.Size(216, 24)
        Me.cbLineas.TabIndex = 106
        '
        'cbGrupos
        '
        Me.cbGrupos.Location = New System.Drawing.Point(128, 43)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.Size = New System.Drawing.Size(216, 24)
        Me.cbGrupos.TabIndex = 107
        '
        'cbSubGrupos
        '
        Me.cbSubGrupos.Location = New System.Drawing.Point(520, 17)
        Me.cbSubGrupos.Name = "cbSubGrupos"
        Me.cbSubGrupos.Size = New System.Drawing.Size(216, 24)
        Me.cbSubGrupos.TabIndex = 108
        '
        'txtArticulo
        '
        Me.txtArticulo.Location = New System.Drawing.Point(520, 43)
        Me.txtArticulo.MaxLength = 50
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(328, 22)
        Me.txtArticulo.TabIndex = 109
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbLineas)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cbGrupos)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbSubGrupos)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtArticulo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(16, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(856, 78)
        Me.GroupBox2.TabIndex = 110
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda:"
        Me.GroupBox2.Visible = False
        '
        'cbOrigenInventario
        '
        Me.cbOrigenInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrigenInventario.Items.AddRange(New Object() {"Productos de Consumo", "Activo Fijo", "Articulos"})
        Me.cbOrigenInventario.Location = New System.Drawing.Point(656, 9)
        Me.cbOrigenInventario.Name = "cbOrigenInventario"
        Me.cbOrigenInventario.Size = New System.Drawing.Size(216, 21)
        Me.cbOrigenInventario.TabIndex = 112
        Me.cbOrigenInventario.Text = "Productos de Consumo"
        Me.cbOrigenInventario.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(520, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 25)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Origen Inventario:"
        Me.Label8.Visible = False
        '
        'frmCargaInventarioBodega_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(888, 613)
        Me.Controls.Add(Me.cbOrigenInventario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblErrores)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRealizadoPor)
        Me.Controls.Add(Me.dgErrores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgArticulos)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbBodega)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmCargaInventarioBodega_Edit"
        Me.Text = "Carga de Inventario de Bodega"
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgErrores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private myCheckBoxCol As Integer = 5 'my checkbox column 

    Private Sub frmCargaInventarioBodega_Edit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        VB.SysContab.Rutinas.CambiarEstilo(Me)

        Me.cbBodega.DataSource = Bodega.GetList().Tables(0)
        Me.cbBodega.ValueMember = "CODIGO"
        Me.cbBodega.DisplayMember = "UBICACION"

        Me.cbBodega.SelectedValue = Me.CBodega
        Me.dtpFecha.Value = Me.dFecha
        Me.txtRealizadoPor.Text = Usuario

        Me.cbBodega.Enabled = False
        Me.dtpFecha.Enabled = False
        Me.txtRealizadoPor.Enabled = False

        tCust = New DataTable("Articulos")
        ds = New DataSet("dsArticulos")
        ds.Tables.Add(tCust)
        VB.SysContab.BodegasDB.GetList_InventarioFisico_Detalle(Me.CBodega, Me.dFecha, ds, Me.TipoArticulo)
        Me.dgArticulos.DataSource = ds.Tables(0).DefaultView
        r.FormatGenerico(dgArticulos, ds.Tables(0))

        AddCustomDataTableStyle()
        Me.Refresh()


    End Sub


    Private Sub AddCustomDataTableStyle()

        'STEP 1: Create a DataTable style object and set properties if required.
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle
        'specify the table from dataset (required step)
        ts1.MappingName = "Articulos"
        ' Set other properties (optional step)
        ts1.AlternatingBackColor = Color.LightBlue
        ts1.SelectionBackColor = Color.RosyBrown


        Dim colCount As Integer
        colCount = 0

        Dim CArticulo As New DataGridTextBoxColumn
        CArticulo.MappingName = "Codigo"
        CArticulo.HeaderText = "Código"
        CArticulo.ReadOnly = True
        CArticulo.Alignment = HorizontalAlignment.Left
        CArticulo.Width = 80
        CArticulo.NullText = ""

        ts1.GridColumnStyles.Add(CArticulo)
        colCount = (colCount + 1)



        Dim nArticulo As New DataGridTextBoxColumn
        nArticulo.MappingName = "Nombre"
        nArticulo.HeaderText = "Nombre"
        nArticulo.ReadOnly = True
        nArticulo.Alignment = HorizontalAlignment.Left
        nArticulo.Width = 200
        nArticulo.NullText = ""

        ts1.GridColumnStyles.Add(nArticulo)
        colCount = (colCount + 1)


        Existencias = New DataGridTextBoxColumn
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

        Fisico = New DataGridTextBoxColumn
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

        Diferencias = New DataGridTextBoxColumn
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

        Dim nComentario As New DataGridTextBoxColumn
        nComentario.MappingName = "Comentarios"
        nComentario.HeaderText = "Comentarios"
        nComentario.ReadOnly = False
        nComentario.Alignment = HorizontalAlignment.Left
        nComentario.Width = 200
        nComentario.NullText = ""

        ts1.GridColumnStyles.Add(nComentario)
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
            e.Row.Item(7) = IIf(e.Row.Item(0), IIf(e.Row.Item(5) <> 0, "Diferencias en el Físico", ""), "No existe Producto en el registro de la Bodega")
            e.Row.AcceptChanges()
            'aplicarfiltro()
        End If
    End Sub

    Private Sub tCust_RowDeleted(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs) Handles tCust.RowDeleted
        e.Row.AcceptChanges()
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
            For i = 0 To tCust.Rows.Count - 1
                'Actualizar el detalle de Inventario Fisico
                VB.SysContab.BodegasDB.InventarioFisicoDetalle_Update(Me.cbBodega.SelectedValue, Me.dtpFecha.Value, tCust.Rows(i)("codigo"), _
                 tCust.Rows(i)("Fisico"), tCust.Rows(i)("Diferencias"), _
                 tCust.Rows(i)("Justificar"), tCust.Rows(i)("Comentarios").ToString)

            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
            VB.SysContab.Rutinas.ErrorTransaccion()
        End Try
        VB.SysContab.Rutinas.okTransaccion()
        Me.Close()
    End Sub
   
    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim tablaLocal As New DataTable
        Dim lds As New DataSet

        tablaLocal = tCust.Copy
        lds.Tables.Add(tablaLocal)

        Try
            lds.WriteXml(Application.StartupPath & "\xml\TCust.xml", XmlWriteMode.WriteSchema)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
            Exit Sub
        End Try

        'Dim Reporte As New rptCargaInventarioFisico
        Dim fReportes As New frmReportes
        Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Reporte.Load(Application.StartupPath & "\Reportes\rptCargaInventarioFisico.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
        Reporte.Database.Tables("Articulos").Location = Application.StartupPath & "\xml\TCust.xml"

        fReportes.crvReportes.ReportSource = Reporte
        fReportes.Show()

    End Sub

    Private Sub frmCargaInventarioBodega_Edit_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim d As frmCargadeInventarioBodega_List = frmCargadeInventarioBodega_List.Instance

        Dim ds As New DataSet
        ds = VB.SysContab.BodegasDB.GetList_InventarioFisico(Microsoft.VisualBasic.Left(d.cbFiltro.Text, 1), d.cbbodega.SelectedValue)
        d.dgInventariosFisicos.DataSource = ds.Tables(0).DefaultView
        r.FormatGenerico(d.dgInventariosFisicos, ds.Tables(0))
    End Sub

    Private Sub lblErrores_Click(sender As Object, e As EventArgs) Handles lblErrores.Click

    End Sub
End Class
