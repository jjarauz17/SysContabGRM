
Imports System.Data.SqlClient

Public Class db_CorreoCopia
    Inherits ClComun
    Dim vCorreoCopiaTabla As New CorreoCopia
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property CorreoCopiaTabla() As CorreoCopia
        Get
            Return vCorreoCopiaTabla
        End Get
        Set(ByVal value As CorreoCopia)
            vCorreoCopiaTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal CorreoCopia As CorreoCopia, Optional Tran As Boolean = False)
        Dim ObjParameter(3) As String
        ObjParameter(0) = CorreoCopia.IdCorreo
        ObjParameter(1) = CorreoCopia.Empresa
        ObjParameter(2) = CorreoCopia.Correo

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_CorreoCopia", ObjParameter)
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
    Public Sub Actualizar(ByVal CorreoCopia As CorreoCopia, Optional Tran As Boolean = False)
        Dim ObjParameter(4) As String
        ObjParameter(0) = CorreoCopia.IdDetalle
        ObjParameter(1) = CorreoCopia.IdCorreo
        ObjParameter(2) = CorreoCopia.Empresa
        ObjParameter(3) = CorreoCopia.Correo

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_CorreoCopia", ObjParameter)
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

        Return ObtieneDatos("sp_sel_CorreoCopia", Id, EmpresaActual)

    End Function

    Public Shared Function ListarEnviar(ByVal Id As String, IdCliente As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_CorreoCopiaCC", Id, IdCliente, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal CorreoCopia As CorreoCopia, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = CorreoCopia.IdCorreo
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_CorreoCopia", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As CorreoCopia
        Dim dt As DataTable = ObtieneDatos("sp_sel_CorreoCopia", Id)
        Dim det As New CorreoCopia

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdDetalle = .item("IdDetalle")
                det.IdCorreo = .item("IdCorreo")
                det.Empresa = .item("Empresa")
                det.Correo = .item("Correo")
            End With
        End If
        Return det
    End Function
End Class
