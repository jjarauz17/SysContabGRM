Imports System.IO
Imports ClasesBLL
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class frmAnticiposCliente

    Private _Control As String
    Public Property Control() As String
        Get
            Return _Control
        End Get
        Set(ByVal value As String)
            _Control = value
        End Set
    End Property

    Dim obj As New AnticiposClientes
    Dim db As New db_AnticiposClientes
    Dim DT_ROL As DataTable

    Private Sub frmDepositosListNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRol()
        '
        Dim f As Date =
            VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f.Date).Date
        '
        Cargar()
        '
        iVista.PopulateColumns()
        FormatoGrid(iVista)

        iVista.Columns("IdAnticipo").Visible = False
        iVista.Columns("IdCliente").Visible = False
        iVista.Columns("Concepto").Visible = False
        iVista.Columns("Comp_No").Visible = False
        iVista.Columns("Per_Id").Visible = False
        iVista.Columns("Mes").Visible = False
        iVista.Columns("IdNota").Visible = False
        iVista.Columns("Registro").Visible = False

        Dim columnCustomer As GridColumn = iVista.Columns("Estado")
        columnCustomer.FilterInfo = New ColumnFilterInfo("[Estado] <> 'Anulado'")
    End Sub

    Public Sub Cargar()

        iGrid.DataSource =
            db_AnticiposClientes.Listar(
            0,
            Desde.DateTime.Date,
            Hasta.DateTime.Date)

    End Sub

    Sub CargarRol()

        Recurso = RolesDB.GetRecurso(Control)
        DT_ROL = RolesDB.UsuarioAcciones(LayoutControl2)

    End Sub

    Private Sub frmAnticiposCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then CargarRol()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        ShowSplash("Cargando Anticipo...")
        Inicio = True
        frmAnticiposClienteAdd.Dispose()
        frmAnticiposClienteAdd.MdiParent = Me.MdiParent
        frmAnticiposClienteAdd.IdAnticipo = 0
        frmAnticiposClienteAdd.Text = "Nuevo Anticipo"
        frmAnticiposClienteAdd.Show()
        frmAnticiposClienteAdd.WindowState = FormWindowState.Maximized
        Inicio = False
        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click

        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        ShowSplash("Cargando Anticipo...")
        Inicio = True
        frmAnticiposClienteAdd.Dispose()
        frmAnticiposClienteAdd.MdiParent = Me.MdiParent
        frmAnticiposClienteAdd.IdAnticipo = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdAnticipo")
        frmAnticiposClienteAdd.Text = "Editar Anticipo"
        frmAnticiposClienteAdd.Show()
        frmAnticiposClienteAdd.WindowState = FormWindowState.Maximized
        Inicio = False
        HideSplash()
    End Sub

    'Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
    '    If iVista.FocusedRowHandle < 0 Then
    '        XtraMsg("Seleccione un registro!")
    '        Exit Sub
    '    End If

    '    If iVista.GetFocusedRowCellValue("Estado") <> "Pendiente" Then
    '        XtraMsg("La Orden de Entrega se encuentra en estado " + iVista.GetFocusedRowCellValue("Estado").ToString.ToUpper + ", No puede ser Autorizada.", MessageBoxIcon.Warning)
    '        Exit Sub
    '    End If
    '    '
    '    If Not XtraMsg2("Esta Seguro de Autorizar esta Orden de Entrega No. " + iVista.GetFocusedRowCellValue("NoOrden").ToString) Then
    '        Exit Sub
    '    End If
    '    '
    '    obj.IdRemision = iVista.GetFocusedRowCellValue("IdRemision")
    '    db.Autorizar(obj, 1)

    '    'XtraMsg("La Orden de Entrega ha sido autorizada.")
    '    Cargar()
    'End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Estado") = "Anulado" Then
            XtraMsg("El Anticipo se encuentra en estado de Anulado*", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '

        'Verificar Cierre del Día
        '------------------------------------------------------------------------------------
        If Not VerificarCierre(CDate(iVista.GetFocusedRowCellValue("Fecha")).Date) Then
            Exit Sub
        End If
        '-------------------------------------------------------------------------------------


        If iVista.GetFocusedRowCellValue("Estado") = "N / C" Then
            XtraMsg("El Anticipo Seleccionado Ya fue Aplicado como Nota de Crédito a Facturas de Ventas.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de Anular este Anticipo No. " + iVista.GetFocusedRowCellValue("Numero").ToString) Then
            Exit Sub
        End If
        '
        obj.IdAnticipo = iVista.GetFocusedRowCellValue("IdAnticipo")
        db.Borrar(obj)

        'XtraMsg("La Orden de Entrega ha sido Anulada.")
        Cargar()
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then iVista.ShowCustomization()
        If Not CheckEdit1.Checked Then iVista.DestroyCustomization()
    End Sub

    Private Sub iVista_HideCustomizationForm(sender As Object, e As EventArgs) Handles iVista.HideCustomizationForm
        CheckEdit1.Checked = False
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles btnDesign.Click
        ShowSplash("Cargando Formaato...")
        FrmConfiguraCheque.Dispose()
        With FrmConfiguraCheque
            .Tipo = 10
            .Text = "Configurar Formato de Remisiones de Bodega"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
        HideSplash()
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle

        If e.Column.FieldName = "Estado" Then
            e.Appearance.BackColor = Color.LightGray
            e.Appearance.Font = New Font("Tahoma", 8, FontStyle.Bold)
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Pendiente" Then
                e.Appearance.ForeColor = Color.Navy
            End If
            '
            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "N / C" Then
                e.Appearance.ForeColor = Color.DarkGreen
            End If
            '
            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Anulado" Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If

        'If e.Column.FieldName = "Contabilizado" Then
        '    If iVista.GetRowCellValue(e.RowHandle, "Contabilizado") Then
        '        e.Appearance.ForeColor = Color.HotPink
        '    End If
        'End If
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        'ShowSplash("Imprimiendo...")
        VB.SysContab.ComprobanteDB.ImprimirComprobante(iVista.GetFocusedRowCellValue("Comp_No"),
                                                       iVista.GetFocusedRowCellValue("Per_Id"),
                                                       iVista.GetFocusedRowCellValue("Fecha"))
        'HideSplash()
    End Sub


    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Private Sub bTraslado_Click(sender As Object, e As EventArgs) Handles bAplicar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Estado") = "Anulado" Then
            XtraMsg("El Anticipo se encuentra en estado de Anulado.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Pendiente") <= 0.00 Then
            XtraMsg("El Anticipo ya fue aplicado en su Totalidad.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '

        ShowSplash("Cargando Saldos...")
        '
        Inicio = True
        frmAsociarAnticipo.Dispose()
        With frmAsociarAnticipo
            .IdAnticipo = iVista.GetFocusedRowCellValue("IdAnticipo")
            .IdCliente = iVista.GetFocusedRowCellValue("IdCliente")
            .txttotal.EditValue = iVista.GetFocusedRowCellValue("Pendiente")
            .txtTCAnticipo.EditValue = iVista.GetFocusedRowCellValue("TCambio")
            .txtMontoU.EditValue = Math.Round(CDbl(iVista.GetFocusedRowCellValue("Pendiente") / iVista.GetFocusedRowCellValue("TCambio")), 6) 'iVista.GetFocusedRowCellValue("Monto U$")
            .Text = "Asociar Anticipo"
            .MdiParent = Me.MdiParent
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
        Inicio = False
        '
        HideSplash()



        'If iVista.GetFocusedRowCellValue("Traslado") Then
        '    If Not XtraMsg2("Esta Remision ya fue generado su traslado, Desea Continuar  de todas formas ?") Then
        '        Exit Sub
        '    End If
        'End If
        ''
        'With frmOrdenesEntregaRemision
        '    .IdRemision = iVista.GetFocusedRowCellValue("IdRemision")
        '    .Text = "Traslado Entre Bodegas"
        '    .rTipo.Properties.Items(0).Enabled = False
        '    .rTipo.EditValue = 2
        '    .txtOrden.Properties.ReadOnly = False
        '    .ShowDialog()
        '    .Dispose()
        'End With

        'Dim ValorCelda As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Nombre del Campo")

    End Sub

    Private Sub bImprimirNC_Click(sender As Object, e As EventArgs) Handles bImprimirNC.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        ShowSplash("Imprimiendo...")

        Dim Cadena As String, Tamano As Integer
        Dim Temp As Boolean = False
        Dim Data() As Byte

        Try

            Data = CType(ObtieneDatos("sp_get_formato_imprimir", 6, EmpresaActual).Rows(0).Item(0), Byte())
            ' Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 6 And Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\rptNotaDC.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

            Temp = True
        Catch ex As Exception
            Temp = False
        End Try
        '
        Dim rpt As rptNotasProveedores

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptNotaDC.repx", True)
        Else
            rpt = New rptNotasProveedores
        End If
        '
        rpt.DataSource = ObtieneDatos("sp_AnticiposClientesImprimirNC", iVista.GetFocusedRowCellValue("IdAnticipo"),
                                      VB.SysContab.Rutinas.Letras(iVista.GetFocusedRowCellValue("Monto"), iVista.GetFocusedRowCellValue("Moneda")),
                                      EmpresaActual)

        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        HideSplash()
        rpt.ShowRibbonPreview()
    End Sub

    Private Sub bImprimirRecibo_Click(sender As Object, e As EventArgs) Handles bImprimirRecibo.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        VB.SysContab.ClientesDB.ImprimirReciboAnticipo(iVista.GetFocusedRowCellValue("IdAnticipo"))
    End Sub

    Private Sub bReporteAuxiliar_Click(sender As Object, e As EventArgs) Handles bReporteAuxiliar.Click
        ShowSplash("Generando Reporte...")
        '
        frmAnticiposReporte.Dispose()
        With frmAnticiposReporte
            .MdiParent = Me.MdiParent
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
        '
        HideSplash()
    End Sub
End Class