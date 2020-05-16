Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraPivotGrid

Public Class FrmGraficoBitacora
    Inherits DevExpress.XtraEditors.XtraForm

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
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grafico As DevExpress.XtraCharts.ChartControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grafico = New DevExpress.XtraCharts.ChartControl
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.Grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grafico
        '
        Me.Grafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grafico.Diagram = Nothing
        Me.Grafico.Location = New System.Drawing.Point(0, 0)
        Me.Grafico.Name = "Grafico"
        Me.Grafico.SeriesTemplate.PointOptionsTypeName = "PointOptions"
        Me.Grafico.Size = New System.Drawing.Size(520, 344)
        Me.Grafico.TabIndex = 0
        '
        'cmdsalir
        '
        Me.cmdsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdsalir.Location = New System.Drawing.Point(440, 352)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.TabIndex = 1
        Me.cmdsalir.Text = "&Salir"
        '
        'FrmGraficoBitacora
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 386)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.Grafico)
        Me.Name = "FrmGraficoBitacora"
        Me.Text = "FrmGraficoBitacora"
        CType(Me.Grafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _Datas As PivotSummaryDataSource

    Public Property Datas() As PivotSummaryDataSource
        Get
            Return _Datas
        End Get
        Set(ByVal Value As PivotSummaryDataSource)
            _Datas = Value
        End Set
    End Property

    Private Sub FrmGraficoBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grafico.DataSource = Datas
        With Grafico
            Dim Serie1 As New DevExpress.XtraCharts.Series("Hoy", DevExpress.XtraCharts.ViewType.Bar)
            Serie1.ArgumentDataMember = "Evento"
            Serie1.ValueDataMembers.AddRange(New String() {"Hoy_Sum"})
            Serie1.LegendText = "Dia Actual"
            Dim Serie2 As New DevExpress.XtraCharts.Series("Ayer", DevExpress.XtraCharts.ViewType.Bar)
            Serie2.ArgumentDataMember = "Evento"
            Serie2.ValueDataMembers.AddRange(New String() {"Ayer_Sum"})
            Serie2.LegendText = "Dia Anterior"
            Dim Serie3 As New DevExpress.XtraCharts.Series("Diferencia", DevExpress.XtraCharts.ViewType.Bar)
            Serie3.ArgumentDataMember = "Evento"
            Serie3.ValueDataMembers.AddRange(New String() {"Diferencia_Sum"})
            Serie3.LegendText = "Diferencia"
            Grafico.Series.Add(Serie1)
            Grafico.Series.Add(Serie2)
            Grafico.Series.Add(Serie3)
        End With
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub


End Class

