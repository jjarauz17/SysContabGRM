Imports ClasesBLL
Imports DevExpress.XtraGrid.Views.Base

Public Class frmDepositosAdd

    Dim obj As New Depositos,
        db As New db_Depositos

    Dim DT_DEPOSITOS As New DataTable("Depositos")
    Public IdDeposito As Integer = 0

    Private Sub frmDepositosAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchLookUp(
            cbBancos,
            ObtieneDatos("SP_GetCatalogoBancos", EmpresaActual),
            "Nombre",
            "Codigo", 0, 4, 5)
        Combo(
            cbSucursal,
            ObtieneDatos("sp_GetSucursalesxUsuario", EmpresaActual, Usuario_ID))
        cbSucursal.ItemIndex = 0

        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        '
        If IdDeposito > 0 Then
            MostrarDatos()
        Else
            Numero.Text = db_Depositos.Numero(
                IIf(IsNothing(cbSucursal.EditValue), "", cbSucursal.EditValue))
        End If

        Cargar()

        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)
        '
        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
            iVista.Columns(i).OptionsColumn.AllowFocus = False
        Next
        '
        iVista.Columns("Seleccionar").OptionsColumn.AllowEdit = True
        iVista.Columns("Seleccionar").OptionsColumn.AllowFocus = True
        iVista.Columns("Cobro_ID").Visible = False
        iVista.Columns("Cliente").Width = 150
    End Sub

    Sub MostrarDatos()
        obj = db_Depositos.Detalles(IdDeposito)

        Numero.Text = obj.Deposito_ID
        Fecha.DateTime = obj.Fecha
        Documento.Text = obj.Documento
        cbSucursal.EditValue = obj.Sucursal
        cbBancos.EditValue = obj.Banco
        Comentarios.Text = obj.Comentario
    End Sub

    Sub Cargar()

        If Not chkResumido.Checked Then
            DT_DEPOSITOS =
            db_Depositos.Ingresos(
            IIf(cbSucursal.EditValue Is Nothing, "%", cbSucursal.EditValue),
            Usuario_ID,
            IdDeposito,
            Fecha.DateTime.Date)

            iGrid.DataSource = DT_DEPOSITOS
        Else
            DT_DEPOSITOS =
            db_Depositos.IngresosResumen(
            IIf(cbSucursal.EditValue Is Nothing, "%", cbSucursal.EditValue),
            Usuario_ID,
            IdDeposito,
            Fecha.DateTime.Date)

            iGrid.DataSource = DT_DEPOSITOS
        End If

    End Sub

    'Private Sub Tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tipo.SelectedIndexChanged
    '    Cargar()
    'End Sub

    Private Sub frmDepositosAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then Cargar()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodo.CheckedChanged
        If chkResumido.Checked Then chkResumido.CheckState = False

        For i As Integer = 0 To iVista.DataRowCount - 1
            iVista.SetRowCellValue(i, "Seleccionar", chkTodo.Checked)
        Next
        '
        iVista.RefreshData()
        iVista.UpdateTotalSummary()
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles iVista.CellValueChanged
        TotaIngresos()
    End Sub

    Private Sub iVista_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles iVista.RowUpdated
        TotaIngresos()
    End Sub

    Private Sub cbSucursal_EditValueChanged(sender As Object, e As EventArgs) Handles cbSucursal.EditValueChanged
        If IdDeposito = 0 Then Numero.Text = db_Depositos.Numero(
            IIf(IsNothing(cbSucursal.EditValue), "", cbSucursal.EditValue))
    End Sub

    Private Sub Fecha_EditValueChanged(sender As Object, e As EventArgs) Handles Fecha.EditValueChanged
        If Fecha.EditValue Is Nothing Then Exit Sub
        '
        Documento.Text = db_Depositos.Documento(
                Fecha.DateTime.Date,
                IIf(IsNothing(cbSucursal.EditValue), "", cbSucursal.EditValue),
                IdDeposito)
    End Sub

    Private Sub chkResumido_CheckedChanged(sender As Object, e As EventArgs) Handles chkResumido.CheckedChanged
        Cargar()
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click

    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click

    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Sub TotaIngresos()
        Dim Total As Double = 0

        For i As Integer = 0 To iVista.DataRowCount - 1
            If iVista.GetRowCellValue(i, "Seleccionar") Then Total += (iVista.GetRowCellValue(i, "Efectivo") + iVista.GetRowCellValue(i, "Tarjeta"))
        Next
        '
        txtTotal.EditValue = Total
        iVista.RefreshData()
    End Sub


End Class