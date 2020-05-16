<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuditoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAuditoria))
        Me.vAuditoriaDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vAuditoria = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbUsuario = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbTablas = New DevExpress.XtraEditors.LookUpEdit()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.dHasta = New DevExpress.XtraEditors.DateEdit()
        Me.dDesde = New DevExpress.XtraEditors.DateEdit()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.vAuditoriaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vAuditoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTablas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vAuditoriaDetalle
        '
        Me.vAuditoriaDetalle.GridControl = Me.dgDatos
        Me.vAuditoriaDetalle.Name = "vAuditoriaDetalle"
        Me.vAuditoriaDetalle.OptionsBehavior.Editable = False
        Me.vAuditoriaDetalle.OptionsView.ShowFooter = True
        Me.vAuditoriaDetalle.OptionsView.ShowGroupPanel = False
        '
        'dgDatos
        '
        Me.dgDatos.Location = New System.Drawing.Point(12, 108)
        Me.dgDatos.MainView = Me.vAuditoria
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(687, 221)
        Me.dgDatos.TabIndex = 7
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vAuditoria, Me.vAuditoriaDetalle})
        '
        'vAuditoria
        '
        Me.vAuditoria.GridControl = Me.dgDatos
        Me.vAuditoria.GroupPanelText = "Arrastrar Columna para Agrupar"
        Me.vAuditoria.Name = "vAuditoria"
        Me.vAuditoria.OptionsBehavior.Editable = False
        Me.vAuditoria.OptionsFind.AlwaysVisible = True
        Me.vAuditoria.OptionsFind.ShowClearButton = False
        Me.vAuditoria.OptionsView.ShowAutoFilterRow = True
        Me.vAuditoria.OptionsView.ShowChildrenInGroupPanel = True
        Me.vAuditoria.OptionsView.ShowFooter = True
        Me.vAuditoria.OptionsView.ShowGroupedColumns = True
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbUsuario)
        Me.LayoutControl1.Controls.Add(Me.cbTablas)
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.bExportar)
        Me.LayoutControl1.Controls.Add(Me.dgDatos)
        Me.LayoutControl1.Controls.Add(Me.dHasta)
        Me.LayoutControl1.Controls.Add(Me.dDesde)
        Me.LayoutControl1.Controls.Add(Me.bBuscar)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(768, 203, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(711, 341)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbUsuario
        '
        Me.cbUsuario.Location = New System.Drawing.Point(55, 84)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUsuario.Properties.Appearance.Options.UseFont = True
        Me.cbUsuario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbUsuario.Properties.NullText = "[Todo]"
        Me.cbUsuario.Properties.ShowFooter = False
        Me.cbUsuario.Properties.ShowHeader = False
        Me.cbUsuario.Size = New System.Drawing.Size(383, 20)
        Me.cbUsuario.StyleController = Me.LayoutControl1
        Me.cbUsuario.TabIndex = 10
        '
        'cbTablas
        '
        Me.cbTablas.Location = New System.Drawing.Point(55, 60)
        Me.cbTablas.Name = "cbTablas"
        Me.cbTablas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTablas.Properties.Appearance.Options.UseFont = True
        Me.cbTablas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTablas.Properties.NullText = "[Todo]"
        Me.cbTablas.Properties.ShowFooter = False
        Me.cbTablas.Properties.ShowHeader = False
        Me.cbTablas.Size = New System.Drawing.Size(383, 20)
        Me.cbTablas.StyleController = Me.LayoutControl1
        Me.cbTablas.TabIndex = 9
        '
        'bSalir
        '
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(615, 12)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(84, 44)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 7
        Me.bSalir.Text = "&Salir"
        '
        'bExportar
        '
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(509, 12)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(102, 44)
        Me.bExportar.StyleController = Me.LayoutControl1
        Me.bExportar.TabIndex = 8
        Me.bExportar.Text = "&Exportar"
        '
        'dHasta
        '
        Me.dHasta.EditValue = Nothing
        Me.dHasta.Location = New System.Drawing.Point(55, 36)
        Me.dHasta.Name = "dHasta"
        Me.dHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dHasta.Properties.Appearance.Options.UseFont = True
        Me.dHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dHasta.Size = New System.Drawing.Size(162, 20)
        Me.dHasta.StyleController = Me.LayoutControl1
        Me.dHasta.TabIndex = 5
        '
        'dDesde
        '
        Me.dDesde.EditValue = Nothing
        Me.dDesde.Location = New System.Drawing.Point(55, 12)
        Me.dDesde.Name = "dDesde"
        Me.dDesde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dDesde.Properties.Appearance.Options.UseFont = True
        Me.dDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dDesde.Size = New System.Drawing.Size(162, 20)
        Me.dDesde.StyleController = Me.LayoutControl1
        Me.dDesde.TabIndex = 4
        '
        'bBuscar
        '
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(221, 12)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(93, 44)
        Me.bBuscar.StyleController = Me.LayoutControl1
        Me.bBuscar.TabIndex = 6
        Me.bBuscar.Text = "&Buscar"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem8, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(711, 341)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dDesde
        Me.LayoutControlItem1.CustomizationFormText = "Desde:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Desde:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(40, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dHasta
        Me.LayoutControlItem2.CustomizationFormText = "Hasta:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Hasta:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(40, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dgDatos
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(691, 225)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(306, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(124, 48)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cbUsuario
        Me.LayoutControlItem8.CustomizationFormText = "Usuario:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(430, 24)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(430, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(430, 24)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Usuario:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(40, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(430, 48)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(261, 48)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(430, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(67, 48)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.bBuscar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(209, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(97, 48)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(97, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(97, 48)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bExportar
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(497, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(106, 48)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(106, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(106, 48)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bSalir
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(603, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(88, 48)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(88, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(88, 48)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbTablas
        Me.LayoutControlItem7.CustomizationFormText = "Tabla:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(430, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(430, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(430, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Tabla:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(40, 13)
        '
        'frmAuditoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 341)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmAuditoria"
        CType(Me.vAuditoriaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vAuditoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTablas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents dHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vAuditoria As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbTablas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbUsuario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents vAuditoriaDetalle As DevExpress.XtraGrid.Views.Grid.GridView
End Class
