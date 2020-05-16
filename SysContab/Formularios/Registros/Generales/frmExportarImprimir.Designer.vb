<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportarImprimir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExportarImprimir))
        Me.rgOpciones = New DevExpress.XtraEditors.RadioGroup()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bPrevia = New DevExpress.XtraEditors.SimpleButton()
        Me.bWeb = New DevExpress.XtraEditors.SimpleButton()
        Me.bTexto = New DevExpress.XtraEditors.SimpleButton()
        Me.bPdf = New DevExpress.XtraEditors.SimpleButton()
        Me.pPrevia = New DevExpress.XtraEditors.PictureEdit()
        Me.bWord = New DevExpress.XtraEditors.SimpleButton()
        Me.pTxt = New DevExpress.XtraEditors.PictureEdit()
        Me.pPdf = New DevExpress.XtraEditors.PictureEdit()
        Me.pWeb = New DevExpress.XtraEditors.PictureEdit()
        Me.bExcelx = New DevExpress.XtraEditors.SimpleButton()
        Me.bExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.pWord = New DevExpress.XtraEditors.PictureEdit()
        Me.pExcel = New DevExpress.XtraEditors.PictureEdit()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Guardar = New System.Windows.Forms.SaveFileDialog()
        Me.rgOrientacion = New DevExpress.XtraEditors.RadioGroup()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.rgOpciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.pPrevia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pPdf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pWeb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pWord.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExcel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgOrientacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rgOpciones
        '
        Me.rgOpciones.EditValue = 6
        Me.rgOpciones.Location = New System.Drawing.Point(108, 249)
        Me.rgOpciones.Name = "rgOpciones"
        Me.rgOpciones.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgOpciones.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgOpciones.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.rgOpciones.Properties.Appearance.Options.UseBackColor = True
        Me.rgOpciones.Properties.Appearance.Options.UseFont = True
        Me.rgOpciones.Properties.Appearance.Options.UseForeColor = True
        Me.rgOpciones.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Microsoft Excel 2003 (*.xls)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Web (HTML)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Acrobat Reader (*.pdf)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Microsoft Word 2003 (*.rtf)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(5, "Texto Plano (*.txt)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(6, "Vista Previa (Impreso)")})
        Me.rgOpciones.Size = New System.Drawing.Size(225, 68)
        Me.rgOpciones.StyleController = Me.LayoutControl1
        Me.rgOpciones.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.rgOrientacion)
        Me.LayoutControl1.Controls.Add(Me.bSalir)
        Me.LayoutControl1.Controls.Add(Me.bPrevia)
        Me.LayoutControl1.Controls.Add(Me.bWeb)
        Me.LayoutControl1.Controls.Add(Me.bTexto)
        Me.LayoutControl1.Controls.Add(Me.bPdf)
        Me.LayoutControl1.Controls.Add(Me.pPrevia)
        Me.LayoutControl1.Controls.Add(Me.bWord)
        Me.LayoutControl1.Controls.Add(Me.pTxt)
        Me.LayoutControl1.Controls.Add(Me.pPdf)
        Me.LayoutControl1.Controls.Add(Me.pWeb)
        Me.LayoutControl1.Controls.Add(Me.bExcelx)
        Me.LayoutControl1.Controls.Add(Me.bExcel)
        Me.LayoutControl1.Controls.Add(Me.pWord)
        Me.LayoutControl1.Controls.Add(Me.rgOpciones)
        Me.LayoutControl1.Controls.Add(Me.pExcel)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(714, 285, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(500, 271)
        Me.LayoutControl1.TabIndex = 5
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'bSalir
        '
        Me.bSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bSalir.ImageOptions.Image = CType(resources.GetObject("bSalir.ImageOptions.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(356, 221)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(132, 38)
        Me.bSalir.StyleController = Me.LayoutControl1
        Me.bSalir.TabIndex = 1
        Me.bSalir.Text = "&Salir"
        '
        'bPrevia
        '
        Me.bPrevia.ImageOptions.Image = CType(resources.GetObject("bPrevia.ImageOptions.Image"), System.Drawing.Image)
        Me.bPrevia.Location = New System.Drawing.Point(252, 138)
        Me.bPrevia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bPrevia.Name = "bPrevia"
        Me.bPrevia.Size = New System.Drawing.Size(236, 38)
        Me.bPrevia.StyleController = Me.LayoutControl1
        Me.bPrevia.TabIndex = 8
        Me.bPrevia.Text = "Vista Previa"
        '
        'bWeb
        '
        Me.bWeb.ImageOptions.Image = CType(resources.GetObject("bWeb.ImageOptions.Image"), System.Drawing.Image)
        Me.bWeb.Location = New System.Drawing.Point(252, 54)
        Me.bWeb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bWeb.Name = "bWeb"
        Me.bWeb.Size = New System.Drawing.Size(236, 38)
        Me.bWeb.StyleController = Me.LayoutControl1
        Me.bWeb.TabIndex = 7
        Me.bWeb.Text = "Web (*.html)"
        '
        'bTexto
        '
        Me.bTexto.ImageOptions.Image = CType(resources.GetObject("bTexto.ImageOptions.Image"), System.Drawing.Image)
        Me.bTexto.Location = New System.Drawing.Point(252, 12)
        Me.bTexto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bTexto.Name = "bTexto"
        Me.bTexto.Size = New System.Drawing.Size(236, 38)
        Me.bTexto.StyleController = Me.LayoutControl1
        Me.bTexto.TabIndex = 6
        Me.bTexto.Text = "Texto Plano (*.txt)"
        '
        'bPdf
        '
        Me.bPdf.ImageOptions.Image = CType(resources.GetObject("bPdf.ImageOptions.Image"), System.Drawing.Image)
        Me.bPdf.Location = New System.Drawing.Point(12, 96)
        Me.bPdf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bPdf.Name = "bPdf"
        Me.bPdf.Size = New System.Drawing.Size(236, 38)
        Me.bPdf.StyleController = Me.LayoutControl1
        Me.bPdf.TabIndex = 6
        Me.bPdf.Text = "Acrobat Reader (*.pdf)"
        '
        'pPrevia
        '
        Me.pPrevia.EditValue = CType(resources.GetObject("pPrevia.EditValue"), Object)
        Me.pPrevia.Location = New System.Drawing.Point(10, 249)
        Me.pPrevia.Name = "pPrevia"
        Me.pPrevia.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pPrevia.Properties.Appearance.Options.UseBackColor = True
        Me.pPrevia.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pPrevia.Properties.ZoomAccelerationFactor = 1.0R
        Me.pPrevia.Size = New System.Drawing.Size(322, 68)
        Me.pPrevia.StyleController = Me.LayoutControl1
        Me.pPrevia.TabIndex = 2
        '
        'bWord
        '
        Me.bWord.ImageOptions.Image = CType(resources.GetObject("bWord.ImageOptions.Image"), System.Drawing.Image)
        Me.bWord.Location = New System.Drawing.Point(252, 96)
        Me.bWord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bWord.Name = "bWord"
        Me.bWord.Size = New System.Drawing.Size(236, 38)
        Me.bWord.StyleController = Me.LayoutControl1
        Me.bWord.TabIndex = 6
        Me.bWord.Text = "Word 97-2003 (*.rtf)"
        '
        'pTxt
        '
        Me.pTxt.EditValue = CType(resources.GetObject("pTxt.EditValue"), Object)
        Me.pTxt.Location = New System.Drawing.Point(114, 249)
        Me.pTxt.Name = "pTxt"
        Me.pTxt.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pTxt.Properties.Appearance.Options.UseBackColor = True
        Me.pTxt.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pTxt.Properties.ZoomAccelerationFactor = 1.0R
        Me.pTxt.Size = New System.Drawing.Size(219, 68)
        Me.pTxt.StyleController = Me.LayoutControl1
        Me.pTxt.TabIndex = 2
        '
        'pPdf
        '
        Me.pPdf.EditValue = CType(resources.GetObject("pPdf.EditValue"), Object)
        Me.pPdf.Location = New System.Drawing.Point(114, 249)
        Me.pPdf.Name = "pPdf"
        Me.pPdf.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pPdf.Properties.Appearance.Options.UseBackColor = True
        Me.pPdf.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pPdf.Properties.ZoomAccelerationFactor = 1.0R
        Me.pPdf.Size = New System.Drawing.Size(219, 68)
        Me.pPdf.StyleController = Me.LayoutControl1
        Me.pPdf.TabIndex = 2
        '
        'pWeb
        '
        Me.pWeb.EditValue = CType(resources.GetObject("pWeb.EditValue"), Object)
        Me.pWeb.Location = New System.Drawing.Point(114, 249)
        Me.pWeb.Name = "pWeb"
        Me.pWeb.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pWeb.Properties.Appearance.Options.UseBackColor = True
        Me.pWeb.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pWeb.Properties.ZoomAccelerationFactor = 1.0R
        Me.pWeb.Size = New System.Drawing.Size(219, 68)
        Me.pWeb.StyleController = Me.LayoutControl1
        Me.pWeb.TabIndex = 2
        '
        'bExcelx
        '
        Me.bExcelx.ImageOptions.Image = CType(resources.GetObject("bExcelx.ImageOptions.Image"), System.Drawing.Image)
        Me.bExcelx.Location = New System.Drawing.Point(12, 54)
        Me.bExcelx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bExcelx.Name = "bExcelx"
        Me.bExcelx.Size = New System.Drawing.Size(236, 38)
        Me.bExcelx.StyleController = Me.LayoutControl1
        Me.bExcelx.TabIndex = 6
        Me.bExcelx.Text = "Excel 2007-2013(*.xlsx)"
        '
        'bExcel
        '
        Me.bExcel.ImageOptions.Image = CType(resources.GetObject("bExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.bExcel.Location = New System.Drawing.Point(12, 12)
        Me.bExcel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bExcel.Name = "bExcel"
        Me.bExcel.Size = New System.Drawing.Size(236, 38)
        Me.bExcel.StyleController = Me.LayoutControl1
        Me.bExcel.TabIndex = 4
        Me.bExcel.Text = "Excel 97-2003 (*.xls)"
        '
        'pWord
        '
        Me.pWord.EditValue = CType(resources.GetObject("pWord.EditValue"), Object)
        Me.pWord.Location = New System.Drawing.Point(114, 249)
        Me.pWord.Name = "pWord"
        Me.pWord.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pWord.Properties.Appearance.Options.UseBackColor = True
        Me.pWord.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pWord.Properties.ZoomAccelerationFactor = 1.0R
        Me.pWord.Size = New System.Drawing.Size(94, 68)
        Me.pWord.StyleController = Me.LayoutControl1
        Me.pWord.TabIndex = 2
        '
        'pExcel
        '
        Me.pExcel.EditValue = CType(resources.GetObject("pExcel.EditValue"), Object)
        Me.pExcel.Location = New System.Drawing.Point(114, 249)
        Me.pExcel.Name = "pExcel"
        Me.pExcel.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pExcel.Properties.Appearance.Options.UseBackColor = True
        Me.pExcel.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pExcel.Properties.ZoomAccelerationFactor = 1.0R
        Me.pExcel.Size = New System.Drawing.Size(17, 51)
        Me.pExcel.StyleController = Me.LayoutControl1
        Me.pExcel.TabIndex = 2
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.rgOpciones
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(380, 88)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.pExcel
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem9"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(145, 67)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.pWord
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(235, 88)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.pPdf
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(380, 88)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.pWeb
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(380, 88)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.pTxt
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem13"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(380, 88)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.pPrevia
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(380, 88)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem15, Me.EmptySpaceItem2, Me.LayoutControlItem7, Me.LayoutControlItem6, Me.LayoutControlItem4, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.EmptySpaceItem3, Me.LayoutControlItem16})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(500, 271)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 171)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(480, 38)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.bSalir
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(344, 209)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(136, 42)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(136, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(136, 42)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 209)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(344, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.bPrevia
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(240, 126)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(240, 45)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.bWeb
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(240, 42)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.bPdf
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.bExcel
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.bWord
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(240, 84)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.bExcelx
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.bTexto
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(240, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(240, 42)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(230, 126)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(10, 45)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'Guardar
        '
        Me.Guardar.Title = "Exportar Información"
        '
        'rgOrientacion
        '
        Me.rgOrientacion.EditValue = False
        Me.rgOrientacion.Location = New System.Drawing.Point(12, 154)
        Me.rgOrientacion.Name = "rgOrientacion"
        Me.rgOrientacion.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgOrientacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgOrientacion.Properties.Appearance.Options.UseBackColor = True
        Me.rgOrientacion.Properties.Appearance.Options.UseFont = True
        Me.rgOrientacion.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Vertical"), New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Horizontal")})
        Me.rgOrientacion.Size = New System.Drawing.Size(226, 25)
        Me.rgOrientacion.StyleController = Me.LayoutControl1
        Me.rgOrientacion.TabIndex = 9
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.rgOrientacion
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(230, 45)
        Me.LayoutControlItem16.Text = "Orientación:"
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(59, 13)
        '
        'frmExportarImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bSalir
        Me.ClientSize = New System.Drawing.Size(500, 271)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExportarImprimir"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones de Exportación"
        CType(Me.rgOpciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.pPrevia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pPdf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pWeb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pWord.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExcel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgOrientacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rgOpciones As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pExcel As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents pWord As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents pPdf As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents pPrevia As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents pTxt As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents pWeb As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents bPrevia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bWeb As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bTexto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bPdf As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bWord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExcelx As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents rgOrientacion As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
End Class
