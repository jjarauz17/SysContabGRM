
Public Class db_RecibosImportar

    Dim Cadena As New ConeccionRecibos

    Public Function List() As DataTable
        Dim Conn As New DbConnect.Connect(Cadena.Conexion())        
        Conn.AddParameter("IdRecibo", SqlDbType.Int, 4, ParameterDirection.Input, 0)
        Return (Conn.EjecutarComando("Get_Recibo_WS"))
    End Function

    Public Function GetDetalle(IdRecibo As Integer) As DataTable
        Dim Conn As New DbConnect.Connect(Cadena.Conexion())
        Conn.AddParameter("IdRecibo", SqlDbType.Int, 4, ParameterDirection.Input, IdRecibo)

        Return (Conn.EjecutarComando("JAR_GetDetalleROC_WS"))
    End Function

    Public Function ActualizarEstado(IdRecibo As Integer) As Boolean
        Try
            Dim Conn As New DbConnect.Connect(Cadena.Conexion())
            Conn.AddParameter("IdRecibo", SqlDbType.Int, 4, ParameterDirection.Input, IdRecibo)

            Conn.EjecutarComando("JAR_ActualizarEstadoROC_WS")
            Return True
        Catch ex As Exception
            XtraMsg(ex.Message)
            Return False
        End Try
    End Function

    Public Function Contabilizar(IdRecibo As Integer, IdEstudiante As Integer, Numero As String, Fecha As Date, Retencion As Double, Monto As Double, Factura As String) As Boolean
        Dim Conn As New DbConnect.Connect(Conexion())

        Try
            Conn.AddParameter("IdRecibo", SqlDbType.Int, 4, ParameterDirection.Input, IdRecibo)
            Conn.AddParameter("Estudiante", SqlDbType.Int, 4, ParameterDirection.Input, IdEstudiante)
            Conn.AddParameter("Recibo", SqlDbType.NVarChar, 50, ParameterDirection.Input, Numero)
            Conn.AddParameter("Fec", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Fecha.Date)
            Conn.AddParameter("Retencion", SqlDbType.Decimal, 20, ParameterDirection.Input, Retencion)
            Conn.AddParameter("Efectivo", SqlDbType.Decimal, 20, ParameterDirection.Input, Monto)
            Conn.AddParameter("Factura", SqlDbType.NVarChar, 50, ParameterDirection.Input, Factura)

            Conn.EjecutarComando("JAR_ContabilizarROR_WS")

            Return True
        Catch ex As Exception
            XtraMsg(ex.Message)
            Return False
        End Try
    End Function

End Class
