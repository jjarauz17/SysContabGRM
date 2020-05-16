Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DbConnect

Namespace VB.SysContab

    Public Class NivelDetailsDB
        Public Nivel As String
        Public Descripcion As String
        Public nLen As String
    End Class

    Public Class LibrosDB

        Public Function Imprimir_LibroBalanzaDinamico(ByVal Periodo As Integer, ByVal Periodo2 As Integer, ByVal Mes As Integer, _
                ByVal Mes2 As Integer, ByVal Ano As Integer, ByVal Ano2 As Integer, ByVal Cuenta As String, _
                    ByVal tCuenta As String, ByVal Nivel As String, _
                    ByVal MonedaBase As String, ByVal MonedaCambio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim DS As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("[_LibroBalanzaDinamico]", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Periodo2", SqlDbType.Int)
            Dim pIdent7 As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pIdent8 As New SqlParameter("@Mes2", SqlDbType.Int)
            Dim pIdent9 As New SqlParameter("@Ano", SqlDbType.Int)
            Dim pIdent10 As New SqlParameter("@Ano2", SqlDbType.Int)
            Dim pIdent11 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@TCuenta", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pident15 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)


            pIdent1.Value = EmpresaActual
            pIdent5.Value = Periodo
            pIdent6.Value = Periodo2
            pIdent7.Value = Mes
            pIdent8.Value = Mes2
            pIdent9.Value = Ano
            pIdent10.Value = Ano2
            pIdent11.Value = Cuenta
            pIdent12.Value = tCuenta
            pIdent13.Value = Nivel

            pident15.Value = MonedaBase
            pident16.Value = MonedaCambio


            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)

            DBCommand.SelectCommand.Parameters.Add(pident15)
            DBCommand.SelectCommand.Parameters.Add(pident16)

            Try
                'Se asigna conexion al comando y se abre conexion 

                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroBalanza")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return DS

        End Function

        Public Function LibroBalanzaCrostab(ByVal Desde As Date, ByVal Hasta As Date, ByVal MonedaCambio As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim DS As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroBalanzaCrossTab", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)


            pIdent1.Value = EmpresaActual
            pIdent6.Value = Desde
            pIdent7.Value = Hasta
            pident16.Value = MonedaCambio


            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pident16)


            DBCommand.SelectCommand.CommandTimeout = 0
            DBCommand.Fill(DS, "LibroBalanza")
            DBConn.Close()

            Return DS

        End Function

        Public Function Detalle_Apie(ByVal Desde As Date, _
               ByVal Hasta As Date, ByVal Periodo As Integer, _
               ByVal MonedaCambio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_getdetalleapie", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresad", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desded", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hastad", SqlDbType.SmallDateTime)
            Dim pIdent5 As New SqlParameter("@Periodod", SqlDbType.Int)
            Dim pIdent12 As New SqlParameter("@MonedaCambiod", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta
            pIdent5.Value = Periodo
            pIdent12.Value = MonedaCambio

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)

            DBCommand.SelectCommand.CommandTimeout = 0
            DBCommand.Fill(dsFicha, "DetalleApie")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function Detalle_Distribucion(ByVal Desde As Date, _
               ByVal Hasta As Date, ByVal MonedaCambio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DetalleDistribucion", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresad", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desded", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hastad", SqlDbType.SmallDateTime)
            Dim pIdent12 As New SqlParameter("@MonedaCambiod", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta
            pIdent12.Value = MonedaCambio

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            Try
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(dsFicha, "DetalleApie")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return dsFicha
        End Function

        Public Function Apie(ByVal Desde As Date, _
               ByVal Hasta As Date, ByVal Periodo As Integer, _
               ByVal MonedaCambio As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_apie", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent12 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta
            pIdent5.Value = Periodo
            pIdent12.Value = MonedaCambio

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)

            DBCommand.SelectCommand.CommandTimeout = 0
            DBCommand.Fill(dsFicha, "Apie")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function Imprimir_LibroDiario(ByVal Desde As Date, _
         ByVal Hasta As Date, ByVal Cuenta As String, ByVal Periodo As Integer, _
         ByVal TipoDocumento As String, ByVal DOCUMENTO As String, ByVal CHEQUE As String, _
         ByVal lUsuario As String, ByVal Titulo As String, ByVal MonedaBase As String, _
         ByVal MonedaCambio As String, ByVal Memoria As Boolean) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroDiario", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@TipoDocumento", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@DOCUMENTO", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@CHEQUE", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@Memoria", SqlDbType.Bit)



            pIdent1.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta
            pIdent4.Value = Cuenta
            pIdent5.Value = Periodo
            pIdent6.Value = TipoDocumento
            pIdent7.Value = DOCUMENTO
            pIdent8.Value = CHEQUE
            pIdent9.Value = lUsuario
            pIdent10.Value = Titulo
            pIdent11.Value = MonedaBase
            pIdent12.Value = MonedaCambio
            pIdent13.Value = Memoria


            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)

            DBCommand.SelectCommand.CommandTimeout = 0
            DBCommand.Fill(dsFicha, "LibroDiario")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function Imprimir_LibroDiario_V2(ByVal Desde As Date, _
                ByVal Hasta As Date, ByVal Cuenta As String, ByVal Periodo As Integer, _
                ByVal TipoDocumento As String, ByVal DOCUMENTO As String, ByVal CHEQUE As String, _
                ByVal lUsuario As String, ByVal Titulo As String, ByVal MonedaBase As String, _
                ByVal MonedaCambio As String, ByVal Memoria As Boolean) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroDiario_V2", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@TipoDocumento", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@DOCUMENTO", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@CHEQUE", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@Memoria", SqlDbType.Bit)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta
            pIdent4.Value = Cuenta
            pIdent5.Value = Periodo
            pIdent6.Value = TipoDocumento
            pIdent7.Value = DOCUMENTO
            pIdent8.Value = CHEQUE
            pIdent9.Value = lUsuario
            pIdent10.Value = Titulo
            pIdent11.Value = MonedaBase
            pIdent12.Value = MonedaCambio
            pIdent13.Value = Memoria

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)

            DBCommand.SelectCommand.CommandTimeout = 0
            DBCommand.Fill(dsFicha, "LibroDiario")
            DBConn.Close()

            Return dsFicha
        End Function

        Public Function Imprimir_LibroDiarioConsolidado_V2(ByVal Desde As Date, _
                ByVal Hasta As Date, _
                ByVal TipoDocumento As String, ByVal Cuenta As String, ByVal DOCUMENTO As String, ByVal CHEQUE As String, _
                ByVal lUsuario As String, ByVal Titulo As String, ByVal MonedaBase As String, _
                ByVal MonedaCambio As String, ByVal Concepto As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroDiarioConsolidado_V2", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@TipoDocumento", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@DOCUMENTO", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@CHEQUE", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@Concepto", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta
            pIdent4.Value = Cuenta
            pIdent6.Value = TipoDocumento
            pIdent7.Value = DOCUMENTO
            pIdent8.Value = CHEQUE
            pIdent9.Value = lUsuario
            pIdent10.Value = Titulo
            pIdent11.Value = MonedaBase
            pIdent12.Value = MonedaCambio
            pIdent13.Value = Concepto

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)

            DBCommand.SelectCommand.CommandTimeout = 0
            DBCommand.Fill(dsFicha, "LibroDiario")
            DBConn.Close()

            Return dsFicha
        End Function


        Public Function Imprimir_LibroAuxiliar(ByVal Desde As Date, _
                ByVal Hasta As Date, ByVal Cuenta As String, ByVal Periodo As Integer, _
                ByVal TipoDocumento As String, ByVal DOCUMENTO As String, _
                ByVal CHEQUE As String, ByVal lUsuario As String, ByVal Titulo As String, _
                ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal Memoria As Boolean, _
                ByVal NEmpresa As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroAuxiliar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@TipoDocumento", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@DOCUMENTO", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@CHEQUE", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@Memoria", SqlDbType.Bit)
            Dim pIdent14 As New SqlParameter("@NEmpresa", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta
            pIdent4.Value = Cuenta
            pIdent5.Value = Periodo
            pIdent6.Value = TipoDocumento
            pIdent7.Value = DOCUMENTO
            pIdent8.Value = CHEQUE
            pIdent9.Value = lUsuario
            pIdent10.Value = Titulo
            pIdent11.Value = MonedaBase
            pIdent12.Value = MonedaCambio
            pIdent13.Value = Memoria
            pIdent14.Value = NEmpresa

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)

            Try
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(dsFicha, "LibroAuxiliar")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return dsFicha
        End Function

        Public Function Imprimir_LibroAuxiliarV2(ByVal Desde As Date, _
               ByVal Hasta As Date, ByVal Cuenta As String, ByVal Nivel As String, _
               ByVal TipoDocumento As String, ByVal DOCUMENTO As String, ByVal CHEQUE As String, _
               ByVal lUsuario As String, ByVal Titulo As String, ByVal MonedaBase As String, _
               ByVal MonedaCambio As String, ByVal Memoria As Boolean, ByVal NEmpresa As String, _
                ByVal xGrupo As Boolean) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroAuxiliar_V2", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@TipoDocumento", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@DOCUMENTO", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@CHEQUE", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@Memoria", SqlDbType.Bit)
            Dim pIdent14 As New SqlParameter("@NEmpresa", SqlDbType.NVarChar)
            Dim pIdent15 As New SqlParameter("@xGrupo", SqlDbType.Bit)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta
            pIdent4.Value = Cuenta
            pIdent5.Value = Nivel
            pIdent6.Value = TipoDocumento
            pIdent7.Value = DOCUMENTO
            pIdent8.Value = CHEQUE
            pIdent9.Value = lUsuario
            pIdent10.Value = Titulo
            pIdent11.Value = MonedaBase
            pIdent12.Value = MonedaCambio
            pIdent13.Value = Memoria
            pIdent14.Value = NEmpresa
            pIdent15.Value = xGrupo

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pIdent15)

            Try
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(dsFicha, "LibroAuxiliar")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return dsFicha
        End Function

        Public Function Imprimir_LibroAuxiliar_Resumen(ByVal Desde As Date, _
               ByVal Hasta As Date, ByVal Cuenta As String, ByVal Periodo As Integer, _
               ByVal TipoDocumento As String, ByVal DOCUMENTO As String, ByVal CHEQUE As String, _
               ByVal lUsuario As String, ByVal Titulo As String, ByVal MonedaBase As String, _
               ByVal MonedaCambio As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroAuxiliar_Resumen", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@TipoDocumento", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@DOCUMENTO", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@CHEQUE", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta
            pIdent4.Value = Cuenta
            pIdent5.Value = Periodo
            pIdent6.Value = TipoDocumento
            pIdent7.Value = DOCUMENTO
            pIdent8.Value = CHEQUE
            pIdent9.Value = lUsuario
            pIdent10.Value = Titulo
            pIdent11.Value = MonedaBase
            pIdent12.Value = MonedaCambio

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)

            DBCommand.Fill(dsFicha, "LibroAuxiliar_Resumen")
            DBConn.Close()

            Return dsFicha
        End Function

        Public Function Imprimir_LibroAuxiliar_SaldoAnterior(ByVal Desde As Date, _
              ByVal Hasta As Date, ByVal Cuenta As String, ByVal Periodo As Integer, _
              ByVal MonedaBase As String, ByVal MonedaCambio As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroAuxiliar_SaldoAnterior", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta
            pIdent4.Value = Cuenta
            pIdent5.Value = Periodo
            pIdent6.Value = MonedaBase
            pIdent7.Value = MonedaCambio

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)

            Try
                'Se asigna conexion al comando y se abre conexion 

                DBCommand.Fill(dsFicha, "LibroAuxiliar")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Imprimir_LibroBalanza(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date,
                ByVal lUsuario As String, ByVal lTitulo As String, ByVal fTCuenta As String,
                    ByVal fCuenta As String, ByVal fNivel As String, ByVal Sincuenta As Boolean,
                    ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal Zeros As Boolean,
                    ByVal Grupo As String, ByVal nGrupo As String, ByVal Reporte As String,
                    ByVal fSAnterior As Boolean, ByRef DS As DataSet, ByVal Memoria As Boolean,
                    ByVal NEmpresa As String, ByVal Distribucion As String, ByVal DeOrden As String,
                    ByVal SAnterior As Integer, ByVal Movimientos As Integer, ByVal SActual As Integer)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroBalanza_v2", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent8 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@TCuenta", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pIdent14 As New SqlParameter("@SinCuenta", SqlDbType.Bit)
            Dim pident15 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pident17 As New SqlParameter("@Zeros", SqlDbType.Bit)
            Dim pident18 As New SqlParameter("@MLA", SqlDbType.Int)
            Dim pident19 As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim pident20 As New SqlParameter("@NGrupo", SqlDbType.NVarChar)
            Dim pident21 As New SqlParameter("@Reporte", SqlDbType.NVarChar)
            Dim pident22 As New SqlParameter("@fSAnterior", SqlDbType.Bit)
            Dim pident23 As New SqlParameter("@Memoria", SqlDbType.Bit)
            Dim pident24 As New SqlParameter("@NEmpresa", SqlDbType.NVarChar)
            Dim pident25 As New SqlParameter("@Distribucion", SqlDbType.NVarChar)
            Dim pident26 As New SqlParameter("@DeOrden", SqlDbType.NVarChar)
            Dim pident27 As New SqlParameter("@SA", SqlDbType.Int)
            Dim pident28 As New SqlParameter("@MO", SqlDbType.Int)
            Dim pident29 As New SqlParameter("@SAc", SqlDbType.Int)

            pIdent1.Value = EmpresaActual
            pIdent5.Value = Periodo
            pIdent6.Value = Desde
            pIdent7.Value = Hasta
            pIdent8.Value = lUsuario
            pIdent9.Value = lTitulo
            pIdent11.Value = fCuenta
            pIdent12.Value = fTCuenta
            pIdent13.Value = fNivel
            pIdent14.Value = Sincuenta
            pident15.Value = MonedaBase
            pident16.Value = MonedaCambio
            pident17.Value = Zeros
            pident18.Value = Me.MaxLenAuxiliar
            pident19.Value = Grupo
            pident20.Value = nGrupo
            pident21.Value = Reporte
            pident22.Value = fSAnterior
            pident23.Value = Memoria
            pident24.Value = NEmpresa
            pident25.Value = Distribucion
            pident26.Value = DeOrden
            pident27.Value = SAnterior
            pident28.Value = Movimientos
            pident29.Value = SActual

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pident15)
            DBCommand.SelectCommand.Parameters.Add(pident16)
            DBCommand.SelectCommand.Parameters.Add(pident17)
            DBCommand.SelectCommand.Parameters.Add(pident18)
            DBCommand.SelectCommand.Parameters.Add(pident19)
            DBCommand.SelectCommand.Parameters.Add(pident20)
            DBCommand.SelectCommand.Parameters.Add(pident21)
            DBCommand.SelectCommand.Parameters.Add(pident22)
            DBCommand.SelectCommand.Parameters.Add(pident23)
            DBCommand.SelectCommand.Parameters.Add(pident24)
            DBCommand.SelectCommand.Parameters.Add(pident25)
            DBCommand.SelectCommand.Parameters.Add(pident26)
            DBCommand.SelectCommand.Parameters.Add(pident27)
            DBCommand.SelectCommand.Parameters.Add(pident28)
            DBCommand.SelectCommand.Parameters.Add(pident29)

            Try
                'Se asigna conexion al comando y se abre conexion 

                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroBalanza")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return DS

        End Function

        Public Function Imprimir_LibroBalanza_Con_Cierre_Fiscal(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date,
                ByVal lUsuario As String, ByVal lTitulo As String, ByVal fTCuenta As String,
                    ByVal fCuenta As String, ByVal fNivel As String, ByVal Sincuenta As Boolean,
                    ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal Zeros As Boolean,
                    ByVal Grupo As String, ByVal nGrupo As String, ByVal Reporte As String,
                    ByVal fSAnterior As Boolean, ByRef DS As DataSet, ByVal Memoria As Boolean,
                    ByVal NEmpresa As String, ByVal Distribucion As String, ByVal DeOrden As String,
                    ByVal SAnterior As Integer, ByVal Movimientos As Integer, ByVal SActual As Integer)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroBalanza_V2_Con_Cierre_Fiscal", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent8 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@TCuenta", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pIdent14 As New SqlParameter("@SinCuenta", SqlDbType.Bit)
            Dim pident15 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pident17 As New SqlParameter("@Zeros", SqlDbType.Bit)
            Dim pident18 As New SqlParameter("@MLA", SqlDbType.Int)
            Dim pident19 As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim pident20 As New SqlParameter("@NGrupo", SqlDbType.NVarChar)
            Dim pident21 As New SqlParameter("@Reporte", SqlDbType.NVarChar)
            Dim pident22 As New SqlParameter("@fSAnterior", SqlDbType.Bit)
            Dim pident23 As New SqlParameter("@Memoria", SqlDbType.Bit)
            Dim pident24 As New SqlParameter("@NEmpresa", SqlDbType.NVarChar)
            Dim pident25 As New SqlParameter("@Distribucion", SqlDbType.NVarChar)
            Dim pident26 As New SqlParameter("@DeOrden", SqlDbType.NVarChar)
            Dim pident27 As New SqlParameter("@SA", SqlDbType.Int)
            Dim pident28 As New SqlParameter("@MO", SqlDbType.Int)
            Dim pident29 As New SqlParameter("@SAc", SqlDbType.Int)

            pIdent1.Value = EmpresaActual
            pIdent5.Value = Periodo
            pIdent6.Value = Desde
            pIdent7.Value = Hasta
            pIdent8.Value = lUsuario
            pIdent9.Value = lTitulo
            pIdent11.Value = fCuenta
            pIdent12.Value = fTCuenta
            pIdent13.Value = fNivel
            pIdent14.Value = Sincuenta
            pident15.Value = MonedaBase
            pident16.Value = MonedaCambio
            pident17.Value = Zeros
            pident18.Value = Me.MaxLenAuxiliar
            pident19.Value = Grupo
            pident20.Value = nGrupo
            pident21.Value = Reporte
            pident22.Value = fSAnterior
            pident23.Value = Memoria
            pident24.Value = NEmpresa
            pident25.Value = Distribucion
            pident26.Value = DeOrden
            pident27.Value = SAnterior
            pident28.Value = Movimientos
            pident29.Value = SActual

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pident15)
            DBCommand.SelectCommand.Parameters.Add(pident16)
            DBCommand.SelectCommand.Parameters.Add(pident17)
            DBCommand.SelectCommand.Parameters.Add(pident18)
            DBCommand.SelectCommand.Parameters.Add(pident19)
            DBCommand.SelectCommand.Parameters.Add(pident20)
            DBCommand.SelectCommand.Parameters.Add(pident21)
            DBCommand.SelectCommand.Parameters.Add(pident22)
            DBCommand.SelectCommand.Parameters.Add(pident23)
            DBCommand.SelectCommand.Parameters.Add(pident24)
            DBCommand.SelectCommand.Parameters.Add(pident25)
            DBCommand.SelectCommand.Parameters.Add(pident26)
            DBCommand.SelectCommand.Parameters.Add(pident27)
            DBCommand.SelectCommand.Parameters.Add(pident28)
            DBCommand.SelectCommand.Parameters.Add(pident29)

            Try
                'Se asigna conexion al comando y se abre conexion 

                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroBalanza")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return DS

        End Function

        Public Function Imprimir_LibroBalanzaSencilla(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
                ByVal lUsuario As String, ByVal lTitulo As String, ByVal fTCuenta As String, _
                    ByVal fCuenta As String, ByVal fNivel As String, ByVal Sincuenta As Boolean, _
                    ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal Zeros As Boolean, _
                    ByVal Grupo As String, ByVal nGrupo As String, ByVal Reporte As String, _
                    ByVal fSAnterior As Boolean, ByRef DS As DataSet, ByVal Memoria As Boolean, _
                    ByVal NEmpresa As String, ByVal Distribucion As String, ByVal DeOrden As String, _
                    ByVal SAnterior As Integer, ByVal Movimientos As Integer, ByVal SActual As Integer)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroBalanzaSencillo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent8 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@TCuenta", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pIdent14 As New SqlParameter("@SinCuenta", SqlDbType.Bit)
            Dim pident15 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pident17 As New SqlParameter("@Zeros", SqlDbType.Bit)
            Dim pident18 As New SqlParameter("@MLA", SqlDbType.Int)
            Dim pident19 As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim pident20 As New SqlParameter("@NGrupo", SqlDbType.NVarChar)
            Dim pident21 As New SqlParameter("@Reporte", SqlDbType.NVarChar)
            Dim pident22 As New SqlParameter("@fSAnterior", SqlDbType.Bit)
            Dim pident23 As New SqlParameter("@Memoria", SqlDbType.Bit)
            Dim pident24 As New SqlParameter("@NEmpresa", SqlDbType.NVarChar)
            Dim pident25 As New SqlParameter("@Distribucion", SqlDbType.NVarChar)
            Dim pident26 As New SqlParameter("@DeOrden", SqlDbType.NVarChar)
            Dim pident27 As New SqlParameter("@SA", SqlDbType.Int)
            Dim pident28 As New SqlParameter("@MO", SqlDbType.Int)
            Dim pident29 As New SqlParameter("@SAc", SqlDbType.Int)

            pIdent1.Value = EmpresaActual
            pIdent5.Value = Periodo
            pIdent6.Value = Desde
            pIdent7.Value = Hasta
            pIdent8.Value = lUsuario
            pIdent9.Value = lTitulo
            pIdent11.Value = fCuenta
            pIdent12.Value = fTCuenta
            pIdent13.Value = fNivel
            pIdent14.Value = Sincuenta
            pident15.Value = MonedaBase
            pident16.Value = MonedaCambio
            pident17.Value = Zeros
            pident18.Value = Me.MaxLenAuxiliar
            pident19.Value = Grupo
            pident20.Value = nGrupo
            pident21.Value = Reporte
            pident22.Value = fSAnterior
            pident23.Value = Memoria
            pident24.Value = NEmpresa
            pident25.Value = Distribucion
            pident26.Value = DeOrden
            pident27.Value = SAnterior
            pident28.Value = Movimientos
            pident29.Value = SActual

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pident15)
            DBCommand.SelectCommand.Parameters.Add(pident16)
            DBCommand.SelectCommand.Parameters.Add(pident17)
            DBCommand.SelectCommand.Parameters.Add(pident18)
            DBCommand.SelectCommand.Parameters.Add(pident19)
            DBCommand.SelectCommand.Parameters.Add(pident20)
            DBCommand.SelectCommand.Parameters.Add(pident21)
            DBCommand.SelectCommand.Parameters.Add(pident22)
            DBCommand.SelectCommand.Parameters.Add(pident23)
            DBCommand.SelectCommand.Parameters.Add(pident24)
            DBCommand.SelectCommand.Parameters.Add(pident25)
            DBCommand.SelectCommand.Parameters.Add(pident26)
            DBCommand.SelectCommand.Parameters.Add(pident27)
            DBCommand.SelectCommand.Parameters.Add(pident28)
            DBCommand.SelectCommand.Parameters.Add(pident29)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroBalanza")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return DS

        End Function
        'Public Function Imprimir_LibroBalanza(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
        '        ByVal lUsuario As String, ByVal lTitulo As String, ByVal lPresentar As String, ByVal fTCuenta As String, _
        '            ByVal fCuenta As String, ByVal fNivel As String, ByVal Sincuenta As Boolean, _
        '            ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal Zeros As Boolean, _
        '            ByVal Grupo As String, ByVal nGrupo As String, ByVal Reporte As String, _
        '            ByVal fSAnterior As Boolean, ByRef DS As DataSet, ByVal Memoria As Boolean, _
        '            ByVal NEmpresa As String, ByVal Distribucion As String, ByVal DeOrden As String, ByVal NivelAgrupacion As Boolean)
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_LibroBalanza_Agrupacion", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
        '    Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
        '    Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
        '    Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
        '    Dim pIdent8 As New SqlParameter("@User", SqlDbType.NVarChar)
        '    Dim pIdent9 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
        '    Dim pIdent10 As New SqlParameter("@Presentar", SqlDbType.NVarChar)
        '    Dim pIdent11 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
        '    Dim pIdent12 As New SqlParameter("@TCuenta", SqlDbType.NVarChar)
        '    Dim pIdent13 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
        '    Dim pIdent14 As New SqlParameter("@SinCuenta", SqlDbType.Bit)
        '    Dim pident15 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
        '    Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
        '    Dim pident17 As New SqlParameter("@Zeros", SqlDbType.Bit)
        '    Dim pident18 As New SqlParameter("@MLA", SqlDbType.Int)
        '    Dim pident19 As New SqlParameter("@Grupo", SqlDbType.NVarChar)
        '    Dim pident20 As New SqlParameter("@NGrupo", SqlDbType.NVarChar)
        '    Dim pident21 As New SqlParameter("@Reporte", SqlDbType.NVarChar)
        '    Dim pident22 As New SqlParameter("@fSAnterior", SqlDbType.Bit)
        '    Dim pident23 As New SqlParameter("@Memoria", SqlDbType.Bit)
        '    Dim pident24 As New SqlParameter("@NEmpresa", SqlDbType.NVarChar)
        '    Dim pident25 As New SqlParameter("@Distribucion", SqlDbType.NVarChar)
        '    Dim pident26 As New SqlParameter("@DeOrden", SqlDbType.NVarChar)

        '    pIdent1.Value = EmpresaActual
        '    pIdent5.Value = Periodo
        '    pIdent6.Value = Desde
        '    pIdent7.Value = Hasta
        '    pIdent8.Value = lUsuario
        '    pIdent9.Value = lTitulo
        '    pIdent10.Value = lPresentar
        '    pIdent11.Value = fCuenta
        '    pIdent12.Value = fTCuenta
        '    pIdent13.Value = fNivel
        '    pIdent14.Value = Sincuenta
        '    pident15.Value = MonedaBase
        '    pident16.Value = MonedaCambio
        '    pident17.Value = Zeros
        '    pident18.Value = Me.MaxLenAuxiliar
        '    pident19.Value = Grupo
        '    pident20.Value = nGrupo
        '    pident21.Value = Reporte
        '    pident22.Value = fSAnterior
        '    pident23.Value = Memoria
        '    pident24.Value = NEmpresa
        '    pident25.Value = Distribucion
        '    pident26.Value = DeOrden

        '    DBCommand.SelectCommand.Parameters.Add(pIdent1)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent5)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent6)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent7)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent8)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent9)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent10)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent11)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent12)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent13)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent14)
        '    DBCommand.SelectCommand.Parameters.Add(pident15)
        '    DBCommand.SelectCommand.Parameters.Add(pident16)
        '    DBCommand.SelectCommand.Parameters.Add(pident17)
        '    DBCommand.SelectCommand.Parameters.Add(pident18)
        '    DBCommand.SelectCommand.Parameters.Add(pident19)
        '    DBCommand.SelectCommand.Parameters.Add(pident20)
        '    DBCommand.SelectCommand.Parameters.Add(pident21)
        '    DBCommand.SelectCommand.Parameters.Add(pident22)
        '    DBCommand.SelectCommand.Parameters.Add(pident23)
        '    DBCommand.SelectCommand.Parameters.Add(pident24)
        '    DBCommand.SelectCommand.Parameters.Add(pident25)
        '    DBCommand.SelectCommand.Parameters.Add(pident26)

        '    Try
        '        'Se asigna conexion al comando y se abre conexion 

        '        DBCommand.Fill(DS, "LibroBalanza")
        '        DBConn.Close()

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        '    Return DS

        'End Function

        Public Function Imprimir_LibroEstadoSituacionMes(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
            ByVal lUsuario As String, ByVal lTitulo As String, ByVal fNivel As String, ByVal MonedaBase As String, _
            ByVal MonedaCambio As String, ByVal Zeros As Boolean, ByVal Grupo As String, _
            ByVal NGrupo As String, ByRef DS As DataSet)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroEstadoSituacionMes", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent5 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pident8 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pident9 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pident10 As New SqlParameter("@Zeros", SqlDbType.Bit)
            Dim pident11 As New SqlParameter("@MLA", SqlDbType.Int)
            Dim pident12 As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim pident13 As New SqlParameter("@NGrupo", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Periodo
            pIdent3.Value = Desde
            pIdent4.Value = Hasta
            pIdent5.Value = lUsuario
            pIdent6.Value = lTitulo
            pIdent7.Value = fNivel
            pident8.Value = MonedaBase
            pident9.Value = MonedaCambio
            pident10.Value = Zeros
            pident11.Value = Me.MaxLenAuxiliar
            pident12.Value = Grupo
            pident13.Value = NGrupo



            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pident8)
            DBCommand.SelectCommand.Parameters.Add(pident9)
            DBCommand.SelectCommand.Parameters.Add(pident10)
            DBCommand.SelectCommand.Parameters.Add(pident11)
            DBCommand.SelectCommand.Parameters.Add(pident12)
            DBCommand.SelectCommand.Parameters.Add(pident13)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroEstadoSituacionMes")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

        Public Function Imprimir_LibroEstadoSituacionQuarter(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
            ByVal lUsuario As String, ByVal lTitulo As String, ByVal fNivel As String, ByVal MonedaBase As String, _
            ByVal MonedaCambio As String, ByVal Zeros As Boolean, ByVal Grupo As String, _
            ByVal NGrupo As String, ByRef DS As DataSet)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroEstadoSituacionQuarter", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent5 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pident8 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pident9 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pident10 As New SqlParameter("@Zeros", SqlDbType.Bit)
            Dim pident11 As New SqlParameter("@MLA", SqlDbType.Int)
            Dim pident12 As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim pident13 As New SqlParameter("@NGrupo", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Periodo
            pIdent3.Value = Desde
            pIdent4.Value = Hasta
            pIdent5.Value = lUsuario
            pIdent6.Value = lTitulo
            pIdent7.Value = fNivel
            pident8.Value = MonedaBase
            pident9.Value = MonedaCambio
            pident10.Value = Zeros
            pident11.Value = Me.MaxLenAuxiliar
            pident12.Value = Grupo
            pident13.Value = NGrupo



            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pident8)
            DBCommand.SelectCommand.Parameters.Add(pident9)
            DBCommand.SelectCommand.Parameters.Add(pident10)
            DBCommand.SelectCommand.Parameters.Add(pident11)
            DBCommand.SelectCommand.Parameters.Add(pident12)
            DBCommand.SelectCommand.Parameters.Add(pident13)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroEstadoSituacionMes")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function


        Public Function Imprimir_LibroEstadoSituacionSem(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
            ByVal lUsuario As String, ByVal lTitulo As String, ByVal fNivel As String, ByVal MonedaBase As String, _
            ByVal MonedaCambio As String, ByVal Zeros As Boolean, ByVal Grupo As String, _
            ByVal NGrupo As String, ByRef DS As DataSet)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroEstadoSituacionSem", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent5 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pident8 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pident9 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pident10 As New SqlParameter("@Zeros", SqlDbType.Bit)
            Dim pident11 As New SqlParameter("@MLA", SqlDbType.Int)
            Dim pident12 As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim pident13 As New SqlParameter("@NGrupo", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Periodo
            pIdent3.Value = Desde
            pIdent4.Value = Hasta
            pIdent5.Value = lUsuario
            pIdent6.Value = lTitulo
            pIdent7.Value = fNivel
            pident8.Value = MonedaBase
            pident9.Value = MonedaCambio
            pident10.Value = Zeros
            pident11.Value = Me.MaxLenAuxiliar
            pident12.Value = Grupo
            pident13.Value = NGrupo



            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pident8)
            DBCommand.SelectCommand.Parameters.Add(pident9)
            DBCommand.SelectCommand.Parameters.Add(pident10)
            DBCommand.SelectCommand.Parameters.Add(pident11)
            DBCommand.SelectCommand.Parameters.Add(pident12)
            DBCommand.SelectCommand.Parameters.Add(pident13)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroEstadoSituacionMes")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function


        Public Function Imprimir_LibroBalanzaMes(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
        ByVal lUsuario As String, ByVal lTitulo As String, ByVal lPresentar As String, ByVal fTCuenta As String, _
            ByVal fCuenta As String, ByVal fNivel As String, ByVal Sincuenta As Boolean, _
            ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal Zeros As Boolean, ByRef DS As DataSet)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroBalanzaMes", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent8 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Presentar", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@TCuenta", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pIdent14 As New SqlParameter("@SinCuenta", SqlDbType.Bit)
            Dim pident15 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pident17 As New SqlParameter("@Zeros", SqlDbType.Bit)

            pIdent1.Value = EmpresaActual
            pIdent5.Value = Periodo
            pIdent6.Value = Desde
            pIdent7.Value = Hasta
            pIdent8.Value = lUsuario
            pIdent9.Value = lTitulo
            pIdent10.Value = lPresentar
            pIdent11.Value = fCuenta
            pIdent12.Value = fTCuenta
            pIdent13.Value = fNivel
            pIdent14.Value = Sincuenta
            pident15.Value = MonedaBase
            pident16.Value = MonedaCambio
            pident17.Value = Zeros


            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pident15)
            DBCommand.SelectCommand.Parameters.Add(pident16)
            DBCommand.SelectCommand.Parameters.Add(pident17)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroBalanza")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function
        Public Function Imprimir_LibroBalanzaQuarter(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
                ByVal lUsuario As String, ByVal lTitulo As String, ByVal lPresentar As String, ByVal fTCuenta As String, _
                    ByVal fCuenta As String, ByVal fNivel As String, ByVal Sincuenta As Boolean, _
                    ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal Zeros As Boolean, ByRef DS As DataSet)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroBalanzaQuarter", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent8 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Presentar", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@TCuenta", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pIdent14 As New SqlParameter("@SinCuenta", SqlDbType.Bit)
            Dim pident15 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pident17 As New SqlParameter("@Zeros", SqlDbType.Bit)

            pIdent1.Value = EmpresaActual
            pIdent5.Value = Periodo
            pIdent6.Value = Desde
            pIdent7.Value = Hasta
            pIdent8.Value = lUsuario
            pIdent9.Value = lTitulo
            pIdent10.Value = lPresentar
            pIdent11.Value = fCuenta
            pIdent12.Value = fTCuenta
            pIdent13.Value = fNivel
            pIdent14.Value = Sincuenta
            pident15.Value = MonedaBase
            pident16.Value = MonedaCambio
            pident17.Value = Zeros


            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pident15)
            DBCommand.SelectCommand.Parameters.Add(pident16)
            DBCommand.SelectCommand.Parameters.Add(pident17)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroBalanza")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

        Public Function Imprimir_LibroBalanzaSem(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
        ByVal lUsuario As String, ByVal lTitulo As String, ByVal lPresentar As String, ByVal fTCuenta As String, _
            ByVal fCuenta As String, ByVal fNivel As String, ByVal Sincuenta As Boolean, _
            ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal Zeros As Boolean, ByRef DS As DataSet)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroBalanzaSem", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent8 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Presentar", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@TCuenta", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pIdent14 As New SqlParameter("@SinCuenta", SqlDbType.Bit)
            Dim pident15 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pident17 As New SqlParameter("@Zeros", SqlDbType.Bit)

            pIdent1.Value = EmpresaActual
            pIdent5.Value = Periodo
            pIdent6.Value = Desde
            pIdent7.Value = Hasta
            pIdent8.Value = lUsuario
            pIdent9.Value = lTitulo
            pIdent10.Value = lPresentar
            pIdent11.Value = fCuenta
            pIdent12.Value = fTCuenta
            pIdent13.Value = fNivel
            pIdent14.Value = Sincuenta
            pident15.Value = MonedaBase
            pident16.Value = MonedaCambio
            pident17.Value = Zeros


            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(pIdent11)
            DBCommand.SelectCommand.Parameters.Add(pIdent12)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pIdent14)
            DBCommand.SelectCommand.Parameters.Add(pident15)
            DBCommand.SelectCommand.Parameters.Add(pident16)
            DBCommand.SelectCommand.Parameters.Add(pident17)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroBalanza")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

        'Public Function Imprimir_LibroBalanza(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
        '       ByVal lUsuario As String, ByVal lTitulo As String, ByVal lPresentar As String, ByVal fTCuenta As String, _
        '           ByVal fCuenta As String, ByVal fNivel As String, ByVal Sincuenta As Boolean, _
        '           ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal Zeros As Boolean, ByRef DS As DataSet)
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter

        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_LibroBalanza", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


        '    Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
        '    Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
        '    Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
        '    Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
        '    Dim pIdent8 As New SqlParameter("@User", SqlDbType.NVarChar)
        '    Dim pIdent9 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
        '    Dim pIdent10 As New SqlParameter("@Presentar", SqlDbType.NVarChar)
        '    Dim pIdent11 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
        '    Dim pIdent12 As New SqlParameter("@TCuenta", SqlDbType.NVarChar)
        '    Dim pIdent13 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
        '    Dim pIdent14 As New SqlParameter("@SinCuenta", SqlDbType.Bit)
        '    Dim pident15 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
        '    Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
        '    Dim pident17 As New SqlParameter("@Zeros", SqlDbType.Bit)

        '    pIdent1.Value = EmpresaActual
        '    pIdent5.Value = Periodo
        '    pIdent6.Value = Desde
        '    pIdent7.Value = Hasta
        '    pIdent8.Value = lUsuario
        '    pIdent9.Value = lTitulo
        '    pIdent10.Value = lPresentar
        '    pIdent11.Value = fCuenta
        '    pIdent12.Value = fTCuenta
        '    pIdent13.Value = fNivel
        '    pIdent14.Value = Sincuenta
        '    pident15.Value = MonedaBase
        '    pident16.Value = MonedaCambio
        '    pident17.Value = Zeros


        '    DBCommand.SelectCommand.Parameters.Add(pIdent1)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent5)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent6)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent7)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent8)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent9)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent10)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent11)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent12)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent13)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent14)
        '    DBCommand.SelectCommand.Parameters.Add(pident15)
        '    DBCommand.SelectCommand.Parameters.Add(pident16)
        '    DBCommand.SelectCommand.Parameters.Add(pident17)

        '    Try
        '        'Se asigna conexion al comando y se abre conexion 

        '        DBCommand.Fill(DS, "LibroBalanza")
        '        DBConn.Close()

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        'End Function

        'Public Function Imprimir_LibroBalanza2(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
        '       ByVal lUsuario As String, ByVal lTitulo As String, ByVal lPresentar As String, ByVal fTCuenta As String, _
        '           ByVal fCuenta As String, ByVal fNivel As String, ByVal Sincuenta As Boolean, _
        '           ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal Zeros As Boolean, ByRef DS As DataSet)
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter

        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_LibroBalanza2", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


        '    Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
        '    Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
        '    Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
        '    Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
        '    Dim pIdent8 As New SqlParameter("@User", SqlDbType.NVarChar)
        '    Dim pIdent9 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
        '    Dim pIdent10 As New SqlParameter("@Presentar", SqlDbType.NVarChar)
        '    Dim pIdent11 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
        '    Dim pIdent12 As New SqlParameter("@TCuenta", SqlDbType.NVarChar)
        '    Dim pIdent13 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
        '    Dim pIdent14 As New SqlParameter("@SinCuenta", SqlDbType.Bit)
        '    Dim pident15 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
        '    Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
        '    Dim pident17 As New SqlParameter("@Zeros", SqlDbType.Bit)

        '    pIdent1.Value = EmpresaActual
        '    pIdent5.Value = Periodo
        '    pIdent6.Value = Desde
        '    pIdent7.Value = Hasta
        '    pIdent8.Value = lUsuario
        '    pIdent9.Value = lTitulo
        '    pIdent10.Value = lPresentar
        '    pIdent11.Value = fCuenta
        '    pIdent12.Value = fTCuenta
        '    pIdent13.Value = fNivel
        '    pIdent14.Value = Sincuenta
        '    pident15.Value = MonedaBase
        '    pident16.Value = MonedaCambio
        '    pident17.Value = Zeros


        '    DBCommand.SelectCommand.Parameters.Add(pIdent1)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent5)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent6)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent7)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent8)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent9)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent10)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent11)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent12)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent13)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent14)
        '    DBCommand.SelectCommand.Parameters.Add(pident15)
        '    DBCommand.SelectCommand.Parameters.Add(pident16)
        '    DBCommand.SelectCommand.Parameters.Add(pident17)

        '    Try
        '        'Se asigna conexion al comando y se abre conexion 

        '        DBCommand.Fill(DS, "LibroBalanza")
        '        DBConn.Close()

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        'End Function
        'Public Function Imprimir_LibroDetalleBalanza(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
        '   ByRef DS As DataSet, ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal NombreTabla As String)
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter

        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_LibroDetalleBalanza", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
        '    Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
        '    Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
        '    Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
        '    Dim pIdent8 As New SqlParameter("@Monedabase", SqlDbType.NVarChar)
        '    Dim pIdent9 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)

        '    pIdent1.Value = EmpresaActual
        '    pIdent5.Value = Periodo
        '    pIdent6.Value = Desde
        '    pIdent7.Value = Hasta
        '    pIdent8.Value = MonedaBase
        '    pIdent9.Value = MonedaCambio


        '    DBCommand.SelectCommand.Parameters.Add(pIdent1)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent5)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent6)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent7)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent8)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent9)


        '    Try
        '        'Se asigna conexion al comando y se abre conexion 

        '        DBCommand.Fill(DS, NombreTabla)
        '        DBConn.Close()

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        'End Function

        'Public Function Imprimir_LibroDetalleBalanza_Detail(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
        '   ByRef DS As DataSet, ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal NombreTabla As String, ByVal Raiz As String, _
        '   ByVal Nombre As String, ByVal SaldoAnterior As String, ByVal Nivel As String, ByVal balres As String)

        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter

        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_LibroDetalleBalanza_Detail", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
        '    Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
        '    Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
        '    Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
        '    Dim pIdent8 As New SqlParameter("@Monedabase", SqlDbType.NVarChar)
        '    Dim pIdent9 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
        '    Dim pident10 As New SqlParameter("@Raiz", SqlDbType.NVarChar)
        '    Dim pident11 As New SqlParameter("@Nombre", SqlDbType.NVarChar)
        '    Dim pident12 As New SqlParameter("@SaldoAnterior", SqlDbType.Float)
        '    Dim pident13 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
        '    Dim pident14 As New SqlParameter("@Balres", SqlDbType.NVarChar)

        '    pIdent1.Value = EmpresaActual
        '    pIdent5.Value = Periodo
        '    pIdent6.Value = Desde
        '    pIdent7.Value = Hasta
        '    pIdent8.Value = MonedaBase
        '    pIdent9.Value = MonedaCambio
        '    pident10.Value = Raiz
        '    pident11.Value = Nombre
        '    pident12.Value = SaldoAnterior
        '    pident13.Value = Nivel
        '    pident14.Value = balres

        '    DBCommand.SelectCommand.Parameters.Add(pIdent1)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent5)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent6)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent7)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent8)
        '    DBCommand.SelectCommand.Parameters.Add(pIdent9)
        '    DBCommand.SelectCommand.Parameters.Add(pident10)
        '    DBCommand.SelectCommand.Parameters.Add(pident11)
        '    DBCommand.SelectCommand.Parameters.Add(pident12)
        '    DBCommand.SelectCommand.Parameters.Add(pident13)
        '    DBCommand.SelectCommand.Parameters.Add(pident14)


        '    Try
        '        'Se asigna conexion al comando y se abre conexion 

        '        DBCommand.Fill(DS, NombreTabla)
        '        DBConn.Close()

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        'End Function

        Public Function Nivel_Detail(ByVal Nivel As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim Detalle As New VB.SysContab.NivelDetailsDB
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListNivelDetails", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            pIdent1.Value = EmpresaActual
            pIdent2.Value = Nivel


            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(dsFicha, "DetalleNivel")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If dsFicha.Tables("DetalleNivel").Rows.Count = 1 Then
                Detalle.Nivel = dsFicha.Tables("DetalleNivel").Rows(0)("Nivel")
                Detalle.Descripcion = dsFicha.Tables("DetalleNivel").Rows(0)("Descripcion")
                Detalle.nLen = dsFicha.Tables("DetalleNivel").Rows(0)("nLen")
            End If
            Return Detalle

        End Function

        Public Function Niveles() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListNiveles", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent1.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent1)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(dsFicha, "Niveles")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Grupos(ByVal Nivel As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListNivelGrupo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Nivel
            pIdent3.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(dsFicha, "Grupos")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function GruposCTA(ByVal MGRUPO As String, ByVal Tipo As String) As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListNivelGrupoCTA", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@MGRUPO", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = MGRUPO
            pIdent3.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(dsFicha, "Grupos")
                DBConn.Close()
                If dsFicha.Tables("Grupos").Rows.Count = 1 Then
                    Return dsFicha.Tables("Grupos").Rows(0)("CTA")
                Else
                    Return "X"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function NivelesGrupos(ByVal Grupo As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListNivelesGrupo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Grupo
            pIdent3.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(dsFicha, "NivelesGrupos")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function Imprimir_LibroEstadoSituacion(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
                        ByVal lUsuario As String, ByVal lTitulo As String, _
                        ByVal fNivelGrupo As String, ByVal fSaldoAnterior As Boolean, _
                        ByVal MonedaBase As String, ByVal MonedaCambio As String, ByRef DS As DataSet)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroEstadoSituacion", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent8 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@NivelGrupo", SqlDbType.NVarChar)
            Dim Pident11 As New SqlParameter("@FSaldoAnterior", SqlDbType.Bit)
            Dim Pident12 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim Pident13 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent5.Value = Periodo
            pIdent6.Value = Desde
            pIdent7.Value = Hasta
            pIdent8.Value = lUsuario
            pIdent9.Value = lTitulo
            pIdent10.Value = fNivelGrupo
            Pident11.Value = fSaldoAnterior
            Pident12.Value = MonedaBase
            Pident13.Value = MonedaCambio

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(Pident11)
            DBCommand.SelectCommand.Parameters.Add(Pident12)
            DBCommand.SelectCommand.Parameters.Add(Pident13)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroEstadoSituacion")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function
        Public Function Imprimir_LibroEstadoSituacionNuevo(ByVal dbconn As SqlConnection, ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
                ByVal lUsuario As String, ByVal lTitulo As String, ByVal fSanterior As Boolean, _
                    ByVal fNivel As String, ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal Zeros As Boolean, _
                    ByVal Grupo As String, ByVal NGrupo As String, ByVal BR As String, ByRef DS As DataSet)
            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroEstadoSituacionNew", dbconn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent8 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pident15 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pident17 As New SqlParameter("@Zeros", SqlDbType.Bit)
            Dim pident18 As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim pident19 As New SqlParameter("@NGrupo", SqlDbType.NVarChar)
            Dim pident20 As New SqlParameter("@MLA", SqlDbType.Int)
            Dim pident21 As New SqlParameter("@fSaldoAnterior", SqlDbType.Bit)
            Dim pident22 As New SqlParameter("@BR", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent5.Value = Periodo
            pIdent6.Value = Desde
            pIdent7.Value = Hasta
            pIdent8.Value = lUsuario
            pIdent9.Value = lTitulo
            pIdent13.Value = fNivel
            pident15.Value = MonedaBase
            pident16.Value = MonedaCambio
            pident17.Value = Zeros
            pident18.Value = Grupo
            pident19.Value = NGrupo
            pident20.Value = Me.MaxLenAuxiliar()
            pident21.Value = fSanterior
            pident22.Value = BR


            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent13)
            DBCommand.SelectCommand.Parameters.Add(pident15)
            DBCommand.SelectCommand.Parameters.Add(pident16)
            DBCommand.SelectCommand.Parameters.Add(pident17)
            DBCommand.SelectCommand.Parameters.Add(pident18)
            DBCommand.SelectCommand.Parameters.Add(pident19)
            DBCommand.SelectCommand.Parameters.Add(pident20)
            DBCommand.SelectCommand.Parameters.Add(pident21)
            DBCommand.SelectCommand.Parameters.Add(pident22)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroEstadoSituacion")
                ' DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function
        Public Function Imprimir_LibroEstadoSituacionT(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
                       ByVal lUsuario As String, ByVal lTitulo As String, _
                       ByVal fNivelGrupo As String, ByVal fSaldoAnterior As Boolean, _
                       ByVal MonedaBase As String, ByVal MonedaCambio As String, ByRef DS As DataSet)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroEstadoSituacionT", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent8 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent9 As New SqlParameter("@Titulo", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@NivelGrupo", SqlDbType.NVarChar)
            Dim Pident11 As New SqlParameter("@FSaldoAnterior", SqlDbType.Bit)
            Dim Pident12 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim Pident13 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)



            pIdent1.Value = EmpresaActual
            pIdent5.Value = Periodo
            pIdent6.Value = Desde
            pIdent7.Value = Hasta
            pIdent8.Value = lUsuario
            pIdent9.Value = lTitulo
            pIdent10.Value = fNivelGrupo
            Pident11.Value = fSaldoAnterior
            Pident12.Value = MonedaBase
            Pident13.Value = MonedaCambio

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            DBCommand.SelectCommand.Parameters.Add(Pident11)
            DBCommand.SelectCommand.Parameters.Add(Pident12)
            DBCommand.SelectCommand.Parameters.Add(Pident13)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroEstadoSituacionT")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function
        Public Function MaxLenAuxiliar() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListLenAuxiliar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent1.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent1)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(dsFicha, "MaxLenAuxiliar")
                DBConn.Close()
                If dsFicha.Tables("MaxLenAuxiliar").Rows.Count = 1 Then
                    Return dsFicha.Tables("MaxLenAuxiliar").Rows(0)("longAuxiliar")
                Else
                    Return -1
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function Catalogo()
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCatalogoNombre", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent1.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent1)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(dsFicha, "Catalogo")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function
        Public Function Imprimir_LibroBancos(ByVal Periodo As Integer, ByVal Desde As Date, ByVal Hasta As Date, _
               ByVal lUsuario As String, ByVal Cuenta As String, ByRef DS As DataSet, ByVal Conciliado As String, ByVal MonedaBase As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroBancos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent5 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim PIdent7 As New SqlParameter("@Conciliado", SqlDbType.NVarChar)

            Dim _Memoria As New SqlParameter("@Memoria", SqlDbType.NVarChar)
            Dim _NEmpresa As New SqlParameter("@NEmpresa", SqlDbType.NVarChar)
            Dim _NBanco As New SqlParameter("@NBanco", SqlDbType.NVarChar)
            Dim _NMonedaBase As New SqlParameter("@NMonedaBase", SqlDbType.NVarChar)

            _Memoria.Value = False
            _NEmpresa.Value = ""
            _NBanco.Value = ""
            _NMonedaBase.Value = MonedaBase

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Periodo
            pIdent3.Value = Desde
            pIdent4.Value = Hasta
            pIdent5.Value = lUsuario
            pIdent6.Value = Cuenta
            PIdent7.Value = Conciliado

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(PIdent7)

            DBCommand.SelectCommand.Parameters.Add(_Memoria)
            DBCommand.SelectCommand.Parameters.Add(_NEmpresa)
            DBCommand.SelectCommand.Parameters.Add(_NBanco)
            DBCommand.SelectCommand.Parameters.Add(_NMonedaBase)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroBancos")
                DBConn.Close()

            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
            End Try

        End Function

        Public Function Imprimir_LibroBancos(ByVal Desde As Date, ByVal Hasta As Date,
               ByVal lUsuario As String, ByVal Cuenta As String, ByRef DS As DataSet,
               ByVal MonedaCambio As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_LibroBancos_v2", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent5 As New SqlParameter("@User", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim PIdent7 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim _Memoria As New SqlParameter("@Memoria", SqlDbType.NVarChar)


            _Memoria.Value = False

            pIdent1.Value = EmpresaActual
            pIdent3.Value = Desde
            pIdent4.Value = Hasta
            pIdent5.Value = lUsuario
            pIdent6.Value = Cuenta
            PIdent7.Value = MonedaCambio

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(PIdent7)

            DBCommand.SelectCommand.Parameters.Add(_Memoria)

            Try
                'Se asigna conexion al comando y se abre conexion 

                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(DS, "LibroBancos")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

        Public Shared Function LibroBancoAuxiliar(ByVal Desde As Date, ByVal Hasta As Date,
               ByVal Cuenta As String, ByVal MonedaCambio As String) As DataTable

            Return ObtieneDatos("sp_LibroBancosAuxiliar",
                                EmpresaActual,
                                Desde,
                                Hasta,
                                Cuenta,
                                MonedaCambio)

        End Function


        Public Function Imprimir_FlujoCaja(ByVal Desde As Date, _
       ByVal Hasta As Date, ByVal Periodo As Integer, _
       ByVal MonedaCambio As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetFlujoCaja", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent3 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Moneda", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta
            pIdent4.Value = Periodo
            pIdent5.Value = MonedaCambio

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            Try
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(dsFicha, "FlujoCaja")
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return dsFicha
        End Function

        Public Shared Function GetFirmasContables() As DataTable
            Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)

            v.AddParameter("empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("_GetFirmasLibrosContables", "FirmasContables")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
            v = Nothing
        End Function

        Public Shared Sub FirmasContables(ByVal Cargo As String, ByVal Nombre As String, ByVal Orden As Integer, _
                                          ByVal Id As Integer)

            Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Cargo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Cargo)
            v.AddParameter("Nombre", SqlDbType.NVarChar, 50, ParameterDirection.Input, Nombre)
            v.AddParameter("Orden", SqlDbType.Int, 5, ParameterDirection.Input, Orden)
            v.AddParameter("Id", SqlDbType.Int, 5, ParameterDirection.Input, Id)

            Try
                v.EjecutarComando("_FirmasContables_AddUpdate")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub FirmasContables(ByVal ID As Integer)
            Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, ID)

            Try
                v.EjecutarComando("_FirmasContables_Delete")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Function FirmasContables() As DataTable
            Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("_FirmasContables_List", "Lista")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return New DataTable
            End Try

        End Function


        Public Shared Function ReporteEstadoSituacion_JAR(Desde As Date, Hasta As Date, Moneda As String) As DataTable

            Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
            v.AddParameter("Desde", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Desde)
            v.AddParameter("Hasta", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Hasta)
            v.AddParameter("MonedaCambio", SqlDbType.Int, 5, ParameterDirection.Input, Moneda)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

            Try
                Return v.EjecutarComando("JAR_ReporteEstadoResultadoGeneral")
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try

        End Function

        Public Shared Function Libro_Auxiliar_DX(Desde As Date, Hasta As Date, Moneda As String, Cuenta As String) As DataTable

            Dim conn As New Connect(VB.SysContab.Rutinas.AbrirConexion)
            conn.AddParameter("empresa", SqlDbType.NVarChar, 50, ParameterDirection.Input, EmpresaActual)
            conn.AddParameter("desde", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Desde)
            conn.AddParameter("hasta", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Hasta)
            conn.AddParameter("moneda", SqlDbType.NVarChar, 5, ParameterDirection.Input, Moneda)
            conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, Cuenta)

            Try
                Return conn.EjecutarComando("JAR_LibroAuxiliar", "Tabla")
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try

        End Function

        Public Shared Function Libro_Auxiliar_DX2(Desde As Date, Hasta As Date, Moneda As String, Cuenta As String) As DataTable

            Dim conn As New Connect(VB.SysContab.Rutinas.AbrirConexion)
            conn.AddParameter("empresa", SqlDbType.NVarChar, 50, ParameterDirection.Input, EmpresaActual)
            conn.AddParameter("desde", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Desde)
            conn.AddParameter("hasta", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Hasta)
            conn.AddParameter("moneda", SqlDbType.NVarChar, 5, ParameterDirection.Input, Moneda)
            conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, Cuenta)

            Try
                Return conn.EjecutarComando("JAR_LibroAuxiliarDetalle", "Tabla")
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try

        End Function

        Public Shared Function Mayor_Auxiliar_Detalle(Desde As Date, Hasta As Date, Moneda As String, Cuenta As String) As DataTable

            Dim conn As New Connect(VB.SysContab.Rutinas.AbrirConexion)
            conn.AddParameter("Empresa", SqlDbType.NVarChar, 50, ParameterDirection.Input, EmpresaActual)
            conn.AddParameter("Desde", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Desde)
            conn.AddParameter("Hasta", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, Hasta)
            conn.AddParameter("Moneda", SqlDbType.NVarChar, 5, ParameterDirection.Input, Moneda)
            conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, Cuenta)

            Try
                Return conn.EjecutarComando("JAR_LibroAuxiliarDetalle_V2", "Tabla")
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try

        End Function

    End Class


End Namespace