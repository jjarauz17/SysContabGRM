Public Class frmInssPagar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmInssPagar = Nothing

    Public Shared Function Instance() As frmInssPagar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmInssPagar()
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
        Me.dgPlanillas.Location = New System.Drawing.Point(16, 17)
        Me.dgPlanillas.Name = "dgPlanillas"
        Me.dgPlanillas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgPlanillas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgPlanillas.ReadOnly = True
        Me.dgPlanillas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgPlanillas.SelectionForeColor = System.Drawing.Color.White
        Me.dgPlanillas.Size = New System.Drawing.Size(888, 497)
        Me.dgPlanillas.TabIndex = 140
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdSalir)
        Me.GroupBox6.Controls.Add(Me.cmdPagar)
        Me.GroupBox6.Location = New System.Drawing.Point(912, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(96, 499)
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
        'frmInssPagar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.dgPlanillas)
        Me.Name = "frmInssPagar"
        CType(Me.dgPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Rutinas As New VB.SysContab.Rutinas()
    Private Sub frmInssPagar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VB.SysContab.Rutinas.CambiarEstilo(Me)
        Dim Ds As New DataSet()
        Ds = VB.SysContab.PeriodoNominaDB.InssPagar()
        dgPlanillas.DataSource = Ds.Tables(0)
        Rutinas.FormatGenerico(dgPlanillas, Ds.Tables(0))
        Me.Text = "Pagar INSS"
        '   pivotGridControl1.DataSource = Ds.Tables(0).DefaultView
    End Sub

    Dim dsLaboral As DataSet
    Dim dsPatronal As DataSet
    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPagar.Click
        If Me.dgPlanillas.CurrentRowIndex < 0 Then
            MsgBox("Seleccione el Mes que desea Pagar", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim f As DataGridTextBoxCombo.frmChequesInss = f.Instance
        f.MdiParent = Me.MdiParent
        f.txtNombre.Text = "INSS" 'NombreEmpresaActual
        f.cbPagar.Enabled = False
        f.txtMonto.Text = CDbl(Me.dgPlanillas.Item(Me.dgPlanillas.CurrentRowIndex, 1)).ToString(Round)
        f.txtMonto.ReadOnly = True
        f.txtRuc.Visible = False
        f.etRuc.Visible = False
        f.etMontoLetras.Text = VB.SysContab.Rutinas.Letras(CDbl(f.txtMonto.Text))

        f.txtConcepto.Text = "Pago Inss Mes " & Me.dgPlanillas.Item(Me.dgPlanillas.CurrentRowIndex, 0)
        'f.Codigo.ColumnComboBox.Enabled = False
        'f.Descripcion.ColumnComboBox.Enabled = False

        f.Mes = Me.dgPlanillas.Item(Me.dgPlanillas.CurrentRowIndex, 2)

        f.etInicio.Text = "1"
        f.Show()
        f.WindowState = FormWindowState.Maximized

        dsLaboral = VB.SysContab.PeriodoNominaDB.InssLaboral(Me.dgPlanillas.Item(Me.dgPlanillas.CurrentRowIndex, 2))
        dsPatronal = VB.SysContab.PeriodoNominaDB.InssPatronal(Me.dgPlanillas.Item(Me.dgPlanillas.CurrentRowIndex, 2))

        Dim newRow1 As DataRow

        newRow1 = f.tCust.NewRow
        newRow1("Codigo1") = dsLaboral.Tables("Tabla").Rows(0).Item("CDet_Cuenta")

        f.tCust.Rows.Add(newRow1)
        f.tCust.Rows(0)("Codigo") = dsLaboral.Tables("Tabla").Rows(0).Item("CDet_Cuenta") & " - " & dsLaboral.Tables("Tabla").Rows(0).Item("NombreCuenta")
        f.tCust.Rows(0)("Descripcion") = dsLaboral.Tables("Tabla").Rows(0).Item("NombreCuenta")
        f.tCust.Rows(0)("Monto") = CDbl(dsLaboral.Tables("Tabla").Rows(0).Item("Monto")).ToString(Round)
        f.tCust.Rows(0)("Concepto") = "Pago Inss Laboral"

        newRow1 = f.tCust.NewRow
        newRow1("Codigo1") = dsLaboral.Tables("Tabla").Rows(0).Item("CDet_Cuenta")

        f.tCust.Rows.Add(newRow1)
        f.tCust.Rows(1)("Codigo") = dsPatronal.Tables("Tabla").Rows(0).Item("CDet_Cuenta") & " - " & dsLaboral.Tables("Tabla").Rows(0).Item("NombreCuenta")
        f.tCust.Rows(1)("Descripcion") = dsPatronal.Tables("Tabla").Rows(0).Item("NombreCuenta")
        f.tCust.Rows(1)("Monto") = CDbl(dsPatronal.Tables("Tabla").Rows(0).Item("Monto")).ToString(Round)
        f.tCust.Rows(1)("Concepto") = "Pago Inss Patronal"

        f.etInicio.Text = "0"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

End Class
