Imports System.Data
Imports System.Data.SqlClient

Public Class frmDepositos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmDepositos = Nothing

    Public Shared Function Instance() As frmDepositos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmDepositos
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
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDepositos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAsignarDepositos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdVerIngresos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdVerHojas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridDepositos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDepositos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cRecibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cNoTarjeta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cEmisor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cNoCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cNoAutoriza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dPorFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents etDepositos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbBancos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents rgTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cMonto As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gridDepositos = New DevExpress.XtraGrid.GridControl()
        Me.vDepositos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cRecibo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cFactura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cBanco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cNoCheque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cEmisor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cNoTarjeta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cNoAutoriza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVerHojas = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdVerIngresos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAsignarDepositos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDepositos = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dPorFecha = New DevExpress.XtraEditors.DateEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.etDepositos = New DevExpress.XtraEditors.LabelControl()
        Me.cbBancos = New DevExpress.XtraEditors.LookUpEdit()
        Me.rgTipo = New DevExpress.XtraEditors.RadioGroup()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.gridDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dPorFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dPorFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBancos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridDepositos
        '
        Me.gridDepositos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDepositos.Location = New System.Drawing.Point(7, 80)
        Me.gridDepositos.MainView = Me.vDepositos
        Me.gridDepositos.Name = "gridDepositos"
        Me.gridDepositos.Size = New System.Drawing.Size(765, 313)
        Me.gridDepositos.TabIndex = 13
        Me.gridDepositos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDepositos})
        '
        'vDepositos
        '
        Me.vDepositos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cRecibo, Me.cFactura, Me.cFecha, Me.cBanco, Me.cNoCheque, Me.cEmisor, Me.cNoTarjeta, Me.cNoAutoriza, Me.cMoneda, Me.cMonto})
        Me.vDepositos.GridControl = Me.gridDepositos
        Me.vDepositos.Name = "vDepositos"
        Me.vDepositos.OptionsFilter.AllowFilterEditor = False
        Me.vDepositos.OptionsView.RowAutoHeight = True
        Me.vDepositos.OptionsView.ShowAutoFilterRow = True
        Me.vDepositos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vDepositos.OptionsView.ShowFooter = True
        Me.vDepositos.OptionsView.ShowGroupPanel = False
        '
        'cRecibo
        '
        Me.cRecibo.Caption = "Recibo"
        Me.cRecibo.FieldName = "Recibo"
        Me.cRecibo.Name = "cRecibo"
        Me.cRecibo.OptionsColumn.AllowEdit = False
        Me.cRecibo.Visible = True
        Me.cRecibo.VisibleIndex = 0
        Me.cRecibo.Width = 54
        '
        'cFactura
        '
        Me.cFactura.Caption = "Factura"
        Me.cFactura.FieldName = "Factura"
        Me.cFactura.Name = "cFactura"
        Me.cFactura.OptionsColumn.AllowEdit = False
        Me.cFactura.Visible = True
        Me.cFactura.VisibleIndex = 1
        Me.cFactura.Width = 67
        '
        'cFecha
        '
        Me.cFecha.Caption = "Fecha"
        Me.cFecha.FieldName = "Fecha"
        Me.cFecha.Name = "cFecha"
        Me.cFecha.OptionsColumn.AllowEdit = False
        Me.cFecha.Visible = True
        Me.cFecha.VisibleIndex = 2
        Me.cFecha.Width = 95
        '
        'cBanco
        '
        Me.cBanco.Caption = "Banco"
        Me.cBanco.FieldName = "Banco"
        Me.cBanco.Name = "cBanco"
        Me.cBanco.OptionsColumn.AllowEdit = False
        Me.cBanco.Visible = True
        Me.cBanco.VisibleIndex = 3
        Me.cBanco.Width = 184
        '
        'cNoCheque
        '
        Me.cNoCheque.Caption = "No. Cheque"
        Me.cNoCheque.FieldName = "No Cheque"
        Me.cNoCheque.Name = "cNoCheque"
        Me.cNoCheque.OptionsColumn.AllowEdit = False
        Me.cNoCheque.Visible = True
        Me.cNoCheque.VisibleIndex = 4
        Me.cNoCheque.Width = 90
        '
        'cEmisor
        '
        Me.cEmisor.Caption = "Emisor"
        Me.cEmisor.FieldName = "Emisor"
        Me.cEmisor.Name = "cEmisor"
        Me.cEmisor.OptionsColumn.AllowEdit = False
        Me.cEmisor.Width = 88
        '
        'cNoTarjeta
        '
        Me.cNoTarjeta.Caption = "No Tarjeta"
        Me.cNoTarjeta.FieldName = "No Tarjeta"
        Me.cNoTarjeta.Name = "cNoTarjeta"
        Me.cNoTarjeta.OptionsColumn.AllowEdit = False
        Me.cNoTarjeta.Width = 97
        '
        'cNoAutoriza
        '
        Me.cNoAutoriza.Caption = "No Autorización"
        Me.cNoAutoriza.FieldName = "No Autorización"
        Me.cNoAutoriza.Name = "cNoAutoriza"
        Me.cNoAutoriza.OptionsColumn.AllowEdit = False
        Me.cNoAutoriza.Width = 90
        '
        'cMoneda
        '
        Me.cMoneda.Caption = "Moneda"
        Me.cMoneda.FieldName = "Moneda"
        Me.cMoneda.Name = "cMoneda"
        Me.cMoneda.OptionsColumn.AllowEdit = False
        Me.cMoneda.Visible = True
        Me.cMoneda.VisibleIndex = 5
        Me.cMoneda.Width = 65
        '
        'cMonto
        '
        Me.cMonto.Caption = "Monto"
        Me.cMonto.DisplayFormat.FormatString = "{0:n2}"
        Me.cMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cMonto.FieldName = "Monto"
        Me.cMonto.Name = "cMonto"
        Me.cMonto.OptionsColumn.AllowEdit = False
        Me.cMonto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto", "{0:n2}")})
        Me.cMonto.Visible = True
        Me.cMonto.VisibleIndex = 6
        Me.cMonto.Width = 69
        '
        'cmdSalir
        '
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.Location = New System.Drawing.Point(12, 215)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(90, 34)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(12, 13)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(90, 34)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdVerHojas
        '
        Me.cmdVerHojas.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerHojas.Appearance.Options.UseFont = True
        Me.cmdVerHojas.Appearance.Options.UseTextOptions = True
        Me.cmdVerHojas.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdVerHojas.Enabled = False
        Me.cmdVerHojas.Location = New System.Drawing.Point(12, 175)
        Me.cmdVerHojas.Name = "cmdVerHojas"
        Me.cmdVerHojas.Size = New System.Drawing.Size(90, 34)
        Me.cmdVerHojas.TabIndex = 10
        Me.cmdVerHojas.Text = "&Ver Hojas de Depositos"
        '
        'cmdVerIngresos
        '
        Me.cmdVerIngresos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerIngresos.Appearance.Options.UseFont = True
        Me.cmdVerIngresos.Enabled = False
        Me.cmdVerIngresos.Location = New System.Drawing.Point(12, 54)
        Me.cmdVerIngresos.Name = "cmdVerIngresos"
        Me.cmdVerIngresos.Size = New System.Drawing.Size(90, 34)
        Me.cmdVerIngresos.TabIndex = 9
        Me.cmdVerIngresos.Text = "&Ver Ingresos"
        '
        'cmdAsignarDepositos
        '
        Me.cmdAsignarDepositos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAsignarDepositos.Appearance.Options.UseFont = True
        Me.cmdAsignarDepositos.Appearance.Options.UseTextOptions = True
        Me.cmdAsignarDepositos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAsignarDepositos.Enabled = False
        Me.cmdAsignarDepositos.Location = New System.Drawing.Point(12, 134)
        Me.cmdAsignarDepositos.Name = "cmdAsignarDepositos"
        Me.cmdAsignarDepositos.Size = New System.Drawing.Size(90, 34)
        Me.cmdAsignarDepositos.TabIndex = 8
        Me.cmdAsignarDepositos.Text = "&Asignar Depositos"
        '
        'cmdDepositos
        '
        Me.cmdDepositos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDepositos.Appearance.Options.UseFont = True
        Me.cmdDepositos.Appearance.Options.UseTextOptions = True
        Me.cmdDepositos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdDepositos.Enabled = False
        Me.cmdDepositos.Location = New System.Drawing.Point(12, 94)
        Me.cmdDepositos.Name = "cmdDepositos"
        Me.cmdDepositos.Size = New System.Drawing.Size(90, 34)
        Me.cmdDepositos.TabIndex = 7
        Me.cmdDepositos.Text = "&Crear Hojas de Depositos"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.dPorFecha)
        Me.PanelControl1.Controls.Add(Me.CheckEdit1)
        Me.PanelControl1.Controls.Add(Me.etDepositos)
        Me.PanelControl1.Controls.Add(Me.cbBancos)
        Me.PanelControl1.Controls.Add(Me.rgTipo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(903, 74)
        Me.PanelControl1.TabIndex = 158
        '
        'dPorFecha
        '
        Me.dPorFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dPorFecha.EditValue = Nothing
        Me.dPorFecha.Location = New System.Drawing.Point(764, 44)
        Me.dPorFecha.Name = "dPorFecha"
        Me.dPorFecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dPorFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dPorFecha.Properties.Appearance.Options.UseFont = True
        Me.dPorFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dPorFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dPorFecha.Size = New System.Drawing.Size(130, 22)
        Me.dPorFecha.TabIndex = 4
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckEdit1.Location = New System.Drawing.Point(762, 17)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Por Fecha"
        Me.CheckEdit1.Size = New System.Drawing.Size(97, 20)
        Me.CheckEdit1.TabIndex = 3
        '
        'etDepositos
        '
        Me.etDepositos.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDepositos.Location = New System.Drawing.Point(14, 50)
        Me.etDepositos.Name = "etDepositos"
        Me.etDepositos.Size = New System.Drawing.Size(44, 16)
        Me.etDepositos.TabIndex = 2
        Me.etDepositos.Text = "Banco:"
        '
        'cbBancos
        '
        Me.cbBancos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBancos.Location = New System.Drawing.Point(64, 44)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Properties.Appearance.Options.UseFont = True
        Me.cbBancos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBancos.Size = New System.Drawing.Size(694, 22)
        Me.cbBancos.TabIndex = 1
        '
        'rgTipo
        '
        Me.rgTipo.Location = New System.Drawing.Point(14, 6)
        Me.rgTipo.Name = "rgTipo"
        Me.rgTipo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgTipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgTipo.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.rgTipo.Properties.Appearance.Options.UseBackColor = True
        Me.rgTipo.Properties.Appearance.Options.UseFont = True
        Me.rgTipo.Properties.Appearance.Options.UseForeColor = True
        Me.rgTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Cheque"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Tarjeta"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Efectivo")})
        Me.rgTipo.Size = New System.Drawing.Size(728, 30)
        Me.rgTipo.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.cmdSalir)
        Me.PanelControl2.Controls.Add(Me.cmdVerHojas)
        Me.PanelControl2.Controls.Add(Me.cmdImprimir)
        Me.PanelControl2.Controls.Add(Me.cmdAsignarDepositos)
        Me.PanelControl2.Controls.Add(Me.cmdVerIngresos)
        Me.PanelControl2.Controls.Add(Me.cmdDepositos)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl2.Location = New System.Drawing.Point(786, 74)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(117, 331)
        Me.PanelControl2.TabIndex = 159
        '
        'frmDepositos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(903, 405)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.gridDepositos)
        Me.Name = "frmDepositos"
        Me.Text = "Depositos Bancarios"
        CType(Me.gridDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dPorFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dPorFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBancos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Clientes As New VB.SysContab.ClientesDB
    Dim Depositos As New VB.SysContab.DepositosDB
    Dim Bancos As New VB.SysContab.BancosDB
    Dim Emisores As New VB.SysContab.EmisoresDB
    Dim r As New VB.SysContab.Rutinas

    Dim Tabla As DataTable
    Dim ds As DataSet
    Dim Fecha As String
    Dim Tipo As Integer
    Dim Asignar As Double = 0

    Private Sub frmDepositos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''r.CambiarEstilo(Me)
        'r.FormularioColor(Me)

        'cbFecha.Checked = False
        'dtpFecha.Enabled = False

        RolesDB.UsuarioAcciones(PanelControl2)

        Me.CheckEdit1.Enabled = False
        Me.dPorFecha.Enabled = False
        CargarCombos(Bancos.List.Tables("Bancos"))

        Tipo = 2
        Me.rgTipo.EditValue = Tipo

        'MostrarDepositosBancoEmisor(Tipo, 0)
        'cbDepositos.DataSource = Bancos.List.Tables("Bancos")
        'cbDepositos.ValueMember = "Codigo"
        'cbDepositos.DisplayMember = "Nombre"

        'cbDepositos.DropDownStyle = ComboBoxStyle.DropDownList
        'cbBancos.EditValue = 0

        'Me.Text = ""
        'Me.etTitulo.BackColor = Color.DarkKhaki
        'Me.Refresh()
    End Sub

    'Private Sub rbEfectivo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Tipo = 1
    '    Asignar = 0
    '    cbDepositos.Enabled = False
    '    MostrarDepositosBancoEmisor(1, IIf(cbBancos.EditValue Is Nothing, 0, cbBancos.EditValue))

    '    Me.etTitulo.Text = "Pagos realizados en Efectivo"

    '    'Validando Columnas a Esconder
    '    Me.vDepositos.Columns("No Cheque").Visible = False
    '    Me.vDepositos.Columns("Banco").Visible = False

    '    Me.vDepositos.Columns("Emisor").Visible = False
    '    Me.vDepositos.Columns("No Tarjeta").Visible = False
    '    Me.vDepositos.Columns("No Autorización").Visible = False
    'End Sub

    'Private Sub rbCheques_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Tipo = 2
    '    Asignar = 0
    '    cbDepositos.Enabled = True
    '    MostrarDepositosBancoEmisor(2, IIf(cbBancos.EditValue Is Nothing, 0, cbBancos.EditValue))
    '    etDepositos.Text = "Bancos"

    '    cbDepositos.DataSource = Bancos.List.Tables("Bancos")
    '    cbDepositos.ValueMember = "Codigo"
    '    cbDepositos.DisplayMember = "Nombre"

    '    cbBancos.EditValue = 0

    '    Me.etTitulo.Text = "Pagos realizados por Cheques"

    '    'Validando Columnas que se van a esconder
    '    Me.vDepositos.Columns("No Cheque").Visible = True
    '    Me.vDepositos.Columns("Banco").Visible = True

    '    Me.vDepositos.Columns("Emisor").Visible = False
    '    Me.vDepositos.Columns("No Tarjeta").Visible = False
    '    Me.vDepositos.Columns("No Autorización").Visible = False

    '    'Posición de las Columnas
    '    Me.vDepositos.Columns("Banco").VisibleIndex = 3
    '    Me.vDepositos.Columns("No Cheque").VisibleIndex = 4
    '    Me.vDepositos.Columns("Moneda").VisibleIndex = 5
    '    Me.vDepositos.Columns("Monto").VisibleIndex = 6
    'End Sub

    'Private Sub rbTarjetas_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Tipo = 3
    '    cbDepositos.Enabled = True
    '    MostrarDepositosBancoEmisor(3, IIf(cbBancos.EditValue Is Nothing, 0, cbBancos.EditValue))

    '    etDepositos.Text = "Emisor"
    '    cbDepositos.DataSource = Emisores.GetList.Tables("Emisores")
    '    cbDepositos.ValueMember = "Codigo"
    '    cbDepositos.DisplayMember = "Nombre"

    '    cbBancos.EditValue = 0

    '    Me.etTitulo.Text = "Pagos realizados por Tarjeta de Crédito"

    '    'Validando Columnas que se van a esconder
    '    Me.vDepositos.Columns("Emisor").Visible = True
    '    Me.vDepositos.Columns("No Tarjeta").Visible = True
    '    Me.vDepositos.Columns("No Autorización").Visible = True

    '    Me.vDepositos.Columns("No Cheque").Visible = False
    '    Me.vDepositos.Columns("Banco").Visible = False

    '    'Posición de las Columnas
    '    Me.vDepositos.Columns("Emisor").VisibleIndex = 3
    '    Me.vDepositos.Columns("No Tarjeta").VisibleIndex = 4
    '    Me.vDepositos.Columns("No Autorización").VisibleIndex = 5
    '    Me.vDepositos.Columns("Moneda").VisibleIndex = 6
    '    Me.vDepositos.Columns("Monto").VisibleIndex = 7
    'End Sub

    'Private Sub MostrarDepositos(ByVal Tipo As Integer)
    '    ds = Clientes.Depositos(Tipo, 0)

    '    dgDepositos.DataSource = ds.Tables("Cobros").DefaultView
    '    Tabla = ds.Tables("Cobros")

    '    r.FormatGenerico(dgDepositos, Tabla)

    '    If ds.Tables("Cobros").Rows.Count <> 0 Then
    '        Registro = dgDepositos.Item(0, 1)
    '    Else
    '        Registro = "Vacio"
    '    End If

    'End Sub

    Private Sub MostrarDepositosBancoEmisor(ByVal Tipo As Integer, ByVal Filtro As String)
        Try
            If CheckEdit1.Checked = True Then
                Fecha = dPorFecha.DateTime.Date
            Else
                Fecha = ""
            End If

            ds = Clientes.DepositosBancoEmisor(Tipo, Filtro, Fecha)
            Me.gridDepositos.DataSource = ds.Tables("Cobros").DefaultView
            FormatoGrid(Me.vDepositos)
            Tabla = ds.Tables("Cobros")
            If ds.Tables("Cobros").Rows.Count = 0 Then Registro = "Vacio"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cbDepositos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If rbCheques.Checked = True Then
        '    Tipo = 2
        'ElseIf rbTarjetas.Checked = True Then
        '    Tipo = 3
        'ElseIf rbEfectivo.Checked = True Then
        '    Tipo = 1
        'End If
        Try
            If IsNumeric(cbBancos.EditValue) Then
                MostrarDepositosBancoEmisor(Tipo, cbBancos.EditValue)
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Private Sub dgDepositos_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Registro = dgDepositos.Item(dgDepositos.CurrentRowIndex, 1)
    'End Sub

    Private Sub cmdDepositos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDepositos.Click
        Dim f As frmAgregarDeposito = frmAgregarDeposito.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.txtCodigo.Focus()
    End Sub

    Private Sub cmdAsignarDepositos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAsignarDepositos.Click
        Dim Cantidad As Integer
        Cantidad = Depositos.CantidadXFecha(Now.Date)

        If Cantidad = 1 Then
            If Not XtraMsg2("Existe una Hoja de Deposito con datos..., Desea Crear otra?") Then
                '
            Else
                Dim fDeposito As frmAgregarDeposito = frmAgregarDeposito.Instance
                fDeposito.MdiParent = Me.MdiParent
                fDeposito.Show()
                fDeposito.txtCodigo.Focus()
                Exit Sub
            End If
        ElseIf Cantidad > 1 Then
            If Not XtraMsg2("Existen " & Cantidad & " Hojas de Deposito con datos..., Desea Crear otra?") Then
                '
            Else
                Dim fDeposito As frmAgregarDeposito = frmAgregarDeposito.Instance
                fDeposito.MdiParent = Me.MdiParent
                fDeposito.Show()
                fDeposito.txtCodigo.Focus()
                Exit Sub
            End If
        End If

        If Clientes.ChequesXBanco(0, Now.Date, 0, 0).Tables("Cobros").Rows.Count <> 0 Then
            If Not XtraMsg2("Arqueo no completado, Desea Continuar?") Then
                Exit Sub
            End If
        End If

        Seleccionar = False

        Deposito = ""
        FechaCobro = ""
        Banco = ""
        Checked = False
        Inicio = True
        Dim f As frmAsignarDepositos = frmAsignarDepositos.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        Inicio = False
    End Sub


    Private Sub cmdVerIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerIngresos.Click
        Dim f As frmCobrosTotales = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub


    Private Sub cmdVerHojas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerHojas.Click
        Dim f As frmDepositosList = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        MostrarDepositosBancoEmisor(Tipo, cbBancos.EditValue)
    End Sub

    'Private Sub cbFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If cbFecha.Checked = True Then
    '        dtpFecha.Enabled = True
    '    Else
    '        dtpFecha.Enabled = False
    '    End If
    '    MostrarDepositosBancoEmisor(Tipo, cbBancos.EditValue)
    'End Sub

    Private Sub vDepositos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vDepositos.DoubleClick
        'Validar que el registro este seleccionado

        If Me.vDepositos.FocusedRowHandle < 0 Then
            MsgBox("Seleccione un Registro primero", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim dr As DataRow = Me.vDepositos.GetDataRow(Me.vDepositos.FocusedRowHandle)

        ''**********************************************************
        ''PARA EL TERRAZA
        'Dim chk_seq As Integer = MicrosDB.GetMicrosChk_seq(dr("Numero").ToString)
        'If chk_seq = 0 Then
        '    MsgBox("La Selección actual no tiene Detalle", MsgBoxStyle.Information, "Detalle Factura")
        '    Exit Sub
        'End If

        ''*************************************************
        ''Mostrar Detalle de la Factura del Micro
        'Dim f As New FrmMicrosDetallesFacturas
        'f.chk_seq = chk_seq
        'f.SimpleButton3.Visible = False
        'f.SimpleButton2.Visible = False
        'f.GridView1.Columns("Cuenta").Visible = False

        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
        ''*************************************************************


        '*********************************************************************
        'PARA(TODOS)
        Registro = dr("Factura").ToString
        'se quito el 02062008
        'Dim f As DataGridTextBoxCombo.frmFacturacionCliente = f.Instance

        NuevaFactura = "NO"
        Dim FormFacturacion As DataGridTextBoxCombo.frmFacturacionClienteVer = FormFacturacion.Instance

        FormFacturacion.MdiParent = Me.MdiParent
        FormFacturacion.Show()
        FormFacturacion.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub vDepositos_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles vDepositos.FocusedRowChanged
        'Registro = dgDepositos.Item(dgDepositos.CurrentRowIndex, 1)
        If Me.vDepositos.FocusedRowHandle < 0 Then Exit Sub

        Registro = Me.vDepositos.GetRowCellValue(Me.vDepositos.FocusedRowHandle, "Factura").ToString
    End Sub

    Private Sub dPorFecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dPorFecha.EditValueChanged
        MostrarDepositosBancoEmisor(Tipo, cbBancos.EditValue)
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            dPorFecha.Enabled = True
        Else
            dPorFecha.Enabled = False
        End If

        MostrarDepositosBancoEmisor(Tipo, cbBancos.EditValue)
    End Sub

    Private Sub cbBancos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBancos.EditValueChanged
        If IsNumeric(cbBancos.EditValue) Then
            MostrarDepositosBancoEmisor(Tipo, cbBancos.EditValue)
        End If
    End Sub

    Private Sub rbCheques_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rbEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rgTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgTipo.SelectedIndexChanged
        ' Tipo = 2, Cheque, Tipo = 3, Tarjeta, Tipo = 1, Efectivo

        If rgTipo.EditValue = 2 Then
            Tipo = 2
            Asignar = 0
            cbBancos.Enabled = True
            MostrarDepositosBancoEmisor(2, IIf(cbBancos.EditValue Is Nothing, 0, cbBancos.EditValue))
            etDepositos.Text = "Banco:"

            CargarCombos(Bancos.List.Tables("Bancos"))

            'Me.etTitulo.Text = "Pagos realizados por Cheques"
            'Validando Columnas que se van a esconder
            Me.vDepositos.Columns("No Cheque").Visible = True
            Me.vDepositos.Columns("Banco").Visible = True

            Me.vDepositos.Columns("Emisor").Visible = False
            Me.vDepositos.Columns("No Tarjeta").Visible = False
            Me.vDepositos.Columns("No Autorización").Visible = False

            'Posición de las Columnas
            Me.vDepositos.Columns("Banco").VisibleIndex = 3
            Me.vDepositos.Columns("No Cheque").VisibleIndex = 4
            Me.vDepositos.Columns("Moneda").VisibleIndex = 5
            Me.vDepositos.Columns("Monto").VisibleIndex = 6

        ElseIf rgTipo.EditValue = 3 Then
            Tipo = 3
            cbBancos.Enabled = True
            MostrarDepositosBancoEmisor(3, IIf(cbBancos.EditValue Is Nothing, 0, cbBancos.EditValue))

            etDepositos.Text = "Emisor:"
            CargarCombos(Emisores.GetList.Tables("Emisores"))

            'Me.etTitulo.Text = "Pagos realizados por Tarjeta de Crédito"

            'Validando Columnas que se van a esconder
            Me.vDepositos.Columns("Emisor").Visible = True
            Me.vDepositos.Columns("No Tarjeta").Visible = True
            Me.vDepositos.Columns("No Autorización").Visible = True

            Me.vDepositos.Columns("No Cheque").Visible = False
            Me.vDepositos.Columns("Banco").Visible = False

            'Posición de las Columnas
            Me.vDepositos.Columns("Emisor").VisibleIndex = 3
            Me.vDepositos.Columns("No Tarjeta").VisibleIndex = 4
            Me.vDepositos.Columns("No Autorización").VisibleIndex = 5
            Me.vDepositos.Columns("Moneda").VisibleIndex = 6
            Me.vDepositos.Columns("Monto").VisibleIndex = 7
        ElseIf rgTipo.EditValue = 1 Then    'Efectivo
            Tipo = 1
            Asignar = 0
            cbBancos.Enabled = False
            Me.cbBancos.Properties.DataSource = Nothing
            'CargarCombos(Nothing)

            MostrarDepositosBancoEmisor(1, IIf(cbBancos.EditValue Is Nothing, 0, cbBancos.EditValue))
            'Me.etTitulo.Text = "Pagos realizados en Efectivo"
            'Validando Columnas a Esconder
            Me.vDepositos.Columns("No Cheque").Visible = False
            Me.vDepositos.Columns("Banco").Visible = False

            Me.vDepositos.Columns("Emisor").Visible = False
            Me.vDepositos.Columns("No Tarjeta").Visible = False
            Me.vDepositos.Columns("No Autorización").Visible = False
        End If
    End Sub

    Sub CargarCombos(ByVal Data As DataTable)

        Me.cbBancos.Properties.DataSource = Data.DefaultView
        Me.cbBancos.Properties.ValueMember = "Codigo"
        Me.cbBancos.Properties.DisplayMember = "Nombre"
        Me.cbBancos.Properties.PopulateColumns()
        Me.cbBancos.Properties.Columns("Empresa").Visible = False
        Me.cbBancos.ItemIndex = 0
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.gridDepositos)
    End Sub
End Class
