Imports System.Data
Imports System.Linq
Imports System.Data.SqlClient
Imports ClasesBLL
Imports Entities

Public Class frmRequisaContab

    Private DetalleEmpresa As New VB.SysContab.EmpresasDetails

    Dim Comprobantes As New VB.SysContab.ComprobanteDB
    Dim Fechas As New VB.SysContab.FechasdeTrabajo

    Dim NoComprob As Double = 0

    Public Requisa As Integer
    Public TRequisa As String
    Public Bodega As String
    Public Referencia As String
    Public Comp_Tipo As Integer
    Public Concepto As String = String.Empty

    Dim ds1 As DataSet
    Private DT_Distribucion As DataTable = New DataTable("Distribucion")
    Dim DTRequisa As New DataTable("Requisa")

    'Private Sub CargaDistribucion()
    '    Me.DT_Distribucion = ObtieneDatos("SELECT * FROM Distribucion")
    'End Sub

    Private Sub frmRequisaContab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CargaDistribucion()
        'If TRequisa = "E" Then DT_Distribucion = CargaDistribucion(0, 0, 0)
        'If TRequisa = "S" Then DT_Distribucion = ObtieneDatos("sp_RequisaDetalleDistribucion", Requisa, EmpresaActual)

        DT_Distribucion = ObtieneDatos("sp_RequisaDetalleDistribucion",
                                       Requisa,
                                       EmpresaActual)
        Cargar()

        ''Me.Fecha.Properties.MinValue = CDate(Fechas.FechaMinima)
        ''Me.Fecha.Properties.MaxValue = CDate(Fechas.FechaMaxima)
        ''Me.Fecha.DateTime = CDate(VB.SysContab.Rutinas.Fecha)
    End Sub

    Sub Cargar()
        GetComprobantesList(cbTipoComp)
        cbTipoComp.EditValue = Comp_Tipo

        RepositorySearchLook(cbProyecto, db_Proyectos.Fill(), "Nombre", "IdProyecto", 0, 4, 5, 6, 7, 8)

        'Me.cbTipoComp.Properties.DataSource = Comprobantes.GetTiposComprobantes(0).Tables("TipoComprobantes")
        'Me.cbTipoComp.Properties.ValueMember = "TipComp_Id"
        'Me.cbTipoComp.Properties.DisplayMember = "TipComp_Nombre"
        'Me.cbTipoComp.Properties.PopulateColumns()

        'For i As Integer = 0 To Me.cbTipoComp.Properties.Columns.Count - 1
        '    Me.cbTipoComp.Properties.Columns(i).Visible = False
        'Next

        'Me.cbTipoComp.Properties.Columns(2).Visible = True
        'Me.cbTipoComp.ItemIndex = 0



        cbCatalogo.DataSource = ObtieneDatos("_GetCatalogo_CuentaActivo", EmpresaActual).DefaultView
        FormatoGrid(cbCatalogo.View, 2)
        cbCatalogo.PopupFormSize = New Point(1000, 0)

        DTRequisa = ObtieneDatos("sp_RequisaDetalleContabilizar",
                                            Requisa,
                                            TRequisa,
                                            Bodega,
                                            EmpresaActual)

        gridDatos.DataSource = DTRequisa

        FormatoGrid(vComprobante, 2, 0, False, True, False)

        Calcular()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Validar() = True Then
            GuardarComprobante()
        End If
    End Sub

    Private Function Validar() As Boolean

        'Verificar Cierre del Día
        '-----------------------------------------------------------------
        If Not VerificarCierre(Fecha.DateTime.Date) Then
            Exit Function
        End If
        '------------------------------------------------------------------

        If Me.cbTipoComp.ItemIndex = 0 Then
            XtraMsg("Seleccione Tipo de Comprobante!")
            cbTipoComp.Focus()
            Return False
        End If

        If Me.vComprobante.DataRowCount < 2 Then
            XtraMsg("Debe ingresar al menos dos lineas en el comprobante", MessageBoxIcon.Error)
            Return False
        End If

        vComprobante.UpdateTotalSummary()
        vComprobante.RefreshData()
        '
        If CDbl(Me.vComprobante.Columns("Debito").SummaryItem.SummaryValue) = 0 Then
            XtraMsg("Debe haber al menos una operación de Débito", MessageBoxIcon.Error)
            Return False
        End If

        If CDbl(Me.vComprobante.Columns("Credito").SummaryItem.SummaryValue) = 0 Then
            XtraMsg("Debe haber al menos una operación de Crédito", MessageBoxIcon.Error)
            Return False
        End If

        If Math.Round(CDbl(Me.vComprobante.Columns("Debito").SummaryItem.SummaryValue), 2) <> Math.Round(CDbl(Me.vComprobante.Columns("Credito").SummaryItem.SummaryValue), 2) Then
            XtraMsg("El Débito y el Crédito NO estan cuadrados", MessageBoxIcon.Error)
            Return False
        End If

        If Me.txtConcepto.Text.Trim.Length = 0 Then
            XtraMsg("Describa el Concepto del Comprobante")
            txtConcepto.Focus()
            Return False
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
                    XtraMsg("La Cuenta " & Me.vComprobante.GetRowCellValue(i, "Cuenta").ToString & " Seleccionada es de Distribución, Favor Distribuirla " & vbCrLf &
                           "ó Verifique el Detalle de la Distribución.", MessageBoxIcon.Warning)
                    Return False
                End If
            End If
        Next
        '******** FIN VERIFICAR DISTRIBUCION *****************************
        '
        '******** VERIFICAR CUENTAS DE INGRESO ***************************
        Dim IsCuentaIngreso As Boolean = False
        Dim _dt As DataTable =
            ObtieneDatos("sp_sel_Cuentas_Ingresos", EmpresaActual)

        If _dt.Rows.Count > 0 Then
            For i As Integer = 0 To vComprobante.DataRowCount - 1
                If _dt.Select("Cuenta = '" & vComprobante.GetRowCellValue(i, "Cuenta") & "'").Length > 0 Then
                    IsCuentaIngreso = True
                    Exit For
                End If
            Next
            '
            'Verificar Cierre de Bolsa
            If IsCuentaIngreso Then
                If Fecha.DateTime.Date <= db_FACTURAS_BOLSA.UltimoCierre().Date Then
                    XtraMsg("La fecha: " & Fecha.DateTime.ToShortDateString & " con la que intenta grabar esta Nota ya fue reportada en BOLSA AGROPECUARIA, " & vbCrLf &
                            "Ultima fecha reportada al: " & db_FACTURAS_BOLSA.UltimoCierre().Date.ToShortDateString, MessageBoxIcon.Error)
                    Return False
                End If
            End If
        End If
        '******** FIN VERIFICAR CUENTAS DE INGRESO **********************
        '
        Return True
    End Function

    Sub GuardarComprobante()

        Dim Cuenta As String = String.Empty
        ''Dim NoComprob As Double = 0
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
            NoComprob =
            VB.SysContab.ComprobanteDB.AddComprobante(Me.cbTipoComp.EditValue, TCambio, txtConcepto.Text,
                                        DetalleEmpresa.MonedaBase, VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date),
                                        Fecha.DateTime.Date, 0, "", False, 0, "", 0, Referencia, VB.SysContab.Rutinas.Fecha,
                                        0, OrigenComprobantes.INVENTARIO)

            'Actualizar la requisa como contabilizada
            VB.SysContab.RequisasDB.Contabilizar(Requisa, True, False, NoComprob,
                                                 VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date),
                                                 Me.Fecha.DateTime.Month)

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

                        VB.SysContab.ComprobanteDB.AddComprobanteDetalles(NoComprob, Cuenta, IsNull(.GetRowCellValue(i, "Concepto"), ""),
                                                                          Math.Round(Importe, 2), 0, Me.cbTipoComp.EditValue, DC, 0, 0,
                                                                          Me.Fecha.DateTime.Date, 1, 0, "", IsNull(.GetRowCellValue(i, "IdProyecto"), 0))
                    Next

                Catch ex As Exception
                    XtraMsg("Hacen Falta Datos Requeridos para Guardar el Comprobante, rebise y vuelva a Intentarlo." & vbCrLf &
                            "Erro: " & ex.Message, MessageBoxIcon.Error)
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    Exit Sub
                End Try
            End With
            '
            'Dim obj As New Distribucion,
            '    db As New db_Distribucion

            'obj.IdEmpresa = EmpresaActual
            'obj.NoComp = NoComprob
            'obj.Per_Id = VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date)
            'obj.Mes = Fecha.DateTime.Month

            'Dim DT_F As DataTable =
            '    DT_Distribucion.GetChanges(
            '    DataRowState.Added Or DataRowState.Unchanged Or DataRowState.Modified)

            'If Not DT_F Is Nothing Then
            '    For i As Integer = 0 To DT_F.Rows.Count - 1
            '        With DT_F


            '            obj.IdRubroGasto = .Rows(i).Item("IdRubroGasto")
            '            obj.IdCentroCosto = .Rows(i).Item("IdCentroCosto")
            '            obj.Valor = .Rows(i).Item("Valor")
            '            obj.Tipo = .Rows(i).Item("Tipo")
            '            obj.Cuenta = .Rows(i).Item("Cuenta")

            '            db.Insertar(obj)


            '            '' If (.Rows(i).RowState = DataRowState.Added Or .Rows(i).RowState = DataRowState.Unchanged) Then
            '            'GuardaDatosTrans("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
            '            '    " VALUES(" & .Rows(i).Item("IdEmpresa") & "," & NoComprob & "," & Me.Fecha.DateTime.Month & "," &
            '            '    VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime.Date) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & Math.Round(CDbl(.Rows(i).Item("Valor")), 2) & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
            '            ''ElseIf .Rows(i).RowState = DataRowState.Modified Then
            '            ''    GuardaDatosTrans("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & NoComprob & ",Mes=" & Me.Fecha.DateTime.Month & "," &
            '            ''    "Per_Id = " & VB.SysContab.PeriodosDB.Activo(Me.Fecha.DateTime) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," &
            '            ''    "Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
            '            ''ElseIf .Rows(i).RowState = DataRowState.Deleted Then
            '            ''End If
            '        End With
            '    Next
            'End If

            'CargaDistribucion(0, 0, 0)
            '--------------------------
            'Fin de Guarda Distribucion
            '--------------------------
            'SetTiempos(OrigenComprobantes.NATURAL, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Guarda, NoComprob)
            'Cargar()

            VB.SysContab.Rutinas.okTransaccion()
        Catch Mensaje As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            ' SetTiempos(OrigenComprobantes.NATURAL, funciones.Tiempos.TiempoFin, Now, funciones.Eventos.Error1, NoComprob)
            XtraMsg(Mensaje.Message, MessageBoxIcon.Error)
            Exit Sub
        End Try
        '
        '------------------------
        'Guarda la Distribucion
        '------------------------
        DTRequisa.AcceptChanges()
        Dim sCuentas = From row In DTRequisa.AsEnumerable()
                       Select row.Field(Of String)("Cuenta") Distinct

        For Each s As Object In sCuentas
            If Not s Is Nothing Then
                If DT_Distribucion.Select("Cuenta = '" & s & "'").Length > 0 Then
                    GuardaDistribucion(
                            DT_Distribucion.Select("Cuenta = '" & s & "'").CopyToDataTable,
                            NoComprob,
                            VB.SysContab.PeriodosDB.Activo(Fecha.DateTime.Date),
                            Fecha.DateTime.Month)
                End If
            End If
        Next
        '--------------------------
        'Fin de Guarda Distribucion
        '--------------------------
        Me.Close()
        Dim f As frmRequisas_List = frmRequisas_List.Instance()
        f.GetData()
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


    Private Sub vComprobante_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vComprobante.DoubleClick
        If Me.vComprobante.DataRowCount = 0 Then
            Exit Sub
        End If

        Try
            Dim forma As New FrmDetalleRequisas
            With Me.vComprobante
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

    Private Sub vComprobante_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vComprobante.CellValueChanged
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

                Calcular()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub vComprobante_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vComprobante.KeyDown
        If Me.vComprobante.DataRowCount = 0 Then
            Exit Sub
        End If

        If e.KeyCode = Keys.Delete Then
            Me.vComprobante.DeleteSelectedRows()
            Calcular()
        End If
    End Sub

    Private Sub vComprobante_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles vComprobante.RowUpdated
        Calcular()
    End Sub

    Sub Calcular()
        Try
            With Me.vComprobante
                Me.etDebito.Text = CDbl(.Columns("Debito").SummaryItem.SummaryValue).ToString(Round)
                Me.etCredito.Text = CDbl(.Columns("Credito").SummaryItem.SummaryValue).ToString(Round)
                Me.etDif.Text = (CDbl(.Columns("Debito").SummaryItem.SummaryValue) - CDbl(.Columns("Credito").SummaryItem.SummaryValue)).ToString(Round)
            End With
        Catch ex As Exception
        End Try
    End Sub


End Class