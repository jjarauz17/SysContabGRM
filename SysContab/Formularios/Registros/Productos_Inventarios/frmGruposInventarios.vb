Imports System.Diagnostics.Process
Public Class frmGruposInventarios
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmGruposInventarios = Nothing

    Public Shared Function Instance() As frmGruposInventarios
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmGruposInventarios
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
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGruposInventarios))
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bExportar
        '
        Me.bExportar.Enabled = False
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(424, 311)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(96, 38)
        Me.bExportar.StyleController = Me.LayoutControl1
        Me.bExportar.TabIndex = 7
        Me.bExportar.Text = "E&xportar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdSalir)
        Me.LayoutControl1.Controls.Add(Me.bExportar)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.cmdModificar)
        Me.LayoutControl1.Controls.Add(Me.cmdBorrar)
        Me.LayoutControl1.Controls.Add(Me.cmdImprimir)
        Me.LayoutControl1.Controls.Add(Me.cmdNuevo)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1001, 315, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(631, 361)
        Me.LayoutControl1.TabIndex = 10
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(524, 311)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(95, 38)
        Me.cmdSalir.StyleController = Me.LayoutControl1
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'iGrid
        '
        Me.iGrid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid.Location = New System.Drawing.Point(12, 12)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid.Name = "iGrid"
        Me.iGrid.Size = New System.Drawing.Size(607, 295)
        Me.iGrid.TabIndex = 9
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsBehavior.Editable = False
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Image = CType(resources.GetObject("cmdModificar.Image"), System.Drawing.Image)
        Me.cmdModificar.Location = New System.Drawing.Point(112, 311)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(96, 38)
        Me.cmdModificar.StyleController = Me.LayoutControl1
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Image = CType(resources.GetObject("cmdBorrar.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(312, 311)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(96, 38)
        Me.cmdBorrar.StyleController = Me.LayoutControl1
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(212, 311)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(96, 38)
        Me.cmdImprimir.StyleController = Me.LayoutControl1
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 311)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(96, 38)
        Me.cmdNuevo.StyleController = Me.LayoutControl1
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(631, 361)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.iGrid
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(611, 299)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdNuevo
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 299)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdModificar
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(100, 299)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdImprimir
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(200, 299)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdBorrar
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(300, 299)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bExportar
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(412, 299)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdSalir
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(512, 299)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(400, 299)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(12, 42)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmGruposInventarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(631, 361)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmGruposInventarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas
    Public Tipo As String

    Private Sub frmGruposInventarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'RolesDB.UsuarioAcciones(GroupBox1)
        RolesDB.UsuarioAcciones(LayoutControl1)
        ''

        'Dim Tabla As New DataTable

        '''r.CambiarEstilo(Me)
        'Tabla = ds.Tables("GRUPOS_INVENTARIO")

        ' r.FormatGenerico(dgGruposInventario, Tabla)

        'If ds.Tables("GRUPOS_INVENTARIO").Rows.Count <> 0 Then
        '    Registro = dgGruposInventario.Item(0, 0)
        'Else
        '    Registro = "Vacio"
        'End If

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name & Tipo)
        ' dgGruposInventario.CaptionText = TituloInv

        Cargar(TipoGrupoInv)
        iVista.PopulateColumns()
        FormatoGrid(iVista)

        ' iVista.Columns("Agregar").Visible = False

        If Tipo = "Productos" Then
            iVista.Columns("Utilidad").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            iVista.Columns("Utilidad").DisplayFormat.FormatString = "{0:p4}"

            iVista.Columns("Utilidad Mínima").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            iVista.Columns("Utilidad Mínima").DisplayFormat.FormatString = "{0:p4}"

            iVista.Columns("Utilidad Máxima").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            iVista.Columns("Utilidad Máxima").DisplayFormat.FormatString = "{0:p4}"

            iVista.Columns("Descuento_Ventas").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            iVista.Columns("Descuento_Ventas").DisplayFormat.FormatString = "{0:p4}"

            iVista.Columns("Descuento_Comercial").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            iVista.Columns("Descuento_Comercial").DisplayFormat.FormatString = "{0:p4}"
        End If
        
        Me.Text = TituloInv
        Me.Refresh()
    End Sub

    Public Sub Cargar(Tipo As String)
        'Dim ds As New DataSet
        Dim GruposInv As New VB.SysContab.Grupos_InventarioDB
        'ds = GruposInv.GetList(Tipo)

        iGrid.DataSource = GruposInv.GetList(Tipo) 'ds.Tables("GRUPOS_INVENTARIO").DefaultView
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarGrupoInvPruducto = frmAgregarGrupoInvPruducto.Instance
        Dim f1 As frmAgregarGrupoInvServicios = frmAgregarGrupoInvServicios.Instance

        Nuevo = "SI"

        If TipoGrupoInv = "P" Then
            'f.MdiParent = Me.MdiParent
            f.StartPosition = FormStartPosition.CenterScreen
            f.Text = "Agregar Grupo de Inventario..."
            f.ShowDialog()
            f.Dispose()
        ElseIf TipoGrupoInv = "S" Then
            f1.MdiParent = Me.MdiParent
            f1.Show()
        End If
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmAgregarGrupoInvPruducto = frmAgregarGrupoInvPruducto.Instance
        Dim f1 As frmAgregarGrupoInvServicios = frmAgregarGrupoInvServicios.Instance

        Nuevo = "NO"

        'If Registro = "Vacio" Then
        '    MsgBox("Seleccione el Grupo que desea Editar", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        Registro = iVista.GetFocusedRowCellValue("Código")

        If TipoGrupoInv = "P" Then
            'f.MdiParent = Me.MdiParent
            f.StartPosition = FormStartPosition.CenterScreen
            f.Text = "Editar Grupo de Inventario..."
            f.ShowDialog()
            f.Dispose()
        ElseIf TipoGrupoInv = "S" Then
            f1.MdiParent = Me.MdiParent
            f1.Show()
        End If

    End Sub

    Private Sub dgGruposInventario_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' Registro = dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0)

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim gruposInv As New VB.SysContab.Grupos_InventarioDB

        'dgGruposInventario.DataSource = gruposInv.GetListBuscar(txtBuscar.Text, TipoGrupoInv).Tables("GRUPOS_INVENTARIO").DefaultView


        'If gruposInv.GetListBuscar(txtBuscar.Text, TipoGrupoInv).Tables("Grupos_Inventario").Rows.Count = 0 Then
        '    Registro = "Vacio"
        '    Exit Sub

        'End If

        'Registro = dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0)

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        'Dim resp As DialogResult
        Dim gruposInv As New VB.SysContab.Grupos_InventarioDB

        'If Registro = "Vacio" Then
        '    MsgBox("Seleccione el Grupo que desea Borrar", MsgBoxStyle.Information)
        '    Exit Sub
        'End If


        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If

        Registro = iVista.GetFocusedRowCellValue("Código")

        Dim Codigo As String
        Dim Nivel As Integer
        Dim Temp As Boolean = False

        Codigo = iVista.GetFocusedRowCellValue("Código")    'dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0)

        Nivel = ObtieneDatos("SELECT Nivel FROM Grupos_Inventario WHERE Tipo = '" & IIf(Tipo = "Productos", "P", "S") & "' AND Empresa = " & EmpresaActual & " AND Codigo_Grupo = '" & Codigo & "'").Rows(0).Item(0)

        Select Case Nivel
            Case 1 : Temp = IIf(ObtieneDatos("SELECT ISNULL(COUNT(*),0) FROM Articulos WHERE Tipo = '" & IIf(Tipo = "Productos", "P", "S") & "' AND Empresa = " & EmpresaActual & " AND Linea = '" & Codigo & "'").Rows(0).Item(0) > 0, True, False)
            Case 2 : Temp = IIf(ObtieneDatos("SELECT ISNULL(COUNT(*),0) FROM Articulos WHERE Tipo = '" & IIf(Tipo = "Productos", "P", "S") & "' AND Empresa = " & EmpresaActual & " AND Grupo = '" & Codigo & "'").Rows(0).Item(0) > 0, True, False)
            Case 3 : Temp = IIf(ObtieneDatos("SELECT ISNULL(COUNT(*),0) FROM Articulos WHERE Tipo = '" & IIf(Tipo = "Productos", "P", "S") & "' AND Empresa = " & EmpresaActual & " AND SubGrupo = '" & Codigo & "'").Rows(0).Item(0) > 0, True, False)
        End Select

        If (ObtieneDatos("SELECT ISNULL(COUNT(*),0) FROM Grupos_Inventario WHERE Empresa = " & EmpresaActual & " AND Codigo_Grupo Like '" & Codigo & "%'").Rows(0).Item(0) > 1) Or Temp Then
            XtraMsg("No puede borrar el registro...", MessageBoxIcon.Error)
            Exit Sub
        End If

        'resp = MsgBox("Esta seguro que dese borrar el Grupo: " & dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0) & " - " & dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        'If resp = DialogResult.No Then
        '    Exit Sub
        'End If

        If Not XtraMsg2("Esta seguro que dese borrar el Grupo: " & iVista.GetFocusedRowCellValue("Código") & " - " & iVista.GetFocusedRowCellValue("Nombre")) Then
            Exit Sub
        End If

        'gruposInv.Delete(dgGruposInventario.Item(dgGruposInventario.CurrentRowIndex, 0), TipoGrupoInv)

        gruposInv.Delete(iVista.GetFocusedRowCellValue("Código"), TipoGrupoInv)
        Cargar(TipoGrupoInv)

        'MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        'Dim Tabla As New DataTable
        'Dim ds As New DataSet

        ''r.CambiarEstilo(Me)

        'ds = gruposInv.GetList(TipoGrupoInv)

        'dgGruposInventario.DataSource = gruposInv.GetList(TipoGrupoInv).Tables("GRUPOS_INVENTARIO").DefaultView
        'Tabla = ds.Tables("GRUPOS_INVENTARIO")

        'If ds.Tables("GRUPOS_INVENTARIO").Rows.Count = 0 Then
        '    Registro = "Vacio"
        'Else
        '    Registro = dgGruposInventario.Item(0, 0)

        'End If

        'r.FormatGenerico(dgGruposInventario, Tabla)

    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmGruposInventarios_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        TipoGrupoInv = "Vacio"
        '
    End Sub

    Private Sub frmGruposInventarios_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '
    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        '
    End Sub

    Private Sub dgGruposInventario_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        '
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'Dim fReportes As New frmReportes
        ''Dim rGruposInventario As New rptGruposInventario
        'Dim GruposInventario As New VB.SysContab.Grupos_InventarioDB
        'Dim rGruposInventario As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'rGruposInventario.Load(Application.StartupPath & "\Reportes\rptGruposInventario.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        'rGruposInventario.SetDataSource(GruposInventario.GetListReporte("", EmpresaActual, TipoGrupoInv))
        'fReportes.crvReportes.ReportSource = rGruposInventario
        'fReportes.Show()

        VistaPrevia(iGrid, Me.Text)
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExportar.Click

        frmExportarImprimir.Mostrar(iGrid, Me.Text)

        'If Tipo = "Productos" Then
        '    Start(Application.StartupPath & "\Ayuda\RegISGrupoProd.chm")
        '    'Help.ShowHelp(Me, "Ayuda/RegISGrupoProd.chm")
        'ElseIf Tipo = "Servicios" Then
        '    Start(Application.StartupPath & "\Ayuda\RegISGrupoServ.chm")
        '    'Help.ShowHelp(Me, "Ayuda/RegISGrupoServ.chm")
        'End If
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Tipo" Then
            If iVista.GetRowCellValue(e.RowHandle, "Tipo") = "Grupo" Then
                'e.Appearance.BackColor = Color.Salmon
                e.Appearance.ForeColor = Color.DarkRed
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                e.Appearance.Font = New Font("Thaoma", 9, FontStyle.Bold)
            Else
                e.Appearance.ForeColor = Color.DarkBlue
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                e.Appearance.Font = New Font("Thaoma", 9, FontStyle.Bold)
            End If
        End If
    End Sub
End Class
