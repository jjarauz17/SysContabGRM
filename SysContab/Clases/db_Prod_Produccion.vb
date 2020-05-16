Imports System.IO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class db_Prod_Produccion
    Inherits ClComun
    Dim vProd_ProduccionTabla As New Prod_Produccion
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Prod_ProduccionTabla() As Prod_Produccion
        Get
            Return vProd_ProduccionTabla
        End Get
        Set(ByVal value As Prod_Produccion)
            vProd_ProduccionTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal Prod_Produccion As Prod_Produccion, Optional Tran As Boolean = False) As Integer

        Dim ObjParameter(12) As String
        ObjParameter(0) = Prod_Produccion.IdSysProduccion
        ObjParameter(1) = Prod_Produccion.Empresa
        ObjParameter(2) = Prod_Produccion.IdSysEstadoPRoduccion
        ObjParameter(3) = Prod_Produccion.FechaProduccion
        ObjParameter(4) = Prod_Produccion.NumeroProduccion
        ObjParameter(5) = Prod_Produccion.IdSysFormula
        ObjParameter(6) = Prod_Produccion.CantidadProducir
        ObjParameter(7) = Prod_Produccion.CantidadRealProducida
        ObjParameter(8) = Prod_Produccion.CostoProduccion
        ObjParameter(9) = Prod_Produccion.Observaciones
        ObjParameter(10) = Prod_Produccion.NoDocumento
        ObjParameter(11) = Prod_Produccion.Bodega

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Prod_Produccion", ObjParameter)
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
    Public Sub Actualizar(ByVal Prod_Produccion As Prod_Produccion, Optional Tran As Boolean = False)
        Dim ObjParameter(12) As String
        ObjParameter(0) = Prod_Produccion.IdSysProduccion
        ObjParameter(1) = Prod_Produccion.Empresa
        ObjParameter(2) = Prod_Produccion.IdSysEstadoPRoduccion
        ObjParameter(3) = Prod_Produccion.FechaProduccion
        ObjParameter(4) = Prod_Produccion.NumeroProduccion
        ObjParameter(5) = Prod_Produccion.IdSysFormula
        ObjParameter(6) = Prod_Produccion.CantidadProducir
        ObjParameter(7) = Prod_Produccion.CantidadRealProducida
        ObjParameter(8) = Prod_Produccion.CostoProduccion
        ObjParameter(9) = Prod_Produccion.Observaciones
        ObjParameter(10) = Prod_Produccion.NoDocumento
        ObjParameter(11) = Prod_Produccion.Bodega

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Prod_Produccion", ObjParameter)
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

    Public Sub GenerarProduccion(ByVal Prod_Produccion As Prod_Produccion, Optional Tran As Boolean = False)
        Dim ObjParameter(4) As String
        ObjParameter(0) = Prod_Produccion.IdSysProduccion
        ObjParameter(1) = Prod_Produccion.Empresa
        ObjParameter(2) = Prod_Produccion.FechaGeneraProduccion        
        ObjParameter(3) = Prod_Produccion.Observaciones2

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Prod_ProduccionGenerar", ObjParameter)
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

    Public Sub FinalizarProduccion(ByVal Prod_Produccion As Prod_Produccion, Optional Tran As Boolean = False)

        Dim ObjParameter(7) As String
        ObjParameter(0) = Prod_Produccion.IdProduccion
        ObjParameter(1) = Prod_Produccion.Empresa
        ObjParameter(2) = Prod_Produccion.FechaFinalizaProduccion
        ObjParameter(3) = Prod_Produccion.ND
        ObjParameter(4) = Prod_Produccion.NC
        ObjParameter(5) = Prod_Produccion.NoDocumento
        ObjParameter(6) = Prod_Produccion.Observaciones3

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Prod_ProduccionFinalizar", ObjParameter)
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
    Public Shared Function Listar(ByVal Id As String, Estado As String, Desde As Date, Hasta As Date) As Data.DataTable

        Return ObtieneDatos("sp_sel_Prod_Produccion", Id, EmpresaActual, Estado, Desde, Hasta)

    End Function

    Public Shared Function ListarGenear(ByVal Id As String, Desde As Date, Hasta As Date) As Data.DataTable

        Return ObtieneDatos("sp_sel_Prod_Produccion_Pendiente", EmpresaActual, Desde, Hasta)
    End Function

    Public Shared Function ListarFinalizar(ByVal Id As String, Desde As Date, Hasta As Date) As Data.DataTable

        Return ObtieneDatos("sp_sel_Prod_Produccion_Pendiente_Finalizar", EmpresaActual, Desde, Hasta)

    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function GetNumero() As String

        Return ObtieneDatos("sp_GetNumero_Produccion", EmpresaActual).Rows.Item(0)("Numero")

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Sub Imprimir(ByVal Id As String, Etiqueta As String)

        Dim Temp As Boolean = False

        ShowSplash("Imprimiendo...")

        Try

            Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 7 And Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            Dim Tamano As Integer = Data.GetUpperBound(0)
            Dim Cadena As String = Application.StartupPath & "\rptProduccion.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

            Temp = True
        Catch ex As Exception
            Temp = False
        End Try
        '
        Dim rpt As Rpt_Produccion

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptProduccion.repx", True)
        Else
            rpt = New Rpt_Produccion
        End If
        '
        Dim DT_DEV As DataTable = ObtieneDatos("sp_Imprimir_ProduccionDevoluciones", Id, EmpresaActual)
        Dim rpt_Dev As New rptProduccionDevoluciones
        rpt_Dev.DataSource = DT_DEV
        If DT_DEV.Rows.Count = 0 Then rpt_Dev.lbltitulo.Visible = False

        rpt.DataSource = ObtieneDatos("sp_Imprimir_Prod_Produccion", Id, EmpresaActual)
        rpt.XrSubreport1.ReportSource = rpt_Dev
        rpt._Etiqueta = Etiqueta

        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        HideSplash()
        rpt.ShowRibbonPreview()
    End Sub

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Anular(ByVal Prod_Produccion As Prod_Produccion, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        Prod_Produccion.Empresa = EmpresaActual

        ObjParameter(0) = Prod_Produccion.IdSysProduccion
        ObjParameter(1) = Prod_Produccion.Empresa
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Prod_Produccion", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As Prod_Produccion
        Dim dt As DataTable = ObtieneDatos("sp_sel_Prod_Produccion", Id, EmpresaActual)
        Dim det As New Prod_Produccion

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdSysProduccion = .Item("IdSysProduccion")
                det.Empresa = .Item("Empresa")
                det.IdSysEstadoPRoduccion = .Item("IdSysEstadoPRoduccion")
                det.FechaProduccion = .Item("FechaProduccion")
                'det.FechaGeneraProduccion = .item("FechaGeneraProduccion")
                'det.FechaFinalizaProduccion = .item("FechaFinalizaProduccion")
                'det.FechaAutorizaProduccion = .item("FechaAutorizaProduccion")
                det.NumeroProduccion = .Item("NumeroProduccion")
                det.IdSysFormula = .Item("IdSysFormula")
                det.CantidadProducir = .Item("CantidadProducir")
                det.CantidadRealProducida = IsNull(.Item("CantidadRealProducida"), 0.0)
                det.CostoProduccion = IsNull(.Item("CostoProduccion"), 0)
                det.Observaciones = IsNull(.Item("Observaciones"), "")
                'det.Observaciones2 = .item("Observaciones2")
                'det.Observaciones3 = .item("Observaciones3")
                det.NoDocumento = IsNull(.Item("NoDocumento"), "")
                det.Bodega = IsNull(.Item("Bodega"), "")
                'det.Desperdicio = .item("Desperdicio")
                'det.Usuario = .item("Usuario")
                'det.Registro = .item("Registro")
            End With
        End If
        Return det
    End Function
End Class
