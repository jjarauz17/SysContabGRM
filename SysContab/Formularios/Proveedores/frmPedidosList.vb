Public Class frmPedidosList
    Inherits DevExpress.XtraEditors.XtraForm

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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgPedidos As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgPedidos = New System.Windows.Forms.DataGrid()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdSalir, Me.cmdAceptar})
        Me.GroupBox1.Location = New System.Drawing.Point(16, 472)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 48)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(136, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 16)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(96, 15)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(512, 20)
        Me.txtBuscar.TabIndex = 17
        Me.txtBuscar.Text = ""
        '
        'dgPedidos
        '
        Me.dgPedidos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgPedidos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgPedidos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgPedidos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgPedidos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgPedidos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgPedidos.DataMember = ""
        Me.dgPedidos.FlatMode = True
        Me.dgPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPedidos.ForeColor = System.Drawing.Color.Black
        Me.dgPedidos.GridLineColor = System.Drawing.Color.Silver
        Me.dgPedidos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgPedidos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgPedidos.HeaderForeColor = System.Drawing.Color.White
        Me.dgPedidos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgPedidos.Location = New System.Drawing.Point(16, 47)
        Me.dgPedidos.Name = "dgPedidos"
        Me.dgPedidos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgPedidos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgPedidos.ReadOnly = True
        Me.dgPedidos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgPedidos.SelectionForeColor = System.Drawing.Color.White
        Me.dgPedidos.Size = New System.Drawing.Size(968, 417)
        Me.dgPedidos.TabIndex = 16
        '
        'frmPedidosList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(992, 534)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.Label1, Me.txtBuscar, Me.dgPedidos})
        Me.Name = "frmPedidosList"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim r As New VB.SysContab.Rutinas()
    'Dim FacturaTemporal As New VB.SysContab.Facturas_Ventas_TemporalDB()
    Dim Pedidos As New VB.SysContab.PedidosDB()
    Public Proveedor As String
    Public Salir As Boolean
    Dim ds As DataSet

    Private Sub frmOrdenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "P e d i d o s  a  P r o v e e d o r e s"
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        r.FormularioColor(Me)
        Dim Tabla As DataTable

        'r.CambiarEstilo(Me)

        ds = Pedidos.PedidosList(0, 1)

        dgPedidos.DataSource = ds.Tables("Pedidos").DefaultView
        Tabla = ds.Tables("Pedidos")

        r.FormatGenerico(dgPedidos, Tabla)

        Salir = True

        'If ds.Tables("Ordenes").Rows.Count <> 0 Then
        '    RegistroOrden = dgOrdenes.Item(0, 1)
        'Else
        '    RegistroOrden = "Vacio"
        'End If

        dgPedidos.CaptionText = "Información de Pedidos"
        Me.Refresh()

    End Sub

    Private Sub dgpedidos_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgPedidos.CurrentCellChanged
        'RegistroOrden = dgOrdenes.Item(dgOrdenes.CurrentRowIndex, 1)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Salir = True
        Me.Close()

        'If etCargarPedido.Text = "1" Then
        '    Exit Sub
        'Else
        '    etCargarPedido.Text = "0"
        'End If

        'If LoadOrden = True Then
        '    Exit Sub
        'Else
        '    LoadOrden = False
        'End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'If Me.dgPedidos.CurrentRowIndex = ds.Tables("Pedidos").Rows.Count - 1 Then
        '    MsgBox("Seleccione un Pedido", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        If Me.dgPedidos.CurrentRowIndex < 0 Then
            MsgBox("Seleccione un Pedido", MsgBoxStyle.Information)
            Exit Sub
        End If

        Salir = False
        'etCargarPedido.Text = "1"
        Me.Close()
        'RegistroOrden = dgOrdenes.Item(dgOrdenes.CurrentRowIndex, 1)
        'LoadOrden = True
        'Me.Close()
    End Sub

    Private Sub dgPedidos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgPedidos.DoubleClick
        If Me.dgPedidos.CurrentRowIndex = ds.Tables("Pedidos").Rows.Count - 1 Then
            MsgBox("Seleccione un Pedido", MsgBoxStyle.Information)
            Exit Sub
        End If
        'etCargarPedido.Text = "1"
        Salir = False
        Me.Close()
        'RegistroOrden = dgOrdenes.Item(dgOrdenes.CurrentRowIndex, 1)
        'LoadOrden = True
        'Me.Close()
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        'Try
        '    dgOrdenes.DataSource = Ordenes.ListOrdenes(txtBuscar.Text, "P").Tables("Ordenes").DefaultView

        '    If Ordenes.ListOrdenes(txtBuscar.Text, "P").Tables("Ordenes").Rows.Count = 0 Then
        '        Exit Sub

        '    End If

        '    RegistroOrden = dgOrdenes.Item(dgOrdenes.CurrentRowIndex, 1)
        'Catch ex As Exception

        'End Try

    End Sub

End Class
