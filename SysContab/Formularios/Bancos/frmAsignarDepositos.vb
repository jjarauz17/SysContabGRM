Imports System.Data.SqlClient

Public Class frmAsignarDepositos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAsignarDepositos = Nothing

    Public Shared Function Instance() As frmAsignarDepositos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAsignarDepositos()
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
    Friend WithEvents cbDepositos As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdVerDepositos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbFecha As System.Windows.Forms.CheckBox
    Friend WithEvents etMontoAsignar As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents etDisponible As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents etDepositado As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents etIngresos As System.Windows.Forms.Label
    Friend WithEvents etTotalT As System.Windows.Forms.Label
    Friend WithEvents cBoxFecha As System.Windows.Forms.CheckBox
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rgTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents rgResumen As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtAsignar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cbBancos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbSeries As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cbDepositos = New System.Windows.Forms.ComboBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdVerDepositos = New DevExpress.XtraEditors.SimpleButton
        Me.cbFecha = New System.Windows.Forms.CheckBox
        Me.etMontoAsignar = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.etDisponible = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.etDepositado = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.etIngresos = New System.Windows.Forms.Label
        Me.etTotalT = New System.Windows.Forms.Label
        Me.cBoxFecha = New System.Windows.Forms.CheckBox
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.dgDatos = New DevExpress.XtraGrid.GridControl
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtAsignar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.rgTipo = New DevExpress.XtraEditors.RadioGroup
        Me.rgResumen = New DevExpress.XtraEditors.RadioGroup
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.cbBancos = New DevExpress.XtraEditors.LookUpEdit
        Me.cbSeries = New DevExpress.XtraEditors.LookUpEdit
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAsignar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgResumen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cbBancos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSeries.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Location = New System.Drawing.Point(13, 93)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(93, 34)
        Me.cmdCancelar.TabIndex = 25
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_SaveFileLarge
        Me.cmdAceptar.Location = New System.Drawing.Point(13, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(93, 35)
        Me.cmdAceptar.TabIndex = 24
        Me.cmdAceptar.Text = "Guardar"
        '
        'cbDepositos
        '
        Me.cbDepositos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbDepositos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepositos.Location = New System.Drawing.Point(134, 9)
        Me.cbDepositos.Name = "cbDepositos"
        Me.cbDepositos.Size = New System.Drawing.Size(633, 21)
        Me.cbDepositos.TabIndex = 16
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(579, 37)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(58, 21)
        Me.dtpFecha.TabIndex = 145
        Me.dtpFecha.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "Hoja de Deposito:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(76, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 148
        Me.Label3.Text = "Banco:"
        '
        'cmdVerDepositos
        '
        Me.cmdVerDepositos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerDepositos.Appearance.Options.UseFont = True
        Me.cmdVerDepositos.Appearance.Options.UseTextOptions = True
        Me.cmdVerDepositos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdVerDepositos.Location = New System.Drawing.Point(13, 53)
        Me.cmdVerDepositos.Name = "cmdVerDepositos"
        Me.cmdVerDepositos.Size = New System.Drawing.Size(93, 34)
        Me.cmdVerDepositos.TabIndex = 152
        Me.cmdVerDepositos.Text = "Hojas de Depositos"
        '
        'cbFecha
        '
        Me.cbFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFecha.AutoSize = True
        Me.cbFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbFecha.Location = New System.Drawing.Point(640, 73)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(89, 18)
        Me.cbFecha.TabIndex = 155
        Me.cbFecha.Text = "Por Fecha:"
        Me.cbFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbFecha.Visible = False
        '
        'etMontoAsignar
        '
        Me.etMontoAsignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.etMontoAsignar.BackColor = System.Drawing.Color.Transparent
        Me.etMontoAsignar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etMontoAsignar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMontoAsignar.ForeColor = System.Drawing.Color.Maroon
        Me.etMontoAsignar.Location = New System.Drawing.Point(673, 295)
        Me.etMontoAsignar.Name = "etMontoAsignar"
        Me.etMontoAsignar.Size = New System.Drawing.Size(100, 20)
        Me.etMontoAsignar.TabIndex = 171
        Me.etMontoAsignar.Text = "0.00"
        Me.etMontoAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.etMontoAsignar.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(564, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "Monto Asignar"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'etDisponible
        '
        Me.etDisponible.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.etDisponible.BackColor = System.Drawing.Color.Transparent
        Me.etDisponible.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etDisponible.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDisponible.ForeColor = System.Drawing.Color.Maroon
        Me.etDisponible.Location = New System.Drawing.Point(458, 297)
        Me.etDisponible.Name = "etDisponible"
        Me.etDisponible.Size = New System.Drawing.Size(100, 20)
        Me.etDisponible.TabIndex = 169
        Me.etDisponible.Text = "0.00"
        Me.etDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.etDisponible.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(379, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 168
        Me.Label7.Text = "Disponible"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'etDepositado
        '
        Me.etDepositado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.etDepositado.BackColor = System.Drawing.Color.Transparent
        Me.etDepositado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etDepositado.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDepositado.ForeColor = System.Drawing.Color.Maroon
        Me.etDepositado.Location = New System.Drawing.Point(273, 299)
        Me.etDepositado.Name = "etDepositado"
        Me.etDepositado.Size = New System.Drawing.Size(100, 20)
        Me.etDepositado.TabIndex = 167
        Me.etDepositado.Text = "0.00"
        Me.etDepositado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.etDepositado.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(186, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 166
        Me.Label8.Text = "Depositado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'etIngresos
        '
        Me.etIngresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.etIngresos.BackColor = System.Drawing.Color.Transparent
        Me.etIngresos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etIngresos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etIngresos.ForeColor = System.Drawing.Color.Maroon
        Me.etIngresos.Location = New System.Drawing.Point(80, 297)
        Me.etIngresos.Name = "etIngresos"
        Me.etIngresos.Size = New System.Drawing.Size(100, 20)
        Me.etIngresos.TabIndex = 165
        Me.etIngresos.Text = "0.00"
        Me.etIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.etIngresos.Visible = False
        '
        'etTotalT
        '
        Me.etTotalT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.etTotalT.AutoSize = True
        Me.etTotalT.BackColor = System.Drawing.Color.Transparent
        Me.etTotalT.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etTotalT.Location = New System.Drawing.Point(9, 301)
        Me.etTotalT.Name = "etTotalT"
        Me.etTotalT.Size = New System.Drawing.Size(65, 16)
        Me.etTotalT.TabIndex = 164
        Me.etTotalT.Text = "Ingresos"
        Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.etTotalT.Visible = False
        '
        'cBoxFecha
        '
        Me.cBoxFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cBoxFecha.AutoSize = True
        Me.cBoxFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cBoxFecha.Location = New System.Drawing.Point(640, 39)
        Me.cBoxFecha.Name = "cBoxFecha"
        Me.cBoxFecha.Size = New System.Drawing.Size(127, 18)
        Me.cBoxFecha.TabIndex = 173
        Me.cBoxFecha.Text = "Hojas por Fecha:"
        Me.cBoxFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cBoxFecha.Visible = False
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha1.Enabled = False
        Me.dtpFecha1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(502, 37)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(71, 21)
        Me.dtpFecha1.TabIndex = 172
        Me.dtpFecha1.Visible = False
        '
        'dgDatos
        '
        Me.dgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDatos.Location = New System.Drawing.Point(8, 99)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtAsignar})
        Me.dgDatos.Size = New System.Drawing.Size(861, 193)
        Me.dgDatos.TabIndex = 174
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'txtAsignar
        '
        Me.txtAsignar.AutoHeight = False
        Me.txtAsignar.Mask.EditMask = "n2"
        Me.txtAsignar.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAsignar.Mask.UseMaskAsDisplayFormat = True
        Me.txtAsignar.Name = "txtAsignar"
        '
        'rgTipo
        '
        Me.rgTipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rgTipo.EditValue = 2
        Me.rgTipo.Location = New System.Drawing.Point(8, 63)
        Me.rgTipo.Name = "rgTipo"
        Me.rgTipo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgTipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgTipo.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.rgTipo.Properties.Appearance.Options.UseBackColor = True
        Me.rgTipo.Properties.Appearance.Options.UseFont = True
        Me.rgTipo.Properties.Appearance.Options.UseForeColor = True
        Me.rgTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Efectivo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Cheque"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Tarjeta")})
        Me.rgTipo.Size = New System.Drawing.Size(759, 30)
        Me.rgTipo.TabIndex = 175
        '
        'rgResumen
        '
        Me.rgResumen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rgResumen.Enabled = False
        Me.rgResumen.Location = New System.Drawing.Point(773, 4)
        Me.rgResumen.Name = "rgResumen"
        Me.rgResumen.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgResumen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgResumen.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.rgResumen.Properties.Appearance.Options.UseBackColor = True
        Me.rgResumen.Properties.Appearance.Options.UseFont = True
        Me.rgResumen.Properties.Appearance.Options.UseForeColor = True
        Me.rgResumen.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Resumido"), New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Detallado")})
        Me.rgResumen.Size = New System.Drawing.Size(96, 53)
        Me.rgResumen.TabIndex = 176
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.cmdVerDepositos)
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Location = New System.Drawing.Point(876, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(120, 288)
        Me.PanelControl1.TabIndex = 177
        '
        'cbBancos
        '
        Me.cbBancos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBancos.Location = New System.Drawing.Point(134, 35)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancos.Properties.Appearance.Options.UseFont = True
        Me.cbBancos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBancos.Size = New System.Drawing.Size(359, 22)
        Me.cbBancos.TabIndex = 178
        '
        'cbSeries
        '
        Me.cbSeries.Location = New System.Drawing.Point(8, 35)
        Me.cbSeries.Name = "cbSeries"
        Me.cbSeries.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSeries.Properties.Appearance.Options.UseFont = True
        Me.cbSeries.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSeries.Size = New System.Drawing.Size(46, 22)
        Me.cbSeries.TabIndex = 180
        Me.cbSeries.Visible = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckEdit1.Location = New System.Drawing.Point(784, 73)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.Caption = "Todos"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(85, 22)
        Me.CheckEdit1.TabIndex = 181
        '
        'frmAsignarDepositos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 326)
        Me.Controls.Add(Me.cbFecha)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.cbSeries)
        Me.Controls.Add(Me.cbBancos)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.rgResumen)
        Me.Controls.Add(Me.rgTipo)
        Me.Controls.Add(Me.dgDatos)
        Me.Controls.Add(Me.cBoxFecha)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.etMontoAsignar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.etDisponible)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.etDepositado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.etIngresos)
        Me.Controls.Add(Me.etTotalT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cbDepositos)
        Me.Name = "frmAsignarDepositos"
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAsignar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgResumen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.cbBancos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSeries.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Variables"
    Dim Depositos As New VB.SysContab.DepositosDB
    Dim Bancos As New VB.SysContab.BancosDB
    Dim Clientes As New VB.SysContab.ClientesDB
    Private Comprobantes As New VB.SysContab.ComprobanteDB

    Private WithEvents myDataSet As DataSet
    Dim tCust As DataTable

    Dim MontoAsignar As New DataGridTextBoxColumn

    Dim ValorActualMonto As Double
    Dim ds As DataSet

    Private myCheckBoxCol As Integer = 6 'my checkbox column 

    Dim r As New VB.SysContab.Rutinas
    Dim k As Integer
    Dim i As Integer

    Dim Fecha As String
    Dim Resumido As Integer
    'Dim Inicio As Boolean

    Dim newRow1 As DataRow

    Dim Total As Double
    Dim Depositado As Double
    Dim Disponible As Double
    Dim Asignar As Double

