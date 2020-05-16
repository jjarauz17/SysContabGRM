

Public Class FrmLibroBalanzaDinamico
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
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbTCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents cbCatalogo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbNiveles As System.Windows.Forms.ComboBox
    Friend WithEvents cbMonedaCambio As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbPeriodos As System.Windows.Forms.ComboBox
    Friend WithEvents cbPeriodos2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbAnno As System.Windows.Forms.ComboBox
    Friend WithEvents cbTrimestre As System.Windows.Forms.ComboBox
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents cbAnno2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbTrimestre2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbMes2 As System.Windows.Forms.ComboBox
    Friend WithEvents rbAno As System.Windows.Forms.RadioButton
    Friend WithEvents rbTri As System.Windows.Forms.RadioButton
    Friend WithEvents rbMes As System.Windows.Forms.RadioButton
    Friend WithEvents rbPe As System.Windows.Forms.RadioButton
    Friend WithEvents rbAno2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbTri2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbMes2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbPe2 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbTCuentas = New System.Windows.Forms.ComboBox
        Me.cbCatalogo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbNiveles = New System.Windows.Forms.ComboBox
        Me.cbMonedaCambio = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.cbAnno = New System.Windows.Forms.ComboBox
        Me.rbAno = New System.Windows.Forms.RadioButton
        Me.cbMes = New System.Windows.Forms.ComboBox
        Me.rbMes = New System.Windows.Forms.RadioButton
        Me.cbPeriodos = New System.Windows.Forms.ComboBox
        Me.rbPe = New System.Windows.Forms.RadioButton
        Me.cbTrimestre = New System.Windows.Forms.ComboBox
        Me.rbTri = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbAnno2 = New System.Windows.Forms.ComboBox
        Me.rbAno2 = New System.Windows.Forms.RadioButton
        Me.cbMes2 = New System.Windows.Forms.ComboBox
        Me.rbMes2 = New System.Windows.Forms.RadioButton
        Me.cbPeriodos2 = New System.Windows.Forms.ComboBox
        Me.rbPe2 = New System.Windows.Forms.RadioButton
        Me.cbTrimestre2 = New System.Windows.Forms.ComboBox
        Me.rbTri2 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdSalir)
        Me.GroupBox6.Controls.Add(Me.cmdImprimir)
        Me.GroupBox6.Location = New System.Drawing.Point(624, 8)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(104, 504)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(16, 56)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 24)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(16, 24)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(80, 24)
        Me.cmdImprimir.TabIndex = 0
        Me.cmdImprimir.Text = "Imprimir"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cbTCuentas)
        Me.GroupBox4.Controls.Add(Me.cbCatalogo)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cbNiveles)
        Me.GroupBox4.Controls.Add(Me.cbMonedaCambio)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(600, 168)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tipo de Cuentas:"
        '
        'cbTCuentas
        '
        Me.cbTCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTCuentas.Items.AddRange(New Object() {"BALANCE", "RESULTADO", "TODAS"})
        Me.cbTCuentas.Location = New System.Drawing.Point(160, 24)
        Me.cbTCuentas.Name = "cbTCuentas"
        Me.cbTCuentas.Size = New System.Drawing.Size(384, 23)
        Me.cbTCuentas.TabIndex = 0
        '
        'cbCatalogo
        '
        Me.cbCatalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCatalogo.Location = New System.Drawing.Point(120, 56)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Size = New System.Drawing.Size(424, 23)
        Me.cbCatalogo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Cuenta:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 24)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Niveles:"
        '
        'cbNiveles
        '
        Me.cbNiveles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNiveles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNiveles.Location = New System.Drawing.Point(120, 88)
        Me.cbNiveles.Name = "cbNiveles"
        Me.cbNiveles.Size = New System.Drawing.Size(424, 23)
        Me.cbNiveles.TabIndex = 17
        '
        'cbMonedaCambio
        '
        Me.cbMonedaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonedaCambio.Location = New System.Drawing.Point(120, 120)
        Me.cbMonedaCambio.Name = "cbMonedaCambio"
        Me.cbMonedaCambio.Size = New System.Drawing.Size(424, 23)
        Me.cbMonedaCambio.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 24)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Moneda:"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox8.Controls.Add(Me.cbAnno)
        Me.GroupBox8.Controls.Add(Me.rbAno)
        Me.GroupBox8.Controls.Add(Me.cbMes)
        Me.GroupBox8.Controls.Add(Me.rbMes)
        Me.GroupBox8.Controls.Add(Me.cbPeriodos)
        Me.GroupBox8.Controls.Add(Me.rbPe)
        Me.GroupBox8.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(288, 152)
        Me.GroupBox8.TabIndex = 14
        Me.GroupBox8.TabStop = False
        '
        'cbAnno
        '
        Me.cbAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAnno.ItemHeight = 15
        Me.cbAnno.Location = New System.Drawing.Point(104, 88)
        Me.cbAnno.Name = "cbAnno"
        Me.cbAnno.Size = New System.Drawing.Size(176, 23)
        Me.cbAnno.TabIndex = 7
        '
        'rbAno
        '
        Me.rbAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAno.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbAno.Location = New System.Drawing.Point(8, 88)
        Me.rbAno.Name = "rbAno"
        Me.rbAno.TabIndex = 6
        Me.rbAno.Text = "Año:"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.ItemHeight = 15
        Me.cbMes.Location = New System.Drawing.Point(104, 56)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(176, 23)
        Me.cbMes.TabIndex = 3
        '
        'rbMes
        '
        Me.rbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMes.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbMes.Location = New System.Drawing.Point(8, 56)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.TabIndex = 2
        Me.rbMes.Text = "Mes:"
        '
        'cbPeriodos
        '
        Me.cbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodos.ItemHeight = 15
        Me.cbPeriodos.Location = New System.Drawing.Point(104, 24)
        Me.cbPeriodos.Name = "cbPeriodos"
        Me.cbPeriodos.Size = New System.Drawing.Size(176, 23)
        Me.cbPeriodos.TabIndex = 1
        '
        'rbPe
        '
        Me.rbPe.Checked = True
        Me.rbPe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPe.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbPe.Location = New System.Drawing.Point(8, 24)
        Me.rbPe.Name = "rbPe"
        Me.rbPe.Size = New System.Drawing.Size(120, 24)
        Me.rbPe.TabIndex = 0
        Me.rbPe.TabStop = True
        Me.rbPe.Text = "Periodo:"
        '
        'cbTrimestre
        '
        Me.cbTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTrimestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTrimestre.ItemHeight = 15
        Me.cbTrimestre.Location = New System.Drawing.Point(144, 392)
        Me.cbTrimestre.Name = "cbTrimestre"
        Me.cbTrimestre.Size = New System.Drawing.Size(176, 23)
        Me.cbTrimestre.TabIndex = 5
        Me.cbTrimestre.Visible = False
        '
        'rbTri
        '
        Me.rbTri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTri.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbTri.Location = New System.Drawing.Point(48, 392)
        Me.rbTri.Name = "rbTri"
        Me.rbTri.TabIndex = 4
        Me.rbTri.Text = "Trimestre:"
        Me.rbTri.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox1.Controls.Add(Me.cbAnno2)
        Me.GroupBox1.Controls.Add(Me.rbAno2)
        Me.GroupBox1.Controls.Add(Me.cbMes2)
        Me.GroupBox1.Controls.Add(Me.rbMes2)
        Me.GroupBox1.Controls.Add(Me.cbPeriodos2)
        Me.GroupBox1.Controls.Add(Me.rbPe2)
        Me.GroupBox1.Location = New System.Drawing.Point(320, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 152)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'cbAnno2
        '
        Me.cbAnno2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAnno2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAnno2.ItemHeight = 15
        Me.cbAnno2.Location = New System.Drawing.Point(104, 88)
        Me.cbAnno2.Name = "cbAnno2"
        Me.cbAnno2.Size = New System.Drawing.Size(176, 23)
        Me.cbAnno2.TabIndex = 7
        '
        'rbAno2
        '
        Me.rbAno2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAno2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbAno2.Location = New System.Drawing.Point(8, 88)
        Me.rbAno2.Name = "rbAno2"
        Me.rbAno2.TabIndex = 6
        Me.rbAno2.Text = "Año:"
        '
        'cbMes2
        '
        Me.cbMes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes2.ItemHeight = 15
        Me.cbMes2.Location = New System.Drawing.Point(104, 56)
        Me.cbMes2.Name = "cbMes2"
        Me.cbMes2.Size = New System.Drawing.Size(176, 23)
        Me.cbMes2.TabIndex = 3
        '
        'rbMes2
        '
        Me.rbMes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMes2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbMes2.Location = New System.Drawing.Point(8, 56)
        Me.rbMes2.Name = "rbMes2"
        Me.rbMes2.TabIndex = 2
        Me.rbMes2.Text = "Mes:"
        '
        'cbPeriodos2
        '
        Me.cbPeriodos2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPeriodos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodos2.ItemHeight = 15
        Me.cbPeriodos2.Location = New System.Drawing.Point(104, 24)
        Me.cbPeriodos2.Name = "cbPeriodos2"
        Me.cbPeriodos2.Size = New System.Drawing.Size(176, 23)
        Me.cbPeriodos2.TabIndex = 1
        '
        'rbPe2
        '
        Me.rbPe2.Checked = True
        Me.rbPe2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPe2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbPe2.Location = New System.Drawing.Point(8, 24)
        Me.rbPe2.Name = "rbPe2"
        Me.rbPe2.TabIndex = 0
        Me.rbPe2.TabStop = True
        Me.rbPe2.Text = "Periodo:"
        '
        'cbTrimestre2
        '
        Me.cbTrimestre2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTrimestre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTrimestre2.ItemHeight = 15
        Me.cbTrimestre2.Location = New System.Drawing.Point(416, 408)
        Me.cbTrimestre2.Name = "cbTrimestre2"
        Me.cbTrimestre2.Size = New System.Drawing.Size(176, 23)
        Me.cbTrimestre2.TabIndex = 5
        Me.cbTrimestre2.Visible = False
        '
        'rbTri2
        '
        Me.rbTri2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTri2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbTri2.Location = New System.Drawing.Point(320, 408)
        Me.rbTri2.Name = "rbTri2"
        Me.rbTri2.TabIndex = 4
        Me.rbTri2.Text = "Trimestre:"
        Me.rbTri2.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(296, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "VS"
        '
        'FrmLibroBalanzaDinamico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(736, 517)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.cbTrimestre2)
        Me.Controls.Add(Me.rbTri2)
        Me.Controls.Add(Me.cbTrimestre)
        Me.Controls.Add(Me.rbTri)
        Me.Name = "FrmLibroBalanzaDinamico"
        Me.Text = "Reportes - Balanza de Comprobación"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared ChildInstance As FrmLibroBalanzaDinamico = Nothing
    Private i As Integer
    Dim Catalogo As New VB.SysContab.CatalogoDB
    Dim Grupos As New VB.SysContab.GruposDB
    Dim Periodos As New VB.SysContab.PeriodosDB
    Dim TComprobantes As New VB.SysContab.ComprobanteDB
    Dim Libros As New VB.SysContab.LibrosDB
    Dim r As New VB.SysContab.Rutinas
    Dim tcuenta As String
    Dim Empresa As New VB.SysContab.EmpresasDetails
    Dim Empresas As New VB.SysContab.EmpresasDB



    Public Shared Function Instance() As FrmLibroBalanzaDinamico
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmLibroBalanzaDinamico
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function


    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmLibroBalanzaDinamico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Tasa As New VB.SysContab.Tasa_CambioDB

        'r.CambiarEstilo(Me)
        i = 0


        cbMonedaCambio.DataSource = Tasa.GetListTasaCambioDisponibles().Tables("Tasa_Cambio")
        cbMonedaCambio.ValueMember = "MonedaCambio"
        cbMonedaCambio.DisplayMember = "Nombre"

        cbCatalogo.DataSource = Catalogo.GetList_SP("%").Tables("Catalogo")
        cbCatalogo.ValueMember = "CUENTA"
        cbCatalogo.DisplayMember = "NOMBRE"

        cbNiveles.DataSource = Libros.Niveles().Tables("Niveles") 'Grupos.GetList_SP("%").Tables("Niveles")
        cbNiveles.ValueMember = "Nivel"
        cbNiveles.DisplayMember = "Descripcion"

        cbPeriodos.DataSource = Periodos.GetList().Tables("Periodos")
        cbPeriodos.ValueMember = "codigo"
        cbPeriodos.DisplayMember = "descripcion"

        cbPeriodos2.DataSource = Periodos.GetList().Tables("Periodos")
        cbPeriodos2.ValueMember = "codigo"
        cbPeriodos2.DisplayMember = "descripcion"


        cbMes.DataSource = TComprobantes.GetCriteriosDebitoCredito(VB.SysContab.Tipo.Mes).Tables("Tabla")
        cbMes.ValueMember = "MesAnno"
        cbMes.DisplayMember = "MesAnno"

        cbMes2.DataSource = TComprobantes.GetCriteriosDebitoCredito(VB.SysContab.Tipo.Mes).Tables("Tabla")
        cbMes2.ValueMember = "MesAnno"
        cbMes2.DisplayMember = "MesAnno"

        cbTrimestre.DataSource = TComprobantes.GetCriteriosDebitoCredito(VB.SysContab.Tipo.Trimestre).Tables("Tabla")
        cbTrimestre.ValueMember = "Trimestre"
        cbTrimestre.DisplayMember = "Trimestre"

        cbTrimestre2.DataSource = TComprobantes.GetCriteriosDebitoCredito(VB.SysContab.Tipo.Trimestre).Tables("Tabla")
        cbTrimestre2.ValueMember = "Trimestre"
        cbTrimestre2.DisplayMember = "Trimestre"

        cbAnno.DataSource = TComprobantes.GetCriteriosDebitoCredito(VB.SysContab.Tipo.Ano).Tables("Tabla")
        cbAnno.ValueMember = "Anno"
        cbAnno.DisplayMember = "Anno"

        cbAnno2.DataSource = TComprobantes.GetCriteriosDebitoCredito(VB.SysContab.Tipo.Ano).Tables("Tabla")
        cbAnno2.ValueMember = "Anno"
        cbAnno2.DisplayMember = "Anno"

        Me.cbTCuentas.SelectedItem = "TODAS"

        Me.cbMonedaCambio.SelectedValue = MonedaBase

        Dim Periodo
        Periodo = VB.SysContab.PeriodosDB.Actual
        Dim Per_Detail As New VB.SysContab.PeriodoDetails

        If Periodo <> 0 Then
            Me.cbPeriodos.SelectedValue = Periodo
            Per_Detail = Periodos.GetDetails(Me.cbPeriodos.SelectedValue)
            If Per_Detail.Inicio.Year = CDate(r.Fecha).Year And Per_Detail.Inicio.Month <= CDate(r.Fecha).Month Then
                Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
            ElseIf Per_Detail.Final.Year = CDate(r.Fecha).Year And Per_Detail.Final.Month >= CDate(r.Fecha).Month Then
                Me.cbMes.SelectedItem = Format(CDate(r.Fecha), "yyyy") & "-" & Format(CDate(r.Fecha), "MM")
            Else
                Me.cbMes.SelectedItem = Format(Per_Detail.Inicio, "yyyy") & "-" & Format(Per_Detail.Inicio, "MM")
            End If
        End If

        
    End Sub

    Private Sub cbTCuentas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTCuentas.SelectedIndexChanged

        'Filtrar el listado de cuentas segun el tipo

        Select Case Me.cbTCuentas.SelectedItem.ToUpper
            Case "BALANCE"
                tcuenta = "B"
            Case "RESULTADO"
                tcuenta = "R"
            Case Else
                tcuenta = "%"
        End Select
        cbCatalogo.DataSource = Catalogo.GetList_SP(tcuenta).Tables("Catalogo")
        cbCatalogo.ValueMember = "CUENTA"
        cbCatalogo.DisplayMember = "NOMBRE"

    End Sub


    Private Sub rbPe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPe.CheckedChanged
        If rbPe.Checked = True Then
            rbPe2.Checked = True
            Bloquear1()
        End If
    End Sub

    Private Sub rbPe2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPe2.CheckedChanged
        If rbPe2.Checked = True Then
            rbPe.Checked = True
            Bloquear1()
        End If
    End Sub

    Private Sub rbMes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMes.CheckedChanged
        If rbMes.Checked = True Then
            rbMes2.Checked = True
            Bloquear2()
        End If
    End Sub

    Private Sub rbMes2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMes2.CheckedChanged
        If rbMes2.Checked = True Then
            rbMes.Checked = True
            Bloquear2()
        End If
    End Sub

    Private Sub rbTri_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTri.CheckedChanged
        If rbTri.Checked = True Then
            rbTri2.Checked = True
            Bloquear3()
        End If
    End Sub

    Private Sub rbTri2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTri2.CheckedChanged
        If rbTri2.Checked = True Then
            rbTri.Checked = True
            Bloquear3()
        End If
    End Sub

    Private Sub rbAno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAno.CheckedChanged
        If rbAno.Checked = True Then
            rbAno2.Checked = True
            Bloquear4()
        End If
    End Sub

    Private Sub rbAno2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAno2.CheckedChanged
        If rbAno2.Checked = True Then
            rbAno.Checked = True
            Bloquear4()
        End If
    End Sub

    Sub Bloquear1()
        cbPeriodos.Enabled = True
        cbPeriodos2.Enabled = True
        cbMes.Enabled = False
        cbMes2.Enabled = False
        cbTrimestre.Enabled = False
        cbTrimestre2.Enabled = False
        cbAnno.Enabled = False
        cbAnno2.Enabled = False
    End Sub

    Sub Bloquear2()
        cbPeriodos.Enabled = False
        cbPeriodos2.Enabled = False
        cbMes.Enabled = True
        cbMes2.Enabled = True
        cbTrimestre.Enabled = False
        cbTrimestre2.Enabled = False
        cbAnno.Enabled = False
        cbAnno2.Enabled = False
    End Sub

    Sub Bloquear3()
        cbPeriodos.Enabled = False
        cbPeriodos2.Enabled = False
        cbMes.Enabled = False
        cbMes2.Enabled = False
        cbTrimestre.Enabled = True
        cbTrimestre2.Enabled = True
        cbAnno.Enabled = False
        cbAnno2.Enabled = False
    End Sub

    Sub Bloquear4()
        cbPeriodos.Enabled = False
        cbPeriodos2.Enabled = False
        cbMes.Enabled = False
        cbMes2.Enabled = False
        cbTrimestre.Enabled = False
        cbTrimestre2.Enabled = False
        cbAnno.Enabled = True
        cbAnno2.Enabled = True
    End Sub



    Private Sub cbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMes.SelectedIndexChanged
        If Not IsNumeric(cbMes.SelectedValue) Then
            Exit Sub
        End If
    End Sub

    Private Sub cbTrimestre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTrimestre.SelectedIndexChanged
        If Not IsNumeric(cbTrimestre.SelectedValue) Then
            Exit Sub
        End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes
        Dim Catalogo As New VB.SysContab.CatalogoDB
        Dim Libros As New VB.SysContab.LibrosDB
        Dim r As New VB.SysContab.RutinasNomina

        Dim dsBalanza As New DataSet
        Dim Periodo As New VB.SysContab.PeriodoDetails
        Dim P As New VB.SysContab.PeriodosDB
        Dim Fecha2 As Date
        Dim DetalleNivel As New VB.SysContab.NivelDetailsDB
        Dim rNivel As Integer

        Periodo = P.GetDetails(Me.cbPeriodos.SelectedValue)
        Empresa = Empresas.GetDetails(EmpresaActual)



        'Dim Reporte As New rptBalanzaDinamico

        Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Reporte.Load(Application.StartupPath & "\Reportes\rptBalanzaDinamico.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)


        Dim Mes As Integer = 0
        Dim Mes2 As Integer = 0
        Dim Anno As Integer = 0
        Dim Anno2 As Integer = 0
        Dim Per As Integer = 0
        Dim Per2 As Integer = 0


        If rbPe.Checked = True Then
            Per = cbPeriodos.SelectedValue
            Per2 = cbPeriodos2.SelectedValue
            Anno = 0
            Anno2 = 0
            Mes = 0
            Mes2 = 0
        End If

        If rbMes.Checked = True Then
            Per = 0
            Per2 = 0
            Mes = Month(cbMes.SelectedValue)
            Mes2 = Month(cbMes2.SelectedValue)
            Anno = Year(cbMes.SelectedValue)
            Anno2 = Year(cbMes2.SelectedValue)
        End If

        If rbAno.Checked = True Then
            Per = 0
            Per2 = 0
            Anno = cbAnno.SelectedValue
            Anno2 = cbAnno2.SelectedValue
            Mes = 0
            Mes2 = 0
        End If

        Dim Ds As New DataSet

        Ds = Libros.Imprimir_LibroBalanzaDinamico(Per, Per2, Mes, Mes2, Anno, Anno2, tcuenta, Me.cbCatalogo.SelectedValue, _
                                            Empresa.MonedaBase, Me.cbMonedaCambio.SelectedValue, _
                                            IIf(Me.cbNiveles.SelectedValue = "%", Me.cbNiveles.Items(Me.cbNiveles.Items.Count - 1).row.itemarray(0), Me.cbNiveles.SelectedValue))

        Ds.WriteXml(Application.StartupPath & "\xml\rBalanzaDinamico.xml", XmlWriteMode.WriteSchema)

        Reporte.Database.Tables("LibroBalanzaDinamico").Location = Application.StartupPath & "\xml\rBalanzaDinamico.xml"
        Reporte.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"

        fReportes.crvReportes.ReportSource = Reporte

        fReportes.crvReportes.Zoom(91)
        fReportes.Show()



        
    End Sub
End Class
