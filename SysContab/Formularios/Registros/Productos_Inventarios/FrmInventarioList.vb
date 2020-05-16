Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class FrmInventarioList

    Dim comp As New VB.SysContab.ComprobanteDB

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub FrmInventarioList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)
        Cargar()
    End Sub

    Sub Cargar()
        iGrid.DataSource = ObtieneDatos("RCT_SPGetInventariosList", EmpresaActual)
        iVista.PopulateColumns()
        FormatoGrid(iVista)

        iVista.Columns("IdInventario").Visible = False
        iVista.Columns("codigo_bodega").Visible = False
        iVista.Columns("Origen").Visible = False

        'iVista.Columns("Comentario").Width = 350
    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNuevo.Click
        FrmLevantarInventario.Dispose()
        FrmLevantarInventario.MdiParent = Me.MdiParent
        FrmLevantarInventario.Show()
        FrmLevantarInventario.Text = "Nuevo Inventario Fisico"
        FrmLevantarInventario.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bModificar.Click
        FrmLevantarInventario.Dispose()
        FrmLevantarInventario.MdiParent = Me.MdiParent
        FrmLevantarInventario.IdInventario = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdInventario")
        FrmLevantarInventario.Show()
        FrmLevantarInventario.Text = "Editar Inventario Fisico"
        FrmLevantarInventario.WindowState = FormWindowState.Maximized
    End Sub


    Function GetForm(ByVal f As Form) As Form

        Return f

    End Function


    Private Sub Autorizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub


    'Function Contabilizar() As Boolean


    '    'Dim Requisa As Integer
    '    ''Requisa = Me.txtrequisa.Text

    '    Dim conexion As New VB.SysContab.Rutinas
    '    DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
    '    DBConnFacturas.Open()
    '    transaccionFacturas = DBConnFacturas.BeginTransaction()
    '    Dim compNumero As Integer
    '    Dim Periodo As Integer

    '    Periodo = VB.SysContab.PeriodosDB.Activo(iVista.GetFocusedRowCellValue("Fecha"))
    '    Try
    '        'CompNumero = comp.ComprobanteUpdate(Me.lblNoComprobante.Text, Me.cbTipoComp.SelectedValue, Me.lblTasaCambio.Text, Me.txtConcepto.Text, ddlMoneda.SelectedValue, Me.lblPeriodo.Text, Me.dtpFecha.Value, 0, False, Me.txtFecha.Text, Me.etRuc.Text, Me.lblChequeNombre.Text, Me.etPagara.Text, Me.etFactura1.Text, Me.dtpFechaPago.Value, Me.etFormaPago.Text, Me.etTipoX.Text)
    '        'agregar el comprobante
    '        'compNumero = comp.AddComprobante(Me.cbTipoComp.SelectedValue, 1.0, Me.Concepto.TextBox.Text, "", _
    '        '   Periodo, Me.dtpFecha.Value, "", "", False, "", "", "", "", "", 0)
    '        compNumero = comp.AddComprobante("101", 1, _
    '                                         "Comprobante de Inventario Fisico con Fecha " & iVista.GetFocusedRowCellValue("Fecha"), _
    '                                         VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase, Periodo, _
    '                                         iVista.GetFocusedRowCellValue("Fecha"), 0, "", False, "0", "", 1, "", _
    '                                         VB.SysContab.Rutinas.Fecha, "0", OrigenComprobantes.MOVIMIENTO_INVENTARIO)

    '        'Actualizar la requisa como contabilizada
    '        'VB.SysContab.RequisasDB.Contabilizar(Requisa, True, False, compNumero, Periodo, CDate(fecha.EditValue).Month)

    '        Dim Debe As Double = 0
    '        Dim Haber As Double = 0
    '        Dim DC As String
    '        Dim Opera As Integer
    '        Dim valida As Boolean = False

    '        Dim dtCuentas As New DataTable
    '        dtCuentas.Columns.Add("Cuenta_Inventario")
    '        dtCuentas.Columns.Add("Cuenta_Costo")
    '        dtCuentas.Columns.Add("Monto_Debito")
    '        dtCuentas.Columns.Add("Monto_Credito")

    '        Dim dtDatos As New DataTable

    '        Dim Variables As New ArrayList
    '        Dim Datos As New ArrayList
    '        Variables.Add("Bodega")
    '        Variables.Add("Tipo")
    '        Variables.Add("IdInventario")
    '        Variables.Add("Fecha")
    '        Datos.Add(iVista.GetFocusedRowCellValue("codigo_bodega"))
    '        Datos.Add(iVista.GetFocusedRowCellValue("Tipo"))
    '        Datos.Add(iVista.GetFocusedRowCellValue("IdInventario"))
    '        Datos.Add(Today)

    '        DTDatos = ProcedureParameters(Datos, Variables, "RCT_SPGetInventarioFisico")


    '        For i As Integer = 0 To dtDatos.Rows.Count - 1

    '            If dtDatos.Rows(i).Item("Diferencia") <> 0 Then

    '                If dtDatos.Rows(i).Item("Diferencia") > 0 Then

    '                    ' DEBITO
    '                    valida = False

    '                    For j As Integer = 0 To dtCuentas.Rows.Count - 1
    '                        If dtDatos.Rows(i).Item("Cuenta") = dtCuentas.Rows(j)("Cuenta_Inventario").ToString Then
    '                            dtCuentas.Rows(j)("Monto_Debito") = IsNull(dtCuentas.Rows(j)("Monto_Debito"), 0) + IsNull(dtDatos.Rows(i).Item("Monto"), 0)
    '                            valida = True
    '                            Exit For
    '                        End If
    '                    Next

    '                    If valida = False Then

    '                        dtCuentas.Rows.Add()
    '                        dtCuentas.Rows(dtCuentas.Rows.Count - 1)("Cuenta_Inventario") = dtDatos.Rows(i).Item("Cuenta")
    '                        dtCuentas.Rows(dtCuentas.Rows.Count - 1)("Monto_Debito") = IsNull(dtDatos.Rows(i).Item("Monto"), 0)
    '                    End If

    '                    ' CREDITO
    '                    valida = False

    '                    For j As Integer = 0 To dtCuentas.Rows.Count - 1
    '                        If dtDatos.Rows(i).Item("CuentaCosto") = dtCuentas.Rows(j)("Cuenta_Costo").ToString Then
    '                            dtCuentas.Rows(j)("Monto_Credito") = IsNull(dtCuentas.Rows(j)("Monto_Credito"), 0) + IsNull(dtDatos.Rows(i).Item("Monto"), 0)
    '                            valida = True
    '                            Exit For
    '                        End If
    '                    Next

    '                    If valida = False Then

    '                        dtCuentas.Rows.Add()
    '                        dtCuentas.Rows(dtCuentas.Rows.Count - 1)("Cuenta_Costo") = dtDatos.Rows(i).Item("CuentaCosto")
    '                        dtCuentas.Rows(dtCuentas.Rows.Count - 1)("Monto_Credito") = IsNull(dtDatos.Rows(i).Item("Monto"), 0)
    '                    End If



    '                End If


    '                ' CASO CONTRARIO



    '                If dtDatos.Rows(i).Item("Diferencia") < 0 Then

    '                    ' CREDITO
    '                    valida = False

    '                    For j As Integer = 0 To dtCuentas.Rows.Count - 1
    '                        If dtDatos.Rows(i).Item("Cuenta") = dtCuentas.Rows(j)("Cuenta_Inventario").ToString Then
    '                            dtCuentas.Rows(j)("Monto_Credito") = IsNull(dtCuentas.Rows(j)("Monto_Credito"), 0) + IsNull(dtDatos.Rows(i).Item("Monto"), 0)
    '                            valida = True
    '                            Exit For
    '                        End If
    '                    Next

    '                    If valida = False Then

    '                        dtCuentas.Rows.Add()
    '                        dtCuentas.Rows(dtCuentas.Rows.Count - 1)("Cuenta_Inventario") = dtDatos.Rows(i).Item("Cuenta")
    '                        dtCuentas.Rows(dtCuentas.Rows.Count - 1)("Monto_Credito") = IsNull(dtDatos.Rows(i).Item("Monto"), 0)
    '                    End If

    '                    ' DEBITO
    '                    valida = False

    '                    For j As Integer = 0 To dtCuentas.Rows.Count - 1
    '                        If dtDatos.Rows(i).Item("CuentaCosto") = dtCuentas.Rows(j)("Cuenta_Costo").ToString Then
    '                            dtCuentas.Rows(j)("Monto_Debito") = IsNull(dtCuentas.Rows(j)("Monto_Debito"), 0) + IsNull(dtDatos.Rows(i).Item("Monto"), 0)
    '                            valida = True
    '                            Exit For
    '                        End If
    '                    Next

    '                    If valida = False Then

    '                        dtCuentas.Rows.Add()
    '                        dtCuentas.Rows(dtCuentas.Rows.Count - 1)("Cuenta_Costo") = dtDatos.Rows(i).Item("CuentaCosto")
    '                        dtCuentas.Rows(dtCuentas.Rows.Count - 1)("Monto_Debito") = IsNull(dtDatos.Rows(i).Item("Monto"), 0)
    '                    End If

    '                End If



    '            End If

    '        Next





    '        For i As Integer = 0 To dtCuentas.Rows.Count - 1



    '            If IsNull(dtCuentas.Rows(i)("Cuenta_Inventario"), "") <> "" Then

    '                If Math.Abs(CDbl(IsNull(dtCuentas.Rows(i)("Monto_Debito"), 0))) > 0 Then
    '                    comp.AddComprobanteDetalles1(compNumero, dtCuentas.Rows(i)("Cuenta_Inventario"), "Inventario Fisico", _
    '                                             Math.Abs(CDbl(dtCuentas.Rows(i)("Monto_Debito"))), "", _
    '                                             "101", "D", "", "", Periodo, iVista.GetFocusedRowCellValue("Fecha"), 1)

    '                End If

    '            End If

    '            If IsNull(dtCuentas.Rows(i)("Cuenta_Inventario"), "") <> "" Then

    '                If Math.Abs(CDbl(IsNull(dtCuentas.Rows(i)("Monto_Credito"), 0))) > 0 Then
    '                    comp.AddComprobanteDetalles1(compNumero, dtCuentas.Rows(i)("Cuenta_Inventario"), "Inventario Fisico", _
    '                                                 Math.Abs(CDbl(dtCuentas.Rows(i)("Monto_Credito"))), "", _
    '                                                "101", "C", "", "", Periodo, iVista.GetFocusedRowCellValue("Fecha"), 1)
    '                End If
    '            End If


    '            If IsNull(dtCuentas.Rows(i)("Cuenta_Costo"), "") <> "" Then


    '                If Math.Abs(CDbl(IsNull(dtCuentas.Rows(i)("Monto_Debito"), 0))) > 0 Then
    '                    comp.AddComprobanteDetalles1(compNumero, dtCuentas.Rows(i)("Cuenta_Costo"), "InventarioFisico", _
    '                                             Math.Abs(CDbl(dtCuentas.Rows(i)("Monto_Debito"))), "", _
    '                                          "101", "D", "", "", Periodo, iVista.GetFocusedRowCellValue("Fecha"), 1)
    '                End If

    '            End If


    '            If IsNull(dtCuentas.Rows(i)("Cuenta_Costo"), "") <> "" Then

    '                If Math.Abs(CDbl(IsNull(dtCuentas.Rows(i)("Monto_Credito"), 0))) > 0 Then
    '                    comp.AddComprobanteDetalles1(compNumero, dtCuentas.Rows(i)("Cuenta_Costo"), "InventarioFisico", _
    '                                             Math.Abs(CDbl(dtCuentas.Rows(i)("Monto_Credito"))), "", _
    '                                          "101", "C", "", "", Periodo, iVista.GetFocusedRowCellValue("Fecha"), 1)

    '                End If
    '            End If





    '        Next





    '        VB.SysContab.Rutinas.okTransaccion()


    '        If MsgBox("Desea Imprimir el comprobante?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "STS-Contab") = MsgBoxResult.Yes Then
    '            ImprimirComprobante(compNumero, Periodo, iVista.GetFocusedRowCellValue("Fecha"))
    '        End If

    '        Return True

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        VB.SysContab.Rutinas.ErrorTransaccion()
    '        Return False
    '    End Try

    '    Me.Close()
    'End Function

    'Sub ImprimirComprobante(ByVal Comprobante As Integer, ByVal Periodo As Integer, ByVal Fecha As Date)
    '    Dim DSComp As New DataSet

    '    Dim DA As New SqlDataAdapter("_ComprobantesImpresoALL", VB.SysContab.Rutinas.AbrirConexion)
    '    DA.SelectCommand.CommandType = CommandType.StoredProcedure

    '    DA.SelectCommand.Parameters.Add("@ComprNO", SqlDbType.NChar)
    '    DA.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int)
    '    DA.SelectCommand.Parameters.Add("@PerID", SqlDbType.Int)
    '    DA.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime)

    '    DA.SelectCommand.Parameters("@Empresa").Value = EmpresaActual
    '    DA.SelectCommand.Parameters("@ComprNO").Value = Comprobante
    '    DA.SelectCommand.Parameters("@PerID").Value = Periodo
    '    DA.SelectCommand.Parameters("@Fecha").Value = Fecha

    '    DA.Fill(DSComp, "Comprobantes")

    '    DSComp.WriteXml(Application.StartupPath & "\rptComprobantesAll.xml", XmlWriteMode.WriteSchema)

    '    Dim rpt As New rptComprobantesALL
    '    rpt.ver = True
    '    rpt.XmlDataPath = Application.StartupPath & "\rptComprobantesAll.xml"

    '    rpt.ShowPrintMarginsWarning = False
    '    rpt.BringToFront()
    '    rpt.ShowRibbonPreview()
    'End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEliminar.Click
        If Me.iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If

        If Me.iVista.GetFocusedRowCellValue("Autorizado") Then
            XtraMsg("El Inventario ya Fue Aplicado", MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not XtraMsg2("¿ Esta Seguro de Borrar el Inventario Fisico Seleccionado ?") Then
            Exit Sub
        End If

        If GuardaDatos("sp_IventarioFisicoDelete " & iVista.GetFocusedRowCellValue("IdInventario")) Then
            Cargar()
        End If
    End Sub

    Private Sub bAplicar_Click(sender As Object, e As EventArgs) Handles bAplicar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        If iVista.GetFocusedRowCellValue("Autorizado") Then
            XtraMsg("El Inventario Fisico ya fue aplicado.", MessageBoxIcon.Error)
            Exit Sub
        End If

        If XtraMsg2("Esta seguro que desea aplicar un el Inventario Fisico?, una vez aplicado no podra modificarlo") Then
            With frmAplicarInventarioFisico
                .Fecha.DateTime = iVista.GetFocusedRowCellValue("Fecha")
                .txtNumero.Text = iVista.GetFocusedRowCellValue("Numero")
                .Bodega = iVista.GetFocusedRowCellValue("codigo_bodega")
                .IdInventario = iVista.GetFocusedRowCellValue("IdInventario")
                .ShowDialog()
                .Dispose()
            End With
            'GuardaRequisa()
            'XtraMsg("Inventario Fisico Aplicado Satisfactoriamente")
            'Cargar()
        End If
    End Sub

    Private Sub Formato_Click(sender As Object, e As EventArgs) Handles bFormato.Click
        frmInventarioFisicoLineas.Tipo = "P"
        frmInventarioFisicoLineas.ShowDialog()
        frmInventarioFisicoLineas.Dispose()
    End Sub
End Class