Imports System.IO

Public Class frmControlVersiones

    Private Sub frmControlVersiones_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Keys.KeyCode = Keys.F2 Then
            bGuardar.Enabled = True
            bGuardar.Focus()
        End If
    End Sub

    Private Sub frmControlVersiones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Keys.KeyCode = Keys.F2 Then
            bGuardar.Enabled = True
            bGuardar.Focus()
        End If
    End Sub

    Private Sub frmControlVersiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Verificar si existe el archivo
        If Not File.Exists(Application.StartupPath & "\versiones.doc") Then
            'Si no existe entonces crear archivo
            File.Create(Application.StartupPath & "\versiones.doc")
        End If
        'Mostrar Archivo
        rVersiones.LoadDocument(Application.StartupPath & "\versiones.doc")
    End Sub

    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
        Try
            'Guardar Cambios
            rVersiones.SaveDocument(Application.StartupPath & "\versiones.doc", DevExpress.XtraRichEdit.DocumentFormat.Doc)
            XtraMsg("Documento Guardado con Exito!")
            rVersiones.LoadDocument(Application.StartupPath & "\versiones.doc")

            bGuardar.Enabled = False
        Catch ex As Exception
            XtraMsg("ERROR: " & ex.Message, MessageBoxIcon.Error)
            bGuardar.Enabled = False
        End Try
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bGuardarComo_Click(sender As Object, e As EventArgs) Handles bGuardarComo.Click
        'Guardar en un Nuevo Archivo
        rVersiones.SaveDocumentAs()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        bGuardar.Enabled = True
        bGuardar.Focus()
    End Sub
End Class