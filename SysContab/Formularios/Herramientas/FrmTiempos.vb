Public Class FrmTiempos
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbproceso As System.Windows.Forms.ComboBox
    Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
    Friend WithEvents desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdgenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbproceso = New System.Windows.Forms.ComboBox
        Me.cmbusuario = New System.Windows.Forms.ComboBox
        Me.desde = New System.Windows.Forms.DateTimePicker
        Me.hasta = New System.Windows.Forms.DateTimePicker
        Me.cmdgenerar = New DevExpress.XtraEditors.SimpleButton
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proceso:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Desde:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Hasta:"
        '
        'cmbproceso
        '
        Me.cmbproceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbproceso.Location = New System.Drawing.Point(64, 16)
        Me.cmbproceso.Name = "cmbproceso"
        Me.cmbproceso.Size = New System.Drawing.Size(200, 21)
        Me.cmbproceso.TabIndex = 3
        '
        'cmbusuario
        '
        Me.cmbusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbusuario.Location = New System.Drawing.Point(64, 48)
        Me.cmbusuario.Name = "cmbusuario"
        Me.cmbusuario.Size = New System.Drawing.Size(200, 21)
        Me.cmbusuario.TabIndex = 3
        '
        'desde
        '
        Me.desde.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.desde.Location = New System.Drawing.Point(344, 16)
        Me.desde.Name = "desde"
        Me.desde.Size = New System.Drawing.Size(136, 20)
        Me.desde.TabIndex = 10
        '
        'hasta
        '
        Me.hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.hasta.Location = New System.Drawing.Point(344, 48)
        Me.hasta.Name = "hasta"
        Me.hasta.Size = New System.Drawing.Size(136, 20)
        Me.hasta.TabIndex = 9
        '
        'cmdgenerar
        '
        Me.cmdgenerar.Location = New System.Drawing.Point(408, 80)
        Me.cmdgenerar.Name = "cmdgenerar"
        Me.cmdgenerar.TabIndex = 11
        Me.cmdgenerar.Text = "&Generar"
        '
        'GridDetalle
        '
        '
        'GridDetalle.EmbeddedNavigator
        '
        Me.GridDetalle.EmbeddedNavigator.Name = ""
        Me.GridDetalle.Location = New System.Drawing.Point(8, 112)
        Me.GridDetalle.MainView = Me.GridView1
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.Size = New System.Drawing.Size(480, 208)
        Me.GridDetalle.TabIndex = 12
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False

        '
        'FrmTiempos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(496, 330)
        Me.Controls.Add(Me.GridDetalle)
        Me.Controls.Add(Me.cmdgenerar)
        Me.Controls.Add(Me.desde)
        Me.Controls.Add(Me.hasta)
        Me.Controls.Add(Me.cmbproceso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbusuario)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmTiempos"
        Me.Text = "Tiempos"
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private StrWhere As String

    Private Sub FrmTiempos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbusuario.DataSource = ObtieneDatos("SELECT '' AS Nombre,'Todos' AS Codigo FROM Usuarios UNION SELECT Usr_NombreCompleto AS Nombre,UPPER(Usr_Login) AS Codigo FROM Usuarios")
        cmbusuario.DisplayMember = "Nombre"
        cmbusuario.ValueMember = "Codigo"

        cmbproceso.DataSource = ObtieneDatos("SELECT 0 AS Codigo,'' AS Nombre UNION SELECT IdProceso AS Codigo,Nombre AS Nombre FROM Aut_TipoProcesos")
        cmbproceso.DisplayMember = "Nombre"
        cmbproceso.ValueMember = "Codigo"
    End Sub

    Private Sub cmdgen6erar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgenerar.Click
        StrWhere = vbNullString
        StrWhere += " AND HoraInicio Between ''" & Format(Me.desde.Value.Date, "MM/dd/yyyy") & " 00:00:00'' AND ''" & Format(Me.hasta.Value.Date, "MM/dd/yyyy") & " 23:59:59'' "
        StrWhere += " AND Empresa = " & EmpresaActual
        If cmbproceso.SelectedIndex > 0 Then
            StrWhere += " AND IdModulo = " & cmbproceso.SelectedValue
        End If
        If cmbusuario.SelectedIndex > 0 Then
            StrWhere += " AND UPPER(Usuario)= '" & UCase(cmbusuario.SelectedValue) & "'"
        End If
        GridDetalle.DataSource = ObtieneDatos("SPGetTiempos '" & StrWhere & "'")
    End Sub
End Class
