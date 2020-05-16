Public Class frmCKAsociarList

    Public Comp_No As Integer = 0, Per_Id As Integer = 0, Mes As Integer = 0, Monto As Double = 0, Fecha As Date, ProveedorID As Integer = 0, IdPago As Integer = 0

    Private Sub frmAsociarPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Buscar()
    End Sub

    Private Sub cmbbancos_EditValueChanged(sender As Object, e As EventArgs) Handles cmbbancos.EditValueChanged
        Try
            Buscar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Buscar()
        Dim Comp As New VB.SysContab.ComprobanteDB()

        dgDatos.DataSource =
            ObtieneDatos("JAR_PagosAnticiposList",
                         EmpresaActual,
                         ProveedorID)
        'Comp.ChequesList(Me.cmbbancos.EditValue, "", "", ProveedorID, "").Tables("Comprobantes").DefaultView
        vDatos.PopulateColumns()
        FormatoGrid(vDatos)
        '        
        vDatos.Columns("Comp_No").Visible = False
        vDatos.Columns("Per_ID").Visible = False
        'vDatos.Columns("No. Cuenta").Visible = False
        vDatos.Columns("Mon_Codigo").Visible = False
        vDatos.Columns("Proveedor").Visible = False
        vDatos.Columns("Imprimir").Visible = False
        'vDatos.Columns("Banco").Visible = False
        vDatos.Columns("MontoC").Visible = False
        vDatos.Columns("IdPago").Visible = False
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If vDatos.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione una Factura")
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de Asociar el Documento No. " & vDatos.GetFocusedRowCellValue("Número").ToString & " a Nombre de: " & vDatos.GetFocusedRowCellValue("Pagar A").ToString & " ?") Then
            Exit Sub
        End If
        '
        Comp_No = vDatos.GetFocusedRowCellValue("Comp_No")
        Per_Id = vDatos.GetFocusedRowCellValue("Per_ID")
        Mes = CDate(vDatos.GetFocusedRowCellValue("Fecha")).Month
        Fecha = vDatos.GetFocusedRowCellValue("Fecha")
        Monto = Math.Round(CDbl(vDatos.GetFocusedRowCellValue("MontoC")), 2)
        IdPago = vDatos.GetFocusedRowCellValue("IdPago")
        '
        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Comp_No = 0
        Close()
    End Sub
End Class