
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_Remisiones
    Inherits ClComun
    Dim vRemisionesTabla As New Remisiones
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property RemisionesTabla() As Remisiones
        Get
            Return vRemisionesTabla
        End Get
        Set(ByVal value As Remisiones)
            vRemisionesTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal Remisiones As Remisiones, Optional Tran As Boolean = False) As Integer
        Dim ObjParameter(23) As String

        ObjParameter(0) = Remisiones.IdRemision
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = Remisiones.NoRemision
        ObjParameter(3) = Remisiones.NoOrden
        ObjParameter(4) = Remisiones.Referencia
        ObjParameter(5) = Remisiones.Sucursal
        ObjParameter(6) = Remisiones.Fecha
        ObjParameter(7) = Remisiones.IdCliente
        ObjParameter(8) = Remisiones.Moneda
        ObjParameter(9) = Remisiones.Monto
        ObjParameter(10) = Remisiones.SubTotal
        ObjParameter(11) = Remisiones.IVA
        ObjParameter(12) = Remisiones.Total
        ObjParameter(13) = Remisiones.TCambio
        ObjParameter(14) = Remisiones.Concepto
        ObjParameter(15) = Remisiones.Direccion
        ObjParameter(16) = Remisiones.Transporte
        ObjParameter(17) = Remisiones.Placa
        ObjParameter(18) = Remisiones.Conductor
        ObjParameter(19) = IIf(Remisiones.Exento, 1, 0)
        ObjParameter(19) = IIf(Remisiones.Exento, 1, 0)
        ObjParameter(20) = Remisiones.Bodega
        ObjParameter(21) = Remisiones.ANombre
        ObjParameter(22) = Remisiones.IdProyecto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Remisiones", ObjParameter)
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
    Public Sub Actualizar(ByVal Remisiones As Remisiones, Optional Tran As Boolean = False)
        Dim ObjParameter(23) As String

        ObjParameter(0) = Remisiones.IdRemision
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = Remisiones.NoRemision
        ObjParameter(3) = Remisiones.NoOrden
        ObjParameter(4) = Remisiones.Referencia
        ObjParameter(5) = Remisiones.Sucursal
        ObjParameter(6) = Remisiones.Fecha
        ObjParameter(7) = Remisiones.IdCliente
        ObjParameter(8) = Remisiones.Moneda
        ObjParameter(9) = Remisiones.Monto
        ObjParameter(10) = Remisiones.SubTotal
        ObjParameter(11) = Remisiones.IVA
        ObjParameter(12) = Remisiones.Total
        ObjParameter(13) = Remisiones.TCambio
        ObjParameter(14) = Remisiones.Concepto
        ObjParameter(15) = Remisiones.Direccion
        ObjParameter(16) = Remisiones.Transporte
        ObjParameter(17) = Remisiones.Placa
        ObjParameter(18) = Remisiones.Conductor
        ObjParameter(19) = IIf(Remisiones.Exento, 1, 0)
        ObjParameter(20) = Remisiones.Bodega
        ObjParameter(21) = Remisiones.ANombre
        ObjParameter(22) = Remisiones.IdProyecto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Remisiones", ObjParameter)
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

        Return ObtieneDatos("sp_sel_Remisiones", Id, Desde, Hasta, EmpresaA)

    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Reporte(Desde As Date, Hasta As Date, Moneda As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_RemisionesReporte", Desde, Hasta, Moneda, EmpresaA)

    End Function

    Public Shared Function ListarPendientes(IdCliente As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_Remisiones_Pendientes", EmpresaA, IdCliente)

    End Function

    Public Shared Function Pendientes(IdCliente As Integer) As Integer

        Return ObtieneDatos("sp_sel_RemisionesPendientesCantidad", EmpresaA, IdCliente).Rows.Item(0)("Cantidad")

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function GetNumero() As String

        Return ObtieneDatos("sp_Remisiones_numero", EmpresaA).Rows.Item(0)("Numero")

    End Function

    Public Shared Function Remisiones_Parcelas(IdRemision As Integer, Empresa As Integer) As Boolean

        Return fn.Guardar("sp_upd_remisionesParcelas", Empresa, IdRemision)

    End Function

    Public Shared Function RemisionesActualizarProyecto(IdRemision As Integer, IdProyecto As Integer) As Boolean

        Return fn.Guardar("sp_upd_RemisionesProyectos", IdRemision, IdProyecto, EmpresaA)

    End Function

    Public Shared Function UpdateEstado(IdRemision As Integer, Estado As String) As Boolean

        Return fn.Guardar("sp_upd_RemisionesEstado", IdRemision, Estado, EmpresaA)

    End Function


    Public Shared Function Remisiones_Contabilizar(IdRemision As Integer, Empresa As Integer) As DataTable

        Return ObtieneDatos("sp_Remisiones_Contabilizar", IdRemision, Empresa)

    End Function

    Public Shared Function Remisiones_UpdateContabilizar(IdRemision As Integer, Comp_No As Integer, Per_Id As Integer, Mes As Integer, Empresa As Integer) As Boolean

        Return fn.Guardar("sp_upd_remisionesContabilizar", IdRemision, Comp_No, Per_Id, Mes, Empresa)

    End Function

    Public Shared Function Imprimir(IdRemision As Integer) As DataTable

        Return ObtieneDatos("sp_sel_Remisiones_Imprimir", IdRemision, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Remisiones As Remisiones, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Remisiones.IdRemision
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Remisiones", ObjParameter)
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

    Public Sub Traslado_Marcar(ByVal Remisiones As Remisiones, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Remisiones.IdRemision
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Remisiones_Traslado", ObjParameter)
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

    Public Function Facturar(ByVal Remisiones As Remisiones, IdRemision As String, Optional Tran As Boolean = False) As Boolean
        Dim ObjParameter(2) As String
        ObjParameter(0) = IdRemision
        ObjParameter(1) = Remisiones.Factura
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Remisiones_Facturar", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As Remisiones
        Dim dt As DataTable = ObtieneDatos("sp_sel_Remisiones", Id, Now.Date, Now.Date, EmpresaA)
        Dim det As New Remisiones

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdRemision = .Item("IdRemision")
                det.Empresa = .Item("Empresa")
                det.NoRemision = .Item("NoRemision")
                det.NoOrden = .Item("NoOrden")
                det.Referencia = .Item("Referencia")
                det.Sucursal = .Item("Sucursal")
                det.Fecha = .Item("Fecha")
                det.IdProyecto = .Item("IdProyecto")
                det.IdCliente = .Item("IdCliente")
                det.ANombre = .Item("ANombre")
                det.Moneda = .Item("Moneda")
                det.Monto = .Item("Monto")
                det.SubTotal = .Item("SubTotal")
                det.IVA = .Item("IVA")
                det.Total = .Item("Total")
                det.TCambio = .Item("TCambio")
                det.Concepto = .Item("Concepto")
                det.Direccion = .Item("Direccion")
                det.Transporte = .Item("Transporte")
                det.Placa = .Item("Placa")
                det.Conductor = .Item("Conductor")
                det.Estado = .Item("Estado")
                det.Activo = .Item("Activo")
                det.Usuario = .Item("Usuario")
                det.Fecha_Creacion = .Item("Fecha_Creacion")
                det.Bodega = .Item("Bodega")
                det.Exento = .Item("Exento")

                ' det.Usuario_Modifica = .Item("Usuario_Modifica")
                ' det.Fecha_Modifica = .Item("Fecha_Modifica")
            End With
        End If
        Return det
    End Function
End Class
