<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormatoRetenciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormatoRetenciones))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridView4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.lblTitulo)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(605, 484, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1000, 708)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1000, 708)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 34)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(976, 620)
        Me.iGrid.TabIndex = 4
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista, Me.GridView1, Me.BandedGridView1, Me.BandedGridView2, Me.BandedGridView4})
        '
        'iVista
        '
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.iGrid
        Me.GridView1.GroupPanelText = "Arrastre aqui para agrupar Columna"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.BandedGridView1.GridControl = Me.iGrid
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.Editable = False
        Me.BandedGridView1.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView1.OptionsView.ShowFooter = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        '
        'BandedGridView2
        '
        Me.BandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.BandedGridView2.GridControl = Me.iGrid
        Me.BandedGridView2.Name = "BandedGridView2"
        Me.BandedGridView2.OptionsBehavior.Editable = False
        Me.BandedGridView2.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView2.OptionsView.ShowFooter = True
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "GridBand1"
        Me.GridBand2.MinWidth = 20
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.VisibleIndex = 0
        '
        'BandedGridView4
        '
        Me.BandedGridView4.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand4})
        Me.BandedGridView4.GridControl = Me.iGrid
        Me.BandedGridView4.Name = "BandedGridView4"
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "GridBand4"
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.VisibleIndex = 0
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 22)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(980, 624)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(876, 658)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "&Salir"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(864, 646)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(760, 658)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(112, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "E&xportar"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton2
        Me.LayoutControlItem3.Location = New System.Drawing.Point(748, 646)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(116, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 646)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(748, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lblTitulo
        '
        Me.lblTitulo.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblTitulo.Appearance.BackColor2 = System.Drawing.SystemColors.MenuHighlight
        Me.lblTitulo.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Appearance.Options.UseBackColor = True
        Me.lblTitulo.Appearance.Options.UseFont = True
        Me.lblTitulo.Appearance.Options.UseForeColor = True
        Me.lblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTitulo.Location = New System.Drawing.Point(12, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(976, 18)
        Me.lblTitulo.StyleController = Me.LayoutControl1
        Me.lblTitulo.TabIndex = 7
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.lblTitulo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(980, 22)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'frmFormatoRetenciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 708)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFormatoRetenciones"
        Me.Text = "Formato de Retenciones a Proveedores"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridView4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
