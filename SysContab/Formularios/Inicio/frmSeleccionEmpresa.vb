Imports ClasesBLL
Imports Entities

Public Class frmSeleccionEmpresa

    Dim Empresa As New VB.SysContab.EmpresasDB
    Dim Config As New VB.SysContab.ConfiguracionDB
    Dim EmpresaDetalle As New VB.SysContab.EmpresasDetails()
    Dim AuditoriaEmpresa As New VB.SysContab.AuditoriaDB
    Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails

    Private Sub frmSeleccionEmpresa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmSeleccionEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbEmpresas.Properties.DataSource = Empresa.EmpresasXUsuarios(Login, Password).Tables("Empresas")
            cbEmpresas.Properties.ValueMember = "Codigo"
            cbEmpresas.Properties.DisplayMember = "Nombre"
            cbEmpresas.Properties.PopulateColumns()
            '
            For i As Integer = 0 To Me.cbEmpresas.Properties.Columns.Count - 1
                Me.cbEmpresas.Properties.Columns(i).Visible = False
            Next
            '
            Me.cbEmpresas.Properties.Columns(1).Visible = True
            cbEmpresas.ItemIndex = 0
            '
            If Empresa.EmpresasXUsuarios(Login, Password).Tables("Empresas").Rows.Count = 1 Then
                Seleccionar()
            ElseIf Empresa.EmpresasXUsuarios(Login, Password).Tables("Empresas").Rows.Count = 0 Then
                With My.Forms.FrmNewBusiness
                    If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                        End
                    Else
                        .Dispose()
                        '
                        Me.Close()
                        My.Forms.frmPrincipalRibbon.Show()
                        My.Forms.frmPrincipalRibbon.WindowState = FormWindowState.Maximized
                    End If
                End With
            Else
                'Me.Text = "** Seleccionar Empresa **"
            End If

        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Dispose()
        End Try
    End Sub

    Private Sub cmdSeleccionar_Click(sender As Object, e As EventArgs) Handles cmdSeleccionar.Click
        Me.Seleccionar()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
        'CerrarProceso()
        'End
        Process.GetCurrentProcess().Kill()
    End Sub

    Private Sub Seleccionar()
        ShowSplash("Cargando Interfaz de Usuario...")

        EmpresaActual = cbEmpresas.EditValue
        NombreEmpresaActual = cbEmpresas.Text
        EmpresaA = EmpresaActual

        EmpresaDetalle = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails()

        MonedaBase = EmpresaDetalle.MonedaBase
        Round = "n" & EmpresaDetalle.Decimales

        Try
            RoundP = "n" & ConfigDetalles.Decimales
        Catch ex As Exception
            RoundP = "n2"
        End Try

        'GuardaDatos("_AuditoriaEmpresa '" & formtitulo & "'," & EmpresaActual & ",2,'',''")
        'AuditoriaEmpresa.AuditoriaSelEmpresa(formtitulo, 2)

        Dim lds As New DataSet
        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        lds.WriteXml(Application.StartupPath & "\xml\logoempresa.xml", XmlWriteMode.WriteSchema)
        '                
        'CierreDeDia()
        CierreDia = BuscarUltimoCierre().Date

        'frmPrincipalRibbon.Show()
        'frmPrincipalRibbon.WindowState = FormWindowState.Maximized
        ''
        'Me.Close()
        Me.Dispose()

        HideSplash()
        'Me.Hide()
        'FormPrincipal.ShowDialog()
        'Activar para modulos cortos. Recoradr activar el corrspondiente en frmPrincipalFacturacion y Contab, y en modulo1
        'Dim N As frmPrincipalCortos = N.Instance
        'N.ShowDialog()
        'Me.Close()
    End Sub


End Class