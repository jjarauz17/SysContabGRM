
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class ConciliacionBancariaDB

        Public Function TiposMovimientosCB(ByVal Tipo As String, ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTiposMovimientosCB", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pCodigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pTipo.Value = Tipo
            pCodigo.Value = Codigo

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pCodigo)

            Try
                DBCommand.Fill(dsFicha, "TMCB")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            DBConn.Close()

            Return dsFicha

        End Function

        Public Function UltimaConciliacion() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListUltimaConciliacion", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "UltimaConciliacion")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            DBConn.Close()

            Return dsFicha

        End Function

        Public Function TiposEstadoCB(ByVal Tipo As String, ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTiposEstadoCB", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pCodigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pTipo.Value = Tipo
            pCodigo.Value = Codigo

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pCodigo)

            Try
                DBCommand.Fill(dsFicha, "TECB")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            DBConn.Close()

            Return dsFicha

        End Function


        Public Function Conciliacion_BancariaADD(ByVal Codigo As String, ByVal Periodo As String, ByVal Desde As Date, _
            ByVal Hasta As Date, ByVal SaldoAnteriorBco As Double, ByVal DebitosBco As Double, _
            ByVal CreditosBco As Double, ByVal SaldoBco As Double, ByVal SaldoAnterior As Double, _
            ByVal Debitos As Double, ByVal Creditos As Double, ByVal Saldo As Double, ByVal Banco As String, _
            ByVal Cuenta As String, Elaborado_por As String, Revisado_por As String, Estado As Integer) As String


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Conciliacion_BancariaADD", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empr_codigo", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            Dim pCodigo As New SqlParameter("@cb_codigo", SqlDbType.NVarChar)
            pCodigo.Direction = ParameterDirection.InputOutput
            pCodigo.Value = Codigo

            Dim pPeriodo As New SqlParameter("@Per_Id", SqlDbType.Int)
            pPeriodo.Value = Periodo

            Dim pDesde As New SqlParameter("@cb_Desde", SqlDbType.SmallDateTime)
            pDesde.Value = Desde

            Dim pHasta As New SqlParameter("@cb_hasta", SqlDbType.SmallDateTime)
            pHasta.Value = Hasta

            Dim pSaldoAnteriorBCO As New SqlParameter("@cb_SaldoAnteriorBCO", SqlDbType.Money)
            pSaldoAnteriorBCO.Value = SaldoAnteriorBco
            Dim pDebitosBCO As New SqlParameter("@cb_debitosbco", SqlDbType.Money)
            pDebitosBCO.Value = DebitosBco
            Dim pCreditosBCO As New SqlParameter("@cb_creditosbco", SqlDbType.Money)
            pCreditosBCO.Value = CreditosBco
            Dim pSaldoBCO As New SqlParameter("@cb_SaldoBco", SqlDbType.Money)
            pSaldoBCO.Value = SaldoBco


            Dim pSaldoAnterior As New SqlParameter("@cb_SaldoAnterior", SqlDbType.Money)
            pSaldoAnterior.Value = SaldoAnterior
            Dim pDebitos As New SqlParameter("@cb_debitos", SqlDbType.Money)
            pDebitos.Value = Debitos
            Dim pCreditos As New SqlParameter("@cb_creditos", SqlDbType.Money)
            pCreditos.Value = Creditos
            Dim pSaldo As New SqlParameter("@cb_Saldo", SqlDbType.Money)
            pSaldo.Value = Saldo

            Dim pBanco As New SqlParameter("@cb_Banco", SqlDbType.Int)
            pBanco.Value = Banco

            Dim pCuenta As New SqlParameter("@cb_Cuenta", SqlDbType.NVarChar)
            pCuenta.Value = Cuenta

            Dim pElaborado As New SqlParameter("@elaborado_por", SqlDbType.NVarChar)
            pElaborado.Value = Elaborado_por

            Dim pRevisado As New SqlParameter("@revisado_por", SqlDbType.NVarChar)
            pRevisado.Value = Revisado_por



            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pCodigo)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pDesde)
            DBCommand.SelectCommand.Parameters.Add(pHasta)
            DBCommand.SelectCommand.Parameters.Add(pSaldoAnteriorBCO)
            DBCommand.SelectCommand.Parameters.Add(pDebitosBCO)
            DBCommand.SelectCommand.Parameters.Add(pCreditosBCO)
            DBCommand.SelectCommand.Parameters.Add(pSaldoBCO)
            DBCommand.SelectCommand.Parameters.Add(pSaldoAnterior)
            DBCommand.SelectCommand.Parameters.Add(pDebitos)
            DBCommand.SelectCommand.Parameters.Add(pCreditos)
            DBCommand.SelectCommand.Parameters.Add(pSaldo)
            DBCommand.SelectCommand.Parameters.Add(pBanco)
            DBCommand.SelectCommand.Parameters.Add(pCuenta)
            DBCommand.SelectCommand.Parameters.Add(pElaborado)
            DBCommand.SelectCommand.Parameters.Add(pRevisado)

            DBCommand.SelectCommand.Parameters.AddWithValue("@Estado", Estado)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Return ""
                Exit Function
            End Try

            DBConn.Close()
            Return CType(pCodigo.Value, String)

        End Function


        Public Function Conciliacion_BancariaUPDATE(ByVal Codigo As String, ByVal Periodo As String, ByVal Desde As Date,
            ByVal Hasta As Date, ByVal SaldoAnteriorBco As Double, ByVal DebitosBco As Double,
            ByVal CreditosBco As Double, ByVal SaldoBco As Double, ByVal SaldoAnterior As Double,
            ByVal Debitos As Double, ByVal Creditos As Double, ByVal Saldo As Double, ByVal Banco As String,
            ByVal Cuenta As String, Elaborado_por As String, Revisado_por As String, Estado As Integer) As String


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Conciliacion_BancariaUPDATE", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empr_codigo", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            Dim pCodigo As New SqlParameter("@cb_codigo", SqlDbType.NVarChar)
            pCodigo.Direction = ParameterDirection.Input
            pCodigo.Value = Codigo

            Dim pPeriodo As New SqlParameter("@Per_Id", SqlDbType.Int)
            pPeriodo.Value = Periodo

            Dim pDesde As New SqlParameter("@cb_Desde", SqlDbType.SmallDateTime)
            pDesde.Value = Desde

            Dim pHasta As New SqlParameter("@cb_hasta", SqlDbType.SmallDateTime)
            pHasta.Value = Hasta

            Dim pSaldoAnteriorBCO As New SqlParameter("@cb_SaldoAnteriorBCO", SqlDbType.Money)
            pSaldoAnteriorBCO.Value = SaldoAnteriorBco
            Dim pDebitosBCO As New SqlParameter("@cb_debitosbco", SqlDbType.Money)
            pDebitosBCO.Value = DebitosBco
            Dim pCreditosBCO As New SqlParameter("@cb_creditosbco", SqlDbType.Money)
            pCreditosBCO.Value = CreditosBco
            Dim pSaldoBCO As New SqlParameter("@cb_SaldoBco", SqlDbType.Money)
            pSaldoBCO.Value = SaldoBco


            Dim pSaldoAnterior As New SqlParameter("@cb_SaldoAnterior", SqlDbType.Money)
            pSaldoAnterior.Value = SaldoAnterior
            Dim pDebitos As New SqlParameter("@cb_debitos", SqlDbType.Money)
            pDebitos.Value = Debitos
            Dim pCreditos As New SqlParameter("@cb_creditos", SqlDbType.Money)
            pCreditos.Value = Creditos
            Dim pSaldo As New SqlParameter("@cb_Saldo", SqlDbType.Money)
            pSaldo.Value = Saldo

            Dim pBanco As New SqlParameter("@cb_Banco", SqlDbType.Int)
            pBanco.Value = Banco

            Dim pCuenta As New SqlParameter("@cb_Cuenta", SqlDbType.NVarChar)
            pCuenta.Value = Cuenta

            Dim pElaborado As New SqlParameter("@elaborado_por", SqlDbType.NVarChar)
            pElaborado.Value = Elaborado_por

            Dim pRevisado As New SqlParameter("@revisado_por", SqlDbType.NVarChar)
            pRevisado.Value = Revisado_por



            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pCodigo)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pDesde)
            DBCommand.SelectCommand.Parameters.Add(pHasta)
            DBCommand.SelectCommand.Parameters.Add(pSaldoAnteriorBCO)
            DBCommand.SelectCommand.Parameters.Add(pDebitosBCO)
            DBCommand.SelectCommand.Parameters.Add(pCreditosBCO)
            DBCommand.SelectCommand.Parameters.Add(pSaldoBCO)
            DBCommand.SelectCommand.Parameters.Add(pSaldoAnterior)
            DBCommand.SelectCommand.Parameters.Add(pDebitos)
            DBCommand.SelectCommand.Parameters.Add(pCreditos)
            DBCommand.SelectCommand.Parameters.Add(pSaldo)
            DBCommand.SelectCommand.Parameters.Add(pBanco)
            DBCommand.SelectCommand.Parameters.Add(pCuenta)
            DBCommand.SelectCommand.Parameters.Add(pElaborado)
            DBCommand.SelectCommand.Parameters.Add(pRevisado)

            DBCommand.SelectCommand.Parameters.AddWithValue("@Estado", Estado)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Return ""
                Exit Function
            End Try

            DBConn.Close()
            Return CType(pCodigo.Value, String)

        End Function

        Public Shared Function Insertar(
                                       ByVal Codigo As String,
                                       ByVal Periodo As String,
                                       ByVal Desde As Date,
                                       ByVal Hasta As Date,
                                       ByVal SaldoAnteriorBco As Double,
                                       ByVal DebitosBco As Double,
                                       ByVal CreditosBco As Double,
                                       ByVal SaldoBco As Double,
                                       ByVal SaldoAnterior As Double,
                                       ByVal Debitos As Double,
                                       ByVal Creditos As Double,
                                       ByVal Saldo As Double,
                                       ByVal Banco As String,
                                       ByVal Cuenta As String,
                                       Elaborado_por As String,
                                       Revisado_por As String,
                                       Estado As Integer,
                                       DT As DataTable) As Boolean

            '/**********************************************************************
            '** Inicializar la Transaccion Principal
            '**********************************************************************/
            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
            Conn.IniciarTransaccion()

            Try
                Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("CB_Codigo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Codigo)
                Conn.AddParameter("Per_id", SqlDbType.Int, 4, ParameterDirection.Input, Periodo)
                Conn.AddParameter("CB_Desde", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, Desde)
                Conn.AddParameter("CB_Hasta", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, Hasta)
                Conn.AddParameter("CB_SaldoAnteriorBco", SqlDbType.Decimal, 18, ParameterDirection.Input, SaldoAnteriorBco)
                Conn.AddParameter("CB_SaldoBco", SqlDbType.Decimal, 18, ParameterDirection.Input, SaldoBco)
                Conn.AddParameter("CB_CreditosBco", SqlDbType.Decimal, 18, ParameterDirection.Input, CreditosBco)
                Conn.AddParameter("CB_DebitosBco", SqlDbType.Decimal, 18, ParameterDirection.Input, DebitosBco)
                Conn.AddParameter("CB_SaldoAnterior", SqlDbType.Decimal, 18, ParameterDirection.Input, SaldoAnterior)
                Conn.AddParameter("CB_Saldo", SqlDbType.Decimal, 18, ParameterDirection.Input, Saldo)
                Conn.AddParameter("CB_Creditos", SqlDbType.Decimal, 18, ParameterDirection.Input, Creditos)
                Conn.AddParameter("CB_Debitos", SqlDbType.Decimal, 18, ParameterDirection.Input, Debitos)
                Conn.AddParameter("CB_Banco", SqlDbType.Int, 4, ParameterDirection.Input, Banco)
                Conn.AddParameter("CB_Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, Cuenta)
                Conn.AddParameter("elaborado_por", SqlDbType.NVarChar, 50, ParameterDirection.Input, Elaborado_por)
                Conn.AddParameter("revisado_por", SqlDbType.NVarChar, 50, ParameterDirection.Input, Revisado_por)
                Conn.AddParameter("Estado", SqlDbType.Int, 4, ParameterDirection.Input, Estado)
                Conn.AddParameter("DT_CONCILIACION_BANCARIA", SqlDbType.Structured, 0, ParameterDirection.Input, DT)

                Conn.EjecutarComando("sp_ins_Conciliacion_Bancaria")
                Conn.CompletarTransaccion()

                Return True
            Catch ex As Exception
                Conn.AnularTransaccion()
                XtraMsg("Error al Guardar Conciliación: " & vbCrLf & ex.Message, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Public Shared Function Actualizar(
                                         ByVal Codigo As String,
                                         ByVal Periodo As String,
                                         ByVal Desde As Date,
                                         ByVal Hasta As Date,
                                         ByVal SaldoAnteriorBco As Double,
                                         ByVal DebitosBco As Double,
                                         ByVal CreditosBco As Double,
                                         ByVal SaldoBco As Double,
                                         ByVal SaldoAnterior As Double,
                                         ByVal Debitos As Double,
                                         ByVal Creditos As Double,
                                         ByVal Saldo As Double,
                                         ByVal Banco As String,
                                         ByVal Cuenta As String,
                                         Elaborado_por As String,
                                         Revisado_por As String,
                                         Estado As Integer,
                                         DT As DataTable) As Boolean

            '/**********************************************************************
            '** Inicializar la Transaccion Principal
            '**********************************************************************/
            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
            Conn.IniciarTransaccion()

            Try
                Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("CB_Codigo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Codigo)
                Conn.AddParameter("Per_id", SqlDbType.Int, 4, ParameterDirection.Input, Periodo)
                Conn.AddParameter("CB_Desde", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, Desde)
                Conn.AddParameter("CB_Hasta", SqlDbType.SmallDateTime, 8, ParameterDirection.Input, Hasta)
                Conn.AddParameter("CB_SaldoAnteriorBco", SqlDbType.Decimal, 18, ParameterDirection.Input, SaldoAnteriorBco)
                Conn.AddParameter("CB_SaldoBco", SqlDbType.Decimal, 18, ParameterDirection.Input, SaldoBco)
                Conn.AddParameter("CB_CreditosBco", SqlDbType.Decimal, 18, ParameterDirection.Input, CreditosBco)
                Conn.AddParameter("CB_DebitosBco", SqlDbType.Decimal, 18, ParameterDirection.Input, DebitosBco)
                Conn.AddParameter("CB_SaldoAnterior", SqlDbType.Decimal, 18, ParameterDirection.Input, SaldoAnterior)
                Conn.AddParameter("CB_Saldo", SqlDbType.Decimal, 18, ParameterDirection.Input, Saldo)
                Conn.AddParameter("CB_Creditos", SqlDbType.Decimal, 18, ParameterDirection.Input, Creditos)
                Conn.AddParameter("CB_Debitos", SqlDbType.Decimal, 18, ParameterDirection.Input, Debitos)
                Conn.AddParameter("CB_Banco", SqlDbType.Int, 4, ParameterDirection.Input, Banco)
                Conn.AddParameter("CB_Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, Cuenta)
                Conn.AddParameter("elaborado_por", SqlDbType.NVarChar, 50, ParameterDirection.Input, Elaborado_por)
                Conn.AddParameter("revisado_por", SqlDbType.NVarChar, 50, ParameterDirection.Input, Revisado_por)
                Conn.AddParameter("Estado", SqlDbType.Int, 4, ParameterDirection.Input, Estado)
                Conn.AddParameter("DT_CONCILIACION_BANCARIA", SqlDbType.Structured, 0, ParameterDirection.Input, DT)

                Conn.EjecutarComando("sp_upd_Conciliacion_Bancaria")
                Conn.CompletarTransaccion()

                Return True
            Catch ex As Exception
                Conn.AnularTransaccion()
                XtraMsg("Error al Actualizar Conciliación: " & vbCrLf & ex.Message, MessageBoxIcon.Error)
                Return False
            End Try

        End Function

        Public Shared Function BorrarDetalleConciliacion(Codigo As String) As Boolean

            Return Guardar("JAR_BorrarDetalleConciliacion", Codigo, EmpresaActual)

        End Function



        Public Function Conciliacion_Bancaria_DetalleADD(ByVal Codigo As String, ByVal DetID As String, ByVal Valor As String, _
           ByVal ES As String, ByVal Estado As String, ByVal Tipo As String, ByVal Sistema As Boolean, _
           ByVal Trasladado As Boolean, ByVal Concepto As String, ByVal Fecha As String, ByVal Documento As String,
           ByVal Razon As Integer, ByVal Conciliado As Integer, ByVal Encontrado As Integer)     ', ByVal Comprobante As Integer)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Conciliacion_Bancaria_DetalleADD", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empr_codigo", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            Dim pCodigo As New SqlParameter("@cb_codigo", SqlDbType.NVarChar, 6)
            'pCodigo.Direction = ParameterDirection.InputOutput
            pCodigo.Value = Codigo

            Dim pDetID As New SqlParameter("@cb_DetID", SqlDbType.NVarChar)
            pDetID.Value = DetID
            Dim pES As New SqlParameter("@cb_es", SqlDbType.NVarChar)
            pES.Value = ES
            Dim pEstado As New SqlParameter("@cb_estado", SqlDbType.NVarChar)
            pEstado.Value = Estado
            Dim pTipo As New SqlParameter("@cb_Tipo", SqlDbType.NVarChar)
            pTipo.Value = Tipo

            Dim pSistema As New SqlParameter("@cb_Sistema", SqlDbType.Bit)
            pSistema.Value = Sistema

            Dim pTrasladado As New SqlParameter("@cb_Trasladado", SqlDbType.Bit)
            pTrasladado.Value = Trasladado

            Dim pValor As New SqlParameter("@cb_Valor", SqlDbType.Money)
            pValor.Value = Valor

            Dim pConcepto As New SqlParameter("@cb_Concepto", SqlDbType.NVarChar, 100)
            pConcepto.Value = Concepto

            Dim pFecha As New SqlParameter("@cb_fecha", SqlDbType.SmallDateTime)
            pFecha.Value = IIf(Len(Fecha) = 0, DBNull.Value, Fecha)

            Dim pDocumento As New SqlParameter("@cb_documento", SqlDbType.NVarChar)
            pDocumento.Value = Documento

            Dim pRazon As New SqlParameter("@IdRazon", SqlDbType.Int)
            pRazon.Value = Razon

            Dim pConciliado As New SqlParameter("@Conciliado", SqlDbType.Int)
            pConciliado.Value = Conciliado

            Dim pEncontrado As New SqlParameter("@Encontrado", SqlDbType.Int)
            pEncontrado.Value = Encontrado


            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pCodigo)
            DBCommand.SelectCommand.Parameters.Add(pDetID)
            DBCommand.SelectCommand.Parameters.Add(pES)
            DBCommand.SelectCommand.Parameters.Add(pEstado)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pSistema)
            DBCommand.SelectCommand.Parameters.Add(pTrasladado)
            DBCommand.SelectCommand.Parameters.Add(pValor)
            DBCommand.SelectCommand.Parameters.Add(pConcepto)
            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pDocumento)

            DBCommand.SelectCommand.Parameters.Add(pRazon)
            DBCommand.SelectCommand.Parameters.Add(pConciliado)
            DBCommand.SelectCommand.Parameters.Add(pEncontrado)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                DBConn.Close()
            End Try
        End Function



        Public Function Conciliaciones_Historial(ByVal Periodo As String, ByVal Banco As Integer, ByVal Cuenta As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand, DBC As SqlDataAdapter
            Dim ds As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListConciliacion_Bancaria", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empr_Codigo", SqlDbType.Int)
            Dim pPeriodo As New SqlParameter("@Per_Id", SqlDbType.Int)
            Dim pBanco As New SqlParameter("@cb_Banco", SqlDbType.Int)
            Dim pCuenta As New SqlParameter("@cb_Cuenta", SqlDbType.NVarChar)

            pEmpresa.Value = EmpresaActual
            pPeriodo.Value = Periodo
            pBanco.Value = Banco
            pCuenta.Value = Cuenta

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)
            DBCommand.SelectCommand.Parameters.Add(pBanco)
            DBCommand.SelectCommand.Parameters.Add(pCuenta)

            Try
                DBCommand.Fill(ds, "CB_E")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            DBC = New SqlDataAdapter("_GetListConciliacion_Bancaria_Detalle", DBConn)
            DBC.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pdEmpresa As New SqlParameter("@Empr_Codigo", SqlDbType.Int)
            Dim pdPeriodo As New SqlParameter("@Per_Id", SqlDbType.Int)
            Dim pdBanco As New SqlParameter("@cb_Banco", SqlDbType.Int)
            Dim pdCuenta As New SqlParameter("@cb_Cuenta", SqlDbType.NVarChar)

            pdEmpresa.Value = EmpresaActual
            pdPeriodo.Value = Periodo
            pdBanco.Value = Banco
            pdCuenta.Value = Cuenta

            DBC.SelectCommand.Parameters.Add(pdEmpresa)
            DBC.SelectCommand.Parameters.Add(pdPeriodo)
            DBC.SelectCommand.Parameters.Add(pdBanco)
            DBC.SelectCommand.Parameters.Add(pdCuenta)

            Try
                DBC.Fill(ds, "CB_D")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            DBConn.Close()
            Return ds

        End Function

        Public Function GetListConciliacion(ByVal Desde As Date, ByVal Hasta As Date, _
               ByVal lUsuario As String, ByVal Cuenta As String, ByRef DS As DataSet, ByVal Conciliado As String, _
               ByVal Banco As Integer)
            'ByVal Periodo As Integer,
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListConciliacionBancaria", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent5 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim PIdent7 As New SqlParameter("@Conciliado", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@Banco", SqlDbType.Int)

            pIdent1.Value = EmpresaActual
            'pIdent2.Value = Periodo
            pIdent3.Value = Desde
            pIdent4.Value = Hasta
            pIdent5.Value = lUsuario
            pIdent6.Value = Cuenta
            PIdent7.Value = Conciliado
            pIdent8.Value = Banco

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(PIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)

            Try
                'Se asigna conexion al comando y se abre conexion 

                DBCommand.Fill(DS, "LibroBancos")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function


        Public Function GetListConciliacion_Bancaria_Detalle_Filtro(ByVal Documento As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim Ficha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListConciliacion_Bancaria_Detalle_Filtro", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Documento", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent5.Value = Documento

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            Try
                'Se asigna conexion al comando y se abre conexion 

                DBCommand.Fill(Ficha, "CBD")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return Ficha
        End Function

        Public Shared Function CB_Nvo() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListConciliacionBancaria_Nvo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pCodigo As New SqlParameter("@Codigo", SqlDbType.NVarChar, 6)
            pCodigo.Direction = ParameterDirection.Output

            pEmpresa.Value = EmpresaActual


            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pCodigo)
            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            DBConn.Close()
            Return CType(pCodigo.Value, String)

        End Function

    End Class



End Namespace

