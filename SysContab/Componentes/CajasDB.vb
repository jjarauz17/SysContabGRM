Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class CajasDetails
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

    Public Class CajasDB
        Public Function GetList2(ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CajasList2", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AddItem(ByVal Codigo As String, ByVal Nombre As String, ByVal PcNombre As String, _
                                ByVal HoraCorte_Fija As Date, ByVal HoraCorte As Date, _
                                Optional ByVal Bodega As String = "0", Optional ByVal GerenteNombre As String = "", _
                                Optional ByVal Cuenta As String = "", Optional ByVal CentroCosto As Integer = 0)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_CajasAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.Int, 4)
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar, 50)
            Dim _Pc_Nombre As SqlParameter = New SqlParameter("@Pc_Nombre", SqlDbType.NVarChar, 64)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Bodega As SqlParameter = New SqlParameter("@Bodega", SqlDbType.NVarChar)
            Dim _GteNombre As SqlParameter = New SqlParameter("@NombreGerente", SqlDbType.NVarChar)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim _CCosto As SqlParameter = New SqlParameter("@CentroCosto", SqlDbType.Int, 4)
            Dim _HoraFija As SqlParameter = New SqlParameter("@HoraCorte_Fija", SqlDbType.DateTime)
            Dim _HoraCorte As SqlParameter = New SqlParameter("@HoraCorte", SqlDbType.date)

            _Codigo.Value = Codigo
            _Nombre.Value = Nombre
            _Pc_Nombre.Value = PcNombre
            _Empresa.Value = EmpresaActual
            _Bodega.Value = Bodega
            _GteNombre.Value = GerenteNombre
            _Cuenta.Value = Cuenta
            _CCosto.Value = CentroCosto
            _HoraFija.Value = HoraCorte_Fija
            _HoraCorte.Value = HoraCorte

            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Pc_Nombre)
            cmd.Parameters.Add(_Bodega)
            cmd.Parameters.Add(_GteNombre)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_CCosto)
            cmd.Parameters.Add(_HoraFija)
            cmd.Parameters.Add(_HoraCorte)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
        End Function

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String, ByVal PcNombre As String, _
                               ByVal HoraCorte_Fija As Date, ByVal HoraCorte As Date, _
                               Optional ByVal Bodega As String = "0", Optional ByVal GerenteNombre As String = "", _
                               Optional ByVal Cuenta As String = "", Optional ByVal CentroCosto As Integer = 0)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_CajasUpdate", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.Int, 4)
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar, 50)
            Dim _Pc_Nombre As SqlParameter = New SqlParameter("@Pc_Nombre", SqlDbType.NVarChar, 64)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Bodega As SqlParameter = New SqlParameter("@Bodega", SqlDbType.NVarChar)
            Dim _GteNombre As SqlParameter = New SqlParameter("@NombreGerente", SqlDbType.NVarChar)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim _CCosto As SqlParameter = New SqlParameter("@CentroCosto", SqlDbType.Int, 4)
            Dim _HoraFija As SqlParameter = New SqlParameter("@HoraCorte_Fija", SqlDbType.DateTime)
            Dim _HoraCorte As SqlParameter = New SqlParameter("@HoraCorte", SqlDbType.DateTime)

            _Codigo.Value = Codigo
            _Nombre.Value = Nombre
            _Pc_Nombre.Value = PcNombre
            _Empresa.Value = EmpresaActual
            _Bodega.Value = Bodega
            _GteNombre.Value = GerenteNombre
            _Cuenta.Value = Cuenta
            _CCosto.Value = CentroCosto
            _HoraFija.Value = HoraCorte_Fija
            _HoraCorte.Value = HoraCorte

            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Pc_Nombre)
            cmd.Parameters.Add(_Bodega)
            cmd.Parameters.Add(_GteNombre)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_CCosto)
            cmd.Parameters.Add(_HoraFija)
            cmd.Parameters.Add(_HoraCorte)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
        End Function

        Public Function List() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CajasList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Cajas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Numero() As Integer
            Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_CotizacionNumero", DBConn)

            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim cmd As SqlCommand = New SqlCommand("_CajasNumero", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pCaja As SqlParameter = New SqlParameter("@Caja", SqlDbType.Int, 4)
            pCaja.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pCaja)

            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Empresa)

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            ' Return the Total
            If pCaja.Value.ToString() <> "" Then
                Return CType(pCaja.Value, Integer)
            Else
                Return 1
            End If
        End Function

        Public Function PcNombre(ByVal Nombre As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CajasPcNombre", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pPcNombre As New SqlParameter("@PcNombre", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            pPcNombre.Value = Nombre
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pPcNombre)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Cajas")

            DBConn.Close()

            Return dsFicha

        End Function

    End Class

End Namespace
