
Public Class frmLiquidacionSelect
    Inherits System.Windows.Forms.Form

    Private Shared ChildInstance As frmLiquidacionSelect = Nothing

    Public Shared Function Instance() As frmLiquidacionSelect
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmLiquidacionSelect
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbProveedor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckSelect As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cmdJump As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Seleccione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbProveedor = New DevExpress.XtraEditors.LookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Seleccione = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ckSelect = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdJump = New DevExpress.XtraEditors.SimpleButton
        Me.rbTipo = New DevExpress.XtraEditors.RadioGroup
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbProveedor
        '
        Me.cbProveedor.EnterMoveNextControl = True
        Me.cbProveedor.Location = New System.Drawing.Point(68, 8)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedor.Properties.LookAndFeel.UseDefaultLookAndFeel = True
        Me.cbProveedor.Properties.LookAndFeel.UseWindowsXPTheme = False
        Me.cbProveedor.Properties.NullText = ""
        Me.cbProveedor.Size = New System.Drawing.Size(332, 20)
        Me.cbProveedor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Proveedor"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(8, 68)
        Me.GridControl1.LookAndFeel.UseWindowsXPTheme = False
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ckSelect})
        Me.GridControl1.Size = New System.Drawing.Size(392, 372)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5, Me.Seleccione, Me.GridColumn4, Me.Codigo})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowColumnResizing = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "IDFactura"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "No. Orden"
        Me.GridColumn2.FieldName = "Factura_ID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 120
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.Caption = "Proveedor"
        Me.GridColumn3.FieldName = "Proveedor"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 172
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "No. O.P."
        Me.GridColumn5.FieldName = "OrdenPago"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'Seleccione
        '
        Me.Seleccione.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Seleccione.AppearanceHeader.Options.UseFont = True
        Me.Seleccione.AppearanceHeader.Options.UseTextOptions = True
        Me.Seleccione.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Seleccione.Caption = "Seleccione"
        Me.Seleccione.FieldName = "Seleccione"
        Me.Seleccione.Name = "Seleccione"
        Me.Seleccione.Visible = True
        Me.Seleccione.VisibleIndex = 2
        Me.Seleccione.Width = 86
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Saldo"
        Me.GridColumn4.FieldName = "Saldo"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.AllowFocus = False
        Me.GridColumn4.OptionsColumn.AllowMove = False
        Me.GridColumn4.OptionsColumn.AllowSize = False
        '
        'Codigo
        '
        Me.Codigo.Caption = "Codigo"
        Me.Codigo.FieldName = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'ckSelect
        '
        Me.ckSelect.AutoHeight = False
        Me.ckSelect.Name = "ckSelect"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(256, 445)
        Me.cmdSalir.LookAndFeel.UseDefaultLookAndFeel = True
        Me.cmdSalir.LookAndFeel.UseWindowsXPTheme = False
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 22
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Location = New System.Drawing.Point(56, 445)
        Me.cmdSave.LookAndFeel.UseDefaultLookAndFeel = True
        Me.cmdSave.LookAndFeel.UseWindowsXPTheme = False
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 21
        Me.cmdSave.Text = "&Continuar"
        '
        'cmdJump
        '
        Me.cmdJump.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdJump.Location = New System.Drawing.Point(156, 445)
        Me.cmdJump.LookAndFeel.UseDefaultLookAndFeel = True
        Me.cmdJump.LookAndFeel.UseWindowsXPTheme = False
        Me.cmdJump.Name = "cmdJump"
        Me.cmdJump.Size = New System.Drawing.Size(75, 23)
        Me.cmdJump.TabIndex = 22
        Me.cmdJump.Text = "S&altar"
        Me.cmdJump.Visible = False
        '
        'rbTipo
        '
        Me.rbTipo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.rbTipo.Location = New System.Drawing.Point(8, 37)
        Me.rbTipo.Name = "rbTipo"
        Me.rbTipo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rbTipo.Properties.Appearance.Options.UseBackColor = True
        Me.rbTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(New Decimal(New Integer() {0, 0, 0, 0}), "Tránsito"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "InBond")})
        Me.rbTipo.Size = New System.Drawing.Size(157, 25)
        Me.rbTipo.TabIndex = 23
        Me.rbTipo.Visible = False
        '
        'frmLiquidacionSelect
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(408, 475)
        Me.ControlBox = False
        Me.Controls.Add(Me.rbTipo)
        Me.Controls.Add(Me.cbProveedor)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdJump)
        Me.Name = "frmLiquidacionSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas A Liquidar"
        CType(Me.cbProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas
    Dim DT As DataTable : Public Origen As Int16 : Public Directa As Boolean

    Private Sub LiquidacionSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VB.SysContab.Rutinas.CambiarEstilo(Me)

        Dim p As New VB.SysContab.ProveedoresDB

        cbProveedor.Properties.DataSource = ObtieneDatos("SELECT CODIGO, NOMBRE FROM PROVEEDORES WHERE Empresa = " & EmpresaActual & _
                                                        " AND Codigo <> 0 ORDER BY Nombre")
        cbProveedor.Properties.DisplayMember = "NOMBRE"
        cbProveedor.Properties.ValueMember = "CODIGO"
        'cbProveedor.Properties.Columns("Proveedor").Visible = False
        If Origen = 2 Then
            cbProveedor.Visible = False : Label1.Visible = False
            ALiquidar()
        End If
    End Sub

    Private Sub ALiquidar()
        DT = ObtieneDatos("SPJ_Liquidaciones_GetOrdenes " & rbTipo.EditValue & "," & EmpresaActual)
        'DT = ObtieneDatos("SPJLiquidarGetFacturas " & IIf(cbProveedor.EditValue Is Nothing, 0, cbProveedor.EditValue) & "," & EmpresaActual & "," & Origen)
        GridControl1.DataSource = DT
        'GridView2.Columns("Codigo").Visible = False
        If GridView2.DataRowCount >= 0 Then
            GridView2.Columns("Factura_ID").OptionsColumn.ReadOnly = True
            If Origen = 2 Then
                GridView2.Columns("Factura_ID").Caption = "No. Orden"
                Me.Width = 500
                'GridView2.Columns("Saldo").Visible = True : GridView2.Columns("Saldo").VisibleIndex = 2
            End If
            If Origen = 3 Then
                GridView2.Columns("Proveedor").Visible = False
            End If
            GridView2.AddNewRow()
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        cbProveedor.Properties.DataSource = ""
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cbProveedor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProveedor.EditValueChanged, rbTipo.EditValueChanged
        ALiquidar()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim DT1 As DataTable
        Dim Facturas As String = "" 'Para seleccionar las IDFacturas a liquidar InBond
        Dim Facturas1 As String = "" 'Para seleccionar las FacturaNo. a liquidar InBond

        GridView1.AddNewRow()
        DT1 = DT.GetChanges(DataRowState.Modified)

        For i As Int16 = 0 To DT1.Rows.Count - 1
            If DT1.Rows(i).Item(3) = True Then
                Facturas = Facturas + DT1.Rows(i).Item(0).ToString + ","
                Facturas1 = Facturas1 + DT1.Rows(i).Item(1) + ","
            End If
        Next
        If Facturas.EndsWith(",") Then Facturas = Facturas.Remove(Facturas.Length - 1, 1)
        If Facturas1.EndsWith(",") Then Facturas1 = Facturas1.Remove(Facturas1.Length - 1, 1)

        If Origen = 1 Or Origen = 3 Then

            'Dim R As Int16

            'Dim f As frmLiquidacionAdd = frmLiquidacionAdd.Instance
            'f.NewLiq = True
            'f.Origen = Origen
            'f.Directa = Directa
            'f.MdiParent = My.Forms.frmPrincipalRibbon
            'f.WindowState = FormWindowState.Maximized
            'f.FacSelec = Facturas
            'f.tbFactura.Text = Facturas1
            'f.ProvSelec = cbProveedor.EditValue
            'f.cbProveedor.EditValue = cbProveedor.EditValue
            'f.Show()

        ElseIf Origen = 2 Then
            Dim Count As Int16 = 0 : Dim LiqIDTemp As String = "" : Dim ProveedorIDTemp As String = ""
            'If DT.Compute("Count(Seleccione)", "Seleccione=0") = 0 Then
            'If Not DT1 Is Nothing Then MsgBox("Favor seleccione una liquidación InBond") : Exit Sub

            'DT1 = DT.GetChanges(DataRowState.Modified)

            If Not DT1 Is Nothing Then
                For i As Integer = 0 To DT1.Rows.Count - 1
                    If DT1.Rows(i).Item(3) = True Then
                        ProveedorIDTemp = ProveedorIDTemp + DT1.Rows(i).Item(5).ToString + ","
                        LiqIDTemp = LiqIDTemp + DT1.Rows(i).Item(0).ToString + ","
                    Else
                        Count += 1
                    End If
                Next
                If Count = 0 And ProveedorIDTemp = "" Then MsgBox("Favor seleccione al menos una liquidación InBond.", MsgBoxStyle.OkOnly, formtitulo) : Exit Sub
                If ProveedorIDTemp.EndsWith(",") Then ProveedorIDTemp = ProveedorIDTemp.Remove(ProveedorIDTemp.Length - 1, 1)
                If LiqIDTemp.EndsWith(",") Then LiqIDTemp = LiqIDTemp.Remove(LiqIDTemp.Length - 1, 1)
                'If DT1.Rows(i).Item(3) = True Then
                '        Count += 1
                '        If Count > 1 Then
                '            MsgBox("Favor seleccione solamente una liquidación InBond.", MsgBoxStyle.OKOnly, formtitulo) : Exit Sub
                '        Else
                '            LiqIDTemp = DT1.Rows(i).Item(0)
                '        End If : End If : Next
                'If LiqIDTemp = 0 Then MsgBox("Favor seleccione al menos una liquidación InBond.", MsgBoxStyle.OKOnly, formtitulo) : Exit Sub
                'Else
                '    MsgBox("Favor seleccione al menos una liquidación InBond.", MsgBoxStyle.OKOnly, formtitulo) : Exit Sub
            End If
            'Else : MsgBox("Favor seleccione al menos una liquidación InBond.", MsgBoxStyle.OKOnly, FormTitulo) : Exit Sub
            'End If
            'If DT1.Rows.Count > 0 Then MsgBox("Favor seleccione solamente una liquidacion InBond.", MsgBoxStyle.OKOnly, FormTitulo) : Exit Sub

            'Para verficar si hay mas de un proveedor para realizar una liquidacion final


            ''ProveedorIDTemp = DT1.Rows(0).Item(6)
            ''For i As Int16 = 1 To DT1.Rows.Count - 1
            ''    If DT1.Rows(i).Item(3) = False Then

            ''    End If
            ''Next
            Dim delimStr As String = ","
            Dim delimiter As Char() = delimStr.ToCharArray() : Dim split As String() = Nothing

            Dim f As frmLiquidacionAdd = frmLiquidacionAdd.Instance
            f.Origen = 3 'Origen
            f.MT = True
            f.NewLiq = True 'False
            f.LiqID = LiqIDTemp
            f.tbFactura.Text = DT1.Rows(0).Item(6)
            f.tbPedido.Text = Facturas1
            'f.ALiquidar = True
            f.MdiParent = My.Forms.frmPrincipalRibbon
            f.WindowState = FormWindowState.Maximized
            f.FacSelec = Facturas
            f.ProvSelec = ProveedorIDTemp 'cbProveedor.EditValue
            split = ProveedorIDTemp.Split(delimiter)
            If split.GetUpperBound(0) > 0 Then
                f.cbProveedor.EditValue = 0
                f.cbProveedor.Enabled = False
            Else
                f.cbProveedor.EditValue = ProveedorIDTemp
            End If
            f.Show()
        End If
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cmdJump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdJump.Click
        Dim f As frmLiquidacionAdd = frmLiquidacionAdd.Instance
        f.NewLiq = True
        f.MdiParent = My.Forms.frmPrincipalRibbon
        f.WindowState = FormWindowState.Normal
        Me.Close()
        f.Show()
    End Sub

    'Private Sub GridView2_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanging
    '    If e.Column.FieldName = "Seleccione" And e.Value = True Then
    '        If GridView2.GetRowCellValue(e.RowHandle, "IDFactura") = "" Then
    '            MsgBox("Esta orden de compra no tiene orden de pago ingresada.")
    '            'DT.RejectChanges()
    '            CellValueChange()
    '        End If
    '    End If
    'End Sub

    'Private Sub CellValueChange()
    '    GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "Seleccione", False)
    'End Sub
End Class