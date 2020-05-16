Public Class frmFacturasComprasContadoContabilizar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmFacturasComprasContadoContabilizar = Nothing

    Public Shared Function Instance() As frmFacturasComprasContadoContabilizar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmFacturasComprasContadoContabilizar()
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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoProv As System.Windows.Forms.Label
    Friend WithEvents dgProveedores As System.Windows.Forms.DataGrid
    Friend WithEvents etPlantilla As System.Windows.Forms.Label
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.dgProveedores = New System.Windows.Forms.DataGrid
        Me.lblTipoProv = New System.Windows.Forms.Label
        Me.etPlantilla = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 366)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 52)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(104, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 26)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(192, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(80, 26)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Contabilizar"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(96, 9)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(512, 20)
        Me.txtBuscar.TabIndex = 13
        '
        'dgProveedores
        '
        Me.dgProveedores.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgProveedores.BackColor = System.Drawing.Color.Gainsboro
        Me.dgProveedores.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgProveedores.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgProveedores.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgProveedores.CaptionForeColor = System.Drawing.Color.Black
        Me.dgProveedores.DataMember = ""
        Me.dgProveedores.FlatMode = True
        Me.dgProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgProveedores.ForeColor = System.Drawing.Color.Black
        Me.dgProveedores.GridLineColor = System.Drawing.Color.Silver
        Me.dgProveedores.HeaderBackColor = System.Drawing.Color.Black
        Me.dgProveedores.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgProveedores.HeaderForeColor = System.Drawing.Color.White
        Me.dgProveedores.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgProveedores.Location = New System.Drawing.Point(16, 43)
        Me.dgProveedores.Name = "dgProveedores"
        Me.dgProveedores.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgProveedores.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgProveedores.ReadOnly = True
        Me.dgProveedores.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgProveedores.SelectionForeColor = System.Drawing.Color.White
        Me.dgProveedores.Size = New System.Drawing.Size(741, 317)
        Me.dgProveedores.TabIndex = 12
        '
        'lblTipoProv
        '
        Me.lblTipoProv.Location = New System.Drawing.Point(680, 517)
        Me.lblTipoProv.Name = "lblTipoProv"
        Me.lblTipoProv.Size = New System.Drawing.Size(100, 25)
        Me.lblTipoProv.TabIndex = 16
        Me.lblTipoProv.Text = "Label2"
        Me.lblTipoProv.Visible = False
        '
        'etPlantilla
        '
        Me.etPlantilla.Location = New System.Drawing.Point(502, 393)
        Me.etPlantilla.Name = "etPlantilla"
        Me.etPlantilla.Size = New System.Drawing.Size(100, 25)
        Me.etPlantilla.TabIndex = 17
        Me.etPlantilla.Text = "Plantilla"
        Me.etPlantilla.Visible = False
        '
        'frmFacturasComprasContadoContabilizar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 441)
        Me.Controls.Add(Me.etPlantilla)
        Me.Controls.Add(Me.lblTipoProv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgProveedores)
        Me.Name = "frmFacturasComprasContadoContabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas()
    Public Fact As String
    Public FactValor As String

    Private Sub frmFacturasComprasContadoContabilizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim FacturasDB As New VB.SysContab.Facturas_ComprasDB()
        Dim Tabla As DataTable
        Dim ds As DataSet

        '  '''r.CambiarEstilo(Me)
        ''r.FormularioColor(Me)

        ds = FacturasDB.FacturasComprasContado(lblTipoProv.Text)

        dgProveedores.DataSource = ds.Tables("Tablas").DefaultView
        Tabla = ds.Tables("Tablas")

        r.FormatGenerico(dgProveedores, Tabla)

        If ds.Tables("Tablas").Rows.Count <> 0 Then
            Registro = dgProveedores.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        dgProveedores.CaptionText = "Información de Facturas"
        Me.Text = "Facturas"
        Me.Refresh()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim Config As New VB.SysContab.ConfiguracionDB()
        Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails()

        ConfigDetalles = Config.GetConfigDetails

        Fact = Me.dgProveedores.Item(Me.dgProveedores.CurrentRowIndex, 0)
        FactValor = Me.dgProveedores.Item(Me.dgProveedores.CurrentRowIndex, 9)

        Dim Subtotal As String = Me.dgProveedores.Item(Me.dgProveedores.CurrentRowIndex, 7)
        Dim IVA As String = Me.dgProveedores.Item(Me.dgProveedores.CurrentRowIndex, 8)
        Dim FechaFact As String = Me.dgProveedores.Item(Me.dgProveedores.CurrentRowIndex, 1)

        Dim IR As String

        IR = CDbl(CDbl(Subtotal).ToString(Round)) * (CDbl(ConfigDetalles.IRProd) / 100.0)

        FactValor = CDbl(CDbl(Subtotal).ToString(Round)) + CDbl(CDbl(IVA).ToString(Round)) - CDbl(CDbl(IR).ToString(Round))

        Dim CuentaIngr As String
        Dim CuentaIVA As String
        Dim CuentaCaja As String
        Dim CuentaIR As String

        Dim Comprobantes As New VB.SysContab.ComprobanteDB()
        Dim Plantilla As New VB.SysContab.PlantillaDB()
        Dim TasaCambio As New VB.SysContab.Tasa_CambioDB()


        'Dim Todos As Integer
        'If ckbTodos.Checked = True Then
        '    Todos = 1
        'Else
        '    Todos = 0
        'End If

        'If TipoFact = 1 Then

        Dim TipoCOmpr As String = Plantilla.GetPlantillasDetails(6, 1).TipoCompr
        'Dim TipoCOmpr As String = Plantilla.GetPlantillasDetails(2, 6).TipoCompr
        'Dim TipoCOmpr As String = Plantilla.GetPlantillasDetails(4, 1).TipoCompr

        'Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(2, 6).Detalles

        Dim plan As String
        Dim ds As DataSet
        'plan = Plantilla.GetTipoPlantilla(4, 1).ToString
        plan = Plantilla.GetTipoPlantilla(1, 6).ToString

        Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(plan)
        ds = Detalles.Detalles

        'Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(2, 6).Detalles
        CuentaCaja = "1000 01 01" 'ds.Tables("PlantillasDetalles").Rows(0).Item("Cuenta") 'DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        CuentaIR = "1400 08" 'ds.Tables("PlantillasDetalles").Rows(1).Item("Cuenta") 'DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
        CuentaIngr = "4000 01 01" 'ds.Tables("PlantillasDetalles").Rows(2).Item("Cuenta") 'DsPlantillas.Tables("PlantillasDetalles").Rows(2).Item("Cuenta")
        CuentaIVA = "2400 01 01" 'ds.Tables("PlantillasDetalles").Rows(3).Item("Cuenta") 'DsPlantillas.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")

        ' FALTA la Moneda y la tasa de cambio
        If Comprobantes.ContabilizaFacturaCompra(CuentaCaja, FactValor, "Por Factura No. " & Fact, _
                                                  CuentaIngr, Subtotal, "Ingreso por Fact No. " & Fact, _
                                                   CuentaIVA, IVA, "IVA Por Fact. No. " & Fact, TipoCOmpr, _
                                                 1, _
                                                1, "Comprobante de Factura No. " & Fact, TipoCOmpr, FechaFact, Fact, CuentaIR, IR, "IR Por Fact. No " & Fact, 1) = True Then

            MsgBox("Se ha contabilizado correctamente la Factura", MsgBoxStyle.Information)

            'Dim DS As New DataSet()
            'DS = FactVentas.GetListContado(dtpFecha.Value, Todos)
            'dgEstadoCuenta.DataSource = DS.Tables("Tablas").DefaultView
            'Tabla = DS.Tables("Tablas")


        Else
            MsgBox("No se ha podido contabilizar la Factura", MsgBoxStyle.Exclamation)
        End If

        'If Plantilla.GetPlantillasDetails(6, 1).PlaID Is DBNull.Value Or Plantilla.GetPlantillasDetails(6, 1).PlaID Is Nothing Or Plantilla.GetPlantillasDetails(6, 1).PlaID = "" Then
        If Plantilla.GetPlantillasDetails(2, 6).PlaID Is DBNull.Value Or Plantilla.GetPlantillasDetails(2, 6).PlaID Is Nothing Or Plantilla.GetPlantillasDetails(2, 6).PlaID = "" Then
            'MsgBox("No existen plantilla del tipo Pago de Contado")
            'Return
        Else
            ''Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(6, 1).Detalles
            'Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(2, 6).Detalles
            'CuentaCaja = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
            'CuentaIR = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
            'CuentaIngr = DsPlantillas.Tables("PlantillasDetalles").Rows(2).Item("Cuenta")
            'CuentaIVA = DsPlantillas.Tables("PlantillasDetalles").Rows(3).Item("Cuenta")

            '' FALTA la Moneda y la tasa de cambio
            'If Comprobantes.ContabilizaFacturaCompra(CuentaCaja, FactValor, "Por Factura No. " & Fact, _
            '                                          CuentaIngr, Subtotal, "Ingreso por Fact No. " & Fact, _
            '                                           CuentaIVA, IVA, "IVA Por Fact. No. " & Fact, TipoCOmpr, _
            '                                         1, _
            '                                        1, "Comprobante de Factura No. " & Fact, TipoCOmpr, FechaFact, Fact, CuentaIR, IR, "IR Por Fact. No " & Fact, 1) = True Then

            '    MsgBox("Se ha contabilizado correctamente la Factura", MsgBoxStyle.Information)

            '    'Dim DS As New DataSet()
            '    'DS = FactVentas.GetListContado(dtpFecha.Value, Todos)
            '    'dgEstadoCuenta.DataSource = DS.Tables("Tablas").DefaultView
            '    'Tabla = DS.Tables("Tablas")

            'Else
            '    MsgBox("No se ha podido contabilizar la Factura", MsgBoxStyle.Exclamation)
            'End If
        End If

        'End If
        ''Crédito
        'If TipoFact = 2 Then

        '    Dim Cliente As String = dgEstadoCuenta.Item(dgEstadoCuenta.CurrentRowIndex, 0)

        '    Dim ClientesDB As New VB.SysContab.ClientesDB()

        '    Dim TipoCOmpr As String = Plantilla.GetPlantillasDetails(4, 2).TipoCompr

        '    If Plantilla.GetPlantillasDetails(4, 2).PlaID Is DBNull.Value Or Plantilla.GetPlantillasDetails(4, 2).PlaID Is Nothing Or Plantilla.GetPlantillasDetails(4, 2).PlaID = "" Then
        '        MsgBox("No existen plantilla del tipo Pago de Crédito")
        '        Return
        '    Else
        '        Dim DsPlantillas As DataSet = Plantilla.GetPlantillasDetails(4, 2).Detalles
        '        CuentaIngr = DsPlantillas.Tables("PlantillasDetalles").Rows(0).Item("Cuenta")
        '        CuentaIVA = DsPlantillas.Tables("PlantillasDetalles").Rows(1).Item("Cuenta")
        '        FactValor = CDbl(CDbl(Subtotal).ToString(Round)) + CDbl(CDbl(IVA).ToString(Round))
        '        IR = 0

        '        If Comprobantes.GeneraComprobanteFactura(ClientesDB.GetDetails(Cliente).Cuenta, FactValor, "Por Factura No." & Fact, _
        '                                   CuentaIngr, Subtotal, "Ingreso por Fact No." & Fact, _
        '                                   CuentaIVA, IVA, "IVA Por Fact. No." & Fact, TipoCOmpr, _
        '                                1, _
        '                                1, "Comprobante de Factura No. " & Fact, TipoCOmpr, FechaFact, Fact, CuentaIR, IR, "IR Por Fact. No " & Fact, 2) = True Then
        '            MsgBox("Se ha contabilizado correctamente la Factura", MsgBoxStyle.Information)
        '            Dim DS As New DataSet()

        '            DS = FactVentas.GetListContado(dtpFecha.Value, Todos)


        '            dgEstadoCuenta.DataSource = DS.Tables("Tablas").DefaultView
        '            Tabla = DS.Tables("Tablas")

        '        Else
        '            MsgBox("No se ha podido contabilizar la Factura", MsgBoxStyle.Exclamation)
        '        End If
        '    End If
        'End If

        ''''Fact = dgProveedores.Item(dgProveedores.CurrentRowIndex, 0)
        ''''FactValor = dgProveedores.Item(dgProveedores.CurrentRowIndex, 9)

        ''''Dim fr As frmBancosContabilizarContado = fr.Instance
        ''''fr.MdiParent = Me.MdiParent

        ''''fr.etPlantilla.Text = Me.etPlantilla.Text
        ''''fr.lblProv.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 3)
        ''''fr.lblProvID.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 2)
        ''''fr.etCodigoProveedor.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 10)
        ''''fr.lblFact.Text = Fact
        ''''fr.lblFactMonto.Text = FactValor
        ''''fr.etIva.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 8)
        ''''fr.etSubTotal.Text = dgProveedores.Item(dgProveedores.CurrentRowIndex, 7)
        ''''fr.Show()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmListaFacturaProveedores_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        '''
    End Sub

    Private Sub dgFacturasProveedores_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgProveedores.MouseEnter
        '''
    End Sub

    Private Sub dgFacturasProveedores_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgProveedores.CurrentCellChanged
        Registro = dgProveedores.Item(dgProveedores.CurrentRowIndex, 0)
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/Procesos/ProcesosContab.chm", HelpNavigator.KeywordIndex, "Sec2.1")
    End Sub
End Class
