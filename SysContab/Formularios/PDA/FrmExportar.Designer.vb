<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExportar))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LblContador = New DevExpress.XtraEditors.LabelControl()
        Me.CmbDependencia = New System.Windows.Forms.ComboBox()
        Me.LblExportacion = New DevExpress.XtraEditors.LabelControl()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.PbrExportacion = New DevExpress.XtraEditors.ProgressBarControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CkbTodosAF = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbDependencia2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CkbCatalogos = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PbrExportacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CkbTodosAF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.CmbDependencia2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CkbCatalogos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.PanelControl3)
        Me.GroupControl1.Controls.Add(Me.PanelControl1)
        Me.GroupControl1.Controls.Add(Me.PanelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(474, 569)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Selección de Información a Exportar"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LabelControl9)
        Me.PanelControl3.Controls.Add(Me.LabelControl10)
        Me.PanelControl3.Controls.Add(Me.LblContador)
        Me.PanelControl3.Controls.Add(Me.CmbDependencia)
        Me.PanelControl3.Controls.Add(Me.LblExportacion)
        Me.PanelControl3.Controls.Add(Me.BtnCancelar)
        Me.PanelControl3.Controls.Add(Me.BtnExportar)
        Me.PanelControl3.Controls.Add(Me.PbrExportacion)
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Controls.Add(Me.LabelControl5)
        Me.PanelControl3.Location = New System.Drawing.Point(6, 408)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(462, 153)
        Me.PanelControl3.TabIndex = 2
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(12, 29)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl9.TabIndex = 11
        Me.LabelControl9.Text = "Exportando Archivos:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(12, 6)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl10.TabIndex = 10
        Me.LabelControl10.Text = "Exportación"
        '
        'LblContador
        '
        Me.LblContador.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContador.Location = New System.Drawing.Point(134, 84)
        Me.LblContador.Name = "LblContador"
        Me.LblContador.Size = New System.Drawing.Size(0, 13)
        Me.LblContador.TabIndex = 9
        '
        'CmbDependencia
        '
        Me.CmbDependencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDependencia.FormattingEnabled = True
        Me.CmbDependencia.Location = New System.Drawing.Point(182, 19)
        Me.CmbDependencia.Name = "CmbDependencia"
        Me.CmbDependencia.Size = New System.Drawing.Size(264, 23)
        Me.CmbDependencia.TabIndex = 9
        Me.CmbDependencia.Visible = False
        '
        'LblExportacion
        '
        Me.LblExportacion.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExportacion.Location = New System.Drawing.Point(134, 29)
        Me.LblExportacion.Name = "LblExportacion"
        Me.LblExportacion.Size = New System.Drawing.Size(0, 13)
        Me.LblExportacion.TabIndex = 8
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.BtnCancelar.Location = New System.Drawing.Point(351, 84)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(105, 63)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.ToolTip = "Salir de Exportación"
        '
        'BtnExportar
        '
        Me.BtnExportar.Location = New System.Drawing.Point(6, 84)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(105, 63)
        Me.BtnExportar.TabIndex = 6
        Me.BtnExportar.ToolTip = "Exportar Datos Hacia PDA"
        '
        'PbrExportacion
        '
        Me.PbrExportacion.Location = New System.Drawing.Point(6, 51)
        Me.PbrExportacion.Name = "PbrExportacion"
        Me.PbrExportacion.Size = New System.Drawing.Size(450, 27)
        Me.PbrExportacion.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(6, 29)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl6.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(6, 6)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(0, 14)
        Me.LabelControl5.TabIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.CkbTodosAF)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(462, 61)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 5)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(195, 14)
        Me.LabelControl4.TabIndex = 2
        Me.LabelControl4.Text = "Selección de Todos los Activos Fijos"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(6, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(0, 14)
        Me.LabelControl1.TabIndex = 1
        '
        'CkbTodosAF
        '
        Me.CkbTodosAF.Location = New System.Drawing.Point(38, 31)
        Me.CkbTodosAF.Name = "CkbTodosAF"
        Me.CkbTodosAF.Properties.Caption = "Exportar Todos los Activos Fijos"
        Me.CkbTodosAF.Size = New System.Drawing.Size(206, 19)
        Me.CkbTodosAF.TabIndex = 0
        Me.CkbTodosAF.ToolTip = "Exporta todos los Activos Fijos (No Recomendado, Vea Ayuda)"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Controls.Add(Me.CmbDependencia2)
        Me.PanelControl2.Controls.Add(Me.CkbCatalogos)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Location = New System.Drawing.Point(6, 106)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(462, 302)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(61, 55)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(72, 16)
        Me.LabelControl8.TabIndex = 12
        Me.LabelControl8.Text = "Ubicaciones:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(12, 6)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(238, 14)
        Me.LabelControl7.TabIndex = 11
        Me.LabelControl7.Text = "Selección de Activos por Centros de Costos"
        '
        'CmbDependencia2
        '
        Me.CmbDependencia2.EditValue = "'_'"
        Me.CmbDependencia2.Location = New System.Drawing.Point(139, 54)
        Me.CmbDependencia2.Name = "CmbDependencia2"
        Me.CmbDependencia2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.CmbDependencia2.Properties.Appearance.Options.UseBackColor = True
        Me.CmbDependencia2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbDependencia2.Properties.NullText = ""
        Me.CmbDependencia2.Properties.View = Me.GridLookUpEdit1View
        Me.CmbDependencia2.Size = New System.Drawing.Size(264, 20)
        Me.CmbDependencia2.TabIndex = 10
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'CkbCatalogos
        '
        Me.CkbCatalogos.Location = New System.Drawing.Point(27, 277)
        Me.CkbCatalogos.Name = "CkbCatalogos"
        Me.CkbCatalogos.Properties.Caption = "Exportar Catálogos"
        Me.CkbCatalogos.Size = New System.Drawing.Size(206, 19)
        Me.CkbCatalogos.TabIndex = 7
        Me.CkbCatalogos.ToolTip = "Exporta los Catálogos de Empleados y Centros de Costo"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(61, 54)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(0, 16)
        Me.LabelControl3.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(6, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(0, 14)
        Me.LabelControl2.TabIndex = 2
        '
        'FrmExportar
        '
        Me.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 577)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "FrmExportar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.PbrExportacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.CkbTodosAF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.CmbDependencia2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CkbCatalogos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CkbTodosAF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CkbCatalogos As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PbrExportacion As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LblExportacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblContador As DevExpress.XtraEditors.LabelControl
    ' Friend WithEvents TdbCentroCosto As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents CmbDependencia As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDependencia2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
