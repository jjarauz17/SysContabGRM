
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_AmortizacionesDetalle
    Inherits ClComun
    Dim vAmortizacionesDetalleTabla As New AmortizacionesDetalle
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property AmortizacionesDetalleTabla() As AmortizacionesDetalle
        Get
            Return vAmortizacionesDetalleTabla
        End Get
        Set(ByVal value As AmortizacionesDetalle)
            vAmortizacionesDetalleTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal AmortizacionesDetalle As AmortizacionesDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(6) As String
        ObjParameter(0) = AmortizacionesDetalle.Cod_amortizacion
        ObjParameter(1) = AmortizacionesDetalle.num_amortizacion
        ObjParameter(2) = AmortizacionesDetalle.Fecha
        ' ObjParameter(3) = AmortizacionesDetalle.Mes
        ObjParameter(3) = AmortizacionesDetalle.Monto_Inicial
        ObjParameter(4) = AmortizacionesDetalle.Monto_Amortizado
        ' ObjParameter(6) = AmortizacionesDetalle.contabilizar
        ObjParameter(5) = EmpresaA

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_AmortizacionesDetalle", ObjParameter)
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
    'Public Sub Actualizar(ByVal AmortizacionesDetalle As AmortizacionesDetalle, Optional Tran As Boolean = False)
    '    Dim ObjParameter(8) As String
    '    ObjParameter(1) = AmortizacionesDetalle.Cod_amortizacion
    '    ObjParameter(2) = AmortizacionesDetalle.num_amortizacion
    '    ObjParameter(3) = AmortizacionesDetalle.Fecha
    '    ObjParameter(4) = AmortizacionesDetalle.Mes
    '    ObjParameter(5) = AmortizacionesDetalle.Monto_Inicial
    '    ObjParameter(6) = AmortizacionesDetalle.Monto_Amortizado
    '    ObjParameter(7) = AmortizacionesDetalle.contabilizar
    '    ObjParameter(8) = AmortizacionesDetalle.Empresa

    '    Try
    '        Me.InicializarMensajeError()
    '        Me.OpenSqlBD()

    '        Dim cmd As New SqlCommand
    '        cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_AmortizacionesDetalle", ObjParameter)
    '        cmd.ExecuteNonQuery()

    '        If Tran = False Then
    '            Commit()
    '        End If
    '    Catch ex As Exception
    '        Me.CodigoError = -1
    '        If Tran = False Then
    '            Rollback()
    '        End If
    '        XtraMsg(ex.Message, MessageBoxIcon.Error)
    '    Finally
    '        If Tran = False Then
    '            CloseSqlBD()
    '        End If
    '    End Try
    'End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_AmortizacionesDetalle", Id)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub UpdateEstado(ByVal AmortizacionesDetalle As AmortizacionesDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(6) As String
        ObjParameter(0) = AmortizacionesDetalle.Cod_amortizacion
        ObjParameter(1) = AmortizacionesDetalle.num_amortizacion
        ObjParameter(2) = EmpresaA
        ObjParameter(3) = AmortizacionesDetalle.Comp_No
        ObjParameter(4) = AmortizacionesDetalle.Per_Id
        ObjParameter(5) = AmortizacionesDetalle.Mes_Id

        Try

            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_AmortizacionesDetalleEstado", ObjParameter)
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
    Public Sub Borrar(ByVal AmortizacionesDetalle As AmortizacionesDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = AmortizacionesDetalle.Cod_amortizacion
        ObjParameter(1) = EmpresaA

        Try

            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_AmortizacionesDetalle", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As AmortizacionesDetalle
        Dim dt As DataTable = ObtieneDatos("sp_sel_AmortizacionesDetalle", Id)
        Dim det As New AmortizacionesDetalle

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.Cod_amortizacion = .Item("Cod_amortizacion")
                det.num_amortizacion = .Item("num_amortizacion")
                det.Fecha = .Item("Fecha")
                det.Mes = .Item("Mes")
                det.Monto_Inicial = .Item("Monto_Inicial")
                det.Monto_Amortizado = .Item("Monto_Amortizado")
                det.contabilizar = .Item("contabilizar")
                det.Empresa = .Item("Empresa")
            End With
        End If
        Return det
    End Function
End Class
