Public Class frmAgregarTipoComprobante
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarTipoComprobante = Nothing

    Public Shared Function Instance() As frmAgregarTipoComprobante
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarTipoComprobante()
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
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAbreviatura As System.Windows.Forms.TextBox
    Friend WithEvents chkCierre As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheque As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConcecutivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkMantenimiento As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtConcecutivo = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkMantenimiento = New System.Windows.Forms.CheckBox
        Me.chkCheque = New System.Windows.Forms.CheckBox
        Me.chkCierre = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAbreviatura = New System.Windows.Forms.TextBox
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtConcecutivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtConcecutivo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkMantenimiento)
        Me.GroupBox1.Controls.Add(Me.chkCheque)
        Me.GroupBox1.Controls.Add(Me.chkCierre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAbreviatura)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtConcecutivo
        '
        Me.txtConcecutivo.Location = New System.Drawing.Point(128, 133)
        Me.txtConcecutivo.Name = "txtConcecutivo"
        Me.txtConcecutivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcecutivo.Properties.Appearance.Options.UseFont = True
        Me.txtConcecutivo.Properties.MaxLength = 10
        Me.txtConcecutivo.Size = New System.Drawing.Size(152, 22)
        Me.txtConcecutivo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(68, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Inicio:"
        '
        'chkMantenimiento
        '
        Me.chkMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMantenimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkMantenimiento.Location = New System.Drawing.Point(359, 129)
        Me.chkMantenimiento.Name = "chkMantenimiento"
        Me.chkMantenimiento.Size = New System.Drawing.Size(249, 26)
        Me.chkMantenimiento.TabIndex = 5
        Me.chkMantenimiento.Text = "Comprobante de Mant. Valor"
        '
        'chkCheque
        '
        Me.chkCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkCheque.Location = New System.Drawing.Point(359, 103)
        Me.chkCheque.Name = "chkCheque"
        Me.chkCheque.Size = New System.Drawing.Size(249, 26)
        Me.chkCheque.TabIndex = 4
        Me.chkCheque.Text = "Comprobante de Cheque"
        '
        'chkCierre
        '
        Me.chkCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCierre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkCierre.Location = New System.Drawing.Point(359, 78)
        Me.chkCierre.Name = "chkCierre"
        Me.chkCierre.Size = New System.Drawing.Size(257, 25)
        Me.chkCierre.TabIndex = 3
        Me.chkCierre.Text = "Comprobante de Cierre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Abrebiatura:"
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.Location = New System.Drawing.Point(128, 89)
        Me.txtAbreviatura.MaxLength = 20
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(152, 20)
        Me.txtAbreviatura.TabIndex = 1
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(208, 187)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(128, 187)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "Aceptar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(50, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(128, 42)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(344, 20)
        Me.txtNombre.TabIndex = 0
        '
        'frmAgregarTipoComprobante
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(648, 240)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAgregarTipoComprobante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtConcecutivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Inicio As Boolean

    Private Sub frmAgregarTipoComprobante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tipo_Comprobante As New VB.SysContab.Tipo_ComprobanteDB()

        GroupBox1.Top = Me.Height / 4
        GroupBox1.Left = Me.Height / 4

        If Nuevo = "NO" Then
            Me.Text = "Editar Tipo de Comprobante"
            Dim Detalles As VB.SysContab.Tipo_ComprobanteDetails = Tipo_Comprobante.GetDetails(Registro)
            Me.txtNombre.Text = Detalles.Nombre
            Me.txtAbreviatura.Text = Detalles.Abreviatura
            Me.chkCierre.Checked = Detalles.Cierre
            Me.chkCheque.Checked = Detalles.Cheque
            Me.chkMantenimiento.Checked = Detalles.Mantenimiento
            Me.txtConcecutivo.Text = Detalles.Inicio
        Else
            Me.Text = "Agregar Tipo de Comprobante"
        End If

        Me.Refresh()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim Tipo_Comprobante As New VB.SysContab.Tipo_ComprobanteDB()
        Dim r As New VB.SysContab.Rutinas
        Dim cc, ck, cm As Integer

        VB.SysContab.Tipo_ComprobanteDB.GetListComprobantesClasificados(cc, ck, cm, IIf(Registro = "Vacio", 0, IIf(Nuevo = "SI", 0, Registro)))
        If cc = -1 Or ck = -1 Or cm = -1 Then
            MsgBox("No se pudo consultar la tabla de tiposcomprobantes", MsgBoxStyle.Critical, "STS-Contab")
            Exit Sub
        End If

        If Me.chkCierre.Checked And cc <> 0 Then
            MsgBox("Ya existe un Tipo de Comprobante de Cierre", MsgBoxStyle.Critical, "STS-Contab")
            Exit Sub
        End If

        If Me.chkCheque.Checked And ck <> 0 Then
            MsgBox("Ya existe un Tipo de Comprobante de Cheque", MsgBoxStyle.Critical, "STS-Contab")
            Exit Sub
        End If

        If Me.chkMantenimiento.Checked And cm <> 0 Then
            MsgBox("Ya existe un Tipo de Comprobante de Mantenimiento", MsgBoxStyle.Critical, "STS-Contab")
            Exit Sub
        End If


        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el Nombre del Tipo de Comprobante", MsgBoxStyle.Information)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub
        End If

        If Trim(Me.txtAbreviatura.Text) = "" Then
            MsgBox("Debe especificar una abreviatura para Tipo de Comprobante", MsgBoxStyle.Information)
            Me.txtAbreviatura.Focus()
            Me.txtAbreviatura.SelectAll()
            Exit Sub
        End If


        If Nuevo = "SI" Then
            Tipo_Comprobante.AddItem(txtNombre.Text, Me.txtAbreviatura.Text, Me.chkCierre.Checked, _
                Me.chkCheque.Checked, Me.chkMantenimiento.Checked, Me.txtConcecutivo.Text)

            r.LimpiarControles(GroupBox1)
            Me.txtConcecutivo.Text = "1"
            Me.chkCierre.Checked = False

            txtNombre.Focus()
        Else
            Tipo_Comprobante.Update(Registro, txtNombre.Text, Me.txtAbreviatura.Text, Me.chkCierre.Checked, _
                Me.chkCheque.Checked, Me.chkMantenimiento.Checked, Me.txtConcecutivo.Text)
            Me.Close()

        End If

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()

    End Sub

    Private Sub frmAgregarTipoComprobante_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim r As New VB.SysContab.Rutinas
        Dim Tipo_Comprobante As New VB.SysContab.Tipo_ComprobanteDB
        Dim t As frmTipoComprobante = t.Instance
        Dim Tabla As New DataTable
        'Dim f As New frmGrupos()
        Dim ds As New DataSet

        ''r.CambiarEstilo(Me)

        ds = Tipo_Comprobante.GetList()
        t.dgTipoComprobante.DataSource = Tipo_Comprobante.GetList().Tables("Tipo_Comprobantes").DefaultView
        Tabla = ds.Tables("Tipo_Comprobantes")

        r.FormatGenerico(t.dgTipoComprobante, Tabla)

        If ds.Tables("Tipo_Comprobantes").Rows.Count <> 0 Then
            Registro = t.dgTipoComprobante.Item(0, 0)
        End If

    End Sub

    Private Sub chkCierre_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCierre.CheckedChanged
        If Me.Inicio = True Then
            Exit Sub
        End If

        If Me.chkCierre.Checked = True Then
            Me.chkCheque.Checked = False
            Me.chkMantenimiento.Checked = False
        End If
    End Sub

    Private Sub chkCheque_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCheque.CheckedChanged
        If Me.Inicio = True Then
            Exit Sub
        End If
        If Me.chkCheque.Checked = True Then
            Me.chkCierre.Checked = False
            Me.chkMantenimiento.Checked = False
        End If
    End Sub

    Private Sub chkMantenimiento_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMantenimiento.CheckedChanged
        If Me.Inicio = True Then
            Exit Sub
        End If
        If Me.chkMantenimiento.Checked = True Then
            Me.chkCierre.Checked = False
            Me.chkCheque.Checked = False
        End If
    End Sub

End Class
