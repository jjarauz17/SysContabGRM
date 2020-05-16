Option Strict Off
Option Explicit On 

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace DataGridTextBoxCombo
    Public Class DataGridComboBoxColumn


        Inherits DataGridTextBoxColumn
        Public WithEvents ColumnComboBox As ComboBox
        Private WithEvents _source As CurrencyManager
        Private _rowNum As Integer
        Private _isEditing As Boolean
        Private _valueChanging As ComboValueChanged
        Public Shared _RowCount As Integer
        'Fields
        'Constructors
        'Events
        'Methods

        Dim Articulos As New VB.SysContab.ArticulosDB()

        Shared Sub New()

        End Sub

        Private Sub ManejaScroll(ByVal sender As Object, ByVal e As EventArgs)
            Exit Sub
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

                'If rowNum = NumFilas - 1 And rowNum > 0 Then
                '    Exit Sub
                '    'source.RemoveAt((source.Count - 1))
                'End If
                'on very first pass, set this static member to number of items in tables
                'check to see if we are on the new row
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
                If LeaveCommit = True Then
                    If _isEditing Then
                        _isEditing = False
                        SetColumnValueAtRow(dataSource, rowNum, ColumnComboBox.Text)
                    End If

                End If

                Return True
            Catch ex As Exception
                MsgBox(ex.Message & " Commit")
            End Try

        End Function

        Private Sub ComboIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Try
                _valueChanging(_rowNum, ColumnComboBox.Text)
                'If ColumnComboBox.SelectedIndex = 0 Then
                '    'Agregar Nuevo
                '    'MsgBox("Agregar Nuevo...")
                '    Dim f As New frmAgregarArticuloQuick()
                '    f.WindowState = FormWindowState.Normal
                '    f.StartPosition = FormStartPosition.CenterScreen
                '    f.ShowDialog()
                'End If
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
                If LeaveCommit = True Then

                    If _isEditing Then
                        SetColumnValueAtRow(_source, _rowNum, ColumnComboBox.Text)
                        _isEditing = False
                        Invalidate()
                    End If
                    'ElseIf BuscarCombo = True Then
                    '    If Trim(ColumnComboBox.Text) = "" Then
                    '        '
                    '    Else
                    '        'If ColumnComboBox.SelectedIndex = 0 Then
                    '        '    'Agregar Nuevo
                    '        '    'MsgBox("Agregar Nuevo...")
                    '        '    'Dim f As New frmAgregarArticuloQuick()
                    '        '    'f.WindowState = FormWindowState.Normal
                    '        '    'f.StartPosition = FormStartPosition.CenterScreen
                    '        '    'f.ShowDialog()
                    '        'Else
                    '        If Articulos.ArticulosBuscar(ColumnComboBox.Text, TipoItem).Tables("Articulos").Rows.Count = 0 Then
                    '            If Indice = 0 Or Me.ColumnComboBox.Text = "Nuevo..." Then
                    '                'Exit Sub
                    '            Else
                    '                If TipoItem = "P" Then
                    '                    MsgBox("No existe el Producto", MsgBoxStyle.Information)
                    '                ElseIf TipoItem = "S" Then
                    '                    MsgBox("No existe el Servicio", MsgBoxStyle.Information)
                    '                Else
                    '                    MsgBox("No existe el Producto o Servicio", MsgBoxStyle.Information)
                    '                End If
                    '            End If
                    '            ColumnComboBox.Focus()
                    '            Exit Sub
                    '        End If
                    '        'End If

                    '    End If

                End If
                ColumnComboBox.Hide()
            Catch ex As Exception
                MsgBox(ex.Message & " LeaveComboBox")
            End Try

        End Sub

        Private Sub ColumnComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColumnComboBox.SelectedValueChanged
            Try
                Indice = ColumnComboBox.SelectedIndex
            Catch ex As Exception
                MsgBox(ex.Message & " SelectedValueChanged")
            End Try
        End Sub

        Private Sub ColumnComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColumnComboBox.SelectedIndexChanged
            Try
                Indice = ColumnComboBox.SelectedIndex
                'IndiceBanco = ColumnComboBox.SelectedIndex
            Catch ex As Exception
                MsgBox(ex.Message & " SelectedIndexChanged")
            End Try
        End Sub

        Private Sub ColumnComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ColumnComboBox.KeyPress
            '02/11/2005
            '''''''If LeaveCommit = False Then
            '''''''    If Microsoft.VisualBasic.Asc(e.KeyChar) = 27 Then
            '''''''        ColumnComboBox.Text = Me.TextBox.Text
            '''''''        Exit Sub

            '''''''    End If

            '''''''    ''''If e.KeyChar.IsControl(e.KeyChar) = True Then
            '''''''    ''''    ColumnComboBox.Text = Me.TextBox.Text
            '''''''    ''''    Exit Sub
            '''''''    ''''End If

            '''''''    Try
            '''''''        If Articulos.ArticulosBuscar(ColumnComboBox.Text, TipoItem).Tables("Articulos").Rows.Count = 0 Then
            '''''''            MsgBox("No existe el Producto o Servicio....", MsgBoxStyle.Information)
            '''''''            e.Handled = True
            '''''''            ColumnComboBox.Focus()
            '''''''            Exit Sub
            '''''''        End If
            '''''''    Catch ex As Exception
            '''''''        MsgBox(ex.Message & " KeyPress")
            '''''''    End Try

            '''''''End If

        End Sub



        '''Private Sub ColumnComboBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColumnComboBox.Leave
        '''    If Articulos.ArticulosBuscar(ColumnComboBox.Text).Tables("Articulos").Rows.Count = 0 Then
        '''        MsgBox("No existe el Producto o Servicio", MsgBoxStyle.Information)
        '''        ColumnComboBox.Focus()
        '''        Exit Sub
        '''    End If
        '''End Sub

        ''''Private Sub ColumnComboBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColumnComboBox.Enter
        ''''    If LeaveCommit = True Then
        ''''        'If ColumnComboBox.SelectedIndex <> 0 Then
        ''''        '    Exit Sub
        ''''        'Else
        ''''        MsgBox(ColumnComboBox.Text)
        ''''        ColumnComboBox.SelectedIndex = 0
        ''''        'End If
        ''''    End If

        ''''End Sub

    End Class


End Namespace
