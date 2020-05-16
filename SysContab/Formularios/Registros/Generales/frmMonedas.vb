Imports System
'Imports iTextSharp
'Imports iTextSharp.text
'Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmMonedas
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmMonedas = Nothing
    Dim r As New VB.SysContab.Rutinas()
    Public Shared Function Instance() As frmMonedas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmMonedas()
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
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgMonedas As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.dgMonedas = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgMonedas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 52)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(242, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 26)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(320, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 26)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.Visible = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(164, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 26)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(86, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 26)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 26)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "Nuevo"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(88, 9)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(326, 20)
        Me.txtBuscar.TabIndex = 9
        '
        'dgMonedas
        '
        Me.dgMonedas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgMonedas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMonedas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgMonedas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgMonedas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgMonedas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgMonedas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgMonedas.CaptionForeColor = System.Drawing.Color.Black
        Me.dgMonedas.DataMember = ""
        Me.dgMonedas.FlatMode = True
        Me.dgMonedas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMonedas.ForeColor = System.Drawing.Color.Black
        Me.dgMonedas.GridLineColor = System.Drawing.Color.Silver
        Me.dgMonedas.HeaderBackColor = System.Drawing.Color.Black
        Me.dgMonedas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgMonedas.HeaderForeColor = System.Drawing.Color.White
        Me.dgMonedas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgMonedas.Location = New System.Drawing.Point(8, 43)
        Me.dgMonedas.Name = "dgMonedas"
        Me.dgMonedas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgMonedas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgMonedas.ReadOnly = True
        Me.dgMonedas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgMonedas.SelectionForeColor = System.Drawing.Color.White
        Me.dgMonedas.Size = New System.Drawing.Size(406, 95)
        Me.dgMonedas.TabIndex = 8
        '
        'frmMonedas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(426, 205)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgMonedas)
        Me.Name = "frmMonedas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgMonedas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim Monedas As New VB.SysContab.MonedaDB()

    Private Sub frmMonedas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As DataTable
        Dim ds As DataSet

        ''VB.SysContab.RutinasNomina.CambiarEstilo(Me)
        RolesDB.UsuarioAcciones(GroupBox1)
        ''
        ds = Monedas.GetList

        dgMonedas.DataSource = Monedas.GetList().Tables("Monedas").DefaultView
        Tabla = ds.Tables("Monedas")

        r.FormatGenerico(dgMonedas, Tabla)

        If ds.Tables("Monedas").Rows.Count <> 0 Then
            Registro = dgMonedas.Item(0, 0)
        Else
            Registro = "Vacio"
        End If

        dgMonedas.CaptionText = "Información de Monedas"
        Me.Text = "Mantenimiento de Monedas"
        ''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        '''VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmAgregarMoneda = frmAgregarMoneda.Instance
        Dim Monedas As New VB.SysContab.MonedaDB()

        Nuevo = "SI"

        f.MdiParent = Me.MdiParent
        f.Show()

        dgMonedas.DataSource = Monedas.GetList().Tables("monedas").DefaultView


    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmAgregarMoneda = frmAgregarMoneda.Instance
        Dim monedas As New VB.SysContab.MonedaDB()

        Nuevo = "NO"

        If Registro = "Vacio" Then
            MsgBox("Seleccione el registro de Moneda que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.MdiParent = Me.MdiParent
        f.Show()

        dgMonedas.DataSource = monedas.GetList().Tables("monedas").DefaultView

    End Sub

    Private Sub dgMonedas_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgMonedas.CurrentCellChanged
        Registro = dgMonedas.Item(dgMonedas.CurrentRowIndex, 0)

    End Sub


    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult
        'Dim Monedas As New VB.SysContab.MonedaDB()

        If Registro = "Vacio" Then
            MsgBox("Seleccione el registro de Moneda que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que dese borrar la Moneda: " & dgMonedas.Item(dgMonedas.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Monedas.Delete(dgMonedas.Item(dgMonedas.CurrentRowIndex, 0))

        MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        'Dim r As New VB.SysContab.RutinasNomina()
        'Dim Tabla As New DataTable()
        ''Dim f As New frmGrupos()
        Dim ds As New DataSet()

        ds = Monedas.GetList

        dgMonedas.DataSource = ds.Tables("Monedas").DefaultView

        'Tabla = ds.Tables("Monedas")

        'If ds.Tables("Monedas").Rows.Count = 0 Then
        '    Registro = "Vacio"

        'End If

        'r.FormatGenerico(dgMonedas, Tabla)

    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim Monedas As New VB.SysContab.MonedaDB()

        dgMonedas.DataSource = Monedas.GetListBuscar(txtBuscar.Text, EmpresaActual).Tables("Monedas").DefaultView


        If Monedas.GetListBuscar(txtBuscar.Text, EmpresaActual).Tables("Monedas").Rows.Count = 0 Then
            Exit Sub
        End If

        Registro = dgMonedas.Item(dgMonedas.CurrentRowIndex, 0)

    End Sub

    Private Sub frmMonedas_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        '''
        'FormPrincipal.IsMdiContainer = False
        'FormPrincipal.Text = NombreEmpresaActual
        'FormPrincipal.Refresh()

    End Sub

    Private Sub frmMonedas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        'Menu Herramientas
        '''
    End Sub

    Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.MouseEnter
        '''
    End Sub

    Private Sub dgMonedas_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgMonedas.MouseEnter
        '''
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'Dim fReportes As New frmReportes()
        'Dim rEmpleados As New rptEmpleados()
        'Dim Empleados As New VB.SysContab.EmpleadosDB()
        'Dim r As New VB.SysContab.RutinasNomina()

        'rEmpleados.SetDataSource(Empleados.GetListReporte(txtBuscar.Text, EmpresaActual))
        'fReportes.crvReportes.ReportSource = rEmpleados
        'fReportes.ShowDialog()

    End Sub
End Class
