Imports DevExpress.XtraEditors
Imports System.IO

Public Class frmSoporteAdd

    Public ID As Integer

    Private Sub frmSoporteAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim bits As Byte() = CType(VB.SysContab.ClientesDB.GetImages(ID).Rows(0).Item(0), Byte())
        Dim memorybits As New MemoryStream(bits)
        Dim bitmap As New Bitmap(memorybits)

        PictureEdit1.Image = bitmap
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If RadioGroup1.EditValue = 1 Then PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip
        If RadioGroup1.EditValue = 2 Then PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        If RadioGroup1.EditValue = 3 Then PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchHorizontal
        If RadioGroup1.EditValue = 4 Then PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.StretchVertical
        If RadioGroup1.EditValue = 5 Then PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
    End Sub
End Class