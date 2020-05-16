Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    'Public Class Tipo_ComprobanteDetails
    '    Public Codigo As String
    '    Public Nombre As String

    'End Class

    Public Class Tipo_ComprobanteDB

        Public Function CierreEstado(ByVal Cierre As Boolean, ByVal Periodo As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CierreEstado", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Cierre As SqlParameter = New SqlParameter("@Cierre", SqlDbType.Bit)
            Dim _Periodo As SqlParameter = New SqlParameter("@Periodo", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Cierre.Value = Cierre
            _Periodo.Value = Periodo
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Cierre)
            DBCommand.SelectCommand.Parameters.Add(_Periodo)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ListCierre(ByVal Cierre As Boolean) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoComprobantesCierre", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Cierre As SqlParameter = New SqlParameter("@Cierre", SqlDbType.Bit)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Cierre.Value = Cierre
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Cierre)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoComprobantesReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Tipo_Comprobantes")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetDetails(ByVal Codigo As String)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsZonas As New DataSet()

            Dim Details As New Tipo_ComprobanteDetails()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM TipoComprobantes WHERE TipComp_ID = " & Codigo & " AND Empresa = '" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsZonas, "Tipo_Comprobantes")

            If dsZonas.Tables("Tipo_Comprobantes").Rows.Count = 1 Then
                Details.Codigo = dsZonas.Tables("Tipo_Comprobantes").Rows(0).Item("TipComp_ID").ToString
                Details.Nombre = dsZonas.Tables("Tipo_Comprobantes").Rows(0).Item("TipComp_Nombre").ToString
                Details.Abreviatura = dsZonas.Tables("Tipo_Comprobantes").Rows(0).Item("TipoComp_Abrev").ToString
                Details.Cierre = dsZonas.Tables("Tipo_Comprobantes").Rows(0).Item("TipComp_Cierre")
                Details.Cheque = dsZonas.Tables("Tipo_Comprobantes").Rows(0).Item("TipComp_Cheque")
                Details.Mantenimiento = dsZonas.Tables("Tipo_Comprobantes").Rows(0).Item("TipComp_Mtto")
                Details.Inicio = dsZonas.Tables("Tipo_Comprobantes").Rows(0).Item("Concectivo")
            End If

            Return Details
        End Function


        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT TipComp_ID AS Codigo, TipComp_Nombre AS Nombre, TipoComp_Abrev AS Abreviatura FROM TipoComprobantes WHERE Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Tipo_Comprobantes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNuevo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Tipo_Comprobantes WHERE Empresa = '" & EmpresaActual & "' ORDER BY Codigo DESC", DBConn)
            DBCommand.Fill(dsFicha, "Tipo_Comprobantes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre FROM Tipo_Comprobantes WHERE Nombre Like '%" & Filtro & "%' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Tipo_Comprobantes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNombre(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre FROM Tipo_Comprobantes WHERE Nombre = '" & Filtro & "' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Tipo_Comprobantes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Sub GetListComprobantesClasificados(ByRef CC As Integer, ByRef CK As Integer, _
            ByRef CM As Integer, ByVal TComprobante As Integer)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetTComp_Clasificados", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@CC", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@CK", SqlDbType.Int)
            Dim pIdent4 As New SqlParameter("@CM", SqlDbType.Int)
            Dim pIdent5 As New SqlParameter("@Tipo", SqlDbType.Int)

            pIdent1.Value = EmpresaActual
            pIdent2.Direction = ParameterDirection.Output
            pIdent3.Direction = ParameterDirection.Output
            pIdent4.Direction = ParameterDirection.Output
            pIdent5.Value = TComprobante

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
                CC = pIdent2.Value
                CK = pIdent3.Value
                CM = pIdent4.Value

            Catch ex As Exception
                MsgBox(ex.Message)
                CC = -1
                CK = -1
                CM = -1

            End Try

        End Sub

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Abreviatura As String, _
                ByVal Cierre As Boolean, ByVal Cheque As Boolean, ByVal Mtto As Boolean, Optional ByVal Inicio As String = "0")

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_TipoComprobantesUpdate", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Codigo As SqlParameter = New SqlParameter("@Codigo", SqlDbType.Int)
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar, 50)
            Dim _Abrev As SqlParameter = New SqlParameter("@Abrev", SqlDbType.NVarChar, 50)
            Dim _Cierre As SqlParameter = New SqlParameter("@Cierre", SqlDbType.Bit)
            Dim _Cheque As SqlParameter = New SqlParameter("@Cheque", SqlDbType.Bit)
            Dim _Mtto As SqlParameter = New SqlParameter("@Mtto", SqlDbType.Bit)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Inicio As SqlParameter = New SqlParameter("@Inicio", SqlDbType.NVarChar, 50)

            _Codigo.Value = Codigo
            _Nombre.Value = Nombre
            _Abrev.Value = Abreviatura
            _Cierre.Value = Cierre
            _Cheque.Value = Cheque
            _Mtto.Value = Mtto
            _Empresa.Value = EmpresaActual
            _Inicio.Value = Inicio

            cmd.Parameters.Add(_Codigo)
            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_Abrev)
            cmd.Parameters.Add(_Cierre)
            cmd.Parameters.Add(_Cheque)
            cmd.Parameters.Add(_Mtto)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Inicio)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
        End Function

        Public Function AddItem(ByVal Nombre As String, ByVal Abreviatura As String, ByVal Cierre As Boolean, _
                    ByVal Cheque As Boolean, ByVal Mtto As Boolean, Optional ByVal Inicio As String = "0")

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_TipoComprobantesAdd", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar, 50)
            Dim _Abrev As SqlParameter = New SqlParameter("@Abrev", SqlDbType.NVarChar, 50)
            Dim _Cierre As SqlParameter = New SqlParameter("@Cierre", SqlDbType.Bit)
            Dim _Cheque As SqlParameter = New SqlParameter("@Cheque", SqlDbType.Bit)
            Dim _Mtto As SqlParameter = New SqlParameter("@Mtto", SqlDbType.Bit)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            Dim _Inicio As SqlParameter = New SqlParameter("@Inicio", SqlDbType.NVarChar, 50)

            _Nombre.Value = Nombre
            _Abrev.Value = Abreviatura
            _Cierre.Value = Cierre
            _Cheque.Value = Cheque
            _Mtto.Value = Mtto
            _Empresa.Value = EmpresaActual
            _Inicio.Value = Inicio

            cmd.Parameters.Add(_Nombre)
            cmd.Parameters.Add(_Abrev)
            cmd.Parameters.Add(_Cierre)
            cmd.Parameters.Add(_Cheque)
            cmd.Parameters.Add(_Mtto)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Inicio)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
        End Function

        'Public Function AddItem(ByVal Nombre As String, ByVal Abreviatura As String, ByVal Cierre As Boolean)


        '    ' Crea una instancia de conexion y un comando SQL
        '    Dim cmd As New SqlCommand()
        '    Dim DBConn As SqlConnection

        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    ' Se define el tipo de comando
        '    cmd.CommandType = CommandType.Text
        '    cmd.CommandText = "INSERT INTO TipoComprobantes(TipComp_Nombre, TipoComp_Abrev, TipComp_Cierre, Empresa) " & _
        '                "Values(" & "'" & Nombre & "','" & Abreviatura & "'," & Cierre & ",'" & EmpresaActual & "')"

        '    'Se asigna conexion al comando y se abre conexion 
        '    cmd.Connection = DBConn
        '    DBConn.Open()
        '    cmd.ExecuteNonQuery()
        '    DBConn.Close()

        'End Function

        'Public Function Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Abreviatura As String, ByVal Cierre As Boolean)

        '    ' Crea una instancia de conexion y un comando SQL
        '    Dim cmd As New SqlCommand()
        '    Dim DBConn As SqlConnection

        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion)

        '    ' Se define el tipo de comando
        '    cmd.CommandType = CommandType.Text

        '    cmd.CommandText = "UPDATE TipoComprobantes SET TipComp_Nombre = '" & Nombre & "', TipoComp_Abrev = '" & Abreviatura & "', TipComp_Cierre =  " & Cierre & " WHERE TipComp_ID = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

        '    'Se asigna conexion al comando y se abre conexion 
        '    cmd.Connection = DBConn
        '    DBConn.Open()
        '    cmd.ExecuteNonQuery()
        '    DBConn.Close()

        'End Function

        Public Function Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM TipoComprobantes WHERE TipComp_Id = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            Try
                cmd.Connection = DBConn
                DBConn.Open()
                cmd.ExecuteNonQuery()
            Catch EXC As Exception
                MsgBox(EXC.Message)
            End Try
            DBConn.Close()

        End Function

        Public Sub New()

        End Sub
    End Class
End Namespace
