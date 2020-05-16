Imports System.Data.SqlClient

Public Class frmAgregarPresupuesto
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmAgregarPresupuesto = Nothing

    Public Shared Function Instance() As frmAgregarPresupuesto
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmAgregarPresupuesto()
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
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TabCB As System.Windows.Forms.TabControl
    Friend WithEvents TPNueva As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbPeriodos As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgPresupuesto As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesde As System.Windows.Forms.TextBox
    Friend WithEvents txtHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbVerPor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblQ01 As System.Windows.Forms.Label
    Friend WithEvents txtQ03 As System.Windows.Forms.TextBox
    Friend WithEvents lblQ04 As System.Windows.Forms.Label
    Friend WithEvents txtQ01 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ04 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ02 As System.Windows.Forms.TextBox
    Friend WithEvents lblQ02 As System.Windows.Forms.Label
    Friend WithEvents lblQ03 As System.Windows.Forms.Label
    Friend WithEvents cbIngPor As System.Windows.Forms.ComboBox
    Friend WithEvents GBQuarters As System.Windows.Forms.GroupBox
    Friend WithEvents GBSemestre As System.Windows.Forms.GroupBox
    Friend WithEvents lblS01 As System.Windows.Forms.Label
    Friend WithEvents txtS01 As System.Windows.Forms.TextBox
    Friend WithEvents txtS02 As System.Windows.Forms.TextBox
    Friend WithEvents lblS02 As System.Windows.Forms.Label
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GBMeses As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GBEjecucion As System.Windows.Forms.GroupBox
    Friend WithEvents txtPDisponible As System.Windows.Forms.TextBox
    Friend WithEvents txtPEjecutado As System.Windows.Forms.TextBox
    Friend WithEvents TxtDisponible As System.Windows.Forms.TextBox
    Friend WithEvents txtEjecutado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdImprimir As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgPresupuesto = New System.Windows.Forms.DataGrid
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.TabCB = New System.Windows.Forms.TabControl
        Me.TPNueva = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbIngPor = New System.Windows.Forms.ComboBox
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.GBEjecucion = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPDisponible = New System.Windows.Forms.TextBox
        Me.txtPEjecutado = New System.Windows.Forms.TextBox
        Me.TxtDisponible = New System.Windows.Forms.TextBox
        Me.txtEjecutado = New System.Windows.Forms.TextBox
        Me.GBMeses = New System.Windows.Forms.GroupBox
        Me.GBSemestre = New System.Windows.Forms.GroupBox
        Me.lblS01 = New System.Windows.Forms.Label
        Me.txtS01 = New System.Windows.Forms.TextBox
        Me.txtS02 = New System.Windows.Forms.TextBox
        Me.lblS02 = New System.Windows.Forms.Label
        Me.GBQuarters = New System.Windows.Forms.GroupBox
        Me.lblQ01 = New System.Windows.Forms.Label
        Me.txtQ03 = New System.Windows.Forms.TextBox
        Me.lblQ04 = New System.Windows.Forms.Label
        Me.txtQ01 = New System.Windows.Forms.TextBox
        Me.txtQ04 = New System.Windows.Forms.TextBox
        Me.txtQ02 = New System.Windows.Forms.TextBox
        Me.lblQ02 = New System.Windows.Forms.Label
        Me.lblQ03 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbVerPor = New System.Windows.Forms.ComboBox
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.cbPeriodos = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDesde = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtHasta = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabCB.SuspendLayout()
        Me.TPNueva.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GBEjecucion.SuspendLayout()
        Me.GBSemestre.SuspendLayout()
        Me.GBQuarters.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgPresupuesto)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 235)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'dgPresupuesto
        '
        Me.dgPresupuesto.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dgPresupuesto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPresupuesto.BackColor = System.Drawing.Color.Gainsboro
        Me.dgPresupuesto.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgPresupuesto.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dgPresupuesto.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgPresupuesto.CaptionForeColor = System.Drawing.Color.Black
        Me.dgPresupuesto.DataMember = ""
        Me.dgPresupuesto.FlatMode = True
        Me.dgPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPresupuesto.ForeColor = System.Drawing.Color.Black
        Me.dgPresupuesto.GridLineColor = System.Drawing.Color.Silver
        Me.dgPresupuesto.HeaderBackColor = System.Drawing.Color.Black
        Me.dgPresupuesto.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dgPresupuesto.HeaderForeColor = System.Drawing.Color.White
        Me.dgPresupuesto.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgPresupuesto.Location = New System.Drawing.Point(8, 20)
        Me.dgPresupuesto.Name = "dgPresupuesto"
        Me.dgPresupuesto.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dgPresupuesto.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgPresupuesto.ReadOnly = True
        Me.dgPresupuesto.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dgPresupuesto.SelectionForeColor = System.Drawing.Color.White
        Me.dgPresupuesto.Size = New System.Drawing.Size(986, 209)
        Me.dgPresupuesto.TabIndex = 12
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(904, 9)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 25)
        Me.cmdCancelar.TabIndex = 25
        Me.cmdCancelar.Text = "&Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdImprimir)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Controls.Add(Me.cmdNuevo)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 467)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1008, 43)
        Me.GroupBox2.TabIndex = 154
        Me.GroupBox2.TabStop = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.Appearance.Options.UseFont = True
        Me.cmdImprimir.Location = New System.Drawing.Point(184, 9)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(72, 25)
        Me.cmdImprimir.TabIndex = 36
        Me.cmdImprimir.Text = "&Imprimir"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Location = New System.Drawing.Point(96, 9)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 25)
        Me.cmdAceptar.TabIndex = 26
        Me.cmdAceptar.Text = "&Guardar"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 9)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(72, 25)
        Me.cmdNuevo.TabIndex = 35
        Me.cmdNuevo.Text = "Nuevo"
        '
        'TabCB
        '
        Me.TabCB.Controls.Add(Me.TPNueva)
        Me.TabCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCB.Location = New System.Drawing.Point(0, 0)
        Me.TabCB.Name = "TabCB"
        Me.TabCB.SelectedIndex = 0
        Me.TabCB.Size = New System.Drawing.Size(1008, 467)
        Me.TabCB.TabIndex = 155
        '
        'TPNueva
        '
        Me.TPNueva.Controls.Add(Me.GroupBox5)
        Me.TPNueva.Controls.Add(Me.Label1)
        Me.TPNueva.Controls.Add(Me.cbVerPor)
        Me.TPNueva.Controls.Add(Me.Button1)
        Me.TPNueva.Controls.Add(Me.GroupBox1)
        Me.TPNueva.Controls.Add(Me.Label17)
        Me.TPNueva.Controls.Add(Me.cbPeriodos)
        Me.TPNueva.Controls.Add(Me.Label12)
        Me.TPNueva.Controls.Add(Me.txtDesde)
        Me.TPNueva.Controls.Add(Me.Label2)
        Me.TPNueva.Controls.Add(Me.txtHasta)
        Me.TPNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPNueva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TPNueva.Location = New System.Drawing.Point(4, 22)
        Me.TPNueva.Name = "TPNueva"
        Me.TPNueva.Size = New System.Drawing.Size(1000, 441)
        Me.TPNueva.TabIndex = 1
        Me.TPNueva.Text = "Presupuesto"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.cbIngPor)
        Me.GroupBox5.Controls.Add(Me.cmdGuardar)
        Me.GroupBox5.Controls.Add(Me.GBEjecucion)
        Me.GroupBox5.Controls.Add(Me.GBMeses)
        Me.GroupBox5.Controls.Add(Me.GBSemestre)
        Me.GroupBox5.Controls.Add(Me.GBQuarters)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox5.Location = New System.Drawing.Point(0, 269)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1000, 172)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Editar Presupuesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Ingresar por:"
        '
        'cbIngPor
        '
        Me.cbIngPor.Items.AddRange(New Object() {"Mes", "Quarter", "Semestre"})
        Me.cbIngPor.Location = New System.Drawing.Point(119, 17)
        Me.cbIngPor.Name = "cbIngPor"
        Me.cbIngPor.Size = New System.Drawing.Size(144, 24)
        Me.cbIngPor.TabIndex = 33
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_SaveLarge
        Me.cmdGuardar.Location = New System.Drawing.Point(504, 9)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(152, 32)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Text = "Guardar && Siguiente"
        '
        'GBEjecucion
        '
        Me.GBEjecucion.Controls.Add(Me.Label5)
        Me.GBEjecucion.Controls.Add(Me.Label4)
        Me.GBEjecucion.Controls.Add(Me.txtPDisponible)
        Me.GBEjecucion.Controls.Add(Me.txtPEjecutado)
        Me.GBEjecucion.Controls.Add(Me.TxtDisponible)
        Me.GBEjecucion.Controls.Add(Me.txtEjecutado)
        Me.GBEjecucion.Location = New System.Drawing.Point(656, 43)
        Me.GBEjecucion.Name = "GBEjecucion"
        Me.GBEjecucion.Size = New System.Drawing.Size(348, 112)
        Me.GBEjecucion.TabIndex = 34
        Me.GBEjecucion.TabStop = False
        Me.GBEjecucion.Text = "Ejecución de Presupuesto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Disponible"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Ejecutado:"
        '
        'txtPDisponible
        '
        Me.txtPDisponible.Enabled = False
        Me.txtPDisponible.Location = New System.Drawing.Point(200, 60)
        Me.txtPDisponible.Name = "txtPDisponible"
        Me.txtPDisponible.Size = New System.Drawing.Size(72, 22)
        Me.txtPDisponible.TabIndex = 3
        '
        'txtPEjecutado
        '
        Me.txtPEjecutado.Enabled = False
        Me.txtPEjecutado.Location = New System.Drawing.Point(200, 26)
        Me.txtPEjecutado.Name = "txtPEjecutado"
        Me.txtPEjecutado.Size = New System.Drawing.Size(72, 22)
        Me.txtPEjecutado.TabIndex = 2
        '
        'TxtDisponible
        '
        Me.TxtDisponible.Enabled = False
        Me.TxtDisponible.Location = New System.Drawing.Point(88, 60)
        Me.TxtDisponible.Name = "TxtDisponible"
        Me.TxtDisponible.Size = New System.Drawing.Size(104, 22)
        Me.TxtDisponible.TabIndex = 1
        '
        'txtEjecutado
        '
        Me.txtEjecutado.Enabled = False
        Me.txtEjecutado.Location = New System.Drawing.Point(88, 26)
        Me.txtEjecutado.Name = "txtEjecutado"
        Me.txtEjecutado.Size = New System.Drawing.Size(104, 22)
        Me.txtEjecutado.TabIndex = 0
        '
        'GBMeses
        '
        Me.GBMeses.Location = New System.Drawing.Point(8, 43)
        Me.GBMeses.Name = "GBMeses"
        Me.GBMeses.Size = New System.Drawing.Size(648, 112)
        Me.GBMeses.TabIndex = 51
        Me.GBMeses.TabStop = False
        Me.GBMeses.Text = "Meses:"
        '
        'GBSemestre
        '
        Me.GBSemestre.Controls.Add(Me.lblS01)
        Me.GBSemestre.Controls.Add(Me.txtS01)
        Me.GBSemestre.Controls.Add(Me.txtS02)
        Me.GBSemestre.Controls.Add(Me.lblS02)
        Me.GBSemestre.Location = New System.Drawing.Point(8, 43)
        Me.GBSemestre.Name = "GBSemestre"
        Me.GBSemestre.Size = New System.Drawing.Size(640, 112)
        Me.GBSemestre.TabIndex = 49
        Me.GBSemestre.TabStop = False
        Me.GBSemestre.Text = "Semestre:"
        '
        'lblS01
        '
        Me.lblS01.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS01.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblS01.Location = New System.Drawing.Point(40, 26)
        Me.lblS01.Name = "lblS01"
        Me.lblS01.Size = New System.Drawing.Size(40, 26)
        Me.lblS01.TabIndex = 35
        Me.lblS01.Text = "S01:"
        '
        'txtS01
        '
        Me.txtS01.Location = New System.Drawing.Point(80, 26)
        Me.txtS01.Name = "txtS01"
        Me.txtS01.Size = New System.Drawing.Size(96, 22)
        Me.txtS01.TabIndex = 36
        '
        'txtS02
        '
        Me.txtS02.Location = New System.Drawing.Point(80, 52)
        Me.txtS02.Name = "txtS02"
        Me.txtS02.Size = New System.Drawing.Size(96, 22)
        Me.txtS02.TabIndex = 38
        '
        'lblS02
        '
        Me.lblS02.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS02.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblS02.Location = New System.Drawing.Point(40, 52)
        Me.lblS02.Name = "lblS02"
        Me.lblS02.Size = New System.Drawing.Size(40, 26)
        Me.lblS02.TabIndex = 37
        Me.lblS02.Text = "S02:"
        '
        'GBQuarters
        '
        Me.GBQuarters.Controls.Add(Me.lblQ01)
        Me.GBQuarters.Controls.Add(Me.txtQ03)
        Me.GBQuarters.Controls.Add(Me.lblQ04)
        Me.GBQuarters.Controls.Add(Me.txtQ01)
        Me.GBQuarters.Controls.Add(Me.txtQ04)
        Me.GBQuarters.Controls.Add(Me.txtQ02)
        Me.GBQuarters.Controls.Add(Me.lblQ02)
        Me.GBQuarters.Controls.Add(Me.lblQ03)
        Me.GBQuarters.Location = New System.Drawing.Point(8, 43)
        Me.GBQuarters.Name = "GBQuarters"
        Me.GBQuarters.Size = New System.Drawing.Size(640, 112)
        Me.GBQuarters.TabIndex = 48
        Me.GBQuarters.TabStop = False
        Me.GBQuarters.Text = "Quarters:"
        '
        'lblQ01
        '
        Me.lblQ01.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ01.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblQ01.Location = New System.Drawing.Point(40, 26)
        Me.lblQ01.Name = "lblQ01"
        Me.lblQ01.Size = New System.Drawing.Size(40, 26)
        Me.lblQ01.TabIndex = 35
        Me.lblQ01.Text = "Q01:"
        '
        'txtQ03
        '
        Me.txtQ03.Location = New System.Drawing.Point(224, 26)
        Me.txtQ03.Name = "txtQ03"
        Me.txtQ03.Size = New System.Drawing.Size(96, 22)
        Me.txtQ03.TabIndex = 40
        '
        'lblQ04
        '
        Me.lblQ04.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ04.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblQ04.Location = New System.Drawing.Point(184, 52)
        Me.lblQ04.Name = "lblQ04"
        Me.lblQ04.Size = New System.Drawing.Size(40, 26)
        Me.lblQ04.TabIndex = 41
        Me.lblQ04.Text = "Q04:"
        '
        'txtQ01
        '
        Me.txtQ01.Location = New System.Drawing.Point(80, 26)
        Me.txtQ01.Name = "txtQ01"
        Me.txtQ01.Size = New System.Drawing.Size(96, 22)
        Me.txtQ01.TabIndex = 36
        '
        'txtQ04
        '
        Me.txtQ04.Location = New System.Drawing.Point(224, 52)
        Me.txtQ04.Name = "txtQ04"
        Me.txtQ04.Size = New System.Drawing.Size(96, 22)
        Me.txtQ04.TabIndex = 42
        '
        'txtQ02
        '
        Me.txtQ02.Location = New System.Drawing.Point(80, 52)
        Me.txtQ02.Name = "txtQ02"
        Me.txtQ02.Size = New System.Drawing.Size(96, 22)
        Me.txtQ02.TabIndex = 38
        '
        'lblQ02
        '
        Me.lblQ02.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ02.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblQ02.Location = New System.Drawing.Point(40, 52)
        Me.lblQ02.Name = "lblQ02"
        Me.lblQ02.Size = New System.Drawing.Size(40, 26)
        Me.lblQ02.TabIndex = 37
        Me.lblQ02.Text = "Q02:"
        '
        'lblQ03
        '
        Me.lblQ03.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQ03.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblQ03.Location = New System.Drawing.Point(184, 26)
        Me.lblQ03.Name = "lblQ03"
        Me.lblQ03.Size = New System.Drawing.Size(40, 26)
        Me.lblQ03.TabIndex = 39
        Me.lblQ03.Text = "Q03:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(760, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Ver por:"
        '
        'cbVerPor
        '
        Me.cbVerPor.Items.AddRange(New Object() {"Mes", "Quarter", "Semestre"})
        Me.cbVerPor.Location = New System.Drawing.Point(832, 11)
        Me.cbVerPor.Name = "cbVerPor"
        Me.cbVerPor.Size = New System.Drawing.Size(144, 24)
        Me.cbVerPor.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.Image = Global.SysContab.My.Resources.Resources.RibbonPrintPreview_FindLarge
        Me.Button1.Location = New System.Drawing.Point(645, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 32)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Cargar Datos"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(8, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 16)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Periodos:"
        '
        'cbPeriodos
        '
        Me.cbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPeriodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodos.Location = New System.Drawing.Point(89, 10)
        Me.cbPeriodos.Name = "cbPeriodos"
        Me.cbPeriodos.Size = New System.Drawing.Size(239, 23)
        Me.cbPeriodos.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(334, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 16)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Desde"
        '
        'txtDesde
        '
        Me.txtDesde.Enabled = False
        Me.txtDesde.Location = New System.Drawing.Point(394, 11)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(88, 22)
        Me.txtDesde.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(488, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Hasta"
        '
        'txtHasta
        '
        Me.txtHasta.Enabled = False
        Me.txtHasta.Location = New System.Drawing.Point(543, 11)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(96, 22)
        Me.txtHasta.TabIndex = 21
        '
        'frmAgregarPresupuesto
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(1008, 510)
        Me.Controls.Add(Me.TabCB)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmAgregarPresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuesto"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabCB.ResumeLayout(False)
        Me.TPNueva.ResumeLayout(False)
        Me.TPNueva.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GBEjecucion.ResumeLayout(False)
        Me.GBEjecucion.PerformLayout()
        Me.GBSemestre.ResumeLayout(False)
        Me.GBSemestre.PerformLayout()
        Me.GBQuarters.ResumeLayout(False)
        Me.GBQuarters.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shared Cuenta As String
    Public Shared Banco As String
    Public Shared Periodo As String
    Public Shared Desde, Hasta As Date

    Dim Presupuesto As New VB.SysContab.PresupuestoDB()
    Dim Comprobantes As New VB.SysContab.ComprobanteDB()
    Dim Periodos As New VB.SysContab.PeriodosDB()
    Dim Per_Detail As New VB.SysContab.PeriodoDetails()

    Private WithEvents myDataSet As DataSet
    Dim tCust As DataTable
    Dim Tabla As DataTable
    Dim ds, dsh As DataSet



    Dim r As New VB.SysContab.Rutinas()

    Dim i As Integer
    Dim k As Integer
    Dim ColMes, ColEje As Integer
    Dim cdesde, chasta As String

    Dim CodigoPresupuesto As String
    Dim newRow1 As DataRow


    Private Sub frmAgregarPresupuesto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbPeriodos.DataSource = Periodos.GetList().Tables("Periodos")
        cbPeriodos.ValueMember = "codigo"
        cbPeriodos.DisplayMember = "descripcion"

        Me.txtQ01.Text = 0.0
        Me.txtQ02.Text = 0.0
        Me.txtQ03.Text = 0.0
        Me.txtQ04.Text = 0.0

        Me.txtS01.Text = 0.0
        Me.txtS02.Text = 0.0

        Me.cbVerPor.SelectedIndex = 0
        ColMes = 0
        Cargar()
        If Me.dgPresupuesto.CurrentRowIndex >= 0 Then
            Sumar(Me.dgPresupuesto.CurrentRowIndex)
        End If
        Me.cbIngPor.SelectedIndex = 0

        'VB.SysContab.Rutinas.UsuariosAcciones(Me, Me.Name)
        '        Nuevo = "NO"
    End Sub

    Private Sub AddCustomDataTableStyle()

        'STEP 1: Create a DataTable style object and set properties if required.
        Dim ts1 As DataGridTableStyle
        ts1 = New DataGridTableStyle
        'specify the table from dataset (required step)
        ts1.MappingName = "Presupuesto"
        ' Set other properties (optional step)
        ts1.AlternatingBackColor = Color.LightBlue
        Dim colCount, ColTope, col As Integer
        colCount = 0

        Dim Cuenta As New DataGridTextBoxColumn
        Cuenta.MappingName = "cuenta"
        Cuenta.HeaderText = "Cuentas"
        Cuenta.ReadOnly = True
        Cuenta.Alignment = HorizontalAlignment.Left
        Cuenta.Width = 80
        Cuenta.NullText = ""


        ts1.GridColumnStyles.Add(Cuenta)
        colCount = (colCount + 1)

        Dim Concepto As New DataGridTextBoxColumn
        Concepto.MappingName = "concepto"
        Concepto.HeaderText = "Concepto"
        Concepto.ReadOnly = True
        Concepto.Alignment = HorizontalAlignment.Left
        Concepto.Width = 200
        Concepto.NullText = ""

        ts1.GridColumnStyles.Add(Concepto)
        colCount = (colCount + 1)
        col = colCount
        Select Case Me.cbVerPor.SelectedIndex
            Case 0
                ColTope = ColMes - 1
            Case 1
                colCount = ColMes
                ColTope = ColMes + 3
            Case 2
                colCount = ColMes + 4
                ColTope = ColMes + 5
        End Select

        While colCount <= ColTope
            ts1.GridColumnStyles.Add(New DataGridTextBoxColumn)
            ts1.GridColumnStyles.Item(col).MappingName = tCust.Columns(colCount).ColumnName
            ts1.GridColumnStyles.Item(col).HeaderText = Microsoft.VisualBasic.Left(tCust.Columns(colCount).ColumnName.ToUpper, 8)
            'Format(Microsoft.VisualBasic.Left(tCust.Columns(colCount).ColumnName.ToUpper, 2), "MMM") & _
            'Microsoft.VisualBasic.Right(tCust.Columns(colCount).ColumnName.ToUpper, 5)
            ts1.GridColumnStyles.Item(col).ReadOnly = True
            ts1.GridColumnStyles.Item(col).Alignment = HorizontalAlignment.Right
            ts1.GridColumnStyles.Item(col).Width = 100
            ts1.GridColumnStyles.Item(col).NullText = ""
            colCount = colCount + 1
            col = col + 1
        End While

        ts1.AllowSorting = False
        ts1.GridLineColor = Color.FromArgb(70, 130, 180)
        ts1.HeaderFont = Me.dgPresupuesto.HeaderFont
        ts1.HeaderBackColor = Color.LightSteelBlue  'Color.LightBlue
        ts1.PreferredRowHeight = 25

        myDataSet.Tables("Presupuesto").DefaultView.AllowDelete = False
        myDataSet.Tables("Presupuesto").DefaultView.AllowNew = False
        myDataSet.Tables("Presupuesto").DefaultView.AllowEdit = True

        dgPresupuesto.TableStyles.Clear()
        dgPresupuesto.TableStyles.Add(ts1)

    End Sub

    Private Sub MakeDataSet()
        ' Create a DataSet.
        myDataSet = New DataSet("myDataSet")
        tCust = New DataTable("Presupuesto")
        Dim col, columna As Integer
        columna = 0
        Dim cCuenta As DataColumn
        cCuenta = New DataColumn("Cuenta")
        tCust.Columns.Add(cCuenta)
        columna = columna + 1

        Dim cConcepto As DataColumn
        cConcepto = New DataColumn("Concepto")
        tCust.Columns.Add(cConcepto)
        columna = columna + 1

        Dim i As Date, Cadena, CadenaE As String
        i = New DateTime(Microsoft.VisualBasic.Right(Me.txtDesde.Text, 4), _
                        Microsoft.VisualBasic.Left(Me.txtDesde.Text, 2), _
                        1)
        'CDate("01\" & Microsoft.VisualBasic.Left(Me.txtDesde.Text, 2) & "\" & Microsoft.VisualBasic.Right(Me.txtDesde.Text, 4))
        col = columna
        'Ingresar los meses
        While i <= New DateTime(Microsoft.VisualBasic.Right(Me.txtHasta.Text, 4), _
                        Microsoft.VisualBasic.Left(Me.txtHasta.Text, 2), _
                        1)
            'CDate("01\" & Microsoft.VisualBasic.Left(Me.txtHasta.Text, 2) & "\" & Microsoft.VisualBasic.Right(Me.txtHasta.Text, 4))
            Cadena = Format(i, "MMM") & "_" & Format(i, "yyyy") & "_" & Format(i, "MM")
            tCust.Columns.Add(New DataColumn(Cadena))
            tCust.Columns(col).DefaultValue = 0.0
            col = col + 1
            i = New DateTime(Format(DateAdd(DateInterval.Month, 1, i), "yyyy"), _
                Format(DateAdd(DateInterval.Month, 1, i), "MM"), _
                1) 'CDate("01\" & Format(DateAdd(DateInterval.Month, 1, i), "MM") & "\" & Format(DateAdd(DateInterval.Month, 1, i), "yyyy"))
        End While

        ColMes = col

        'Quarters
        tCust.Columns.Add(New DataColumn("Q01"))
        tCust.Columns(col).DefaultValue = 0.0
        col = col + 1
        tCust.Columns.Add(New DataColumn("Q02"))
        tCust.Columns(col).DefaultValue = 0.0
        col = col + 1
        tCust.Columns.Add(New DataColumn("Q03"))
        tCust.Columns(col).DefaultValue = 0.0
        col = col + 1
        tCust.Columns.Add(New DataColumn("Q04"))
        tCust.Columns(col).DefaultValue = 0.0
        col = col + 1

        'Semesters
        tCust.Columns.Add(New DataColumn("S01"))
        tCust.Columns(col).DefaultValue = 0.0
        col = col + 1

        tCust.Columns.Add(New DataColumn("S02"))
        tCust.Columns(col).DefaultValue = 0.0
        col = col + 1


        i = New DateTime(Microsoft.VisualBasic.Right(Me.txtDesde.Text, 4), _
                        Microsoft.VisualBasic.Left(Me.txtDesde.Text, 2), _
                        1)
        'CDate("01\" & Microsoft.VisualBasic.Left(Me.txtDesde.Text, 2) & "\" & Microsoft.VisualBasic.Right(Me.txtDesde.Text, 4))

        'Ingresar las ejecuciones por mes
        While i <= New DateTime(Microsoft.VisualBasic.Right(Me.txtHasta.Text, 4), _
                        Microsoft.VisualBasic.Left(Me.txtHasta.Text, 2), _
                        1)
            'CDate("01\" & Microsoft.VisualBasic.Left(Me.txtHasta.Text, 2) & "\" & Microsoft.VisualBasic.Right(Me.txtHasta.Text, 4))
            Cadena = Format(i, "yyyy") & "_" & Format(i, "MM")
            tCust.Columns.Add(New DataColumn(Cadena))
            tCust.Columns(col).DefaultValue = 0.0
            col = col + 1
            i = New DateTime(Format(DateAdd(DateInterval.Month, 1, i), "yyyy"), _
                Format(DateAdd(DateInterval.Month, 1, i), "MM"), _
                1)
            'CDate("01\" & Format(DateAdd(DateInterval.Month, 1, i), "MM") & "\" & Format(DateAdd(DateInterval.Month, 1, i), "yyyy"))
        End While

        ColEje = col

        'Quarters
        tCust.Columns.Add(New DataColumn("EQ01"))
        tCust.Columns(col).DefaultValue = 0.0
        col = col + 1
        tCust.Columns.Add(New DataColumn("EQ02"))
        tCust.Columns(col).DefaultValue = 0.0
        col = col + 1
        tCust.Columns.Add(New DataColumn("EQ03"))
        tCust.Columns(col).DefaultValue = 0.0
        col = col + 1
        tCust.Columns.Add(New DataColumn("EQ04"))
        tCust.Columns(col).DefaultValue = 0.0
        col = col + 1

        'Semesters
        tCust.Columns.Add(New DataColumn("ES01"))
        tCust.Columns(col).DefaultValue = 0.0
        col = col + 1

        tCust.Columns.Add(New DataColumn("ES02"))
        tCust.Columns(col).DefaultValue = 0.0
        col = col + 1

        tCust.PrimaryKey = New DataColumn() {tCust.Columns("cuenta")}

        myDataSet.Tables.Add(tCust)
        myDataSet.Tables("Presupuesto").DefaultView.AllowDelete = False
        myDataSet.Tables("Presupuesto").DefaultView.AllowEdit = True




        Dim ds0 As New DataSet, j As Integer, nRow As DataRow
        If Nuevo = "SI" Then
            ''' Si es nuevo
            DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction

            Try
                CodigoPresupuesto = Presupuesto.GetPresupuesto_Nvo(Me.cdesde, Me.chasta, DBConnFacturas, transaccionFacturas)
                VB.SysContab.Rutinas.okTransaccion()
            Catch ex As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(ex.Message)
            End Try

            ds0 = Presupuesto.GetList_CuentasPresupuesto()
            For j = 0 To ds0.Tables("Presupuesto").Rows.Count - 1
                nRow = tCust.NewRow
                nRow("cuenta") = ds0.Tables("Presupuesto").Rows(j)("cuenta")
                nRow("concepto") = ds0.Tables("Presupuesto").Rows(j)("concepto")
                tCust.Rows.Add(nRow)
            Next
            Me.TPNueva.Text = "Nuevo Presupuesto: " & CodigoPresupuesto

        Else

            Dim dsPresupuesto As DataSet
            dsPresupuesto = Presupuesto.GetPresupuesto_Activo()
            If dsPresupuesto.Tables(0).Rows.Count > 0 Then 'Echar luego un vistazo si tenemos varios presupuestos activos
                If Microsoft.VisualBasic.Right(dsPresupuesto.Tables(0).Rows(0)("pre_desde"), 2) & "-" & _
                    Microsoft.VisualBasic.Left(dsPresupuesto.Tables(0).Rows(0)("pre_desde"), 4) <> Me.txtDesde.Text _
                Or Microsoft.VisualBasic.Right(dsPresupuesto.Tables(0).Rows(0)("pre_hasta"), 2) & "-" & _
                    Microsoft.VisualBasic.Left(dsPresupuesto.Tables(0).Rows(0)("pre_hasta"), 4) <> Me.txtHasta.Text Then

                    MsgBox("No existe presupuesto activo para este periodo", MsgBoxStyle.Critical, "Sts-Contab")
                    Exit Sub

                End If

                Dim dsPresupuestoDetalle As DataSet
                dsPresupuestoDetalle = Presupuesto.GetPresupuestoDetalle(dsPresupuesto.Tables(0).Rows(0)("pre_codigo"))
                dsPresupuestoDetalle.WriteXml(Application.StartupPath & "\xml\presupuesto.xml", XmlWriteMode.WriteSchema)
                Dim foundrow As DataRow = tCust.NewRow
                For j = 0 To dsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows.Count - 1
                    nRow = tCust.NewRow
                    If dsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows(j)("pre_cuenta") = "6111 10 01" Then
                        Dim r As Integer
                        r = 0
                    End If
                    i = New DateTime(Microsoft.VisualBasic.Left(dsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows(j)("pre_mes"), 4), _
                            Microsoft.VisualBasic.Right(dsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows(j)("pre_mes"), 2), _
                            1)
                    'CDate("01\" & Microsoft.VisualBasic.Right(dsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows(j)("pre_mes"), 2) & "\" & Microsoft.VisualBasic.Left(dsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows(j)("pre_mes"), 4))

                    Cadena = Format(i, "MMM") & "_" & Format(i, "yyyy") & "_" & Format(i, "MM")
                    CadenaE = Format(i, "yyyy") & "_" & Format(i, "MM")

                    foundrow = tCust.Rows.Find(dsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows(j)("pre_cuenta"))

                    If foundrow Is Nothing Then
                        nRow("cuenta") = dsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows(j)("pre_cuenta")
                        nRow("concepto") = dsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows(j)("nombre")
                        Try
                            nRow(Cadena) = dsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows(j)("pre_monto")
                            nRow(CadenaE) = dsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows(j)("pre_ejecutado")
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        tCust.Rows.Add(nRow)
                    Else
                        foundrow(Cadena) = dsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows(j)("pre_monto")
                        foundrow(CadenaE) = dsPresupuestoDetalle.Tables("PresupuestoDetalle").Rows(j)("pre_ejecutado")
                    End If



                Next
                Me.TPNueva.Text = "Presupuesto: " & dsPresupuesto.Tables(0).Rows(0)("pre_codigo")
                CodigoPresupuesto = dsPresupuesto.Tables(0).Rows(0)("pre_codigo")
            End If
        End If

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Nuevo = "NO"
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim rColumna As String
        Dim i, j, k As Integer
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction
        Me.cdesde = Microsoft.VisualBasic.Right(Me.txtDesde.Text, 4) & Microsoft.VisualBasic.Left(Me.txtDesde.Text, 2)
        Me.chasta = Microsoft.VisualBasic.Right(Me.txtHasta.Text, 4) & Microsoft.VisualBasic.Left(Me.txtHasta.Text, 2)
        Try
            If Nuevo = "SI" Then
                'Se vuelve a buscar un codigo de presupuesto
                CodigoPresupuesto = Presupuesto.GetPresupuesto_Nvo(Me.cdesde, Me.chasta, DBConnFacturas, transaccionFacturas)
                Presupuesto.Presupuesto_Desactivar(CodigoPresupuesto)
                Presupuesto.AddItem_Encabezado(CodigoPresupuesto, "Presupuesto " & CodigoPresupuesto, Me.cdesde, Me.chasta, Me.cbPeriodos.SelectedValue)
                'Agregar las cuentas
                For i = 0 To tCust.Rows.Count - 1
                    For j = 2 To ColMes - 1
                        rColumna = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(tCust.Columns(j).ColumnName, 8), 4) & _
                            Microsoft.VisualBasic.Right(tCust.Columns(j).ColumnName, 2)
                        Presupuesto.AddItem_Detalle(CodigoPresupuesto, tCust.Rows(i)("Cuenta"), rColumna, _
                        tCust.Rows(i)(tCust.Columns(j).ColumnName), tCust.Rows(i)(tCust.Columns(j).ColumnName))
                    Next
                Next
            Else
                'Editando presupuesto
                'Solo se edita el Detalle
                For i = 0 To tCust.Rows.Count - 1
                    k = ColMes + 6
                    For j = 2 To ColMes - 1
                        'Definir la columna de Ejecucion de Mes que se va a editar
                        rColumna = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(tCust.Columns(j).ColumnName, 8), 4) & _
                            Microsoft.VisualBasic.Right(tCust.Columns(j).ColumnName, 2)
                        If CDbl(tCust.Rows(i).Item(j)) < CDbl(tCust.Rows(i).Item(k)) Then
                            MsgBox("Esta intentando reducir el presupuesto a una cantidad menor que " & Chr(13) & _
                                "lo ya ejecutado. Se dejara por defecto la cantidad ejecutada." & Chr(13) & _
                                "Cuenta: " & tCust.Rows(i).Item(0) & "-" & tCust.Rows(i).Item(1) & Chr(13) & _
                                "Valor Ejecutado: " & tCust.Rows(i).Item(k) & Chr(13) & _
                                "Valor Digitado: " & tCust.Rows(i).Item(j) & Chr(13) _
                                , MsgBoxStyle.Critical + MsgBoxStyle.OKOnly)
                            tCust.Rows(i).Item(j) = tCust.Rows(i).Item(k)
                        End If
                        Presupuesto.UpdateItem_Detalle(CodigoPresupuesto, tCust.Rows(i)("Cuenta"), rColumna, _
                            tCust.Rows(i).Item(j))
                        k = k + 1
                    Next
                Next
            End If
            VB.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox(ex.Message)

        End Try

        Nuevo = "NO"
        Cargar()
        Me.TPNueva.Text = "Presupuesto: " & CodigoPresupuesto
    End Sub

    Private Sub Cargar()
        ''r.CambiarEstilo(Me)
        r.FormularioColor(Me)

        Me.dgPresupuesto.CaptionText = "Presupuesto"

        MakeDataSet()
        Me.dgPresupuesto.SetDataBinding(myDataSet, "Presupuesto")
        AddCustomDataTableStyle()

        dgPresupuesto.ReadOnly = True
        'Me.txtCb_codigo.Text = Conciliacion.CB_Nvo()
        ''Me.DTPDesde.Value = Me.Desde
        ''Me.DTPHasta.Value = Me.Hasta

        'Me.txtSaldoAnteriorBco.Text = Format(0.0, "###,###,##0.00")
        'Me.txtDebitosBCO.Text = Format(0.0, "###,###,##0.00")
        'Me.txtCreditosBCO.Text = Format(0.0, "###,###,##0.00")
        'Me.txtSaldoBco.Text = Format(0.0, "###,###,##0.00")

        'Me.txtSaldoAnteriorSys.Text = Format(0.0, "###,###,##0.00")
        'Me.txtDebitosSys.Text = Format(0.0, "###,###,##0.00")
        'Me.txtCreditosSys.Text = Format(0.0, "###,###,##0.00")
        'Me.txtSaldoSys.Text = Format(0.0, "###,###,##0.00")

        ''Cargar el historial
        'dsh = Conciliacion.Conciliaciones_Historial(Me.cbPeriodos.SelectedValue, Me.Banco, Me.Cuenta)
        'dsh.Tables("CB_E").PrimaryKey = New DataColumn() {dsh.Tables("CB_E").Columns("Codigo")}

        'Dim ParentCols() As DataColumn
        'ParentCols = New DataColumn() {dsh.Tables("CB_E").Columns("Codigo")}


        'dsh.Tables("CB_D").PrimaryKey = New DataColumn() {dsh.Tables("CB_D").Columns("Codigo"), _
        '                                    dsh.Tables("CB_D").Columns("DetId")}


        'Dim ChildCols() As DataColumn

        'ChildCols = New DataColumn() {dsh.Tables("CB_D").Columns("Codigo")}

        'Dim Relacion As DataRelation
        'Try
        '    Relacion = New DataRelation("Detalle", ParentCols, ChildCols)
        'Catch ex As DataException
        '    MsgBox(ex.Message)
        'End Try
        'dsh.Relations.Add(Relacion)



        'Me.dgEncabezado.SetDataBinding(dsh, "CB_E")
        'Tabla = dsh.Tables("CB_E")
        'r.FormatGenerico(Me.dgEncabezado, Tabla)
        'Me.dgEncabezado.CaptionText = "Conciliaciones Bancarias"
        'Me.dgEncabezado.ReadOnly = True
        'Me.dgEncabezado.AllowNavigation = False


        'Me.dgDetalle.SetDataBinding(dsh, "CB_E.Detalle")
        'Tabla = dsh.Tables("CB_D")
        'r.FormatGenerico(Me.dgDetalle, Tabla)
        'Me.dgDetalle.CaptionText = "Detalle de Conciliaciones Bancarias"
        'Me.dgDetalle.ReadOnly = True

        Me.Refresh()
    End Sub

    Private Sub TabCB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TPNueva.Click
        Me.cmdAceptar.Enabled = True
    End Sub
    Private Sub TPHistorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.cmdAceptar.Enabled = False
    End Sub

    Private Sub cbPeriodos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPeriodos.SelectedValueChanged


        Dim tipo As Type
        tipo = Me.cbPeriodos.SelectedValue.GetType

        If tipo.FullName = "System.Data.DataRowView" Then
            Exit Sub
        Else
            'Llenar los datos del groupbox con el rango de fechas
            Per_Detail = Periodos.GetDetails(Me.cbPeriodos.SelectedValue)
            If Per_Detail.ID Is Nothing Or Per_Detail.ID = 0 Then
                ' MsgBox("No existe el código de Periodo Fiscal seleccionado", MsgBoxStyle.Critical)
                Exit Sub
            Else
                Me.txtDesde.Text = Format(Per_Detail.Inicio, "MM") & "-" & Format(Per_Detail.Inicio, "yyyy")
                Me.txtHasta.Text = Format(Per_Detail.Final, "MM") & "-" & Format(Per_Detail.Final, "yyyy")
            End If

            ''Llenar los datos de los meses del periodo
            'Dim anio, aniofinal, i As Integer
            'anio = Format(Per_Detail.Inicio, "yyyy") + Format(Per_Detail.Inicio, "MM")
            'aniofinal = Format(Per_Detail.Final, "yyyy") + Format(Per_Detail.Final, "MM")
            'i = 1
            'Me.cbMes.Items.Clear()
            'Do While anio <= aniofinal
            '    Me.cbMes.Items.Add(Microsoft.VisualBasic.Left(anio, 4) & "-" & Format(DateAdd(DateInterval.Month, i - 1, Per_Detail.Inicio), "MM")) 'Format(DateAdd(DateInterval.Month, i - 1, Per_Detail.Inicio), "MMMM")
            '    anio = Format(DateAdd(DateInterval.Month, i, Per_Detail.Inicio), "yyyy") + Format(DateAdd(DateInterval.Month, i, Per_Detail.Inicio), "MM")
            '    i = i + 1
            'Loop
            'Me.cbMes.SelectedItem = Format(Per_Detail.Inicio, "yyyy") & "-" & Format(Per_Detail.Inicio, "MM")

        End If
    End Sub







    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cargar()
    End Sub



    Private Sub cbVerPor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbVerPor.SelectedIndexChanged
        If ColMes > 0 Then
            AddCustomDataTableStyle()
        End If
    End Sub

    Private Sub cbIngPor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbIngPor.SelectedIndexChanged
        Dim i, X, Y, Alto, Alto2, Ancho, Ancho2, linea, columna, Objeto As Integer


        X = 40
        Y = 16
        Alto = 24
        Ancho = 40
        Ancho2 = 96
        Alto2 = 22
        linea = 0
        columna = 0
        Objeto = 0
        Select Case Me.cbIngPor.SelectedIndex
            Case 0
                Me.GBMeses.Visible = True
                Me.GBQuarters.Visible = False
                Me.GBSemestre.Visible = False

                'Crear los textboxes pa los meses
                For i = 2 To ColMes - 1
                    'crear la etiqueta
                    Me.GBMeses.Controls.Add(New Label)
                    Me.GBMeses.Controls.Item(Me.GBMeses.Controls.Count - 1).Text = Microsoft.VisualBasic.Left(tCust.Columns(i).ColumnName, 3)
                    Me.GBMeses.Controls.Item(Me.GBMeses.Controls.Count - 1).Location = New System.Drawing.Point(X + (columna * 145), Y + (linea * 24))
                    Me.GBMeses.Controls.Item(Me.GBMeses.Controls.Count - 1).Name = "lblM" + Microsoft.VisualBasic.Right(tCust.Columns(i).ColumnName, 2)
                    Me.GBMeses.Controls.Item(Me.GBMeses.Controls.Count - 1).Size = New System.Drawing.Size(Ancho, Alto)

                    ' Crear el txtbox
                    Me.GBMeses.Controls.Add(New TextBox)
                    'Me.GBMeses.Controls.Item(me.GBMeses.Controls.Count - 1).Text = Microsoft.VisualBasic.Left(tCust.Columns(i).ColumnName, 3)
                    Me.GBMeses.Controls.Item(Me.GBMeses.Controls.Count - 1).Location = New System.Drawing.Point(X + 40 + (columna * 145), Y + (linea * 24))
                    Me.GBMeses.Controls.Item(Me.GBMeses.Controls.Count - 1).Name = "txtM" + Microsoft.VisualBasic.Right(tCust.Columns(i).ColumnName, 2)
                    Me.GBMeses.Controls.Item(Me.GBMeses.Controls.Count - 1).Size = New System.Drawing.Size(Ancho2, Alto2)
                    Objeto = Objeto + 1

                    If Objeto Mod 3 = 0 Then
                        columna = columna + 1
                        linea = 0
                    Else
                        linea = Objeto Mod 3
                    End If

                Next


            Case 1
                Me.GBMeses.Visible = False
                Me.GBQuarters.Visible = True
                Me.GBSemestre.Visible = False

            Case 2
                Me.GBMeses.Visible = False
                Me.GBQuarters.Visible = False
                Me.GBSemestre.Visible = True
        End Select
    End Sub

    Private Sub Sumar(ByVal linea As Integer)
        Dim Col, i, Q, S As Integer
        Dim Suma, SumaS As Double
        Q = ColMes
        S = ColMes + 4
        Suma = 0.0
        SumaS = 0.0
        For Col = 1 To ColMes - 2
            Suma = Suma + tCust.Rows(linea).Item(Col + 1)
            SumaS = SumaS + tCust.Rows(linea).Item(Col + 1)
            If Col Mod 3 = 0 Then
                tCust.Rows(linea).Item(Q) = Suma
                Q = Q + 1
                Suma = 0.0
            End If
            If Col Mod 6 = 0 Then
                tCust.Rows(linea).Item(S) = SumaS
                S = S + 1
                SumaS = 0.0
            End If
        Next
    End Sub


    Private Sub Actualizar(ByVal linea As Integer)
        Dim I As Integer
        For I = 2 To ColMes - 1
            Me.GBMeses.Controls.Item(2 * (I - 2) + 1).Text = tCust.Rows(linea).Item(I)
        Next
        'los quarters
        Me.txtQ01.Text = tCust.Rows(linea).Item(ColMes)
        Me.txtQ02.Text = tCust.Rows(linea).Item(ColMes + 1)
        Me.txtQ03.Text = tCust.Rows(linea).Item(ColMes + 2)
        Me.txtQ04.Text = tCust.Rows(linea).Item(ColMes + 3)

        'los Semestres
        Me.txtS01.Text = tCust.Rows(linea).Item(ColMes + 4)
        Me.txtS02.Text = tCust.Rows(linea).Item(ColMes + 5)
    End Sub


    Private Sub dgPresupuesto_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPresupuesto.CurrentCellChanged
        Dim i, j As Integer

        Sumar(Me.dgPresupuesto.CurrentRowIndex)
        Actualizar(Me.dgPresupuesto.CurrentRowIndex)

        If Me.dgPresupuesto.CurrentCell.ColumnNumber > 1 Then
            Select Case Me.cbVerPor.SelectedIndex
                Case 0 'Meses
                    i = ColMes + 4
                    j = 0
                Case 1
                    i = ColEje - 2
                    j = ColMes - 2
                Case 2
                    i = ColEje + 2
                    j = ColMes + 2
            End Select
            If Me.dgPresupuesto.CurrentCell.ColumnNumber > 1 Then
                Me.txtEjecutado.Text = tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(i + Me.dgPresupuesto.CurrentCell.ColumnNumber)
                Me.txtPEjecutado.Text = Math.Round(((tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(i + Me.dgPresupuesto.CurrentCell.ColumnNumber) / _
                                    IIf(tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(j + Me.dgPresupuesto.CurrentCell.ColumnNumber) = 0, 1, tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(j + Me.dgPresupuesto.CurrentCell.ColumnNumber))) * 100.0), 2).ToString & "%"
                Me.TxtDisponible.Text = tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(j + Me.dgPresupuesto.CurrentCell.ColumnNumber) - _
                                    tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(i + Me.dgPresupuesto.CurrentCell.ColumnNumber)
                Me.txtPDisponible.Text = Math.Round((((tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(j + Me.dgPresupuesto.CurrentCell.ColumnNumber) - _
                                    tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(i + Me.dgPresupuesto.CurrentCell.ColumnNumber)) / _
                                    IIf(tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(j + Me.dgPresupuesto.CurrentCell.ColumnNumber) = 0, 1, tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(j + Me.dgPresupuesto.CurrentCell.ColumnNumber)) * 100.0)), 2).ToString & "%"

            End If
            Me.GBEjecucion.Text = "Ejecución de Presupuesto para: " & _
                Microsoft.VisualBasic.Left(tCust.Columns.Item(j + Me.dgPresupuesto.CurrentCell.ColumnNumber).ColumnName, 8)
        Else
            Me.txtEjecutado.Text = 0.0
            Me.txtPEjecutado.Text = "0.00%"
            Me.TxtDisponible.Text = 0.0
            Me.txtPDisponible.Text = "0.00%"
            Me.GBEjecucion.Text = "Ejecución de Presupuesto"
        End If
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim I, cuota1, cuota2, cuota3, cuota4, Resto1, Resto2, Resto3, Resto4 As Integer


        Select Case Me.cbIngPor.SelectedIndex
            Case 0 'Meses
                For I = 2 To ColMes - 1
                    tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(I) = Me.GBMeses.Controls.Item(2 * (I - 2) + 1).Text
                Next
            Case 1 'Quarters
                Resto1 = Me.txtQ01.Text
                cuota1 = Me.txtQ01.Text / 3
                Resto2 = Me.txtQ02.Text
                cuota2 = Me.txtQ02.Text / 3
                Resto3 = Me.txtQ03.Text
                cuota3 = Me.txtQ03.Text / 3
                Resto4 = Me.txtQ04.Text
                cuota4 = Me.txtQ04.Text / 3

                For I = 2 To ColMes - 1
                    'Primer Quarter

                    If I <= 4 Then
                        tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(I) = IIf(Resto1 < cuota1, Resto1, cuota1)
                        Resto1 = Resto1 - cuota1
                    End If
                    ' Segundo Quarter
                    If I > 4 And I <= 7 Then
                        tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(I) = IIf(Resto2 < cuota2, Resto2, cuota2)
                        Resto2 = Resto2 - cuota2
                    End If
                    ' Tercer Quarter
                    If I > 7 And I <= 10 Then
                        tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(I) = IIf(Resto3 < cuota3, Resto3, cuota3)
                        Resto3 = Resto3 - cuota3

                    End If
                    ' cuarter Quarter
                    If I > 10 And I <= 13 Then
                        tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(I) = IIf(Resto4 < cuota4, Resto4, cuota4)
                        Resto4 = Resto4 - cuota4
                    End If
                Next

            Case 2 'Semestres
                Resto1 = Me.txtS01.Text
                cuota1 = Me.txtS01.Text / 6
                Resto2 = Me.txtS02.Text
                cuota2 = Me.txtS02.Text / 6

                For I = 2 To ColMes - 1
                    'Primer Semestre

                    If I <= 7 Then
                        tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(I) = IIf(Resto1 < cuota1, Resto1, cuota1)
                        Resto1 = Resto1 - cuota1
                    End If
                    ' Segundo Semestre
                    If I > 7 And I <= 13 Then
                        tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(I) = IIf(Resto2 < cuota2, Resto2, cuota2)
                        Resto2 = Resto2 - cuota2

                    End If
                Next

        End Select

        Sumar(Me.dgPresupuesto.CurrentRowIndex)
        Actualizar(Me.dgPresupuesto.CurrentRowIndex)
        If Me.dgPresupuesto.CurrentRowIndex < tCust.Rows.Count - 1 Then
            Me.dgPresupuesto.CurrentRowIndex = Me.dgPresupuesto.CurrentRowIndex + 1
        End If

    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        Nuevo = "SI"
        DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        DBConnFacturas.Open()
        transaccionFacturas = DBConnFacturas.BeginTransaction

        Me.cdesde = Microsoft.VisualBasic.Right(Me.txtDesde.Text, 4) & Microsoft.VisualBasic.Left(Me.txtDesde.Text, 2)
        Me.chasta = Microsoft.VisualBasic.Right(Me.txtHasta.Text, 4) & Microsoft.VisualBasic.Left(Me.txtHasta.Text, 2)
        Try
            CodigoPresupuesto = Presupuesto.GetPresupuesto_Nvo(Me.cdesde, Me.chasta, DBConnFacturas, transaccionFacturas)
            VB.SysContab.Rutinas.okTransaccion()
        Catch ex As Exception
            VB.SysContab.Rutinas.ErrorTransaccion()
            MsgBox(ex.Message)
        End Try

        Me.TPNueva.Text = "Presupuesto: " & CodigoPresupuesto
        Cargar()
        If Me.dgPresupuesto.CurrentRowIndex >= 0 Then
            Sumar(Me.dgPresupuesto.CurrentRowIndex)
            Actualizar(Me.dgPresupuesto.CurrentRowIndex)
        End If

    End Sub


    Private Sub GBEjecucion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GBEjecucion.Enter

    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

        Dim f As frmReportePresupuesto = f.Instance

        f.MdiParent = Me.ParentForm
        f.Presupuesto = CodigoPresupuesto
        f.Periodo = Me.cbPeriodos.SelectedValue
        f.cuenta = tCust.Rows(Me.dgPresupuesto.CurrentRowIndex).Item(0)
        f.Show()
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub TabCB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabCB.SelectedIndexChanged

    End Sub

    Private Sub dgPresupuesto_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgPresupuesto.Navigate

    End Sub

    Private Sub dgPresupuesto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPresupuesto.DoubleClick
        If dgPresupuesto.CurrentRowIndex >= 0 Then
            Dim forma As New FrmPresupuestoRubros
            With dgPresupuesto
                forma.Cuenta = .Item(.CurrentRowIndex, 0)
                forma.Presupuesto = CodigoPresupuesto
                forma.ShowDialog()
                Cargar()
            End With
        End If
    End Sub
End Class

