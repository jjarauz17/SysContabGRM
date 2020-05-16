Imports System.Data
Imports System.Data.SqlClient
Imports ClasesBLL
Imports DevExpress.XtraEditors
Imports SysContab.VB.SysContab

Public Class frmAmoritizacionesSelecRpt

    Private Sub frmReportes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Cargar Datos en Combo
        'Me.cbNombre.Properties.DataSource = ObtieneDatos("SELECT 0 Codigo,'--- Seleccione Amortización ---' Nombre UNION SELECT Codigo,Nombre From CatalogoAmortizacion WHERE Empresa = " & EmpresaActual).DefaultView
        'Me.cbNombre.EditValue = 0

        SearchLookUp(cbAmorizaciones, db_CatalogoAmortizacion.Listar(0), "Nombre", "Codigo", 2, 3, 4, 6, 7, 8, 12)

        Me.rgOpciones.EditValue = 1
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        If Me.rgOpciones.EditValue = 1 Then

            If cbAmorizaciones.EditValue Is Nothing Then
                XtraMsg("Seleccione la Amortización")
                Exit Sub
            End If

            Dim rpt As New rptDetalle_Amortizacion
            rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
            '
            AmortizacionesDB.Imprimir(cbAmorizaciones.EditValue, rpt)

            'AmortizacionesDB.ImprimirAmortizacion(cbNombre.EditValue)
            'AmortizacionesDB.CREAR_VISTA_PREVIA(Me.cbNombre.EditValue)
            'My.Forms.frmexportaciongrid.ShowDialog()
            'AmortizacionesDB.IMPRIMIR(My.Forms.frmexportaciongrid.Formato, 1)
        ElseIf rgOpciones.EditValue = 2 Then
            Dim rpt As New rptAmortiza_General
            rpt.pLogo.Image = frmPrincipalRibbon.pLogo.Image
            '
            AmortizacionesDB.ImprimirResumen(rpt)

            ' If AmortizacionesDB.CREAR_XML() Then
            '    '
            '    AmortizacionesDB.IMPRIMIR("Vista", 2)
            '    'frmExportarImprimir.Mostrar(Grid, Me.Text)
            '    'My.Forms.frmexportaciongrid.ShowDialog()
            '    'AmortizacionesDB.IMPRIMIR(My.Forms.frmexportaciongrid.Formato, 2)
            'Else
            '    XtraMsg("No se han encontrado amortizaciones pendientes")
            'End If
        ElseIf rgOpciones.EditValue = 3 Then

        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub rgOpciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgOpciones.SelectedIndexChanged
        If Me.rgOpciones.EditValue = 1 Then
            cbAmorizaciones.Enabled = True
        ElseIf rgOpciones.EditValue = 2 Or rgOpciones.EditValue = 3 Then
            cbAmorizaciones.Enabled = False
        End If
    End Sub
End Class