Imports System.Data.SqlClient
Public Class frmAgregarActivo
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarActivo = Nothing

    Public Shared Function Instance() As frmAgregarActivo
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarActivo
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region "Variables"
    Public nEstado, nSituacion As String
    Public gp As New VB.SysContab.Grupos_DepreciacionDB
    Public gdd As New VB.SysContab.Grupos_DepreciacionDetails
    Dim txttipo As String
    Friend WithEvents dgAsignacion As DevExpress.XtraGrid.GridControl
    Friend WithEvents vAsignacion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbEmpleados As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbCentroCosto As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents dtAsignacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbCentroCosto2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbEmpleado2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdAsignar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPrecio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorDepreciado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRescate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbCaract1 As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents tbCaract2 As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ckInicial As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents cbCuentaInventario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtMesesDepreciados As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cbProveedor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCuentaDepreciacion As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCuentaGastos As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCuentaActivo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtComentarios As DevExpress.XtraEditors.MemoEdit
    Dim terminado As Boolean
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
    Friend WithEvents etCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha_entrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRegistro_Catastral As System.Windows.Forms.TextBox
    Friend WithEvents txtEscritura As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRegistro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTomo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DTPFecha_Escritura As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbPropiedad As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_Compra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtMotor As System.Windows.Forms.TextBox
    Friend WithEvents txtChasis As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoAuto As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtPlaca As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GBArticulo As System.Windows.Forms.GroupBox
    Friend WithEvents gbVehiculo As System.Windows.Forms.GroupBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents CbSituacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents gbCodigo As System.Windows.Forms.GroupBox
    Friend WithEvents gbCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents gbComentarios As System.Windows.Forms.GroupBox
    Friend WithEvents gbDescripcion As System.Windows.Forms.GroupBox
    Friend WithEvents gbEstado As System.Windows.Forms.GroupBox
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents gbValor As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtValor_Revalorizacion As System.Windows.Forms.TextBox
    Friend WithEvents txtValor_Depreciacion As System.Windows.Forms.TextBox
    Friend WithEvents txtPorc_Revalorizacion As System.Windows.Forms.TextBox
    Friend WithEvents txtPorc_Depreciacion As System.Windows.Forms.TextBox
    Friend WithEvents txtVida_Util As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cbGrupoDepreciacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtserie As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtmodel As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents dgDepreciaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDepreciaciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents dgMovimientos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vMovimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cmdVerDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label41 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarActivo))
        Me.gbCodigo = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpFecha_Compra = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.etCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFecha_entrada = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodigoBarra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbCuentas = New System.Windows.Forms.GroupBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.cbCuentaInventario = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cbGrupoDepreciacion = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRegistro_Catastral = New System.Windows.Forms.TextBox()
        Me.gbComentarios = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbDescripcion = New System.Windows.Forms.GroupBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbCaract1 = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.tbCaract2 = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.GBArticulo = New System.Windows.Forms.GroupBox()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gbPropiedad = New System.Windows.Forms.GroupBox()
        Me.txtTomo = New System.Windows.Forms.TextBox()
        Me.DTPFecha_Escritura = New System.Windows.Forms.DateTimePicker()
        Me.txtRegistro = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEscritura = New System.Windows.Forms.TextBox()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbVehiculo = New System.Windows.Forms.GroupBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMotor = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtChasis = New System.Windows.Forms.TextBox()
        Me.txtTipoAuto = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.gbEstado = New System.Windows.Forms.GroupBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.CbSituacion = New System.Windows.Forms.ComboBox()
        Me.gbValor = New System.Windows.Forms.GroupBox()
        Me.txtMesesDepreciados = New DevExpress.XtraEditors.TextEdit()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.ckInicial = New DevExpress.XtraEditors.CheckEdit()
        Me.txtValorDepreciado = New DevExpress.XtraEditors.TextEdit()
        Me.txtRescate = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorActual = New DevExpress.XtraEditors.TextEdit()
        Me.txtPrecio = New DevExpress.XtraEditors.TextEdit()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtVida_Util = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtValor_Depreciacion = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPorc_Depreciacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPorc_Revalorizacion = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtValor_Revalorizacion = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmdVerDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgMovimientos = New DevExpress.XtraGrid.GridControl()
        Me.vMovimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.dgDepreciaciones = New DevExpress.XtraGrid.GridControl()
        Me.vDepreciaciones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cmdAsignar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dtAsignacion = New DevExpress.XtraEditors.DateEdit()
        Me.cbCentroCosto2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbEmpleado2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.dgAsignacion = New DevExpress.XtraGrid.GridControl()
        Me.vAsignacion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbEmpleados = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbCentroCosto = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.cbProveedor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCuentaActivo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCuentaGastos = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCuentaDepreciacion = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.txtComentarios = New DevExpress.XtraEditors.MemoEdit()
        Me.gbCodigo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbCuentas.SuspendLayout()
        CType(Me.cbCuentaInventario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGrupoDepreciacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbComentarios.SuspendLayout()
        Me.gbDescripcion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBArticulo.SuspendLayout()
        Me.gbPropiedad.SuspendLayout()
        Me.gbVehiculo.SuspendLayout()
        Me.gbEstado.SuspendLayout()
        Me.gbValor.SuspendLayout()
        CType(Me.txtMesesDepreciados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorDepreciado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRescate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDepreciaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDepreciaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAsignacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAsignacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentroCosto2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmpleado2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAsignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vAsignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCuentaActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCuentaGastos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCuentaDepreciacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCodigo
        '
        Me.gbCodigo.BackColor = System.Drawing.Color.Transparent
        Me.gbCodigo.Controls.Add(Me.txtDescripcion)
        Me.gbCodigo.Controls.Add(Me.cbProveedor)
        Me.gbCodigo.Controls.Add(Me.Label21)
        Me.gbCodigo.Controls.Add(Me.dtpFecha_Compra)
        Me.gbCodigo.Controls.Add(Me.Label20)
        Me.gbCodigo.Controls.Add(Me.Label19)
        Me.gbCodigo.Controls.Add(Me.txtFactura)
        Me.gbCodigo.Controls.Add(Me.etCodigo)
        Me.gbCodigo.Controls.Add(Me.txtCodigo)
        Me.gbCodigo.Controls.Add(Me.Label2)
        Me.gbCodigo.Location = New System.Drawing.Point(3, 3)
        Me.gbCodigo.Name = "gbCodigo"
        Me.gbCodigo.Size = New System.Drawing.Size(712, 191)
        Me.gbCodigo.TabIndex = 0
        Me.gbCodigo.TabStop = False
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(16, 156)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(113, 26)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Fecha Compra:"
        '
        'dtpFecha_Compra
        '
        Me.dtpFecha_Compra.Enabled = False
        Me.dtpFecha_Compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtpFecha_Compra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_Compra.Location = New System.Drawing.Point(135, 156)
        Me.dtpFecha_Compra.Name = "dtpFecha_Compra"
        Me.dtpFecha_Compra.Size = New System.Drawing.Size(128, 20)
        Me.dtpFecha_Compra.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(16, 104)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(113, 26)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Proveedor:"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(16, 130)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 26)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "No. Factura:"
        '
        'txtFactura
        '
        Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(135, 130)
        Me.txtFactura.MaxLength = 50
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(244, 20)
        Me.txtFactura.TabIndex = 2
        '
        'etCodigo
        '
        Me.etCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etCodigo.Location = New System.Drawing.Point(16, 17)
        Me.etCodigo.Name = "etCodigo"
        Me.etCodigo.Size = New System.Drawing.Size(72, 26)
        Me.etCodigo.TabIndex = 10
        Me.etCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(135, 16)
        Me.txtCodigo.MaxLength = 16
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(128, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(16, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 35)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Fecha Inicio Uso del Bien:"
        '
        'dtpFecha_entrada
        '
        Me.dtpFecha_entrada.Enabled = False
        Me.dtpFecha_entrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dtpFecha_entrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_entrada.Location = New System.Drawing.Point(128, 52)
        Me.dtpFecha_entrada.Name = "dtpFecha_entrada"
        Me.dtpFecha_entrada.Size = New System.Drawing.Size(160, 20)
        Me.dtpFecha_entrada.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 26)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Código de Barra:"
        '
        'txtCodigoBarra
        '
        Me.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarra.Location = New System.Drawing.Point(134, 25)
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.Size = New System.Drawing.Size(208, 20)
        Me.txtCodigoBarra.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(4, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Cuenta de Depreciación:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(38, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Cuenta de Gastos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Grupo de Depreciación:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(366, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Unidad:"
        '
        'txtUnidad
        '
        Me.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.Location = New System.Drawing.Point(438, 25)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(88, 20)
        Me.txtUnidad.TabIndex = 1
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(6, 63)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(94, 40)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(6, 17)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(94, 40)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(768, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 503)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'gbCuentas
        '
        Me.gbCuentas.BackColor = System.Drawing.Color.Transparent
        Me.gbCuentas.Controls.Add(Me.cbCuentaDepreciacion)
        Me.gbCuentas.Controls.Add(Me.Label44)
        Me.gbCuentas.Controls.Add(Me.cbCuentaGastos)
        Me.gbCuentas.Controls.Add(Me.cbCuentaInventario)
        Me.gbCuentas.Controls.Add(Me.cbCuentaActivo)
        Me.gbCuentas.Controls.Add(Me.Label33)
        Me.gbCuentas.Controls.Add(Me.cbGrupoDepreciacion)
        Me.gbCuentas.Controls.Add(Me.Label5)
        Me.gbCuentas.Controls.Add(Me.Label4)
        Me.gbCuentas.Controls.Add(Me.Label6)
        Me.gbCuentas.Location = New System.Drawing.Point(3, 3)
        Me.gbCuentas.Name = "gbCuentas"
        Me.gbCuentas.Size = New System.Drawing.Size(712, 172)
        Me.gbCuentas.TabIndex = 0
        Me.gbCuentas.TabStop = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(13, 136)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(151, 16)
        Me.Label44.TabIndex = 24
        Me.Label44.Text = "Cuenta de Inventario:"
        Me.Label44.Visible = False
        '
        'cbCuentaInventario
        '
        Me.cbCuentaInventario.Location = New System.Drawing.Point(176, 135)
        Me.cbCuentaInventario.Name = "cbCuentaInventario"
        Me.cbCuentaInventario.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentaInventario.Properties.Appearance.Options.UseFont = True
        Me.cbCuentaInventario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCuentaInventario.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUENTA", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", 200, "Nombre de la Cuenta")})
        Me.cbCuentaInventario.Properties.NullText = ""
        Me.cbCuentaInventario.Size = New System.Drawing.Size(456, 20)
        Me.cbCuentaInventario.TabIndex = 23
        Me.cbCuentaInventario.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(38, 60)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(132, 16)
        Me.Label33.TabIndex = 22
        Me.Label33.Text = "Cuenta de Activos:"
        '
        'cbGrupoDepreciacion
        '
        Me.cbGrupoDepreciacion.Location = New System.Drawing.Point(176, 17)
        Me.cbGrupoDepreciacion.Name = "cbGrupoDepreciacion"
        Me.cbGrupoDepreciacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbGrupoDepreciacion.Properties.Appearance.Options.UseFont = True
        Me.cbGrupoDepreciacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbGrupoDepreciacion.Properties.NullText = ""
        Me.cbGrupoDepreciacion.Size = New System.Drawing.Size(456, 20)
        Me.cbGrupoDepreciacion.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(16, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 26)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Reg. Catastral:"
        '
        'txtRegistro_Catastral
        '
        Me.txtRegistro_Catastral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRegistro_Catastral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistro_Catastral.Location = New System.Drawing.Point(134, 16)
        Me.txtRegistro_Catastral.Name = "txtRegistro_Catastral"
        Me.txtRegistro_Catastral.Size = New System.Drawing.Size(208, 20)
        Me.txtRegistro_Catastral.TabIndex = 0
        '
        'gbComentarios
        '
        Me.gbComentarios.BackColor = System.Drawing.Color.Transparent
        Me.gbComentarios.Controls.Add(Me.txtComentarios)
        Me.gbComentarios.Controls.Add(Me.Label12)
        Me.gbComentarios.Location = New System.Drawing.Point(3, 190)
        Me.gbComentarios.Name = "gbComentarios"
        Me.gbComentarios.Size = New System.Drawing.Size(712, 112)
        Me.gbComentarios.TabIndex = 1
        Me.gbComentarios.TabStop = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(16, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 26)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Comentarios:"
        '
        'gbDescripcion
        '
        Me.gbDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.gbDescripcion.Controls.Add(Me.cbTipo)
        Me.gbDescripcion.Controls.Add(Me.GroupBox1)
        Me.gbDescripcion.Controls.Add(Me.GBArticulo)
        Me.gbDescripcion.Controls.Add(Me.Label18)
        Me.gbDescripcion.Controls.Add(Me.gbPropiedad)
        Me.gbDescripcion.Controls.Add(Me.gbVehiculo)
        Me.gbDescripcion.Location = New System.Drawing.Point(3, 1)
        Me.gbDescripcion.Name = "gbDescripcion"
        Me.gbDescripcion.Size = New System.Drawing.Size(712, 468)
        Me.gbDescripcion.TabIndex = 0
        Me.gbDescripcion.TabStop = False
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Items.AddRange(New Object() {"Equipo", "Propiedad", "Vehículo", "Mobiliario", "Software"})
        Me.cbTipo.Location = New System.Drawing.Point(142, 16)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(160, 21)
        Me.cbTipo.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbCaract1)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.tbCaract2)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 391)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OTROS DATOS"
        '
        'tbCaract1
        '
        Me.tbCaract1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCaract1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCaract1.Location = New System.Drawing.Point(144, 26)
        Me.tbCaract1.Name = "tbCaract1"
        Me.tbCaract1.Size = New System.Drawing.Size(208, 20)
        Me.tbCaract1.TabIndex = 0
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(16, 26)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(112, 26)
        Me.Label42.TabIndex = 25
        Me.Label42.Text = "Característica 1"
        '
        'tbCaract2
        '
        Me.tbCaract2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCaract2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCaract2.Location = New System.Drawing.Point(482, 26)
        Me.tbCaract2.Name = "tbCaract2"
        Me.tbCaract2.Size = New System.Drawing.Size(172, 20)
        Me.tbCaract2.TabIndex = 1
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(376, 26)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(100, 26)
        Me.Label43.TabIndex = 12
        Me.Label43.Text = "Característica 2"
        '
        'GBArticulo
        '
        Me.GBArticulo.Controls.Add(Me.txtCodigoBarra)
        Me.GBArticulo.Controls.Add(Me.Label7)
        Me.GBArticulo.Controls.Add(Me.txtUnidad)
        Me.GBArticulo.Controls.Add(Me.Label1)
        Me.GBArticulo.Controls.Add(Me.txtserie)
        Me.GBArticulo.Controls.Add(Me.Label36)
        Me.GBArticulo.Controls.Add(Me.txtmodel)
        Me.GBArticulo.Controls.Add(Me.Label37)
        Me.GBArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBArticulo.Location = New System.Drawing.Point(8, 43)
        Me.GBArticulo.Name = "GBArticulo"
        Me.GBArticulo.Size = New System.Drawing.Size(696, 87)
        Me.GBArticulo.TabIndex = 0
        Me.GBArticulo.TabStop = False
        Me.GBArticulo.Text = "ARTICULO / BIEN"
        '
        'txtserie
        '
        Me.txtserie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserie.Location = New System.Drawing.Point(134, 53)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(208, 20)
        Me.txtserie.TabIndex = 2
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(16, 54)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(112, 26)
        Me.Label36.TabIndex = 25
        Me.Label36.Text = "Serie:"
        '
        'txtmodel
        '
        Me.txtmodel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmodel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodel.Location = New System.Drawing.Point(438, 53)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(168, 20)
        Me.txtmodel.TabIndex = 3
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(366, 53)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(64, 26)
        Me.Label37.TabIndex = 25
        Me.Label37.Text = "Modelo:"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(16, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 26)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Tipo Activo:"
        '
        'gbPropiedad
        '
        Me.gbPropiedad.Controls.Add(Me.Label11)
        Me.gbPropiedad.Controls.Add(Me.txtTomo)
        Me.gbPropiedad.Controls.Add(Me.txtRegistro_Catastral)
        Me.gbPropiedad.Controls.Add(Me.DTPFecha_Escritura)
        Me.gbPropiedad.Controls.Add(Me.txtRegistro)
        Me.gbPropiedad.Controls.Add(Me.Label17)
        Me.gbPropiedad.Controls.Add(Me.txtEscritura)
        Me.gbPropiedad.Controls.Add(Me.txtFolio)
        Me.gbPropiedad.Controls.Add(Me.Label16)
        Me.gbPropiedad.Controls.Add(Me.Label13)
        Me.gbPropiedad.Controls.Add(Me.Label14)
        Me.gbPropiedad.Controls.Add(Me.Label15)
        Me.gbPropiedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPropiedad.Location = New System.Drawing.Point(8, 137)
        Me.gbPropiedad.Name = "gbPropiedad"
        Me.gbPropiedad.Size = New System.Drawing.Size(696, 103)
        Me.gbPropiedad.TabIndex = 1
        Me.gbPropiedad.TabStop = False
        Me.gbPropiedad.Text = "PROPIEDAD"
        '
        'txtTomo
        '
        Me.txtTomo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTomo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTomo.Location = New System.Drawing.Point(438, 42)
        Me.txtTomo.Name = "txtTomo"
        Me.txtTomo.Size = New System.Drawing.Size(208, 20)
        Me.txtTomo.TabIndex = 3
        '
        'DTPFecha_Escritura
        '
        Me.DTPFecha_Escritura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DTPFecha_Escritura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha_Escritura.Location = New System.Drawing.Point(134, 68)
        Me.DTPFecha_Escritura.Name = "DTPFecha_Escritura"
        Me.DTPFecha_Escritura.Size = New System.Drawing.Size(128, 20)
        Me.DTPFecha_Escritura.TabIndex = 4
        '
        'txtRegistro
        '
        Me.txtRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistro.Location = New System.Drawing.Point(438, 16)
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.Size = New System.Drawing.Size(208, 20)
        Me.txtRegistro.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(16, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 26)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Fecha Escritura:"
        '
        'txtEscritura
        '
        Me.txtEscritura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEscritura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEscritura.Location = New System.Drawing.Point(134, 42)
        Me.txtEscritura.Name = "txtEscritura"
        Me.txtEscritura.Size = New System.Drawing.Size(208, 20)
        Me.txtEscritura.TabIndex = 2
        '
        'txtFolio
        '
        Me.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(438, 68)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(208, 20)
        Me.txtFolio.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(366, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 26)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Folio:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(16, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 26)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Escritura:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(366, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 26)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Registro:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(366, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 26)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Tomo:"
        '
        'gbVehiculo
        '
        Me.gbVehiculo.Controls.Add(Me.txtAño)
        Me.gbVehiculo.Controls.Add(Me.Label32)
        Me.gbVehiculo.Controls.Add(Me.txtPlaca)
        Me.gbVehiculo.Controls.Add(Me.Label31)
        Me.gbVehiculo.Controls.Add(Me.txtColor)
        Me.gbVehiculo.Controls.Add(Me.Label26)
        Me.gbVehiculo.Controls.Add(Me.Label25)
        Me.gbVehiculo.Controls.Add(Me.txtModelo)
        Me.gbVehiculo.Controls.Add(Me.txtMotor)
        Me.gbVehiculo.Controls.Add(Me.txtMarca)
        Me.gbVehiculo.Controls.Add(Me.txtChasis)
        Me.gbVehiculo.Controls.Add(Me.txtTipoAuto)
        Me.gbVehiculo.Controls.Add(Me.Label27)
        Me.gbVehiculo.Controls.Add(Me.Label28)
        Me.gbVehiculo.Controls.Add(Me.Label29)
        Me.gbVehiculo.Controls.Add(Me.Label30)
        Me.gbVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVehiculo.Location = New System.Drawing.Point(6, 247)
        Me.gbVehiculo.Name = "gbVehiculo"
        Me.gbVehiculo.Size = New System.Drawing.Size(696, 137)
        Me.gbVehiculo.TabIndex = 2
        Me.gbVehiculo.TabStop = False
        Me.gbVehiculo.Text = "VEHICULO"
        '
        'txtAño
        '
        Me.txtAño.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.Location = New System.Drawing.Point(448, 95)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(208, 20)
        Me.txtAño.TabIndex = 7
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(376, 95)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 26)
        Me.Label32.TabIndex = 47
        Me.Label32.Text = "Año:"
        '
        'txtPlaca
        '
        Me.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.Location = New System.Drawing.Point(448, 69)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(208, 20)
        Me.txtPlaca.TabIndex = 5
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(376, 69)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 26)
        Me.Label31.TabIndex = 45
        Me.Label31.Text = "Placa:"
        '
        'txtColor
        '
        Me.txtColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(448, 43)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(208, 20)
        Me.txtColor.TabIndex = 3
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(376, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 26)
        Me.Label26.TabIndex = 43
        Me.Label26.Text = "Color:"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(16, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(92, 26)
        Me.Label25.TabIndex = 33
        Me.Label25.Text = "Motor:"
        '
        'txtModelo
        '
        Me.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(144, 95)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(208, 20)
        Me.txtModelo.TabIndex = 6
        '
        'txtMotor
        '
        Me.txtMotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotor.Location = New System.Drawing.Point(144, 17)
        Me.txtMotor.Name = "txtMotor"
        Me.txtMotor.Size = New System.Drawing.Size(208, 20)
        Me.txtMotor.TabIndex = 0
        '
        'txtMarca
        '
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(144, 69)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(208, 20)
        Me.txtMarca.TabIndex = 4
        '
        'txtChasis
        '
        Me.txtChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChasis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChasis.Location = New System.Drawing.Point(144, 43)
        Me.txtChasis.Name = "txtChasis"
        Me.txtChasis.Size = New System.Drawing.Size(208, 20)
        Me.txtChasis.TabIndex = 2
        '
        'txtTipoAuto
        '
        Me.txtTipoAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAuto.Location = New System.Drawing.Point(448, 17)
        Me.txtTipoAuto.Name = "txtTipoAuto"
        Me.txtTipoAuto.Size = New System.Drawing.Size(208, 20)
        Me.txtTipoAuto.TabIndex = 1
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(376, 17)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 26)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "Tipo Auto:"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(16, 43)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 26)
        Me.Label28.TabIndex = 35
        Me.Label28.Text = "Chasis"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(16, 69)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 26)
        Me.Label29.TabIndex = 37
        Me.Label29.Text = "Marca:"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(16, 95)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 26)
        Me.Label30.TabIndex = 39
        Me.Label30.Text = "Modelo:"
        '
        'gbEstado
        '
        Me.gbEstado.Controls.Add(Me.Label34)
        Me.gbEstado.Controls.Add(Me.CbSituacion)
        Me.gbEstado.Controls.Add(Me.Label8)
        Me.gbEstado.Controls.Add(Me.dtpFecha_entrada)
        Me.gbEstado.Location = New System.Drawing.Point(3, 307)
        Me.gbEstado.Name = "gbEstado"
        Me.gbEstado.Size = New System.Drawing.Size(712, 103)
        Me.gbEstado.TabIndex = 2
        Me.gbEstado.TabStop = False
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(16, 17)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 26)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "Situación:"
        '
        'CbSituacion
        '
        Me.CbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbSituacion.Items.AddRange(New Object() {"En Uso", "Almacén", "Baja", "Vendido"})
        Me.CbSituacion.Location = New System.Drawing.Point(128, 17)
        Me.CbSituacion.Name = "CbSituacion"
        Me.CbSituacion.Size = New System.Drawing.Size(160, 21)
        Me.CbSituacion.TabIndex = 1
        '
        'gbValor
        '
        Me.gbValor.BackColor = System.Drawing.Color.Transparent
        Me.gbValor.Controls.Add(Me.txtMesesDepreciados)
        Me.gbValor.Controls.Add(Me.Label45)
        Me.gbValor.Controls.Add(Me.ckInicial)
        Me.gbValor.Controls.Add(Me.txtValorDepreciado)
        Me.gbValor.Controls.Add(Me.txtRescate)
        Me.gbValor.Controls.Add(Me.txtValorActual)
        Me.gbValor.Controls.Add(Me.txtPrecio)
        Me.gbValor.Controls.Add(Me.Label41)
        Me.gbValor.Controls.Add(Me.Label38)
        Me.gbValor.Controls.Add(Me.txtVida_Util)
        Me.gbValor.Controls.Add(Me.Label35)
        Me.gbValor.Controls.Add(Me.txtValor_Depreciacion)
        Me.gbValor.Controls.Add(Me.Label24)
        Me.gbValor.Controls.Add(Me.txtPorc_Depreciacion)
        Me.gbValor.Controls.Add(Me.Label10)
        Me.gbValor.Controls.Add(Me.Label3)
        Me.gbValor.Controls.Add(Me.Label9)
        Me.gbValor.Location = New System.Drawing.Point(3, 192)
        Me.gbValor.Name = "gbValor"
        Me.gbValor.Size = New System.Drawing.Size(712, 155)
        Me.gbValor.TabIndex = 1
        Me.gbValor.TabStop = False
        '
        'txtMesesDepreciados
        '
        Me.txtMesesDepreciados.Location = New System.Drawing.Point(544, 102)
        Me.txtMesesDepreciados.Name = "txtMesesDepreciados"
        Me.txtMesesDepreciados.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMesesDepreciados.Properties.Appearance.Options.UseFont = True
        Me.txtMesesDepreciados.Properties.DisplayFormat.FormatString = "n2"
        Me.txtMesesDepreciados.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMesesDepreciados.Properties.EditFormat.FormatString = "n2"
        Me.txtMesesDepreciados.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMesesDepreciados.Properties.Mask.EditMask = "n2"
        Me.txtMesesDepreciados.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMesesDepreciados.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMesesDepreciados.Properties.NullText = "0.00"
        Me.txtMesesDepreciados.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMesesDepreciados.Size = New System.Drawing.Size(126, 20)
        Me.txtMesesDepreciados.TabIndex = 43
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(367, 103)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(179, 26)
        Me.Label45.TabIndex = 42
        Me.Label45.Text = "Meses Depreciados:"
        '
        'ckInicial
        '
        Me.ckInicial.Location = New System.Drawing.Point(16, 128)
        Me.ckInicial.Name = "ckInicial"
        Me.ckInicial.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ckInicial.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ckInicial.Properties.Appearance.Options.UseFont = True
        Me.ckInicial.Properties.Appearance.Options.UseForeColor = True
        Me.ckInicial.Properties.Caption = "Saldo Inicial"
        Me.ckInicial.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ckInicial.Size = New System.Drawing.Size(175, 19)
        Me.ckInicial.TabIndex = 38
        '
        'txtValorDepreciado
        '
        Me.txtValorDepreciado.Location = New System.Drawing.Point(176, 102)
        Me.txtValorDepreciado.Name = "txtValorDepreciado"
        Me.txtValorDepreciado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorDepreciado.Properties.Appearance.Options.UseFont = True
        Me.txtValorDepreciado.Properties.DisplayFormat.FormatString = "n2"
        Me.txtValorDepreciado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorDepreciado.Properties.EditFormat.FormatString = "n2"
        Me.txtValorDepreciado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorDepreciado.Properties.Mask.EditMask = "n2"
        Me.txtValorDepreciado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorDepreciado.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValorDepreciado.Properties.NullText = "0.00"
        Me.txtValorDepreciado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtValorDepreciado.Size = New System.Drawing.Size(100, 20)
        Me.txtValorDepreciado.TabIndex = 41
        '
        'txtRescate
        '
        Me.txtRescate.Location = New System.Drawing.Point(176, 76)
        Me.txtRescate.Name = "txtRescate"
        Me.txtRescate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtRescate.Properties.Appearance.Options.UseFont = True
        Me.txtRescate.Properties.DisplayFormat.FormatString = "n2"
        Me.txtRescate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRescate.Properties.EditFormat.FormatString = "n2"
        Me.txtRescate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRescate.Properties.Mask.EditMask = "n2"
        Me.txtRescate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRescate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtRescate.Properties.NullText = "0.00"
        Me.txtRescate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRescate.Size = New System.Drawing.Size(100, 20)
        Me.txtRescate.TabIndex = 41
        '
        'txtValorActual
        '
        Me.txtValorActual.Location = New System.Drawing.Point(176, 51)
        Me.txtValorActual.Name = "txtValorActual"
        Me.txtValorActual.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtValorActual.Properties.Appearance.Options.UseFont = True
        Me.txtValorActual.Properties.DisplayFormat.FormatString = "n2"
        Me.txtValorActual.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorActual.Properties.EditFormat.FormatString = "n2"
        Me.txtValorActual.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtValorActual.Properties.Mask.EditMask = "n2"
        Me.txtValorActual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorActual.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValorActual.Properties.NullText = "0.00"
        Me.txtValorActual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtValorActual.Size = New System.Drawing.Size(100, 20)
        Me.txtValorActual.TabIndex = 41
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(176, 25)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPrecio.Properties.Appearance.Options.UseFont = True
        Me.txtPrecio.Properties.DisplayFormat.FormatString = "n2"
        Me.txtPrecio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrecio.Properties.EditFormat.FormatString = "n2"
        Me.txtPrecio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrecio.Properties.Mask.EditMask = "n2"
        Me.txtPrecio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecio.Properties.NullText = "0.00"
        Me.txtPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 41
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(16, 103)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(162, 26)
        Me.Label41.TabIndex = 40
        Me.Label41.Text = "Valor Depreciado:"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(16, 78)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(140, 25)
        Me.Label38.TabIndex = 39
        Me.Label38.Text = "Valor de Rescate:"
        '
        'txtVida_Util
        '
        Me.txtVida_Util.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVida_Util.Enabled = False
        Me.txtVida_Util.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVida_Util.Location = New System.Drawing.Point(544, 52)
        Me.txtVida_Util.Name = "txtVida_Util"
        Me.txtVida_Util.Size = New System.Drawing.Size(126, 20)
        Me.txtVida_Util.TabIndex = 3
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(367, 52)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(133, 26)
        Me.Label35.TabIndex = 37
        Me.Label35.Text = "Vida Útil:"
        '
        'txtValor_Depreciacion
        '
        Me.txtValor_Depreciacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor_Depreciacion.Enabled = False
        Me.txtValor_Depreciacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor_Depreciacion.Location = New System.Drawing.Point(544, 78)
        Me.txtValor_Depreciacion.Name = "txtValor_Depreciacion"
        Me.txtValor_Depreciacion.Size = New System.Drawing.Size(126, 20)
        Me.txtValor_Depreciacion.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(367, 78)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(178, 25)
        Me.Label24.TabIndex = 35
        Me.Label24.Text = "Valor de Depreciación"
        '
        'txtPorc_Depreciacion
        '
        Me.txtPorc_Depreciacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorc_Depreciacion.Enabled = False
        Me.txtPorc_Depreciacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorc_Depreciacion.Location = New System.Drawing.Point(544, 26)
        Me.txtPorc_Depreciacion.Name = "txtPorc_Depreciacion"
        Me.txtPorc_Depreciacion.Size = New System.Drawing.Size(126, 20)
        Me.txtPorc_Depreciacion.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(364, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 26)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "% Depreciación:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 26)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Valor de Adquisición:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(16, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 26)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Valor en Libros:"
        '
        'txtPorc_Revalorizacion
        '
        Me.txtPorc_Revalorizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorc_Revalorizacion.Enabled = False
        Me.txtPorc_Revalorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorc_Revalorizacion.Location = New System.Drawing.Point(147, 397)
        Me.txtPorc_Revalorizacion.Name = "txtPorc_Revalorizacion"
        Me.txtPorc_Revalorizacion.Size = New System.Drawing.Size(88, 20)
        Me.txtPorc_Revalorizacion.TabIndex = 5
        Me.txtPorc_Revalorizacion.Visible = False
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(3, 397)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 26)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "% Revalorización:"
        Me.Label22.Visible = False
        '
        'txtValor_Revalorizacion
        '
        Me.txtValor_Revalorizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValor_Revalorizacion.Enabled = False
        Me.txtValor_Revalorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor_Revalorizacion.Location = New System.Drawing.Point(147, 423)
        Me.txtValor_Revalorizacion.Name = "txtValor_Revalorizacion"
        Me.txtValor_Revalorizacion.Size = New System.Drawing.Size(88, 20)
        Me.txtValor_Revalorizacion.TabIndex = 6
        Me.txtValor_Revalorizacion.Visible = False
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(3, 423)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(144, 26)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "Valor Revalorización:"
        Me.Label23.Visible = False
        '
        'cmdVerDetalle
        '
        Me.cmdVerDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdVerDetalle.Location = New System.Drawing.Point(83, 465)
        Me.cmdVerDetalle.Name = "cmdVerDetalle"
        Me.cmdVerDetalle.Size = New System.Drawing.Size(75, 25)
        Me.cmdVerDetalle.TabIndex = 21
        Me.cmdVerDetalle.Text = "&Ver Detalle"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAgregar.Location = New System.Drawing.Point(3, 465)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 25)
        Me.cmdAgregar.TabIndex = 20
        Me.cmdAgregar.Text = "A&gregar"
        '
        'dgMovimientos
        '
        Me.dgMovimientos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMovimientos.Location = New System.Drawing.Point(3, 214)
        Me.dgMovimientos.MainView = Me.vMovimientos
        Me.dgMovimientos.Name = "dgMovimientos"
        Me.dgMovimientos.Size = New System.Drawing.Size(749, 245)
        Me.dgMovimientos.TabIndex = 19
        Me.dgMovimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vMovimientos})
        '
        'vMovimientos
        '
        Me.vMovimientos.GridControl = Me.dgMovimientos
        Me.vMovimientos.Name = "vMovimientos"
        Me.vMovimientos.OptionsBehavior.Editable = False
        Me.vMovimientos.OptionsSelection.MultiSelect = True
        Me.vMovimientos.OptionsView.ShowAutoFilterRow = True
        Me.vMovimientos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vMovimientos.OptionsView.ShowFooter = True
        Me.vMovimientos.OptionsView.ShowGroupPanel = False
        '
        'Label40
        '
        Me.Label40.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(3, 188)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(377, 26)
        Me.Label40.TabIndex = 18
        Me.Label40.Text = "Movimientos que afectaron el Valor del Activo:"
        '
        'dgDepreciaciones
        '
        Me.dgDepreciaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDepreciaciones.Location = New System.Drawing.Point(3, 25)
        Me.dgDepreciaciones.MainView = Me.vDepreciaciones
        Me.dgDepreciaciones.Name = "dgDepreciaciones"
        Me.dgDepreciaciones.Size = New System.Drawing.Size(749, 155)
        Me.dgDepreciaciones.TabIndex = 0
        Me.dgDepreciaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDepreciaciones})
        '
        'vDepreciaciones
        '
        Me.vDepreciaciones.GridControl = Me.dgDepreciaciones
        Me.vDepreciaciones.Name = "vDepreciaciones"
        Me.vDepreciaciones.OptionsBehavior.Editable = False
        Me.vDepreciaciones.OptionsSelection.MultiSelect = True
        Me.vDepreciaciones.OptionsView.ShowAutoFilterRow = True
        Me.vDepreciaciones.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vDepreciaciones.OptionsView.ShowFooter = True
        Me.vDepreciaciones.OptionsView.ShowGroupPanel = False
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(3, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(168, 25)
        Me.Label39.TabIndex = 17
        Me.Label39.Text = "Depreciaciones:"
        '
        'cmdAsignar
        '
        Me.cmdAsignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAsignar.Enabled = False
        Me.cmdAsignar.Location = New System.Drawing.Point(309, 444)
        Me.cmdAsignar.Name = "cmdAsignar"
        Me.cmdAsignar.Size = New System.Drawing.Size(75, 25)
        Me.cmdAsignar.TabIndex = 7
        Me.cmdAsignar.Text = "Asignar"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Location = New System.Drawing.Point(3, 449)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Fecha de Asignacion:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(3, 397)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Centro de Costo:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(3, 421)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Empleado:"
        '
        'dtAsignacion
        '
        Me.dtAsignacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtAsignacion.EditValue = Nothing
        Me.dtAsignacion.Enabled = False
        Me.dtAsignacion.Location = New System.Drawing.Point(111, 446)
        Me.dtAsignacion.Name = "dtAsignacion"
        Me.dtAsignacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtAsignacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtAsignacion.Size = New System.Drawing.Size(152, 20)
        Me.dtAsignacion.TabIndex = 3
        '
        'cbCentroCosto2
        '
        Me.cbCentroCosto2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbCentroCosto2.Enabled = False
        Me.cbCentroCosto2.Location = New System.Drawing.Point(111, 390)
        Me.cbCentroCosto2.Name = "cbCentroCosto2"
        Me.cbCentroCosto2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentroCosto2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 40, "Nombre")})
        Me.cbCentroCosto2.Properties.NullText = "[Seleccione el Centro de Costo]"
        Me.cbCentroCosto2.Size = New System.Drawing.Size(273, 20)
        Me.cbCentroCosto2.TabIndex = 2
        '
        'cbEmpleado2
        '
        Me.cbEmpleado2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbEmpleado2.Enabled = False
        Me.cbEmpleado2.Location = New System.Drawing.Point(111, 418)
        Me.cbEmpleado2.Name = "cbEmpleado2"
        Me.cbEmpleado2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpleado2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 200, "Nombre")})
        Me.cbEmpleado2.Properties.NullText = "[Seleccione el Empleado]"
        Me.cbEmpleado2.Size = New System.Drawing.Size(273, 20)
        Me.cbEmpleado2.TabIndex = 1
        '
        'dgAsignacion
        '
        Me.dgAsignacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAsignacion.Location = New System.Drawing.Point(3, 3)
        Me.dgAsignacion.MainView = Me.vAsignacion
        Me.dgAsignacion.Name = "dgAsignacion"
        Me.dgAsignacion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbEmpleados, Me.cbCentroCosto})
        Me.dgAsignacion.Size = New System.Drawing.Size(749, 380)
        Me.dgAsignacion.TabIndex = 0
        Me.dgAsignacion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vAsignacion})
        '
        'vAsignacion
        '
        Me.vAsignacion.GridControl = Me.dgAsignacion
        Me.vAsignacion.Name = "vAsignacion"
        Me.vAsignacion.OptionsBehavior.Editable = False
        Me.vAsignacion.OptionsView.ShowAutoFilterRow = True
        Me.vAsignacion.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vAsignacion.OptionsView.ShowGroupPanel = False
        '
        'cbEmpleados
        '
        Me.cbEmpleados.AutoHeight = False
        Me.cbEmpleados.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpleados.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 200, "Nombre")})
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.NullText = "[Seleccione el Empleado]"
        '
        'cbCentroCosto
        '
        Me.cbCentroCosto.AutoHeight = False
        Me.cbCentroCosto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCentroCosto.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 200, "Descripcion")})
        Me.cbCentroCosto.Name = "cbCentroCosto"
        Me.cbCentroCosto.NullText = "[Seleccione el Centro de Costo]"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(5, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(761, 521)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.gbEstado)
        Me.XtraTabPage1.Controls.Add(Me.gbCodigo)
        Me.XtraTabPage1.Controls.Add(Me.gbComentarios)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(755, 493)
        Me.XtraTabPage1.Text = "Activo"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.gbDescripcion)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(755, 493)
        Me.XtraTabPage2.Text = "Descripción"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.gbValor)
        Me.XtraTabPage3.Controls.Add(Me.gbCuentas)
        Me.XtraTabPage3.Controls.Add(Me.Label23)
        Me.XtraTabPage3.Controls.Add(Me.txtPorc_Revalorizacion)
        Me.XtraTabPage3.Controls.Add(Me.txtValor_Revalorizacion)
        Me.XtraTabPage3.Controls.Add(Me.Label22)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(755, 493)
        Me.XtraTabPage3.Text = "Cuentas/Valores"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.cmdVerDetalle)
        Me.XtraTabPage4.Controls.Add(Me.Label39)
        Me.XtraTabPage4.Controls.Add(Me.cmdAgregar)
        Me.XtraTabPage4.Controls.Add(Me.dgDepreciaciones)
        Me.XtraTabPage4.Controls.Add(Me.dgMovimientos)
        Me.XtraTabPage4.Controls.Add(Me.Label40)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(755, 493)
        Me.XtraTabPage4.Text = "Histórico de Movimientos"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.cmdAsignar)
        Me.XtraTabPage5.Controls.Add(Me.dgAsignacion)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage5.Controls.Add(Me.cbEmpleado2)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage5.Controls.Add(Me.cbCentroCosto2)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage5.Controls.Add(Me.dtAsignacion)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(755, 493)
        Me.XtraTabPage5.Text = "Asignación"
        '
        'cbProveedor
        '
        Me.cbProveedor.Location = New System.Drawing.Point(135, 104)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.Properties.Appearance.Options.UseFont = True
        Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedor.Properties.View = Me.SearchLookUpEdit1View
        Me.cbProveedor.Size = New System.Drawing.Size(544, 20)
        Me.cbProveedor.TabIndex = 34
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'cbCuentaActivo
        '
        Me.cbCuentaActivo.Location = New System.Drawing.Point(176, 56)
        Me.cbCuentaActivo.Name = "cbCuentaActivo"
        Me.cbCuentaActivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentaActivo.Properties.Appearance.Options.UseFont = True
        Me.cbCuentaActivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCuentaActivo.Properties.View = Me.GridView1
        Me.cbCuentaActivo.Size = New System.Drawing.Size(456, 20)
        Me.cbCuentaActivo.TabIndex = 35
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cbCuentaGastos
        '
        Me.cbCuentaGastos.Location = New System.Drawing.Point(176, 82)
        Me.cbCuentaGastos.Name = "cbCuentaGastos"
        Me.cbCuentaGastos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentaGastos.Properties.Appearance.Options.UseFont = True
        Me.cbCuentaGastos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCuentaGastos.Properties.View = Me.GridView2
        Me.cbCuentaGastos.Size = New System.Drawing.Size(456, 20)
        Me.cbCuentaGastos.TabIndex = 38
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'cbCuentaDepreciacion
        '
        Me.cbCuentaDepreciacion.Location = New System.Drawing.Point(176, 109)
        Me.cbCuentaDepreciacion.Name = "cbCuentaDepreciacion"
        Me.cbCuentaDepreciacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentaDepreciacion.Properties.Appearance.Options.UseFont = True
        Me.cbCuentaDepreciacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCuentaDepreciacion.Properties.View = Me.GridView3
        Me.cbCuentaDepreciacion.Size = New System.Drawing.Size(456, 20)
        Me.cbCuentaDepreciacion.TabIndex = 36
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(135, 42)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Size = New System.Drawing.Size(544, 56)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(135, 10)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(544, 86)
        Me.txtComentarios.TabIndex = 4
        '
        'frmAgregarActivo
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(880, 526)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmAgregarActivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbCodigo.ResumeLayout(False)
        Me.gbCodigo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbCuentas.ResumeLayout(False)
        Me.gbCuentas.PerformLayout()
        CType(Me.cbCuentaInventario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGrupoDepreciacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbComentarios.ResumeLayout(False)
        Me.gbDescripcion.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBArticulo.ResumeLayout(False)
        Me.GBArticulo.PerformLayout()
        Me.gbPropiedad.ResumeLayout(False)
        Me.gbPropiedad.PerformLayout()
        Me.gbVehiculo.ResumeLayout(False)
        Me.gbVehiculo.PerformLayout()
        Me.gbEstado.ResumeLayout(False)
        Me.gbValor.ResumeLayout(False)
        Me.gbValor.PerformLayout()
        CType(Me.txtMesesDepreciados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorDepreciado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRescate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDepreciaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDepreciaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAsignacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAsignacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentroCosto2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmpleado2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAsignacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vAsignacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage5.PerformLayout()
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCuentaActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCuentaGastos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCuentaDepreciacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgregarActivo_Fijo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Activo_Fijo As New VB.SysContab.Activo_FijosDB
        Dim g As New VB.SysContab.Grupos_InventarioDB
        Dim Catalogo As New VB.SysContab.CatalogoDB
        Dim p As New VB.SysContab.ProveedoresDB
        Dim DtCentros, dTEmpleados As New DataTable
        Dim Areas As New VB.SysContab.AreaDB

        DtCentros = VB.SysContab.RubrosGastosDB.CentrosCosto_Listar()
        dTEmpleados = VB.SysContab.EmpleadosDB.GetListDepto("%").Tables(0)

        terminado = False


        Me.cbEmpleados.DataSource = dTEmpleados
        Me.cbEmpleados.DisplayMember = "Nombre"
        Me.cbEmpleados.ValueMember = "Codigo"

        Me.cbCentroCosto.DataSource = DtCentros 'VB.SysContab.RubrosGastosDB.CentrosCosto_Listar()
        Me.cbCentroCosto.DisplayMember = "Nombre"
        Me.cbCentroCosto.ValueMember = "Codigo"

        Me.cbEmpleado2.Properties.DataSource = dTEmpleados
        Me.cbEmpleado2.Properties.DisplayMember = "Nombre"
        Me.cbEmpleado2.Properties.ValueMember = "Codigo"

        Me.cbCentroCosto2.Properties.DataSource = DtCentros 'VB.SysContab.RubrosGastosDB.CentrosCosto_Listar()
        Me.cbCentroCosto2.Properties.DisplayMember = "Nombre"
        Me.cbCentroCosto2.Properties.ValueMember = "Codigo"

        'dt = VB.SysContab.CatalogoDB.GetListBuscarComboAuxiliar("%", "%", EmpresaActual).Tables("CATALOGO")
        Dim dt As DataTable = ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual)

        SearchLookUp(cbCuentaGastos, dt, "Display", "Cuenta", 2)
        SearchLookUp(cbCuentaDepreciacion, dt, "Display", "Cuenta", 2)
        SearchLookUp(cbCuentaActivo, dt, "Display", "Cuenta", 2)

        'LookUp(cbCuentaGastos, dt, "Display", "Cuenta", 2)
        'LookUp(cbCuentaDepreciacion, dt, "Display", "Cuenta", 2)
        'LookUp(cbCuentaActivo, dt, "Display", "Cuenta", 2)

        LookUp(cbCuentaInventario, dt, "Display", "Cuenta", 2)

        SearchLookUp(
            cbProveedor,
            VB.SysContab.ProveedoresDB.ProveedoresList(1).Tables("Proveedores"),
            "Nombre",
            "Codigo")

        'cbCuentaGastos.Properties.DataSource = dt
        'cbCuentaGastos.Properties.ValueMember = "CUENTA"
        'cbCuentaGastos.Properties.DisplayMember = "NOMBRE"

        'cbCuentaDepreciacion.Properties.DataSource = dt 'Catalogo.GetListBuscarComboAuxiliar("%", "%", EmpresaActual).Tables("CATALOGO")
        'cbCuentaDepreciacion.Properties.ValueMember = "CUENTA"
        'cbCuentaDepreciacion.Properties.DisplayMember = "NOMBRE"

        'cbCuentaActivo.Properties.DataSource = dt 'Catalogo.GetListBuscarComboAuxiliar("%", "%", EmpresaActual).Tables("CATALOGO")
        'cbCuentaActivo.Properties.ValueMember = "CUENTA"
        'cbCuentaActivo.Properties.DisplayMember = "NOMBRE"

        'cbCuentaInventario.Properties.DataSource = dt 'Catalogo.GetListBuscarComboAuxiliar("%", "%", EmpresaActual).Tables("CATALOGO")
        'cbCuentaInventario.Properties.ValueMember = "CUENTA"
        'cbCuentaInventario.Properties.DisplayMember = "NOMBRE"

        cbGrupoDepreciacion.Properties.DataSource = VB.SysContab.Grupos_DepreciacionDB.GetListBuscarCombo("%").Tables("Grupos_Depreciacion")
        cbGrupoDepreciacion.Properties.ValueMember = "CODIGO"
        cbGrupoDepreciacion.Properties.DisplayMember = "NOMBRE"
        cbGrupoDepreciacion.Properties.ForceInitialize()
        cbGrupoDepreciacion.Properties.PopulateColumns()

        'For i As Integer = 2 To cbGrupoDepreciacion.Properties.Columns.Count - 1
        '    cbCuentaDepreciacion.Properties.Columns(i).Visible = False
        'Next

        'Me.cbProveedor.DataSource = p.ProveedoresListCombo().Tables("Proveedores")
        'Me.cbProveedor.ValueMember = "CODIGO"
        'Me.cbProveedor.DisplayMember = "NOMBRE"

        Me.dtpFecha_entrada.Value = Today

        If Nuevo = "NO" Then

            Me.Text = "Agregar Activo Fijo"
            CargarHistorico()
            Me.dgAsignacion.DataSource = VB.SysContab.RubrosGastosDB.Asignacion_Listar(Registro, "%")
            Me.vAsignacion.Columns("consecutivo").Caption = "Consecutivo"
            Me.vAsignacion.Columns("empresa").Visible = False
            Me.vAsignacion.Columns("af_codigo").Visible = False
            Me.vAsignacion.Columns("empleado").Caption = "Empleado"
            Me.vAsignacion.Columns("empleado").ColumnEdit = Me.cbEmpleados
            Me.vAsignacion.Columns("centrocosto").Caption = "Centro de Costo"
            Me.vAsignacion.Columns("centrocosto").ColumnEdit = Me.cbCentroCosto
            Me.vAsignacion.Columns("fechaefectiva").Caption = "Fecha Asignacion"
            Me.vAsignacion.Columns("activo").Caption = "¿Activo?"
            Me.vAsignacion.Columns("fechahasta").Caption = "Fecha de Retiro"
            Me.vAsignacion.BestFitColumns()

            Dim Detalles As VB.SysContab.Activo_FijosDetails = VB.SysContab.Activo_FijosDB.GetDetails(Registro)

            If Detalles.Asignado = True Then
                If Detalles.FechaAsignacion = Nothing Then
                    Me.dtAsignacion.Properties.MinValue = dtpFecha_Compra.Value

                Else
                    Me.dtAsignacion.Properties.MinValue = Detalles.FechaAsignacion
                End If
            Else
                Me.dtAsignacion.Properties.MinValue = Today.Date
            End If


            'Me.Text = "Editando Activo: " & Detalles.Codigo & "-" & Detalles.Descripcion

            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtDescripcion.Text = Detalles.Descripcion
            Me.txtMesesDepreciados.EditValue = Detalles.MesesDepreciado
            Me.txtPrecio.Text = Detalles.Precio
            Me.txtValorActual.Text = Detalles.Valor_Libros
            Me.txtRescate.Text = Detalles.Valor_Rescate
            Me.txtValorDepreciado.Text = Detalles.Valor_Depreciado
            Me.Label35.Text = "Vida Util en " & IIf(VB.SysContab.Grupos_DepreciacionDB.GetDetails(Detalles.Grupo_Depreciacion).Periodo = "A", "Años", "Meses")

            Me.dtpFecha_entrada.Value = IIf(IsDBNull(Detalles.Fecha_Entrada), Today, Detalles.Fecha_Entrada)
            Me.dtpFecha_Compra.Value = Detalles.Fecha_Factura

            If Detalles.Valor_Depreciado = 0 Then dtpFecha_entrada.Enabled = True
            'Me.dtpFecha_Compra.Enabled = False

            Me.cbCuentaActivo.EditValue = Detalles.Cuenta_Activo
            Me.cbCuentaInventario.EditValue = Detalles.Cuenta_Inventario
            Me.cbCuentaDepreciacion.EditValue = Detalles.Cuenta_Depreciacion
            Me.cbCuentaGastos.EditValue = Detalles.Cuenta_Gastos
            Me.cbGrupoDepreciacion.EditValue = Detalles.Grupo_Depreciacion
            Me.cbTipo.SelectedItem = IIf(Detalles.Tipo = "A", "Equipo", IIf(Detalles.Tipo = "P", "Propiedad", IIf(Detalles.Tipo = "M", "Mobiliario", IIf(Detalles.Tipo = "S", "Software", "Vehículo"))))
            'se elimino cbestado, pq no cumplia una funcion logica 29122008
            'Me.cbEstado.SelectedItem = IIf(Detalles.Estado = "P", "Perfecto", IIf(Detalles.Estado = "R", "Regular", "Mal"))
            Me.CbSituacion.SelectedItem = IIf(Detalles.Situacion = "U", "En Uso", IIf(Detalles.Situacion = "D", "Desuso", "Almacén"))
            Me.txtComentarios.Text = Detalles.Comentarios
            Me.cbProveedor.EditValue = CInt(Detalles.Proveedor)
            Me.txtFactura.Text = Detalles.Factura


            If Me.cbTipo.SelectedItem = "Propiedad" Then
                Me.txtRegistro_Catastral.Text = Detalles.PropiedadDetail.Registro_Catastral
                Me.txtEscritura.Text = Detalles.PropiedadDetail.Escritura
                Me.txtRegistro.Text = Detalles.PropiedadDetail.Registro
                Me.txtFolio.Text = Detalles.PropiedadDetail.Folio
                Me.txtTomo.Text = Detalles.PropiedadDetail.Tomo
                Me.DTPFecha_Escritura.Value = Detalles.PropiedadDetail.Fecha_Escritura
            ElseIf Me.cbTipo.SelectedItem = "Vehículo" Then
                Me.txtAño.Text = Detalles.VehiculoDetail.Año
                Me.txtChasis.Text = Detalles.VehiculoDetail.Chasis
                Me.txtColor.Text = Detalles.VehiculoDetail.Color
                Me.txtMarca.Text = Detalles.VehiculoDetail.Marca
                Me.txtModelo.Text = Detalles.VehiculoDetail.Modelo
                Me.txtMotor.Text = Detalles.VehiculoDetail.Motor
                Me.txtPlaca.Text = Detalles.VehiculoDetail.Placa
                Me.txtTipoAuto.Text = Detalles.VehiculoDetail.TipoAuto
            Else 'If Me.cbTipo.SelectedItem = "Equipo" Or Me.cbTipo.SelectedItem = "Mobiliario" Or Me.cbTipo.SelectedItem = "Software" Then
                Me.txtCodigoBarra.Text = Detalles.ArticuloDetail.Codigo_Barra
                Me.txtUnidad.Text = Detalles.ArticuloDetail.Unidad
                txtserie.Text = Detalles.ArticuloDetail.Serie
                txtmodel.Text = Detalles.ArticuloDetail.Modelo
            End If
            tbCaract1.Text = Detalles.Caract1 : tbCaract2.Text = Detalles.Caract2
            'Me.GBArticulo.Enabled = True
            'Me.gbCodigo.Enabled = True
            'Me.gbComentarios.Enabled = True
            'Me.gbCuentas.Enabled = True
            'Me.gbDescripcion.Enabled = False
            'Me.gbEstado.Enabled = True
            'Me.gbPropiedad.Enabled = True
            'Me.gbValor.Enabled = True
            'Me.gbVehiculo.Enabled = True
            'txtserie.Enabled = True
            'txtmodel.Enabled = True

            'Me.GBArticulo.Enabled = False
            'Me.gbCodigo.Enabled = False
            'Me.gbComentarios.Enabled = True
            'Me.gbCuentas.Enabled = False
            'Me.gbDescripcion.Enabled = False
            'Me.gbEstado.Enabled = True
            'Me.gbPropiedad.Enabled = False
            'Me.gbValor.Enabled = False
            'Me.gbVehiculo.Enabled = False
            'txtserie.Enabled = False
            'txtmodel.Enabled = False
            Me.txtValorActual.Properties.ReadOnly = True
            Me.cbEmpleado2.Enabled = True
            Me.cbCentroCosto2.Enabled = True
            Me.dtAsignacion.Enabled = True
            Me.cmdAsignar.Enabled = True

        Else
            'Me.Text = "Agregando Nuevo Activo Fijo"
            'Me.txtPrecio.Text = "0.00"
            'Me.txtValorActual.Text = "0.00"
            'Me.txtRescate.Text = "0.00"
            'Me.txtValorDepreciado.Text = "0.00"
            Me.txtValorActual.Enabled = True
            Me.dtpFecha_Compra.Enabled = True
            dtpFecha_entrada.Enabled = True
            Me.txtMesesDepreciados.EditValue = 0
            'txtCodigo.Text = ObtieneDatos("SELECT isnull(max(cast(codigo_activo AS INT)),0)+1 FROM ACTIVO_FIJOS af WHERE Empresa=" & EmpresaActual).Rows(0).Item(0)
            txtCodigo.Text = VB.SysContab.Activo_FijosDB.GetCodigo()
        End If

        terminado = True
        Me.Refresh()

    End Sub

    Private Sub CargarHistorico()
        Me.dgDepreciaciones.DataSource = VB.SysContab.Activo_FijosDB.GetDepreciacion(Registro)

        Me.vDepreciaciones.Columns("Mes Depreciación").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.vDepreciaciones.Columns("Mes Depreciación").SummaryItem.DisplayFormat = "{0:n0}"

        Me.vDepreciaciones.Columns("Valor").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDepreciaciones.Columns("Valor").SummaryItem.DisplayFormat = "{0:n2}"

        Me.dgMovimientos.DataSource = VB.SysContab.Activo_FijosDB.GetMovimientos(Registro, "%")

        Me.vMovimientos.Columns("Consecutivo").Width = 50
        Me.vMovimientos.Columns("Tipo Movimiento").Width = 150
        Me.vMovimientos.Columns("Fecha").Width = 50
        Me.vMovimientos.Columns("Valor").Width = 50
        Me.vMovimientos.Columns("Contabilizado").Width = 50

        Me.vMovimientos.Columns("Consecutivo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.vMovimientos.Columns("Consecutivo").SummaryItem.DisplayFormat = "{0:n0}"

        Me.vMovimientos.Columns("Valor").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vMovimientos.Columns("Valor").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vMovimientos.Columns("Codigo Activo").Visible = False
        'Me.vMovimientos.Columns("Activo").Visible = False
        'Me.vMovimientos.Columns("Tipo").Visible = False

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub frmAgregarActivo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim a As frmActivos = frmActivos.Instance
        a.Cargar()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'Dim Activo As New VB.SysContab.Activo_FijosDB
        Dim r As New VB.SysContab.Rutinas
        nEstado = ""
        'Validar
        If Validar() Then

            'If MsgBox("Está seguro de los datos a guardar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "STS-Activos") = MsgBoxResult.No Then
            '    Exit Sub
            'End If

            If Not XtraMsg2("Está seguro de los datos a guardar?") Then
                Exit Sub
            End If


            Dim gd As VB.SysContab.Grupos_DepreciacionDetails, dfecha As Date, dfecha2 As Date
            gd = VB.SysContab.Grupos_DepreciacionDB.GetDetails(Me.cbGrupoDepreciacion.EditValue)
            If Me.ckInicial.EditValue = True Then
                dfecha = DateAdd(DateInterval.Month,
                                 (Me.txtPrecio.EditValue - txtValorActual.EditValue) / (Me.txtPrecio.EditValue / (IIf(gd.Periodo = "A", 12, 1) * gd.Vida_Util)),
                                 dtpFecha_entrada.Value.Date)
                dfecha = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, DateAdd(DateInterval.Day, (-1 * dfecha.Day) + 1, dfecha)))
                dfecha2 = New Date(VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MESCALCULODEPRECIACION.Substring(0, 4),
                                     VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MESCALCULODEPRECIACION.Substring(4, 2), 1)
                dfecha2 = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 2, dfecha2))

                If dfecha > dfecha2 Then
                    XtraMsg("La fecha de entrada no corresponde a los meses depreciados. Se sugiere " &
                    DateAdd(DateInterval.Month, -2 * (Me.txtPrecio.EditValue - txtValorActual.EditValue) / (Me.txtPrecio.EditValue / (IIf(gd.Periodo = "A", 12, 1) * gd.Vida_Util)), dfecha).ToString &
                            " como fecha posible de compra/ingreso", MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Try

                If Nuevo = "SI" Then
                    Dim ActCode As String = VB.SysContab.Activo_FijosDB.GetCodigo()

                    'ActCode = ObtieneDatos("SELECT isnull(MAX(CAST(Codigo_Activo AS INT)),0)+1 FROM ACTIVO_FIJOS af WHERE af.EMPRESA = " & EmpresaActual).Rows(0).Item(0)

                    If IsNumeric(ActCode) Then
                        If Me.cbTipo.SelectedItem = "Equipo" Or Me.cbTipo.SelectedItem = "Mobiliario" Or Me.cbTipo.SelectedItem = "Software" Then
                            VB.SysContab.Activo_FijosDB.AddItem_Articulo(IIf(txtCodigo.Text = "", ActCode, txtCodigo.Text),
                                txtDescripcion.Text,
                                txtPrecio.Text,
                                Me.txtValorActual.Text,
                                cbGrupoDepreciacion.EditValue,
                                Me.cbCuentaActivo.EditValue,
                                Me.cbCuentaInventario.EditValue,
                                cbCuentaGastos.EditValue,
                                cbCuentaDepreciacion.EditValue,
                                Me.dtpFecha_entrada.Value.Date,
                                txtCodigoBarra.Text,
                                txtUnidad.Text,
                                nEstado,
                                nSituacion,
                                txttipo,
                                Me.txtFactura.Text,
                                Me.cbProveedor.EditValue,
                                Me.txtComentarios.Text,
                                txtserie.Text, txtmodel.Text, dtpFecha_Compra.Value, Me.txtRescate.Text, ckInicial.Checked)
                        ElseIf Me.cbTipo.SelectedItem = "Propiedad" Then
                            VB.SysContab.Activo_FijosDB.AddItem_Propiedad(ActCode, txtDescripcion.Text, txtPrecio.Text,
                                Me.txtValorActual.Text, cbGrupoDepreciacion.EditValue,
                                Me.cbCuentaActivo.EditValue, Me.cbCuentaInventario.EditValue, cbCuentaGastos.EditValue,
                                cbCuentaDepreciacion.EditValue, Me.dtpFecha_entrada.Value.Date, Me.txtRegistro_Catastral.Text,
                                Me.txtEscritura.Text, Me.DTPFecha_Escritura.Value.Date, Me.txtRegistro.Text, Me.txtTomo.Text,
                                Me.txtFolio.Text, nEstado, nSituacion, txttipo, Me.txtComentarios.Text, dtpFecha_Compra.Value,
                                Me.txtRescate.Text, ckInicial.Checked)
                        Else
                            VB.SysContab.Activo_FijosDB.AddItem_Vehiculo(ActCode, txtDescripcion.Text, txtPrecio.Text,
                                Me.txtValorActual.Text, cbGrupoDepreciacion.EditValue,
                                Me.cbCuentaActivo.EditValue, Me.cbCuentaInventario.EditValue, cbCuentaGastos.EditValue,
                                cbCuentaDepreciacion.EditValue, Me.dtpFecha_entrada.Value.Date, nEstado, nSituacion,
                                txttipo, Me.txtMotor.Text, Me.txtChasis.Text, Me.txtMarca.Text, Me.txtModelo.Text,
                                Me.txtTipoAuto.Text, Me.txtColor.Text, Me.txtPlaca.Text, Me.txtAño.Text, Me.txtFactura.Text,
                                Me.cbProveedor.EditValue, Me.txtComentarios.Text, dtpFecha_Compra.Value, Me.txtRescate.Text,
                                ckInicial.Checked)
                        End If

                    End If

                Else
                    'Dim Detalles As VB.SysContab.Activo_FijosDetails = Activo.GetDetails(Registro)
                    If Me.cbTipo.SelectedItem = "Equipo" Or Me.cbTipo.SelectedItem = "Mobiliario" Or Me.cbTipo.SelectedItem = "Software" Then
                        VB.SysContab.Activo_FijosDB.UpdateItem_Articulo(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text,
                            cbGrupoDepreciacion.EditValue, Me.cbCuentaActivo.EditValue, Me.cbCuentaInventario.EditValue,
                            Me.cbCuentaGastos.EditValue, cbCuentaDepreciacion.EditValue, Me.dtpFecha_entrada.Value.Date,
                            txtCodigoBarra.Text, txtUnidad.Text,
                            nEstado, nSituacion, txttipo, Me.txtFactura.Text, Me.cbProveedor.EditValue, Me.txtComentarios.Text,
                            txtserie.Text, txtmodel.Text, txttipo, dtpFecha_Compra.Value, Me.txtRescate.Text)
                    ElseIf Me.cbTipo.SelectedItem = "Propiedad" Then
                        VB.SysContab.Activo_FijosDB.UpdateItem_Propiedad(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text,
                            cbGrupoDepreciacion.EditValue, Me.cbCuentaActivo.EditValue, cbCuentaInventario.EditValue,
                            cbCuentaGastos.EditValue, cbCuentaDepreciacion.EditValue, Me.dtpFecha_entrada.Value.Date,
                            Me.txtRegistro_Catastral.Text, Me.txtEscritura.Text, Me.DTPFecha_Escritura.Value.Date,
                            Me.txtRegistro.Text, Me.txtTomo.Text, Me.txtFolio.Text, nEstado, nSituacion, txttipo,
                            Me.txtComentarios.Text, cbProveedor.EditValue, txttipo, dtpFecha_Compra.Value, Me.txtRescate.Text)
                    Else
                        VB.SysContab.Activo_FijosDB.UpdateItem_Vehiculo(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text,
                            cbGrupoDepreciacion.EditValue, Me.cbCuentaActivo.EditValue, cbCuentaInventario.EditValue,
                            cbCuentaGastos.EditValue, cbCuentaDepreciacion.EditValue, Me.dtpFecha_entrada.Value.Date,
                            nEstado, nSituacion, txttipo, Me.txtMotor.Text, Me.txtChasis.Text, Me.txtMarca.Text, Me.txtModelo.Text,
                            Me.txtTipoAuto.Text, Me.txtColor.Text, Me.txtPlaca.Text, Me.txtAño.Text, Me.txtFactura.Text,
                            cbProveedor.EditValue, Me.txtComentarios.Text, txttipo, dtpFecha_Compra.Value, Me.txtRescate.Text)
                    End If
                End If

                'If tbCaract1.Text.Trim <> "" Or tbCaract2.Text.Trim <> "" Then
                '    ObtieneDatos("_AFCaractAUD " & IIf(Nuevo = "SI", ActCode, txtCodigo.Text) & "," & EmpresaActual & ",'" & tbCaract1.Text.Trim & "','" & tbCaract2.Text.Trim & "'," & IIf(Nuevo = "SI", 1, 2))
                'End If

                VB.SysContab.Rutinas.okTransaccion()
                Me.Close()
            Catch ex As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                XtraMsg(ex.Message,
                        MessageBoxIcon.Error)

            End Try

        End If
    End Sub

    Private Function Validar() As Boolean
        Dim Mensaje As String = ""

        If Me.txtCodigo.Text = "" Then
            Mensaje = Mensaje & "Código del Activo" & vbCrLf
            'MsgBox("Digite el codigo del activo", MsgBoxStyle.Critical, "STS-Activos")

        End If

        If Me.txtDescripcion.Text = "" Then
            Mensaje = Mensaje & "Descripción del Activo" & vbCrLf
            'MsgBox("Digite la descripción del activo", MsgBoxStyle.Critical, "STS-Activos")

        End If

        'If Me.cbProveedor.SelectedValue = 0 Or Me.cbProveedor.SelectedValue Is Nothing Then
        '    Mensaje = Mensaje & "Proveedor" & vbCrLf
        '    'MsgBox("Seleccione el proveedor", MsgBoxStyle.Critical, "STS-Activos")

        'End If
        'If nEstado Is Nothing Or nEstado = "" Then
        '    Mensaje = Mensaje & "Estado" & vbCrLf
        'End If

        If cbProveedor.EditValue Is Nothing Then
            Mensaje = Mensaje & "Proveedor" & vbCrLf
        End If

        If nSituacion Is Nothing Or nSituacion = "" Then
            Mensaje = Mensaje & "Situación" & vbCrLf
            'MsgBox("Seleccione la situación", MsgBoxStyle.Critical, "STS-Activos")

        End If

        If Me.cbTipo.SelectedIndex = 0 Then
            txttipo = "A"
        ElseIf Me.cbTipo.SelectedIndex = 1 Then
            txttipo = "P"
        ElseIf Me.cbTipo.SelectedIndex = 2 Then
            txttipo = "V"
        ElseIf Me.cbTipo.SelectedIndex = 3 Then
            txttipo = "M"
        ElseIf Me.cbTipo.SelectedIndex = 4 Then
            txttipo = "S"
        Else
            Mensaje = Mensaje & "Tipo de Activo" & vbCrLf
        End If

        If Me.cbGrupoDepreciacion.EditValue Is Nothing Then
            Mensaje = Mensaje & "Grupo de Depreciación" & vbCrLf
            'MsgBox("Seleccione el grupo de depreciación", MsgBoxStyle.Critical, "STS-Activos")

        End If
        If Me.cbCuentaActivo.EditValue Is Nothing Then
            Mensaje = Mensaje & "Cuenta Activo" & vbCrLf
            'MsgBox("Seleccione la cuenta de gastos del activo", MsgBoxStyle.Critical, "STS-Activos")
            '
        End If
        'If Me.cbCuentaInventario.EditValue Is Nothing Then
        '    Mensaje = Mensaje & "Cuenta Inventario" & vbCrLf
        '    'MsgBox("Seleccione la cuenta de gastos del activo", MsgBoxStyle.Critical, "STS-Activos")
        '    '
        'End If
        If Me.cbCuentaGastos.EditValue Is Nothing Then
            Mensaje = Mensaje & "Cuenta de Gastos" & vbCrLf
            'MsgBox("Seleccione la cuenta de gastos del activo", MsgBoxStyle.Critical, "STS-Activos")
            '
        End If
        If Me.cbCuentaDepreciacion.EditValue Is Nothing Then
            Mensaje = Mensaje & "Cuenta de Depreciación" & vbCrLf
            'MsgBox("Seleccione la cuenta de gastos del activo", MsgBoxStyle.Critical, "STS-Activos")
            '
        End If

        If CDbl(Me.txtPrecio.Text) < 0 Then
            Mensaje = Mensaje & "Precio menor que 0" & vbCrLf
            'MsgBox("El Precio no puede ser menor que 0", MsgBoxStyle.Critical, "STS-Activos")
        End If
        If Len(Mensaje) > 0 Then
            Mensaje = "Existen errores en los campos: " & vbCrLf & Mensaje
            XtraMsg(Mensaje,
                    MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipo.SelectedIndexChanged
        If Me.cbTipo.SelectedItem = "Equipo" Or Me.cbTipo.SelectedItem = "Mobiliario" Or Me.cbTipo.SelectedItem = "Software" Then
            Me.GBArticulo.Enabled = True
            Me.gbPropiedad.Enabled = False
            Me.gbVehiculo.Enabled = False
            txtserie.Enabled = True
            txtmodel.Enabled = True
        ElseIf Me.cbTipo.SelectedItem = "Propiedad" Then
            Me.GBArticulo.Enabled = False
            Me.gbPropiedad.Enabled = True
            Me.gbVehiculo.Enabled = False
        Else
            Me.GBArticulo.Enabled = False
            Me.gbPropiedad.Enabled = False
            Me.gbVehiculo.Enabled = True

        End If
    End Sub

    'Private Sub cbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.cbEstado.SelectedItem = "Perfecto" Then
    '        nEstado = "P"
    '    ElseIf Me.cbEstado.SelectedItem = "Regular" Then
    '        nEstado = "R"
    '    Else
    '        nEstado = "M"
    '    End If
    'End Sub

    Private Sub CbSituacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbSituacion.SelectedIndexChanged
        'En Uso
        'Almacén
        'Baja
        'Vendido
        If Me.CbSituacion.SelectedItem = "En Uso" Then
            nSituacion = "U"
        ElseIf Me.CbSituacion.SelectedItem = "Vendido" Then
            nSituacion = "D"
        ElseIf Me.CbSituacion.SelectedItem = "Baja" Then
            nSituacion = "B"
        Else
            nSituacion = "A"
        End If
    End Sub

    Private Sub txtPrecio_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecio.EditValueChanged
        If txtValorDepreciado.EditValue = 0 Then txtValorActual.EditValue = txtPrecio.EditValue
    End Sub

    Private Sub txtPrecio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPrecio.Validating
        If terminado Then
            If Me.txtPrecio.Text = "" Then
                Me.txtPrecio.Text = "0.00"
            End If
            If CDbl(Me.txtPrecio.Text) < 0 Then
                MsgBox("El precio de compra del activo no puede ser menor que cero.", MsgBoxStyle.Exclamation, "STS-Activos")
                Exit Sub
            End If
            If Nuevo = "NO" Then
                If CDbl(Me.txtPrecio.Text) < CDbl(Me.txtValorActual.Text) Then
                    Me.txtPrecio.Text = Me.txtValorActual.Text
                    MsgBox("El precio de Compra no puede ser menor que el valor en libros.", MsgBoxStyle.Exclamation, "STS-Activos")
                    Exit Sub
                End If

            Else
                Me.txtValorActual.Text = Me.txtPrecio.Text
                If IsNumeric(Me.cbGrupoDepreciacion.EditValue) Then
                    Me.txtVida_Util.Text = gdd.Vida_Util
                    Me.txtPorc_Depreciacion.Text = gdd.Porcentaje
                    Me.txtPorc_Revalorizacion.Text = gdd.Porcentaje_Revaloracion
                    Me.txtValor_Depreciacion.Text = CDbl(((Me.txtValorActual.Text) - Me.txtRescate.Text) / (IIf(gdd.Vida_Util = 0, 1, (gdd.Vida_Util * IIf(gdd.Periodo = "A", 12, 1))) - Me.txtMesesDepreciados.EditValue)).ToString(Round)
                    Me.txtValor_Revalorizacion.Text = CDbl((Me.txtValorActual.Text - Me.txtRescate.Text) * (gdd.Porcentaje_Revaloracion / 100)).ToString(Round)  '/ (gdd.Vida_Util * 12)
                End If
            End If
        End If
    End Sub

    Private Sub cbGrupoDepreciacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGrupoDepreciacion.EditValueChanged
        If IsNumeric(Me.cbGrupoDepreciacion.EditValue) Then
            gdd = VB.SysContab.Grupos_DepreciacionDB.GetDetails(Me.cbGrupoDepreciacion.EditValue)
            Me.Label35.Text = "Vida Util en " & IIf(gdd.Periodo = "A", "Años", "Meses")
            If Me.txtPrecio.Text > 0 Then
                Me.txtVida_Util.Text = gdd.Vida_Util
                Me.txtPorc_Depreciacion.Text = gdd.Porcentaje
                Me.txtPorc_Revalorizacion.Text = gdd.Porcentaje_Revaloracion
                Me.txtValor_Depreciacion.Text = CDbl(((Me.txtValorActual.EditValue) - Me.txtRescate.EditValue) / (IIf(gdd.Vida_Util = 0, 1, (gdd.Vida_Util * IIf(gdd.Periodo = "A", 12, 1))) - Me.txtMesesDepreciados.EditValue)).ToString(Round)
                Me.txtValor_Revalorizacion.Text = CDbl((Me.txtValorActual.EditValue - Me.txtRescate.EditValue) * (gdd.Porcentaje_Revaloracion / 100)).ToString(Round)  '/ (gdd.Vida_Util * 12)
            End If
        End If
    End Sub

    Private Sub txtValorActual_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtValorActual.Validating

        If Me.txtValorActual.Text = "" Then
            Me.txtValorActual.Text = "0.00"
        End If

        If CDbl(Me.txtValorActual.Text) < 0 Then
            MsgBox("El valor en libros no puede ser menor que cero", MsgBoxStyle.Exclamation, "STS-Activos")
            Exit Sub
        End If
        If Nuevo <> "NO" Then
            If CDbl(Me.txtValorActual.Text) > CDbl(Me.txtPrecio.Text) Then
                Me.txtValorActual.Text = Me.txtPrecio.Text
                MsgBox("El valor en libros no puede ser mayor que el precio de compra", MsgBoxStyle.Exclamation, "STS-Activos")
                Exit Sub
            End If

            If IsNumeric(Me.cbGrupoDepreciacion.EditValue) Then
                Me.txtVida_Util.Text = gdd.Vida_Util
                Me.txtPorc_Depreciacion.Text = gdd.Porcentaje
                Me.txtPorc_Revalorizacion.Text = gdd.Porcentaje_Revaloracion
                Me.txtValor_Depreciacion.Text = CDbl(((Me.txtValorActual.Text) - Me.txtRescate.Text) / (IIf(gdd.Vida_Util = 0, 1, (gdd.Vida_Util * IIf(gdd.Periodo = "A", 12, 1))) - Me.txtMesesDepreciados.EditValue)).ToString(Round)
                Me.txtValor_Revalorizacion.Text = CDbl((Me.txtValorActual.Text - Me.txtRescate.Text) * (gdd.Porcentaje_Revaloracion / 100)).ToString(Round)  '/ (gdd.Vida_Util * 12)
            End If

        End If

    End Sub

    Private Sub txtRescate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtRescate.Validating
        If terminado Then

            If Me.txtRescate.Text = "" Then
                Me.txtRescate.Text = "1"
                Exit Sub
            End If

            If CDbl(Me.txtRescate.Text) < 0 Then
                MsgBox("El valor de rescate no puede ser menor que cero", MsgBoxStyle.Exclamation, "STS-Activos")
                Exit Sub
            End If

            If CDbl(Me.txtRescate.Text) > CDbl(Me.txtValorActual.Text) Then
                MsgBox("El valor de rescate no puede ser mayor que el valor en libros", MsgBoxStyle.Exclamation, "STS-Activos")
                Me.txtRescate.Text = Me.txtValorActual.Text
                Exit Sub
            End If

            If IsNumeric(Me.cbGrupoDepreciacion.EditValue) Then
                Me.txtVida_Util.Text = gdd.Vida_Util
                Me.txtPorc_Depreciacion.Text = gdd.Porcentaje
                Me.txtPorc_Revalorizacion.Text = gdd.Porcentaje_Revaloracion
                Me.txtValor_Depreciacion.Text = CDbl(((Me.txtValorActual.Text) - Me.txtRescate.Text) / (IIf(gdd.Vida_Util = 0, 1, (gdd.Vida_Util * IIf(gdd.Periodo = "A", 12, 1))) - Me.txtMesesDepreciados.EditValue)).ToString(Round)
                Me.txtValor_Revalorizacion.Text = CDbl((Me.txtValorActual.Text - Me.txtRescate.Text) * (gdd.Porcentaje_Revaloracion / 100)).ToString(Round)  '/ (gdd.Vida_Util * 12)
            End If
        End If
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim f As New frmAgregarMovimientos
        frmAgregarMovimientos.Modo = "A"
        frmAgregarMovimientos.Valor = Me.txtValorDepreciado.Text
        f.ShowDialog()
        CargarHistorico()
        f.Dispose()
    End Sub

    Private Sub cmdVerDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerDetalle.Click
        Dim f As New frmAgregarMovimientos
        frmAgregarMovimientos.Consecutivo = Me.vMovimientos.GetFocusedRowCellValue("Consecutivo")
        frmAgregarMovimientos.Modo = "V"
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub dtpFecha_Compra_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha_Compra.ValueChanged
        Me.dtpFecha_entrada.MinDate = Me.dtpFecha_Compra.Value
        'Me.dtpFecha_entrada.Enabled = True
    End Sub

    Private Sub cmdAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAsignar.Click
        Dim empleado, ccosto As String
        empleado = ""
        ccosto = ""

        If Me.cbEmpleado2.EditValue = Nothing Then
            empleado = ""
        ElseIf Me.cbEmpleado2.EditValue = "%" Then
            empleado = ""
        Else
            empleado = Me.cbEmpleado2.EditValue
        End If

        If Me.cbCentroCosto2.EditValue Is Nothing Then
            ccosto = ""
        ElseIf Me.cbCentroCosto2.EditValue = "0" Then
            ccosto = ""
        Else
            ccosto = Me.cbCentroCosto2.EditValue.ToString
        End If

        If empleado = "" And ccosto = "" Then
            XtraMsg("Debe seleccionar un empleado o un centro de costo para asignar el activo", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Me.dtAsignacion.EditValue Is Nothing Then
            XtraMsg("Digite una fecha de asignacion")
            Exit Sub
        End If

        VB.SysContab.RubrosGastosDB.Asignacion_Add(Me.txtCodigo.Text, _
            empleado, IsNull(ccosto, 0), Me.dtAsignacion.EditValue)

        Me.dgAsignacion.DataSource = VB.SysContab.RubrosGastosDB.Asignacion_Listar(Me.txtCodigo.Text, "%")
        Me.vAsignacion.Columns("consecutivo").Caption = "Consecutivo"
        Me.vAsignacion.Columns("empresa").Visible = False
        Me.vAsignacion.Columns("af_codigo").Visible = False
        Me.vAsignacion.Columns("empleado").Caption = "Empleado"
        Me.vAsignacion.Columns("empleado").ColumnEdit = Me.cbEmpleados
        Me.vAsignacion.Columns("centrocosto").Caption = "Centro de Costo"
        Me.vAsignacion.Columns("centrocosto").ColumnEdit = Me.cbCentroCosto
        Me.vAsignacion.Columns("fechaefectiva").Caption = "Fecha Asignacion"
        Me.vAsignacion.Columns("activo").Caption = "¿Activo?"
        Me.vAsignacion.Columns("fechahasta").Caption = "Fecha de Retiro"
        Me.vAsignacion.BestFitColumns()

    End Sub

    Private Sub txtValorActual_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValorActual.EditValueChanged
        txtValorDepreciado.EditValue = txtPrecio.EditValue - txtValorActual.EditValue
    End Sub

   
    
End Class

