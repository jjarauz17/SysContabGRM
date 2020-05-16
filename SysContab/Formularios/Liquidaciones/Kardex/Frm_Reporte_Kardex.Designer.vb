<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte_Kardex
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Reporte_Kardex))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Fecha_Ini = New DevExpress.XtraEditors.DateEdit
        Me.Fecha_Fin = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.Productos = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.Fecha_Ini.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha_Ini.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha_Fin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha_Fin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Productos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(46, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Desde :"
        '
        'Fecha_Ini
        '
        Me.Fecha_Ini.EditValue = Nothing
        Me.Fecha_Ini.Location = New System.Drawing.Point(106, 21)
        Me.Fecha_Ini.Name = "Fecha_Ini"
        Me.Fecha_Ini.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha_Ini.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Fecha_Ini.Size = New System.Drawing.Size(100, 20)
        Me.Fecha_Ini.TabIndex = 3
        '
        'Fecha_Fin
        '
        Me.Fecha_Fin.EditValue = Nothing
        Me.Fecha_Fin.Location = New System.Drawing.Point(106, 49)
        Me.Fecha_Fin.Name = "Fecha_Fin"
        Me.Fecha_Fin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha_Fin.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.Fecha_Fin.Size = New System.Drawing.Size(100, 20)
        Me.Fecha_Fin.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(46, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Hasta :"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(548, 24)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(123, 40)
        Me.SimpleButton3.TabIndex = 8
        Me.SimpleButton3.Text = "Imprimir"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(548, 116)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(123, 40)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "Salir"
        '
        'Productos
        '
        Me.Productos.EditValue = ""
        Me.Productos.Location = New System.Drawing.Point(106, 81)
        Me.Productos.Name = "Productos"
        Me.Productos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Productos.Properties.NullText = ""
        Me.Productos.Properties.PopupFormMinSize = New System.Drawing.Size(600, 500)
        Me.Productos.Properties.View = Me.GridLookUpEdit1View
        Me.Productos.Size = New System.Drawing.Size(314, 20)
        Me.Productos.TabIndex = 24
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(24, 84)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl3.TabIndex = 25
        Me.LabelControl3.Text = "Productos :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(106, 113)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(314, 20)
        Me.txtCodigo.TabIndex = 26
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(37, 116)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 27
        Me.LabelControl4.Text = "Codigos :"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = Global.Sts.Admin.My.Resources.Resources.RibbonPrintPreview_ZoomLarge
        Me.SimpleButton1.Location = New System.Drawing.Point(548, 70)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(123, 40)
        Me.SimpleButton1.TabIndex = 28
        Me.SimpleButton1.Text = "Buscar"
        '
        'Frm_Reporte_Kardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 435)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.Productos)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.Fecha_Fin)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.Fecha_Ini)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "Frm_Reporte_Kardex"
        Me.Text = "Reporte de Kardex"
        CType(Me.Fecha_Ini.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha_Ini.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha_Fin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha_Fin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Productos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Fecha_Ini As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Fecha_Fin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Productos As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
