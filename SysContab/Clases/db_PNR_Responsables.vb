
Imports System.Data.SqlClient

Public Class db_PNR_Responsables
    Inherits ClComun
    Dim vPNR_ResponsablesTabla As New PNR_Responsables
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property PNR_ResponsablesTabla() As PNR_Responsables
        Get
            Return vPNR_ResponsablesTabla
        End Get
        Set(ByVal value As PNR_Responsables)
            vPNR_ResponsablesTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal PNR_Responsables As PNR_Responsables, Optional Tran As Boolean = False)
        Dim ObjParameter(3) As String
        ObjParameter(0) = PNR_Responsables.Empresa
        ObjParameter(1) = PNR_Responsables.Nombre
        ObjParameter(2) = PNR_Responsables.Cargo

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            vPNR_ResponsablesTabla.IdResponsable = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_PNR_Responsables", ObjParameter).ExecuteNonQuery()
            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            'Me.MensajeError = ex.Message
            'Me.SendEmail(ex.Message)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal PNR_Responsables As PNR_Responsables, Optional Tran As Boolean = False)
        Dim ObjParameter(4) As String
        ObjParameter(0) = PNR_Responsables.IdResponsable
        ObjParameter(1) = PNR_Responsables.Empresa
        ObjParameter(2) = PNR_Responsables.Nombre
        ObjParameter(3) = PNR_Responsables.Cargo

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            vPNR_ResponsablesTabla.IdResponsable = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_PNR_Responsables", ObjParameter).ExecuteNonQuery()
            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            'Me.MensajeError = ex.Message
            'Me.SendEmail(ex.Message)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_PNR_Responsables", Id, EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Borrar(ByVal PNR_Responsables As PNR_Responsables, Optional Tran As Boolean = False) As Boolean
        Dim ObjParameter(1) As String
        ObjParameter(0) = PNR_Responsables.IdResponsable
        ObjParameter(1) = PNR_Responsables.IdResponsable
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_PNR_Responsables", ObjParameter).ExecuteNonQuery()
            If Tran = False Then
                Commit()
            End If
            '
            Return True
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return False            
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Id As String) As PNR_Responsables
        Dim dt As DataTable = ObtieneDatos("sp_sel_PNR_Responsables", Id, EmpresaActual)
        Dim det As New PNR_Responsables

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdResponsable = .Item("IdResponsable")
                det.Empresa = .Item("Empresa")
                det.Nombre = .Item("Nombre")
                det.Cargo = .Item("Cargo")
                det.Registro = .Item("Registro")
                det.Usuario = .Item("Usuario")
            End With
        End If
        Return det
    End Function
End Class
