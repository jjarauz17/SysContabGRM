Public Class frmPuntosVenta
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmPuntosVenta = Nothing

    Public Shared Function Instance() As frmPuntosVenta
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPuntosVenta()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgPuntosVentas As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.dgPuntosVentas = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPuntosVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 388)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 60)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(281, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.SysContab.My.Resources.Resources._115_25x25
        Me.cmdSalir.Location = New System.Drawing.Point(377, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(84, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(467, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        Me.cmdImprimir.Visible = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(185, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(95, 17)
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
        Me.txtBuscar.Location = New System.Drawing.Point(96, 17)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(511, 20)
        Me.txtBuscar.TabIndex = 17
        '
        'dgPuntosVentas
        '
        Me.dgPuntosVentas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgPuntosVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPuntosVentas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgPuntosVentas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgPuntosVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgPuntosVentas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgPuntosVentas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgPuntosVentas.CaptionForeColor = System.Drawing.Color.Black
        Me.dgPuntosVentas.DataMember = ""
        Me.dgPuntosVentas.FlatMode = True
        Me.dgPuntosVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPuntosVentas.ForeColor = System.Drawing.Color.Black
        Me.dgPuntosVentas.GridLineColor = System.Drawing.Color.Silver
        Me.dgPuntosVentas.HeaderBackColor = System.Drawing.Color.Black
        Me.dgPuntosVentas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgPuntosVentas.HeaderForeColor = System.Drawing.Color.White
        Me.dgPuntosVentas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgPuntosVentas.Location = New System.Drawing.Point(19, 43)
        Me.dgPuntosVentas.Name = "dgPuntosVentas"
        Me.dgPuntosVentas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgPuntosVentas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgPuntosVentas.ReadOnly = True
        Me.dgPuntosVentas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgPuntosVentas.SelectionForeColor = System.Drawing.Color.White
        Me.dgPuntosVentas.Size = New System.Drawing.Size(588, 339)
        Me.dgPuntosVentas.TabIndex = 15
        '
        'frmPuntosVenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(626, 448)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgPuntosVentas)
        Me.Name = "frmPuntosVenta"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgPuntosVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim PuntosVenta As New VB.SysContab.PuntosVentasDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As New DataTable()
    Dim ds As New DataSet()

    Private Sub frmPuntosVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'r.FormularioColor(Me)
        ''  '''r.CambiarEstilo(Me)
        RolesDB.UsuarioAcciones(GroupBox1)
        ''
        ds = PuntosVenta.List

        dgPuntosVentas.DataSource = ds.Tables("Puntos_Venta").DefaultView
        Tabla = ds.Tables("Puntos_Venta")

        r.FormatGenerico(dgPuntosVentas, Tabla)

        If ds.Tables("Puntos_Venta").Rows.Count <> 0 Then
            Registro = dgPuntosVentas.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        ''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        dgPuntosVentas.CaptionText = "Información de Puntos de Venta"

        Me.Text = "Mantenimiento de Puntos de Venta"
        Me.Refresh()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarPuntoVenta = f.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.txtNombre.Focus()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click

    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/RegPuntoVenta.chm")
        'Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "PuntodeVenta")
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'Dim fReportes As New frmReportes()
        'Dim rPuntoVenta As New rptPuntoVenta()
        'Dim PuntoVenta As New VB.SysContab.PuntosVentasDB()
        'Dim r As New VB.SysContab.Rutinas()

        'rPuntoVenta.SetDataSource(PuntoVenta.GetList2(EmpresaActual))
        'fReportes.crvReportes.ReportSource = rPuntoVenta
        'freportes.Show()
    End Sub
End Class
