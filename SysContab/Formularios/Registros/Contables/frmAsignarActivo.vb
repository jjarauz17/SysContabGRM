Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmAsignarActivo
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAsignarActivo = Nothing

    Public Shared Function Instance() As frmAsignarActivo
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAsignarActivo()
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
    Friend WithEvents dgActivos_Fijos As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAnterior As System.Windows.Forms.RadioButton
    Friend WithEvents rbSeleccionados As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents etAnterior As System.Windows.Forms.Label
    Friend WithEvents cmdAsignar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbEmpleadoAnterior As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgActivos_Fijos = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.etAnterior = New System.Windows.Forms.Label()
        Me.rbAnterior = New System.Windows.Forms.RadioButton()
        Me.rbSeleccionados = New System.Windows.Forms.RadioButton()
        Me.cbEmpleadoAnterior = New System.Windows.Forms.ComboBox()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAsignar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgActivos_Fijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgActivos_Fijos
        '
        Me.dgActivos_Fijos.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgActivos_Fijos.DataMember = ""
        Me.dgActivos_Fijos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgActivos_Fijos.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgActivos_Fijos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgActivos_Fijos.Location = New System.Drawing.Point(0, 8)
        Me.dgActivos_Fijos.Name = "dgActivos_Fijos"
        Me.dgActivos_Fijos.Size = New System.Drawing.Size(808, 352)
        Me.dgActivos_Fijos.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.GroupBox8, Me.cmdSalir, Me.cmdAsignar})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 368)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(808, 160)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbEmpleado, Me.Label1})
        Me.GroupBox2.Location = New System.Drawing.Point(400, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 104)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        '
        'cbEmpleado
        '
        Me.cbEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpleado.ItemHeight = 15
        Me.cbEmpleado.Location = New System.Drawing.Point(8, 40)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(384, 23)
        Me.cbEmpleado.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Empleado:"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox8.Controls.AddRange(New System.Windows.Forms.Control() {Me.etAnterior, Me.rbAnterior, Me.rbSeleccionados, Me.cbEmpleadoAnterior})
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox8.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(384, 104)
        Me.GroupBox8.TabIndex = 122
        Me.GroupBox8.TabStop = False
        '
        'etAnterior
        '
        Me.etAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etAnterior.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etAnterior.Location = New System.Drawing.Point(8, 48)
        Me.etAnterior.Name = "etAnterior"
        Me.etAnterior.Size = New System.Drawing.Size(136, 24)
        Me.etAnterior.TabIndex = 13
        Me.etAnterior.Text = "Empleado Anterior:"
        Me.etAnterior.Visible = False
        '
        'rbAnterior
        '
        Me.rbAnterior.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbAnterior.Location = New System.Drawing.Point(152, 16)
        Me.rbAnterior.Name = "rbAnterior"
        Me.rbAnterior.Size = New System.Drawing.Size(144, 32)
        Me.rbAnterior.TabIndex = 1
        Me.rbAnterior.Text = "Asignados"
        '
        'rbSeleccionados
        '
        Me.rbSeleccionados.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.rbSeleccionados.Location = New System.Drawing.Point(8, 17)
        Me.rbSeleccionados.Name = "rbSeleccionados"
        Me.rbSeleccionados.Size = New System.Drawing.Size(128, 31)
        Me.rbSeleccionados.TabIndex = 0
        Me.rbSeleccionados.Text = "No Asignados"
        '
        'cbEmpleadoAnterior
        '
        Me.cbEmpleadoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpleadoAnterior.ItemHeight = 15
        Me.cbEmpleadoAnterior.Location = New System.Drawing.Point(8, 72)
        Me.cbEmpleadoAnterior.Name = "cbEmpleadoAnterior"
        Me.cbEmpleadoAnterior.Size = New System.Drawing.Size(368, 23)
        Me.cbEmpleadoAnterior.TabIndex = 12
        Me.cbEmpleadoAnterior.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(456, 128)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdAsignar
        '
        Me.cmdAsignar.Location = New System.Drawing.Point(320, 128)
        Me.cmdAsignar.Name = "cmdAsignar"
        Me.cmdAsignar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAsignar.TabIndex = 1
        Me.cmdAsignar.Text = "Asignar"
        '
        'frmAsignarActivo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(848, 542)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.dgActivos_Fijos})
        Me.Name = "frmAsignarActivo"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        CType(Me.dgActivos_Fijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents myDataSet As DataSet

    Dim Activos_Fijos As New VB.SysContab.Activo_FijosDB()
    Dim ds As DataSet

    Dim tCust As DataTable

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub rbAnterior_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbAnterior.Click
        etAnterior.Visible = True
        cbEmpleadoAnterior.Visible = True

    End Sub

    Private Sub rbSeleccionados_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSeleccionados.Click
        etAnterior.Visible = False
        cbEmpleadoAnterior.Visible = False

        ds = Activos_Fijos.GetList("A")

        MakeDataSet()
        ' Bind the DataGrid to the DataSet. The dataMember
        'specifies that the Customers table should be displayed.
        dgActivos_Fijos.SetDataBinding(myDataSet, "EastCoastSales")
        'create and add a custom table style so we can
        'easily get at the behavior of a cell...
        AddCustomDataTableStyle()

    End Sub

    Private Sub frmAsignarActivo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Empleado As New VB.SysContab.EmpleadosDB()
        'Dim Activos_Fijos As New VB.SysContab.Activo_FijosDB()
        Dim r As New VB.SysContab.Rutinas()
        'Dim Tabla As DataTable
        'Dim ds As DataSet

        cbEmpleado.DataSource = Empleado.GetListBuscarCombo("%").Tables("EMPLEADOS")
        cbEmpleado.ValueMember = "Codigo"
        cbEmpleado.DisplayMember = "Nombre"

        cbEmpleadoAnterior.DataSource = Empleado.GetListBuscarCombo("%").Tables("EMPLEADOS")
        cbEmpleadoAnterior.ValueMember = "Codigo"
        cbEmpleadoAnterior.DisplayMember = "Nombre"

        rbSeleccionados.Checked = True

        'r.CambiarEstilo(Me)

        ds = Activos_Fijos.GetList("%")

        'dgActivos_Fijos.DataSource = Activos_Fijos.GetList().Tables("Activo_Fijos").DefaultView
        'Tabla = ds.Tables("Activo_Fijos")

        'r.FormatGenerico(dgActivos_Fijos, Tabla)

        'dgActivos_Fijos.CaptionText = "Activos Fijos"


        MakeDataSet()
        ' Bind the DataGrid to the DataSet. The dataMember
        'specifies that the Customers table should be displayed.
        dgActivos_Fijos.SetDataBinding(myDataSet, "EastCoastSales")
        'create and add a custom table style so we can
        'easily get at the behavior of a cell...
        AddCustomDataTableStyle()

        Me.Text = "Asignar Activos Fijos"
        Me.Refresh()

    End Sub


    Private Sub AddCustomDataTableStyle()

        'STEP 1: Create a DataTable style object and set properties if required.
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle()
        'specify the table from dataset (required step)
        ts1.MappingName = "EastCoastSales"
        ' Set other properties (optional step)
        ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount As Integer
        colCount = 0

        'STEP 3: Create an int column style and add it to the tablestyle
        'this requires setting the format for the column through its property descriptor
        Dim pdc As PropertyDescriptorCollection
        pdc = Me.BindingContext(myDataSet, "EastCoastSales").GetItemProperties
        'now created a formated column using the pdc
        Dim csIDInt As DataGridTextBoxColumn
        csIDInt = New DataGridTextBoxColumn(pdc("Codigo"), "i", True)
        csIDInt.Format = "d3"
        csIDInt.MappingName = "Codigo"
        csIDInt.HeaderText = "Codigo"
        csIDInt.ReadOnly = True
        csIDInt.Width = 100
        ts1.GridColumnStyles.Add(csIDInt)
        colCount = (colCount + 1)
        csIDInt.NullText = ""


        'STEP 2: Create a string column and add it to the tablestyle
        Dim TextCol As DataGridColumnStyle
        TextCol = New DataGridTextBoxColumn()
        TextCol.MappingName = "DESCRIPCION"
        'from dataset table
        TextCol.HeaderText = "DESCRIPCION"
        TextCol.Width = 400
        TextCol.ReadOnly = True
        ts1.GridColumnStyles.Add(TextCol)
        colCount = (colCount + 1)

        TextCol.NullText = ""

        'STEP 4: Add the checkbox
        Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        boolCol.MappingName = "AGREGAR"
        boolCol.HeaderText = "AGREGAR"
        'uncomment this line to get a two-state checkbox
        CType(boolCol, DataGridBoolColumn).AllowNull = False

        boolCol.Width = 100
        boolCol.ReadOnly = False

        boolCol.NullText = ""

        'hook the new event to our handler in the grid
        AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
        ts1.GridColumnStyles.Add(boolCol)
        colCount = (colCount + 1)

        ''STEP 5: Add a second checkbox

        'boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        'boolCol.MappingName = "Current2"
        'boolCol.HeaderText = "Info Current2"
        'CType(boolCol, DataGridBoolColumn).AllowNull = False
        'boolCol.Width = 70
        ''hook the new event to our handler in the grid
        'AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
        'ts1.GridColumnStyles.Add(boolCol)
        'colCount = (colCount + 1)

        'STEP 6: Add the tablestyle to your datagrids tablestlye collection
        dgActivos_Fijos.TableStyles.Clear()
        dgActivos_Fijos.TableStyles.Add(ts1)


    End Sub
    Private Sub MakeDataSet()

        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")


        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust = New DataTable("EastCoastSales")

        ' Create two columns, and add them to the first table.
        Dim cCustID As DataColumn
        cCustID = New DataColumn("Codigo") ', GetType(System.Int32))
        Dim cCustName As DataColumn
        cCustName = New DataColumn("Descripcion")
        Dim cCurrent As DataColumn
        cCurrent = New DataColumn("AGREGAR", GetType(System.Boolean))
        'Dim cCurrent2 As DataColumn
        'cCurrent2 = New DataColumn("Current2", GetType(System.Boolean))
        tCust.Columns.Add(cCustID)
        tCust.Columns.Add(cCustName)
        tCust.Columns.Add(cCurrent)

        'tCust.Columns.Add(cCurrent2)
        ' Add the tables to the DataSet.
        myDataSet.Tables.Add(tCust)

        ' Populates the tables. For each customer and order, 
        'creates two DataRow variables. 
        Dim newRow1 As DataRow
        ' Create three customers in the Customers Table.
        Dim i As Integer
        i = 0

        Do While (i < ds.Tables("Activo_Fijos").Rows.Count)
            newRow1 = tCust.NewRow
            newRow1("Codigo") = ds.Tables("Activo_Fijos").Rows(i).Item("Codigo")
            ' Add the row to the Customers table.
            tCust.Rows.Add(newRow1)
            i = (i + 1)

        Loop
        ' Give each customer a distinct name.

        For i = 0 To ds.Tables("Activo_Fijos").Rows.Count - 1
            tCust.Rows(i)("DESCRIPCION") = ds.Tables("Activo_Fijos").Rows(i).Item("DESCRIPCION")
            tCust.Rows(i)("AGREGAR") = False

        Next

        'myDataSet.Tables("EastCoastSales").DefaultView.AllowDelete = False
        'myDataSet.Tables("EastCoastSales").DefaultView.AllowNew = False
        'myDataSet.Tables("EastCoastSales").DefaultView.AllowEdit = False

        'tCust.DefaultView.AllowDelete = False
        'tCust.DefaultView.AllowEdit = False
        'tCust.DefaultView.AllowNew = False


        'tCust.Rows(0)("custName") = ds.Tables("Activo_Fijos").Rows(0).Item("CODIGO ")
        'tCust.Rows(1)("custName") = ds.Tables("Activo_Fijos").Rows(0).Item("DESCRIPCION")
        'tCust.Rows(2)("custName") = "Omega"
        '' Give the Current column a value.
        'tCust.Rows(0)("Current") = True
        'tCust.Rows(1)("Current") = True
        'tCust.Rows(2)("Current") = False
        'tCust.Rows(0)("Current2") = False
        'tCust.Rows(1)("Current2") = True
        'tCust.Rows(2)("Current2") = False

    End Sub

    Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)

        Dim s As String
        s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
        Console.WriteLine(s)

    End Sub


    Private Sub cmdAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAsignar.Click
        Dim Activo As New VB.SysContab.Activo_FijosDB()
        Dim i As Integer
        Dim Asignar As Integer
        Asignar = 0

        For i = 0 To tCust.Rows.Count - 1
            If tCust.Rows(i)("AGREGAR") = True Then
                If rbSeleccionados.Checked = True Then
                    Activo.AsignarActivo(cbEmpleado.SelectedValue, tCust.Rows(i).Item("Codigo"))
                Else
                    Activo.TrasladarActivo(cbEmpleadoAnterior.SelectedValue, cbEmpleado.SelectedValue, tCust.Rows(i).Item("Codigo"))

                End If

                Asignar = Asignar + 1
            End If

        Next

        If Asignar = 0 Then
            MsgBox("Seleccione los Activos que desea asignar a este empleado", MsgBoxStyle.Information)
            Exit Sub
        Else
            MsgBox("se asignaron " & Asignar & " Activos", MsgBoxStyle.Information)

        End If

        If rbSeleccionados.Checked = True Then
            ds = Activos_Fijos.GetList("A")
        Else
            ds = Activos_Fijos.GetListActivoEmpleado(cbEmpleadoAnterior.SelectedValue)

        End If

        MakeDataSet()
        ' Bind the DataGrid to the DataSet. The dataMember
        'specifies that the Customers table should be displayed.
        dgActivos_Fijos.SetDataBinding(myDataSet, "EastCoastSales")
        'create and add a custom table style so we can
        'easily get at the behavior of a cell...
        AddCustomDataTableStyle()




    End Sub

    Private Sub cbEmpleadoAnterior_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbEmpleadoAnterior.SelectedIndexChanged
        If rbSeleccionados.Checked = False Then
            ds = Activos_Fijos.GetListActivoEmpleado(cbEmpleadoAnterior.SelectedValue.ToString)

            MakeDataSet()
            ' Bind the DataGrid to the DataSet. The dataMember
            'specifies that the Customers table should be displayed.
            dgActivos_Fijos.SetDataBinding(myDataSet, "EastCoastSales")
            'create and add a custom table style so we can
            'easily get at the behavior of a cell...
            AddCustomDataTableStyle()
        End If
    End Sub

    
    
End Class
