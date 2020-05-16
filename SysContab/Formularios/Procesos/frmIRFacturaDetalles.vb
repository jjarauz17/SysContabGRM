Public Class frmIRFacturaDetalles
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmIRFacturaDetalles = Nothing

    Public Shared Function Instance() As frmIRFacturaDetalles
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmIRFacturaDetalles()
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
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Salir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents dgFacturas As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Salir = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.dgFacturas = New System.Windows.Forms.DataGrid()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.AddRange(New System.Windows.Forms.Control() {Me.Salir})
        Me.GroupBox9.Location = New System.Drawing.Point(24, 456)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(976, 48)
        Me.GroupBox9.TabIndex = 124
        Me.GroupBox9.TabStop = False
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Salir.Location = New System.Drawing.Point(888, 16)
        Me.Salir.Name = "Salir"
        Me.Salir.TabIndex = 1
        Me.Salir.Text = "Salir"
        '
        'lblTipo
        '
        Me.lblTipo.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(8, 8)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(1000, 20)
        Me.lblTipo.TabIndex = 122
        Me.lblTipo.Text = "VENTAS"
        Me.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgFacturas
        '
        Me.dgFacturas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgFacturas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgFacturas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgFacturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgFacturas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgFacturas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturas.CaptionForeColor = System.Drawing.Color.Black
        Me.dgFacturas.DataMember = ""
        Me.dgFacturas.FlatMode = True
        Me.dgFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturas.ForeColor = System.Drawing.Color.Black
        Me.dgFacturas.GridLineColor = System.Drawing.Color.Silver
        Me.dgFacturas.HeaderBackColor = System.Drawing.Color.Black
        Me.dgFacturas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturas.HeaderForeColor = System.Drawing.Color.White
        Me.dgFacturas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgFacturas.Location = New System.Drawing.Point(8, 8)
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgFacturas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgFacturas.ReadOnly = True
        Me.dgFacturas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgFacturas.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturas.Size = New System.Drawing.Size(1000, 440)
        Me.dgFacturas.TabIndex = 123
        '
        'frmIRFacturaDetalles
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox9, Me.lblTipo, Me.dgFacturas})
        Me.Name = "frmIRFacturaDetalles"
        Me.Text = "Reporte I.R. Detalles"
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Mes As String
    Public FechaDesde As String
    Public FechaHasta As String
    Public Tipo As String
    Dim FactVentasDB As New VB.SysContab.Facturas_VentasDB()
    Dim FactComprasDB As New VB.SysContab.Facturas_ComprasDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Tabla As DataTable
    Dim dsFacturas As DataSet
    Dim I As Integer

    Private Sub frmIRFacturaDetalles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Tipo = 1 Then
            lblTipo.Text = "Facturas de Ventas"
            dsFacturas = FactVentasDB.GetFacturasDetalles(FechaDesde, FechaHasta, Mes)
            dgFacturas.DataSource = dsFacturas.Tables("Tablas").DefaultView
            Tabla = dsFacturas.Tables("Tablas")
            r.FormatGenerico(dgFacturas, Tabla)
        End If

        If Tipo = 2 Then
            lblTipo.Text = "Facturas de Compras"

            dsFacturas = FactComprasDB.GetFacturasDetalles(FechaDesde, FechaHasta, Mes)

            dgFacturas.DataSource = dsFacturas.Tables("Tablas").DefaultView

            Tabla = dsFacturas.Tables("Tablas")

            r.FormatGenerico(dgFacturas, Tabla)
        End If
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
End Class
