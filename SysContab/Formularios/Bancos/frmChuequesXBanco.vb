Imports System.Data.SqlClient

Public Class frmChuequesXBanco
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmChuequesXBanco = Nothing

    Public Shared Function Instance() As frmChuequesXBanco
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmChuequesXBanco()
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
    Friend WithEvents etBanco As System.Windows.Forms.Label
    Friend WithEvents etTotal As System.Windows.Forms.Label
    Friend WithEvents etTotalT As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgDepositos = New System.Windows.Forms.DataGrid()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.etBanco = New System.Windows.Forms.Label()
        Me.etDescripcion = New System.Windows.Forms.Label()
        Me.etTotal = New System.Windows.Forms.Label()
        Me.etTotalT = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgDepositos})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 440)
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
        Me.dgDepositos.Size = New System.Drawing.Size(736, 424)
        Me.dgDepositos.TabIndex = 12
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(8, 408)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancelar.TabIndex = 25
        Me.cmdCancelar.Text = "Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdCancelar})
        Me.GroupBox2.Location = New System.Drawing.Point(768, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(88, 440)
        Me.GroupBox2.TabIndex = 154
        Me.GroupBox2.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.GroupBox7.Controls.AddRange(New System.Windows.Forms.Control() {Me.etBanco, Me.etDescripcion})
        Me.GroupBox7.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(848, 32)
        Me.GroupBox7.TabIndex = 155
        Me.GroupBox7.TabStop = False
        '
        'etBanco
        '
        Me.etBanco.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.etBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etBanco.ForeColor = System.Drawing.Color.White
        Me.etBanco.Location = New System.Drawing.Point(160, 8)
        Me.etBanco.Name = "etBanco"
        Me.etBanco.Size = New System.Drawing.Size(688, 20)
        Me.etBanco.TabIndex = 114
        Me.etBanco.Text = "NOMBRE DEL BANCO"
        Me.etBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etDescripcion
        '
        Me.etDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(102, Byte), CType(153, Byte), CType(153, Byte))
        Me.etDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etDescripcion.ForeColor = System.Drawing.Color.White
        Me.etDescripcion.Location = New System.Drawing.Point(0, 8)
        Me.etDescripcion.Name = "etDescripcion"
        Me.etDescripcion.Size = New System.Drawing.Size(160, 20)
        Me.etDescripcion.TabIndex = 113
        Me.etDescripcion.Text = "CHEQUES POR BANCO:"
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
        'frmChuequesXBanco
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(928, 526)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.etTotal, Me.etTotalT, Me.GroupBox7, Me.GroupBox2, Me.GroupBox1})
        Me.Name = "frmChuequesXBanco"
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

    Private myCheckBoxCol As Integer = 5 'my checkbox column 

    Dim r As New VB.SysContab.Rutinas()

    Dim i As Integer
    Dim k As Integer

    Dim Fecha As String
    Dim Inicio As Boolean

    Dim newRow1 As DataRow

    Dim Total As Double

    Private Sub frmAsignarDepositos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VB.SysContab.Rutinas.CambiarEstilo(Me)
        r.FormularioColor(Me)

        Fecha = FechaCobro

        Total = 0

        ds = Clientes.ChequesXBanco(Banco, Fecha, 1, 1)
        BancoDetalle = Bancos.GetDetails(Banco)

        etBanco.Text = BancoDetalle.Nombre & "     Fecha: " & Fecha
        etBanco.BackColor = Color.FromArgb(102, 153, 153)

        dgDepositos.CaptionText = ""
        etDescripcion.BackColor = Color.FromArgb(102, 153, 153)

        MakeDataSet()
        dgDepositos.SetDataBinding(myDataSet, "Item")
        AddCustomDataTableStyle()
        
        dgDepositos.Text = "Detalle de Cheques por Banco"

        dgDepositos.ReadOnly = True

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
        Cheque.HeaderText = "Cheque"
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

        'Dim boolCol As DataGridCheckBoxChangeEvent.MyDataGridBoolColumn
        'boolCol = New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn(colCount)
        'boolCol.MappingName = "Agregar"
        'boolCol.HeaderText = "Agregar"
        'boolCol.Alignment = HorizontalAlignment.Center

        'CType(boolCol, DataGridBoolColumn).AllowNull = False

        'boolCol.Width = 70
        'boolCol.ReadOnly = False

        'boolCol.NullText = ""


        'AddHandler boolCol.BoolValueChanged, New DataGridCheckBoxChangeEvent.MyDataGridBoolColumn.BoolValueChangedEventHandler(AddressOf HandleBoolChanges)

        'ts1.GridColumnStyles.Add(boolCol)
        'colCount = (colCount + 1)

        ts1.AllowSorting = False
        ts1.PreferredRowHeight = 25

        myDataSet.Tables("Item").DefaultView.AllowDelete = False
        myDataSet.Tables("Item").DefaultView.AllowNew = False
        myDataSet.Tables("Item").DefaultView.AllowEdit = False

        dgDepositos.TableStyles.Clear()
        dgDepositos.TableStyles.Add(ts1)



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

        'Dim cAgregar As DataColumn
        'cAgregar = New DataColumn("Agregar", GetType(System.Boolean))
        'tCust.Columns.Add(cAgregar)

        tCust.DefaultView.AllowDelete = False
        tCust.DefaultView.AllowNew = False
        tCust.DefaultView.AllowEdit = False

        myDataSet.Tables.Add(tCust)

        Dim newRow1 As DataRow

        For i = 0 To ds.Tables("Cobros").Rows.Count - 1
            newRow1 = tCust.NewRow
            tCust.Rows.Add(newRow1)

            tCust.Rows(i)("Linea") = i + 1
            tCust.Rows(i)("Numero") = ds.Tables("Cobros").Rows(i).Item("Numero")
            tCust.Rows(i)("Cheque") = ds.Tables("Cobros").Rows(i).Item("No Cheque")
            tCust.Rows(i)("Banco") = ds.Tables("Cobros").Rows(i).Item("Banco")
            tCust.Rows(i)("MontoCheque") = CDbl(ds.Tables("Cobros").Rows(i).Item("Monto")).ToString(Round)
            tCust.Rows(i)("Fecha") = ds.Tables("Cobros").Rows(i).Item("Fecha")
            'etTotal.Text = CDbl(etTotal.Text + tCust.Rows(i)("MontoCheque")).ToString(Round)
            Total = Total + tCust.Rows(i)("MontoCheque")
        Next

        etTotal.Text = Total.ToString(Round)
        myDataSet.Tables("Item").DefaultView.AllowDelete = False
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdVerDepositos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As frmDepositosList = f.Instance
        f.MdiParent = Me.MdiParent
        f.Show()
        f.WindowState = FormWindowState.Maximized

    End Sub

End Class
