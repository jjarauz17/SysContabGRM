Imports System.IO
Imports System.Data.SqlClient

Public Class frmCargaDeInventarioBodega
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmCargaDeInventarioBodega = Nothing

    Public Shared Function Instance() As frmCargaDeInventarioBodega
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmCargaDeInventarioBodega()
        End If
        ChildInstance.BringToFront()
        Return ChildInstance
    End Function
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
    Dim DVFiltrada As DataView
    Dim Filtro As String
    Dim TipoArticulo As String
    Dim GruposP As New VB.SysContab.Grupos_InventarioDB
    Dim GruposCC As New VB.SysContab.GruposCCDB
    Private Cargado As Boolean

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
        Me.cbBodega = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.dgArticulos = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.Exportar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImportar = New DevExpress.XtraEditors.SimpleButton
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.dgErrores = New System.Windows.Forms.DataGrid
        Me.lblErrores = New System.Windows.Forms.Label
        Me.txtRealizadoPor = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbLineas = New System.Windows.Forms.ComboBox
        Me.cbGrupos = New System.Windows.Forms.ComboBox
        Me.cbSubGrupos = New System.Windows.Forms.ComboBox
        Me.txtArticulo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbOrigenInventario = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbBodega
        '
        Me.cbBodega.Location = New System.Drawing.Point(144, 8)
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
        Me.dtpFecha.Location = New System.Drawing.Point(144, 32)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(120, 20)
        Me.dtpFecha.TabIndex = 95
        '
        'dgArticulos
        '
        Me.dgArticulos.DataMember = ""
        Me.dgArticulos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgArticulos.Location = New System.Drawing.Point(16, 160)
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.Size = New System.Drawing.Size(856, 280)
        Me.dgArticulos.TabIndex = 96
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdGuardar)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.Exportar)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdImportar)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 448)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(856, 56)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(648, 16)
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
        'Exportar
        '
        Me.Exportar.Location = New System.Drawing.Point(216, 16)
        Me.Exportar.Name = "Exportar"
        Me.Exportar.Size = New System.Drawing.Size(96, 32)
        Me.Exportar.TabIndex = 2
        Me.Exportar.Text = "Exportar Formato Carga"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(112, 16)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(96, 32)
        Me.cmdImprimir.TabIndex = 1
        Me.cmdImprimir.Text = "Imprimir Formato Carga"
        '
        'cmdImportar
        '
        Me.cmdImportar.Location = New System.Drawing.Point(8, 16)
        Me.cmdImportar.Name = "cmdImportar"
        Me.cmdImportar.Size = New System.Drawing.Size(96, 32)
        Me.cmdImportar.TabIndex = 0
        Me.cmdImportar.Text = "Importar Archivo Inventario Fisico"
        '
        'dgErrores
        '
        Me.dgErrores.DataMember = ""
        Me.dgErrores.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgErrores.Location = New System.Drawing.Point(16, 160)
        Me.dgErrores.Name = "dgErrores"
        Me.dgErrores.Size = New System.Drawing.Size(856, 280)
        Me.dgErrores.TabIndex = 98
        Me.dgErrores.Visible = False
        '
        'lblErrores
        '
        Me.lblErrores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrores.ForeColor = System.Drawing.Color.Firebrick
        Me.lblErrores.Location = New System.Drawing.Point(664, 64)
        Me.lblErrores.Name = "lblErrores"
        Me.lblErrores.Size = New System.Drawing.Size(200, 16)
        Me.lblErrores.TabIndex = 99
        Me.lblErrores.Text = "Ver Errores de Importación"
        Me.lblErrores.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblErrores.Visible = False
        '
        'txtRealizadoPor
        '
        Me.txtRealizadoPor.Enabled = False
        Me.txtRealizadoPor.Location = New System.Drawing.Point(144, 56)
        Me.txtRealizadoPor.MaxLength = 50
        Me.txtRealizadoPor.Name = "txtRealizadoPor"
        Me.txtRealizadoPor.Size = New System.Drawing.Size(328, 20)
        Me.txtRealizadoPor.TabIndex = 100
        Me.txtRealizadoPor.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Realizado Por:"
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
        'cbLineas
        '
        Me.cbLineas.Location = New System.Drawing.Point(128, 16)
        Me.cbLineas.Name = "cbLineas"
        Me.cbLineas.Size = New System.Drawing.Size(216, 24)
        Me.cbLineas.TabIndex = 106
        '
        'cbGrupos
        '
        Me.cbGrupos.Location = New System.Drawing.Point(128, 40)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.Size = New System.Drawing.Size(216, 24)
        Me.cbGrupos.TabIndex = 107
        '
        'cbSubGrupos
        '
        Me.cbSubGrupos.Location = New System.Drawing.Point(520, 16)
        Me.cbSubGrupos.Name = "cbSubGrupos"
        Me.cbSubGrupos.Size = New System.Drawing.Size(216, 24)
        Me.cbSubGrupos.TabIndex = 108
        '
        'txtArticulo
        '
        Me.txtArticulo.Location = New System.Drawing.Point(520, 40)
        Me.txtArticulo.MaxLength = 50
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(328, 22)
        Me.txtArticulo.TabIndex = 109
        Me.txtArticulo.Text = ""
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
        Me.GroupBox2.Location = New System.Drawing.Point(16, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(856, 72)
        Me.GroupBox2.TabIndex = 110
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda:"
        '
        'cbOrigenInventario
        '
        Me.cbOrigenInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrigenInventario.Items.AddRange(New Object() {"Productos de Consumo", "Activo Fijo", "Articulos"})
        Me.cbOrigenInventario.Location = New System.Drawing.Point(656, 8)
        Me.cbOrigenInventario.Name = "cbOrigenInventario"
        Me.cbOrigenInventario.Size = New System.Drawing.Size(216, 21)
        Me.cbOrigenInventario.TabIndex = 112
        Me.cbOrigenInventario.Text = "Productos de Consumo"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label8.Location = New System.Drawing.Point(520, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 24)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Origen Inventario:"
        '
        'frmCargaDeInventarioBodega
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(888, 522)
        Me.Controls.Add(Me.cbOrigenInventario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblErrores)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRealizadoPor)
        Me.Controls.Add(Me.dgErrores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgArticulos)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbBodega)
        Me.Name = "frmCargaDeInventarioBodega"
        Me.Text = "Carga de Inventario de Bodega"
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgErrores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private myCheckBoxCol As Integer = 5 'my checkbox column 

    Private Sub frmCargaDeInventarioBodega_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cargado = False

        VB.SysContab.Rutinas.CambiarEstilo(Me)
        Me.Filtro = ""
        Me.cbBodega.DataSource = Bodega.GetList()
        Me.cbBodega.ValueMember = "CODIGO"
        Me.cbBodega.DisplayMember = "UBICACION"
        Me.txtRealizadoPor.Text = Usuario
        Me.cbBodega.SelectedIndex = 0
        Me.TipoArticulo = "P"
        'Me.Cargar()
        'Me.cbOrigenInventario.Text = "Articulos"
        Me.cbOrigenInventario.SelectedIndex = 2
        Me.lblErrores.Text = "Ver Errores de Importación"


        If Me.TipoArticulo = "A" Then

            cbLineas.DataSource = GruposCC.Lineas().Tables("GruposCC")
            cbLineas.ValueMember = "Código"
            cbLineas.DisplayMember = "Nombre"

            cbLineas.SelectedValue = 0

            cbGrupos.DataSource = GruposCC.Grupos(Me.cbLineas.SelectedValue).Tables("GruposCC")
            cbGrupos.ValueMember = "Código"
            cbGrupos.DisplayMember = "Nombre"

            cbSubGrupos.DataSource = GruposCC.SubGrupos(Me.cbGrupos.SelectedValue).Tables("GruposCC")
            cbSubGrupos.ValueMember = "Código"
            cbSubGrupos.DisplayMember = "Nombre"
        Else
            ''Agregar los controles de busqueda
            Me.cbLineas.DataSource = GruposP.Lineas(TipoArticulo).Tables("GruposCC")
            Me.cbLineas.ValueMember = "Código"
            Me.cbLineas.DisplayMember = "Nombre"
            Me.cbLineas.SelectedValue = 0

            Me.cbGrupos.DataSource = GruposP.Grupos(Me.cbLineas.SelectedValue, TipoArticulo).Tables("GruposCC")
            Me.cbGrupos.ValueMember = "Código"
            Me.cbGrupos.DisplayMember = "Nombre"
        End If
        Me.Cargado = True
        Me.Cargar()
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
        boolCol.MappingName = "Cargar"
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

    Private Sub Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exportar.Click
        Dim lds As New DataSet()
        VB.SysContab.BodegasDB.CargaInventarioBodega(Me.cbBodega.SelectedValue, lds, Me.TipoArticulo, "", "")
        lds.Tables("Articulos").Columns.Remove("Sistema")
        lds.Tables("Articulos").Columns.Remove("Cargar")

        Try
            'Create the FileStream to write with.
            Dim strFilename As String
            strFilename = Application.StartupPath & "\xml\CargarInventario.xml"
            Dim fs As New System.IO.FileStream(strFilename, _
               System.IO.FileMode.Create)

            'Create an XmlTextWriter for the FileStream.
            Dim xtw As New System.Xml.XmlTextWriter(fs, _
               System.Text.Encoding.Unicode)

            'Add the processing instruction to the beginning of the XML
            ' file, leaving the one which indicates a style sheet commented.
            xtw.WriteProcessingInstruction("xml", "version='1.0'")
            'xtw.WriteProcessingInstruction( _
            '"xml-stylesheet", "type='text/xsl' href='CargarInventario.xsl'")

            'Write the XML from the dataset to the file.
            lds.WriteXml(xtw)
            xtw.Close()

            MsgBox("Archivo exportado satisfactoriamente", MsgBoxStyle.Information, "STS-Contab")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
            Exit Sub
        End Try

    End Sub

    Private Sub Importar_Fisico()
        Dim xmlds As New DataSet()


        Dim nArchivo As String
        Dim myStream As Stream = Nothing
        Dim Documentos As New VB.SysContab.DocumentosDB()

        Me.OFD.InitialDirectory = Application.StartupPath()

        Me.OFD.Filter = "CSV Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|Xls Files (*.xls)|*.xls"
        Me.OFD.FilterIndex = 1
        Me.OFD.RestoreDirectory = True

        If OFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = Me.OFD.OpenFile()
            Catch Ex As Exception
                MessageBox.Show("No se puede leer el archivo. Error original: " & Ex.Message)
                Exit Sub
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If Not IsNothing(myStream) Then
                    nArchivo = Me.OFD.FileName
                    myStream.Close()
                    xmlds = New DataSet()
                    If Documentos.Leer_Archivo(nArchivo, xmlds) = -1 Then  'xmlds =VB.SysContab.RutinasNomina.LeerXML(nArchivo)
                        MsgBox("Error al cargar el archivo")
                    End If
                End If
            End Try
        End If
        If IsNothing(myStream) Then
            Exit Sub
        End If
        If xmlds.Tables(0).Columns(0).ColumnName.ToLower <> "codigo" Then
            MsgBox("El nombre del primer campo debe ser <Codigo>", MsgBoxStyle.Critical, "STS-Contab")
            Exit Sub
        End If
        If xmlds.Tables(0).Columns(1).ColumnName.ToLower <> "fisico" Then
            MsgBox("El nombre del segundo campo debe ser <Fisico>", MsgBoxStyle.Critical, "STS-Contab")
            Exit Sub
        End If

        Dim Errores As New DataSet()
        Dim i As Integer
        Dim dDSArt_Bod As New DataSet()
        Errores = xmlds.Clone()
        Errores.Tables(0).Columns.Add("TError")
        For i = 0 To xmlds.Tables(0).Rows.Count - 1
            If Not IsNumeric(xmlds.Tables(0).Rows(i)("fisico")) Then
                Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "Numero de formato inválido"
                GoTo ContinueT
            End If
            'verificar si existe el codigo en el catalogo de articulos
            Articulos = VB.SysContab.ArticulosDB.GetDetails(xmlds.Tables(0).Rows(i)("codigo"), "P", EmpresaActual)
            If Articulos.Codigo Is Nothing Or Articulos.Codigo Is DBNull.Value Then
                Errores.Tables(0).Rows.Add(xmlds.Tables(0).Rows(i).ItemArray)
                Errores.Tables(0).Rows(Errores.Tables(0).Rows.Count - 1)("TError") = "El Codigo del Articulo No existe"
            End If
            'Verificar si existe el producto asignado en la bodega
            VB.SysContab.BodegasDB.GetList_ArticulosBodega(Me.cbBodega.SelectedValue, xmlds.Tables(0).Rows(i)("codigo"), dDSArt_Bod, Me.TipoArticulo, "", "")
            'Si no existe en la bodega se debe marcar en el dataset del grid

            custDV.Sort = "Codigo"
            Indice = custDV.Find(xmlds.Tables(0).Rows(i)("Codigo"))
            If Indice >= 0 Then 'si lo encuentra
                custDV.Item(Indice).Row.Item("fisico") = xmlds.Tables(0).Rows(i)("fisico")

                'No es necesario hacer aca la diferencia, se hace en el columnchange de tcust
                'custDV.Item(Indice).Row.Item("Diferencias") = custDV.Item(Indice).Row.Item("Existencias") - xmlds.Tables(0).Rows(i)("fisico")
                'La marcada se da en columnchange de tcust
                'custDV.Item(Indice).Row.Item("Cargar") = IIf(custDV.Item(Indice).Row.Item("Diferencias") > 0, True, False)
            Else
                If Not (Articulos.Codigo Is Nothing Or Articulos.Codigo Is DBNull.Value) Then
                    'Agrear el nuevo registro de articulo, pero marcarlo como Justificar
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    tCust.Rows(tCust.Rows.Count - 1)("Sistema") = False
                    tCust.Rows(tCust.Rows.Count - 1)("Codigo") = xmlds.Tables(0).Rows(i)("Codigo")
                    tCust.Rows(tCust.Rows.Count - 1)("Nombre") = Articulos.Nombre
                    tCust.Rows(tCust.Rows.Count - 1)("Existencias") = 0.0
                    tCust.Rows(tCust.Rows.Count - 1)("Fisico") = xmlds.Tables(0).Rows(i)("Fisico")
                    'No es necesario hacer aca la diferencia, se hace en el columnchange de tcust
                    'tCust.Rows(tCust.Rows.Count - 1)("Diferencias") = xmlds.Tables(0).Rows(i)("Codigo") * -1
                    tCust.Rows(tCust.Rows.Count - 1)("Cargar") = True

                End If
            End If
