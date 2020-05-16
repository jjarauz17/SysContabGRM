Imports System.Data
Imports System.Data.SqlClient

Public Class frmPagoCajaChica

    Public dtFact As DataTable
    Dim dsCB As DataSet
    Dim CatBancos As New VB.SysContab.Catalogo_BancosDB
    Dim Comp As New VB.SysContab.ComprobanteDB
    Dim TipoCompr As Integer = 0
    Private Temp As Boolean = False

    Private DT_Distribucion As DataTable = New DataTable("Distribucion")

    Private Sub Distribucion()
        DT_Distribucion = CargaDistribucion(0, 0, 0)
    End Sub

    Private Sub frmPagoCajaChica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Distribucion()
        ' Fecha.DateTime = VB.SysContab.Rutinas.Fecha()
        CargarCombos()
        Cargar()
    End Sub

    Sub CargarCombos()
        Me.cbBanco.Properties.DataSource = ObtieneDatos("SP_GetCatalogoBancos", EmpresaActual, 1).DefaultView
        Me.cbBanco.Properties.ValueMember = "Cuenta"
        Me.cbBanco.Properties.DisplayMember = "Nombre"
        Me.cbBanco.Properties.PopulateColumns()

        Me.cbBanco.Properties.Columns("Codigo").Visible = False
        Me.cbBanco.Properties.Columns("Orden").Visible = False
        Me.cbBanco.Properties.Columns("Cod").Visible = False
        Me.cbBanco.ItemIndex = 0
        ''

        Me.cbCatalogo.DataSource = ObtieneDatos("_GetCatalogo_CuentaActivo " & EmpresaActual).DefaultView
        Me.cbCatalogo.ValueMember = "Cuenta"
        Me.cbCatalogo.DisplayMember = "Display"
        cbCatalogo.PopulateViewColumns()
        'Me.vCatalogo.PopulateColumns()
        FormatoGrid(Me.vCatalogo)

        Me.vCatalogo.Columns("Display").Visible = False
        Me.vCatalogo.Columns("Cuenta").VisibleIndex = 0
        Me.vCatalogo.Columns("Nombre").VisibleIndex = 1
        Me.vCatalogo.Columns("NombreCompleto").VisibleIndex = 2

        'Me.vCatalogo.BestFitColumns()
    End Sub

    Sub Cargar()
        Me.dgDatos.DataSource = dtFact
        Me.vDatos.PopulateColumns()
        FormatoGrid(vDatos, 2, 0, False, True)
        ''
        For i As Integer = 0 To Me.vDatos.Columns.Count - 1
            Me.vDatos.Columns(i).OptionsColumn.AllowEdit = False            
        Next

        Me.vDatos.Columns("Cuenta").OptionsColumn.AllowEdit = True
        'Me.vDatos.Columns("Debito").OptionsColumn.AllowEdit = True
        Me.vDatos.Columns("Proveedor").OptionsColumn.AllowEdit = True
        Me.vDatos.Columns("#Factura").OptionsColumn.AllowEdit = True
        ''Me.vDatos.Columns("Credito").OptionsColumn.AllowEdit = True

        Me.vDatos.Columns("Mnto.").OptionsColumn.AllowEdit = True
        Me.vDatos.Columns("A Pagar").OptionsColumn.AllowEdit = True
        Me.vDatos.Columns("A Pagar U$").OptionsColumn.AllowEdit = True

        'Me.vDatos.Columns("Debito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'Me.vDatos.Columns("Debito").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.vDatos.Columns("Saldo").Visible = False
        Me.vDatos.Columns("Debito").Visible = False
        Me.vDatos.Columns("Fecha").Visible = False
        Me.vDatos.Columns("Proveedor_ID").Visible = False
        Me.vDatos.Columns("Comp_No").Visible = False
        Me.vDatos.Columns("Mes").Visible = False
        Me.vDatos.Columns("Per_ID").Visible = False
        Me.vDatos.Columns("Credito").Visible = False

        Me.vDatos.Columns("Cuenta").ColumnEdit = cbCatalogo
        Me.vDatos.Columns("Debito").ColumnEdit = txtMonto
        Me.vDatos.Columns("Credito").ColumnEdit = txtMonto
        Me.vDatos.Columns("A Pagar").ColumnEdit = txtMonto
        Me.vDatos.Columns("A Pagar U$").ColumnEdit = txtMonto
        Me.vDatos.Columns("Mnto.").ColumnEdit = txtMonto
        Me.vDatos.Columns("Saldo").ColumnEdit = txtMonto
        Me.vDatos.BestFitColumns()
        ''
        TipoCompr = ObtieneDatos("SELECT tc.TipComp_Id Tipo FROM TipoComprobantes tc WHERE tc.TipComp_Cheque = 1 AND tc.Empresa =" & EmpresaActual).Rows.Item(0)(0)
    End Sub

    Private Sub vDatos_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vDatos.CellValueChanged
        Try
            If e.Column.FieldName = "Mnto." Then
                Temp = True
                ' vDatos.SetRowCellValue(e.RowHandle, "A Pagar", Math.Round(CDbl(vDatos.GetRowCellValue(e.RowHandle, "A Pagar") + e.Value), 2))
                vDatos.SetRowCellValue(e.RowHandle, "A Pagar U$", Math.Round(CDbl(IsNull(vDatos.GetRowCellValue(e.RowHandle, "A Pagar"), 0.0) + e.Value) / txtTasa.EditValue, 2))
                Temp = False
            End If
            '
            If e.Column.FieldName = "A Pagar" And Not Temp Then
                Temp = True

                vDatos.SetRowCellValue(e.RowHandle, "A Pagar U$", Math.Round(CDbl(IsNull(vDatos.GetRowCellValue(e.RowHandle, "Mnto."), 0.0) + e.Value) / txtTasa.EditValue, 2))

                Temp = False
            End If
            '
            If e.Column.FieldName = "A Pagar U$" And Not Temp Then
                Temp = True

                vDatos.SetRowCellValue(e.RowHandle, "A Pagar", Math.Round(CDbl(e.Value * txtTasa.EditValue) - IsNull(vDatos.GetRowCellValue(e.RowHandle, "Mnto."), 0.0), 2))

                Temp = False
            End If


            'If e.Column.FieldName = "Debito" Then
            '    If e.Value > 0 Then
            '        vDatos.SetRowCellValue(e.RowHandle, "Credito", 0.0)
            '        'Else
            '        '    vDatos.SetRowCellValue(e.RowHandle, "Debito", 0.0)
            '    End If


            'End If
            ' ''
            'If e.Column.FieldName = "Credito" Then
            '    If e.Value > 0 Then
            '        vDatos.SetRowCellValue(e.RowHandle, "Debito", 0.0)
            '        'Else
            '        '    vDatos.SetRowCellValue(e.RowHandle, "Credito", 0.0)
            '    End If
            'End If

            ''vDatos.RefreshData()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub vDatos_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles vDatos.ValidateRow
        Try
            If IsNull(vDatos.GetRowCellValue(e.RowHandle, "Proveedor_ID"), 0) <> 0 Then

                If vDatos.GetRowCellValue(e.RowHandle, "A Pagar") = 0.0 Or _
                    vDatos.GetRowCellValue(e.RowHandle, "A Pagar U$") = 0.0 Then
                    e.ErrorText = "El Monto a Pagar no puede ser Cero (0)." + vbCrLf
                    e.Valid = False
                End If
                '
                If vDatos.GetRowCellValue(e.RowHandle, "A Pagar") > vDatos.GetRowCellValue(e.RowHandle, "Saldo") Then
                    e.ErrorText = "El Monto a Pagar no puede ser Mayor al Saldo de la Factura." + vbCrLf
                    e.Valid = False
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If txtComentario.Text.Trim.Length = 0 Then
            XtraMsg("Describa un Comentario")
            txtComentario.Focus()
            Exit Sub
        End If
        ''
        If txtNombre.Text.Trim.Length = 0 Then
            XtraMsg("Introduzca el Nombre del Cheque")
            txtNombre.Focus()
            Exit Sub
        End If
        ''
        If ObtieneDatos("SELECT cd.CDet_NoChk FROM ComprobantesDetalles cd WHERE cd.CDet_NoChk = '" & Me.txtNoCheque.Text & "' AND cd.CDet_Cuenta = '" & Me.cbBanco.EditValue & "' AND cd.Empresa = " & EmpresaActual).Rows.Count > 0 Then
            XtraMsg("El Número de Cheque que intenta Guardar para el Banco seleccionado, YA EXISTE.", MessageBoxIcon.Error)
            txtNoCheque.Focus()
            txtNoCheque.SelectAll()
            Exit Sub
        End If
        '
        vDatos.RefreshData()
        vDatos.UpdateTotalSummary()

        '
        ''******** VERIFICAR DISTRIBUCION ***********************************
        'For i As Integer = 0 To vDatos.DataRowCount - 1
        '    Dim CTemp As String = vbNullString
        '    Try
        '        CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
        '                             + " CuentaContable = '" & vDatos.GetRowCellValue(i, "Cuenta") & "'" _
        '                             + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)
        '    Catch ex As Exception
        '        CTemp = "xxx"
        '    End Try

        '    If CTemp <> "xxx" And CTemp <> vbNullString Then
        '        '
        '        If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
        '            XtraMsg("La Cuenta " & vDatos.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
        '                   "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
        '            Exit Sub
        '        End If
        '    End If
        'Next
        ''******** FIN VERIFICAR DISTRIBUCION *****************************

        Dim CuentaMtto As String = ""
        Dim MontoMnto As Double = vDatos.Columns("Mnto.").SummaryItem.SummaryValue

        If MontoMnto > 0.0 Then
            Try
                'Buscar las Cuentas de Matto Valor
                Dim DsPlantillas As DataSet = VB.SysContab.PlantillaDB.GetPlantillasDetails(7, 1).Detalles
                CuentaMtto = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
            Catch ex As Exception
                XtraMsg("Hace Falta la Plantilla de Mantenimiento de Valor", MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

        Dim TCambio As Double = 1.0

        If dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo") = MonedaBase Then
            TCambio = 1
        Else
            TCambio = txtTasa.EditValue
        End If

        '****************************************************************
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()

        Try
            Dim CompNo As Integer = VB.SysContab.ComprobanteDB.AddComprobante(TipoCompr, TCambio,
                                                                              txtComentario.Text, dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo"),
                                                                              VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date),
                                                                              Fecha.DateTime.Date, "", txtNombre.Text.Trim, False, 0, "", 2, "", Me.Fecha.DateTime.Date, 0,
                                                                              OrigenComprobantes.CAJA_CHICA)

            For i As Integer = 0 To Me.vDatos.DataRowCount - 1
                If IsNull(vDatos.GetRowCellValue(i, "A Pagar"), 0) <> 0 Then

                    Dim Importe As Double = Math.Abs(CDbl(IsNull(vDatos.GetRowCellValue(i, "A Pagar"), 0.0)))

                    Dim DC As String = IIf(IsNull(vDatos.GetRowCellValue(i, "A Pagar"), 0.0) > 0, "D", "C")

                    'Guardar Detalle del Comprobante
                    VB.SysContab.ComprobanteDB.AddComprobanteDetalles(CompNo, vDatos.GetRowCellValue(i, "Cuenta"),
                                                IsNull(vDatos.GetRowCellValue(i, "Proveedor"), ""), Math.Round(CDbl(Importe), 2),
                                                txtNoCheque.Text, TipoCompr, DC, IsNull(vDatos.GetRowCellValue(i, "#Factura"), ""), 0,
                                                Fecha.DateTime.Date, 0)


                    'Validar solo las lineas que son cuentas de Proveedores
                    If IsNull(vDatos.GetRowCellValue(i, "Proveedor_ID"), 0) <> 0.0 Then

                        If IsNull(vDatos.GetRowCellValue(i, "A Pagar"), 0.0) > 0.0 Then

                            If vDatos.GetRowCellValue(i, "A Pagar") >= vDatos.GetRowCellValue(i, "Saldo") Then
                                VB.SysContab.ComprobanteDB.CancelarFactura(vDatos.GetRowCellValue(i, "#Factura"), vDatos.GetRowCellValue(i, "Proveedor_ID"), 1)
                            End If

                            VB.SysContab.ComprobanteDB.PagosFactura(vDatos.GetRowCellValue(i, "Comp_No"), vDatos.GetRowCellValue(i, "Per_ID"),
                                              vDatos.GetRowCellValue(i, "Fecha"), vDatos.GetRowCellValue(i, "A Pagar"),
                                              CompNo, VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date),
                                              Fecha.DateTime.Date, vDatos.GetRowCellValue(i, "#Factura"),
                                              vDatos.GetRowCellValue(i, "Proveedor_ID"), 0)
                        End If
                    End If
                End If
            Next
            'Contabilizar Mantenimiento de Valor
            If MontoMnto > 0.0 Then
                VB.SysContab.ComprobanteDB.AddComprobanteDetalles(CompNo, CuentaMtto,
                                            "Mantenimiento de Valor",
                                            Math.Round(MontoMnto, 2),
                                            txtNoCheque.Text, TipoCompr, "D", "", 0, Me.Fecha.DateTime.Date, 1)
            End If

            '' Credito
            VB.SysContab.ComprobanteDB.AddComprobanteDetalles(CompNo, cbBanco.EditValue,
                                            cbBanco.GetColumnValue("Descripcion"),
                                            Math.Round(CDbl(vDatos.Columns("A Pagar").SummaryItem.SummaryValue + MontoMnto), 2),
                                            txtNoCheque.Text, TipoCompr, "C", "", 0, Me.Fecha.DateTime.Date, 0)

            If IsNumeric(txtNoCheque.Text) Then
                VB.SysContab.ComprobanteDB.ActualizarCheque(cbBanco.EditValue, txtNoCheque.Text)
            End If

            VB.SysContab.Rutinas.okTransaccion()
            '
            '----------------------
            'Guarda la Distribucion
            '----------------------
            Dim DT_F As DataTable
            DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Deleted)
            If Not DT_F Is Nothing Then
                For i = 0 To DT_F.Rows.Count - 1
                    With DT_F
                        If .Rows(i).RowState = DataRowState.Added Then
                            GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
                            " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & CompNo & "," & Fecha.DateTime.Month & "," &
                            VB.SysContab.PeriodosDB.Activo(Fecha.DateTime) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
                        ElseIf .Rows(i).RowState = DataRowState.Modified Then
                            GuardaDatos("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & CompNo & ",Mes=" & Fecha.DateTime.Month & "," &
                            "Per_Id = " & VB.SysContab.PeriodosDB.Activo(Fecha.DateTime) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," &
                            "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
                        ElseIf .Rows(i).RowState = DataRowState.Deleted Then
                        End If
                    End With
                Next
            End If

            'Distribucion()
            '--------------------------
            'Fin de Guarda Distribucion
            '--------------------------

            Dim f As frmListaFacturaProveedoresPlan = frmListaFacturaProveedoresPlan.Instance()
            f.Cargar()

            Close()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg("ERROR : " & ex.Message, MessageBoxIcon.Error)
        End Try
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

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub cbBanco_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBanco.EditValueChanged
        Try
            dsCB = CatBancos.CatalogoBancosXCuenta(cbBanco.EditValue)

            txtNoCheque.EditValue = VB.SysContab.Catalogo_BancosDB.GetCheque(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Banco"), dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("Numero_Cuenta")).ToString
            txtBalance.Text = CDbl(IsNull(VB.SysContab.ComprobanteDB.SaldoxCuenta(Me.cbBanco.EditValue, VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date)), 0)).ToString("n2")
            txtMoneda.Text = dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_descripcion")

            'If VB.SysContab.EmpresasDB.GetDetails(EmpresaActual).MonedaBase.Equals(dsCB.Tables("CATALOGO_BANCOS").Rows(0).Item("mon_codigo")) Then
            '    TCambio = 1
            '    txtTasa.EditValue = TCambio
            'Else
            '    TCambio = TasaPago
            '    txtTasa.EditValue = TCambio
            'End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub vDatos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vDatos.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vDatos.DeleteSelectedRows()
            Me.vDatos.RefreshData()
        End If
    End Sub
End Class