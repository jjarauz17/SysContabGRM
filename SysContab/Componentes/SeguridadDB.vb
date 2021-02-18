Imports System
Imports DbConnect
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class LoginDetailsDB
        Public Empresa As String
        Public UserID As String
        Public Role As String
    End Class


    Public Class SeguridadDB

        Public Shared Function UsuarioRecursos1(ByVal UserID As Integer, ByVal Modulo As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_UsuarioRecursos1", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Usuario As New SqlParameter("@Usuario", SqlDbType.Int)
            _Usuario.Value = UserID
            DBCommand.SelectCommand.Parameters.Add(_Usuario)

            Dim _Modulo As New SqlParameter("@Modulo", SqlDbType.Int)
            _Modulo.Value = Modulo
            DBCommand.SelectCommand.Parameters.Add(_Modulo)

            DBCommand.Fill(dsFicha, "Menu")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function UsuarioMenu(ByVal UserID As Integer, ByVal Modulo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_UsuarioMenu", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Usuario As New SqlParameter("@Usuario", SqlDbType.Int)
            _Usuario.Value = UserID
            DBCommand.SelectCommand.Parameters.Add(_Usuario)

            Dim _Modulo As New SqlParameter("@Modulo", SqlDbType.NVarChar)
            _Modulo.Value = Modulo
            DBCommand.SelectCommand.Parameters.Add(_Modulo)

            DBCommand.Fill(dsFicha, "Menu")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Sub RolesMenuAdd(ByVal RolID As Integer, ByVal MenuID As Integer, _
                                                ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)

            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_RolesMenuAdd", dbConn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@MenuID", SqlDbType.Int)
            Param.Value = MenuID
            cmd.Parameters.Add(Param)

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.Int)
            pModulo.Value = 2
            cmd.Parameters.Add(pModulo)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()
        End Sub

        Public Shared Sub RolesMenuBorrar(ByVal RolID As Integer, _
                                      ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)


            Dim dsFicha As New DataSet()
            Dim cmd As SqlCommand = New SqlCommand("_RolesMenuDelete", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.Int)
            pModulo.Value = 2
            cmd.Parameters.Add(pModulo)
            'DBCommand.SelectCommand.Parameters.Add(pModulo)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Function MenuRecursos(ByVal RolID As Integer, ByVal Menu As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RolesMenuRecurso", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pRol As New SqlParameter("@RolID", SqlDbType.Int)
            pRol.Value = RolID
            DBCommand.SelectCommand.Parameters.Add(pRol)

            Dim pMenu As New SqlParameter("@Menu", SqlDbType.Int)
            pMenu.Value = Menu
            DBCommand.SelectCommand.Parameters.Add(pMenu)

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.Int)
            pModulo.Value = 2
            DBCommand.SelectCommand.Parameters.Add(pModulo)

            DBCommand.Fill(dsFicha, "Menu")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function MenuPrincipal(ByVal Nivel As Integer, ByVal Menu As Integer, ByVal Rol As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Menu", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Nivel As New SqlParameter("@Nivel", SqlDbType.Int)
            _Nivel.Value = Nivel
            DBCommand.SelectCommand.Parameters.Add(_Nivel)

            Dim _Menu As New SqlParameter("@Menu", SqlDbType.Int)
            _Menu.Value = Menu
            DBCommand.SelectCommand.Parameters.Add(_Menu)

            Dim _Rol As New SqlParameter("@Rol", SqlDbType.Int)
            _Rol.Value = Rol
            DBCommand.SelectCommand.Parameters.Add(_Rol)

            DBCommand.Fill(dsFicha, "Menu")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Sub RolesAccionesAdd(ByVal RolID As Integer, ByVal AccionID As Integer, _
                                                ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)

            Dim dsFicha As New DataSet()
            Dim cmd As SqlCommand = New SqlCommand("_RolesAccionesAdd", dbConn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@AccionID", SqlDbType.Int)
            Param.Value = AccionID
            cmd.Parameters.Add(Param)

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.Int)
            pModulo.Value = 2
            cmd.Parameters.Add(pModulo)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()
        End Sub

        Public Shared Sub RolesAccionesBorrar(ByVal RolID As Integer, _
                                      ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)

            Dim dsFicha As New DataSet()
            Dim cmd As SqlCommand = New SqlCommand("_RolesAccionesDelete", dbConn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.Int)
            pModulo.Value = 2
            cmd.Parameters.Add(pModulo)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Sub

        Public Shared Function Menu() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_MenuList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Modulo As New SqlParameter("@Modulo", SqlDbType.Int)
            _Modulo.Value = 2
            DBCommand.SelectCommand.Parameters.Add(_Modulo)

            DBCommand.Fill(dsFicha, "Menu")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function UsuarioAcciones(ByVal UserID As Integer, ByVal Recurso As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_UsuarioAcciones", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Usuario As New SqlParameter("@Usuario", SqlDbType.Int)
            _Usuario.Value = UserID
            DBCommand.SelectCommand.Parameters.Add(_Usuario)

            Dim _Recurso As New SqlParameter("@Recurso", SqlDbType.NVarChar)
            _Recurso.Value = Recurso
            DBCommand.SelectCommand.Parameters.Add(_Recurso)

            DBCommand.Fill(dsFicha, "Usuarios")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function RecursosAcciones(ByVal Nivel As Integer, ByVal Accion As Integer, ByVal Recurso As Integer, ByVal Rol As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RecursosAcciones", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Nivel As New SqlParameter("@Nivel", SqlDbType.Int)
            _Nivel.Value = Nivel
            DBCommand.SelectCommand.Parameters.Add(_Nivel)

            Dim _Accion As New SqlParameter("@Accion", SqlDbType.Int)
            _Accion.Value = Accion
            DBCommand.SelectCommand.Parameters.Add(_Accion)

            Dim _Recurso As New SqlParameter("@Recurso", SqlDbType.Int)
            _Recurso.Value = Recurso
            DBCommand.SelectCommand.Parameters.Add(_Recurso)

            Dim _Rol As New SqlParameter("@Rol", SqlDbType.Int)
            _Rol.Value = Rol
            DBCommand.SelectCommand.Parameters.Add(_Rol)

            DBCommand.Fill(dsFicha, "Usuarios")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function UsuarioRecursos(ByVal UserID As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_UsuarioRecursos", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Usuario As New SqlParameter("@Usuario", SqlDbType.Int)
            _Usuario.Value = UserID
            DBCommand.SelectCommand.Parameters.Add(_Usuario)

            DBCommand.Fill(dsFicha, "Usuarios")
            DBConn.Close()

            Return dsFicha

        End Function


        Public Shared Sub UsuariosEmpresasBorrar(ByVal UsrID As Integer, _
                                             ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)            
            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_UsuariosEmpresasDelete", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@UsrID", SqlDbType.Int)
            Param.Value = UsrID
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()
        End Sub


        Public Shared Sub UsuariosRolesBorrar(ByVal UsrID As Integer, _
                                             ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)
            Dim dsFicha As New DataSet()

            Dim cmd As SqlCommand = New SqlCommand("_UsuariosRolesDelete", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@UsrID", SqlDbType.Int)
            Param.Value = UsrID
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Sub


        Public Shared Sub UsuariosUpdate(ByVal UsrID As Integer, ByVal Nombre As String, ByVal Login As String,
                                              ByVal Password As String, ByVal Email As String, ByVal Habilitado As Boolean,
                                              ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction,
                                              Cargo As String, Telefono As String,
                                              Optional ByVal Rol As Integer = 0, Optional ByVal Centro As String = "",
                                              Optional Bodega As String = "")
            'Dim dsFicha As New DataSet()
            Dim cmd As SqlCommand = New SqlCommand("_UsuariosUpdate", dbConn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@UserID", SqlDbType.Int)
            Param.Value = UsrID
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Param.Value = Nombre
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Login", SqlDbType.NVarChar)
            Param.Value = Login
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Password", SqlDbType.NVarChar)
            Param.Value = Password
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Email", SqlDbType.NVarChar)
            Param.Value = Email
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Habilitado", SqlDbType.Bit)
            Param.Value = Habilitado
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Rol", SqlDbType.Int)
            Param.Value = Rol
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Centro", SqlDbType.NVarChar)
            Param.Value = Centro
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Bodega", SqlDbType.NVarChar)
            Param.Value = Bodega
            cmd.Parameters.Add(Param)

            cmd.Parameters.AddWithValue("@Cargo", Cargo)
            cmd.Parameters.AddWithValue("@Telefono", Telefono)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()
        End Sub


        Public Shared Function GetUsuario(ByVal UserID As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_UsuarioGetDetalle", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pUserID As New SqlParameter("@UserID", SqlDbType.Int)
            pUserID.Value = UserID
            DBCommand.SelectCommand.Parameters.Add(pUserID)

            DBCommand.Fill(dsFicha, "Usuarios")
            DBConn.Close()


            DBCommand = New SqlDataAdapter("_UsuariosRolesxUserID", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pRol As New SqlParameter("@UserID", SqlDbType.Int)
            pRol.Value = UserID
            DBCommand.SelectCommand.Parameters.Add(pRol)

            DBCommand.Fill(dsFicha, "UsuariosRoles")
            DBConn.Close()


            DBCommand = New SqlDataAdapter("_UsuariosEmpresasxUserID", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmp As New SqlParameter("@UserID", SqlDbType.Int)
            pEmp.Value = UserID
            DBCommand.SelectCommand.Parameters.Add(pEmp)

            DBCommand.Fill(dsFicha, "UsuariosEmpresas")
            DBConn.Close()

            Return dsFicha

        End Function


        Public Shared Sub UsuariosBorrar(ByVal UserID As Integer)
            Dim DBConn As SqlConnection            
            Dim dsFicha As New DataSet()
            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_UsuariosDelete", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@UserID", SqlDbType.Int)
            Param.Value = UserID
            cmd.Parameters.Add(Param)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()


        End Sub


        Public Shared Function GetUsuariosList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_UsuariosList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Tabla")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function Login(ByVal UserName As String, _
                                    ByVal Password As String) As LoginDetailsDB

            ' Create Instance of Connection and Command Object
            Dim Conn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            Conn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As New SqlCommand("_UsuariosLogin", Conn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Login As SqlParameter = New SqlParameter("@UsrLogin", SqlDbType.NVarChar, 50)
            _Login.Value = UserName
            cmd.Parameters.Add(_Login)

            Dim _Password As SqlParameter = New SqlParameter("@UsrPassword", SqlDbType.NVarChar, 50)
            _Password.Value = Password
            cmd.Parameters.Add(_Password)

            Dim UserID As SqlParameter = New SqlParameter("@UserID", SqlDbType.NVarChar, 50)
            UserID.Direction = ParameterDirection.Output
            cmd.Parameters.Add(UserID)

            Dim Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.NVarChar, 50)
            Empresa.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Empresa)

            Dim Rol As SqlParameter = New SqlParameter("@Rol", SqlDbType.NVarChar, 50)
            Rol.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Rol)


            Conn.Open()
            cmd.ExecuteNonQuery()
            Conn.Close()

            Dim Det As New LoginDetailsDB

            If UserID.Value Is DBNull.Value Then
                Det.UserID = String.Empty
            Else
                Det.UserID = CStr(UserID.Value)
            End If

            If Empresa.Value Is DBNull.Value Then
                Det.Empresa = String.Empty
            Else
                Det.Empresa = CStr(Empresa.Value)
            End If

            If Rol.Value Is DBNull.Value Then
                Det.Role = String.Empty
            Else
                Det.Role = CStr(Rol.Value)
            End If

            Return Det

        End Function

        Public Shared Function GetLogin(ByVal UserName As String,
                                    ByVal UserPassword As String) As DataTable

            Return ObtieneDatos("JAR_GetUsuario", UserName, UserPassword)
        End Function

        Public Shared Function GetLogin(ByVal UserName As String) As DataTable

            Return ObtieneDatos("sp_sel_Usuarios", UserName)

        End Function


        Public Shared Sub UsuariosRolesAdd(ByVal RolID As Integer, ByVal UsrID As Integer, _
                                               ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)

            Dim dsFicha As New DataSet

            Dim cmd As SqlCommand = New SqlCommand("_UsuariosRolesAdd", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@UsrID", SqlDbType.Int)
            Param.Value = UsrID
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Sub


        Public Shared Sub UsuarioEmpresasAdd(ByVal UserID As Integer, ByVal EmpresaID As String, _
                               ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)
            Dim dsFicha As New DataSet

            Dim cmd As SqlCommand = New SqlCommand("_UsuariosEmpresasAdd", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@UserID", SqlDbType.Int)
            Param.Value = UserID
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@EmpresaID", SqlDbType.Int)
            Param.Value = EmpresaID
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Sub


        Public Shared Function UsuariosAdd(ByVal Login As String, ByVal Nombre As String,
                                           ByVal Password As String, ByVal Email As String,
                                           ByVal Habilitado As Boolean, Cargo As String, Telefono As String,
                                           ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction,
                                           Optional ByVal Rol As Integer = 0) As String

            Dim dt As New DataTable

            Dim cmd As SqlDataAdapter = New SqlDataAdapter("_UsuariosAdd", dbConn)
            cmd.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Param.Value = Nombre
            cmd.SelectCommand.Parameters.Add(Param)

            Param = New SqlParameter("@Login", SqlDbType.NVarChar)
            Param.Value = Login
            cmd.SelectCommand.Parameters.Add(Param)

            Param = New SqlParameter("@Password", SqlDbType.NVarChar)
            Param.Value = Password
            cmd.SelectCommand.Parameters.Add(Param)

            Param = New SqlParameter("@Email", SqlDbType.NVarChar)
            Param.Value = Email
            cmd.SelectCommand.Parameters.Add(Param)

            Param = New SqlParameter("@Habilitado", SqlDbType.Bit)
            Param.Value = Habilitado
            cmd.SelectCommand.Parameters.Add(Param)

            'Param = New SqlParameter("@UserID", SqlDbType.Int)
            'Param.Direction = ParameterDirection.Output
            'cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Rol", SqlDbType.Int)
            Param.Value = Rol
            cmd.SelectCommand.Parameters.Add(Param)

            cmd.SelectCommand.Parameters.AddWithValue("@Cargo", Cargo)
            cmd.SelectCommand.Parameters.AddWithValue("@Telefono", Telefono)

            cmd.SelectCommand.Connection = dbConn
            cmd.SelectCommand.Transaction = Transaccion
            cmd.Fill(dt)

            'cmd.Connection = dbConn
            'cmd.Transaction = Transaccion
            'cmd.ExecuteNonQuery()
            'da = New SqlDataAdapter(cmd)

            '
            If dt.Rows.Count > 0 Then
                Return dt.Rows.Item(0)("Usr_Id")
            Else
                Return 0
            End If

            'If Not Param.Value Is DBNull.Value Then
            '    Return Param.Value
            'Else
            '    Return 0
            'End If
        End Function



        Public Shared Function GetRolesActivos() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RolesGetListHabilitado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Tabla")
            DBConn.Close()

            Return dsFicha

        End Function


        Public Shared Function RolesRecursosBorrar(ByVal RolID As Integer, _
                                              ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim cmd As SqlCommand = New SqlCommand("_RolesRecurosDelete", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.Int)
            pModulo.Value = 2
            cmd.Parameters.Add(pModulo)
            'DBCommand.SelectCommand.Parameters.Add(pModulo)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Function


        Public Shared Function RolesUpdate(ByVal RolID As Integer, ByVal Nombre As String, ByVal Descripcion As String, ByVal Habilitado As Boolean, _
                                        ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction) As String
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim cmd As SqlCommand = New SqlCommand("_RolesUpdate", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Param.Value = Nombre
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Param.Value = Descripcion
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Habilitado", SqlDbType.Bit)
            Param.Value = Habilitado
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

        End Function


        Public Shared Function GetRol(ByVal RolID As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_RolesGetRol", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pRolID As New SqlParameter("@RolID", SqlDbType.Int)
            pRolID.Value = RolID
            DBCommand.SelectCommand.Parameters.Add(pRolID)

            DBCommand.Fill(dsFicha, "Roles")
            DBConn.Close()

            DBCommand = New SqlDataAdapter("_RolesGetRolRecurso", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pRol As New SqlParameter("@RolID", SqlDbType.Int)
            pRol.Value = RolID
            DBCommand.SelectCommand.Parameters.Add(pRol)

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.Int)
            pModulo.Value = 2
            DBCommand.SelectCommand.Parameters.Add(pModulo)

            DBCommand.Fill(dsFicha, "RolesRecursos")
            DBConn.Close()

            Return dsFicha

        End Function



        Public Shared Function RolesBorrar(ByVal RolID As Integer)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_RolesDelete", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()


        End Function



        Public Shared Function GetLisRoles() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            DBCommand = New SqlDataAdapter("_RolesGetList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()
            Return dsFicha
        End Function

        Public Shared Function RolesRecursosAdd(ByVal RolID As Integer, ByVal ResID As Integer, _
                                                ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction)

            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim cmd As SqlCommand = New SqlCommand("_RolesRecursosAdd", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Value = RolID
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@ResID", SqlDbType.Int)
            Param.Value = ResID
            cmd.Parameters.Add(Param)

            Dim pModulo As New SqlParameter("@Modulo", SqlDbType.Int)
            pModulo.Value = 2
            cmd.Parameters.Add(pModulo)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()
        End Function


        Public Shared Function RolesAdd(ByVal Nombre As String, ByVal Descripcion As String, ByVal Habilitado As Boolean, _
                                        ByVal dbConn As SqlConnection, ByVal Transaccion As SqlTransaction) As String
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim cmd As SqlCommand = New SqlCommand("_RolesAdd", dbConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim Param As SqlParameter

            Param = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            Param.Value = Nombre
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Param.Value = Descripcion
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@Habilitado", SqlDbType.Bit)
            Param.Value = Habilitado
            cmd.Parameters.Add(Param)

            Param = New SqlParameter("@RolID", SqlDbType.Int)
            Param.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Param)

            cmd.Connection = dbConn
            cmd.Transaction = Transaccion
            cmd.ExecuteNonQuery()

            If Not Param.Value Is DBNull.Value Then
                Return Param.Value
            Else
                Return 0
            End If


        End Function



        Public Shared Function GetLisRecursos() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            DBCommand = New SqlDataAdapter("_RecursosGetList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()
            Return dsFicha
        End Function

        Public Shared Function DeshabilitarUsuario(ID As Integer) As Boolean
            Dim conn As New Connect(VB.SysContab.Rutinas.AbrirConexion)
            conn.AddParameter("Usr_Id", SqlDbType.Int, 4, ParameterDirection.Input, ID)

            Try
                conn.EjecutarComando("sp_Deshabilitar_Usuario")

                Return True
            Catch ex As Exception
                XtraMsg("ERROR: " & ex.Message, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

    End Class

End Namespace