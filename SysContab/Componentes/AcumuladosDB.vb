Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class AcumuladosDB


        Public Function GetList(ByVal Codigo As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT NOMBRE_MES AS MES, SUM(MONTO) AS MONTO, MES AS NUMERO_MES FROM ACUMULADOS WHERE CODIGO_CP ='" & Codigo & "' AND TIPO = '" & Tipo & "' AND EMPRESA = '" & EmpresaActual & "' GROUP BY CODIGO_CP, NOMBRE_MES, MES ORDER BY MES", DBConn)
            DBCommand = New SqlDataAdapter("SELECT MESES.MES, SUM(ACUMULADOS.MONTO) AS MONTO FROM MESES LEFT OUTER JOIN ACUMULADOS ON MESES.MES = ACUMULADOS.NOMBRE_MES AND ACUMULADOS.TIPO = '" & Tipo & "' AND CODIGO_CP = '" & Codigo & " ' GROUP BY MESES.MES, MESES.NUMERO", DBConn)
            DBCommand.Fill(dsFicha, "ACUMULADOS")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Function GetListMesCero(ByVal Codigo As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT MES, MONTO FROM MESES WHERE MES NOT IN (SELECT NOMBRE_MES FROM ACUMULADOS WHERE TIPO ='P')", DBConn)
            DBCommand.Fill(dsFicha, "MESES")

            DBConn.Close()

            Return dsFicha

        End Function


    End Class

End Namespace
