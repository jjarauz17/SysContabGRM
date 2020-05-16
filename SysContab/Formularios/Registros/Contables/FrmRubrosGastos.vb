Public Class FrmRubrosGastos
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents cmbcuentas As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdnuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdeditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmddepnomina As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.cmdnuevo = New DevExpress.XtraEditors.SimpleButton
        Me.cmbcuentas = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmdGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdeditar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmddepnomina = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(60, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'txtnombre
        '
        Me.txtnombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(120, 17)
        Me.txtnombre.MaxLength = 150
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(248, 21)
        Me.txtnombre.TabIndex = 1
        '
        'cmdnuevo
        '
        Me.cmdnuevo.Location = New System.Drawing.Point(89, 9)
        Me.cmdnuevo.Name = "cmdnuevo"
        Me.cmdnuevo.Size = New System.Drawing.Size(75, 24)
        Me.cmdnuevo.TabIndex = 2
        Me.cmdnuevo.Text = "&Nuevo"
        '
        'cmbcuentas
        '
        Me.cmbcuentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbcuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcuentas.Enabled = False
        Me.cmbcuentas.Location = New System.Drawing.Point(120, 43)
        Me.cmbcuentas.Name = "cmbcuentas"
        Me.cmbcuentas.Size = New System.Drawing.Size(248, 21)
        Me.cmbcuentas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cuenta Contable:"
        '
        'CmdGuardar
        '
        Me.CmdGuardar.Enabled = False
        Me.CmdGuardar.Location = New System.Drawing.Point(332, 9)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(75, 24)
        Me.CmdGuardar.TabIndex = 2
        Me.CmdGuardar.Text = "&Guardar"
        '
        'cmdeditar
        '
        Me.cmdeditar.Enabled = False
        Me.cmdeditar.Location = New System.Drawing.Point(170, 9)
        Me.cmdeditar.Name = "cmdeditar"
        Me.cmdeditar.Size = New System.Drawing.Size(75, 24)
        Me.cmdeditar.TabIndex = 2
        Me.cmdeditar.Text = "E&ditar"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Location = New System.Drawing.Point(251, 9)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 24)
        Me.cmdEliminar.TabIndex = 2
        Me.cmdEliminar.Text = "&Eliminar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdsalir.Location = New System.Drawing.Point(413, 9)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(75, 24)
        Me.cmdsalir.TabIndex = 2
        Me.cmdsalir.Text = "&Salir"
        '
        'GridDetalle
        '
        Me.GridDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDetalle.Location = New System.Drawing.Point(16, 78)
        Me.GridDetalle.MainView = Me.GridView1
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.Size = New System.Drawing.Size(472, 206)
        Me.GridDetalle.TabIndex = 4
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cmddepnomina
        '
        Me.cmddepnomina.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmddepnomina.Appearance.Options.UseTextOptions = True
        Me.cmddepnomina.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmddepnomina.Location = New System.Drawing.Point(392, 21)
        Me.cmddepnomina.Name = "cmddepnomina"
        Me.cmddepnomina.Size = New System.Drawing.Size(96, 43)
        Me.cmddepnomina.TabIndex = 5
        Me.cmddepnomina.Text = "&Departamentos Nomina"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdEliminar)
        Me.PanelControl1.Controls.Add(Me.cmdsalir)
        Me.PanelControl1.Controls.Add(Me.cmdeditar)
        Me.PanelControl1.Controls.Add(Me.CmdGuardar)
        Me.PanelControl1.Controls.Add(Me.cmdnuevo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 306)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(496, 42)
        Me.PanelControl1.TabIndex = 6
        '
        'FrmRubrosGastos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(496, 348)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.cmddepnomina)
        Me.Controls.Add(Me.GridDetalle)
        Me.Controls.Add(Me.cmbcuentas)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmRubrosGastos"
        Me.Text = "FrmRubrosGastos"
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Enum TipoReporte
        RubrosGastos
        CentrosCostos
    End Enum
    Private Nuevo As Boolean = False
    Private Elimina As Boolean
    Private Formulario As TipoReporte
    Private Procedimiento As String
    Private vista As New DevExpress.XtraGrid.Views.Grid.GridView
    Private Id As Integer

    Private Sub FrmRubrosGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DT As New DataTable
        Select Case Formulario
            Case TipoReporte.RubrosGastos : Procedimiento = "RubrosGastos"
                cmddepnomina.Visible = False
                Me.Text = "Catalogo de Rubros de Gastos"
            Case TipoReporte.CentrosCostos : Procedimiento = "CentroDeCosto"
                Me.Text = "Catalogo de Centros de Costos"
        End Select
        GetData()
        GridView1.Columns("Activo").Visible = False
        DT = ObtieneDatos("SELECT Cuenta,Cuenta + ' ' + Nombre AS Nombre FROM Catalogo WHERE Tipo='A' AND Empresa = " & EmpresaActual)
        cmbcuentas.DataSource = DT
        cmbcuentas.ValueMember = "Cuenta"
        cmbcuentas.DisplayMember = "Nombre"
        cmbcuentas.SelectedIndex = -1
    End Sub

    Private Sub cmdnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnuevo.Click
        Nuevo = True
        Elimina = False
        LimpiarControles(Me)
        CmdGuardar.Enabled = True
        cmdeditar.Enabled = False
        cmdEliminar.Enabled = False
        txtnombre.Enabled = True
        cmbcuentas.Enabled = True
    End Sub

    Private Sub CmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGuardar.Click
        If Formulario = TipoReporte.RubrosGastos Then If Trim(txtnombre.Text = vbNullString) Or (cmbcuentas.SelectedIndex < 0) Then Exit Sub
        If Formulario = TipoReporte.CentrosCostos Then If Trim(txtnombre.Text = vbNullString) Then Exit Sub
        If Elimina Then
            If ObtieneDatos("SELECT COUNT(" & IIf(Formulario = TipoReporte.CentrosCostos, "IdCentroCosto", "IdRubroGasto") & ") FROM Distribucion WHERE IdEmpresa = " & EmpresaActual & " AND " & IIf(Formulario = TipoReporte.CentrosCostos, "IdCentroCosto=", "IdRubroGasto=") & GridView1.GetFocusedRowCellValue("Codigo")).Rows(0).Item(0) > 0 Then
                MsgBox("No puede eliminar el registro, ya tiene asociada una distribucion", MsgBoxStyle.Critical)
                GoTo Continua
            End If
        End If
        If GuardaDatos("SPGuardaDatosDep " & " " & IIf(Nuevo, 0, Id) & ",'" & txtnombre.Text & "','" & cmbcuentas.SelectedValue & "'," & IIf(Elimina, 0, 1) & ",'" & Procedimiento & "'," & EmpresaActual) Then
            GetData()
