<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSairi
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
        Me.dgDatos = New DevExpress.XtraGrid.GridControl
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.FHasta = New DevExpress.XtraEditors.DateEdit
        Me.FDesde = New DevExpress.XtraEditors.DateEdit
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDatos
        '
        Me.dgDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDatos.Location = New System.Drawing.Point(0, 78)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(874, 360)
        Me.dgDatos.TabIndex = 3
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsBehavior.Editable = False
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.CheckEdit1)
        Me.PanelControl1.Controls.Add(Me.btnSalir)
        Me.PanelControl1.Controls.Add(Me.btnBuscar)
        Me.PanelControl1.Controls.Add(Me.btnExportar)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.FHasta)
        Me.PanelControl1.Controls.Add(Me.FDesde)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(874, 78)
        Me.PanelControl1.TabIndex = 2
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckEdit1.Location = New System.Drawing.Point(763, 53)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.CheckEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.CheckEdit1.Properties.Caption = "Selector de Datos"
        Me.CheckEdit1.Size = New System.Drawing.Size(106, 21)
        Me.CheckEdit1.TabIndex = 14
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(779, 18)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 32)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "&Salir"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(237, 18)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(90, 32)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "&Buscar"
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Location = New System.Drawing.Point(683, 18)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(90, 32)
        Me.btnExportar.TabIndex = 11
        Me.btnExportar.Text = "&Exportar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(32, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Hasta:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(30, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Desde:"
        '
        'FHasta
        '
        Me.FHasta.EditValue = Nothing
        Me.FHasta.Location = New System.Drawing.Point(85, 30)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.FHasta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FHasta.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.FHasta.Properties.Appearance.Options.UseFont = True
        Me.FHasta.Properties.Appearance.Options.UseForeColor = True
        Me.FHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FHasta.Size = New System.Drawing.Size(146, 20)
        Me.FHasta.TabIndex = 4
        '
        'FDesde
        '
        Me.FDesde.EditValue = Nothing
        Me.FDesde.Location = New System.Drawing.Point(85, 5)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.FDesde.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FDesde.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.FDesde.Properties.Appearance.Options.UseFont = True
        Me.FDesde.Properties.Appearance.Options.UseForeColor = True
        Me.FDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FDesde.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FDesde.Size = New System.Drawing.Size(146, 20)
        Me.FDesde.TabIndex = 5
        '
        'frmSairi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 438)
        Me.Controls.Add(Me.dgDatos)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmSairi"
        Me.Text = "S.A.I.R.I"
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FDesde As DevExpress.XtraEditors.DateEdit
End Class
