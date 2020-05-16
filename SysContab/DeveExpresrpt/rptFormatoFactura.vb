Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting.BarCode
Imports DevExpress.XtraReports.UI

Public Class rptFormatoFactura


    Private Sub rptFormatoFactura_AfterPrint(sender As Object, e As EventArgs) Handles Me.AfterPrint
        '  Me.XrPictureBox1.Image = Image.FromFile("D:\Grupo McGregor\SysContab\SysContab\bin\graphics\Customer.png")
    End Sub

    Private Sub rptFormatoFactura_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        'XrBarCode1 = CreateQRCodeBarCode("1572126")
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