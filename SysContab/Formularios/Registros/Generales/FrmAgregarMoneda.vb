Public Class frmAgregarMoneda
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarMoneda = Nothing
    Private LCodigo As String
    Dim r As New VB.SysContab.Rutinas()
    Public Shared Function Instance() As frmAgregarMoneda
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarMoneda()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSimbolo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSimbolo = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 26)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(136, 43)
        Me.txtCodigo.MaxLength = 3
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigo.TabIndex = 120
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(136, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 42)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Appearance.Options.UseForeColor = True
        Me.cmdCancelar.Location = New System.Drawing.Point(88, 9)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 25)
        Me.cmdCancelar.TabIndex = 29
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Appearance.Options.UseForeColor = True
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 9)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 25)
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "Aceptar"
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(24, 9)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(480, 21)
        Me.etDescripcion.TabIndex = 123
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 25)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(136, 78)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(368, 20)
        Me.txtDescripcion.TabIndex = 124
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(24, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 26)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Simbolo:"
        '
        'txtSimbolo
        '
        Me.txtSimbolo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSimbolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSimbolo.Location = New System.Drawing.Point(136, 112)
        Me.txtSimbolo.MaxLength = 10
        Me.txtSimbolo.Name = "txtSimbolo"
        Me.txtSimbolo.Size = New System.Drawing.Size(112, 20)
        Me.txtSimbolo.TabIndex = 126
        '
        'frmAgregarMoneda
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(512, 194)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSimbolo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.etDescripcion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Name = "frmAgregarMoneda"
        Me.Text = "Monedas"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmAgregarMoneda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Monedas As New VB.SysContab.MonedaDB()

        If Nuevo = "NO" Then
            Me.txtCodigo.Text = ""
            Me.txtDescripcion.Text = ""

            Me.etDescripcion.Text = "Editar Moneda".ToUpper
            Me.Text = "Editar Moneda"

            Dim Detalles As VB.SysContab.MonedaDetails = Monedas.GetDetails(Registro)

            LCodigo = Detalles.Codigo
            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtDescripcion.Text = Detalles.Descripcion
            Me.txtSimbolo.Text = Detalles.Simbolo

        Else
            Me.Text = "Agregar Moneda"
            Me.etDescripcion.Text = "Agregar Moneda".ToUpper
            Me.txtCodigo.Text = Monedas.GetListCodigoNvo
            Me.txtDescripcion.Text = ""
            LCodigo = ""

        End If


        Me.Refresh()


    End Sub




    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim Monedas As New VB.SysContab.MonedaDB()
        Dim ds As DataSet
        Dim CodigoNvo As String, Grabado As Integer
        If Trim(Me.txtDescripcion.Text) = "" Then
            MsgBox("Introduzca la Descripción de la Moneda", MsgBoxStyle.Information)
            Me.txtDescripcion.Focus()
            Exit Sub
        End If

        If Trim(Me.txtSimbolo.Text) = "" Then
            MsgBox("Introduzca el Simbolo de la Moneda", MsgBoxStyle.Information)
            Me.txtSimbolo.Focus()
            Exit Sub
        End If

        If Nuevo = "SI" Then
            ds = Monedas.GetListDescripcion(Me.txtCodigo.Text)
            If ds.Tables("Monedas").Rows.Count <> 0 Then
                MsgBox("Ese moneda ya ha sido definido anteriormente, favor revisar", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "Codigo ya Existe")
                Exit Sub
            Else
                CodigoNvo = Monedas.GetListCodigoNvo() ' Acordarme de agregar los ceros a la izquierda, no me gusta dejarlo asi
                Grabado = Monedas.AddItem(CodigoNvo, Me.txtDescripcion.Text, Me.txtSimbolo.Text)
                If Grabado = 0 Then
                    MsgBox("Registro agregado satisfactoriamente", MsgBoxStyle.OKOnly)
                    Me.Close()
                End If
            End If
        Else
            Grabado = Monedas.Update(Me.txtCodigo.Text, Me.txtDescripcion.Text, Me.txtSimbolo.Text)
            If Grabado = 0 Then
                MsgBox("Registro actualizado satisfactoriamente", MsgBoxStyle.OKOnly)
                Me.Close()
            End If

        End If

    End Sub

    Private Sub frmAgregarMoneda_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

        Dim Moneda As New VB.SysContab.MonedaDB()
        Dim Mon As frmMonedas = frmMonedas.Instance
        Dim Tabla As New DataTable()
        Dim ds As New DataSet()


        ds = Moneda.GetList()
        Mon.dgMonedas.DataSource = Moneda.GetList().Tables("Monedas").DefaultView
        Tabla = ds.Tables("Monedas")

        r.FormatGenerico(Mon.dgMonedas, Tabla)

        If ds.Tables("Monedas").Rows.Count <> 0 Then
            Registro = Mon.dgMonedas.Item(0, 0)
        Else
            Registro = "Vacio"

        End If

    End Sub
End Class
