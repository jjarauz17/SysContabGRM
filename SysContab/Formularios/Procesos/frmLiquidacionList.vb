Imports DevExpress.XtraReports.UI

Public Class frmLiquidacionList
    'Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmLiquidacionList = Nothing

    Public Shared Function Instance() As frmLiquidacionList
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmLiquidacionList
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents LiqInBond As System.Windows.Forms.MenuItem
    Friend WithEvents LiqDirecta As System.Windows.Forms.MenuItem
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdMercTransito As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LiqFinal As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.LiqInBond = New System.Windows.Forms.MenuItem
        Me.LiqFinal = New System.Windows.Forms.MenuItem
        Me.LiqDirecta = New System.Windows.Forms.MenuItem
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdMercTransito = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(5, 61)
        Me.GridControl1.LookAndFeel.UseWindowsXPTheme = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(998, 390)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Appearance.ForeColor = System.Drawing.Color.Red
        Me.cmdExit.Appearance.Options.UseForeColor = True
        Me.cmdExit.Image = Global.SysContab.My.Resources.Resources.SalirFrm
        Me.cmdExit.Location = New System.Drawing.Point(913, 11)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(90, 35)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "&Salir"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.LiqInBond, Me.LiqFinal, Me.LiqDirecta})
        '
        'LiqInBond
        '
        Me.LiqInBond.Index = 0
        Me.LiqInBond.Text = "Liquidación &InBond"
        '
        'LiqFinal
        '
        Me.LiqFinal.Index = 1
        Me.LiqFinal.Text = "Liquidación &Final"
        '
        'LiqDirecta
        '
        Me.LiqDirecta.Index = 2
        Me.LiqDirecta.Text = "Liquidación &Directa"
        Me.LiqDirecta.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Image = Global.SysContab.My.Resources.Resources.Find
        Me.cmdEdit.Location = New System.Drawing.Point(101, 11)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(90, 35)
        Me.cmdEdit.TabIndex = 1
        Me.cmdEdit.Text = "&Detalle"
        '
        'cmdMercTransito
        '
        Me.cmdMercTransito.Appearance.Options.UseTextOptions = True
        Me.cmdMercTransito.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdMercTransito.Enabled = False
        Me.cmdMercTransito.Image = Global.SysContab.My.Resources.Resources.Container
        Me.cmdMercTransito.Location = New System.Drawing.Point(197, 11)
        Me.cmdMercTransito.Name = "cmdMercTransito"
        Me.cmdMercTransito.Size = New System.Drawing.Size(90, 35)
        Me.cmdMercTransito.TabIndex = 1
        Me.cmdMercTransito.Text = "&Merc. Tránsito"
        '
        'cmdPrint
        '
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Image = Global.SysContab.My.Resources.Resources.ImprimirD
        Me.cmdPrint.Location = New System.Drawing.Point(293, 11)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(90, 35)
        Me.cmdPrint.TabIndex = 1
        Me.cmdPrint.Text = "&Imprimir"
        '
        'cmdNew
        '
        Me.cmdNew.Enabled = False
        Me.cmdNew.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_PageOrientationPortrait
        Me.cmdNew.Location = New System.Drawing.Point(5, 11)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(90, 35)
        Me.cmdNew.TabIndex = 1
        Me.cmdNew.Text = "&Nuevo"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.Image = Global.SysContab.My.Resources.Resources.RibbonUserDesigner_RedoLarge
        Me.SimpleButton1.Location = New System.Drawing.Point(389, 11)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(97, 35)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "&Exportar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdNew)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.cmdExit)
        Me.PanelControl1.Controls.Add(Me.cmdEdit)
        Me.PanelControl1.Controls.Add(Me.cmdMercTransito)
        Me.PanelControl1.Controls.Add(Me.cmdPrint)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1008, 55)
        Me.PanelControl1.TabIndex = 10
        '
        'frmLiquidacionList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 463)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmLiquidacionList"
        Me.Text = "Listado de Liquidaciones"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Vaiables"
    Dim r As New VB.SysContab.Rutinas
    Friend WithEvents Dvista As New DevExpress.XtraGrid.Views.Grid.GridView
    Dim Nombre1 As String : Dim Nombre2 As String : Dim Timer As Boolean = True
