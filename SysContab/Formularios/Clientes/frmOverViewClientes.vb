Public Class frmOverViewClientes
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmOverViewClientes = Nothing

    Public Shared Function Instance() As frmOverViewClientes
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmOverViewClientes()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Private Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel8 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel9 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel10 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel11 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel13 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel14 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel16 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel18 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel20 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel22 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel24 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel26 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel27 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel28 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel29 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel30 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel32 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel34 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel35 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel37 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel38 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel40 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel43 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel45 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel47 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel49 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel50 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel51 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel53 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel55 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel57 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel59 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel60 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel61 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel62 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel63 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel65 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel67 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbSalir As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOverViewClientes))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel18 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel16 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel14 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel13 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel11 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel10 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel38 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel40 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel35 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel37 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel32 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel34 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel20 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel22 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel24 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel26 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel27 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel28 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel29 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel30 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel43 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel45 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel47 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel49 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel50 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel51 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel65 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel67 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel53 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel55 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel57 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel59 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel60 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel61 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel62 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel63 = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbSalir = New System.Windows.Forms.PictureBox()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(456, 216)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel18
        '
        Me.LinkLabel18.BackColor = System.Drawing.Color.White
        Me.LinkLabel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel18.LinkColor = System.Drawing.Color.White
        Me.LinkLabel18.Location = New System.Drawing.Point(210, 426)
        Me.LinkLabel18.Name = "LinkLabel18"
        Me.LinkLabel18.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel18.TabIndex = 18
        Me.LinkLabel18.TabStop = True
        Me.LinkLabel18.Text = "-"
        Me.LinkLabel18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel16
        '
        Me.LinkLabel16.BackColor = System.Drawing.Color.White
        Me.LinkLabel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel16.LinkColor = System.Drawing.Color.White
        Me.LinkLabel16.Location = New System.Drawing.Point(210, 402)
        Me.LinkLabel16.Name = "LinkLabel16"
        Me.LinkLabel16.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel16.TabIndex = 16
        Me.LinkLabel16.TabStop = True
        Me.LinkLabel16.Text = "-"
        Me.LinkLabel16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel14
        '
        Me.LinkLabel14.BackColor = System.Drawing.Color.White
        Me.LinkLabel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel14.LinkColor = System.Drawing.Color.White
        Me.LinkLabel14.Location = New System.Drawing.Point(210, 378)
        Me.LinkLabel14.Name = "LinkLabel14"
        Me.LinkLabel14.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel14.TabIndex = 14
        Me.LinkLabel14.TabStop = True
        Me.LinkLabel14.Text = "-"
        Me.LinkLabel14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel13
        '
        Me.LinkLabel13.BackColor = System.Drawing.Color.White
        Me.LinkLabel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel13.LinkColor = System.Drawing.Color.White
        Me.LinkLabel13.Location = New System.Drawing.Point(210, 354)
        Me.LinkLabel13.Name = "LinkLabel13"
        Me.LinkLabel13.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel13.TabIndex = 12
        Me.LinkLabel13.TabStop = True
        Me.LinkLabel13.Text = "-"
        Me.LinkLabel13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel11
        '
        Me.LinkLabel11.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel11.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel11.Image = CType(resources.GetObject("LinkLabel11.Image"), System.Drawing.Bitmap)
        Me.LinkLabel11.Location = New System.Drawing.Point(24, 426)
        Me.LinkLabel11.Name = "LinkLabel11"
        Me.LinkLabel11.Size = New System.Drawing.Size(136, 16)
        Me.LinkLabel11.TabIndex = 11
        Me.LinkLabel11.TabStop = True
        Me.LinkLabel11.Text = "Efectua una Devoluci�n"
        '
        'LinkLabel10
        '
        Me.LinkLabel10.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel10.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel10.Image = CType(resources.GetObject("LinkLabel10.Image"), System.Drawing.Bitmap)
        Me.LinkLabel10.Location = New System.Drawing.Point(24, 402)
        Me.LinkLabel10.Name = "LinkLabel10"
        Me.LinkLabel10.Size = New System.Drawing.Size(136, 16)
        Me.LinkLabel10.TabIndex = 10
        Me.LinkLabel10.TabStop = True
        Me.LinkLabel10.Text = "Factura"
        '
        'LinkLabel9
        '
        Me.LinkLabel9.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel9.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel9.Image = CType(resources.GetObject("LinkLabel9.Image"), System.Drawing.Bitmap)
        Me.LinkLabel9.Location = New System.Drawing.Point(24, 378)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(136, 16)
        Me.LinkLabel9.TabIndex = 9
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "Cotiza"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel8.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel8.Image = CType(resources.GetObject("LinkLabel8.Image"), System.Drawing.Bitmap)
        Me.LinkLabel8.Location = New System.Drawing.Point(24, 354)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(136, 14)
        Me.LinkLabel8.TabIndex = 8
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Hace Orden de Compra"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Bitmap)
        Me.Label2.Location = New System.Drawing.Point(208, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Inf."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel38
        '
        Me.LinkLabel38.BackColor = System.Drawing.Color.White
        Me.LinkLabel38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel38.LinkColor = System.Drawing.Color.White
        Me.LinkLabel38.Location = New System.Drawing.Point(750, 450)
        Me.LinkLabel38.Name = "LinkLabel38"
        Me.LinkLabel38.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel38.TabIndex = 27
        Me.LinkLabel38.TabStop = True
        Me.LinkLabel38.Text = "-"
        Me.LinkLabel38.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel40
        '
        Me.LinkLabel40.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel40.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel40.Image = CType(resources.GetObject("LinkLabel40.Image"), System.Drawing.Bitmap)
        Me.LinkLabel40.Location = New System.Drawing.Point(568, 450)
        Me.LinkLabel40.Name = "LinkLabel40"
        Me.LinkLabel40.Size = New System.Drawing.Size(152, 16)
        Me.LinkLabel40.TabIndex = 25
        Me.LinkLabel40.TabStop = True
        Me.LinkLabel40.Text = "Cotizaciones pendientes"
        '
        'LinkLabel35
        '
        Me.LinkLabel35.BackColor = System.Drawing.Color.White
        Me.LinkLabel35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel35.Location = New System.Drawing.Point(750, 426)
        Me.LinkLabel35.Name = "LinkLabel35"
        Me.LinkLabel35.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel35.TabIndex = 24
        Me.LinkLabel35.TabStop = True
        Me.LinkLabel35.Text = "-"
        Me.LinkLabel35.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel37
        '
        Me.LinkLabel37.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel37.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel37.Image = CType(resources.GetObject("LinkLabel37.Image"), System.Drawing.Bitmap)
        Me.LinkLabel37.Location = New System.Drawing.Point(568, 426)
        Me.LinkLabel37.Name = "LinkLabel37"
        Me.LinkLabel37.Size = New System.Drawing.Size(160, 14)
        Me.LinkLabel37.TabIndex = 22
        Me.LinkLabel37.TabStop = True
        Me.LinkLabel37.Text = "Arqueo de Caja"
        '
        'LinkLabel32
        '
        Me.LinkLabel32.BackColor = System.Drawing.Color.White
        Me.LinkLabel32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel32.LinkColor = System.Drawing.Color.White
        Me.LinkLabel32.Location = New System.Drawing.Point(750, 402)
        Me.LinkLabel32.Name = "LinkLabel32"
        Me.LinkLabel32.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel32.TabIndex = 21
        Me.LinkLabel32.TabStop = True
        Me.LinkLabel32.Text = "-"
        Me.LinkLabel32.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel34
        '
        Me.LinkLabel34.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel34.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel34.Image = CType(resources.GetObject("LinkLabel34.Image"), System.Drawing.Bitmap)
        Me.LinkLabel34.Location = New System.Drawing.Point(568, 402)
        Me.LinkLabel34.Name = "LinkLabel34"
        Me.LinkLabel34.Size = New System.Drawing.Size(136, 14)
        Me.LinkLabel34.TabIndex = 19
        Me.LinkLabel34.TabStop = True
        Me.LinkLabel34.Text = "Facturas de Cr�dito"
        '
        'LinkLabel20
        '
        Me.LinkLabel20.BackColor = System.Drawing.Color.White
        Me.LinkLabel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel20.LinkColor = System.Drawing.Color.White
        Me.LinkLabel20.Location = New System.Drawing.Point(750, 378)
        Me.LinkLabel20.Name = "LinkLabel20"
        Me.LinkLabel20.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel20.TabIndex = 18
        Me.LinkLabel20.TabStop = True
        Me.LinkLabel20.Text = "-"
        Me.LinkLabel20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel22
        '
        Me.LinkLabel22.BackColor = System.Drawing.Color.White
        Me.LinkLabel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel22.LinkColor = System.Drawing.Color.White
        Me.LinkLabel22.Location = New System.Drawing.Point(750, 354)
        Me.LinkLabel22.Name = "LinkLabel22"
        Me.LinkLabel22.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel22.TabIndex = 16
        Me.LinkLabel22.TabStop = True
        Me.LinkLabel22.Text = "-"
        Me.LinkLabel22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel24
        '
        Me.LinkLabel24.BackColor = System.Drawing.Color.White
        Me.LinkLabel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel24.LinkColor = System.Drawing.Color.White
        Me.LinkLabel24.Location = New System.Drawing.Point(750, 330)
        Me.LinkLabel24.Name = "LinkLabel24"
        Me.LinkLabel24.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel24.TabIndex = 14
        Me.LinkLabel24.TabStop = True
        Me.LinkLabel24.Text = "-"
        Me.LinkLabel24.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel26
        '
        Me.LinkLabel26.BackColor = System.Drawing.Color.White
        Me.LinkLabel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel26.LinkColor = System.Drawing.Color.White
        Me.LinkLabel26.Location = New System.Drawing.Point(750, 306)
        Me.LinkLabel26.Name = "LinkLabel26"
        Me.LinkLabel26.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel26.TabIndex = 12
        Me.LinkLabel26.TabStop = True
        Me.LinkLabel26.Text = "-"
        Me.LinkLabel26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel27
        '
        Me.LinkLabel27.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel27.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel27.Image = CType(resources.GetObject("LinkLabel27.Image"), System.Drawing.Bitmap)
        Me.LinkLabel27.Location = New System.Drawing.Point(568, 378)
        Me.LinkLabel27.Name = "LinkLabel27"
        Me.LinkLabel27.Size = New System.Drawing.Size(136, 14)
        Me.LinkLabel27.TabIndex = 11
        Me.LinkLabel27.TabStop = True
        Me.LinkLabel27.Text = "Facturas de Contado"
        '
        'LinkLabel28
        '
        Me.LinkLabel28.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel28.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel28.Image = CType(resources.GetObject("LinkLabel28.Image"), System.Drawing.Bitmap)
        Me.LinkLabel28.Location = New System.Drawing.Point(568, 354)
        Me.LinkLabel28.Name = "LinkLabel28"
        Me.LinkLabel28.Size = New System.Drawing.Size(136, 14)
        Me.LinkLabel28.TabIndex = 10
        Me.LinkLabel28.TabStop = True
        Me.LinkLabel28.Text = "Facturas Realizadas"
        '
        'LinkLabel29
        '
        Me.LinkLabel29.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel29.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel29.Image = CType(resources.GetObject("LinkLabel29.Image"), System.Drawing.Bitmap)
        Me.LinkLabel29.Location = New System.Drawing.Point(568, 330)
        Me.LinkLabel29.Name = "LinkLabel29"
        Me.LinkLabel29.Size = New System.Drawing.Size(152, 14)
        Me.LinkLabel29.TabIndex = 9
        Me.LinkLabel29.TabStop = True
        Me.LinkLabel29.Text = "Informaci�n de Productos"
        '
        'LinkLabel30
        '
        Me.LinkLabel30.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel30.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel30.Image = CType(resources.GetObject("LinkLabel30.Image"), System.Drawing.Bitmap)
        Me.LinkLabel30.Location = New System.Drawing.Point(568, 306)
        Me.LinkLabel30.Name = "LinkLabel30"
        Me.LinkLabel30.Size = New System.Drawing.Size(136, 14)
        Me.LinkLabel30.TabIndex = 8
        Me.LinkLabel30.TabStop = True
        Me.LinkLabel30.Text = "Datos de Clientes"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Bitmap)
        Me.Label4.Location = New System.Drawing.Point(749, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Inf."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel43
        '
        Me.LinkLabel43.BackColor = System.Drawing.Color.White
        Me.LinkLabel43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel43.LinkColor = System.Drawing.Color.White
        Me.LinkLabel43.Location = New System.Drawing.Point(750, 221)
        Me.LinkLabel43.Name = "LinkLabel43"
        Me.LinkLabel43.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel43.TabIndex = 16
        Me.LinkLabel43.TabStop = True
        Me.LinkLabel43.Text = "-"
        Me.LinkLabel43.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel45
        '
        Me.LinkLabel45.BackColor = System.Drawing.Color.White
        Me.LinkLabel45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel45.LinkColor = System.Drawing.Color.White
        Me.LinkLabel45.Location = New System.Drawing.Point(750, 197)
        Me.LinkLabel45.Name = "LinkLabel45"
        Me.LinkLabel45.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel45.TabIndex = 14
        Me.LinkLabel45.TabStop = True
        Me.LinkLabel45.Text = "-"
        Me.LinkLabel45.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel47
        '
        Me.LinkLabel47.BackColor = System.Drawing.Color.White
        Me.LinkLabel47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel47.LinkColor = System.Drawing.Color.White
        Me.LinkLabel47.Location = New System.Drawing.Point(750, 173)
        Me.LinkLabel47.Name = "LinkLabel47"
        Me.LinkLabel47.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel47.TabIndex = 12
        Me.LinkLabel47.TabStop = True
        Me.LinkLabel47.Text = "-"
        Me.LinkLabel47.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel49
        '
        Me.LinkLabel49.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel49.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel49.Image = CType(resources.GetObject("LinkLabel49.Image"), System.Drawing.Bitmap)
        Me.LinkLabel49.Location = New System.Drawing.Point(568, 221)
        Me.LinkLabel49.Name = "LinkLabel49"
        Me.LinkLabel49.Size = New System.Drawing.Size(136, 19)
        Me.LinkLabel49.TabIndex = 10
        Me.LinkLabel49.TabStop = True
        Me.LinkLabel49.Text = "Cobros Recibidos"
        '
        'LinkLabel50
        '
        Me.LinkLabel50.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel50.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel50.Image = CType(resources.GetObject("LinkLabel50.Image"), System.Drawing.Bitmap)
        Me.LinkLabel50.Location = New System.Drawing.Point(568, 197)
        Me.LinkLabel50.Name = "LinkLabel50"
        Me.LinkLabel50.Size = New System.Drawing.Size(136, 19)
        Me.LinkLabel50.TabIndex = 9
        Me.LinkLabel50.TabStop = True
        Me.LinkLabel50.Text = "Ventas Perdidas"
        '
        'LinkLabel51
        '
        Me.LinkLabel51.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel51.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel51.Image = CType(resources.GetObject("LinkLabel51.Image"), System.Drawing.Bitmap)
        Me.LinkLabel51.Location = New System.Drawing.Point(568, 173)
        Me.LinkLabel51.Name = "LinkLabel51"
        Me.LinkLabel51.Size = New System.Drawing.Size(136, 16)
        Me.LinkLabel51.TabIndex = 8
        Me.LinkLabel51.TabStop = True
        Me.LinkLabel51.Text = "Ventas Realizadas"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Bitmap)
        Me.Label6.Location = New System.Drawing.Point(748, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Inf."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel65
        '
        Me.LinkLabel65.BackColor = System.Drawing.Color.White
        Me.LinkLabel65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel65.LinkColor = System.Drawing.Color.White
        Me.LinkLabel65.Location = New System.Drawing.Point(494, 450)
        Me.LinkLabel65.Name = "LinkLabel65"
        Me.LinkLabel65.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel65.TabIndex = 21
        Me.LinkLabel65.TabStop = True
        Me.LinkLabel65.Text = "-"
        Me.LinkLabel65.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel67
        '
        Me.LinkLabel67.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel67.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel67.Image = CType(resources.GetObject("LinkLabel67.Image"), System.Drawing.Bitmap)
        Me.LinkLabel67.Location = New System.Drawing.Point(302, 450)
        Me.LinkLabel67.Name = "LinkLabel67"
        Me.LinkLabel67.Size = New System.Drawing.Size(160, 16)
        Me.LinkLabel67.TabIndex = 19
        Me.LinkLabel67.TabStop = True
        Me.LinkLabel67.Text = "Como cobrar facturas cr�dito"
        '
        'LinkLabel53
        '
        Me.LinkLabel53.BackColor = System.Drawing.Color.White
        Me.LinkLabel53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel53.LinkColor = System.Drawing.Color.White
        Me.LinkLabel53.Location = New System.Drawing.Point(494, 426)
        Me.LinkLabel53.Name = "LinkLabel53"
        Me.LinkLabel53.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel53.TabIndex = 18
        Me.LinkLabel53.TabStop = True
        Me.LinkLabel53.Text = "-"
        Me.LinkLabel53.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel55
        '
        Me.LinkLabel55.BackColor = System.Drawing.Color.White
        Me.LinkLabel55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel55.LinkColor = System.Drawing.Color.White
        Me.LinkLabel55.Location = New System.Drawing.Point(494, 402)
        Me.LinkLabel55.Name = "LinkLabel55"
        Me.LinkLabel55.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel55.TabIndex = 16
        Me.LinkLabel55.TabStop = True
        Me.LinkLabel55.Text = "-"
        Me.LinkLabel55.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel57
        '
        Me.LinkLabel57.BackColor = System.Drawing.Color.White
        Me.LinkLabel57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel57.LinkColor = System.Drawing.Color.White
        Me.LinkLabel57.Location = New System.Drawing.Point(494, 378)
        Me.LinkLabel57.Name = "LinkLabel57"
        Me.LinkLabel57.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel57.TabIndex = 14
        Me.LinkLabel57.TabStop = True
        Me.LinkLabel57.Text = "-"
        Me.LinkLabel57.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel59
        '
        Me.LinkLabel59.BackColor = System.Drawing.Color.White
        Me.LinkLabel59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel59.LinkColor = System.Drawing.Color.White
        Me.LinkLabel59.Location = New System.Drawing.Point(494, 354)
        Me.LinkLabel59.Name = "LinkLabel59"
        Me.LinkLabel59.Size = New System.Drawing.Size(16, 16)
        Me.LinkLabel59.TabIndex = 12
        Me.LinkLabel59.TabStop = True
        Me.LinkLabel59.Text = "-"
        Me.LinkLabel59.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel60
        '
        Me.LinkLabel60.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel60.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel60.Image = CType(resources.GetObject("LinkLabel60.Image"), System.Drawing.Bitmap)
        Me.LinkLabel60.Location = New System.Drawing.Point(302, 426)
        Me.LinkLabel60.Name = "LinkLabel60"
        Me.LinkLabel60.Size = New System.Drawing.Size(160, 14)
        Me.LinkLabel60.TabIndex = 11
        Me.LinkLabel60.TabStop = True
        Me.LinkLabel60.Text = "Como cobrar facturas contado"
        '
        'LinkLabel61
        '
        Me.LinkLabel61.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel61.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel61.Image = CType(resources.GetObject("LinkLabel61.Image"), System.Drawing.Bitmap)
        Me.LinkLabel61.Location = New System.Drawing.Point(302, 402)
        Me.LinkLabel61.Name = "LinkLabel61"
        Me.LinkLabel61.Size = New System.Drawing.Size(152, 14)
        Me.LinkLabel61.TabIndex = 10
        Me.LinkLabel61.TabStop = True
        Me.LinkLabel61.Text = "Como seleccionar servicios"
        '
        'LinkLabel62
        '
        Me.LinkLabel62.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel62.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel62.Image = CType(resources.GetObject("LinkLabel62.Image"), System.Drawing.Bitmap)
        Me.LinkLabel62.Location = New System.Drawing.Point(302, 378)
        Me.LinkLabel62.Name = "LinkLabel62"
        Me.LinkLabel62.Size = New System.Drawing.Size(152, 14)
        Me.LinkLabel62.TabIndex = 9
        Me.LinkLabel62.TabStop = True
        Me.LinkLabel62.Text = "Como Seleccionar Productos"
        '
        'LinkLabel63
        '
        Me.LinkLabel63.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel63.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(143, Byte), CType(140, Byte), CType(127, Byte))
        Me.LinkLabel63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel63.Image = CType(resources.GetObject("LinkLabel63.Image"), System.Drawing.Bitmap)
        Me.LinkLabel63.Location = New System.Drawing.Point(302, 354)
        Me.LinkLabel63.Name = "LinkLabel63"
        Me.LinkLabel63.Size = New System.Drawing.Size(152, 14)
        Me.LinkLabel63.TabIndex = 8
        Me.LinkLabel63.TabStop = True
        Me.LinkLabel63.Text = "Como seleccionar un cliente"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Bitmap)
        Me.Label8.Location = New System.Drawing.Point(492, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 14)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Inf."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Bitmap)
        Me.PictureBox3.Location = New System.Drawing.Point(552, 280)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(232, 192)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Bitmap)
        Me.PictureBox4.Location = New System.Drawing.Point(552, 149)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(232, 96)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 30
        Me.PictureBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Bitmap)
        Me.Label10.Location = New System.Drawing.Point(552, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 24)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Reportes"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Bitmap)
        Me.Label11.Location = New System.Drawing.Point(294, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(232, 24)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Preguntas m�s frecuentes"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Bitmap)
        Me.PictureBox6.Location = New System.Drawing.Point(294, 328)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(232, 148)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 33
        Me.PictureBox6.TabStop = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Bitmap)
        Me.Label12.Location = New System.Drawing.Point(8, 304)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(232, 24)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Conocer como se:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Bitmap)
        Me.PictureBox8.Location = New System.Drawing.Point(8, 328)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(232, 148)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 36
        Me.PictureBox8.TabStop = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Bitmap)
        Me.Label13.Location = New System.Drawing.Point(192, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 16)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Proceso de Ventas"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Bitmap)
        Me.PictureBox10.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(528, 32)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 38
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Bitmap)
        Me.PictureBox11.Location = New System.Drawing.Point(8, 40)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(528, 256)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 40
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Location = New System.Drawing.Point(568, -16)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(200, 197)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 41
        Me.PictureBox12.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Bitmap)
        Me.Label1.Location = New System.Drawing.Point(552, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Preguntas m�s frecuentes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbSalir
        '
        Me.pbSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbSalir.Image = CType(resources.GetObject("pbSalir.Image"), System.Drawing.Bitmap)
        Me.pbSalir.Location = New System.Drawing.Point(602, 48)
        Me.pbSalir.Name = "pbSalir"
        Me.pbSalir.Size = New System.Drawing.Size(134, 30)
        Me.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbSalir.TabIndex = 130
        Me.pbSalir.TabStop = False
        '
        'frmOverViewClientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 533)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.pbSalir, Me.Label1, Me.PictureBox1, Me.PictureBox11, Me.Label13, Me.PictureBox10, Me.LinkLabel18, Me.LinkLabel16, Me.LinkLabel14, Me.LinkLabel13, Me.LinkLabel11, Me.LinkLabel10, Me.LinkLabel9, Me.LinkLabel8, Me.Label2, Me.Label12, Me.PictureBox8, Me.LinkLabel65, Me.LinkLabel67, Me.LinkLabel53, Me.LinkLabel55, Me.LinkLabel57, Me.LinkLabel59, Me.LinkLabel60, Me.LinkLabel61, Me.LinkLabel62, Me.LinkLabel63, Me.Label8, Me.Label11, Me.PictureBox6, Me.LinkLabel45, Me.Label6, Me.LinkLabel47, Me.LinkLabel43, Me.LinkLabel50, Me.LinkLabel49, Me.LinkLabel51, Me.Label10, Me.PictureBox4, Me.LinkLabel38, Me.LinkLabel40, Me.LinkLabel35, Me.LinkLabel37, Me.LinkLabel32, Me.LinkLabel34, Me.LinkLabel20, Me.LinkLabel22, Me.LinkLabel24, Me.LinkLabel26, Me.LinkLabel27, Me.LinkLabel28, Me.LinkLabel29, Me.LinkLabel30, Me.Label4, Me.PictureBox3, Me.PictureBox12})
        Me.Name = "frmOverViewClientes"
        Me.Text = "Descripci�n General de Procesos de Ventas"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Pv As New VB.SysContab.PuntosVentasDB
    Dim dsPuntoVenta As DataSet
    Dim Cajas As New VB.SysContab.CajasDB
    'Private Sub letCotizaciones_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles letCotizaciones.LinkClicked

    '    Dim FormCotizacion As DataGridTextBoxCombo.frmCotizaciones = FormCotizacion.Instance

    '    FormCotizacion.MdiParent = Me.MdiParent
    '    FormCotizacion.Show()
    '    FormCotizacion.WindowState = FormWindowState.Maximized
    'End Sub

    'Private Sub letFactura_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles letFactura.LinkClicked
    '    Dim dsCajas As DataSet
    '    Dim Cajas As New VB.SysContab.CajasDB()
    '    dsCajas = Cajas.PcNombre(Environment.MachineName.ToString)

    '    If dsCajas.Tables("Cajas").Rows.Count = 0 Then
    '        MsgBox("La Computadora " & Environment.MachineName.ToString & " no est� configurada como Caja", MsgBoxStyle.Information)
    '        Exit Sub
    '    End If

    '    Dim FormFacturacion As DataGridTextBoxCombo.frmFacturacionCliente = FormFacturacion.Instance
    '    FormFacturacion.etCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

    '    FormFacturacion.MdiParent = Me.MdiParent
    '    FormFacturacion.Show()
    '    FormFacturacion.WindowState = FormWindowState.Maximized

    '    Inicio = False
    'End Sub

    'Private Sub letDepositos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles letDepositos.LinkClicked
    '    Dim f As frmDepositos = f.Instance
    '    f.MdiParent = Me.MdiParent
    '    f.Show()
    '    f.WindowState = FormWindowState.Maximized
    'End Sub

    'Private Sub letDevoluciones_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles letDevoluciones.LinkClicked
    '    Dim f As frmDevolucionesFacturas = f.Instance
    '    f.etInicio.Text = "1"

    '    f.MdiParent = Me.MdiParent
    '    f.Show()
    '    f.WindowState = FormWindowState.Maximized

    '    f.etInicio.Text = "0"
    'End Sub

    Private Sub LinkLabel15_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim FormCotizacion As FrmCotizacionNew = FormCotizacion.Instance

        FormCotizacion.MdiParent = Me.MdiParent
        FormCotizacion.Show()
        FormCotizacion.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmOverViewClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Rut As New VB.SysContab.Rutinas
        Rut.FormularioColor(Me)
    End Sub
    Private Sub LinkLabel13_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesOrdenes.chm")
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        dsPuntoVenta = PV.PcNombre(Environment.MachineName.ToString)

        If dsPuntoVenta.Tables("Puntos_Venta").Rows.Count = 0 Then
            MsgBox("La Computadora " & Environment.MachineName.ToString & " no est� configurada como Punto de Venta", MsgBoxStyle.Information)
            Exit Sub
        End If

        dsPuntoVenta = PV.PcNombre(Environment.MachineName.ToString)

        PvCodigo = dsPuntoVenta.Tables("Puntos_Venta").Rows(0).Item("Pv_Codigo").ToString
        PvNombre = dsPuntoVenta.Tables("Puntos_Venta").Rows(0).Item("Pv_Nombre").ToString

        'FormPrincipal.IsMdiContainer = True

        NuevaFactura = "SI"
        Opened = "SI"

        Dim f As frmListaOrdenes = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Dim FormCotizacion As FrmCotizacionNew = FormCotizacion.Instance

        FormCotizacion.MdiParent = Me.MdiParent
        FormCotizacion.Show()
        FormCotizacion.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub LinkLabel14_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesCotizaciones.chm")
    End Sub

    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        Dim dsCajas As DataSet
        Dim Cajas As New VB.SysContab.CajasDB
        dsCajas = Cajas.PcNombre(Environment.MachineName.ToString)

        If dsCajas.Tables("Cajas").Rows.Count = 0 Then
            MsgBox("La Computadora " & Environment.MachineName.ToString & " no est� configurada como Caja", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Dim FormFacturacion As DataGridTextBoxCombo.frmFacturacionCliente = FormFacturacion.Instance
        'FormFacturacion.etCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        Dim FormFacturacion As FrmFacturacionClienteNew = FormFacturacion.Instance
        FormFacturacion.txtCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        FormFacturacion.MdiParent = Me.MdiParent
        FormFacturacion.Show()
        FormFacturacion.WindowState = FormWindowState.Maximized

        Inicio = False
    End Sub
    Private Sub LinkLabel16_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesFacturas.chm")
    End Sub

    Private Sub LinkLabel11_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        Opened = "SI"

        Dim f As frmDevolucionesFacturas = f.Instance
        f.etInicio.Text = "1"
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"

    End Sub
    Private Sub LinkLabel18_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel18.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesDevoluciones.chm")
    End Sub

    Private Sub LinkLabel63_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel63.LinkClicked
        NuevaFactura = "SI"
        FacturarCotizacion = False

        Opened = "SI"

        Inicio = True

        Dim dsCajas As DataSet
        dsCajas = Cajas.PcNombre(Environment.MachineName.ToString)

        If dsCajas.Tables("Cajas").Rows.Count = 0 Then
            MsgBox("La Computadora " & Environment.MachineName.ToString & " no est� configurada como Caja", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Dim FormFacturacion As DataGridTextBoxCombo.frmFacturacionCliente = FormFacturacion.Instance
        'FormFacturacion.etCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        Dim FormFacturacion As FrmFacturacionClienteNew = FormFacturacion.Instance
        FormFacturacion.txtCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        FormFacturacion.MdiParent = Me.MdiParent
        FormFacturacion.Show()
        FormFacturacion.WindowState = FormWindowState.Maximized

        Inicio = False
    End Sub
    Private Sub LinkLabel59_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel59.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesFacturacion.chm", HelpNavigator.KeywordIndex, "2.1")

    End Sub

    Private Sub LinkLabel62_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel62.LinkClicked
        NuevaFactura = "SI"
        FacturarCotizacion = False

        Opened = "SI"

        Inicio = True

        Dim dsCajas As DataSet
        dsCajas = Cajas.PcNombre(Environment.MachineName.ToString)

        If dsCajas.Tables("Cajas").Rows.Count = 0 Then
            MsgBox("La Computadora " & Environment.MachineName.ToString & " no est� configurada como Caja", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Dim FormFacturacion As DataGridTextBoxCombo.frmFacturacionCliente = FormFacturacion.Instance
        'FormFacturacion.etCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        Dim FormFacturacion As FrmFacturacionClienteNew = FormFacturacion.Instance
        FormFacturacion.txtCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        FormFacturacion.MdiParent = Me.MdiParent
        FormFacturacion.Show()
        FormFacturacion.WindowState = FormWindowState.Maximized

        Inicio = False
    End Sub
    Private Sub LinkLabel57_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel57.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesFacturacion.chm", HelpNavigator.KeywordIndex, "ProdServ")
    End Sub

    Private Sub LinkLabel61_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel61.LinkClicked
        NuevaFactura = "SI"
        FacturarCotizacion = False

        Opened = "SI"

        Inicio = True

        Dim dsCajas As DataSet
        dsCajas = Cajas.PcNombre(Environment.MachineName.ToString)

        If dsCajas.Tables("Cajas").Rows.Count = 0 Then
            MsgBox("La Computadora " & Environment.MachineName.ToString & " no est� configurada como Caja", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Dim FormFacturacion As DataGridTextBoxCombo.frmFacturacionCliente = FormFacturacion.Instance
        'FormFacturacion.etCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        Dim FormFacturacion As FrmFacturacionClienteNew = FormFacturacion.Instance
        FormFacturacion.txtCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        FormFacturacion.MdiParent = Me.MdiParent
        FormFacturacion.Show()
        FormFacturacion.WindowState = FormWindowState.Maximized

        Inicio = False
    End Sub
    Private Sub LinkLabel55_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel55.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesFacturacion.chm", HelpNavigator.KeywordIndex, "ProdServ")
    End Sub

    Private Sub LinkLabel60_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel60.LinkClicked
        NuevaFactura = "SI"
        FacturarCotizacion = False

        Opened = "SI"

        Inicio = True

        Dim dsCajas As DataSet
        dsCajas = Cajas.PcNombre(Environment.MachineName.ToString)

        If dsCajas.Tables("Cajas").Rows.Count = 0 Then
            MsgBox("La Computadora " & Environment.MachineName.ToString & " no est� configurada como Caja", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Dim FormFacturacion As DataGridTextBoxCombo.frmFacturacionCliente = FormFacturacion.Instance
        'FormFacturacion.etCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        Dim FormFacturacion As FrmFacturacionClienteNew = FormFacturacion.Instance
        FormFacturacion.txtCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        FormFacturacion.MdiParent = Me.MdiParent
        FormFacturacion.Show()
        FormFacturacion.WindowState = FormWindowState.Maximized

        Inicio = False
    End Sub
    Private Sub LinkLabel53_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel53.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesFacturacion.chm")
    End Sub

    Private Sub LinkLabel67_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel67.LinkClicked
        Opened = "SI"
        NuevaFactura = "NO"
        FacturarCotizacion = False

        Dim f As FrmCobrosNew = f.Instance
        Dim dsCajas As DataSet
        dsCajas = Cajas.PcNombre(Environment.MachineName.ToString)

        If dsCajas.Tables("Cajas").Rows.Count = 0 Then
            MsgBox("La Computadora " & Environment.MachineName.ToString & " no est� configurada como Caja", MsgBoxStyle.Information)
            Exit Sub
        End If

        'f.etCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub LinkLabel65_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel65.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesFacturas.chm", HelpNavigator.KeywordIndex, "2.1")
    End Sub

    Private Sub LinkLabel51_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel51.LinkClicked
        Dim f As frmReportesFactura = f.Instance
        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub
    Private Sub LinkLabel47_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel47.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesFacturas.chm", HelpNavigator.KeywordIndex, "Reportes")
    End Sub

    Private Sub LinkLabel50_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel50.LinkClicked
        '   Dim fReportes As New frmReportes
        '   Dim rFacturas As New rptReporteVentasPerdidas
        '   Dim Clientes As New VB.SysContab.ClientesDB
        '   rFacturas.SetDataSource(Clientes.FacturasReporte(cbClientes.Text, Tipo, Mes, Fecha1, Fecha2, cbVendedores.Text, cbProveedores.Text, tbCodigo.Text, cbProductos.Text, cbLineas.Text, cbGrupos.Text, cbSubGrupos.Text, FacRango1, FacRango2, TipoFac2, TipoArt, ArtMin, ArtMax, Orden))
        '   fReportes.crvReportes.ReportSource = rFacturas
        '   fReportes.Show()
    End Sub
    Private Sub LinkLabel45_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel45.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesVentasPerdidas.chm", HelpNavigator.KeywordIndex, "2.1")
    End Sub

    Private Sub LinkLabel30_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel30.LinkClicked
        Dim f As frmClientes = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub LinkLabel26_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel26.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesLista.chm")
    End Sub

    Private Sub LinkLabel29_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel29.LinkClicked
        Opened = "SI"

        Dim f As frmArticulos = f.Instance
        f.MdiParent = Me.MdiParent
        TituloInv = "Mantenimiento de Art�culos"
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub LinkLabel24_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel24.LinkClicked
        Help.ShowHelp(Me, "ayuda/RegISProductos.chm")
    End Sub

    Private Sub LinkLabel28_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel28.LinkClicked
        Opened = "SI"
        NuevaFactura = "NO"
        FacturarCotizacion = False

        Dim f As frmListaFacturaClientes = f.Instance
        f.etInicio.Text = "1"

        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
        f.etInicio.Text = "0"
    End Sub
    Private Sub LinkLabel22_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel22.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesFacturas.chm")
    End Sub

    Private Sub LinkLabel27_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel27.LinkClicked
        NuevaFactura = "SI"
        FacturarCotizacion = False

        Opened = "SI"
        Inicio = True

        Dim dsCajas As DataSet
        dsCajas = Cajas.PcNombre(Environment.MachineName.ToString)

        If dsCajas.Tables("Cajas").Rows.Count = 0 Then
            MsgBox("La Computadora " & Environment.MachineName.ToString & " no est� configurada como Caja", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Dim FormFacturacion As DataGridTextBoxCombo.frmFacturacionCliente = FormFacturacion.Instance
        'FormFacturacion.etCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        Dim FormFacturacion As FrmFacturacionClienteNew = FormFacturacion.Instance
        FormFacturacion.txtCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        FormFacturacion.MdiParent = Me.MdiParent
        FormFacturacion.Show()
        FormFacturacion.WindowState = FormWindowState.Maximized

        Inicio = False
    End Sub
    Private Sub LinkLabel20_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel20.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesFacturacion.chm")
    End Sub

    Private Sub LinkLabel34_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel34.LinkClicked
        NuevaFactura = "SI"
        FacturarCotizacion = False

        Opened = "SI"
        Inicio = True

        Dim dsCajas As DataSet
        dsCajas = Cajas.PcNombre(Environment.MachineName.ToString)

        If dsCajas.Tables("Cajas").Rows.Count = 0 Then
            MsgBox("La Computadora " & Environment.MachineName.ToString & " no est� configurada como Caja", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Dim FormFacturacion As DataGridTextBoxCombo.frmFacturacionCliente = FormFacturacion.Instance
        'FormFacturacion.etCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        Dim FormFacturacion As FrmFacturacionClienteNew = FormFacturacion.Instance
        FormFacturacion.txtCaja.Text = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo").ToString

        FormFacturacion.MdiParent = Me.MdiParent
        FormFacturacion.Show()
        FormFacturacion.WindowState = FormWindowState.Maximized

        Inicio = False
    End Sub
    Private Sub LinkLabel32_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel32.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesFacturacion.chm")
    End Sub
    Private Sub LinkLabel37_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel37.LinkClicked

    End Sub

    Private Sub LinkLabel35_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel35.LinkClicked
        Help.ShowHelp(Me, "ayuda/ProcesosArqueo.chm")
    End Sub

    Private Sub LinkLabel40_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel40.LinkClicked
        Opened = "SI"

        Dim f As frmListaCotizaciones = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub LinkLabel38_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel38.LinkClicked
        Help.ShowHelp(Me, "ayuda/Cotizaciones.chm", HelpNavigator.KeywordIndex, "Cotizaciones")
    End Sub

    Private Sub LinkLabel49_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel49.LinkClicked
        Dim f As frmRecibos = f.Instance
        f.etInicio.Text = "1"
        f.Cliente = ""
        f.Recibo = ""
        f.MdiParent = Me.MdiParent
        f.WindowState = FormWindowState.Maximized
        f.Show()
        f.etInicio.Text = "0"
    End Sub
    Private Sub LinkLabel43_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel43.LinkClicked
        Help.ShowHelp(Me, "ayuda/ClientesCobroVentas.chm", HelpNavigator.KeywordIndex, "Recibos")
    End Sub

    Private Sub pbSalir_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbSalir.MouseEnter
        pbSalir.Image = Image.FromFile(Application.StartupPath & "\Graphics\Logos\Salir2")
    End Sub
    Private Sub pbSalir_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbSalir.MouseLeave
        pbSalir.Image = Image.FromFile(Application.StartupPath & "\Graphics\Logos\Salir1")
    End Sub
    Private Sub pbSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbSalir.Click
        Me.Close()
    End Sub
End Class
