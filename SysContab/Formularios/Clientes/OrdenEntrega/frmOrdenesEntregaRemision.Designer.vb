﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrdenesEntregaRemision
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenesEntregaRemision))
        Me.Numero = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cbProyectos = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.iVistaProyectos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ANombre = New DevExpress.XtraEditors.TextEdit()
        Me.cbMovimientos = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbDestino = New DevExpress.XtraEditors.LookUpEdit()
        Me.rTipo = New DevExpress.XtraEditors.RadioGroup()
        Me.txtOrden = New DevExpress.XtraEditors.TextEdit()
        Me.tTotalU = New DevExpress.XtraEditors.TextEdit()
        Me.tTotal = New DevExpress.XtraEditors.TextEdit()
        Me.tSubTotal = New DevExpress.XtraEditors.TextEdit()
        Me.tIva = New DevExpress.XtraEditors.TextEdit()
        Me.iGrid = New DevExpress.XtraGrid.GridControl()
        Me.iVista = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tPorcentaje = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.tMonto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cbItems = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rChkEntrega = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.txtReferencia = New DevExpress.XtraEditors.TextEdit()
        Me.txtNoPlaca = New DevExpress.XtraEditors.TextEdit()
        Me.txtConductor = New DevExpress.XtraEditors.TextEdit()
        Me.txtTransporte = New DevExpress.XtraEditors.TextEdit()
        Me.tTasa = New DevExpress.XtraEditors.TextEdit()
        Me.cbMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.txtDireccion = New DevExpress.XtraEditors.MemoEdit()
        Me.cbSucursal = New DevExpress.XtraEditors.LookUpEdit()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.cbCliente = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyTotal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyOrigen = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyDestino = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyMovimiento = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.Numero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cbProyectos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVistaProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTotalU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tIva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rChkEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoPlaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConductor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransporte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Numero
        '
        Me.Numero.Location = New System.Drawing.Point(814, 12)
        Me.Numero.Name = "Numero"
        Me.Numero.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Numero.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Maroon
        Me.Numero.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Numero.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.Numero.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.Numero.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.Numero.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Numero.Properties.ReadOnly = True
        Me.Numero.Size = New System.Drawing.Size(118, 24)
        Me.Numero.StyleController = Me.LayoutControl1
        Me.Numero.TabIndex = 5
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cbProyectos)
        Me.LayoutControl1.Controls.Add(Me.ANombre)
        Me.LayoutControl1.Controls.Add(Me.cbMovimientos)
        Me.LayoutControl1.Controls.Add(Me.cbDestino)
        Me.LayoutControl1.Controls.Add(Me.rTipo)
        Me.LayoutControl1.Controls.Add(Me.txtOrden)
        Me.LayoutControl1.Controls.Add(Me.tTotalU)
        Me.LayoutControl1.Controls.Add(Me.tTotal)
        Me.LayoutControl1.Controls.Add(Me.tSubTotal)
        Me.LayoutControl1.Controls.Add(Me.tIva)
        Me.LayoutControl1.Controls.Add(Me.iGrid)
        Me.LayoutControl1.Controls.Add(Me.txtReferencia)
        Me.LayoutControl1.Controls.Add(Me.txtNoPlaca)
        Me.LayoutControl1.Controls.Add(Me.txtConductor)
        Me.LayoutControl1.Controls.Add(Me.txtTransporte)
        Me.LayoutControl1.Controls.Add(Me.tTasa)
        Me.LayoutControl1.Controls.Add(Me.cbMoneda)
        Me.LayoutControl1.Controls.Add(Me.txtObservaciones)
        Me.LayoutControl1.Controls.Add(Me.txtDireccion)
        Me.LayoutControl1.Controls.Add(Me.cbSucursal)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Controls.Add(Me.cbCliente)
        Me.LayoutControl1.Controls.Add(Me.Numero)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(976, 211, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(944, 661)
        Me.LayoutControl1.TabIndex = 6
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbProyectos
        '
        Me.cbProyectos.Location = New System.Drawing.Point(118, 91)
        Me.cbProyectos.Name = "cbProyectos"
        Me.cbProyectos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProyectos.Properties.Appearance.Options.UseFont = True
        Me.cbProyectos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbProyectos.Properties.View = Me.iVistaProyectos
        Me.cbProyectos.Size = New System.Drawing.Size(814, 20)
        Me.cbProyectos.StyleController = Me.LayoutControl1
        Me.cbProyectos.TabIndex = 137
        '
        'iVistaProyectos
        '
        Me.iVistaProyectos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.iVistaProyectos.Name = "iVistaProyectos"
        Me.iVistaProyectos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.iVistaProyectos.OptionsView.ShowGroupPanel = False
        '
        'ANombre
        '
        Me.ANombre.Location = New System.Drawing.Point(580, 115)
        Me.ANombre.Name = "ANombre"
        Me.ANombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ANombre.Properties.Appearance.Options.UseFont = True
        Me.ANombre.Size = New System.Drawing.Size(352, 22)
        Me.ANombre.StyleController = Me.LayoutControl1
        Me.ANombre.TabIndex = 12
        '
        'cbMovimientos
        '
        Me.cbMovimientos.Location = New System.Drawing.Point(563, 67)
        Me.cbMovimientos.Name = "cbMovimientos"
        Me.cbMovimientos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMovimientos.Properties.Appearance.Options.UseFont = True
        Me.cbMovimientos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMovimientos.Properties.NullText = ""
        Me.cbMovimientos.Properties.ShowFooter = False
        Me.cbMovimientos.Size = New System.Drawing.Size(369, 20)
        Me.cbMovimientos.StyleController = Me.LayoutControl1
        Me.cbMovimientos.TabIndex = 127
        '
        'cbDestino
        '
        Me.cbDestino.Location = New System.Drawing.Point(118, 67)
        Me.cbDestino.Name = "cbDestino"
        Me.cbDestino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDestino.Size = New System.Drawing.Size(335, 20)
        Me.cbDestino.StyleController = Me.LayoutControl1
        Me.cbDestino.TabIndex = 16
        Me.cbDestino.Tag = ""
        '
        'rTipo
        '
        Me.rTipo.EditValue = 1
        Me.rTipo.Location = New System.Drawing.Point(343, 12)
        Me.rTipo.Name = "rTipo"
        Me.rTipo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rTipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rTipo.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rTipo.Properties.Appearance.Options.UseBackColor = True
        Me.rTipo.Properties.Appearance.Options.UseFont = True
        Me.rTipo.Properties.Appearance.Options.UseForeColor = True
        Me.rTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "REMISION"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "TRASLADO")})
        Me.rTipo.Size = New System.Drawing.Size(361, 25)
        Me.rTipo.StyleController = Me.LayoutControl1
        Me.rTipo.TabIndex = 187
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(814, 41)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOrden.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtOrden.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.txtOrden.Properties.Appearance.Options.UseBackColor = True
        Me.txtOrden.Properties.Appearance.Options.UseFont = True
        Me.txtOrden.Properties.Appearance.Options.UseForeColor = True
        Me.txtOrden.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOrden.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrden.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Maroon
        Me.txtOrden.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtOrden.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtOrden.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtOrden.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.txtOrden.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOrden.Properties.ReadOnly = True
        Me.txtOrden.Size = New System.Drawing.Size(118, 22)
        Me.txtOrden.StyleController = Me.LayoutControl1
        Me.txtOrden.TabIndex = 8
        '
        'tTotalU
        '
        Me.tTotalU.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.tTotalU.Location = New System.Drawing.Point(781, 627)
        Me.tTotalU.Name = "tTotalU"
        Me.tTotalU.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tTotalU.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTotalU.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.tTotalU.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.tTotalU.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.tTotalU.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.tTotalU.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.tTotalU.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tTotalU.Properties.Mask.EditMask = "n2"
        Me.tTotalU.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tTotalU.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tTotalU.Properties.ReadOnly = True
        Me.tTotalU.Size = New System.Drawing.Size(151, 22)
        Me.tTotalU.StyleController = Me.LayoutControl1
        Me.tTotalU.TabIndex = 200
        '
        'tTotal
        '
        Me.tTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.tTotal.Location = New System.Drawing.Point(781, 601)
        Me.tTotal.Name = "tTotal"
        Me.tTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tTotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.tTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.tTotal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.tTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.tTotal.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.tTotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tTotal.Properties.Mask.EditMask = "n2"
        Me.tTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tTotal.Properties.ReadOnly = True
        Me.tTotal.Size = New System.Drawing.Size(151, 22)
        Me.tTotal.StyleController = Me.LayoutControl1
        Me.tTotal.TabIndex = 199
        '
        'tSubTotal
        '
        Me.tSubTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.tSubTotal.Location = New System.Drawing.Point(781, 549)
        Me.tSubTotal.Name = "tSubTotal"
        Me.tSubTotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tSubTotal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSubTotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.tSubTotal.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.tSubTotal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.tSubTotal.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.tSubTotal.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.tSubTotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tSubTotal.Properties.Mask.EditMask = "n2"
        Me.tSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tSubTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tSubTotal.Properties.ReadOnly = True
        Me.tSubTotal.Size = New System.Drawing.Size(151, 22)
        Me.tSubTotal.StyleController = Me.LayoutControl1
        Me.tSubTotal.TabIndex = 197
        '
        'tIva
        '
        Me.tIva.EditValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.tIva.Location = New System.Drawing.Point(781, 575)
        Me.tIva.Name = "tIva"
        Me.tIva.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tIva.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tIva.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.tIva.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.tIva.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.tIva.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.tIva.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.tIva.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tIva.Properties.Mask.EditMask = "n2"
        Me.tIva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tIva.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.tIva.Properties.ReadOnly = True
        Me.tIva.Size = New System.Drawing.Size(151, 22)
        Me.tIva.StyleController = Me.LayoutControl1
        Me.tIva.TabIndex = 198
        '
        'iGrid
        '
        Me.iGrid.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid.Location = New System.Drawing.Point(12, 213)
        Me.iGrid.MainView = Me.iVista
        Me.iGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.iGrid.Name = "iGrid"
        Me.iGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.tPorcentaje, Me.tMonto, Me.cbItems, Me.rChkEntrega})
        Me.iGrid.Size = New System.Drawing.Size(920, 332)
        Me.iGrid.TabIndex = 7
        Me.iGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iVista})
        '
        'iVista
        '
        Me.iVista.GridControl = Me.iGrid
        Me.iVista.Name = "iVista"
        Me.iVista.OptionsView.ShowAutoFilterRow = True
        Me.iVista.OptionsView.ShowFooter = True
        Me.iVista.OptionsView.ShowGroupPanel = False
        '
        'tPorcentaje
        '
        Me.tPorcentaje.AutoHeight = False
        Me.tPorcentaje.Mask.EditMask = "p4"
        Me.tPorcentaje.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tPorcentaje.Mask.UseMaskAsDisplayFormat = True
        Me.tPorcentaje.Name = "tPorcentaje"
        '
        'tMonto
        '
        Me.tMonto.AutoHeight = False
        Me.tMonto.Mask.EditMask = "n4"
        Me.tMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tMonto.Mask.UseMaskAsDisplayFormat = True
        Me.tMonto.Name = "tMonto"
        '
        'cbItems
        '
        Me.cbItems.AutoHeight = False
        Me.cbItems.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbItems.Name = "cbItems"
        Me.cbItems.NullText = "[Seleccione Producto]"
        Me.cbItems.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'rChkEntrega
        '
        Me.rChkEntrega.AutoHeight = False
        Me.rChkEntrega.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.rChkEntrega.Name = "rChkEntrega"
        '
        'txtReferencia
        '
        Me.txtReferencia.EditValue = "True"
        Me.txtReferencia.Location = New System.Drawing.Point(563, 41)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Properties.Appearance.Options.UseFont = True
        Me.txtReferencia.Size = New System.Drawing.Size(141, 22)
        Me.txtReferencia.StyleController = Me.LayoutControl1
        Me.txtReferencia.TabIndex = 10
        '
        'txtNoPlaca
        '
        Me.txtNoPlaca.Location = New System.Drawing.Point(746, 189)
        Me.txtNoPlaca.Name = "txtNoPlaca"
        Me.txtNoPlaca.Size = New System.Drawing.Size(186, 20)
        Me.txtNoPlaca.StyleController = Me.LayoutControl1
        Me.txtNoPlaca.TabIndex = 9
        '
        'txtConductor
        '
        Me.txtConductor.Location = New System.Drawing.Point(580, 141)
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.Size = New System.Drawing.Size(352, 20)
        Me.txtConductor.StyleController = Me.LayoutControl1
        Me.txtConductor.TabIndex = 8
        '
        'txtTransporte
        '
        Me.txtTransporte.Location = New System.Drawing.Point(118, 141)
        Me.txtTransporte.Name = "txtTransporte"
        Me.txtTransporte.Size = New System.Drawing.Size(352, 20)
        Me.txtTransporte.StyleController = Me.LayoutControl1
        Me.txtTransporte.TabIndex = 7
        '
        'tTasa
        '
        Me.tTasa.Location = New System.Drawing.Point(118, 117)
        Me.tTasa.Name = "tTasa"
        Me.tTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tTasa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTasa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Maroon
        Me.tTasa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.tTasa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.tTasa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.tTasa.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.tTasa.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tTasa.Properties.Mask.EditMask = "n4"
        Me.tTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.tTasa.Properties.ReadOnly = True
        Me.tTasa.Size = New System.Drawing.Size(97, 22)
        Me.tTasa.StyleController = Me.LayoutControl1
        Me.tTasa.TabIndex = 7
        '
        'cbMoneda
        '
        Me.cbMoneda.Location = New System.Drawing.Point(746, 165)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMoneda.Size = New System.Drawing.Size(186, 20)
        Me.cbMoneda.StyleController = Me.LayoutControl1
        Me.cbMoneda.TabIndex = 12
        Me.cbMoneda.Tag = "True"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(12, 565)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Properties.MaxLength = 512
        Me.txtObservaciones.Size = New System.Drawing.Size(659, 84)
        Me.txtObservaciones.StyleController = Me.LayoutControl1
        Me.txtObservaciones.TabIndex = 12
        Me.txtObservaciones.Tag = "True"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(118, 165)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.MaxLength = 512
        Me.txtDireccion.Size = New System.Drawing.Size(518, 44)
        Me.txtDireccion.StyleController = Me.LayoutControl1
        Me.txtDireccion.TabIndex = 11
        Me.txtDireccion.Tag = ""
        '
        'cbSucursal
        '
        Me.cbSucursal.Location = New System.Drawing.Point(118, 41)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSucursal.Size = New System.Drawing.Size(335, 20)
        Me.cbSucursal.StyleController = Me.LayoutControl1
        Me.cbSucursal.TabIndex = 15
        Me.cbSucursal.Tag = "True"
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(118, 12)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Size = New System.Drawing.Size(115, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 9
        '
        'cbCliente
        '
        Me.cbCliente.Location = New System.Drawing.Point(118, 115)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCliente.Properties.View = Me.SearchLookUpEdit1View
        Me.cbCliente.Size = New System.Drawing.Size(352, 20)
        Me.cbCliente.StyleController = Me.LayoutControl1
        Me.cbCliente.TabIndex = 14
        Me.cbCliente.Tag = ""
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.tTasa
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 105)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(207, 26)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(207, 26)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(924, 26)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "T/Cambio:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(103, 13)
        Me.LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem13, Me.LayoutControlItem11, Me.LayoutControlItem2, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.lyTotal, Me.LayoutControlItem21, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem15, Me.lyOrigen, Me.lyDestino, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.lyMovimiento, Me.LayoutControlItem12, Me.LayoutControlItem22, Me.LayoutControlItem4, Me.LayoutControlItem18})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(944, 661)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Numero
        Me.LayoutControlItem1.Location = New System.Drawing.Point(696, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(228, 29)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(228, 29)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(228, 29)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "No. Remisión:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(103, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbCliente
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 103)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(462, 26)
        Me.LayoutControlItem3.Text = "Cliente:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(103, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtDireccion
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 153)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(628, 48)
        Me.LayoutControlItem5.Text = "Dirección de Entrega:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(103, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.iGrid
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 201)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(924, 336)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtNoPlaca
        Me.LayoutControlItem11.Location = New System.Drawing.Point(628, 177)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(296, 24)
        Me.LayoutControlItem11.Text = "No. Placa:"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(103, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Fecha
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(225, 29)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(225, 29)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(225, 29)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Fecha:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(103, 13)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.tSubTotal
        Me.LayoutControlItem19.Location = New System.Drawing.Point(663, 537)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(261, 26)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(261, 26)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(261, 26)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "Sub Total:"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(103, 13)
        Me.LayoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.tIva
        Me.LayoutControlItem20.Location = New System.Drawing.Point(663, 563)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(261, 26)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(261, 26)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(261, 26)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.Text = "Impuesto:"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(103, 13)
        Me.LayoutControlItem20.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lyTotal
        '
        Me.lyTotal.Control = Me.tTotal
        Me.lyTotal.Location = New System.Drawing.Point(663, 589)
        Me.lyTotal.MaxSize = New System.Drawing.Size(261, 26)
        Me.lyTotal.MinSize = New System.Drawing.Size(261, 26)
        Me.lyTotal.Name = "lyTotal"
        Me.lyTotal.Size = New System.Drawing.Size(261, 26)
        Me.lyTotal.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyTotal.Text = "Total:"
        Me.lyTotal.TextSize = New System.Drawing.Size(103, 13)
        Me.lyTotal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.tTotalU
        Me.LayoutControlItem21.Location = New System.Drawing.Point(663, 615)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(261, 26)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(261, 26)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(261, 26)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.Text = "Total U$:"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(103, 13)
        Me.LayoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtObservaciones
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 537)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(0, 104)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(107, 104)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(663, 104)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Observaciones:"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(103, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbMoneda
        Me.LayoutControlItem7.Location = New System.Drawing.Point(628, 153)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(296, 24)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(296, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(296, 24)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Moneda:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(103, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.rTipo
        Me.LayoutControlItem15.Location = New System.Drawing.Point(225, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(471, 29)
        Me.LayoutControlItem15.Text = "Entrega"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(103, 13)
        '
        'lyOrigen
        '
        Me.lyOrigen.Control = Me.cbSucursal
        Me.lyOrigen.Location = New System.Drawing.Point(0, 29)
        Me.lyOrigen.Name = "lyOrigen"
        Me.lyOrigen.Size = New System.Drawing.Size(445, 26)
        Me.lyOrigen.Text = "Sucursal:"
        Me.lyOrigen.TextSize = New System.Drawing.Size(103, 13)
        '
        'lyDestino
        '
        Me.lyDestino.Control = Me.cbDestino
        Me.lyDestino.Location = New System.Drawing.Point(0, 55)
        Me.lyDestino.Name = "lyDestino"
        Me.lyDestino.Size = New System.Drawing.Size(445, 24)
        Me.lyDestino.Text = "Destino:"
        Me.lyDestino.TextSize = New System.Drawing.Size(103, 13)
        Me.lyDestino.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtTransporte
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 129)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(462, 24)
        Me.LayoutControlItem9.Text = "Transporte:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(103, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtConductor
        Me.LayoutControlItem10.Location = New System.Drawing.Point(462, 129)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(462, 24)
        Me.LayoutControlItem10.Text = "Conductor:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(103, 13)
        '
        'lyMovimiento
        '
        Me.lyMovimiento.Control = Me.cbMovimientos
        Me.lyMovimiento.Location = New System.Drawing.Point(445, 55)
        Me.lyMovimiento.Name = "lyMovimiento"
        Me.lyMovimiento.Size = New System.Drawing.Size(479, 24)
        Me.lyMovimiento.Text = "Movimiento:"
        Me.lyMovimiento.TextSize = New System.Drawing.Size(103, 13)
        Me.lyMovimiento.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtReferencia
        Me.LayoutControlItem12.Location = New System.Drawing.Point(445, 29)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(251, 26)
        Me.LayoutControlItem12.Text = "No. Documento:"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(103, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtOrden
        Me.LayoutControlItem22.Location = New System.Drawing.Point(696, 29)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(228, 26)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(228, 26)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(228, 26)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.Text = "# Orden Entrega:"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(103, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ANombre
        Me.LayoutControlItem4.Location = New System.Drawing.Point(462, 103)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(462, 26)
        Me.LayoutControlItem4.Text = "A Nombre:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(103, 13)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cbProyectos
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 79)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(924, 24)
        Me.LayoutControlItem18.Text = "Proyecto:"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(103, 13)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("0c2d8b9b-5656-4dd4-b7fe-a8e52ea85f0a")
        Me.DockPanel1.Location = New System.Drawing.Point(944, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(140, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(140, 661)
        Me.DockPanel1.Text = "Opciones"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(131, 634)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.bSalir)
        Me.LayoutControl2.Controls.Add(Me.bExportar)
        Me.LayoutControl2.Controls.Add(Me.bGuardar)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(950, 175, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(131, 634)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'bSalir
        '
        Me.bSalir.ImageOptions.Image = CType(resources.GetObject("bSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(12, 584)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(107, 38)
        Me.bSalir.StyleController = Me.LayoutControl2
        Me.bSalir.TabIndex = 7
        Me.bSalir.Text = "&Salir"
        '
        'bExportar
        '
        Me.bExportar.ImageOptions.Image = CType(resources.GetObject("bExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(12, 542)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(107, 38)
        Me.bExportar.StyleController = Me.LayoutControl2
        Me.bExportar.TabIndex = 6
        Me.bExportar.Text = "E&xportar"
        '
        'bGuardar
        '
        Me.bGuardar.ImageOptions.Image = CType(resources.GetObject("bGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(12, 12)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(107, 38)
        Me.bGuardar.StyleController = Me.LayoutControl2
        Me.bGuardar.TabIndex = 4
        Me.bGuardar.Text = "&Guardar"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(131, 634)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.bGuardar
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.bExportar
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 530)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.bSalir
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 572)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(111, 42)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 42)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(111, 488)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmOrdenesEntregaRemision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.KeyPreview = True
        Me.Name = "frmOrdenesEntregaRemision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Numero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cbProyectos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVistaProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMovimientos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTotalU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tIva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rChkEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoPlaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConductor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransporte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Numero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbCliente As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyOrigen As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNoPlaca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtConductor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTransporte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtReferencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents iGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents iVista As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tPorcentaje As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents tMonto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cbItems As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents tTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tSubTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tIva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyTotal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tTotalU As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rChkEntrega As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents rTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbDestino As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lyDestino As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbMovimientos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lyMovimiento As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ANombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbProyectos As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents iVistaProyectos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
End Class