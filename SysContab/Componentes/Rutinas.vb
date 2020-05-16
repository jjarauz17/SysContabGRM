'Connection string for ASP (using ADO):
'Provider=SQLOLEDB.1;Persist Security Info=True;User ID=syscontab;Password=66cc9588;Initial Catalog=syscontab;Data Source=sql15.hostbasket.com
'Connection string for ASP.NET (using ADO.NET with System.Data.SqlClient namespace):
'Persist Security Info=True;User ID=syscontab;Password=66cc9588;Initial Catalog=syscontab;Data Source=sql15.hostbasket.com

Option Strict Off
Option Explicit On

Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO

Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Imports System.Xml

Namespace VB.SysContab

    Public Class Rutinas

        Public Function NZ(ByVal Valor As Object, ByVal ValorNulo As Object) As Object
            If Valor Is DBNull.Value Then
                Return (ValorNulo)
            Else
                Return (Valor)
            End If
        End Function

        Public Shared Function RecursosUsuario()
            '    'FormPrincipal.cmdBase.Enabled = False
            '    'FormPrincipal.cmdClientes.Enabled = False
            '    'FormPrincipal.cmdProveedores.Enabled = False
            '    'FormPrincipal.cmdBancos.Enabled = False
            '    'FormPrincipal.cmdProcesos.Enabled = False
            '    'FormPrincipal.cmdReportes.Enabled = False
            '    'FormPrincipal.cmdHerramientas.Enabled = False
            '    'Dim dsMenu As DataSet
            '    Dim dsUsuarioRecurso As DataSet
            '    Dim i As Integer
            '    Dim j As Integer
            '    Dim k As Integer
            '    'dsMenu = VB.SysContab.SeguridadDB.Menu

            '    dsUsuarioRecurso = VB.SysContab.SeguridadDB.UsuarioRecursos1(Usuario_ID, 2)

            '    ''For i = 0 To dsUsuarioRecurso.Tables("Menu").Rows.Count - 1
            '    For j = 0 To FormPrincipal.Controls.Count - 1
            '        If FormPrincipal.Controls(j).GetType.Name = "GroupBox" Then
            '            For k = 0 To FormPrincipal.Controls(j).Controls.Count - 1
            '                'If FormPrincipal.Controls(j).Controls(k).Name = dsUsuarioRecurso.Tables("Menu").Rows(i).Item("Menu_Recurso") Then
            '                FormPrincipal.Controls(j).Controls(k).Enabled = False
            '                'End If
            '            Next
            '        End If
            '    Next
            '    ''Next

            '    For i = 0 To dsUsuarioRecurso.Tables("Menu").Rows.Count - 1
            '        For j = 0 To FormPrincipal.Controls.Count - 1
            '            If FormPrincipal.Controls(j).GetType.Name = "GroupBox" Then
            '                For k = 0 To FormPrincipal.Controls(j).Controls.Count - 1
            '                    If FormPrincipal.Controls(j).Controls(k).Name = dsUsuarioRecurso.Tables("Menu").Rows(i).Item("Res_Control") Then
            '                        FormPrincipal.Controls(j).Controls(k).Enabled = True
            '                    End If
            '                Next
            '            End If
            '        Next
            '    Next
        End Function


        Public Shared Function MenuUsuario()
            '    Dim dsMenu As DataSet
            '    Dim dsUsuarioMenu As DataSet
            '    Dim i As Integer
            '    Dim j As Integer
            '    Dim k As Integer
            '    dsMenu = VB.SysContab.SeguridadDB.Menu
            '    dsUsuarioMenu = VB.SysContab.SeguridadDB.UsuarioMenu(Usuario_ID, 2)

            '    For i = 0 To dsMenu.Tables("Menu").Rows.Count - 1
            '        For j = 0 To FormPrincipal.Controls.Count - 1
            '            If FormPrincipal.Controls(j).GetType.Name = "GroupBox" Then
            '                For k = 0 To FormPrincipal.Controls(j).Controls.Count - 1
            '                    If FormPrincipal.Controls(j).Controls(k).Name = dsMenu.Tables("Menu").Rows(i).Item("Menu_Recurso") Then
            '                        FormPrincipal.Controls(j).Controls(k).Enabled = False
            '                    End If
            '                Next
            '            End If

            '            If FormPrincipal.Controls(j).Name = dsMenu.Tables("Menu").Rows(i).Item("Menu_Recurso") Then
            '                FormPrincipal.Controls(j).Enabled = False
            '            End If
            '        Next
            '    Next
            '    'Buscar los menu que tiene asigando el usuario
            '    For i = 0 To dsUsuarioMenu.Tables("Menu").Rows.Count - 1
            '        For j = 0 To FormPrincipal.Controls.Count - 1
            '            If FormPrincipal.Controls(j).GetType.Name = "GroupBox" Then
            '                For k = 0 To FormPrincipal.Controls(j).Controls.Count - 1
            '                    If FormPrincipal.Controls(j).Controls(k).Name = dsUsuarioMenu.Tables("Menu").Rows(i).Item("Menu_Recurso") Then
            '                        FormPrincipal.Controls(j).Controls(k).Enabled = True
            '                    End If
            '                Next
            '            End If

            '            If FormPrincipal.Controls(j).Name = dsUsuarioMenu.Tables("Menu").Rows(i).Item("Menu_Recurso") Then
            '                FormPrincipal.Controls(j).Enabled = True
            '            End If
            '        Next
            '    Next

            '    FormPrincipal.etCambiarEmpresa.Enabled = True
            '    FormPrincipal.etCerrarHerramientas.Enabled = True
            '    FormPrincipal.etAyuda.Enabled = True
            '    FormPrincipal.etCambiarEmpresa.Enabled = True
            '    FormPrincipal.etCerrarHerramientas.Enabled = True
            '    FormPrincipal.etAyuda.Enabled = True
            '    FormPrincipal.etAyudaRegistros.Enabled = True
            '    FormPrincipal.etAyudaClientes.Enabled = True
            '    FormPrincipal.etAyudaProv.Enabled = True
            '    FormPrincipal.etAyudaBancos.Enabled = True
            '    FormPrincipal.etAyduaProcesos.Enabled = True
            '    FormPrincipal.etAyudaReportes.Enabled = True
            '    FormPrincipal.etAyudaGenerales.Enabled = True
            '    FormPrincipal.etAyudaContables.Enabled = True
            '    FormPrincipal.etAyudaInvServ.Enabled = True
            '    FormPrincipal.etAyudaRepActivos.Enabled = True
            '    FormPrincipal.etAyudaRepComerciales.Enabled = True
            '    FormPrincipal.etAyudaRepContable.Enabled = True
            '    FormPrincipal.etAyudaRepGen.Enabled = True
            '    FormPrincipal.etAyudaRepPresupuesto.Enabled = True
            '    FormPrincipal.etAyudaRepDinamico.Enabled = True

        End Function

        'Public Shared Function UsuariosAcciones(ByVal f As Form, ByVal fp As String)
        '    '    Dim i As Integer
        '    '    Dim j As Integer
        '    '    Dim k As Integer
        '    '    Dim dsSeguridad As DataSet
        '    '    dsSeguridad = VB.SysContab.SeguridadDB.UsuarioAcciones(Usuario_ID, fp)
        '    '    For j = 0 To f.Controls.Count - 1
        '    '        If f.Controls(j).GetType.Name = "GroupBox" And f.Controls(j).Name <> "gbNo" Then
        '    '            For k = 0 To f.Controls(j).Controls.Count - 1
        '    '                If f.Controls(j).Controls.Item(k).GetType.Name = "Button" Then
        '    '                    f.Controls(j).Controls.Item(k).Enabled = False
        '    '                    If f.Controls(j).Controls.Item(k).Text = "Salir" Or f.Controls(j).Controls.Item(k).Text = "&Salir" Or f.Controls(j).Controls.Item(k).Text = "Ayuda" Or f.Controls(j).Controls.Item(k).Text = "&Ayuda" Or f.Controls(j).Controls.Item(k).Name = "cmdSalir" Or f.Controls(j).Controls.Item(k).Name = "cmdAyuda" Then
        '    '                        f.Controls(j).Controls.Item(k).Enabled = True
        '    '                    End If
        '    '                    'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Control").ToString = f.Controls(j).Controls.Item(k).Name Then
        '    '                    '    f.Controls(j).Controls.Item(k).Enabled = True
        '    '                    'End If
        '    '                End If
        '    '            Next
        '    '        End If
        '    '    Next

        '    '    For i = 0 To dsSeguridad.Tables("Usuarios").Rows.Count - 1
        '    '        For j = 0 To f.Controls.Count - 1
        '    '            If f.Controls(j).GetType.Name = "GroupBox" And f.Controls(j).Name <> "gbNo" Then
        '    '                For k = 0 To f.Controls(j).Controls.Count - 1
        '    '                    If f.Controls(j).Controls.Item(k).GetType.Name = "Button" Then
        '    '                        'f.Controls(j).Controls.Item(k).Enabled = False
        '    '                        'If f.Controls(j).Controls.Item(k).Text = "Salir" Or f.Controls(j).Controls.Item(k).Text = "Ayuda" Then
        '    '                        '    f.Controls(j).Controls.Item(k).Enabled = True
        '    '                        'End If
        '    '                        If dsSeguridad.Tables("Usuarios").Rows(i).Item("Control").ToString = f.Controls(j).Controls.Item(k).Name Then
        '    '                            f.Controls(j).Controls.Item(k).Enabled = True
        '    '                        End If
        '    '                    End If
        '    '                Next
        '    '            End If
        '    '        Next
        '    '    Next
        '    'End Function

        '    'Public Function DesabilitarRecursos(ByVal Menu As Control)
        '    '    Dim i As Integer

        '    '    If Menu.GetType.Name <> "GroupBox" Then
        '    '        Menu.Enabled = False
        '    '        Exit Function
        '    '    End If

        '    '    For i = 0 To Menu.Controls.Count - 1
        '    '        Menu.Controls.Item(i).Enabled = False
        '    '    Next

        '    '    'FormPrincipal.etMovimientos.Enabled = True
        '    '    'FormPrincipal.etPHorarios.Enabled = True
        '    '    'FormPrincipal.etHorasExtras.Enabled = True
        '    '    'FormPrincipal.etMovimiento.Enabled = True
        '    '    'FormPrincipal.etPlanilla0.Enabled = True
        '    '    'FormPrincipal.etVacaciones.Enabled = True
        '    '    FormPrincipal.etCambiarEmpresa.Enabled = True

        '    '    FormPrincipal.etCerrarHerramientas.Enabled = True

        '    'End Function

        '    'Public Function UsuariosRecursos(ByVal dsSeguridad As DataSet)
        '    '    Dim i As Integer
        '    '    For i = 0 To dsSeguridad.Tables("Usuarios").Rows.Count - 1
        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmEmpleados" Then
        '    '        '    FormPrincipal.cmdPersonal.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmDepartamentos" Then
        '    '        '    FormPrincipal.etDepartamentos.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmAreas" Then
        '    '        '    FormPrincipal.etAreas.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmCargos" Then
        '    '        '    FormPrincipal.etCargos.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmFunciones" Then
        '    '        '    FormPrincipal.etFunciones.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmHorarios" Then
        '    '        '    FormPrincipal.etHorarios.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmMonedas" Then
        '    '        '    FormPrincipal.etmonedas.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmTipoDeduccion" Then
        '    '        '    FormPrincipal.etTDeduccion.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmTipoIngreso" Then
        '    '        '    FormPrincipal.etTiposIngresos.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmFeriados" Then
        '    '        '    FormPrincipal.etFeriados.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmEmpHorarioSemana" Then
        '    '        '    FormPrincipal.etHSemanal.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmAgregarMReloj" Then
        '    '        '    FormPrincipal.etMReloj.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmGenerarHExtras" Then
        '    '        '    FormPrincipal.etGenHExtra.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmAutHExtras" Then
        '    '        '    FormPrincipal.etAutoHExtras.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmReporteHE" Then
        '    '        '    FormPrincipal.etReporteHE.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmDeducciones" Then
        '    '        '    FormPrincipal.etDeducciones.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmDeduccionesUnicas" Then
        '    '        '    FormPrincipal.etMDeducciones.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmIngresos" Then
        '    '        '    FormPrincipal.etIngresosP.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmIngresosUnicos" Then
        '    '        '    FormPrincipal.etIngresosU.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmGenMovimientos" Then
        '    '        '    FormPrincipal.etGenMovPer.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmGenPlanilla" Then
        '    '        '    FormPrincipal.etGenPlan.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmVacaciones" Then
        '    '        '    FormPrincipal.etPagoVacaciones.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmPeriodoNomina" Then
        '    '        '    FormPrincipal.cmdPeriodos.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmRptPlanilla" Then
        '    '        '    FormPrincipal.etRptPlanilla.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmRptPlanillaComparativo" Then
        '    '        '    FormPrincipal.etComparativoPlanilla.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmReporteHE" Then
        '    '        '    FormPrincipal.etRptHorasExtras.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmCambiarEmpresa" Then
        '    '        '    FormPrincipal.etCambiarEmpresa.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "FrmRolesListar" Then
        '    '        '    FormPrincipal.etRoles.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "FrmUsuariosListar" Then
        '    '        '    FormPrincipal.etUsuarios.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmEmpleadosPermisos" Then
        '    '        '    FormPrincipal.etPermisos.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmEmpleadosPermisos" Then
        '    '        '    FormPrincipal.etPermisos.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmPagoAguinaldo" Then
        '    '        '    FormPrincipal.etAguinaldo.Enabled = True
        '    '        'End If

        '    '        'If dsSeguridad.Tables("Usuarios").Rows(i).Item("Res_URL") = "frmAhorro" Then
        '    '        '    FormPrincipal.etAhorro.Enabled = True
        '    '        'End If

        '    '    Next

        'End Function

        Public Function LeerXML(ByVal Path As String) As DataSet
            Dim ds As New DataSet()
            If File.Exists(Path) Then
                ds.ReadXml(Path) ', XmlReadMode.ReadSchema)
                Return ds
            Else
                MsgBox("No existe ese archivo", MsgBoxStyle.Critical)
                Return Nothing
            End If
        End Function

        Public Shared Function Fecha() As Date
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_FechaServer", DBConn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim pFecha As SqlParameter = New SqlParameter("@Fecha", SqlDbType.DateTime, 50)
            pFecha.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pFecha)

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            Return pFecha.Value
        End Function

        Public Shared Function FechaANSI(ByVal FechaAct As String) As String

            Dim FechaActual As String

            Dim Anno As String = Right(FechaAct, 4)
            Dim Mes As String = Right(Left(FechaAct, 5), 2)
            Dim Dia As String = Left(FechaAct, 2)

            FechaActual = Anno & Mes & Dia

            Return FechaActual

        End Function

        Public Shared Function FechaANSIComp(ByVal FechaAct As String) As String

            Dim FechaActual As String = ""

            If FechaAct = "" Then
                FechaActual = ""
            Else
                Dim Anno As String = Right(FechaAct, 4)
                Dim Mes As String = Right(Left(FechaAct, 5), 2)
                Dim Dia As String = Left(FechaAct, 2)
                FechaActual = Anno & "/" & Mes & "/" & Dia
            End If

            Return FechaActual

        End Function

        Public Shared Sub ErrorTransaccion()
            transaccionFacturas.Rollback()
            DBConnFacturas.Close()
            transaccionFacturas = Nothing
            DBConnFacturas = Nothing
        End Sub

        Public Shared Sub okTransaccion()
            transaccionFacturas.Commit()
            DBConnFacturas.Close()
            transaccionFacturas = Nothing
            DBConnFacturas = Nothing

            'MsgBox("Los datos se guardaron correctamente", MsgBoxStyle.Information)
            'LimpiarControles()

        End Sub

        Public Sub FormularioColor(ByVal Control As Form)
            Dim i As Integer
            Dim j As Integer
            Dim k As Integer

            If Control.GetType.Name <> "TextBox" And Control.GetType.Name <> "ComboBox" Then
                Control.BackColor = Color.FromArgb(225, 236, 236)
            End If

            If Control.GetType.Name = "TextBox" Or Control.GetType.Name = "ComboBox" Then
                Control.BackColor = Color.White
            End If

            For i = 0 To Control.Controls.Count - 1
                'Control.BackColor = Color.FromArgb(225, 236, 236)
                'Control.BackColor = Color.FromArgb(189, 210, 210)
                '189, 210, 210

                If Control.Controls(i).GetType.Name <> "TextBox" And Control.Controls(i).GetType.Name <> "ComboBox" Then
                    Control.Controls(i).BackColor = Color.FromArgb(225, 236, 236)
                End If

                If Control.Controls(i).GetType.Name = "TextBox" Or Control.Controls(i).GetType.Name = "ComboBox" Then
                    Control.Controls(i).BackColor = Color.White
                End If

                If Control.Controls(i).GetType.Name = "GroupBox" Then
                    'Button()
                    For j = 0 To Control.Controls(i).Controls.Count - 1
                        If Control.Controls(i).Controls(j).GetType.Name <> "TextBox" And Control.Controls(i).Controls(j).GetType.Name <> "ComboBox" Then
                            Control.Controls(i).Controls(j).BackColor = Color.FromArgb(225, 236, 236)
                        End If

                        If Control.Controls(i).Controls(j).GetType.Name = "TextBox" Or Control.Controls(i).Controls(j).GetType.Name = "ComboBox" Then
                            Control.Controls(i).Controls(j).BackColor = Color.White
                        End If

                        If Control.Controls(i).Controls(j).Text = "&Salir" Then
                            Control.Controls(i).Controls(j).ForeColor = Color.FromArgb(255, 0, 0)
                        End If

                        If Control.Controls(i).Controls(j).GetType.Name = "GroupBox" Then
                            For k = 0 To Control.Controls(i).Controls(j).Controls.Count - 1
                                If Control.Controls(i).Controls(j).Controls(k).Text = "&Salir" Then
                                    Control.Controls(i).Controls(j).Controls(k).ForeColor = Color.FromArgb(255, 0, 0)
                                End If
                                If Control.Controls(i).Controls(j).Controls(k).GetType.Name <> "TextBox" And Control.Controls(i).Controls(j).Controls(k).GetType.Name <> "ComboBox" Then
                                    Control.Controls(i).Controls(j).Controls(k).BackColor = Color.FromArgb(225, 236, 236)
                                End If

                                If Control.Controls(i).Controls(j).Controls(k).GetType.Name = "TextBox" Or Control.Controls(i).Controls(j).Controls(k).GetType.Name = "ComboBox" Then
                                    Control.Controls(i).Controls(j).Controls(k).BackColor = Color.White
                                End If
                            Next
                        End If
                        'End If
                    Next
                End If
            Next
        End Sub

        Public Sub ComboAutoCompleteKeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)     'Handles ComboBox2.KeyUp
            Dim CB As ComboBox = DirectCast(sender, ComboBox)
            Dim inicio As Integer = CB.Text.Length
            Dim indice As Integer
            Dim t As String = e.KeyCode.ToString


            'If t.Length >= 1 AndAlso ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse IsNumeric(t) OrElse (t >= "A" AndAlso t <= "Z") _
            '                   OrElse InStr(" /*-+()!#$%&=?¡¿~{}[],.-_<>@|°¬", t) > 0) _
            '                   Or e.KeyCode = Keys.Space Then
            'MsgBox(e.KeyValue)

            If (e.KeyValue >= 48 And e.KeyValue <= 57) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Or
               (e.KeyValue >= 65 And e.KeyValue <= 90) Or (e.KeyValue = 192) Or
               (InStr(" /*-+()!#$%&=?¡¿~{}[],.-_<>@|°¬", t) > 0) Or (e.KeyCode = Keys.Space) Then ' Or _
                '(e.KeyValue >= 65 And e.KeyValue <= ) Then 'Or (IsNumeric(t)) Or (t >= "A" And t <= "Z") Or (InStr(" /*-+()!#$%&=?¡¿~{}[],.-_<>@|°¬", t) > 0) Or (e.KeyCode = Keys.Space) Then
                'If t = "Back" Then
                '    If CB.SelectionStart = 1 Then
                '        p = CB.SelectionStart
                '    Else
                '        p = CB.SelectionStart - 1
                '    End If
                'Else
                '    p = CB.SelectionStart
                'End If
                Dim p As Integer = CB.SelectionStart

                'If p = -1 Then
                '    indice = CB.FindString(CB.Text.Substring(0, p + 1))
                'Else
                indice = CB.FindString(CB.Text.Substring(0, p))
                'End If

                'Cliente = Cliente & Chr(e.KeyData)

                If indice >= 0 Then
                    CB.SuspendLayout()
                    CB.SelectedIndex = indice
                    CB.Select(p, CB.Text.Length)
                    CB.ResumeLayout()
                End If
            End If

        End Sub

        Friend Sub ComboAutoComplete(ByVal Combo As ComboBox)
            AddHandler Combo.KeyUp, AddressOf ComboAutoCompleteKeyUp
        End Sub

        Public Shared Sub OcultarMenu(ByVal control As Form)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is GroupBox Then
                    control.Controls.Item(i).Visible = False
                End If
            Next
        End Sub

        'Funcion para limpiar los elementos de un formulario
        Public Sub LimpiarControles(ByVal control As GroupBox)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is TextBox Then
                    control.Controls.Item(i).Text = ""
                End If
            Next
        End Sub

        Public Sub EstablecerCero(ByVal control As GroupBox)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is TextBox Then
                    control.Controls.Item(i).Text = 0.ToString(Round)
                End If
            Next
        End Sub

        Public Sub DeshabilitarControles(ByVal control As GroupBox)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is TextBox Or TypeOf (control.Controls.Item(i)) Is ComboBox _
                Or TypeOf (control.Controls.Item(i)) Is DateTimePicker Then
                    control.Controls.Item(i).Enabled = False
                End If
            Next
        End Sub

        Public Sub HabilitarControles(ByVal control As GroupBox)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is TextBox Or TypeOf (control.Controls.Item(i)) Is ComboBox _
                Or TypeOf (control.Controls.Item(i)) Is DateTimePicker Then
                    control.Controls.Item(i).Enabled = True
                End If
            Next
        End Sub

        Public Shared Function AbrirConexion() As String

            Dim conex As String = Conexion()


            ''Dim Server As String
            ''Dim User As String
            ''Dim Password As String

            'If Not File.Exists(Application.StartupPath & "\Configurar.ini") Then
            '    If Not File.Exists(Application.StartupPath & "\Configurar.txt") Then
            '        XtraMsg("Falta el archivo de configuracion: Configurar", MessageBoxIcon.Exclamation)
            '        Return "Nothing"
            '        Exit Function
            '    End If
            'End If

            'Dim ConnectionFile As System.IO.StreamReader

            'Try
            '    ConnectionFile = New System.IO.StreamReader(Application.StartupPath & "\Configurar.ini")
            'Catch ex As Exception
            '    ConnectionFile = New System.IO.StreamReader(Application.StartupPath & "\Configurar.txt")
            'End Try


            'Server = ConnectionFile.ReadLine.ToString()
            'Usuario = Login 'ConnectionFile.ReadLine.ToString()
            'UPassword = Password 'ConnectionFile.ReadLine.ToString()
            'DBName = ConnectionFile.ReadLine.ToString()
            'ContabilizarVenta = ConnectionFile.ReadLine.ToString()

            'If Usuario = "xxxVacio" Then
            '    conex = "Persist Security Info=True;User ID=stscontab;Password=" & Password & ";Initial Catalog=stscontab;Data Source=" & Server
            'Else
            '    'conex = "server=" & Server & ";Initial Catalog=SysContab;User Id=" & User & ";Password=" & Password & ";"
            '    conex = "server=" & Server & ";Initial Catalog=" & DBName & ";User Id=" & Usuario & ";Password=" & UPassword & ";"
            '    'conex = "server=servidor;Initial Catalog=BaseDatos;User Id=" sa;Password=123456;"
            'End If

            Return conex
        End Function

        Public Function AbrirConexionReporte() As String
            Dim NombreServidor As String
            Dim UserName As String
            Dim Password As String
            Dim NombreBaseDeDatos As String

            Dim conex As String

            If Not File.Exists(Application.StartupPath & "\Configurar.ini") Then
                If Not File.Exists(Application.StartupPath & "\Configurar.txt") Then
                    XtraMsg("Falta el archivo de configuracion: Configurar", MessageBoxIcon.Exclamation)
                    Return "Nothing"
                    Exit Function
                End If
            End If

            Dim ConnectionFile As System.IO.StreamReader

            Try
                ConnectionFile = New System.IO.StreamReader(Application.StartupPath & "\Configurar.ini")
            Catch ex As Exception
                ConnectionFile = New System.IO.StreamReader(Application.StartupPath & "\Configurar.txt")
            End Try

            NombreServidor = ConnectionFile.ReadLine.ToString()
            UserName = ConnectionFile.ReadLine.ToString()
            Password = ConnectionFile.ReadLine.ToString()
            NombreBaseDeDatos = "SysContab"

            conex = "driver={SQL Server};server=" & NombreServidor & ";" &
                    "uid=" & UserName & ";pwd=" & Password &
                    ";database=" & NombreBaseDeDatos

            Return conex

        End Function

        Private Sub TextBoxMontoLeaveHandler(ByVal sender As Object, ByVal e As EventArgs)
            'MsgBox(CType(sender, System.Windows.Forms.DataGridTextBox).Text)

            If CType(sender, System.Windows.Forms.DataGridTextBox).Text = "" Then
                Exit Sub
            End If

            If Not IsNumeric(CType(sender, System.Windows.Forms.DataGridTextBox).Text) Then
                MsgBox("Introduzca un valor númerico", MsgBoxStyle.Information)
                CType(sender, System.Windows.Forms.DataGridTextBox).Focus()
                Exit Sub
            Else
                CType(sender, System.Windows.Forms.DataGridTextBox).Text = CDbl(CType(sender, System.Windows.Forms.DataGridTextBox).Text).ToString("n2")
            End If
        End Sub

        Public Function FormatGenerico(ByVal Grilla As DataGrid, ByVal fuente As DataTable) As Boolean
            Dim i As Integer = 0
            Grilla.TableStyles.Clear()
            Dim EstiloGrilla As New DataGridTableStyle

            EstiloGrilla.MappingName = fuente.TableName()             'Estilo de la Grilla, para la tabla maestra de terceros de facturación
            Dim column As New DataGridTextBoxColumn

            Dim fila1 As DataRow = fuente.NewRow()
            'Dim fila As DataGridTableStyle
            'Dim column1 As DataGrid
            'fuente.Rows.Add(fila1)

            EstiloGrilla.PreferredRowHeight = 20

            While i < fuente.Columns.Count
                If Grilla.Name = "dgFacturasP" And fuente.Columns(i).Caption = "Seleccionar" Then
                    'Dim newCol As New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(0)
                    Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
                    boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(0)
                    boolCol.MappingName = fuente.Columns(i).ColumnName '"Agregar"
                    boolCol.HeaderText = fuente.Columns(i).Caption '"Agregar"
                    boolCol.Alignment = HorizontalAlignment.Center
                    CType(boolCol, DataGridBoolColumn).AllowNull = False

                    boolCol.Width = 75
                    boolCol.ReadOnly = False

                    boolCol.NullText = ""

                    AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)

                    EstiloGrilla.GridColumnStyles.Add(boolCol)
                    EstiloGrilla.ReadOnly = False
                    'EstiloGrilla.a
                Else

                    If fuente.Columns(i).Caption <> "." Then


                        column = New DataGridTextBoxColumn
                        column.MappingName = fuente.Columns(i).ColumnName
                        column.HeaderText = fuente.Columns(i).Caption
                        column.ReadOnly = True

                        column.Width = fuente.Columns(i).Caption.Length * 20
                        If Grilla.Name = "dgInventariosFisicos" Then
                            If column.MappingName.ToUpper = "CODIGO_BODEGA" Then
                                column.Width = 0
                            End If
                            If column.MappingName.ToUpper = "REALIZADOPOR" Or column.MappingName.ToUpper = "AUTORIZADOPOR" Then
                                column.Width = 100
                            End If
                            If column.MappingName.ToUpper = "AUTORIZADO" Then
                                column.Width = 100
                            End If

                        End If
                        If column.MappingName.ToUpper = "NOMBRE" Or column.MappingName.ToUpper = "ENCARGADO" Or column.MappingName.ToUpper = "DESCRIPCION" Or column.MappingName.ToUpper = "DIRECCION" Or column.MappingName.ToUpper = "CONTADOR" Or column.MappingName.ToUpper = "AREA" Or column.MappingName = "Descripción" Then
                            column.Width = 350
                        End If

                        If column.MappingName.ToUpper = "PAIS" Or column.MappingName.ToUpper = "CORREO" Or column.MappingName.ToUpper = "CIUDAD" Or column.MappingName.ToUpper = "MONEDA" Then
                            column.Width = 200
                        End If

                        If column.MappingName = "Comisión Producto" Or column.MappingName = "Comisión Servicio" Then
                            column.NullText = 0.ToString(Round)
                            column.Format = "##,###0.00"
                            column.Alignment = HorizontalAlignment.Right

                            column.Width = 130
                        End If

                        'If column.MappingName = "TipoPedido" Then
                        '    column.Width = 0
                        'End If

                        If column.MappingName = "Tasa Cambio" Then
                            column.ReadOnly = False
                        End If

                        If column.MappingName.ToUpper = "BANCO" Or column.MappingName.ToUpper = "PAGAR A" Then  'Or Grilla.Name.ToUpper <> "DGMNEMOTECNICOS" Then
                            column.Width = 300
                        End If

                        If column.MappingName.ToUpper = "SISTEMA" Or column.MappingName = "TipoF" Or column.MappingName = "Per_ID" Or column.MappingName = "Comp_No" Or column.MappingName = "T" Or column.MappingName = "CDet_Cuenta" Or column.MappingName = "NombreCuenta" Or column.MappingName = "NumeroMes" Or column.MappingName = "Comp_Fecha" Or column.MappingName = "Mon_Codigo" Or column.MappingName = "TipoMovimiento" Or column.MappingName = "Codigo_Bodega" Then
                            column.Width = 0
                        End If

                        If Grilla.Name.ToUpper = "DGMNEMOTECNICOS" Then
                            If column.MappingName.ToUpper = "TIPO_COMPROBANTE" Then
                                column.Width = 120
                            End If
                            If column.MappingName.ToUpper = "DESCRIPCION" Then
                                column.Width = 300
                            End If
                            If column.MappingName.ToUpper = "MNEMOTECNICO" Then
                                column.Width = 100
                            End If

                        End If

                        If column.MappingName.ToUpper = "CONCEPTO" Then
                            column.Width = 600
                        End If

                        If column.MappingName.ToUpper = "PROCESO" Then
                            column.Width = 85
                        End If

                        If column.MappingName.ToUpper = "CLIENTE" Or column.MappingName.ToUpper = "PROVEEDOR" Then
                            column.Width = 300

                        End If

                        If column.MappingName.ToUpper = "P. VENTA" Then
                            column.Width = 70
                        End If

                        If column.MappingName.ToUpper = "MES" Or column.MappingName = "Termino de Pago" Then
                            column.Width = 120
                        End If

                        If column.MappingName = "No Autorización" Then
                            column.Width = 150
                        End If

                        If Grilla.Name = "dgCatalogo" Then
                            If column.MappingName = "Grupo" Then
                                column.Width = 225
                            End If
                        End If

                        If column.MappingName = "No. Entrada" Or column.MappingName = "No. Devolución" Or column.MappingName = "No. Salida" Or column.MappingName.ToUpper = "RUC" Or column.MappingName.ToUpper = "FAX" Or column.MappingName = "No. Cuenta" Or column.MappingName = "Comprobante" Then
                            column.Width = 100
                        End If

                        If Grilla.Name = "dgAcumuladosProductos1" Then
                            If column.MappingName.ToUpper = "MES" Then
                                column.Width = 100
                            End If
                        End If

                        If column.MappingName.ToUpper = "CODIGO_ARTICULO" Or column.MappingName.ToUpper = "CODIGO_SERVICIO" Then
                            column.HeaderText = "Código "
                            column.Width = 160
                        End If

                        If column.MappingName.ToUpper = "CODIGO_GRUPO" Or column.MappingName.ToUpper = "PORCENTAJE_DEPRECIACION" Then
                            column.Width = fuente.Columns(i).Caption.Length * 10
                        End If

                        If column.MappingName.ToUpper = "MONTO NOTA DEBITO" Then
                            column.NullText = 0.ToString(Round)
                            column.Format = "##,###0.00"
                            column.Alignment = HorizontalAlignment.Right
                            column.Width = 150
                        End If

                        If column.MappingName.ToUpper = "PRECIO" Or column.MappingName.ToUpper = "COSTO" Or column.MappingName.ToUpper = "MONTO CHEQUE" Or column.MappingName.ToUpper = "MONTO TARJETA" Or column.MappingName.ToUpper = "EFECTIVO" Or column.MappingName.ToUpper = "MONTO TOTAL" Then
                            column.NullText = 0.ToString(Round)
                            column.Format = "##,###0.00"
                            column.Alignment = HorizontalAlignment.Right
                            column.Width = 100
                            'column.HeaderText = column.HeaderText & "."
                        End If

                        If column.MappingName.ToUpper = "CODIGO" Then
                            If Grilla.Name = "dgClientes" Then
                                'column.Format = "C-0000"
                            ElseIf Grilla.Name = "dgProveedores" Then
                                'column.Format = "P-0000"
                            ElseIf Grilla.Name = "dgVendedores" Then
                                'column.Format = "V-0000"
                            ElseIf Grilla.Name = "dgArticulos" Then
                                If column.MappingName.ToUpper = "TIPO" Then
                                    column.Width = 0
                                End If
                            ElseIf Grilla.Name = "dgActivos_Fijos" Then
                                column.Width = 100
                            ElseIf Grilla.Name = "dgNombres" Then
                                column.Width = 100
                            Else
                                column.Width = 0
                            End If

                        End If

                        If Grilla.Name = "dgArticulos" And column.MappingName.ToUpper = "TIPO" Then
                            'EstiloGrilla.PreferredRowHeight = 25
                            'If column.MappingName.ToUpper = "TIPO" Then
                            column.Width = 0
                            'End If
                        End If

                        If column.MappingName.ToUpper = "NUMERO_MES" Or column.MappingName.ToUpper = "NOMBRE_EMPLEADO" Or column.MappingName.ToUpper = "NUMERO" Or column.MappingName.ToUpper = "CLIENTE_ID" Or column.MappingName.ToUpper = "CLASE" Or column.MappingName.ToUpper = "DISPLAYMEMBER" Or column.MappingName.ToUpper = "DEPOSITO_ID" Or column.MappingName.ToUpper = "FACTURA_ORIGEN" Or column.MappingName = "OrdenCompra" Or column.MappingName = "Proveedor_ID" Or column.MappingName = "Factura_ID" Then
                            column.Width = 0
                        End If

                        'If Grilla.Name = "dgVentas" Then
                        '    column.NullText = ""
                        'End If

                        column.NullText = ""

                        If column.MappingName.ToUpper = "NO FACTURA" Or column.MappingName.ToUpper = "FECHA PAGO" Or column.MappingName.ToUpper = "FECHA ENTREGA" Or column.MappingName.ToUpper = "NO. PEDIDO" Or column.MappingName.ToUpper = "NO. ORDEN" Or column.MappingName.ToUpper = "NO. DEPOSITO" Or column.MappingName.ToUpper = "FIN" Or column.MappingName.ToUpper = "FECHA DEPOSITO" Then
                            column.Width = 100
                        End If


                        If Grilla.Name = "dgRecibos" Then
                            If column.MappingName.ToUpper = "TIPO" Then
                                column.Width = 150
                            End If
                        End If

                        If column.MappingName.ToUpper = "ENTRADA" Or column.MappingName.ToUpper = "SALIDAS" Then
                            If Grilla.Name <> "dgArticuloCCAcumulado" Then
                                column.NullText = "0"
                                column.Alignment = HorizontalAlignment.Right
                                column.HeaderText = "Unidades"
                            End If
                            If Grilla.Name = "dgAcumuladosProductos1" Then
                                column.Width = 55
                            End If
                        End If

                        If column.MappingName.ToUpper = "VALOR_ENTRADA" Or column.MappingName.ToUpper = "VALOR" Then
                            column.HeaderText = "Valor"

                            If Grilla.Name = "dgAcumuladosProductos1" Then
                                column.Width = 50
                            Else
                                column.Width = 100
                            End If


                        End If

                        If column.MappingName.ToUpper = "COD. GRUPO" Then
                            column.Width = 80
                        End If

                        If column.MappingName.ToUpper = "CANTIDAD" Or column.MappingName.ToUpper = "EXISTENCIAS" Then
                            column.NullText = "0"
                            column.Alignment = HorizontalAlignment.Right
                            column.Width = 100
                        End If

                        If Grilla.Name <> "dgCobrosHistorial" And Grilla.Name <> "dgPagosXRecibo" Then
                            If column.MappingName.ToUpper = "SALDO_INICIAL" Or column.MappingName.ToUpper = "SALDO INICIAL" Or column.MappingName.ToUpper = "MONTO" Or column.MappingName.ToUpper = "DEBE" Or column.MappingName.ToUpper = "HABER" Or column.MappingName.ToUpper = "SALDO" Or column.MappingName.ToUpper = "PRESUPUESTO" Or column.MappingName.ToUpper = "VENTAS" Or column.MappingName.ToUpper = "COMISION" Or column.MappingName.ToUpper = "VALOR" Or column.MappingName.ToUpper = "VALOR_ENTRADA" Or column.MappingName.ToUpper = "MONTO" Or column.MappingName.ToUpper = "DESCUENTO" Or column.MappingName.ToUpper = "IVA" Or column.MappingName.ToUpper = "OTROS" Or column.MappingName.ToUpper = "TOTAL" Or column.MappingName.ToUpper = "RECARGO" Or column.MappingName.ToUpper = "SUB TOTAL" Or column.MappingName.ToUpper = "ABONO" Or column.MappingName = "Otros" Or column.MappingName = "Impuesto" Then
                                column.NullText = 0.ToString(Round)
                                column.Format = "##,###0.00"
                                column.Alignment = HorizontalAlignment.Right
                                If Grilla.Name = "dgAcumuladosProductos1" Then
                                    column.Width = 70
                                Else
                                    column.Width = 100
                                End If
                            End If
                        End If

                        If EstiloGrilla.MappingName.ToUpper = "CB_E" Or EstiloGrilla.MappingName.ToUpper = "CB_D" Then
                            If Left(column.MappingName.ToUpper, 8) = "CREDITOS" Or Left(column.MappingName.ToUpper, 7) = "DEBITOS" Then
                                column.NullText = 0.ToString(Round)
                                column.Format = "##,###0.00"
                                column.Alignment = HorizontalAlignment.Right
                                column.Width = 150
                            End If
                            If column.MappingName.ToUpper = "PERIODO" Then
                                column.Alignment = HorizontalAlignment.Left
                                column.Width = 250
                            End If
                            If column.MappingName.ToUpper = "CONCEPTO" Then
                                column.Alignment = HorizontalAlignment.Left
                                column.Width = 250
                            End If
                            If column.MappingName.ToUpper = "TIPO" Or column.MappingName.ToUpper = "ESTADO" Or
                                column.MappingName.ToUpper = "COMPROBANTE" Or column.MappingName.ToUpper = "CHEQUE" Then
                                column.Alignment = HorizontalAlignment.Left
                                column.Width = 100
                            End If
                            If Left(column.MappingName.ToUpper, 5) = "SALDO" Then
                                column.NullText = 0.ToString(Round)
                                column.Format = "##,###0.00"
                                column.Alignment = HorizontalAlignment.Right
                                column.Width = 150
                            End If
                        End If

                        If column.MappingName.ToUpper = "DIA" Then
                            column.ReadOnly = True
                        End If

                        If Grilla.Name = "dgCobrosHistorial" Then
                            If column.MappingName.ToUpper = "FACTURA" Or column.MappingName.ToUpper = "NOMBRE" Or column.MappingName.ToUpper = "FECHA" Or column.MappingName.ToUpper = "TOTAL" Or column.MappingName.ToUpper = "EMPRESA" Or column.MappingName.ToUpper = "TRANSACCION" Then
                                column.Width = 0
                            ElseIf column.MappingName.ToUpper = "FECHACOBRO" Then
                                column.HeaderText = "Fecha Pago"
                                column.Format = "dd/MM/yyyy"
                                column.Width = 100
                            ElseIf column.MappingName.ToUpper = "COBRO" Or column.MappingName.ToUpper = "SALDO" Then
                                column.NullText = 0.ToString(Round)
                                column.Format = "##,###0.00"
                                column.Alignment = HorizontalAlignment.Right
                                column.Width = 100
                                If column.MappingName.ToUpper = "COBRO" Then
                                    column.HeaderText = "Valor"
                                End If
                            ElseIf column.MappingName.ToUpper = "TRANSACCION/RECIBO" Then
                                column.Width = 130
                            ElseIf column.MappingName.ToUpper = "ORDEN" Then
                                column.Width = 0
                            End If
                        End If

                        If Grilla.Name = "dgCatalogoAcumulados" Or Grilla.Name = "dgAcumuladosProductos" Or Grilla.Name = "dgVentasServicios" Or Grilla.Name = "dgAcumuladosProductos1" Then
                            If Grilla.Name = "dgVentasServicios" Then
                                If column.MappingName.ToUpper = "UNIDADES" Then
                                    column.Width = 100
                                    column.Alignment = HorizontalAlignment.Right
                                    column.HeaderText = "Cantidad"
                                    column.NullText = "0"

                                End If
                            End If

                            If column.MappingName.ToUpper = "CUENTA" Or column.MappingName.ToUpper = "NOMBRE" Or column.MappingName.ToUpper = "PRODUCTO" Or column.MappingName.ToUpper = "ITEM" Then
                                column.Width = 0
                            End If
                        End If

                        If Grilla.Name = "dgPagosXRecibo" Then
                            column.Width = 100
                            If column.MappingName.ToUpper = "MONTO CHEQUE" Or column.MappingName.ToUpper = "MONTO TARJETA" Or column.MappingName.ToUpper = "EFECTIVO" Or column.MappingName.ToUpper = "NOTA DEBITO" Then
                                column.NullText = 0.ToString(Round)
                                column.Format = "##,###0.00"
                                column.Alignment = HorizontalAlignment.Right
                            ElseIf column.MappingName.ToUpper = "TIPO PAGO" Then
                                column.Width = 120
                            ElseIf column.MappingName.ToUpper = "BANCO" Then
                                column.Width = 300
                            ElseIf column.MappingName.ToUpper = "MONEDA" Then
                                column.Width = 200
                            ElseIf column.MappingName.ToUpper = "NO TARJETA" Then
                                column.Width = 150
                            ElseIf column.MappingName.ToUpper = "TIPO TARJETA" Then
                                column.Width = 150
                            ElseIf column.MappingName.ToUpper = "EMISOR" Then
                                column.Width = 250
                            ElseIf column.MappingName.ToUpper = "AUTORIZACION" Then
                                column.Width = 150
                            ElseIf column.MappingName.ToUpper = "TRANSACCION/RECIBO" Then
                                column.Width = 130
                            ElseIf column.MappingName.ToUpper = "ORDEN" Then
                                column.Width = 0
                            End If
                        End If

                        If column.MappingName.ToUpper = "FECHA" Or column.MappingName.ToUpper = "FECHA ENTREGA" Or column.MappingName.ToUpper = "VENCIMIENTO" Then
                            column.Format = "dd/MM/yyyy"
                            column.Width = 100
                        End If

                        If column.MappingName.ToUpper = "FECHA VENCIMIENTO" Then
                            column.Format = "dd/MM/yyyy"
                            column.Width = 130

                        End If

                        If column.MappingName = "No Cotización" Then
                            column.Width = 100

                        End If

                        '***************************************************************************************************

                        If Grilla.Name = "dgCatalogoAcumulados" Then

                            Dim c As Integer
                            Dim Saldo As Double
                            Saldo = 0

                            For c = 0 To fuente.Rows.Count - 1

                                If Grilla.Item(c, 2) Is DBNull.Value Then
                                    Grilla.Item(c, 2) = 0
                                End If

                                If Grilla.Item(c, 3) Is DBNull.Value Then
                                    Grilla.Item(c, 3) = 0
                                End If

                                Saldo = Saldo + Grilla.Item(c, 2) - Grilla.Item(c, 3)
                                Grilla.Item(c, 4) = Saldo.ToString(Round)
                            Next

                        End If

                        If Grilla.Name = "dgCatalogoAcumulados" Or Grilla.Name = "dgFacturasClientes" Or Grilla.Name = "dgVentasPerdidas" Then
                            If column.MappingName.ToUpper = "ORDEN" Then
                                column.Width = 0
                            End If
                        End If


                        If Grilla.Name = "DGVentas" Or Grilla.Name = "dgCompras" Then
                            If column.MappingName = "Orden" Or column.MappingName = "Cliente" Then
                                column.Width = 0
                            ElseIf column.MappingName = "Valor" Or column.MappingName = "Saldo" Or column.MappingName = "I.R." Or column.MappingName = "I.R. x Cobrar" Then
                                column.Width = 120
                                column.NullText = 0.ToString(Round)
                                column.Format = "##,###0.00"
                                column.Alignment = HorizontalAlignment.Right
                            ElseIf column.MappingName = "Tipo" Then
                                column.Width = 150
                            ElseIf column.MappingName = "Acción" Then
                                column.Width = 75
                            ElseIf column.MappingName = "Recibo" Then
                                column.Width = 75
                            End If

                            EstiloGrilla.PreferredRowHeight = 20
                            EstiloGrilla.AllowSorting = False

                            'Dim c As Integer
                            'Dim Saldo As Double
                            'Saldo = 0
                            'If Grilla.Name = "dgCompras" Then
                            '    For c = 0 To fuente.Rows.Count - 1
                            '        If Grilla.Item(c, 2) Is DBNull.Value Then
                            '            'saldo = 0 + saldo
                            '        Else
                            '            Saldo = Grilla.Item(c, 2) + Saldo
                            '        End If
                            '        Grilla.Item(c, 3) = Saldo.ToString(Round)
                            '    Next
                            'End If

                        End If

                        '***************************************************************************************************
                        'dgEstadoCuenta
                        If Grilla.Name = "dgEstadoCuenta" Then
                            Dim Tipo As String
                            If column.MappingName = "Orden" Or column.MappingName = "Cliente" Or column.MappingName = "Proveedor" Then
                                column.Width = 0
                                If column.MappingName = "Cliente" Then
                                    Tipo = "C"
                                ElseIf column.MappingName = "Proveedor" Then
                                    Tipo = "P"
                                End If
                            ElseIf column.MappingName = "Débitos" Or column.MappingName = "Créditos" Or column.MappingName = "Saldo" Then
                                column.Width = 100
                                column.NullText = 0.ToString(Round)
                                column.Format = "##,###0.00"
                                column.Alignment = HorizontalAlignment.Right
                            ElseIf column.MappingName = "Factura" Then
                                column.Width = 90
                            ElseIf column.MappingName = "Tipo Factura" Then
                                column.Width = 150
                            ElseIf column.MappingName = "Forma de Pago" Then
                                column.Width = 150
                            ElseIf column.MappingName = "Acción" Then
                                column.Width = 75
                            ElseIf column.MappingName = "Recibo" Then
                                column.Width = 75
                            ElseIf column.MappingName = "Comprobante" Then
                                column.Width = 95
                            ElseIf column.MappingName = " " Then
                                column.Width = 70
                            End If

                            EstiloGrilla.PreferredRowHeight = 20
                            EstiloGrilla.AllowSorting = False

                            Dim c As Integer
                            Dim Saldo As Double
                            Saldo = 0
                            If Tipo = "C" Then
                                For c = 0 To fuente.Rows.Count - 1
                                    Saldo = Grilla.Item(c, 7) - Grilla.Item(c, 8) + Saldo
                                    Grilla.Item(c, 9) = Saldo.ToString(Round)
                                Next
                            ElseIf Tipo = "P" Then
                                For c = 0 To fuente.Rows.Count - 1
                                    Saldo = Grilla.Item(c, 8) - Grilla.Item(c, 7) + Saldo
                                    Grilla.Item(c, 9) = Saldo.ToString(Round)
                                Next
                            End If


                        End If

                        If Grilla.Name = "dgDepositos" Then
                            If column.MappingName = "Recibo" Or column.MappingName = "Factura" Or column.MappingName = "Fecha" Or column.MappingName = "No Cheque" Then
                                column.Width = 100
                            End If
                        End If

                        If Grilla.Name = "dgDepositosLista" Then
                            If column.MappingName.ToUpper <> "DEPOSITO_ID" And column.MappingName.ToUpper <> "NOMBRE" And column.MappingName.ToUpper <> "BANCO_CUENTA" Then
                                column.Width = 0
                            ElseIf column.MappingName.ToUpper = "DEPOSITO_ID" Then
                                column.HeaderText = "No."
                                column.Width = 25
                            ElseIf column.MappingName.ToUpper = "BANCO_CUENTA" Then
                                column.HeaderText = "Cuenta"
                                column.Width = 50
                            End If
                            EstiloGrilla.AllowSorting = False
                        End If

                        If Grilla.Name = "dgCobrosTotales" Then
                            If column.MappingName.ToUpper = "Valor" Then
                                column.Width = 100
                                column.Format = "##,###0.00"
                                column.Alignment = HorizontalAlignment.Right
                            End If
                            If column.MappingName.ToUpper = "ASIGNADOS" Or column.MappingName.ToUpper = "PENDIENTES" Then
                                column.Width = 100
                                column.Alignment = HorizontalAlignment.Right
                            End If
                            If column.MappingName.ToUpper = "CANT. CKS" Then
                                column.Width = 75
                                column.Alignment = HorizontalAlignment.Right
                            End If
                        End If

                        If Grilla.Name = "dgArticuloCCAcumulado" Then
                            If column.MappingName.ToUpper = "ENTRADAS" Or column.MappingName.ToUpper = "SALIDAS" Then
                                column.NullText = "0"
                                column.Alignment = HorizontalAlignment.Right
                                column.Width = 55
                            ElseIf column.MappingName.ToUpper = "MONTO" Or column.MappingName.ToUpper = "MONTO1" Then
                                column.HeaderText = "Monto"
                                column.NullText = 0.ToString(Round)
                                column.Format = "##,###0.00"
                                column.Alignment = HorizontalAlignment.Right
                                column.Width = 90
                            ElseIf column.MappingName.ToUpper = "MES" Then
                                column.Width = 80
                            End If
                        ElseIf Grilla.Name = "dgAreasAcumulados" Then
                            If column.MappingName.ToUpper = "ENTRADAS" Or column.MappingName.ToUpper = "SALIDAS" Then
                                column.HeaderText = ""
                                column.NullText = "0"
                                column.Alignment = HorizontalAlignment.Right
                                column.Width = 0
                            ElseIf column.MappingName.ToUpper = "MONTO" Then
                                column.NullText = 0.ToString(Round)
                                column.Format = "##,###0.00"
                                column.Alignment = HorizontalAlignment.Right
                                column.Width = 100
                            ElseIf column.MappingName.ToUpper = "MES" Then
                                column.Width = 85
                            End If
                        End If

                        If Grilla.Name = "dgFacturasP" Then
                            If column.MappingName = "Forma de Pago" Then
                                column.Width = 100
                            ElseIf column.MappingName = "Cuenta" Or column.MappingName = "Codigo" Or column.MappingName = "Monto" Or column.MappingName = "Descuento" Or column.MappingName = "Sub Total" Or column.MappingName = "IVA" Then
                                column.Width = 0
                                column.HeaderText = ""
                            ElseIf column.MappingName = "Monto a Pagar" Then
                                column.Format = "##,###0.00"
                                column.Alignment = HorizontalAlignment.Right
                                column.Width = 100
                                column.ReadOnly = False

                                'Dim x As System.EventArgs
                                'Dim y As System.Windows.Forms.DataGridTextBox

                                AddHandler column.TextBox.Leave, New EventHandler(AddressOf TextBoxMontoLeaveHandler)
                            ElseIf column.MappingName = "Nombre" Then
                                column.HeaderText = "Proveedor"
                                column.Width = 300
                            ElseIf column.MappingName = "Fecha" Then
                                column.Width = 90
                            End If
                        End If

                        If Grilla.Name = "dgComprobantes" Then
                            If column.MappingName = "Factura" Or column.MappingName = "Proveedor" Then
                                column.Width = 0
                            End If
                        End If

                        EstiloGrilla.HeaderFont = Grilla.HeaderFont
                        EstiloGrilla.GridColumnStyles.Add(column)

                    End If
                End If
                i += 1
            End While

            'Grilla.TableStyles.Clear()
            If Grilla.Name = "dgTasaCambio" Or Grilla.Name = "dgAcumulados" Or Grilla.Name = "dgCatalogoAcumulados" Or Grilla.Name = "dgVentas" Or Grilla.Name = "dgAcumuladosProductos" Or Grilla.Name = "dgVentasServicios" Or Grilla.Name = "dgAcumuladosProductos1" Then
                EstiloGrilla.AllowSorting = False
                If Grilla.Name = "dgAcumulados" Or Grilla.Name = "dgCatalogoAcumulados" Or Grilla.Name = "dgVentas" Or Grilla.Name = "dgAcumuladosProductos" Or Grilla.Name = "dgVentasServicios" Or Grilla.Name = "dgAcumuladosProductos1" Then

                    Dim fila As DataRow = fuente.NewRow()

                    '
                    Dim filaPresupuesto As DataRow = fuente.NewRow()
                    Dim filaDebe As DataRow = fuente.NewRow()
                    Dim filaHaber As DataRow = fuente.NewRow()
                    Dim filaSaldo As DataRow = fuente.NewRow()

                    Dim x As Integer
                    Dim total As Double

                    Dim TotalPresupuesto As Double
                    Dim TotalDebe As Double
                    Dim TotalHaber As Double
                    Dim TotalSaldo As Double

                    Dim TotalVentas As Double
                    Dim TotalComisiones As Double

                    Dim TotalEntradas As Double
                    Dim TotalUnidades As Double
                    Dim TotalUnidadesEntrada As Double

                    Dim TotalServicios As Double
                    Dim TotalServiciosValor As Double

                    total = 0

                    TotalPresupuesto = 0
                    TotalDebe = 0
                    TotalHaber = 0
                    TotalSaldo = 0

                    TotalVentas = 0
                    TotalComisiones = 0

                    TotalUnidades = 0

                    TotalEntradas = 0
                    TotalUnidadesEntrada = 0

                    TotalServicios = 0
                    TotalServiciosValor = 0

                    If Grilla.Name = "dgCatalogoAcumulados" Then
                        For x = 0 To fuente.Rows.Count - 1
                            'If dsFicha.Tables("Tabla").Rows(0).Item("Cargo_anterior") Is DBNull.Value Then
                            If Grilla.Item(x, 1) Is DBNull.Value Then
                                '
                            Else
                                'TotalPresupuesto = TotalPresupuesto + Grilla.Item(x, 1)
                            End If

                            If Grilla.Item(x, 2) Is DBNull.Value Then
                                '
                            Else
                                TotalDebe = TotalDebe + Grilla.Item(x, 2)
                            End If

                            If Grilla.Item(x, 3) Is DBNull.Value Then
                                '
                            Else
                                TotalHaber = TotalHaber + Grilla.Item(x, 3)
                            End If

                            If Grilla.Item(x, 4) Is DBNull.Value Then
                                '
                            Else
                                TotalSaldo = TotalSaldo + Grilla.Item(x, 4)
                            End If

                            If Grilla.Item(x, 1) Is DBNull.Value Then
                                '
                            Else
                                'total = total + Grilla.Item(x, 1)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        'fila("Presupuesto") = TotalPresupuesto.ToString(Round)
                        fila("Debe") = TotalDebe.ToString(Round)
                        fila("Haber") = TotalHaber.ToString(Round)
                        fila("Saldo") = (TotalDebe.ToString(Round) - TotalHaber.ToString(Round)).ToString(Round)

                        'fila("Numero_Mes") = 13

                        fuente.Rows.Add(fila)

                    ElseIf Grilla.Name = "dgAcumulados" Then

                        'For x = 0 To fuente.Rows.Count - 1

                        '    If Grilla.Item(x, 1) Is DBNull.Value Then
                        '        '
                        '    Else
                        '        total = total + Grilla.Item(x, 1)
                        '    End If

                        'Next

                        'fila("Mes") = "TOTAL"
                        'fila("Monto") = total.ToString(Round)


                        'fuente.Rows.Add(fila)

                    ElseIf Grilla.Name = "dgVentas" Then
                        For x = 0 To fuente.Rows.Count - 1
                            If Grilla.Item(x, 2) Is DBNull.Value Then
                                '
                            Else
                                TotalVentas = TotalVentas + Grilla.Item(x, 2)
                            End If

                            If Grilla.Item(x, 3) Is DBNull.Value Then
                                '
                            Else
                                TotalComisiones = TotalComisiones + Grilla.Item(x, 3)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        fila("Ventas") = TotalVentas.ToString(Round)
                        fila("Comision") = TotalComisiones.ToString(Round)

                        'fila.Item(0).Color = Grilla.BackColor.FromArgb(255, 0, 0)

                        fuente.Rows.Add(fila)

                    ElseIf Grilla.Name = "dgAcumuladosProductos" Or Grilla.Name = "dgAcumuladosProductos1" Then
                        For x = 0 To fuente.Rows.Count - 1

                            If Grilla.Item(x, 2) Is DBNull.Value Then
                                '
                            Else
                                TotalUnidadesEntrada = TotalUnidadesEntrada + Grilla.Item(x, 2)
                            End If

                            If Grilla.Item(x, 3) Is DBNull.Value Then
                                '
                            Else
                                TotalEntradas = TotalEntradas + Grilla.Item(x, 3)
                            End If

                            If Grilla.Item(x, 4) Is DBNull.Value Then
                                '
                            Else
                                TotalUnidades = TotalUnidades + Grilla.Item(x, 4)
                            End If

                            If Grilla.Item(x, 6) Is DBNull.Value Then
                                '
                            Else
                                TotalVentas = TotalVentas + Grilla.Item(x, 6)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        fila("Salidas") = TotalUnidades
                        fila("Valor") = TotalVentas.ToString(Round)
                        fila("Entrada") = TotalUnidadesEntrada
                        fila("Valor_Entrada") = TotalEntradas.ToString(Round)

                        fuente.Rows.Add(fila)

                        'fila.Item(0).Color = Grilla.BackColor.FromArgb(255, 0, 0)
                    ElseIf Grilla.Name = "dgVentasServicios" Then
                        For x = 0 To fuente.Rows.Count - 1
                            If Grilla.Item(x, 2) Is DBNull.Value Then
                                '
                            Else
                                TotalServicios = TotalServicios + Grilla.Item(x, 2)
                            End If

                            If Grilla.Item(x, 4) Is DBNull.Value Then
                                '
                            Else
                                TotalServiciosValor = TotalServiciosValor + Grilla.Item(x, 4)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        fila("Unidades") = TotalServicios
                        fila("Valor") = TotalServiciosValor.ToString(Round)

                        'fila.Item(0).Color = Grilla.BackColor.FromArgb(255, 0, 0)

                        fuente.Rows.Add(fila)

                    End If
                End If

            End If
            'EstiloGrilla.BackColor = Grilla.BackColor.FromArgb(225, 236, 236)
            EstiloGrilla.AlternatingBackColor = Color.LightBlue 'Grilla.BackColor.FromArgb(225, 236, 236)
            Grilla.TableStyles.Add(EstiloGrilla)

            'Grilla.TableStyles.Item(0).BackColor = Grilla.BackColor.CadetBlue
            'Grilla.TableStyles.Item(0).PreferredRowHeight = 1000
            'Grilla.AlternatingBackColor = Grilla.BackColor.Black
            'Grilla.TableStyles.Item(0).BackColor = Grilla.BackColor.FromArgb(225, 236, 236) 'Grilla.BackColor.FromArgb(200, 223, 212)
            Grilla.TableStyles.Item(0).GridLineColor = Grilla.BackColor.SteelBlue
            Grilla.TableStyles.Item(0).HeaderBackColor = Grilla.BackColor.LightSteelBlue

            'Grilla = Grilla.BackColor.FromArgb(255, 0, 0)


            'Grilla.TableStyles.Item(0).

            'Grilla.TableStyles.Item(0). = Grilla.BackColor.CadetBlue
            'Grilla.TableStyles.Item(0).RowHeadersVisible = False
            'Grilla.TableStyles.Item(0).RowHeaderWidth = 10

        End Function

        'Al estar declarado como Shared, podemos usarlo sin crear
        'una instancia de la clase
        Public Shared Sub CambiarEstilo(ByVal tControl As Control)
            ' '' Cambiar el estilo del control...
            ' '' sólo si es uno de los indicados
            ''Select Case tControl.GetType.Name
            ''    ''''''Case "Label"
            ''    ''''''    CType(tControl, Label).FlatStyle = FlatStyle.System
            ''    Case "CheckBox"
            ''        CType(tControl, CheckBox).FlatStyle = FlatStyle.System
            ''    Case "RadioButton"
            ''        CType(tControl, RadioButton).FlatStyle = FlatStyle.System
            ''    Case "Button"
            ''        ' Si el botón tiene asignada la propiedad Image     (11/Oct/02)
            ''        ' no cambiarlo...
            ''        Dim tButton As Button = CType(tControl, Button)
            ''        If tButton.Image Is Nothing Then
            ''            tButton.FlatStyle = FlatStyle.System
            ''        End If
            ''    Case "GroupBox"
            ''        CType(tControl, GroupBox).FlatStyle = FlatStyle.System
            ''End Select
            ' ''
            ' '' Cambiar también los controles contenidos en cada control...
            ''If tControl.Controls.Count > 0 Then
            ''    Dim tControl2 As Control
            ''    '
            ''    For Each tControl2 In tControl.Controls
            ''        CambiarEstilo(tControl2)
            ''    Next
            ''End If
        End Sub

        Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)

            Dim s As String
            s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
            Console.WriteLine(s)

        End Sub

        'Private Sub etProveedores_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etProveedores.MouseEnter
        '    etProveedores.BackColor = etGenerales.BackColor.White
        '    etProveedores.ForeColor = etGenerales.BackColor.FromArgb(0, 51, 102)

        'End Sub

        Public Shared Sub EntrarMouse(ByVal Etiqueta As Label)
            Etiqueta.BackColor = Etiqueta.BackColor.White
            Etiqueta.ForeColor = Etiqueta.BackColor.FromArgb(0, 51, 102)

        End Sub

        Public Shared Sub SalirMouse(ByVal Etiqueta As Label)
            Etiqueta.BackColor = Etiqueta.BackColor.FromArgb(0, 51, 102)
            Etiqueta.ForeColor = Etiqueta.BackColor.White
        End Sub

        Public Shared Function Letras(ByVal tyCantidad As Double, Optional ByVal Moneda As String = "") As String

            Dim i As Integer
            Dim lyCantidad As Double, lyCentavos As Double, lnDigito As Byte, lnPrimerDigito As Byte, lnSegundoDigito As Byte, lnTercerDigito As Byte, lcBloque As String, lnNumeroBloques As Byte, lnBloqueCero
            'Redondea el valor a dos coma flotante
            tyCantidad = Math.Round(tyCantidad, 2)
            'Redondea el valor sin coma flotante
            lyCantidad = Int(tyCantidad)
            'Nos determina la cantidad de centavos
            lyCentavos = (tyCantidad - lyCantidad) * 100

            '  string data [] = new string [] { "a", "b", "c", "d", "e" };

            Dim laUnidades() As String = {"Un", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorce", "Quince", "Dieciseis", "Diecisiete", "Dieciocho", "Diecinueve", "Veinte", "Veintiun", "Veintidos", "Veintitres", "Veinticuatro", "Veinticinco", "Veintiseis", "Veintisiete", "Veintiocho", "Veintinueve"}


            'Arreglo que nos determina las unidades de los numeros llega hasta veintinueve porque de ahi en adelante los numeros son iguales
            '  laUnidades = Array("Un", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorce", "Quince", "Diesiseis", "Diesisiete", "Diesiocho", "Diesinueve", "Veinte", "Veintiun", "Veintidos", "Veintitres", "Veinticuatro", "Veinticinco", "Veintiseis", "Veintisiete", "Veintiocho", "Veintinueve")
            'Arreglo que nos determina las decenas de los numeros
            Dim laDecenas() As String = {"Diez", "Veinte", "Treinta", "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa"}
            'Arreglo que nos determina las centenas de los numeros
            Dim laCentenas() As String = {"Ciento", "Doscientos", "Trescientos", "Cuatrocientos", "Quinientos", "Seiscientos", "Setecientos", "Ochocientos", "Novecientos"}
            'Nos indica los bloques de tres que se peocesan. Inicialmente es uno. Unidades, decenas y centenas.
            lnNumeroBloques = 1

            Do
                lnPrimerDigito = 0
                lnSegundoDigito = 0
                lnTercerDigito = 0
                lcBloque = ""
                lnBloqueCero = 0

                'Ciclo for que nos determina con cada ciclo las unidades (1) decenas (2) centenas (3)
                For i = 1 To 3
                    'lnDigito toma el residuo de lyCantidad dividido entre diez
                    lnDigito = lyCantidad Mod 10
                    If lnDigito <> 0 Then
                        Select Case i
                            Case 1
                                'Asigna nombre a las unidades. i vale una indicando que son unidades
                                lcBloque = " " & laUnidades(lnDigito - 1)
                                lnPrimerDigito = lnDigito
                            Case 2
                                If lnDigito <= 2 Then
                                    lcBloque = " " & laUnidades((lnDigito * 10) + lnPrimerDigito - 1)
                                Else
                                    lcBloque = " " & laDecenas(lnDigito - 1) & IIf(lnPrimerDigito <> 0, " Y", System.DBNull.Value) & lcBloque
                                End If
                                lnSegundoDigito = lnDigito
                            Case 3
                                lcBloque = " " & IIf(lnDigito = 1 And lnPrimerDigito = 0 And lnSegundoDigito = 0, "Cien", laCentenas(lnDigito - 1)) & lcBloque
                                lnTercerDigito = lnDigito
                        End Select
                    Else
                        lnBloqueCero = lnBloqueCero + 1
                    End If
                    lyCantidad = Int(lyCantidad / 10)
                    If lyCantidad = 0 Then
                        Exit For
                    End If
                Next i
                Select Case lnNumeroBloques
                    Case 1
                        Letras = lcBloque
                    Case 2
                        Letras = lcBloque & IIf(lnBloqueCero = 3, System.DBNull.Value, " Mil") & Letras
                    Case 3
                        Letras = lcBloque & IIf(lnPrimerDigito = 1 And lnSegundoDigito = 0 And lnTercerDigito = 0, " Millon", " Millones") & Letras
                End Select
                lnNumeroBloques = lnNumeroBloques + 1
            Loop Until lyCantidad = 0
            'No escribe la cadena final de la conversion con la cantida de centavos si existen

            'SE deja en comentario el nombre de la moneda hasta que se agregue una opcion de incluir descripcion de la 
            'moneda dentro del cheque segun el registro en la tabla monedas BRobelo 26092007
            'Letras = (Letras & IIf(tyCantidad > 1, " Cordobas ", " Cordoba ") & " CON " & CInt(lyCentavos) & "/100").ToString.ToUpper
            Letras = (Letras & IIf(tyCantidad > 1, " ", "") & Moneda & " CON " & CInt(lyCentavos).ToString.PadLeft(2, "0"c) & "/100").ToString.ToUpper
            'Format(Str(lyCentavos), "00")
        End Function

        Public Shared Function TasaCambio(ByVal Fecha As Date) As Double
            Dim variables As New ArrayList
            Dim Datos As New ArrayList

            variables.Add("Empresa")
            variables.Add("Fecha")

            Datos.Add(EmpresaActual)
            Datos.Add(Fecha)

            Dim DT As DataTable = ProcedureParameters(Datos, variables, "sp_GetTasaCambio")

            Return DT.Rows.Item(0)("Tasa")
        End Function

        'Public Shared Function ConvertToXElement(ByVal json As String, ByVal enc As Encoding) As XElement

        '    Dim data As Byte() = enc.GetBytes(json)

        '    Using ms As New MemoryStream(data)

        '        Using xmlReader As XmlDictionaryReader = JsonReaderWriterFactory.CreateJsonReader(ms, enc, New XmlDictionaryReaderQuotas, Nothing)

        '            Return XElement.Load(xmlReader)

        '        End Using




        '    End Using

        'End Function

    End Class



End Namespace

'Hablando de Felicidad en la Seccion de la prensa: Cartar al Director la frase de Valor del Dia es:
'Felicidad 
'“El bien de la humanidad debe consistir en que cada uno goce al máximo de la
' felicidad que pueda, sin disminuir la felicidad de los demás”. 

'Frases de valor
'Hablar 
'“Quien de verdad sabe de qué habla, no encuentra razones para levantar la voz”. 
'Leonardo Da Vinci,pintor, escultor e inventor italiano (1452-1519) 
