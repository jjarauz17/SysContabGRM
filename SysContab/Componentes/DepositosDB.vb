Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class DepositosDetails
        Public Numero As String
        Public Deposito_ID As String
        Public Fecha As Date
        Public Banco_ID As String
        Public Banco_Cuenta As String
        Public Estado As Boolean
    End Class
    Public Class DepositosDB

        Public Sub OtrosIngresosDelete(ByVal Comp As String, ByVal Periodo As String, ByVal Fecha As String)

            Dim cmd As SqlCommand = New SqlCommand("_DepositoOIBorrar", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure

            Dim _Comp As SqlParameter = New SqlParameter("@ComprNO", SqlDbType.NVarChar)
            Dim _Periodo As SqlParameter = New SqlParameter("@PerID", SqlDbType.Decimal)
            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)

            _Comp.Value = Comp
            _Periodo.Value = Periodo
            _Fecha.Value = Fecha
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Comp)
            cmd.Parameters.Add(_Periodo)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Sub UpdateEstado(ByVal Deposito As String, ByVal Estado As String)

            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_DepositosUpdateEstado", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pDeposito As New SqlParameter("@Deposito", SqlDbType.NVarChar)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.Int)
            Dim pEmpresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            pDeposito.Value = Deposito
            pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pDeposito)
            cmd.Parameters.Add(pEstado)
            cmd.Parameters.Add(pEmpresa)

            ' Open the connection and execute the Command
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Function GetBancoDeposito(ByVal VarDeposito As String) As String

            ' Create Instance of Connection and Command Object
            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            Dim cmd As SqlCommand = New SqlCommand("_DepositosGetBanco", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _VarDeposito As New SqlParameter("@VarDeposito", SqlDbType.NVarChar)
            _VarDeposito.Value = VarDeposito
            cmd.Parameters.Add(_VarDeposito)

            Dim _Banco As SqlParameter = New SqlParameter("@Banco", SqlDbType.NVarChar, 40)
            _Banco.Direction = ParameterDirection.Output
            cmd.Parameters.Add(_Banco)

            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            Return _Banco.Value

        End Function

        Public Function CantidadXFecha(ByVal Fecha As String) As Integer
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_DepositosCantidadXFecha", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFecha.Value = Fecha
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pFecha)
            cmd.Parameters.Add(pEmpresa)

            Dim parameterCantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Int, 4)
            parameterCantidad.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterCantidad)


            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            ' Return the Total
            'If parameterCantidad.Value.ToString() <> "" Then
            Return CType(parameterCantidad.Value, Integer)
            'Else
            '    Return 0
            'End If

        End Function

        Public Function DepositosDetallesBuscar(ByVal Deposito As String, ByVal Cobro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DepositosDetallesBuscar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pDeposito As New SqlParameter("@DepositoID", SqlDbType.NVarChar)
            Dim pCobro As New SqlParameter("@CobroID", SqlDbType.Decimal)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pDeposito.Value = Deposito
            pCobro.Value = Cobro
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pDeposito)
            DBCommand.SelectCommand.Parameters.Add(pCobro)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function DepositosgetDetalles(ByVal Deposito As String) As DepositosDetails
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim Detalle As New VB.SysContab.DepositosDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DepositosGetDetails", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pDeposito As New SqlParameter("@Deposito", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pDeposito.Value = Deposito
            pEmpresa.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pDeposito)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "Cobros")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            If dsFicha.Tables("Cobros").Rows.Count = 1 Then
                Detalle.Banco_Cuenta = dsFicha.Tables("Cobros").Rows(0)("banco_cuenta")
                Detalle.Banco_ID = dsFicha.Tables("Cobros").Rows(0)("Banco_ID")
                Detalle.Deposito_ID = dsFicha.Tables("Cobros").Rows(0)("Deposito_ID")
                Detalle.Estado = dsFicha.Tables("Cobros").Rows(0)("Deposito_estado")
                Detalle.Fecha = dsFicha.Tables("Cobros").Rows(0)("Deposito_fecha")
                Detalle.Numero = dsFicha.Tables("Cobros").Rows(0)("Deposito_numero")
            End If
            Return Detalle
        End Function

        Public Sub DepositosDetallesDelete(ByVal Deposito As String, ByVal Cobro As String, ByVal Numero As String)
            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_DepositosDetallesDelete", DBConnFacturas)
            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            'Dim cmd As SqlCommand = New SqlCommand("_DepositosDetallesDelete", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Deposito As SqlParameter = New SqlParameter("@DepositoID", SqlDbType.NVarChar)
            Dim _Cobro As SqlParameter = New SqlParameter("@CobroID", SqlDbType.Decimal)
            Dim _Numero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)


            _Deposito.Value = Deposito
            _Cobro.Value = Cobro
            _Numero.Value = Numero
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Deposito)
            cmd.Parameters.Add(_Cobro)
            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas 'Lineas
            cmd.ExecuteNonQuery()

            ' Open the connection and execute the Command
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

        End Sub

        Public Function DepositosDetalles(ByVal Deposito) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DepositoDetallesList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pDeposito As New SqlParameter("@Deposito_ID", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pDeposito.Value = Deposito
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pDeposito)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Cobros")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub AddItemDetalles(ByVal Deposito_ID As String, ByVal Cobro_ID As String, ByVal Monto As String)

            Dim cmd As SqlCommand = New SqlCommand("_DepositosDetallesAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Deposito As SqlParameter = New SqlParameter("@Deposito_ID", SqlDbType.NVarChar)
            Dim _Cobro As SqlParameter = New SqlParameter("@Cobro_ID", SqlDbType.Decimal)
            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Deposito.Value = Deposito_ID
            _Cobro.Value = Cobro_ID
            _Monto.Value = Monto
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Deposito)
            cmd.Parameters.Add(_Cobro)
            cmd.Parameters.Add(_Monto)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub

        Public Sub AddItem(ByVal Numero As String, ByVal Codigo As String, ByVal Fecha As String, _
                           ByVal Banco As String, ByVal Cuenta As String, ByVal Documento As String)

            Dim DBConn As SqlConnection

            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_DepositosAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Numero As SqlParameter = New SqlParameter("@Deposito_Numero", SqlDbType.Decimal)
            Dim _Codigo As SqlParameter = New SqlParameter("@Deposito_ID", SqlDbType.NVarChar)
            Dim _Fecha As SqlParameter = New SqlParameter("@Deposito_Fecha", SqlDbType.DateTime, 8)
            Dim _Banco As SqlParameter = New SqlParameter("@Banco_ID", SqlDbType.Int, 4)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Banco_Cuenta", SqlDbType.NVarChar, 50)
            Dim _Documento As SqlParameter = New SqlParameter("@Documento", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Numero.Value = Numero
            _Codigo.Value = Codigo
            _Fecha.Value = Fecha
            _Banco.Value = Banco
            _Cuenta.Value = Cuenta
            _Documento.Value = Documento
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Numero)
            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Fecha)
            cmd.Parameters.Add(_Banco)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_Documento)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
        End Sub

        Public Function List(ByVal Banco As String, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Estado As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DepositosList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pBanco As New SqlParameter("@Banco", SqlDbType.Int)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pEstado As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            pBanco.Value = Banco
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pEstado.Value = Estado
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pBanco)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Depositos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Numero(ByVal Fecha As String) As Integer
            Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_CotizacionNumero", DBConn)

            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim cmd As SqlCommand = New SqlCommand("_DepositosNumero", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim _Fecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 8)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim pDeposito As SqlParameter = New SqlParameter("@Deposito", SqlDbType.Int, 4)
            pDeposito.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pDeposito)


            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            ' Return the Total
            If pDeposito.Value.ToString() <> "" Then
                Return CType(pDeposito.Value, Integer)
            Else
                Return 1
            End If
        End Function

    End Class

End Namespace

