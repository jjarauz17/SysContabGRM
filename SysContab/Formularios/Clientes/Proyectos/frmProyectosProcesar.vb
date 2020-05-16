Imports ClasesBLL
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient

Public Class frmProyectosProcesar

    Dim DT_PROYECTOS As DataTable

    Private Sub frmProyectosProcesar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetTipoMovimientos(cbMovimiento, 1)
        GetComprobantesList(cbTipoComp)
        cbMovimiento.ItemIndex = 0

        RepositoryItemLookUpEdit(
            cbBodega,
            ObtieneDatos("JAR_GetBodegasList",
                         EmpresaActual),
            "UBICACION",
            "CODIGO", 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)

        FechaMov.DateTime = fHasta.DateTime.Date
        rCheck.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        '
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)

        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVista.Columns("Bodega").OptionsColumn.AllowEdit = True
        iVista.Columns("Procesar").OptionsColumn.AllowEdit = True
        iVista.Columns("Cantidad").OptionsColumn.AllowEdit = True
        iVista.Columns("Saldo").OptionsColumn.AllowEdit = True
        iVista.Columns("Costo").OptionsColumn.AllowEdit = True
        '
        iVista.Columns("IdProyecto").Visible = False
        iVista.Columns("Debito").Visible = False
        iVista.Columns("Credito").Visible = False
        iVista.Columns("Bodega").ColumnEdit = cbBodega
        iVista.Columns("Procesar").ColumnEdit = rCheck
        iVista.Columns("Cantidad").ColumnEdit = rMonto
        iVista.Columns("Costo").ColumnEdit = rMonto
        iVista.Columns("Saldo").ColumnEdit = rMonto
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If iVista.DataRowCount = 0 Then
            XtraMsg("No hay registros para procesar.", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If cbMovimiento.ItemIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Movimiento", MessageBoxIcon.Warning)
            cbMovimiento.Focus()
            Exit Sub
        End If
        '        
        Dim dr() As DataRow = DT_PROYECTOS.Select("Procesar = 1")
        If dr.Length = 0 Then
            XtraMsg("Debe Seleccionar al Menos 1 proyecto para procesar.", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        Dim Saldo As Double = CDbl(DT_PROYECTOS.Compute("SUM(Saldo)", "Procesar = 1").ToString)
        '
        'Si hay saldo de proyectos, entonces validar el tipo de comprobante
        If Saldo > 0 Then
            If Me.cbTipoComp.ItemIndex = 0 Then
                XtraMsg("Seleccione Tipo de Comprobante!")
                cbTipoComp.Focus()
                Exit Sub
            End If
        End If
        '
        If Not XtraMsg2("Esta Seguro de Procesar los Costos en los Proyectos?") Then
            Exit Sub
        End If
        '
        Dim _DT_PROYECTOS As DataTable =
            DT_PROYECTOS.Select("Procesar = 1").CopyToDataTable

        Dim Proyectos = From row In _DT_PROYECTOS.AsEnumerable()
                        Select row.Field(Of String)("Bodega") Distinct

        Dim CuentaDebe = From row In _DT_PROYECTOS.AsEnumerable()
                         Select row.Field(Of String)("Debito") Distinct

        Dim CuentaHaber = From row In _DT_PROYECTOS.AsEnumerable()
                          Select row.Field(Of String)("Credito") Distinct


        ShowSplash("Procesando Proyectos...")

        'Guardar Comprobante, si hay monto en Saldo
        If Saldo > 0 Then
            '***********************************************************************
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()
            '***********************************************************************

            Try
                'Guardar Encabezado del Comprobante
                Dim Comp_No As Integer =
                VB.SysContab.ComprobanteDB.AddComprobante(Me.cbTipoComp.EditValue, 1.0, txtConcepto.Text,
                                        VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase,
                                        VB.SysContab.PeriodosDB.Activo(FechaMov.DateTime.Date),
                                        FechaMov.DateTime.Date, 0, "", False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha,
                                        0, OrigenComprobantes.PROYECTOS_COSTOS)


                'Debito
                For Each s As Object In CuentaDebe
                    If Not s Is Nothing Then
                        Dim Importe As Double = CDbl(_DT_PROYECTOS.Compute("SUM(Saldo)", "Debito = '" & s & "'").ToString)
                        If Importe > 0 Then
                            VB.SysContab.ComprobanteDB.AddComprobanteDetalles(Comp_No, s, "",
                                                                          Math.Round(Importe, 2), 0,
                                                                          cbTipoComp.EditValue, "D", 0, 0,
                                                                          FechaMov.DateTime.Date, 1, 0, "", 0)
                        End If
                    End If
                Next

                'Credito
                For Each s As Object In CuentaHaber
                    If Not s Is Nothing Then
                        Dim Importe As Double = CDbl(_DT_PROYECTOS.Compute("SUM(Saldo)", "Credito = '" & s & "'").ToString)
                        If Importe > 0 Then
                            VB.SysContab.ComprobanteDB.AddComprobanteDetalles(Comp_No, s, "",
                                                                          Math.Round(Importe, 2), 0,
                                                                          cbTipoComp.EditValue, "C", 0, 0,
                                                                          FechaMov.DateTime.Date, 1, 0, "", 0)
                        End If
                    End If
                Next


                VB.SysContab.Rutinas.okTransaccion()
            Catch ex As Exception
                XtraMsg("Error al Guardar Comprobante: " & vbCrLf & ex.Message, MessageBoxIcon.Error)
                VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End Try
        End If
        '
        Try
            'Guardando Movimiento de los Costos a Procesar
            For Each s As Object In Proyectos
                If Not s Is Nothing Then
                    Dim DT_REQ As DataTable = _DT_PROYECTOS.Select("Bodega =" & s).CopyToDataTable

                    Dim Requisa As Integer = db_requisas.Add(EmpresaActual, "E", FechaMov.DateTime.Date, s.ToString, Login,
                                                             "", cbMovimiento.EditValue, "PROCESAR PROYECTOS", txtConcepto.Text)

                    For i As Integer = 0 To DT_REQ.Rows.Count - 1
                        'Guardar Detalle de la Requisa
                        db_requisas.AddDetalle(EmpresaActual, Requisa, DT_REQ.Rows(i)("Codigo"), "P",
                                               DT_REQ.Rows(i)("Cantidad"),
                                               DT_REQ.Rows(i)("Saldo") + DT_REQ.Rows(i)("Costo"),
                                               cbMovimiento.GetColumnValue("Cuenta"), "", "", "")
                        'Marcar Proyecto como Procesado
                        db_requisas.Proyectos_Procesar(
                            DT_REQ.Rows(i)("IdProyecto"),
                            Requisa,
                            EmpresaActual)
                    Next
                    '
                    'Marcar requisa como contabilizada
                    db_requisas.Requisa_Contabilizada(
                        Requisa,
                        EmpresaActual)
                End If
            Next

            HideSplash()
            XtraMsg("Los Proyectos se han procesado con éxito!")
            Close()
            '
            If frmProyectos.Created Then frmProyectos.Cargar()
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message & vbCrLf & "Error al Guardar.", MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Cargar(Desde As Date, Hasta As Date)
        DT_PROYECTOS = ObtieneDatos("sp_ProyectoCosto_procesar",
                                    Desde,
                                    Hasta,
                                    EmpresaActual)

        iGrid.DataSource = DT_PROYECTOS.DefaultView
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        ShowSplash()
        Cargar(
            fDesde.DateTime.Date,
            fHasta.DateTime.Date)
        HideSplash()
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Procesar" Then

            If iVista.GetRowCellValue(e.RowHandle, "Procesar") Then
                e.Appearance.BackColor = Color.LightGreen
            Else
                e.Appearance.BackColor = Color.Tomato
            End If
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        For i As Integer = 0 To iVista.DataRowCount - 1
            iVista.SetRowCellValue(i, "Procesar", CheckEdit1.Checked)
        Next
        iVista.RefreshData()
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles iVista.CellValueChanged
        If e.Column.FieldName = "Costo" Or
           e.Column.FieldName = "Cantidad" Or
           e.Column.FieldName = "Saldo" Then

            iVista.SetRowCellValue(e.RowHandle, "Total",
                                       CDbl(iVista.GetRowCellValue(e.RowHandle, "Cantidad") *
                                       (iVista.GetRowCellValue(e.RowHandle, "Saldo") + iVista.GetRowCellValue(e.RowHandle, "Costo"))))

            'If e.Value > 0 Then
            '    iVista.SetRowCellValue(e.RowHandle, "Total",
            '                           CDbl(iVista.GetRowCellValue(e.RowHandle, "Cantidad") *
            '                           iVista.GetRowCellValue(e.RowHandle, "Costo")))
            'Else
            '    If e.Column.FieldName = "Costo" Then iVista.SetRowCellValue(e.RowHandle, "Costo", e.Value)
            '    If e.Column.FieldName = "Cantidad" Then iVista.SetRowCellValue(e.RowHandle, "Cantidad", e.Value)
            'End If

        End If
    End Sub

    Private Sub iVista_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles iVista.ValidateRow
        If iVista.GetRowCellValue(e.RowHandle, "Cantidad") = 0 Then
            e.ErrorText = "El valor debe ser mayor que Cero (0)." & vbCrLf
            e.Valid = False
        End If
    End Sub

End Class