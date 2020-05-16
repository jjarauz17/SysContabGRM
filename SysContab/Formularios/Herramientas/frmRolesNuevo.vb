Imports System.Data
Imports System.Data.SqlClient
Imports SysContab.VB.SysContab

Public Class frmRolesNuevo

    Public Rol As Integer
    Public Nombre As String
    Public Descripcion As String
    Dim Ok As String

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Ok = "NO"
        Me.Close()
    End Sub

    Private Sub frmRolesNuevo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Ok = "SI" Then
            My.Forms.frmRoles.Cargar()
        End If
    End Sub

    Private Sub frmRolesNuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        '
        Me.btnExpandir.Enabled = True
        MostrarDatos()
    End Sub

    Sub Cargar()
        Me.TreeRoles.DataSource = ObtieneDatos("_REST_ArbolRoles " & Rol & "").DefaultView

        Me.TreeRoles.KeyFieldName = "Hijo"
        Me.TreeRoles.ParentFieldName = "Padre"

        Me.TreeRoles.PopulateColumns()
        Me.TreeRoles.Columns("Clave").Visible = False
        Me.TreeRoles.Columns("Tipo2").Visible = False

        Me.TreeRoles.Columns("Nombre").OptionsColumn.AllowEdit = False
        Me.TreeRoles.Columns("Tipo").OptionsColumn.AllowEdit = False

        Me.TreeRoles.Columns("Nombre").Width = 350
        Me.TreeRoles.Columns("Seleccionar").Width = 100
        Me.TreeRoles.Columns("Tipo").Width = 100
    End Sub

    Sub MostrarDatos()
        If Rol <> 0 Then
            Me.txtNombre.Text = Nombre
            Me.txtDescrip.Text = Descripcion
        End If
    End Sub

    Private Sub btnExpandir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpandir.Click
        Me.TreeRoles.ExpandAll()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        '*****  Validar Que hayan Opciones Seleccionadas

        If Me.txtNombre.Text.Trim.Length = 0 Then
            XtraMsg("Escriba el Nombre del Rol")
            Exit Sub
        End If

        If Me.txtDescrip.Text.Trim.Length = 0 Then
            XtraMsg("Escriba la Descripción del Rol")
            Exit Sub
        End If


        '///// Iniciar Trasaccion
        DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction
        '///////////////////////////////////////

        Try
            Me.TreeRoles.ExpandAll()

            If Rol = 0 Then 'Nuevo
                If Not _
                GuardaDatosTrans("INSERT INTO REST_Roles VALUES('" & Me.txtNombre.Text & "','" & Me.txtDescrip.Text & "')") Then
                    Rutinas.ErrorTransaccion()
                End If

                Rol = ObtieneDatosTrans("SELECT MAX(ID) Rol FROM REST_Roles rr").Rows.Item(0)(0)

                Gurdar()
            Else    'Actualizar
                If Not _
               GuardaDatosTrans("UPDATE REST_Roles SET Nombre ='" & Me.txtNombre.Text & "', Descripcion = '" & Me.txtDescrip.Text & "'" _
                                + " WHERE ID = " & Rol) Then
                    Rutinas.ErrorTransaccion()
                End If

                If Not _
               GuardaDatosTrans("DELETE FROM REST_RolesMenu WHERE Rol_Id = " & Rol) Then
                    Rutinas.ErrorTransaccion()
                End If

                If Not _
               GuardaDatosTrans("DELETE FROM REST_RolesRecursos WHERE Rol_Id = " & Rol) Then
                    Rutinas.ErrorTransaccion()
                End If

                If Not _
               GuardaDatosTrans("DELETE FROM REST_RolesAcciones WHERE Rol_Id = " & Rol) Then
                    Rutinas.ErrorTransaccion()
                End If

                Gurdar()
            End If


            Rutinas.okTransaccion()
            XtraMsg("Los Datos de Rol han Sido Guardados Correctamente.")

            RolesDB.UsuarioMenu()
            RolesDB.UsuarioRecursos()
            Ok = "SI"
            Me.Close()
        Catch ex As Exception
            Rutinas.ErrorTransaccion()
        End Try
    End Sub

    Sub Gurdar()
        '' Recorrer Arbol y Guardar Recursos
        For i As Integer = 0 To TreeRoles.Nodes.Count - 1

            If TreeRoles.Nodes(i).GetValue("Seleccionar") Then
                If Not _
                GuardaDatosTrans("INSERT INTO REST_RolesMenu VAlUES (" & Rol & "," & TreeRoles.Nodes(i).GetValue("Clave") & ")") Then
                    Rutinas.ErrorTransaccion()
                    Exit For
                End If
            End If

            For j As Integer = 0 To TreeRoles.Nodes(i).Nodes.Count - 1
                ''Guardar Recursos
                If TreeRoles.Nodes(i).Nodes.Item(j).GetValue("Seleccionar") Then
                    If Not _
                    GuardaDatosTrans("INSERT INTO REST_RolesRecursos VAlUES (" & Rol & "," & TreeRoles.Nodes(i).Nodes.Item(j).GetValue("Clave") & ")") Then
                        Rutinas.ErrorTransaccion()
                        Exit For
                    End If
                End If

                For k As Integer = 0 To TreeRoles.Nodes(i).Nodes(j).Nodes.Count - 1
                    ''Guardar Acciones
                    If TreeRoles.Nodes(i).Nodes(j).Nodes.Item(k).GetValue("Seleccionar") Then
                        If Not _
                        GuardaDatosTrans("INSERT INTO REST_RolesAcciones VAlUES (" & Rol & "," & TreeRoles.Nodes(i).Nodes(j).Nodes.Item(k).GetValue("Clave") & ")") Then
                            Rutinas.ErrorTransaccion()
                            Exit For
                        End If
                    End If
                Next
            Next
        Next
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        If Rol = 0 Then Exit Sub
        '
        CargarFiltrado()
        frmExportarImprimir.Mostrar(TreeListExportar, "Rol: " & txtNombre.Text & vbCrLf & "Descripción: " & txtDescrip.Text)
    End Sub

    Sub CargarFiltrado()
        TreeListExportar.DataSource = ObtieneDatos("JAR_ArbolRolesFiltrado " & Rol & "").DefaultView

        TreeListExportar.KeyFieldName = "Hijo"
        TreeListExportar.ParentFieldName = "Padre"

        TreeListExportar.PopulateColumns()
        TreeListExportar.Columns("Clave").Visible = False
        TreeListExportar.Columns("Tipo2").Visible = False

        TreeListExportar.Columns("Nombre").OptionsColumn.AllowEdit = False
        TreeListExportar.Columns("Tipo").OptionsColumn.AllowEdit = False

        TreeListExportar.Columns("Nombre").Width = 350
        TreeListExportar.Columns("Seleccionar").Width = 100
        TreeListExportar.Columns("Tipo").Width = 100

        TreeListExportar.ExpandAll()
    End Sub

    Private Sub bContraer_Click(sender As Object, e As EventArgs) Handles bContraer.Click
        Me.TreeRoles.CollapseAll()
    End Sub

    Private Sub TreeRoles_FilterNode(sender As Object, e As DevExpress.XtraTreeList.FilterNodeEventArgs) Handles TreeRoles.FilterNode
        'If e.Node("Seleccionar") Then
        '    e.Node.Visible = False
        '    e.Handled = True
        'End If
    End Sub
End Class