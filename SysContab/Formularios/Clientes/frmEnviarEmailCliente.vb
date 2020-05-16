Imports System.IO
Imports DevExpress.XtraReports.UI
Public Class frmEnviarEmailCliente

    Public Codigo As Integer = 0
    Dim obj As New CorreoConfig
    Dim DT_CC As New DataTable
    Public IdSucursal As String = ""

    Private Sub frmEnviarEmailCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FechaCorte.DateTime = VB.SysContab.Rutinas.Fecha().Date
        GetMonedasList(cbMoneda)
        'GetMonedas(cbMoneda)
        'cbMoneda.ItemIndex = 0

        '1era Pestaña.
        obj = db_CorreoConfig.Detalles(1, IdSucursal)
        DT_CC = db_CorreoCopia.ListarEnviar(obj.IdCorreo, Codigo)
        iGrid.DataSource = DT_CC
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        ShowSplash("Imprimiendo...")

        Try
            'Dim Datas() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 21 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\rptEstadoCuentaEnviar.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

        Catch ex As Exception
            Temp = False            
        End Try

        Dim rpt As rptEstadoCuentaCliente_Email

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptEstadoCuentaEnviar.repx", True)
        Else
            rpt = New rptEstadoCuentaCliente_Email
        End If

        rpt.DataSource = ObtieneDatos("JAR_EstadoCuentaReporte_EnviarEmail", Codigo, EmpresaActual, FechaCorte.DateTime.Date, cbMoneda.EditValue)
        HideSplash()

        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        rpt.ShowRibbonPreview()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        ShowSplash("Enviando Correo...")

        Try
            'Dim Datas() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 21 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\rptEstadoCuentaEnviar.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

        Catch ex As Exception
            Temp = False
        End Try

        Dim rpt As rptEstadoCuentaCliente_Email

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptEstadoCuentaEnviar.repx", True)
        Else
            rpt = New rptEstadoCuentaCliente_Email
        End If
        '
        Try
            rpt.DataSource = ObtieneDatos("JAR_EstadoCuentaReporte_EnviarEmail",
                                          Codigo,
                                          EmpresaActual,
                                          FechaCorte.DateTime.Date,
                                          cbMoneda.EditValue)

            Dim ClienteDetalle As New VB.SysContab.ClientesDetails
            ClienteDetalle = VB.SysContab.ClientesDB.GetDetails(Codigo)

            If IsNull(ClienteDetalle.Correo, "").ToString.Trim.Length = 0 Then
                XtraMsg("El Cliente :" & ClienteDetalle.Nombre.Trim & " No tiene correo de Envío")
                Exit Sub
            End If

            If IO.File.Exists(Application.StartupPath & "\xml\Estado_Cuenta_" & Replace(Replace(ClienteDetalle.Nombre.Trim, " ", ""), "/", "") & ".pdf") Then
                IO.File.Delete(Application.StartupPath & "\xml\Estado_Cuenta_" & Replace(Replace(ClienteDetalle.Nombre.Trim, " ", ""), "/", "") & ".pdf")
            End If

            rpt.ExportToPdf(Application.StartupPath & "\xml\Estado_Cuenta_" & Replace(Replace(ClienteDetalle.Nombre.Trim, " ", ""), "/", "") & ".pdf")

            Dim db_Mail As New db_EnviarCorreo

            db_Mail.EstadoDeCuenta(
                Application.StartupPath & "\xml\Estado_Cuenta_" & Replace(Replace(ClienteDetalle.Nombre.Trim, " ", ""), "/", "") & ".pdf",
                ClienteDetalle.Correo,
                FechaCorte.DateTime.Date,
                "Estado de Cuenta " & Replace(Replace(ClienteDetalle.Nombre.Trim, " ", ""), "/", ""),
                ClienteDetalle.Nombre,
                DT_CC,
                IdSucursal)
        Catch ex As Exception
            XtraMsg(ex.Message)
        End Try


        HideSplash()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub

    Private Sub iVista_KeyDown(sender As Object, e As KeyEventArgs) Handles iVista.KeyDown
        'If iVista.FocusedRowHandle < 0 Then Exit Sub
        'If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Admin") Then Exit Sub

        'If e.KeyCode = Keys.Delete Then
        '    iVista.DeleteSelectedRows()
        '    iVista.RefreshData()
        'End If
    End Sub

    Private Sub iVista_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles iVista.ShowingEditor
        If iVista.GetRowCellValue(iVista.FocusedRowHandle, "Admin") Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmEnviarEmailCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Close()
    End Sub
End Class