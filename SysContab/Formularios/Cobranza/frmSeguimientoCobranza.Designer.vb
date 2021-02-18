<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguimientoCobranza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeguimientoCobranza))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyEditar = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lyAnular = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyAnular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bAnular)
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.bExportar)
        Me.LayoutControl1.Controls.Add(Me.bEditar)
        Me.LayoutControl1.Controls.Add(Me.bNuevo)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1222, 388, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(670, 347)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bAnular
        '
        Me.bAnular.Enabled = False
        Me.bAnular.ImageOptions.SvgImage = CType(resources.GetObject("bAnular.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bAnular.Location = New System.Drawing.Point(240, 299)
        Me.bAnular.Name = "bAnular"
        Me.bAnular.Size = New System.Drawing.Size(110, 36)
        Me.bAnular.StyleController = Me.LayoutControl1
        Me.bAnular.TabIndex = 9
        Me.bAnular.Text = "&Anular"
        '
        'bSalir
        '
        Me.bSalir.ImageOptions.SvgImage = CType(resources.GetObject("bSalir.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bSalir.Location = New System.Drawing.Point(548, 299)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(110, 36)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 8
        Me.bSalir.Text = "&Salir"
        '
        'bExportar
        '
        Me.bExportar.Enabled = False
        Me.bExportar.ImageOptions.SvgImage = CType(resources.GetObject("bExportar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bExportar.Location = New System.Drawing.Point(434, 299)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(110, 36)
        Me.bExportar.StyleController = Me.LayoutControl1
        Me.bExportar.TabIndex = 7
        Me.bExportar.Text = "E&xportar"
        '
        'bEditar
        '
        Me.bEditar.Enabled = False
        Me.bEditar.ImageOptions.SvgImage = CType(resources.GetObject("bEditar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bEditar.Location = New System.Drawing.Point(126, 299)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Size = New System.Drawing.Size(110, 36)
        Me.bEditar.StyleController = Me.LayoutControl1
        Me.bEditar.TabIndex = 6
        Me.bEditar.Text = "&Editar"
        '
        'bNuevo
        '
        Me.bNuevo.Enabled = False
        Me.bNuevo.ImageOptions.SvgImage = CType(resources.GetObject("bNuevo.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bNuevo.Location = New System.Drawing.Point(12, 299)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(110, 36)
        Me.bNuevo.StyleController = Me.LayoutControl1
        Me.bNuevo.TabIndex = 5
        Me.bNuevo.Text = "&Nuevo"
        '
        'iGrid
        '
        Me.iGrid.Location = New System.Drawing.Point(12, 12)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Name = "iGrid"
        Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rLink})
        Me.iGrid.Size = New System.Drawing.Size(646, 283)
        Me.iGrid.TabIndex = 4
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        '
        'rLink
        '
        Me.rLink.AutoHeight = False
        Me.rLink.Caption = "Documentos"
        Me.rLink.Name = "rLink"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.lyEditar, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.lyAnular})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(670, 347)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(650, 287)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.bNuevo
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 287)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(114, 40)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(114, 40)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(114, 40)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'lyEditar
        '
        Me.lyEditar.Control = Me.bEditar
        Me.lyEditar.Location = New System.Drawing.Point(114, 287)
        Me.lyEditar.MaxSize = New System.Drawing.Size(114, 40)
        Me.lyEditar.MinSize = New System.Drawing.Size(114, 40)
        Me.lyEditar.Name = "lyEditar"
        Me.lyEditar.Size = New System.Drawing.Size(114, 40)
        Me.lyEditar.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyEditar.TextSize = New System.Drawing.Size(0, 0)
        Me.lyEditar.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.bExportar
        Me.LayoutControlItem4.Location = New System.Drawing.Point(422, 287)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(114, 40)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(114, 40)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(114, 40)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bSalir
        Me.LayoutControlItem5.Location = New System.Drawing.Point(536, 287)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(114, 40)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(114, 40)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(114, 40)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(342, 287)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(80, 40)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lyAnular
        '
        Me.lyAnular.Control = Me.bAnular
        Me.lyAnular.Location = New System.Drawing.Point(228, 287)
        Me.lyAnular.MaxSize = New System.Drawing.Size(114, 40)
        Me.lyAnular.MinSize = New System.Drawing.Size(114, 40)
        Me.lyAnular.Name = "lyAnular"
        Me.lyAnular.Size = New System.Drawing.Size(114, 40)
        Me.lyAnular.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyAnular.TextSize = New System.Drawing.Size(0, 0)
        Me.lyAnular.TextVisible = False
        '
        'frmSeguimientoCobranza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 347)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.SvgImage = CType(resources.GetObject("frmSeguimientoCobranza.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.KeyPreview = True
        Me.Name = "frmSeguimientoCobranza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyAnular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lyEditar As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents bAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lyAnular As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
End Class
