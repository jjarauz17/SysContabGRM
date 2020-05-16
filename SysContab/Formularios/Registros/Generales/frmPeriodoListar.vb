Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmPeriodoListar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmPeriodoListar = Nothing

    Public Shared Function Instance() As frmPeriodoListar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPeriodoListar()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim PeriodosDB As New VB.SysContab.PeriodosDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Empresas As New VB.SysContab.EmpresasDB()
    Dim EmpresaDetalles As New VB.SysContab.EmpresasDetails()
    Dim Comprobantes As New VB.SysContab.ComprobanteDB()
    Dim Tabla As DataTable
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCerrarPeriodo As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPeriodoListar))
        Me.cmdCerrarPeriodo = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCerrarPeriodo
        '
        Me.cmdCerrarPeriodo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrarPeriodo.Appearance.Options.UseFont = True
        Me.cmdCerrarPeriodo.Enabled = False
        Me.cmdCerrarPeriodo.Image = CType(resources.GetObject("cmdCerrarPeriodo.Image"), System.Drawing.Image)
        Me.cmdCerrarPeriodo.Location = New System.Drawing.Point(212, 225)
        Me.cmdCerrarPeriodo.Name = "cmdCerrarPeriodo"
        Me.cmdCerrarPeriodo.Size = New System.Drawing.Size(137, 38)
        Me.cmdCerrarPeriodo.StyleController = Me.LayoutControl1
        Me.cmdCerrarPeriodo.TabIndex = 7
        Me.cmdCerrarPeriodo.Text = "&Cerrar Periodo"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.cmdCerrarPeriodo)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl1.Controls.Add(Me.cmdModificar)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(965, 305, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(602, 275)
        Me.LayoutControl1.TabIndex = 14
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(395, 225)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(96, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "E&xportar"
        Me.cmdImprimir.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(495, 225)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(95, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'iGrid
        '
        Me.iGrid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid.Location = New System.Drawing.Point(12, 12)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(578, 209)
        Me.iGrid.TabIndex = 13
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsBehavior.Editable = False
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 225)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(96, 38)
        Me.cmdNuevo.StyleController = Me.LayoutControl1
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Image = CType(resources.GetObject("cmdModificar.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(112, 225)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(96, 38)
        Me.cmdModificar.StyleController = Me.LayoutControl1
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(602, 275)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(582, 213)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdNuevo
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 213)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdModificar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(100, 213)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdCerrarPeriodo
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(200, 213)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(141, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(141, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(141, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdSalir
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(483, 213)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdImprimir
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(383, 213)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(341, 213)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(42, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmPeriodoListar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(602, 275)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmPeriodoListar"
        Me.Text = "Listar Periodos"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPeriodoListar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  ''r.CambiarEstilo(Me)
        'r.FormularioColor(Me)

        Cargar()
        iVista.PopulateColumns()
        FormatoGrid(iVista)

        '  VB.SysContab.Rutinas.UsuariosAcciones( Me, Me.Name)

        RolesDB.UsuarioAcciones(LayoutControl1)
    End Sub

    Public Sub Cargar()
        Dim ds As DataSet
        ds = PeriodosDB.GetLista()

        iGrid.DataSource = ds.Tables("Periodos").DefaultView

        'dgEmpresas.DataSource = ds.Tables("Periodos").DefaultView
        'Tabla = ds.Tables("Periodos")
        'r.FormatGenerico(dgEmpresas, Tabla)

        If ds.Tables("Periodos").Rows.Count <> 0 Then
            Registro = iVista.GetRowCellValue(0, "Codigo")
        Else
            Registro = "Vacio"
        End If
    End Sub

    'Private Sub dgEmpresas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgEmpresas.CurrentCellChanged
    '    Registro = dgEmpresas.Item(dgEmpresas.CurrentRowIndex, 0)
    'End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro!")
            Exit Sub
        End If

        'Registro = Me.dgEmpresas.Item(Me.dgEmpresas.CurrentRowIndex, 0)

        Registro = iVista.GetFocusedRowCellValue("Codigo")

        'If Registro = "Vacio" Then
        '    MsgBox("Seleccione el periodo que desea Editar", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        Dim f As frmPeriodoRegistrar = frmPeriodoRegistrar.Instance()
        f.MdiParent = Me.MdiParent

        Dim PerDetalles As VB.SysContab.PeriodoDetails = PeriodosDB.GetDetails(Registro)

        f.txtPeriodo.Text = PerDetalles.Descripcion
        f.dtpDesde.Value = PerDetalles.Inicio
        f.dtpHasta.Value = PerDetalles.Final
        f.ckbPer.Checked = PerDetalles.Accion
        f.ckbPerHab.Checked = PerDetalles.Activo
        f.chkActual.Checked = IIf(PerDetalles.Actual = 1, True, False)
        f.txtValidador.Text = PerDetalles.ID

        If PerDetalles.Estado = True Then
            f.txtPeriodo.Enabled = False
            f.dtpDesde.Enabled = False
            f.dtpHasta.Enabled = False
            f.ckbPer.Enabled = False
            f.ckbPerHab.Enabled = False
            f.chkActual.Enabled = False
            f.txtValidador.Enabled = False
        End If

        f.Show()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmPeriodoRegistrar = frmPeriodoRegistrar.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        'f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        frmExportarImprimir.Mostrar(iGrid, Me.Text)

        ' VistaPrevia(iGrid, Me.Text)
        'Dim fReportes As New frmReportes()
        ''Dim rPeriodo As New rptPeriodos()
        'Dim Periodo As New VB.SysContab.PeriodosDB()
        'Dim r As New VB.SysContab.Rutinas()

        'Dim rPeriodo As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'rPeriodo.Load(Application.StartupPath & "\Reportes\rptPeriodos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        'rPeriodo.SetDataSource(Periodo.GetList2(EmpresaActual))
        'fReportes.crvReportes.ReportSource = rPeriodo
        'fReportes.Show()
    End Sub

    Private Sub cmdCerrarPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrarPeriodo.Click

        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro!")
            Exit Sub
        End If

        Dim CuentaUtilidadPerdida As String
        Dim CuentaUtilidadAcumulada As String

        Dim TipoComp As New VB.SysContab.Tipo_ComprobanteDB()
        Dim PeriodoACerrar As Integer = iVista.GetFocusedRowCellValue("Codigo") ' Me.dgEmpresas.Item(Me.dgEmpresas.CurrentRowIndex, 0)

        If TipoComp.CierreEstado(1, PeriodoACerrar).Tables("Tabla").Rows.Count <> 0 Then
            XtraMsg("El Periodo ya fue cerrado", MessageBoxIcon.Error)
            Exit Sub
        End If

        EmpresaDetalles = Empresas.GetDetails(EmpresaActual)
        Dim PerDetalles As VB.SysContab.PeriodoDetails =
            PeriodosDB.GetDetails(iVista.GetFocusedRowCellValue("Codigo"))

        If PerDetalles.Estado = True Then
            If PerDetalles.Actual = -1 Then
                XtraMsg("El Periodo ya fue cerrado", MessageBoxIcon.Error)
                Exit Sub
            Else
                XtraMsg("Hay un error en el periodo, esta marcado como Estado = Cerrado y la marca de PActual esta <> -1," & _
                vbCrLf & "Avise al administrador / Contador ", MessageBoxIcon.Error)
                'VB.SysContab.Rutinas.ErrorTransaccion()
                Exit Sub
            End If
        End If

        Dim dsTC As DataSet
        dsTC = TipoComp.ListCierre(1)

        If dsTC.Tables("Tabla").Rows.Count = 0 Then
            XtraMsg("Debe crear un tipo de comprobante de cierre")
            Exit Sub
        End If

        CuentaUtilidadPerdida = PeriodosDB.CuentaUtilidadPerdida()
        CuentaUtilidadAcumulada = PeriodosDB.CuentaUtilidadAcumulada()

        If CuentaUtilidadPerdida = "0" Then
            XtraMsg("Debe definirse en el Catalogo la Cuenta de 'Utilidades y/o Perdidas'", MessageBoxIcon.Warning)
            Exit Sub
        End If

        If CuentaUtilidadAcumulada = "0" Then
            XtraMsg("Debe definirse en el Catalogo la Cuenta de 'Utilidades Acumuladas'", MessageBoxIcon.Warning)
            Exit Sub
        End If

        'If MsgBox("Esta seguro que quiere cerrar el Periodo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
        '    Exit Sub
        'End If

        If Not XtraMsg2("Esta Seguro que quiere cerrar el Periodo?") Then
            Exit Sub
        End If

        Dim PeriodoNuevo As Integer
        Dim Inicio As Integer
        Dim Final As Integer

        Dim f As New frmPeriodoCerrar
        r.FormularioColor(f)
        f.Show()
        f.Refresh()

        PeriodoNuevo = PeriodosDB.PeriodoNuevo(iVista.GetFocusedRowCellValue("Codigo"))

        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction

        Inicio = PerDetalles.Final.AddDays(1).Year
        Final = PerDetalles.Final.AddYears(1).Year

        Try

            'Dim NoComprob As Double = Comprobantes.AddComprobanteCierre(dsTC.Tables("Tabla").Rows(0).Item("TipComp_ID").ToString, 1, "Cierre de Periodo", MonedaBase, Me.dgEmpresas.Item(Me.dgEmpresas.CurrentRowIndex, 0), PerDetalles.Final, 0, "", False, OrigenComprobantes.CIERRE_PERIODO_FISCAL)
            Dim NoComprob As Double = Comprobantes.AddComprobante(dsTC.Tables("Tabla").Rows(0).Item("TipComp_ID").ToString, _
                1, "Cierre de Periodo del Año " & CDate(iVista.GetFocusedRowCellValue("Fin")).Year.ToString, MonedaBase, iVista.GetFocusedRowCellValue("Codigo"), _
                PerDetalles.Final, 0, "", False, _
                "0", "", 9, "", PerDetalles.Final, 0, _
                OrigenComprobantes.CIERRE_PERIODO_FISCAL)

            PeriodosDB.CerrarPeriodo(iVista.GetFocusedRowCellValue("Codigo"), _
                                     CuentaUtilidadPerdida, _
                                     CuentaUtilidadAcumulada, _
                                     NoComprob, "Cierre de Periodo del Año " & CDate(iVista.GetFocusedRowCellValue("Fin")).Year.ToString, _
                                     PerDetalles.Final)

            'PeriodosDB.CopiarSaldos(Me.dgEmpresas.Item(Me.dgEmpresas.CurrentRowIndex, 0), PerDetalles.Inicio, PerDetalles.Final, EmpresaDetalles.MonedaBase, EmpresaDetalles.MonedaBase, PerDetalles.Final.AddDays(1), PerDetalles.Final.AddYears(1), "PERIODO " & Inicio & " - " & Final, 1)
            PeriodoNuevo = PeriodosDB.CopiarSaldos(iVista.GetFocusedRowCellValue("Codigo"))
            PeriodosDB.CerrarPeriodo(iVista.GetFocusedRowCellValue("Codigo"), 1)
            VB.SysContab.Rutinas.okTransaccion()

        Catch ex As Exception
            f.Close()
            VB.SysContab.Rutinas.ErrorTransaccion()
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try

        Cargar()

        'ds = PeriodosDB.GetLista()
        'dgEmpresas.DataSource = ds.Tables("Periodos").DefaultView
        'FormPrincipal.StatusBar1.Panels(2).Text = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Actual).Descripcion.ToString
        f.Close()
    End Sub

End Class
