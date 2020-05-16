Imports System.Data
Imports System.Data.SqlClient

Public Class frmRoles

    Private Sub frmRoles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(Me.LayoutControl2)
        ''
        Cargar()
    End Sub

    Public Sub Cargar()
        Me.gridDatos.DataSource = ObtieneDatos("SELECT ID,Nombre,Descripcion FROM REST_Roles").DefaultView
        FormatoGrid(Me.vRoles)
        ''
        Me.vRoles.BestFitColumns()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ShowSplash()
        '
        My.Forms.frmRolesNuevo.MdiParent = Me.MdiParent
        My.Forms.frmRolesNuevo.Rol = 0
        My.Forms.frmRolesNuevo.Show()
        My.Forms.frmRolesNuevo.WindowState = FormWindowState.Maximized
        '
        HideSplash()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Me.vRoles.DataRowCount = 0 Then
            Exit Sub
        End If

        ShowSplash()
        '
        My.Forms.frmRolesNuevo.MdiParent = Me.MdiParent
        My.Forms.frmRolesNuevo.Rol = Me.vRoles.GetFocusedRowCellValue("ID")
        My.Forms.frmRolesNuevo.Nombre = Me.vRoles.GetFocusedRowCellValue("Nombre")
        My.Forms.frmRolesNuevo.Descripcion = Me.vRoles.GetFocusedRowCellValue("Descripcion")
        My.Forms.frmRolesNuevo.Show()
        My.Forms.frmRolesNuevo.WindowState = FormWindowState.Maximized
        '
        HideSplash()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(gridDatos, NombreEmpresaActual & vbCrLf & Me.Text)
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles bClonar.Click
        If vRoles.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro...")
            Exit Sub
        End If
        '

        If Not XtraMsg2("Esta seguro de Clonar este Rol: " & vRoles.GetFocusedRowCellValue("Nombre").ToString & " ?") Then
            Exit Sub
        End If
        '

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Try
            Conn.RemoveParameters()
            Conn.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, vRoles.GetFocusedRowCellValue("ID"))

            Conn.EjecutarComando("JAR_ClonarRol")

            XtraMsg("El Rol se ha Clonado correctamente!")
            Cargar()
        Catch ex As Exception
            XtraMsg("ERROR: " & ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub
End Class