Imports System
Imports System.Data
Imports ClasesBLL
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Xml
Imports System.Text
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.BarCode

Namespace VB.SysContab

    Public Class FacturasDetails
        Public Numero As String
        Public Factura As String
        Public Fecha As String
        Public CodigoCliente As String
        Public Ruc As String

        Public Monto As String
        Public SubTotal As String
        Public DescuentoP As String
        Public DescuentoC As String
        Public IvaP As String
        Public IvaC As String
        Public RecargoP As String
        Public RecargoC As String
        Public OtrosP As String
        Public OtrosC As String
        Public Total As String

        Public Saldo As String
        Public FormaPago As String
        Public Vendedor As String
        Public ComisionP As String
        Public ComisionC As String
        Public FechaCancelar As String
        Public FechaVencimiento As String
        Public Tipo As String
        Public Mon_mtto As String

    End Class
    Public Class Facturas_VentasDB
        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 04/Abril/2007
        'Objetivo: Obtiene la Lista de Facturas Pendientes
        '*******************************************************

        Public Function GetListFacturasPendientes(ByVal Fecha As String, ByVal Todos As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasVentasGetListxFechaCredito", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha)

            Dim _Todos As SqlParameter = New SqlParameter("@Todos", SqlDbType.Int)
            _Todos.Value = Todos
            DBCommand.SelectCommand.Parameters.Add(_Todos)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function
        Public Function AlcaldiaImpuestos(ByVal Mes As String, ByVal Year As Integer, ByVal Impuesto As Double) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_AlcaldiaImpuestos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Mes As SqlParameter = New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Dim _Year As SqlParameter = New SqlParameter("@Year", SqlDbType.Int)
            _Year.Value = Year
            DBCommand.SelectCommand.Parameters.Add(_Year)

            Dim _Impuesto As SqlParameter = New SqlParameter("@Impuesto", SqlDbType.Int)
            _Impuesto.Value = Impuesto
            DBCommand.SelectCommand.Parameters.Add(_Impuesto)

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function IVA(ByVal Mes As String, ByVal FechaIni As String, _
                                       ByVal FechaFin As String, ByVal EmpresaActual As String, _
                                       ByVal MontoIR As String, ByVal IRProd As String, ByVal IRServ As String, _
                                       ByVal MesAnterior As String, ByVal IRVentas As String) As DataSet

            Dim r As New VB.SysContab.Rutinas
            Dim DBconn As SqlConnection = New SqlConnection(Rutinas.AbrirConexion)
            Dim DBCommand As SqlDataAdapter
            Dim DBCommand2 As SqlDataAdapter
            Dim dsFicha As New DataSet

            DBCommand2 = New SqlDataAdapter("_FacturasVentasIVARep", DBconn)

            DBCommand2.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa2.Value = EmpresaActual
            DBCommand2.SelectCommand.Parameters.Add(pEmpresa2)

            Dim _FechaIni2 As New SqlParameter("@FechaIni", SqlDbType.NVarChar, 50)
            _FechaIni2.Value = FechaIni
            DBCommand2.SelectCommand.Parameters.Add(_FechaIni2)

            Dim _FechaFin2 As New SqlParameter("@FechaFin", SqlDbType.NVarChar, 50)
            _FechaFin2.Value = FechaFin
            DBCommand2.SelectCommand.Parameters.Add(_FechaFin2)


            Dim pMes2 As New SqlParameter("@Mes", SqlDbType.Int)
            pMes2.Value = Mes
            DBCommand2.SelectCommand.Parameters.Add(pMes2)

            'Dim _IRVentas As New SqlParameter("@IRVentas", SqlDbType.NVarChar, 50)
            '_IRVentas.Value = IRVentas
            'DBCommand2.SelectCommand.Parameters.Add(_IRVentas)

            DBCommand2.Fill(dsFicha, "_FacturasVentasIVARep;1")

            DBconn.Close()


            DBCommand = New SqlDataAdapter("_FacturasComprasIVArep", DBconn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            pMes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(pMes)

            Dim _FechaIni As New SqlParameter("@FechaIni", SqlDbType.NVarChar, 50)
            _FechaIni.Value = FechaIni
            DBCommand.SelectCommand.Parameters.Add(_FechaIni)

            Dim _FechaFin As New SqlParameter("@FechaFin", SqlDbType.NVarChar, 50)
            _FechaFin.Value = FechaFin
            DBCommand.SelectCommand.Parameters.Add(_FechaFin)

            Dim _MesAnterior As New SqlParameter("@MesAnterior", SqlDbType.NVarChar, 50)
            _MesAnterior.Value = MesAnterior
            DBCommand.SelectCommand.Parameters.Add(_MesAnterior)

            DBCommand.Fill(dsFicha, "_FacturasComprasIVArep;1")

            DBconn.Close()

            Return dsFicha

        End Function

        Public Shared Function IR(ByVal Mes As String, ByVal FechaIni As String, _
                                        ByVal FechaFin As String, ByVal EmpresaActual As String, _
                                        ByVal MontoIR As String, ByVal IRProd As String, ByVal IRServ As String, _
                                        ByVal MesAnterior As String, ByVal IRVentas As String) As DataSet

            Dim r As New VB.SysContab.Rutinas
            Dim DBconn As SqlConnection = New SqlConnection(Rutinas.AbrirConexion)
            Dim DBCommand As SqlDataAdapter
            Dim DBCommand2 As SqlDataAdapter
            Dim dsFicha As New DataSet

            DBCommand2 = New SqlDataAdapter("_FacturasVentasIRRep", DBconn)

            DBCommand2.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa2.Value = EmpresaActual
            DBCommand2.SelectCommand.Parameters.Add(pEmpresa2)

            Dim _FechaIni2 As New SqlParameter("@FechaIni", SqlDbType.NVarChar, 50)
            _FechaIni2.Value = FechaIni
            DBCommand2.SelectCommand.Parameters.Add(_FechaIni2)

            Dim _FechaFin2 As New SqlParameter("@FechaFin", SqlDbType.NVarChar, 50)
            _FechaFin2.Value = FechaFin
            DBCommand2.SelectCommand.Parameters.Add(_FechaFin2)


            Dim pMes2 As New SqlParameter("@Mes", SqlDbType.Int)
            pMes2.Value = Mes
            DBCommand2.SelectCommand.Parameters.Add(pMes2)

            Dim _IRVentas As New SqlParameter("@IRVentas", SqlDbType.NVarChar, 50)
            _IRVentas.Value = IRVentas
            DBCommand2.SelectCommand.Parameters.Add(_IRVentas)

            Dim _IRProd2 As New SqlParameter("@IRProd", SqlDbType.NVarChar, 50)
            _IRProd2.Value = IRProd
            DBCommand2.SelectCommand.Parameters.Add(_IRProd2)

            Dim _MontoIR2 As New SqlParameter("@MontoIR", SqlDbType.NVarChar, 50)
            _MontoIR2.Value = MontoIR
            DBCommand2.SelectCommand.Parameters.Add(_MontoIR2)

            Try
                DBCommand2.Fill(dsFicha, "_FacturasVentasIRRep;1")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBconn.Close()


            DBCommand = New SqlDataAdapter("_FacturasComprasIRrep", DBconn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            pMes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(pMes)

            Dim _FechaIni As New SqlParameter("@FechaIni", SqlDbType.NVarChar, 50)
            _FechaIni.Value = FechaIni
            DBCommand.SelectCommand.Parameters.Add(_FechaIni)

            Dim _FechaFin As New SqlParameter("@FechaFin", SqlDbType.NVarChar, 50)
            _FechaFin.Value = FechaFin
            DBCommand.SelectCommand.Parameters.Add(_FechaFin)

            Dim _MontoIR As New SqlParameter("@MontoIR", SqlDbType.NVarChar, 50)
            _MontoIR.Value = MontoIR
            DBCommand.SelectCommand.Parameters.Add(_MontoIR)

            Dim _IRProd As New SqlParameter("@IRProd", SqlDbType.NVarChar, 50)
            _IRProd.Value = IRProd
            DBCommand.SelectCommand.Parameters.Add(_IRProd)

            Dim _IRServ As New SqlParameter("@IRServ", SqlDbType.NVarChar, 50)
            _IRServ.Value = IRServ
            DBCommand.SelectCommand.Parameters.Add(_IRServ)

            Dim _MesAnterior As New SqlParameter("@MesAnterior", SqlDbType.Float)
            _MesAnterior.Value = MesAnterior
            DBCommand.SelectCommand.Parameters.Add(_MesAnterior)

            Try
                DBCommand.Fill(dsFicha, "_FacturasComprasIRrep;1")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBconn.Close()
            Return dsFicha

        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 7/Julio/2006
        'Objetivo: Imprimir la Factura
        '*******************************************************
        Public Function GetImprimirFact(ByVal Factura As String, ByVal VerNombre As Boolean) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasVentasFormulario", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar)
            _Factura.Value = Factura
            DBCommand.SelectCommand.Parameters.Add(_Factura)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 8/Marzo/2006
        'Objetivo: Regresa IVA de las Facturas Ventas
        '*******************************************************

        Public Function GetIRVentas(ByVal FechaINI As String, ByVal FechaFIN As String, _
                                    ByVal Mes As String, ByVal TipoProd As Integer, ByVal IRVentas As String, ByVal Year As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasVentasIR", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _TipoProd As SqlParameter = New SqlParameter("@TipoProd", SqlDbType.Int) ' 0 Todos 1 Productos 2 Servicios
            _TipoProd.Value = TipoProd
            DBCommand.SelectCommand.Parameters.Add(_TipoProd)

            If FechaINI <> "" And FechaFIN <> "" Then
                Dim _FechaINI As SqlParameter = New SqlParameter("@FechaINI", SqlDbType.DateTime)
                _FechaINI.Value = FechaINI
                DBCommand.SelectCommand.Parameters.Add(_FechaINI)

                Dim _FechaFIN As SqlParameter = New SqlParameter("@FechaFIN", SqlDbType.DateTime)
                _FechaFIN.Value = FechaFIN
                DBCommand.SelectCommand.Parameters.Add(_FechaFIN)

            Else
                Dim _FechaINI As SqlParameter = New SqlParameter("@FechaINI", SqlDbType.NVarChar)
                _FechaINI.Value = FechaINI
                DBCommand.SelectCommand.Parameters.Add(_FechaINI)

                Dim _FechaFIN As SqlParameter = New SqlParameter("@FechaFIN", SqlDbType.NVarChar)
                _FechaFIN.Value = FechaFIN
                DBCommand.SelectCommand.Parameters.Add(_FechaFIN)

            End If

            Dim _Mes As SqlParameter = New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Dim _IRVentas As SqlParameter = New SqlParameter("@IRVentas", SqlDbType.Float)
            _IRVentas.Value = IRVentas
            DBCommand.SelectCommand.Parameters.Add(_IRVentas)

            Dim _Year As SqlParameter = New SqlParameter("@Year", SqlDbType.Int)
            _Year.Value = Year
            DBCommand.SelectCommand.Parameters.Add(_Year)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function


        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 3/Marzo/2006
        'Objetivo: Regresa la lista de Facturas de Ventas
        '*******************************************************

        Public Function GetFacturasDetalles(ByVal FechaINI As String, ByVal FechaFIN As String, ByVal Mes As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasVentasListxFecha", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            If FechaINI <> "" And FechaFIN <> "" Then

                Dim _FechaINI As SqlParameter = New SqlParameter("@FechaINI", SqlDbType.DateTime)
                _FechaINI.Value = FechaINI
                DBCommand.SelectCommand.Parameters.Add(_FechaINI)

                Dim _FechaFIN As SqlParameter = New SqlParameter("@FechaFIN", SqlDbType.DateTime)
                _FechaFIN.Value = FechaFIN
                DBCommand.SelectCommand.Parameters.Add(_FechaFIN)

            Else
                Dim _FechaINI As SqlParameter = New SqlParameter("@FechaINI", SqlDbType.NVarChar)
                _FechaINI.Value = FechaINI
                DBCommand.SelectCommand.Parameters.Add(_FechaINI)

                Dim _FechaFIN As SqlParameter = New SqlParameter("@FechaFIN", SqlDbType.NVarChar)
                _FechaFIN.Value = FechaFIN
                DBCommand.SelectCommand.Parameters.Add(_FechaFIN)

            End If

            Dim _Mes As SqlParameter = New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function



        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 3/Marzo/2006
        'Objetivo: Regresa IVA de las Facturas Ventas
        '*******************************************************

        Public Function GetIVAxTipo(ByVal FechaINI As String, ByVal FechaFIN As String, ByVal Mes As String, ByVal TipoProd As Integer, ByVal Year As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasVentasIVA", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _TipoProd As SqlParameter = New SqlParameter("@TipoProd", SqlDbType.Int) ' 0 Todos 1 Productos 2 Servicios
            _TipoProd.Value = TipoProd
            DBCommand.SelectCommand.Parameters.Add(_TipoProd)

            If FechaINI <> "" And FechaFIN <> "" Then

                Dim _FechaINI As SqlParameter = New SqlParameter("@FechaINI", SqlDbType.DateTime)
                _FechaINI.Value = FechaINI
                DBCommand.SelectCommand.Parameters.Add(_FechaINI)

                Dim _FechaFIN As SqlParameter = New SqlParameter("@FechaFIN", SqlDbType.DateTime)
                _FechaFIN.Value = FechaFIN
                DBCommand.SelectCommand.Parameters.Add(_FechaFIN)

            Else
                Dim _FechaINI As SqlParameter = New SqlParameter("@FechaINI", SqlDbType.NVarChar)
                _FechaINI.Value = FechaINI
                DBCommand.SelectCommand.Parameters.Add(_FechaINI)

                Dim _FechaFIN As SqlParameter = New SqlParameter("@FechaFIN", SqlDbType.NVarChar)
                _FechaFIN.Value = FechaFIN
                DBCommand.SelectCommand.Parameters.Add(_FechaFIN)

            End If

            Dim _Mes As SqlParameter = New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Dim _Year As SqlParameter = New SqlParameter("@Year", SqlDbType.Int)
            _Year.Value = Year
            DBCommand.SelectCommand.Parameters.Add(_Year)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 1/Marzo/2006
        'Objetivo: Regresa la lista de Facturas de Credito
        '*******************************************************

        Public Function GetListCredito(ByVal Fecha As String, ByVal Todos As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasVentasGetListxFechaCredito", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha)

            Dim _Todos As SqlParameter = New SqlParameter("@Todos", SqlDbType.Int)
            _Todos.Value = Todos
            DBCommand.SelectCommand.Parameters.Add(_Todos)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 20/Febrero/2006
        'Objetivo: Regresa la lista de Facturas de una Fecha
        '*******************************************************

        Public Function GetListContado(ByVal Fecha As String, ByVal Todos As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasVentasGetListxFecha", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha)

            Dim _Todos As SqlParameter = New SqlParameter("@Todos", SqlDbType.Int)
            _Todos.Value = Todos
            DBCommand.SelectCommand.Parameters.Add(_Todos)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetFacturasDetails(ByVal Codigo As String) As FacturasDetails


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFacturas_Ventas As New DataSet
            Dim Details As New FacturasDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Facturas_Ventas WHERE Factura = '" & Codigo & "' And Empresa = '" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsFacturas_Ventas, "Facturas_Ventas")

            If dsFacturas_Ventas.Tables("Facturas_Ventas").Rows.Count = 1 Then
                Details.Numero = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Numero").ToString
                Details.Factura = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Factura").ToString
                Details.Fecha = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Fecha").ToString
                Details.CodigoCliente = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Cliente").ToString
                Details.Ruc = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Ruc").ToString
                Details.Monto = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Monto").ToString
                Details.SubTotal = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("SubTotal").ToString
                Details.DescuentoP = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Descuento").ToString

                Details.IvaP = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Iva").ToString

                Details.RecargoP = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Recargo").ToString

                Details.OtrosP = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Otros").ToString

                Details.Total = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Total").ToString
                Details.Saldo = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Saldo").ToString
                Details.FormaPago = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Tipo_Factura").ToString
                Details.Vendedor = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Vendedor").ToString

                Details.FechaCancelar = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Fecha_Pago").ToString
                Details.FechaVencimiento = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Fecha_Vencimiento").ToString
                Details.Tipo = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("Tipo").ToString
                Details.Mon_mtto = dsFacturas_Ventas.Tables("Facturas_Ventas").Rows(0).Item("mon_mtto")
            End If

            Return Details
        End Function

        Public Shared Function GetCobrosPendientes(IdCliente As Integer, FechaCobro As Date) As DataTable

            Return ObtieneDatos("SP_GetListFacturasXCliente", IdCliente, EmpresaActual, FechaCobro)

        End Function

        Public Shared Function GetCobrosPendientesAnticipos(IdCliente As Integer, FechaCobro As Date) As DataTable

            Return ObtieneDatos("SP_GetListFacturasXClienteAnticipo",
                                IdCliente,
                                EmpresaActual,
                                FechaCobro)


        End Function

        Public Shared Function SaveLineasDetalle(Factura As String, Fecha As Date, _DT_NEW As DataTable) As Boolean

            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
            Conn.IniciarTransaccion()
            '
            Try
                Conn.RemoveParameters()
                Conn.AddParameter("Factura", SqlDbType.NVarChar, 50, ParameterDirection.Input, Factura)
                Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Fecha.Date)
                Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("DT_FACTURA", SqlDbType.Structured, 0, ParameterDirection.Input, _DT_NEW)

                Conn.EjecutarComando("sp_ins_FACTURAS_VENTAS_LINEAS")
                Conn.CompletarTransaccion()

                Return True
            Catch ex As Exception
                Conn.AnularTransaccion()
                XtraMsg("Error al Guardar Nuevos Registros a la Factura: " & vbCrLf & ex.Message, MessageBoxIcon.Error)
                Return False
            End Try

        End Function

        Public Shared Function UpdateLineasDetalle(Factura As String, Fecha As Date, _DT_UPD As DataTable) As Boolean

            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
            Conn.IniciarTransaccion()
            '
            Try
                Conn.RemoveParameters()
                Conn.AddParameter("Factura", SqlDbType.NVarChar, 50, ParameterDirection.Input, Factura)
                Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Fecha.Date)
                Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("DT_FACTURA", SqlDbType.Structured, 0, ParameterDirection.Input, _DT_UPD)

                Conn.EjecutarComando("sp_upd_FACTURAS_VENTAS_LINEAS")
                Conn.CompletarTransaccion()

                Return True
            Catch ex As Exception
                Conn.AnularTransaccion()
                XtraMsg("Error al Actualizar Registros a la Factura: " & vbCrLf & ex.Message, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Public Shared Function DeleteLineasDetalle(IdDetalle As Double, Factura As String) As Boolean

            Return Guardar("sp_del_FACTURAS_VENTAS_LINEAS", IdDetalle,
                           Factura,
                           EmpresaActual)


        End Function

        Public Shared Function UpdateTotales(Factura As String) As Boolean

            Return Guardar("sp_upd_FACTURAS_VENTAS_Totales", Factura,
                           EmpresaActual)

        End Function

        Public Shared Function ListaDetalle(Factura As String) As DataTable

            Return ObtieneDatos("sp_sel_FACTURAS_VENTAS_LINEAS",
                                Factura,
                                EmpresaActual)

        End Function


        Public Shared Function CreateQRCodeBarCode(ByVal BarCodeText As String) As XRBarCode
            ' Create a bar code control.
            Dim barCode As New XRBarCode()

            ' Set the bar code's type to QRCode.
            barCode.Symbology = New QRCodeGenerator()

            ' Adjust the bar code's main properties.
            barCode.Text = BarCodeText
            barCode.Width = 400
            barCode.Height = 150

            ' If the AutoModule property is set to false, uncomment the next line.
            barCode.AutoModule = True
            ' barcode.Module = 3;

            ' Adjust the properties specific to the bar code type.
            CType(barCode.Symbology, QRCodeGenerator).CompactionMode = QRCodeCompactionMode.AlphaNumeric
            CType(barCode.Symbology, QRCodeGenerator).ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.H
            CType(barCode.Symbology, QRCodeGenerator).Version = QRCodeVersion.AutoVersion

            Return barCode
        End Function


        Public Shared Sub ImprimirFactura2(Factura As String, Formato As Integer, Optional VistaPrevia As Boolean = False)

            ShowSplash("Imprimiendo...")

            Dim Temp As Boolean = False

            Try
                Dim Data() As Byte = CType(db_TipoFacturas.Listar(Formato).Rows.Item(0)("Formato"), Byte())

                Temp = True
                Dim Tamano As Integer = 0
                Tamano = Data.GetUpperBound(0)

                Dim Cadena As String = Application.StartupPath & "\rptFormato.repx"

                If File.Exists(Cadena) Then Kill(Cadena)
                Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
                Archivo.Write(Data, 0, Tamano)
                Archivo.Close()

            Catch ex As Exception
                Temp = False
            End Try

            Dim rpt As RptFacturaNew

            If Not Temp Then
                rpt = New RptFacturaNew
            Else
                rpt = XtraReport.FromFile(Application.StartupPath & "\rptFormato.repx", True)
            End If
            '
            If VistaPrevia Then
                VistaPreviaDX(rpt,
                 ObtieneDatos("sp_GetRptFacturaTemporal", EmpresaActual),
                  "Factura No. " & Factura)
            Else
                VistaPreviaDX(rpt,
                  ObtieneDatos("sp_GetRptFacturaCredito", EmpresaActual, Factura, 0.00),
                  "Factura No. " & Factura)
            End If

            '
            HideSplash()

        End Sub

        Public Shared Sub ImprimirFactura(Factura As String, DiasPago As Integer, Optional VistaPrevia As Boolean = False)

            ShowSplash("Imprimiendo...")

            Dim Temp As Boolean = False

            If DiasPago = 0 Then  '' Factura de Contado
                Temp = db_Formatos.FormatoImpreso(2, "RptFactura")
            Else    ' Factura de Credito
                Temp = db_Formatos.FormatoImpreso(9, "RptFacturaCredito")
            End If
            '
            Dim Rep As XtraReport

            If Temp = True Then
                If DiasPago = 0 Then '' Factura de Contado
                    Rep = XtraReport.FromFile(Application.StartupPath & "\RptFactura.repx", True)
                Else    ' Factura de Credito
                    Rep = XtraReport.FromFile(Application.StartupPath & "\RptFacturaCredito.repx", True)
                End If
            Else
                If DiasPago = 0 Then  '' Factura de Contado
                    Rep = New RptFacturaNew
                Else
                    Rep = New RptFacturaNewCredito
                End If
            End If
            '
            If VistaPrevia Then
                VistaPreviaDX(Rep,
                ObtieneDatos("sp_GetRptFacturaTemporal", EmpresaActual),
                 "Factura No. " & Factura)
            Else
                If DiasPago = 0 Then  '' Factura de Contado
                    VistaPreviaDX(Rep,
                                  ObtieneDatos("sp_GetRptFacturaContado", EmpresaActual, Factura, 0.00),
                                  "Factura No. " & Factura)
                    'Rep.DataSource = ObtieneDatos("sp_GetRptFacturaContado", EmpresaActual, Factura, 0.00)
                Else
                    VistaPreviaDX(Rep,
                                  ObtieneDatos("sp_GetRptFacturaCredito", EmpresaActual, Factura, 0.00),
                                  "Factura No. " & Factura)
                    'Rep.DataSource = ObtieneDatos("sp_GetRptFacturaCredito", EmpresaActual, Factura, 0.00)
                End If
            End If

            '
            HideSplash()

        End Sub

        Public Shared Function EnviarCorreoClienteFE(Factura As String,
                                                     Cliente As Integer,
                                                     Correo As String,
                                                     Formato As Integer,
                                                     Tipo As String) As Boolean

            Dim Temp As Boolean = False

            Try
                Dim Data() As Byte = CType(db_TipoFacturas.Listar(Formato).Rows.Item(0)("Formato"), Byte())

                Temp = True
                Dim Tamano As Integer = 0
                Tamano = Data.GetUpperBound(0)

                Dim Cadena As String = Application.StartupPath & "\rptFormato.repx"

                If File.Exists(Cadena) Then Kill(Cadena)
                Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
                Archivo.Write(Data, 0, Tamano)
                Archivo.Close()

            Catch ex As Exception
                Temp = False
            End Try
            '
            Try
                Dim rpt As New RptFacturaNew

                If Temp Then rpt = XtraReport.FromFile(Application.StartupPath & "\rptFormato.repx", True)
                rpt.DataSource = ObtieneDatos("sp_GetRptFacturaCredito", EmpresaActual, Factura)
                '
                Dim obj As IDP_FacturaElectronica = IDP_FacturaElectronicaToken.Detalles()
                Dim fvXml As New FacturaXML
                fvXml.Detalle(Factura, Tipo)
                '
                If IO.File.Exists(obj.DirectorioATV & "Enviados\FacturaElectronica_No_" & Factura & "_Clave_" & fvXml.ClaveNumerica & ".pdf") Then
                    IO.File.Delete(obj.DirectorioATV & "Enviados\FacturaElectronica_No_" & Factura & "_Clave_" & fvXml.ClaveNumerica & ".pdf")
                End If
                '
                rpt.ExportToPdf(obj.DirectorioATV & "Enviados\FacturaElectronica_No_" & Factura & "_Clave_" & fvXml.ClaveNumerica & ".pdf")
                '
                Dim attach1 As String = obj.DirectorioATV & "Enviados\FacturaElectronica_No_" & Factura & "_Clave_" & fvXml.ClaveNumerica & ".pdf"
                Dim attach2 As String = obj.DirectorioATV & fvXml.Consecutivo & "_XML_Firmado.xml"
                Dim attach3 As String = obj.DirectorioATV & fvXml.Consecutivo & "_05_RESP.xml"

                Return Guardar("sp_FacturaElectronicaEnviarMail",
                               Factura,
                               fvXml.ClaveNumerica,
                               Correo,
                               attach1,
                               attach2,
                               attach3,
                               EmpresaActual)

            Catch ex As Exception
                XtraMsg("Error al Crear PDF de Factura, el correo no se envió. Intenete Re-Enviarlo en unos minutos." & vbCrLf & ex.Message,
                        MessageBoxIcon.Error)
                Return False
            End Try

        End Function
        '
        Public Shared Function EnviarCorreoClienteNE(Factura As String,
                                                     NoNota As String,
                                                     Cliente As Integer,
                                                     Correo As String,
                                                     Tipo As String) As Boolean

            Try
                Dim Temp As Boolean = db_Formatos.FormatoImpreso(6, "rptFormato")

                Dim rpt As rptNotasProveedores

                If Temp = True Then
                    rpt = XtraReport.FromFile(Application.StartupPath & "\rptFormato.repx", True)
                Else
                    rpt = New rptNotasProveedores
                End If
                '
                If Temp Then rpt = XtraReport.FromFile(Application.StartupPath & "\rptFormato.repx", True)
                rpt.DataSource = ObtieneDatos("sp_NotaCreditoElectronicaImprimir",
                                              NoNota,
                                              EmpresaActual)
                '
                Dim obj As IDP_FacturaElectronica = IDP_FacturaElectronicaToken.Detalles()
                Dim fvXml As New FacturaXML
                fvXml.Detalle(
                    Factura,
                    Tipo)
                '
                If IO.File.Exists(obj.DirectorioATV & "Enviados\NotaCreditoElectronica_No_" & NoNota & "_Clave_" & fvXml.ClaveNumerica & ".pdf") Then
                    IO.File.Delete(obj.DirectorioATV & "Enviados\NotaCreditoElectronica_No_" & NoNota & "_Clave_" & fvXml.ClaveNumerica & ".pdf")
                End If
                '
                If IO.File.Exists(obj.DirectorioATV & fvXml.Consecutivo & "_XML_Firmado.xml") Then
                    IO.File.Delete(obj.DirectorioATV & fvXml.Consecutivo & "_XML_Firmado.xml")
                End If
                '
                If IO.File.Exists(obj.DirectorioATV & fvXml.Consecutivo & "_05_RESP.xml") Then
                    IO.File.Delete(obj.DirectorioATV & fvXml.Consecutivo & "_05_RESP.xml")
                End If

                Dim XmlFirma As New Xml.XmlDocument
                XmlFirma.LoadXml(fvXml.XmlFirmado)

                Dim XmlRest As New Xml.XmlDocument
                XmlRest.LoadXml(fvXml.XmlRespuesta)

                XmlFirma.Save(obj.DirectorioATV & fvXml.Consecutivo & "_XML_Firmado.xml")
                XmlRest.Save(obj.DirectorioATV & fvXml.Consecutivo & "_05_RESP.xml")

                rpt.ExportToPdf(obj.DirectorioATV & "Enviados\NotaCreditoElectronica_No_" & NoNota & "_Clave_" & fvXml.ClaveNumerica & ".pdf")
                '
                Dim attach1 As String = obj.DirectorioATV & "Enviados\NotaCreditoElectronica_No_" & NoNota & "_Clave_" & fvXml.ClaveNumerica & ".pdf"
                Dim attach2 As String = obj.DirectorioATV & fvXml.Consecutivo & "_XML_Firmado.xml"
                Dim attach3 As String = obj.DirectorioATV & fvXml.Consecutivo & "_05_RESP.xml"

                Return Guardar("sp_NotaCreditoElectronicaEnviarMail",
                               Factura,
                               fvXml.ClaveNumerica,
                               Correo,
                               attach1,
                               attach2,
                               attach3,
                               EmpresaActual)

            Catch ex As Exception
                XtraMsg("Error al Crear PDF de la Nota de Crédito, el correo no se envió. Intenete Re-Enviarlo en unos minutos." & vbCrLf & ex.Message,
                        MessageBoxIcon.Error)
                Return False
            End Try

        End Function


        Public Shared Function BorrarNotaCreditoElectronica(NoFactura As String) As Boolean

            Return Guardar("sp_BorrarDevolucionElectronica",
                           NoFactura,
                           EmpresaActual)

        End Function

        Public Shared Function BuscarFacturasNC(NoFactura As String) As Integer

            Return ObtieneDatos("sp_sel_FACTURAS_VENTAS_Buscar",
                           NoFactura,
                           EmpresaActual).Rows.Item(0)("Cantidad")

        End Function

        Public Shared Function BuscarDevolucionNC(IdNota As Integer) As DataTable

            Return ObtieneDatos("sp_sel_MaestroNotasCDDevolucion",
                   IdNota,
                   EmpresaActual)

        End Function

        Public Shared Function MensajeRechazo(Consecutivo As String,
                                              Factura As String) As DataTable

            Return ObtieneDatos("sp_sel_FACTURAS_VENTAS_XMLMensajeRechazo",
                                Consecutivo,
                                Factura,
                                EmpresaActual)

        End Function



    End Class

End Namespace
