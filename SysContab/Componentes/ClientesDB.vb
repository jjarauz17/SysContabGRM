Imports System
Imports System.IO
Imports System.Linq
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports ClasesBLL

Namespace VB.SysContab

    Public Class FacturacionXDia
        Public Total As String
        Public TotalContado As String
        Public TotalCredito As String
        Public TotalCobros As String
        Public TotalAdelantos As String

        Public TotalChequesContado As String
        Public TotalEfectivoContado As String
        Public TotalTarjetasContado As String
        Public TotalNotasDebitoContado As String

        Public TotalChequesCredito As String
        Public TotalEfectivoCredito As String
        Public TotalTarjetasCredito As String
        Public TotalNotasDebitoCredito As String

        Public TotalChequesAbonos As String
        Public TotalEfectivoAbonos As String
        Public TotalTarjetasAbonos As String
        Public TotalNotasDebitoAbonos As String

        Public TotalRetenciones As String

    End Class



    Public Class ClientesDetails
        Public Codigo As String
        Public Nombre As String
        Public Nombre_Comercial As String
        Public Contacto As String
        Public Cargo As String
        Public Telefono_Contacto As String
        Public Celular_Contacto As String
        Public Email_Contacto As String
        Public Gerente As String
        Public Telefono_Gerente As String
        Public Celular_Gerente As String
        Public Email_Gerente As String
        Public Contador As String
        Public Telefono_Contador As String
        Public Celular_Contador As String
        Public Email_Contador As String
        Public Direccion As String
        Public Ciudad As String
        Public Pais As Integer
        Public Departamento As Integer
        Public Municipio As Integer
        Public DepartamentoN As String
        Public MunicipioN As String
        Public PaisN As String
        Public Telefono As String
        Public Fax As String
        Public Correo As String
        Public Ruc As String
        Public Tipo As String
        Public Cod_Zona As String
        Public Cod_Forma_Pago As String
        'Public Nombre_Zona As String
        Public Desc_Prod As String
        Public Desc_Serv As String
        Public Desc_Adicional As String
        Public Limite_Credito As Double
        Public Vendedor As String
        Public Cuenta As String
        Public Excento As Boolean
        Public TipoCliente As String
        Public Retenedor As Boolean
        Public RetenedorAlcaldia As Boolean
        Public Cedula As String
        Public CodigoLetra As String
        Public Empleado As Boolean
        Public Garantia As Boolean
        Public Categoria As Integer
        Public Moneda As String
        Public ValidarLimite As Boolean
        Public Comentario As String
        Public Activo As Boolean
        Public Agro As Boolean
    End Class

    Public Class ClientesDB

        Public Shared Function GetFacturasVentasPendientes(ByVal Fecha As Date, ByVal Moneda As String,
        ByVal TC As String, ByVal Memoria As Boolean, ByVal NEmpresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasVentasPendientesGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha)

            Dim _Moneda As SqlParameter = New SqlParameter("@Moneda", SqlDbType.NVarChar)
            _Moneda.Value = Moneda
            DBCommand.SelectCommand.Parameters.Add(_Moneda)

            Dim _TC As SqlParameter = New SqlParameter("@TC", SqlDbType.NVarChar)
            _TC.Value = TC
            DBCommand.SelectCommand.Parameters.Add(_TC)

            Dim _Memoria As SqlParameter = New SqlParameter("@Memoria", SqlDbType.Bit)
            _Memoria.Value = Memoria
            DBCommand.SelectCommand.Parameters.Add(_Memoria)

            Dim _NEmpresa As SqlParameter = New SqlParameter("@NEmpresa", SqlDbType.NVarChar)
            _NEmpresa.Value = NEmpresa
            DBCommand.SelectCommand.Parameters.Add(_NEmpresa)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CobroUpdate(ByVal Numero As String, ByVal Recibo As String, ByVal Factura As String, ByVal Fecha As String,
                         ByVal Tipo_Pago As String, ByVal Monto As String, ByVal NoCheque As String,
                         ByVal Banco As String, ByVal Cuenta As String, ByVal Monto_Cheque As String,
                         ByVal Tipo_Tarjeta As String, ByVal Emisor As String, ByVal No_Tarjeta As String,
                         ByVal Autorizacion As String, ByVal Monto_Tarjeta As String, ByVal Monto_Efectivo As String,
                         ByVal Moneda As String, ByVal TipoCambio As String, ByVal Saldo As String,
                         ByVal Monto_NotaDebito As String, ByVal CuentaCatalogo As String, ByVal Tipo As String,
                         ByVal Transaccion As String, ByVal Origen As String)

            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_CobrosUpdate", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar, 50)
            Dim _Recibo As SqlParameter = New SqlParameter("@Recibo", SqlDbType.NVarChar, 50)
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _Tipo_Pago As SqlParameter = New SqlParameter("@Tipo_Pago", SqlDbType.Int, 4)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 8)
            Dim _NoCheque As SqlParameter = New SqlParameter("@NoCheque", SqlDbType.NVarChar, 50)
            Dim _Banco As SqlParameter = New SqlParameter("@Banco", SqlDbType.Int, 4)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar, 50)
            Dim _Monto_Cheque As SqlParameter = New SqlParameter("@Monto_Cheque", SqlDbType.Float, 8)
            Dim _Tipo_Tarjeta As SqlParameter = New SqlParameter("@Tipo_Tarjeta", SqlDbType.NVarChar, 50)
            Dim _Emisor As SqlParameter = New SqlParameter("@Emisor", SqlDbType.NVarChar, 50)
            Dim _No_Tarjeta As SqlParameter = New SqlParameter("@No_Tarjeta", SqlDbType.NVarChar, 50)
            Dim _Autorizacion As SqlParameter = New SqlParameter("@Autorizacion", SqlDbType.NVarChar, 50)
            Dim _Monto_Tarjeta As SqlParameter = New SqlParameter("@Monto_Tarjeta", SqlDbType.Float, 8)
            Dim _Monto_Efectivo As SqlParameter = New SqlParameter("@Monto_Efectivo", SqlDbType.Float, 8)
            Dim _Moneda As SqlParameter = New SqlParameter("@Moneda", SqlDbType.NVarChar, 50)
            Dim _MontoNotaDebito As SqlParameter = New SqlParameter("@Monto_NotaDebito", SqlDbType.Float, 8)
            Dim _CuentaCatalogo As SqlParameter = New SqlParameter("@Cuenta_Catalogo", SqlDbType.NVarChar, 50)
            Dim _TipoCambio As SqlParameter = New SqlParameter("@TipoCambio", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int)
            Dim _Transaccion As SqlParameter = New SqlParameter("@Transaccion", SqlDbType.NVarChar, 50)
            Dim _Origen As SqlParameter = New SqlParameter("@Origen", SqlDbType.Int)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Numero.Value = Numero
            _Recibo.Value = Recibo
            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _Tipo_Pago.Value = Tipo_Pago
            _Monto.Value = Monto
            _NoCheque.Value = NoCheque
            _Banco.Value = Banco
            _Cuenta.Value = Cuenta
            _Monto_Cheque.Value = Monto_Cheque
            _Tipo_Tarjeta.Value = Tipo_Tarjeta
            _Emisor.Value = Emisor
            _No_Tarjeta.Value = No_Tarjeta
            _Autorizacion.Value = Autorizacion
            _Monto_Tarjeta.Value = Monto_Tarjeta
            _Monto_Efectivo.Value = Monto_Efectivo
            _Moneda.Value = Moneda
            _TipoCambio.Value = TipoCambio
            _MontoNotaDebito.Value = Monto_NotaDebito
            _CuentaCatalogo.Value = CuentaCatalogo
            _Saldo.Value = Saldo
            _Tipo.Value = Tipo
            _Transaccion.Value = Transaccion
            _Origen.Value = Origen
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Recibo)
            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Tipo_Pago)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_NoCheque)
            cmd.Parameters.Add(_Banco)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_Monto_Cheque)
            cmd.Parameters.Add(_Tipo_Tarjeta)
            cmd.Parameters.Add(_Emisor)
            cmd.Parameters.Add(_No_Tarjeta)
            cmd.Parameters.Add(_Autorizacion)
            cmd.Parameters.Add(_Monto_Tarjeta)
            cmd.Parameters.Add(_Monto_Efectivo)
            cmd.Parameters.Add(_Moneda)
            cmd.Parameters.Add(_MontoNotaDebito)
            cmd.Parameters.Add(_CuentaCatalogo)
            cmd.Parameters.Add(_TipoCambio)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Transaccion)
            cmd.Parameters.Add(_Origen)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            '15/11/2005
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function


        Public Function GetTotalRecibo(ByVal Recibo As Integer, ByVal Tipo As Integer, ByVal Cadena As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim Total As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RecibosCobrosImpreso", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pRecibo As New SqlParameter("@Recibo", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pCadena As New SqlParameter("@Cadena", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pRecibo.Value = Recibo
            pTipo.Value = Tipo
            pCadena.Value = ""

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pRecibo)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pCadena)

            DBCommand.Fill(Total, "Cobros")
            DBConn.Close()

            Return Total


        End Function

        'Public Sub ReciboImprimir(ByVal Recibo As String)
        '    Dim fReportes As New frmReportes
        '    Dim rRecibos As New rptRecibos
        '    Dim Ds As New DataSet

        '    'Dim rTotal As New VB.SysContab.Facturas_VentasDB()
        '    Dim Total As String
        '    Dim Convertido As String
        '    'Dim tblLogOnInfo As New TableLogOnInfo
        '    'Dim tblName As Table

        '    'Para retornar el total de un recibo
        '    Total = GetTotalRecibo(Recibo, 0, "").Tables("Cobros").Rows(0).Item("Monto")
        '    'Para convertir el total en cadena
        '    Dim Convert As New VB.SysContab.Rutinas
        '    Convertido = Convert.Letras(Total)

        '    Ds = GetTotalRecibo(Recibo, 1, Convertido)
        '    Ds.WriteXml(Application.StartupPath & "\xml\Recibo.xml", XmlWriteMode.WriteSchema)
        '    rRecibos.Database.Tables("_RecibosCobrosImpreso;1").Location = Application.StartupPath & "\xml\Recibo.xml"

        '    fReportes.crvReportes.ReportSource = rRecibos
        '    fReportes.crvReportes.Zoom(119)
        '    fReportes.Show()
        'End Sub

        Public Function ComprobanteUpdateRecibo(ByVal Comprobante As String, ByVal Recibo As String, ByVal Fecha As String, ByVal Periodo As Integer)
            Dim cmd As SqlCommand = New SqlCommand("_ComprobanteUpdateRecibo", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Periodo As SqlParameter = New SqlParameter("@Periodo", SqlDbType.Int)
            Dim _Comprobante As SqlParameter = New SqlParameter("@Comprobante", SqlDbType.NVarChar)
            Dim _Recibo As SqlParameter = New SqlParameter("@Recibo", SqlDbType.NVarChar)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)


            _Periodo.Value = Periodo
            _Comprobante.Value = Comprobante
            _Recibo.Value = Recibo
            _Fecha.Value = Fecha
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Periodo)
            cmd.Parameters.Add(_Comprobante)
            cmd.Parameters.Add(_Recibo)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()


        End Function

        Public Function ComprobanteBuscar(ByVal Comprobante As String, ByVal Fecha As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComprobanteBuscar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Comprobante As New SqlParameter("@Comprobante", SqlDbType.NVarChar)
            Dim _Periodo As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Comprobante.Value = Comprobante
            _Periodo.Value = PeriodosDB.Activo(Fecha)
            _Fecha.Value = Fecha
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Comprobante)
            DBCommand.SelectCommand.Parameters.Add(_Periodo)
            DBCommand.SelectCommand.Parameters.Add(_Fecha)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ReciboComprobante(ByVal Recibo As String,
                                          Serie As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ReciboComprobante", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Recibo As New SqlParameter("@Recibo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Recibo.Value = Recibo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Recibo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.AddWithValue("@Serie", Serie)

            DBCommand.Fill(dsFicha, "Recibos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturaUpdate(ByVal Factura As String, ByVal Fecha As String, ByVal Cliente As String,
                           ByVal Ruc As String, ByVal Monto As String, ByVal SubTotal As String,
                           ByVal Descuento As String, ByVal Iva As String, ByVal Recargo As String,
                           ByVal Otros As String, ByVal Total As String, ByVal Saldo As String,
                           ByVal Vendedor As String, ByVal Fecha_Pago As String,
                           ByVal Fecha_Vencimiento As String, ByVal Tipo As String,
                           ByVal Tipo_Factura As String, ByVal Nombre_Cliente As String)


            ' Create Instance of Connection and Command Object

            '''Dim DBConn As SqlConnection

            Dim cmd As SqlCommand = New SqlCommand("_FacturasVentasUpdate", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _Cliente As SqlParameter = New SqlParameter("@Cliente", SqlDbType.Int, 4)
            Dim _Ruc As SqlParameter = New SqlParameter("@Ruc", SqlDbType.NVarChar, 50)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 8)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Recargo As SqlParameter = New SqlParameter("@Recargo", SqlDbType.Float, 8)
            Dim _Otros As SqlParameter = New SqlParameter("@Otros", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _Vendedor As SqlParameter = New SqlParameter("@Vendedor", SqlDbType.Int, 4)
            Dim _FechaPago As SqlParameter = New SqlParameter("@Fecha_Pago", SqlDbType.DateTime, 8)
            Dim _FechaVencimiento As SqlParameter = New SqlParameter("@Fecha_Vencimiento", SqlDbType.DateTime, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Tipo_Factura As SqlParameter = New SqlParameter("@Tipo_Factura", SqlDbType.Int, 4)
            Dim _Nombre_Cliente As SqlParameter = New SqlParameter("@Nombre_Cliente", SqlDbType.NVarChar, 100)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _Cliente.Value = Cliente
            _Ruc.Value = Ruc
            _Monto.Value = Monto
            _SubTotal.Value = SubTotal
            _Descuento.Value = Descuento
            _Iva.Value = Iva
            _Recargo.Value = Recargo
            _Otros.Value = Otros
            _Total.Value = Total
            _Saldo.Value = Saldo
            _Vendedor.Value = IIf(Vendedor = "", 0, Vendedor)
            _FechaPago.Value = Fecha_Pago
            _FechaVencimiento.Value = Fecha_Vencimiento
            _Tipo.Value = Tipo
            _Tipo_Factura.Value = Tipo_Factura
            _Nombre_Cliente.Value = Nombre_Cliente
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Cliente)
            cmd.Parameters.Add(_Ruc)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Recargo)
            cmd.Parameters.Add(_Otros)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_Vendedor)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_FechaVencimiento)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Tipo_Factura)
            cmd.Parameters.Add(_Nombre_Cliente)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            '''DBConn.Open()
            'DBConnFacturas.Open()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            ''''DBConn.Close()
            '''DBConnFacturas.Close()

        End Function


        Public Function FacturaCobroDelete(ByVal Factura As String)

            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_FacturaCobroDelete", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function

        Public Function FacturaDetalleCalc(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturaDetalleCalc", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Factura.Value = Factura
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Factura)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasDirectaLista(ByVal Cliente As String, ByVal Fecha As String, ByVal Fecha1 As String, ByVal Mes As String, ByVal Estado As String, ByVal Tipo As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim EstadoLocal As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasClientesD", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Cliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim _Fecha As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim _Fecha1 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim _Estado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Cliente.Value = Cliente
            _Fecha.Value = Fecha
            _Fecha1.Value = Fecha1
            _Mes.Value = Mes
            _Estado.Value = Estado
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Cliente)
            DBCommand.SelectCommand.Parameters.Add(_Fecha)
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)
            DBCommand.SelectCommand.Parameters.Add(_Mes)
            DBCommand.SelectCommand.Parameters.Add(_Estado)
            DBCommand.SelectCommand.Parameters.Add(_Tipo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            'Try
            DBCommand.Fill(dsFicha, "Tabla")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AddFacturaDirecta(ByVal Factura As String, ByVal Fecha As String, ByVal FechaVencimiento As String, ByVal Cliente As String,
                                           ByVal Tipo As String, ByVal FormaPago As String, ByVal SubTotal As String,
                                           ByVal Descuento As String, ByVal Iva As String, ByVal Recargo As String,
                                           ByVal Otros As String, ByVal Total As String, ByVal MontoProductos As String, ByVal MontoServicios As String)


            Dim cmd As SqlCommand = New SqlCommand("_FacturasClientesAdd", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _FechaVecimiento As SqlParameter = New SqlParameter("@FechaPago", SqlDbType.DateTime, 8)
            Dim _Cliente As SqlParameter = New SqlParameter("@Cliente", SqlDbType.Int, 9)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 50)
            Dim _FormaPago As SqlParameter = New SqlParameter("@FormaPago", SqlDbType.Float, 8)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Recargo As SqlParameter = New SqlParameter("@Recargo", SqlDbType.Float, 8)
            Dim _Otros As SqlParameter = New SqlParameter("@Otros", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _MontoProductos As SqlParameter = New SqlParameter("@MontoProducto", SqlDbType.Float, 8)
            Dim _MontoServicios As SqlParameter = New SqlParameter("@MontoServicio", SqlDbType.Float, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _FechaVecimiento.Value = FechaVencimiento
            _Cliente.Value = Cliente
            _Tipo.Value = Tipo
            _FormaPago.Value = FormaPago
            _SubTotal.Value = SubTotal
            _Descuento.Value = Descuento
            _Iva.Value = Iva
            _Recargo.Value = Recargo
            _Otros.Value = Otros
            _Total.Value = Total
            _MontoProductos.Value = MontoProductos
            _MontoServicios.Value = MontoServicios
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_FechaVecimiento)
            cmd.Parameters.Add(_Cliente)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Recargo)
            cmd.Parameters.Add(_Otros)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_MontoProductos)
            cmd.Parameters.Add(_MontoServicios)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            '''DBConn.Open()
            'DBConnFacturas.Open()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            ''''DBConn.Close()
            '''DBConnFacturas.Close()

        End Function

        Public Function CobrosReciboCajaTran(ByVal Recibo As String) As DataSet
            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CobrosReciboCaja", DBConnFacturas)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Recibo As New SqlParameter("@Recibo", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Recibo.Value = Recibo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Recibo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.SelectCommand.Connection = DBConnFacturas
            DBCommand.SelectCommand.Transaction = transaccionFacturas

            DBCommand.Fill(dsFicha, "Cobros")

            'DBConn.Close()

            Return dsFicha

        End Function

        Public Function CobrosReciboCaja(ByVal Recibo As String,
                                         Serie As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_CobrosReciboCaja", DBConn)
            DBCommand = New SqlDataAdapter("sp_CobrosReciboCaja", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Recibo As New SqlParameter("@Recibo", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Recibo.Value = Recibo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Recibo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)
            DBCommand.SelectCommand.Parameters.AddWithValue("@Serie", Serie)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function FacturacionXDia(ByVal Fecha As Date, Optional ByVal Caja As Integer = 0) As FacturacionXDia
            Dim Details As New FacturacionXDia

            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_FacturacionXDia", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pcaja As New SqlParameter("@Caja", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pFecha.Value = Fecha
            pcaja.Value = Caja

            cmd.Parameters.Add(pEmpresa)
            cmd.Parameters.Add(pFecha)
            cmd.Parameters.Add(pcaja)

            Dim pTotal As SqlParameter = New SqlParameter("@Total", SqlDbType.Float)
            pTotal.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotal)

            Dim pTotalContado As SqlParameter = New SqlParameter("@TotalContado", SqlDbType.Float)
            pTotalContado.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalContado)

            Dim pTotalCredito As SqlParameter = New SqlParameter("@TotalCredito", SqlDbType.Float)
            pTotalCredito.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalCredito)

            Dim pTotalCobros As SqlParameter = New SqlParameter("@TotalCobros", SqlDbType.Float)
            pTotalCobros.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalCobros)

            Dim pTotalAdelantos As SqlParameter = New SqlParameter("@TotalAdelantos", SqlDbType.Float)
            pTotalAdelantos.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalAdelantos)


            ''05/05/2006
            'Contado
            Dim pTotalChequesContado As SqlParameter = New SqlParameter("@TotalChequesContado", SqlDbType.Float)
            pTotalChequesContado.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalChequesContado)

            Dim pTotalTarjetasContado As SqlParameter = New SqlParameter("@TotalTarjetasContado", SqlDbType.Float)
            pTotalTarjetasContado.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalTarjetasContado)

            Dim pTotalEfectivoContado As SqlParameter = New SqlParameter("@TotalEfectivoContado", SqlDbType.Float)
            pTotalEfectivoContado.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalEfectivoContado)

            Dim pTotalNotasDebitoContado As SqlParameter = New SqlParameter("@TotalNotasDebitoContado", SqlDbType.Float)
            pTotalNotasDebitoContado.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalNotasDebitoContado)

            'Credito
            Dim pTotalChequesCredito As SqlParameter = New SqlParameter("@TotalChequesCredito", SqlDbType.Float)
            pTotalChequesCredito.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalChequesCredito)

            Dim pTotalTarjetasCredito As SqlParameter = New SqlParameter("@TotalTarjetasCredito", SqlDbType.Float)
            pTotalTarjetasCredito.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalTarjetasCredito)

            Dim pTotalEfectivoCredito As SqlParameter = New SqlParameter("@TotalEfectivoCredito", SqlDbType.Float)
            pTotalEfectivoCredito.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalEfectivoCredito)

            Dim pTotalNotasDebitoCredito As SqlParameter = New SqlParameter("@TotalNotasDebitoCredito", SqlDbType.Float)
            pTotalNotasDebitoCredito.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalNotasDebitoCredito)


            'Abonos
            Dim pTotalChequesAbonos As SqlParameter = New SqlParameter("@TotalChequesAbonos", SqlDbType.Float)
            pTotalChequesAbonos.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalChequesAbonos)

            Dim pTotalTarjetasAbonos As SqlParameter = New SqlParameter("@TotalTarjetasAbonos", SqlDbType.Float)
            pTotalTarjetasAbonos.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalTarjetasAbonos)

            Dim pTotalEfectivoAbonos As SqlParameter = New SqlParameter("@TotalEfectivoAbonos", SqlDbType.Float)
            pTotalEfectivoAbonos.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalEfectivoAbonos)

            Dim pTotalNotasDebitoAbonos As SqlParameter = New SqlParameter("@TotalNotasDebitoAbonos", SqlDbType.Float)
            pTotalNotasDebitoAbonos.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalNotasDebitoAbonos)

            'total agregado el 29022008 rmpr
            Dim pTotalRetenciones As SqlParameter = New SqlParameter("@TotalRetenciones", SqlDbType.Float)
            pTotalRetenciones.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pTotalRetenciones)

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            Details.TotalRetenciones = pTotalRetenciones.Value

            Details.Total = pTotal.Value
            Details.TotalContado = pTotalContado.Value
            Details.TotalCredito = pTotalCredito.Value
            Details.TotalCobros = pTotalCobros.Value
            Details.TotalAdelantos = pTotalAdelantos.Value

            'Contado
            Details.TotalChequesContado = pTotalChequesContado.Value
            Details.TotalTarjetasContado = pTotalTarjetasContado.Value
            Details.TotalEfectivoContado = pTotalEfectivoContado.Value
            Details.TotalNotasDebitoContado = pTotalNotasDebitoContado.Value

            'Credito
            Details.TotalChequesCredito = pTotalChequesCredito.Value
            Details.TotalTarjetasCredito = pTotalTarjetasCredito.Value
            Details.TotalEfectivoCredito = pTotalEfectivoCredito.Value
            Details.TotalNotasDebitoCredito = pTotalNotasDebitoCredito.Value

            'Abonos
            Details.TotalChequesAbonos = pTotalChequesAbonos.Value
            Details.TotalTarjetasAbonos = pTotalTarjetasAbonos.Value
            Details.TotalEfectivoAbonos = pTotalEfectivoAbonos.Value
            Details.TotalNotasDebitoAbonos = pTotalNotasDebitoAbonos.Value

            Return Details

        End Function

        Public Function RecibosCobros(ByVal Cliente As String, ByVal Fecha1 As String, ByVal Fecha2 As String,
                ByVal Tipo As String, ByVal Recibo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RecibosCobros", DBConn)
            'DBCommand = New SqlDataAdapter("sp_MaestroRecibos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pRecibo As New SqlParameter("@Recibo", SqlDbType.NVarChar)

            pCliente.Value = Cliente
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual
            pRecibo.Value = Recibo

            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pRecibo)

            DBCommand.SelectCommand.CommandTimeout = 0
            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function NotasDebitoXCliente(ByVal Cliente As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_NotasDebitoXCliente", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pCliente.Value = Cliente
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CobrosNotasDebito(ByVal Mes As String, ByVal Anio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CobrosNotasDebito", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pAnio As New SqlParameter("@Anio", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pMes.Value = Mes
            pAnio.Value = Anio
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pAnio)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function VentasPerdidasUpdateFactura(ByVal Numero As String, ByVal Usuario As String, ByVal Factura As String)

            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_VentasPerdidasUpdateFactura", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pNumero As New SqlParameter("@Numero", SqlDbType.Real)
            Dim pUsuario As New SqlParameter("@Usuario", SqlDbType.NVarChar)
            Dim pFactura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim pEmpresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            pNumero.Value = Numero
            pUsuario.Value = Usuario
            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pNumero)
            cmd.Parameters.Add(pUsuario)
            cmd.Parameters.Add(pFactura)
            cmd.Parameters.Add(pEmpresa)

            ' Open the connection and execute the Command
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function VentasPerdidasBuscar(ByVal Numero As String, ByVal Item As String, ByVal Usuario As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_VentasPerdidasBuscar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim pNumero As New SqlParameter("@Numero", SqlDbType.Real)
            Dim pItem As New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim pUsuario As New SqlParameter("@Usuario", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pNumero.Value = Numero
            pItem.Value = Item
            pUsuario.Value = Usuario
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pNumero)
            DBCommand.SelectCommand.Parameters.Add(pItem)
            DBCommand.SelectCommand.Parameters.Add(pUsuario)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "VentasPerdidas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function VentasPerdidasDetalle(ByVal Numero As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_VentasPerdidasDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pNumero As New SqlParameter("@Numero", SqlDbType.Decimal)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pNumero.Value = Numero
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pNumero)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "VentasPerdidas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function VentasPerdidasListDetalle(ByVal Cliente As String, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Producto As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_VentasPerdidasListDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pProducto As New SqlParameter("@Producto", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pCliente.Value = Cliente
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pProducto.Value = Producto
            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pProducto)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "VentasPerdidas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function VentasPerdidasList(ByVal Cliente As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_VentasPerdidasList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pCliente.Value = Cliente
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "VentasPerdidas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function VentaPerdidaNumero() As Long
            Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_CotizacionNumero", DBConn)

            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim cmd As SqlCommand = New SqlCommand("_VentasPerdidasNumero", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            'Dim pCotizacion As New SqlParameter("@Cotizacion", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)


            Dim pNumero As SqlParameter = New SqlParameter("@Numero", SqlDbType.Decimal)
            pNumero.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pNumero)


            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            ' Return the Total
            If pNumero.Value.ToString() <> "" Then
                Return CType(pNumero.Value, Long)
            Else
                Return 1
            End If

        End Function


        Public Function VentasPerdidasAddItem(ByVal Numero As String, ByVal Item As String, ByVal Usuario As String, ByVal Cliente As String, ByVal Vendedor As String, ByVal Cantidad As String, ByVal Precio As String, ByVal Tipo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_VentasPerdidasAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.Decimal)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar)
            Dim _Usuario As SqlParameter = New SqlParameter("@Usuario", SqlDbType.NVarChar)
            Dim _Cliente As SqlParameter = New SqlParameter("@Cliente", SqlDbType.NVarChar)
            Dim _Vendedor As SqlParameter = New SqlParameter("@Vendedor", SqlDbType.NVarChar)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float)
            Dim _Precio As SqlParameter = New SqlParameter("@Precio", SqlDbType.Float)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Numero.Value = Numero
            _Item.Value = Item
            _Usuario.Value = Usuario
            _Cliente.Value = Cliente
            _Vendedor.Value = Vendedor
            _Cantidad.Value = Cantidad
            _Precio.Value = Precio
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Usuario)
            cmd.Parameters.Add(_Cliente)
            cmd.Parameters.Add(_Vendedor)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Precio)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

        End Function
        Public Function DevolucionesFacturas(ByVal Fecha1 As Date, ByVal Fecha2 As String) As DataSet

        End Function

        Public Function DevolucionesFacturas(ByVal Factura As String, ByVal Filtro As String, ByVal Tipo As String, ByVal Mes As String, ByVal Estado As String, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal BuscarPor As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DevolucionesFacturas", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.Int)
            Dim pBuscarPor As New SqlParameter("@BuscarPor", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            If Fecha1 = "" Then
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            Else
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.DateTime)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            End If

            pFactura.Value = Factura
            pFiltro.Value = Filtro
            pTipo.Value = Tipo
            pMes.Value = Mes
            pEstado.Value = Estado
            pBuscarPor.Value = BuscarPor
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pBuscarPor)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturaCobro(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturaCobro", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturaSalida(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturaSalida", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function UpdateFacturaEstado(ByVal Factura As String, ByVal Estado As Boolean)

            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_FacturasVentasUpdateEstado", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.Bit)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Estado.Value = Estado
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Estado)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Shared Function ListaClientes(ByVal Filtro As String, ByVal Estado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ClientesLista", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFiltro.Value = Filtro
            pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.SelectCommand.CommandTimeout = 0
            DBCommand.Fill(dsFicha, "CLIENTES")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturaDetalleSalida(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturaDetalleSalida", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturaDetalleDevolucion(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturaDetalleDevolucion", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function EstadoCuentaProveedorReporte(ByVal ProveedorID As String, ByVal Mes As String, ByVal FormaPago As String,
                                    ByVal Fecha As String, ByVal FechaDesde As DateTime, ByVal FechaHasta As DateTime,
                                    Optional ByVal Cuenta As String = "%") As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EstadoCuentaProveedorReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            pProveedor.Value = ProveedorID
            DBCommand.SelectCommand.Parameters.Add(pProveedor)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Dim _FormaPago As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            _FormaPago.Value = FormaPago
            DBCommand.SelectCommand.Parameters.Add(_FormaPago)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
            _Fecha.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha)


            Dim _Periodo As New SqlParameter("@Periodo", SqlDbType.NVarChar)
            _Periodo.Value = PeriodosDB.Activo(FechaHasta)
            DBCommand.SelectCommand.Parameters.Add(_Periodo)

            'If FechaDesde = "" Then
            '    Dim _Fechadesde As New SqlParameter("@Fechadesde", SqlDbType.NVarChar)
            '    _Fechadesde.Value = FechaDesde
            '    DBCommand.SelectCommand.Parameters.Add(_Fechadesde)
            'Else
            Dim _Fechadesde As New SqlParameter("@Fechadesde", SqlDbType.DateTime)
            _Fechadesde.Value = FechaDesde
            DBCommand.SelectCommand.Parameters.Add(_Fechadesde)
            'End If

            'If FechaHasta = "" Then
            '    Dim _FechaHasta As New SqlParameter("@FechaHasta", SqlDbType.NVarChar)
            '    _FechaHasta.Value = FechaHasta
            '    DBCommand.SelectCommand.Parameters.Add(_FechaHasta)
            'Else
            Dim _FechaHasta As New SqlParameter("@FechaHasta", SqlDbType.DateTime)
            _FechaHasta.Value = FechaHasta 'CDate(FechaHasta).AddDays(1)
            DBCommand.SelectCommand.Parameters.Add(_FechaHasta)
            'End If

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim EmpresasDB As New VB.SysContab.EmpresasDB

            Dim _EmpresaName As New SqlParameter("@EmpresaName", SqlDbType.NVarChar)
            _EmpresaName.Value = EmpresasDB.GetDetails(EmpresaActual).Nombre
            DBCommand.SelectCommand.Parameters.Add(_EmpresaName)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Cuenta
            DBCommand.SelectCommand.Parameters.Add(_Cuenta)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function EstadoCuentaProveedorReporte(ByVal FechaDesde As DateTime, ByVal FechaHasta As DateTime,
                                                        ByVal Cuenta As String, Proveedor As Integer) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("sp_GetSaldosProveedor", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Fechadesde As New SqlParameter("@Fechadesde", SqlDbType.DateTime)
            _Fechadesde.Value = FechaDesde
            DBCommand.SelectCommand.Parameters.Add(_Fechadesde)

            Dim _FechaHasta As New SqlParameter("@FechaHasta", SqlDbType.DateTime)
            _FechaHasta.Value = FechaHasta
            DBCommand.SelectCommand.Parameters.Add(_FechaHasta)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Cuenta
            DBCommand.SelectCommand.Parameters.Add(_Cuenta)

            Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            _Proveedor.Value = Proveedor
            DBCommand.SelectCommand.Parameters.Add(_Proveedor)

            DBCommand.Fill(dsFicha, "Facturas_Compras")
            DBConn.Close()

            Return dsFicha
        End Function


        Public Function EstadoCuentaReporte(ByVal Cliente As String, ByVal Mes As String, ByVal FormaPago As String,
                                            ByVal Fecha As String, ByVal FechaDesde As DateTime, ByVal FechaHasta As DateTime) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EstadoCuentaReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            pCliente.Value = Cliente
            DBCommand.SelectCommand.Parameters.Add(pCliente)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Dim _FormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)
            _FormaPago.Value = FormaPago
            DBCommand.SelectCommand.Parameters.Add(_FormaPago)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
            _Fecha.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha)

            'If FechaDesde = "" Then
            '    Dim _Fechadesde As New SqlParameter("@Fechadesde", SqlDbType.NVarChar)
            '    _Fechadesde.Value = FechaDesde
            '    DBCommand.SelectCommand.Parameters.Add(_Fechadesde)
            'Else
            Dim _Fechadesde As New SqlParameter("@Fechadesde", SqlDbType.DateTime)
            _Fechadesde.Value = FechaDesde
            DBCommand.SelectCommand.Parameters.Add(_Fechadesde)
            'End If

            'If FechaHasta = "" Then
            '    Dim _FechaHasta As New SqlParameter("@FechaHasta", SqlDbType.NVarChar)
            '    _FechaHasta.Value = FechaHasta
            '    DBCommand.SelectCommand.Parameters.Add(_FechaHasta)
            'Else
            Dim _FechaHasta As New SqlParameter("@FechaHasta", SqlDbType.DateTime)
            _FechaHasta.Value = FechaHasta 'CDate(FechaHasta).AddDays(1)  sepa judas de donde salio 28052008
            DBCommand.SelectCommand.Parameters.Add(_FechaHasta)
            'End If

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim EmpresasDB As New VB.SysContab.EmpresasDB

            Dim _EmpresaName As New SqlParameter("@EmpresaName", SqlDbType.NVarChar)
            _EmpresaName.Value = EmpresasDB.GetDetails(EmpresaActual).Nombre
            DBCommand.SelectCommand.Parameters.Add(_EmpresaName)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ChequesXBancoEstado(ByVal Banco As String, ByVal Fecha As Date, ByVal Estado As String) As DataSet

            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ChequesXBanco1", DBConnFacturas)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pBanco As New SqlParameter("@Banco", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pBanco.Value = Banco
            pFecha.Value = Fecha
            pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pBanco)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            'DBCommand.Fill(dsFicha, "Cobros")

            DBCommand.SelectCommand.Connection = DBConnFacturas
            DBCommand.SelectCommand.Transaction = transaccionFacturas

            DBCommand.Fill(dsFicha, "Cobros")

            'DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasIVA(ByVal Mes As String, ByVal TipoArt As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            DBCommand = New SqlDataAdapter("_GetListReporteIVA", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pTipoArt As New SqlParameter("@TipoFac", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pMes.Value = Mes
            pTipoArt.Value = TipoArt

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pTipoArt)

            Try
                DBCommand.Fill(dsFicha, "Facturas_Ventas_Lineas")
            Catch e As Exception
                MsgBox(e.Message)
            End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ArqueosDetallesEfectivoDelete(ByVal Arqueo As String, ByVal Fecha As Date)
            Dim cmd As SqlCommand = New SqlCommand("_ArqueoDetallesEfectivoDelete", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Arqueo As SqlParameter = New SqlParameter("@Arqueo", SqlDbType.NVarChar)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)


            _Arqueo.Value = Arqueo
            _Fecha.Value = Fecha
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Arqueo)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas 'Lineas
            cmd.ExecuteNonQuery()

        End Function

        Public Function ArqueosDetallesDelete(ByVal Arqueo As String, ByVal Cobro As String)
            Dim cmd As SqlCommand = New SqlCommand("_ArqueoDetallesDelete", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Arqueo As SqlParameter = New SqlParameter("@ArqueoID", SqlDbType.NVarChar)
            Dim _Cobro As SqlParameter = New SqlParameter("@CobroID", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)


            _Arqueo.Value = Arqueo
            _Cobro.Value = Cobro
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Arqueo)
            cmd.Parameters.Add(_Cobro)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas 'Lineas
            cmd.ExecuteNonQuery()

        End Function

        Public Function ArqueosList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ArqueosList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'Dim pFecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            'pFecha.Value = Fecha
            pEmpresa.Value = EmpresaActual

            'DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ArqueosAdd(ByVal Arqueo_Numero As String, ByVal Fecha As String)
            Dim cmd As SqlCommand = New SqlCommand("_ArqueoAdd", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure


            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Numero.Value = Arqueo_Numero
            _Fecha.Value = Fecha
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            '15/11/2005
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function ArqueoNumero(ByVal Fecha As String) As Integer
            Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_CotizacionNumero", DBConn)

            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim cmd As SqlCommand = New SqlCommand("_ArqueoNumero", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pArqueo As SqlParameter = New SqlParameter("@Arqueo", SqlDbType.Int, 4)
            pArqueo.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pArqueo)

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
            pFecha.Value = Fecha
            cmd.Parameters.Add(pFecha)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            ' Return the Total
            If pArqueo.Value.ToString() <> "" Then
                Return CType(pArqueo.Value, Integer)
            Else
                Return 1
            End If
        End Function

        Public Function CobrosArquear(ByVal Fecha As Date, Optional ByVal Caja As Integer = 0) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CobrosArquear", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pCaja As New SqlParameter("@Caja", SqlDbType.Int)

            pFecha.Value = Fecha
            pEmpresa.Value = EmpresaActual
            pCaja.Value = Caja

            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pCaja)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function MaxTotalFactura() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetMaxTotalFactura", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function MaxTotalFacturaLinea() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetMaxTotalFacturaLinea", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas_Lineas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ArqueosDetallesNotaDebitoAdd(ByVal Arqueo_Numero As String, ByVal Fecha As String)
            Dim cmd As SqlCommand = New SqlCommand("_ArqueoDetallesNotaDebitoAdd", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Arqueo As SqlParameter = New SqlParameter("@Arqueo", SqlDbType.Int, 4)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.NVarChar, 50)
            Dim _Fecha1 As SqlParameter = New SqlParameter("@Fecha1", SqlDbType.DateTime, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Arqueo.Value = Arqueo_Numero
            _Fecha.Value = Fecha
            _Fecha1.Value = Fecha
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Arqueo)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Fecha1)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            '15/11/2005
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function ArqueosDetallesEfectivoAdd(ByVal Arqueo_Numero As String, ByVal Fecha As String)
            Dim cmd As SqlCommand = New SqlCommand("_ArqueoDetallesEfectivoAdd", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Arqueo As SqlParameter = New SqlParameter("@Arqueo", SqlDbType.Int, 4)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.NVarChar, 50)
            Dim _Fecha1 As SqlParameter = New SqlParameter("@Fecha1", SqlDbType.DateTime, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Arqueo.Value = Arqueo_Numero
            _Fecha.Value = Fecha
            _Fecha1.Value = Fecha
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Arqueo)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Fecha1)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            '15/11/2005
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function ArqueosDetallesAdd(ByVal Arqueo_Numero As String, ByVal Fecha As Date, ByVal Cobro_ID As String)
            Dim cmd As SqlCommand = New SqlCommand("_ArqueoDetallesAdd", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _Cobro As SqlParameter = New SqlParameter("@Cobro_ID", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Numero.Value = Arqueo_Numero
            _Fecha.Value = Fecha
            _Cobro.Value = Cobro_ID
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Cobro)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            '15/11/2005
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function ChequesXBanco(ByVal Banco As String, ByVal Fecha As Date, ByVal Arqueo As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ChequesXBanco", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pBanco As New SqlParameter("@Banco", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pArqueo As New SqlParameter("@Arqueo", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pBanco.Value = Banco
            pFecha.Value = Fecha
            pArqueo.Value = Arqueo
            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pBanco)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pArqueo)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CobrosUpdateMontoDepositadoRestar(ByVal Numero As String, ByVal Monto As String)
            Dim cmd As SqlCommand = New SqlCommand("_CobrosUpdateMontoDepositadoRestar", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.Int, 4)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Numero.Value = Numero
            _Monto.Value = Monto
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function CobrosUpdateMontoDepositado(ByVal Numero As String, ByVal Monto As String)
            Dim cmd As SqlCommand = New SqlCommand("_CobrosUpdateMontoDepositado", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.Int, 4)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Numero.Value = Numero
            _Monto.Value = Monto
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function CobrosXTotales(ByVal Fecha As Date) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CobrosTotales", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFecha.Value = Fecha
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            'cmd.Connection = DBConnFacturas
            'cmd.Transaction = transaccionFacturas
            'cmd.ExecuteNonQuery()

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CobrosXFecha(ByVal Fecha As String) As DataSet
            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CobrosXFecha", DBConnFacturas)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFecha.Value = Fecha
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            'cmd.Connection = DBConnFacturas
            'cmd.Transaction = transaccionFacturas
            'cmd.ExecuteNonQuery()

            DBCommand.SelectCommand.Connection = DBConnFacturas
            DBCommand.SelectCommand.Transaction = transaccionFacturas
            DBCommand.Fill(dsFicha, "Cobros")

            'DBConn.Close()


            Return dsFicha

        End Function

        Public Function CobrosNumero() As Integer
            'Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_CobrosNumero", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)


            Dim pNumero As SqlParameter = New SqlParameter("@Numero", SqlDbType.Int, 4)
            pNumero.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pNumero)

            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            ' Return the Total
            If pNumero.Value.ToString() <> "" Then
                Return CType(pNumero.Value, Integer)
            Else
                Return 1
            End If

        End Function

        Public Function CobrosUpdateEstado(ByVal Numero As String, ByVal Estado As String)
            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_CobrosUpdateEstado", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.Int, 4)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Numero.Value = Numero
            _Estado.Value = Estado
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Estado)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            '15/11/2005
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function FacturasVencidas(ByVal Cliente As String, ByVal Tipo As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasVencidas", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)

            If Fecha1 = "" Then
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            Else
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.DateTime)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            End If

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pCliente.Value = Cliente
            pTipo.Value = Tipo
            'pFecha1.Value = Fecha1
            'pFecha2.Value = Fecha2
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            'DBCommand.SelectCommand.Parameters.Add(pFecha1)
            'DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasPendientes(ByVal Cliente As String, ByVal Tipo As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasPendientes", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)

            If Fecha1 = "" Then
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            Else
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.DateTime)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            End If

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pCliente.Value = Cliente
            pTipo.Value = Tipo
            'pFecha1.Value = Fecha1
            'pFecha2.Value = Fecha2
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            'DBCommand.SelectCommand.Parameters.Add(pFecha1)
            'DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasReporte(ByVal Filtro As String, ByVal Tipo As String, ByVal Mes As String,
                    ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal Vendedor As String, ByVal Proveedor As String,
                    ByVal CodArticulo As String, ByVal Articulo As String, ByVal Linea As String, ByVal Grupo As String,
                    ByVal SubGrupos As String, ByVal FacRango1 As String, ByVal FacRango2 As String, ByVal TipoFac2 As String,
                    ByVal TipoArt As String, ByVal ArtMin As String, ByVal ArtMax As String, ByVal Orden As Integer) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListReporteFacturas", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@TipoFac", SqlDbType.Int)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.SmallDateTime)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.SmallDateTime)
            Dim pVendedor As New SqlParameter("@Vendedor", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            'Dim pNoFactura As New SqlParameter("@NoFactura", SqlDbType.Int)
            Dim pCodArticulo As New SqlParameter("@CodArticulo", SqlDbType.NVarChar)
            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim pTipoArt As New SqlParameter("@TipoArt", SqlDbType.NVarChar)
            Dim pLinea As New SqlParameter("@Linea", SqlDbType.NVarChar)
            Dim pGrupo As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim pSubGrupos As New SqlParameter("@SubGrupo", SqlDbType.NVarChar)
            'Dim pOrden As New SqlParameter("@Orden", SqlDbType.NVarChar)
            Dim pFacRango1 As New SqlParameter("@FacRango1", SqlDbType.Float)
            Dim pFacRango2 As New SqlParameter("@FacRango2", SqlDbType.Float)
            Dim pTipoFac2 As New SqlParameter("@TipoFac2", SqlDbType.NVarChar)
            Dim pArtMin As New SqlParameter("@ArtMin", SqlDbType.Float)
            Dim pArtMAx As New SqlParameter("@ArtMax", SqlDbType.Float)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pFiltro.Value = Filtro
            pTipo.Value = Tipo
            pTipoFac2.Value = TipoFac2
            pMes.Value = Mes
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pVendedor.Value = Vendedor
            pProveedor.Value = Proveedor
            'pNoFactura.Value = NoFactura
            pCodArticulo.Value = CodArticulo
            pArticulo.Value = Articulo
            pTipoArt.Value = TipoArt
            pLinea.Value = Linea
            pGrupo.Value = Grupo
            pSubGrupos.Value = SubGrupos
            'pOrden.Value = Orden
            pFacRango1.Value = FacRango1
            pFacRango2.Value = FacRango2
            pArtMin.Value = ArtMin
            pArtMAx.Value = ArtMax
            pOrden.Value = Orden

            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pTipoFac2)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pVendedor)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            'DBCommand.SelectCommand.Parameters.Add(pNoFactura)
            DBCommand.SelectCommand.Parameters.Add(pCodArticulo)
            DBCommand.SelectCommand.Parameters.Add(pArticulo)
            DBCommand.SelectCommand.Parameters.Add(pTipoArt)
            DBCommand.SelectCommand.Parameters.Add(pLinea)
            DBCommand.SelectCommand.Parameters.Add(pGrupo)
            DBCommand.SelectCommand.Parameters.Add(pSubGrupos)
            'DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.SelectCommand.Parameters.Add(pFacRango1)
            DBCommand.SelectCommand.Parameters.Add(pFacRango2)
            DBCommand.SelectCommand.Parameters.Add(pArtMin)
            DBCommand.SelectCommand.Parameters.Add(pArtMAx)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            Try

                DBCommand.Fill(dsFicha, "Facturas_Ventas")
            Catch e As Exception
                MsgBox(e.Message)
            End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function PagosXCliente(ByVal Cliente As String, ByVal Tipo As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PagosXCliente", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)

            If Fecha1 = "" Then
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            Else
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.DateTime)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            End If

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pCliente.Value = Cliente
            pTipo.Value = Tipo
            'pFecha1.Value = Fecha1
            'pFecha2.Value = Fecha2
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            'DBCommand.SelectCommand.Parameters.Add(pFecha1)
            'DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasXTipo(ByVal Cliente As String, ByVal Tipo As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasXTipo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)

            If Fecha1 = "" Then
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            Else
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.DateTime)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            End If

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pCliente.Value = Cliente
            pTipo.Value = Tipo
            'pFecha1.Value = Fecha1
            'pFecha2.Value = Fecha2
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            'DBCommand.SelectCommand.Parameters.Add(pFecha1)
            'DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function EstadoCuenta(ByVal Cliente As String, Moneda As String) As DataTable

            Return ObtieneDatos("_EstadoCuentaList",
                                Cliente,
                                EmpresaActual,
                                Moneda)

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet

            'Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_EstadoCuentaList", DBConn)

            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            'Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            'pCliente.Value = Cliente
            'pEmpresa.Value = EmpresaActual

            'DBCommand.SelectCommand.Parameters.Add(pCliente)
            'DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            'DBCommand.Fill(dsFicha, "Clientes")

            'DBConn.Close()

            'Return dsFicha

        End Function

        Public Function ClientesList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ClientesList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Clientes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturaNumero(ByVal serie As String, ByVal MultiSerie As Boolean) As Integer
            Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_CotizacionNumero", DBConn)

            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim cmd As SqlCommand = New SqlCommand("_FacturaNumero", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            'Dim pCotizacion As New SqlParameter("@Cotizacion", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Float)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim pserie As New SqlParameter("@serie", SqlDbType.NVarChar)
            pserie.Value = serie
            cmd.Parameters.Add(pserie)

            Dim pmultiserie As New SqlParameter("@multiserie", SqlDbType.Bit)
            pmultiserie.Value = MultiSerie
            cmd.Parameters.Add(pmultiserie)


            Dim pFactura As SqlParameter = New SqlParameter("@Factura", SqlDbType.Int, 4)
            pFactura.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pFactura)


            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            'cmd.Connection = DBConnFacturas
            'cmd.Transaction = transaccionFacturas 'Lineas
            'cmd.ExecuteNonQuery()

            ' Return the Total
            If pFactura.Value.ToString() <> "" Then
                Return CType(pFactura.Value, Integer)
            Else
                Return 1
            End If

        End Function

        ''''''Public Function GetPedidoMaxCLiente(ByVal CliID As String) As Double

        ''''''    ' Create Instance of Connection and Command Object
        ''''''    Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
        ''''''    Dim cmd As SqlCommand = New SqlCommand("_PedidoMaxCliente", conn)

        ''''''    ' Mark the Command as a SPROC
        ''''''    cmd.CommandType = CommandType.StoredProcedure

        ''''''    ' Add Parameters to SPROC
        ''''''    Dim _CliID As SqlParameter = New SqlParameter("@CliID", SqlDbType.NVarChar, 50)
        ''''''    _CliID.Value = CliID
        ''''''    cmd.Parameters.Add(_CliID)

        ''''''    Dim parameterTotalCost As SqlParameter = New SqlParameter("@TotalCost", SqlDbType.Money, 8)
        ''''''    parameterTotalCost.Direction = ParameterDirection.Output
        ''''''    cmd.Parameters.Add(parameterTotalCost)

        ''''''    ' Open the connection and execute the Command
        ''''''    conn.Open()
        ''''''    cmd.ExecuteNonQuery()
        ''''''    conn.Close()

        ''''''    ' Return the Total
        ''''''    If parameterTotalCost.Value.ToString() <> "" Then
        ''''''        Return CType(parameterTotalCost.Value, Double)
        ''''''    Else
        ''''''        Return 0
        ''''''    End If

        ''''''End Function

        Public Function CobrosXFacturaAll(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CobrosxFacturaAll", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CobrosXRecibo(ByVal Recibo As String, ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CobrosxRecibo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pRecibo As New SqlParameter("@Recibo", SqlDbType.NVarChar)
            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pRecibo.Value = Recibo
            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pRecibo)
            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CobrosHistorial(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CobrosSaldoFactura", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Function CotizacionNumero() As Integer
            Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_CotizacionNumero", DBConn)

            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim cmd As SqlCommand = New SqlCommand("_CotizacionNumero", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            'Dim pCotizacion As New SqlParameter("@Cotizacion", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)


            Dim parameterCotizacion As SqlParameter = New SqlParameter("@Cotizacion", SqlDbType.Int, 4)
            parameterCotizacion.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterCotizacion)


            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            ' Return the Total
            If parameterCotizacion.Value.ToString() <> "" Then
                Return CType(parameterCotizacion.Value, Integer)
            Else
                Return 1
            End If

        End Function

        Public Function AddCotizacionLineas(ByVal Cotizacion As String, ByVal Item As String, ByVal Cantidad As String,
                                            ByVal Precio As String, ByVal Descuento As String, ByVal Total As String,
                                            ByVal Comision As String, ByVal Tipo As String, ByVal Iva As String)


            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_CotizacionesLineasAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Cotizacion As SqlParameter = New SqlParameter("@Cotizacion", SqlDbType.NVarChar, 50)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float, 8)
            Dim _Precio As SqlParameter = New SqlParameter("@Precio", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Comision As SqlParameter = New SqlParameter("@Comision", SqlDbType.Float, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Cotizacion.Value = Cotizacion
            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Precio.Value = Precio
            _Descuento.Value = Descuento
            _Total.Value = Total
            _Comision.Value = Comision
            _Tipo.Value = Tipo
            _Iva.Value = Iva
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Cotizacion)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Precio)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_Comision)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Empresa)


            ' Open the connection and execute the Command

            'MsgBox(DBConnFacturasLineas.ConnectionTimeout)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas 'Lineas
            cmd.ExecuteNonQuery()

            ''''DBConn.Open()
            ''''cmd.ExecuteNonQuery()
            ''''DBConn.Close()

        End Function

        Public Function AddCotizacion(ByVal Cotizacion As String, ByVal Descripcion As String, ByVal Fecha_Vencimiento As String, ByVal Cliente As String,
                                      ByVal SubTotal As String, ByVal Descuento As String, ByVal Iva As String,
                                      ByVal Total As String, ByVal Vendedor As String)


            ' Create Instance of Connection and Command Object

            '''Dim DBConn As SqlConnection

            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas

            ''''DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            ''''Dim cmd As SqlCommand = New SqlCommand("_FacturasVentasAdd", DBConn)

            Dim cmd As SqlCommand = New SqlCommand("_CotizacionesAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Cotizacion As SqlParameter = New SqlParameter("@Cotizacion", SqlDbType.NVarChar, 50)
            Dim _Descripcion As SqlParameter = New SqlParameter("@Descripcion", SqlDbType.NVarChar, 8)
            Dim _Fecha_Vencimiento As SqlParameter = New SqlParameter("@Fecha_Vencimiento", SqlDbType.DateTime, 8)
            Dim _Cliente As SqlParameter = New SqlParameter("@Cliente", SqlDbType.Int, 4)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Vendedor As SqlParameter = New SqlParameter("@Vendedor", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Cotizacion.Value = Cotizacion
            _Descripcion.Value = Descripcion
            _Fecha_Vencimiento.Value = Fecha_Vencimiento
            _Cliente.Value = Cliente
            _SubTotal.Value = SubTotal
            _Descuento.Value = Descuento
            _Iva.Value = Iva
            _Total.Value = Total
            _Vendedor.Value = Vendedor
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Cotizacion)
            cmd.Parameters.Add(_Descripcion)
            cmd.Parameters.Add(_Fecha_Vencimiento)
            cmd.Parameters.Add(_Cliente)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_Vendedor)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            '''DBConn.Open()
            'DBConnFacturas.Open()
            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
            ''''DBConn.Close()
            '''DBConnFacturas.Close()

        End Function

        Public Function CobrosxFactura(ByVal Tipo As Integer, ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CobrosxFactura", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pTipo.Value = Tipo 'Tipo de Pago. 1 = Efectivo, 2 = CK, 3 = Tarjeta de Crédito
            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            If Tipo = 1 Then
                DBCommand.Fill(dsFicha, "Cobros")
            ElseIf Tipo = 2 Then
                DBCommand.Fill(dsFicha, "Recibo_Cheques")
            Else
                DBCommand.Fill(dsFicha, "Recibo_Tarjetas")
            End If

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function DepositosBancoEmisor(ByVal Tipo As String, ByVal Filtro As String, ByVal Fecha As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DepositosBancoEmisor", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            'If Fecha = "" Then
            'Dim pFecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
            'pFecha.Value = Fecha
            'DBCommand.SelectCommand.Parameters.Add(pFecha)

            'Else
            '    Dim pFecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            '    pFecha.Value = Fecha
            '    DBCommand.SelectCommand.Parameters.Add(pFecha)
            'End If

            pTipo.Value = Tipo
            pFiltro.Value = Filtro
            pFecha.Value = Fecha
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Depositos(ByVal Tipo As String, ByVal Estado As String, ByVal Fecha As String,
                                  ByVal Banco As String, ByVal Resumido As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Depositos", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.Int)
            Dim pBanco As New SqlParameter("@Banco", SqlDbType.Int)
            Dim pResumido As New SqlParameter("@Resumido", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            'Dim pTodos As New SqlParameter("@Todos", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pTipo.Value = Tipo
            pFecha.Value = Fecha
            pEstado.Value = Estado
            pBanco.Value = Banco
            pResumido.Value = Resumido
            'pTodos.Value = Todos
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pBanco)
            DBCommand.SelectCommand.Parameters.Add(pResumido)
            'DBCommand.SelectCommand.Parameters.Add(pTodos)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            'Try
            DBCommand.Fill(dsFicha, "Cobros")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try


            DBConn.Close()
            Return dsFicha
        End Function

        Public Function ComprobanteBuscarXFactura(ByVal Factura As String, ByVal Proveedor As Integer) As DataSet
            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComprobantesBuscarXFactura", DBConnFacturas)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual
            pProveedor.Value = Proveedor

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)

            DBCommand.SelectCommand.Connection = DBConnFacturas
            DBCommand.SelectCommand.Transaction = transaccionFacturas

            DBCommand.Fill(dsFicha, "Tabla")

            'DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturaDetalle(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturaDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ClientesBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ClientesBuscar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Clientes")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function Acumulados(ByVal Cliente As String, ByVal Anio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ClientesAcumulados", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.NVarChar)
            Dim pAnio As New SqlParameter("@Anio", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pCliente.Value = Cliente
            pAnio.Value = Anio
            pEmpresa.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pAnio)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AcumuladosDevoluciones(ByVal Cliente As String, ByVal Anio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ClientesAcumuladosDevoluciones", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.NVarChar)
            Dim pAnio As New SqlParameter("@Anio", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pCliente.Value = Cliente
            pAnio.Value = Anio
            pEmpresa.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pAnio)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub FacturaDelete(ByVal Factura As String)
            ' Create Instance of Connection and Command Object

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_FacturaDelete", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Factura.Value = Factura
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        'Public Function FacturaNumero() As DataSet
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet()

        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_FacturaNumero", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

        '    pEmpresa.Value = EmpresaActual

        '    DBCommand.SelectCommand.Parameters.Add(pEmpresa)

        '    DBCommand.Fill(dsFicha, "Facturas_Ventas")

        '    DBConn.Close()

        '    Return dsFicha

        'End Function

        Public Function FacturasPrint(ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasVentasPrint", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            'Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pFactura.Value = Factura
            'pCliente.Value = Cliente
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            'DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub AddFacturaLineas(ByVal Factura As String, ByVal Item As String, ByVal Cantidad As String,
                                         ByVal Precio As String, ByVal Iva As String, ByVal Descuento As String, ByVal Total As String,
                                         ByVal Comision As String, ByVal Tipo As String, ByVal IvaPorcentaje As String,
                                         ByVal ItemDescripcion As String, Optional ByVal Promocion As Double = 0, Optional ByVal Presentacion As String = "",
                                         Optional ByVal Comentario As String = "", Optional Modelo As String = "", Optional NoSerie As String = "")

            'Create Instance of Connection and Command Object
            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()
            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())
            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            'Mark the Command as a SPROC

            Dim cmd As SqlCommand = New SqlCommand("_FacturasVentasLineasAdd", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure

            'FACTURA
            'ITEM
            'CANTIDAD
            'PRECIO
            'DESCUENTO
            'TOTAL
            'EMPRESA

            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float, 8)
            Dim _Precio As SqlParameter = New SqlParameter("@Precio", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Comision As SqlParameter = New SqlParameter("@Comision", SqlDbType.Float, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _IvaPorcentaje As SqlParameter = New SqlParameter("@IvaPorcentaje", SqlDbType.Float, 8)
            Dim _ItemDescripcion As SqlParameter = New SqlParameter("@ItemDescripcion", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Promocion As SqlParameter = New SqlParameter("@Promocion", SqlDbType.Money, 8)
            Dim _Presentacion As SqlParameter = New SqlParameter("@Presentacion", SqlDbType.NVarChar, 50)
            Dim _Comentario As SqlParameter = New SqlParameter("@Comentario", SqlDbType.NVarChar)
            Dim _Modelo As SqlParameter = New SqlParameter("@Modelo", SqlDbType.NVarChar)
            Dim _NoSerie As SqlParameter = New SqlParameter("@NoSerie", SqlDbType.NVarChar)

            _Factura.Value = Factura
            _Item.Value = Item
            _Cantidad.Value = Cantidad
            _Precio.Value = Precio
            _Iva.Value = Iva
            _Descuento.Value = Descuento
            _Total.Value = Total
            _Comision.Value = Comision
            _Tipo.Value = Tipo
            _IvaPorcentaje.Value = IvaPorcentaje
            _ItemDescripcion.Value = ItemDescripcion
            _Empresa.Value = EmpresaActual
            _Promocion.Value = Promocion
            _Presentacion.Value = Presentacion
            _Comentario.Value = Comentario
            _Modelo.Value = Modelo
            _NoSerie.Value = NoSerie

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Precio)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_Comision)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_IvaPorcentaje)
            cmd.Parameters.Add(_ItemDescripcion)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Promocion)
            cmd.Parameters.Add(_Presentacion)
            cmd.Parameters.Add(_Comentario)
            cmd.Parameters.Add(_Modelo)
            cmd.Parameters.Add(_NoSerie)

            'fdsfsfd()
            ' Open the connection and execute the Command

            'MsgBox(DBConnFacturasLineas.ConnectionTimeout)
            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas 'Lineas
            cmd.ExecuteNonQuery()

            ''''DBConn.Open()
            ''''cmd.ExecuteNonQuery()
            ''''DBConn.Close()
        End Sub

        Public Function ListCobros(ByVal Cliente As String, ByVal Fecha As String, ByVal Banco As String, ByVal Emisor As String, ByVal Factura As String, ByVal FormaPago As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetCobros", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
            Dim pBanco As New SqlParameter("@Banco", SqlDbType.NVarChar)
            Dim pEmisor As New SqlParameter("@Emisor", SqlDbType.Int)
            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pFormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            'If Fecha = "  /  /    " Then
            '    Fecha = ""
            'End If

            pCliente.Value = Cliente
            pFecha.Value = Fecha
            pBanco.Value = Banco
            pEmisor.Value = Emisor
            pFactura.Value = Factura
            pFormaPago.Value = FormaPago
            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pBanco)
            DBCommand.SelectCommand.Parameters.Add(pEmisor)
            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pFormaPago)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function DeleteReciboTarjetas(ByVal Factura As String, ByVal Caja As String)
            ' Create Instance of Connection and Command Object

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_ReciboTarjetasDelete", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Caja As SqlParameter = New SqlParameter("@Caja", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Factura.Value = Factura
            _Caja.Value = Caja
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Caja)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function AddReciboTarjetas(ByVal Recibo As String, ByVal Tipo_Tarjeta As String, ByVal Emisor As String, ByVal NoTarjeta As String, ByVal Autorizacion As String, ByVal Monto As String, ByVal Caja As String, ByVal Moneda As String)

            ' Create Instance of Connection and Command Object

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_ReciboTarjetasAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Recibo As SqlParameter = New SqlParameter("@Recibo", SqlDbType.NVarChar, 50)
            Dim _Tipo_Tarjeta As SqlParameter = New SqlParameter("@Tipo_Tarjeta", SqlDbType.NVarChar, 50)
            Dim _Emisor As SqlParameter = New SqlParameter("@Emisor", SqlDbType.NVarChar, 50)
            Dim _NoTarjeta As SqlParameter = New SqlParameter("@Tarjeta", SqlDbType.NVarChar, 50)
            Dim _Autorizacion As SqlParameter = New SqlParameter("@Autorizacion", SqlDbType.NVarChar, 50)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 8)
            Dim _Caja As SqlParameter = New SqlParameter("@Caja", SqlDbType.Int)
            Dim _Moneda As SqlParameter = New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Recibo.Value = Recibo
            _Tipo_Tarjeta.Value = Tipo_Tarjeta
            _Emisor.Value = Emisor
            _NoTarjeta.Value = NoTarjeta
            _Autorizacion.Value = Autorizacion
            _Monto.Value = Monto
            _Caja.Value = Caja
            _Moneda.Value = Moneda
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Recibo)
            cmd.Parameters.Add(_Tipo_Tarjeta)
            cmd.Parameters.Add(_Emisor)
            cmd.Parameters.Add(_NoTarjeta)
            cmd.Parameters.Add(_Autorizacion)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_Caja)
            cmd.Parameters.Add(_Moneda)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function ListReciboTarjetas(ByVal Caja As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetReciboTarjetas", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'Dim pRecibo As New SqlParameter("@Recibo", SqlDbType.NVarChar)
            Dim pCaja As New SqlParameter("@Caja", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pCaja.Value = Caja
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCaja)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Recibo_Tarjetas")
            DBConn.Close()

            Return dsFicha

        End Function

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Public Function DeleteReciboCheques(ByVal Factura As String, ByVal Caja As String)
            ' Create Instance of Connection and Command Object

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_ReciboChequesDelete", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Caja As SqlParameter = New SqlParameter("@Caja", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Factura.Value = Factura
            _Caja.Value = Caja
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Caja)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function AddReciboCheques(ByVal Recibo As String, ByVal NoCheque As String, ByVal Banco As String, ByVal Cuenta As String, ByVal Monto As String, ByVal Moneda As String, ByVal Caja As String)

            ' Create Instance of Connection and Command Object

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_ReciboChequesAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Recibo As SqlParameter = New SqlParameter("@Recibo", SqlDbType.NVarChar, 50)
            Dim _Cheque As SqlParameter = New SqlParameter("@NoCheque", SqlDbType.NVarChar, 50)
            Dim _Banco As SqlParameter = New SqlParameter("@Banco", SqlDbType.NVarChar, 50)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar, 50)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 8)
            Dim _Moneda As SqlParameter = New SqlParameter("@Moneda", SqlDbType.NVarChar, 50)
            Dim _Caja As SqlParameter = New SqlParameter("@Caja", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Recibo.Value = Recibo
            _Cheque.Value = NoCheque
            _Banco.Value = Banco
            _Cuenta.Value = Cuenta
            _Monto.Value = Monto
            _Moneda.Value = Moneda
            _Caja.Value = Caja
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Recibo)
            cmd.Parameters.Add(_Cheque)
            cmd.Parameters.Add(_Banco)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_Moneda)
            cmd.Parameters.Add(_Caja)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function ListReciboCheques(ByVal Caja As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetReciboCheques", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'Dim pRecibo As New SqlParameter("@Recibo", SqlDbType.NVarChar)
            Dim pCaja As New SqlParameter("@Caja", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            'pRecibo.Value = Recibo
            pCaja.Value = Caja
            pEmpresa.Value = EmpresaActual

            'DBCommand.SelectCommand.Parameters.Add(pRecibo)
            DBCommand.SelectCommand.Parameters.Add(pCaja)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Recibo_Cheques")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GenerarTransaccion() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CobrosNoTransaccion", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GenerarReciboTrans() As DataSet
            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_GenerarNoRecibo", DBConn)
            DBCommand = New SqlDataAdapter("_GenerarNoRecibo", DBConnFacturas)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.SelectCommand.Connection = DBConnFacturas
            DBCommand.SelectCommand.Transaction = transaccionFacturas

            DBCommand.Fill(dsFicha, "Cobros")

            'DBConn.Close()

            Return dsFicha

        End Function

        Public Function GenerarRecibo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GenerarNoRecibo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function
        Public Shared Function ValidarRecibo(ByVal Recibo As String,
                                             Serie As String) As Integer
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ReciboBuscar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pRecibo As New SqlParameter("@Recibo", SqlDbType.Int)
            Dim pEncontrado As New SqlParameter("@Encontrado", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pRecibo.Value = Recibo
            pEncontrado.Direction = ParameterDirection.Output

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pRecibo)
            DBCommand.SelectCommand.Parameters.Add(pEncontrado)

            DBCommand.SelectCommand.Parameters.AddWithValue("@Serie", Serie)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return pEncontrado.Value
        End Function

        Public Function ListFacturasXFactura(ByVal Factura As String, ByVal Cliente As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFacturasXFactura", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pFactura.Value = Factura
            pCliente.Value = Cliente
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        'Public Function AddCobro(ByVal Numero As String, ByVal Recibo As String, ByVal Factura As String, ByVal Fecha As String, _
        '                         ByVal Tipo_Pago As String, ByVal Monto As String, ByVal NoCheque As String, _
        '                         ByVal Banco As String, ByVal Cuenta As String, ByVal Monto_Cheque As String, _
        '                         ByVal Tipo_Tarjeta As String, ByVal Emisor As String, ByVal No_Tarjeta As String, _
        '                         ByVal Autorizacion As String, ByVal Monto_Tarjeta As String, ByVal Monto_Efectivo As String, _
        '                         ByVal Moneda As String, ByVal TipoCambio As String, ByVal Saldo As String, _
        '                         ByVal Monto_NotaDebito As String, ByVal CuentaCatalogo As String, ByVal Tipo As String, ByVal Transaccion As String, ByVal Origen As String, ByVal MontoIR As Double)

        '    Dim cmd As SqlCommand = New SqlCommand("_CobrosAdd", DBConnFacturas)

        '    cmd.CommandType = CommandType.StoredProcedure

        '    Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar, 50)
        '    Dim _Recibo As SqlParameter = New SqlParameter("@Recibo", SqlDbType.NVarChar, 50)
        '    Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
        '    Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
        '    Dim _Tipo_Pago As SqlParameter = New SqlParameter("@Tipo_Pago", SqlDbType.Int, 4)
        '    Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 8)
        '    Dim _NoCheque As SqlParameter = New SqlParameter("@NoCheque", SqlDbType.NVarChar, 50)
        '    Dim _Banco As SqlParameter = New SqlParameter("@Banco", SqlDbType.Int, 4)
        '    Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar, 50)
        '    Dim _Monto_Cheque As SqlParameter = New SqlParameter("@Monto_Cheque", SqlDbType.Float, 8)
        '    Dim _Tipo_Tarjeta As SqlParameter = New SqlParameter("@Tipo_Tarjeta", SqlDbType.NVarChar, 50)
        '    Dim _Emisor As SqlParameter = New SqlParameter("@Emisor", SqlDbType.NVarChar, 50)
        '    Dim _No_Tarjeta As SqlParameter = New SqlParameter("@No_Tarjeta", SqlDbType.NVarChar, 50)
        '    Dim _Autorizacion As SqlParameter = New SqlParameter("@Autorizacion", SqlDbType.NVarChar, 50)
        '    Dim _Monto_Tarjeta As SqlParameter = New SqlParameter("@Monto_Tarjeta", SqlDbType.Float, 8)
        '    Dim _Monto_Efectivo As SqlParameter = New SqlParameter("@Monto_Efectivo", SqlDbType.Float, 8)
        '    Dim _Moneda As SqlParameter = New SqlParameter("@Moneda", SqlDbType.NVarChar, 50)
        '    Dim _MontoNotaDebito As SqlParameter = New SqlParameter("@Monto_NotaDebito", SqlDbType.Float, 8)
        '    Dim _CuentaCatalogo As SqlParameter = New SqlParameter("@Cuenta_Catalogo", SqlDbType.NVarChar, 50)
        '    Dim _TipoCambio As SqlParameter = New SqlParameter("@TipoCambio", SqlDbType.Float, 8)
        '    Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
        '    Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int)
        '    Dim _Transaccion As SqlParameter = New SqlParameter("@Transaccion", SqlDbType.NVarChar, 50)
        '    Dim _Origen As SqlParameter = New SqlParameter("@Origen", SqlDbType.Int)
        '    Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
        '    Dim _MontoIR As SqlParameter = New SqlParameter("@MontoIR", SqlDbType.Money)

        '    _Numero.Value = Numero
        '    _Recibo.Value = Recibo
        '    _Factura.Value = Factura
        '    _Fecha.Value = Fecha
        '    _Tipo_Pago.Value = Tipo_Pago
        '    _Monto.Value = Monto
        '    _NoCheque.Value = NoCheque
        '    _Banco.Value = Banco
        '    _Cuenta.Value = Cuenta
        '    _Monto_Cheque.Value = Monto_Cheque
        '    _Tipo_Tarjeta.Value = Tipo_Tarjeta
        '    _Emisor.Value = Emisor
        '    _No_Tarjeta.Value = No_Tarjeta
        '    _Autorizacion.Value = Autorizacion
        '    _Monto_Tarjeta.Value = Monto_Tarjeta
        '    _Monto_Efectivo.Value = Monto_Efectivo
        '    _Moneda.Value = Moneda
        '    _TipoCambio.Value = TipoCambio
        '    _MontoNotaDebito.Value = Monto_NotaDebito
        '    _CuentaCatalogo.Value = CuentaCatalogo
        '    _Saldo.Value = Saldo
        '    _Tipo.Value = Tipo
        '    _Transaccion.Value = Transaccion
        '    _Origen.Value = Origen
        '    _Empresa.Value = EmpresaActual
        '    _MontoIR.Value = MontoIR

        '    cmd.Parameters.Add(_Numero)
        '    cmd.Parameters.Add(_Recibo)
        '    cmd.Parameters.Add(_Factura)
        '    cmd.Parameters.Add(_Fecha)
        '    cmd.Parameters.Add(_Tipo_Pago)
        '    cmd.Parameters.Add(_Monto)
        '    cmd.Parameters.Add(_NoCheque)
        '    cmd.Parameters.Add(_Banco)
        '    cmd.Parameters.Add(_Cuenta)
        '    cmd.Parameters.Add(_Monto_Cheque)
        '    cmd.Parameters.Add(_Tipo_Tarjeta)
        '    cmd.Parameters.Add(_Emisor)
        '    cmd.Parameters.Add(_No_Tarjeta)
        '    cmd.Parameters.Add(_Autorizacion)
        '    cmd.Parameters.Add(_Monto_Tarjeta)
        '    cmd.Parameters.Add(_Monto_Efectivo)
        '    cmd.Parameters.Add(_Moneda)
        '    cmd.Parameters.Add(_MontoNotaDebito)
        '    cmd.Parameters.Add(_CuentaCatalogo)
        '    cmd.Parameters.Add(_TipoCambio)
        '    cmd.Parameters.Add(_Saldo)
        '    cmd.Parameters.Add(_Tipo)
        '    cmd.Parameters.Add(_Transaccion)
        '    cmd.Parameters.Add(_Origen)
        '    cmd.Parameters.Add(_Empresa)
        '    cmd.Parameters.Add(_MontoIR)

        '    ' Open the connection and execute the Command
        '    '15/11/2005
        '    'DBConn.Open()
        '    'cmd.ExecuteNonQuery()
        '    'DBConn.Close()

        '    cmd.Connection = DBConnFacturas
        '    cmd.Transaction = transaccionFacturas
        '    cmd.ExecuteNonQuery()

        'End Function

        Public Function AddCobro(ByVal Numero As String, ByVal Recibo As String, ByVal Factura As String, ByVal Fecha As String,
                         ByVal Tipo_Pago As String, ByVal Monto As String, ByVal NoCheque As String,
                         ByVal Banco As String, ByVal Cuenta As String, ByVal Monto_Cheque As String,
                         ByVal Tipo_Tarjeta As String, ByVal Emisor As String, ByVal No_Tarjeta As String,
                         ByVal Autorizacion As String, ByVal Monto_Tarjeta As String, ByVal Monto_Efectivo As String,
                         ByVal Moneda As String, ByVal TipoCambio As String, ByVal Saldo As String,
                         ByVal Monto_NotaDebito As String, ByVal CuentaCatalogo As String, ByVal Tipo As String,
                         ByVal Transaccion As String, ByVal Origen As String, ByVal MontoIR As Double,
                         ByVal ValorIR_Alcaldia As Double,
                         ByVal AplicaMnto As Integer, ByVal ValorMnto As Double,
                         ByVal Caja As Integer, ByVal Serie As String, RecibimosDe As String, PorCuentas As String)

            Dim cmd As SqlCommand = New SqlCommand("_CobrosAdd", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar, 50)
            Dim _Recibo As SqlParameter = New SqlParameter("@Recibo", SqlDbType.NVarChar, 50)
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _Tipo_Pago As SqlParameter = New SqlParameter("@Tipo_Pago", SqlDbType.Int, 4)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 8)
            Dim _NoCheque As SqlParameter = New SqlParameter("@NoCheque", SqlDbType.NVarChar, 50)
            Dim _Banco As SqlParameter = New SqlParameter("@Banco", SqlDbType.Int, 4)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar, 50)
            Dim _Monto_Cheque As SqlParameter = New SqlParameter("@Monto_Cheque", SqlDbType.Float, 8)
            Dim _Tipo_Tarjeta As SqlParameter = New SqlParameter("@Tipo_Tarjeta", SqlDbType.NVarChar, 50)
            Dim _Emisor As SqlParameter = New SqlParameter("@Emisor", SqlDbType.NVarChar, 50)
            Dim _No_Tarjeta As SqlParameter = New SqlParameter("@No_Tarjeta", SqlDbType.NVarChar, 50)
            Dim _Autorizacion As SqlParameter = New SqlParameter("@Autorizacion", SqlDbType.NVarChar, 50)
            Dim _Monto_Tarjeta As SqlParameter = New SqlParameter("@Monto_Tarjeta", SqlDbType.Float, 8)
            Dim _Monto_Efectivo As SqlParameter = New SqlParameter("@Monto_Efectivo", SqlDbType.Float, 8)
            Dim _Moneda As SqlParameter = New SqlParameter("@Moneda", SqlDbType.NVarChar, 50)
            Dim _MontoNotaDebito As SqlParameter = New SqlParameter("@Monto_NotaDebito", SqlDbType.Float, 8)
            Dim _CuentaCatalogo As SqlParameter = New SqlParameter("@Cuenta_Catalogo", SqlDbType.NVarChar, 50)
            Dim _TipoCambio As SqlParameter = New SqlParameter("@TipoCambio", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int)
            Dim _Transaccion As SqlParameter = New SqlParameter("@Transaccion", SqlDbType.NVarChar, 50)
            Dim _Origen As SqlParameter = New SqlParameter("@Origen", SqlDbType.Int)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _MontoIR As SqlParameter = New SqlParameter("@MontoIR", SqlDbType.Money)
            Dim _AplicaMnto As SqlParameter = New SqlParameter("@AplicaMnto", SqlDbType.Bit)
            Dim _ValorMnto As SqlParameter = New SqlParameter("@ValorMnto", SqlDbType.Money)
            Dim _ValorIR_Alcaldia As SqlParameter = New SqlParameter("@ValorIR_Alcaldia", SqlDbType.Money)
            Dim _Caja As SqlParameter = New SqlParameter("@Caja", SqlDbType.Int, 4)
            Dim _Serie As SqlParameter = New SqlParameter("@Serie", SqlDbType.NVarChar, 50)

            _Numero.Value = Numero
            _Recibo.Value = Recibo
            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _Tipo_Pago.Value = Tipo_Pago
            _Monto.Value = Monto
            _NoCheque.Value = NoCheque
            _Banco.Value = Banco
            _Cuenta.Value = Cuenta
            _Monto_Cheque.Value = Monto_Cheque
            _Tipo_Tarjeta.Value = Tipo_Tarjeta
            _Emisor.Value = Emisor
            _No_Tarjeta.Value = No_Tarjeta
            _Autorizacion.Value = Autorizacion
            _Monto_Tarjeta.Value = Monto_Tarjeta
            _Monto_Efectivo.Value = Monto_Efectivo
            _Moneda.Value = Moneda
            _TipoCambio.Value = TipoCambio
            _MontoNotaDebito.Value = Monto_NotaDebito
            _CuentaCatalogo.Value = CuentaCatalogo
            _Saldo.Value = Saldo
            _Tipo.Value = Tipo
            _Transaccion.Value = Transaccion
            _Origen.Value = Origen
            _Empresa.Value = EmpresaActual
            _MontoIR.Value = MontoIR
            _AplicaMnto.Value = AplicaMnto
            _ValorMnto.Value = Math.Round(ValorMnto, 2)
            _ValorIR_Alcaldia.Value = ValorIR_Alcaldia
            _Caja.Value = Caja
            _Serie.Value = Serie


            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Recibo)
            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Tipo_Pago)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_NoCheque)
            cmd.Parameters.Add(_Banco)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_Monto_Cheque)
            cmd.Parameters.Add(_Tipo_Tarjeta)
            cmd.Parameters.Add(_Emisor)
            cmd.Parameters.Add(_No_Tarjeta)
            cmd.Parameters.Add(_Autorizacion)
            cmd.Parameters.Add(_Monto_Tarjeta)
            cmd.Parameters.Add(_Monto_Efectivo)
            cmd.Parameters.Add(_Moneda)
            cmd.Parameters.Add(_MontoNotaDebito)
            cmd.Parameters.Add(_CuentaCatalogo)
            cmd.Parameters.Add(_TipoCambio)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Transaccion)
            cmd.Parameters.Add(_Origen)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_MontoIR)
            cmd.Parameters.Add(_AplicaMnto)
            cmd.Parameters.Add(_ValorMnto)
            cmd.Parameters.Add(_ValorIR_Alcaldia)
            cmd.Parameters.Add(_Caja)
            cmd.Parameters.Add(_Serie)

            cmd.Parameters.AddWithValue("@RecibimosDe", RecibimosDe)
            cmd.Parameters.AddWithValue("@PorCuenta", PorCuentas)

            ' Open the connection and execute the Command
            '15/11/2005
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function




        Public Function UpdateFacturaSaldo(ByVal Factura As String, ByVal Cliente As String, ByVal Saldo As String)
            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_FacturasVentasUpdateSaldo", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Cliente As SqlParameter = New SqlParameter("@Cliente", SqlDbType.Int, 4)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Factura.Value = Factura
            _Cliente.Value = Cliente
            _Saldo.Value = Saldo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Cliente)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function ListFacturasXCliente(ByVal Cliente As String, ByVal Fecha As DateTime) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFacturasXCliente", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)
            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)

            pCliente.Value = Cliente
            pEmpresa.Value = EmpresaActual
            pFecha.Value = Fecha

            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pFecha)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function UpdateFactura(ByVal Numero As String, ByVal Factura As String, ByVal Fecha As String, ByVal Cliente As String,
                                ByVal Ruc As String, ByVal Monto As String, ByVal SubTotal As String,
                                ByVal DescuentoP As String, ByVal DescuentoC As String, ByVal IvaP As String,
                                ByVal IvaC As String, ByVal RecargoP As String, ByVal RecargoC As String,
                                ByVal OtrosP As String, ByVal OtrosC As String, ByVal Total As String,
                                ByVal Saldo As String, ByVal Forma_Pago As String, ByVal Vendedor As String,
                                ByVal ComisionP As String, ByVal ComisionC As String, ByVal Fecha_Cancelar As String,
                                ByVal Fecha_Vencimiento As String, ByVal Tipo As String)
            ' Create Instance of Connection and Command Object

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_FacturasVentasUpdate", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.Int, 4)
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _Cliente As SqlParameter = New SqlParameter("@Cliente", SqlDbType.Int, 4)
            Dim _Ruc As SqlParameter = New SqlParameter("@Ruc", SqlDbType.NVarChar, 50)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 8)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _DescuentoP As SqlParameter = New SqlParameter("@DescuentoP", SqlDbType.Float, 8)
            Dim _DescuentoC As SqlParameter = New SqlParameter("@DescuentoC", SqlDbType.Float, 8)
            Dim _IvaP As SqlParameter = New SqlParameter("@IvaP", SqlDbType.Float, 8)
            Dim _IvaC As SqlParameter = New SqlParameter("@IvaC", SqlDbType.Float, 8)
            Dim _RecargoP As SqlParameter = New SqlParameter("@RecargoP", SqlDbType.Float, 8)
            Dim _RecargoC As SqlParameter = New SqlParameter("@RecargoC", SqlDbType.Float, 8)
            Dim _OtrosP As SqlParameter = New SqlParameter("@OtrosP", SqlDbType.Float, 8)
            Dim _OtrosC As SqlParameter = New SqlParameter("@OtrosC", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _FormaPago As SqlParameter = New SqlParameter("@Forma_Pago", SqlDbType.Int, 4)
            Dim _Vendedor As SqlParameter = New SqlParameter("@Vendedor", SqlDbType.Int, 4)
            Dim _ComisionP As SqlParameter = New SqlParameter("@ComisionP", SqlDbType.Float, 8)
            Dim _ComisionC As SqlParameter = New SqlParameter("@ComisionC", SqlDbType.Float, 8)
            Dim _FechaCancelar As SqlParameter = New SqlParameter("@Fecha_Cancelar", SqlDbType.DateTime, 8)
            Dim _FechaVencimiento As SqlParameter = New SqlParameter("@Fecha_Vencimiento", SqlDbType.DateTime, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Numero.Value = Numero
            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _Cliente.Value = Cliente
            _Ruc.Value = Ruc
            _Monto.Value = Monto
            _SubTotal.Value = SubTotal
            _DescuentoP.Value = DescuentoP
            _DescuentoC.Value = DescuentoC
            _IvaP.Value = IvaP
            _IvaC.Value = IvaC
            _RecargoP.Value = RecargoP
            _RecargoC.Value = RecargoC
            _OtrosP.Value = OtrosP
            _OtrosC.Value = OtrosC
            _Total.Value = Total
            _Saldo.Value = Saldo
            _FormaPago.Value = Forma_Pago
            _Vendedor.Value = Vendedor
            _ComisionP.Value = ComisionP
            _ComisionC.Value = ComisionC
            _FechaCancelar.Value = Fecha_Cancelar
            _FechaVencimiento.Value = Fecha_Vencimiento
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Cliente)
            cmd.Parameters.Add(_Ruc)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_DescuentoP)
            cmd.Parameters.Add(_DescuentoC)
            cmd.Parameters.Add(_IvaP)
            cmd.Parameters.Add(_IvaC)
            cmd.Parameters.Add(_RecargoP)
            cmd.Parameters.Add(_RecargoC)
            cmd.Parameters.Add(_OtrosP)
            cmd.Parameters.Add(_OtrosC)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_FormaPago)
            cmd.Parameters.Add(_Vendedor)
            cmd.Parameters.Add(_ComisionP)
            cmd.Parameters.Add(_ComisionC)
            cmd.Parameters.Add(_FechaCancelar)
            cmd.Parameters.Add(_FechaVencimiento)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function



        Public Function FacturasXFecha123(ByVal Filtro As String, ByVal Tipo As String, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Estado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasListXFecha", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.DateTime)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pFiltro.Value = Filtro
            pTipo.Value = Tipo
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasXTipoList(ByVal Factura As String, ByVal Filtro As String, ByVal Tipo As String, ByVal Mes As String, ByVal Estado As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            If Fecha1 = "" Then
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            Else
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.DateTime)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            End If

            pFactura.Value = Factura
            pFiltro.Value = Filtro
            pTipo.Value = Tipo
            pMes.Value = Mes
            pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FacturasXTipoList(ByVal Tipo As String, ByVal Mes As String,
                                          ByVal Fecha1 As String, ByVal Fecha2 As String,
                                          ByVal Caja As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("sp_FacturasClientesList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            'Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            'Dim pEstado As New SqlParameter("@Estado", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pCaja As New SqlParameter("@Caja", SqlDbType.NVarChar)
            Dim pUsuario As New SqlParameter("@Usuario", SqlDbType.Int)

            If Fecha1 = "" Then
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            Else
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.DateTime)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            End If

            'pFactura.Value = Factura
            'pFiltro.Value = Filtro
            pTipo.Value = Tipo
            pMes.Value = Mes
            'pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual
            pCaja.Value = Caja
            pUsuario.Value = Usuario_ID
            'pIdent2.Value = Empresa

            'DBCommand.SelectCommand.Parameters.Add(pFactura)
            'DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            'DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pCaja)
            DBCommand.SelectCommand.Parameters.Add(pUsuario)

            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.SelectCommand.CommandTimeout = 0
            DBCommand.Fill(dsFicha, "Facturas_Ventas")
            DBConn.Close()

            Return dsFicha
        End Function

        Public Function ListFacturas(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFacturasVentas", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pFiltro.Value = Filtro
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function AddFactura(ByVal Factura As String, ByVal Fecha As String, ByVal Cliente As String,
                                   ByVal Ruc As String, ByVal Monto As String, ByVal SubTotal As String,
                                   ByVal Descuento As String, ByVal Iva As String, ByVal Recargo As String,
                                   ByVal Otros As String, ByVal Total As String, ByVal Saldo As String,
                                   ByVal Vendedor As String, ByVal Fecha_Pago As String,
                                   ByVal Fecha_Vencimiento As String, ByVal Tipo As String,
                                   ByVal Tipo_Factura As String, ByVal Nombre_Cliente As String, ByVal Retencion As Boolean,
                                   ByVal MonedaMtto As String, ByVal serie As String, ByVal multiserie As Boolean, ByVal Remision As String, ByVal Orden As String,
                                   ByVal Caja As String, ByVal Cultivo As String, ByVal NoEntrega As String,
                                   Optional ByVal Condiciones As String = "",
                                   Optional ByVal IdSerie As Integer = 0, Optional ByVal FacturaN As Integer = 0, Optional ByVal TCambio As Double = 1.0,
                                   Optional ByVal Emp_Codigo As String = vbNullString, Optional ByVal Despacho As String = "B",
                                   Optional ByVal Impresa As String = "01", Optional ByVal Comentario As String = "")

            'Optional ByVal trn_quincena As String = vbNullString, _
            'Optional ByVal ptm_codigoEmp As String = vbNullString)
            Dim cmd As SqlCommand = New SqlCommand("_FacturasVentasAdd", DBConnFacturas)
            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure
            ' Add Parameters to SPROC
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            Dim _Cliente As SqlParameter = New SqlParameter("@Cliente", SqlDbType.Int, 4)
            Dim _Ruc As SqlParameter = New SqlParameter("@Ruc", SqlDbType.NVarChar, 50)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float, 8)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Recargo As SqlParameter = New SqlParameter("@Recargo", SqlDbType.Float, 8)
            Dim _Otros As SqlParameter = New SqlParameter("@Otros", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float, 8)
            Dim _Vendedor As SqlParameter = New SqlParameter("@Vendedor", SqlDbType.Int, 4)
            Dim _FechaPago As SqlParameter = New SqlParameter("@Fecha_Pago", SqlDbType.DateTime, 8)
            Dim _FechaVencimiento As SqlParameter = New SqlParameter("@Fecha_Vencimiento", SqlDbType.DateTime, 8)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int, 4)
            Dim _Tipo_Factura As SqlParameter = New SqlParameter("@Tipo_Factura", SqlDbType.Int, 4)
            Dim _Nombre_Cliente As SqlParameter = New SqlParameter("@Nombre_Cliente", SqlDbType.NVarChar, 130)
            Dim _Retencion As SqlParameter = New SqlParameter("@Retencion", SqlDbType.Bit)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Moneda As SqlParameter = New SqlParameter("@Moneda", SqlDbType.NVarChar, 2)
            Dim _Remision As SqlParameter = New SqlParameter("@Remision", SqlDbType.NVarChar, 50)
            Dim _Orden As SqlParameter = New SqlParameter("@Orden", SqlDbType.NVarChar, 50)
            Dim _Caja As SqlParameter = New SqlParameter("@Caja", SqlDbType.NVarChar, 50)
            Dim _IdSerie As SqlParameter = New SqlParameter("@IdSerie", SqlDbType.Int, 4)
            Dim _FacturaN As SqlParameter = New SqlParameter("@FacturaN", SqlDbType.Int, 4)
            Dim _Cultivo As SqlParameter = New SqlParameter("@Cultivo", SqlDbType.NVarChar, 10)
            Dim _NoEntrega As SqlParameter = New SqlParameter("@NoEntrega", SqlDbType.NVarChar, 10)
            Dim _Condiciones As SqlParameter = New SqlParameter("@Condiciones", SqlDbType.NVarChar, 50)
            Dim _TCambio As SqlParameter = New SqlParameter("@TCambio", SqlDbType.Float)
            Dim _Emp_Codigo As SqlParameter = New SqlParameter("@Emp_Codigo", SqlDbType.NVarChar, 50)
            Dim _Despacho As SqlParameter = New SqlParameter("@Despacho", SqlDbType.NVarChar, 20)
            Dim _MonedaImpresa As SqlParameter = New SqlParameter("@Impresa", SqlDbType.NVarChar, 10)
            Dim _Comentario As SqlParameter = New SqlParameter("@Comentario", SqlDbType.NVarChar)
            'Dim _trn_quincena As SqlParameter = New SqlParameter("@trn_quincena", SqlDbType.NVarChar, 50)
            'Dim _ptm_codigoEmp As SqlParameter = New SqlParameter("@ptm_codigoEmp", SqlDbType.NVarChar, 50)

            _Factura.Value = Factura
            _Fecha.Value = Fecha
            _Cliente.Value = Cliente
            _Ruc.Value = Ruc
            _Monto.Value = Monto
            _SubTotal.Value = SubTotal
            _Descuento.Value = Descuento
            _Iva.Value = Iva
            _Recargo.Value = Recargo
            _Otros.Value = Otros
            _Total.Value = Total
            _Saldo.Value = Saldo
            _Vendedor.Value = Vendedor
            _FechaPago.Value = Fecha_Pago
            _FechaVencimiento.Value = Fecha_Vencimiento
            _Tipo.Value = Tipo
            _Tipo_Factura.Value = Tipo_Factura
            _Nombre_Cliente.Value = Nombre_Cliente
            _Retencion.Value = Retencion
            _Empresa.Value = EmpresaActual
            _Moneda.Value = MonedaMtto
            _Remision.Value = Remision
            _Orden.Value = Orden
            _Caja.Value = Caja
            _IdSerie.Value = IdSerie
            _FacturaN.Value = FacturaN
            _Cultivo.Value = Cultivo
            _NoEntrega.Value = NoEntrega
            _Condiciones.Value = Condiciones
            _TCambio.Value = TCambio
            _Emp_Codigo.Value = Emp_Codigo
            _Despacho.Value = Despacho
            _MonedaImpresa.Value = Impresa
            _Comentario.Value = Comentario
            '_trn_quincena.Value = trn_quincena
            '_ptm_codigoEmp.Value = ptm_codigoEmp

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Cliente)
            cmd.Parameters.Add(_Ruc)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_SubTotal)
            cmd.Parameters.Add(_Descuento)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Recargo)
            cmd.Parameters.Add(_Otros)
            cmd.Parameters.Add(_Total)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_Vendedor)
            cmd.Parameters.Add(_FechaPago)
            cmd.Parameters.Add(_FechaVencimiento)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Tipo_Factura)
            cmd.Parameters.Add(_Nombre_Cliente)
            cmd.Parameters.Add(_Retencion)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Moneda)
            cmd.Parameters.Add(_Remision)
            cmd.Parameters.Add(_Orden)
            cmd.Parameters.Add(_Caja)
            cmd.Parameters.Add(_IdSerie)
            cmd.Parameters.Add(_FacturaN)
            cmd.Parameters.Add(_Cultivo)
            cmd.Parameters.Add(_NoEntrega)
            cmd.Parameters.Add(_Condiciones)
            cmd.Parameters.Add(_TCambio)
            cmd.Parameters.Add(_Emp_Codigo)
            cmd.Parameters.Add(_Despacho)
            cmd.Parameters.Add(_MonedaImpresa)
            cmd.Parameters.Add(_Comentario)
            'cmd.Parameters.Add(_trn_quincena)
            'cmd.Parameters.Add(_ptm_codigoEmp)

            Dim pserie As New SqlParameter("@serie", SqlDbType.NVarChar)
            pserie.Value = serie
            cmd.Parameters.Add(pserie)

            Dim pmultiserie As New SqlParameter("@multiserie", SqlDbType.Bit)
            pmultiserie.Value = multiserie
            cmd.Parameters.Add(pmultiserie)


            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function

        Public Shared Function GuardarFactura(ByVal Factura As String, ByVal Fecha As Date, ByVal Cliente As Integer,
                                   ByVal Ruc As String, ByVal Monto As Double, ByVal SubTotal As Double,
                                   ByVal Descuento As Double, ByVal Iva As Double, ByVal Recargo As Double,
                                   ByVal Otros As Double, ByVal Total As Double, ByVal Saldo As Double,
                                   ByVal Vendedor As Integer, ByVal Fecha_Pago As Date,
                                   ByVal Fecha_Vencimiento As Date, ByVal Tipo As String,
                                   ByVal Tipo_Factura As String, ByVal Nombre_Cliente As String, ByVal Retencion As Boolean,
                                   ByVal MonedaMtto As String, ByVal serie As String, ByVal multiserie As Boolean, ByVal Remision As String, ByVal Orden As String,
                                   ByVal Caja As String, ByVal Cultivo As String, ByVal NoEntrega As String,
                                   ByVal Condiciones As String,
                                   ByVal IdSerie As Integer, ByVal FacturaN As Integer, ByVal TCambio As Double,
                                   ByVal Emp_Codigo As String, ByVal Despacho As String,
                                   ByVal Impresa As String, ByVal Comentario As String,
                                   ByVal LoadCotizacion As Boolean, ByVal LoadOrden As Boolean,
                                   ByVal Contado As Boolean, ByVal TotalEfectivo As Double, ByVal TotalNotaDebito As Double,
                                   ByVal TotalCheques As Double, ByVal TotalTarjetas As Double, ByVal TotalFactura As Double,
                                   ByVal TotalGlobal As Double, ByVal Recibo As Double, ByVal MonedaROC As String, ByVal DT_CK As DataTable, ByVal DT_TC As DataTable,
                                   ByVal Detalle As DataTable) As Boolean

            '/**********************************************************************
            '** Inicializar la Transaccion Principal
            '**********************************************************************/

            'For i As Integer = 0 To Detalle.Rows.Count - 1
            '    Detalle.Rows.Item(i)("Cantidad") = Math.Round(CDbl(Detalle.Rows.Item(i)("Cantidad")), 4)
            '    Detalle.Rows.Item(i)("PrecioU") = Math.Round(CDbl(Detalle.Rows.Item(i)("PrecioU")), 4)
            '    Detalle.Rows.Item(i)("Precio") = Math.Round(CDbl(Detalle.Rows.Item(i)("Precio")), 4)
            '    Detalle.Rows.Item(i)("Total") = Math.Round(CDbl(Detalle.Rows.Item(i)("Total")), 4)
            '    Detalle.Rows.Item(i)("IVA") = Math.Round(CDbl(Detalle.Rows.Item(i)("IVA")), 4)
            '    Detalle.Rows.Item(i)("Costo") = Math.Round(CDbl(Detalle.Rows.Item(i)("Costo")), 4)
            'Next

            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
            Conn.IniciarTransaccion()

            Try
                Conn.RemoveParameters()
                Conn.AddParameter("Factura", SqlDbType.NVarChar, 50, ParameterDirection.Input, Factura)
                Conn.AddParameter("Fecha", SqlDbType.DateTime, 8, ParameterDirection.Input, Fecha)
                Conn.AddParameter("Cliente", SqlDbType.Int, 4, ParameterDirection.Input, Cliente)
                Conn.AddParameter("Ruc", SqlDbType.NVarChar, 50, ParameterDirection.Input, Ruc)
                Conn.AddParameter("Monto", SqlDbType.Decimal, 18, ParameterDirection.Input, Monto)
                Conn.AddParameter("SubTotal", SqlDbType.Decimal, 18, ParameterDirection.Input, SubTotal)
                Conn.AddParameter("Descuento", SqlDbType.Decimal, 18, ParameterDirection.Input, Descuento)
                Conn.AddParameter("Iva", SqlDbType.Decimal, 18, ParameterDirection.Input, Iva)
                Conn.AddParameter("Recargo", SqlDbType.Decimal, 18, ParameterDirection.Input, Recargo)
                Conn.AddParameter("Otros", SqlDbType.Decimal, 18, ParameterDirection.Input, Otros)
                Conn.AddParameter("Total", SqlDbType.Decimal, 18, ParameterDirection.Input, Total)
                Conn.AddParameter("Saldo", SqlDbType.Decimal, 18, ParameterDirection.Input, Saldo)
                Conn.AddParameter("Vendedor", SqlDbType.Int, 4, ParameterDirection.Input, Vendedor)
                Conn.AddParameter("Fecha_Pago", SqlDbType.DateTime, 8, ParameterDirection.Input, Fecha_Pago)
                Conn.AddParameter("Fecha_Vencimiento", SqlDbType.DateTime, 8, ParameterDirection.Input, Fecha_Vencimiento)
                Conn.AddParameter("Tipo", SqlDbType.Int, 4, ParameterDirection.Input, Tipo)
                Conn.AddParameter("Tipo_Factura", SqlDbType.Int, 4, ParameterDirection.Input, Tipo_Factura)
                Conn.AddParameter("Nombre_Cliente", SqlDbType.NVarChar, 512, ParameterDirection.Input, Nombre_Cliente)
                Conn.AddParameter("Retencion", SqlDbType.Bit, 0, ParameterDirection.Input, Retencion)
                Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Moneda", SqlDbType.NVarChar, 2, ParameterDirection.Input, MonedaMtto)
                Conn.AddParameter("serie", SqlDbType.NVarChar, 10, ParameterDirection.Input, serie)
                Conn.AddParameter("multiserie", SqlDbType.Bit, 0, ParameterDirection.Input, multiserie)
                Conn.AddParameter("Remision", SqlDbType.NVarChar, 256, ParameterDirection.Input, Remision)
                Conn.AddParameter("Orden", SqlDbType.NVarChar, 256, ParameterDirection.Input, Orden)
                Conn.AddParameter("Caja", SqlDbType.NVarChar, 50, ParameterDirection.Input, Caja)
                Conn.AddParameter("IdSerie", SqlDbType.Int, 4, ParameterDirection.Input, IdSerie)
                Conn.AddParameter("FacturaN", SqlDbType.Int, 4, ParameterDirection.Input, FacturaN)
                Conn.AddParameter("Cultivo", SqlDbType.NVarChar, 10, ParameterDirection.Input, Cultivo)
                Conn.AddParameter("NoEntrega", SqlDbType.NVarChar, 256, ParameterDirection.Input, NoEntrega)
                Conn.AddParameter("Condiciones", SqlDbType.NVarChar, 256, ParameterDirection.Input, Condiciones)
                Conn.AddParameter("TCambio", SqlDbType.Decimal, 18, ParameterDirection.Input, TCambio)
                Conn.AddParameter("Emp_Codigo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Emp_Codigo)
                Conn.AddParameter("Despacho", SqlDbType.NVarChar, 20, ParameterDirection.Input, Despacho)
                Conn.AddParameter("Impresa", SqlDbType.NVarChar, 10, ParameterDirection.Input, Impresa)
                Conn.AddParameter("Comentario", SqlDbType.NVarChar, 1024, ParameterDirection.Input, Comentario)
                Conn.AddParameter("LoadCotizacion", SqlDbType.Bit, 0, ParameterDirection.Input, LoadCotizacion)
                Conn.AddParameter("LoadOrden", SqlDbType.Bit, 0, ParameterDirection.Input, LoadOrden)
                Conn.AddParameter("Cot_ID", SqlDbType.Int, 4, ParameterDirection.Input, IIf(RegistroCotizacion Is Nothing, 0, IIf(IsNumeric(RegistroCotizacion), RegistroCotizacion, 0)))
                Conn.AddParameter("Orden_ID", SqlDbType.Int, 4, ParameterDirection.Input, 0)    ' IIf(RegistroOrden Is Nothing, 0, RegistroOrden))

                Conn.AddParameter("Contado", SqlDbType.Bit, 0, ParameterDirection.Input, Contado)
                Conn.AddParameter("TotalEfectivo", SqlDbType.Decimal, 18, ParameterDirection.Input, TotalEfectivo)
                Conn.AddParameter("TotalNotaDebito", SqlDbType.Decimal, 18, ParameterDirection.Input, TotalNotaDebito)
                Conn.AddParameter("TotalCheques", SqlDbType.Decimal, 18, ParameterDirection.Input, TotalCheques)
                Conn.AddParameter("TotalTarjetas", SqlDbType.Decimal, 18, ParameterDirection.Input, TotalTarjetas)
                Conn.AddParameter("TotalFactura", SqlDbType.Decimal, 18, ParameterDirection.Input, TotalFactura)
                Conn.AddParameter("TotalGlobal", SqlDbType.Decimal, 18, ParameterDirection.Input, TotalGlobal)
                Conn.AddParameter("Recibo", SqlDbType.Decimal, 18, ParameterDirection.Input, Recibo)
                Conn.AddParameter("MonedaRoc", SqlDbType.NVarChar, 2, ParameterDirection.Input, MonedaROC)

                Conn.AddParameter("DT_CHEQUES", SqlDbType.Structured, 0, ParameterDirection.Input, DT_CK)
                Conn.AddParameter("DT_TARJETAS", SqlDbType.Structured, 0, ParameterDirection.Input, DT_TC)
                Conn.AddParameter("DT_FACTURA", SqlDbType.Structured, 0, ParameterDirection.Input, Detalle)

                Conn.EjecutarComando("JAR_GuardarFactura")
                Conn.CompletarTransaccion()

                Return True
            Catch ex As Exception
                Conn.AnularTransaccion()
                XtraMsg("Error al Guardar: " & vbCrLf & ex.Message, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Public Shared Function GuardarFacturaPrevia(ByVal Factura As String, ByVal Fecha As Date, ByVal Cliente As Integer,
                                   ByVal Ruc As String, ByVal Monto As Double, ByVal SubTotal As Double,
                                   ByVal Descuento As Double, ByVal Iva As Double, ByVal Recargo As Double,
                                   ByVal Otros As Double, ByVal Total As Double, ByVal Saldo As Double,
                                   ByVal Vendedor As Integer, ByVal Fecha_Pago As Date,
                                   ByVal Fecha_Vencimiento As Date, ByVal Tipo As String,
                                   ByVal Tipo_Factura As String, ByVal Nombre_Cliente As String, ByVal Retencion As Boolean,
                                   ByVal MonedaMtto As String, ByVal serie As String, ByVal multiserie As Boolean, ByVal Remision As String, ByVal Orden As String,
                                   ByVal Caja As String, ByVal Cultivo As String, ByVal NoEntrega As String,
                                   ByVal Condiciones As String,
                                   ByVal IdSerie As Integer, ByVal FacturaN As Integer, ByVal TCambio As Double,
                                   ByVal Emp_Codigo As String, ByVal Despacho As String,
                                   ByVal Impresa As String, ByVal Comentario As String,
                                   ByVal LoadCotizacion As Boolean, ByVal LoadOrden As Boolean,
                                   ByVal Contado As Boolean, ByVal TotalEfectivo As Double, ByVal TotalNotaDebito As Double,
                                   ByVal TotalCheques As Double, ByVal TotalTarjetas As Double, ByVal TotalFactura As Double,
                                   ByVal TotalGlobal As Double, ByVal Recibo As Double, ByVal MonedaROC As String, ByVal DT_CK As DataTable, ByVal DT_TC As DataTable,
                                   ByVal Detalle As DataTable) As Boolean

            '/**********************************************************************
            '** Inicializar la Transaccion Principal
            '**********************************************************************/
            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
            Conn.IniciarTransaccion()

            Try
                Conn.RemoveParameters()
                Conn.AddParameter("Factura", SqlDbType.NVarChar, 50, ParameterDirection.Input, Factura)
                Conn.AddParameter("Fecha", SqlDbType.DateTime, 8, ParameterDirection.Input, Fecha)
                Conn.AddParameter("Cliente", SqlDbType.Int, 4, ParameterDirection.Input, Cliente)
                Conn.AddParameter("Ruc", SqlDbType.NVarChar, 50, ParameterDirection.Input, Ruc)
                Conn.AddParameter("Monto", SqlDbType.Decimal, 18, ParameterDirection.Input, Monto)
                Conn.AddParameter("SubTotal", SqlDbType.Decimal, 18, ParameterDirection.Input, SubTotal)
                Conn.AddParameter("Descuento", SqlDbType.Decimal, 18, ParameterDirection.Input, Descuento)
                Conn.AddParameter("Iva", SqlDbType.Decimal, 18, ParameterDirection.Input, Iva)
                Conn.AddParameter("Recargo", SqlDbType.Decimal, 18, ParameterDirection.Input, Recargo)
                Conn.AddParameter("Otros", SqlDbType.Decimal, 18, ParameterDirection.Input, Otros)
                Conn.AddParameter("Total", SqlDbType.Decimal, 18, ParameterDirection.Input, Total)
                Conn.AddParameter("Saldo", SqlDbType.Decimal, 18, ParameterDirection.Input, Saldo)
                Conn.AddParameter("Vendedor", SqlDbType.Int, 4, ParameterDirection.Input, Vendedor)
                Conn.AddParameter("Fecha_Pago", SqlDbType.DateTime, 8, ParameterDirection.Input, Fecha_Pago)
                Conn.AddParameter("Fecha_Vencimiento", SqlDbType.DateTime, 8, ParameterDirection.Input, Fecha_Vencimiento)
                Conn.AddParameter("Tipo", SqlDbType.Int, 4, ParameterDirection.Input, Tipo)
                Conn.AddParameter("Tipo_Factura", SqlDbType.Int, 4, ParameterDirection.Input, Tipo_Factura)
                Conn.AddParameter("Nombre_Cliente", SqlDbType.NVarChar, 512, ParameterDirection.Input, Nombre_Cliente)
                Conn.AddParameter("Retencion", SqlDbType.Bit, 0, ParameterDirection.Input, Retencion)
                Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Moneda", SqlDbType.NVarChar, 2, ParameterDirection.Input, MonedaMtto)
                Conn.AddParameter("serie", SqlDbType.NVarChar, 10, ParameterDirection.Input, serie)
                Conn.AddParameter("multiserie", SqlDbType.Bit, 0, ParameterDirection.Input, multiserie)
                Conn.AddParameter("Remision", SqlDbType.NVarChar, 256, ParameterDirection.Input, Remision)
                Conn.AddParameter("Orden", SqlDbType.NVarChar, 256, ParameterDirection.Input, Orden)
                Conn.AddParameter("Caja", SqlDbType.NVarChar, 50, ParameterDirection.Input, Caja)
                Conn.AddParameter("IdSerie", SqlDbType.Int, 4, ParameterDirection.Input, IdSerie)
                Conn.AddParameter("FacturaN", SqlDbType.Int, 4, ParameterDirection.Input, FacturaN)
                Conn.AddParameter("Cultivo", SqlDbType.NVarChar, 10, ParameterDirection.Input, Cultivo)
                Conn.AddParameter("NoEntrega", SqlDbType.NVarChar, 256, ParameterDirection.Input, NoEntrega)
                Conn.AddParameter("Condiciones", SqlDbType.NVarChar, 256, ParameterDirection.Input, Condiciones)
                Conn.AddParameter("TCambio", SqlDbType.Decimal, 18, ParameterDirection.Input, TCambio)
                Conn.AddParameter("Emp_Codigo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Emp_Codigo)
                Conn.AddParameter("Despacho", SqlDbType.NVarChar, 20, ParameterDirection.Input, Despacho)
                Conn.AddParameter("Impresa", SqlDbType.NVarChar, 10, ParameterDirection.Input, Impresa)
                Conn.AddParameter("Comentario", SqlDbType.NVarChar, 1024, ParameterDirection.Input, Comentario)
                Conn.AddParameter("LoadCotizacion", SqlDbType.Bit, 0, ParameterDirection.Input, LoadCotizacion)
                Conn.AddParameter("LoadOrden", SqlDbType.Bit, 0, ParameterDirection.Input, LoadOrden)
                Conn.AddParameter("Cot_ID", SqlDbType.Int, 4, ParameterDirection.Input, IIf(RegistroCotizacion Is Nothing, 0, IIf(IsNumeric(RegistroCotizacion), RegistroCotizacion, 0)))
                Conn.AddParameter("Orden_ID", SqlDbType.Int, 4, ParameterDirection.Input, 0)    ' IIf(RegistroOrden Is Nothing, 0, RegistroOrden))

                Conn.AddParameter("Contado", SqlDbType.Bit, 0, ParameterDirection.Input, Contado)
                Conn.AddParameter("TotalEfectivo", SqlDbType.Decimal, 18, ParameterDirection.Input, TotalEfectivo)
                Conn.AddParameter("TotalNotaDebito", SqlDbType.Decimal, 18, ParameterDirection.Input, TotalNotaDebito)
                Conn.AddParameter("TotalCheques", SqlDbType.Decimal, 18, ParameterDirection.Input, TotalCheques)
                Conn.AddParameter("TotalTarjetas", SqlDbType.Decimal, 18, ParameterDirection.Input, TotalTarjetas)
                Conn.AddParameter("TotalFactura", SqlDbType.Decimal, 18, ParameterDirection.Input, TotalFactura)
                Conn.AddParameter("TotalGlobal", SqlDbType.Decimal, 18, ParameterDirection.Input, TotalGlobal)
                Conn.AddParameter("Recibo", SqlDbType.Decimal, 18, ParameterDirection.Input, Recibo)
                Conn.AddParameter("MonedaRoc", SqlDbType.NVarChar, 2, ParameterDirection.Input, MonedaROC)

                Conn.AddParameter("DT_CHEQUES", SqlDbType.Structured, 0, ParameterDirection.Input, DT_CK)
                Conn.AddParameter("DT_TARJETAS", SqlDbType.Structured, 0, ParameterDirection.Input, DT_TC)
                Conn.AddParameter("DT_FACTURA", SqlDbType.Structured, 0, ParameterDirection.Input, Detalle)

                Conn.EjecutarComando("JAR_GuardarFacturaTemporal")
                Conn.CompletarTransaccion()

                Return True
            Catch ex As Exception
                Conn.AnularTransaccion()
                XtraMsg("Error al Guardar: " & vbCrLf & ex.Message, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Public Shared Function FacturaVentaUpdateIR(Factura As String, MontoIR As Double, IrAlma As Double) As Boolean

            Return Guardar("sp_upd_FACTURAS_VENTAS_Retencion", Factura, MontoIR, IrAlma, EmpresaActual)

        End Function

        Public Function GenerarCodigo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo FROM Clientes WHERE Empresa = '" & EmpresaActual & "' AND Codigo <> '9999' ORDER BY Codigo DESC", DBConn)
            DBCommand.Fill(dsFicha, "CLIENTES")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GeneradorReportes(ByVal Departamento As String, ByVal Municipio As String, ByVal TipoReporte As Integer, ByVal Zona As String, ByVal FormaPago As String, ByVal Vendedor As String, ByVal Orden As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GeneradorReportesClientes", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pDepto As New SqlParameter("@Depto", SqlDbType.NVarChar)
            Dim pMuni As New SqlParameter("@Muni", SqlDbType.NVarChar)
            Dim pTipoReporte As New SqlParameter("@TipoReporte", SqlDbType.Int)
            Dim pZona As New SqlParameter("@Zona", SqlDbType.Int)
            Dim pFormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)
            Dim pVendedor As New SqlParameter("@Vendedor", SqlDbType.Int)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pTipoReporte.Value = TipoReporte
            pDepto.Value = Departamento
            pMuni.Value = Municipio
            pZona.Value = Zona
            pFormaPago.Value = FormaPago
            pVendedor.Value = Vendedor
            pOrden.Value = Orden

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipoReporte)
            DBCommand.SelectCommand.Parameters.Add(pDepto)
            DBCommand.SelectCommand.Parameters.Add(pMuni)
            DBCommand.SelectCommand.Parameters.Add(pZona)
            DBCommand.SelectCommand.Parameters.Add(pFormaPago)
            DBCommand.SelectCommand.Parameters.Add(pVendedor)
            DBCommand.SelectCommand.Parameters.Add(pOrden)


            DBCommand.Fill(dsFicha, "CLIENTES")

            DBConn.Close()

            Return dsFicha
        End Function


        Public Function GetListReporte(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListClientesReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "CLIENTES")

            DBConn.Close()

            Return dsFicha
        End Function


        Public Shared Function GetDetails(ByVal Codigo As String) As VB.SysContab.ClientesDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsClientes As New DataSet
            Dim Details As New ClientesDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ClientesDetalles", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            'DBCommand = New SqlDataAdapter("SELECT * FROM Clientes WHERE Codigo = '" & Codigo & "' And Empresa = '" & EmpresaActual & "'", DBConn)

            pCliente.Value = Codigo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsClientes, "Clientes")

            If dsClientes.Tables("Clientes").Rows.Count = 1 Then
                Details.Codigo = dsClientes.Tables("Clientes").Rows(0).Item("Codigo").ToString
                Details.Nombre = dsClientes.Tables("Clientes").Rows(0).Item("Nombre").ToString
                Details.Nombre_Comercial = dsClientes.Tables("Clientes").Rows(0).Item("Nombre_Comercial")
                Details.Contacto = dsClientes.Tables("Clientes").Rows(0).Item("Contacto").ToString
                Details.Cargo = dsClientes.Tables("Clientes").Rows(0).Item("Cargo").ToString
                Details.Telefono_Contacto = dsClientes.Tables("Clientes").Rows(0).Item("Telefono_Contacto").ToString
                Details.Celular_Contacto = dsClientes.Tables("Clientes").Rows(0).Item("Celular_Contacto").ToString
                Details.Email_Contacto = dsClientes.Tables("Clientes").Rows(0).Item("Email_Contacto").ToString
                Details.Gerente = dsClientes.Tables("Clientes").Rows(0).Item("Gerente").ToString
                Details.Telefono_Gerente = dsClientes.Tables("Clientes").Rows(0).Item("Telefono_Gerente").ToString
                Details.Celular_Gerente = dsClientes.Tables("Clientes").Rows(0).Item("Celular_Gerente").ToString
                Details.Email_Gerente = dsClientes.Tables("Clientes").Rows(0).Item("Email_Gerente").ToString
                Details.Contador = dsClientes.Tables("Clientes").Rows(0).Item("Contador").ToString
                Details.Telefono_Contador = dsClientes.Tables("Clientes").Rows(0).Item("Telefono_Contador").ToString
                Details.Celular_Contador = dsClientes.Tables("Clientes").Rows(0).Item("Celular_Contador").ToString
                Details.Email_Contador = dsClientes.Tables("Clientes").Rows(0).Item("Email_Contador").ToString
                Details.Direccion = dsClientes.Tables("Clientes").Rows(0).Item("Direccion").ToString
                Details.Ciudad = dsClientes.Tables("Clientes").Rows(0).Item("Ciudad").ToString
                Details.Pais = dsClientes.Tables("Clientes").Rows(0).Item("pais_ID")
                Details.Departamento = dsClientes.Tables("Clientes").Rows(0).Item("Departamento")
                Details.Municipio = dsClientes.Tables("Clientes").Rows(0).Item("Municipio")

                Details.DepartamentoN = dsClientes.Tables("Clientes").Rows(0).Item("DepartamentoN")
                Details.MunicipioN = dsClientes.Tables("Clientes").Rows(0).Item("MunicipioN")
                Details.PaisN = dsClientes.Tables("Clientes").Rows(0).Item("PaisN")

                Details.Telefono = dsClientes.Tables("Clientes").Rows(0).Item("Telefono").ToString
                Details.Fax = dsClientes.Tables("Clientes").Rows(0).Item("Fax").ToString
                Details.Correo = dsClientes.Tables("Clientes").Rows(0).Item("Correo").ToString
                Details.Ruc = dsClientes.Tables("Clientes").Rows(0).Item("Ruc").ToString
                Details.Cedula = dsClientes.Tables("Clientes").Rows(0).Item("Cedula").ToString
                'Details.Tipo = dsClientes.Tables("Clientes").Rows(0).Item("Tipo")
                Details.Cod_Zona = dsClientes.Tables("Clientes").Rows(0).Item("Cod_Zona").ToString
                Details.Cod_Forma_Pago = dsClientes.Tables("Clientes").Rows(0).Item("Cod_Forma_Pago")

                Details.Desc_Prod = dsClientes.Tables("Clientes").Rows(0).Item("Desc_Prod").ToString
                Details.Desc_Serv = dsClientes.Tables("Clientes").Rows(0).Item("Desc_Serv").ToString
                Details.Desc_Adicional = dsClientes.Tables("Clientes").Rows(0).Item("Desc_Adicional").ToString
                Details.Limite_Credito = dsClientes.Tables("Clientes").Rows(0).Item("Limite_Credito").ToString

                Details.Vendedor = IsNull(dsClientes.Tables("Clientes").Rows(0).Item("Vendedor"), 0)
                Details.Cuenta = dsClientes.Tables("Clientes").Rows(0).Item("Cuenta").ToString
                Details.Excento = IsNull(dsClientes.Tables("Clientes").Rows(0).Item("Excento"), False)
                Details.TipoCliente = dsClientes.Tables("Clientes").Rows(0).Item("TipoCliente").ToString
                Details.Retenedor = dsClientes.Tables("Clientes").Rows(0).Item("Retenedor")
                Details.RetenedorAlcaldia = dsClientes.Tables("Clientes").Rows(0).Item("Retenedor_Alcaldia")
                Details.CodigoLetra = dsClientes.Tables("Clientes").Rows(0).Item("CodigoLetra")
                Details.Empleado = dsClientes.Tables("Clientes").Rows(0).Item("Empleado")
                Details.Garantia = dsClientes.Tables("Clientes").Rows(0).Item("Garantia")
                Details.Categoria = dsClientes.Tables("Clientes").Rows(0).Item("Categoria")
                Details.Moneda = dsClientes.Tables("Clientes").Rows(0).Item("Moneda")
                Details.ValidarLimite = dsClientes.Tables("Clientes").Rows(0).Item("ValidarLimite")
                Details.Comentario = dsClientes.Tables("Clientes").Rows(0).Item("Comentarios")
                Details.Activo = dsClientes.Tables("Clientes").Rows(0).Item("ACTIVO")
                Details.Agro = dsClientes.Tables("Clientes").Rows(0).Item("AgroServicio")

                ''''If Codigo <> 0 Then
                ''''    DBCommand = New SqlDataAdapter("SELECT * FROM Zonas WHERE Codigo = " & Details.Cod_Zona & " AND Empresa = '" & EmpresaActual & "'", DBConn)

                ''''    DBCommand.Fill(dsClientes, "Zonas")

                ''''    Details.Nombre_Zona = dsClientes.Tables("Zonas").Rows(0).Item("Nombre").ToString
                ''''End If

            End If

            Return Details

        End Function

        Public Shared Function GetList(Optional Todos As Integer = 0) As DataSet
            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()
            'Dim cd As String

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Codigo, Cuenta, Nombre, Contacto, Direccion, Ciudad, Telefono FROM Clientes WHERE Empresa = '" & EmpresaActual & "' And Codigo <> 0 And Codigo <> 9999", DBConn)
            'DBCommand.Fill(dsFicha, "CLIENTES")

            'DBConn.Close()

            'Return dsFicha
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ClientesGetList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTodos As New SqlParameter("@Todos", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pTodos.Value = Todos

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTodos)

            DBCommand.Fill(dsFicha, "Clientes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Cuenta, Nombre, Contacto, Direccion, Ciudad, Telefono FROM Clientes WHERE Nombre Like '%" & Filtro & "%' And Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "CLIENTES")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select CodGrup as [Código], Nombre, Nivel, Total From GRUPOS WHERE Tipo = '" & Tipo & "' AND CodGrup ='" & Filtro & "' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Clientes WHERE Codigo = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function AddItem(ByVal Codigo As String, ByVal Nombre As String, ByVal Contacto As String,
                                ByVal Cargo As String, ByVal Telefono_Contacto As String,
                                ByVal Celular_Contacto As String, ByVal Email_Contacto As String,
                                ByVal Gerente As String, ByVal Telefono_Gerente As String,
                                ByVal Celular_Gerente As String, ByVal Email_Gerente As String,
                                ByVal Contador As String, ByVal Telefono_Contador As String,
                                ByVal Celular_Contador As String, ByVal Email_Contador As String,
                                ByVal Direccion As String, ByVal Departamento As String, ByVal Municipio As String,
                                ByVal Ciudad As String, ByVal Telefono As String,
                                ByVal Fax As String, ByVal Correo As String, ByVal Ruc As String,
                                ByVal Cod_Zona As String, ByVal Cod_Forma_Pago As String, ByVal Desc_Prod As String,
                                ByVal Desc_Serv As String, ByVal Desc_Adicional As String,
                                ByVal Limite_Credito As Double, ByVal Vendedor As String, ByVal Cuenta As String,
                                ByVal Excento As Boolean, ByVal TipoCliente As String, ByVal Retenedor As Boolean,
                                ByVal PAIS As Integer, ByVal Retenedor_Alcaldia As Boolean, ByVal Cedula As String,
                                ByVal CodigoLetra As String, ByVal Empleado As Boolean,
                                ByVal Garantia As Integer, ByVal Moneda As String,
                                ByVal ValidarLimite As Integer,
                                ByVal Categoria As Integer, Observaciones As String, Activo As Integer, Agro As Integer,
                                Nombre_Comercial As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "INSERT INTO Clientes(Codigo, Nombre, Retenedor_Alcaldia, Contacto, Cargo, Telefono_Contacto, Celular_Contacto, " _
            + "Email_Contacto, Gerente, Telefono_Gerente, Celular_Gerente, Email_Gerente, Contador, Telefono_Contador, Celular_Contador, Email_Contador, " _
            + "Direccion, Departamento, Municipio, Ciudad, Telefono, Fax, Correo, Ruc, Cod_Zona, Cod_Forma_Pago, Desc_Prod, Desc_Serv, Desc_Adicional, " _
            + "Limite_Credito, Vendedor, Cuenta, Excento, TipoCliente, Retenedor, Empresa, pais_id,Cedula,CodigoLetra,Empleado,Garantia,Categoria,Moneda,ValidarLimite,Comentarios, ACTIVO, AgroServicio, Nombre_Comercial) " _
            + "Values(" & "'" & Codigo & "','" & Nombre & "','" & Retenedor_Alcaldia & "','" & Contacto & "','" & Cargo & "','" & Telefono_Contacto & "','" &
            Celular_Contacto & "','" & Email_Contacto & "','" & Gerente & "','" & Telefono_Gerente & "','" & Celular_Gerente & "','" & Email_Gerente & "','" &
            Contador & "','" & Telefono_Contador & "','" & Celular_Contador & "','" & Email_Contador & "','" & Direccion & "','" & Departamento & "','" &
            Municipio & "','" & Ciudad & "','" & Telefono & "','" & Fax & "','" & Correo & "','" & Ruc & "','" & Cod_Zona & "','" & Cod_Forma_Pago & "','" &
            Desc_Prod & "','" & Desc_Serv & "','" & Desc_Adicional & "'," & Limite_Credito & ",'" & Vendedor & "','" & Cuenta & "','" & Excento & "','" &
            TipoCliente & "','" & Retenedor & "','" & EmpresaActual & "','" & PAIS & "','" & Cedula & "','" & CodigoLetra & "','" &
            Empleado & "'," & Garantia & "," & Categoria & ",'" & Moneda & "'," & ValidarLimite & ",'" & Observaciones & "'," & Activo & "," & Agro & ", '" & Nombre_Comercial & "')"

            Try
                'Se asigna conexion al comando y se abre conexion 
                cmd.Connection = DBConn
                DBConn.Open()
                cmd.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Contacto As String,
            ByVal Cargo As String, ByVal Telefono_Contacto As String, ByVal Celular_Contacto As String,
            ByVal Email_Contacto As String, ByVal Gerente As String, ByVal Telefono_Gerente As String,
            ByVal Celular_Gerente As String, ByVal Email_Gerente As String, ByVal Contador As String,
            ByVal Telefono_Contador As String, ByVal Celular_Contador As String, ByVal Email_Contador As String,
            ByVal Direccion As String, ByVal Departamento As String, ByVal Municipio As String,
            ByVal Ciudad As String, ByVal Telefono As String, ByVal Fax As String, ByVal Correo As String,
            ByVal Ruc As String, ByVal Cod_Zona As String, ByVal Cod_Forma_Pago As String,
            ByVal Desc_Prod As String, ByVal Desc_Serv As String, ByVal Desc_Adicional As String,
            ByVal Limite_Credito As Double, ByVal Vendedor As String, ByVal Cuenta As String,
            ByVal Excento As String, ByVal TipoCliente As String, ByVal Retenedor As String,
            ByVal Pais As Integer, ByVal Retenedor_Alcaldia As Boolean, ByVal Cedula As String,
            ByVal CodigoLetra As String, ByVal Empleado As Boolean, ByVal Garantia As Integer,
            ByVal Moneda As String, ByVal ValidarLimite As Integer, ByVal Categoria As Integer,
            Observaciones As String, Activo As Integer, Agro As Integer,
            Nombre_Comercial As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)
            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Clientes SET Nombre = '" & Nombre & "', " &
                  "Contacto = '" & Contacto & "', " &
                  "Cargo = '" & Cargo & "', " &
                  "Telefono_Contacto = '" & Telefono_Contacto & "', " &
                  "Celular_Contacto = '" & Celular_Contacto & "', " &
                  "Email_Contacto = '" & Email_Contacto & "', " &
                  "Gerente = '" & Gerente & "', " &
                  "Telefono_Gerente = '" & Telefono_Gerente & "', " &
                  "Celular_Gerente = '" & Celular_Gerente & "', " &
                  "Email_Gerente = '" & Email_Gerente & "', " &
                  "Contador = '" & Contador & "', " &
                  "Telefono_Contador = '" & Telefono_Contador & "', " &
                  "Celular_Contador = '" & Celular_Contador & "', " &
                  "Email_Contador = '" & Email_Contador & "', " &
                  "Direccion = '" & Direccion & "', " &
                  "Departamento = '" & Departamento & "', " &
                  "Municipio = '" & Municipio & "', " &
                  "Ciudad = '" & Ciudad & "', " &
                  "Telefono = '" & Telefono & "', " &
                  "Fax = '" & Fax & "', " &
                  "Correo = '" & Correo & "', " &
                  "Ruc = '" & Ruc & "', " &
                  "Cod_Zona = " & Cod_Zona & ", " &
                  "Cod_Forma_Pago = '" & Cod_Forma_Pago & "', " &
                  "Desc_Prod = '" & Desc_Prod & "', " &
                  "Desc_Serv = '" & Desc_Serv & "', " &
                  "Desc_Adicional = '" & Desc_Adicional & "', " &
                  "Limite_Credito = " & Limite_Credito & ", " &
                  "Vendedor = '" & Vendedor & "', " &
                  "Cuenta = '" & Cuenta & "', " &
                  "Excento = '" & Excento & "', " &
                  "TipoCliente = '" & TipoCliente & "', " &
                  "Retenedor = '" & Retenedor & "', " &
                  "Retenedor_Alcaldia = '" & Retenedor_Alcaldia & "', " &
                  "pais_ID = '" & Pais & "', " &
                  "cedula = '" & Cedula & "', " &
                  "CodigoLetra = '" & CodigoLetra & "', " &
                  "Empleado = '" & Empleado & "', " &
                  "Garantia = " & Garantia & ", " &
                  "Categoria = " & Categoria & ", " &
                  "Moneda = '" & Moneda & "', " &
                  "Comentarios = '" & Observaciones & "', " &
                  "ValidarLimite = " & ValidarLimite & ", " &
                  "ACTIVO = " & Activo & ", " &
                  "AgroServicio = " & Agro & ",  " &
                  "Nombre_Comercial = '" & Nombre_Comercial & "' " &
                  " WHERE Codigo = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()
        End Function

        Public Shared Sub AnularRecibo(ByVal Recibo As String)
            Dim cmd As SqlCommand = New SqlCommand("_Anular_Recibo", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Recibo", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)


            _Factura.Value = Recibo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Sub CobrosUpdateIR(ByVal Recibo As String, ByVal Factura As String,
            ByVal TipoPago As Integer, ByVal MontoIR As Double)

            Dim cmd As SqlCommand = New SqlCommand("_CobrosUpdateIR", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure


            Dim _Recibo As SqlParameter = New SqlParameter("@Recibo", SqlDbType.Int)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim _TipoPago As SqlParameter = New SqlParameter("@Tipo_Pago", SqlDbType.Int)
            Dim _MontoIR As SqlParameter = New SqlParameter("@montoir", SqlDbType.Money)


            _Factura.Value = Factura
            _Recibo.Value = Recibo
            _Empresa.Value = EmpresaActual
            _TipoPago.Value = TipoPago
            _MontoIR.Value = MontoIR

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Recibo)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_TipoPago)
            cmd.Parameters.Add(_MontoIR)


            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Sub

        Public Shared Function BuscarRecibosDepositos(ByVal Recibo As String,
                                                      Serie As String) As Integer
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_BuscarRecibosDepositos", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pRecibo As New SqlParameter("@Recibo", SqlDbType.Int)
            pRecibo.Value = Recibo
            DBCommand.SelectCommand.Parameters.Add(pRecibo)

            Dim pEncontrados As New SqlParameter("@Encontrados", SqlDbType.Int)
            pEncontrados.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(pEncontrados)

            DBCommand.SelectCommand.Parameters.AddWithValue("@Serie", Serie)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

                Return pEncontrados.Value
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                Return -1
            End Try
        End Function

        Public Function EstadoCuentaReporteNew(ByVal Cliente As String, ByVal Mes As String, ByVal FormaPago As String,
                              ByVal Fecha As String, ByVal FechaDesde As DateTime, ByVal FechaHasta As DateTime,
                              ByVal Sucursal As String,
                              Rubro As String, QuitarSaldo As Integer) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SP_EstadoCuentaReporte", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            pCliente.Value = Cliente
            DBCommand.SelectCommand.Parameters.Add(pCliente)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Dim _FormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)
            _FormaPago.Value = FormaPago
            DBCommand.SelectCommand.Parameters.Add(_FormaPago)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
            _Fecha.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha)

            'If FechaDesde = "" Then
            '    Dim _Fechadesde As New SqlParameter("@Fechadesde", SqlDbType.NVarChar)
            '    _Fechadesde.Value = FechaDesde
            '    DBCommand.SelectCommand.Parameters.Add(_Fechadesde)
            'Else
            Dim _Fechadesde As New SqlParameter("@Fechadesde", SqlDbType.SmallDateTime)
            _Fechadesde.Value = FechaDesde
            DBCommand.SelectCommand.Parameters.Add(_Fechadesde)
            'End If

            'If FechaHasta = "" Then
            '    Dim _FechaHasta As New SqlParameter("@FechaHasta", SqlDbType.NVarChar)
            '    _FechaHasta.Value = FechaHasta
            '    DBCommand.SelectCommand.Parameters.Add(_FechaHasta)
            'Else
            Dim _FechaHasta As New SqlParameter("@FechaHasta", SqlDbType.SmallDateTime)
            _FechaHasta.Value = FechaHasta 'CDate(FechaHasta).AddDays(1)  sepa judas de donde salio 28052008
            DBCommand.SelectCommand.Parameters.Add(_FechaHasta)
            'End If

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim EmpresasDB As New VB.SysContab.EmpresasDB

            Dim _EmpresaName As New SqlParameter("@EmpresaName", SqlDbType.NVarChar)
            _EmpresaName.Value = EmpresasDB.GetDetails(EmpresaActual).Nombre
            DBCommand.SelectCommand.Parameters.Add(_EmpresaName)

            Dim _Sucursal As New SqlParameter("@Sucursal", SqlDbType.NVarChar)
            _Sucursal.Value = Sucursal
            DBCommand.SelectCommand.Parameters.Add(_Sucursal)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Rubro
            DBCommand.SelectCommand.Parameters.Add(_Cuenta)

            DBCommand.SelectCommand.Parameters.AddWithValue("@SaldoCero", QuitarSaldo)

            DBCommand.SelectCommand.CommandTimeout = 0
            DBCommand.Fill(dsFicha, "Facturas_Ventas")
            DBConn.Close()

            Dim qryUser = From row In dsFicha.Tables(0).AsEnumerable()
                              Select row.Field(Of String)("Cliente") Distinct

            Dim DT As DataTable = dsFicha.Tables(0).Clone

            Dim sS As String = ""

            Try

                For Each s As String In qryUser
                    If Not s Is Nothing Then

                        sS = s

                        Dim DT_CLIENTE As DataTable = dsFicha.Tables(0).Select("Cliente ='" & s.ToString() & "'").CopyToDataTable

                        Dim SaldoAteriorC As Double = 0.0,
                            SaldoAteriorU As Double = 0.0

                        For i As Integer = 0 To DT_CLIENTE.Rows.Count - 1
                            DT_CLIENTE.Rows.Item(i)("Saldo") = (SaldoAteriorC + DT_CLIENTE.Rows.Item(i)("Monto")) - DT_CLIENTE.Rows.Item(i)("Abono")
                            DT_CLIENTE.Rows.Item(i)("SaldoU") = (SaldoAteriorU + DT_CLIENTE.Rows.Item(i)("MontoU")) - DT_CLIENTE.Rows.Item(i)("AbonoU")

                            SaldoAteriorC = (SaldoAteriorC + DT_CLIENTE.Rows.Item(i)("Monto")) - DT_CLIENTE.Rows.Item(i)("Abono")
                            SaldoAteriorU = (SaldoAteriorU + DT_CLIENTE.Rows.Item(i)("MontoU")) - DT_CLIENTE.Rows.Item(i)("AbonoU")
                        Next
                        '          
                        'Agregar Contenido del DT actualizado con los saldos al DT maestro
                        DT.Merge(DT_CLIENTE)
                    End If
                Next

                dsFicha.Tables.Clear()
                dsFicha.Tables.Add(DT)

                'For i As Integer = 0 To dsFicha.Tables(0).Rows.Count - 1

                '    If dsFicha.Tables(0).Rows.Item(i)("Acción") = "Saldo Anterior" Or i = 0 Then
                '        dsFicha.Tables(0).Rows.Item(i)("Acumulado") = CDbl(dsFicha.Tables(0).Rows.Item(i)("Monto") - dsFicha.Tables(0).Rows.Item(i)("Abono"))

                '        dsFicha.Tables(0).Rows.Item(i)("AcumuladoU") = CDbl(dsFicha.Tables(0).Rows.Item(i)("Monto") - dsFicha.Tables(0).Rows.Item(i)("Abono"))
                '    Else                       
                '        dsFicha.Tables(0).Rows.Item(i)("Acumulado") = CDbl(dsFicha.Tables(0).Rows.Item(i - 1)("Acumulado") + _
                '            dsFicha.Tables(0).Rows.Item(i)("Monto") - _
                '            dsFicha.Tables(0).Rows.Item(i)("Abono"))

                '        dsFicha.Tables(0).Rows.Item(i)("AcumuladoU") = IIf(Math.Round(CDbl(dsFicha.Tables(0).Rows.Item(i)("Monto")), 2) = 0.0, dsFicha.Tables(0).Rows.Item(i)("Abono") * -1, dsFicha.Tables(0).Rows.Item(i)("Monto"))
                '    End If

                'Next

            Catch ex As Exception
                XtraMsg("Error en Linq: " & vbCrLf & sS & vbCrLf & ex.Message, MessageBoxIcon.Error)
            End Try

            Return dsFicha
        End Function

        Public Shared Sub ImprimirRecibo(NoRecibo As String,
                                         Serie As String,
                                         op As Integer)

            ShowSplash("Imprimiendo Recibo...")
            '
            Dim Temp As Boolean = db_Formatos.FormatoImpreso(3, "RptRecibo")

            Dim Rep As RptRecibo

            If Temp = True Then
                Rep = XtraReport.FromFile(Application.StartupPath & "\RptRecibo.repx", True)
            Else
                Rep = New RptRecibo
            End If

            'VistaPreviaDX(Rep,
            '              ObtieneDatos("SPGetRptRecibo", EmpresaActual, NoRecibo, op),
            '              "No. Recibo : " & NoRecibo)

            VistaPreviaDX(Rep,
                          ObtieneDatos("sp_sel_COBROSImprimir", Serie, NoRecibo, op, EmpresaActual),
                          "No. Recibo : " & Serie & NoRecibo)
            HideSplash()
        End Sub

        Public Shared Sub ImprimirReciboAnticipo(IdAnticipo As Integer)

            ShowSplash("Imprimiendo Recibo...")
            '
            'Dim Cadena As String
            'Dim Temp As Boolean = False
            'Dim Data() As Byte

            'Try
            '    'Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 3 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            '    Data = CType(db_Formatos.GetFormato(3).Rows(0).Item("ChequeD"), Byte())
            '    Temp = True
            '    Dim Tamano As Integer
            '    Tamano = Data.GetUpperBound(0)
            '    Cadena = Application.StartupPath & "\RptRecibo.repx"
            '    If File.Exists(Cadena) Then Kill(Cadena)
            '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            '    Archivo.Write(Data, 0, Tamano)
            '    Archivo.Close()

            'Catch ex As Exception
            '    Temp = False
            'End Try

            Dim Temp As Boolean = db_Formatos.FormatoImpreso(3, "RptRecibo")

            Dim Rep As RptRecibo

            If Temp = True Then
                Rep = XtraReport.FromFile(Application.StartupPath & "\RptRecibo.repx", True)
            Else
                Rep = New RptRecibo
            End If

            VistaPreviaDX(Rep,
                          ObtieneDatos("sp_AnticiposClientesImprimirROC", IdAnticipo, EmpresaActual),
                          "No. Recibo : " & db_AnticiposClientes.Detalles(IdAnticipo).NoRecibo)
            HideSplash()

            'Rep.DataSource = ObtieneDatos("sp_AnticiposClientesImprimirROC", IdAnticipo, EmpresaActual)
            'Rep.ShowPrintMarginsWarning = False
            'Rep.BringToFront()
            'HideSplash()
            'Rep.ShowRibbonPreview()
        End Sub

        Public Shared Function DinamicoCotizaciones(Desde As Date, Hasta As Date, Moneda As String) As DataTable
            Return ObtieneDatos("JAR_GetReporteDinamicoCotizaciones", Desde, Hasta, EmpresaActual, Moneda)
        End Function

        Public Shared Function DinamicoClientesAntiguedadProxima(Corte As Date, Moneda As String, Sucursal As String, QuitarRet As Integer) As DataTable
            Return ObtieneDatos("SPRptAnalisisAntiguedad_Proximas", EmpresaActual, 0, 0, Corte, Moneda, Sucursal, QuitarRet)
        End Function

        Public Shared Function DinamicoAntiguedadPorPeriodo(Desde As Date, Hasta As Date, Corte_Cobro As Date, Moneda As String, Sucursal As String) As DataTable
            Return ObtieneDatos("sp_antiguedad_por_periodo", EmpresaActual, Desde, Hasta, Corte_Cobro, Moneda, 1, "%", Sucursal)
        End Function

        Public Shared Function DinamicoAntiguedadPagado(Desde As Date, Hasta As Date, Sucursal As String, Moneda As Integer) As DataTable
            Return ObtieneDatos("JAR_GetAntiguedadPagado", Desde, Hasta, Sucursal, Moneda, EmpresaActual)
        End Function

        Public Shared Function DinamicoDevoluciones(Desde As Date, Hasta As Date, Moneda As String) As DataTable
            Return ObtieneDatos("JAR_GetDinamicoDevoluciones", Desde, Hasta, Moneda, EmpresaActual)
        End Function

        Public Shared Function DinamicoRebajas(Desde As Date, Hasta As Date, Moneda As String) As DataTable
            Return ObtieneDatos("JAR_GetDinamicoRebajas", Desde, Hasta, Moneda, EmpresaActual)
        End Function

        Public Shared Function DinamicoRecuperacionxSaldo(Corte As Date, Hasta As Date, Moneda As String,
                                                          Sucursal As String, Cuenta As String,
                                                          Optional Vacio As Boolean = False) As DataTable

            Return ObtieneDatos("sp_sel_ReporteRecuperacionXSaldo", Corte, Hasta, Moneda, Sucursal, Cuenta, IIf(Vacio, 0, EmpresaActual))

        End Function

        Public Shared Function GetImages(Tipo As String, Codigo As String) As DataTable
            Return ObtieneDatos("sp_GetImagenes", Tipo, Codigo, EmpresaActual)
        End Function

        Public Shared Function GetDocumentos(Tipo As String, Codigo As String) As DataTable
            Return ObtieneDatos("sp_GetDocuementos", Tipo, Codigo, EmpresaActual)
        End Function

        Public Shared Function GetImages(Id As Integer) As DataTable
            Return ObtieneDatos("sp_GetImagenesxID", Id)
        End Function

        Public Shared Sub DeleteImage(Id As Integer)
            GuardaDatos("DELETE FROM Soportes WHERE IdSoporte =" & Id)
        End Sub

        Public Shared Sub DeletePDF(Tipo As String, Codigo As String)
            GuardaDatos("DELETE FROM Soportes WHERE Tipo ='" & Tipo & "' AND Codigo = '" & Codigo & "' AND Empresa = " & EmpresaActual)
        End Sub

        Public Shared Sub AbrirDocumento(Id As Integer, Fichero As String)

            Try
                Dim Data As Byte() = CType(VB.SysContab.ClientesDB.GetImages(Id).Rows(0).Item(0), Byte())

                Dim Tamano As Integer = Data.GetUpperBound(0)
                Dim Cadena As String = Application.StartupPath & "\" & IIf(Fichero.Trim.Length = 0, "Manual.pdf", Fichero)
                If File.Exists(Cadena) Then Kill(Cadena)
                Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
                Archivo.Write(Data, 0, Tamano)
                Archivo.Close()

                Process.Start(Cadena)
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Shared Sub CrearDocumento(Id As Integer, Extencion As String, Ruta As String, Concecutivo As Integer)

            Try
                'Borrar Contenido del Directorio
                'My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\Soportes", FileIO.DeleteDirectoryOption.DeleteAllContents)               

                Dim Data As Byte() = CType(VB.SysContab.ClientesDB.GetImages(Id).Rows(0).Item(0), Byte())

                Dim Tamano As Integer = Data.GetUpperBound(0)
                'Dim Cadena As String = Application.StartupPath & "\Soportes\" & IIf(Fichero.Trim.Length = 0, "Manual.pdf", Fichero)
                Dim Cadena As String = Ruta + "Soporte" + Concecutivo.ToString.PadLeft(2, "0") + Extencion
                If File.Exists(Cadena) Then Kill(Cadena)
                Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
                Archivo.Write(Data, 0, Tamano)
                Archivo.Close()

                'Actualizar Ruta Completa en la Tabla
                Guardar("JAR_ActualizarRutaSoportes", Id, Cadena)
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
            End Try
        End Sub


        Public Shared Function MaestroNotasCDUpdateATV(IdNota As Integer,
                                                       Atv As String) As Boolean

            Return Guardar("sp_upd_MaestroNotasCDATV",
                           IdNota,
                           Atv,
                           EmpresaActual)

        End Function

        Public Shared Function GetNotaDetalle(IdNota As Integer) As DataTable

            Return ObtieneDatos("sp_sel_MaestroNotasCD",
                           IdNota,
                           EmpresaActual)

        End Function




    End Class
End Namespace
