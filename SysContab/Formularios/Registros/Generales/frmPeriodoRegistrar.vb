Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmPeriodoRegistrar
    Inherits DevExpress.XtraEditors.XtraForm

    Private Shared ChildInstance As frmPeriodoRegistrar = Nothing

    Public Shared Function Instance() As frmPeriodoRegistrar
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmPeriodoRegistrar()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents ckbPer As System.Windows.Forms.CheckBox
    Friend WithEvents ckbPerHab As System.Windows.Forms.CheckBox
    Friend WithEvents txtValidador As System.Windows.Forms.TextBox
    Friend WithEvents chkActual As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkActual = New System.Windows.Forms.CheckBox
        Me.ckbPerHab = New System.Windows.Forms.CheckBox
        Me.ckbPer = New System.Windows.Forms.CheckBox
        Me.txtPeriodo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.txtValidador = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chkActual)
        Me.GroupBox1.Controls.Add(Me.ckbPerHab)
        Me.GroupBox1.Controls.Add(Me.ckbPer)
        Me.GroupBox1.Controls.Add(Me.txtPeriodo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpHasta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDesde)
        Me.GroupBox1.Controls.Add(Me.txtValidador)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(872, 241)
        Me.GroupBox1.TabIndex = 149
        Me.GroupBox1.TabStop = False
        '
        'chkActual
        '
        Me.chkActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkActual.Location = New System.Drawing.Point(512, 69)
        Me.chkActual.Name = "chkActual"
        Me.chkActual.Size = New System.Drawing.Size(224, 26)
        Me.chkActual.TabIndex = 152
        Me.chkActual.Text = "Periodo Actual"
        '
        'ckbPerHab
        '
        Me.ckbPerHab.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbPerHab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ckbPerHab.Location = New System.Drawing.Point(512, 43)
        Me.ckbPerHab.Name = "ckbPerHab"
        Me.ckbPerHab.Size = New System.Drawing.Size(224, 26)
        Me.ckbPerHab.TabIndex = 17
        Me.ckbPerHab.Text = "Periodo Habilitado"
        '
        'ckbPer
        '
        Me.ckbPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbPer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ckbPer.Location = New System.Drawing.Point(512, 17)
        Me.ckbPer.Name = "ckbPer"
        Me.ckbPer.Size = New System.Drawing.Size(224, 26)
        Me.ckbPer.TabIndex = 16
        Me.ckbPer.Text = "Periodo Activo"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPeriodo.Location = New System.Drawing.Point(88, 95)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(368, 21)
        Me.txtPeriodo.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(24, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 26)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Periodo"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(88, 60)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(112, 20)
        Me.dtpHasta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Desde:"
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(88, 26)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(112, 20)
        Me.dtpDesde.TabIndex = 0
        '
        'txtValidador
        '
        Me.txtValidador.Location = New System.Drawing.Point(760, 26)
        Me.txtValidador.Name = "txtValidador"
        Me.txtValidador.Size = New System.Drawing.Size(100, 21)
        Me.txtValidador.TabIndex = 151
        Me.txtValidador.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Controls.Add(Me.cmdCancelar)
        Me.GroupBox2.Location = New System.Drawing.Point(880, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 241)
        Me.GroupBox2.TabIndex = 150
        Me.GroupBox2.TabStop = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAceptar.Location = New System.Drawing.Point(16, 17)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(72, 26)
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(16, 52)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(72, 26)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Salir"
        '
        'frmPeriodoRegistrar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(994, 260)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPeriodoRegistrar"
        Me.Text = "Registrar Periodos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim PeriodosDB As New VB.SysContab.PeriodosDB()
    Dim r As New VB.SysContab.Rutinas()

    Private Sub frmPeriodoRegistrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'If Me.txtPeriodo.Enabled = False Then
        '    Me.ckbPer.Enabled = False
        '    Me.ckbPerHab.Enabled = False
        'Else
        '    If txtValidador.Text <> "" Then
        '        ckbPerHab.Visible = True
        '        If ckbPerHab.Checked = False Then
        '            ckbPer.Enabled = False
        '        Else
        '            ckbPer.Enabled = True
        '        End If
        '    Else
        '        ckbPerHab.Visible = False
        '    End If

        '    If ckbPer.Checked = True Then
        '        ckbPer.Enabled = False
        '        ckbPerHab.Enabled = False
        '    Else
        '        ckbPer.Enabled = True
        '        ckbPerHab.Enabled = True
        '    End If

        'End If
    End Sub
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Validar() = True Then
            If txtValidador.Text = "" Then 'Nuevo Registro de Periodo
                DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
                DBConnFacturas.Open()
                transaccionFacturas = DBConnFacturas.BeginTransaction
                Try
                    PeriodosDB.AddItem(dtpDesde.Value.Date, dtpHasta.Value.Date, txtPeriodo.Text, ckbPer.Checked, IIf(Me.chkActual.Checked, 1, 0))
                    VB.SysContab.Rutinas.okTransaccion()
                Catch ex As Exception
                    VB.SysContab.Rutinas.ErrorTransaccion()
                    MsgBox(ex.Message)
                End Try
            Else
                If PeriodosDB.Update(txtValidador.Text, dtpDesde.Value.Date, dtpHasta.Value.Date, txtPeriodo.Text, ckbPerHab.Checked, ckbPer.Checked, IIf(Me.chkActual.Checked, 1, 0)) = True Then
                    'MsgBox("El Registro ha sido actualizado correctamente", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("Error al actualizar el registro", MsgBoxStyle.Critical)
                End If
            End If
        End If
        Me.Close()
    End Sub
    Public Function Validar() As Boolean
        If txtPeriodo.Text = "" Then
            MsgBox("Debe ingresar un nombre del Periodo", MsgBoxStyle.Exclamation)
            Return False
            Exit Function
        End If

        If dtpDesde.Value.Date = dtpHasta.Value.Date Then
            MsgBox("La fecha de inicio y fin del periodo no pueden ser iguales", MsgBoxStyle.Exclamation)
            Return False
            Exit Function
        End If

        If dtpDesde.Value.Date > dtpHasta.Value.Date Then
            MsgBox("La fecha de inicio debe ser menor a la de fin del periodo", MsgBoxStyle.Exclamation)
            Return False
            Exit Function
        End If

        Return True
    End Function
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
    Private Sub frmPeriodoRegistrar_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim f As frmPeriodoListar = frmPeriodoListar.Instance()
        f.Cargar()
        'f.dgEmpresas.DataSource = PeriodosDB.GetLista().Tables("Periodos").DefaultView
        'FormPrincipal.StatusBar1.Panels(2).Text = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Actual).Descripcion.ToString
    End Sub
End Class
