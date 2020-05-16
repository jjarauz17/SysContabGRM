Public Class frmComprobantesDiariosLista
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmComprobantesDiariosLista = Nothing

    Public Shared Function Instance() As frmComprobantesDiariosLista
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmComprobantesDiariosLista()
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
    Friend WithEvents gbxAccion As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdDebitosCreditos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdComprasAbono As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdComprasCredito As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdComprasContado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNomina As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAmortizaciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdActivoFijo As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComprobantesDiariosLista))
        Me.gbxAccion = New System.Windows.Forms.GroupBox()
        Me.cmdDebitosCreditos = New DevExpress.XtraEditors.SimpleButton()
        Me.Button3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdActivoFijo = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNomina = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdComprasContado = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdComprasCredito = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAmortizaciones = New DevExpress.XtraEditors.SimpleButton()
        Me.Button5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button11 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdComprasAbono = New DevExpress.XtraEditors.SimpleButton()
        Me.Button4 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button8 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button7 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button6 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button10 = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxAccion.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxAccion
        '
        Me.gbxAccion.BackColor = System.Drawing.Color.Transparent
        Me.gbxAccion.Controls.Add(Me.cmdDebitosCreditos)
        Me.gbxAccion.Controls.Add(Me.Button3)
        Me.gbxAccion.Controls.Add(Me.Button1)
        Me.gbxAccion.Controls.Add(Me.Button2)
        Me.gbxAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAccion.ForeColor = System.Drawing.Color.Maroon
        Me.gbxAccion.Location = New System.Drawing.Point(224, 119)
        Me.gbxAccion.Name = "gbxAccion"
        Me.gbxAccion.Size = New System.Drawing.Size(264, 253)
        Me.gbxAccion.TabIndex = 151
        Me.gbxAccion.TabStop = False
        Me.gbxAccion.Text = "VENTAS"
        '
        'cmdDebitosCreditos
        '
        Me.cmdDebitosCreditos.Enabled = False
        Me.cmdDebitosCreditos.ImageOptions.Image = CType(resources.GetObject("cmdDebitosCreditos.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdDebitosCreditos.Location = New System.Drawing.Point(8, 189)
        Me.cmdDebitosCreditos.Name = "cmdDebitosCreditos"
        Me.cmdDebitosCreditos.Size = New System.Drawing.Size(250, 50)
        Me.cmdDebitosCreditos.TabIndex = 10
        Me.cmdDebitosCreditos.Text = "NOTAS  DEBITOS-CREDITOS"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.ImageOptions.Image = CType(resources.GetObject("Button3.ImageOptions.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(8, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(250, 50)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "ABONOS A FACTURA"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.ImageOptions.Image = CType(resources.GetObject("Button1.ImageOptions.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(8, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "VENTAS DE CONTADO"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.ImageOptions.Image = CType(resources.GetObject("Button2.ImageOptions.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(8, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(250, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "VENTAS DE CREDITO"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(194, 34)
        Me.GroupBox3.TabIndex = 161
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(568, 21)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "CONTABILIZAR INGRESOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmdActivoFijo)
        Me.GroupBox1.Controls.Add(Me.cmdNomina)
        Me.GroupBox1.Controls.Add(Me.cmdComprasContado)
        Me.GroupBox1.Controls.Add(Me.cmdComprasCredito)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(496, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 253)
        Me.GroupBox1.TabIndex = 162
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COMPRAS"
        '
        'cmdActivoFijo
        '
        Me.cmdActivoFijo.Enabled = False
        Me.cmdActivoFijo.ImageOptions.Image = CType(resources.GetObject("cmdActivoFijo.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdActivoFijo.Location = New System.Drawing.Point(8, 77)
        Me.cmdActivoFijo.Name = "cmdActivoFijo"
        Me.cmdActivoFijo.Size = New System.Drawing.Size(250, 50)
        Me.cmdActivoFijo.TabIndex = 5
        Me.cmdActivoFijo.Text = "ACTIVO FIJO"
        '
        'cmdNomina
        '
        Me.cmdNomina.Enabled = False
        Me.cmdNomina.ImageOptions.Image = CType(resources.GetObject("cmdNomina.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNomina.Location = New System.Drawing.Point(8, 19)
        Me.cmdNomina.Name = "cmdNomina"
        Me.cmdNomina.Size = New System.Drawing.Size(250, 50)
        Me.cmdNomina.TabIndex = 4
        Me.cmdNomina.Text = "NOMINA"
        '
        'cmdComprasContado
        '
        Me.cmdComprasContado.Enabled = False
        Me.cmdComprasContado.ImageOptions.Image = CType(resources.GetObject("cmdComprasContado.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdComprasContado.Location = New System.Drawing.Point(8, 189)
        Me.cmdComprasContado.Name = "cmdComprasContado"
        Me.cmdComprasContado.Size = New System.Drawing.Size(250, 50)
        Me.cmdComprasContado.TabIndex = 1
        Me.cmdComprasContado.Text = "FACTURAS DE CONTADO"
        '
        'cmdComprasCredito
        '
        Me.cmdComprasCredito.Enabled = False
        Me.cmdComprasCredito.ImageOptions.Image = CType(resources.GetObject("cmdComprasCredito.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdComprasCredito.Location = New System.Drawing.Point(8, 133)
        Me.cmdComprasCredito.Name = "cmdComprasCredito"
        Me.cmdComprasCredito.Size = New System.Drawing.Size(250, 50)
        Me.cmdComprasCredito.TabIndex = 2
        Me.cmdComprasCredito.Text = "FACTURAS DE CREDITOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnAmortizaciones)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(224, 378)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 80)
        Me.GroupBox2.TabIndex = 163
        Me.GroupBox2.TabStop = False
        '
        'btnAmortizaciones
        '
        Me.btnAmortizaciones.Enabled = False
        Me.btnAmortizaciones.ImageOptions.Image = CType(resources.GetObject("btnAmortizaciones.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAmortizaciones.Location = New System.Drawing.Point(8, 18)
        Me.btnAmortizaciones.Name = "btnAmortizaciones"
        Me.btnAmortizaciones.Size = New System.Drawing.Size(250, 50)
        Me.btnAmortizaciones.TabIndex = 164
        Me.btnAmortizaciones.Text = "AMORTIZACIONES"
        '
        'Button5
        '
        Me.Button5.ImageOptions.Image = CType(resources.GetObject("Button5.ImageOptions.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(280, 18)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(250, 50)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "SALIR"
        '
        'Button11
        '
        Me.Button11.ImageOptions.Image = CType(resources.GetObject("Button11.ImageOptions.Image"), System.Drawing.Image)
        Me.Button11.Location = New System.Drawing.Point(766, 265)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(248, 36)
        Me.Button11.TabIndex = 12
        Me.Button11.Text = "ADELANTOS"
        Me.Button11.UseWaitCursor = True
        Me.Button11.Visible = False
        '
        'cmdComprasAbono
        '
        Me.cmdComprasAbono.ImageOptions.Image = CType(resources.GetObject("cmdComprasAbono.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdComprasAbono.Location = New System.Drawing.Point(766, 201)
        Me.cmdComprasAbono.Name = "cmdComprasAbono"
        Me.cmdComprasAbono.Size = New System.Drawing.Size(248, 52)
        Me.cmdComprasAbono.TabIndex = 3
        Me.cmdComprasAbono.Text = "ABONOS A FACTURA"
        Me.cmdComprasAbono.UseWaitCursor = True
        Me.cmdComprasAbono.Visible = False
        '
        'Button4
        '
        Me.Button4.ImageOptions.Image = CType(resources.GetObject("Button4.ImageOptions.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(766, 319)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(248, 37)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "REPORTE DE TARJETAS"
        Me.Button4.UseWaitCursor = True
        Me.Button4.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(224, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(536, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 160
        Me.PictureBox1.TabStop = False
        '
        'Button8
        '
        Me.Button8.ImageOptions.Image = CType(resources.GetObject("Button8.ImageOptions.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(24, 198)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(248, 52)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "CONTABILIZAR I.V.A"
        Me.Button8.Visible = False
        '
        'Button7
        '
        Me.Button7.ImageOptions.Image = CType(resources.GetObject("Button7.ImageOptions.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(24, 267)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(248, 52)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "CONTABILIZAR I.R."
        Me.Button7.Visible = False
        '
        'Button6
        '
        Me.Button6.ImageOptions.Image = CType(resources.GetObject("Button6.ImageOptions.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(24, 138)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(248, 52)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "RECIBO EFECTIVO DE BANCO"
        Me.Button6.Visible = False
        '
        'Button10
        '
        Me.Button10.ImageOptions.Image = CType(resources.GetObject("Button10.ImageOptions.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(766, 144)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(248, 51)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "ALCALDIA"
        Me.Button10.UseWaitCursor = True
        Me.Button10.Visible = False
        '
        'frmComprobantesDiariosLista
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 470)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdComprasAbono)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbxAccion)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmComprobantesDiariosLista"
        Me.gbxAccion.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As frmComprobantesContadoLista = frmComprobantesContadoLista.Instance()
        f.Dispose()
        '        
        Dim fr As frmComprobantesContadoLista = frmComprobantesContadoLista.Instance()
        fr.MdiParent = Me.MdiParent
        fr.Text = "Contabilizar Ventas de Contado"
        fr.TipoFact = 1 ' Contado
        fr.lblTipo.Text = "FACTURAS DE CONTADO"
        fr.Show()
        fr.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim f As frmComprobantesContadoLista = frmComprobantesContadoLista.Instance()
        f.Dispose()
        '
        Dim fr As frmComprobantesContadoLista = frmComprobantesContadoLista.Instance
        fr.MdiParent = Me.MdiParent
        fr.Text = "Contabilizar Ventas de Credito"
        fr.TipoFact = 2 ' Credito
        fr.lblTipo.Text = "FACTURAS DE CREDITO"
        fr.Show()
        fr.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim fr As FrmIRFacturaContabilizado = fr.Instance
        fr.MdiParent = Me.MdiParent
        fr.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        'Dim fr As FrmIVAContabilizado = fr.Instance
        'fr.MdiParent = Me.MdiParent

        'fr.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim f As frmRecibos = frmRecibos.Instance()
        f.etInicio.Text = "1"
        f.Cliente = ""
        f.Recibo = ""
        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
        f.etInicio.Text = "0"
    End Sub

    Private Sub frmComprobantesDiariosLista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''    Me.Text = "Contabilizar"
        RolesDB.UsuarioAcciones(gbxAccion)
        RolesDB.UsuarioAcciones(GroupBox1)
        RolesDB.UsuarioAcciones(GroupBox2)
    End Sub

    Private Sub cmdDebitosCreditos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDebitosCreditos.Click
        Dim fr As frmCobrosNotasDebito = fr.Instance
        fr.MdiParent = Me.MdiParent
        fr.Show()
    End Sub

    Private Sub cmdComprasCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdComprasCredito.Click
        Dim plan As String
        Dim Plantilla As New VB.SysContab.PlantillaDB()

        plan = Plantilla.GetTipoPlantilla(2, 6).ToString

        If plan = "" Or plan Is DBNull.Value Then
            MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As frmFacturasComprasContabilizar = f.Instance
        f.lblTipoProv.Text = 0
        f.etPlantilla.Text = plan

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdComprasContado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdComprasContado.Click
        Dim plan As String
        Dim Plantilla As New VB.SysContab.PlantillaDB()

        'plan = Plantilla.GetTipoPlantilla(1, 6).ToString
        'plan = Plantilla.GetTipoPlantilla(2, 6).ToString
        plan = Plantilla.GetTipoPlantilla(4, 1).ToString

        '''If plan = "" Or plan Is DBNull.Value Then
        '''    MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
        '''    Exit Sub
        '''End If

        Dim f As frmFacturasComprasContadoContabilizar = f.Instance
        f.lblTipoProv.Text = 0
        f.etPlantilla.Text = plan

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdNomina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNomina.Click
        Dim f As FrmListaPlanillasContables = FrmListaPlanillasContables.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Planillas por Contabilizar"
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdActivoFijo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActivoFijo.Click
        Dim f As FrmActivoFijoContabilizar = FrmActivoFijoContabilizar.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.Text = "Contabilizar Activo Fijo"
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnAmortizaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmortizaciones.Click
        frmContabAmortiza.Dispose()
        frmContabAmortiza.MdiParent = Me.MdiParent
        frmContabAmortiza.Show()
        frmContabAmortiza.Text = "Contabilizar Amortizaciones"
        frmContabAmortiza.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub cmdComprasAbono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdComprasAbono.Click

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

    End Sub
End Class
