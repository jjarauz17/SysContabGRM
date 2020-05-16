Imports DbConnect

Namespace VB.SysContab
    Public Class RubrosGastosDB
        Public Shared Sub Asignacion_Add(ByVal Activo As String, ByVal Empleado As String, ByVal CentroCosto As Integer, ByVal FechaEfectiva As Date)
            Dim v As New Connect(Rutinas.AbrirConexion())
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Af_codigo", SqlDbType.NVarChar, 16, ParameterDirection.Input, Activo)
            v.AddParameter("Empleado", SqlDbType.NVarChar, 8, ParameterDirection.Input, Empleado)
            v.AddParameter("centrocosto", SqlDbType.Int, 5, ParameterDirection.Input, CentroCosto)
            v.AddParameter("fechaefectiva", SqlDbType.SmallDateTime, 16, ParameterDirection.Input, FechaEfectiva)
            Try
                v.EjecutarComando("AF_Asignacion_Add")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Function Asignacion_Listar(ByVal Activo As String, ByVal Valido As String) As DataTable
            Dim v As New Connect(Rutinas.AbrirConexion())
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Activo", SqlDbType.NVarChar, 16, ParameterDirection.Input, Activo)
            v.AddParameter("Valido", SqlDbType.NVarChar, 1, ParameterDirection.Input, Valido)
            Try
                Return v.EjecutarComando("AF_Asignacion_List", "Lista")
            Catch ex As Exception
                Return New DataTable
            End Try

        End Function

        Public Shared Function CentrosCosto_Listar() As DataTable
            Dim v As New Connect(Rutinas.AbrirConexion())
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Try
                Return v.EjecutarComando("CC_GetList", "Lista")
            Catch ex As Exception
                Return New DataTable
            End Try

        End Function
        Public Shared Function Listar(ByVal CentroCosto As Integer) As DataTable
            Dim v As New Connect(Rutinas.AbrirConexion())
            v.AddParameter("CC", SqlDbType.Int, 5, ParameterDirection.Input, CentroCosto)
            Try
                Return v.EjecutarComando("CC_Cuentas_GetList", "Lista")
            Catch ex As Exception
                Return New DataTable
            End Try
        End Function

        Public Shared Function Listar_Tipos() As DataTable
            Dim v As New Connect(Rutinas.AbrirConexion())
            Try
                Return v.EjecutarComando("CC_Cuentas_Tipo", "Lista")
            Catch ex As Exception
                Return New DataTable
            End Try
        End Function

        Public Shared Sub Guardar(ByVal ccd As Integer, ByVal cc As Integer, ByVal tipo As String, ByVal Cuenta As String, ByVal Prefijo As Boolean)
            Dim v As New Connect(Rutinas.AbrirConexion())
            v.AddParameter("ccd", SqlDbType.Int, 5, ParameterDirection.Input, ccd)
            v.AddParameter("cc", SqlDbType.Int, 5, ParameterDirection.Input, cc)
            v.AddParameter("tipo", SqlDbType.Int, 5, ParameterDirection.Input, tipo)
            v.AddParameter("cuenta", SqlDbType.Int, 5, ParameterDirection.Input, Cuenta)
            v.AddParameter("prefijo", SqlDbType.Int, 5, ParameterDirection.Input, Prefijo)
            Try
                v.EjecutarComando("CC_Cuentas_AddUpdate")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Public Shared Sub Borrar(ByVal ccd As Integer)
            Dim v As New Connect(Rutinas.AbrirConexion())
            v.AddParameter("ccd", SqlDbType.Int, 5, ParameterDirection.Input, ccd)
            Try
                v.EjecutarComando("CC_Cuentas_Delete")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub
    End Class

End Namespace