#End Region

    Private Sub frmAsignarDepositos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabla As DataTable

        ''r.CambiarEstilo(Me)
        'r.FormularioColor(Me)
        'ds = Depositos.List

        Fecha = FechaCobro
        dtpFecha.Enabled = False
        Me.rgResumen.Enabled = False
        'GroupBox3.Enabled = False

        Total = 0
        Depositado = 0
        Disponible = 0
        Asignar = 0

        Me.rgResumen.EditValue = 1
        'Resumido = 1

        GridCheque()

        'dgDepositos.CaptionText = ""

        cbDepositos.DataSource = Depositos.List(0, "", "", 0).Tables("Depositos")
        cbDepositos.ValueMember = "Deposito_ID"
        cbDepositos.DisplayMember = "DisplayMember"

        If Deposito = "" Then
            cbDepositos.SelectedIndex = cbDepositos.Items.Count - 1
        Else
            cbDepositos.SelectedValue = Deposito 'La hoja de deposito ya fue seleccionada
        End If

        CargarCombos()

        'cbBancos.DataSource = Bancos.ListAll.Tables("Bancos")
        'cbBancos.ValueMember = "Codigo"
        'cbBancos.DisplayMember = "Nombre"

        If Seleccionar = True Then

            Dim f As frmCobrosTotales = frmCobrosTotales.Instance
            Dim j As Integer
            k = 0

            MakeDataSet1()

            For j = 0 To f.ds.Tables("Cobros").Rows.Count - 1
                If f.tCust.Rows(j)("Agregar") = True Then
                    If f.ds.Tables("Cobros").Rows(j).Item("Orden") = 2 Or f.ds.Tables("Cobros").Rows(j).Item("Orden") = 5 Then
                        ds = Clientes.Depositos(2, 0, Fecha, f.tCust.Rows(j)("Codigo"), Resumido)
                        'MakeDataSet1()
                        AsignarDatos()
                        ''dgDepositos.SetDataBinding(myDataSet, "Item")
                        ''AddCustomDataTableStyle()
                    Else
                        '

                    End If
                End If
                'MsgBox(f.tCust.Rows(i)("Agregar"))
                'Exit Sub
            Next

            If j > 0 Then
                ''dgDepositos.SetDataBinding(myDataSet, "Item")
                ''AddCustomDataTableStyle()
                'Else

                'MsgBox(f.dgCobrosTotales.Item(0, 6))

            End If
        Else



            ''MakeDataSet()
            ''dgDepositos.SetDataBinding(myDataSet, "Item")
            ''AddCustomDataTableStyle()



            'If Banco = "" Then
            '    '
            'Else
            '    cbBancos.SelectedValue = Banco
            'End If

            'If Banco = "0" Then
            '    Inicio = True
            '    myCheckBoxCol = 3
            '    rbEfectivo.Checked = True
            'Else
            '    'MakeDataSet()
            '    'dgDepositos.SetDataBinding(myDataSet, "Item")
            '    'AddCustomDataTableStyle()
            '    ''''''''''''''''''''''''''''''
            'End If

        End If

        cbDepositos.DropDownStyle = ComboBoxStyle.DropDownList

        'cbBancos.DropDownStyle = ComboBoxStyle.DropDownList
        'r.FormatGenerico(dgDepositosLista, Tabla)
        'dgDepositos.ReadOnly = False
        'dgDepositos.ReadOnly = False
        'Inicio = False
        Me.Refresh()
    End Sub

    Sub CargarCombos()
        Me.cbBancos.Properties.DataSource = Bancos.ListAll.Tables("Bancos").DefaultView
        Me.cbBancos.Properties.ValueMember = "Codigo"
        Me.cbBancos.Properties.DisplayMember = "Nombre"
        Me.cbBancos.Properties.PopulateColumns()
        Me.cbBancos.Properties.Columns("Empresa").Visible = False
        Me.cbBancos.ItemIndex = 0

        'Me.cbSeries.Properties.DataSource = ObtieneDatos("sp_GetSeriesList " & EmpresaActual)
        'Me.cbSeries.Properties.ValueMember = "Valor"
        'Me.cbSeries.Properties.DisplayMember = "Serie"
        'Me.cbSeries.Properties.PopulateColumns()
        'Me.cbSeries.Properties.Columns("Valor").Visible = False
        'Me.cbSeries.ItemIndex = 0
    End Sub

    'Private Sub 'AddCustomDataTableStyle()

    '    'STEP 1: Create a DataTable style object and set properties if required.
    '    Dim ts1 As DataGridTableStyle
    '    ts1 = New DataGridTableStyle
    '    'specify the table from dataset (required step)
    '    ts1.MappingName = "Item"
    '    ' Set other properties (optional step)
    '    ts1.AlternatingBackColor = Color.LightBlue
    '    Dim colCount As Integer
    '    colCount = 0

    '    'Dim Linea As New DataGridTextBoxColumn()
    '    'Linea.MappingName = "Linea"
    '    'Linea.HeaderText = ""
    '    'Linea.ReadOnly = True
    '    'Linea.Alignment = HorizontalAlignment.Left
    '    'Linea.Width = 25
    '    'Linea.NullText = ""

    '    'ts1.GridColumnStyles.Add(Linea)
    '    'colCount = (colCount + 1)

    '    Dim Numero As New DataGridTextBoxColumn
    '    Numero.MappingName = "Numero"
    '    Numero.HeaderText = "Numero"
    '    Numero.ReadOnly = True
    '    Numero.Alignment = HorizontalAlignment.Left
    '    Numero.Width = 0
    '    Numero.NullText = ""

    '    ts1.GridColumnStyles.Add(Numero)
    '    colCount = (colCount + 1)

    '    Dim Cliente As New DataGridTextBoxColumn
    '    Cliente.MappingName = "Cliente"
    '    Cliente.HeaderText = "Cliente"
    '    Cliente.ReadOnly = True
    '    Cliente.Alignment = HorizontalAlignment.Left
    '    Cliente.Width = 250
    '    Cliente.NullText = ""

    '    ts1.GridColumnStyles.Add(Cliente)
    '    colCount = (colCount + 1)

    '    Dim Cheque As New DataGridTextBoxColumn
    '    Cheque.MappingName = "Cheque"
    '    Cheque.HeaderText = "Cheque"
    '    Cheque.ReadOnly = True
    '    Cheque.Alignment = HorizontalAlignment.Left
    '    Cheque.Width = 80
    '    Cheque.NullText = ""

    '    ts1.GridColumnStyles.Add(Cheque)
    '    colCount = (colCount + 1)

    '    Dim Banco As New DataGridTextBoxColumn
    '    Banco.MappingName = "Banco"
    '    Banco.HeaderText = "Banco"
    '    Banco.ReadOnly = True
    '    Banco.Alignment = HorizontalAlignment.Left
    '    Banco.Width = 250
    '    Banco.NullText = ""

    '    ts1.GridColumnStyles.Add(Banco)
    '    colCount = (colCount + 1)

    '    Dim MontoCheque As New DataGridTextBoxColumn
    '    MontoCheque.MappingName = "MontoCheque"
    '    MontoCheque.HeaderText = "Monto"
    '    MontoCheque.ReadOnly = True
    '    MontoCheque.Alignment = HorizontalAlignment.Right
    '    MontoCheque.Width = 100
    '    MontoCheque.NullText = ""

    '    ts1.GridColumnStyles.Add(MontoCheque)
    '    colCount = (colCount + 1)

    '    Dim Fecha As New DataGridTextBoxColumn
    '    Fecha.MappingName = "Fecha"
    '    Fecha.HeaderText = "Fecha"
    '    Fecha.ReadOnly = True
    '    Fecha.Alignment = HorizontalAlignment.Left
    '    Fecha.Width = 80
    '    Fecha.NullText = ""

    '    ts1.GridColumnStyles.Add(Fecha)
    '    colCount = (colCount + 1)

    '    Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
    '    boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
    '    boolCol.MappingName = "Agregar"
    '    boolCol.HeaderText = "Agregar"
    '    boolCol.Alignment = HorizontalAlignment.Center
    '    'uncomment this line to get a two-state checkbox
    '    CType(boolCol, DataGridBoolColumn).AllowNull = False

    '    boolCol.Width = 65
    '    boolCol.ReadOnly = False

    '    boolCol.NullText = ""

    '    'hook the new event to our handler in the grid
    '    AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
    '    'AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
    '    'AddHandler boolCol. , AddressOf CheckedChanged
    '    ts1.GridColumnStyles.Add(boolCol)
    '    colCount = (colCount + 1)

    '    'STEP 4: Add the checkbox
    '    'Dim i As Integer
    '    'For i = 0 To ds.Tables("Depositos").Rows.Count - 1
    '    '    Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
    '    '    boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
    '    '    boolCol.MappingName = ds.Tables("Depositos").Rows(i).Item("Deposito_ID") & "D"
    '    '    boolCol.HeaderText = ds.Tables("Depositos").Rows(i).Item("Deposito_ID")
    '    '    boolCol.Alignment = HorizontalAlignment.Center
    '    '    'uncomment this line to get a two-state checkbox
    '    '    CType(boolCol, DataGridBoolColumn).AllowNull = False

    '    '    boolCol.Width = 50
    '    '    boolCol.ReadOnly = False

    '    '    boolCol.NullText = ""

    '    '    'hook the new event to our handler in the grid
    '    '    AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
    '    '    ts1.GridColumnStyles.Add(boolCol)
    '    '    colCount = (colCount + 1)

    '    'Next

    '    ''STEP 5: Add a second checkbox

    '    Dim Comp As New DataGridTextBoxColumn
    '    Comp.MappingName = "Comp"
    '    Comp.HeaderText = ""
    '    Comp.ReadOnly = True
    '    Comp.Alignment = HorizontalAlignment.Right
    '    Comp.Width = 0
    '    Comp.NullText = ""
    '    ts1.GridColumnStyles.Add(Comp)
    '    colCount = (colCount + 1)

    '    Dim Empresa As New DataGridTextBoxColumn
    '    Empresa.MappingName = "Empresa"
    '    Empresa.HeaderText = ""
    '    Empresa.ReadOnly = True
    '    Empresa.Alignment = HorizontalAlignment.Right
    '    Empresa.Width = 0
    '    Empresa.NullText = ""
    '    ts1.GridColumnStyles.Add(Empresa)
    '    colCount = (colCount + 1)

    '    Dim Periodo As New DataGridTextBoxColumn
    '    Periodo.MappingName = "Periodo"
    '    Periodo.HeaderText = ""
    '    Periodo.ReadOnly = True
    '    Periodo.Alignment = HorizontalAlignment.Right
    '    Periodo.Width = 0
    '    Periodo.NullText = ""
    '    ts1.GridColumnStyles.Add(Periodo)
    '    colCount = (colCount + 1)

    '    Dim Mes As New DataGridTextBoxColumn
    '    Mes.MappingName = "Mes"
    '    Mes.HeaderText = ""
    '    Mes.ReadOnly = True
    '    Mes.Alignment = HorizontalAlignment.Right
    '    Mes.Width = 0
    '    Mes.NullText = ""
    '    ts1.GridColumnStyles.Add(Mes)
    '    colCount = (colCount + 1)

    '    'STEP 6: Add the tablestyle to your datagrids tablestlye collection
    '    ts1.AllowSorting = False
    '    ts1.HeaderFont = dgDepositos.HeaderFont
    '    ts1.GridLineColor = Color.FromArgb(70, 130, 180)
    '    ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
    '    ts1.PreferredRowHeight = 25
    '    Me.dgDepositos.CaptionVisible = False

    '    'tCust.DefaultView.AllowDelete = False
    '    'tCust.DefaultView.AllowNew = False
    '    'tCust.DefaultView.AllowEdit = False

    '    'dgDepositos.ReadOnly = True

    '    myDataSet.Tables("Item").DefaultView.AllowDelete = False
    '    myDataSet.Tables("Item").DefaultView.AllowNew = False
    '    myDataSet.Tables("Item").DefaultView.AllowEdit = True

    '    dgDepositos.TableStyles.Clear()
    '    dgDepositos.TableStyles.Add(ts1)



    'End Sub

    Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
        Dim s As String
        s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
        Console.WriteLine(s)
    End Sub

    Private Sub MakeDataSet()
        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")

        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust = New DataTable("Item")

        ' Create two columns, and add them to the first table.
        Dim i As Integer

        'For i = 0 To ds1.Tables("Depositos").Rows.Count ' - 1
        '    Dim cAgregar As DataColumn
        '    cAgregar = New DataColumn(i, GetType(System.Boolean))
        '    tCust.Columns.Add(cAgregar)
        'Next

        'Dim cLinea As DataColumn
        'cLinea = New DataColumn("Linea")
        'tCust.Columns.Add(cLinea)

        Total = 0
        Depositado = 0

        Dim cNumero As DataColumn
        cNumero = New DataColumn("Numero")
        tCust.Columns.Add(cNumero)

        Dim cCliente As DataColumn
        cCliente = New DataColumn("Cliente")
        tCust.Columns.Add(cCliente)

        Dim cCheque As DataColumn
        cCheque = New DataColumn("Cheque")
        tCust.Columns.Add(cCheque)

        Dim cBanco As DataColumn
        cBanco = New DataColumn("Banco")
        tCust.Columns.Add(cBanco)

        Dim cMontoCheque As DataColumn
        cMontoCheque = New DataColumn("MontoCheque")
        tCust.Columns.Add(cMontoCheque)

        Dim cFecha As DataColumn
        cFecha = New DataColumn("Fecha")
        tCust.Columns.Add(cFecha)

        Dim cAgregar As DataColumn
        cAgregar = New DataColumn("Agregar", GetType(System.Boolean))
        tCust.Columns.Add(cAgregar)

        Dim cComp As DataColumn
        cComp = New DataColumn("Comp")
        tCust.Columns.Add(cComp)

        Dim cEmpresa As DataColumn
        cEmpresa = New DataColumn("Empresa")
        tCust.Columns.Add(cEmpresa)

        Dim cPeriodo As DataColumn
        cPeriodo = New DataColumn("Periodo")
        tCust.Columns.Add(cPeriodo)

        Dim cMes As DataColumn
        cMes = New DataColumn("Mes")
        tCust.Columns.Add(cMes)

        'For i = 0 To ds.Tables("Depositos").Rows.Count - 1
        '    Dim cAgregar As DataColumn
        '    'cAgregar = New DataColumn(ds.Tables("Depositos").Rows(i).Item("Deposito_ID") & "D", GetType(System.Boolean))
        '    cAgregar = New DataColumn(ds.Tables("Depositos").Rows(i).Item("Deposito_ID") & "D", GetType(System.Boolean))
        '    tCust.Columns.Add(cAgregar)
        'Next


        tCust.DefaultView.AllowDelete = False
        tCust.DefaultView.AllowNew = False
        tCust.DefaultView.AllowEdit = False

        'tCust.Columns.Add(cCurrent2)
        ' Add the tables to the DataSet.
        myDataSet.Tables.Add(tCust)

        'creates two DataRow variables. 
        Dim newRow1 As DataRow
        ' Create three customers in the Customers Table.
        'newRow1 = tCust.NewRow
        'newRow1(i) = False
        'tCust.Rows.Add(newRow1)

        newRow1 = tCust.NewRow
        'newRow1(i) = False
        tCust.Rows.Add(newRow1)

        'i = 0
        Dim j As Integer
        If Checked = True Then
            tCust.Rows(0)("Agregar") = True
        Else
            tCust.Rows(0)("Agregar") = False
        End If

        j = 1

        For i = 0 To ds.Tables("Cobros").Rows.Count - 1

            If ds.Tables("Cobros").Rows(i).Item("Estado") = 1 Then 'Ya fue asignado
                'Ya fue asignado
                Depositado = Depositado + CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)
            Else

                newRow1 = tCust.NewRow
                'newRow1(i) = False
                tCust.Rows.Add(newRow1)

                'tCust.Rows(i + 1)("Linea") = i + 1
                tCust.Rows(j)("Numero") = ds.Tables("Cobros").Rows(i).Item("Numero")
                tCust.Rows(j)("Cliente") = ds.Tables("Cobros").Rows(i).Item("Cliente")
                tCust.Rows(j)("Cheque") = ds.Tables("Cobros").Rows(i).Item("No Cheque")
                tCust.Rows(j)("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
                tCust.Rows(j)("MontoCheque") = CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)
                tCust.Rows(j)("Fecha") = ds.Tables("Cobros").Rows(i).Item("Fecha")

                tCust.Rows(j)("Comp") = ds.Tables("Cobros").Rows(i).Item("Comp_No")
                tCust.Rows(j)("Empresa") = ds.Tables("Cobros").Rows(i).Item("Empresa")
                tCust.Rows(j)("Periodo") = ds.Tables("Cobros").Rows(i).Item("Per_ID")
                tCust.Rows(j)("Mes") = ds.Tables("Cobros").Rows(i).Item("Mes")

                If Checked = True Then
                    tCust.Rows(j)("Agregar") = True
                Else
                    tCust.Rows(j)("Agregar") = False
                End If

                j = j + 1

                'For j = 0 To ds.Tables("Depositos").Rows.Count - 1
                '    tCust.Rows(i)(ds.Tables("Depositos").Rows(j).Item("Deposito_ID") & "D") = False
                'Next
            End If

            Total = Total + CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)

        Next

        myDataSet.Tables("Item").DefaultView.AllowDelete = False

        etIngresos.Text = Total.ToString(Round)
        etDepositado.Text = Depositado.ToString(Round)
        etDisponible.Text = (Total.ToString(Round) - Depositado.ToString(Round)).ToString(Round)

    End Sub

    Private Sub MakeDataSet1()
        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")

        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust = New DataTable("Item")

        ' Create two columns, and add them to the first table.
        Dim i As Integer

        'For i = 0 To ds1.Tables("Depositos").Rows.Count ' - 1
        '    Dim cAgregar As DataColumn
        '    cAgregar = New DataColumn(i, GetType(System.Boolean))
        '    tCust.Columns.Add(cAgregar)
        'Next

        'Dim cLinea As DataColumn
        'cLinea = New DataColumn("Linea")
        'tCust.Columns.Add(cLinea)

        Total = 0

        Dim cNumero As DataColumn
        cNumero = New DataColumn("Numero")
        tCust.Columns.Add(cNumero)

        Dim cCheque As DataColumn
        cCheque = New DataColumn("Cheque")
        tCust.Columns.Add(cCheque)

        Dim cBanco As DataColumn
        cBanco = New DataColumn("Banco")
        tCust.Columns.Add(cBanco)

        Dim cMontoCheque As DataColumn
        cMontoCheque = New DataColumn("MontoCheque")
        tCust.Columns.Add(cMontoCheque)

        Dim cFecha As DataColumn
        cFecha = New DataColumn("Fecha")
        tCust.Columns.Add(cFecha)

        Dim cAgregar As DataColumn
        cAgregar = New DataColumn("Agregar", GetType(System.Boolean))
        tCust.Columns.Add(cAgregar)

        Dim cComp As DataColumn
        cComp = New DataColumn("Comp")
        tCust.Columns.Add(cComp)

        Dim cEmpresa As DataColumn
        cEmpresa = New DataColumn("Empresa")
        tCust.Columns.Add(cEmpresa)

        Dim cPeriodo As DataColumn
        cPeriodo = New DataColumn("Periodo")
        tCust.Columns.Add(cPeriodo)

        Dim cMes As DataColumn
        cMes = New DataColumn("Mes")
        tCust.Columns.Add(cMes)

        'For i = 0 To ds.Tables("Depositos").Rows.Count - 1
        '    Dim cAgregar As DataColumn
        '    'cAgregar = New DataColumn(ds.Tables("Depositos").Rows(i).Item("Deposito_ID") & "D", GetType(System.Boolean))
        '    cAgregar = New DataColumn(ds.Tables("Depositos").Rows(i).Item("Deposito_ID") & "D", GetType(System.Boolean))
        '    tCust.Columns.Add(cAgregar)
        'Next


        tCust.DefaultView.AllowDelete = False
        tCust.DefaultView.AllowNew = False
        tCust.DefaultView.AllowEdit = False

        'tCust.Columns.Add(cCurrent2)
        ' Add the tables to the DataSet.
        myDataSet.Tables.Add(tCust)

        'creates two DataRow variables. 
        'Dim newRow1 As DataRow
        ' Create three customers in the Customers Table.
        newRow1 = tCust.NewRow
        'newRow1(i) = False
        tCust.Rows.Add(newRow1)

        'newRow1 = tCust.NewRow
        'newRow1(i) = False
        'tCust.Rows.Add(newRow1)

        'i = 0
        'Dim j As Integer

        'If Checked = True Then
        tCust.Rows(0)("Agregar") = True
        'Else
        '    tCust.Rows(0)("Agregar") = False
        'End If

        'k = 0

        'For i = 0 To ds.Tables("Cobros").Rows.Count - 1

        '    newRow1 = tCust.NewRow
        '    newRow1("Numero") = ds.Tables("Cobros").Rows(i).Item("Numero")

        '    'newRow1 = tCust.NewRow
        '    'newRow1(i) = False
        '    tCust.Rows.Add(newRow1)

        '    'MsgBox(tCust.Rows(k)("Numero").ToString)

        '    'tCust.Rows(i + 1)("Linea") = i + 1
        '    'tCust.Rows(k)("Numero") = ds.Tables("Cobros").Rows(i).Item("Numero")
        '    tCust.Rows(k)("Cheque") = ds.Tables("Cobros").Rows(i).Item("No Cheque")
        '    tCust.Rows(k)("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
        '    tCust.Rows(k)("MontoCheque") = CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)
        '    tCust.Rows(k)("Fecha") = ds.Tables("Cobros").Rows(i).Item("Fecha")

        '    'If Checked = True Then
        '    tCust.Rows(k)("Agregar") = True
        '    'Else
        '    '    tCust.Rows(k + 1)("Agregar") = False
        '    'End If

        '    'For j = 0 To ds.Tables("Depositos").Rows.Count - 1
        '    '    tCust.Rows(i)(ds.Tables("Depositos").Rows(j).Item("Deposito_ID") & "D") = False
        '    'Next
        '    k = k + 1
        'Next
        'myDataSet.Tables("Item").DefaultView.AllowDelete = False
    End Sub

    Private Sub AsignarDatos()
        For i = 0 To ds.Tables("Cobros").Rows.Count - 1
            If ds.Tables("Cobros").Rows(i).Item("Estado") = 1 Then 'Ya fue asignado
                'Ya fue asignado
                Depositado = Depositado + CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)

            Else
                newRow1 = tCust.NewRow
                newRow1("Numero") = ds.Tables("Cobros").Rows(i).Item("Numero")

                newRow1("Cheque") = ds.Tables("Cobros").Rows(i).Item("No Cheque")
                newRow1("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
                newRow1("MontoCheque") = CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)
                newRow1("Fecha") = ds.Tables("Cobros").Rows(i).Item("Fecha")
                newRow1("Agregar") = True

                newRow1("Comp") = ds.Tables("Cobros").Rows(i).Item("Comp_No")
                newRow1("Empresa") = ds.Tables("Cobros").Rows(i).Item("Empresa")
                newRow1("Periodo") = ds.Tables("Cobros").Rows(i).Item("Per_ID")
                newRow1("Mes") = ds.Tables("Cobros").Rows(i).Item("Mes")

                tCust.Rows.Add(newRow1)

                'tCust.Rows(k)("Cheque") = ds.Tables("Cobros").Rows(i).Item("No Cheque")
                'tCust.Rows(k)("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
                'tCust.Rows(k)("MontoCheque") = CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)
                'tCust.Rows(k)("Fecha") = ds.Tables("Cobros").Rows(i).Item("Fecha")

                'tCust.Rows(k)("Agregar") = True

                k = k + 1

            End If
            Total = Total + CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)
        Next

        myDataSet.Tables("Item").DefaultView.AllowDelete = False
        etIngresos.Text = Total.ToString(Round)
        etDepositado.Text = Depositado.ToString(Round)
        etDisponible.Text = (Total.ToString(Round) - Depositado.ToString(Round)).ToString(Round)
    End Sub


    'Private Sub dgDepositos_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
    '    'If rbCheques.Checked = True Then
    '    '    myCheckBoxCol = 6 'my checkbox column 
    '    'Else
    '    '    If Resumido = 1 Then
    '    '        myCheckBoxCol = 2
    '    '    Else
    '    '        myCheckBoxCol = 6
    '    '    End If

    '    'End If

    '    Dim hti As DataGrid.HitTestInfo = Me.dgDepositos.HitTest(e.X, e.Y)
    '    Try
    '        If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
    '            Asignar = 0
    '            Me.dgDepositos(hti.Row, hti.Column) = Not CBool(Me.dgDepositos(hti.Row, hti.Column))
    '        Else
    '            Exit Sub
    '        End If
    '    Catch ex As Exception
    '        'MessageBox.Show(ex.ToString())
    '    End Try

    '    If dgDepositos.CurrentRowIndex <> 0 And hti.Column = myCheckBoxCol Then
    '        If tCust.Rows(0)("Agregar") = True Then
    '            For i = 1 To tCust.Rows.Count - 1
    '                If tCust.Rows(i)("Agregar") = False Then
    '                    tCust.Rows(0)("Agregar") = False
    '                End If
    '            Next
    '        ElseIf tCust.Rows(0)("Agregar") = False Then
    '            For i = 1 To tCust.Rows.Count - 1
    '                If tCust.Rows(i)("Agregar") = False Then
    '                    Exit For
    '                End If
    '            Next
    '            If i = tCust.Rows.Count Then
    '                tCust.Rows(0)("Agregar") = True
    '            End If
    '        End If
    '        'Me.dgDepositos(0, hti.Column) = False 'Not CBool(Me.dgDepositos(0, hti.Column))
    '    End If

    '    If dgDepositos.CurrentRowIndex = 0 And tCust.Rows(0)("Agregar") = True And hti.Column = myCheckBoxCol Then
    '        For i = 1 To tCust.Rows.Count - 1
    '            tCust.Rows(i)("Agregar") = True
    '        Next
    '    ElseIf dgDepositos.CurrentRowIndex = 0 And tCust.Rows(0)("Agregar") = False And hti.Column = myCheckBoxCol Then
    '        For i = 1 To tCust.Rows.Count - 1
    '            tCust.Rows(i)("Agregar") = False
    '        Next
    '    End If

    '    For i = 1 To tCust.Rows.Count - 1 'ds.Tables("Cobros").Rows.Count - 1
    '        If rbEfectivo.Checked = True Then
    '            If tCust.Rows(i)("Agregar") = True Then
    '                Asignar = Asignar + CDbl(tCust.Rows(i)("MontoAsignar")).ToString(Round)
    '            End If
    '        Else
    '            If tCust.Rows(i)("Agregar") = True Then
    '                Asignar = Asignar + CDbl(tCust.Rows(i)("MontoCheque")).ToString(Round)
    '            End If
    '        End If
    '    Next

    '    etMontoAsignar.Text = Asignar.ToString(Round)

    'End Sub 'dataGrid2_MouseUp 

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim Cantidad As Integer = 0
        Dim MontoAsignar As Double = 0
        Dim dsCobrosxFecha As DataSet

        Checked = False


        If cbDepositos.Text = "" Then
            MsgBox("Seleccione la Hoja de Deposito", MsgBoxStyle.Information)
            cbDepositos.Focus()
            Exit Sub
        End If

        For i As Integer = 0 To Me.vDatos.DataRowCount - 1  'Validar
            If Me.vDatos.GetRowCellValue(i, "Agregar") Then
                Cantidad += 1
            End If
        Next

        If Cantidad = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Debe Seleccionar al menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        '
        Try

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            For i As Integer = 0 To Me.vDatos.DataRowCount - 1
                If Me.vDatos.GetRowCellValue(i, "Agregar") Then
                    If Me.rgTipo.EditValue = 1 Then 'Efectivo
                        If Me.vDatos.GetRowCellValue(i, "Comp_No") <> 0 Then    'Otros Ingresos
                            Comprobantes.PagosFactura(Me.vDatos.GetRowCellValue(i, "Comp_No"), _
                                                      Me.vDatos.GetRowCellValue(i, "Per_ID"), _
                                                      CDate(Me.vDatos.GetRowCellValue(i, "Fecha")).Month, _
                                                      Me.vDatos.GetRowCellValue(i, "MontoAsignar"), _
                                                      Me.vDatos.GetRowCellValue(i, "Comp_No"), _
                                                      Me.vDatos.GetRowCellValue(i, "Per_ID"), _
                                                      CDate(Me.vDatos.GetRowCellValue(i, "Fecha")).Month, _
                                                      cbDepositos.SelectedValue, 0, 0)
                        Else    'Ingresos
                            dsCobrosxFecha = Clientes.CobrosXFecha(Me.vDatos.GetRowCellValue(i, "Fecha"))
                            MontoAsignar = Me.vDatos.GetRowCellValue(i, "MontoAsignar")

                            If Resumido = 1 Then    'Resumido
                                For j As Integer = 0 To dsCobrosxFecha.Tables("Cobros").Rows.Count - 1
                                    If MontoAsignar = dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo") Then
                                        Depositos.AddItemDetalles(cbDepositos.SelectedValue, dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), MontoAsignar)
                                        Clientes.CobrosUpdateMontoDepositado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), MontoAsignar)
                                        Clientes.CobrosUpdateEstado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), 1)
                                        Exit For
                                    ElseIf MontoAsignar < dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo") Then
                                        Depositos.AddItemDetalles(cbDepositos.SelectedValue, dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), MontoAsignar)
                                        Clientes.CobrosUpdateMontoDepositado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), MontoAsignar)
                                        Exit For
                                    ElseIf MontoAsignar > dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo") Then
                                        Depositos.AddItemDetalles(cbDepositos.SelectedValue, dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo"))
                                        Clientes.CobrosUpdateMontoDepositado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo"))
                                        Clientes.CobrosUpdateEstado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), 1)
                                        MontoAsignar = MontoAsignar - dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo")
                                    End If
                                Next
                            Else    'Si es detallado
                                Depositos.AddItemDetalles(cbDepositos.SelectedValue, Me.vDatos.GetRowCellValue(i, "Numero"), Me.vDatos.GetRowCellValue(i, "MontoAsignar"))
                                Clientes.CobrosUpdateMontoDepositado(Me.vDatos.GetRowCellValue(i, "Numero"), Me.vDatos.GetRowCellValue(i, "MontoAsignar"))
                                If Me.vDatos.GetRowCellValue(i, "Monto") = Me.vDatos.GetRowCellValue(i, "MontoAsignar") Then
                                    Clientes.CobrosUpdateEstado(Me.vDatos.GetRowCellValue(i, "Numero"), 1)
                                End If
                            End If

                        End If
                    Else                'Cheque o Tarjeta
                        If Me.vDatos.GetRowCellValue(i, "Comp_No") <> 0 Then    'Otros Ingresos
                            Comprobantes.PagosFactura(Me.vDatos.GetRowCellValue(i, "Comp_No"), _
                                                      Me.vDatos.GetRowCellValue(i, "Per_ID"), _
                                                      CDate(Me.vDatos.GetRowCellValue(i, "Fecha")).Month, _
                                                      Me.vDatos.GetRowCellValue(i, "Monto"), _
                                                      Me.vDatos.GetRowCellValue(i, "Comp_No"), _
                                                      Me.vDatos.GetRowCellValue(i, "Per_ID"), _
                                                      CDate(Me.vDatos.GetRowCellValue(i, "Fecha")).Month, _
                                                      cbDepositos.SelectedValue, 0, 0)
                        Else    'Ingresos
                            Depositos.AddItemDetalles(cbDepositos.SelectedValue, Me.vDatos.GetRowCellValue(i, "Numero"), Me.vDatos.GetRowCellValue(i, "Monto"))
                            Clientes.CobrosUpdateMontoDepositado(Me.vDatos.GetRowCellValue(i, "Numero"), Me.vDatos.GetRowCellValue(i, "Monto"))
                            If Me.vDatos.GetRowCellValue(i, "Monto") = Me.vDatos.GetRowCellValue(i, "MontoAsignar") Then
                                Clientes.CobrosUpdateEstado(Me.vDatos.GetRowCellValue(i, "Numero"), 1)
                            End If
                        End If
                    End If
                End If
            Next

            'For i As Integer = 1 To tCust.Rows.Count - 1
            '    If tCust.Rows(i)("Agregar") = True Then
            '        If rgTipo.EditValue = 1 Then
            '            'If rbEfectivo.Checked = True Then
            '            If tCust.Rows(i)("Comp") <> "0" Then 'Otros Ingresos
            '                Comprobantes.PagosFactura(tCust.Rows(i)("Comp"), tCust.Rows(i)("Periodo"), tCust.Rows(i)("Mes"), tCust.Rows(i)("MontoAsignar"), tCust.Rows(i)("Comp"), tCust.Rows(i)("Periodo"), tCust.Rows(i)("Mes"), cbDepositos.SelectedValue, 0, 0)
            '            Else
            '                dsCobrosxFecha = Clientes.CobrosXFecha(tCust.Rows(i)("Fecha"))
            '                MontoAsignar = tCust.Rows(i)("MontoAsignar") 'dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo")
            '                If Resumido = 1 Then
            '                    For j = 0 To dsCobrosxFecha.Tables("Cobros").Rows.Count - 1
            '                        If MontoAsignar = dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo") Then
            '                            Depositos.AddItemDetalles(cbDepositos.SelectedValue, dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), MontoAsignar)
            '                            Clientes.CobrosUpdateMontoDepositado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), MontoAsignar)
            '                            Clientes.CobrosUpdateEstado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), 1)
            '                            Exit For
            '                        ElseIf MontoAsignar < dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo") Then
            '                            Depositos.AddItemDetalles(cbDepositos.SelectedValue, dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), MontoAsignar)
            '                            Clientes.CobrosUpdateMontoDepositado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), MontoAsignar)
            '                            Exit For
            '                        ElseIf MontoAsignar > dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo") Then
            '                            Depositos.AddItemDetalles(cbDepositos.SelectedValue, dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo"))
            '                            Clientes.CobrosUpdateMontoDepositado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo"))
            '                            Clientes.CobrosUpdateEstado(dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Numero"), 1)
            '                            MontoAsignar = MontoAsignar - dsCobrosxFecha.Tables("Cobros").Rows(j).Item("Monto_Efectivo")
            '                        End If
            '                    Next
            '                Else 'si es detallado
            '                    Depositos.AddItemDetalles(cbDepositos.SelectedValue, tCust.Rows(i)("Numero"), tCust.Rows(i)("MontoAsignar"))
            '                    Clientes.CobrosUpdateMontoDepositado(tCust.Rows(i)("Numero"), tCust.Rows(i)("MontoAsignar"))
            '                    If tCust.Rows(i)("Monto") = tCust.Rows(i)("MontoAsignar") Then
            '                        Clientes.CobrosUpdateEstado(tCust.Rows(i)("Numero"), 1)
            '                    End If
            '                End If
            '            End If

            '        Else 'Cheque
            '            If tCust.Rows(i)("Comp") <> "0" Then 'Otros Ingresos
            '                Comprobantes.PagosFactura(tCust.Rows(i)("Comp"), tCust.Rows(i)("Periodo"), tCust.Rows(i)("Mes"), tCust.Rows(i)("MontoCheque"), tCust.Rows(i)("Comp"), tCust.Rows(i)("Periodo"), tCust.Rows(i)("Mes"), cbDepositos.SelectedValue, 0, 0)
            '            Else
            '                Depositos.AddItemDetalles(cbDepositos.SelectedValue, tCust.Rows(i)("Numero"), tCust.Rows(i)("MontoCheque"))
            '                Clientes.CobrosUpdateMontoDepositado(tCust.Rows(i)("Numero"), tCust.Rows(i)("MontoCheque"))
            '                Clientes.CobrosUpdateEstado(tCust.Rows(i)("Numero"), 1)
            '            End If

            '        End If
            '        Cantidad = 1
            '    End If
            'Next


            VB.SysContab.Rutinas.okTransaccion()

            rgTipo_SelectedIndexChanged(Nothing, Nothing)   'Cargar
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox(ex.Message & "Guardar", MsgBoxStyle.Critical)
            Exit Sub
        End Try

        ''If rbCheques.Checked = True Then
        'If rgTipo.EditValue = 2 Then
        '    ds = Clientes.Depositos(2, 0, Fecha, cbBancos.EditValue, Resumido, Me.cbSeries.EditValue)
        '    'MakeDataSet()
        '    'dgDepositos.SetDataBinding(myDataSet, "Item")
        '    'AddCustomDataTableStyle()
        'Else
        '    ds = Clientes.Depositos(1, 0, Fecha, 0, Resumido, Me.cbSeries.EditValue)
        '    'MakeDataSetEfectivo()
        '    'dgDepositos.SetDataBinding(myDataSet, "Item")
        '    'AddCustomDataTableStyleEfectivo()
        'End If

        'etMontoAsignar.Text = CDbl(0).ToString(Round)
        ''ds = Clientes.Depositos(2, 0, dtpFecha.Value, cbBancos.SelectedValue, Todo)

        ' ''MakeDataSet()
        ' ''dgDepositos.SetDataBinding(myDataSet, "Item")
        ' ''AddCustomDataTableStyle()
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        If cbFecha.Checked = True Then
            Fecha = dtpFecha.Value.Date
        Else
            Fecha = ""
        End If

        'If rbCheques.Checked = True Then
        If rgTipo.EditValue = 2 Then
            ds = Clientes.Depositos(2, 0, Fecha, cbBancos.EditValue, Resumido)

            'MakeDataSet()
            'dgDepositos.SetDataBinding(myDataSet, "Item")
            'AddCustomDataTableStyle()
        Else
            ds = Clientes.Depositos(1, 0, Fecha, cbBancos.EditValue, Resumido)

            MakeDataSetEfectivo()
            'dgDepositos.SetDataBinding(myDataSet, "Item")
            'AddCustomDataTableStyleEfectivo()
        End If


    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cbBancos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If cbBancos.Enabled = False Then
            Exit Sub
        End If

        If Inicio = True Then
            Exit Sub
        End If

        If IsNumeric(cbBancos.EditValue) Then
            ds = Clientes.Depositos(2, 0, Fecha, cbBancos.EditValue, Resumido)

            'MakeDataSet()
            'dgDepositos.SetDataBinding(myDataSet, "Item")
            'AddCustomDataTableStyle()
        End If
    End Sub

    'Private Sub cbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTodos.CheckedChanged
    '    If cbTodos.Checked = True Then
    '        cbBancos.SelectedValue = 0
    '        dtpFecha.Enabled = False
    '        cbBancos.Enabled = False
    '        Todo = 1
    '    Else
    '        dtpFecha.Enabled = True
    '        cbBancos.Enabled = True
    '        Todo = 0
    '    End If

    '    ds = Clientes.Depositos(2, 0, Fecha, cbBancos.SelectedValue)

    '    'MakeDataSet()
    '    'dgDepositos.SetDataBinding(myDataSet, "Item")
    '    'AddCustomDataTableStyle()
    'End Sub

    Private Sub cmdVerDepositos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerDepositos.Click
        Dim f As frmDepositosList = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub MakeDataSetEfectivo()
        myDataSet = New DataSet("myDataSet")

        tCust = New DataTable("Item")

        Dim i As Integer

        Total = 0
        Depositado = 0
        Disponible = 0
        Asignar = 0

        If Resumido = 0 Then
            Dim cNumero As DataColumn
            cNumero = New DataColumn("Numero")
            tCust.Columns.Add(cNumero)

            Dim cRecibo As DataColumn
            cRecibo = New DataColumn("Recibo")
            tCust.Columns.Add(cRecibo)

            Dim cFactura As DataColumn
            cFactura = New DataColumn("Factura")
            tCust.Columns.Add(cFactura)
        End If

        Dim cFecha As DataColumn
        cFecha = New DataColumn("Fecha")
        tCust.Columns.Add(cFecha)

        Dim cIngreso As DataColumn
        cIngreso = New DataColumn("Ingreso")
        tCust.Columns.Add(cIngreso)

        Dim cDepositado As DataColumn
        cDepositado = New DataColumn("Depositado")
        tCust.Columns.Add(cDepositado)

        Dim cMonto As DataColumn
        cMonto = New DataColumn("Monto")
        tCust.Columns.Add(cMonto)

        Dim cMontoAsignar As DataColumn
        cMontoAsignar = New DataColumn("MontoAsignar")
        tCust.Columns.Add(cMontoAsignar)

        Dim cAgregar As DataColumn
        cAgregar = New DataColumn("Agregar", GetType(System.Boolean))
        tCust.Columns.Add(cAgregar)

        Dim cComp As DataColumn
        cComp = New DataColumn("Comp")
        tCust.Columns.Add(cComp)

        Dim cEmpresa As DataColumn
        cEmpresa = New DataColumn("Empresa")
        tCust.Columns.Add(cEmpresa)

        Dim cPeriodo As DataColumn
        cPeriodo = New DataColumn("Periodo")
        tCust.Columns.Add(cPeriodo)

        Dim cMes As DataColumn
        cMes = New DataColumn("Mes")
        tCust.Columns.Add(cMes)

        'tCust.DefaultView.AllowDelete = False
        'tCust.DefaultView.AllowNew = False
        'tCust.DefaultView.AllowEdit = False

        myDataSet.Tables.Add(tCust)

        Dim newRow1 As DataRow
        newRow1 = tCust.NewRow
        tCust.Rows.Add(newRow1)

        Dim j As Integer

        If Checked = True Then
            tCust.Rows(0)("Agregar") = True
        Else
            tCust.Rows(0)("Agregar") = False
        End If

        j = 1

        For i = 0 To ds.Tables("Cobros").Rows.Count - 1
            If CDbl(ds.Tables("Cobros").Rows(i).Item("MontoAsignar")).ToString(Round) = 0 Then
                ''
            Else
                newRow1 = tCust.NewRow
                tCust.Rows.Add(newRow1)

                If Resumido = 0 Then
                    'tCust.Rows(i + 1)("Numero") = ds.Tables("Cobros").Rows(i).Item("Numero")
                    tCust.Rows(j)("Numero") = ds.Tables("Cobros").Rows(i).Item("Numero")
                    tCust.Rows(j)("Recibo") = ds.Tables("Cobros").Rows(i).Item("Recibo")
                    tCust.Rows(j)("Factura") = ds.Tables("Cobros").Rows(i).Item("Factura")

                End If

                'tCust.Rows(i + 1)("Numero") = ds.Tables("Cobros").Rows(i).Item("Numero")
                'tCust.Rows(i + 1)("Cheque") = ds.Tables("Cobros").Rows(i).Item("No Cheque")
                'tCust.Rows(i + 1)("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
                tCust.Rows(j)("Fecha") = Format(ds.Tables("Cobros").Rows(i).Item("Fecha"), "dd/MM/yyyy")
                tCust.Rows(j)("Ingreso") = CDbl(ds.Tables("Cobros").Rows(i).Item("Ingreso")).ToString(Round)
                tCust.Rows(j)("Depositado") = CDbl(ds.Tables("Cobros").Rows(i).Item("Depositado")).ToString(Round)
                tCust.Rows(j)("Monto") = CDbl(ds.Tables("Cobros").Rows(i).Item("MontoAsignar")).ToString(Round)
                tCust.Rows(j)("MontoAsignar") = CDbl(ds.Tables("Cobros").Rows(i).Item("MontoAsignar")).ToString(Round)
                tCust.Rows(j)("Comp") = ds.Tables("Cobros").Rows(i).Item("Comp_No")
                tCust.Rows(j)("Empresa") = ds.Tables("Cobros").Rows(i).Item("Empresa")
                tCust.Rows(j)("Periodo") = ds.Tables("Cobros").Rows(i).Item("Per_ID")
                tCust.Rows(j)("Mes") = ds.Tables("Cobros").Rows(i).Item("Mes")

                If Checked = True Then
                    tCust.Rows(j)("Agregar") = True
                Else
                    tCust.Rows(j)("Agregar") = False
                End If

                j = j + 1

            End If

            'tCust.Rows(i + 1)("Agregar") = False
            Total = Total + CDbl(ds.Tables("Cobros").Rows(i).Item("Ingreso")).ToString(Round)
            Depositado = Depositado + CDbl(ds.Tables("Cobros").Rows(i).Item("Depositado")).ToString(Round)
            Disponible = Disponible + CDbl(ds.Tables("Cobros").Rows(i).Item("MontoAsignar")).ToString(Round)
            'Asignar = Asignar + CDbl(ds.Tables("Cobros").Rows(i).Item("MontoAsignar")).ToString(Round)

        Next

        myDataSet.Tables("Item").DefaultView.AllowDelete = False

        etIngresos.Text = Total.ToString(Round)
        etDepositado.Text = Depositado.ToString(Round)
        etDisponible.Text = Disponible.ToString(Round)
        etMontoAsignar.Text = Asignar.ToString(Round)

    End Sub

    'Private Sub TextBoxMontoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
    '    'If dgDepositos.CurrentRowIndex = 0 Or dgDepositos.CurrentRowIndex = tCust.Rows.Count Then
    '    '    Exit Sub
    '    'End If

    '    If Not IsNumeric(MontoAsignar.TextBox.Text) Then
    '        MontoAsignar.TextBox.Text = ValorActualMonto.ToString(Round)
    '        Exit Sub
    '    Else
    '        'Asignar = Asignar - MontoAsignar.TextBox.Text
    '        If CDbl(MontoAsignar.TextBox.Text) <= 0 Then
    '            MsgBox("El Monto a Asignar debe ser mayor que Cero (0)", MsgBoxStyle.Information)
    '            MontoAsignar.TextBox.Text = ValorActualMonto.ToString(Round)
    '            'Cantidad.TextBox.Focus()
    '            Exit Sub
    '        ElseIf CDbl(MontoAsignar.TextBox.Text) > CDbl(tCust.Rows(dgDepositos.CurrentRowIndex)("Monto")) Then
    '            MsgBox("El Monto a Asignar debe ser menor o igual que el Monto ...", MsgBoxStyle.Information)
    '            MontoAsignar.TextBox.Text = ValorActualMonto.ToString(Round)
    '        Else
    '            'If MontoAsignar.TextBox.Text = "0" Then
    '            '    MontoAsignar.TextBox.Text = "0.00"
    '            'Else
    '            MontoAsignar.TextBox.Text = CDbl(MontoAsignar.TextBox.Text).ToString(Round)

    '            'If CDbl(MontoAsignar.TextBox.Text) = 0 Then
    '            '    tCust.Rows(dgDepositos.CurrentRowIndex)("Agregar") = False
    '            'End If

    '            'End If
    '            'Descuento.TextBox.Refresh()
    '        End If

    '        Asignar = 0
    '        For i = 1 To tCust.Rows.Count - 1 'ds.Tables("Cobros").Rows.Count - 1
    '            If tCust.Rows(i)("Agregar") = True Then
    '                Asignar = Asignar + CDbl(tCust.Rows(i)("MontoAsignar")).ToString(Round)
    '            End If
    '        Next
    '        'Asignar = Asignar + MontoAsignar.TextBox.Text
    '        etMontoAsignar.Text = Asignar.ToString(Round)
    '    End If

    'End Sub

    'Private Sub AddCustomDataTableStyleEfectivo()
    '    Dim ts1 As DataGridTableStyle
    '    ts1 = New DataGridTableStyle
    '    ts1.MappingName = "Item"
    '    ts1.AlternatingBackColor = Color.LightBlue
    '    Dim colCount As Integer
    '    colCount = 0

    '    If Resumido = 0 Then
    '        Dim Numero As New DataGridTextBoxColumn
    '        Numero.MappingName = "Numero"
    '        Numero.HeaderText = "Numero"
    '        Numero.ReadOnly = True
    '        Numero.Alignment = HorizontalAlignment.Left
    '        Numero.Width = 0
    '        Numero.NullText = ""

    '        ts1.GridColumnStyles.Add(Numero)
    '        colCount = (colCount + 1)

    '        Dim Recibo As New DataGridTextBoxColumn
    '        Recibo.MappingName = "Recibo"
    '        Recibo.HeaderText = "Recibo"
    '        Recibo.ReadOnly = True
    '        Recibo.Alignment = HorizontalAlignment.Left
    '        Recibo.Width = 75
    '        Recibo.NullText = ""

    '        ts1.GridColumnStyles.Add(Recibo)
    '        colCount = (colCount + 1)

    '        Dim Factura As New DataGridTextBoxColumn
    '        Factura.MappingName = "Factura"
    '        Factura.HeaderText = "Factura"
    '        Factura.ReadOnly = True
    '        Factura.Alignment = HorizontalAlignment.Left
    '        Factura.Width = 75
    '        Factura.NullText = ""

    '        ts1.GridColumnStyles.Add(Factura)
    '        colCount = (colCount + 1)
    '    End If

    '    Dim Fecha As New DataGridTextBoxColumn
    '    Fecha.MappingName = "Fecha"
    '    Fecha.HeaderText = "Fecha"
    '    Fecha.ReadOnly = True
    '    Fecha.Alignment = HorizontalAlignment.Left
    '    Fecha.Width = 80
    '    Fecha.NullText = ""
    '    ts1.GridColumnStyles.Add(Fecha)
    '    colCount = (colCount + 1)

    '    Dim Ingreso As New DataGridTextBoxColumn
    '    Ingreso.MappingName = "Ingreso"
    '    Ingreso.HeaderText = "Ingreso"
    '    Ingreso.ReadOnly = True
    '    Ingreso.Alignment = HorizontalAlignment.Right
    '    Ingreso.Width = 100
    '    Ingreso.NullText = ""

    '    ts1.GridColumnStyles.Add(Ingreso)
    '    colCount = (colCount + 1)


    '    Dim Depositado As New DataGridTextBoxColumn
    '    Depositado.MappingName = "Depositado"
    '    Depositado.HeaderText = "Depositado"
    '    Depositado.ReadOnly = True
    '    Depositado.Alignment = HorizontalAlignment.Right
    '    Depositado.Width = 100
    '    Depositado.NullText = ""

    '    ts1.GridColumnStyles.Add(Depositado)
    '    colCount = (colCount + 1)

    '    Dim MontoCheque As New DataGridTextBoxColumn
    '    MontoCheque.MappingName = "Monto"
    '    MontoCheque.HeaderText = "Monto"
    '    MontoCheque.ReadOnly = True
    '    MontoCheque.Alignment = HorizontalAlignment.Right
    '    MontoCheque.Width = 100
    '    MontoCheque.NullText = ""
    '    ts1.GridColumnStyles.Add(MontoCheque)
    '    colCount = (colCount + 1)

    '    'Dim MontoAsignar As New DataGridTextBoxColumn()
    '    MontoAsignar.MappingName = "MontoAsignar"
    '    MontoAsignar.HeaderText = "Monto Asignar"
    '    MontoAsignar.ReadOnly = False
    '    MontoAsignar.Alignment = HorizontalAlignment.Right
    '    MontoAsignar.Width = 100
    '    MontoAsignar.NullText = ""

    '    AddHandler MontoAsignar.TextBox.Leave, New EventHandler(AddressOf TextBoxMontoLeaveHandler)

    '    ts1.GridColumnStyles.Add(MontoAsignar)
    '    colCount = (colCount + 1)

    '    Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
    '    boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
    '    boolCol.MappingName = "Agregar"
    '    boolCol.HeaderText = "Agregar"
    '    boolCol.Alignment = HorizontalAlignment.Center
    '    CType(boolCol, DataGridBoolColumn).AllowNull = False
    '    boolCol.Width = 70
    '    boolCol.ReadOnly = False
    '    boolCol.NullText = ""
    '    AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
    '    ts1.GridColumnStyles.Add(boolCol)
    '    colCount = (colCount + 1)

    '    Dim Comp As New DataGridTextBoxColumn
    '    Comp.MappingName = "Comp"
    '    Comp.HeaderText = ""
    '    Comp.ReadOnly = True
    '    Comp.Alignment = HorizontalAlignment.Right
    '    Comp.Width = 0
    '    Comp.NullText = ""
    '    ts1.GridColumnStyles.Add(Comp)
    '    colCount = (colCount + 1)

    '    Dim Empresa As New DataGridTextBoxColumn
    '    Empresa.MappingName = "Empresa"
    '    Empresa.HeaderText = ""
    '    Empresa.ReadOnly = True
    '    Empresa.Alignment = HorizontalAlignment.Right
    '    Empresa.Width = 0
    '    Empresa.NullText = ""
    '    ts1.GridColumnStyles.Add(Empresa)
    '    colCount = (colCount + 1)

    '    Dim Periodo As New DataGridTextBoxColumn
    '    Periodo.MappingName = "Periodo"
    '    Periodo.HeaderText = ""
    '    Periodo.ReadOnly = True
    '    Periodo.Alignment = HorizontalAlignment.Right
    '    Periodo.Width = 0
    '    Periodo.NullText = ""
    '    ts1.GridColumnStyles.Add(Periodo)
    '    colCount = (colCount + 1)

    '    Dim Mes As New DataGridTextBoxColumn
    '    Mes.MappingName = "Mes"
    '    Mes.HeaderText = ""
    '    Mes.ReadOnly = True
    '    Mes.Alignment = HorizontalAlignment.Right
    '    Mes.Width = 0
    '    Mes.NullText = ""
    '    ts1.GridColumnStyles.Add(Mes)
    '    colCount = (colCount + 1)

    '    ts1.AllowSorting = False
    '    ts1.HeaderFont = dgDepositos.HeaderFont
    '    ts1.GridLineColor = Color.FromArgb(70, 130, 180)
    '    ts1.HeaderBackColor = Color.LightSteelBlue
    '    ts1.PreferredRowHeight = 25
    '    Me.dgDepositos.CaptionVisible = False

    '    myDataSet.Tables("Item").DefaultView.AllowDelete = False
    '    myDataSet.Tables("Item").DefaultView.AllowNew = False
    '    myDataSet.Tables("Item").DefaultView.AllowEdit = True

    '    dgDepositos.TableStyles.Clear()
    '    dgDepositos.TableStyles.Add(ts1)

    'End Sub

    Private Sub rbEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Inicio = True Then
            Exit Sub
        End If

        etMontoAsignar.Text = CDbl(0).ToString(Round)
        etDepositado.Text = CDbl(0).ToString(Round)
        etIngresos.Text = CDbl(0).ToString(Round)

        If Inicio = False Then
            Checked = False
        End If


        'If rbDetallado.Checked = True Then
        '    myCheckBoxCol = 8
        'Else
        '    myCheckBoxCol = 5
        'End If

        'If rbEfectivo.Checked = True Then
        If rgTipo.EditValue = 2 Then
            'dgDepositos.ReadOnly = False
            cbBancos.Enabled = False
            'GroupBox3.Enabled = True
            Me.rgResumen.Enabled = True

            ds = Clientes.Depositos(1, 0, Fecha, 0, Resumido)

            '  MakeDataSetEfectivo()
            'dgDepositos.SetDataBinding(myDataSet, "Item")
            ' AddCustomDataTableStyleEfectivo()
        End If
    End Sub

    Private Sub rbCheques_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Checked = False
        myCheckBoxCol = 6 'my checkbox column 
        etMontoAsignar.Text = CDbl(0).ToString(Round)
        etDepositado.Text = CDbl(0).ToString(Round)
        etIngresos.Text = CDbl(0).ToString(Round)

        'If rbCheques.Checked = True Then
        If rgTipo.EditValue = 2 Then
            'dgDepositos.ReadOnly = True
            cbBancos.Enabled = True
            'GroupBox3.Enabled = False
            Me.rgResumen.Enabled = False

            ds = Clientes.Depositos(2, 0, Fecha, cbBancos.EditValue, Resumido)

            'MakeDataSet()
            'dgDepositos.SetDataBinding(myDataSet, "Item")
            'AddCustomDataTableStyle()
        End If
    End Sub

    Private Sub cbFecha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFecha.Click
        Checked = False
        If cbFecha.Checked = True Then
            dtpFecha.Enabled = True
            Fecha = dtpFecha.Value.Date
        Else
            dtpFecha.Enabled = False
            Fecha = ""
        End If

        'If rbCheques.Checked = True Then
        If rgTipo.EditValue = 2 Then
            ds = Clientes.Depositos(2, 0, Fecha, cbBancos.EditValue, Resumido)
            'MakeDataSet()
            'dgDepositos.SetDataBinding(myDataSet, "Item")
            'AddCustomDataTableStyle()
        Else
            ds = Clientes.Depositos(1, 0, Fecha, 0, Resumido)
            MakeDataSetEfectivo()
            'dgDepositos.SetDataBinding(myDataSet, "Item")
            'AddCustomDataTableStyleEfectivo()
        End If

    End Sub

    'Private Sub rbDetallado_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Checked = False
    '    Resumido = 0
    '    myCheckBoxCol = 8
    '    ds = Clientes.Depositos(1, 0, Fecha, 0, Resumido, Me.cbSeries.EditValue)
    '    MakeDataSetEfectivo()
    '    'dgDepositos.SetDataBinding(myDataSet, "Item")
    '    ' AddCustomDataTableStyleEfectivo()

    'End Sub

    'Private Sub rbResumido_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Checked = False
    '    Resumido = 1
    '    myCheckBoxCol = 5
    '    ds = Clientes.Depositos(1, 0, Fecha, 0, Resumido)
    '    MakeDataSetEfectivo()
    '    'dgDepositos.SetDataBinding(myDataSet, "Item")
    '    'AddCustomDataTableStyleEfectivo()
    'End Sub

    'Private Sub cbBancos_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Checked = False
    'End Sub

    'Private Sub dgDepositos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        If rbEfectivo.Checked = True Then
    '            If dgDepositos.CurrentRowIndex = 0 Or dgDepositos.CurrentRowIndex = tCust.Rows.Count Then
    '                dgDepositos.ReadOnly = True
    '            Else
    '                dgDepositos.ReadOnly = False
    '                ValorActualMonto = tCust.Rows(dgDepositos.CurrentRowIndex)("MontoAsignar")
    '            End If
    '        End If
    '    Catch
    '    End Try
    'End Sub

    Private Sub frmAsignarDepositos_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'Dim f As frmCobrosTotales = f.Instance
        ''f.dgCobrosTotales.DataSource = Clientes.CobrosXTotales(f.dtpFecha.Value.Date).Tables("Cobros").DefaultView
        'f.'MakeDataSet()
        'f.dgCobrosTotales.SetDataBinding(myDataSet, "Item")
        'f.'AddCustomDataTableStyle()
    End Sub

    Dim Fecha1 As String
    Dim Fecha2 As String
    Private Sub cBoxFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBoxFecha.CheckedChanged
        If cBoxFecha.Checked = True Then
            Fecha1 = dtpFecha1.Value.Date
            Fecha2 = dtpFecha1.Value.Date
            dtpFecha1.Enabled = True
        Else
            dtpFecha1.Enabled = False
            Fecha1 = ""
            Fecha2 = ""
        End If

        cbDepositos.DataSource = Depositos.List(0, Fecha1, Fecha2, 0).Tables("Depositos")
        cbDepositos.ValueMember = "Deposito_ID"
        cbDepositos.DisplayMember = "DisplayMember"
    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged
        'If Fecha1 = Nothing Then
        '    Exit Sub
        'End If

        Fecha1 = dtpFecha1.Value.Date
        Fecha2 = dtpFecha1.Value.Date

        cbDepositos.DataSource = Depositos.List(0, Fecha1, Fecha2, 0).Tables("Depositos")
        cbDepositos.ValueMember = "Deposito_ID"
        cbDepositos.DisplayMember = "DisplayMember"
    End Sub

    Private Sub rgDtl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgResumen.SelectedIndexChanged
        Resumido = Me.rgResumen.EditValue
        GridEfectivo()

        'If Me.rgDtl.EditValue = 1 Then  'Resumido
        '    Checked = False
        '    Resumido = 1
        '    myCheckBoxCol = 5
        '    ds = Clientes.Depositos(1, 0, Fecha, 0, Resumido)
        '    MakeDataSetEfectivo()

        'ElseIf Me.rgDtl.EditValue = 0 Then  'Detallado
        '    Checked = False
        '    Resumido = 0
        '    myCheckBoxCol = 8
        '    ds = Clientes.Depositos(1, 0, Fecha, 0, Resumido)
        '    MakeDataSetEfectivo()
        'End If
    End Sub

    Private Sub rgTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgTipo.SelectedIndexChanged
        If Inicio = True Then Exit Sub

        If Me.rgTipo.EditValue = 1 Then 'Efectivo

            etMontoAsignar.Text = CDbl(0).ToString(Round)
            etDepositado.Text = CDbl(0).ToString(Round)
            etIngresos.Text = CDbl(0).ToString(Round)

            Me.rgResumen.Enabled = True

            If Inicio = False Then Checked = False

            'If rbDetallado.Checked = True Then
            '    myCheckBoxCol = 8
            'Else
            '    myCheckBoxCol = 5
            'End If

            'If rbEfectivo.Checked = True Then
            'dgDepositos.ReadOnly = False
            cbBancos.Enabled = False
            'GroupBox3.Enabled = True
            Me.rgResumen.Enabled = True
            '
            GridEfectivo()

            'MakeDataSetEfectivo()
            ''dgDepositos.SetDataBinding(myDataSet, "Item")
            'AddCustomDataTableStyleEfectivo()
            'End If



        ElseIf Me.rgTipo.EditValue = 2 Then  'Cheque

            Checked = False
            'myCheckBoxCol = 6 'my checkbox column 

            etMontoAsignar.Text = CDbl(0).ToString(Round)
            etDepositado.Text = CDbl(0).ToString(Round)
            etIngresos.Text = CDbl(0).ToString(Round)

            Me.rgResumen.Enabled = False

            'If rbCheques.Checked = True Then
            'dgDepositos.ReadOnly = True

            cbBancos.Enabled = True
            'GroupBox3.Enabled = False
            Me.rgResumen.Enabled = False

            GridCheque()

            'ds = Clientes.Depositos(2, 0, Fecha, cbBancos.SelectedValue, Resumido)
            'Me.dgDatos.DataSource = ds.Tables("Cobros")
            'Me.vDatos.PopulateColumns()
            'FormatoGrid(Me.vDatos)

            ''MakeDataSet()
            ''dgDepositos.SetDataBinding(myDataSet, "Item")
            ''AddCustomDataTableStyle()
            'End If

        ElseIf Me.rgTipo.EditValue = 3 Then  'Tarjeta
            etMontoAsignar.Text = CDbl(0).ToString(Round)
            etDepositado.Text = CDbl(0).ToString(Round)
            etIngresos.Text = CDbl(0).ToString(Round)

            cbBancos.Enabled = True
            Me.rgResumen.Enabled = True

            GridTarjeta()
        End If

    End Sub

    Private Sub rbCheques_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub GridEfectivo()
        ds = Clientes.Depositos(1, 0, Fecha, 0, Resumido)
        Me.dgDatos.DataSource = ds.Tables("Cobros")
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)

        Me.vDatos.Columns("Tipo").Visible = False
        Me.vDatos.Columns("Comp_No").Visible = False
        Me.vDatos.Columns("Empresa").Visible = False
        Me.vDatos.Columns("Per_ID").Visible = False
        Me.vDatos.Columns("Mes").Visible = False
        Me.vDatos.Columns("Estado").Visible = False
        If Resumido = 0 Then Me.vDatos.Columns("Numero").Visible = False 'Detallado

        For i As Integer = 0 To Me.vDatos.Columns.Count - 1
            Me.vDatos.Columns(i).OptionsColumn.AllowEdit = False
        Next

        Me.vDatos.Columns("Agregar").OptionsColumn.AllowEdit = True
        Me.vDatos.Columns("MontoAsignar").OptionsColumn.AllowEdit = True
        Me.vDatos.Columns("MontoAsignar").ColumnEdit = Me.txtAsignar

        Me.vDatos.Columns("Ingreso").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Ingreso").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Ingreso").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Ingreso").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("MontoAsignar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("MontoAsignar").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("MontoAsignar").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("MontoAsignar").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("Depositado").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Depositado").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Depositado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Depositado").SummaryItem.DisplayFormat = "{0:n2}"

        Me.etIngresos.Text = CDbl(Me.vDatos.Columns("Ingreso").SummaryItem.SummaryValue).ToString("n2")
        Me.etDepositado.Text = CDbl(Me.vDatos.Columns("Depositado").SummaryItem.SummaryValue).ToString("n2")
        Me.etDisponible.Text = CDbl(CDbl(Me.vDatos.Columns("Ingreso").SummaryItem.SummaryValue) - CDbl(Me.vDatos.Columns("Depositado").SummaryItem.SummaryValue)).ToString("n2")
        'Me.etMontoAsignar.Text = CDbl(Me.vDatos.Columns("MontoAsignar").SummaryItem.SummaryValue).ToString("n2")
    End Sub

    Sub GridCheque()

        ds = Clientes.Depositos(2, 0, Fecha, Me.cbBancos.EditValue, Resumido)
        Me.dgDatos.DataSource = ds.Tables("Cobros")
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)


        Me.vDatos.Columns("Numero").Visible = False
        Me.vDatos.Columns("Tipo").Visible = False
        Me.vDatos.Columns("Comp_No").Visible = False
        Me.vDatos.Columns("Empresa").Visible = False
        Me.vDatos.Columns("Per_ID").Visible = False
        Me.vDatos.Columns("Mes").Visible = False
        Me.vDatos.Columns("Estado").Visible = False
        Me.vDatos.BestFitColumns()

        For i As Integer = 0 To Me.vDatos.Columns.Count - 1
            Me.vDatos.Columns(i).OptionsColumn.AllowEdit = False
        Next

        Me.vDatos.Columns("Agregar").OptionsColumn.AllowEdit = True

        Me.vDatos.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

        Me.etIngresos.Text = CDbl(Me.vDatos.Columns("Monto").SummaryItem.SummaryValue).ToString("n2")
        Me.etDepositado.Text = CDbl(Me.vDatos.Columns("Monto").SummaryItem.SummaryValue).ToString("n2")
        Me.etDisponible.Text = CDbl(Me.vDatos.Columns("Monto").SummaryItem.SummaryValue).ToString("n2")
        'Me.etDisponible.Text = CDbl(CDbl(Me.vDatos.Columns("Monto").SummaryItem.SummaryValue) - CDbl(Me.vDatos.Columns("Depositado").SummaryItem.SummaryValue)).ToString("n2")
    End Sub

    Sub GridTarjeta()
        ds = Clientes.Depositos(3, 0, Fecha, Me.cbBancos.EditValue, Resumido)
        Me.dgDatos.DataSource = ds.Tables("Cobros")
        Me.vDatos.PopulateColumns()
        FormatoGrid(Me.vDatos)

        For i As Integer = 0 To Me.vDatos.Columns.Count - 1
            Me.vDatos.Columns(i).OptionsColumn.AllowEdit = False
        Next

        Me.vDatos.Columns("Agregar").OptionsColumn.AllowEdit = True

        Me.vDatos.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

        Me.etIngresos.Text = CDbl(Me.vDatos.Columns("Monto").SummaryItem.SummaryValue).ToString("n2")
        Me.etDepositado.Text = CDbl(Me.vDatos.Columns("Monto").SummaryItem.SummaryValue).ToString("n2")
        Me.etDisponible.Text = CDbl(Me.vDatos.Columns("Monto").SummaryItem.SummaryValue).ToString("n2")
    End Sub

    Sub Totales()

    End Sub

    Private Sub cbSeries_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSeries.EditValueChanged
        Try
            'rgTipo_SelectedIndexChanged(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub vDatos_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles vDatos.ValidateRow
        If Me.rgTipo.EditValue = 1 Then 'Efectivo
            If Me.vDatos.GetRowCellValue(e.RowHandle, "Agregar") Then
                If Me.vDatos.GetRowCellValue(e.RowHandle, "MontoAsignar") <= 0 Or _
                (Me.vDatos.GetRowCellValue(e.RowHandle, "MontoAsignar") > Me.vDatos.GetRowCellValue(e.RowHandle, "Monto")) Then
                    e.ErrorText = "El Monto a Asignar Deber ser Mayor que Cero (0) y Menor ó igual al Monto Disponible" & vbCrLf
                    e.Valid = False
                End If
            End If
        End If
    End Sub

    Private Sub cbBancos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBancos.EditValueChanged
        If cbBancos.Enabled = False Then
            Exit Sub
        End If

        If Inicio = True Then
            Exit Sub
        End If

        rgTipo_SelectedIndexChanged(Nothing, Nothing)

        'If IsNumeric(cbBancos.EditValue) Then
        '    ds = Clientes.Depositos(2, 0, Fecha, cbBancos.EditValue, Resumido, Me.cbSeries.EditValue)

        '    'MakeDataSet()
        '    'dgDepositos.SetDataBinding(myDataSet, "Item")
        '    'AddCustomDataTableStyle()
        'End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If Me.vDatos.DataRowCount = 0 Then Exit Sub

        For i As Integer = 0 To Me.vDatos.DataRowCount - 1
            Me.vDatos.SetRowCellValue(i, "Agregar", Me.CheckEdit1.Checked)
        Next

        Me.vDatos.RefreshData()
    End Sub
End Class
