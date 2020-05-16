<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirmasContables
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
        Me.Grid = New DevExpress.XtraGrid.GridControl
        Me.vLista = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEditar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.Location = New System.Drawing.Point(12, 12)
        Me.Grid.MainView = Me.vLista
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(467, 287)
        Me.Grid.TabIndex = 0
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vLista})
        '
        'vLista
        '
        Me.vLista.GridControl = Me.Grid
        Me.vLista.Name = "vLista"
        Me.vLista.OptionsBehavior.Editable = False
        Me.vLista.OptionsView.ShowAutoFilterRow = True
        Me.vLista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vLista.OptionsView.ShowFooter = True
        Me.vLista.OptionsView.ShowGroupPanel = False
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAgregar.Enabled = False
        Me.cmdAgregar.Location = New System.Drawing.Point(11, 5)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 30)
        Me.cmdAgregar.TabIndex = 1
        Me.cmdAgregar.Text = "&Agregar"
        '
        'cmdEditar
        '
        Me.cmdEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEditar.Enabled = False
        Me.cmdEditar.Location = New System.Drawing.Point(92, 5)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(75, 30)
        Me.cmdEditar.TabIndex = 2
        Me.cmdEditar.Text = "&Modificar"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(173, 5)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(75, 30)
        Me.cmdBorrar.TabIndex = 3
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(403, 5)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 30)
        Me.cmdSalir.TabIndex = 4
        Me.cmdSalir.Text = "Salir"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdBorrar)
        Me.PanelControl1.Controls.Add(Me.cmdSalir)
        Me.PanelControl1.Controls.Add(Me.cmdAgregar)
        Me.PanelControl1.Controls.Add(Me.cmdEditar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 305)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(491, 42)
        Me.PanelControl1.TabIndex = 5
        '
        'frmFirmasContables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(491, 347)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Grid)
        Me.Name = "frmFirmasContables"
        Me.Text = "Firmas Contables (Para Reportes)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents vLista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
