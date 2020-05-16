<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowDialog
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
        Me.cbCuentas = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        CType(Me.cbCuentas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCuentas
        '
        Me.cbCuentas.Location = New System.Drawing.Point(69, 35)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCuentas.Properties.PopupFormMinSize = New System.Drawing.Size(700, 0)
        Me.cbCuentas.Size = New System.Drawing.Size(390, 20)
        Me.cbCuentas.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(20, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Cuenta:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(281, 79)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(86, 33)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "&Aceptar"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(373, 79)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 33)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "&Salir"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.cbCuentas)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.btnSalir)
        Me.GroupControl1.Controls.Add(Me.btnAceptar)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(487, 121)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "CUENTA CONTABLE TEMPORAL"
        '
        'frmShowDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 146)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShowDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Cuenta"
        CType(Me.cbCuentas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbCuentas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
