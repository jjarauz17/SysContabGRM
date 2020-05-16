Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class DistribucionDB


        Public Shared Function GetData(ByVal CompNo As String, ByVal PerID As String, ByVal Fecha As DateTime, ByVal Moneda As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DistribucionGetDetalles", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim ComprNO As New SqlParameter("@CompNO", SqlDbType.Int)
            ComprNO.Value = CompNo
            DBCommand.SelectCommand.Parameters.Add(ComprNO)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _PerID As New SqlParameter("@periodo", SqlDbType.Int)
            _PerID.Value = PerID
            DBCommand.SelectCommand.Parameters.Add(_PerID)

            Dim _Fecha1 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha1.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)

            Dim _Moneda As New SqlParameter("@MONEDACAMBIOD", SqlDbType.NVarChar)
            _Moneda.Value = Moneda
            DBCommand.SelectCommand.Parameters.Add(_Moneda)

            Dim myDataSet As New DataSet
            DBCommand.Fill(dsFicha, "Distribucion")
            DBConn.Close()

            Return dsFicha

        End Function



    End Class


End Namespace