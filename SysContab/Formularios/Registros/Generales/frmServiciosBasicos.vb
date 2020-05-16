Imports System.Data.SqlClient
Public Class frmServiciosBasicos
    Inherits DevExpress.XtraEditors.XtraForm

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
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SBBasura As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBEnergia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBAgua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcBasura As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVBasura As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bConsecutivo_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bSer_Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bSer_CuentaProvision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bSer_CuentaGasto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bSer_CtaIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcEnergia As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVEnergia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents eConsecutivo_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents eSer_Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents eSer_CuentaProvision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents eSer_CuentaGasto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents eSer_CtaIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAgua As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVAgua As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Consecutivo_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ser_Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ser_CuentaProvision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Ser_CuentaGasto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ser_CtaIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SBTVCable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBCelular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBTelefono As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcTVCable As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTVCable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tvConsecutivo_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tvSer_Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tvSer_CuentaProvision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tvSer_CuentaGasto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tvSer_CtaIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCelular As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCelular As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cConsecutivo_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cSer_Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cSer_CuentaProvision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cSer_CuentaGasto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cSer_CtaIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTelefono As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTelefono As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tConsecutivo_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tSer_Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tSer_CuentaProvision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tSer_CuentaGasto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tSer_CtaIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.SBBasura = New DevExpress.XtraEditors.SimpleButton
        Me.SBEnergia = New DevExpress.XtraEditors.SimpleButton
        Me.SBAgua = New DevExpress.XtraEditors.SimpleButton
        Me.gcBasura = New DevExpress.XtraGrid.GridControl
        Me.GVBasura = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.bConsecutivo_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bSer_Descripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bSer_CuentaProvision = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.bSer_CuentaGasto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bSer_CtaIR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcEnergia = New DevExpress.XtraGrid.GridControl
        Me.GVEnergia = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.eConsecutivo_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.eSer_Descripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.eSer_CuentaProvision = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.eSer_CuentaGasto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.eSer_CtaIR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcAgua = New DevExpress.XtraGrid.GridControl
        Me.GVAgua = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Consecutivo_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Ser_Descripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Ser_CuentaProvision = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Ser_CuentaGasto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Ser_CtaIR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl
        Me.SBTVCable = New DevExpress.XtraEditors.SimpleButton
        Me.SBCelular = New DevExpress.XtraEditors.SimpleButton
        Me.SBTelefono = New DevExpress.XtraEditors.SimpleButton
        Me.gcTVCable = New DevExpress.XtraGrid.GridControl
        Me.gvTVCable = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tvConsecutivo_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tvSer_Descripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tvSer_CuentaProvision = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tvSer_CuentaGasto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tvSer_CtaIR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcCelular = New DevExpress.XtraGrid.GridControl
        Me.gvCelular = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cConsecutivo_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cSer_Descripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cSer_CuentaProvision = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cSer_CuentaGasto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cSer_CtaIR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcTelefono = New DevExpress.XtraGrid.GridControl
        Me.gvTelefono = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tConsecutivo_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tSer_Descripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tSer_CuentaProvision = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tSer_CuentaGasto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tSer_CtaIR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.GroupBox2.SuspendLayout()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.gcBasura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVBasura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcEnergia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVEnergia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAgua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVAgua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.gcTVCable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTVCable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCelular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCelular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(8, 17)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(792, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 536)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 92)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(636, 33)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 5)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(760, 531)
        Me.XtraTabControl1.TabIndex = 157
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LayoutControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(751, 500)
        Me.XtraTabPage1.Text = "Agua - Energia - Basura"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LayoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = True
        Me.LayoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LayoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = True
        Me.LayoutControl1.Controls.Add(Me.SBBasura)
        Me.LayoutControl1.Controls.Add(Me.SBEnergia)
        Me.LayoutControl1.Controls.Add(Me.SBAgua)
        Me.LayoutControl1.Controls.Add(Me.gcBasura)
        Me.LayoutControl1.Controls.Add(Me.gcEnergia)
        Me.LayoutControl1.Controls.Add(Me.gcAgua)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.HighlightFocusedItem = True
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(751, 500)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SBBasura
        '
        Me.SBBasura.Location = New System.Drawing.Point(659, 469)
        Me.SBBasura.Name = "SBBasura"
        Me.SBBasura.Size = New System.Drawing.Size(83, 22)
        Me.SBBasura.StyleController = Me.LayoutControl1
        Me.SBBasura.TabIndex = 9
        Me.SBBasura.Text = "Guardar"
        '
        'SBEnergia
        '
        Me.SBEnergia.Location = New System.Drawing.Point(659, 283)
        Me.SBEnergia.Name = "SBEnergia"
        Me.SBEnergia.Size = New System.Drawing.Size(83, 22)
        Me.SBEnergia.StyleController = Me.LayoutControl1
        Me.SBEnergia.TabIndex = 8
        Me.SBEnergia.Text = "Guardar"
        '
        'SBAgua
        '
        Me.SBAgua.Location = New System.Drawing.Point(659, 132)
        Me.SBAgua.Name = "SBAgua"
        Me.SBAgua.Size = New System.Drawing.Size(83, 22)
        Me.SBAgua.StyleController = Me.LayoutControl1
        Me.SBAgua.TabIndex = 7
        Me.SBAgua.Text = "Guardar"
        '
        'gcBasura
        '
        Me.gcBasura.Location = New System.Drawing.Point(10, 340)
        Me.gcBasura.MainView = Me.GVBasura
        Me.gcBasura.Name = "gcBasura"
        Me.gcBasura.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit3})
        Me.gcBasura.Size = New System.Drawing.Size(732, 118)
        Me.gcBasura.TabIndex = 6
        Me.gcBasura.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVBasura})
        '
        'GVBasura
        '
        Me.GVBasura.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.bConsecutivo_ID, Me.bSer_Descripcion, Me.bSer_CuentaProvision, Me.bSer_CuentaGasto, Me.bSer_CtaIR})
        Me.GVBasura.GridControl = Me.gcBasura
        Me.GVBasura.Name = "GVBasura"
        Me.GVBasura.OptionsView.ShowGroupPanel = False
        '
        'bConsecutivo_ID
        '
        Me.bConsecutivo_ID.Caption = "Consecutivo_ID"
        Me.bConsecutivo_ID.FieldName = "Consecutivo_ID"
        Me.bConsecutivo_ID.Name = "bConsecutivo_ID"
        Me.bConsecutivo_ID.Visible = True
        Me.bConsecutivo_ID.VisibleIndex = 0
        Me.bConsecutivo_ID.Width = 100
        '
        'bSer_Descripcion
        '
        Me.bSer_Descripcion.Caption = "Descripción"
        Me.bSer_Descripcion.FieldName = "Ser_Descripcion"
        Me.bSer_Descripcion.Name = "bSer_Descripcion"
        Me.bSer_Descripcion.Visible = True
        Me.bSer_Descripcion.VisibleIndex = 1
        Me.bSer_Descripcion.Width = 200
        '
        'bSer_CuentaProvision
        '
        Me.bSer_CuentaProvision.Caption = "Cuenta IVA"
        Me.bSer_CuentaProvision.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.bSer_CuentaProvision.Name = "bSer_CuentaProvision"
        Me.bSer_CuentaProvision.Visible = True
        Me.bSer_CuentaProvision.VisibleIndex = 2
        Me.bSer_CuentaProvision.Width = 198
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUENTA", "Código", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", 198, "Nombre")})
        Me.RepositoryItemLookUpEdit3.DisplayMember = "NOMBRE"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.ShowFooter = False
        Me.RepositoryItemLookUpEdit3.ValueMember = "CUENTA"
        '
        'bSer_CuentaGasto
        '
        Me.bSer_CuentaGasto.Caption = "Cuenta Gasto"
        Me.bSer_CuentaGasto.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.bSer_CuentaGasto.FieldName = "Ser_CuentaGasto"
        Me.bSer_CuentaGasto.Name = "bSer_CuentaGasto"
        Me.bSer_CuentaGasto.Visible = True
        Me.bSer_CuentaGasto.VisibleIndex = 3
        Me.bSer_CuentaGasto.Width = 198
        '
        'bSer_CtaIR
        '
        Me.bSer_CtaIR.Caption = "Cuenta IR"
        Me.bSer_CtaIR.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.bSer_CtaIR.FieldName = "Ser_CtaIR"
        Me.bSer_CtaIR.Name = "bSer_CtaIR"
        Me.bSer_CtaIR.Visible = True
        Me.bSer_CtaIR.VisibleIndex = 4
        '
        'gcEnergia
        '
        Me.gcEnergia.Location = New System.Drawing.Point(10, 189)
        Me.gcEnergia.MainView = Me.GVEnergia
        Me.gcEnergia.Name = "gcEnergia"
        Me.gcEnergia.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2})
        Me.gcEnergia.Size = New System.Drawing.Size(732, 83)
        Me.gcEnergia.TabIndex = 5
        Me.gcEnergia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVEnergia})
        '
        'GVEnergia
        '
        Me.GVEnergia.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.eConsecutivo_ID, Me.eSer_Descripcion, Me.eSer_CuentaProvision, Me.eSer_CuentaGasto, Me.eSer_CtaIR})
        Me.GVEnergia.GridControl = Me.gcEnergia
        Me.GVEnergia.Name = "GVEnergia"
        Me.GVEnergia.OptionsView.ShowGroupPanel = False
        '
        'eConsecutivo_ID
        '
        Me.eConsecutivo_ID.Caption = "Consecutivo_ID"
        Me.eConsecutivo_ID.FieldName = "Consecutivo_ID"
        Me.eConsecutivo_ID.Name = "eConsecutivo_ID"
        Me.eConsecutivo_ID.Visible = True
        Me.eConsecutivo_ID.VisibleIndex = 0
        Me.eConsecutivo_ID.Width = 100
        '
        'eSer_Descripcion
        '
        Me.eSer_Descripcion.Caption = "Descripción"
        Me.eSer_Descripcion.FieldName = "Ser_Descripcion"
        Me.eSer_Descripcion.Name = "eSer_Descripcion"
        Me.eSer_Descripcion.Visible = True
        Me.eSer_Descripcion.VisibleIndex = 1
        Me.eSer_Descripcion.Width = 200
        '
        'eSer_CuentaProvision
        '
        Me.eSer_CuentaProvision.Caption = "Cuenta IVA"
        Me.eSer_CuentaProvision.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.eSer_CuentaProvision.FieldName = "Ser_CuentaProvision"
        Me.eSer_CuentaProvision.Name = "eSer_CuentaProvision"
        Me.eSer_CuentaProvision.Visible = True
        Me.eSer_CuentaProvision.VisibleIndex = 2
        Me.eSer_CuentaProvision.Width = 198
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUENTA", "Código", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", 198, "Nombre")})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "NOMBRE"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ShowFooter = False
        Me.RepositoryItemLookUpEdit2.ValueMember = "CUENTA"
        '
        'eSer_CuentaGasto
        '
        Me.eSer_CuentaGasto.Caption = "Cuenta Gasto"
        Me.eSer_CuentaGasto.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.eSer_CuentaGasto.FieldName = "Ser_CuentaGasto"
        Me.eSer_CuentaGasto.Name = "eSer_CuentaGasto"
        Me.eSer_CuentaGasto.Visible = True
        Me.eSer_CuentaGasto.VisibleIndex = 3
        Me.eSer_CuentaGasto.Width = 198
        '
        'eSer_CtaIR
        '
        Me.eSer_CtaIR.Caption = "Cuenta IR"
        Me.eSer_CtaIR.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.eSer_CtaIR.FieldName = "Ser_CtaIR"
        Me.eSer_CtaIR.Name = "eSer_CtaIR"
        Me.eSer_CtaIR.Visible = True
        Me.eSer_CtaIR.VisibleIndex = 4
        '
        'gcAgua
        '
        Me.gcAgua.Location = New System.Drawing.Point(10, 28)
        Me.gcAgua.MainView = Me.GVAgua
        Me.gcAgua.Name = "gcAgua"
        Me.gcAgua.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.gcAgua.Size = New System.Drawing.Size(732, 93)
        Me.gcAgua.TabIndex = 4
        Me.gcAgua.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVAgua})
        '
        'GVAgua
        '
        Me.GVAgua.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Consecutivo_ID, Me.Ser_Descripcion, Me.Ser_CuentaProvision, Me.Ser_CuentaGasto, Me.Ser_CtaIR})
        Me.GVAgua.GridControl = Me.gcAgua
        Me.GVAgua.Name = "GVAgua"
        Me.GVAgua.OptionsView.ShowGroupPanel = False
        '
        'Consecutivo_ID
        '
        Me.Consecutivo_ID.Caption = "Consecutivo_ID"
        Me.Consecutivo_ID.FieldName = "Consecutivo_ID"
        Me.Consecutivo_ID.Name = "Consecutivo_ID"
        Me.Consecutivo_ID.OptionsColumn.AllowEdit = False
        Me.Consecutivo_ID.Visible = True
        Me.Consecutivo_ID.VisibleIndex = 0
        Me.Consecutivo_ID.Width = 100
        '
        'Ser_Descripcion
        '
        Me.Ser_Descripcion.Caption = "Descripción"
        Me.Ser_Descripcion.FieldName = "Ser_Descripcion"
        Me.Ser_Descripcion.Name = "Ser_Descripcion"
        Me.Ser_Descripcion.Visible = True
        Me.Ser_Descripcion.VisibleIndex = 1
        Me.Ser_Descripcion.Width = 200
        '
        'Ser_CuentaProvision
        '
        Me.Ser_CuentaProvision.Caption = "Cuenta IVA"
        Me.Ser_CuentaProvision.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.Ser_CuentaProvision.FieldName = "Ser_CuentaProvision"
        Me.Ser_CuentaProvision.Name = "Ser_CuentaProvision"
        Me.Ser_CuentaProvision.OptionsColumn.AllowMove = False
        Me.Ser_CuentaProvision.Visible = True
        Me.Ser_CuentaProvision.VisibleIndex = 2
        Me.Ser_CuentaProvision.Width = 198
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUENTA", "Código", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", 198, "Nombre")})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "NOMBRE"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ShowFooter = False
        Me.RepositoryItemLookUpEdit1.ShowHeader = False
        Me.RepositoryItemLookUpEdit1.ValueMember = "CUENTA"
        '
        'Ser_CuentaGasto
        '
        Me.Ser_CuentaGasto.Caption = "Cuenta Gasto"
        Me.Ser_CuentaGasto.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.Ser_CuentaGasto.FieldName = "Ser_CuentaGasto"
        Me.Ser_CuentaGasto.Name = "Ser_CuentaGasto"
        Me.Ser_CuentaGasto.OptionsColumn.AllowMove = False
        Me.Ser_CuentaGasto.Visible = True
        Me.Ser_CuentaGasto.VisibleIndex = 3
        Me.Ser_CuentaGasto.Width = 198
        '
        'Ser_CtaIR
        '
        Me.Ser_CtaIR.Caption = "Cuenta IR"
        Me.Ser_CtaIR.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.Ser_CtaIR.FieldName = "Ser_CtaIR"
        Me.Ser_CtaIR.Name = "Ser_CtaIR"
        Me.Ser_CtaIR.Visible = True
        Me.Ser_CtaIR.VisibleIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(751, 500)
        Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Servicio de Agua"
        Me.LayoutControlGroup2.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutControlGroup2.ExpandButtonVisible = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(749, 161)
        Me.LayoutControlGroup2.Text = "Servicio de Agua"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gcAgua
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(743, 104)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SBAgua
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(649, 104)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(94, 33)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 104)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(649, 33)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Servicio de Energía"
        Me.LayoutControlGroup3.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutControlGroup3.ExpandButtonVisible = True
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem2, Me.EmptySpaceItem3})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 161)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(749, 151)
        Me.LayoutControlGroup3.Text = "Servicio de Energía"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SBEnergia
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(649, 94)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(94, 33)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.gcEnergia
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(743, 94)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 94)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(649, 33)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "Servicio de Basura"
        Me.LayoutControlGroup4.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutControlGroup4.ExpandButtonVisible = True
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem6, Me.EmptySpaceItem4})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 312)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(749, 186)
        Me.LayoutControlGroup4.Text = "Servicio de Basura"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.gcBasura
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(743, 129)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SBBasura
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(649, 129)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(94, 33)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 129)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(649, 33)
        Me.EmptySpaceItem4.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LayoutControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(751, 500)
        Me.XtraTabPage2.Text = "Teléfono -Celular - TV Cable"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LayoutControl2.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = True
        Me.LayoutControl2.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LayoutControl2.Appearance.DisabledLayoutItem.Options.UseForeColor = True
        Me.LayoutControl2.Controls.Add(Me.SBTVCable)
        Me.LayoutControl2.Controls.Add(Me.SBCelular)
        Me.LayoutControl2.Controls.Add(Me.SBTelefono)
        Me.LayoutControl2.Controls.Add(Me.gcTVCable)
        Me.LayoutControl2.Controls.Add(Me.gcCelular)
        Me.LayoutControl2.Controls.Add(Me.gcTelefono)
        Me.LayoutControl2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LayoutControl2.Location = New System.Drawing.Point(8, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsView.HighlightFocusedItem = True
        Me.LayoutControl2.Root = Me.LayoutControlGroup5
        Me.LayoutControl2.Size = New System.Drawing.Size(736, 500)
        Me.LayoutControl2.TabIndex = 1
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SBTVCable
        '
        Me.SBTVCable.Location = New System.Drawing.Point(646, 469)
        Me.SBTVCable.Name = "SBTVCable"
        Me.SBTVCable.Size = New System.Drawing.Size(81, 22)
        Me.SBTVCable.StyleController = Me.LayoutControl2
        Me.SBTVCable.TabIndex = 9
        Me.SBTVCable.Text = "Guardar"
        '
        'SBCelular
        '
        Me.SBCelular.Location = New System.Drawing.Point(646, 300)
        Me.SBCelular.Name = "SBCelular"
        Me.SBCelular.Size = New System.Drawing.Size(81, 22)
        Me.SBCelular.StyleController = Me.LayoutControl2
        Me.SBCelular.TabIndex = 8
        Me.SBCelular.Text = "Guardar"
        '
        'SBTelefono
        '
        Me.SBTelefono.Location = New System.Drawing.Point(646, 134)
        Me.SBTelefono.Name = "SBTelefono"
        Me.SBTelefono.Size = New System.Drawing.Size(81, 22)
        Me.SBTelefono.StyleController = Me.LayoutControl2
        Me.SBTelefono.TabIndex = 7
        Me.SBTelefono.Text = "Guardar"
        '
        'gcTVCable
        '
        Me.gcTVCable.Location = New System.Drawing.Point(10, 357)
        Me.gcTVCable.MainView = Me.gvTVCable
        Me.gcTVCable.Name = "gcTVCable"
        Me.gcTVCable.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit4})
        Me.gcTVCable.Size = New System.Drawing.Size(717, 101)
        Me.gcTVCable.TabIndex = 6
        Me.gcTVCable.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTVCable})
        '
        'gvTVCable
        '
        Me.gvTVCable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tvConsecutivo_ID, Me.tvSer_Descripcion, Me.tvSer_CuentaProvision, Me.tvSer_CuentaGasto, Me.tvSer_CtaIR})
        Me.gvTVCable.GridControl = Me.gcTVCable
        Me.gvTVCable.Name = "gvTVCable"
        Me.gvTVCable.OptionsView.ShowGroupPanel = False
        '
        'tvConsecutivo_ID
        '
        Me.tvConsecutivo_ID.Caption = "Consecutivo_ID"
        Me.tvConsecutivo_ID.FieldName = "Consecutivo_ID"
        Me.tvConsecutivo_ID.Name = "tvConsecutivo_ID"
        Me.tvConsecutivo_ID.Visible = True
        Me.tvConsecutivo_ID.VisibleIndex = 0
        Me.tvConsecutivo_ID.Width = 100
        '
        'tvSer_Descripcion
        '
        Me.tvSer_Descripcion.Caption = "Descripción"
        Me.tvSer_Descripcion.FieldName = "Ser_Descripcion"
        Me.tvSer_Descripcion.Name = "tvSer_Descripcion"
        Me.tvSer_Descripcion.Visible = True
        Me.tvSer_Descripcion.VisibleIndex = 1
        Me.tvSer_Descripcion.Width = 200
        '
        'tvSer_CuentaProvision
        '
        Me.tvSer_CuentaProvision.Caption = "Cuenta IVA"
        Me.tvSer_CuentaProvision.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.tvSer_CuentaProvision.FieldName = "Ser_CuentaProvision"
        Me.tvSer_CuentaProvision.Name = "tvSer_CuentaProvision"
        Me.tvSer_CuentaProvision.Visible = True
        Me.tvSer_CuentaProvision.VisibleIndex = 2
        Me.tvSer_CuentaProvision.Width = 198
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUENTA", "Código", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", 198, "Nombre")})
        Me.RepositoryItemLookUpEdit4.DisplayMember = "NOMBRE"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.ShowFooter = False
        Me.RepositoryItemLookUpEdit4.ValueMember = "CUENTA"
        '
        'tvSer_CuentaGasto
        '
        Me.tvSer_CuentaGasto.Caption = "Cuenta Gasto"
        Me.tvSer_CuentaGasto.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.tvSer_CuentaGasto.FieldName = "Ser_CuentaGasto"
        Me.tvSer_CuentaGasto.Name = "tvSer_CuentaGasto"
        Me.tvSer_CuentaGasto.Visible = True
        Me.tvSer_CuentaGasto.VisibleIndex = 3
        Me.tvSer_CuentaGasto.Width = 198
        '
        'tvSer_CtaIR
        '
        Me.tvSer_CtaIR.Caption = "Cuenta IR"
        Me.tvSer_CtaIR.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.tvSer_CtaIR.FieldName = "tvSer_CtaIR"
        Me.tvSer_CtaIR.Name = "tvSer_CtaIR"
        Me.tvSer_CtaIR.Visible = True
        Me.tvSer_CtaIR.VisibleIndex = 4
        '
        'gcCelular
        '
        Me.gcCelular.Location = New System.Drawing.Point(10, 191)
        Me.gcCelular.MainView = Me.gvCelular
        Me.gcCelular.Name = "gcCelular"
        Me.gcCelular.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit5})
        Me.gcCelular.Size = New System.Drawing.Size(717, 98)
        Me.gcCelular.TabIndex = 5
        Me.gcCelular.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCelular})
        '
        'gvCelular
        '
        Me.gvCelular.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cConsecutivo_ID, Me.cSer_Descripcion, Me.cSer_CuentaProvision, Me.cSer_CuentaGasto, Me.cSer_CtaIR})
        Me.gvCelular.GridControl = Me.gcCelular
        Me.gvCelular.Name = "gvCelular"
        Me.gvCelular.OptionsView.ShowGroupPanel = False
        '
        'cConsecutivo_ID
        '
        Me.cConsecutivo_ID.Caption = "Consecutivo_ID"
        Me.cConsecutivo_ID.FieldName = "Consecutivo_ID"
        Me.cConsecutivo_ID.Name = "cConsecutivo_ID"
        Me.cConsecutivo_ID.Visible = True
        Me.cConsecutivo_ID.VisibleIndex = 0
        Me.cConsecutivo_ID.Width = 100
        '
        'cSer_Descripcion
        '
        Me.cSer_Descripcion.Caption = "Descripción"
        Me.cSer_Descripcion.FieldName = "Ser_Descripcion"
        Me.cSer_Descripcion.Name = "cSer_Descripcion"
        Me.cSer_Descripcion.Visible = True
        Me.cSer_Descripcion.VisibleIndex = 1
        Me.cSer_Descripcion.Width = 200
        '
        'cSer_CuentaProvision
        '
        Me.cSer_CuentaProvision.Caption = "Cuenta IVA"
        Me.cSer_CuentaProvision.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.cSer_CuentaProvision.FieldName = "Ser_CuentaProvision"
        Me.cSer_CuentaProvision.Name = "cSer_CuentaProvision"
        Me.cSer_CuentaProvision.Visible = True
        Me.cSer_CuentaProvision.VisibleIndex = 2
        Me.cSer_CuentaProvision.Width = 198
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUENTA", "Código", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", 198, "Nombre")})
        Me.RepositoryItemLookUpEdit5.DisplayMember = "NOMBRE"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        Me.RepositoryItemLookUpEdit5.ShowFooter = False
        Me.RepositoryItemLookUpEdit5.ValueMember = "CUENTA"
        '
        'cSer_CuentaGasto
        '
        Me.cSer_CuentaGasto.Caption = "Cuenta Gasto"
        Me.cSer_CuentaGasto.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.cSer_CuentaGasto.FieldName = "Ser_CuentaGasto"
        Me.cSer_CuentaGasto.Name = "cSer_CuentaGasto"
        Me.cSer_CuentaGasto.Visible = True
        Me.cSer_CuentaGasto.VisibleIndex = 3
        Me.cSer_CuentaGasto.Width = 198
        '
        'cSer_CtaIR
        '
        Me.cSer_CtaIR.Caption = "Cuenta IR"
        Me.cSer_CtaIR.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.cSer_CtaIR.FieldName = "cSer_CtaIR"
        Me.cSer_CtaIR.Name = "cSer_CtaIR"
        Me.cSer_CtaIR.Visible = True
        Me.cSer_CtaIR.VisibleIndex = 4
        '
        'gcTelefono
        '
        Me.gcTelefono.Location = New System.Drawing.Point(10, 28)
        Me.gcTelefono.MainView = Me.gvTelefono
        Me.gcTelefono.Name = "gcTelefono"
        Me.gcTelefono.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit6})
        Me.gcTelefono.Size = New System.Drawing.Size(717, 95)
        Me.gcTelefono.TabIndex = 4
        Me.gcTelefono.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTelefono})
        '
        'gvTelefono
        '
        Me.gvTelefono.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tConsecutivo_ID, Me.tSer_Descripcion, Me.tSer_CuentaProvision, Me.tSer_CuentaGasto, Me.tSer_CtaIR})
        Me.gvTelefono.GridControl = Me.gcTelefono
        Me.gvTelefono.Name = "gvTelefono"
        Me.gvTelefono.OptionsView.ShowGroupPanel = False
        '
        'tConsecutivo_ID
        '
        Me.tConsecutivo_ID.Caption = "Consecutivo_ID"
        Me.tConsecutivo_ID.FieldName = "Consecutivo_ID"
        Me.tConsecutivo_ID.Name = "tConsecutivo_ID"
        Me.tConsecutivo_ID.OptionsColumn.AllowEdit = False
        Me.tConsecutivo_ID.Visible = True
        Me.tConsecutivo_ID.VisibleIndex = 0
        Me.tConsecutivo_ID.Width = 100
        '
        'tSer_Descripcion
        '
        Me.tSer_Descripcion.Caption = "Descripción"
        Me.tSer_Descripcion.FieldName = "Ser_Descripcion"
        Me.tSer_Descripcion.Name = "tSer_Descripcion"
        Me.tSer_Descripcion.Visible = True
        Me.tSer_Descripcion.VisibleIndex = 1
        Me.tSer_Descripcion.Width = 200
        '
        'tSer_CuentaProvision
        '
        Me.tSer_CuentaProvision.Caption = "Cuenta IVA"
        Me.tSer_CuentaProvision.ColumnEdit = Me.RepositoryItemLookUpEdit6
        Me.tSer_CuentaProvision.FieldName = "Ser_CuentaProvision"
        Me.tSer_CuentaProvision.Name = "tSer_CuentaProvision"
        Me.tSer_CuentaProvision.OptionsColumn.AllowMove = False
        Me.tSer_CuentaProvision.Visible = True
        Me.tSer_CuentaProvision.VisibleIndex = 2
        Me.tSer_CuentaProvision.Width = 198
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CUENTA", "Código", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", 198, "Nombre")})
        Me.RepositoryItemLookUpEdit6.DisplayMember = "NOMBRE"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.NullText = ""
        Me.RepositoryItemLookUpEdit6.ShowFooter = False
        Me.RepositoryItemLookUpEdit6.ShowHeader = False
        Me.RepositoryItemLookUpEdit6.ValueMember = "CUENTA"
        '
        'tSer_CuentaGasto
        '
        Me.tSer_CuentaGasto.Caption = "Cuenta Gasto"
        Me.tSer_CuentaGasto.ColumnEdit = Me.RepositoryItemLookUpEdit6
        Me.tSer_CuentaGasto.FieldName = "Ser_CuentaGasto"
        Me.tSer_CuentaGasto.Name = "tSer_CuentaGasto"
        Me.tSer_CuentaGasto.Visible = True
        Me.tSer_CuentaGasto.VisibleIndex = 3
        Me.tSer_CuentaGasto.Width = 198
        '
        'tSer_CtaIR
        '
        Me.tSer_CtaIR.Caption = "Cuenta IR"
        Me.tSer_CtaIR.ColumnEdit = Me.RepositoryItemLookUpEdit6
        Me.tSer_CtaIR.FieldName = "tSer_CtaIR"
        Me.tSer_CtaIR.Name = "tSer_CtaIR"
        Me.tSer_CtaIR.Visible = True
        Me.tSer_CtaIR.VisibleIndex = 4
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup6, Me.LayoutControlGroup7, Me.LayoutControlGroup8})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(736, 500)
        Me.LayoutControlGroup5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup5.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.CustomizationFormText = "Servicio de Teléfono"
        Me.LayoutControlGroup6.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutControlGroup6.ExpandButtonVisible = True
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem5})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(734, 163)
        Me.LayoutControlGroup6.Text = "Servicio de Teléfono"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.gcTelefono
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(728, 106)
        Me.LayoutControlItem7.Text = "LayoutControlItem1"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SBTelefono
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(636, 106)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem8.Text = "LayoutControlItem4"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 106)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(636, 33)
        Me.EmptySpaceItem5.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.CustomizationFormText = "Servicio de Celular"
        Me.LayoutControlGroup7.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutControlGroup7.ExpandButtonVisible = True
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem6})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 163)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(734, 166)
        Me.LayoutControlGroup7.Text = "Servicio de Celular"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SBCelular
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(636, 109)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem9.Text = "LayoutControlItem5"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.gcCelular
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(728, 109)
        Me.LayoutControlItem10.Text = "LayoutControlItem2"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 109)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(636, 33)
        Me.EmptySpaceItem6.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.CustomizationFormText = "Servicio de TV Cable"
        Me.LayoutControlGroup8.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutControlGroup8.ExpandButtonVisible = True
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem12, Me.EmptySpaceItem7})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(0, 329)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(734, 169)
        Me.LayoutControlGroup8.Text = "Servicio de TV Cable"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.gcTVCable
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(728, 112)
        Me.LayoutControlItem11.Text = "LayoutControlItem3"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SBTVCable
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(636, 112)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(92, 33)
        Me.LayoutControlItem12.Text = "LayoutControlItem6"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextToControlDistance = 0
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 112)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(636, 33)
        Me.EmptySpaceItem7.Text = "EmptySpaceItem4"
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmServiciosBasicos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(896, 544)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmServiciosBasicos"
        Me.Text = "Seleccionar Servicios Basicos"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.gcBasura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVBasura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcEnergia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVEnergia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAgua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVAgua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.gcTVCable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTVCable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCelular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCelular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Shared ChildInstance As frmServiciosBasicos = Nothing

    Public Shared Function Instance() As frmServiciosBasicos
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmServiciosBasicos
        End If
        ChildInstance.BringToFront()

        Return ChildInstance

    End Function

    Dim ServBas As New VB.SysContab.ServiciosBasicos


    Private Sub frmServiciosBasicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lds As New DataSet
        lds = VB.SysContab.CatalogoDB.GetList_SP("%")
        'me.GVAgua.Columns("Ser_CuentaProvision").ColumnEdit
        RepositoryItemLookUpEdit1.DataSource = lds.Tables(0)
        RepositoryItemLookUpEdit2.DataSource = lds.Tables(0)
        RepositoryItemLookUpEdit3.DataSource = lds.Tables(0)
        RepositoryItemLookUpEdit4.DataSource = lds.Tables(0)
        RepositoryItemLookUpEdit5.DataSource = lds.Tables(0)
        RepositoryItemLookUpEdit6.DataSource = lds.Tables(0)
        lds.Dispose()
        'LLenar el Grid del Agua
        Me.gcAgua.DataSource = VB.SysContab.ServiciosBasicos.GetList("B", ServiciosBasicos.Agua).Tables(0)

        'LLenar el Grid del Energia
        Me.gcEnergia.DataSource = VB.SysContab.ServiciosBasicos.GetList("B", ServiciosBasicos.Energia).Tables(0)

        'LLenar el Grid del Basura
        Me.gcBasura.DataSource = VB.SysContab.ServiciosBasicos.GetList("B", ServiciosBasicos.Basura).Tables(0)

        'LLenar el Grid del Telefono
        Me.gcTelefono.DataSource = VB.SysContab.ServiciosBasicos.GetList("B", ServiciosBasicos.Telefono).Tables(0)

        'LLenar el Grid del Celular
        Me.gcCelular.DataSource = VB.SysContab.ServiciosBasicos.GetList("B", ServiciosBasicos.Celular).Tables(0)

        'LLenar el Grid del TV Cable
        Me.gcTVCable.DataSource = VB.SysContab.ServiciosBasicos.GetList("B", ServiciosBasicos.TVCable).Tables(0)


    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub


    Private Sub SBAgua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBAgua.Click, SBBasura.Click, SBCelular.Click, SBEnergia.Click, SBTelefono.Click, SBTVCable.Click

        Dim i As Integer
        Dim SBasico As Integer
        Dim Grid As New DevExpress.XtraGrid.GridControl

        Select Case sender.name.toupper

            Case "SBAGUA"
                SBasico = ServiciosBasicos.Agua
                Grid = Me.gcAgua
            Case "SBBASURA"
                SBasico = ServiciosBasicos.Basura
                Grid = Me.gcBasura
            Case "SBCELULAR"
                SBasico = ServiciosBasicos.Celular
                Grid = Me.gcCelular
            Case "SBENERGIA"
                SBasico = ServiciosBasicos.Energia
                Grid = Me.gcEnergia
            Case "SBTELEFONO"
                SBasico = ServiciosBasicos.Telefono
                Grid = Me.gcTelefono
            Case "SBTVCABLE"
                SBasico = ServiciosBasicos.TVCable
                Grid = Me.gcTVCable
        End Select


        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction()

        Try
            For i = 0 To Grid.DataSource.rows.count - 1
                'Verificar si existe el Servicio
                If VB.SysContab.ServiciosBasicos.Buscar(SBasico, _
                    Grid.DataSource.rows(i)("Consecutivo_ID")) = True Then
                    'Modificar
                    VB.SysContab.ServiciosBasicos.UpdateServiciosTrans(SBasico, _
                                            Grid.DataSource.rows(i)("Consecutivo_ID"), _
                                            Grid.DataSource.rows(i)("Ser_Descripcion"), _
                                            Grid.DataSource.rows(i)("Ser_CuentaProvision"), _
                                            Grid.DataSource.rows(i)("Ser_CuentaGasto"), _
                                            Grid.DataSource.rows(i)("Ser_CtaIR"))
                Else
                    'Agregar
                    VB.SysContab.ServiciosBasicos.AddServiciosTrans(SBasico, _
                        Grid.DataSource.rows(i)("Consecutivo_ID"), _
                        Grid.DataSource.rows(i)("Ser_Descripcion"), _
                        Grid.DataSource.rows(i)("Ser_CuentaProvision"), _
                        Grid.DataSource.rows(i)("Ser_CuentaGasto"), _
                        Grid.DataSource.rows(i)("Ser_CtaIR"))
                End If
            Next
            VB.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            MsgBox(ex.Message)
            VB.SysContab.Rutinas.ErrorTransaccion()
        End Try


    End Sub
End Class
