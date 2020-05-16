Option Strict Off
Option Explicit On 

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace DataGridTextBox
    Public Class DataGridComboBox

        Inherits DataGridTextBoxColumn
        Public WithEvents ColumnComboBox As ComboBox
        Private WithEvents _source As CurrencyManager
        Private _rowNum As Integer
        Private _isEditing As Boolean
        Private _valueChanging As ComboValueChanged
        Public Shared _RowCount As Integer


        Dim Articulos As New VB.SysContab.ArticulosDB()
        Dim CatBancos As New VB.SysContab.Catalogo_BancosDB()


        Shared Sub New()

        End Sub

        Private Sub ManejaScroll(ByVal sender As Object, ByVal e As EventArgs)
            Try
                If ColumnComboBox.Visible Then
                    ColumnComboBox.Visible = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message & " ManejaScroll")
            End Try

        End Sub

        Public Sub New(ByVal valueChanging As ComboValueChanged)

            MyBase.New()
            Try
                _isEditing = False
                _RowCount = -1
                _valueChanging = valueChanging
                ColumnComboBox = New ComboBox()
                AddHandler ColumnComboBox.Leave, New EventHandler(AddressOf LeaveComboBox)
                AddHandler ColumnComboBox.Enter, New EventHandler(AddressOf ComboMadeCurrent)
                AddHandler ColumnComboBox.SelectedIndexChanged, New System.EventHandler(AddressOf ComboIndexChanged)
            Catch ex As Exception
                MsgBox(ex.Message & " New")
            End Try

        End Sub

        Protected Overloads Overrides Sub Edit(ByVal source As CurrencyManager, ByVal rowNum As Integer, ByVal bounds As Rectangle, ByVal readOnly1 As Boolean, ByVal instantText As String, ByVal cellIsVisible As Boolean)

            Try

                If (_RowCount = -(1)) Then
                    _RowCount = source.Count
                End If
                If (_RowCount < source.Count) Then
                    ' remove the one that has been added
                    ' and add a new to sync 
                    source.RemoveAt((source.Count - 1))
                    source.AddNew()
                    'source.RemoveAt()
                End If
                _RowCount = source.Count
                MyBase.Edit(source, rowNum, bounds, readOnly1, instantText, cellIsVisible)
                _rowNum = rowNum
                _source = source
                ColumnComboBox.Parent = Me.TextBox.Parent
                ColumnComboBox.Location = Me.TextBox.Location
                ColumnComboBox.Size = New Size(Me.TextBox.Size.Width, ColumnComboBox.Size.Height)
                RemoveHandler ColumnComboBox.SelectedIndexChanged, New System.EventHandler(AddressOf ComboIndexChanged)
                ColumnComboBox.Text = Me.TextBox.Text
                AddHandler ColumnComboBox.SelectedIndexChanged, New System.EventHandler(AddressOf ComboIndexChanged)
                Me.TextBox.Visible = False
                ColumnComboBox.Visible = True
                ColumnComboBox.BringToFront()
                ColumnComboBox.Focus()

            Catch ex As Exception
                MsgBox(ex.Message & " Edit")
            End Try

        End Sub

        Protected Overloads Overrides Function Commit(ByVal dataSource As CurrencyManager, ByVal rowNum As Integer) As Boolean
            Try
                'If LeaveCommit = True Then
                'If _isEditing Then
                '    _isEditing = False
                '    SetColumnValueAtRow(dataSource, rowNum, ColumnComboBox.Text)
                'End If

                'End If

                Return True
            Catch ex As Exception
                MsgBox(ex.Message & " Commit")
            End Try

        End Function

        Private Sub ComboIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Try
                _valueChanging(_rowNum, ColumnComboBox.Text)
            Catch ex As Exception
                MsgBox(ex.Message & " ComboIndexChaged")
            End Try

        End Sub

        Private Sub ComboMadeCurrent(ByVal sender As Object, ByVal e As EventArgs)
            Try
                _isEditing = True
            Catch ex As Exception
                MsgBox(ex.Message & " ComboMadeCurrent")
            End Try
        End Sub

        Private Sub LeaveComboBox(ByVal sender As Object, ByVal e As EventArgs)
            Try
                'If LeaveCommit = True Then
                'If _isEditing Then
                '    SetColumnValueAtRow(_source, _rowNum, ColumnComboBox.Text)
                '    _isEditing = False
                '    Invalidate()
                'End If

                'Else
                'If Not IsNumeric(ColumnComboBox.Text) = False Then
                '    If CatBancos.GetList(ColumnComboBox.Text).Tables("CUENTA").Rows.Count = 0 Then
                '        MsgBox("No hay Catologos de Bancos", MsgBoxStyle.Information)
                '        ColumnComboBox.Focus()
                '        Exit Sub
                '    End If
                'End If

                'End If

                ColumnComboBox.Hide()

            Catch ex As Exception

                MsgBox(ex.Message & " LeaveComboBox")
            End Try

        End Sub

        'Private Sub ColumnComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColumnComboBox.SelectedValueChanged
        '    Try
        '        Indice = ColumnComboBox.SelectedIndex
        '    Catch ex As Exception
        '        MsgBox(ex.Message & " SelectedValueChanged")
        '    End Try
        'End Sub

        Private Sub ColumnComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColumnComboBox.SelectedIndexChanged
            Try
                Indice = ColumnComboBox.SelectedIndex
            Catch ex As Exception
                MsgBox(ex.Message & " SelectedIndexChanged")
            End Try

        End Sub

    End Class


End Namespace
