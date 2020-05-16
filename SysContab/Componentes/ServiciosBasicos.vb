

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab
    Public Class ServiciosBasicosDetail
        Public Basico_ID As Integer
        Public Consecutivo_ID As Integer
        Public Descripcion As String
        Public CuentaIVA As String
        Public CuentaProvision As String
        Public CuentaIR As String
    End Class
    Public Class ServiciosBasicos
        Public Shared Function AnularFactura(ByVal Factura As String, ByVal Proveedor As Integer) As Integer

            Dim cmd As SqlCommand = New SqlCommand("_AnularFacturaSB", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int)
            Dim _Proveedor As SqlParameter = New SqlParameter("@proveedor", SqlDbType.Int)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Int)


            _Factura.Value = Factura
            _Empresa.Value = EmpresaActual
            _Proveedor.Value = Proveedor
            _Cantidad.Direction = ParameterDirection.Output

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Empresa)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Cantidad)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            Return _Cantidad.Value

        End Function
        Public Shared Function Buscar(ByVal Basico As Integer, ByVal Consecutivo As Integer) As Boolean
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ServiciosBasicosBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pBasico_ID As New SqlParameter("@Basico_ID", SqlDbType.Int)
            pBasico_ID.Value = Basico
            DBCommand.SelectCommand.Parameters.Add(pBasico_ID)

            Dim pConsecutivo As New SqlParameter("@Consecutivo_ID", SqlDbType.Int)
            pConsecutivo.Value = Consecutivo
            DBCommand.SelectCommand.Parameters.Add(pConsecutivo)

            Dim pExiste As New SqlParameter("@Existe", SqlDbType.Bit)
            pExiste.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(pExiste)

            Try
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Return True
            End Try
            Return pExiste.Value

        End Function
        Public Shared Function GetDetails(ByVal Basico_ID As Integer, ByVal Consecutivo_ID As Integer) As ServiciosBasicosDetail
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim detalle As New VB.SysContab.ServiciosBasicosDetail

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ServiciosBasicosGetDetails", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pBasico_ID As New SqlParameter("@Basico_ID", SqlDbType.NVarChar)
            pBasico_ID.Value = Basico_ID
            DBCommand.SelectCommand.Parameters.Add(pBasico_ID)

            Dim pFiltro As New SqlParameter("@Consecutivo_ID", SqlDbType.NVarChar)
            pFiltro.Value = Consecutivo_ID
            DBCommand.SelectCommand.Parameters.Add(pFiltro)

            Try
                DBCommand.Fill(dsFicha, "Tablas")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If dsFicha.Tables(0).Rows.Count = 1 Then
                detalle.Basico_ID = dsFicha.Tables(0).Rows(0)("Basico_ID")
                detalle.Consecutivo_ID = dsFicha.Tables(0).Rows(0)("Consecutivo_ID")
                detalle.CuentaIVA = dsFicha.Tables(0).Rows(0)("ser_cuentaprovision").ToString
                detalle.CuentaProvision = dsFicha.Tables(0).Rows(0)("ser_cuentagasto").ToString
                detalle.CuentaIR = dsFicha.Tables(0).Rows(0)("ser_ctair").ToString
                detalle.Descripcion = dsFicha.Tables(0).Rows(0)("ser_descripcion").ToString
            End If
            Return detalle

        End Function
        Public Shared Function GetList(ByVal Filtro As String, ByVal Basico_ID As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ServiciosBasicosList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pFiltro As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            pFiltro.Value = Filtro
            DBCommand.SelectCommand.Parameters.Add(pFiltro)

            Dim pBasico_ID As New SqlParameter("@Basico_ID", SqlDbType.NVarChar)
            pBasico_ID.Value = Basico_ID
            DBCommand.SelectCommand.Parameters.Add(pBasico_ID)

            Try
                DBCommand.Fill(dsFicha, "Tablas")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return dsFicha

        End Function
        Public Shared Function GetList(ByVal Filtrar As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_SB_Disponibles", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pFiltrar As New SqlParameter("@Filtrar", SqlDbType.Int)
            pFiltrar.Value = Filtrar
            DBCommand.SelectCommand.Parameters.Add(pFiltrar)

            Try
                DBCommand.Fill(dsFicha, "Tablas")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return dsFicha

        End Function


        Public Shared Function VerificarServicios() As String

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ServiciosBasicosVerificar", DBConn)

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

            If _Valor.Value.ToString() <> "" Then
                Return 1
            Else
                Return 0
            End If


        End Function


        Public Shared Function Actualizar(ByVal CuentaAgua As String, ByVal CuentaLuz As String, _
                                   ByVal CuentaTel As String, ByVal CuentaCel As String, _
                                   ByVal CuentaCable As String, ByVal CuentaBasura As String) As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                'UpdateServiciosTrans(CuentaAgua, 1)
                'UpdateServiciosTrans(CuentaLuz, 2)
                'UpdateServiciosTrans(CuentaTel, 3)
                'UpdateServiciosTrans(CuentaCel, 4)
                'UpdateServiciosTrans(CuentaCable, 5)
                'UpdateServiciosTrans(CuentaBasura, 6)
                VB.SysContab.Rutinas.okTransaccion()

                Return 1

            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)

                Return 0

            End Try

        End Function


        Public Shared Sub UpdateServiciosTrans(ByVal Basico_ID As Integer, ByVal Consecutivo_ID As Integer, _
            ByVal Ser_Descripcion As String, ByVal CuentaProvision As String, ByVal CuentaGasto As String, _
            ByVal Ser_CuentaIR As String)

            Dim conexion As New VB.SysContab.Rutinas

            Dim cmd As New SqlCommand("_ServiciosBasicosUpdateItem", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim pBasico_ID As New SqlParameter("@Basico_ID", SqlDbType.Int)
            pBasico_ID.Value = Basico_ID
            cmd.Parameters.Add(pBasico_ID)

            Dim pConsecutivo_ID As New SqlParameter("@Consecutivo_ID", SqlDbType.Int)
            pConsecutivo_ID.Value = Consecutivo_ID
            cmd.Parameters.Add(pConsecutivo_ID)

            Dim pDescripcion As New SqlParameter("@Ser_Descripcion", SqlDbType.NVarChar, 100)
            pDescripcion.Value = Ser_Descripcion
            cmd.Parameters.Add(pDescripcion)

            Dim pCuentaProvision As New SqlParameter("@CuentaProvision", SqlDbType.NVarChar, 64)
            pCuentaProvision.Value = CuentaProvision
            cmd.Parameters.Add(pCuentaProvision)

            Dim pCuentaGasto As New SqlParameter("@CuentaGasto", SqlDbType.NVarChar, 64)
            pCuentaGasto.Value = CuentaGasto
            cmd.Parameters.Add(pCuentaGasto)

            Dim pCuentaIR As New SqlParameter("@CuentaIR", SqlDbType.NVarChar, 64)
            pCuentaIR.Value = Ser_CuentaIR
            cmd.Parameters.Add(pCuentaIR)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()


        End Sub



        Public Shared Function Guardar(ByVal CuentaAgua As String, ByVal CuentaLuz As String, _
                                    ByVal CuentaTel As String, ByVal CuentaCel As String, _
                                    ByVal CuentaCable As String, ByVal CuentaBasura As String) As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                'AddServiciosTrans(CuentaAgua, 1)
                'AddServiciosTrans(CuentaLuz, 2)
                'AddServiciosTrans(CuentaTel, 3)
                'AddServiciosTrans(CuentaCel, 4)
                'AddServiciosTrans(CuentaCable, 5)
                'AddServiciosTrans(CuentaBasura, 6)
                'VB.SysContab.Rutinas.okTransaccion()
                Return 1
            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)
                Return 0

            End Try


        End Function



        '*******************************************************
        ' Objetivo: Agrega un servicio basico en transaccion
        ' Autor: Bernardo Robelo
        ' Fecha: 1/Feb/2006
        'Esta version se anulo para dar cabida a  una nueva estructura
        '*******************************************************
        '*******************************************************
        ' Objetivo: Agrega un servicio basico en transaccion
        ' Autor: ROSA MARIA PORRAS ROJAS (RTG)
        ' Fecha: 20/Jun/2007
        '*******************************************************

        Public Shared Sub AddServiciosTrans(ByVal Basico_ID As Integer, ByRef Consecutivo_ID As Integer, _
            ByVal Ser_Descripcion As String, ByVal CuentaProvision As String, ByVal CuentaGasto As String, _
            ByVal Ser_CuentaIR As String)

            Dim conexion As New VB.SysContab.Rutinas

            Dim cmd As New SqlCommand("_ServiciosBasicosAddItem", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim pBasico_ID As New SqlParameter("@Basico_ID", SqlDbType.Int)
            pBasico_ID.Value = Basico_ID
            cmd.Parameters.Add(pBasico_ID)

            Dim pConsecutivo_ID As New SqlParameter("@Consecutivo_ID", SqlDbType.Int)
            pConsecutivo_ID.Value = Consecutivo_ID
            pConsecutivo_ID.Direction = ParameterDirection.InputOutput
            cmd.Parameters.Add(pConsecutivo_ID)

            Dim pDescripcion As New SqlParameter("@Ser_Descripcion", SqlDbType.NVarChar, 100)
            pDescripcion.Value = Ser_Descripcion
            cmd.Parameters.Add(pDescripcion)

            Dim pCuentaProvision As New SqlParameter("@CuentaProvision", SqlDbType.NVarChar, 64)
            pCuentaProvision.Value = CuentaProvision
            cmd.Parameters.Add(pCuentaProvision)

            Dim pCuentaGasto As New SqlParameter("@CuentaGasto", SqlDbType.NVarChar, 64)
            pCuentaGasto.Value = CuentaGasto
            cmd.Parameters.Add(pCuentaGasto)

            Dim pCuentaIR As New SqlParameter("@CuentaIR", SqlDbType.NVarChar, 64)
            pCuentaIR.Value = Ser_CuentaIR
            cmd.Parameters.Add(pCuentaIR)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            Consecutivo_ID = pConsecutivo_ID.Value
        End Sub






    End Class



End Namespace