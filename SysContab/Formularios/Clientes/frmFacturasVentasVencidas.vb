Imports Entities

Public Class frmFacturasVentasVencidas

    Public sProc As String = String.Empty
    Public Origen As Integer = 0
    Public DT As New DataTable("Vencidas")
    Public Ok As Boolean = False,
        Saldo As Double = 0.00,
        Facturas As String = String.Empty,
        IdCliente As Integer = 0

    Private Sub frmFacturasVentasVencidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Origen = 0 Then Cargar()
        If Origen = 1 Then CargarVencidas()
    End Sub

    Sub Cargar()
        iGrid.DataSource = ObtieneDatos(sProc, EmpresaActual, 1)
        FormatoGrid(iVista)

        iVista.Columns("CLIENTE").Width = 300
        iVista.Columns("FACTURA").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        iVista.Columns("FACTURA").SummaryItem.DisplayFormat = "{0:n0}"

        'iVista.Columns("CLIENTE").Group()
        'iVista.ExpandAllGroups()
    End Sub

    Sub CargarVencidas()

        lblMsg.Text = "El Cliente contiene facturas vencidas, Desea Facturar de todos Modos ?" & vbCrLf &
            "Quedará grabado en bitacora si decide facturar."
        lyFacturar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lyRazon.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

        iGrid.DataSource = DT

        iVista.PopulateColumns()
        FormatoGrid(iVista)

        iVista.Columns("Cliente").Visible = False
        iVista.Columns("IdCliente").Visible = False
        iVista.Columns("Moneda").Visible = False
        '
        iVista.Columns("Monto").Caption = "Monto en " & iVista.GetRowCellValue(0, "Moneda")
        iVista.Columns("Saldo").Caption = "Saldo en " & iVista.GetRowCellValue(0, "Moneda")

        iVista.Columns("Factura").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        iVista.Columns("Factura").SummaryItem.DisplayFormat = "{0:n0}"
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = False
        Close()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If mRazon.Text.Trim.Length = 0 Then
            XtraMsg("Se debe describir la razon por la cual se autoriza facturar a este cliente.", MessageBoxIcon.Error)
            mRazon.Focus()
            Exit Sub
        End If
        '
        If mRazon.Text.Trim.Length < 15 Then
            XtraMsg("Favor indicar un comentario válido", MessageBoxIcon.Error)
            mRazon.Focus()
            mRazon.SelectAll()
            Exit Sub
        End If
        '
        Dim objCliente As New CLIENTES,
            dbClientes As New db_CLIENTES
        objCliente = dbClientes.Detalles(IdCliente, EmpresaActual)

        If objCliente.ValidarVencidas = 1 Then
            frmListaNegraValidar.Dispose()
            '
            With frmListaNegraValidar
                .Text = $"Cliente: {objCliente.NOMBRE}"
                .IdCliente = IdCliente
                .ClienteN = objCliente.NOMBRE
                .Factura = String.Empty
                .IdSucursal = objCliente.CodigoLetra.Substring(0, 2)
                .TipoAprobacion = "Facturas Vencidas"
                .ShowDialog()
                If Not .Ok Then
                    Exit Sub
                End If
            End With
        End If
        '
        For i As Integer = 0 To iVista.DataRowCount - 1
            Facturas = Facturas + iVista.GetRowCellValue(i, "Factura") + " ,"
        Next

        Saldo = Math.Round(CDbl(iVista.Columns("Saldo").SummaryItem.SummaryValue), 2)

        Ok = True
        Close()
    End Sub
End Class