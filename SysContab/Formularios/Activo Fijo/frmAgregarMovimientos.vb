Public Class frmAgregarMovimientos
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
    Friend WithEvents cbTipoMovimiento As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents txtValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents vTipoMovimiento As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarMovimientos))
        Me.cbTipoMovimiento = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vTipoMovimiento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtValor = New DevExpress.XtraEditors.TextEdit()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.deFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.cbTipoMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vTipoMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbTipoMovimiento
        '
        Me.cbTipoMovimiento.EditValue = ""
        Me.cbTipoMovimiento.Location = New System.Drawing.Point(112, 12)
        Me.cbTipoMovimiento.Name = "cbTipoMovimiento"
        Me.cbTipoMovimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipoMovimiento.Properties.NullText = ""
        Me.cbTipoMovimiento.Properties.PopupFormMinSize = New System.Drawing.Size(488, 0)
        Me.cbTipoMovimiento.Properties.ShowFooter = False
        Me.cbTipoMovimiento.Properties.View = Me.vTipoMovimiento
        Me.cbTipoMovimiento.Size = New System.Drawing.Size(334, 20)
        Me.cbTipoMovimiento.StyleController = Me.LayoutControl1
        Me.cbTipoMovimiento.TabIndex = 1
        '
        'vTipoMovimiento
        '
        Me.vTipoMovimiento.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vTipoMovimiento.Name = "vTipoMovimiento"
        Me.vTipoMovimiento.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vTipoMovimiento.OptionsView.ShowGroupPanel = False
        '
        'txtValor
        '
        Me.txtValor.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(112, 60)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtValor.Properties.Appearance.Options.UseFont = True
        Me.txtValor.Properties.Appearance.Options.UseForeColor = True
        Me.txtValor.Properties.Mask.EditMask = "n2"
        Me.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtValor.Size = New System.Drawing.Size(148, 22)
        Me.txtValor.StyleController = Me.LayoutControl1
        Me.txtValor.TabIndex = 19
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(112, 86)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(334, 85)
        Me.txtConcepto.StyleController = Me.LayoutControl1
        Me.txtConcepto.TabIndex = 20
        '
        'cmdAceptar
        '
        Me.cmdAceptar.ImageOptions.Image = CType(resources.GetObject("cmdAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(260, 222)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(89, 38)
        Me.cmdAceptar.StyleController = Me.LayoutControl1
        Me.cmdAceptar.TabIndex = 23
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(353, 222)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(93, 38)
        Me.cmdCancelar.StyleController = Me.LayoutControl1
        Me.cmdCancelar.TabIndex = 24
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.Location = New System.Drawing.Point(112, 36)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deFecha.Properties.Appearance.Options.UseFont = True
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Size = New System.Drawing.Size(148, 20)
        Me.deFecha.StyleController = Me.LayoutControl1
        Me.deFecha.TabIndex = 27
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdCancelar)
        Me.LayoutControl1.Controls.Add(Me.cmdAceptar)
        Me.LayoutControl1.Controls.Add(Me.deFecha)
        Me.LayoutControl1.Controls.Add(Me.txtConcepto)
        Me.LayoutControl1.Controls.Add(Me.cbTipoMovimiento)
        Me.LayoutControl1.Controls.Add(Me.txtValor)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(695, 165, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(458, 272)
        Me.LayoutControl1.TabIndex = 28
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(458, 272)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cbTipoMovimiento
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(438, 24)
        Me.LayoutControlItem1.Text = "Tipo de Movimiento:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(96, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 163)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(438, 47)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.deFecha
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(252, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(252, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(252, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Fecha:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtValor
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(252, 26)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(252, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(252, 26)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Valor:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtConcepto
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(438, 89)
        Me.LayoutControlItem4.Text = "Concepto:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdAceptar
        Me.LayoutControlItem5.Location = New System.Drawing.Point(248, 210)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(93, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(93, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(93, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdCancelar
        Me.LayoutControlItem6.Location = New System.Drawing.Point(341, 210)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(97, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(252, 48)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(186, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(252, 24)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(186, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 210)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(248, 42)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmAgregarMovimientos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(458, 272)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmAgregarMovimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarMovimientos"
        CType(Me.cbTipoMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vTipoMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Variables"
    Public Shared Modo As String = "A"
    Public Shared Consecutivo As Integer = 0
    Public Shared Valor As Double = 0
    Public Cargado As Boolean = False
#End Region
    Private Sub frmAgregarMovimientos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cbTipoMovimiento.Properties.DataSource = VB.SysContab.Activo_FijosDB.GetListTransaccion
        Me.cbTipoMovimiento.Properties.DisplayMember = "Descripción"
        Me.cbTipoMovimiento.Properties.ValueMember = "Codigo"
        Me.cbTipoMovimiento.Properties.PopulateViewColumns()
        Me.vTipoMovimiento.Columns("Codigo").Width = 50
        Me.vTipoMovimiento.Columns("Descripción").Width = 150
        Me.vTipoMovimiento.Columns("Signo").Width = 50
        Me.vTipoMovimiento.Columns("Cuenta Contable").Width = 150

        If Modo = "A" Then
            Me.deFecha.EditValue = Today
            Me.cmdAceptar.Enabled = True
        Else
            Me.cmdAceptar.Enabled = False
            Dim dt As New DataTable
            dt = VB.SysContab.Activo_FijosDB.GetMovimientoDetalle(Consecutivo)
            If dt Is Nothing Then
                XtraMsg("Hubo un error al intentar recuperar la información de este movimiento", MessageBoxIcon.Error)
            Else
                If dt.Rows.Count = 0 Then
                    XtraMsg("No hay detalle que mostrar", MessageBoxIcon.Error)
                Else
                    Me.cbTipoMovimiento.EditValue = dt.Rows(0)("trv_codigo")
                    Me.deFecha.EditValue = dt.Rows(0)("fecha")
                    Me.txtValor.EditValue = dt.Rows(0)("valor")
                    Me.txtConcepto.Text = dt.Rows(0)("concepto")
                End If

            End If

        End If
        Cargado = True
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim valor As Double

        If Me.txtValor.EditValue = 0.0 Then
            XtraMsg("El Valor debe ser mayor que Cero (0).", MessageBoxIcon.Warning)
            Exit Sub
        Else
            Try
                valor = Me.txtValor.EditValue

                If Me.cbTipoMovimiento.EditValue = 1 Or Me.cbTipoMovimiento.EditValue = 2 Then
                    If Me.vTipoMovimiento.GetFocusedRowCellValue("Signo") = "-" Then
                        valor = valor * 1
                    ElseIf Me.vTipoMovimiento.GetFocusedRowCellValue("Signo") = "+" Then
                        valor = valor * 1
                    End If
                End If

            Catch ex As Exception
                XtraMsg("El valor no corresponde a un Número valido", MessageBoxIcon.Warning)
                Exit Sub
            End Try
        End If

        If Me.cbTipoMovimiento.EditValue Is Nothing Then
            XtraMsg("Seleccione por favor el tipo de movimiento a aplicar")
            Exit Sub
        End If

        If Me.deFecha.EditValue Is Nothing Then
            XtraMsg("Favor seleccionar la fecha de la transacción")
            Exit Sub
        End If

        If Me.txtConcepto.Text.Length = 0 Then
            XtraMsg("Favor digitar el concepto o descripción del movimiento")
            Exit Sub
        End If

        Dim dt As New DataTable
        dt = VB.SysContab.Activo_FijosDB.ContarMovimientosxTipo(Registro)

        If Not dt Is Nothing Then
            If Me.cbTipoMovimiento.EditValue = 3 Then
                If dt.Rows(0)("Venta") <> 0 Then
                    XtraMsg("No se puede registrar otra transaccion de Venta cuando una esta pendiente de revisión", MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
            If Me.cbTipoMovimiento.EditValue = 4 Then
                If dt.Rows(0)("Baja") <> 0 Then
                    XtraMsg("No se puede registrar otra transaccion de Baja cuando una esta pendiente de revisión", MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
        End If

        VB.SysContab.Activo_FijosDB.TranValor_Add(Registro, _
            Me.cbTipoMovimiento.EditValue, _
            Me.deFecha.EditValue, _
            valor, _
            Me.txtConcepto.Text)
        Me.Close()
    End Sub

    Private Sub cbTipoMovimiento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoMovimiento.EditValueChanged
        If Cargado Then
            If Me.cbTipoMovimiento.EditValue = 1 Or Me.cbTipoMovimiento.EditValue = 2 Then
                Me.txtValor.Enabled = True
                Me.txtValor.EditValue = 0.0
            Else
                Me.txtValor.Enabled = True
                Me.txtValor.EditValue = Valor
            End If
        End If
    End Sub
End Class
