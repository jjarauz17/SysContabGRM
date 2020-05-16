Imports System.IO

Namespace VB.SysContab
    Public Class DocumentosDB
        Public Function Leer_Archivo(ByVal Archivo As String, ByRef DS As DataSet) As Integer
            Dim delimStr As String = ","
            Dim delimiter As Char() = delimStr.ToCharArray()
            Dim split As String() = Nothing

            Dim Linea As String
            Dim i, j As Integer



            If Not File.Exists(Archivo) Then
                MsgBox("No existe el archivo: " & Archivo, MsgBoxStyle.Information)
                Exit Function
            End If
            Dim ConnectionFile As New System.IO.StreamReader(Archivo)

            DS.Tables.Add("Archivo")
            i = 1
            Do While True
                Try
                    Linea = ConnectionFile.ReadLine.ToString()
                Catch ex As Exception
                    If i = 0 Then
                        GoTo fallo
                    End If
                    Exit Do
                End Try

                If Linea.Length = 0 And i = 1 Then
                    GoTo fallo
                    Exit Do
                End If
                If Linea.Length = 0 Then ' Si no tiene nada en la linea
                    Exit Do
                End If
                split = Linea.Split(delimiter)
                If i <= 1 Then 'Primera Linea contiene la descripcion de los campos del encabezado
                    If DS.Tables("Archivo").Columns.Count = 0 Then
                        For j = 0 To split.GetUpperBound(0)
                            DS.Tables("Archivo").Columns.Add(split(j).Trim)
                        Next
                    Else
                        GoTo fallo
                        DS.Tables.Clear()
                        Exit Do
                    End If
                Else
                    If DS.Tables("Archivo").Columns.Count = 0 Then
                        GoTo fallo
                        DS.Tables.Clear()
                        Exit Do
                    Else
                        If split(0) <> "" Then
                            DS.Tables("Archivo").Rows.Add(split)
                        End If
                    End If

                End If
                i = i + 1
            Loop

            Return 1
fallo:      Return -1

        End Function

        Public Shared Function Leer_Archivo(ByVal DS As DataSet, ByVal Archivo As String) As Integer

            Dim delimStr As String = ","
            Dim delimiter As Char() = delimStr.ToCharArray()
            Dim split As String() = Nothing

            Dim Linea As String
            Dim i, j As Integer

            If Not File.Exists(Archivo) Then
                MsgBox("No existe el archivo: " & Archivo, MsgBoxStyle.Information)
                Exit Function
            End If

            Dim ConnectionFile As New StreamReader(Archivo)
            DS.Tables.Add("Archivo")

            i = 1

            Do While True
                Try
                    Linea = ConnectionFile.ReadLine.ToString()
                Catch ex As Exception
                    If i = 0 Then
                        GoTo fallo
                    End If
                    Exit Do
                End Try

                If Linea.Length = 0 And i = 1 Then
                    GoTo fallo
                    Exit Do
                End If

                If Linea.Length = 0 Then ' Si no tiene nada en la linea
                    Exit Do
                End If

                split = Linea.Split(delimiter)

                If i <= 1 Then 'Primera Linea contiene la descripcion de los campos del encabezado
                    If DS.Tables("Archivo").Columns.Count = 0 Then
                        For j = 0 To split.GetUpperBound(0)
                            DS.Tables("Archivo").Columns.Add(split(j).Trim)
                        Next
                    Else
                        GoTo fallo
                        DS.Tables.Clear()
                        Exit Do
                    End If
                Else
                    If DS.Tables("Archivo").Columns.Count = 0 Then
                        GoTo fallo
                        DS.Tables.Clear()
                        Exit Do
                    Else
                        DS.Tables("Archivo").Rows.Add(split)
                        'If split(0) <> "" Then
                        '    DS.Tables("Archivo").Rows.Add(split)
                        '    MsgBox("No hay Fecha ")
                        'End If
                    End If

                End If
                i = i + 1
            Loop

            Return 1
