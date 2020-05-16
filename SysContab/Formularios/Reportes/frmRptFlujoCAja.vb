Imports System.Data.SqlClient
Public Class frmRptFlujoCAja
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmRptFlujoCAja = Nothing
    Private i As Integer


    Dim Periodos As New VB.SysContab.PeriodosDB()
    Dim Libros As New VB.SysContab.LibrosDB()
    Dim r As New VB.SysContab.Rutinas()
    Private Empresa As New VB.SysContab.EmpresasDetails()
    Private Empresas As New VB.SysContab.EmpresasDB()

    Public Shared Function Instance() As frmRptFlujoCAja
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmRptFlujoCAja()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbPeriodos As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GBRango As System.Windows.Forms.GroupBox
    Friend WithEvents GBMes As System.Windows.Forms.GroupBox
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkMes As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRango As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chkMes = New System.Windows.Forms.CheckBox()
        Me.ChkRango = New System.Windows.Forms.CheckBox()
        Me.cbPeriodos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GBMes = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.GBRango = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GBMes.SuspendLayout()
        Me.GBRango.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(88, 17)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(104, 20)
        Me.dtpDesde.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(88, 43)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(104, 20)
        Me.dtpHasta.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.cbPeriodos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.GBMes)
        Me.GroupBox1.Controls.Add(Me.GBRango)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 155)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chkMes)
        Me.GroupBox8.Controls.Add(Me.ChkRango)
        Me.GroupBox8.Location = New System.Drawing.Point(16, 52)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(200, 94)
        Me.GroupBox8.TabIndex = 14
        Me.GroupBox8.TabStop = False
        '
        'chkMes
        '
        Me.chkMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkMes.Location = New System.Drawing.Point(16, 43)
        Me.chkMes.Name = "chkMes"
        Me.chkMes.Size = New System.Drawing.Size(96, 26)
        Me.chkMes.TabIndex = 1
        Me.chkMes.Text = "Mes"
        '
        'ChkRango
        '
        Me.ChkRango.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRango.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRango.Location = New System.Drawing.Point(16, 17)
        Me.ChkRango.Name = "ChkRango"
        Me.ChkRango.Size = New System.Drawing.Size(152, 26)
        Me.ChkRango.TabIndex = 0
        Me.ChkRango.Text = "Rango de Fechas"
        '
        'cbPeriodos
        '
        Me.cbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodos.Location = New System.Drawing.Point(88, 17)
        Me.cbPeriodos.Name = "cbPeriodos"
        Me.cbPeriodos.Size = New System.Drawing.Size(424, 23)
        Me.cbPeriodos.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 26)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Periodos:"
        '
        'GBMes
        '
        Me.GBMes.Controls.Add(Me.Label7)
        Me.GBMes.Controls.Add(Me.cbMes)
        Me.GBMes.Location = New System.Drawing.Point(224, 52)
        Me.GBMes.Name = "GBMes"
        Me.GBMes.Size = New System.Drawing.Size(288, 94)
        Me.GBMes.TabIndex = 16
        Me.GBMes.TabStop = False
        Me.GBMes.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 26)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Mes:"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.Location = New System.Drawing.Point(80, 43)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(192, 23)
        Me.cbMes.TabIndex = 1
        '
        'GBRango
        '
        Me.GBRango.Controls.Add(Me.dtpDesde)
        Me.GBRango.Controls.Add(Me.Label1)
        Me.GBRango.Controls.Add(Me.Label2)
        Me.GBRango.Controls.Add(Me.dtpHasta)
        Me.GBRango.Location = New System.Drawing.Point(224, 52)
        Me.GBRango.Name = "GBRango"
        Me.GBRango.Size = New System.Drawing.Size(288, 94)
        Me.GBRango.TabIndex = 15
        Me.GBRango.TabStop = False
        Me.GBRango.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdSalir)
        Me.GroupBox6.Controls.Add(Me.cmdImprimir)
        Me.GroupBox6.Location = New System.Drawing.Point(560, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(112, 224)
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
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cbMonedaCambio)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(520, 61)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(16, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 26)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Moneda:"
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Location = New System.Drawing.Point(104, 26)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Size = New System.Drawing.Size(392, 23)
        Me.cbMonedaCambio.TabIndex = 0
        '
        'frmRptFlujoCAja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(688, 229)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRptFlujoCAja"
        Me.Text = "Reportes - Flujo de Caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GBMes.ResumeLayout(False)
        Me.GBRango.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Per_Detail As New VB.SysContab.PeriodoDetails()

    Private Sub frmLibroEstadoSituacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Tasa As New VB.SysContab.Tasa_CambioDB()

        'r.CambiarEstilo(Me)
        i = 0

        cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        cbMonedaCambio.ValueMember = "MonedaCambio"
        cbMonedaCambio.DisplayMember = "Nombre"

        cbPeriodos.DataSource = Periodos.GetList().Tables("Periodos")
        cbPeriodos.ValueMember = "codigo"
        cbPeriodos.DisplayMember = "descripcion"

        Me.cbMonedaCambio.SelectedValue = MonedaBase

        Me.chkMes.Checked = True

        Dim Periodo
        Periodo = VB.SysContab.PeriodosDB.Actual
        If Periodo <> 0 Then
            Me.cbPeriodos.SelectedValue = Periodo
            Per_Detail = Periodos.GetDetails(Me.cbPeriodos.SelectedValue)
            If Per_Detail.Inicio.Year = CDate(r.Fecha).Year And Per_Detail.Inicio.Month <= CDate(r.Fecha).Month Then
                Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
            ElseIf Per_Detail.Final.Year = CDate(r.Fecha).Year And Per_Detail.Final.Month >= CDate(r.Fecha).Month Then
                Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
            Else
                Me.cbMes.SelectedItem = Format(Per_Detail.Inicio, "yyyy") & "-" & Format(Per_Detail.Inicio, "MM")
            End If
        End If


    End Sub


    Private Sub cbPeriodos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPeriodos.SelectedValueChanged
        Dim tipo As Type
        tipo = Me.cbPeriodos.SelectedValue.GetType

        If tipo.FullName = "System.Data.DataRowView" Then
            Exit Sub
        Else
            'Llenar los datos del groupbox con el rango de fechas
            Per_Detail = Periodos.GetDetails(Me.cbPeriodos.SelectedValue)
            If Per_Detail.ID Is Nothing Or Per_Detail.ID = 0 Then
                ' MsgBox("No existe el código de Periodo Fiscal seleccionado", MsgBoxStyle.Critical)
                Exit Sub
            Else
                If Per_Detail.Inicio < Me.dtpDesde.MinDate Then

                    Me.dtpDesde.MinDate = Per_Detail.Inicio.Date
                    Me.dtpDesde.MaxDate = Per_Detail.Final.Date
                    Me.dtpDesde.Value = Per_Detail.Inicio.Date

                    Me.dtpHasta.MinDate = Per_Detail.Inicio.Date
                    Me.dtpHasta.MaxDate = Per_Detail.Final.Date
                    Me.dtpHasta.Value = Per_Detail.Final.Date
                Else
                    Me.dtpDesde.MaxDate = Per_Detail.Final.Date
                    Me.dtpDesde.MinDate = Per_Detail.Inicio.Date
                    Me.dtpDesde.Value = Per_Detail.Inicio.Date

                    Me.dtpHasta.MaxDate = Per_Detail.Final.Date
                    Me.dtpHasta.MinDate = Per_Detail.Inicio.Date
                    Me.dtpHasta.Value = Per_Detail.Final.Date
                End If
            End If
            'Llenar los datos de los meses del periodo
            Dim anio, aniofinal, i As Integer
            anio = Format(Per_Detail.Inicio, "yyyy") + Format(Per_Detail.Inicio, "MM")
            aniofinal = Format(Per_Detail.Final, "yyyy") + Format(Per_Detail.Final, "MM")
            i = 1
            Me.cbMes.Items.Clear()
            Do While anio <= aniofinal
                Me.cbMes.Items.Add(Microsoft.VisualBasic.Left(anio, 4) & "-" & Format(DateAdd(DateInterval.Month, i - 1, Per_Detail.Inicio), "MM")) 'Format(DateAdd(DateInterval.Month, i - 1, Per_Detail.Inicio), "MMMM")
                anio = Format(DateAdd(DateInterval.Month, i, Per_Detail.Inicio), "yyyy") + Format(DateAdd(DateInterval.Month, i, Per_Detail.Inicio), "MM")
                i = i + 1
            Loop
            'Me.cbMes.SelectedItem = Format(Per_Detail.Inicio, "yyyy") & "-" & Format(Per_Detail.Inicio, "MM")
            If Per_Detail.Inicio.Year = CDate(r.Fecha).Year And Per_Detail.Inicio.Month <= CDate(r.Fecha).Month Then
                Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
            ElseIf Per_Detail.Final.Year = CDate(r.Fecha).Year And Per_Detail.Final.Month >= CDate(r.Fecha).Month Then
                Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
            Else
                Me.cbMes.SelectedItem = Format(Per_Detail.Inicio, "yyyy") & "-" & Format(Per_Detail.Inicio, "MM")
            End If
            If Me.GBMes.Visible = True Then
                'Me.dtpDesde.Value = CDate("01/" & Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) & "/" & Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4))
                'Me.dtpHasta.Value = CDate(Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) - 1)) & "/" & Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) & "/" & Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4))
                Me.dtpDesde.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), 1)
                Me.dtpHasta.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) - 1)))

            End If

        End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes()
        'Dim Reporte As New rptflujoCaja()

        Dim ds As New DataSet
        Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Reporte.Load(Application.StartupPath & "\Reportes\rptflujoCaja.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
        '
        Dim Libros As New VB.SysContab.LibrosDB
        ds = Libros.Imprimir_FlujoCaja(Me.dtpDesde.Value.Date, Me.dtpHasta.Value.Date, _
                                       Me.cbPeriodos.SelectedValue, Me.cbMonedaCambio.SelectedValue)

        ds.WriteXml(Application.StartupPath & "\xml\rFlujoCaja.xml", XmlWriteMode.WriteSchema)


        Reporte.Database.Tables("_GetFlujoCaja").Location = Application.StartupPath & "\xml\rFlujoCaja.xml"
        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
        fReportes.crvReportes.ReportSource = Reporte
        fReportes.ShowDialog()

        
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub




    Private Sub chkMes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMes.CheckedChanged
        If Me.chkMes.Checked Then
            Me.GBMes.Visible = True
            Me.GBRango.Visible = False
            Me.ChkRango.Checked = False
        Else
            Me.GBMes.Visible = False
            Me.GBRango.Visible = True
            Me.ChkRango.Checked = True
        End If
    End Sub

    Private Sub ChkRango_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkRango.CheckedChanged
        If Me.ChkRango.Checked Then
            Me.GBMes.Visible = False
            Me.GBRango.Visible = True
            Me.chkMes.Checked = False
        Else
            Me.GBMes.Visible = True
            Me.GBRango.Visible = False
            Me.chkMes.Checked = True
        End If
    End Sub


    Private Sub cbMes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMes.SelectedIndexChanged
        'Me.dtpDesde.Value = CDate("01/" & Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) & "/" & Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4))
        'Me.dtpHasta.Value = CDate(Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) - 1)) & "/" & Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) & "/" & Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4))
        Me.dtpDesde.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), 1)
        Me.dtpHasta.Value = New DateTime(Microsoft.VisualBasic.Left(Me.cbMes.SelectedItem, 4), Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2), Str(Meses(Microsoft.VisualBasic.Right(Me.cbMes.SelectedItem, 2) - 1)))

    End Sub




End Class
