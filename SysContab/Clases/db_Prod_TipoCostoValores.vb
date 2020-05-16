
Imports System.Data.SqlClient

Public Class db_Prod_TipoCostoValores
    Inherits ClComun
    Dim vProd_TipoCostoValoresTabla As New Prod_TipoCostoValores
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Prod_TipoCostoValoresTabla() As Prod_TipoCostoValores
        Get
            Return vProd_TipoCostoValoresTabla
        End Get
        Set(ByVal value As Prod_TipoCostoValores)
            vProd_TipoCostoValoresTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Prod_TipoCostoValores As Prod_TipoCostoValores, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = Prod_TipoCostoValores.Nombre
        ObjParameter(1) = Prod_TipoCostoValores.Empresa

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Prod_TipoCostoValores", ObjParameter)
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
    Public Sub Actualizar(ByVal Prod_TipoCostoValores As Prod_TipoCostoValores, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = Prod_TipoCostoValores.CodconsecutTipoCosto
        ObjParameter(1) = Prod_TipoCostoValores.Nombre

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Prod_TipoCostoValores", ObjParameter)
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

        Return ObtieneDatos("sp_sel_Prod_TipoCostoValores", Id, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Prod_TipoCostoValores As Prod_TipoCostoValores, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Prod_TipoCostoValores.CodconsecutTipoCosto
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Prod_TipoCostoValores", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As Prod_TipoCostoValores
        Dim dt As DataTable = ObtieneDatos("sp_sel_Prod_TipoCostoValores", Id, EmpresaActual)
        Dim det As New Prod_TipoCostoValores

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.CodconsecutTipoCosto = .item("CodconsecutTipoCosto")
                det.Nombre = .item("Nombre")
                det.Empresa = .item("Empresa")
            End With
        End If
        Return det
    End Function
End Class
