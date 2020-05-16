Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base

'Imports System.Configuration

Public Class frmAgregarEmpresa
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarEmpresa = Nothing

    Public Shared Function Instance() As frmAgregarEmpresa
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarEmpresa()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function


    Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtContador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCiudad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cbMonedaSalario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents nudAnio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cbMonedaBase As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbBodegas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbGMT As DevExpress.XtraScheduler.UI.TimeZoneEdit
    Friend WithEvents cbRegion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtSCuenta5 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtSCuenta7 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtSCuenta9 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtSCuenta8 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtSCuenta6 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtSCuenta4 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtSCuenta3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtSCuenta2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtSCuenta1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtMayor As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents chkEspacio As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtInatec As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMontoIR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIRVentas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIRServicios As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIRProductos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtLineas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtNoDecimales As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtDevolucionProveedorNumero As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtDevolucionClienteNumero As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtOrdenCompraNumero As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtPedidoNumero As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtCotizacionNumero As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtOrdenVentaInicial As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtReciboNumero As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtRequisaBodegaNumero As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtReciboDigitos As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtFacturaDigitos As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lytxtFacturaDigitos As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPresPorcMin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ckMultiple As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents chkOC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbMes As DevExpress.XtraScheduler.UI.MonthEdit
    Friend WithEvents LayoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblCuenta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkValidar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
    Dim Bodegas As New VB.SysContab.BodegasDB()

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
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtFactNum As System.Windows.Forms.TextBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgSeries As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbPais As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ckLiquidacion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarEmpresa))
        Me.cbPais = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.lblCuenta = New DevExpress.XtraEditors.LabelControl()
        Me.cbMes = New DevExpress.XtraScheduler.UI.MonthEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFactNum = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.dgSeries = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtPresPorcMin = New DevExpress.XtraEditors.TextEdit()
        Me.txtRequisaBodegaNumero = New DevExpress.XtraEditors.SpinEdit()
        Me.chkOC = New DevExpress.XtraEditors.CheckEdit()
        Me.ckMultiple = New DevExpress.XtraEditors.CheckEdit()
        Me.ckLiquidacion = New DevExpress.XtraEditors.CheckEdit()
        Me.txtLineas = New DevExpress.XtraEditors.SpinEdit()
        Me.txtNoDecimales = New DevExpress.XtraEditors.SpinEdit()
        Me.txtDevolucionProveedorNumero = New DevExpress.XtraEditors.SpinEdit()
        Me.txtDevolucionClienteNumero = New DevExpress.XtraEditors.SpinEdit()
        Me.txtOrdenCompraNumero = New DevExpress.XtraEditors.SpinEdit()
        Me.txtPedidoNumero = New DevExpress.XtraEditors.SpinEdit()
        Me.txtCotizacionNumero = New DevExpress.XtraEditors.SpinEdit()
        Me.txtOrdenVentaInicial = New DevExpress.XtraEditors.SpinEdit()
        Me.txtReciboNumero = New DevExpress.XtraEditors.SpinEdit()
        Me.txtReciboDigitos = New DevExpress.XtraEditors.SpinEdit()
        Me.txtFacturaDigitos = New DevExpress.XtraEditors.SpinEdit()
        Me.txtInatec = New DevExpress.XtraEditors.TextEdit()
        Me.txtMontoIR = New DevExpress.XtraEditors.TextEdit()
        Me.txtIRVentas = New DevExpress.XtraEditors.TextEdit()
        Me.txtIRServicios = New DevExpress.XtraEditors.TextEdit()
        Me.txtIRProductos = New DevExpress.XtraEditors.TextEdit()
        Me.txtIva = New DevExpress.XtraEditors.TextEdit()
        Me.chkEspacio = New DevExpress.XtraEditors.CheckEdit()
        Me.txtSCuenta5 = New DevExpress.XtraEditors.SpinEdit()
        Me.txtSCuenta7 = New DevExpress.XtraEditors.SpinEdit()
        Me.txtSCuenta9 = New DevExpress.XtraEditors.SpinEdit()
        Me.txtSCuenta8 = New DevExpress.XtraEditors.SpinEdit()
        Me.txtSCuenta6 = New DevExpress.XtraEditors.SpinEdit()
        Me.txtSCuenta4 = New DevExpress.XtraEditors.SpinEdit()
        Me.txtSCuenta3 = New DevExpress.XtraEditors.SpinEdit()
        Me.txtSCuenta2 = New DevExpress.XtraEditors.SpinEdit()
        Me.txtSCuenta1 = New DevExpress.XtraEditors.SpinEdit()
        Me.txtMayor = New DevExpress.XtraEditors.SpinEdit()
        Me.cbRegion = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbGMT = New DevExpress.XtraScheduler.UI.TimeZoneEdit()
        Me.cbMonedaSalario = New DevExpress.XtraEditors.LookUpEdit()
        Me.nudAnio = New DevExpress.XtraEditors.SpinEdit()
        Me.cbMonedaBase = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbBodegas = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtContador = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.txtCiudad = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lytxtFacturaDigitos = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.chkValidar = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.cbPais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPresPorcMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequisaBodegaNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckMultiple.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckLiquidacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLineas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoDecimales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDevolucionProveedorNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDevolucionClienteNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdenCompraNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPedidoNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCotizacionNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdenVentaInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReciboNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReciboDigitos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacturaDigitos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInatec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoIR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIRVentas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIRServicios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIRProductos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEspacio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSCuenta5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSCuenta7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSCuenta9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSCuenta8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSCuenta6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSCuenta4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSCuenta3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSCuenta2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSCuenta1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMayor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRegion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGMT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMonedaSalario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMonedaBase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBodegas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCiudad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytxtFacturaDigitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkValidar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbPais
        '
        Me.cbPais.Location = New System.Drawing.Point(186, 94)
        Me.cbPais.Name = "cbPais"
        Me.cbPais.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPais.Properties.Appearance.Options.UseFont = True
        Me.cbPais.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbPais.Properties.NullText = ""
        Me.cbPais.Size = New System.Drawing.Size(674, 20)
        Me.cbPais.StyleController = Me.LayoutControl1
        Me.cbPais.TabIndex = 2
        Me.cbPais.Tag = "True"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkValidar)
        Me.LayoutControl1.Controls.Add(Me.lblCuenta)
        Me.LayoutControl1.Controls.Add(Me.cbMes)
        Me.LayoutControl1.Controls.Add(Me.Panel1)
        Me.LayoutControl1.Controls.Add(Me.txtPresPorcMin)
        Me.LayoutControl1.Controls.Add(Me.txtRequisaBodegaNumero)
        Me.LayoutControl1.Controls.Add(Me.chkOC)
        Me.LayoutControl1.Controls.Add(Me.ckMultiple)
        Me.LayoutControl1.Controls.Add(Me.ckLiquidacion)
        Me.LayoutControl1.Controls.Add(Me.txtLineas)
        Me.LayoutControl1.Controls.Add(Me.txtNoDecimales)
        Me.LayoutControl1.Controls.Add(Me.txtDevolucionProveedorNumero)
        Me.LayoutControl1.Controls.Add(Me.txtDevolucionClienteNumero)
        Me.LayoutControl1.Controls.Add(Me.txtOrdenCompraNumero)
        Me.LayoutControl1.Controls.Add(Me.txtPedidoNumero)
        Me.LayoutControl1.Controls.Add(Me.txtCotizacionNumero)
        Me.LayoutControl1.Controls.Add(Me.txtOrdenVentaInicial)
        Me.LayoutControl1.Controls.Add(Me.txtReciboNumero)
        Me.LayoutControl1.Controls.Add(Me.txtReciboDigitos)
        Me.LayoutControl1.Controls.Add(Me.txtFacturaDigitos)
        Me.LayoutControl1.Controls.Add(Me.txtInatec)
        Me.LayoutControl1.Controls.Add(Me.txtMontoIR)
        Me.LayoutControl1.Controls.Add(Me.txtIRVentas)
        Me.LayoutControl1.Controls.Add(Me.txtIRServicios)
        Me.LayoutControl1.Controls.Add(Me.txtIRProductos)
        Me.LayoutControl1.Controls.Add(Me.txtIva)
        Me.LayoutControl1.Controls.Add(Me.chkEspacio)
        Me.LayoutControl1.Controls.Add(Me.txtSCuenta5)
        Me.LayoutControl1.Controls.Add(Me.txtSCuenta7)
        Me.LayoutControl1.Controls.Add(Me.txtSCuenta9)
        Me.LayoutControl1.Controls.Add(Me.txtSCuenta8)
        Me.LayoutControl1.Controls.Add(Me.txtSCuenta6)
        Me.LayoutControl1.Controls.Add(Me.txtSCuenta4)
        Me.LayoutControl1.Controls.Add(Me.txtSCuenta3)
        Me.LayoutControl1.Controls.Add(Me.txtSCuenta2)
        Me.LayoutControl1.Controls.Add(Me.txtSCuenta1)
        Me.LayoutControl1.Controls.Add(Me.txtMayor)
        Me.LayoutControl1.Controls.Add(Me.cbRegion)
        Me.LayoutControl1.Controls.Add(Me.cbGMT)
        Me.LayoutControl1.Controls.Add(Me.cbMonedaSalario)
        Me.LayoutControl1.Controls.Add(Me.nudAnio)
        Me.LayoutControl1.Controls.Add(Me.cbMonedaBase)
        Me.LayoutControl1.Controls.Add(Me.cbBodegas)
        Me.LayoutControl1.Controls.Add(Me.txtContador)
        Me.LayoutControl1.Controls.Add(Me.txtTelefono)
        Me.LayoutControl1.Controls.Add(Me.cbPais)
        Me.LayoutControl1.Controls.Add(Me.txtCiudad)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem45, Me.LayoutControlItem41})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1036, 290, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(884, 561)
        Me.LayoutControl1.TabIndex = 163
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'lblCuenta
        '
        Me.lblCuenta.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCuenta.Appearance.Options.UseFont = True
        Me.lblCuenta.Appearance.Options.UseForeColor = True
        Me.lblCuenta.Appearance.Options.UseTextOptions = True
        Me.lblCuenta.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCuenta.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCuenta.Location = New System.Drawing.Point(36, 409)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(812, 18)
        Me.lblCuenta.StyleController = Me.LayoutControl1
        Me.lblCuenta.TabIndex = 214
        Me.lblCuenta.Text = "Ejemplo Cuenta: 0000 00 00 000"
        '
        'cbMes
        '
        Me.cbMes.Location = New System.Drawing.Point(186, 214)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.Properties.Appearance.Options.UseFont = True
        Me.cbMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMes.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbMes.Size = New System.Drawing.Size(296, 22)
        Me.cbMes.StyleController = Me.LayoutControl1
        Me.cbMes.TabIndex = 213
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtSerie)
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Controls.Add(Me.txtFactNum)
        Me.Panel1.Controls.Add(Me.Label49)
        Me.Panel1.Controls.Add(Me.Label50)
        Me.Panel1.Controls.Add(Me.SimpleButton2)
        Me.Panel1.Controls.Add(Me.GridControl1)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(508, 306)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 178)
        Me.Panel1.TabIndex = 184
        Me.Panel1.Visible = False
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(8, 34)
        Me.txtSerie.MaxLength = 1
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(48, 21)
        Me.txtSerie.TabIndex = 176
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(8, 69)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton1.TabIndex = 179
        Me.SimpleButton1.Text = "Agregar"
        '
        'txtFactNum
        '
        Me.txtFactNum.Location = New System.Drawing.Point(64, 34)
        Me.txtFactNum.Name = "txtFactNum"
        Me.txtFactNum.Size = New System.Drawing.Size(100, 21)
        Me.txtFactNum.TabIndex = 177
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label49.Location = New System.Drawing.Point(8, 17)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(32, 17)
        Me.Label49.TabIndex = 179
        Me.Label49.Text = "Serie"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label50.Location = New System.Drawing.Point(64, 17)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(88, 17)
        Me.Label50.TabIndex = 180
        Me.Label50.Text = "Factura Inicial"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(88, 69)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton2.TabIndex = 181
        Me.SimpleButton2.Text = "Borrar"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(216, 9)
        Me.GridControl1.MainView = Me.dgSeries
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(310, 112)
        Me.GridControl1.TabIndex = 178
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgSeries})
        '
        'dgSeries
        '
        Me.dgSeries.GridControl = Me.GridControl1
        Me.dgSeries.Name = "dgSeries"
        Me.dgSeries.OptionsView.ShowGroupPanel = False
        '
        'txtPresPorcMin
        '
        Me.txtPresPorcMin.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txtPresPorcMin.Location = New System.Drawing.Point(402, 98)
        Me.txtPresPorcMin.Name = "txtPresPorcMin"
        Me.txtPresPorcMin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresPorcMin.Properties.Appearance.Options.UseFont = True
        Me.txtPresPorcMin.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPresPorcMin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPresPorcMin.Properties.Mask.EditMask = "P"
        Me.txtPresPorcMin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPresPorcMin.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPresPorcMin.Size = New System.Drawing.Size(458, 22)
        Me.txtPresPorcMin.StyleController = Me.LayoutControl1
        Me.txtPresPorcMin.TabIndex = 207
        '
        'txtRequisaBodegaNumero
        '
        Me.txtRequisaBodegaNumero.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtRequisaBodegaNumero.Location = New System.Drawing.Point(186, 358)
        Me.txtRequisaBodegaNumero.Name = "txtRequisaBodegaNumero"
        Me.txtRequisaBodegaNumero.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequisaBodegaNumero.Properties.Appearance.Options.UseFont = True
        Me.txtRequisaBodegaNumero.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtRequisaBodegaNumero.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtRequisaBodegaNumero.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtRequisaBodegaNumero.Size = New System.Drawing.Size(318, 22)
        Me.txtRequisaBodegaNumero.StyleController = Me.LayoutControl1
        Me.txtRequisaBodegaNumero.TabIndex = 209
        '
        'chkOC
        '
        Me.chkOC.Location = New System.Drawing.Point(508, 46)
        Me.chkOC.Name = "chkOC"
        Me.chkOC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOC.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkOC.Properties.Appearance.Options.UseFont = True
        Me.chkOC.Properties.Appearance.Options.UseForeColor = True
        Me.chkOC.Properties.Caption = "Orden de Compra Exenta"
        Me.chkOC.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkOC.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkOC.Size = New System.Drawing.Size(352, 22)
        Me.chkOC.StyleController = Me.LayoutControl1
        Me.chkOC.TabIndex = 184
        '
        'ckMultiple
        '
        Me.ckMultiple.Location = New System.Drawing.Point(508, 98)
        Me.ckMultiple.Name = "ckMultiple"
        Me.ckMultiple.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckMultiple.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ckMultiple.Properties.Appearance.Options.UseFont = True
        Me.ckMultiple.Properties.Appearance.Options.UseForeColor = True
        Me.ckMultiple.Properties.Caption = "Facturas MultiSerie"
        Me.ckMultiple.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ckMultiple.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ckMultiple.Size = New System.Drawing.Size(352, 22)
        Me.ckMultiple.StyleController = Me.LayoutControl1
        Me.ckMultiple.TabIndex = 184
        '
        'ckLiquidacion
        '
        Me.ckLiquidacion.Location = New System.Drawing.Point(508, 72)
        Me.ckLiquidacion.Name = "ckLiquidacion"
        Me.ckLiquidacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckLiquidacion.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ckLiquidacion.Properties.Appearance.Options.UseFont = True
        Me.ckLiquidacion.Properties.Appearance.Options.UseForeColor = True
        Me.ckLiquidacion.Properties.Caption = "Utilizar módulo de liquidaciones"
        Me.ckLiquidacion.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ckLiquidacion.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ckLiquidacion.Size = New System.Drawing.Size(352, 22)
        Me.ckLiquidacion.StyleController = Me.LayoutControl1
        Me.ckLiquidacion.TabIndex = 183
        '
        'txtLineas
        '
        Me.txtLineas.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txtLineas.Location = New System.Drawing.Point(186, 488)
        Me.txtLineas.Name = "txtLineas"
        Me.txtLineas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLineas.Properties.Appearance.Options.UseFont = True
        Me.txtLineas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLineas.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtLineas.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtLineas.Size = New System.Drawing.Size(318, 22)
        Me.txtLineas.StyleController = Me.LayoutControl1
        Me.txtLineas.TabIndex = 212
        '
        'txtNoDecimales
        '
        Me.txtNoDecimales.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtNoDecimales.Location = New System.Drawing.Point(186, 462)
        Me.txtNoDecimales.Name = "txtNoDecimales"
        Me.txtNoDecimales.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoDecimales.Properties.Appearance.Options.UseFont = True
        Me.txtNoDecimales.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNoDecimales.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtNoDecimales.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtNoDecimales.Size = New System.Drawing.Size(318, 22)
        Me.txtNoDecimales.StyleController = Me.LayoutControl1
        Me.txtNoDecimales.TabIndex = 211
        '
        'txtDevolucionProveedorNumero
        '
        Me.txtDevolucionProveedorNumero.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtDevolucionProveedorNumero.Location = New System.Drawing.Point(186, 384)
        Me.txtDevolucionProveedorNumero.Name = "txtDevolucionProveedorNumero"
        Me.txtDevolucionProveedorNumero.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDevolucionProveedorNumero.Properties.Appearance.Options.UseFont = True
        Me.txtDevolucionProveedorNumero.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDevolucionProveedorNumero.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtDevolucionProveedorNumero.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtDevolucionProveedorNumero.Size = New System.Drawing.Size(318, 22)
        Me.txtDevolucionProveedorNumero.StyleController = Me.LayoutControl1
        Me.txtDevolucionProveedorNumero.TabIndex = 210
        '
        'txtDevolucionClienteNumero
        '
        Me.txtDevolucionClienteNumero.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtDevolucionClienteNumero.Location = New System.Drawing.Point(186, 410)
        Me.txtDevolucionClienteNumero.Name = "txtDevolucionClienteNumero"
        Me.txtDevolucionClienteNumero.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDevolucionClienteNumero.Properties.Appearance.Options.UseFont = True
        Me.txtDevolucionClienteNumero.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDevolucionClienteNumero.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtDevolucionClienteNumero.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtDevolucionClienteNumero.Size = New System.Drawing.Size(318, 22)
        Me.txtDevolucionClienteNumero.StyleController = Me.LayoutControl1
        Me.txtDevolucionClienteNumero.TabIndex = 210
        '
        'txtOrdenCompraNumero
        '
        Me.txtOrdenCompraNumero.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtOrdenCompraNumero.Location = New System.Drawing.Point(186, 436)
        Me.txtOrdenCompraNumero.Name = "txtOrdenCompraNumero"
        Me.txtOrdenCompraNumero.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenCompraNumero.Properties.Appearance.Options.UseFont = True
        Me.txtOrdenCompraNumero.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOrdenCompraNumero.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtOrdenCompraNumero.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtOrdenCompraNumero.Size = New System.Drawing.Size(318, 22)
        Me.txtOrdenCompraNumero.StyleController = Me.LayoutControl1
        Me.txtOrdenCompraNumero.TabIndex = 210
        '
        'txtPedidoNumero
        '
        Me.txtPedidoNumero.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtPedidoNumero.Location = New System.Drawing.Point(186, 332)
        Me.txtPedidoNumero.Name = "txtPedidoNumero"
        Me.txtPedidoNumero.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoNumero.Properties.Appearance.Options.UseFont = True
        Me.txtPedidoNumero.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPedidoNumero.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtPedidoNumero.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtPedidoNumero.Size = New System.Drawing.Size(318, 22)
        Me.txtPedidoNumero.StyleController = Me.LayoutControl1
        Me.txtPedidoNumero.TabIndex = 210
        '
        'txtCotizacionNumero
        '
        Me.txtCotizacionNumero.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCotizacionNumero.Location = New System.Drawing.Point(186, 306)
        Me.txtCotizacionNumero.Name = "txtCotizacionNumero"
        Me.txtCotizacionNumero.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCotizacionNumero.Properties.Appearance.Options.UseFont = True
        Me.txtCotizacionNumero.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCotizacionNumero.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtCotizacionNumero.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCotizacionNumero.Size = New System.Drawing.Size(318, 22)
        Me.txtCotizacionNumero.StyleController = Me.LayoutControl1
        Me.txtCotizacionNumero.TabIndex = 210
        '
        'txtOrdenVentaInicial
        '
        Me.txtOrdenVentaInicial.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtOrdenVentaInicial.Location = New System.Drawing.Point(186, 280)
        Me.txtOrdenVentaInicial.Name = "txtOrdenVentaInicial"
        Me.txtOrdenVentaInicial.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenVentaInicial.Properties.Appearance.Options.UseFont = True
        Me.txtOrdenVentaInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOrdenVentaInicial.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtOrdenVentaInicial.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtOrdenVentaInicial.Size = New System.Drawing.Size(318, 22)
        Me.txtOrdenVentaInicial.StyleController = Me.LayoutControl1
        Me.txtOrdenVentaInicial.TabIndex = 210
        '
        'txtReciboNumero
        '
        Me.txtReciboNumero.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtReciboNumero.Location = New System.Drawing.Point(186, 254)
        Me.txtReciboNumero.Name = "txtReciboNumero"
        Me.txtReciboNumero.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReciboNumero.Properties.Appearance.Options.UseFont = True
        Me.txtReciboNumero.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtReciboNumero.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtReciboNumero.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtReciboNumero.Size = New System.Drawing.Size(318, 22)
        Me.txtReciboNumero.StyleController = Me.LayoutControl1
        Me.txtReciboNumero.TabIndex = 210
        '
        'txtReciboDigitos
        '
        Me.txtReciboDigitos.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtReciboDigitos.Location = New System.Drawing.Point(186, 228)
        Me.txtReciboDigitos.Name = "txtReciboDigitos"
        Me.txtReciboDigitos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReciboDigitos.Properties.Appearance.Options.UseFont = True
        Me.txtReciboDigitos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtReciboDigitos.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtReciboDigitos.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtReciboDigitos.Size = New System.Drawing.Size(318, 22)
        Me.txtReciboDigitos.StyleController = Me.LayoutControl1
        Me.txtReciboDigitos.TabIndex = 209
        '
        'txtFacturaDigitos
        '
        Me.txtFacturaDigitos.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtFacturaDigitos.Location = New System.Drawing.Point(186, 202)
        Me.txtFacturaDigitos.Name = "txtFacturaDigitos"
        Me.txtFacturaDigitos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacturaDigitos.Properties.Appearance.Options.UseFont = True
        Me.txtFacturaDigitos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFacturaDigitos.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtFacturaDigitos.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtFacturaDigitos.Size = New System.Drawing.Size(318, 22)
        Me.txtFacturaDigitos.StyleController = Me.LayoutControl1
        Me.txtFacturaDigitos.TabIndex = 208
        '
        'txtInatec
        '
        Me.txtInatec.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtInatec.Location = New System.Drawing.Point(186, 176)
        Me.txtInatec.Name = "txtInatec"
        Me.txtInatec.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInatec.Properties.Appearance.Options.UseFont = True
        Me.txtInatec.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInatec.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtInatec.Properties.Mask.EditMask = "P"
        Me.txtInatec.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtInatec.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInatec.Size = New System.Drawing.Size(318, 22)
        Me.txtInatec.StyleController = Me.LayoutControl1
        Me.txtInatec.TabIndex = 206
        '
        'txtMontoIR
        '
        Me.txtMontoIR.EditValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtMontoIR.Location = New System.Drawing.Point(186, 150)
        Me.txtMontoIR.Name = "txtMontoIR"
        Me.txtMontoIR.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoIR.Properties.Appearance.Options.UseFont = True
        Me.txtMontoIR.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMontoIR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMontoIR.Properties.Mask.EditMask = "n2"
        Me.txtMontoIR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoIR.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoIR.Size = New System.Drawing.Size(318, 22)
        Me.txtMontoIR.StyleController = Me.LayoutControl1
        Me.txtMontoIR.TabIndex = 206
        '
        'txtIRVentas
        '
        Me.txtIRVentas.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtIRVentas.Location = New System.Drawing.Point(186, 124)
        Me.txtIRVentas.Name = "txtIRVentas"
        Me.txtIRVentas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRVentas.Properties.Appearance.Options.UseFont = True
        Me.txtIRVentas.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIRVentas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIRVentas.Properties.Mask.EditMask = "P"
        Me.txtIRVentas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIRVentas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtIRVentas.Size = New System.Drawing.Size(318, 22)
        Me.txtIRVentas.StyleController = Me.LayoutControl1
        Me.txtIRVentas.TabIndex = 205
        '
        'txtIRServicios
        '
        Me.txtIRServicios.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txtIRServicios.Location = New System.Drawing.Point(186, 98)
        Me.txtIRServicios.Name = "txtIRServicios"
        Me.txtIRServicios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRServicios.Properties.Appearance.Options.UseFont = True
        Me.txtIRServicios.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIRServicios.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIRServicios.Properties.Mask.EditMask = "P"
        Me.txtIRServicios.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIRServicios.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtIRServicios.Size = New System.Drawing.Size(318, 22)
        Me.txtIRServicios.StyleController = Me.LayoutControl1
        Me.txtIRServicios.TabIndex = 206
        '
        'txtIRProductos
        '
        Me.txtIRProductos.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtIRProductos.Location = New System.Drawing.Point(186, 72)
        Me.txtIRProductos.Name = "txtIRProductos"
        Me.txtIRProductos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRProductos.Properties.Appearance.Options.UseFont = True
        Me.txtIRProductos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIRProductos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIRProductos.Properties.Mask.EditMask = "P"
        Me.txtIRProductos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIRProductos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtIRProductos.Size = New System.Drawing.Size(318, 22)
        Me.txtIRProductos.StyleController = Me.LayoutControl1
        Me.txtIRProductos.TabIndex = 205
        '
        'txtIva
        '
        Me.txtIva.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtIva.Location = New System.Drawing.Point(186, 46)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.Properties.Appearance.Options.UseFont = True
        Me.txtIva.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIva.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIva.Properties.Mask.EditMask = "P"
        Me.txtIva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIva.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtIva.Size = New System.Drawing.Size(318, 22)
        Me.txtIva.StyleController = Me.LayoutControl1
        Me.txtIva.TabIndex = 204
        '
        'chkEspacio
        '
        Me.chkEspacio.Location = New System.Drawing.Point(36, 383)
        Me.chkEspacio.Name = "chkEspacio"
        Me.chkEspacio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEspacio.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.chkEspacio.Properties.Appearance.Options.UseFont = True
        Me.chkEspacio.Properties.Appearance.Options.UseForeColor = True
        Me.chkEspacio.Properties.Caption = "Usar espacio entre nivel de las cuentas"
        Me.chkEspacio.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkEspacio.Size = New System.Drawing.Size(812, 22)
        Me.chkEspacio.StyleController = Me.LayoutControl1
        Me.chkEspacio.TabIndex = 203
        '
        'txtSCuenta5
        '
        Me.txtSCuenta5.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSCuenta5.Location = New System.Drawing.Point(36, 357)
        Me.txtSCuenta5.Name = "txtSCuenta5"
        Me.txtSCuenta5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCuenta5.Properties.Appearance.Options.UseFont = True
        Me.txtSCuenta5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSCuenta5.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtSCuenta5.Size = New System.Drawing.Size(159, 22)
        Me.txtSCuenta5.StyleController = Me.LayoutControl1
        Me.txtSCuenta5.TabIndex = 174
        '
        'txtSCuenta7
        '
        Me.txtSCuenta7.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSCuenta7.Location = New System.Drawing.Point(362, 357)
        Me.txtSCuenta7.Name = "txtSCuenta7"
        Me.txtSCuenta7.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCuenta7.Properties.Appearance.Options.UseFont = True
        Me.txtSCuenta7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSCuenta7.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtSCuenta7.Size = New System.Drawing.Size(159, 22)
        Me.txtSCuenta7.StyleController = Me.LayoutControl1
        Me.txtSCuenta7.TabIndex = 174
        '
        'txtSCuenta9
        '
        Me.txtSCuenta9.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSCuenta9.Location = New System.Drawing.Point(689, 357)
        Me.txtSCuenta9.Name = "txtSCuenta9"
        Me.txtSCuenta9.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCuenta9.Properties.Appearance.Options.UseFont = True
        Me.txtSCuenta9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSCuenta9.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtSCuenta9.Size = New System.Drawing.Size(159, 22)
        Me.txtSCuenta9.StyleController = Me.LayoutControl1
        Me.txtSCuenta9.TabIndex = 174
        '
        'txtSCuenta8
        '
        Me.txtSCuenta8.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSCuenta8.Location = New System.Drawing.Point(525, 357)
        Me.txtSCuenta8.Name = "txtSCuenta8"
        Me.txtSCuenta8.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCuenta8.Properties.Appearance.Options.UseFont = True
        Me.txtSCuenta8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSCuenta8.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtSCuenta8.Size = New System.Drawing.Size(160, 22)
        Me.txtSCuenta8.StyleController = Me.LayoutControl1
        Me.txtSCuenta8.TabIndex = 174
        '
        'txtSCuenta6
        '
        Me.txtSCuenta6.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSCuenta6.Location = New System.Drawing.Point(199, 357)
        Me.txtSCuenta6.Name = "txtSCuenta6"
        Me.txtSCuenta6.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCuenta6.Properties.Appearance.Options.UseFont = True
        Me.txtSCuenta6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSCuenta6.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtSCuenta6.Size = New System.Drawing.Size(159, 22)
        Me.txtSCuenta6.StyleController = Me.LayoutControl1
        Me.txtSCuenta6.TabIndex = 174
        '
        'txtSCuenta4
        '
        Me.txtSCuenta4.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSCuenta4.Location = New System.Drawing.Point(689, 314)
        Me.txtSCuenta4.Name = "txtSCuenta4"
        Me.txtSCuenta4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCuenta4.Properties.Appearance.Options.UseFont = True
        Me.txtSCuenta4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSCuenta4.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtSCuenta4.Size = New System.Drawing.Size(159, 22)
        Me.txtSCuenta4.StyleController = Me.LayoutControl1
        Me.txtSCuenta4.TabIndex = 174
        '
        'txtSCuenta3
        '
        Me.txtSCuenta3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSCuenta3.Location = New System.Drawing.Point(525, 314)
        Me.txtSCuenta3.Name = "txtSCuenta3"
        Me.txtSCuenta3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCuenta3.Properties.Appearance.Options.UseFont = True
        Me.txtSCuenta3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSCuenta3.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtSCuenta3.Size = New System.Drawing.Size(160, 22)
        Me.txtSCuenta3.StyleController = Me.LayoutControl1
        Me.txtSCuenta3.TabIndex = 173
        '
        'txtSCuenta2
        '
        Me.txtSCuenta2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSCuenta2.Location = New System.Drawing.Point(362, 314)
        Me.txtSCuenta2.Name = "txtSCuenta2"
        Me.txtSCuenta2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCuenta2.Properties.Appearance.Options.UseFont = True
        Me.txtSCuenta2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSCuenta2.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtSCuenta2.Size = New System.Drawing.Size(159, 22)
        Me.txtSCuenta2.StyleController = Me.LayoutControl1
        Me.txtSCuenta2.TabIndex = 172
        '
        'txtSCuenta1
        '
        Me.txtSCuenta1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSCuenta1.Location = New System.Drawing.Point(199, 314)
        Me.txtSCuenta1.Name = "txtSCuenta1"
        Me.txtSCuenta1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCuenta1.Properties.Appearance.Options.UseFont = True
        Me.txtSCuenta1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSCuenta1.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtSCuenta1.Size = New System.Drawing.Size(159, 22)
        Me.txtSCuenta1.StyleController = Me.LayoutControl1
        Me.txtSCuenta1.TabIndex = 171
        '
        'txtMayor
        '
        Me.txtMayor.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtMayor.Location = New System.Drawing.Point(36, 314)
        Me.txtMayor.Name = "txtMayor"
        Me.txtMayor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMayor.Properties.Appearance.Options.UseFont = True
        Me.txtMayor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMayor.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtMayor.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtMayor.Size = New System.Drawing.Size(159, 22)
        Me.txtMayor.StyleController = Me.LayoutControl1
        Me.txtMayor.TabIndex = 170
        '
        'cbRegion
        '
        Me.cbRegion.Location = New System.Drawing.Point(186, 166)
        Me.cbRegion.Name = "cbRegion"
        Me.cbRegion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRegion.Properties.Appearance.Options.UseFont = True
        Me.cbRegion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbRegion.Size = New System.Drawing.Size(674, 20)
        Me.cbRegion.StyleController = Me.LayoutControl1
        Me.cbRegion.TabIndex = 202
        '
        'cbGMT
        '
        Me.cbGMT.Location = New System.Drawing.Point(186, 142)
        Me.cbGMT.Name = "cbGMT"
        Me.cbGMT.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGMT.Properties.Appearance.Options.UseFont = True
        Me.cbGMT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbGMT.Size = New System.Drawing.Size(674, 20)
        Me.cbGMT.StyleController = Me.LayoutControl1
        Me.cbGMT.TabIndex = 200
        '
        'cbMonedaSalario
        '
        Me.cbMonedaSalario.Location = New System.Drawing.Point(648, 240)
        Me.cbMonedaSalario.Name = "cbMonedaSalario"
        Me.cbMonedaSalario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaSalario.Properties.Appearance.Options.UseFont = True
        Me.cbMonedaSalario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMonedaSalario.Size = New System.Drawing.Size(212, 20)
        Me.cbMonedaSalario.StyleController = Me.LayoutControl1
        Me.cbMonedaSalario.TabIndex = 169
        '
        'nudAnio
        '
        Me.nudAnio.EditValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudAnio.Location = New System.Drawing.Point(186, 240)
        Me.nudAnio.Name = "nudAnio"
        Me.nudAnio.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudAnio.Properties.Appearance.Options.UseFont = True
        Me.nudAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.nudAnio.Properties.MaxValue = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.nudAnio.Properties.MinValue = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nudAnio.Size = New System.Drawing.Size(296, 22)
        Me.nudAnio.StyleController = Me.LayoutControl1
        Me.nudAnio.TabIndex = 169
        '
        'cbMonedaBase
        '
        Me.cbMonedaBase.Location = New System.Drawing.Point(648, 214)
        Me.cbMonedaBase.Name = "cbMonedaBase"
        Me.cbMonedaBase.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaBase.Properties.Appearance.Options.UseFont = True
        Me.cbMonedaBase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMonedaBase.Size = New System.Drawing.Size(212, 20)
        Me.cbMonedaBase.StyleController = Me.LayoutControl1
        Me.cbMonedaBase.TabIndex = 168
        '
        'cbBodegas
        '
        Me.cbBodegas.Location = New System.Drawing.Point(648, 190)
        Me.cbBodegas.Name = "cbBodegas"
        Me.cbBodegas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBodegas.Properties.Appearance.Options.UseFont = True
        Me.cbBodegas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbBodegas.Size = New System.Drawing.Size(212, 20)
        Me.cbBodegas.StyleController = Me.LayoutControl1
        Me.cbBodegas.TabIndex = 167
        '
        'txtContador
        '
        Me.txtContador.Location = New System.Drawing.Point(186, 70)
        Me.txtContador.Name = "txtContador"
        Me.txtContador.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContador.Properties.Appearance.Options.UseFont = True
        Me.txtContador.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContador.Size = New System.Drawing.Size(674, 20)
        Me.txtContador.StyleController = Me.LayoutControl1
        Me.txtContador.TabIndex = 164
        Me.txtContador.Tag = "True"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(186, 190)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Properties.Appearance.Options.UseFont = True
        Me.txtTelefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Size = New System.Drawing.Size(296, 20)
        Me.txtTelefono.StyleController = Me.LayoutControl1
        Me.txtTelefono.TabIndex = 164
        Me.txtTelefono.Tag = "True"
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(186, 118)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Properties.Appearance.Options.UseFont = True
        Me.txtCiudad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCiudad.Size = New System.Drawing.Size(674, 20)
        Me.txtCiudad.StyleController = Me.LayoutControl1
        Me.txtCiudad.TabIndex = 5
        Me.txtCiudad.Tag = "True"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(186, 46)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Properties.Appearance.Options.UseFont = True
        Me.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Size = New System.Drawing.Size(674, 20)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 4
        Me.txtNombre.Tag = "True"
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.txtPresPorcMin
        Me.LayoutControlItem45.Location = New System.Drawing.Point(216, 52)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(624, 26)
        Me.LayoutControlItem45.Text = "Pres Porc Min:"
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.Panel1
        Me.LayoutControlItem41.Location = New System.Drawing.Point(484, 260)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(356, 182)
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem41.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(884, 561)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup2
        Me.TabbedControlGroup1.SelectedTabPageIndex = 0
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(864, 541)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3})
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem10, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlGroup4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem12, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem48})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(840, 495)
        Me.LayoutControlGroup2.Text = "Datos Generales"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtNombre
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(840, 24)
        Me.LayoutControlItem1.Text = "Compañia:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtTelefono
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(462, 24)
        Me.LayoutControlItem4.Tag = ""
        Me.LayoutControlItem4.Text = "Telefono:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.nudAnio
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 194)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(462, 26)
        Me.LayoutControlItem10.Text = "Año:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cbBodegas
        Me.LayoutControlItem8.Location = New System.Drawing.Point(462, 144)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(378, 24)
        Me.LayoutControlItem8.Text = "Bodega:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cbMonedaBase
        Me.LayoutControlItem9.Location = New System.Drawing.Point(462, 168)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem9.Text = "Moneda Base:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cbMonedaSalario
        Me.LayoutControlItem11.Location = New System.Drawing.Point(462, 194)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(378, 26)
        Me.LayoutControlItem11.Text = "Moneda Salario:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup4.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem23, Me.LayoutControlItem17, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem14, Me.LayoutControlItem13, Me.LayoutControlItem18, Me.LayoutControlItem22, Me.LayoutControlItem6})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 220)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(840, 275)
        Me.LayoutControlGroup4.Text = "Configurar Niveles y Longitud de Cuenta Contable"
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem15.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem15.Control = Me.txtSCuenta2
        Me.LayoutControlItem15.Location = New System.Drawing.Point(326, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(163, 43)
        Me.LayoutControlItem15.Text = "Nivel 2"
        Me.LayoutControlItem15.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(159, 14)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem16.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem16.Control = Me.txtSCuenta3
        Me.LayoutControlItem16.Location = New System.Drawing.Point(489, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(164, 43)
        Me.LayoutControlItem16.Text = "Nivel 3"
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(159, 14)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.chkEspacio
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 86)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(816, 26)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem17.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem17.Control = Me.txtSCuenta4
        Me.LayoutControlItem17.Location = New System.Drawing.Point(653, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(163, 43)
        Me.LayoutControlItem17.Text = "Nivel 4"
        Me.LayoutControlItem17.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(159, 14)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem19.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem19.Control = Me.txtSCuenta8
        Me.LayoutControlItem19.Location = New System.Drawing.Point(489, 43)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(164, 43)
        Me.LayoutControlItem19.Text = "Nivel 8"
        Me.LayoutControlItem19.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(159, 14)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem20.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem20.Control = Me.txtSCuenta9
        Me.LayoutControlItem20.Location = New System.Drawing.Point(653, 43)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(163, 43)
        Me.LayoutControlItem20.Text = "Nivel 9"
        Me.LayoutControlItem20.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(159, 14)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem21.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem21.Control = Me.txtSCuenta7
        Me.LayoutControlItem21.Location = New System.Drawing.Point(326, 43)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(163, 43)
        Me.LayoutControlItem21.Text = "Nivel 7"
        Me.LayoutControlItem21.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(159, 14)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem14.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem14.Control = Me.txtSCuenta1
        Me.LayoutControlItem14.Location = New System.Drawing.Point(163, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(163, 43)
        Me.LayoutControlItem14.Text = "Nivel 1"
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(159, 14)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem13.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem13.Control = Me.txtMayor
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(163, 43)
        Me.LayoutControlItem13.Text = "Mayor"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(159, 14)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem18.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem18.Control = Me.txtSCuenta6
        Me.LayoutControlItem18.Location = New System.Drawing.Point(163, 43)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(163, 43)
        Me.LayoutControlItem18.Text = "Nivel 6"
        Me.LayoutControlItem18.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(159, 14)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem22.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem22.Control = Me.txtSCuenta5
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 43)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(163, 43)
        Me.LayoutControlItem22.Text = "Nivel 5"
        Me.LayoutControlItem22.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(159, 14)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.lblCuenta
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 112)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(816, 120)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtContador
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(840, 24)
        Me.LayoutControlItem5.Text = "Contador:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbGMT
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(840, 24)
        Me.LayoutControlItem7.Text = "Zona Horaria:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cbRegion
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(840, 24)
        Me.LayoutControlItem12.Text = "Región:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtCiudad
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(840, 24)
        Me.LayoutControlItem2.Text = "Ciudad:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbPais
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(840, 24)
        Me.LayoutControlItem3.Text = "País:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem48
        '
        Me.LayoutControlItem48.Control = Me.cbMes
        Me.LayoutControlItem48.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem48.Name = "LayoutControlItem48"
        Me.LayoutControlItem48.Size = New System.Drawing.Size(462, 26)
        Me.LayoutControlItem48.Text = "Inicio Año Fiscal:"
        Me.LayoutControlItem48.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem33, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem28, Me.LayoutControlItem39, Me.LayoutControlItem38, Me.LayoutControlItem43, Me.EmptySpaceItem1, Me.lytxtFacturaDigitos, Me.LayoutControlItem29, Me.LayoutControlItem31, Me.LayoutControlItem34, Me.LayoutControlItem35, Me.LayoutControlItem36, Me.LayoutControlItem37, Me.LayoutControlItem42, Me.LayoutControlItem47, Me.LayoutControlItem44, Me.LayoutControlItem32, Me.EmptySpaceItem2, Me.LayoutControlItem30, Me.EmptySpaceItem3, Me.LayoutControlItem49})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(840, 495)
        Me.LayoutControlGroup3.Text = "Configuraciones"
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.txtIva
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem33.Text = "IVA:"
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txtIRProductos
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem24.Text = "IR Productos:"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtIRServicios
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem25.Text = "Servicios Profesionales: "
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.txtIRVentas
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem26.Text = "IR Ventas:"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.txtMontoIR
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem27.Text = "Monto IR:"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txtInatec
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 130)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem28.Text = "INATEC:"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.txtDevolucionProveedorNumero
        Me.LayoutControlItem39.Location = New System.Drawing.Point(0, 338)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem39.Text = "No. Devolución Proveedor Inicial:"
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.txtDevolucionClienteNumero
        Me.LayoutControlItem38.Location = New System.Drawing.Point(0, 364)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem38.Text = "No. Devolución Cliente Inicial:"
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.txtLineas
        Me.LayoutControlItem43.Location = New System.Drawing.Point(0, 442)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem43.Text = "Cantidad de Lineas en Factura:"
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(159, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 468)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(840, 27)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lytxtFacturaDigitos
        '
        Me.lytxtFacturaDigitos.Control = Me.txtFacturaDigitos
        Me.lytxtFacturaDigitos.Location = New System.Drawing.Point(0, 156)
        Me.lytxtFacturaDigitos.Name = "lytxtFacturaDigitos"
        Me.lytxtFacturaDigitos.Size = New System.Drawing.Size(484, 26)
        Me.lytxtFacturaDigitos.Text = "Digitos en Factura:"
        Me.lytxtFacturaDigitos.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.txtReciboDigitos
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 182)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem29.Text = "Digitos en Recibo:"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.txtReciboNumero
        Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 208)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem31.Text = "No. Recibo Inicial:"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.txtOrdenVentaInicial
        Me.LayoutControlItem34.Location = New System.Drawing.Point(0, 234)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem34.Text = "No. Orden Venta Inicial:"
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.txtCotizacionNumero
        Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 260)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem35.Text = "No. Cotización Inicial:"
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.txtPedidoNumero
        Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 286)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem36.Text = "No. Pedido Inicial:"
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.txtOrdenCompraNumero
        Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 390)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem37.Text = "No. Orden Compra Inicial:"
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.txtNoDecimales
        Me.LayoutControlItem42.Location = New System.Drawing.Point(0, 416)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem42.Text = "No. de Decimales en Productos:"
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(159, 13)
        '
        'LayoutControlItem47
        '
        Me.LayoutControlItem47.Control = Me.chkOC
        Me.LayoutControlItem47.Location = New System.Drawing.Point(484, 0)
        Me.LayoutControlItem47.Name = "LayoutControlItem47"
        Me.LayoutControlItem47.Size = New System.Drawing.Size(356, 26)
        Me.LayoutControlItem47.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem47.TextVisible = False
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.ckLiquidacion
        Me.LayoutControlItem44.Location = New System.Drawing.Point(484, 26)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(356, 26)
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem44.TextVisible = False
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.ckMultiple
        Me.LayoutControlItem32.Location = New System.Drawing.Point(484, 52)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(356, 26)
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem32.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(484, 156)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(356, 78)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.txtRequisaBodegaNumero
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 312)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(484, 26)
        Me.LayoutControlItem30.Text = "Movimiento de Inventario Inicial:"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(159, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(484, 234)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(356, 234)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 12)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(107, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl2
        Me.cmdAceptar.TabIndex = 20
        Me.cmdAceptar.Text = "&Guardar"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl2.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup5
        Me.LayoutControl2.Size = New System.Drawing.Size(131, 588)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(12, 54)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(107, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl2
        Me.cmdCancelar.TabIndex = 21
        Me.cmdCancelar.Text = "&Salir"
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem40, Me.LayoutControlItem46})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(131, 588)
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.cmdAceptar
        Me.LayoutControlItem40.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem40.TextVisible = False
        '
        'LayoutControlItem46
        '
        Me.LayoutControlItem46.Control = Me.cmdCancelar
        Me.LayoutControlItem46.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem46.Name = "LayoutControlItem46"
        Me.LayoutControlItem46.Size = New System.Drawing.Size(111, 526)
        Me.LayoutControlItem46.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem46.TextVisible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(0, 561)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(884, 54)
        Me.GroupBox1.TabIndex = 162
        Me.GroupBox1.TabStop = False
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("552dec0c-3417-4ef3-b667-6e6e2e6b604f")
        Me.DockPanel1.Location = New System.Drawing.Point(884, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 615)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 588)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'chkValidar
        '
        Me.chkValidar.Location = New System.Drawing.Point(508, 124)
        Me.chkValidar.Name = "chkValidar"
        Me.chkValidar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkValidar.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkValidar.Properties.Appearance.Options.UseFont = True
        Me.chkValidar.Properties.Appearance.Options.UseForeColor = True
        Me.chkValidar.Properties.Caption = "Validar Tasa de Cambio"
        Me.chkValidar.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkValidar.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkValidar.Size = New System.Drawing.Size(352, 22)
        Me.chkValidar.StyleController = Me.LayoutControl1
        Me.chkValidar.TabIndex = 185
        '
        'LayoutControlItem49
        '
        Me.LayoutControlItem49.Control = Me.chkValidar
        Me.LayoutControlItem49.Location = New System.Drawing.Point(484, 78)
        Me.LayoutControlItem49.Name = "LayoutControlItem49"
        Me.LayoutControlItem49.Size = New System.Drawing.Size(356, 78)
        Me.LayoutControlItem49.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem49.TextVisible = False
        '
        'frmAgregarEmpresa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1024, 615)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmAgregarEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.cbPais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPresPorcMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequisaBodegaNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckMultiple.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckLiquidacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLineas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoDecimales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDevolucionProveedorNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDevolucionClienteNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdenCompraNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPedidoNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCotizacionNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdenVentaInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReciboNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReciboDigitos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacturaDigitos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInatec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoIR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIRVentas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIRServicios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIRProductos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEspacio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSCuenta5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSCuenta7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSCuenta9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSCuenta8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSCuenta6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSCuenta4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSCuenta3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSCuenta2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSCuenta1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMayor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRegion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGMT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMonedaSalario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMonedaBase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBodegas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCiudad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytxtFacturaDigitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkValidar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region



    'Dim i As Integer
    'Dim m As String
    'Dim k As Integer
    'Dim k1 As Integer
    'Dim cm As Integer
    'Dim ml As Integer
    'Dim Empresa As New VB.SysContab.EmpresasDB()
    'Dim Detalles As New VB.SysContab.EmpresasDetails()

    'Dim Monedas As New VB.SysContab.MonedaDB()
    'Dim Config As New VB.SysContab.ConfiguracionDB()

    Dim Empresa As String = EmpresaActual

    Private Sub frmAgregarEmpresa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        EmpresaActual = Empresa
    End Sub

    Private Sub frmAgregarEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        'Dim i As Integer
        'Dim r As New VB.SysContab.Rutinas()


        ' Dim Emp As New VB.SysContab.EmpresasDB()
        ''  '''r.CambiarEstilo(Me)
        'Me.cbMonedaBase.DataSource = Monedas.GetList.Tables("Monedas")
        'Me.cbMonedaBase.ValueMember = "Codigo"
        'Me.cbMonedaBase.DisplayMember = "Descripcion"

        'Me.cbMonedaSalario.DataSource = Monedas.GetList.Tables("Monedas")
        'Me.cbMonedaSalario.ValueMember = "Codigo"
        'Me.cbMonedaSalario.DisplayMember = "Descripcion"

        'Me.cbBodegas.DataSource = Bodegas.GetList().Tables("Bodegas")
        'Me.cbBodegas.ValueMember = "CODIGO"
        'Me.cbBodegas.DisplayMember = "UBICACION"

        Empresa = EmpresaActual
        EmpresaActual = Registro

        Dim DetallesEmpresa As New VB.SysContab.EmpresasDetails
        DetallesEmpresa = VB.SysContab.EmpresasDB.GetDetails(Registro)

        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails()

        Me.cbPais.Properties.DataSource = VB.SysContab.PaisesDB.GetList(True)
        Me.cbPais.Properties.ValueMember = "Codigo"
        Me.cbPais.Properties.DisplayMember = "Nombre"
        Me.cbPais.Properties.PopulateColumns()
        Me.cbPais.Properties.Columns(0).Visible = False

        ' Me.cbGMT.SelectedText = "-06:00"

        GetMonedas(cbMonedaBase)
        GetMonedas(cbMonedaSalario)
        GetBodegasList(cbBodegas)

        Dim tz As TimeZoneInfo = TimeZoneInfo.Local
        cbGMT.EditValue = tz.Id

        ' GetMesesList(cbMes)
        CargarConfiguracionRegional(cbRegion)

        If Nuevo = "NO" Then
            ''''''''''''''''''''''''''''''''''''''''''
            'Agregado el 11042008
            'Me.txtFacturaNumero.Enabled = False
            ''''''''''''''''''''''''''''''''''''''''''
            'Me.etDescripcion.Text = "Editar Empresa".ToUpper
            'Me.Text = "Editar Empresa"
            'Try
            '    Empresa = EmpresaActual
            '    EmpresaActual = Registro
            '    ConfigDetalles = Config.GetConfigDetails
            '    EmpresaActual = Empresa
            'Catch ex As Exception
            '    EmpresaActual = Empresa
            'End Try

            'Me.cbGMT.SelectedItem = IIf(DetallesEmpresa.GMT <> 0, Microsoft.VisualBasic.Left(DetallesEmpresa.GMT.ToString, 1) & Math.Abs(DetallesEmpresa.GMT).ToString.PadLeft(2, "0") & ":00", " 00:00")

            cbGMT.EditValue = DetallesEmpresa.IdGMT
            cbRegion.EditValue = DetallesEmpresa.Region
            chkOC.Checked = DetallesEmpresa.Exento_OC
            chkValidar.Checked = DetallesEmpresa.ValidarTCambio

            Me.txtIva.Text = ConfigDetalles.IVA
            Me.txtIRProductos.Text = ConfigDetalles.IRProd
            Me.txtIRServicios.Text = ConfigDetalles.IRServ
            Me.txtIRVentas.Text = ConfigDetalles.IR_Ventas
            Me.txtMontoIR.Text = ConfigDetalles.MontoIR
            Me.txtInatec.Text = ConfigDetalles.INATEC

            Me.txtFacturaDigitos.Text = ConfigDetalles.FacturaDigitos
            Me.txtRequisaBodegaNumero.Text = ConfigDetalles.RequisaBodegaNumero

            Me.ckMultiple.Checked = ConfigDetalles.SeriesMultiples
            Me.txtReciboDigitos.Text = ConfigDetalles.ReciboDigitos
            Me.txtReciboNumero.Text = ConfigDetalles.ReciboNumero
            Me.txtOrdenVentaInicial.Text = ConfigDetalles.OrdenClienteNumero
            Me.txtPedidoNumero.Text = ConfigDetalles.PedidoNumero
            Me.txtOrdenCompraNumero.Text = ConfigDetalles.OrdenCompraNumero
            Me.txtDevolucionClienteNumero.Text = ConfigDetalles.DevolucionClienteNumero
            Me.txtDevolucionProveedorNumero.Text = ConfigDetalles.DevolucionProveedorNumero
            ckLiquidacion.Checked = ConfigDetalles.Liqudacion
            'No. de Decimales en Productos / Invetanrios
            Me.txtNoDecimales.Text = ConfigDetalles.Decimales
            txtLineas.EditValue = ConfigDetalles.LineasFactura

            'If ConfigDetalles.Bodega.ToString Is DBNull.Value Or ConfigDetalles.Bodega.ToString = Nothing Then
            'Else
            Me.cbBodegas.EditValue = ConfigDetalles.Bodega.ToString
            'End If

            Me.txtPresPorcMin.Text = 10

            txtNombre.Text = DetallesEmpresa.Nombre
            txtCiudad.Text = DetallesEmpresa.Ciudad
            ' txtPais.Text = DetallesEmpresa.Pais
            cbPais.EditValue = DetallesEmpresa.Pais_ID
            txtTelefono.Text = DetallesEmpresa.Telefono
            txtContador.Text = DetallesEmpresa.Contador

            cbMes.EditValue = CInt(DetallesEmpresa.Mes)

            Me.chkEspacio.Checked = DetallesEmpresa.Espacio

            'If DetallesEmpresa.Mes = 1 Then
            '    cbMes.SelectedIndex = 0
            'Else
            '    cbMes.SelectedIndex = 1
            'End If

            Me.nudAnio.Value = DetallesEmpresa.Anio

            If DetallesEmpresa.Mayor <> 0 Then
                txtMayor.Text = DetallesEmpresa.Mayor
                txtMayor.ReadOnly = True
            End If

            If DetallesEmpresa.Espacio = True Then
                If DetallesEmpresa.SC01 <> 0 Then
                    txtSCuenta1.Text = DetallesEmpresa.SC01 - 1
                    txtSCuenta1.ReadOnly = True
                End If

                If DetallesEmpresa.SC02 <> 0 Then
                    txtSCuenta2.Text = DetallesEmpresa.SC02 - 2
                    txtSCuenta2.ReadOnly = True
                End If

                If DetallesEmpresa.SC03 <> 0 Then
                    txtSCuenta3.Text = DetallesEmpresa.SC03 - 3
                    txtSCuenta3.ReadOnly = True
                End If

                If DetallesEmpresa.SC04 <> 0 Then
                    txtSCuenta4.Text = DetallesEmpresa.SC04 - 4
                    txtSCuenta4.ReadOnly = True
                End If

                If DetallesEmpresa.SC05 <> 0 Then
                    txtSCuenta5.Text = DetallesEmpresa.SC05 - 5
                    txtSCuenta5.ReadOnly = True
                End If

                If DetallesEmpresa.SC06 <> 0 Then
                    txtSCuenta6.Text = DetallesEmpresa.SC06 - 6
                    txtSCuenta6.ReadOnly = True
                End If

                If DetallesEmpresa.SC07 <> 0 Then
                    txtSCuenta7.Text = DetallesEmpresa.SC07 - 7
                    txtSCuenta7.ReadOnly = True
                End If

                If DetallesEmpresa.SC08 <> 0 Then
                    txtSCuenta8.Text = DetallesEmpresa.SC08 - 8
                    txtSCuenta8.ReadOnly = True
                End If

                If DetallesEmpresa.SC09 <> 0 Then
                    txtSCuenta9.Text = DetallesEmpresa.SC09 - 9
                    txtSCuenta9.ReadOnly = True
                End If
            Else
                If DetallesEmpresa.SC01 <> 0 Then
                    txtSCuenta1.Text = DetallesEmpresa.SC01
                    txtSCuenta1.ReadOnly = True
                End If

                If DetallesEmpresa.SC02 <> 0 Then
                    txtSCuenta2.Text = DetallesEmpresa.SC02
                    txtSCuenta2.ReadOnly = True
                End If

                If DetallesEmpresa.SC03 <> 0 Then
                    txtSCuenta3.Text = DetallesEmpresa.SC03
                    txtSCuenta3.ReadOnly = True
                End If

                If DetallesEmpresa.SC04 <> 0 Then
                    txtSCuenta4.Text = DetallesEmpresa.SC04
                    txtSCuenta4.ReadOnly = True
                End If

                If DetallesEmpresa.SC05 <> 0 Then
                    txtSCuenta5.Text = DetallesEmpresa.SC05
                    txtSCuenta5.ReadOnly = True
                End If

                If DetallesEmpresa.SC06 <> 0 Then
                    txtSCuenta6.Text = DetallesEmpresa.SC06
                    txtSCuenta6.ReadOnly = True
                End If

                If DetallesEmpresa.SC07 <> 0 Then
                    txtSCuenta7.Text = DetallesEmpresa.SC07
                    txtSCuenta7.ReadOnly = True
                End If

                If DetallesEmpresa.SC08 <> 0 Then
                    txtSCuenta8.Text = DetallesEmpresa.SC08
                    txtSCuenta8.ReadOnly = True
                End If

                If DetallesEmpresa.SC09 <> 0 Then
                    txtSCuenta9.Text = DetallesEmpresa.SC09
                    txtSCuenta9.ReadOnly = True
                End If

            End If

            cbMonedaBase.EditValue = DetallesEmpresa.MonedaBase
            cbMonedaSalario.EditValue = DetallesEmpresa.MonedaSalario
            If ObtieneDatos("SELECT Count(Cuenta) FROM Catalogo WHERE Empresa = " & EmpresaActual).Rows(0).Item(0) > 0 Then chkEspacio.Enabled = False
        Else

            'cbMes.SelectedIndex = -1
            nudAnio.Value = Year(VB.SysContab.Rutinas.Fecha())

            Me.Text = "Agregar Empresa"
            'etDescripcion.Text = "Agregar Empresa".ToUpper

        End If

        Me.GridControl1.DataSource = ObtieneDatos("select Serie, Factura from series WHERE empr_codigo = " & EmpresaActual)
    End Sub

    Private Sub frmAgregarEmpresa_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim emp As frmEmpresas = frmEmpresas.Instance()
        emp.LoadGrid()

        'Dim r As New VB.SysContab.Rutinas
        'Dim Empresas As New VB.SysContab.EmpresasDB
        'Dim emp As frmEmpresas = emp.Instance
        'Dim Tabla As New DataTable
        'Dim ds As New DataSet

        'ds = Empresas.EmpresasXUsuarios(Login, Password)
        ''emp.dgEmpresas.DataSource = ds.Tables("Empresas").DefaultView
        'Tabla = ds.Tables("Empresas")

        ''r.FormatGenerico(emp.dgEmpresas, Tabla)

        'If ds.Tables("Empresas").Rows.Count <> 0 Then
        '    'Registro = emp.dgEmpresas.Item(0, 0)
        '    If Registro = EmpresaActual Then
        '        ConfigDetalles = Config.GetConfigDetails

        '        MonedaBase = Empresa.GetDetails(EmpresaActual).MonedaBase
        '        Round = "n" & Empresa.GetDetails(EmpresaActual).Decimales
        '        RoundP = "n" & ConfigDetalles.Decimales

        '        Dim lds As New DataSet
        '        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        '        lds.WriteXml(Application.StartupPath & "\xml\logoempresa.xml", XmlWriteMode.WriteSchema)
        '    End If
        'End If

    End Sub

    Private Sub txtMascara_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
                Exit Sub

            End If

        End If

    End Sub

    'Private Sub txtMascara_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim i As Integer
    '    Dim j As Integer
    '    Dim Mascara As String
    '    Mascara = ""
    '    ml = 0

    '    If Trim(txtMascara.Text) = "" Then
    '        Exit Sub
    '    End If

    '    For i = 0 To txtMascara.Text.Length - 1
    '        For j = 1 To txtMascara.Text.Substring(i, 1)
    '            Mascara = Mascara & "1"
    '        Next
    '        Mascara = Mascara & " "
    '        'Mascara = Mascara & txtMascara.Text.Substring(i, 1)
    '    Next

    '    etMascara.Text = Mascara
    '    m = txtMascara.Text
    '    k = -1
    '    k1 = -1
    '    cm = 0

    '    For i = 0 To m.Length - 1
    '        ml = CInt(m.Substring(i, 1)) + ml
    '    Next

    '    ml = ml + m.Length - 1

    '    txtCuenta.MaxLength = ml

    '    'MsgBox(ml)

    'End Sub

    'Private Sub txtMascara_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    etMascara.Text = ""

    'End Sub

    'Private Sub txtCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuenta.KeyPress
    '    ''Dim i As Integer
    '    ''Dim j As Integer

    '    ''If txtCuenta.TextLength = 0 Then
    '    ''    k = -1
    '    ''    cm = 0
    '    ''    'Exit Sub

    '    ''End If

    '    ''If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then

    '    ''    If Not IsNumeric(e.KeyChar) Or cm = m.Length Or txtCuenta.TextLength = ml Then
    '    ''        e.Handled = True
    '    ''        Exit Sub

    '    ''    End If

    '    ''    k = k + 1

    '    ''    If k = CInt(m.Substring(cm, 1)) Then
    '    ''        k = 0
    '    ''        cm = cm + 1
    '    ''        txtCuenta.Text = txtCuenta.Text & " "
    '    ''        txtCuenta.SelectionStart = txtCuenta.TextLength

    '    ''    End If
    '    ''Else
    '    ''    k = k - 1

    '    ''    'If cm >= 0 Then
    '    ''    If k <= 2 Then
    '    ''        k = 0
    '    ''        k1 = txtCuenta.TextLength - 2
    '    ''        While txtCuenta.Text.Substring(k1, 1) <> " " And k1 > 0
    '    ''            k1 = k1 - 1
    '    ''            k = k + 1
    '    ''        End While
    '    ''        k = k - 1
    '    ''    End If
    '    ''    'End If

    '    ''    If txtCuenta.Text <> "" Then
    '    ''        If txtCuenta.Text.Substring(txtCuenta.TextLength - 1, 1) = " " Then
    '    ''            cm = cm - 1
    '    ''        End If
    '    ''    End If

    '    ''End If
    '    ''Dim Empresa As New VB.SysContab.EmpresasDB()
    '    ''Dim Detalles As New VB.SysContab.EmpresasDetails()

    '    ''Detalles = Empresa.GetDetails("2")

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '        If txtCuenta.TextLength = txtCuenta.MaxLength Then
    '            e.Handled = True
    '            Exit Sub

    '        End If

    '        If Detalles.Mayor <> 0 Then
    '            If txtCuenta.TextLength = Detalles.Mayor Then
    '                txtCuenta.Text = txtCuenta.Text & " "
    '                txtCuenta.SelectionStart = txtCuenta.TextLength
    '                Exit Sub

    '            End If

    '        End If

    '        If Detalles.SC01 <> 0 Then
    '            If txtCuenta.TextLength = Detalles.SC01 + 1 Then
    '                txtCuenta.Text = txtCuenta.Text & " "
    '                txtCuenta.SelectionStart = txtCuenta.TextLength
    '                Exit Sub

    '            End If

    '        End If

    '        If Detalles.SC02 <> 0 Then
    '            If txtCuenta.TextLength = Detalles.SC02 + 2 Then
    '                txtCuenta.Text = txtCuenta.Text & " "
    '                txtCuenta.SelectionStart = txtCuenta.TextLength
    '                Exit Sub

    '            End If

    '        End If

    '        If Detalles.SC03 <> 0 Then
    '            If txtCuenta.TextLength = Detalles.SC03 + 3 Then
    '                txtCuenta.Text = txtCuenta.Text & " "
    '                txtCuenta.SelectionStart = txtCuenta.TextLength
    '                Exit Sub

    '            End If

    '        End If

    '        If Detalles.SC04 <> 0 Then
    '            If txtCuenta.TextLength = Detalles.SC04 + 4 Then
    '                txtCuenta.Text = txtCuenta.Text & " "
    '                txtCuenta.SelectionStart = txtCuenta.TextLength
    '                Exit Sub

    '            End If

    '        End If

    '        If Detalles.SC05 <> 0 Then
    '            If txtCuenta.TextLength = Detalles.SC05 + 5 Then
    '                txtCuenta.Text = txtCuenta.Text & " "
    '                txtCuenta.SelectionStart = txtCuenta.TextLength
    '                Exit Sub

    '            End If

    '        End If

    '        If Detalles.SC06 <> 0 Then
    '            If txtCuenta.TextLength = Detalles.SC06 + 6 Then
    '                txtCuenta.Text = txtCuenta.Text & " "
    '                txtCuenta.SelectionStart = txtCuenta.TextLength
    '                Exit Sub

    '            End If

    '        End If

    '        If Detalles.SC07 <> 0 Then
    '            If txtCuenta.TextLength = Detalles.SC07 + 7 Then
    '                txtCuenta.Text = txtCuenta.Text & " "
    '                txtCuenta.SelectionStart = txtCuenta.TextLength
    '                Exit Sub

    '            End If

    '        End If

    '        If Detalles.SC08 <> 0 Then
    '            If txtCuenta.TextLength = Detalles.SC08 + 8 Then
    '                txtCuenta.Text = txtCuenta.Text & " "
    '                txtCuenta.SelectionStart = txtCuenta.TextLength
    '                Exit Sub

    '            End If

    '        End If

    '        If Detalles.SC09 <> 0 Then
    '            If txtCuenta.TextLength = Detalles.SC09 + 9 Then
    '                txtCuenta.Text = txtCuenta.Text & " "
    '                txtCuenta.SelectionStart = txtCuenta.TextLength
    '                Exit Sub

    '            End If

    '        End If

    '        'If txtCuenta.TextLength = 4 Or txtCuenta.TextLength = 7 Or txtCuenta.TextLength = 10 Or txtCuenta.TextLength = 14 Or txtCuenta.TextLength = 19 Then
    '        '    txtCuenta.Text = txtCuenta.Text & " "
    '        '    txtCuenta.SelectionStart = txtCuenta.TextLength

    '        'End If

    '    End If

    'End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Not DxValidationProvider1.Validate Then Exit Sub

        'Dim Info As TimeZoneInfo = TimeZoneEdit1.GetSelectedDataRow()
        'XtraMsg(Info.Id)
        'XtraMsg(cbGMT.Text)
        'Exit Sub


        'Dim Empresas As New VB.SysContab.EmpresasDB
        'Dim r As New VB.SysContab.Rutinas


        'If Trim(txtNombre.Text) = "" Then
        '    MsgBox("Introduzca el Nombre de la Empresa", MsgBoxStyle.Information)
        '    txtNombre.Focus()
        '    txtNombre.SelectAll()
        '    Exit Sub
        'End If

        'If Trim(txtCiudad.Text) = "" Then
        '    MsgBox("Introduzca la Ciudad de la Empresa", MsgBoxStyle.Information)
        '    txtCiudad.Focus()
        '    txtCiudad.SelectAll()
        '    Exit Sub
        'End If
        ' '''Editado por JET
        ' '''If Trim(txtPais.Text) = "" Then
        ' '''    MsgBox("Introduzca el Pais de la Empresa", MsgBoxStyle.Information)
        ' '''    txtPais.Focus()
        ' '''    txtPais.SelectAll()
        ' '''    Exit Sub
        ' '''End If
        'If cbPais.EditValue = 0 Then
        '    MsgBox("Favor seleccione un país para la empresa.", MsgBoxStyle.Information)
        '    cbPais.Focus()
        '    Exit Sub
        'End If
        'If Trim(txtTelefono.Text) = "" Then
        '    MsgBox("Introduzca el Teléfono de la Empresa", MsgBoxStyle.Information)
        '    txtTelefono.Focus()
        '    txtTelefono.SelectAll()
        '    Exit Sub
        'End If

        'If Trim(txtContador.Text) = "" Then
        '    MsgBox("Introduzca el Contador de la Empresa", MsgBoxStyle.Information)
        '    txtContador.Focus()
        '    txtContador.SelectAll()
        '    Exit Sub
        'End If

        'If Trim(cbMes.Text) = "" Then
        '    MsgBox("Seleccione el Mes en que empieza el año fiscal", MsgBoxStyle.Information)
        '    cbMes.Focus()
        '    'cbMes.SelectAll()
        '    Exit Sub
        'End If

        'If Trim(txtMayor.Text) = "" Then
        '    MsgBox("Introduzca el nivel Mayor de la cuenta", MsgBoxStyle.Information)
        '    txtMayor.Focus()
        '    txtMayor.SelectAll()
        '    Exit Sub
        'End If

        'If cbMes.Text = "ENERO" Then
        '    mes = 1
        'Else
        '    mes = 7
        'End If

        Dim mes As String = cbMes.EditValue

        ' Exit Sub

        Dim Mayor As Integer
        Dim SC01 As Integer
        Dim SC02 As Integer
        Dim SC03 As Integer
        Dim SC04 As Integer
        Dim SC05 As Integer
        Dim SC06 As Integer
        Dim SC07 As Integer
        Dim SC08 As Integer
        Dim SC09 As Integer

        If Me.chkEspacio.Checked = True Then

            Mayor = txtMayor.EditValue
            SC01 = IIf(txtSCuenta1.EditValue > 0, txtSCuenta1.EditValue + 1, 0)
            SC02 = IIf(txtSCuenta2.EditValue > 0, txtSCuenta2.EditValue + 2, 0)
            SC03 = IIf(txtSCuenta3.EditValue > 0, txtSCuenta3.EditValue + 3, 0)
            SC04 = IIf(txtSCuenta4.EditValue > 0, txtSCuenta4.EditValue + 4, 0)
            SC05 = IIf(txtSCuenta5.EditValue > 0, txtSCuenta5.EditValue + 5, 0)
            SC06 = IIf(txtSCuenta6.EditValue > 0, txtSCuenta6.EditValue + 6, 0)
            SC07 = IIf(txtSCuenta7.EditValue > 0, txtSCuenta7.EditValue + 7, 0)
            SC08 = IIf(txtSCuenta8.EditValue > 0, txtSCuenta8.EditValue + 8, 0)
            SC09 = IIf(txtSCuenta9.EditValue > 0, txtSCuenta9.EditValue + 9, 0)

            'If Trim(txtSCuenta1.Text) = "" Then
            '    SC01 = "0"
            'Else
            '    SC01 = CInt(Trim(txtSCuenta1.Text)) + 1
            'End If

            'If Trim(txtSCuenta2.Text) = "" Then
            '    SC02 = "0"
            'Else
            '    SC02 = CInt(Trim(txtSCuenta2.Text)) + 2
            'End If

            'If Trim(txtSCuenta3.Text) = "" Then
            '    SC03 = "0"
            'Else
            '    SC03 = CInt(Trim(txtSCuenta3.Text)) + 3
            'End If

            'If Trim(txtSCuenta4.Text) = "" Then
            '    SC04 = "0"
            'Else
            '    SC04 = CInt(Trim(txtSCuenta4.Text)) + 4
            'End If

            'If Trim(txtSCuenta5.Text) = "" Then
            '    SC05 = "0"
            'Else
            '    SC05 = CInt(Trim(txtSCuenta5.Text)) + 5
            'End If

            'If Trim(txtSCuenta6.Text) = "" Then
            '    SC06 = "0"
            'Else
            '    SC06 = CInt(Trim(txtSCuenta6.Text)) + 6
            'End If

            'If Trim(txtSCuenta7.Text) = "" Then
            '    SC07 = "0"
            'Else
            '    SC07 = CInt(Trim(txtSCuenta7.Text)) + 7
            'End If

            'If Trim(txtSCuenta8.Text) = "" Then
            '    SC08 = "0"
            'Else
            '    SC08 = CInt(Trim(txtSCuenta8.Text)) + 8
            'End If

            'If Trim(txtSCuenta9.Text) = "" Then
            '    SC09 = "0"
            'Else
            '    SC09 = CInt(Trim(txtSCuenta9.Text)) + 9
            'End If
        Else

            Mayor = txtMayor.EditValue
            SC01 = IIf(txtSCuenta1.EditValue > 0, txtSCuenta1.EditValue, 0)
            SC02 = IIf(txtSCuenta2.EditValue > 0, txtSCuenta2.EditValue, 0)
            SC03 = IIf(txtSCuenta3.EditValue > 0, txtSCuenta3.EditValue, 0)
            SC04 = IIf(txtSCuenta4.EditValue > 0, txtSCuenta4.EditValue, 0)
            SC05 = IIf(txtSCuenta5.EditValue > 0, txtSCuenta5.EditValue, 0)
            SC06 = IIf(txtSCuenta6.EditValue > 0, txtSCuenta6.EditValue, 0)
            SC07 = IIf(txtSCuenta7.EditValue > 0, txtSCuenta7.EditValue, 0)
            SC08 = IIf(txtSCuenta8.EditValue > 0, txtSCuenta8.EditValue, 0)
            SC09 = IIf(txtSCuenta9.EditValue > 0, txtSCuenta9.EditValue, 0)

            'If Trim(txtMayor.Text) = "" Then
            '    Mayor = "0"
            'Else
            '    Mayor = CInt(Trim(txtMayor.Text))
            'End If

            'If Trim(txtSCuenta1.Text) = "" Then
            '    SC01 = "0"
            'Else
            '    SC01 = CInt(Trim(txtSCuenta1.Text))
            'End If

            'If Trim(txtSCuenta2.Text) = "" Then
            '    SC02 = "0"
            'Else
            '    SC02 = CInt(Trim(txtSCuenta2.Text))
            'End If

            'If Trim(txtSCuenta3.Text) = "" Then
            '    SC03 = "0"
            'Else
            '    SC03 = CInt(Trim(txtSCuenta3.Text))
            'End If

            'If Trim(txtSCuenta4.Text) = "" Then
            '    SC04 = "0"
            'Else
            '    SC04 = CInt(Trim(txtSCuenta4.Text))
            'End If

            'If Trim(txtSCuenta5.Text) = "" Then
            '    SC05 = "0"
            'Else
            '    SC05 = CInt(Trim(txtSCuenta5.Text))
            'End If

            'If Trim(txtSCuenta6.Text) = "" Then
            '    SC06 = "0"
            'Else
            '    SC06 = CInt(Trim(txtSCuenta6.Text))
            'End If

            'If Trim(txtSCuenta7.Text) = "" Then
            '    SC07 = "0"
            'Else
            '    SC07 = CInt(Trim(txtSCuenta7.Text))
            'End If

            'If Trim(txtSCuenta8.Text) = "" Then
            '    SC08 = "0"
            'Else
            '    SC08 = CInt(Trim(txtSCuenta8.Text))
            'End If

            'If Trim(txtSCuenta9.Text) = "" Then
            '    SC09 = "0"
            'Else
            '    SC09 = CInt(Trim(txtSCuenta9.Text))
            'End If

        End If

        Dim intGMT As Integer = IIf(IsNumeric(Mid(cbGMT.Text, 6, 2)), Mid(cbGMT.Text, 5, 1) & Mid(cbGMT.Text, 6, 2), 0)

        'intGMT = CDbl(Microsoft.VisualBasic.Left(IsNull(Me.cbGMT.SelectedItem, 0), 1) & _
        '            Microsoft.VisualBasic.Mid(IsNull(Me.cbGMT.SelectedItem, 0), 2, 2))

        'Exit Sub
        Try
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            If Nuevo = "SI" Then
                VB.SysContab.EmpresasDB.AddItem(txtNombre.Text, txtCiudad.Text, cbPais.Text, txtTelefono.Text, _
                txtContador.Text, mes, nudAnio.Value, Now.Date, _
                Mayor, SC01, SC02, SC03, SC04, SC05, SC06, SC07, SC08, SC09, _
                Me.cbMonedaBase.EditValue, Me.cbMonedaSalario.EditValue, Me.txtIva.EditValue, _
                Me.txtIRProductos.EditValue, Me.txtIRServicios.EditValue, Me.txtIRVentas.EditValue, Me.txtMontoIR.EditValue, _
                Me.txtInatec.EditValue, Me.txtPresPorcMin.EditValue, Me.txtFacturaDigitos.EditValue, Me.txtRequisaBodegaNumero.EditValue, ckMultiple.Checked, _
                Me.txtReciboDigitos.EditValue, Me.txtReciboNumero.EditValue, Me.txtOrdenVentaInicial.EditValue, _
                Me.txtCotizacionNumero.EditValue, Me.txtPedidoNumero.EditValue, _
                Me.txtOrdenCompraNumero.EditValue, Me.txtDevolucionClienteNumero.EditValue, _
                Me.txtDevolucionProveedorNumero.EditValue, Me.chkEspacio.Checked, _
                IIf(Me.cbBodegas.EditValue Is Nothing Or Me.cbBodegas.EditValue = "", "", Me.cbBodegas.EditValue), _
                intGMT, Me.cbPais.EditValue, IIf(IsNumeric(Me.txtNoDecimales.EditValue), CInt(Me.txtNoDecimales.EditValue), 2), ckLiquidacion.CheckState)

                'MsgBox("Los datos han sido guardados correctament", MsgBoxStyle.Information)
            Else
                VB.SysContab.EmpresasDB.Update(Registro, txtNombre.Text, txtCiudad.Text, cbPais.Text, txtTelefono.Text,
                txtContador.Text, mes, nudAnio.Value, Now.Date, Mayor, SC01, SC02, SC03,
                SC04, SC05, SC06, SC07, SC08, SC09, Me.cbMonedaBase.EditValue,
                Me.cbMonedaSalario.EditValue, Me.txtIva.EditValue, Me.txtIRProductos.EditValue,
                Me.txtIRServicios.EditValue, Me.txtIRVentas.EditValue, Me.txtMontoIR.EditValue, Me.txtInatec.EditValue,
                Me.txtPresPorcMin.EditValue, Me.txtFacturaDigitos.EditValue, Me.txtRequisaBodegaNumero.EditValue, ckMultiple.Checked,
                Me.txtReciboDigitos.EditValue, Me.txtReciboNumero.EditValue, Me.txtOrdenVentaInicial.EditValue,
                Me.txtCotizacionNumero.EditValue, Me.txtPedidoNumero.EditValue, Me.txtOrdenCompraNumero.EditValue,
                Me.txtDevolucionClienteNumero.EditValue, Me.txtDevolucionProveedorNumero.EditValue, Me.chkEspacio.Checked,
                IIf(Me.cbBodegas.EditValue Is Nothing Or Me.cbBodegas.EditValue = "", "", Me.cbBodegas.EditValue),
                intGMT, Me.cbPais.EditValue, IIf(IsNumeric(Me.txtNoDecimales.EditValue), CInt(Me.txtNoDecimales.EditValue), 2), ckLiquidacion.CheckState,
                txtLineas.EditValue, cbGMT.EditValue, cbRegion.EditValue, IIf(chkOC.Checked, 1, 0), IIf(chkValidar.Checked, 1, 0))


                My.Application.ChangeCulture(cbRegion.EditValue)
                'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)
            End If

            VB.SysContab.Rutinas.okTransaccion()
            'If Me.ckMultiple.Checked = False Then
            '    If MsgBox("Esta seguro que desea deshabilitar el modo de Series Multiples,  los numeros de factura seran eliminados", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '        GuardaDatos("delete from series where empr_codigo = " & EmpresaActual)
            '        Me.GroupBox4.Visible = False
            '    Else
            '        Me.GroupBox4.Visible = True
            '    End If
            'End If
            Close()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            VB.SysContab.Rutinas.ErrorTransaccion()
        End Try

    End Sub

    'Private Sub txtSCuenta1_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Trim(txtSCuenta1.Text) <> "" Then
    '        If CInt(txtSCuenta1.Text) <= CInt(txtMayor.Text) Then
    '            MsgBox("valor no valido")
    '            txtSCuenta1.Focus()
    '            Exit Sub
    '        End If

    '        etMascara.Text = ""
    '        For i = 1 To txtSCuenta1.Text
    '            etMascara.Text = etMascara.Text & "-"
    '            If i = txtMayor.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta1.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '        Next

    '    End If

    'End Sub

    'Private Sub txtSCuenta2_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Trim(txtSCuenta2.Text) <> "" Then
    '        If CInt(txtSCuenta2.Text) <= CInt(txtSCuenta1.Text) Then
    '            MsgBox("valor no valido")
    '            txtSCuenta2.Focus()
    '            Exit Sub
    '        End If

    '        etMascara.Text = ""
    '        For i = 1 To txtSCuenta2.Text
    '            etMascara.Text = etMascara.Text & "-"
    '            If i = txtMayor.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta1.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta2.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '        Next

    '    End If

    'End Sub

    'Private Sub txtSCuenta3_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Trim(txtSCuenta3.Text) <> "" Then
    '        If CInt(txtSCuenta3.Text) <= CInt(txtSCuenta2.Text) Then
    '            MsgBox("valor no valido")
    '            txtSCuenta3.Focus()
    '            Exit Sub

    '        End If

    '        etMascara.Text = ""
    '        For i = 1 To txtSCuenta3.Text
    '            etMascara.Text = etMascara.Text & "-"
    '            If i = txtMayor.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta1.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta2.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta3.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '        Next

    '    End If

    'End Sub

    'Private Sub txtSCuenta4_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Trim(txtSCuenta4.Text) <> "" Then
    '        If CInt(txtSCuenta4.Text) <= CInt(txtSCuenta3.Text) Then
    '            MsgBox("valor no valido")
    '            txtSCuenta4.Focus()
    '            Exit Sub

    '        End If

    '        etMascara.Text = ""
    '        For i = 1 To txtSCuenta4.Text
    '            etMascara.Text = etMascara.Text & "-"
    '            If i = txtMayor.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta1.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta2.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta3.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta4.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '        Next

    '    End If

    'End Sub

    'Private Sub txtSCuenta5_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Trim(txtSCuenta5.Text) <> "" Then
    '        If CInt(txtSCuenta5.Text) <= CInt(txtSCuenta4.Text) Then
    '            MsgBox("valor no valido")
    '            txtSCuenta5.Focus()
    '            Exit Sub
    '        End If

    '        etMascara.Text = ""
    '        For i = 1 To txtSCuenta5.Text
    '            etMascara.Text = etMascara.Text & "-"
    '            If i = txtMayor.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta1.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta2.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta3.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta4.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta5.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If
    '        Next

    '    End If

    'End Sub

    'Private Sub txtSCuenta6_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Trim(txtSCuenta6.Text) <> "" Then
    '        If CInt(txtSCuenta6.Text) <= CInt(txtSCuenta5.Text) Then
    '            MsgBox("valor no valido")
    '            txtSCuenta6.Focus()
    '            Exit Sub

    '        End If

    '        etMascara.Text = ""
    '        For i = 1 To txtSCuenta6.Text
    '            etMascara.Text = etMascara.Text & "-"
    '            If i = txtMayor.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta1.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta2.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta3.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta4.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta5.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta6.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If
    '        Next

    '    End If

    'End Sub

    'Private Sub txtSCuenta7_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Trim(txtSCuenta7.Text) <> "" Then
    '        If CInt(txtSCuenta7.Text) <= CInt(txtSCuenta6.Text) Then
    '            MsgBox("valor no valido")
    '            txtSCuenta7.Focus()
    '            Exit Sub
    '        End If

    '        etMascara.Text = ""
    '        For i = 1 To txtSCuenta7.Text
    '            etMascara.Text = etMascara.Text & "-"
    '            If i = txtMayor.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta1.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta2.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta3.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta4.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta5.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta6.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta7.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If
    '        Next

    '    End If

    'End Sub

    'Private Sub txtSCuenta8_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Trim(txtSCuenta8.Text) <> "" Then
    '        If CInt(txtSCuenta8.Text) <= CInt(txtSCuenta7.Text) Then
    '            MsgBox("valor no valido")
    '            txtSCuenta8.Focus()
    '            Exit Sub
    '        End If

    '        etMascara.Text = ""
    '        For i = 1 To txtSCuenta8.Text
    '            etMascara.Text = etMascara.Text & "-"
    '            If i = txtMayor.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta1.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta2.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta3.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta4.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta5.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta6.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta7.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta8.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If
    '        Next

    '    End If

    'End Sub

    'Private Sub txtSCuenta9_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Trim(txtSCuenta9.Text) <> "" Then
    '        If CInt(txtSCuenta9.Text) <= CInt(txtSCuenta8.Text) Then
    '            MsgBox("valor no valido")
    '            txtSCuenta9.Focus()
    '            Exit Sub
    '        End If

    '        etMascara.Text = ""
    '        For i = 1 To txtSCuenta9.Text
    '            etMascara.Text = etMascara.Text & "-"
    '            If i = txtMayor.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta1.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta2.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta3.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta4.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta5.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta6.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta7.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta8.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '            If i = txtSCuenta9.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If
    '        Next

    '    End If
    'End Sub

    ''Private Sub txtSCuenta1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSCuenta1.KeyPress
    ''    If Trim(txtMayor.Text) = "" Then
    ''        e.Handled = True
    ''        MsgBox("Debe introducir un valor en la SubCuenta Anterior", MsgBoxStyle.Information)
    ''        txtMayor.Focus()
    ''        txtMayor.SelectAll()
    ''        Exit Sub

    ''    End If

    ''    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    ''        If Not IsNumeric(e.KeyChar) Then
    ''            e.Handled = True
    ''        End If
    ''    End If

    ''End Sub

    'Private Sub txtMayor_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim i As Integer
    '    If Trim(txtSCuenta9.Text) <> "" Then
    '        If CInt(txtSCuenta9.Text) <= CInt(txtSCuenta8.Text) Then
    '            MsgBox("valor no valido")
    '            txtSCuenta9.Focus()
    '            Exit Sub
    '        End If

    '        etMascara.Text = ""
    '        For i = 1 To txtMayor.Text
    '            etMascara.Text = etMascara.Text & "-"
    '            If i = txtMayor.Text Then
    '                etMascara.Text = etMascara.Text & " "
    '            End If

    '        Next

    '    End If

    'End Sub

    'Private Sub txtSCuenta4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    etMascara.Text = ""

    'End Sub

    'Private Sub txtSCuenta3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    etMascara.Text = ""

    'End Sub

    'Private Sub txtSCuenta2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    etMascara.Text = ""

    'End Sub

    'Private Sub txtSCuenta1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    etMascara.Text = ""

    'End Sub

    'Private Sub txtMayor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    etMascara.Text = ""
    'End Sub

    'Private Sub txtSCuenta9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Trim(txtSCuenta8.Text) = "" Then
    '        e.Handled = True
    '        MsgBox("Debe introducir un valor en la SubCuenta Anterior", MsgBoxStyle.Information)
    '        txtSCuenta8.Focus()
    '        txtSCuenta8.SelectAll()
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '        If Not IsNumeric(e.KeyChar) Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtSCuenta8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Trim(txtSCuenta7.Text) = "" Then
    '        e.Handled = True
    '        MsgBox("Debe introducir un valor en la SubCuenta Anterior", MsgBoxStyle.Information)
    '        txtSCuenta7.Focus()
    '        txtSCuenta7.SelectAll()
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '        If Not IsNumeric(e.KeyChar) Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtSCuenta7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Trim(txtSCuenta6.Text) = "" Then
    '        e.Handled = True
    '        MsgBox("Debe introducir un valor en la SubCuenta Anterior", MsgBoxStyle.Information)
    '        txtSCuenta6.Focus()
    '        txtSCuenta6.SelectAll()
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '        If Not IsNumeric(e.KeyChar) Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtSCuenta6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Trim(txtSCuenta5.Text) = "" Then
    '        e.Handled = True
    '        MsgBox("Debe introducir un valor en la SubCuenta Anterior", MsgBoxStyle.Information)
    '        txtSCuenta5.Focus()
    '        txtSCuenta5.SelectAll()
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '        If Not IsNumeric(e.KeyChar) Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtSCuenta5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Trim(txtSCuenta4.Text) = "" Then
    '        e.Handled = True
    '        MsgBox("Debe introducir un valor en la SubCuenta Anterior", MsgBoxStyle.Information)
    '        txtSCuenta4.Focus()
    '        txtSCuenta4.SelectAll()
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '        If Not IsNumeric(e.KeyChar) Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtSCuenta4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Trim(txtSCuenta3.Text) = "" Then
    '        e.Handled = True
    '        MsgBox("Debe introducir un valor en la SubCuenta Anterior", MsgBoxStyle.Information)
    '        txtSCuenta3.Focus()
    '        txtSCuenta3.SelectAll()
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '        If Not IsNumeric(e.KeyChar) Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtSCuenta3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Trim(txtSCuenta2.Text) = "" Then
    '        e.Handled = True
    '        MsgBox("Debe introducir un valor en la SubCuenta Anterior", MsgBoxStyle.Information)
    '        txtSCuenta2.Focus()
    '        txtSCuenta2.SelectAll()
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '        If Not IsNumeric(e.KeyChar) Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtSCuenta2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Trim(txtSCuenta1.Text) = "" Then
    '        e.Handled = True
    '        MsgBox("Debe introducir un valor en la SubCuenta Anterior", MsgBoxStyle.Information)
    '        txtSCuenta1.Focus()
    '        txtSCuenta1.SelectAll()
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '        If Not IsNumeric(e.KeyChar) Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtSCuenta1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Trim(Me.txtMayor.Text) = "" Then
    '        e.Handled = True
    '        MsgBox("Debe introducir un valor en la SubCuenta Anterior", MsgBoxStyle.Information)
    '        Me.txtMayor.Focus()
    '        Me.txtMayor.SelectAll()
    '        Exit Sub
    '    End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '        If Not IsNumeric(e.KeyChar) Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtMayor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    'If Trim(Me.txtMayor.Text) = "" Then
    '    '    e.Handled = True
    '    '    MsgBox("Debe introducir un valor en la SubCuenta Anterior", MsgBoxStyle.Information)
    '    '    Me.txtMayor.Focus()
    '    '    Me.txtMayor.SelectAll()
    '    '    Exit Sub
    '    'End If

    '    If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
    '        If Not IsNumeric(e.KeyChar) Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click        
        Me.Close()
    End Sub

    'Private Sub nudMayor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudMayor.ValueChanged
    '    Me.nudSC1.Minimum = Me.nudMayor.Value + 1
    'End Sub

    'Private Sub nudSC1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSC1.ValueChanged
    '    Me.nudSC2.Minimum = Me.nudSC1.Value + 1
    'End Sub

    'Private Sub nudSC2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSC2.ValueChanged
    '    Me.nudSC3.Minimum = Me.nudSC2.Value + 1
    'End Sub

    'Private Sub nudSC3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSC3.ValueChanged
    '    Me.nudSC4.Minimum = Me.nudSC3.Value + 1
    'End Sub

    'Private Sub nudSC4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSC4.ValueChanged
    '    Me.nudSC5.Minimum = Me.nudSC4.Value + 1
    'End Sub

    'Private Sub nudSC5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSC5.ValueChanged
    '    Me.nudSC6.Minimum = Me.nudSC5.Value + 1
    'End Sub

    'Private Sub nudSC6_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSC6.ValueChanged
    '    Me.nudSC7.Minimum = Me.nudSC6.Value + 1
    'End Sub

    'Private Sub nudSC7_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSC7.ValueChanged
    '    Me.nudSC8.Minimum = Me.nudSC7.Value + 1
    'End Sub

    'Private Sub nudSC8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSC8.ValueChanged
    '    Me.nudSC9.Minimum = Me.nudSC8.Value + 1
    'End Sub

    ''Private Sub nudSC9_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudSC9.ValueChanged
    ''    Me.nudSC2.Minimum = Me.nudSC1.Value + 1
    ''End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Dim Datos As New ArrayList
        Dim Variables As New ArrayList
        Variables.Add("@Empresa")
        Variables.Add("@Serie")
        Variables.Add("@Factura")
        Datos.Add(EmpresaActual)
        Datos.Add(Me.txtSerie.Text)
        Datos.Add(Me.txtFactNum.Text)



        If ProcedureSave(Datos, Variables, "_SeriesAdd") = True Then
            Me.txtFactNum.Text = ""
            Me.txtSerie.Text = ""

        Else
            MsgBox("La serie ya existe. Por favor cambie el nombre e intente nuevamente")
        End If


        Me.GridControl1.DataSource = ObtieneDatos("select Serie, Factura from series WHERE empr_codigo = " & EmpresaActual)


    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click

        GuardaDatos("delete from series where empr_codigo = " & EmpresaActual & " AND serie = '" & Me.dgSeries.GetRowCellValue(dgSeries.FocusedRowHandle, dgSeries.Columns(0)) & "'")

        Me.GridControl1.DataSource = ObtieneDatos("select Serie, Factura from series WHERE empr_codigo = " & EmpresaActual)

    End Sub

    Private Sub ckMultiple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Nuevo = "NO" And ckMultiple.Checked = False Then
            If ckMultiple.CheckState = CheckState.Unchecked And ObtieneDatos("SELECT SeriesMultiples FROM Configuraciones WHERE Empresa=" & EmpresaActual).Rows(0).Item(0) = True Then
                If XtraMsg2("Esta seguro que desea deshabilitar el modo de Series Multiples?") Then
                    'GuardaDatos("DELETE FROM series WHERE empr_codigo = " & EmpresaActual)
                    'Me.Panel1.Visible = False
                End If
            Else
                'Me.GridControl1.DataSource = ObtieneDatos("SELECT Serie, Factura FROM series WHERE empr_codigo = " & EmpresaActual)
                ' Me.Panel1.Visible = False
            End If
        Else
            If ckMultiple.Checked = True Then
                'Me.GridControl1.DataSource = ObtieneDatos("SELECT Serie, Factura FROM series WHERE empr_codigo = " & EmpresaActual)
                'Me.Panel1.Visible = True
            Else
                'Me.Panel1.Visible = False
            End If
        End If
        'Me.GridControl1.DataSource = ObtieneDatos("SELECT Serie, Factura FROM series WHERE empr_codigo = " & EmpresaActual)
        'If Me.ckMultiple.Checked = True Then
        '    Me.GroupBox4.Visible = True
        'Else
        '    Me.GroupBox4.Visible = False
        'End If
        'Me.GridControl1.DataSource = ObtieneDatos("select Serie, Factura from series WHERE empr_codigo = " & EmpresaActual)
        'If Me.ckMultiple.Checked = True Then
        '    Me.GroupBox4.Visible = True
        'Else
        '    Me.GroupBox4.Visible = False
        'End If
    End Sub

    Private Sub txtMayor_EditValueChanged(sender As Object, e As EventArgs) Handles txtMayor.EditValueChanged, txtSCuenta1.EditValueChanged, _
                                                                                    txtSCuenta2.EditValueChanged, txtSCuenta3.EditValueChanged, _
                                                                                    txtSCuenta4.EditValueChanged, txtSCuenta5.EditValueChanged, _
                                                                                    txtSCuenta6.EditValueChanged, txtSCuenta7.EditValueChanged, _
                                                                                    txtSCuenta8.EditValueChanged, txtSCuenta9.EditValueChanged
        CuentaEjemplo()
    End Sub

    Sub CuentaEjemplo()
        Dim Mayor As String = "1"
        Dim s01 As String = "1"
        Dim s02 As String = "1"
        Dim s03 As String = "1"
        Dim s04 As String = "1"
        Dim s05 As String = "1"
        Dim s06 As String = "1"
        Dim s07 As String = "1"
        Dim s08 As String = "1"
        Dim s09 As String = "1"

        Try
            If chkEspacio.Checked Then
                lblCuenta.Text = "Ejemplo Cuenta: " & Mayor.PadRight(txtMayor.EditValue, "0") & _
                IIf(txtSCuenta1.EditValue = 0, "", " " & s01.PadLeft(Math.Abs(txtSCuenta1.EditValue - txtMayor.EditValue), "0")) & _
                IIf(txtSCuenta2.EditValue = 0, "", " " & s02.PadLeft(Math.Abs(txtSCuenta2.EditValue - txtSCuenta1.EditValue), "0")) & _
                IIf(txtSCuenta3.EditValue = 0, "", " " & s03.PadLeft(Math.Abs(txtSCuenta3.EditValue - txtSCuenta2.EditValue), "0")) & _
                IIf(txtSCuenta4.EditValue = 0, "", " " & s04.PadLeft(Math.Abs(txtSCuenta4.EditValue - txtSCuenta3.EditValue), "0")) & _
                IIf(txtSCuenta5.EditValue = 0, "", " " & s05.PadLeft(Math.Abs(txtSCuenta5.EditValue - txtSCuenta4.EditValue), "0")) & _
                IIf(txtSCuenta6.EditValue = 0, "", " " & s06.PadLeft(Math.Abs(txtSCuenta6.EditValue - txtSCuenta5.EditValue), "0")) & _
                IIf(txtSCuenta7.EditValue = 0, "", " " & s07.PadLeft(Math.Abs(txtSCuenta7.EditValue - txtSCuenta6.EditValue), "0")) & _
                IIf(txtSCuenta8.EditValue = 0, "", " " & s08.PadLeft(Math.Abs(txtSCuenta8.EditValue - txtSCuenta7.EditValue), "0")) & _
                IIf(txtSCuenta9.EditValue = 0, "", " " & s09.PadLeft(Math.Abs(txtSCuenta9.EditValue - txtSCuenta8.EditValue), "0"))
            Else
                lblCuenta.Text = "Ejemplo Cuenta: " & Mayor.PadRight(txtMayor.EditValue, "0") & _
                IIf(txtSCuenta1.EditValue = 0, "", s01.PadLeft(Math.Abs(txtSCuenta1.EditValue - txtMayor.EditValue), "0")) & _
                IIf(txtSCuenta2.EditValue = 0, "", s02.PadLeft(Math.Abs(txtSCuenta2.EditValue - txtSCuenta1.EditValue), "0")) & _
                IIf(txtSCuenta3.EditValue = 0, "", s03.PadLeft(Math.Abs(txtSCuenta3.EditValue - txtSCuenta2.EditValue), "0")) & _
                IIf(txtSCuenta4.EditValue = 0, "", s04.PadLeft(Math.Abs(txtSCuenta4.EditValue - txtSCuenta3.EditValue), "0")) & _
                IIf(txtSCuenta5.EditValue = 0, "", s05.PadLeft(Math.Abs(txtSCuenta5.EditValue - txtSCuenta4.EditValue), "0")) & _
                IIf(txtSCuenta6.EditValue = 0, "", s06.PadLeft(Math.Abs(txtSCuenta6.EditValue - txtSCuenta5.EditValue), "0")) & _
                IIf(txtSCuenta7.EditValue = 0, "", s07.PadLeft(Math.Abs(txtSCuenta7.EditValue - txtSCuenta6.EditValue), "0")) & _
                IIf(txtSCuenta8.EditValue = 0, "", s08.PadLeft(Math.Abs(txtSCuenta8.EditValue - txtSCuenta7.EditValue), "0")) & _
                IIf(txtSCuenta9.EditValue = 0, "", s09.PadLeft(Math.Abs(txtSCuenta9.EditValue - txtSCuenta8.EditValue), "0"))
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
