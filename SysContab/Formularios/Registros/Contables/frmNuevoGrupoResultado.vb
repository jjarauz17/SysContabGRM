Imports System.Text.RegularExpressions

Public Class frmNuevoGrupoResultado
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmNuevoGrupoResultado = Nothing

    Public Shared Function Instance() As frmNuevoGrupoResultado
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmNuevoGrupoResultado()
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDe As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNivel As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents cbnivel As System.Windows.Forms.ComboBox
    Friend WithEvents cbOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFactor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmdAbajo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdArriba As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgNiveles As DevExpress.XtraGrid.GridControl
    Friend WithEvents Vista As DevExpress.XtraGrid.Views.Grid.GridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFactor = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbOperacion = New System.Windows.Forms.ComboBox
        Me.cbnivel = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTotalDe = New System.Windows.Forms.TextBox
        Me.txtNivel = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.CmdAbajo = New DevExpress.XtraEditors.SimpleButton
        Me.cmdArriba = New DevExpress.XtraEditors.SimpleButton
        Me.dgNiveles = New DevExpress.XtraGrid.GridControl
        Me.Vista = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgNiveles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtFactor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbOperacion)
        Me.GroupBox1.Controls.Add(Me.cbnivel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTotalDe)
        Me.GroupBox1.Controls.Add(Me.txtNivel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 181)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(200, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 26)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Factor:"
        '
        'txtFactor
        '
        Me.txtFactor.Enabled = False
        Me.txtFactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactor.Location = New System.Drawing.Point(288, 146)
        Me.txtFactor.Name = "txtFactor"
        Me.txtFactor.Size = New System.Drawing.Size(80, 20)
        Me.txtFactor.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(16, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 26)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Operación:"
        '
        'cbOperacion
        '
        Me.cbOperacion.Enabled = False
        Me.cbOperacion.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.cbOperacion.Location = New System.Drawing.Point(96, 146)
        Me.cbOperacion.Name = "cbOperacion"
        Me.cbOperacion.Size = New System.Drawing.Size(80, 21)
        Me.cbOperacion.TabIndex = 18
        '
        'cbnivel
        '
        Me.cbnivel.Items.AddRange(New Object() {"FORMULA", "NIVEL 1", "NIVEL 2", "NIVEL 3"})
        Me.cbnivel.Location = New System.Drawing.Point(224, 78)
        Me.cbnivel.Name = "cbnivel"
        Me.cbnivel.Size = New System.Drawing.Size(160, 21)
        Me.cbnivel.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(96, 9)
        Me.txtCodigo.MaxLength = 6
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total de:"
        '
        'txtTotalDe
        '
        Me.txtTotalDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDe.Location = New System.Drawing.Point(96, 112)
        Me.txtTotalDe.Name = "txtTotalDe"
        Me.txtTotalDe.Size = New System.Drawing.Size(344, 20)
        Me.txtTotalDe.TabIndex = 3
        '
        'txtNivel
        '
        Me.txtNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivel.Location = New System.Drawing.Point(296, 9)
        Me.txtNivel.MaxLength = 1
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(40, 20)
        Me.txtNivel.TabIndex = 2
        Me.txtNivel.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nivel de Cuentas en Informe:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(96, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(344, 20)
        Me.txtNombre.TabIndex = 1
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(432, 479)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Salir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(352, 479)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        '
        'CmdAbajo
        '
        Me.CmdAbajo.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAbajo.Appearance.Options.UseFont = True
        Me.CmdAbajo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdAbajo.Location = New System.Drawing.Point(512, 250)
        Me.CmdAbajo.Name = "CmdAbajo"
        Me.CmdAbajo.Size = New System.Drawing.Size(44, 26)
        Me.CmdAbajo.TabIndex = 10
        Me.CmdAbajo.Text = "Abajo"
        '
        'cmdArriba
        '
        Me.cmdArriba.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdArriba.Appearance.Options.UseFont = True
        Me.cmdArriba.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdArriba.Location = New System.Drawing.Point(512, 215)
        Me.cmdArriba.Name = "cmdArriba"
        Me.cmdArriba.Size = New System.Drawing.Size(44, 26)
        Me.cmdArriba.TabIndex = 9
        Me.cmdArriba.Text = "Arriba"
        '
        'dgNiveles
        '
        Me.dgNiveles.Location = New System.Drawing.Point(16, 215)
        Me.dgNiveles.MainView = Me.Vista
        Me.dgNiveles.Name = "dgNiveles"
        Me.dgNiveles.Size = New System.Drawing.Size(488, 257)
        Me.dgNiveles.TabIndex = 8
        Me.dgNiveles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Vista})
        '
        'Vista
        '
        Me.Vista.GridControl = Me.dgNiveles
        Me.Vista.Name = "Vista"
        Me.Vista.OptionsCustomization.AllowColumnMoving = False
        Me.Vista.OptionsCustomization.AllowColumnResizing = False
        Me.Vista.OptionsCustomization.AllowFilter = False
        Me.Vista.OptionsCustomization.AllowGroup = False
        Me.Vista.OptionsCustomization.AllowSort = False
        Me.Vista.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Vista.OptionsView.ShowGroupPanel = False
        '
        'frmNuevoGrupoResultado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(856, 517)
        Me.Controls.Add(Me.CmdAbajo)
        Me.Controls.Add(Me.cmdArriba)
        Me.Controls.Add(Me.dgNiveles)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Name = "frmNuevoGrupoResultado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgNiveles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim Detalle As Integer = 0
    Dim Detalles As New VB.SysContab.GruposDetails
