Imports DbConnect
Public Class frmOrdenGrupos
    Inherits DevExpress.XtraEditors.XtraForm
    Private Shared ChildInstance As frmOrdenGrupos = Nothing

    Public Shared Function Instance() As frmOrdenGrupos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmOrdenGrupos
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
    Friend WithEvents TL As DevExpress.XtraTreeList.TreeList
    Friend WithEvents CmdAbajo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdArriba As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TL = New DevExpress.XtraTreeList.TreeList
        Me.CmdAbajo = New DevExpress.XtraEditors.SimpleButton
        Me.cmdArriba = New DevExpress.XtraEditors.SimpleButton
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.TL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TL
        '
        Me.TL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TL.Location = New System.Drawing.Point(16, 8)
        Me.TL.Name = "TL"
        Me.TL.OptionsBehavior.DragNodes = True
        Me.TL.Size = New System.Drawing.Size(536, 440)
        Me.TL.TabIndex = 9
        '
        'CmdAbajo
        '
        Me.CmdAbajo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdAbajo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdAbajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAbajo.Location = New System.Drawing.Point(560, 40)
        Me.CmdAbajo.Name = "CmdAbajo"
        Me.CmdAbajo.Size = New System.Drawing.Size(44, 24)
        Me.CmdAbajo.TabIndex = 11
        Me.CmdAbajo.Text = "Abajo"
        '
        'cmdArriba
        '
        Me.cmdArriba.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdArriba.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdArriba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdArriba.Location = New System.Drawing.Point(560, 8)
        Me.cmdArriba.Name = "cmdArriba"
        Me.cmdArriba.Size = New System.Drawing.Size(44, 24)
        Me.cmdArriba.TabIndex = 10
        Me.cmdArriba.Text = "Arriba"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(400, 456)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(72, 24)
        Me.cmdGuardar.TabIndex = 12
        Me.cmdGuardar.Text = "Guardar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(480, 456)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 24)
        Me.cmdSalir.TabIndex = 13
        Me.cmdSalir.Text = "Salir"
        '
        'frmOrdenGrupos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(624, 509)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.CmdAbajo)
        Me.Controls.Add(Me.cmdArriba)
        Me.Controls.Add(Me.TL)
        Me.Name = "frmOrdenGrupos"
        Me.Text = "frmOrdenGrupos"
        Me.WindowState = FormWindowState.Maximized
        CType(Me.TL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Public Tipo As String
    Private Cargado As Boolean = False
#End Region

    Private Sub frmOrdenGrupos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cargar(Me.Tipo)
        Me.Cargado = True
    End Sub
    Public Sub Cargar(ByVal Tipo As String)

        Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
        v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
        v.AddParameter("Tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Tipo)
        Me.TL.DataSource = v.EjecutarComando("_ArbolGrupos", "Tabla")
        Me.TL.KeyFieldName = "Hijo"
        Me.TL.ParentFieldName = "Padre"
        Me.TL.PopulateColumns()
        v = Nothing
        Me.TL.Columns("Orden").VisibleIndex = -1 'Para esconderlo
        Me.TL.Columns("Catalogo").VisibleIndex = -1 'Para esconderlo
        Me.TL.Columns("Nivel").VisibleIndex = -1 'Para esconderlo
        Me.TL.Columns("Codigo").VisibleIndex = -1 'Para esconderlo
        Me.TL.Columns("Nombre").OptionsColumn.AllowEdit = False

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdArriba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdArriba.Click

        Dim Nivel As Integer
        Nivel = Me.TL.GetNodeIndex(Me.TL.FocusedNode)

        Dim NivelHermanoMayor, NivelNodoActual As String
        If Me.TL.FocusedNode.GetValue("Catalogo") = True Then
            Exit Sub
        End If

        'Si es el primer nodo
        If Not Me.TL.FocusedNode.ParentNode Is Nothing Then
            If Me.TL.FocusedNode.ParentNode.FirstNode Is Me.TL.FocusedNode Then
                Exit Sub
            End If
        Else
            'Es uno de los nodos de la raiz
        End If

        'Buscar el hermano anterior
        Dim nodo As DevExpress.XtraTreeList.Nodes.TreeListNode
        nodo = Me.TL.FocusedNode.PrevVisibleNode
        If nodo Is Nothing Then
            Exit Sub
        End If

        If Not nodo.ParentNode Is Nothing Then
            While True
                If nodo.ParentNode Is Me.TL.FocusedNode.ParentNode Then
                    Exit While
                Else
                    nodo = nodo.PrevVisibleNode
                End If
            End While
        End If

        NivelHermanoMayor = nodo.GetValue("Nivel")
        NivelNodoActual = Me.TL.FocusedNode.GetValue("Nivel")
        Dim l As String

        'Procesar el Nodo Hermano Mayor
        nodo.SetValue("Hijo", NivelNodoActual & nodo.GetValue("Hijo").ToString.Substring(NivelHermanoMayor.Length, nodo.GetValue("Hijo").ToString.Length - NivelHermanoMayor.Length))
        For Each n As DevExpress.XtraTreeList.Nodes.TreeListNode In nodo.Nodes
            n.SetValue("Padre", nodo.GetValue("Hijo")) 'NivelNodoActual & nodo.GetValue("Hijo").ToString.Substring(NivelHermanoMayor.Length, nodo.GetValue("Hijo").ToString.Length - NivelHermanoMayor.Length))
            n.SetValue("Orden", NivelNodoActual.Split(CType("-", Char()), 2)(1))
        Next

        'Procesar el Nodo Actual
        Me.TL.FocusedNode.SetValue("Hijo", NivelHermanoMayor & Me.TL.FocusedNode.GetValue("Hijo").ToString.Substring(NivelNodoActual.Length, Me.TL.FocusedNode.GetValue("Hijo").ToString.Length - NivelNodoActual.Length))
        For Each n As DevExpress.XtraTreeList.Nodes.TreeListNode In Me.TL.FocusedNode.Nodes
            n.SetValue("Padre", Me.TL.FocusedNode.GetValue("Hijo")) 'NivelHermanoMayor & Me.TL.FocusedNode.GetValue("Hijo").ToString.Substring(NivelNodoActual.Length, Me.TL.FocusedNode.GetValue("Hijo").ToString.Length - NivelNodoActual.Length))
            n.SetValue("Orden", NivelHermanoMayor.Split(CType("-", Char()), 2)(1))
        Next
        Me.TL.RefreshDataSource()
        Dim i As Integer
        i = Me.TL.GetNodeIndex(nodo)
        Me.TL.SetNodeIndex(nodo, Me.TL.GetNodeIndex(Me.TL.FocusedNode))
        Me.TL.SetNodeIndex(Me.TL.FocusedNode, i)
        i = Nothing

        'Me.TL.SetNodeIndex(Me.TL.FocusedNode, Nivel - 1)
        'Me.TL.SetNodeIndex(Me.TL.Nodes(Nivel - 1), Nivel)

    End Sub

    Private Sub CmdAbajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAbajo.Click

        Dim Nivel As Integer
        Nivel = Me.TL.GetNodeIndex(Me.TL.FocusedNode)

        Dim NivelHermanoMenor, NivelNodoActual As String
        If Me.TL.FocusedNode.GetValue("Catalogo") = True Then
            Exit Sub
        End If

        'Si es el ultimo nodo
        If Not Me.TL.FocusedNode.ParentNode Is Nothing Then
            If Me.TL.FocusedNode.ParentNode.LastNode Is Me.TL.FocusedNode Then
                Exit Sub
            End If
        Else
            'Es uno de los nodos de la raiz
        End If
        'Buscar el hermano siguiente
        Dim nodo As DevExpress.XtraTreeList.Nodes.TreeListNode
        nodo = Me.TL.FocusedNode.NextVisibleNode
        If nodo Is Nothing Then
            Exit Sub
        End If
        If Not nodo.ParentNode Is Nothing Then
            While True
                If nodo.ParentNode Is Me.TL.FocusedNode.ParentNode Then
                    Exit While
                Else
                    nodo = nodo.NextVisibleNode
                End If
            End While
        End If

        NivelHermanoMenor = nodo.GetValue("Nivel")
        NivelNodoActual = Me.TL.FocusedNode.GetValue("Nivel")
        Dim l As String

        'Procesar el Nodo Hermano Menor
        nodo.SetValue("Hijo", NivelNodoActual & nodo.GetValue("Hijo").ToString.Substring(NivelHermanoMenor.Length, nodo.GetValue("Hijo").ToString.Length - NivelHermanoMenor.Length))
        For Each n As DevExpress.XtraTreeList.Nodes.TreeListNode In nodo.Nodes
            n.SetValue("Padre", nodo.GetValue("Hijo")) 'NivelNodoActual & nodo.GetValue("Hijo").ToString.Substring(NivelHermanoMayor.Length, nodo.GetValue("Hijo").ToString.Length - NivelHermanoMayor.Length))
            n.SetValue("Orden", NivelNodoActual.Split(CType("-", Char()), 2)(1))
        Next

        'Procesar el Nodo Actual
        Me.TL.FocusedNode.SetValue("Hijo", NivelHermanoMenor & Me.TL.FocusedNode.GetValue("Hijo").ToString.Substring(NivelNodoActual.Length, Me.TL.FocusedNode.GetValue("Hijo").ToString.Length - NivelNodoActual.Length))
        For Each n As DevExpress.XtraTreeList.Nodes.TreeListNode In Me.TL.FocusedNode.Nodes
            n.SetValue("Padre", Me.TL.FocusedNode.GetValue("Hijo")) 'NivelHermanoMayor & Me.TL.FocusedNode.GetValue("Hijo").ToString.Substring(NivelNodoActual.Length, Me.TL.FocusedNode.GetValue("Hijo").ToString.Length - NivelNodoActual.Length))
            n.SetValue("Orden", NivelHermanoMenor.Split(CType("-", Char()), 2)(1))
        Next
        Me.TL.RefreshDataSource()
        Dim i As Integer
        i = Me.TL.GetNodeIndex(nodo)
        Me.TL.SetNodeIndex(nodo, Me.TL.GetNodeIndex(Me.TL.FocusedNode))
        Me.TL.SetNodeIndex(Me.TL.FocusedNode, i)
        i = Nothing
        'Me.TL.SetNodeIndex(Me.TL.FocusedNode, Nivel + 1)
        'Me.TL.SetNodeIndex(Me.TL.Nodes(Nivel + 1), Nivel)

    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click


        For i As Integer = 0 To Me.TL.DataSource.rows.count - 1
            If Me.TL.DataSource.rows(i)("Catalogo") = False Then
                Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
                v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                v.AddParameter("Codigo", SqlDbType.NVarChar, 10, ParameterDirection.Input, Me.TL.DataSource.rows(i)("Codigo"))
                v.AddParameter("Tipo", SqlDbType.NVarChar, 1, ParameterDirection.Input, Me.Tipo)
                v.AddParameter("Orden", SqlDbType.Int, 5, ParameterDirection.Input, Me.TL.DataSource.rows(i)("Orden"))
                v.AddParameter("Detalle", SqlDbType.Bit, 5, ParameterDirection.Input, Me.TL.DataSource.rows(i)("Presentar Detalle"))
                Try
                    v.EjecutarComando("_GruposOrden_Update")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                v = Nothing
            End If

        Next
    End Sub


    Private Sub TL_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TL.FocusedNodeChanged
        If Me.Cargado Then
            If e.Node.GetValue("Catalogo") = True Then
                Me.TL.Columns("Presentar Detalle").OptionsColumn.AllowEdit = False
            Else
                Me.TL.Columns("Presentar Detalle").OptionsColumn.AllowEdit = True
            End If
        End If
    End Sub
End Class
