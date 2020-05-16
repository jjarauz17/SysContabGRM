<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiseñoFacturaCliente
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
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = 2
        Me.RadioGroup1.Location = New System.Drawing.Point(25, 12)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGroup1.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.RadioGroup1.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup1.Properties.Appearance.Options.UseForeColor = True
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Factura de Contado"), New DevExpress.XtraEditors.Controls.RadioGroupItem(9, "Factura de Crédito")})
        Me.RadioGroup1.Size = New System.Drawing.Size(257, 93)
        Me.RadioGroup1.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(177, 120)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(105, 32)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Cancelar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(25, 120)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(105, 32)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Aceptar"
        '
        'frmDiseñoFacturaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 165)
        Me.ControlBox = False
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.RadioGroup1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = True
        Me.Name = "frmDiseñoFacturaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