#End Region

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim grupos As New VB.SysContab.GruposDB
        Dim r As New VB.SysContab.Rutinas

        If Trim(txtCodigo.Text) = "" Then
            MsgBox("Introduzca el Código del Grupo", MsgBoxStyle.Information)
            txtCodigo.Focus()
            txtCodigo.SelectAll()
            Exit Sub

        End If

        If Trim(txtNombre.Text) = "" Then
            MsgBox("Introduzca el Nombre del Grupo", MsgBoxStyle.Information)
            txtNombre.Focus()
            txtNombre.SelectAll()
            Exit Sub

        End If

        If Trim(txtNivel.Text) = "" Then
            MsgBox("Introduzca el Nivel del Grupo", MsgBoxStyle.Information)
            txtNivel.Focus()
            txtNivel.SelectAll()
            Exit Sub

        End If

        If IsNumeric(txtNivel.Text) Then
            'OK
        Else
            MsgBox("El Nivel del Grupo debe ser un Número", MsgBoxStyle.Information)
            txtNivel.Focus()
            txtNivel.SelectAll()
            Exit Sub

        End If

        If Me.cbnivel.SelectedIndex = 0 Then
            If Me.txtTotalDe.Text = "" Then 'se limpio la formula
                MsgBox("Para los grupos de tipo formula debe ingresar los grupos que la conforman, separados por comas.", MsgBoxStyle.Information, "STS-Contab")
                Exit Sub
            End If
        Else
            If Me.txtTotalDe.Text <> "" Then
                MsgBox("Para los grupos que no son de tipo formula, el campo Total De debe ir en blanco.", MsgBoxStyle.Information, "STS-Contab")
                Exit Sub
            End If
        End If

        'grupos.AddItem(txtCodigo.Text, txtNombre.Text, txtNivel.Text, txtTotalDe.Text, "R")

        If Nuevo = "SI" Then
            grupos.AddItem(txtCodigo.Text, txtNombre.Text, Me.cbnivel.SelectedIndex, txtTotalDe.Text, "R", Me.cbOperacion.Text, Me.txtFactor.Text)
            'MsgBox("El registro se ha grabado correctamente", MsgBoxStyle.Information)

            r.LimpiarControles(GroupBox1)
            Me.cbnivel.SelectedIndex = 1
            Me.cbOperacion.SelectedIndex = 2
            Me.txtFactor.Text = "1.00"
            Me.txtNivel.Text = Me.cbnivel.SelectedIndex.ToString
            Me.Refresh()
            txtCodigo.Focus()

        Else
            grupos.Update(txtCodigo.Text, txtNombre.Text, Me.cbnivel.SelectedIndex, txtTotalDe.Text, "R", Me.cbOperacion.Text, Me.txtFactor.Text)
            'MsgBox("El registro se ha actualizado correctamente", MsgBoxStyle.Information)

        End If

        If Nuevo = "NO" Then
            'Actualizar los ordenes
            Dim i As Integer = 0
            For i = 0 To Me.Vista.DataRowCount - 1
                'If Detalle = Me.Vista.GetRowCellValue(i, "Nivel") Then
                grupos.Update_Orden(Me.Vista.GetRowCellValue(i, "Codigo"), "R", Me.Vista.GetRowCellValue(i, "Orden"), Me.Vista.GetRowCellValue(i, "Detalle"))
                'End If

            Next
        Else
            Try
                Detalle = ObtieneDatos("Select isnull(max(Orden),0) + 1  from grupos where empresa = " & EmpresaActual & " and tipo = 'R' and Nivel = " & Me.cbnivel.SelectedIndex).Rows(0)(0)
                grupos.Update_Orden(Me.txtCodigo.Text, "R", Detalle, True)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub cmdArriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdArriba.Click
        If Me.Vista.GetFocusedRowCellValue("Nivel") < Detalles.Nivel Then
            Exit Sub
        End If
        If Me.Vista.FocusedRowHandle = 0 Then
            Exit Sub
        End If
        Dim O1, O2 As Integer
        O1 = Me.Vista.GetRowCellValue(Me.Vista.FocusedRowHandle - 1, "Orden")
        O2 = Me.Vista.GetRowCellValue(Me.Vista.FocusedRowHandle, "Orden")
        Me.Vista.SetRowCellValue(Me.Vista.FocusedRowHandle - 1, "Orden", O2)
        Me.Vista.SetRowCellValue(Me.Vista.FocusedRowHandle, "Orden", O1)
        'Me.Vista.RefreshData()
        Me.Vista.Columns("Orden").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

    End Sub

    Private Sub CmdAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAbajo.Click
        If Me.Vista.GetFocusedRowCellValue("Nivel") < Detalles.Nivel Then
            Exit Sub
        End If
        If Me.Vista.FocusedRowHandle = Me.Vista.DataRowCount - 1 Then
            Exit Sub
        End If
        Dim O1, O2 As Integer

        O1 = Me.Vista.GetRowCellValue(Me.Vista.FocusedRowHandle, "Orden")
        O2 = Me.Vista.GetRowCellValue(Me.Vista.FocusedRowHandle + 1, "Orden")

        Me.Vista.SetRowCellValue(Me.Vista.FocusedRowHandle + 1, "Orden", O1)
        Me.Vista.SetRowCellValue(Me.Vista.FocusedRowHandle, "Orden", O2)
        'Me.Vista.RefreshData()
        Me.Vista.Columns("Orden").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmNuevoGrupoResultado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As New VB.SysContab.Rutinas
        Dim grupos As New VB.SysContab.GruposDB


        If Nuevo = "NO" Then
            Me.Text = "Editar Grupo de Resultado"
            Detalles = grupos.GetDetails(Registro, TipoGrupo)
            txtCodigo.ReadOnly = True
            Me.txtCodigo.Text = Detalles.Codigo
            Me.txtNombre.Text = Detalles.Nombre
            Me.txtNivel.Text = Detalles.Nivel
            Me.txtTotalDe.Text = Detalles.Total
            Me.cbnivel.SelectedIndex = Detalles.Nivel
            Me.txtFactor.Text = Detalles.Factor
            Me.cbOperacion.SelectedItem = Detalles.Operacion

            Dim g As New VB.SysContab.GruposDB
            Dim longitud As Integer
            Dim i As Integer


            'longitud = txtCodigo.Text.Length
            longitud = Registro.Length
            Me.Cargar(Detalles)
            'If longitud = 1 Then
            '    Exit Sub
            'Else
            '    lbGruposSup.Items.Clear()
            '    For i = 0 To longitud - 2
            '        If g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Grupos").Rows.Count <> 0 Then
            '            lbGruposSup.Items.Add(g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Grupos").Rows(0).Item("Codigo_Grupo") & " - " & g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Grupos").Rows(0).Item("Nombre"))

            '        End If

            '    Next

            '    If lbGruposSup.Items.Count <> 0 Then
            '        etGruposSup.Visible = True
            '        lbGruposSup.Visible = True

            '    End If

            'End If
        Else
            Me.Text = "Agregar Grupo de Resultado"
            Me.cbnivel.SelectedIndex = 1
            Me.cbOperacion.SelectedIndex = 2
            Me.txtFactor.Text = "1.00"
            Me.txtNivel.Text = Me.cbnivel.SelectedIndex.ToString

        End If

        Me.Refresh()

    End Sub

    Public Sub Cargar(ByVal Det As VB.SysContab.GruposDetails)
        Try
            Detalle = ObtieneDatos("Select max(Nivel) from grupos where empresa = " & EmpresaActual & " and tipo = 'R'").Rows(0)(0)
            If Det.Nivel = 1 Then
                Me.dgNiveles.DataSource = ObtieneDatos("Select Codigo_grupo as Codigo, Nombre as Nombre, Nivel, Orden, Detalle from grupos where empresa = " & EmpresaActual & " and nivel <> 0 and tipo = 'R' and nivel <= " & Det.Nivel)
            Else
                Me.dgNiveles.DataSource = ObtieneDatos("Select Codigo_grupo as Codigo, Nombre as Nombre, Nivel, Orden, Detalle from grupos where codigo_grupo like '" & IIf(Me.txtCodigo.Text = "", "-", Me.txtCodigo.Text.Substring(0, Det.Nivel - 1)) & "' + '%' and empresa = " & EmpresaActual & " and nivel <> 0 and tipo = 'R' and nivel <= " & Det.Nivel)
            End If
            'Me.Vista.Columns("Orden").Visible = False
            Me.Vista.Columns("Nivel").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

      

    End Sub

    Private Sub frmNuevoGrupoResultado_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim grupo As frmGrupos = grupo.Instance
        grupo.cargar()

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        'lbGruposSup.Items.Clear()
        'lbGruposSup.Visible = False
        'etGruposSup.Visible = False

        Dim codigo As New Regex("\d{1}", RegexOptions.IgnoreCase)

        If Not codigo.IsMatch(txtCodigo.Text) Then
            txtCodigo.ResetText()

        End If

    End Sub

    Private Sub txtCodigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Leave
        'Dim g As New VB.SysContab.GruposDB()
        'Dim longitud As Integer
        'Dim i As Integer

        'If Nuevo = "NO" Then
        '    Exit Sub
        'End If

        'If Trim(txtCodigo.Text) <> "" Then
        '    longitud = txtCodigo.Text.Length
        '    g.GetListCodigo(txtCodigo.Text, TipoGrupo)

        '    If longitud = 1 Then
        '        If g.GetListCodigo(txtCodigo.Text, TipoGrupo).Tables("Grupos").Rows.Count <> 0 Then
        '            MsgBox("Código de Grupo ya existe", MsgBoxStyle.Information)
        '            txtCodigo.Focus()
        '            Exit Sub

        '        End If
        '    Else
        '        If g.GetListCodigo(txtCodigo.Text, TipoGrupo).Tables("Grupos").Rows.Count <> 0 Then
        '            MsgBox("Código de Grupo ya existe", MsgBoxStyle.Information)
        '            txtCodigo.Focus()
        '            Exit Sub

        '        End If

        '        lbGruposSup.Items.Clear()
        '        For i = 0 To longitud - 2
        '            If g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Grupos").Rows.Count <> 0 Then
        '                lbGruposSup.Items.Add(g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Grupos").Rows(0).Item("Codigo_Grupo") & " - " & g.GetListCodigo(txtCodigo.Text.Substring(0, i + 1), TipoGrupo).Tables("Grupos").Rows(0).Item("Nombre"))

        '            End If

        '        Next

        '        If lbGruposSup.Items.Count <> 0 Then
        '            etGruposSup.Visible = True
        '            lbGruposSup.Visible = True

        '        End If

        '    End If

        'End If

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Microsoft.VisualBasic.Asc(e.KeyChar) <> 8 Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
                Exit Sub

            End If
        End If

    End Sub

    Private Sub txtTotalDe_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotalDe.Leave
        If Me.cbnivel.SelectedIndex = 0 Then
            If Me.txtTotalDe.Text = "" Then 'se limpio la formula
                MsgBox("Para los grupos de tipo formula debe ingresar los grupos que la conforman, separados por comas", MsgBoxStyle.Information, "STS-Contab")
            End If
        Else
            Me.txtTotalDe.Text = ""
        End If

    End Sub

    Private Sub cbnivel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbnivel.SelectedIndexChanged
        If Me.cbnivel.SelectedIndex = 0 Then
            Me.cbOperacion.Enabled = True
            Me.txtFactor.Enabled = True
        Else
            Me.cbOperacion.Enabled = False
            Me.txtFactor.Enabled = False

        End If
        Me.txtNivel.Text = Me.cbnivel.SelectedIndex.ToString
    End Sub
End Class
