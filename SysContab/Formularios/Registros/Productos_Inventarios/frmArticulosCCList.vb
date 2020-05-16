Imports System.Diagnostics.Process
Public Class frmArticulosCCList
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmArticulosCCList = Nothing

    Public Shared Function Instance() As frmArticulosCCList
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmArticulosCCList
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Vista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbLineas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbGrupos As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbSubGrupos As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cbSubSubGrupos As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents dgArticulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbProveedores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.dgArticulos = New DevExpress.XtraGrid.GridControl()
        Me.Vista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbLineas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbGrupos = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbSubGrupos = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbSubSubGrupos = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.cbProveedores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSubGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSubSubGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 358)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 61)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'btnExportar
        '
        Me.btnExportar.Enabled = False
        Me.btnExportar.Location = New System.Drawing.Point(398, 17)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(72, 35)
        Me.btnExportar.TabIndex = 8
        Me.btnExportar.Text = "&Exportar"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(320, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(476, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(164, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(242, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(86, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'dgArticulos
        '
        Me.dgArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgArticulos.Location = New System.Drawing.Point(8, 12)
        Me.dgArticulos.MainView = Me.Vista
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbLineas, Me.cbGrupos, Me.cbSubGrupos, Me.cbSubSubGrupos, Me.cbProveedores})
        Me.dgArticulos.Size = New System.Drawing.Size(779, 340)
        Me.dgArticulos.TabIndex = 7
        Me.dgArticulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vista})
        '
        'Vista
        '
        Me.Vista.GridControl = Me.dgArticulos
        Me.Vista.Name = "Vista"
        Me.Vista.OptionsBehavior.Editable = False
        Me.Vista.OptionsView.ShowAutoFilterRow = True
        Me.Vista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vista.OptionsView.ShowFooter = True
        Me.Vista.OptionsView.ShowGroupPanel = False
        '
        'cbLineas
        '
        Me.cbLineas.AutoHeight = False
        Me.cbLineas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLineas.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Código", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 150, "Nombre")})
        Me.cbLineas.Name = "cbLineas"
        Me.cbLineas.NullText = ""
        '
        'cbGrupos
        '
        Me.cbGrupos.AutoHeight = False
        Me.cbGrupos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbGrupos.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Código", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 150, "Nombre")})
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.NullText = ""
        '
        'cbSubGrupos
        '
        Me.cbSubGrupos.AutoHeight = False
        Me.cbSubGrupos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSubGrupos.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Código", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 150, "Nombre")})
        Me.cbSubGrupos.Name = "cbSubGrupos"
        Me.cbSubGrupos.NullText = ""
        '
        'cbSubSubGrupos
        '
        Me.cbSubSubGrupos.AutoHeight = False
        Me.cbSubSubGrupos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSubSubGrupos.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Código", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 150, "Nombre")})
        Me.cbSubSubGrupos.Name = "cbSubSubGrupos"
        Me.cbSubSubGrupos.NullText = ""
        '
        'cbProveedores
        '
        Me.cbProveedores.AutoHeight = False
        Me.cbProveedores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProveedores.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 150, "Nombre")})
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.NullText = ""
        '
        'frmArticulosCCList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(795, 419)
        Me.Controls.Add(Me.dgArticulos)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmArticulosCCList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSubGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSubSubGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public GruposCC As New VB.SysContab.GruposCCDB
    Dim Proveedores As New VB.SysContab.ProveedoresDB

    Private Sub frmArticulosCCList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then Cargar()
    End Sub


    Private Sub frmArticulosCCList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RolesDB.UsuarioAcciones(GroupBox1)
        ''
        cbLineas.DataSource = GruposCC.Lineas().Tables("GruposCC")
        cbLineas.ValueMember = "Código"
        cbLineas.DisplayMember = "Nombre"

        cbGrupos.DataSource = GruposCC.Grupos("%").Tables("GruposCC")
        cbGrupos.ValueMember = "Código"
        cbGrupos.DisplayMember = "Nombre"

        cbSubGrupos.DataSource = GruposCC.SubGrupos("%").Tables("GruposCC")
        cbSubGrupos.ValueMember = "Código"
        cbSubGrupos.DisplayMember = "Nombre"

        cbProveedores.DataSource = Proveedores.ListAll().Tables("Proveedores")
        cbProveedores.ValueMember = "Codigo"
        cbProveedores.DisplayMember = "Nombre"

        Cargar()
        Grid()
    End Sub
    Public Sub Cargar()
        dgArticulos.DataSource = GruposCC.ArticulosCCList()
    End Sub

    Sub Grid()
        Me.Vista.PopulateColumns()
        FormatoGrid(Me.Vista)

        Vista.Columns("Nombre").Width = 180
        Me.Vista.Columns("Proveedor").ColumnEdit = cbProveedores
        Me.Vista.Columns("Linea").ColumnEdit = cbLineas
        Me.Vista.Columns("Grupo").ColumnEdit = cbGrupos
        Me.Vista.Columns("Sub Grupo").ColumnEdit = cbSubGrupos

        Me.Vista.Columns("Costo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Vista.Columns("Costo").DisplayFormat.FormatString = "{0:" & Round & "}"
        Me.Vista.Columns("Costo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Vista.Columns("Costo").SummaryItem.DisplayFormat = "{0:" & Round & "}"

        'Me.Vista.BestFitColumns()

        If Me.Vista.DataRowCount = 0 Then
            Registro = "Vacio"
        Else
            Registro = Me.Vista.GetRowCellValue(0, "Código")
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarArticuloCC = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.Vista.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Contabilidad")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.Vista.GetFocusedRowCellValue("Código")
        End If

        Dim f As frmArticuloCCEdit = f.Instance
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.txtCodigo.Text = Registro
        f.Show()
        f.etInicio.Text = "0"
        f.cbProveedor.Focus()

    End Sub


    Private Sub frmGruposInventarios_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '
    End Sub


    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.Vista.DataRowCount = 0 Then
            MsgBox("No hay registros en la lista", MsgBoxStyle.Critical, "Sts.Contabilidad")
            Registro = "Vacio"
            Exit Sub
        Else
            Registro = Me.Vista.GetFocusedRowCellValue("Código")
        End If
        If MsgBox("Desea borrar el Artículo: " & Registro & " - " & Me.Vista.GetFocusedRowCellValue("Nombre"), MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            GruposCC.ArticuloCCDelete(Registro)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cargar()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim f As frmComprasCCReportes = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Start(Application.StartupPath & "\Ayuda\RegISInventario.chm")
        'Help.ShowHelp(Me, "ayuda/RegISInventario.chm")
    End Sub

    Private Sub Vista_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles Vista.FocusedRowChanged
        Registro = Me.Vista.GetFocusedRowCellValue("Código")
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.dgArticulos)
    End Sub
End Class
