Imports System.Linq
Imports System.ComponentModel
Imports SysContab.VB.SysContab

Public Class frmOrdenCompraToOP

    Public NoOrden As String,
        Ok As Boolean = False,
        MultiSelect As Boolean = False,
        ds As New DataSet

    Dim OC As New Ordenes_ComprasDB,
        fp As New Forma_PagoDB,
        fc As New Facturas_ComprasDB

    Dim _DT As New DataTable("OrdenCompra"),
        DT_Distribucion As DataTable = New DataTable("Distribucion")

    Private Sub Distribucion()
        DT_Distribucion = CargaDistribucion(0, 0, 0)
    End Sub

    Private Function VerificaDistribucion(ByVal Cuenta As String) As Boolean
        Dim tmp As Boolean = False

        If DT_Distribucion Is Nothing Then
            Return False
        End If

        For i As Integer = 0 To DT_Distribucion.Rows.Count - 1
            If Cuenta = DT_Distribucion.Rows(i).Item("Cuenta") Then
                tmp = True
                Exit For
            End If
        Next

        Return tmp
    End Function

    Private Sub frmOrdenCompraToOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddValidation(Me, DxValidationProvider1)

        SearchLookUp(
                cbProveedor,
                ProveedoresDB.ProveedoresList(1).Tables("Proveedores"), "Nombre", "Codigo")

        Fecha.DateTime = Rutinas.Fecha().Date

        _DT = OC.OrdenComprasDetalleTrasladar(NoOrden)
        iGrid.DataSource = _DT
        FormatoGrid(iVista, 4, 0, False)

        cbProveedor.EditValue = _DT.Rows.Item(0)("Proveedor_ID")
        etTasa.EditValue = GetTasaCambioDia(Fecha.DateTime)

        Dim Tipo As IEnumerable(Of String) =
                       From row In _DT.AsEnumerable()
                       Select row.Field(Of String)("Tipo") Distinct

        If Tipo.Count > 1 Then
            TipoServicio.EditValue = "A"
        Else
            TipoServicio.EditValue = Tipo.ToList().Item(0).ToString()
        End If

        Dim s() As String = Split(NoOrden, ",")

        If Split(NoOrden, ",").Count > 1 Then
            iVista.Columns("NoOrden").Visible = True
            iVista.Columns("NoOrden").VisibleIndex = 0
        End If
    End Sub

    Private Sub frmOrdenCompraToOP_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Ok = False
            Close()
        End If
    End Sub

    Private Sub dFecha_EditValueChanged(sender As Object, e As EventArgs) Handles Fecha.EditValueChanged
        etTasa.EditValue = GetTasaCambioDia(IsNull(Fecha.DateTime, Now.Date))
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        'If Not VerificarCierre(Fecha.DateTime.Date) Then
        '    Exit Sub
        'End If
        ''
        ''******** VERIFICAR DISTRIBUCION ***********************************
        'For i As Integer = 0 To iVista.DataRowCount - 1

        '    Dim DT_RG As DataTable =
        '        ObtieneDatos("sp_sel_RubroGastos",
        '                          iVista.GetRowCellValue(i, "Cuenta"),
        '                          EmpresaActual)

        '    If DT_RG.Rows.Count > 0 Then
        '        If Not VerificaDistribucion(DT_RG.Rows.Item(0)("CuentaContable")) Then
        '            XtraMsg("La Cuenta " & iVista.GetRowCellValue(i, "Cuenta").ToString &
        '                    " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
        '                   "ó Verifique el Detalle de la Distribución.",
        '                    MessageBoxIcon.Warning)
        '            Exit Sub
        '        End If
        '    End If
        'Next
        ''******** FIN VERIFICAR DISTRIBUCION *****************************
        ''
        'Dim Plantilla As New PlantillaDB
        'Dim plan As String = Plantilla.GetTipoPlantilla(1, 9)

        ''Validar si existe la Plantilla Contable
        'If plan = "" Or plan Is DBNull.Value Then
        '    XtraMsg("No hay Plantilla Disponible para realizar Esta Transacción",
        '            MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        ''
        'Dim PlantillaDetalle As PlantillaDetails = Plantilla.GetPlantillasDetails(plan)

        'Dim TipoCompr As Integer = PlantillaDetalle.TipoCompr
        'Dim TCambio As Double = GetTasaCambioDia(Fecha.DateTime)
        'Dim Dias As Integer = fp.FormaPagoDias(cbFormaPago.EditValue)
        'Dim Per_Id As Integer = PeriodosDB.Activo(Fecha.DateTime.Date)
        'Dim DetalleProveedor As ProveedoresDetails = ProveedoresDB.GetDetails(cbProveedor.EditValue)
        'Dim Estado As String = "F"
        'Dim CuentaMntoD As String = String.Empty,
        '    CuentaMntoC = String.Empty

        'Dim Cuentas(iVista.DataRowCount) As String
        'Dim Montos(iVista.DataRowCount) As Double
        ''
        'If _DT.Select("Tipo='P'").Length > 0 And
        '        _DT.Select("Tipo='S'").Length > 0 Then
        '    Estado = "P"
        'End If

        'If TipoServicio.EditValue.Equals("P") Then
        '    Estado = "P"
        'ElseIf TipoServicio.EditValue.Equals("I") Then
        '    Estado = "P"
        'ElseIf TipoServicio.EditValue.Equals("S") Then
        '    Estado = "F"
        'ElseIf TipoServicio.EditValue.Equals("A") Then
        '    Estado = "P"
        'End If

        Ok = True
        Close()

        ShowSplash()
        Inicio = True
        '
        Dim frm As frmFacturasCompra = frmFacturasCompra.Instance()
        frm.Dispose()
        '
        Dim f As frmFacturasCompra = frmFacturasCompra.Instance()
        'f.OrdenCompra = txtFactura.Text
        f.txtOrden.Text = txtNoOrden.Text   'Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "No. Orden")
        f.etOrigen.Text = 0                 'Me.iVista.GetRowCellValue(Me.iVista.FocusedRowHandle, "Factura_Origen")
        f.OC_Multiple = MultiSelect
        f._DT_OC = _DT.Select("Trasladar = 1").CopyToDataTable()
        f.IsLoadOC = True
        f.Destino = 1
        f.gbTipo.Enabled = False
        f.MdiParent = frmPrincipalRibbon
        f.etTipo.Text = "A"
        f.Show()
        f.Text = "Nueva Orden de Pago"
        f.WindowState = FormWindowState.Maximized
        f.txtfactura.Focus()
        f.Nuevo = False
        '
        Inicio = False
        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = False
        Close()
    End Sub

    Private Sub iVista_ShowingEditor(sender As Object, e As CancelEventArgs) Handles iVista.ShowingEditor

        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Entregado") >=
            iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cantidad") Then
            e.Cancel = True
        End If

    End Sub

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        'If iVista.FocusedRowHandle < 0 Then Exit Sub
        ''        
        'Dim SubTotal As Double = 0.00

        'With FrmDetalleRequisas

        '    If cbMoneda.EditValue <> MonedaBase Then
        '        SubTotal = Math.Round(CDbl(iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cantidad") * iVista.GetRowCellValue(iVista.FocusedRowHandle, "Costo")) / etTasa.EditValue, 2)
        '    Else
        '        SubTotal = Math.Round(CDbl(iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cantodad") * iVista.GetRowCellValue(iVista.FocusedRowHandle, "Costo")), 2)
        '    End If
        '    '
        '    .Cuenta = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Cuenta")
        '    .Monto = Math.Abs(SubTotal)
        '    .Tipo = IIf(SubTotal < 0, "C", "D")
        '    .Periodo = PeriodosDB.Activo(Fecha.DateTime.Date)
        '    .CompNo = 0
        '    .Mes = Fecha.DateTime.Month

        '    .Mostrar(DT_Distribucion)
        '    DT_Distribucion.DefaultView.RowFilter = ""
        'End With
    End Sub
End Class