Public Class frmTipoPlantillas
    Private Sub frmTipoPlantillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl2)

        Cargar()
        iVista.PopulateColumns()
        FormatoGrid(iVista)
    End Sub

    Public Sub Cargar()
        iGrid.DataSource = VB.SysContab.PlantillaDB.GetList().Tables("Tablas").DefaultView
    End Sub

    Private Sub frmTipoPlantillas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then Cargar()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click


        Dim f As frmTipoPlantillasAgregar = frmTipoPlantillasAgregar.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Nueva Plantilla Contable"
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro.")
            Exit Sub
        End If
        '
        Dim frm As frmTipoPlantillasAgregarVer = frmTipoPlantillasAgregarVer.Instance()
        frm.Dispose()

        Dim f As frmTipoPlantillasAgregarVer = frmTipoPlantillasAgregarVer.Instance()

        Registro = iVista.GetFocusedRowCellValue("TIPO")

        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Editar Plantilla Contable: " & Registro
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro.")
            Exit Sub
        End If

        Registro = iVista.GetFocusedRowCellValue("TIPO")

        If Not XtraMsg2("Esta Seguro de borrar la Plantilla: " & Registro & " ?") Then
            Exit Sub
        End If

        Try
            VB.SysContab.PlantillaDB.Delete(Registro)
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Exit Sub
        End Try
        '
        XtraMsg("El registro ha sido borrado")
        Cargar()
    End Sub

    Private Sub cmdAyuda_Click(sender As Object, e As EventArgs) Handles cmdAyuda.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Close()
    End Sub
End Class