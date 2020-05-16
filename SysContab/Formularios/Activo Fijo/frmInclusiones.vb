Public Class frmInclusiones

  

    Private Sub frmInclusiones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargar()

    End Sub

    Private Sub Cargar()
        Dim dt As New DataTable
        dt = VB.SysContab.CatalogoDB.GetListBuscarComboAuxiliar("%", "%", EmpresaActual).Tables("CATALOGO")
        cbActivo.DataSource = dt
        cbActivo.ValueMember = "CUENTA"
        cbActivo.DisplayMember = "NOMBRE"

        cbInventario.DataSource = dt
        cbInventario.ValueMember = "CUENTA"
        cbInventario.DisplayMember = "NOMBRE"

        Me.GridControl1.DataSource = VB.SysContab.Articulos_AFijoDB.GetActivosContabilizar("0")
        Me.vLista.BestFitColumns()
        Me.vLista.Columns("codigo_activo").Caption = "Codigo"
        Me.vLista.Columns("descripcion").Caption = "Descripcion"
        Me.vLista.Columns("fecha_entrada").Caption = "Fecha de Entrada"
        Me.vLista.Columns("Valor_Libros").Caption = "Valor Libros"
        Me.vLista.Columns("Valor_Libros").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vLista.Columns("Valor_Libros").DisplayFormat.FormatString = "n2"
        Me.vLista.Columns("Valor_Libros").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vLista.Columns("Valor_Libros").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vLista.Columns("Depreciado").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vLista.Columns("Depreciado").DisplayFormat.FormatString = "n2"
        Me.vLista.Columns("Depreciado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vLista.Columns("Depreciado").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vLista.Columns("Precio").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vLista.Columns("Precio").DisplayFormat.FormatString = "n2"
        Me.vLista.Columns("Precio").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vLista.Columns("Precio").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vLista.Columns("cta_activo").Caption = "Cuenta de Activo"
        Me.vLista.Columns("cta_activo").ColumnEdit = Me.cbActivo
        Me.vLista.Columns("cta_inventario").Caption = "Cuenta Inventario"
        Me.vLista.Columns("cta_inventario").ColumnEdit = Me.cbInventario

        For i As Integer = 0 To Me.vLista.Columns.Count - 4
            Me.vLista.Columns(i).OptionsColumn.ReadOnly = True
        Next
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub chkContabilizar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkContabilizar.CheckedChanged
        For i As Integer = 0 To Me.vLista.DataRowCount - 1
            Me.vLista.SetRowCellValue(i, "Contabilizar", Me.chkContabilizar.EditValue)
        Next
    End Sub

    Private Sub cmdContabilizar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdContabilizar.Click

        If Me.vLista.DataRowCount = 0 Then
            MsgBox("No hay datos para contabilizar")
            Exit Sub
        End If
        Dim tempdt As DataTable
        Try

            tempdt = Me.GridControl1.DataSource.clone
            For i As Integer = 0 To Me.vLista.DataRowCount - 1
                If Me.vLista.GetRowCellValue(i, "Contabilizar") = True Then
                    tempdt.Rows.Add(Me.vLista.GetDataRow(i).ItemArray)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try



        Dim c As Integer
        c = tempdt.Compute("Count(contabilizar)", "contabilizar = 1 ")
        If c = 0 Then
            MsgBox("No se han seleccionado registros para contabilizar, favor revisar", MsgBoxStyle.Critical, "Sts.Activos")
            Exit Sub
        End If

        c = tempdt.Compute("Count(cta_activo)", "cta_activo= ''  ")
        If c >= 1 Then
            MsgBox("Hay Articulos cuya cuenta de Activos esta en blanco, favor revisar", MsgBoxStyle.Critical, "Sts.Activos")
            Exit Sub
        End If

        c = tempdt.Compute("Count(cta_inventario)", "cta_inventario= ''")
        If c >= 1 Then
            MsgBox("Hay Articulos cuya cuenta de Inventario esta en blanco, favor revisar", MsgBoxStyle.Critical, "Sts.Activos")
            Exit Sub
        End If

        Dim Registro As DataRow
        Dim Comprobante As New DataTable("Comprobante")
        Comprobante.Columns.Add("Cuenta", System.Type.GetType("System.String"))
        Comprobante.Columns.Add("Debitos", System.Type.GetType("System.Decimal"))
        Comprobante.Columns.Add("Creditos", System.Type.GetType("System.Decimal"))
        Comprobante.Columns.Add("Concepto", System.Type.GetType("System.String"))
        Comprobante.Columns.Add("Modificar", System.Type.GetType("System.Boolean"))
        Comprobante.Columns.Add("Codigo", System.Type.GetType("System.String"))


        For i As Integer = 0 To tempdt.Rows.Count - 1
            If tempdt.Rows(i)("cta_activo") <> "" And tempdt.Rows(i)("cta_inventario") <> "" Then

                Registro = Comprobante.NewRow

                Registro(0) = tempdt.Rows(i)("cta_activo")
                Registro(1) = tempdt.Rows(i)("Precio")
                Registro(2) = 0
                Registro(3) = "Activo Codigo " & tempdt.Rows(i)("Codigo_Activo")
                Registro(4) = False
                Registro(5) = tempdt.Rows(i)("Codigo_Activo")

                Comprobante.Rows.Add(Registro)

                Registro = Comprobante.NewRow

                Registro(0) = tempdt.Rows(i)("cta_inventario")
                Registro(1) = 0
                Registro(2) = tempdt.Rows(i)("Precio")
                Registro(3) = "Activo Codigo " & tempdt.Rows(i)("Codigo_Activo")
                Registro(4) = False
                Registro(5) = tempdt.Rows(i)("Codigo_Activo")

                Comprobante.Rows.Add(Registro)

            End If
        Next


        frmInclusion_Contabilizar.Dispose()
        frmInclusion_Contabilizar.Datos = Comprobante
        frmInclusion_Contabilizar.ShowDialog()

        Cargar()
    End Sub


    Private Sub vLista_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles vLista.KeyUp
        If e.KeyCode = Keys.F5 Then
            Cargar()
        End If
    End Sub
End Class