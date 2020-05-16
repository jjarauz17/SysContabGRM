Public Class RolesDB

    Public Shared Function UsuarioMenu() As DataTable

        'Poner Invisible todos los Botones
        With frmPrincipalRibbon.RibbonControl


            'Poner Invisible las Paginas Categorias y sus Paginas
            For Each c As Object In .PageCategories

                For i As Integer = 0 To c.Pages.Count - 1
                    c.Pages.Item(i).Visible = False
                Next

            Next

            'For Each c As Object In .PageCategories
            '    If TypeOf c Is DevExpress.XtraBars.Ribbon.RibbonPageCategory Then c.Visible = False
            'Next

            'Poner Invisibles las Paginas
            For Each c As Object In .Pages
                If TypeOf c Is DevExpress.XtraBars.Ribbon.RibbonPage Then c.Visible = False
            Next

            'Poner invisibles los Botones
            For Each c As Object In .Items
                If TypeOf c Is DevExpress.XtraBars.BarButtonItem Then c.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Next
            '
        End With

        ''Habilitar Botones de Info General
        'With frmPrincipalRibbon.RibbonControl
        '    For Each c As Object In .Pages
        '        'Recorrer Todoas las Pestañas del Menu Principal
        '        If TypeOf c Is DevExpress.XtraBars.Ribbon.RibbonPage Then
        '            Dim Pestana As DevExpress.XtraBars.Ribbon.RibbonPage = c
        '            'XtraMsg(Pestana.Text)

        '            'Recorrer Cada Grupo Asociado a la Pestaña
        '            For i As Integer = 0 To Pestana.Groups.Count - 1
        '                Dim Grupo As DevExpress.XtraBars.Ribbon.RibbonPageGroup = Pestana.Groups(i)

        '                'Grupo.
        '                'XtraMsg(Grupo.Text)
        '                'XtraMsg(Grupo.Ribbon.Items.Count.ToString)

        '                Dim Contador As Integer = 0

        '                For Each s As Object In Grupo.Page.Ribbon.Items
        '                    XtraMsg(s.Name)
        '                    If TypeOf s Is DevExpress.XtraBars.BarButtonItem Then
        '                        If s.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then Contador += 1
        '                    End If
        '                Next

        '                If Contador = 0 Then Grupo.Visible = False


        '                'Contador = 0

        '                'For Each s As Object In Grupo.Page.Ribbon.Items
        '                '    XtraMsg(s.Name)
        '                '    If TypeOf s Is DevExpress.XtraBars.BarButtonItem Then
        '                '        If s.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then Contador += 1
        '                '    End If
        '                'Next

        '                'If Contador = 0 Then Grupo.Visible = False

        '                'XtraMsg(Pestana.Groups(i).Text)
        '            Next
        '        End If
        '    Next
        'End With

        'Habilitar Botones de Info General
        With frmPrincipalRibbon
            .rgbSkin.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            .etFecha.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            .etPeriodo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            .bCierreDia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            .etServidor.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            .etBase.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            .etUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End With

        Dim DT As DataTable = ObtieneDatos("_REST_GetMenuUsuario " & Usr_Rol & "")

        Try
            'Buscar Opciones en el Menu que se activarán
            With My.Forms.frmPrincipalRibbon.RibbonControl
                For Each c As Object In .Pages

                    If TypeOf c Is DevExpress.XtraBars.Ribbon.RibbonPage Then

                        For i As Integer = 0 To DT.Rows.Count - 1
                            If c.Name = DT.Rows.Item(i)("Control") Then
                                c.visible = True
                                ' If c.Name = "rGenerales" Or c.Name = "rContables" Or c.Name = "rInventario" Then frmPrincipalRibbon.rPageCategoria.Visible = True
                            End If
                        Next
                    End If
                Next
                '
                For Each c As Object In .PageCategories

                    Dim rpCat As DevExpress.XtraBars.Ribbon.RibbonPageCategory = c

                    For i As Integer = 0 To rpCat.Pages.Count - 1
                        For j As Integer = 0 To DT.Rows.Count - 1
                            If rpCat.Pages.Item(i).Name = DT.Rows.Item(j)("Control") Then
                                rpCat.Pages.Item(i).Visible = True
                                c.Visible = True
                            End If
                        Next
                    Next

                Next
            End With
        Catch ex As Exception
        End Try

        Return DT
    End Function

    Public Shared Function UsuarioRecursos() As DataTable      
        Dim dt As DataTable = ObtieneDatos("_REST_GetRecursosUsuario " & Usr_Rol & "")

        For i As Integer = 0 To dt.Rows.Count - 1
            Try
                'Buscar Opciones en el Menu que se activarán
                With My.Forms.frmPrincipalRibbon.RibbonControl
                    For Each c As Object In .Items
                        If TypeOf c Is DevExpress.XtraBars.BarButtonItem Then
                            If c.Name = dt.Rows.Item(i)("Control") Then
                                c.Enabled = True
                                c.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            End If
                        End If

                        If TypeOf c Is DevExpress.XtraBars.BarEditItem Then
                            If c.Name = dt.Rows.Item(i)("Control") Then
                                c.Enabled = True
                                c.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            End If
                        End If
                    Next
                End With
            Catch ex As Exception
            End Try
        Next

        Return dt
    End Function

    Public Shared Function UsuarioAcciones() As DataTable
        Dim dt As DataTable = ObtieneDatos("_REST_GetAccionesUsuario " & Usr_Rol & "," & Recurso & "")
        '
        Return dt
    End Function

    '    Public Shared Sub UsuarioAcciones(ByVal frm As DevExpress.XtraEditors.PanelControl)
    Public Shared Function UsuarioAcciones(ByVal p As DevExpress.XtraEditors.PanelControl) As DataTable
        Dim dt As DataTable = ObtieneDatos("_REST_GetAccionesUsuario " & Usr_Rol & "," & Recurso & "")
        For i As Integer = 0 To dt.Rows.Count - 1
            Try
                For Each c As Object In p.Controls
                    If TypeOf c Is DevExpress.XtraEditors.SimpleButton Then
                        If c.Name = dt.Rows.Item(i)("Control") Then
                            ' MsgBox(c.Name.ToString)
                            c.Enabled = True
                        End If
                    End If
                Next
            Catch ex As Exception
            End Try
        Next
        '
        Return dt
    End Function

    '    Public Shared Sub UsuarioAcciones(ByVal frm As DevExpress.XtraEditors.PanelControl)


    Public Shared Function UsuarioAcciones(ByVal p As DevExpress.XtraLayout.LayoutControl) As DataTable

        Dim dt As DataTable = ObtieneDatos("_REST_GetAccionesUsuario", Usr_Rol, Recurso)
        For i As Integer = 0 To dt.Rows.Count - 1
            Try
                For Each c As Object In p.Controls  '' Nivel 1
                    If TypeOf c Is DevExpress.XtraEditors.SimpleButton Then
                        If c.Name = dt.Rows.Item(i)("Control") Then
                            c.Enabled = True
                        End If
                    End If
                Next
            Catch ex As Exception
            End Try
        Next

        Return dt
    End Function



    Public Shared Sub UsuarioAcciones(ByVal p As GroupBox)
        Dim dt As DataTable = ObtieneDatos("_REST_GetAccionesUsuario " & Usr_Rol & "," & Recurso & "")
        For i As Integer = 0 To dt.Rows.Count - 1
            Try
                For Each c As Object In p.Controls
                    If TypeOf c Is DevExpress.XtraEditors.SimpleButton Then
                        If c.Name = dt.Rows.Item(i)("Control") Then
                            ' MsgBox(c.Name.ToString)
                            c.Enabled = True
                        End If
                    End If
                Next
            Catch ex As Exception
            End Try
        Next
    End Sub
    '- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    Public Shared Function GetRecurso(Control As String) As Integer

        Return ObtieneDatos("sp_sel_REST_Recursos",
                            Control) _
                            .Rows.
                            Item(0)("ID")

    End Function

    '- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

End Class
