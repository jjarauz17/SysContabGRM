Public Class frmComprasCCReportes
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmComprasCCReportes = Nothing

    Public Shared Function Instance() As frmComprasCCReportes
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmComprasCCReportes()
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Dim Mes As New VB.SysContab.MesesDB()
    Dim Compras As New VB.SysContab.Facturas_ComprasDB()
    Dim Puntos_Venta As New VB.SysContab.PuntosVentasDB()
    Dim FormaPago As New VB.SysContab.Forma_PagoDB()
    Dim r As New VB.SysContab.Rutinas()
    Friend WithEvents dgCodigo As System.Windows.Forms.DataGrid

    Public GruposCC As New VB.SysContab.GruposCCDB()
    Dim Proveedores As New VB.SysContab.ProveedoresDB()

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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFile As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrint As System.Windows.Forms.RadioButton
    Friend WithEvents rbScreen As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents cbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents tbCodigo As System.Windows.Forms.TextBox
    Friend WithEvents tbValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbMaximos As System.Windows.Forms.RadioButton
    Friend WithEvents rbMinimos As System.Windows.Forms.RadioButton
    Friend WithEvents rbListaInventarios As System.Windows.Forms.RadioButton
    Friend WithEvents rbKardex As System.Windows.Forms.RadioButton
    Friend WithEvents rbFisico As System.Windows.Forms.RadioButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbSubGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents cbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbLinear As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cbLinear = New DevExpress.XtraEditors.LookUpEdit
        Me.cbSubGrupo = New System.Windows.Forms.ComboBox
        Me.cbGrupo = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbCodigo = New System.Windows.Forms.TextBox
        Me.cbProductos = New System.Windows.Forms.ComboBox
        Me.cbProveedores = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.rbFisico = New System.Windows.Forms.RadioButton
        Me.rbKardex = New System.Windows.Forms.RadioButton
        Me.rbMaximos = New System.Windows.Forms.RadioButton
        Me.rbMinimos = New System.Windows.Forms.RadioButton
        Me.rbListaInventarios = New System.Windows.Forms.RadioButton
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.rbFile = New System.Windows.Forms.RadioButton
        Me.rbPrint = New System.Windows.Forms.RadioButton
        Me.rbScreen = New System.Windows.Forms.RadioButton
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Cancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.tbValorTotal = New System.Windows.Forms.TextBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.etDescripcion = New System.Windows.Forms.Label
        Me.GroupBox4.SuspendLayout()
        CType(Me.cbLinear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbLinear)
        Me.GroupBox4.Controls.Add(Me.cbSubGrupo)
        Me.GroupBox4.Controls.Add(Me.cbGrupo)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.tbCodigo)
        Me.GroupBox4.Controls.Add(Me.cbProductos)
        Me.GroupBox4.Controls.Add(Me.cbProveedores)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(8, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(456, 248)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CRITERIOS DE SELECCION"
        '
        'cbLinear
        '
        Me.cbLinear.Location = New System.Drawing.Point(104, 130)
        Me.cbLinear.Name = "cbLinear"
        Me.cbLinear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLinear.Properties.LookAndFeel.UseDefaultLookAndFeel = True
        Me.cbLinear.Properties.LookAndFeel.UseWindowsXPTheme = False
        Me.cbLinear.Properties.NullText = ""
        Me.cbLinear.Size = New System.Drawing.Size(344, 25)
        Me.cbLinear.TabIndex = 67
        '
        'cbSubGrupo
        '
        Me.cbSubGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubGrupo.Location = New System.Drawing.Point(104, 198)
        Me.cbSubGrupo.Name = "cbSubGrupo"
        Me.cbSubGrupo.Size = New System.Drawing.Size(344, 21)
        Me.cbSubGrupo.TabIndex = 63
        '
        'cbGrupo
        '
        Me.cbGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupo.Location = New System.Drawing.Point(104, 164)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(344, 21)
        Me.cbGrupo.TabIndex = 62
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(8, 198)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 26)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "Sub Grupo:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(8, 164)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 26)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Grupo:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 26)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Linea:"
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(104, 60)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(160, 21)
        Me.tbCodigo.TabIndex = 5
        '
        'cbProductos
        '
        Me.cbProductos.Location = New System.Drawing.Point(104, 95)
        Me.cbProductos.Name = "cbProductos"
        Me.cbProductos.Size = New System.Drawing.Size(344, 23)
        Me.cbProductos.TabIndex = 6
        '
        'cbProveedores
        '
        Me.cbProveedores.Location = New System.Drawing.Point(104, 26)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(344, 23)
        Me.cbProveedores.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 25)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Articulo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Código"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Proveedor"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbFisico)
        Me.GroupBox6.Controls.Add(Me.rbKardex)
        Me.GroupBox6.Controls.Add(Me.rbMaximos)
        Me.GroupBox6.Controls.Add(Me.rbMinimos)
        Me.GroupBox6.Controls.Add(Me.rbListaInventarios)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(8, 310)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(456, 198)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "OPCIONES DE REPORTES"
        '
        'rbFisico
        '
        Me.rbFisico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbFisico.Location = New System.Drawing.Point(8, 164)
        Me.rbFisico.Name = "rbFisico"
        Me.rbFisico.Size = New System.Drawing.Size(144, 21)
        Me.rbFisico.TabIndex = 4
        Me.rbFisico.Text = "Inventario Físico"
        Me.rbFisico.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbKardex
        '
        Me.rbKardex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbKardex.Location = New System.Drawing.Point(8, 129)
        Me.rbKardex.Name = "rbKardex"
        Me.rbKardex.Size = New System.Drawing.Size(144, 22)
        Me.rbKardex.TabIndex = 3
        Me.rbKardex.Text = "Inventario Kardex"
        Me.rbKardex.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbMaximos
        '
        Me.rbMaximos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbMaximos.Location = New System.Drawing.Point(6, 95)
        Me.rbMaximos.Name = "rbMaximos"
        Me.rbMaximos.Size = New System.Drawing.Size(144, 21)
        Me.rbMaximos.TabIndex = 2
        Me.rbMaximos.Text = "Máximos"
        Me.rbMaximos.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbMinimos
        '
        Me.rbMinimos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbMinimos.Location = New System.Drawing.Point(6, 60)
        Me.rbMinimos.Name = "rbMinimos"
        Me.rbMinimos.Size = New System.Drawing.Size(146, 26)
        Me.rbMinimos.TabIndex = 1
        Me.rbMinimos.Text = "Mínimos"
        Me.rbMinimos.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbListaInventarios
        '
        Me.rbListaInventarios.Checked = True
        Me.rbListaInventarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbListaInventarios.Location = New System.Drawing.Point(6, 26)
        Me.rbListaInventarios.Name = "rbListaInventarios"
        Me.rbListaInventarios.Size = New System.Drawing.Size(152, 26)
        Me.rbListaInventarios.TabIndex = 0
        Me.rbListaInventarios.TabStop = True
        Me.rbListaInventarios.Text = "Lista de Inventarios"
        Me.rbListaInventarios.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.rbFile)
        Me.GroupBox8.Controls.Add(Me.rbPrint)
        Me.GroupBox8.Controls.Add(Me.rbScreen)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox8.Location = New System.Drawing.Point(528, 52)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(176, 112)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "SALIDA"
        '
        'rbFile
        '
        Me.rbFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbFile.Location = New System.Drawing.Point(6, 78)
        Me.rbFile.Name = "rbFile"
        Me.rbFile.Size = New System.Drawing.Size(154, 25)
        Me.rbFile.TabIndex = 2
        Me.rbFile.Text = "Archivo"
        Me.rbFile.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbPrint
        '
        Me.rbPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbPrint.Location = New System.Drawing.Point(6, 52)
        Me.rbPrint.Name = "rbPrint"
        Me.rbPrint.Size = New System.Drawing.Size(154, 26)
        Me.rbPrint.TabIndex = 1
        Me.rbPrint.Text = "Impresora"
        Me.rbPrint.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'rbScreen
        '
        Me.rbScreen.Checked = True
        Me.rbScreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.rbScreen.Location = New System.Drawing.Point(6, 26)
        Me.rbScreen.Name = "rbScreen"
        Me.rbScreen.Size = New System.Drawing.Size(152, 26)
        Me.rbScreen.TabIndex = 0
        Me.rbScreen.TabStop = True
        Me.rbScreen.Text = "Pantalla"
        Me.rbScreen.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Cancel)
        Me.GroupBox9.Controls.Add(Me.cmdImprimir)
        Me.GroupBox9.Location = New System.Drawing.Point(528, 198)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(176, 129)
        Me.GroupBox9.TabIndex = 8
        Me.GroupBox9.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(56, 60)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 25)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "Cancelar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(56, 26)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 25)
        Me.cmdImprimir.TabIndex = 0
        Me.cmdImprimir.Text = "Aceptar"
        '
        'tbValorTotal
        '
        Me.tbValorTotal.BackColor = System.Drawing.SystemColors.HotTrack
        Me.tbValorTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbValorTotal.ForeColor = System.Drawing.Color.Chartreuse
        Me.tbValorTotal.Location = New System.Drawing.Point(152, 24)
        Me.tbValorTotal.Name = "tbValorTotal"
        Me.tbValorTotal.Size = New System.Drawing.Size(104, 20)
        Me.tbValorTotal.TabIndex = 8
        Me.tbValorTotal.Text = "33333333333333"
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox12.Controls.Add(Me.Label4)
        Me.GroupBox12.Controls.Add(Me.etDescripcion)
        Me.GroupBox12.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1008, 34)
        Me.GroupBox12.TabIndex = 115
        Me.GroupBox12.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(8, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 14)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "REPORTE DE INVENTARIO"
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(3, 9)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(1000, 21)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmComprasCCReportes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "frmComprasCCReportes"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.cbLinear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmComprasCCReportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Linea As New VB.SysContab.Grupos_InventarioDB()

        cbLinear.Properties.DataSource = GruposCC.Lineas().Tables(0)
        cbLinear.Properties.PopulateColumns()
        cbLinear.Properties.ValueMember = "Código"
        cbLinear.Properties.DisplayMember = "Nombre"
        cbLinear.Properties.Columns("Código").Visible = False

        Me.cbProveedores.DataSource = Proveedores.ListAll().Tables("Proveedores")
        Me.cbProveedores.ValueMember = "Codigo"
        Me.cbProveedores.DisplayMember = "Nombre"

        cbProductos.DataSource = GruposCC.ArticulosCCList1().Tables("GruposCC") 'Articulo.ArticulosListAll.Tables("Articulos")
        cbProductos.ValueMember = "Código"
        cbProductos.DisplayMember = "Nombre"
        cbProductos.SelectedValue = 0

        r.ComboAutoComplete(Me.cbProveedores)
        r.ComboAutoComplete(Me.cbProductos)
        'r.ComboAutoComplete(Me.cbLinea)
        r.ComboAutoComplete(Me.cbGrupo)
        r.ComboAutoComplete(Me.cbSubGrupo)

    End Sub

    Private Sub cbLinea_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cbGrupo.DataSource = GruposCC.Grupos(IIf(cbLinear.EditValue Is Nothing, 0, cbLinear.EditValue)).Tables(0)
        cbGrupo.ValueMember = "Código"
        cbGrupo.DisplayMember = "Nombre"
    End Sub

    Private Sub cbGrupo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrupo.SelectedValueChanged
        cbSubGrupo.DataSource = GruposCC.SubGrupos(Me.cbGrupo.SelectedValue).Tables("GruposCC")
        cbSubGrupo.ValueMember = "Código"
        cbSubGrupo.DisplayMember = "Nombre"
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim fReportes As New frmReportes
        Dim ds As DataSet

        If Me.rbListaInventarios.Checked = True Then
            'Dim rLista As New rptInventarioLista
            Dim rLista As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rLista.Load(Application.StartupPath & "\Reportes\rptInventarioLista.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            ds = GruposCC.ArticulosCCLista(cbProductos.SelectedValue, cbProveedores.SelectedValue, IIf(cbLinear.EditValue Is Nothing, 0, cbLinear.EditValue), IIf(cbGrupo.SelectedValue Is Nothing, 0, cbGrupo.SelectedValue), IIf(cbSubGrupo.SelectedValue Is Nothing, 0, cbSubGrupo.SelectedValue))
            ds.WriteXml(Application.StartupPath & "\xml\RepInvent.xml", XmlWriteMode.WriteSchema)
            rLista.Database.Tables("_ArticulosCCMaximo").Location = Application.StartupPath & "\xml\RepInvent.xml"
            rLista.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
            fReportes.crvReportes.ReportSource = rLista

        ElseIf Me.rbMinimos.Checked = True Then
            'Dim rMinimos As New rptInventarioMinimo
            Dim rMinimos As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rMinimos.Load(Application.StartupPath & "\Reportes\rptInventarioMinimo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            ds = GruposCC.ArticulosCCMinimo(cbProductos.SelectedValue, cbProveedores.SelectedValue, IIf(cbLinear.EditValue Is Nothing, 0, cbLinear.EditValue), IIf(cbGrupo.SelectedValue Is Nothing, 0, cbGrupo.SelectedValue), IIf(cbSubGrupo.SelectedValue Is Nothing, 0, cbSubGrupo.SelectedValue))
            ds.WriteXml(Application.StartupPath & "\xml\RepInvent.xml", XmlWriteMode.WriteSchema)
            rMinimos.Database.Tables("_ArticulosCCMaximo").Location = Application.StartupPath & "\xml\RepInvent.xml"
            rMinimos.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
            fReportes.crvReportes.ReportSource = rMinimos

        ElseIf Me.rbMaximos.Checked = True Then
            'Dim rMaximos As New rptInventarioMaximo
            Dim rMaximos As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rMaximos.Load(Application.StartupPath & "\Reportes\rptInventarioMaximo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            ds = GruposCC.ArticulosCCMaximo(cbProductos.SelectedValue, cbProveedores.SelectedValue, IIf(cbLinear.EditValue Is Nothing, 0, cbLinear.EditValue), IIf(cbGrupo.SelectedValue Is Nothing, 0, cbGrupo.SelectedValue), IIf(cbSubGrupo.SelectedValue Is Nothing, 0, cbSubGrupo.SelectedValue))
            ds.WriteXml(Application.StartupPath & "\xml\RepInvent.xml", XmlWriteMode.WriteSchema)
            rMaximos.Database.Tables("_ArticulosCCMaximo").Location = Application.StartupPath & "\xml\RepInvent.xml"
            rMaximos.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
            fReportes.crvReportes.ReportSource = rMaximos

        ElseIf Me.rbKardex.Checked = True Then
            'Dim rKardex As New rptInventarioKardex
            Dim rKardex As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rKardex.Load(Application.StartupPath & "\Reportes\rptInventarioKardex.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            ds = GruposCC.Kardex(cbProductos.SelectedValue, cbProveedores.SelectedValue, IIf(cbLinear.EditValue Is Nothing, 0, cbLinear.EditValue), IIf(cbGrupo.SelectedValue Is Nothing, 0, cbGrupo.SelectedValue), IIf(cbSubGrupo.SelectedValue Is Nothing, 0, cbSubGrupo.SelectedValue))
            ds.WriteXml(Application.StartupPath & "\xml\RepInvent.xml", XmlWriteMode.WriteSchema)
            rKardex.Database.Tables("_InventarioKardex").Location = Application.StartupPath & "\xml\RepInvent.xml"
            rKardex.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
            fReportes.crvReportes.ReportSource = rKardex

        ElseIf Me.rbFisico.Checked = True Then
            'Dim rFisico As New rptInventarioFisico
            Dim rFisico As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rFisico.Load(Application.StartupPath & "\Reportes\rptInventarioFisico.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            ds = GruposCC.ArticulosCCLista(cbProductos.SelectedValue, cbProveedores.SelectedValue, IIf(cbLinear.EditValue Is Nothing, 0, cbLinear.EditValue), IIf(cbGrupo.SelectedValue Is Nothing, 0, cbGrupo.SelectedValue), IIf(cbSubGrupo.SelectedValue Is Nothing, 0, cbSubGrupo.SelectedValue))
            ds.WriteXml(Application.StartupPath & "\xml\RepInvent.xml", XmlWriteMode.WriteSchema)
            rFisico.Database.Tables("_ArticulosCCMaximo").Location = Application.StartupPath & "\xml\RepInvent.xml"
            rFisico.Database.Tables("_GetLogoEmpresa").Location = Application.StartupPath & "\xml\logoempresa.xml"
            fReportes.crvReportes.ReportSource = rFisico
        End If

        If rbScreen.Checked = True Then
            fReportes.Show()
        ElseIf rbPrint.Checked = True Then
            fReportes.crvReportes.PrintReport()
        Else
            fReportes.crvReportes.ExportReport()
        End If
    End Sub

End Class