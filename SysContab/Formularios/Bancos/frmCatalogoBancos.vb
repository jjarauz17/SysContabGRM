Imports DbConnect
Public Class frmCatalogoBancos
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmCatalogoBancos = Nothing

    Public Shared Function Instance() As frmCatalogoBancos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmCatalogoBancos
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

#Region "Variables"
    Public cBanco As String
    Dim cuenta As String
    Dim Cod_Cuenta As String
    Dim DetalleBanco As New VB.SysContab.BancosDetails
#End Region


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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbTipoCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoCheque As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfigurarCK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcnPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents Vista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgCatalogoBancos As DevExpress.XtraGrid.GridControl
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbInstitucion As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit
        Me.cbCatalogo = New DevExpress.XtraEditors.LookUpEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcnPlanilla = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCPlanilla = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbInstitucion = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNoCuenta = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbTipoCuenta = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNoCheque = New System.Windows.Forms.TextBox
        Me.cmdConfigurarCK = New DevExpress.XtraEditors.SimpleButton
        Me.dgCatalogoBancos = New DevExpress.XtraGrid.GridControl
        Me.Vista = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCatalogoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbMoneda)
        Me.GroupBox1.Controls.Add(Me.cbCatalogo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtcnPlanilla)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCPlanilla)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdAgregar)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbInstitucion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNoCuenta)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbTipoCuenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNoCheque)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 194)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(136, 95)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Properties.NullText = ""
        Me.cbMoneda.Size = New System.Drawing.Size(192, 20)
        Me.cbMoneda.TabIndex = 150
        '
        'cbCatalogo
        '
        Me.cbCatalogo.Location = New System.Drawing.Point(136, 26)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Properties.NullText = ""
        Me.cbCatalogo.Size = New System.Drawing.Size(528, 20)
        Me.cbCatalogo.TabIndex = 149
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(344, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 26)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "Consec. Planilla"
        '
        'txtcnPlanilla
        '
        Me.txtcnPlanilla.Location = New System.Drawing.Point(472, 155)
        Me.txtcnPlanilla.MaxLength = 5
        Me.txtcnPlanilla.Name = "txtcnPlanilla"
        Me.txtcnPlanilla.Size = New System.Drawing.Size(192, 21)
        Me.txtcnPlanilla.TabIndex = 147
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(344, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 26)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "e-Planilla "
        '
        'txtCPlanilla
        '
        Me.txtCPlanilla.Location = New System.Drawing.Point(472, 129)
        Me.txtCPlanilla.MaxLength = 4
        Me.txtCPlanilla.Name = "txtCPlanilla"
        Me.txtCPlanilla.Size = New System.Drawing.Size(192, 21)
        Me.txtCPlanilla.TabIndex = 145
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 26)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "No. Cheque:"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Appearance.Options.UseFont = True
        Me.cmdAgregar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAgregar.Location = New System.Drawing.Point(8, 164)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAgregar.TabIndex = 141
        Me.cmdAgregar.Text = "Agregar"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(344, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 35)
        Me.Label10.TabIndex = 139
        Me.Label10.Text = "Institucion Bancaria SIB"
        '
        'cbInstitucion
        '
        Me.cbInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbInstitucion.Location = New System.Drawing.Point(472, 95)
        Me.cbInstitucion.Name = "cbInstitucion"
        Me.cbInstitucion.Size = New System.Drawing.Size(192, 23)
        Me.cbInstitucion.TabIndex = 138
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 26)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Moneda:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(344, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 26)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "No. de Cuenta:"
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuenta.Location = New System.Drawing.Point(472, 60)
        Me.txtNoCuenta.MaxLength = 50
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(192, 21)
        Me.txtNoCuenta.TabIndex = 134
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 26)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Tipo de Cuenta"
        '
        'cbTipoCuenta
        '
        Me.cbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoCuenta.Items.AddRange(New Object() {"CORRIENTE", "CERTIFICADO DE DEPOSITO", "CUENTA DEL MERCADO", "AHORRO"})
        Me.cbTipoCuenta.Location = New System.Drawing.Point(136, 60)
        Me.cbTipoCuenta.Name = "cbTipoCuenta"
        Me.cbTipoCuenta.Size = New System.Drawing.Size(192, 23)
        Me.cbTipoCuenta.TabIndex = 132
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 26)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Cuenta:"
        '
        'txtNoCheque
        '
        Me.txtNoCheque.Location = New System.Drawing.Point(136, 129)
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.Size = New System.Drawing.Size(192, 21)
        Me.txtNoCheque.TabIndex = 143
        '
        'cmdConfigurarCK
        '
        Me.cmdConfigurarCK.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfigurarCK.Appearance.Options.UseFont = True
        Me.cmdConfigurarCK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdConfigurarCK.Location = New System.Drawing.Point(176, 17)
        Me.cmdConfigurarCK.Name = "cmdConfigurarCK"
        Me.cmdConfigurarCK.Size = New System.Drawing.Size(96, 26)
        Me.cmdConfigurarCK.TabIndex = 143
        Me.cmdConfigurarCK.Text = "Configurar CK"
        Me.cmdConfigurarCK.Visible = False
        '
        'dgCatalogoBancos
        '
        Me.dgCatalogoBancos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCatalogoBancos.Location = New System.Drawing.Point(16, 200)
        Me.dgCatalogoBancos.MainView = Me.Vista
        Me.dgCatalogoBancos.Name = "dgCatalogoBancos"
        Me.dgCatalogoBancos.Size = New System.Drawing.Size(680, 240)
        Me.dgCatalogoBancos.TabIndex = 148
        Me.dgCatalogoBancos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vista})
        '
        'Vista
        '
        Me.Vista.GridControl = Me.dgCatalogoBancos
        Me.Vista.Name = "Vista"
        Me.Vista.OptionsBehavior.Editable = False
        Me.Vista.OptionsView.ShowAutoFilterRow = True
        Me.Vista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vista.OptionsView.ShowFooter = True
        Me.Vista.OptionsView.ShowGroupPanel = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.cmdAyuda)
        Me.GroupBox3.Controls.Add(Me.cmdSalir)
        Me.GroupBox3.Controls.Add(Me.cmdImprimir)
        Me.GroupBox3.Controls.Add(Me.cmdBorrar)
        Me.GroupBox3.Controls.Add(Me.cmdConfigurarCK)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 446)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(680, 51)
        Me.GroupBox3.TabIndex = 142
        Me.GroupBox3.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAyuda.Location = New System.Drawing.Point(512, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 26)
        Me.cmdAyuda.TabIndex = 5
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(592, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(96, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 26)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(16, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 26)
        Me.cmdBorrar.TabIndex = 3
        Me.cmdBorrar.Text = "Borrar"
        '
        'frmCatalogoBancos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(720, 509)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgCatalogoBancos)
        Me.Name = "frmCatalogoBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCatalogoBancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCatalogoBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmdConfigurarCK.Visible = True
        Me.Text = "Cuentas Contables de Bancos"

        'cbCatalogo.DataSource = Catalogo.GetListBuscarComboAuxiliar("%", Cod_CuentaP, EmpresaActual).Tables("CATALOGO")
        Me.cbCatalogo.Properties.DataSource = ObtieneDatos("Select Cuenta, Nombre from Catalogo Where empresa = " & EmpresaActual & " and CajaBanco = 1 and Tipo = 'A'")
        cbCatalogo.Properties.ValueMember = "Cuenta"
        cbCatalogo.Properties.DisplayMember = "Nombre"

        Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
        Me.cbInstitucion.DataSource = v.EjecutarComando("_GetList_InsBanc")
        cbInstitucion.ValueMember = "Codigo"
        cbInstitucion.DisplayMember = "Nombre"
        cbInstitucion.SelectedValue = 0
        v = Nothing

        Me.cbMoneda.Properties.DataSource = VB.SysContab.Tasa_CambioDB.GetListTasaCambioDisponibles.Tables("Tasa_Cambio")
        Me.cbMoneda.Properties.ValueMember = "MonedaCambio"
        Me.cbMoneda.Properties.DisplayMember = "Nombre"
        Me.cbMoneda.Properties.PopulateColumns()
        Me.cbMoneda.Properties.Columns("Empresa").Visible = False
        Me.cbMoneda.Properties.Columns("MonedaBase").Visible = False
        Me.cbMoneda.Properties.Columns("MonedaCambio").Visible = False


        DetalleBanco = VB.SysContab.BancosDB.GetDetails(BancoP)
        Me.Text = "Agregar Cuentas a Bancos"
        Me.cargar()

    End Sub

    Public Sub cargar()
        dgCatalogoBancos.DataSource = VB.SysContab.Catalogo_BancosDB.GetList(BancoP).Tables("CATALOGO_BANCOS").DefaultView
        Me.cargar_detalle()
        Me.Vista.PopulateColumns()
        Me.Vista.Columns("Codigo").Visible = False
        Me.Vista.Columns("Formato").Visible = False
        Me.Vista.Columns("MonCod").Visible = False
    End Sub

    Public Sub cargar_detalle()
        If Me.Vista.DataRowCount = 0 Then
            CatalogoBancosP = "Vacio"
        Else
            CatalogoBancosP = Me.Vista.GetFocusedRowCellValue("Codigo")
            'Me.cbCatalogo.EditValue = Me.Vista.GetFocusedRowCellValue("Cuenta")
            'Me.cbTipoCuenta.SelectedItem = Me.Vista.GetFocusedRowCellValue("Tipo Cuenta")
            'Me.cbMoneda.EditValue = Me.Vista.GetFocusedRowCellValue("MonCod")
            'Me.txtNoCheque.Text = Me.Vista.GetFocusedRowCellValue("No. Cheque")
            'Me.txtCPlanilla.Text = Me.Vista.GetFocusedRowCellValue("Codigo Servicio Planilla")
            'Me.txtcnPlanilla.Text = Me.Vista.GetFocusedRowCellValue("Consecutivo Servicio Planilla")
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click

        If Trim(cbCatalogo.Text) = "" Then
            MsgBox("Seleccione la cuenta", MsgBoxStyle.Information)
            cbCatalogo.Focus()
            cbCatalogo.SelectAll()
            Exit Sub

        End If

        If VB.SysContab.Catalogo_BancosDB.GetListNuevo(BancoP, Cod_Cuenta).Tables("CATALOGO_BANCOS").Rows.Count <> 0 Then
            MsgBox("La cuenta ya fue asignada a este Banco", MsgBoxStyle.Information)
            cbCatalogo.Focus()
            cbCatalogo.SelectAll()
            Exit Sub

        End If

        If Trim(cbTipoCuenta.Text) = "" Then
            MsgBox("Seleccione tipo de cuenta", MsgBoxStyle.Information)
            cbTipoCuenta.Focus()
            cbTipoCuenta.SelectAll()
            Exit Sub

        End If

        If Trim(txtNoCuenta.Text) = "" Then
            MsgBox("Introduzca el No. de Cuenta", MsgBoxStyle.Information)
            txtNoCuenta.Focus()
            txtNoCuenta.SelectAll()
            Exit Sub

        End If

        If Trim(cbMoneda.Text) = "" Then
            MsgBox("Seleccione la Moneda", MsgBoxStyle.Information)
            cbMoneda.Focus()
            cbMoneda.SelectAll()
            Exit Sub

        End If

        If cbInstitucion.SelectedValue = 0 Then
            MsgBox("Seleccione la Institución Bancaria Autorizada por la SIB de la cuenta.", MsgBoxStyle.Information)
            cbInstitucion.Focus()
            cbInstitucion.SelectAll()
            Exit Sub
        End If

        Try
            VB.SysContab.Catalogo_BancosDB.AddItem(Me.cbCatalogo.EditValue, BancoP, cbTipoCuenta.Text, _
                txtNoCuenta.Text, cbInstitucion.SelectedValue, cbMoneda.EditValue, _
                txtNoCheque.Text, Me.txtCPlanilla.Text, Me.txtcnPlanilla.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try


        'cbCatalogo.EditValue = -1
        'cbTipoCuenta.SelectedValue = -1
        'txtNoCuenta.Text = ""
        'cbMoneda.EditValue = -1
        'cbFormato.SelectedValue = -1

        Me.cargar()

    End Sub

    'Private Sub cbCatalogo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim C As New VB.SysContab.CatalogoDB

    '    If Trim(cbCatalogo.Text) = "" Then
    '        cuenta = ""
    '        Exit Sub
    '    End If

    '    If C.GetListBuscarCombo(cbCatalogo.Text, EmpresaActual).Tables("CATALOGO").Rows.Count = 0 Then
    '        MsgBox("Cuenta no Existe", MsgBoxStyle.Information)
    '        cuenta = ""
    '        cbCatalogo.Focus()
    '        Exit Sub

    '    End If

    '    cbCatalogo.SelectedValue = C.GetListBuscarCombo(cbCatalogo.Text, EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA")
    '    Cod_Cuenta = C.GetListBuscarCombo(cbCatalogo.Text, EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA")

    '    cuenta = ""

    'End Sub

    'Private Sub cbCatalogo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cuenta = ""
    'End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.Vista.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Contabilidad")
            CatalogoBancosP = "Vacio"
            Exit Sub
        Else
            CatalogoBancosP = Me.Vista.GetFocusedRowCellValue("Codigo")
        End If
        Dim CatalogoBancos As New VB.SysContab.Catalogo_BancosDB

        If MsgBox("Esta seguro que desea borrar la Cuenta Contable " & Me.Vista.GetFocusedRowCellValue("Cuenta") & " con No. de Cuenta: " & Me.Vista.GetFocusedRowCellValue("NoCuenta"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = DialogResult.No Then
            Exit Sub
        End If

        'se debe agregar una restriccion para no borrar si hay comprobantes con esa cuenta.
        ''
        VB.SysContab.Catalogo_BancosDB.Delete(CatalogoBancosP)
        Me.cargar_detalle()

    End Sub

    Private Sub cmdConfigurarCK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfigurarCK.Click
        If Me.Vista.DataRowCount = 0 Then
            MsgBox("No hay cuentas que configurar", MsgBoxStyle.Critical, "Sts.Contab")
            Exit Sub
        End If

        Dim Forma As New FrmConfiguraCheque
        Forma.Codigos = CInt(Me.Vista.GetFocusedRowCellValue("Codigo"))
        Forma.Show()

    End Sub

    Private Sub Vista_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles Vista.FocusedRowChanged
        Me.cargar_detalle()
    End Sub

End Class
