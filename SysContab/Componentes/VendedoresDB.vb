Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class VendedoresDetails
        Public Codigo As String
        Public Nombre As String
        Public Linea As String
        Public Direccion As String
        Public Ciudad As String
        Public Telefono As String
        Public Celular As String
        Public Correo As String
        Public Cod_Zona As String
        Public Comision As String
        Public Comision_Servicio As String
        Public Nombre_Zona As String
        Public Tipo As Integer
        Public Activo As Boolean
        Public IdCentro As Integer
    End Class

    Public Class VendedoresDB

        Public Function VendedoresList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_VendedoresList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Vendedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetVentas(ByVal Vendedor As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetVentasVendedores", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pVendedor As New SqlParameter("@Vendedor", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pVendedor.Value = Vendedor
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pVendedor)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GeneradorReportes(ByVal TipoReporte As Integer, ByVal Mes As Integer, ByVal Fecha1 As String, _
         ByVal Fecha2 As String, ByVal Vendedor As Integer, ByVal Cliente As Integer, ByVal Linea As Integer, _
         ByVal Departamento As Integer, ByVal Municipio As Integer, ByVal Zona As Integer, ByVal Orden As Integer, _
         ByVal FormaPago As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GeneradorReportesVendedores", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipoReporte As New SqlParameter("@TipoReporte", SqlDbType.Int)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.Int)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)
            Dim pVendedor As New SqlParameter("@Vendedor", SqlDbType.Int)
            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            Dim pLinea As New SqlParameter("@Linea", SqlDbType.Int)
            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.Int)
            Dim pMunicipio As New SqlParameter("@Municipio", SqlDbType.Int)
            Dim pZona As New SqlParameter("@Zona", SqlDbType.Int)
            Dim PFormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pTipoReporte.Value = TipoReporte
            pMes.Value = Mes
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pOrden.Value = Orden
            pVendedor.Value = Vendedor
            pCliente.Value = Cliente
            pLinea.Value = Linea
            pDepartamento.Value = Departamento
            pMunicipio.Value = Municipio
            pZona.Value = Zona
            PFormaPago.Value = FormaPago

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pTipoReporte)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.SelectCommand.Parameters.Add(pVendedor)
            DBCommand.SelectCommand.Parameters.Add(pCliente)
            DBCommand.SelectCommand.Parameters.Add(pLinea)
            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pMunicipio)
            DBCommand.SelectCommand.Parameters.Add(pZona)
            DBCommand.SelectCommand.Parameters.Add(PFormaPago)

            DBCommand.Fill(dsFicha, "Vendedores")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GenerarCodigo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo FROM Vendedores WHERE Empresa = '" & EmpresaActual & "' ORDER BY Codigo DESC", DBConn)
            DBCommand.Fill(dsFicha, "Vendedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetClientesxVendedor(ByVal Vendedor As String) As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetClientesxVendedor", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pVendedor As New SqlParameter("@Vendedor", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pVendedor.Value = Vendedor
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pVendedor)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "VENDEDORES")

            DBConn.Close()

            Return dsFicha.Tables("Vendedores").Rows(0).Item("Clientes").ToString

        End Function


        Public Shared Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListVendedoresReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "VENDEDORES")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetDetails(ByVal Codigo As String)

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsVendedores As New DataSet()
            'Dim dsZona As New DataSet()
            'Dim Details As New VendedoresDetails()
            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT * FROM Vendedores WHERE Codigo = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'", DBConn)

            'DBCommand.Fill(dsVendedores, "Vendedores")

            Dim Details As New VendedoresDetails()
            Dim DTVendedores As DataTable = GetList(Codigo)


            If DTVendedores.Rows.Count = 1 Then

                Details.Codigo = DTVendedores.Rows(0).Item("Codigo").ToString
                Details.Nombre = DTVendedores.Rows(0).Item("Nombre").ToString
                Details.Linea = DTVendedores.Rows(0).Item("Linea").ToString
                Details.Direccion = DTVendedores.Rows(0).Item("Direccion").ToString
                Details.Ciudad = DTVendedores.Rows(0).Item("Ciudad").ToString
                Details.Telefono = DTVendedores.Rows(0).Item("Telefono").ToString
                Details.Celular = DTVendedores.Rows(0).Item("Celular").ToString
                Details.Correo = DTVendedores.Rows(0).Item("Correo").ToString
                Details.Cod_Zona = DTVendedores.Rows(0).Item("Cod_Zona").ToString
                Details.Comision = DTVendedores.Rows(0).Item("Comision").ToString
                Details.Comision_Servicio = DTVendedores.Rows(0).Item("Comision_Servicio").ToString
                Details.Tipo = DTVendedores.Rows(0).Item("TIPO")
                Details.Activo = DTVendedores.Rows(0).Item("ACTIVO")
                Details.IdCentro = DTVendedores.Rows(0).Item("IdCentro")

                'DBCommand = New SqlDataAdapter("SELECT * FROM Zonas WHERE Codigo = " & Details.Cod_Zona & " And Empresa = '" & EmpresaActual & "'", DBConn)
                'DBCommand.Fill(dsZona, "Zonas")
                'Details.Nombre_Zona = dsZona.Tables("Zonas").Rows(0).Item("Nombre").ToString

            End If

            Return Details

        End Function

        Public Shared Function GetList(Codigo As Integer) As DataTable

            Return ObtieneDatos("sp_sel_vendedores", Codigo, EmpresaActual)


            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT cast(Codigo AS INT) Codigo, Nombre, case when Tipo = 0 then 'VENDEDOR' ELSE 'TECNICO' END Tipo, Direccion, Ciudad Cargo, Telefono, Celular, Correo, Comision AS [Comisión Producto], Comision_Servicio AS [Comisión Servicio], CAST(ACTIVO as BIT) ACTIVO FROM Vendedores WHERE Empresa = '" & EmpresaActual & "'", DBConn)
            'DBCommand.Fill(dsFicha, "Vendedores")

            'DBConn.Close()

            'Return dsFicha

        End Function

        Public Function GetListComision() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre, Direccion, Ciudad, Telefono, Celular, Correo, Comision, Comision_Servicio FROM Vendedores WHERE Empresa = '" & EmpresaActual & "' ORDER BY Codigo DESC", DBConn)
            DBCommand.Fill(dsFicha, "Vendedores")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNuevo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Vendedores WHERE Empresa = '" & EmpresaActual & "' ORDER BY Codigo DESC", DBConn)
            DBCommand.Fill(dsFicha, "Vendedores")

            DBConn.Close()

            Return dsFicha

        End Function

        'Public Function GetListBuscar(ByVal Filtro As String) As DataSet
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet()
        '    Dim cd As String

        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("SELECT CAST(Codigo as int) Codigo, Nombre, Direccion, Ciudad, Telefono, Celular, Correo, Comision, Comision_Servicio FROM Vendedores WHERE Nombre Like '%" & Filtro & "%' AND Empresa ='" & EmpresaActual & "'", DBConn)
        '    DBCommand.Fill(dsFicha, "Vendedores")

        '    DBConn.Close()

        '    Return dsFicha

        'End Function

        Public Function GetListBuscarCombo(ByVal Filtro As String, Optional Todo As Integer = 0) As DataTable
            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()
            'Dim cd As String

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("SELECT CAST(Codigo as int) Codigo, Nombre, Direccion, Ciudad, Telefono, Celular, Correo, Comision, Comision_Servicio, IdCentro FROM Vendedores WITH (NOLOCK) WHERE Nombre Like '" & Filtro & "%' AND ACTIVO = 1 AND TIPO = 0 AND Empresa = '" & EmpresaActual & "'", DBConn)
            'DBCommand.Fill(dsFicha, "Vendedores")
            ' DBConn.Close()

            Return ObtieneDatos("JAR_GetVendedoresList", EmpresaActual, Todo)


            '    Return dsFicha

        End Function

        Public Function AddItem(ByVal Codigo As String, ByVal Nombre As String, ByVal Linea As String, ByVal Direccion As String, ByVal Ciudad As String, _
                                ByVal Telefono As String, ByVal Celular As String, ByVal Correo As String, ByVal Cod_Zona As String, _
                                ByVal Comision As String, ByVal Comision_Servicio As String, Tipo As Integer, Activo As Integer, IdCentro As Integer)


            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Vendedores(Codigo, Nombre, Linea, Direccion, Ciudad, Telefono, Celular, Correo, Cod_Zona, Comision, Comision_Servicio, Empresa, TIPO,ACTIVO, IdCentro) " & _
                        "Values(" & "'" & Codigo & "','" & Nombre & "','" & Linea & "','" & Direccion & "','" & Ciudad & "','" & Telefono & "','" & Celular & "','" & Correo & "','" & Cod_Zona & "','" & Comision & "','" & Comision_Servicio & "','" & EmpresaActual & "'," & Tipo & "," & Activo & "," & IdCentro & ")"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Linea As String, ByVal Direccion As String, ByVal Ciudad As String, _
                                ByVal Telefono As String, ByVal Celular As String, ByVal Correo As String, ByVal Cod_Zona As String, _
                                ByVal Comision As String, ByVal Comision_Servicio As String, Tipo As Integer, Activo As Integer, IdCentro As Integer)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "UPDATE Vendedores SET Nombre = '" & Nombre & "', " & _
                              "Linea = '" & Linea & "', " & _
                              "Direccion = '" & Direccion & "', " & _
                              "Ciudad = '" & Ciudad & "', " & _
                              "Telefono = '" & Telefono & "', " & _
                              "Celular = '" & Celular & "', " & _
                              "Correo = '" & Correo & "', " & _
                              "Cod_Zona = " & Cod_Zona & ", " & _
                              "Comision = '" & Comision & "', " & _
                              "Comision_Servicio = '" & Comision_Servicio & "', " & _
                              "ACTIVO = '" & Activo & "', " & _
                              "TIPO = " & Tipo & ",  " & _
                              "IdCentro = " & IdCentro & " " & _
                              " WHERE Codigo = " & Codigo & " AND Empresa = '" & EmpresaActual & "'"
            Try
                'Se asigna conexion al comando y se abre conexion 
                cmd.Connection = DBConn
                DBConn.Open()
                cmd.ExecuteNonQuery()
                DBConn.Close()

                'Si se desactiva el Vendedor, los clientes asignados a ese vendedor quedaron sin Vendedor asignado
                If Activo = 0 Then
                    GuardaDatos("UPDATE CLIENTES SET VENDEDOR = 0 WHERE VENDEDOR = " & Codigo & " AND EMPRESA = " & EmpresaActual)
                End If
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
            End Try

        End Function

        Public Function Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Vendedores WHERE Codigo = '" & Codigo & "' AND Empresa = '" & EmpresaActual & "'"

            'Se asigna conexion al comando y se abre conexion 

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()

            DBConn.Close()

        End Function

    End Class
End Namespace
