<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotasDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotasDetalle))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Fecha = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.gridDatos = New DevExpress.XtraGrid.GridControl()
        Me.vDatos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Comentario = New DevExpress.XtraEditors.MemoEdit()
        Me.Moneda = New DevExpress.XtraEditors.TextEdit()
        Me.Monto = New DevExpress.XtraEditors.TextEdit()
        Me.Tipo = New DevExpress.XtraEditors.TextEdit()
        Me.Cliente = New DevExpress.XtraEditors.TextEdit()
        Me.Numero = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Comentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Moneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Monto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.bExportar)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.Fecha)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.gridDatos)
        Me.LayoutControl1.Controls.Add(Me.Comentario)
        Me.LayoutControl1.Controls.Add(Me.Moneda)
        Me.LayoutControl1.Controls.Add(Me.Monto)
        Me.LayoutControl1.Controls.Add(Me.Tipo)
        Me.LayoutControl1.Controls.Add(Me.Cliente)
        Me.LayoutControl1.Controls.Add(Me.Numero)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(656, 530)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bExportar
        '
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.bExportar.Location = New System.Drawing.Point(318, 480)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(108, 38)
        Me.bExportar.StyleController = Me.LayoutControl1
        Me.bExportar.TabIndex = 15
        Me.bExportar.Text = "E&xportar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Options.UseTextOptions = True
        Me.SimpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.SimpleButton2.Location = New System.Drawing.Point(430, 480)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(115, 38)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 14
        Me.SimpleButton2.Text = "&Imprimir Comprobante"
        '
        'Fecha
        '
        Me.Fecha.EditValue = Nothing
        Me.Fecha.Location = New System.Drawing.Point(391, 72)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.Fecha.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Fecha.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Fecha.Properties.ReadOnly = True
        Me.Fecha.Size = New System.Drawing.Size(241, 20)
        Me.Fecha.StyleController = Me.LayoutControl1
        Me.Fecha.TabIndex = 13
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.SimpleButton1.Location = New System.Drawing.Point(549, 480)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(95, 38)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "&Salir"
        '
        'gridDatos
        '
        Me.gridDatos.Location = New System.Drawing.Point(24, 268)
        Me.gridDatos.MainView = Me.vDatos
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.Size = New System.Drawing.Size(608, 196)
        Me.gridDatos.TabIndex = 11
        Me.gridDatos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vDatos, Me.GridView2})
        '
        'vDatos
        '
        Me.vDatos.GridControl = Me.gridDatos
        Me.vDatos.Name = "vDatos"
        Me.vDatos.OptionsBehavior.Editable = False
        Me.vDatos.OptionsView.ShowFooter = True
        Me.vDatos.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gridDatos
        Me.GridView2.Name = "GridView2"
        '
        'Comentario
        '
        Me.Comentario.Location = New System.Drawing.Point(86, 170)
        Me.Comentario.Name = "Comentario"
        Me.Comentario.Size = New System.Drawing.Size(546, 51)
        Me.Comentario.StyleController = Me.LayoutControl1
        Me.Comentario.TabIndex = 10
        '
        'Moneda
        '
        Me.Moneda.Location = New System.Drawing.Point(86, 146)
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.Moneda.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Moneda.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Moneda.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.Moneda.Properties.ReadOnly = True
        Me.Moneda.Size = New System.Drawing.Size(546, 20)
        Me.Moneda.StyleController = Me.LayoutControl1
        Me.Moneda.TabIndex = 9
        '
        'Monto
        '
        Me.Monto.Location = New System.Drawing.Point(86, 120)
        Me.Monto.Name = "Monto"
        Me.Monto.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.Monto.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Monto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.Monto.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Monto.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.Monto.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.Monto.Properties.Mask.EditMask = "n2"
        Me.Monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Monto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Monto.Properties.ReadOnly = True
        Me.Monto.Size = New System.Drawing.Size(239, 22)
        Me.Monto.StyleController = Me.LayoutControl1
        Me.Monto.TabIndex = 8
        '
        'Tipo
        '
        Me.Tipo.Location = New System.Drawing.Point(86, 42)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.Tipo.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.Tipo.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Tipo.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.Tipo.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.Tipo.Properties.AppearanceReadOnly.Options.UseTextOptions = True
        Me.Tipo.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Tipo.Properties.ReadOnly = True
        Me.Tipo.Size = New System.Drawing.Size(546, 26)
        Me.Tipo.StyleController = Me.LayoutControl1
        Me.Tipo.TabIndex = 7
        '
        'Cliente
        '
        Me.Cliente.Location = New System.Drawing.Point(86, 96)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.Cliente.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cliente.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Cliente.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.Cliente.Properties.ReadOnly = True
        Me.Cliente.Size = New System.Drawing.Size(546, 20)
        Me.Cliente.StyleController = Me.LayoutControl1
        Me.Cliente.TabIndex = 6
        '
        'Numero
        '
        Me.Numero.Location = New System.Drawing.Point(86, 72)
        Me.Numero.Name = "Numero"
        Me.Numero.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.Numero.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Numero.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.Numero.Properties.ReadOnly = True
        Me.Numero.Size = New System.Drawing.Size(239, 20)
        Me.Numero.StyleController = Me.LayoutControl1
        Me.Numero.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlItem9, Me.EmptySpaceItem1, Me.LayoutControlItem10, Me.LayoutControlItem11})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(656, 530)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "DATOS DE LA NOTA"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(636, 225)
        Me.LayoutControlGroup2.Text = "DATOS DE LA NOTA"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Numero
        Me.LayoutControlItem1.CustomizationFormText = "Número:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(305, 24)
        Me.LayoutControlItem1.Text = "Número:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(59, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Cliente
        Me.LayoutControlItem3.CustomizationFormText = "Cliente:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 54)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(612, 24)
        Me.LayoutControlItem3.Text = "Cliente:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(59, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Monto
        Me.LayoutControlItem5.CustomizationFormText = "Monto:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(305, 26)
        Me.LayoutControlItem5.Text = "Monto:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(59, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Moneda
        Me.LayoutControlItem6.CustomizationFormText = "Moneda:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(612, 24)
        Me.LayoutControlItem6.Text = "Moneda:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(59, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Comentario
        Me.LayoutControlItem7.CustomizationFormText = "Comentario:"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 128)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(612, 55)
        Me.LayoutControlItem7.Text = "Comentario:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(59, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Fecha
        Me.LayoutControlItem2.CustomizationFormText = "Fecha:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(305, 30)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(307, 24)
        Me.LayoutControlItem2.Text = "Fecha:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(59, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Tipo
        Me.LayoutControlItem4.CustomizationFormText = "Tipo:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(612, 30)
        Me.LayoutControlItem4.Text = "Tipo:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(59, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(305, 78)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(307, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup3.AppearanceGroup.ForeColor = System.Drawing.Color.Crimson
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup3.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup3.CustomizationFormText = "DETALLE DE LA NOTA"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 225)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(636, 243)
        Me.LayoutControlGroup3.Text = "DETALLE DE LA NOTA"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.gridDatos
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(612, 200)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SimpleButton1
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(537, 468)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(99, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 468)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(306, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SimpleButton2
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(418, 468)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(119, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(119, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(119, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.bExportar
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(306, 468)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(112, 42)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'frmNotasDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 530)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNotasDetalle"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "INFORMACION NOTAS DEBITO/CREDITO"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Fecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Comentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Moneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Monto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Comentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Moneda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Monto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Tipo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Numero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gridDatos As DevExpress.XtraGrid.GridControl
    Friend WithEvents vDatos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
End Class
