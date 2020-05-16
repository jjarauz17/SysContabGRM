Option Strict Off
Option Explicit On 

Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Imports System.IO

Namespace VB.SysContab

    Public Class RutinasNomina

        Public Shared Function OcultarMenu(ByVal control As Form)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is GroupBox Then
                    control.Controls.Item(i).Visible = False
                End If
            Next
        End Function

        'Funcion para limpiar los elementos de un formulario
        Public Function LimpiarControles(ByVal control As GroupBox)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is TextBox Then
                    control.Controls.Item(i).Text = ""
                End If
            Next
        End Function

        Public Function EstablecerCero(ByVal control As GroupBox)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is TextBox Then
                    control.Controls.Item(i).Text = "0.00"
                End If
            Next
        End Function

        Public Function DeshabilitarControles(ByVal control As GroupBox)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is TextBox Or TypeOf (control.Controls.Item(i)) Is ComboBox _
                Or TypeOf (control.Controls.Item(i)) Is DateTimePicker Then
                    control.Controls.Item(i).Enabled = False
                End If
            Next
        End Function

        Public Function HabilitarControles(ByVal control As GroupBox)
            Dim i As Integer
            For i = 0 To control.Controls.Count - 1
                If TypeOf (control.Controls.Item(i)) Is TextBox Or TypeOf (control.Controls.Item(i)) Is ComboBox _
                Or TypeOf (control.Controls.Item(i)) Is DateTimePicker Then
                    control.Controls.Item(i).Enabled = True
                End If
            Next
        End Function

        Public Function FormatGenerico(ByVal Grilla As DataGrid, ByVal fuente As DataTable) As Boolean
            Dim i As Integer = 0
            Grilla.TableStyles.Clear()
            Dim EstiloGrilla As New DataGridTableStyle()

            EstiloGrilla.MappingName = fuente.TableName()
            'Estilo de la Grilla, para la tabla maestra de terceros de facturación
            Dim column As New DataGridTextBoxColumn()
            Dim column2 As New NumericUpDown()

            Dim fila1 As DataRow = fuente.NewRow()
            'Dim fila As DataGridTableStyle
            'Dim column1 As DataGrid
            'fuente.Rows.Add(fila1)

            While i < fuente.Columns.Count
                If fuente.Columns(i).Caption <> "." Then
                    ' defaults
                    column = New DataGridTextBoxColumn()
                    column.MappingName = fuente.Columns(i).ColumnName
                    column.HeaderText = fuente.Columns(i).Caption
                    column.Width = fuente.Columns(i).Caption.Length * 20
                    column.NullText = ""
                    column.ReadOnly = True

                    If column.MappingName.ToUpper = "NOMBRE" Or
                        Right(column.MappingName.ToUpper, 6) = "NOMBRE" Then
                        column.Width = 350
                        column.HeaderText = "Nombre"
                    End If

                    If column.MappingName.ToUpper = "DESCRIPCION" Or
                        Right(column.MappingName.ToUpper, 11) = "DESCRIPCION" Then
                        column.HeaderText = "Descripcion"
                        column.Width = 350
                    End If
                    If column.MappingName.ToUpper = "DIRECCION" Or
                        Right(column.MappingName.ToUpper, 9) = "DIRECCION" Then
                        column.Width = 350
                        column.HeaderText = "Direccion"
                    End If

                    If column.MappingName.ToUpper = "MES" Then
                        column.HeaderText = "Código"
                        column.Width = 160
                    End If


                    If column.MappingName.ToUpper = "CODIGO" Or
                        Right(column.MappingName.ToUpper, 6) = "CODIGO" Then
                        column.Width = 100
                        column.HeaderText = "Codigo"

                    End If

                    If column.MappingName.ToUpper = "EMPLEADO" Then
                        If Grilla.Name.ToUpper = "DGHEXTRAS" Then
                            column.Width = 80
                        Else
                            column.Width = 160
                        End If
                    End If

                    If column.MappingName.ToUpper = "QUINCENA" Then
                        If Grilla.Name.ToUpper = "DGHEXTRAS" Then
                            column.Width = 100
                        End If
                    End If

                    If column.MappingName.ToUpper = "AUTORIZADAS" Then
                        If Grilla.Name.ToUpper = "DGHEXTRAS" Then
                            column.Width = 80
                            column.ReadOnly = False
                        End If
                    End If

                    If column.MappingName.ToUpper = "SOLICITADAS" Then
                        If Grilla.Name.ToUpper = "DGHEXTRAS" Then
                            column.Width = 80
                        End If
                    End If


                    If column.MappingName.ToUpper = "NUMERO_MES" Or
                        column.MappingName.ToUpper = "NOMBRE_EMPLEADO" Or
                        column.MappingName.ToUpper = "NUMERO" Then
                        column.Width = 0
                    End If





                    'If column.MappingName.ToUpper = "ENTRADA" Then
                    '   If Grilla.Name.ToUpper <> "DGHORARIOS" Or Grilla.Name.ToUpper <> "DGDETALLE" Then
                    '        column.HeaderText = "Unidades"
                    '   End If

                    'End If


                    If column.MappingName.ToUpper = "ENTRADA" Then
                        'column.HeaderText = "Entrada " & Chr(13) & fuente.Columns(i).Caption
                        Select Case Grilla.Name.ToUpper
                            Case Grilla.Name.ToUpper <> "DGHORARIOS"
                                column.NullText = "0"
                                column.Alignment = HorizontalAlignment.Right
                                column.Width = 100
                            Case Grilla.Name.ToUpper = "DGHORARIOS"
                                column.NullText = "0"
                                column.Alignment = HorizontalAlignment.Left
                                column.Format = "hh:mm tt"
                                column.Width = 150
                            Case Grilla.Name.ToUpper = "DGDETALLE"
                                column.NullText = "0"
                                column.Alignment = HorizontalAlignment.Left
                                column.Width = 150
                        End Select
                    End If


                    If column.MappingName.ToUpper = "SALIDA" Then
                        Select Case Grilla.Name.ToUpper
                            Case Grilla.Name.ToUpper = "DGHORARIOS"
                                column.NullText = "0"
                                column.Alignment = HorizontalAlignment.Left
                                column.Format = "hh:mm tt"
                                column.Width = 150
                            Case Grilla.Name.ToUpper = "DGDETALLE"
                                column.NullText = "0"
                                column.Alignment = HorizontalAlignment.Left
                                column.Width = 150

                        End Select
                    End If

                    '                If column.MappingName.ToUpper = "SALDO_INICIAL" Then
                    '                    column.NullText = "0.00"
                    '                    column.Format = "##,###0.00"
                    '                    column.Alignment = HorizontalAlignment.Right
                    '                    column.Width = 100

                    '                    column.HeaderText = column.HeaderText & "."
                    '                End If

                    If column.MappingName.ToUpper = "DIA" Then
                        column.ReadOnly = True
                        'column.Alignment = HorizontalAlignment.Right
                        'column.Width = 150

                    End If


                    EstiloGrilla.GridColumnStyles.Add(column)

                End If
                i += 1
            End While

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Grilla.TableStyles.Clear()
            If Grilla.Name = "dgTasaCambio" Or Grilla.Name = "dgAcumulados" Or Grilla.Name = "dgCatalogoAcumulados" Or Grilla.Name = "dgVentas" Or Grilla.Name = "dgAcumuladosProductos" Or Grilla.Name = "dgVentasServicios" Then
                EstiloGrilla.AllowSorting = False
                If Grilla.Name = "dgAcumulados" Or Grilla.Name = "dgCatalogoAcumulados" Or Grilla.Name = "dgVentas" Or Grilla.Name = "dgAcumuladosProductos" Or Grilla.Name = "dgVentasServicios" Then

                    Dim fila As DataRow = fuente.NewRow()

                    '
                    Dim filaPresupuesto As DataRow = fuente.NewRow()
                    Dim filaDebe As DataRow = fuente.NewRow()
                    Dim filaHaber As DataRow = fuente.NewRow()
                    Dim filaSaldo As DataRow = fuente.NewRow()

                    Dim x As Integer
                    Dim total As Double

                    Dim TotalPresupuesto
                    Dim TotalDebe
                    Dim TotalHaber
                    Dim TotalSaldo

                    Dim TotalVentas
                    Dim TotalComisiones

                    Dim TotalEntradas
                    Dim TotalUnidades
                    Dim TotalUnidadesEntrada

                    Dim TotalServicios
                    Dim TotalServiciosValor

                    total = 0

                    TotalPresupuesto = 0
                    TotalDebe = 0
                    TotalHaber = 0
                    TotalSaldo = 0

                    TotalVentas = 0
                    TotalComisiones = 0

                    TotalUnidades = 0

                    TotalEntradas = 0
                    TotalUnidadesEntrada = 0

                    TotalServicios = 0
                    TotalServiciosValor = 0

                    If Grilla.Name = "dgCatalogoAcumulados" Then
                        For x = 0 To fuente.Rows.Count - 1
                            'If dsFicha.Tables("Tabla").Rows(0).Item("Cargo_anterior") Is DBNull.Value Then
                            If Grilla.Item(x, 1) Is DBNull.Value Then
                                '
                            Else
                                TotalPresupuesto = TotalPresupuesto + Grilla.Item(x, 1)
                            End If

                            If Grilla.Item(x, 2) Is DBNull.Value Then
                                '
                            Else
                                TotalDebe = TotalDebe + Grilla.Item(x, 2)
                            End If

                            If Grilla.Item(x, 3) Is DBNull.Value Then
                                '
                            Else
                                TotalHaber = TotalHaber + Grilla.Item(x, 3)
                            End If

                            If Grilla.Item(x, 4) Is DBNull.Value Then
                                '
                            Else
                                TotalSaldo = TotalSaldo + Grilla.Item(x, 4)
                            End If

                            If Grilla.Item(x, 1) Is DBNull.Value Then
                                '
                            Else
                                total = total + Grilla.Item(x, 1)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        fila("Presupuesto") = TotalPresupuesto
                        fila("Debe") = TotalDebe
                        fila("Haber") = TotalHaber
                        fila("Saldo") = TotalSaldo

                        'fila("Numero_Mes") = 13

                        fuente.Rows.Add(fila)

                    ElseIf Grilla.Name = "dgAcumulados" Then

                        For x = 0 To fuente.Rows.Count - 1
                            'If dsFicha.Tables("Tabla").Rows(0).Item("Cargo_anterior") Is DBNull.Value Then

                            If Grilla.Item(x, 1) Is DBNull.Value Then
                                '
                            Else
                                total = total + Grilla.Item(x, 1)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        fila("Monto") = total

                        'fila("Numero_Mes") = 13

                        fuente.Rows.Add(fila)

                    ElseIf Grilla.Name = "dgVentas" Then
                        For x = 0 To fuente.Rows.Count - 1
                            If Grilla.Item(x, 2) Is DBNull.Value Then
                                '
                            Else
                                TotalVentas = TotalVentas + Grilla.Item(x, 2)
                            End If

                            If Grilla.Item(x, 3) Is DBNull.Value Then
                                '
                            Else
                                TotalComisiones = TotalComisiones + Grilla.Item(x, 3)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        fila("Ventas") = TotalVentas
                        fila("Comision") = TotalComisiones

                        'fila.Item(0).Color = Grilla.BackColor.FromArgb(255, 0, 0)

                        fuente.Rows.Add(fila)

                    ElseIf Grilla.Name = "dgAcumuladosProductos" Then
                        For x = 0 To fuente.Rows.Count - 1

                            If Grilla.Item(x, 2) Is DBNull.Value Then
                                '
                            Else
                                TotalUnidadesEntrada = TotalUnidadesEntrada + Grilla.Item(x, 2)
                            End If

                            If Grilla.Item(x, 3) Is DBNull.Value Then
                                '
                            Else
                                TotalEntradas = TotalEntradas + Grilla.Item(x, 3)
                            End If

                            If Grilla.Item(x, 4) Is DBNull.Value Then
                                '
                            Else
                                TotalUnidades = TotalUnidades + Grilla.Item(x, 4)
                            End If

                            If Grilla.Item(x, 6) Is DBNull.Value Then
                                '
                            Else
                                TotalVentas = TotalVentas + Grilla.Item(x, 6)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        fila("Unidades") = TotalUnidades
                        fila("Valor") = TotalVentas
                        fila("Entrada") = TotalUnidadesEntrada
                        fila("Valor_Entrada") = TotalEntradas

                        fuente.Rows.Add(fila)

                        'fila.Item(0).Color = Grilla.BackColor.FromArgb(255, 0, 0)
                    ElseIf Grilla.Name = "dgVentasServicios" Then
                        For x = 0 To fuente.Rows.Count - 1
                            If Grilla.Item(x, 3) Is DBNull.Value Then
                                '
                            Else
                                TotalServicios = TotalServicios + Grilla.Item(x, 3)
                            End If

                            If Grilla.Item(x, 4) Is DBNull.Value Then
                                '
                            Else
                                TotalServiciosValor = TotalServiciosValor + Grilla.Item(x, 4)
                            End If

                        Next

                        fila("Mes") = "TOTAL"
                        fila("Unidades") = TotalServicios
                        fila("Valor") = TotalServiciosValor

                        'fila.Item(0).Color = Grilla.BackColor.FromArgb(255, 0, 0)

                        fuente.Rows.Add(fila)

                    End If
                End If

            End If

            Grilla.TableStyles.Add(EstiloGrilla)

            'Grilla.TableStyles.Item(0).BackColor = Grilla.BackColor.CadetBlue
            Grilla.TableStyles.Item(0).BackColor = Grilla.BackColor.FromArgb(225, 236, 236) 'Grilla.BackColor.FromArgb(200, 223, 212)
            Grilla.TableStyles.Item(0).GridLineColor = Grilla.BackColor.SteelBlue
            Grilla.TableStyles.Item(0).HeaderBackColor = Grilla.BackColor.LightSteelBlue

            'Grilla = Grilla.BackColor.FromArgb(255, 0, 0)


            'Grilla.TableStyles.Item(0).

            'Grilla.TableStyles.Item(0). = Grilla.BackColor.CadetBlue
            'Grilla.TableStyles.Item(0).RowHeadersVisible = False
            'Grilla.TableStyles.Item(0).RowHeaderWidth = 10

        End Function

        ' Al estar declarado como Shared, podemos usarlo sin crear
        ' una instancia de la clase
        Public Shared Sub CambiarEstilo(ByVal tControl As Control)
            ' Cambiar el estilo del control...
            ' sólo si es uno de los indicados
            'Select Case tControl.GetType.Name
            '    ''''''Case "Label"
            '    ''''''    CType(tControl, Label).FlatStyle = FlatStyle.System
            'Case "CheckBox"
            '        CType(tControl, CheckBox).FlatStyle = FlatStyle.System
            '    Case "RadioButton"
            '        CType(tControl, RadioButton).FlatStyle = FlatStyle.System
            '    Case "Button"
            '        ' Si el botón tiene asignada la propiedad Image     (11/Oct/02)
            '        ' no cambiarlo...
            '        Dim tButton As Button = CType(tControl, Button)
            '        If tButton.Image Is Nothing Then
            '            tButton.FlatStyle = FlatStyle.System
            '        End If
            '    Case "GroupBox"
            '        CType(tControl, GroupBox).FlatStyle = FlatStyle.System
            'End Select
            ''
            '' Cambiar también los controles contenidos en cada control...
            'If tControl.Controls.Count > 0 Then
            '    Dim tControl2 As Control
            '    '
            '    For Each tControl2 In tControl.Controls
            '        CambiarEstilo(tControl2)
            '    Next
            'End If
        End Sub

        Private Sub HandleBoolChanges(ByVal sender As Object, ByVal e As DataGridCheckBoxChangeEvent.BoolValueChangedEventArgs)

            Dim s As String
            s = System.String.Format("Bool Changes: row {0}, col {1}   value {2}", e.Row, e.Column, e.BoolValue)
            Console.WriteLine(s)

        End Sub

        'Private Sub etProveedores_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etProveedores.MouseEnter
        '    etProveedores.BackColor = etGenerales.BackColor.White
        '    etProveedores.ForeColor = etGenerales.BackColor.FromArgb(0, 51, 102)

        'End Sub

        Public Shared Sub EntrarMouse(ByVal Etiqueta As Label)
            Etiqueta.BackColor = Etiqueta.BackColor.White
            Etiqueta.ForeColor = Etiqueta.BackColor.FromArgb(0, 51, 102)

        End Sub

        Public Shared Sub SalirMouse(ByVal Etiqueta As Label)
            Etiqueta.BackColor = Etiqueta.BackColor.FromArgb(0, 51, 102)
            Etiqueta.ForeColor = Etiqueta.BackColor.White
        End Sub

        Public Function HeaderFooter()
        End Function

        Public Shared Function ConversionDecimales(ByVal nnumero As Double) As String


            Dim UNIDAD() As String = {"", "", "UNO ", "DOS ", "TRES ", "CUATRO ", "CINCO ", "SEIS ", "SIETE ", "OCHO ", "NUEVE "}
            Dim DECENA() As String = {"", "", "DIEZ ", "VEINTE ", "TREINTA ", "CUARENTA ", "CINCUENTA ", "SESENTA ", "SETENTA ", "OCHENTA ", "NOVENTA "}
            Dim CENTENA() As String = {"", "", "CIENTO ", "DOSCIENTOS ", "TRESCIENTOS ", "CUATROCIENTOS ", "QUINIENTOS ", _
                                        "SEISCIENTOS ", "SETECIENTOS ", "OCHOCIENTOS ", "NOVECIENTOS "}
            Dim EXCEPCION() As String = {"", "ONCE ", "DOCE ", "TRECE ", "CATORCE ", "QUINCE "}
            Dim num2, letra, auxlinea, ls_decimal As String
            'string UNIDAD[10],DECENA[10],CENTENA[10],EXCEPCION[5]
            Dim n100000000, n10000000, n1000000, n100000, n10000, n1000, n100, n10, n As Integer

            If nnumero = 0 Then
                letra = "CERO "
                Return letra
            End If



            num2 = CStr(Math.Round(nnumero, 2))

            n100000000 = Int(nnumero / 100000000)
            nnumero = nnumero - n100000000 * 100000000
            n10000000 = Int(nnumero / 10000000)
            nnumero = nnumero - n10000000 * 10000000
            n1000000 = Int(nnumero / 1000000)
            nnumero = nnumero - n1000000 * 1000000
            n100000 = Int(nnumero / 100000)
            nnumero = nnumero - n100000 * 100000
            n10000 = Int(nnumero / 10000)
            nnumero = nnumero - n10000 * 10000
            n1000 = Int(nnumero / 1000)
            nnumero = nnumero - n1000 * 1000
            n100 = Int(nnumero / 100)
            nnumero = nnumero - n100 * 100
            n10 = Int(nnumero / 10)
            nnumero = nnumero - n10 * 10
            n = Int(nnumero)

            'real en pb???

            n100000000 = CDbl(CStr(Math.Round(n100000000, 2)))
            n10000000 = CDbl(CStr(Math.Round(n10000000, 2)))
            n1000000 = CDbl(CStr(Math.Round(n1000000, 2)))
            n100000 = CDbl(CStr(Math.Round(n100000, 2)))
            n10000 = CDbl(CStr(Math.Round(n10000, 2)))
            n1000 = CDbl(CStr(Math.Round(n1000, 2)))
            n100 = CDbl(CStr(Math.Round(n100, 2)))
            n10 = CDbl(CStr(Math.Round(n10, 2)))
            n = CDbl(CStr(Math.Round(n, 2)))

            num2 = CStr(Math.Round(CDbl(CStr(Math.Round(nnumero, 2))), 2))


            nnumero = CDbl(Right(num2, 2))
            '  MILLONES
            If n100000000 = 1 And n10000000 = 0 And n1000000 = 0 Then
                letra = "CIEN "
            Else
                If n10000000 = 1 And n1000000 > 0 And n1000000 <= 5 Then
                    letra = CENTENA(n100000000 + 1) + EXCEPCION(n1000000)
                Else
                    letra = CENTENA(n100000000 + 1) + DECENA(n10000000)
                    If n1000000 <> 0 And n10000000 <> 0 Then
                        letra = letra + "Y "
                    Else
                        letra = letra + ""
                    End If
                    letra = letra + UNIDAD(n1000000 + 1)
                End If
            End If
            If letra Is Nothing Or n1000000 <> 0 Then
                If n1000000 = 1 Then
                    letra = letra + "MILLON "
                Else
                    letra = letra + "MILLONES "
                End If
            End If

            'MILES
            If n100000 = 1 And n10000 = 0 And n1000 = 0 Then
                letra = letra + "CIEN "
            Else
                If n10000 = 1 And n1000 > 0 And n1000 <= 5 Then
                    letra = letra + CENTENA(n100000 + 1) + EXCEPCION(n1000)
                Else
                    letra = letra + CENTENA(n100000 + 1) + DECENA(n10000 + 1)
                    If n1000 <> 0 And n10000 <> 0 Then
                        letra = letra + "Y "
                    Else
                        letra = letra + ""
                    End If
                    letra = letra + UNIDAD(n1000 + 1)
                End If
            End If
            If n100000 <> 0 Or n10000 <> 0 Or n1000 <> 0 Then
                letra = letra + "MIL "
            End If
            If n100 = 1 And n10 = 0 And n = 0 Then
                letra = letra + "CIEN "
            Else
                If n10 = 1 And n > 0 And n <= 5 Then
                    letra = letra + CENTENA(n100 + 1) + EXCEPCION(n)
                Else
                    letra = letra + CENTENA(n100 + 1) + DECENA(n10 + 1)
                    If n <> 0 And n10 <> 0 Then
                        Select Case n10
                            Case 1
                                Select Case n
                                    Case 6, 7, 8, 9
                                        letra = Left(letra, Len(letra) - 2)
                                        letra = letra + "CI"
                                End Select
                            Case 2
                                letra = Left(letra, Len(letra) - 2)
                                letra = letra + "I"
                            Case Else
                                letra = letra + "Y "
                        End Select

                    Else
                        letra = letra + ""
                    End If
                    letra = letra + UNIDAD(n + 1)
                    If n = 1 And (n10 = 1 Or n10 = 2) Then
                        letra = Left(letra, Len(letra) - 1)
                        letra = letra
                    End If

                End If
            End If


            ''''''
            If nnumero < 10 Then
                ls_decimal = "0" + CStr(nnumero)
            Else
                ls_decimal = CStr(nnumero)
            End If

            letra = letra + ls_decimal + "/100"
            'linea1 = letra
            'If Len(Trim(letra)) < 50 Then
            '    linea1 = linea1 + linea1.PadRight(50 - Len(Trim(letra)), "*")
            'Else
            '    linea1 = linea1 + ""
            'End If

            'linea2 = linea2.PadRight(22, "*")
            'If Len(linea1) > 65 Then
            '    auxlinea = Left(linea1, linea1.IndexOf("/") - 3)
            '    linea2 = Right(linea1, 6) + linea1.PadRight(16, "*")
            '    linea1 = auxlinea
            'End If

            Return letra
        End Function

        Public Shared Function ConversionEnteros(ByVal nnumero As Double) As String


            Dim UNIDAD() As String = {"", "", "UNO ", "DOS ", "TRES ", "CUATRO ", "CINCO ", "SEIS ", "SIETE ", "OCHO ", "NUEVE "}
            Dim DECENA() As String = {"", "", "DIEZ ", "VEINTE ", "TREINTA ", "CUARENTA ", "CINCUENTA ", "SESENTA ", "SETENTA ", "OCHENTA ", "NOVENTA "}
            Dim CENTENA() As String = {"", "", "CIENTO ", "DOSCIENTOS ", "TRESCIENTOS ", "CUATROCIENTOS ", "QUINIENTOS ", _
                                        "SEISCIENTOS ", "SETECIENTOS ", "OCHOCIENTOS ", "NOVECIENTOS "}
            Dim EXCEPCION() As String = {"", "ONCE ", "DOCE ", "TRECE ", "CATORCE ", "QUINCE "}
            Dim num2, letra, auxlinea, ls_decimal As String

            Dim n100000000, n10000000, n1000000, n100000, n10000, n1000, n100, n10, n As Integer

            If nnumero = 0 Then
                letra = "CERO "
                Return letra
            End If

            num2 = CStr(Math.Round(nnumero, 2))

            n100000000 = Int(nnumero / 100000000)
            nnumero = nnumero - n100000000 * 100000000
            n10000000 = Int(nnumero / 10000000)
            nnumero = nnumero - n10000000 * 10000000
            n1000000 = Int(nnumero / 1000000)
            nnumero = nnumero - n1000000 * 1000000
            n100000 = Int(nnumero / 100000)
            nnumero = nnumero - n100000 * 100000
            n10000 = Int(nnumero / 10000)
            nnumero = nnumero - n10000 * 10000
            n1000 = Int(nnumero / 1000)
            nnumero = nnumero - n1000 * 1000
            n100 = Int(nnumero / 100)
            nnumero = nnumero - n100 * 100
            n10 = Int(nnumero / 10)
            nnumero = nnumero - n10 * 10
            n = Int(nnumero)

            'real en pb???

            n100000000 = CDbl(CStr(Math.Round(n100000000, 2)))
            n10000000 = CDbl(CStr(Math.Round(n10000000, 2)))
            n1000000 = CDbl(CStr(Math.Round(n1000000, 2)))
            n100000 = CDbl(CStr(Math.Round(n100000, 2)))
            n10000 = CDbl(CStr(Math.Round(n10000, 2)))
            n1000 = CDbl(CStr(Math.Round(n1000, 2)))
            n100 = CDbl(CStr(Math.Round(n100, 2)))
            n10 = CDbl(CStr(Math.Round(n10, 2)))
            n = CDbl(CStr(Math.Round(n, 2)))

            num2 = CStr(Math.Round(CDbl(CStr(Math.Round(nnumero, 2))), 2))


            nnumero = CDbl(Right(num2, 2))
            '  MILLONES
            If n100000000 = 1 And n10000000 = 0 And n1000000 = 0 Then
                letra = "CIEN "
            Else
                If n10000000 = 1 And n1000000 > 0 And n1000000 <= 5 Then
                    letra = CENTENA(n100000000 + 1) + EXCEPCION(n1000000)
                Else
                    letra = CENTENA(n100000000 + 1) + DECENA(n10000000)
                    If n1000000 <> 0 And n10000000 <> 0 Then
                        letra = letra + "Y "
                    Else
                        letra = letra + ""
                    End If
                    letra = letra + UNIDAD(n1000000 + 1)
                End If
            End If
            If letra Is Nothing Or n1000000 <> 0 Then
                If n1000000 = 1 Then
                    letra = letra + "MILLON "
                Else
                    letra = letra + "MILLONES "
                End If
            End If

            'MILES
            If n100000 = 1 And n10000 = 0 And n1000 = 0 Then
                letra = letra + "CIEN "
            Else
                If n10000 = 1 And n1000 > 0 And n1000 <= 5 Then
                    letra = letra + CENTENA(n100000 + 1) + EXCEPCION(n1000)
                Else
                    letra = letra + CENTENA(n100000 + 1) + DECENA(n10000 + 1)
                    If n1000 <> 0 And n10000 <> 0 Then
                        letra = letra + "Y "
                    Else
                        letra = letra + ""
                    End If
                    letra = letra + UNIDAD(n1000 + 1)
                End If
            End If
            If n100000 <> 0 Or n10000 <> 0 Or n1000 <> 0 Then
                letra = letra + "MIL "
            End If
            If n100 = 1 And n10 = 0 And n = 0 Then
                letra = letra + "CIEN "
            Else
                If n10 = 1 And n > 0 And n <= 5 Then
                    letra = letra + CENTENA(n100 + 1) + EXCEPCION(n)
                Else
                    letra = letra + CENTENA(n100 + 1) + DECENA(n10 + 1)
                    If n <> 0 And n10 <> 0 Then
                        Select Case n10
                            Case 1
                                Select Case n
                                    Case 6, 7, 8, 9
                                        letra = Left(letra, Len(letra) - 2)
                                        letra = letra + "CI"
                                End Select
                            Case 2
                                letra = Left(letra, Len(letra) - 2)
                                letra = letra + "I"
                            Case Else
                                letra = letra + "Y "
                        End Select

                    Else
                        letra = letra + ""
                    End If
                    letra = letra + UNIDAD(n + 1)
                    If n = 1 And (n10 = 1 Or n10 = 2) Then
                        letra = Left(letra, Len(letra) - 1)
                        letra = letra
                    End If

                End If
            End If


            'If nnumero < 10 Then
            '    ls_decimal = CStr(nnumero)
            'Else
            '    ls_decimal = CStr(nnumero)
            'End If
            'letra = letra
            'linea1 = letra
            'If Len(Trim(letra)) < 50 Then
            '    linea1 = linea1 + linea1.PadRight(50 - Len(Trim(letra)), "*")
            'Else
            '    linea1 = linea1 + ""
            'End If

            'linea2 = linea2.PadRight(22, "*")
            'If Len(linea1) > 65 Then

            '    auxlinea = Left(linea1, linea1.IndexOf("/") - 3)
            '    linea2 = Right(linea1, 6) + linea1.PadRight(16, "*")
            '    linea1 = auxlinea
            'End If


            Return letra
        End Function


    End Class

End Namespace
