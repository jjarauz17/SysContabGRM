Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class EmpleadosDetails
        Public Codigo As String
        Public Nombre As String
        Public PNombre As String
        Public SNombre As String
        Public PApellido As String
        Public SApellido As String
        Public DepartamentoC As String
        Public Municipio As String
        Public Direccion As String
        Public Telefono As String
        Public Celular As String
        Public Email As String
        Public Fecha_Nacimiento As String
        Public Nivel_Academico As String
        Public Profesion As String
        Public Sexo As String
        Public Inss As String
        Public Ruc As String
        Public Cedula As String
        Public Fecha_Ingreso As String
        Public Fecha_FinContrato As String
        Public Contrato As String
        Public Departamento As String
        Public Cargo As String
        Public Funcion As String
        Public Horario As String
        Public Salario As String
        Public Estado As String
        Public Duracion As String
        'Public Correo As String
        Public Moneda As String
        Public FormaPago As String  'Quincena, Semanal, Mensual, Destajo
        Public AcumVac As String    'Acumulado de Vacaciones
        Public Ahorro As String     'Acumulado de Ahorro
        Public HExtra As String     'Si el empleado tiene derecho a horas extras
        Public VTransporte As String    'Viatico de transporte que se le paga al empleado




    End Class

    Public Class EmpleadosDB


        Public Function GetListNvo() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpleadoCodigoNvo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)


            DBCommand.Fill(dsFicha, "Empleados")

            DBConn.Close()

            If IsDBNull(dsFicha.Tables("Empleados").Rows(0).Item("CODIGO")) Then
                Return "1"
            Else
                Return Trim(Str(Val(dsFicha.Tables("Empleados").Rows(0).Item("CODIGO")) + 1))
            End If

        End Function
        Public Function GeneradorReportes(ByVal Empleado As String, ByVal Departamento As String, ByVal Cargo As String, ByVal Funcion As String, ByVal Nivel As String, ByVal Profesion As String, ByVal Orden As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GeneradorReportesEmpleados", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.Int)
            Dim pCargo As New SqlParameter("@Cargo", SqlDbType.Int)
            Dim pFuncion As New SqlParameter("@Funcion", SqlDbType.Int)
            Dim pNivel As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pProfesion As New SqlParameter("@Profesion", SqlDbType.NVarChar)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)

            pDepartamento.Value = Departamento
            pCargo.Value = Cargo
            pFuncion.Value = Funcion
            pNivel.Value = Nivel
            pProfesion.Value = Profesion
            pOrden.Value = Orden
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pCargo)
            DBCommand.SelectCommand.Parameters.Add(pFuncion)
            DBCommand.SelectCommand.Parameters.Add(pNivel)
            DBCommand.SelectCommand.Parameters.Add(pProfesion)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "Empleados")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GeneradorReportesGeneral(ByVal Empleado As String, ByVal Departamento As String, ByVal Cargo As String, ByVal Funcion As String, ByVal Nivel As String, ByVal Profesion As String, ByVal Tipo As String, ByVal Orden As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GeneradorReportesEmpleadosGeneral", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pDepartamento As New SqlParameter("@Departamento", SqlDbType.Int)
            Dim pCargo As New SqlParameter("@Cargo", SqlDbType.Int)
            Dim pFuncion As New SqlParameter("@Funcion", SqlDbType.Int)
            Dim pNivel As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pProfesion As New SqlParameter("@Profesion", SqlDbType.NVarChar)
            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)

            pDepartamento.Value = Departamento
            pCargo.Value = Cargo
            pFuncion.Value = Funcion
            pNivel.Value = Nivel
            pProfesion.Value = Profesion
            pTipo.Value = Tipo
            pOrden.Value = Orden
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pDepartamento)
            DBCommand.SelectCommand.Parameters.Add(pCargo)
            DBCommand.SelectCommand.Parameters.Add(pFuncion)
            DBCommand.SelectCommand.Parameters.Add(pNivel)
            DBCommand.SelectCommand.Parameters.Add(pProfesion)
            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Try
                DBCommand.Fill(dsFicha, "Empleados")
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpleadosReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "EMPLEADOS")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetDetails(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsEmpleados As New DataSet()
            Dim Details As New EmpleadosDetails()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' DBCommand = New SqlDataAdapter("SELECT * FROM Empleados WHERE CODIGO_EMPLEADO = '" & Codigo & "' And Empresa = '" & EmpresaActual & "'", DBConn)
            DBCommand = New SqlDataAdapter("_GetListEmpleadosDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'DBCommand.Fill(dsEmpleados, "Empleados")

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsEmpleados, "EMPLEADOS")

            DBConn.Close()


            If dsEmpleados.Tables("Empleados").Rows.Count = 1 Then
                Details.Codigo = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Codigo").ToString
                Details.Nombre = dsEmpleados.Tables("Empleados").Rows(0).Item("Nombre")
                Details.PNombre = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_PNombre").ToString
                Details.SNombre = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_SNombre").ToString
                Details.PApellido = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_PApellido").ToString
                Details.SApellido = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_SApellido").ToString
                Details.DepartamentoC = dsEmpleados.Tables("Empleados").Rows(0).Item("DepC_codigo").ToString
                Details.Municipio = dsEmpleados.Tables("Empleados").Rows(0).Item("Mun_codigo").ToString
                Details.Direccion = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Direccion").ToString
                Details.Telefono = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Telefono").ToString
                Details.Celular = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Celular").ToString
                Details.Email = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Email").ToString
                Details.Fecha_Nacimiento = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_FNac").ToString
                Details.Nivel_Academico = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_NAcademico").ToString
                Details.Profesion = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Profesion").ToString
                Details.Sexo = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Sexo").ToString
                Details.Inss = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Inss").ToString
                Details.Ruc = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Ruc").ToString
                Details.Cedula = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Cedula").ToString
                Details.Fecha_Ingreso = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_FIngreso").ToString
                Details.Fecha_FinContrato = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_FfinContrato").ToString
                Details.Contrato = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Contrato").ToString
                Details.Departamento = dsEmpleados.Tables("Empleados").Rows(0).Item("Dep_codigo").ToString
                Details.Cargo = dsEmpleados.Tables("Empleados").Rows(0).Item("Cgo_codigo").ToString
                Details.Funcion = dsEmpleados.Tables("Empleados").Rows(0).Item("Fun_codigo").ToString
                Details.Horario = dsEmpleados.Tables("Empleados").Rows(0).Item("Hor_Codigo").ToString
                Details.Salario = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Salario").ToString
                Details.Estado = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Estado").ToString
                Details.Duracion = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Duracion").ToString
                Details.Moneda = dsEmpleados.Tables("Empleados").Rows(0).Item("Mon_codigo").ToString
                Details.FormaPago = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_formaPago").ToString
                Details.AcumVac = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_AcumVac").ToString
                Details.Ahorro = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Ahorro").ToString
                Details.HExtra = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_HExtra").ToString
                Details.VTransporte = dsEmpleados.Tables("Empleados").Rows(0).Item("Emp_Vtransporte").ToString

            End If

            Return Details

        End Function

        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_getlistEmpleado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Empleados")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetLists() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_getlistEmpleados", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Empleados")

            DBConn.Close()

            Return dsFicha

        End Function
        Public Function GetListVacaciones() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_getlistEmpleadosVacaciones", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Empleados")

            DBConn.Close()

            Return dsFicha

        End Function
        Public Function GetListAfiscal(ByVal Empleado As String, ByVal AFiscal As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_getlistEmpleadoAFiscal", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pident As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@AFiscal", SqlDbType.NVarChar)
            pIdent2.Value = EmpresaActual
            pident.Value = Empleado
            pIdent3.Value = AFiscal
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pident)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.Fill(dsFicha, "AFiscal")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function GetListDepto(ByVal Depto As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_getlistEmpleadoDpto", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Depto", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Depto
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Empleados")

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

            DBCommand = New SqlDataAdapter("_GetListEmpleadoBuscar ", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Empleados")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscarCombo(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpleadoCombo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            Try
                DBCommand.Fill(dsFicha, "EMPLEADOS")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim cd As String

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpleadoCodigo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "EMPLEADOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Delete(ByVal Codigo As String)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpleadoDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function AddItem(ByVal Codigo As String, ByVal PNombre As String, ByVal SNombre As String, ByVal PApellido As String,
                ByVal SApellido As String, ByVal DepartamentoC As String, ByVal Municipio As String, ByVal Direccion As String,
                ByVal Telefono As String, ByVal Celular As String, ByVal Email As String, ByVal Fecha_Nacimiento As String,
                ByVal Nivel_Academico As String, ByVal Profesion As String, ByVal Sexo As String, ByVal Inss As String,
                ByVal Ruc As String, ByVal Cedula As String, ByVal Fecha_Ingreso As String, ByVal Fecha_FinContrato As String,
                ByVal Contrato As String, ByVal Departamento As String, ByVal Cargo As String, ByVal Funcion As String,
                ByVal Horario As String, ByVal Salario As String, ByVal Estado As String,
                ByVal Duracion As String, ByVal Moneda As String, ByVal FormaPago As String, ByVal HExtra As String,
                ByVal VTransporte As String)


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_EmpleadoAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@PNombre", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@SNombre", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@PApellido", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@SApellido", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Departamentoc", SqlDbType.Int)
            Dim pIdent8 As New SqlParameter("@Municipio", SqlDbType.Int)
            Dim pIdent9 As New SqlParameter("@Direccion", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Telefono", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Celular", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@Email", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@FNacimiento", SqlDbType.DateTime)
            Dim pIdent14 As New SqlParameter("@NAcademico", SqlDbType.NVarChar)
            Dim pIdent15 As New SqlParameter("@Profesion", SqlDbType.NVarChar)
            Dim pIdent16 As New SqlParameter("@Sexo", SqlDbType.NVarChar)
            Dim pIdent17 As New SqlParameter("@Inss", SqlDbType.NVarChar)
            Dim pIdent18 As New SqlParameter("@Ruc", SqlDbType.NVarChar)
            Dim pIdent19 As New SqlParameter("@Cedula", SqlDbType.NVarChar)
            Dim pIdent20 As New SqlParameter("@FIngreso", SqlDbType.DateTime)
            'Dim pIdent21 As New SqlParameter("@FfinContrato", SqlDbType.DateTime)
            Dim pIdent22 As New SqlParameter("@Contrato", SqlDbType.NVarChar)
            Dim pIdent23 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent24 As New SqlParameter("@Cargo", SqlDbType.NVarChar)
            Dim pIdent25 As New SqlParameter("@Funcion", SqlDbType.NVarChar)
            Dim pIdent26 As New SqlParameter("@Horario", SqlDbType.NVarChar)
            Dim pIdent27 As New SqlParameter("@Salario", SqlDbType.Float)
            Dim pIdent28 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pIdent29 As New SqlParameter("@Duracion", SqlDbType.Float)
            Dim pIdent30 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pIdent31 As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            Dim pIdent32 As New SqlParameter("@HExtra", SqlDbType.NVarChar)
            Dim pIdent33 As New SqlParameter("@VTransporte", SqlDbType.Float)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = PNombre
            pIdent4.Value = SNombre
            pIdent5.Value = PApellido
            pIdent6.Value = SApellido
            pIdent7.Value = DepartamentoC
            pIdent8.Value = Municipio
            pIdent9.Value = Direccion
            pIdent10.Value = Telefono
            pIdent11.Value = Celular
            pIdent12.Value = Email
            pIdent13.Value = Fecha_Nacimiento
            pIdent14.Value = Nivel_Academico
            pIdent15.Value = Profesion
            pIdent16.Value = Sexo
            pIdent17.Value = Inss
            pIdent18.Value = Ruc
            pIdent19.Value = Cedula
            pIdent20.Value = Fecha_Ingreso
            'pIdent21.Value = Fecha_FinContrato
            pIdent22.Value = Contrato
            pIdent23.Value = Departamento
            pIdent24.Value = Cargo
            pIdent25.Value = Funcion
            pIdent26.Value = Horario
            pIdent27.Value = Salario
            pIdent28.Value = Estado
            pIdent29.Value = Duracion
            pIdent30.Value = Moneda
            pIdent31.Value = FormaPago
            pIdent32.Value = HExtra
            pIdent33.Value = VTransporte

            DBCommand.SelectCommand.Parameters.Add(pIdent)
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
            DBCommand.SelectCommand.Parameters.Add(pIdent16)
            DBCommand.SelectCommand.Parameters.Add(pIdent17)
            DBCommand.SelectCommand.Parameters.Add(pIdent18)
            DBCommand.SelectCommand.Parameters.Add(pIdent19)
            DBCommand.SelectCommand.Parameters.Add(pIdent20)
            'DBCommand.SelectCommand.Parameters.Add(pIdent21)
            DBCommand.SelectCommand.Parameters.Add(pIdent22)
            DBCommand.SelectCommand.Parameters.Add(pIdent23)
            DBCommand.SelectCommand.Parameters.Add(pIdent24)
            DBCommand.SelectCommand.Parameters.Add(pIdent25)
            DBCommand.SelectCommand.Parameters.Add(pIdent26)
            DBCommand.SelectCommand.Parameters.Add(pIdent27)
            DBCommand.SelectCommand.Parameters.Add(pIdent28)
            DBCommand.SelectCommand.Parameters.Add(pIdent29)
            DBCommand.SelectCommand.Parameters.Add(pIdent30)
            DBCommand.SelectCommand.Parameters.Add(pIdent31)
            DBCommand.SelectCommand.Parameters.Add(pIdent32)
            DBCommand.SelectCommand.Parameters.Add(pIdent33)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function


        Public Function UpdateTemp(ByVal Codigo As String, ByVal PNombre As String, ByVal SNombre As String, ByVal PApellido As String,
                ByVal SApellido As String, ByVal DepartamentoC As String, ByVal Municipio As String, ByVal Direccion As String,
                ByVal Telefono As String, ByVal Celular As String, ByVal Email As String, ByVal Fecha_Nacimiento As String,
                ByVal Nivel_Academico As Integer, ByVal Profesion As String, ByVal Sexo As String, ByVal Inss As String,
                ByVal Ruc As String, ByVal Cedula As String, ByVal Fecha_Ingreso As String, ByVal Fecha_FinContrato As String,
                ByVal Contrato As String, ByVal Departamento As String, ByVal Cargo As String, ByVal Funcion As String,
                ByVal Horario As String, ByVal Salario As String, ByVal Estado As String,
                ByVal Duracion As String, ByVal Moneda As String, ByVal FormaPago As String, ByVal HExtra As String,
                ByVal VTransporte As String)


            ' cmd.CommandText = "UPDATE Empleados SET CODIGO_EMPLEADO = '" & Trim(Codigo) & "' WHERE CODIGO_EMPLEADO = '" & Codigo & "'"


        End Function

        Public Function Update(ByVal Codigo As String, ByVal PNombre As String, ByVal SNombre As String, ByVal PApellido As String,
                ByVal SApellido As String, ByVal DepartamentoC As String, ByVal Municipio As String, ByVal Direccion As String,
                ByVal Telefono As String, ByVal Celular As String, ByVal Email As String, ByVal Fecha_Nacimiento As String,
                ByVal Nivel_Academico As String, ByVal Profesion As String, ByVal Sexo As String, ByVal Inss As String,
                ByVal Ruc As String, ByVal Cedula As String, ByVal Fecha_Ingreso As String, ByVal Fecha_FinContrato As String,
                ByVal Contrato As String, ByVal Departamento As String, ByVal Cargo As String, ByVal Funcion As String,
                ByVal Horario As String, ByVal Salario As String, ByVal Estado As String,
                ByVal Duracion As String, ByVal Moneda As String, ByVal FormaPago As String, ByVal HExtra As String,
                ByVal VTransporte As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_EmpleadoUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@PNombre", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@SNombre", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@PApellido", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@SApellido", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Departamentoc", SqlDbType.Int)
            Dim pIdent8 As New SqlParameter("@Municipio", SqlDbType.Int)
            Dim pIdent9 As New SqlParameter("@Direccion", SqlDbType.NVarChar)
            Dim pIdent10 As New SqlParameter("@Telefono", SqlDbType.NVarChar)
            Dim pIdent11 As New SqlParameter("@Celular", SqlDbType.NVarChar)
            Dim pIdent12 As New SqlParameter("@Email", SqlDbType.NVarChar)
            Dim pIdent13 As New SqlParameter("@FNacimiento", SqlDbType.DateTime)
            Dim pIdent14 As New SqlParameter("@NAcademico", SqlDbType.NVarChar)
            Dim pIdent15 As New SqlParameter("@Profesion", SqlDbType.NVarChar)
            Dim pIdent16 As New SqlParameter("@Sexo", SqlDbType.NVarChar)
            Dim pIdent17 As New SqlParameter("@Inss", SqlDbType.NVarChar)
            Dim pIdent18 As New SqlParameter("@Ruc", SqlDbType.NVarChar)
            Dim pIdent19 As New SqlParameter("@Cedula", SqlDbType.NVarChar)
            Dim pIdent20 As New SqlParameter("@FIngreso", SqlDbType.DateTime)
            'Dim pIdent21 As New SqlParameter("@FfinContrato", SqlDbType.DateTime)
            Dim pIdent22 As New SqlParameter("@Contrato", SqlDbType.NVarChar)
            Dim pIdent23 As New SqlParameter("@Departamento", SqlDbType.NVarChar)
            Dim pIdent24 As New SqlParameter("@Cargo", SqlDbType.NVarChar)
            Dim pIdent25 As New SqlParameter("@Funcion", SqlDbType.NVarChar)
            Dim pIdent26 As New SqlParameter("@Horario", SqlDbType.NVarChar)
            Dim pIdent27 As New SqlParameter("@Salario", SqlDbType.Float)
            Dim pIdent28 As New SqlParameter("@Estado", SqlDbType.NVarChar)
            Dim pIdent29 As New SqlParameter("@Duracion", SqlDbType.Float)
            Dim pIdent30 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pIdent31 As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            Dim pIdent32 As New SqlParameter("@HExtra", SqlDbType.NVarChar)
            Dim pIdent33 As New SqlParameter("@VTransporte", SqlDbType.Float)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = PNombre
            pIdent4.Value = SNombre
            pIdent5.Value = PApellido
            pIdent6.Value = SApellido
            pIdent7.Value = DepartamentoC
            pIdent8.Value = Municipio
            pIdent9.Value = Direccion
            pIdent10.Value = Telefono
            pIdent11.Value = Celular
            pIdent12.Value = Email
            pIdent13.Value = Fecha_Nacimiento
            pIdent14.Value = Nivel_Academico
            pIdent15.Value = Profesion
            pIdent16.Value = Sexo
            pIdent17.Value = Inss
            pIdent18.Value = Ruc
            pIdent19.Value = Cedula
            pIdent20.Value = Fecha_Ingreso
            ' pIdent21.Value = Fecha_FinContrato
            pIdent22.Value = Contrato
            pIdent23.Value = Departamento
            pIdent24.Value = Cargo
            pIdent25.Value = Funcion
            pIdent26.Value = Horario
            pIdent27.Value = Salario
            pIdent28.Value = Estado
            pIdent29.Value = Duracion
            pIdent30.Value = Moneda
            pIdent31.Value = FormaPago
            pIdent32.Value = HExtra
            pIdent33.Value = VTransporte

            DBCommand.SelectCommand.Parameters.Add(pIdent)
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
            DBCommand.SelectCommand.Parameters.Add(pIdent16)
            DBCommand.SelectCommand.Parameters.Add(pIdent17)
            DBCommand.SelectCommand.Parameters.Add(pIdent18)
            DBCommand.SelectCommand.Parameters.Add(pIdent19)
            DBCommand.SelectCommand.Parameters.Add(pIdent20)
            'DBCommand.SelectCommand.Parameters.Add(pIdent21)
            DBCommand.SelectCommand.Parameters.Add(pIdent22)
            DBCommand.SelectCommand.Parameters.Add(pIdent23)
            DBCommand.SelectCommand.Parameters.Add(pIdent24)
            DBCommand.SelectCommand.Parameters.Add(pIdent25)
            DBCommand.SelectCommand.Parameters.Add(pIdent26)
            DBCommand.SelectCommand.Parameters.Add(pIdent27)
            DBCommand.SelectCommand.Parameters.Add(pIdent28)
            DBCommand.SelectCommand.Parameters.Add(pIdent29)
            DBCommand.SelectCommand.Parameters.Add(pIdent30)
            DBCommand.SelectCommand.Parameters.Add(pIdent31)
            DBCommand.SelectCommand.Parameters.Add(pIdent32)
            DBCommand.SelectCommand.Parameters.Add(pIdent33)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

        Public Function UpdateVac(ByVal Codigo As String,
                ByVal Dias As Long, ByVal APagar As Long)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_EmpleadoUpdateVacaciones", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Dias", SqlDbType.Float)
            Dim pIdent4 As New SqlParameter("@APagar", SqlDbType.Float)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Dias
            pIdent4.Value = APagar

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

        Public Function UpdateAguinaldo(ByVal TPeriodo As String) ', _
            'ByVal Dias As Long)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_EmpleadoUpdateAguinaldo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@TPeriodo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = TPeriodo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

        Public Function UpdateAguinaldo_Decrease(ByVal Empleado As String,
            ByVal Dias As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            ' Se define el tipo de comando

            DBCommand = New SqlDataAdapter("_EmpleadoUpdateAguinaldo_Decrease", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empleado", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Dias", SqlDbType.Float)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Empleado
            pIdent3.Value = Dias

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function
    End Class

End Namespace
