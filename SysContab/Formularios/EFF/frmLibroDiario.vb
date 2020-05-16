Imports DevExpress.XtraReports.UI

Public Class frmLibroDiario
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmLibroDiario = Nothing
    Private Empresa As New VB.SysContab.EmpresasDetails
    Private Empresas As New VB.SysContab.EmpresasDB()
    

    Public Shared Function Instance() As frmLibroDiario
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmLibroDiario()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
    Dim Fechas As VB.SysContab.FechasdeOperacion

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbTComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtChk As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimirDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConsolidado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbCBanco As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbCBanco = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbTComprobante = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtChk = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnConsolidado = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImprimirDetail = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.cbCBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(120, 86)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(112, 20)
        Me.dtpDesde.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(336, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(432, 86)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(104, 20)
        Me.dtpHasta.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpHasta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTitulo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbMonedaCambio)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 120)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(120, 26)
        Me.txtTitulo.MaxLength = 50
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(416, 21)
        Me.txtTitulo.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(16, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Título:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 26)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Moneda:"
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Location = New System.Drawing.Point(120, 52)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Size = New System.Drawing.Size(416, 23)
        Me.cbMonedaCambio.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.cbCBanco)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cbTComprobante)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 129)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(552, 85)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'cbCBanco
        '
        Me.cbCBanco.Location = New System.Drawing.Point(120, 55)
        Me.cbCBanco.Name = "cbCBanco"
        Me.cbCBanco.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCBanco.Properties.Appearance.Options.UseFont = True
        Me.cbCBanco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCBanco.Properties.PopupFormMinSize = New System.Drawing.Size(700, 0)
        Me.cbCBanco.Properties.ShowFooter = False
        Me.cbCBanco.Size = New System.Drawing.Size(416, 20)
        Me.cbCBanco.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(4, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Cuenta Banco:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(10, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 35)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tipos Comprobantes:"
        '
        'cbTComprobante
        '
        Me.cbTComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTComprobante.Location = New System.Drawing.Point(120, 26)
        Me.cbTComprobante.Name = "cbTComprobante"
        Me.cbTComprobante.Size = New System.Drawing.Size(416, 23)
        Me.cbTComprobante.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtConcepto)
        Me.GroupBox5.Controls.Add(Me.txtDocumento)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txtChk)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(24, 220)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(552, 150)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(36, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Concepto:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(127, 50)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(409, 86)
        Me.txtConcepto.TabIndex = 16
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(127, 17)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(112, 21)
        Me.txtDocumento.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Comprobante:"
        '
        'txtChk
        '
        Me.txtChk.Location = New System.Drawing.Point(424, 17)
        Me.txtChk.Name = "txtChk"
        Me.txtChk.Size = New System.Drawing.Size(112, 21)
        Me.txtChk.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(353, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cheque:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnConsolidado)
        Me.GroupBox6.Controls.Add(Me.btnImprimirDetail)
        Me.GroupBox6.Controls.Add(Me.cmdSalir)
        Me.GroupBox6.Controls.Add(Me.cmdImprimir)
        Me.GroupBox6.Location = New System.Drawing.Point(584, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(136, 361)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        '
        'btnConsolidado
        '
        Me.btnConsolidado.Appearance.Options.UseTextOptions = True
        Me.btnConsolidado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnConsolidado.Location = New System.Drawing.Point(16, 98)
        Me.btnConsolidado.Name = "btnConsolidado"
        Me.btnConsolidado.Size = New System.Drawing.Size(104, 34)
        Me.btnConsolidado.TabIndex = 3
        Me.btnConsolidado.Text = "Imprimir Consolidado"
        Me.btnConsolidado.Visible = False
        '
        'btnImprimirDetail
        '
        Me.btnImprimirDetail.Location = New System.Drawing.Point(16, 58)
        Me.btnImprimirDetail.Name = "btnImprimirDetail"
        Me.btnImprimirDetail.Size = New System.Drawing.Size(104, 34)
        Me.btnImprimirDetail.TabIndex = 2
        Me.btnImprimirDetail.Text = "Imprimir Detallado"
        Me.btnImprimirDetail.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(16, 138)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(104, 35)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(16, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(104, 35)
        Me.cmdImprimir.TabIndex = 0
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'frmLibroDiario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(736, 377)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLibroDiario"
        Me.Text = "Reportes - Libro Diario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.cbCBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmLibroDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Catalogo As New VB.SysContab.CatalogoDB()
        Dim Periodos As New VB.SysContab.PeriodosDB()
        Dim TComprobantes As New VB.SysContab.ComprobanteDB()
        Dim Tasa As New VB.SysContab.Tasa_CambioDB

        cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        cbMonedaCambio.ValueMember = "MonedaCambio"
        cbMonedaCambio.DisplayMember = "Nombre"

        cbTComprobante.DataSource = TComprobantes.GetTiposComprobantes().Tables("TipoComprobantes")
        cbTComprobante.ValueMember = "TipComp_Id"
        cbTComprobante.DisplayMember = "TipComp_Nombre"

        Me.cbCBanco.Properties.DataSource = ObtieneDatos("SP_GetCatalogoBancos_V2 " & EmpresaActual)
        Me.cbCBanco.Properties.ValueMember = "Cuenta"
        Me.cbCBanco.Properties.DisplayMember = "Nombre"
        Me.cbCBanco.Properties.PopulateColumns()
        Me.cbCBanco.Properties.Columns("Codigo").Visible = False

        Me.cbCBanco.ItemIndex = 0
        Me.cbMonedaCambio.SelectedValue = MonedaBase
    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        ShowSplash("Imprimiendo Reporte...")

        'Dim dtl As VB.SysContab.EmpresasDetails = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)

        Dim rpt As New rptLibroDiario
        rpt.DataSource = Me.BuscarDatos()
        rpt.txtEmpresa.Text = NombreEmpresaActual
        rpt.txtTitulo.Text = "Libro Diario"
        rpt.lblConcepto.Text = "Concepto: " & txtConcepto.Text
        ' rpt.lblNumero.Text = txtNumero.Text        
        rpt.ShowRibbonPreview()

        HideSplash()


        'Dim fReportes As New frmReportes
        'Dim Libros As New VB.SysContab.LibrosDB
        'Dim r As New VB.SysContab.RutinasNomina
        ''Dim rColilla As New rptLibroDiario

        'Empresa = Empresas.GetDetails(EmpresaActual)
        ''Dim Reporte As New rptLibroDiario
        ''
        'Dim reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'reporte.Load(Application.StartupPath & "\Reportes\rptLibroDiario.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        ''
        'Dim Ds As New DataSet
        'Ds = Libros.Imprimir_LibroDiario(Me.dtpDesde.Value, Me.dtpHasta.Value, "%", _
        '                    0, Me.cbTComprobante.SelectedValue, _
        '                    Me.txtDocumento.Text, Me.txtChk.Text, Login, Me.txtTitulo.Text, _
        '                    Empresa.MonedaBase, Me.cbMonedaCambio.SelectedValue, False)

        'Ds.WriteXml(Application.StartupPath & "\xml\rptLibroDiario.xml", XmlWriteMode.WriteSchema)
        'Reporte.Database.Tables(0).Location = Application.StartupPath & "\xml\rptLibroDiario.xml"
        'fReportes.crvReportes.ReportSource = Reporte
        'fReportes.crvReportes.Zoom(91)
        'fReportes.Show()
    End Sub

    Private Function BuscarDatos() As DataTable
        Dim v As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion)
        v.AddParameter("empresa", SqlDbType.NVarChar, 50, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("desde", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, dtpDesde.Value.Date)
        v.AddParameter("hasta", SqlDbType.SmallDateTime, 5, ParameterDirection.Input, dtpHasta.Value.Date)
        v.AddParameter("moneda", SqlDbType.NVarChar, 5, ParameterDirection.Input, cbMonedaCambio.SelectedValue)

        Try
            Return v.EjecutarComando("JAR_LibroDiario", "Tabla")
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirDetail.Click
        Dim Libros As New VB.SysContab.LibrosDB

        Empresa = Empresas.GetDetails(EmpresaActual)

        'Dim Reporte As New rptLibroDiario
        Dim Ds As New DataSet

        Dim reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        reporte.Load(Application.StartupPath & "\Reportes\rptLibroDiario.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        '
        Ds = Libros.Imprimir_LibroDiario_V2(Me.dtpDesde.Value.Date, Me.dtpHasta.Value.Date, "%", _
                             0, Me.cbTComprobante.SelectedValue, _
                            Me.txtDocumento.Text, Me.txtChk.Text, Login, Me.txtTitulo.Text, _
                            Empresa.MonedaBase, Me.cbMonedaCambio.SelectedValue, False)

        If Ds.Tables(0).Rows.Count = 0 Then
            MsgBox("La Cosulta no ha devuleto Ningún Resultado para los Parametros de Busqueda Seleccionados", MsgBoxStyle.Information)
            Exit Sub
        End If

        Ds.WriteXml(Application.StartupPath & "\xml\rptLibroDiario.xml", XmlWriteMode.WriteSchema)
        Dim rpt As New rptReporteDiariosDetallado

        rpt.XmlDataPath = Application.StartupPath & "\xml\rptLibroDiario.xml"

        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        rpt.ShowRibbonPreview()
    End Sub

    Private Sub btnConsolidado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsolidado.Click
        Dim Libros As New VB.SysContab.LibrosDB

        Empresa = Empresas.GetDetails(EmpresaActual)

        'Dim Reporte As New rptLibroDiario
        Dim Ds As New DataSet
        Dim reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        reporte.Load(Application.StartupPath & "\Reportes\rptLibroDiario.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        '
        Ds = Libros.Imprimir_LibroDiarioConsolidado_V2(Me.dtpDesde.Value.Date, Me.dtpHasta.Value.Date, _
                               Me.cbTComprobante.SelectedValue, Me.cbCBanco.EditValue, Me.txtDocumento.Text, Me.txtChk.Text, Login, Me.txtTitulo.Text, _
                              Empresa.MonedaBase, Me.cbMonedaCambio.SelectedValue, Me.txtConcepto.Text)


        If Ds.Tables(0).Rows.Count = 0 Then
            MsgBox("La Cosulta no ha devuleto Ningún Resultado para los Parametros de Busqueda Seleccionados", MsgBoxStyle.Information)
            Exit Sub
        End If

        Ds.WriteXml(Application.StartupPath & "\xml\rptLibroDiarioConsolidado.xml", XmlWriteMode.WriteSchema)
        Dim rpt As New rptReporteDiariosConsolidado

        rpt.XmlDataPath = Application.StartupPath & "\xml\rptLibroDiarioConsolidado.xml"

        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        rpt.ShowRibbonPreview()
    End Sub
End Class
