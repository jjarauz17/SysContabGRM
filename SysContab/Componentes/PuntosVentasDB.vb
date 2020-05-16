Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class PuntosVentasDetails
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

    End Class

    Public Class PuntosVentasDB

        Public Function GetList2(ByVal EmpresaActual As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PuntosVentaList2", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Puntos_Venta")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub AddItem(ByVal Codigo As String, ByVal Nombre As String, ByVal PCNombre As String)

            Dim DBConn As SqlConnection
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_PuntosVentaAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.Int, 4)
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _PCNombre As SqlParameter = New SqlParameter("@Pc_Nombre", SqlDbType.NVarChar, 50)

            _Codigo.Value = Codigo
            _Nombre.Value = Nombre
            _PCNombre.Value = PCNombre
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_PCNombre)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

        End Sub

        Public Function List() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PuntosVentaList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Puntos_Venta")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Numero() As Integer
            Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_CotizacionNumero", DBConn)

            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim cmd As SqlCommand = New SqlCommand("_PuntosVentaNumero", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            'Dim pCotizacion As New SqlParameter("@Cotizacion", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)


            Dim pPuntoVenta As SqlParameter = New SqlParameter("@PuntoVenta", SqlDbType.Int, 4)
            pPuntoVenta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pPuntoVenta)


            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            ' Return the Total
            If pPuntoVenta.Value.ToString() <> "" Then
                Return CType(pPuntoVenta.Value, Integer)
            Else
                Return 1
            End If
        End Function

        Public Function PcNombre(ByVal Nombre As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PuntosVentaPcNombre", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pPcNombre As New SqlParameter("@PcNombre", SqlDbType.NVarChar)
            Dim pEmpresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            pPcNombre.Value = Nombre
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pPcNombre)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Puntos_Venta")

            DBConn.Close()

            Return dsFicha

        End Function

    End Class

End Namespace
