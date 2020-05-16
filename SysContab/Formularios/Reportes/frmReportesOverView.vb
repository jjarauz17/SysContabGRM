Public Class frmReportesOverView
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReportesOverView = Nothing

    Public Shared Function Instance() As frmReportesOverView
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportesOverView()
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
    Friend WithEvents Button5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etSalidas As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Button10 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportesOverView))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Button8 = New DevExpress.XtraEditors.SimpleButton
        Me.Button7 = New DevExpress.XtraEditors.SimpleButton
        Me.Button6 = New DevExpress.XtraEditors.SimpleButton
        Me.Button5 = New DevExpress.XtraEditors.SimpleButton
        Me.Button4 = New DevExpress.XtraEditors.SimpleButton
        Me.Button3 = New DevExpress.XtraEditors.SimpleButton
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton
        Me.Button10 = New DevExpress.XtraEditors.SimpleButton
        Me.Button9 = New DevExpress.XtraEditors.SimpleButton
        Me.etSalidas = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(510, 158)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(240, 69)
        Me.SimpleButton1.TabIndex = 159
        Me.SimpleButton1.Text = "Centro de Costo"
        '
        'Button8
        '
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(262, 160)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(240, 69)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "FLUJO DE CAJA"
        '
        'Button7
        '
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(510, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(240, 69)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "ESTADO  RESULTADOS"
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(262, 83)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(240, 69)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "ESTADO  SITUACION"
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(262, 235)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(240, 69)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "SALIR"
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(262, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(240, 69)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "BALANZA DE COMPROBACION"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(14, 160)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(240, 69)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "MAYOR AUXILIAR"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(14, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 69)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "DIARIO"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(16, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 69)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "COMPROBANTES"
        '
        'Button10
        '
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(510, 83)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(240, 69)
        Me.Button10.TabIndex = 158
        Me.Button10.Text = "DISTRIBUCIÓN"
        '
        'Button9
        '
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(592, 12)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(184, 69)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "BALANZA COMPARATIVA"
        Me.Button9.Visible = False
        '
        'etSalidas
        '
        Me.etSalidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etSalidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.etSalidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etSalidas.ForeColor = System.Drawing.Color.White
        Me.etSalidas.Location = New System.Drawing.Point(2, 2)
        Me.etSalidas.Name = "etSalidas"
        Me.etSalidas.Size = New System.Drawing.Size(763, 16)
        Me.etSalidas.TabIndex = 113
        Me.etSalidas.Text = "REPORTES DE CONTABILIDAD"
        Me.etSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(126, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(768, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 157
        Me.PictureBox1.TabStop = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.Button4)
        Me.PanelControl1.Controls.Add(Me.Button8)
        Me.PanelControl1.Controls.Add(Me.Button10)
        Me.PanelControl1.Controls.Add(Me.Button7)
        Me.PanelControl1.Controls.Add(Me.Button1)
        Me.PanelControl1.Controls.Add(Me.Button6)
        Me.PanelControl1.Controls.Add(Me.Button2)
        Me.PanelControl1.Controls.Add(Me.Button5)
        Me.PanelControl1.Controls.Add(Me.Button3)
        Me.PanelControl1.Location = New System.Drawing.Point(126, 179)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(767, 314)
        Me.PanelControl1.TabIndex = 158
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.etSalidas)
        Me.PanelControl2.Location = New System.Drawing.Point(126, 157)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(767, 20)
        Me.PanelControl2.TabIndex = 159
        '
        'frmReportesOverView
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 501)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button9)
        Me.Name = "frmReportesOverView"
        Me.Text = "Reportes de Contabilidad"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As frmComprobantes = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim f As frmLibroBalanza = f.Instance
        f.MdiParent = Me.MdiParent

        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim f As frmLibroDiario = f.Instance
        f.MdiParent = Me.MdiParent

        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim f As frmLibroEstadoSituacion = f.Instance
        f.MdiParent = Me.MdiParent

        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim f As frmLibroAuxiliar = f.Instance

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim f As frmLibroEstadoResultado = f.Instance

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim f As frmRptFlujoCAja = f.Instance

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim f As FrmLibroBalanzaDinamico = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim F As New frmrptcentroscosto
        F.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim f As New FrmCrosstab_CentroCosto
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub
End Class
