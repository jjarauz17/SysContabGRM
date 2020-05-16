<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarComprobante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportarComprobante))
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.cRequired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WizardControl1 = New DevExpress.XtraWizard.WizardControl()
        Me.WelcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
        Me.WizardPage1 = New DevExpress.XtraWizard.WizardPage()
        Me.ListBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
        Me.ckLetras = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.WizardPage2 = New DevExpress.XtraWizard.WizardPage()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.igridControl = New DevExpress.XtraGrid.GridControl()
        Me.iGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cFields = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemColumns = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WizardControl1.SuspendLayout()
        Me.WizardPage1.SuspendLayout()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompletionWizardPage1.SuspendLayout()
        CType(Me.ckLetras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WizardPage2.SuspendLayout()
        CType(Me.igridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cRequired
        '
        Me.cRequired.Caption = "Requerido"
        Me.cRequired.FieldName = "Required"
        Me.cRequired.Name = "cRequired"
        '
        'WizardControl1
        '
        Me.WizardControl1.Controls.Add(Me.WelcomeWizardPage1)
        Me.WizardControl1.Controls.Add(Me.WizardPage1)
        Me.WizardControl1.Controls.Add(Me.CompletionWizardPage1)
        Me.WizardControl1.Controls.Add(Me.WizardPage2)
        Me.WizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WizardControl1.Location = New System.Drawing.Point(0, 0)
        Me.WizardControl1.Name = "WizardControl1"
        Me.WizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.WelcomeWizardPage1, Me.WizardPage1, Me.WizardPage2, Me.CompletionWizardPage1})
        Me.WizardControl1.Size = New System.Drawing.Size(936, 498)
        '
        'WelcomeWizardPage1
        '
        Me.WelcomeWizardPage1.IntroductionText = resources.GetString("WelcomeWizardPage1.IntroductionText")
        Me.WelcomeWizardPage1.Name = "WelcomeWizardPage1"
        Me.WelcomeWizardPage1.ProceedText = "Para Continuar, Click en Siguiente..."
        Me.WelcomeWizardPage1.Size = New System.Drawing.Size(719, 365)
        Me.WelcomeWizardPage1.Text = "Bienvenido al Asistente de Importacion de Datos"
        '
        'WizardPage1
        '
        Me.WizardPage1.Controls.Add(Me.ListBoxControl1)
        Me.WizardPage1.Controls.Add(Me.SimpleButton1)
        Me.WizardPage1.DescriptionText = "Por favor elija un archivo para importar, y luego definir la Hoja de usar"
        Me.WizardPage1.Name = "WizardPage1"
        Me.WizardPage1.Size = New System.Drawing.Size(904, 353)
        Me.WizardPage1.Text = "1. Seleccione Hja de Calculo de Microsoft Excel"
        '
        'ListBoxControl1
        '
        Me.ListBoxControl1.Location = New System.Drawing.Point(16, 43)
        Me.ListBoxControl1.Name = "ListBoxControl1"
        Me.ListBoxControl1.Size = New System.Drawing.Size(885, 296)
        Me.ListBoxControl1.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(16, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(135, 34)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Seleccionar Archivo"
        '
        'CompletionWizardPage1
        '
        Me.CompletionWizardPage1.Controls.Add(Me.ckLetras)
        Me.CompletionWizardPage1.Controls.Add(Me.LabelControl3)
        Me.CompletionWizardPage1.FinishText = "Ha completado correctamente el asistente"
        Me.CompletionWizardPage1.Name = "CompletionWizardPage1"
        Me.CompletionWizardPage1.ProceedText = "Para cerrar el Asistente, click en Finalizar"
        Me.CompletionWizardPage1.Size = New System.Drawing.Size(719, 365)
        Me.CompletionWizardPage1.Text = "Completar el Asistente"
        '
        'ckLetras
        '
        Me.ckLetras.Location = New System.Drawing.Point(641, 492)
        Me.ckLetras.Name = "ckLetras"
        Me.ckLetras.Properties.Caption = "Letras"
        Me.ckLetras.Size = New System.Drawing.Size(75, 15)
        Me.ckLetras.TabIndex = 13
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(3, 43)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "LabelControl3"
        '
        'WizardPage2
        '
        Me.WizardPage2.Controls.Add(Me.LabelControl1)
        Me.WizardPage2.Controls.Add(Me.SimpleButton2)
        Me.WizardPage2.Controls.Add(Me.igridControl)
        Me.WizardPage2.DescriptionText = "Complete la asignación de columnas a los campos"
        Me.WizardPage2.Name = "WizardPage2"
        Me.WizardPage2.Size = New System.Drawing.Size(904, 353)
        Me.WizardPage2.Text = "Asignación de columnas"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "LabelControl1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(798, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(92, 25)
        Me.SimpleButton2.TabIndex = 10
        Me.SimpleButton2.Text = "&Ver Archivo"
        '
        'igridControl
        '
        Me.igridControl.Location = New System.Drawing.Point(14, 39)
        Me.igridControl.MainView = Me.iGridView
        Me.igridControl.Name = "igridControl"
        Me.igridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemColumns})
        Me.igridControl.Size = New System.Drawing.Size(876, 311)
        Me.igridControl.TabIndex = 0
        Me.igridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.iGridView})
        '
        'iGridView
        '
        Me.iGridView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iGridView.Appearance.HeaderPanel.Options.UseFont = True
        Me.iGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.iGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.iGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cFields, Me.GridColumn2, Me.GridColumn6, Me.GridColumn7, Me.cRequired})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.cRequired
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Expression = "[Required] == True"
        StyleFormatCondition2.Value1 = True
        Me.iGridView.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.iGridView.GridControl = Me.igridControl
        Me.iGridView.Name = "iGridView"
        Me.iGridView.OptionsView.ShowAutoFilterRow = True
        Me.iGridView.OptionsView.ShowGroupPanel = False
        '
        'cFields
        '
        Me.cFields.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cFields.AppearanceCell.Options.UseBackColor = True
        Me.cFields.Caption = "Campos"
        Me.cFields.FieldName = "Fields"
        Me.cFields.Name = "cFields"
        Me.cFields.OptionsColumn.AllowEdit = False
        Me.cFields.Visible = True
        Me.cFields.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Asignar Columna"
        Me.GridColumn2.ColumnEdit = Me.ItemColumns
        Me.GridColumn2.FieldName = "AsignColumn"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'ItemColumns
        '
        Me.ItemColumns.AutoHeight = False
        Me.ItemColumns.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemColumns.Name = "ItemColumns"
        Me.ItemColumns.NullText = ""
        Me.ItemColumns.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridColumn6.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn6.Caption = "Ejmplo"
        Me.GridColumn6.FieldName = "Sample"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GridColumn7.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn7.Caption = "Tipo de Dato"
        Me.GridColumn7.FieldName = "Type"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmImportarComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 498)
        Me.Controls.Add(Me.WizardControl1)
        Me.Name = "frmImportarComprobante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Datos desde Excel..."
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WizardControl1.ResumeLayout(False)
        Me.WizardPage1.ResumeLayout(False)
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompletionWizardPage1.ResumeLayout(False)
        Me.CompletionWizardPage1.PerformLayout()
        CType(Me.ckLetras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WizardPage2.ResumeLayout(False)
        Me.WizardPage2.PerformLayout()
        CType(Me.igridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WizardControl1 As DevExpress.XtraWizard.WizardControl
    Friend WithEvents WelcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
    Friend WithEvents WizardPage1 As DevExpress.XtraWizard.WizardPage
    Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents WizardPage2 As DevExpress.XtraWizard.WizardPage
    Friend WithEvents igridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents iGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cFields As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemColumns As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckLetras As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cRequired As DevExpress.XtraGrid.Columns.GridColumn
End Class
