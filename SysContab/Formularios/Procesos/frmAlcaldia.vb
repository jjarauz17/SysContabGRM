Public Class frmAlcaldia
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAlcaldia = Nothing

    Public Shared Function Instance() As frmAlcaldia
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAlcaldia()
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents rbMes As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVentas As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtBanID As System.Windows.Forms.TextBox
    Friend WithEvents etPlantilla As System.Windows.Forms.Label
    Friend WithEvents txtTotalPagar As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCheque As System.Windows.Forms.CheckBox
    Friend WithEvents chkEfectivo As System.Windows.Forms.CheckBox
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.rbMes = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.DGVentas = New System.Windows.Forms.DataGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.txtBanID = New System.Windows.Forms.TextBox()
        Me.etPlantilla = New System.Windows.Forms.Label()
        Me.txtTotalPagar = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCheque = New System.Windows.Forms.CheckBox()
        Me.chkEfectivo = New System.Windows.Forms.CheckBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.DGVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbMes, Me.rbMes})
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 64)
        Me.GroupBox3.TabIndex = 115
        Me.GroupBox3.TabStop = False
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMes.ItemHeight = 15
        Me.cbMes.Location = New System.Drawing.Point(72, 24)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(144, 23)
        Me.cbMes.TabIndex = 4
        '
        'rbMes
        '
        Me.rbMes.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.rbMes.Checked = True
        Me.rbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMes.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.rbMes.Location = New System.Drawing.Point(8, 24)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(72, 24)
        Me.rbMes.TabIndex = 1
        Me.rbMes.TabStop = True
        Me.rbMes.Text = "Mes"
        Me.rbMes.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdAceptar, Me.cmdSalir})
        Me.GroupBox9.Location = New System.Drawing.Point(16, 208)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(240, 104)
        Me.GroupBox9.TabIndex = 116
        Me.GroupBox9.TabStop = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(80, 24)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Pagar"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(80, 64)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Text = "Salir"
        '
        'DGVentas
        '
        Me.DGVentas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.DGVentas.BackColor = System.Drawing.Color.Gainsboro
        Me.DGVentas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DGVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DGVentas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.DGVentas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DGVentas.CaptionForeColor = System.Drawing.Color.Black
        Me.DGVentas.DataMember = ""
        Me.DGVentas.FlatMode = True
        Me.DGVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVentas.ForeColor = System.Drawing.Color.Black
        Me.DGVentas.GridLineColor = System.Drawing.Color.Silver
        Me.DGVentas.HeaderBackColor = System.Drawing.Color.Black
        Me.DGVentas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DGVentas.HeaderForeColor = System.Drawing.Color.White
        Me.DGVentas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DGVentas.Location = New System.Drawing.Point(272, 8)
        Me.DGVentas.Name = "DGVentas"
        Me.DGVentas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.DGVentas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DGVentas.ReadOnly = True
        Me.DGVentas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.DGVentas.SelectionForeColor = System.Drawing.Color.White
        Me.DGVentas.Size = New System.Drawing.Size(712, 240)
        Me.DGVentas.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(272, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(712, 20)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "VENTAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(896, 9)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(80, 16)
        Me.LinkLabel2.TabIndex = 138
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Ver Detalles"
        '
        'txtBanID
        '
        Me.txtBanID.Location = New System.Drawing.Point(368, 320)
        Me.txtBanID.Name = "txtBanID"
        Me.txtBanID.TabIndex = 140
        Me.txtBanID.Text = "0"
        Me.txtBanID.Visible = False
        '
        'etPlantilla
        '
        Me.etPlantilla.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.etPlantilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etPlantilla.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.etPlantilla.Location = New System.Drawing.Point(272, 320)
        Me.etPlantilla.Name = "etPlantilla"
        Me.etPlantilla.Size = New System.Drawing.Size(72, 16)
        Me.etPlantilla.TabIndex = 191
        Me.etPlantilla.Text = "Plantilla"
        Me.etPlantilla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etPlantilla.Visible = False
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPagar.Location = New System.Drawing.Point(400, 256)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.ReadOnly = True
        Me.txtTotalPagar.Size = New System.Drawing.Size(136, 20)
        Me.txtTotalPagar.TabIndex = 196
        Me.txtTotalPagar.Text = ""
        Me.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(162, Byte))
        Me.Label15.Location = New System.Drawing.Point(272, 256)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 16)
        Me.Label15.TabIndex = 197
        Me.Label15.Text = "Total a Pagar:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkCheque, Me.chkEfectivo})
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(16, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 104)
        Me.GroupBox1.TabIndex = 198
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMA DE PAGO"
        '
        'chkCheque
        '
        Me.chkCheque.Checked = True
        Me.chkCheque.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheque.Location = New System.Drawing.Point(16, 24)
        Me.chkCheque.Name = "chkCheque"
        Me.chkCheque.Size = New System.Drawing.Size(160, 24)
        Me.chkCheque.TabIndex = 26
        Me.chkCheque.Text = "Cheque"
        '
        'chkEfectivo
        '
        Me.chkEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEfectivo.Location = New System.Drawing.Point(16, 64)
        Me.chkEfectivo.Name = "chkEfectivo"
        Me.chkEfectivo.Size = New System.Drawing.Size(120, 24)
        Me.chkEfectivo.TabIndex = 25
        Me.chkEfectivo.Text = "Efectivo"
        '
        'frmAlcaldia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.txtTotalPagar, Me.Label15, Me.etPlantilla, Me.txtBanID, Me.LinkLabel2, Me.Label1, Me.DGVentas, Me.GroupBox9, Me.GroupBox3})
        Me.Name = "frmAlcaldia"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.DGVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim PeriodosDB As New VB.SysContab.PeriodosDB()
    Dim Meses As New VB.SysContab.MesesDB()
    Dim FactVentasDB As New VB.SysContab.Facturas_VentasDB()
    Dim PlantillasDB As New VB.SysContab.PlantillaDB()
    Dim ComprobantesDB As New VB.SysContab.ComprobanteDB()

    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As DataTable
    Dim dsVentas As DataSet
    Dim I As Integer

    Dim Mes As String
    Dim MesAnterior As String
    Dim FechaDesde As String
    Dim FechaHasta As String

    Dim MesConcepto As String


    Dim Anio As String
    Private Sub frmAlcaldia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbMes.DataSource = VB.SysContab.MesesDB.MesexPeriodo.Tables("Meses")
        cbMes.ValueMember = "Mes"
        cbMes.DisplayMember = "MesAnno"
        cbMes.SelectedValue = 0

        CalculaTotal()
    End Sub

    Sub CalculaTotal()
        MesAnterior = 0

        If rbMes.Checked = True Then
            If Not IsNumeric(cbMes.SelectedValue) Then
                Exit Sub
            End If
            Mes = cbMes.SelectedValue
            FechaDesde = ""
            FechaHasta = ""
            If IsNumeric(Mes) = True And Mes > 0 Then
                MesAnterior = Month((New DateTime(Today.Year, Mes, 1)).AddMonths(-1)) 'Month(CDate("01/" & Mes & "/" & Today().Year).AddMonths(-1))
            End If
            MesConcepto = Mes

        End If

        dsVentas = FactVentasDB.AlcaldiaImpuestos(Mes, Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4), 2)
        DGVentas.DataSource = dsVentas.Tables("Tablas").DefaultView

        Tabla = dsVentas.Tables("Tablas")
        r.FormatGenerico(DGVentas, Tabla)

        DGVentas.ReadOnly = True

        Me.txtTotalPagar.Text = CDbl(dsVentas.Tables("Tablas").Rows(dsVentas.Tables("Tablas").Rows.Count - 1).Item("Impuesto").ToString).ToString(Round)

    End Sub

    Private Sub rbMes_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMes.CheckedChanged
        cbMes.Enabled = True
    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Anio = Microsoft.VisualBasic.Right(Me.cbMes.Text, 4)
        If Me.cbMes.SelectedIndex = 0 Then
            MsgBox("Seleccione el mes", MsgBoxStyle.Information)
            Me.cbMes.Focus()
            Exit Sub
        End If
        CalculaTotal()
    End Sub

    Private Sub cbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMes.SelectedIndexChanged
        Anio = Microsoft.VisualBasic.Right(Me.cbMes.Text, 4)
        CalculaTotal()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim fr As frmReporteIVADetalles = fr.Instance
        fr.MdiParent = Me.MdiParent

        fr.Mes = Mes
        fr.FechaDesde = FechaDesde
        fr.FechaHasta = FechaHasta
        fr.Tipo = 1
        fr.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim fr As frmReporteIVADetalles = fr.Instance
        fr.MdiParent = Me.MdiParent
        fr.Mes = Mes
        fr.FechaDesde = FechaDesde
        fr.FechaHasta = FechaHasta
        fr.Tipo = 2
        fr.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If CDbl(Me.txtTotalPagar.Text) = 0 Then
            MsgBox("No hay ningún Monto a Pagar", MsgBoxStyle.Information)
            Exit Sub
        End If
        'If CDbl(Me.txtTotalPagar.Text) = 0 Then
        '    Dim f1 As DataGridTextBox.frmComprobanteImpuestosIVA1 = f1.Instance
        '    f1.etPlantilla.Text = Me.etPlantilla.Text
        '    f1.MontoIVAVentas = CDbl(Me.txtTotalPagar.Text)
        '    f1.MdiParent = Me.MdiParent
        '    f1.txtValor.Text = Me.txtTotalPagar.Text
        '    f1.Show()
        'Else
        If Me.chkCheque.Checked = True Then
            Dim f As frmBancosAlcaldiaImpuestos = f.Instance
            f.etPlantilla.Text = Me.etPlantilla.Text

            f.MontoIVAVentas = CDbl(Me.txtTotalPagar.Text)
            f.Mes = cbMes.SelectedValue
            f.Year = Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4)

            f.MdiParent = Me.MdiParent
            f.lblFactMonto.Text = Me.txtTotalPagar.Text
            f.Show()
        ElseIf Me.chkEfectivo.Checked = True Then
            Dim f1 As DataGridTextBox.frmComprobanteAlcaldiaImpuestosCaja = f1.Instance
            f1.etPlantilla.Text = Me.etPlantilla.Text

            f1.MontoIVAVentas = CDbl(Me.txtTotalPagar.Text)

            f1.Mes = cbMes.SelectedValue
            f1.Year = Microsoft.VisualBasic.Right(Me.cbMes.Text.ToString, 4)

            f1.MdiParent = Me.MdiParent
            f1.txtValor.Text = Me.txtTotalPagar.Text
            f1.Show()
        End If

        'End If
    End Sub

    Private Sub chkEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEfectivo.CheckedChanged
        Me.chkCheque.Checked = Not Me.chkEfectivo.Checked
    End Sub

    Private Sub chkCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheque.CheckedChanged
        Me.chkEfectivo.Checked = Not Me.chkCheque.Checked
    End Sub

End Class
