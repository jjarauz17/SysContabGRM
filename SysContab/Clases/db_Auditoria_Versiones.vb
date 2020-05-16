
Imports System.Data.SqlClient

Public Class db_Auditoria_Versiones
    Inherits ClComun
    Dim vAuditoria_VersionesTabla As New Auditoria_Versiones
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Auditoria_VersionesTabla() As Auditoria_Versiones
        Get
            Return vAuditoria_VersionesTabla
        End Get
        Set(ByVal value As Auditoria_Versiones)
            vAuditoria_VersionesTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Auditoria_Versiones As Auditoria_Versiones, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = Auditoria_Versiones.Usr_Id        
        ObjParameter(1) = Auditoria_Versiones.Version

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Auditoria_Versiones", ObjParameter)
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

End Class
