Imports System.Data.SqlClient

Public Class db_TipoFacturas
    Inherits ClComun
    Dim vTipoFacturasTabla As New TipoFacturas
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property TipoFacturasTabla() As TipoFacturas
        Get
            Return vTipoFacturasTabla
        End Get
        Set(ByVal value As TipoFacturas)
            vTipoFacturasTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal TipoFacturas As TipoFacturas, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = TipoFacturas.Empresa
        ObjParameter(1) = TipoFacturas.Nombre

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_TipoFacturas", ObjParameter)
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
    Public Sub Actualizar(ByVal TipoFacturas As TipoFacturas, Optional Tran As Boolean = False)
        Dim ObjParameter(4) As String

        ObjParameter(0) = TipoFacturas.IdTipo
        ObjParameter(1) = TipoFacturas.Empresa
        ObjParameter(2) = TipoFacturas.Nombre
        ObjParameter(3) = TipoFacturas.Formato

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_TipoFacturas", ObjParameter)
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

        Return ObtieneDatos("sp_sel_TipoFacturas", Id, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal TipoFacturas As TipoFacturas, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = TipoFacturas.IdTipo
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_TipoFacturas", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As TipoFacturas
        Dim dt As DataTable = ObtieneDatos("sp_sel_TipoFacturas", Id, EmpresaActual)
        Dim det As New TipoFacturas

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdTipo = .item("IdTipo")
                det.Empresa = .item("Empresa")
                det.Nombre = .item("Nombre")
                det.Formato = .item("Formato")
            End With
        End If
        Return det
    End Function
End Class
