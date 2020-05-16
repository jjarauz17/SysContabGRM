Imports System.IO
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class db_OrdenesEntrega
    Inherits ClComun
    Dim vOrdenesEntregaTabla As New OrdenesEntrega
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property OrdenesEntregaTabla() As OrdenesEntrega
        Get
            Return vOrdenesEntregaTabla
        End Get
        Set(ByVal value As OrdenesEntrega)
            vOrdenesEntregaTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal OrdenesEntrega As OrdenesEntrega, Optional Tran As Boolean = False) As Integer

        Dim ObjParameter(25) As String
        ObjParameter(0) = OrdenesEntrega.IdOrden
        ObjParameter(1) = OrdenesEntrega.NoOrden
        ObjParameter(2) = OrdenesEntrega.Referencia
        ObjParameter(3) = OrdenesEntrega.Sucursal
        ObjParameter(4) = EmpresaA
        ObjParameter(5) = OrdenesEntrega.Fecha.Date
        ObjParameter(6) = OrdenesEntrega.IdCliente
        ObjParameter(7) = OrdenesEntrega.Moneda
        ObjParameter(8) = OrdenesEntrega.Monto
        ObjParameter(9) = OrdenesEntrega.SubTotal
        ObjParameter(10) = OrdenesEntrega.IVA
        ObjParameter(11) = OrdenesEntrega.Total
        ObjParameter(12) = OrdenesEntrega.TCambio
        ObjParameter(13) = OrdenesEntrega.Concepto
        ObjParameter(14) = OrdenesEntrega.Direccion
        ObjParameter(15) = OrdenesEntrega.Transporte
        ObjParameter(16) = OrdenesEntrega.Placa
        ObjParameter(17) = OrdenesEntrega.Conductor
        ObjParameter(18) = OrdenesEntrega.Tipo
        ObjParameter(19) = OrdenesEntrega.Destino
        ObjParameter(20) = OrdenesEntrega.Responsable
        ObjParameter(21) = OrdenesEntrega.IdCentro
        ObjParameter(22) = OrdenesEntrega.ANombre
        ObjParameter(23) = OrdenesEntrega.Solicitado
        ObjParameter(24) = OrdenesEntrega.IdProyecto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_OrdenesEntrega", ObjParameter)
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
            Return False
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal OrdenesEntrega As OrdenesEntrega, Optional Tran As Boolean = False)
        Dim ObjParameter(25) As String
        ObjParameter(0) = OrdenesEntrega.IdOrden
        ObjParameter(1) = OrdenesEntrega.NoOrden
        ObjParameter(2) = OrdenesEntrega.Referencia
        ObjParameter(3) = OrdenesEntrega.Sucursal
        ObjParameter(4) = EmpresaA
        ObjParameter(5) = OrdenesEntrega.Fecha
        ObjParameter(6) = OrdenesEntrega.IdCliente
        ObjParameter(7) = OrdenesEntrega.Moneda
        ObjParameter(8) = OrdenesEntrega.Monto
        ObjParameter(9) = OrdenesEntrega.SubTotal
        ObjParameter(10) = OrdenesEntrega.IVA
        ObjParameter(11) = OrdenesEntrega.Total
        ObjParameter(12) = OrdenesEntrega.TCambio
        ObjParameter(13) = OrdenesEntrega.Concepto
        ObjParameter(14) = OrdenesEntrega.Direccion
        ObjParameter(15) = OrdenesEntrega.Transporte
        ObjParameter(16) = OrdenesEntrega.Placa
        ObjParameter(17) = OrdenesEntrega.Conductor
        ObjParameter(18) = OrdenesEntrega.Tipo
        ObjParameter(19) = OrdenesEntrega.Destino
        ObjParameter(20) = OrdenesEntrega.Responsable
        ObjParameter(21) = OrdenesEntrega.IdCentro
        ObjParameter(22) = OrdenesEntrega.ANombre
        ObjParameter(23) = OrdenesEntrega.Solicitado
        ObjParameter(24) = OrdenesEntrega.IdProyecto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_OrdenesEntrega", ObjParameter)
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
    Public Sub Autorizar(ByVal OrdenesEntrega As OrdenesEntrega, Estado As Integer, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = OrdenesEntrega.IdOrden
        ObjParameter(1) = Estado
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_OrdenesEntrega_Autorizado", ObjParameter)
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

    Public Sub Traslado_Marcar(ByVal OrdenesEntrega As OrdenesEntrega, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = OrdenesEntrega.IdOrden

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_OrdenesEntrega_Traslado", ObjParameter)
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

        Return ObtieneDatos("sp_sel_OrdenesEntrega", Id, Desde, Hasta, EmpresaA)

    End Function

    Public Shared Function ListarPendiente() As Data.DataTable

        Return ObtieneDatos("sp_sel_OrdenesEntrega_Pendientes", EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function GetNumero() As String

        Return ObtieneDatos("sp_OrdenesEntrega_numero", EmpresaA).Rows.Item(0)("Numero")

    End Function

    Public Shared Function ValidarProductosNuevos(IdOrden As Integer) As String

        Return ObtieneDatos("sp_OrdenesEntrega_validarNuevos", IdOrden, EmpresaA).Rows.Item(0)("Msg")

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Imprimir(IdOrden As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_OrdenesEntrega_Imprimir", IdOrden, EmpresaA)

    End Function



    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    'Public Shared Function Imprimir(IdOrden As Integer) As XtraReport

    '    Dim Cadena As String
    '    Dim Temp As Boolean = False
    '    Dim Data() As Byte

    '    Try
    '        Data = CType(ObtieneDatos("sp_get_formato_imprimir", 12, EmpresaA).Rows(0).Item(0), Byte())
    '        Temp = True
    '        '
    '        Dim Tamano As Integer
    '        Tamano = Data.GetUpperBound(0)
    '        Cadena = Application.StartupPath & "\rptOrdenEntrega.repx"
    '        If File.Exists(Cadena) Then Kill(Cadena)
    '        Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
    '        Archivo.Write(Data, 0, Tamano)
    '        Archivo.Close()
    '    Catch ex As Exception
    '        Temp = False
    '    End Try

    '    Dim rpt As rptOrdenEntrega

    '    If Temp = True Then
    '        rpt = XtraReport.FromFile(Application.StartupPath & "\rptProyecto.repx", True)
    '    Else
    '        rpt = New rptOrdenEntrega
    '    End If

    '    rpt.DataSource = ObtieneDatos("sp_sel_Proyecto_Imprimir", IdOrden, EmpresaA)
    '    rpt.ShowPrintMarginsWarning = False

    '    Return rpt
    'End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal OrdenesEntrega As OrdenesEntrega, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = OrdenesEntrega.IdOrden
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_OrdenesEntrega", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As OrdenesEntrega
        Dim dt As DataTable = ObtieneDatos("sp_sel_OrdenesEntrega", Id, Now.Date, Now.Date, EmpresaA)
        Dim det As New OrdenesEntrega

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdOrden = .Item("IdOrden")
                det.NoOrden = .Item("NoOrden")
                det.Tipo = .Item("Tipo")
                det.Referencia = .Item("Referencia")
                det.Sucursal = .Item("Sucursal")
                det.IdCentro = .Item("IdCentro")
                det.Destino = .Item("Destino")
                det.Empresa = .Item("Empresa")
                det.Fecha = .Item("Fecha")
                det.IdProyecto = .Item("IdProyecto")
                det.IdCliente = .Item("IdCliente")
                det.ANombre = .Item("ANombre")
                det.Responsable = .Item("Responsable")
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
                det.Solicitado = .Item("Solicitado")
                det.Autorizado = IIf(.Item("Autorizado"), 1, 0)
                det.Bodega = .Item("Bodega")
                'det.Fecha_Creacion = .Item("Fecha_Creacion")
                'det.Usuario_Modifica = .Item("Usuario_Modifica")
                'det.Fecha_Modifica = .Item("Fecha_Modifica")
            End With
        End If
        Return det
    End Function
End Class
