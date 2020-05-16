<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCotizacionesDescripcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCotizacionesDescripcion))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.txtComentario = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bGuardar)
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.txtComentario)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(547, 63, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(517, 272)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(517, 272)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(12, 31)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(493, 203)
        Me.txtComentario.StyleController = Me.LayoutControl1
        Me.txtComentario.TabIndex = 188
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.Control = Me.txtComentario
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(497, 226)
        Me.LayoutControlItem1.Text = "Descripción Impresa"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(131, 16)
        '
        'bSalir
        '
        Me.bSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(405, 238)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(100, 22)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 191
        Me.bSalir.Text = "&Cancelar"
        '
        'bGuardar
        '
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(301, 238)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 22)
        Me.bGuardar.StyleController = Me.LayoutControl1
        Me.bGuardar.TabIndex = 190
        Me.bGuardar.Text = "&Guardar"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.bSalir
        Me.LayoutControlItem2.Location = New System.Drawing.Point(393, 226)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(104, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.bGuardar
        Me.LayoutControlItem3.Location = New System.Drawing.Point(289, 226)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(104, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 226)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(289, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmCotizacionesDescripcion
        '
        Me.AcceptButton = Me.bGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bSalir
        Me.ClientSize = New System.Drawing.Size(517, 272)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCotizacionesDescripcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizaciones Descripción"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtComentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
