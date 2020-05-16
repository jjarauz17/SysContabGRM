
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_TipoNotasCD
    Inherits ClComun
    Dim vTipoNotasCDTabla As New TipoNotasCD
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property TipoNotasCDTabla() As TipoNotasCD
        Get
            Return vTipoNotasCDTabla
        End Get
        Set(ByVal value As TipoNotasCD)
            vTipoNotasCDTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal TipoNotasCD As TipoNotasCD, Optional Tran As Boolean = False)
        Dim ObjParameter(3) As String
        ObjParameter(0) = EmpresaA
        ObjParameter(1) = TipoNotasCD.Nombre
        ObjParameter(2) = TipoNotasCD.Descripcion

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_TipoNotasCD", ObjParameter)
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
    Public Sub Actualizar(ByVal TipoNotasCD As TipoNotasCD, Optional Tran As Boolean = False)
        Dim ObjParameter(4) As String
        ObjParameter(0) = TipoNotasCD.IdTipo
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = TipoNotasCD.Nombre
        ObjParameter(3) = TipoNotasCD.Descripcion

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_TipoNotasCD", ObjParameter)
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
    Public Shared Function Listar(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_TipoNotasCD", Id, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal TipoNotasCD As TipoNotasCD, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = TipoNotasCD.IdTipo
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_TipoNotasCD", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As TipoNotasCD
        Dim dt As DataTable = ObtieneDatos("sp_sel_TipoNotasCD", Id, EmpresaA)
        Dim det As New TipoNotasCD

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdTipo = .Item("IdTipo")
                det.Empresa = .Item("Empresa")
                det.Nombre = .Item("Nombre")
                det.Descripcion = .Item("Descripcion")
            End With
        End If
        Return det
    End Function
End Class
