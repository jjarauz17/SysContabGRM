Imports System.Data.SqlClient
Imports ClasesBLL
Public Class frmRemisionesContabilizar

    Public IdRemision As Integer = 0, NoComp As Double = 0
    Public NoRemision As String = "", Ok As String = "NO"

    Private DT_Distribucion As DataTable = New DataTable("Distribucion")

    Private Sub frmRemisionesContabilizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        DT_Distribucion = CargaDistribucion(0, 0, 0)
        GetTipoComprobantesList(cbTipo)
        cbTipo.ItemIndex = 0

        CargarCatalogo()

        iGrid.DataSource = db_Remisiones.Remisiones_Contabilizar(IdRemision, EmpresaActual)
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False, True, False)

        iVista.Columns("Cuenta").ColumnEdit = cbCatalogo
        iVista.Columns("Debito").ColumnEdit = txtMonto
        iVista.Columns("Credito").ColumnEdit = txtMonto
    End Sub

    Sub CargarCatalogo()
        RepositorySearchLook(cbCatalogo, ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual), "Display", "Cuenta", 2)
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
        If iVista.DataRowCount < 2 Then
            XtraMsg("Debe ingresar al menos dos lineas en el comprobante", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If CDbl(iVista.Columns("Debito").SummaryItem.SummaryValue) <> CDbl(iVista.Columns("Credito").SummaryItem.SummaryValue) Then
            XtraMsg("El Débito y el Crédito no estan cuadrados", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        '******** VERIFICAR DISTRIBUCION ***********************************
        For i As Integer = 0 To iVista.DataRowCount - 1
            Dim CTemp As String = vbNullString
            Try
                CTemp = ObtieneDatos("SELECT CuentaContable FROM RubrosGastos WHERE Activo = 1 AND" _
                                     + " CuentaContable = '" & iVista.GetRowCellValue(i, "Cuenta") & "'" _
                                     + " AND Empresa = " & EmpresaActual).Rows(0).Item(0)
            Catch ex As Exception
                CTemp = "xxx"
            End Try

            If CTemp <> "xxx" And CTemp <> vbNullString Then
                '
                If VerificaDistribucion(CTemp) = False And ObligarDistribucion = True Then
                    XtraMsg("La Cuenta " & iVista.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
                           "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
        Next
        '******** FIN VERIFICAR DISTRIBUCION *****************************
        '

        Dim Per_Id As Integer = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date)

        '----------------------------------------------------------------------
        Dim conexion As New VB.SysContab.Rutinas
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()
        '----------------------------------------------------------------------

        Try
            Dim Cuenta As String = "", DC As String = "", Importe As Double = 0.00

            NoComp =
            VB.SysContab.ComprobanteDB.AddComprobante(cbTipo.EditValue, 1.0, Concepto.Text,
                                       MonedaBase, Per_Id,
                                       Fecha.DateTime.Date, 0, "", False, 0, "", 0, Documento.Text, VB.SysContab.Rutinas.Fecha(),
                                       0, OrigenComprobantes.INVENTARIO, "", 0, 0, "0")

            With iVista
                Try
                    For i As Integer = 0 To .DataRowCount - 1
                        Cuenta = IsNull(.GetRowCellValue(i, "Cuenta"), "")

                        If Cuenta = "" Then
                            XtraMsg("La cuenta Contable no puede ser vacia.", MessageBoxIcon.Error)
                            VB.SysContab.Rutinas.ErrorTransaccion()
                            Ok = "NO"
                            Exit Sub
                        End If

                        If .GetRowCellValue(i, "Debito") > 0 Then
                            DC = "D"
                            Importe = .GetRowCellValue(i, "Debito")
                        ElseIf .GetRowCellValue(i, "Credito") > 0 Then
                            DC = "C"
                            Importe = .GetRowCellValue(i, "Credito")
                        End If

                        VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComp, Cuenta, IsNull(.GetRowCellValue(i, "Descripcion"), ""),
                                                            Math.Round(Importe, 2), 0, cbTipo.EditValue, DC, 0, 0,
                                                            Fecha.DateTime.Date, 1)
                    Next
                Catch ex As Exception
                    XtraMsg("Hacen Falta Datos Requeridos para Guardar el Comprobante, rebise y vuelva a Intentarlo", MessageBoxIcon.Error)
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    Ok = "NO"
                    Exit Sub
                End Try
            End With
            '
            If Not db_Remisiones.Remisiones_UpdateContabilizar(IdRemision, NoComp, Per_Id, Fecha.DateTime.Month, EmpresaActual) Then
                VB.SysContab.Rutinas.ErrorTransaccion()
                Ok = "NO"
                Exit Sub
            End If
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
                            " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & NoComp & "," & Fecha.DateTime.Month & "," &
                            VB.SysContab.PeriodosDB.Activo(Fecha.DateTime) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
                        ElseIf .Rows(i).RowState = DataRowState.Modified Then
                            GuardaDatos("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & NoComp & ",Mes=" & Fecha.DateTime.Month & "," &
                            "Per_Id = " & VB.SysContab.PeriodosDB.Activo(Fecha.DateTime) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," &
                            "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
                        ElseIf .Rows(i).RowState = DataRowState.Deleted Then
                        End If
                    End With
                Next
            End If
            '--------------------------
            'Fin de Guarda Distribucion
            '--------------------------



            VB.SysContab.Rutinas.okTransaccion()
            XtraMsg("La Remisión Numero " & NoRemision & " ha sido contabilizada con Exito!")

            Ok = "SI"
            Close()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Ok = "NO"
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

    Private Sub iVista_DoubleClick(sender As Object, e As EventArgs) Handles iVista.DoubleClick
        If iVista.DataRowCount = 0 Then
            Exit Sub
        End If
        '
        Try
            Dim frm As New FrmDetalleRequisas
            With iVista
                frm.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
                If IsDBNull(.GetRowCellValue(.FocusedRowHandle, "Debito")) OrElse IsNothing(.GetRowCellValue(.FocusedRowHandle, "Debito")) OrElse .GetRowCellValue(.FocusedRowHandle, "Debito") = Nothing OrElse .GetRowCellValue(.FocusedRowHandle, "Debito") = 0 Then
                    frm.Monto = .GetRowCellValue(.FocusedRowHandle, "Credito")
                    frm.Tipo = "C"
                    frm.Periodo = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime)
                    frm.CompNo = NoComp
                    frm.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
                    frm.Mes = Fecha.DateTime.Month
                Else
                    frm.Monto = .GetRowCellValue(.FocusedRowHandle, "Debito")
                    frm.Tipo = "D"
                    frm.Periodo = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime)
                    frm.CompNo = NoComp
                    frm.Cuenta = .GetRowCellValue(.FocusedRowHandle, "Cuenta")
                    frm.Mes = Fecha.DateTime.Month
                End If
                frm.Mostrar(DT_Distribucion)
                DT_Distribucion.DefaultView.RowFilter = ""
            End With

        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub iVista_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If iVista.DataRowCount = 0 Then Exit Sub
        If e.KeyCode = Keys.Delete Then iVista.DeleteSelectedRows()
    End Sub

    Private Sub iVista_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles iVista.RowUpdated
        CargarCatalogo()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Ok = "NO"
        Close()
    End Sub


End Class