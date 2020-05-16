Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Namespace VB.SysContab

    Public Class CotizacionesDB

        Public Function ImprimirCotizacion(ByVal Cotizacion As Long)
            'If MsgBox("¿Desea imprimir la Cotización?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            DBCommand = New SqlDataAdapter("_CotizacionesClientes", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pOrden As New SqlParameter("@Cotizacion", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            pOrden.Value = Cotizacion
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.Fill(dsFicha, "Cotizaciones")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function DeleteCotizacionDetalle(ByVal Cotizacion As String)
            Dim conexion As New VB.SysContab.Rutinas

            Dim cmd As SqlCommand = New SqlCommand("_CotizacionDelete", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Cotizacion As SqlParameter = New SqlParameter("@Cotizacion", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Cotizacion.Value = Cotizacion
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Cotizacion)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            'DBConn.Open()
            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
            'DBConn.Close()

        End Function

        Public Function UpdateCotizacion(ByVal Cotizacion As String, ByVal Descripcion As String, ByVal Cliente As String, _
                                         ByVal SubTotal As String, ByVal Descuento As String, ByVal Iva As String, _
                                         ByVal Total As String, ByVal Vendedor As String)


            ' Create Instance of Connection and Command Object

            '''Dim DBConn As SqlConnection

            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas

            ''''DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            ''''Dim cmd As SqlCommand = New SqlCommand("_FacturasVentasAdd", DBConn)

            Dim cmd As SqlCommand = New SqlCommand("_CotizacionUpdate", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Cotizacion As SqlParameter = New SqlParameter("@Cotizacion", SqlDbType.NVarChar, 50)
            Dim _Descripcion As SqlParameter = New SqlParameter("@Descripcion", SqlDbType.NVarChar, 8)
            Dim _Cliente As SqlParameter = New SqlParameter("@Cliente", SqlDbType.Int, 4)
            Dim _SubTotal As SqlParameter = New SqlParameter("@SubTotal", SqlDbType.Float, 8)
            Dim _Descuento As SqlParameter = New SqlParameter("@Descuento", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Total As SqlParameter = New SqlParameter("@Total", SqlDbType.Float, 8)
            Dim _Vendedor As SqlParameter = New SqlParameter("@Vendedor", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Cotizacion.Value = Cotizacion
            _Descripcion.Value = Descripcion
            _Cliente.Value = Cliente
            _SubTotal.Value = SubTotal
            _Descuento.Value = Descuento
            _Iva.Value = Iva
            _Total.Value = Total
            _Vendedor.Value = Vendedor
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Cotizacion)
            cmd.Parameters.Add(_Descripcion)
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

        Public Function UpdateEstado(ByVal Cotizacion As String, ByVal Factura As String)
            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_CotizacionUpdateEstado", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Cotizacion As SqlParameter = New SqlParameter("@Cotizacion", SqlDbType.NVarChar, 50)
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)


            _Cotizacion.Value = Cotizacion
            _Factura.Value = Factura
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Cotizacion)
            cmd.Parameters.Add(_Factura)
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

        Public Function CotizacionDetalle(ByVal Cotizacion As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CotizacionDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCotizacion As New SqlParameter("@Cotizacion", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pCotizacion.Value = Cotizacion
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCotizacion)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Cotizaciones")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CotizacionesBuscarXCodigo(ByVal Cotizacion As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CotizacionesBuscarXCodigo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCotizacion As New SqlParameter("@Cotizacion", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pCotizacion.Value = Cotizacion
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pCotizacion)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cotizaciones")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CotizacionesBuscar(ByVal Filtro As String, ByVal Estado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CotizacionesBuscar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pFiltro.Value = Filtro
            pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pFiltro)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cotizaciones")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CotizacionesXCliente(ByVal Cliente As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CotizacionesXCliente", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pCliente.Value = Cliente
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cotizaciones")

            DBConn.Close()

            Return dsFicha

        End Function

    End Class

End Namespace
