
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Imports System.Web.Mail
'Imports System.Web.Mail.SmtpMail


Public Class frmZonas
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmZonas = Nothing

    Public Shared Function Instance() As frmZonas
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmZonas()
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
    Friend WithEvents dgZonas As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgZonas = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAyuda = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.dgZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgZonas
        '
        Me.dgZonas.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgZonas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgZonas.BackColor = System.Drawing.Color.Gainsboro
        Me.dgZonas.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgZonas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgZonas.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgZonas.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgZonas.CaptionForeColor = System.Drawing.Color.Black
        Me.dgZonas.DataMember = ""
        Me.dgZonas.FlatMode = True
        Me.dgZonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgZonas.ForeColor = System.Drawing.Color.Black
        Me.dgZonas.GridLineColor = System.Drawing.Color.Silver
        Me.dgZonas.HeaderBackColor = System.Drawing.Color.Black
        Me.dgZonas.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgZonas.HeaderForeColor = System.Drawing.Color.White
        Me.dgZonas.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgZonas.Location = New System.Drawing.Point(27, 35)
        Me.dgZonas.Name = "dgZonas"
        Me.dgZonas.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgZonas.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgZonas.ReadOnly = True
        Me.dgZonas.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgZonas.SelectionForeColor = System.Drawing.Color.White
        Me.dgZonas.Size = New System.Drawing.Size(401, 161)
        Me.dgZonas.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Controls.Add(Me.cmdAyuda)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 60)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(476, 26)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(72, 26)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.Visible = False
        '
        'cmdAyuda
        '
        Me.cmdAyuda.Enabled = False
        Me.cmdAyuda.Location = New System.Drawing.Point(242, 17)
        Me.cmdAyuda.Name = "cmdAyuda"
        Me.cmdAyuda.Size = New System.Drawing.Size(72, 35)
        Me.cmdAyuda.TabIndex = 7
        Me.cmdAyuda.Text = "&Ayuda"
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.SysContab.My.Resources.Resources._115_25x25
        Me.cmdSalir.Location = New System.Drawing.Point(320, 17)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 35)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(398, 17)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 35)
        Me.cmdImprimir.TabIndex = 4
        Me.cmdImprimir.Text = "&Imprimir"
        Me.cmdImprimir.Visible = False
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Enabled = False
        Me.cmdBorrar.Location = New System.Drawing.Point(164, 17)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 35)
        Me.cmdBorrar.TabIndex = 5
        Me.cmdBorrar.Text = "&Borrar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Enabled = False
        Me.cmdModificar.Location = New System.Drawing.Point(86, 17)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 35)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "&Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 17)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 35)
        Me.cmdNuevo.TabIndex = 1
        Me.cmdNuevo.Text = "&Nuevo"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(104, 9)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(324, 20)
        Me.txtBuscar.TabIndex = 5
        '
        'frmZonas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(439, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgZonas)
        Me.Name = "frmZonas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgZonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim r As New VB.SysContab.Rutinas()
    Private Sub frmZonas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Zonas As New VB.SysContab.ZonasDB()
        Dim Tabla As New DataTable()
        Dim ds As New DataSet()

        'r.CambiarEstilo(Me)
        RolesDB.UsuarioAcciones(GroupBox1)
        ds = Zonas.GetList()

        dgZonas.DataSource = Zonas.GetList().Tables("Zonas").DefaultView
        Tabla = ds.Tables("Zonas")

        r.FormatGenerico(dgZonas, Tabla)

        'If ds.Tables("Zonas").Rows.Count <> 0 Then
        '    Registro = dgZonas.Item(0, 0)
        'Else
        '    Registro = "Vacio"
        'End If

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)

        dgZonas.CaptionText = "Información de Zonas"

        Me.Text = "Mantenimiento de Zonas"
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim z As frmAgregarZona = z.Instance
        Nuevo = "SI"
        z.MdiParent = Me.MdiParent
        z.Show()

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim zonas As New VB.SysContab.ZonasDB()
        dgZonas.DataSource = zonas.GetListBuscar(txtBuscar.Text).Tables("Zonas").DefaultView


        If zonas.GetListBuscar(txtBuscar.Text).Tables("Zonas").Rows.Count = 0 Then
            Exit Sub

        End If

        Registro = dgZonas.Item(dgZonas.CurrentRowIndex, 0)
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim f As frmAgregarZona = frmAgregarZona.Instance()
        Dim zonas As New VB.SysContab.ZonasDB()

        Nuevo = "NO"

        If Registro = "Vacio" Then
            MsgBox("Seleccione la Zona que desea Editar", MsgBoxStyle.Information)
            Exit Sub
        End If

        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub dgZonas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgZonas.CurrentCellChanged
        Registro = dgZonas.Item(dgZonas.CurrentRowIndex, 0)

    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        Dim resp As DialogResult
        Dim zonas As New VB.SysContab.ZonasDB()

        If Registro = "Vacio" Then
            MsgBox("Seleccione la Zona que desea Borrar", MsgBoxStyle.Information)
            Exit Sub
        End If

        resp = MsgBox("Esta seguro que dese borrar la Zona: " & dgZonas.Item(dgZonas.CurrentRowIndex, 1), MsgBoxStyle.YesNo + MsgBoxStyle.Question)

        If resp = DialogResult.No Then
            Exit Sub
        End If

        Try
            zonas.Delete(dgZonas.Item(dgZonas.CurrentRowIndex, 0))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try

        MsgBox("El registro ha sido borrado", MsgBoxStyle.Information)

        Dim r As New VB.SysContab.Rutinas()
        Dim Tabla As New DataTable()
        'Dim f As New frmGrupos()
        Dim ds As New DataSet()

        ''  '''r.CambiarEstilo(Me)

        ds = zonas.GetList

        dgZonas.DataSource = zonas.GetList().Tables("Zonas").DefaultView
        Tabla = ds.Tables("Zonas")

        If ds.Tables("Zonas").Rows.Count = 0 Then
            Registro = "Vacio"
        Else
            Registro = dgZonas.Item(0, 0)

        End If

        r.FormatGenerico(dgZonas, Tabla)

    End Sub


    Private Sub dgZonas_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgZonas.Navigate

    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True

        End If

    End Sub

    'Private Sub dgZonas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgZonas.MouseEnter
    '    '''
    'End Sub

    'Private Sub frmZonas_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
    '    '''
    'End Sub

    'Private Sub txtBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.MouseEnter
    '    '''
    'End Sub

    Private Sub frmZonas_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"
        '''
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        ''''

        'Dim fReportes As New frmReportes()

        'Dim rZonas As New crZonas()

        'Dim Zonas As New VB.SysContab.ZonasDB()
        'Dim dsZonas As New DataSet()

        'dsZonas = Zonas.GetListReporte(Me.txtBuscar.Text)
        'rZonas.SetDataSource(dsZonas)
        'fReportes.crvReportes.ReportSource = rZonas
        'freportes.Show()
    End Sub

    Private Sub cmdAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAyuda.Click
        Help.ShowHelp(Me, "ayuda/RegZonas.chm")
        'Help.ShowHelp(Me, "ayuda/STSContab.chm", HelpNavigator.KeywordIndex, "Zonas")
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Exit Sub
        Dim r As New VB.SysContab.Rutinas()

        Dim odst As New DataSet()
        Dim CadenaCn As String = r.AbrirConexion '"uid=sa;server=(local);database=northwind"

        'Creamos un objeto SqlConnection
        Dim ocn As New SqlConnection(CadenaCn)

        'creamos un objeto SqlCommand que ejecute el SP
        Dim ocmd As New SqlCommand("_LibroBalanzaNew", ocn)

        ocmd.CommandType = CommandType.StoredProcedure
        'Adicionamos el tipo y el valor de los parametros

        'que necesita el procedimiento almacenado

        ocmd.Parameters.Add("@Empresa", SqlDbType.Int).Value = 0
        ocmd.Parameters.Add("@Periodo", SqlDbType.Int).Value = 0
        ocmd.Parameters.Add("@Desde", SqlDbType.SmallDateTime).Value = "01/01/2006"
        ocmd.Parameters.Add("@Hasta", SqlDbType.SmallDateTime).Value = "01/01/2006"
        ocmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = "User"
        ocmd.Parameters.Add("@Titulo", SqlDbType.NVarChar).Value = ""
        ocmd.Parameters.Add("@Presentar", SqlDbType.NVarChar).Value = ""
        ocmd.Parameters.Add("@Cuenta", SqlDbType.NVarChar).Value = "123"
        ocmd.Parameters.Add("@TCuenta", SqlDbType.NVarChar).Value = "123"
        ocmd.Parameters.Add("@Nivel", SqlDbType.NVarChar).Value = "1"
        ocmd.Parameters.Add("@SinCuenta", SqlDbType.Bit).Value = 1
        ocmd.Parameters.Add("@MonedaBase", SqlDbType.NVarChar).Value = "1"
        ocmd.Parameters.Add("@MonedaCambio", SqlDbType.NVarChar).Value = "1"
        ocmd.Parameters.Add("@Zeros", SqlDbType.Bit).Value = 1

        'Creamos el objeto SqlDataAdapter que utilice al objeto SqlCommand,    
        'por lo que no necesita establecer la cadena de conexión por que el 
        'objeto Command ya esta utilizando una conexión.

        Dim odap As New SqlDataAdapter(ocmd)
        'Poblamos el objeto Dataset

        odap.Fill(odst)

        'Creamos el Schema a traves del metodo WriteXMLSchema y le
        'indicamos la ruta donde se guardara, la extension del archivo
        'resultante debe ser *.XSD
        odst.WriteXmlSchema(Application.StartupPath & "\Esquemas\LibroBalanza.xsd")

        'Destruimos las variables

        ocn.Dispose()

        ocmd.Dispose()






       


    End Sub

End Class
