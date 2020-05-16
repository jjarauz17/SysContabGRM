Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Threading
Module Globales

    Public ClsDal As New LibraryClassCommonds.MY_LibraryClassCommonds.Cls_DAL

    Public WaitTitulo As String = "Cargando..."
    Public ContabilizarVenta As Integer = 0 '1 = Se Contabiliza, 0 = No se Contabiliza
    Public CierreDia As Date = Now.Date
    Public SucursalActual As Integer = 0

    Public PublishPrueba As Boolean = False

    'Oscar Valdivia 23 Abril 2009 Cambio para pagos recibo
    Public DT_Tarjetas As DataTable = Nothing
    Public DT_Cheques As DataTable = Nothing

    Public strOrdenPago As String = "Orden de Pago" 'RAMAC
    'Public strOrdenPago As String = "Facturas" 'Todos
    Public IVAAsumido As Boolean = True
    Public ObligarDistribucion As Boolean = True

    Public UserDetails As VB.SysContab.LoginDetailsDB

    Public Login As String = ""
    Public Password As String = ""
    Public Usuario_ID As String
    Public Usr_Rol As Integer
    Public Recurso As Integer = 0
    Public IdRecursoComp As Integer = 0
    Public EstiloActual As String
    Public Usr_Mail As String = ""
    Public Usr_Nombre As String = ""
    'SPublic ProductoVersion As String

    Public Inicio As Boolean

    Public Seleccionar As Boolean

    Public RegistroPlantilla As String

    Public Checked As Boolean

    Public FechaCobro As String
    Public Deposito As String
    Public Banco As String

    Public BuscarCombo As Boolean

    Public TipoFacturaCliente As String
    Public Fecha1 As String
    Public Fecha2 As String

    Public Usuario As String
    Public UPassword As String
    Public Server As String
    Public DBName As String

    Public ClienteFactura As String
    Public TipoAcumulado As String


    Public PvCodigo As String
    Public PvNombre As String

    Public TotalPedido As Double
    Public RegistroPedido As String

    Public TipoFactura As Integer 'Contado = 0, Crédito=1

    Public GuardarFactura As Boolean

    Public Round As String
    Public RoundP As String

    Public RegistroCotizacion As String
    Public FacturarCotizacion As Boolean

    Public QuincenaTrabajo As String
    Public Meses() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

    'Public TipoItem As String

    Public ProductoServicio As String 'Si es Producto o Servicio

    Public NoFactura As String
    Public NuevaFactura As String

    Public Cod_Cliente As String

    Public AgregarClienteQuick As Boolean

    'Public FormFacturacion As DataGridTextBoxCombo.frmFacturacionCliente = FormFacturacion
    'Public FormFacturacion As DataGridTextBoxCombo.frmFacturacionCliente = FormFacturacion.Instance
    'Public fp As DataGridTextBoxCombo.frmFacturacionCliente  = fp.Instance

    Public NombreCliente As String

    Public TipoItem As String 'Si es Producto o Servicio

    Public WithEvents tItem As New DataTable

    Public LeaveCommit As Boolean 'Para ejecutar o No el evento LeaveCommit

    Public DBConnFacturas As SqlConnection
    Public transaccionFacturas As SqlTransaction

    ''Public DBConnFacturasLineas As SqlConnection
    ''Public transaccionFacturasLineas As SqlTransaction

    ''Public DBConnExistencia As SqlConnection
    ''Public transaccionExistencia As SqlTransaction

    Public NumFilas As String

    Public Transaccion As String
    Public Recibo As String
    Public TotalEfectivo As Double
    Public TotalCheques As Double
    Public TotalTarjetas As Double
    Public TotalNotaDebito As Double
    Public CuentaNotaDebito As String

    Public TotalFactura As Double

    Public TotalGlobal As Double

    Public TotalTemporal As Double

    Public Cobros As Boolean

    Public TotalFacturaCliente As Double
    Public SubTotalFacturaCliente As Double
    Public SubTotalFacturaNoDescuentos As Double
    Public TotalDescuento As Double

    'Public Moneda As String

    Public Indice As Integer
    Public CodigoP As String = ""
    Public IndiceBanco As Integer

    'Public Acumulados(,) As Object
    Public Monto_Mes As New ArrayList(12)
    Public Debe As New ArrayList(12)
    Public Haber As New ArrayList(12)
    Public Saldo As New ArrayList(12)

    Public TipoGrupo As String
    Public Titulo As String
    Public TipoGrupoInv As String
    Public TituloInv As String
    Public Nuevo As String
    Public Registro As String
    Public RegistroCliente As String
    Public Registro1 As String

    Public RegistroOrden As String
    Public RegistroOrdenVer As String

    Public RegistroFacturaTemporal As String
    Public RegistroOrdenProceso As String
    Public LoadOrden As Boolean

    Public LoadFacturaTemporal As Boolean
    Public LoadOrdenProceso As Boolean
    Public LoadCotizacionCliente As Boolean

    Public CodGrupo As String
    Public NombreGrupo As String
    Public Opened As String

    Public Buscar As String
    Public TituloBuscar As String

    Public VendedorP As String
    Public NombreVendedorP As String
    Public ComisionP As String
    Public ComisionServicioP As String

    Public BancoP As String
    Public CatalogoBancosP As String
    Public Cod_CuentaP As String

    Public EmpresaActual As String
    Public NombreEmpresaActual As String
    Public MonedaBase As String

    Public DetalleGrupo As New VB.SysContab.GruposDetails
    Public DetalleGrupoInv As New VB.SysContab.Grupos_InventarioDetails
    'Public DetalleProveedor As New VB.SysContab.ProveedoresDetails
    Public DetalleZona As New VB.SysContab.ZonasDetails

    ''''''''''''''''''''''' Zona de Cambios Obligados para cada compilada''''''''''''''''''''
    Public TodosClientes As Integer = 1 'Para todos = 0; Para Almori = 1    
    Public Terraza As Boolean = True 'Para terraza = true (No exije subgrupo); Para todos = false 
    Public VendedorEx As Boolean = True 'Para HVM true (Exije Vendedor); Para todos = false 

    ''Para eppa 
    'Public ObligarDistribucion As Boolean = True
    'Public AbroparPedidos As Boolean = True     'Indica si se pedira Codigo de Aprobación en Los Peidos (False = No requiere Codigo de Aprobación)
    'Public IVAAsumido As Boolean = True
    'Public ChkProveedores As Boolean = True     'Indica si el proveedor deberá ser aprobado y Confirmado despues de ser Ingresado para su uso
    'Public AbrobarOrden As Boolean = True       'Indica si se pedira Codigo de Aprobación en las Ordenes

    ' Para el resto
    Public AbroparPedidos As Boolean = True    'Indica si se pedira Codigo de  Aprobación en Los Peidos (False = No requiere Codigo de Aprobación)
    Public ChkProveedores As Boolean = False     'Indica si el proveedor deberá ser aprobado y Confirmado despues de ser Ingresado para su uso
    Public AbrobarOrden As Boolean = False       'Indica si se pedira Codigo de Aprobación en las Ordenes

    'Public FormPrincipal As frmPrincipal = FormPrincipal.Instance
    'Public formtitulo As String = "Sys.Contab"
    Public formtitulo As String = My.Application.Info.ProductName.ToString



    'Public FormPrincipal As frmPrincipalFacturacion = FormPrincipal.Instance
    'Public FormTitulo As String = "STS.Factur"

    'Public FormPrincipal As frmPrincipalInventario = FormPrincipal.Instance
    'Public FormTitulo As String = "STS.Invent"

    'Public FormPrincipal As frmContabilidadFULL = FormPrincipal.Instance
    'Public FormTitulo As String = "STS.Contab"

    '    Public FormPrincipal As frmPrincipalPyme = FormPrincipal.Instance
    'Public FormTitulo As String = "STS.Contab-PYME"

    '******************El siguiente codigo es de los modulos cortos.*******************
    '***Solo hay que desactivar uno de los FormTitluo de arriba y activar el deseado***
    'Public FormPrincipal As frmPrincipalCortos = FormPrincipal.Instance
    'Public FormTitulo As String = "STS.Factur-Caja" 'Modulo Caja
    'Public FormTitulo As String = "STS.Factur-Ordenes" 'Modulo Ordenes
    'Public FormTitulo As String = "STS.Factur-Almacen" 'Modulo Alamcen
    'Public FormTitulo As String = "STS.Contab-Tesorería" 'Modulo Tesoreria
    'Public FormTitulo As String = "STS.Contab-Adquiciciones" 'Modulo Adquiciciones
    'Public FormTitulo As String = "STS.Contab-Auxiliar Contabilidad" 'Modulo Contab
    'Public FormTitulo As String = "STS.Contab-Contador" 'Modulo Contador

    ''''''''''''''''''''''' Zona de Cambios Obligados para cada compilada''''''''''''''''''''

    'Abrir una vez un form MDI
    '    En el MDI (frmPrincipal)
    'Private Sub mnuBusqueda_Click(ByVal sender As System.Object, ByVal e As 
    'System.EventArgs) Handles mnuBusqueda.Click
    '        Me.mnuBusqueda.Enabled = False
    '        Dim lofrmBusqueda As New frmBusqueda()
    '        lofrmBusqueda.MdiParent = Me
    '        lofrmBusqueda.Show()
    '    End Sub

    'En el Hijo del MDI
    'Private Sub frmBusqueda_Closed(ByVal sender As Object, ByVal e As 
    'System.EventArgs) Handles MyBase.Closed
    '        CType(Me.MdiParent, frmPrincipal).mnuBusqueda.Enabled = True
    '    End Sub

    Public Enum ServiciosBasicos
        Agua = 1
        Energia = 2
        Telefono = 3
        Celular = 4
        TVCable = 5
        Basura = 6
    End Enum

    Public Enum ServiciosRecurrentes
        ALQUILER_INMUEBLES = 7
        SUBSCRIPCIONES = 8
        SEGUROS_GENERALES = 9
        SEGUROS_MEDICOS = 10
        VIAJES_HOSPEDAJE = 11
        COMIDAS = 12
        MTTO_EDIFICIO = 13
        MTTO_VEHICULAR = 14
        MTTO_EQUIPOS = 15
        COMBUSTIBLES = 16
    End Enum

    Public Enum OrigenComprobantes
        DEFECTO = 0
        NATURAL = 1
        ACTIVO_FIJO = 2
        CHEQUE = 3
        NOTA_CREDITO = 4
        DEVOLUCION_CLIENTE = 5
        DEVOLUCION_PROVEEDOR = 6
        ORDEN_DE_PAGO = 7
        VENTAS = 8
        ENTRADA_ALMACEN = 9
        OTROS_INGRESOS = 10
        CIERRE_PERIODO_FISCAL = 11
        PLANILLA = 12
        INVENTARIO = 13
        RECIBO = 14
        CHEQUE_DIRECTO = 15
        NOTA_DEBITO = 16
        AMORTIZACION = 17
        CAJA_CHICA = 18
        IMPORTADO = 19
        RENDICION_CUENTA = 20
        PROYECTOS_COSTOS = 21
        ANTICIPO_CLIENTES = 22
        NC_CLIENTE = 23
        ND_CLIENTE = 24
        ND_PROVEEDOR = 25
        NC_PROVEEDOR = 26
        NC_ELECTRONICA = 27
        IR_ANUAL = 28
        NC_DEVOLUCION = 29
        NC_ANTICIPO = 30
    End Enum
    Public Enum TipoProveedor
        Juridico = 1
        Natural = 2
    End Enum

    Public Enum Longitud_Linea_Archivos
        SAIRI = 371
        BAC = 122
    End Enum

    'Sub Main()
    '    DevExpress.UserSkins.BonusSkins.Register()
    '    DevExpress.Skins.SkinManager.EnableFormSkins()
    '    DevExpress.Skins.SkinManager.EnableMdiFormSkins()

    '    Dim Login As New FrmLogin2008
    '    Login.ShowDialog()
    'End Sub
End Module
