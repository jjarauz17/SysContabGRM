Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Localization


Public Class FrmPlanillaxContabilizar
    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As FrmPlanillaxContabilizar = Nothing
    Friend WithEvents dVista As New DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbRubros As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbCCosto As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

    Public Shared Function Instance() As FrmPlanillaxContabilizar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmPlanillaxContabilizar()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

#Region " Windows Form Designer generated code "

    Private Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSeleccionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etDescripcionIngr As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbTipoComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents vPlanillas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgPlanillas As DevExpress.XtraGrid.GridControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSeleccionar = New DevExpress.XtraEditors.SimpleButton()
        Me.etDescripcionIngr = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbTipoComp = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgPlanillas = New DevExpress.XtraGrid.GridControl()
        Me.vPlanillas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgPlanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vPlanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.SimpleButton1)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.cmdSalir)
        Me.GroupBox6.Controls.Add(Me.cmdSeleccionar)
        Me.GroupBox6.Location = New System.Drawing.Point(892, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(112, 507)
        Me.GroupBox6.TabIndex = 144
        Me.GroupBox6.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButton1.Location = New System.Drawing.Point(16, 473)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 26)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Exportar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 26)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Imprimir"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(16, 112)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 26)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Location = New System.Drawing.Point(16, 26)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(80, 26)
        Me.cmdSeleccionar.TabIndex = 0
        Me.cmdSeleccionar.Text = "&Contabilizar"
        '
        'etDescripcionIngr
        '
        Me.etDescripcionIngr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etDescripcionIngr.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcionIngr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcionIngr.ForeColor = System.Drawing.Color.White
        Me.etDescripcionIngr.Location = New System.Drawing.Point(12, 9)
        Me.etDescripcionIngr.Name = "etDescripcionIngr"
        Me.etDescripcionIngr.Size = New System.Drawing.Size(872, 21)
        Me.etDescripcionIngr.TabIndex = 142
        Me.etDescripcionIngr.Text = "Detalle de Planilla a Contabilizar. Planilla Codigo: "
        Me.etDescripcionIngr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 26)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(96, 34)
        Me.txtCodigo.MaxLength = 14
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigo.TabIndex = 145
        '
        'txtConcepto
        '
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Location = New System.Drawing.Point(96, 69)
        Me.txtConcepto.MaxLength = 100
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConcepto.Size = New System.Drawing.Size(632, 43)
        Me.txtConcepto.TabIndex = 147
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 26)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "Concepto:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(240, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Fecha:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(320, 34)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(120, 20)
        Me.dtpFecha.TabIndex = 149
        Me.dtpFecha.Value = New Date(2006, 8, 10, 10, 38, 43, 562)
        '
        'cbTipoComp
        '
        Me.cbTipoComp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoComp.Location = New System.Drawing.Point(640, 34)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Size = New System.Drawing.Size(248, 21)
        Me.cbTipoComp.TabIndex = 157
        Me.cbTipoComp.Text = "ComboBox1"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(479, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 18)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "Tipo de Comprobante:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(16, 121)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(864, 401)
        Me.TabControl1.TabIndex = 158
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgPlanillas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(856, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consolidada"
        '
        'dgPlanillas
        '
        Me.dgPlanillas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPlanillas.Location = New System.Drawing.Point(8, 8)
        Me.dgPlanillas.MainView = Me.vPlanillas
        Me.dgPlanillas.Name = "dgPlanillas"
        Me.dgPlanillas.Size = New System.Drawing.Size(840, 364)
        Me.dgPlanillas.TabIndex = 1
        Me.dgPlanillas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vPlanillas})
        '
        'vPlanillas
        '
        Me.vPlanillas.GridControl = Me.dgPlanillas
        Me.vPlanillas.Name = "vPlanillas"
        Me.vPlanillas.OptionsBehavior.Editable = False
        Me.vPlanillas.OptionsSelection.MultiSelect = True
        Me.vPlanillas.OptionsView.ShowFooter = True
        Me.vPlanillas.OptionsView.ShowGroupPanel = False
        '
        'FrmPlanillaxContabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.etDescripcionIngr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbTipoComp)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmPlanillaxContabilizar"
        Me.Text = "Contabilizar Planilla"
        Me.GroupBox6.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Tipo As String
    Public Codigo As String

    Dim Ds As New DataSet

    Dim Rutinas As New VB.SysContab.Rutinas
    Private i As Integer
    Dim Catalogo As New VB.SysContab.CatalogoDB()
    Dim Grupos As New VB.SysContab.GruposDB()
    Dim Periodos As New VB.SysContab.PeriodosDB()
    Dim TComprobantes As New VB.SysContab.ComprobanteDB

    Dim Libros As New VB.SysContab.LibrosDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim tcuenta As String
    Dim Empresa As New VB.SysContab.EmpresasDetails()
    Dim Empresas As New VB.SysContab.EmpresasDB()

    Dim PeriodoNomina As New VB.SysContab.PeriodoNominaDB()

    Dim tblLogOnInfo As New TableLogOnInfo()
    Dim tblName As Table
    Dim Fechas As New VB.SysContab.FechasdeTrabajo

    Private Sub FrmPlanillaxContabilizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbTipoComp.DataSource = TComprobantes.GetTiposComprobantes.Tables("TipoComprobantes")
        cbTipoComp.ValueMember = "TipComp_Id"
        cbTipoComp.DisplayMember = "TipComp_Nombre"
        Me.cbTipoComp.SelectedIndex = 0

        Dim DT2 As New DataTable
        'DT2 = ObtieneDatos("SPSubCentroCosto")
        DT2 = ObtieneDatos("SELECT CAST(cdc.Codigo AS NVARCHAR(10)) Codigo, cdc.Nombre FROM CentroDeCosto cdc" _
                                                  + " WHERE cdc.Activo = 1 AND cdc.Empresa = " & EmpresaActual)

        Me.cbCCosto.DataSource = DT2
        cbCCosto.DisplayMember = "Nombre"
        cbCCosto.ValueMember = "Codigo"

        cbCCosto.ShowHeader = True
        cbCCosto.PopulateColumns()

        cbCCosto.PopupFormMinSize = New Point(800, 0)
        cbCCosto.Columns(0).Visible = False
        cbCCosto.NullText = ""

        Dim DT3 As New DataTable

        DT3 = ObtieneDatos("SELECT rg.Codigo, rg.Nombre FROM RubrosGastos rg WHERE rg.Activo = 1 AND rg.Empresa = " & EmpresaActual)
        Me.cbRubros.DataSource = DT3
        cbRubros.DisplayMember = "Nombre"
        cbRubros.ValueMember = "Codigo"
        cbRubros.ShowFooter = False
        cbRubros.ShowHeader = False
        cbRubros.PopulateColumns()
        cbRubros.PopupFormMinSize = New Point(800, 0)
        cbRubros.Columns(0).Visible = False
        cbRubros.NullText = ""


        Me.dtpFecha.MinDate = Fechas.FechaMinima
        Me.dtpFecha.MaxDate = Fechas.FechaMaxima

        Me.dtpFecha.Value = Rutinas.Fecha

        txtCodigo.Text = Codigo

        etDescripcionIngr.Text = etDescripcionIngr.Text & " " & Codigo

        Ds = VB.SysContab.PeriodoNominaDB.GetPlanilla(Codigo)

        dgPlanillas.DataSource = Ds.Tables("Tabla")
        Me.vPlanillas.PopulateColumns()
        Me.txtConcepto.Text = IsNull(Me.vPlanillas.GetRowCellValue(0, "concepto"), "")
        Me.vPlanillas.Columns("concepto").Visible = False
        Me.vPlanillas.Columns("cuenta").Caption = "Cuenta"
        Me.vPlanillas.Columns("debe").Caption = "Debe"
        Me.vPlanillas.Columns("haber").Caption = "Haber"
        Me.vPlanillas.Columns("comentario").Caption = "Comentario"

        Me.vPlanillas.Columns("debe").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vPlanillas.Columns("debe").DisplayFormat.FormatString = "n2"

        Me.vPlanillas.Columns("debe").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vPlanillas.Columns("debe").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vPlanillas.Columns("haber").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vPlanillas.Columns("haber").DisplayFormat.FormatString = "n2"

        Me.vPlanillas.Columns("haber").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vPlanillas.Columns("haber").SummaryItem.DisplayFormat = "{0:n2}"

        'Agregar una tabla con el detalle de la distribucion 
        Dim dt As New DataTable
        dt = VB.SysContab.PeriodoNominaDB.GetPlanilla_Distribucion(Codigo)
        Ds.Tables.Add(dt.Copy)
        Ds.Tables("Tabla").PrimaryKey = New DataColumn() {Ds.Tables("Tabla").Columns("id")}
        Ds.Tables("Distribucion").PrimaryKey = New DataColumn() {Ds.Tables("Distribucion").Columns("id")}

        Dim ParentCols() As DataColumn
        ParentCols = New DataColumn() {Ds.Tables("Tabla").Columns("id")}

        Dim ChildCols() As DataColumn
        ChildCols = New DataColumn() {Ds.Tables("Distribucion").Columns("padre")}

        Dim Relacion As DataRelation = Nothing
        Try
            Relacion = New DataRelation("Detalle", ParentCols, ChildCols)
        Catch ex As DataException
            MsgBox(ex.Message)
        End Try
        Ds.Relations.Add(Relacion)


    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click

        If Not XtraMsg2("Esta Seguro de Contabilizar la Planilla Seleccionada?") Then
            Exit Sub
        End If


        Dim Cat As New VB.SysContab.CatalogoDB()

        Dim Compr As New VB.SysContab.ComprobanteDB()
        Dim Parametro As Integer
        Parametro = Me.cbTipoComp.SelectedValue


        Dim i As Integer

        For i = 0 To Ds.Tables(0).Rows.Count - 1
            If Cat.GetCuenta(vPlanillas.GetRowCellValue(i, "cuenta"), "A").Tables(0).Rows.Count = 0 Then
                XtraMsg("La Cuenta " & Ds.Tables(0).Rows(i).Item("Descripcion") & " no ha sido configurada como Auxiliar")
                Exit Sub
            End If
        Next

        Dim TipoCompr, CompNo As Integer
        Dim Importe As Double
        Dim DC As String


        ' VALIDAR SI HAY UN TIPO DE COMPROBANTE
        Dim DsTipoCompr As New DataSet()
        DsTipoCompr = Compr.TiposComprobantesCheques()
        If DsTipoCompr.Tables(0).Rows.Count = 0 Then
            XtraMsg("Por Favor Configure los Tipo de Comprobantes", MessageBoxIcon.Warning)
            Exit Sub
        End If
        If Me.cbTipoComp.SelectedValue = Nothing Or Me.cbTipoComp.SelectedValue Is DBNull.Value Then
            XtraMsg("Seleccione el tipo de Comprobante", MessageBoxIcon.Error)
            Exit Sub
        End If
        TipoCompr = Me.cbTipoComp.SelectedValue

        ' VALIDAR SI HAY UN PERIODO ACTIVO
        If VB.SysContab.PeriodosDB.Activo(dtpFecha.Value) = 0 Then
            XtraMsg("Por Favor establezca un Periodo Activo", MessageBoxIcon.Error)
            Exit Sub
        End If


        DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()

        Try

            ShowSplash("Contabilizando Planilla...")

            CompNo = Compr.AddComprobante(TipoCompr, 1, txtConcepto.Text, VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, _
                                VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value), dtpFecha.Value, 0, "", False, 0, "", Parametro, Codigo, _
                                VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.PLANILLA)

            For i = 0 To vPlanillas.DataRowCount - 1
                Importe = 0
                If vPlanillas.GetRowCellValue(i, "debe") > 0 Then
                    Importe = vPlanillas.GetRowCellValue(i, "debe")
                    DC = "D"
                ElseIf vPlanillas.GetRowCellValue(i, "haber") > 0 Then
                    Importe = vPlanillas.GetRowCellValue(i, "haber")
                    DC = "C"

                End If

                If vPlanillas.GetRowCellValue(i, "debe") = 0 And vPlanillas.GetRowCellValue(i, "haber") = 0 Then
                    GoTo saltar
                End If

                Compr.AddComprobanteDetalles(CompNo, _
                   vPlanillas.GetRowCellValue(i, "cuenta"), _
                   vPlanillas.GetRowCellValue(i, "comentario"), _
                    Importe, 0, TipoCompr, DC, 0, 0, _
                    Me.dtpFecha.Value, 0)

