Imports System.IO
Imports DevExpress.XtraReports.UI
Public Class frmTrasladosBodegasList

    Private Sub frmTrasladosBodegasList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        '
        Desde.DateTime = New DateTime(f.Year, f.Month, 1)
        Hasta.DateTime = f.Date

        Cargar()
        Formato()
    End Sub

    Public Sub Cargar()
        iGrid.DataSource = ObtieneDatos("JAR_MovimientoTrasladosList", Desde.DateTime.Date, Hasta.DateTime.Date, EmpresaActual)
    End Sub

    Sub Formato()

        iVista.PopulateColumns()
        FormatoGrid(iVista, 2, 0, False, False, True)
        '
        iVista.Columns("CODIGO_BODEGA").Visible = False
        iVista.Columns("CODIGO_BODEGAD").Visible = False
        iVista.Columns("Tipo Movimiento").Width = 120
        iVista.Columns("Bodega Origen").Width = 120
        iVista.Columns("Bodega Destino").Width = 120
        iVista.Columns("Usuario").Width = 70
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Dim f As frmBodega_Traslado = frmBodega_Traslado.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Nuevo Traslados de Bodega"
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bImprimir_Click(sender As Object, e As EventArgs) Handles bImprimir.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro", MessageBoxIcon.Information)
            Exit Sub
        End If
        '
        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        ShowSplash("Imprimiendo...")

        Try
            ' Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 25 and Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Data = CType(ObtieneDatos("sp_sel_Bodegas", iVista.GetFocusedRowCellValue("CODIGO_BODEGA"), EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            '
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\rptTraslado.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()
        Catch ex As Exception
            Temp = False
        End Try

        Dim rpt As rptTrasladoBodegas

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptTraslado.repx", True)
        Else
            rpt = New rptTrasladoBodegas
        End If

        rpt.DataSource = ObtieneDatos("JAR_ImprimirTraslado", iVista.GetFocusedRowCellValue("#Entrada"), iVista.GetFocusedRowCellValue("#Salida"), EmpresaActual)
        rpt.ShowPrintMarginsWarning = False
        HideSplash()

        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        rpt.ShowRibbonPreview()
    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Procesado") Then
            XtraMsg("Este Traslado ya fue Procesado, no se puede Borrar", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        'Verificar Cierre del Día
        '---------------------------------------------------------------------
        If Not VerificarCierre(CDate(iVista.GetFocusedRowCellValue("Fecha")).Date) Then
            Exit Sub
        End If
        '-------------------------------------------------------------------
        '
        If Not XtraMsg2("Esta Seguro de Borrar el Traslado Seleccionado?") Then
            Exit Sub
        End If
        '

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()

        Try

            Conn.AddParameter("Entrada", SqlDbType.Int, 5, ParameterDirection.Input, iVista.GetFocusedRowCellValue("#Entrada"))
            Conn.AddParameter("Salida", SqlDbType.Int, 5, ParameterDirection.Input, iVista.GetFocusedRowCellValue("#Salida"))
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.EjecutarComando("JAR_BorrarTraslado")

            Conn.CompletarTransaccion()

            Cargar()
        Catch ex As Exception
            XtraMsg(ex.Message & ". Guardar", MessageBoxIcon.Error)
            Conn.AnularTransaccion()
        End Try

    End Sub

    Private Sub bDiseno_Click(sender As Object, e As EventArgs) Handles bDiseno.Click
        ShowSplash("Cargando Formatos...")
        With frmFormatosTraslados
            .Text = "Diseño de Formatos de Notas de Traslados"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
        HideSplash()


        'With FrmConfiguraCheque
        '    .Tipo = 25
        '    .Show()
        '    .WindowState = FormWindowState.Maximized
        'End With
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Procesado" Then
            If iVista.GetRowCellValue(e.RowHandle, "Procesado") Then
                e.Appearance.BackColor = Color.DarkSalmon
            End If
        End If
    End Sub

    Private Sub bTrasladar_Click(sender As Object, e As EventArgs) Handles bTrasladar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro", MessageBoxIcon.Information)
            Exit Sub
        End If
        '
        With frmGuardarMovimiento
            .IdRequisa_Importar = iVista.GetFocusedRowCellValue("#Entrada")
            .Tipo = 2
            .SimpleButton3.Enabled = False
            .TipoServicio.Properties.Items(1).Enabled = True
            .TipoServicio.Properties.Items(2).Enabled = False
            .ShowDialog()
            .Dispose()
        End With
    End Sub
End Class