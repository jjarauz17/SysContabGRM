Imports System.Data
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab
Imports DevExpress.XtraReports.UI

Public Class AmortizacionesDB

    Public Shared Function CREAR_VISTA_PREVIA(ByVal Id_Nombre As Integer) As DataSet

        Dim DS As New DataSet
        Dim Codigo As Integer = 0

        Dim sql_datos As String = "SELECT (SELECT e.NOMBRE FROM EMPRESAS e WHERE e.CODIGO = a.Empresa) Empresa,A.Cod_amortizacion,a.Fecha_Inicial F_inicio," _
        + " a.Fecha_Limite F_limite,M.mon_simbolo + ' ' + M.mon_descripcion Moneda,ca.Nombre," _
        + " a.Plazo,a.Monto_amortizado Valor FROM Amortizaciones a INNER JOIN CatalogoAmortizacion ca ON a.Nombre = ca.Codigo AND a.Empresa =ca.Empresa" _
        + " INNER JOIN Monedas m ON a.Moneda COLLATE SQL_Latin1_General_CP1_CI_AS = m.mon_codigo AND a.Empresa = m.empr_codigo" _
        + " WHERE (a.estado = 1) AND (ca.Codigo = " & Id_Nombre & ") AND a.Empresa = " & EmpresaActual

        Dim da1 As New SqlDataAdapter(sql_datos, Rutinas.AbrirConexion)
        da1.Fill(DS, "DATOS")

        If DS.Tables("DATOS").Rows.Count <> 0 Then
            Codigo = DS.Tables(0).Rows(0).Item("Cod_amortizacion")
        End If

        Dim sql_calculos As String = "SELECT AD.Fecha,AD.Monto_Amortizado AS M_amortizado, AD.Monto_Inicial AS M_inicial," _
        + " AD.num_amortizacion AS NO, CASE Contabilizar WHEN 1 THEN 'SI' ELSE 'NO' END Contab FROM Amortizaciones A INNER JOIN AmortizacionesDetalle AD" _
        + " ON A.Cod_amortizacion = AD.Cod_amortizacion AND A.Empresa = AD.Empresa" _
        + " WHERE (A.Cod_amortizacion = " & Codigo & ") AND A.Empresa = " & EmpresaActual

        Dim da2 As New SqlDataAdapter(sql_calculos, Rutinas.AbrirConexion)
        da2.Fill(DS, "DETALLE")

        If DS.Tables("DETALLE").Rows.Count > 0 Then
            CREAR_DS(DS)    'Crear DataSet para el Reporte
        End If

        Return DS
    End Function


    Public Shared Sub CREAR_DS(ByVal DS_DATOS As DataSet)
        Dim DS As New DataSet
        Dim dr As DataRow
        Dim dt1 As New DataTable("CALCULOS")
        Dim DT2 As New DataTable("DATOS")

        'Campos de la Tabla 1
        dt1.Columns.Add("NO", Type.GetType("System.Int32"))
        dt1.Columns.Add("Fecha", Type.GetType("System.String"))
        dt1.Columns.Add("M_inicial", Type.GetType("System.Decimal"))
        dt1.Columns.Add("M_amortizado", Type.GetType("System.Decimal"))
        dt1.Columns.Add("Contabilizado", Type.GetType("System.String"))

        'Campos de la Tabla 2
        DT2.Columns.Add("F_inicio", Type.GetType("System.String"))
        DT2.Columns.Add("F_limite", Type.GetType("System.String"))
        DT2.Columns.Add("Plazo", Type.GetType("System.Int32"))
        DT2.Columns.Add("Valor", Type.GetType("System.Decimal"))
        DT2.Columns.Add("Nombre", Type.GetType("System.String"))
        DT2.Columns.Add("Moneda", Type.GetType("System.String"))
        DT2.Columns.Add("Empresa", Type.GetType("System.String"))

        'Obtener Datos de la Tabla 1
        For i As Integer = 0 To DS_DATOS.Tables("DETALLE").Rows.Count - 1
            dr = dt1.NewRow

            dr(0) = DS_DATOS.Tables("DETALLE").Rows(i).Item("NO")
            dr(1) = CDate(DS_DATOS.Tables("DETALLE").Rows(i).Item("Fecha")).ToShortDateString
            dr(2) = DS_DATOS.Tables("DETALLE").Rows(i).Item("M_inicial")
            dr(3) = DS_DATOS.Tables("DETALLE").Rows(i).Item("M_amortizado")
            dr(4) = DS_DATOS.Tables("DETALLE").Rows(i).Item("Contab")

            dt1.Rows.Add(dr)
        Next
        'Obtener Datos de la Tabla 2
        dr = DT2.NewRow

        dr(0) = CDate(DS_DATOS.Tables("DATOS").Rows(0).Item("F_inicio")).ToShortDateString
        dr(1) = CDate(DS_DATOS.Tables("DATOS").Rows(0).Item("F_limite")).ToShortDateString
        dr(2) = DS_DATOS.Tables("DATOS").Rows(0).Item("Plazo")
        dr(3) = DS_DATOS.Tables("DATOS").Rows(0).Item("Valor")
        dr(4) = DS_DATOS.Tables("DATOS").Rows(0).Item("Nombre")
        dr(5) = DS_DATOS.Tables("DATOS").Rows(0).Item("Moneda")
        dr(6) = DS_DATOS.Tables("DATOS").Rows(0).Item("Empresa")


        DT2.Rows.Add(dr)

        DS.Tables.Add(dt1)
        DS.Tables.Add(DT2)

        DS.WriteXml(Application.StartupPath & "\XML\rptAmortizacion.xml", XmlWriteMode.WriteSchema)
    End Sub

    Public Shared Function ImprimirAmortizacion(ByVal Codigo As Integer)
        Dim rpt As New rptDetalle_Amortizacion
        rpt.DataSource = ObtieneDatos("JAR_GetAmortizacionImpresa " & Codigo & "," & EmpresaActual)
        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        rpt.ShowRibbonPreview()
    End Function

    Public Shared Sub IMPRIMIR(ByVal FORMATO As String, ByVal Op As Integer)
        Dim rpt As DevExpress.XtraReports.UI.XtraReport = Nothing

        If Op = 1 Then
            rpt = New rptDetalle_Amortizacion
            rpt.XmlDataPath = Application.StartupPath & "\XML\rptAmortizacion.xml"
        ElseIf Op = 2 Then
            rpt = New rptAmortiza_General
            rpt.XmlDataPath = Application.StartupPath & "\XML\rptAmortiza_General.xml"
        End If

        Select Case FORMATO
            Case "Vista"
                rpt.ShowPrintMarginsWarning = False
                rpt.BringToFront()
                rpt.ShowRibbonPreview()
            Case "*.xls"
                rpt.ExportToXls(Application.StartupPath & "\export\Amortizacion.xls")
                Process.Start(Application.StartupPath & "\export\Amortizacion.xls")
            Case "*.pdf"
                rpt.ExportToPdf(Application.StartupPath & "\export\Amortizacion.pdf")
                Process.Start(Application.StartupPath & "\export\Amortizacion.pdf")
            Case "*.html"
                rpt.ExportToHtml(Application.StartupPath & "\export\Amortizacion.html")
                Process.Start(Application.StartupPath & "\export\Amortizacion.html")
            Case "*.rtf"
                rpt.ExportToRtf(Application.StartupPath & "\export\Amortizacion.rtf")
                Process.Start(Application.StartupPath & "\export\Amortizacion.rtf")
            Case "*.txt"
                rpt.ExportToText(Application.StartupPath & "\export\Amortizacion.txt")
                Process.Start(Application.StartupPath & "\export\Amortizacion.txt")
        End Select
    End Sub

    Public Shared Function CREAR_XML() As Boolean

        Dim sSQL As String = "SELECT (SELECT e.NOMBRE FROM EMPRESAS e WHERE e.CODIGO = a.Empresa) Empresa," _
        + " 0 as No,Fecha_Inicial,Fecha_Limite,ca.Nombre,Count(ca.Nombre) as Cuotas,a.Plazo," _
        + " Monto_total,(Monto_total - SUM(a.Monto_amortizado)) AS Monto_amortizado,a.Monto_amortizado Amortizar,SUM(a.Monto_amortizado) AS Pendiente" _
        + " FROM catalogoamortizacion ca INNER JOIN amortizaciones a ON ca.Codigo = a.Cod_amortizacion  AND ca.Empresa = a.Empresa" _
        + " INNER JOIN amortizacionesdetalle ad ON a.Cod_amortizacion = ad.Cod_amortizacion  AND a.Empresa = ad.Empresa" _
        + " WHERE(contabilizar = 0 And a.Empresa = " & EmpresaActual & ")" _
        + " Group By a.Empresa,Fecha_Inicial,Fecha_Limite,ca.Nombre,a.Monto_amortizado,Monto_total,a.Plazo ORDER BY convert(datetime,Fecha_Inicial,103)"

        Dim DS As New DataSet
        DS.Tables.Add(ObtieneDatos(sSQL))

        If DS.Tables(0).Rows.Count > 0 Then 'Si hay datos
            For i As Integer = 0 To DS.Tables(0).Rows.Count - 1
                DS.Tables(0).Rows.Item(i)("No") = i + 1
            Next
            DS.WriteXml(Application.StartupPath & "\XML\rptAmortiza_General.xml", XmlWriteMode.WriteSchema)
            Return True
        End If

        Return False    'Si no encuentra datos
    End Function

    Public Shared Function GenerarID(ByVal tabla As String) As Integer
        Dim DT As DataTable = ObtieneDatos("Select ISNULL(MAX(Cod_amortizacion),0) From " & tabla & " WHERE Empresa = " & EmpresaActual)
        Return DT.Rows.Item(0)(0) + 1
    End Function

    Public Shared Function GetAmortizacionActual(ByVal ID_nombre As Integer) As DataTable
        Return ObtieneDatos("SELECT * FROM Amortizaciones a INNER JOIN CatalogoAmortizacion ca" _
                     + " ON a.Nombre = ca.Codigo AND a.Empresa = ca.Empresa WHERE a.Nombre = " & ID_nombre & "" _
                     + " AND a.estado = 1 AND a.Empresa = " & EmpresaActual)

        'Return ObtieneDatos("Select * From Amortizaciones Where Nombre = " & ID_nombre & " AND estado = 1 AND Empresa = " & EmpresaActual)
    End Function

    Public Shared Function GetAmorotizacionId() As Integer
        Return ObtieneDatos("SELECT isnull(MAX(ca.Codigo),0) + 1 Id FROM CatalogoAmortizacion ca WHERE ca.Empresa = " & EmpresaActual).Rows.Item(0)("Id")
    End Function

    Public Shared Function CATALOGO_CUENTA(ByVal CUENTA As String, ByVal op As Integer) As String
        Dim dt As DataTable = ObtieneDatos("Select CUENTA,NOMBRE From CATALOGO WHERE CUENTA = '" & CUENTA & "' AND EMPRESA = " & EmpresaActual)

        If dt.Rows.Count > 0 Then
            If op = 1 Then Return dt.Rows(0).Item("CUENTA").ToString
            If op = 2 Then Return dt.Rows(0).Item("NOMBRE").ToString
        End If

        Return ""
    End Function

    Public Shared Sub Imprimir(ByVal Codigo As Integer, rpt As DevExpress.XtraReports.UI.XtraReport)

        ShowSplash("Imprimiendo...")

        Dim DT As DataTable = ObtieneDatos("JAR_GetAmortizacionImpresa", Codigo, EmpresaActual)

        If DT.Rows.Count = 0 Then
            HideSplash()
            XtraMsg("La Amortización no contiene tabla Generada!", MessageBoxIcon.Warning)
            Exit Sub
        End If

        VistaPreviaDX(rpt, DT, "Amortización No. " & Codigo.ToString())
        HideSplash()

        '' rpt.DataSource = DT
        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()
    End Sub

    Public Shared Sub ImprimirResumen(rpt As DevExpress.XtraReports.UI.XtraReport)
        ShowSplash("Imprimiendo...")
        Dim DT As DataTable = ObtieneDatos("sp_GetAmortizacionImpresaResumen", EmpresaActual)
        '
        VistaPreviaDX(rpt, DT, "Reporte de Amortizaciones Pendientes")
        HideSplash()
        'rpt.DataSource = DT
        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        'rpt.ShowRibbonPreview()
    End Sub

End Class
