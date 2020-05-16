Imports DevExpress.XtraPrinting

Public Class frmDetalleMovimientoCliente

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ShowSplash("Generando Reporte...")
        Buscar()
        HideSplash()
    End Sub

    Sub Buscar()
        Dim dt As DataTable = ObtieneDatos("JAR_GetDetalleMovimientoCliente",
                                           Desde.DateTime.Date,
                                           Hasta.DateTime.Date,
                                           cbSucursal.EditValue,
                                           EmpresaActual)

        dgDatos.DataSource = dt.DefaultView
        'vDatos.PopulateColumns()
        'FormatoGrid(vDatos)
        '
        vDatos.Columns("Cliente").Group()
        vDatos.ExpandAllGroups()
    End Sub

    Private Sub frmDetalleMovimientoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = f.Date
        '      
        Combo(cbSucursal, ObtieneDatos("sp_GetSucursalesClientes", EmpresaActual))
        cbSucursal.ItemIndex = 0
        '
        CargarPrimero()
    End Sub

    Sub CargarPrimero()
        Dim dt As DataTable = ObtieneDatos("JAR_GetDetalleMovimientoCliente",
                                           Desde.DateTime.Date.AddMonths(2).Date,
                                           Hasta.DateTime.Date,
                                           cbSucursal.EditValue,
                                           EmpresaActual)

        dgDatos.DataSource = dt.DefaultView
        vDatos.PopulateColumns()
        FormatoGrid(vDatos)
    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
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
                    cbSucursal.Text, ""})

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
            ' Cl.ShowRibbonPreview()
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Exportar_Click(sender As Object, e As EventArgs) Handles Exportar.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Close()
    End Sub
End Class