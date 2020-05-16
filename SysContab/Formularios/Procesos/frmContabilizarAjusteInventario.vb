Imports System.Data
Imports System.Data.SqlClient

Public Class frmContabilizarAjusteInventario

    Public Desde As Date, Hasta As Date
    Private DT_Distribucion As DataTable = New DataTable("Distribucion")

    Dim NoComprob As Double = 0
    Private DetalleEmpresa As New VB.SysContab.EmpresasDetails

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Verificar Cierre del Día
        '-----------------------------------------------------------------
        If Not VerificarCierre(Fecha.DateTime.Date) Then
            Exit Sub
        End If
        '------------------------------------------------------------------

        If cbTipoComp.EditValue Is Nothing Then
            XtraMsg("Seleccione Tipo de Comprobante!")
            cbTipoComp.Focus()
            Exit Sub
        End If
        '
        vComprobante.UpdateTotalSummary()
        vComprobante.RefreshData()
        '
        If CDbl(Me.vComprobante.Columns("Debito").SummaryItem.SummaryValue) = 0 Then
            XtraMsg("Debe haber al menos una operación de Débito", MessageBoxIcon.Error)
            Exit Sub
        End If

        If CDbl(Me.vComprobante.Columns("Credito").SummaryItem.SummaryValue) = 0 Then
            XtraMsg("Debe haber al menos una operación de Crédito", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Math.Round(CDbl(Me.vComprobante.Columns("Debito").SummaryItem.SummaryValue), 2) <> Math.Round(CDbl(Me.vComprobante.Columns("Credito").SummaryItem.SummaryValue), 2) Then
            XtraMsg("El Débito y el Crédito NO estan cuadrados", MessageBoxIcon.Error)
            Exit Sub
        End If

        If Me.txtConcepto.Text.Trim.Length = 0 Then
            XtraMsg("Describa el Concepto del Comprobante")
            txtConcepto.Focus()
            Exit Sub
        End If
        '

        '******** VERIFICAR DISTRIBUCION ***********************************
        For i As Integer = 0 To Me.vComprobante.DataRowCount - 1
            Dim CTemp As String = vbNullString
            Try
                CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
                                     + " CuentaContable = '" & vComprobante.GetRowCellValue(i, "Cuenta") & "'" _
                                     + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)
            Catch ex As Exception
                CTemp = "xxx"
            End Try

            If CTemp <> "xxx" And CTemp <> vbNullString Then
                '
                If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
                    XtraMsg("La Cuenta " & Me.vComprobante.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf & _
                           "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
        Next
        '******** FIN VERIFICAR DISTRIBUCION *****************************


        Dim Cuenta As String = String.Empty
        Dim DC As String = String.Empty
        Dim Importe As Decimal = 0
        Dim TCambio As Double = 1

        DetalleEmpresa = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        '----------------------------------------------------------------------
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()
        '----------------------------------------------------------------------

        Try
            NoComprob = _
            VB.SysContab.ComprobanteDB.AddComprobante(Me.cbTipoComp.EditValue, TCambio, txtConcepto.Text, _
                                        DetalleEmpresa.MonedaBase, VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date), _
                                        Fecha.DateTime.Date, 0, "", False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, _
                                        0, OrigenComprobantes.NATURAL)

            With Me.vComprobante
                Try
                    For i As Integer = 0 To .DataRowCount - 1
                        Cuenta = .GetRowCellValue(i, "Cuenta")

                        If .GetRowCellValue(i, "Debito") > 0 Then
                            DC = "D"
                            Importe = .GetRowCellValue(i, "Debito") * TCambio
                        ElseIf .GetRowCellValue(i, "Credito") > 0 Then
                            DC = "C"
                            Importe = .GetRowCellValue(i, "Credito") * TCambio
                        End If

                        VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, Cuenta, .GetRowCellValue(i, "Concepto").ToString, _
                                                                          Math.Round(Importe, 2), 0, Me.cbTipoComp.EditValue, DC, 0, 0, _
                                                                          Me.Fecha.DateTime.Date, 1)
                    Next

                Catch ex As Exception
                    XtraMsg("Hacen Falta Datos Requeridos para Guardar el Comprobante, rebise y vuelva a Intentarlo." & vbCrLf & _
                            "Erro: " & ex.Message, MessageBoxIcon.Error)
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    Exit Sub
                End Try
            End With


            '----------------------
            'Guarda la Distribucion
            '----------------------
            Dim DT_F As DataTable
            DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Deleted)
            If Not DT_F Is Nothing Then
                For i As Integer = 0 To DT_F.Rows.Count - 1
                    With DT_F
                        If .Rows(i).RowState = DataRowState.Added Then
                            GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " & _
                            " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & NoComprob & "," & Me.Fecha.DateTime.Month & "," & _
                            VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
                        ElseIf .Rows(i).RowState = DataRowState.Modified Then
                            GuardaDatos("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & NoComprob & ",Mes=" & Me.Fecha.DateTime.Month & "," & _
                            "Per_Id = " & VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," & _
                            "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
                        ElseIf .Rows(i).RowState = DataRowState.Deleted Then
                        End If
                    End With
                Next
            End If

            CargaDistribucion(0, 0, 0)
            '--------------------------
            'Fin de Guarda Distribucion
            '--------------------------

            VB.SysContab.Rutinas.okTransaccion()

            XtraMsg("Comprobante Guardado con Exito!")
            Close()
        Catch Mensaje As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            'SetTiempos(OrigenComprobantes.NATURAL, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Error1, NoComprob)
            XtraMsg(Mensaje.Message, MessageBoxIcon.Error)
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

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub frmContabilizarAjusteInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DT_Distribucion = CargaDistribucion(0, 0, 0)
        GetTipoComprobantesList(cbTipoComp)
        Cargar()
    End Sub

    Sub Cargar()
        cbCatalogo.DataSource = ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual)
        cbCatalogo.ValueMember = "Cuenta"
        cbCatalogo.DisplayMember = "Display"
        cbCatalogo.PopulateViewColumns()
        FormatoGrid(irVista)
        irVista.Columns("Display").Visible = False
        cbCatalogo.PopupFormSize = New Point(900, 0)
        '
        iGrid.DataSource = ObtieneDatos("SET DATEFORMAT dmy; EXEC jar_GetAjusteInventario '" & Desde.Date & "','" & Hasta.Date & "',0," & EmpresaActual)
        vComprobante.PopulateColumns()
        FormatoGrid(vComprobante)
        '
        vComprobante.Columns("Cuenta").ColumnEdit = cbCatalogo
        vComprobante.Columns("Debito").ColumnEdit = txtMonto
        vComprobante.Columns("Credito").ColumnEdit = txtMonto
        vComprobante.Columns("Cuenta").Width = 200
        vComprobante.Columns("Concepto").Width = 300
        '
        vComprobante.Columns("Debito").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vComprobante.Columns("Debito").DisplayFormat.FormatString = "{0:n2}"
        vComprobante.Columns("Debito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        vComprobante.Columns("Debito").SummaryItem.DisplayFormat = "{0:n2}"

        vComprobante.Columns("Credito").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vComprobante.Columns("Credito").DisplayFormat.FormatString = "{0:n2}"
        vComprobante.Columns("Credito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        vComprobante.Columns("Credito").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    Private Sub vComprobante_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vComprobante.CellValueChanged
        Try
            With Me.vComprobante

                If e.Column.FieldName = "Cuenta" Then
                    If IsDBNull(.GetRowCellValue(e.RowHandle, "Debito")) Then
                        .SetRowCellValue(e.RowHandle, "Debito", 0.0)
                    End If

                    If IsDBNull(.GetRowCellValue(e.RowHandle, "Credito")) Then
                        .SetRowCellValue(e.RowHandle, "Credito", 0.0)
                    End If
                End If

                If e.Column.FieldName = "Debito" Then
                    If .GetRowCellValue(e.RowHandle, "Debito") > 0 Then
                        .SetRowCellValue(e.RowHandle, "Credito", 0.0)
                    End If
                End If

                If e.Column.FieldName = "Credito" Then
                    If .GetRowCellValue(e.RowHandle, "Credito") > 0 Then
                        .SetRowCellValue(e.RowHandle, "Debito", 0.0)
                    End If
                End If

                .UpdateTotalSummary()

                ' Calcular()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub vComprobante_DoubleClick(sender As Object, e As EventArgs) Handles vComprobante.DoubleClick
        If vComprobante.DataRowCount = 0 Then
            Exit Sub
        End If

        Try
            Dim forma As New FrmDetalleRequisas
            With vComprobante
                forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
                If IsDBNull(.GetRowCellValue(.FocusedRowHandle, "Debito")) OrElse IsNothing(.GetRowCellValue(.FocusedRowHandle, "Debito")) OrElse .GetRowCellValue(.FocusedRowHandle, "Debito") = Nothing OrElse .GetRowCellValue(.FocusedRowHandle, "Debito") = 0 Then
                    forma.Monto = .GetRowCellValue(.FocusedRowHandle, "Credito") '.Item(.CurrentRowIndex, 4)
                    forma.Tipo = "C"
                    forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date)
                    forma.CompNo = NoComprob
                    forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta") '.Item(.CurrentRowIndex, 0)
                    forma.Mes = Fecha.DateTime.Month
                Else
                    forma.Monto = .GetRowCellValue(.FocusedRowHandle, "Debito") '.Item(.CurrentRowIndex, 3)
                    forma.Tipo = "D"
                    forma.Periodo = VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime)
                    forma.CompNo = NoComprob
                    forma.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta") '.Item(.CurrentRowIndex, 0)
                    forma.Mes = Fecha.DateTime.Month
                End If
                forma.Mostrar(DT_Distribucion)
                Me.DT_Distribucion.DefaultView.RowFilter = ""
            End With
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub vComprobante_KeyDown(sender As Object, e As KeyEventArgs) Handles vComprobante.KeyDown
        If Me.vComprobante.DataRowCount = 0 Then
            Exit Sub
        End If

        If e.KeyCode = Keys.Delete Then
            Me.vComprobante.DeleteSelectedRows()
            vComprobante.UpdateTotalSummary()
            vComprobante.RefreshData()

            ' Calcular()
        End If
    End Sub
End Class