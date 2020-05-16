Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmVendedor_Linea
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmVendedor_Linea = Nothing

    Public Shared Function Instance() As frmVendedor_Linea
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmVendedor_Linea()
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
    Friend WithEvents etNombreProveedor As System.Windows.Forms.Label
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendedor_Linea))
        Me.etNombreProveedor = New System.Windows.Forms.Label()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'etNombreProveedor
        '
        Me.etNombreProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etNombreProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNombreProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etNombreProveedor.Location = New System.Drawing.Point(242, 12)
        Me.etNombreProveedor.Name = "etNombreProveedor"
        Me.etNombreProveedor.Size = New System.Drawing.Size(730, 20)
        Me.etNombreProveedor.TabIndex = 114
        Me.etNombreProveedor.Text = "VENDEDOR"
        Me.etNombreProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(12, 12)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(226, 20)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.Text = "ASIGNAR LINEAS AL VENDEDOR:"
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(637, 661)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(139, 22)
        Me.cmdAyuda.StyleController = Me.LayoutControl1
        Me.cmdAyuda.TabIndex = 5
        Me.cmdAyuda.Text = "Ayuda"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.etNombreProveedor)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdAyuda)
        Me.LayoutControl1.Controls.Add(Me.etDescripcion)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(977, 210, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(984, 711)
        Me.LayoutControl1.TabIndex = 119
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'iGrid
        '
        Me.iGrid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid.Location = New System.Drawing.Point(12, 36)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(960, 621)
        Me.iGrid.TabIndex = 120
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(879, 661)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(93, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 661)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(100, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "&Guardar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(780, 661)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(95, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "E&xportar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(984, 711)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.etDescripcion
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(230, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(230, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(230, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.etNombreProveedor
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(230, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(24, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(734, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.iGrid
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(964, 625)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdAceptar
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 649)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdImprimir
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(768, 649)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdSalir
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(867, 649)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(104, 649)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(521, 42)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdAyuda
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(625, 649)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(143, 42)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        Me.LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'frmVendedor_Linea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(984, 711)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmVendedor_Linea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents myDataSet As DataSet

    'Dim Activos_Fijos As New VB.SysContab.Activo_FijosDB()
    Dim GruposInv As New VB.SysContab.Grupos_InventarioDB()
    Dim g As New VB.SysContab.Grupos_InventarioDB()
    Dim ds As DataSet

    Dim ValorActual As String

    Dim WithEvents tCust As DataTable

    Private myCheckBoxCol As Integer = 3 'my checkbox column 

    Private Sub frmVendedor_Linea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ds = GruposInv.GetListBuscarCombo("%", "P")
        'ds = GruposInv.GetListBuscar("%", "P")

        Dim detalles As New VB.SysContab.VendedoresDetails()
        Dim vendedor As New VB.SysContab.VendedoresDB()
        detalles = vendedor.GetDetails(VendedorP)


        Cargar("P")
        iVista.PopulateColumns()
        FormatoGrid(iVista)

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("Agregar").OptionsColumn.AllowEdit = True
        iVista.Columns("Nombre").Width = 300

        iVista.Columns("Utilidad").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Utilidad").DisplayFormat.FormatString = "{0:p4}"

        iVista.Columns("Descuento_Ventas").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Descuento_Ventas").DisplayFormat.FormatString = "{0:p4}"

        iVista.Columns("Descuento_Comercial").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Descuento_Comercial").DisplayFormat.FormatString = "{0:p4}"

        'dgLineas.ReadOnly = True

        'MakeDataSet()
        'Bind the DataGrid to the DataSet. The dataMember
        'specifies that the Customers table should be displayed.
        'dgLineas.SetDataBinding(myDataSet, "Lineas")
        'create and add a custom table style so we can
        'easily get at the behavior of a cell...
        'AddCustomDataTableStyle()

        'Me.Text = "Asignar Lineas de Productos"
        Me.etNombreProveedor.Text = detalles.Nombre
        ValorActual = "0.00"
        Me.Refresh()
    End Sub

    Public Sub Cargar(Tipo As String)
        'Dim ds As New DataSet
        Dim GruposInv As New VB.SysContab.Grupos_InventarioDB
        'ds = GruposInv.GetList(Tipo)

        iGrid.DataSource = GruposInv.GetListBuscar(Tipo) 'ds.Tables("GRUPOS_INVENTARIO").DefaultView
    End Sub



    Private Sub MakeDataSet()

        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")


        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust = New DataTable("Lineas")

        ' Create two columns, and add them to the first table.
        Dim cCustID As DataColumn
        cCustID = New DataColumn("CODIGO", GetType(System.Int32))

        Dim cCustName As DataColumn
        cCustName = New DataColumn("DESCRIPCION")

        Dim cCustComision As DataColumn
        cCustComision = New DataColumn("COMISION")

        Dim cCurrent As DataColumn
        cCurrent = New DataColumn("AGREGAR", GetType(System.Boolean))
        'Dim cCurrent2 As DataColumn
        'cCurrent2 = New DataColumn("Current2", GetType(System.Boolean))

        tCust.Columns.Add(cCustID)
        tCust.Columns.Add(cCustName)
        tCust.Columns.Add(cCustComision)
        tCust.Columns.Add(cCurrent)

        'tCust.Columns.Add(cCurrent2)
        ' Add the tables to the DataSet.
        myDataSet.Tables.Add(tCust)

        ' Populates the tables. For each customer and order, 
        'creates two DataRow variables. 
        Dim newRow1 As DataRow
        ' Create three customers in the Customers Table.
        Dim i As Integer
        i = 0

        Do While (i < ds.Tables("Grupos_Inventario").Rows.Count)
            newRow1 = tCust.NewRow
            newRow1("CODIGO") = ds.Tables("Grupos_Inventario").Rows(i).Item("CODIGO_GRUPO")
            'newRow1("DESCRIPCION") = ds.Tables("Grupos_Inventario").Rows(i).Item("Nombre")
            ' Add the row to the Customers table.
            tCust.Rows.Add(newRow1)
            i = (i + 1)

        Loop
        ' Give each customer a distinct name.

        For i = 0 To ds.Tables("Grupos_Inventario").Rows.Count - 1
            'tCust.Rows(i)("DESCRIPCION") = ds.Tables("Activo_Fijos").Rows(i).Item("DESCRIPCION")
            tCust.Rows(i)("DESCRIPCION") = ds.Tables("Grupos_Inventario").Rows(i).Item("Nombre")

            If g.GetListVendedorLineas(VendedorP, tCust.Rows(i)("Codigo")) = True Then
                tCust.Rows(i)("AGREGAR") = True
                'Obtener la comision por linea del Vendedor
                tCust.Rows(i)("COMISION") = Format(g.GetListComisionLinea(VendedorP, tCust.Rows(i)("Codigo")).Tables("VENDEDOR_LINEA").Rows(0).Item("Comision"), "##,###0.00")
                'MsgBox(g.GetListComisionLinea(VendedorP, tCust.Rows(i)("Codigo")).Tables("VENDEDOR_LINEA").Rows(0).Item("Comision"))

            Else
                tCust.Rows(i)("AGREGAR") = False
                tCust.Rows(i)("COMISION") = "0.00"
            End If
        Next

        'myDataSet.Tables("Lineas").DefaultView.AllowDelete = False
        'myDataSet.Tables("Lineas").DefaultView.AllowNew = False
        'myDataSet.Tables("Lineas").DefaultView.AllowEdit = True

    End Sub

    'Private Sub AddCustomDataTableStyle()

    '    'STEP 1: Create a DataTable style object and set properties if required.
    '    Dim ts1 As DataGridTableStyle
    '    ts1 = New DataGridTableStyle()
    '    'specify the table from dataset (required step)
    '    ts1.MappingName = "Lineas"
    '    ' Set other properties (optional step)
    '    ts1.AlternatingBackColor = Color.LightBlue
    '    Dim colCount As Integer
    '    colCount = 0

    '    'STEP 3: Create an int column style and add it to the tablestyle
    '    'this requires setting the format for the column through its property descriptor
    '    Dim pdc As PropertyDescriptorCollection
    '    pdc = Me.BindingContext(myDataSet, "Lineas").GetItemProperties
    '    'now created a formated column using the pdc
    '    Dim csIDInt As DataGridTextBoxColumn
    '    csIDInt = New DataGridTextBoxColumn(pdc("CODIGO"), "d", True)
    '    'csIDInt.Format = "d3"
    '    csIDInt.MappingName = "CODIGO"
    '    csIDInt.HeaderText = "CODIGO"
    '    csIDInt.ReadOnly = True
    '    csIDInt.Width = 0
    '    ts1.GridColumnStyles.Add(csIDInt)
    '    colCount = (colCount + 1)
    '    csIDInt.NullText = ""


    '    'STEP 2: Create a string column and add it to the tablestyle
    '    Dim TextCol As DataGridColumnStyle
    '    TextCol = New DataGridTextBoxColumn()
    '    TextCol.MappingName = "DESCRIPCION"
    '    'from dataset table
    '    TextCol.HeaderText = "Descripción"
    '    TextCol.Width = 400
    '    TextCol.ReadOnly = True
    '    ts1.GridColumnStyles.Add(TextCol)
    '    colCount = (colCount + 1)

    '    TextCol.NullText = ""

    '    'Comision
    '    Dim colComision As DataGridTextBoxColumn
    '    colComision = New DataGridTextBoxColumn() '(pdc("colComision"), "i", True)
    '    colComision.MappingName = "COMISION"
    '    'from dataset table
    '    'colComision.Format = "##,###0.00"
    '    colComision.HeaderText = "Comisión"
    '    colComision.Width = 100
    '    colComision.Alignment = HorizontalAlignment.Right
    '    colComision.ReadOnly = False
    '    ts1.GridColumnStyles.Add(colComision)
    '    colCount = (colCount + 1)

    '    colComision.NullText = ""

    '    'STEP 4: Add the checkbox
    '    Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
    '    boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
    '    boolCol.MappingName = "AGREGAR"
    '    boolCol.HeaderText = "Asignar"
    '    boolCol.Alignment = HorizontalAlignment.Center

    '    'uncomment this line to get a two-state checkbox
    '    CType(boolCol, DataGridBoolColumn).AllowNull = False

    '    boolCol.Width = 100
    '    boolCol.ReadOnly = False

    '    boolCol.NullText = ""

    '    'hook the new event to our handler in the grid
    '    AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
    '    ts1.GridColumnStyles.Add(boolCol)
    '    colCount = (colCount + 1)

    '    ''STEP 5: Add a second checkbox

    '    'boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
    '    'boolCol.MappingName = "Current2"
    '    'boolCol.HeaderText = "Info Current2"
    '    'CType(boolCol, DataGridBoolColumn).AllowNull = False
    '    'boolCol.Width = 70
    '    ''hook the new event to our handler in the grid
    '    'AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
    '    'ts1.GridColumnStyles.Add(boolCol)
    '    'colCount = (colCount + 1)

    '    'STEP 6: Add the tablestyle to your datagrids tablestlye collection

    '    ts1.AllowSorting = False
    '    ts1.PreferredRowHeight = 25

    '    tCust.DefaultView.AllowNew = False
    '    tCust.DefaultView.AllowDelete = False

    '    dgLineas.TableStyles.Clear()
    '    dgLineas.TableStyles.Add(ts1)

    'End Sub

    'Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)

    '    Dim s As String
    '    s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
    '    Console.WriteLine(s)

    'End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        ' Dim i As Integer
        'Dim Asignar As Integer
        'Asignar = 0


        'Borrar Las lineas que tenga asignada
        VB.SysContab.Grupos_InventarioDB.DeleteLineasVendedor(VendedorP)

        For i As Integer = 0 To iVista.DataRowCount - 1
            If iVista.GetRowCellValue(i, "Agregar") Then
                g.AddLineaVendedor(VendedorP, iVista.GetRowCellValue(i, "Código"), 0.0, "P")
            End If
        Next

        'For i = 0 To tCust.Rows.Count - 1
        '    If tCust.Rows(i)("AGREGAR") = True Then
        '        If g.GetListVendedorLineas(VendedorP, tCust.Rows(i)("Codigo")) = True Then
        '            'Ya existe
        '            g.UpdateComision(VendedorP, tCust.Rows(i).Item("CODIGO"), tCust.Rows(i).Item("COMISION"), "P")
        '        Else
        '            g.AddLineaVendedor(VendedorP, tCust.Rows(i).Item("CODIGO"), tCust.Rows(i).Item("COMISION"), "P")
        '        End If

        '        Asignar = Asignar + 1
        '    Else
        '        If g.GetListVendedorLineas(VendedorP, tCust.Rows(i)("Codigo")) = True Then
        '            'Borrar si Ya existe
        '            g.DeleteVendedorLinea(VendedorP, tCust.Rows(i).Item("CODIGO"))
        '            tCust.Rows(i)("COMISION") = "0.00"

        '        Else

        '        End If

        '        Asignar = Asignar + 1

        '    End If
        'Next

        'If Asignar = 0 Then
        '    'MsgBox("Seleccione las Lineas que desea asignar al vendedor", MsgBoxStyle.Information)
        '    'Exit Sub
        'Else
        '    XtraMsg("Proceso finalizó.")
        '    'ElseIf Asignar = 1 Then
        '    '    MsgBox("Se asignó " & Asignar & " Lineas al vendedor", MsgBoxStyle.Information)
        '    'Else
        '    '    MsgBox("Se asignaron " & Asignar & " Lineas al vendedor", MsgBoxStyle.Information)

        'End If

        XtraMsg("Datos Guardados con Exito!")

        Cargar("P")

        'ds = GruposInv.GetListBuscarCombo("%", "P")
        'ds = GruposInv.GetListBuscar("%", "P")

        'MakeDataSet()
        'Bind the DataGrid to the DataSet. The dataMember
        'specifies that the Customers table should be displayed.
        'dgLineas.SetDataBinding(myDataSet, "Lineas")
        'create and add a custom table style so we can
        'easily get at the behavior of a cell...
        'AddCustomDataTableStyle()
    End Sub

    'Private Sub dgLineas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        If ds.Tables("GRUPOS_INVENTARIO").Rows.Count = dgLineas.CurrentRowIndex Then
    '            'dgLineas.Select(dgLineas.CurrentRowIndex - 1)
    '            dgLineas.ReadOnly = True
    '        Else
    '            dgLineas.ReadOnly = False

    '        End If

    '        If dgLineas.CurrentRowIndex >= 0 And dgLineas.CurrentRowIndex < ds.Tables("GRUPOS_INVENTARIO").Rows.Count Then
    '            ValorActual = tCust.Rows(dgLineas.CurrentRowIndex)("COMISION")

    '        End If
    '    Catch
    '        Exit Sub
    '    End Try
    'End Sub

    'Private Sub tCust_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles tCust.ColumnChanged
    '    If Not IsNumeric(e.Row.Item(2)) Then
    '        If dgLineas.CurrentRowIndex >= 0 And dgLineas.CurrentRowIndex < ds.Tables("GRUPOS_INVENTARIO").Rows.Count Then
    '            e.Row.Item(2) = ValorActual
    '        End If
    '    Else
    '        'e.Row.Item(2) = Format(e.Row.Item(2), "##,###0.00")
    '    End If

    'End Sub

    'Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim gruposInv As New VB.SysContab.Grupos_InventarioDB()
    '    'dgGruposInventario.DataSource = gruposInv.GetListBuscar(txtBuscar.Text, TipoGrupoInv).Tables("GRUPOS_INVENTARIO").DefaultView
    '    ds = gruposInv.GetListBuscar(txtBuscar.Text, "P")

    '    'If gruposInv.GetListBuscar(txtBuscar.Text, "P").Tables("Grupos_Inventario").Rows.Count = 0 Then
    '    '    Registro = "Vacio"
    '    '    Exit Sub

    '    'End If

    '    MakeDataSet()
    '    'Bind the DataGrid to the DataSet. The dataMember
    '    'specifies that the Customers table should be displayed.
    '    dgLineas.SetDataBinding(myDataSet, "Lineas")
    '    'create and add a custom table style so we can
    '    'easily get at the behavior of a cell...
    '    AddCustomDataTableStyle()

    '    txtBuscar.Focus()
    '    txtBuscar.SelectionStart = txtBuscar.Text.Length

    '    'Registro = dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0)
    'End Sub

    'Private Sub dgLineas_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
    '    Dim hti As DataGrid.HitTestInfo = Me.dgLineas.HitTest(e.X, e.Y)
    '    Try
    '        If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
    '            Me.dgLineas(hti.Row, hti.Column) = Not CBool(Me.dgLineas(hti.Row, hti.Column))
    '        Else
    '            Exit Sub
    '        End If
    '    Catch ex As Exception
    '        'MessageBox.Show(ex.ToString())
    '    End Try
    'End Sub 'dataGrid2_MouseUp

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        frmExportarImprimir.Mostrar(iGrid, "Grupo de Productos")
    End Sub


    Private Sub iVista_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Agregar" Then
            If iVista.GetRowCellValue(e.RowHandle, "Agregar") Then
                e.Appearance.BackColor = Color.Salmon
            End If
        End If
    End Sub

    Private Sub iVista_ShowingEditor(sender As Object, e As CancelEventArgs) Handles iVista.ShowingEditor
        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Tipo") <> "Sub Grupo" Then e.Cancel = True
    End Sub

End Class
