Imports Microsoft.Win32
Imports System.Net

Public Class frmAgregarPuntoVenta
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarPuntoVenta = Nothing

    Public Shared Function Instance() As frmAgregarPuntoVenta
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarPuntoVenta()
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
    Friend WithEvents etCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombrePC As System.Windows.Forms.TextBox
    Friend WithEvents lbComputadoras As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbComputadoras = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNombrePC = New System.Windows.Forms.TextBox
        Me.etCodigo = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.etNombre = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbComputadoras)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombrePC)
        Me.GroupBox1.Controls.Add(Me.etCodigo)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.etNombre)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 511)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'lbComputadoras
        '
        Me.lbComputadoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbComputadoras.ItemHeight = 15
        Me.lbComputadoras.Location = New System.Drawing.Point(104, 164)
        Me.lbComputadoras.Name = "lbComputadoras"
        Me.lbComputadoras.Size = New System.Drawing.Size(360, 274)
        Me.lbComputadoras.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PC:"
        '
        'txtNombrePC
        '
        Me.txtNombrePC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombrePC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePC.Location = New System.Drawing.Point(104, 138)
        Me.txtNombrePC.Name = "txtNombrePC"
        Me.txtNombrePC.ReadOnly = True
        Me.txtNombrePC.Size = New System.Drawing.Size(360, 21)
        Me.txtNombrePC.TabIndex = 2
        '
        'etCodigo
        '
        Me.etCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etCodigo.Location = New System.Drawing.Point(16, 34)
        Me.etCodigo.Name = "etCodigo"
        Me.etCodigo.Size = New System.Drawing.Size(72, 26)
        Me.etCodigo.TabIndex = 8
        Me.etCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(104, 34)
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(96, 21)
        Me.txtCodigo.TabIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(216, 456)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 35)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "&Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(104, 456)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 35)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'etNombre
        '
        Me.etNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.etNombre.Location = New System.Drawing.Point(16, 86)
        Me.etNombre.Name = "etNombre"
        Me.etNombre.Size = New System.Drawing.Size(72, 26)
        Me.etNombre.TabIndex = 2
        Me.etNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(104, 86)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(360, 21)
        Me.txtNombre.TabIndex = 1
        '
        'frmAgregarPuntoVenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(536, 526)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAgregarPuntoVenta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas()
    Dim PuntosVenta As New VB.SysContab.PuntosVentasDB()
    Dim Red As String
    Dim i As Integer

    Private Sub frmAgregarPuntoVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r.FormularioColor(Me)
        Try
            Dim ConnectionFile As New System.IO.StreamReader(Application.StartupPath & "\Red.txt")

            Red = "WinNT://" & ConnectionFile.ReadLine.ToString()

            Me.lbComputadoras.BackColor = Color.White
            Dim domain As New DirectoryServices.DirectoryEntry(Red)
            Dim computadoras As DirectoryServices.DirectoryEntries
            Dim computadora As DirectoryServices.DirectoryEntry

            computadoras = domain.Children
            computadoras.SchemaFilter.Add("Computer")
            i = 0
            For Each computadora In computadoras
                i = 1
                'MessageBox.Show(computadora.Name)
                If PuntosVenta.PcNombre(computadora.Name).Tables("Puntos_Venta").Rows.Count = 0 Then
                    lbComputadoras.Items.Add(computadora.Name)
                End If
            Next

            If i = 0 Then
                If PuntosVenta.PcNombre(Environment.MachineName.ToString).Tables("Puntos_Venta").Rows.Count = 0 Then
                    Me.lbComputadoras.Items.Add(Environment.MachineName.ToString)
                End If
            End If

            txtCodigo.Text = PuntosVenta.Numero
            txtNombre.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'Dim rr As RegistryKey = Registry.LocalMachine.OpenSubKey(RegistryHive.LocalMachine, "dfdf")
        'Dim dns As System.Net.IPHostEntry = System.Net.Dns.Resolve(Environment.MachineName)
        'MessageBox.Show(dns.AddressList(0).ToString)
        'MsgBox(dns.AddressLis)

        'MsgBox(Environment.MachineName)

        'Dim ipEntry As IPHostEntry
        'Dim address As IPAddress

        'ipEntry = dns.Resolve(Environment.MachineName)

        'For Each address In ipEntry.AddressList
        '    'Console.WriteLine(address.ToString())
        '    MsgBox(address.ToString())
        'Next

        'Exit Sub

        If Me.lbComputadoras.Items.Count = 0 Then
            MsgBox("Todas las Computadoras de la red ya fueron configuradas como Puntos de Venta.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el nombre del Punto de Venta", MsgBoxStyle.Exclamation)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub
        End If

        If Trim(txtNombrePC.Text) = "" Then
            MsgBox("Seleccione el nombre de la Computadora", MsgBoxStyle.Exclamation)
            txtNombrePC.Focus()
            txtNombrePC.SelectAll()
            Exit Sub
        End If

        Try
            PuntosVenta.AddItem(txtCodigo.Text, txtNombre.Text, Me.txtNombrePC.Text)
            r.LimpiarControles(GroupBox1)
            txtCodigo.Text = PuntosVenta.Numero
            txtNombre.Focus()

            Dim domain As New DirectoryServices.DirectoryEntry(Red)
            Dim computadoras As DirectoryServices.DirectoryEntries
            Dim computadora As DirectoryServices.DirectoryEntry

            computadoras = domain.Children
            computadoras.SchemaFilter.Add("Computer")

            lbComputadoras.Items.Clear()

            For Each computadora In computadoras
                'MessageBox.Show(computadora.Name)
                If PuntosVenta.PcNombre(computadora.Name).Tables("Puntos_Venta").Rows.Count = 0 Then
                    lbComputadoras.Items.Add(computadora.Name)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmAgregarPuntoVenta_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim Tabla As New DataTable()
        Dim ds As New DataSet()

        Dim f As frmPuntosVenta = f.Instance

        ds = PuntosVenta.List

        f.dgPuntosVentas.DataSource = ds.Tables("Puntos_Venta").DefaultView
        Tabla = ds.Tables("Puntos_Venta")

        r.FormatGenerico(f.dgPuntosVentas, Tabla)

        If ds.Tables("Puntos_Venta").Rows.Count <> 0 Then
            Registro = f.dgPuntosVentas.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        f.dgPuntosVentas.CaptionText = "Información de Puntos de Venta"

    End Sub

    Private Sub lbComputadoras_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbComputadoras.SelectedIndexChanged
        Me.txtNombrePC.Text = lbComputadoras.Items.Item(lbComputadoras.SelectedIndex)
    End Sub

End Class
