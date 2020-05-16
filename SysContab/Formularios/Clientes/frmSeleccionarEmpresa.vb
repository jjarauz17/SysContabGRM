'Imports System.Threading

Public Class frmSeleccionarEmpresa
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmSeleccionarEmpresa = Nothing

    Public Shared Function Instance() As frmSeleccionarEmpresa
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmSeleccionarEmpresa()
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
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSeleccionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbEmpresas As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeleccionarEmpresa))
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSeleccionar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbEmpresas = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cbEmpresas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Image = Global.SysContab.My.Resources.Resources._115_25x25
        Me.cmdCancelar.Location = New System.Drawing.Point(125, 76)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(90, 32)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Image = Global.SysContab.My.Resources.Resources._114_25x25
        Me.cmdSeleccionar.Location = New System.Drawing.Point(16, 76)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(103, 32)
        Me.cmdSeleccionar.TabIndex = 1
        Me.cmdSeleccionar.Text = "Seleccionar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.cmdSeleccionar)
        Me.PanelControl1.Controls.Add(Me.cbEmpresas)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(440, 113)
        Me.PanelControl1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(16, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Empresa: "
        '
        'cbEmpresas
        '
        Me.cbEmpresas.Location = New System.Drawing.Point(16, 31)
        Me.cbEmpresas.Name = "cbEmpresas"
        Me.cbEmpresas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpresas.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbEmpresas.Properties.Appearance.Options.UseFont = True
        Me.cbEmpresas.Properties.Appearance.Options.UseForeColor = True
        Me.cbEmpresas.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpresas.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbEmpresas.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbEmpresas.Properties.AppearanceDropDown.Options.UseForeColor = True
        Me.cbEmpresas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpresas.Properties.ShowFooter = False
        Me.cbEmpresas.Properties.ShowHeader = False
        Me.cbEmpresas.Size = New System.Drawing.Size(406, 22)
        Me.cbEmpresas.TabIndex = 0
        '
        'frmSeleccionarEmpresa
        '
        Me.AcceptButton = Me.cmdSeleccionar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(459, 137)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeleccionarEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cbEmpresas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Empresa As New VB.SysContab.EmpresasDB
    Dim Config As New VB.SysContab.ConfiguracionDB
    Dim EmpresaDetalle As New VB.SysContab.EmpresasDetails()
    Dim AuditoriaEmpresa As New VB.SysContab.AuditoriaDB
    Dim ConfigDetalles As New VB.SysContab.ConfiguracionDetails

    'Dim myThreadDelegate As New ThreadStart(AddressOf Reportes)
    'Dim myThread As New Threading.Thread(AddressOf Reportes)

    Dim r As New VB.SysContab.Rutinas()

    Private Sub frmSeleccionarEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cbEmpresas.Properties.DataSource = Empresa.EmpresasXUsuarios(Login, Password).Tables("Empresas")
            cbEmpresas.Properties.ValueMember = "Codigo"
            cbEmpresas.Properties.DisplayMember = "Nombre"
            cbEmpresas.Properties.PopulateColumns()
            '
            For i As Integer = 0 To Me.cbEmpresas.Properties.Columns.Count - 1
                Me.cbEmpresas.Properties.Columns(i).Visible = False
            Next
            '
            Me.cbEmpresas.Properties.Columns(1).Visible = True
            cbEmpresas.ItemIndex = 0
            '
            If Empresa.EmpresasXUsuarios(Login, Password).Tables("Empresas").Rows.Count = 1 Then
                Seleccionar()
            ElseIf Empresa.EmpresasXUsuarios(Login, Password).Tables("Empresas").Rows.Count = 0 Then
                With My.Forms.FrmNewBusiness
                    If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                        End
                    Else
                        .Dispose()
                        '
                        Me.Close()
                        My.Forms.frmPrincipalRibbon.Show()
                        My.Forms.frmPrincipalRibbon.WindowState = FormWindowState.Maximized
                    End If
                End With

                'Dim forma As New FrmNewBusiness
                'If forma.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                '    End
                'Else
                '    Me.Hide()
                '    FormPrincipal.ShowDialog()
                '    Me.Close()
                'End If
            Else
                Me.Text = "** Seleccionar Empresa **"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Me.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        Me.Seleccionar()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        End
    End Sub

    Private Sub Seleccionar()
        ShowSplash("Cargando Interfaz de Usuario...")

        EmpresaActual = cbEmpresas.EditValue
        NombreEmpresaActual = cbEmpresas.Text
        EmpresaDetalle = VB.SysContab.EmpresasDB.GetDetails(EmpresaActual)
        ConfigDetalles = VB.SysContab.ConfiguracionDB.GetConfigDetails()

        MonedaBase = EmpresaDetalle.MonedaBase
        Round = "n" & EmpresaDetalle.Decimales

        Try
            RoundP = "n" & ConfigDetalles.Decimales
        Catch ex As Exception
            RoundP = "n2"
        End Try

        GuardaDatos("_AuditoriaEmpresa '" & formtitulo & "'," & EmpresaActual & ",2,'',''")

        'AuditoriaEmpresa.AuditoriaSelEmpresa(formtitulo, 2)

        Dim lds As New DataSet
        lds = VB.SysContab.EmpresasDB.GetLogoEmpresa()
        lds.WriteXml(Application.StartupPath & "\xml\logoempresa.xml", XmlWriteMode.WriteSchema)
        '                
        CierreDeDia()
        My.Forms.frmPrincipalRibbon.Show()
        My.Forms.frmPrincipalRibbon.WindowState = FormWindowState.Maximized
        '
        Me.Close()

        HideSplash()
        'Me.Hide()
        'FormPrincipal.ShowDialog()
        'Activar para modulos cortos. Recoradr activar el corrspondiente en frmPrincipalFacturacion y Contab, y en modulo1
        'Dim N As frmPrincipalCortos = N.Instance
        'N.ShowDialog()
        'Me.Close()
    End Sub

    Sub CierreDeDia()
        Try
            CierreDia = CDate(ObtieneDatos("SELECT MAX(Fecha) FROM CierreDia WHERE Empresa = " & EmpresaActual).Rows(0).Item(0))
        Catch ex As Exception
            CierreDia = vbNullString
            'GuardaDatos("sp_CierreAdd " & EmpresaActual)
            'GoTo Verificar
        End Try
    End Sub
End Class
