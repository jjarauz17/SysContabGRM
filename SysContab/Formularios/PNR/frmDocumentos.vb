Imports System.IO
Public Class frmDocumentos

    Public Codigo As String = 0
    Public NDocumento As String = ""
    Public Tipo As String = "CLIENTES"

    Private Sub frmDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDocumentos()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        SavedImage(Tipo, Codigo)
        CargarDocumentos()
    End Sub

    Sub CargarDocumentos()
        'Cargar Documentos Digitalizados
        iGrid.DataSource = VB.SysContab.ClientesDB.GetDocumentos(Tipo, Codigo)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Documento!")
            Exit Sub
        End If

        frmSoporteAdd.ID = iVista.GetFocusedRowCellValue("IdDocumento")
        frmSoporteAdd.StartPosition = FormStartPosition.CenterParent
        frmSoporteAdd.ShowDialog()
        frmSoporteAdd.Dispose()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Documento!")
            Exit Sub
        End If
        '
        If XtraMsg2("Esta Seguro de Borrar el Documento Seleccionado?") Then
            VB.SysContab.ClientesDB.DeleteImage(iVista.GetFocusedRowCellValue("IdDocumento"))
            CargarDocumentos()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmExportarImprimir.Mostrar(iGrid, "Soportes Digitales: " & NDocumento)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Close()
    End Sub

    Private Sub rLinkAbrir_Click(sender As Object, e As EventArgs) Handles rLinkAbrir.Click
        If iVista.FocusedRowHandle < 0 Then Exit Sub

        VB.SysContab.ClientesDB.AbrirDocumento(iVista.GetFocusedRowCellValue("IdDocumento"), _
                                               iVista.GetFocusedRowCellValue("Documento"))
    End Sub

    Private Sub frmDocumentos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
End Class