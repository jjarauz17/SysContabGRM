Imports DevExpress.XtraPrinting
Imports System.Drawing
Imports System.Data
Imports System.Data.SqlClient

Public Class frmDetalleMovimientosCxP

    Private Sub frmObligacionesxPagar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = f.Date
        '
        Cargar()
        CargarPrimero()
    End Sub
    Sub CargarPrimero()
        Dim dt As DataTable = ObtieneDatos("JAR_GetMovimientosDetalleCxP", Desde.DateTime.Date.AddMonths(2).Date, _
                                                                            Hasta.DateTime.Date, _
                                                                            IIf(cbRubro.ItemIndex = 0, "%", cbRubro.EditValue), _
                                                                            EmpresaActual)
        dgDatos.DataSource = dt.DefaultView
        vDatos.PopulateColumns()
        FormatoGrid(vDatos)

        vDatos.Columns("CONCEPTO").Visible = False
        vDatos.Columns("CODIGO").Visible = False
    End Sub

    Sub Cargar()
        cbRubro.Properties.DataSource = ObtieneDatos("sp_GetTiposProveedores", EmpresaActual)
        cbRubro.Properties.ValueMember = "CUENTA"
        cbRubro.Properties.DisplayMember = "Display"
        cbRubro.Properties.PopulateColumns()
        cbRubro.Properties.Columns(2).Visible = False
        cbRubro.ItemIndex = 0
    End Sub

    Private Sub Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exportar.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ShowSplash("Generando Reporte...")

        Dim dt As DataTable = ObtieneDatos("JAR_GetMovimientosDetalleCxP", Desde.DateTime.Date, _
                                                                            Hasta.DateTime.Date, _
                                                                            IIf(cbRubro.ItemIndex = 0, "%", cbRubro.EditValue), _
                                                                            EmpresaActual)
        dgDatos.DataSource = dt.DefaultView

        ' vDatos.PopulateColumns()
        'FormatoGrid(vDatos)
        '
        'Me.vDatos.Columns("FECHA").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        'Me.vDatos.Columns("FECHA").DisplayFormat.FormatString = "{0:dd/MM/yy}"
        ''
        'Me.vDatos.Columns("DEBITO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.vDatos.Columns("DEBITO").DisplayFormat.FormatString = "{0:n2}"
        'Me.vDatos.Columns("DEBITO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.vDatos.Columns("DEBITO").SummaryItem.DisplayFormat = "{0:n2}"
        ''
        'Me.vDatos.Columns("CREDITO").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.vDatos.Columns("CREDITO").DisplayFormat.FormatString = "{0:n2}"
        'Me.vDatos.Columns("CREDITO").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.vDatos.Columns("CREDITO").SummaryItem.DisplayFormat = "{0:n2}"
        '
        Me.vDatos.Columns("PROVEEDOR").Group()
        Me.vDatos.ExpandAllGroups()

        ' Me.vDatos.BestFitColumns()

        HideSplash()
    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        Try
            Dim Ps As New PrintingSystem
            Dim Cl As New PrintableComponentLink
            Ps.Links.AddRange(New Object() {Cl})
            Cl.Component = dgDatos

            Dim leftColumn As String = "Fecha y Hora : [Date Printed] - [Time Printed]"
            Dim rightColumn As String = "Paginas: [Page # of Pages #]"

            ' Create a PageHeaderFooter object and initializing it with
            ' the link's PageHeaderFooter.
            Dim phf As PageHeaderFooter = _
                TryCast(Cl.PageHeaderFooter, PageHeaderFooter)

            ' Clear the PageHeaderFooter's contents.
            phf.Footer.Content.Clear()
            phf.Header.Content.Clear()

            phf.Header.Font = New System.Drawing.Font("Tahoma", 9, FontStyle.Bold)

            phf.Header.Content.AddRange(New String() _
                {"", NombreEmpresaActual + vbCrLf + "DETALLE DE MOVIMIENTOS DEL PERIODO " & Desde.DateTime.Date.ToShortDateString & " AL " & Hasta.DateTime.Date.ToShortDateString & vbCrLf & _
                    cbRubro.Text, ""})

            phf.Footer.LineAlignment = BrickAlignment.Center
            ' Add custom information to the link's header.
            phf.Footer.Content.AddRange(New String() _
                {leftColumn, "", rightColumn})
            phf.Footer.LineAlignment = BrickAlignment.Center

            Cl.CreateDocument()
            Cl.Margins.Left = 20
            Cl.Margins.Right = 20
            Cl.Margins.Bottom = 40

            Cl.Landscape = True
            Cl.ShowPreview()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then vDatos.ShowCustomization()
        If Not CheckEdit1.Checked Then vDatos.DestroyCustomization()
    End Sub

    Private Sub vDatos_HideCustomizationForm(sender As Object, e As EventArgs) Handles vDatos.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub
End Class