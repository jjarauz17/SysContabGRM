Public Class frmProveedoresAdicionales
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
    Friend WithEvents dgProveedores As System.Windows.Forms.DataGrid
    Friend WithEvents etProveedor As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etArticulo As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgProveedores = New System.Windows.Forms.DataGrid
        Me.etProveedor = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.etArticulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgProveedores
        '
        Me.dgProveedores.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgProveedores.BackColor = System.Drawing.Color.Gainsboro
        Me.dgProveedores.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgProveedores.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgProveedores.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgProveedores.CaptionForeColor = System.Drawing.Color.Black
        Me.dgProveedores.DataMember = ""
        Me.dgProveedores.FlatMode = True
        Me.dgProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgProveedores.ForeColor = System.Drawing.Color.Black
        Me.dgProveedores.GridLineColor = System.Drawing.Color.Silver
        Me.dgProveedores.HeaderBackColor = System.Drawing.Color.Black
        Me.dgProveedores.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgProveedores.HeaderForeColor = System.Drawing.Color.White
        Me.dgProveedores.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgProveedores.Location = New System.Drawing.Point(8, 43)
        Me.dgProveedores.Name = "dgProveedores"
        Me.dgProveedores.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgProveedores.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgProveedores.ReadOnly = True
        Me.dgProveedores.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgProveedores.SelectionForeColor = System.Drawing.Color.White
        Me.dgProveedores.Size = New System.Drawing.Size(672, 349)
        Me.dgProveedores.TabIndex = 1
        '
        'etProveedor
        '
        Me.etProveedor.Location = New System.Drawing.Point(104, 112)
        Me.etProveedor.Name = "etProveedor"
        Me.etProveedor.Size = New System.Drawing.Size(100, 25)
        Me.etProveedor.TabIndex = 14
        Me.etProveedor.Text = "Proveedor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 398)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 51)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(288, 17)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Location = New System.Drawing.Point(200, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 26)
        Me.cmdAyuda.TabIndex = 4
        Me.cmdAyuda.Text = "A&yuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(384, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(104, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 26)
        Me.cmdImprimir.TabIndex = 3
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 17)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'etArticulo
        '
        Me.etArticulo.Location = New System.Drawing.Point(104, 146)
        Me.etArticulo.Name = "etArticulo"
        Me.etArticulo.Size = New System.Drawing.Size(100, 25)
        Me.etArticulo.TabIndex = 16
        Me.etArticulo.Text = "Articulo"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(80, 9)
        Me.txtBuscar.MaxLength = 100
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(600, 22)
        Me.txtBuscar.TabIndex = 0
        '
        'frmProveedoresAdicionales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(688, 454)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.etArticulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.etProveedor)
        Me.Controls.Add(Me.dgProveedores)
        Me.Name = "frmProveedoresAdicionales"
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim tCust As DataTable
    Private WithEvents myDataSet As DataSet

    Dim ds As DataSet
    Dim Articulos As New VB.SysContab.ArticulosDB()
    Dim Proveedores As New VB.SysContab.ProveedoresDB()

    Private myCheckBoxCol As Integer = 2 'my checkbox column 

    Private Sub frmProveedoresAdicionales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.etProveedor.Visible = False
        Me.etArticulo.Visible = False
        Me.dgProveedores.Text = "Lista de Proveedores"
        Me.Text = "Lista de Proveedores"
        ds = Proveedores.ProveedoresAdicionalesList(etProveedor.Text, Me.etArticulo.Text, Me.txtBuscar.Text)
        MakeDataSet()
        dgProveedores.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
        Me.txtBuscar.Focus()
        Me.Refresh()
    End Sub

    Private Sub MakeDataSet()
        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")

        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust = New DataTable("Item")

        ' Create two columns, and add them to the first table.
        Dim i As Integer

        Dim cCodigo As DataColumn
        cCodigo = New DataColumn("Codigo")
        tCust.Columns.Add(cCodigo)

        Dim cNombre As DataColumn
        cNombre = New DataColumn("Nombre")
        tCust.Columns.Add(cNombre)

        Dim cAgregar As DataColumn
        cAgregar = New DataColumn("Agregar", GetType(System.Boolean))
        tCust.Columns.Add(cAgregar)

        Dim cAgregar1 As DataColumn
        cAgregar1 = New DataColumn("Agregar1", GetType(System.Boolean))
        tCust.Columns.Add(cAgregar1)

        tCust.DefaultView.AllowDelete = False
        tCust.DefaultView.AllowNew = False
        tCust.DefaultView.AllowEdit = False

        myDataSet.Tables.Add(tCust)

        Dim newRow1 As DataRow

        For i = 0 To ds.Tables("Proveedores").Rows.Count - 1
            newRow1 = tCust.NewRow
            tCust.Rows.Add(newRow1)

            tCust.Rows(i)("Codigo") = ds.Tables("Proveedores").Rows(i).Item("Codigo")
            tCust.Rows(i)("Nombre") = ds.Tables("Proveedores").Rows(i).Item("Nombre")
            tCust.Rows(i)("Agregar") = ds.Tables("Proveedores").Rows(i).Item("Asignado")
            tCust.Rows(i)("Agregar1") = ds.Tables("Proveedores").Rows(i).Item("Asignado")
        Next

        myDataSet.Tables("Item").DefaultView.AllowDelete = False

    End Sub

    Private Sub AddCustomDataTableStyle()

        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle()

        ts1.MappingName = "Item"

        ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount As Integer
        colCount = 0

        Dim Codigo As New DataGridTextBoxColumn()
        Codigo.MappingName = "Codigo"
        Codigo.HeaderText = "Código"
        Codigo.ReadOnly = True
        Codigo.Alignment = HorizontalAlignment.Left
        Codigo.Width = 75
        Codigo.NullText = ""

        ts1.GridColumnStyles.Add(Codigo)
        colCount = (colCount + 1)

        Dim Nombre As New DataGridTextBoxColumn()
        Nombre.MappingName = "Nombre"
        Nombre.HeaderText = "Nombre"
        Nombre.ReadOnly = True
        Nombre.Alignment = HorizontalAlignment.Left
        Nombre.Width = 300
        Nombre.NullText = ""

        ts1.GridColumnStyles.Add(Nombre)
        colCount = (colCount + 1)


        Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        boolCol.MappingName = "Agregar"
        boolCol.HeaderText = "Agregar"
        boolCol.Alignment = HorizontalAlignment.Center

        CType(boolCol, DataGridBoolColumn).AllowNull = False

        boolCol.Width = 65
        boolCol.ReadOnly = False

        boolCol.NullText = ""

        AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
        ts1.GridColumnStyles.Add(boolCol)
        colCount = (colCount + 1)


        Dim boolCol1 As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        boolCol1 = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        boolCol1.MappingName = "Agregar1"
        boolCol1.HeaderText = "Agregar1"
        boolCol1.Alignment = HorizontalAlignment.Center

        CType(boolCol1, DataGridBoolColumn).AllowNull = False

        boolCol1.Width = 0
        boolCol1.ReadOnly = False

        boolCol1.NullText = ""

        AddHandler boolCol1.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)
        ts1.GridColumnStyles.Add(boolCol1)
        colCount = (colCount + 1)


        ts1.AllowSorting = False
        ts1.HeaderFont = Me.dgProveedores.HeaderFont
        ts1.PreferredRowHeight = 25
        'ts1.ReadOnly = True

        myDataSet.Tables("Item").DefaultView.AllowDelete = False
        myDataSet.Tables("Item").DefaultView.AllowNew = False
        myDataSet.Tables("Item").DefaultView.AllowEdit = True

        Me.dgProveedores.TableStyles.Clear()
        Me.dgProveedores.TableStyles.Add(ts1)

    End Sub

    Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
        Dim s As String
        s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
        Console.WriteLine(s)
    End Sub

    Private Sub dgProveedores_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgProveedores.MouseUp


        Dim hti As DataGrid.HitTestInfo = Me.dgProveedores.HitTest(e.X, e.Y)
        Try
            If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
                Me.dgProveedores(hti.Row, hti.Column) = Not CBool(Me.dgProveedores(hti.Row, hti.Column))
            Else
                Exit Sub
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
        End Try


    End Sub 'dataGrid2_MouseUp 

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim i As Integer
        For i = 0 To tCust.Rows.Count - 1
            If tCust.Rows(i)("Agregar") = False And tCust.Rows(i)("Agregar1") = False Then
                'Nada
            ElseIf tCust.Rows(i)("Agregar") = True And tCust.Rows(i)("Agregar1") = True Then
                'Nada
            ElseIf tCust.Rows(i)("Agregar") = True And tCust.Rows(i)("Agregar1") = False Then
                Try
                    Articulos.ProveedoresAdicionalesAddItem(Me.etArticulo.Text, tCust.Rows(i)("Codigo"), "P")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf tCust.Rows(i)("Agregar") = False And tCust.Rows(i)("Agregar1") = True Then
                Try
                    Articulos.ProveedoresAdicionalesDelete(Me.etArticulo.Text, tCust.Rows(i)("Codigo"), "P")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Next

        ds = Proveedores.ProveedoresAdicionalesList(Me.etProveedor.Text, Me.etArticulo.Text, Me.txtBuscar.Text)
        MakeDataSet()
        dgProveedores.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Dim i As Integer
        For i = 0 To tCust.Rows.Count - 1
            tCust.Rows(i)("Agregar") = tCust.Rows(i)("Agregar1")
        Next
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        ds = Proveedores.ProveedoresAdicionalesList(Me.etProveedor.Text, Me.etArticulo.Text, Me.txtBuscar.Text)
        MakeDataSet()
        dgProveedores.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

    End Sub
End Class
