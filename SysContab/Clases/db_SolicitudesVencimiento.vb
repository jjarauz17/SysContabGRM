
Imports System.Data.SqlClient

Public Class db_SolicitudesVencimiento
    Inherits ClComun
    Dim vSolicitudesVencimientoTabla As New SolicitudesVencimiento
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property SolicitudesVencimientoTabla() As SolicitudesVencimiento
        Get
            Return vSolicitudesVencimientoTabla
        End Get
        Set(ByVal value As SolicitudesVencimiento)
            vSolicitudesVencimientoTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal SolicitudesVencimiento As SolicitudesVencimiento, Optional Tran As Boolean = False) As Integer
        Dim ObjParameter(7) As String
        ObjParameter(0) = SolicitudesVencimiento.IdSolicitud
        ObjParameter(1) = EmpresaActual
        ObjParameter(2) = SolicitudesVencimiento.Cliente
        ObjParameter(3) = SolicitudesVencimiento.Solicitado_por
        ObjParameter(4) = SolicitudesVencimiento.Correo
        ObjParameter(5) = SolicitudesVencimiento.Fecha
        ObjParameter(6) = SolicitudesVencimiento.Concepto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_SolicitudesVencimiento", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If

            Return cmd.Parameters(1).Value
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal SolicitudesVencimiento As SolicitudesVencimiento, Optional Tran As Boolean = False)
        Dim ObjParameter(10) As String
        ObjParameter(0) = SolicitudesVencimiento.IdSolicitud
        ObjParameter(1) = EmpresaActual
        ObjParameter(2) = SolicitudesVencimiento.Cliente
        ObjParameter(3) = SolicitudesVencimiento.Solicitado_por
        ObjParameter(4) = SolicitudesVencimiento.Correo
        ObjParameter(5) = SolicitudesVencimiento.Fecha
        ObjParameter(6) = SolicitudesVencimiento.Fecha_Aprobada
        ObjParameter(7) = SolicitudesVencimiento.Fecha_Denegada
        ObjParameter(8) = SolicitudesVencimiento.Concepto
        ObjParameter(9) = SolicitudesVencimiento.Estado

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_SolicitudesVencimiento", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar(ByVal Id As String, Estado As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_SolicitudesVencimiento", Id, Estado, EmpresaActual)

    End Function

    Public Shared Function ListarEnviadas(ByVal Id As String, Estado As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_SolicitudesEnviadas", Id, Estado, EmpresaActual)

    End Function

    Public Shared Function GetEstados() As Data.DataTable

        Return ObtieneDatos("sp_GetEstadosSolicitud")

    End Function

    Public Shared Function EnviarSolicitud(Id As Integer) As Boolean

        Return Guardar("JAR_EnviarSolicitud",
                       Id,
                       EmpresaActual)

    End Function

    Public Shared Function EnviarRespuesta(Id As Integer, Estado As String) As Boolean

        Return Guardar("JAR_EnviarRespuesta", Id, Estado, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal SolicitudesVencimiento As SolicitudesVencimiento, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = SolicitudesVencimiento.IdSolicitud
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_SolicitudesVencimiento", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Id As String, Estado As String) As SolicitudesVencimiento
        Dim dt As DataTable = ObtieneDatos("sp_sel_SolicitudesVencimiento", Id, Estado, EmpresaActual)
        Dim det As New SolicitudesVencimiento

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdSolicitud = .item("IdSolicitud")
                det.Empresa = .item("Empresa")
                det.Cliente = .item("Cliente")
                det.Solicitado_por = .item("Solicitado_por")
                det.Correo = .item("Correo")
                det.Fecha = .item("Fecha")
                'det.Fecha_Aprobada = .item("Fecha_Aprobada")
                'det.Fecha_Denegada = .item("Fecha_Denegada")
                det.Concepto = .item("Concepto")
                det.Estado = .item("Estado")
                det.Usuario = .item("Usuario")
                'det.Usuario_Aprueba = .item("Usuario_Aprueba")
                'det.Usuario_Deniega = .item("Usuario_Deniega")
                'det.Registro = .item("Registro")
            End With
        End If
        Return det
    End Function
End Class
