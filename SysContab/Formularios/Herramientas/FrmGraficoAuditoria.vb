Public Class FrmGraficoAuditoria
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optusuario As System.Windows.Forms.RadioButton
    Friend WithEvents optdepartamento As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmblista As System.Windows.Forms.ComboBox
    Friend WithEvents cmdgenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grafico As DevExpress.XtraCharts.ChartControl
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbeventos As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdbitacora As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbcomprobante As System.Windows.Forms.ComboBox
    Friend WithEvents cmdcomprobantes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdtiempos As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmblista = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.optusuario = New System.Windows.Forms.RadioButton
        Me.optdepartamento = New System.Windows.Forms.RadioButton
        Me.cmbcomprobante = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbeventos = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Grafico = New DevExpress.XtraCharts.ChartControl
        Me.cmdgenerar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdcomprobantes = New DevExpress.XtraEditors.SimpleButton
        Me.cmdbitacora = New DevExpress.XtraEditors.SimpleButton
        Me.cmdtiempos = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmblista)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.optusuario)
        Me.GroupBox1.Controls.Add(Me.optdepartamento)
        Me.GroupBox1.Controls.Add(Me.cmbcomprobante)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbeventos)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Filtro"
        '
        'cmblista
        '
        Me.cmblista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblista.Location = New System.Drawing.Point(104, 64)
        Me.cmblista.Name = "cmblista"
        Me.cmblista.Size = New System.Drawing.Size(200, 21)
        Me.cmblista.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'optusuario
        '
        Me.optusuario.Checked = True
        Me.optusuario.Location = New System.Drawing.Point(24, 24)
        Me.optusuario.Name = "optusuario"
        Me.optusuario.Size = New System.Drawing.Size(64, 24)
        Me.optusuario.TabIndex = 0
        Me.optusuario.TabStop = True
        Me.optusuario.Text = "Usuario"
        '
        'optdepartamento
        '
        Me.optdepartamento.Location = New System.Drawing.Point(136, 24)
        Me.optdepartamento.Name = "optdepartamento"
        Me.optdepartamento.TabIndex = 0
        Me.optdepartamento.Text = "Departamento"
        '
        'cmbcomprobante
        '
        Me.cmbcomprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcomprobante.Location = New System.Drawing.Point(104, 104)
        Me.cmbcomprobante.Name = "cmbcomprobante"
        Me.cmbcomprobante.Size = New System.Drawing.Size(200, 21)
        Me.cmbcomprobante.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tipo Comp:"
        '
        'cmbeventos
        '
        Me.cmbeventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbeventos.Location = New System.Drawing.Point(384, 104)
        Me.cmbeventos.Name = "cmbeventos"
        Me.cmbeventos.Size = New System.Drawing.Size(168, 21)
        Me.cmbeventos.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(312, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Evento:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(384, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(136, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(384, 64)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(136, 20)
        Me.DateTimePicker2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(312, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(312, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Hasta:"
        '
        'Grafico
        '
        Me.Grafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grafico.Diagram = Nothing
        Me.Grafico.Location = New System.Drawing.Point(8, 160)
        Me.Grafico.Name = "Grafico"
        Me.Grafico.SeriesTemplate.PointOptionsTypeName = "PointOptions"
        Me.Grafico.Size = New System.Drawing.Size(672, 400)
        Me.Grafico.TabIndex = 1
        '
        'cmdgenerar
        '
        Me.cmdgenerar.Location = New System.Drawing.Point(592, 8)
        Me.cmdgenerar.Name = "cmdgenerar"
        Me.cmdgenerar.Size = New System.Drawing.Size(88, 23)
        Me.cmdgenerar.TabIndex = 2
        Me.cmdgenerar.Text = "&Generar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Location = New System.Drawing.Point(592, 128)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(88, 23)
        Me.cmdsalir.TabIndex = 2
        Me.cmdsalir.Text = "&Salir"
        '
        'cmdcomprobantes
        '
        Me.cmdcomprobantes.Location = New System.Drawing.Point(592, 96)
        Me.cmdcomprobantes.Name = "cmdcomprobantes"
        Me.cmdcomprobantes.Size = New System.Drawing.Size(88, 23)
        Me.cmdcomprobantes.TabIndex = 3
        Me.cmdcomprobantes.Text = "&Comprobantes"
        '
        'cmdbitacora
        '
        Me.cmdbitacora.Location = New System.Drawing.Point(592, 38)
        Me.cmdbitacora.Name = "cmdbitacora"
        Me.cmdbitacora.Size = New System.Drawing.Size(88, 23)
        Me.cmdbitacora.TabIndex = 2
        Me.cmdbitacora.Text = "&Bitacora"
        '
        'cmdtiempos
        '
        Me.cmdtiempos.Location = New System.Drawing.Point(592, 65)
        Me.cmdtiempos.Name = "cmdtiempos"
        Me.cmdtiempos.Size = New System.Drawing.Size(88, 23)
        Me.cmdtiempos.TabIndex = 3
        Me.cmdtiempos.Text = "&Tiempos"
        '
        'FrmGraficoAuditoria
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(688, 570)
        Me.Controls.Add(Me.cmdcomprobantes)
        Me.Controls.Add(Me.cmdgenerar)
        Me.Controls.Add(Me.Grafico)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.cmdbitacora)
        Me.Controls.Add(Me.cmdtiempos)
        Me.Name = "FrmGraficoAuditoria"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Grafico de Auditoria de Usuarios"
        Me.WindowState = FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Grafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Temp As Boolean = False
    Dim StrWhere As String = ""
    Dim StrWheres As String = ""

    Private Sub FrmGraficoAuditoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbcomprobante.DataSource = ObtieneDatos("SELECT 0 AS Codigo, 'Todos' AS Nombre UNION SELECT TipComp_Id AS Codigo,TipComp_Nombre AS Nombre FROM TipoComprobantes WHERE Empresa = " & EmpresaActual)
        cmbcomprobante.ValueMember = "Codigo"
        cmbcomprobante.DisplayMember = "Nombre"
        cmbeventos.Items.Add("Todos")
        cmbeventos.Items.Add("Modificar")
        cmbeventos.Items.Add("Registrar")
        cmbeventos.Items.Add("Borrar")
        cmbeventos.SelectedIndex = 0
        Temp = True
        Label1.Text = "Usuario"
    End Sub

    Private Sub optusuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optusuario.CheckedChanged, optdepartamento.CheckedChanged
        Label1.Text = CType(sender, RadioButton).Text
        If optusuario.Checked Then
            cmblista.DataSource = ObtieneDatos("SELECT '' AS Nombre,'Todos' AS Codigo FROM Usuarios UNION SELECT Usr_NombreCompleto AS Nombre,UPPER(Usr_Login) AS Codigo FROM Usuarios")
        Else
            cmblista.DataSource = ObtieneDatos("SELECT '' AS Nombre,0 AS Codigo FROM CodigoDepartamentos UNION SELECT Nombre,IdDepartamento AS Codigo FROM CodigoDepartamentos")
        End If
        cmblista.ValueMember = "Codigo"
        cmblista.DisplayMember = "Nombre"
    End Sub

    Private Sub cmdgenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgenerar.Click, cmbcomprobante.SelectedIndexChanged
        If Temp Then
            StrWhere = ""
            StrWheres = ""


            StrWhere += " AND Auditoria.Empresa = " & EmpresaActual
            StrWheres += " AND Auditoria.Empresa = " & EmpresaActual

            If Me.DateTimePicker1.Value.Date = Me.DateTimePicker2.Value.Date Then
                StrWhere += " AND convert(nvarchar,fecha,103) = ''" & Me.DateTimePicker2.Value.Date & "''"
                StrWheres += " AND convert(nvarchar,fecha,103) = '" & Me.DateTimePicker2.Value.Date & "'"
            Else
                StrWhere += " AND fecha Between ''" & Format(Me.DateTimePicker1.Value.Date, "MM/dd/yyyy") & " 00:00:00'' AND ''" & Format(Me.DateTimePicker2.Value.Date, "MM/dd/yyyy") & " 23:59:59''"
                StrWheres += " AND fecha Between '" & Format(Me.DateTimePicker1.Value.Date, "MM/dd/yyyy") & " 00:00:00' AND '" & Format(Me.DateTimePicker2.Value.Date, "MM/dd/yyyy") & " 23:59:59'"
            End If

            If cmbcomprobante.SelectedIndex > 0 Then
                StrWhere += "AND C.Comp_Tipo = " & cmbcomprobante.SelectedValue
            End If
            With Grafico
                .DataSource = ObtieneDatos("SPGraficoAuditoria '" & StrWhere & "'," & IIf(optusuario.Checked, 0, 1))
                .SeriesDataMember = "Eventos"
                .SeriesTemplate.ArgumentDataMember = "Usuario"
                .SeriesTemplate.ValueDataMembers.AddRange(New String() {"Evento"})
                Dim diag As DevExpress.XtraCharts.XYDiagram = CType(.Diagram, DevExpress.XtraCharts.XYDiagram)
                diag.AxisX.Label.Angle = 90
                .Refresh()
            End With
        End If
    End Sub

    Private Sub cmblista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblista.SelectedIndexChanged, cmbeventos.SelectedIndexChanged
        If cmblista.SelectedIndex = 0 Then Grafico.SeriesTemplate.DataFilters.Clear()
        If cmbeventos.SelectedIndex = 0 Then Grafico.SeriesTemplate.DataFilters.Clear()
        For i As Integer = 0 To Grafico.SeriesTemplate.DataFilters.Count - 1
            If Grafico.SeriesTemplate.DataFilters(i).ColumnName = "Usuario" Then
                Grafico.SeriesTemplate.DataFilters(i).Value = UCase(cmblista.SelectedValue)
                Exit For
            End If
        Next
        For i As Integer = 0 To Grafico.SeriesTemplate.DataFilters.Count - 1
            If Grafico.SeriesTemplate.DataFilters(i).ColumnName = "Eventos" Then
                Grafico.SeriesTemplate.DataFilters(i).Value = cmbeventos.Text
                Exit Sub
            End If
        Next
        If cmblista.SelectedIndex > 0 Then Grafico.SeriesTemplate.DataFilters.Add("Usuario", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, IIf(optusuario.Checked, UCase(cmblista.SelectedValue), cmblista.Text))
        If cmbeventos.SelectedIndex > 0 Then Grafico.SeriesTemplate.DataFilters.Add("Eventos", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, cmbeventos.Text)
        Grafico.Refresh()
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmdtiempos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtiempos.Click
        Dim Forma As New FrmTiempos
        'Forma.StrWhere = StrWheres
        Forma.Show()
    End Sub

    Private Sub cmdbitacora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbitacora.Click
        Dim forma As New FrmBitacora
        forma.ShowDialog()
    End Sub

    Private Sub cmdcomprobantes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcomprobantes.Click
        Dim forma As New FrmDetalleTiempo
        forma.StrWhere = StrWheres
        forma.Mostrar()
    End Sub
End Class
