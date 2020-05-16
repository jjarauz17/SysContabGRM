
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_AmortizacionesPlantilla
    Inherits ClComun
    Dim vAmortizacionesPlantillaTabla As New AmortizacionesPlantilla
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property AmortizacionesPlantillaTabla() As AmortizacionesPlantilla
        Get
            Return vAmortizacionesPlantillaTabla
        End Get
        Set(ByVal value As AmortizacionesPlantilla)
            vAmortizacionesPlantillaTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal AmortizacionesPlantilla As AmortizacionesPlantilla, Optional Tran As Boolean = False)
        Dim ObjParameter(5) As String
        ObjParameter(0) = EmpresaA
        ObjParameter(1) = AmortizacionesPlantilla.Codigo
        ObjParameter(2) = AmortizacionesPlantilla.Cuenta
        ObjParameter(3) = AmortizacionesPlantilla.Tipo
        ObjParameter(4) = AmortizacionesPlantilla.CentroCosto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_AmortizacionesPlantilla", ObjParameter)
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
    'Public Sub Actualizar(ByVal AmortizacionesPlantilla As AmortizacionesPlantilla, Optional Tran As Boolean = False)
    '    Dim ObjParameter(6) As String
    '    ObjParameter(0) = AmortizacionesPlantilla.IdDetalle
    '    ObjParameter(1) = AmortizacionesPlantilla.Empresa
    '    ObjParameter(2) = AmortizacionesPlantilla.Codigo
    '    ObjParameter(3) = AmortizacionesPlantilla.Cuenta
    '    ObjParameter(4) = AmortizacionesPlantilla.Tipo
    '    ObjParameter(5) = AmortizacionesPlantilla.CentroCosto

    '    Try
    '        Me.InicializarMensajeError()
    '        Me.OpenSqlBD()

    '        Dim cmd As New SqlCommand
    '        cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_AmortizacionesPlantilla", ObjParameter)
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

        Return ObtieneDatos("sp_sel_AmortizacionesPlantilla", Id, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal AmortizacionesPlantilla As AmortizacionesPlantilla, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = AmortizacionesPlantilla.Codigo
        ObjParameter(1) = EmpresaA
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_AmortizacionesPlantilla", ObjParameter)
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

    ''-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    'Public Shared Function Detalles(ByVal Id As String) As AmortizacionesPlantilla
    '    Dim dt As DataTable = ObtieneDatos("sp_sel_AmortizacionesPlantilla", Id, EmpresaA)
    '    Dim det As New AmortizacionesPlantilla

    '    If dt.Rows.Count > 0 Then
    '        With dt.Rows(0)
    '            det.IdDetalle = .Item("IdDetalle")
    '            det.Empresa = .Item("Empresa")
    '            det.Codigo = .Item("Codigo")
    '            det.Cuenta = .Item("Cuenta")
    '            det.Tipo = .Item("Tipo")
    '            det.CentroCosto = .Item("CentroCosto")
    '        End With
    '    End If
    '    Return det
    'End Function
End Class
