<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguridadGuardar
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(21, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(326, 44)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Va a guardar un comprobante sin distribucion, digite el codigo de autorizacion pa" & _
            "ra proceder"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(30, 53)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Properties.Appearance.Options.UseFont = True
        Me.txtCodigo.Properties.MaxLength = 15
        Me.txtCodigo.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCodigo.Size = New System.Drawing.Size(284, 29)
        Me.txtCodigo.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(171, 88)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(68, 25)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "&Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(245, 88)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 25)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "&Cancelar"
        '
        'frmSeguridadGuardar
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(359, 128)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeguridadGuardar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "*** Código de Seguridad ***"
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
End Class
