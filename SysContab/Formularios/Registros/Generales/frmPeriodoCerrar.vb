Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmPeriodoCerrar
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents etPeriodo As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.etPeriodo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Procesando información..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'etPeriodo
        '
        Me.etPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etPeriodo.ForeColor = System.Drawing.Color.Maroon
        Me.etPeriodo.Location = New System.Drawing.Point(192, 48)
        Me.etPeriodo.Name = "etPeriodo"
        Me.etPeriodo.Size = New System.Drawing.Size(72, 16)
        Me.etPeriodo.TabIndex = 1
        Me.etPeriodo.Text = "Periodo"
        Me.etPeriodo.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmPeriodoCerrar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(296, 70)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.etPeriodo, Me.Label1})
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPeriodoCerrar"
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Cerrar Periodo Contable"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim PeriodosDB As New VB.SysContab.PeriodosDB()
    Dim r As New VB.SysContab.Rutinas()
    Dim Empresas As New VB.SysContab.EmpresasDB()
    Dim EmpresaDetalles As New VB.SysContab.EmpresasDetails()

    'Public Inicio As Integer
    'Public Final As Integer

    Public Inicio1 As DateTime
    Public Final1 As DateTime

    Private Sub frmPeriodoCerrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim PeriodoNuevo As Integer
        'Dim Inicio As Integer
        'Dim Final As Integer

        'EmpresaDetalles = Empresas.GetDetails(EmpresaActual)
        'Dim PerDetalles As VB.SysContab.PeriodoDetails = PeriodosDB.GetDetails(7)

        'PeriodoNuevo = PeriodosDB.PeriodoNuevo(7)

        'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
        'DBConnFacturas.Open()

        'transaccionFacturas = DBConnFacturas.BeginTransaction


        'Inicio = PerDetalles.Final.AddDays(1).Year
        'Final = PerDetalles.Final.AddYears(1).Year

        'Try
        '    PeriodosDB.CopiarSaldos(7, PerDetalles.Inicio, PerDetalles.Final, EmpresaDetalles.MonedaBase, EmpresaDetalles.MonedaBase, PerDetalles.Final.AddDays(1), PerDetalles.Final.AddYears(1), "PERIODO " & Inicio & " - " & Final, 1)
        '    'PeriodosDB.CerrarPeriodo(Me.dgEmpresas.Item(Me.dgEmpresas.CurrentRowIndex, 0), 1)
        '    VB.SysContab.Rutinas.okTransaccion()
        'Catch ex As Exception
        '    VB.SysContab.Rutinas.ErrorTransaccion()
        '    MsgBox(ex.Message)
        '    'Me.Close()
        'End Try

        'Dim f As frmPeriodoListar = f.Instance
        ''ds = PeriodosDB.GetLista()
        'f.dgEmpresas.DataSource = PeriodosDB.GetLista().Tables("Periodos").DefaultView

        'FormPrincipal.StatusBar1.Panels(2).Text = VB.SysContab.PeriodosDB.GetDetails(VB.SysContab.PeriodosDB.Activo).Descripcion.ToString

        'Me.Close()

        'Me.Close()
        'Me.ProgressBar1.Minimum = 0
        'Me.ProgressBar1.Maximum = 60
        'Me.ProgressBar1.Value = 0

    End Sub

End Class
