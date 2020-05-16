Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports SysContab.VB.SysContab

'Namespace DataGridTextBoxCombo
Public Class frmPedidos
    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As frmPedidos = Nothing

    Public Shared Function Instance() As frmPedidos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPedidos()
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
    Friend WithEvents cmdConsulta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConsultaProveedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFechaEntrega As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDepartamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMunicipio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRuc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TipoSolicitud As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemArticulo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemArticuloD As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPrecioU As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPrecioC As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbliva As System.Windows.Forms.Label
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents cmbcentrocosto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents etTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLogin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cbMetodosEnvios As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbAgencias As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbConsignatarios As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents frmPedidosConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCondiciones As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNumeroAlterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TipoSolicituditem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtObservacionesitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPedidoitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtpFechaitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtpFechaEntregaitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents etTasaitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbConsignatariositem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMetodosEnviositem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbAgenciasitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtLoginitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbcentrocostoitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalU As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtSeguimiento As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbProveedor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidos))
        Me.cmdConsultaProveedor = New DevExpress.XtraEditors.SimpleButton()
        Me.frmPedidosConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.txtSeguimiento = New DevExpress.XtraEditors.MemoEdit()
        Me.cbFormaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalU = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdConsulta = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNumeroAlterno = New DevExpress.XtraEditors.TextEdit()
        Me.cbCondiciones = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDepartamento = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbliva = New System.Windows.Forms.Label()
        Me.txtMunicipio = New DevExpress.XtraEditors.TextEdit()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemArticuloD = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPrecioU = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPrecioC = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDireccion = New DevExpress.XtraEditors.MemoEdit()
        Me.cbConsignatarios = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbMetodosEnvios = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbAgencias = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbcentrocosto = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.txtLogin = New DevExpress.XtraEditors.TextEdit()
        Me.etTasa = New DevExpress.XtraEditors.TextEdit()
        Me.txtPedido = New DevExpress.XtraEditors.TextEdit()
        Me.dtpFechaEntrega = New DevExpress.XtraEditors.DateEdit()
        Me.dtpFecha = New DevExpress.XtraEditors.DateEdit()
        Me.TipoSolicitud = New DevExpress.XtraEditors.RadioGroup()
        Me.txtRuc = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtPedidoitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dtpFechaitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dtpFechaEntregaitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.etTasaitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cbAgenciasitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtLoginitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cbConsignatariositem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cbMetodosEnviositem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtObservacionesitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmbcentrocostoitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TipoSolicituditem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.cbProveedor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.frmPedidosConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmPedidosConvertedLayout.SuspendLayout()
        CType(Me.txtSeguimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroAlterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCondiciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemArticuloD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbConsignatarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMetodosEnvios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAgencias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbcentrocosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLogin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaEntrega.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoSolicitud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPedidoitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaEntregaitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etTasaitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAgenciasitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoginitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbConsignatariositem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMetodosEnviositem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacionesitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbcentrocostoitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoSolicituditem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdConsultaProveedor
        '
        Me.cmdConsultaProveedor.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsultaProveedor.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdConsultaProveedor.Appearance.Options.UseFont = True
        Me.cmdConsultaProveedor.Appearance.Options.UseForeColor = True
        Me.cmdConsultaProveedor.Location = New System.Drawing.Point(906, 508)
        Me.cmdConsultaProveedor.Name = "cmdConsultaProveedor"
        Me.cmdConsultaProveedor.Size = New System.Drawing.Size(66, 22)
        Me.cmdConsultaProveedor.StyleController = Me.frmPedidosConvertedLayout
        Me.cmdConsultaProveedor.TabIndex = 33
        Me.cmdConsultaProveedor.Text = "Pro&veedor"
        Me.cmdConsultaProveedor.Visible = False
        '
        'frmPedidosConvertedLayout
        '
        Me.frmPedidosConvertedLayout.Controls.Add(Me.cbProveedor)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.txtSeguimiento)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.cbFormaPago)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.Label4)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.Label3)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.lblTotalU)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.Label1)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.lbltotal)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.cmdConsultaProveedor)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.cmdAceptar)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.cmdCancelar)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.cmdConsulta)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.txtNumeroAlterno)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.cbCondiciones)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.txtDepartamento)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.txtTelefono)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.Label11)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.lbliva)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.txtMunicipio)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.lblsubtotal)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.GridDetalle)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.txtDireccion)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.cbConsignatarios)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.cbMetodosEnvios)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.cbAgencias)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.cmbcentrocosto)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.txtObservaciones)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.txtLogin)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.etTasa)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.txtPedido)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.dtpFechaEntrega)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.dtpFecha)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.TipoSolicitud)
        Me.frmPedidosConvertedLayout.Controls.Add(Me.txtRuc)
        Me.frmPedidosConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmPedidosConvertedLayout.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem10, Me.LayoutControlItem1, Me.LayoutControlItem6, Me.LayoutControlItem16, Me.LayoutControlItem9})
        Me.frmPedidosConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmPedidosConvertedLayout.Name = "frmPedidosConvertedLayout"
        Me.frmPedidosConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(382, 295, 250, 350)
        Me.frmPedidosConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmPedidosConvertedLayout.Size = New System.Drawing.Size(984, 428)
        Me.frmPedidosConvertedLayout.TabIndex = 162
        '
        'txtSeguimiento
        '
        Me.txtSeguimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSeguimiento.Location = New System.Drawing.Point(117, 170)
        Me.txtSeguimiento.Name = "txtSeguimiento"
        Me.txtSeguimiento.Size = New System.Drawing.Size(631, 50)
        Me.txtSeguimiento.StyleController = Me.frmPedidosConvertedLayout
        Me.txtSeguimiento.TabIndex = 191
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFormaPago.Location = New System.Drawing.Point(442, 40)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPago.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbFormaPago.Properties.Appearance.Options.UseFont = True
        Me.cbFormaPago.Properties.Appearance.Options.UseForeColor = True
        Me.cbFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFormaPago.Properties.NullText = ""
        Me.cbFormaPago.Properties.ShowFooter = False
        Me.cbFormaPago.Properties.ShowHeader = False
        Me.cbFormaPago.Size = New System.Drawing.Size(216, 22)
        Me.cbFormaPago.StyleController = Me.frmPedidosConvertedLayout
        Me.cbFormaPago.TabIndex = 192
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(657, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "Impuesto:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(657, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 198
        Me.Label3.Text = "Sub Total:"
        '
        'lblTotalU
        '
        Me.lblTotalU.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalU.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalU.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalU.Location = New System.Drawing.Point(779, 396)
        Me.lblTotalU.Name = "lblTotalU"
        Me.lblTotalU.Size = New System.Drawing.Size(193, 20)
        Me.lblTotalU.TabIndex = 197
        Me.lblTotalU.Text = "0.00"
        Me.lblTotalU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(657, 396)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "Total U$:"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Maroon
        Me.lbltotal.Location = New System.Drawing.Point(779, 372)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(193, 20)
        Me.lbltotal.TabIndex = 163
        Me.lbltotal.Text = "0.00"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_SaveLarge
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 324)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(90, 38)
        Me.cmdAceptar.StyleController = Me.frmPedidosConvertedLayout
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "&Guardar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.ImageOptions.Image = Global.SysContab.My.Resources.Resources._115
        Me.cmdCancelar.Location = New System.Drawing.Point(561, 324)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(92, 38)
        Me.cmdCancelar.StyleController = Me.frmPedidosConvertedLayout
        Me.cmdCancelar.TabIndex = 29
        Me.cmdCancelar.Text = "&Salir"
        '
        'cmdConsulta
        '
        Me.cmdConsulta.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsulta.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdConsulta.Appearance.Options.UseFont = True
        Me.cmdConsulta.Appearance.Options.UseForeColor = True
        Me.cmdConsulta.Appearance.Options.UseTextOptions = True
        Me.cmdConsulta.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdConsulta.ImageOptions.Image = CType(resources.GetObject("cmdConsulta.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdConsulta.Location = New System.Drawing.Point(106, 324)
        Me.cmdConsulta.Name = "cmdConsulta"
        Me.cmdConsulta.Size = New System.Drawing.Size(100, 38)
        Me.cmdConsulta.StyleController = Me.frmPedidosConvertedLayout
        Me.cmdConsulta.TabIndex = 31
        Me.cmdConsulta.Text = "&Existencia por Bodega"
        '
        'txtNumeroAlterno
        '
        Me.txtNumeroAlterno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroAlterno.Location = New System.Drawing.Point(864, 12)
        Me.txtNumeroAlterno.Name = "txtNumeroAlterno"
        Me.txtNumeroAlterno.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtNumeroAlterno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroAlterno.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtNumeroAlterno.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumeroAlterno.Properties.Appearance.Options.UseFont = True
        Me.txtNumeroAlterno.Properties.Appearance.Options.UseForeColor = True
        Me.txtNumeroAlterno.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.txtNumeroAlterno.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroAlterno.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.txtNumeroAlterno.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNumeroAlterno.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtNumeroAlterno.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNumeroAlterno.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtNumeroAlterno.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroAlterno.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtNumeroAlterno.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNumeroAlterno.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtNumeroAlterno.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNumeroAlterno.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumeroAlterno.Size = New System.Drawing.Size(108, 24)
        Me.txtNumeroAlterno.StyleController = Me.frmPedidosConvertedLayout
        Me.txtNumeroAlterno.TabIndex = 168
        '
        'cbCondiciones
        '
        Me.cbCondiciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCondiciones.Location = New System.Drawing.Point(117, 40)
        Me.cbCondiciones.Name = "cbCondiciones"
        Me.cbCondiciones.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCondiciones.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbCondiciones.Properties.Appearance.Options.UseFont = True
        Me.cbCondiciones.Properties.Appearance.Options.UseForeColor = True
        Me.cbCondiciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCondiciones.Properties.NullText = ""
        Me.cbCondiciones.Properties.ShowFooter = False
        Me.cbCondiciones.Properties.ShowHeader = False
        Me.cbCondiciones.Size = New System.Drawing.Size(216, 22)
        Me.cbCondiciones.StyleController = Me.frmPedidosConvertedLayout
        Me.cbCondiciones.TabIndex = 196
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Enabled = False
        Me.txtDepartamento.Location = New System.Drawing.Point(576, 494)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtDepartamento.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartamento.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDepartamento.Properties.Appearance.Options.UseBackColor = True
        Me.txtDepartamento.Properties.Appearance.Options.UseFont = True
        Me.txtDepartamento.Properties.Appearance.Options.UseForeColor = True
        Me.txtDepartamento.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.txtDepartamento.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartamento.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.txtDepartamento.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtDepartamento.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtDepartamento.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtDepartamento.Size = New System.Drawing.Size(258, 20)
        Me.txtDepartamento.StyleController = Me.frmPedidosConvertedLayout
        Me.txtDepartamento.TabIndex = 160
        Me.txtDepartamento.Visible = False
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(576, 494)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelefono.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTelefono.Properties.Appearance.Options.UseBackColor = True
        Me.txtTelefono.Properties.Appearance.Options.UseFont = True
        Me.txtTelefono.Properties.Appearance.Options.UseForeColor = True
        Me.txtTelefono.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.txtTelefono.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTelefono.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtTelefono.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtTelefono.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtTelefono.Size = New System.Drawing.Size(104, 20)
        Me.txtTelefono.StyleController = Me.frmPedidosConvertedLayout
        Me.txtTelefono.TabIndex = 158
        Me.txtTelefono.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label11.Location = New System.Drawing.Point(657, 372)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 20)
        Me.Label11.TabIndex = 153
        Me.Label11.Text = "Total C$:"
        '
        'lbliva
        '
        Me.lbliva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbliva.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliva.ForeColor = System.Drawing.Color.Maroon
        Me.lbliva.Location = New System.Drawing.Point(779, 348)
        Me.lbliva.Name = "lbliva"
        Me.lbliva.Size = New System.Drawing.Size(193, 20)
        Me.lbliva.TabIndex = 149
        Me.lbliva.Text = "0.00"
        Me.lbliva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Enabled = False
        Me.txtMunicipio.Location = New System.Drawing.Point(576, 508)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtMunicipio.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipio.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMunicipio.Properties.Appearance.Options.UseBackColor = True
        Me.txtMunicipio.Properties.Appearance.Options.UseFont = True
        Me.txtMunicipio.Properties.Appearance.Options.UseForeColor = True
        Me.txtMunicipio.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.txtMunicipio.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipio.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.txtMunicipio.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtMunicipio.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtMunicipio.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtMunicipio.Size = New System.Drawing.Size(312, 20)
        Me.txtMunicipio.StyleController = Me.frmPedidosConvertedLayout
        Me.txtMunicipio.TabIndex = 161
        Me.txtMunicipio.Visible = False
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsubtotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.ForeColor = System.Drawing.Color.Maroon
        Me.lblsubtotal.Location = New System.Drawing.Point(779, 324)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(193, 20)
        Me.lblsubtotal.TabIndex = 150
        Me.lblsubtotal.Text = "0.00"
        Me.lblsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(12, 224)
        Me.GridDetalle.MainView = Me.GridView1
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemArticulo, Me.ItemArticuloD, Me.txtPrecioC, Me.txtPrecioU})
        Me.GridDetalle.Size = New System.Drawing.Size(960, 96)
        Me.GridDetalle.TabIndex = 147
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn11, Me.GridColumn6, Me.GridColumn10, Me.GridColumn12, Me.GridColumn14, Me.GridColumn15, Me.GridColumn1})
        Me.GridView1.GridControl = Me.GridDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsFilter.AllowColumnMRUFilterList = False
        Me.GridView1.OptionsFilter.AllowFilterEditor = False
        Me.GridView1.OptionsFilter.AllowMRUFilterList = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Codigo"
        Me.GridColumn3.ColumnEdit = Me.ItemArticulo
        Me.GridColumn3.FieldName = "Item"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 102
        '
        'ItemArticulo
        '
        Me.ItemArticulo.AutoHeight = False
        Me.ItemArticulo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemArticulo.Name = "ItemArticulo"
        Me.ItemArticulo.NullText = ""
        Me.ItemArticulo.ShowFooter = False
        Me.ItemArticulo.ShowHeader = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Descripcion"
        Me.GridColumn4.ColumnEdit = Me.ItemArticuloD
        Me.GridColumn4.FieldName = "Item"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 331
        '
        'ItemArticuloD
        '
        Me.ItemArticuloD.AutoHeight = False
        Me.ItemArticuloD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemArticuloD.Name = "ItemArticuloD"
        Me.ItemArticuloD.NullText = ""
        Me.ItemArticuloD.ShowFooter = False
        Me.ItemArticuloD.ShowHeader = False
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Cantidad"
        Me.GridColumn5.DisplayFormat.FormatString = "n2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Cantidad"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 103
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Precio U$"
        Me.GridColumn11.ColumnEdit = Me.txtPrecioU
        Me.GridColumn11.FieldName = "PrecioU"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        Me.GridColumn11.Width = 103
        '
        'txtPrecioU
        '
        Me.txtPrecioU.AutoHeight = False
        Me.txtPrecioU.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioU.Name = "txtPrecioU"
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Precio C$"
        Me.GridColumn6.ColumnEdit = Me.txtPrecioC
        Me.GridColumn6.FieldName = "Precio"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 101
        '
        'txtPrecioC
        '
        Me.txtPrecioC.AutoHeight = False
        Me.txtPrecioC.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioC.Name = "txtPrecioC"
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn10.AppearanceHeader.Options.UseFont = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Sub Total C$"
        Me.GridColumn10.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "Total"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.AllowFocus = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")})
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 5
        Me.GridColumn10.Width = 124
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "IVA"
        Me.GridColumn12.DisplayFormat.FormatString = "n2"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "IVA"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:n2}")})
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Tipo"
        Me.GridColumn14.FieldName = "Tipo"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Exento"
        Me.GridColumn15.FieldName = "Exento"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Existencia"
        Me.GridColumn1.FieldName = "Existencia"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(576, 508)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Properties.Appearance.Options.UseFont = True
        Me.txtDireccion.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.txtDireccion.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.txtDireccion.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtDireccion.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtDireccion.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtDireccion.Size = New System.Drawing.Size(326, 22)
        Me.txtDireccion.StyleController = Me.frmPedidosConvertedLayout
        Me.txtDireccion.TabIndex = 159
        Me.txtDireccion.Visible = False
        '
        'cbConsignatarios
        '
        Me.cbConsignatarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbConsignatarios.Location = New System.Drawing.Point(117, 92)
        Me.cbConsignatarios.Name = "cbConsignatarios"
        Me.cbConsignatarios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConsignatarios.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbConsignatarios.Properties.Appearance.Options.UseFont = True
        Me.cbConsignatarios.Properties.Appearance.Options.UseForeColor = True
        Me.cbConsignatarios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbConsignatarios.Properties.NullText = ""
        Me.cbConsignatarios.Properties.ShowFooter = False
        Me.cbConsignatarios.Properties.ShowHeader = False
        Me.cbConsignatarios.Size = New System.Drawing.Size(406, 22)
        Me.cbConsignatarios.StyleController = Me.frmPedidosConvertedLayout
        Me.cbConsignatarios.TabIndex = 195
        '
        'cbMetodosEnvios
        '
        Me.cbMetodosEnvios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMetodosEnvios.Location = New System.Drawing.Point(117, 144)
        Me.cbMetodosEnvios.Name = "cbMetodosEnvios"
        Me.cbMetodosEnvios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMetodosEnvios.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbMetodosEnvios.Properties.Appearance.Options.UseFont = True
        Me.cbMetodosEnvios.Properties.Appearance.Options.UseForeColor = True
        Me.cbMetodosEnvios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMetodosEnvios.Properties.NullText = ""
        Me.cbMetodosEnvios.Properties.ShowFooter = False
        Me.cbMetodosEnvios.Properties.ShowHeader = False
        Me.cbMetodosEnvios.Size = New System.Drawing.Size(406, 22)
        Me.cbMetodosEnvios.StyleController = Me.frmPedidosConvertedLayout
        Me.cbMetodosEnvios.TabIndex = 193
        '
        'cbAgencias
        '
        Me.cbAgencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAgencias.Location = New System.Drawing.Point(117, 118)
        Me.cbAgencias.Name = "cbAgencias"
        Me.cbAgencias.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAgencias.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbAgencias.Properties.Appearance.Options.UseFont = True
        Me.cbAgencias.Properties.Appearance.Options.UseForeColor = True
        Me.cbAgencias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAgencias.Properties.NullText = ""
        Me.cbAgencias.Properties.ShowFooter = False
        Me.cbAgencias.Properties.ShowHeader = False
        Me.cbAgencias.Size = New System.Drawing.Size(406, 22)
        Me.cbAgencias.StyleController = Me.frmPedidosConvertedLayout
        Me.cbAgencias.TabIndex = 191
        '
        'cmbcentrocosto
        '
        Me.cmbcentrocosto.Location = New System.Drawing.Point(590, 66)
        Me.cmbcentrocosto.Name = "cmbcentrocosto"
        Me.cmbcentrocosto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcentrocosto.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbcentrocosto.Properties.Appearance.Options.UseFont = True
        Me.cmbcentrocosto.Properties.Appearance.Options.UseForeColor = True
        Me.cmbcentrocosto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbcentrocosto.Properties.NullText = ""
        Me.cmbcentrocosto.Properties.ShowFooter = False
        Me.cmbcentrocosto.Properties.ShowHeader = False
        Me.cmbcentrocosto.Size = New System.Drawing.Size(166, 22)
        Me.cmbcentrocosto.StyleController = Me.frmPedidosConvertedLayout
        Me.cmbcentrocosto.TabIndex = 155
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.Location = New System.Drawing.Point(527, 108)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(445, 58)
        Me.txtObservaciones.StyleController = Me.frmPedidosConvertedLayout
        Me.txtObservaciones.TabIndex = 190
        '
        'txtLogin
        '
        Me.txtLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLogin.EnterMoveNextControl = True
        Me.txtLogin.Location = New System.Drawing.Point(767, 40)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtLogin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtLogin.Properties.Appearance.Options.UseBackColor = True
        Me.txtLogin.Properties.Appearance.Options.UseFont = True
        Me.txtLogin.Properties.Appearance.Options.UseForeColor = True
        Me.txtLogin.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtLogin.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtLogin.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtLogin.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtLogin.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtLogin.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtLogin.Properties.ReadOnly = True
        Me.txtLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtLogin.Size = New System.Drawing.Size(205, 22)
        Me.txtLogin.StyleController = Me.frmPedidosConvertedLayout
        Me.txtLogin.TabIndex = 189
        '
        'etTasa
        '
        Me.etTasa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etTasa.EditValue = 1
        Me.etTasa.EnterMoveNextControl = True
        Me.etTasa.Location = New System.Drawing.Point(865, 66)
        Me.etTasa.Name = "etTasa"
        Me.etTasa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.etTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTasa.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.etTasa.Properties.Appearance.Options.UseBackColor = True
        Me.etTasa.Properties.Appearance.Options.UseFont = True
        Me.etTasa.Properties.Appearance.Options.UseForeColor = True
        Me.etTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.etTasa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTasa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.etTasa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.etTasa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.etTasa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.etTasa.Properties.Mask.EditMask = "n4"
        Me.etTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.etTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.etTasa.Properties.ReadOnly = True
        Me.etTasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.etTasa.Size = New System.Drawing.Size(107, 22)
        Me.etTasa.StyleController = Me.frmPedidosConvertedLayout
        Me.etTasa.TabIndex = 187
        '
        'txtPedido
        '
        Me.txtPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPedido.Location = New System.Drawing.Point(648, 12)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedido.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPedido.Properties.Appearance.Options.UseBackColor = True
        Me.txtPedido.Properties.Appearance.Options.UseFont = True
        Me.txtPedido.Properties.Appearance.Options.UseForeColor = True
        Me.txtPedido.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.txtPedido.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedido.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.txtPedido.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtPedido.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtPedido.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPedido.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtPedido.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedido.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtPedido.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtPedido.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtPedido.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtPedido.Properties.Mask.EditMask = "d"
        Me.txtPedido.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPedido.Properties.ReadOnly = True
        Me.txtPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPedido.Size = New System.Drawing.Size(107, 22)
        Me.txtPedido.StyleController = Me.frmPedidosConvertedLayout
        Me.txtPedido.TabIndex = 167
        '
        'dtpFechaEntrega
        '
        Me.dtpFechaEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaEntrega.EditValue = Nothing
        Me.dtpFechaEntrega.EnterMoveNextControl = True
        Me.dtpFechaEntrega.Location = New System.Drawing.Point(348, 66)
        Me.dtpFechaEntrega.Name = "dtpFechaEntrega"
        Me.dtpFechaEntrega.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFechaEntrega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEntrega.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaEntrega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaEntrega.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFechaEntrega.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpFechaEntrega.Size = New System.Drawing.Size(133, 20)
        Me.dtpFechaEntrega.StyleController = Me.frmPedidosConvertedLayout
        Me.dtpFechaEntrega.TabIndex = 153
        '
        'dtpFecha
        '
        Me.dtpFecha.EditValue = Nothing
        Me.dtpFecha.EnterMoveNextControl = True
        Me.dtpFecha.Location = New System.Drawing.Point(117, 66)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Properties.Appearance.Options.UseFont = True
        Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpFecha.Properties.Mask.EditMask = "ddMMyy"
        Me.dtpFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtpFecha.Size = New System.Drawing.Size(122, 20)
        Me.dtpFecha.StyleController = Me.frmPedidosConvertedLayout
        Me.dtpFecha.TabIndex = 152
        '
        'TipoSolicitud
        '
        Me.TipoSolicitud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoSolicitud.EditValue = "P"
        Me.TipoSolicitud.Location = New System.Drawing.Point(752, 170)
        Me.TipoSolicitud.Name = "TipoSolicitud"
        Me.TipoSolicitud.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TipoSolicitud.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoSolicitud.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.TipoSolicitud.Properties.Appearance.Options.UseBackColor = True
        Me.TipoSolicitud.Properties.Appearance.Options.UseFont = True
        Me.TipoSolicitud.Properties.Appearance.Options.UseForeColor = True
        Me.TipoSolicitud.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Productos"), New DevExpress.XtraEditors.Controls.RadioGroupItem("I", "Miscelaneos"), New DevExpress.XtraEditors.Controls.RadioGroupItem("A", "Ambos", False)})
        Me.TipoSolicitud.Size = New System.Drawing.Size(220, 50)
        Me.TipoSolicitud.StyleController = Me.frmPedidosConvertedLayout
        Me.TipoSolicitud.TabIndex = 145
        Me.TipoSolicitud.TabStop = False
        '
        'txtRuc
        '
        Me.txtRuc.Enabled = False
        Me.txtRuc.Location = New System.Drawing.Point(576, 494)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtRuc.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRuc.Properties.Appearance.Options.UseBackColor = True
        Me.txtRuc.Properties.Appearance.Options.UseFont = True
        Me.txtRuc.Properties.Appearance.Options.UseForeColor = True
        Me.txtRuc.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.txtRuc.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.txtRuc.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtRuc.Properties.AppearanceDisabled.Options.UseFont = True
        Me.txtRuc.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtRuc.Size = New System.Drawing.Size(158, 20)
        Me.txtRuc.StyleController = Me.frmPedidosConvertedLayout
        Me.txtRuc.TabIndex = 157
        Me.txtRuc.Visible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtTelefono
        Me.LayoutControlItem3.CustomizationFormText = "IVA :"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(564, 482)
        Me.LayoutControlItem3.Name = "txtTelefonoitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(108, 40)
        Me.LayoutControlItem3.Text = "IVA :"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Bottom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtRuc
        Me.LayoutControlItem10.CustomizationFormText = "txtRucitem"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(564, 482)
        Me.LayoutControlItem10.Name = "txtRucitem"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(162, 40)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtDepartamento
        Me.LayoutControlItem1.CustomizationFormText = "Sub Total :"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(564, 482)
        Me.LayoutControlItem1.Name = "txtDepartamentoitem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(262, 40)
        Me.LayoutControlItem1.Text = "Sub Total :"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Bottom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtMunicipio
        Me.LayoutControlItem6.CustomizationFormText = "txtMunicipioitem"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(564, 496)
        Me.LayoutControlItem6.Name = "txtMunicipioitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(316, 26)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cmdConsultaProveedor
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(894, 496)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(70, 26)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtDireccion
        Me.LayoutControlItem9.CustomizationFormText = "txtDireccionitem"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(564, 496)
        Me.LayoutControlItem9.Name = "txtDireccionitem"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(330, 26)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem11, Me.txtPedidoitem, Me.dtpFechaitem, Me.dtpFechaEntregaitem, Me.etTasaitem, Me.cbAgenciasitem, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem13, Me.EmptySpaceItem3, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.EmptySpaceItem4, Me.LayoutControlItem12, Me.txtLoginitem, Me.LayoutControlItem22, Me.cbConsignatariositem, Me.cbMetodosEnviositem, Me.txtObservacionesitem, Me.LayoutControlItem21, Me.cmbcentrocostoitem, Me.TipoSolicituditem, Me.LayoutControlItem23})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(984, 428)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.GridDetalle
        Me.LayoutControlItem8.CustomizationFormText = "GridDetalleitem"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 212)
        Me.LayoutControlItem8.Name = "GridDetalleitem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(964, 100)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cbCondiciones
        Me.LayoutControlItem11.CustomizationFormText = "Condición de Venta:"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(325, 26)
        Me.LayoutControlItem11.Text = "Terminos de Pago:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(102, 13)
        '
        'txtPedidoitem
        '
        Me.txtPedidoitem.Control = Me.txtPedido
        Me.txtPedidoitem.CustomizationFormText = "#Consecutivo:"
        Me.txtPedidoitem.Location = New System.Drawing.Point(531, 0)
        Me.txtPedidoitem.MaxSize = New System.Drawing.Size(216, 28)
        Me.txtPedidoitem.MinSize = New System.Drawing.Size(216, 28)
        Me.txtPedidoitem.Name = "txtPedidoitem"
        Me.txtPedidoitem.Size = New System.Drawing.Size(216, 28)
        Me.txtPedidoitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.txtPedidoitem.Text = "#Consecutivo:"
        Me.txtPedidoitem.TextSize = New System.Drawing.Size(102, 13)
        '
        'dtpFechaitem
        '
        Me.dtpFechaitem.Control = Me.dtpFecha
        Me.dtpFechaitem.CustomizationFormText = "Fecha:"
        Me.dtpFechaitem.Location = New System.Drawing.Point(0, 54)
        Me.dtpFechaitem.MaxSize = New System.Drawing.Size(231, 26)
        Me.dtpFechaitem.MinSize = New System.Drawing.Size(231, 26)
        Me.dtpFechaitem.Name = "dtpFechaitem"
        Me.dtpFechaitem.Size = New System.Drawing.Size(231, 26)
        Me.dtpFechaitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.dtpFechaitem.Text = "Fecha:"
        Me.dtpFechaitem.TextSize = New System.Drawing.Size(102, 13)
        '
        'dtpFechaEntregaitem
        '
        Me.dtpFechaEntregaitem.Control = Me.dtpFechaEntrega
        Me.dtpFechaEntregaitem.CustomizationFormText = "Fecha de  Entrega:"
        Me.dtpFechaEntregaitem.Location = New System.Drawing.Point(231, 54)
        Me.dtpFechaEntregaitem.MaxSize = New System.Drawing.Size(242, 26)
        Me.dtpFechaEntregaitem.MinSize = New System.Drawing.Size(242, 26)
        Me.dtpFechaEntregaitem.Name = "dtpFechaEntregaitem"
        Me.dtpFechaEntregaitem.Size = New System.Drawing.Size(242, 26)
        Me.dtpFechaEntregaitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.dtpFechaEntregaitem.Text = "Fecha de  Entrega:"
        Me.dtpFechaEntregaitem.TextSize = New System.Drawing.Size(102, 13)
        '
        'etTasaitem
        '
        Me.etTasaitem.Control = Me.etTasa
        Me.etTasaitem.CustomizationFormText = "T/Cambio:"
        Me.etTasaitem.Location = New System.Drawing.Point(748, 54)
        Me.etTasaitem.MaxSize = New System.Drawing.Size(216, 26)
        Me.etTasaitem.MinSize = New System.Drawing.Size(216, 26)
        Me.etTasaitem.Name = "etTasaitem"
        Me.etTasaitem.Size = New System.Drawing.Size(216, 26)
        Me.etTasaitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.etTasaitem.Text = "T/Cambio:"
        Me.etTasaitem.TextSize = New System.Drawing.Size(102, 13)
        '
        'cbAgenciasitem
        '
        Me.cbAgenciasitem.Control = Me.cbAgencias
        Me.cbAgenciasitem.CustomizationFormText = "Agencia:"
        Me.cbAgenciasitem.Location = New System.Drawing.Point(0, 106)
        Me.cbAgenciasitem.MaxSize = New System.Drawing.Size(515, 26)
        Me.cbAgenciasitem.MinSize = New System.Drawing.Size(515, 26)
        Me.cbAgenciasitem.Name = "cbAgenciasitem"
        Me.cbAgenciasitem.Size = New System.Drawing.Size(515, 26)
        Me.cbAgenciasitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.cbAgenciasitem.Text = "Agencia:"
        Me.cbAgenciasitem.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.lbltotal
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(767, 360)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Label11
        Me.LayoutControlItem4.CustomizationFormText = "Label11item"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(645, 360)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(122, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(122, 24)
        Me.LayoutControlItem4.Name = "Label11item"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(122, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.lbliva
        Me.LayoutControlItem5.CustomizationFormText = "lblivaitem"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(767, 336)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem5.Name = "lblivaitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.lblsubtotal
        Me.LayoutControlItem7.CustomizationFormText = "lblsubtotalitem"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(767, 312)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem7.Name = "lblsubtotalitem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.Label1
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(645, 384)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(122, 24)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(122, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(122, 24)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.lblTotalU
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(767, 384)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(197, 24)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.Label3
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(645, 312)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(122, 24)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(122, 24)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(122, 24)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.Label4
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(645, 336)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(122, 24)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(122, 24)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(122, 24)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cmdAceptar
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 312)
        Me.LayoutControlItem13.MaxSize = New System.Drawing.Size(94, 42)
        Me.LayoutControlItem13.MinSize = New System.Drawing.Size(94, 42)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(94, 42)
        Me.LayoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 354)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(645, 54)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cmdConsulta
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(94, 312)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cmdCancelar
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(549, 312)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(198, 312)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(351, 42)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtNumeroAlterno
        Me.LayoutControlItem12.CustomizationFormText = "No. Pedido:"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(747, 0)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(217, 28)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(217, 28)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(217, 28)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "No. Pedido:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(102, 13)
        '
        'txtLoginitem
        '
        Me.txtLoginitem.Control = Me.txtLogin
        Me.txtLoginitem.CustomizationFormText = "Usuario:"
        Me.txtLoginitem.Location = New System.Drawing.Point(650, 28)
        Me.txtLoginitem.MaxSize = New System.Drawing.Size(314, 26)
        Me.txtLoginitem.MinSize = New System.Drawing.Size(314, 26)
        Me.txtLoginitem.Name = "txtLoginitem"
        Me.txtLoginitem.Size = New System.Drawing.Size(314, 26)
        Me.txtLoginitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.txtLoginitem.Text = "Usuario:"
        Me.txtLoginitem.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtSeguimiento
        Me.LayoutControlItem22.CustomizationFormText = "Seguimiento:"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 158)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(0, 54)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(109, 54)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(740, 54)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.Text = "Seguimiento:"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(102, 13)
        '
        'cbConsignatariositem
        '
        Me.cbConsignatariositem.Control = Me.cbConsignatarios
        Me.cbConsignatariositem.CustomizationFormText = "Consignatario:"
        Me.cbConsignatariositem.Location = New System.Drawing.Point(0, 80)
        Me.cbConsignatariositem.MaxSize = New System.Drawing.Size(515, 26)
        Me.cbConsignatariositem.MinSize = New System.Drawing.Size(515, 26)
        Me.cbConsignatariositem.Name = "cbConsignatariositem"
        Me.cbConsignatariositem.Size = New System.Drawing.Size(515, 26)
        Me.cbConsignatariositem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.cbConsignatariositem.Text = "Consignatario:"
        Me.cbConsignatariositem.TextSize = New System.Drawing.Size(102, 13)
        '
        'cbMetodosEnviositem
        '
        Me.cbMetodosEnviositem.Control = Me.cbMetodosEnvios
        Me.cbMetodosEnviositem.CustomizationFormText = "Metodo de Envio:"
        Me.cbMetodosEnviositem.Location = New System.Drawing.Point(0, 132)
        Me.cbMetodosEnviositem.MaxSize = New System.Drawing.Size(515, 26)
        Me.cbMetodosEnviositem.MinSize = New System.Drawing.Size(515, 26)
        Me.cbMetodosEnviositem.Name = "cbMetodosEnviositem"
        Me.cbMetodosEnviositem.Size = New System.Drawing.Size(515, 26)
        Me.cbMetodosEnviositem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.cbMetodosEnviositem.Text = "Metodo de Envio:"
        Me.cbMetodosEnviositem.TextSize = New System.Drawing.Size(102, 13)
        '
        'txtObservacionesitem
        '
        Me.txtObservacionesitem.Control = Me.txtObservaciones
        Me.txtObservacionesitem.CustomizationFormText = "Observaciones:"
        Me.txtObservacionesitem.Location = New System.Drawing.Point(515, 80)
        Me.txtObservacionesitem.MaxSize = New System.Drawing.Size(0, 78)
        Me.txtObservacionesitem.MinSize = New System.Drawing.Size(96, 78)
        Me.txtObservacionesitem.Name = "txtObservacionesitem"
        Me.txtObservacionesitem.Size = New System.Drawing.Size(449, 78)
        Me.txtObservacionesitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.txtObservacionesitem.Text = "Observaciones:"
        Me.txtObservacionesitem.TextLocation = DevExpress.Utils.Locations.Top
        Me.txtObservacionesitem.TextSize = New System.Drawing.Size(102, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.cbFormaPago
        Me.LayoutControlItem21.CustomizationFormText = "Forma de Pago:"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(325, 28)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(325, 26)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(325, 26)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(325, 26)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.Text = "Forma de Pago:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(102, 13)
        '
        'cmbcentrocostoitem
        '
        Me.cmbcentrocostoitem.Control = Me.cmbcentrocosto
        Me.cmbcentrocostoitem.CustomizationFormText = "Centro de Costo:"
        Me.cmbcentrocostoitem.Location = New System.Drawing.Point(473, 54)
        Me.cmbcentrocostoitem.Name = "cmbcentrocostoitem"
        Me.cmbcentrocostoitem.Size = New System.Drawing.Size(275, 26)
        Me.cmbcentrocostoitem.Text = "Centro de Costo:"
        Me.cmbcentrocostoitem.TextSize = New System.Drawing.Size(102, 13)
        '
        'TipoSolicituditem
        '
        Me.TipoSolicituditem.Control = Me.TipoSolicitud
        Me.TipoSolicituditem.CustomizationFormText = "TipoSolicituditem"
        Me.TipoSolicituditem.Location = New System.Drawing.Point(740, 158)
        Me.TipoSolicituditem.MaxSize = New System.Drawing.Size(224, 54)
        Me.TipoSolicituditem.MinSize = New System.Drawing.Size(224, 54)
        Me.TipoSolicituditem.Name = "TipoSolicituditem"
        Me.TipoSolicituditem.Size = New System.Drawing.Size(224, 54)
        Me.TipoSolicituditem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.TipoSolicituditem.TextSize = New System.Drawing.Size(0, 0)
        Me.TipoSolicituditem.TextVisible = False
        '
        'cbProveedor
        '
        Me.cbProveedor.Location = New System.Drawing.Point(117, 12)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.Properties.Appearance.Options.UseFont = True
        Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedor.Properties.View = Me.SearchLookUpEdit1View
        Me.cbProveedor.Size = New System.Drawing.Size(422, 20)
        Me.cbProveedor.StyleController = Me.frmPedidosConvertedLayout
        Me.cbProveedor.TabIndex = 200
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cbProveedor
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(531, 28)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(102, 13)
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'frmPedidos
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(984, 428)
        Me.Controls.Add(Me.frmPedidosConvertedLayout)
        Me.LookAndFeel.SkinName = "Blue"
        Me.Name = "frmPedidos"
        CType(Me.frmPedidosConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmPedidosConvertedLayout.ResumeLayout(False)
        CType(Me.txtSeguimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroAlterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCondiciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemArticuloD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbConsignatarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMetodosEnvios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAgencias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbcentrocosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLogin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaEntrega.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoSolicitud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPedidoitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaEntregaitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etTasaitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAgenciasitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoginitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbConsignatariositem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMetodosEnviositem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacionesitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbcentrocostoitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoSolicituditem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas()
    Private Temp As Boolean = False

    Private Config As New VB.SysContab.ConfiguracionDB
    Private ConfigDetalles As New VB.SysContab.ConfiguracionDetails

    Dim Proveedores As New VB.SysContab.ProveedoresDB()
    Dim DetallesProveedor As New VB.SysContab.ProveedoresDetails()
    Dim Departamentos As New VB.SysContab.DepartamentosCDB()
    Dim Municipios As New VB.SysContab.MunicipiosDB()
    Dim Articulos As New VB.SysContab.ArticulosDB()
    Dim DetallesProducto As New VB.SysContab.ArticulosDetails()
    Dim Pedidos As New VB.SysContab.PedidosDB()

    Dim ArticulosCC As New VB.SysContab.GruposCCDB()
    Dim FormaPago As New VB.SysContab.Forma_PagoDB()

    Dim ValorActualCantidad As Double
    Dim ValorActualDescuento As Double

    Dim i As Integer

    Dim Servicio As Boolean

    Dim dsItems As DataSet
    Dim Tipo As Integer '0 --> Productos 1 --> Inventario, 2 -- > Ambos

    Dim dsItemCC As DataSet

    Dim TCambio As Double = 1
    ' Public TipoPedido As String
    Public IdPedido As Integer = 0

    Private Sub frmPedidos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ''Para refrescar la lista de los pedidos
        'Dim f As frmListaPedidos = frmListaPedidos.Instance()
        'f.Cargar()

        ''If f.checkBoxFecha.Checked = True Then
        ''    f.ds = Pedidos.PedidosListXFecha(f.cbProveedores.EditValue, f.cbEstado.SelectedIndex, f.fDesde.DateTime.Date, f.fHasta.DateTime.Date)
        ''    f.Cargar()
        ''Else
        ''    f.ds = Pedidos.PedidosList(f.cbProveedores.EditValue, f.cbEstado.SelectedIndex)
        ''    f.Cargar()
        ''End If

        'f.CargarRegistro()
    End Sub

    Private Sub frmPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.DateTime = Now.Date
        Me.dtpFechaEntrega.DateTime = Now.Date

        'CargarProveedores()
        'GetCatalogoProveedores(Me.cbProveedor, Me.vProve)
        SearchLookUp(cbProveedor, VB.SysContab.ProveedoresDB.ProveedoresList(1).Tables("Proveedores"), "Nombre", "Codigo")
        GetCentrosCostosList(Me.cmbcentrocosto)
        GetConsignatarios(cbConsignatarios)
        GetMetodosEnvio(cbMetodosEnvios)
        GetAgencias(cbAgencias)
        GetCondicionesVenta(cbCondiciones)
        GetFormaPagoList(cbFormaPago)
        '
        GetArticulos()
        MostrarPedido()
        CalcularTotales()

        LeaveCommit = False
        BuscarCombo = True
        TipoItem = "P"
        Indice = -1
        Tipo = 0
        Servicio = False

        ConfigDetalles = Config.GetConfigDetails

        Me.txtPrecioC.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioC.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

        Me.txtPrecioU.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioU.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString
    End Sub

    Sub MostrarPedido()
        Dim DT As DataTable = ObtieneDatos("JAR_GetDetallePedido " & IdPedido & "," & EmpresaActual)

        Dim f As Date = Rutinas.Fecha().Date

        If DT.Rows.Count = 0 Then   'Nuevo
            dtpFecha.DateTime = f.Date
            dtpFechaEntrega.DateTime = f.Date
            txtPedido.EditValue = Pedidos.PedidoNumero
            txtNumeroAlterno.Text = txtPedido.EditValue.ToString.PadLeft(5, "0") + "-" + dtpFecha.DateTime.Date.Day.ToString + dtpFecha.DateTime.Date.Month.ToString + Mid(dtpFecha.DateTime.Date.Year.ToString, 4, 1).ToString
            txtLogin.Text = Login
            Me.GridDetalle.DataSource = DT
        Else
            cbProveedor.EditValue = DT.Rows.Item(0)("Proveedor_ID")
            txtPedido.EditValue = DT.Rows.Item(0)("Ped_ID")
            txtNumeroAlterno.Text = DT.Rows.Item(0)("NoPedidoAlterno")
            cbFormaPago.EditValue = DT.Rows.Item(0)("FormaPagoID")
            txtNumeroAlterno.Text = DT.Rows.Item(0)("NoPedidoAlterno")
            cbCondiciones.EditValue = DT.Rows.Item(0)("Terminos")
            dtpFecha.DateTime = DT.Rows.Item(0)("Ped_Fecha")
            dtpFechaEntrega.DateTime = DT.Rows.Item(0)("Ped_FechaEntrega")
            etTasa.EditValue = DT.Rows.Item(0)("Tasa")
            TCambio = etTasa.EditValue
            txtObservaciones.Text = DT.Rows.Item(0)("Observaciones")
            txtSeguimiento.Text = DT.Rows.Item(0)("Seguimiento")
            cmbcentrocosto.EditValue = DT.Rows.Item(0)("CentroCosto")
            cbConsignatarios.EditValue = DT.Rows.Item(0)("Consignatario")
            cbMetodosEnvios.EditValue = DT.Rows.Item(0)("Metodo_Envio")
            cbAgencias.EditValue = DT.Rows.Item(0)("Agencia")
            txtLogin.Text = DT.Rows.Item(0)("Usuario")
            TipoSolicitud.EditValue = DT.Rows.Item(0)("Ped_Tipo")

            Me.GridDetalle.DataSource = DT
        End If

        'ObtieneDatos("SELECT '' Item,1 Cantidad,0.00 PrecioU,0.00 Precio,0.00 Total," _
        '      + " 0.00 IVA,'' Tipo,0.00 Existencia,convert(bit,0) Exento FROM Usuarios WHERE 0=1")

    End Sub

    'Sub CargarProveedores()
    '    Me.cbProveedor.Properties.DataSource = Nothing

    '    If ChkProveedores Then  ' Mostrar Solo Proveedores Aprobados
    '        Me.cbProveedor.Properties.DataSource = ObtieneDatos("SELECT Codigo,CodigoLetra, Nombre,Cuenta,CodigoLetra + ' ' + Nombre Display FROM Proveedores WHERE Tipo <> 4 AND (Aprobar = 1 AND Confirmar = 1) AND Empresa =" & EmpresaActual).DefaultView
    '    Else
    '        Me.cbProveedor.Properties.DataSource = ObtieneDatos("SELECT Codigo,CodigoLetra, Nombre,Cuenta,CodigoLetra + ' ' + Nombre Display FROM Proveedores WHERE Tipo <> 4 AND Empresa =" & EmpresaActual).DefaultView
    '    End If

    '    Me.cbProveedor.Properties.ValueMember = "Codigo"
    '    Me.cbProveedor.Properties.DisplayMember = "Display"
    'End Sub

    Sub GetArticulos()
        If Me.TipoSolicitud.EditValue = "I" Then
            Me.ItemArticulo.DataSource = ArticulosCC.ArticulosCCInvent().Tables("GruposCC").DefaultView
            Me.ItemArticulo.DisplayMember = "Codigo"
            Me.ItemArticulo.ValueMember = "Codigo"
            Me.ItemArticulo.PopulateColumns()

            For i As Integer = 0 To Me.ItemArticulo.Columns.Count - 1
                Me.ItemArticulo.Columns(i).Visible = False
            Next

            Me.ItemArticulo.Columns("Codigo").Visible = True


            Me.ItemArticuloD.DataSource = ArticulosCC.ArticulosCCInvent().Tables("GruposCC").DefaultView
            Me.ItemArticuloD.DisplayMember = "Nombre"
            Me.ItemArticuloD.ValueMember = "Codigo"
            Me.ItemArticuloD.PopulateColumns()

            For i As Integer = 0 To Me.ItemArticuloD.Columns.Count - 1
                Me.ItemArticuloD.Columns(i).Visible = False
            Next

            Me.ItemArticuloD.Columns("Nombre").Visible = True
        Else
            Me.ItemArticulo.DataSource = Articulos.ProductosGetLista(Me.TipoSolicitud.EditValue).Tables("Articulos").DefaultView
            Me.ItemArticulo.DisplayMember = "Codigo"
            Me.ItemArticulo.ValueMember = "Codigo"
            Me.ItemArticulo.PopulateColumns()

            For i As Integer = 0 To Me.ItemArticulo.Columns.Count - 1
                Me.ItemArticulo.Columns(i).Visible = False
            Next

            Me.ItemArticulo.Columns("Codigo").Visible = True

            Me.ItemArticuloD.DataSource = Articulos.ProductosGetLista(Me.TipoSolicitud.EditValue).Tables("Articulos").DefaultView
            Me.ItemArticuloD.DisplayMember = "Nombre"
            Me.ItemArticuloD.ValueMember = "Codigo"
            Me.ItemArticuloD.PopulateColumns()

            For i As Integer = 0 To Me.ItemArticuloD.Columns.Count - 1
                Me.ItemArticuloD.Columns(i).Visible = False
            Next

            Me.ItemArticuloD.Columns("Nombre").Visible = True
        End If

        'GetData()
    End Sub

    Private Sub GetData()

        'Dim Datos As New ArrayList
        'Dim Variables As New ArrayList

        'Variables.Add("Empresa")
        'Variables.Add("Factura")

        'Datos.Add(EmpresaActual)
        'Datos.Add(Factura)
        'DT_Facturas = ProcedureParameters(Datos, Variables, "sp_GetDetalleOrdenEntrega")
        'GridDetalle.DataSource = DT_Facturas

        'Me.GridDetalle.DataSource = ObtieneDatos("SELECT '' Item,1 Cantidad,0.00 PrecioU,0.00 Precio,0.00 Total," _
        '                                         + " 0.00 IVA,'' Tipo,0.00 Existencia,convert(bit,0) Exento FROM Usuarios WHERE 0=1")

        'ConfigDetalles = Config.GetConfigDetails

        'Me.txtPrecioC.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        'Me.txtPrecioC.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

        'Me.txtPrecioU.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        'Me.txtPrecioU.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.cbProveedor.EditValue Is Nothing Then
            XtraMsg("Seleccione el Proveedor")
            cbProveedor.Focus()
            Exit Sub
        End If
        ''
        If txtNumeroAlterno.Text.Trim.Length = 0 Then
            XtraMsg("Ingrese el Número de Pedido")
            txtNumeroAlterno.Focus()
            Exit Sub
        End If

        If Me.GridView1.DataRowCount = 0 Then
            XtraMsg("Seleccione al menos un Producto", MessageBoxIcon.Error)
            Me.GridDetalle.Focus()
            Exit Sub
        End If

        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction

        Try

            ShowSplash("Guardando Pedido...")

            If IdPedido = 0 Then    'Nuevo
                txtPedido.EditValue = Pedidos.PedidoNumero()

                Pedidos.AddItem(txtPedido.Text, dtpFecha.DateTime.Date, dtpFechaEntrega.DateTime.Date,
                            cbProveedor.EditValue, Tipo, cbFormaPago.EditValue, Usuario_ID,
                             IIf(Me.cmbcentrocosto.EditValue Is Nothing, 0, Me.cmbcentrocosto.EditValue),
                              cbCondiciones.EditValue, txtObservaciones.Text, txtSeguimiento.Text,
                                IIf(Me.cbConsignatarios.EditValue Is Nothing, 0, Me.cbConsignatarios.EditValue),
                                IIf(Me.cbMetodosEnvios.EditValue Is Nothing, 0, Me.cbMetodosEnvios.EditValue),
                                IIf(Me.cbAgencias.EditValue Is Nothing, 0, Me.cbAgencias.EditValue),
                                txtNumeroAlterno.Text)
            Else    'Editar
                Pedidos.Update(txtPedido.EditValue, dtpFecha.DateTime.Date,
                               dtpFechaEntrega.DateTime.Date, cbProveedor.EditValue, Tipo,
                               cbFormaPago.EditValue, Usuario_ID,
                             IIf(Me.cmbcentrocosto.EditValue Is Nothing, 0, Me.cmbcentrocosto.EditValue),
                              cbCondiciones.EditValue, txtObservaciones.Text, txtSeguimiento.Text,
                                IIf(Me.cbConsignatarios.EditValue Is Nothing, 0, Me.cbConsignatarios.EditValue),
                                IIf(Me.cbMetodosEnvios.EditValue Is Nothing, 0, Me.cbMetodosEnvios.EditValue),
                                IIf(Me.cbAgencias.EditValue Is Nothing, 0, Me.cbAgencias.EditValue),
                                txtNumeroAlterno.Text)
            End If

            Pedidos.DeletePedidosLineas(txtPedido.EditValue)

            For i As Integer = 0 To Me.GridView1.DataRowCount - 1
                Pedidos.AddPedidosLineas(Me.txtPedido.EditValue, Me.GridView1.GetRowCellValue(i, "Item"), Me.GridView1.GetRowCellValue(i, "Cantidad"),
                                         Me.GridView1.GetRowCellValue(i, "Precio"), Me.GridView1.GetRowCellValue(i, "Tipo"))
            Next


            VB.SysContab.Rutinas.okTransaccion()
            LimpiarControles()

            'If Me.rbInventario.Checked = True Then
            '    txtPedido.Text = Pedidos.PedidoCCNumero
            '    Pedidos.PedidosCCAdd(txtPedido.Text, dtpFecha.DateTime.Date, dtpFechaEntrega.DateTime.Date, cbProveedor.EditValue)
            'Else
            '    txtPedido.Text = Pedidos.PedidoNumero
            '    Pedidos.AddItem(txtPedido.Text, dtpFecha.DateTime.Date, dtpFechaEntrega.DateTime.Date, cbProveedor.EditValue, Tipo)
            'End If

            'If tCust.Rows.Count > 0 Then
            '    If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Costo") Is DBNull.Value Then
            '        tCust.Rows(tCust.Rows.Count - 1).Delete()
            '    End If
            'End If
            'If Me.rbInventario.Checked = True Then
            '    For i = 0 To tCust.Rows.Count - 1
            '        Pedidos.PedidosCCLineasAdd(txtPedido.Text, tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Cantidad"), tCust.Rows(i)("Costo"))
            '    Next
            'Else
            '    For i = 0 To tCust.Rows.Count - 1
            '        Pedidos.AddPedidosLineas(txtPedido.Text, tCust.Rows(i)("ArticuloCodigo"), tCust.Rows(i)("Cantidad"), tCust.Rows(i)("Costo"), tCust.Rows(i)("Tipo"))
            '    Next
            'End If

            HideSplash()

            XtraMsg("Pedido Guardado con Exito!")
            Dim f As frmListaPedidos = frmListaPedidos.Instance()
            f.Cargar()

            Close()
        Catch ex As Exception
            HideSplash()
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LimpiarControles()
        txtPedido.EditValue = Pedidos.PedidoNumero
        GetCodigoAlterno()
        TipoSolicitud.EditValue = "P"
        IdPedido = 0
        GetArticulos()
        MostrarPedido()
        ' GetData()

        lblsubtotal.Text = "0.00"
        lbliva.Text = "0.00"
        lbltotal.Text = "0.00"
        lblTotalU.Text = "0.00"

        If Me.TipoSolicitud.EditValue = "P" Then
            Tipo = 0
        ElseIf Me.TipoSolicitud.EditValue = "I" Then
            Tipo = 1
        ElseIf Me.TipoSolicitud.EditValue = "A" Then
            Tipo = 2
        End If

        'etTotal.Text = "0.00"
        'Indice = -1
        'tCust.Rows.Clear()
        'MakeDataSet()
        'dgPedidos.SetDataBinding(myDataSet, "Articulos")
        'AddCustomDataTableStyle()
        'r.ComboAutoComplete(Articulo.ColumnComboBox)
        'r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
    End Sub


    Private Sub cmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsulta.Click
        If GridView1.FocusedRowHandle < 0 Then
            Exit Sub
        End If
        '
        Dim f As frmGridArticulosxBodega = frmGridArticulosxBodega.Instance()
        f.cArticulo = GridView1.GetFocusedRowCellValue("Item")
        f.Text = "PRODUCTO: " + GridView1.GetFocusedRowCellValue("Item")
        f.TipoProducto = "P"
        f.ShowDialog()
        f.Dispose()



        'Dim f As frmBuscarItem = f.Instance
        'If tCust.Rows.Count > 0 Then
        '    If tCust.Rows(tCust.Rows.Count - 1)("ArticuloCodigo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Articulo") Is DBNull.Value And tCust.Rows(tCust.Rows.Count - 1)("Costo") Is DBNull.Value Then
        '        tCust.Rows(tCust.Rows.Count - 1).Delete()
        '    End If
        'End If
        'If Me.TipoSolicitud.EditValue = "P" Then
        '    Dim f As frmBuscarItem = f.Instance
        '    f.MdiParent = Me.MdiParent
        '    f.Show()
        'ElseIf Me.TipoSolicitud.EditValue = "I" Then
        '    Dim f As frmBuscarItemCC = f.Instance
        '    f.etInicio.Text = "1"
        '    f.MdiParent = Me.MdiParent
        '    f.Show()
        '    f.etInicio.Text = "0"
        'End If
    End Sub

    Private Sub rbActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Inicio = True Then
        '    Exit Sub
        'End If

        'If rbActivo.Checked = True Then
        '    Tipo = 2
        '    Dim dsItems As DataSet
        '    dsItems = Articulos.ProductosGetAll("P")

        '    ArticuloCodigo.ColumnComboBox.Items.Clear()
        '    Articulo.ColumnComboBox.Items.Clear()
        '    ItemTipo.ColumnComboBox.Items.Clear()

        '    For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
        '        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
        '        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
        '        ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

        '    Next
        'End If
        'TipoItem = "A"
    End Sub

    Private Sub rbInventario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MakeDataSet()
        'dgPedidos.SetDataBinding(myDataSet, "Articulos")
        'AddCustomDataTableStyle()

        'r.ComboAutoComplete(Articulo.ColumnComboBox)
        'r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)
        'If Inicio = True Then
        '    Exit Sub
        'End If

        'If rbInventario.Checked = True Then
        '    Tipo = 1
        '    Dim dsItems As DataSet
        '    dsItems = Articulos.ProductosGetAll("S")

        '    ArticuloCodigo.ColumnComboBox.Items.Clear()
        '    Articulo.ColumnComboBox.Items.Clear()
        '    ItemTipo.ColumnComboBox.Items.Clear()

        '    For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
        '        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
        '        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
        '        ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

        '    Next
        'End If
        'TipoItem = "S"
    End Sub

    Private Sub rbProductos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'MakeDataSet()
        'dgPedidos.SetDataBinding(myDataSet, "Articulos")
        'AddCustomDataTableStyle()

        'r.ComboAutoComplete(Articulo.ColumnComboBox)
        'r.ComboAutoComplete(ArticuloCodigo.ColumnComboBox)

        'If Inicio = True Then
        '    Exit Sub
        'End If

        'If rbProductos.Checked = True Then
        '    Tipo = 0
        '    Dim dsItems As DataSet

        '    dsItems = Articulos.ProductosGetAll("P")

        '    ArticuloCodigo.ColumnComboBox.Items.Clear()
        '    Articulo.ColumnComboBox.Items.Clear()
        '    ItemTipo.ColumnComboBox.Items.Clear()

        '    For i = 0 To dsItems.Tables("Articulos").Rows.Count - 1
        '        ArticuloCodigo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Codigo"))
        '        Articulo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Nombre"))
        '        ItemTipo.ColumnComboBox.Items.Add(dsItems.Tables("Articulos").Rows(i).Item("Tipo"))

        '    Next
        'End If
        'TipoItem = "P"
    End Sub

    'Private Sub cmdConsultaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaProveedor.Click
    '    If Me.cbProveedor.EditValue Is Nothing Then
    '        MsgBox("Seleccione el Proveedor", MsgBoxStyle.Information)
    '        Me.cbProveedor.Focus()
    '        Exit Sub
    '    End If

    '    'If Me.cbProveedor.EditValue = Nothing Then
    '    '    MsgBox("El Proveedor no está registrado", MsgBoxStyle.Information)
    '    '    Me.cbProveedor.Focus()
    '    '    Exit Sub
    '    'End If

    '    Dim f As frmAcumuladosProveedor = f.Instance

    '    f.Proveedor = Me.cbProveedor.EditValue

    '    f.MdiParent = Me.MdiParent
    '    f.Show()
    'End Sub

    'Private Sub cbProveedor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProveedor.EditValueChanged
    '    If Inicio Then Exit Sub

    '    If Me.cbProveedor.EditValue Is Nothing Then
    '        Exit Sub
    '    End If

    '    If Me.cbProveedor.EditValue Is Nothing Or IsNumeric(Me.cbProveedor.EditValue) = False Then
    '        txtRuc.Text = ""
    '        txtDireccion.Text = ""
    '        txtTelefono.Text = ""
    '        txtDepartamento.Text = ""
    '        txtMunicipio.Text = ""
    '        Exit Sub
    '    End If

    '    DetallesProveedor = ProveedoresDB.GetDetails(Me.cbProveedor.EditValue)

    '    Me.txtRuc.Text = DetallesProveedor.Ruc
    '    Me.txtDireccion.Text = DetallesProveedor.Direccion
    '    Me.txtTelefono.Text = DetallesProveedor.Telefono
    '    If IsNumeric(DetallesProveedor.Departamento) = True Then
    '        Try
    '            Me.txtDepartamento.Text = ObtieneDatos("SELECT Nombre_Departamento FROM DepartamentosC WHERE Codigo_Departamento = " & DetallesProveedor.Departamento & " AND Empresa = " & EmpresaActual).Rows.Item(0)("Nombre_Departamento").ToString
    '            Me.txtMunicipio.Text = ObtieneDatos("SELECT Nombre_Municipio FROM Municipios WHERE Codigo_Departamento = " & DetallesProveedor.Departamento & " AND Codigo_Municipio = " & DetallesProveedor.Municipio).Rows.Item(0)("Nombre_Municipio").ToString
    '        Catch ex As Exception
    '        End Try
    '    End If
    'End Sub

    Private Sub TipoSolicitud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoSolicitud.SelectedIndexChanged
        If Inicio Then Exit Sub

        GetArticulos()
        If Me.TipoSolicitud.EditValue = "P" Then
            Tipo = 0
        ElseIf Me.TipoSolicitud.EditValue = "I" Then
            Tipo = 1
        ElseIf Me.TipoSolicitud.EditValue = "A" Then
            Tipo = 2
        End If
    End Sub

    Private Sub GridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            GridView1.DeleteRow(GridView1.FocusedRowHandle)
            GridView1.FocusedRowHandle = GridView1.DataRowCount - 1
        End If
        CalcularTotales()
    End Sub

    Private Sub GridView1_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        CalcularTotales()
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If e.Column.FieldName = "Item" Then
            Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(e.Value)
            Temp = True
            GridView1.SetRowCellValue(e.RowHandle, "Precio", DR.Item("Precio"))
            GridView1.SetRowCellValue(e.RowHandle, "PrecioU", Math.Round(DR.Item("Precio") / TCambio, 2))
            GridView1.SetRowCellValue(e.RowHandle, "Cantidad", 1)
            GridView1.SetRowCellValue(e.RowHandle, "Tipo", DR.Item("Tipo"))
            GridView1.SetRowCellValue(e.RowHandle, "Exento", DR.Item("Exento"))
            Temp = False
        End If

        If e.Column.FieldName = "Precio" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                GridView1.SetRowCellValue(e.RowHandle, "PrecioU", CDbl(e.Value / TCambio))
                Temp = False
            End If
        End If

        If e.Column.FieldName = "PrecioU" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                GridView1.SetRowCellValue(e.RowHandle, "Precio", CDbl(e.Value * TCambio))
                Temp = False
            End If
        End If

        If e.Column.FieldName = "Descuento" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                GridView1.SetRowCellValue(e.RowHandle, "Descuento", e.Value / 100)
                Temp = False
            End If
        End If

        If e.Column.FieldName = "Precio" Or e.Column.FieldName = "Cantidad" Or e.Column.FieldName = "Descuento" Then
            GridView1.SetRowCellValue(e.RowHandle, "Total", IsNull(GridView1.GetRowCellValue(e.RowHandle, "Cantidad"), 1) * IsNull(GridView1.GetRowCellValue(e.RowHandle, "Precio"), 0) - (IsNull(GridView1.GetRowCellValue(e.RowHandle, "Cantidad"), 1) * IsNull(GridView1.GetRowCellValue(e.RowHandle, "Precio"), 0) * IsNull(GridView1.GetRowCellValue(e.RowHandle, "Descuento"), 0)))
            Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(GridView1.GetRowCellValue(e.RowHandle, "Item"))
            'Dim Config As New VB.SysContab.ConfiguracionDB
            'ConfigDetalles = New VB.SysContab.ConfiguracionDetails
            ConfigDetalles = Config.GetConfigDetails
            If DR.Item("Exento") = False Then
                GridView1.SetRowCellValue(e.RowHandle, "IVA", IsNull(GridView1.GetRowCellValue(e.RowHandle, "Total") * (ConfigDetalles.IVA / 100.0), 0))
            End If
        End If

        GridView1.UpdateTotalSummary()
    End Sub

    Sub CalcularTotales()
        Try
            lblsubtotal.Text = FormatNumber(GridView1.Columns("Total").SummaryItem.SummaryValue, 2)
            lbliva.Text = FormatNumber(GridView1.Columns("IVA").SummaryItem.SummaryValue, 2)
            lbltotal.Text = FormatNumber(CDbl(lblsubtotal.Text) + CDbl(lbliva.Text), 2)
            lblTotalU.Text = Math.Round(CDbl(lbltotal.Text) / TCambio, 2).ToString("n2")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dtpFecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.EditValueChanged
        If Inicio Then Exit Sub
        GetTasa()
        GetCodigoAlterno()
    End Sub

    Sub GetCodigoAlterno()
        If IdPedido = 0 Then txtNumeroAlterno.Text = txtPedido.EditValue.ToString.PadLeft(5, "0") + "-" + dtpFecha.DateTime.Date.Day.ToString + dtpFecha.DateTime.Date.Month.ToString + Mid(dtpFecha.DateTime.Date.Year.ToString, 4, 1).ToString
    End Sub

    Sub GetTasa()
        Try
            TCambio = ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo._TCambioDia(" & EmpresaActual & ", '" & dtpFecha.DateTime.Date & "') Tasa").Rows.Item(0)(0)
            etTasa.Text = TCambio.ToString("n4")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub cmbcentrocosto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcentrocosto.EditValueChanged

    End Sub

    Private Sub cbFormaPago_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFormaPago.EditValueChanged
        Try
            If Not cbFormaPago.EditValue Is Nothing Then
                dtpFechaEntrega.DateTime = dtpFecha.DateTime.AddDays(FormaPago.FormaPagoDias(cbFormaPago.EditValue))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbProveedor_EditValueChanged(sender As Object, e As EventArgs) Handles cbProveedor.EditValueChanged
        If Inicio Then Exit Sub

        If cbProveedor.EditValue Is Nothing Then
            Exit Sub
        End If

        If cbProveedor.EditValue Is Nothing Or IsNumeric(cbProveedor.EditValue) = False Then
            txtRuc.Text = ""
            txtDireccion.Text = ""
            txtTelefono.Text = ""
            txtDepartamento.Text = ""
            txtMunicipio.Text = ""
            Exit Sub
        End If

        DetallesProveedor = ProveedoresDB.GetDetails(cbProveedor.EditValue)

        Me.txtRuc.Text = DetallesProveedor.Ruc
        Me.txtDireccion.Text = DetallesProveedor.Direccion
        Me.txtTelefono.Text = DetallesProveedor.Telefono
        If IsNumeric(DetallesProveedor.Departamento) = True Then
            Try
                Me.txtDepartamento.Text = ObtieneDatos("SELECT Nombre_Departamento FROM DepartamentosC WHERE Codigo_Departamento = " & DetallesProveedor.Departamento & " AND Empresa = " & EmpresaActual).Rows.Item(0)("Nombre_Departamento").ToString
                Me.txtMunicipio.Text = ObtieneDatos("SELECT Nombre_Municipio FROM Municipios WHERE Codigo_Departamento = " & DetallesProveedor.Departamento & " AND Codigo_Municipio = " & DetallesProveedor.Municipio).Rows.Item(0)("Nombre_Municipio").ToString
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class

'End Namespace
