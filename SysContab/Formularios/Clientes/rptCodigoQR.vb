Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting.BarCode
Imports DevExpress.XtraReports.UI

Public Class rptCodigoQR
    Private Sub rptCodigoQR_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        Me.Detail.Controls.Add(CreateQRCodeBarCode("012345678"))
    End Sub

    Public Function CreateQRCodeBarCode(ByVal BarCodeText As String) As XRBarCode
        ' Create a bar code control.
        Dim barCode As New XRBarCode()

        ' Set the bar code's type to QRCode.
        barCode.Symbology = New QRCodeGenerator()

        ' Adjust the bar code's main properties.
        barCode.Text = BarCodeText
        barCode.Width = 400
        barCode.Height = 150

        ' If the AutoModule property is set to false, uncomment the next line.
        barCode.AutoModule = True
        ' barcode.Module = 3;

        ' Adjust the properties specific to the bar code type.
        CType(barCode.Symbology, QRCodeGenerator).CompactionMode = QRCodeCompactionMode.AlphaNumeric
        CType(barCode.Symbology, QRCodeGenerator).ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.H
        CType(barCode.Symbology, QRCodeGenerator).Version = QRCodeVersion.AutoVersion

        Return barCode
    End Function

End Class