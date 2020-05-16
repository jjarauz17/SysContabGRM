Public Class db_PNR_Reportes

    Public Shared Function Reporte_Pivot(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("PNR_GetPlanNegocioReporte", Id, EmpresaActual)

    End Function

    Public Shared Function ReporteImpreso(Id As Integer) As DataTable

        Return ObtieneDatos("PNR_ReporteImpreso", Id, EmpresaActual)

    End Function

    Public Shared Function ReportePlanDeAccion(Id As Integer) As DataTable

        Return ObtieneDatos("PNR_GetPlanDeAccion", Id, EmpresaActual)

    End Function

    Public Shared Function ReporteAntecedentes(Id As Integer) As DataTable

        Return ObtieneDatos("PNR_GetAntecedentes", Id, EmpresaActual)

    End Function

    Public Shared Function Reporte_PivotConsolidado(Periodo As Integer) As Data.DataTable

        Return ObtieneDatos("PNR_GetPlanNegocioReporteConsolidado2", EmpresaActual, Periodo)

    End Function

    Public Shared Function Estadisticas(Desde As Date, Hasta As Date) As Data.DataTable

        Return ObtieneDatos("PNR_FrecuenciaUso", Desde, Hasta)

    End Function


    Public Shared Function Actualizar_Ventas_PNR(Periodo As Integer, Empresa As Integer) As Boolean
        Try
            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

            Conn.AddParameter("Periodo", SqlDbType.Int, 5, ParameterDirection.Input, Periodo)
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, Empresa)

            Conn.EjecutarComando("JAR_ActualizarVentaAllPNR")

            Return True
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function Actualizar_Ventas_PNR(ID As Integer) As Boolean
        Try
            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

            Conn.AddParameter("IdPlanNegocio", SqlDbType.Int, 5, ParameterDirection.Input, ID)
            Conn.EjecutarComando("JAR_ActualizarVentaPNR")

            Return True
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
    End Function



End Class
