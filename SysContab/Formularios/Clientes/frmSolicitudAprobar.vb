Public Class frmSolicitudAprobar

    Dim obj As New SolicitudesVencimiento
    Dim db As New db_SolicitudesVencimiento

    Dim obj_Detallle As New SolicitudesVencimientoDetalle
    Dim db_Detalle As New db_SolicitudesVencimientoDetalle

    Public IdSolicitud As Integer = 0

    Private Sub frmSolicitudesAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If frmSolicitudesVencimientos.Created Then frmSolicitudesVencimientos.Cargar()
    End Sub

    Private Sub frmSolicitudesAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        SearchLookUp(cbCliente, ObtieneDatos("SP_GetClientes", EmpresaActual, 1), "Nombre", "Codigo", 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)

        If IdSolicitud = 0 Then
            Dim DT As DataTable = ObtieneDatos("_UsuarioGetDetalle", Usuario_ID)

            txtSolicitado.Text = DT.Rows.Item(0)("Usr_NombreCompleto")
            txtCorreo.Text = DT.Rows.Item(0)("Usr_email")

            CargarDetalle()
            FormatoEnvia()
        Else
            obj = db_SolicitudesVencimiento.Detalles(IdSolicitud, "")

            cbCliente.EditValue = obj.Cliente
            txtSolicitado.Text = obj.Solicitado_por
            txtCorreo.Text = obj.Correo
            Fecha.DateTime = obj.Fecha
            mJustificacion.Text = obj.Concepto

            cbCliente.Properties.ReadOnly = True

            CargarDetalle()
            FormatoAprueba()
        End If
        '     
        CalcularSaldo()
    End Sub

    Sub FormatoEnvia()
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)
        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("Aprobar").Visible = False
        iVista.Columns("Concepto").Visible = False
        iVista.Columns("Comentario").Width = 300

        iVista.Columns("Factura").OptionsColumn.AllowEdit = False
        iVista.Columns("Vencimiento").OptionsColumn.AllowEdit = False
        iVista.Columns("Aprobado").OptionsColumn.AllowEdit = False

        iVista.Columns("Cambiar Fecha").ColumnEdit = rCheck
    End Sub

    Sub FormatoAprueba()
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)
        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("Comentario").Width = 300
        iVista.Columns("Concepto").Width = 300
        iVista.Columns("Aprobado").Width = 80

        iVista.Columns("Cambiar Fecha").OptionsColumn.AllowEdit = False
        iVista.Columns("Factura").OptionsColumn.AllowEdit = False
        iVista.Columns("Vencimiento").OptionsColumn.AllowEdit = False
        iVista.Columns("Solicitada").OptionsColumn.AllowEdit = False
        iVista.Columns("Saldo U$").OptionsColumn.AllowEdit = False

        iVista.Columns("Cambiar Fecha").ColumnEdit = rCheck
        iVista.Columns("Aprobado").ColumnEdit = rCheck
    End Sub

    Sub CargarDetalle()
        iGrid.DataSource = db_SolicitudesVencimientoDetalle.Listar(0, IdSolicitud)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ' If Not DxValidationProvider1.Validate Then Exit Sub

        If iVista.DataRowCount = 0 Then
            XtraMsg("No hay facturas en el detalle!", MessageBoxIcon.Error)
            Exit Sub
        End If

        'Quitar todos filtros si hay culumnas con filtros aplicados
        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).ClearFilter()
        Next

        Dim selec As Boolean = False

        For i As Integer = 0 To iVista.DataRowCount - 1
            If iVista.GetRowCellValue(i, "Aprobado") Then selec = True
        Next

        If Not selec Then
            XtraMsg("Debe Aprobar al menos 1 Factura", MessageBoxIcon.Warning)
            Exit Sub
        End If

        '
        obj.IdSolicitud = IdSolicitud
        obj.Cliente = cbCliente.EditValue
        obj.Solicitado_por = txtSolicitado.Text
        obj.Correo = txtCorreo.Text
        obj.Fecha = Fecha.DateTime.Date
        obj.Fecha_Aprobada = VB.SysContab.Rutinas.Fecha().Date
        obj.Concepto = mJustificacion.Text
        obj.Estado = "F"

        If IdSolicitud <> 0 Then
            ShowSplash("Guardando...")

            db.Actualizar(obj)

            For i As Integer = 0 To iVista.DataRowCount - 1
                If iVista.GetRowCellValue(i, "Aprobado") Then
                    obj_Detallle.IdDetalle = iVista.GetRowCellValue(i, "IdDetalle")
                    obj_Detallle.IdSolicitud = IdSolicitud
                    obj_Detallle.Factura = iVista.GetRowCellValue(i, "Factura")
                    obj_Detallle.Vencimiento = iVista.GetRowCellValue(i, "Vencimiento")
                    obj_Detallle.Solicitada = iVista.GetRowCellValue(i, "Solicitada")
                    obj_Detallle.Aprobada = 1
                    obj_Detallle.Comentario = IsNull(iVista.GetRowCellValue(i, "Concepto"))

                    db_Detalle.Actualizar(obj_Detallle)
                End If
            Next

            db_SolicitudesVencimiento.EnviarRespuesta(IdSolicitud, "F")

            HideSplash()
            XtraMsg("Los cambios solicitados han sido actualizados con éxito, se enviará correo notificación")

            Close()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        For i As Integer = 0 To iVista.DataRowCount - 1
            iVista.SetRowCellValue(i, "Aprobado", CheckEdit1.Checked)
        Next
        iVista.RefreshData()
    End Sub

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
        'If IdSolicitud = 0 Then
        '    ShowSplash()
        '    iGrid.DataSource = ObtieneDatos("JAR_GetFacturasSaldos", cbCliente.EditValue, VB.SysContab.Rutinas.Fecha().Date, EmpresaActual)
        '    HideSplash()
        'End If
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Aprobado" Then
            If iVista.GetRowCellValue(e.RowHandle, "Aprobado") Then
                e.Appearance.BackColor = Color.Green
            Else
                e.Appearance.BackColor = Color.Tomato
            End If
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If Not XtraMsg2("Esta seguro de Denegar esta Solicitud?") Then
            Exit Sub
        End If
        '
        obj.IdSolicitud = IdSolicitud
        obj.Cliente = cbCliente.EditValue
        obj.Solicitado_por = txtSolicitado.Text
        obj.Correo = txtCorreo.Text
        obj.Fecha = Fecha.DateTime.Date
        obj.Fecha_Denegada = VB.SysContab.Rutinas.Fecha().Date
        obj.Concepto = mJustificacion.Text
        obj.Estado = "D"

        If IdSolicitud <> 0 Then
            ShowSplash("Guardando...")

            db.Actualizar(obj)

            For i As Integer = 0 To iVista.DataRowCount - 1
                ' If iVista.GetRowCellValue(i, "Aprobado") Then
                obj_Detallle.IdDetalle = iVista.GetRowCellValue(i, "IdDetalle")
                obj_Detallle.IdSolicitud = IdSolicitud
                obj_Detallle.Factura = iVista.GetRowCellValue(i, "Factura")
                obj_Detallle.Vencimiento = iVista.GetRowCellValue(i, "Vencimiento")
                obj_Detallle.Solicitada = iVista.GetRowCellValue(i, "Solicitada")
                obj_Detallle.Aprobada = 0
                obj_Detallle.Comentario = IsNull(iVista.GetRowCellValue(i, "Concepto"))

                db_Detalle.Actualizar(obj_Detallle)
                ' End If
            Next

            db_SolicitudesVencimiento.EnviarRespuesta(IdSolicitud, "D")


            HideSplash()
            XtraMsg("Los cambios solicitados han sido actualizados con éxito, se enviará correo de notificación")

            Close()
        End If

    End Sub

    Sub CalcularSaldo()
        Dim Saldo As Double = 0.0
        For i As Integer = 0 To iVista.DataRowCount - 1
            If iVista.GetRowCellValue(i, "Cambiar Fecha") Then
                Saldo += iVista.GetRowCellValue(i, "Saldo U$")
            End If
        Next

        lblSaldo.Text = "Monto Solicitado U$: " & Saldo.ToString("n2")
    End Sub

End Class