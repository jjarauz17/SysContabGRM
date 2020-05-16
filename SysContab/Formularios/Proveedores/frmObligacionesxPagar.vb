Imports DevExpress.XtraPrinting
Imports System.Drawing
Imports System.Data
Imports System.Data.SqlClient

Public Class frmObligacionesxPagar

    Private Sub frmObligacionesxPagar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        Desde.DateTime = VB.SysContab.Rutinas.Fecha().Date.AddMonths(-1).Date
        Hasta.DateTime = VB.SysContab.Rutinas.Fecha().Date
    End Sub

    Sub Cargar()
        'Me.cbRubro.Properties.DataSource = ObtieneDatos("sp_GetTiposProveedores " & EmpresaActual)
        'Me.cbRubro.Properties.ValueMember = "CUENTA"
        'Me.cbRubro.Properties.DisplayMember = "Display"
        'Me.cbRubro.Properties.PopulateColumns()
        'Me.cbRubro.Properties.Columns("Display").Visible = False
        'Me.cbRubro.ItemIndex = 0

        GridControl1.DataSource = ObtieneDatos("sp_GetTiposProveedores " & EmpresaActual & ",1")
        GridView1.PopulateColumns()
        FormatoGrid(GridView1, 2, 0, False)
        '
        For i As Integer = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
        Next
        ''
        GridView1.Columns("Seleccionar").OptionsColumn.AllowEdit = True
        GridView1.BestFitColumns()
    End Sub

    Private Sub Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exportar.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim dt As New DataTable

        For i As Integer = 0 To Me.GridView1.DataRowCount - 1
            If GridView1.GetRowCellValue(i, "Seleccionar") Then
                Dim da As New SqlDataAdapter("SET DATEFORMAT dmy; EXEC JAR_GetObligacionesxPagar '" & GridView1.GetRowCellValue(i, "CUENTA") & "','" & Desde.DateTime.Date & "','" & Hasta.DateTime.Date & "', " & EmpresaActual, VB.SysContab.Rutinas.AbrirConexion())
                da.Fill(dt)
            End If
        Next

        If dt.Rows.Count = 0 Then
            dgDatos.DataSource = Nothing
            Exit Sub
        ElseIf dt Is Nothing Then
            dgDatos.DataSource = Nothing
            Exit Sub
        End If

        ''dgDatos.DataSource = ObtieneDatos("SET DATEFORMAT dmy; EXEC JAR_GetObligacionesxPagar '" & cbRubro.EditValue & "','" & Desde.DateTime.Date & "','" & Hasta.DateTime.Date & "', " & EmpresaActual)
        dgDatos.DataSource = dt.DefaultView
        vDatos.PopulateColumns()
        FormatoGrid(vDatos)

        Me.vDatos.Columns("Fecha").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.vDatos.Columns("Fecha").DisplayFormat.FormatString = "{0:dd/MM/yy}"

        Me.vDatos.Columns("Vence").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.vDatos.Columns("Vence").DisplayFormat.FormatString = "{0:dd/MM/yy}"

        Me.vDatos.Columns("Monto C$").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Monto C$").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Monto C$").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Monto C$").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("Monto U$").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Monto U$").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Monto U$").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Monto U$").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("T/C").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("T/C").DisplayFormat.FormatString = "{0:n4}"

        Me.vDatos.BestFitColumns()
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
                {"", NombreEmpresaActual + vbCrLf + "COMPROMISOS DE PAGO PARA EL PERIODO DEL " & Desde.DateTime.Date.ToShortDateString & " AL " & Hasta.DateTime.Date.ToShortDateString, ""})

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
End Class