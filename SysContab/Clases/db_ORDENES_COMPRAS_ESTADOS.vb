
Imports System.Data.SqlClient

Public Class db_ORDENES_COMPRAS_ESTADOS
    Inherits ClComun
    Dim vORDENES_COMPRAS_ESTADOSTabla As New ORDENES_COMPRAS_ESTADOS
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property ORDENES_COMPRAS_ESTADOSTabla() As ORDENES_COMPRAS_ESTADOS
        Get
            Return vORDENES_COMPRAS_ESTADOSTabla
        End Get
        Set(ByVal value As ORDENES_COMPRAS_ESTADOS)
            vORDENES_COMPRAS_ESTADOSTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal ORDENES_COMPRAS_ESTADOS As ORDENES_COMPRAS_ESTADOS, Optional Tran As Boolean = False)
        Dim ObjParameter(4) As String
        ObjParameter(0) = ORDENES_COMPRAS_ESTADOS.Nombre
        ObjParameter(1) = ORDENES_COMPRAS_ESTADOS.Empresa
        ObjParameter(2) = ORDENES_COMPRAS_ESTADOS.Facturada
        ObjParameter(3) = ORDENES_COMPRAS_ESTADOS.Pendiente        

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_ORDENES_COMPRAS_ESTADOS", ObjParameter)
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
    Public Sub Actualizar(ByVal ORDENES_COMPRAS_ESTADOS As ORDENES_COMPRAS_ESTADOS, Optional Tran As Boolean = False)
        Dim ObjParameter(5) As String
        ObjParameter(0) = ORDENES_COMPRAS_ESTADOS.IdEstado
        ObjParameter(1) = ORDENES_COMPRAS_ESTADOS.Nombre
        ObjParameter(2) = ORDENES_COMPRAS_ESTADOS.Empresa
        ObjParameter(3) = ORDENES_COMPRAS_ESTADOS.Facturada
        ObjParameter(4) = ORDENES_COMPRAS_ESTADOS.Pendiente        

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_ORDENES_COMPRAS_ESTADOS", ObjParameter)
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

        Return ObtieneDatos("sp_sel_ORDENES_COMPRAS_ESTADOS", Id, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal ORDENES_COMPRAS_ESTADOS As ORDENES_COMPRAS_ESTADOS, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = ORDENES_COMPRAS_ESTADOS.IdEstado
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_ORDENES_COMPRAS_ESTADOS", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As ORDENES_COMPRAS_ESTADOS
        Dim dt As DataTable = ObtieneDatos("sp_sel_ORDENES_COMPRAS_ESTADOS", Id, EmpresaActual)
        Dim det As New ORDENES_COMPRAS_ESTADOS

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdEstado = .item("IdEstado")
                det.Nombre = .item("Nombre")
                det.Empresa = .item("Empresa")
                det.Facturada = IIf(.Item("Facturada"), 1, 0)
                det.Pendiente = IIf(.Item("Pendiente"), 1, 0)
            End With
        End If
        Return det
    End Function
End Class
