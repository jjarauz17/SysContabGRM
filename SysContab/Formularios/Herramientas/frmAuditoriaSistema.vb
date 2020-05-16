Public Class frmAuditoriaSistema
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAuditoriaSistema = Nothing

    Public Shared Function Instance() As frmAuditoriaSistema
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAuditoriaSistema
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ckFecha As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents cmdBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbAccion As System.Windows.Forms.ComboBox
    Friend WithEvents etInicio As System.Windows.Forms.Label
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdGraficos As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbUsuario = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ckFecha = New System.Windows.Forms.CheckBox
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbAccion = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.cmdBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdGraficos = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.etInicio = New System.Windows.Forms.Label
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbUsuario
        '
        Me.cbUsuario.Location = New System.Drawing.Point(16, 43)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(216, 21)
        Me.cbUsuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(344, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "hasta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ckFecha
        '
        Me.ckFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ckFecha.Location = New System.Drawing.Point(240, 24)
        Me.ckFecha.Name = "ckFecha"
        Me.ckFecha.Size = New System.Drawing.Size(112, 17)
        Me.ckFecha.TabIndex = 4
        Me.ckFecha.Text = "Rango de Fecha"
        Me.ckFecha.UseVisualStyleBackColor = False
        '
        'dtpInicio
        '
        Me.dtpInicio.Enabled = False
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(240, 43)
        Me.dtpInicio.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(104, 21)
        Me.dtpInicio.TabIndex = 5
        '
        'dtpFinal
        '
        Me.dtpFinal.Enabled = False
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFinal.Location = New System.Drawing.Point(377, 43)
        Me.dtpFinal.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(104, 21)
        Me.dtpFinal.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(489, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Evento Realizado"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbAccion
        '
        Me.cbAccion.Items.AddRange(New Object() {"--Todos--", "Ingresar", "Actualizar", "Borrar"})
        Me.cbAccion.Location = New System.Drawing.Point(489, 43)
        Me.cbAccion.Name = "cbAccion"
        Me.cbAccion.Size = New System.Drawing.Size(144, 21)
        Me.cbAccion.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.DataGrid1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(8, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(993, 175)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTADO DE AUDITORIA"
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(3, 16)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(987, 156)
        Me.DataGrid1.TabIndex = 3
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdBuscar.Appearance.Options.UseFont = True
        Me.cmdBuscar.Appearance.Options.UseForeColor = True
        Me.cmdBuscar.Enabled = False
        Me.cmdBuscar.Location = New System.Drawing.Point(15, 9)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(72, 33)
        Me.cmdBuscar.TabIndex = 10
        Me.cmdBuscar.Text = "Buscar"
        '
        'cmdGraficos
        '
        Me.cmdGraficos.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGraficos.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdGraficos.Appearance.Options.UseFont = True
        Me.cmdGraficos.Appearance.Options.UseForeColor = True
        Me.cmdGraficos.Enabled = False
        Me.cmdGraficos.Location = New System.Drawing.Point(175, 9)
        Me.cmdGraficos.Name = "cmdGraficos"
        Me.cmdGraficos.Size = New System.Drawing.Size(72, 33)
        Me.cmdGraficos.TabIndex = 14
        Me.cmdGraficos.Text = "Graficos"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Appearance.Options.UseForeColor = True
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(95, 9)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 33)
        Me.cmdImprimir.TabIndex = 13
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdSalir
        '
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.Appearance.Options.UseForeColor = True
        Me.cmdSalir.Location = New System.Drawing.Point(255, 9)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 33)
        Me.cmdSalir.TabIndex = 12
        Me.cmdSalir.Text = "Salir"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(632, 69)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parámertos"
        '
        'etInicio
        '
        Me.etInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etInicio.Location = New System.Drawing.Point(640, 43)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(16, 17)
        Me.etInicio.TabIndex = 161
        Me.etInicio.Text = "1"
        Me.etInicio.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.cmdGraficos)
        Me.PanelControl1.Controls.Add(Me.cmdImprimir)
        Me.PanelControl1.Controls.Add(Me.cmdBuscar)
        Me.PanelControl1.Controls.Add(Me.cmdSalir)
        Me.PanelControl1.Location = New System.Drawing.Point(655, 24)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(346, 54)
        Me.PanelControl1.TabIndex = 162
        '
        'frmAuditoria
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1009, 268)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbAccion)
        Me.Controls.Add(Me.dtpFinal)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.ckFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbUsuario)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.etInicio)
        Me.Name = "frmAuditoria"
        Me.Text = "Auditoria del Sistema"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas
    Dim Auditoria As New VB.SysContab.AuditoriaDB
    Dim ds As DataSet
    Dim Fecha1 As String
    Dim Fecha2 As String

    Private Sub frmAuditoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''r.FormularioColor(Me)
        RolesDB.UsuarioAcciones(Me.PanelControl1)
        Me.Text = "A u d i t o r i a"
        Fecha1 = ""
        Fecha2 = ""

        Me.cbUsuario.DataSource = Auditoria.UsuariosList.Tables("Auditoria")
        Me.cbUsuario.ValueMember = "ID"
        Me.cbUsuario.DisplayMember = "Usr_NombreCompleto"

        Me.cbUsuario.SelectedIndex = 0
        Me.cbAccion.SelectedIndex = 0

        ds = Auditoria.AuditoriaList("", Fecha1, Fecha2, "")
        Me.DataGrid1.DataSource = ds.Tables("Auditoria")
        r.FormatGenerico(DataGrid1, ds.Tables("Auditoria"))
    End Sub

    Private Sub ckFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckFecha.CheckedChanged
        If ckFecha.Checked = True Then
            Me.dtpInicio.Enabled = True
            Me.dtpFinal.Enabled = True
        Else
            Me.dtpInicio.Enabled = False
            Me.dtpFinal.Enabled = False
        End If
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim Evento As String
        Dim Usuario As String

        If ckFecha.Checked = True Then
            Fecha1 = dtpInicio.Value.Date
            Fecha2 = dtpFinal.Value.Date
        Else
            Fecha1 = ""
            Fecha2 = ""
        End If
        Select Case cbAccion.SelectedIndex
            Case 0
                Evento = ""
            Case 1
                Evento = "I"
            Case 2
                Evento = "U"
            Case Else
                Evento = "D"
        End Select

        ds = Auditoria.AuditoriaList(Me.cbUsuario.SelectedValue, Fecha1, Fecha2, Evento)
        Me.DataGrid1.DataSource = ds.Tables("Auditoria")
        r.FormatGenerico(DataGrid1, ds.Tables("Auditoria"))
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        ds.WriteXml(Application.StartupPath & "\xml\RepAuditoria.xml", XmlWriteMode.WriteSchema)

        Dim fReportes As New frmReportes
        'Dim rOrdenes As New rptAuditoria
        'rOrdenes.Database.Tables("_AuditoriaList").Location = Application.StartupPath & "\xml\RepAuditoria.xml"
        'rOrdenes.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
        'fReportes.crvReportes.ReportSource = rOrdenes
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdGraficos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGraficos.Click
        Dim forma As New FrmGraficoAuditoria
        forma.Show()
    End Sub
End Class
