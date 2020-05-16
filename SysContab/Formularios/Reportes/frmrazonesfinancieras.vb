Imports System.Data.SqlClient
Imports System.Data
Imports DevExpress.XtraReports.UI

Public Class frmrazonesfinancieras
    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As frmrazonesfinancieras = Nothing

    Public Shared Function Instance() As frmrazonesfinancieras
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmrazonesfinancieras
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnombrerazon As System.Windows.Forms.TextBox
    Friend WithEvents GridDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdnuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdeditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbrazon As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbcuentas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdimprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbano As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdeditar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdguardar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdnuevo = New DevExpress.XtraEditors.SimpleButton
        Me.GridDetail = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtnombrerazon = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbrazon = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbcuentas = New DevExpress.XtraEditors.LookUpEdit
        Me.GridDetalle = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmdimprimir = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmbano = New System.Windows.Forms.ComboBox
        Me.cmbmes = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbcuentas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdeditar)
        Me.GroupBox1.Controls.Add(Me.cmdguardar)
        Me.GroupBox1.Controls.Add(Me.cmdnuevo)
        Me.GroupBox1.Controls.Add(Me.GridDetail)
        Me.GroupBox1.Controls.Add(Me.txtnombrerazon)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 224)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Definir Razones"
        '
        'cmdeditar
        '
        Me.cmdeditar.Location = New System.Drawing.Point(104, 192)
        Me.cmdeditar.Name = "cmdeditar"
        Me.cmdeditar.Size = New System.Drawing.Size(64, 23)
        Me.cmdeditar.TabIndex = 8
        Me.cmdeditar.Text = "&Editar"
        '
        'cmdguardar
        '
        Me.cmdguardar.Location = New System.Drawing.Point(176, 192)
        Me.cmdguardar.Name = "cmdguardar"
        Me.cmdguardar.Size = New System.Drawing.Size(64, 23)
        Me.cmdguardar.TabIndex = 7
        Me.cmdguardar.Text = "&Guardar"
        '
        'cmdnuevo
        '
        Me.cmdnuevo.Location = New System.Drawing.Point(32, 192)
        Me.cmdnuevo.Name = "cmdnuevo"
        Me.cmdnuevo.Size = New System.Drawing.Size(64, 23)
        Me.cmdnuevo.TabIndex = 6
        Me.cmdnuevo.Text = "&Nuevo"
        '
        'GridDetail
        '
        '
        'GridDetail.EmbeddedNavigator
        '
        Me.GridDetail.EmbeddedNavigator.Name = ""
        Me.GridDetail.Location = New System.Drawing.Point(8, 56)
        Me.GridDetail.MainView = Me.GridView1
        Me.GridDetail.Name = "GridDetail"
        Me.GridDetail.Size = New System.Drawing.Size(304, 128)
        Me.GridDetail.TabIndex = 5
        Me.GridDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.GridControl = Me.GridDetail
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsView.ShowGroupPanel = False

        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "No"
        Me.GridColumn1.FieldName = "Tipo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn1.OptionsFilter.AllowFilter = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Nombre"
        Me.GridColumn2.DisplayFormat.FormatString = "D"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "Descripcion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn2.OptionsFilter.AllowFilter = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 120
        '
        'txtnombrerazon
        '
        Me.txtnombrerazon.Location = New System.Drawing.Point(112, 24)
        Me.txtnombrerazon.Name = "txtnombrerazon"
        Me.txtnombrerazon.ReadOnly = True
        Me.txtnombrerazon.Size = New System.Drawing.Size(184, 20)
        Me.txtnombrerazon.TabIndex = 1
        Me.txtnombrerazon.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Razon"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbrazon)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbcuentas)
        Me.GroupBox2.Controls.Add(Me.GridDetalle)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(336, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 296)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grupos por Razon"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(256, 264)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.TabIndex = 6
        Me.cmdsave.Text = "&Actualizar"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cuenta"
        '
        'cmbrazon
        '
        Me.cmbrazon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbrazon.Location = New System.Drawing.Point(104, 32)
        Me.cmbrazon.Name = "cmbrazon"
        Me.cmbrazon.Size = New System.Drawing.Size(232, 21)
        Me.cmbrazon.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre Razon"
        '
        'cmbcuentas
        '
        Me.cmbcuentas.EditValue = "Cuenta"
        Me.cmbcuentas.Location = New System.Drawing.Point(104, 64)
        Me.cmbcuentas.Name = "cmbcuentas"
        '
        'cmbcuentas.Properties
        '
        Me.cmbcuentas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbcuentas.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cuenta", "Cuenta", 50), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 100)})
        Me.cmbcuentas.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
        Me.cmbcuentas.Size = New System.Drawing.Size(232, 20)
        Me.cmbcuentas.TabIndex = 2
        '
        'GridDetalle
        '
        '
        'GridDetalle.EmbeddedNavigator
        '
        Me.GridDetalle.EmbeddedNavigator.Name = ""
        Me.GridDetalle.Location = New System.Drawing.Point(16, 96)
        Me.GridDetalle.MainView = Me.GridView2
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.Size = New System.Drawing.Size(320, 160)
        Me.GridDetalle.TabIndex = 5
        Me.GridDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView2.GridControl = Me.GridDetalle
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsView.ShowGroupPanel = False

        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Cuenta"
        Me.GridColumn3.FieldName = "Cuenta"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn3.OptionsFilter.AllowFilter = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 50
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Nombre"
        Me.GridColumn4.DisplayFormat.FormatString = "D"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "Nombre"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn4.OptionsFilter.AllowFilter = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 120
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tipo"
        Me.GridColumn5.FieldName = "Tipo"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Empresa"
        Me.GridColumn6.FieldName = "Empresa"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'cmdimprimir
        '
        Me.cmdimprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdimprimir.Location = New System.Drawing.Point(248, 24)
        Me.cmdimprimir.Name = "cmdimprimir"
        Me.cmdimprimir.Size = New System.Drawing.Size(64, 23)
        Me.cmdimprimir.TabIndex = 2
        Me.cmdimprimir.Text = "&Imprimir"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbano)
        Me.GroupBox3.Controls.Add(Me.cmbmes)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmdimprimir)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(320, 64)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reporte"
        '
        'cmbano
        '
        Me.cmbano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbano.Location = New System.Drawing.Point(176, 24)
        Me.cmbano.Name = "cmbano"
        Me.cmbano.Size = New System.Drawing.Size(56, 21)
        Me.cmbano.TabIndex = 5
        '
        'cmbmes
        '
        Me.cmbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmes.Location = New System.Drawing.Point(64, 24)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(104, 21)
        Me.cmbmes.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Periodo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Salir"
        '
        'frmrazonesfinancieras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 314)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmrazonesfinancieras"
        Me.Text = "Razones Financieras"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.cmbcuentas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim vista As DevExpress.XtraGrid.Views.Grid.GridView
    Enum Accion
        Nuevo
        Edita
    End Enum
    Dim Ac As Accion
    Dim IdRazon As Integer = 0
    Dim DT As New DataTable
    Dim Carga As Boolean = False


    Private Sub GridDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDetail.DoubleClick
        vista = GridDetail.MainView
        If vista.SelectedRowsCount > 0 Then
            Dim fila As DataRow
            For Each i As Integer In vista.GetSelectedRows
                If i < 0 Then
                    Exit For
                End If
                fila = vista.GetDataRow(i)
                Inicializa()
                txtnombrerazon.Text = fila("Descripcion")
                IdRazon = fila("Tipo")
            Next
        End If
    End Sub

    Private Sub frmrazonesfinancieras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DT.Columns.Add("Tipo", System.Type.GetType("System.Int32"))
            DT.Columns.Add("Empresa", System.Type.GetType("System.Int32"))
            DT.Columns.Add("Cuenta", System.Type.GetType("System.String"))
            DT.Columns.Add("Nombre", System.Type.GetType("System.String"))

            CargaDatos()

            For i As Integer = 1 To 12
                cmbmes.Items.Add(MonthName(i, False))
            Next
            cmbmes.SelectedIndex = 0
            Dim Data As New DataSet
            Data = CreaDatos("SELECT per_inicio,per_final FROM Periodos WHERE Empresa = " & EmpresaActual)
            For i As Integer = 0 To Data.Tables(0).Rows.Count - 1
                For j As Integer = Year(Data.Tables(0).Rows(i).Item(0)) To Year(Data.Tables(0).Rows(i).Item(1))
                    If cmbano.FindString(j) >= 0 Then  Else cmbano.Items.Add(j)
                Next
            Next
            If Data.Tables(0).Rows.Count - 1 >= 0 Then cmbano.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CargaDatos()
        Carga = True
        Dim Data As New DataSet
        Data = CreaDatos("SELECT * FROM RESCUENTASGRUPOSRAZONES")
        GridDetail.DataSource = Data
        GridDetail.DataMember = "Datos"
        cmbrazon.DataSource = Data.Tables("Datos")
        cmbrazon.ValueMember = "Tipo"
        cmbrazon.DisplayMember = "Descripcion"
        Dim DataCuenta As New DataSet
        DataCuenta = CreaDatos("SELECT Cuenta,Nombre FROM Catalogo WHERE Empresa = " & EmpresaActual)
        cmbcuentas.Properties.DataSource = DataCuenta.Tables("Datos")
        cmbcuentas.Properties.ValueMember = "Cuenta"
        cmbcuentas.Properties.DisplayMember = "Nombre"
        cmbcuentas.ItemIndex = 0
        Carga = False
        cmbrazon_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub cmdeditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeditar.Click
        If Trim(txtnombrerazon.Text) = vbNullString And IdRazon = 0 Then Exit Sub
        txtnombrerazon.ReadOnly = False
        txtnombrerazon.Focus()
        txtnombrerazon.SelectAll()
        Ac = Accion.Edita
    End Sub

    Private Sub cmdnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnuevo.Click
        Ac = Accion.Nuevo
        txtnombrerazon.Text = vbNullString
        txtnombrerazon.ReadOnly = False
        txtnombrerazon.Focus()
        IdRazon = 0
    End Sub

    Private Sub cmdguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdguardar.Click
        If Trim(txtnombrerazon.Text) = vbNullString Then Exit Sub
        Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim SQL As New SqlCommand("SPCreaRazonesFinancieras '" & txtnombrerazon.Text & "'," & IIf(Ac = Accion.Edita, IdRazon, 0), DC)
        Try
            DC.Open()
            SQL.ExecuteNonQuery()
            MsgBox("Registro guardado con exito")
            CargaDatos()
            Inicializa()
            IdRazon = 0
        Catch ex As Exception
            MsgBox("Error : " & Err.Description)
        End Try
        DC.Close()
    End Sub

    Private Sub Inicializa()
        txtnombrerazon.Text = vbNullString
        txtnombrerazon.ReadOnly = True
    End Sub

    Private Function CreaDatos(ByVal SQL As String) As DataSet
        Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim DA As New SqlDataAdapter(SQL, DC)
        Dim DS As New DataSet
        DA.Fill(DS, "Datos")
        Return DS
    End Function

    Private Sub cmbcuentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbcuentas.KeyDown
        If e.KeyCode = Keys.Return Then
            Dim DR As DataRow
            With DT
                For i As Integer = 0 To DT.Rows.Count - 1
                    If DT.Rows(i).Item("Empresa") = EmpresaActual And _
                    DT.Rows(i).Item("Cuenta") = cmbcuentas.GetColumnValue("Cuenta") And _
                    DT.Rows(i).Item("Tipo") = cmbrazon.SelectedValue Then
                        MsgBox("Ya ha Seleccionado el Valor")
                        Exit Sub
                    End If
                Next
                DR = .NewRow
                DR.Item("Tipo") = cmbrazon.SelectedValue
                DR.Item("Cuenta") = cmbcuentas.GetColumnValue("Cuenta")
                DR.Item("Nombre") = cmbcuentas.GetColumnValue("Nombre")
                DR.Item("Empresa") = EmpresaActual
                .Rows.Add(DR)
            End With
            GridDetalle.DataSource = DT
            GridDetalle.Refresh()
        End If
    End Sub

    Private Sub GridDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridDetalle.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim fila As DataRow
            vista = GridDetalle.MainView
            If vista.SelectedRowsCount > 0 Then
                For Each j As Integer In vista.GetSelectedRows
                    fila = vista.GetDataRow(j)
                Next
            End If
            For i As Integer = 0 To DT.Rows.Count - 1
                If DT.Rows(i).Item("Empresa") = fila("Empresa") And _
                DT.Rows(i).Item("Cuenta") = fila("Cuenta") And _
                DT.Rows(i).Item("Tipo") = fila("Tipo") Then
                    If EliminaFila(fila("Tipo"), fila("Cuenta"), fila("Empresa")) = False Then
                        MsgBox("Error al eliminar")
                        Exit Sub
                    End If
                    DT.Rows(i).Delete()
                    GridDetalle.DataSource = DT
                    GridDetalle.Refresh()
                    Exit For
                End If
                DT.AcceptChanges()
            Next
        End If
    End Sub

    Private Function EliminaFila(ByVal Tipo, ByVal Cuenta, ByVal Empresa) As Boolean
        Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim SQL As New SqlCommand("SPEliminaRazon '" & Cuenta & "'," & Empresa & "," & Tipo, DC)
        Try
            DC.Open()
            SQL.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        DC.Close()
    End Function

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim fila As DataRow
        vista = GridDetalle.MainView
        If vista.SelectedRowsCount > 0 Then
            Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
            Dim SQL As New SqlCommand
            Try
                DC.Open()
                For j As Integer = 0 To vista.RowCount - 1
                    fila = vista.GetDataRow(j)
                    SQL.Connection = DC
                    SQL.CommandText = "SPGuardaRazon '" & fila("Cuenta") & "'," & fila("Empresa") & "," & fila("Tipo") & ",'" & fila("Nombre") & "'"
                    SQL.ExecuteNonQuery()
                Next
            Catch ex As Exception
                MsgBox("ocurrio un error al guardar intente de nuevo")
            End Try
            DC.Close()
        End If
    End Sub

    Private Sub cmbrazon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbrazon.SelectedIndexChanged
        If Not Carga Then
            Dim Data As New DataSet
            Data = CreaDatos("SELECT * FROM RESCUENTASRAZONESFINANCIERAS WHERE Empresa = " & EmpresaActual & " AND Tipo = " & cmbrazon.SelectedValue)
            If Data.Tables("Datos").Rows.Count >= 0 Then
                DT.Columns.Clear()
            End If
            DT = Data.Tables("Datos")
            GridDetalle.DataSource = DT
            GridDetalle.Refresh()
        End If
    End Sub

    Private Sub cmdimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdimprimir.Click
        Dim Data As New DataSet
        Data = CreaDatos("_CreaRazonesFinancieras " & EmpresaActual & "," & cmbmes.SelectedIndex + 1 & "," & cmbano.Text)
        Dim Rep As New RptRazonesFinan
        Rep.DataSource = Data
        Rep.DataMember = "Datos"
        Rep.ShowRibbonPreview()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub GridDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDetalle.Click

    End Sub
End Class
