

Public Class frmReportePresupuesto
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReportePresupuesto = Nothing
    Private i As Integer
    Private Empresa As New VB.SysContab.EmpresasDetails()
    Private Empresas As New VB.SysContab.EmpresasDB()
    Public Pres As New VB.SysContab.PresupuestoDB()
    Public Presupuesto As String
    Public Periodo As Integer
    Public cuenta As String

    Public Shared Function Instance() As frmReportePresupuesto
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportePresupuesto()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbCatalogo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbPeriodos As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbCatalogo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbPeriodos = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCatalogo
        '
        Me.cbCatalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo.Location = New System.Drawing.Point(120, 26)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Size = New System.Drawing.Size(416, 23)
        Me.cbCatalogo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 26)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Cuenta:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbCatalogo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 95)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbPeriodos)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(552, 103)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'cbPeriodos
        '
        Me.cbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPeriodos.Enabled = False
        Me.cbPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodos.Location = New System.Drawing.Point(120, 26)
        Me.cbPeriodos.Name = "cbPeriodos"
        Me.cbPeriodos.Size = New System.Drawing.Size(416, 23)
        Me.cbPeriodos.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 26)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Periodos:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdSalir)
        Me.GroupBox6.Controls.Add(Me.cmdImprimir)
        Me.GroupBox6.Location = New System.Drawing.Point(584, 17)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(112, 267)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(16, 60)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 26)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(16, 26)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(80, 26)
        Me.cmdImprimir.TabIndex = 0
        Me.cmdImprimir.Text = "Imprimir"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.cbMonedaCambio)
        Me.GroupBox8.Location = New System.Drawing.Point(24, 215)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(552, 69)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 26)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Moneda:"
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Location = New System.Drawing.Point(120, 26)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Size = New System.Drawing.Size(416, 23)
        Me.cbMonedaCambio.TabIndex = 0
        '
        'frmReportePresupuesto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(704, 298)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmReportePresupuesto"
        Me.Text = "Reportes - Presupuesto"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReportePresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Catalogo As New VB.SysContab.CatalogoDB()
        Dim Periodos As New VB.SysContab.PeriodosDB()
        Dim TComprobantes As New VB.SysContab.ComprobanteDB()
        Dim r As New VB.SysContab.RutinasNomina()
        Dim Tasa As New VB.SysContab.Tasa_CambioDB()

        'r.CambiarEstilo(Me)
        i = 0

        cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        cbMonedaCambio.ValueMember = "MonedaCambio"
        cbMonedaCambio.DisplayMember = "Nombre"

        cbCatalogo.DataSource = Pres.GetList_CuentasPresupuesto_Combo().Tables("Presupuesto")
        cbCatalogo.ValueMember = "cuenta"
        cbCatalogo.DisplayMember = "concepto"

        cbPeriodos.DataSource = Periodos.GetList().Tables("Periodos")
        cbPeriodos.ValueMember = "codigo"
        cbPeriodos.DisplayMember = "descripcion"

        Me.cbPeriodos.SelectedValue = Me.Periodo
        Me.cbCatalogo.SelectedValue = Me.cuenta

    End Sub

    Private Sub cbPeriodos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPeriodos.SelectedValueChanged
        'Dim Per_Detail As New VB.SysContab.PeriodoDetails()
        'Dim Periodo As New VB.SysContab.PeriodosDB()
        'Dim tipo As Type
        'tipo = Me.cbPeriodos.SelectedValue.GetType

        'If tipo.FullName = "System.Data.DataRowView" Then

        '    Exit Sub
        'Else
        '    Per_Detail = Periodo.GetDetails(Me.cbPeriodos.SelectedValue)
        '    If Per_Detail.ID Is Nothing Or Per_Detail.ID = 0 Then

        '        ' MsgBox("No existe el código de Periodo Fiscal seleccionado", MsgBoxStyle.Critical)
        '        Exit Sub
        '    Else
        '        If Per_Detail.Inicio < Me.dtpDesde.MinDate Then

        '            Me.dtpDesde.MinDate = Per_Detail.Inicio.Date
        '            Me.dtpDesde.MaxDate = Per_Detail.Final.Date
        '            Me.dtpDesde.Value = Per_Detail.Inicio.Date

        '            Me.dtpHasta.MinDate = Per_Detail.Inicio.Date
        '            Me.dtpHasta.MaxDate = Per_Detail.Final.Date
        '            Me.dtpHasta.Value = Per_Detail.Final.Date
        '        Else
        '            Me.dtpDesde.MaxDate = Per_Detail.Final.Date
        '            Me.dtpDesde.MinDate = Per_Detail.Inicio.Date
        '            Me.dtpDesde.Value = Per_Detail.Inicio.Date

        '            Me.dtpHasta.MaxDate = Per_Detail.Final.Date
        '            Me.dtpHasta.MinDate = Per_Detail.Inicio.Date
        '            Me.dtpHasta.Value = Per_Detail.Final.Date
        '        End If
        '    End If

        'End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes()
        Dim Presupuesto As New VB.SysContab.PresupuestoDB()
        Dim r As New VB.SysContab.RutinasNomina()
        'Dim reporte As New rptPresupuesto()

        Dim reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        reporte.Load(Application.StartupPath & "\Reportes\rptPresupuesto.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        Dim lds As New DataSet
        lds = Presupuesto.GetListReporte(Me.Presupuesto, Me.cbMonedaCambio.SelectedValue, Me.cbCatalogo.SelectedValue)
        lds.WriteXml(Application.StartupPath & "\xml\rptPresupuesto.xml", XmlWriteMode.WriteSchema)

        'reporte.SetDataSource(Presupuesto.GetListReporte(Me.Presupuesto, Me.cbMonedaCambio.SelectedValue, Me.cbCatalogo.SelectedValue))
        reporte.Database.Tables(0).Location = Application.StartupPath & "\xml\rptPresupuesto.xml"
        fReportes.crvReportes.ReportSource = reporte
        freportes.Show()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class
