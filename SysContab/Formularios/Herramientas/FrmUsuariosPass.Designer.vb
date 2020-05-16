<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuariosPass
    Inherits DevExpress.XtraEditors.XtraForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtusuario = New DevExpress.XtraEditors.TextEdit
        Me.txtactual = New DevExpress.XtraEditors.TextEdit
        Me.txtnueva = New DevExpress.XtraEditors.TextEdit
        Me.txtrepetir = New DevExpress.XtraEditors.TextEdit
        Me.cmdaceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton
        Me.DxError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        CType(Me.txtusuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtactual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnueva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrepetir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(92, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(92, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contraseña Atual:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(92, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nueva Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(92, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Repetir Contraseña:"
        '
        'txtusuario
        '
        Me.txtusuario.Enabled = False
        Me.txtusuario.Location = New System.Drawing.Point(217, 13)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(183, 20)
        Me.txtusuario.TabIndex = 0
        '
        'txtactual
        '
        Me.txtactual.Location = New System.Drawing.Point(217, 39)
        Me.txtactual.Name = "txtactual"
        Me.txtactual.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtactual.Size = New System.Drawing.Size(183, 20)
        Me.txtactual.TabIndex = 1
        '
        'txtnueva
        '
        Me.txtnueva.Location = New System.Drawing.Point(217, 65)
        Me.txtnueva.Name = "txtnueva"
        Me.txtnueva.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnueva.Size = New System.Drawing.Size(183, 20)
        Me.txtnueva.TabIndex = 2
        '
        'txtrepetir
        '
        Me.txtrepetir.Location = New System.Drawing.Point(217, 91)
        Me.txtrepetir.Name = "txtrepetir"
        Me.txtrepetir.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrepetir.Size = New System.Drawing.Size(183, 20)
        Me.txtrepetir.TabIndex = 3
        '
        'cmdaceptar
        '
        Me.cmdaceptar.Location = New System.Drawing.Point(243, 126)
        Me.cmdaceptar.Name = "cmdaceptar"
        Me.cmdaceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdaceptar.TabIndex = 4
        Me.cmdaceptar.Text = "Aceptar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Location = New System.Drawing.Point(324, 126)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdsalir.TabIndex = 5
        Me.cmdsalir.Text = "Salir"
        '
        'DxError
        '
        Me.DxError.ContainerControl = Me
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.SysContab.My.Resources.Resources._6363_babasse_MyPrivateFolder3D
        Me.PictureEdit1.Location = New System.Drawing.Point(-1, 21)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(93, 91)
        Me.PictureEdit1.TabIndex = 6
        '
        'frmUsuariosPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 162)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.cmdaceptar)
        Me.Controls.Add(Me.txtrepetir)
        Me.Controls.Add(Me.txtnueva)
        Me.Controls.Add(Me.txtactual)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuariosPass"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion de Usuarios"
        CType(Me.txtusuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtactual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnueva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrepetir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtusuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtactual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtnueva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtrepetir As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdaceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxError As System.Windows.Forms.ErrorProvider
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
