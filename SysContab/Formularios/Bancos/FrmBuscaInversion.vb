Imports System.Data
Imports System.Data.SqlClient

Public Class FrmBuscaInversion
    Inherits DevExpress.XtraEditors.XtraForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmdaceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdcancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdaceptar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdcancelar = New DevExpress.XtraEditors.SimpleButton
        Me.GridDetail = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.GridDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdaceptar
        '
        Me.cmdaceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdaceptar.Location = New System.Drawing.Point(408, 256)
        Me.cmdaceptar.Name = "cmdaceptar"
        Me.cmdaceptar.TabIndex = 1
        Me.cmdaceptar.Text = "&Aceptar"
        '
        'cmdcancelar
        '
        Me.cmdcancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdcancelar.Location = New System.Drawing.Point(496, 256)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.TabIndex = 2
        Me.cmdcancelar.Text = "&Cancelar"
        '
        'GridDetail
        '
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridDetail.EmbeddedNavigator.Name = ""
        Me.GridDetail.Location = New System.Drawing.Point(8, 8)
        Me.GridDetail.MainView = Me.GridView1
        Me.GridDetail.Name = "GridDetail"
        Me.GridDetail.Size = New System.Drawing.Size(560, 232)
        Me.GridDetail.TabIndex = 4
        Me.GridDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView1.GridControl = Me.GridDetail
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False

        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "No"
        Me.GridColumn1.FieldName = "InversionNo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Fecha"
        Me.GridColumn2.DisplayFormat.FormatString = "D"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "Fecha"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 120
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Plazo"
        Me.GridColumn3.FieldName = "Plazo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 65
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Interes"
        Me.GridColumn4.CustomizationCaption = "Interes"
        Me.GridColumn4.DisplayFormat.FormatString = "c2"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Interes"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 65
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Institucion"
        Me.GridColumn6.FieldName = "Nombre"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 174
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Monto"
        Me.GridColumn5.DisplayFormat.FormatString = "c2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Valor"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 65
        '
        'FrmBuscaInversion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(225, Byte), CType(236, Byte), CType(236, Byte))
        Me.ClientSize = New System.Drawing.Size(576, 286)
        Me.Controls.Add(Me.GridDetail)
        Me.Controls.Add(Me.cmdcancelar)
        Me.Controls.Add(Me.cmdaceptar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscaInversion"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "FrmBuscaInversion"
        CType(Me.GridDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim vista As DevExpress.XtraGrid.Views.Grid.GridView

    Private Sub FrmBuscaInversion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DC As New SqlConnection(VB.SysContab.Rutinas.AbrirConexion)
        Dim DA As New SqlDataAdapter("SELECT IdInversion AS InversionNo,Fecha,Interes,Plazo,Valor,Nombre FROM Inversiones WHERE IdEmpresa =" & EmpresaActual, DC)
        Dim DS As New DataSet
        DA.Fill(DS, "Inversiones")
        GridDetail.DataSource = DS
        GridDetail.DataMember = "Inversiones"
    End Sub

    Public Function Mostrar() As Integer
        Me.ShowDialog()
        If DialogResult <> DialogResult.Cancel Then
            If vista.SelectedRowsCount > 0 Then
                Dim fila As DataRow
                For Each i As Integer In vista.GetSelectedRows
                    If i < 0 Then
                        Return 0
                        Exit For
                    End If
                    fila = vista.GetDataRow(i)
                    Return fila.Item("InversionNo")
                Next
            Else
                Return 0
            End If
        Else
                Return 0
        End If
    End Function

    Private Sub cmdcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaceptar.Click
        vista = GridDetail.MainView
        If vista.SelectedRowsCount < 0 Then Exit Sub
    End Sub
End Class
