<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportar
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportar))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ckbTRASLADOS = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.DtpHasta = New DevExpress.XtraEditors.DateEdit()
        Me.DtpDesde = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CkbTodosAFLeidos = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LblControl = New DevExpress.XtraEditors.LabelControl()
        Me.PbrImportacion = New DevExpress.XtraEditors.ProgressBarControl()
        Me.BtnImportar = New DevExpress.XtraEditors.SimpleButton()
        Me.TTCImportar = New DevExpress.Utils.ToolTipController(Me.components)
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LblImportacion = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ckbTRASLADOS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DtpHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CkbTodosAFLeidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PbrImportacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.ckbTRASLADOS)
        Me.GroupControl1.Controls.Add(Me.PanelControl1)
        Me.GroupControl1.Controls.Add(Me.CkbTodosAFLeidos)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(306, 184)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Selección de Información a Importar"
        '
        'ckbTRASLADOS
        '
        Me.ckbTRASLADOS.EditValue = True
        Me.ckbTRASLADOS.Location = New System.Drawing.Point(5, 161)
        Me.ckbTRASLADOS.Name = "ckbTRASLADOS"
        Me.ckbTRASLADOS.Properties.Caption = "Activos Trasladados"
        Me.ckbTRASLADOS.Size = New System.Drawing.Size(165, 18)
        Me.ckbTRASLADOS.TabIndex = 2
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.DtpHasta)
        Me.PanelControl1.Controls.Add(Me.DtpDesde)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(42, 49)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(225, 96)
        Me.PanelControl1.TabIndex = 1
        '
        'DtpHasta
        '
        Me.DtpHasta.EditValue = Nothing
        Me.DtpHasta.Enabled = False
        Me.DtpHasta.Location = New System.Drawing.Point(63, 64)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtpHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DtpHasta.Size = New System.Drawing.Size(134, 20)
        Me.DtpHasta.TabIndex = 4
        '
        'DtpDesde
        '
        Me.DtpDesde.EditValue = Nothing
        Me.DtpDesde.Enabled = False
        Me.DtpDesde.Location = New System.Drawing.Point(63, 30)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtpDesde.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DtpDesde.Size = New System.Drawing.Size(134, 20)
        Me.DtpDesde.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(15, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Hasta:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 33)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Desde:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Lecturas por fechas:"
        '
        'CkbTodosAFLeidos
        '
        Me.CkbTodosAFLeidos.EditValue = True
        Me.CkbTodosAFLeidos.Location = New System.Drawing.Point(5, 25)
        Me.CkbTodosAFLeidos.Name = "CkbTodosAFLeidos"
        Me.CkbTodosAFLeidos.Properties.Caption = "Todos los Activos Fijos Leídos"
        Me.CkbTodosAFLeidos.Size = New System.Drawing.Size(165, 18)
        Me.CkbTodosAFLeidos.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LblControl)
        Me.GroupControl2.Controls.Add(Me.PbrImportacion)
        Me.GroupControl2.Controls.Add(Me.BtnImportar)
        Me.GroupControl2.Controls.Add(Me.BtnCancelar)
        Me.GroupControl2.Controls.Add(Me.LblImportacion)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 202)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(306, 151)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Avance del Proceso"
        '
        'LblControl
        '
        Me.LblControl.Location = New System.Drawing.Point(111, 70)
        Me.LblControl.Name = "LblControl"
        Me.LblControl.Size = New System.Drawing.Size(156, 13)
        Me.LblControl.TabIndex = 11
        Me.LblControl.Text = "                                                    "
        '
        'PbrImportacion
        '
        Me.PbrImportacion.Location = New System.Drawing.Point(7, 39)
        Me.PbrImportacion.Name = "PbrImportacion"
        Me.PbrImportacion.Size = New System.Drawing.Size(294, 25)
        Me.PbrImportacion.TabIndex = 10
        '
        'BtnImportar
        '
        ' Me.BtnImportar.Image = Global.SIAF__BDF.My.Resources.Resources.Importar
        Me.BtnImportar.Location = New System.Drawing.Point(5, 92)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(90, 55)
        Me.BtnImportar.TabIndex = 9
        Me.BtnImportar.ToolTip = "Importar Lectuars del PDA hacia la PC"
        Me.BtnImportar.ToolTipController = Me.TTCImportar
        '
        'TTCImportar
        '
        Me.TTCImportar.Rounded = True
        Me.TTCImportar.RoundRadius = 15
        Me.TTCImportar.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.BtnCancelar.Location = New System.Drawing.Point(211, 92)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(90, 55)
        Me.BtnCancelar.TabIndex = 8
        Me.BtnCancelar.ToolTip = "Salir de Importación"
        Me.BtnCancelar.ToolTipController = Me.TTCImportar
        '
        'LblImportacion
        '
        Me.LblImportacion.Location = New System.Drawing.Point(111, 26)
        Me.LblImportacion.Name = "LblImportacion"
        Me.LblImportacion.Size = New System.Drawing.Size(156, 13)
        Me.LblImportacion.TabIndex = 4
        Me.LblImportacion.Text = "                                                    "
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(7, 26)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Importando Activos:"
        '
        'FrmImportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 358)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importaciones"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.ckbTRASLADOS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DtpHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CkbTodosAFLeidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.PbrImportacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CkbTodosAFLeidos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DtpHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DtpDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LblImportacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnImportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TTCImportar As DevExpress.Utils.ToolTipController
    Friend WithEvents PbrImportacion As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents LblControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckbTRASLADOS As DevExpress.XtraEditors.CheckEdit
End Class
