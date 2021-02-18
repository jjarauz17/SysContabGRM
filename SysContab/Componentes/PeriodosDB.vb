Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class FechasdeTrabajo
        Public FechaMinima As Date = VB.SysContab.PeriodosDB.GetFechas(0)
        Public FechaMaxima As Date = VB.SysContab.PeriodosDB.GetFechas(1)
    End Class

    Public Class FechasdeOperacion
        Public FechaMinima As Date = VB.SysContab.PeriodosDB.GetFechas("0")
        Public FechaMaxima As Date = VB.SysContab.PeriodosDB.GetFechas("1")
    End Class
    Public Class PeriodoDetails
        Public ID As String
        Public Descripcion As String
        Public Inicio As DateTime
        Public Final As DateTime
        Public Activo As Boolean
        Public Accion As Boolean
        Public Estado As Boolean
        Public Actual As Integer
    End Class

    Public Class PeriodosDB

        Public Shared Function CuentaUtilidadAcumulada() As String

            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As New SqlDataAdapter("_CuentaUtilidadAcumulada", DBConn)

            'Dim cmd As SqlCommand = New SqlCommand("_PeriodosCerrar", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            cmd.SelectCommand.Parameters.Add(_Empresa)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar, 64)
            _Cuenta.Direction = ParameterDirection.Output
            cmd.SelectCommand.Parameters.Add(_Cuenta)

            DBConn.Open()
            cmd.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

            Return _Cuenta.Value

        End Function

        Public Shared Function CuentaUtilidadPerdida() As String

            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As New SqlDataAdapter("_CuentaUtilidadPerdida", DBConn)

            'Dim cmd As SqlCommand = New SqlCommand("_PeriodosCerrar", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            cmd.SelectCommand.Parameters.Add(_Empresa)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar, 64)
            _Cuenta.Direction = ParameterDirection.Output
            cmd.SelectCommand.Parameters.Add(_Cuenta)

            DBConn.Open()
            cmd.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

            Return _Cuenta.Value

        End Function

        Public Shared Function CerrarPeriodo(ByVal PerID As String, ByVal Cuenta As String, ByVal Cuenta1 As String, ByVal Comprobante As String, ByVal Concepto As String, ByVal Fecha As String)
            Dim cmd As SqlCommand = New SqlCommand("_PeriodoCierre", DBConnFacturas)
            'cmd.CommandTimeout = 300

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            cmd.Parameters.Add(_Empresa)

            Dim _PerID As New SqlParameter("@Periodo", SqlDbType.Int)
            _PerID.Value = PerID
            cmd.Parameters.Add(_PerID)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar, 64)
            _Cuenta.Value = Cuenta
            cmd.Parameters.Add(_Cuenta)

            Dim _Cuenta1 As New SqlParameter("@Cuenta1", SqlDbType.NVarChar, 64)
            _Cuenta1.Value = Cuenta1
            cmd.Parameters.Add(_Cuenta1)

            Dim _Comprobante As New SqlParameter("@CompNo", SqlDbType.NVarChar)
            _Comprobante.Value = Comprobante
            cmd.Parameters.Add(_Comprobante)

            Dim _Concepto As New SqlParameter("@Concepto", SqlDbType.NVarChar)
            _Concepto.Value = Concepto
            cmd.Parameters.Add(_Concepto)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Shared Function PeriodoNuevo(ByVal PerID As String) As Integer

            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As New SqlDataAdapter("_PeriodoNuevo", DBConn)

            'Dim cmd As SqlCommand = New SqlCommand("_PeriodosCerrar", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            cmd.SelectCommand.Parameters.Add(_Empresa)

            Dim _PerID As New SqlParameter("@Periodo", SqlDbType.Int)
            _PerID.Value = PerID
            cmd.SelectCommand.Parameters.Add(_PerID)

            Dim _PeriodoNuevo As New SqlParameter("@PeriodoNuevo", SqlDbType.Int)
            _PeriodoNuevo.Direction = ParameterDirection.Output
            cmd.SelectCommand.Parameters.Add(_PeriodoNuevo)

            DBConn.Open()
            cmd.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

            Return _PeriodoNuevo.Value

        End Function

        Public Shared Function CerrarPeriodo(ByVal PerID As String, ByVal Estado As Boolean)

            'Dim DBConn As SqlConnection
            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())


            'Dim cmd As New SqlCommand("_CopiarSaldos", DBConn)

            Dim cmd As SqlCommand = New SqlCommand("_PeriodosCerrar", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            cmd.Parameters.Add(_Empresa)

            Dim _PerID As New SqlParameter("@Periodo", SqlDbType.Int)
            _PerID.Value = PerID
            cmd.Parameters.Add(_PerID)

            Dim _Estado As New SqlParameter("@Estado", SqlDbType.Int)
            _Estado.Value = Estado
            cmd.Parameters.Add(_Estado)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        'Public Shared Function CopiarSaldos(ByVal PerID As String, ByVal PerInicio As String, ByVal PerFinal As String, ByVal MonedaBase As String, ByVal MonedaCambio As String, ByVal Inicio As String, ByVal Final As String, ByVal PerDescripcion As String, ByVal PerAccion As Boolean)
        '    Dim cmd As SqlCommand = New SqlCommand("_CopiarSaldos", DBConnFacturas)
        '    cmd.CommandTimeout = 300

        '    ' Mark the Command as a SPROC
        '    cmd.CommandType = CommandType.StoredProcedure

        '    Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    _Empresa.Value = EmpresaActual
        '    cmd.Parameters.Add(_Empresa)

        '    Dim _PerID As New SqlParameter("@Periodo", SqlDbType.Int)
        '    _PerID.Value = PerID
        '    cmd.Parameters.Add(_PerID)

        '    Dim _PerInicio As New SqlParameter("@Desde", SqlDbType.DateTime, 8)
        '    _PerInicio.Value = PerInicio
        '    cmd.Parameters.Add(_PerInicio)

        '    Dim _PerFinal As New SqlParameter("@Hasta", SqlDbType.DateTime, 8)
        '    _PerFinal.Value = PerFinal
        '    cmd.Parameters.Add(_PerFinal)

        '    Dim _TCuenta As New SqlParameter("@TCuenta", SqlDbType.NVarChar, 1)
        '    _TCuenta.Value = "%"
        '    cmd.Parameters.Add(_TCuenta)

        '    Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar, 100)
        '    _Cuenta.Value = "%"
        '    cmd.Parameters.Add(_Cuenta)

        '    Dim _Nivel As New SqlParameter("@Nivel", SqlDbType.NVarChar, 2)
        '    _Nivel.Value = "03"
        '    cmd.Parameters.Add(_Nivel)

        '    Dim _Monedabase As New SqlParameter("@Monedabase", SqlDbType.NVarChar, 2)
        '    _Monedabase.Value = MonedaBase
        '    cmd.Parameters.Add(_Monedabase)

        '    Dim _MonedaCambio As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar, 2)
        '    _MonedaCambio.Value = MonedaCambio
        '    cmd.Parameters.Add(_MonedaCambio)




        '    Dim _Inicio As SqlParameter = New SqlParameter("@PerInicio", SqlDbType.DateTime, 4)
        '    _Inicio.Value = Inicio
        '    cmd.Parameters.Add(_Inicio)

        '    Dim _Final As SqlParameter = New SqlParameter("@PerFinal", SqlDbType.DateTime, 4)
        '    _Final.Value = Final
        '    cmd.Parameters.Add(_Final)

        '    Dim _PerDescrip As SqlParameter = New SqlParameter("@PerDescrip", SqlDbType.NVarChar, 80)
        '    _PerDescrip.Value = PerDescripcion
        '    cmd.Parameters.Add(_PerDescrip)

        '    Dim _PerAccion As SqlParameter = New SqlParameter("@PerAccion", SqlDbType.Int, 1)
        '    _PerAccion.Value = PerAccion
        '    cmd.Parameters.Add(_PerAccion)





        '    cmd.Connection = DBConnFacturas
        '    cmd.Transaction = transaccionFacturas
        '    cmd.ExecuteNonQuery()

        'End Function
        Public Shared Function CopiarSaldos(ByVal PeriodoCerrado As Integer) As Integer

            Dim cmd As SqlCommand = New SqlCommand("_CopiarSaldos_V2", DBConnFacturas)
            cmd.CommandTimeout = 300

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            cmd.Parameters.Add(_Empresa)

            Dim _PerID As New SqlParameter("@PeriodoCerrado", SqlDbType.Int)
            _PerID.Value = PeriodoCerrado
            cmd.Parameters.Add(_PerID)

            Dim _PeriodoNuevo As New SqlParameter("@PeriodoNuevo", SqlDbType.Int)
            _PeriodoNuevo.Direction = ParameterDirection.Output
            cmd.Parameters.Add(_PeriodoNuevo)


            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            Return _PeriodoNuevo.Value

        End Function
        Public Function GetList2(ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PeriodosList2", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Periodos")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Shared Function Activo(ByVal Fecha As Date) As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PeriodoActivo_Fecha", DBConn)

            ' Mark the Command as a SPROC
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Valor As New SqlParameter("@Valor", SqlDbType.NVarChar, 60)
            _Valor.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(_Valor)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            _Fecha.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

            If _Valor.Value.ToString = "" Or _Valor.Value Is DBNull.Value Then
                Return 0
            Else
                Return _Valor.Value
            End If

        End Function

        'Public Shared Function Activo() As String

        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_PeriodoActivo", DBConn)

        '    ' Mark the Command as a SPROC
        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    ' Add Parameters to SPROC
        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    DBCommand.SelectCommand.Parameters.Add(pEmpresa)

        '    Dim _Valor As New SqlParameter("@Valor", SqlDbType.NVarChar, 60)
        '    _Valor.Direction = ParameterDirection.Output
        '    DBCommand.SelectCommand.Parameters.Add(_Valor)

        '    DBConn.Open()
        '    DBCommand.SelectCommand.ExecuteNonQuery()
        '    DBConn.Close()

        '    If _Valor.Value.ToString = "" Or _Valor.Value Is DBNull.Value Then
        '        Return 0
        '    Else
        '        Return _Valor.Value.ToString
        '    End If

        'End Function

        Public Shared Function Actual() As String

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PeriodoActual", DBConn)

            ' Mark the Command as a SPROC
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Valor As New SqlParameter("@Valor", SqlDbType.NVarChar, 60)
            _Valor.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(_Valor)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

            If _Valor.Value.ToString = "" Or _Valor.Value Is DBNull.Value Then
                Return 0
            Else
                Return _Valor.Value
            End If

        End Function

        Public Shared Function Update(ByVal PerID As String, ByVal PerInicio As String, _
                                ByVal PerFinal As String, ByVal PerDescripcion As String, _
                                ByVal PerActivo As Boolean, ByVal PerAccion As Boolean, ByVal Actual As Integer) As Boolean

            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As New SqlCommand("_PeriodosUpdate", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _PerID As New SqlParameter("@PerID", SqlDbType.NVarChar, 50)
            _PerID.Value = PerID
            cmd.Parameters.Add(_PerID)

            Dim _PerInicio As New SqlParameter("@PerInicio", SqlDbType.DateTime, 8)
            _PerInicio.Value = PerInicio
            cmd.Parameters.Add(_PerInicio)

            Dim _PerFinal As New SqlParameter("@PerFinal", SqlDbType.DateTime, 8)
            _PerFinal.Value = PerFinal
            cmd.Parameters.Add(_PerFinal)

            Dim _PerDescripcion As New SqlParameter("@PerDescripcion", SqlDbType.NVarChar, 50)
            _PerDescripcion.Value = PerDescripcion
            cmd.Parameters.Add(_PerDescripcion)

            Dim _PerActivo As New SqlParameter("@PerActivo", SqlDbType.Int, 1)
            _PerActivo.Value = PerActivo
            cmd.Parameters.Add(_PerActivo)

            Dim _PerAccion As New SqlParameter("@PerAccion", SqlDbType.Int, 1)
            _PerAccion.Value = PerAccion
            cmd.Parameters.Add(_PerAccion)

            Dim _Actual As SqlParameter = New SqlParameter("@Actual", SqlDbType.Int)
            _Actual.Value = Actual
            cmd.Parameters.Add(_Actual)

            Try
                cmd.Connection = DBConn
                DBConn.Open()
                cmd.ExecuteNonQuery()
                DBConn.Close()
                Return True
            Catch
                Return False
            End Try
        End Function

        Public Function AddItem(ByVal PerInicio As String, ByVal PerFinal As String, _
                                ByVal PerDescripcion As String, ByVal PerAccion As Boolean, ByVal Actual As Integer)

            'Dim DBConn As SqlConnection
            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_PeriodosAdd", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure

            Dim _PerInicio As SqlParameter = New SqlParameter("@PerInicio", SqlDbType.DateTime, 4)
            _PerInicio.Value = PerInicio
            cmd.Parameters.Add(_PerInicio)

            Dim _PerFinal As SqlParameter = New SqlParameter("@PerFinal", SqlDbType.DateTime, 4)
            _PerFinal.Value = PerFinal
            cmd.Parameters.Add(_PerFinal)

            Dim _PerDescrip As SqlParameter = New SqlParameter("@PerDescrip", SqlDbType.NVarChar, 80)
            _PerDescrip.Value = PerDescripcion
            cmd.Parameters.Add(_PerDescrip)

            Dim _PerAccion As SqlParameter = New SqlParameter("@PerAccion", SqlDbType.Int, 1)
            _PerAccion.Value = PerAccion
            cmd.Parameters.Add(_PerAccion)

            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            _Empresa.Value = EmpresaActual
            cmd.Parameters.Add(_Empresa)

            Dim _Actual As SqlParameter = New SqlParameter("@Actual", SqlDbType.Int)
            _Actual.Value = Actual
            cmd.Parameters.Add(_Actual)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            'cmd.Connection = DBConn
            'DBConn.Open()
            'cmd.ExecuteNonQuery()
            'DBConn.Close()

        End Function


        Public Function GetLista() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PeriodosList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            Try
                DBCommand.Fill(dsFicha, "Periodos")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return dsFicha

        End Function


        Public Shared Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodos", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)

            Try
                DBCommand.Fill(dsFicha, "Periodos")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return dsFicha

        End Function

        Public Shared Function GetDetails(ByVal Periodo As String) As PeriodoDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsHorario As New DataSet
            Dim Details As New PeriodoDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodosDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Periodo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsHorario, "Periodo")

            If dsHorario.Tables("Periodo").Rows.Count = 1 Then
                Details.ID = dsHorario.Tables("Periodo").Rows(0).Item("per_id").ToString
                Details.Descripcion = dsHorario.Tables("Periodo").Rows(0).Item("Per_Descripcion").ToString
                Details.Inicio = dsHorario.Tables("Periodo").Rows(0).Item("Per_Inicio").ToString
                Details.Final = dsHorario.Tables("Periodo").Rows(0).Item("per_Final").ToString
                Details.Activo = dsHorario.Tables("Periodo").Rows(0).Item("per_activo").ToString
                Details.Accion = dsHorario.Tables("Periodo").Rows(0).Item("per_accion").ToString
                Details.Estado = dsHorario.Tables("Periodo").Rows(0).Item("Per_Estado").ToString
                Details.Actual = dsHorario.Tables("Periodo").Rows(0).Item("Per_Actual")
            Else
                Details.Descripcion = ""
            End If

            Return Details

        End Function

        Public Shared Function GetFechas(ByVal Parte As Integer) As Date

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetPeriodosFechas", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Inicio", SqlDbType.SmallDateTime)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Final", SqlDbType.SmallDateTime)

            pIdent.Direction = ParameterDirection.Output
            pIdent2.Value = EmpresaActual
            pIdent3.Direction = ParameterDirection.Output

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                If Parte = 0 Then 'Inicio
                    Return pIdent.Value
                Else
                    Return pIdent3.Value
                End If
            Catch ex As Exception
                MsgBox("Error al requerir el rango de fechas de los periodos activos", MsgBoxStyle.Critical, "STS-Contab")
                Return Now
            End Try
            DBConn.Close()

        End Function
        Public Shared Function GetFechas(ByVal Parte As String) As Date

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetPeriodosFechasOperacion", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Inicio", SqlDbType.SmallDateTime)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Final", SqlDbType.SmallDateTime)

            pIdent.Direction = ParameterDirection.Output
            pIdent2.Value = EmpresaActual
            pIdent3.Direction = ParameterDirection.Output

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                If Parte = "0" Then 'Inicio
                    Return pIdent.Value
                Else
                    Return pIdent3.Value
                End If
            Catch ex As Exception
                MsgBox("Error al requerir el rango de fechas de los periodos que se han trabajado", MsgBoxStyle.Critical, "STS-Contab")
                Return Now
            End Try
            DBConn.Close()

        End Function
    End Class
End Namespace