Public Class frmOtrosCargos
    Private Shared ChildInstance As frmOtrosCargos = Nothing

    Public LiqLoanID As Integer = 0
    Public GastoTipo As Integer = 0
    Public x As Decimal = 0
    Public dt As DataTable


    Public Shared Function Instance() As frmOtrosCargos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmOtrosCargos
        End If
        ChildInstance.BringToFront()
        Return ChildInstance
    End Function

    Private Sub frmOtrosCargos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RepcbGasto.DataSource = ObtieneDatos("SELECT LiqGastoID, GastoNombre,Monto FROM LiquidacionesGastos WHERE Tipo = " & GastoTipo)
        RepcbGasto.ValueMember = "LiqGastoID"
        RepcbGasto.DisplayMember = "GastoNombre"
        dt = ObtieneDatos("SELECT LiqGastoID,GastoMonto as Monto FROM LiquidacionesDetalleGasto WHERE LiqID =" & LiqLoanID)
        GridControl1.DataSource = dt
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        x = GridView1.Columns("Monto").SummaryItem.SummaryValue
        dt.AcceptChanges()
        Close()
    End Sub

    'Private Sub RepcbGasto_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles RepcbGasto.EditValueChanging

    'End Sub
End Class