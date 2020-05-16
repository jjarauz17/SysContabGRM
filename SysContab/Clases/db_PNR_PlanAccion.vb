
Imports System.Data.SqlClient

Public Class db_PNR_PlanAccion
    Inherits ClComun
    Dim vPNR_PlanAccionTabla As New PNR_PlanAccion
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property PNR_PlanAccionTabla() As PNR_PlanAccion
        Get
            Return vPNR_PlanAccionTabla
        End Get
        Set(ByVal value As PNR_PlanAccion)
            vPNR_PlanAccionTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal PNR_PlanAccion As PNR_PlanAccion, Optional Tran As Boolean = False)
        Dim ObjParameter(9) As String
        ObjParameter(0) = PNR_PlanAccion.IdPlanNegocio
        ObjParameter(1) = PNR_PlanAccion.Empresa
        ObjParameter(2) = PNR_PlanAccion.Nombre
        ObjParameter(3) = PNR_PlanAccion.IdResponsable
        ObjParameter(4) = PNR_PlanAccion.Fecha_Limite
        ObjParameter(5) = PNR_PlanAccion.Recursos
        ObjParameter(6) = PNR_PlanAccion.Avance
        ObjParameter(7) = PNR_PlanAccion.Fecha_Ejecucion
        ObjParameter(8) = PNR_PlanAccion.Gasto_Real

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_PNR_PlanAccion", ObjParameter)
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

    Public Sub InsertarxCultivo(ByVal PNR_PlanAccion As PNR_PlanAccion, Optional Tran As Boolean = False)
        Dim ObjParameter(12) As String

        ObjParameter(0) = PNR_PlanAccion.IdPlanNegocio
        ObjParameter(1) = PNR_PlanAccion.Empresa
        ObjParameter(2) = PNR_PlanAccion.Nombre
        ObjParameter(3) = PNR_PlanAccion.IdResponsable
        ObjParameter(4) = PNR_PlanAccion.Fecha_Limite
        ObjParameter(5) = PNR_PlanAccion.Recursos
        ObjParameter(6) = PNR_PlanAccion.Avance
        ObjParameter(7) = PNR_PlanAccion.Fecha_Ejecucion
        ObjParameter(8) = PNR_PlanAccion.Gasto_Real
        ObjParameter(9) = PNR_PlanAccion.Sucursal
        ObjParameter(10) = PNR_PlanAccion.Cultivo
        ObjParameter(11) = PNR_PlanAccion.Periodo

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_PNR_PlanAccionxCultivo", ObjParameter)
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
    Public Sub Actualizar(ByVal PNR_PlanAccion As PNR_PlanAccion, Optional Tran As Boolean = False)
        Dim ObjParameter(10) As String
        ObjParameter(0) = PNR_PlanAccion.IdPlanAccion
        ObjParameter(1) = PNR_PlanAccion.IdPlanNegocio
        ObjParameter(2) = PNR_PlanAccion.Empresa
        ObjParameter(3) = PNR_PlanAccion.Nombre
        ObjParameter(4) = PNR_PlanAccion.IdResponsable
        ObjParameter(5) = PNR_PlanAccion.Fecha_Limite
        ObjParameter(6) = PNR_PlanAccion.Recursos
        ObjParameter(7) = PNR_PlanAccion.Avance
        ObjParameter(8) = PNR_PlanAccion.Fecha_Ejecucion
        ObjParameter(9) = PNR_PlanAccion.Gasto_Real

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_PNR_PlanAccion", ObjParameter)
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
    Public Shared Function Listar(ByVal Id As String, IdPlanNegocio As Integer, Periodo As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_PNR_PlanAccion", Id, IdPlanNegocio, EmpresaActual, Periodo)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal PNR_PlanAccion As PNR_PlanAccion, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = PNR_PlanAccion.IdPlanAccion
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_PNR_PlanAccion", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As PNR_PlanAccion
        Dim dt As DataTable = ObtieneDatos("sp_sel_PNR_PlanAccion", Id, 0, EmpresaActual)
        Dim det As New PNR_PlanAccion

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdPlanAccion = .Item("IdPlanAccion")
                det.IdPlanNegocio = .Item("IdPlanNegocio")
                det.Empresa = .Item("Empresa")
                det.Nombre = .Item("Nombre")
                det.IdResponsable = .Item("IdResponsable")
                det.Fecha_Limite = .Item("Fecha_Limite")
                det.Recursos = .Item("Recursos")
                det.Avance = .Item("Avance")
                det.Fecha_Ejecucion = .Item("Fecha_Ejecucion")
                det.Gasto_Real = .Item("Gasto_Real")
                det.Registro = .Item("Registro")
                det.Usuario = .Item("Usuario")
            End With
        End If
        Return det
    End Function
End Class
