
Imports System.Data.SqlClient

Public Class db_Presupuesto
    Inherits ClComun
    Dim vPresupuestoTabla As New Presupuesto
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property PresupuestoTabla() As Presupuesto
        Get
            Return vPresupuestoTabla
        End Get
        Set(ByVal value As Presupuesto)
            vPresupuestoTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal Presupuesto As Presupuesto, Optional Tran As Boolean = False) As Integer
        Dim ObjParameter(8) As String
        ObjParameter(0) = Presupuesto.IdPresupuesto
        ObjParameter(1) = Presupuesto.Codigo
        ObjParameter(2) = EmpresaActual
        ObjParameter(3) = Presupuesto.Periodo
        ObjParameter(4) = Presupuesto.Fecha
        ObjParameter(5) = Presupuesto.IdSucursal
        ObjParameter(6) = Presupuesto.IdCultivo
        ObjParameter(7) = Presupuesto.Descripcion


        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Presupuesto", ObjParameter)
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
    Public Sub Actualizar(ByVal Presupuesto As Presupuesto, Optional Tran As Boolean = False)
         Dim ObjParameter(8) As String
        ObjParameter(0) = Presupuesto.IdPresupuesto
        ObjParameter(1) = Presupuesto.Codigo
        ObjParameter(2) = EmpresaActual
        ObjParameter(3) = Presupuesto.Periodo
        ObjParameter(4) = Presupuesto.Fecha
        ObjParameter(5) = Presupuesto.IdSucursal
        ObjParameter(6) = Presupuesto.IdCultivo
        ObjParameter(7) = Presupuesto.Descripcion

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Presupuesto", ObjParameter)
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
    Public Shared Function Listar(ByVal Id As String, Periodo As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_Presupuesto", Id, EmpresaActual, Periodo)

    End Function

    Public Shared Function GetNumero(Sucursal As String) As String

        Return ObtieneDatos("sp_GetNumeroPresupuesto", Sucursal, EmpresaActual).Rows.Item(0)("Numero")

    End Function

    Public Shared Function ValidarPresupuesto(Periodo As Integer, Cultivo As Integer, Sucursal As String) As Boolean

        'Verificar si ya existe
        If ObtieneDatos("sp_validar_presupuesto", Periodo, Cultivo, Sucursal, EmpresaActual).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function ReporteDinamico(ByVal IdPresupuesto As Integer) As Data.DataTable

        Return ObtieneDatos("sp_dinamico_Presupuesto", IdPresupuesto, EmpresaActual)

    End Function

    Public Shared Function ReporteDinamicoConsolidado() As Data.DataTable

        Return ObtieneDatos("sp_dinamico_Presupuesto_Consolidado", EmpresaActual)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Presupuesto As Presupuesto, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Presupuesto.IdPresupuesto
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Presupuesto", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As Presupuesto
        Dim dt As DataTable = ObtieneDatos("sp_sel_Presupuesto", Id, EmpresaActual)
        Dim det As New Presupuesto

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdPresupuesto = .Item("IdPresupuesto")
                det.Codigo = .Item("Codigo")
                det.Empresa = .Item("Empresa")
                det.Periodo = .Item("Periodo")
                det.Fecha = .Item("Fecha")
                det.IdSucursal = .Item("IdSucursal")
                det.IdCultivo = .Item("IdCultivo")
                det.Descripcion = .Item("Descripcion")
            End With
        End If
        Return det
    End Function
End Class
