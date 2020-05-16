Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmInversiones
    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As frmInversiones = Nothing

    Public Shared Function Instance() As frmInversiones
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmInversiones
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
#Region " Windows Form Designer generated code "

    Public Sub New()
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents cmdDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtInteres As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtInstitucion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtValor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdimprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdbuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdnuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtfechalimite As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkanual As System.Windows.Forms.CheckBox
    Friend WithEvents cmbmoneda As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbBancos = New System.Windows.Forms.ComboBox()
        Me.cmdDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtInteres = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtInstitucion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPlazo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdimprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdbuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdnuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtfechalimite = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbmoneda = New System.Windows.Forms.ComboBox()
        Me.chkanual = New System.Windows.Forms.CheckBox()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(20, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 26)
        Me.Label7.TabIndex = 185
        Me.Label7.Text = "Seleccione Banco"
        '
        'cmbBancos
        '
        Me.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBancos.Location = New System.Drawing.Point(164, 95)
        Me.cmbBancos.Name = "cmbBancos"
        Me.cmbBancos.Size = New System.Drawing.Size(288, 21)
        Me.cmbBancos.TabIndex = 5
        '
        'cmdDetalle
        '
        Me.cmdDetalle.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDetalle.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdDetalle.Appearance.Options.UseFont = True
        Me.cmdDetalle.Appearance.Options.UseForeColor = True
        Me.cmdDetalle.Location = New System.Drawing.Point(528, 129)
        Me.cmdDetalle.Name = "cmdDetalle"
        Me.cmdDetalle.Size = New System.Drawing.Size(75, 25)
        Me.cmdDetalle.TabIndex = 6
        Me.cmdDetalle.Text = "&Detalle"
        '
        'TxtInteres
        '
        Me.TxtInteres.Location = New System.Drawing.Point(520, 26)
        Me.TxtInteres.Name = "TxtInteres"
        Me.TxtInteres.Size = New System.Drawing.Size(72, 21)
        Me.TxtInteres.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(424, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 180
        Me.Label6.Text = "Interes Anual % "
        '
        'TxtInstitucion
        '
        Me.TxtInstitucion.Location = New System.Drawing.Point(164, 60)
        Me.TxtInstitucion.Name = "TxtInstitucion"
        Me.TxtInstitucion.Size = New System.Drawing.Size(288, 21)
        Me.TxtInstitucion.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 26)
        Me.Label5.TabIndex = 178
        Me.Label5.Text = "Nombre de la Institución"
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(664, 26)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(96, 21)
        Me.TxtValor.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(616, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 26)
        Me.Label4.TabIndex = 176
        Me.Label4.Text = "Valor "
        '
        'TxtPlazo
        '
        Me.TxtPlazo.Location = New System.Drawing.Point(344, 26)
        Me.TxtPlazo.MaxLength = 4
        Me.TxtPlazo.Name = "TxtPlazo"
        Me.TxtPlazo.Size = New System.Drawing.Size(72, 21)
        Me.TxtPlazo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 26)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Fecha Inicial"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(168, 26)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(104, 20)
        Me.txtFecha.TabIndex = 0
        Me.txtFecha.Value = New Date(2007, 5, 7, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(296, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 26)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Plazo"
        '
        'cmdsalir
        '
        Me.cmdsalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsalir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdsalir.Appearance.Options.UseFont = True
        Me.cmdsalir.Appearance.Options.UseForeColor = True
        Me.cmdsalir.Location = New System.Drawing.Point(688, 129)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(75, 25)
        Me.cmdsalir.TabIndex = 8
        Me.cmdsalir.Text = "&Salir"
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(16, 164)
        Me.GridDetalle.MainView = Me.GridView2
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.Size = New System.Drawing.Size(743, 232)
        Me.GridDetalle.TabIndex = 9
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'GridView2
        '
        Me.GridView2.ActiveFilterEnabled = False
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GridView2.GridControl = Me.GridDetalle
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.ViewCaption = "Detalle de Inversion"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "No"
        Me.GridColumn1.DisplayFormat.FormatString = "d"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn1.FieldName = "No"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn1.OptionsFilter.AllowFilter = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 54
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.DisplayFormat.FormatString = "D"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn2.OptionsFilter.AllowFilter = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 279
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Interes Anual"
        Me.GridColumn3.DisplayFormat.FormatString = "{0:#,#.00}"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Interes"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 115
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Monto"
        Me.GridColumn4.DisplayFormat.FormatString = "{0:#,#.00}"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Monto"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn4.OptionsFilter.AllowFilter = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 119
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Monto Inicial"
        Me.GridColumn5.DisplayFormat.FormatString = "{0:#,#.00}"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "MontoIni"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 100
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridDetalle
        Me.GridView1.Name = "GridView1"
        '
        'cmdimprimir
        '
        Me.cmdimprimir.Location = New System.Drawing.Point(608, 129)
        Me.cmdimprimir.Name = "cmdimprimir"
        Me.cmdimprimir.Size = New System.Drawing.Size(75, 25)
        Me.cmdimprimir.TabIndex = 7
        Me.cmdimprimir.Text = "&Imprimir"
        '
        'cmdguardar
        '
        Me.cmdguardar.Location = New System.Drawing.Point(528, 95)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(75, 25)
        Me.cmdguardar.TabIndex = 186
        Me.cmdguardar.Text = "&Guardar"
        '
        'cmdbuscar
        '
        Me.cmdbuscar.Location = New System.Drawing.Point(608, 95)
        Me.cmdbuscar.Name = "cmdbuscar"
        Me.cmdbuscar.Size = New System.Drawing.Size(75, 25)
        Me.cmdbuscar.TabIndex = 187
        Me.cmdbuscar.Text = "&Buscar"
        '
        'cmdnuevo
        '
        Me.cmdnuevo.Location = New System.Drawing.Point(688, 95)
        Me.cmdnuevo.Name = "cmdnuevo"
        Me.cmdnuevo.Size = New System.Drawing.Size(75, 25)
        Me.cmdnuevo.TabIndex = 188
        Me.cmdnuevo.Text = "Nuevo"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(356, 17)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "Intereses Devengados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(15, 431)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(356, 17)
        Me.Label8.TabIndex = 189
        Me.Label8.Text = "Interes 10%"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(399, 405)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(356, 17)
        Me.Label9.TabIndex = 189
        Me.Label9.Text = "Intereses Netos"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(399, 431)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(356, 17)
        Me.Label10.TabIndex = 189
        Me.Label10.Text = "Total a Recibir"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(24, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 17)
        Me.Label11.TabIndex = 173
        Me.Label11.Text = "Fecha Limite Retiro"
        '
        'txtfechalimite
        '
        Me.txtfechalimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfechalimite.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfechalimite.Location = New System.Drawing.Point(168, 129)
        Me.txtfechalimite.Name = "txtfechalimite"
        Me.txtfechalimite.Size = New System.Drawing.Size(104, 20)
        Me.txtfechalimite.TabIndex = 6
        Me.txtfechalimite.Value = New Date(2007, 5, 7, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(472, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 18)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Moneda"
        '
        'cmbmoneda
        '
        Me.cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmoneda.Location = New System.Drawing.Point(528, 60)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Size = New System.Drawing.Size(232, 21)
        Me.cmbmoneda.TabIndex = 191
        '
        'chkanual
        '
        Me.chkanual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkanual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkanual.Location = New System.Drawing.Point(344, 129)
        Me.chkanual.Name = "chkanual"
        Me.chkanual.Size = New System.Drawing.Size(104, 26)
        Me.chkanual.TabIndex = 192
        Me.chkanual.Text = "Detalle Anual"
        '
        'frmInversiones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(775, 454)
        Me.Controls.Add(Me.chkanual)
        Me.Controls.Add(Me.cmbmoneda)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdnuevo)
        Me.Controls.Add(Me.cmdbuscar)
        Me.Controls.Add(Me.cmdguardar)
        Me.Controls.Add(Me.cmdimprimir)
        Me.Controls.Add(Me.GridDetalle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbBancos)
        Me.Controls.Add(Me.cmdDetalle)
        Me.Controls.Add(Me.TxtInteres)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtInstitucion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPlazo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtfechalimite)
        Me.Name = "frmInversiones"
        Me.Text = "Calculo de Inversiones"
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim DS As DataSet
    Public Inversion As Integer = 0
    Private MonedaBase As String
    Private AplicaMoneda As Boolean

    Private Sub frmInversiones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '--------------------------------
        Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim DAS As New SqlDataAdapter("SELECT emp_monedabase FROM Empresas WHERE Codigo =" & EmpresaActual, DC)
        Dim DSet As New DataSet
        DAS.Fill(DSet, "MonedaBase")
        MonedaBase = DSet.Tables("MonedaBase").Rows(0).Item("emp_monedabase")
        '---------------------------------
        Dim DA As New SqlDataAdapter("SELECT Codigo,Nombre FROM Bancos WHERE Empresa =" & EmpresaActual & " AND Activo=1", DC)
        DA.Fill(DSet, "Bancos")
        cmbBancos.DataSource = DSet.Tables("Bancos")
        cmbBancos.ValueMember = "Codigo"
        cmbBancos.DisplayMember = "Nombre"
        Dim DA1 As New SqlDataAdapter("SELECT mon_Codigo as Codigo,mon_descripcion AS Nombre FROM Monedas WHERE Empr_codigo =" & EmpresaActual, DC)
        DA1.Fill(DSet, "Monedas")
        cmbmoneda.DataSource = DSet.Tables("Monedas")
        cmbmoneda.ValueMember = "Codigo"
        cmbmoneda.DisplayMember = "Nombre"
        DS = New DataSet
        With DS
            DS.Tables.Add("Grid")
            DS.Tables("Grid").Columns.Add("No", System.Type.GetType("System.Int32"))
            DS.Tables("Grid").Columns.Add("Fecha", System.Type.GetType("System.DateTime"))
            DS.Tables("Grid").Columns.Add("MontoIni", System.Type.GetType("System.Double"))
            DS.Tables("Grid").Columns.Add("Interes", System.Type.GetType("System.Double"))
            DS.Tables("Grid").Columns.Add("Monto", System.Type.GetType("System.Double"))
            DS.Tables("Grid").Columns.Add("Institucion", System.Type.GetType("System.String"))
            DS.Tables("Grid").Columns.Add("Banco", System.Type.GetType("System.String"))
            DS.Tables("Grid").Columns.Add("Fechas", System.Type.GetType("System.DateTime"))
            DS.Tables("Grid").Columns.Add("Plazo", System.Type.GetType("System.Double"))
            DS.Tables("Grid").Columns.Add("Inter", System.Type.GetType("System.Double"))
            DS.Tables("Grid").Columns.Add("Inicial", System.Type.GetType("System.Double"))
            DS.Tables("Grid").Columns.Add("Limite", System.Type.GetType("System.DateTime"))
        End With
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Me.Close()
    End Sub

    Private Sub cmdDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetalle.Click
        '------------------------
        If cmbmoneda.SelectedValue = MonedaBase Then
            AplicaMoneda = False
        Else
            AplicaMoneda = True
        End If
        '------------------------
        Dim DR As DataRow
        Dim Fecha As Date
        Dim Monto As Double
        Dim Interes As Double
        Fecha = txtFecha.Value
        Monto = Val(TxtValor.Text)
        Dim i As Integer = 0
        DS.Clear()

        For i = 0 To Me.Controls.Count - 1
            If Me.Controls(i).Name = "TxtInstitucion" Then
            Else
                If TypeOf Me.Controls(i) Is TextBox Then If Me.Controls(i).Text = vbNullString Then Exit Sub
            End If
        Next

        Label2.Text = vbNullString
        Label8.Text = vbNullString
        Label9.Text = vbNullString
        Label10.Text = vbNullString

        For i = 0 To IIf(chkanual.Checked, IIf((Val(TxtPlazo.Text) / 12) > (Val(TxtPlazo.Text) \ 12), (Val(TxtPlazo.Text) \ 12), (Val(TxtPlazo.Text) \ 12) - 1), Val(TxtPlazo.Text) - 1)
            With DS.Tables("Grid")
                DR = .NewRow
                DR.Item("MontoIni") = Monto
                If i > 0 Then
                    Fecha = IIf(chkanual.Checked, DateAdd(DateInterval.Year, 1, Fecha), DateAdd(DateInterval.Month, 1, Fecha))
                End If
                Interes = IIf(chkanual.Checked, ((Val(TxtInteres.Text) / 100 / 12) / Val(TxtPlazo.Text)) * Monto, Monto * (Val(TxtInteres.Text) / 100 / 12))
                Monto += Interes
                DR.Item("No") = i + 1
                DR.Item("Fecha") = Fecha
                DR.Item("Interes") = Interes
                DR.Item("Monto") = Monto
                DR.Item("Institucion") = TxtInstitucion.Text
                DR.Item("Banco") = cmbBancos.Text
                DR.Item("Fechas") = txtFecha.Text
                DR.Item("Plazo") = TxtPlazo.Text
                DR.Item("Inter") = TxtInteres.Text
                DR.Item("Inicial") = TxtValor.Text
                DR.Item("Limite") = txtfechalimite.Text
                .Rows.Add(DR)
            End With
        Next

        GridDetalle.DataMember = "Grid"
        GridDetalle.DataSource = DS
        GridDetalle.Refresh()
        Dim Vista As DevExpress.XtraGrid.Views.Grid.GridView
        Dim Fila As DataRow
        Vista = GridDetalle.MainView
        For Cont As Integer = 0 To Vista.RowCount - 1
            Fila = Vista.GetDataRow(Cont)
            Label2.Text = "Intereses Devengados -> " + Format(CDbl(IIf(Mid(Label2.Text, 24) = vbNullString, 0, Mid(Label2.Text, 24))) + CDbl(Fila.Item(3)), "#,#.00")
        Next
        Label8.Text = "Interes 10% -> " + Format(IIf(Mid(Label2.Text, 24) = vbNullString, 0, CDbl(Mid(Label2.Text, 24)) * 0.1), "#,#.00")
        Label9.Text = "Intereses Netos -> " + Format(IIf(Mid(Label2.Text, 24) = vbNullString, 0, CDbl(Mid(Label2.Text, 24)) - CDbl(Mid(Label8.Text, 15))), "#,#.00")
        Label10.Text = "Total a Recibir -> " + Format(IIf(Mid(Label9.Text, 19) = vbNullString, 0, CDbl(Mid(Label9.Text, 19)) + CDbl(TxtValor.Text)), "#,#.00")
    End Sub

    Private Sub cmdimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdimprimir.Click
        Dim Rep As New RptInversiones
        Rep.DataSource = DS

        Rep.ShowPrintMarginsWarning = False
        Rep.BringToFront()
        Rep.ShowRibbonPreview()
    End Sub

    Private Sub cmdguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdguardar.Click
        cmdDetalle_Click(sender, e)
        Try
            Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
            Dim DA As New SqlCommand("SPInversiones " & Inversion & ",'" & txtFecha.Value & "'," & cmbBancos.SelectedValue & "," & TxtPlazo.Text & "," & TxtInteres.Text & "," & TxtValor.Text & ",'" & TxtInstitucion.Text & "'," & EmpresaActual & ",'" & txtfechalimite.Value & "'," & IIf(chkanual.Checked, 1, 0), DC)
            DC.Open()
            DA.ExecuteNonQuery()
            DC.Close()
            Inversion = 0
        Catch ex As Exception
            MsgBox("Error al guardar, intente de nuevo", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmdbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbuscar.Click
        Dim Forma As New FrmBuscaInversion
        Inversion = Forma.Mostrar
        If Inversion <> 0 Then
            Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
            Dim DA As New SqlDataAdapter("SELECT * FROM Inversiones WHERE IdInversion =" & Inversion, DC)
            Dim DS As New DataSet
            DA.Fill(DS, "Inversion")
            With DS.Tables("Inversion")
                TxtPlazo.Text = .Rows(0).Item("Plazo")
                TxtInteres.Text = .Rows(0).Item("Interes")
                TxtInstitucion.Text = .Rows(0).Item("Nombre")
                TxtValor.Text = .Rows(0).Item("Valor")
                txtFecha.Value = .Rows(0).Item("Fecha")
                txtfechalimite.Value = .Rows(0).Item("FechaLimite")
                cmbBancos.SelectedValue = .Rows(0).Item("IdBanco")
                chkanual.Checked = IIf(.Rows(0).Item("Anual"), 1, 0)
                cmdDetalle_Click(sender, e)
            End With
        End If
    End Sub

    Private Sub cmdnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnuevo.Click
        DS.Clear()
        TxtPlazo.Text = vbNullString
        TxtInteres.Text = vbNullString
        TxtInstitucion.Text = vbNullString
        TxtValor.Text = vbNullString
        Inversion = 0
    End Sub

    Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890.", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function

    Private Sub ValidaTexto(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtValor.KeyPress, TxtInteres.KeyPress, TxtPlazo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class