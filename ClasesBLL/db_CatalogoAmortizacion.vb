
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_CatalogoAmortizacion
    Inherits ClComun
    Dim vCatalogoAmortizacionTabla As New CatalogoAmortizacion
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property CatalogoAmortizacionTabla() As CatalogoAmortizacion
        Get
            Return vCatalogoAmortizacionTabla
        End Get
        Set(ByVal value As CatalogoAmortizacion)
            vCatalogoAmortizacionTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal CatalogoAmortizacion As CatalogoAmortizacion, Optional Tran As Boolean = False)
        Dim ObjParameter(6) As String
        ObjParameter(0) = CatalogoAmortizacion.Codigo
        ObjParameter(1) = CatalogoAmortizacion.Nombre
        ObjParameter(2) = EmpresaA
        ObjParameter(3) = CatalogoAmortizacion.Debito
        ObjParameter(4) = CatalogoAmortizacion.Credito
        ObjParameter(5) = CatalogoAmortizacion.TipoCompr

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_CatalogoAmortizacion", ObjParameter)
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
    Public Sub Actualizar(ByVal CatalogoAmortizacion As CatalogoAmortizacion, Optional Tran As Boolean = False)
        Dim ObjParameter(6) As String
        ObjParameter(0) = CatalogoAmortizacion.Codigo
        ObjParameter(1) = CatalogoAmortizacion.Nombre
        ObjParameter(2) = EmpresaA
        ObjParameter(3) = CatalogoAmortizacion.Debito
        ObjParameter(4) = CatalogoAmortizacion.Credito
        ObjParameter(5) = CatalogoAmortizacion.TipoCompr

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_CatalogoAmortizacion", ObjParameter)
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

        Return ObtieneDatos("sp_sel_CatalogoAmortizacion", Id, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function ListarPendientes(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_CatalogoAmortizacionPendientes", Id, EmpresaA)

    End Function

    Public Shared Function GetCodigo() As Integer

        Return ObtieneDatos("sp_sel_CatalogoAmortizacionGetCodigo", EmpresaA).Rows.Item(0)("Codigo")

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal CatalogoAmortizacion As CatalogoAmortizacion, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = CatalogoAmortizacion.Codigo
        ObjParameter(1) = EmpresaA

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_CatalogoAmortizacion", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As CatalogoAmortizacion
        Dim dt As DataTable = ObtieneDatos("sp_sel_CatalogoAmortizacion", Id, EmpresaA)
        Dim det As New CatalogoAmortizacion

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.Codigo = .Item("Codigo")
                det.Nombre = .Item("Nombre")
                det.Empresa = .Item("Empresa")
                det.Debito = .Item("Debito")
                det.Credito = .Item("Credito")
                det.TipoCompr = .Item("TipoCompr")
            End With
        End If
        Return det
    End Function
End Class