Continua:
            cmdnuevo_Click(sender, e)
            txtnombre.Enabled = False
            cmbcuentas.Enabled = False
            Nuevo = True
            Elimina = False
        Else
            MsgBox("Error al guardar, intente de nuevo", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub GetData()
        GridDetalle.DataSource = ObtieneDatos("SELECT Codigo,Nombre,CuentaContable AS [Cuenta Contable],Activo FROM " & Procedimiento & " WHERE Activo=1 AND Empresa = " & EmpresaActual & " ORDER BY Codigo")
    End Sub

    Public Sub Mostrar(ByVal Tipo As TipoReporte)
        Formulario = Tipo
        Me.Show()
    End Sub

    Private Sub GridDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDetalle.Click
        Dim fila As DataRow
        vista = GridDetalle.MainView
        For Each i As Integer In vista.GetSelectedRows
            If i >= 0 Then
                fila = vista.GetDataRow(i)
                txtnombre.Text = fila.Item("Nombre")
                cmbcuentas.SelectedValue = fila.Item("Cuenta Contable")
                Id = fila.Item("Codigo")
                cmdeditar.Enabled = True
                cmdEliminar.Enabled = True
            End If
        Next
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub cmdeditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeditar.Click
        cmdEliminar.Enabled = False
        CmdGuardar.Enabled = True
        txtnombre.Enabled = True
        cmbcuentas.Enabled = True
        Nuevo = False
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        cmdeditar.Enabled = False
        CmdGuardar.Enabled = False
        Elimina = True
        Nuevo = False
        CmdGuardar_Click(sender, e)
    End Sub

    
    Private Sub cmddepnomina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddepnomina.Click
        Dim Forma As New FrmDepartamentosNomina
        Forma.Centro = GridView1.GetFocusedRowCellValue("Codigo")
        Forma.ShowDialog()
    End Sub
End Class
