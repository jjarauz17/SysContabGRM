Imports System.Data.SqlClient
Public Class frmCargadeInventarioBodega_List
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmCargadeInventarioBodega_List = Nothing

    Public Shared Function Instance() As frmCargadeInventarioBodega_List
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmCargadeInventarioBodega_List()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents dgInventariosFisicos As System.Windows.Forms.DataGrid
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdJustificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbbodega As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdJustificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEditar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.dgInventariosFisicos = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbFiltro = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbbodega = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgInventariosFisicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdJustificar)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdEditar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 464)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 56)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'cmdJustificar
        '
        Me.cmdJustificar.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdJustificar.Location = New System.Drawing.Point(248, 16)
        Me.cmdJustificar.Name = "cmdJustificar"
        Me.cmdJustificar.Size = New System.Drawing.Size(72, 32)
        Me.cmdJustificar.TabIndex = 10
        Me.cmdJustificar.Text = "Justificar"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdBorrar.Location = New System.Drawing.Point(168, 16)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 32)
        Me.cmdBorrar.TabIndex = 9
        Me.cmdBorrar.Text = "Borrar"
        '
        'cmdEditar
        '
        Me.cmdEditar.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdEditar.Location = New System.Drawing.Point(88, 16)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(72, 32)
        Me.cmdEditar.TabIndex = 8
        Me.cmdEditar.Text = "Editar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 16)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 32)
        Me.cmdNuevo.TabIndex = 7
        Me.cmdNuevo.Text = "Nuevo"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(680, 16)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 32)
        Me.cmdSalir.TabIndex = 6
        Me.cmdSalir.Text = "&Salir"
        '
        'dgInventariosFisicos
        '
        Me.dgInventariosFisicos.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgInventariosFisicos.BackColor = System.Drawing.Color.Gainsboro
        Me.dgInventariosFisicos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgInventariosFisicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgInventariosFisicos.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgInventariosFisicos.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgInventariosFisicos.CaptionForeColor = System.Drawing.Color.Black
        Me.dgInventariosFisicos.DataMember = ""
        Me.dgInventariosFisicos.FlatMode = True
        Me.dgInventariosFisicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgInventariosFisicos.ForeColor = System.Drawing.Color.Black
        Me.dgInventariosFisicos.GridLineColor = System.Drawing.Color.Silver
        Me.dgInventariosFisicos.HeaderBackColor = System.Drawing.Color.Black
        Me.dgInventariosFisicos.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgInventariosFisicos.HeaderForeColor = System.Drawing.Color.White
        Me.dgInventariosFisicos.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgInventariosFisicos.Location = New System.Drawing.Point(16, 80)
        Me.dgInventariosFisicos.Name = "dgInventariosFisicos"
        Me.dgInventariosFisicos.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgInventariosFisicos.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgInventariosFisicos.ReadOnly = True
        Me.dgInventariosFisicos.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgInventariosFisicos.SelectionForeColor = System.Drawing.Color.White
        Me.dgInventariosFisicos.Size = New System.Drawing.Size(768, 384)
        Me.dgInventariosFisicos.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Estado:"
        '
        'cbFiltro
        '
        Me.cbFiltro.Items.AddRange(New Object() {"Todos", "Pendientes", "Autorizados"})
        Me.cbFiltro.Location = New System.Drawing.Point(104, 8)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(184, 21)
        Me.cbFiltro.TabIndex = 95
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Bodegas:"
        '
        'cbbodega
        '
        Me.cbbodega.Items.AddRange(New Object() {"Todos", "Pendientes", "Autorizados"})
        Me.cbbodega.Location = New System.Drawing.Point(104, 32)
        Me.cbbodega.Name = "cbbodega"
        Me.cbbodega.Size = New System.Drawing.Size(184, 21)
        Me.cbbodega.TabIndex = 97
        '
        'frmCargadeInventarioBodega_List
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(792, 526)
        Me.Controls.Add(Me.cbbodega)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbFiltro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgInventariosFisicos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCargadeInventarioBodega_List"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgInventariosFisicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Bodega As New VB.SysContab.BodegasDB
    Dim r As New VB.SysContab.Rutinas()
    Private Sub frmArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cbbodega.DataSource = Bodega.GetList()
        Me.cbbodega.ValueMember = "CODIGO"
        Me.cbbodega.DisplayMember = "UBICACION"
        Me.cbbodega.SelectedIndex = 0

        Dim ds As New DataSet()
        ds = VB.SysContab.BodegasDB.GetList_InventarioFisico("T", "%")
        Me.cbFiltro.SelectedIndex = 0
        Me.dgInventariosFisicos.DataSource = ds.Tables(0).DefaultView
        r.FormatGenerico(Me.dgInventariosFisicos, ds.Tables(0))
        ds.Dispose()
        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        Me.Refresh()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmArticulos_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Opened = "NO"

    End Sub

    Private Sub cbFiltro_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFiltro.SelectedIndexChanged
        If IsNumeric(Me.cbbodega.SelectedValue) Then
            Dim ds As New DataSet
            ds = VB.SysContab.BodegasDB.GetList_InventarioFisico(Microsoft.VisualBasic.Left(Me.cbFiltro.Text, 1), Me.cbbodega.SelectedValue)
            Me.dgInventariosFisicos.DataSource = ds.Tables(0).DefaultView
            r.FormatGenerico(Me.dgInventariosFisicos, ds.Tables(0))
        End If
        
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Dim f As frmCargaDeInventarioBodega = f.Instance
        Nuevo = "SI"
        f.MdiParent = Me.MdiParent
        f.Show()

    End Sub

    Private Sub cmdJustificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdJustificar.Click
        Dim f As frmCargadeInventarioBodega_Justificar = f.Instance
        Nuevo = "NO"
        f.MdiParent = Me.MdiParent
        f.CodigoBodega = Me.dgInventariosFisicos.DataSource.table.rows(Me.dgInventariosFisicos.CurrentRowIndex)("codigo_bodega")
        f.Fecha = Me.dgInventariosFisicos.DataSource.table.rows(Me.dgInventariosFisicos.CurrentRowIndex)("fecha")
        f.TipoArticulo = Me.dgInventariosFisicos.DataSource.table.rows(Me.dgInventariosFisicos.CurrentRowIndex)("Origen")
        f.Show()

    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim f As frmCargaInventarioBodega_Edit = f.Instance
        f.MdiParent = Me.MdiParent
        If Me.dgInventariosFisicos.DataSource.table.rows(Me.dgInventariosFisicos.CurrentRowIndex)("autorizado") = True Then
            MsgBox("Este inventario ya ha sido autorizado, no puede editarse ", MsgBoxStyle.Information, "STS-Contab")
            Exit Sub
        End If
        f.CBodega = Me.dgInventariosFisicos.DataSource.table.rows(Me.dgInventariosFisicos.CurrentRowIndex)("codigo_bodega")
        f.dFecha = Me.dgInventariosFisicos.DataSource.table.rows(Me.dgInventariosFisicos.CurrentRowIndex)("fecha")
        f.TipoArticulo = Me.dgInventariosFisicos.DataSource.table.rows(Me.dgInventariosFisicos.CurrentRowIndex)("Origen")

        f.Show()
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.dgInventariosFisicos.DataSource.table.rows(Me.dgInventariosFisicos.CurrentRowIndex)("autorizado") = True Then
            MsgBox("Este inventario ya ha sido autorizado, no puede borrarse ", MsgBoxStyle.Information, "STS-Contab")
            Exit Sub
        End If
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()
        Try
            'Borrar los detalles
            VB.SysContab.BodegasDB.InventarioFisicoDetalle_Delete(Me.dgInventariosFisicos.DataSource.table.rows(Me.dgInventariosFisicos.CurrentRowIndex)("codigo_bodega"), _
                Me.dgInventariosFisicos.DataSource.table.rows(Me.dgInventariosFisicos.CurrentRowIndex)("fecha"))
            'Borrar el encabezado
            VB.SysContab.BodegasDB.InventarioFisico_Delete(Me.dgInventariosFisicos.DataSource.table.rows(Me.dgInventariosFisicos.CurrentRowIndex)("codigo_bodega"), _
                Me.dgInventariosFisicos.DataSource.table.rows(Me.dgInventariosFisicos.CurrentRowIndex)("fecha"))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
            VB.SysContab.Rutinas.ErrorTransaccion()
        End Try
        VB.SysContab.Rutinas.okTransaccion()

        Dim ds As New DataSet
        ds = VB.SysContab.BodegasDB.GetList_InventarioFisico(Microsoft.VisualBasic.Left(Me.cbFiltro.Text, 1), Me.cbbodega.SelectedValue)
        Me.dgInventariosFisicos.DataSource = ds.Tables(0).DefaultView
        r.FormatGenerico(Me.dgInventariosFisicos, ds.Tables(0))

    End Sub
End Class
