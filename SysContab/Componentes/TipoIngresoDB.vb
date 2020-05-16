Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class TipoIngresoDetails
        Public Empresa As String
        Public Codigo As String
        Public Descripcion As String
        Public Tipo As String
        Public Editable As Boolean
        Public Borrable As Boolean
        Public Gravable As Boolean
        Public GINSS As Boolean
        Public CtaContable As String
    End Class

    Public Class TipoIngresoDB

        
        Public Function GetDetails(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim Details As New TipoIngresoDetails()

            Dim conexion As New VB.SysContab.RutinasNomina()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoIngresoDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "TipoIngreso")

            If dsFicha.Tables("TipoIngreso").Rows.Count = 1 Then

                Details.Empresa = dsFicha.Tables("TipoIngreso").Rows(0).Item("empr_codigo")
                Details.Codigo = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_codigo")
                Details.Descripcion = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_descripcion")
                Details.Tipo = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdm_codigo")
                Details.Borrable = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_borrable")
                Details.Editable = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_editable")
                Details.Gravable = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_gravable")
                Details.GINSS = dsFicha.Tables("TIPOINGRESO").Rows(0).Item("TDI_GRAVINSS")
                Details.CtaContable = dsFicha.Tables("TipoIngreso").Rows(0).Item("tdi_ctacontable")

            End If

            Return Details

        End Function

        Public Function GetList(ByVal Filtro As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoIngreso", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Filtro", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Filtro
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "TipoIngreso")

            DBConn.Close()

            Return dsFicha


        End Function

        Public Function GetListCodigo(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoIngresoCodigo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "TipoIngreso")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet

            'Revisar los datos de busqueda y donde se utilizan.
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.RutinasNomina()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoIngresoBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "TipoIngreso")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigoNvo() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.RutinasNomina()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListTipoIngresoCodigoNvo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pIdent)


            DBCommand.Fill(dsFicha, "TipoIngreso")

            DBConn.Close()

            If dsFicha.Tables("TipoIngreso").Rows(0).Item("CODIGO") Is DBNull.Value Then
                Return "001"
            Else
                Return dsFicha.Tables("TipoIngreso").Rows(0).Item("CODIGO")
            End If


        End Function


        Public Function Delete(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.RutinasNomina()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoIngresoDelete", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBConn.Open()
            DBCommand.SelectCommand.ExecuteNonQuery()
            DBConn.Close()

        End Function

        Public Function AddItem(ByVal Codigo As String, ByVal Descripcion As String, ByVal Tipo As String, _
            ByVal Editable As Boolean, ByVal Borrable As Boolean, ByVal Gravable As Boolean, ByVal GINSS As Boolean, _
            ByVal Cuenta As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.RutinasNomina()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoIngresoAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Editable", SqlDbType.Bit)
            Dim pIdent6 As New SqlParameter("@Borrable", SqlDbType.Bit)
            Dim pIdent7 As New SqlParameter("@Gravable", SqlDbType.Bit)
            Dim pIdent8 As New SqlParameter("@GINSS", SqlDbType.Bit)
            Dim pIdent9 As New SqlParameter("@CtaContable", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Descripcion
            pIdent4.Value = Tipo
            pIdent5.Value = Editable
            pIdent6.Value = Borrable
            pIdent7.Value = Gravable
            pIdent8.Value = GINSS
            pIdent9.Value = Cuenta

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function



        Public Function Update(ByVal Codigo As String, ByVal Cuenta As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoIngresoUpdateCuenta", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@CtaContable", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent7.Value = Cuenta

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function




        Public Function Update(ByVal Codigo As String, ByVal Descripcion As String, ByVal Tipo As String, _
            ByVal Gravable As Boolean, ByVal GINSS As Boolean, ByVal Cuenta As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.RutinasNomina
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoIngresoUpdate", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Gravable", SqlDbType.Bit)
            Dim pIdent6 As New SqlParameter("@Ginss", SqlDbType.Bit)
            Dim pIdent7 As New SqlParameter("@CtaContable", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Descripcion
            pIdent4.Value = Tipo
            pIdent5.Value = Gravable
            pIdent6.Value = GINSS
            pIdent7.Value = Cuenta

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)

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
