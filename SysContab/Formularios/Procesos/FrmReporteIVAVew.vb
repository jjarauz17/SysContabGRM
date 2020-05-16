Public Class FrmReporteIVAVew
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As FrmReporteIVAVew = Nothing

    Public Shared Function Instance() As FrmReporteIVAVew
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New FrmReporteIVAVew
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkcheque As System.Windows.Forms.RadioButton
    Friend WithEvents chkefectivo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdppagar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdbuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdayuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridVentas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridCompras As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtventas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcompras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txttotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DetalleVenta As System.Windows.Forms.LinkLabel
    Friend WithEvents DetalleCompra As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbmes = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkcheque = New System.Windows.Forms.RadioButton
        Me.chkefectivo = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdppagar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdbuscar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdayuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton
        Me.GridVentas = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridCompras = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtventas = New DevExpress.XtraEditors.TextEdit
        Me.txtcompras = New DevExpress.XtraEditors.TextEdit
        Me.txttotal = New DevExpress.XtraEditors.TextEdit
        Me.DetalleVenta = New System.Windows.Forms.LinkLabel
        Me.DetalleCompra = New System.Windows.Forms.LinkLabel
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtventas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcompras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbmes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmbmes
        '
        Me.cmbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes.Location = New System.Drawing.Point(64, 24)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(121, 21)
        Me.cmbmes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mes :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkcheque)
        Me.GroupBox2.Controls.Add(Me.chkefectivo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(16, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma de Pago"
        '
        'chkcheque
        '
        Me.chkcheque.Checked = True
        Me.chkcheque.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.chkcheque.Location = New System.Drawing.Point(32, 24)
        Me.chkcheque.Name = "chkcheque"
        Me.chkcheque.TabIndex = 0
        Me.chkcheque.TabStop = True
        Me.chkcheque.Text = "Cheque"
        '
        'chkefectivo
        '
        Me.chkefectivo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.chkefectivo.Location = New System.Drawing.Point(32, 56)
        Me.chkefectivo.Name = "chkefectivo"
        Me.chkefectivo.TabIndex = 0
        Me.chkefectivo.Text = "Efectivo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdppagar)
        Me.GroupBox3.Controls.Add(Me.cmdbuscar)
        Me.GroupBox3.Controls.Add(Me.cmdayuda)
        Me.GroupBox3.Controls.Add(Me.cmdsalir)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 320)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'cmdppagar
        '
        Me.cmdppagar.Location = New System.Drawing.Point(16, 24)
        Me.cmdppagar.Name = "cmdppagar"
        Me.cmdppagar.TabIndex = 0
        Me.cmdppagar.Text = "&Pagar"
        '
        'cmdbuscar
        '
        Me.cmdbuscar.Location = New System.Drawing.Point(104, 24)
        Me.cmdbuscar.Name = "cmdbuscar"
        Me.cmdbuscar.TabIndex = 0
        Me.cmdbuscar.Text = "&Buscar"
        Me.cmdbuscar.Visible = False
        '
        'cmdayuda
        '
        Me.cmdayuda.Location = New System.Drawing.Point(16, 56)
        Me.cmdayuda.Name = "cmdayuda"
        Me.cmdayuda.TabIndex = 0
        Me.cmdayuda.Text = "&Ayuda"
        '
        'cmdsalir
        '
        Me.cmdsalir.Location = New System.Drawing.Point(104, 56)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.TabIndex = 0
        Me.cmdsalir.Text = "&Salir"
        '
        'GridVentas
        '
        '
        'GridVentas.EmbeddedNavigator
        '
        Me.GridVentas.EmbeddedNavigator.Name = ""
        Me.GridVentas.Location = New System.Drawing.Point(224, 16)
        Me.GridVentas.MainView = Me.GridView1
        Me.GridVentas.Name = "GridVentas"
        Me.GridVentas.Size = New System.Drawing.Size(456, 192)
        Me.GridVentas.TabIndex = 3
        Me.GridVentas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridVentas
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False

        Me.GridView1.ViewCaption = "V E N T A S"
        '
        'GridCompras
        '
        '
        'GridCompras.EmbeddedNavigator
        '
        Me.GridCompras.EmbeddedNavigator.Name = ""
        Me.GridCompras.Location = New System.Drawing.Point(224, 224)
        Me.GridCompras.MainView = Me.GridView2
        Me.GridCompras.Name = "GridCompras"
        Me.GridCompras.Size = New System.Drawing.Size(456, 192)
        Me.GridCompras.TabIndex = 3
        Me.GridCompras.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridCompras
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False

        Me.GridView2.ViewCaption = "C O M P R A S"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "IVA Ventas :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "IVA Compras :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(195, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total a Pagar :"
        '
        'txtventas
        '
        Me.txtventas.Location = New System.Drawing.Point(104, 216)
        Me.txtventas.Name = "txtventas"
        '
        'txtventas.Properties
        '
        Me.txtventas.Properties.LookAndFeel.UseDefaultLookAndFeel = True
        Me.txtventas.Properties.LookAndFeel.UseWindowsXPTheme = False
        Me.txtventas.Properties.Mask.EditMask = "n2"
        Me.txtventas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtventas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtventas.Properties.NullText = "0.00"
        Me.txtventas.Properties.ReadOnly = True
        Me.txtventas.TabIndex = 4
        '
        'txtcompras
        '
        Me.txtcompras.Location = New System.Drawing.Point(104, 248)
        Me.txtcompras.Name = "txtcompras"
        '
        'txtcompras.Properties
        '
        Me.txtcompras.Properties.LookAndFeel.UseDefaultLookAndFeel = True
        Me.txtcompras.Properties.LookAndFeel.UseWindowsXPTheme = False
        Me.txtcompras.Properties.Mask.EditMask = "n2"
        Me.txtcompras.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtcompras.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtcompras.Properties.NullText = "0.00"
        Me.txtcompras.Properties.ReadOnly = True
        Me.txtcompras.TabIndex = 4
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(104, 280)
        Me.txttotal.Name = "txttotal"
        '
        'txttotal.Properties
        '
        Me.txttotal.Properties.LookAndFeel.UseDefaultLookAndFeel = True
        Me.txttotal.Properties.LookAndFeel.UseWindowsXPTheme = False
        Me.txttotal.Properties.Mask.EditMask = "n2"
        Me.txttotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txttotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttotal.Properties.NullText = "0.00"
        Me.txttotal.Properties.ReadOnly = True
        Me.txttotal.TabIndex = 4
        '
        'DetalleVenta
        '
        Me.DetalleVenta.BackColor = System.Drawing.Color.Transparent
        Me.DetalleVenta.Location = New System.Drawing.Point(232, 188)
        Me.DetalleVenta.Name = "DetalleVenta"
        Me.DetalleVenta.Size = New System.Drawing.Size(80, 16)
        Me.DetalleVenta.TabIndex = 5
        Me.DetalleVenta.TabStop = True
        Me.DetalleVenta.Text = "Ver Detalles"
        '
        'DetalleCompra
        '
        Me.DetalleCompra.BackColor = System.Drawing.Color.Transparent
        Me.DetalleCompra.Location = New System.Drawing.Point(232, 395)
        Me.DetalleCompra.Name = "DetalleCompra"
        Me.DetalleCompra.Size = New System.Drawing.Size(80, 16)
        Me.DetalleCompra.TabIndex = 5
        Me.DetalleCompra.TabStop = True
        Me.DetalleCompra.Text = "Ver Detalles"
        '
        'FrmReporteIVAVew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(688, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.DetalleCompra)
        Me.Controls.Add(Me.DetalleVenta)
        Me.Controls.Add(Me.txtventas)
        Me.Controls.Add(Me.GridVentas)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridCompras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcompras)
        Me.Controls.Add(Me.txttotal)
        Me.Name = "FrmReporteIVAVew"
        Me.Text = "Reporte IVA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtventas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcompras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _Plantilla As String

    Public Property Plantilla()
        Get
            Return _Plantilla
        End Get
        Set(ByVal Value)
            _Plantilla = Value
        End Set
    End Property

    Dim PeriodosDB As New VB.SysContab.PeriodosDB
    Dim Meses As New VB.SysContab.MesesDB
    Dim FactVentasDB As New VB.SysContab.Facturas_VentasDB
    Dim FactComprasDB As New VB.SysContab.Facturas_ComprasDB
    Dim PlantillasDB As New VB.SysContab.PlantillaDB
    Dim ComprobantesDB As New VB.SysContab.ComprobanteDB

    Dim r As New VB.SysContab.Rutinas
    Dim TablaVentas As DataTable
    Dim TablaCompras As DataTable
    Dim dsVentas As DataSet
    Dim dsCompras As DataSet
    Dim I As Integer

    Dim Mes As String
    Dim MesAnterior As String
    Dim FechaDesde As String
    Dim FechaHasta As String
    Dim IVASoportadoAnterior As String
    Dim IVARepercutidoAnterior As String
    Dim MesConcepto As String

    Dim Anio As String

    Private Sub FrmReporteIVAVew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbmes.DataSource = VB.SysContab.MesesDB.MesexPeriodo.Tables("Meses")
        cmbmes.ValueMember = "Mes"
        cmbmes.DisplayMember = "MesAnno"
        cmbmes.SelectedValue = 0
        CalculaTotal()
    End Sub

    Private Sub cmbmes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmes.SelectedIndexChanged
        Anio = Microsoft.VisualBasic.Right(cmbmes.Text, 4)
        CalculaTotal()
    End Sub

    Private Sub CalculaTotal()

        MesAnterior = 0
        'txtCredito.Text = 0
        IVARepercutidoAnterior = 0
        IVASoportadoAnterior = 0


        If Not IsNumeric(cmbmes.SelectedValue) Then
            Exit Sub
        End If
        Mes = cmbmes.SelectedValue
        FechaDesde = ""
        FechaHasta = ""
        If IsNumeric(Mes) = True And Mes > 0 Then
            MesAnterior = Month((New DateTime(Today.Year, Mes, 1)).AddMonths(-1)) 'Month(CDate("01/" & Mes & "/" & Today().Year).AddMonths(-1))
        End If
        MesConcepto = Mes



        GridVentas.DataSource = FactVentasDB.GetIVAxTipo(FechaDesde, FechaHasta, Mes, 0, Microsoft.VisualBasic.Right(Me.cmbmes.Text.ToString, 4)).Tables(0)
        GridCompras.DataSource = FactComprasDB.GetIVAxTipo(FechaDesde, FechaHasta, Mes, 0, 0, Microsoft.VisualBasic.Right(Me.cmbmes.Text.ToString, 4)).Tables(0)

        FormatoGrid(GridView1)
        FormatoGrid(GridView2)

        For i As Integer = 1 To GridView1.Columns.Count - 1
            GridView1.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(i).DisplayFormat.FormatString = "n2"
            GridView1.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            GridView2.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView2.Columns(i).DisplayFormat.FormatString = "n2"
            GridView2.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            GridView1.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            GridView1.Columns(i).SummaryItem.DisplayFormat = "{0:n2}"
            GridView1.Columns(i).SummaryItem.FieldName = GridView1.Columns(i).FieldName
            GridView2.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            GridView2.Columns(i).SummaryItem.DisplayFormat = "{0:n2}"
            GridView2.Columns(i).SummaryItem.FieldName = GridView2.Columns(i).FieldName
        Next


        GridView1.UpdateTotalSummary()
        GridView2.UpdateTotalSummary()

        'txtIVAReper.Text = 0
        'txtIVASoport.Text = 0

        txtventas.EditValue = GridView1.Columns("IVA").SummaryItem.SummaryValue
        txtcompras.EditValue = GridView2.Columns("IVA").SummaryItem.SummaryValue

        If CDbl(txtventas.EditValue) - CDbl(txtcompras.EditValue) <= 0 Then
            txttotal.EditValue = CDbl(0).ToString(Round)
        Else
            txttotal.EditValue = CDbl(CDbl(txtventas.EditValue) - CDbl(txtcompras.EditValue)).ToString(Round)
        End If


    End Sub

    Private Sub cmdayuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdayuda.Click
        Help.ShowHelp(Me, "ayuda/ProcesosEfectuarPagos.chm", HelpNavigator.KeywordIndex, "IVA")
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub DetalleVenta_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DetalleVenta.LinkClicked
        Dim fr As frmReporteIVADetalles = fr.Instance
        fr.MdiParent = Me.MdiParent

        fr.Mes = Mes
        fr.FechaDesde = FechaDesde
        fr.FechaHasta = FechaHasta
        fr.Tipo = 1
        fr.Show()
    End Sub

    Private Sub DetalleCompra_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DetalleCompra.LinkClicked
        Dim fr As frmReporteIVADetalles = fr.Instance
        fr.MdiParent = Me.MdiParent
        fr.Mes = Mes
        fr.FechaDesde = FechaDesde
        fr.FechaHasta = FechaHasta
        fr.Tipo = 2
        fr.Show()
    End Sub

    Private Sub cmdppagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdppagar.Click
        If CDbl(txttotal.EditValue) = 0 And CDbl(txtventas.EditValue) = 0 And CDbl(txtcompras.EditValue) = 0 Then
            MsgBox("No hay ningún Monto a Pagar", MsgBoxStyle.Information)
            Exit Sub
        End If

        If CDbl(txttotal.EditValue) > 0 Then
            '    Dim f1 As DataGridTextBox.frmComprobanteImpuestosIVA1 = f1.Instance
            '    f1.etPlantilla.Text = Plantilla

            '    f1.MontoIVAVentas = CDbl(txtventas.EditValue)
            '    f1.MontoIVACompras = CDbl(txtventas.EditValue)

            '    f1.Mes = cmbmes.SelectedValue
            '    f1.Year = Microsoft.VisualBasic.Right(Me.cmbmes.Text.ToString, 4)

            '    f1.MdiParent = Me.MdiParent
            '    f1.txtValor.Text = txttotal.EditValue 'IIf(Me.chkAnticipo.Checked, CDbl(Me.txtTotal.Text), 0) + IIf(Me.chkGeneral.Checked, CDbl(Me.txtMontoServicioGeneral.Text), 0) + IIf(Me.chkProfesional.Checked, CDbl(Me.txtIRProfesionales.Text), 0) + IIf(Me.chkResidente.Checked, CDbl(Me.txtIRResidentes.Text), 0)
            '    f1.Show()
            'Else
            If Me.chkcheque.Checked = True Then
                Dim f As frmBancosImpuestosIVA = frmBancosImpuestosIVA.Instance()
                f.etPlantilla.Text = Plantilla

                f.MontoIVAVentas = CDbl(Me.txtventas.EditValue)
                f.MontoIVACompras = CDbl(Me.txtcompras.EditValue)

                f.Mes = cmbmes.SelectedValue
                f.Year = Microsoft.VisualBasic.Right(Me.cmbmes.Text.ToString, 4)

                f.MdiParent = Me.MdiParent
                f.lblFactMonto.Text = Me.txttotal.EditValue 'IIf(Me.chkAnticipo.Checked, CDbl(Me.txtTotal.Text), 0) + IIf(Me.chkGeneral.Checked, CDbl(Me.txtMontoServicioGeneral.Text), 0) + IIf(Me.chkProfesional.Checked, CDbl(Me.txtIRProfesionales.Text), 0) + IIf(Me.chkResidente.Checked, CDbl(Me.txtIRResidentes.Text), 0)
                f.Show()
            ElseIf Me.chkefectivo.Checked = True Then
                'Dim f1 As DataGridTextBox.frmComprobanteImpuestosIVACaja = f1.Instance
                'f1.etPlantilla.Text = Plantilla

                'f1.MontoIVAVentas = CDbl(Me.txtventas.EditValue)
                'f1.MontoIVACompras = CDbl(Me.txtcompras.EditValue)

                'f1.Mes = cmbmes.SelectedValue
                'f1.Year = Microsoft.VisualBasic.Right(Me.cmbmes.Text.ToString, 4)

                'f1.MdiParent = Me.MdiParent
                'f1.txtValor.Text = Me.txttotal.EditValue 'IIf(Me.chkAnticipo.Checked, CDbl(Me.txtTotal.Text), 0) + IIf(Me.chkGeneral.Checked, CDbl(Me.txtMontoServicioGeneral.Text), 0) + IIf(Me.chkProfesional.Checked, CDbl(Me.txtIRProfesionales.Text), 0) + IIf(Me.chkResidente.Checked, CDbl(Me.txtIRResidentes.Text), 0)
                'f1.Show()
            End If

        End If
    End Sub
End Class
