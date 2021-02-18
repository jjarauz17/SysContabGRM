Public Class frmPropiedadesAdd

    Dim obj As New PNR_Propiedades
    Dim db As New db_PNR_Propiedades

    Dim objDetalle As New PNR_Propiedades_Detalle
    Dim dbDetalle As New db_PNR_Propiedades_Detalle

    Dim DT As New DataTable("Pro_Detalle")

    Public IdPropiedad As Integer = 0
    Public IdCliente As Integer = 0,
        IdPeriodo As Integer = 0
    Public Ok As String = "NO"

    Private Sub frmPropiedadesAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmPropiedades.Cargar()
    End Sub

    Private Sub frmPropiedadesAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        CargarCombos()
        '
        If IdPropiedad <> 0 Then
            obj = db_PNR_Propiedades.Detalles(IdPropiedad, IdCliente, cbPeriodo.EditValue)

            If Not obj Is Nothing Then
                txtNombre.Text = obj.Nombre
                cbCliente.EditValue = obj.IdCliente
                cbCultivo.EditValue = obj.IdCultivo
                txtTotalMz.EditValue = obj.Total_Mz
                txtMzAtendidas.EditValue = obj.Mz_Atendidas
                txtMzCultivo.EditValue = obj.Mz_Cultivo
                txtPotencialBiologico.EditValue = obj.Potencial_Biologico
                cbPeriodo.EditValue = obj.Periodo

                cbPeriodo.Properties.ReadOnly = True
            End If
        End If
        '
        CargarDetalle()
        If IdPeriodo > 0 Then cbPeriodo.EditValue = IdPeriodo
    End Sub

    Sub CargarDetalle()
        DT = db_PNR_Propiedades_Detalle.Listar(IIf(IdPropiedad = 0, -1, IdPropiedad))
        iGrid.DataSource = DT
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False, True, False)

        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("IdPropiedad").Visible = False
        '
        iVista.Columns("Total Mz").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        iVista.Columns("Total Mz").DisplayFormat.FormatString = "{0:n2}"
        iVista.Columns("Total Mz").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        iVista.Columns("Total Mz").SummaryItem.DisplayFormat = "{0:n2}"
        '
        iVista.Columns("Nombre").Width = 500
    End Sub

    Sub CargarCombos()
        Application.DoEvents()
        Combo(cbPeriodo, db_PNR_PlanNegocio.GetPeriodos())
        cbPeriodo.EditValue = VB.SysContab.Rutinas.Fecha().Year
        '
        Application.DoEvents()
        GridLookUp(cbCliente, ObtieneDatos("PNR_GetClientes", EmpresaActual), _
                   "Nombre", "Codigo", 0, 1, 2)
        cbCliente.Properties.PopupFormSize = New Point(1000, 0)
        '
        Application.DoEvents()
        Combo(cbCultivo, GetCultivo())
        'Application.DoEvents()
        'GetTipoCultivo(cbCultivo)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub
        '
        obj.IdPropiedad = IdPropiedad
        obj.Empresa = EmpresaActual
        obj.Nombre = ""
        obj.IdCliente = cbCliente.EditValue
        obj.IdCultivo = cbCultivo.EditValue
        obj.Total_Mz = txtTotalMz.EditValue
        obj.Mz_Atendidas = txtTotalMz.EditValue
        obj.Mz_Cultivo = 0.0
        obj.Potencial_Biologico = txtPotencialBiologico.EditValue
        obj.Periodo = cbPeriodo.EditValue

        'Guardar Encabezado
        If IdPropiedad = 0 Then
            IdPropiedad = db.Insertar(obj)
            Ok = "SI"
        Else
            db.Actualizar(obj)
            Ok = "SI"
        End If

        'Guardar Detalle
        'Borrar Detalle
        objDetalle.IdPropiedad = IdPropiedad
        dbDetalle.Borrar(objDetalle)

        For i As Integer = 0 To iVista.DataRowCount - 1
            objDetalle.Nombre = IsNull(iVista.GetRowCellValue(i, "Nombre"), "")
            objDetalle.Manzanas = IsNull(iVista.GetRowCellValue(i, "Total Mz"), 0.0)

            dbDetalle.Insertar(objDetalle)
        Next

        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub iVista_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        If e.KeyCode = Keys.Delete Then
            iVista.DeleteSelectedRows()
            SumarManzanas()            
        End If
    End Sub

    Private Sub iVista_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles iVista.RowUpdated
        SumarManzanas()
    End Sub

    Sub SumarManzanas()
        iVista.RefreshData()
        txtTotalMz.EditValue = iVista.Columns("Total Mz").SummaryItem.SummaryValue
    End Sub

    Private Sub txtPotencialBiologico_EditValueChanged(sender As Object, e As EventArgs) Handles txtPotencialBiologico.EditValueChanged, txtTotalMz.EditValueChanged
        Try
            txtPotencial.EditValue = Math.Round(txtTotalMz.EditValue * txtPotencialBiologico.EditValue, 2)
        Catch ex As Exception
            txtPotencial.EditValue = 0.0
        End Try
    End Sub

End Class