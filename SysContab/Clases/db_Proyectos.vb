Imports System.IO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class db_Proyectos
    Inherits ClComun
    Dim vProyectosTabla As New Proyectos
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property ProyectosTabla() As Proyectos
        Get
            Return vProyectosTabla
        End Get
        Set(ByVal value As Proyectos)
            vProyectosTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal Proyectos As Proyectos, Optional Tran As Boolean = False) As Integer
        Dim ObjParameter(24) As String
        ObjParameter(0) = Proyectos.IdProyecto
        ObjParameter(1) = Proyectos.Numero
        ObjParameter(2) = EmpresaActual
        ObjParameter(3) = Proyectos.Codigo
        ObjParameter(4) = Proyectos.Nombre
        ObjParameter(5) = Proyectos.IdCliente
        ObjParameter(6) = Proyectos.Fecha
        ObjParameter(7) = Proyectos.Fecha_Inicio
        ObjParameter(8) = Proyectos.Fecha_Fin
        ObjParameter(9) = Proyectos.Duracion
        ObjParameter(10) = Proyectos.Cuenta
        ObjParameter(11) = Proyectos.CuentaCosto
        ObjParameter(12) = Proyectos.CuentaIngreso
        ObjParameter(13) = Proyectos.Linea
        ObjParameter(14) = Proyectos.Grupo
        ObjParameter(15) = Proyectos.Descripcion
        ObjParameter(16) = Proyectos.Estado
        ObjParameter(17) = Proyectos.Bodega
        ObjParameter(18) = Proyectos.ANombre
        ObjParameter(19) = Proyectos.IdCentro
        ObjParameter(20) = Proyectos.CodigoServicio
        ObjParameter(21) = Proyectos.Precio
        ObjParameter(22) = Proyectos.CABYS
        ObjParameter(23) = Proyectos.Impuesto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Proyectos", ObjParameter)
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
    Public Sub Actualizar(ByVal Proyectos As Proyectos, Optional Tran As Boolean = False)
        Dim ObjParameter(24) As String
        ObjParameter(0) = Proyectos.IdProyecto
        ObjParameter(1) = Proyectos.Numero
        ObjParameter(2) = EmpresaActual
        ObjParameter(3) = Proyectos.Codigo
        ObjParameter(4) = Proyectos.Nombre
        ObjParameter(5) = Proyectos.IdCliente
        ObjParameter(6) = Proyectos.Fecha
        ObjParameter(7) = Proyectos.Fecha_Inicio
        ObjParameter(8) = Proyectos.Fecha_Fin
        ObjParameter(9) = Proyectos.Duracion
        ObjParameter(10) = Proyectos.Cuenta
        ObjParameter(11) = Proyectos.CuentaCosto
        ObjParameter(12) = Proyectos.CuentaIngreso
        ObjParameter(13) = Proyectos.Linea
        ObjParameter(14) = Proyectos.Grupo
        ObjParameter(15) = Proyectos.Descripcion
        ObjParameter(16) = Proyectos.Estado
        ObjParameter(17) = Proyectos.Bodega
        ObjParameter(18) = Proyectos.ANombre
        ObjParameter(19) = Proyectos.IdCentro
        ObjParameter(20) = Proyectos.CodigoServicio
        ObjParameter(21) = Proyectos.Precio
        ObjParameter(22) = Proyectos.CABYS
        ObjParameter(23) = Proyectos.Impuesto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Proyectos", ObjParameter)
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

        Return ObtieneDatos("sp_sel_Proyectos",
                            Id,
                            Desde,
                            Hasta,
                            EmpresaActual)

    End Function

    Public Shared Function Fill(Optional Todo As Integer = 0) As Data.DataTable

        Return ObtieneDatos("sp_sel_ProyectosCombos",
                            EmpresaActual,
                            Todo)

    End Function

    Public Shared Function FillxCliente(IdCliente As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_ProyectosCombosCliente",
                            IdCliente,
                            EmpresaActual)

    End Function

    Public Shared Function FillxClienteCheck(IdCliente As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_ProyectosCombosClienteCheck",
                            IdCliente,
                            EmpresaActual)

    End Function

    Public Shared Function GetNumero() As String

        Return ObtieneDatos("sp_GetNumero_Proyecto",
                            EmpresaActual) _
                            .Rows _
                            .Item(0)("Numero")

    End Function

    Public Shared Function Pendientes(IdCliente As Integer) As Integer

        Return ObtieneDatos("sp_sel_ProyectosPendientes",
                            IdCliente,
                            EmpresaActual) _
                            .Rows _
                            .Item(0)("Cantidad")

    End Function

    Public Shared Function Reporte(Desde As Date, Hasta As Date) As Data.DataTable

        Return ObtieneDatos("sp_ProyectosReporte",
                            Desde,
                            Hasta,
                            EmpresaActual)

    End Function

    Public Shared Function ReporteImprimir(Desde As Date, Hasta As Date) As Data.DataTable

        'Return ObtieneDatos("sp_ProyectosReporteImpreso",
        '                    Desde,
        '                    Hasta,
        '                    EmpresaActual)

        Return ObtieneDatos("sp_ProyectosReporte",
                          Desde,
                          Hasta,
                          EmpresaActual)

    End Function


    Public Shared Function ProyectoFinalizar(IdProyecto As Integer) As Boolean

        Return Guardar("sp_upd_ProyectosFinalizar", IdProyecto, EmpresaActual)

    End Function

    Public Shared Sub Imprimir(IdProyecto As Integer)

        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        ShowSplash("Imprimiendo...")

        Try
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 26 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            '
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\rptProyecto.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()
        Catch ex As Exception
            Temp = False
        End Try

        Dim rpt As rptProyecto

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptProyecto.repx", True)
        Else
            rpt = New rptProyecto
        End If

        rpt.DataSource = ObtieneDatos("sp_sel_Proyecto_Imprimir", IdProyecto, EmpresaActual)
        rpt.ShowPrintMarginsWarning = False
        HideSplash()
        rpt.ShowRibbonPreview()
    End Sub

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Borrar(ByVal Proyectos As Proyectos, Optional Tran As Boolean = False) As String
        Dim ObjParameter(2) As String
        ObjParameter(0) = Proyectos.msg
        ObjParameter(1) = Proyectos.IdProyecto
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Proyectos", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As Integer) As Proyectos
        Dim dt As DataTable = ObtieneDatos("sp_sel_Proyectos", Id, Now.Date, Now.Date, EmpresaActual)
        Dim det As New Proyectos

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdProyecto = .Item("IdProyecto")
                det.Numero = .Item("Numero")
                det.Empresa = .Item("Empresa")
                det.Codigo = IsNull(.Item("Codigo"), "")
                det.CodigoServicio = IsNull(.Item("CodigoServicio"), "")
                det.Nombre = .Item("Nombre")
                det.IdCliente = .Item("IdCliente")
                det.IdCentro = .Item("IdCentro")
                det.ANombre = IsNull(.Item("ANombre"), "")
                det.Bodega = IsNull(.Item("Bodega"), "")
                det.Fecha = .Item("Fecha")
                det.Fecha_Inicio = .Item("Fecha_Inicio")
                det.Fecha_Fin = .Item("Fecha_Fin")
                det.Duracion = .Item("Duracion")
                det.Cuenta = .Item("Cuenta")
                det.CuentaCosto = IsNull(.Item("CuentaCosto"), "")
                det.CuentaIngreso = IsNull(.Item("CuentaIngreso"), "")
                det.Linea = IsNull(.Item("Linea"), "")
                det.Grupo = IsNull(.Item("Grupo"), "")
                det.Descripcion = .Item("Descripcion")
                det.Estado = .Item("Estado")
                det.Precio = .Item("Precio")
                det.CABYS = .Item("CABYS")
                det.Impuesto = .Item("Impuesto")
            End With
        End If
        Return det
    End Function
End Class
