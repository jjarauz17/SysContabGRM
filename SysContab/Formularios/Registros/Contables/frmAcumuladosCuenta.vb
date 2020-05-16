Public Class frmAcumuladosCuenta
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAcumuladosCuenta = Nothing

    Public Shared Function Instance() As frmAcumuladosCuenta
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAcumuladosCuenta()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
    Dim Fechas As New VB.SysContab.FechasdeTrabajo
    Dim CatalogoAcumulados As New VB.SysContab.CatalogoDB
    Dim r As New VB.SysContab.Rutinas
    Dim Detalles As New VB.SysContab.CatalogoDetails
    Dim Tabla As DataTable
    Dim ds As DataSet

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
    Friend WithEvents dgCatalogoAcumulados As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOcultarGrafico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbGrafico As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGrafico As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents cmdgraficodev As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgCatalogoAcumulados = New System.Windows.Forms.DataGrid
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdGrafico = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdgraficodev = New DevExpress.XtraEditors.SimpleButton
        Me.gbGrafico = New System.Windows.Forms.GroupBox
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmdOcultarGrafico = New DevExpress.XtraEditors.SimpleButton
        CType(Me.dgCatalogoAcumulados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbGrafico.SuspendLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCatalogoAcumulados
        '
        Me.dgCatalogoAcumulados.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgCatalogoAcumulados.BackColor = System.Drawing.Color.Gainsboro
        Me.dgCatalogoAcumulados.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgCatalogoAcumulados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCatalogoAcumulados.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgCatalogoAcumulados.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgCatalogoAcumulados.CaptionForeColor = System.Drawing.Color.Black
        Me.dgCatalogoAcumulados.DataMember = ""
        Me.dgCatalogoAcumulados.FlatMode = True
        Me.dgCatalogoAcumulados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCatalogoAcumulados.ForeColor = System.Drawing.Color.Black
        Me.dgCatalogoAcumulados.GridLineColor = System.Drawing.Color.Silver
        Me.dgCatalogoAcumulados.HeaderBackColor = System.Drawing.Color.Black
        Me.dgCatalogoAcumulados.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgCatalogoAcumulados.HeaderForeColor = System.Drawing.Color.White
        Me.dgCatalogoAcumulados.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgCatalogoAcumulados.Location = New System.Drawing.Point(16, 42)
        Me.dgCatalogoAcumulados.Name = "dgCatalogoAcumulados"
        Me.dgCatalogoAcumulados.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgCatalogoAcumulados.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCatalogoAcumulados.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgCatalogoAcumulados.SelectionForeColor = System.Drawing.Color.White
        Me.dgCatalogoAcumulados.Size = New System.Drawing.Size(640, 400)
        Me.dgCatalogoAcumulados.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.etDescripcion)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(776, 34)
        Me.GroupBox3.TabIndex = 115
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 21)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "ACUMULADOS DE LA CUENTA:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etDescripcion.Location = New System.Drawing.Point(200, 9)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(576, 21)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdGrafico)
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Controls.Add(Me.cmdImprimir)
        Me.GroupBox2.Controls.Add(Me.cmdgraficodev)
        Me.GroupBox2.Location = New System.Drawing.Point(808, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 491)
        Me.GroupBox2.TabIndex = 116
        Me.GroupBox2.TabStop = False
        '
        'cmdGrafico
        '
        Me.cmdGrafico.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrafico.Appearance.Options.UseFont = True
        Me.cmdGrafico.Location = New System.Drawing.Point(16, 155)
        Me.cmdGrafico.Name = "cmdGrafico"
        Me.cmdGrafico.Size = New System.Drawing.Size(72, 26)
        Me.cmdGrafico.TabIndex = 23
        Me.cmdGrafico.Text = "Gráfico"
        Me.cmdGrafico.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.Location = New System.Drawing.Point(16, 78)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 25)
        Me.cmdSalir.TabIndex = 22
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Location = New System.Drawing.Point(16, 11)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 26)
        Me.cmdImprimir.TabIndex = 20
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdgraficodev
        '
        Me.cmdgraficodev.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdgraficodev.Appearance.Options.UseFont = True
        Me.cmdgraficodev.Location = New System.Drawing.Point(16, 43)
        Me.cmdgraficodev.Name = "cmdgraficodev"
        Me.cmdgraficodev.Size = New System.Drawing.Size(72, 26)
        Me.cmdgraficodev.TabIndex = 23
        Me.cmdgraficodev.Text = "GráficoD"
        '
        'gbGrafico
        '
        Me.gbGrafico.Controls.Add(Me.PivotGridControl1)
        Me.gbGrafico.Controls.Add(Me.dtpDesde)
        Me.gbGrafico.Controls.Add(Me.dtpHasta)
        Me.gbGrafico.Controls.Add(Me.btnBuscar)
        Me.gbGrafico.Controls.Add(Me.LabelControl2)
        Me.gbGrafico.Controls.Add(Me.LabelControl1)
        Me.gbGrafico.Controls.Add(Me.cmdOcultarGrafico)
        Me.gbGrafico.Controls.Add(Me.dgCatalogoAcumulados)
        Me.gbGrafico.Location = New System.Drawing.Point(32, 34)
        Me.gbGrafico.Name = "gbGrafico"
        Me.gbGrafico.Size = New System.Drawing.Size(776, 491)
        Me.gbGrafico.TabIndex = 117
        Me.gbGrafico.TabStop = False
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3})
        Me.PivotGridControl1.Location = New System.Drawing.Point(16, 197)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(344, 232)
        Me.PivotGridControl1.TabIndex = 128
        Me.PivotGridControl1.Visible = False
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.FieldName = "Orden"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField2.AreaIndex = 0
        Me.PivotGridField2.FieldName = "Debe"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField3.AreaIndex = 1
        Me.PivotGridField3.FieldName = "Haber"
        Me.PivotGridField3.Name = "PivotGridField3"
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(88, 17)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(112, 21)
        Me.dtpDesde.TabIndex = 127
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(280, 17)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(112, 21)
        Me.dtpHasta.TabIndex = 126
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Location = New System.Drawing.Point(400, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(72, 26)
        Me.btnBuscar.TabIndex = 125
        Me.btnBuscar.Text = "Buscar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(208, 17)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 14)
        Me.LabelControl2.TabIndex = 124
        Me.LabelControl2.Text = "Hasta:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(16, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 14)
        Me.LabelControl1.TabIndex = 122
        Me.LabelControl1.Text = "Desde:"
        '
        'cmdOcultarGrafico
        '
        Me.cmdOcultarGrafico.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOcultarGrafico.Appearance.Options.UseFont = True
        Me.cmdOcultarGrafico.Appearance.Options.UseTextOptions = True
        Me.cmdOcultarGrafico.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdOcultarGrafico.Location = New System.Drawing.Point(16, 448)
        Me.cmdOcultarGrafico.Name = "cmdOcultarGrafico"
        Me.cmdOcultarGrafico.Size = New System.Drawing.Size(72, 34)
        Me.cmdOcultarGrafico.TabIndex = 120
        Me.cmdOcultarGrafico.Text = "Ocultar Gráfico"
        Me.cmdOcultarGrafico.Visible = False
        '
        'frmAcumuladosCuenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(936, 532)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbGrafico)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmAcumuladosCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgCatalogoAcumulados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.gbGrafico.ResumeLayout(False)
        Me.gbGrafico.PerformLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAcumuladosCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Detalles = CatalogoAcumulados.GetDetails(Registro)
        etDescripcion.Text = Detalles.Nombre.ToUpper

        Me.dtpDesde.MinDate = Fechas.FechaMinima
        Me.dtpDesde.MaxDate = Fechas.FechaMaxima

        Me.dtpHasta.MinDate = Fechas.FechaMinima
        Me.dtpHasta.MaxDate = Fechas.FechaMaxima

        Me.dtpDesde.Value = Fechas.FechaMinima
        Me.dtpHasta.Value = Fechas.FechaMaxima

        dgCatalogoAcumulados.CaptionText = "Acumulados"
        ''r.CambiarEstilo(Me)
        ds = CatalogoAcumulados.GetListAcumulados(Registro, Me.dtpDesde.Value, Me.dtpHasta.Value)
        ds.Tables("CATALOGO").DefaultView.AllowDelete = False
        ds.Tables("CATALOGO").DefaultView.AllowNew = False
        ds.Tables("CATALOGO").DefaultView.AllowEdit = False

        dgCatalogoAcumulados.DataSource = ds.Tables("CATALOGO").DefaultView
        Tabla = ds.Tables("CATALOGO")

        r.FormatGenerico(dgCatalogoAcumulados, Tabla)

        dgCatalogoAcumulados.Refresh()
        dgCatalogoAcumulados.Visible = True

        Me.PivotGridControl1.DataSource = ds.Tables(0)
        Me.Refresh()

    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes
        'Dim rAcumuladosCuenta As New rptCatalalogoAcumulados
        Dim AcumuladosCuenta As New VB.SysContab.CatalogoDB
        Dim r As New VB.SysContab.Rutinas

        Dim rAcumuladosCuenta As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rAcumuladosCuenta.Load(Application.StartupPath & "\Reportes\rptCatalalogoAcumulados.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        rAcumuladosCuenta.SetDataSource(AcumuladosCuenta.GetListAcumuladosCuenta(Registro))
        fReportes.crvReportes.ReportSource = rAcumuladosCuenta
        fReportes.Show()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdOcultarGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOcultarGrafico.Click
        Me.dgCatalogoAcumulados.Visible = True
        Me.cmdOcultarGrafico.Visible = False
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        dgCatalogoAcumulados.CaptionText = "Acumulados"
        'r.CambiarEstilo(Me)
        ds = CatalogoAcumulados.GetListAcumulados(Registro, Me.dtpDesde.Value, Me.dtpHasta.Value)
        ds.Tables("CATALOGO").DefaultView.AllowDelete = False
        ds.Tables("CATALOGO").DefaultView.AllowNew = False
        ds.Tables("CATALOGO").DefaultView.AllowEdit = False

        dgCatalogoAcumulados.DataSource = ds.Tables("CATALOGO").DefaultView
        Tabla = ds.Tables("CATALOGO")

        r.FormatGenerico(dgCatalogoAcumulados, Tabla)

        dgCatalogoAcumulados.Refresh()
    End Sub

    Private Sub cmdgraficodev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgraficodev.Click
        Dim Forma As New frmgraficosxtra
        Forma.Mostrar(frmgraficosxtra.TipoGrafico.Acumulados, Me.PivotGridControl1.CreateSummaryDataSource, False, Me.PivotGridControl1)
    End Sub
End Class
