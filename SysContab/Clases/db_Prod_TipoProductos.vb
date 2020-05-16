
Imports System.Data.SqlClient

Public Class db_Prod_TipoProductos
    Inherits ClComun
    Dim vProd_TipoProductosTabla As New Prod_TipoProductos
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Prod_TipoProductosTabla() As Prod_TipoProductos
        Get
            Return vProd_TipoProductosTabla
        End Get
        Set(ByVal value As Prod_TipoProductos)
            vProd_TipoProductosTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Prod_TipoProductos As Prod_TipoProductos, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = Prod_TipoProductos.NombreTipoProd
        ObjParameter(1) = Prod_TipoProductos.Empresa

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Prod_TipoProductos", ObjParameter)
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
    Public Sub Actualizar(ByVal Prod_TipoProductos As Prod_TipoProductos, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = Prod_TipoProductos.CodTipoProd
        ObjParameter(1) = Prod_TipoProductos.NombreTipoProd

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Prod_TipoProductos", ObjParameter)
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

        Return ObtieneDatos("sp_sel_Prod_TipoProductos", Id, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Prod_TipoProductos As Prod_TipoProductos, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Prod_TipoProductos.CodTipoProd
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Prod_TipoProductos", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As Prod_TipoProductos
        Dim dt As DataTable = ObtieneDatos("sp_sel_Prod_TipoProductos", Id, EmpresaActual)
        Dim det As New Prod_TipoProductos

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.CodTipoProd = .item("CodTipoProd")
                det.NombreTipoProd = .item("NombreTipoProd")
                det.Empresa = .item("Empresa")
            End With
        End If
        Return det
    End Function
End Class
