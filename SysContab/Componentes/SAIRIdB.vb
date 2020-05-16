Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Namespace VB.SysContab
    Public Class SAIRI

        Public Shared Function Sairi_Facturas(ByVal Desde As Date, ByVal Hasta As Date) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet


            DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBCommand = New SqlDataAdapter("_GetSairiFacturasCompras", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pDesde As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pHasta As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)

            pDesde.Value = Desde
            pHasta.Value = Hasta
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pHasta)
            DBCommand.SelectCommand.Parameters.Add(pDesde)

            Try
                DBCommand.Fill(dsFicha, "Ir")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()
            Return dsFicha
        End Function
        Public Shared Function ExportarTXT(ByVal Tablas As DataTable, ByVal Q As String, ByVal Longitud As Integer) As Boolean
            Dim i As Integer

            Dim objStreamWriter As StreamWriter = New StreamWriter(Q, False, System.Text.Encoding.Default) 'File.CreateText(Q)
            objStreamWriter.Flush()

            For i = 0 To Tablas.Rows.Count - 1
                'asumiendo que desde sql viene la linea pegada
                objStreamWriter.WriteLine(Microsoft.VisualBasic.Left(Tablas.Rows(i)("Linea"), Longitud))
            Next
            objStreamWriter.Close()
            Return True
        End Function
    End Class
End Namespace