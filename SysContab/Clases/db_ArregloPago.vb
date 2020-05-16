
Imports System.Data.SqlClient

Public Class db_ArregloPago
    Inherits ClComun
    Dim vArregloPagoTabla As New ArregloPago
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property ArregloPagoTabla() As ArregloPago
        Get
            Return vArregloPagoTabla
        End Get
        Set(ByVal value As ArregloPago)
            vArregloPagoTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal ArregloPago As ArregloPago, Optional Tran As Boolean = False) As Integer
        Dim ObjParameter(11) As String
        ObjParameter(0) = ArregloPago.IdArreglo
        ObjParameter(1) = ArregloPago.Numero
        ObjParameter(2) = EmpresaActual
        ObjParameter(3) = ArregloPago.IdCliente
        ObjParameter(4) = ArregloPago.FechaSolicitud
        ObjParameter(5) = ArregloPago.FechaInicio
        ObjParameter(6) = ArregloPago.FechaCorte
        ObjParameter(7) = ArregloPago.DiasGracia
        ObjParameter(8) = ArregloPago.NoCuotas
        ObjParameter(9) = ArregloPago.Interes
        ObjParameter(10) = ArregloPago.Monto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_ArregloPago", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If

            Return cmd.Parameters(1).Value
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
    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal ArregloPago As ArregloPago, Optional Tran As Boolean = False)
        Dim ObjParameter(11) As String
        ObjParameter(0) = ArregloPago.IdArreglo
        ObjParameter(1) = ArregloPago.Numero
        ObjParameter(2) = EmpresaActual
        ObjParameter(3) = ArregloPago.IdCliente
        ObjParameter(4) = ArregloPago.FechaSolicitud
        ObjParameter(5) = ArregloPago.FechaInicio
        ObjParameter(6) = ArregloPago.FechaCorte
        ObjParameter(7) = ArregloPago.DiasGracia
        ObjParameter(8) = ArregloPago.NoCuotas
        ObjParameter(9) = ArregloPago.Interes
        ObjParameter(10) = ArregloPago.Monto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_ArregloPago", ObjParameter)
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

        Return ObtieneDatos("sp_sel_ArregloPago", Id, EmpresaActual)

    End Function

    Public Shared Function GetNumero(Sucursal As String) As String

        Return ObtieneDatos("sp_GetNumeroAP", Sucursal, EmpresaActual).Rows.Item(0)("Numero")

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal ArregloPago As ArregloPago, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = ArregloPago.IdArreglo
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_ArregloPago", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As ArregloPago
        Dim dt As DataTable = ObtieneDatos("sp_sel_ArregloPago", Id, EmpresaActual)
        Dim det As New ArregloPago

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdArreglo = .item("IdArreglo")
                det.Numero = .item("Numero")
                det.Empresa = .item("Empresa")
                det.IdCliente = .item("IdCliente")
                det.FechaSolicitud = .item("FechaSolicitud")
                det.FechaInicio = .item("FechaInicio")
                det.FechaCorte = .item("FechaCorte")
                det.DiasGracia = .item("DiasGracia")
                det.NoCuotas = .item("NoCuotas")
                det.Interes = .item("Interes")
                det.Monto = .item("Monto")
                det.Estado = .item("Estado")
                det.Usuario = .item("Usuario")
                det.Registro = .item("Registro")
            End With
        End If
        Return det
    End Function
End Class
