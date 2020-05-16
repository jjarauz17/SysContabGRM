Public Class frmMercaderiaTransito
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmMercaderiaTransito = Nothing

    Public Shared Function Instance() As frmMercaderiaTransito
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmMercaderiaTransito
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
    Friend WithEvents cmdDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdAprobar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRevision As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDetail = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdAprobar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRevision = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Appearance.ForeColor = System.Drawing.Color.Red
        Me.cmdExit.Appearance.Options.UseForeColor = True
        Me.cmdExit.Location = New System.Drawing.Point(929, 12)
        Me.cmdExit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdExit.LookAndFeel.UseWindowsXPTheme = True
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "&Salir"
        '
        'cmdDetail
        '
        Me.cmdDetail.Location = New System.Drawing.Point(848, 12)
        Me.cmdDetail.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdDetail.LookAndFeel.UseWindowsXPTheme = True
        Me.cmdDetail.Name = "cmdDetail"
        Me.cmdDetail.Size = New System.Drawing.Size(75, 23)
        Me.cmdDetail.TabIndex = 4
        Me.cmdDetail.Text = "&Ver Detalle"
        Me.cmdDetail.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(13, 49)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(991, 486)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'cmdAprobar
        '
        Me.cmdAprobar.Location = New System.Drawing.Point(13, 12)
        Me.cmdAprobar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAprobar.LookAndFeel.UseWindowsXPTheme = True
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAprobar.TabIndex = 5
        Me.cmdAprobar.Text = "&A Liqudiar"
        '
        'cmdRevision
        '
        Me.cmdRevision.Location = New System.Drawing.Point(94, 12)
        Me.cmdRevision.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRevision.LookAndFeel.UseWindowsXPTheme = True
        Me.cmdRevision.Name = "cmdRevision"
        Me.cmdRevision.Size = New System.Drawing.Size(75, 23)
        Me.cmdRevision.TabIndex = 5
        Me.cmdRevision.Text = "A &Revisión"
        '
        'frmMercaderiaTransito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1016, 547)
        Me.ControlBox = False
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.cmdDetail)
        Me.Controls.Add(Me.cmdRevision)
        Me.Controls.Add(Me.cmdAprobar)
        Me.Controls.Add(Me.cmdExit)
        Me.Name = "frmMercaderiaTransito"
        Me.Text = "Mercaderia en Tránsito"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim DT As DataTable

    Private Sub frmMercaderiaTransito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridControl1.DataSource = ObtieneDatos("SELECT MTID,p.Nombre as Proveedor,oc.NoOrden AS[No. Orden],oc.Factura_Fecha as Fecha,a.NOMBRE as Articulo" & _
                                ",ocl.Item_Cantidad as Cantidad, CASE Estado WHEN 1 THEN 'En tránsito' WHEN 2 THEN 'Aprobada' WHEN 3 THEN 'A Revisión' " & _
                                "ELSE 'Liquidada' END AS Estado FROM Liquidaciones_MercaderiaTransito lmt JOIN ORDENES_COMPRAS oc ON lmt.OrdenCompraID = oc.OrdenCompra " & _
                                "JOIN ORDENES_COMPRAS_LINEAS ocl ON oc.Factura_ID =ocl.Factura_ID AND oc.Empresa_ID = ocl.Empresa_ID JOIN ARTICULOS a ON " & _
                                "ocl.Item_ID = a.CODIGO_ARTICULO AND ocl.Item_Tipo = a.TIPO JOIN PROVEEDORES p ON oc.Proveedor_ID = p.CODIGO " & _
                                "AND oc.Empresa_ID = p.EMPRESA WHERE oc.Empresa_ID=" & EmpresaActual & " AND InBond = 0")
        GridView1.PopulateColumns()
        GridView1.OptionsBehavior.Editable = False
        GridView1.Columns(0).Group()
        GridView1.Columns(1).Group()
        GridView1.ExpandAllGroups()
        GridView1.Columns("Fecha").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        GridView1.Columns("Fecha").DisplayFormat.FormatString = "dd-MMM-yyyy"
    End Sub

    'Private Sub cbFacturas_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.txtRegistro.EditValue = 0
    '    GridControl1.DataSource = ObtieneDatos("SELECT Nombre, Item_Cantidad AS Cantidad, ROUND(ValorFob,2) AS ValorFob, 0.00 AS Registro, 0.00 AS Total " & _
    '                            "FROM Facturas_Compras_Lineas FCL INNER JOIN Facturas_Compras FC ON FCL.Factura_ID=FC.Factura_ID AND " & _
    '                            "FCL.Empresa_ID=FC.Empresa_ID INNER JOIN Articulos ON Item_ID=Codigo_Articulo AND FCL.Empresa_ID = Empresa " & _
    '                            "WHERE FCL.Empresa_ID = " & EmpresaActual & " AND IDFactura = " & cbFacturas.EditValue & " AND Proveedor = " & cbProveedor.EditValue)
    '    GridView1.PopulateColumns()
    '    GridView1.OptionsBehavior.Editable = False
    '    GridView1.Columns(1).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
    '    GridView1.Columns(1).SummaryItem.DisplayFormat = "{0:n0}"
    '    GridView1.Columns(2).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
    '    GridView1.Columns(2).SummaryItem.DisplayFormat = "{0:n2}"
    '    GridView1.Columns(3).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
    '    GridView1.Columns(3).SummaryItem.DisplayFormat = "{0:n2}"

    'End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    'Private Sub txtRegistro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    For i As Integer = 0 To GridView1.DataRowCount - 1
    '        GridView1.SetRowCellValue(i, "Registro", GridView1.GetRowCellValue(i, "ValorFob") / GridView1.Columns(2).SummaryItem.SummaryValue * Me.txtRegistro.EditValue)
    '        GridView1.SetRowCellValue(i, "Total", GridView1.GetRowCellValue(i, "ValorFob") + GridView1.GetRowCellValue(i, "Registro"))
    '    Next
    'End Sub

    Private Sub cmdAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAprobar.Click
        ObtieneDatos("UPDATE Liquidaciones_MercaderiaTransito SET Estado = 2 WHERE MTID=" & GridView1.GetFocusedRowCellValue(""))
    End Sub
End Class
