<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirmasContables_Agregar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.spOrden = New DevExpress.XtraEditors.SpinEdit
        Me.txtCargo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        CType(Me.spOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAceptar.Location = New System.Drawing.Point(142, 143)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Location = New System.Drawing.Point(223, 143)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 4
        Me.cmdSalir.Text = "&Salir"
        '
        'spOrden
        '
        Me.spOrden.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spOrden.Location = New System.Drawing.Point(69, 84)
        Me.spOrden.Name = "spOrden"
        Me.spOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spOrden.Properties.IsFloatValue = False
        Me.spOrden.Properties.Mask.EditMask = "N00"
        Me.spOrden.Properties.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.spOrden.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spOrden.Size = New System.Drawing.Size(100, 20)
        Me.spOrden.TabIndex = 2
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(69, 32)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Properties.MaxLength = 50
        Me.txtCargo.Size = New System.Drawing.Size(320, 20)
        Me.txtCargo.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(23, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Cargo:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(69, 58)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.MaxLength = 50
        Me.txtNombre.Size = New System.Drawing.Size(320, 20)
        Me.txtNombre.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(22, 91)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Orden:"
        '
        'frmFirmasContables_Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(462, 190)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.spOrden)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Name = "frmFirmasContables_Agregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar/Modificar Firmas Contables"
        CType(Me.spOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents spOrden As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtCargo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
