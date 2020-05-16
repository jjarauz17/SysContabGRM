
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Public Class db_Amortizaciones
    Inherits ClComun
    Dim vAmortizacionesTabla As New Amortizaciones
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property AmortizacionesTabla() As Amortizaciones
        Get
            Return vAmortizacionesTabla
        End Get
        Set(ByVal value As Amortizaciones)
            vAmortizacionesTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Amortizaciones As Amortizaciones, Optional Tran As Boolean = False)
        Dim ObjParameter(9) As String
        ObjParameter(0) = Amortizaciones.Cod_amortizacion
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = Amortizaciones.Fecha_Inicial
        ObjParameter(3) = Amortizaciones.Fecha_Limite
        ObjParameter(4) = Amortizaciones.Plazo
        ObjParameter(5) = Amortizaciones.Nombre
        ObjParameter(6) = Amortizaciones.Moneda
        ObjParameter(7) = Amortizaciones.Monto_total
        ObjParameter(8) = Amortizaciones.Monto_amortizado
        'ObjParameter(9) = Amortizaciones.estado

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Amortizaciones", ObjParameter)
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
    Public Sub Actualizar(ByVal Amortizaciones As Amortizaciones, Optional Tran As Boolean = False)
        Dim ObjParameter(9) As String
        ObjParameter(0) = Amortizaciones.Cod_amortizacion
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = Amortizaciones.Fecha_Inicial
        ObjParameter(3) = Amortizaciones.Fecha_Limite
        ObjParameter(4) = Amortizaciones.Plazo
        ObjParameter(5) = Amortizaciones.Nombre
        ObjParameter(6) = Amortizaciones.Moneda
        ObjParameter(7) = Amortizaciones.Monto_total
        ObjParameter(8) = Amortizaciones.Monto_amortizado
        ' ObjParameter(9) = Amortizaciones.estado

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Amortizaciones", ObjParameter)
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
    Public Shared Function Listar(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_Amortizaciones", Id, EmpresaA)

    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Tabla(ByVal Codigo As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_AmortizacionesTabla", Codigo, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function BuscarAmoritzacion(ByVal Codigo As Integer) As DataTable

        Return ObtieneDatos("sp_sel_AmortizacionesBuscar", Codigo, EmpresaA)

        'If DT.Rows.Count = 0 Then
        '    Return "SI"
        'Else
        '    Return "NO"
        'End If

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function GetCodigo() As Integer

        Return ObtieneDatos("sp_sel_AmortizacionesGetCodigo", EmpresaA).Rows.Item(0)("Codigo")

    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Plantilla(ByVal Codigo As Integer) As Data.DataTable

        Return ObtieneDatos("sp_GetPlantilla_Amortizaciones", Codigo, EmpresaA)

    End Function

    'Public Shared Sub Imprimir(ByVal Codigo As Integer, rpt As DevExpress.XtraReports.UI.XtraReport)


    '    Dim DT As DataTable = ObtieneDatos("JAR_GetAmortizacionImpresa", Codigo, EmpresaA)

    '    If DT.Rows.Count = 0 Then
    '        XtraMsg("La Amortización no contiene tabla Generada!", MessageBoxIcon.Warning)
    '        Exit Sub
    '    End If



    '    '' rpt.DataSource = DT
    '    'rpt.ShowPrintMarginsWarning = False
    '    'rpt.BringToFront()
    '    'rpt.ShowRibbonPreview()
    'End Sub

    'Public Shared Sub ImprimirResumen(rpt As DevExpress.XtraReports.UI.XtraReport)
    '    Dim DT As DataTable = ObtieneDatos("sp_GetAmortizacionImpresaResumen", EmpresaA)
    '    '
    '    rpt.DataSource = DT
    '    rpt.ShowPrintMarginsWarning = False
    '    rpt.BringToFront()
    '    rpt.ShowRibbonPreview()
    'End Sub



    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Estado(ByVal Codigo As Integer) As String

        Dim DT As DataTable = ObtieneDatos("sp_sel_AmoritzacionEstado", Codigo, EmpresaA)
        '
        With DT.Rows
            If .Count = 0 Then
                Return "NUEVA"
            ElseIf .Count = 1 Then
                If .Item(0)(0) = True Then   'Finalizada
                    Return "FINALIZADA"
                Else
                    Return "CREADA"
                End If
            Else
                Return "PROCESO"
            End If
        End With

        '    If dt.Rows.Count = 0 Then
        '        Return "NUEVA"  'Crar Nueva
        '    ElseIf dt.Rows.Count = 1 Then
        '        If dt.Rows.Item(0)(0) = False Then  'Mostrar Para Modificar
        '            Return "CREADA"
        '        Else
        '            Return "NUEVA"  'Ya se Contabilizó Todo, Volver a Utilizar
        '        End If
        '    ElseIf dt.Rows.Count = 2 Then   'En Proceso No se Puede Modificar
        '        Return "PROCESO"
        '    End If

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function MesesPendientes(ByVal Codigo As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_AmortizacionesMesesPendientes", Codigo, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal Amortizaciones As Amortizaciones, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = Amortizaciones.Cod_amortizacion
        Try

            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Amortizaciones", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As Amortizaciones
        Dim dt As DataTable = ObtieneDatos("sp_sel_Amortizaciones", Id, EmpresaA)
        Dim det As New Amortizaciones

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.Cod_amortizacion = .Item("Cod_amortizacion")
                ' det.Empresa = .Item("Empresa")
                det.Fecha_Inicial = .Item("Fecha_Inicial")
                det.Fecha_Limite = .Item("Fecha_Limite")
                det.Plazo = .Item("Plazo")
                det.Nombre = .Item("Nombre")
                det.Moneda = .Item("Moneda")
                det.Monto_total = .Item("Monto_total")
                det.Monto_amortizado = .Item("Monto_amortizado")
                det.TipoCompr = .Item("TipoCompr")
                'det.estado = .Item("estado")
            End With
        End If
        Return det
    End Function
End Class
