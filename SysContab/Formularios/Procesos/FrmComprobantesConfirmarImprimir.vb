Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraReports.UI


Public Class FrmComprobantesConfirmarImprimir
    Inherits DevExpress.XtraEditors.XtraForm

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
    Friend WithEvents CompNo As System.Windows.Forms.Label
    Friend WithEvents PerID As System.Windows.Forms.Label
    Friend WithEvents Valorletras As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.Label
    Friend WithEvents Monto As System.Windows.Forms.Label
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button3 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CompNo = New System.Windows.Forms.Label()
        Me.PerID = New System.Windows.Forms.Label()
        Me.Valorletras = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Monto = New System.Windows.Forms.Label()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'CompNo
        '
        Me.CompNo.Location = New System.Drawing.Point(16, 16)
        Me.CompNo.Name = "CompNo"
        Me.CompNo.Size = New System.Drawing.Size(100, 23)
        Me.CompNo.TabIndex = 0
        Me.CompNo.Visible = False
        '
        'PerID
        '
        Me.PerID.Location = New System.Drawing.Point(128, 16)
        Me.PerID.Name = "PerID"
        Me.PerID.Size = New System.Drawing.Size(100, 23)
        Me.PerID.TabIndex = 1
        Me.PerID.Visible = False
        '
        'Valorletras
        '
        Me.Valorletras.Location = New System.Drawing.Point(24, 40)
        Me.Valorletras.Name = "Valorletras"
        Me.Valorletras.Size = New System.Drawing.Size(100, 23)
        Me.Valorletras.TabIndex = 2
        Me.Valorletras.Visible = False
        '
        'Fecha
        '
        Me.Fecha.Location = New System.Drawing.Point(128, 40)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(100, 23)
        Me.Fecha.TabIndex = 3
        Me.Fecha.Visible = False
        '
        'Monto
        '
        Me.Monto.Location = New System.Drawing.Point(16, 64)
        Me.Monto.Name = "Monto"
        Me.Monto.Size = New System.Drawing.Size(100, 23)
        Me.Monto.TabIndex = 4
        Me.Monto.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(88, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 40)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Vista Preliminar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(88, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 40)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Imprimir"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(86, 120)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 40)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Salir"
        '
        'FrmComprobantesConfirmarImprimir
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(292, 174)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Monto)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Valorletras)
        Me.Controls.Add(Me.PerID)
        Me.Controls.Add(Me.CompNo)
        Me.Name = "FrmComprobantesConfirmarImprimir"
        Me.Text = "Imprimir Comprobante"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim Comp As New VB.SysContab.ComprobanteDB

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Dim fReportes As New frmReportes

        'Dim rFactura As New rptComprobanteCKDinamico
        'rFactura.SetDataSource(Comp.ImprimirCombrobante(CompNo.Text, PerID.Text, Valorletras.Text, Fecha.Text, Monto.Text))
        'fReportes.crvReportes.ReportSource = rFactura
        'fReportes.Show()


        ImprimeCheque()

        'Dim fReportes As New frmReportes

        'If EmpresaActual = 13 Then
        '    Dim rFactura As New rptComprobanteChequeSIMTESIS
        '    rFactura.SetDataSource(Comp.ImprimirCombrobante(CompNo.Text, PerID.Text, Valorletras.Text, Fecha.Text, Monto.Text))
        '    fReportes.crvReportes.ReportSource = rFactura
        '    fReportes.Show()
        'Else
        '    Dim rFactura As New rptComprobanteCheque2
        '    rFactura.SetDataSource(Comp.ImprimirCombrobante(CompNo.Text, PerID.Text, Valorletras.Text, Fecha.Text, Monto.Text))
        '    fReportes.crvReportes.ReportSource = rFactura
        '    fReportes.Show()
        'End If



    End Sub



    Private Sub ImprimeCheque(Optional ByVal Directo As Boolean = False)

        Dim r As New VB.SysContab.Rutinas
        Dim ValorLetras As String = r.Letras(Monto.Text)    'VB.SysContab.Rutinas.ConversionDecimales( CDbl(lblDebito.Text).ToString(Round))
        Dim Cadena As String
        Dim Data() As Byte
        Dim Cod As Integer = ObtieneDatos("SPGetCodigoBanco " & PerID.Text _
                        & "," & CompNo.Text _
                        & "," & EmpresaActual & "," _
                        & Month(CDate(Fecha.Text).Date)).Rows(0).Item(0)
        If Cod = 0 Then
            MsgBox("No hay configurado ningun cheque para esta cuenta", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            'Dim Datas() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
            Data = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
        Catch ex As Exception
            MsgBox("No hay formato de cheque definido", MsgBoxStyle.Critical)
            Exit Sub
        End Try
        'Dim Data() As Byte = CType(ObtieneDatos("SELECT ChequeD FROM Catalogo_Bancos WHERE Codigo = " & Cod).Rows(0).Item(0), Byte())
        Dim Tamano As Integer
        Tamano = Data.GetUpperBound(0)
        Cadena = Application.StartupPath & "\RptCheque.repx"
        If File.Exists(Cadena) Then Kill(Cadena)
        Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
        Archivo.Write(Data, 0, Tamano)
        Archivo.Close()
        Dim Rep As XtraReport = XtraReport.FromFile(Application.StartupPath & "\RptCheque.repx", True)
        Rep.DataSource = GetChequeDb(PerID.Text, CompNo.Text, CDate(Fecha.Text).Date, ValorLetras)
        If Directo Then Rep.PrintDialog() Else Rep.ShowRibbonPreview()
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ImprimeCheque(True)

        'Dim fReportes As New frmReportes

        'If EmpresaActual = 13 Then
        '    Dim rFactura As New rptComprobanteChequeSIMTESIS
        '    rFactura.SetDataSource(Comp.ImprimirCombrobante(CompNo.Text, PerID.Text, Valorletras.Text, Fecha.Text, Monto.Text))
        '    fReportes.crvReportes.ReportSource = rFactura
        '    fReportes.crvReportes.PrintReport()
        'Else
        '    Dim rFactura As New rptComprobanteCheque2
        '    rFactura.SetDataSource(Comp.ImprimirCombrobante(CompNo.Text, PerID.Text, Valorletras.Text, Fecha.Text, Monto.Text))
        '    fReportes.crvReportes.ReportSource = rFactura
        '    fReportes.crvReportes.PrintReport()
        'End If
    End Sub
End Class

