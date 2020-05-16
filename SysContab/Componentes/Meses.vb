Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class MesesDB

        Public Shared Function MesexPeriodo() As DataSet

            Dim ds As New DataSet()
            Dim myDataSet As DataSet
            Dim j As Integer
            Dim newRow1 As DataRow
            Dim tCust As DataTable

            myDataSet = New DataSet("myDataSet")

            ' Create two DataTables.
            'Dim tCust As DataTable
            tCust = New DataTable("Meses")

            ' Create two columns, and add them to the first table.

            Dim cMes As DataColumn
            cMes = New DataColumn("Mes")
            tCust.Columns.Add(cMes)

            Dim cAnno As DataColumn
            cAnno = New DataColumn("Anno")
            tCust.Columns.Add(cAnno)

            Dim cMesAnno As DataColumn
            cMesAnno = New DataColumn("MesAnno")
            tCust.Columns.Add(cMesAnno)

            Dim cFecha As DataColumn
            cFecha = New DataColumn("Fecha")
            tCust.Columns.Add(cFecha)

            'tCust.Columns.Add(cCurrent2)
            ' Add the tables to the DataSet.

            Dim FechaControl As DateTime = PeriodosDB.GetDetails(PeriodosDB.Actual).Inicio

            j = 0

            'newRow1 = tCust.NewRow
            'tCust.Rows.Add(newRow1)
            'tCust.Rows(j)("Fecha") = 1 & "/" & 1 & "/" & 1900
            'tCust.Rows(j)("Mes") = 0
            'tCust.Rows(j)("MesAnno") = "-- Seleccione --"

            'j = j + 1


            While FechaControl < PeriodosDB.GetDetails(PeriodosDB.Actual).Final

                newRow1 = tCust.NewRow
                newRow1("Mes") = 1
                ' Add the row to the Customers table.
                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("Fecha") = New Date(Year(FechaControl), Month(FechaControl), 1)
                tCust.Rows(j)("Mes") = Month(FechaControl)
                tCust.Rows(j)("MesAnno") = NombreMes(Month(FechaControl)) & "-" & Year(FechaControl)

                j = j + 1

                FechaControl = FechaControl.AddMonths(1)

            End While

            myDataSet.Tables.Add(tCust)


            Return myDataSet


        End Function


        Public Shared Function NombreMes(ByVal Mes As Integer) As String

            If Mes = 1 Then
                Return "Enero"
            End If

            If Mes = 2 Then
                Return "Febrero"
            End If

            If Mes = 3 Then
                Return "Marzo"
            End If

            If Mes = 4 Then
                Return "Abril"
            End If

            If Mes = 5 Then
                Return "Mayo"
            End If

            If Mes = 6 Then
                Return "Junio"
            End If

            If Mes = 7 Then
                Return "Julio"
            End If

            If Mes = 8 Then
                Return "Agosto"
            End If

            If Mes = 9 Then
                Return "Septiembre"
            End If

            If Mes = 10 Then
                Return "Octubre"
            End If

            If Mes = 11 Then
                Return "Noviembre"
            End If

            If Mes = 12 Then
                Return "Diciembre"
            End If

            Return "No Valido"


        End Function



        Public Function GetList() As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_MesesList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Meses")

            DBConn.Close()

            Return dsFicha


        End Function

    End Class
End Namespace