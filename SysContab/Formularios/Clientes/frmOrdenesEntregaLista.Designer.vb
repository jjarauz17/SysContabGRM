<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenesEntregaLista
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbOrdenes = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vOrdenesList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gridDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cbOrdenes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vOrdenesList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Orden Entrega #:"
        '
        'cbOrdenes
        '
        Me.cbOrdenes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOrdenes.Location = New System.Drawing.Point(114, 16)
        Me.cbOrdenes.Name = "cbOrdenes"
        Me.cbOrdenes.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrdenes.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbOrdenes.Properties.Appearance.Options.UseFont = True
        Me.cbOrdenes.Properties.Appearance.Options.UseForeColor = True
        Me.cbOrdenes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOrdenes.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbOrdenes.Properties.View = Me.vOrdenesList
        Me.cbOrdenes.Size = New System.Drawing.Size(713, 20)
        Me.cbOrdenes.TabIndex = 1
        '
        'vOrdenesList
        '
        Me.vOrdenesList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vOrdenesList.Name = "vOrdenesList"
        Me.vOrdenesList.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vOrdenesList.OptionsView.ShowAutoFilterRow = True
        Me.vOrdenesList.OptionsView.ShowGroupPanel = False
        '
        'gridDatos
        '
        Me.gridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatos.Location = New System.Drawing.Point(12, 42)
        Me.gridDatos.MainView = Me.vDatos
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.Size = New System.Drawing.Size(815, 282)
        Me.gridDatos.TabIndex = 2
        Me.gridDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.gridDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.btnNew)
        Me.PanelControl1.Controls.Add(Me.btnQuit)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 330)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(815, 48)
        Me.PanelControl1.TabIndex = 12
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(20, 9)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(90, 30)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&Aceptar"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Location = New System.Drawing.Point(711, 9)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(90, 30)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "&Salir"
        '
        'frmOrdenesEntregaLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 390)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.gridDatos)
        Me.Controls.Add(Me.cbOrdenes)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmOrdenesEntregaLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "*** LISTA DE ORDENES DE ENTREGA ***"
        CType(Me.cbOrdenes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vOrdenesList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbOrdenes As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vOrdenesList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
End Class
