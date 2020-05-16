Public Class frmRespaldoDB 

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If Not DxValidationProvider1.Validate Then
            Exit Sub
        End If

        Dim f As Date = VB.SysContab.Rutinas.Fecha()

        Me.Guardar.Filter = "Archivos de Respaldo (*.bak)|*.bak"
        Me.Guardar.FileName = "SysSGR_Backup_" + f.ToShortDateString.Replace("/", "").Replace("\", "") + "_" + f.ToShortTimeString.Replace(":", "").Replace(" ", "").Replace(".", "").ToUpper
        If Me.Guardar.ShowDialog = Windows.Forms.DialogResult.OK Then
            ShowSplash()
            If GuardaDatos("SGR_BackupDB '" & txtBase.Text & "','" & Me.Guardar.FileName & "'") Then
                HideSplash()
                etMsg.ForeColor = Color.DarkRed
                etMsg.Text = "Respaldo Creado en: " + Me.Guardar.FileName
            Else
                HideSplash()
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub

    Private Sub frmRespaldoDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        ''
        Dim s As String() = LeeData()

        txtServidor.Text = s(0)
        txtBase.Text = s(1)
    End Sub
End Class