saltar:
            Next

            'La distribucion
            For j As Integer = 0 To Ds.Tables("Distribucion").Rows.Count - 1
                GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,idsubcentro, IdCentroCosto,Valor,Tipo,Cuenta) " & _
                            " VALUES(" & EmpresaActual & "," & CompNo & "," & Me.dtpFecha.Value.Month & "," & _
                           VB.SysContab.PeriodosDB.Activo(Me.dtpFecha.Value.Date) & "," & _
                            Ds.Tables("Distribucion").Rows(j).Item("idrubrogasto") & "," & _
                            Ds.Tables("Distribucion").Rows(j).Item("idsubcentro") & "," & _
                            Ds.Tables("Distribucion").Rows(j).Item("idsubcentro") & "," & _
                            Ds.Tables("Distribucion").Rows(j).Item("valor") & ",'" & _
                            Ds.Tables("Distribucion").Rows(j).Item("tipo") & "','" & _
                            Ds.Tables("Distribucion").Rows(j).Item("cuenta") & "')")

            Next

            PeriodoNomina.Contabilizar(Codigo, Parametro)
            VB.SysContab.Rutinas.okTransaccion()

            HideSplash()

            XtraMsg("La Planilla se ha Conabilizado Correctamente!")
            Close()

            Dim f As FrmListaPlanillasContables = FrmListaPlanillasContables.Instance()
            If f.Created Then f.Cargar()
        Catch ex As Exception
            HideSplash()
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Exit Sub
        Finally
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim fReportes As New frmReportes()
        Dim Catalogo As New VB.SysContab.CatalogoDB()
        Dim Libros As New VB.SysContab.LibrosDB()
        Dim r As New VB.SysContab.RutinasNomina()

        Dim dsBalanza As New DataSet()
        Dim Periodo As New VB.SysContab.PeriodoDetails()
        Dim P As New VB.SysContab.PeriodosDB()
        Dim Fecha2 As Date
        Dim DetalleNivel As New VB.SysContab.NivelDetailsDB()
        Dim rNivel As Integer

        'Dim Reporte As New rptContabilizarNomina()

        Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Reporte.Load(Application.StartupPath & "\Reportes\rptContabilizarNomina.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        ''Reporte.SetDatabaseLogon(Usuario, UPassword, Server, DBName)
        'For Each tblName In Reporte.Database.Tables
        '    tblLogOnInfo = tblName.LogOnInfo
        '    'set connection parameters
        '    tblLogOnInfo.ConnectionInfo.DatabaseName = DBName
        '    tblLogOnInfo.ConnectionInfo.ServerName = Server
        '    tblLogOnInfo.ConnectionInfo.UserID = Usuario
        '    tblLogOnInfo.ConnectionInfo.Password = UPassword

        '    'apply the connection information to the table
        '    Try
        '        tblName.ApplyLogOnInfo(tblLogOnInfo)
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        Exit Sub
        '    End Try
        'Next

        'Reporte.SetParameterValue("@Empresa", EmpresaActual)
        'Reporte.SetParameterValue("@Codigo", Codigo)
        'fReportes.crvReportes.ReportSource = Reporte

        Dim Ds As New DataSet()

        Ds = VB.SysContab.PeriodoNominaDB.NominaxContabilizarList(Codigo)

        Ds.WriteXml(Application.StartupPath & "\xml\planillacontabilizar.xml", XmlWriteMode.WriteSchema)

        Reporte.Database.Tables("Tabla").Location = Application.StartupPath & "\xml\planillacontabilizar.xml"
        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"

        fReportes.crvReportes.ReportSource = Reporte

        fReportes.crvReportes.Zoom(91)
        fReportes.Show()
    End Sub

    Private Sub FrmPlanillaxContabilizar_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim F As FrmListaPlanillasContables = F.Instance

        Dim Ds As New DataSet()

        Ds = VB.SysContab.PeriodoNominaDB.GetListContabilizado(False, True, True, True)

        F.dgPlanillas.DataSource = Ds.Tables(0)


    End Sub

    Private Sub Vista_GridMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs) Handles vPlanillas.GridMenuItemClick
        Dim sumFormat As String
        Dim subSumFormat As Integer
        If e.MenuType <> GridMenuType.Summary Or e.DXMenuItem.Tag.Equals(GridStringId.MenuFooterCount) Then Exit Sub

        sumFormat = e.SummaryFormat
        subSumFormat = sumFormat.IndexOf("0")
        If subSumFormat > 0 Then sumFormat = sumFormat.Substring(0, subSumFormat) + "0:n2}"
        e.SummaryFormat = sumFormat



    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(dgPlanillas, Me.Text)
        'Dim f As New frmexportaciongrid
        'f.Mostrar(Me.dgPlanillas)
    End Sub

    Private Sub vPlanillas_MasterRowExpanded(sender As Object, e As CustomMasterRowEventArgs) Handles vPlanillas.MasterRowExpanded
        If sender.FocusedRowHandle >= 0 Then
            dVista = sender.GetVisibleDetailView(sender.FocusedRowHandle)
            If Not dVista Is Nothing Then
                dVista.OptionsBehavior.ReadOnly = True
                dVista.Columns("id").Visible = False
                dVista.Columns("padre").Visible = False

                dVista.Columns("idrubrogasto").ColumnEdit = Me.cbRubros
                dVista.Columns("idrubrogasto").Caption = "Rubro Gasto"

                dVista.Columns("idsubcentro").ColumnEdit = Me.cbCCosto
                dVista.Columns("idsubcentro").Caption = "Centro Costo"

                dVista.Columns("tipo").Caption = "Debito/Credito"
                dVista.Columns("cuenta").Caption = "Cuenta Contable"



                dVista.Columns("valor").Width = 80
                dVista.Columns("valor").OptionsColumn.ReadOnly = True
                dVista.Columns("valor").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                dVista.Columns("valor").DisplayFormat.FormatString = "n2"


                dVista.Columns("valor").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                dVista.Columns("valor").SummaryItem.DisplayFormat = "{0:n2}"
                dVista.BestFitColumns()
            End If
        End If
    End Sub
End Class
