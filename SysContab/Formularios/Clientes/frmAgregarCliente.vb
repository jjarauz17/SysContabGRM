Imports Entities

Public Class frmAgregarCliente
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarCliente = Nothing

    Public Shared Function Instance() As frmAgregarCliente
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarCliente()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Friend WithEvents chkEmpl As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGarantia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cbCategoria As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbmoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtLimiteCredito As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkLimite As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl4 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents chkRetenedorAlcaldia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkExcento As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkRetenedor As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup10 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup11 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup12 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbDepartamentos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem57 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMunicipios As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtFax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkAgro As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tNombreComercial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbZona As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbVendedor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbCatalogo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCiudad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCorreo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtCelularContacto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefonoContacto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtEmailContacto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCargoContacto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtContacto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCedulaContacto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtGerente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNombreGerente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtEmailGerente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCelularGerente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefonoGerente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txCedulaContador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txCedulaGerente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCelularContador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefonoContador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmailContador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtContador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem53 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem50 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem58 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txCelularRepresentante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefonoRepresentante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCorreoRepresentante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCedulaRepresentante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreRepresentante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem55 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem59 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem60 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem61 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents cbPais As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCodigoLetra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem62 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem63 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtRuc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cedula As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbTipoCliente As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents cbClasificacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtCelular As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup9 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bAcuerdosPagos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem64 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents sMascara As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem65 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem66 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem67 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem69 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem68 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem70 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem71 As DevExpress.XtraLayout.LayoutControlItem
    Dim Cod_Cuenta As String

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
    'Friend WithEvents txtGerente As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAcumulado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents cmdEstadoCuenta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDevoluciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNotasDebitos As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarCliente))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Me.cmdNotasDebitos = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.bAcuerdosPagos = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.etInicio = New System.Windows.Forms.Label()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEstadoCuenta = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDevoluciones = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAcumulado = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem64 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.sMascara = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCelular = New DevExpress.XtraEditors.TextEdit()
        Me.cbClasificacion = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbTipoCliente = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtRuc = New DevExpress.XtraEditors.TextEdit()
        Me.Cedula = New DevExpress.XtraEditors.TextEdit()
        Me.cbPais = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCodigoLetra = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.txCelularRepresentante = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefonoRepresentante = New DevExpress.XtraEditors.TextEdit()
        Me.txtCorreoRepresentante = New DevExpress.XtraEditors.TextEdit()
        Me.txtCedulaRepresentante = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreRepresentante = New DevExpress.XtraEditors.TextEdit()
        Me.txCedulaContador = New DevExpress.XtraEditors.TextEdit()
        Me.txCedulaGerente = New DevExpress.XtraEditors.TextEdit()
        Me.txtCelularContador = New DevExpress.XtraEditors.TextEdit()
        Me.txtCelularGerente = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefonoContador = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmailContador = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmailGerente = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefonoGerente = New DevExpress.XtraEditors.TextEdit()
        Me.txtContador = New DevExpress.XtraEditors.TextEdit()
        Me.txtCedulaContacto = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmailContacto = New DevExpress.XtraEditors.TextEdit()
        Me.txtCargoContacto = New DevExpress.XtraEditors.TextEdit()
        Me.txtContacto = New DevExpress.XtraEditors.TextEdit()
        Me.txtCelularContacto = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefonoContacto = New DevExpress.XtraEditors.TextEdit()
        Me.txtFax = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.txtCiudad = New DevExpress.XtraEditors.TextEdit()
        Me.txtCorreo = New DevExpress.XtraEditors.TextEdit()
        Me.cbFormaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbVendedor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbCatalogo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbZona = New DevExpress.XtraEditors.LookUpEdit()
        Me.tNombreComercial = New DevExpress.XtraEditors.TextEdit()
        Me.chkAgro = New DevExpress.XtraEditors.CheckEdit()
        Me.chkActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.cbMunicipios = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbDepartamentos = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtDireccion = New DevExpress.XtraEditors.MemoEdit()
        Me.chkLimite = New DevExpress.XtraEditors.CheckEdit()
        Me.cmbmoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtLimiteCredito = New DevExpress.XtraEditors.TextEdit()
        Me.chkRetenedorAlcaldia = New DevExpress.XtraEditors.CheckEdit()
        Me.chkExcento = New DevExpress.XtraEditors.CheckEdit()
        Me.cbCategoria = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkRetenedor = New DevExpress.XtraEditors.CheckEdit()
        Me.chkGarantia = New DevExpress.XtraEditors.CheckEdit()
        Me.chkEmpl = New DevExpress.XtraEditors.CheckEdit()
        Me.txtNombreGerente = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem62 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem63 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem57 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem65 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup10 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem66 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup12 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem50 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem58 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem67 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem55 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem59 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem60 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem61 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup11 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem53 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem69 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem68 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem70 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem71 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.txtCelular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbClasificacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipoCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cedula.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoLetra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txCelularRepresentante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonoRepresentante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorreoRepresentante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCedulaRepresentante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreRepresentante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txCedulaContador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txCedulaGerente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCelularContador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCelularGerente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonoContador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmailContador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmailGerente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonoGerente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCedulaContacto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmailContacto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargoContacto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContacto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCelularContacto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonoContacto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCiudad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorreo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbVendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbZona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNombreComercial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAgro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMunicipios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDepartamentos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLimite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLimiteCredito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRetenedorAlcaldia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExcento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRetenedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGarantia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEmpl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreGerente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdNotasDebitos
        '
        Me.cmdNotasDebitos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNotasDebitos.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNotasDebitos.Appearance.Options.UseFont = True
        Me.cmdNotasDebitos.Appearance.Options.UseForeColor = True
        Me.cmdNotasDebitos.Appearance.Options.UseTextOptions = True
        Me.cmdNotasDebitos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdNotasDebitos.ImageOptions.Image = CType(resources.GetObject("cmdNotasDebitos.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNotasDebitos.Location = New System.Drawing.Point(12, 222)
        Me.cmdNotasDebitos.Name = "cmdNotasDebitos"
        Me.cmdNotasDebitos.Size = New System.Drawing.Size(118, 38)
        Me.cmdNotasDebitos.StyleController = Me.LayoutControl3
        Me.cmdNotasDebitos.TabIndex = 4
        Me.cmdNotasDebitos.Text = "&Notas de Débitos"
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.bAcuerdosPagos)
        Me.LayoutControl3.Controls.Add(Me.SimpleButton4)
        Me.LayoutControl3.Controls.Add(Me.etInicio)
        Me.LayoutControl3.Controls.Add(Me.cmdNotasDebitos)
        Me.LayoutControl3.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl3.Controls.Add(Me.cmdEstadoCuenta)
        Me.LayoutControl3.Controls.Add(Me.cmdDevoluciones)
        Me.LayoutControl3.Controls.Add(Me.cmdAcumulado)
        Me.LayoutControl3.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13, Me.LayoutControlItem11, Me.LayoutControlItem10})
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1059, 175, 250, 350)
        Me.LayoutControl3.Root = Me.LayoutControlGroup3
        Me.LayoutControl3.Size = New System.Drawing.Size(141, 558)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'bAcuerdosPagos
        '
        Me.bAcuerdosPagos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAcuerdosPagos.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bAcuerdosPagos.Appearance.Options.UseFont = True
        Me.bAcuerdosPagos.Appearance.Options.UseForeColor = True
        Me.bAcuerdosPagos.Appearance.Options.UseTextOptions = True
        Me.bAcuerdosPagos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bAcuerdosPagos.Enabled = False
        Me.bAcuerdosPagos.ImageOptions.Image = CType(resources.GetObject("bAcuerdosPagos.ImageOptions.Image"), System.Drawing.Image)
        Me.bAcuerdosPagos.Location = New System.Drawing.Point(12, 138)
        Me.bAcuerdosPagos.Name = "bAcuerdosPagos"
        Me.bAcuerdosPagos.Size = New System.Drawing.Size(118, 38)
        Me.bAcuerdosPagos.StyleController = Me.LayoutControl3
        Me.bAcuerdosPagos.TabIndex = 5
        Me.bAcuerdosPagos.Text = "Acuerdos de P&agos"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Appearance.Options.UseForeColor = True
        Me.SimpleButton4.Appearance.Options.UseTextOptions = True
        Me.SimpleButton4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton4.ImageOptions.Image = CType(resources.GetObject("SimpleButton4.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(12, 96)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(118, 38)
        Me.SimpleButton4.StyleController = Me.LayoutControl3
        Me.SimpleButton4.TabIndex = 5
        Me.SimpleButton4.Text = "&Documentos Digitales"
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(12, 319)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(118, 210)
        Me.etInicio.TabIndex = 159
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseTextOptions = True
        Me.cmdCancelar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(12, 491)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(118, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl3
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "&Salir"
        '
        'cmdEstadoCuenta
        '
        Me.cmdEstadoCuenta.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEstadoCuenta.Appearance.Options.UseForeColor = True
        Me.cmdEstadoCuenta.Appearance.Options.UseTextOptions = True
        Me.cmdEstadoCuenta.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdEstadoCuenta.Enabled = False
        Me.cmdEstadoCuenta.ImageOptions.Image = CType(resources.GetObject("cmdEstadoCuenta.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdEstadoCuenta.Location = New System.Drawing.Point(12, 54)
        Me.cmdEstadoCuenta.Name = "cmdEstadoCuenta"
        Me.cmdEstadoCuenta.Size = New System.Drawing.Size(118, 38)
        Me.cmdEstadoCuenta.StyleController = Me.LayoutControl3
        Me.cmdEstadoCuenta.TabIndex = 1
        Me.cmdEstadoCuenta.Text = "Estado de &Cuenta"
        '
        'cmdDevoluciones
        '
        Me.cmdDevoluciones.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDevoluciones.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDevoluciones.Appearance.Options.UseFont = True
        Me.cmdDevoluciones.Appearance.Options.UseForeColor = True
        Me.cmdDevoluciones.Appearance.Options.UseTextOptions = True
        Me.cmdDevoluciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdDevoluciones.ImageOptions.Image = CType(resources.GetObject("cmdDevoluciones.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdDevoluciones.Location = New System.Drawing.Point(12, 180)
        Me.cmdDevoluciones.Name = "cmdDevoluciones"
        Me.cmdDevoluciones.Size = New System.Drawing.Size(118, 38)
        Me.cmdDevoluciones.StyleController = Me.LayoutControl3
        Me.cmdDevoluciones.TabIndex = 3
        Me.cmdDevoluciones.Text = "&Devoluciones"
        '
        'cmdAcumulado
        '
        Me.cmdAcumulado.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcumulado.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAcumulado.Appearance.Options.UseFont = True
        Me.cmdAcumulado.Appearance.Options.UseForeColor = True
        Me.cmdAcumulado.Appearance.Options.UseTextOptions = True
        Me.cmdAcumulado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAcumulado.ImageOptions.Image = CType(resources.GetObject("cmdAcumulado.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAcumulado.Location = New System.Drawing.Point(12, 449)
        Me.cmdAcumulado.Name = "cmdAcumulado"
        Me.cmdAcumulado.Size = New System.Drawing.Size(118, 38)
        Me.cmdAcumulado.StyleController = Me.LayoutControl3
        Me.cmdAcumulado.TabIndex = 2
        Me.cmdAcumulado.Text = "&Acumulado"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.Appearance.Options.UseTextOptions = True
        Me.cmdAceptar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(118, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl3
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "&Guardar"
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.etInicio
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 307)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(122, 214)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        Me.LayoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdNotasDebitos
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cmdDevoluciones
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Root"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem12, Me.LayoutControlItem30, Me.EmptySpaceItem4, Me.LayoutControlItem64})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "Root"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(142, 541)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdAceptar
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdEstadoCuenta
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmdAcumulado
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 437)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdCancelar
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 479)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.SimpleButton4
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem30.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem30.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem30.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem30.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 168)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(122, 269)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem64
        '
        Me.LayoutControlItem64.Control = Me.bAcuerdosPagos
        Me.LayoutControlItem64.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem64.MaxSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem64.MinSize = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem64.Name = "LayoutControlItem64"
        Me.LayoutControlItem64.Size = New System.Drawing.Size(122, 42)
        Me.LayoutControlItem64.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem64.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem64.TextVisible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.EditValue = ""
        Me.txtObservaciones.Location = New System.Drawing.Point(528, 291)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtObservaciones.Properties.Appearance.Options.UseFont = True
        Me.txtObservaciones.Properties.Appearance.Options.UseForeColor = True
        Me.txtObservaciones.Size = New System.Drawing.Size(336, 124)
        Me.txtObservaciones.StyleController = Me.LayoutControl4
        Me.txtObservaciones.TabIndex = 4
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.SimpleButton7)
        Me.LayoutControl4.Controls.Add(Me.SimpleButton5)
        Me.LayoutControl4.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl4.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl4.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl4.Controls.Add(Me.sMascara)
        Me.LayoutControl4.Controls.Add(Me.txtCelular)
        Me.LayoutControl4.Controls.Add(Me.cbClasificacion)
        Me.LayoutControl4.Controls.Add(Me.cbTipoCliente)
        Me.LayoutControl4.Controls.Add(Me.txtRuc)
        Me.LayoutControl4.Controls.Add(Me.Cedula)
        Me.LayoutControl4.Controls.Add(Me.cbPais)
        Me.LayoutControl4.Controls.Add(Me.txtCodigoLetra)
        Me.LayoutControl4.Controls.Add(Me.txtCodigo)
        Me.LayoutControl4.Controls.Add(Me.txtFax)
        Me.LayoutControl4.Controls.Add(Me.txCelularRepresentante)
        Me.LayoutControl4.Controls.Add(Me.txtTelefonoRepresentante)
        Me.LayoutControl4.Controls.Add(Me.txtCorreoRepresentante)
        Me.LayoutControl4.Controls.Add(Me.txtCedulaRepresentante)
        Me.LayoutControl4.Controls.Add(Me.txtNombreRepresentante)
        Me.LayoutControl4.Controls.Add(Me.txCedulaContador)
        Me.LayoutControl4.Controls.Add(Me.txCedulaGerente)
        Me.LayoutControl4.Controls.Add(Me.txtCelularContador)
        Me.LayoutControl4.Controls.Add(Me.txtCelularGerente)
        Me.LayoutControl4.Controls.Add(Me.txtTelefonoContador)
        Me.LayoutControl4.Controls.Add(Me.txtEmailContador)
        Me.LayoutControl4.Controls.Add(Me.txtEmailGerente)
        Me.LayoutControl4.Controls.Add(Me.txtTelefonoGerente)
        Me.LayoutControl4.Controls.Add(Me.txtContador)
        Me.LayoutControl4.Controls.Add(Me.txtCedulaContacto)
        Me.LayoutControl4.Controls.Add(Me.txtEmailContacto)
        Me.LayoutControl4.Controls.Add(Me.txtCargoContacto)
        Me.LayoutControl4.Controls.Add(Me.txtContacto)
        Me.LayoutControl4.Controls.Add(Me.txtCelularContacto)
        Me.LayoutControl4.Controls.Add(Me.txtTelefonoContacto)
        Me.LayoutControl4.Controls.Add(Me.txtTelefono)
        Me.LayoutControl4.Controls.Add(Me.txtCiudad)
        Me.LayoutControl4.Controls.Add(Me.txtCorreo)
        Me.LayoutControl4.Controls.Add(Me.cbFormaPago)
        Me.LayoutControl4.Controls.Add(Me.cbVendedor)
        Me.LayoutControl4.Controls.Add(Me.cbCatalogo)
        Me.LayoutControl4.Controls.Add(Me.cbZona)
        Me.LayoutControl4.Controls.Add(Me.tNombreComercial)
        Me.LayoutControl4.Controls.Add(Me.chkAgro)
        Me.LayoutControl4.Controls.Add(Me.chkActivo)
        Me.LayoutControl4.Controls.Add(Me.cbMunicipios)
        Me.LayoutControl4.Controls.Add(Me.cbDepartamentos)
        Me.LayoutControl4.Controls.Add(Me.txtNombre)
        Me.LayoutControl4.Controls.Add(Me.txtDireccion)
        Me.LayoutControl4.Controls.Add(Me.txtObservaciones)
        Me.LayoutControl4.Controls.Add(Me.chkLimite)
        Me.LayoutControl4.Controls.Add(Me.cmbmoneda)
        Me.LayoutControl4.Controls.Add(Me.txtLimiteCredito)
        Me.LayoutControl4.Controls.Add(Me.chkRetenedorAlcaldia)
        Me.LayoutControl4.Controls.Add(Me.chkExcento)
        Me.LayoutControl4.Controls.Add(Me.cbCategoria)
        Me.LayoutControl4.Controls.Add(Me.chkRetenedor)
        Me.LayoutControl4.Controls.Add(Me.chkGarantia)
        Me.LayoutControl4.Controls.Add(Me.chkEmpl)
        Me.LayoutControl4.Controls.Add(Me.txtNombreGerente)
        Me.LayoutControl4.Controls.Add(Me.SimpleButton6)
        Me.LayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl4.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
        Me.LayoutControl4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1062, 166, 250, 350)
        Me.LayoutControl4.Root = Me.LayoutControlGroup4
        Me.LayoutControl4.Size = New System.Drawing.Size(888, 585)
        Me.LayoutControl4.TabIndex = 3
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(816, 254)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(24, 22)
        Me.SimpleButton5.StyleController = Me.LayoutControl4
        Me.SimpleButton5.TabIndex = 234
        Me.SimpleButton5.ToolTip = "Quitar Mascara"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(828, 101)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(24, 22)
        Me.SimpleButton3.StyleController = Me.LayoutControl4
        Me.SimpleButton3.TabIndex = 234
        Me.SimpleButton3.ToolTip = "Quitar Mascara"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(396, 290)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(24, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl4
        Me.SimpleButton2.TabIndex = 234
        Me.SimpleButton2.ToolTip = "Quitar Mascara"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(396, 125)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl4
        Me.SimpleButton1.TabIndex = 234
        Me.SimpleButton1.ToolTip = "Quitar Mascara"
        '
        'sMascara
        '
        Me.sMascara.ImageOptions.Image = CType(resources.GetObject("sMascara.ImageOptions.Image"), System.Drawing.Image)
        Me.sMascara.Location = New System.Drawing.Point(671, 190)
        Me.sMascara.Name = "sMascara"
        Me.sMascara.Size = New System.Drawing.Size(24, 22)
        Me.sMascara.StyleController = Me.LayoutControl4
        Me.sMascara.TabIndex = 233
        Me.sMascara.ToolTip = "Quitar Mascara"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(463, 216)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Properties.Appearance.Options.UseFont = True
        Me.txtCelular.Properties.Mask.EditMask = "(\d?\d?\d?) \d\d\d\d-\d\d\d\d"
        Me.txtCelular.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.txtCelular.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCelular.Properties.MaxLength = 20
        Me.txtCelular.Size = New System.Drawing.Size(204, 20)
        Me.txtCelular.StyleController = Me.LayoutControl4
        Me.txtCelular.TabIndex = 221
        '
        'cbClasificacion
        '
        Me.cbClasificacion.Location = New System.Drawing.Point(182, 500)
        Me.cbClasificacion.Name = "cbClasificacion"
        Me.cbClasificacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClasificacion.Properties.Appearance.Options.UseFont = True
        Me.cbClasificacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbClasificacion.Size = New System.Drawing.Size(399, 20)
        Me.cbClasificacion.StyleController = Me.LayoutControl4
        Me.cbClasificacion.TabIndex = 209
        '
        'cbTipoCliente
        '
        Me.cbTipoCliente.Location = New System.Drawing.Point(480, 142)
        Me.cbTipoCliente.Name = "cbTipoCliente"
        Me.cbTipoCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoCliente.Properties.Appearance.Options.UseFont = True
        Me.cbTipoCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoCliente.Size = New System.Drawing.Size(215, 20)
        Me.cbTipoCliente.StyleController = Me.LayoutControl4
        Me.cbTipoCliente.TabIndex = 209
        Me.cbTipoCliente.Tag = "True"
        '
        'txtRuc
        '
        Me.txtRuc.Location = New System.Drawing.Point(481, 166)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Properties.Appearance.Options.UseFont = True
        Me.txtRuc.Properties.MaxLength = 20
        Me.txtRuc.Size = New System.Drawing.Size(214, 20)
        Me.txtRuc.StyleController = Me.LayoutControl4
        Me.txtRuc.TabIndex = 226
        '
        'Cedula
        '
        Me.Cedula.Location = New System.Drawing.Point(493, 190)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cedula.Properties.Appearance.Options.UseFont = True
        Me.Cedula.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Cedula.Properties.Mask.EditMask = "000-000000-0000L"
        Me.Cedula.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.Cedula.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Cedula.Properties.MaxLength = 20
        Me.Cedula.Size = New System.Drawing.Size(174, 20)
        Me.Cedula.StyleController = Me.LayoutControl4
        Me.Cedula.TabIndex = 227
        '
        'cbPais
        '
        Me.cbPais.Location = New System.Drawing.Point(170, 118)
        Me.cbPais.Name = "cbPais"
        Me.cbPais.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPais.Properties.Appearance.Options.UseFont = True
        Me.cbPais.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPais.Size = New System.Drawing.Size(525, 20)
        Me.cbPais.StyleController = Me.LayoutControl4
        Me.cbPais.TabIndex = 208
        Me.cbPais.Tag = "True"
        '
        'txtCodigoLetra
        '
        Me.txtCodigoLetra.Location = New System.Drawing.Point(438, 46)
        Me.txtCodigoLetra.Name = "txtCodigoLetra"
        Me.txtCodigoLetra.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoLetra.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtCodigoLetra.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoLetra.Properties.Appearance.Options.UseForeColor = True
        Me.txtCodigoLetra.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoLetra.Properties.MaxLength = 15
        Me.txtCodigoLetra.Size = New System.Drawing.Size(209, 20)
        Me.txtCodigoLetra.StyleController = Me.LayoutControl4
        Me.txtCodigoLetra.TabIndex = 225
        Me.txtCodigoLetra.Tag = "True"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(170, 46)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Properties.Appearance.Options.UseFont = True
        Me.txtCodigo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Brown
        Me.txtCodigo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodigo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCodigo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodigo.Properties.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(118, 22)
        Me.txtCodigo.StyleController = Me.LayoutControl4
        Me.txtCodigo.TabIndex = 225
        Me.txtCodigo.Tag = "True"
        '
        'txCelularRepresentante
        '
        Me.txCelularRepresentante.Location = New System.Drawing.Point(495, 175)
        Me.txCelularRepresentante.Name = "txCelularRepresentante"
        Me.txCelularRepresentante.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCelularRepresentante.Properties.Appearance.Options.UseFont = True
        Me.txCelularRepresentante.Properties.Mask.BeepOnError = True
        Me.txCelularRepresentante.Properties.Mask.EditMask = "(999) 0000-0000"
        Me.txCelularRepresentante.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txCelularRepresentante.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txCelularRepresentante.Size = New System.Drawing.Size(357, 20)
        Me.txCelularRepresentante.StyleController = Me.LayoutControl4
        Me.txCelularRepresentante.TabIndex = 231
        '
        'txtTelefonoRepresentante
        '
        Me.txtTelefonoRepresentante.Location = New System.Drawing.Point(504, 151)
        Me.txtTelefonoRepresentante.Name = "txtTelefonoRepresentante"
        Me.txtTelefonoRepresentante.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoRepresentante.Properties.Appearance.Options.UseFont = True
        Me.txtTelefonoRepresentante.Properties.Mask.BeepOnError = True
        Me.txtTelefonoRepresentante.Properties.Mask.EditMask = "(999) 0000-0000"
        Me.txtTelefonoRepresentante.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtTelefonoRepresentante.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTelefonoRepresentante.Size = New System.Drawing.Size(348, 20)
        Me.txtTelefonoRepresentante.StyleController = Me.LayoutControl4
        Me.txtTelefonoRepresentante.TabIndex = 230
        '
        'txtCorreoRepresentante
        '
        Me.txtCorreoRepresentante.Location = New System.Drawing.Point(495, 127)
        Me.txtCorreoRepresentante.Name = "txtCorreoRepresentante"
        Me.txtCorreoRepresentante.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoRepresentante.Properties.Appearance.Options.UseFont = True
        Me.txtCorreoRepresentante.Size = New System.Drawing.Size(357, 20)
        Me.txtCorreoRepresentante.StyleController = Me.LayoutControl4
        Me.txtCorreoRepresentante.TabIndex = 232
        '
        'txtCedulaRepresentante
        '
        Me.txtCedulaRepresentante.Location = New System.Drawing.Point(495, 101)
        Me.txtCedulaRepresentante.Name = "txtCedulaRepresentante"
        Me.txtCedulaRepresentante.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaRepresentante.Properties.Appearance.Options.UseFont = True
        Me.txtCedulaRepresentante.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedulaRepresentante.Properties.Mask.EditMask = "000-000000-0000L"
        Me.txtCedulaRepresentante.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtCedulaRepresentante.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCedulaRepresentante.Size = New System.Drawing.Size(329, 20)
        Me.txtCedulaRepresentante.StyleController = Me.LayoutControl4
        Me.txtCedulaRepresentante.TabIndex = 228
        '
        'txtNombreRepresentante
        '
        Me.txtNombreRepresentante.Location = New System.Drawing.Point(499, 77)
        Me.txtNombreRepresentante.Name = "txtNombreRepresentante"
        Me.txtNombreRepresentante.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreRepresentante.Properties.Appearance.Options.UseFont = True
        Me.txtNombreRepresentante.Size = New System.Drawing.Size(353, 20)
        Me.txtNombreRepresentante.StyleController = Me.LayoutControl4
        Me.txtNombreRepresentante.TabIndex = 225
        '
        'txCedulaContador
        '
        Me.txCedulaContador.Location = New System.Drawing.Point(78, 290)
        Me.txCedulaContador.Name = "txCedulaContador"
        Me.txCedulaContador.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCedulaContador.Properties.Appearance.Options.UseFont = True
        Me.txCedulaContador.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txCedulaContador.Properties.Mask.EditMask = "000-000000-0000L"
        Me.txCedulaContador.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txCedulaContador.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txCedulaContador.Size = New System.Drawing.Size(314, 20)
        Me.txCedulaContador.StyleController = Me.LayoutControl4
        Me.txCedulaContador.TabIndex = 227
        '
        'txCedulaGerente
        '
        Me.txCedulaGerente.Location = New System.Drawing.Point(507, 254)
        Me.txCedulaGerente.Name = "txCedulaGerente"
        Me.txCedulaGerente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCedulaGerente.Properties.Appearance.Options.UseFont = True
        Me.txCedulaGerente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txCedulaGerente.Properties.Mask.EditMask = "000-000000-0000L"
        Me.txCedulaGerente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txCedulaGerente.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txCedulaGerente.Size = New System.Drawing.Size(305, 20)
        Me.txCedulaGerente.StyleController = Me.LayoutControl4
        Me.txCedulaGerente.TabIndex = 227
        '
        'txtCelularContador
        '
        Me.txtCelularContador.Location = New System.Drawing.Point(78, 364)
        Me.txtCelularContador.Name = "txtCelularContador"
        Me.txtCelularContador.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelularContador.Properties.Appearance.Options.UseFont = True
        Me.txtCelularContador.Properties.Mask.BeepOnError = True
        Me.txtCelularContador.Properties.Mask.EditMask = "(999) 0000-0000"
        Me.txtCelularContador.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtCelularContador.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCelularContador.Size = New System.Drawing.Size(342, 20)
        Me.txtCelularContador.StyleController = Me.LayoutControl4
        Me.txtCelularContador.TabIndex = 230
        '
        'txtCelularGerente
        '
        Me.txtCelularGerente.Location = New System.Drawing.Point(507, 328)
        Me.txtCelularGerente.Name = "txtCelularGerente"
        Me.txtCelularGerente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelularGerente.Properties.Appearance.Options.UseFont = True
        Me.txtCelularGerente.Properties.Mask.BeepOnError = True
        Me.txtCelularGerente.Properties.Mask.EditMask = "(999) 0000-0000"
        Me.txtCelularGerente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtCelularGerente.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCelularGerente.Size = New System.Drawing.Size(333, 20)
        Me.txtCelularGerente.StyleController = Me.LayoutControl4
        Me.txtCelularGerente.TabIndex = 225
        '
        'txtTelefonoContador
        '
        Me.txtTelefonoContador.Location = New System.Drawing.Point(87, 340)
        Me.txtTelefonoContador.Name = "txtTelefonoContador"
        Me.txtTelefonoContador.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoContador.Properties.Appearance.Options.UseFont = True
        Me.txtTelefonoContador.Properties.Mask.BeepOnError = True
        Me.txtTelefonoContador.Properties.Mask.EditMask = "(999) 0000-0000"
        Me.txtTelefonoContador.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtTelefonoContador.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTelefonoContador.Size = New System.Drawing.Size(333, 20)
        Me.txtTelefonoContador.StyleController = Me.LayoutControl4
        Me.txtTelefonoContador.TabIndex = 229
        '
        'txtEmailContador
        '
        Me.txtEmailContador.Location = New System.Drawing.Point(78, 316)
        Me.txtEmailContador.Name = "txtEmailContador"
        Me.txtEmailContador.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailContador.Properties.Appearance.Options.UseFont = True
        Me.txtEmailContador.Size = New System.Drawing.Size(342, 20)
        Me.txtEmailContador.StyleController = Me.LayoutControl4
        Me.txtEmailContador.TabIndex = 231
        '
        'txtEmailGerente
        '
        Me.txtEmailGerente.Location = New System.Drawing.Point(507, 280)
        Me.txtEmailGerente.Name = "txtEmailGerente"
        Me.txtEmailGerente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailGerente.Properties.Appearance.Options.UseFont = True
        Me.txtEmailGerente.Size = New System.Drawing.Size(333, 20)
        Me.txtEmailGerente.StyleController = Me.LayoutControl4
        Me.txtEmailGerente.TabIndex = 227
        '
        'txtTelefonoGerente
        '
        Me.txtTelefonoGerente.Location = New System.Drawing.Point(516, 304)
        Me.txtTelefonoGerente.Name = "txtTelefonoGerente"
        Me.txtTelefonoGerente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoGerente.Properties.Appearance.Options.UseFont = True
        Me.txtTelefonoGerente.Properties.Mask.BeepOnError = True
        Me.txtTelefonoGerente.Properties.Mask.EditMask = "(999) 0000-0000"
        Me.txtTelefonoGerente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtTelefonoGerente.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTelefonoGerente.Size = New System.Drawing.Size(324, 20)
        Me.txtTelefonoGerente.StyleController = Me.LayoutControl4
        Me.txtTelefonoGerente.TabIndex = 224
        '
        'txtContador
        '
        Me.txtContador.Location = New System.Drawing.Point(82, 266)
        Me.txtContador.Name = "txtContador"
        Me.txtContador.Size = New System.Drawing.Size(338, 20)
        Me.txtContador.StyleController = Me.LayoutControl4
        Me.txtContador.TabIndex = 232
        '
        'txtCedulaContacto
        '
        Me.txtCedulaContacto.Location = New System.Drawing.Point(78, 125)
        Me.txtCedulaContacto.Name = "txtCedulaContacto"
        Me.txtCedulaContacto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaContacto.Properties.Appearance.Options.UseFont = True
        Me.txtCedulaContacto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedulaContacto.Properties.Mask.EditMask = "000-000000-0000L"
        Me.txtCedulaContacto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtCedulaContacto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCedulaContacto.Size = New System.Drawing.Size(314, 20)
        Me.txtCedulaContacto.StyleController = Me.LayoutControl4
        Me.txtCedulaContacto.TabIndex = 226
        '
        'txtEmailContacto
        '
        Me.txtEmailContacto.Location = New System.Drawing.Point(78, 151)
        Me.txtEmailContacto.Name = "txtEmailContacto"
        Me.txtEmailContacto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailContacto.Properties.Appearance.Options.UseFont = True
        Me.txtEmailContacto.Size = New System.Drawing.Size(342, 20)
        Me.txtEmailContacto.StyleController = Me.LayoutControl4
        Me.txtEmailContacto.TabIndex = 226
        '
        'txtCargoContacto
        '
        Me.txtCargoContacto.Location = New System.Drawing.Point(74, 101)
        Me.txtCargoContacto.Name = "txtCargoContacto"
        Me.txtCargoContacto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargoContacto.Properties.Appearance.Options.UseFont = True
        Me.txtCargoContacto.Size = New System.Drawing.Size(346, 20)
        Me.txtCargoContacto.StyleController = Me.LayoutControl4
        Me.txtCargoContacto.TabIndex = 225
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(82, 77)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacto.Properties.Appearance.Options.UseFont = True
        Me.txtContacto.Size = New System.Drawing.Size(338, 20)
        Me.txtContacto.StyleController = Me.LayoutControl4
        Me.txtContacto.TabIndex = 224
        '
        'txtCelularContacto
        '
        Me.txtCelularContacto.Location = New System.Drawing.Point(78, 199)
        Me.txtCelularContacto.Name = "txtCelularContacto"
        Me.txtCelularContacto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelularContacto.Properties.Appearance.Options.UseFont = True
        Me.txtCelularContacto.Properties.Mask.BeepOnError = True
        Me.txtCelularContacto.Properties.Mask.EditMask = "(999) 0000-0000"
        Me.txtCelularContacto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtCelularContacto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCelularContacto.Size = New System.Drawing.Size(342, 20)
        Me.txtCelularContacto.StyleController = Me.LayoutControl4
        Me.txtCelularContacto.TabIndex = 223
        '
        'txtTelefonoContacto
        '
        Me.txtTelefonoContacto.Location = New System.Drawing.Point(87, 175)
        Me.txtTelefonoContacto.Name = "txtTelefonoContacto"
        Me.txtTelefonoContacto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoContacto.Properties.Appearance.Options.UseFont = True
        Me.txtTelefonoContacto.Properties.Mask.BeepOnError = True
        Me.txtTelefonoContacto.Properties.Mask.EditMask = "(999) 0000-0000"
        Me.txtTelefonoContacto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtTelefonoContacto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTelefonoContacto.Size = New System.Drawing.Size(333, 20)
        Me.txtTelefonoContacto.StyleController = Me.LayoutControl4
        Me.txtTelefonoContacto.TabIndex = 222
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(170, 190)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Properties.Appearance.Options.UseFont = True
        Me.txtFax.Size = New System.Drawing.Size(478, 20)
        Me.txtFax.StyleController = Me.LayoutControl4
        Me.txtFax.TabIndex = 216
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(170, 216)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Properties.Appearance.Options.UseFont = True
        Me.txtTelefono.Properties.Mask.EditMask = "(\d?\d?\d?) \d\d\d\d-\d\d\d\d"
        Me.txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.txtTelefono.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTelefono.Properties.MaxLength = 20
        Me.txtTelefono.Size = New System.Drawing.Size(219, 20)
        Me.txtTelefono.StyleController = Me.LayoutControl4
        Me.txtTelefono.TabIndex = 220
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(170, 347)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Properties.Appearance.Options.UseFont = True
        Me.txtCiudad.Size = New System.Drawing.Size(354, 20)
        Me.txtCiudad.StyleController = Me.LayoutControl4
        Me.txtCiudad.TabIndex = 220
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(170, 242)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Properties.Appearance.Options.UseFont = True
        Me.txtCorreo.Size = New System.Drawing.Size(247, 20)
        Me.txtCorreo.StyleController = Me.LayoutControl4
        Me.txtCorreo.TabIndex = 219
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Location = New System.Drawing.Point(502, 242)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPago.Properties.Appearance.Options.UseFont = True
        Me.cbFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbFormaPago.Size = New System.Drawing.Size(193, 20)
        Me.cbFormaPago.StyleController = Me.LayoutControl4
        Me.cbFormaPago.TabIndex = 209
        Me.cbFormaPago.Tag = "True"
        '
        'cbVendedor
        '
        Me.cbVendedor.Location = New System.Drawing.Point(170, 395)
        Me.cbVendedor.Name = "cbVendedor"
        Me.cbVendedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbVendedor.Properties.View = Me.GridView1
        Me.cbVendedor.Size = New System.Drawing.Size(354, 20)
        Me.cbVendedor.StyleController = Me.LayoutControl4
        Me.cbVendedor.TabIndex = 218
        Me.cbVendedor.Tag = "True"
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cbCatalogo
        '
        Me.cbCatalogo.Location = New System.Drawing.Point(170, 371)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo.Properties.View = Me.SearchLookUpEdit1View
        Me.cbCatalogo.Size = New System.Drawing.Size(354, 20)
        Me.cbCatalogo.StyleController = Me.LayoutControl4
        Me.cbCatalogo.TabIndex = 217
        Me.cbCatalogo.Tag = "True"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'cbZona
        '
        Me.cbZona.Location = New System.Drawing.Point(170, 323)
        Me.cbZona.Name = "cbZona"
        Me.cbZona.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbZona.Properties.Appearance.Options.UseFont = True
        Me.cbZona.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbZona.Size = New System.Drawing.Size(354, 20)
        Me.cbZona.StyleController = Me.LayoutControl4
        Me.cbZona.TabIndex = 208
        '
        'tNombreComercial
        '
        Me.tNombreComercial.Location = New System.Drawing.Point(170, 94)
        Me.tNombreComercial.Name = "tNombreComercial"
        Me.tNombreComercial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tNombreComercial.Size = New System.Drawing.Size(525, 20)
        Me.tNombreComercial.StyleController = Me.LayoutControl4
        Me.tNombreComercial.TabIndex = 214
        '
        'chkAgro
        '
        Me.chkAgro.Location = New System.Drawing.Point(711, 103)
        Me.chkAgro.Name = "chkAgro"
        Me.chkAgro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAgro.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkAgro.Properties.Appearance.Options.UseFont = True
        Me.chkAgro.Properties.Appearance.Options.UseForeColor = True
        Me.chkAgro.Properties.Caption = "Agro Servicio"
        Me.chkAgro.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkAgro.Size = New System.Drawing.Size(131, 22)
        Me.chkAgro.StyleController = Me.LayoutControl4
        Me.chkAgro.TabIndex = 215
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(711, 77)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkActivo.Properties.Appearance.Options.UseFont = True
        Me.chkActivo.Properties.Appearance.Options.UseForeColor = True
        Me.chkActivo.Properties.Caption = "Cliente Activo"
        Me.chkActivo.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkActivo.Size = New System.Drawing.Size(141, 22)
        Me.chkActivo.StyleController = Me.LayoutControl4
        Me.chkActivo.TabIndex = 214
        '
        'cbMunicipios
        '
        Me.cbMunicipios.Location = New System.Drawing.Point(170, 299)
        Me.cbMunicipios.Name = "cbMunicipios"
        Me.cbMunicipios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMunicipios.Properties.Appearance.Options.UseFont = True
        Me.cbMunicipios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMunicipios.Size = New System.Drawing.Size(354, 20)
        Me.cbMunicipios.StyleController = Me.LayoutControl4
        Me.cbMunicipios.TabIndex = 210
        Me.cbMunicipios.Tag = "True"
        '
        'cbDepartamentos
        '
        Me.cbDepartamentos.Location = New System.Drawing.Point(170, 275)
        Me.cbDepartamentos.Name = "cbDepartamentos"
        Me.cbDepartamentos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartamentos.Properties.Appearance.Options.UseFont = True
        Me.cbDepartamentos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDepartamentos.Size = New System.Drawing.Size(354, 20)
        Me.cbDepartamentos.StyleController = Me.LayoutControl4
        Me.cbDepartamentos.TabIndex = 207
        Me.cbDepartamentos.Tag = "True"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(170, 70)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Size = New System.Drawing.Size(525, 20)
        Me.txtNombre.StyleController = Me.LayoutControl4
        Me.txtNombre.TabIndex = 213
        Me.txtNombre.Tag = "True"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(170, 142)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(277, 68)
        Me.txtDireccion.StyleController = Me.LayoutControl4
        Me.txtDireccion.TabIndex = 212
        '
        'chkLimite
        '
        Me.chkLimite.Location = New System.Drawing.Point(36, 450)
        Me.chkLimite.Name = "chkLimite"
        Me.chkLimite.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLimite.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkLimite.Properties.Appearance.Options.UseFont = True
        Me.chkLimite.Properties.Appearance.Options.UseForeColor = True
        Me.chkLimite.Properties.Caption = "Validar Limite de Crédito"
        Me.chkLimite.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkLimite.Size = New System.Drawing.Size(816, 22)
        Me.chkLimite.StyleController = Me.LayoutControl4
        Me.chkLimite.TabIndex = 211
        '
        'cmbmoneda
        '
        Me.cmbmoneda.EnterMoveNextControl = True
        Me.cmbmoneda.Location = New System.Drawing.Point(632, 476)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbmoneda.Properties.NullText = ""
        Me.cmbmoneda.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbmoneda.Properties.ShowFooter = False
        Me.cmbmoneda.Properties.ShowHeader = False
        Me.cmbmoneda.Size = New System.Drawing.Size(220, 20)
        Me.cmbmoneda.StyleController = Me.LayoutControl4
        Me.cmbmoneda.TabIndex = 5
        Me.cmbmoneda.TabStop = False
        '
        'txtLimiteCredito
        '
        Me.txtLimiteCredito.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtLimiteCredito.Location = New System.Drawing.Point(674, 500)
        Me.txtLimiteCredito.Name = "txtLimiteCredito"
        Me.txtLimiteCredito.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtLimiteCredito.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimiteCredito.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtLimiteCredito.Properties.Appearance.Options.UseBackColor = True
        Me.txtLimiteCredito.Properties.Appearance.Options.UseFont = True
        Me.txtLimiteCredito.Properties.Appearance.Options.UseForeColor = True
        Me.txtLimiteCredito.Properties.Appearance.Options.UseTextOptions = True
        Me.txtLimiteCredito.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtLimiteCredito.Properties.Mask.EditMask = "n2"
        Me.txtLimiteCredito.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtLimiteCredito.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtLimiteCredito.Size = New System.Drawing.Size(178, 22)
        Me.txtLimiteCredito.StyleController = Me.LayoutControl4
        Me.txtLimiteCredito.TabIndex = 210
        '
        'chkRetenedorAlcaldia
        '
        Me.chkRetenedorAlcaldia.Location = New System.Drawing.Point(711, 233)
        Me.chkRetenedorAlcaldia.Name = "chkRetenedorAlcaldia"
        Me.chkRetenedorAlcaldia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRetenedorAlcaldia.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkRetenedorAlcaldia.Properties.Appearance.Options.UseFont = True
        Me.chkRetenedorAlcaldia.Properties.Appearance.Options.UseForeColor = True
        Me.chkRetenedorAlcaldia.Properties.Caption = "Retenedor IR Alcaldia"
        Me.chkRetenedorAlcaldia.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkRetenedorAlcaldia.Size = New System.Drawing.Size(141, 22)
        Me.chkRetenedorAlcaldia.StyleController = Me.LayoutControl4
        Me.chkRetenedorAlcaldia.TabIndex = 210
        '
        'chkExcento
        '
        Me.chkExcento.Location = New System.Drawing.Point(711, 207)
        Me.chkExcento.Name = "chkExcento"
        Me.chkExcento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExcento.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkExcento.Properties.Appearance.Options.UseFont = True
        Me.chkExcento.Properties.Appearance.Options.UseForeColor = True
        Me.chkExcento.Properties.Caption = "Exento IVA"
        Me.chkExcento.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkExcento.Size = New System.Drawing.Size(141, 22)
        Me.chkExcento.StyleController = Me.LayoutControl4
        Me.chkExcento.TabIndex = 210
        '
        'cbCategoria
        '
        Me.cbCategoria.Location = New System.Drawing.Point(182, 476)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoria.Properties.Appearance.Options.UseFont = True
        EditorButtonImageOptions1.EnableTransparency = False
        EditorButtonImageOptions2.EnableTransparency = False
        EditorButtonImageOptions3.EnableTransparency = False
        Me.cbCategoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Borrar Datos"), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, True, True, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Editar/Cambiar  Datos"), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Agregar Nuevo Movimiento")})
        Me.cbCategoria.Properties.NullText = "[Seleccione Categoria]"
        Me.cbCategoria.Properties.ShowFooter = False
        Me.cbCategoria.Size = New System.Drawing.Size(399, 20)
        Me.cbCategoria.StyleController = Me.LayoutControl4
        Me.cbCategoria.TabIndex = 4
        '
        'chkRetenedor
        '
        Me.chkRetenedor.Location = New System.Drawing.Point(711, 181)
        Me.chkRetenedor.Name = "chkRetenedor"
        Me.chkRetenedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRetenedor.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkRetenedor.Properties.Appearance.Options.UseFont = True
        Me.chkRetenedor.Properties.Appearance.Options.UseForeColor = True
        Me.chkRetenedor.Properties.Caption = "Retenedor IR"
        Me.chkRetenedor.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkRetenedor.Size = New System.Drawing.Size(141, 22)
        Me.chkRetenedor.StyleController = Me.LayoutControl4
        Me.chkRetenedor.TabIndex = 210
        '
        'chkGarantia
        '
        Me.chkGarantia.Location = New System.Drawing.Point(711, 129)
        Me.chkGarantia.Name = "chkGarantia"
        Me.chkGarantia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGarantia.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkGarantia.Properties.Appearance.Options.UseFont = True
        Me.chkGarantia.Properties.Appearance.Options.UseForeColor = True
        Me.chkGarantia.Properties.Caption = "Garantia Bancaria"
        Me.chkGarantia.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkGarantia.Size = New System.Drawing.Size(141, 22)
        Me.chkGarantia.StyleController = Me.LayoutControl4
        Me.chkGarantia.TabIndex = 209
        '
        'chkEmpl
        '
        Me.chkEmpl.Location = New System.Drawing.Point(711, 155)
        Me.chkEmpl.Name = "chkEmpl"
        Me.chkEmpl.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEmpl.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkEmpl.Properties.Appearance.Options.UseFont = True
        Me.chkEmpl.Properties.Appearance.Options.UseForeColor = True
        Me.chkEmpl.Properties.Caption = "Para Empleados"
        Me.chkEmpl.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkEmpl.Size = New System.Drawing.Size(141, 22)
        Me.chkEmpl.StyleController = Me.LayoutControl4
        Me.chkEmpl.TabIndex = 208
        '
        'txtNombreGerente
        '
        Me.txtNombreGerente.Location = New System.Drawing.Point(507, 230)
        Me.txtNombreGerente.Name = "txtNombreGerente"
        Me.txtNombreGerente.Size = New System.Drawing.Size(333, 20)
        Me.txtNombreGerente.StyleController = Me.LayoutControl4
        Me.txtNombreGerente.TabIndex = 228
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtFax
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(628, 24)
        Me.LayoutControlItem4.Text = "Fax:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "Root"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "Root"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(888, 585)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.CustomizationFormText = "TabbedControlGroup1"
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup5
        Me.TabbedControlGroup1.SelectedTabPageIndex = 0
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(868, 565)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup5, Me.LayoutControlGroup8})
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "Datos Generales"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem21, Me.LayoutControlItem1, Me.LayoutControlItem6, Me.LayoutControlItem32, Me.EmptySpaceItem1, Me.LayoutControlItem62, Me.LayoutControlItem63, Me.LayoutControlGroup2, Me.LayoutControlGroup9, Me.LayoutControlItem5, Me.LayoutControlItem35, Me.LayoutControlItem22, Me.LayoutControlItem17, Me.LayoutControlItem44, Me.LayoutControlItem20, Me.LayoutControlItem26, Me.LayoutControlItem28, Me.LayoutControlItem14, Me.LayoutControlItem34, Me.LayoutControlItem27, Me.LayoutControlItem33, Me.LayoutControlItem57, Me.LayoutControlItem29, Me.EmptySpaceItem2, Me.LayoutControlItem65, Me.LayoutControlItem70, Me.LayoutControlItem71})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(844, 519)
        Me.LayoutControlGroup5.Text = "Datos Generales"
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtNombre
        Me.LayoutControlItem21.CustomizationFormText = "Nombre:"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(675, 24)
        Me.LayoutControlItem21.Text = "Cliente:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtObservaciones
        Me.LayoutControlItem1.CustomizationFormText = "Comentarios y Observaciones"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(504, 229)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(340, 144)
        Me.LayoutControlItem1.Text = "Comentarios y Observaciones"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbZona
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 277)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(504, 24)
        Me.LayoutControlItem6.Text = "Zona:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.txtCiudad
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 301)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(504, 24)
        Me.LayoutControlItem32.Text = "Ciudad:"
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(143, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 492)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(844, 27)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem62
        '
        Me.LayoutControlItem62.Control = Me.txtCodigo
        Me.LayoutControlItem62.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem62.MaxSize = New System.Drawing.Size(268, 24)
        Me.LayoutControlItem62.MinSize = New System.Drawing.Size(268, 24)
        Me.LayoutControlItem62.Name = "LayoutControlItem62"
        Me.LayoutControlItem62.Size = New System.Drawing.Size(268, 24)
        Me.LayoutControlItem62.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem62.Text = "Código:"
        Me.LayoutControlItem62.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlItem63
        '
        Me.LayoutControlItem63.Control = Me.txtCodigoLetra
        Me.LayoutControlItem63.Location = New System.Drawing.Point(268, 0)
        Me.LayoutControlItem63.MaxSize = New System.Drawing.Size(359, 24)
        Me.LayoutControlItem63.MinSize = New System.Drawing.Size(359, 24)
        Me.LayoutControlItem63.Name = "LayoutControlItem63"
        Me.LayoutControlItem63.Size = New System.Drawing.Size(359, 24)
        Me.LayoutControlItem63.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem63.Text = "Codigo Letra:"
        Me.LayoutControlItem63.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.BackColor = System.Drawing.Color.Transparent
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseBackColor = True
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent
        Me.LayoutControlGroup2.AppearanceItemCaption.Options.UseBackColor = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem43, Me.LayoutControlItem41, Me.LayoutControlItem40, Me.LayoutControlItem42, Me.LayoutControlItem16})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 373)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(844, 119)
        Me.LayoutControlGroup2.Text = "Limite de Crédito"
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.chkLimite
        Me.LayoutControlItem43.CustomizationFormText = "LayoutControlItem43"
        Me.LayoutControlItem43.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(820, 26)
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem43.TextVisible = False
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.txtLimiteCredito
        Me.LayoutControlItem41.CustomizationFormText = "Límite de Credito:"
        Me.LayoutControlItem41.Location = New System.Drawing.Point(549, 50)
        Me.LayoutControlItem41.MaxSize = New System.Drawing.Size(271, 26)
        Me.LayoutControlItem41.MinSize = New System.Drawing.Size(271, 26)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(271, 26)
        Me.LayoutControlItem41.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem41.Text = "Límite de Credito:"
        Me.LayoutControlItem41.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(84, 13)
        Me.LayoutControlItem41.TextToControlDistance = 5
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.cbCategoria
        Me.LayoutControlItem40.CustomizationFormText = "Categoria:"
        Me.LayoutControlItem40.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(549, 24)
        Me.LayoutControlItem40.Text = "Categoria:"
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.cmbmoneda
        Me.LayoutControlItem42.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem42.Location = New System.Drawing.Point(549, 26)
        Me.LayoutControlItem42.MaxSize = New System.Drawing.Size(271, 24)
        Me.LayoutControlItem42.MinSize = New System.Drawing.Size(271, 24)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(271, 24)
        Me.LayoutControlItem42.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem42.Text = "Moneda:"
        Me.LayoutControlItem42.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(42, 13)
        Me.LayoutControlItem42.TextToControlDistance = 5
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cbClasificacion
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(549, 26)
        Me.LayoutControlItem16.Text = "Clasificación:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlGroup9
        '
        Me.LayoutControlGroup9.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup9.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem19, Me.LayoutControlItem18, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem25})
        Me.LayoutControlGroup9.Location = New System.Drawing.Point(675, 0)
        Me.LayoutControlGroup9.Name = "LayoutControlGroup9"
        Me.LayoutControlGroup9.Size = New System.Drawing.Size(169, 229)
        Me.LayoutControlGroup9.Text = "Configuración"
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.chkGarantia
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(145, 26)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.chkEmpl
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(145, 26)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.chkActivo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(145, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.chkAgro
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(135, 26)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(135, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(145, 26)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.chkRetenedor
        Me.LayoutControlItem23.CustomizationFormText = "LayoutControlItem23"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(145, 26)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.chkExcento
        Me.LayoutControlItem24.CustomizationFormText = "LayoutControlItem24"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 130)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(145, 26)
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.chkRetenedorAlcaldia
        Me.LayoutControlItem25.CustomizationFormText = "LayoutControlItem25"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(145, 30)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.tNombreComercial
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(675, 24)
        Me.LayoutControlItem5.Text = "Nombre Comercial:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.txtCorreo
        Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 196)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(397, 33)
        Me.LayoutControlItem35.Text = "Correo:"
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtRuc
        Me.LayoutControlItem22.Location = New System.Drawing.Point(427, 120)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.Text = "RUC:"
        Me.LayoutControlItem22.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(25, 13)
        Me.LayoutControlItem22.TextToControlDistance = 5
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.Cedula
        Me.LayoutControlItem17.Location = New System.Drawing.Point(427, 144)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(220, 26)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.Text = "Cédula:"
        Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem17.TextToControlDistance = 5
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.txtDireccion
        Me.LayoutControlItem44.CustomizationFormText = "Dirección:"
        Me.LayoutControlItem44.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem44.MaxSize = New System.Drawing.Size(0, 72)
        Me.LayoutControlItem44.MinSize = New System.Drawing.Size(160, 72)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(427, 74)
        Me.LayoutControlItem44.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem44.Text = "Dirección:"
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cbTipoCliente
        Me.LayoutControlItem20.Location = New System.Drawing.Point(427, 96)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(248, 24)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.Text = "Tipo:"
        Me.LayoutControlItem20.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(24, 13)
        Me.LayoutControlItem20.TextToControlDistance = 5
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.txtTelefono
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 170)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(369, 26)
        Me.LayoutControlItem26.Text = "Telefono:"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txtCelular
        Me.LayoutControlItem28.Location = New System.Drawing.Point(397, 170)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(250, 26)
        Me.LayoutControlItem28.Text = "Celular:"
        Me.LayoutControlItem28.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem28.TextToControlDistance = 5
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cbPais
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(675, 24)
        Me.LayoutControlItem14.Text = "Pais:"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.cbFormaPago
        Me.LayoutControlItem34.Location = New System.Drawing.Point(397, 196)
        Me.LayoutControlItem34.MaxSize = New System.Drawing.Size(278, 33)
        Me.LayoutControlItem34.MinSize = New System.Drawing.Size(278, 33)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(278, 33)
        Me.LayoutControlItem34.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem34.Text = "Forma de Pago:"
        Me.LayoutControlItem34.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(76, 13)
        Me.LayoutControlItem34.TextToControlDistance = 5
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.cbCatalogo
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 325)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(504, 24)
        Me.LayoutControlItem27.Text = "Cuenta:"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.cbVendedor
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 349)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(504, 24)
        Me.LayoutControlItem33.Text = "Vendedor:"
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlItem57
        '
        Me.LayoutControlItem57.Control = Me.cbDepartamentos
        Me.LayoutControlItem57.Location = New System.Drawing.Point(0, 229)
        Me.LayoutControlItem57.Name = "LayoutControlItem57"
        Me.LayoutControlItem57.Size = New System.Drawing.Size(504, 24)
        Me.LayoutControlItem57.Text = "Departamento:"
        Me.LayoutControlItem57.TextSize = New System.Drawing.Size(143, 13)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.cbMunicipios
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 253)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(504, 24)
        Me.LayoutControlItem29.Text = "Municipio:"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(143, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(627, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(48, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem65
        '
        Me.LayoutControlItem65.Control = Me.sMascara
        Me.LayoutControlItem65.Location = New System.Drawing.Point(647, 144)
        Me.LayoutControlItem65.MaxSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem65.MinSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem65.Name = "LayoutControlItem65"
        Me.LayoutControlItem65.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem65.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem65.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem65.TextVisible = False
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.CustomizationFormText = "Contactos"
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup10, Me.LayoutControlGroup12, Me.LayoutControlGroup1, Me.EmptySpaceItem3, Me.SplitterItem1})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(844, 519)
        Me.LayoutControlGroup8.Text = "Contactos"
        '
        'LayoutControlGroup10
        '
        Me.LayoutControlGroup10.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup10.AppearanceGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.LayoutControlGroup10.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup10.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup10.CustomizationFormText = "Contacto"
        Me.LayoutControlGroup10.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem31, Me.LayoutControlItem38, Me.LayoutControlItem39, Me.LayoutControlItem15, Me.LayoutControlItem37, Me.LayoutControlItem36, Me.LayoutControlItem66})
        Me.LayoutControlGroup10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup10.Name = "LayoutControlGroup10"
        Me.LayoutControlGroup10.Size = New System.Drawing.Size(412, 189)
        Me.LayoutControlGroup10.Text = "Contacto"
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.txtContacto
        Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(388, 24)
        Me.LayoutControlItem31.Text = "Nombre:"
        Me.LayoutControlItem31.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(41, 13)
        Me.LayoutControlItem31.TextToControlDistance = 5
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.txtEmailContacto
        Me.LayoutControlItem38.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(388, 24)
        Me.LayoutControlItem38.Text = "Correo:"
        Me.LayoutControlItem38.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem38.TextToControlDistance = 5
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.txtCedulaContacto
        Me.LayoutControlItem39.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(360, 26)
        Me.LayoutControlItem39.Text = "Cédula:"
        Me.LayoutControlItem39.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem39.TextToControlDistance = 5
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtCargoContacto
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(388, 24)
        Me.LayoutControlItem15.Text = "Cargo:"
        Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(33, 13)
        Me.LayoutControlItem15.TextToControlDistance = 5
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.txtCelularContacto
        Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(388, 24)
        Me.LayoutControlItem37.Text = "Celular:"
        Me.LayoutControlItem37.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem37.TextToControlDistance = 5
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.txtTelefonoContacto
        Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(388, 24)
        Me.LayoutControlItem36.Text = "Telefono:"
        Me.LayoutControlItem36.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(46, 13)
        Me.LayoutControlItem36.TextToControlDistance = 5
        '
        'LayoutControlItem66
        '
        Me.LayoutControlItem66.Control = Me.SimpleButton1
        Me.LayoutControlItem66.Location = New System.Drawing.Point(360, 48)
        Me.LayoutControlItem66.MaxSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem66.MinSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem66.Name = "LayoutControlItem66"
        Me.LayoutControlItem66.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem66.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem66.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem66.TextVisible = False
        '
        'LayoutControlGroup12
        '
        Me.LayoutControlGroup12.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup12.AppearanceGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.LayoutControlGroup12.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup12.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup12.CustomizationFormText = "Contador"
        Me.LayoutControlGroup12.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem50, Me.LayoutControlItem51, Me.LayoutControlItem52, Me.LayoutControlItem58, Me.LayoutControlItem54, Me.LayoutControlItem67})
        Me.LayoutControlGroup12.Location = New System.Drawing.Point(0, 189)
        Me.LayoutControlGroup12.Name = "LayoutControlGroup12"
        Me.LayoutControlGroup12.Size = New System.Drawing.Size(412, 165)
        Me.LayoutControlGroup12.Text = "Contador"
        '
        'LayoutControlItem50
        '
        Me.LayoutControlItem50.Control = Me.txtContador
        Me.LayoutControlItem50.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem50.Name = "LayoutControlItem50"
        Me.LayoutControlItem50.Size = New System.Drawing.Size(388, 24)
        Me.LayoutControlItem50.Text = "Nombre:"
        Me.LayoutControlItem50.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem50.TextSize = New System.Drawing.Size(41, 13)
        Me.LayoutControlItem50.TextToControlDistance = 5
        '
        'LayoutControlItem51
        '
        Me.LayoutControlItem51.Control = Me.txtEmailContador
        Me.LayoutControlItem51.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem51.Name = "LayoutControlItem51"
        Me.LayoutControlItem51.Size = New System.Drawing.Size(388, 24)
        Me.LayoutControlItem51.Text = "Correo:"
        Me.LayoutControlItem51.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem51.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem51.TextToControlDistance = 5
        '
        'LayoutControlItem52
        '
        Me.LayoutControlItem52.Control = Me.txtTelefonoContador
        Me.LayoutControlItem52.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem52.Name = "LayoutControlItem52"
        Me.LayoutControlItem52.Size = New System.Drawing.Size(388, 24)
        Me.LayoutControlItem52.Text = "Telefono:"
        Me.LayoutControlItem52.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem52.TextSize = New System.Drawing.Size(46, 13)
        Me.LayoutControlItem52.TextToControlDistance = 5
        '
        'LayoutControlItem58
        '
        Me.LayoutControlItem58.Control = Me.txtCelularContador
        Me.LayoutControlItem58.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem58.Name = "LayoutControlItem58"
        Me.LayoutControlItem58.Size = New System.Drawing.Size(388, 24)
        Me.LayoutControlItem58.Text = "Celular:"
        Me.LayoutControlItem58.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem58.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem58.TextToControlDistance = 5
        '
        'LayoutControlItem54
        '
        Me.LayoutControlItem54.Control = Me.txCedulaContador
        Me.LayoutControlItem54.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem54.Name = "LayoutControlItem54"
        Me.LayoutControlItem54.Size = New System.Drawing.Size(360, 26)
        Me.LayoutControlItem54.Text = "Cédula:"
        Me.LayoutControlItem54.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem54.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem54.TextToControlDistance = 5
        '
        'LayoutControlItem67
        '
        Me.LayoutControlItem67.Control = Me.SimpleButton2
        Me.LayoutControlItem67.Location = New System.Drawing.Point(360, 24)
        Me.LayoutControlItem67.MaxSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem67.MinSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem67.Name = "LayoutControlItem67"
        Me.LayoutControlItem67.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem67.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem67.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem67.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup1.AppearanceGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem55, Me.LayoutControlItem56, Me.LayoutControlItem59, Me.LayoutControlItem60, Me.LayoutControlItem61, Me.LayoutControlGroup11, Me.LayoutControlItem68})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(417, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(427, 354)
        Me.LayoutControlGroup1.Text = "Representante Legal"
        '
        'LayoutControlItem55
        '
        Me.LayoutControlItem55.Control = Me.txtNombreRepresentante
        Me.LayoutControlItem55.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem55.Name = "LayoutControlItem55"
        Me.LayoutControlItem55.Size = New System.Drawing.Size(403, 24)
        Me.LayoutControlItem55.Text = "Nombre:"
        Me.LayoutControlItem55.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem55.TextSize = New System.Drawing.Size(41, 13)
        Me.LayoutControlItem55.TextToControlDistance = 5
        '
        'LayoutControlItem56
        '
        Me.LayoutControlItem56.Control = Me.txtCedulaRepresentante
        Me.LayoutControlItem56.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem56.Name = "LayoutControlItem56"
        Me.LayoutControlItem56.Size = New System.Drawing.Size(375, 26)
        Me.LayoutControlItem56.Text = "Cédula:"
        Me.LayoutControlItem56.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem56.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem56.TextToControlDistance = 5
        '
        'LayoutControlItem59
        '
        Me.LayoutControlItem59.Control = Me.txtCorreoRepresentante
        Me.LayoutControlItem59.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem59.Name = "LayoutControlItem59"
        Me.LayoutControlItem59.Size = New System.Drawing.Size(403, 24)
        Me.LayoutControlItem59.Text = "Correo:"
        Me.LayoutControlItem59.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem59.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem59.TextToControlDistance = 5
        '
        'LayoutControlItem60
        '
        Me.LayoutControlItem60.Control = Me.txtTelefonoRepresentante
        Me.LayoutControlItem60.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem60.Name = "LayoutControlItem60"
        Me.LayoutControlItem60.Size = New System.Drawing.Size(403, 24)
        Me.LayoutControlItem60.Text = "Telefono:"
        Me.LayoutControlItem60.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem60.TextSize = New System.Drawing.Size(46, 13)
        Me.LayoutControlItem60.TextToControlDistance = 5
        '
        'LayoutControlItem61
        '
        Me.LayoutControlItem61.Control = Me.txCelularRepresentante
        Me.LayoutControlItem61.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem61.Name = "LayoutControlItem61"
        Me.LayoutControlItem61.Size = New System.Drawing.Size(403, 24)
        Me.LayoutControlItem61.Text = "Celular:"
        Me.LayoutControlItem61.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem61.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem61.TextToControlDistance = 5
        '
        'LayoutControlGroup11
        '
        Me.LayoutControlGroup11.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup11.AppearanceGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.LayoutControlGroup11.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup11.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup11.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem46, Me.LayoutControlItem47, Me.LayoutControlItem48, Me.LayoutControlItem49, Me.LayoutControlItem53, Me.LayoutControlItem69})
        Me.LayoutControlGroup11.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlGroup11.Name = "LayoutControlGroup11"
        Me.LayoutControlGroup11.Size = New System.Drawing.Size(403, 189)
        Me.LayoutControlGroup11.Text = "Gerente"
        '
        'LayoutControlItem46
        '
        Me.LayoutControlItem46.Control = Me.txtNombreGerente
        Me.LayoutControlItem46.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem46.Name = "LayoutControlItem46"
        Me.LayoutControlItem46.Size = New System.Drawing.Size(379, 24)
        Me.LayoutControlItem46.Text = "Nombre"
        Me.LayoutControlItem46.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem46.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem46.TextToControlDistance = 5
        '
        'LayoutControlItem47
        '
        Me.LayoutControlItem47.Control = Me.txtEmailGerente
        Me.LayoutControlItem47.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem47.Name = "LayoutControlItem47"
        Me.LayoutControlItem47.Size = New System.Drawing.Size(379, 24)
        Me.LayoutControlItem47.Text = "Correo:"
        Me.LayoutControlItem47.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem47.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem47.TextToControlDistance = 5
        '
        'LayoutControlItem48
        '
        Me.LayoutControlItem48.Control = Me.txtTelefonoGerente
        Me.LayoutControlItem48.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem48.Name = "LayoutControlItem48"
        Me.LayoutControlItem48.Size = New System.Drawing.Size(379, 24)
        Me.LayoutControlItem48.Text = "Telefono:"
        Me.LayoutControlItem48.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem48.TextSize = New System.Drawing.Size(46, 13)
        Me.LayoutControlItem48.TextToControlDistance = 5
        '
        'LayoutControlItem49
        '
        Me.LayoutControlItem49.Control = Me.txtCelularGerente
        Me.LayoutControlItem49.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem49.Name = "LayoutControlItem49"
        Me.LayoutControlItem49.Size = New System.Drawing.Size(379, 48)
        Me.LayoutControlItem49.Text = "Celular:"
        Me.LayoutControlItem49.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem49.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem49.TextToControlDistance = 5
        '
        'LayoutControlItem53
        '
        Me.LayoutControlItem53.Control = Me.txCedulaGerente
        Me.LayoutControlItem53.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem53.Name = "LayoutControlItem53"
        Me.LayoutControlItem53.Size = New System.Drawing.Size(351, 26)
        Me.LayoutControlItem53.Text = "Cédula:"
        Me.LayoutControlItem53.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem53.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem53.TextToControlDistance = 5
        '
        'LayoutControlItem69
        '
        Me.LayoutControlItem69.Control = Me.SimpleButton5
        Me.LayoutControlItem69.Location = New System.Drawing.Point(351, 24)
        Me.LayoutControlItem69.MaxSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem69.MinSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem69.Name = "LayoutControlItem69"
        Me.LayoutControlItem69.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem69.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem69.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem69.TextVisible = False
        '
        'LayoutControlItem68
        '
        Me.LayoutControlItem68.Control = Me.SimpleButton3
        Me.LayoutControlItem68.Location = New System.Drawing.Point(375, 24)
        Me.LayoutControlItem68.MaxSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem68.MinSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem68.Name = "LayoutControlItem68"
        Me.LayoutControlItem68.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem68.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem68.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem68.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 354)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(844, 165)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.Location = New System.Drawing.Point(412, 0)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(5, 354)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("4775b374-1aba-49d0-a63c-69d8ded23746")
        Me.DockPanel1.Location = New System.Drawing.Point(888, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(150, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(150, 585)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl3)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(141, 558)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.CustomizationFormText = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(697, 441)
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.CustomizationFormText = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(697, 441)
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(50, 20)
        '
        'SimpleButton6
        '
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(671, 216)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(24, 22)
        Me.SimpleButton6.StyleController = Me.LayoutControl4
        Me.SimpleButton6.TabIndex = 235
        Me.SimpleButton6.ToolTip = "Quitar Mascara"
        '
        'LayoutControlItem70
        '
        Me.LayoutControlItem70.Control = Me.SimpleButton6
        Me.LayoutControlItem70.Location = New System.Drawing.Point(647, 170)
        Me.LayoutControlItem70.MaxSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem70.MinSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem70.Name = "LayoutControlItem70"
        Me.LayoutControlItem70.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem70.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem70.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem70.TextVisible = False
        '
        'SimpleButton7
        '
        Me.SimpleButton7.ImageOptions.Image = CType(resources.GetObject("SimpleButton7.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(393, 216)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(24, 22)
        Me.SimpleButton7.StyleController = Me.LayoutControl4
        Me.SimpleButton7.TabIndex = 236
        Me.SimpleButton7.ToolTip = "Quitar Mascara"
        '
        'LayoutControlItem71
        '
        Me.LayoutControlItem71.Control = Me.SimpleButton7
        Me.LayoutControlItem71.Location = New System.Drawing.Point(369, 170)
        Me.LayoutControlItem71.MaxSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem71.MinSize = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem71.Name = "LayoutControlItem71"
        Me.LayoutControlItem71.Size = New System.Drawing.Size(28, 26)
        Me.LayoutControlItem71.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem71.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem71.TextVisible = False
        '
        'frmAgregarCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1038, 585)
        Me.Controls.Add(Me.LayoutControl4)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmAgregarCliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.txtCelular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbClasificacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipoCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cedula.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoLetra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txCelularRepresentante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonoRepresentante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorreoRepresentante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCedulaRepresentante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreRepresentante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txCedulaContador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txCedulaGerente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCelularContador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCelularGerente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonoContador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmailContador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmailGerente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonoGerente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCedulaContacto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmailContacto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCargoContacto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContacto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCelularContacto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonoContacto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCiudad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorreo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbVendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbZona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNombreComercial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAgro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMunicipios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDepartamentos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLimite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLimiteCredito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRetenedorAlcaldia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExcento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRetenedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGarantia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEmpl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreGerente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim vendedor As String
    Dim Cod_Vendedor As Integer

    Dim Nombre As String = String.Empty,
        cuenta As String = String.Empty

    Public clientes As New VB.SysContab.ClientesDB(),
        Detalles As New VB.SysContab.ClientesDetails(),
        Cliente As Integer = 0

    Dim objCampos As New CamposRequeridos
    Dim RequeridosDB As New db_CamposRequeridos

    Dim objCliente As New CLIENTES
    Dim ClienteDB As New db_CLIENTES
    Private Sub frmAgregarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Verificar si hay campos requeridos
        RequeridosDB.SetCamposRequeridos(
            LayoutControl4,
            Me.Name,
            EmpresaActual)
        '
        AddValidation(Me, DxValidationProvider1)
        '
        CargarCombos()
        '
        If Cliente > 0 Then
            cmdEstadoCuenta.Enabled = True
            bAcuerdosPagos.Enabled = True
            '
            MostrarDatos()
        Else
            txtCodigo.Text =
                ClienteDB.GetCodigo(EmpresaActual)

            Nombre = String.Empty
            chkActivo.Checked = True
            MascaraTelefonos()
        End If
        '
        If Not EmpresaActual.Equals("1") Then
            Cedula.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            txtCedulaContacto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            txCedulaContador.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            txCedulaGerente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            txtCedulaRepresentante.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None

        End If
        txtCodigoLetra.Focus()


        'If Nuevo = "NO" Then
        '    Me.Text = "Editar Cliente"
        '    cmdEstadoCuenta.Enabled = True
        '    bAcuerdosPagos.Enabled = True

        '    Detalles = VB.SysContab.ClientesDB.GetDetails(Cliente)
        '    Me.txtCodigo.Text = Detalles.Codigo '"C-" & Format(CInt(Detalles.Codigo), "0000")
        '    Me.txtCodigoLetra.Text = Detalles.CodigoLetra

        '    'Nombre = Detalles.Nombre
        '    'Me.txtNombre.Text = Detalles.Nombre
        '    'tNombreComercial.Text = Detalles.Nombre_Comercial
        '    'Me.txtContacto.Text = Detalles.Contacto
        '    'Me.txtCargoContacto.Text = Detalles.Cargo
        '    'Me.txtTelefonoContacto.Text = Detalles.Telefono_Contacto
        '    'Me.txtCelularContacto.Text = Detalles.Celular_Contacto
        '    'Me.txtEmailContacto.Text = Detalles.Email_Contacto
        '    'txtNombreGerente.Text = Detalles.Gerente
        '    'Me.txtTelefonoGerente.Text = Detalles.Telefono_Gerente
        '    'Me.txtCelularGerente.Text = Detalles.Celular_Gerente
        '    'Me.txtEmailGerente.Text = Detalles.Email_Gerente
        '    'Me.txtContador.Text = Detalles.Contador
        '    'Me.txtTelefonoContador.Text = Detalles.Telefono_Contador
        '    'Me.txtCelularContador.Text = Detalles.Celular_Contador
        '    'Me.txtEmailContador.Text = Detalles.Email_Contador
        '    'Me.txtDireccion.Text = Detalles.Direccion
        '    'Me.txtCiudad.Text = Detalles.Ciudad
        '    'Me.cbDepartamentos.EditValue = Detalles.Departamento
        '    'Me.cbMunicipios.EditValue = Detalles.Municipio
        '    'Me.cbPais.EditValue = Detalles.Pais
        '    'Me.txtTelefono.Text = Detalles.Telefono
        '    'Me.txtFax.Text = Detalles.Fax
        '    'Me.txtCorreo.Text = Detalles.Correo
        '    'Me.txtRuc.Text = Detalles.Ruc
        '    'Me.Cedula.Text = Detalles.Cedula
        '    'txtObservaciones.Text = Detalles.Comentario

        '    'Me.cbFormaPago.EditValue = Detalles.Cod_Forma_Pago
        '    'Me.cbCatalogo.EditValue = Detalles.Cuenta
        '    'Cod_Cuenta = Detalles.Cuenta

        '    'If Detalles.Desc_Prod = "P" Then
        '    '    cbDescProd.SelectedIndex = 0
        '    'ElseIf Detalles.Desc_Prod = "A" Then
        '    '    cbDescProd.SelectedIndex = 1
        '    'ElseIf Detalles.Desc_Prod = "B" Then
        '    '    cbDescProd.SelectedIndex = 2
        '    'ElseIf Detalles.Desc_Prod = "C" Then
        '    '    cbDescProd.SelectedIndex = 3
        '    'End If

        '    'If Detalles.Desc_Serv = "P" Then
        '    '    cbDescServ.SelectedIndex = 0
        '    'ElseIf Detalles.Desc_Serv = "A" Then
        '    '    cbDescServ.SelectedIndex = 1
        '    'ElseIf Detalles.Desc_Serv = "B" Then
        '    '    cbDescServ.SelectedIndex = 2
        '    'ElseIf Detalles.Desc_Serv = "C" Then
        '    '    cbDescServ.SelectedIndex = 3
        '    'End If

        '    'Me.txtDescAdicional.Text = Detalles.Desc_Adicional
        '    Me.txtLimiteCredito.EditValue = Detalles.Limite_Credito

        '    Me.cbZona.EditValue = IIf(Detalles.Cod_Zona = "", 0, Detalles.Cod_Zona)
        '    Cod_Vendedor = IIf(Detalles.Vendedor = "", 0, Detalles.Vendedor)
        '    Me.cbVendedor.EditValue = IIf(Detalles.Vendedor = "", 0, Detalles.Vendedor)
        '    Me.cbTipoCliente.EditValue = Detalles.TipoCliente - 1

        '    Me.chkExcento.Checked = Detalles.Excento
        '    Me.chkRetenedor.Checked = Detalles.Retenedor
        '    Me.chkRetenedorAlcaldia.Checked = Detalles.RetenedorAlcaldia

        '    Me.chkEmpl.Checked = Detalles.Empleado
        '    Me.chkGarantia.Checked = Detalles.Garantia
        '    cbCategoria.EditValue = Detalles.Categoria
        '    cmbmoneda.EditValue = Detalles.Moneda
        '    chkLimite.Checked = Detalles.ValidarLimite
        '    chkActivo.Checked = Detalles.Activo
        '    chkAgro.Checked = Detalles.Agro
        'Else
        '    Me.Text = "Agregar Cliente"
        '    If clientes.GenerarCodigo().Tables("Clientes").Rows.Count <> 0 Then
        '        Me.txtCodigo.Text = clientes.GenerarCodigo().Tables("Clientes").Rows(0).Item("Codigo") + 1
        '    Else
        '        Me.txtCodigo.Text = "1"
        '    End If

        '    Nombre = ""
        '    chkActivo.Checked = True
        '    MascaraTelefonos()
        'End If

        'CargarDocumentos()
        'r.ComboAutoComplete(Me.cbCatalogo)
        'r.ComboAutoComplete(Me.cbZona)
        'Me.Refresh()
    End Sub

    Sub MostrarDatos()

        objCliente = ClienteDB.Detalles(Cliente, EmpresaActual)
        Dim Muni As New VB.SysContab.MunicipiosDB
        '
        txtCodigo.Text = objCliente.CODIGO
        txtCodigoLetra.Text = objCliente.CodigoLetra
        Nombre = objCliente.NOMBRE
        txtNombre.Text = objCliente.NOMBRE
        tNombreComercial.Text = objCliente.Nombre_Comercial
        cbPais.EditValue = objCliente.Pais_Id

        If objCliente.TELEFONO.Trim.Length > 0 Then txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        If objCliente.CELULAR.Trim.Length > 0 Then txtCelular.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None

        If objCliente.TELEFONO_CONTACTO.Trim.Length > 0 Then txtTelefonoContacto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        If objCliente.CELULAR_CONTACTO.Trim.Length > 0 Then txtCelularContacto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None

        If objCliente.TELEFONO_GERENTE.Trim.Length > 0 Then txtTelefonoGerente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        If objCliente.CELULAR_GERENTE.Trim.Length > 0 Then txtCelularGerente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None

        If objCliente.TELEFONO_CONTADOR.Trim.Length > 0 Then txtTelefonoContador.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        If objCliente.CELULAR_CONTADOR.Trim.Length > 0 Then txtCelularContador.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None

        If objCliente.TELEFONO_REPRESENTANTE.Trim.Length > 0 Then txtTelefonoRepresentante.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        If objCliente.CELULAR_REPRESENTANTE.Trim.Length > 0 Then txCelularRepresentante.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None

        'Dim Area As String = cbPais.GetColumnValue("Area")
        'txtTelefono.EditValue = IIf(Area.Trim.Length > 0, IIf(Area.Trim.Equals(Mid(objCliente.TELEFONO, 1, 3)), objCliente.TELEFONO, $"{Area}{objCliente.TELEFONO}"), objCliente.TELEFONO)

        txtTelefono.Text = objCliente.TELEFONO
        txtCelular.EditValue = objCliente.CELULAR
        txtCorreo.Text = objCliente.CORREO
        cbTipoCliente.EditValue = objCliente.TipoCliente
        txtRuc.Text = objCliente.RUC
        Cedula.Text = objCliente.Cedula
        txtDireccion.Text = objCliente.DIRECCION
        cbFormaPago.EditValue = objCliente.COD_FORMA_PAGO
        cbDepartamentos.EditValue = objCliente.DEPARTAMENTO
        Combo(cbMunicipios, Muni.List(objCliente.DEPARTAMENTO))
        cbMunicipios.EditValue = objCliente.MUNICIPIO
        txtCiudad.Text = objCliente.CIUDAD
        cbZona.EditValue = objCliente.COD_ZONA
        cbCatalogo.EditValue = objCliente.CUENTA
        cbVendedor.EditValue = objCliente.VENDEDOR
        txtObservaciones.Text = objCliente.Comentarios
        Cod_Cuenta = objCliente.CUENTA
        '
        chkLimite.Checked = IIf(objCliente.ValidarLimite = 1, True, False)
        cbCategoria.EditValue = objCliente.Categoria
        cbClasificacion.EditValue = objCliente.Clasificacion
        cmbmoneda.EditValue = objCliente.Moneda
        txtLimiteCredito.EditValue = objCliente.LIMITE_CREDITO
        '
        chkActivo.Checked = IIf(objCliente.ACTIVO = 1, True, False)
        chkAgro.Checked = IIf(objCliente.AgroServicio = 1, True, False)
        chkGarantia.Checked = IIf(objCliente.Garantia = 1, True, False)
        chkEmpl.Checked = IIf(objCliente.Empleado = 1, True, False)
        chkRetenedor.Checked = IIf(objCliente.Retenedor = 1, True, False)
        chkExcento.Checked = IIf(objCliente.Excento = 1, True, False)
        chkRetenedorAlcaldia.Checked = IIf(objCliente.Retenedor_Alcaldia = 1, True, False)

        txtContacto.Text = objCliente.CONTACTO
        txtCargoContacto.Text = objCliente.CARGO
        txtTelefonoContacto.Text = objCliente.TELEFONO_CONTACTO
        txtCelularContacto.Text = objCliente.CELULAR_CONTACTO
        txtCedulaContacto.Text = objCliente.CEDULA_GONTACTO
        txtEmailContacto.Text = objCliente.EMAIL_CONTACTO

        txtNombreRepresentante.Text = objCliente.REPRESENTANTE
        txtTelefonoRepresentante.Text = objCliente.TELEFONO_REPRESENTANTE
        txCelularRepresentante.Text = objCliente.CELULAR_REPRESENTANTE
        txtCedulaRepresentante.Text = objCliente.CEDULA_REPRESENTANTE
        txtCorreoRepresentante.Text = objCliente.EMAIL_REPRESENTANTE

        txtNombreGerente.Text = objCliente.GERENTE
        txtTelefonoGerente.Text = objCliente.TELEFONO_GERENTE
        txtCelularGerente.Text = objCliente.CELULAR_GERENTE
        txCedulaGerente.Text = objCliente.CEDULA_GERENTE
        txtEmailGerente.Text = objCliente.EMAIL_GERENTE

        txtContador.Text = objCliente.CONTADOR
        txtTelefonoContador.Text = objCliente.TELEFONO_CONTADOR
        txtCelularContador.Text = objCliente.CELULAR_CONTADOR
        txCedulaContador.Text = objCliente.CEDULA_CONTADOR
        txtEmailContador.Text = objCliente.EMAIL_CONTADOR
    End Sub

    Sub CargarCombos()

        Dim z As New VB.SysContab.ZonasDB()
        Dim v As New VB.SysContab.VendedoresDB()
        Dim f As New VB.SysContab.Forma_PagoDB()

        Combo(cbDepartamentos, VB.SysContab.DepartamentosCDB.List())
        cbDepartamentos.ItemIndex = 0

        Combo(cbZona, z.GetListBuscarCombo())
        cbZona.ItemIndex = 0

        SearchLookUp(cbVendedor, v.GetListBuscarCombo("%"), "Nombre", "Codigo", 0, 2, 7, 8, 9)

        Combo(cbFormaPago, f.GetList(0))
        cbFormaPago.ItemIndex = 0

        SearchLookUp(cbCatalogo, ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual), "Display", "Cuenta", 2)

        Combo(cbPais, VB.SysContab.PaisesDB.GetList(True))
        cbPais.ItemIndex = 0

        Combo(cbTipoCliente, ObtieneDatos("sp_sel_CR_TipoClienteFill", 0))
        cbTipoCliente.ItemIndex = 0

        Combo(cbClasificacion, ObtieneDatos("sp_sel_Clientes_ClasificacionFill", 1))
        cbClasificacion.ItemIndex = 0

        GetMonedasList(cmbmoneda)
        cmbmoneda.EditValue = MonedaBase

        LookUp(cbCategoria,
               ObtieneDatos("JAR_GetClientesCategoria", EmpresaActual),
               "Nombre",
               "IdCategoria",
               "[Categoria de Cliente]", 0)
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        If cbTipoCliente.EditValue = 1 Then
            If txtRuc.Text.Trim.Length = 0 Then
                XtraMsg("Ingrese el Numero RUC del Cliente",
                        MessageBoxIcon.Warning)
                txtRuc.Focus()
                Exit Sub
            End If
        ElseIf cbTipoCliente.EditValue = 2 Then
            If Cedula.Text.Trim.Length = 0 Then
                XtraMsg("Ingrese el Numero de Cédula del Cliente",
                        MessageBoxIcon.Warning)
                Cedula.Focus()
                Exit Sub
            End If
        End If

        objCliente.CODIGO = IIf(Cliente = 0, ClienteDB.GetCodigo(EmpresaActual), txtCodigo.Text)
        objCliente.NOMBRE = txtNombre.Text.Trim
        objCliente.CONTACTO = txtContacto.Text.Trim
        objCliente.CARGO = txtCargoContacto.Text.Trim
        objCliente.TELEFONO_CONTACTO = txtTelefonoContacto.EditValue.Trim
        objCliente.CELULAR_CONTACTO = txtCelularContacto.EditValue.Trim
        objCliente.EMAIL_CONTACTO = txtEmailContacto.Text.Trim
        objCliente.GERENTE = txtNombreGerente.Text.Trim
        objCliente.TELEFONO_GERENTE = txtTelefonoGerente.EditValue.Trim
        objCliente.CELULAR_GERENTE = txtCelularGerente.EditValue.Trim
        objCliente.EMAIL_GERENTE = txtEmailGerente.Text.Trim
        objCliente.CONTADOR = txtContador.Text.Trim
        objCliente.TELEFONO_CONTADOR = txtTelefonoContador.EditValue.Trim
        objCliente.CELULAR_CONTADOR = txtCelularContador.EditValue.Trim
        objCliente.EMAIL_CONTADOR = txtEmailContador.Text.Trim
        objCliente.DIRECCION = txtDireccion.Text.Trim
        objCliente.Pais_Id = cbPais.EditValue
        objCliente.DEPARTAMENTO = cbDepartamentos.EditValue
        objCliente.MUNICIPIO = cbMunicipios.EditValue
        objCliente.CIUDAD = txtCiudad.Text.Trim
        objCliente.TELEFONO = txtTelefono.EditValue.Trim
        objCliente.FAX = String.Empty
        objCliente.CORREO = txtCorreo.Text.Trim
        objCliente.RUC = txtRuc.Text.Trim
        objCliente.TIPO = 0
        objCliente.COD_ZONA = cbZona.EditValue
        objCliente.COD_FORMA_PAGO = cbFormaPago.EditValue
        objCliente.DESC_PROD = "P"
        objCliente.DESC_SERV = "P"
        objCliente.Moneda = cmbmoneda.EditValue
        objCliente.DESC_ADICIONAL = 0
        objCliente.LIMITE_CREDITO = txtLimiteCredito.EditValue
        objCliente.VENDEDOR = cbVendedor.EditValue
        objCliente.CUENTA = cbCatalogo.EditValue
        objCliente.Excento = IIf(chkExcento.Checked, 1, 0)
        objCliente.TipoCliente = cbTipoCliente.EditValue
        objCliente.Retenedor = IIf(chkRetenedor.Checked, 1, 0)
        objCliente.Fecha_Creacion = Now.Date
        objCliente.EMPRESA = EmpresaActual
        objCliente.TipoIVA_ID = 0
        objCliente.Retenedor_Alcaldia = IIf(chkRetenedorAlcaldia.Checked, 1, 0)
        objCliente.Cedula = Cedula.Text.Trim    'IIf(Cedula Is Nothing, "", Cedula.EditValue.Trim)
        objCliente.CodigoLetra = txtCodigoLetra.Text.Trim
        objCliente.Empleado = IIf(chkEmpl.Checked, 1, 0)
        objCliente.Garantia = IIf(chkGarantia.Checked, 1, 0)
        objCliente.CodConsecutPorcentaje = 0
        objCliente.Categoria = cbCategoria.EditValue
        objCliente.ValidarLimite = IIf(chkLimite.Checked, 1, 0)
        objCliente.SucursalCliente = String.Empty
        objCliente.Comentarios = txtObservaciones.Text.Trim
        objCliente.Registro = Now.Date
        objCliente.Usuario = Login
        objCliente.ACTIVO = IIf(chkActivo.Checked, 1, 0)
        objCliente.AgroServicio = IIf(chkAgro.Checked, 1, 0)
        objCliente.Nombre_Comercial = tNombreComercial.Text.Trim
        objCliente.CELULAR = txtCelular.EditValue.Trim
        objCliente.Clasificacion = cbClasificacion.EditValue
        objCliente.CEDULA_GERENTE = txCedulaGerente.Text.Trim
        objCliente.CEDULA_GONTACTO = txtCedulaContacto.Text.Trim
        objCliente.CEDULA_CONTADOR = txCedulaContador.Text.Trim
        objCliente.REPRESENTANTE = txtNombreRepresentante.Text.Trim
        objCliente.CEDULA_REPRESENTANTE = txtCedulaRepresentante.Text.Trim
        objCliente.EMAIL_REPRESENTANTE = txtCorreoRepresentante.Text.Trim
        objCliente.TELEFONO_REPRESENTANTE = txtTelefonoRepresentante.EditValue.Trim
        objCliente.CELULAR_REPRESENTANTE = txCelularRepresentante.EditValue.Trim
        '
        If Cliente = 0 Then
            If ClienteDB.Insertar(objCliente) Then
                If XtraMsg2("El cliente se ha registrado correctamente, " & vbCrLf &
                           "Desea registrar otro Cliente ?") Then
                    NuevoCliente()
                Else
                    Close()
                    Dim frm As frmClientes = frmClientes.Instance()
                    frm.Cargar()
                End If
            End If
        Else
            If ClienteDB.Actualizar(objCliente) Then
                Close()
                Dim frm As frmClientes = frmClientes.Instance()
                frm.Cargar()
            End If
        End If

        'Dim s = txtTelefono.Text
        'Dim st = txtTelefono.EditValue

        'Dim Excento As Integer = IIf(chkExcento.Checked, 1, 0)
        'Dim Retenedor As Integer = IIf(chkRetenedor.Checked, 1, 0)

        'If Nuevo = "SI" Then
        '    If txtCodigoLetra.Text.Trim.Length > 0 Then
        '        If ObtieneDatos("JAR_BuscarCodigoLetra '" & txtCodigoLetra.Text & "',1," & EmpresaActual).Rows.Count > 0 Then
        '            XtraMsg("El Código Ya Existe!", MessageBoxIcon.Error)
        '            txtCodigoLetra.SelectAll()
        '            txtCodigoLetra.Focus()
        '            Exit Sub
        '        End If
        '    End If

        '    'Me.txtCodigo.Text = clientes.GenerarCodigo().Tables("Clientes").Rows(0).Item("Codigo") + 1
        '    If clientes.GenerarCodigo().Tables("Clientes").Rows.Count <> 0 Then
        '        Me.txtCodigo.Text = clientes.GenerarCodigo().Tables("Clientes").Rows(0).Item("Codigo") + 1
        '    Else
        '        Me.txtCodigo.Text = "1"
        '    End If

        '    cliente.AddItem(txtCodigo.Text, txtNombre.Text, txtContacto.Text, txtCargoContacto.Text,
        '        txtTelefonoContacto.Text, txtCelularContacto.Text, txtEmailContacto.Text, txtGerente.Text,
        '        txtTelefonoGerente.Text, txtCelularGerente.Text, txtEmailGerente.Text, txtContador.Text,
        '        txtTelefonoContador.Text, txtCelularContador.Text, txtEmailContador.Text, txtDireccion.Text,
        '        cbDepartamentos.EditValue, IIf(cbMunicipios.EditValue Is Nothing, 0, cbMunicipios.EditValue), txtCiudad.Text, txtTelefono.Text,
        '        txtFax.Text, txtCorreo.Text, txtRuc.Text, Me.cbZona.EditValue, cbFormaPago.EditValue,
        '        "A", "A", 0.00, txtLimiteCredito.EditValue, cbVendedor.EditValue,
        '        IsNull(Me.cbCatalogo.EditValue, ""), Excento, Me.cbTipoCliente.EditValue, Retenedor,
        '        Me.cbPais.EditValue, Me.chkRetenedorAlcaldia.Checked, Cedula.Text, Me.txtCodigoLetra.Text,
        '        Me.chkEmpl.Checked, IIf(Me.chkGarantia.Checked, 1, 0), cmbmoneda.EditValue, IIf(Me.chkLimite.Checked, 1, 0),
        '        IIf(cbCategoria.EditValue Is Nothing, 0, cbCategoria.EditValue), txtObservaciones.Text, IIf(Me.chkActivo.Checked, 1, 0),
        '        IIf(Me.chkAgro.Checked, 1, 0), tNombreComercial.Text)
        '    'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)

        '    XtraMsg("El cliente se ha registrado correctamente!")

        '    NuevoCliente()

        '    If clientes.GenerarCodigo().Tables("Clientes").Rows.Count <> 0 Then
        '        Me.txtCodigo.Text = clientes.GenerarCodigo().Tables("Clientes").Rows(0).Item("Codigo") + 1
        '    Else
        '        Me.txtCodigo.Text = "1"
        '    End If

        '    txtNombre.Focus()
        'Else
        '    cliente.Update(txtCodigo.Text, txtNombre.Text, txtContacto.Text, txtCargoContacto.Text,
        '        txtTelefonoContacto.Text, txtCelularContacto.Text, txtEmailContacto.Text, txtGerente.Text,
        '        txtTelefonoGerente.Text, txtCelularGerente.Text, txtEmailGerente.Text, txtContador.Text,
        '        txtTelefonoContador.Text, txtCelularContador.Text, txtEmailContador.Text, txtDireccion.Text,
        '        cbDepartamentos.EditValue, IIf(cbMunicipios.EditValue Is Nothing, 0, cbMunicipios.EditValue), txtCiudad.Text, txtTelefono.Text,
        '        txtFax.Text, txtCorreo.Text, txtRuc.Text, Me.cbZona.EditValue, cbFormaPago.EditValue,
        '        "A", "A", 0.00, txtLimiteCredito.EditValue, cbVendedor.EditValue,
        '        Me.cbCatalogo.EditValue, Excento, Me.cbTipoCliente.EditValue, Retenedor,
        '        Me.cbPais.EditValue, Me.chkRetenedorAlcaldia.Checked, Cedula.Text, Me.txtCodigoLetra.Text,
        '        Me.chkEmpl.Checked, IIf(Me.chkGarantia.Checked, 1, 0), cmbmoneda.EditValue, IIf(Me.chkLimite.Checked, 1, 0),
        '        IIf(cbCategoria.EditValue Is Nothing, 0, cbCategoria.EditValue), txtObservaciones.Text, IIf(Me.chkActivo.Checked, 1, 0),
        '        IIf(Me.chkAgro.Checked, 1, 0), tNombreComercial.Text)
        '    'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
        '    Me.Close()
        'End If

    End Sub

    Private Sub NuevoCliente()

        For Each c As Object In LayoutControl4.Controls
            If TypeOf c Is DevExpress.XtraEditors.TextEdit Or
                TypeOf c Is DevExpress.XtraEditors.MemoEdit Then
                c.Text = vbNullString
            End If
        Next
        '
        chkLimite.Checked = False
        chkActivo.Checked = True
        chkAgro.Checked = False

        cbZona.ItemIndex = 0
        cbClasificacion.ItemIndex = 0
        cbDepartamentos.ItemIndex = 0
        cbCatalogo.EditValue = Nothing
        cbVendedor.EditValue = Nothing
        txtLimiteCredito.EditValue = 0.00
        Cliente = 0
        Nombre = String.Empty
        txtCodigo.Text = ClienteDB.GetCodigo(EmpresaActual)
        MascaraTelefonos()

        txtCodigoLetra.Focus()

        'txtCodigoLetra.Text = vbNullString
        '        txtNombre.Text = vbNullString
        '        cbTipoCliente.Text = vbNullString
        '        txtRuc.Text = vbNullString
        '        txtDireccion.Text = vbNullString
        '        txtCelularContacto.Text = vbNullString
        '        txtCelularContador.Text = vbNullString
        '        txtCargoContacto.Text = vbNullString
        '        txtCelularGerente.Text = vbNullString
        '        txtCiudad.Text = vbNullString
        '        txtContacto.Text = vbNullString
        '        txtContador.Text = vbNullString
        '        txtCorreo.Text = vbNullString
        '        txtEmailContacto.Text = vbNullString
        '        txtEmailContador.Text = vbNullString
        '        txtEmailGerente.Text = vbNullString
        '        txtFax.Text = vbNullString
        '        txtNombreGerente.Text = vbNullString
        '        txtLimiteCredito.EditValue = 0.0
        '        txtTelefono.Text = vbNullString
        '        txtTelefonoContacto.Text = vbNullString
        '        txtTelefonoContador.Text = vbNullString
        '        txtTelefonoGerente.Text = vbNullString
        '        cbCatalogo.Text = vbNullString
        '        cbDepartamentos.Text = vbNullString
        '        cbFormaPago.Text = vbNullString
        '        cbMunicipios.Text = vbNullString
        '        cbVendedor.Text = vbNullString
        '        cbZona.Text = vbNullString
        '        chkEmpl.Checked = False
        '        chkLimite.Checked = False

        '        Cliente = 0
        '        Nombre = String.Empty
        '        txtCodigo.Text = ClienteDB.GetCodigo(EmpresaActual)

        '        txtCodigoLetra.Focus()
    End Sub

    'Private Sub frmAgregarCliente_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    '    Dim r As New VB.SysContab.Rutinas()
    '    Dim clientes As New VB.SysContab.ClientesDB()
    '    Dim c As frmClientes = c.Instance
    '    Dim Tabla As New DataTable()
    '    Dim ds As New DataSet()

    '    ds = clientes.GetList()
    '    c.dgClientes.DataSource = clientes.GetList().Tables("Clientes").DefaultView
    '    Tabla = ds.Tables("Clientes")

    '    r.FormatGenerico(c.dgClientes, Tabla)

    '    If ds.Tables("Clientes").Rows.Count <> 0 Then
    '        Registro = c.dgClientes.Item(0, 0)

    '    End If

    'End Sub

    'Private Sub txtDescAdicional_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Trim(txtDescAdicional.Text) <> "" Then
    '        If IsNumeric(txtDescAdicional.Text) Then
    '            '
    '        Else
    '            MsgBox("Por favor ingrese un valor numérico", MsgBoxStyle.Information)
    '            txtDescAdicional.Focus()
    '            txtDescAdicional.SelectAll()
    '            Exit Sub

    '        End If

    '    End If
    'End Sub

    Private Sub cbZona_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '    Dim z As New VB.SysContab.ZonasDB()

        '    If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
        '        If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
        '            zona = ""
        '            cbZona.SelectAll()
        '            Exit Sub

        '        End If

        '        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
        '            Exit Sub

        '        End If
        '    End If

        '    If cbZona.Text = "" Then
        '        zona = ""
        '        Exit Sub
        '    End If

        '    If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
        '        If zona.Length = 1 Then
        '            zona = ""
        '        End If

        '        If zona.Length > 1 Then
        '            zona = Mid(zona, 1, zona.Length - 1)
        '        End If

        '        If cbZona.Text = "" Then
        '            zona = ""
        '            Exit Sub

        '        End If

        '    Else
        '        zona = zona & e.KeyChar

        '    End If

        '    If z.GetListBuscarCombo(zona).Tables("ZONAS").Rows.Count = 0 Then
        '        '

        '    Else
        '        cbZona.SelectedValue = z.GetListBuscarCombo(zona).Tables("ZONAS").Rows(0).Item("CODIGO")
        '        cbZona.SelectionStart = zona.Length
        '        cbZona.Select(zona.Length, cbZona.Text.Length)

        '    End If

        'End Sub

        'Private Sub cbZona_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbZona.Leave
        '    Dim z As New VB.SysContab.ZonasDB()

        '    If Trim(cbZona.Text) = "" Then
        '        zona = ""
        '        Exit Sub
        '    End If

        '    If z.GetListBuscarCombo(cbZona.Text).Tables("Zonas").Rows.Count = 0 Then
        '        MsgBox("Zona no Existe", MsgBoxStyle.Information)
        '        zona = ""
        '        cbZona.Focus()
        '        Exit Sub

        '    End If

        '    'cbZona.SelectedValue = z.GetListBuscarCombo(cbZona.Text).Tables("ZONAS").Rows(0).Item("CODIGO")
        '    Cod_Zona = z.GetListBuscarCombo(cbZona.Text).Tables("Zonas").Rows(0).Item("CODIGO")

        '    zona = ""

    End Sub

    Private Sub cbZona_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'zona = ""
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
            txtNombre.Text = Nombre
            txtNombre.SelectAll()
        End If
    End Sub

    'Private Sub cbVendedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    Dim v As New VB.SysContab.VendedoresDB

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
    '        If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
    '            vendedor = ""
    '            cbVendedor.SelectAll()
    '            Exit Sub

    '        End If

    '        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '            Exit Sub

    '        End If
    '    End If

    '    If cbVendedor.Text = "" Then
    '        vendedor = ""
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
    '        If vendedor.Length = 1 Then
    '            vendedor = ""
    '        End If

    '        If vendedor.Length > 1 Then
    '            vendedor = Mid(vendedor, 1, vendedor.Length - 1)
    '        End If

    '        If cbVendedor.Text = "" Then
    '            vendedor = ""
    '            Exit Sub

    '        End If

    '    Else
    '        vendedor = vendedor & e.KeyChar

    '    End If

    '    If v.GetListBuscarCombo(vendedor).Rows.Count = 0 Then
    '        '
    '    Else
    '        cbVendedor.SelectedValue = v.GetListBuscarCombo(vendedor).Rows(0).Item("CODIGO")
    '        cbVendedor.SelectionStart = vendedor.Length
    '        cbVendedor.Select(vendedor.Length, cbVendedor.Text.Length)

    '    End If

    'End Sub

    Private Sub cbVendedor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim v As New VB.SysContab.VendedoresDB

        If Trim(cbVendedor.Text) = "" Then
            vendedor = ""
            Exit Sub
        End If

        If v.GetListBuscarCombo(cbVendedor.Text).Rows.Count = 0 Then
            MsgBox("Vendedor no Existe", MsgBoxStyle.Information)
            vendedor = ""
            cbVendedor.Focus()
            Exit Sub

        End If

        'cbVendedor.SelectedValue = v.GetListBuscarCombo(cbVendedor.Text).Tables("VENDEDORES").Rows(0).Item("CODIGO")
        'cbVendedor.Refresh()
        Cod_Vendedor = v.GetListBuscarCombo(cbVendedor.Text).Rows(0).Item("CODIGO")

        vendedor = ""

    End Sub

    Private Sub cbVendedor_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        vendedor = ""

    End Sub

    'Private Sub frmAgregarCliente_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    '    If AgregarClienteQuick = True Then
    '        Exit Sub
    '    End If

    '    Dim c As frmClientes = frmClientes.Instance
    '    c.Cargar()

    'End Sub

    'Private Sub cbCatalogo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCatalogo.KeyPress
    '    Dim C As New VB.SysContab.CatalogoDB()
    '    If e.KeyChar = "'" Then
    '        e.Handled = True
    '        Exit Sub

    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) < 32 Then
    '        If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
    '            cuenta = ""
    '            cbCatalogo.SelectAll()
    '            Exit Sub

    '        End If

    '        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '            Exit Sub

    '        End If
    '    End If

    '    If cbCatalogo.Text = "" Then
    '        cuenta = ""
    '        Exit Sub

    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) = 8 Then
    '        If cuenta.Length = 1 Then
    '            cuenta = ""
    '        End If

    '        If cuenta.Length > 1 Then
    '            cuenta = Mid(cuenta, 1, cuenta.Length - 1)

    '        End If

    '        If cbCatalogo.Text = "" Then
    '            cuenta = ""
    '            Exit Sub

    '        End If

    '    Else
    '        cuenta = cuenta & e.KeyChar

    '    End If

    '    If C.GetListBuscarCombo(cuenta, EmpresaActual).Tables("CATALOGO").Rows.Count = 0 Then
    '        '
    '    Else
    '        cbCatalogo.SelectedValue = C.GetListBuscarCombo(cuenta, EmpresaActual).Tables("CATALOGO").Rows(0).Item("CUENTA")
    '        e.Handled = True
    '        cbCatalogo.SelectionStart = cuenta.Length
    '        cbCatalogo.Select(cuenta.Length, cbCatalogo.Text.Length)

    '    End If

    'End Sub

    Private Sub cbCatalogo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Me.cbCatalogo.SelectedValue = Nothing Then
        '    MsgBox("Seleccione una cuenta", MsgBoxStyle.Information)
        '    Me.cbCatalogo.Focus()
        '    Exit Sub
        'End If
    End Sub

    Private Sub cbCatalogo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cuenta = ""
    End Sub

    Private Sub cmdAcumulado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcumulado.Click
        Dim f As frmAcumulados = frmAcumulados.Instance()

        TipoAcumulado = "C"

        RegistroCliente = txtCodigo.Text

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    'Private Sub cbDepartamentos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.etInicio.Text = "1" Then
    '        Exit Sub
    '    End If

    '    Dim Muni As New VB.SysContab.MunicipiosDB

    '    If IsNumeric(cbDepartamentos.SelectedValue) Then
    '        cbMunicipios.DataSource = Muni.List(cbDepartamentos.SelectedValue.ToString).Tables("Municipios")
    '        cbMunicipios.ValueMember = "Codigo"
    '        cbMunicipios.DisplayMember = "Nombre"

    '        'If Nuevo = "NO" Then
    '        '    cbMunicipios.SelectedValue = Detalles.Municipio

    '        'End If

    '    End If
    'End Sub

    Private Sub cmdEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEstadoCuenta.Click
        RegistroCliente = Me.txtCodigo.Text
        AgregarClienteQuick = False
        '
        Dim frm As frmEstadoCuenta = frmEstadoCuenta.Instance()
        frm.Dispose()
        '
        Dim f As frmEstadoCuenta = frmEstadoCuenta.Instance()
        f.MdiParent = Me.MdiParent
        f.Text = "Estado de Cuenta"
        f.lblTitulo.Text = ""
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdDevoluciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDevoluciones.Click
        Dim f As frmDevolucionesClienteList = f.Instance
        Me.etInicio.Text = "1"
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdNotasDebitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNotasDebitos.Click
        Dim f As frmNotasDebitoCliente = f.Instance
        Me.etInicio.Text = "1"
        f.etInicio.Text = "1"
        f.etClienteCodigo.Text = txtCodigo.Text

        f.MdiParent = Me.MdiParent
        f.Show()
        f.etInicio.Text = "0"
    End Sub

    Private Sub cbCategoria_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbCategoria.ButtonClick
        If e.Button.Index = 3 Then  'Registrar Nuevo Movimeinto
            With frmClienteCategoria
                .Text = "Crear Categoria de Cliente"
                .lyCodigo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                .txtCodigo.EditValue = 0
                .ShowDialog()
                If .Ok = "SI" Then
                    LookUp(cbCategoria, ObtieneDatos("JAR_GetClientesCategoria", EmpresaActual), "Nombre", "IdCategoria", "[Categoria de Cliente]", 0)
                    'GetClientesCategorias(cbCategoria)
                End If
                .Dispose()
            End With

        ElseIf e.Button.Index = 2 Then  'Actualizar Datos
            If cbCategoria.EditValue Is Nothing Or cbCategoria.EditValue = 0 Then
                XtraMsg("Seleccione el Registro que desea Editar")
                Exit Sub
            End If

            With frmClienteCategoria
                .Text = "Editar Categoria de Cliente"
                .lyCodigo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                .txtCodigo.EditValue = cbCategoria.EditValue
                .txtNombre.Text = cbCategoria.Text
                .ShowDialog()
                If .Ok = "SI" Then
                    LookUp(cbCategoria, ObtieneDatos("JAR_GetClientesCategoria", EmpresaActual), "Nombre", "IdCategoria", "[Categoria de Cliente]", 0)
                    'GetClientesCategorias(cbCategoria)
                End If
                .Dispose()
            End With
        ElseIf e.Button.Index = 1 Then  'Borrar Datos
            If cbCategoria.EditValue Is Nothing Or cbCategoria.EditValue = 0 Then
                XtraMsg("Seleccione el Registro que desea Borrar")
                Exit Sub
            End If
            '
            Dim DTC As DataTable = ObtieneDatos("SELECT c.CODIGO FROM CLIENTES c WHERE c.EMPRESA = " & EmpresaActual & " AND  c.Categoria  = " & cbCategoria.EditValue)

            If DTC.Rows.Count > 0 Then
                XtraMsg("La Categoria que intentar Borrar ya se encuentra asignada a : " & DTC.Rows.Count.ToString & " Clientes", MessageBoxIcon.Error)
                Exit Sub
            Else
                If GuardaDatos("DELETE FROM Clientes_Categorias WHERE IdCategoria = " & cbCategoria.EditValue) Then
                    LookUp(cbCategoria, ObtieneDatos("JAR_GetClientesCategoria", EmpresaActual), "Nombre", "IdCategoria", "[Categoria de Cliente]", 0)
                    'GetClientesCategorias(cbCategoria)
                End If
            End If
        End If
    End Sub

    'Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
    '    SavedImage("CLIENTES", txtCodigo.Text)
    '    CargarDocumentos()
    'End Sub

    'Sub CargarDocumentos()
    '    'Cargar Documentos Digitalizados
    '    GridControl1.DataSource = VB.SysContab.ClientesDB.GetImages("CLIENTES", txtCodigo.Text)
    '    GridView1.Columns("Codigo").Visible = False
    'End Sub

    'Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
    '    If GridView1.FocusedRowHandle < 0 Then
    '        XtraMsg("Seleccione un Documento!")
    '        Exit Sub
    '    End If

    '    frmSoporteAdd.ID = GridView1.GetFocusedRowCellValue("Codigo")
    '    frmSoporteAdd.StartPosition = FormStartPosition.CenterParent
    '    frmSoporteAdd.ShowDialog()
    '    frmSoporteAdd.Dispose()
    'End Sub

    Private Sub txtDescAdicional_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub btnBorrar_Click(sender As Object, e As EventArgs)
    '    If GridView1.FocusedRowHandle < 0 Then
    '        XtraMsg("Seleccione un Documento!")
    '        Exit Sub
    '    End If

    '    If XtraMsg2("Esta Seguro de Borrar el Documento Seleccionado?") Then
    '        VB.SysContab.ClientesDB.DeleteImage(GridView1.GetFocusedRowCellValue("Codigo"))
    '        CargarDocumentos()
    '    End If
    'End Sub

    'Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
    '    frmExportarImprimir.Mostrar(GridControl1, "Documentos Digitalizados del Cliente: " & txtNombre.Text)
    'End Sub

    Private Sub cbDepartamentos_EditValueChanged(sender As Object, e As EventArgs) Handles cbDepartamentos.EditValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If

        Dim Muni As New VB.SysContab.MunicipiosDB
        Combo(cbMunicipios, Muni.List(cbDepartamentos.EditValue))

        ' If IsNumeric(cbDepartamentos.SelectedValue) Then
        'cbMunicipios.DataSource = Muni.List(cbDepartamentos.SelectedValue.ToString).Tables("Municipios")
        'cbMunicipios.ValueMember = "Codigo"
        'cbMunicipios.DisplayMember = "Nombre"

        'If Nuevo = "NO" Then
        '    cbMunicipios.SelectedValue = Detalles.Municipio
        'End If
        '  End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If Nuevo = "SI" Then
            XtraMsg("Debe Guardar Primero el Cliente...")
            Exit Sub
        End If
        '
        With frmDocumentos
            .Tipo = "CLIENTES"
            .Codigo = txtCodigo.Text
            .NDocumento = txtNombre.Text
            .Text = "Soporte Digital del Cliente: " & txtNombre.Text
            .txtNombre.Text = txtNombre.Text
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub cbPais_EditValueChanged(sender As Object, e As EventArgs) Handles cbPais.EditValueChanged
        If Me.etInicio.Text = "1" Then
            Exit Sub
        End If
        '
        MascaraTelefonos()
        'If Nuevo = "SI" Then MascaraTelefonos()
    End Sub

    Sub MascaraTelefonos()

        If Nuevo.Equals("SI") Then
            txtCelular.Text = cbPais.GetColumnValue("Area")
            txtTelefono.Text = cbPais.GetColumnValue("Area")

            txtTelefonoContacto.Text = cbPais.GetColumnValue("Area")
            txtCelularContacto.Text = cbPais.GetColumnValue("Area")

            txtTelefonoContador.Text = cbPais.GetColumnValue("Area")
            txtCelularContador.Text = cbPais.GetColumnValue("Area")

            txtTelefonoGerente.Text = cbPais.GetColumnValue("Area")
            txtCelularGerente.Text = cbPais.GetColumnValue("Area")

            txtTelefonoRepresentante.Text = cbPais.GetColumnValue("Area")
            txCelularRepresentante.Text = cbPais.GetColumnValue("Area")

        Else
            If txtTelefono.EditValue.ToString().Length = 0 Then txtTelefono.Text = cbPais.GetColumnValue("Area")
            If txtCelular.EditValue.ToString().Length = 0 Then txtCelular.Text = cbPais.GetColumnValue("Area")

            If txtTelefonoContacto.EditValue.ToString().Length = 0 Then txtTelefonoContacto.Text = cbPais.GetColumnValue("Area")
            If txtCelularContacto.EditValue.ToString().Length = 0 Then txtCelularContacto.Text = cbPais.GetColumnValue("Area")

            If txtTelefonoContador.EditValue.ToString().Length = 0 Then txtTelefonoContador.Text = cbPais.GetColumnValue("Area")
            If txtCelularContador.EditValue.ToString().Length = 0 Then txtCelularContador.Text = cbPais.GetColumnValue("Area")

            If txtTelefonoGerente.EditValue.ToString().Length = 0 Then txtTelefonoGerente.Text = cbPais.GetColumnValue("Area")
            If txtCelularGerente.EditValue.ToString().Length = 0 Then txtCelularGerente.Text = cbPais.GetColumnValue("Area")

            If txtTelefonoRepresentante.EditValue.ToString().Length = 0 Then txtTelefonoRepresentante.Text = cbPais.GetColumnValue("Area")
            If txCelularRepresentante.EditValue.ToString().Length = 0 Then txCelularRepresentante.Text = cbPais.GetColumnValue("Area")
        End If
    End Sub

    Private Sub sMascara_Click(sender As Object, e As EventArgs) Handles sMascara.Click
        Cedula.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Cedula.Properties.Mask.EditMask = String.Empty
        Cedula.EditValue = String.Empty
        Cedula.Focus()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        txtCedulaContacto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        txtCedulaContacto.Properties.Mask.EditMask = String.Empty
        txtCedulaContacto.EditValue = String.Empty
        txtCedulaContacto.Focus()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        txCedulaContador.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        txCedulaContador.Properties.Mask.EditMask = String.Empty
        txCedulaContador.EditValue = String.Empty
        txCedulaContador.Focus()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        txtCedulaRepresentante.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        txtCedulaRepresentante.Properties.Mask.EditMask = String.Empty
        txtCedulaRepresentante.EditValue = String.Empty
        txtCedulaRepresentante.Focus()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        txCedulaGerente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        txCedulaGerente.Properties.Mask.EditMask = String.Empty
        txCedulaGerente.EditValue = String.Empty
        txCedulaGerente.Focus()
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        txtTelefono.Properties.Mask.EditMask = String.Empty
        txtTelefono.EditValue = String.Empty
        txtTelefono.Focus()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        txtCelular.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        txtCelular.Properties.Mask.EditMask = String.Empty
        txtCelular.EditValue = String.Empty
        txtCelular.Focus()
    End Sub
End Class
