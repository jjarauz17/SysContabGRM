Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class frmTipoPlantillasAgregarVer
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmTipoPlantillasAgregarVer = Nothing

    Public Shared Function Instance() As frmTipoPlantillasAgregarVer
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmTipoPlantillasAgregarVer()
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
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents dgFacturacionCliente As System.Windows.Forms.DataGrid
    Friend WithEvents cbTipoComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbEsquema As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbEsquema = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgFacturacionCliente = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTipo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbTipoComp = New System.Windows.Forms.ComboBox
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbEsquema)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dgFacturacionCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbTipoComp)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 505)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'cbEsquema
        '
        Me.cbEsquema.Location = New System.Drawing.Point(136, 60)
        Me.cbEsquema.Name = "cbEsquema"
        Me.cbEsquema.Size = New System.Drawing.Size(304, 21)
        Me.cbEsquema.TabIndex = 155
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 26)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "Esquema Plantilla"
        '
        'dgFacturacionCliente
        '
        Me.dgFacturacionCliente.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgFacturacionCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.dgFacturacionCliente.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgFacturacionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgFacturacionCliente.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgFacturacionCliente.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturacionCliente.CaptionForeColor = System.Drawing.Color.Black
        Me.dgFacturacionCliente.DataMember = ""
        Me.dgFacturacionCliente.FlatMode = True
        Me.dgFacturacionCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgFacturacionCliente.ForeColor = System.Drawing.Color.Black
        Me.dgFacturacionCliente.GridLineColor = System.Drawing.Color.Silver
        Me.dgFacturacionCliente.HeaderBackColor = System.Drawing.Color.Black
        Me.dgFacturacionCliente.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgFacturacionCliente.HeaderForeColor = System.Drawing.Color.White
        Me.dgFacturacionCliente.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgFacturacionCliente.Location = New System.Drawing.Point(8, 95)
        Me.dgFacturacionCliente.Name = "dgFacturacionCliente"
        Me.dgFacturacionCliente.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgFacturacionCliente.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgFacturacionCliente.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgFacturacionCliente.SelectionForeColor = System.Drawing.Color.White
        Me.dgFacturacionCliente.Size = New System.Drawing.Size(888, 404)
        Me.dgFacturacionCliente.TabIndex = 150
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(88, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipo:"
        '
        'txtTipo
        '
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.Location = New System.Drawing.Point(136, 26)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(304, 20)
        Me.txtTipo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(528, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(592, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(304, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(464, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 26)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Tipo Comprobante:"
        '
        'cbTipoComp
        '
        Me.cbTipoComp.Location = New System.Drawing.Point(592, 60)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Size = New System.Drawing.Size(304, 21)
        Me.cbTipoComp.TabIndex = 154
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(8, 69)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 34)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(8, 17)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 35)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Guardar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(920, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(88, 505)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'frmTipoPlantillasAgregarVer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 526)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTipoPlantillasAgregarVer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Tipo de Plantillas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgFacturacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents myDataSet As DataSet
    Dim WithEvents tCust As DataTable
    Dim WithEvents Cuenta As DataGridTextBoxColumn
    Dim WithEvents Usos As DataGridTextBoxColumn
    Dim WithEvents Catalogo As DataGridTextBoxColumn
    Dim WithEvents DC As DataGridTextBox.DataGridComboBox
    Dim WithEvents Concepto As DataGridTextBox.DataGridComboBox
    Dim WithEvents ConceptoID As DataGridTextBox.DataGridComboBox
    Dim WithEvents Var As DataGridTextBox.DataGridComboBox
    Dim WithEvents VarID As DataGridTextBox.DataGridComboBox
    Dim WithEvents Concepto2 As DataGridTextBox.DataGridComboBox
    Dim WithEvents ConceptoID2 As DataGridTextBox.DataGridComboBox
    Dim WithEvents Var2 As DataGridTextBox.DataGridComboBox
    Dim WithEvents VarID2 As DataGridTextBox.DataGridComboBox
    Dim WithEvents Concepto3 As DataGridTextBox.DataGridComboBox
    Dim WithEvents ConceptoID3 As DataGridTextBox.DataGridComboBox
    Dim WithEvents Var3 As DataGridTextBox.DataGridComboBox
    Dim WithEvents VarID3 As DataGridTextBox.DataGridComboBox
    Dim WithEvents Concepto4 As DataGridTextBox.DataGridComboBox
    Dim WithEvents ConceptoID4 As DataGridTextBox.DataGridComboBox
    Dim WithEvents Var4 As DataGridTextBox.DataGridComboBox
    Dim WithEvents VarID4 As DataGridTextBox.DataGridComboBox
    Dim CatalogoDB As New VB.SysContab.CatalogoDB()
    Dim ConceptoDB As New VB.SysContab.ConceptosDB()
    Dim Plantilla As New VB.SysContab.PlantillaDB()
    Dim VariablesDB As New VB.SysContab.VariablesDB()
    Dim Comprobantes As New VB.SysContab.ComprobanteDB()
    Dim ds As DataSet
    Dim i As Integer

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim r As New VB.SysContab.Rutinas()
        Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(Registro)
        Dim Valor As String

        If Validar() = True Then

            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()


            Valor = Plantilla.UpDateTipoPlantilla(Detalles.TipoPlantilla, txtTipo.Text, txtNombre.Text, cbTipoComp.SelectedValue)


            If Valor = 1 Then

                Try

                    For i = 0 To tCust.Rows.Count - 1

                        Dim DC As String
                        Dim Opera As Integer

                        If tCust.Rows(i)("DC").ToString = "Débito" Then
                            DC = "D"
                            Opera = 1
                        End If

                        If tCust.Rows(i)("DC").ToString = "Crédito" Then
                            DC = "C"
                            Opera = 2
                        End If

                        Plantilla.UpDateAddTipoPlantilla(txtTipo.Text, txtNombre.Text, tCust.Rows(i)("Cuenta").ToString, tCust.Rows(i)("Uso").ToString, Opera, _
                                                    tCust.Rows(i)("ConceptoID").ToString, tCust.Rows(i)("VarID").ToString, _
                                                    tCust.Rows(i)("ConceptoID2").ToString, tCust.Rows(i)("VarID2").ToString, _
                                                    tCust.Rows(i)("ConceptoID3").ToString, tCust.Rows(i)("VarID3").ToString, _
                                                    tCust.Rows(i)("ConceptoID4").ToString, tCust.Rows(i)("VarID4").ToString)

                    Next
                    VB.SysContab.Rutinas.okTransaccion()
                    XtraMsg("El registro se ha grabado correctamente")
                    If frmTipoPlantillas.Created Then frmTipoPlantillas.Cargar()
                    Me.Close()

                Catch Mensaje As Exception
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    MsgBox(Mensaje.Message)
                    Exit Sub

                Finally

                End Try

            End If

        End If



    End Sub

    Private Sub frmAgregarZona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Detalles As VB.SysContab.PlantillaDetails = Plantilla.GetPlantillasDetails(Registro)
        Me.txtNombre.Text = Detalles.NombrePlantilla
        Me.txtTipo.Text = Detalles.TipoPlantilla

        cbTipoComp.DataSource = Comprobantes.GetTiposComprobantes(0).Tables("TipoComprobantes")
        cbTipoComp.ValueMember = "TipComp_Id"
        cbTipoComp.DisplayMember = "TipComp_Nombre"


        cbEsquema.DataSource = Plantilla.GetListPlantillasContables().Tables("Tablas")
        cbEsquema.ValueMember = "Pla_Id"
        cbEsquema.DisplayMember = "Pla_Nombre"


        cbTipoComp.SelectedValue = Detalles.TipoCompr

        cbEsquema.SelectedValue = Detalles.PlaID


        ds = Detalles.Detalles

        dgFacturacionCliente.ReadOnly = True

        MakeDataSet()

        dgFacturacionCliente.SetDataBinding(myDataSet, "Plantillas")
        AddCustomDataTableStyle()


        Me.Refresh()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub


    Private Sub MakeDataSet()
        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")

        ' Create two DataTables.
        'Dim tCust As DataTable
        tCust = New DataTable("Plantillas")

        ' Create two columns, and add them to the first table.

        Dim cCuenta As DataColumn
        cCuenta = New DataColumn("Cuenta")

        Dim cCatalogo As DataColumn
        cCatalogo = New DataColumn("Catalogo")

        Dim cUso As DataColumn
        cUso = New DataColumn("Uso")

        Dim cDC As DataColumn
        cDC = New DataColumn("DC")

        Dim cConcepto As DataColumn
        cConcepto = New DataColumn("Concepto")

        Dim cConceptoID As DataColumn
        cConceptoID = New DataColumn("ConceptoID")

        Dim cVar As DataColumn
        cVar = New DataColumn("Var")

        Dim cVarID As DataColumn
        cVarID = New DataColumn("VarID")

        Dim cConcepto2 As DataColumn
        cConcepto2 = New DataColumn("Concepto2")

        Dim cConceptoID2 As DataColumn
        cConceptoID2 = New DataColumn("ConceptoID2")

        Dim cVar2 As DataColumn
        cVar2 = New DataColumn("Var2")

        Dim cVarID2 As DataColumn
        cVarID2 = New DataColumn("VarID2")

        Dim cConcepto3 As DataColumn
        cConcepto3 = New DataColumn("Concepto3")

        Dim cConceptoID3 As DataColumn
        cConceptoID3 = New DataColumn("ConceptoID3")

        Dim cVar3 As DataColumn
        cVar3 = New DataColumn("Var3")

        Dim cVarID3 As DataColumn
        cVarID3 = New DataColumn("VarID3")

        Dim cConcepto4 As DataColumn
        cConcepto4 = New DataColumn("Concepto4")

        Dim cConceptoID4 As DataColumn
        cConceptoID4 = New DataColumn("ConceptoID4")

        Dim cVar4 As DataColumn
        cVar4 = New DataColumn("Var4")

        Dim cVarID4 As DataColumn
        cVarID4 = New DataColumn("VarID4")


        tCust.Columns.Add(cCuenta)
        tCust.Columns.Add(cCatalogo)
        tCust.Columns.Add(cUso)
        tCust.Columns.Add(cDC)
        tCust.Columns.Add(cConcepto)
        tCust.Columns.Add(cConceptoID)
        tCust.Columns.Add(cVar)
        tCust.Columns.Add(cVarID)
        tCust.Columns.Add(cConcepto2)
        tCust.Columns.Add(cConceptoID2)
        tCust.Columns.Add(cVar2)
        tCust.Columns.Add(cVarID2)
        tCust.Columns.Add(cConcepto3)
        tCust.Columns.Add(cConceptoID3)
        tCust.Columns.Add(cVar3)
        tCust.Columns.Add(cVarID3)
        tCust.Columns.Add(cConcepto4)
        tCust.Columns.Add(cConceptoID4)
        tCust.Columns.Add(cVar4)
        tCust.Columns.Add(cVarID4)

        myDataSet.Tables.Add(tCust)

        Dim newRow1 As DataRow

        Dim j As Integer

        For j = 0 To ds.Tables("PlantillasDetalles").Rows.Count - 1
            newRow1 = tCust.NewRow
            newRow1("Cuenta") = ds.Tables("PlantillasDetalles").Rows(j).Item("Cuenta")
            tCust.Rows.Add(newRow1)

            tCust.Rows(j)("Cuenta") = ds.Tables("PlantillasDetalles").Rows(j).Item("Cuenta")
            tCust.Rows(j)("Catalogo") = ds.Tables("PlantillasDetalles").Rows(j).Item("Catalogo")
            tCust.Rows(j)("Uso") = ds.Tables("PlantillasDetalles").Rows(j).Item("Etiqueta")

            If ds.Tables("PlantillasDetalles").Rows(j).Item("Débito") = 1 Then
                tCust.Rows(j)("DC") = "Débito"
            Else
                tCust.Rows(j)("DC") = "Crédito"
            End If

            tCust.Rows(j)("Concepto") = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto")
            tCust.Rows(j)("ConceptoID") = ds.Tables("PlantillasDetalles").Rows(j).Item("ConceptoID")
            tCust.Rows(j)("Var") = ds.Tables("PlantillasDetalles").Rows(j).Item("Var")
            tCust.Rows(j)("VarID") = ds.Tables("PlantillasDetalles").Rows(j).Item("VarID")

            tCust.Rows(j)("Concepto2") = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto2")
            tCust.Rows(j)("ConceptoID2") = ds.Tables("PlantillasDetalles").Rows(j).Item("ConceptoID2")
            tCust.Rows(j)("Var2") = ds.Tables("PlantillasDetalles").Rows(j).Item("Var2")
            tCust.Rows(j)("VarID2") = ds.Tables("PlantillasDetalles").Rows(j).Item("VarID2")

            tCust.Rows(j)("Concepto3") = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto3")
            tCust.Rows(j)("ConceptoID3") = ds.Tables("PlantillasDetalles").Rows(j).Item("ConceptoID3")
            tCust.Rows(j)("Var3") = ds.Tables("PlantillasDetalles").Rows(j).Item("Var3")
            tCust.Rows(j)("VarID3") = ds.Tables("PlantillasDetalles").Rows(j).Item("VarID3")

            tCust.Rows(j)("Concepto4") = ds.Tables("PlantillasDetalles").Rows(j).Item("Concepto4")
            tCust.Rows(j)("ConceptoID4") = ds.Tables("PlantillasDetalles").Rows(j).Item("ConceptoID4")
            tCust.Rows(j)("Var4") = ds.Tables("PlantillasDetalles").Rows(j).Item("Var4")
            tCust.Rows(j)("VarID4") = ds.Tables("PlantillasDetalles").Rows(j).Item("VarID4")

        Next

    End Sub



    Private Sub AddCustomDataTableStyle()

        Dim dsItems As DataSet
        dsItems = ConceptoDB.GetListar()

        Dim dsVariables As DataSet
        dsVariables = VariablesDB.GetList()

        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle()
        ts1.MappingName = "Plantillas"
        ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount As Integer
        colCount = 0

        ' Cuenta
        Cuenta = New DataGridTextBoxColumn()
        Cuenta.MappingName = "Cuenta"
        Cuenta.HeaderText = "Cuenta"
        Cuenta.Width = 100
        Cuenta.ReadOnly = False
        ts1.GridColumnStyles.Add(Cuenta)
        ts1.PreferredRowHeight = (Cuenta.TextBox.Height + 3)
        Cuenta.NullText = ""
        colCount = (colCount + 1)
        AddHandler Cuenta.TextBox.DoubleClick, New EventHandler(AddressOf ObtieneDato)

        ' CATALOGO
        Catalogo = New DataGridTextBoxColumn()
        Catalogo.MappingName = "Catalogo"
        Catalogo.HeaderText = "Catalogo"
        Catalogo.Width = 200
        Catalogo.ReadOnly = True
        ts1.GridColumnStyles.Add(Catalogo)
        ts1.PreferredRowHeight = (Catalogo.TextBox.Height + 3)
        Catalogo.NullText = ""
        colCount = (colCount + 1)


        ' Etiqueta
        Usos = New DataGridTextBoxColumn()
        Usos.MappingName = "Uso"
        Usos.HeaderText = "Etiqueta"
        Usos.Width = 200
        Usos.ReadOnly = False
        ts1.GridColumnStyles.Add(Usos)
        ts1.PreferredRowHeight = (Usos.TextBox.Height + 3)
        Usos.NullText = ""
        colCount = (colCount + 1)



        ' DEBITO / CREDITO --- 0 / 1 
        DC = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboCredito))
        DC.MappingName = "DC"
        DC.HeaderText = "Débito/Crédito"
        DC.Width = 150
        DC.Alignment = HorizontalAlignment.Center
        DC.ReadOnly = True
        DC.ColumnComboBox.Items.Add("Débito")
        DC.ColumnComboBox.Items.Add("Crédito")

        ts1.GridColumnStyles.Add(DC)
        colCount = (colCount + 1)
        DC.NullText = "-Seleccione-"


        'CONCEPTO ID 
        ConceptoID = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto))
        ConceptoID.MappingName = "ConceptoID"
        ConceptoID.Width = 0
        ts1.GridColumnStyles.Add(ConceptoID)
        ts1.PreferredRowHeight = (ConceptoID.ColumnComboBox.Height + 3)
        ConceptoID.NullText = ""
        colCount = (colCount + 1)



        ' CONCEPTO
        Concepto = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto))
        Concepto.MappingName = "Concepto"
        Concepto.HeaderText = "Concepto"
        Concepto.Width = 200
        Concepto.ReadOnly = True
        ts1.GridColumnStyles.Add(Concepto)
        ts1.PreferredRowHeight = (Concepto.TextBox.Height + 3)
        Concepto.NullText = "-Seleccione Concepto-"

        For i = 0 To dsItems.Tables("Conceptos").Rows.Count - 1
            ConceptoID.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Codigo"))
            Concepto.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Nombre"))
        Next
        colCount = (colCount + 1)


        'Variables ID 
        VarID = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar))
        VarID.MappingName = "VarID"
        VarID.Width = 0
        ts1.GridColumnStyles.Add(VarID)
        ts1.PreferredRowHeight = (VarID.ColumnComboBox.Height + 3)
        VarID.NullText = ""
        colCount = (colCount + 1)

        ' Variables
        Var = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar))
        Var.MappingName = "Var"
        Var.HeaderText = "Variable1"
        Var.Width = 200
        Var.ReadOnly = True
        ts1.GridColumnStyles.Add(Var)
        ts1.PreferredRowHeight = (Var.TextBox.Height + 3)
        Var.NullText = "-Seleccione Variable-"
        For i = 0 To dsVariables.Tables("Variables").Rows.Count - 1
            VarID.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_ID"))
            Var.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_Nombre"))
        Next
        colCount = (colCount + 1)



        'CONCEPTO ID 2
        ConceptoID2 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto2))
        ConceptoID2.MappingName = "ConceptoID2"
        ConceptoID2.Width = 0
        ts1.GridColumnStyles.Add(ConceptoID2)
        ts1.PreferredRowHeight = (ConceptoID2.ColumnComboBox.Height + 3)
        ConceptoID2.NullText = ""
        colCount = (colCount + 1)



        ' CONCEPTO 2
        Concepto2 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto2))
        Concepto2.MappingName = "Concepto2"
        Concepto2.HeaderText = "Concepto2"
        Concepto2.Width = 200
        Concepto2.ReadOnly = True
        ts1.GridColumnStyles.Add(Concepto2)
        ts1.PreferredRowHeight = (Concepto2.TextBox.Height + 3)
        Concepto2.NullText = "-Seleccione Concepto-"
        For i = 0 To dsItems.Tables("Conceptos").Rows.Count - 1
            ConceptoID2.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Codigo"))
            Concepto2.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Nombre"))
        Next
        colCount = (colCount + 1)


        'Variables ID2 
        VarID2 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar2))
        VarID2.MappingName = "VarID2"
        VarID2.Width = 0
        ts1.GridColumnStyles.Add(VarID2)
        ts1.PreferredRowHeight = (VarID2.ColumnComboBox.Height + 3)
        VarID2.NullText = ""
        colCount = (colCount + 1)

        ' Variables2
        Var2 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar2))
        Var2.MappingName = "Var2"
        Var2.HeaderText = "Variable2"
        Var2.Width = 200
        Var2.ReadOnly = True
        ts1.GridColumnStyles.Add(Var2)
        ts1.PreferredRowHeight = (Var2.TextBox.Height + 3)
        Var2.NullText = "-Seleccione Variable-"
        For i = 0 To dsVariables.Tables("Variables").Rows.Count - 1
            VarID2.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_ID"))
            Var2.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_Nombre"))
        Next
        colCount = (colCount + 1)



        'CONCEPTO ID 3
        ConceptoID3 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto3))
        ConceptoID3.MappingName = "ConceptoID3"
        ConceptoID3.Width = 0
        ts1.GridColumnStyles.Add(ConceptoID3)
        ts1.PreferredRowHeight = (ConceptoID3.ColumnComboBox.Height + 3)
        ConceptoID3.NullText = ""
        colCount = (colCount + 1)



        ' CONCEPTO 3
        Concepto3 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto3))
        Concepto3.MappingName = "Concepto3"
        Concepto3.HeaderText = "Concepto3"
        Concepto3.Width = 200
        Concepto3.ReadOnly = True
        ts1.GridColumnStyles.Add(Concepto3)
        ts1.PreferredRowHeight = (Concepto3.TextBox.Height + 3)
        Concepto3.NullText = "-Seleccione Concepto-"
        For i = 0 To dsItems.Tables("Conceptos").Rows.Count - 1
            ConceptoID3.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Codigo"))
            Concepto3.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Nombre"))
        Next
        colCount = (colCount + 1)


        'Variables ID3 
        VarID3 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar3))
        VarID3.MappingName = "VarID3"
        VarID3.Width = 0
        ts1.GridColumnStyles.Add(VarID3)
        ts1.PreferredRowHeight = (VarID3.ColumnComboBox.Height + 3)
        VarID3.NullText = ""
        colCount = (colCount + 1)

        ' Variables3
        Var3 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar3))
        Var3.MappingName = "Var3"
        Var3.HeaderText = "Variable3"
        Var3.Width = 200
        Var3.ReadOnly = True
        ts1.GridColumnStyles.Add(Var3)
        ts1.PreferredRowHeight = (Var3.TextBox.Height + 3)
        Var3.NullText = "-Seleccione Variable-"
        For i = 0 To dsVariables.Tables("Variables").Rows.Count - 1
            VarID3.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_ID"))
            Var3.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_Nombre"))
        Next
        colCount = (colCount + 1)



        'CONCEPTO ID 4
        ConceptoID4 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto4))
        ConceptoID4.MappingName = "ConceptoID4"
        ConceptoID4.Width = 0
        ts1.GridColumnStyles.Add(ConceptoID4)
        ts1.PreferredRowHeight = (ConceptoID4.ColumnComboBox.Height + 3)
        ConceptoID4.NullText = ""
        colCount = (colCount + 1)



        ' CONCEPTO 4
        Concepto4 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboConcepto4))
        Concepto4.MappingName = "Concepto4"
        Concepto4.HeaderText = "Concepto4"
        Concepto4.Width = 200
        Concepto4.ReadOnly = True
        ts1.GridColumnStyles.Add(Concepto4)
        ts1.PreferredRowHeight = (Concepto4.TextBox.Height + 3)
        Concepto4.NullText = "-Seleccione Concepto-"
        For i = 0 To dsItems.Tables("Conceptos").Rows.Count - 1
            ConceptoID4.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Codigo"))
            Concepto4.ColumnComboBox.Items.Add(dsItems.Tables("Conceptos").Rows(i).Item("Nombre"))
        Next
        colCount = (colCount + 1)


        'Variables ID4
        VarID4 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar4))
        VarID4.MappingName = "VarID4"
        VarID4.Width = 0
        ts1.GridColumnStyles.Add(VarID4)
        ts1.PreferredRowHeight = (VarID4.ColumnComboBox.Height + 3)
        VarID4.NullText = ""
        colCount = (colCount + 1)

        ' Variables4
        Var4 = New DataGridTextBox.DataGridComboBox(New DataGridTextBox.ComboValueChanged(AddressOf MyComboVar4))
        Var4.MappingName = "Var4"
        Var4.HeaderText = "Variable4"
        Var4.Width = 200
        Var4.ReadOnly = True
        ts1.GridColumnStyles.Add(Var4)
        ts1.PreferredRowHeight = (Var4.TextBox.Height + 3)
        Var4.NullText = "-Seleccione Variable-"
        For i = 0 To dsVariables.Tables("Variables").Rows.Count - 1
            VarID4.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_ID"))
            Var4.ColumnComboBox.Items.Add(dsVariables.Tables("Variables").Rows(i).Item("Var_Nombre"))
        Next
        colCount = (colCount + 1)


        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'STEP 6: Add the tablestyle to your datagrids tablestlye collection

        ts1.AllowSorting = False
        ts1.HeaderFont = dgFacturacionCliente.HeaderFont
        dgFacturacionCliente.CaptionVisible = False
        dgFacturacionCliente.TableStyles.Clear()
        dgFacturacionCliente.TableStyles.Add(ts1)

    End Sub


    Public Sub MyComboCredito(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("DC") = DC.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("DC") = DC.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboValueChanged")
        End Try
    End Sub



    Private Sub ObtieneDato(ByVal sender As Object, ByVal e As EventArgs)
        Dim F As New frmCuentasAsignar()
        F.ShowDialog()

        If tCust.Rows.Count < Me.dgFacturacionCliente.CurrentRowIndex + 1 Then
            Dim newRow1 As DataRow
            newRow1 = tCust.NewRow
            tCust.Rows.Add(newRow1)
            newRow1("Cuenta") = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            newRow1("Catalogo") = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        Else
            tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Cuenta") = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 0)
            tCust.Rows(Me.dgFacturacionCliente.CurrentRowIndex)("Catalogo") = F.dgCatalogo.Item(F.dgCatalogo.CurrentRowIndex, 1)
        End If
    End Sub


    Private Sub Evento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F3 Then
            ObtieneDato(sender, e)
        ElseIf e.KeyCode = Keys.Enter Then
        End If
    End Sub


    Private Function Validar() As Boolean
        Dim Credito As Integer = 0
        Dim Debito As Integer = 0
        Dim MontActivo As Double = 0
        Dim MontPasivo As Double = 0

        If Trim(txtTipo.Text) = "" Then
            MsgBox("Introduzca el Tipo de Plantilla", MsgBoxStyle.Information)
            txtTipo.Focus()
            txtTipo.SelectAll()
            Return False
            Exit Function
        End If

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el Nombre de Plantilla", MsgBoxStyle.Information)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Return False
            Exit Function
        End If

        If tCust.Rows.Count = 0 Then
            MsgBox("Debe ingresar una cuenta a la Plantilla", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If


        For i = 0 To tCust.Rows.Count - 1

            'CODIGO
            If tCust.Rows(i)("Cuenta").ToString = "" Or tCust.Rows(i)("Cuenta") Is DBNull.Value Or tCust.Rows(i)("Cuenta").ToString = "" Or tCust.Rows(i)("Cuenta") Is DBNull.Value Then
                MsgBox("Presione F3 para seleccionar una Cuenta del Catalogo", MsgBoxStyle.Critical)
                dgFacturacionCliente.Select(i)
                Return False
                Exit Function
            End If

            ' Etiqueta
            If tCust.Rows(i)("Uso").ToString = "" Or tCust.Rows(i)("Uso") Is DBNull.Value Or tCust.Rows(i)("Uso").ToString = "" Or tCust.Rows(i)("Uso") Is DBNull.Value Then
                MsgBox("Escriba una etiqueta para la cuenta.", MsgBoxStyle.Critical)
                dgFacturacionCliente.Select(i)
                Return False
                Exit Function
            End If

            ' DEBITO  / CREDITO
            If tCust.Rows(i)("DC").ToString = "" Or tCust.Rows(i)("DC") Is DBNull.Value Or tCust.Rows(i)("DC").ToString = "" Or tCust.Rows(i)("DC") Is DBNull.Value Then
                MsgBox("Seleccione la acción a aplicar a la cuenta: Crédito / Dédito", MsgBoxStyle.Critical)
                dgFacturacionCliente.Select(i)
                Return False
                Exit Function
            Else
                ' Una operacion de C / D

                ' ACT 

                If tCust.Rows(i)("DC").ToString = "Débito" Then
                    Debito = Debito + 1
                End If


                If tCust.Rows(i)("DC").ToString = "Crédito" Then
                    Credito = Credito + 1
                End If
            End If

            ''' CONCEPTO 1
            ''If (tCust.Rows(i)("ConceptoID").ToString = "" Or tCust.Rows(i)("ConceptoID") Is DBNull.Value Or tCust.Rows(i)("ConceptoID").ToString = "" Or tCust.Rows(i)("ConceptoID") Is DBNull.Value) And _
            ''   (tCust.Rows(i)("VarID").ToString = "" Or tCust.Rows(i)("VarID") Is DBNull.Value Or tCust.Rows(i)("VarID").ToString = "" Or tCust.Rows(i)("VarID") Is DBNull.Value) Then
            ''    MsgBox("Debe seleccionar un Concepto y una Variable.", MsgBoxStyle.Critical)
            ''    dgFacturacionCliente.Select(i)
            ''    Return False
            ''    Exit Function
            ''End If

        Next

        If Debito = 0 And tCust.Rows.Count > 0 Then
            MsgBox("Debe haber al menos una operación de Débito", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If
        If Credito = 0 And tCust.Rows.Count > 0 Then
            MsgBox("Debe haber al menos una operación de Crédito", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If

        Return True
    End Function



    Public Sub MyComboConcepto(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("ConceptoID") = ConceptoID.ColumnComboBox.Items.Item(Indice)
                    newRow1("Concepto") = Concepto.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("ConceptoID") = ConceptoID.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Concepto") = Concepto.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboCredito")
        End Try
    End Sub


    Public Sub MyComboVar(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("VarID") = VarID.ColumnComboBox.Items.Item(Indice)
                    newRow1("Var") = Var.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("VarID") = VarID.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Var") = Var.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboVar")
        End Try
    End Sub


    Public Sub MyComboConcepto2(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("ConceptoID2") = ConceptoID2.ColumnComboBox.Items.Item(Indice)
                    newRow1("Concepto2") = Concepto2.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("ConceptoID2") = ConceptoID2.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Concepto2") = Concepto2.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboConcepto2")
        End Try
    End Sub


    Public Sub MyComboVar2(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("VarID2") = VarID2.ColumnComboBox.Items.Item(Indice)
                    newRow1("Var2") = Var2.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("VarID2") = VarID2.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Var2") = Var2.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboVar2")
        End Try
    End Sub


    Public Sub MyComboConcepto3(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("ConceptoID3") = ConceptoID3.ColumnComboBox.Items.Item(Indice)
                    newRow1("Concepto3") = Concepto3.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("ConceptoID3") = ConceptoID3.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Concepto3") = Concepto3.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboConcepto3")
        End Try
    End Sub


    Public Sub MyComboVar3(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("VarID3") = VarID3.ColumnComboBox.Items.Item(Indice)
                    newRow1("Var3") = Var3.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("VarID3") = VarID3.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Var3") = Var3.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboVar3")
        End Try
    End Sub


    Public Sub MyComboConcepto4(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("ConceptoID4") = ConceptoID4.ColumnComboBox.Items.Item(Indice)
                    newRow1("Concepto4") = Concepto4.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("ConceptoID4") = ConceptoID4.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Concepto4") = Concepto4.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboConcepto2")
        End Try
    End Sub


    Public Sub MyComboVar4(ByVal rowChanging As Integer, ByVal newValue As Object)
        Try
            If Indice >= 0 Then

                If tCust.Rows.Count < rowChanging + 1 Then
                    Dim newRow1 As DataRow
                    newRow1 = tCust.NewRow
                    tCust.Rows.Add(newRow1)
                    newRow1("VarID4") = VarID4.ColumnComboBox.Items.Item(Indice)
                    newRow1("Var4") = Var4.ColumnComboBox.Items.Item(Indice)
                Else
                    tCust.Rows(rowChanging)("VarID4") = VarID4.ColumnComboBox.Items.Item(Indice)
                    tCust.Rows(rowChanging)("Var4") = Var4.ColumnComboBox.Items.Item(Indice)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message & "MyComboVar4")
        End Try
    End Sub






End Class
