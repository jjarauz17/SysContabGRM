
Imports System.Data.SqlClient

Public Class db_PNR_PlanNegocio
    Inherits ClComun
    Dim vPNR_PlanNegocioTabla As New PNR_PlanNegocio
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property PNR_PlanNegocioTabla() As PNR_PlanNegocio
        Get
            Return vPNR_PlanNegocioTabla
        End Get
        Set(ByVal value As PNR_PlanNegocio)
            vPNR_PlanNegocioTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal PNR_PlanNegocio As PNR_PlanNegocio, Optional Tran As Boolean = False) As Integer

        Dim ObjParameter(16) As String
        ObjParameter(0) = PNR_PlanNegocio.IdPlanNegocio
        ObjParameter(1) = PNR_PlanNegocio.Codigo
        ObjParameter(2) = EmpresaActual
        ObjParameter(3) = PNR_PlanNegocio.Peridodo
        ObjParameter(4) = PNR_PlanNegocio.Fecha
        ObjParameter(5) = PNR_PlanNegocio.IdCliente
        ObjParameter(6) = PNR_PlanNegocio.IdResponsable
        ObjParameter(7) = PNR_PlanNegocio.IdPropiedad
        ObjParameter(8) = PNR_PlanNegocio.IdCultivo
        ObjParameter(9) = PNR_PlanNegocio.IdSucursal
        ObjParameter(10) = PNR_PlanNegocio.Total_Mz
        ObjParameter(11) = PNR_PlanNegocio.Mz_Atendidas
        ObjParameter(12) = PNR_PlanNegocio.Mz_Cultivo
        ObjParameter(13) = PNR_PlanNegocio.Potencial_Biologico
        ObjParameter(14) = PNR_PlanNegocio.Presentacion
        ObjParameter(15) = PNR_PlanNegocio.Observaciones

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_PNR_PlanNegocio", ObjParameter)
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
            Me.SendEmail(ex.Message)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal PNR_PlanNegocio As PNR_PlanNegocio, Optional Tran As Boolean = False)

        Dim ObjParameter(16) As String
        ObjParameter(0) = PNR_PlanNegocio.IdPlanNegocio
        ObjParameter(1) = PNR_PlanNegocio.Codigo
        ObjParameter(2) = EmpresaActual
        ObjParameter(3) = PNR_PlanNegocio.Peridodo
        ObjParameter(4) = PNR_PlanNegocio.Fecha
        ObjParameter(5) = PNR_PlanNegocio.IdCliente
        ObjParameter(6) = PNR_PlanNegocio.IdResponsable
        ObjParameter(7) = PNR_PlanNegocio.IdPropiedad
        ObjParameter(8) = PNR_PlanNegocio.IdCultivo
        ObjParameter(9) = PNR_PlanNegocio.IdSucursal
        ObjParameter(10) = PNR_PlanNegocio.Total_Mz
        ObjParameter(11) = PNR_PlanNegocio.Mz_Atendidas
        ObjParameter(12) = PNR_PlanNegocio.Mz_Cultivo
        ObjParameter(13) = PNR_PlanNegocio.Potencial_Biologico
        ObjParameter(14) = PNR_PlanNegocio.Presentacion
        ObjParameter(15) = PNR_PlanNegocio.Observaciones

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_PNR_PlanNegocio", ObjParameter)
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
            Me.SendEmail(ex.Message)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar(ByVal Id As String, Periodo As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_PNR_PlanNegocio", Id, EmpresaActual, Usuario_ID, Periodo)

    End Function

    Public Shared Function Listar2(Periodo As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_PNR_PlanNegocio_Trasladar", EmpresaActual, Periodo)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function GetNumero(Sucursal As String, Periodo As Integer) As String

        Return ObtieneDatos("PNR_GetNumeroPNR", Sucursal, EmpresaActual, Periodo).Rows.Item(0)("Numero")

    End Function

    Public Shared Function ValidarPNR(Cliente As String, Periodo As Integer, Cultivo As Integer, Sucursal As String) As Boolean

        'Verificar si ya existe
        If ObtieneDatos("JAR_ValidarPNR", Cliente, Periodo, Cultivo, Sucursal, EmpresaActual).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function GetPeriodos() As DataTable

        Return ObtieneDatos("PNR_GetPeriodos")

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function GetClientesAdicionales(Id As Integer) As DataTable

        Return ObtieneDatos("PRN_GetClientesAdicionales", Id)

    End Function

    Public Shared Function GetObjetivosEstrategicos(Periodo As Integer) As Data.DataTable

        Return ObtieneDatos("PNR_ReporteObjetivosEstrategicos", EmpresaActual, Periodo)

    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Borrar(ByVal PNR_PlanNegocio As PNR_PlanNegocio, Optional Tran As Boolean = False) As Boolean
        Dim ObjParameter(1) As String
        ObjParameter(0) = PNR_PlanNegocio.IdPlanNegocio
        ObjParameter(1) = ""

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_PNR_PlanNegocio", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If

            Return True ' cmd.Parameters(1).Value
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Me.SendEmail(ex.Message)
            Return False
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Id As String) As PNR_PlanNegocio
        Dim dt As DataTable = ObtieneDatos("sp_sel_PNR_PlanNegocio", Id, EmpresaActual, Usuario_ID)
        Dim det As New PNR_PlanNegocio

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdPlanNegocio = .item("IdPlanNegocio")
                det.Codigo = .item("Codigo")
                det.Empresa = .item("Empresa")
                det.Peridodo = .item("Peridodo")
                det.Fecha = .item("Fecha")
                det.IdCliente = .item("IdCliente")
                det.IdResponsable = .item("IdResponsable")
                det.IdPropiedad = .item("IdPropiedad")
                det.IdCultivo = .Item("IdCultivo")
                det.IdSucursal = .Item("IdSucursal")
                det.Total_Mz = .item("Total_Mz")
                det.Mz_Atendidas = .item("Mz_Atendidas")
                det.Mz_Cultivo = .item("Mz_Cultivo")
                det.Potencial_Biologico = .item("Potencial_Biologico")
                det.Presentacion = .Item("Presentacion")
                det.Registro = .item("Registro")
                det.Usuario = .Item("Usuario")
                det.Observaciones = .Item("Observaciones")
            End With
        End If
        Return det
    End Function

    Public Shared Function GuardarPNR_Trasladar(Periodo As Integer, NewPeriodo As Integer, DT_PNR As DataTable)

        '/**********************************************************************
        '** Inicializar la Transaccion Principal
        '**********************************************************************/
        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()

        Try
            Conn.RemoveParameters()
            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
            Conn.AddParameter("Periodo", SqlDbType.Int, 4, ParameterDirection.Input, Periodo)
            Conn.AddParameter("NewPeriodo", SqlDbType.Int, 4, ParameterDirection.Input, NewPeriodo)
            Conn.AddParameter("DT_PNR", SqlDbType.Structured, 0, ParameterDirection.Input, DT_PNR)

            Conn.EjecutarComando("JAR_GuardarPNR_Trasladar")
            Conn.CompletarTransaccion()

            Return True
        Catch ex As Exception
            Conn.AnularTransaccion()
            XtraMsg("Error al Guardar: " & vbCrLf & ex.Message, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

End Class