fallo:      Return -1

        End Function

        '        Public Function Leer_Archivo(ByVal Archivo As String, ByRef DS As DataSet) As Integer
        '            Dim delimStr As String = ","
        '            Dim delimiter As Char() = delimStr.ToCharArray()
        '            Dim split As String() = Nothing

        '            Dim Linea As String
        '            Dim i, j As Integer



        '            If Not File.Exists(Archivo) Then
        '                MsgBox("No existe el archivo: " & Archivo, MsgBoxStyle.Information)
        '                Exit Function
        '            End If
        '            Dim ConnectionFile As New System.IO.StreamReader(Archivo)

        '            DS.Tables.Add("Archivo")
        '            i = 1
        '            Do While True
        '                Try
        '                    Linea = ConnectionFile.ReadLine.ToString()
        '                Catch ex As Exception
        '                    If i = 0 Then
        '                        GoTo fallo
        '                    End If
        '                    Exit Do
        '                End Try

        '                If Linea.Length = 0 And i = 1 Then
        '                    GoTo fallo
        '                    Exit Do
        '                End If
        '                If Linea.Length = 0 Then ' Si no tiene nada en la linea
        '                    Exit Do
        '                End If
        '                split = Linea.Split(delimiter)
        '                If i <= 1 Then 'Primera Linea contiene la descripcion de los campos del encabezado
        '                    If DS.Tables("Archivo").Columns.Count = 0 Then
        '                        For j = 0 To split.GetUpperBound(0)
        '                            DS.Tables("Archivo").Columns.Add(split(j).Trim)
        '                        Next
        '                    Else
        '                        GoTo fallo
        '                        DS.Tables.Clear()
        '                        Exit Do
        '                    End If
        '                Else
        '                    If DS.Tables("Archivo").Columns.Count = 0 Then
        '                        GoTo fallo
        '                        DS.Tables.Clear()
        '                        Exit Do
        '                    Else
        '                        If split(0) <> "" Then
        '                            DS.Tables("Archivo").Rows.Add(split)
        '                        End If
        '                    End If

        '                End If
        '                i = i + 1
        '            Loop

        '            Return 1
        'fallo:      Return -1

        '        End Function
        Public Function Leer_EC_BAC(ByVal Archivo As String, ByRef DS As DataSet) As Integer

            Dim delimStr As String = ","
            Dim delimiter As Char() = delimStr.ToCharArray()
            Dim split As String() = Nothing

            Dim Linea As String
            Dim i, j As Integer

            'Dim Encabezado(1)() As String
            'Dim Detalle(99)() As String

            If Not File.Exists(Archivo) Then
                MsgBox("No existe el archivo: " & Archivo, MsgBoxStyle.Information)
                Exit Function
            End If
            Dim ConnectionFile As New System.IO.StreamReader(Archivo)

            DS.Tables.Add("Encabezado")
            DS.Tables.Add("Detalle")
            i = 1
            Do While True
                Linea = ConnectionFile.ReadLine.ToString()
                split = Linea.Split(delimiter)
                If i <= 2 Then 'Primera Linea contiene la descripcion de los campos del encabezado
                    If DS.Tables("Encabezado").Columns.Count = 0 Then
                        For j = 0 To 16
                            DS.Tables("Encabezado").Columns.Add(split(j).Trim)
                        Next
                    Else
                        'Encabezado(i - 1) = split
                        DS.Tables("Encabezado").Rows.Add(split)
                    End If
                Else
                    If Linea.Length <> 0 And i = 3 Then 'Error, el archivo debe tener esta linea en blanco
                        Return (-1)
                        Exit Function
                    End If
                    If i >= 5 Then 'Encabezados del Detalle
                        If Linea.Length = 0 Then
                            Exit Do
                        Else
                            If DS.Tables("Detalle").Columns.Count = 0 Then
                                For j = 0 To 6
                                    DS.Tables("Detalle").Columns.Add(split(j).Trim)
                                Next
                            Else
                                'Detalle(i - 5) = split
                                DS.Tables("Detalle").Rows.Add(split)
                            End If
                        End If
                    End If
                End If
                i = i + 1
            Loop



        End Function
    End Class
End Namespace