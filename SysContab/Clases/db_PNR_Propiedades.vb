
Imports System.Data.SqlClient

Public Class db_PNR_Propiedades
    Inherits ClComun
    Dim vPNR_PropiedadesTabla As New PNR_Propiedades
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property PNR_PropiedadesTabla() As PNR_Propiedades
        Get
            Return vPNR_PropiedadesTabla
        End Get
        Set(ByVal value As PNR_Propiedades)
            vPNR_PropiedadesTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal PNR_Propiedades As PNR_Propiedades, Optional Tran As Boolean = False) As Integer
        Dim ObjParameter(10) As String
        ObjParameter(0) = PNR_Propiedades.IdPropiedad
        ObjParameter(1) = PNR_Propiedades.Empresa
        ObjParameter(2) = PNR_Propiedades.Nombre
        ObjParameter(3) = PNR_Propiedades.IdCliente
        ObjParameter(4) = PNR_Propiedades.Total_Mz
        ObjParameter(5) = PNR_Propiedades.Mz_Atendidas
        ObjParameter(6) = PNR_Propiedades.IdCultivo
        ObjParameter(7) = PNR_Propiedades.Mz_Cultivo
        ObjParameter(8) = PNR_Propiedades.Potencial_Biologico
        ObjParameter(9) = PNR_Propiedades.Periodo
        'ObjParameter(8) = PNR_Propiedades.Regristro
        'ObjParameter(9) = PNR_Propiedades.Usuario

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_PNR_Propiedades", ObjParameter)
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
            'Me.MensajeError = ex.Message
            Me.SendEmail(ex.Message)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal PNR_Propiedades As PNR_Propiedades, Optional Tran As Boolean = False)
        Dim ObjParameter(10) As String
        ObjParameter(0) = PNR_Propiedades.IdPropiedad
        ObjParameter(1) = PNR_Propiedades.Empresa
        ObjParameter(2) = PNR_Propiedades.Nombre
        ObjParameter(3) = PNR_Propiedades.IdCliente
        ObjParameter(4) = PNR_Propiedades.Total_Mz
        ObjParameter(5) = PNR_Propiedades.Mz_Atendidas
        ObjParameter(6) = PNR_Propiedades.IdCultivo
        ObjParameter(7) = PNR_Propiedades.Mz_Cultivo
        ObjParameter(8) = PNR_Propiedades.Potencial_Biologico
        ObjParameter(9) = PNR_Propiedades.Periodo
        'ObjParameter(9) = PNR_Propiedades.Regristro
        'ObjParameter(10) = PNR_Propiedades.Usuario

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            vPNR_PropiedadesTabla.IdPropiedad = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_PNR_Propiedades", ObjParameter).ExecuteNonQuery()
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
    Public Shared Function Listar(Id As Integer, IdCliente As Integer, Periodo As Integer) As Data.DataTable
        Return ObtieneDatos("sp_sel_PNR_Propiedades", Id, IdCliente, EmpresaActual, Periodo)
    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Borrar(ByVal PNR_Propiedades As PNR_Propiedades, Optional Tran As Boolean = False) As String
        Dim ObjParameter(2) As String
        ObjParameter(0) = PNR_Propiedades.IdPropiedad
        ObjParameter(1) = PNR_Propiedades.Valor
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            Dim cmd As New SqlCommand

            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_PNR_Propiedades", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If
            '
            Return cmd.Parameters(1).Value
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
    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Id As String, IdCliente As Integer, Periodo As Integer) As PNR_Propiedades
        Dim dt As DataTable = ObtieneDatos("sp_sel_PNR_Propiedades", Id, IdCliente, EmpresaActual, Periodo)
        Dim det As New PNR_Propiedades

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdPropiedad = .Item("IdPropiedad")
                det.Empresa = .Item("Empresa")
                det.Nombre = .Item("Nombre")
                det.IdCliente = .Item("IdCliente")
                det.Total_Mz = .Item("Total_Mz")
                det.Mz_Atendidas = .Item("Mz_Atendidas")
                det.IdCultivo = .Item("IdCultivo")
                det.Mz_Cultivo = .Item("Mz_Cultivo")
                det.Potencial_Biologico = .Item("Potencial_Biologico")
                det.Regristro = .Item("Regristro")
                det.Usuario = .Item("Usuario")
                det.Periodo = .Item("Periodo")
            End With
        End If
        Return det
    End Function
End Class
