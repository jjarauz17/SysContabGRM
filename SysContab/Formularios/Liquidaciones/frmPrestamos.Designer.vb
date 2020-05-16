<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrestamos
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Banco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LoanNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LoanAmount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.InterestRate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.StartDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.EndDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LoanID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Mes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SaldoInicial = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Amortizacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Interes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Mensualidad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cBancos = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.gbData = New System.Windows.Forms.GroupBox
        Me.cmdOtherCharges = New DevExpress.XtraEditors.SimpleButton
        Me.tbDocNo = New DevExpress.XtraEditors.TextEdit
        Me.dtFin = New DevExpress.XtraEditors.DateEdit
        Me.dtInicio = New DevExpress.XtraEditors.DateEdit
        Me.cbTipoLiq = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.ckLiquidar = New DevExpress.XtraEditors.CheckEdit
        Me.cbLiquidaciones = New DevExpress.XtraEditors.LookUpEdit
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.tbMeses = New DevExpress.XtraEditors.TextEdit
        Me.tbInteres = New DevExpress.XtraEditors.TextEdit
        Me.cmdCalc = New DevExpress.XtraEditors.SimpleButton
        Me.tbOtrosCargos = New DevExpress.XtraEditors.TextEdit
        Me.tbSaldoInicial = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cBancos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbData.SuspendLayout()
        CType(Me.tbDocNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoLiq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckLiquidar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLiquidaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMeses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbInteres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOtrosCargos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSaldoInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 134)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(861, 483)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.Banco, Me.LoanNo, Me.LoanAmount, Me.InterestRate, Me.StartDate, Me.EndDate})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.FieldName = "LoanID"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'Banco
        '
        Me.Banco.Caption = "Institucuión Financiera"
        Me.Banco.FieldName = "NOMBRE"
        Me.Banco.Name = "Banco"
        Me.Banco.Visible = True
        Me.Banco.VisibleIndex = 0
        '
        'LoanNo
        '
        Me.LoanNo.AppearanceHeader.Options.UseTextOptions = True
        Me.LoanNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LoanNo.Caption = "No."
        Me.LoanNo.FieldName = "LoanNo"
        Me.LoanNo.Name = "LoanNo"
        Me.LoanNo.Visible = True
        Me.LoanNo.VisibleIndex = 1
        '
        'LoanAmount
        '
        Me.LoanAmount.AppearanceCell.Options.UseTextOptions = True
        Me.LoanAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LoanAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.LoanAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LoanAmount.Caption = "Monto"
        Me.LoanAmount.DisplayFormat.FormatString = "n2"
        Me.LoanAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LoanAmount.FieldName = "LoanAmount"
        Me.LoanAmount.Name = "LoanAmount"
        Me.LoanAmount.Visible = True
        Me.LoanAmount.VisibleIndex = 2
        '
        'InterestRate
        '
        Me.InterestRate.AppearanceCell.Options.UseTextOptions = True
        Me.InterestRate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.InterestRate.AppearanceHeader.Options.UseTextOptions = True
        Me.InterestRate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.InterestRate.Caption = "Tasa de Interés"
        Me.InterestRate.DisplayFormat.FormatString = "p"
        Me.InterestRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.InterestRate.FieldName = "InterestRate"
        Me.InterestRate.Name = "InterestRate"
        Me.InterestRate.Visible = True
        Me.InterestRate.VisibleIndex = 3
        '
        'StartDate
        '
        Me.StartDate.AppearanceCell.Options.UseTextOptions = True
        Me.StartDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.StartDate.AppearanceHeader.Options.UseTextOptions = True
        Me.StartDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.StartDate.Caption = "Fecha Inicio"
        Me.StartDate.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.StartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.StartDate.FieldName = "StartDate"
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Visible = True
        Me.StartDate.VisibleIndex = 4
        '
        'EndDate
        '
        Me.EndDate.AppearanceCell.Options.UseTextOptions = True
        Me.EndDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EndDate.AppearanceHeader.Options.UseTextOptions = True
        Me.EndDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EndDate.Caption = "Fecha Fin"
        Me.EndDate.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.EndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.EndDate.FieldName = "EndDate"
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Visible = True
        Me.EndDate.VisibleIndex = 5
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.Location = New System.Drawing.Point(12, 361)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(861, 268)
        Me.GridControl2.TabIndex = 4
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.GridControl2.Visible = False
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.LoanID, Me.Mes, Me.SaldoInicial, Me.Amortizacion, Me.Interes, Me.Mensualidad, Me.GridColumn1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'LoanID
        '
        Me.LoanID.Caption = "GridColumn1"
        Me.LoanID.FieldName = "LoanID"
        Me.LoanID.Name = "LoanID"
        '
        'Mes
        '
        Me.Mes.Caption = "Cuota"
        Me.Mes.FieldName = "Mes"
        Me.Mes.Name = "Mes"
        Me.Mes.Visible = True
        Me.Mes.VisibleIndex = 0
        '
        'SaldoInicial
        '
        Me.SaldoInicial.Caption = "Saldo Inicial"
        Me.SaldoInicial.DisplayFormat.FormatString = "n2"
        Me.SaldoInicial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SaldoInicial.FieldName = "SaldoInicial"
        Me.SaldoInicial.Name = "SaldoInicial"
        Me.SaldoInicial.Visible = True
        Me.SaldoInicial.VisibleIndex = 1
        '
        'Amortizacion
        '
        Me.Amortizacion.Caption = "Principal"
        Me.Amortizacion.DisplayFormat.FormatString = "n2"
        Me.Amortizacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Amortizacion.FieldName = "Amortizacion"
        Me.Amortizacion.Name = "Amortizacion"
        Me.Amortizacion.SummaryItem.DisplayFormat = "{0:n2}"
        Me.Amortizacion.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Amortizacion.Visible = True
        Me.Amortizacion.VisibleIndex = 2
        '
        'Interes
        '
        Me.Interes.Caption = "Interes"
        Me.Interes.DisplayFormat.FormatString = "n2"
        Me.Interes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Interes.FieldName = "Interes"
        Me.Interes.Name = "Interes"
        Me.Interes.SummaryItem.DisplayFormat = "{0:n2}"
        Me.Interes.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Interes.Visible = True
        Me.Interes.VisibleIndex = 3
        '
        'Mensualidad
        '
        Me.Mensualidad.Caption = "Mensualidad"
        Me.Mensualidad.DisplayFormat.FormatString = "n2"
        Me.Mensualidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Mensualidad.FieldName = "Mensualidad"
        Me.Mensualidad.Name = "Mensualidad"
        Me.Mensualidad.SummaryItem.DisplayFormat = "{0:n2}"
        Me.Mensualidad.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Mensualidad.Visible = True
        Me.Mensualidad.VisibleIndex = 4
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Contabilizado"
        Me.GridColumn1.FieldName = "Contabilizado"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNuevo.Location = New System.Drawing.Point(798, 12)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Appearance.ForeColor = System.Drawing.Color.Red
        Me.cmdSalir.Appearance.Options.UseForeColor = True
        Me.cmdSalir.Location = New System.Drawing.Point(798, 41)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 2
        Me.cmdSalir.Text = "&Salir"
        '
        'cBancos
        '
        Me.cBancos.EnterMoveNextControl = True
        Me.cBancos.Location = New System.Drawing.Point(82, 15)
        Me.cBancos.Name = "cBancos"
        Me.cBancos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cBancos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 40, "Nombre")})
        Me.cBancos.Properties.NullText = ""
        Me.cBancos.Size = New System.Drawing.Size(255, 20)
        Me.cBancos.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(6, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Bancos"
        '
        'gbData
        '
        Me.gbData.Controls.Add(Me.cmdOtherCharges)
        Me.gbData.Controls.Add(Me.tbDocNo)
        Me.gbData.Controls.Add(Me.dtFin)
        Me.gbData.Controls.Add(Me.dtInicio)
        Me.gbData.Controls.Add(Me.cbTipoLiq)
        Me.gbData.Controls.Add(Me.LabelControl8)
        Me.gbData.Controls.Add(Me.LabelControl9)
        Me.gbData.Controls.Add(Me.LabelControl1)
        Me.gbData.Controls.Add(Me.ckLiquidar)
        Me.gbData.Controls.Add(Me.cBancos)
        Me.gbData.Controls.Add(Me.cbLiquidaciones)
        Me.gbData.Controls.Add(Me.Label23)
        Me.gbData.Controls.Add(Me.Label20)
        Me.gbData.Controls.Add(Me.tbMeses)
        Me.gbData.Controls.Add(Me.tbInteres)
        Me.gbData.Controls.Add(Me.cmdCalc)
        Me.gbData.Controls.Add(Me.tbOtrosCargos)
        Me.gbData.Controls.Add(Me.tbSaldoInicial)
        Me.gbData.Controls.Add(Me.LabelControl4)
        Me.gbData.Controls.Add(Me.LabelControl7)
        Me.gbData.Controls.Add(Me.LabelControl6)
        Me.gbData.Controls.Add(Me.LabelControl5)
        Me.gbData.Controls.Add(Me.LabelControl3)
        Me.gbData.Controls.Add(Me.LabelControl2)
        Me.gbData.Location = New System.Drawing.Point(12, 0)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(770, 128)
        Me.gbData.TabIndex = 0
        Me.gbData.TabStop = False
        Me.gbData.Visible = False
        '
        'cmdOtherCharges
        '
        Me.cmdOtherCharges.Location = New System.Drawing.Point(200, 97)
        Me.cmdOtherCharges.Name = "cmdOtherCharges"
        Me.cmdOtherCharges.Size = New System.Drawing.Size(75, 23)
        Me.cmdOtherCharges.TabIndex = 165
        Me.cmdOtherCharges.Text = "Agregar"
        '
        'tbDocNo
        '
        Me.tbDocNo.EnterMoveNextControl = True
        Me.tbDocNo.Location = New System.Drawing.Point(445, 14)
        Me.tbDocNo.Name = "tbDocNo"
        Me.tbDocNo.Size = New System.Drawing.Size(100, 20)
        Me.tbDocNo.TabIndex = 1
        '
        'dtFin
        '
        Me.dtFin.EditValue = Nothing
        Me.dtFin.EnterMoveNextControl = True
        Me.dtFin.Location = New System.Drawing.Point(613, 42)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFin.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.dtFin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFin.Properties.EditFormat.FormatString = "dd-MMM-yy"
        Me.dtFin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtFin.Properties.Mask.EditMask = "dd-MMM-yy"
        Me.dtFin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtFin.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtFin.Size = New System.Drawing.Size(100, 20)
        Me.dtFin.TabIndex = 5
        '
        'dtInicio
        '
        Me.dtInicio.EditValue = Nothing
        Me.dtInicio.EnterMoveNextControl = True
        Me.dtInicio.Location = New System.Drawing.Point(445, 42)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtInicio.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.dtInicio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtInicio.Properties.EditFormat.FormatString = "dd-MMM-yy"
        Me.dtInicio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtInicio.Properties.Mask.EditMask = "dd-MMM-yy"
        Me.dtInicio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.dtInicio.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtInicio.Size = New System.Drawing.Size(100, 20)
        Me.dtInicio.TabIndex = 4
        '
        'cbTipoLiq
        '
        Me.cbTipoLiq.EnterMoveNextControl = True
        Me.cbTipoLiq.Location = New System.Drawing.Point(237, 71)
        Me.cbTipoLiq.Name = "cbTipoLiq"
        Me.cbTipoLiq.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoLiq.Properties.Items.AddRange(New Object() {"Tránsito", "InBond", "Final"})
        Me.cbTipoLiq.Size = New System.Drawing.Size(100, 20)
        Me.cbTipoLiq.TabIndex = 7
        Me.cbTipoLiq.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(368, 18)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl8.TabIndex = 4
        Me.LabelControl8.Text = "No. Doc."
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(6, 104)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl9.TabIndex = 4
        Me.LabelControl9.Text = "Otros Cargos"
        '
        'ckLiquidar
        '
        Me.ckLiquidar.Location = New System.Drawing.Point(6, 71)
        Me.ckLiquidar.Name = "ckLiquidar"
        Me.ckLiquidar.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ckLiquidar.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ckLiquidar.Properties.Appearance.Options.UseFont = True
        Me.ckLiquidar.Properties.Appearance.Options.UseForeColor = True
        Me.ckLiquidar.Properties.Caption = "Agregar a liquidación"
        Me.ckLiquidar.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ckLiquidar.Size = New System.Drawing.Size(164, 20)
        Me.ckLiquidar.TabIndex = 6
        '
        'cbLiquidaciones
        '
        Me.cbLiquidaciones.EnterMoveNextControl = True
        Me.cbLiquidaciones.Location = New System.Drawing.Point(396, 70)
        Me.cbLiquidaciones.Name = "cbLiquidaciones"
        Me.cbLiquidaciones.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLiquidaciones.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.cbLiquidaciones.Properties.Appearance.Options.UseFont = True
        Me.cbLiquidaciones.Properties.Appearance.Options.UseForeColor = True
        Me.cbLiquidaciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLiquidaciones.Properties.NullText = ""
        Me.cbLiquidaciones.Properties.ShowFooter = False
        Me.cbLiquidaciones.Properties.ShowHeader = False
        Me.cbLiquidaciones.Size = New System.Drawing.Size(85, 20)
        Me.cbLiquidaciones.TabIndex = 8
        Me.cbLiquidaciones.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(365, 74)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 13)
        Me.Label23.TabIndex = 163
        Me.Label23.Text = "No:"
        Me.Label23.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(200, 75)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 13)
        Me.Label20.TabIndex = 164
        Me.Label20.Text = "Tipo:"
        Me.Label20.Visible = False
        '
        'tbMeses
        '
        Me.tbMeses.Location = New System.Drawing.Point(726, 67)
        Me.tbMeses.Name = "tbMeses"
        Me.tbMeses.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tbMeses.Properties.Appearance.Options.UseFont = True
        Me.tbMeses.Properties.Mask.EditMask = "n0"
        Me.tbMeses.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbMeses.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbMeses.Properties.NullText = "0"
        Me.tbMeses.Properties.ReadOnly = True
        Me.tbMeses.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbMeses.Size = New System.Drawing.Size(38, 21)
        Me.tbMeses.TabIndex = 9
        Me.tbMeses.TabStop = False
        '
        'tbInteres
        '
        Me.tbInteres.EnterMoveNextControl = True
        Me.tbInteres.Location = New System.Drawing.Point(295, 41)
        Me.tbInteres.Name = "tbInteres"
        Me.tbInteres.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tbInteres.Properties.Appearance.Options.UseFont = True
        Me.tbInteres.Properties.EditFormat.FormatString = "n2"
        Me.tbInteres.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbInteres.Properties.Mask.EditMask = "n2"
        Me.tbInteres.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbInteres.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbInteres.Properties.NullText = "0.00"
        Me.tbInteres.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbInteres.Size = New System.Drawing.Size(42, 21)
        Me.tbInteres.TabIndex = 3
        '
        'cmdCalc
        '
        Me.cmdCalc.Location = New System.Drawing.Point(689, 12)
        Me.cmdCalc.Name = "cmdCalc"
        Me.cmdCalc.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalc.TabIndex = 8
        Me.cmdCalc.Text = "&Calcular"
        '
        'tbOtrosCargos
        '
        Me.tbOtrosCargos.EnterMoveNextControl = True
        Me.tbOtrosCargos.Location = New System.Drawing.Point(82, 97)
        Me.tbOtrosCargos.Name = "tbOtrosCargos"
        Me.tbOtrosCargos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tbOtrosCargos.Properties.Appearance.Options.UseFont = True
        Me.tbOtrosCargos.Properties.EditFormat.FormatString = "n2"
        Me.tbOtrosCargos.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbOtrosCargos.Properties.Mask.EditMask = "n2"
        Me.tbOtrosCargos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbOtrosCargos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbOtrosCargos.Properties.NullText = "0.00"
        Me.tbOtrosCargos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbOtrosCargos.Size = New System.Drawing.Size(100, 21)
        Me.tbOtrosCargos.TabIndex = 2
        '
        'tbSaldoInicial
        '
        Me.tbSaldoInicial.EnterMoveNextControl = True
        Me.tbSaldoInicial.Location = New System.Drawing.Point(82, 41)
        Me.tbSaldoInicial.Name = "tbSaldoInicial"
        Me.tbSaldoInicial.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.tbSaldoInicial.Properties.Appearance.Options.UseFont = True
        Me.tbSaldoInicial.Properties.EditFormat.FormatString = "n2"
        Me.tbSaldoInicial.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tbSaldoInicial.Properties.Mask.EditMask = "n2"
        Me.tbSaldoInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tbSaldoInicial.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tbSaldoInicial.Properties.NullText = "0.00"
        Me.tbSaldoInicial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbSaldoInicial.Size = New System.Drawing.Size(100, 21)
        Me.tbSaldoInicial.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(341, 44)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(9, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "%"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(551, 44)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl7.TabIndex = 4
        Me.LabelControl7.Text = "Fecha Fin"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(368, 44)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl6.TabIndex = 4
        Me.LabelControl6.Text = "Fecha Inicio"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(726, 44)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Meses"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(200, 44)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Tasa de Interes"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(6, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "$ Préstamo"
        '
        'frmPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 641)
        Me.Controls.Add(Me.gbData)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmPrestamos"
        Me.Text = "Préstamos Bancarios"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cBancos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        CType(Me.tbDocNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoLiq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckLiquidar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLiquidaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMeses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbInteres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOtrosCargos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSaldoInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cBancos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gbData As System.Windows.Forms.GroupBox
    Friend WithEvents tbMeses As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbInteres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tbSaldoInicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCalc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbTipoLiq As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ckLiquidar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbLiquidaciones As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LoanID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaldoInicial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Amortizacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Interes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Mensualidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Mes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tbDocNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LoanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Banco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LoanAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InterestRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdOtherCharges As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbOtrosCargos As DevExpress.XtraEditors.TextEdit
End Class
