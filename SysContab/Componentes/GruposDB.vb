Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class GruposDetails
        Public Codigo As String
        Public Nombre As String
        Public Nivel As String
        Public Total As String
        Public Tipo As String
        Public Operacion As String
        Public Factor As Double

    End Class

    Public Class GruposDB

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListGruposReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            pIdent3.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "Grupos")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetDetails(ByVal Codigo As String, ByVal Tipo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsGrupo As New DataSet()
            Dim Details As New GruposDetails()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Grupos WHERE CODIGO_GRUPO = '" & Codigo & "' AND Tipo = '" & Tipo & "' AND Empresa ='" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsGrupo, "Grupos")

            If dsGrupo.Tables("Grupos").Rows.Count = 1 Then
                Details.Codigo = dsGrupo.Tables("Grupos").Rows(0).Item("CODIGO_GRUPO")
                Details.Nombre = dsGrupo.Tables("Grupos").Rows(0).Item("Nombre")
                Details.Nivel = dsGrupo.Tables("Grupos").Rows(0).Item("Nivel")
                Details.Factor = dsGrupo.Tables("Grupos").Rows(0).Item("factor")
                Details.Operacion = dsGrupo.Tables("Grupos").Rows(0).Item("Operacion")

                If dsGrupo.Tables("Grupos").Rows(0).Item("Total") Is DBNull.Value Then
                    Details.Total = ""
                Else
                    Details.Total = dsGrupo.Tables("Grupos").Rows(0).Item("Total")
                End If

                Details.Tipo = dsGrupo.Tables("Grupos").Rows(0).Item("Tipo")
            End If

            Return Details

        End Function

        Public Function GetListAll() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select CODIGO_GRUPO, Nombre, Nivel, Total From GRUPOS WHERE Empresa = '" & EmpresaActual & "' ORDER BY Codigo_Grupo", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetList(ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select CODIGO_GRUPO AS [Código], Nombre, Nivel, Total From GRUPOS WHERE Tipo = '" & Tipo & "' AND Empresa = '" & EmpresaActual & "' ORDER BY Codigo_Grupo", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetList_Presupuesto() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select '0' as CODIGO_GRUPO, ' --- Seleccione ---' as Nombre Union Select CODIGO_GRUPO, Nombre From GRUPOS WHERE Tipo = 'P' AND Empresa = '" & EmpresaActual & "' ORDER BY Codigo_Grupo", DBConn)
            Try
                DBCommand.Fill(dsFicha, "GRUPOS")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select CODIGO_GRUPO, Nombre, Nivel, Total From GRUPOS WHERE Tipo = '" & Tipo & "' AND Nombre Like '%" & Filtro & "%' AND Empresa ='" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscarCombo(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select CODIGO_GRUPO, cast(CODIGO_GRUPO as nvarchar(100))+ '-' + Nombre as Nombre, Nivel, Total From GRUPOS WHERE Tipo = '" & Tipo & "' AND Nombre Like '" & Filtro & "%' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'Try
            'DBConn = New OleDbConnection("server=HP18599821974;" _
            '                        & "Initial Catalog=Inscripcion;" _
            '                        & "User Id=sa;" _
            '                        & "Password=enter;")

            DBCommand = New SqlDataAdapter("Select CODIGO_GRUPO, Nombre, Nivel, Total From GRUPOS WHERE Tipo = '" & Tipo & "' AND CODIGO_GRUPO ='" & Filtro & "' AND Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Delete(ByVal Codigo As String, ByVal Tipo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Grupos WHERE CODIGO_GRUPO = '" & Codigo & "' AND Tipo = '" & Tipo & "' AND Empresa ='" & EmpresaActual & "'"

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

        Public Function AddItem(ByVal Codigo_Grupo As String, ByVal Nombre As String, ByVal Nivel As Integer, _
                                       ByVal Total As String, ByVal Tipo As String, ByVal operacion As String, ByVal Factor As Double)


            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Grupos(CODIGO_GRUPO, NOMBRE, NIVEL, TOTAL, TIPO, EMPRESA, factor, operacion) " & _
                        "Values(" & "'" & Codigo_Grupo & "','" & Nombre & "'," & Nivel & ",'" & Total & "','" & Tipo & "','" & EmpresaActual & "'," & Factor & ",'" & operacion & "')"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Nivel As Integer, _
            ByVal Total As String, ByVal Tipo As String, ByVal Operacion As String, ByVal Factor As Double)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Grupos SET Nombre = '" & Nombre & _
                "', Nivel = " & Nivel & _
                ", Total ='" & Total & _
                "', Factor ='" & Factor & _
                "', Operacion ='" & Operacion & _
                "' WHERE CODIGO_GRUPO = '" & Codigo & "' AND Tipo = '" & Tipo & "' AND Empresa ='" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function AddItem(ByVal Codigo_Grupo As String, ByVal Nombre As String, ByVal Nivel As Integer, _
                                     ByVal Total As String, ByVal Tipo As String)


            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Grupos(CODIGO_GRUPO, NOMBRE, NIVEL, TOTAL, TIPO, EMPRESA) " & _
                        "Values(" & "'" & Codigo_Grupo & "','" & Nombre & "'," & Nivel & ",'" & Total & "','" & Tipo & "','" & EmpresaActual & "')"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Nivel As Integer, _
            ByVal Total As String, ByVal Tipo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Grupos SET Nombre = '" & Nombre & _
                "', Nivel = " & Nivel & _
                ", Total ='" & Total & _
                "' WHERE CODIGO_GRUPO = '" & Codigo & "' AND Tipo = '" & Tipo & "' AND Empresa ='" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function Update_Orden(ByVal Codigo As String, ByVal Tipo As String, ByVal Orden As Integer, ByVal Detalle As Boolean)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Grupos SET Orden = '" & Orden & _
                "', Detalle = " & IIf(Detalle = True, 1, 0) & _
                " WHERE CODIGO_GRUPO = '" & Codigo & "' AND Tipo = '" & Tipo & "' AND Empresa ='" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function
    End Class

End Namespace
