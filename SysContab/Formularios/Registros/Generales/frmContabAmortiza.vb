Imports System.Data
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab
Imports DevExpress.XtraEditors
Imports ClasesBLL

Public Class frmContabAmortiza
    Dim FirthTime As Integer = 0
    Dim DT_ROW As DataTable 'Contiene la Fila de la amortizacion actual
    Dim con As New SqlConnection(Rutinas.AbrirConexion)
    Dim Comprobante As New ComprobanteDB()

    Private DT_Distribucion As DataTable = New DataTable("Distribucion")

    Dim obj As New Amortizaciones

    Dim Comp_No As Integer = 0,
        Per_Id As Integer,
        TCambio As Double = 1

    Private Sub Distribucion()
        DT_Distribucion = CargaDistribucion(0, 0, 0)
    End Sub

    Private Sub frmContabAmortiza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Combos()
        fecha.DateTime = Now.Date
        '
        Distribucion()
        '
        GetTasa()
        '
        Cargar()
        FormatoGrid(iVista, 2, 0, False, True, False)
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_Amortizaciones.Plantilla(IIf(cbAmorizaciones.EditValue Is Nothing, 0, cbAmorizaciones.EditValue))
    End Sub

    Sub GetTasa()
        '**** Cargar Tasa de Cambio
        TCambio = CDbl(ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo._TCambioDia(" & EmpresaActual & ",'" & fecha.DateTime.Date & "')").Rows.Item(0)(0)).ToString("n4")
        txtTasa.EditValue = TCambio
        '
        If EmpresasDB.GetDetails(EmpresaActual).MonedaBase = cbMoneda.EditValue Then
            TCambio = 1
        End If
    End Sub

    Private Sub Combos()

        'Cargar Datos en Combo
        'Me.cbNombre.Properties.DataSource = ObtieneDatos("sp_AmortizacionesList " & EmpresaActual).DefaultView
        'Me.cbNombre.Properties.DisplayMember = "Nombre"
        'Me.cbNombre.Properties.ValueMember = "Codigo"
        'Me.cbNombre.Properties.PopulateColumns()
        'Me.cbNombre.ItemIndex = 0

        SearchLookUp(cbAmorizaciones, db_CatalogoAmortizacion.ListarPendientes(0), "Nombre", "Codigo", 2, 3, 4, 6, 7, 8)

        RepositorySearchLook(cbCatalogo, ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual), "Display", "Cuenta", 2)

        GetMonedasList(cbMoneda)
        GetComprobantesList(cmbTipoComprobante)

        'Me.cmbTipoComprobante.DataSource = ObtieneDatos("select 0 TipComp_Id,'--- Seleccione ---' TipComp_Nombre union Select TipComp_Id,TipComp_Nombre From TipoComprobantes Where Empresa = " & EmpresaActual).DefaultView
        'Me.cmbTipoComprobante.DisplayMember = "TipComp_Nombre"
        'Me.cmbTipoComprobante.ValueMember = "TipComp_Id"
        'Me.cmbTipoComprobante.SelectedIndex = 0

        'Me.cbCat.DataSource = ObtieneDatos("SELECT CUENTA, NOMBRE, CUENTA + ' - ' + NOMBRE Display From CATALOGO WHERE Tipo = 'A' AND EMPRESA = " & EmpresaActual).DefaultView
    End Sub

    'Private Function ComboMes() As Boolean

    '    Dim DT_cod As DataTable = ObtieneDatos("Select Cod_amortizacion From Amortizaciones Where Estado = 1 AND Nombre = " & cbNombre.EditValue & " AND Empresa = " & EmpresaActual)

    '    If DT_cod.Rows.Count > 0 Then

    '        Me.cmbmes.DataSource = ObtieneDatos("Select * From AmortizacionesDetalle Where Cod_amortizacion = " & DT_cod.Rows(0).Item(0) & " AND Contabilizar = 0 AND Empresa = " & EmpresaActual) 'dt.DefaultView
    '        Me.cmbmes.DisplayMember = "Mes"
    '        Me.cmbmes.ValueMember = "num_amortizacion"

    '        If Me.cmbmes.Items.Count = 0 Then
    '            MsgBox("No hay Meses pendientes de Amortizar", MsgBoxStyle.Information, "Contabilizar Amortización")
    '            ActualizarEstado()
    '            Return False
    '        Else
    '            Me.btnContab.Enabled = True
    '            Return True
    '        End If
    '    Else
    '        Me.cmbmes.DataSource = Nothing
    '        Me.btnContab.Enabled = False
    '        Return False
    '    End If
    'End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    'Private Sub CARGAR_MESES()

    '    If ComboMes() Then

    '        'DT_ROW = Nothing  'Limpiar tabla
    '        'DT_ROW = AmortizacionesDB.GetAmortizacionActual(Me.cbNombre.EditValue)

    '        'cmbTipoComprobante.EditValue = DT_ROW.Rows(0).Item("TipoCompr")
    '        'cbMoneda.EditValue = DT_ROW.Rows(0).Item("Moneda")
    '        ''
    '        'iGrid.DataSource = ObtieneDatos("_GetPlantilla_Amortiza " & Me.cbNombre.EditValue & "," & EmpresaActual)
    '        'etMonto.Text = CDbl(DT_ROW.Rows(0).Item("Monto_Amortizado")).ToString("n2")

    '        obj = db_Amortizaciones.Detalles(cbAmorizaciones.EditValue)

    '        cmbTipoComprobante.EditValue = obj.TipoCompr
    '        cbMoneda.EditValue = obj.Moneda
    '        etMonto.Text = obj.Monto_amortizado.ToString("n2")
    '        '
    '        Cargar()
    '    End If
    'End Sub

    Private Sub btnContab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContab.Click

        'If Me.cmbmes.SelectedIndex < 0 Then
        '    XtraMsg("Seleccione el Mes a contabilizar")
        '    Me.cmbmes.Focus()
        '    Exit Sub
        'End If

        If cbAmorizaciones.EditValue Is Nothing Then
            XtraMsg("Seleccione una Amortización!")
            cbAmorizaciones.Focus()
            Exit Sub
        End If
        '
        If cbMeses.EditValue Is Nothing Then
            XtraMsg("Seleccione el Mes a Amortizar!")
            cbMeses.Focus()
            Exit Sub
        End If

        If Me.cmbTipoComprobante.ItemIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Comprobante")
            Me.cmbTipoComprobante.Focus()
            Exit Sub
        End If

        If Me.txtConcepto.Text.Trim.Length = 0 Then
            XtraMsg("Describa el Concepto del Comprobante")
            Me.txtConcepto.Focus()
            Exit Sub
        End If

        If txtConsecutivo.Text.Trim.Length = 0 Then
            XtraMsg("Describa la Referencia/Consecutivo para este comprobante",
                    MessageBoxIcon.Warning)
            txtConsecutivo.Focus()
            Exit Sub
        End If

        'If Me.iVista.DataRowCount < 2 Then
        '    XtraMsg("Complete La Información en el Detalle del Comprobante", MessageBoxIcon.Warning)
        '    Exit Sub
        'End If

        If CDbl(iVista.Columns("Debitos").SummaryItem.SummaryValue) = 0 Then
            XtraMsg("Debe haber al menos una operación de Débito", MessageBoxIcon.Error)
            Exit Sub
        End If

        If CDbl(Me.iVista.Columns("Creditos").SummaryItem.SummaryValue) = 0 Then
            XtraMsg("Debe haber al menos una operación de Crédito", MessageBoxIcon.Error)
            Exit Sub
        End If

        If CDbl(Me.iVista.Columns("Debitos").SummaryItem.SummaryValue) <> CDbl(Me.iVista.Columns("Creditos").SummaryItem.SummaryValue) Then
            XtraMsg("El Débito y el Crédito no estan cuadrados", MessageBoxIcon.Error)
            Exit Sub
        End If

        '******** VERIFICAR DISTRIBUCION ***********************************
        For i As Integer = 0 To Me.iVista.DataRowCount - 1
            Dim CTemp As String = vbNullString
            Try
                CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
                                     + " CuentaContable = '" & Me.iVista.GetRowCellValue(i, "Cuenta") & "'" _
                                     + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)
            Catch ex As Exception
                CTemp = "xxx"
            End Try

            If CTemp <> "xxx" And CTemp <> vbNullString Then
                '
                If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
                    XtraMessageBox.Show("La Cuenta " & Me.iVista.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
                           "ó Verifique el Detalle de la Distribución.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If
        Next
        '******** FIN VERIFICAR DISTRIBUCION *****************************


        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(fecha.DateTime.Date) Then
            Exit Sub
        End If
        '---------------------------------------------------------------------

        If GUARDAR_COMPROBANTE() Then   'Guardar comprobante y detalle

            obj = db_Amortizaciones.Detalles(cbAmorizaciones.EditValue)

            Dim obj_dtl As New AmortizacionesDetalle
            Dim db_dtl As New db_AmortizacionesDetalle

            obj_dtl.Cod_amortizacion = obj.Cod_amortizacion
            obj_dtl.num_amortizacion = cbMeses.EditValue
            obj_dtl.Comp_No = Comp_No
            obj_dtl.Per_Id = Per_Id
            obj_dtl.Mes_Id = fecha.DateTime.Month

            db_dtl.UpdateEstado(obj_dtl)

            XtraMsg("El Comprobante para el mes Seleccionado ha Sido Contabilizado Correctamente.")

            txtConcepto.Text = ""
            SearchLookUp(cbAmorizaciones, db_CatalogoAmortizacion.ListarPendientes(0), "Nombre", "Codigo", 2, 3, 4, 6, 7, 8)
            CargarAmortizacion()

            'ActualizarMes() 'ACTUALIZAR MES AMORTIZADO
            'LimpiarDatos()
        End If
    End Sub

    Private Function GUARDAR_COMPROBANTE() As Boolean
        ''COMPROBANTE
        'Dim consulta As String = "INSERT INTO Comprobantes (Comp_No,[Empresa],[Comp_Tipo],[Comp_Fecha],[Comp_TasaCambio],[Comp_Concepto]," _
        '                    + " [Comp_Moneda],[Per_Id],[Deposito_ID],[Transferencia],[ChequeNombre],[Mes],[Pagara],[Ruc]," _
        '                    + " [Tipo],[Proveedor],[Factura],[Fecha_Pago],[Forma_Pago],[Comp])" _
        '                    + " VALUES (@CompNo,@Empresa ,@TipoComp ,@Fecha,@TasaCambio,@CompConcepto,@Moneda,@PerID,@Deposito,@Transferencia,@ChequeNombre," _
        '                    + " @Mes,@Pagara,@Ruc,@Tipo,@Proveedor,@Factura,@FechaPago,@FormaPago,@Comp)"


        Per_Id = PeriodosDB.Activo(fecha.DateTime.Date)

        '----------------------------------------------------------------------
        Dim conexion As New VB.SysContab.Rutinas
        DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()
        '----------------------------------------------------------------------

        Comp_No = ComprobanteDB.AddComprobante(
            cmbTipoComprobante.EditValue,
            TCambio,
            txtConcepto.Text.Trim,
            cbMoneda.EditValue,
            Per_Id,
            fecha.DateTime.Date,
            0,
            "",
            False,
            0,
            "",
            0,
            "Amortización No. " & cbAmorizaciones.EditValue.ToString(),
             VB.SysContab.Rutinas.Fecha,
            0,
            OrigenComprobantes.AMORTIZACION,
            "",
            0,
            0,
            txtConsecutivo.Text.Trim)

        'Dim NoComp As Double = Comprobante.AddComprobante(consulta, CInt(Me.cmbTipoComprobante.SelectedValue.ToString), 1, Me.txtConcepto.Text.Trim, _
        'DT_ROW.Rows(0).Item("Moneda").ToString, CInt(Comprobante.Activo(Me.fecha.DateTime.Date)), Me.fecha.DateTime.Date, "", "", False, 0, "", 0, 0, Me.fecha.DateTime.Date, 0, 0)

        Dim Cuenta As String = String.Empty
        Dim DC As String = String.Empty
        Dim Importe As Decimal = 0

        With iVista
            Try
                For i As Integer = 0 To .DataRowCount - 1
                    Cuenta = .GetRowCellValue(i, "Cuenta")

                    If .GetRowCellValue(i, "Debitos") > 0 Then
                        DC = "D"
                        Importe = .GetRowCellValue(i, "Debitos")
                    ElseIf .GetRowCellValue(i, "Creditos") > 0 Then
                        DC = "C"
                        Importe = .GetRowCellValue(i, "Creditos")
                    End If
                    '
                    ComprobanteDB.AddComprobanteDetalles(Comp_No,
                                                       Cuenta,
                                                       AmortizacionesDB.CATALOGO_CUENTA(Cuenta, 2),
                                                       Math.Round(Importe * TCambio, 2), 0,
                                                       cmbTipoComprobante.EditValue,
                                                       DC, 0, 0,
                                                       Me.fecha.DateTime.Date, 1)
                Next
                '

                VB.SysContab.Rutinas.okTransaccion()
                '
                '----------------------
                'Guarda la Distribucion
                '----------------------
                Dim DT_F As DataTable
                DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Deleted)
                If Not DT_F Is Nothing Then
                    For i As Integer = 0 To DT_F.Rows.Count - 1
                        With DT_F
                            If .Rows(i).RowState = DataRowState.Added Then
                                GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
                                " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & Comp_No & "," & Me.fecha.DateTime.Month & "," &
                                VB.SysContab.PeriodosDB.Activo(Me.fecha.DateTime) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") * TCambio & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
                            ElseIf .Rows(i).RowState = DataRowState.Modified Then
                                GuardaDatos("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & Comp_No & ",Mes=" & Me.fecha.DateTime.Month & "," &
                                "Per_Id = " & Per_Id & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") * TCambio & "," &
                                "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
                            ElseIf .Rows(i).RowState = DataRowState.Deleted Then
                            End If
                        End With
                    Next
                End If
                '
                Distribucion()
                '--------------------------
                'Fin de Guarda Distribucion
                '--------------------------
                '
                Return True
            Catch ex As Exception
                XtraMsg("Hacen Falta Datos Requeridos para Guardar el Comprobante, rebise y vuelva a Intentarlo", MessageBoxIcon.Error)
                Rutinas.ErrorTransaccion()
                Return False
            End Try
        End With
    End Function

    'Private Sub ActualizarMes()
    '    Dim sSQL As String = "UPDATE AmortizacionesDetalle SET Contabilizar = 1" _
    '        + " Where Cod_amortizacion = " & CInt(DT_ROW.Rows(0).Item("Cod_amortizacion").ToString) & " AND Mes = '" & Me.cmbmes.Text & "' AND Empresa = " & EmpresaActual

    '    If Not GuardaDatos(sSQL) Then
    '        XtraMsg("Error Inesperado, Consulte con el Administrador del Sistema", MessageBoxIcon.Error)
    '        Exit Sub
    '    End If

    '    XtraMsg("El Comprobante para el mes Seleccionado ha Sido Contabilizado Correctamente.")
    'End Sub

    'Private Sub ActualizarEstado()
    '    Try
    '        Dim sSQL As String = "UPDATE Amortizaciones SET Estado = 0" _
    '            + " Where Cod_amortizacion = " & CInt(DT_ROW.Rows(0).Item("Cod_amortizacion").ToString) & " AND Empresa = " & EmpresaActual

    '        If Not GuardaDatos(sSQL) Then
    '            XtraMsg("Error Inesperado, Consulte con el Administrador del Sistema", MessageBoxIcon.Error)
    '            Exit Sub
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub LimpiarDatos()
    '    Me.cmbmes.DataSource = Nothing
    '    Me.txtConcepto.Text = String.Empty
    '    Me.iGrid.DataSource = Nothing 'ObtieneDatos("SELECT '' CUENTA,0.00 Debitos,0.00 Creditos FROM CATALOGO WHERE 0=1")
    '    ' Me.cbNombre.ItemIndex = 0
    '    cbAmorizaciones.EditValue = Nothing
    '    cmbTipoComprobante.ItemIndex = 0
    '    FirthTime = 0
    '    Cargar()
    'End Sub

    Private Sub vCat_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles iVista.DoubleClick
        If Me.iVista.DataRowCount = 0 Then
            Exit Sub
        End If

        Try
            Dim forma As New FrmDetalleRequisas
            With Me.iVista
                forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
                If IsDBNull(.GetRowCellValue(.FocusedRowHandle, "Debitos")) OrElse IsNothing(.GetRowCellValue(.FocusedRowHandle, "Debitos")) OrElse .GetRowCellValue(.FocusedRowHandle, "Debitos") = Nothing OrElse .GetRowCellValue(.FocusedRowHandle, "Debitos") = 0 Then
                    forma.Monto = .GetRowCellValue(.FocusedRowHandle, "Creditos") '.Item(.CurrentRowIndex, 4)
                    forma.Tipo = "C"
                    forma.Periodo = Per_Id
                    forma.CompNo = Comp_No
                    forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta") '.Item(.CurrentRowIndex, 0)
                    forma.Mes = fecha.DateTime.Month
                Else
                    forma.Monto = .GetRowCellValue(.FocusedRowHandle, "Debitos") '.Item(.CurrentRowIndex, 3)
                    forma.Tipo = "D"
                    forma.Periodo = Per_Id
                    forma.CompNo = Comp_No
                    forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta") '.Item(.CurrentRowIndex, 0)
                    forma.Mes = fecha.DateTime.Month
                End If
                forma.Mostrar(DT_Distribucion)
                Me.DT_Distribucion.DefaultView.RowFilter = ""
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub vCat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles iVista.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.iVista.DeleteSelectedRows()
        End If
    End Sub


    Private Sub vCat_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged
        Try
            With Me.iVista

                If e.Column.FieldName = "Cuenta" Then
                    If IsDBNull(.GetRowCellValue(e.RowHandle, "Debitos")) Then
                        .SetRowCellValue(e.RowHandle, "Debitos", 0.0)
                    End If

                    If IsDBNull(.GetRowCellValue(e.RowHandle, "Creditos")) Then
                        .SetRowCellValue(e.RowHandle, "Creditos", 0.0)
                    End If
                End If

                If e.Column.FieldName = "Debitos" Then
                    If .GetRowCellValue(e.RowHandle, "Debitos") > 0 Then
                        .SetRowCellValue(e.RowHandle, "Creditos", 0.0)
                    End If
                End If

                If e.Column.FieldName = "Creditos" Then
                    If .GetRowCellValue(e.RowHandle, "Creditos") > 0 Then
                        .SetRowCellValue(e.RowHandle, "Debitos", 0.0)
                    End If
                End If

                .UpdateTotalSummary()

            End With
        Catch ex As Exception
        End Try
    End Sub

    'Private Sub cbNombre_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.cbNombre.ItemIndex > 0 Then
    '        CARGAR_MESES()
    '    Else
    '        Me.btnContab.Enabled = False
    '        Me.etMonto.Text = "0.00"
    '    End If
    'End Sub

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


    Private Sub cbAmorizaciones_EditValueChanged(sender As Object, e As EventArgs) Handles cbAmorizaciones.EditValueChanged
        CargarAmortizacion()
    End Sub

    Sub CargarAmortizacion()

        obj = db_Amortizaciones.Detalles(IIf(cbAmorizaciones.EditValue Is Nothing, 0, cbAmorizaciones.EditValue))

        If Not obj Is Nothing Then

            cmbTipoComprobante.EditValue = obj.TipoCompr
            cbMoneda.EditValue = obj.Moneda
            etMonto.Text = obj.Monto_amortizado.ToString("n2")
            '
            Dim DT_MES As DataTable = db_Amortizaciones.MesesPendientes(obj.Cod_amortizacion)
            LookUp(cbMeses, DT_MES, "Nombre", "Numero", "[Seleccione Mes]", 0)
            cbMeses.ItemIndex = 0

            If DT_MES.Rows.Count > 0 Then
                fecha.DateTime = cbMeses.GetColumnValue("Fecha")
                btnContab.Enabled = True
                Cargar()
            End If

            If DT_MES.Rows.Count = 0 Then
                iGrid.DataSource = db_Amortizaciones.Plantilla(0)
                btnContab.Enabled = False
                etMonto.Text = "0.00"
            End If
        Else
            btnContab.Enabled = False
            etMonto.Text = "0.00"
        End If

    End Sub

    Private Sub cbMeses_EditValueChanged(sender As Object, e As EventArgs) Handles cbMeses.EditValueChanged
        If cbMeses.EditValue Is Nothing Then Exit Sub

        fecha.DateTime = cbMeses.GetColumnValue("Fecha")
    End Sub

    Private Sub fecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.EditValueChanged
        Try
            GetTasa()
        Catch ex As Exception
            txtTasa.EditValue = 1.0
        End Try
    End Sub
End Class