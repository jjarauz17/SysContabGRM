Imports System.Linq
Imports System.Threading.Tasks
Imports ClasesBLL
Imports Connectivity
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon

Public Class frmPrincipalRibbon

    Dim dsPuntoVenta As DataSet
    Dim Pv As New VB.SysContab.PuntosVentasDB()
    Dim Cajas As New VB.SysContab.CajasDB()
    Dim Empresa As New VB.SysContab.EmpresasDB
    Dim Fecha_Actual As Date = VB.SysContab.Rutinas.Fecha().Date
    Dim Fecha_Ultimo_Dias As Date = UltimoDia(Fecha_Actual).Date
    Private TC As New db_TasaCambio
    Dim EmpresaDetalle As New VB.SysContab.EmpresasDetails()
    Dim Red As New cl_Red

    'Dim skinsToHide() As String = {"Seven Classic", "DevExpress Style", "Dark", "2010", "2007", "Sharp"}

    'Private Sub HideSkins(ByVal skinsToHide() As String)
    '    For i = 0 To SkinRibbonGalleryBarItem2.Gallery.Groups.Count - 1
    '        Dim group = SkinRibbonGalleryBarItem2.Gallery.Groups(i)
    '        If group Is Nothing Then
    '            Continue For
    '        End If
    '        For j = 0 To group.Items.Count - 1
    '            Dim item = group.Items(j)
    '            If item Is Nothing Then
    '                Continue For
    '            End If
    '            For Each skin In skinsToHide
    '                If item.Caption.Contains(skin) Then
    '                    item.Visible = False
    '                End If
    '            Next skin
    '        Next j
    '    Next i
    'End Sub

    Sub New()
        InitSkins()
        InitializeComponent()
        InitSkinGallery()
        AplicarCulture()
        '
        'HideSkins(skinsToHide)
        'SkinRibbonGalleryBarItem1.Gallery.Groups.Remove(
        '    SkinRibbonGalleryBarItem1.Gallery.Groups.OfType(Of GalleryItemGroup)().First(
        '    Function(x) String.Equals(x.Caption, "Bonus Skins")))

        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(LeeEstilo())
    End Sub

    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub

    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbSkin, True)
    End Sub

    Sub AplicarCulture()
        Dim obj As New VB.SysContab.EmpresasDetails
        obj = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        My.Application.ChangeCulture(IIf(obj.Region = "", My.Application.Culture.Name, obj.Region))
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TC_Mes.Tick
        'Me.etHora.Caption = Now.ToLongTimeString.ToUpper
        'Format(Now.Hour, "00") & ":" & Format(Now.Minute, "00") & ":" & Format(Now.Second, "00")
        'If EmpresaActual = 17 Then Exit Sub

        If Fecha_Actual.Date >= Fecha_Ultimo_Dias.AddDays(-5) Then

            TC.GetTasaCambio(MonedaBase, Fecha_Ultimo_Dias.AddDays(1).Date)

            If TC.Validar_Tasa Then
                If TC.TC_Oficial = 1 Then
                    AlertControl1.Show(Me, "Alerta  de Tasa de Cambio!", TC.MensajeMes & vbCrLf & vbCrLf & vbCrLf &
                              "Clic Aqui para Ingresar Tasa")

                    IniciaContador(300000)
                Else
                    TC_Mes.Enabled = False
                    TC_Mes.Dispose()
                    AlertControl1.Dispose()
                End If
            Else
                TC_Mes.Enabled = False
                TC_Mes.Dispose()
                AlertControl1.Dispose()
            End If


            'If ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo._TCambioDia(" & EmpresaActual & ", '" & Fecha_Ultimo_Dias.AddDays(1).Date & "') TCambio").Rows.Item(0)("TCambio") = 1.0 Then
            '    AlertControl1.Show(Me, "Alerta  de Tasa de Cambio!", "No Existe Tasa de Cambio para el Mes: " & ObtieneDatos("SELECT dbo.fn_Mes(" & Fecha_Ultimo_Dias.AddDays(1).Month & ") Mes").Rows.Item(0)("Mes") & vbCrLf & vbCrLf & vbCrLf &
            '                  "Clic Aqui para Ingresar Tasa")

            '    IniciaContador(300000)
            'End If
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles TC_Dia.Tick

        'If EmpresaActual = 17 Then Exit Sub

        TC.GetTasaCambio(MonedaBase, Fecha_Actual.Date)

        If TC.Validar_Tasa Then
            If TC.TC_Oficial = 1 Then
                AlertControl1.Show(Me, "Alerta  de Tasa de Cambio!", TC.MensajeDia & vbCrLf & vbCrLf & vbCrLf &
                              "Clic Aqui para Ingresar Tasa")

                IniciaContador2(300000)
            Else
                TC_Dia.Enabled = False
                TC_Dia.Dispose()
                AlertControl2.Dispose()
            End If
        Else
            TC_Mes.Enabled = False
            TC_Mes.Dispose()
            AlertControl1.Dispose()
        End If


        'If ObtieneDatos("SET DATEFORMAT dmy; SELECT dbo._TCambioDia(" & EmpresaActual & ", '" & Fecha_Actual.Date & "') TCambio").Rows.Item(0)("TCambio") = 1.0 Then
        '    AlertControl2.Show(Me, "Alerta  de Tasa de Cambio!", "No Existe Tasa de Cambio del Día: " & Fecha_Actual.ToShortDateString & vbCrLf & vbCrLf & vbCrLf &
        '              "Clic Aqui para Ingresar Tasa")

        '    IniciaContador2(30000)
        'Else
        '    TC_Dia.Enabled = True
        '    TC_Dia.Dispose()
        '    AlertControl2.Dispose()
        'End If
    End Sub

    Public Sub IniciaContador(Intervalo As Integer)
        TC_Mes.Enabled = True
        TC_Mes.Interval = Intervalo
        TC_Mes.Start()
    End Sub

    Public Sub IniciaContador2(Intervalo As Integer)
        TC_Dia.Enabled = True
        TC_Dia.Interval = Intervalo
        TC_Dia.Start()
    End Sub

    Public Sub IniciaContador3(Intervalo As Integer)
        TimerRed.Enabled = True
        TimerRed.Interval = Intervalo
        TimerRed.Start()
    End Sub

    Private Sub frmPrincipalRibbon_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Not XtraMsg2("¿ Desea Salir por Completo del Sistema ?", MessageBoxIcon.Question) Then
            e.Cancel = True
        Else
            'Close()
            'End
            'CerrarProceso()
            Process.GetCurrentProcess().Kill()
        End If

    End Sub

    Private Sub frmPrincipalRibbon_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RolesDB.UsuarioMenu()
        '
        Dim DT_ROL As DataTable = RolesDB.UsuarioRecursos()

        If DT_ROL.Rows.Count > 0 Then
            Dim dr() As DataRow = DT_ROL.Select("Control = 'AlertaTCambio'")
            Dim dr2() As DataRow = DT_ROL.Select("Control = 'AlertaTCambioDia'")

            If dr.Length > 0 Then IniciaContador(1000)
            If dr2.Length > 0 Then IniciaContador2(1000)
        End If
        '

        Me.etFecha.Caption = Now.ToLongDateString.ToUpper
        Me.etUsuario.Caption = Login
        Me.etPeriodo.Caption = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Actual).Descripcion.ToString

        Dim s As String() = LeeData()

        etServidor.Caption = s(0).ToString
        etBase.Caption = s(1).ToString

        Me.RibbonControl.ApplicationCaption = formtitulo & " - " & NombreEmpresaActual

        Try
            bCierreDia.Caption = CierreDia.ToShortDateString
        Catch ex As Exception
            bCierreDia.Caption = "Sin Definir"
        End Try

        lblpublicacion.Caption = GetVersion(ProductVersion)
        bEstiloActual.Caption = LeeEstilo()

        Dim pinicio As New DevExpress.XtraBars.Ribbon.RibbonPage
        pinicio = rClientes
        Me.RibbonControl.SelectedPage = pinicio

        '/************ VALIDAR TASA DE CAMBIOS QUE ESTE REGISTRADA ************
        'EmpresaDetalle = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        TC.GetTasaCambio(
            MonedaBase,
            Fecha_Actual.Date)
        '
        ShowTCambio(TC.TC_Oficial)
        'bTCambio.Caption = "T/Cambio = " & TC.TC_Oficial.ToString("n4")

        If TC.Validar_Tasa Then
            If TC.TC_Oficial = 1 Then XtraMsg(TC.MensajeDia.ToUpper & vbCrLf &
                                              "FAVOR INGRESAR TASA DE CAMBIO ANTES DE EMPEZAR A FACTURAR", MessageBoxIcon.Error)
        End If
        '/*********************************************************************


        IniciaContador3(5000)

        '*******   CARGAR LOGO DE LA EMPRESA*****************************
        CargarLogo()
        '****************************************************************

        'Guardar()
        'frmExportarImprimir.Mostrar()



    End Sub

    'Sub CargarEstilos()
    '    vskin = New SkinGalleryHelper(Me.rgbSkin)
    '    'DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(EstiloActual)
    'End Sub

    Private Sub etEmpresas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etEmpresas.ItemClick
        Dim frm As frmEmpresas = frmEmpresas.Instance()
        frm.Dispose()

        Dim f As frmEmpresas = frmEmpresas.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etCajas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etCajas.ItemClick
        Dim frm As frmCajas = frmCajas.Instance()
        frm.Dispose()
        '
        Dim f As frmCajas = frmCajas.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etFormaPago_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etFormaPago.ItemClick
        Dim f As frmFormaPago = frmFormaPago.Instance
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etZonas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etZonas.ItemClick
        Dim f As frmZonas = frmZonas.Instance
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etVendedores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etVendedores.ItemClick

        Dim f As frmVendedores = frmVendedores.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub etTasaCambio_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etTasaCambio.ItemClick

        Dim f As frmTasaCambio = frmTasaCambio.Instance()
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Text = e.Item.Caption
        f.ShowDialog()
        f.Dispose()

        'Dim f As frmTasaCambio = frmTasaCambio.Instance
        'f.Inicio = True
        'f.MdiParent = Me
        'Recurso = RolesDB.GetRecurso(e.Item.Name)
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
        'f.Inicio = False
    End Sub

    Private Sub etPuntosVenta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etPuntosVenta.ItemClick
        Dim f As frmPuntosVenta = frmPuntosVenta.Instance
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etEmisores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etEmisores.ItemClick
        Dim f As frmEmisores = frmEmisores.Instance()

        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etTipoTarjetas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etTipoTarjetas.ItemClick
        Dim f As frmTarjetas = frmTarjetas.Instance()

        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etTipoPlantillas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etTipoPlantillas.ItemClick

        ShowSplash()
        frmTipoPlantillas.Dispose()
        frmTipoPlantillas.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmTipoPlantillas.Show()
        frmTipoPlantillas.Text = e.Item.Caption
        frmTipoPlantillas.WindowState = FormWindowState.Maximized
        HideSplash()

        'Dim f As frmPlantillasBuscar = frmPlantillasBuscar.Instance
        'f.MdiParent = Me
        'Recurso = RolesDB.GetRecurso(e.Item.Name)
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etServiciosBasicos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etServiciosBasicos.ItemClick
        Dim f As frmServiciosBasicos = frmServiciosBasicos.Instance()

        f.MdiParent = Me
        f.Text = e.Item.Caption
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etPeriodos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etPeriodos.ItemClick
        Dim f As frmPeriodoListar = frmPeriodoListar.Instance()

        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etmonedas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etmonedas.ItemClick
        Dim f As frmMonedas = frmMonedas.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etPaises_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etPaises.ItemClick
        Dim f As frmPaises = frmPaises.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etMunicipios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etMunicipios.ItemClick
        Dim f As frmMunicipios = frmMunicipios.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etFirmasContables_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etFirmasContables.ItemClick
        Dim f As New frmFirmasContables
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etAmortiza_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etAmortiza.ItemClick
        ShowSplash()
        FrmMtnoAmortizacion.Dispose()
        FrmMtnoAmortizacion.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        FrmMtnoAmortizacion.Show()
        FrmMtnoAmortizacion.Text = e.Item.Caption
        FrmMtnoAmortizacion.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub etBalance_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etBalance.ItemClick
        Dim form As frmGrupos = frmGrupos.Instance()
        form.Dispose()
        '
        Dim f As frmGrupos = frmGrupos.Instance()
        f.Tipo = "Balance"
        f.MdiParent = Me

        TipoGrupo = "B"
        Titulo = "Mantenimiento de Grupos de Balance"
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etResultado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etResultado.ItemClick
        'If TipoGrupo <> "Vacio" Then
        '    XtraMsg("Cierre la ventana: " & Titulo)
        '    Exit Sub
        'End If

        '
        Dim form As frmGrupos = frmGrupos.Instance()
        form.Dispose()
        '
        Dim f As frmGrupos = frmGrupos.Instance()
        f.Tipo = "Resultado"
        f.MdiParent = Me

        TipoGrupo = "R"
        Titulo = "Mantenimiento de Grupos de Resultado"

        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etOrden_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etOrden.ItemClick
        'If TipoGrupo <> "Vacio" Then
        '    XtraMsg("Cierre la ventana: " & Titulo)
        '    Exit Sub
        'End If
        '
        Dim form As frmGrupos = frmGrupos.Instance()
        form.Dispose()
        '
        Dim f As frmGrupos = frmGrupos.Instance()
        f.Tipo = "Orden"
        f.MdiParent = Me

        TipoGrupo = "O"
        Titulo = "Mantenimiento de Grupos de Orden"

        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etPresupuesto_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etPresupuesto.ItemClick
        'If TipoGrupo <> "Vacio" Then
        '    XtraMsg("Cierre la ventana: " & Titulo)
        '    Exit Sub
        'End If
        '
        Dim form As frmGrupos = frmGrupos.Instance()
        form.Dispose()
        '
        Dim f As frmGrupos = frmGrupos.Instance()
        f.Tipo = "Presupuesto"
        f.MdiParent = Me

        TipoGrupo = "P"
        Titulo = "Mantenimiento de Grupos de Presupuesto"

        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etGruposDepreciacion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etGruposDepreciacion.ItemClick
        'Dim f As frmGruposDepreciacion = frmGruposDepreciacion.Instance()
        'f.MdiParent = Me
        'Recurso = RolesDB.GetRecurso(e.Item.Name)
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etCatalogo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etCatalogo.ItemClick
        Dim frm As frmCatalogo = frmCatalogo.Instance()
        frm.Dispose()

        Dim f As frmCatalogo = frmCatalogo.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etTipoComp_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etTipoComp.ItemClick
        Dim f As frmTipoComprobante = frmTipoComprobante.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etRubrosDistribucion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etRubrosDistribucion.ItemClick
        Dim f As New FrmRubrosGastos '= f.Instance
        f.MdiParent = Me
        f.Text = e.Item.Caption
        ''Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Mostrar(FrmRubrosGastos.TipoReporte.RubrosGastos)
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etCentrosCosto_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etCentrosCosto.ItemClick
        Dim f As New FrmRubrosGastos '= f.Instance
        f.MdiParent = Me
        f.Text = e.Item.Caption
        ''Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Mostrar(FrmRubrosGastos.TipoReporte.CentrosCostos)
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etPlantillaPlanilla_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etPlantillaPlanilla.ItemClick
        Dim f As FrmPlantillaIngresosDeduciones = FrmPlantillaIngresosDeduciones.Instance()
        f.MdiParent = Me
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etAgrupaciones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etAgrupaciones.ItemClick
        Dim frmChildInstance As frmAgrupaciones = frmAgrupaciones.Instance()
        frmChildInstance.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmChildInstance.Show()
        frmChildInstance.Text = e.Item.Caption
        frmChildInstance.Refresh()
    End Sub

    Private Sub etConceptos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etConceptos.ItemClick
        Dim f As frmConceptos = frmConceptos.Instance()
        f.MdiParent = Me
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etPresupuestos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etPresupuestos.ItemClick
        ShowSplash()
        frmPresupuestoNew.Dispose()
        frmPresupuestoNew.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmPresupuestoNew.Show()
        frmPresupuestoNew.Text = e.Item.Caption
        frmPresupuestoNew.WindowState = FormWindowState.Maximized
        HideSplash()

        'Dim f As frmAgregarPresupuesto = frmAgregarPresupuesto.Instance()
        'f.MdiParent = Me
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized

    End Sub

    'Private Sub etActivos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etActivos.ItemClick
    '    Dim frmChildInstance As frmActivos = frmActivos.Instance
    '    frmChildInstance.MdiParent = Me
    '    frmChildInstance.Text = e.Item.Caption
    '    frmChildInstance.Show()

    'End Sub

    Private Sub etGrupoProductos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etGrupoProductos.ItemClick
        Dim form As frmGruposInventarios = frmGruposInventarios.Instance()
        form.Dispose()
        '
        Dim f As frmGruposInventarios = frmGruposInventarios.Instance
        f.Tipo = "Productos"
        f.MdiParent = Me

        TipoGrupoInv = "P"
        TituloInv = "Mantenimiento de Grupos de Productos"
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etGrupoServicios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etGrupoServicios.ItemClick
        Dim form As frmGruposInventarios = frmGruposInventarios.Instance()
        form.Dispose()
        '
        Dim f As frmGruposInventarios = frmGruposInventarios.Instance()
        f.Tipo = "Servicios"
        f.MdiParent = Me

        TipoGrupoInv = "S"
        TituloInv = "Mantenimiento de Grupos de Servicios"
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etGrupoInventario_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etGrupoInventario.ItemClick
        Dim f As frmGruposCC = frmGruposCC.Instance
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etAreasConsumo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bConsultarExistencias.ItemClick
        ShowSplash()
        frmBuscarProducto.Dispose()
        frmBuscarProducto.Show()
        HideSplash()

        'Dim f As frmAreasConsumo = frmAreasConsumo.Instance
        'f.MdiParent = Me
        'Recurso = RolesDB.GetRecurso(e.Item.Name)
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etProductos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etProductos.ItemClick
        ShowSplash()
        Dim frm As frmArticulos = frmArticulos.Instance()
        frm.Dispose()

        Dim f As frmArticulos = frmArticulos.Instance()
        f.MdiParent = Me

        TituloInv = "Mantenimiento de Artículos"
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub etServicios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etServicios.ItemClick
        ShowSplash()
        Dim frm As frmServicios = frmServicios.Instance()
        frm.Dispose()

        Dim f As frmServicios = frmServicios.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub etArticulosInventario_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etArticulosInventario.ItemClick
        ShowSplash()
        Dim frm As frmArticulosCCList = frmArticulosCCList.Instance()
        frm.Dispose()

        Dim f As frmArticulosCCList = frmArticulosCCList.Instance
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub etBodega_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etBodega.ItemClick
        Dim frm As frmBodegas = frmBodegas.Instance()
        frm.Dispose()

        Dim f As frmBodegas = frmBodegas.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etAlmacenES_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etTMovimientos.ItemClick

        frmTipoMovimientosInvent.Dispose()
        My.Forms.frmTipoMovimientosInvent.MdiParent = Me
        My.Forms.frmTipoMovimientosInvent.Text = e.Item.Caption
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        My.Forms.frmTipoMovimientosInvent.Show()
        My.Forms.frmTipoMovimientosInvent.WindowState = FormWindowState.Maximized

        'Dim f As frmAlmacenES = frmAlmacenES.Instance
        'f.etDestino.Text = "0"
        'f.MdiParent = Me
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etTrasladoBodega_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etTrasladoBodega.ItemClick

        frmTrasladosBodegasList.Dispose()
        frmTrasladosBodegasList.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmTrasladosBodegasList.Show()
        frmTrasladosBodegasList.Text = e.Item.Caption
        frmTrasladosBodegasList.WindowState = FormWindowState.Maximized

        'ShowSplash()
        'Dim f2 As frmBodega_Traslado = frmBodega_Traslado.Instance()
        'f2.Dispose()
        ''ff
        'Dim f As frmBodega_Traslado = frmBodega_Traslado.Instance()
        'f.MdiParent = Me
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
        'HideSplash()
    End Sub

    Private Sub etRemisiones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etRemisiones.ItemClick
        ShowSplash()
        frmRemisionesPendiente.Dispose()
        frmRemisionesPendiente.MdiParent = Me
        'Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmRemisionesPendiente.Show()
        frmRemisionesPendiente.Text = e.Item.Caption
        frmRemisionesPendiente.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub etRequisas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etRequisas.ItemClick
        ShowSplash("Cargando Movimientos...")
        '
        Dim f2 As frmRequisas_List = frmRequisas_List.Instance()
        f2.Dispose()
        '
        Dim f As frmRequisas_List = frmRequisas_List.Instance()
        f.MdiParent = Me
        f.Begin = True
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        f.Begin = False
        HideSplash()
    End Sub

    Private Sub etFacturacionCliente_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etFacturacionCliente.ItemClick
        Inicio = True

        ShowSplash("Cargando Facturación...")

        'frmChildInstance.WindowState = FormWindowState.Normal
        'dsPuntoVenta = Pv.PcNombre(Environment.MachineName.ToString)

        Dim dsCajas As DataSet = Cajas.PcNombre(Environment.MachineName.ToString)

        If dsCajas.Tables("Cajas").Rows.Count = 0 Then
            HideSplash()
            XtraMsg("La Computadora " & Environment.MachineName.ToString & " no está configurada como Caja",
                    MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        TC.GetTasaCambio(
            MonedaBase,
            Fecha_Actual.Date)
        '
        If TC.Validar_Tasa Then
            If TC.TC_Oficial = 1.0 Then
                HideSplash()
                XtraMsg(
                    TC.MensajeDia.ToUpper & vbCrLf &
                    "FAVOR INGRESAR TASA DE CAMBIO ANTES DE EMPEZAR A FACTURAR",
                    MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        '*********************************************************************
        Dim frm As FrmFacturacionClienteNew = FrmFacturacionClienteNew.Instance()
        frm.Dispose()
        '
        Dim FormFacturacion As FrmFacturacionClienteNew = FrmFacturacionClienteNew.Instance()
        FormFacturacion.txtCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        Recurso = RolesDB.GetRecurso(e.Item.Name)

        FormFacturacion.MdiParent = Me
        FormFacturacion.Show()
        FormFacturacion.Text = e.Item.Caption
        FormFacturacion.WindowState = FormWindowState.Maximized

        HideSplash()
        Inicio = False
    End Sub

    Private Sub etFacturas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etFacturas.ItemClick

        ShowSplash()

        Dim f2 As frmListaFacturaClientes = frmListaFacturaClientes.Instance()
        f2.Dispose()

        Dim f As frmListaFacturaClientes = frmListaFacturaClientes.Instance()
        f.etInicio.Text = "1"
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.MdiParent = Me
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized

        f.etInicio.Text = "0"
        HideSplash()
    End Sub

    Private Sub etCobros_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etCobros.ItemClick

        Dim dsCajas As DataSet
        dsCajas = Cajas.PcNombre(Environment.MachineName.ToString)

        If dsCajas.Tables("Cajas").Rows.Count = 0 Then
            XtraMsg("La Computadora " & Environment.MachineName.ToString & " no está configurada como Caja", MessageBoxIcon.Information)
            Exit Sub
        End If
        '
        TC.GetTasaCambio(
            MonedaBase,
            Fecha_Actual.Date)
        '
        If TC.Validar_Tasa Then
            If TC.TC_Oficial = 1.0 Then
                XtraMsg(TC.MensajeDia.ToUpper & vbCrLf &
                                              "FAVOR INGRESAR TASA DE CAMBIO ANTES DE EMPEZAR.", MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        '*********************************************************************
        '
        ShowSplash()
        Dim frm As FrmCobrosNew = FrmCobrosNew.Instance()
        frm.Dispose()
        '
        Dim f As FrmCobrosNew = FrmCobrosNew.Instance()
        f.etInicio.Text = "1"
        f.txtCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
        HideSplash()
    End Sub

    Private Sub etRecibos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etRecibos.ItemClick
        ShowSplash()
        '
        Dim f2 As frmRecibos = frmRecibos.Instance()
        f2.Dispose()

        Dim f As frmRecibos = frmRecibos.Instance()

        f.MdiParent = Me
        f.Begin = True
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        f.Begin = False
        '
        HideSplash()
    End Sub

    Private Sub etOtrosIngresos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etOtrosIngresos.ItemClick

        Dim f As frmOtrosIngresosList = frmOtrosIngresosList.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.etInicio.Text = "1"
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"

    End Sub

    Private Sub etClientes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etClientes.ItemClick
        'Dim db As New db_EnviarCorreo
        'db.EnviarCorreo()

        ShowSplash("Clientes...")
        Dim frm As frmClientes = frmClientes.Instance()
        frm.Dispose()

        Dim f As frmClientes = frmClientes.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub etCotizaciones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etCotizaciones.ItemClick
        ShowSplash("Cargando Cotizacoines...")
        Dim f As frmListaCotizaciones = frmListaCotizaciones.Instance
        f.Dispose()
        '
        Dim frm As frmListaCotizaciones = frmListaCotizaciones.Instance
        frm.etInicio.Text = "1"
        frm.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frm.Show()
        frm.Text = e.Item.Caption
        frm.WindowState = FormWindowState.Maximized
        HideSplash()
        frm.etInicio.Text = "0"
    End Sub

    Private Sub etFacturaPuntoVenta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etFacturaPuntoVenta.ItemClick

        frmOrdenesEntregaNew.Dispose()
        frmOrdenesEntregaNew.MdiParent = Me
        frmOrdenesEntregaNew.Text = e.Item.Caption
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmOrdenesEntregaNew.Show()
        frmOrdenesEntregaNew.WindowState = FormWindowState.Maximized


        'dsPuntoVenta = Pv.PcNombre(Environment.MachineName.ToString)

        'If dsPuntoVenta.Tables("Puntos_Venta").Rows.Count = 0 Then
        '    XtraMsg("La Computadora " & Environment.MachineName.ToString & " NO está configurada como Punto de Venta")
        '    Exit Sub
        'End If

        'dsPuntoVenta = Pv.PcNombre(Environment.MachineName.ToString)

        'PvCodigo = dsPuntoVenta.Tables("Puntos_Venta").Rows(0).Item("Pv_Codigo").ToString
        'PvNombre = dsPuntoVenta.Tables("Puntos_Venta").Rows(0).Item("Pv_Nombre").ToString


        'menuClientes.Visible = False
        'menu1.Visible = False

        'NuevaFactura = "SI"

        'Opened = "SI"
        'Me.Refresh()

        'Dim f As frmListaOrdenes = frmListaOrdenes.Instance()
        'f.MdiParent = Me
        'Recurso = RolesDB.GetRecurso(e.Item.Name)
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etDevolucionesCliente_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etDevolucionesCliente.ItemClick
        ShowSplash()

        Dim frm As frmDevolucionesClienteList = frmDevolucionesClienteList.Instance()
        frm.Dispose()

        Dim f As frmDevolucionesClienteList = frmDevolucionesClienteList.Instance()
        f.etInicio.Text = "1"
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"

        HideSplash()

        'Dim f As frmDevolucionesFacturas = frmDevolucionesFacturas.Instance()
        'f.etInicio.Text = "1"
        'f.MdiParent = Me
        'Recurso = RolesDB.GetRecurso(e.Item.Name)
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
        'f.etInicio.Text = "0"
    End Sub

    Private Sub etSalidaCC_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bAsignarDescuento.ItemClick
        Dim f As frmSalidasCCList = frmSalidasCCList.Instance()
        f.etInicio.Text = "1"
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub etVentasPerdidas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)

        'frmArregloPago.Dispose()
        'frmArregloPago.MdiParent = Me
        'frmArregloPago.Text = e.Item.Caption
        'frmArregloPago.Show()
        'frmArregloPago.WindowState = FormWindowState.Maximized

        'Dim f As frmVentasPerdidasListaDetalle = frmVentasPerdidasListaDetalle.Instance
        'f.etInicio.Text = "1"
        'f.MdiParent = Me
        'Recurso = RolesDB.GetRecurso(e.Item.Name)
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
        'f.etInicio.Text = "0"
    End Sub

    Private Sub etNotasCD_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etNotasCD.ItemClick
        ShowSplash("Cargando N D/C...")
        Dim f2 As FrmNotasList = FrmNotasList.Instance()
        f2.Dispose()
        ''
        Dim f As FrmNotasList = FrmNotasList.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub etOverViewClientes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bExoneraciones.ItemClick

        frmInformeExoneraciones.Dispose()
        frmInformeExoneraciones.MdiParent = Me
        frmInformeExoneraciones.Show()
        frmInformeExoneraciones.Text = e.Item.Caption
        frmInformeExoneraciones.WindowState = FormWindowState.Maximized


        'Dim f As frmOverViewClientes = f.Instance
        'f.MdiParent = Me
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etProveedores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etProveedores.ItemClick
        ShowSplash()
        Dim frm As frmProveedores = frmProveedores.Instance()
        frm.Dispose()
        '
        Dim f As frmProveedores = frmProveedores.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub etListaPedidos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etListaPedidos.ItemClick
        ShowSplash()
        Dim frm As frmListaPedidos = frmListaPedidos.Instance()
        frm.Dispose()

        Dim f As frmListaPedidos = frmListaPedidos.Instance()

        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub etFacturasCompras_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etOrdenesCompras.ItemClick
        ShowSplash()
        Dim frm As frmOrdenesCompraLista = frmOrdenesCompraLista.Instance()
        frm.Dispose()

        Dim f As frmOrdenesCompraLista = frmOrdenesCompraLista.Instance()

        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub etListaFacturas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etListaFacturas.ItemClick
        Inicio = True
        ShowSplash()
        Dim frm As frmFacturasComprasList = frmFacturasComprasList.Instance()
        frm.Dispose()

        'Dim fPedidos As DataGridTextBoxCombo.frmPedidosrtert = fPedidos.Instance
        Dim f As frmFacturasComprasList = frmFacturasComprasList.Instance()
        f.etInicio.Text = "1"
        f.MdiParent = Me
        f.cbEstado.Enabled = True
        'f.Label1.Visible = True
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
        HideSplash()
        Inicio = False
    End Sub

    Private Sub etFacturar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bEstadoOC.ItemClick

        frmEstadosOCList.Dispose()
        frmEstadosOCList.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmEstadosOCList.Show()
        frmEstadosOCList.Text = e.Item.Caption
        frmEstadosOCList.WindowState = FormWindowState.Maximized

        'ShowSplash()
        'Dim f As frmFacturasComprasSB = frmFacturasComprasSB.Instance()
        'f.etInicio.Text = "1"
        'f.MdiParent = Me
        'Recurso = RolesDB.GetRecurso(e.Item.Name)
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
        'f.etInicio.Text = "0"
        'HideSplash()
        ''f.cbProveedor.Focus()
    End Sub

    Private Sub etDevolucionesProveedor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etDevolucionesProveedor.ItemClick
        ShowSplash()
        Dim f As frmDevolucionesFacturasCompras = frmDevolucionesFacturasCompras.Instance()

        f.etInicio.Text = "1"

        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized

        f.etInicio.Text = "0"
        HideSplash()
    End Sub

    Private Sub etFacturaProveedor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bDetallePagos.ItemClick
        ShowSplash()

        frmDetalleDePagosFC.Dispose()
        frmDetalleDePagosFC.MdiParent = Me
        frmDetalleDePagosFC.Show()
        frmDetalleDePagosFC.Text = e.Item.Caption
        frmDetalleDePagosFC.WindowState = FormWindowState.Maximized

        'Dim f As DataGridTextBoxCombo.frmFacturaProveedor = f.Instance
        'f.MdiParent = Me
        'f.etInicio.Text = "1"
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
        'f.etInicio.Text = "0"
        HideSplash()
    End Sub

    Private Sub etNotas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etNotas.ItemClick
        ShowSplash("Cargando N D/C...")
        frmNotasProveedoresList.Dispose()

        frmNotasProveedoresList.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)

        frmNotasProveedoresList.Show()
        frmNotasProveedoresList.Text = e.Item.Caption
        frmNotasProveedoresList.WindowState = FormWindowState.Maximized
        '
        HideSplash()
    End Sub

    Private Sub etOverViewProveedores_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etOverViewProveedores.ItemClick
        'Dim f As frmOverViewProveedores = frmOverViewProveedores.Instance()
        'f.MdiParent = Me
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etBancos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etBancos.ItemClick
        Dim f As frmBancos = frmBancos.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etDepositos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etDepositos.ItemClick
        'Dim f As frmDepositos = frmDepositos.Instance()
        'f.MdiParent = Me
        'Recurso = RolesDB.GetRecurso(e.Item.Name)
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized


        frmDepositosListNew.Dispose()
        frmDepositosListNew.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmDepositosListNew.Show()
        frmDepositosListNew.Text = e.Item.Caption
        frmDepositosListNew.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub etTransferencias_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etTransferencias.ItemClick
        Dim f As FrmTrasladoCuentas = FrmTrasladoCuentas.Instance()
        f.etInicio.Text = "1"
        f.MdiParent = Me
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub

    Private Sub etLibroBancos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etLibroBancos.ItemClick
        Inicio = True
        ShowSplash()
        frmLibroBancoNew.Dispose()
        frmLibroBancoNew.MdiParent = Me
        frmLibroBancoNew.Show()
        frmLibroBancoNew.Text = e.Item.Caption
        frmLibroBancoNew.WindowState = FormWindowState.Maximized
        HideSplash()
        Inicio = False

        'Dim f As frmLBBancos = frmLBBancos.Instance()
        '''f.MdiParent = Me
        'f.Text = e.Item.Caption
        'f.ShowDialog()
        'f.Dispose()
        '''f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etConciliacion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etConciliacion.ItemClick
        Inicio = True
        Dim f2 As frmBcosConc_List = frmBcosConc_List.Instance()
        f2.Dispose()

        Dim f As frmBcosConc_List = frmBcosConc_List.Instance()

        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)

        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        Inicio = False
    End Sub

    Private Sub etChequeAgregar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etChequeAgregar.ItemClick
        ShowSplash()
        Dim f As FrmHacerCheques = FrmHacerCheques.Instance()
        f.MdiParent = Me
        'f.etInicio.Text = "1"
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        'f.etInicio.Text = "0"
        HideSplash()
    End Sub

    Private Sub etCheques_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etCheques.ItemClick
        ShowSplash()
        '
        Dim f As frmChequesList = frmChequesList.Instance()
        f.etInicio.Text = "1"
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)

        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
        '
        HideSplash()
    End Sub

    Private Sub etInversiones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etInversiones.ItemClick
        Dim f As frmInversiones = frmInversiones.Instance
        f.MdiParent = Me

        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etOverViewBancos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etOverViewBancos.ItemClick
        'Dim f As FrmOverViewBancos = f.Instance
        'f.MdiParent = Me
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etEfectuarPagos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etEfectuarPagos.ItemClick
        TC.GetTasaCambio(MonedaBase, Fecha_Actual.Date)
        '
        If TC.Validar_Tasa Then
            If TC.TC_Oficial = 1.0 Then
                XtraMsg(TC.MensajeDia.ToUpper & vbCrLf &
                                              "FAVOR INGRESAR TASA DE CAMBIO ANTES DE EMPEZAR.", MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        '*********************************************************************

        Dim f As frmPlantillasListaTemplate = frmPlantillasListaTemplate.Instance()

        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etComprobantes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etComprobantes.ItemClick
        Dim Periodo As Integer
        Periodo = VB.SysContab.PeriodosDB.Actual

        If Periodo = 0 Then
            XtraMsg("Debe haber un periodo contable Activo", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        '
        TC.GetTasaCambio(MonedaBase, Fecha_Actual.Date)
        '
        If TC.Validar_Tasa Then
            If TC.TC_Oficial = 1.0 Then
                XtraMsg(TC.MensajeDia.ToUpper & vbCrLf &
                                              "FAVOR INGRESAR TASA DE CAMBIO ANTES DE EMPEZAR.", MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        '*********************************************************************

        'Dim f As frmCompr = f.Instance
        Dim f As frmHacerComprobantes = frmHacerComprobantes.Instance()
        f.MdiParent = Me
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etArqueo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etArqueo.ItemClick
        Dim f As frmAgregarArqueo = frmAgregarArqueo.Instance()

        f.MdiParent = Me
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etContabilizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etContabilizar.ItemClick
        TC.GetTasaCambio(MonedaBase, Fecha_Actual.Date)
        '
        If TC.Validar_Tasa Then
            If TC.TC_Oficial = 1.0 Then
                XtraMsg(TC.MensajeDia.ToUpper & vbCrLf &
                                              "FAVOR INGRESAR TASA DE CAMBIO ANTES DE EMPEZAR.", MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        '*********************************************************************

        Dim f As frmComprobantesDiariosLista = frmComprobantesDiariosLista.Instance()

        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etPagosCajaChica_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etPagosCajaChica.ItemClick
        'Dim f As frmPagosCajaChicaList = frmPagosCajaChicaList.Instance()
        'f.etInicio.Text = "1"
        'f.MdiParent = Me
        'Recurso = RolesDB.GetRecurso(e.Item.Name)
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
        'f.etInicio.Text = "0"
    End Sub

    'Private Sub etLevantaInvent_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etLevantaInvent.ItemClick
    '    Dim f As frmCargadeInventarioBodega_List = f.Instance
    '    f.MdiParent = Me
    '    f.Show()
    '    f.Text = e.Item.Caption
    '    f.WindowState = FormWindowState.Maximized
    'End Sub

    Private Sub etCierreDia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etCierreDia.ItemClick
        Dim Forma As New FrmCierreDia
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        Forma.ShowDialog()
        Forma.Dispose()
    End Sub

    Private Sub etLiquidaciones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etLiquidaciones.ItemClick
        'Dim f As frmLiquidacionList = frmLiquidacionList.Instance()
        'f.MdiParent = Me
        'Recurso = RolesDB.GetRecurso(e.Item.Name)
        'f.Show()
        'f.Text = e.Item.Caption
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etDetalleAmortiza_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etDetalleAmortiza.ItemClick
        Inicio = True
        frmCacularAmortizacion.Dispose()
        frmCacularAmortizacion.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmCacularAmortizacion.Show()
        frmCacularAmortizacion.Text = e.Item.Caption
        frmCacularAmortizacion.WindowState = FormWindowState.Maximized
        Inicio = False
    End Sub

    Private Sub etOverViewProcesos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etOverViewProcesos.ItemClick
        'Dim f As frmOverViewProcesos = f.Instance
        'f.MdiParent = Me
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etReporteContabilidad_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etReporteContabilidad.ItemClick

        ShowSplash("Cargando Comprobantes...")
        '
        Dim f As frmComprobantes = frmComprobantes.Instance()
        f.Begin = True
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.MdiParent = Me
        f.Text = e.Item.Caption
        f.Show()
        f.WindowState = FormWindowState.Maximized
        '
        f.Begin = False
        HideSplash()
    End Sub

    Private Sub etMayorA_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etMayorA.ItemClick
        'Dim frm As frmLibroAuxiliar = frmLibroAuxiliar.Instance()
        'frm.Dispose()

        Dim f As frmLibroAuxiliar = frmLibroAuxiliar.Instance()
        ' f.MdiParent = Me
        f.Text = e.Item.Caption
        f.Show()
        ' f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etLibroDiario_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etLibroDiario.ItemClick
        Dim f As frmLibroDiario = frmLibroDiario.Instance()
        f.MdiParent = Me
        f.Text = e.Item.Caption
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etBalanza_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etBalanza.ItemClick
        Dim f As frmLibroBalanza = frmLibroBalanza.Instance()
        ' f.MdiParent = Me
        f.Text = e.Item.Caption
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
        ' f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etER_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etER.ItemClick
        'frmEstadoResultadoNew.Dispose()
        ''
        'With frmEstadoResultadoNew
        '    .MdiParent = Me
        '    .Text = e.Item.Caption
        '    .Show()
        '    .WindowState = FormWindowState.Maximized
        'End With


        Dim f As frmLibroEstadoResultado = frmLibroEstadoResultado.Instance()
        f.Text = e.Item.Caption
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()

        'Dim f As frmLibroEstadoResultado = frmLibroEstadoResultado.Instance()
        'f.MdiParent = Me
        'f.Text = e.Item.Caption
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etES_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etES.ItemClick
        Dim f As frmLibroEstadoSituacion = frmLibroEstadoSituacion.Instance()
        f.Text = e.Item.Caption
        f.Show()
        f.StartPosition = FormStartPosition.CenterParent

        'f.Dispose()
        'f.MdiParent = Me
        'f.Text = e.Item.Caption
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etDistribucion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etDistribucion.ItemClick
        ShowSplash("Centros de Costos...")
        FrmCrosstab_CentroCosto.Dispose()
        FrmCrosstab_CentroCosto.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        FrmCrosstab_CentroCosto.Text = e.Item.Caption
        FrmCrosstab_CentroCosto.Show()
        FrmCrosstab_CentroCosto.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub etFlujoc_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etFlujoc.ItemClick
        Dim f As frmRptFlujoCAja = frmRptFlujoCAja.Instance()
        '
        f.MdiParent = Me
        f.Text = e.Item.Caption
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etCentroCostoR_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etCentroCostoR.ItemClick
        Dim f As New frmrptcentroscosto
        f.Text = e.Item.Caption
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub etReporteGestionComercial_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etReporteGestionComercial.ItemClick
        Dim frm As frmReportesOverviewGestionComercial = frmReportesOverviewGestionComercial.Instance()
        frm.Dispose()
        '
        Dim f As frmReportesOverviewGestionComercial = frmReportesOverviewGestionComercial.Instance()
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.MdiParent = Me
        f.Text = e.Item.Caption
        'f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etReporteActivoFijo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etReporteActivoFijo.ItemClick
        Dim f As frmReportesActivos = frmReportesActivos.Instance()

        f.MdiParent = Me
        f.Text = e.Item.Caption
        f.Show()

        f.cbEmpleados.SelectedValue = 0
        f.cbDepartamentos.SelectedValue = 0
        f.cbCargos.SelectedValue = 0
        f.cbStatus.SelectedIndex = 0
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etrptPresupuesto_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etrptPresupuesto.ItemClick
        Dim f As frmRptPresupuesto = frmRptPresupuesto.Instance()

        f.MdiParent = Me
        f.Text = e.Item.Caption
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etrptGenerales_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bBuroCredito.ItemClick
        frmBuroCredito.Dispose()
        frmBuroCredito.MdiParent = Me
        frmBuroCredito.Show()
        frmBuroCredito.Text = e.Item.Caption
        frmBuroCredito.WindowState = FormWindowState.Maximized


        'Dim f As frmRptControlPanel = frmRptControlPanel.Instance()
        'f.MdiParent = Me
        'f.Text = e.Item.Caption
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etRazonesFin_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etRazonesFin.ItemClick
        Dim f As frmrazonesfinancieras = frmrazonesfinancieras.Instance()

        f.MdiParent = Me
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etOverViewReportes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim f As frmOverViewReportes = frmOverViewReportes.Instance()
        f.MdiParent = Me
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etDinamicoContables_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etDinamicoContables.ItemClick

        Dim f As frmReportesOverViewCrossTab = frmReportesOverViewCrossTab.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Text = e.Item.Caption
        f.Show()
        f.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub etDinamicosGestionComercial_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etDinamicosGestionComercial.ItemClick
        Dim f As FrmReportesGestionComercialCrossTab = FrmReportesGestionComercialCrossTab.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Text = e.Item.Caption
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etCambiarEmpresa_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etCambiarEmpresa.ItemClick
        If Empresa.EmpresasXUsuarios(Login, Password).Tables("Empresas").Rows.Count = 1 Then
            XtraMsg("El Usuario Solo Tiene Asignada 1 Empresa.", MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        '
        Dim f As New frmCambiarEmpresa
        f.Text = e.Item.Caption
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub etRoles_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etRoles.ItemClick
        frmRoles.Dispose()

        With My.Forms.frmRoles
            .MdiParent = Me
            Recurso = RolesDB.GetRecurso(e.Item.Name)
            .Text = e.Item.Caption
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

        'etFacturacionCliente.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'Dim f As FrmRolesListar = f.Instance
        'f.MdiParent = Me
        'f.Text = e.Item.Caption
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etUsuarios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etUsuarios.ItemClick
        Dim frm As FrmUsuariosListar = FrmUsuariosListar.Instance()
        frm.Dispose()
        '
        Dim f As FrmUsuariosListar = FrmUsuariosListar.Instance()

        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Text = e.Item.Caption
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etContraseña_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etContraseña.ItemClick
        Dim Forma As New frmUsuariosPass
        Me.IsMdiContainer = True
        Forma.Text = e.Item.Caption
        Forma.ShowDialog()
        Forma = Nothing
    End Sub

    Private Sub etAuditoria_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etAuditoria.ItemClick
        Dim f As frmAuditoriaSistema = frmAuditoriaSistema.Instance()
        f.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        f.Text = e.Item.Caption
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etDBRespaldo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etDBRespaldo.ItemClick
        Dim f As frmbackup = frmbackup.Instance()
        f.Text = e.Item.Caption
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub etAyuda_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etAyuda.ItemClick
        Help.ShowHelp(Me, "Ayuda/stscontab.chm")
    End Sub

    Private Sub etFisico_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etFisico.ItemClick
        FrmInventarioList.Dispose()
        FrmInventarioList.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        FrmInventarioList.Show()
        FrmInventarioList.Text = e.Item.Caption
        FrmInventarioList.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub etInventario_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles etInventario.ItemClick
        ShowSplash()

        Dim frm As FrmConsultasVentas = FrmConsultasVentas.Instance()
        frm.Dispose()


        Dim f As FrmConsultasVentas = FrmConsultasVentas.Instance()
        f.MdiParent = Me
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized

        HideSplash()

        LeeData()
    End Sub

    Private Sub bDMovimientos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bDMovimientos.ItemClick
        FrmRequisasCrossTab.Dispose()
        FrmRequisasCrossTab.MdiParent = Me
        FrmRequisasCrossTab.Show()
        FrmRequisasCrossTab.Text = e.Item.Caption
        FrmRequisasCrossTab.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub etCierreInvent_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub btnObligaciones_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnObligaciones.ItemClick
        frmObligacionesxPagar.Dispose()
        frmObligacionesxPagar.MdiParent = Me
        frmObligacionesxPagar.Show()
        frmObligacionesxPagar.Text = e.Item.Caption
        frmObligacionesxPagar.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RibbonControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonControl.Click

    End Sub

    Private Sub rgbSkin_GalleryItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles rgbSkin.GalleryItemClick
        EscribeEstilo(e.Item.Caption)
        bEstiloActual.Caption = e.Item.Caption
    End Sub

    Private Sub bAuditoria_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bAuditoria.ItemClick
        frmAuditoria.Dispose()
        frmAuditoria.MdiParent = Me
        frmAuditoria.Show()
        frmAuditoria.Text = e.Item.Caption
        frmAuditoria.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bAjusteCxC_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bAjusteCxC.ItemClick

        frmAjusteClientes.Dispose()
        frmAjusteClientes.MdiParent = Me
        frmAjusteClientes.Show()
        frmAjusteClientes.Text = e.Item.Caption
        frmAjusteClientes.WindowState = FormWindowState.Maximized

        'If XtraMsg2("Esta Seguro de Realizar el Ajuste Automático de las Cuentas x Cobrar." & vbCrLf & _
        '            "Este proceso limpiara todas aquellas cuentas con diferencias de centavos en su saldo." & vbCrLf & _
        '            "Esta Seguro de Aplicar esta Operación") Then
        '    ShowSplash()
        '    Dim CantidadFacturas As Integer = ObtieneDatos("JAR_AjustarCxC 0," & EmpresaActual).Rows.Count
        '    If GuardaDatos("JAR_AjustarCxC 1," & EmpresaActual) Then
        '        HideSplash()
        '        XtraMsg("Se han Ajustado: " & CantidadFacturas.ToString & " Facturas con éxito !!!")
        '    Else
        '        HideSplash()
        '    End If
        'End If
    End Sub

    Private Sub RepararCostos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles RepararCostos.ItemClick
        frmRepararCosto.Dispose()
        frmRepararCosto.MdiParent = Me
        frmRepararCosto.Show()
        frmRepararCosto.Text = e.Item.Caption
        frmRepararCosto.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub lblpublicacion_ItemDoubleClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles lblpublicacion.ItemDoubleClick
        'frmControlVersiones.Show()
        'frmControlVersiones.Text = "Control de Versiones - " & e.Item.Caption
        'frmControlVersiones.WindowState = FormWindowState.Maximized
        Try
            Process.Start("\\192.168.0.2\simtesis\publish\SysContabv3\SysContab.application")
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bConsignatarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bConsignatarios.ItemClick
        frmConsignatarios.Dispose()
        frmConsignatarios.MdiParent = Me
        frmConsignatarios.Show()
        frmConsignatarios.Text = e.Item.Caption
        frmConsignatarios.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bAgencias_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bAgencias.ItemClick
        frmAgencias.Dispose()
        frmAgencias.MdiParent = Me
        frmAgencias.Show()
        frmAgencias.Text = e.Item.Caption
        frmAgencias.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bEnvio_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bEnvio.ItemClick
        frmMetodosEnvio.Dispose()
        frmMetodosEnvio.MdiParent = Me
        frmMetodosEnvio.Show()
        frmMetodosEnvio.Text = e.Item.Caption
        frmMetodosEnvio.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bVencimiento_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bVencimiento.ItemClick
        frmVencimientoFacturasV.Dispose()
        frmVencimientoFacturasV.MdiParent = Me
        frmVencimientoFacturasV.Show()
        frmVencimientoFacturasV.Text = e.Item.Caption
        frmVencimientoFacturasV.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bInformeIR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bInformeIR.ItemClick
        frmInformeRetenciones.Dispose()
        frmInformeRetenciones.MdiParent = Me
        frmInformeRetenciones.Show()
        frmInformeRetenciones.Text = e.Item.Caption
        frmInformeRetenciones.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bCodigosAutorizacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bCodigosAutorizacion.ItemClick
        frmCodigosAutorizacion.ShowDialog()
        frmCodigosAutorizacion.Dispose()
    End Sub

    Private Sub bAsociarPagos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bAsociarPagos.ItemClick
        frmAsociarPagos.Dispose()
        frmAsociarPagos.MdiParent = Me
        frmAsociarPagos.Show()
        frmAsociarPagos.Text = e.Item.Caption
        frmAsociarPagos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bConfigDescuentos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub bDetalleMovimientos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bDetalleMovimientos.ItemClick
        ShowSplash()
        frmDetalleMovimientosCxP.Dispose()
        frmDetalleMovimientosCxP.MdiParent = Me
        frmDetalleMovimientosCxP.Show()
        frmDetalleMovimientosCxP.Text = e.Item.Caption
        frmDetalleMovimientosCxP.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bCierreInventario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles etCierreInvent.ItemClick
        frmCierreInventario.Dispose()
        frmCierreInventario.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmCierreInventario.Show()
        frmCierreInventario.Text = e.Item.Caption
        frmCierreInventario.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bAsociarPagosC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bAsociarPagosC.ItemClick
        frmAsociarPagosClientes.Dispose()
        frmAsociarPagosClientes.MdiParent = Me
        frmAsociarPagosClientes.Show()
        frmAsociarPagosClientes.Text = e.Item.Caption
        frmAsociarPagosClientes.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bRemisionesTaller_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bRemisionesTaller.ItemClick
        frmRemisionesTaller.Dispose()
        frmRemisionesTaller.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmRemisionesTaller.Show()
        frmRemisionesTaller.Text = e.Item.Caption
        frmRemisionesTaller.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bAjusteInventario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bAjusteInventario.ItemClick
        frmAjusteInventario.Dispose()
        frmAjusteInventario.MdiParent = Me
        frmAjusteInventario.Show()
        frmAjusteInventario.Text = e.Item.Caption
        frmAjusteInventario.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        ShowSplash()
        '
        frmResponsables.Dispose()
        frmResponsables.MdiParent = Me
        frmResponsables.Show()
        frmResponsables.Text = "PNR - " & e.Item.Caption
        frmResponsables.WindowState = FormWindowState.Maximized
        '
        HideSplash()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        ShowSplash()
        frmPlanNegocioList.Dispose()
        frmPlanNegocioList.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmPlanNegocioList.Show()
        frmPlanNegocioList.Text = e.Item.Caption
        frmPlanNegocioList.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ShowSplash()
        frmPropiedades.Dispose()
        frmPropiedades.MdiParent = Me
        frmPropiedades.Show()
        frmPropiedades.Text = "PNR - " & e.Item.Caption
        frmPropiedades.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bExportarAPDA.ItemClick
        frmExportarA_PDA.ShowDialog()
        frmExportarA_PDA.Dispose()
    End Sub

    Private Sub bEstadosCotizacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bEstadosCotizacion.ItemClick
        frmEstadosCotizacionesList.Dispose()
        frmEstadosCotizacionesList.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmEstadosCotizacionesList.Show()
        frmEstadosCotizacionesList.Text = e.Item.Caption
        frmEstadosCotizacionesList.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bCondicionesVenta_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bCondicionesVenta.ItemClick
        frmCondicionesVenta.Dispose()
        frmCondicionesVenta.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmCondicionesVenta.Show()
        frmCondicionesVenta.Text = e.Item.Caption
        frmCondicionesVenta.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bMovimientosContables_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bMovimientosContables.ItemClick
        frmDinamicoContable.Dispose()
        frmDinamicoContable.MdiParent = Me
        frmDinamicoContable.Show()
        frmDinamicoContable.Text = e.Item.Caption
        frmDinamicoContable.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bDetalleMovimientoCxC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bDetalleMovimientoCxC.ItemClick
        ShowSplash()
        frmDetalleMovimientoCliente.Dispose()
        frmDetalleMovimientoCliente.MdiParent = Me
        frmDetalleMovimientoCliente.Show()
        frmDetalleMovimientoCliente.Text = e.Item.Caption
        frmDetalleMovimientoCliente.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bEnvioCorreo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bEnvioCorreo.ItemClick
        frmConfigurarCorreo.Text = e.Item.Caption
        frmConfigurarCorreo.ShowDialog()
        frmConfigurarCorreo.Dispose()
    End Sub

    Private Sub BarButtonItem7_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bConsolidado.ItemClick
        ShowSplash()
        Inicio = True
        frmPlanNegocioPivotConsolidado.Dispose()
        frmPlanNegocioPivotConsolidado.MdiParent = Me
        frmPlanNegocioPivotConsolidado.Show()
        frmPlanNegocioPivotConsolidado.Text = e.Item.Caption
        frmPlanNegocioPivotConsolidado.WindowState = FormWindowState.Maximized
        Inicio = False
        HideSplash()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ShowSplash()
        frmAntecedentesList.Dispose()
        frmAntecedentesList.MdiParent = Me
        frmAntecedentesList.Show()
        frmAntecedentesList.Text = e.Item.Caption
        frmAntecedentesList.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub AlertControl1_AlertClick(sender As Object, e As DevExpress.XtraBars.Alerter.AlertClickEventArgs) Handles AlertControl1.AlertClick
        Dim f As frmTasaCambio = frmTasaCambio.Instance
        f.Inicio = True
        f.MdiParent = Me
        f.Text = "Tasa de Cambio"
        Recurso = ObtieneDatos("SELECT rr.ID FROM REST_Recursos rr WHERE rr.Control = 'etTasaCambio'").Rows.Item(0)(0)
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.Inicio = False
    End Sub

    Private Sub bPlanAccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bPlanAccion.ItemClick
        ShowSplash()
        frmPlanDeAccionList.Dispose()
        frmPlanDeAccionList.MdiParent = Me
        frmPlanDeAccionList.Show()
        frmPlanDeAccionList.Text = e.Item.Caption
        frmPlanDeAccionList.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        ShowSplash()
        frmObjetivosEstrategicosList.Dispose()
        frmObjetivosEstrategicosList.MdiParent = Me
        frmObjetivosEstrategicosList.Show()
        frmObjetivosEstrategicosList.Text = e.Item.Caption
        frmObjetivosEstrategicosList.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bAntiguedadInventario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bAntiguedadInventario.ItemClick
        ShowSplash()
        frmReporteAntiguedadInventarios.Dispose()
        frmReporteAntiguedadInventarios.MdiParent = Me
        frmReporteAntiguedadInventarios.Show()
        frmReporteAntiguedadInventarios.Text = e.Item.Caption
        frmReporteAntiguedadInventarios.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        ShowSplash()
        frmPlanNegocioTrasladar.Dispose()
        frmPlanNegocioTrasladar.MdiParent = Me
        frmPlanNegocioTrasladar.Show()
        frmPlanNegocioTrasladar.Text = e.Item.Caption
        frmPlanNegocioTrasladar.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bConfigurarBalance.ItemClick
        frmGruposBalance.Dispose()
        frmGruposBalance.MdiParent = Me
        frmGruposBalance.Tipo = "B"
        frmGruposBalance.lblTitulo.Text = "Configurar Balance General"
        frmGruposBalance.Show()
        frmGruposBalance.Text = e.Item.Caption
        frmGruposBalance.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bConfiguraER_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bConfiguraER.ItemClick
        frmGruposBalance.Dispose()
        frmGruposBalance.MdiParent = Me
        frmGruposBalance.Tipo = "R"
        frmGruposBalance.lblTitulo.Text = "Configurar Estado de Resultado"
        frmGruposBalance.Show()
        frmGruposBalance.Text = e.Item.Caption
        frmGruposBalance.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub lblpublicacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles lblpublicacion.ItemClick
        'Try
        '    Process.Start("\\192.168.0.2\simtesis\publish\SysContabv3\SysContab.application")
        'Catch ex As Exception
        '    XtraMsg(ex.Message, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub bImportarDePDA_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bImportarDePDA.ItemClick
        frmImportarPDA.Dispose()
        frmImportarPDA.MdiParent = Me
        frmImportarPDA.Show()
        frmImportarPDA.Text = e.Item.Caption
        frmImportarPDA.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bIntereses_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bIntereses.ItemClick
        frmInteresesClientes.Text = e.Item.Caption
        frmInteresesClientes.ShowDialog()
        frmInteresesClientes.Dispose()
    End Sub

    Private Sub bImportarRecibos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bImportarRecibos.ItemClick
        FrmHistoricoRecibos.Dispose()
        FrmHistoricoRecibos.MdiParent = Me
        FrmHistoricoRecibos.Show()
        FrmHistoricoRecibos.Text = e.Item.Caption
        FrmHistoricoRecibos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub bEstadisticasPNR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bEstadisticasPNR.ItemClick
        ShowSplash("Cargando Estadisticas...")
        frmEstadisticas.Dispose()
        frmEstadisticas.MdiParent = Me
        frmEstadisticas.Show()
        frmEstadisticas.Text = e.Item.Caption
        frmEstadisticas.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        frmCostosProduccion.Dispose()
        frmCostosProduccion.MdiParent = Me
        frmCostosProduccion.Show()
        frmCostosProduccion.Text = e.Item.Caption
        frmCostosProduccion.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem20_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        frmTipoCostos.Dispose()
        frmTipoCostos.MdiParent = Me
        frmTipoCostos.Show()
        frmTipoCostos.Text = e.Item.Caption
        frmTipoCostos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem21_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        frmTipoValores.Dispose()
        frmTipoValores.MdiParent = Me
        frmTipoValores.Show()
        frmTipoValores.Text = e.Item.Caption
        frmTipoValores.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem16_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        frmTipoProductos.Dispose()
        frmTipoProductos.MdiParent = Me
        frmTipoProductos.Show()
        frmTipoProductos.Text = e.Item.Caption
        frmTipoProductos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        ShowSplash()
        FrmFormulaList.Dispose()
        FrmFormulaList.MdiParent = Me
        FrmFormulaList.Show()
        FrmFormulaList.Text = e.Item.Caption
        FrmFormulaList.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        ShowSplash()
        Inicio = True
        FrmProduccion.Dispose()
        FrmProduccion.MdiParent = Me
        FrmProduccion.Show()
        FrmProduccion.Text = e.Item.Caption
        FrmProduccion.WindowState = FormWindowState.Maximized
        Inicio = False
        HideSplash()
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        ShowSplash()
        FrmProduccionGenerar.Dispose()
        FrmProduccionGenerar.MdiParent = Me
        FrmProduccionGenerar.Show()
        FrmProduccionGenerar.Text = e.Item.Caption
        FrmProduccionGenerar.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        ShowSplash()
        FrmProduccionFinalizar.Dispose()
        FrmProduccionFinalizar.MdiParent = Me
        FrmProduccionFinalizar.Show()
        FrmProduccionFinalizar.Text = e.Item.Caption
        FrmProduccionFinalizar.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem19_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        ShowSplash()
        frmDinamicoProduccion.Dispose()
        frmDinamicoProduccion.MdiParent = Me
        frmDinamicoProduccion.Show()
        frmDinamicoProduccion.Text = e.Item.Caption
        frmDinamicoProduccion.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bProyectos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bProyectos.ItemClick
        ShowSplash()
        frmProyectos.Dispose()
        frmProyectos.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmProyectos.Show()
        frmProyectos.Text = e.Item.Caption
        frmProyectos.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bFacturasVencidas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bSolicitudesPendientes.ItemClick
        ShowSplash()
        Inicio = True
        frmSolicitudesVencimientos.Dispose()
        frmSolicitudesVencimientos.MdiParent = Me
        frmSolicitudesVencimientos.Show()
        frmSolicitudesVencimientos.Text = e.Item.Caption
        frmSolicitudesVencimientos.WindowState = FormWindowState.Maximized
        Inicio = False
        HideSplash()
    End Sub

    Private Sub bSolicitudesEnviadas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bSolicitudesEnviadas.ItemClick
        ShowSplash()
        Inicio = True
        frmSolicitudesEnviadas.Dispose()
        frmSolicitudesEnviadas.MdiParent = Me
        frmSolicitudesEnviadas.Show()
        frmSolicitudesEnviadas.Text = e.Item.Caption
        frmSolicitudesEnviadas.WindowState = FormWindowState.Maximized
        Inicio = False
        HideSplash()
    End Sub

    Private Sub BarButtonItem22_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bConsultaExistenciaEmpresas.ItemClick
        ShowSplash()
        frmBuscarProductoxEmpresas.Dispose()
        frmBuscarProductoxEmpresas.Show()
        HideSplash()
    End Sub

    Private Sub bConsolidadoPresupuesto_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bConsolidadoPresupuesto.ItemClick
        ShowSplash()
        frmPresupuestoConsolidado.Dispose()
        frmPresupuestoConsolidado.MdiParent = Me
        frmPresupuestoConsolidado.Show()
        frmPresupuestoConsolidado.Text = e.Item.Caption
        frmPresupuestoConsolidado.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bRemisionesCliente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bRemisionesCliente.ItemClick
        ShowSplash()
        frmRemisionesCliente.Dispose()
        frmRemisionesCliente.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmRemisionesCliente.Show()
        frmRemisionesCliente.Text = e.Item.Caption
        frmRemisionesCliente.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem22_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles etOTPendientes.ItemClick
        ShowSplash()
        frmOrdenesEntregaPendientes.Dispose()
        frmOrdenesEntregaPendientes.MdiParent = Me
        frmOrdenesEntregaPendientes.Show()
        frmOrdenesEntregaPendientes.Text = e.Item.Caption
        frmOrdenesEntregaPendientes.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bZohoCrm_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bZohoCrm.ItemClick
        ShowSplash()
        frmZohoConnect.Dispose()
        frmZohoConnect.MdiParent = Me
        frmZohoConnect.Show()
        frmZohoConnect.Text = e.Item.Caption
        frmZohoConnect.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bAnticipo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bAnticipo.ItemClick
        ShowSplash()
        Inicio = True
        frmAnticiposCliente.Dispose()
        frmAnticiposCliente.MdiParent = Me
        frmAnticiposCliente.Control = e.Item.Name
        frmAnticiposCliente.Show()
        frmAnticiposCliente.Text = e.Item.Caption
        frmAnticiposCliente.WindowState = FormWindowState.Maximized
        Inicio = False
        HideSplash()
    End Sub

    Private Sub bComprobantesElectronicos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bComprobantesElectronicos.ItemClick
        ShowSplash()
        frmComprobantesElectonicosProveedores.Dispose()
        frmComprobantesElectonicosProveedores.MdiParent = Me
        frmComprobantesElectonicosProveedores.Show()
        frmComprobantesElectonicosProveedores.Text = e.Item.Caption
        frmComprobantesElectonicosProveedores.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem22_ItemClick_2(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        Dim frm As frmGruposDepreciacion = frmGruposDepreciacion.Instance()
        frm.Dispose()
        '
        Dim f As frmGruposDepreciacion = frmGruposDepreciacion.Instance()

        With f
            .MdiParent = Me
            .Show()
            .Text = e.Item.Caption
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub BarButtonItem24_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        'Validar la Ultima Fecha de Depreciacion
        Dim _DT As DataTable = CierresDB.Cierre_Ultimo()
        'No hay cierre de Activo Fijo Creado
        If _DT.Rows.Count = 0 Then
            Dim frmConfig As New frmConfigurar_Fecha
            With frmConfig
                If .ShowDialog() = DialogResult.Cancel Then
                    .Dispose()
                    Exit Sub
                End If
                .Dispose()
            End With
        End If

        ShowSplash()
        Dim frm As frmActivos = frmActivos.Instance()
        frm.Dispose()
        '
        Dim f As frmActivos = frmActivos.Instance()

        With f
            .MdiParent = Me
            .Show()
            .Text = e.Item.Caption
            .WindowState = FormWindowState.Maximized
        End With
        '
        HideSplash()
    End Sub

    Private Sub etActivos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles etActivos.ItemClick

    End Sub

    Private Sub BarButtonItem26_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        ShowSplash()
        Dim frm As frmAsignarActivo = frmAsignarActivo.Instance()
        frm.Dispose()
        '
        Dim f As frmAsignarActivo = frmAsignarActivo.Instance()
        f.MdiParent = Me
        f.Text = e.Item.Caption
        f.Show()
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem25_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        ShowSplash()
        Dim frm As New frmDepreciacion
        frm.Dispose()

        Dim f As New frmDepreciacion
        f.MdiParent = Me
        f.Text = e.Item.Caption
        f.Show()
        f.WindowState = FormWindowState.Maximized

        HideSplash()
    End Sub

    Private Sub BarButtonItem27_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        Dim frm As New frmMovimientos
        frm.Dispose()

        Dim f As New frmMovimientos
        frmMovimientos.Instance()
        f.MdiParent = Me
        f.Show()
        f.Text = e.Item.Caption
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BarButtonItem28_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        Dim frmConfig As New frmConfigurar_Fecha
        With frmConfig
            If .ShowDialog() = DialogResult.Cancel Then
                .Dispose()
                Exit Sub
            End If
            .Dispose()
        End With
    End Sub

    Private Sub TimerRed_Tick(sender As Object, e As EventArgs) Handles TimerRed.Tick
        VerificarConexion()
    End Sub

    Async Sub VerificarConexion()

        'Dim cx As New CheckConexion
        'Dim response As Response = Await cx.CheckConnection()

        Dim conn As New VerificarConexion
        Dim task As Response = Await conn.CheckConnection()

        If task.IsSuccess Then
            Me.bConnect.ItemAppearance.Normal.BackColor = Color.LimeGreen
            Me.bConnect.Caption = "Connect"
        Else
            Me.bConnect.ItemAppearance.Normal.BackColor = Color.OrangeRed
            Me.bConnect.Caption = "Disconnect"
        End If
    End Sub

    Private Sub bReporteImpuestos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bReporteIRAnual.ItemClick
        ShowSplash()
        frmReporteIRAnual.Dispose()
        frmReporteIRAnual.MdiParent = Me
        frmReporteIRAnual.Show()
        frmReporteIRAnual.Text = e.Item.Caption
        frmReporteIRAnual.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bConnect_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bConnect.ItemClick
        'Dim hash As New HashMD5
        ''
        ''Dim s As String() = {"test0001|", "1.00", "125348569", "ky958482569"}
        'Dim s As String = hash.Main("test0001" + "|" + "1.00" + "|" + "125348569" + "|" + "ky958482569")
        'XtraMsg(s)
    End Sub

    Private Sub bTCambio_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bTCambio.ItemClick
        TC.GetTasaCambio(
            MonedaBase,
            Fecha_Actual.Date)
        '
        ShowTCambio(TC.TC_Oficial)
        Me.Refresh()

        If TC.Validar_Tasa Then
            If TC.TC_Oficial = 1 Then XtraMsg(TC.MensajeDia.ToUpper & vbCrLf &
                                              "FAVOR INGRESAR TASA DE CAMBIO ANTES DE EMPEZAR A FACTURAR", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub bAnalisis_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bAnalisis.ItemClick
        ShowSplash("Cargando...")
        frmReportesClientes.Dispose()
        frmReportesClientes.MdiParent = Me
        frmReportesClientes.Show()
        frmReportesClientes.Text = e.Item.Caption
        frmReportesClientes.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub frmPrincipalRibbon_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F7 Then
            If Login.Equals("jarauz") Then
                With frmExportToFtp
                    .Text = "Subir Reporte de Ventas a FTP"
                    .Show()
                    .WindowState = FormWindowState.Maximized
                End With
            End If
        End If
    End Sub

    Private Sub bListaNegra_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bListaNegra.ItemClick
        ShowSplash("Cargando...")
        '
        frmListaNegra.Dispose()
        frmListaNegra.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmListaNegra.Show()
        frmListaNegra.Text = e.Item.Caption
        frmListaNegra.WindowState = FormWindowState.Maximized
        '
        HideSplash()
    End Sub

    Private Sub bSeguimiento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bSeguimiento.ItemClick
        ShowSplash()
        frmSeguimientoCobranza.Dispose()
        frmSeguimientoCobranza.MdiParent = Me
        frmSeguimientoCobranza.IdCliente = 0
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmSeguimientoCobranza.Show()
        frmSeguimientoCobranza.Text = e.Item.Caption
        frmSeguimientoCobranza.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bEnvioEC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bEnvioEC.ItemClick
        ShowSplash("Cargando...")
        frmBitacoraEnvioEC.Dispose()
        frmBitacoraEnvioEC.MdiParent = Me
        frmBitacoraEnvioEC.Show()
        frmBitacoraEnvioEC.Text = e.Item.Caption
        frmBitacoraEnvioEC.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bBitacoraAprobacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bBitacoraAprobacion.ItemClick
        ShowSplash("Cargando...")
        frmBitacoraAprobaciones.Dispose()
        frmBitacoraAprobaciones.MdiParent = Me
        frmBitacoraAprobaciones.Show()
        frmBitacoraAprobaciones.Text = e.Item.Caption
        frmBitacoraAprobaciones.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem33_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bPresupuestoGastos.ItemClick
        ShowSplash("Cargando...")
        PresuGastoResumen.Dispose()
        PresuGastoResumen.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        PresuGastoResumen.Show()
        PresuGastoResumen.Text = e.Item.Caption
        PresuGastoResumen.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bConsolidadoGastos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bConsolidadoGastos.ItemClick

        'ShowSplash("Cargando...")
        'FrmReportDiferente.Dispose()
        'FrmReportDiferente.MdiParent = Me
        'FrmReportDiferente.Show()
        'FrmReportDiferente.cargargridreport(0, 2)
        'FrmReportDiferente.Text = e.Item.Caption
        'FrmReportDiferente.WindowState = FormWindowState.Maximized
        'HideSplash()

        ShowSplash()
        frmPresupuestoGastosConsolidado.Dispose()
        frmPresupuestoGastosConsolidado.MdiParent = Me
        frmPresupuestoGastosConsolidado.Show()
        frmPresupuestoGastosConsolidado.Text = e.Item.Caption
        frmPresupuestoGastosConsolidado.WindowState = FormWindowState.Maximized
        HideSplash()

    End Sub

    Private Sub BarButtonItem33_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bPlanesMensual.ItemClick
        ShowSplash()
        frmPlanNegocioNew.Dispose()
        frmPlanNegocioNew.MdiParent = Me
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmPlanNegocioNew.Show()
        frmPlanNegocioNew.Text = e.Item.Caption
        frmPlanNegocioNew.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bReportePNRMensual_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bReportePNRMensual.ItemClick
        ShowSplash()
        frmPlanNegocioNewConsolidado.Dispose()
        frmPlanNegocioNewConsolidado.MdiParent = Me
        frmPlanNegocioNewConsolidado.Show()
        frmPlanNegocioNewConsolidado.Text = e.Item.Caption
        frmPlanNegocioNewConsolidado.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub BarButtonItem33_ItemClick_2(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bFacturasCuotas.ItemClick
        ShowSplash()
        frmFacturacionCuotas.Dispose()
        frmFacturacionCuotas.MdiParent = Me
        frmFacturacionCuotas.Text = e.Item.Caption
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmFacturacionCuotas.Show()
        frmFacturacionCuotas.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub bArregloDePago_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bArregloDePago.ItemClick
        ShowSplash()
        frmArregloPago.Dispose()
        frmArregloPago.MdiParent = Me
        frmArregloPago.Text = e.Item.Caption
        Recurso = RolesDB.GetRecurso(e.Item.Name)
        frmArregloPago.Show()
        frmArregloPago.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub
End Class