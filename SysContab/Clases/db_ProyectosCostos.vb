
Imports System.Data.SqlClient

Public Class db_ProyectosCostos
    Inherits ClComun
    Dim vProyectosCostosTabla As New ProyectosCostos
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property ProyectosCostosTabla() As ProyectosCostos
        Get
            Return vProyectosCostosTabla
        End Get
        Set(ByVal value As ProyectosCostos)
            vProyectosCostosTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal ProyectosCostos As ProyectosCostos, Optional Tran As Boolean = False)
        Dim ObjParameter(11) As String
        ObjParameter(0) = ProyectosCostos.IdProyecto
        ObjParameter(1) = EmpresaActual
        ObjParameter(2) = ProyectosCostos.NoFactura
        ObjParameter(3) = ProyectosCostos.Proveedor
        ObjParameter(4) = ProyectosCostos.Comp_No
        ObjParameter(5) = ProyectosCostos.Per_Id
        ObjParameter(6) = ProyectosCostos.Mes
        ObjParameter(7) = ProyectosCostos.IdRequisa
        ObjParameter(8) = ProyectosCostos.Tipo
        ObjParameter(9) = ProyectosCostos.Costo
        ObjParameter(10) = ProyectosCostos.Fecha

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_ProyectosCostos", ObjParameter)
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
    Public Sub Actualizar(ByVal ProyectosCostos As ProyectosCostos, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = ProyectosCostos.IdDetalle
        'ObjParameter(1) = ProyectosCostos.IdProyecto
        'ObjParameter(2) = ProyectosCostos.Empresa
        'ObjParameter(3) = ProyectosCostos.NoFactura
        'ObjParameter(4) = ProyectosCostos.Proveedor
        'ObjParameter(5) = ProyectosCostos.Comp_No
        'ObjParameter(6) = ProyectosCostos.Per_Id
        'ObjParameter(7) = ProyectosCostos.Mes
        'ObjParameter(8) = ProyectosCostos.IdRequisa
        'ObjParameter(9) = ProyectosCostos.Tipo
        'ObjParameter(10) = ProyectosCostos.Costo
        ObjParameter(1) = ProyectosCostos.Facturado

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_ProyectosCostos", ObjParameter)
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

        Return ObtieneDatos("sp_sel_ProyectosCostos", Id)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal ProyectosCostos As ProyectosCostos, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = ProyectosCostos.IdDetalle
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_ProyectosCostos", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As ProyectosCostos
        Dim dt As DataTable = ObtieneDatos("sp_sel_ProyectosCostos", Id)
        Dim det As New ProyectosCostos

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdDetalle = .item("IdDetalle")
                det.IdProyecto = .item("IdProyecto")
                det.Empresa = .item("Empresa")
                det.NoFactura = .item("NoFactura")
                det.Proveedor = .item("Proveedor")
                det.Comp_No = .item("Comp_No")
                det.Per_Id = .item("Per_Id")
                det.Mes = .item("Mes")
                det.IdRequisa = .item("IdRequisa")
                det.Tipo = .item("Tipo")
                det.Costo = .item("Costo")
                det.Facturado = .item("Facturado")
                det.Usuario = .item("Usuario")
                det.Registro = .item("Registro")
            End With
        End If
        Return det
    End Function
End Class
