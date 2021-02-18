
Imports System.Data.SqlClient

Public Class db_ArregloPagoDetalle
    Inherits ClComun
    Dim vArregloPagoDetalleTabla As New ArregloPagoDetalle
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property ArregloPagoDetalleTabla() As ArregloPagoDetalle
        Get
            Return vArregloPagoDetalleTabla
        End Get
        Set(ByVal value As ArregloPagoDetalle)
            vArregloPagoDetalleTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal ArregloPagoDetalle As ArregloPagoDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(7) As String
        ObjParameter(0) = ArregloPagoDetalle.IdArreglo
        ObjParameter(1) = EmpresaActual
        ObjParameter(2) = ArregloPagoDetalle.Numero
        ObjParameter(3) = ArregloPagoDetalle.FechaPago
        ObjParameter(4) = ArregloPagoDetalle.Vencimiento
        ObjParameter(5) = ArregloPagoDetalle.Cuota
        ObjParameter(6) = ArregloPagoDetalle.Interes

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_ArregloPagoDetalle", ObjParameter)
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
    Public Sub Actualizar(ByVal ArregloPagoDetalle As ArregloPagoDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(8) As String
        ObjParameter(0) = ArregloPagoDetalle.IdDetalle
        ObjParameter(1) = ArregloPagoDetalle.IdArreglo
        ObjParameter(2) = EmpresaActual
        ObjParameter(3) = ArregloPagoDetalle.Numero
        ObjParameter(4) = ArregloPagoDetalle.FechaPago
        ObjParameter(5) = ArregloPagoDetalle.Vencimiento
        ObjParameter(6) = ArregloPagoDetalle.Cuota
        ObjParameter(7) = ArregloPagoDetalle.Interes

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_ArregloPagoDetalle", ObjParameter)
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
    Public Shared Function Listar(ByVal Id As String) As DataTable

        Return ObtieneDatos("sp_sel_ArregloPagoDetalle", Id, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal ArregloPagoDetalle As ArregloPagoDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = ArregloPagoDetalle.IdArreglo
        ObjParameter(1) = EmpresaActual
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_ArregloPagoDetalle", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As ArregloPagoDetalle
        Dim dt As DataTable = ObtieneDatos("sp_sel_ArregloPagoDetalle", Id, EmpresaActual)
        Dim det As New ArregloPagoDetalle

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdDetalle = .item("IdDetalle")
                det.IdArreglo = .item("IdArreglo")
                det.Empresa = .item("Empresa")
                det.Numero = .item("Numero")
                det.FechaPago = .item("FechaPago")
                det.Vencimiento = .item("Vencimiento")
                det.Cuota = .item("Cuota")
                det.Interes = .item("Interes")
                det.Aplicada = .item("Aplicada")
            End With
        End If
        Return det
    End Function
End Class