#End Region

    Private Sub frmLiquidacionesList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''r.CambiarEstilo(Me)
        'r.FormularioColor(Me)
        RolesDB.UsuarioAcciones(PanelControl1)
        Refrescar()
    End Sub

    Public Sub Refrescar()
        Dim DS As New DataSet
        DS.Tables.Add(ObtieneDatos("SPJLiquidacionesList " & EmpresaActual))
        DS.Tables(0).TableName = "LiqPa"
        DS.Tables.Add(ObtieneDatos("SELECT LiqIBID AS LiqID,LiqID AS IDLiq, LiqNo,Fecha,ProveedorID,TC,Flete" & _
        ",BultosLiq AS[Bultos Liquidados],Poliza,CASE WHEN Estado=0 THEN 'Pendiente' WHEN Estado=1 THEN 'Importado' ELSE 'Anulado'END AS Estado " & _
        "FROM Liquidaciones INNER JOIN PROVEEDORES ON ProveedorID=Codigo AND EmpresaID=Empresa WHERE EmpresaID=" & _
        EmpresaActual & " AND LiqIBID <> 0 ORDER BY LiqNo DESC"))
        DS.Tables(1).TableName = "LiqSon"


        Try
            DS.Tables(0).Columns("LiqID").DefaultValue = 0
            DS.Tables(1).Columns("LiqID").DefaultValue = 0
            DS.Tables(0).Columns("LiqID").AllowDBNull = False
            DS.Tables(1).Columns("LiqID").AllowDBNull = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DS.Relations.Add("Liquidaciones", DS.Tables("LiqPa").Columns("LiqID"), DS.Tables("LiqSon").Columns("LiqID"))

        GridControl1.DataSource = DS.Tables(0) : GridView1.PopulateColumns() : FormatoGrid(Me.GridView1)
        GridView1.ColumnPanelRowHeight = 50
        GridView1.Columns(0).Visible = False : GridView1.Columns("Impuesto").Visible = False
        GridView1.Columns("ProveedorID").Visible = False : GridView1.Columns("Bultos Liquidados").Visible = False
        GridView1.Columns("Fecha").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        GridView1.Columns("Fecha").DisplayFormat.FormatString = "dd-MMM-yy"
        GridView1.Columns("LiqNo").Width = 75 : GridView1.Columns(2).Width = 75 : GridView1.Columns(6).Width = 50
        GridView1.Columns("Proveedor").Width = 250
        GridView1.Columns(10).AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        GridView1.Columns(11).AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        For i As Int16 = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Next
        GridView1.Columns("Fecha").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("No. Pedido").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("Factura").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("Recibo").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridView1.Columns("FOB").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns("FOB").DisplayFormat.FormatString = "N2"
        GridView1.Columns("Flete").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns("Flete").DisplayFormat.FormatString = "N2"
        GridView1.Columns("Bultos Entrantes").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridView1.Columns("Bultos Entrantes").DisplayFormat.FormatString = "N2"
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Timer = False
        Me.Close()
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        'Me.ContextMenu1.Show(cmdNew, New System.Drawing.Point(40, 30))
        Dim f As frmLiquidacionSelect = f.Instance
        f.Origen = 2
        f.WindowState = FormWindowState.Normal
        f.ShowDialog()
    End Sub

    'Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
    '    If GridView1.DataRowCount < 1 Then
    '        Exit Sub
    '    End If
    '    Dim f As frmLiquidacionAdd = f.Instance

    '    If Not Nombre1 Is Nothing And Not Nombre2 Is Nothing Then
    '        If Nombre1 = "" And Nombre2 = "Liquidaciones" Then
    '            f.Origen = 1
    '            f.LiqID = GridView1.GetFocusedRowCellValue("LiqID")
    '            f.tbLiqNo.Text = GridView1.GetFocusedRowCellValue("LiqNo")
    '        Else
    '            f.Origen = 2
    '            f.LiqID = Dvista.GetFocusedRowCellValue("IDLiq")
    '            If Dvista.GetFocusedRowCellValue("Estado") = "Pendiente" Then f.cmdImportar.Enabled = True
    '            f.tbLiqNo.Text = Dvista.GetFocusedRowCellValue("LiqNo")
    '        End If
    '    Else
    '        If GridView1.GetFocusedRowCellValue("LiqNo").ToString.StartsWith("I") Then
    '            f.Origen = 1 : Else : f.Origen = 2
    '            f.LiqID = GridView1.GetFocusedRowCellValue("LiqID")
    '            If GridView1.GetFocusedRowCellValue("Estado") = "Pendientes" Then
    '                f.cmdImportar.Enabled = True : Else : f.cmdImportar.Enabled = False
    '            End If
    '        End If
    '        f.LiqID = GridView1.GetFocusedRowCellValue("LiqID")
    '        f.tbLiqNo.Text = GridView1.GetFocusedRowCellValue("LiqNo")
    '    End If

    '    f.NewLiq = False
    '    f.cmdSave.Enabled = False
    '    f.MdiParent = Me.MdiParent
    '    f.WindowState = FormWindowState.Maximized
    '    f.cbProveedor.EditValue = GridView1.GetFocusedRowCellValue("ProveedorID")
    '    f.Show()
    'End Sub

    'Private Sub LiqInBond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiqInBond.Click
    '    Dim f As frmLiquidacionSelect = f.Instance
    '    f.Origen = 3
    '    f.WindowState = FormWindowState.Normal
    '    f.ShowDialog()
    'End Sub

    'Private Sub LiqFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiqFinal.Click
    '    Dim f As frmLiquidacionSelect = f.Instance
    '    f.Origen = 2
    '    f.WindowState = FormWindowState.Normal
    '    f.ShowDialog()
    'End Sub

    Private Sub LiqDirecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiqDirecta.Click
        'Dim f As frmLiquidacionAdd = f.Instance
        'f.NewLiq = True
        'f.MdiParent = Me.MdiParent
        'f.WindowState = FormWindowState.Maximized
        'f.Show()
        Dim f As frmLiquidacionSelect = f.Instance
        f.Origen = 1
        f.WindowState = FormWindowState.Normal
        f.Directa = True
        f.ShowDialog()
    End Sub

    Private Sub GridView1_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles GridView1.MasterRowExpanded
        'If sender.FocusedRowHandle >= 0 Then
        '    Dvista = sender.GetVisibleDetailView(sender.FocusedRowHandle)
        '    If Not Dvista Is Nothing Then
        '        For i As Int16 = 0 To Dvista.Columns.Count - 1
        '            Dvista.Columns(i).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        '        Next

        '        Dvista.ColumnPanelRowHeight = 20
        '        Dvista.Columns("LiqID").Visible = False
        '        Dvista.Columns("IDLiq").Visible = False
        '        Dvista.Columns("ProveedorID").Visible = False
        '        Dvista.Columns("Fecha").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '        Dvista.Columns("Fecha").DisplayFormat.FormatString = "dd-MMM-yyyy"
        '        Dvista.Columns("Bultos Liquidados").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        '        Dvista.Columns("Bultos Liquidados").SummaryItem.DisplayFormat = "{0:n2}"
        '    End If
        'End If
    End Sub

    Private Sub GridControl1_FocusedViewChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.ViewFocusEventArgs) Handles GridControl1.FocusedViewChanged
        If Timer Then
            Nombre1 = CType(e.View.LevelName, String)
            Nombre2 = CType(e.PreviousView.LevelName, String)
        End If
    End Sub

    Private Sub cmdMercTransito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMercTransito.Click
        Dim f As frmMercaderiaTransito = f.Instance
        f.MdiParent = My.Forms.frmPrincipalRibbon
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If GridView1.FocusedRowHandle < 0 Then
            Exit Sub
        End If
        Dim LiqRep As New rptLiqReport
        Dim DTEx As New DataTable

        LiqRep.DataSource = ObtieneDatos("SPJ_LiqPrint " & GridView1.GetFocusedRowCellValue("LiqID") & "," & EmpresaActual & ",'" & Usuario & "'")
        LiqRep.gcDetail.DataSource = ObtieneDatos("SPJ_LiqPrintDetail " & GridView1.GetFocusedRowCellValue("LiqID") & "," & EmpresaActual)
        DTEx = ObtieneDatos("SPJ_LiqPrintExpenses  " & GridView1.GetFocusedRowCellValue("LiqID") & "," & EmpresaActual)
        If DTEx.Rows.Count > 0 Then
            LiqRep.gcGastos.DataSource = DTEx
        Else
            LiqRep.XrLabel30.Visible = False
            LiqRep.gcGastos.Visible = False
            LiqRep.BandedGridColumn17.Visible = False
        End If

        LiqRep.ShowRibbonPreview()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        My.Forms.frmExportarImprimir.Mostrar(GridControl1)
    End Sub
End Class
