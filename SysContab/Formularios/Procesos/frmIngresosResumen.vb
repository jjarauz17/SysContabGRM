Public Class frmIngresosResumen
    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As frmIngresosResumen = Nothing

    Public Shared Function Instance() As frmIngresosResumen
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmIngresosResumen()
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents etTotalEfectivoContado As System.Windows.Forms.Label
    Friend WithEvents etTotalTarjetasContado As System.Windows.Forms.Label
    Friend WithEvents etTotalChequesContado As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents etTotalEfectivoCredito As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents etTotalNotasDebitoCredito As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents etTotalTarjetasCredito As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents etTotalChequesCredito As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents etTotalEfectivoAbonos As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents etTotalNotasDebitoAbonos As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents etTotalTarjetasAbonos As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents etTotalChequesAbonos As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents etTotalEfectivo As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents etTotalNotasDebito As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents etTotalTarjetas As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents etTotalCheques As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents etTotalNotasDebitoContado As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etTotal As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.etTotalEfectivoContado = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.etTotalNotasDebitoContado = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.etTotalTarjetasContado = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.etTotalChequesContado = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.etTotalEfectivoCredito = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.etTotalNotasDebitoCredito = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.etTotalTarjetasCredito = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.etTotalChequesCredito = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.etTotalEfectivoAbonos = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.etTotalNotasDebitoAbonos = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.etTotalTarjetasAbonos = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.etTotalChequesAbonos = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.etTotalEfectivo = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.etTotalNotasDebito = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.etTotalTarjetas = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.etTotalCheques = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.etTotal = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.etTotalEfectivoContado)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.etTotalNotasDebitoContado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.etTotalTarjetasContado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.etTotalChequesContado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(16, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 190)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FACTURACION CONTADO"
        '
        'etTotalEfectivoContado
        '
        Me.etTotalEfectivoContado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalEfectivoContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalEfectivoContado.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalEfectivoContado.Location = New System.Drawing.Point(128, 103)
        Me.etTotalEfectivoContado.Name = "etTotalEfectivoContado"
        Me.etTotalEfectivoContado.Size = New System.Drawing.Size(200, 26)
        Me.etTotalEfectivoContado.TabIndex = 180
        Me.etTotalEfectivoContado.Text = "0.00"
        Me.etTotalEfectivoContado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(16, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 26)
        Me.Label8.TabIndex = 179
        Me.Label8.Text = "Tarjetas:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotalNotasDebitoContado
        '
        Me.etTotalNotasDebitoContado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalNotasDebitoContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalNotasDebitoContado.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalNotasDebitoContado.Location = New System.Drawing.Point(128, 138)
        Me.etTotalNotasDebitoContado.Name = "etTotalNotasDebitoContado"
        Me.etTotalNotasDebitoContado.Size = New System.Drawing.Size(200, 26)
        Me.etTotalNotasDebitoContado.TabIndex = 178
        Me.etTotalNotasDebitoContado.Text = "0.00"
        Me.etTotalNotasDebitoContado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 26)
        Me.Label7.TabIndex = 177
        Me.Label7.Text = "Notas Debito:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotalTarjetasContado
        '
        Me.etTotalTarjetasContado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalTarjetasContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalTarjetasContado.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalTarjetasContado.Location = New System.Drawing.Point(128, 69)
        Me.etTotalTarjetasContado.Name = "etTotalTarjetasContado"
        Me.etTotalTarjetasContado.Size = New System.Drawing.Size(200, 26)
        Me.etTotalTarjetasContado.TabIndex = 176
        Me.etTotalTarjetasContado.Text = "0.00"
        Me.etTotalTarjetasContado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 26)
        Me.Label4.TabIndex = 175
        Me.Label4.Text = "Efectivo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotalChequesContado
        '
        Me.etTotalChequesContado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalChequesContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalChequesContado.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalChequesContado.Location = New System.Drawing.Point(128, 34)
        Me.etTotalChequesContado.Name = "etTotalChequesContado"
        Me.etTotalChequesContado.Size = New System.Drawing.Size(200, 26)
        Me.etTotalChequesContado.TabIndex = 174
        Me.etTotalChequesContado.Text = "0.00"
        Me.etTotalChequesContado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(16, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 26)
        Me.Label6.TabIndex = 173
        Me.Label6.Text = "Cheques:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.etTotalEfectivoCredito)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.etTotalNotasDebitoCredito)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.etTotalTarjetasCredito)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.etTotalChequesCredito)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(16, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 189)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FACTURACION CREDITO - ADELANTOS"
        '
        'etTotalEfectivoCredito
        '
        Me.etTotalEfectivoCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalEfectivoCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalEfectivoCredito.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalEfectivoCredito.Location = New System.Drawing.Point(128, 103)
        Me.etTotalEfectivoCredito.Name = "etTotalEfectivoCredito"
        Me.etTotalEfectivoCredito.Size = New System.Drawing.Size(200, 26)
        Me.etTotalEfectivoCredito.TabIndex = 180
        Me.etTotalEfectivoCredito.Text = "0.00"
        Me.etTotalEfectivoCredito.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 26)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "Tarjetas:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotalNotasDebitoCredito
        '
        Me.etTotalNotasDebitoCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalNotasDebitoCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalNotasDebitoCredito.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalNotasDebitoCredito.Location = New System.Drawing.Point(128, 138)
        Me.etTotalNotasDebitoCredito.Name = "etTotalNotasDebitoCredito"
        Me.etTotalNotasDebitoCredito.Size = New System.Drawing.Size(200, 26)
        Me.etTotalNotasDebitoCredito.TabIndex = 178
        Me.etTotalNotasDebitoCredito.Text = "0.00"
        Me.etTotalNotasDebitoCredito.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(16, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 26)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "Notas Debito:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotalTarjetasCredito
        '
        Me.etTotalTarjetasCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalTarjetasCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalTarjetasCredito.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalTarjetasCredito.Location = New System.Drawing.Point(128, 69)
        Me.etTotalTarjetasCredito.Name = "etTotalTarjetasCredito"
        Me.etTotalTarjetasCredito.Size = New System.Drawing.Size(200, 26)
        Me.etTotalTarjetasCredito.TabIndex = 176
        Me.etTotalTarjetasCredito.Text = "0.00"
        Me.etTotalTarjetasCredito.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(16, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 26)
        Me.Label10.TabIndex = 175
        Me.Label10.Text = "Efectivo:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotalChequesCredito
        '
        Me.etTotalChequesCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalChequesCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalChequesCredito.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalChequesCredito.Location = New System.Drawing.Point(128, 34)
        Me.etTotalChequesCredito.Name = "etTotalChequesCredito"
        Me.etTotalChequesCredito.Size = New System.Drawing.Size(200, 26)
        Me.etTotalChequesCredito.TabIndex = 174
        Me.etTotalChequesCredito.Text = "0.00"
        Me.etTotalChequesCredito.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(16, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 26)
        Me.Label12.TabIndex = 173
        Me.Label12.Text = "Cheques:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.etTotalEfectivoAbonos)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.etTotalNotasDebitoAbonos)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.etTotalTarjetasAbonos)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.etTotalChequesAbonos)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(408, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 190)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ABONOS A FACTURAS"
        '
        'etTotalEfectivoAbonos
        '
        Me.etTotalEfectivoAbonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalEfectivoAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalEfectivoAbonos.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalEfectivoAbonos.Location = New System.Drawing.Point(128, 103)
        Me.etTotalEfectivoAbonos.Name = "etTotalEfectivoAbonos"
        Me.etTotalEfectivoAbonos.Size = New System.Drawing.Size(200, 26)
        Me.etTotalEfectivoAbonos.TabIndex = 180
        Me.etTotalEfectivoAbonos.Text = "0.00"
        Me.etTotalEfectivoAbonos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 26)
        Me.Label3.TabIndex = 179
        Me.Label3.Text = "Tarjetas:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotalNotasDebitoAbonos
        '
        Me.etTotalNotasDebitoAbonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalNotasDebitoAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalNotasDebitoAbonos.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalNotasDebitoAbonos.Location = New System.Drawing.Point(128, 138)
        Me.etTotalNotasDebitoAbonos.Name = "etTotalNotasDebitoAbonos"
        Me.etTotalNotasDebitoAbonos.Size = New System.Drawing.Size(200, 26)
        Me.etTotalNotasDebitoAbonos.TabIndex = 178
        Me.etTotalNotasDebitoAbonos.Text = "0.00"
        Me.etTotalNotasDebitoAbonos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(16, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 26)
        Me.Label11.TabIndex = 177
        Me.Label11.Text = "Notas Debito:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotalTarjetasAbonos
        '
        Me.etTotalTarjetasAbonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalTarjetasAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalTarjetasAbonos.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalTarjetasAbonos.Location = New System.Drawing.Point(128, 69)
        Me.etTotalTarjetasAbonos.Name = "etTotalTarjetasAbonos"
        Me.etTotalTarjetasAbonos.Size = New System.Drawing.Size(200, 26)
        Me.etTotalTarjetasAbonos.TabIndex = 176
        Me.etTotalTarjetasAbonos.Text = "0.00"
        Me.etTotalTarjetasAbonos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(16, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 26)
        Me.Label14.TabIndex = 175
        Me.Label14.Text = "Efectivo:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotalChequesAbonos
        '
        Me.etTotalChequesAbonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalChequesAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalChequesAbonos.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalChequesAbonos.Location = New System.Drawing.Point(128, 34)
        Me.etTotalChequesAbonos.Name = "etTotalChequesAbonos"
        Me.etTotalChequesAbonos.Size = New System.Drawing.Size(200, 26)
        Me.etTotalChequesAbonos.TabIndex = 174
        Me.etTotalChequesAbonos.Text = "0.00"
        Me.etTotalChequesAbonos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(16, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 26)
        Me.Label16.TabIndex = 173
        Me.Label16.Text = "Cheques:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.etTotalEfectivo)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.etTotalNotasDebito)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.etTotalTarjetas)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.etTotalCheques)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(408, 225)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(352, 189)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "RESUMEN"
        '
        'etTotalEfectivo
        '
        Me.etTotalEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalEfectivo.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalEfectivo.Location = New System.Drawing.Point(128, 103)
        Me.etTotalEfectivo.Name = "etTotalEfectivo"
        Me.etTotalEfectivo.Size = New System.Drawing.Size(200, 26)
        Me.etTotalEfectivo.TabIndex = 180
        Me.etTotalEfectivo.Text = "0.00"
        Me.etTotalEfectivo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(16, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 26)
        Me.Label9.TabIndex = 179
        Me.Label9.Text = "Tarjetas:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotalNotasDebito
        '
        Me.etTotalNotasDebito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalNotasDebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalNotasDebito.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalNotasDebito.Location = New System.Drawing.Point(128, 138)
        Me.etTotalNotasDebito.Name = "etTotalNotasDebito"
        Me.etTotalNotasDebito.Size = New System.Drawing.Size(200, 26)
        Me.etTotalNotasDebito.TabIndex = 178
        Me.etTotalNotasDebito.Text = "0.00"
        Me.etTotalNotasDebito.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(16, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 26)
        Me.Label15.TabIndex = 177
        Me.Label15.Text = "Notas Debito:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotalTarjetas
        '
        Me.etTotalTarjetas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalTarjetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalTarjetas.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalTarjetas.Location = New System.Drawing.Point(128, 69)
        Me.etTotalTarjetas.Name = "etTotalTarjetas"
        Me.etTotalTarjetas.Size = New System.Drawing.Size(200, 26)
        Me.etTotalTarjetas.TabIndex = 176
        Me.etTotalTarjetas.Text = "0.00"
        Me.etTotalTarjetas.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(16, 103)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 26)
        Me.Label18.TabIndex = 175
        Me.Label18.Text = "Efectivo:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotalCheques
        '
        Me.etTotalCheques.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotalCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalCheques.ForeColor = System.Drawing.Color.Maroon
        Me.etTotalCheques.Location = New System.Drawing.Point(128, 34)
        Me.etTotalCheques.Name = "etTotalCheques"
        Me.etTotalCheques.Size = New System.Drawing.Size(200, 26)
        Me.etTotalCheques.TabIndex = 174
        Me.etTotalCheques.Text = "0.00"
        Me.etTotalCheques.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(16, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 26)
        Me.Label20.TabIndex = 173
        Me.Label20.Text = "Cheques:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(720, 25)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "INGRESOS A CAJA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmdAyuda)
        Me.GroupBox5.Controls.Add(Me.cmdCancelar)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 457)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(744, 60)
        Me.GroupBox5.TabIndex = 175
        Me.GroupBox5.TabStop = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAyuda.Appearance.Options.UseFont = True
        Me.cmdAyuda.Location = New System.Drawing.Point(16, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 26
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Location = New System.Drawing.Point(104, 17)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 35)
        Me.cmdCancelar.TabIndex = 25
        Me.cmdCancelar.Text = "&Salir"
        '
        'etTotal
        '
        Me.etTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotal.ForeColor = System.Drawing.Color.Maroon
        Me.etTotal.Location = New System.Drawing.Point(544, 421)
        Me.etTotal.Name = "etTotal"
        Me.etTotal.Size = New System.Drawing.Size(216, 34)
        Me.etTotal.TabIndex = 180
        Me.etTotal.Text = "0.00"
        Me.etTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(408, 421)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 34)
        Me.Label17.TabIndex = 179
        Me.Label17.Text = "Total Ingresos:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmIngresosResumen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(866, 526)
        Me.Controls.Add(Me.etTotal)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmIngresosResumen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas()

    Private Sub frmIngresosResumen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r.FormularioColor(Me)
        Me.Text = "Ingresos a Caja"
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

End Class
