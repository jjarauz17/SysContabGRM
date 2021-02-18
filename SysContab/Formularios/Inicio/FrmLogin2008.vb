Imports ClasesBLL
Imports Entities

Public Class FrmLogin2008

    Dim Rutinas As New VB.SysContab.Rutinas()    
    Dim Empresa As New VB.SysContab.EmpresasDB
    Dim EmpresaDetalle As New VB.SysContab.EmpresasDetails()    
    Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
        'End
    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaceptar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        Try
            Login = Me.txtlogin.Text.ToString.ToUpper
            Password = Me.txtpassword.Text

            Usuario = Login
            UPassword = Password

            'Inicializar Variables Globales para Conexion en Modulo BLL
            LoginN = Login
            PasswordN = Password

            'UserDetails = VB.SysContab.SeguridadDB.Login(txtlogin.Text, txtpassword.Text)
            'Usuario_ID = UserDetails.UserID.ToString 'VB.SysContab.SeguridadDB.Login(txtLogin.Text, txtPassword.Text).UserID.ToString
            'Usuario_ID = VB.SysContab.SeguridadDB.Login(txtLogin.Text, txtPassword.Text).UserID.ToString
            'Usr_Rol = UserDetails.Role
            ' Dim dt As DataTable = ObtieneDatos("select * from Usuarios u WHERE u.Usr_Login = '" & txtlogin.Text & "' and u.Usr_Password = '" & txtpassword.Text & "'")

            Dim DT As DataTable =
                VB.SysContab.SeguridadDB.GetLogin(
                txtlogin.Text,
                txtpassword.Text)

            If DT.Rows.Count > 0 Then

                If DT.Rows.Item(0)("Usr_Habilitado") Then

                    'Buscar Empresas Asignadas al Usuario
                    Dim ds As DataSet = Empresa.EmpresasXUsuarios(Login, Password)

                    Usuario_ID = DT.Rows.Item(0)("Usr_Id")
                    Usr_Rol = DT.Rows.Item(0)("Usr_Rol")
                    Usr_Mail = DT.Rows.Item(0)("Usr_email")
                    Usr_Nombre = DT.Rows.Item(0)("Usr_NombreCompleto")

                    '/****************************************************************
                    '***  Registrando Version de Sistema Actual
                    '/****************************************************************
                    Dim obj As New Auditoria_Versiones
                    Dim db As New db_Auditoria_Versiones

                    obj.Usr_Id = Usuario_ID
                    obj.Version = GetVersion(ProductVersion)

                    db.Insertar(obj)
                    '/****************************************************************
                    '***    Fin Registrando Version de Sistema Actual
                    '/****************************************************************

                    If ds.Tables(0).Rows.Count = 1 Then
                        Seleccionar(ds)
                    Else
                        frmSeleccionEmpresa.ShowDialog()
                        frmSeleccionEmpresa.Dispose()

                        DialogResult = Windows.Forms.DialogResult.OK
                        Dispose()

                        frmPrincipalRibbon.Show()
                        frmPrincipalRibbon.WindowState = FormWindowState.Maximized
                    End If
                    '
                    RecordarUsuario()
                Else
                    XtraMsg("El Usuario: " & txtlogin.Text & " se encuentra Deshabilitado, favor consulte al administrador del Sistema.", MessageBoxIcon.Warning)
                End If
            Else
                XtraMsg("Acceso Denegado", MessageBoxIcon.Exclamation)
                Me.txtpassword.Focus()
                Me.txtpassword.SelectAll()
            End If

            'If Usuario_ID <> String.Empty Then
            '    'Me.Hide()
            '    Dim f As frmSeleccionarEmpresa = frmSeleccionarEmpresa.Instance()
            '    f.Show()
            '    Me.Close()
            'Else
            '    XtraMsg("Acceso Denegado", MessageBoxIcon.Exclamation)
            '    Me.txtpassword.Focus()
            '    Me.txtpassword.SelectAll()
            'End If
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)

            Me.txtpassword.Focus()
            Me.txtpassword.SelectAll()
        End Try
    End Sub

    Private Sub Seleccionar(ds As DataSet)
        ShowSplash("Cargando Interfaz de Usuario...")

        EmpresaActual = ds.Tables(0).Rows.Item(0)("Codigo")
        NombreEmpresaActual = ds.Tables(0).Rows.Item(0)("Nombre")
        EmpresaA = EmpresaActual


        EmpresaDetalle = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails()

        MonedaBase = EmpresaDetalle.MonedaBase
        Round = "n" & EmpresaDetalle.Decimales
        RoundP = "n" & ConfigDetalles.Decimales

        'GuardaDatos("_AuditoriaEmpresa '" & formtitulo & "'," & EmpresaActual & ",2,'',''")
        'AuditoriaEmpresa.AuditoriaSelEmpresa(formtitulo, 2)


        Dim lds As New DataSet
        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        lds.WriteXml(Application.StartupPath & "\xml\logoempresa.xml", XmlWriteMode.WriteSchema)
        '                
        'CierreDeDia()
        CierreDia = BuscarUltimoCierre().Date

        DialogResult = DialogResult.OK
        Dispose()
        '
        frmPrincipalRibbon.Show()
        frmPrincipalRibbon.WindowState = FormWindowState.Maximized
        '
        'Me.Close()
        'Me.Dispose()

        HideSplash()
        'Me.Hide()
        'FormPrincipal.ShowDialog()
        'Activar para modulos cortos. Recoradr activar el corrspondiente en frmPrincipalFacturacion y Contab, y en modulo1
        'Dim N As frmPrincipalCortos = N.Instance
        'N.ShowDialog()
        'Me.Close()
    End Sub

    Sub RecordarUsuario()
        If Me.CheckEdit1.CheckState = CheckState.Checked Then
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NLogin", Encrypt(txtlogin.Text))
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NClave", Encrypt(txtpassword.Text))
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NCheck", CheckEdit1.CheckState)
        Else
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NLogin", Encrypt(""))
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NClave", Encrypt(""))
            SaveSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NCheck", False)
        End If
    End Sub

    Private Sub FrmLogin2008_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess().Kill()
        'CerrarProceso()
    End Sub

    Private Sub FrmLogin2008_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        'If Not File.Exists(Application.StartupPath & "\Configurar.ini") Then
        '    XtraMsg("Falta el archivo de configuracion: Configurar.ini", MessageBoxIcon.Exclamation)
        'End If
        'Buscar Estilo Actual
        'If ObtieneDatos("SELECT * FROM Estilo_Actual ea WHERE ea.PC = '" & My.Computer.Name & "'", 1).Rows.Count = 0 Then
        '    GuardaDatos("_EstiloActual '" & My.Computer.Name & "','Black',0", 1)
        'End If
        'EstiloActual = ObtieneDatos("SELECT * FROM Estilo_Actual ea WHERE ea.PC = '" & My.Computer.Name & "'", 1).Rows.Item(0)("Estilo")
        'My.Forms.frmPrincipalRibbon.master.LookAndFeel.SkinName = EstiloActual
        ''My.Forms.frmPrincipalRibbon.master.LookAndFeel.SkinName = EstiloActual

        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(LeeEstilo())
        Me.Text = "Ingresar a " & formtitulo

        lblpublicacion.Text = GetVersion(ProductVersion)

        'Recordar Usuario
        If GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NLogin") <> Nothing Then
            txtlogin.Text = Decrypt((GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NLogin"))).ToString
            txtpassword.Text = Decrypt((GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NClave"))).ToString
            CheckEdit1.CheckState = (GetSetting(My.Application.Info.ProductName.ToString, "CxCadena", "NCheck"))
        End If

        ' CerrarProceso()

        If PublishPrueba = True Then
            EscribeData(My.Settings.Servidor, My.Settings.BaseDatos, String.Empty, String.Empty)
        End If

    End Sub

    Private Sub bConfiguar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bConfiguar.Click
        FrmConfiguracionServer.Inicio = 1
        FrmConfiguracionServer.ShowDialog()
        FrmConfiguracionServer.Dispose()
    End Sub
End Class