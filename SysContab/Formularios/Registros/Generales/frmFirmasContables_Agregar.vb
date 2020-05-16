Public Class frmFirmasContables_Agregar

#Region "Variables"
    Public Cargo As String = ""
    Public Nombre As String = ""
    Public Orden As Integer = 1
    Public Id As Integer = 0
#End Region

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        VB.SysContab.LibrosDB.FirmasContables(txtCargo.Text, txtNombre.Text, spOrden.EditValue, Id)
    End Sub

    Private Sub frmFirmasContables_Agregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtNombre.Text = Me.Nombre
        Me.txtCargo.Text = Me.Cargo
        Me.spOrden.EditValue = Orden
    End Sub
End Class