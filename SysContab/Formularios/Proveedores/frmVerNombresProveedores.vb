Public Class frmVerNombresProveedores
    Inherits DevExpress.XtraEditors.XtraForm

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
    Friend WithEvents dgNombres As System.Windows.Forms.DataGrid
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgNombres = New System.Windows.Forms.DataGrid
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.dgNombres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgNombres
        '
        Me.dgNombres.DataMember = ""
        Me.dgNombres.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgNombres.Location = New System.Drawing.Point(8, 9)
        Me.dgNombres.Name = "dgNombres"
        Me.dgNombres.Size = New System.Drawing.Size(544, 258)
        Me.dgNombres.TabIndex = 0
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(464, 273)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(88, 26)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        '
        'frmVerNombresProveedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(560, 306)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgNombres)
        Me.Name = "frmVerNombresProveedores"
        Me.Text = "frmVerNombresProveedores"
        CType(Me.dgNombres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Datos As New DataSet

    Private Sub frmVerNombresProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As New VB.SysContab.Rutinas

        Me.dgNombres.DataSource = Datos.Tables(0)
        r.FormatGenerico(Me.dgNombres, Datos.Tables(0))
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class
