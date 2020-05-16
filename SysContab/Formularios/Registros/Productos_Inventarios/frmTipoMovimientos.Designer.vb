<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoMovimientos
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipoMovimientos))
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.cbCatalogo1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.vCat1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbTipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkAjuste = New DevExpress.XtraEditors.CheckEdit()
        Me.cbClases = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnQuit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.chkProyecto = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCatalogo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vCat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAjuste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbClases.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkProyecto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl6.Location = New System.Drawing.Point(94, 32)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(147, 23)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtNombre.Properties.Appearance.Options.UseFont = True
        Me.txtNombre.Properties.Appearance.Options.UseForeColor = True
        Me.txtNombre.Size = New System.Drawing.Size(416, 22)
        Me.txtNombre.TabIndex = 0
        '
        'cbCatalogo1
        '
        Me.cbCatalogo1.Location = New System.Drawing.Point(147, 53)
        Me.cbCatalogo1.Name = "cbCatalogo1"
        Me.cbCatalogo1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo1.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbCatalogo1.Properties.Appearance.Options.UseFont = True
        Me.cbCatalogo1.Properties.Appearance.Options.UseForeColor = True
        Me.cbCatalogo1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCatalogo1.Properties.NullText = "--- Seleccione Cuenta ---"
        Me.cbCatalogo1.Properties.PopupFormMinSize = New System.Drawing.Size(800, 0)
        Me.cbCatalogo1.Properties.View = Me.vCat1
        Me.cbCatalogo1.Size = New System.Drawing.Size(416, 22)
        Me.cbCatalogo1.TabIndex = 1
        '
        'vCat1
        '
        Me.vCat1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vCat1.Name = "vCat1"
        Me.vCat1.OptionsBehavior.Editable = False
        Me.vCat1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.vCat1.OptionsView.ShowGroupPanel = False
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.chkProyecto)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.cbTipo)
        Me.GroupControl1.Controls.Add(Me.chkAjuste)
        Me.GroupControl1.Controls.Add(Me.cbClases)
        Me.GroupControl1.Controls.Add(Me.txtNombre)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.cbCatalogo1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(582, 159)
        Me.GroupControl1.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl3.Location = New System.Drawing.Point(34, 114)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Tipo Comprobante:"
        '
        'cbTipo
        '
        Me.cbTipo.Location = New System.Drawing.Point(147, 107)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipo.Size = New System.Drawing.Size(416, 20)
        Me.cbTipo.TabIndex = 10
        '
        'chkAjuste
        '
        Me.chkAjuste.Location = New System.Drawing.Point(93, 132)
        Me.chkAjuste.Name = "chkAjuste"
        Me.chkAjuste.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAjuste.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkAjuste.Properties.Appearance.Options.UseFont = True
        Me.chkAjuste.Properties.Appearance.Options.UseForeColor = True
        Me.chkAjuste.Properties.Caption = "Ajuste"
        Me.chkAjuste.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkAjuste.Size = New System.Drawing.Size(75, 22)
        Me.chkAjuste.TabIndex = 9
        '
        'cbClases
        '
        Me.cbClases.Location = New System.Drawing.Point(147, 81)
        Me.cbClases.Name = "cbClases"
        Me.cbClases.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClases.Properties.Appearance.Options.UseFont = True
        Me.cbClases.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Borrar Datos", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "Editar/Cambiar  Datos", Nothing, Nothing, False), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "Agregar Nuevo Movimiento", Nothing, Nothing, False)})
        Me.cbClases.Properties.NullText = ""
        Me.cbClases.Properties.ShowFooter = False
        Me.cbClases.Size = New System.Drawing.Size(416, 20)
        Me.cbClases.TabIndex = 8
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl2.Location = New System.Drawing.Point(108, 88)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Clase:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(98, 62)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Cuenta:"
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Image = CType(resources.GetObject("btnQuit.Image"), System.Drawing.Image)
        Me.btnQuit.Location = New System.Drawing.Point(502, 178)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(92, 36)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "&Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(404, 178)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 36)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "&Guardar"
        '
        'chkProyecto
        '
        Me.chkProyecto.Location = New System.Drawing.Point(174, 132)
        Me.chkProyecto.Name = "chkProyecto"
        Me.chkProyecto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProyecto.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.chkProyecto.Properties.Appearance.Options.UseFont = True
        Me.chkProyecto.Properties.Appearance.Options.UseForeColor = True
        Me.chkProyecto.Properties.Caption = "Proyectos"
        Me.chkProyecto.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.chkProyecto.Size = New System.Drawing.Size(113, 22)
        Me.chkProyecto.TabIndex = 12
        '
        'frmTipoMovimientos
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(606, 225)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmTipoMovimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "*** MOVIMIENTOS DE INVENTARIO ***"
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCatalogo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vCat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAjuste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbClases.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkProyecto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbCatalogo1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents vCat1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnQuit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbClases As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkAjuste As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkProyecto As DevExpress.XtraEditors.CheckEdit
End Class
