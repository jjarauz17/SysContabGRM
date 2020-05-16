Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports SysContab.VB.SysContab

Public Class frmReporteIRAnual
    Private Sub frmReporteIRAnual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
        LookUp(cbPeriodo, ObtieneDatos("_GetListPeriodos", EmpresaActual), "descripcion", "codigo", "[Seleccione Periodo]", 0, 2, 3, 4, 5)
        SearchLookUp(cbCuentaRenta, ObtieneDatos("_GetCatalogo_Cuenta", EmpresaActual), "Display", "Cuenta", 2)

        LookUp(cbTipo, ObtieneDatos("SP_TipoComprobantesList", EmpresaActual, 1), "TipComp_Nombre", "TipComp_Id", 0, 2, 3)
        cbTipo.ItemIndex = 0
        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
    End Sub

    Sub Cargar()
        iGridIR.DataSource = ObtieneDatos("sp_sel_IR_BALBOA", EmpresaActual)
        iVistaIR.PopulateColumns()
        FormatoGrid(iVistaIR, 2, 0, False, False, False)
        '        
        iVistaIR.Columns("Primer %").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None
        iVistaIR.Columns("Primer %").DisplayFormat.FormatString = "{0:p2}"
        iVistaIR.Columns("Segundo %").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None
        iVistaIR.Columns("Segundo %").DisplayFormat.FormatString = "{0:p2}"

        iVistaIR.OptionsView.ShowFooter = False
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If iVistaIR.DataRowCount = 0 Then
            XtraMsg("No existe Tabla de IR Configurada", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If cbPeriodo.EditValue Is Nothing Then
            XtraMsg("Seleccione el Periodo contable.")
            cbPeriodo.Focus()
            Exit Sub
        End If
        '
        If cbCuentaRenta.EditValue Is Nothing Then
            XtraMsg("Seleccione la Cuenta Contable del Impuesto a la Renta.")
            cbCuentaRenta.Focus()
            Exit Sub
        End If
        '
        ShowSplash("Generando Resultado...")
        iGridResultado.DataSource = ObtieneDatos("sp_GetRetencionAnual",
                                          CDate(cbPeriodo.GetColumnValue("Fin")),
                                          MonedaBase,
                                          EmpresaActual)
        iVistaResultado.PopulateColumns()
        FormatoGrid(iVistaResultado, 2, 0, False, False, False)

        iVistaResultado.OptionsView.ShowFooter = False

        If iVistaResultado.DataRowCount > 0 Then
            Dim Monto As Double = 0.00
            If CDbl(IsNull(iVistaResultado.GetRowCellValue(0, "Segundo Resultado"), 0.00)) > CDbl(IsNull(iVistaResultado.GetRowCellValue(1, "Primer Resultado"), 0.00)) Then
                Monto = Math.Round(CDbl(IsNull(iVistaResultado.GetRowCellValue(0, "Segundo Resultado"), 0.00)), 2)
            Else
                Monto = Math.Round(CDbl(IsNull(iVistaResultado.GetRowCellValue(1, "Primer Resultado"), 0.00)), 2)
            End If

            lblImpuesto.Text = "Retención de este Periódo " + cbPeriodo.GetColumnValue("Año").ToString() + " = " + Monto.ToString("n")

            GenerarComprobante(Monto)
        End If
        '
        HideSplash()
    End Sub

    Sub GenerarComprobante(Monto As Double)
        RepositorySearchLook(cbCatalogo, ObtieneDatos("_GetCatalogo_Cuenta", EmpresaActual), "Display", "Cuenta", 2)


        iGridComp.DataSource = ObtieneDatos("sp_ComprobantesIRAnual",
                                            cbCuentaRenta.EditValue,
                                            Monto,
                                            EmpresaActual)
        iVistaComp.PopulateColumns()
        FormatoGrid(iVistaComp, 2, 0, False, False, False)

        For i As Integer = 0 To iVistaComp.Columns.Count - 1
            iVistaComp.Columns(i).OptionsColumn.AllowEdit = False
        Next

        iVistaComp.Columns("Cuenta").ColumnEdit = cbCatalogo
        iVistaComp.Columns("Cuenta").OptionsColumn.AllowEdit = True
        iVistaComp.Columns("Descripcion").OptionsColumn.AllowEdit = True
    End Sub

    Private Sub cbPeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles cbPeriodo.EditValueChanged
        If cbPeriodo.EditValue Is Nothing Then Exit Sub
        '
        Fecha.Properties.MinValue = CDate(cbPeriodo.GetColumnValue("Inicio"))
        Fecha.Properties.MaxValue = CDate(cbPeriodo.GetColumnValue("Fin"))
        Fecha.DateTime = CDate(cbPeriodo.GetColumnValue("Fin"))
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If cbTipo.ItemIndex = 0 Then
            XtraMsg("Seleccione Tipo de Comprobante")
            cbTipo.Focus()
            Exit Sub
        End If
        '
        If cbPeriodo.EditValue Is Nothing Then
            XtraMsg("Seleccione el Periodo contable.")
            cbPeriodo.Focus()
            Exit Sub
        End If
        '
        If Concepto.Text.Trim.Length = 0 Then
            XtraMsg("Describa el Concepto del Comprobante")
            Concepto.Focus()
            Exit Sub
        End If
        '
        If iVistaComp.DataRowCount = 0 Then
            XtraMsg("No existe Detalle del Comprobante", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        Dim Cantidad As Integer = ObtieneDatos("sp_ComprobantesIRAnualValidar", cbPeriodo.EditValue, EmpresaActual).Rows.Item(0)("Cantidad")

        If Cantidad = 1 Then
            XtraMsg("Ya exite un Comprobante del Tipo IR_ANUAL para este periodo Seleccionado.", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Not Math.Round(CDbl(iVistaComp.Columns("Debito").SummaryItem.SummaryValue), 2) _
            .Equals(Math.Round(CDbl(iVistaComp.Columns("Credito").SummaryItem.SummaryValue), 2)) Then
            XtraMsg("El Débito y el Crédito no estan cuadrados", MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim Per_Id As Integer = PeriodosDB.Activo(Fecha.DateTime.Date)
        Dim Cuenta As String = String.Empty, DC As String = String.Empty
        Dim Importe As Double = 0.00000

        '----------------------------------------------------------------------
        Dim conexion As New VB.SysContab.Rutinas
        DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()
        '----------------------------------------------------------------------

        Try
            Dim Comp_No As Double =
            ComprobanteDB.AddComprobante(cbTipo.EditValue, 1.0, Concepto.Text,
                                        MonedaBase, Per_Id,
                                        Fecha.DateTime.Date, 0, "", False, 0, "", 0, "", Rutinas.Fecha,
                                        0, OrigenComprobantes.IR_ANUAL, "", 0, 0, "")

            With iVistaComp
                For i As Integer = 0 To .DataRowCount - 1
                    Cuenta = .GetRowCellValue(i, "Cuenta")
                    '
                    If .GetRowCellValue(i, "Debito") > 0 Then
                        DC = "D"
                        Importe = .GetRowCellValue(i, "Debito")
                    ElseIf .GetRowCellValue(i, "Credito") > 0 Then
                        DC = "C"
                        Importe = .GetRowCellValue(i, "Credito")
                    End If
                    '
                    ComprobanteDB.AddComprobanteDetalles(Comp_No, Cuenta, IsNull(.GetRowCellValue(i, "Descripcion"), ""),
                                                            Math.Round(Importe, 2), 0, cbTipo.EditValue, DC, "", 0,
                                                            Fecha.DateTime.Date, 1, 0)
                Next
            End With

            Rutinas.okTransaccion()
            XtraMsg("El Comprobante de IR ANUAL se ha guardado con éxito!")

            ShowSplash("Imprimiendo Comprobante....")

            Dim Temp As Boolean = db_Formatos.FormatoImpreso(17, "rptComprobante")
            Dim rpt As rptComprobantesALL

            If Temp = True Then
                rpt = XtraReport.FromFile(Application.StartupPath & "\rptComprobante.repx", True)
            Else
                rpt = New rptComprobantesALL
            End If

            rpt.ver = True
            rpt.gfDistribucion.Visible = False

            Dim _DT As DataTable = ObtieneDatos("_ComprobantesImpresoALL",
                                                Comp_No,
                                                EmpresaActual,
                                                Per_Id,
                                                Fecha.DateTime.Date)

            VistaPreviaDX(rpt, _DT, "Comprobante de Retención Anual")

            HideSplash()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg("Error al Guardar Comprobante: " & ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub
End Class