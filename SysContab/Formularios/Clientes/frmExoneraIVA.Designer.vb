<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExoneraIVA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExoneraIVA))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.mComentario = New DevExpress.XtraEditors.MemoEdit()
        Me.txtFactura = New DevExpress.XtraEditors.TextEdit()
        Me.txtReferencia = New DevExpress.XtraEditors.TextEdit()
        Me.txtCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.mComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.bGuardar)
        Me.LayoutControl1.Controls.Add(Me.mComentario)
        Me.LayoutControl1.Controls.Add(Me.txtFactura)
        Me.LayoutControl1.Controls.Add(Me.txtReferencia)
        Me.LayoutControl1.Controls.Add(Me.txtCliente)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(755, 232, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(570, 310)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'mComentario
        '
        Me.mComentario.Location = New System.Drawing.Point(128, 88)
        Me.mComentario.Name = "mComentario"
        Me.mComentario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mComentario.Properties.Appearance.Options.UseFont = True
        Me.mComentario.Size = New System.Drawing.Size(430, 101)
        Me.mComentario.StyleController = Me.LayoutControl1
        Me.mComentario.TabIndex = 8
        Me.mComentario.Tag = "True"
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(128, 38)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFactura.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFactura.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtFactura.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtFactura.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtFactura.Properties.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(179, 22)
        Me.txtFactura.StyleController = Me.LayoutControl1
        Me.txtFactura.TabIndex = 7
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(128, 64)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Properties.Appearance.Options.UseFont = True
        Me.txtReferencia.Size = New System.Drawing.Size(430, 20)
        Me.txtReferencia.StyleController = Me.LayoutControl1
        Me.txtReferencia.TabIndex = 7
        Me.txtReferencia.Tag = "True"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(128, 12)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCliente.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtCliente.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCliente.Properties.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(430, 22)
        Me.txtCliente.StyleController = Me.LayoutControl1
        Me.txtCliente.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(570, 310)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtCliente
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(550, 26)
        Me.LayoutControlItem1.Text = "Cliente:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtReferencia
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(550, 24)
        Me.LayoutControlItem2.Text = "Referencia Documento:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtFactura
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(299, 26)
        Me.LayoutControlItem3.Text = "No. Factura:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.mComentario
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(550, 105)
        Me.LayoutControlItem4.Text = "Comentarios:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(113, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 248)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(314, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 181)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(550, 67)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(299, 26)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(251, 26)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'bGuardar
        '
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(326, 260)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(114, 38)
        Me.bGuardar.StyleController = Me.LayoutControl1
        Me.bGuardar.TabIndex = 9
        Me.bGuardar.Text = "&Guardar"
        '
        'bSalir
        '
        Me.bSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(444, 260)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(114, 38)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 10
        Me.bSalir.Text = "&Salir"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bGuardar
        Me.LayoutControlItem5.Location = New System.Drawing.Point(314, 248)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bSalir
        Me.LayoutControlItem6.Location = New System.Drawing.Point(432, 248)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(118, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'frmExoneraIVA
        '
        Me.AcceptButton = Me.bGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bSalir
        Me.ClientSize = New System.Drawing.Size(570, 310)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmExoneraIVA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSTANCIA DE EXONERACION DE IVA"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.mComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtReferencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents mComentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
