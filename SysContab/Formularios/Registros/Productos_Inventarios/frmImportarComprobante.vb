Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraWizard
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Linq

Public Class frmImportarComprobante
    Inherits XtraForm

    Public DT As New DataTable

    Dim Temp As Boolean = False

    Public Sub New()
        Me.New(True, WizardStyle.Wizard97)
    End Sub

    Public IdBuy As Integer
    Public Tipo As String = "FISICO"
    Dim DT_ASIGNAR As New DataTable("ASIGNAR")

    Public Ok As String = "NO"

    Public Sub New(ByVal allowAnimation As Boolean, ByVal style As WizardStyle)
        InitializeComponent()
        WizardControl1.AllowTransitionAnimation = allowAnimation
        WizardControl1.WizardStyle = style
    End Sub

    Private finish As Boolean = False

    Private Sub frmImportPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Tipo = "FISICO" Then
                Dim dc As New DataColumn("CODIGO")
                DT.Columns.Add(dc)

                dc = New DataColumn("DESCRIPCION")
                DT.Columns.Add(dc)

                dc = New DataColumn("UNIDAD")
                DT.Columns.Add(dc)

                dc = New DataColumn("MODELO")
                DT.Columns.Add(dc)

                dc = New DataColumn("UBICACION")
                DT.Columns.Add(dc)

                dc = New DataColumn("FISICO")
                DT.Columns.Add(dc)

                dc = New DataColumn("COSTO")
                DT.Columns.Add(dc)

            ElseIf Tipo = "TASA_CAMBIO" Then

                Dim dc As New DataColumn("Fecha")
                DT.Columns.Add(dc)

                dc = New DataColumn("Tasa")
                DT.Columns.Add(dc)

                dc = New DataColumn("Paralelo")
                DT.Columns.Add(dc)
            ElseIf Tipo = "COMPROBANTE" Then

                Dim dc As New DataColumn("Cuenta")
                DT.Columns.Add(dc)

                dc = New DataColumn("Debito")
                DT.Columns.Add(dc)

                dc = New DataColumn("Credito")
                DT.Columns.Add(dc)

                dc = New DataColumn("NoOrden")
                DT.Columns.Add(dc)

                dc = New DataColumn("Factura")
                DT.Columns.Add(dc)

                dc = New DataColumn("Concepto")
                DT.Columns.Add(dc)

                dc = New DataColumn("IdProyecto")
                DT.Columns.Add(dc)

                dc = New DataColumn("IdOrdenCompra")
                DT.Columns.Add(dc)

                dc = New DataColumn("ret")
                DT.Columns.Add(dc)
            End If
        Catch ex As Exception
        End Try

        WizardPage1.AllowNext = False
        WizardPage2.AllowNext = False
    End Sub

    Public Archivo As String
    Public Hoja As String

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Me.OpenFileDialog1.DefaultExt = "*.xls"
        Me.OpenFileDialog1.Filter = "(*.xls)|*.xls"

        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                Archivo = Me.OpenFileDialog1.FileName
                Dim Conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Archivo & ";Extended Properties=""Excel 8.0;HDR=YES;IMEX=1""")
                Dim dtHojas As DataTable

                Conn.Open()

                dtHojas = Conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                      New Object() {Nothing, Nothing, Nothing, "TABLE"})

                ListBoxControl1.DataSource = dtHojas
                ListBoxControl1.DisplayMember = "TABLE_NAME"
                ListBoxControl1.ValueMember = "TABLE_NAME"

                Conn.Close()

                WizardPage1.AllowNext = True

                LabelControl1.Text = "Trabajando con Archivo: " & Archivo
                LabelControl3.Text = "Trabajando con Archivo: " & Archivo

                Dim parts() = Archivo.Split("\")
                Dim fileName As String = parts(parts.Length - 1)
                fileName = fileName.Replace(".xls", "")


            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Dim TotalQuantity As Double
    Dim AssignedQuantity As Double
    Dim NombreTotal As String = ""

    Private Sub WizardControl1_NextClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraWizard.WizardCommandButtonClickEventArgs) Handles WizardControl1.NextClick


        If WizardControl1.SelectedPage.Name = "WizardPage1" Then
            If ListBoxControl1.SelectedValue Is Nothing Then
                XtraMsg("Por Favor seleccione Nombre de la Hoja para Continuar")
                WizardPage1.AllowNext = False
                Exit Sub
            End If


            Hoja = ListBoxControl1.SelectedValue


            Dim dtExcel As New DataTable
            dtExcel = Excel(Archivo, Hoja, "select * from {0}")

            Dim dtCol As New DataTable
            dtCol.Columns.Add("Valor")

            For i As Integer = 0 To dtExcel.Columns.Count - 1
                dtCol.Rows.Add(dtExcel.Columns(i).ColumnName)
            Next

            ItemColumns.DataSource = dtCol
            ItemColumns.DisplayMember = "Valor"
            ItemColumns.ValueMember = "Valor"

            DT_ASIGNAR = Fields(Tipo)
            igridControl.DataSource = DT_ASIGNAR

            'ASIGNANDO VALORES POR DEFAULT
            For i As Integer = 0 To iGridView.RowCount - 1
                For j As Integer = 0 To dtExcel.Columns.Count - 1

                    If (Strings.UCase(dtExcel.Columns(j).ColumnName) Like Strings.UCase(iGridView.GetRowCellValue(i, "Fields")) & "*") Then
                        iGridView.SetRowCellValue(i, "AsignColumn", dtExcel.Columns(j).ColumnName)
                        iGridView.SetRowCellValue(i, "Sample", dtExcel.Rows(0).Item(j).ToString)
                    End If
                Next
            Next


            'VERIFICANDO ASIGNACION
            WizardPage2.AllowNext = True

            For i As Integer = 0 To iGridView.RowCount - 1
                If iGridView.GetRowCellValue(i, "AsignColumn") Is String.Empty Then
                    WizardPage2.AllowNext = False
                End If
            Next

        End If


        If WizardControl1.SelectedPage.Name = "WizardPage2" Then
            ShowSplash()

            TotalQuantity = 0

            Dim dtExcel As New DataTable
            dtExcel = Excel(Archivo, Hoja, "select * from {0}")


            Dim dtCol As New DataTable
            dtCol.Columns.Add("Valor")

            ''ASIGNANDO VALORES POR DEFAULT
            'For i As Integer = 0 To iGridView.RowCount - 1
            '    If Strings.UCase(iGridView.GetRowCellValue(i, "Fields")) = "QUANTITY" Then
            '        NombreTotal = iGridView.GetRowCellValue(i, "AsignColumn")
            '    End If
            'Next



            ''CALCULANDO EL VALOR DE TOTAL DE CANTIDADES
            'For i As Integer = 0 To dtExcel.Rows.Count - 1
            '    TotalQuantity = IsNull(dtExcel.Rows(i).Item(NombreTotal), 0) + TotalQuantity
            'Next





            'AGREGANDO VALORES POSIBLES DE TALLAS BASADO EN TIPO DE DATOS '
            For i As Integer = 0 To dtExcel.Columns.Count - 1
                If IsNumeric(dtExcel.Rows(0).Item(dtExcel.Columns(i).ColumnName)) Or CStr(dtExcel.Rows(0).Item(dtExcel.Columns(i).ColumnName).ToString) = "" Then
                    dtCol.Rows.Add(dtExcel.Columns(i).ColumnName)
                End If
            Next



            HideSplash()

        End If


    End Sub



    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub


    Private Sub iGrid_Clic(sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iGridView.CellValueChanged


        If e.Column.FieldName = "AsignColumn" Then
            WizardPage2.AllowNext = True
            For i As Integer = 0 To iGridView.RowCount - 1
                If iGridView.GetRowCellValue(i, "AsignColumn") Is String.Empty And iGridView.GetRowCellValue(i, "Required") = True Then
                    WizardPage2.AllowNext = False
                End If
            Next

        End If

    End Sub

    Private Sub wizardControl1_CancelClick(ByVal sender As Object, ByVal e As CancelEventArgs) Handles WizardControl1.CancelClick
        Ok = "NO"
        Me.Close()
    End Sub

    Private Sub ListBoxControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxControl1.SelectedIndexChanged

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        Dim dtExcel As New DataTable
        dtExcel = Excel(Archivo, Hoja, "select * from {0}")

        FrmDetalleCrossTabDinamicos.Dispose()

        With FrmDetalleCrossTabDinamicos
            .Text = "Archivo a Importar"
            .StartPosition = FormStartPosition.CenterParent
            .GridControl1.DataSource = dtExcel
            .GridView1.PopulateColumns()
            FormatoGrid(.GridView1)
            .ShowDialog()
            .Dispose()
        End With


        'Dim form As New XtraForm()
        'form.Text = "Detalles"
        'form.StartPosition = FormStartPosition.CenterParent
        'Dim grid As New DataGridView()
        'grid.Parent = form
        'grid.Dock = DockStyle.Fill
        'grid.DataSource = dtExcel
        'form.Width = 1200
        'form.Height = 800
        'form.ShowDialog()
        'form.Dispose()
    End Sub

    Private Sub wizardControl1_FinishClick(ByVal sender As Object, ByVal e As CancelEventArgs) Handles WizardControl1.FinishClick

        Dim dtExcel As New DataTable
        dtExcel = Excel(Archivo, Hoja, "select * from {0}")

        Dim dtCol As New DataTable
        dtCol.Columns.Add("Valor")

        For i As Integer = 0 To dtExcel.Columns.Count - 1
            dtCol.Rows.Add(dtExcel.Columns(i).ColumnName)
        Next

        Dim ExisteStyle As Boolean = True
        Dim ExisteSArticle As Boolean = True

        'Creamos un dataset limpio solo volcarlo a la tabla

        ShowSplash("Importando...")


        If Tipo = "FISICO" Then     'Importando Inventario Fisico

            For a As Integer = 0 To dtExcel.Rows.Count - 1
                Dim dr As DataRow = DT.NewRow

                For i As Integer = 0 To iGridView.RowCount - 1

                    If iGridView.GetRowCellValue(i, "Fields") = "CODIGO" Then
                        If IsNull(iGridView.GetRowCellValue(i, "AsignColumn"), "") <> "" Then
                            dr.Item("CODIGO") = RTrim(LTrim(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")).ToString()))
                        End If
                    End If

                    If iGridView.GetRowCellValue(i, "Fields") = "DESCRIPCION" Then
                        If IsNull(iGridView.GetRowCellValue(i, "AsignColumn"), "") <> "" Then
                            dr.Item("DESCRIPCION") = IsNull(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")), "")
                        End If
                    End If

                    If iGridView.GetRowCellValue(i, "Fields") = "UNIDAD" Then
                        If IsNull(iGridView.GetRowCellValue(i, "AsignColumn"), "") <> "" Then
                            dr.Item("UNIDAD") = IsNull(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")), "")
                        Else
                            dr.Item("UNIDAD") = ""
                        End If
                    End If

                    If iGridView.GetRowCellValue(i, "Fields") = "MODELO" Then
                        'If Not IsDBNull(iGridView.GetRowCellValue(i, "AsignColumn")) Then
                        If IsNull(iGridView.GetRowCellValue(i, "AsignColumn"), "") <> "" Then
                            dr.Item("MODELO") = IsNull(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")), "")
                        Else
                            dr.Item("MODELO") = ""
                        End If
                    End If

                    If iGridView.GetRowCellValue(i, "Fields") = "UBICACION" Then
                        If IsNull(iGridView.GetRowCellValue(i, "AsignColumn"), "") <> "" Then
                            dr.Item("UBICACION") = IsNull(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")), "")
                        Else
                            dr.Item("UBICACION") = ""
                        End If
                    End If

                    If iGridView.GetRowCellValue(i, "Fields") = "FISICO" Then
                        If Not IsDBNull(iGridView.GetRowCellValue(i, "AsignColumn")) Then
                            dr.Item("FISICO") = IsNull(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")), 0.0)
                        Else
                            dr.Item("FISICO") = 0.0
                        End If
                    End If

                    If iGridView.GetRowCellValue(i, "Fields") = "COSTO" Then
                        If Not IsDBNull(iGridView.GetRowCellValue(i, "AsignColumn")) Then
                            dr.Item("COSTO") = IsNull(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")), 0.0)
                        Else
                            dr.Item("COSTO") = 0.0
                        End If
                    End If
                Next

                DT.Rows.Add(dr)
            Next

        ElseIf Tipo = "TASA_CAMBIO" Then    'Importando Tasa de Cambio
            For a As Integer = 0 To dtExcel.Rows.Count - 1
                Dim dr As DataRow = DT.NewRow

                For i As Integer = 0 To iGridView.RowCount - 1
                    If iGridView.GetRowCellValue(i, "Fields") = "Fecha" Then
                        If IsNull(iGridView.GetRowCellValue(i, "AsignColumn"), "") <> "" Then
                            dr.Item("Fecha") = RTrim(LTrim(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")).ToString()))
                        End If
                    End If
                    '
                    If iGridView.GetRowCellValue(i, "Fields") = "Tasa" Then
                        If Not IsDBNull(iGridView.GetRowCellValue(i, "AsignColumn")) And
                            iGridView.GetRowCellValue(i, "AsignColumn") <> "" Then
                            dr.Item("Tasa") = IsNull(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")), 0.0)
                        Else
                            dr.Item("Tasa") = 1.0
                        End If
                    End If
                    '
                    If iGridView.GetRowCellValue(i, "Fields") = "Paralelo" Then
                        If Not IsDBNull(iGridView.GetRowCellValue(i, "AsignColumn")) And
                            iGridView.GetRowCellValue(i, "AsignColumn") <> "" Then
                            dr.Item("Paralelo") = IsNull(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")), 0.0)
                        Else
                            dr.Item("Paralelo") = 1.0
                        End If
                    End If

                Next

                DT.Rows.Add(dr)
            Next

        ElseIf Tipo = "COMPROBANTE" Then    'Importando Comprobante
            For a As Integer = 0 To dtExcel.Rows.Count - 1
                Dim dr As DataRow = DT.NewRow

                For i As Integer = 0 To iGridView.RowCount - 1

                    If iGridView.GetRowCellValue(i, "Fields") = "Cuenta" Then
                        If IsNull(iGridView.GetRowCellValue(i, "AsignColumn"), "") <> "" Then
                            dr.Item("Cuenta") = RTrim(LTrim(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")).ToString()))
                        End If
                    End If

                    If iGridView.GetRowCellValue(i, "Fields") = "Debito" Then
                        If Not IsDBNull(iGridView.GetRowCellValue(i, "AsignColumn")) Then
                            dr.Item("Debito") = IsNull(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")), 0.0)
                        Else
                            dr.Item("Debito") = 0.0
                        End If
                    End If

                    If iGridView.GetRowCellValue(i, "Fields") = "Credito" Then
                        If Not IsDBNull(iGridView.GetRowCellValue(i, "AsignColumn")) Then
                            dr.Item("Credito") = IsNull(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")), 0.0)
                        Else
                            dr.Item("Credito") = 0.0
                        End If
                    End If

                    If iGridView.GetRowCellValue(i, "Fields") = "Concepto" Then
                        If IsNull(iGridView.GetRowCellValue(i, "AsignColumn"), "") <> "" Then
                            dr.Item("Concepto") = IsNull(dtExcel.Rows(a).Item(iGridView.GetRowCellValue(i, "AsignColumn")), "")
                        Else
                            dr.Item("Concepto") = ""
                        End If
                    End If

                Next

                DT.Rows.Add(dr)
            Next

        End If

        Ok = "SI"
        HideSplash()

    End Sub


    Private Sub iGridBudget_Click2(sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles iGridView.CellValueChanged
        If e.Column.FieldName = "AsignColumn" Then
            Dim dtExcel As New DataTable
            dtExcel = Excel(Archivo, Hoja, "select * from {0}")
            Try
                iGridView.SetRowCellValue(e.RowHandle, "Sample", dtExcel.Rows(0).Item(e.Value).ToString)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub WelcomeWizardPage1_Click(sender As Object, e As EventArgs) Handles WelcomeWizardPage1.Click

    End Sub
End Class