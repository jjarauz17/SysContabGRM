Public Class frmTarjetas
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmTarjetas = Nothing

    Public Shared Function Instance() As frmTarjetas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmTarjetas()
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
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgTarjetas As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.dgTarjetas = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgTarjetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 245)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 60)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(291, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(387, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(465, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        Me.cmdImprimir.Visible = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(195, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(104, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(88, 16)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(488, 20)
        Me.txtBuscar.TabIndex = 29
        '
        'dgTarjetas
        '
        Me.dgTarjetas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgTarjetas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTarjetas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgTarjetas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgTarjetas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgTarjetas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgTarjetas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgTarjetas.CaptionForeColor = System.Drawing.Color.Black
        Me.dgTarjetas.DataMember = ""
        Me.dgTarjetas.FlatMode = True
        Me.dgTarjetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTarjetas.ForeColor = System.Drawing.Color.Black
        Me.dgTarjetas.GridLineColor = System.Drawing.Color.Silver
        Me.dgTarjetas.HeaderBackColor = System.Drawing.Color.Black
        Me.dgTarjetas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgTarjetas.HeaderForeColor = System.Drawing.Color.White
        Me.dgTarjetas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgTarjetas.Location = New System.Drawing.Point(16, 51)
        Me.dgTarjetas.Name = "dgTarjetas"
        Me.dgTarjetas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgTarjetas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgTarjetas.ReadOnly = True
        Me.dgTarjetas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgTarjetas.SelectionForeColor = System.Drawing.Color.White
        Me.dgTarjetas.Size = New System.Drawing.Size(560, 186)
        Me.dgTarjetas.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 26)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Buscar:"
        '
        'frmTarjetas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(594, 317)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgTarjetas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTarjetas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgTarjetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim Tarjetas As New VB.SysContab.TarjetasDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As New DataTable()
    Dim ds As New DataSet()

    Private Sub frmTarjetas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'r.FormularioColor(Me)
            '  '''r.CambiarEstilo(Me)

            RolesDB.UsuarioAcciones(GroupBox1)

            ds = Tarjetas.List

            dgTarjetas.DataSource = ds.Tables("Tarjetas").DefaultView
            Tabla = ds.Tables("Tarjetas")

            r.FormatGenerico(dgTarjetas, Tabla)

            If ds.Tables("Tarjetas").Rows.Count <> 0 Then
                Registro = dgTarjetas.Item(0, 0)
            Else
                Registro = "Vacio"
            End If

            ''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

            dgTarjetas.CaptionText = "Información de Tipos de Tarjetas de Créditos"

            Me.Text = "Mantenimiento de Tipos de Tarjetas de Créditos"
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarTarjetas = f.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.txtNombre.Focus()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/RegTipoTarjetas.chm")
        'Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "TipodeTarjetas")
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes()
        'Dim rTarjeta As New rptTarjetas()
        Dim Tarjeta As New VB.SysContab.TarjetasDB()
        Dim r As New VB.SysContab.Rutinas()

        Dim rTarjeta As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rTarjeta.Load(Application.StartupPath & "\Reportes\rptTarjetas.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        rTarjeta.SetDataSource(Tarjeta.GetList2(EmpresaActual))
        fReportes.crvReportes.ReportSource = rTarjeta
        freportes.Show()
    End Sub
End Class
