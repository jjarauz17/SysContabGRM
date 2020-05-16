Public Class frmOrdenesProceso
    Inherits DevExpress.XtraEditors.XtraForm
    Dim r As New VB.SysContab.Rutinas()
    Dim OrdenProceso As New VB.SysContab.OrdenProcesoDB()

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
    Friend WithEvents dgOrdenesProceso As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgOrdenesProceso = New System.Windows.Forms.DataGrid()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgOrdenesProceso, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgOrdenesProceso
        '
        Me.dgOrdenesProceso.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgOrdenesProceso.BackColor = System.Drawing.Color.Gainsboro
        Me.dgOrdenesProceso.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgOrdenesProceso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgOrdenesProceso.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgOrdenesProceso.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgOrdenesProceso.CaptionForeColor = System.Drawing.Color.Black
        Me.dgOrdenesProceso.DataMember = ""
        Me.dgOrdenesProceso.FlatMode = True
        Me.dgOrdenesProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgOrdenesProceso.ForeColor = System.Drawing.Color.Black
        Me.dgOrdenesProceso.GridLineColor = System.Drawing.Color.Silver
        Me.dgOrdenesProceso.HeaderBackColor = System.Drawing.Color.Black
        Me.dgOrdenesProceso.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgOrdenesProceso.HeaderForeColor = System.Drawing.Color.White
        Me.dgOrdenesProceso.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgOrdenesProceso.Location = New System.Drawing.Point(16, 47)
        Me.dgOrdenesProceso.Name = "dgOrdenesProceso"
        Me.dgOrdenesProceso.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgOrdenesProceso.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgOrdenesProceso.ReadOnly = True
        Me.dgOrdenesProceso.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgOrdenesProceso.SelectionForeColor = System.Drawing.Color.White
        Me.dgOrdenesProceso.Size = New System.Drawing.Size(968, 417)
        Me.dgOrdenesProceso.TabIndex = 16
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
        'frmOrdenesProceso
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(992, 534)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.Label1, Me.dgOrdenesProceso, Me.txtBuscar})
        Me.Name = "frmOrdenesProceso"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgOrdenesProceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmOrdenesProceso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Ordenes en Proceso"
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        r.FormularioColor(Me)
        Dim Tabla As DataTable
        Dim ds As DataSet

        'r.CambiarEstilo(Me)

        ds = OrdenProceso.ListOrdenesProceso("", "P")

        dgOrdenesProceso.DataSource = ds.Tables("Ordenes_Proceso").DefaultView
        Tabla = ds.Tables("Ordenes_Proceso")

        r.FormatGenerico(dgOrdenesProceso, Tabla)

        If ds.Tables("Ordenes_Proceso").Rows.Count <> 0 Then
            RegistroFacturaTemporal = dgOrdenesProceso.Item(0, 1)
        Else
            RegistroFacturaTemporal = "Vacio"
        End If

        dgOrdenesProceso.CaptionText = "Información de Ordenes en Proceso"
        Me.Refresh()
    End Sub

    Private Sub dgFacturasClientes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgOrdenesProceso.CurrentCellChanged
        RegistroOrdenProceso = dgOrdenesProceso.Item(dgOrdenesProceso.CurrentRowIndex, 1)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
        If LoadOrdenProceso = True Then
            Exit Sub
        Else
            LoadOrdenProceso = False
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        RegistroOrdenProceso = dgOrdenesProceso.Item(dgOrdenesProceso.CurrentRowIndex, 1)
        LoadOrdenProceso = True
        Me.Close()
    End Sub

    Private Sub dgFacturasClientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgOrdenesProceso.DoubleClick
        RegistroOrdenProceso = Me.dgOrdenesProceso.Item(Me.dgOrdenesProceso.CurrentRowIndex, 1)
        LoadOrdenProceso = True
        Me.Close()
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Try
            Me.dgOrdenesProceso.DataSource = OrdenProceso.ListOrdenesProceso(txtBuscar.Text, "P").Tables("Ordenes_Proceso").DefaultView

            If OrdenProceso.ListOrdenesProceso(txtBuscar.Text, "P").Tables("Ordenes_Proceso").Rows.Count = 0 Then
                Exit Sub

            End If

            RegistroOrdenProceso = dgOrdenesProceso.Item(dgOrdenesProceso.CurrentRowIndex, 1)
        Catch ex As Exception

        End Try

    End Sub

End Class
