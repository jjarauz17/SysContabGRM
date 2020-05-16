Imports System.IO
Imports ClasesBLL
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class frmRemisionesCliente

    Dim obj As New Remisiones
    Dim db As New db_Remisiones
    Dim DT_ROL As DataTable

    Private Sub frmDepositosListNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DT_ROL = RolesDB.UsuarioAcciones(LayoutControl2)
        '
        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date
        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f.Date).Date
        '
        Cargar()
        '
        iVista.PopulateColumns()
        FormatoGrid(iVista)

        iVista.Columns("IdRemision").Visible = False
        iVista.Columns("Concepto").Visible = False
        iVista.Columns("Registro").Visible = False
        iVista.Columns("Monto").Visible = False
        iVista.Columns("TCambio").Visible = False
        iVista.Columns("Direccion").Visible = False
        iVista.Columns("Placa").Visible = False
        iVista.Columns("Conductor").Visible = False
        iVista.Columns("Activo").Visible = False
        iVista.Columns("TCambio").Visible = False

        Dim columnCustomer As GridColumn = iVista.Columns("Estado")
        columnCustomer.FilterInfo = New ColumnFilterInfo("[Estado] <> 'Anulada'")
    End Sub

    Public Sub Cargar()
        iGrid.DataSource = db_Remisiones.Listar(0, Desde.DateTime.Date, Hasta.DateTime.Date)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        ShowSplash("Cargando Remisión...")
        Inicio = True
        frmRemisionesClienteAdd.Dispose()
        frmRemisionesClienteAdd.MdiParent = Me.MdiParent
        frmRemisionesClienteAdd.IdRemision = 0
        frmRemisionesClienteAdd.Text = "Nueva Remisión"
        frmRemisionesClienteAdd.DT_ROL = DT_ROL
        frmRemisionesClienteAdd.Show()
        frmRemisionesClienteAdd.WindowState = FormWindowState.Maximized
        Inicio = False
        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click

        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        ShowSplash("Cargando Remisión...")
        Inicio = False
        frmRemisionesClienteAdd.Dispose()
        frmRemisionesClienteAdd.MdiParent = Me.MdiParent
        frmRemisionesClienteAdd.IdRemision = iVista.GetFocusedRowCellValue("IdRemision")
        frmRemisionesClienteAdd.Text = "Editar Remisión"
        frmRemisionesClienteAdd.DT_ROL = DT_ROL
        frmRemisionesClienteAdd.Show()
        frmRemisionesClienteAdd.WindowState = FormWindowState.Maximized
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

        If iVista.GetFocusedRowCellValue("Estado") <> "Pendiente" Then
            XtraMsg("La Orden de Entrega se encuentra en estado " + iVista.GetFocusedRowCellValue("Estado").ToString.ToUpper + ", No puede ser Anulada.", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Traslado") Then
            XtraMsg("Esta Remisión ya contiene un traslado Generado!", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de Anular esta Remisión No. " + iVista.GetFocusedRowCellValue("NoRemision").ToString) Then
            Exit Sub
        End If
        '
        obj.IdRemision = iVista.GetFocusedRowCellValue("IdRemision")
        db.Borrar(obj)

        'XtraMsg("La Orden de Entrega ha sido Anulada.")
        Cargar()
    End Sub

    'Private Sub SimpleButton5_Click(sender As Object, e As EventArgs)
    '    If iVista.FocusedRowHandle < 0 Then
    '        XtraMsg("Seleccione un registro!")
    '        Exit Sub
    '    End If
    '    '
    '    If Not iVista.GetFocusedRowCellValue("Autorizada") Then
    '        XtraMsg("La Orden de Entrega no se encuentra Autorizada!", MessageBoxIcon.Warning)
    '        Exit Sub
    '    End If
    '    '
    '    If iVista.GetFocusedRowCellValue("Estado") = "Pendiente" Or iVista.GetFocusedRowCellValue("Estado") = "Anulada" Then
    '        XtraMsg("La Orden de Entrega se encuentra en estado " + iVista.GetFocusedRowCellValue("Estado").ToString.ToUpper +
    '                ",  No puede ser convertida en Remisión.", MessageBoxIcon.Error)
    '        Exit Sub
    '    End If

    '    If iVista.GetFocusedRowCellValue("Entrega") = "Entregada" Then
    '        XtraMsg("La Orden de Entrega ya ha sido entregada en su totalidad.", MessageBoxIcon.Warning)
    '        Exit Sub
    '    End If

    '    'ShowSplash("Cargando Orden...")
    '    'frmOrdenesEntregaRemision.Dispose()
    '    With frmOrdenesEntregaRemision
    '        '.MdiParent = Me.MdiParent
    '        .IdOrden = iVista.GetFocusedRowCellValue("IdOrden")
    '        .Text = "Entregar Orden"
    '        .ShowDialog()
    '        '.WindowState = FormWindowState.Maximized
    '    End With
    '    HideSplash()

    'End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles cmdAyuda.Click
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
                e.Appearance.ForeColor = Color.Salmon
            End If
            '
            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Facturada" Then
                e.Appearance.ForeColor = Color.DarkGreen
            End If
            '
            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Anulada" Then
                e.Appearance.ForeColor = Color.Red
            End If
            '
            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "En Proyecto" Then
                e.Appearance.ForeColor = Color.Green
            End If

            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "O / T" Then
                e.Appearance.ForeColor = Color.Navy
            End If
        End If

        If e.Column.FieldName = "Contabilizado" Then
            If iVista.GetRowCellValue(e.RowHandle, "Contabilizado") Then
                e.Appearance.ForeColor = Color.HotPink
            End If
        End If
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        Imprimir(iVista.GetFocusedRowCellValue("IdRemision"))
    End Sub

    Sub Imprimir(IdRemision As Integer)
        ShowSplash("Imprimiendo...")

        'Dim Cadena As String
        'Dim Temp As Boolean = False
        'Dim Data() As Byte

        'Try
        '    Data = CType(ObtieneDatos("sp_get_formato_imprimir", 10, EmpresaActual).Rows(0).Item(0), Byte())
        '    Temp = True
        '    '
        '    Dim Tamano As Integer
        '    Tamano = Data.GetUpperBound(0)
        '    Cadena = Application.StartupPath & "\rptOrdenEntrega.repx"
        '    If File.Exists(Cadena) Then Kill(Cadena)
        '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        '    Archivo.Write(Data, 0, Tamano)
        '    Archivo.Close()

        'Catch ex As Exception
        '    Temp = False
        'End Try

        Dim Temp As Boolean = db_Formatos.FormatoImpreso(10, "rptRemisiones")

        Dim rpt As rptRemisiones

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptRemisiones.repx", True)
        Else
            rpt = New rptRemisiones
        End If

        Dim obj As New Remisiones
        obj = db_Remisiones.Detalles(IdRemision)

        rpt.DT_ROL = DT_ROL
        rpt.IdSucursal = obj.Sucursal

        'rpt.DataSource = db_Remisiones.Imprimir(IdRemision)
        VistaPreviaDX(rpt, db_Remisiones.Imprimir(IdRemision), "Remisión de Bodega No. " & obj.NoRemision)
        HideSplash()

        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        ''
        'HideSplash()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ShowSplash()
        Cargar()
        HideSplash()
    End Sub

    Private Sub bTraslado_Click(sender As Object, e As EventArgs) Handles bTraslado.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Estado") = "Anulada" Then
            XtraMsg("La Remision se encuentra en estado de Anulada*", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If iVista.GetFocusedRowCellValue("Traslado") Then
            If Not XtraMsg2("Esta Remision ya fue generado su traslado, Desea Continuar  de todas formas ?") Then
                Exit Sub
            End If
        End If
        '
        With frmOrdenesEntregaRemision
            .IdRemision = iVista.GetFocusedRowCellValue("IdRemision")
            .NoRemision = iVista.GetFocusedRowCellValue("NoRemision")
            .Text = "Traslado Entre Bodegas"
            .rTipo.Properties.Items(0).Enabled = False
            .rTipo.EditValue = 2
            .txtOrden.Properties.ReadOnly = False
            .ShowDialog()
            .Dispose()
        End With

        'Dim ValorCelda As String = iVista.GetRowCellValue(iVista.FocusedRowHandle, "Nombre del Campo")
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles bGenerarMovimiento.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Estado") = "Anulada" Then
            XtraMsg("La Remision se encuentra en estado de Anulada*", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If iVista.GetFocusedRowCellValue("Estado") = "Facturada" Then
            XtraMsg("La Remision se encuentra facturada.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Estado") = "En Proyecto" Then
            XtraMsg("La Remisión seleccionada ya fue generada como proyecto.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        With frmGuardarMovimiento
            .IdRemision = iVista.GetFocusedRowCellValue("IdRemision")
            .NoRemision = iVista.GetFocusedRowCellValue("NoRemision")
            .Tipo = 4
            '.SimpleButton3.Enabled = False
            .TipoServicio.Properties.Items(0).Description = "Nota de Débito"
            .TipoServicio.Properties.Items(0).Enabled = True
            .TipoServicio.Properties.Items(1).Enabled = False
            .TipoServicio.Properties.Items(2).Enabled = False
            .TipoServicio.EditValue = 1
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub bContabilizar_Click(sender As Object, e As EventArgs) Handles bContabilizar.Click

        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Estado") = "Anulada" Then
            XtraMsg("La Remision se encuentra en estado de Anulada*", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Contabilizado") Then
            XtraMsg("La Remision se encuentra Contabilizada.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '        
        With frmRemisionesContabilizar
            .IdRemision = iVista.GetFocusedRowCellValue("IdRemision")
            .NoRemision = iVista.GetFocusedRowCellValue("NoRemision")
            .Documento.Text = "REM " + iVista.GetFocusedRowCellValue("NoRemision")
            .Fecha.DateTime = iVista.GetFocusedRowCellValue("Fecha")
            .Text = "Contabilizar Remisión # " & iVista.GetFocusedRowCellValue("NoRemision")

            .ShowDialog()
            If .Ok = "SI" Then Cargar()
            .Dispose()
        End With
    End Sub

    Private Sub bGenerarOT_Click(sender As Object, e As EventArgs) Handles bGenerarOT.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Estado") = "Anulada" Then
            XtraMsg("La Remision se encuentra en estado de Anulada*", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If iVista.GetFocusedRowCellValue("Estado") = "Facturada" Then
            XtraMsg("La Remision se encuentra facturada.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Estado") = "En Proyecto" Then
            XtraMsg("La Remisión seleccionada ya fue generada como proyecto.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '

        ShowSplash("")
        '
        frmRemisionesGenerarOT.Dispose()
        '
        With frmRemisionesGenerarOT
            .IdRemision = iVista.GetFocusedRowCellValue("IdRemision")
            .MdiParent = Me.MdiParent
            .Text = "Generar O/T"
            .Show()
            .StartPosition = FormStartPosition.CenterParent
            .WindowState = FormWindowState.Maximized
        End With
        '
        HideSplash()

    End Sub

    Private Sub bReporte_Click(sender As Object, e As EventArgs) Handles bReporte.Click
        ShowSplash()
        frmDinamicoRemisiones.Dispose()
        frmDinamicoRemisiones.MdiParent = Me.MdiParent
        frmDinamicoRemisiones.Text = "Reporte Dinámico de Remisiones"
        frmDinamicoRemisiones.Show()
        frmDinamicoRemisiones.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub
End Class