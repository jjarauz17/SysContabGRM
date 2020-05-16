
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_AnticiposClientesDetalle
    Inherits ClComun
    Dim vAnticiposClientesDetalleTabla As New AnticiposClientesDetalle
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property AnticiposClientesDetalleTabla() As AnticiposClientesDetalle
        Get
            Return vAnticiposClientesDetalleTabla
        End Get
        Set(ByVal value As AnticiposClientesDetalle)
            vAnticiposClientesDetalleTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal AnticiposClientesDetalle As AnticiposClientesDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(6) As String
        ObjParameter(0) = AnticiposClientesDetalle.IdAnticipo
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = AnticiposClientesDetalle.Cuenta
        ObjParameter(3) = AnticiposClientesDetalle.Debito
        ObjParameter(4) = AnticiposClientesDetalle.Credito
        ObjParameter(5) = AnticiposClientesDetalle.Concepto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_AnticiposClientesDetalle", ObjParameter)
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
    Public Sub Actualizar(ByVal AnticiposClientesDetalle As AnticiposClientesDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(7) As String
        ObjParameter(0) = AnticiposClientesDetalle.IdDetalle
        ObjParameter(1) = AnticiposClientesDetalle.IdAnticipo
        ObjParameter(2) = EmpresaA
        ObjParameter(3) = AnticiposClientesDetalle.Cuenta
        ObjParameter(4) = AnticiposClientesDetalle.Debito
        ObjParameter(5) = AnticiposClientesDetalle.Credito
        ObjParameter(6) = AnticiposClientesDetalle.Concepto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_AnticiposClientesDetalle", ObjParameter)
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

        Return ObtieneDatos("sp_sel_AnticiposClientesDetalle", Id)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal AnticiposClientesDetalle As AnticiposClientesDetalle, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = AnticiposClientesDetalle.IdDetalle
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_AnticiposClientesDetalle", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As AnticiposClientesDetalle
        Dim dt As DataTable = ObtieneDatos("sp_sel_AnticiposClientesDetalle", Id)
        Dim det As New AnticiposClientesDetalle

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdDetalle = .Item("IdDetalle")
                det.IdAnticipo = .Item("IdAnticipo")
                det.Empresa = .Item("Empresa")
                det.Cuenta = .Item("Cuenta")
                det.Debito = .Item("Debito")
                det.Credito = .Item("Credito")
                det.Concepto = .Item("Concepto")
            End With
        End If
        Return det
    End Function
End Class
