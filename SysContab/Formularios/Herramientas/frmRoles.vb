Imports System.Data
Imports System.Data.SqlClient
Imports Entities

Public Class frmRoles

    Dim rol As New Roles,
        db_rol As New db_Roles

    Private Sub frmRoles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(Me.LayoutControl2)
        ''
        Cargar()
        '
        vRoles.PopulateColumns()
        FormatoGridNew(vRoles, 2, 1)
        vRoles.Columns("ID").Visible = False
    End Sub

    Public Sub Cargar()
        Me.gridDatos.DataSource = db_rol.Listar(0)
        'ObtieneDatos("SELECT ID,Nombre,Descripcion FROM REST_Roles").DefaultView
        'Me.vRoles.BetFitColumns()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ShowSplash()
        '
        My.Forms.frmRolesNuevo.Dispose()
        My.Forms.frmRolesNuevo.MdiParent = Me.MdiParent
        My.Forms.frmRolesNuevo.ID = 0
        My.Forms.frmRolesNuevo.Text = "Nuevo Rol de Usuario"
        My.Forms.frmRolesNuevo.Show()
        My.Forms.frmRolesNuevo.WindowState = FormWindowState.Maximized
        '
        HideSplash()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If vRoles.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        ShowSplash()
        '
        My.Forms.frmRolesNuevo.Dispose()
        My.Forms.frmRolesNuevo.MdiParent = Me.MdiParent
        My.Forms.frmRolesNuevo.ID = Me.vRoles.GetFocusedRowCellValue("ID")
        My.Forms.frmRolesNuevo.Text = "Editar Rol de Usuario"
        'My.Forms.frmRolesNuevo.Nombre = Me.vRoles.GetFocusedRowCellValue("Nombre")
        'My.Forms.frmRolesNuevo.Descripcion = Me.vRoles.GetFocusedRowCellValue("Descripcion")
        My.Forms.frmRolesNuevo.Show()
        My.Forms.frmRolesNuevo.WindowState = FormWindowState.Maximized
        '
        HideSplash()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If vRoles.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        Dim _dt As DataTable = db_rol.UsuariosRoles(vRoles.GetFocusedRowCellValue("ID"))

        If _dt.Rows.Count > 0 Then
            XtraMsg($"El Rol {vRoles.GetFocusedRowCellValue("Nombre")} contiene {_dt.Rows.Count.ToString()} usuarios asignados.",
                    MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If Not XtraMsg2($"Esta Seguro de Borrar el Rol {vRoles.GetFocusedRowCellValue("Nombre").ToString.ToUpper()} ?") Then
            Exit Sub
        End If
        '
        Dim RolesMenu As New REST_RolesMenu,
            RolesRecursos As New REST_RolesRecursos,
            RolesAcciones As New REST_RolesAcciones,
            db_RolesMenu As New db_REST_RolesMenu,
            db_RolesRecursos As New db_REST_RolesRecursos,
            db_RolesAcciones As New db_REST_RolesAcciones

        Dim ID As Integer = vRoles.GetFocusedRowCellValue("ID")

        rol.ID = ID
        RolesMenu.Rol_Id = ID
        RolesRecursos.Rol_Id = ID
        RolesAcciones.Rol_Id = ID

        db_RolesMenu.Borrar(RolesMenu)
        db_RolesRecursos.Borrar(RolesRecursos)
        db_RolesAcciones.Borrar(RolesAcciones)
        db_rol.Borrar(rol)

        Cargar()
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
        If Not XtraMsg2($"Esta seguro de Clonar este Rol: {vRoles.GetFocusedRowCellValue("Nombre")} ?") Then
            Exit Sub
        End If
        '
        rol.ID = vRoles.GetFocusedRowCellValue("ID")
        If db_rol.Clonar(rol) Then
            XtraMsg("El Rol se ha Clonado correctamente!")
            Cargar()
        End If

        'Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        'Try
        '    Conn.RemoveParameters()
        '    Conn.AddParameter("ID", SqlDbType.Int, 5, ParameterDirection.Input, vRoles.GetFocusedRowCellValue("ID"))

        '    Conn.EjecutarComando("JAR_ClonarRol")

        '    XtraMsg("El Rol se ha Clonado correctamente!")
        '    Cargar()
        'Catch ex As Exception
        '    XtraMsg("ERROR: " & ex.Message, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub vRoles_KeyDown(sender As Object, e As KeyEventArgs) Handles vRoles.KeyDown
        If e.KeyCode = Keys.F5 Then Cargar()
    End Sub

    Private Sub vRoles_DoubleClick(sender As Object, e As EventArgs) Handles vRoles.DoubleClick
        If vRoles.FocusedRowHandle < 0 Then Exit Sub
        '
        Dim obj As Object = vRoles.GetFocusedValue,
            sRoles As String = String.Empty

        If IsNumeric(obj) Then
            Dim _dt As DataTable = db_rol.UsuariosRoles(vRoles.GetFocusedRowCellValue("ID"))

            If _dt.Rows.Count = 0 Then
                XtraMsg($"El Rol {vRoles.GetFocusedRowCellValue("Nombre").ToString.ToUpper} no contiene usuarios asignados")
            Else
                For i As Integer = 0 To _dt.Rows.Count - 1
                    sRoles = sRoles + $"Login: {_dt.Rows.Item(i)("Login").ToString.ToUpper}, Nombre: {_dt.Rows.Item(i)("Nombre").ToString.ToUpper}, Activo = {_dt.Rows.Item(i)("Activo")}" + vbCrLf
                Next
                '
                XtraMsg(
                    sRoles + vbCrLf + $"Total Usuarios: {_dt.Rows.Count.ToString()}",
                    MessageBoxIcon.Asterisk,
                    MessageBoxButtons.OK,
                    "Roles asignados a Usuarios")
            End If
        End If
    End Sub
End Class