Imports System.Data
Imports System.Data.SqlClient

Public Class frmInclusion_Contabilizar
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents dgDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdContabilizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents dtpFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbTipoComprobante As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Calcu As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientos_Contabilizar))
        Me.dgDetalle = New DevExpress.XtraGrid.GridControl
        Me.vDetalle = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cbCatalogo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Calcu = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdContabilizar = New DevExpress.XtraEditors.SimpleButton
        Me.dtpFecha = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cbTipoComprobante = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calcu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDetalle
        '
        Me.dgDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalle.Location = New System.Drawing.Point(16, 112)
        Me.dgDetalle.MainView = Me.vDetalle
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCatalogo, Me.Calcu})
        Me.dgDetalle.Size = New System.Drawing.Size(480, 112)
        Me.dgDetalle.TabIndex = 0
        Me.dgDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDetalle})
        '
        'vDetalle
        '
        Me.vDetalle.GridControl = Me.dgDetalle
        Me.vDetalle.Name = "vDetalle"
        Me.vDetalle.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vDetalle.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vDetalle.OptionsView.ShowFooter = True
        Me.vDetalle.OptionsView.ShowGroupPanel = False
        '
        'cbCatalogo
        '
        Me.cbCatalogo.AutoHeight = False
        Me.cbCatalogo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUENTA", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", 200)})
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.NullText = ""
        '
        'Calcu
        '
        Me.Calcu.AutoHeight = False
        Me.Calcu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Calcu.Name = "Calcu"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdContabilizar)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 52)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Image = Global.SysActivos.My.Resources.Resources.cancel24
        Me.cmdSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdSalir.Location = New System.Drawing.Point(394, 12)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 34)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdContabilizar
        '
        Me.cmdContabilizar.Image = CType(resources.GetObject("cmdContabilizar.Image"), System.Drawing.Image)
        Me.cmdContabilizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdContabilizar.Location = New System.Drawing.Point(6, 12)
        Me.cmdContabilizar.Name = "cmdContabilizar"
        Me.cmdContabilizar.Size = New System.Drawing.Size(92, 34)
        Me.cmdContabilizar.TabIndex = 0
        Me.cmdContabilizar.Text = "&Contabilizar"
        '
        'dtpFecha
        '
        Me.dtpFecha.EditValue = Nothing
        Me.dtpFecha.Location = New System.Drawing.Point(144, 8)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Fecha:"
        '
        'cbTipoComprobante
        '
        Me.cbTipoComprobante.Location = New System.Drawing.Point(144, 32)
        Me.cbTipoComprobante.Name = "cbTipoComprobante"
        Me.cbTipoComprobante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoComprobante.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TipComp_Id", "Código", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TipComp_Nombre", 200, "Tipo de Comprobante")})
        Me.cbTipoComprobante.Properties.NullText = ""
        Me.cbTipoComprobante.Size = New System.Drawing.Size(248, 20)
        Me.cbTipoComprobante.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Tipo de Comprobante:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConcepto.Location = New System.Drawing.Point(144, 56)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(352, 48)
        Me.txtConcepto.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 56)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Concepto:"
        '
        'frmMovimientos_Contabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(512, 290)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cbTipoComprobante)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgDetalle)
        Me.Name = "frmMovimientos_Contabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilizando Movimientos de Activo Fijo"
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calcu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtpFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
#Region "Variables"
    Public Tipo As Integer = 0
    Public Regresar As Boolean = False
    Public Valor As Double = 0
    Public Consecutivo As Integer
    Public Datos As DataTable = Nothing
