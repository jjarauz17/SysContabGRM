
Imports System.Data.SqlClient

Public Class db_CorreoConfig
    Inherits ClComun
    Dim vCorreoConfigTabla As New CorreoConfig
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property CorreoConfigTabla() As CorreoConfig
        Get
            Return vCorreoConfigTabla
        End Get
        Set(ByVal value As CorreoConfig)
            vCorreoConfigTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal CorreoConfig As CorreoConfig, Optional Tran As Boolean = False) As Integer
        Dim ObjParameter(13) As String
        ObjParameter(0) = CorreoConfig.IdCorreo
        ObjParameter(1) = CorreoConfig.Tipo
        ObjParameter(2) = CorreoConfig.Empresa
        ObjParameter(3) = CorreoConfig.Correo
        ObjParameter(4) = CorreoConfig.Clave
        ObjParameter(5) = CorreoConfig.Smtp
        ObjParameter(6) = CorreoConfig.SSL
        ObjParameter(7) = CorreoConfig.Puerto
        ObjParameter(8) = CorreoConfig.IdSucursal
        ObjParameter(9) = CorreoConfig.Perfil
        ObjParameter(10) = CorreoConfig.Copia
        ObjParameter(11) = CorreoConfig.Asunto
        ObjParameter(12) = CorreoConfig.ANombre

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_CorreoConfig", ObjParameter)
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
            Me.SendEmail(ex.Message)
            Return 0
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal CorreoConfig As CorreoConfig, Optional Tran As Boolean = False)
        Dim ObjParameter(13) As String
        ObjParameter(0) = CorreoConfig.IdCorreo
        ObjParameter(1) = CorreoConfig.Tipo
        ObjParameter(2) = CorreoConfig.Empresa
        ObjParameter(3) = CorreoConfig.Correo
        ObjParameter(4) = CorreoConfig.Clave
        ObjParameter(5) = CorreoConfig.Smtp
        ObjParameter(6) = CorreoConfig.SSL
        ObjParameter(7) = CorreoConfig.Puerto
        ObjParameter(8) = CorreoConfig.IdSucursal
        ObjParameter(9) = CorreoConfig.Perfil
        ObjParameter(10) = CorreoConfig.Copia
        ObjParameter(11) = CorreoConfig.Asunto
        ObjParameter(12) = CorreoConfig.ANombre

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_CorreoConfig", ObjParameter)
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
            Me.SendEmail(ex.Message)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_CorreoConfig", Id, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal CorreoConfig As CorreoConfig, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = CorreoConfig.IdCorreo
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_CorreoConfig", ObjParameter)
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
            Me.SendEmail(ex.Message)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Id As String, IdSucursal As String) As CorreoConfig
        Dim dt As DataTable = ObtieneDatos("sp_sel_CorreoConfig", Id, IdSucursal, EmpresaActual)
        Dim det As New CorreoConfig

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdCorreo = .Item("IdCorreo")
                det.Tipo = .Item("Tipo")
                det.Empresa = .Item("Empresa")
                det.Correo = .Item("Correo")
                det.Clave = .Item("Clave")
                det.Smtp = .Item("Smtp")
                det.SSL = IIf(.Item("SSL"), 1, 0)
                det.Puerto = .Item("Puerto")
                det.IdSucursal = .Item("IdSucursal")
                det.Perfil = .Item("Perfil")
                det.Copia = .Item("Copia")
                det.Asunto = .Item("Asunto")
                det.ANombre = .Item("ANombre")
            End With
        End If
        Return det
    End Function
End Class
