Public Class frmListaFacturaProveedoresPlan
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmListaFacturaProveedoresPlan = Nothing

    Public Shared Function Instance() As frmListaFacturaProveedoresPlan
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmListaFacturaProveedoresPlan
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
    Friend WithEvents cmdBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTipoProv As System.Windows.Forms.Label
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents vFacturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cSelec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMontoPagar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtMntoValor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMontoPagarU As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents etInicio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTasa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cShow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.cSelec = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cShow = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBorrar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.lblTipoProv = New System.Windows.Forms.Label
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.vFacturas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtMntoValor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtMontoPagar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtMontoPagarU = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.fecha = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.etInicio = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtTasa = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMntoValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoPagarU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cSelec
        '
        Me.cSelec.AppearanceCell.Options.UseTextOptions = True
        Me.cSelec.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cSelec.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cSelec.AppearanceHeader.Options.UseFont = True
        Me.cSelec.AppearanceHeader.Options.UseTextOptions = True
        Me.cSelec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cSelec.Caption = "Seleccionar"
        Me.cSelec.FieldName = "Selecc"
        Me.cSelec.Name = "cSelec"
        Me.cSelec.Visible = True
        Me.cSelec.VisibleIndex = 15
        Me.cSelec.Width = 44
        '
        'cShow
        '
        Me.cShow.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cShow.AppearanceHeader.Options.UseFont = True
        Me.cShow.AppearanceHeader.Options.UseTextOptions = True
        Me.cShow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cShow.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cShow.Caption = "Aplicar Retensión."
        Me.cShow.FieldName = "Mostrar"
        Me.cShow.Name = "cShow"
        Me.cShow.Width = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdSalir)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.cmdNuevo)
        Me.GroupBox1.Controls.Add(Me.lblTipoProv)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 52)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(188, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Ver Factura"
        Me.Button1.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Location = New System.Drawing.Point(914, 13)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(72, 32)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "&Salir"
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Location = New System.Drawing.Point(110, 13)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 32)
        Me.cmdBorrar.TabIndex = 1
        Me.cmdBorrar.Text = "&Ayuda"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 13)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(96, 32)
        Me.cmdNuevo.TabIndex = 0
        Me.cmdNuevo.Text = "&Pagar Factura"
        '
        'lblTipoProv
        '
        Me.lblTipoProv.Location = New System.Drawing.Point(400, 18)
        Me.lblTipoProv.Name = "lblTipoProv"
        Me.lblTipoProv.Size = New System.Drawing.Size(100, 25)
        Me.lblTipoProv.TabIndex = 16
        Me.lblTipoProv.Text = "Label2"
        Me.lblTipoProv.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(8, 37)
        Me.GridControl1.MainView = Me.vFacturas
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMontoPagar, Me.txtMntoValor, Me.txtMontoPagarU})
        Me.GridControl1.Size = New System.Drawing.Size(996, 229)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vFacturas})
        '
        'vFacturas
        '
        Me.vFacturas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFacturas.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vFacturas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFacturas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.vFacturas.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vFacturas.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.vFacturas.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.vFacturas.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.vFacturas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vFacturas.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.vFacturas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vFacturas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.vFacturas.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vFacturas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.vFacturas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.vFacturas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.vFacturas.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.vFacturas.Appearance.Empty.Options.UseBackColor = True
        Me.vFacturas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFacturas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.vFacturas.Appearance.EvenRow.Options.UseBackColor = True
        Me.vFacturas.Appearance.EvenRow.Options.UseForeColor = True
        Me.vFacturas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFacturas.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vFacturas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFacturas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.vFacturas.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vFacturas.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.vFacturas.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.vFacturas.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.vFacturas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vFacturas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.vFacturas.Appearance.FilterPanel.Options.UseBackColor = True
        Me.vFacturas.Appearance.FilterPanel.Options.UseForeColor = True
        Me.vFacturas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.vFacturas.Appearance.FixedLine.Options.UseBackColor = True
        Me.vFacturas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.vFacturas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.vFacturas.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vFacturas.Appearance.FocusedCell.Options.UseForeColor = True
        Me.vFacturas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.vFacturas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.vFacturas.Appearance.FocusedRow.Options.UseBackColor = True
        Me.vFacturas.Appearance.FocusedRow.Options.UseForeColor = True
        Me.vFacturas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFacturas.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vFacturas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFacturas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.vFacturas.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vFacturas.Appearance.FooterPanel.Options.UseBackColor = True
        Me.vFacturas.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.vFacturas.Appearance.FooterPanel.Options.UseForeColor = True
        Me.vFacturas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vFacturas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vFacturas.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.vFacturas.Appearance.GroupButton.Options.UseBackColor = True
        Me.vFacturas.Appearance.GroupButton.Options.UseBorderColor = True
        Me.vFacturas.Appearance.GroupButton.Options.UseForeColor = True
        Me.vFacturas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vFacturas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vFacturas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.vFacturas.Appearance.GroupFooter.Options.UseBackColor = True
        Me.vFacturas.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.vFacturas.Appearance.GroupFooter.Options.UseForeColor = True
        Me.vFacturas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vFacturas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFacturas.Appearance.GroupPanel.Options.UseBackColor = True
        Me.vFacturas.Appearance.GroupPanel.Options.UseForeColor = True
        Me.vFacturas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vFacturas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.vFacturas.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.vFacturas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.vFacturas.Appearance.GroupRow.Options.UseBackColor = True
        Me.vFacturas.Appearance.GroupRow.Options.UseBorderColor = True
        Me.vFacturas.Appearance.GroupRow.Options.UseFont = True
        Me.vFacturas.Appearance.GroupRow.Options.UseForeColor = True
        Me.vFacturas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFacturas.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vFacturas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.vFacturas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.vFacturas.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.vFacturas.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.vFacturas.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.vFacturas.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.vFacturas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.vFacturas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.vFacturas.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.vFacturas.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.vFacturas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.vFacturas.Appearance.HorzLine.Options.UseBackColor = True
        Me.vFacturas.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.vFacturas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.vFacturas.Appearance.OddRow.Options.UseBackColor = True
        Me.vFacturas.Appearance.OddRow.Options.UseForeColor = True
        Me.vFacturas.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.vFacturas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.vFacturas.Appearance.Preview.Options.UseBackColor = True
        Me.vFacturas.Appearance.Preview.Options.UseForeColor = True
        Me.vFacturas.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.vFacturas.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.vFacturas.Appearance.Row.Options.UseBackColor = True
        Me.vFacturas.Appearance.Row.Options.UseForeColor = True
        Me.vFacturas.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.vFacturas.Appearance.RowSeparator.Options.UseBackColor = True
        Me.vFacturas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.vFacturas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.vFacturas.Appearance.SelectedRow.Options.UseBackColor = True
        Me.vFacturas.Appearance.SelectedRow.Options.UseForeColor = True
        Me.vFacturas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.vFacturas.Appearance.VertLine.Options.UseBackColor = True
        Me.vFacturas.ColumnPanelRowHeight = 35
        Me.vFacturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn8, Me.GridColumn9, Me.GridColumn7, Me.GridColumn12, Me.GridColumn20, Me.cShow, Me.GridColumn10, Me.GridColumn18, Me.GridColumn14, Me.GridColumn11, Me.cSelec, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn19})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Salmon
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Salmon
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.cSelec
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = True
        StyleFormatCondition1.Value2 = True
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Salmon
        StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.Salmon
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.cShow
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = True
        StyleFormatCondition2.Value2 = True
        Me.vFacturas.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.vFacturas.GridControl = Me.GridControl1
        Me.vFacturas.Name = "vFacturas"
        Me.vFacturas.OptionsView.EnableAppearanceEvenRow = True
        Me.vFacturas.OptionsView.EnableAppearanceOddRow = True
        Me.vFacturas.OptionsView.ShowAutoFilterRow = True
        Me.vFacturas.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.vFacturas.OptionsView.ShowFooter = True
        Me.vFacturas.OptionsView.ShowGroupPanel = False
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "No. Orden"
        Me.GridColumn13.FieldName = "Factura"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 56
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Factura"
        Me.GridColumn1.FieldName = "NoOrden"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 56
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 56
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Cuenta"
        Me.GridColumn3.FieldName = "Cuenta"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Nombre"
        Me.GridColumn4.FieldName = "Nombre"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 56
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn5.Caption = "Forma de Pago"
        Me.GridColumn5.FieldName = "Forma de Pago"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 56
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Monto"
        Me.GridColumn6.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Monto"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.SummaryItem.DisplayFormat = "{0:N}"
        Me.GridColumn6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 56
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "SubTotal"
        Me.GridColumn8.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Sub Total"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.SummaryItem.DisplayFormat = "{0:N}"
        Me.GridColumn8.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 56
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn9.AppearanceHeader.Options.UseFont = True
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "IVA"
        Me.GridColumn9.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "IVA"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.SummaryItem.DisplayFormat = "{0:N}"
        Me.GridColumn9.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 56
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Parcial"
        Me.GridColumn7.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "Parcial"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.SummaryItem.DisplayFormat = "{0:N}"
        Me.GridColumn7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 9
        Me.GridColumn7.Width = 56
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn12.AppearanceHeader.Options.UseFont = True
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "Saldo"
        Me.GridColumn12.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "Saldo"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.SummaryItem.DisplayFormat = "{0:N}"
        Me.GridColumn12.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 10
        Me.GridColumn12.Width = 56
        '
        'GridColumn20
        '
        Me.GridColumn20.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn20.AppearanceHeader.Options.UseFont = True
        Me.GridColumn20.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn20.Caption = "Retension"
        Me.GridColumn20.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn20.FieldName = "Retension"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn20.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 11
        Me.GridColumn20.Width = 65
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn10.AppearanceHeader.Options.UseFont = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Total"
        Me.GridColumn10.DisplayFormat.FormatString = "{0:N}"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "Total"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.SummaryItem.DisplayFormat = "{0:N}"
        Me.GridColumn10.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        Me.GridColumn10.Width = 56
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn18.AppearanceHeader.Options.UseFont = True
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn18.Caption = "Mnto. Valor"
        Me.GridColumn18.ColumnEdit = Me.txtMntoValor
        Me.GridColumn18.FieldName = "Mnto"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn18.SummaryItem.FieldName = "mnto"
        Me.GridColumn18.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 12
        Me.GridColumn18.Width = 55
        '
        'txtMntoValor
        '
        Me.txtMntoValor.AutoHeight = False
        Me.txtMntoValor.Mask.EditMask = "n2"
        Me.txtMntoValor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMntoValor.Mask.UseMaskAsDisplayFormat = True
        Me.txtMntoValor.Name = "txtMntoValor"
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn14.AppearanceHeader.Options.UseFont = True
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn14.Caption = "Monto Pagar C$"
        Me.GridColumn14.ColumnEdit = Me.txtMontoPagar
        Me.GridColumn14.FieldName = "Pagar"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn14.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 13
        Me.GridColumn14.Width = 55
        '
        'txtMontoPagar
        '
        Me.txtMontoPagar.AutoHeight = False
        Me.txtMontoPagar.Mask.EditMask = "n2"
        Me.txtMontoPagar.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoPagar.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoPagar.Name = "txtMontoPagar"
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn11.Caption = "Monto Pagar U$"
        Me.GridColumn11.ColumnEdit = Me.txtMontoPagarU
        Me.GridColumn11.FieldName = "PagarU"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.SummaryItem.DisplayFormat = "{0:n2}"
        Me.GridColumn11.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 14
        Me.GridColumn11.Width = 72
        '
        'txtMontoPagarU
        '
        Me.txtMontoPagarU.AutoHeight = False
        Me.txtMontoPagarU.Mask.EditMask = "n2"
        Me.txtMontoPagarU.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoPagarU.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoPagarU.Name = "txtMontoPagarU"
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "Comp_No"
        Me.GridColumn15.FieldName = "Comp_No"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.Caption = "Mes"
        Me.GridColumn16.FieldName = "Mes"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.Caption = "Per_ID"
        Me.GridColumn17.FieldName = "Per_ID"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Moneda"
        Me.GridColumn19.FieldName = "Moneda"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'fecha
        '
        Me.fecha.EditValue = Nothing
        Me.fecha.Location = New System.Drawing.Point(98, 8)
        Me.fecha.Name = "fecha"
        Me.fecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Properties.Appearance.Options.UseFont = True
        Me.fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.fecha.Size = New System.Drawing.Size(143, 20)
        Me.fecha.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(8, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "Fecha de Pago:"
        '
        'etInicio
        '
        Me.etInicio.Location = New System.Drawing.Point(520, 18)
        Me.etInicio.Name = "etInicio"
        Me.etInicio.Size = New System.Drawing.Size(6, 13)
        Me.etInicio.TabIndex = 19
        Me.etInicio.Text = "0"
        Me.etInicio.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(247, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl2.TabIndex = 18
        Me.LabelControl2.Text = "Tasa:"
        '
        'txtTasa
        '
        Me.txtTasa.EditValue = New Decimal(New Integer() {10000, 0, 0, 262144})
        Me.txtTasa.EnterMoveNextControl = True
        Me.txtTasa.Location = New System.Drawing.Point(283, 6)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtTasa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtTasa.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTasa.Properties.Appearance.Options.UseBackColor = True
        Me.txtTasa.Properties.Appearance.Options.UseFont = True
        Me.txtTasa.Properties.Appearance.Options.UseForeColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Info
        Me.txtTasa.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.txtTasa.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTasa.Properties.Mask.EditMask = "n4"
        Me.txtTasa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTasa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTasa.Size = New System.Drawing.Size(100, 22)
        Me.txtTasa.TabIndex = 1
        '
        'frmListaFacturaProveedoresPlan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1016, 326)
        Me.Controls.Add(Me.txtTasa)
        Me.Controls.Add(Me.etInicio)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmListaFacturaProveedoresPlan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMntoValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoPagarU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim Conf As New VB.SysContab.ConfiguracionDB
    Dim Prov As New VB.SysContab.ProveedoresDB

    Dim r As New VB.SysContab.Rutinas
    Public Fact As String
    Public FactValor As Double, SubTotal As Double, FactMnto As Double

    Public WithEvents myDataSet As DataSet
    Dim tCust As DataTable
    Public WithEvents tCust1 As New DataTable
    'Dim tCust1 As DataTable

    Dim Config As New VB.SysContab.ConfiguracionDB
    Dim ConfigDet As VB.SysContab.ConfiguracionDetails = Config.GetConfigDetails()

    Public ds As DataSet
    Private Temp As Boolean = False
    Dim Abono As Double = 0


    Private Sub frmListaFacturaProveedoresPlan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.fecha.DateTime = CDate(VB.SysContab.Rutinas.Fecha())
        Cargar()
        Me.txtTasa.EditValue = VB.SysContab.Rutinas.TasaCambio(Me.fecha.DateTime.Date)
    End Sub

    Public Sub Cargar()
        Dim FacturasDB As New VB.SysContab.Facturas_ComprasDB

        ds = FacturasDB.GetListxTipoProductoCredito(lblTipoProv.Text, fecha.DateTime.Date, Me.txtTasa.EditValue)
        Me.GridControl1.DataSource = ds.Tables(0)
        Me.vFacturas.BestFitColumns()

        'Me.txtTasa.EditValue = VB.SysContab.Rutinas.TasaCambio(Me.fecha.DateTime.Date)

        If ds.Tables("Tablas").Rows.Count <> 0 Then
            Registro = Me.vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "Factura")
        Else
            Registro = "Vacio"
        End If


        Me.Text = "*** Listado de Facturas por Pagar ***"
        Me.Refresh()
    End Sub

    Private Sub Seleccionar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click

        Dim Proveedor As String
        Dim CompFact, SaldoFact As String, FactPagar As String
        Dim IR_Pagado_Alcaldia, IRPagado, IVAAsumido As Boolean

        'Para Pagos en Cordobas
        Dim Monto_IR_Pagado, Monto_IR_Pagado_Alcaldia, MontoIVAasumido, MontoIRxPagar, SubTotalIRxPagar, _
        MontoIR_ALMAxPagar, SubTotalIR_ALMAxPagar As Double

        'Para los Pagos en Dolares
        Dim Monto_IR_PagadoUS, Monto_IR_Pagado_AlcaldiaUS, MontoIVAasumidoUS, MontoIRxPagarUS, SubTotalIRxPagarUS, _
        MontoIR_ALMAxPagarUS, SubTotalIR_ALMAxPagarUS As Double

        Dim MntoValor1, MntoValor2, TC1, TC2 As Double
        Dim SegundoIR As Boolean = False
        '        SegundoIR = False

        Dim i As Integer
        Dim fr As New frmPagoFacturas
        fr.etInicio.Text = "0"
        fr.MdiParent = Me.MdiParent
        'Dim fr As frmPlantillasBancos = fr.Instance
        'fr.MdiParent = Me.MdiParent

        MontoIVAasumido = 0
        SubTotal = 0
        FactValor = 0
        FactMnto = 0
        Fact = ""
        CompFact = ""

        '******************************************************************************************
        '*** VALIDA SI TIENEN ALGO SELECCIONADO
        '******************************************************************************************

        Dim Control As Boolean = False
        For i = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Control = True
                Exit For
            End If
            Control = False
        Next

        If Control = False Then
            MsgBox("Por favor seleccionar al menos una factura para pagar")
            Exit Sub
        End If

        '******************************************************************************************

        IRPagado = True

        For i = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Try
                    If CBool(Me.vFacturas.GetRowCellValue(i, "IR_Pagado")) = False Then
                        IRPagado = False
                    End If
                Catch ex As Exception
                    IRPagado = False
                    Exit For
                End Try
            End If
        Next

        For i = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Try
                    If CBool(Me.vFacturas.GetRowCellValue(i, "Iva_Asumido")) = True Then
                        IVAAsumido = True
                        Exit For
                    End If
                Catch ex As Exception
                    IVAAsumido = False
                End Try
            End If
        Next

        For i = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                Proveedor = Me.vFacturas.GetRowCellValue(i, "Codigo")
            End If
        Next

        Dim Muni As New VB.SysContab.MunicipiosDB
        Dim MunDet As VB.SysContab.MunicipioDetails = Muni.GetDetails(Prov.GetDetails(Proveedor).Departamento, Prov.GetDetails(Proveedor).Municipio)

        If Prov.GetDetails(Proveedor).Departamento = "0" And Prov.GetDetails(Proveedor).Municipio = "0" Then
            MsgBox("No se puede completar el Pago, por favor Ingrese Departamento o Municipio del Proveedor", MsgBoxStyle.Critical)
            Exit Sub
        End If

        For i = 0 To Me.vFacturas.RowCount - 1
            If vFacturas.GetRowCellValue(i, "Selecc") = True Then
                If Proveedor <> Me.vFacturas.GetRowCellValue(i, "Codigo") Then
                    MsgBox("No se puede pagar a Proveedores distintos en un mismo cheque.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                Fact = CStr(vFacturas.GetRowCellValue(i, "Factura")) & " | " & CStr(Fact)
                CompFact = vFacturas.GetRowCellValue(i, "Comp_No") & " | " & CompFact
                SaldoFact = vFacturas.GetRowCellValue(i, "Saldo") & " | " & SaldoFact
                FactPagar = (vFacturas.GetRowCellValue(i, "Pagar") - vFacturas.GetRowCellValue(i, "Mnto")) & " | " & FactPagar
                FactValor = vFacturas.GetRowCellValue(i, "Pagar") + FactValor
                FactMnto = vFacturas.GetRowCellValue(i, "Mnto") + FactMnto

                If CDbl(vFacturas.GetRowCellValue(i, "IVA")) > 0 Then
                    SubTotal = CDbl(vFacturas.GetRowCellValue(i, "Pagar") / ((ConfigDet.IVA / 100) + 1)) + SubTotal
                Else
                    SubTotal = CDbl(vFacturas.GetRowCellValue(i, "Pagar")) + SubTotal
                End If

                'fr.lblProv.Text = dgProveedores.Item(i, 4)
                'fr.lblProvID.Text = dgProveedores.Item(i, 3)
                'fr.etCodigoProveedor.Text = dgProveedores.Item(i, 11)

                fr.lblProv.Text = vFacturas.GetRowCellValue(i, "Nombre")
                fr.lblProvID.Text = vFacturas.GetRowCellValue(i, "Cuenta")
                fr.etCodigoProveedor.Text = vFacturas.GetRowCellValue(i, "Codigo")

                'fr.Comp_No = dgProveedores.Item(i, 12)
                'fr.Mes = dgProveedores.Item(i, 13)
                'fr.Per_ID = dgProveedores.Item(i, 14)
                'fr.FormaPago = dgProveedores.Item(i, 15)

                fr.Comp_No = vFacturas.GetRowCellValue(i, "Comp_No")
                fr.Mes = vFacturas.GetRowCellValue(i, "Mes")
                fr.Per_ID = vFacturas.GetRowCellValue(i, "Per_ID")
                fr.FormaPago = vFacturas.GetRowCellValue(i, "FormaPago_ID")

                Try
                    'fr.IVAAsumido = dgProveedores.Item(i, 18)
                    fr.IVAAsumido = vFacturas.GetRowCellValue(i, "Iva_Asumido")
                Catch ex As Exception
                    fr.IVAAsumido = False
                End Try

                fr.IR_Pagado_Alcaldia = IsNull(vFacturas.GetRowCellValue(i, "IR_Pagado_Alcaldia"), False)
                fr.IRPagado = IsNull(vFacturas.GetRowCellValue(i, "IR_Pagado"), False)

                If fr.IVAAsumido = True Then
                    MontoIVAasumido = SubTotal + MontoIVAasumido
                End If

                If fr.IR_Pagado_Alcaldia = True Then
                    If CDbl(vFacturas.GetRowCellValue(i, "Pagar") / (ConfigDet.IVA / 100 + 1)) >= MunDet.Impuesto_SVenta_Min Then
                        Monto_IR_Pagado_Alcaldia = SubTotal + Monto_IR_Pagado_Alcaldia
                    End If
                End If

                'MunDet.Impuesto_SVenta()

                'If fr.IRPagado = True And CDbl(GridView1.GetRowCellValue(i, "Monto")) >= Conf.GetConfigDetails().MontoIR Then
                '    Monto_IR_Pagado = SubTotal + Monto_IR_Pagado
                'End If

                If CDbl(vFacturas.GetRowCellValue(i, "IVA")) > 0 Then
                    If fr.IRPagado = True And CDbl(vFacturas.GetRowCellValue(i, "Pagar") / (ConfigDet.IVA / 100 + 1)) >= Conf.GetConfigDetails().MontoIR Then
                        Monto_IR_Pagado = SubTotal + Monto_IR_Pagado
                    End If
                Else
                    If fr.IRPagado = True And CDbl(vFacturas.GetRowCellValue(i, "Pagar")) >= Conf.GetConfigDetails().MontoIR Then
                        Monto_IR_Pagado = SubTotal + Monto_IR_Pagado
                    End If
                End If

                '
                Try
                    fr.IRPagado = vFacturas.GetRowCellValue(i, "IR_Pagado")
                Catch ex As Exception
                    fr.IRPagado = False
                End Try

                If fr.IRPagado = False Then
                    'If CDbl(GridView1.GetRowCellValue(i, "Monto")) >= Conf.GetConfigDetails().MontoIR And CBool(Prov.GetDetails(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Codigo")).Exento) = False Then
                    If CDbl(vFacturas.GetRowCellValue(i, "IVA")) > 0 Then
                        If CDbl(vFacturas.GetRowCellValue(i, "Pagar") / (ConfigDet.IVA / 100 + 1)) >= Conf.GetConfigDetails().MontoIR And CBool(Prov.GetDetails(vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "Codigo")).Exento) = False Then
                            MontoIRxPagar = FactValor + MontoIRxPagar
                            SubTotalIRxPagar = SubTotalIRxPagar + CDbl(vFacturas.GetRowCellValue(i, "Pagar") / (ConfigDet.IVA / 100 + 1))
                        End If
                    Else
                        If CDbl(vFacturas.GetRowCellValue(i, "Pagar")) >= Conf.GetConfigDetails().MontoIR And CBool(Prov.GetDetails(vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "Codigo")).Exento) = False Then
                            MontoIRxPagar = FactValor + MontoIRxPagar
                            SubTotalIRxPagar = SubTotalIRxPagar + CDbl(vFacturas.GetRowCellValue(i, "Pagar"))
                        End If
                    End If
                Else
                    If SegundoIR = False Then
                        SegundoIR = True
                    End If
                End If

                If fr.IR_Pagado_Alcaldia = False Then
                    If CDbl(vFacturas.GetRowCellValue(i, "IVA")) > 0 Then
                        If CDbl(vFacturas.GetRowCellValue(i, "Pagar") / (ConfigDet.IVA / 100 + 1)) >= MunDet.Impuesto_SVenta_Min And CBool(Prov.GetDetails(vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "Codigo")).Exento) = False Then
                            MontoIR_ALMAxPagar = FactValor + MontoIR_ALMAxPagar
                            SubTotalIR_ALMAxPagar = SubTotalIR_ALMAxPagar + CDbl(vFacturas.GetRowCellValue(i, "Pagar") / (ConfigDet.IVA / 100 + 1))
                        End If
                    Else
                        If CDbl(vFacturas.GetRowCellValue(i, "Pagar")) >= MunDet.Impuesto_SVenta_Min And CBool(Prov.GetDetails(vFacturas.GetRowCellValue(vFacturas.FocusedRowHandle, "Codigo")).Exento) = False Then
                            MontoIR_ALMAxPagar = FactValor + MontoIR_ALMAxPagar
                            SubTotalIR_ALMAxPagar = SubTotalIR_ALMAxPagar + CDbl(vFacturas.GetRowCellValue(i, "Pagar"))
                        End If
                    End If
                End If

                fr.etFecha.Text = vFacturas.GetRowCellValue(i, "Fecha")
            End If
        Next

        Fact = Fact.Substring(0, Fact.Length - 3)
        CompFact = CompFact.Substring(0, CompFact.Length - 3)

        fr.CompFact = CompFact
        fr.SaldoFact = SaldoFact
        fr.FactPagar = FactPagar
        fr.SegundoIR = SegundoIR
        fr.Fecha.DateTime = Me.fecha.DateTime
        fr.TasaPago = Me.txtTasa.EditValue

        fr.lblFact.Text = Fact
        fr.lblFactMonto.Text = FactValor
        fr.FactMnto = FactMnto

        fr.SubTotal = SubTotal

        fr.IVAAsumido = IVAAsumido
        fr.IRPagado = IRPagado

        fr.MontoIVAasumido = MontoIVAasumido
        fr.Monto_IR_Pagado_Alcaldia = Monto_IR_Pagado_Alcaldia
        fr.Monto_IR_Pagado = Monto_IR_Pagado
        fr.MontoIRxPagar = MontoIRxPagar
        fr.SubTotalIRxPagar = SubTotalIRxPagar
        fr.MontoIR_ALMAxPagar = MontoIR_ALMAxPagar
        fr.SubTotalIR_ALMAxPagar = SubTotalIR_ALMAxPagar
        fr.Show()
        fr.WindowState = FormWindowState.Maximized
        fr.etInicio.Text = "1"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub frmListaFacturaProveedores_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        VB.SysContab.Rutinas.OcultarMenu(FormPrincipal)
    End Sub

    Private Sub dgFacturasProveedores_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VB.SysContab.Rutinas.OcultarMenu(FormPrincipal)
    End Sub


    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If lblTipoProv.Text = 0 Then
            Help.ShowHelp(Me, "ayuda/ProcesosEfectuarPagos.chm", HelpNavigator.KeywordIndex, "Productos")
        Else
            Help.ShowHelp(Me, "ayuda/ProcesosEfectuarPagos.chm", HelpNavigator.KeywordIndex, "Servicios")
        End If
    End Sub

    Private Sub fecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecha.EditValueChanged
        If etInicio.Text = "1" Then
            Cargar()
            Me.txtTasa.EditValue = VB.SysContab.Rutinas.TasaCambio(Me.fecha.DateTime.Date)
        End If
    End Sub

    Private Sub vFacturas_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles vFacturas.CellValueChanged
        If e.Column.FieldName = "Pagar" Then
            If e.Value <= 0 Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Introduzca una Cantidad Mayor que Cero (0)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Not Temp Then
                    Temp = True
                    Me.vFacturas.SetRowCellValue(e.RowHandle, "PagarU", Math.Round(CDbl(e.Value / Me.txtTasa.EditValue), 2))
                    If Me.vFacturas.GetRowCellValue(e.RowHandle, "Moneda") <> MonedaBase Then
                        Dim Mnto As Double = VB.SysContab.Facturas_ComprasDB.GetMntoCompras(Me.vFacturas.GetRowCellValue(e.RowHandle, "Fecha"), _
                                                                                            Me.fecha.DateTime.Date, Math.Round(CDbl(e.Value / Me.txtTasa.EditValue), 4), _
                                                                                            Me.vFacturas.GetRowCellValue(e.RowHandle, "Moneda"))
                        Me.vFacturas.SetRowCellValue(e.RowHandle, "Mnto", Mnto)
                    End If
                    Temp = False
                End If
            End If
        End If

        If e.Column.FieldName = "PagarU" Then
            If e.Value <= 0 Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Introduzca una Cantidad Mayor que Cero (0)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Not Temp Then
                    Temp = True
                    Me.vFacturas.SetRowCellValue(e.RowHandle, "Pagar", Math.Round(CDbl(e.Value * Me.txtTasa.EditValue), 2))
                    If Me.vFacturas.GetRowCellValue(e.RowHandle, "Moneda") <> MonedaBase Then
                        Dim Mnto As Double = VB.SysContab.Facturas_ComprasDB.GetMntoCompras(Me.vFacturas.GetRowCellValue(e.RowHandle, "Fecha"), _
                                                                                            Me.fecha.DateTime.Date, e.Value, _
                                                                                            Me.vFacturas.GetRowCellValue(e.RowHandle, "Moneda"))
                        Me.vFacturas.SetRowCellValue(e.RowHandle, "Mnto", Mnto)
                    End If
                    Temp = False
                End If
            End If
        End If

    End Sub

    Private Sub txtTasa_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTasa.Validating
        If etInicio.Text = "1" Then Cargar()
    End Sub
End Class
