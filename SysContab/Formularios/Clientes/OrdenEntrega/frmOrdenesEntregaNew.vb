Imports System.IO
Imports ClasesBLL
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Public Class frmOrdenesEntregaNew

    Dim obj As New OrdenesEntrega
    Dim db As New db_OrdenesEntrega
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

        iVista.Columns("IdOrden").Visible = False
        iVista.Columns("Concepto").Visible = False
        iVista.Columns("Registro").Visible = False
        iVista.Columns("Moneda").Visible = False
        iVista.Columns("Monto").Visible = False
        iVista.Columns("TCambio").Visible = False
        iVista.Columns("Direccion").Visible = False
        iVista.Columns("Placa").Visible = False
        iVista.Columns("Conductor").Visible = False

        Dim columnCustomer As GridColumn = iVista.Columns("Estado")
        columnCustomer.FilterInfo = New ColumnFilterInfo("[Estado] <> 'Anulada'")
    End Sub

    Public Sub Cargar()
        iGrid.DataSource =
            db_OrdenesEntrega.Listar(
            0,
            Desde.DateTime.Date,
            Hasta.DateTime.Date)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        ShowSplash("Cargando Orden...")
        Inicio = True
        frmOrdenesEntregaAdd.Dispose()
        frmOrdenesEntregaAdd.MdiParent = Me.MdiParent
        frmOrdenesEntregaAdd.IdOrden = 0
        frmOrdenesEntregaAdd.Text = "Nueva Orden de Entrega"
        frmOrdenesEntregaAdd.DT_ROL = DT_ROL
        frmOrdenesEntregaAdd.Show()
        frmOrdenesEntregaAdd.WindowState = FormWindowState.Maximized
        Inicio = False
        HideSplash()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click

        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        ShowSplash("Cargando Orden...")
        Inicio = True
        frmOrdenesEntregaAdd.Dispose()
        frmOrdenesEntregaAdd.MdiParent = Me.MdiParent
        frmOrdenesEntregaAdd.IdOrden = iVista.GetFocusedRowCellValue("IdOrden")
        frmOrdenesEntregaAdd.Text = "Editar Orden de Entrega"
        frmOrdenesEntregaAdd.DT_ROL = DT_ROL
        frmOrdenesEntregaAdd.Show()
        frmOrdenesEntregaAdd.WindowState = FormWindowState.Maximized
        Inicio = False
        HideSplash()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles bAutorizar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Estado") <> "Pendiente" Then
            XtraMsg("La Orden de Entrega se encuentra en estado " + iVista.GetFocusedRowCellValue("Estado").ToString.ToUpper + ", No puede ser Autorizada.", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If EmpresaActual = 1 Then
            Dim DT_OT As DataTable = db_OrdenesEntregaDetalle.Listar(iVista.GetFocusedRowCellValue("IdOrden"))

            Dim dr_fisico() As DataRow = DT_OT.Select("Fisico = 0.00")

            If dr_fisico.Length > 0 Then
                XtraMsg("Existe " & dr_fisico.Length.ToString & " Producto(s) sin Existencia Fisica, favor ingresar Fisico para aprobar", MessageBoxIcon.Warning)
                Exit Sub
            End If

        End If


        If Not XtraMsg2("Esta Seguro de Autorizar esta Orden de Entrega No. " + iVista.GetFocusedRowCellValue("NoOrden").ToString) Then
            Exit Sub
        End If
        '
        obj.IdOrden = iVista.GetFocusedRowCellValue("IdOrden")
        db.Autorizar(obj, 1)

        'XtraMsg("La Orden de Entrega ha sido autorizada.")
        Cargar()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Entrega") <> "Pendiente" Then
            XtraMsg("La Orden de Entrega se encuentra en estado " + iVista.GetFocusedRowCellValue("Entrega").ToString.ToUpper + ", No puede ser Anulada.", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Estado") = "Anulada" Then
            XtraMsg("La Orden de Entrega se encuentra en estado " + iVista.GetFocusedRowCellValue("Estado").ToString.ToUpper + ", No puede ser Anulada.", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If Not XtraMsg2("Esta Seguro de Anular esta Orden de Entrega No. " + iVista.GetFocusedRowCellValue("NoOrden").ToString) Then
            Exit Sub
        End If
        '
        obj.IdOrden = iVista.GetFocusedRowCellValue("IdOrden")
        db.Borrar(obj)

        'XtraMsg("La Orden de Entrega ha sido Anulada.")
        Cargar()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles bARemsion.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        If Not iVista.GetFocusedRowCellValue("Autorizada") Then
            XtraMsg("La Orden de Entrega no se encuentra Autorizada!", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Estado") = "Pendiente" Or iVista.GetFocusedRowCellValue("Estado") = "Anulada" Then
            XtraMsg("La Orden de Entrega se encuentra en estado " + iVista.GetFocusedRowCellValue("Estado").ToString.ToUpper +
                    ",  No puede ser convertida en Remisión.", MessageBoxIcon.Error)
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Entrega") = "Entregada" Then
            XtraMsg("La Orden de Entrega ya ha sido entregada en su totalidad.", MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim msg As String = db_OrdenesEntrega.ValidarProductosNuevos(iVista.GetFocusedRowCellValue("IdOrden"))

        If msg <> "Ok" Then
            XtraMsg(msg, MessageBoxIcon.Error)
            Exit Sub
        End If

        'ShowSplash("Cargando Orden...")
        'frmOrdenesEntregaRemision.Dispose()
        With frmOrdenesEntregaRemision
            '.MdiParent = Me.MdiParent
            .IdOrden = iVista.GetFocusedRowCellValue("IdOrden")
            .Text = "Entregar Orden"
            .ShowDialog()
            '.WindowState = FormWindowState.Maximized
            .Dispose()
        End With
        ' HideSplash()

    End Sub

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
        With FrmConfiguraCheque
            .Tipo = 12
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Estado" Then
            e.Appearance.Font = New Font("Tahoma", 8, FontStyle.Bold)
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Pendiente" Then
                e.Appearance.ForeColor = Color.Salmon
                e.Appearance.BackColor = Color.LightGray
            End If
            '
            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Autorizada" Then
                e.Appearance.ForeColor = Color.DarkGreen
                e.Appearance.BackColor = Color.LightGray
            End If
            '
            If iVista.GetRowCellValue(e.RowHandle, "Estado") = "Anulada" Then
                e.Appearance.ForeColor = Color.Red
                e.Appearance.BackColor = Color.Gray
            End If
        End If
        '
        If e.Column.FieldName = "Entrega" Then
            e.Appearance.BackColor = Color.LightCyan
            e.Appearance.Font = New Font("Tahoma", 8, FontStyle.Bold)
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

            If iVista.GetRowCellValue(e.RowHandle, "Entrega") = "Anulada" Then e.Appearance.ForeColor = Color.Red
            If iVista.GetRowCellValue(e.RowHandle, "Entrega") = "Pendiente" Then e.Appearance.ForeColor = Color.Salmon

            If iVista.GetRowCellValue(e.RowHandle, "Entrega") = "Entregada" Or
               iVista.GetRowCellValue(e.RowHandle, "Entrega") = "Parcial" Then
                e.Appearance.ForeColor = Color.DarkGreen
            End If
        End If
        '
        If e.Column.FieldName = "Autorizada" Then
            If Not iVista.GetRowCellValue(e.RowHandle, "Autorizada") Then e.Appearance.BackColor = Color.Salmon
            If iVista.GetRowCellValue(e.RowHandle, "Autorizada") Then e.Appearance.BackColor = Color.Green
        End If
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        Imprimir(iVista.GetFocusedRowCellValue("IdOrden"))
    End Sub

    Sub Imprimir(IdOrden As Integer)
        ShowSplash("Imprimiendo...")

        'Dim Cadena As String
        'Dim Temp As Boolean = False
        'Dim Data() As Byte

        'Try
        '    Data = CType(ObtieneDatos("sp_get_formato_imprimir", 12, EmpresaA).Rows(0).Item(0), Byte())
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

        Dim Temp As Boolean = db_Formatos.FormatoImpreso(12, "rptOrdenEntrega")

        Dim rpt As rptOrdenEntrega

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptOrdenEntrega.repx", True)
        Else
            rpt = New rptOrdenEntrega
        End If

        ' rpt.DataSource = db_OrdenesEntrega.Imprimir(IdOrden)    'ObtieneDatos("sp_sel_OrdenesEntrega_Imprimir", IdOrden, EmpresaActual)

        VistaPreviaDX(rpt, db_OrdenesEntrega.Imprimir(IdOrden), "Orden de Entrega No. " & iVista.GetFocusedRowCellValue("NoOrden"))
        HideSplash()

        'rpt.ShowPrintMarginsWarning = False
        'rpt.BringToFront()
        ''
        'HideSplash()
        'rpt.ShowRibbonPreview()
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Cargar()
    End Sub
End Class