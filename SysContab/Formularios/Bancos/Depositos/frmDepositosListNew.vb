Imports ClasesBLL
Public Class frmDepositosListNew

    Dim obj As New Depositos
    Dim db As New db_Depositos

    Private Sub frmDepositosListNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SearchLookUp(cbBancos, ObtieneDatos("SP_GetCatalogoBancos", EmpresaActual), "Nombre", "Codigo", 0, 4, 5)
        RolesDB.UsuarioAcciones(LayoutControl2)

        Dim f As Date = VB.SysContab.Rutinas.Fecha().Date

        Desde.DateTime = New DateTime(f.Year, f.Month, 1).Date
        Hasta.DateTime = UltimoDiaDelMes(f.Date).Date

        Cargar()
        iVista.PopulateColumns()
        FormatoGrid(iVista)

        iVista.Columns("IdDeposito").Visible = False
        iVista.Columns("Comentario").Visible = False
        iVista.Columns("Fecha_Creacion").Visible = False
        iVista.Columns("Fecha_Modificacion").Visible = False
        iVista.Columns("Usuario_Modificacion").Visible = False
    End Sub

    Sub Cargar()
        iGrid.DataSource = db_Depositos.Listar(0, Desde.DateTime.Date, Hasta.DateTime.Date)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        frmDepositosAdd.Dispose()
        '
        With frmDepositosAdd
            .MdiParent = Me.MdiParent
            .Text = "Crear Deposito"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        frmDepositosAdd.Dispose()
        '
        With frmDepositosAdd
            .MdiParent = Me.MdiParent
            .IdDeposito = iVista.GetRowCellValue(iVista.FocusedRowHandle, "IdDeposito")
            .Text = "Editar Deposito"
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles bVer.Click

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles bAnular.Click

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles bContabilizar.Click

    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(iGrid, Me.Text)
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Close()
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Cargar()
    End Sub
End Class