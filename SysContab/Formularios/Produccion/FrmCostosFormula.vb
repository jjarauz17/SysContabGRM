Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class FrmCostosFormula
    'Public IdSysFormula As New TextBox
    'Private DtElimina As New DataTable
    'Private GuardarGrid As New LibraryClassCommonds.MY_LibraryClassCommonds.Cls_GuardarDesdeXtragrid
    'Private Sub FrmCostosFormula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    DtElimina.Columns.Add("CodCostosProd")
    '    LlenarCombos()
    '    CargarDatosGrid()

    'End Sub

    'Private Sub CmdCerrar_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles CmdCerrar.LinkClicked
    '    Me.Close()
    'End Sub

    'Public Sub CargarDatosGrid()
    '    Application.DoEvents()
    '    Dim dt As New DataTable
    '    dt = ClsDal.ObtieneDatos("exec SP_GetProd_CostosFormula " & IdSysFormula.Text)
    '    If Not dt Is Nothing Then
    '        Datos.DataSource = dt
    '        Me.GridView1.PopulateColumns()
    '        GridView1.Columns.Item("CodConsecutCatCosto").ColumnEdit = CostoRepoitory
    '        GridView1.Columns.Item("mon_codigo").ColumnEdit = MonedaReporitory
    '        GridView1.Columns.Item("CodconsecutTipoCosto").ColumnEdit = CostoValorRepository

    '        GridView1.Columns.Item("IdSysArticulosFormula").Visible = False
    '        GridView1.Columns.Item("CodCostosProd").Visible = False
    '        GridView1.Columns.Item("Empresa").Visible = False


    '        GridView1.Columns.Item("CodConsecutCatCosto").Caption = "Item Costos"
    '        GridView1.Columns.Item("mon_codigo").Caption = "Moneda"
    '        GridView1.Columns.Item("CodconsecutTipoCosto").Caption = "Forma"
    '        GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
    '    End If
    '    EjecutarEliminacionRegistros()
    'End Sub
    'Private Sub EjecutarEliminacionRegistros()
    '    If Not DtElimina.Rows.Count > 0 Then Exit Sub

    '    Dim Dt As New DataTable

    '    For i As Integer = 0 To DtElimina.Rows.Count - 1
    '        Dt = ClsDal.ObtieneDatos(" exec SPRemove_Prod_CostosFormula  @IdSysArticulosFormula = " & DtElimina.Rows(i).Item(0))
    '        If Not Dt Is Nothing Then
    '            If Dt.Rows(0).Item(0).ToString = 1 Then
    '                GridView1.DeleteSelectedRows()

    '            End If
    '            ' MsgBox(Dt.Rows(0).Item(1).ToString, MsgBoxStyle.Information, "Informacion")
    '        End If
    '    Next

    '    DtElimina.Rows.Clear()


    'End Sub


    'Public Sub LlenarCombos()
    '    'Application.DoEvents()

    '    Dim Ht As New Hashtable
    '    Dim CatalogoTxt As New TextBox
    '    Ht.Clear()
    '    CatalogoTxt.Text = Catalogos.Moneda
    '    Ht.Add("@Catalogo", CatalogoTxt.Text)
    '    Ht.Add("@Empresa", EmpresaActual)
    '    clsLlenaCombo.ReturLLenaComboLookupedit("SP_GetCatalogos", Ht, Me.MonedaReporitory, "Codigo", "Nombre", , False)
    '    Ht.Clear()
    '    CatalogoTxt.Text = Catalogos.ListaCostos
    '    Ht.Add("@Catalogo", CatalogoTxt.Text)
    '    Ht.Add("@Empresa", EmpresaActual)
    '    clsLlenaCombo.ReturLLenaComboLookupedit("SP_GetCatalogos", Ht, Me.CostoRepoitory, "Codigo", "Nombre", , False)

    '    Ht.Clear()
    '    CatalogoTxt.Text = Catalogos.ListaValores
    '    Ht.Add("@Catalogo", CatalogoTxt.Text)
    '    Ht.Add("@Empresa", EmpresaActual)
    '    clsLlenaCombo.ReturLLenaComboLookupedit("SP_GetCatalogos", Ht, Me.CostoValorRepository, "Codigo", "Nombre", , False)



    '    CargarDatosGrid()

    'End Sub


    'Private Sub GridView1_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GridView1.InvalidRowException
    '    ' e.ErrorText = "Informacion Requerida"
    '    e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction

    'End Sub

    'Private Sub GridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
    '    Try
    '        Dim view As ColumnView = CType(sender, ColumnView)
    '        Dim column1 As GridColumn = view.Columns("CodConsecutCatCosto")
    '        Dim column2 As GridColumn = view.Columns("mon_codigo")
    '        Dim column3 As GridColumn = view.Columns("Valor")

    '        ' Dim column2 As GridColumn = view.Columns("EndTime")
    '        If IsDBNull(GridView1.GetRowCellValue(e.RowHandle, "CodConsecutCatCosto")) Then
    '            e.Valid = False
    '            view.SetColumnError(column1, "Debe Seleccionar un registro de la lista", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
    '            Exit Sub
    '        End If
    '        If IsDBNull(GridView1.GetRowCellValue(e.RowHandle, "mon_codigo")) Then
    '            e.Valid = False
    '            view.SetColumnError(column2, "Debe Seleccionar un registro de la lista", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
    '            Exit Sub
    '        End If

    '        If IsDBNull(GridView1.GetRowCellValue(e.RowHandle, "CodconsecutTipoCosto")) Then
    '            e.Valid = False
    '            view.SetColumnError(column2, "Debe Seleccionar un registro de la lista", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
    '            Exit Sub
    '        End If

    '        If IsDBNull(GridView1.GetRowCellValue(e.RowHandle, "Valor")) Then
    '            e.Valid = False
    '            view.SetColumnError(column3, "El campo Valor no debe contener valores nulo ni ceros", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
    '            Exit Sub
    '        End If

    '        If GridView1.GetRowCellValue(e.RowHandle, "Valor") <= 0 Then
    '            e.Valid = False
    '            view.SetColumnError(column3, "El campo Valor no debe contener valores negaticos ni ceros", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
    '            Exit Sub
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub CmdEliminarFila_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles CmdEliminarFila.LinkClicked
    '    If Not IsDBNull(GridView1.GetFocusedRowCellValue("CodCostosProd")) Then
    '        Dim Resp As Integer = MsgBox("Se dispone a eliminar un registro que se encuentra guardado en la base datos." & vbCrLf & "Desea Eliminar este registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Registro")
    '        If Resp = vbYes Then
    '            Dim NewRow As DataRow = DtElimina.NewRow()
    '            NewRow("CodCostosProd") = GridView1.GetFocusedRowCellValue("CodCostosProd")
    '            DtElimina.Rows.Add(NewRow)
    '            GridView1.DeleteSelectedRows()
    '        End If

    '    Else
    '        GridView1.DeleteSelectedRows()
    '    End If
    'End Sub

    'Private Sub BtnGuardarDatos_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles BtnGuardarDatos.LinkClicked
    '    Dim Ht As New Hashtable
    '    Ht.Clear()
    '    'Ht.Add("0", "@CodConsecutOrdenMatanza")
    '    'Ht.Add("CodConsecutPesoPie", "@CodConsecutPesoPie")
    '    'Ht.Add("CodOrdenMatanza", "@CodOrdenMatanza")
    '    'Ht.Add("CodAlternoGanaderoEntrada", "@CodGanadero")
    '    'Ht.Add("CodAlternoGanaderoPesada", "@CodAlternoGanadero")
    '    'Ht.Add("Nombre", "@Nombres")
    '    '' Ht.Add("Nombre", "@Apellidos")
    '    'Ht.Add("Lote", "@Lote")
    '    'Ht.Add("FechaPesada", "@FechaPesada")
    '    'Ht.Add("CodSexo", "@CodConsecutClafSexoGanado")
    '    'Ht.Add("TipoClasificacion", "@TipoClasificacion")
    '    'Ht.Add("CantidadGanado", "@CantidadGanado")
    '    'Ht.Add("CantidadReal", "@CantidadGanadoManual")
    '    'Ht.Add("PesoGanado", "@PesoReal")
    '    'Ht.Add("Pesoreal", "@PesoManual")
    '    'Ht.Add(TxtUsuarioId, "@UsuarioId")
    '    'Ht.Add(TxtCodOrdenMatanzaMaestra, "@CodConsecutOrdMatanzaMestra")


    '    Ht.Add("CodCostosProd", "@CodCostosProd")
    '    Ht.Add(TxtEmpresa, "@Empresa")
    '    Ht.Add(IdSysFormula, "@IdSysArticulosFormula")
    '    Ht.Add("CodConsecutCatCosto", "@CodConsecutCatCosto")
    '    Ht.Add("mon_codigo", "@mon_codigo")
    '    Ht.Add("CodconsecutTipoCosto", "@CodconsecutTipoCosto")
    '    Ht.Add("Valor", "@Valor")



    '    If GuardarGrid.GuardaXtraGRID("SP_Guardar_Prod_CostosFormula", Ht, Datos) = True Then
    '        EjecutarEliminacionRegistros()
    '        CargarDatosGrid()
    '        MsgBox("Informacion generada con exito", MsgBoxStyle.Information, "registro de informacion")

    '           End If
    'End Sub

    'Private Sub CostoRepoitory_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles CostoRepoitory.ButtonClick
    '    If e.Button.Index = 1 Then
    '        Using Obj As New FrmCostosProdc
    '            Obj.StartPosition = FormStartPosition.CenterScreen
    '            Obj.ShowDialog()
    '            LlenarCombos()
    '        End Using
    '    End If
    'End Sub
End Class