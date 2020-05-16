<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProyectosCostosDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProyectosCostosDetalle))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.iGrid1 = New DevExpress.XtraGrid.GridControl()
        Me.iVista1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tPorcentaje = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.tMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.iGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.iGrid1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2575, 311, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(884, 561)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(774, 527)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(98, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Salir"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(672, 527)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(98, 22)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "E&xportar"
        '
        'iGrid1
        '
        Me.iGrid1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid1.Location = New System.Drawing.Point(12, 34)
        Me.iGrid1.MainView = Me.iVista1
        Me.iGrid1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid1.Name = "iGrid1"
        Me.iGrid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.tPorcentaje, Me.tMonto})
        Me.iGrid1.Size = New System.Drawing.Size(860, 489)
        Me.iGrid1.TabIndex = 5
        Me.iGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista1})
        '
        'iVista1
        '
        Me.iVista1.GridControl = Me.iGrid1
        Me.iVista1.Name = "iVista1"
        Me.iVista1.OptionsBehavior.Editable = False
        Me.iVista1.OptionsView.ShowAutoFilterRow = True
        Me.iVista1.OptionsView.ShowFooter = True
        Me.iVista1.OptionsView.ShowGroupPanel = False
        '
        'tPorcentaje
        '
        Me.tPorcentaje.AutoHeight = False
        Me.tPorcentaje.Mask.EditMask = "p4"
        Me.tPorcentaje.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tPorcentaje.Mask.UseMaskAsDisplayFormat = True
        Me.tPorcentaje.Name = "tPorcentaje"
        '
        'tMonto
        '
        Me.tMonto.AutoHeight = False
        Me.tMonto.Mask.EditMask = "n4"
        Me.tMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tMonto.Mask.UseMaskAsDisplayFormat = True
        Me.tMonto.Name = "tMonto"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(884, 561)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.DimGray
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem1.Control = Me.iGrid1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(864, 515)
        Me.LayoutControlItem1.Text = "Detalle de Costos del Proyecto"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(250, 19)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(660, 515)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton2
        Me.LayoutControlItem3.Location = New System.Drawing.Point(762, 515)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 515)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(660, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmProyectosCostosDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.LayoutControl1)
        Me.KeyPreview = True
        Me.Name = "frmProyectosCostosDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.iGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents iGrid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tPorcentaje As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents tMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
