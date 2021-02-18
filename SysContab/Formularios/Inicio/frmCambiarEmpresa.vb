Imports System.IO
Imports ClasesBLL
Public Class frmCambiarEmpresa
    Inherits DevExpress.XtraEditors.XtraForm

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
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbEmpresas As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambiarEmpresa))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cbEmpresas = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbEmpresas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.cbEmpresas)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(514, 164, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(459, 158)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(242, 108)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(101, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Seleccionar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(347, 108)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Cancelar"
        '
        'cbEmpresas
        '
        Me.cbEmpresas.Location = New System.Drawing.Point(12, 29)
        Me.cbEmpresas.Name = "cbEmpresas"
        Me.cbEmpresas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpresas.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbEmpresas.Properties.Appearance.Options.UseFont = True
        Me.cbEmpresas.Properties.Appearance.Options.UseForeColor = True
        Me.cbEmpresas.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpresas.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbEmpresas.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbEmpresas.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cbEmpresas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpresas.Properties.ShowFooter = False
        Me.cbEmpresas.Properties.ShowHeader = False
        Me.cbEmpresas.Size = New System.Drawing.Size(435, 22)
        Me.cbEmpresas.StyleController = Me.LayoutControl1
        Me.cbEmpresas.TabIndex = 0
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(459, 158)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.Control = Me.cbEmpresas
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(439, 43)
        Me.LayoutControlItem1.Text = "Seleccione Empresa:"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(122, 14)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(230, 96)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(105, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(335, 96)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 43)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(439, 53)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 96)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(230, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmCambiarEmpresa
        '
        Me.AcceptButton = Me.SimpleButton2
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.SimpleButton1
        Me.ClientSize = New System.Drawing.Size(459, 158)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambiarEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar Empresa"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbEmpresas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Empresa As New VB.SysContab.EmpresasDB
    Dim EmpresaDetalle As New VB.SysContab.EmpresasDetails
    Dim AuditoriaEmpresa As New VB.SysContab.AuditoriaDB
    Dim Logo As New VB.SysContab.EmpresasDB
    Dim Config As New VB.SysContab.ConfiguracionDB
    Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails
    Private TC As New db_TasaCambio

    Private Sub frmCambiarEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim r As New VB.SysContab.Rutinas

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
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Help.ShowHelp(Me, "Ayuda/Herramientas/CambiarEmpresa.chm")
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click


        If Me.cbEmpresas.Text = "" Then
            XtraMsg("No hay ninguna empresa Seleccionada", MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        '
        If EmpresaActual <> cbEmpresas.EditValue Then
            CerrarFormulariosHijos()
        End If

        EmpresaActual = cbEmpresas.EditValue
        NombreEmpresaActual = cbEmpresas.Text
        EmpresaA = EmpresaActual

        EmpresaDetalle = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails

        MonedaBase = EmpresaDetalle.MonedaBase
        Round = "n" & EmpresaDetalle.Decimales
        RoundP = "n" & ConfigDetalles.Decimales

        AuditoriaEmpresa.AuditoriaSelEmpresa(formtitulo, 3)

        Dim lds As New DataSet
        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        lds.WriteXml(Application.StartupPath & "\xml\logoempresa.xml", XmlWriteMode.WriteSchema)

        'CierreDeDia()
        CierreDia = BuscarUltimoCierre().Date

        'FormPrincipal.StatusBar1.Panels(2).Text = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo).Descripcion.ToString
        'Dim principal As New frmPrincipal()
        'FormPrincipal.Text = "SysContab - " & NombreEmpresaActual

        'Dim Cadena As String = Cadena = VB.SysContab.EmpresasDB.GetLogoEmpresaPath()

        frmPrincipalRibbon.RibbonControl.ApplicationCaption = formtitulo & " - " & NombreEmpresaActual
        frmPrincipalRibbon.AplicarCulture()

        AplicarRoles()

        Try
            frmPrincipalRibbon.bCierreDia.Caption = CierreDia.ToShortDateString
        Catch ex As Exception
            frmPrincipalRibbon.bCierreDia.Caption = "Sin Definir"
        End Try

        TC.GetTasaCambio(
            MonedaBase,
            VB.SysContab.Rutinas.Fecha().Date)

        ShowTCambio(TC.TC_Oficial)

        'My.Forms.frmPrincipalRibbon.RibbonControl.ApplicationDocumentCaption = formtitulo & " - " & NombreEmpresaActual
        'FormPrincipal.Text = FormTitulo & " - " & NombreEmpresaActual
        'If File.Exists(Cadena) Then
        '    FormPrincipal.pbLogo.Image = FormPrincipal.pbLogo.Image.FromFile(Cadena)
        'End If
        'principal.Refresh()

        CargarLogo()
        Me.Close()
    End Sub

    Sub CerrarFormulariosHijos()
        Dim f As DevExpress.XtraEditors.XtraForm

        For Each f In frmPrincipalRibbon.MdiChildren
            f.Close()
        Next

    End Sub

    'Sub CierreDeDia()
    '    Try
    '        CierreDia = CDate(ObtieneDatos("SELECT MAX(Fecha) FROM CierreDia WHERE Empresa = " & EmpresaActual).Rows(0).Item(0))
    '    Catch ex As Exception
    '        CierreDia = vbNullString
    '        'GuardaDatos("sp_CierreAdd " & EmpresaActual)
    '        'GoTo Verificar
    '    End Try
    'End Sub

    Sub AplicarRoles()

        RolesDB.UsuarioMenu()
        Dim DT_ROL As DataTable = RolesDB.UsuarioRecursos()

        If DT_ROL.Rows.Count > 0 Then
            Dim dr() As DataRow = DT_ROL.Select("Control = 'AlertaTCambio'")
            Dim dr2() As DataRow = DT_ROL.Select("Control = 'AlertaTCambioDia'")

            With frmPrincipalRibbon
                If dr.Length > 0 Then .IniciaContador(1000)
                If dr2.Length > 0 Then .IniciaContador2(1000)
            End With
        End If
    End Sub

End Class
