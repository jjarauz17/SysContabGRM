<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormato_SadoInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormato_SadoInicial))
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(2, 4)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(718, 311)
        Me.PictureEdit1.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton1.Location = New System.Drawing.Point(625, 321)
        Me.SimpleButton1.LookAndFeel.SkinName = "Glass Oceans"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = True
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(95, 34)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Salir"
        '
        'frmFormato_SadoInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.SimpleButton1
        Me.ClientSize = New System.Drawing.Size(725, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = True
        Me.Name = "frmFormato_SadoInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
