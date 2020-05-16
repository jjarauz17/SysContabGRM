Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab
    '*******************************************************
' ComprobanteDB
    ' Objetivo: Manejar todas configuraciones
' Autor: Bernardo Robelo
    ' Fecha: 15/Nov/2005
    '*******************************************************
    Public Class ConfiguracionDetails

        Public IVA As Double = 0
        Public IRProd As Double = 0
        Public IRServ As Double = 0
        Public MontoIR As Double = 0
        Public IR_Ventas As Double = 0
        Public INATEC As Double = 0
        Public FacturaDigitos As Integer = 0
        Public FacturaNumero As Double = 0
        Public SeriesMultiples As Boolean = False
        Public ReciboDigitos As Integer = 0
        Public ReciboNumero As Double = 0
        Public OrdenClienteNumero As Double = 0
        Public CotizacionNumero As Double = 0
        Public PedidoNumero As Double = 0
        Public OrdenCompraNumero As Double = 0
        Public DevolucionClienteNumero As Double = 0
        Public DevolucionProveedorNumero As Double = 0
        Public RequisaBodegaNumero As Double = 0
        Public Bodega As String = 0
        Public Decimales As Integer = 0
        Public RecChica As Integer = 0
        Public RecDigitos As Integer = 0
        Public Liqudacion As Boolean = False
        Public LineasFactura As Integer = 0
    End Class

    Public Class ConfiguracionDB

        Public Shared Function GetConfigDetails() As ConfiguracionDetails
            Dim TConfig As DataTable = ObtieneDatos("SELECT * FROM Configuraciones WHERE Empresa = " & EmpresaActual)

            Try
                If TConfig.Rows.Item(0)("IVA").ToString.Trim.Length <> 0 Then

                    Dim myOrderDetails As New ConfiguracionDetails

                    myOrderDetails.IRProd = TConfig.Rows.Item(0)("IR_Prod") '_IRProd.Value
                    myOrderDetails.IRServ = TConfig.Rows.Item(0)("IR_Serv") '_IRServ.Value
                    myOrderDetails.IVA = TConfig.Rows.Item(0)("IVA") '_IVA.Value
                    myOrderDetails.MontoIR = TConfig.Rows.Item(0)("MontoIR") '_MontoIR.Value
                    myOrderDetails.IR_Ventas = TConfig.Rows.Item(0)("IR_Ventas") '_IR_Ventas.Value
                    myOrderDetails.INATEC = TConfig.Rows.Item(0)("INATEC") '_INATEC.Value
                    myOrderDetails.FacturaDigitos = TConfig.Rows.Item(0)("FacturaDigitos") '_FacturaDigitos.Value
                    myOrderDetails.FacturaNumero = TConfig.Rows.Item(0)("FacturaNumero") '_FacturaNumero.Value
                    myOrderDetails.SeriesMultiples = IIf(TConfig.Rows.Item(0)("SeriesMultiples").ToString.Trim.Length = 0, 0, TConfig.Rows.Item(0)("SeriesMultiples")) '_SeriesMultiples.Value
                    myOrderDetails.ReciboDigitos = TConfig.Rows.Item(0)("ReciboDigitos") '_ReciboDigitos.Value
                    myOrderDetails.ReciboNumero = TConfig.Rows.Item(0)("ReciboNumero") '_ReciboNumero.Value
                    myOrderDetails.OrdenClienteNumero = TConfig.Rows.Item(0)("OrdenClienteNumero") '_OrdenClienteNumero.Value
                    myOrderDetails.CotizacionNumero = TConfig.Rows.Item(0)("CotizacionNumero") '_CotizacionNumero.Value
                    myOrderDetails.PedidoNumero = TConfig.Rows.Item(0)("PedidoNumero") '_PedidoNumero.Value
                    myOrderDetails.OrdenCompraNumero = TConfig.Rows.Item(0)("OrdenCompraNumero") '_OrdenCompraNumero.Value
                    myOrderDetails.DevolucionClienteNumero = TConfig.Rows.Item(0)("DevolucionClienteNumero") '_DevolucionClienteNumero.Value
                    myOrderDetails.DevolucionProveedorNumero = TConfig.Rows.Item(0)("DevolucionProveedorNumero") '_DevolucionProveedorNumero.Value
                    myOrderDetails.RequisaBodegaNumero = TConfig.Rows.Item(0)("RequisaBodegaNumero")
                    myOrderDetails.Bodega = TConfig.Rows.Item(0)("Codigo_Bodega") '_Bodega.Value
                    myOrderDetails.Decimales = TConfig.Rows.Item(0)("DECIMALES_PROD") '_DecimalesProd.Value
                    myOrderDetails.RecChica = TConfig.Rows.Item(0)("RecChica") '_DecimalesProd.Value
                    myOrderDetails.RecDigitos = TConfig.Rows.Item(0)("RecDigitos") '_DecimalesProd.Value
                    myOrderDetails.Liqudacion = TConfig.Rows.Item(0)("Liquidacion")
                    myOrderDetails.LineasFactura = TConfig.Rows.Item(0)("LineasFactura")

                    Return myOrderDetails
                Else
                    Return Nothing
                End If

            Catch ex As Exception

            End Try

            'Dim Conn As SqlConnection
            ' Create Instance of Connection and Command Object
            'Dim conexion As New VB.SysContab.Rutinas()
            'Conn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim cmd As New SqlDataAdapter("_ConfiguracionDetalles", Conn)
            '' Mark the Command as a SPROC
            'cmd.SelectCommand.CommandType = CommandType.StoredProcedure

            '' Add Parameters to SPROC
            'Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'pEmpresa.Value = EmpresaActual
            'cmd.SelectCommand.Parameters.Add(pEmpresa)

            'Dim _IVA As New SqlParameter("@IVA", SqlDbType.Float)
            '_IVA.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_IVA)

            'Dim _IRProd As New SqlParameter("@IRProd", SqlDbType.Float)
            '_IRProd.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_IRProd)

            'Dim _IRServ As New SqlParameter("@IRServ", SqlDbType.Float)
            '_IRServ.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_IRServ)

            'Dim _MontoIR As New SqlParameter("@MontoIR", SqlDbType.Float)
            '_MontoIR.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_MontoIR)

            'Dim _IR_Ventas As New SqlParameter("@IR_Ventas", SqlDbType.Float)
            '_IR_Ventas.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_IR_Ventas)

            'Dim _INATEC As New SqlParameter("@INATEC", SqlDbType.Float)
            '_INATEC.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_INATEC)

            'Dim _FacturaDigitos As New SqlParameter("@FacturaDigitos", SqlDbType.Int)
            '_FacturaDigitos.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_FacturaDigitos)

            'Dim _FacturaNumero As New SqlParameter("@FacturaNumero", SqlDbType.Float)
            '_FacturaNumero.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_FacturaNumero)

            'Dim _SeriesMultiples As New SqlParameter("@SeriesMultiples", SqlDbType.Bit)
            '_SeriesMultiples.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_SeriesMultiples)

            'Dim _ReciboDigitos As New SqlParameter("@ReciboDigitos", SqlDbType.Int)
            '_ReciboDigitos.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_ReciboDigitos)

            'Dim _ReciboNumero As New SqlParameter("@ReciboNumero", SqlDbType.Float)
            '_ReciboNumero.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_ReciboNumero)

            'Dim _OrdenClienteNumero As New SqlParameter("@OrdenClienteNumero", SqlDbType.Float)
            '_OrdenClienteNumero.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_OrdenClienteNumero)

            'Dim _CotizacionNumero As New SqlParameter("@CotizacionNumero", SqlDbType.Float)
            '_CotizacionNumero.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_CotizacionNumero)

            'Dim _PedidoNumero As New SqlParameter("@PedidoNumero", SqlDbType.Float)
            '_PedidoNumero.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_PedidoNumero)

            'Dim _OrdenCompraNumero As New SqlParameter("@OrdenCompraNumero", SqlDbType.Float)
            '_OrdenCompraNumero.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_OrdenCompraNumero)

            'Dim _DevolucionClienteNumero As New SqlParameter("@DevolucionClienteNumero", SqlDbType.Float)
            '_DevolucionClienteNumero.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_DevolucionClienteNumero)

            'Dim _DevolucionProveedorNumero As New SqlParameter("@DevolucionProveedorNumero", SqlDbType.Float)
            '_DevolucionProveedorNumero.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_DevolucionProveedorNumero)

            'Dim _Bodega As New SqlParameter("@Bodega", SqlDbType.NVarChar, 50)
            '_Bodega.Direction = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_Bodega)

            ''Numero de Decimales en Productos/Inventario
            'Dim _DecimalesProd As New SqlParameter("@Decimales", SqlDbType.Int)
            '_DecimalesProd.Value = ParameterDirection.Output
            'cmd.SelectCommand.Parameters.Add(_DecimalesProd)

            'Conn.Open()
            'cmd.SelectCommand.ExecuteNonQuery()
            'Conn.Close()
            ' ship date is null if order doesn't exist, or belongs to a different user

            'If Not _IVA.Value Is DBNull.Value Then

            '    ' Create and Populate OrderDetails Struct using
            '    ' Output Params from the SPROC, as well as the
            '    ' populated dataset from the SqlDataAdapter
            '    Dim myOrderDetails As New ConfiguracionDetails

            '    myOrderDetails.IRProd = _IRProd.Value
            '    myOrderDetails.IRServ = _IRServ.Value
            '    myOrderDetails.IVA = _IVA.Value
            '    myOrderDetails.MontoIR = _MontoIR.Value
            '    myOrderDetails.IR_Ventas = _IR_Ventas.Value
            '    myOrderDetails.INATEC = _INATEC.Value
            '    myOrderDetails.FacturaDigitos = _FacturaDigitos.Value
            '    myOrderDetails.FacturaNumero = _FacturaNumero.Value
            '    myOrderDetails.SeriesMultiples = _SeriesMultiples.Value
            '    myOrderDetails.ReciboDigitos = _ReciboDigitos.Value
            '    myOrderDetails.ReciboNumero = _ReciboNumero.Value
            '    myOrderDetails.OrdenClienteNumero = _OrdenClienteNumero.Value
            '    myOrderDetails.CotizacionNumero = _CotizacionNumero.Value
            '    myOrderDetails.PedidoNumero = _PedidoNumero.Value
            '    myOrderDetails.OrdenCompraNumero = _OrdenCompraNumero.Value
            '    myOrderDetails.DevolucionClienteNumero = _DevolucionClienteNumero.Value
            '    myOrderDetails.DevolucionProveedorNumero = _DevolucionProveedorNumero.Value
            '    myOrderDetails.Bodega = _Bodega.Value
            '    myOrderDetails.Decimales = _DecimalesProd.Value

            '    ' Return the DataSet
            '    Return myOrderDetails
            'Else
            '    Return Nothing
            'End If
        End Function

        Public Shared Sub UpdateBodegaDefault(ByVal Bodega As String)

            Dim Conn As SqlConnection
            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Conn = New SqlConnection(Rutinas.AbrirConexion())
            Dim cmd As New SqlDataAdapter("_BodegaDefault", Conn)

            ' Mark the Command as a SPROC
            cmd.SelectCommand.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.SelectCommand.Parameters.Add(pEmpresa)


            Dim _Bodega As New SqlParameter("@Bodega", SqlDbType.NVarChar, 50)
            _Bodega.Value = Bodega
            cmd.SelectCommand.Parameters.Add(_Bodega)

            Try
                Conn.Open()
                cmd.SelectCommand.ExecuteNonQuery()
                Conn.Close()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
                Conn.Close()
                Exit Sub
            End Try
        End Sub
    End Class
End Namespace
