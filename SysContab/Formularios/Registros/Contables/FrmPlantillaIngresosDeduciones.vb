Imports System.Data.SqlClient
Public Class FrmPlantillaIngresosDeduciones
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmPlantillaIngresosDeduciones = Nothing

    Public Shared Function Instance() As FrmPlantillaIngresosDeduciones
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmPlantillaIngresosDeduciones
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbTipoIngr As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipoDeducc As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigoIngr As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoDeducc As System.Windows.Forms.TextBox
    Friend WithEvents etDescripcionIngr As System.Windows.Forms.Label
    Friend WithEvents etDescripcionDeducc As System.Windows.Forms.Label
    Friend WithEvents cbCtaContableIngr As System.Windows.Forms.ComboBox
    Friend WithEvents cbCtaContableDeducc As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbTipoRubro As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigoRubro As System.Windows.Forms.TextBox
    Friend WithEvents etDescripcionRubro As System.Windows.Forms.Label
    Friend WithEvents cbCtaContableRubroDeb As System.Windows.Forms.ComboBox
    Friend WithEvents cbCtaContableRubroCred As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gcPlantilla As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPlantilla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dep_nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tipoMovimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Movimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbCuentas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SBIngresos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBDeducciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SbRubros As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbCtaContableIngr = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbTipoIngr = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.etDescripcionIngr = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigoIngr = New System.Windows.Forms.TextBox
        Me.cbCtaContableDeducc = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbTipoDeducc = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCodigoDeducc = New System.Windows.Forms.TextBox
        Me.etDescripcionDeducc = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbCtaContableRubroDeb = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbTipoRubro = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCodigoRubro = New System.Windows.Forms.TextBox
        Me.etDescripcionRubro = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbCtaContableRubroCred = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.gcPlantilla = New DevExpress.XtraGrid.GridControl
        Me.gvPlantilla = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.dep_nombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tipoMovimiento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Movimiento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Cuenta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cbCuentas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.SbRubros = New DevExpress.XtraEditors.SimpleButton
        Me.SBDeducciones = New DevExpress.XtraEditors.SimpleButton
        Me.SBIngresos = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.gcPlantilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPlantilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCtaContableIngr
        '
        Me.cbCtaContableIngr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCtaContableIngr.Location = New System.Drawing.Point(139, 112)
        Me.cbCtaContableIngr.Name = "cbCtaContableIngr"
        Me.cbCtaContableIngr.Size = New System.Drawing.Size(344, 23)
        Me.cbCtaContableIngr.TabIndex = 148
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(16, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 26)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Cuenta Debito:"
        '
        'cbTipoIngr
        '
        Me.cbTipoIngr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoIngr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoIngr.Location = New System.Drawing.Point(139, 78)
        Me.cbTipoIngr.Name = "cbTipoIngr"
        Me.cbTipoIngr.Size = New System.Drawing.Size(344, 23)
        Me.cbTipoIngr.TabIndex = 142
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Descripción:"
        '
        'etDescripcionIngr
        '
        Me.etDescripcionIngr.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcionIngr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcionIngr.ForeColor = System.Drawing.Color.White
        Me.etDescripcionIngr.Location = New System.Drawing.Point(16, 17)
        Me.etDescripcionIngr.Name = "etDescripcionIngr"
        Me.etDescripcionIngr.Size = New System.Drawing.Size(599, 22)
        Me.etDescripcionIngr.TabIndex = 138
        Me.etDescripcionIngr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 26)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Código:"
        '
        'txtCodigoIngr
        '
        Me.txtCodigoIngr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoIngr.Enabled = False
        Me.txtCodigoIngr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoIngr.Location = New System.Drawing.Point(139, 52)
        Me.txtCodigoIngr.MaxLength = 14
        Me.txtCodigoIngr.Name = "txtCodigoIngr"
        Me.txtCodigoIngr.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigoIngr.TabIndex = 135
        '
        'cbCtaContableDeducc
        '
        Me.cbCtaContableDeducc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCtaContableDeducc.Location = New System.Drawing.Point(139, 241)
        Me.cbCtaContableDeducc.Name = "cbCtaContableDeducc"
        Me.cbCtaContableDeducc.Size = New System.Drawing.Size(344, 23)
        Me.cbCtaContableDeducc.TabIndex = 158
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 26)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Cuenta Credito:"
        '
        'cbTipoDeducc
        '
        Me.cbTipoDeducc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDeducc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoDeducc.Location = New System.Drawing.Point(139, 207)
        Me.cbTipoDeducc.Name = "cbTipoDeducc"
        Me.cbTipoDeducc.Size = New System.Drawing.Size(344, 23)
        Me.cbTipoDeducc.TabIndex = 156
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(16, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 26)
        Me.Label9.TabIndex = 154
        Me.Label9.Text = "Descripción:"
        '
        'txtCodigoDeducc
        '
        Me.txtCodigoDeducc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoDeducc.Enabled = False
        Me.txtCodigoDeducc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoDeducc.Location = New System.Drawing.Point(139, 181)
        Me.txtCodigoDeducc.MaxLength = 14
        Me.txtCodigoDeducc.Name = "txtCodigoDeducc"
        Me.txtCodigoDeducc.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigoDeducc.TabIndex = 149
        '
        'etDescripcionDeducc
        '
        Me.etDescripcionDeducc.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcionDeducc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcionDeducc.ForeColor = System.Drawing.Color.White
        Me.etDescripcionDeducc.Location = New System.Drawing.Point(16, 146)
        Me.etDescripcionDeducc.Name = "etDescripcionDeducc"
        Me.etDescripcionDeducc.Size = New System.Drawing.Size(599, 22)
        Me.etDescripcionDeducc.TabIndex = 152
        Me.etDescripcionDeducc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(16, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 26)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "Código:"
        '
        'cbCtaContableRubroDeb
        '
        Me.cbCtaContableRubroDeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCtaContableRubroDeb.Location = New System.Drawing.Point(139, 362)
        Me.cbCtaContableRubroDeb.Name = "cbCtaContableRubroDeb"
        Me.cbCtaContableRubroDeb.Size = New System.Drawing.Size(344, 23)
        Me.cbCtaContableRubroDeb.TabIndex = 167
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Cuenta Debito:"
        '
        'cbTipoRubro
        '
        Me.cbTipoRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoRubro.Location = New System.Drawing.Point(139, 327)
        Me.cbTipoRubro.Name = "cbTipoRubro"
        Me.cbTipoRubro.Size = New System.Drawing.Size(344, 23)
        Me.cbTipoRubro.TabIndex = 165
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 26)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "Descripción:"
        '
        'txtCodigoRubro
        '
        Me.txtCodigoRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoRubro.Enabled = False
        Me.txtCodigoRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoRubro.Location = New System.Drawing.Point(139, 302)
        Me.txtCodigoRubro.MaxLength = 14
        Me.txtCodigoRubro.Name = "txtCodigoRubro"
        Me.txtCodigoRubro.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigoRubro.TabIndex = 161
        '
        'etDescripcionRubro
        '
        Me.etDescripcionRubro.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcionRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcionRubro.ForeColor = System.Drawing.Color.White
        Me.etDescripcionRubro.Location = New System.Drawing.Point(16, 276)
        Me.etDescripcionRubro.Name = "etDescripcionRubro"
        Me.etDescripcionRubro.Size = New System.Drawing.Size(599, 21)
        Me.etDescripcionRubro.TabIndex = 163
        Me.etDescripcionRubro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(16, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 25)
        Me.Label8.TabIndex = 162
        Me.Label8.Text = "Código:"
        '
        'cbCtaContableRubroCred
        '
        Me.cbCtaContableRubroCred.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCtaContableRubroCred.Location = New System.Drawing.Point(139, 396)
        Me.cbCtaContableRubroCred.Name = "cbCtaContableRubroCred"
        Me.cbCtaContableRubroCred.Size = New System.Drawing.Size(344, 23)
        Me.cbCtaContableRubroCred.TabIndex = 170
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(16, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 26)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Cuenta Crédito:"
        '
        'gcPlantilla
        '
        Me.gcPlantilla.Location = New System.Drawing.Point(16, 9)
        Me.gcPlantilla.MainView = Me.gvPlantilla
        Me.gcPlantilla.Name = "gcPlantilla"
        Me.gcPlantilla.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbCuentas})
        Me.gcPlantilla.Size = New System.Drawing.Size(752, 491)
        Me.gcPlantilla.TabIndex = 171
        Me.gcPlantilla.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPlantilla})
        '
        'gvPlantilla
        '
        Me.gvPlantilla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.dep_nombre, Me.tipoMovimiento, Me.Movimiento, Me.DC, Me.Cuenta})
        Me.gvPlantilla.GridControl = Me.gcPlantilla
        Me.gvPlantilla.GroupCount = 2
        Me.gvPlantilla.Name = "gvPlantilla"
        Me.gvPlantilla.OptionsView.ShowChildrenInGroupPanel = True
        Me.gvPlantilla.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.dep_nombre, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.tipoMovimiento, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'dep_nombre
        '
        Me.dep_nombre.Caption = "Departamento"
        Me.dep_nombre.FieldName = "dep_nombre"
        Me.dep_nombre.Name = "dep_nombre"
        Me.dep_nombre.OptionsColumn.AllowEdit = False
        Me.dep_nombre.Visible = True
        Me.dep_nombre.VisibleIndex = 0
        Me.dep_nombre.Width = 166
        '
        'tipoMovimiento
        '
        Me.tipoMovimiento.Caption = "Tipo Movimiento"
        Me.tipoMovimiento.FieldName = "tMovimiento"
        Me.tipoMovimiento.Name = "tipoMovimiento"
        Me.tipoMovimiento.Visible = True
        Me.tipoMovimiento.VisibleIndex = 1
        Me.tipoMovimiento.Width = 126
        '
        'Movimiento
        '
        Me.Movimiento.Caption = "Movimiento"
        Me.Movimiento.FieldName = "Movimiento"
        Me.Movimiento.Name = "Movimiento"
        Me.Movimiento.Visible = True
        Me.Movimiento.VisibleIndex = 0
        Me.Movimiento.Width = 216
        '
        'DC
        '
        Me.DC.Caption = "Débito/Crédito"
        Me.DC.FieldName = "DC"
        Me.DC.Name = "DC"
        Me.DC.OptionsColumn.AllowEdit = False
        Me.DC.Visible = True
        Me.DC.VisibleIndex = 1
        Me.DC.Width = 74
        '
        'Cuenta
        '
        Me.Cuenta.Caption = "Cuenta"
        Me.Cuenta.ColumnEdit = Me.cbCuentas
        Me.Cuenta.FieldName = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Visible = True
        Me.Cuenta.VisibleIndex = 2
        Me.Cuenta.Width = 250
        '
        'cbCuentas
        '
        Me.cbCuentas.AutoHeight = False
        Me.cbCuentas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCuentas.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUENTA", 25, "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", 50, "Nombre")})
        Me.cbCuentas.DisplayMember = "NOMBRE"
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.ValueMember = "CUENTA"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(776, 457)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(88, 34)
        Me.cmdAceptar.TabIndex = 173
        Me.cmdAceptar.Text = "Guardar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(10, 404)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(88, 35)
        Me.cmdSalir.TabIndex = 174
        Me.cmdSalir.Text = "Salir"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(16, 9)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(880, 480)
        Me.XtraTabControl1.TabIndex = 175
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.XtraTabPage1.Appearance.Header.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.XtraTabPage1.Appearance.Header.Options.UseBackColor = True
        Me.XtraTabPage1.Appearance.HeaderActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.XtraTabPage1.Appearance.HeaderActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.XtraTabPage1.Appearance.HeaderActive.Options.UseBackColor = True
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Transparent
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.SbRubros)
        Me.XtraTabPage1.Controls.Add(Me.SBDeducciones)
        Me.XtraTabPage1.Controls.Add(Me.SBIngresos)
        Me.XtraTabPage1.Controls.Add(Me.cbCtaContableIngr)
        Me.XtraTabPage1.Controls.Add(Me.Label6)
        Me.XtraTabPage1.Controls.Add(Me.cbTipoIngr)
        Me.XtraTabPage1.Controls.Add(Me.Label2)
        Me.XtraTabPage1.Controls.Add(Me.etDescripcionIngr)
        Me.XtraTabPage1.Controls.Add(Me.Label1)
        Me.XtraTabPage1.Controls.Add(Me.txtCodigoIngr)
        Me.XtraTabPage1.Controls.Add(Me.cbCtaContableDeducc)
        Me.XtraTabPage1.Controls.Add(Me.Label7)
        Me.XtraTabPage1.Controls.Add(Me.cbTipoDeducc)
        Me.XtraTabPage1.Controls.Add(Me.Label9)
        Me.XtraTabPage1.Controls.Add(Me.txtCodigoDeducc)
        Me.XtraTabPage1.Controls.Add(Me.etDescripcionDeducc)
        Me.XtraTabPage1.Controls.Add(Me.Label11)
        Me.XtraTabPage1.Controls.Add(Me.cbCtaContableRubroDeb)
        Me.XtraTabPage1.Controls.Add(Me.Label3)
        Me.XtraTabPage1.Controls.Add(Me.cbTipoRubro)
        Me.XtraTabPage1.Controls.Add(Me.Label4)
        Me.XtraTabPage1.Controls.Add(Me.txtCodigoRubro)
        Me.XtraTabPage1.Controls.Add(Me.etDescripcionRubro)
        Me.XtraTabPage1.Controls.Add(Me.Label8)
        Me.XtraTabPage1.Controls.Add(Me.cbCtaContableRubroCred)
        Me.XtraTabPage1.Controls.Add(Me.Label5)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(871, 449)
        Me.XtraTabPage1.Text = "Plantilla Planilla Consolidada"
        '
        'SbRubros
        '
        Me.SbRubros.Location = New System.Drawing.Point(507, 379)
        Me.SbRubros.Name = "SbRubros"
        Me.SbRubros.Size = New System.Drawing.Size(88, 35)
        Me.SbRubros.TabIndex = 177
        Me.SbRubros.Text = "Actualizar"
        '
        'SBDeducciones
        '
        Me.SBDeducciones.Location = New System.Drawing.Point(507, 233)
        Me.SBDeducciones.Name = "SBDeducciones"
        Me.SBDeducciones.Size = New System.Drawing.Size(88, 34)
        Me.SBDeducciones.TabIndex = 176
        Me.SBDeducciones.Text = "Actualizar"
        '
        'SBIngresos
        '
        Me.SBIngresos.Location = New System.Drawing.Point(507, 103)
        Me.SBIngresos.Name = "SBIngresos"
        Me.SBIngresos.Size = New System.Drawing.Size(88, 35)
        Me.SBIngresos.TabIndex = 175
        Me.SBIngresos.Text = "Actualizar"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.gcPlantilla)
        Me.XtraTabPage2.Controls.Add(Me.cmdAceptar)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(871, 449)
        Me.XtraTabPage2.Text = "Plantilla Planilla Departamentalizada"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(904, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 457)
        Me.GroupBox1.TabIndex = 176
        Me.GroupBox1.TabStop = False
        '
        'FrmPlantillaIngresosDeduciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1016, 496)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "FrmPlantillaIngresosDeduciones"
        Me.Text = "Plantilla de Planilla"
        CType(Me.gcPlantilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPlantilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim TIngreso As New VB.SysContab.TipoIngresoDB
    Dim TDeduccion As New VB.SysContab.TipoDeduccionDB
    Dim TRubro As New VB.SysContab.TipoRubroDB
    Dim TMovimiento As New VB.SysContab.TipoMovimientoDB
    Dim Catalogo As New VB.SysContab.CatalogoDB
    Dim Rut As New VB.SysContab.Rutinas

    Private Sub FrmPlantillaIngresosDeduciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Rut.CambiarEstilo(Me)

        Me.cbCtaContableIngr.DataSource = Catalogo.GetList_SPTipo256("A", 56).Tables("Catalogo")
        Me.cbCtaContableIngr.ValueMember = "CUENTA"
        Me.cbCtaContableIngr.DisplayMember = "NOMBRE"

        Me.cbCtaContableDeducc.DataSource = Catalogo.GetList_SPTipo256("A", 2).Tables("Catalogo")
        Me.cbCtaContableDeducc.ValueMember = "CUENTA"
        Me.cbCtaContableDeducc.DisplayMember = "NOMBRE"

        Me.cbCtaContableRubroDeb.DataSource = Catalogo.GetList_SPTipo256("A", 56).Tables("Catalogo")
        Me.cbCtaContableRubroDeb.ValueMember = "CUENTA"
        Me.cbCtaContableRubroDeb.DisplayMember = "NOMBRE"

        Me.cbCtaContableRubroCred.DataSource = Catalogo.GetList_SPTipo256("A", 2).Tables("Catalogo")
        Me.cbCtaContableRubroCred.ValueMember = "CUENTA"
        Me.cbCtaContableRubroCred.DisplayMember = "NOMBRE"


        Me.cbTipoIngr.DataSource = TIngreso.GetList("%").Tables("TipoIngreso")
        Me.cbTipoIngr.ValueMember = "Codigo"
        Me.cbTipoIngr.DisplayMember = "Descripcion"

        Me.cbTipoDeducc.DataSource = TDeduccion.GetList("%").Tables("TipoDeduccion")
        Me.cbTipoDeducc.ValueMember = "Codigo"
        Me.cbTipoDeducc.DisplayMember = "Descripcion"

        Me.cbTipoRubro.DataSource = TRubro.GetList().Tables(0)
        Me.cbTipoRubro.ValueMember = "Codigo"
        Me.cbTipoRubro.DisplayMember = "Descripcion"

        Rut.ComboAutoComplete(cbCtaContableIngr)
        Rut.ComboAutoComplete(cbCtaContableDeducc)
        Rut.ComboAutoComplete(cbCtaContableRubroCred)
        Rut.ComboAutoComplete(cbCtaContableRubroDeb)

        Me.etDescripcionIngr.Text = "Editar Tipo de Ingreso".ToUpper
        Me.etDescripcionDeducc.Text = "Editar Tipo de Deducción".ToUpper
        Me.etDescripcionRubro.Text = "Editar Tipo de Rubro Empresa".ToUpper

        'Lo nuevo
        Dim lds As New DataSet
        lds = VB.SysContab.CatalogoDB.GetList_SP("%")
        Me.cbCuentas.DataSource = lds.Tables(0)
        Me.gcPlantilla.DataSource = VB.SysContab.PlantillaPlanillaDB.GetList("%").Tables("PlantillaPlanilla_Departamento")

        Me.Refresh()

    End Sub

    Private Sub cbTipoIngr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoIngr.SelectedIndexChanged
        If IsNumeric(cbTipoIngr.SelectedValue) = True Then
            Me.txtCodigoIngr.Text = cbTipoIngr.SelectedValue
            cbCtaContableIngr.SelectedValue = TIngreso.GetListCodigo(cbTipoIngr.SelectedValue).Tables(0).Rows(0).Item("Cuenta")
        End If
    End Sub

    Private Sub cbTipoDeducc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoDeducc.SelectedIndexChanged
        If IsNumeric(cbTipoDeducc.SelectedValue) = True Then
            Me.txtCodigoDeducc.Text = cbTipoDeducc.SelectedValue
            cbCtaContableDeducc.SelectedValue = TDeduccion.GetListCodigo(cbTipoDeducc.SelectedValue).Tables(0).Rows(0).Item("Cuenta")
        End If
    End Sub

    Private Sub cbTipoRubro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoRubro.SelectedIndexChanged
        If IsNumeric(cbTipoRubro.SelectedValue) = True Then
            Me.txtCodigoRubro.Text = cbTipoRubro.SelectedValue
            Me.cbCtaContableRubroDeb.SelectedValue = TRubro.GetListCodigo(cbTipoRubro.SelectedValue).Tables(0).Rows(0).Item("Cuenta")
            Me.cbCtaContableRubroCred.SelectedValue = TRubro.GetListCodigo(cbTipoRubro.SelectedValue).Tables(0).Rows(0).Item("CuentaCredito")
        End If
    End Sub


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim i As Integer

        If Me.gvPlantilla.DataSource.table.rows.count > 0 Then
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Try
                For i = 0 To Me.gvPlantilla.DataSource.table.rows.count - 1
                    'Buscar si ya esta grabado
                    Dim Valor As Integer = VB.SysContab.PlantillaPlanillaDB.Buscar(Me.gvPlantilla.DataSource.table.rows(i).item("dep_codigo"), _
                                                    Me.gvPlantilla.DataSource.table.rows(i).item("mov_codigo"), _
                                                    Me.gvPlantilla.DataSource.table.rows(i).item("mov_tipo"))
                    If Valor = 0 Then
                        If Not (Me.gvPlantilla.DataSource.table.rows(i).item("DC") = "" Or _
                            Me.gvPlantilla.DataSource.table.rows(i).item("DC") Is Nothing Or _
                            Me.gvPlantilla.DataSource.table.rows(i).item("Cuenta") = "" Or _
                            Me.gvPlantilla.DataSource.table.rows(i).item("Cuenta") Is Nothing) Then

                            VB.SysContab.PlantillaPlanillaDB.Add(Me.gvPlantilla.DataSource.table.rows(i).item("dep_codigo"), _
                                    Me.gvPlantilla.DataSource.table.rows(i).item("mov_codigo"), _
                                    Me.gvPlantilla.DataSource.table.rows(i).item("mov_tipo"), _
                                    Me.gvPlantilla.DataSource.table.rows(i).item("DC"), _
                                    Me.gvPlantilla.DataSource.table.rows(i).item("Cuenta"))
                        End If
                    ElseIf Valor = 1 Then
                        If Not (Me.gvPlantilla.DataSource.table.rows(i).item("DC") Is Nothing Or _
                                Me.gvPlantilla.DataSource.table.rows(i).item("Cuenta") Is Nothing) Then

                            VB.SysContab.PlantillaPlanillaDB.Update(Me.gvPlantilla.DataSource.table.rows(i).item("dep_codigo"), _
                                    Me.gvPlantilla.DataSource.table.rows(i).item("mov_codigo"), _
                                    Me.gvPlantilla.DataSource.table.rows(i).item("mov_tipo"), _
                                    Me.gvPlantilla.DataSource.table.rows(i).item("DC"), _
                                    Me.gvPlantilla.DataSource.table.rows(i).item("Cuenta"))
                        End If
                    ElseIf Valor = -1 Then 'Se encontro un error
                        MsgBox("No se pudo encontrar el registro. Revise sus datos por favor", MsgBoxStyle.Critical, "STS-Contab")
                        VB.SysContab.Rutinas.ErrorTransaccion()
                        Exit Sub
                    End If
                Next
                VB.SysContab.Rutinas.okTransaccion()
                Me.Close()
            Catch ex As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub SBIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBIngresos.Click
        If cbCtaContableIngr.SelectedValue Is Nothing Or cbCtaContableIngr.SelectedValue Is DBNull.Value Then
            MsgBox("Seleccione la cuenta contable")
            Exit Sub
        End If
        TIngreso.Update(cbTipoIngr.SelectedValue, cbCtaContableIngr.SelectedValue)
    End Sub

    Private Sub SBDeducciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBDeducciones.Click
        If cbCtaContableDeducc.SelectedValue Is Nothing Or cbCtaContableDeducc.SelectedValue Is DBNull.Value Then
            MsgBox("Seleccione la cuenta contable")
            Exit Sub
        End If
        TDeduccion.UpdateCuenta(cbTipoDeducc.SelectedValue, cbCtaContableDeducc.SelectedValue)
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SbRubros.Click
        If cbCtaContableRubroDeb.SelectedValue Is Nothing Or cbCtaContableRubroDeb.SelectedValue Is DBNull.Value Or Me.cbCtaContableRubroCred.SelectedValue Is Nothing Or Me.cbCtaContableRubroCred.SelectedValue Is DBNull.Value Then
            MsgBox("Seleccione la cuenta contable")
            Exit Sub
        End If
        TRubro.Update(cbTipoRubro.SelectedValue, Me.cbCtaContableRubroDeb.SelectedValue, Me.cbCtaContableRubroCred.SelectedValue)
    End Sub
End Class
