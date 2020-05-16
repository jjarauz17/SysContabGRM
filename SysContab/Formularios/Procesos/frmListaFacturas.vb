Public Class frmListaFacturas
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmListaFacturas = Nothing

    Public Shared Function Instance() As frmListaFacturas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmListaFacturas()
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
    Friend WithEvents cmdFacturar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgFacturas As System.Windows.Forms.DataGrid
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbFormaPagoList As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents gcFacturasServicios As DevExpress.XtraGrid.GridControl
    Friend WithEvents Facturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbProveedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbServicios As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cFacturas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cFormaPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cIva As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdFacturar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.dgFacturas = New System.Windows.Forms.DataGrid
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbFormaPagoList = New System.Windows.Forms.ComboBox
        Me.cbFormaPago = New DevExpress.XtraEditors.LookUpEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.gcFacturasServicios = New DevExpress.XtraGrid.GridControl
        Me.Facturas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cFacturas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cFormaPago = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cMonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cDescuento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cSubTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cIva = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cbProveedor = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cbServicios = New DevExpress.XtraEditors.LookUpEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcFacturasServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbServicios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdFacturar)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 424)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 48)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdAyuda.Location = New System.Drawing.Point(152, 16)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 24)
        Me.cmdAyuda.TabIndex = 8
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdFacturar
        '
        Me.cmdFacturar.Location = New System.Drawing.Point(24, 16)
        Me.cmdFacturar.Name = "cmdFacturar"
        Me.cmdFacturar.Size = New System.Drawing.Size(112, 24)
        Me.cmdFacturar.TabIndex = 7
        Me.cmdFacturar.Text = "&Pagar Factura"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(240, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'dgFacturas
        '
        Me.dgFacturas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgFacturas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgFacturas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgFacturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgFacturas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgFacturas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturas.CaptionForeColor = System.Drawing.Color.Black
        Me.dgFacturas.DataMember = ""
        Me.dgFacturas.FlatMode = True
        Me.dgFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturas.ForeColor = System.Drawing.Color.Black
        Me.dgFacturas.GridLineColor = System.Drawing.Color.Silver
        Me.dgFacturas.HeaderBackColor = System.Drawing.Color.Black
        Me.dgFacturas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturas.HeaderForeColor = System.Drawing.Color.White
        Me.dgFacturas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgFacturas.Location = New System.Drawing.Point(712, 440)
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgFacturas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgFacturas.ReadOnly = True
        Me.dgFacturas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgFacturas.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturas.Size = New System.Drawing.Size(208, 40)
        Me.dgFacturas.TabIndex = 16
        Me.dgFacturas.Visible = False
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label25.Location = New System.Drawing.Point(712, 416)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(104, 16)
        Me.Label25.TabIndex = 177
        Me.Label25.Text = "Forma de Pago:"
        Me.Label25.Visible = False
        '
        'cbFormaPagoList
        '
        Me.cbFormaPagoList.Location = New System.Drawing.Point(816, 416)
        Me.cbFormaPagoList.Name = "cbFormaPagoList"
        Me.cbFormaPagoList.Size = New System.Drawing.Size(96, 21)
        Me.cbFormaPagoList.TabIndex = 178
        Me.cbFormaPagoList.Text = "ComboBox1"
        Me.cbFormaPagoList.Visible = False
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Location = New System.Drawing.Point(152, 16)
        Me.cbFormaPago.Name = "cbFormaPago"
        '
        'cbFormaPago.Properties
        '
        Me.cbFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFormaPago.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 200)})
        Me.cbFormaPago.Properties.DisplayMember = "Nombre"
        Me.cbFormaPago.Properties.NullText = ""
        Me.cbFormaPago.Properties.ShowFooter = False
        Me.cbFormaPago.Properties.ValueMember = "Codigo"
        Me.cbFormaPago.Size = New System.Drawing.Size(200, 20)
        Me.cbFormaPago.TabIndex = 180
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 24)
        Me.Label19.TabIndex = 181
        Me.Label19.Text = "Forma de Pago:"
        '
        'gcFacturasServicios
        '
        '
        'gcFacturasServicios.EmbeddedNavigator
        '
        Me.gcFacturasServicios.EmbeddedNavigator.Name = ""
        Me.gcFacturasServicios.Location = New System.Drawing.Point(16, 88)
        Me.gcFacturasServicios.MainView = Me.Facturas
        Me.gcFacturasServicios.Name = "gcFacturasServicios"
        Me.gcFacturasServicios.Size = New System.Drawing.Size(848, 256)
        Me.gcFacturasServicios.TabIndex = 179
        Me.gcFacturasServicios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Facturas})
        '
        'Facturas
        '
        Me.Facturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cFacturas, Me.cFecha, Me.cFormaPago, Me.cMonto, Me.cDescuento, Me.cSubTotal, Me.cIva})
        Me.Facturas.GridControl = Me.gcFacturasServicios
        Me.Facturas.Name = "Facturas"
        Me.Facturas.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Facturas.OptionsView.ShowGroupPanel = False
        '
        'cFacturas
        '
        Me.cFacturas.Caption = "Código de Factura"
        Me.cFacturas.FieldName = "Factura"
        Me.cFacturas.Name = "cFacturas"
        Me.cFacturas.OptionsColumn.AllowEdit = False
        Me.cFacturas.Visible = True
        Me.cFacturas.VisibleIndex = 0
        '
        'cFecha
        '
        Me.cFecha.Caption = "Fecha"
        Me.cFecha.FieldName = "Fecha"
        Me.cFecha.Name = "cFecha"
        Me.cFecha.OptionsColumn.AllowEdit = False
        Me.cFecha.Visible = True
        Me.cFecha.VisibleIndex = 1
        '
        'cFormaPago
        '
        Me.cFormaPago.Caption = "Forma de Pago"
        Me.cFormaPago.FieldName = "FormaPago"
        Me.cFormaPago.Name = "cFormaPago"
        Me.cFormaPago.Visible = True
        Me.cFormaPago.VisibleIndex = 2
        '
        'cMonto
        '
        Me.cMonto.Caption = "Monto"
        Me.cMonto.FieldName = "Monto"
        Me.cMonto.Name = "cMonto"
        Me.cMonto.Visible = True
        Me.cMonto.VisibleIndex = 3
        '
        'cDescuento
        '
        Me.cDescuento.Caption = "Descuento"
        Me.cDescuento.FieldName = "Descuento"
        Me.cDescuento.Name = "cDescuento"
        Me.cDescuento.Visible = True
        Me.cDescuento.VisibleIndex = 4
        '
        'cSubTotal
        '
        Me.cSubTotal.Caption = "Sub Total"
        Me.cSubTotal.FieldName = "SubTotal"
        Me.cSubTotal.Name = "cSubTotal"
        Me.cSubTotal.Visible = True
        Me.cSubTotal.VisibleIndex = 5
        '
        'cIva
        '
        Me.cIva.Caption = "IVA"
        Me.cIva.FieldName = "IVA"
        Me.cIva.Name = "cIva"
        Me.cIva.Visible = True
        Me.cIva.VisibleIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(560, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(96, 24)
        Me.LabelControl1.TabIndex = 185
        Me.LabelControl1.Text = "Proveedor:"
        Me.LabelControl1.Visible = False
        '
        'cbProveedor
        '
        Me.cbProveedor.Location = New System.Drawing.Point(696, 16)
        Me.cbProveedor.Name = "cbProveedor"
        '
        'cbProveedor.Properties
        '
        Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 200)})
        Me.cbProveedor.Properties.DisplayMember = "Nombre"
        Me.cbProveedor.Properties.NullText = ""
        Me.cbProveedor.Properties.ShowFooter = False
        Me.cbProveedor.Properties.ValueMember = "Codigo"
        Me.cbProveedor.Size = New System.Drawing.Size(216, 20)
        Me.cbProveedor.TabIndex = 184
        Me.cbProveedor.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(16, 48)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(96, 24)
        Me.LabelControl2.TabIndex = 183
        Me.LabelControl2.Text = "Servicios:"
        '
        'cbServicios
        '
        Me.cbServicios.Location = New System.Drawing.Point(152, 48)
        Me.cbServicios.Name = "cbServicios"
        '
        'cbServicios.Properties
        '
        Me.cbServicios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbServicios.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Servicio", 60), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ser_Descripcion", "Descripcion", 130), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CtaGasto", "Cuenta Provisión", 200)})
        Me.cbServicios.Properties.DisplayMember = "Ser_Descripcion"
        Me.cbServicios.Properties.NullText = ""
        Me.cbServicios.Properties.PopupWidth = 200
        Me.cbServicios.Properties.ShowFooter = False
        Me.cbServicios.Properties.ValueMember = "Codigo"
        Me.cbServicios.Size = New System.Drawing.Size(416, 20)
        Me.cbServicios.TabIndex = 182
        '
        'frmListaFacturas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1028, 550)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cbProveedor)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cbServicios)
        Me.Controls.Add(Me.cbFormaPago)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.gcFacturasServicios)
        Me.Controls.Add(Me.cbFormaPagoList)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgFacturas)
        Me.Name = "frmListaFacturas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcFacturasServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Facturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbServicios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Dim Facturas As New VB.SysContab.Facturas_Ventas_TemporalDB()
    Public Basico_ID As Integer = 0

    Dim FacturasComprasDB As New VB.SysContab.Facturas_ComprasDB()
    Dim FormaPagoDB As New VB.SysContab.Forma_PagoDB()
    Dim r As New VB.SysContab.Rutinas()

    Dim Tabla As DataTable
    Dim ds As DataSet
    Public Fact As String
    Public FactValor As String

    Dim Proveedores As New VB.SysContab.ProveedoresDB
    Dim FormaPago As New VB.SysContab.Forma_PagoDB
    Dim Consecutivo As Integer
    Dim Estado As String

    Private Sub frmListaOrdenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Servicio As String
        ' Me.cbProveedor.Properties.DataSource = Proveedores.ProveedoresServiciosList().Tables("Proveedores")
        Me.cbServicios.Properties.DataSource = VB.SysContab.ServiciosBasicos.GetList("B", IIf(Me.Basico_ID = 0, "%", Me.Basico_ID)).Tables(0)
        Me.cbFormaPago.Properties.DataSource = FormaPago.FormaPagoList().Tables("Forma_Pago")
        Me.cbServicios.ItemIndex = 0
        Me.cbFormaPago.ItemIndex = 0
        If Me.cbServicios.Properties.DataSource.rows.count >= 1 Then
            Consecutivo = Me.cbServicios.Properties.DataSource.rows(Me.cbServicios.ItemIndex)("Consecutivo_ID")
        Else
            Consecutivo = 0
        End If

        'Servicio = Me.cbServicios.EditValue
        'Me.gcFacturasServicios.DataSource = VB.SysContab.Facturas_ComprasDB.GetList(0, _
        '        Servicio.Substring(0, 2), Servicio.Substring(3, 10), "%").Tables(0)

        Me.gcFacturasServicios.DataSource = VB.SysContab.Facturas_ComprasDB.GetList(0, _
               Me.Basico_ID, Consecutivo, IIf(Me.cbFormaPago.EditValue = 0, "%", Me.cbFormaPago.EditValue)).Tables(0)

        'Try

        '    'r.CambiarEstilo(Me)
        '    r.FormularioColor(Me)

        '    cbFormaPagoList.DataSource = FormaPagoDB.FormaPagoListAll().Tables("Forma_Pago")
        '    cbFormaPagoList.ValueMember = "Codigo"
        '    cbFormaPagoList.DisplayMember = "Nombre"


        '    ds = FacturasComprasDB.GetList(lblProvID.Text, lblEsqID.Text, cbFormaPagoList.SelectedValue)
        '    dgFacturas.DataSource = ds.Tables("Tablas").DefaultView

        '    Tabla = ds.Tables("Tablas")

        '    r.FormatGenerico(dgFacturas, Tabla)

        '    If ds.Tables("Tablas").Rows.Count <> 0 Then
        '        RegistroOrdenVer = dgFacturas.Item(0, 1)
        '    Else
        '        RegistroOrdenVer = "Vacio"
        '    End If

        '    dgFacturas.CaptionText = "Información de Facturas Pendientes"
        '    Me.Text = "Facturas"
        '    Me.Refresh()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub


    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub cmdFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFacturar.Click

        If Me.gcFacturasServicios.DataSource.rows(Me.Facturas.FocusedRowHandle).item("comp_no") = 0 Then
            MsgBox("No se encuentra el comprobante de esta factura", MsgBoxStyle.Critical, "STS-Contab")
            Exit Sub
        End If
        'Buscar el detalle de la factura
        Fact = Me.gcFacturasServicios.DataSource.rows(Me.Facturas.FocusedRowHandle).item("Factura")
        FactValor = Me.gcFacturasServicios.DataSource.rows(Me.Facturas.FocusedRowHandle).item("Total")

        'Fact = dgFacturas.Item(dgFacturas.CurrentRowIndex, 0)
        'FactValor = dgFacturas.Item(dgFacturas.CurrentRowIndex, 8)


        'If VB.SysContab.ComprobanteDB.GetComprobanteAprobadoxFact(Fact, _
        'Me.gcFacturasServicios.DataSource.rows(Me.Facturas.FocusedRowHandle).item("Proveedor"), _
        ' Me.gcFacturasServicios.DataSource.rows(Me.Facturas.FocusedRowHandle).item("Fecha")) = True Then
        '    'lblProvID.Text,

            Dim fr As frmPlantillasBancosSB = fr.Instance
            fr.MdiParent = Me.MdiParent
            fr.lblProv.Text = Me.gcFacturasServicios.DataSource.rows(Me.Facturas.FocusedRowHandle).item("Nombre")
            fr.lblProvID.Text = Me.gcFacturasServicios.DataSource.rows(Me.Facturas.FocusedRowHandle).item("Proveedor")
            'fr.lblProv.Text = lblProv.Text
            'fr.lblProvID.Text = lblProvID.Text
            fr.Basico = Me.cbServicios.Properties.DataSource.rows(Me.cbServicios.ItemIndex)("ProdServ")
            fr.Consecutivo = Me.cbServicios.Properties.DataSource.rows(Me.cbServicios.ItemIndex)("Ser_Descripcion")
            fr.SUBTOTAL = Me.gcFacturasServicios.DataSource.rows(Me.Facturas.FocusedRowHandle).item("SubTotal")
            fr.etCodigoProveedor.Text = Me.gcFacturasServicios.DataSource.rows(Me.Facturas.FocusedRowHandle).item("Proveedor") 'Me.dgFacturas.Item(Me.dgFacturas.CurrentRowIndex, 9)
            fr.Servicio = Me.cbServicios.EditValue
            fr.compFact = Me.gcFacturasServicios.DataSource.rows(Me.Facturas.FocusedRowHandle).item("comp_no")
            fr.compMes = Me.gcFacturasServicios.DataSource.rows(Me.Facturas.FocusedRowHandle).item("Mes")
            fr.compPerID = Me.gcFacturasServicios.DataSource.rows(Me.Facturas.FocusedRowHandle).item("per_ID")

            fr.lblFact.Text = Fact
            fr.lblFactMonto.Text = FactValor
            fr.Show()
        'Else
        '    MsgBox("No se puede Pagar Factura. No esta Aprobada")
        'End If
    End Sub

    Private Sub cbFormaPagoList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFormaPagoList.SelectedValueChanged

        If IsNumeric(cbFormaPagoList.SelectedValue) Then

            'ds = FacturasComprasDB.GetList(lblProvID.Text, lblEsqID.Text, cbFormaPagoList.SelectedValue)
            dgFacturas.DataSource = ds.Tables("Tablas").DefaultView
            Tabla = ds.Tables("Tablas")

        End If

    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/ProcesosEfectuarPagos.chm", HelpNavigator.KeywordIndex, "ServicioBasico")
    End Sub

    Private Sub cbFormaPago_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFormaPago.EditValueChanged
        Dim servicio As String
        If Not (cbFormaPago.EditValue Is Nothing Or cbFormaPago.EditValue Is DBNull.Value) Then
            If Me.cbServicios.Properties.DataSource.rows.count >= 1 And (Not (Me.cbServicios.EditValue Is Nothing Or Me.cbServicios.EditValue Is DBNull.Value)) Then
                servicio = Me.cbServicios.EditValue
                Me.gcFacturasServicios.DataSource = VB.SysContab.Facturas_ComprasDB.GetList(0, _
                        servicio.Substring(0, 2), servicio.Substring(3, 10), IIf(Me.cbFormaPago.EditValue = 0, "%", Me.cbFormaPago.EditValue)).Tables(0)
            End If
        End If
    End Sub

    Private Sub cbServicios_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbServicios.EditValueChanged
        Dim servicio As String
        If Not (cbServicios.EditValue Is Nothing Or cbServicios.EditValue Is DBNull.Value) Then
            If Me.cbFormaPago.Properties.DataSource.rows.count >= 1 And (Not (Me.cbFormaPago.EditValue Is Nothing Or Me.cbFormaPago.EditValue Is DBNull.Value)) Then
                servicio = Me.cbServicios.EditValue
                Me.gcFacturasServicios.DataSource = VB.SysContab.Facturas_ComprasDB.GetList(0, _
                        servicio.Substring(0, 2), servicio.Substring(3, 10), IIf(Me.cbFormaPago.EditValue = 0, "%", Me.cbFormaPago.EditValue)).Tables(0)
            End If
        End If
    End Sub
End Class
