Imports System.Data.SqlClient

Public Class frmArqueo
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmArqueo = Nothing

    Public Shared Function Instance() As frmArqueo
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmArqueo()
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
    Friend WithEvents dgDepositos As System.Windows.Forms.DataGrid
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents etDescripcion As System.Windows.Forms.Label
    Friend WithEvents etTotal As System.Windows.Forms.Label
    Friend WithEvents etTotalT As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkNoArqueados As System.Windows.Forms.CheckBox
    Friend WithEvents chkArqueados As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgDepositos = New System.Windows.Forms.DataGrid()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.etTotal = New System.Windows.Forms.Label()
        Me.etTotalT = New System.Windows.Forms.Label()
        Me.chkNoArqueados = New System.Windows.Forms.CheckBox()
        Me.chkArqueados = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgDepositos})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 416)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'dgDepositos
        '
        Me.dgDepositos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgDepositos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgDepositos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgDepositos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgDepositos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgDepositos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgDepositos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgDepositos.DataMember = ""
        Me.dgDepositos.FlatMode = True
        Me.dgDepositos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDepositos.ForeColor = System.Drawing.Color.Black
        Me.dgDepositos.GridLineColor = System.Drawing.Color.Silver
        Me.dgDepositos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgDepositos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgDepositos.HeaderForeColor = System.Drawing.Color.White
        Me.dgDepositos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDepositos.Location = New System.Drawing.Point(8, 8)
        Me.dgDepositos.Name = "dgDepositos"
        Me.dgDepositos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgDepositos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgDepositos.ReadOnly = True
        Me.dgDepositos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgDepositos.SelectionForeColor = System.Drawing.Color.White
        Me.dgDepositos.Size = New System.Drawing.Size(736, 400)
        Me.dgDepositos.TabIndex = 12
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(8, 376)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 25
        Me.cmdCancelar.Text = "Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdAceptar, Me.cmdCancelar})
        Me.GroupBox2.Location = New System.Drawing.Point(768, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(88, 416)
        Me.GroupBox2.TabIndex = 154
        Me.GroupBox2.TabStop = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 16)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 24)
        Me.cmdAceptar.TabIndex = 26
        Me.cmdAceptar.Text = "Guardar"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox7.Controls.AddRange(New System.Windows.Forms.Control() {Me.etDescripcion})
        Me.GroupBox7.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(848, 32)
        Me.GroupBox7.TabIndex = 155
        Me.GroupBox7.TabStop = False
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(0, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(848, 20)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.Text = "ARQUEO DE CAJA"
        Me.etDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etTotal
        '
        Me.etTotal.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.etTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotal.ForeColor = System.Drawing.Color.Maroon
        Me.etTotal.Location = New System.Drawing.Point(360, 480)
        Me.etTotal.Name = "etTotal"
        Me.etTotal.Size = New System.Drawing.Size(176, 32)
        Me.etTotal.TabIndex = 157
        Me.etTotal.Text = "0.00"
        Me.etTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etTotalT
        '
        Me.etTotalT.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.etTotalT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etTotalT.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.etTotalT.Location = New System.Drawing.Point(296, 488)
        Me.etTotalT.Name = "etTotalT"
        Me.etTotalT.Size = New System.Drawing.Size(56, 24)
        Me.etTotalT.TabIndex = 156
        Me.etTotalT.Text = "Total:"
        Me.etTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkNoArqueados
        '
        Me.chkNoArqueados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoArqueados.Location = New System.Drawing.Point(256, 40)
        Me.chkNoArqueados.Name = "chkNoArqueados"
        Me.chkNoArqueados.Size = New System.Drawing.Size(120, 24)
        Me.chkNoArqueados.TabIndex = 25
        Me.chkNoArqueados.Text = "Sin Arquear"
        '
        'chkArqueados
        '
        Me.chkArqueados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArqueados.Location = New System.Drawing.Point(128, 40)
        Me.chkArqueados.Name = "chkArqueados"
        Me.chkArqueados.Size = New System.Drawing.Size(120, 24)
        Me.chkArqueados.TabIndex = 24
        Me.chkArqueados.Text = "Arqueados"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Presentación:"
        '
        'chkTodos
        '
        Me.chkTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodos.Location = New System.Drawing.Point(384, 40)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(120, 24)
        Me.chkTodos.TabIndex = 158
        Me.chkTodos.Text = "Todos"
        '
        'frmArqueo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(928, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkTodos, Me.etTotal, Me.etTotalT, Me.GroupBox7, Me.GroupBox2, Me.GroupBox1, Me.chkNoArqueados, Me.Label5, Me.chkArqueados})
        Me.Name = "frmArqueo"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Depositos As New VB.SysContab.DepositosDB()
    Dim Bancos As New VB.SysContab.BancosDB()
    Dim Clientes As New VB.SysContab.ClientesDB()

    Dim BancoDetalle As New VB.SysContab.BancosDetails()

    Private WithEvents myDataSet As DataSet
    Dim tCust As DataTable

    Dim MontoAsignar As New DataGridTextBoxColumn()

    Dim ValorActualMonto As Double
    Dim ds As DataSet

    Private myCheckBoxCol As Integer = 6 'my checkbox column 

    Dim r As New VB.SysContab.Rutinas()

    Dim i As Integer
    Dim k As Integer

    Public Fecha As Date
    Dim Inicio As Boolean

    Dim newRow1 As DataRow

    Dim Total As Double

    Dim Tipo As Integer
    Public Arqueo As Integer

    Private Sub frmAsignarDepositos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Tabla As DataTable
        'r.CambiarEstilo(Me)
        r.FormularioColor(Me)

        'Fecha = FechaCobro

        Tipo = 1
        'Arqueo = 1

        ds = Clientes.ChequesXBanco(0, Fecha, Arqueo, Tipo)
        'BancoDetalle = Bancos.GetDetails(Banco)

        etDescripcion.Text = "Arqueo de Caja:   " & Arqueo & "-" & Fecha
        etDescripcion.BackColor = Color.FromArgb(102, 153, 153)
        dgDepositos.CaptionText = "Ingresos por Cheques y Efectivo"

        MakeDataSet()
        dgDepositos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()

        'dgDepositos.Text = "Lista de Cheques"

        dgDepositos.ReadOnly = True
        Me.chkArqueados.Checked = True

        Me.Refresh()

    End Sub

    Private Sub AddCustomDataTableStyle()

        'STEP 1: Create a DataTable style object and set properties if required.
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle()
        'specify the table from dataset (required step)
        ts1.MappingName = "Item"
        ' Set other properties (optional step)
        ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount As Integer
        colCount = 0

        Dim Linea As New DataGridTextBoxColumn()
        Linea.MappingName = "Linea"
        Linea.HeaderText = ""
        Linea.ReadOnly = True
        Linea.Alignment = HorizontalAlignment.Left
        Linea.Width = 30
        Linea.NullText = ""

        ts1.GridColumnStyles.Add(Linea)
        colCount = (colCount + 1)

        Dim Numero As New DataGridTextBoxColumn()
        Numero.MappingName = "Numero"
        Numero.HeaderText = "Numero"
        Numero.ReadOnly = True
        Numero.Alignment = HorizontalAlignment.Left
        Numero.Width = 0
        Numero.NullText = ""

        ts1.GridColumnStyles.Add(Numero)
        colCount = (colCount + 1)

        Dim Cheque As New DataGridTextBoxColumn()
        Cheque.MappingName = "Cheque"
        Cheque.HeaderText = "No. Cheque"
        Cheque.ReadOnly = True
        Cheque.Alignment = HorizontalAlignment.Left
        Cheque.Width = 75
        Cheque.NullText = ""

        ts1.GridColumnStyles.Add(Cheque)
        colCount = (colCount + 1)

        Dim Banco As New DataGridTextBoxColumn()
        Banco.MappingName = "Banco"
        Banco.HeaderText = "Banco"
        Banco.ReadOnly = True
        Banco.Alignment = HorizontalAlignment.Left
        Banco.Width = 300
        Banco.NullText = ""

        ts1.GridColumnStyles.Add(Banco)
        colCount = (colCount + 1)

        Dim MontoCheque As New DataGridTextBoxColumn()
        MontoCheque.MappingName = "MontoCheque"
        MontoCheque.HeaderText = "Monto"
        MontoCheque.ReadOnly = True
        MontoCheque.Alignment = HorizontalAlignment.Right
        MontoCheque.Width = 100
        MontoCheque.NullText = ""

        ts1.GridColumnStyles.Add(MontoCheque)
        colCount = (colCount + 1)

        Dim Fecha As New DataGridTextBoxColumn()
        Fecha.MappingName = "Fecha"
        Fecha.HeaderText = "Fecha"
        Fecha.ReadOnly = True
        Fecha.Alignment = HorizontalAlignment.Left
        Fecha.Width = 80
        Fecha.NullText = ""

        ts1.GridColumnStyles.Add(Fecha)
        colCount = (colCount + 1)

        Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        boolCol.MappingName = "Agregar"
        boolCol.HeaderText = "Arqueado"
        boolCol.Alignment = HorizontalAlignment.Center

        CType(boolCol, DataGridBoolColumn).AllowNull = False

        boolCol.Width = 70
        boolCol.ReadOnly = False

        boolCol.NullText = ""


        AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)

        ts1.GridColumnStyles.Add(boolCol)
        colCount = (colCount + 1)

        ts1.AllowSorting = False
        ts1.GridLineColor = Color.FromArgb(70, 130, 180)
        ts1.HeaderFont = Me.dgDepositos.HeaderFont
        ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
        ts1.PreferredRowHeight = 25

        myDataSet.Tables("Item").DefaultView.AllowDelete = False
        myDataSet.Tables("Item").DefaultView.AllowNew = False
        myDataSet.Tables("Item").DefaultView.AllowEdit = False

        dgDepositos.TableStyles.Clear()
        dgDepositos.TableStyles.Add(ts1)

    End Sub

    Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)
        Dim s As String
        s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
        Console.WriteLine(s)
    End Sub

    Private Sub MakeDataSet()
        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")

        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust = New DataTable("Item")

        Dim cLinea As DataColumn
        cLinea = New DataColumn("Linea")
        tCust.Columns.Add(cLinea)

        Dim cNumero As DataColumn
        cNumero = New DataColumn("Numero")
        tCust.Columns.Add(cNumero)

        Dim cCheque As DataColumn
        cCheque = New DataColumn("Cheque")
        tCust.Columns.Add(cCheque)

        Dim cBanco As DataColumn
        cBanco = New DataColumn("Banco")
        tCust.Columns.Add(cBanco)

        Dim cMontoCheque As DataColumn
        cMontoCheque = New DataColumn("MontoCheque")
        tCust.Columns.Add(cMontoCheque)

        Dim cFecha As DataColumn
        cFecha = New DataColumn("Fecha")
        tCust.Columns.Add(cFecha)

        Dim cAgregar As DataColumn
        cAgregar = New DataColumn("Agregar", GetType(System.Boolean))
        tCust.Columns.Add(cAgregar)

        tCust.DefaultView.AllowDelete = False
        tCust.DefaultView.AllowNew = False
        tCust.DefaultView.AllowEdit = False

        myDataSet.Tables.Add(tCust)

        Dim newRow1 As DataRow
        Total = 0
        For i = 0 To ds.Tables("Cobros").Rows.Count - 1
            newRow1 = tCust.NewRow
            tCust.Rows.Add(newRow1)

            tCust.Rows(i)("Linea") = i + 1
            tCust.Rows(i)("Numero") = ds.Tables("Cobros").Rows(i).Item("Numero")
            tCust.Rows(i)("Cheque") = ds.Tables("Cobros").Rows(i).Item("No Cheque")
            tCust.Rows(i)("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
            tCust.Rows(i)("MontoCheque") = CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)
            tCust.Rows(i)("Fecha") = ds.Tables("Cobros").Rows(i).Item("Fecha")

            tCust.Rows(i)("Agregar") = ds.Tables("Cobros").Rows(i).Item("Arqueado")

            If Tipo = 2 Then
                If ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 6 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 7 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 8 Then
                    Total = Total + tCust.Rows(i)("MontoCheque")
                End If
            Else
                If ds.Tables("Cobros").Rows(i).Item("Orden") = 2 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 4 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 5 Then
                    Total = Total + tCust.Rows(i)("MontoCheque")
                End If
            End If

        Next

        etTotal.Text = Total.ToString(Round)
        myDataSet.Tables("Item").DefaultView.AllowDelete = False
    End Sub

    Private Sub dgDepositos_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgDepositos.MouseUp
        'If rbCheques.Checked = True Then
        '    myCheckBoxCol = 6 'my checkbox column 
        'Else
        '    If Resumido = 1 Then
        '        myCheckBoxCol = 2
        '    Else
        '        myCheckBoxCol = 6
        '    End If

        'End If

        Dim hti As DataGrid.HitTestInfo = Me.dgDepositos.HitTest(e.X, e.Y)
        Try
            If hti.Type = DataGrid.HitTestType.Cell AndAlso hti.Column = myCheckBoxCol Then
                If Tipo <> 2 Then
                    If ds.Tables("Cobros").Rows(dgDepositos.CurrentRowIndex).Item("Orden") = 2 Then
                        'tCust.Rows(dgDepositos.CurrentRowIndex)("Agregar") = False
                        Me.dgDepositos(dgDepositos.CurrentRowIndex, hti.Column) = False
                        Exit Sub
                    End If
                Else
                    If ds.Tables("Cobros").Rows(dgDepositos.CurrentRowIndex).Item("Orden") = 3 Then
                        'tCust.Rows(dgDepositos.CurrentRowIndex)("Agregar") = False
                        Me.dgDepositos(dgDepositos.CurrentRowIndex, hti.Column) = False
                        Exit Sub
                    End If
                End If

                Me.dgDepositos(hti.Row, hti.Column) = Not CBool(Me.dgDepositos(hti.Row, hti.Column))
            End If
        Catch ex As Exception
        End Try

        'If dgDepositos.CurrentRowIndex <> 0 And hti.Column = myCheckBoxCol Then
        '    If tCust.Rows(0)("Agregar") = True Then
        '        For i = 1 To tCust.Rows.Count - 1
        '            If tCust.Rows(i)("Agregar") = False Then
        '                tCust.Rows(0)("Agregar") = False
        '            End If
        '        Next
        '    ElseIf tCust.Rows(0)("Agregar") = False Then
        '        For i = 1 To tCust.Rows.Count - 1
        '            If tCust.Rows(i)("Agregar") = False Then
        '                Exit For
        '            End If
        '        Next
        '        If i = tCust.Rows.Count Then
        '            tCust.Rows(0)("Agregar") = True
        '        End If
        '    End If
        '    'Me.dgDepositos(0, hti.Column) = False 'Not CBool(Me.dgDepositos(0, hti.Column))
        'End If

        'If dgDepositos.CurrentRowIndex = 0 And tCust.Rows(0)("Agregar") = True And hti.Column = myCheckBoxCol Then
        '    For i = 1 To tCust.Rows.Count - 1
        '        tCust.Rows(i)("Agregar") = True
        '    Next
        'ElseIf dgDepositos.CurrentRowIndex = 0 And tCust.Rows(0)("Agregar") = False And hti.Column = myCheckBoxCol Then
        '    For i = 1 To tCust.Rows.Count - 1
        '        tCust.Rows(i)("Agregar") = False
        '    Next
        'End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        'Dim Cantidad As Integer
        Try
            'Cantidad = 0
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            For i = 0 To tCust.Rows.Count - 1
                If tCust.Rows(i)("Agregar") = True Then
                    If Tipo = 2 Then
                        If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 2 Then
                            Clientes.ArqueosDetallesDelete(Arqueo, tCust.Rows(i)("Numero"))
                            Clientes.ArqueosDetallesAdd(Arqueo, Fecha, tCust.Rows(i)("Numero"))
                            ''''''Clientes.CobrosUpdateArqueoCheque(tCust.Rows(i)("Numero"), 1)
                        ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 4 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 5 Then
                            Clientes.ArqueosDetallesEfectivoDelete(Arqueo, Fecha)
                            Clientes.ArqueosDetallesEfectivoAdd(Arqueo, Fecha)
                            '''''Clientes.CobrosUpdateArqueoEfectivo(1, Fecha)
                        End If
                    Else
                        If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Then
                            Clientes.ArqueosDetallesDelete(Arqueo, tCust.Rows(i)("Numero"))
                            Clientes.ArqueosDetallesAdd(Arqueo, Fecha, tCust.Rows(i)("Numero"))
                            ''''''Clientes.CobrosUpdateArqueoCheque(tCust.Rows(i)("Numero"), 1)
                        ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Then
                            Clientes.ArqueosDetallesEfectivoDelete(Arqueo, Fecha)
                            Clientes.ArqueosDetallesEfectivoAdd(Arqueo, Fecha)
                            '''''Clientes.CobrosUpdateArqueoEfectivo(1, Fecha)
                        End If

                    End If
                Else
                    If Tipo = 2 Then
                        If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 2 Then
                            Clientes.ArqueosDetallesDelete(Arqueo, tCust.Rows(i)("Numero"))
                        ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 4 Or ds.Tables("Cobros").Rows(i).Item("Orden") = 5 Then
                            Clientes.ArqueosDetallesEfectivoDelete(Arqueo, Fecha)
                        End If
                    Else
                        If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Then
                            Clientes.ArqueosDetallesDelete(Arqueo, tCust.Rows(i)("Numero"))
                        ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Then
                            Clientes.ArqueosDetallesEfectivoDelete(Arqueo, Fecha)
                        End If

                        'Else

                    End If

                    'If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Then
                    '    Clientes.ArqueosDetallesAdd(ArqueoNumero, tCust.Rows(i)("Numero"))
                    'ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Then
                    '    Clientes.ArqueosDetallesEfectivoAdd(ArqueoNumero, Fecha)
                    'End If
                    'Cantidad = 1
                    'Else
                    '    If ds.Tables("Cobros").Rows(i).Item("Orden") = 1 Then
                    '        '''''Clientes.CobrosUpdateArqueoCheque(tCust.Rows(i)("Numero"), 0)
                    '    ElseIf ds.Tables("Cobros").Rows(i).Item("Orden") = 3 Then
                    '        ''''''Clientes.CobrosUpdateArqueoEfectivo(0, Fecha)
                    '    End If

                End If
            Next

            'If Cantidad = 0 Then
            '    MsgBox("Debe seleccionar al menos un registro", MsgBoxStyle.Information)
            '    VB.SysContab.Rutinas.ErrorTransaccion()
            '    Exit Sub
            'End If

            VB.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox(ex.Message & "Aceptar")
            Exit Sub
        End Try

        ds = Clientes.ChequesXBanco(0, Fecha, Arqueo, Tipo)

        MakeDataSet()
        dgDepositos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
    End Sub

    Private Sub chkArqueados_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkArqueados.CheckedChanged
        If chkArqueados.Checked = True Then
            Tipo = 1
            Me.chkNoArqueados.Checked = False
            Me.chkTodos.Checked = False

            ds = Clientes.ChequesXBanco(0, Fecha, Arqueo, Tipo)
            MakeDataSet()
            dgDepositos.SetDataBinding(myDataSet, "Item")
            AddCustomDataTableStyle()
        ElseIf chkArqueados.Checked = False And Me.chkTodos.Checked = False Then
            Me.chkNoArqueados.Checked = True
            Tipo = 0

            ds = Clientes.ChequesXBanco(0, Fecha, Arqueo, Tipo)
            MakeDataSet()
            dgDepositos.SetDataBinding(myDataSet, "Item")
            AddCustomDataTableStyle()
        End If
    End Sub

    Private Sub chkNoArqueados_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNoArqueados.CheckedChanged
        If chkNoArqueados.Checked = True Then
            Tipo = 0
            Me.chkArqueados.Checked = False
            Me.chkTodos.Checked = False

            ds = Clientes.ChequesXBanco(0, Fecha, Arqueo, Tipo)
            MakeDataSet()
            dgDepositos.SetDataBinding(myDataSet, "Item")
            AddCustomDataTableStyle()
        ElseIf chkNoArqueados.Checked = False And Me.chkTodos.Checked = False Then
            Tipo = 1
            Me.chkArqueados.Checked = True
            ds = Clientes.ChequesXBanco(0, Fecha, Arqueo, Tipo)
            MakeDataSet()
            dgDepositos.SetDataBinding(myDataSet, "Item")
            AddCustomDataTableStyle()
        End If
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If chkTodos.Checked = True Then
            Tipo = 2
            Me.chkArqueados.Checked = False
            Me.chkNoArqueados.Checked = False

            ds = Clientes.ChequesXBanco(0, Fecha, Arqueo, Tipo)
            MakeDataSet()
            dgDepositos.SetDataBinding(myDataSet, "Item")
            AddCustomDataTableStyle()
        ElseIf chkTodos.Checked = False And Me.chkNoArqueados.Checked = False Then
            Tipo = 1
            Me.chkArqueados.Checked = True

            ds = Clientes.ChequesXBanco(0, Fecha, Arqueo, Tipo)
            MakeDataSet()
            dgDepositos.SetDataBinding(myDataSet, "Item")
            AddCustomDataTableStyle()
        End If
    End Sub

End Class
