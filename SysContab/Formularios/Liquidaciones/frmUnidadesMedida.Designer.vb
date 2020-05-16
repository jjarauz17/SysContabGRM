<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnidadesMedida
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.tbName = New DevExpress.XtraEditors.TextEdit
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MedidaID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MedNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MedCod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.tbCorto = New DevExpress.XtraEditors.TextEdit
        CType(Me.tbName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCorto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nombre"
        '
        'tbName
        '
        Me.tbName.Enabled = False
        Me.tbName.EnterMoveNextControl = True
        Me.tbName.Location = New System.Drawing.Point(58, 11)
        Me.tbName.Name = "tbName"
        Me.tbName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tbName.Properties.Appearance.Options.UseFont = True
        Me.tbName.Size = New System.Drawing.Size(238, 21)
        Me.tbName.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 71)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(800, 395)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MedidaID, Me.MedNombre, Me.MedCod})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'MedidaID
        '
        Me.MedidaID.Caption = "MedidaID"
        Me.MedidaID.FieldName = "MedidaID"
        Me.MedidaID.Name = "MedidaID"
        '
        'MedNombre
        '
        Me.MedNombre.Caption = "Nombre"
        Me.MedNombre.FieldName = "MedNombre"
        Me.MedNombre.Name = "MedNombre"
        Me.MedNombre.Visible = True
        Me.MedNombre.VisibleIndex = 0
        Me.MedNombre.Width = 163
        '
        'MedCod
        '
        Me.MedCod.Caption = "Corto"
        Me.MedCod.FieldName = "MedCod"
        Me.MedCod.Name = "MedCod"
        Me.MedCod.Visible = True
        Me.MedCod.VisibleIndex = 1
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AccessibleName = "Liquidacion"
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'cmdNew
        '
        Me.cmdNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNew.Location = New System.Drawing.Point(571, 42)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 23)
        Me.cmdNew.TabIndex = 6
        Me.cmdNew.Text = "&Nuevo"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Location = New System.Drawing.Point(737, 42)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 8
        Me.cmdExit.Text = "&Salir"
        '
        'cmdEdit
        '
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Location = New System.Drawing.Point(656, 42)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 7
        Me.cmdEdit.Text = "&Editar"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 42)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Corto"
        '
        'tbCorto
        '
        Me.tbCorto.EditValue = ""
        Me.tbCorto.Enabled = False
        Me.tbCorto.EnterMoveNextControl = True
        Me.tbCorto.Location = New System.Drawing.Point(58, 38)
        Me.tbCorto.Name = "tbCorto"
        Me.tbCorto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tbCorto.Properties.Appearance.Options.UseFont = True
        Me.tbCorto.Properties.Mask.EditMask = "N2"
        Me.tbCorto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbCorto.Size = New System.Drawing.Size(69, 21)
        Me.tbCorto.TabIndex = 4
        '
        'frmUnidadesMedida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 478)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.tbCorto)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmUnidadesMedida"
        Me.Text = "Listado de Tarifas"
        CType(Me.tbName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCorto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbCorto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MedidaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MedNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MedCod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
