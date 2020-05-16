Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class CatalogoDetails
        Public Cuenta As String
        Public Nombre As String
        Public Tipo As String
        Public Cuenta_De As String
        Public Saldo_Inicial As String
        Public Presupuesto_Anual As String
        Public Grupo As String
        Public Clase As String
        Public SubCuenta As String
        Public Gpo_Presupuesto As String
        Public Proveedor As Boolean
        Public Caja As Boolean
        Public CajaBanco As Boolean
        Public Agrupacion As String
        Public Inventario As Boolean
        Public Distribucion As Boolean
        Public DeOrden As Boolean
        Public UtilidadPerdida As Boolean
        Public UtilidadAcumulada As Boolean
        Public CChica As Boolean
        Public Retencion As Boolean
        Public Devolucion As Boolean
        Public Rebajas As Boolean
        Public MntoValor As Boolean
        Public Rendicion As Boolean
        Public Activo As Boolean
        Public EsProyecto As Boolean
    End Class

    Public Class CatalogoDB


        Public Function GetListBuscar(ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Cuenta, Nombre, Grupo, Tipo, Cuenta_De, Saldo_Inicial, Presupuesto_Anual FROM Clientes WHERE Nombre Like '%" & Filtro & "%' AND Empresa = '" & Empresa & "'", DBConn)

            DBCommand = New SqlDataAdapter("SELECT CATALOGO.CUENTA, CATALOGO.CUENTA + ' - ' +  CATALOGO.NOMBRE AS NOMBRE, CATALOGO.TIPO AS TIPO, GRUPOS.CODIGO_GRUPO, GRUPOS.NOMBRE AS GRUPO, SALDO_INICIAL " & _
                                           "FROM CATALOGO INNER JOIN EMPRESAS ON CATALOGO.EMPRESA = EMPRESAS.CODIGO INNER JOIN GRUPOS ON GRUPOS.CODIGO_GRUPO = CATALOGO.GRUPO AND GRUPOS.EMPRESA = EMPRESAS.CODIGO AND EMPRESAS.CODIGO = '" & Empresa & "' WHERE Catalogo.Tipo = 'A' ORDER BY CUENTA", DBConn)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Function GetCuenta(ByVal Cuenta As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoGetCuenta", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pCuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            pCuenta.Value = Cuenta
            DBCommand.SelectCommand.Parameters.Add(pCuenta)

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            pTipo.Value = Tipo
            DBCommand.SelectCommand.Parameters.Add(pTipo)

            DBCommand.Fill(dsFicha, "Catalogo")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetList_SPTipo256(ByVal filtro As String, ByVal numero As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCCxTipo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Numero", SqlDbType.NVarChar)
            pIdent2.Value = EmpresaActual
            pIdent3.Value = filtro
            pIdent4.Value = numero
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                DBCommand.Fill(dsFicha, "Catalogo")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            DBConn.Close()
            Return dsFicha
        End Function

        '*******************************************************
        '--FECHA: 08/08/2006
        '--AUTOR: RtB
        '--OBJETIVO: Calcula el saldo anterior de una cuenta
        '*******************************************************
        Public Function GetListCuenta_SaldoAnterior(ByVal Periodo As String, ByVal Cuenta As String, _
            ByVal Hasta As Date, ByVal MonedaCambio As String) As Double
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCuenta_SaldoAnterior", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.Int)
            pPeriodo.Value = Periodo
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)

            Dim pCuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            pCuenta.Value = Cuenta
            DBCommand.SelectCommand.Parameters.Add(pCuenta)

            Dim pHasta As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            pHasta.Value = Hasta
            DBCommand.SelectCommand.Parameters.Add(pHasta)

            Dim pMonedaCambio As New SqlParameter("@Monedacambio", SqlDbType.NVarChar)
            pMonedaCambio.Value = MonedaCambio
            DBCommand.SelectCommand.Parameters.Add(pMonedaCambio)

            Dim pSaldo As New SqlParameter("@SAnterior", SqlDbType.Float)
            pSaldo.Value = 0.0
            pSaldo.Direction = ParameterDirection.InputOutput
            DBCommand.SelectCommand.Parameters.Add(pSaldo)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DBConn.Close()
            Return pSaldo.Value

        End Function

        Public Function SaldoInicialActualizar(ByVal Cuenta As String, ByVal Periodo As String, _
                                        ByVal Saldo As String, ByVal Operacion As Integer)

            ' Create Instance of Connection and Command Object
            Dim cmd As SqlCommand = New SqlCommand("_SaldoInicialActualizar", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Cuenta As SqlParameter = New SqlParameter("@UPCuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Cuenta
            cmd.Parameters.Add(_Cuenta)

            Dim _Periodo As New SqlParameter("@Periodo", SqlDbType.Int)
            _Periodo.Value = Periodo
            cmd.Parameters.Add(_Periodo)

            Dim _Saldo As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float)
            _Saldo.Value = Saldo
            cmd.Parameters.Add(_Saldo)

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            cmd.Parameters.Add(_Empresa)

            Dim _Operacion As New SqlParameter("@Operacion", SqlDbType.Int)
            _Operacion.Value = Operacion
            cmd.Parameters.Add(_Operacion)

            ' Open the connection and execute the Command

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function

        Public Function SaldoInicialAdd(ByVal Cuenta As String, ByVal Periodo As String, _
                                        ByVal Saldo As String)

            ' Create Instance of Connection and Command Object
            Dim cmd As SqlCommand = New SqlCommand("_SaldoInicialAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure


            ' Add Parameters to SPROC
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Cuenta
            cmd.Parameters.Add(_Cuenta)

            Dim _Periodo As New SqlParameter("@Periodo", SqlDbType.Int)
            _Periodo.Value = Periodo
            cmd.Parameters.Add(_Periodo)

            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.Float)
            _Saldo.Value = Saldo
            cmd.Parameters.Add(_Saldo)

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function

        Public Shared Function CatalogoXCuenta(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoXCuenta", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Codigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            _Codigo.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(_Codigo)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Catalogo")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function List() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogosList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Catalogo")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        '-- FECHA: 21/DIC/2005
        '--AUTOR: BERNARDO ROBELO
        '--OBJETIVO: Lista los Acumulados del Catalogo: Por Cuenta
        '*******************************************************

        Public Function GetListMayores(ByVal Cuenta As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoMayoresListBusqueda", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Cuenta
            DBCommand.SelectCommand.Parameters.Add(_Cuenta)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        '-- FECHA: 21/DIC/2005
        '--AUTOR: BERNARDO ROBELO
        '--OBJETIVO: Lista los Acumulados del Catalogo
        '*******************************************************

        Public Function GetListMayores() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoMayoresList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetList_SP(ByVal filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCC", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            pIdent2.Value = EmpresaActual
            pIdent3.Value = filtro
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                DBCommand.Fill(dsFicha, "Catalogo")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            DBConn.Close()
            Return dsFicha
        End Function

        '*******************************************************
        '-- FECHA: 21/DIC/2005
        '--AUTOR: BERNARDO ROBELO
        '--OBJETIVO: Lista los Acumulados del Catalogo
        '*******************************************************

        Public Function GetListAcumulados(ByVal Codigo As String, ByVal Desde As DateTime, ByVal hasta As DateTime) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())


            DBCommand = New SqlDataAdapter("_CatalogoAcumulados", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Codigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            _Codigo.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(_Codigo)

            Dim _desde As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            _desde.Value = Desde
            DBCommand.SelectCommand.Parameters.Add(_desde)

            Dim _Hasta As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            _Hasta.Value = hasta
            DBCommand.SelectCommand.Parameters.Add(_Hasta)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            Try
                DBCommand.Fill(dsFicha, "CATALOGO")
            Catch m As Exception
                MsgBox(m.Message)
            End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigoBuscar(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoListBuscar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Filtro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            _Filtro.Value = Filtro
            DBCommand.SelectCommand.Parameters.Add(_Filtro)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            Try
                DBCommand.Fill(dsFicha, "CATALOGO")
            Catch m As Exception
                MsgBox(m.Message)
            End Try

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        '-- FECHA: 17/NOV/2005
        '--AUTOR: BERNARDO ROBELO
        '--OBJETIVO: ACTUALIZAR EL CATALOGO DE CUENTAS
        '--DESCRIPCION: A partir de un numero de cuenta auxliar, 
        'un monto y una operacion (+ -) actualizar las subcuentas y principal
        '*******************************************************

        Public Function ActualizarCuentas123(ByVal Cuenta As String, ByVal Monto As String, _
                                          ByVal Operacion As Integer)

            ' Create Instance of Connection and Command Object
            Dim cmd As SqlCommand = New SqlCommand("_CatalogoActualizarCuentas", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure


            ' Add Parameters to SPROC
            Dim _UPCuenta As SqlParameter = New SqlParameter("@UPCuenta", SqlDbType.NVarChar)
            _UPCuenta.Value = Cuenta
            cmd.Parameters.Add(_UPCuenta)

            Dim _Monto As SqlParameter = New SqlParameter("@Monto", SqlDbType.Float)
            _Monto.Value = Monto
            cmd.Parameters.Add(_Monto)

            'OPERACION: 1 + SUMAR 2 - RESTAR
            Dim _Operacion As New SqlParameter("@Operacion", SqlDbType.Int)
            _Operacion.Value = Operacion
            cmd.Parameters.Add(_Operacion)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            ' Open the connection and execute the Command

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()



        End Function

        Public Function CatalogoList1(ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoList1", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CatalogoListTipo(ByVal Tipo As String, ByVal Estilo As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoListTipo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pEstilo As New SqlParameter("@Estilo", SqlDbType.Int)

            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual
            pEstilo.Value = Estilo

            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pEstilo)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function CatalogoList(ByVal Tipo As String, ByVal Caja As Boolean) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pCaja As New SqlParameter("@Caja", SqlDbType.Bit)

            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual
            pCaja.Value = Caja

            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pCaja)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CatalogoList(ByVal Tipo As String, ByVal Caja As Boolean, ByVal Distribuida As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoList_Distribuida", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pCaja As New SqlParameter("@Caja", SqlDbType.Bit)
            Dim pDistribuida As New SqlParameter("@Distribuida", SqlDbType.NVarChar)

            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual
            pCaja.Value = Caja
            pDistribuida.Value = Distribuida

            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pCaja)
            DBCommand.SelectCommand.Parameters.Add(pDistribuida)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function CatalogoList(ByVal Tipo As String, ByVal Caja As Boolean, _
            ByVal Inventario As Boolean, ByVal Campo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoList_Inventario", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pCaja As New SqlParameter("@Caja", SqlDbType.Bit)
            Dim pInventario As New SqlParameter("@Inventario", SqlDbType.NVarChar)

            pTipo.Value = Tipo
            pEmpresa.Value = EmpresaActual
            pCaja.Value = Caja
            pInventario.Value = Inventario

            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pCaja)
            DBCommand.SelectCommand.Parameters.Add(pInventario)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListAcumuladosCuenta(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListAcumuladosCuentaReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCodigo As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)


            pCodigo.Value = Codigo
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pCodigo)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        'Public Function GetListAcumulados(ByVal Codigo As String) As DataSet
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet()

        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    'DBCommand = New SqlDataAdapter("SELECT NOMBRE_MES AS MES, SUM(MONTO) AS MONTO, MES AS NUMERO_MES FROM ACUMULADOS WHERE CODIGO_CP ='" & Codigo & "' AND TIPO = '" & Tipo & "' AND EMPRESA = '" & EmpresaActual & "' GROUP BY CODIGO_CP, NOMBRE_MES, MES ORDER BY MES", DBConn)
        '    DBCommand = New SqlDataAdapter("SELECT MESES.MES, PRESUPUESTO, SUM(CATALOGO_ACUMULADOS.DEBE) AS DEBE, SUM(CATALOGO_ACUMULADOS.HABER) AS HABER, (SUM(CATALOGO_ACUMULADOS.DEBE) -  SUM(CATALOGO_ACUMULADOS.HABER)) AS SALDO, Catalogo.Cuenta, Catalogo.Nombre FROM MESES LEFT OUTER JOIN CATALOGO_ACUMULADOS ON MESES.MES = CATALOGO_ACUMULADOS.NOMBRE_MES INNER JOIN Catalogo ON CATALOGO_ACUMULADOS.Cuenta = Catalogo.Cuenta WHERE Catalogo.Cuenta = '" & Codigo & "' AND Catalogo.Empresa = '" & EmpresaActual & "' GROUP BY MESES.MES, MESES.NUMERO, PRESUPUESTO, Catalogo.Nombre, Catalogo.Cuenta ORDER BY Meses.Numero", DBConn)
        '    DBCommand.Fill(dsFicha, "CATALOGO_ACUMULADOS")

        '    DBConn.Close()

        '    Return dsFicha

        'End Function


        Public Function GetListGeneradorReportes(ByVal Grupo As String, ByVal Mayor As String, ByVal SubCuenta As String, ByVal Auxiliar As String, ByVal Ordenar As String, ByVal Saldo As Integer, ByVal Mes As Integer, ByVal Moneda As Integer, ByVal TipoCambio As Double) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCatalogoGeneradorReportes", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pGrupo As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim pMayor As New SqlParameter("@Mayor", SqlDbType.NVarChar)
            Dim pSubCuenta As New SqlParameter("@SubCuenta", SqlDbType.NVarChar)
            Dim pAuxiliar As New SqlParameter("@Auxiliar", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pOrdenar As New SqlParameter("@Ordenar", SqlDbType.Int)
            Dim pSaldo As New SqlParameter("@Saldo", SqlDbType.Int)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pMoneda As New SqlParameter("@Moneda", SqlDbType.Int)
            Dim pTipoCambio As New SqlParameter("@TipoCambio", SqlDbType.Float)

            pGrupo.Value = Grupo
            pMayor.Value = Mayor
            pSubCuenta.Value = SubCuenta
            pAuxiliar.Value = Auxiliar
            pEmpresa.Value = EmpresaActual
            pOrdenar.Value = Ordenar
            pSaldo.Value = Saldo
            pMes.Value = Mes
            pMoneda.Value = Moneda
            pTipoCambio.Value = TipoCambio

            DBCommand.SelectCommand.Parameters.Add(pGrupo)
            DBCommand.SelectCommand.Parameters.Add(pMayor)
            DBCommand.SelectCommand.Parameters.Add(pSubCuenta)
            DBCommand.SelectCommand.Parameters.Add(pAuxiliar)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pOrdenar)
            DBCommand.SelectCommand.Parameters.Add(pSaldo)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pMoneda)
            DBCommand.SelectCommand.Parameters.Add(pTipoCambio)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetDetails(ByVal Codigo As String) As CatalogoDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsCatalogo As New DataSet
            Dim Details As New CatalogoDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT * FROM Clientes WHERE Codigo = '" & Codigo & "' And Empresa = '" & EmpresaActual & "'", DBConn)

            DBCommand = New SqlDataAdapter("SELECT C.*, ISNULL(Saldo, 0) AS Saldo FROM Catalogo C LEFT JOIN CatalogoSaldo CS ON C.Cuenta = CS.Cuenta AND C.Empresa = CS.Empresa AND CS.Per_ID = " & VB.SysContab.PeriodosDB.Actual & " WHERE C.Cuenta = '" & Codigo & "' And C.Empresa = " & EmpresaActual, DBConn)

            DBCommand.Fill(dsCatalogo, "Catalogo")

            If dsCatalogo.Tables("Catalogo").Rows.Count = 1 Then
                Details.Cuenta = dsCatalogo.Tables("Catalogo").Rows(0).Item("Cuenta").ToString
                Details.Nombre = dsCatalogo.Tables("Catalogo").Rows(0).Item("Nombre").ToString
                Details.Tipo = dsCatalogo.Tables("Catalogo").Rows(0).Item("Tipo").ToString
                Details.Cuenta_De = dsCatalogo.Tables("Catalogo").Rows(0).Item("Cuenta_De").ToString
                Details.Grupo = dsCatalogo.Tables("Catalogo").Rows(0).Item("Grupo").ToString
                Details.Saldo_Inicial = dsCatalogo.Tables("Catalogo").Rows(0).Item("Saldo").ToString
                Details.Presupuesto_Anual = dsCatalogo.Tables("Catalogo").Rows(0).Item("Presupuesto_Anual").ToString
                Details.Clase = dsCatalogo.Tables("Catalogo").Rows(0).Item("Clase").ToString
                Details.SubCuenta = dsCatalogo.Tables("Catalogo").Rows(0).Item("SubCuenta").ToString
                Details.Gpo_Presupuesto = dsCatalogo.Tables("Catalogo").Rows(0).Item("grupo_presupuesto").ToString
                Details.Proveedor = dsCatalogo.Tables("Catalogo").Rows(0).Item("Proveedor").ToString
                Details.Caja = dsCatalogo.Tables("Catalogo").Rows(0).Item("Caja").ToString
                Details.CajaBanco = dsCatalogo.Tables("Catalogo").Rows(0).Item("CajaBanco").ToString
                Details.Agrupacion = dsCatalogo.Tables("Catalogo").Rows(0).Item("Agrupacion").ToString
                Details.Inventario = dsCatalogo.Tables("Catalogo").Rows(0).Item("Inventario")
                Details.Distribucion = dsCatalogo.Tables("Catalogo").Rows(0).Item("Distribucion")
                Details.DeOrden = dsCatalogo.Tables("Catalogo").Rows(0).Item("DeOrden")
                Details.UtilidadPerdida = dsCatalogo.Tables("Catalogo").Rows(0).Item("UtilidadPerdida")
                Details.UtilidadAcumulada = dsCatalogo.Tables("Catalogo").Rows(0).Item("UtilidadAcumulada")
                Details.CChica = dsCatalogo.Tables("Catalogo").Rows(0).Item("CChica")
                Details.Retencion = dsCatalogo.Tables("Catalogo").Rows(0).Item("Retencion")
                Details.Devolucion = dsCatalogo.Tables("Catalogo").Rows(0).Item("Devolucion")
                Details.Rebajas = dsCatalogo.Tables("Catalogo").Rows(0).Item("Rebajas")
                Details.MntoValor = dsCatalogo.Tables("Catalogo").Rows(0).Item("Mnto_Valor")
                Details.Rendicion = dsCatalogo.Tables("Catalogo").Rows(0).Item("Rendicion")
                Details.Activo = dsCatalogo.Tables("Catalogo").Rows(0).Item("Activo")
                Details.EsProyecto = dsCatalogo.Tables("Catalogo").Rows(0).Item("EsProyecto")
            End If

            Return Details

        End Function

        Public Function GetList(ByVal Nombre As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CatalogoLista", DBConn)
            'DBCommand = New SqlDataAdapter("_CatalogoListaSaldo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Nombre As New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Periodo As New SqlParameter("@PerID", SqlDbType.Int)

            _Nombre.Value = Nombre
            _Empresa.Value = EmpresaActual
            _Periodo.Value = VB.SysContab.PeriodosDB.Actual

            DBCommand.SelectCommand.Parameters.Add(_Nombre)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)
            DBCommand.SelectCommand.Parameters.Add(_Periodo)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha


            ''''Dim DBConn As SqlConnection
            ''''Dim DBCommand As SqlDataAdapter
            ''''Dim dsFicha As New DataSet()

            ''''Dim conexion As New VB.SysContab.Rutinas()
            ''''DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ''''DBCommand = New SqlDataAdapter("SELECT CATALOGO.CUENTA AS Cuenta, CATALOGO.NOMBRE AS Nombre, CATALOGO.TIPO AS Tipo, GRUPOS.CODIGO_GRUPO + ' - ' + GRUPOS.NOMBRE AS Grupo, CS.Saldo AS [Saldo], Clase " & _
            ''''                               "FROM CATALOGO LEFT JOIN CatalogoSaldo CS ON CATALOGO.Cuenta = CS.Cuenta AND CATALOGO.Empresa = CS.Empresa AND CS.Per_ID = " & VB.SysContab.PeriodosDB.Activo & " INNER JOIN EMPRESAS ON CATALOGO.EMPRESA = EMPRESAS.CODIGO INNER JOIN GRUPOS ON GRUPOS.CODIGO_GRUPO = CATALOGO.GRUPO AND CATALOGO.EMPRESA = EMPRESAS.CODIGO AND GRUPOS.EMPRESA = EMPRESAS.CODIGO AND CATALOGO.BALRES = GRUPOS.TIPO AND Catalogo.Nombre LIKE '%" & Nombre & "%' AND EMPRESAS.CODIGO = '" & EmpresaActual & "' ORDER BY CUENTA", DBConn)

            ''''DBCommand.Fill(dsFicha, "CATALOGO")

            ''''DBConn.Close()

            ''''Return dsFicha


        End Function

        ''''Public Function GetList() As DataSet

        ''''    ' Create Instance of Connection and Command Object
        ''''    Dim DBConn As SqlConnection
        ''''    Dim conexion As New VB.SysContab.Rutinas()

        ''''    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        ''''    'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionPagos"))
        ''''    'Dim cmd As SqlCommand = New SqlCommand("_CatalogoGetList", DBConn)

        ''''    ' Mark the Command as a SPROC
        ''''    'cmd.CommandType = CommandType.StoredProcedure

        ''''    ' Execute the command
        ''''    DBConn.Open()
        ''''    'Dim result As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        ''''    Dim dsCatalogo As New DataSet()

        ''''    Dim DBCommand As SqlDataAdapter
        ''''    DBCommand = New SqlDataAdapter("_CatalogoGetList", DBConn)
        ''''    DBCommand.Fill(dsCatalogo, "Catalogo")

        ''''    DBConn.Close()

        ''''    ' Return the datareader result
        ''''    'Return result
        ''''    Return dsCatalogo

        ''''End Function

        Public Function GetListBuscar(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Cuenta, Nombre, Grupo, Tipo, Cuenta_De, Saldo_Inicial, Presupuesto_Anual FROM Clientes WHERE Nombre Like '%" & Filtro & "%' AND Empresa = '" & Empresa & "'", DBConn)

            DBCommand = New SqlDataAdapter("SELECT CATALOGO.CUENTA, CATALOGO.NOMBRE AS NOMBRE, CATALOGO.TIPO AS TIPO, GRUPOS.CODIGO_GRUPO, GRUPOS.NOMBRE AS GRUPO, SALDO_INICIAL " & _
                                           "FROM CATALOGO INNER JOIN EMPRESAS ON CATALOGO.EMPRESA = EMPRESAS.CODIGO INNER JOIN GRUPOS ON GRUPOS.CODIGO_GRUPO = CATALOGO.GRUPO AND GRUPOS.EMPRESA = EMPRESAS.CODIGO AND CATALOGO.NOMBRE LIKE '%" & Filtro & "%' AND EMPRESAS.CODIGO = '" & Empresa & "' ORDER BY CUENTA", DBConn)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscarComboBanco(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Cuenta, Nombre, Grupo, Tipo, Cuenta_De, Saldo_Inicial, Presupuesto_Anual FROM Clientes WHERE Nombre Like '%" & Filtro & "%' AND Empresa = '" & Empresa & "'", DBConn)

            DBCommand = New SqlDataAdapter("SELECT CATALOGO.CUENTA AS CUENTA, CATALOGO.CUENTA + ' - ' + CATALOGO.NOMBRE AS NOMBRE, CATALOGO.TIPO AS TIPO, GRUPOS.CODIGO_GRUPO, GRUPOS.NOMBRE AS GRUPO, SALDO_INICIAL " & _
                                           "FROM CATALOGO INNER JOIN EMPRESAS ON CATALOGO.EMPRESA = EMPRESAS.CODIGO INNER JOIN GRUPOS ON GRUPOS.CODIGO_GRUPO = CATALOGO.GRUPO AND GRUPOS.TIPO = CATALOGO.BALRES AND GRUPOS.EMPRESA = EMPRESAS.CODIGO AND CATALOGO.NOMBRE LIKE '%" & Filtro & "%' AND EMPRESAS.CODIGO = '" & Empresa & "' ORDER BY CUENTA", DBConn)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscarCombo(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Cuenta, Nombre, Grupo, Tipo, Cuenta_De, Saldo_Inicial, Presupuesto_Anual FROM Clientes WHERE Nombre Like '%" & Filtro & "%' AND Empresa = '" & Empresa & "'", DBConn)

            DBCommand = New SqlDataAdapter("SELECT CATALOGO.CUENTA AS CUENTA, CATALOGO.CUENTA + ' - ' + CATALOGO.NOMBRE AS NOMBRE, CATALOGO.TIPO AS TIPO, GRUPOS.CODIGO_GRUPO, GRUPOS.NOMBRE AS GRUPO, SALDO_INICIAL " &
                                           "FROM CATALOGO INNER JOIN EMPRESAS ON CATALOGO.EMPRESA = EMPRESAS.CODIGO INNER JOIN GRUPOS ON GRUPOS.CODIGO_GRUPO = CATALOGO.GRUPO AND GRUPOS.TIPO = CATALOGO.BALRES AND GRUPOS.EMPRESA = EMPRESAS.CODIGO AND CATALOGO.NOMBRE LIKE '%" & Filtro & "%' AND EMPRESAS.CODIGO = '" & Empresa & "' AND CATALOGO.Tipo = 'A' ORDER BY CUENTA", DBConn)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscarComboMayor(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Cuenta, Nombre, Grupo, Tipo, Cuenta_De, Saldo_Inicial, Presupuesto_Anual FROM Clientes WHERE Nombre Like '%" & Filtro & "%' AND Empresa = '" & Empresa & "'", DBConn)

            DBCommand = New SqlDataAdapter("SELECT CATALOGO.CUENTA AS CUENTA, CATALOGO.NOMBRE AS NOMBRE, CATALOGO.TIPO AS TIPO, GRUPOS.CODIGO_GRUPO, GRUPOS.NOMBRE AS GRUPO, SALDO_INICIAL " & _
                                           "FROM CATALOGO INNER JOIN EMPRESAS ON CATALOGO.EMPRESA = EMPRESAS.CODIGO INNER JOIN GRUPOS ON GRUPOS.CODIGO_GRUPO = CATALOGO.GRUPO AND GRUPOS.EMPRESA = EMPRESAS.CODIGO AND CATALOGO.NOMBRE LIKE '" & Filtro & "%' AND CATALOGO.TIPO = 'M' AND EMPRESAS.CODIGO = '" & Empresa & "' ORDER BY CUENTA", DBConn)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListBuscarComboAuxiliar(ByVal Filtro As String, ByVal SubCuenta As String, ByVal Empresa As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Cuenta, Nombre, Grupo, Tipo, Cuenta_De, Saldo_Inicial, Presupuesto_Anual FROM Clientes WHERE Nombre Like '%" & Filtro & "%' AND Empresa = '" & Empresa & "'", DBConn)

            DBCommand = New SqlDataAdapter("SELECT CATALOGO.CUENTA AS CUENTA, CATALOGO.NOMBRE AS NOMBRE, CATALOGO.TIPO AS TIPO, GRUPOS.CODIGO_GRUPO, GRUPOS.NOMBRE AS GRUPO, SALDO_INICIAL " &
                                           "FROM CATALOGO INNER JOIN EMPRESAS ON CATALOGO.EMPRESA = EMPRESAS.CODIGO INNER JOIN GRUPOS ON GRUPOS.CODIGO_GRUPO = CATALOGO.GRUPO AND GRUPOS.EMPRESA = EMPRESAS.CODIGO AND CATALOGO.NOMBRE LIKE '" & Filtro & "%' AND CATALOGO.TIPO = 'A' AND CATALOGO.SUBCUENTA = '" & SubCuenta & "' AND EMPRESAS.CODIGO = '" & Empresa & "' ORDER BY CUENTA", DBConn)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function



        Public Function GetListCodigo(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CUENTA, NOMBRE, SUBCUENTA, SALDO_INICIAL, TIPO, CLASE FROM CATALOGO WHERE CUENTA ='" & Filtro & "' And Empresa = '" & Empresa & "'", DBConn)
            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigoBorrar(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CUENTA, NOMBRE, SALDO_INICIAL FROM CATALOGO WHERE CUENTA LIKE '" & Filtro & "%' AND CUENTA <> '" & Filtro & "' AND  Empresa = '" & Empresa & "'", DBConn)
            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListSubCuenta(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT CUENTA, NOMBRE, SALDO_INICIAL FROM CATALOGO WHERE SUBCUENTA = '" & Filtro & "' AND Empresa = '" & Empresa & "'", DBConn)
            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AddItem(ByVal Cuenta As String, ByVal Nombre As String, ByVal Tipo As String,
            ByVal Cuenta_De As String, ByVal Saldo_Inicial As String, ByVal Presupuesto_Anual As String,
            ByVal Grupo As String, ByVal Empresa As String, ByVal SubCuenta As String, ByVal Clase As String,
            ByVal Debito As String, ByVal Credito As String, ByVal Gpo_Presupuesto As String,
            ByVal Proveedor As Integer, ByVal Caja As Integer,
            ByVal Agrupacion As String, ByVal Inventario As Integer,
            ByVal Distribucion As Integer, ByVal DeOrden As Integer,
            ByVal UtilidadPerdida As Integer, ByVal UtilidadAcumulada As Integer, ByVal CChica As Boolean,
            ByVal Retencion As Boolean, ByVal Devolucion As Boolean, ByVal Rebajas As Boolean, MntoValor As Boolean,
            Rendicion As Boolean, Activo As Boolean, EsProyecto As Boolean)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "INSERT INTO Catalogo(Cuenta, Nombre, Tipo, Cuenta_De, BalRes, Saldo_Inicial, Presupuesto_Anual, Grupo, Clase, Empresa, Debito, Credito, SubCuenta, grupo_presupuesto, Proveedor, Caja, CajaBanco, Agrupacion, Inventario, Distribucion, DeOrden, UtilidadPerdida, UtilidadAcumulada,CChica,Retencion, Devolucion, Rebajas, Mnto_Valor, Rendicion, Activo, EsProyecto) " &
                        "Values(" & "'" & Cuenta & "','" & Nombre & "','" & Tipo & "','" & Cuenta_De & "','" & Cuenta_De & "','" & Saldo_Inicial & "','" & Presupuesto_Anual & "','" & Grupo & "','" & Clase & "','" & Empresa & "','" & Debito & "','" & Credito & "','" & SubCuenta & "','" & Gpo_Presupuesto & "'," & Proveedor & "," & Caja & "," & Caja & ", '" & Agrupacion & "'," & Inventario & "," & Distribucion & "," & DeOrden & "," & UtilidadPerdida & "," & UtilidadAcumulada & "," & IIf(CChica = False, 0, 1) & ", " & IIf(Retencion = False, 0, 1) & "," & IIf(Devolucion = False, 0, 1) & "," & IIf(Rebajas = False, 0, 1) & "," & IIf(MntoValor = False, 0, 1) & "," & IIf(Rendicion = False, 0, 1) & "," & IIf(Activo, 1, 0) & "," & IIf(EsProyecto, 1, 0) & ")"
            'Try
            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

        End Function


        Public Function Update(ByVal Cuenta As String, ByVal Nombre As String, ByVal Tipo As String,
            ByVal Cuenta_De As String, ByVal Saldo_Inicial As String, ByVal Presupuesto_Anual As String,
            ByVal Grupo As String, ByVal Empresa As String, ByVal Clase As String,
            ByVal Gpo_Presupuesto As String, ByVal Proveedor As Integer, ByVal Caja As Integer,
            ByVal Agrupacion As String, ByVal Inventario As Integer, ByVal Distribucion As Integer,
            ByVal DeOrden As Integer, ByVal UtilidadPerdida As Integer, ByVal UtilidadAcumulada As Integer,
            ByVal CChica As Boolean, ByVal Retencion As Boolean,
            ByVal Devolucion As Boolean, ByVal Rebajas As Boolean, MntoValor As Boolean, Rendicion As Boolean,
                               Activo As Boolean, EsProyecto As Boolean)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Catalogo SET Nombre = '" & Nombre & "', " &
                  "Tipo = '" & Tipo & "', " &
                  "Cuenta_De = '" & Cuenta_De & "', " &
                  "BalRes = '" & Cuenta_De & "', " &
                  "Saldo_Inicial = '" & Saldo_Inicial & "', " &
                  "Presupuesto_Anual = '" & Presupuesto_Anual & "', " &
                  "Grupo = '" & Grupo & "', " &
                  "Grupo_Presupuesto = '" & Gpo_Presupuesto & "', " &
                  "Agrupacion = '" & Agrupacion & "', " &
                  "Inventario = " & Inventario & ", " &
                  "Distribucion = " & Distribucion & ", " &
                  "DeOrden = " & DeOrden & ", " &
                  "UtilidadPerdida = " & UtilidadPerdida & ", " &
                  "UtilidadAcumulada = " & UtilidadAcumulada & ", " &
                  "Clase = '" & Clase & "', " &
                  "Proveedor = " & Proveedor & ", " &
                  "Caja = " & Caja & ", " &
                  "CajaBanco = " & Caja & ", " &
                  "CChica = " & IIf(CChica = False, 0, 1) & ", " &
                  "Devolucion = " & IIf(Devolucion = False, 0, 1) & ", " &
                  "Rebajas = " & IIf(Rebajas = False, 0, 1) & ", " &
                  "Retencion = " & IIf(Retencion = False, 0, 1) & ", " &
                  "Mnto_Valor = " & IIf(MntoValor = False, 0, 1) & ", " &
                  "Activo = " & IIf(Activo, 1, 0) & ", " &
                  "EsProyecto = " & IIf(EsProyecto, 1, 0) & ", " &
                  "Rendicion = " & IIf(Rendicion = False, 0, 1) & " " &
                  "WHERE Cuenta = '" & Cuenta & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function


        Public Shared Function Update_UP_UA(ByVal Utilidad As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            If Utilidad = "UP" Then
                cmd.CommandText = "UPDATE Catalogo set " & _
                      "UtilidadPerdida = " & "0 " & _
                      "WHERE  Empresa = '" & EmpresaActual & "'"
            Else
                cmd.CommandText = "UPDATE Catalogo set " & _
                      "UtilidadAcumulada = " & "0 " & _
                      "WHERE  Empresa = '" & EmpresaActual & "'"
            End If
            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function UpdateSaldos(ByVal Cuenta As String, ByVal Saldo_Actual As String, ByVal Saldo_Nuevo As String, ByVal Empresa As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Catalogo SET Saldo_Inicial = '" & CInt(Saldo_Actual) + CInt(Saldo_Nuevo) & "' " & _
                              "WHERE Cuenta = '" & Cuenta & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        'Esta funcion se utiliza cuando se modifica una cuenta
        Public Function UpdateSaldosEdit(ByVal Cuenta As String, ByVal Saldo As String, ByVal Tipo As Integer)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            If Tipo = 1 Then
                cmd.CommandText = "UPDATE Catalogo SET Saldo_Inicial = '" & Saldo & "', " & _
                                  "Debito = '" & Saldo & "' " & _
                                  "WHERE Cuenta = '" & Cuenta & "' AND Empresa = '" & EmpresaActual & "'"
            Else
                cmd.CommandText = "UPDATE Catalogo SET Saldo_Inicial = '" & Saldo & "', " & _
                                  "Credito = '" & Saldo & "' " & _
                                  "WHERE Cuenta = '" & Cuenta & "' AND Empresa = '" & EmpresaActual & "'"
            End If

            'cmd.CommandText = "UPDATE Catalogo SET Saldo_Inicial = '" & Saldo & "', " & _
            '                  "Debito = '" & Saldo & "' " & _
            '                  "WHERE Cuenta = '" & Cuenta & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Catalogo WHERE Cuenta = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function


        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.RutinasNomina
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCatalogoReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "CATALOGO")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GenReporte(ByVal Grupo As String, ByVal Mayor As String, ByVal Subcuenta As String, _
        ByVal Auxiliar As String, ByVal Saldo As Integer, ByVal Mes As Integer, _
        ByVal Moneda As Integer, ByVal Tipocambio As Integer, ByVal Ordenar As Integer) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCatalogoGeneradorReportes", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Grupo As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim _Mayor As New SqlParameter("@Mayor", SqlDbType.NVarChar)
            Dim _Subcuenta As New SqlParameter("@Subcuenta", SqlDbType.NVarChar)
            Dim _Auxiliar As New SqlParameter("@Auxiliar", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Saldo As New SqlParameter("@Saldo", SqlDbType.Int)
            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim _Moneda As New SqlParameter("@Moneda", SqlDbType.Int)
            Dim _Tipocambio As New SqlParameter("@Tipocambio", SqlDbType.Float)
            Dim _Ordenar As New SqlParameter("@Ordenar", SqlDbType.Int)

            _Grupo.Value = Grupo
            _Mayor.Value = Mayor
            _Subcuenta.Value = Subcuenta
            _Auxiliar.Value = Auxiliar
            _Empresa.Value = EmpresaActual
            _Saldo.Value = Saldo
            _Mes.Value = Mes
            _Moneda.Value = Moneda
            _Tipocambio.Value = Tipocambio
            _Ordenar.Value = Ordenar

            DBCommand.SelectCommand.Parameters.Add(_Grupo)
            DBCommand.SelectCommand.Parameters.Add(_Mayor)
            DBCommand.SelectCommand.Parameters.Add(_Subcuenta)
            DBCommand.SelectCommand.Parameters.Add(_Auxiliar)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)
            DBCommand.SelectCommand.Parameters.Add(_Saldo)
            DBCommand.SelectCommand.Parameters.Add(_Mes)
            DBCommand.SelectCommand.Parameters.Add(_Moneda)
            DBCommand.SelectCommand.Parameters.Add(_Tipocambio)
            DBCommand.SelectCommand.Parameters.Add(_Ordenar)

            DBCommand.Fill(dsFicha, "CATALOGO")
            DBConn.Close()
            DBConn.Dispose()

            Return dsFicha

        End Function

        Sub AddItem(p1 As String, p2 As String, Tipo As String, CuentaD As String, SaldoInicial As Double, PresupuestoAnual As Double, p7 As Object, EmpresaActual As String, p9 As Object, p10 As Integer, Debito As Double, Credito As Double, p13 As Object, Proveedor As Integer, Caja As Integer, p16 As Object, p17 As Object, p18 As Object, p19 As Object, p20 As Object, p21 As Object, p22 As Boolean, p23 As Boolean, p24 As Boolean, p25 As Boolean, p26 As Boolean)
            Throw New NotImplementedException
        End Sub

    End Class
End Namespace