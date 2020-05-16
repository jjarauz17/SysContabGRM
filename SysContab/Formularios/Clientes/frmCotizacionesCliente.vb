Public Class frmCotizacionesCliente
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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCotizacionesCliente))
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(859, 511)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(113, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(797, 336, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(984, 561)
        Me.LayoutControl1.TabIndex = 20
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(741, 511)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(114, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 12)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(960, 495)
        Me.iGrid.TabIndex = 21
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsBehavior.Editable = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(984, 561)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(964, 499)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdAceptar
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(729, 499)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdSalir
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(847, 499)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 499)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(729, 42)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmCotizacionesCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmCotizacionesCliente"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas()
    Dim Cotizaciones As New VB.SysContab.CotizacionesDB()
    Dim Tabla As DataTable
    Dim ds As DataSet

    Private Sub frmCotizacionesCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Cotizaciones por Cliente Pendientes de Facturar"
        'Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'Me.MaximizeBox = False
        'r.FormularioColor(Me)
        'r.CambiarEstilo(Me)

        ds = Cotizaciones.CotizacionesXCliente(ClienteFactura)

        iGrid.DataSource = ds.Tables("Cotizaciones").DefaultView
        iVista.PopulateColumns()
        FormatoGrid(iVista)

        iVista.Columns("Cliente_ID").Visible = False

        'dgCotizacionesCliente.DataSource = ds.Tables("Cotizaciones").DefaultView
        'Tabla = ds.Tables("Cotizaciones")
        ' r.FormatGenerico(dgCotizacionesCliente, Tabla)

        If ds.Tables("Cotizaciones").Rows.Count <> 0 Then
            RegistroFacturaTemporal = iVista.GetRowCellValue(0, "No Cotización")
        Else
            RegistroFacturaTemporal = "Vacio"
        End If

        'dgCotizacionesCliente.CaptionText = "Información de Cotizaciones"
        'Me.Refresh()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        LoadCotizacionCliente = False
        Close()

        'If LoadCotizacionCliente = True Then
        '    Exit Sub
        'Else
        '    LoadCotizacionCliente = False
        'End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If iVista.FocusedRowHandle < 0 Then Exit Sub

        RegistroCotizacion = iVista.GetFocusedRowCellValue("No Cotización")
        LoadCotizacionCliente = True
        Me.Close()
    End Sub


    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        If iVista.FocusedRowHandle < 0 Then Exit Sub

        RegistroCotizacion = iVista.GetFocusedRowCellValue("No Cotización")
        LoadCotizacionCliente = True
        Close()
    End Sub
End Class
