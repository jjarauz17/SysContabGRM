Imports System.Data.SqlClient
Imports SysContab.VB.SysContab

Public Class frmGridArticulosxBodega
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmGridArticulosxBodega = Nothing

    Public Shared Function Instance() As frmGridArticulosxBodega
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmGridArticulosxBodega
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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGridArticulosxBodega))
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(691, 614)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(81, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.btnExportar)
        Me.LayoutControl1.Controls.Add(Me.btnGuardar)
        Me.LayoutControl1.Controls.Add(Me.dgDatos)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(388, 363, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(784, 664)
        Me.LayoutControl1.TabIndex = 9
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(592, 614)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(95, 38)
        Me.btnExportar.StyleController = Me.LayoutControl1
        Me.btnExportar.TabIndex = 6
        Me.btnExportar.Text = "&Exportar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.Options.UseTextOptions = True
        Me.btnGuardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(451, 614)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(137, 38)
        Me.btnGuardar.StyleController = Me.LayoutControl1
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "&Registrar Ingreso"
        '
        'dgDatos
        '
        Me.dgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDatos.Location = New System.Drawing.Point(12, 12)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(760, 598)
        Me.dgDatos.TabIndex = 7
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(784, 664)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgDatos
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(764, 602)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnGuardar
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(439, 602)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(141, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(141, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(141, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnExportar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(580, 602)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdSalir
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(679, 602)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(85, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(85, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(85, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 602)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(439, 42)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmGridArticulosxBodega
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(784, 664)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmGridArticulosxBodega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public TipoProducto As String
    Public cArticulo As String
    Dim dt As DataTable


    Private Sub frmArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        Cargar()
    End Sub

    Sub Cargar()
        'Dim lds As New DataSet
        'lds = VB.SysContab.BodegasDB.GetDetalledeBodegaxProducto(Me.cArticulo, Me.TipoProducto, "%")

        dt = ObtieneDatos("sp_GetBodegaArticulos", cArticulo, TipoProducto, EmpresaActual)
        Me.dgDatos.DataSource = dt
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos, 6, 0, False, True)
        '
        For i As Integer = 0 To Me.vDatos.Columns.Count - 1
            Me.vDatos.Columns(i).OptionsColumn.AllowEdit = False
        Next
        '
        Me.vDatos.Columns("CODIGO_BODEGA").Visible = False

        Me.vDatos.Columns("EN BODEGA").OptionsColumn.AllowEdit = True
        Me.vDatos.Columns("ACTIVO FACTURAR").OptionsColumn.AllowEdit = True
        '
        Me.vDatos.Columns("EXISTENCIA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("EXISTENCIA").DisplayFormat.FormatString = "{0:n4}"
        Me.vDatos.Columns("EXISTENCIA").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("EXISTENCIA").SummaryItem.DisplayFormat = "{0:n4}"

        Me.vDatos.Columns("REAL").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("REAL").DisplayFormat.FormatString = "{0:n4}"
        Me.vDatos.Columns("REAL").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("REAL").SummaryItem.DisplayFormat = "{0:n4}"
        '        
        Me.vDatos.Columns("COSTO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("COSTO").DisplayFormat.FormatString = "{0:n6}"
        Me.vDatos.Columns("COSTO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("COSTO").SummaryItem.DisplayFormat = "{0:n6}"
        '
        Me.vDatos.Columns("COSTO PROMEDIO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("COSTO PROMEDIO").DisplayFormat.FormatString = "{0:n6}"
        Me.vDatos.Columns("COSTO PROMEDIO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("COSTO PROMEDIO").SummaryItem.DisplayFormat = "{0:n6}"
        '
        Me.vDatos.BestFitColumns()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim DetalleProducto As New VB.SysContab.ArticulosDetails
        DetalleProducto = VB.SysContab.ArticulosDB.GetDetails(cArticulo, TipoProducto)

        My.Forms.frmExportarImprimir.Mostrar(Me.dgDatos, "Existencias por Bodega", "ITEM: " & DetalleProducto.Codigo + " - " + DetalleProducto.Nombre)
    End Sub

    Private Sub vDatos_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles vDatos.RowCellStyle
        If e.Column.FieldName = "EN BODEGA" Then
            If Me.vDatos.GetRowCellValue(e.RowHandle, "EN BODEGA") Then
                e.Appearance.BackColor = Color.Salmon
            End If
            ''
            If Not vDatos.GetRowCellValue(e.RowHandle, "ACTIVO FACTURAR") Then
                e.Appearance.BackColor = Color.DarkSalmon
            End If
        End If
    End Sub

    Private Sub vDatos_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vDatos.ShowingEditor
        'If vDatos.GetRowCellValue(vDatos.FocusedRowHandle, "EN BODEGA") And _
        '    Not vDatos.GetRowCellValue(Me.vDatos.FocusedRowHandle, "EXISTENCIA") Is DBNull.Value Then e.Cancel = True
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim nIngreso As DataTable = dt.GetChanges(DataRowState.Modified)
        '
        If nIngreso Is Nothing Then
            XtraMsg("Selecione al Menos 1 Bodega para realizar el Ingreso del Producto", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        Dim selec As Boolean = False
        For i As Integer = 0 To nIngreso.Rows.Count - 1
            If nIngreso.Rows.Item(i)("EN BODEGA") Then
                selec = True
                Exit For
            End If
        Next
        '
        If Not selec Then
            XtraMsg("Selecione al Menos 1 Bodega para realizar el Ingreso", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If Not XtraMsg2("¿ Ingresar Producto: " & cArticulo & " a la(s) Bodega(s) seleccionada(s) ?") Then
            Exit Sub
        End If

        'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        'DBConnFacturas.Open()
        'transaccionFacturas = DBConnFacturas.BeginTransaction()
        '
        Try
            For i As Integer = 0 To nIngreso.Rows.Count - 1
                If nIngreso.Rows.Item(i)("EN BODEGA") Then
                    '' BodegasDB.Bodega_Articulos_Add(nIngreso.Rows.Item(i)("CODIGO_BODEGA"), cArticulo, 0, 0, "P")
                    GuardaDatos("JAR_Bodega_Articulos_Add '" & nIngreso.Rows.Item(i)("CODIGO_BODEGA") & "'," & _
                                "'" & cArticulo & "','P'," & EmpresaActual)

                    GuardaDatos("JAR_ActualizarEstadoBA '" & cArticulo & "','P'," & _
                                     "'" & nIngreso.Rows.Item(i)("CODIGO_BODEGA") & "'," & _
                                     "'" & IIf(nIngreso.Rows.Item(i)("ACTIVO FACTURAR"), 1, 0) & "'," & _
                                     EmpresaActual)
                End If
            Next
            '
            '' Rutinas.okTransaccion()
            '
            XtraMsg("Ingreso del Producto: " & cArticulo & " en Bodegas Exitoso.")
            Cargar()
        Catch ex As Exception
            '' Rutinas.ErrorTransaccion()
            XtraMsg("ERROR: " & ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub
End Class