Imports System.IO
Imports DevExpress.XtraReports.UI
Public Class frmSituacionFinanciera

    Public IdCliente As Integer
    Private Sub frmSituacionFinanciera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetMonedasList(cbMoneda)
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Fecha.DateTime = f.Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f).Date

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If RadioGroup1.EditValue = 1 Then
            ShowSplash("Imprimiendo...")
            ''
            Dim r As New rptEstadoCuentaEnviar

            r.Periodo.Text = "Al Corte: " & Fecha.DateTime.Date
            r.DataSource = ObtieneDatos("SP_EstadoCuentaReporteEnviar", IdCliente, _
                                                                        Fecha.DateTime.Date, _
                                                                        Fecha.DateTime.Date, _
                                                                        EmpresaActual)
            HideSplash()

            r.ShowPrintMarginsWarning = False
            r.BringToFront()
            r.ShowRibbonPreview()

        ElseIf RadioGroup1.EditValue = 3 Then
            Dim Mes As Integer = 0
            Dim Fecha As String = ""

            Dim Clientes As New VB.SysContab.ClientesDB
            ShowSplash("Imprimiendo...")
            ''
            Dim rpt As New RptEstadoCuentaCliente
            rpt.DataSource = Clientes.EstadoCuentaReporteNew(IdCliente, Mes,
                                0, Fecha, Desde.DateTime.Date,
                                Hasta.DateTime.Date, "%", "%", 1).Tables(0)

            HideSplash()

            rpt.ShowPrintMarginsWarning = False
            rpt.BringToFront()
            rpt.ShowRibbonPreview()

        ElseIf RadioGroup1.EditValue = 2 Then

            Dim Cadena As String
            Dim Temp As Boolean = False
            Dim Data() As Byte

            ShowSplash("Imprimiendo Antiguedad...")

            Try
                Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 22 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
                Temp = True
                Dim Tamano As Integer
                Tamano = Data.GetUpperBound(0)
                Cadena = Application.StartupPath & "\rptAntiguedad.repx"
                If File.Exists(Cadena) Then Kill(Cadena)
                Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
                Archivo.Write(Data, 0, Tamano)
                Archivo.Close()
            Catch ex As Exception
                Temp = False
            End Try

            Dim rpt As RptAnalisisAntiguedad

            If Temp = True Then
                rpt = XtraReport.FromFile(Application.StartupPath & "\rptAntiguedad.repx", True)
            Else
                rpt = New RptAnalisisAntiguedad
            End If

            rpt.Detalle = CheckEdit1.Checked

            Dim dtRpt As DataTable = ObtieneDatos("SPRptAnalisisAntiguedad", EmpresaActual, IdCliente, 0, _
                                              Fecha.DateTime.Date, cbMoneda.EditValue, _
                                              "%", _
                                              0, 0, _
                                              IIf(CheckEdit1.Checked, 1, 0))

            rpt.XrPictureBox1.Image = frmPrincipalRibbon.pLogo.Image
            rpt.DataSource = dtRpt

            HideSplash()

            rpt.ShowPrintMarginsWarning = False
            rpt.BringToFront()
            rpt.ShowRibbonPreview()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If RadioGroup1.EditValue = 1 Or RadioGroup1.EditValue = 2 Then
            Fecha.Enabled = True
            Desde.Enabled = False
            Hasta.Enabled = False
        Else
            Fecha.Enabled = False
            Desde.Enabled = True
            Hasta.Enabled = True
        End If
    End Sub
End Class