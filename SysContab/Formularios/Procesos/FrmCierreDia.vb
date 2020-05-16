Public Class FrmCierreDia
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
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents bDeshacer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblCierre As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdaceptar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCierreDia))
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdaceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.bDeshacer = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lblCierre = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(231, 109)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Size = New System.Drawing.Size(173, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(392, 48)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "NOTA : Recuerde que una vez cerrado el dia no podra agregar ni modificar informac" &
    "ion contable referente a dias anteriores al periodo cerrado."
        '
        'cmdsalir
        '
        Me.cmdsalir.ImageOptions.Image = CType(resources.GetObject("cmdsalir.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdsalir.Location = New System.Drawing.Point(285, 214)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(119, 38)
        Me.cmdsalir.StyleController = Me.LayoutControl1
        Me.cmdsalir.TabIndex = 2
        Me.cmdsalir.Text = "&Salir"
        '
        'cmdaceptar
        '
        Me.cmdaceptar.ImageOptions.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_SaveLarge
        Me.cmdaceptar.Location = New System.Drawing.Point(162, 214)
        Me.cmdaceptar.Name = "cmdaceptar"
        Me.cmdaceptar.Size = New System.Drawing.Size(119, 38)
        Me.cmdaceptar.StyleController = Me.LayoutControl1
        Me.cmdaceptar.TabIndex = 2
        Me.cmdaceptar.Text = "&Guardar"
        '
        'bDeshacer
        '
        Me.bDeshacer.Appearance.Options.UseTextOptions = True
        Me.bDeshacer.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bDeshacer.Enabled = False
        Me.bDeshacer.ImageOptions.Image = CType(resources.GetObject("bDeshacer.ImageOptions.Image"), System.Drawing.Image)
        Me.bDeshacer.Location = New System.Drawing.Point(12, 214)
        Me.bDeshacer.Name = "bDeshacer"
        Me.bDeshacer.Size = New System.Drawing.Size(128, 38)
        Me.bDeshacer.StyleController = Me.LayoutControl1
        Me.bDeshacer.TabIndex = 4
        Me.bDeshacer.Text = "&Deshacer Ultimo  Cierre"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.lblCierre)
        Me.LayoutControl1.Controls.Add(Me.bDeshacer)
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Controls.Add(Me.cmdaceptar)
        Me.LayoutControl1.Controls.Add(Me.cmdsalir)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(948, 114, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup3
        Me.LayoutControl1.Size = New System.Drawing.Size(416, 264)
        Me.LayoutControl1.TabIndex = 5
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.EmptySpaceItem5, Me.LayoutControlItem2, Me.EmptySpaceItem6, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.EmptySpaceItem7, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.LayoutControlItem5})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "Root"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(416, 264)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.LabelControl1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(396, 52)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 121)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(396, 81)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.Control = Me.Fecha
        Me.LayoutControlItem2.Location = New System.Drawing.Point(135, 97)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(261, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(261, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(261, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Mes a Cerrar:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(80, 14)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 57)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(396, 40)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdsalir
        Me.LayoutControlItem1.Location = New System.Drawing.Point(273, 202)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(123, 42)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(123, 42)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(123, 42)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdaceptar
        Me.LayoutControlItem3.Location = New System.Drawing.Point(150, 202)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(123, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(123, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(123, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(132, 202)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(18, 42)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bDeshacer
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 202)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(132, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 97)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(135, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lblCierre
        '
        Me.lblCierre.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCierre.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lblCierre.Appearance.Options.UseFont = True
        Me.lblCierre.Appearance.Options.UseForeColor = True
        Me.lblCierre.Appearance.Options.UseTextOptions = True
        Me.lblCierre.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblCierre.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblCierre.Location = New System.Drawing.Point(12, 64)
        Me.lblCierre.Name = "lblCierre"
        Me.lblCierre.Size = New System.Drawing.Size(392, 1)
        Me.lblCierre.StyleController = Me.LayoutControl1
        Me.lblCierre.TabIndex = 6
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.lblCierre
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(396, 5)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'FrmCierreDia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(416, 264)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCierreDia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaceptar.Click
        If Fecha.EditValue = Nothing Then
            XtraMsg("Seleccione el dia a cerrar")
            Exit Sub
        End If

        If Not XtraMsg2("Esta seguro que desea cerrar el dia : " & Fecha.EditValue & " , esta Acción no se puede revertir") Then Exit Sub

        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Add("Fecha")
        Variables.Add("Empresa")

        Datos.Add(Fecha.DateTime.Date)
        Datos.Add(EmpresaActual)

        If ProcedureSave(Datos, Variables, "SpCierreDia") = False Then
            XtraMsg("Error al cerrar el dia, intente nuevamente", MessageBoxIcon.Error)
        Else
            XtraMsg("Dia cerrado correctamente!")
            'CierreDeDia()
            CierreDia = BuscarUltimoCierre().Date
            frmPrincipalRibbon.bCierreDia.Caption = CierreDia.ToShortDateString
            Close()
        End If
    End Sub

    Private Sub FrmCierreDia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(LayoutControl1)

        Dim UltimoCierre As Date = BuscarUltimoCierre().Date

        Fecha.Properties.MinValue = UltimoCierre.AddDays(1)
        Fecha.Properties.MaxValue = UltimoDiaDelMes(UltimoCierre.AddMonths(1))
        Fecha.DateTime = UltimoDiaDelMes(UltimoCierre.AddMonths(1))

        Me.Text = "Ultimo Cierre : " & UltimoCierre.ToShortDateString()
        lblCierre.Text = Me.Text

        'Try
        '    Fecha.Properties.MinValue = CDate(ObtieneDatos("SELECT ISNULL(MAX(Fecha),GETDATE()) FROM CierreDia WHERE Empresa = " & EmpresaActual).Rows(0).Item(0)) ' DateAdd(DateInterval.Day, 1, CDate(ObtieneDatos("SELECT MAX(Fecha) FROM CierreDia WHERE Empresa = " & EmpresaActual).Rows(0).Item(0)))
        '    Fecha.Properties.MaxValue = VB.SysContab.Rutinas.Fecha().Date
        '    Fecha.DateTime = VB.SysContab.Rutinas.Fecha().Date
        'Catch ex As Exception
        '    Fecha.DateTime = Now.Date
        'End Try

    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click

    End Sub

    Private Sub bDeshacer_Click(sender As Object, e As EventArgs) Handles bDeshacer.Click

        Dim UltimoCierre As Date = BuscarUltimoCierre().Date

        If Not XtraMsg2("Esta Seguro en Deshacer el Ultimo Cierre :" & UltimoCierre.ToShortDateString & " ?") Then
            Exit Sub
        End If
        '
        If Guardar("sp_del_CierreDia", UltimoCierre, EmpresaActual) Then
            XtraMsg("El Ultimo Cierre contable ha sido abierto correctamente!")
            CierreDia = BuscarUltimoCierre().Date
            frmPrincipalRibbon.bCierreDia.Caption = CierreDia.ToShortDateString
            Close()
        End If

    End Sub
End Class