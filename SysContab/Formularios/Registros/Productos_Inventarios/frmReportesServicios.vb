Public Class frmReportesServicios
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmReportesServicios = Nothing

    Public Shared Function Instance() As frmReportesServicios
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmReportesServicios()
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbArchivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbImpresora As System.Windows.Forms.RadioButton
    Friend WithEvents rbPantalla As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbAlfabetico As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cbProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents cbGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents cbSubGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents cbLineas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rbDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbExistencias As System.Windows.Forms.RadioButton
    Friend WithEvents rbCostos As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrecios As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbProveedores = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbGrupos = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbSubGrupos = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbLineas = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbArchivo = New System.Windows.Forms.RadioButton
        Me.rbImpresora = New System.Windows.Forms.RadioButton
        Me.rbPantalla = New System.Windows.Forms.RadioButton
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.rbCodigo = New System.Windows.Forms.RadioButton
        Me.rbAlfabetico = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rbDescripcion = New System.Windows.Forms.RadioButton
        Me.rbExistencias = New System.Windows.Forms.RadioButton
        Me.rbCostos = New System.Windows.Forms.RadioButton
        Me.rbPrecios = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cbProveedores)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.cbGrupos)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.cbSubGrupos)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.cbLineas)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(208, 26)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(456, 198)
        Me.GroupBox4.TabIndex = 151
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CRITERIOS DE SELECCION"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 25)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Proveedor"
        '
        'cbProveedores
        '
        Me.cbProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedores.Location = New System.Drawing.Point(136, 26)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(304, 23)
        Me.cbProveedores.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 25)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Grupo"
        '
        'cbGrupos
        '
        Me.cbGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupos.Location = New System.Drawing.Point(136, 112)
        Me.cbGrupos.Name = "cbGrupos"
        Me.cbGrupos.Size = New System.Drawing.Size(304, 23)
        Me.cbGrupos.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Sub Grupo"
        '
        'cbSubGrupos
        '
        Me.cbSubGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubGrupos.Location = New System.Drawing.Point(136, 155)
        Me.cbSubGrupos.Name = "cbSubGrupos"
        Me.cbSubGrupos.Size = New System.Drawing.Size(304, 23)
        Me.cbSubGrupos.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Linea"
        '
        'cbLineas
        '
        Me.cbLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLineas.Location = New System.Drawing.Point(136, 69)
        Me.cbLineas.Name = "cbLineas"
        Me.cbLineas.Size = New System.Drawing.Size(304, 23)
        Me.cbLineas.TabIndex = 63
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbArchivo)
        Me.GroupBox1.Controls.Add(Me.rbImpresora)
        Me.GroupBox1.Controls.Add(Me.rbPantalla)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(208, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 164)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMATO"
        '
        'rbArchivo
        '
        Me.rbArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbArchivo.Location = New System.Drawing.Point(16, 112)
        Me.rbArchivo.Name = "rbArchivo"
        Me.rbArchivo.Size = New System.Drawing.Size(112, 34)
        Me.rbArchivo.TabIndex = 2
        Me.rbArchivo.Text = "Archivo"
        '
        'rbImpresora
        '
        Me.rbImpresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbImpresora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbImpresora.Location = New System.Drawing.Point(16, 69)
        Me.rbImpresora.Name = "rbImpresora"
        Me.rbImpresora.Size = New System.Drawing.Size(112, 34)
        Me.rbImpresora.TabIndex = 1
        Me.rbImpresora.Text = "Impresora"
        '
        'rbPantalla
        '
        Me.rbPantalla.Checked = True
        Me.rbPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPantalla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbPantalla.Location = New System.Drawing.Point(16, 26)
        Me.rbPantalla.Name = "rbPantalla"
        Me.rbPantalla.Size = New System.Drawing.Size(112, 34)
        Me.rbPantalla.TabIndex = 0
        Me.rbPantalla.TabStop = True
        Me.rbPantalla.Text = "Pantalla"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.rbCodigo)
        Me.GroupBox6.Controls.Add(Me.rbAlfabetico)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(16, 241)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(160, 164)
        Me.GroupBox6.TabIndex = 153
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ORDEN"
        '
        'rbCodigo
        '
        Me.rbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbCodigo.Location = New System.Drawing.Point(16, 69)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(112, 34)
        Me.rbCodigo.TabIndex = 1
        Me.rbCodigo.Tag = ""
        Me.rbCodigo.Text = "Código"
        '
        'rbAlfabetico
        '
        Me.rbAlfabetico.Checked = True
        Me.rbAlfabetico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAlfabetico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbAlfabetico.Location = New System.Drawing.Point(16, 26)
        Me.rbAlfabetico.Name = "rbAlfabetico"
        Me.rbAlfabetico.Size = New System.Drawing.Size(112, 34)
        Me.rbAlfabetico.TabIndex = 0
        Me.rbAlfabetico.TabStop = True
        Me.rbAlfabetico.Tag = ""
        Me.rbAlfabetico.Text = "Alfabético"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.rbDescripcion)
        Me.GroupBox5.Controls.Add(Me.rbExistencias)
        Me.GroupBox5.Controls.Add(Me.rbCostos)
        Me.GroupBox5.Controls.Add(Me.rbPrecios)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(16, 26)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(160, 198)
        Me.GroupBox5.TabIndex = 154
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TIPO DE REPORTE"
        '
        'rbDescripcion
        '
        Me.rbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbDescripcion.Location = New System.Drawing.Point(16, 155)
        Me.rbDescripcion.Name = "rbDescripcion"
        Me.rbDescripcion.Size = New System.Drawing.Size(112, 35)
        Me.rbDescripcion.TabIndex = 5
        Me.rbDescripcion.Text = "Descripción"
        '
        'rbExistencias
        '
        Me.rbExistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExistencias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbExistencias.Location = New System.Drawing.Point(16, 112)
        Me.rbExistencias.Name = "rbExistencias"
        Me.rbExistencias.Size = New System.Drawing.Size(112, 34)
        Me.rbExistencias.TabIndex = 4
        Me.rbExistencias.Text = "Existencias"
        '
        'rbCostos
        '
        Me.rbCostos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCostos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbCostos.Location = New System.Drawing.Point(16, 69)
        Me.rbCostos.Name = "rbCostos"
        Me.rbCostos.Size = New System.Drawing.Size(112, 34)
        Me.rbCostos.TabIndex = 3
        Me.rbCostos.Text = "Costos"
        '
        'rbPrecios
        '
        Me.rbPrecios.Checked = True
        Me.rbPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrecios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbPrecios.Location = New System.Drawing.Point(16, 26)
        Me.rbPrecios.Name = "rbPrecios"
        Me.rbPrecios.Size = New System.Drawing.Size(128, 34)
        Me.rbPrecios.TabIndex = 0
        Me.rbPrecios.TabStop = True
        Me.rbPrecios.Text = "Lista de Precio"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cmdSalir)
        Me.GroupBox3.Controls.Add(Me.cmdAceptar)
        Me.GroupBox3.Location = New System.Drawing.Point(350, 362)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 43)
        Me.GroupBox3.TabIndex = 155
        Me.GroupBox3.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Appearance.Options.UseFont = True
        Me.cmdSalir.Location = New System.Drawing.Point(104, 11)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 22
        Me.cmdSalir.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Location = New System.Drawing.Point(16, 11)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 20
        Me.cmdAceptar.Text = "Aceptar"
        '
        'frmReportesServicios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(848, 483)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "frmReportesServicios"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReportesServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Proveedor As New VB.SysContab.ProveedoresDB()
        Dim Linea As New VB.SysContab.Grupos_InventarioDB()

        cbProveedores.DataSource = Proveedor.ProveedoresList("3").Tables("PROVEEDORES")
        cbProveedores.ValueMember = "Codigo"
        cbProveedores.DisplayMember = "Nombre"

        cbLineas.DataSource = Linea.GetListBuscarCombo("%", "P").Tables("GRUPOS_INVENTARIO")
        cbLineas.ValueMember = "CODIGO_GRUPO"
        cbLineas.DisplayMember = "NOMBRE"

        cbGrupos.DataSource = Linea.GetListBuscarCombo("%", "P").Tables("GRUPOS_INVENTARIO")
        cbGrupos.ValueMember = "CODIGO_GRUPO"
        cbGrupos.DisplayMember = "NOMBRE"

        cbSubGrupos.DataSource = Linea.GetListBuscarCombo("%", "P").Tables("GRUPOS_INVENTARIO")
        cbSubGrupos.ValueMember = "CODIGO_GRUPO"
        cbSubGrupos.DisplayMember = "NOMBRE"

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim fReportes As New frmReportes()
        Dim Articulos As New VB.SysContab.ArticulosDB()
        Dim r As New VB.SysContab.Rutinas()

        Dim Orden As Integer

        If rbAlfabetico.Checked = True Then
            Orden = 1
        ElseIf rbCodigo.Checked = True Then
            Orden = 2
        End If

        Dim Linea As String

        If cbLineas.SelectedValue = Nothing Then
            Linea = 0
        Else
            Linea = cbLineas.SelectedValue
        End If

        If rbPrecios.Checked = True Then
            'Dim rArticulos As New rptProductos()
            Dim rArticulos As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rArticulos.Load(Application.StartupPath & "\Reportes\rptProductos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            rArticulos.SetDataSource(Articulos.GeneradorReportes(cbProveedores.SelectedValue, Linea, Orden, ""))
            fReportes.crvReportes.ReportSource = rArticulos

        ElseIf rbCostos.Checked = True Then
            'Dim rArticulosCostos As New rptProductosCostos()
            Dim rArticulosCostos As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rArticulosCostos.Load(Application.StartupPath & "\Reportes\rptProductosCostos.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            '
            rArticulosCostos.SetDataSource(Articulos.GeneradorReportes(cbProveedores.SelectedValue, Linea, Orden, ""))
            fReportes.crvReportes.ReportSource = rArticulosCostos

            'ElseIf rbExistencias.Checked = True Then
            '    Dim rArticulosExistencias As New rptProductosExistencias()
            '    rArticulosExistencias.SetDataSource(Articulos.GeneradorReportes(cbProveedores.SelectedValue, Linea, Orden))
            '    fReportes.crvReportes.ReportSource = rArticulosExistencias

            'ElseIf rbDescripcion.Checked = True Then
            '    Dim rArticulosDescripcion As New rptProductosDescripcion()
            '    rArticulosDescripcion.SetDataSource(Articulos.GeneradorReportes(cbProveedores.SelectedValue, Linea, Orden))
            '    fReportes.crvReportes.ReportSource = rArticulosDescripcion

        End If

        'freportes.Show()

        If rbPantalla.Checked = True Then
            freportes.Show()

        ElseIf rbImpresora.Checked = True Then
            fReportes.crvReportes.PrintReport()
        Else
            fReportes.crvReportes.ExportReport()
        End If
    End Sub

End Class
