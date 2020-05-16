Imports DbConnect

Public Class CierresDB

    Public Shared Function Cierre_Ultimo() As DataTable
        Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        Try
            Return v.EjecutarComando("_AF_Cierres_Ultimo", "Lista")
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Shared Sub Cierre_Guardar(ByVal UMCD As String, ByVal fechacierre As DateTime)
        Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("UMCD", SqlDbType.NVarChar, 6, ParameterDirection.Input, UMCD)
        v.AddParameter("fechacierre", SqlDbType.DateTime, 10, ParameterDirection.Input, fechacierre)

        Try
            v.EjecutarComando("_AF_Cierres_Add")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
