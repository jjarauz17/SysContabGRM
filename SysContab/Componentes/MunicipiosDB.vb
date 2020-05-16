Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class MunicipioDetails
        Public Departamento As Integer
        Public Codigo As Integer
        Public Nombre As String
        Public Impuesto_SVenta As Double
        Public Impuesto_SVenta_Min As Double
    End Class
    Public Class MunicipiosDB

        Public Function List(ByVal Departamento As Integer) As DataTable
            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet
            'Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())
            'Try
            '    DBCommand = New SqlDataAdapter("SELECT DISTINCT Codigo_Municipio AS Codigo, Nombre_Municipio AS Nombre FROM Municipios WHERE Codigo_Departamento = " & Departamento, DBConn)
            '    DBCommand.Fill(dsFicha, "Municipios")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
            'DBConn.Close()
            'Return dsFicha

            Return ObtieneDatos("JAR_MunicipiosList", EmpresaActual, Departamento)

        End Function

        Public Function GetList(ByVal Departamento As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            Try
                DBCommand = New SqlDataAdapter("SELECT 0 AS Codigo, '--Todos--' AS Nombre UNION SELECT Codigo_Municipio AS Codigo, Nombre_Municipio AS Nombre FROM Municipios WHERE Codigo_Departamento = " & Departamento & " OR Codigo_Municipio = 0", DBConn)
                DBCommand.Fill(dsFicha, "Municipios")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetDetails(ByVal Departamento As Integer, ByVal Municipio As Integer) As MunicipioDetails
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim detalles As New VB.SysContab.MunicipioDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            Try
                DBCommand = New SqlDataAdapter("SELECT m.Codigo_Departamento, m.Codigo_Municipio, m.Nombre_Municipio, m.Impuesto_SVentas, m.Impuesto_SVentas_Min " & _
                                               "FROM MUNICIPIOS AS m WHERE m.Codigo_Departamento = " & Departamento & " AND m.Codigo_Municipio = " & Municipio & " AND m.Empresa = " & EmpresaActual, DBConn)
                DBCommand.Fill(dsFicha, "Municipios")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If dsFicha.Tables(0).Rows.Count = 1 Then
                detalles.Departamento = dsFicha.Tables(0).Rows(0)("Codigo_Departamento")
                detalles.Codigo = dsFicha.Tables(0).Rows(0)("Codigo_Municipio")
                detalles.Nombre = dsFicha.Tables(0).Rows(0)("Nombre_municipio")
                detalles.Impuesto_SVenta = dsFicha.Tables(0).Rows(0)("Impuesto_SVentas")
                detalles.Impuesto_SVenta_Min = dsFicha.Tables(0).Rows(0)("Impuesto_SVentas_Min")

            Else
                ''error
                Return Nothing
            End If
            DBConn.Close()
            Return detalles

        End Function

    End Class

End Namespace
