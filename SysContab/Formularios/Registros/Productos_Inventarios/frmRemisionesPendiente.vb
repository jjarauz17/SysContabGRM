Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class frmRemisionesPendiente

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnDiseno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiseno.Click
        Dim forma As New FrmConfiguraCheque

        forma.Tipo = 10
        forma.Text = "Diseño de Remisiones de Bodega"
        forma.Show()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.iVista.DataRowCount = 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.iVista.FocusedRowHandle < 0 Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Information)
            Exit Sub
        End If


        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        Try
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 10").Rows(0).Item(0), Byte())

            Temp = True
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\rptRemisiones.repx"

            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()
        Catch ex As Exception
            Temp = False
        End Try

        Dim Rep As XtraReport

        If Temp = True Then
            Rep = XtraReport.FromFile(Application.StartupPath & "\rptRemisiones.repx", True)
        Else
            Rep = New rptRemisiones
        End If

        Rep.DataSource = ObtieneDatos("sp_rptRemision '" & Me.iVista.GetFocusedRowCellValue("NO. Remisión") & "'," & EmpresaActual)

        Rep.ShowPrintMarginsWarning = False
        Rep.BringToFront()
        Rep.ShowRibbonPreview()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        'frmAgregarRemisiones.MdiParent = Me.MdiParent
        'frmAgregarRemisiones.Factura = 0
        'frmAgregarRemisiones.Show()
        'frmAgregarRemisiones.WindowState = FormWindowState.Maximized

        If cbBodegas.EditValue Is Nothing Or cbBodegas.EditValue = "" Then
            XtraMsg("Seleccione Bodega!")
            cbBodegas.Focus()
            Exit Sub
        End If
        '
        ShowSplash("Cargando Remisiones...")
        Cargar()
        HideSplash()
    End Sub

    Private Sub frmRemisiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'RolesDB.UsuarioAcciones(LayoutControl2)

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.EditValue = New DateTime(f.Year, f.Month, 1)
        Hasta.EditValue = f.Date

        GetBodegasxUsuario(cbBodegas)
        Cargar()
        '
        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False)
    End Sub

    Public Sub Cargar()

        Dim DT As DataTable = ObtieneDatos("JAR_RemisionesPendientes", Desde.DateTime.Date, Hasta.DateTime.Date, cbBodegas.EditValue, EmpresaActual)
        iGrid.DataSource = DT

        'Me.iGrid.DataSource = ObtieneDatos("sp_GetRemisionesList " & EmpresaActual)
        'Me.iVista.PopulateColumns()
        'FormatoGrid(Me.iVista)
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub
End Class