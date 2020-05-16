Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class Forma_PagoDetails
        Public Codigo As String
        Public Nombre As String
        Public Dias As String

    End Class

    Public Class Forma_PagoDB

        Public Function FormaPagoCreditos() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FormaPagoCreditos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Forma_Pago")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function FormaPagoListAll() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FormaPagoListAll", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Forma_Pago")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function FormaPagoDias(ByVal Codigo As String) As Integer
            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_FormaPagoDias", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pCodigo As New SqlParameter("@Codigo", SqlDbType.Int)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pCodigo.Value = Codigo
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pCodigo)
            cmd.Parameters.Add(pEmpresa)


            Dim parameterDias As SqlParameter = New SqlParameter("@Dias", SqlDbType.Int, 4)
            parameterDias.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterDias)

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            ' Return the Total
            If parameterDias.Value.ToString() <> "" Then
                Return CType(parameterDias.Value, Integer)
            Else
                Return -1
            End If

        End Function

        Public Function FormaPagoList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FormaPagoList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Forma_Pago")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListFormaPagosReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Forma_Pago")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetDetails(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsZonas As New DataSet()
            Dim Details As New Forma_PagoDetails()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Forma_Pago WHERE Codigo = " & Codigo & " And Empresa = '" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsZonas, "Forma_Pago")

            If dsZonas.Tables("Forma_Pago").Rows.Count = 1 Then
                Details.Codigo = dsZonas.Tables("Forma_Pago").Rows(0).Item("Codigo")
                Details.Nombre = dsZonas.Tables("Forma_Pago").Rows(0).Item("Nombre")
                Details.Dias = dsZonas.Tables("Forma_Pago").Rows(0).Item("Dias")

            End If
            DBConn.Close()

            Return Details

        End Function


        Public Function GetListTodosparaVentas() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT '%' as Codigo, '--TODOS--' as Nombre, 0 as Dias  UNION SELECT Convert(Varchar, Codigo) as Codigo, Nombre, Dias FROM Forma_Pago WHERE Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Forma_Pago")

            DBConn.Close()

            Return dsFicha

        End Function

        'Public Function GetListTodos() As DataSet
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("SELECT '0' as Codigo, '--TODOS--' as Nombre, 0 as Dias  UNION SELECT Convert(Varchar, Codigo) as Codigo, Nombre, Dias FROM Forma_Pago WHERE Empresa = '" & EmpresaActual & "'", DBConn)
        '    DBCommand.Fill(dsFicha, "Forma_Pago")

        '    DBConn.Close()

        '    Return dsFicha

        'End Function



        Public Function GetList(Optional Todos As Integer = 0) As DataTable


            Return ObtieneDatos("sp_sel_FORMA_PAGOFill",
                                Todos,
                                EmpresaActual)


            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet

            'Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre, Dias FROM Forma_Pago WHERE Empresa = '" & EmpresaActual & "' Order By Dias", DBConn)
            'DBCommand.Fill(dsFicha, "Forma_Pago")

            'DBConn.Close()
            'Return dsFicha

        End Function

        Public Function GetListNuevo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Forma_Pago WHERE Empresa = '" & EmpresaActual & " ORDER BY Codigo DESC", DBConn)
            DBCommand.Fill(dsFicha, "Zonas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre FROM Forma_Pago WHERE Nombre Like '%" & Filtro & "%' And Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "Forma_Pago")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function AddItem(ByVal Nombre As String, ByVal Dias As String)


            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Forma_Pago(Nombre, Dias, Empresa) " & _
                        "Values(" & "'" & Nombre & "','" & Dias & "','" & EmpresaActual & "')"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Dias As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Forma_Pago SET Nombre = '" & Nombre & "', Dias = '" & Dias & "' WHERE Codigo = '" & Codigo & "' And Empresa = '" & EmpresaActual & "'"

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
            cmd.CommandText = "DELETE FROM Forma_Pago WHERE Codigo = '" & Codigo & "' And Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

            DBConn.Close()

        End Function

    End Class

End Namespace
