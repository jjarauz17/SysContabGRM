Public Class FrmReportesGestionComercialCrossTab
    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As FrmReportesGestionComercialCrossTab = Nothing

    Public Shared Function Instance() As FrmReportesGestionComercialCrossTab
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmReportesGestionComercialCrossTab
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents etSalidas As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bCotizaciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bRebajas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bDevoluciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportesGestionComercialCrossTab))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.etSalidas = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.bRebajas = New DevExpress.XtraEditors.SimpleButton()
        Me.bDevoluciones = New DevExpress.XtraEditors.SimpleButton()
        Me.bCotizaciones = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button6 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button3 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button4 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.etSalidas)
        Me.GroupBox5.Location = New System.Drawing.Point(200, 154)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(618, 34)
        Me.GroupBox5.TabIndex = 160
        Me.GroupBox5.TabStop = False
        '
        'etSalidas
        '
        Me.etSalidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etSalidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etSalidas.ForeColor = System.Drawing.Color.White
        Me.etSalidas.Location = New System.Drawing.Point(-56, 3)
        Me.etSalidas.Name = "etSalidas"
        Me.etSalidas.Size = New System.Drawing.Size(792, 21)
        Me.etSalidas.TabIndex = 113
        Me.etSalidas.Text = "REPORTES DE GESTION COMERCIAL CROSSTAB"
        Me.etSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.bRebajas)
        Me.PanelControl1.Controls.Add(Me.bDevoluciones)
        Me.PanelControl1.Controls.Add(Me.bCotizaciones)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.Button6)
        Me.PanelControl1.Controls.Add(Me.Button2)
        Me.PanelControl1.Controls.Add(Me.Button5)
        Me.PanelControl1.Controls.Add(Me.Button3)
        Me.PanelControl1.Location = New System.Drawing.Point(200, 180)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(618, 386)
        Me.PanelControl1.TabIndex = 163
        '
        'bRebajas
        '
        Me.bRebajas.Enabled = False
        Me.bRebajas.ImageOptions.SvgImage = CType(resources.GetObject("bRebajas.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bRebajas.Location = New System.Drawing.Point(56, 231)
        Me.bRebajas.Name = "bRebajas"
        Me.bRebajas.Size = New System.Drawing.Size(240, 69)
        Me.bRebajas.TabIndex = 10
        Me.bRebajas.Text = "REBAJAS / DESCUENTOS"
        '
        'bDevoluciones
        '
        Me.bDevoluciones.Enabled = False
        Me.bDevoluciones.ImageOptions.SvgImage = CType(resources.GetObject("bDevoluciones.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bDevoluciones.Location = New System.Drawing.Point(56, 156)
        Me.bDevoluciones.Name = "bDevoluciones"
        Me.bDevoluciones.Size = New System.Drawing.Size(240, 69)
        Me.bDevoluciones.TabIndex = 9
        Me.bDevoluciones.Text = "DEVOLUCIONES DE CLIENTE"
        '
        'bCotizaciones
        '
        Me.bCotizaciones.Enabled = False
        Me.bCotizaciones.ImageOptions.SvgImage = CType(resources.GetObject("bCotizaciones.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bCotizaciones.Location = New System.Drawing.Point(328, 156)
        Me.bCotizaciones.Name = "bCotizaciones"
        Me.bCotizaciones.Size = New System.Drawing.Size(240, 69)
        Me.bCotizaciones.TabIndex = 8
        Me.bCotizaciones.Text = "COTIZACIONES DE CLIENTES"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(328, 81)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(240, 69)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "RESUMEN DE CAJA"
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.ImageOptions.SvgImage = CType(resources.GetObject("Button6.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Button6.Location = New System.Drawing.Point(328, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(240, 69)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "VENTAS          "
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.ImageOptions.SvgImage = CType(resources.GetObject("Button2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Button2.Location = New System.Drawing.Point(56, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 69)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "COMPRAS      "
        '
        'Button5
        '
        Me.Button5.ImageOptions.SvgImage = CType(resources.GetObject("Button5.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Button5.Location = New System.Drawing.Point(328, 231)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(240, 69)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "SALIR"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.ImageOptions.SvgImage = CType(resources.GetObject("Button3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Button3.Location = New System.Drawing.Point(56, 81)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(240, 69)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "INVENTARIO   "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(650, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(168, 155)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 162
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(200, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(448, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 161
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.ImageOptions.Image = CType(resources.GetObject("Button1.ImageOptions.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(834, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 69)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CTAS X PAGAR      "
        Me.Button1.Visible = False
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.ImageOptions.Image = CType(resources.GetObject("Button4.ImageOptions.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(834, 69)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 69)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "CTAS X COBRAR     "
        Me.Button4.Visible = False
        '
        'FrmReportesGestionComercialCrossTab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 627)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Name = "FrmReportesGestionComercialCrossTab"
        Me.Text = "Reportes de Gestión Comercial CrossTab"
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As FrmCuentasxPagarCrossTab = FrmCuentasxPagarCrossTab.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim f As FrmCuentaxCobrarCrossTab = FrmCuentaxCobrarCrossTab.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ShowSplash()
        Dim f As FrmComprasCrossTab = FrmComprasCrossTab.Instance()
        f.MdiParent = Me.MdiParent
        f.Text = "Dinámico de Compras"
        f.Show()
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ShowSplash()
        Dim f As FrmVentasCrossTab = FrmVentasCrossTab.Instance()
        f.MdiParent = Me.MdiParent

        f.Show()
        f.Text = "Dinámico de Ventas"
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim f As FrmConsultasVentas = FrmConsultasVentas.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ShowSplash("Cargando...")
        frmResumenCaja.Dispose()
        '
        Dim f As New frmResumenCaja
        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Resumen de Caja"
        f.WindowState = FormWindowState.Maximized
        HideSplash()
    End Sub

    Private Sub FrmReportesGestionComercialCrossTab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(Me.PanelControl1)
    End Sub

    Private Sub bCotizaciones_Click(sender As Object, e As EventArgs) Handles bCotizaciones.Click
        frmDinamicoCotizaciones.Dispose()
        frmDinamicoCotizaciones.MdiParent = Me.MdiParent
        frmDinamicoCotizaciones.etInicio.Text = "0"
        frmDinamicoCotizaciones.Show()        
        frmDinamicoCotizaciones.WindowState = FormWindowState.Maximized
        frmDinamicoCotizaciones.etInicio.Text = "1"
    End Sub

    Private Sub bDevoluciones_Click(sender As Object, e As EventArgs) Handles bDevoluciones.Click
        ShowSplash()
        frmDinamicoDevoluciones.Dispose()
        frmDinamicoDevoluciones.etInicio.Text = "0"
        frmDinamicoDevoluciones.MdiParent = Me.MdiParent
        frmDinamicoDevoluciones.Show()
        frmDinamicoDevoluciones.WindowState = FormWindowState.Maximized
        frmDinamicoDevoluciones.etInicio.Text = "1"
        HideSplash()
    End Sub

    Private Sub bRebajas_Click(sender As Object, e As EventArgs) Handles bRebajas.Click
        ShowSplash()
        frmDinamicoRebajas.Dispose()
        frmDinamicoRebajas.etInicio.Text = "0"
        frmDinamicoRebajas.MdiParent = Me.MdiParent
        frmDinamicoRebajas.Show()
        frmDinamicoRebajas.WindowState = FormWindowState.Maximized
        frmDinamicoDevoluciones.etInicio.Text = "1"
        HideSplash()
    End Sub
End Class
