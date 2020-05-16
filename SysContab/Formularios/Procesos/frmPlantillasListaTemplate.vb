Public Class frmPlantillasListaTemplate
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmPlantillasListaTemplate = Nothing

    Public Shared Function Instance() As frmPlantillasListaTemplate
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPlantillasListaTemplate()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim Funcion As New VB.SysContab.FuncionesDB()
    Dim r As New VB.SysContab.RutinasNomina()
    Dim Plantilla As New VB.SysContab.PlantillaDB()
    Dim Tabla As New DataTable()
    Dim ds As New DataSet()
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GbProv As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GBNomina As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gbImpuestos As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl

    Public Particular As Boolean

#Region " Código generado por el Diseñador de Windows Forms "

    Private Sub New()
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
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdPlanilla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdIRPlanilla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdInss As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAlcaldia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdIR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdIva As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdProductos As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlantillasListaTemplate))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button8 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button6 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdProductos = New DevExpress.XtraEditors.SimpleButton()
        Me.Button5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdIR = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAlcaldia = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdIva = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdInss = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdIRPlanilla = New DevExpress.XtraEditors.SimpleButton()
        Me.Button12 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPlanilla = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GbProv = New DevExpress.XtraEditors.PanelControl()
        Me.GBNomina = New DevExpress.XtraEditors.PanelControl()
        Me.gbImpuestos = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GbProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbProv.SuspendLayout()
        CType(Me.GBNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBNomina.SuspendLayout()
        CType(Me.gbImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbImpuestos.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(774, 57)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(200, 57)
        Me.SimpleButton1.TabIndex = 156
        Me.SimpleButton1.Text = "INVENTARIO"
        Me.SimpleButton1.Visible = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(774, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(200, 57)
        Me.Button8.TabIndex = 155
        Me.Button8.Text = "SERVICIOS"
        Me.Button8.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 69)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(200, 54)
        Me.Button6.TabIndex = 153
        Me.Button6.Text = "SERVICIOS BASICOS"
        Me.Button6.Visible = False
        '
        'cmdProductos
        '
        Me.cmdProductos.Appearance.Options.UseTextOptions = True
        Me.cmdProductos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdProductos.Location = New System.Drawing.Point(6, 9)
        Me.cmdProductos.Name = "cmdProductos"
        Me.cmdProductos.Size = New System.Drawing.Size(200, 54)
        Me.cmdProductos.TabIndex = 154
        Me.cmdProductos.Text = "ORDENES DE PAGO/ FACTURAS DE COMPRA"
        '
        'Button5
        '
        Me.Button5.ImageOptions.Image = CType(resources.GetObject("Button5.ImageOptions.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(51, 208)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(240, 60)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "SALIR"
        '
        'Button4
        '
        Me.Button4.ImageOptions.Image = CType(resources.GetObject("Button4.ImageOptions.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(774, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 60)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "CLIENTES"
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.ImageOptions.Image = CType(resources.GetObject("Button3.ImageOptions.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(51, 142)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(240, 60)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "IMPUESTOS"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.ImageOptions.Image = CType(resources.GetObject("Button2.ImageOptions.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(51, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 60)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "NOMINA"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.ImageOptions.Image = CType(resources.GetObject("Button1.ImageOptions.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(51, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "PROVEEDORES "
        '
        'cmdIR
        '
        Me.cmdIR.Location = New System.Drawing.Point(7, 61)
        Me.cmdIR.Name = "cmdIR"
        Me.cmdIR.Size = New System.Drawing.Size(200, 54)
        Me.cmdIR.TabIndex = 162
        Me.cmdIR.Text = "RETENCIONES I.R."
        '
        'cmdAlcaldia
        '
        Me.cmdAlcaldia.Location = New System.Drawing.Point(7, 117)
        Me.cmdAlcaldia.Name = "cmdAlcaldia"
        Me.cmdAlcaldia.Size = New System.Drawing.Size(200, 54)
        Me.cmdAlcaldia.TabIndex = 157
        Me.cmdAlcaldia.Text = "ALCALDIA"
        '
        'cmdIva
        '
        Me.cmdIva.Location = New System.Drawing.Point(7, 4)
        Me.cmdIva.Name = "cmdIva"
        Me.cmdIva.Size = New System.Drawing.Size(200, 54)
        Me.cmdIva.TabIndex = 161
        Me.cmdIva.Text = "I.V.A"
        '
        'cmdInss
        '
        Me.cmdInss.ImageOptions.Image = CType(resources.GetObject("cmdInss.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdInss.Location = New System.Drawing.Point(7, 65)
        Me.cmdInss.Name = "cmdInss"
        Me.cmdInss.Size = New System.Drawing.Size(200, 54)
        Me.cmdInss.TabIndex = 158
        Me.cmdInss.Text = "SEGURIDAD SOCIAL"
        '
        'cmdIRPlanilla
        '
        Me.cmdIRPlanilla.ImageOptions.Image = CType(resources.GetObject("cmdIRPlanilla.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdIRPlanilla.Location = New System.Drawing.Point(7, 125)
        Me.cmdIRPlanilla.Name = "cmdIRPlanilla"
        Me.cmdIRPlanilla.Size = New System.Drawing.Size(200, 54)
        Me.cmdIRPlanilla.TabIndex = 157
        Me.cmdIRPlanilla.Text = "I.R."
        '
        'Button12
        '
        Me.Button12.ImageOptions.Image = CType(resources.GetObject("Button12.ImageOptions.Image"), System.Drawing.Image)
        Me.Button12.Location = New System.Drawing.Point(7, 185)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(200, 54)
        Me.Button12.TabIndex = 161
        Me.Button12.Text = "INATEC"
        '
        'cmdPlanilla
        '
        Me.cmdPlanilla.ImageOptions.Image = CType(resources.GetObject("cmdPlanilla.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdPlanilla.Location = New System.Drawing.Point(7, 5)
        Me.cmdPlanilla.Name = "cmdPlanilla"
        Me.cmdPlanilla.Size = New System.Drawing.Size(200, 54)
        Me.cmdPlanilla.TabIndex = 159
        Me.cmdPlanilla.Text = "PLANILLA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(200, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(568, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 159
        Me.PictureBox1.TabStop = False
        '
        'GbProv
        '
        Me.GbProv.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GbProv.Controls.Add(Me.cmdProductos)
        Me.GbProv.Controls.Add(Me.Button6)
        Me.GbProv.Location = New System.Drawing.Point(291, 5)
        Me.GbProv.Name = "GbProv"
        Me.GbProv.Size = New System.Drawing.Size(212, 68)
        Me.GbProv.TabIndex = 163
        Me.GbProv.Visible = False
        '
        'GBNomina
        '
        Me.GBNomina.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GBNomina.Controls.Add(Me.cmdIRPlanilla)
        Me.GBNomina.Controls.Add(Me.cmdInss)
        Me.GBNomina.Controls.Add(Me.cmdPlanilla)
        Me.GBNomina.Controls.Add(Me.Button12)
        Me.GBNomina.Location = New System.Drawing.Point(291, 74)
        Me.GBNomina.Name = "GBNomina"
        Me.GBNomina.Size = New System.Drawing.Size(212, 244)
        Me.GBNomina.TabIndex = 163
        Me.GBNomina.Visible = False
        '
        'gbImpuestos
        '
        Me.gbImpuestos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.gbImpuestos.Controls.Add(Me.cmdAlcaldia)
        Me.gbImpuestos.Controls.Add(Me.cmdIR)
        Me.gbImpuestos.Controls.Add(Me.cmdIva)
        Me.gbImpuestos.Location = New System.Drawing.Point(291, 138)
        Me.gbImpuestos.Name = "gbImpuestos"
        Me.gbImpuestos.Size = New System.Drawing.Size(212, 180)
        Me.gbImpuestos.TabIndex = 163
        Me.gbImpuestos.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GbProv)
        Me.PanelControl1.Controls.Add(Me.Button1)
        Me.PanelControl1.Controls.Add(Me.Button5)
        Me.PanelControl1.Controls.Add(Me.Button3)
        Me.PanelControl1.Controls.Add(Me.GBNomina)
        Me.PanelControl1.Controls.Add(Me.Button2)
        Me.PanelControl1.Controls.Add(Me.gbImpuestos)
        Me.PanelControl1.Location = New System.Drawing.Point(200, 156)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(568, 335)
        Me.PanelControl1.TabIndex = 160
        '
        'frmPlantillasListaTemplate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 505)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button8)
        Me.Name = "frmPlantillasListaTemplate"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GbProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbProv.ResumeLayout(False)
        CType(Me.GBNomina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBNomina.ResumeLayout(False)
        CType(Me.gbImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbImpuestos.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPlantillasLista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(PanelControl1)
        ''
        Me.Text = "Efectuar Pagos"

        If Particular = True Then
            Me.Button2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False
        End If
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'gbxAccion.Visible = False
        'gbxCmd.Visible = True
        'dgZonas.Visible = True
        'dgZonas.CaptionText = "Información de Plantillas"

        'Me.Text = "Mantenimiento de Plantillas"
        'Me.Refresh()
        GbProv.Visible = True
        GBNomina.Visible = False
        gbImpuestos.Visible = False

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim f As DataGridTextBox.frmComprobanteTipo1 = f.Instance
        'Dim zonas As New VB.SysContab.ZonasDB()

        'If Registro = "Vacio" Then
        '    MsgBox("Seleccione la Plantilla que desea Abrir", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'f.MdiParent = Me.MdiParent
        'f.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        'Dim f As frmPlantillasPagoProveedores = frmPlantillasPagoProveedores.Instance()

        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized

        'Exit Sub

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GbProv.Visible = False
        GBNomina.Visible = True
        gbImpuestos.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        GbProv.Visible = False
        GBNomina.Visible = False
        gbImpuestos.Visible = True

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GbProv.Visible = False
        GBNomina.Visible = False
        gbImpuestos.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProductos.Click
        'Dim plan As String
        Dim Plantilla As New VB.SysContab.PlantillaDB()

        RegistroPlantilla = Plantilla.GetTipoPlantilla(10, 8).ToString

        If RegistroPlantilla = "" Or RegistroPlantilla Is DBNull.Value Then
            XtraMsg("No hay plantilla Disponible para realizar esta Transacción", MessageBoxIcon.Error)
            Exit Sub
        End If

        ShowSplash()
        ''
        Dim f As frmListaFacturaProveedoresPlan = frmListaFacturaProveedoresPlan.Instance()
        f.etInicio.Text = "0"
        f.lblTipoProv.Text = 0

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized        
        f.etInicio.Text = "1"
        ''
        HideSplash()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim Plantilla As New VB.SysContab.PlantillaDB

        RegistroPlantilla = Plantilla.GetTipoPlantilla(1, 10).ToString

        If RegistroPlantilla = "" Or RegistroPlantilla Is DBNull.Value Then
            MsgBox("No hay plantilla Disponible para realizar esta Transacción", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As frmListaFacturaProveedoresPlan = frmListaFacturaProveedoresPlan.Instance()
        f.etInicio.Text = "0"
        f.lblTipoProv.Text = 1

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "1"

        'Dim f As frmListaFacturaProveedores = f.Instance
        'RegistroPlantilla = Plantilla.GetTipoPlantilla(1, 1)

        'f.lblTipoProv.Text = 1
        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.WindowState = FormWindowState.Maximized
        'Exit Sub
    End Sub


    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIva.Click
        Dim plan As String
        Dim Plantilla As New VB.SysContab.PlantillaDB()

        plan = Plantilla.GetTipoPlantilla(1, 3).ToString

        If plan = "" Or plan Is DBNull.Value Then
            MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
        ds = Detalles.Detalles

        'Dim f As frmReporteIVA = f.Instance
        'f.etPlantilla.Text = plan
        Dim f As FrmReporteIVAVew = FrmReporteIVAVew.Instance()
        f.Plantilla = plan
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIR.Click
        Dim plan As String
        Dim Plantilla As New VB.SysContab.PlantillaDB()

        plan = Plantilla.GetTipoPlantilla(2, 3).ToString

        If plan = "" Or plan Is DBNull.Value Then
            MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
        ds = Detalles.Detalles

        Dim f As frmIRxFactura = frmIRxFactura.Instance()
        f.etPlantilla.Text = plan
        f.etCuentaIRProfesional.Text = ds.Tables("PlantillasDetalles").Rows(2).Item("Cuenta").ToString
        f.etCuentaIRResidente.Text = ds.Tables("PlantillasDetalles").Rows(3).Item("Cuenta").ToString

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdPlanilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlanilla.Click
        Dim f As frmPlanillasPagar = frmPlanillasPagar.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim f As frmInatecPagar = frmInatecPagar.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdIRPlanilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIRPlanilla.Click
        Dim f As frmIRPagar = frmIRPagar.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdInss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInss.Click
        Dim f As frmInssPagar = frmInssPagar.Instance()
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdAlcaldia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlcaldia.Click
        Dim plan As String
        Dim Plantilla As New VB.SysContab.PlantillaDB()

        plan = Plantilla.GetTipoPlantilla(4, 3).ToString

        If plan = "" Or plan Is DBNull.Value Then
            MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
        ds = Detalles.Detalles

        Dim f As frmAlcaldia = frmAlcaldia.Instance()
        f.etPlantilla.Text = plan
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'Facturas de Consumo Interno.
        Dim Plantilla As New VB.SysContab.PlantillaDB()

        RegistroPlantilla = Plantilla.GetTipoPlantilla(10, 8).ToString

        If RegistroPlantilla = "" Or RegistroPlantilla Is DBNull.Value Then
            MsgBox("No hay plantilla disponible para realizar esta transacción", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As frmListaFacturaProveedoresPlan = frmListaFacturaProveedoresPlan.Instance()
        f.etInicio.Text = "0"
        f.lblTipoProv.Text = 4

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "1"
    End Sub
End Class
