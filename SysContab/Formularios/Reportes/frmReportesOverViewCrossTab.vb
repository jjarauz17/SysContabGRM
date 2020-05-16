Public Class frmReportesOverViewCrossTab
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReportesOverViewCrossTab = Nothing

    Public Shared Function Instance() As frmReportesOverViewCrossTab
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportesOverViewCrossTab
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents etSalidas As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportesOverViewCrossTab))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.etSalidas = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button7 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button6 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button8 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.etSalidas)
        Me.GroupBox5.Location = New System.Drawing.Point(200, 164)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(568, 34)
        Me.GroupBox5.TabIndex = 156
        Me.GroupBox5.TabStop = False
        '
        'etSalidas
        '
        Me.etSalidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etSalidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etSalidas.ForeColor = System.Drawing.Color.White
        Me.etSalidas.Location = New System.Drawing.Point(0, 9)
        Me.etSalidas.Name = "etSalidas"
        Me.etSalidas.Size = New System.Drawing.Size(592, 21)
        Me.etSalidas.TabIndex = 113
        Me.etSalidas.Text = "REPORTES DE CONTABILIDAD CROSSTAB"
        Me.etSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(200, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(416, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 157
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(616, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 155)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 158
        Me.PictureBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(159, 164)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(240, 69)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "SALIR"
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(26, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(240, 69)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "BALANZA COMPROBACION"
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(26, 89)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(240, 69)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "ESTADO  RESULTADOS"
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(298, 14)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(240, 69)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "ESTADO  SITUACION"
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(298, 89)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(240, 69)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "FLUJO DE CAJA"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Button8)
        Me.PanelControl1.Controls.Add(Me.Button6)
        Me.PanelControl1.Controls.Add(Me.Button7)
        Me.PanelControl1.Controls.Add(Me.Button4)
        Me.PanelControl1.Controls.Add(Me.Button5)
        Me.PanelControl1.Location = New System.Drawing.Point(200, 195)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(568, 245)
        Me.PanelControl1.TabIndex = 159
        '
        'frmReportesOverViewCrossTab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "frmReportesOverViewCrossTab"
        Me.Text = "Reportes de Contabilidad"
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim f As FrmBalanzaComprobacionCrossTab = FrmBalanzaComprobacionCrossTab.Instance()
        f.MdiParent = Me.MdiParent

        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub



    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim f As FrmEstadoSituacionCrossTab = FrmEstadoSituacionCrossTab.Instance
        f.MdiParent = Me.MdiParent

        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim f As FrmEstadoResultadosCrossTab = FrmEstadoResultadosCrossTab.Instance

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim f As FrmFlujoCajaCrossTab = FrmFlujoCajaCrossTab.Instance()

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub frmReportesOverViewCrossTab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(Me.PanelControl1)
    End Sub
End Class
