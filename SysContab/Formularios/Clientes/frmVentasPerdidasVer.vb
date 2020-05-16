Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace DataGridTextBoxCombo
    Public Class frmVentasPerdidasVer
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared ChildInstance As frmVentasPerdidasVer = Nothing

        Public Shared Function Instance() As frmVentasPerdidasVer
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New frmVentasPerdidasVer()
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
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
        Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents etTotal As System.Windows.Forms.Label
        Friend WithEvents etTotalT As System.Windows.Forms.Label
        Friend WithEvents dgFacturacionCliente As System.Windows.Forms.DataGrid
        Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtNumero As System.Windows.Forms.TextBox
        Friend WithEvents txtCliente As System.Windows.Forms.TextBox
        Friend WithEvents txtFactura As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.gbBotones = New System.Windows.Forms.GroupBox()
            Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
            Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
            Me.etTotal = New System.Windows.Forms.Label()
            Me.etTotalT = New System.Windows.Forms.Label()
            Me.dgFacturacionCliente = New System.Windows.Forms.DataGrid()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.txtNumero = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtCliente = New System.Windows.Forms.TextBox()
            Me.txtFactura = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox3.SuspendLayout()
            Me.gbBotones.SuspendLayout()
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label1.Location = New System.Drawing.Point(856, 7)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 24)
            Me.Label1.TabIndex = 148
            Me.Label1.Text = "Fecha:"
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label24.Location = New System.Drawing.Point(8, 7)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(64, 24)
            Me.Label24.TabIndex = 147
            Me.Label24.Text = "Cliente:"
            '
            'GroupBox3
            '
            Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.gbBotones, Me.etTotal, Me.etTotalT, Me.dgFacturacionCliente})
            Me.GroupBox3.Location = New System.Drawing.Point(8, 31)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(1008, 488)
            Me.GroupBox3.TabIndex = 149
            Me.GroupBox3.TabStop = False
            '
            'gbBotones
            '
            Me.gbBotones.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.gbBotones.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdAyuda, Me.cmdImprimir, Me.cmdCancelar})
            Me.gbBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbBotones.ForeColor = System.Drawing.Color.Maroon
            Me.gbBotones.Location = New System.Drawing.Point(912, 8)
            Me.gbBotones.Name = "gbBotones"
            Me.gbBotones.Size = New System.Drawing.Size(88, 432)
            Me.gbBotones.TabIndex = 130
            Me.gbBotones.TabStop = False
            '
            'cmdAyuda
            '
            Me.cmdAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAyuda.ForeColor = System.Drawing.Color.Black
            Me.cmdAyuda.Location = New System.Drawing.Point(8, 72)
            Me.cmdAyuda.Name = "cmdAyuda"
            Me.cmdAyuda.Size = New System.Drawing.Size(72, 32)
            Me.cmdAyuda.TabIndex = 127
            Me.cmdAyuda.Text = "Ayuda"
            '
            'cmdImprimir
            '
            Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdImprimir.ForeColor = System.Drawing.Color.Black
            Me.cmdImprimir.Location = New System.Drawing.Point(8, 16)
            Me.cmdImprimir.Name = "cmdImprimir"
            Me.cmdImprimir.Size = New System.Drawing.Size(72, 32)
            Me.cmdImprimir.TabIndex = 30
            Me.cmdImprimir.Text = "&Imprimir"
            '
            'cmdCancelar
            '
            Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancelar.ForeColor = System.Drawing.Color.Black
            Me.cmdCancelar.Location = New System.Drawing.Point(8, 128)
            Me.cmdCancelar.Name = "cmdCancelar"
            Me.cmdCancelar.Size = New System.Drawing.Size(72, 32)
            Me.cmdCancelar.TabIndex = 29
            Me.cmdCancelar.Text = "&Salir"
            '
            'etTotal
            '
            Me.etTotal.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotal.ForeColor = System.Drawing.Color.Maroon
            Me.etTotal.Location = New System.Drawing.Point(688, 448)
            Me.etTotal.Name = "etTotal"
            Me.etTotal.Size = New System.Drawing.Size(168, 32)
            Me.etTotal.TabIndex = 110
            Me.etTotal.Text = "0.00"
            Me.etTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'etTotalT
            '
            Me.etTotalT.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.etTotalT.Location = New System.Drawing.Point(624, 456)
            Me.etTotalT.Name = "etTotalT"
            Me.etTotalT.Size = New System.Drawing.Size(56, 24)
            Me.etTotalT.TabIndex = 109
            Me.etTotalT.Text = "Total:"
            Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dgFacturacionCliente
            '
            Me.dgFacturacionCliente.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
            Me.dgFacturacionCliente.BackColor = System.Drawing.Color.Gainsboro
            Me.dgFacturacionCliente.BackgroundColor = System.Drawing.Color.DarkGray
            Me.dgFacturacionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgFacturacionCliente.CaptionBackColor = System.Drawing.Color.DarkKhaki
            Me.dgFacturacionCliente.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgFacturacionCliente.CaptionForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.DataMember = ""
            Me.dgFacturacionCliente.FlatMode = True
            Me.dgFacturacionCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgFacturacionCliente.ForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.GridLineColor = System.Drawing.Color.Silver
            Me.dgFacturacionCliente.HeaderBackColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dgFacturacionCliente.HeaderForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.LinkColor = System.Drawing.Color.DarkSlateBlue
            Me.dgFacturacionCliente.Location = New System.Drawing.Point(8, 8)
            Me.dgFacturacionCliente.Name = "dgFacturacionCliente"
            Me.dgFacturacionCliente.ParentRowsBackColor = System.Drawing.Color.LightGray
            Me.dgFacturacionCliente.ParentRowsForeColor = System.Drawing.Color.Black
            Me.dgFacturacionCliente.SelectionBackColor = System.Drawing.Color.Firebrick
            Me.dgFacturacionCliente.SelectionForeColor = System.Drawing.Color.White
            Me.dgFacturacionCliente.Size = New System.Drawing.Size(896, 432)
            Me.dgFacturacionCliente.TabIndex = 27
            '
            'dtpFecha
            '
            Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtpFecha.Location = New System.Drawing.Point(920, 7)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
            Me.dtpFecha.TabIndex = 153
            '
            'txtNumero
            '
            Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumero.Location = New System.Drawing.Point(528, 8)
            Me.txtNumero.MaxLength = 50
            Me.txtNumero.Name = "txtNumero"
            Me.txtNumero.ReadOnly = True
            Me.txtNumero.Size = New System.Drawing.Size(104, 20)
            Me.txtNumero.TabIndex = 157
            Me.txtNumero.Text = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label8.Location = New System.Drawing.Point(456, 8)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(64, 24)
            Me.Label8.TabIndex = 156
            Me.Label8.Text = "No. Venta Perdida:"
            '
            'txtCliente
            '
            Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCliente.Location = New System.Drawing.Point(72, 8)
            Me.txtCliente.MaxLength = 50
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.ReadOnly = True
            Me.txtCliente.Size = New System.Drawing.Size(376, 20)
            Me.txtCliente.TabIndex = 155
            Me.txtCliente.Text = ""
            '
            'txtFactura
            '
            Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFactura.Location = New System.Drawing.Point(728, 8)
            Me.txtFactura.MaxLength = 50
            Me.txtFactura.Name = "txtFactura"
            Me.txtFactura.ReadOnly = True
            Me.txtFactura.Size = New System.Drawing.Size(120, 20)
            Me.txtFactura.TabIndex = 159
            Me.txtFactura.Text = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
            Me.Label2.Location = New System.Drawing.Point(640, 8)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(80, 24)
            Me.Label2.TabIndex = 158
            Me.Label2.Text = "No. Factura:"
            '
            'frmVentasPerdidasVer
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(1016, 526)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtFactura, Me.Label2, Me.txtNumero, Me.Label8, Me.txtCliente, Me.Label1, Me.Label24, Me.GroupBox3, Me.dtpFecha})
            Me.Name = "frmVentasPerdidasVer"
            Me.GroupBox3.ResumeLayout(False)
            Me.gbBotones.ResumeLayout(False)
            CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Dim Clientes As New VB.SysContab.ClientesDB()

        Dim r As New VB.SysContab.Rutinas()

        Dim ds As DataSet

        Dim WithEvents tCust As DataTable
        Private WithEvents myDataSet As DataSet

        Dim Cantidad As DataGridTextBoxColumn
        Dim ValorActualCantidad As Double

        Dim i As Integer

        Dim SubTotalFacturaClienteV As Double
        Dim SubTotalFacturaNoDescuentosV As Double
        Dim TotalFacturaClienteV As Double
        Dim TotalDescuentoV As Double

        Private myCheckBoxCol As Integer = 8 'my checkbox column 
        Dim Config As New VB.SysContab.ConfiguracionDB()
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()

        Private Sub frmFacturacionClienteVer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ''r.CambiarEstilo(Me)
            r.FormularioColor(Me)

            ConfigDetalles = Config.GetConfigDetails

            ds = Clientes.VentasPerdidasDetalle(Me.txtNumero.Text) 'Clientes.FacturaDetalleDevolucion(txtFactura.Text)

            dgFacturacionCliente.ReadOnly = True

            txtCliente.Text = ds.Tables("VentasPerdidas").Rows(0).Item("Cliente").ToString
            txtFactura.Text = ds.Tables("VentasPerdidas").Rows(0).Item("Factura").ToString

            dtpFecha.Value = ds.Tables("VentasPerdidas").Rows(0).Item("Fecha")
            dtpFecha.Enabled = False

            'txtDevolucion.Text = ds.Tables("VentasPerdidas").Rows(0).Item("Devolucion")
            Me.txtNumero.ReadOnly = True

            MakeDataSet()
            dgFacturacionCliente.SetDataBinding(myDataSet, "Articulos")
            AddCustomDataTableStyle()

            '
            'SubTotalFacturaClienteV = 0
            'SubTotalFacturaNoDescuentosV = 0
            'TotalFacturaClienteV = 0
            'TotalDescuentoV = 0

            'For i = 0 To tCust.Rows.Count - 1
            '    If tCust.Rows(i)("SubTotal") Is DBNull.Value Or tCust.Rows(i)("SubTotal").ToString = "" Or tCust.Rows(i)("SubTotal").ToString = "0.00" Then
            '        '
            '    ElseIf IsNumeric(tCust.Rows(i)("SubTotal")) And tCust.Rows(i)("SubTotal").ToString <> "" Then
            '        Try
            '            SubTotalFacturaClienteV = SubTotalFacturaClienteV + tCust.Rows(i)("SubTotal")
            '            SubTotalFacturaNoDescuentosV = SubTotalFacturaNoDescuentosV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio"))
            '            TotalDescuentoV = TotalDescuentoV + (tCust.Rows(i)("Cantidad") * tCust.Rows(i)("Precio") * tCust.Rows(i)("Descuento") / 100.0)
            '        Catch ex As Exception
            '            MsgBox(ex.Message)

            '        End Try
            '    End If
            'Next

            'etSaldo.Visible = False
            'etSaldoT.Visible = False

            'etSubTotal.Text = SubTotalFacturaClienteV.ToString(Round)
            'etIva.Text = (SubTotalFacturaClienteV * (ConfigDetalles.IVA / 100.0)).ToString(Round)
            'etTotal.Text = (SubTotalFacturaClienteV + CDbl(etIva.Text)).ToString(Round)

            Me.Text = "Venta Perdida"

        End Sub

        Private Sub MakeDataSet()

            myDataSet = New DataSet("myDataSet")

            tCust = New DataTable("Articulos")

            Dim cArticuloCodigo As DataColumn
            cArticuloCodigo = New DataColumn("ArticuloCodigo")

            Dim cArticulo As DataColumn
            cArticulo = New DataColumn("Articulo")

            Dim cCantidad As DataColumn
            cCantidad = New DataColumn("Cantidad")

            Dim cPrecio As DataColumn
            cPrecio = New DataColumn("Precio")

            Dim cSubTotal As DataColumn
            cSubTotal = New DataColumn("SubTotal")

            Dim cTipo As DataColumn
            cTipo = New DataColumn("Tipo")

            Dim cCodigoTemporal As DataColumn
            cCodigoTemporal = New DataColumn("CodigoTemporal")

            'Dim cAgregar As DataColumn
            'cAgregar = New DataColumn("Agregar", GetType(System.Boolean))

            tCust.Columns.Add(cArticuloCodigo)
            tCust.Columns.Add(cArticulo)
            tCust.Columns.Add(cCantidad)
            tCust.Columns.Add(cPrecio)
            tCust.Columns.Add(cSubTotal)
            tCust.Columns.Add(cTipo)
            tCust.Columns.Add(cCodigoTemporal)
            'tCust.Columns.Add(cAgregar)

            tCust.DefaultView.AllowDelete = False
            tCust.DefaultView.AllowNew = False

            myDataSet.Tables.Add(tCust)

            myDataSet.Tables("Articulos").DefaultView.AllowDelete = False
            myDataSet.Tables("Articulos").DefaultView.AllowNew = False

            Dim newRow1 As DataRow

            Dim j As Integer
            Dim Total As Double
            Total = 0

            For j = 0 To ds.Tables("VentasPerdidas").Rows.Count - 1
                newRow1 = tCust.NewRow
                newRow1("ArticuloCodigo") = ds.Tables("VentasPerdidas").Rows(j).Item("Item")
                tCust.Rows.Add(newRow1)

                tCust.Rows(j)("CodigoTemporal") = ds.Tables("VentasPerdidas").Rows(j).Item("Item")
                tCust.Rows(j)("Articulo") = ds.Tables("VentasPerdidas").Rows(j).Item("Descripcion")
                tCust.Rows(j)("Cantidad") = ds.Tables("VentasPerdidas").Rows(j).Item("Cantidad")
                tCust.Rows(j)("Precio") = CDbl(ds.Tables("VentasPerdidas").Rows(j).Item("Precio")).ToString(Round)
                tCust.Rows(j)("SubTotal") = CDbl((CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio")))).ToString(Round)
                tCust.Rows(j)("Tipo") = ds.Tables("VentasPerdidas").Rows(j).Item("Tipo")

                Total = Total + CDbl((CDbl(tCust.Rows(j)("Cantidad")) * CDbl(tCust.Rows(j)("Precio")))).ToString(Round)
                'tCust.Rows(j)("Agregar") = False

            Next

            Me.etTotal.Text = CDbl(Total).ToString(Round)

        End Sub

        Private Sub AddCustomDataTableStyle()
            Dim ts1 As DataGridTableStyle
            ts1 = New DataGridTableStyle()

            ts1.MappingName = "Articulos"
            ts1.AlternatingBackColor = Color.LightBlue
            Dim colCount As Integer
            colCount = 0

            Dim ArticuloCodigo As DataGridTextBoxColumn
            ArticuloCodigo = New DataGridTextBoxColumn()
            ArticuloCodigo.MappingName = "ArticuloCodigo"
            ArticuloCodigo.HeaderText = "Código"
            ArticuloCodigo.Width = 100
            ArticuloCodigo.Alignment = HorizontalAlignment.Left
            ArticuloCodigo.ReadOnly = True
            ArticuloCodigo.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(ArticuloCodigo)
            colCount = (colCount + 1)

            ArticuloCodigo.NullText = ""


            Dim Articulo As DataGridTextBoxColumn
            Articulo = New DataGridTextBoxColumn()
            Articulo.MappingName = "Articulo"
            Articulo.HeaderText = "Descripción"
            Articulo.Width = 300
            Articulo.Alignment = HorizontalAlignment.Left
            Articulo.ReadOnly = True
            Articulo.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(Articulo)
            colCount = (colCount + 1)

            Articulo.NullText = ""

            'Dim Cantidad As DataGridTextBoxColumn
            Cantidad = New DataGridTextBoxColumn()
            Cantidad.MappingName = "Cantidad"
            Cantidad.HeaderText = "Cantidad"
            Cantidad.Width = 100
            Cantidad.Alignment = HorizontalAlignment.Right
            Cantidad.ReadOnly = False

            ts1.GridColumnStyles.Add(Cantidad)
            colCount = (colCount + 1)

            Cantidad.NullText = ""

            Dim Precio As DataGridTextBoxColumn
            Precio = New DataGridTextBoxColumn()
            Precio.MappingName = "Precio"
            Precio.HeaderText = "Precio"
            Precio.Width = 120
            Precio.Alignment = HorizontalAlignment.Right
            Precio.ReadOnly = True
            Precio.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(Precio)
            colCount = (colCount + 1)

            Precio.NullText = (0).ToString(Round)

            Dim SubTotal As DataGridTextBoxColumn
            SubTotal = New DataGridTextBoxColumn()
            SubTotal.MappingName = "SubTotal"
            SubTotal.HeaderText = "Sub Total"
            SubTotal.Width = 150
            SubTotal.Alignment = HorizontalAlignment.Right
            SubTotal.ReadOnly = True
            SubTotal.Format = "##,###0.00"
            ts1.GridColumnStyles.Add(SubTotal)
            colCount = (colCount + 1)

            SubTotal.NullText = (0).ToString(Round)

            Dim Tipo As DataGridTextBoxColumn
            Tipo = New DataGridTextBoxColumn()
            Tipo.MappingName = "Tipo"
            Tipo.HeaderText = "Tipo"
            Tipo.Width = 75
            Tipo.Alignment = HorizontalAlignment.Left
            Tipo.ReadOnly = True
            ts1.GridColumnStyles.Add(Tipo)
            colCount = (colCount + 1)

            Tipo.NullText = ""

            Dim CodigoTemporal As DataGridTextBoxColumn
            CodigoTemporal = New DataGridTextBoxColumn()
            CodigoTemporal.MappingName = "CodigoTemporal"
            CodigoTemporal.HeaderText = "CodigoTemporal"
            CodigoTemporal.Width = 0
            CodigoTemporal.Alignment = HorizontalAlignment.Left
            CodigoTemporal.ReadOnly = True
            ts1.GridColumnStyles.Add(CodigoTemporal)
            colCount = (colCount + 1)

            CodigoTemporal.NullText = ""

            ts1.AllowSorting = False
            ts1.HeaderFont = dgFacturacionCliente.HeaderFont
            ts1.HeaderBackColor = Color.LightSteelBlue
            ts1.GridLineColor = Color.FromArgb(70, 130, 180)

            dgFacturacionCliente.CaptionVisible = False

            ts1.PreferredRowHeight = 25

            'TS1.DefaultTableStyl
            myDataSet.Tables("Articulos").DefaultView.AllowDelete = False
            'dsTasaCambio.Tables("TASA_CAMBIO").DefaultView.AllowEdit = True
            'ts1.ReadOnly = True
            tCust.DefaultView.AllowDelete = False

            dgFacturacionCliente.CaptionVisible = False

            dgFacturacionCliente.TableStyles.Clear()
            dgFacturacionCliente.TableStyles.Add(ts1)

        End Sub

        Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
            Me.Close()
        End Sub

    End Class

End Namespace
