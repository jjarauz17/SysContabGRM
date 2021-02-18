
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid

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
        Dim ObjParameter(12) As String
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
        ObjParameter(11) = ArregloPago.Comentario

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
        Dim ObjParameter(12) As String
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
        ObjParameter(11) = ArregloPago.Comentario

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
    Public Shared Function Listar() As DataTable

        Return ObtieneDatos("sp_sel_ArregloPago", 0, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar2(Factura As String) As DataTable

        Return ObtieneDatos("sp_sel_ArregloPagoxFacturas", Factura, EmpresaActual)

    End Function

    Public Shared Function GetNumero() As String

        Return ObtieneDatos("sp_GetNumeroAP", EmpresaActual).Rows.Item(0)("Numero")

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Aprobar(Id As Integer) As Boolean

        Return Guardar("sp_upd_ArregloPagoAprobar", Id, EmpresaActual)

    End Function

    Public Shared Sub Imprimir(iGrid As GridControl, Titulo As String, Periodo As String)
        VistaPrevia(
            iGrid,
            $"{NombreEmpresaActual}{vbCrLf}{Titulo}",
            Periodo)
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Borrar(ByVal ArregloPago As ArregloPago, Optional Tran As Boolean = False) As String

        Dim ObjParameter(3) As String
        ObjParameter(0) = String.Empty
        ObjParameter(1) = ArregloPago.IdArreglo
        ObjParameter(2) = EmpresaActual
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_ArregloPago", ObjParameter)
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
            'XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return ex.Message
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Id As Integer) As ArregloPago
        Dim dt As DataTable = ObtieneDatos("sp_sel_ArregloPago", Id, EmpresaActual)
        Dim det As New ArregloPago

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdArreglo = .Item("IdArreglo")
                det.Numero = .Item("Numero")
                det.Empresa = .Item("Empresa")
                det.IdCliente = .Item("IdCliente")
                det.FechaSolicitud = .Item("FechaSolicitud")
                det.FechaInicio = .Item("FechaInicio")
                det.FechaCorte = .Item("FechaCorte")
                det.DiasGracia = .Item("DiasGracia")
                det.NoCuotas = .Item("NoCuotas")
                det.Interes = .Item("Interes")
                det.Monto = .Item("Monto")
                det.Comentario = .Item("Comentario")
                det.Estado = .Item("Estado")
                det.Aprobado = .Item("Aprobado")
                det.Usuario = .Item("Usuario")
                det.Registro = .Item("Registro")
            End With
        End If
        Return det
    End Function

End Class
