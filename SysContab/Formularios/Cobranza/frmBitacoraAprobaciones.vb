Imports Entities

Public Class frmBitacoraAprobaciones

    Dim dbBitacora As New db_ClientesListaNegraAprobacion

    Private Sub frmBitacoraEnvioEC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f).Date
        '
        Cargar()
        iVista.PopulateColumns()
        '
        FormatoGridNew(iVista, 2, 1)
        iVista.Columns("Id").Visible = False
        iVista.Columns("Descripcion").Visible = False
        iVista.Columns("Aplicado").Visible = False
        iVista.Columns("Registro").Visible = False
    End Sub

    Sub Cargar()
        iGrid.DataSource = dbBitacora.Listar(
            Desde.DateTime.Date,
            Hasta.DateTime.Date,
            EmpresaActual)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then iVista.ShowCustomization()
        If Not CheckEdit1.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub iVista_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Close()
    End Sub
End Class