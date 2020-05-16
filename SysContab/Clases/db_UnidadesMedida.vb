
Imports System.Data.SqlClient

Public Class db_UnidadesMedida
    Inherits ClComun
    Dim vUnidadesMedidaTabla As New UnidadesMedida
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property UnidadesMedidaTabla() As UnidadesMedida
        Get
            Return vUnidadesMedidaTabla
        End Get
        Set(ByVal value As UnidadesMedida)
            vUnidadesMedidaTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal UnidadesMedida As UnidadesMedida, Optional Tran As Boolean = False)
        Dim ObjParameter(3) As String
        ObjParameter(0) = EmpresaActual
        ObjParameter(1) = UnidadesMedida.Unidad
        ObjParameter(2) = UnidadesMedida.Nombre

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_UnidadesMedida", ObjParameter)
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
    Public Sub Actualizar(ByVal UnidadesMedida As UnidadesMedida, Optional Tran As Boolean = False)
        Dim ObjParameter(4) As String
        ObjParameter(0) = UnidadesMedida.IdUnidad
        ObjParameter(1) = UnidadesMedida.Empresa
        ObjParameter(2) = UnidadesMedida.Unidad
        ObjParameter(3) = UnidadesMedida.Nombre

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_UnidadesMedida", ObjParameter)
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

        Return ObtieneDatos("sp_sel_UnidadesMedida", Id, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal UnidadesMedida As UnidadesMedida, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = UnidadesMedida.IdUnidad
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_UnidadesMedida", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As UnidadesMedida
        Dim dt As DataTable = ObtieneDatos("sp_sel_UnidadesMedida", Id, EmpresaActual)
        Dim det As New UnidadesMedida

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdUnidad = .item("IdUnidad")
                det.Empresa = .item("Empresa")
                det.Unidad = .item("Unidad")
                det.Nombre = .item("Nombre")
            End With
        End If
        Return det
    End Function
End Class
