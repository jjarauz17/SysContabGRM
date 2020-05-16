Imports System.Data.SqlClient
Imports ClasesBLL
Imports DevExpress.XtraGrid.Views.Base

Public Class frmAnticiposClienteAdd

    Public IdAnticipo As Integer = 0, NoComp As Double = 0
    Private DT_Distribucion As DataTable = New DataTable("Distribucion")
    Dim DT As New DataTable

    Dim obj As New AnticiposClientes, obj_dtl As New AnticiposClientesDetalle
    Dim db As New db_AnticiposClientes, db_dtl As New db_AnticiposClientesDetalle

    Private Sub frmRemisionesContabilizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        DT_Distribucion = CargaDistribucion(0, 0, 0)
        '
        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        CargarCombos()
        CargarCatalogo()
        '
        CargarDetalle()
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False, True, False)

        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("IdAnticipo").Visible = False

        iVista.Columns("Cuenta").ColumnEdit = cbCatalogo
        iVista.Columns("Debito").ColumnEdit = txtMonto
        iVista.Columns("Credito").ColumnEdit = txtMonto

        txtTasa.EditValue = GetTasaCambioDia(Fecha.DateTime.Date)

        If IdAnticipo = 0 Then NoAnticipo.Text = db_AnticiposClientes.GetNumero()
        If IdAnticipo <> 0 Then MostrarDatos()
    End Sub

    Sub CargarDetalle()
        DT = db_AnticiposClientesDetalle.Listar(IdAnticipo)
        iGrid.DataSource = DT
    End Sub

    Sub CargarCatalogo()
        RepositorySearchLook(cbCatalogo,
                             ObtieneDatos(IIf(IdAnticipo = 0, "_GetCatalogo_CuentaActivo", "_GetCatalogo_Cuenta"), EmpresaActual), "Display", "Cuenta", 2)
    End Sub

    Sub CargarCombos()
        SearchLookUp(cbCaja, VB.SysContab.CatalogoDB.CatalogoList("A", 1).Tables("CATALOGO"), "Nombre2", "Cuenta", 2, 3)
        SearchLookUp(cbCliente, VB.SysContab.ClientesDB.GetList(1).Tables("CLIENTES"), "Nombre", "Codigo", 3, 4, 5, 6, 7, 8)

        GetVendedores(cbAsesor, 1)
        cbAsesor.ItemIndex = 0

        GetTipoComprobantesList(cbTipo, 1)
        '
        cbTipo.ItemIndex = 0
        cbCaja.EditValue = "0"
        '
        Combo(cbBanco, db_BancosCK.Listar(), "[Seleccione Banco]")
        GetMonedasList(cbMoneda)
    End Sub

    Sub MostrarDatos()
        obj = db_AnticiposClientes.Detalles(IdAnticipo)

        If Not obj Is Nothing Then
            cbCaja.EditValue = obj.Caja
            NoAnticipo.Text = obj.Numero
            cbCliente.EditValue = obj.IdCliente
            Fecha.DateTime = obj.Fecha
            FormaPago.EditValue = obj.FormaPago
            NoRecibo.Text = obj.NoRecibo
            NoCheque.Text = obj.NoCheque
            Referencia.Text = obj.Referencia
            Concepto.Text = obj.Concepto
            cbBanco.EditValue = obj.Banco
            cbTipo.EditValue = obj.TipoComprobante
            cbMoneda.EditValue = obj.Moneda
            txtTasa.EditValue = obj.TCambio
            cbAsesor.EditValue = obj.Vendedor

            NoComp = obj.Comp_No
            DT_Distribucion = CargaDistribucion(obj.Mes, obj.Comp_No, obj.Per_Id)
            TotalAnticipo()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(Fecha.DateTime.Date) Then
            Exit Sub
        End If
        '---------------------------------------------------------------------
        '
        If cbCaja.EditValue = "0" Then
            XtraMsg("Seleccione la Cuenta de Caja/Banco")
            cbCaja.Focus()
            Exit Sub
        End If

        If cbCliente.EditValue Is Nothing Then
            XtraMsg("Seleccione el Cliente")
            cbCliente.Focus()
            Exit Sub
        End If

        If cbTipo.ItemIndex = 0 Then
            XtraMsg("Seleccione el Tipo de Comprobante")
            cbTipo.Focus()
            Exit Sub
        End If

        If iVista.DataRowCount = 0 Then
            XtraMsg("Debe ingresar al menos 1 linea en el Detalle del Anticipo", MessageBoxIcon.Error)
            Exit Sub
        End If

        'Dim Monto As Double = CDbl(iVista.Columns("Credito").SummaryItem.SummaryValue) - CDbl(iVista.Columns("Debito").SummaryItem.SummaryValue)

        Dim Monto As Double = CDbl(iVista.Columns("Credito").SummaryItem.SummaryValue)
        Dim NetoAnticipo As Double = CDbl(iVista.Columns("Credito").SummaryItem.SummaryValue) - CDbl(iVista.Columns("Debito").SummaryItem.SummaryValue)

        If Monto <= 0 Then
            XtraMsg("El Monto del Anticipo debe ser Mayor que Cero (0), Anticipo = " & Monto.ToString("n2"), MessageBoxIcon.Warning)
            Exit Sub
        End If

        '
        'If CDbl(iVista.Columns("Debito").SummaryItem.SummaryValue) <> CDbl(iVista.Columns("Credito").SummaryItem.SummaryValue) Then
        '    XtraMsg("El Débito y el Crédito no estan cuadrados", MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        '
        ''******** VERIFICAR DISTRIBUCION ***********************************
        'For i As Integer = 0 To iVista.DataRowCount - 1
        '    Dim CTemp As String = vbNullString
        '    Try
        '        CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
        '                             + " CuentaContable = '" & iVista.GetRowCellValue(i, "Cuenta") & "'" _
        '                             + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)
        '    Catch ex As Exception
        '        CTemp = "xxx"
        '    End Try

        '    If CTemp <> "xxx" And CTemp <> vbNullString Then
        '        '
        '        If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
        '            XtraMsg("La Cuenta " & iVista.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
        '                   "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
        '            Exit Sub
        '        End If
        '    End If
        'Next
        ''******** FIN VERIFICAR DISTRIBUCION **********************************************
        '
        Dim Per_Id As Integer = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date)

        obj.IdAnticipo = IdAnticipo
        obj.Numero = NoAnticipo.Text
        obj.IdCliente = cbCliente.EditValue
        obj.Caja = cbCaja.EditValue
        obj.NoRecibo = NoRecibo.Text
        obj.NoCheque = NoCheque.Text
        obj.Referencia = Referencia.Text
        'obj.Fecha = Fecha.DateTime.Date
        obj.TipoComprobante = cbTipo.EditValue
        obj.FormaPago = FormaPago.EditValue
        obj.Banco = IIf(cbBanco.EditValue Is Nothing, 0, cbBanco.EditValue)
        obj.Moneda = cbMoneda.EditValue
        obj.TCambio = txtTasa.EditValue
        obj.Monto = NetoAnticipo
        obj.Concepto = Concepto.Text
        obj.Per_Id = Per_Id
        obj.Mes = Fecha.DateTime.Month
        obj.IdNota = 0
        obj.Vendedor = cbAsesor.EditValue

        If IdAnticipo = 0 Then
            ShowSplash("Guardando Anticipo...")

            'Guardar Comprobante
            If GuardarComprobante(Per_Id, NetoAnticipo) Then
                'GuardarDistribucion(NoComp, Per_Id)

                obj.Fecha = Fecha.DateTime.Date
                obj.Comp_No = NoComp

                IdAnticipo = db.Insertar(obj)
                '
                Dim _DT As DataTable = DT.GetChanges(DataRowState.Added Or DataRowState.Modified)

                If Not _DT Is Nothing Then
                    For i As Integer = 0 To _DT.Rows.Count - 1
                        obj_dtl.IdAnticipo = IdAnticipo
                        obj_dtl.Cuenta = IsNull(_DT.Rows.Item(i)("Cuenta"), "")
                        obj_dtl.Debito = IsNull(_DT.Rows.Item(i)("Debito"), 0.00)
                        obj_dtl.Credito = IsNull(_DT.Rows.Item(i)("Credito"), 0.00)
                        obj_dtl.Concepto = IsNull(_DT.Rows.Item(i)("Concepto"), "")

                        db_dtl.Insertar(obj_dtl)
                    Next
                End If

                HideSplash()

                XtraMsg("El Anticipo No. " + db_AnticiposClientes.Detalles(IdAnticipo).Numero + " se ha creado con exito!")

                'ShowSplash("Imprimiendo...")
                VB.SysContab.ComprobanteDB.ImprimirComprobante(NoComp, Per_Id, Fecha.DateTime)
                ' HideSplash()

                Close()
                If frmAnticiposCliente.Created Then frmAnticiposCliente.Cargar()
            End If
        Else
            ShowSplash("Actualizando Anticipo...")
            'Verificar si la modificacion incluye Cambio de Fecha a otro mes.
            If Fecha.DateTime.Year = CDate(obj.Fecha).Year Then
                If Fecha.DateTime.Month <> CDate(obj.Fecha).Month Then
                    'Se anula el comprobante actual
                    If Not AnularComprobante() Then Exit Sub
                    'Eliminar Distribucion Actual
                    'EliminaDistribucion(obj.Comp_No, obj.Per_Id, obj.Mes)
                    'Guardar Nuevo Comprobante
                    If Not GuardarComprobante(Per_Id, NetoAnticipo) Then Exit Sub
                    '
                    obj.Fecha = Fecha.DateTime.Date
                    obj.Comp_No = NoComp
                    'Guardar la Distribucion
                    'GuardarDistribucion(NoComp, Per_Id)
                Else
                    '----------------------------------------------------------------------
                    Dim conexion As New VB.SysContab.Rutinas
                    DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
                    DBConnFacturas.Open()
                    transaccionFacturas = DBConnFacturas.BeginTransaction()
                    '---------------------------------------------------------------------- 

                    Dim Cuenta As String = "", DC As String = "", Importe As Double = 0.00, TCambio As Double = 1.0
                    If MonedaBase <> cbMoneda.EditValue Then TCambio = txtTasa.EditValue


                    Try
                        VB.SysContab.ComprobanteDB.ComprobanteUpdate(obj.Comp_No, cbTipo.EditValue, txtTasa.EditValue, Concepto.Text, cbMoneda.EditValue,
                                                                obj.Per_Id, Fecha.DateTime.Date, "", False, CDate(obj.Fecha).Date, "",
                                                                "", 0, Referencia.Text, Fecha.DateTime.Date, 0, 0)

                        VB.SysContab.ComprobanteDB.BorrarDetalleComprobante(obj.Comp_No, obj.Per_Id, obj.Mes)
                        '                        
                        'Cargar Monto en Caja/Banco
                        VB.SysContab.ComprobanteDB.AddComprobanteDetalles(obj.Comp_No, cbCaja.EditValue, cbCliente.Text,
                                                        Math.Round(NetoAnticipo * TCambio, 2), NoCheque.Text, cbTipo.EditValue, "D", 0, NoRecibo.Text,
                                                        Fecha.DateTime.Date, 1)



                        'Guardar Detalle del Comprobante
                        With iVista
                            For i As Integer = 0 To .DataRowCount - 1
                                Cuenta = IsNull(.GetRowCellValue(i, "Cuenta"), "")

                                If Cuenta = "" Then
                                    XtraMsg("La cuenta Contable no puede ser vacia.", MessageBoxIcon.Error)
                                    VB.SysContab.Rutinas.ErrorTransaccion()
                                    HideSplash()
                                    Exit Sub
                                End If

                                If IsNull(.GetRowCellValue(i, "Debito"), 0.00) > 0 Then
                                    DC = "D"
                                    Importe = IsNull(.GetRowCellValue(i, "Debito"), 0.00)
                                ElseIf IsNull(.GetRowCellValue(i, "Credito"), 0.00) > 0 Then
                                    DC = "C"
                                    Importe = IsNull(.GetRowCellValue(i, "Credito"), 0.00)
                                End If

                                VB.SysContab.ComprobanteDB.AddComprobanteDetalles(obj.Comp_No, Cuenta, IsNull(.GetRowCellValue(i, "Concepto"), ""),
                                                                Math.Round(Importe * TCambio, 2), 0, cbTipo.EditValue, DC, 0, NoRecibo.Text,
                                                                Fecha.DateTime.Date, 1)
                            Next
                        End With
                        '
                        VB.SysContab.Rutinas.okTransaccion()
                        '
                        'Eliminar Distribucion
                        EliminaDistribucion(obj.Comp_No, obj.Per_Id, obj.Mes)
                        'Guardar Distribucion
                        'GuardarDistribucion(obj.Comp_No, obj.Per_Id)
                    Catch ex As Exception
                        VB.SysContab.Rutinas.ErrorTransaccion()
                        XtraMsg(ex.Message, MessageBoxIcon.Error)
                        HideSplash()
                        Exit Sub
                    End Try
                End If
            Else
                'Se anula el comprobante actual
                If Not AnularComprobante() Then Exit Sub
                'Eliminar Distribucion Actual
                ' EliminaDistribucion(obj.Comp_No, obj.Per_Id, obj.Mes)
                'Guardar Nuevo Comprobante
                If Not GuardarComprobante(Per_Id, NetoAnticipo) Then Exit Sub
                '
                obj.Fecha = Fecha.DateTime.Date
                obj.Comp_No = NoComp
                'Guardar la Distribucion
                'GuardarDistribucion(NoComp, Per_Id)
            End If
            '
            db.Actualizar(obj)
            '
            db_AnticiposClientes.BorrarDetalle(IdAnticipo)
            '
            Dim _DT = DT.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Unchanged)
            For i As Integer = 0 To _DT.Rows.Count - 1

                obj_dtl.IdAnticipo = IdAnticipo
                obj_dtl.Cuenta = IsNull(_DT.Rows.Item(i)("Cuenta"), "")
                obj_dtl.Debito = IsNull(_DT.Rows.Item(i)("Debito"), 0.00)
                obj_dtl.Credito = IsNull(_DT.Rows.Item(i)("Credito"), 0.00)
                obj_dtl.Concepto = IsNull(_DT.Rows.Item(i)("Concepto"), "")

                db_dtl.Insertar(obj_dtl)
            Next
            '
            HideSplash()
            XtraMsg("Los Cambios Solicitados han sido actualizados con exito!")
            '
            Close()
            If frmAnticiposCliente.Created Then frmAnticiposCliente.Cargar()
        End If
    End Sub

    Function GuardarComprobante(Per_Id As Integer, Monto As Double) As Boolean

        'Guardar Comprobante
        Try
            '----------------------------------------------------------------------
            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()
            '----------------------------------------------------------------------    

            Dim Cuenta As String = "", DC As String = "", Importe As Double = 0.00, TCambio As Double = 1.0

            If MonedaBase <> cbMoneda.EditValue Then TCambio = txtTasa.EditValue

            NoComp =
            VB.SysContab.ComprobanteDB.AddComprobante(cbTipo.EditValue, txtTasa.EditValue, Concepto.Text,
                                   cbMoneda.EditValue, Per_Id,
                                   Fecha.DateTime.Date, 0, "", False, 0, "", 0, Referencia.Text, VB.SysContab.Rutinas.Fecha(),
                                   0, OrigenComprobantes.ANTICIPO_CLIENTES, "", 0, 0, "0")


            'Cargar Monto en Caja/Banco
            VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComp, cbCaja.EditValue, cbCliente.Text,
                                                        Math.Round(Monto * TCambio, 2), NoCheque.Text, cbTipo.EditValue, "D", 0, NoRecibo.Text,
                                                        Fecha.DateTime.Date, 1)

            With iVista
                Try
                    For i As Integer = 0 To .DataRowCount - 1
                        Cuenta = IsNull(.GetRowCellValue(i, "Cuenta"), "")

                        If Cuenta = "" Then
                            XtraMsg("La cuenta Contable no puede ser vacia.", MessageBoxIcon.Error)
                            VB.SysContab.Rutinas.ErrorTransaccion()
                            HideSplash()
                            Return False
                        End If

                        If IsNull(.GetRowCellValue(i, "Debito"), 0.00) > 0 Then
                            DC = "D"
                            Importe = IsNull(.GetRowCellValue(i, "Debito"), 0.00)
                        ElseIf IsNull(.GetRowCellValue(i, "Credito"), 0.00) > 0 Then
                            DC = "C"
                            Importe = IsNull(.GetRowCellValue(i, "Credito"), 0.00)
                        End If

                        VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComp, Cuenta, IsNull(.GetRowCellValue(i, "Concepto"), ""),
                                                        Math.Round(Importe * TCambio, 2), 0, cbTipo.EditValue, DC, 0, NoRecibo.Text,
                                                        Fecha.DateTime.Date, 1)
                    Next
                Catch ex As Exception
                    XtraMsg("Error al Contabilizar: " & ex.Message, MessageBoxIcon.Error)
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    HideSplash()
                    Return False
                End Try
            End With
            '
            VB.SysContab.Rutinas.okTransaccion()

            Return True
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            HideSplash()
            Return False
        End Try

    End Function

    Function AnularComprobante() As Boolean
        '----------------------------------------------------------------------
        Dim conexion As New VB.SysContab.Rutinas
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()
        '----------------------------------------------------------------------  

        Try
            VB.SysContab.ComprobanteDB.ComprobanteAnular(obj.Comp_No, obj.Per_Id, obj.Fecha)
            VB.SysContab.Rutinas.okTransaccion()

            Return True
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    'Sub GuardarDistribucion(Comp_No As Integer, Per_Id As Integer)
    '    '------------------------
    '    'Guarda la Distribucion
    '    '------------------------
    '    Dim DT_F As DataTable
    '    DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Deleted Or DataRowState.Unchanged)
    '    If Not DT_F Is Nothing Then
    '        For i = 0 To DT_F.Rows.Count - 1
    '            With DT_F
    '                'GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
    '                '    " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & NoComp & "," & Fecha.DateTime.Month & "," &
    '                '    Per_Id & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")

    '                If .Rows(i).RowState = DataRowState.Added Then
    '                    GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
    '                    " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & NoComp & "," & Fecha.DateTime.Month & "," &
    '                    Per_Id & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
    '                ElseIf .Rows(i).RowState = DataRowState.Modified Then
    '                    GuardaDatos("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & NoComp & ",Mes=" & Fecha.DateTime.Month & "," &
    '                    "Per_Id = " & Per_Id & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," &
    '                    "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
    '                ElseIf .Rows(i).RowState = DataRowState.Deleted Then
    '                End If

    '            End With
    '        Next
    '    End If
    '    '----------------------------
    '    'Fin de Guarda Distribucion
    '    '----------------------------
    'End Sub

    'Private Function VerificaDistribucion(ByVal Cuenta As String) As Boolean
    '    Dim tmp As Boolean = False

    '    If DT_Distribucion Is Nothing Then
    '        Return False
    '    End If

    '    For i As Integer = 0 To DT_Distribucion.Rows.Count - 1
    '        If Cuenta = DT_Distribucion.Rows(i).Item("Cuenta") Then
    '            tmp = True
    '            Exit For
    '        End If
    '    Next

    '    Return tmp
    'End Function

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        'If iVista.DataRowCount = 0 Then
        '    Exit Sub
        'End If
        ''
        'Try
        '    Dim frm As New FrmDetalleRequisas
        '    With iVista
        '        frm.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
        '        If IsDBNull(.GetRowCellValue(.FocusedRowHandle, "Debito")) OrElse IsNothing(.GetRowCellValue(.FocusedRowHandle, "Debito")) OrElse .GetRowCellValue(.FocusedRowHandle, "Debito") = Nothing OrElse .GetRowCellValue(.FocusedRowHandle, "Debito") = 0 Then
        '            frm.Monto = .GetRowCellValue(.FocusedRowHandle, "Credito")
        '            frm.Tipo = "C"
        '            frm.Periodo = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime)
        '            frm.CompNo = NoComp
        '            frm.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
        '            frm.Mes = Fecha.DateTime.Month
        '        Else
        '            frm.Monto = .GetRowCellValue(.FocusedRowHandle, "Debito")
        '            frm.Tipo = "D"
        '            frm.Periodo = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime)
        '            frm.CompNo = NoComp
        '            frm.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
        '            frm.Mes = Fecha.DateTime.Month
        '        End If
        '        frm.Mostrar(DT_Distribucion)
        '        DT_Distribucion.DefaultView.RowFilter = ""
        '    End With

        'Catch ex As Exception
        '    XtraMsg(ex.Message, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub iVista_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If iVista.DataRowCount = 0 Then Exit Sub
        If e.KeyCode = Keys.Delete Then iVista.DeleteSelectedRows()
    End Sub

    Private Sub txtTasa_EditValueChanged(sender As Object, e As EventArgs) Handles txtTasa.EditValueChanged
        If Not Inicio Then TotalAnticipo()
    End Sub

    Private Sub cbMoneda_EditValueChanged(sender As Object, e As EventArgs) Handles cbMoneda.EditValueChanged
        If Not Inicio Then TotalAnticipo()
    End Sub

    Private Sub Fecha_EditValueChanged(sender As Object, e As EventArgs) Handles Fecha.EditValueChanged
        If Not Inicio Then txtTasa.EditValue = GetTasaCambioDia(Fecha.DateTime.Date)
    End Sub

    Private Sub iVista_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles iVista.RowUpdated
        CargarCatalogo()
        TotalAnticipo()
    End Sub

    Sub TotalAnticipo()
        'If Inicio Then Exit Sub

        iVista.RefreshData()
        Dim Monto As Double = CDbl(iVista.Columns("Credito").SummaryItem.SummaryValue) - CDbl(iVista.Columns("Debito").SummaryItem.SummaryValue)

        lblTotal.Text = "Total Anticipo " & cbMoneda.GetColumnValue("Simbolo") & ": " + Monto.ToString("n2")
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles iVista.CellValueChanged

    End Sub
End Class