Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class rptLibroAuxiliar2

    Public Nivel As Integer = 1

    Private Sub ghsc01_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles ghsc01.BeforePrint
        'Dim Fila As DataRowView = GetCurrentRow()
        'If Fila.Item("sc02") = " " Then
        '    Me.ghSC02.Visible = False
        'Else
        '    Me.ghSC02.Visible = True
        'End If
    End Sub

    Private Sub ghMayor_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles ghMayor.BeforePrint


        'Dim DT As DataTable = Me.get

        '  Dim Fila As DataRowView = GetCurrentRow()

        'XtraMsg(Fila.Item("SaldoAnterior").ToString)
        'XtraMsg(Fila.Item("debe").ToString)
        'XtraMsg(Fila.Item("haber").ToString)        



        'Dim Fila As DataRowView = GetCurrentRow()
        'If Fila.Item("sc01") = " " Then
        '    Me.ghsc01.Visible = False
        'Else
        '    Me.ghsc01.Visible = True
        'End If
    End Sub

    Private Sub rptLibroAuxiliar_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        'Validar los Niveles que seran visibles
        If Nivel = 1 Then           'Solo Las Mayores
            ghsc01.Visible = False
            ghSC02.Visible = False
            ghSC03.Visible = False
            ghCuenta.Visible = False
            Detalle.Visible = False
        ElseIf Nivel = 2 Then       'Primer Nivel
            ghsc01.Visible = True
            ghSC02.Visible = False
            ghSC03.Visible = False
            ghCuenta.Visible = False
            Detalle.Visible = False
        ElseIf Nivel = 3 Then       'Segundo Nivel
            ghsc01.Visible = True
            ghSC02.Visible = True
            ghSC03.Visible = False
            ghCuenta.Visible = False
            Detalle.Visible = False
        ElseIf Nivel = 4 Then       'Tercer Nivel
            ghsc01.Visible = True
            ghSC02.Visible = True
            ghSC03.Visible = True
            ghCuenta.Visible = False
            Detalle.Visible = False
        ElseIf Nivel = 5 Then       'Cuarto Nivel
            ghsc01.Visible = True
            ghSC02.Visible = True
            ghSC03.Visible = True
            ghCuenta.Visible = True
            Detalle.Visible = True
        Else                        'Todos los Niveles
            ghsc01.Visible = True
            ghSC02.Visible = True
            ghSC03.Visible = True
            ghCuenta.Visible = True
            Detalle.Visible = True
        End If
    End Sub

    Private Sub Comprobante_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Comprobante.BeforePrint, XrLabel42.BeforePrint
        CType(sender, XRLabel).Tag = GetCurrentRow()
    End Sub

    Private Sub Comprobante_PreviewMouseMove(sender As Object, e As DevExpress.XtraReports.UI.PreviewMouseEventArgs) Handles Comprobante.PreviewMouseMove, XrLabel42.PreviewMouseMove
        e.PreviewControl.Cursor = Cursors.Hand
    End Sub

    Private Sub Comprobante_PreviewClick(sender As Object, e As DevExpress.XtraReports.UI.PreviewMouseEventArgs) Handles Comprobante.PreviewClick, XrLabel42.PreviewClick

        'Dim Cadena As String
        'Dim Temp As Boolean = False
        'Dim Data() As Byte

        If (CType(e.Brick.Value, DataRowView)).Row("CompID").ToString() = "" Then Exit Sub

        ShowSplash("Imprimiendo Comprobante...")

        'Try
        '    Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 17 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())

        '    Temp = True
        '    Dim Tamano As Integer
        '    Tamano = Data.GetUpperBound(0)
        '    Cadena = Application.StartupPath & "\rptComprobante.repx"

        '    If File.Exists(Cadena) Then Kill(Cadena)
        '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        '    Archivo.Write(Data, 0, Tamano)
        '    Archivo.Close()
        'Catch ex As Exception
        '    Temp = False
        'End Try

        Dim Temp As Boolean = db_Formatos.FormatoImpreso(17, "rptComprobante")

        Dim DTDistrubucion As DataTable = ObtieneDatos("JAR_GetComprobanteDistribucion", (CType(e.Brick.Value, DataRowView)).Row("CompID").ToString(),
                                                      CInt(Fix((CType(e.Brick.Value, DataRowView)).Row("Periodo"))),
                                                      CDate((CType(e.Brick.Value, DataRowView)).Row("Fecha").ToString()).Month,
                                                      EmpresaActual)

        Dim rptDistribucin As New rptComprobanteDistribucion
        rptDistribucin.DataSource = DTDistrubucion

        Dim rpt As rptComprobantesALL

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptComprobante.repx", True)
        Else
            rpt = New rptComprobantesALL
        End If

        rpt.ver = True
        rpt.XrSubreport1.ReportSource = rptDistribucin
        rpt.gfDistribucion.Visible = IIf(DTDistrubucion.Rows.Count > 0, True, False)
        rpt.XrPictureBox1.Image = pLogo.Image

        Dim DT As DataTable = ObtieneDatos("_ComprobantesImpresoALL", (CType(e.Brick.Value, DataRowView)).Row("CompID").ToString(),
                                      EmpresaActual,
                                      CInt(Fix((CType(e.Brick.Value, DataRowView)).Row("Periodo"))),
                                      CDate((CType(e.Brick.Value, DataRowView)).Row("Fecha").ToString()))

        VistaPreviaDX(rpt, DT, "Comprobante No. " & (CType(e.Brick.Value, DataRowView)).Row("CompID").ToString())

        '
        'With frmManejadorReporte3
        '    .DocumentViewer1.PrintingSystem = rpt.PrintingSystem
        '    rpt.DataSource = DT
        '    rpt.ShowPrintMarginsWarning = False
        '    rpt.CreateDocument()
        '    If frmMDIReporte.Created Then .MdiParent = frmMDIReporte
        '    .Show()
        '    .Text = "Comprobante No. " & (CType(e.Brick.Value, DataRowView)).Row("CompID").ToString()
        '    .WindowState = FormWindowState.Maximized
        'End With
        '
        HideSplash()

        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()
    End Sub



    Private Sub rptLibroAuxiliar2_DataSourceRowChanged(sender As Object, e As DataSourceRowEventArgs) Handles Me.DataSourceRowChanged
        'Dim Fila As DataRowView = GetCurrentRow()

        'If Fila.Item("SaldoAnterior") = 0.00 Then
        '    Fila.Item("SaldoAnterior") = DBNull.Value
        'End If
        ''
        'If Fila.Item("debe") = 0.00 Then
        '    Fila.Item("debe") = DBNull.Value
        'End If
        ''
        'If Fila.Item("haber") = 0.00 Then
        '    Fila.Item("haber") = DBNull.Value
        'End If
    End Sub
End Class