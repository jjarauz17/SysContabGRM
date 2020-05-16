Public Class FrmDepartamentosNomina
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
    Friend WithEvents cmbdepartamentos As System.Windows.Forms.ComboBox
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdeliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdagregar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbdepartamentos = New System.Windows.Forms.ComboBox
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdsalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdeliminar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdagregar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Departamento:"
        '
        'cmbdepartamentos
        '
        Me.cmbdepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdepartamentos.Location = New System.Drawing.Point(112, 16)
        Me.cmbdepartamentos.Name = "cmbdepartamentos"
        Me.cmbdepartamentos.Size = New System.Drawing.Size(200, 21)
        Me.cmbdepartamentos.TabIndex = 0
        '
        'GridDetalle
        '
        '
        'GridDetalle.EmbeddedNavigator
        '
        Me.GridDetalle.EmbeddedNavigator.Name = ""
        Me.GridDetalle.Location = New System.Drawing.Point(16, 48)
        Me.GridDetalle.MainView = Me.GridView1
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.Size = New System.Drawing.Size(336, 160)
        Me.GridDetalle.TabIndex = 5
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridDetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False

        '
        'cmdguardar
        '
        Me.cmdguardar.Location = New System.Drawing.Point(147, 224)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.TabIndex = 3
        Me.cmdguardar.Text = "Guardar"
        '
        'cmdsalir
        '
        Me.cmdsalir.Location = New System.Drawing.Point(235, 224)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.TabIndex = 4
        Me.cmdsalir.Text = "&Salir"
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Location = New System.Drawing.Point(59, 224)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.TabIndex = 2
        Me.cmdeliminar.Text = "&Borrar"
        '
        'cmdagregar
        '
        Me.cmdagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdagregar.ForeColor = System.Drawing.Color.Red
        Me.cmdagregar.Location = New System.Drawing.Point(320, 14)
        Me.cmdagregar.Name = "cmdagregar"
        Me.cmdagregar.Size = New System.Drawing.Size(32, 23)
        Me.cmdagregar.TabIndex = 1
        Me.cmdagregar.Text = "+"
        '
        'FrmDepartamentosNomina
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(368, 266)
        Me.Controls.Add(Me.cmdguardar)
        Me.Controls.Add(Me.GridDetalle)
        Me.Controls.Add(Me.cmbdepartamentos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.cmdeliminar)
        Me.Controls.Add(Me.cmdagregar)
        Me.Name = "FrmDepartamentosNomina"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Departamentos Nomina"
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _Centro As Integer

    Public Property Centro()
        Get
            Return _Centro
        End Get
        Set(ByVal Value)
            _Centro = Value
        End Set
    End Property

    Private DT As New DataTable

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub FrmDepartamentosNomina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbdepartamentos.DataSource = ObtieneDatos("SELECT dep_codigo AS Codigo,dep_nombre AS Nombre  FROM Departamentos WHERE empr_codigo = " & EmpresaActual)
        cmbdepartamentos.DisplayMember = "Nombre"
        cmbdepartamentos.ValueMember = "Codigo"
        GetData()
    End Sub

    Public Sub GetData()
        DT = ObtieneDatos("SELECT IdDetalle AS Det,cco_codigo as Codigo,dep_codigo as Departamento FROM CentroDeCosto_Departamento WHERE Empresa = " & EmpresaActual & " AND cco_codigo = " & Centro)
        GridDetalle.DataSource = DT
        GridView1.Columns("Det").Visible = False
        GridView1.Columns("Codigo").Visible = False
        Dim ItemDep As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        ItemDep.DataSource = ObtieneDatos("SELECT dep_codigo AS Codigo,dep_nombre AS Nombre  FROM Departamentos WHERE empr_codigo = " & EmpresaActual)
        ItemDep.ValueMember = "Codigo"
        ItemDep.DisplayMember = "Nombre"
        ItemDep.NullText = ""
        ItemDep.ShowFooter = False
        ItemDep.ShowHeader = False
        ItemDep.PopulateColumns()
        ItemDep.Columns(0).Visible = False
        GridView1.Columns("Departamento").ColumnEdit = ItemDep
    End Sub


    Private Sub cmdagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdagregar.Click
        Dim Fila As DataRow
        Fila = DT.NewRow
        Fila("Codigo") = Centro
        Fila("Departamento") = cmbdepartamentos.SelectedValue
        DT.Rows.Add(Fila)
        GridDetalle.DataSource = DT
        GridDetalle.Refresh()
    End Sub

    Private Sub cmdeliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeliminar.Click
        If Not IsDBNull(GridView1.GetFocusedRowCellValue("Det")) Then
            GuardaDatos("DELETE FROM CentroDeCosto_Departamento WHERE IdDetalle = " & GridView1.GetFocusedRowCellValue("Det"))
        Else
            For i As Integer = 0 To DT.Rows.Count - 1
                If DT.Rows(i).Item("Codigo") = GridView1.GetFocusedRowCellValue("Codigo") And _
                DT.Rows(i).Item("Departamento") = GridView1.GetFocusedRowCellValue("Departamento") Then
                    DT.Rows(i).Delete()
                    DT.AcceptChanges()
                    Exit For
                End If
            Next
        End If
        GridDetalle.DataSource = DT
        GridDetalle.Refresh()
    End Sub

    Private Sub cmdguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdguardar.Click
        Dim Temp As Boolean = False
        For i As Integer = 0 To GridView1.DataRowCount - 1
            If GuardaDatos("INSERT INTO CentroDeCosto_Departamento(empresa,cco_codigo,dep_codigo) VALUES(" & EmpresaActual & "," & Centro & ",'" & GridView1.GetRowCellValue(i, "Departamento") & "')") = False Then
                '    MsgBox("Error: Verifique que no exista el departamento '" & GridView1.GetRowCellDisplayText(i, "Departamento") & "'")
                Temp = True
            End If
        Next
        If Temp = True Then
            'MsgBox("Se produjeron errores al guardar, intente de nuevo", MsgBoxStyle.Critical)
        Else
            MsgBox("Datos guardados correctamente")
        End If
        GetData()
    End Sub
End Class
