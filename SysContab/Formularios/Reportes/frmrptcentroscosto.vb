Imports DevExpress.XtraReports.UI

Public Class frmrptcentroscosto
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
    Friend WithEvents cmbmoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbrubro As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcentro As System.Windows.Forms.ComboBox
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdaceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkcentro As System.Windows.Forms.CheckBox
    Friend WithEvents chkrubro As System.Windows.Forms.CheckBox
    Friend WithEvents chkdetalle As System.Windows.Forms.CheckBox
    Friend WithEvents chktotalcuenta As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDistribuidos As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.desde = New System.Windows.Forms.DateTimePicker()
        Me.hasta = New System.Windows.Forms.DateTimePicker()
        Me.cmbcentro = New System.Windows.Forms.ComboBox()
        Me.cmbrubro = New System.Windows.Forms.ComboBox()
        Me.cmdaceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbmoneda = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkcentro = New System.Windows.Forms.CheckBox()
        Me.chkrubro = New System.Windows.Forms.CheckBox()
        Me.chkdetalle = New System.Windows.Forms.CheckBox()
        Me.chktotalcuenta = New System.Windows.Forms.CheckBox()
        Me.ChkDistribuidos = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(59, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(62, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(4, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Centro de Costo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(61, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Rubro:"
        '
        'desde
        '
        Me.desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.desde.Location = New System.Drawing.Point(112, 43)
        Me.desde.Name = "desde"
        Me.desde.Size = New System.Drawing.Size(232, 21)
        Me.desde.TabIndex = 1
        '
        'hasta
        '
        Me.hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.hasta.Location = New System.Drawing.Point(112, 78)
        Me.hasta.Name = "hasta"
        Me.hasta.Size = New System.Drawing.Size(232, 21)
        Me.hasta.TabIndex = 1
        '
        'cmbcentro
        '
        Me.cmbcentro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcentro.Location = New System.Drawing.Point(112, 112)
        Me.cmbcentro.Name = "cmbcentro"
        Me.cmbcentro.Size = New System.Drawing.Size(232, 21)
        Me.cmbcentro.TabIndex = 2
        '
        'cmbrubro
        '
        Me.cmbrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbrubro.Location = New System.Drawing.Point(112, 146)
        Me.cmbrubro.Name = "cmbrubro"
        Me.cmbrubro.Size = New System.Drawing.Size(232, 21)
        Me.cmbrubro.TabIndex = 2
        '
        'cmdaceptar
        '
        Me.cmdaceptar.Location = New System.Drawing.Point(384, 250)
        Me.cmdaceptar.Name = "cmdaceptar"
        Me.cmdaceptar.Size = New System.Drawing.Size(75, 25)
        Me.cmdaceptar.TabIndex = 3
        Me.cmdaceptar.Text = "&Aceptar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Location = New System.Drawing.Point(496, 250)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(75, 25)
        Me.cmdsalir.TabIndex = 3
        Me.cmdsalir.Text = "&Salir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(50, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Moneda:"
        '
        'cmbmoneda
        '
        Me.cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmoneda.Location = New System.Drawing.Point(112, 181)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Size = New System.Drawing.Size(232, 21)
        Me.cmbmoneda.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkcentro)
        Me.GroupBox1.Controls.Add(Me.chkrubro)
        Me.GroupBox1.Controls.Add(Me.chkdetalle)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(360, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 181)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mostrar detalle por"
        '
        'chkcentro
        '
        Me.chkcentro.AutoSize = True
        Me.chkcentro.Checked = True
        Me.chkcentro.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkcentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcentro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkcentro.Location = New System.Drawing.Point(32, 43)
        Me.chkcentro.Name = "chkcentro"
        Me.chkcentro.Size = New System.Drawing.Size(140, 17)
        Me.chkcentro.TabIndex = 7
        Me.chkcentro.Text = "Por Centro de Costo"
        '
        'chkrubro
        '
        Me.chkrubro.AutoSize = True
        Me.chkrubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkrubro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkrubro.Location = New System.Drawing.Point(32, 86)
        Me.chkrubro.Name = "chkrubro"
        Me.chkrubro.Size = New System.Drawing.Size(83, 17)
        Me.chkrubro.TabIndex = 6
        Me.chkrubro.Text = "Por Rubro"
        '
        'chkdetalle
        '
        Me.chkdetalle.AutoSize = True
        Me.chkdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkdetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkdetalle.Location = New System.Drawing.Point(32, 129)
        Me.chkdetalle.Name = "chkdetalle"
        Me.chkdetalle.Size = New System.Drawing.Size(178, 17)
        Me.chkdetalle.TabIndex = 5
        Me.chkdetalle.Text = "Detalle de los Documentos"
        '
        'chktotalcuenta
        '
        Me.chktotalcuenta.AutoSize = True
        Me.chktotalcuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chktotalcuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.chktotalcuenta.Location = New System.Drawing.Point(112, 219)
        Me.chktotalcuenta.Name = "chktotalcuenta"
        Me.chktotalcuenta.Size = New System.Drawing.Size(134, 17)
        Me.chktotalcuenta.TabIndex = 6
        Me.chktotalcuenta.Text = "Totales por Cuenta"
        '
        'ChkDistribuidos
        '
        Me.ChkDistribuidos.AutoSize = True
        Me.ChkDistribuidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDistribuidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.ChkDistribuidos.Location = New System.Drawing.Point(112, 242)
        Me.ChkDistribuidos.Name = "ChkDistribuidos"
        Me.ChkDistribuidos.Size = New System.Drawing.Size(112, 17)
        Me.ChkDistribuidos.TabIndex = 6
        Me.ChkDistribuidos.Text = "No Distribuidos"
        '
        'frmrptcentroscosto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(592, 287)
        Me.Controls.Add(Me.chktotalcuenta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdaceptar)
        Me.Controls.Add(Me.cmbcentro)
        Me.Controls.Add(Me.desde)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hasta)
        Me.Controls.Add(Me.cmbrubro)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbmoneda)
        Me.Controls.Add(Me.ChkDistribuidos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrptcentroscosto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Centros de Costo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub frmrptcentroscosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbcentro.DataSource = ObtieneDatos("SELECT 0 AS Codigo,'Todos' AS Nombre UNION ALL SELECT Codigo,Nombre FROM CentroDeCosto WHERE Activo = 1 AND Empresa = " & EmpresaActual)
        cmbcentro.DisplayMember = "Nombre"
        cmbcentro.ValueMember = "Codigo"

        cmbrubro.DataSource = ObtieneDatos("SELECT 0 AS Codigo,'Todos' AS Nombre UNION ALL SELECT Codigo,Nombre FROM RubrosGastos WHERE Activo = 1 AND Empresa = " & EmpresaActual)
        cmbrubro.DisplayMember = "Nombre"
        cmbrubro.ValueMember = "Codigo"

        cmbmoneda.DataSource = ObtieneDatos("SELECT mon_codigo AS Codigo,mon_descripcion AS Nombre FROM Monedas WHERE empr_codigo = " & EmpresaActual)
        cmbmoneda.DisplayMember = "Nombre"
        cmbmoneda.ValueMember = "Codigo"

        cmbmoneda.SelectedValue = MonedaBase
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaceptar.Click
        Dim Empresa As VB.SysContab.EmpresasDetails
        Dim Empresas As VB.SysContab.EmpresasDB
        Empresa = Empresas.GetDetails(EmpresaActual)
        Dim Datos As New ArrayList
        Dim Variables As New ArrayList
        Datos.Add(EmpresaActual)
        Datos.Add(cmbcentro.SelectedValue)
        Datos.Add(cmbrubro.SelectedValue)
        Datos.Add(desde.Value.Date)
        Datos.Add(hasta.Value.Date)
        Datos.Add(Empresa.MonedaBase)
        Datos.Add(cmbmoneda.SelectedValue)
        Variables.Add("Empresa")
        Variables.Add("Centro")
        Variables.Add("Rubro")
        Variables.Add("Desde")
        Variables.Add("Hasta")
        Variables.Add("MB")
        Variables.Add("MC")

        If ChkDistribuidos.Checked Then
            Dim Rep As New RptNoDistribuidos
            Datos.Clear()
            Variables.Clear()
            Datos.Add(desde.Value.Date)
            Datos.Add(hasta.Value.Date)
            Datos.Add(EmpresaActual)
            Variables.Add("Desde")
            Variables.Add("Hasta")
            Variables.Add("Empresa")
            Rep.DataSource = ProcedureParameters(Datos, Variables, "SPRptNoDistribuidos")

            Rep.ShowPrintMarginsWarning = False
            Rep.BringToFront()
            Rep.ShowRibbonPreview()
        Else
            If chktotalcuenta.Checked Then
                Dim Rep As New RptCentrosdeCosto2
                Rep.DataSource = ProcedureParameters(Datos, Variables, "SPRptCentrosCosto")
                Rep.GrpComprobante.Visible = chkdetalle.Checked
                Rep.GrpCuenta.Visible = chkrubro.Checked
                'Rep.Detail.Visible = chkdetalle.Checked
                Rep.ShowPrintMarginsWarning = False
                Rep.BringToFront()
                Rep.ShowRibbonPreview()
            Else
                Dim Rep As New RptCentrosdeCosto
                Rep.DataSource = ProcedureParameters(Datos, Variables, "SPRptCentrosCosto")
                Rep.GrpCentro.Visible = chkcentro.Checked
                Rep.GrpCuenta.Visible = chkrubro.Checked
                Rep.Detail.Visible = chkdetalle.Checked
                Rep.ShowPrintMarginsWarning = False
                Rep.BringToFront()
                Rep.ShowRibbonPreview()
            End If
        End If
    End Sub

    Private Sub ChkDistribuidos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDistribuidos.CheckedChanged
        cmbmoneda.Enabled = Not ChkDistribuidos.Checked
        cmbrubro.Enabled = Not ChkDistribuidos.Checked
        cmbcentro.Enabled = Not ChkDistribuidos.Checked
        GroupBox1.Enabled = Not ChkDistribuidos.Checked
        chktotalcuenta.Enabled = Not ChkDistribuidos.Checked
    End Sub
End Class
