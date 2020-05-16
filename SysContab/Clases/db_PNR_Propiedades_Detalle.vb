
Imports System.Data.SqlClient

Public Class db_PNR_Propiedades_Detalle
    Inherits ClComun
    Dim vPNR_Propiedades_DetalleTabla As New PNR_Propiedades_Detalle
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property PNR_Propiedades_DetalleTabla() As PNR_Propiedades_Detalle
        Get
            Return vPNR_Propiedades_DetalleTabla
        End Get
        Set(ByVal value As PNR_Propiedades_Detalle)
            vPNR_Propiedades_DetalleTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal PNR_Propiedades_Detalle As PNR_Propiedades_Detalle, Optional Tran As Boolean = False)
        Dim ObjParameter(3) As String
        ObjParameter(0) = PNR_Propiedades_Detalle.IdPropiedad
        ObjParameter(1) = PNR_Propiedades_Detalle.Nombre
        ObjParameter(2) = PNR_Propiedades_Detalle.Manzanas

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_PNR_Propiedades_Detalle", ObjParameter)
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
    Public Sub Actualizar(ByVal PNR_Propiedades_Detalle As PNR_Propiedades_Detalle, Optional Tran As Boolean = False)
        Dim ObjParameter(4) As String
        ObjParameter(0) = PNR_Propiedades_Detalle.IdDetalle
        ObjParameter(1) = PNR_Propiedades_Detalle.IdPropiedad
        ObjParameter(2) = PNR_Propiedades_Detalle.Nombre
        ObjParameter(3) = PNR_Propiedades_Detalle.Manzanas

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_PNR_Propiedades_Detalle", ObjParameter)
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

        Return ObtieneDatos("sp_sel_PNR_Propiedades_Detalle", Id)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal PNR_Propiedades_Detalle As PNR_Propiedades_Detalle, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = PNR_Propiedades_Detalle.IdPropiedad
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_PNR_Propiedades_Detalle", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As PNR_Propiedades_Detalle
        Dim dt As DataTable = ObtieneDatos("sp_sel_PNR_Propiedades_Detalle", Id)
        Dim det As New PNR_Propiedades_Detalle

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdDetalle = .item("IdDetalle")
                det.IdPropiedad = .item("IdPropiedad")
                det.Nombre = .item("Nombre")
                det.Manzanas = .item("Manzanas")
            End With
        End If
        Return det
    End Function
End Class
