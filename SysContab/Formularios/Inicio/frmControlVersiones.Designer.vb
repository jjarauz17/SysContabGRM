<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlVersiones
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlVersiones))
        Me.bGuardarComo = New DevExpress.XtraEditors.SimpleButton()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.rVersiones = New DevExpress.XtraRichEdit.RichEditControl()
        Me.cMenuDerecho = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cMenuDerecho.SuspendLayout()
        Me.SuspendLayout()
        '
        'bGuardarComo
        '
        Me.bGuardarComo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardarComo.Appearance.Options.UseTextOptions = True
        Me.bGuardarComo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bGuardarComo.Image = CType(resources.GetObject("bGuardarComo.Image"), System.Drawing.Image)
        Me.bGuardarComo.Location = New System.Drawing.Point(611, 602)
        Me.bGuardarComo.Name = "bGuardarComo"
        Me.bGuardarComo.Size = New System.Drawing.Size(107, 38)
        Me.bGuardarComo.TabIndex = 7
        Me.bGuardarComo.Text = "&Guardar Como"
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(724, 602)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(102, 38)
        Me.bSalir.TabIndex = 6
        Me.bSalir.Text = "&Salir"
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.Appearance.Options.UseTextOptions = True
        Me.bGuardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(494, 602)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(111, 38)
        Me.bGuardar.TabIndex = 6
        Me.bGuardar.Text = "&Guardar Documento"
        '
        'rVersiones
        '
        Me.rVersiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rVersiones.Location = New System.Drawing.Point(12, 12)
        Me.rVersiones.Name = "rVersiones"
        Me.rVersiones.Options.Fields.UseCurrentCultureDateTimeFormat = False
        Me.rVersiones.Options.MailMerge.KeepLastParagraph = False
        Me.rVersiones.Size = New System.Drawing.Size(814, 584)
        Me.rVersiones.TabIndex = 4
        '
        'cMenuDerecho
        '
        Me.cMenuDerecho.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem})
        Me.cMenuDerecho.Name = "cMenuDerecho"
        Me.cMenuDerecho.Size = New System.Drawing.Size(170, 26)
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'frmControlVersiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 652)
        Me.Controls.Add(Me.rVersiones)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bGuardarComo)
        Me.KeyPreview = True
        Me.Name = "frmControlVersiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Versiones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cMenuDerecho.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rVersiones As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardarComo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cMenuDerecho As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
