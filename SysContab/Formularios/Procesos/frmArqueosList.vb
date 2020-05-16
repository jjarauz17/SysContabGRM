Public Class frmArqueosList
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmArqueosList = Nothing

    Public Shared Function Instance() As frmArqueosList
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmArqueosList()
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
    Friend WithEvents dgArqueos As System.Windows.Forms.DataGrid
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
        Me.dgArqueos = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgArqueos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(16, 465)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 51)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(392, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 26)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(488, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(200, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 26)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(296, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 26)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(104, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 26)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 26)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Nuevo"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(96, 17)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(384, 20)
        Me.txtBuscar.TabIndex = 17
        '
        'dgArqueos
        '
        Me.dgArqueos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgArqueos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgArqueos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgArqueos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgArqueos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgArqueos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgArqueos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgArqueos.DataMember = ""
        Me.dgArqueos.FlatMode = True
        Me.dgArqueos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgArqueos.ForeColor = System.Drawing.Color.Black
        Me.dgArqueos.GridLineColor = System.Drawing.Color.Silver
        Me.dgArqueos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgArqueos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgArqueos.HeaderForeColor = System.Drawing.Color.White
        Me.dgArqueos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgArqueos.Location = New System.Drawing.Point(16, 52)
        Me.dgArqueos.Name = "dgArqueos"
        Me.dgArqueos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgArqueos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgArqueos.ReadOnly = True
        Me.dgArqueos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgArqueos.SelectionForeColor = System.Drawing.Color.White
        Me.dgArqueos.Size = New System.Drawing.Size(976, 413)
        Me.dgArqueos.TabIndex = 15
        '
        'frmArqueosList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1008, 525)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgArqueos)
        Me.Name = "frmArqueosList"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgArqueos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim Clientes As New VB.SysContab.ClientesDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As New DataTable()
    Dim ds As New DataSet()

    Private Sub frmPuntosVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r.FormularioColor(Me)
        'r.CambiarEstilo(Me)

        ds = Clientes.ArqueosList

        dgArqueos.DataSource = ds.Tables("Cobros").DefaultView
        Tabla = ds.Tables("Cobros")

        r.FormatGenerico(dgArqueos, Tabla)

        If ds.Tables("Cobros").Rows.Count <> 0 Then
            Registro = dgArqueos.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        dgArqueos.CaptionText = "Información de Arqueos"

        Me.Text = "Lista de Arqueos"
        Me.Refresh()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        'Dim f As frmAgregarPuntoVenta = f.Instance
        'Nuevo = "SI"
        'f.MdiParent = Me.MdiParent
        'f.Show()
        'f.txtNombre.Focus()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub dgArqueos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgArqueos.DoubleClick
        Dim f As frmArqueo = f.Instance
        f.Arqueo = dgArqueos.Item(dgArqueos.CurrentRowIndex, 0)
        f.Fecha = dgArqueos.Item(dgArqueos.CurrentRowIndex, 2)
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub cmdModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmArqueo = f.Instance
        f.Arqueo = dgArqueos.Item(dgArqueos.CurrentRowIndex, 0)
        f.Fecha = dgArqueos.Item(dgArqueos.CurrentRowIndex, 2)
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

End Class
