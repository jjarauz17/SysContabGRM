<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNotaCreditoGT
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotaCreditoGT))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtSerie = New DevExpress.XtraEditors.TextEdit()
        Me.txtDocumento = New DevExpress.XtraEditors.TextEdit()
        Me.txtAutorizado = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.Cliente = New DevExpress.XtraEditors.TextEdit()
        Me.Factura = New DevExpress.XtraEditors.TextEdit()
        Me.FechaNota = New DevExpress.XtraEditors.DateEdit()
        Me.Motivo = New DevExpress.XtraEditors.MemoEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAutorizado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Factura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaNota.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Motivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtSerie)
        Me.LayoutControl1.Controls.Add(Me.txtDocumento)
        Me.LayoutControl1.Controls.Add(Me.txtAutorizado)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Controls.Add(Me.Cliente)
        Me.LayoutControl1.Controls.Add(Me.Factura)
        Me.LayoutControl1.Controls.Add(Me.FechaNota)
        Me.LayoutControl1.Controls.Add(Me.Motivo)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(687, 191, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(508, 324)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(98, 84)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSerie.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.txtSerie.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtSerie.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtSerie.Properties.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(398, 20)
        Me.txtSerie.StyleController = Me.LayoutControl1
        Me.txtSerie.TabIndex = 10
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(98, 60)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtDocumento.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.txtDocumento.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtDocumento.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtDocumento.Properties.ReadOnly = True
        Me.txtDocumento.Size = New System.Drawing.Size(398, 20)
        Me.txtDocumento.StyleController = Me.LayoutControl1
        Me.txtDocumento.TabIndex = 9
        '
        'txtAutorizado
        '
        Me.txtAutorizado.Location = New System.Drawing.Point(98, 36)
        Me.txtAutorizado.Name = "txtAutorizado"
        Me.txtAutorizado.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtAutorizado.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.txtAutorizado.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtAutorizado.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtAutorizado.Properties.ReadOnly = True
        Me.txtAutorizado.Size = New System.Drawing.Size(398, 20)
        Me.txtAutorizado.StyleController = Me.LayoutControl1
        Me.txtAutorizado.TabIndex = 8
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton2.Location = New System.Drawing.Point(256, 276)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(240, 36)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "&Salir"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 276)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(240, 36)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "&Enviar Nota"
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(368, 12)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Fecha.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.Fecha.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.Fecha.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.ReadOnly = True
        Me.Fecha.Size = New System.Drawing.Size(128, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 6
        '
        'Cliente
        '
        Me.Cliente.Location = New System.Drawing.Point(98, 108)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Cliente.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.Cliente.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.Cliente.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.Cliente.Properties.ReadOnly = True
        Me.Cliente.Size = New System.Drawing.Size(398, 20)
        Me.Cliente.StyleController = Me.LayoutControl1
        Me.Cliente.TabIndex = 7
        '
        'Factura
        '
        Me.Factura.Location = New System.Drawing.Point(98, 12)
        Me.Factura.Name = "Factura"
        Me.Factura.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Factura.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Navy
        Me.Factura.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.Factura.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.Factura.Properties.ReadOnly = True
        Me.Factura.Size = New System.Drawing.Size(180, 20)
        Me.Factura.StyleController = Me.LayoutControl1
        Me.Factura.TabIndex = 6
        '
        'FechaNota
        '
        Me.FechaNota.EditValue = New Date(2020, 11, 27, 12, 32, 15, 0)
        Me.FechaNota.Location = New System.Drawing.Point(98, 132)
        Me.FechaNota.Name = "FechaNota"
        Me.FechaNota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaNota.Properties.Appearance.Options.UseFont = True
        Me.FechaNota.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaNota.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaNota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.FechaNota.Size = New System.Drawing.Size(138, 20)
        Me.FechaNota.StyleController = Me.LayoutControl1
        Me.FechaNota.TabIndex = 5
        '
        'Motivo
        '
        Me.Motivo.Location = New System.Drawing.Point(12, 172)
        Me.Motivo.Name = "Motivo"
        Me.Motivo.Size = New System.Drawing.Size(484, 100)
        Me.Motivo.StyleController = Me.LayoutControl1
        Me.Motivo.TabIndex = 4
        Me.Motivo.Tag = "True"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(508, 324)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Motivo
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(488, 120)
        Me.LayoutControlItem1.Text = "Motivo:"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(83, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.FechaNota
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(228, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Fecha Nota:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(83, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Factura
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(270, 24)
        Me.LayoutControlItem3.Text = "Factura:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(83, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Cliente
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(488, 24)
        Me.LayoutControlItem4.Text = "Cliente:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(83, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Fecha
        Me.LayoutControlItem5.Location = New System.Drawing.Point(270, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(218, 24)
        Me.LayoutControlItem5.Text = "Fecha Emisión:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(83, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(228, 120)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(260, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton1
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 264)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(244, 40)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton2
        Me.LayoutControlItem7.Location = New System.Drawing.Point(244, 264)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(244, 40)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtAutorizado
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(488, 24)
        Me.LayoutControlItem8.Text = "No. Autorización:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(83, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtDocumento
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(488, 24)
        Me.LayoutControlItem9.Text = "No. Documento:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(83, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtSerie
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(488, 24)
        Me.LayoutControlItem10.Text = "Serie:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(83, 13)
        '
        'frmNotaCreditoGT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 324)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmNotaCreditoGT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAutorizado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Factura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaNota.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Motivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Motivo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FechaNota As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Cliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Factura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents txtAutorizado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtSerie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
End Class
