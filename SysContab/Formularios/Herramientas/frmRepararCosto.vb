Public Class frmRepararCosto 

    Private Sub frmRepararCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Sub Cargar()
        Desde.DateTime = VB.SysContab.Rutinas.Fecha().Date.AddMonths(-1)
        Hasta.DateTime = VB.SysContab.Rutinas.Fecha().Date
        '
        'GetTipoMovimientos(cbMovimientos)
        cbCheckTipo.Properties.DataSource = ObtieneDatos("JAR_GetTiposMovimientos " & EmpresaActual)
        cbCheckTipo.Properties.ValueMember = "ID"
        cbCheckTipo.Properties.DisplayMember = "Nombre"
        cbCheckTipo.CheckAll()
        '

        GetBodegasList(cbBodega)


        'Dim Bodega As New VB.SysContab.BodegasDB
        'cbBodega.Properties.DataSource = Bodega.GetList().Tables(0)
        'cbBodega.Properties.ValueMember = "CODIGO"
        'cbBodega.Properties.DisplayMember = "UBICACION"
        cbBodega.CheckAll()

        'GetBodegasList(cmbbodega)
        'cbMovimientos.ItemIndex = 0
        'cmbbodega.ItemIndex = 0
    End Sub

    Private Sub bBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBuscar.Click
        GetData()
    End Sub

    Private Sub bExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Public Sub GetData()
        ShowSplash("Cargando Movimientos...")
        '
        'Dim ds As New DataSet
        'ds = VB.SysContab.RequisasDB.GetList_Requisas("%", Desde.DateTime.Date, "%", Hasta.DateTime.Date)
        dgDatos.DataSource = ObtieneDatos("SET dateformat dmy; EXEC JAR_GetMovimientosProcesados '" & Desde.DateTime.Date & "','" & Hasta.DateTime.Date & "','" & cbCheckTipo.EditValue & "','" & cbBodega.EditValue & "'," & EmpresaActual)
        'GridView1.PopulateColumns()
        'FormatoGrid(Me.vDatos)
        Me.vDatos.Columns("Codigo_Clase").Visible = False
        Me.vDatos.Columns("Nombre_Clase").Visible = False
        Me.vDatos.Columns("mov_id").Visible = False
        Me.vDatos.BestFitColumns()
        '
        HideSplash()
    End Sub

    Private Sub bEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEditar.Click
        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
        End If
        '
        With frmCostoEditar
            .Fecha.DateTime = vDatos.GetFocusedRowCellValue("req_fecha")
            .txtTipo.Text = vDatos.GetFocusedRowCellValue("Tipo")
            .txtMovimiento.Text = vDatos.GetFocusedRowCellValue("mov_nombre")
            .txtBodega.Text = vDatos.GetFocusedRowCellValue("Ubicacion")
            .txtIdMovimiento.Text = vDatos.GetFocusedRowCellValue("req_codigo")
            .IdMovimiento = vDatos.GetFocusedRowCellValue("req_codigo")
            .IdBodega = vDatos.GetFocusedRowCellValue("codigo_Bodega")
            .TipoDocumento = vDatos.GetFocusedRowCellValue("tipo_documento")
            '.TipoDocumento = vDatos.GetFocusedRowCellValue("mov_id")
            .ShowDialog()
            .Dispose()
        End With
    End Sub
End Class