ContinueT: Next
        MsgBox("Archivo Importado", MsgBoxStyle.OKOnly, "STS-Contab")
        If Errores.Tables(0).Rows.Count <> 0 Then
            'Exportar_Archivo(Errores.Tables(0), "Errores")

            dgErrores.DataSource = Errores.Tables(0).DefaultView
            r.FormatGenerico(dgErrores, Errores.Tables(0))

            dgErrores.CaptionText = "Errores de Importación de Archivos"
            Me.lblErrores.Visible = True
            Me.Refresh()
        Else
            Me.lblErrores.Visible = False
        End If
    End Sub

    Private Function Exportar_Archivo(ByVal Tablas As DataTable, ByVal Nombre As String) As Boolean
        Dim i, j As Integer
        Dim Cadena As String


        Dim objStreamWriter As StreamWriter = File.CreateText(Application.StartupPath() & "\exportfiles\" & Nombre & ".txt")
        objStreamWriter.Flush()

        For i = 0 To Tablas.Rows.Count - 1
            Cadena = ""
            For j = 0 To Tablas.Columns.Count - 1
                Cadena = Cadena & "," & Tablas.Rows(i)(j).ToString
            Next
            objStreamWriter.WriteLine(Cadena)
        Next
        objStreamWriter.Close()
        Return True
    End Function

    Private Sub cmdImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImportar.Click
        Importar_Fisico()
    End Sub

    Private Sub lblErrores_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblErrores.Click
        If Me.lblErrores.Text = "Ver Errores de Importación" Then
            Me.lblErrores.Text = "Ocultar Errores de Importación"
            Me.dgErrores.Visible = True
            Me.GroupBox1.Enabled = False
        Else
            Me.lblErrores.Text = "Ver Errores de Importación"
            Me.dgErrores.Visible = False
            Me.GroupBox1.Enabled = True
        End If

    End Sub

    
   
    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim i As Integer
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()
        If Me.cbOrigenInventario.Text.ToUpper = "PRODUCTOS DE CONSUMO" Then
            TipoArticulo = "A"
        ElseIf Me.cbOrigenInventario.Text.ToUpper = "ARTICULOS" Then
            TipoArticulo = "P"
        ElseIf Me.cbOrigenInventario.Text.ToUpper = "ACTIVO FIJO" Then
            TipoArticulo = "F"
        End If
        Try
            'Agregar el encabezado del Inventario Fisico
            VB.SysContab.BodegasDB.InventarioFisico_Add(Me.cbBodega.SelectedValue, Me.dtpFecha.Value, Me.txtRealizadoPor.Text, Me.TipoArticulo)
            For i = 0 To tCust.Rows.Count - 1
                'Agregar el detalle de Inventario Fisico
                VB.SysContab.BodegasDB.InventarioFisicoDetalle_Add(Me.cbBodega.SelectedValue, Me.dtpFecha.Value, tCust.Rows(i)("codigo"), _
                 tCust.Rows(i)("Existencias"), tCust.Rows(i)("Fisico"), tCust.Rows(i)("Diferencias"), _
                 IIf(tCust.Rows(i)("Sistema") = False, 9, IIf(tCust.Rows(i)("Cargar") = False, 0, 1)), tCust.Rows(i)("Comentarios"), Me.TipoArticulo)

            Next
            VB.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
            VB.SysContab.Rutinas.ErrorTransaccion()
        End Try

    End Sub
    

    Private Sub Cargar()
        If Me.Cargado = True Then
            If Me.cbBodega.DataSource.rows.count > 0 Then
                tCust = New DataTable("Articulos")
                ds = New DataSet("dsArticulos")
                ds.Tables.Add(tCust)
                VB.SysContab.BodegasDB.CargaInventarioBodega(Me.cbBodega.SelectedValue, ds, Me.TipoArticulo, Me.Filtro, Me.txtArticulo.Text)
                Dim cComentarios As New DataColumn
                cComentarios.ColumnName = "Comentarios"
                cComentarios.DataType = GetType(System.String)
                cComentarios.DefaultValue = ""

                'tCust.Columns.Add("Comentarios", GetType(System.String))
                tCust.Columns.Add(cComentarios)

                custDV = New DataView(tCust, "", "Codigo", DataViewRowState.CurrentRows)
                'DVFiltrada = New DataView(tCust)
                Me.dgArticulos.DataSource = ds.Tables(0).DefaultView 'DVFiltrada 
                AddCustomDataTableStyle()
            End If
        End If
    End Sub

    Private Sub cbOrigenInventario_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbOrigenInventario.SelectedIndexChanged
        If IsNumeric(Me.cbBodega.SelectedValue) Then
            If Me.cbOrigenInventario.Text.ToUpper = "PRODUCTOS DE CONSUMO" Then
                TipoArticulo = "A"
            ElseIf Me.cbOrigenInventario.Text.ToUpper = "ARTICULOS" Then
                TipoArticulo = "P"
            ElseIf Me.cbOrigenInventario.Text.ToUpper = "ACTIVO FIJO" Then
                TipoArticulo = "F"
            End If
            Me.Cargar()

            If Me.TipoArticulo = "A" Then

                cbLineas.DataSource = GruposCC.Lineas().Tables("GruposCC")
                cbLineas.ValueMember = "Código"
                cbLineas.DisplayMember = "Nombre"

                cbLineas.SelectedValue = 0

                cbGrupos.DataSource = GruposCC.Grupos(Me.cbLineas.SelectedValue).Tables("GruposCC")
                cbGrupos.ValueMember = "Código"
                cbGrupos.DisplayMember = "Nombre"

                cbSubGrupos.DataSource = GruposCC.SubGrupos(Me.cbGrupos.SelectedValue).Tables("GruposCC")
                cbSubGrupos.ValueMember = "Código"
                cbSubGrupos.DisplayMember = "Nombre"
            Else
                ''Agregar los controles de busqueda
                Me.cbLineas.DataSource = GruposP.Lineas(Me.TipoArticulo).Tables("GruposCC")
                Me.cbLineas.ValueMember = "Código"
                Me.cbLineas.DisplayMember = "Nombre"
                Me.cbLineas.SelectedIndex = 0

                Me.cbGrupos.DataSource = GruposP.Grupos(Me.cbLineas.SelectedValue, Me.TipoArticulo).Tables("GruposCC")
                Me.cbGrupos.ValueMember = "Código"
                Me.cbGrupos.DisplayMember = "Nombre"

                cbSubGrupos.DataSource = GruposP.SubGrupos(Me.cbGrupos.SelectedValue, Me.TipoArticulo).Tables("GruposCC")
                cbSubGrupos.ValueMember = "Código"
                cbSubGrupos.DisplayMember = "Nombre"
            End If
        End If
    End Sub


    Private Sub cbBodega_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBodega.SelectedIndexChanged
        If IsNumeric(Me.cbBodega.SelectedValue) Then
            If Me.cbOrigenInventario.Text.ToUpper = "PRODUCTOS DE CONSUMO" Then
                TipoArticulo = "A"
            ElseIf Me.cbOrigenInventario.Text.ToUpper = "ARTICULOS" Then
                TipoArticulo = "P"
            ElseIf Me.cbOrigenInventario.Text.ToUpper = "ACTIVO FIJO" Then
                TipoArticulo = "F"
            End If
            Me.Cargar()
        End If
    End Sub
    Private Sub cbLineas_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLineas.SelectedValueChanged
        If IsNumeric(Me.cbLineas.SelectedValue) Then
            If Me.TipoArticulo = "A" Then
                cbGrupos.DataSource = GruposCC.Grupos(Me.cbLineas.SelectedValue).Tables("GruposCC")
                cbGrupos.ValueMember = "Código"
                cbGrupos.DisplayMember = "Nombre"

                cbSubGrupos.DataSource = GruposCC.SubGrupos(Me.cbGrupos.SelectedValue).Tables("GruposCC")
                cbSubGrupos.ValueMember = "Código"
                cbSubGrupos.DisplayMember = "Nombre"
            Else
                Me.cbGrupos.DataSource = GruposP.Grupos(Me.cbLineas.SelectedValue, TipoArticulo).Tables("GruposCC")
                Me.cbGrupos.ValueMember = "Código"
                Me.cbGrupos.DisplayMember = "Nombre"

                cbSubGrupos.DataSource = GruposP.SubGrupos(Me.cbGrupos.SelectedValue, TipoArticulo).Tables("GruposCC")
                cbSubGrupos.ValueMember = "Código"
                cbSubGrupos.DisplayMember = "Nombre"
            End If
            aplicarfiltro()
        End If
    End Sub

    Private Sub cbGrupos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrupos.SelectedValueChanged
        If IsNumeric(Me.cbGrupos.SelectedValue) Then
            If Me.TipoArticulo = "A" Then
                cbSubGrupos.DataSource = GruposCC.SubGrupos(Me.cbGrupos.SelectedValue).Tables("GruposCC")
                cbSubGrupos.ValueMember = "Código"
                cbSubGrupos.DisplayMember = "Nombre"
            Else
                cbSubGrupos.DataSource = GruposP.SubGrupos(Me.cbGrupos.SelectedValue, TipoArticulo).Tables("GruposCC")
                cbSubGrupos.ValueMember = "Código"
                cbSubGrupos.DisplayMember = "Nombre"
            End If
            aplicarfiltro()
        End If
    End Sub
    Private Sub aplicarfiltro()

        Filtro = ""
        If IsNumeric(Me.cbLineas.SelectedValue) Then
            If Me.cbLineas.SelectedIndex > 0 Then
                Filtro = Filtro & IIf(Len(Filtro.Trim) > 0, " And ", "") & "Linea = '" & Me.cbLineas.SelectedValue & "'"
            Else
                Filtro = ""
            End If
        End If
        If IsNumeric(Me.cbGrupos.SelectedValue) Then
            If Me.cbGrupos.SelectedValue > 0 Then
                Filtro = Filtro & IIf(Len(Filtro.Trim) > 0, " And ", "") & "Grupo = '" & Me.cbGrupos.SelectedValue & "'"
            Else
                If IsNumeric(Me.cbLineas.SelectedValue) Then
                    If Me.cbLineas.SelectedIndex > 0 Then
                        Filtro = "Linea = '" & Me.cbLineas.SelectedValue & "'"
                    Else
                        Filtro = ""
                    End If
                End If
            End If
        End If

        If IsNumeric(Me.cbSubGrupos.SelectedValue) Then
            If Me.cbSubGrupos.SelectedValue > 0 Then
                Filtro = Filtro & IIf(Len(Filtro.Trim) > 0, " And ", "") & "SubGrupo = '" & Me.cbSubGrupos.SelectedValue & "'"
            Else
                If IsNumeric(Me.cbLineas.SelectedValue) Then
                    If Me.cbLineas.SelectedIndex > 0 Then
                        Filtro = "Linea = '" & Me.cbLineas.SelectedValue & "'"
                    Else
                        Filtro = ""
                    End If
                End If
                If IsNumeric(Me.cbGrupos.SelectedValue) Then
                    If Me.cbGrupos.SelectedValue > 0 Then
                        Filtro = Filtro & IIf(Len(Filtro.Trim) > 0, " And ", "") & "Grupo = '" & Me.cbGrupos.SelectedValue & "'"
                    End If
                End If
            End If
        End If

        'El filtro no lo pude realizar dentro del dataset
        'por eso voy a crear el filtro sacando los datos 
        Cargar()
        'DVFiltrada = New DataView(tCust)
        'DVFiltrada.RowStateFilter = DataViewRowState.CurrentRows
        'DVFiltrada.RowFilter = Filtro
        'Me.dgArticulos.DataSource = DVFiltrada
        'AddCustomDataTableStyle()
    End Sub

    Private Sub cbSubGrupos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSubGrupos.SelectedIndexChanged
        If IsNumeric(Me.cbSubGrupos.SelectedValue) Then
            aplicarfiltro()
        End If
    End Sub

    Private Sub txtArticulo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtArticulo.TextChanged
        aplicarfiltro()
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

    Private Sub frmCargaDeInventarioBodega_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim d As frmCargadeInventarioBodega_List = frmCargadeInventarioBodega_List.Instance

        Dim ds As New DataSet
        ds = VB.SysContab.BodegasDB.GetList_InventarioFisico(Microsoft.VisualBasic.Left(d.cbFiltro.Text, 1), d.cbbodega.SelectedValue)
        d.dgInventariosFisicos.DataSource = ds.Tables(0).DefaultView
        r.FormatGenerico(d.dgInventariosFisicos, ds.Tables(0))

    End Sub
End Class
