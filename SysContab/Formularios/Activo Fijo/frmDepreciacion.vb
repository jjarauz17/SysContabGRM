Imports System.IO
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class frmDepreciacion

    Private Shared ChildInstance As frmDepreciacion = Nothing

    Public Shared Function Instance() As frmDepreciacion
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmDepreciacion
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Private Sub frmDepreciacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cargar()
    End Sub

    Private Sub cargar()
        Dim fecha As Date
        Dim Emp As New VB.SysContab.EmpresasDetails
        fecha = Now.Date
        Emp = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        Dim Mes As String
        Mes = VB.SysContab.Activo_FijosDB.GetListUMCD()
        Dim ProximoMes As Date = DateAdd(DateInterval.Month, 1, New Date(Microsoft.VisualBasic.Left(Mes, 4), Microsoft.VisualBasic.Right(Mes, 2), 1))
        Me.dgDatos.DataSource = VB.SysContab.Activo_FijosDB.Calc_Depreciacion_pendiente(fecha, ProximoMes.Date.Year.ToString & ProximoMes.Date.Month.ToString.PadLeft(2, "0"))
        'Me.vLista.BestFitColumns()
        Me.vLista.Columns("Valor").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vLista.Columns("Valor").DisplayFormat.FormatString = "n2"

        Me.vLista.Columns("Valor").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vLista.Columns("Valor").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vLista.Columns("Descripcion").Width = 200

        Me.txtMes.Text = ProximoMes
    End Sub

    Private Sub cmdDepreciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDepreciar.Click
        Dim Activos As New VB.SysContab.Activo_FijosDB
        Dim Fecha As Date, Actualizado As Integer

        Dim Emp As New VB.SysContab.EmpresasDetails
        Dim Empresas As New VB.SysContab.EmpresasDB
        Fecha = Now.Date
        Emp = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        Dim Mes As String
        Mes = VB.SysContab.Activo_FijosDB.GetListUMCD()


        Dim ProximoMes As Date = DateAdd(DateInterval.Month, 1, New Date(Microsoft.VisualBasic.Left(Mes, 4), Microsoft.VisualBasic.Right(Mes, 2), 1))

        If Not XtraMsg2("Esta seguro de calcular la depreciacion para el mes " & ProximoMes) Then
            Exit Sub
        End If

        Actualizado = VB.SysContab.Activo_FijosDB.Calc_Depreciacion(Fecha, ProximoMes.Date.Year.ToString & ProximoMes.Date.Month.ToString.PadLeft(2, "0"))

        cargar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        ''Dim fReportes As New frmReportes
        ''Dim Reporte As New rptActivosDepreciacion
        'Dim ds As New DataSet
        'Dim Mes As String
        'Mes = VB.SysContab.Activo_FijosDB.GetListUMCD()
        'Dim ProximoMes As Date = DateAdd(DateInterval.Month, 1, New Date(Microsoft.VisualBasic.Left(Mes, 4), Microsoft.VisualBasic.Right(Mes, 2), 1))
        'Dim Emp As New VB.SysContab.EmpresasDetails
        'Dim Empresas As New VB.SysContab.EmpresasDB
        'Emp = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        'ds = VB.SysContab.Activo_FijosDB.Depreciacion_Imprimir(ProximoMes.Date.Year.ToString & ProximoMes.Date.Month.ToString.PadLeft(2, "0"), Emp.MONEDABASE)
        'ds.WriteXml(Application.StartupPath & "\xml\RptDepreciacion.xml", XmlWriteMode.WriteSchema)
        ''Reporte.Database.Tables("_Activo_Fijo_Reporte_Depreciacion").Location = Application.StartupPath & "\xml\RptDepreciacion.xml"
        ''Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"

        ''fReportes.crvReportes.ReportSource = Reporte
        ''fReportes.ShowDialog()

        vLista.Columns("Mes").Visible = False
        vLista.Columns("Fecha").Visible = False

        ReportFooter()
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.Landscape = False
        PrintableComponentLink1.ShowPreview()

        'vLista.Columns("Mes").Visible = True : vLista.Columns("Fecha").Visible = True
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Me.vLista.DataRowCount <> 0 Then
            XtraMsg("No se puede cerrar un mes si aun quedan pendientes activos por depreciar")
            Exit Sub
        End If

        Dim Mes As String
        Mes = VB.SysContab.Activo_FijosDB.GetListUMCD()

        Dim ProximoMes As Date = DateAdd(DateInterval.Month, 1, New Date(Microsoft.VisualBasic.Left(Mes, 4), Microsoft.VisualBasic.Right(Mes, 2), 1))
        Try
            CierresDB.Cierre_Guardar(ProximoMes.Date.Year & ProximoMes.Date.Month.ToString.PadLeft(2, "0"), Today.Date)

            If XtraMsg2("Desea contabilizar el mes de " & ProximoMes.Month.ToString & "?") Then
                cargar()
            Else
                Exit Sub
            End If

        Catch ex As Exception
            XtraMsg(ex.ToString, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim DT As New DataTable
        DT = ObtieneDatos("SELECT Nombre, empr_logo FROM Empresas WHERE Codigo = " & EmpresaActual)
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 13, FontStyle.Bold)
        If File.Exists(Application.StartupPath & "\" & DT.Rows(0).Item(1)) Then
            Dim rec3 As RectangleF = New RectangleF(0, 0, 184, 116)
            Dim im As System.Drawing.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\" & DT.Rows(0).Item(1))
            e.Graph.DrawImage(im, rec3, BorderSide.None, Color.Transparent)

        End If
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        Dim rec2 As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 50)
        Dim rec4 As RectangleF = New RectangleF(0, 40, e.Graph.ClientPageSize.Width, 60)

        e.Graph.DrawString(DT.Rows(0).Item(0), Color.Black, rec, BorderSide.None)
        e.Graph.DrawString("Reporte Cálculo de Depreciación", Color.Black, rec2, BorderSide.None)
        e.Graph.DrawString("Mes de calculo: " & Format(CDate(txtMes.Text), "MMMM"), Color.Black, rec4, BorderSide.None)
    End Sub

    Private Sub PrintableComponentLink1_CreateReportFooterArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportFooterArea
        Dim s As String = "Autorizado por"
        Dim s2 As String = "Realizado por"
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Arial", 10)
        e.Graph.BackColor = Color.Transparent

        Dim sz As SizeF = e.Graph.MeasureString(s)
        sz.Width += 80
        Dim r As RectangleF = New RectangleF(New PointF(50, 80), sz)
        Dim t As RectangleF = New RectangleF(New PointF(700, 80), sz)
        Dim t2 As RectangleF = New RectangleF(New PointF(700, 95), sz)
        e.Graph.DrawString(s, Color.Black, r, BorderSide.Top)
        e.Graph.DrawString(s2, Color.Black, t, BorderSide.Top)
        e.Graph.DrawString(Usuario, Color.Black, t2, BorderSide.None)

    End Sub

    Private Sub ReportFooter()
        Dim leftColumn As String = "Fecha y Hora : [Date Printed] - [Time Printed]"
        Dim middleColumn As String = "Usuario: " & Usuario
        Dim rightColumn As String = "Páginas: [Page # of Pages #]"

        ' Create a PageHeaderFooter object and initializing it with
        ' the link's PageHeaderFooter.
        Dim phf As PageHeaderFooter = _
            TryCast(PrintableComponentLink1.PageHeaderFooter, PageHeaderFooter)

        ' Clear the PageHeaderFooter's contents.
        phf.Footer.Content.Clear()

        ' Add custom information to the link's header.
        phf.Footer.Content.AddRange(New String() _
            {leftColumn, middleColumn, rightColumn})
        phf.Footer.LineAlignment = BrickAlignment.Center
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'frmexportaciongrid.Mostrar(dgDatos)
        frmExportarImprimir.Mostrar(dgDatos, Me.Text)
    End Sub
End Class