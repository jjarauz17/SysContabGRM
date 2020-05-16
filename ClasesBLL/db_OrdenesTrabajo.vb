
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_OrdenesTrabajo
    Inherits ClComun
    Dim vOrdenesTrabajoTabla As New OrdenesTrabajo
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property OrdenesTrabajoTabla() As OrdenesTrabajo
        Get
            Return vOrdenesTrabajoTabla
        End Get
        Set(ByVal value As OrdenesTrabajo)
            vOrdenesTrabajoTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal OrdenesTrabajo As OrdenesTrabajo, Optional Tran As Boolean = False) As Integer
        Dim ObjParameter(19) As String
        ObjParameter(0) = OrdenesTrabajo.IdOrden
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = OrdenesTrabajo.NoOrden
        ObjParameter(3) = OrdenesTrabajo.Documento
        ObjParameter(4) = OrdenesTrabajo.Fecha
        ObjParameter(5) = OrdenesTrabajo.Tipo_Mantenimiento
        ObjParameter(6) = OrdenesTrabajo.IdCliente
        ObjParameter(7) = OrdenesTrabajo.IdVendedor
        ObjParameter(8) = OrdenesTrabajo.Bodega
        ObjParameter(9) = OrdenesTrabajo.Fallas_Equipo
        ObjParameter(10) = OrdenesTrabajo.Trabajo_Realizado
        ObjParameter(11) = OrdenesTrabajo.Observaciones
        ObjParameter(12) = OrdenesTrabajo.Monto
        ObjParameter(13) = OrdenesTrabajo.SubTotal
        ObjParameter(14) = OrdenesTrabajo.IVA
        ObjParameter(15) = OrdenesTrabajo.Total
        ObjParameter(16) = OrdenesTrabajo.TCambio
        ObjParameter(17) = OrdenesTrabajo.Tipo
        ObjParameter(18) = OrdenesTrabajo.IdRemision

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_OrdenesTrabajo", ObjParameter)
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
            Return 0
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal OrdenesTrabajo As OrdenesTrabajo, Optional Tran As Boolean = False)
        Dim ObjParameter(18) As String
        ObjParameter(0) = OrdenesTrabajo.IdOrden
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = OrdenesTrabajo.NoOrden
        ObjParameter(3) = OrdenesTrabajo.Documento
        ObjParameter(4) = OrdenesTrabajo.Fecha
        ObjParameter(5) = OrdenesTrabajo.Tipo_Mantenimiento
        ObjParameter(6) = OrdenesTrabajo.IdCliente
        ObjParameter(7) = OrdenesTrabajo.IdVendedor
        ObjParameter(8) = OrdenesTrabajo.Bodega
        ObjParameter(9) = OrdenesTrabajo.Fallas_Equipo
        ObjParameter(10) = OrdenesTrabajo.Trabajo_Realizado
        ObjParameter(11) = OrdenesTrabajo.Observaciones
        ObjParameter(12) = OrdenesTrabajo.Monto
        ObjParameter(13) = OrdenesTrabajo.SubTotal
        ObjParameter(14) = OrdenesTrabajo.IVA
        ObjParameter(15) = OrdenesTrabajo.Total
        ObjParameter(16) = OrdenesTrabajo.TCambio
        ObjParameter(17) = OrdenesTrabajo.Tipo

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_OrdenesTrabajo", ObjParameter)
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
    Public Shared Function Listar(ByVal Id As String, Desde As Date, Hasta As Date) As Data.DataTable

        Return ObtieneDatos("sp_sel_OrdenesTrabajo",
                            Id,
                            Desde,
                            Hasta,
                            EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

    Public Shared Function GetNumero() As String

        Return ObtieneDatos("sp_OrdenesTrabajo_numero", EmpresaA).Rows.Item(0)("Numero")

    End Function
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

    Public Shared Function UpdateRemisiones(IdOrden As Integer,
                                            Optional Estado As String = "N",
                                            Optional IdProyecto As Integer = 0) As Boolean

        Return fn.Guardar("sp_upd_OrdenTrabajoRemision",
                          IdOrden,
                          EmpresaA,
                          Estado,
                          IdProyecto)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --    

    Public Shared Function Pendientes(IdCliente As Integer) As Integer

        Return ObtieneDatos("sp_sel_OrdenesTrabajo_Pendientes", IdCliente, EmpresaA).Rows.Item(0)("Cantidad")

    End Function

    Public Shared Function Reporte(Desde As Date, Hasta As Date) As Data.DataTable

        Return ObtieneDatos("sp_sel_OrdenesTrabajoReporte",
                            Desde,
                            Hasta,
                            EmpresaA)

    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

    Public Function Borrar(ByVal OrdenesTrabajo As OrdenesTrabajo, Optional Tran As Boolean = False) As Boolean
        Dim ObjParameter(1) As String
        ObjParameter(0) = OrdenesTrabajo.IdOrden
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_OrdenesTrabajo", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If

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

    Public Function Facturar(IdOrden As String,
                             Factura As String,
                             Optional Tran As Boolean = False) As Boolean

        Dim ObjParameter(3) As String
        ObjParameter(0) = IdOrden
        ObjParameter(1) = Factura
        ObjParameter(2) = EmpresaA

        Try

            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_OrdenesTrabajo_Facturar", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If

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

    Public Shared Function Detalles(ByVal Id As String) As OrdenesTrabajo
        Dim dt As DataTable = ObtieneDatos("sp_sel_OrdenesTrabajo", Id, Now.Date, Now.Date, EmpresaA)
        Dim det As New OrdenesTrabajo

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdOrden = .Item("IdOrden")
                det.Empresa = .Item("Empresa")
                det.NoOrden = .Item("NoOrden")
                det.Tipo = .Item("Tipo")
                det.Documento = .Item("Documento")
                det.Fecha = .Item("Fecha")
                det.Tipo_Mantenimiento = .Item("Tipo_Mantenimiento")
                det.IdCliente = .Item("IdCliente")
                det.IdVendedor = .Item("IdVendedor")
                det.Bodega = .Item("Bodega")
                det.Fallas_Equipo = .Item("Fallas_Equipo")
                det.Trabajo_Realizado = .Item("Trabajo_Realizado")
                det.Observaciones = .Item("Observaciones")
                det.Monto = .Item("Monto")
                det.SubTotal = .Item("SubTotal")
                det.IVA = .Item("IVA")
                det.Total = .Item("Total")
                det.TCambio = .Item("TCambio")
                det.Estado = .Item("Estado")
                det.Usuario = .Item("Usuario")
                '  det.Fecha_Creacion = .Item("Fecha_Creacion")
                ' det.Usuario_Modifica = .Item("Usuario_Modifica")
                ' det.Fecha_Modifica = .Item("Fecha_Modifica")
            End With
        End If
        Return det
    End Function
End Class
