
Public Class frmPlantillasPagoProveedores
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmPlantillasPagoProveedores = Nothing

    Public Shared Function Instance() As frmPlantillasPagoProveedores
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPlantillasPagoProveedores()
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
    Friend WithEvents gbxAccion As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBasura As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCelular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTelefono As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEnergia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgua As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPlantillasPagoProveedores))
        Me.gbxAccion = New System.Windows.Forms.GroupBox
        Me.btnBasura = New DevExpress.XtraEditors.SimpleButton
        Me.btnCable = New DevExpress.XtraEditors.SimpleButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        Me.btnCelular = New DevExpress.XtraEditors.SimpleButton
        Me.btnTelefono = New DevExpress.XtraEditors.SimpleButton
        Me.btnEnergia = New DevExpress.XtraEditors.SimpleButton
        Me.btnAgua = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button13 = New DevExpress.XtraEditors.SimpleButton
        Me.Button12 = New DevExpress.XtraEditors.SimpleButton
        Me.Button11 = New DevExpress.XtraEditors.SimpleButton
        Me.Button10 = New DevExpress.XtraEditors.SimpleButton
        Me.Button9 = New DevExpress.XtraEditors.SimpleButton
        Me.Button8 = New DevExpress.XtraEditors.SimpleButton
        Me.gbxAccion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxAccion
        '
        Me.gbxAccion.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.gbxAccion.Controls.Add(Me.btnBasura)
        Me.gbxAccion.Controls.Add(Me.btnCable)
        Me.gbxAccion.Controls.Add(Me.btnSalir)
        Me.gbxAccion.Controls.Add(Me.btnCelular)
        Me.gbxAccion.Controls.Add(Me.btnTelefono)
        Me.gbxAccion.Controls.Add(Me.btnEnergia)
        Me.gbxAccion.Controls.Add(Me.btnAgua)
        Me.gbxAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAccion.ForeColor = System.Drawing.Color.Maroon
        Me.gbxAccion.Location = New System.Drawing.Point(8, 8)
        Me.gbxAccion.Name = "gbxAccion"
        Me.gbxAccion.Size = New System.Drawing.Size(688, 512)
        Me.gbxAccion.TabIndex = 151
        Me.gbxAccion.TabStop = False
        Me.gbxAccion.Text = "SELECCIONE  UNA  ACCION"
        '
        'btnBasura
        '
        Me.btnBasura.Image = CType(resources.GetObject("btnBasura.Image"), System.Drawing.Image)
        Me.btnBasura.Location = New System.Drawing.Point(320, 192)
        Me.btnBasura.Name = "btnBasura"
        Me.btnBasura.Size = New System.Drawing.Size(240, 64)
        Me.btnBasura.TabIndex = 7
        Me.btnBasura.Text = "SERVICIO DE BASURA"
        '
        'btnCable
        '
        Me.btnCable.Image = CType(resources.GetObject("btnCable.Image"), System.Drawing.Image)
        Me.btnCable.Location = New System.Drawing.Point(64, 192)
        Me.btnCable.Name = "btnCable"
        Me.btnCable.Size = New System.Drawing.Size(240, 64)
        Me.btnCable.TabIndex = 6
        Me.btnCable.Text = "TELEVISION POR CABLE"
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(200, 272)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(240, 64)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "SALIR"
        '
        'btnCelular
        '
        Me.btnCelular.Image = CType(resources.GetObject("btnCelular.Image"), System.Drawing.Image)
        Me.btnCelular.Location = New System.Drawing.Point(320, 112)
        Me.btnCelular.Name = "btnCelular"
        Me.btnCelular.Size = New System.Drawing.Size(240, 64)
        Me.btnCelular.TabIndex = 4
        Me.btnCelular.Text = "TELEFONIA CELULAR"
        '
        'btnTelefono
        '
        Me.btnTelefono.Image = CType(resources.GetObject("btnTelefono.Image"), System.Drawing.Image)
        Me.btnTelefono.Location = New System.Drawing.Point(64, 112)
        Me.btnTelefono.Name = "btnTelefono"
        Me.btnTelefono.Size = New System.Drawing.Size(240, 64)
        Me.btnTelefono.TabIndex = 3
        Me.btnTelefono.Text = "SERVICIO DE TELEFONO"
        '
        'btnEnergia
        '
        Me.btnEnergia.Image = CType(resources.GetObject("btnEnergia.Image"), System.Drawing.Image)
        Me.btnEnergia.Location = New System.Drawing.Point(320, 32)
        Me.btnEnergia.Name = "btnEnergia"
        Me.btnEnergia.Size = New System.Drawing.Size(240, 64)
        Me.btnEnergia.TabIndex = 2
        Me.btnEnergia.Text = "SERVICIO DE ENERGIA"
        '
        'btnAgua
        '
        Me.btnAgua.Image = CType(resources.GetObject("btnAgua.Image"), System.Drawing.Image)
        Me.btnAgua.Location = New System.Drawing.Point(64, 32)
        Me.btnAgua.Name = "btnAgua"
        Me.btnAgua.Size = New System.Drawing.Size(240, 64)
        Me.btnAgua.TabIndex = 1
        Me.btnAgua.Text = "SERVICIO DE AGUA"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(704, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 512)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCIONE LA OPERACION"
        Me.GroupBox1.Visible = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Maroon
        Me.Button13.Location = New System.Drawing.Point(48, 392)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(168, 56)
        Me.Button13.TabIndex = 7
        Me.Button13.Text = "NOTA DE DEBITO"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Maroon
        Me.Button12.Location = New System.Drawing.Point(48, 320)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(168, 56)
        Me.Button12.TabIndex = 6
        Me.Button12.Text = "RECONEXION"
        '
        'Button11
        '
        Me.Button11.ForeColor = System.Drawing.Color.Maroon
        Me.Button11.Location = New System.Drawing.Point(48, 248)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(168, 56)
        Me.Button11.TabIndex = 5
        Me.Button11.Text = "ABONO"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(48, 176)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(168, 56)
        Me.Button10.TabIndex = 4
        Me.Button10.Text = "PAGO"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(48, 104)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(168, 56)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = "DEPOSITO"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Maroon
        Me.Button8.Location = New System.Drawing.Point(48, 32)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(168, 56)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "INSTALACION"
        '
        'frmPlantillasPagoProveedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxAccion)
        Me.Name = "frmPlantillasPagoProveedores"
        Me.Text = "Lista de Servicios"
        Me.gbxAccion.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgua.Click, _
        btnBasura.Click, btnCelular.Click, btnEnergia.Click, btnTelefono.Click, btnCable.Click

        Dim fr As frmListaFacturas = fr.Instance
        fr.MdiParent = Me.MdiParent
        Select Case sender.name.toupper
            Case "BTNAGUA"
                fr.Basico_ID = ServiciosBasicos.Agua
            Case "BTNBASURA"
                fr.Basico_ID = ServiciosBasicos.Basura
            Case "BTNCELULAR"
                fr.Basico_ID = ServiciosBasicos.Celular
            Case "BTNENERGIA"
                fr.Basico_ID = ServiciosBasicos.Energia
            Case "BTNTELEFONO"
                fr.Basico_ID = ServiciosBasicos.Telefono
            Case "BTNCABLE"
                fr.Basico_ID = ServiciosBasicos.TVCable

        End Select

        fr.Show()
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class
