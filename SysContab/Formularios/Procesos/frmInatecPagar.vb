Public Class frmInatecPagar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmInatecPagar = Nothing

    Public Shared Function Instance() As frmInatecPagar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmInatecPagar()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " Windows Form Designer generated code "

    Private Sub New()
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
    Friend WithEvents dgPlanillas As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPagar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgPlanillas = New System.Windows.Forms.DataGrid
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdPagar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.dgPlanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgPlanillas
        '
        Me.dgPlanillas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgPlanillas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgPlanillas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgPlanillas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgPlanillas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgPlanillas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgPlanillas.CaptionForeColor = System.Drawing.Color.Black
        Me.dgPlanillas.DataMember = ""
        Me.dgPlanillas.FlatMode = True
        Me.dgPlanillas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPlanillas.ForeColor = System.Drawing.Color.Black
        Me.dgPlanillas.GridLineColor = System.Drawing.Color.Silver
        Me.dgPlanillas.HeaderBackColor = System.Drawing.Color.Black
        Me.dgPlanillas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgPlanillas.HeaderForeColor = System.Drawing.Color.White
        Me.dgPlanillas.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.dgPlanillas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgPlanillas.Location = New System.Drawing.Point(12, 12)
        Me.dgPlanillas.Name = "dgPlanillas"
        Me.dgPlanillas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgPlanillas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgPlanillas.ReadOnly = True
        Me.dgPlanillas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgPlanillas.SelectionForeColor = System.Drawing.Color.White
        Me.dgPlanillas.Size = New System.Drawing.Size(888, 349)
        Me.dgPlanillas.TabIndex = 140
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdSalir)
        Me.GroupBox6.Controls.Add(Me.cmdPagar)
        Me.GroupBox6.Location = New System.Drawing.Point(908, 7)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(96, 349)
        Me.GroupBox6.TabIndex = 141
        Me.GroupBox6.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(8, 60)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 26)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        '
        'cmdPagar
        '
        Me.cmdPagar.Location = New System.Drawing.Point(8, 26)
        Me.cmdPagar.Name = "cmdPagar"
        Me.cmdPagar.Size = New System.Drawing.Size(80, 26)
        Me.cmdPagar.TabIndex = 0
        Me.cmdPagar.Text = "Pagar"
        '
        'frmInatecPagar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 384)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.dgPlanillas)
        Me.Name = "frmInatecPagar"
        CType(Me.dgPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Rutinas As New VB.SysContab.Rutinas()
    Private Sub frmInatecPagar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        VB.SysContab.Rutinas.CambiarEstilo(Me)
        Dim Ds As New DataSet()
        Ds = VB.SysContab.PeriodoNominaDB.InatecPagar()
        dgPlanillas.DataSource = Ds.Tables(0)
        Rutinas.FormatGenerico(dgPlanillas, Ds.Tables(0))
        Me.Text = "Pagar INATEC"
        '   pivotGridControl1.DataSource = Ds.Tables(0).DefaultView
    End Sub


    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPagar.Click
        If Me.dgPlanillas.CurrentRowIndex < 0 Then
            MsgBox("Seleccione el Mes que desea Pagar", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As DataGridTextBoxCombo.frmChequesInatec = f.Instance
        f.MdiParent = Me.MdiParent
        f.txtNombre.Text = "Inatec" 'NombreEmpresaActual
        f.cbPagar.Enabled = False
        f.txtMonto.Text = CDbl(Me.dgPlanillas.Item(Me.dgPlanillas.CurrentRowIndex, 1)).ToString(Round)
        f.txtMonto.ReadOnly = True
        f.txtRuc.Visible = False
        f.etRuc.Visible = False
        f.etMontoLetras.Text = VB.SysContab.Rutinas.Letras(CDbl(f.txtMonto.Text))

        f.txtConcepto.Text = "Pago Inatec Mes " & Me.dgPlanillas.Item(Me.dgPlanillas.CurrentRowIndex, 0)
        'f.Codigo.ColumnComboBox.Enabled = False
        'f.Descripcion.ColumnComboBox.Enabled = False

        f.Mes = Me.dgPlanillas.Item(Me.dgPlanillas.CurrentRowIndex, 4)

        f.etInicio.Text = "1"
        f.Show()
        f.WindowState = FormWindowState.Maximized

        Dim newRow1 As DataRow
        newRow1 = f.tCust.NewRow
        newRow1("Codigo1") = Me.dgPlanillas.Item(Me.dgPlanillas.CurrentRowIndex, 2)

        f.tCust.Rows.Add(newRow1)
        f.tCust.Rows(0)("Codigo") = Me.dgPlanillas.Item(Me.dgPlanillas.CurrentRowIndex, 2) & " - " & Me.dgPlanillas.Item(Me.dgPlanillas.CurrentRowIndex, 3)
        f.tCust.Rows(0)("Descripcion") = Me.dgPlanillas.Item(Me.dgPlanillas.CurrentRowIndex, 3)
        f.tCust.Rows(0)("Monto") = CDbl(f.txtMonto.Text).ToString(Round)
        f.tCust.Rows(0)("Concepto") = "Pago Inatec"

        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

End Class
