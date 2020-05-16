Public Class frmAuditoria 

    Private Sub frmAuditoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dDesde.DateTime = Now.Date
        dHasta.DateTime = Now.Date
        Combos()
    End Sub

    Sub Combos()
        cbTablas.Properties.DataSource = ObtieneDatos("JAR_AuditoriaFiltros", 1)
        cbTablas.Properties.ValueMember = "Tabla"
        cbTablas.Properties.DisplayMember = "Tabla"
        cbTablas.Properties.PopulateColumns()
        cbTablas.ItemIndex = 0
        '
        cbUsuario.Properties.DataSource = ObtieneDatos("JAR_AuditoriaFiltros", 2)
        cbUsuario.Properties.ValueMember = "Usuario"
        cbUsuario.Properties.DisplayMember = "Usuario"
        cbUsuario.Properties.PopulateColumns()
        cbUsuario.ItemIndex = 0
        '
    End Sub

    Sub Cargar()
        Dim ds As New DataSet
        'Dim dt1, dt2, dt3 As New DataTable

        Dim dt1 As DataTable = ObtieneDatos("JAR_GetAuditoriaMaestro",
                                            dDesde.DateTime.Date,
                                            dHasta.DateTime.Date,
                                            cbTablas.EditValue,
                                            cbUsuario.EditValue)
        dt1.TableName = "Maestro"

        Dim dt2 As DataTable = ObtieneDatos("JAR_GetAuditoriaDetalle",
                                            dDesde.DateTime.Date,
                                            dHasta.DateTime.Date,
                                            cbTablas.EditValue,
                                            cbUsuario.EditValue)
        dt2.TableName = "Detalle"

        ds.Tables.Add(dt1)
        ds.Tables.Add(dt2)
        ds.Relations.Add("Detalle", dt1.Columns("IdAuditoria"), dt2.Columns("IdAuditoria"))

        dgDatos.DataSource = ds.Tables("Maestro")
        dgDatos.ForceInitialize()
        vAuditoria.PopulateColumns()
        '
        FormatoGrid(vAuditoria)

        vAuditoria.Columns("Fecha").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        vAuditoria.Columns("Fecha").DisplayFormat.FormatString = "{0:dd/MM/yyyy}"

        vAuditoria.Columns("Hora").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        vAuditoria.Columns("Hora").DisplayFormat.FormatString = "{0:hh:mm tt}"
    End Sub

    Private Sub bBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBuscar.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Private Sub bExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        Close()
    End Sub
End Class