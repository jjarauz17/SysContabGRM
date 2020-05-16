Public Class frmRecibosxFactura 

    Public Factura As String = ""
    Public OK As String = "NO"


    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        OK = "NO"
        Close()
    End Sub

    Private Sub frmRecibosxFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridControl1.DataSource = ObtieneDatos("JAR_GetRecibosxFactura", Factura, EmpresaActual)
        GridView1.PopulateColumns()
        FormatoGrid(GridView1)
        ''
        GridView1.BestFitColumns()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        frmExportarImprimir.Mostrar(GridControl1)
    End Sub
End Class