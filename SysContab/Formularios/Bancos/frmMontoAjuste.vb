Public Class frmMontoAjuste
    'Inherits System.Windows.Forms.Form
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
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rbPerdida As System.Windows.Forms.RadioButton
    Friend WithEvents rbGanancia As System.Windows.Forms.RadioButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents frmMontoAjusteConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit()
        Me.rbPerdida = New System.Windows.Forms.RadioButton()
        Me.rbGanancia = New System.Windows.Forms.RadioButton()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.frmMontoAjusteConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmMontoAjusteConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmMontoAjusteConvertedLayout.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMonto
        '
        Me.txtMonto.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMonto.Location = New System.Drawing.Point(66, 65)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtMonto.Properties.Appearance.Options.UseFont = True
        Me.txtMonto.Properties.Appearance.Options.UseForeColor = True
        Me.txtMonto.Properties.Mask.EditMask = "n2"
        Me.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMonto.Size = New System.Drawing.Size(141, 26)
        Me.txtMonto.StyleController = Me.frmMontoAjusteConvertedLayout
        Me.txtMonto.TabIndex = 3
        '
        'rbPerdida
        '
        Me.rbPerdida.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPerdida.ForeColor = System.Drawing.Color.MediumBlue
        Me.rbPerdida.Location = New System.Drawing.Point(168, 12)
        Me.rbPerdida.Name = "rbPerdida"
        Me.rbPerdida.Size = New System.Drawing.Size(166, 25)
        Me.rbPerdida.TabIndex = 1
        Me.rbPerdida.Text = "Perdida"
        '
        'rbGanancia
        '
        Me.rbGanancia.Checked = True
        Me.rbGanancia.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGanancia.ForeColor = System.Drawing.Color.MediumBlue
        Me.rbGanancia.Location = New System.Drawing.Point(12, 12)
        Me.rbGanancia.Name = "rbGanancia"
        Me.rbGanancia.Size = New System.Drawing.Size(152, 25)
        Me.rbGanancia.TabIndex = 0
        Me.rbGanancia.TabStop = True
        Me.rbGanancia.Text = "Ganancia"
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Image = Global.SysContab.My.Resources.Resources._115
        Me.btnQuit.Location = New System.Drawing.Point(236, 181)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(98, 38)
        Me.btnQuit.StyleController = Me.frmMontoAjusteConvertedLayout
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "&Salir"
        '
        'btnOK
        '
        Me.btnOK.Image = Global.SysContab.My.Resources.Resources._114
        Me.btnOK.Location = New System.Drawing.Point(132, 181)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 38)
        Me.btnOK.StyleController = Me.frmMontoAjusteConvertedLayout
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "&Aceptar"
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(66, 41)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.Fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.Appearance.Options.UseFont = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Size = New System.Drawing.Size(141, 20)
        Me.Fecha.StyleController = Me.frmMontoAjusteConvertedLayout
        Me.Fecha.TabIndex = 2
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(12, 111)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Properties.Appearance.Options.UseFont = True
        Me.txtConcepto.Size = New System.Drawing.Size(322, 66)
        Me.txtConcepto.StyleController = Me.frmMontoAjusteConvertedLayout
        Me.txtConcepto.TabIndex = 7
        '
        'frmMontoAjusteConvertedLayout
        '
        Me.frmMontoAjusteConvertedLayout.Controls.Add(Me.txtConcepto)
        Me.frmMontoAjusteConvertedLayout.Controls.Add(Me.Fecha)
        Me.frmMontoAjusteConvertedLayout.Controls.Add(Me.txtMonto)
        Me.frmMontoAjusteConvertedLayout.Controls.Add(Me.btnQuit)
        Me.frmMontoAjusteConvertedLayout.Controls.Add(Me.rbPerdida)
        Me.frmMontoAjusteConvertedLayout.Controls.Add(Me.rbGanancia)
        Me.frmMontoAjusteConvertedLayout.Controls.Add(Me.btnOK)
        Me.frmMontoAjusteConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmMontoAjusteConvertedLayout.Location = New System.Drawing.Point(0, 0)
        Me.frmMontoAjusteConvertedLayout.Name = "frmMontoAjusteConvertedLayout"
        Me.frmMontoAjusteConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(691, 200, 250, 350)
        Me.frmMontoAjusteConvertedLayout.Root = Me.LayoutControlGroup1
        Me.frmMontoAjusteConvertedLayout.Size = New System.Drawing.Size(346, 231)
        Me.frmMontoAjusteConvertedLayout.TabIndex = 8
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(346, 231)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtConcepto
        Me.LayoutControlItem1.CustomizationFormText = "Concepto:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 83)
        Me.LayoutControlItem1.Name = "txtConceptoitem"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(326, 86)
        Me.LayoutControlItem1.Text = "Concepto:"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Fecha
        Me.LayoutControlItem2.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 29)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(199, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(199, 24)
        Me.LayoutControlItem2.Name = "Fechaitem"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(199, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Fecha:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtMonto
        Me.LayoutControlItem3.CustomizationFormText = "Monto:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 53)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(199, 30)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(199, 30)
        Me.LayoutControlItem3.Name = "txtMontoitem"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(199, 30)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Monto:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(50, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnQuit
        Me.LayoutControlItem4.CustomizationFormText = "btnQuititem"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(224, 169)
        Me.LayoutControlItem4.Name = "btnQuititem"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(102, 42)
        Me.LayoutControlItem4.Text = "btnQuititem"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.rbPerdida
        Me.LayoutControlItem5.CustomizationFormText = "rbPerdidaitem"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(156, 0)
        Me.LayoutControlItem5.Name = "rbPerdidaitem"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(170, 29)
        Me.LayoutControlItem5.Text = "rbPerdidaitem"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.rbGanancia
        Me.LayoutControlItem6.CustomizationFormText = "rbGananciaitem"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "rbGananciaitem"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(156, 29)
        Me.LayoutControlItem6.Text = "rbGananciaitem"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnOK
        Me.LayoutControlItem7.CustomizationFormText = "btnOKitem"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(120, 169)
        Me.LayoutControlItem7.Name = "btnOKitem"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(104, 42)
        Me.LayoutControlItem7.Text = "btnOKitem"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 169)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(120, 42)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(199, 29)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(127, 54)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmMontoAjuste
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(346, 231)
        Me.ControlBox = False
        Me.Controls.Add(Me.frmMontoAjusteConvertedLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMontoAjuste"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste por Deslizamiento de Moneda"
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmMontoAjusteConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmMontoAjusteConvertedLayout.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public OK As String = ""
    Public Monto As Double = 0
    Public TipoA As Boolean = True
    Public Concepto As String = ""
    Public FechaC As Date
    Public Per_Id As Integer

    Private Sub frmMontoAjuste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Fecha.DateTime = Now.Date
        Me.txtMonto.Text = "0.00"
        Me.txtConcepto.Text = String.Empty
        Me.rbGanancia.Checked = True
        FechasPeriodo()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Me.txtMonto.EditValue = 0 Then
            XtraMsg("Digite Una Cantidad Mayor que Cero (0)", MessageBoxIcon.Warning)
            Exit Sub
        End If

        OK = "SI"
        Monto = Me.txtMonto.EditValue
        Concepto = Me.txtConcepto.Text
        FechaC = Me.Fecha.DateTime.Date
        Me.Close()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        OK = "NO"
        Me.Close()
    End Sub

    Sub FechasPeriodo()
        Try
            Dim dtl As New VB.SysContab.PeriodoDetails
            dtl = VB.SysContab.PeriodosDB.GetDetails(Per_Id)

            Me.Fecha.Properties.MinValue = dtl.Inicio
            Me.Fecha.Properties.MaxValue = dtl.Final
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rbGanancia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGanancia.CheckedChanged
        If Me.rbGanancia.Checked Then TipoA = True
    End Sub

    Private Sub rbPerdida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPerdida.CheckedChanged
        If Me.rbPerdida.Checked Then TipoA = False
    End Sub
End Class
