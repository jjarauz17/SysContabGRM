Imports System.IO

Public Class frmbackup
    Inherits DevExpress.XtraEditors.XtraForm


    Private Shared ChildInstance As frmbackup = Nothing

    Public Shared Function Instance() As frmbackup
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmbackup
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents bar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblporcentaje As System.Windows.Forms.Label
    Friend WithEvents Abrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdrestaurar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdbuscarrespaldo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Detalle As System.Windows.Forms.ListView
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtnombrebase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkbd As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtarchivorestaura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtServidor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents etMsg As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdRespaldo As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbackup))
        Me.bar = New System.Windows.Forms.ProgressBar()
        Me.lblporcentaje = New System.Windows.Forms.Label()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Detalle = New System.Windows.Forms.ListView()
        Me.cmdrestaurar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.etMsg = New DevExpress.XtraEditors.LabelControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.txtnombrebase = New DevExpress.XtraEditors.TextEdit()
        Me.chkbd = New DevExpress.XtraEditors.CheckEdit()
        Me.txtarchivorestaura = New DevExpress.XtraEditors.TextEdit()
        Me.txtBase = New DevExpress.XtraEditors.TextEdit()
        Me.cmdRespaldo = New DevExpress.XtraEditors.SimpleButton()
        Me.txtServidor = New DevExpress.XtraEditors.TextEdit()
        Me.cmdbuscarrespaldo = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Guardar = New System.Windows.Forms.SaveFileDialog()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtnombrebase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkbd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtarchivorestaura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServidor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bar
        '
        Me.bar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bar.Location = New System.Drawing.Point(0, 464)
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(432, 17)
        Me.bar.TabIndex = 2
        Me.bar.Visible = False
        '
        'lblporcentaje
        '
        Me.lblporcentaje.Location = New System.Drawing.Point(324, 472)
        Me.lblporcentaje.Name = "lblporcentaje"
        Me.lblporcentaje.Size = New System.Drawing.Size(96, 17)
        Me.lblporcentaje.TabIndex = 4
        '
        'Abrir
        '
        Me.Abrir.DefaultExt = "*.bak"
        Me.Abrir.Filter = "(*.bak)|*.bak"
        '
        'Detalle
        '
        Me.Detalle.Location = New System.Drawing.Point(24, 280)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Size = New System.Drawing.Size(384, 118)
        Me.Detalle.TabIndex = 18
        Me.Detalle.UseCompatibleStateImageBehavior = False
        '
        'cmdrestaurar
        '
        Me.cmdrestaurar.Image = CType(resources.GetObject("cmdrestaurar.Image"), System.Drawing.Image)
        Me.cmdrestaurar.Location = New System.Drawing.Point(306, 238)
        Me.cmdrestaurar.Name = "cmdrestaurar"
        Me.cmdrestaurar.Size = New System.Drawing.Size(102, 38)
        Me.cmdrestaurar.StyleController = Me.LayoutControl1
        Me.cmdrestaurar.TabIndex = 13
        Me.cmdrestaurar.Text = "Res&taurar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.etMsg)
        Me.LayoutControl1.Controls.Add(Me.Detalle)
        Me.LayoutControl1.Controls.Add(Me.btnSalir)
        Me.LayoutControl1.Controls.Add(Me.txtnombrebase)
        Me.LayoutControl1.Controls.Add(Me.chkbd)
        Me.LayoutControl1.Controls.Add(Me.txtarchivorestaura)
        Me.LayoutControl1.Controls.Add(Me.txtBase)
        Me.LayoutControl1.Controls.Add(Me.cmdRespaldo)
        Me.LayoutControl1.Controls.Add(Me.txtServidor)
        Me.LayoutControl1.Controls.Add(Me.cmdbuscarrespaldo)
        Me.LayoutControl1.Controls.Add(Me.cmdrestaurar)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(432, 464)
        Me.LayoutControl1.TabIndex = 15
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'etMsg
        '
        Me.etMsg.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.etMsg.Location = New System.Drawing.Point(24, 91)
        Me.etMsg.Name = "etMsg"
        Me.etMsg.Size = New System.Drawing.Size(384, 1)
        Me.etMsg.StyleController = Me.LayoutControl1
        Me.etMsg.TabIndex = 19
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(307, 414)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 38)
        Me.btnSalir.StyleController = Me.LayoutControl1
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "&Salir"
        '
        'txtnombrebase
        '
        Me.txtnombrebase.Location = New System.Drawing.Point(149, 214)
        Me.txtnombrebase.Name = "txtnombrebase"
        Me.txtnombrebase.Size = New System.Drawing.Size(259, 20)
        Me.txtnombrebase.StyleController = Me.LayoutControl1
        Me.txtnombrebase.TabIndex = 8
        '
        'chkbd
        '
        Me.chkbd.Location = New System.Drawing.Point(24, 214)
        Me.chkbd.Name = "chkbd"
        Me.chkbd.Properties.Caption = "Nueva Base de Datos"
        Me.chkbd.Size = New System.Drawing.Size(121, 15)
        Me.chkbd.StyleController = Me.LayoutControl1
        Me.chkbd.TabIndex = 7
        '
        'txtarchivorestaura
        '
        Me.txtarchivorestaura.Location = New System.Drawing.Point(24, 181)
        Me.txtarchivorestaura.Name = "txtarchivorestaura"
        Me.txtarchivorestaura.Size = New System.Drawing.Size(348, 20)
        Me.txtarchivorestaura.StyleController = Me.LayoutControl1
        Me.txtarchivorestaura.TabIndex = 6
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(96, 67)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(312, 20)
        Me.txtBase.StyleController = Me.LayoutControl1
        Me.txtBase.TabIndex = 5
        '
        'cmdRespaldo
        '
        Me.cmdRespaldo.Image = CType(resources.GetObject("cmdRespaldo.Image"), System.Drawing.Image)
        Me.cmdRespaldo.Location = New System.Drawing.Point(305, 96)
        Me.cmdRespaldo.Name = "cmdRespaldo"
        Me.cmdRespaldo.Size = New System.Drawing.Size(103, 38)
        Me.cmdRespaldo.StyleController = Me.LayoutControl1
        Me.cmdRespaldo.TabIndex = 1
        Me.cmdRespaldo.Text = "&Respaldar"
        '
        'txtServidor
        '
        Me.txtServidor.Location = New System.Drawing.Point(96, 43)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(312, 20)
        Me.txtServidor.StyleController = Me.LayoutControl1
        Me.txtServidor.TabIndex = 4
        '
        'cmdbuscarrespaldo
        '
        Me.cmdbuscarrespaldo.Location = New System.Drawing.Point(376, 181)
        Me.cmdbuscarrespaldo.Name = "cmdbuscarrespaldo"
        Me.cmdbuscarrespaldo.Size = New System.Drawing.Size(32, 29)
        Me.cmdbuscarrespaldo.StyleController = Me.LayoutControl1
        Me.cmdbuscarrespaldo.TabIndex = 12
        Me.cmdbuscarrespaldo.Text = "..."
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem10, Me.LayoutControlGroup3, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(432, 464)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Respaldar Base de Datos"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem11})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(412, 138)
        Me.LayoutControlGroup2.Text = "Respaldar Base de Datos"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtServidor
        Me.LayoutControlItem1.CustomizationFormText = "Servidor:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(388, 24)
        Me.LayoutControlItem1.Text = "Servidor:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(69, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtBase
        Me.LayoutControlItem2.CustomizationFormText = "Base de Datos"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(388, 24)
        Me.LayoutControlItem2.Text = "Base de Datos"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(69, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 53)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(281, 42)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdRespaldo
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(281, 53)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.etMsg
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(388, 5)
        Me.LayoutControlItem11.Text = "LayoutControlItem11"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnSalir
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(295, 402)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(117, 42)
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Restaurar Base de Datos"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem5, Me.LayoutControlItem9, Me.LayoutControlItem8, Me.LayoutControlItem6, Me.EmptySpaceItem3})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 138)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(412, 264)
        Me.LayoutControlGroup3.Text = "Restaurar Base de Datos"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtarchivorestaura
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(352, 33)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdbuscarrespaldo
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(352, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(36, 33)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(36, 33)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(36, 33)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.chkbd
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 33)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(125, 24)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Detalle
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 99)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(388, 122)
        Me.LayoutControlItem9.Text = "LayoutControlItem9"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdrestaurar
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(282, 57)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(106, 42)
        Me.LayoutControlItem8.Text = "LayoutControlItem8"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtnombrebase
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(125, 33)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(263, 24)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 57)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(282, 42)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 402)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(295, 42)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmbackup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(432, 481)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.lblporcentaje)
        Me.Controls.Add(Me.bar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmbackup"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Base Datos"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtnombrebase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkbd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtarchivorestaura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServidor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim restaura As SQLDMO.Restore2
    Dim respaldo As SQLDMO.Backup2
    Dim servidor As SQLDMO.SQLServer2

    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtServidor.Text = Server
        txtBase.Text = DBName

        Dim r As New VB.SysContab.Rutinas

        '' r.FormularioColor(Me)

        With Detalle
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .LabelEdit = False
            .Columns.Clear()
            .Items.Clear()
            .Columns.Add("No", 40, HorizontalAlignment.Center)
            .Columns.Add("Fecha", 170, HorizontalAlignment.Center)
            .Columns.Add("Equipo", 50, HorizontalAlignment.Center)
            .Columns.Add("Base", 50, HorizontalAlignment.Center)
            .Columns.Add("Usuario", 70, HorizontalAlignment.Center)
        End With
    End Sub

    Private Sub ConectaServidor()
        servidor = New SQLDMO.SQLServer2
        With servidor
            .LoginSecure = False
            .Name = Server 'nombre del server
            .Connect(Server, Usuario, UPassword) 'servidor usuario pass
        End With
    End Sub

    Public Sub PercentComplete(ByVal Message As String, ByVal Percent As Integer)
        bar.Value = Percent
        lblporcentaje.Refresh()
        lblporcentaje.Text = Percent & "% Completado"
    End Sub

    Private Sub chkbd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' txtnombrebase.ReadOnly = Not chkbd.Checked
    End Sub

    Private Sub cmdRespaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRespaldo.Click


        'Dim cad As String = 

        'VB.SysContab.Rutinas.AbrirConexion()


        'If Not IO.Directory.Exists("C:\backup\") Then
        '    IO.Directory.CreateDirectory("C:\backup\")
        'End If

        'Try
        '    Funciones.GuardaDatos("BACKUP DATABASE " & DBName & " TO DISK = 'C:\backup\SYSCONTAB-BACKUP" & Now.Year & Now.Month & Now.Day & Now.Hour & Now.Minute & ".BAK'")
        '    MsgBox("Respaldo realizado satisfactoriamente. En la ubicación c:\backup\")
        '    Exit Sub
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


        'respaldo = New SQLDMO.Backup2
        'ConectaServidor()
        'AddHandler respaldo.PercentComplete, AddressOf PercentComplete


        'With respaldo
        '    .Database = DBName 'nombre de la db a respaldar
        '    .Files = "[C:\SystemBackUp\" & .Database & Format(Now, "ddmmyyhhmmss") & ".bak]"
        '    .Action = SQLDMO.SQLDMO_BACKUP_TYPE.SQLDMOBackup_Database
        '    bar.Visible = True
        '    lblporcentaje.Visible = True
        '    Try
        '        .SQLBackup(servidor)
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        '    bar.Visible = False
        '    lblporcentaje.Visible = False
        'End With
        'servidor.DisConnect()


        '' Dim f As Date = RutinasDB.FechaServer()

        Dim f As Date = VB.SysContab.Rutinas.Fecha()

        Me.Guardar.Filter = "Archivos de Respaldo (*.bak)|*.bak"
        Me.Guardar.FileName = "SysContab_Backup_" + f.ToShortDateString.Replace("/", "").Replace("\", "") + "_" + f.ToShortTimeString.Replace(":", "").Replace(" ", "").Replace(".", "").ToUpper
        If Me.Guardar.ShowDialog = Windows.Forms.DialogResult.OK Then
            ShowSplash()
            If GuardaDatos("JAR_BackupDB '" & txtBase.Text & "','" & Me.Guardar.FileName & "'") Then
                etMsg.ForeColor = Color.DarkRed
                etMsg.Text = "Respaldo Creado en: " + Me.Guardar.FileName
            End If
            HideSplash()
        End If
    End Sub

    Private Sub cmdrestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrestaurar.Click
        Dim NuevaUbicacion
        Dim Resultado As SQLDMO.QueryResults2
        If Detalle.SelectedItems.Count = 0 Then Exit Sub
        ConectaServidor()
        restaura.Files = "[" & txtarchivorestaura.Text & "]"
        restaura.FileNumber = Detalle.SelectedItems.Item(0).Text
        If chkbd.Checked Then
            Resultado = restaura.ReadFileList(servidor)
            For i As Integer = 1 To Resultado.Rows
                NuevaUbicacion = NuevaUbicacion & IIf(NuevaUbicacion = vbNullString, "", ",") & "[" & Resultado.GetColumnString(i, 1) & "],[" & servidor.Registry.SQLDataRoot & "\Data\" & txtnombrebase.Text & "." & IIf(i = 1, "mdf]", "ldf]")
                If i = 2 Then Exit For
            Next i
            restaura.RelocateFiles = NuevaUbicacion
        End If
        restaura.Action = SQLDMO.SQLDMO_RESTORE_TYPE.SQLDMORestore_Database
        restaura.Database = IIf(chkbd.Checked, txtnombrebase.Text, "sf")
        restaura.ReplaceDatabase = True
        AddHandler restaura.PercentComplete, AddressOf PercentComplete
        bar.Visible = True
        lblporcentaje.Visible = True
        Try
            restaura.SQLRestore(servidor)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bar.Visible = False
        lblporcentaje.Visible = False
    End Sub

    Private Sub cmdbuscarrespaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbuscarrespaldo.Click
        Dim dr As SQLDMO.QueryResults2
        Detalle.Items.Clear()
        txtarchivorestaura.Text = vbNullString
        If Abrir.ShowDialog = DialogResult.Cancel Then Exit Sub
        restaura = New SQLDMO.Restore2
        ConectaServidor()
        With restaura
            .Files = Abrir.FileName
            txtarchivorestaura.Text = Abrir.FileName
            .LoadHistory = True
            dr = .ReadBackupHeader(servidor)
        End With

        For i As Integer = 1 To dr.Rows

            With Detalle.Items.Add(dr.GetColumnString(i, 6))
                .SubItems.Add(dr.GetColumnString(i, 19))
                .SubItems.Add(dr.GetColumnString(i, 9))
                .SubItems.Add(dr.GetColumnString(i, 10))
                .SubItems.Add(dr.GetColumnString(i, 8))
            End With
        Next
        servidor.DisConnect()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub chkbd_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbd.CheckedChanged
        txtnombrebase.Properties.ReadOnly = Not chkbd.Checked
    End Sub
End Class

