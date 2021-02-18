Imports Entities
Imports ClasesBLL
Imports System.Linq
Imports System.Data.SqlClient
Imports System.IO
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

        Public Shared Function IVA(ByVal Mes As String, ByVal FechaIni As String,
                                       ByVal FechaFin As String, ByVal EmpresaActual As String,
                                       ByVal MontoIR As String, ByVal IRProd As String, ByVal IRServ As String,
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

        Public Shared Function IR(ByVal Mes As String, ByVal FechaIni As String,
                                        ByVal FechaFin As String, ByVal EmpresaActual As String,
                                        ByVal MontoIR As String, ByVal IRProd As String, ByVal IRServ As String,
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

        Public Function GetIRVentas(ByVal FechaINI As String, ByVal FechaFIN As String,
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

        Public Shared Function FacturasVentasBuscarNC(IdNota As Integer) As DataTable

            Return ObtieneDatos("sp_sel_FACTURAS_VENTAS_BuscarNC",
                           IdNota,
                           EmpresaActual)

        End Function

        Public Shared Function BuscarDevolucionNC(IdNota As Integer) As DataTable

            Return ObtieneDatos("sp_sel_MaestroNotasCDDevolucion",
                   IdNota,
                   EmpresaActual)

        End Function

        Public Shared Function MensajeRechazo(Consecutivo As String,
                                              Factura As String,
                                              Optional Tipo As String = "01") As DataTable

            Return ObtieneDatos("sp_sel_FACTURAS_VENTAS_XMLMensajeRechazo",
                                Consecutivo,
                                Factura,
                                EmpresaActual,
                                Tipo)

        End Function

        Public Property Comp_No As Integer = 0
        Public Property Per_Id As Integer = 0
        Public Property Mes As Integer = 0
        Public Property NoDevolucion As Integer = 0
        Public Property IdNota As Integer = 0
        Public Property MontoNC As Double = 0
        Public Property Fecha As Date

        Public Function Devolucion(DT_Header As DataTable,
                               DT_Detalle As DataTable,
                               FechaDevolucion As Date,
                               MovimientoID As Integer,
                               TipoNC As Integer,
                               Referencia As String,
                               NoNota As String,
                               Concepto As String,
                               Origen As Integer) As Boolean

            'Dim DT_Header As DataTable = ObtieneDatos("sp_sel_FACTURAS_VENTAS",
            '                                          NoFactura,
            '                                          EmpresaActual)

            Dim ClienteDetalle As New ClientesDetails
            ClienteDetalle = ClientesDB.GetDetails(DT_Header.Rows.Item(0)("CLIENTE"))

            Dim Plantilla As New PlantillaDB
            Dim plan As String = Plantilla.GetTipoPlantilla(4, 4).ToString()
            '
            If plan = "" Or plan Is DBNull.Value Then
                XtraMsg("No hay Plantilla Contable de Devolución para Realizar esta Transacción",
                        MessageBoxIcon.Error)
                Return False
            End If
            '
            Dim CuentaCliente As String = String.Empty,
                CompNo As Integer = 0,
                EsProducto As Boolean = True,
                Repetido As Boolean = False,
                CuentaIVA As String = String.Empty,
                fp As Integer = 0,
                CuentaMtto As String = String.Empty,
                MttoMonto As Double = 0.00,
                TCambio As Double = GetTasaCambioDia(FechaDevolucion)

            Dim CuentasIventario As New ArrayList,     'CUENTAS CONTABLES D PRODUCTOS
                MontosIventario As New ArrayList,  'MONTO DE PRODUCTOS INVENTARIO        
                CuentasCostos As New ArrayList,     'CUENTAS CONTABLES D PRODUCTOS
                MontosCostos As New ArrayList,  'MONTO DE PRODUCTOS COSTO        
                CuentasIngresos As New ArrayList,   'CUENTAS CONTABLES D PRODUCTOS
                MontosIngresos As New ArrayList,  'MONTO DE PRODUCTOS INVENTARIO VS. COSTO
                ArrayCentros As New ArrayList,   'DISTRIBUION A LOS CENTROS DE COSTOS.
                ArrayCentrosMoneda As New ArrayList, 'DISTRIBUION A LOS CENTROS DE COSTOS POR DESLIZAMIENTO
                TotalCaja As Double = 0,
                MontoIVA As Double = 0

            Dim PlanillaDetalle As New VB.SysContab.PlantillaDetails(),
                TipoComp As Integer = Plantilla.GetPlantillasDetails(plan).TipoCompr,
                NoFactura As String = DT_Header.Rows.Item(0)("FACTURA"),
                Dev As New DevolucionesClienteDB(),
                FormaPago As New Forma_PagoDB(),
                DTDistribucion As DataTable = CargaDistribucion(0, 0, 0)

            If ClientesDB.FacturaDetalleDevolucion(NoFactura).
                Tables("Facturas_Ventas").Rows.Count = 0 Then EsProducto = False

            'Buscar Plantilla de Mantenimiento de Valor.
            Dim DsPlantillas As DataSet =
                PlantillaDB.GetPlantillasDetails(7, 1).Detalles

            If DsPlantillas.Tables("PlantillasDetalles").Rows.Count <= 1 Then
                XtraMsg("Hace Falta la Plantilla de Mantenimiento de Valor.",
                        MessageBoxIcon.Error)
                Return False
            End If

            'Factura de Contado
            If FormaPago.FormaPagoDias(DT_Header.Rows.Item(0)("TIPO_FACTURA")) = 0 Then   'Contado
                fp = 0
                PlanillaDetalle =
                    PlantillaDB.GetPlantillasDetails(4, 1)

                If PlanillaDetalle.PlaID Is DBNull.Value Or
                    PlanillaDetalle.PlaID Is Nothing Or
                    PlanillaDetalle.PlaID = "" Then

                    XtraMsg("No existen plantilla del tipo Factura de Contado", MessageBoxIcon.Warning)
                    Return False
                Else
                    CuentaCliente = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                    CuentaIVA = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")
                    'CuentaIR = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
                    'CuentaIR_Alcaldia = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(6).Item("Cuenta")
                End If
            Else    'Factura de Credito
                fp = 1
                PlanillaDetalle = PlantillaDB.GetPlantillasDetails(4, 2)

                If ClienteDetalle.Cuenta.Trim = "" Then
                    XtraMsg("No se puede contabilizar la Devolución, porque no hay cuenta contable para el cliente: " & ClienteDetalle.Nombre, MessageBoxIcon.Error)
                    Return False
                End If
                '
                If PlanillaDetalle.PlaID Is DBNull.Value Or
                   PlanillaDetalle.PlaID Is Nothing Or
                   PlanillaDetalle.PlaID = "" Then

                    XtraMsg("No existen plantilla del tipo Factura de Crédito", MessageBoxIcon.Warning)
                    Return False
                Else
                    CuentaCliente = ClienteDetalle.Cuenta
                    CuentaIVA = PlanillaDetalle.Detalles.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
                End If
            End If
            '
            Per_Id = PeriodosDB.Activo(FechaDevolucion)
            NoDevolucion = DevolucionesClienteDB.Numero()

            'Iniciar Transacción...
            '/****************************************************************************
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction
            '****************************************************************************/
            '
            Try
                '***************  CONTABILIZANDO DEVOLUCION FACTURA
                CompNo = ComprobanteDB.AddComprobante(TipoComp, 1,
                        "Nota de Crédito por Devolución #: " & NoDevolucion.ToString() & ", Referencia #: " & Referencia,
                        MonedaBase, Per_Id,
                        FechaDevolucion, 0, "", False,
                        DT_Header.Rows.Item(0)("CLIENTE"),
                        "", 0, NoNota, Rutinas.Fecha, 0,
                        IIf(CInt(EmpresaActual) = 20, OrigenComprobantes.NC_ELECTRONICA, OrigenComprobantes.NC_DEVOLUCION))

                Dev.AddItem(NoDevolucion,
                        NoFactura,
                        Referencia,
                        CompNo,
                        Per_Id,
                        FechaDevolucion.Month,
                        0,
                        "",
                        Concepto)

                For i As Integer = 0 To DT_Detalle.Rows.Count - 1

                    Dim IvaP As Double = 0
                    If Origen = 1 Then  'Devolucion Total.
                        IvaP = DT_Detalle.Rows.Item(i)("Iva_Porcentaje")
                    ElseIf Origen = 2 Then
                        IvaP = DT_Detalle.Rows.Item(i)("IvaP") * 100.0
                    End If


                    Dim IVAUnidad As Double = IIf(CDbl(DT_Detalle.Rows.Item(i)("IVA")) > 0,
                                              CDbl(DT_Detalle.Rows.Item(i)("CANTIDAD") * DT_Detalle.Rows.Item(i)("PRECIO")) *
                                              CDbl(IvaP / 100.0), 0.00)

                    Dim Descuento As Double = DT_Detalle.Rows.Item(i)("DESCUENTO")

                    Dim Mantenimiento As Double =
                        (DT_Detalle.Rows.Item(i)("CANTIDAD") * (DT_Detalle.Rows.Item(i)("PRECIOUSD") * TCambio)) -
                        (DT_Detalle.Rows.Item(i)("CANTIDAD") * DT_Detalle.Rows.Item(i)("PRECIO"))

                    MttoMonto += Mantenimiento

                    Dev.AddItemDetalle(
                        NoDevolucion,
                        DT_Detalle.Rows.Item(i)("ITEM"),
                        DT_Detalle.Rows.Item(i)("TIPO"),
                        DT_Detalle.Rows.Item(i)("CANTIDAD"),
                        IVAUnidad,
                        DT_Detalle.Rows.Item(i)("PRECIO"),
                        Math.Round(Mantenimiento, 2),
                        Descuento)

                    ''*********** DISTRIBUION CUENTA DE DESLIZAMIENTO DE MONEDA **********************
                    If Mantenimiento <> 0 Then

                        If Mantenimiento > 0 Then CuentaMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
                        If Mantenimiento < 0 Then CuentaMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")

                        Dim DT_RG As DataTable =
                            ObtieneDatosTrans("sp_sel_RubroGastos",
                                              CuentaMtto,
                                              EmpresaActual)

                        If DT_RG.Rows.Count > 0 Then

                            Dim _ExisteCentro As Boolean = False
                            Dim _Existe As Boolean = False

                            For c As Integer = 0 To ArrayCentrosMoneda.Count - 1
                                'Verifica si existe centro
                                If DT_Detalle.Rows.Item(i)("CentroID") = ArrayCentrosMoneda(c) Then
                                    _ExisteCentro = True
                                    'Distribucion Ingresos
                                    For d As Integer = 0 To DTDistribucion.Rows.Count - 1
                                        If CuentaMtto = DTDistribucion.Rows(d).Item("Cuenta") And
                                                 DTDistribucion.Rows(d).Item("IdCentroCosto") = ArrayCentrosMoneda(c) Then

                                            _Existe = True

                                            DTDistribucion.Rows(d).Item("Valor") =
                                                Math.Round(Mantenimiento + DTDistribucion.Rows(d).Item("Valor"), 2)
                                        End If
                                    Next
                                End If
                            Next
                            '
                            If _ExisteCentro = False Then
                                'Verifica si no existe y lo agrega
                                ArrayCentrosMoneda.Add(DT_Detalle.Rows.Item(i)("CentroID"))
                            End If
                            '
                            If _Existe = False Then
                                Dim row As DataRow = DTDistribucion.NewRow()

                                row("IdRubroGasto") = DT_RG.Rows(0).Item("Codigo")
                                row("IdEmpresa") = EmpresaActual
                                row("NoComp") = CompNo
                                row("Mes") = FechaDevolucion.Month
                                row("Per_Id") = Per_Id
                                row("IdCentroCosto") = DT_Detalle.Rows.Item(i)("CentroID")
                                row("Valor") = Math.Round(Mantenimiento, 2)
                                row("Tipo") = IIf(Mantenimiento > 0, "C", "D")
                                row("Cuenta") = CuentaMtto

                                DTDistribucion.Rows.Add(row)
                            End If

                        End If

                    End If

                    Guardar_Con_Transaccion("sp_DevolucionClienteDetalle_Proyecto",
                                                DT_Detalle.Rows.Item(i)("NUMERO"),
                                                DT_Detalle.Rows.Item(i)("CANTIDAD"),
                                                EmpresaActual)

                    Guardar_Con_Transaccion("sp_DevolucionClienteDetalle_Devuelto",
                                            DT_Detalle.Rows.Item(i)("NUMERO"),
                                            EmpresaActual)

                    ''***********   CUENTAS DE INGRESOS  **********************
                    Repetido = False

                    For c As Integer = 0 To CuentasIngresos.Count - 1
                        If DT_Detalle.Rows.Item(i)("CUENTA_DEVOLUCION") = CuentasIngresos(c) Then

                            MontosIngresos(c) = MontosIngresos(c) +
                                ((DT_Detalle.Rows.Item(i)("CANTIDAD") * (DT_Detalle.Rows.Item(i)("PRECIOUSD") * TCambio)) -
                                 (DT_Detalle.Rows.Item(i)("CANTIDAD") * (DT_Detalle.Rows.Item(i)("PRECIOUSD") * TCambio) * (Descuento / 100.0)))

                            Repetido = True
                        End If
                    Next
                    '
                    If Repetido = False Then
                        CuentasIngresos.Add(DT_Detalle.Rows.Item(i)("CUENTA_DEVOLUCION"))

                        MontosIngresos.Add((DT_Detalle.Rows.Item(i)("CANTIDAD") * (DT_Detalle.Rows.Item(i)("PRECIOUSD") * TCambio)) -
                                                   (DT_Detalle.Rows.Item(i)("CANTIDAD") * (DT_Detalle.Rows.Item(i)("PRECIOUSD") * TCambio) * (Descuento / 100.0)))
                    End If
                    '' ***********   FIN CUENTAS DE INGRESOS  *********************
                    '
                    '' ***********  DISTRIBUCION CUENTAS DE DEVOLUCION  *************
                    Dim ExisteCentro As Boolean = False
                    Dim Existe As Boolean = False
                    '
                    For c As Integer = 0 To ArrayCentros.Count - 1
                        'Verifica si existe centro
                        If DT_Detalle.Rows.Item(i)("CentroID") = ArrayCentros(c) Then
                            ExisteCentro = True
                            'Distribucion Ingresos
                            For d As Integer = 0 To DTDistribucion.Rows.Count - 1
                                If DT_Detalle.Rows.Item(i)("CUENTA_DEVOLUCION") = DTDistribucion.Rows(d).Item("Cuenta") And
                                             DTDistribucion.Rows(d).Item("IdCentroCosto") = ArrayCentros(c) Then

                                    Existe = True

                                    DTDistribucion.Rows(d).Item("Valor") =
                                        Math.Round(((DT_Detalle.Rows.Item(i)("CANTIDAD") * (DT_Detalle.Rows.Item(i)("PRECIOUSD") * TCambio)) -
                                                     (DT_Detalle.Rows.Item(i)("CANTIDAD") * (DT_Detalle.Rows.Item(i)("PRECIOUSD") * TCambio) * (Descuento / 100))) +
                                                      DTDistribucion.Rows(d).Item("Valor"), 2)
                                End If
                            Next
                        End If
                    Next
                    '
                    If ExisteCentro = False Then
                        'Verifica si no existe y lo agrega
                        ArrayCentros.Add(DT_Detalle.Rows.Item(i)("CentroID"))
                    End If
                    '' ***********  FIN DISTRIBUCION CUENTAS DE INGRESOS  *************
                    ''******************** AGREGAR DISTRIBUCION A LA TABLA ***********
                    If Existe = False Then
                        Dim row As DataRow = DTDistribucion.NewRow()
                        Dim DT_RG As DataTable = ObtieneDatosTrans("sp_sel_RubroGastos",
                                                                DT_Detalle.Rows.Item(i)("CUENTA_DEVOLUCION"),
                                                                EmpresaActual)

                        If DT_RG.Rows.Count > 0 Then
                            row("IdRubroGasto") = DT_RG.Rows(0).Item("Codigo")
                            row("IdEmpresa") = EmpresaActual
                            row("NoComp") = CompNo
                            row("Mes") = FechaDevolucion.Month
                            row("Per_Id") = Per_Id
                            row("IdCentroCosto") = DT_Detalle.Rows.Item(i)("CentroID")   'cbCentroCosto.EditValue  
                            row("Valor") = Math.Round(((DT_Detalle.Rows.Item(i)("CANTIDAD") * (DT_Detalle.Rows.Item(i)("PRECIOUSD") * TCambio)) -
                                                            (DT_Detalle.Rows.Item(i)("CANTIDAD") * (DT_Detalle.Rows.Item(i)("PRECIOUSD") * TCambio) * (Descuento / 100))), 2)
                            row("Tipo") = "D"
                            row("Cuenta") = DT_Detalle.Rows.Item(i)("CUENTA_DEVOLUCION")

                            DTDistribucion.Rows.Add(row)
                        End If
                    End If
                    '                    
                    '**************************************************
                    'FIN DE DISTRIBUCION -  CENTRO DE COSTOS
                    '**************************************************
                    TotalCaja = TotalCaja + ((DT_Detalle.Rows.Item(i)("CANTIDAD") * DT_Detalle.Rows.Item(i)("PRECIO")) -
                                                            (DT_Detalle.Rows.Item(i)("CANTIDAD") * DT_Detalle.Rows.Item(i)("PRECIO") * (Descuento / 100)))
                    '
                    'MontoIVA = MontoIVA + (DT_DETALLE.Rows.Item(i)("IVA"))
                    MontoIVA = MontoIVA + +(IIf(CDbl(DT_Detalle.Rows.Item(i)("IVA")) > 0,
                                                  CDbl(DT_Detalle.Rows.Item(i)("CANTIDAD") * DT_Detalle.Rows.Item(i)("PRECIO")) *
                                                  CDbl(IvaP / 100.0), 0.00))
                Next
                '
                '*****************  CONTABILIZANDO DEBITOS ***********************
                '*****************************************************************
                'Ingresos 
                For c As Integer = 0 To CuentasIngresos.Count - 1
                    ComprobanteDB.AddComprobanteDetalles(
                        CompNo,
                        CuentasIngresos(c),
                        "Ingreso por Devolucion No. " & NoDevolucion.ToString(),
                        Math.Round(MontosIngresos(c), 2),
                        "0",
                        TipoComp,
                        "D",
                        "0",
                        "0",
                        FechaDevolucion.Date, 1)
                Next
                '
                'IVA    
                If MontoIVA > 0 Then
                    ComprobanteDB.AddComprobanteDetalles(
                        CompNo,
                        CuentaIVA,
                        "IVA Por Devolucion No. " & NoDevolucion.ToString(),
                        Math.Round(MontoIVA, 2),
                        "0",
                        TipoComp,
                        "D",
                        "0",
                        "0",
                        FechaDevolucion.Date, 1)
                End If
                '
                '*****************  CONTABILIZANDO CREDITO ***********************
                '*****************************************************************
                'Cajas
                ComprobanteDB.AddComprobanteDetalles(
                    CompNo,
                    CuentaCliente,
                    IIf(fp = 0, "Fondos por Depositar/Cajas", "Cuentas x Cobrar Clientes"),
                    Math.Round(TotalCaja + MontoIVA, 2),
                    "0",
                    TipoComp,
                    "C",
                    "0",
                    "0",
                    FechaDevolucion.Date, 1)
                '
                Comp_No = CompNo
                Mes = FechaDevolucion.Month
                Fecha = FechaDevolucion
                '
                ComprobanteDB.ComprobanteDiferenciaDevolucion(
                    CompNo,
                    Per_Id,
                    Mes,
                    CuentaMtto)

                Rutinas.okTransaccion()
            Catch ex As Exception
                XtraMsg(ex.Message & " Contabilizar.",
                    MessageBoxIcon.Error)
                Rutinas.ErrorTransaccion()
                Return False
            End Try
            '
            '----------------------
            'Guarda la Distribucion
            '----------------------
            GuardaDistribucion(
                DTDistribucion,
                CompNo,
                Per_Id,
                FechaDevolucion.Date.Month)
            '----------------------
            'Fin Guarda la Distribucion
            '----------------------
            Try
                '***************** GUARDAR NOTA DE CREDITO ***********************
                Dim db_Notas As New db_MaestroNotasCD
                MontoNC = Math.Round(TotalCaja + MontoIVA, 2)
                '
                IdNota = db_Notas.Guardar(
                    NoNota,
                    ClienteDetalle.Codigo,
                    FechaDevolucion.Date,
                    TipoComp,
                    MontoNC,
                    "Nota de Crédito por Devolución #: " & NoDevolucion.ToString() & ", Referencia #: " & Referencia,
                    1,
                    MonedaBase,
                    CompNo,
                    Per_Id,
                    FechaDevolucion.Month,
                    FechaDevolucion.Date,
                    0,
                    TipoNC,
                    "",
                    NoDevolucion)

                If IdNota > 0 Then
                    'Detalle de la N/C
                    db_Notas.GuardarDetalle(
                        IdNota,
                        NoFactura,
                        MontoNC,
                        DT_Header.Rows.Item(0)("FECHA"),
                        0.00)
                End If
                ''*************** FIN REGISTRO NOTA DE CREDITO ****************
                '----------------------------------------
                'Guarda Movimiento de Inventario
                '----------------------------------------
                If EsProducto Then
                    'Validar si hay registros para procesar
                    'Dim dr() As DataRow = DT_DETALLE.Select("EsProyecto = 0")
                    Dim dr() As DataRow = DT_Detalle.Select("TIPO = 'P'")
                    If dr.Length > 0 Then

                        Dim _DETALLE As DataTable = DT_Detalle.Select("TIPO = 'P'").CopyToDataTable

                        'Productos sin relacion con los proyectos
                        If _DETALLE.Select("IdProyecto = 0").Length > 0 Then

                            Dim _SIN_PROY As DataTable =
                            _DETALLE.Select("IdProyecto = 0") _
                            .CopyToDataTable

                            If _SIN_PROY.Rows.Count > 0 Then

                                Dim Requisa As Integer = db_requisas.Add(
                                    EmpresaActual,
                                    "E",
                                    FechaDevolucion.Date,
                                    _SIN_PROY.Rows.Item(0)("Bodega"),
                                    Login,
                                    NoDevolucion,
                                    MovimientoID,
                                    Referencia,
                                    "Nota de Crédito por Devolución #: " & NoDevolucion.ToString() & ", Referencia #: NC" & Referencia,
                                    "", "", "", "", "", "",
                                    ClienteDetalle.Codigo, "", 0, 0, 0, NoDevolucion)

                                For i As Integer = 0 To _SIN_PROY.Rows.Count - 1
                                    'If _SIN_PROY.Rows.Item(i)("TIPO") = "P" Then

                                    db_requisas.AddDetalle(
                                        EmpresaActual,
                                        Requisa,
                                        _SIN_PROY.Rows.Item(i)("ITEM"),
                                        "P",
                                        _SIN_PROY.Rows.Item(i)("CANTIDAD"),
                                        _SIN_PROY.Rows.Item(i)("COSTO"),
                                        "NC", "", "", "")

                                    'End If
                                Next
                            End If

                        End If
                        '
                        'Productos con Relacion a los Proyectos.
                        If _DETALLE.Select("IdProyecto > 0").Length > 0 Then

                            Dim _CON_PROY As DataTable = _DETALLE.Select("IdProyecto > 0").CopyToDataTable()

                            If _CON_PROY.Rows.Count > 0 Then

                                Dim req = From row In _CON_PROY.AsEnumerable()
                                          Select row.Field(Of Object)("IdProyecto") Distinct

                                For Each s As Object In req
                                    If Not s Is Nothing Then

                                        Dim _DT As DataTable =
                                                _CON_PROY.
                                                Select("IdProyecto = " & s).
                                                CopyToDataTable

                                        Dim Requisa As Integer = db_requisas.Add(
                                            EmpresaActual,
                                            "E",
                                            FechaDevolucion.Date,
                                            _DT.Rows.Item(0)("Bodega"),
                                            Login,
                                            NoDevolucion,
                                            MovimientoID,
                                            Referencia,
                                            "Nota de Crédito por Devolución #: " & NoDevolucion.ToString() & ", Referencia #: NC" & Referencia,
                                            "", "", "", "", "", "",
                                            ClienteDetalle.Codigo, "", s, 0, 0, NoDevolucion)

                                        For i As Integer = 0 To _DT.Rows.Count - 1
                                            'If _DT.Rows.Item(i)("TIPO") = "P" Then

                                            db_requisas.AddDetalle(
                                                EmpresaActual,
                                                Requisa,
                                                _DT.Rows.Item(i)("ITEM"),
                                                "P",
                                                _DT.Rows.Item(i)("CANTIDAD"),
                                                _DT.Rows.Item(i)("COSTO"),
                                                "NC", "", "", "")
                                            ' End If
                                        Next
                                    End If
                                Next
                            End If
                        End If
                    End If
                End If


                XtraMsg("Devolución realizada Exitosamente !!!",
                    MessageBoxIcon.Information)
                '
                ''Imprimir el Comprobante Contable de la Devolución
                'ComprobanteDB.ImprimirComprobante(
                '    CompNo,
                '    PeriodosDB.Activo(FechaDevolucion.Date),
                '    FechaDevolucion.Date)

                ''Actualizar Lista de Devoluciones
                'Dim f As frmDevolucionesClienteList = frmDevolucionesClienteList.Instance()
                'If f.Created Then f.Cargar()

                Return True
            Catch ex As Exception
                XtraMsg(ex.Message & ". Guardar N/C",
                    MessageBoxIcon.Error)
                Return False
            End Try

        End Function

        Public Shared Sub DevolucionImprimir(ID As Integer, NoNota As String, Tipo As String, Monto As Double)
            'Imprimir Nota de Credito.
            ShowSplash("Imprimiendo...")
            '
            Dim Temp As Boolean =
                db_Formatos.FormatoImpreso(6, "rptNotaDC")

            Dim rpt As rptNotasProveedores

            If Temp = True Then
                rpt = XtraReport.FromFile(Application.StartupPath & "\rptNotaDC.repx", True)
            Else
                rpt = New rptNotasProveedores
            End If
            '
            Dim DT_NDC As DataTable = ObtieneDatos("JAR_NotaClienteImprimir",
                                                   ID,
                                                   Tipo,
                                                   Rutinas.Letras(Monto),
                                                   EmpresaActual)
            VistaPreviaDX(
                rpt,
                DT_NDC,
                $"NOTA DE {IIf(Tipo = "C", "CREDITO", "DEBITO")} NO. {NoNota}")

            HideSplash()
        End Sub

        '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
        Public Shared Function Detalles(ByVal Factura As String) As FACTURAS_VENTAS

            Dim dt As DataTable = ObtieneDatos("sp_sel_FACTURAS_VENTAS", Factura, EmpresaActual)
            Dim det As New FACTURAS_VENTAS

            If dt.Rows.Count = 0 Then
                det = Nothing
            Else
                With dt.Rows(0)
                    det.NUMERO = .Item("NUMERO")
                    det.FACTURA = .Item("FACTURA")
                    det.FECHA = .Item("FECHA")
                    det.CLIENTE = .Item("CLIENTE")
                    det.RUC = .Item("RUC")
                    det.MONTO = .Item("MONTO")
                    det.SUBTOTAL = .Item("SUBTOTAL")
                    det.DESCUENTO = .Item("DESCUENTO")
                    det.IVA = .Item("IVA")
                    det.RECARGO = .Item("RECARGO")
                    det.OTROS = .Item("OTROS")
                    det.TOTAL = .Item("TOTAL")
                    det.SALDO = .Item("SALDO")
                    det.VENDEDOR = .Item("VENDEDOR")
                    det.FECHA_PAGO = .Item("FECHA_PAGO")
                    det.FECHA_VENCIMIENTO = .Item("FECHA_VENCIMIENTO")
                    det.TIPO = .Item("TIPO")
                    det.TIPO_FACTURA = .Item("TIPO_FACTURA")
                    det.USUARIO_CREACION = IsNull(.Item("USUARIO_CREACION"), "")
                    'det.USUARIO_MODIFICACION = .Item("USUARIO_MODIFICACION")
                    det.FECHA_CREACION = IsNull(.Item("FECHA_CREACION"), Now.Date)
                    'det.FECHA_MODIFICACION = .Item("FECHA_MODIFICACION")
                    det.NUMERO_MES = .Item("NUMERO_MES")
                    'det.Pv_Codigo = .Item("Pv_Codigo")
                    det.Estado = .Item("Estado")
                    det.EMPRESA = .Item("EMPRESA")
                    det.NOMBRE_CLIENTE = .Item("NOMBRE_CLIENTE")
                    det.Fact_Cancelado = .Item("Fact_Cancelado")
                    det.Fact_Contabilizar = .Item("Fact_Contabilizar")
                    det.Fact_IVA = .Item("Fact_IVA")
                    det.Fact_IR = .Item("Fact_IR")
                    det.Retencion = .Item("Retencion")
                    det.mon_mtto = .Item("mon_mtto")
                    det.Remision = .Item("Remision")
                    det.Orden = .Item("Orden")
                    det.Caja = .Item("Caja")
                    det.Cultivo = .Item("Cultivo")
                    det.OrdenEntrega = .Item("OrdenEntrega")
                    det.Condiciones = .Item("Condiciones")
                    det.SI = .Item("SI")
                    det.TCambio = .Item("TCambio")
                    'det.Emp_Codigo = .Item("Emp_Codigo")
                    det.Valido = .Item("Valido")
                    det.Procesado = .Item("Procesado")
                    'det.trn_quincena = .Item("trn_quincena")
                    'det.ptm_codigoEmp = .Item("ptm_codigoEmp")
                    det.Comp_No = .Item("Comp_No")
                    det.Per_Id = .Item("Per_Id")
                    det.Mes = .Item("Mes")
                    det.Bodega = .Item("Bodega")
                    det.Despacho = .Item("Despacho")
                    det.MonedaImpresa = .Item("MonedaImpresa")
                    det.Comentario = .Item("Comentario")
                    det.IR_Alcaldia = .Item("IR_Alcaldia")
                    det.Formato = .Item("Formato")
                    det.Convenio = .Item("Convenio")
                    det.IdProyecto = .Item("IdProyecto")
                    det.IdCentro = .Item("IdCentro")
                    det.Serie = .Item("Serie")
                    det.Descripcion_Serie = .Item("Descripcion_Serie")
                    ' det.Fecha_Anulacion = .Item("Fecha_Anulacion")
                    det.Fiscal = .Item("Fiscal")
                    det.MontoIr = .Item("MontoIr")
                    det.MontoIrAlma = .Item("MontoIrAlma")
                    det.ATV = .Item("ATV")
                    det.Mensaje = .Item("Mensaje")
                    det.IdBolsa = .Item("IdBolsa")
                End With
            End If

            Return det

        End Function

    End Class

End Namespace
