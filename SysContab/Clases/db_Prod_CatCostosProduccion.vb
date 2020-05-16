
Imports System.Data.SqlClient

Public Class db_Prod_CatCostosProduccion
    Inherits ClComun
    Dim vProd_CatCostosProduccionTabla As New Prod_CatCostosProduccion
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Prod_CatCostosProduccionTabla() As Prod_CatCostosProduccion
        Get
            Return vProd_CatCostosProduccionTabla
        End Get
        Set(ByVal value As Prod_CatCostosProduccion)
            vProd_CatCostosProduccionTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Prod_CatCostosProduccion As Prod_CatCostosProduccion, Optional Tran As Boolean = False)
        Dim ObjParameter(3) As String
        ObjParameter(0) = Prod_CatCostosProduccion.CodConsecutTipoCosto
        ObjParameter(1) = Prod_CatCostosProduccion.NombreCosto
        ObjParameter(2) = Prod_CatCostosProduccion.Empresa

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Prod_CatCostosProduccion", ObjParameter)
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
    Public Sub Actualizar(ByVal Prod_CatCostosProduccion As Prod_CatCostosProduccion, Optional Tran As Boolean = False)
        Dim ObjParameter(3) As String
        ObjParameter(0) = Prod_CatCostosProduccion.CodConsecutCatCosto
        ObjParameter(1) = Prod_CatCostosProduccion.CodConsecutTipoCosto
        ObjParameter(2) = Prod_CatCostosProduccion.NombreCosto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Prod_CatCostosProduccion", ObjParameter)
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

        Return ObtieneDatos("sp_sel_Prod_CatCostosProduccion", Id, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Prod_CatCostosProduccion As Prod_CatCostosProduccion, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Prod_CatCostosProduccion.CodConsecutCatCosto
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Prod_CatCostosProduccion", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As Prod_CatCostosProduccion
        Dim dt As DataTable = ObtieneDatos("sp_sel_Prod_CatCostosProduccion", Id, EmpresaActual)
        Dim det As New Prod_CatCostosProduccion

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.CodConsecutCatCosto = .item("CodConsecutCatCosto")
                det.CodConsecutTipoCosto = .item("CodConsecutTipoCosto")
                det.NombreCosto = .item("NombreCosto")
                det.Empresa = .item("Empresa")
            End With
        End If
        Return det
    End Function
End Class
