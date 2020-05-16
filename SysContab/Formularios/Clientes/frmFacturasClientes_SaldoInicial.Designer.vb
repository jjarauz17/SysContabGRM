<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturasClientes_SaldoInicial
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnFormato = New DevExpress.XtraEditors.SimpleButton
        Me.btnImportar = New DevExpress.XtraEditors.SimpleButton
        Me.btnBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.cmbmoneda = New DevExpress.XtraEditors.LookUpEdit
        Me.Label39 = New System.Windows.Forms.Label
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gridDatos = New DevExpress.XtraGrid.GridControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.btnFormato)
        Me.PanelControl1.Controls.Add(Me.btnImportar)
        Me.PanelControl1.Controls.Add(Me.btnBorrar)
        Me.PanelControl1.Controls.Add(Me.btnImprimir)
        Me.PanelControl1.Controls.Add(Me.btnQuit)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 353)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(868, 48)
        Me.PanelControl1.TabIndex = 3
        '
        'btnFormato
        '
        Me.btnFormato.Location = New System.Drawing.Point(251, 9)
        Me.btnFormato.Name = "btnFormato"
        Me.btnFormato.Size = New System.Drawing.Size(90, 30)
        Me.btnFormato.TabIndex = 1
        Me.btnFormato.Text = "&Ver Formato"
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(138, 9)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(107, 30)
        Me.btnImportar.TabIndex = 0
        Me.btnImportar.Text = "&Importar de Excel"
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(347, 9)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(90, 30)
        Me.btnBorrar.TabIndex = 0
        Me.btnBorrar.Text = "&Borrar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(20, 9)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(112, 30)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "&Exportar/Imprimir"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Location = New System.Drawing.Point(764, 9)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(90, 30)
        Me.btnQuit.TabIndex = 0
        Me.btnQuit.Text = "&Salir"
        '
        'cmbmoneda
        '
        Me.cmbmoneda.Location = New System.Drawing.Point(87, 12)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbmoneda.Properties.NullText = ""
        Me.cmbmoneda.Properties.ShowFooter = False
        Me.cmbmoneda.Properties.ShowHeader = False
        Me.cmbmoneda.Size = New System.Drawing.Size(161, 20)
        Me.cmbmoneda.TabIndex = 141
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(9, 16)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(72, 16)
        Me.Label39.TabIndex = 142
        Me.Label39.Text = "Moneda :"
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.gridDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsBehavior.Editable = False
        Me.vDatos.OptionsView.ShowAutoFilterRow = True
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'gridDatos
        '
        Me.gridDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDatos.Location = New System.Drawing.Point(12, 40)
        Me.gridDatos.MainView = Me.vDatos
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.Size = New System.Drawing.Size(868, 307)
        Me.gridDatos.TabIndex = 2
        Me.gridDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'frmFacturasClientes_SaldoInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 413)
        Me.Controls.Add(Me.cmbmoneda)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.gridDatos)
        Me.Name = "frmFacturasClientes_SaldoInicial"
        Me.Text = "*** SALDO INICIAL DEL CLIENTES ***"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.cmbmoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnFormato As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmbmoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridDatos As DevExpress.XtraGrid.GridControl
End Class