#End Region

    Private Sub frmMovimientos_Contabilizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If Tipo = 0 Then
        '    Me.dgDetalle.Enabled = False
        'End If
        Me.cbCatalogo.DataSource = VB.SysContab.CatalogoDB.GetListBuscarComboAuxiliar("%", "%", EmpresaActual).Tables(0)
        Me.cbCatalogo.ValueMember = "CUENTA"
        Me.cbCatalogo.DisplayMember = "NOMBRE"

        Me.cbTipoComprobante.Properties.DataSource = VB.SysContab.ComprobanteDB.GetTiposComprobantes(0).Tables("TipoComprobantes")
        Me.cbTipoComprobante.Properties.ValueMember = "TipComp_Id"
        Me.cbTipoComprobante.Properties.DisplayMember = "TipComp_Nombre"

        Me.dgDetalle.DataSource = Datos
        Me.vDetalle.PopulateColumns()

        Me.vDetalle.Columns("Cuenta").ColumnEdit = Me.cbCatalogo
        Me.vDetalle.Columns("Debitos").ColumnEdit = Me.Calcu
        Me.vDetalle.Columns("Creditos").ColumnEdit = Me.Calcu
        Me.vDetalle.BestFitColumns()


        Me.txtConcepto.Text = "Contabilizando Inclusion de Activos Fijos "
        Me.vDetalle.OptionsBehavior.Editable = False
        Me.vDetalle.Columns("Modificar").Visible = False
        Me.vDetalle.Columns("Codigo").Visible = False
        Me.vDetalle.Columns("Debitos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDetalle.Columns("Debitos").DisplayFormat.FormatString = "n2"
        Me.vDetalle.Columns("Debitos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDetalle.Columns("Debitos").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDetalle.Columns("Creditos").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDetalle.Columns("Creditos").DisplayFormat.FormatString = "n2"
        Me.vDetalle.Columns("Creditos").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDetalle.Columns("Creditos").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdContabilizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdContabilizar.Click

        If Math.Round(Me.vDetalle.Columns("Debitos").SummaryItem.SummaryValue, 2) <> Math.Round(Me.vDetalle.Columns("Creditos").SummaryItem.SummaryValue, 2) Then
            MsgBox("El comprobante esta descuadrado", MsgBoxStyle.Critical, "Sts.Activos")
            Exit Sub
        End If
        If Me.cbTipoComprobante.EditValue Is Nothing Then
            MsgBox("Seleccione un tipo de Comprobante", MsgBoxStyle.Critical, "Sts.Activos")
            Exit Sub
        End If

        Dim conexion As New VB.SysContab.Rutinas
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()

        Dim NoComprob As Double
        Try
            NoComprob = _
                VB.SysContab.ComprobanteDB.AddComprobante(Me.cbTipoComprobante.EditValue, _
                    1, Me.txtConcepto.Text, _
                    VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MONEDABASE, _
                    VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.EditValue), _
                    Me.dtpFecha.EditValue, _
                    0, "", False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.NATURAL)

            For i As Integer = 0 To Me.vDetalle.DataRowCount - 1
                Dim DC As String
                DC = IIf(Me.vDetalle.GetRowCellValue(i, "Debitos") = 0, "C", "D")
                VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, _
                    Me.vDetalle.GetRowCellValue(i, "Cuenta"), _
                    Me.vDetalle.GetRowCellValue(i, "Concepto"), _
                    Me.vDetalle.GetRowCellValue(i, "Debitos") + Me.vDetalle.GetRowCellValue(i, "Creditos"), _
                    0, Me.cbTipoComprobante.EditValue, DC, 0, 0, Me.dtpFecha.EditValue, 1)

                VB.SysContab.Activo_FijosDB.Inclusion_Contabilizar(Me.vDetalle.GetRowCellValue(i, "Codigo"), True)
            Next


            VB.SysContab.Rutinas.okTransaccion()
            SetTiempos(Module1.OrigenComprobantes.NATURAL, Funciones.Tiempos.TiempoFin, Now, Funciones.Eventos.Guarda, NoComprob)

            frmMovimientos.Cargar()
            Me.Close()
        Catch Mensaje As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            SetTiempos(Module1.OrigenComprobantes.NATURAL, Funciones.Tiempos.TiempoFin, Now, Funciones.Eventos.Error1, NoComprob)
            MsgBox(Mensaje.Message)
            Exit Sub
        End Try
    End Sub


    Private Sub dgDetalle_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDetalle.KeyUp
        If e.KeyCode = Keys.Delete Then
            If Me.vDetalle.GetFocusedRowCellValue("Modificar") = True Then
                Me.vDetalle.DeleteRow(Me.vDetalle.FocusedRowHandle)
            End If
        End If
    End Sub

    Private Sub vDetalle_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vDetalle.CellValueChanged
        If e.Column.FieldName = "Debitos" And Regresar = False Then
            Regresar = True
            Me.vDetalle.SetFocusedRowCellValue(Me.vDetalle.Columns("Creditos"), 0)
            Regresar = False
        ElseIf e.Column.FieldName = "Creditos" And Regresar = False Then
            Regresar = True
            Me.vDetalle.SetFocusedRowCellValue(Me.vDetalle.Columns("Debitos"), 0)
            Regresar = False
        End If
    End Sub


End Class

