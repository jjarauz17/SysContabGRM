Public Class frmVerFormato
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerFormato))
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(3, 3)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(720, 426)
        Me.PictureEdit1.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(647, 476)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(88, 32)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "<< &Regresar"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(6, 7)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(735, 463)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Controls.Add(Me.PictureEdit1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(726, 432)
        Me.XtraTabPage1.Text = "Formato 1"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage2.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage2.Controls.Add(Me.PictureEdit2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(726, 432)
        Me.XtraTabPage2.Text = "Formato 2"
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureEdit2.EditValue = CType(resources.GetObject("PictureEdit2.EditValue"), Object)
        Me.PictureEdit2.Location = New System.Drawing.Point(3, 3)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit2.Size = New System.Drawing.Size(720, 426)
        Me.PictureEdit2.TabIndex = 1
        '
        'frmVerFormato
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(752, 520)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.LookAndFeel.SkinName = "iMaginary"
        Me.LookAndFeel.UseDefaultLookAndFeel = True
        Me.Name = "frmVerFormato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "*** FORMATO PARA IMPORTAR ARCHIVO DE EXCEL ***"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class

