Imports DevExpress.XtraReports.UI

Public Class XtraBalanzaComprobacion
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Component Designer generated code "

    Public Sub New(Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Designer support
        Container.Add(me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Component overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Private WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.
    'Do not modify it using the code editor.
    Friend WithEvents Cuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Nombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DebitoS As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CreditoS As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DebitoM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CreditoM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SC01 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SC02 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Mayor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SC03 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CreditoA As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DebitoA As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NSC01 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NSC02 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NMayor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NSC03 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GrpCuenta As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GrpGrupo As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Grupo As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents GrpSC01 As DevExpress.XtraReports.UI.GroupHeaderBand
    Public WithEvents GrpSC02 As DevExpress.XtraReports.UI.GroupHeaderBand
    Public WithEvents GrpMayor As DevExpress.XtraReports.UI.GroupHeaderBand
    Public WithEvents GrpSC03 As DevExpress.XtraReports.UI.GroupHeaderBand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary10 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary11 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary12 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary13 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary14 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary15 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary16 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary17 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary18 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary19 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary20 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary21 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary22 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary23 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary24 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary25 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary26 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary27 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary28 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary29 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary30 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary31 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary32 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary33 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary34 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary35 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary36 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary37 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary38 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary39 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary40 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary41 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary42 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.DebitoA = New DevExpress.XtraReports.UI.XRLabel
        Me.CreditoA = New DevExpress.XtraReports.UI.XRLabel
        Me.CreditoM = New DevExpress.XtraReports.UI.XRLabel
        Me.DebitoM = New DevExpress.XtraReports.UI.XRLabel
        Me.CreditoS = New DevExpress.XtraReports.UI.XRLabel
        Me.DebitoS = New DevExpress.XtraReports.UI.XRLabel
        Me.Nombre = New DevExpress.XtraReports.UI.XRLabel
        Me.Cuenta = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.GrpSC01 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.SC01 = New DevExpress.XtraReports.UI.XRLabel
        Me.NSC01 = New DevExpress.XtraReports.UI.XRLabel
        Me.GrpSC02 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.SC02 = New DevExpress.XtraReports.UI.XRLabel
        Me.NSC02 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.GrpMayor = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.Mayor = New DevExpress.XtraReports.UI.XRLabel
        Me.NMayor = New DevExpress.XtraReports.UI.XRLabel
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.GrpSC03 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel
        Me.NSC03 = New DevExpress.XtraReports.UI.XRLabel
        Me.SC03 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.GrpCuenta = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel
        Me.GrpGrupo = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.Grupo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.DebitoA, Me.CreditoA, Me.CreditoM, Me.DebitoM, Me.CreditoS, Me.DebitoS, Me.Nombre, Me.Cuenta})
        Me.Detail.Height = 17
        Me.Detail.Name = "Detail"
        Me.Detail.Visible = False
        '
        'DebitoA
        '
        Me.DebitoA.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoA", "{0:n2}")})
        Me.DebitoA.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.DebitoA.Location = New System.Drawing.Point(833, 0)
        Me.DebitoA.Name = "DebitoA"
        Me.DebitoA.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DebitoA.ParentStyleUsing.UseFont = False
        Me.DebitoA.Size = New System.Drawing.Size(84, 17)
        Me.DebitoA.Text = "XrLabel1"
        Me.DebitoA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'CreditoA
        '
        Me.CreditoA.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoA", "{0:n2}")})
        Me.CreditoA.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.CreditoA.Location = New System.Drawing.Point(917, 0)
        Me.CreditoA.Name = "CreditoA"
        Me.CreditoA.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CreditoA.ParentStyleUsing.UseFont = False
        Me.CreditoA.Size = New System.Drawing.Size(83, 17)
        Me.CreditoA.Text = "XrLabel1"
        Me.CreditoA.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'CreditoM
        '
        Me.CreditoM.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoM", "{0:n2}")})
        Me.CreditoM.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.CreditoM.Location = New System.Drawing.Point(750, 0)
        Me.CreditoM.Name = "CreditoM"
        Me.CreditoM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CreditoM.ParentStyleUsing.UseFont = False
        Me.CreditoM.Size = New System.Drawing.Size(83, 17)
        Me.CreditoM.Text = "XrLabel1"
        Me.CreditoM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'DebitoM
        '
        Me.DebitoM.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoM", "{0:n2}")})
        Me.DebitoM.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.DebitoM.Location = New System.Drawing.Point(666, 0)
        Me.DebitoM.Name = "DebitoM"
        Me.DebitoM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DebitoM.ParentStyleUsing.UseFont = False
        Me.DebitoM.Size = New System.Drawing.Size(84, 17)
        Me.DebitoM.Text = "XrLabel1"
        Me.DebitoM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'CreditoS
        '
        Me.CreditoS.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoS", "{0:n2}")})
        Me.CreditoS.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.CreditoS.Location = New System.Drawing.Point(583, 0)
        Me.CreditoS.Name = "CreditoS"
        Me.CreditoS.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CreditoS.ParentStyleUsing.UseFont = False
        Me.CreditoS.Size = New System.Drawing.Size(83, 17)
        Me.CreditoS.Text = "XrLabel1"
        Me.CreditoS.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'DebitoS
        '
        Me.DebitoS.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoS", "{0:n2}")})
        Me.DebitoS.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.DebitoS.Location = New System.Drawing.Point(500, 0)
        Me.DebitoS.Name = "DebitoS"
        Me.DebitoS.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.DebitoS.ParentStyleUsing.UseFont = False
        Me.DebitoS.Size = New System.Drawing.Size(83, 17)
        Me.DebitoS.Text = "XrLabel1"
        Me.DebitoS.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Nombre
        '
        Me.Nombre.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre", "")})
        Me.Nombre.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Nombre.Location = New System.Drawing.Point(133, 0)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nombre.ParentStyleUsing.UseFont = False
        Me.Nombre.Size = New System.Drawing.Size(367, 17)
        Me.Nombre.Text = "XrLabel1"
        Me.Nombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Cuenta
        '
        Me.Cuenta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cuenta", "")})
        Me.Cuenta.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Cuenta.Location = New System.Drawing.Point(0, 0)
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Cuenta.ParentStyleUsing.UseFont = False
        Me.Cuenta.Size = New System.Drawing.Size(133, 17)
        Me.Cuenta.Text = "Cuenta"
        Me.Cuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel49, Me.XrLabel48, Me.XrLabel47, Me.XrLabel32, Me.XrLabel30, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel49
        '
        Me.XrLabel49.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel49.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel49.Location = New System.Drawing.Point(837, 33)
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.ParentStyleUsing.UseBorders = False
        Me.XrLabel49.ParentStyleUsing.UseFont = False
        Me.XrLabel49.Size = New System.Drawing.Size(160, 25)
        Me.XrLabel49.Text = "Saldo Actual"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel48
        '
        Me.XrLabel48.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel48.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel48.Location = New System.Drawing.Point(670, 33)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.ParentStyleUsing.UseBorders = False
        Me.XrLabel48.ParentStyleUsing.UseFont = False
        Me.XrLabel48.Size = New System.Drawing.Size(161, 25)
        Me.XrLabel48.Text = "Movimiento"
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel47
        '
        Me.XrLabel47.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel47.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel47.Location = New System.Drawing.Point(504, 33)
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.ParentStyleUsing.UseBorders = False
        Me.XrLabel47.ParentStyleUsing.UseFont = False
        Me.XrLabel47.Size = New System.Drawing.Size(159, 25)
        Me.XrLabel47.Text = "Saldo Anterior"
        Me.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel32
        '
        Me.XrLabel32.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel32.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel32.Location = New System.Drawing.Point(917, 75)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.ParentStyleUsing.UseBorders = False
        Me.XrLabel32.ParentStyleUsing.UseFont = False
        Me.XrLabel32.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel32.Text = "Creditos"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel30
        '
        Me.XrLabel30.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel30.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel30.Location = New System.Drawing.Point(833, 75)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.ParentStyleUsing.UseBorders = False
        Me.XrLabel30.ParentStyleUsing.UseFont = False
        Me.XrLabel30.Size = New System.Drawing.Size(84, 25)
        Me.XrLabel30.Text = "Debitos"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.Location = New System.Drawing.Point(0, 75)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.ParentStyleUsing.UseBorders = False
        Me.XrLabel6.ParentStyleUsing.UseFont = False
        Me.XrLabel6.Size = New System.Drawing.Size(133, 25)
        Me.XrLabel6.Text = "Cuenta"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.Location = New System.Drawing.Point(500, 75)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.ParentStyleUsing.UseBorders = False
        Me.XrLabel5.ParentStyleUsing.UseFont = False
        Me.XrLabel5.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel5.Text = "Debitos"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.Location = New System.Drawing.Point(666, 75)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.ParentStyleUsing.UseBorders = False
        Me.XrLabel4.ParentStyleUsing.UseFont = False
        Me.XrLabel4.Size = New System.Drawing.Size(84, 25)
        Me.XrLabel4.Text = "Debitos"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.Location = New System.Drawing.Point(583, 75)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.ParentStyleUsing.UseBorders = False
        Me.XrLabel3.ParentStyleUsing.UseFont = False
        Me.XrLabel3.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel3.Text = "Creditos"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.Location = New System.Drawing.Point(750, 75)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.ParentStyleUsing.UseBorders = False
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel2.Text = "Creditos"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(133, 75)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.ParentStyleUsing.UseBorders = False
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(367, 25)
        Me.XrLabel1.Text = "Nombre"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Height = 25
        Me.PageFooter.Name = "PageFooter"
        '
        'GrpSC01
        '
        Me.GrpSC01.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel38, Me.XrLabel37, Me.XrLabel12, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.SC01, Me.NSC01})
        Me.GrpSC01.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("SC01", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpSC01.Height = 17
        Me.GrpSC01.Level = 3
        Me.GrpSC01.Name = "GrpSC01"
        '
        'XrLabel38
        '
        Me.XrLabel38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoA", "")})
        Me.XrLabel38.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel38.Location = New System.Drawing.Point(833, 0)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.ParentStyleUsing.UseFont = False
        Me.XrLabel38.Size = New System.Drawing.Size(84, 17)
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel38.Summary = XrSummary1
        Me.XrLabel38.Text = "XrLabel38"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel37
        '
        Me.XrLabel37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoA", "")})
        Me.XrLabel37.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel37.Location = New System.Drawing.Point(917, 0)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.ParentStyleUsing.UseFont = False
        Me.XrLabel37.Size = New System.Drawing.Size(83, 17)
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel37.Summary = XrSummary2
        Me.XrLabel37.Text = "XrLabel37"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoS", "")})
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.Location = New System.Drawing.Point(583, 0)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.ParentStyleUsing.UseFont = False
        Me.XrLabel12.Size = New System.Drawing.Size(83, 17)
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel12.Summary = XrSummary3
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoS", "")})
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.Location = New System.Drawing.Point(500, 0)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.ParentStyleUsing.UseFont = False
        Me.XrLabel9.Size = New System.Drawing.Size(83, 17)
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.IgnoreNullValues = True
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel9.Summary = XrSummary4
        Me.XrLabel9.Text = "XrLabel9"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoM", "")})
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.Location = New System.Drawing.Point(750, 0)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.ParentStyleUsing.UseFont = False
        Me.XrLabel8.Size = New System.Drawing.Size(83, 17)
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.IgnoreNullValues = True
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel8.Summary = XrSummary5
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoM", "")})
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.Location = New System.Drawing.Point(666, 0)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.ParentStyleUsing.UseFont = False
        Me.XrLabel7.Size = New System.Drawing.Size(84, 17)
        XrSummary6.FormatString = "{0:n2}"
        XrSummary6.IgnoreNullValues = True
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel7.Summary = XrSummary6
        Me.XrLabel7.Text = "XrLabel7"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'SC01
        '
        Me.SC01.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SC01", "")})
        Me.SC01.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.SC01.ForeColor = System.Drawing.Color.Black
        Me.SC01.Location = New System.Drawing.Point(0, 0)
        Me.SC01.Name = "SC01"
        Me.SC01.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SC01.ParentStyleUsing.UseFont = False
        Me.SC01.ParentStyleUsing.UseForeColor = False
        Me.SC01.Size = New System.Drawing.Size(133, 17)
        Me.SC01.Text = "Cuenta"
        Me.SC01.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'NSC01
        '
        Me.NSC01.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NSC01", "")})
        Me.NSC01.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NSC01.Location = New System.Drawing.Point(133, 0)
        Me.NSC01.Name = "NSC01"
        Me.NSC01.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NSC01.ParentStyleUsing.UseFont = False
        Me.NSC01.Size = New System.Drawing.Size(367, 17)
        Me.NSC01.Text = "XrLabel1"
        Me.NSC01.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GrpSC02
        '
        Me.GrpSC02.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel36, Me.XrLabel35, Me.XrLabel18, Me.XrLabel17, Me.SC02, Me.NSC02, Me.XrLabel14, Me.XrLabel13})
        Me.GrpSC02.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("SC02", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpSC02.Height = 17
        Me.GrpSC02.Level = 2
        Me.GrpSC02.Name = "GrpSC02"
        Me.GrpSC02.Visible = False
        '
        'XrLabel36
        '
        Me.XrLabel36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoA", "")})
        Me.XrLabel36.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel36.Location = New System.Drawing.Point(917, 0)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.ParentStyleUsing.UseFont = False
        Me.XrLabel36.Size = New System.Drawing.Size(83, 17)
        XrSummary7.FormatString = "{0:n2}"
        XrSummary7.IgnoreNullValues = True
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel36.Summary = XrSummary7
        Me.XrLabel36.Text = "XrLabel36"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel35
        '
        Me.XrLabel35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoA", "")})
        Me.XrLabel35.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel35.Location = New System.Drawing.Point(833, 0)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.ParentStyleUsing.UseFont = False
        Me.XrLabel35.Size = New System.Drawing.Size(84, 17)
        XrSummary8.FormatString = "{0:n2}"
        XrSummary8.IgnoreNullValues = True
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel35.Summary = XrSummary8
        Me.XrLabel35.Text = "XrLabel35"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoM", "")})
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.Location = New System.Drawing.Point(750, 0)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.ParentStyleUsing.UseFont = False
        Me.XrLabel18.Size = New System.Drawing.Size(83, 17)
        XrSummary9.FormatString = "{0:n2}"
        XrSummary9.IgnoreNullValues = True
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel18.Summary = XrSummary9
        Me.XrLabel18.Text = "XrLabel18"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel17
        '
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoM", "")})
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.Location = New System.Drawing.Point(666, 0)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.ParentStyleUsing.UseFont = False
        Me.XrLabel17.Size = New System.Drawing.Size(84, 17)
        XrSummary10.FormatString = "{0:n2}"
        XrSummary10.IgnoreNullValues = True
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel17.Summary = XrSummary10
        Me.XrLabel17.Text = "XrLabel17"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'SC02
        '
        Me.SC02.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SC02", "")})
        Me.SC02.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.SC02.ForeColor = System.Drawing.Color.Black
        Me.SC02.Location = New System.Drawing.Point(0, 0)
        Me.SC02.Name = "SC02"
        Me.SC02.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SC02.ParentStyleUsing.UseFont = False
        Me.SC02.ParentStyleUsing.UseForeColor = False
        Me.SC02.Size = New System.Drawing.Size(133, 17)
        Me.SC02.Text = "Cuenta"
        Me.SC02.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'NSC02
        '
        Me.NSC02.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NSC02", "")})
        Me.NSC02.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NSC02.Location = New System.Drawing.Point(133, 0)
        Me.NSC02.Name = "NSC02"
        Me.NSC02.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NSC02.ParentStyleUsing.UseFont = False
        Me.NSC02.Size = New System.Drawing.Size(367, 17)
        Me.NSC02.Text = "XrLabel1"
        Me.NSC02.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoS", "")})
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.Location = New System.Drawing.Point(500, 0)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.ParentStyleUsing.UseFont = False
        Me.XrLabel14.Size = New System.Drawing.Size(83, 17)
        XrSummary11.FormatString = "{0:n2}"
        XrSummary11.IgnoreNullValues = True
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel14.Summary = XrSummary11
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoS", "")})
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.Location = New System.Drawing.Point(583, 0)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.ParentStyleUsing.UseFont = False
        Me.XrLabel13.Size = New System.Drawing.Size(83, 17)
        XrSummary12.FormatString = "{0:n2}"
        XrSummary12.IgnoreNullValues = True
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel13.Summary = XrSummary12
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GrpMayor
        '
        Me.GrpMayor.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel40, Me.XrLabel39, Me.XrLabel24, Me.XrLabel23, Me.XrLabel20, Me.XrLabel19, Me.Mayor, Me.NMayor})
        Me.GrpMayor.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Mayor", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpMayor.Height = 17
        Me.GrpMayor.Level = 4
        Me.GrpMayor.Name = "GrpMayor"
        Me.GrpMayor.Visible = False
        '
        'XrLabel40
        '
        Me.XrLabel40.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoA", "")})
        Me.XrLabel40.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel40.Location = New System.Drawing.Point(833, 0)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.ParentStyleUsing.UseFont = False
        Me.XrLabel40.Size = New System.Drawing.Size(84, 17)
        XrSummary13.FormatString = "{0:n2}"
        XrSummary13.IgnoreNullValues = True
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel40.Summary = XrSummary13
        Me.XrLabel40.Text = "XrLabel40"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel39
        '
        Me.XrLabel39.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoA", "")})
        Me.XrLabel39.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel39.Location = New System.Drawing.Point(917, 0)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.ParentStyleUsing.UseFont = False
        Me.XrLabel39.Size = New System.Drawing.Size(83, 17)
        XrSummary14.FormatString = "{0:n2}"
        XrSummary14.IgnoreNullValues = True
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel39.Summary = XrSummary14
        Me.XrLabel39.Text = "XrLabel39"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel24
        '
        Me.XrLabel24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoM", "")})
        Me.XrLabel24.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel24.Location = New System.Drawing.Point(750, 0)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.ParentStyleUsing.UseFont = False
        Me.XrLabel24.Size = New System.Drawing.Size(83, 17)
        XrSummary15.FormatString = "{0:n2}"
        XrSummary15.IgnoreNullValues = True
        XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel24.Summary = XrSummary15
        Me.XrLabel24.Text = "XrLabel24"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel23
        '
        Me.XrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoM", "")})
        Me.XrLabel23.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.Location = New System.Drawing.Point(666, 0)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.ParentStyleUsing.UseFont = False
        Me.XrLabel23.Size = New System.Drawing.Size(84, 17)
        XrSummary16.FormatString = "{0:n2}"
        XrSummary16.IgnoreNullValues = True
        XrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel23.Summary = XrSummary16
        Me.XrLabel23.Text = "XrLabel23"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoS", "")})
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel20.Location = New System.Drawing.Point(583, 0)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.ParentStyleUsing.UseFont = False
        Me.XrLabel20.Size = New System.Drawing.Size(83, 17)
        XrSummary17.FormatString = "{0:n2}"
        XrSummary17.IgnoreNullValues = True
        XrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel20.Summary = XrSummary17
        Me.XrLabel20.Text = "XrLabel20"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel19
        '
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoS", "")})
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.Location = New System.Drawing.Point(500, 0)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.ParentStyleUsing.UseFont = False
        Me.XrLabel19.Size = New System.Drawing.Size(83, 17)
        XrSummary18.FormatString = "{0:n2}"
        XrSummary18.IgnoreNullValues = True
        XrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel19.Summary = XrSummary18
        Me.XrLabel19.Text = "XrLabel19"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Mayor
        '
        Me.Mayor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Mayor", "")})
        Me.Mayor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Mayor.ForeColor = System.Drawing.Color.Black
        Me.Mayor.Location = New System.Drawing.Point(0, 0)
        Me.Mayor.Name = "Mayor"
        Me.Mayor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Mayor.ParentStyleUsing.UseFont = False
        Me.Mayor.ParentStyleUsing.UseForeColor = False
        Me.Mayor.Size = New System.Drawing.Size(133, 17)
        Me.Mayor.Text = "Cuenta"
        Me.Mayor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'NMayor
        '
        Me.NMayor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NMayor", "")})
        Me.NMayor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NMayor.Location = New System.Drawing.Point(133, 0)
        Me.NMayor.Name = "NMayor"
        Me.NMayor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NMayor.ParentStyleUsing.UseFont = False
        Me.NMayor.Size = New System.Drawing.Size(367, 17)
        Me.NMayor.Text = "XrLabel1"
        Me.NMayor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel42, Me.XrLabel41, Me.XrLabel28, Me.XrLabel27, Me.XrLabel26, Me.XrLabel25})
        Me.ReportFooter.Height = 17
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel42
        '
        Me.XrLabel42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoA", "")})
        Me.XrLabel42.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel42.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.XrLabel42.Location = New System.Drawing.Point(833, 0)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.ParentStyleUsing.UseFont = False
        Me.XrLabel42.ParentStyleUsing.UseForeColor = False
        Me.XrLabel42.Size = New System.Drawing.Size(84, 17)
        XrSummary19.FormatString = "{0:n2}"
        XrSummary19.IgnoreNullValues = True
        XrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel42.Summary = XrSummary19
        Me.XrLabel42.Text = "XrLabel42"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel41
        '
        Me.XrLabel41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoA", "")})
        Me.XrLabel41.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel41.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.XrLabel41.Location = New System.Drawing.Point(917, 0)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel41.ParentStyleUsing.UseFont = False
        Me.XrLabel41.ParentStyleUsing.UseForeColor = False
        Me.XrLabel41.Size = New System.Drawing.Size(83, 17)
        XrSummary20.FormatString = "{0:n2}"
        XrSummary20.IgnoreNullValues = True
        XrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel41.Summary = XrSummary20
        Me.XrLabel41.Text = "XrLabel41"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel28
        '
        Me.XrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoM", "")})
        Me.XrLabel28.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel28.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.XrLabel28.Location = New System.Drawing.Point(750, 0)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.ParentStyleUsing.UseFont = False
        Me.XrLabel28.ParentStyleUsing.UseForeColor = False
        Me.XrLabel28.Size = New System.Drawing.Size(83, 17)
        XrSummary21.FormatString = "{0:n2}"
        XrSummary21.IgnoreNullValues = True
        XrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel28.Summary = XrSummary21
        Me.XrLabel28.Text = "XrLabel28"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel27
        '
        Me.XrLabel27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoS", "")})
        Me.XrLabel27.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.XrLabel27.Location = New System.Drawing.Point(583, 0)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.ParentStyleUsing.UseFont = False
        Me.XrLabel27.ParentStyleUsing.UseForeColor = False
        Me.XrLabel27.Size = New System.Drawing.Size(83, 17)
        XrSummary22.FormatString = "{0:n2}"
        XrSummary22.IgnoreNullValues = True
        XrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel27.Summary = XrSummary22
        Me.XrLabel27.Text = "XrLabel27"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel26
        '
        Me.XrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoS", "")})
        Me.XrLabel26.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel26.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.XrLabel26.Location = New System.Drawing.Point(500, 0)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.ParentStyleUsing.UseFont = False
        Me.XrLabel26.ParentStyleUsing.UseForeColor = False
        Me.XrLabel26.Size = New System.Drawing.Size(83, 17)
        XrSummary23.FormatString = "{0:n2}"
        XrSummary23.IgnoreNullValues = True
        XrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel26.Summary = XrSummary23
        Me.XrLabel26.Text = "XrLabel26"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel25
        '
        Me.XrLabel25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoM", "")})
        Me.XrLabel25.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel25.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.XrLabel25.Location = New System.Drawing.Point(666, 0)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.ParentStyleUsing.UseFont = False
        Me.XrLabel25.ParentStyleUsing.UseForeColor = False
        Me.XrLabel25.Size = New System.Drawing.Size(84, 17)
        XrSummary24.FormatString = "{0:n2}"
        XrSummary24.IgnoreNullValues = True
        XrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel25.Summary = XrSummary24
        Me.XrLabel25.Text = "XrLabel25"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GrpSC03
        '
        Me.GrpSC03.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel34, Me.XrLabel33, Me.NSC03, Me.SC03, Me.XrLabel29, Me.XrLabel22, Me.XrLabel16, Me.XrLabel11})
        Me.GrpSC03.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("SC03", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpSC03.Height = 17
        Me.GrpSC03.Level = 1
        Me.GrpSC03.Name = "GrpSC03"
        Me.GrpSC03.ParentStyleUsing.UseBorderWidth = False
        Me.GrpSC03.Visible = False
        '
        'XrLabel34
        '
        Me.XrLabel34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoA", "")})
        Me.XrLabel34.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel34.Location = New System.Drawing.Point(917, 0)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.ParentStyleUsing.UseFont = False
        Me.XrLabel34.Size = New System.Drawing.Size(83, 17)
        XrSummary25.FormatString = "{0:n2}"
        XrSummary25.IgnoreNullValues = True
        XrSummary25.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel34.Summary = XrSummary25
        Me.XrLabel34.Text = "XrLabel34"
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel33
        '
        Me.XrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoA", "")})
        Me.XrLabel33.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel33.Location = New System.Drawing.Point(833, 0)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.ParentStyleUsing.UseFont = False
        Me.XrLabel33.Size = New System.Drawing.Size(84, 17)
        XrSummary26.FormatString = "{0:n2}"
        XrSummary26.IgnoreNullValues = True
        XrSummary26.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel33.Summary = XrSummary26
        Me.XrLabel33.Text = "XrLabel33"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'NSC03
        '
        Me.NSC03.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NSC03", "")})
        Me.NSC03.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NSC03.Location = New System.Drawing.Point(133, 0)
        Me.NSC03.Name = "NSC03"
        Me.NSC03.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.NSC03.ParentStyleUsing.UseFont = False
        Me.NSC03.Size = New System.Drawing.Size(367, 17)
        Me.NSC03.Text = "XrLabel1"
        Me.NSC03.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SC03
        '
        Me.SC03.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SC03", "")})
        Me.SC03.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.SC03.ForeColor = System.Drawing.Color.Black
        Me.SC03.Location = New System.Drawing.Point(0, 0)
        Me.SC03.Name = "SC03"
        Me.SC03.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SC03.ParentStyleUsing.UseFont = False
        Me.SC03.ParentStyleUsing.UseForeColor = False
        Me.SC03.Size = New System.Drawing.Size(133, 17)
        Me.SC03.Text = "Cuenta"
        Me.SC03.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel29
        '
        Me.XrLabel29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoM", "")})
        Me.XrLabel29.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel29.Location = New System.Drawing.Point(666, 0)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.ParentStyleUsing.UseFont = False
        Me.XrLabel29.Size = New System.Drawing.Size(84, 17)
        XrSummary27.FormatString = "{0:n2}"
        XrSummary27.IgnoreNullValues = True
        XrSummary27.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel29.Summary = XrSummary27
        Me.XrLabel29.Text = "XrLabel29"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel22
        '
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoM", "")})
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel22.Location = New System.Drawing.Point(750, 0)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.ParentStyleUsing.UseFont = False
        Me.XrLabel22.Size = New System.Drawing.Size(83, 17)
        XrSummary28.FormatString = "{0:n2}"
        XrSummary28.IgnoreNullValues = True
        XrSummary28.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel22.Summary = XrSummary28
        Me.XrLabel22.Text = "XrLabel22"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel16
        '
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoS", "")})
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.Location = New System.Drawing.Point(583, 0)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.ParentStyleUsing.UseFont = False
        Me.XrLabel16.Size = New System.Drawing.Size(83, 17)
        XrSummary29.FormatString = "{0:n2}"
        XrSummary29.IgnoreNullValues = True
        XrSummary29.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel16.Summary = XrSummary29
        Me.XrLabel16.Text = "XrLabel16"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoS", "")})
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.Location = New System.Drawing.Point(500, 0)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.ParentStyleUsing.UseFont = False
        Me.XrLabel11.Size = New System.Drawing.Size(83, 17)
        XrSummary30.FormatString = "{0:n2}"
        XrSummary30.IgnoreNullValues = True
        XrSummary30.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel11.Summary = XrSummary30
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GrpCuenta
        '
        Me.GrpCuenta.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel46, Me.XrLabel45, Me.XrLabel31, Me.XrLabel21, Me.XrLabel15, Me.XrLabel10, Me.XrLabel44, Me.XrLabel43})
        Me.GrpCuenta.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Cuenta", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpCuenta.Height = 17
        Me.GrpCuenta.Name = "GrpCuenta"
        Me.GrpCuenta.Visible = False
        '
        'XrLabel46
        '
        Me.XrLabel46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoS", "")})
        Me.XrLabel46.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel46.Location = New System.Drawing.Point(500, 0)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.ParentStyleUsing.UseFont = False
        Me.XrLabel46.Size = New System.Drawing.Size(83, 17)
        XrSummary31.FormatString = "{0:n2}"
        XrSummary31.IgnoreNullValues = True
        XrSummary31.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel46.Summary = XrSummary31
        Me.XrLabel46.Text = "XrLabel46"
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel45
        '
        Me.XrLabel45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoS", "")})
        Me.XrLabel45.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel45.Location = New System.Drawing.Point(583, 0)
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.ParentStyleUsing.UseFont = False
        Me.XrLabel45.Size = New System.Drawing.Size(83, 17)
        XrSummary32.FormatString = "{0:n2}"
        XrSummary32.IgnoreNullValues = True
        XrSummary32.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel45.Summary = XrSummary32
        Me.XrLabel45.Text = "XrLabel45"
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel31
        '
        Me.XrLabel31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoM", "")})
        Me.XrLabel31.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel31.Location = New System.Drawing.Point(750, 0)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.ParentStyleUsing.UseFont = False
        Me.XrLabel31.Size = New System.Drawing.Size(83, 17)
        XrSummary33.FormatString = "{0:n2}"
        XrSummary33.IgnoreNullValues = True
        XrSummary33.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel31.Summary = XrSummary33
        Me.XrLabel31.Text = "XrLabel31"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoM", "")})
        Me.XrLabel21.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel21.Location = New System.Drawing.Point(666, 0)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.ParentStyleUsing.UseFont = False
        Me.XrLabel21.Size = New System.Drawing.Size(84, 17)
        XrSummary34.FormatString = "{0:n2}"
        XrSummary34.IgnoreNullValues = True
        XrSummary34.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel21.Summary = XrSummary34
        Me.XrLabel21.Text = "XrLabel21"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoA", "")})
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel15.Location = New System.Drawing.Point(833, 0)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.ParentStyleUsing.UseFont = False
        Me.XrLabel15.Size = New System.Drawing.Size(84, 17)
        XrSummary35.FormatString = "{0:n2}"
        XrSummary35.IgnoreNullValues = True
        XrSummary35.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel15.Summary = XrSummary35
        Me.XrLabel15.Text = "XrLabel15"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoA", "")})
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel10.Location = New System.Drawing.Point(917, 0)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.ParentStyleUsing.UseFont = False
        Me.XrLabel10.Size = New System.Drawing.Size(83, 17)
        XrSummary36.FormatString = "{0:n2}"
        XrSummary36.IgnoreNullValues = True
        XrSummary36.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel10.Summary = XrSummary36
        Me.XrLabel10.Text = "XrLabel10"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel44
        '
        Me.XrLabel44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cuenta", "")})
        Me.XrLabel44.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel44.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.ParentStyleUsing.UseFont = False
        Me.XrLabel44.Size = New System.Drawing.Size(133, 17)
        Me.XrLabel44.Text = "Cuenta"
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel43
        '
        Me.XrLabel43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre", "")})
        Me.XrLabel43.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel43.Location = New System.Drawing.Point(133, 0)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.ParentStyleUsing.UseFont = False
        Me.XrLabel43.Size = New System.Drawing.Size(367, 17)
        Me.XrLabel43.Text = "XrLabel1"
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GrpGrupo
        '
        Me.GrpGrupo.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Grupo, Me.XrLabel55, Me.XrLabel54, Me.XrLabel53, Me.XrLabel52, Me.XrLabel51, Me.XrLabel50})
        Me.GrpGrupo.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Grupo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpGrupo.Height = 17
        Me.GrpGrupo.Level = 5
        Me.GrpGrupo.Name = "GrpGrupo"
        '
        'Grupo
        '
        Me.Grupo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Grupo", "")})
        Me.Grupo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Grupo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.Grupo.Location = New System.Drawing.Point(0, 0)
        Me.Grupo.Name = "Grupo"
        Me.Grupo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Grupo.ParentStyleUsing.UseFont = False
        Me.Grupo.ParentStyleUsing.UseForeColor = False
        Me.Grupo.Size = New System.Drawing.Size(133, 17)
        Me.Grupo.Text = "Cuenta"
        Me.Grupo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel55
        '
        Me.XrLabel55.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoS", "")})
        Me.XrLabel55.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel55.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.XrLabel55.Location = New System.Drawing.Point(500, 0)
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.ParentStyleUsing.UseFont = False
        Me.XrLabel55.ParentStyleUsing.UseForeColor = False
        Me.XrLabel55.Size = New System.Drawing.Size(83, 17)
        XrSummary37.FormatString = "{0:n2}"
        XrSummary37.IgnoreNullValues = True
        XrSummary37.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel55.Summary = XrSummary37
        Me.XrLabel55.Text = "XrLabel19"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel54
        '
        Me.XrLabel54.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoS", "")})
        Me.XrLabel54.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel54.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.XrLabel54.Location = New System.Drawing.Point(583, 0)
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.ParentStyleUsing.UseFont = False
        Me.XrLabel54.ParentStyleUsing.UseForeColor = False
        Me.XrLabel54.Size = New System.Drawing.Size(83, 17)
        XrSummary38.FormatString = "{0:n2}"
        XrSummary38.IgnoreNullValues = True
        XrSummary38.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel54.Summary = XrSummary38
        Me.XrLabel54.Text = "XrLabel20"
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel53
        '
        Me.XrLabel53.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoM", "")})
        Me.XrLabel53.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel53.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.XrLabel53.Location = New System.Drawing.Point(666, 0)
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel53.ParentStyleUsing.UseFont = False
        Me.XrLabel53.ParentStyleUsing.UseForeColor = False
        Me.XrLabel53.Size = New System.Drawing.Size(84, 17)
        XrSummary39.FormatString = "{0:n2}"
        XrSummary39.IgnoreNullValues = True
        XrSummary39.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel53.Summary = XrSummary39
        Me.XrLabel53.Text = "XrLabel23"
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel52
        '
        Me.XrLabel52.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoM", "")})
        Me.XrLabel52.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel52.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.XrLabel52.Location = New System.Drawing.Point(750, 0)
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel52.ParentStyleUsing.UseFont = False
        Me.XrLabel52.ParentStyleUsing.UseForeColor = False
        Me.XrLabel52.Size = New System.Drawing.Size(83, 17)
        XrSummary40.FormatString = "{0:n2}"
        XrSummary40.IgnoreNullValues = True
        XrSummary40.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel52.Summary = XrSummary40
        Me.XrLabel52.Text = "XrLabel24"
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel51
        '
        Me.XrLabel51.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CreditoA", "")})
        Me.XrLabel51.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel51.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.XrLabel51.Location = New System.Drawing.Point(917, 0)
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel51.ParentStyleUsing.UseFont = False
        Me.XrLabel51.ParentStyleUsing.UseForeColor = False
        Me.XrLabel51.Size = New System.Drawing.Size(83, 17)
        XrSummary41.FormatString = "{0:n2}"
        XrSummary41.IgnoreNullValues = True
        XrSummary41.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel51.Summary = XrSummary41
        Me.XrLabel51.Text = "XrLabel39"
        Me.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel50
        '
        Me.XrLabel50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DebitoA", "")})
        Me.XrLabel50.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel50.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.XrLabel50.Location = New System.Drawing.Point(833, 0)
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel50.ParentStyleUsing.UseFont = False
        Me.XrLabel50.ParentStyleUsing.UseForeColor = False
        Me.XrLabel50.Size = New System.Drawing.Size(84, 17)
        XrSummary42.FormatString = "{0:n2}"
        XrSummary42.IgnoreNullValues = True
        XrSummary42.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel50.Summary = XrSummary42
        Me.XrLabel50.Text = "XrLabel40"
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XtraBalanzaComprobacion
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GrpSC01, Me.GrpSC02, Me.GrpMayor, Me.ReportFooter, Me.GrpSC03, Me.GrpCuenta, Me.GrpGrupo})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
    Public Ceros As Boolean

    Private Sub GrpSC01_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GrpSC01.BeforePrint
        Dim Fila As DataRowView = GetCurrentRow()
        If (Fila.Item("Cuenta") = Fila.Item("SC01")) Or (Ceros And (IsNull(Fila.Item("CreditoA"), 0.0) = 0.0 And IsNull(Fila.Item("DebitoA"), 0.0) = 0.0)) Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub GrpSC02_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GrpSC02.BeforePrint
        Dim Fila As DataRowView = GetCurrentRow()
        If (Fila.Item("Cuenta") = Fila.Item("SC02")) Or (Ceros And (IsNull(Fila.Item("CreditoA"), 0.0) = 0.0 And IsNull(Fila.Item("DebitoA"), 0.0) = 0.0)) Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

    End Sub

    Private Sub GrpSC03_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GrpSC03.BeforePrint
        Dim Fila As DataRowView = GetCurrentRow()
        If (Fila.Item("Cuenta") = Fila.Item("SC03")) Or (Ceros And (IsNull(Fila.Item("CreditoA"), 0.0) = 0.0 And IsNull(Fila.Item("DebitoA"), 0.0) = 0.0)) Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub GrpCuenta_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GrpCuenta.BeforePrint
        Dim Fila As DataRowView = GetCurrentRow()
        If (Ceros And (IsNull(Fila.Item("CreditoA"), 0.0) = 0.0 And IsNull(Fila.Item("DebitoA"), 0.0) = 0.0)) Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    'Private Sub GrpSC04_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GrpSC04.BeforePrint
    '    Dim Fila As DataRowView = GetCurrentRow()
    '    If Fila.Item("Cuenta") = Fila.Item("SC04") Then
    '        e.Cancel = True
    '    Else
    '        e.Cancel = False
    '    End If
    'End Sub

    'Private Sub GrpSC05_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GrpSC05.BeforePrint
    '    Dim Fila As DataRowView = GetCurrentRow()
    '    If Fila.Item("Cuenta") = Fila.Item("SC05") Then
    '        e.Cancel = True
    '    Else
    '        e.Cancel = False
    '    End If
    'End Sub

End Class

