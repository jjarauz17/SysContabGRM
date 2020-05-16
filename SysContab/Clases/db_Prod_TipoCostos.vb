
Imports System.Data.SqlClient

Public Class db_Prod_TipoCostos
    Inherits ClComun
    Dim vProd_TipoCostosTabla As New Prod_TipoCostos
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Prod_TipoCostosTabla() As Prod_TipoCostos
        Get
            Return vProd_TipoCostosTabla
        End Get
        Set(ByVal value As Prod_TipoCostos)
            vProd_TipoCostosTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Prod_TipoCostos As Prod_TipoCostos, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = Prod_TipoCostos.TipoCosto
        ObjParameter(1) = Prod_TipoCostos.Empresa

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Prod_TipoCostos", ObjParameter)
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
    Public Sub Actualizar(ByVal Prod_TipoCostos As Prod_TipoCostos, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = Prod_TipoCostos.CodConsecutTipoCosto
        ObjParameter(1) = Prod_TipoCostos.TipoCosto        

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Prod_TipoCostos", ObjParameter)
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

        Return ObtieneDatos("sp_sel_Prod_TipoCostos", Id, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Prod_TipoCostos As Prod_TipoCostos, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Prod_TipoCostos.CodConsecutTipoCosto
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Prod_TipoCostos", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As Prod_TipoCostos
        Dim dt As DataTable = ObtieneDatos("sp_sel_Prod_TipoCostos", Id, EmpresaActual)
        Dim det As New Prod_TipoCostos

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.CodConsecutTipoCosto = .item("CodConsecutTipoCosto")
                det.TipoCosto = .item("TipoCosto")
                det.Empresa = .item("Empresa")
            End With
        End If
        Return det
    End Function
End Class
