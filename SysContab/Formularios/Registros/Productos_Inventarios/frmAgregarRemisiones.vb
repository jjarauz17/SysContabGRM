Public Class frmAgregarRemisiones

    Private DetallesCliente As New VB.SysContab.ClientesDetails
    Private DT_Facturas As DataTable = New DataTable("Facturas")
    Public Factura As String = ""
    Private Temp As Boolean = False
    Dim TCambio As Double = 1

    Dim Estr_H As New Remisiones
    Dim Estr_D As New Remisiones
    Dim Trans_H As New ClRemisiones
    Dim Trans_D As New ClRemisiones_Lineas


    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub frmAgregarRemisiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetCentrosCostosList(Me.cmbcentrocosto)
        LoadClients()
        Me.fecha.EditValue = Now.Date
        Me.txtNoRemision.EditValue = ObtieneDatos("SELECT isnull(max(r.Remision + 1),1) Numero FROM Remisiones r WHERE r.Empresa = " & EmpresaActual).Rows.Item(0)("Numero")

        GetArticulos()
        GetData()

        '**** Cargar Tasa de Cambio
        TCambio = CDbl(ObtieneDatos("SELECT isnull(max(tc.TASA_CAMBIO),1) Tasa FROM TASA_CAMBIO tc" _
        + " WHERE tc.DIA = " & Me.fecha.DateTime.Day & " AND tc.MES = " & Me.fecha.DateTime.Month & " AND tc.ANIO = " & Me.fecha.DateTime.Year & "").Rows.Item(0)(0))
        Me.etTasa.Text = TCambio.ToString("n4")
    End Sub

    Private Sub LoadClients()
        GetClientesList(cmbclientes)
        cmbclientes.Properties.Columns(0).Visible = True : cmbclientes.Properties.ShowHeader = True 'Para radioshack
        cmbclientes.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch 'Para radioshack
    End Sub

    Private Sub cmbclientes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbclientes.EditValueChanged
        Try
            DetallesCliente = VB.SysContab.ClientesDB.GetDetails(cmbclientes.EditValue)
            txtdireccion.Text = cmbclientes.GetColumnValue("Direccion")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GetData()
        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Add("Empresa")
        Variables.Add("Factura")

        Datos.Add(EmpresaActual)
        Datos.Add(Factura)
        DT_Facturas = ProcedureParameters(Datos, Variables, "sp_GetDetalleRemision")
        GridDetalle.DataSource = DT_Facturas
    End Sub

    Private Sub GetArticulos()
        Dim DT As DataTable
        DT = ObtieneDatos("SP_ArticulosGetAll 'P'," & EmpresaActual)
        ItemArticulo.DataSource = DT
        ItemArticulo.DisplayMember = "Codigo"
        ItemArticulo.ValueMember = "Codigo"
        ItemArticulo.PopulateColumns()
        For i As Integer = 2 To ItemArticulo.Columns.Count - 1
            ItemArticulo.Columns(i).Visible = False
        Next
        ItemArticulo.Columns(1).Visible = False
        ItemArticuloD.DataSource = DT
        ItemArticuloD.DisplayMember = "Nombre"
        ItemArticuloD.ValueMember = "Codigo"
        ItemArticuloD.PopulateColumns()
        For i As Integer = 2 To ItemArticuloD.Columns.Count - 1
            ItemArticuloD.Columns(i).Visible = False
        Next
        ItemArticuloD.Columns(0).Visible = False
    End Sub

    Private Sub vDatos_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vDatos.CellValueChanged
        If e.Column.FieldName = "Item" Then
            Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(e.Value)
            Temp = True
            Me.vDatos.SetRowCellValue(e.RowHandle, "Precio", DR.Item("Precio"))
            Me.vDatos.SetRowCellValue(e.RowHandle, "PrecioU", DR.Item("PrecioU"))
            Me.vDatos.SetRowCellValue(e.RowHandle, "Cantidad", 1)
            Me.vDatos.SetRowCellValue(e.RowHandle, "Unidad", DR.Item("Unidad"))
            Me.vDatos.SetRowCellValue(e.RowHandle, "Cuenta", DR.Item("Cuenta"))
            Me.vDatos.SetRowCellValue(e.RowHandle, "Tipo", DR.Item("Tipo"))
            Me.vDatos.SetRowCellValue(e.RowHandle, "Exento", DR.Item("Exento"))
            Temp = False
        End If

        If e.Column.FieldName = "Precio" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                Me.vDatos.SetRowCellValue(e.RowHandle, "PrecioU", Math.Round(CDbl(e.Value / TCambio), 2))
                Temp = False
            End If
        End If

        If e.Column.FieldName = "PrecioU" And Not Temp Then
            If e.Value <> 0 Then
                Temp = True
                Me.vDatos.SetRowCellValue(e.RowHandle, "Precio", Math.Round(CDbl(e.Value * TCambio), 2))
                Temp = False
            End If
        End If

        '*** Actualizar el Valor de la UNIDAD en la tabla de ARTICULOS
        If e.Column.FieldName = "Unidad" And Not Temp Then
            Temp = True
            Try
                GuardaDatos("UPDATE ARTICULOS SET UNIDAD = '" & e.Value & "'" _
                            + " WHERE CODIGO_ARTICULO = '" & Me.vDatos.GetRowCellValue(e.RowHandle, "Item") & "'" _
                            + " AND TIPO = '" & Me.vDatos.GetRowCellValue(e.RowHandle, "Tipo") & "'")
            Catch ex As Exception
            End Try
            Temp = False
        End If

        If e.Column.FieldName = "Precio" Or e.Column.FieldName = "Cantidad" Then
            Me.vDatos.SetRowCellValue(e.RowHandle, "Total", IsNull(Me.vDatos.GetRowCellValue(e.RowHandle, "Cantidad"), 1) * IsNull(Me.vDatos.GetRowCellValue(e.RowHandle, "Precio"), 0))

            Dim DR As DataRowView = ItemArticulo.GetDataSourceRowByKeyValue(Me.vDatos.GetRowCellValue(e.RowHandle, "Item"))
            Dim Config As New VB.SysContab.ConfiguracionDB
            Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
            ConfigDetalles = Config.GetConfigDetails

            If DR.Item("Exento") = False Then
                Me.vDatos.SetRowCellValue(e.RowHandle, "IVA", IsNull(Me.vDatos.GetRowCellValue(e.RowHandle, "Total") * (ConfigDetalles.IVA / 100.0), 0))
            End If
        End If

        Me.vDatos.UpdateTotalSummary()
    End Sub

    Private Sub fecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.EditValueChanged
        Try
            TCambio = CDbl(ObtieneDatos("SELECT isnull(max(tc.TASA_CAMBIO),1) Tasa FROM TASA_CAMBIO tc" _
            + " WHERE tc.DIA = " & Me.fecha.DateTime.Day & " AND tc.MES = " & Me.fecha.DateTime.Month & " AND tc.ANIO = " & Me.fecha.DateTime.Year & "").Rows.Item(0)(0))
            Me.etTasa.Text = TCambio.ToString("n4")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If ObtieneDatos("SELECT * FROM Remisiones r WHERE r.Remision = " & Me.txtNoRemision.EditValue & " AND r.Empresa = " & EmpresaActual).Rows.Count > 0 Then
            MsgBox("El Número de Remisión ya fue Ingresado", MsgBoxStyle.Critical)
            Me.txtNoRemision.Focus()
            Me.txtNoRemision.SelectAll()
            Exit Sub
        End If

        If Me.cmbcentrocosto.EditValue Is Nothing Then
            MsgBox("Seleccione la Sucursal", MsgBoxStyle.Information)
            Me.cmbcentrocosto.Focus()
            Exit Sub
        End If

        If Me.cmbclientes.EditValue Is Nothing Then
            MsgBox("Seleccione el Cliente", MsgBoxStyle.Information)
            Me.cmbclientes.Focus()
            Exit Sub
        End If

        If Me.vDatos.DataRowCount = 0 Then
            MsgBox("Ingrese al Menos 1 Prodcuto", MsgBoxStyle.Information)
            Me.vDatos.Focus()
            Exit Sub
        End If

        Encabezado()    '' Estructura de Datos
        Trans_H.ins_Remisiones(Estr_H)

        If ClComun.MensajeError = "" Then
            If Detalle() Then
                'Dim ds As New DataSet
                'ds.Tables.Add(ObtieneDatos("sp_rptRemision " & Me.txtNoRemision.EditValue & "," & EmpresaActual))
                'ds.WriteXml(Application.StartupPath & "\xml\rptRemision.xml", XmlWriteMode.WriteSchema)
                My.Forms.frmRemisiones.Cargar()
                Me.Close()
            End If
        Else
            MsgBox(ClComun.MensajeError)
        End If
    End Sub

    Sub Encabezado()
        With Estr_H
            .Empresa = EmpresaActual
            .Remision = Me.txtNoRemision.EditValue
            .Fecha = fecha.DateTime.Date
            .Sucursal = Me.cmbcentrocosto.EditValue
            .Cliente = Me.cmbclientes.EditValue
            .Transaportista = Me.txtTransportisat.Text
            .Conductor = Me.txtConductor.Text
            .NoPlaca = Me.txtPlaca.Text
            .Orden = IIf(Me.txtNoOrden.Text.Trim.Length = 0, 0, Me.txtNoOrden.EditValue)
            .Traslado = IIf(Me.txtTraslado.Text.Trim.Length = 0, 0, Me.txtTraslado.EditValue)
        End With
    End Sub

    Function Detalle() As Boolean
        For i As Integer = 0 To DT_Facturas.Rows.Count - 1
            With Estr_D
                .Empresa = EmpresaActual
                .Remision = Me.txtNoRemision.EditValue
                .Item = DT_Facturas.Rows.Item(i)("Item")
                .Cantidad = DT_Facturas.Rows.Item(i)("Cantidad")
                .Precio = DT_Facturas.Rows.Item(i)("Precio")
                .IVA = IsNull(DT_Facturas.Rows.Item(i)("IVA"), 0)
                .SubTotal = DT_Facturas.Rows.Item(i)("Total")

                Trans_D.ins_Remisiones_Lineas(Estr_D)

                If ClComun.MensajeError <> "" Then
                    MsgBox(ClComun.MensajeError)
                    Return False
                    Exit For
                End If
            End With
        Next

        Return True
    End Function


    Private Sub txtNoRemision_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNoRemision.Validating
        If ObtieneDatos("SELECT * FROM Remisiones r WHERE r.Remision = " & Me.txtNoRemision.EditValue & " AND r.Empresa = " & EmpresaActual).Rows.Count > 0 Then
            MsgBox("El Número de Remisión ya fue Ingresado", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnBuscarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarOrden.Click
        My.Forms.frmOrdenesEntregaLista.ShowDialog()
        My.Forms.frmOrdenesEntregaLista.Dispose()
    End Sub

    Private Sub btnBuscarTraslado_Click(sender As Object, e As EventArgs) Handles btnBuscarTraslado.Click

    End Sub
End Class