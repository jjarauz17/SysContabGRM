<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnularChequeProcesado
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.dFecha = New DevExpress.XtraEditors.DateEdit()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bAnular = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBanco = New DevExpress.XtraEditors.TextEdit()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.txtMoneda = New DevExpress.XtraEditors.TextEdit()
        Me.dgDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtNoCheque = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dFecha)
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.bAnular)
        Me.LayoutControl1.Controls.Add(Me.txtBanco)
        Me.LayoutControl1.Controls.Add(Me.txtConcepto)
        Me.LayoutControl1.Controls.Add(Me.txtMoneda)
        Me.LayoutControl1.Controls.Add(Me.dgDatos)
        Me.LayoutControl1.Controls.Add(Me.txtMonto)
        Me.LayoutControl1.Controls.Add(Me.txtNombre)
        Me.LayoutControl1.Controls.Add(Me.txtNoCheque)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(821, 168, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(641, 460)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'dFecha
        '
        Me.dFecha.EditValue = Nothing
        Me.dFecha.Location = New System.Drawing.Point(97, 382)
        Me.dFecha.Name = "dFecha"
        Me.dFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dFecha.Properties.Appearance.Options.UseFont = True
        Me.dFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dFecha.Size = New System.Drawing.Size(149, 22)
        Me.dFecha.StyleController = Me.LayoutControl1
        Me.dFecha.TabIndex = 10
        '
        'bSalir
        '
        Me.bSalir.Image = Global.SysContab.My.Resources.Resources._115
        Me.bSalir.Location = New System.Drawing.Point(537, 410)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(92, 38)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 9
        Me.bSalir.Text = "&Salir"
        '
        'bAnular
        '
        Me.bAnular.Image = Global.SysContab.My.Resources.Resources._114
        Me.bAnular.Location = New System.Drawing.Point(441, 410)
        Me.bAnular.Name = "bAnular"
        Me.bAnular.Size = New System.Drawing.Size(92, 38)
        Me.bAnular.StyleController = Me.LayoutControl1
        Me.bAnular.TabIndex = 8
        Me.bAnular.Text = "&Anular"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(97, 36)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtBanco.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBanco.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtBanco.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtBanco.Properties.ReadOnly = True
        Me.txtBanco.Size = New System.Drawing.Size(532, 20)
        Me.txtBanco.StyleController = Me.LayoutControl1
        Me.txtBanco.TabIndex = 6
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(97, 108)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtConcepto.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtConcepto.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtConcepto.Properties.ReadOnly = True
        Me.txtConcepto.Size = New System.Drawing.Size(532, 46)
        Me.txtConcepto.StyleController = Me.LayoutControl1
        Me.txtConcepto.TabIndex = 7
        '
        'txtMoneda
        '
        Me.txtMoneda.Location = New System.Drawing.Point(290, 84)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtMoneda.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoneda.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMoneda.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtMoneda.Properties.ReadOnly = True
        Me.txtMoneda.Size = New System.Drawing.Size(339, 20)
        Me.txtMoneda.StyleController = Me.LayoutControl1
        Me.txtMoneda.TabIndex = 6
        '
        'dgDatos
        '
        Me.dgDatos.Location = New System.Drawing.Point(12, 158)
        Me.dgDatos.MainView = Me.vDatos
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(617, 220)
        Me.dgDatos.TabIndex = 6
        Me.dgDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.dgDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsBehavior.Editable = False
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(97, 84)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMonto.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.txtMonto.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtMonto.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtMonto.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtMonto.Properties.Mask.EditMask = "n2"
        Me.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMonto.Properties.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(104, 20)
        Me.txtMonto.StyleController = Me.LayoutControl1
        Me.txtMonto.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(97, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNombre.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtNombre.Properties.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(532, 20)
        Me.txtNombre.StyleController = Me.LayoutControl1
        Me.txtNombre.TabIndex = 5
        '
        'txtNoCheque
        '
        Me.txtNoCheque.Location = New System.Drawing.Point(97, 12)
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtNoCheque.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCheque.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNoCheque.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtNoCheque.Properties.ReadOnly = True
        Me.txtNoCheque.Size = New System.Drawing.Size(106, 20)
        Me.txtNoCheque.StyleController = Me.LayoutControl1
        Me.txtNoCheque.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.SimpleSeparator1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(641, 460)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtNoCheque
        Me.LayoutControlItem1.CustomizationFormText = "#Cheque:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "#Cheque:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtNombre
        Me.LayoutControlItem2.CustomizationFormText = "A nombre:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(621, 24)
        Me.LayoutControlItem2.Text = "A nombre:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtMonto
        Me.LayoutControlItem3.CustomizationFormText = "Monto:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Monto:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dgDatos
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 146)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(621, 224)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(195, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(426, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtMoneda
        Me.LayoutControlItem5.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(193, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(428, 24)
        Me.LayoutControlItem5.Text = "Moneda:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtConcepto
        Me.LayoutControlItem6.CustomizationFormText = "Concepto:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(0, 50)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(99, 50)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(621, 50)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Concepto:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtBanco
        Me.LayoutControlItem7.CustomizationFormText = "Banco:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(621, 24)
        Me.LayoutControlItem7.Text = "Banco:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(82, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.bAnular
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(429, 398)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.bSalir
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(525, 398)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(96, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.dFecha
        Me.LayoutControlItem10.CustomizationFormText = "Fecha Anulación:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 370)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(238, 26)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(238, 26)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(238, 26)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Fecha Anulación:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(82, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(238, 370)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(383, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 398)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(429, 42)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 396)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(621, 2)
        '
        'frmAnularChequeProcesado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 460)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAnularChequeProcesado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ANULAR CHEQUE PROCESADO ***"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtNoCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dgDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtMoneda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtBanco As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bAnular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
End Class
