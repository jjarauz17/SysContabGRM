Imports System.Data
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab

Public Class frmDepositosContabilizar

    Public IdDetalle As Integer
    Public Monto As Double
    Public Concepto As String
    Public TCambio As Double

    Public CuentaD As String, CuentaC As String, TipoCOmpr As Integer, HojaDeposito As String, Documento As String, Ok As String

    Private Sub frmDeshacerCuentaOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()

        'Me.Fecha.DateTime = Rutinas.Fecha()        
        GetComprobantesList(Me.cbTipoComp)
        Me.cbTipoComp.EditValue = TipoCOmpr

        GetTasa()

        Me.cbCatalogo.DataSource = ObtieneDatos("_GetCatalogo_Cuenta " & EmpresaActual)
        Me.cbCatalogo.ValueMember = "Cuenta"
        Me.cbCatalogo.DisplayMember = "Display"
        FormatoGrid(Me.vCat)
        Me.vCat.Columns("Display").Visible = False

        Me.gridDatos.DataSource = ObtieneDatos("sp_GetComprobanteDeposito '" & CuentaD & "','" & CuentaC & "'," & Monto & "")
        Me.vComprobante.PopulateColumns()
        FormatoGrid(Me.vComprobante)

        Me.vComprobante.Columns("Cuenta").ColumnEdit = Me.cbCatalogo
        Me.vComprobante.Columns("Debito").ColumnEdit = Me.txtDebito
        Me.vComprobante.Columns("Credito").ColumnEdit = Me.txtCredito
        Me.vComprobante.Columns("orden").Visible = False

        'Me.vComprobante.Columns("Debito").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.vComprobante.Columns("Debito").DisplayFormat.FormatString = "{0:n2}"
        Me.vComprobante.Columns("Debito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vComprobante.Columns("Debito").SummaryItem.DisplayFormat = "{0:n2}"

        'Me.vComprobante.Columns("Credito").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'Me.vComprobante.Columns("Credito").DisplayFormat.FormatString = "{0:n2}"
        Me.vComprobante.Columns("Credito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vComprobante.Columns("Credito").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vComprobante.RefreshData()
    End Sub

    Sub GetTasa()
        'Try
        '    Me.txtTasa.EditValue = ArreglosPagos.BuscarTasa(Me.Fecha.DateTime.Date)

        '    If txtTasa.EditValue > 1 Then
        '        Me.btnGuardar.Enabled = True
        '    Else
        '        MsgBox("No hay Tasa de Cambio del Dia: " & Me.Fecha.DateTime.ToShortDateString, MsgBoxStyle.Information, "Tasa de Cambio")
        '        Me.btnGuardar.Enabled = False
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not Validadar() Then
            Ok = "NO"
            Exit Sub
        End If

        ' ''-------------------------------------------------------------
        'DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        'DBConnFacturas.Open()
        'transaccionFacturas = DBConnFacturas.BeginTransaction()
        ' ''-------------------------------------------------------------

        If Contabilizar() Then
            Ok = "SI"
            Me.Close()
        End If

        'If Contabilizar() Then
        '    GuardaDatos("UPDATE Micros_Transacciones SET FormaPago = '' WHERE ID = " & IdDetalle)
        '    DevExpress.XtraEditors.XtraMessageBox.Show("La Información se ha Procesado Correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    My.Forms.frmCuentasOrden.Cargar()
        '    Me.Close()
        'End If
    End Sub

    Function Validadar() As Boolean
        '**** Verificar Cierre del Dia  ***************************
        If Not VerificarCierre(Me.Fecha.DateTime.Date) Then
            Return False
        End If
        '----------------------------------------------------------

        If Me.cbTipoComp.ItemIndex = 0 Then
            MsgBox("Seleccione el Tipo de Comprobante", MsgBoxStyle.Information)
            Me.cbTipoComp.Focus()
            Return False
        End If

        If Me.vComprobante.DataRowCount < 2 Then
            MsgBox("Debe ingresar al menos dos lineas en el comprobante", MsgBoxStyle.Critical)
            Return False
        End If

        If CDbl(Me.vComprobante.Columns("Debito").SummaryItem.SummaryValue) = 0 Then
            MsgBox("Debe haber al menos una operación de Débito", MsgBoxStyle.Critical)
            Return False
        End If

        If CDbl(Me.vComprobante.Columns("Credito").SummaryItem.SummaryValue) = 0 Then
            MsgBox("Debe haber al menos una operación de Crédito", MsgBoxStyle.Critical)
            Return False
        End If

        If CDbl(Me.vComprobante.Columns("Debito").SummaryItem.SummaryValue) <> CDbl(Me.vComprobante.Columns("Credito").SummaryItem.SummaryValue) Then
            MsgBox("El Débito y el Crédito No están cuadrados", MsgBoxStyle.Critical)
            Return False
        End If

        For i As Integer = 0 To Me.vComprobante.DataRowCount - 1
            If Me.vComprobante.GetRowCellValue(i, "Cuenta") = "" Then
                MsgBox("Asigne la Cuenta Contable", MsgBoxStyle.Critical)
                Return False
            End If
        Next

        If Me.txtComentarios.Text.Trim.Length = 0 Then
            MsgBox("Describa el Concepto del Comprobante", MsgBoxStyle.Information)
            Me.txtComentarios.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub vInteres_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vComprobante.CellValueChanged
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

                'Calcular()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub vInteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vComprobante.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.vComprobante.DeleteSelectedRows()
        End If
    End Sub

    Private Sub Fecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha.EditValueChanged
        GetTasa()
        'Cargar()
    End Sub

    Function Contabilizar() As Boolean

        Dim Cuenta As String = ""
        Dim Importe As Double = 0
        Dim DC As String = ""
        Dim NoComp As Double = 0

        If Documento.Length > 0 Then
            HojaDeposito = Documento & " - " & HojaDeposito
        End If

        Try
            NoComp = ComprobanteDB.AddComprobante(Me.cbTipoComp.EditValue, 1, Me.txtComentarios.Text, _
            EmpresasDB.GetDetails(EmpresaActual).MonedaBase, PeriodosDB.Activo(Me.Fecha.DateTime.Date), _
            Me.Fecha.DateTime.Date, HojaDeposito, "", False, _
            "0", "", 0, "0", Rutinas.Fecha(), 0, 0)

            With Me.vComprobante
                Try
                    For i As Integer = 0 To .DataRowCount - 1
                        Cuenta = .GetRowCellValue(i, "Cuenta")

                        If .GetRowCellValue(i, "Debito") > 0 Then
                            DC = "D"
                            Importe = .GetRowCellValue(i, "Debito")
                        ElseIf .GetRowCellValue(i, "Credito") > 0 Then
                            DC = "C"
                            Importe = .GetRowCellValue(i, "Credito")
                        End If

                        ComprobanteDB.AddComprobanteDetalles(NoComp, Cuenta, .GetRowCellValue(i, "Concepto"), _
                                                             Importe, 0, Me.cbTipoComp.EditValue, DC, "0", "0", _
                                                             Me.Fecha.DateTime.Date, 1)
                    Next
                Catch ex As Exception
                    MsgBox("Hacen Falta Datos Requeridos para Guardar el Comprobante, rebise y vuelva a Intentarlo", MsgBoxStyle.Critical)
                    Ok = "NO"
                    Return False
                End Try
            End With

            Ok = "SI"
            Return True
        Catch ex As Exception
            Ok = "NO"
            Return False
        End Try
    End Function

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Ok = "NO"
        Me.Close()
    End Sub
End Class