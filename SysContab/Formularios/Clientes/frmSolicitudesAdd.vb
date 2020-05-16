Public Class frmSolicitudesAdd

    Dim obj As New SolicitudesVencimiento
    Dim db As New db_SolicitudesVencimiento

    Dim obj_Detallle As New SolicitudesVencimientoDetalle
    Dim db_Detalle As New db_SolicitudesVencimientoDetalle

    Public IdSolicitud As Integer = 0

    Private Sub frmSolicitudesAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If frmSolicitudesEnviadas.Created Then frmSolicitudesEnviadas.Cargar()
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
            SimpleButton1.Enabled = False

            CargarDetalle()
            FormatoAprueba()
        End If
        '        
    End Sub

    Sub FormatoEnvia()
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)
        iVista.Columns("IdDetalle").Visible = False
        iVista.Columns("Aprobado").Visible = False
        iVista.Columns("Concepto").Visible = False
        iVista.Columns("Comentario").Width = 300        

        iVista.Columns("Factura").OptionsColumn.AllowEdit = False
        iVista.Columns("Vencimiento").OptionsColumn.AllowEdit = False
        iVista.Columns("Aprobado").OptionsColumn.AllowEdit = False
        iVista.Columns("Saldo U$").OptionsColumn.AllowEdit = False

        iVista.Columns("Cambiar Fecha").ColumnEdit = rCheck
        iVista.Columns("Aprobado").ColumnEdit = rCheck
    End Sub

    Sub FormatoAprueba()
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)

        iVista.OptionsBehavior.Editable = False

        iVista.Columns("IdDetalle").Visible = False    
        iVista.Columns("Comentario").Width = 300
        iVista.Columns("Concepto").Width = 300
        iVista.Columns("Aprobado").Width = 80

        iVista.Columns("Cambiar Fecha").ColumnEdit = rCheck
        iVista.Columns("Aprobado").ColumnEdit = rCheck
    End Sub

    Sub CargarDetalle()
        iGrid.DataSource = db_SolicitudesVencimientoDetalle.Listar(0, IdSolicitud)    
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        If iVista.DataRowCount = 0 Then
            XtraMsg("No hay facturas en el detalle!", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        'Quitar todos filtros si hay culumnas con filtros aplicados
        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).ClearFilter()
        Next

        Dim selec As Boolean = False
        For i As Integer = 0 To iVista.DataRowCount - 1
            If iVista.GetRowCellValue(i, "Cambiar Fecha") Then selec = True
        Next

        If Not selec Then
            XtraMsg("Debe seleccionar al menos 1 Factura", MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim DT_SOPORTES As DataTable =
            VB.SysContab.ClientesDB.GetDocumentos("CLIENTES", cbCliente.EditValue)

        Dim Ruta As String =
            ObtieneDatos("JAR_GetRutaCompartida").Rows.Item(0)("Ruta")

        If DT_SOPORTES.Rows.Count = 0 Then
            If Not XtraMsg2("No se han adjuntado Soportes para esta solicitud, Desea continuar de todas formas?") Then
                Exit Sub
            End If
        Else
            'Borrar Contenido de la Carpeta que contiene los archivos a Adjuntar
            Try
                Dim files As String() = System.IO.Directory.GetFiles(Ruta)
                For Each file As String In files
                    Kill(file)
                Next

            Catch ex As Exception
                XtraMsg("Error de Acceso a la Ruta en el servidor: " & Ruta & vbCrLf & _
                        ex.Message & vbCrLf & _
                        "FAVOR CONSULTAR AL ADMINISTRADOR DE RED SOBRE ESTE ERROR...", MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '
        If Not XtraMsg2("Esta seguro que la información es correcta?") Then
            Exit Sub
        End If
        '
        obj.IdSolicitud = IdSolicitud
        obj.Cliente = cbCliente.EditValue
        obj.Solicitado_por = txtSolicitado.Text
        obj.Correo = txtCorreo.Text
        obj.Fecha = Fecha.DateTime.Date
        obj.Concepto = mJustificacion.Text

        If IdSolicitud = 0 Then
            ShowSplash("Enviando...")

            IdSolicitud = db.Insertar(obj)

            For i As Integer = 0 To iVista.DataRowCount - 1
                If iVista.GetRowCellValue(i, "Cambiar Fecha") Then
                    obj_Detallle.IdSolicitud = IdSolicitud
                    obj_Detallle.Factura = iVista.GetRowCellValue(i, "Factura")
                    obj_Detallle.Vencimiento = iVista.GetRowCellValue(i, "Vencimiento")
                    obj_Detallle.Solicitada = iVista.GetRowCellValue(i, "Solicitada")
                    obj_Detallle.Aprobada = 0
                    obj_Detallle.Comentario = IsNull(iVista.GetRowCellValue(i, "Comentario"))

                    db_Detalle.Insertar(obj_Detallle)
                End If
            Next

            If DT_SOPORTES.Rows.Count > 0 Then
                Try                
                    For i As Integer = 0 To DT_SOPORTES.Rows.Count - 1
                        VB.SysContab.ClientesDB.CrearDocumento(DT_SOPORTES.Rows.Item(i)("IdDocumento"), _
                                                 DT_SOPORTES.Rows.Item(i)("Extension"), Ruta, i + 1)
                    Next
                Catch ex As Exception
                End Try
            End If

            db_SolicitudesVencimiento.EnviarSolicitud(IdSolicitud)

            HideSplash()
            XtraMsg("Solicitud de Cambios de Fechas de vencimiento ha sido enviada con éxito!")

            Close()
        Else
            db.Actualizar(obj)
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub cbCliente_EditValueChanged(sender As Object, e As EventArgs) Handles cbCliente.EditValueChanged
        If IdSolicitud = 0 Then
            ShowSplash()
            iGrid.DataSource = ObtieneDatos("JAR_GetFacturasSaldos", cbCliente.EditValue, VB.SysContab.Rutinas.Fecha().Date, EmpresaActual)
            HideSplash()
        End If
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
        With frmDocumentos
            .Tipo = "CLIENTES"
            .Codigo = cbCliente.EditValue
            .NDocumento = cbCliente.Text
            .Text = "Soporte Digital del Cliente: " & cbCliente.Text
            .txtNombre.Text = cbCliente.Text
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub iVista_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iVista.CellValueChanged
        CalcularSaldo()
    End Sub

    Sub CalcularSaldo()
        Dim Saldo As Double = 0.0
        For i As Integer = 0 To iVista.DataRowCount - 1
            If iVista.GetRowCellValue(i, "Cambiar Fecha") Then
                Saldo += iVista.GetRowCellValue(i, "Saldo U$")
            End If
        Next

        lblSaldo.Text = "Monto a Solicitar U$: " & Saldo.ToString("n2")
    End Sub
End Class