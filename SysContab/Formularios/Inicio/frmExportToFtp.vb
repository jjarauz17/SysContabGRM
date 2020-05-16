Imports System.IO
Imports System.Net
Imports System.Net.WebRequestMethods

Public Class frmExportToFtp
    Private Sub frmExportToFtp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Sub Cargar()

        iGrid.DataSource = ObtieneDatos("JAR_FacturasVentasCrossTab_ZOHO", EmpresaActual)
        iVista.PopulateColumns()
        FormatoGrid(iVista, 4)

        iVista.ExportToXlsx($"{Application.StartupPath}\xml\ReporteVentasNI.xlsx")

        Exit Sub

        'Using ftp As New Ftp
        '    ftp.ConnectSSL("ftp.facturaelectronica.equipsa.net")
        '    ftp.Login(_dt.Rows.Item(0)("ftpUserName"), _dt.Rows.Item(0)("ftpPassword"))

        '    ftp.ChangeFolder("Zoho")
        '    ftp.Upload(
        '        _dt.Rows.Item(0)("filename"),
        '        $"{Application.StartupPath}\xml\ReporteVentasNI.xlsx")

        '    Dim serverHash As Byte() = client.GetFileHash("report.txt", FtpHashType.CRC)

        '    ftp.Close()
        'End Using

        Dim _dt As DataTable = ObtieneDatos("sp_GetFTPCredendials",
                                            EmpresaActual,
                                            1)

        Dim lf As New Connectivity.LoadFileFtp()
        lf.UploadFTP(
            $"{Application.StartupPath}\xml\ReporteVentasNI.xlsx",
            _dt.Rows.Item(0)("ftpServerIP"),
            _dt.Rows.Item(0)("ftpUserName"),
            _dt.Rows.Item(0)("ftpPassword"))

        Exit Sub


        'lf.FtpUp($"{Application.StartupPath}\xml\ReporteVentasNI.xlsx", _dt)
        'lf.GetFileList("Zoho", _dt)



        'Subir Archivo por FTP
        ' Configurar el Request
        'Dim ElRequest As FtpWebRequest =
        '    DirectCast(WebRequest.Create($"{_dt.Rows.Item(0)("ftpServerIP")}{_dt.Rows.Item(0)("filename")}"), FtpWebRequest)

        Dim ElRequest As FtpWebRequest =
            DirectCast(WebRequest.Create($"{_dt.Rows.Item(0)("ftpServerIP")}{_dt.Rows.Item(0)("filename")}"), FtpWebRequest)

        ElRequest.Credentials = New NetworkCredential(
            _dt.Rows.Item(0)("ftpUserName").ToString(),
            _dt.Rows.Item(0)("ftpPassword").ToString(),
            "facturaelectronica.equipsa.net")
        ElRequest.Method = WebRequestMethods.Ftp.UploadFile

        ' Leer archivo
        'Dim BufferArchivo() As Byte = File.ReadAllBytes($"{Application.StartupPath}\xml\ReporteVentasNI.xlsx")

        ' Subir archivo
        'Dim ElStream As System.IO.Stream = ElRequest.GetRequestStream()
        'ElStream.Write(BufferArchivo, 0, BufferArchivo.Length)
        'ElStream.Close()
        'ElStream.Dispose()



    End Sub

    Sub SubirArchivo()

    End Sub

End Class