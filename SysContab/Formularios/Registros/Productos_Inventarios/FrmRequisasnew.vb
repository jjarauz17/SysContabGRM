Imports ClasesBLL
Imports System.Data.OleDb
Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class FrmRequisasnew
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmRequisasnew = Nothing

    Public Shared Function Instance() As FrmRequisasnew
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmRequisasnew
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents txtrealizado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbbodega As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbrequisa As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TipoServicio As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtrequisa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtfactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdactualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbMovimientos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCosto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtReferencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents etCuenta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FrmRequisasnewConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents lyImportar As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyRefrescar As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyGuardar As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents mConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTransporte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPlaca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtConductor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtRemision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtOtMatriz As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtOtSuc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbCliente As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoPoliza As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbProducto As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbProyectos As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents iVistaProyectos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbOrden As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rFactor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtRecibimosDe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbCentroCosto As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbProveedor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRequisasnew))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCosto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtrealizado = New DevExpress.XtraEditors.TextEdit()
        Me.FrmRequisasnewConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.cbProveedor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRecibimosDe = New DevExpress.XtraEditors.TextEdit()
        Me.cbOrden = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbProyectos = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.iVistaProyectos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCliente = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NoPoliza = New DevExpress.XtraEditors.TextEdit()
        Me.txtOtSuc = New DevExpress.XtraEditors.TextEdit()
        Me.txtOtMatriz = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemision = New DevExpress.XtraEditors.TextEdit()
        Me.txtConductor = New DevExpress.XtraEditors.TextEdit()
        Me.txtPlaca = New DevExpress.XtraEditors.TextEdit()
        Me.txtTransporte = New DevExpress.XtraEditors.TextEdit()
        Me.mConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdactualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtReferencia = New DevExpress.XtraEditors.TextEdit()
        Me.cbMovimientos = New DevExpress.XtraEditors.LookUpEdit()
        Me.TipoServicio = New DevExpress.XtraEditors.RadioGroup()
        Me.fecha = New DevExpress.XtraEditors.DateEdit()
        Me.cmbrequisa = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtrequisa = New DevExpress.XtraEditors.TextEdit()
        Me.etCuenta = New DevExpress.XtraEditors.LabelControl()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbProducto = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rFactor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbCentroCosto = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cmbbodega = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtfactura = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyImportar = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyRefrescar = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyGuardar = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrealizado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmRequisasnewConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmRequisasnewConvertedLayout.SuspendLayout()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRecibimosDe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProyectos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVistaProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoPoliza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtSuc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtMatriz.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConductor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransporte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoServicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbrequisa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrequisa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbbodega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyRefrescar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Existencia"
        Me.GridColumn3.ColumnEdit = Me.txtCosto
        Me.GridColumn3.DisplayFormat.FormatString = "{0:n4}"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Existencia"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 89
        '
        'txtCosto
        '
        Me.txtCosto.Appearance.Options.UseTextOptions = True
        Me.txtCosto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCosto.AutoHeight = False
        Me.txtCosto.Mask.EditMask = "n6"
        Me.txtCosto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCosto.Mask.UseMaskAsDisplayFormat = True
        Me.txtCosto.Name = "txtCosto"
        '
        'txtrealizado
        '
        Me.txtrealizado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtrealizado.Location = New System.Drawing.Point(813, 38)
        Me.txtrealizado.Name = "txtrealizado"
        Me.txtrealizado.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtrealizado.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrealizado.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtrealizado.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtrealizado.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtrealizado.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtrealizado.Properties.ReadOnly = True
        Me.txtrealizado.Size = New System.Drawing.Size(183, 20)
        Me.txtrealizado.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.txtrealizado.TabIndex = 6
        '
        'FrmRequisasnewConvertedLayout
        '
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.cbProveedor)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.SimpleButton3)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.txtRecibimosDe)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.cbOrden)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.cbProyectos)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.cbCliente)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.NoPoliza)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.txtOtSuc)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.txtOtMatriz)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.txtRemision)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.txtConductor)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.txtPlaca)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.txtTransporte)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.mConcepto)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.cmdsalir)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.cmdguardar)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.cmdactualizar)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.SimpleButton2)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.SimpleButton1)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.txtReferencia)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.cbMovimientos)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.TipoServicio)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.fecha)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.txtrealizado)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.cmbrequisa)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.txtrequisa)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.etCuenta)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.GridDetalle)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.cmbbodega)
        Me.FrmRequisasnewConvertedLayout.Controls.Add(Me.txtfactura)
        Me.FrmRequisasnewConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmRequisasnewConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.FrmRequisasnewConvertedLayout.Name = "FrmRequisasnewConvertedLayout"
        Me.FrmRequisasnewConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(813, 190, 250, 350)
        Me.FrmRequisasnewConvertedLayout.Root = Me.LayoutControlGroup1
        Me.FrmRequisasnewConvertedLayout.Size = New System.Drawing.Size(1008, 711)
        Me.FrmRequisasnewConvertedLayout.TabIndex = 12
        '
        'cbProveedor
        '
        Me.cbProveedor.Location = New System.Drawing.Point(126, 143)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.Properties.Appearance.Options.UseFont = True
        Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedor.Properties.PopupView = Me.GridView2
        Me.cbProveedor.Size = New System.Drawing.Size(601, 20)
        Me.cbProveedor.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.cbProveedor.TabIndex = 135
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Appearance.Options.UseTextOptions = True
        Me.SimpleButton3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(256, 661)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(113, 38)
        Me.SimpleButton3.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.SimpleButton3.TabIndex = 13
        Me.SimpleButton3.Text = "&Imprimir"
        '
        'txtRecibimosDe
        '
        Me.txtRecibimosDe.Location = New System.Drawing.Point(381, 38)
        Me.txtRecibimosDe.Name = "txtRecibimosDe"
        Me.txtRecibimosDe.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtRecibimosDe.Properties.Appearance.Options.UseFont = True
        Me.txtRecibimosDe.Properties.MaxLength = 50
        Me.txtRecibimosDe.Size = New System.Drawing.Size(314, 22)
        Me.txtRecibimosDe.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.txtRecibimosDe.TabIndex = 13
        '
        'cbOrden
        '
        Me.cbOrden.Location = New System.Drawing.Point(567, 64)
        Me.cbOrden.Name = "cbOrden"
        Me.cbOrden.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrden.Properties.Appearance.Options.UseFont = True
        Me.cbOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOrden.Properties.PopupView = Me.GridView3
        Me.cbOrden.Size = New System.Drawing.Size(128, 20)
        Me.cbOrden.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.cbOrden.TabIndex = 135
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'cbProyectos
        '
        Me.cbProyectos.Location = New System.Drawing.Point(126, 119)
        Me.cbProyectos.Name = "cbProyectos"
        Me.cbProyectos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProyectos.Properties.Appearance.Options.UseFont = True
        Me.cbProyectos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProyectos.Properties.PopupView = Me.iVistaProyectos
        Me.cbProyectos.Size = New System.Drawing.Size(376, 20)
        Me.cbProyectos.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.cbProyectos.TabIndex = 135
        '
        'iVistaProyectos
        '
        Me.iVistaProyectos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.iVistaProyectos.Name = "iVistaProyectos"
        Me.iVistaProyectos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.iVistaProyectos.OptionsView.ShowGroupPanel = False
        '
        'cbCliente
        '
        Me.cbCliente.Location = New System.Drawing.Point(620, 119)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCliente.Properties.Appearance.Options.UseFont = True
        Me.cbCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCliente.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cbCliente.Size = New System.Drawing.Size(376, 20)
        Me.cbCliente.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.cbCliente.TabIndex = 134
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'NoPoliza
        '
        Me.NoPoliza.Location = New System.Drawing.Point(845, 143)
        Me.NoPoliza.Name = "NoPoliza"
        Me.NoPoliza.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoPoliza.Properties.Appearance.Options.UseFont = True
        Me.NoPoliza.Size = New System.Drawing.Size(151, 20)
        Me.NoPoliza.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.NoPoliza.TabIndex = 132
        '
        'txtOtSuc
        '
        Me.txtOtSuc.Location = New System.Drawing.Point(763, 239)
        Me.txtOtSuc.Name = "txtOtSuc"
        Me.txtOtSuc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtSuc.Properties.Appearance.Options.UseFont = True
        Me.txtOtSuc.Size = New System.Drawing.Size(233, 20)
        Me.txtOtSuc.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.txtOtSuc.TabIndex = 133
        '
        'txtOtMatriz
        '
        Me.txtOtMatriz.Location = New System.Drawing.Point(452, 239)
        Me.txtOtMatriz.Name = "txtOtMatriz"
        Me.txtOtMatriz.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtMatriz.Properties.Appearance.Options.UseFont = True
        Me.txtOtMatriz.Size = New System.Drawing.Size(193, 20)
        Me.txtOtMatriz.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.txtOtMatriz.TabIndex = 132
        '
        'txtRemision
        '
        Me.txtRemision.Location = New System.Drawing.Point(126, 239)
        Me.txtRemision.Name = "txtRemision"
        Me.txtRemision.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemision.Properties.Appearance.Options.UseFont = True
        Me.txtRemision.Size = New System.Drawing.Size(208, 20)
        Me.txtRemision.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.txtRemision.TabIndex = 131
        '
        'txtConductor
        '
        Me.txtConductor.Location = New System.Drawing.Point(654, 215)
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConductor.Properties.Appearance.Options.UseFont = True
        Me.txtConductor.Size = New System.Drawing.Size(342, 20)
        Me.txtConductor.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.txtConductor.TabIndex = 131
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(654, 191)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.Properties.Appearance.Options.UseFont = True
        Me.txtPlaca.Size = New System.Drawing.Size(342, 20)
        Me.txtPlaca.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.txtPlaca.TabIndex = 131
        '
        'txtTransporte
        '
        Me.txtTransporte.Location = New System.Drawing.Point(654, 167)
        Me.txtTransporte.Name = "txtTransporte"
        Me.txtTransporte.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransporte.Properties.Appearance.Options.UseFont = True
        Me.txtTransporte.Size = New System.Drawing.Size(342, 20)
        Me.txtTransporte.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.txtTransporte.TabIndex = 130
        '
        'mConcepto
        '
        Me.mConcepto.Location = New System.Drawing.Point(126, 167)
        Me.mConcepto.Name = "mConcepto"
        Me.mConcepto.Size = New System.Drawing.Size(410, 68)
        Me.mConcepto.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.mConcepto.TabIndex = 12
        '
        'cmdsalir
        '
        Me.cmdsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdsalir.Appearance.Options.UseTextOptions = True
        Me.cmdsalir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdsalir.ImageOptions.Image = CType(resources.GetObject("cmdsalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(902, 661)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(94, 38)
        Me.cmdsalir.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.cmdsalir.TabIndex = 3
        Me.cmdsalir.Text = "&Salir"
        '
        'cmdguardar
        '
        Me.cmdguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdguardar.Appearance.Options.UseTextOptions = True
        Me.cmdguardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdguardar.ImageOptions.Image = CType(resources.GetObject("cmdguardar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdguardar.Location = New System.Drawing.Point(780, 661)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(118, 38)
        Me.cmdguardar.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.cmdguardar.TabIndex = 2
        Me.cmdguardar.Text = "&Guardar"
        '
        'cmdactualizar
        '
        Me.cmdactualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdactualizar.Appearance.Options.UseTextOptions = True
        Me.cmdactualizar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdactualizar.ImageOptions.Image = CType(resources.GetObject("cmdactualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdactualizar.Location = New System.Drawing.Point(645, 661)
        Me.cmdactualizar.Name = "cmdactualizar"
        Me.cmdactualizar.Size = New System.Drawing.Size(131, 38)
        Me.cmdactualizar.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.cmdactualizar.TabIndex = 1
        Me.cmdactualizar.Text = "&Refrescar Datos"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Options.UseTextOptions = True
        Me.SimpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(515, 661)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(126, 38)
        Me.SimpleButton2.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "&Exportar Datos"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Options.UseTextOptions = True
        Me.SimpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(373, 661)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(138, 38)
        Me.SimpleButton1.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Importar de Excel"
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(381, 12)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtReferencia.Properties.Appearance.Options.UseFont = True
        Me.txtReferencia.Properties.MaxLength = 50
        Me.txtReferencia.Size = New System.Drawing.Size(301, 22)
        Me.txtReferencia.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.txtReferencia.TabIndex = 1
        '
        'cbMovimientos
        '
        Me.cbMovimientos.Location = New System.Drawing.Point(126, 90)
        Me.cbMovimientos.Name = "cbMovimientos"
        Me.cbMovimientos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMovimientos.Properties.Appearance.Options.UseFont = True
        EditorButtonImageOptions1.EnableTransparency = False
        EditorButtonImageOptions2.EnableTransparency = False
        EditorButtonImageOptions3.EnableTransparency = False
        Me.cbMovimientos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "Borrar Datos", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "Editar/Cambiar  Datos", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "Agregar Nuevo Movimiento", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.cbMovimientos.Properties.NullText = ""
        Me.cbMovimientos.Properties.ShowFooter = False
        Me.cbMovimientos.Size = New System.Drawing.Size(531, 20)
        Me.cbMovimientos.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.cbMovimientos.TabIndex = 3
        '
        'TipoServicio
        '
        Me.TipoServicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoServicio.Location = New System.Drawing.Point(697, 90)
        Me.TipoServicio.Name = "TipoServicio"
        Me.TipoServicio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TipoServicio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TipoServicio.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.TipoServicio.Properties.Appearance.Options.UseBackColor = True
        Me.TipoServicio.Properties.Appearance.Options.UseFont = True
        Me.TipoServicio.Properties.Appearance.Options.UseForeColor = True
        Me.TipoServicio.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TipoServicio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Productos"), New DevExpress.XtraEditors.Controls.RadioGroupItem("I", "Inventario Interno")})
        Me.TipoServicio.Size = New System.Drawing.Size(299, 25)
        Me.TipoServicio.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.TipoServicio.TabIndex = 8
        '
        'fecha
        '
        Me.fecha.EditValue = Nothing
        Me.fecha.Location = New System.Drawing.Point(126, 12)
        Me.fecha.Name = "fecha"
        Me.fecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Properties.Appearance.Options.UseFont = True
        Me.fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fecha.Size = New System.Drawing.Size(137, 22)
        Me.fecha.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.fecha.TabIndex = 0
        '
        'cmbrequisa
        '
        Me.cmbrequisa.Location = New System.Drawing.Point(126, 38)
        Me.cmbrequisa.Name = "cmbrequisa"
        Me.cmbrequisa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbrequisa.Properties.Appearance.Options.UseFont = True
        Me.cmbrequisa.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.cmbrequisa.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.cmbrequisa.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmbrequisa.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmbrequisa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbrequisa.Properties.NullText = ""
        Me.cmbrequisa.Properties.ShowFooter = False
        Me.cmbrequisa.Properties.ShowHeader = False
        Me.cmbrequisa.Properties.ShowLines = False
        Me.cmbrequisa.Size = New System.Drawing.Size(137, 20)
        Me.cmbrequisa.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.cmbrequisa.TabIndex = 2
        '
        'txtrequisa
        '
        Me.txtrequisa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtrequisa.Location = New System.Drawing.Point(813, 12)
        Me.txtrequisa.Name = "txtrequisa"
        Me.txtrequisa.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtrequisa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrequisa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtrequisa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtrequisa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtrequisa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtrequisa.Properties.ReadOnly = True
        Me.txtrequisa.Size = New System.Drawing.Size(183, 22)
        Me.txtrequisa.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.txtrequisa.TabIndex = 5
        '
        'etCuenta
        '
        Me.etCuenta.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCuenta.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.etCuenta.Appearance.Options.UseFont = True
        Me.etCuenta.Appearance.Options.UseForeColor = True
        Me.etCuenta.Location = New System.Drawing.Point(661, 90)
        Me.etCuenta.Name = "etCuenta"
        Me.etCuenta.Size = New System.Drawing.Size(32, 16)
        Me.etCuenta.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.etCuenta.TabIndex = 11
        Me.etCuenta.Text = "****"
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(12, 263)
        Me.GridDetalle.MainView = Me.vDatos
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtCosto, Me.txtCantidad, Me.cbCatalogo, Me.cbProducto, Me.rFactor, Me.cbCentroCosto})
        Me.GridDetalle.Size = New System.Drawing.Size(984, 394)
        Me.GridDetalle.TabIndex = 9
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vDatos.Appearance.HeaderPanel.Options.UseFont = True
        Me.vDatos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.vDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.vDatos.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.vDatos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn7, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn2, Me.GridColumn8})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Salmon
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Salmon
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.GridColumn3
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = 0
        StyleFormatCondition1.Value2 = 0
        Me.vDatos.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.vDatos.GridControl = Me.GridDetalle
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Producto"
        Me.GridColumn1.ColumnEdit = Me.cbProducto
        Me.GridColumn1.FieldName = "Codigo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 280
        '
        'cbProducto
        '
        Me.cbProducto.AutoHeight = False
        Me.cbProducto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.NullText = "[Agregar Producto]"
        Me.cbProducto.PopupView = Me.GridView1
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Cuenta"
        Me.GridColumn7.ColumnEdit = Me.cbCatalogo
        Me.GridColumn7.FieldName = "Cuenta"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 123
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.Caption = "Cantidad a Ingresar"
        Me.GridColumn4.ColumnEdit = Me.txtCantidad
        Me.GridColumn4.FieldName = "Cantidad"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", "{0:n4}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 7
        Me.GridColumn4.Width = 87
        '
        'txtCantidad
        '
        Me.txtCantidad.AutoHeight = False
        Me.txtCantidad.Mask.EditMask = "n4"
        Me.txtCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidad.Name = "txtCantidad"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Costo"
        Me.GridColumn5.ColumnEdit = Me.txtCosto
        Me.GridColumn5.FieldName = "Costo"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 86
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "U/M"
        Me.GridColumn6.FieldName = "Unidad"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.AllowFocus = False
        Me.GridColumn6.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 81
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Factor"
        Me.GridColumn2.ColumnEdit = Me.rFactor
        Me.GridColumn2.FieldName = "Factor"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 6
        Me.GridColumn2.Width = 86
        '
        'rFactor
        '
        Me.rFactor.Appearance.Options.UseTextOptions = True
        Me.rFactor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rFactor.AutoHeight = False
        Me.rFactor.Mask.EditMask = "n6"
        Me.rFactor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.rFactor.Mask.UseMaskAsDisplayFormat = True
        Me.rFactor.Name = "rFactor"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Centro de Costo"
        Me.GridColumn8.ColumnEdit = Me.cbCentroCosto
        Me.GridColumn8.FieldName = "IdCentro"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        Me.GridColumn8.Width = 134
        '
        'cbCentroCosto
        '
        Me.cbCentroCosto.AutoHeight = False
        Me.cbCentroCosto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentroCosto.Name = "cbCentroCosto"
        '
        'cmbbodega
        '
        Me.cmbbodega.Location = New System.Drawing.Point(126, 64)
        Me.cmbbodega.Name = "cmbbodega"
        Me.cmbbodega.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbodega.Properties.Appearance.Options.UseFont = True
        Me.cmbbodega.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info
        Me.cmbbodega.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbodega.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkRed
        Me.cmbbodega.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmbbodega.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cmbbodega.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmbbodega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbbodega.Properties.NullText = ""
        Me.cmbbodega.Properties.ShowFooter = False
        Me.cmbbodega.Properties.ShowHeader = False
        Me.cmbbodega.Properties.ShowLines = False
        Me.cmbbodega.Size = New System.Drawing.Size(323, 20)
        Me.cmbbodega.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.cmbbodega.TabIndex = 4
        '
        'txtfactura
        '
        Me.txtfactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfactura.Location = New System.Drawing.Point(813, 64)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtfactura.Properties.Appearance.Options.UseFont = True
        Me.txtfactura.Size = New System.Drawing.Size(183, 22)
        Me.txtfactura.StyleController = Me.FrmRequisasnewConvertedLayout
        Me.txtfactura.TabIndex = 7
        Me.txtfactura.Visible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem12, Me.lyImportar, Me.LayoutControlItem14, Me.lyRefrescar, Me.lyGuardar, Me.LayoutControlItem17, Me.EmptySpaceItem3, Me.EmptySpaceItem2, Me.LayoutControlItem1, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem11, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem9, Me.LayoutControlItem18, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem13})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1008, 711)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtReferencia
        Me.LayoutControlItem2.CustomizationFormText = "Referencia :"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(255, 0)
        Me.LayoutControlItem2.Name = "txtReferenciaitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(419, 26)
        Me.LayoutControlItem2.Text = "Referencia :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.fecha
        Me.LayoutControlItem5.CustomizationFormText = "Fecha :"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(255, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(255, 26)
        Me.LayoutControlItem5.Name = "fechaitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(255, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Fecha :"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtrealizado
        Me.LayoutControlItem6.CustomizationFormText = "Realizado por :"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(687, 26)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(301, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(301, 24)
        Me.LayoutControlItem6.Name = "txtrealizadoitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(301, 26)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Realizado por :"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmbrequisa
        Me.LayoutControlItem7.CustomizationFormText = "Tipo:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(255, 26)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(255, 26)
        Me.LayoutControlItem7.Name = "cmbrequisaitem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(255, 26)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Tipo:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtrequisa
        Me.LayoutControlItem8.CustomizationFormText = "# Movimiento :"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(687, 0)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(301, 26)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(301, 26)
        Me.LayoutControlItem8.Name = "txtrequisaitem"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(301, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "# Movimiento :"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.GridDetalle
        Me.LayoutControlItem10.CustomizationFormText = "GridDetalleitem"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 251)
        Me.LayoutControlItem10.Name = "GridDetalleitem"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(988, 398)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtfactura
        Me.LayoutControlItem12.CustomizationFormText = "# Factura :"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(687, 52)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(301, 26)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(301, 26)
        Me.LayoutControlItem12.Name = "txtfacturaitem"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(301, 26)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.Text = "# Factura :"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(111, 13)
        '
        'lyImportar
        '
        Me.lyImportar.Control = Me.SimpleButton1
        Me.lyImportar.CustomizationFormText = "LayoutControlItem13"
        Me.lyImportar.Location = New System.Drawing.Point(361, 649)
        Me.lyImportar.MaxSize = New System.Drawing.Size(142, 42)
        Me.lyImportar.MinSize = New System.Drawing.Size(142, 42)
        Me.lyImportar.Name = "lyImportar"
        Me.lyImportar.Size = New System.Drawing.Size(142, 42)
        Me.lyImportar.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyImportar.TextSize = New System.Drawing.Size(0, 0)
        Me.lyImportar.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.SimpleButton2
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(503, 649)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(130, 42)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(130, 42)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(130, 42)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'lyRefrescar
        '
        Me.lyRefrescar.Control = Me.cmdactualizar
        Me.lyRefrescar.CustomizationFormText = "LayoutControlItem15"
        Me.lyRefrescar.Location = New System.Drawing.Point(633, 649)
        Me.lyRefrescar.MaxSize = New System.Drawing.Size(135, 42)
        Me.lyRefrescar.MinSize = New System.Drawing.Size(135, 42)
        Me.lyRefrescar.Name = "lyRefrescar"
        Me.lyRefrescar.Size = New System.Drawing.Size(135, 42)
        Me.lyRefrescar.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyRefrescar.TextSize = New System.Drawing.Size(0, 0)
        Me.lyRefrescar.TextVisible = False
        '
        'lyGuardar
        '
        Me.lyGuardar.Control = Me.cmdguardar
        Me.lyGuardar.CustomizationFormText = "LayoutControlItem16"
        Me.lyGuardar.Location = New System.Drawing.Point(768, 649)
        Me.lyGuardar.MaxSize = New System.Drawing.Size(122, 42)
        Me.lyGuardar.MinSize = New System.Drawing.Size(122, 42)
        Me.lyGuardar.Name = "lyGuardar"
        Me.lyGuardar.Size = New System.Drawing.Size(122, 42)
        Me.lyGuardar.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyGuardar.TextSize = New System.Drawing.Size(0, 0)
        Me.lyGuardar.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cmdsalir
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(890, 649)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(98, 42)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 649)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(244, 42)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(674, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(13, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.mConcepto
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 155)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(0, 72)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(112, 72)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(528, 72)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Concepto:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtPlaca
        Me.LayoutControlItem19.Location = New System.Drawing.Point(528, 179)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(460, 24)
        Me.LayoutControlItem19.Text = "No. Placa:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtConductor
        Me.LayoutControlItem20.Location = New System.Drawing.Point(528, 203)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(460, 24)
        Me.LayoutControlItem20.Text = "Conductor:"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmbbodega
        Me.LayoutControlItem11.CustomizationFormText = "Bodega:"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem11.Name = "cmbbodegaitem"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(441, 26)
        Me.LayoutControlItem11.Text = "Bodega:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TipoServicio
        Me.LayoutControlItem4.CustomizationFormText = "# Factura :"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(685, 78)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(303, 29)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(303, 29)
        Me.LayoutControlItem4.Name = "TipoServicioitem"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(303, 29)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "# Factura :"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbMovimientos
        Me.LayoutControlItem3.CustomizationFormText = "Movimiento:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem3.Name = "cbMovimientositem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(649, 29)
        Me.LayoutControlItem3.Text = "Movimiento:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.etCuenta
        Me.LayoutControlItem9.CustomizationFormText = "etCuentaitem"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(649, 78)
        Me.LayoutControlItem9.Name = "etCuentaitem"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(36, 29)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtTransporte
        Me.LayoutControlItem18.Location = New System.Drawing.Point(528, 155)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(460, 24)
        Me.LayoutControlItem18.Text = "Tipo de Transporte:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtRemision
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 227)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(326, 24)
        Me.LayoutControlItem21.Text = "#Remisión:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtOtMatriz
        Me.LayoutControlItem22.Location = New System.Drawing.Point(326, 227)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(311, 24)
        Me.LayoutControlItem22.Text = "#O. Entrega C. Matriz:"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtOtSuc
        Me.LayoutControlItem23.Location = New System.Drawing.Point(637, 227)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(351, 24)
        Me.LayoutControlItem23.Text = "#O. Entrega Sucursal:"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cbCliente
        Me.LayoutControlItem15.Location = New System.Drawing.Point(494, 107)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(494, 24)
        Me.LayoutControlItem15.Text = "Cliente:"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cbProyectos
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 107)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(494, 24)
        Me.LayoutControlItem16.Text = "Proyecto:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.cbOrden
        Me.LayoutControlItem24.Location = New System.Drawing.Point(441, 52)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(246, 26)
        Me.LayoutControlItem24.Text = "Orden Trabajo:"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtRecibimosDe
        Me.LayoutControlItem25.Location = New System.Drawing.Point(255, 26)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(432, 26)
        Me.LayoutControlItem25.Text = "Recibimos de:"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.SimpleButton3
        Me.LayoutControlItem26.Location = New System.Drawing.Point(244, 649)
        Me.LayoutControlItem26.MaxSize = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem26.MinSize = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.cbProveedor
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 131)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(719, 24)
        Me.LayoutControlItem27.Text = "Proveedor:"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.NoPoliza
        Me.LayoutControlItem13.Location = New System.Drawing.Point(719, 131)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(269, 24)
        Me.LayoutControlItem13.Text = "No. Poliza:"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(111, 13)
        '
        'FrmRequisasnew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 711)
        Me.Controls.Add(Me.FrmRequisasnewConvertedLayout)
        Me.Name = "FrmRequisasnew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requisas de Bodega"
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrealizado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmRequisasnewConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmRequisasnewConvertedLayout.ResumeLayout(False)
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRecibimosDe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProyectos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVistaProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoPoliza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtSuc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtMatriz.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConductor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransporte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoServicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbrequisa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrequisa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbbodega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyRefrescar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Data As DataTable = New DataTable("Requisa")
    Public IdRequisa As Integer = 0
    Private Temp As Boolean = False
    Public DT_ROL As DataTable
    Private Save As Boolean = False

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub FrmRequisasnew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetBodegasxUsuario(cmbbodega, 0)
        'GetBodegasList(cmbbodega)
        GetTipoMovimientos(cbMovimientos, IIf(IdRequisa = 0, 1, 0))

        'cmbrequisa.Properties.DataSource = ObtieneDatos("SELECT 'Entrada' AS Nombre,1 AS Codigo UNION ALL SELECT 'Salida' AS Nombre,2 AS Codigo")
        'cmbrequisa.Properties.PopulateColumns()
        'cmbrequisa.Properties.DisplayMember = "Nombre"
        'cmbrequisa.Properties.ValueMember = "Codigo"
        'cmbrequisa.Properties.Columns(1).Visible = False

        LookUp(cmbrequisa, ObtieneDatos("sp_sel_TipoRequisa", EmpresaActual), "Nombre", "Codigo", "[Seleccione]", 0)

        SearchLookUp(cbCliente, ObtieneDatos("JAR_GetClientes", EmpresaActual), "Nombre", "Codigo")
        cbCliente.EditValue = 0
        '
        SearchLookUp(cbProveedor, ObtieneDatos("sp_sel_Proveedores", EmpresaActual, 1), "NOMBRE", "CODIGO")
        cbProveedor.EditValue = 0

        SearchLookUp(cbOrden, ObtieneDatos("sp_Get_OrdenesTrabajo", EmpresaActual), "Numero", "IdOrden", 0)
        '
        GetCentrosCostosList(cbCentroCosto)
        '
        CargarCatalogo()
        SearchLookUp(
            cbProyectos,
            db_Proyectos.Fill(IIf(IdRequisa = 0, 1, 0)),
            "Nombre",
            "IdProyecto", 0, 6, 7, 8)
        cbProyectos.EditValue = 0

        GetData()

        VB.SysContab.Rutinas.Fecha()
    End Sub

    Sub CargarCatalogo()

        RepositorySearchLook(cbCatalogo, ObtieneDatos("_GetCatalogo_Cuenta", EmpresaActual), "Display", "Cuenta", 2)

        'Me.cbCatalogo.DataSource = ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual).DefaultView
        'Me.cbCatalogo.ValueMember = "Cuenta"
        'Me.cbCatalogo.DisplayMember = "Display"
        'cbCatalogo.PopulateViewColumns()
        ''Me.vCatalogo.PopulateColumns()
        'FormatoGrid(Me.vCatalogo)
        'Me.vCatalogo.Columns("Display").Visible = False
        'Me.vCatalogo.Columns("Cuenta").VisibleIndex = 0
        'Me.vCatalogo.Columns("Nombre").VisibleIndex = 1
        'Me.vCatalogo.Columns("NombreCompleto").VisibleIndex = 2
        'Me.vCatalogo.BestFitColumns()
    End Sub

    Private Sub GetData()

        If IdRequisa = 0 Then
            Me.txtrealizado.Text = Usuario
            Me.txtrequisa.Text = VB.SysContab.RequisasDB.GetCodigoNuevo()
            Me.cbMovimientos.ItemIndex = 0
            Me.cmbbodega.ItemIndex = 0
            Me.TipoServicio.EditValue = "P"
            Me.cmbrequisa.ItemIndex = 0
            Me.fecha.EditValue = Now.Date
        Else

            Me.TipoServicio.Enabled = False
            'Me.cmbbodega.Enabled = False
            Me.cmbrequisa.Enabled = False
            Me.txtrequisa.Text = IdRequisa

            Dim DT As DataTable = ObtieneDatos("SPGetRequisasEditar", IdRequisa, EmpresaActual)

            TipoServicio.EditValue = IsNull(DT.Rows(0)("tipo_articulo"), "P")
            cmbbodega.EditValue = DT.Rows(0)("codigo_bodega")
            cmbrequisa.EditValue = IIf(DT.Rows(0)("req_tipo") = "E", 1, 2)
            cbMovimientos.EditValue = DT.Rows(0)("Movimiento_ID")
            fecha.EditValue = DT.Rows(0)("req_fecha")
            txtrealizado.Text = DT.Rows(0)("req_realizadopor")
            txtReferencia.Text = DT.Rows(0)("Referencia")
            txtfactura.Text = DT.Rows(0)("Factura")
            mConcepto.Text = DT.Rows(0)("Concepto")
            txtTransporte.Text = DT.Rows(0)("Transporte")
            txtPlaca.Text = DT.Rows(0)("NoPlaca")
            txtConductor.Text = DT.Rows(0)("Conductor")
            txtRemision.Text = DT.Rows(0)("Remision")
            txtOtMatriz.Text = DT.Rows(0)("OT_Matriz")
            txtOtSuc.Text = DT.Rows(0)("OT_Suc")
            cbCliente.EditValue = DT.Rows(0)("IdCliente")
            NoPoliza.Text = DT.Rows(0)("NoPoliza")
            cbProyectos.EditValue = DT.Rows(0)("IdProyecto")
            cbOrden.EditValue = DT.Rows(0)("IdOrden")
            txtRecibimosDe.Text = DT.Rows(0)("RecibimosDe")
            cbProveedor.EditValue = DT.Rows(0)("IdProveedor")

            'If cmbrequisa.EditValue = 2 Then Me.cmbbodega.Enabled = False
            'If cmbrequisa.EditValue = 1 Then Me.cmbbodega.Enabled = True
            '
            'If DT.Rows(0)("Procesado") Or DT.Rows(0)("req_contabilizada") Then
            '    'Me.cmdguardar.Enabled = False
            '    'Me.cmbbodega.Enabled = False

            '    FrmRequisasnewConvertedLayout.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True
            'End If
            '
            'If cbMovimientos.GetColumnValue("Clase") = "M" Then cbMovimientos.Properties.ReadOnly = True
            'If cbMovimientos.GetColumnValue("Clase") = "M" Then vDatos.OptionsBehavior.Editable = False
            'If cbMovimientos.GetColumnValue("Clase") = "M" Then cmbbodega.Enabled = False


            If DT.Rows(0)("req_contabilizada") Then
                cmdguardar.Enabled = True
                vDatos.OptionsBehavior.Editable = False
                If cbMovimientos.GetColumnValue("Clase") = "M" Then cbMovimientos.Properties.ReadOnly = True
            End If
            '
            If DT.Rows(0)("Procesado") Then
                cmdguardar.Enabled = False
                vDatos.OptionsBehavior.Editable = False
            End If
            '
            If cbMovimientos.GetColumnValue("Clase") <> "M" Then GetTipoMovimientos(Me.cbMovimientos, 1)
            'If cbProyectos.EditValue <> 0 Then cbProyectos.Properties.ReadOnly = True

            'Validar si se pueden Guardar los Traslados
            If DT_ROL.Rows.Count > 0 Then
                Dim dr() As DataRow = DT_ROL.Select("Control = 'Traslados'")

                If dr.Length = 0 Then
                    If cbMovimientos.GetColumnValue("Clase") = "M" Then
                        vDatos.OptionsBehavior.Editable = False
                        cbMovimientos.Properties.ReadOnly = True
                    End If
                Else
                    If cbMovimientos.GetColumnValue("Clase") = "M" Then
                        vDatos.OptionsBehavior.Editable = True
                        cbMovimientos.Properties.ReadOnly = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmbrequisa_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbrequisa.EditValueChanged
        txtfactura.Text = vbNullString

        If sender.editvalue = 1 Then
            'txtfactura.Visible = True
            'LabelControl6.Visible = True

            Me.vDatos.OptionsView.ShowAutoFilterRow = False
        Else
            'txtfactura.Visible = False
            'LabelControl6.Visible = False

            Me.vDatos.OptionsView.ShowAutoFilterRow = False
        End If

        BuscarArticulos()
    End Sub

    Private Sub cmbbodega_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbodega.EditValueChanged
        'Solo Cuando es Nuevo
        If IdRequisa = 0 Then BuscarArticulos()
    End Sub

    Private Sub BuscarArticulos()

        If cmbrequisa.EditValue Is Nothing Then Exit Sub

        If cmbrequisa.EditValue = 2 Then    '' Salida

            Data = ObtieneDatos("SP_GetBodegasArticulos2", EmpresaActual, cmbbodega.EditValue, TipoServicio.EditValue, 0, IdRequisa)
            GridDetalle.DataSource = Data

            'vDatos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            'For i As Integer = 0 To GridView1.Columns.Count - 2
            '    GridView1.Columns(i).OptionsColumn.AllowEdit = False
            '    'GridView1.Columns(i).OptionsColumn.ReadOnly = True
            '    GridView1.Columns(i).OptionsColumn.AllowFocus = False
            'Next

            vDatos.Columns("Cantidad").Caption = "Cantidad a Retirar"
        Else    '' Entrada
            Data = ObtieneDatos("SP_GetBodegasArticulos2", EmpresaActual, cmbbodega.EditValue, TipoServicio.EditValue, 1, IdRequisa)
            GridDetalle.DataSource = Data
            ' vDatos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            'GridView1.Columns("Existencia").OptionsColumn.AllowEdit = False
            'GridView1.Columns("Existencia").OptionsColumn.ReadOnly = True
            'GridView1.Columns("Existencia").OptionsColumn.AllowFocus = False
            vDatos.Columns("Cantidad").Caption = "Cantidad a Ingresar"
        End If

        'Dim Config As New VB.SysContab.ConfiguracionDB
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails

        Me.txtCosto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCosto.Mask.EditMask = "n" + ConfigDetalles.Decimales.ToString

        Me.vDatos.Columns("Costo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Costo").SummaryItem.DisplayFormat = "{0:n" + ConfigDetalles.Decimales.ToString & "}"
    End Sub

    Private Sub TipoServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoServicio.SelectedIndexChanged
        ListaArticulos()
        BuscarArticulos()
    End Sub

    Private Sub ListaArticulos()
        RepositorySearchLook(cbProducto, ObtieneDatos("SP_GetArticulo", EmpresaActual, TipoServicio.EditValue), "Display", "Codigo", 5)

        'Dim DTP As DataTable
        'DTP = ObtieneDatos("SP_GetArticulo " & EmpresaActual & ",'" & TipoServicio.EditValue & "'")
        'ItemProducto.DataSource = DTP
        'ItemProducto.DisplayMember = "Codigo"
        'ItemProducto.ValueMember = "Codigo"
        'ItemProducto.PopulateColumns()
        'ItemProductoD.DataSource = DTP
        'ItemProductoD.DisplayMember = "Nombre"
        'ItemProductoD.ValueMember = "Codigo"
        'ItemProductoD.PopulateColumns()
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vDatos.CellValueChanged
        If e.Column.FieldName = "Codigo" Then

            Dim DR As DataRowView = cbProducto.GetRowByKeyValue(e.Value)

            If Data.Compute("Count(Codigo)", "Codigo = '" & e.Value & "'") >= 1 Then 'And cmbrequisa.Text.ToString.Substring(0, 1) = "E" Then
                XtraMsg("Ya existe este producto en la lista", MessageBoxIcon.Warning)
                vDatos.DeleteRow(vDatos.FocusedRowHandle)
            End If

            Try
                'vDatos.SetRowCellValue(e.RowHandle, "Existencia", ObtieneDatos("SELECT ISNULL(SUM(Existencia),0) FROM Bodegas_Articulos WHERE Empresa = " & EmpresaActual & " AND Codigo_Bodega = '" & cmbbodega.EditValue & "' AND Codigo_Articulo = '" & e.Value & "'").Rows(0).Item(0))
                'vDatos.SetRowCellValue(e.RowHandle, "Costo", ObtieneDatos("SELECT isnull(costo,0) FROM Bodegas_Articulos WHERE Empresa = " & EmpresaActual & " AND Codigo_Bodega = '" & cmbbodega.EditValue & "' AND Codigo_Articulo = '" & e.Value & "'").Rows(0).Item(0))
                'vDatos.SetRowCellValue(e.RowHandle, "Existencia", ObtieneDatos("SELECT dbo.fn_CalcularExistenciaReal('" & cmbbodega.EditValue & "','" & e.Value & "'," & EmpresaActual & ") Existencia").Rows(0).Item(0))
                'vDatos.SetRowCellValue(e.RowHandle, "Costo", ObtieneDatos("SELECT isnull(ba.Costo_Prom,0.00) FROM Bodegas_Articulos ba WHERE Empresa = " & EmpresaActual & " AND Codigo_Bodega = '" & cmbbodega.EditValue & "' AND Codigo_Articulo = '" & e.Value & "'").Rows(0).Item(0))

                Dim DT_PROD As DataTable =
                    ObtieneDatos("JAR_GetProductoExistencia", e.Value, cmbbodega.EditValue, EmpresaActual)

                If DT_PROD.Rows.Count > 0 Then
                    vDatos.SetRowCellValue(e.RowHandle, "Existencia", DT_PROD.Rows.Item(0)("Existencia"))
                    vDatos.SetRowCellValue(e.RowHandle, "Costo", DT_PROD.Rows.Item(0)("Costo"))
                    vDatos.SetRowCellValue(e.RowHandle, "Cantidad", 1.0)
                End If

                vDatos.SetRowCellValue(e.RowHandle, "Cuenta", cbMovimientos.GetColumnValue("Cuenta"))
                vDatos.SetRowCellValue(e.RowHandle, "Unidad", DR.Item("Unidad"))
                vDatos.SetRowCellValue(e.RowHandle, "Factor", DR.Item("Factor"))

            Catch ex As Exception
                vDatos.SetRowCellValue(e.RowHandle, "Existencia", 0.00)
                vDatos.SetRowCellValue(e.RowHandle, "Costo", 0.00)
                vDatos.SetRowCellValue(e.RowHandle, "Cuenta", "")
                vDatos.SetRowCellValue(e.RowHandle, "Unidad", "")
                vDatos.SetRowCellValue(e.RowHandle, "Factor", 1.0)
            End Try

            ''Me.vDatos.Columns("Codigo").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default
            'Data.DefaultView.RowFilter = ""
        End If

        'If e.Column.FieldName = "Cantidad" And cmbrequisa.Text.ToString.Substring(0, 1) = "S" And Not Temp Then
        '    If e.Value > GridView1.GetRowCellValue(e.RowHandle, "Existencia") Then
        '        Temp = True
        '        GridView1.SetRowCellValue(e.RowHandle, "Cantidad", 0)
        '        Temp = False
        '        XtraMsg("No puede sacar mas de lo que hay en existencias", MessageBoxIcon.Error)
        '        SendKeys.Send("{ESC}")
        '        Exit Sub
        '    End If
        'End If
    End Sub

    Private Sub vDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles vDatos.KeyDown
        If vDatos.FocusedRowHandle < 0 Then Exit Sub

        If e.KeyCode = Keys.Delete Then
            vDatos.DeleteSelectedRows()
            vDatos.RefreshData()
        End If
    End Sub

    Private Sub vDatos_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles vDatos.RowUpdated
        'Me.vDatos.Columns("Codigo").OptionsFilter.Reset()
        'Me.vDatos.OptionsFilter.Reset()
        'Data.DefaultView.RowFilter = ""
    End Sub

    Private Sub vDatos_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles vDatos.ValidateRow
        ''If IsDBNull(vDatos.GetRowCellValue(e.RowHandle, "Codigo")) Or (IsDBNull(vDatos.GetRowCellValue(e.RowHandle, "Cantidad")) OrElse vDatos.GetRowCellValue(e.RowHandle, "Cantidad") = Nothing OrElse vDatos.GetRowCellValue(e.RowHandle, "Cantidad") < 0) Then
        If IsDBNull(vDatos.GetRowCellValue(e.RowHandle, "Codigo")) Or (IsDBNull(vDatos.GetRowCellValue(e.RowHandle, "Cantidad"))) Then
            e.ErrorText = "Complete la informacion" & vbCrLf
            e.Valid = False
        End If
    End Sub

    'Function MovimientoCuenta() As String
    '    Return ObtieneDatos("SELECT isnull(max(tm.Cuenta),'') Cuenta FROM TipoMovimientos tm WHERE tm.ID =" & Me.cbMovimientos.EditValue).Rows.Item(0)("Cuenta")
    'End Function

    Private Sub cmdguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdguardar.Click
        Dim Factor As Integer = 0

        'Verificar Cierre del Día
        '*******************************************************************************************
        If Not VerificarCierre(fecha.DateTime.Date) Then
            Exit Sub
        End If
        '*******************************************************************************************
        '*******************************************************************************************
        ' Validar Cierre de Inventario
        If Not VerificarCierre_Inventario(fecha.DateTime.Date) Then
            Exit Sub
        End If
        '*******************************************************************************************
        '
        If cmbbodega.EditValue = Nothing Or cmbrequisa.EditValue = Nothing Or txtrequisa.Text = Nothing Then
            XtraMsg("Complete la informacion")
            Exit Sub
        End If
        '
        If Me.cbMovimientos.EditValue = 0 Or Me.cbMovimientos.EditValue Is Nothing Then
            XtraMsg("Seleccione el Tipo de Movimiento a Realizar")
            Me.cbMovimientos.Focus()
            Exit Sub
        End If
        '
        If vDatos.DataRowCount = 0 Then
            XtraMsg("No hay registro a procesar")
            Exit Sub
        End If
        '
        If mConcepto.Text.Trim.Length = 0 Then
            XtraMsg("Describa el Concepto del Movimiento")
            mConcepto.Focus()
            Exit Sub
        End If
        '
        'Si es Saida, Verificar si tiene asignado un proyecto
        If IdRequisa = 0 Then
            If cmbrequisa.EditValue = 2 Then
                If cbProyectos.EditValue <> 0 Then
                    If Not XtraMsg2("Estos productos se Cargarán al Proyecto : " & cbProyectos.Text & vbCrLf &
                                "Está Seguro que la información es Correcta?") Then
                        Exit Sub
                    End If
                End If
            End If
        End If
        '
        If cmbrequisa.Text.ToString.Substring(0, 1) = "E" Then Factor = 1 Else Factor = -1

        Dim Registro As Boolean = False

        'If txtfactura.Text <> "" Then
        '    If XtraMsg2("La Requisa es solamente de REGISTRO de Entrada de la Factura " & txtfactura.Text) Then
        '        Registro = True
        '    End If
        'End If

        'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        'DBConnFacturas.Open()
        'transaccionFacturas = DBConnFacturas.BeginTransaction

        Dim Requisa As Integer = 0

        'If IdRequisa = 0 Then
        '    Requisa = VB.SysContab.RequisasDB.GetCodigoNuevo()         
        'Else
        '    Requisa = Me.txtrequisa.Text
        'End If

        If IdRequisa = 0 Then
            If cmbrequisa.EditValue = 2 Then
                If cbProyectos.EditValue <> 0 Then
                    If GuardarTraslado_Proyecto() Then
                        XtraMsg("Traslado Realizado Exitosamente !!!")
                        Close()
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                End If
            End If
        End If

        ShowSplash("Guardando Movimiento...")

        Try

            If IdRequisa = 0 Then
                Requisa = db_requisas.Add(EmpresaActual, cmbrequisa.Text.ToString.Substring(0, 1), fecha.DateTime.Date, cmbbodega.EditValue,
                                          txtrealizado.Text, txtfactura.Text, cbMovimientos.EditValue, txtReferencia.Text, mConcepto.Text,
                                          txtTransporte.Text, txtPlaca.Text, txtConductor.Text, txtRemision.Text,
                                          txtOtMatriz.Text, txtOtSuc.Text, cbCliente.EditValue, NoPoliza.Text,
                                          cbProyectos.EditValue, IIf(cbOrden.EditValue Is Nothing, 0, cbOrden.EditValue),
                                          cbProveedor.EditValue, 0, 0, 0, txtRecibimosDe.Text)

                If Requisa = 0 Then Exit Sub
            Else
                Requisa = IdRequisa ' Me.txtrequisa.Text
                If Not db_requisas.Update(EmpresaActual, Requisa, cmbrequisa.Text.ToString.Substring(0, 1), fecha.DateTime.Date,
                                          cmbbodega.EditValue, txtrealizado.Text, txtfactura.Text,
                                        cbMovimientos.EditValue, txtReferencia.Text, mConcepto.Text, txtTransporte.Text, txtPlaca.Text,
                                          txtConductor.Text, txtRemision.Text, txtOtMatriz.Text, txtOtSuc.Text, cbCliente.EditValue,
                                          NoPoliza.Text, cbProyectos.EditValue,
                                          IIf(cbOrden.EditValue Is Nothing, 0, cbOrden.EditValue), txtRecibimosDe.Text, cbProveedor.EditValue) Then Exit Sub
            End If


            'Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
            'Conn.IniciarTransaccion()

            'Try
            'ShowSplash("Guardando Movimiento...")

            'Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            'Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Output, Requisa)
            'Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, cmbrequisa.Text.ToString.Substring(0, 1))
            'Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, fecha.DateTime.Date)
            'Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, cmbbodega.EditValue)
            'Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtrealizado.Text)
            'Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, Registro)
            'Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, txtfactura.Text)
            'Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, Me.cbMovimientos.EditValue)
            'Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, Me.txtReferencia.Text)
            'Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, mConcepto.Text)
            'Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, txtTransporte.Text)
            'Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtPlaca.Text)
            'Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, txtConductor.Text)
            'Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtRemision.Text)
            'Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtOtMatriz.Text)
            'Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtOtSuc.Text)
            'Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, cbCliente.EditValue)
            'Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, NoPoliza.Text)
            'Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, cbProyectos.EditValue)
            'Conn.AddParameter("IdOrden", SqlDbType.Int, 5, ParameterDirection.Input, IIf(cbOrden.EditValue Is Nothing, 0, cbOrden.EditValue))

            'Conn.EjecutarComando("SP_Requisas_Add")

            'If IdRequisa = 0 Then Requisa = Conn.GetParameter("Requisa").Valor
            'If IdRequisa <> 0 Then Requisa = Me.txtrequisa.Text

            ''Requisa = VB.SysContab.RequisasDB.AddItem(Requisa, cmbrequisa.Text.ToString.Substring(0, 1), fecha.DateTime.Date, cmbbodega.EditValue, txtrealizado.Text, Registro, txtfactura.Text)
            ''If Requisa <> -1 Then
            ''    ''Conn.RemoveParameters()
            ''    ''Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            ''    ''Conn.AddParameter("Documento", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
            ''    ''Conn.AddParameter("Tipo", SqlDbType.NVarChar, 5, ParameterDirection.Input, "R")
            ''    ''Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, fecha.DateTime.Date)
            ''    ''Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, cmbbodega.EditValue)
            ''    ''Conn.AddParameter("Proveedor", SqlDbType.Int, 5, ParameterDirection.Input, 0)
            ''    ''Conn.EjecutarComando("SP_Transaccion_Bodega_Add")
            ''Else
            ''    HideSplash()
            ''    Conn.AnularTransaccion()
            ''    Exit Sub
            ''End If

            Dim DT As DataTable =
                Data.GetChanges(DataRowState.Added Or DataRowState.Modified)

            'Dim Articulos As New VB.SysContab.ArticulosDB
            'If cmbrequisa.EditValue = 1 Then
            '    DT = Data.GetChanges(DataRowState.Added Or DataRowState.Modified)
            'Else
            '    DT = Data.GetChanges(DataRowState.Added Or DataRowState.Modified)
            'End If

            If Not DT Is Nothing Then
                For i As Integer = 0 To DT.Rows.Count - 1

                    db_requisas.AddDetalle(EmpresaActual, Requisa, DT.Rows(i)("Codigo"),
                                           TipoServicio.EditValue,
                                            IIf(DT.Rows(i)("Cantidad") < 0, DT.Rows(i)("Cantidad") * -1, DT.Rows(i)("Cantidad")),
                                            DT.Rows.Item(i)("Costo"),
                                            IsNull(DT.Rows.Item(i)("Cuenta"), ""), "", "", "", 0, 1,
                                            IsNull(DT.Rows.Item(i)("IdCentro"), 0))


                    'Conn.RemoveParameters()
                    'Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    'Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                    'Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT.Rows(i)("Codigo"))
                    'Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, TipoServicio.EditValue)
                    'Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, IIf(DT.Rows(i)("Cantidad") < 0, DT.Rows(i)("Cantidad") * -1, DT.Rows(i)("Cantidad")))
                    'Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, DT.Rows.Item(i)("Costo"))
                    'Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT.Rows.Item(i)("Cuenta"))
                    'Conn.EjecutarComando("SP_Requisas_Detalle_Add")
                    'Else
                    '    Conn.RemoveParameters()
                    '    Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    '    Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                    '    Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT.Rows(i)("Codigo"))
                    '    Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, TipoServicio.EditValue)
                    '    Conn.EjecutarComando("SP_Requisas_Detalle_Delete")
                    'End If

                    ' ''Agregar el detalle de transaccion de bodega
                    ''Conn.RemoveParameters()
                    ''Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    ''Conn.AddParameter("Bodega", SqlDbType.NVarChar, 10, ParameterDirection.Input, cmbbodega.EditValue)
                    ''Conn.AddParameter("Articulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT.Rows(i)("Codigo"))
                    ''Conn.AddParameter("Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "R")
                    ''Conn.AddParameter("Documento", SqlDbType.NVarChar, 20, ParameterDirection.Input, Requisa)
                    ''Conn.AddParameter("Proveedor", SqlDbType.Int, 10, ParameterDirection.Input, 0)
                    ''Conn.AddParameter("Movimiento", SqlDbType.NVarChar, 10, ParameterDirection.Input, cmbrequisa.Text.Substring(0, 1))
                    ''Conn.AddParameter("Existencia", SqlDbType.Decimal, 20, ParameterDirection.Input, DT.Rows(i)("Cantidad"))
                    ''Conn.AddParameter("Costo", SqlDbType.Decimal, 20, ParameterDirection.Input, DT.Rows.Item(i)("Costo"))
                    ''Conn.AddParameter("Articulo_Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, TipoServicio.EditValue)
                    ''Conn.EjecutarComando("SP_Transaccion_Bodega_Detalle_Add")

                    'VB.SysContab.BodegasDB.TransaccionBodegaDetalle_Add(cmbbodega.EditValue, _
                    '     DT.Rows(i)("Codigo"), "R", Requisa, cmbrequisa.Text.ToString.Substring(0, 1), _
                    'DT.Rows(i)("Cantidad") * Factor, 0, "0", TipoServicio.EditValue)
                    'sumar las existencias

                    ''Conn.RemoveParameters()
                    ''Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    ''Conn.AddParameter("Cantidad", SqlDbType.Money, 10, ParameterDirection.Input, ValorX)
                    ''Conn.AddParameter("Item", SqlDbType.NVarChar, 20, ParameterDirection.Input, DT.Rows(i)("Codigo"))
                    ''Conn.AddParameter("Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, TipoServicio.EditValue)
                    ''Conn.EjecutarComando("SP_ItemsSumarExistencia")

                    ' ''Articulos.SumarExistencias(DT.Rows(i)("Codigo"), DT.Rows(i)("Cantidad") * Factor, TipoServicio.EditValue)

                    ''Conn.RemoveParameters()
                    ''Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                    ''Conn.AddParameter("Codigo", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT.Rows(i)("Codigo"))
                    ''Conn.AddParameter("Tipo", SqlDbType.NVarChar, 20, ParameterDirection.Input, TipoServicio.EditValue)
                    ''Conn.AddParameter("Costo", SqlDbType.Decimal, 20, ParameterDirection.Input, DT.Rows(i)("Costo"))
                    ''Conn.EjecutarComando("SPActualizarCosto")
                Next
            End If
            '
            If IdRequisa <> 0 Then

                Dim DT_DEL As DataTable = Data.GetChanges(DataRowState.Deleted)

                If Not DT_DEL Is Nothing Then
                    For i As Integer = 0 To DT_DEL.Rows.Count - 1

                        db_requisas.DeleteDetalle(EmpresaActual, Requisa, DT_DEL.Rows(i)("Codigo", DataRowVersion.Original), TipoServicio.EditValue)

                        'Conn.RemoveParameters()
                        'Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                        'Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                        'Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT_DEL.Rows(i)("Codigo", DataRowVersion.Original))
                        'Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, TipoServicio.EditValue)

                        'Conn.EjecutarComando("SP_Requisas_Detalle_Delete")                        
                    Next
                End If
            End If

            'Conn.CompletarTransaccion()

            Data.AcceptChanges()
            IdRequisa = Requisa
            txtrequisa.Text = Requisa.ToString()
            '
            BuscarArticulos()

            HideSplash()
            XtraMsg("Datos Guardados!", MessageBoxIcon.Information)

            Save = True
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message & ". Guardar", MessageBoxIcon.Error)
            Save = False
            'Conn.AnularTransaccion()
        End Try
    End Sub

    Function GuardarTraslado_Proyecto() As Boolean

        Dim DT_MOV As DataTable = ObtieneDatos("sp_Get_MovimientoProyecto", EmpresaActual)

        If DT_MOV.Rows.Count = 0 Then
            XtraMsg("No existe Movimiento creado para este tipo de transacción.")
            Return False
        End If

        Dim Id_Mov As Integer = DT_MOV.Rows.Item(0)("Movimiento")

        Dim Entrada As Integer = 0, Salida As Integer = 0

        'Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        'Conn.IniciarTransaccion()

        Try

            ShowSplash("Guardando Traslado...")

            'Guardar Entrada
            Entrada = db_requisas.Add(EmpresaActual, "E", fecha.DateTime.Date, cbProyectos.Properties.View.GetRowCellValue(cbProyectos.Properties.View.FocusedRowHandle, "Bodega"),
                                          Login, txtfactura.Text, Id_Mov, txtReferencia.Text, mConcepto.Text,
                                          txtTransporte.Text, txtPlaca.Text, txtConductor.Text, txtRemision.Text,
                                        txtOtMatriz.Text, txtOtSuc.Text, cbCliente.EditValue, NoPoliza.Text,
                                          cbProyectos.EditValue, IIf(cbOrden.EditValue Is Nothing, 0, cbOrden.EditValue), 0, 0, 0)


            If Entrada > 0 Then
                Dim DT As DataTable = Data.GetChanges(DataRowState.Added Or DataRowState.Modified)

                If Not DT Is Nothing Then
                    For i As Integer = 0 To DT.Rows.Count - 1

                        db_requisas.AddDetalle(EmpresaActual, Entrada, DT.Rows(i)("Codigo"), TipoServicio.EditValue,
                                                    DT.Rows(i)("Cantidad"), DT.Rows.Item(i)("Costo"), DT.Rows.Item(i)("Cuenta"))
                    Next
                End If
                '
                'Guardar Salida
                Salida = db_requisas.Add(EmpresaActual, "S", fecha.DateTime.Date, cmbbodega.EditValue,
                                          Login, txtfactura.Text, Id_Mov, txtReferencia.Text, mConcepto.Text,
                                          txtTransporte.Text, txtPlaca.Text, txtConductor.Text, txtRemision.Text,
                                          txtOtMatriz.Text, txtOtSuc.Text, cbCliente.EditValue, NoPoliza.Text,
                                          cbProyectos.EditValue, IIf(cbOrden.EditValue Is Nothing, 0, cbOrden.EditValue), 0, 0, Entrada)

                If Not DT Is Nothing Then
                    For i As Integer = 0 To DT.Rows.Count - 1

                        db_requisas.AddDetalle(EmpresaActual, Salida, DT.Rows(i)("Codigo"), TipoServicio.EditValue,
                                                    DT.Rows(i)("Cantidad"), DT.Rows.Item(i)("Costo"), DT.Rows.Item(i)("Cuenta"))
                    Next
                End If

                'Procesar Combos
                If Not DT Is Nothing Then
                    For i As Integer = 0 To DT.Rows.Count - 1

                        'Si el producto es Combo, se realizara la Conversion.
                        If db_requisas.Verificar_Combos(DT.Rows(i)("Codigo")).Rows.Count > 0 Then

                            db_requisas.Convertir_Combos(Entrada, DT.Rows(i)("Codigo"))

                        End If

                    Next
                End If



            End If

            Return True

            HideSplash()
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)

            Return False
        End Try


        'Dim Requisa As Integer = VB.SysContab.RequisasDB.GetCodigoNuevo()
        'Entrada = Requisa
        ''
        'Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        'Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
        'Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, "E")
        'Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, fecha.DateTime.Date)
        'Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, cbProyectos.Properties.View.GetRowCellValue(cbProyectos.Properties.View.FocusedRowHandle, "Bodega"))
        'Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Login)
        'Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, False)
        'Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, txtfactura.Text)
        'Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, Id_Mov)
        'Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtReferencia.Text)
        'Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, mConcepto.Text)
        'Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, txtTransporte.Text)
        'Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtPlaca.Text)
        'Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, txtConductor.Text)
        'Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtRemision.Text)
        'Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtOtMatriz.Text)
        'Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtOtSuc.Text)
        'Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, cbCliente.EditValue)
        'Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, NoPoliza.Text)
        'Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, cbProyectos.EditValue)
        'Conn.AddParameter("IdOrden", SqlDbType.Int, 5, ParameterDirection.Input, IIf(cbOrden.EditValue Is Nothing, 0, cbOrden.EditValue))
        'Conn.AddParameter("IdRequisa_Referencia", SqlDbType.Int, 5, ParameterDirection.Input, Requisa + 1)

        'Conn.EjecutarComando("SP_Requisas_Add")
        '
        'Dim DT As DataTable = Data.GetChanges(DataRowState.Added Or DataRowState.Modified)
        ''
        'If Not DT Is Nothing Then
        '    For i As Integer = 0 To DT.Rows.Count - 1
        '        Conn.RemoveParameters()
        '        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        '        Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
        '        Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT.Rows(i)("Codigo"))
        '        Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, TipoServicio.EditValue)
        '        Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, DT.Rows(i)("Cantidad"))
        '        Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, DT.Rows.Item(i)("Costo"))
        '        Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT.Rows.Item(i)("Cuenta"))
        '        '
        '        Conn.EjecutarComando("SP_Requisas_Detalle_Add")
        '    Next
        'End If
        '
        'Registrando Salida
        'Salida = Requisa + 1
        ''Encabezado
        'Conn.RemoveParameters()
        'Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        'Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa + 1)
        'Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, "S")
        'Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, fecha.DateTime.Date)
        'Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, cmbbodega.EditValue)
        'Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Login)
        'Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, False)
        'Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, txtfactura.Text)
        'Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, Id_Mov)
        'Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtReferencia.Text)
        'Conn.AddParameter("Concepto", SqlDbType.NVarChar, 2048, ParameterDirection.Input, mConcepto.Text)
        'Conn.AddParameter("Transporte", SqlDbType.NVarChar, 512, ParameterDirection.Input, txtTransporte.Text)
        'Conn.AddParameter("NoPlaca", SqlDbType.NVarChar, 100, ParameterDirection.Input, txtPlaca.Text)
        'Conn.AddParameter("Conductor", SqlDbType.NVarChar, 512, ParameterDirection.Input, txtConductor.Text)
        'Conn.AddParameter("Remision", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtRemision.Text)
        'Conn.AddParameter("OT_Matriz", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtOtMatriz.Text)
        'Conn.AddParameter("OT_Suc", SqlDbType.NVarChar, 50, ParameterDirection.Input, txtOtSuc.Text)
        'Conn.AddParameter("IdCliente", SqlDbType.Int, 5, ParameterDirection.Input, cbCliente.EditValue)
        'Conn.AddParameter("NoPoliza", SqlDbType.NVarChar, 50, ParameterDirection.Input, NoPoliza.Text)
        'Conn.AddParameter("IdProyecto", SqlDbType.Int, 5, ParameterDirection.Input, cbProyectos.EditValue)
        'Conn.AddParameter("IdOrden", SqlDbType.Int, 5, ParameterDirection.Input, IIf(cbOrden.EditValue Is Nothing, 0, cbOrden.EditValue))
        'Conn.AddParameter("IdRequisa_Referencia", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)

        'Conn.EjecutarComando("SP_Requisas_Add")
        '
        'If Not DT Is Nothing Then
        '    For i As Integer = 0 To DT.Rows.Count - 1
        '        Conn.RemoveParameters()
        '        Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        '        Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa + 1)
        '        Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT.Rows(i)("Codigo"))
        '        Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, TipoServicio.EditValue)
        '        Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, DT.Rows(i)("Cantidad"))
        '        Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, DT.Rows.Item(i)("Costo"))
        '        Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT.Rows.Item(i)("Cuenta"))
        '        '
        '        Conn.EjecutarComando("SP_Requisas_Detalle_Add")
        '    Next
        'End If

        'Conn.CompletarTransaccion()
        'HideSplash()

        '    Return True
        'Catch ex As Exception
        '    HideSplash()
        '    XtraMsg(ex.Message & "Guardar", MessageBoxIcon.Error)
        '    Conn.AnularTransaccion()

        '    Return False
        'End Try
    End Function

    Private Sub FrmRequisasnew_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim frm As frmRequisas_List = frmRequisas_List.Instance

        If frm.Created Then If Save Then frm.GetData()
    End Sub

    Private Sub cmdactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdactualizar.Click
        ListaArticulos()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Dim DT As New DataTable("Excel")
        Me.OpenFileDialog1.DefaultExt = "*.xls"
        Me.OpenFileDialog1.Filter = "(*.xls)|*.xls"

        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                Dim DC As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Me.OpenFileDialog1.FileName & ";Extended Properties=""Excel 8.0;HDR=YES;IMEX=1""")
                Dim DA As New OleDbDataAdapter("SELECT * FROM [" & InputBox("Nombre de la Hoja : ", "Hoja de calculo") & "$]", DC)
                DA.Fill(DT)

                If DT.Columns.Count - 1 <> 3 Then
                    MsgBox("Deben ser Cuatro (4) columnas para Importar el Archivo")
                    Exit Sub
                End If

                For i As Integer = 0 To DT.Rows.Count - 1
                    Dim Variables As New ArrayList
                    Dim Datos As New ArrayList
                    Variables.Add("Codigo")
                    Variables.Add("Nombre")
                    Variables.Add("Tipo")
                    Variables.Add("Empresa")

                    Datos.Add(DT.Rows(i).Item(0).ToString.Trim)
                    Datos.Add(DT.Rows(i).Item(1).ToString.Trim)
                    Datos.Add(TipoServicio.EditValue)
                    Datos.Add(EmpresaActual)
                    ProcedureParameters(Datos, Variables, "SPVerificaItem")
                Next

                For i As Integer = 0 To DT.Rows.Count - 1
                    If DT.Rows(i).Item(2) > 0 Then
                        ' If cmbrequisa.Text.ToString.Substring(0, 1) = "E" Then
                        vDatos.AddNewRow()
                        vDatos.SetRowCellValue(vDatos.FocusedRowHandle, "Codigo", DT.Rows(i).Item(0))
                        vDatos.SetRowCellValue(vDatos.FocusedRowHandle, "Cantidad", DT.Rows(i).Item(2))
                        vDatos.SetRowCellValue(vDatos.FocusedRowHandle, "Costo", DT.Rows(i).Item(3))
                        'Else
                        '    For j As Integer = 0 To vDatos.DataRowCount - 1
                        '        If DT.Rows(i).Item(0) = vDatos.GetRowCellValue(j, "Codigo") Then
                        '            vDatos.SetRowCellValue(j, "Cantidad", DT.Rows(i).Item(2))
                        '            vDatos.SetRowCellValue(j, "Costo", DT.Rows(i).Item(3))
                        '        End If
                        '    Next
                        'End If
                    End If
                Next
                ListaArticulos()
                '               
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub cbMovimientos_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbMovimientos.ButtonClick

        If e.Button.Index = 3 Then  'Registrar Nuevo Movimeinto
            My.Forms.frmTipoMovimientos.Nuevo = "SI"
            My.Forms.frmTipoMovimientos.GroupControl1.Text = "REGISTRAR NUEVO MOVIMIENTO"
            My.Forms.frmTipoMovimientos.ShowDialog()
            If My.Forms.frmTipoMovimientos.Ok = "SI" Then
                GetTipoMovimientos(Me.cbMovimientos, IIf(IdRequisa = 0, 1, 0))
            End If
            My.Forms.frmTipoMovimientos.Dispose()

        ElseIf e.Button.Index = 2 Then  'Actualizar Datos
            ' If Me.cbMovimientos.GetColumnValue("ID") = 0 Then
            If cbMovimientos.ItemIndex = 0 Then
                XtraMsg("Seleccione Un Registro para Actualizar Datos")
                Exit Sub
            End If

            My.Forms.frmTipoMovimientos.Nuevo = "NO"
            My.Forms.frmTipoMovimientos.GroupControl1.Text = "ACTUALIZAR DATOS DEL MOVIMIENTO"
            My.Forms.frmTipoMovimientos.ID = Me.cbMovimientos.EditValue 'Me.cbMovimientos.GetColumnValue("ID")
            My.Forms.frmTipoMovimientos.ShowDialog()
            If My.Forms.frmTipoMovimientos.Ok = "SI" Then
                GetTipoMovimientos(Me.cbMovimientos, IIf(IdRequisa = 0, 1, 0))
            End If
            My.Forms.frmTipoMovimientos.Dispose()

        ElseIf e.Button.Index = 1 Then  'Borrar Datos
            'If Me.cbMovimientos.GetColumnValue("ID") = 0 Then
            '    MsgBox("Seleccione Un Registro", MsgBoxStyle.Information)
            '    Exit Sub
            'End If

            If cbMovimientos.ItemIndex = 0 Then
                XtraMsg("Seleccione Un Registro")
                Exit Sub
            End If

            If ObtieneDatos("SELECT * FROM Requisas r WHERE r.Movimiento_ID = " & cbMovimientos.EditValue & "" _
                            + " AND r.empresa = " & EmpresaActual).Rows.Count > 0 Then
                XtraMsg("El Registro Seleccionado contiene Movimientos Realizados, No se puede Borrar", MessageBoxIcon.Error)
                Exit Sub
            Else
                If GuardaDatos("DELETE FROM TipoMovimientos WHERE ID = " & Me.cbMovimientos.EditValue & " AND Empresa = " & EmpresaActual) Then
                    GetTipoMovimientos(Me.cbMovimientos, IIf(IdRequisa = 0, 1, 0))
                End If
            End If
        End If
    End Sub

    Private Sub cbMovimientos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMovimientos.EditValueChanged
        If Inicio Then Exit Sub
        '
        If Me.cbMovimientos.ItemIndex = 0 Then
            Me.etCuenta.Text = ""
        Else
            Me.etCuenta.Text = "Cuenta: " + Me.cbMovimientos.Properties.GetDataSourceValue("Cuenta", Me.cbMovimientos.ItemIndex).ToString
            For i As Integer = 0 To vDatos.DataRowCount - 1
                vDatos.SetRowCellValue(i, "Cuenta", cbMovimientos.GetColumnValue("Cuenta"))
            Next
            vDatos.RefreshData()
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(GridDetalle)
    End Sub

    Private Sub cbProyectos_EditValueChanged(sender As Object, e As EventArgs) Handles cbProyectos.EditValueChanged
        If IdRequisa = 0 Then

            If cbProyectos.EditValue <> 0 Then
                cbCliente.EditValue = cbProyectos.Properties.View.GetRowCellValue(cbProyectos.Properties.View.FocusedRowHandle, "IdCliente")
                cbCliente.ReadOnly = True
                '
                txtReferencia.Text = cbProyectos.Properties.View.GetRowCellValue(cbProyectos.Properties.View.FocusedRowHandle, "Codigo")
            Else
                cbCliente.EditValue = 0
                cbCliente.ReadOnly = False
                '
                txtReferencia.Text = ""
            End If

        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If IdRequisa = 0 Then Exit Sub
        '

        Dim rq As New ClasesBLL.db_requisas
        rq.Detalles(IdRequisa)

        If rq.Clase = "M" Then
            XtraMsg("Los Traslados se imprimen desde el Módulo de Traslado!")
            Exit Sub
        End If
        '
        'Dim Cadena As String
        'Dim Temp As Boolean = False
        'Dim Data() As Byte

        ShowSplash("Imprimiendo...")

        'Try
        '    Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 24 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
        '    Temp = True
        '    '
        '    Dim Tamano As Integer
        '    Tamano = Data.GetUpperBound(0)
        '    Cadena = Application.StartupPath & "\rptRequisa.repx"
        '    If File.Exists(Cadena) Then Kill(Cadena)
        '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        '    Archivo.Write(Data, 0, Tamano)
        '    Archivo.Close()
        'Catch ex As Exception
        '    Temp = False
        'End Try

        Dim Temp As Boolean = db_Formatos.FormatoImpreso(24, "rptRequisa")

        Dim rpt As rptEntrada_Bodega

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptRequisa.repx", True)
        Else
            rpt = New rptEntrada_Bodega
        End If

        VistaPreviaDX(rpt,
                      ObtieneDatos("sp_GetRequisaImpresa", IdRequisa, txtReferencia.Text, EmpresaActual),
                      "Movimiento de Inventario No. " & IdRequisa)

        HideSplash()

        ' Dim rpt As New rptEntrada_Bodega
        'rpt.DataSource = ObtieneDatos("sp_GetRequisaImpresa", IdRequisa, txtReferencia.Text, EmpresaActual)
        'rpt.ShowPrintMarginsWarning = False
        'HideSplash()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub FrmRequisasnew_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub
End Class
