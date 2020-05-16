
Imports System.Data.SqlClient

Public Class db_PNR_Antecedentes
    Inherits ClComun
    Dim vPNR_AntecedentesTabla As New PNR_Antecedentes
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property PNR_AntecedentesTabla() As PNR_Antecedentes
        Get
            Return vPNR_AntecedentesTabla
        End Get
        Set(ByVal value As PNR_Antecedentes)
            vPNR_AntecedentesTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal PNR_Antecedentes As PNR_Antecedentes, Optional Tran As Boolean = False)
        Dim ObjParameter(7) As String

        ObjParameter(0) = PNR_Antecedentes.IdPlanNegocio
        ObjParameter(1) = PNR_Antecedentes.Empresa
        ObjParameter(2) = PNR_Antecedentes.Periodo
        ObjParameter(3) = PNR_Antecedentes.Mz_Anterior
        ObjParameter(4) = PNR_Antecedentes.Mz_Actual
        ObjParameter(5) = PNR_Antecedentes.PBS_Anterior
        ObjParameter(6) = PNR_Antecedentes.PBS_Actual

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_PNR_Antecedentes", ObjParameter)
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
    Public Sub Actualizar(ByVal PNR_Antecedentes As PNR_Antecedentes, Optional Tran As Boolean = False)
        Dim ObjParameter(8) As String
        ObjParameter(0) = PNR_Antecedentes.IdAntecedente
        ObjParameter(1) = PNR_Antecedentes.IdPlanNegocio
        ObjParameter(2) = PNR_Antecedentes.Empresa
        ObjParameter(3) = PNR_Antecedentes.Periodo
        ObjParameter(4) = PNR_Antecedentes.Mz_Anterior
        ObjParameter(5) = PNR_Antecedentes.Mz_Actual
        ObjParameter(6) = PNR_Antecedentes.PBS_Anterior
        ObjParameter(7) = PNR_Antecedentes.PBS_Actual

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_PNR_Antecedentes", ObjParameter)
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

        Return ObtieneDatos("sp_sel_PNR_Antecedentes", Id, IdPlanNegocio, EmpresaActual, Periodo)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal PNR_Antecedentes As PNR_Antecedentes, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = PNR_Antecedentes.IdAntecedente
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_PNR_Antecedentes", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As PNR_Antecedentes
        Dim dt As DataTable = ObtieneDatos("sp_sel_PNR_Antecedentes", Id, 0, EmpresaActual)
        Dim det As New PNR_Antecedentes

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdAntecedente = .item("IdAntecedente")
                det.IdPlanNegocio = .item("IdPlanNegocio")
                det.Empresa = .item("Empresa")
                det.Periodo = .item("Periodo")
                det.Mz_Anterior = .item("Mz_Anterior")
                det.Mz_Actual = .item("Mz_Actual")
                det.PBS_Anterior = .item("PBS_Anterior")
                det.PBS_Actual = .item("PBS_Actual")
                det.Registro = .item("Registro")
                det.Usuario = .item("Usuario")
            End With
        End If
        Return det
    End Function
End Class
