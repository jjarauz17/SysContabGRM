
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_BancosCK
    Inherits ClComun
    Dim vBancosCKTabla As New BancosCK
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property BancosCKTabla() As BancosCK
        Get
            Return vBancosCKTabla
        End Get
        Set(ByVal value As BancosCK)
            vBancosCKTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal BancosCK As BancosCK, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String

        ObjParameter(0) = EmpresaA
        ObjParameter(1) = BancosCK.Nombre


        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_BancosCK", ObjParameter)
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
    Public Sub Actualizar(ByVal BancosCK As BancosCK, Optional Tran As Boolean = False)
        Dim ObjParameter(3) As String
        ObjParameter(0) = BancosCK.IdBanco
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = BancosCK.Nombre


        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_BancosCK", ObjParameter)
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
    Public Shared Function Listar() As Data.DataTable

        Return ObtieneDatos("sp_sel_BancosCK", EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal BancosCK As BancosCK, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = BancosCK.IdBanco
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_BancosCK", ObjParameter)
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

    ''-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    'Public Shared Function Detalles(ByVal Id As String) As BancosCK
    '    Dim dt As DataTable = ObtieneDatos("sp_sel_BancosCK", Id)
    '    Dim det As New BancosCK

    '    If dt.Rows.Count > 0 Then
    '        With dt.Rows(0)
    '            det.IdBanco = .Item("IdBanco")
    '            det.Empresa = .Item("Empresa")
    '            det.Nombre = .Item("Nombre")
    '        End With
    '    End If
    '    Return det
    'End Function
End Class
