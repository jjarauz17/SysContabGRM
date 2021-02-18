Imports Entities

Module DistribucionGastos

    Public Function CargaDistribucion(Optional ByVal Mes As Integer = 0,
                                     Optional ByVal Comprobante As Integer = 0,
                                     Optional ByVal Periodo As Integer = 0) As DataTable

        Dim dbDistribucion As New db_Distribucion

        Return dbDistribucion.CargaDistribucion(
            Comprobante,
            Periodo,
            Mes,
            EmpresaActual)

        'Return ObtieneDatos("SELECT * FROM Distribucion WHERE Mes = " & Mes & " AND NoComp = '" & Comprobante & "' AND IdEmpresa = " & EmpresaActual & " AND Per_Id = " & Periodo)
    End Function

    'Public Function CargaDistribucionTrans(ByVal Mes As Integer, ByVal Comprobante As Integer, ByVal Periodo As Integer) As DataTable

    '    Dim dbDistribucion As New db_Distribucion

    '    Return dbDistribucion.CargaDistribucionTrans(
    '        DBConnFacturas,
    '        transaccionFacturas,
    '        Comprobante,
    '        Periodo,
    '        Mes,
    '        EmpresaActual)

    '    'Return ObtieneDatosTrans("SELECT * FROM Distribucion WHERE Mes = " & Mes & " AND NoComp = '" & Comprobante & "' AND IdEmpresa = " & EmpresaActual & " AND Per_Id = " & Periodo)
    'End Function

    Public Sub EliminaDistribucion(ByVal Comp_Np As Integer,
                                   ByVal Per_Id As Integer,
                                   ByVal Mes As Integer,
                                   Optional Trans As Boolean = False)

        Dim objDistribucion As New Distribucion
        Dim dbDistribucion As New db_Distribucion

        objDistribucion.IdDetalle = 0
        objDistribucion.NoComp = Comp_Np
        objDistribucion.Per_Id = Per_Id
        objDistribucion.Mes = Mes
        objDistribucion.IdEmpresa = EmpresaActual

        Try
            dbDistribucion.Borrar(
                objDistribucion,
                Trans,
                DBConnFacturas,
                transaccionFacturas)
        Catch ex As Exception
        End Try

        'Try
        '    If Not Trans Then
        '        GuardaDatos("DELETE FROM Distribucion WHERE IdEmpresa = " & EmpresaActual & " AND NoComp = " & Comp_Np & " AND Mes = " & Mes & " AND Per_Id = " & Per_Id)
        '    Else
        '        GuardaDatosTrans("DELETE FROM Distribucion WHERE IdEmpresa = " & EmpresaActual & " AND NoComp = " & Comp_Np & " AND Mes = " & Mes & " AND Per_Id = " & Per_Id)
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub
    ''
    Public Sub EliminaDistribucionTrans(ByVal Comp_No As Integer,
                                        ByVal Per_Id As Integer,
                                        ByVal Mes As Integer)

        Dim objDistribucion As New Distribucion
        Dim dbDistribucion As New db_Distribucion

        objDistribucion.IdDetalle = 0
        objDistribucion.NoComp = Comp_No
        objDistribucion.Per_Id = Per_Id
        objDistribucion.Mes = Mes
        objDistribucion.IdEmpresa = EmpresaActual

        Try
            dbDistribucion.Borrar(
                objDistribucion,
                True,
                DBConnFacturas,
                transaccionFacturas)
        Catch ex As Exception
        End Try

        'Try
        '    GuardaDatosTrans("DELETE FROM Distribucion WHERE IdEmpresa = " & EmpresaActual & " AND NoComp = " & Comprobante & " AND Mes = " & Mes & " AND Per_Id = " & Periodo)
        'Catch ex As Exception
        'End Try
    End Sub

    Public Sub GuardaDistribucion(ByVal DT_Distribucion As DataTable,
                                       Comp_No As Integer,
                                       Per_Id As Integer,
                                       Mes As Integer)

        Dim dbDistribucion As New db_Distribucion,
            objDistribucion As New Distribucion

        objDistribucion.IdEmpresa = EmpresaActual
        objDistribucion.NoComp = Comp_No
        objDistribucion.Mes = Mes
        objDistribucion.Per_Id = Per_Id

        Dim DT_F As DataTable =
            DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Unchanged)

        If Not DT_F Is Nothing Then
            For i As Integer = 0 To DT_F.Rows.Count - 1
                With DT_F
                    objDistribucion.IdRubroGasto = .Rows(i).Item("IdRubroGasto")
                    objDistribucion.IdCentroCosto = .Rows(i).Item("IdCentroCosto")
                    objDistribucion.Valor = .Rows(i).Item("Valor")
                    objDistribucion.Tipo = .Rows(i).Item("Tipo")
                    objDistribucion.Cuenta = .Rows(i).Item("Cuenta")

                    dbDistribucion.Insertar(objDistribucion)
                End With
            Next
        End If
    End Sub

    Public Sub GuardaDistribucion(ByVal DT_Distribucion As DataTable,
                                  ByVal Fecha As Date,
                                  ByVal Comprobante As Integer,
                                  Optional Borrar As Boolean = True)

        Dim dbDistribucion As New db_Distribucion,
            objDistribucion As New Distribucion

        objDistribucion.IdEmpresa = EmpresaActual

        Dim DT_F As DataTable =
            DT_Distribucion.GetChanges(DataRowState.Deleted)

        If Borrar Then

            If Not DT_F Is Nothing Then
                For i As Integer = 0 To DT_F.Rows.Count - 1
                    With DT_F
                        If DT_F.Rows(i).RowState = DataRowState.Deleted Then
                            Dim Fila As DataRow = DT_F.Rows(i)

                            objDistribucion.IdDetalle = Fila("IdDetalle", DataRowVersion.Original)
                            dbDistribucion.Borrar(objDistribucion)

                            'GuardaDatos("DELETE FROM Distribucion WHERE IdDetalle = " & Fila("IdDetalle", DataRowVersion.Original))
                        End If
                    End With
                Next
            End If

        End If

        If Not DT_F Is Nothing Then DT_F.Clear()
        DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Unchanged)

        If Not DT_F Is Nothing Then
            For i As Integer = 0 To DT_F.Rows.Count - 1
                With DT_F

                    objDistribucion.NoComp = IIf(Comprobante = Nothing, .Rows(i).Item("NoComp"), Comprobante)
                    objDistribucion.Mes = Fecha.Month
                    objDistribucion.Per_Id = VB.SysContab.PeriodosDB.Activo(Fecha.Date)
                    objDistribucion.IdRubroGasto = .Rows(i).Item("IdRubroGasto")
                    objDistribucion.IdCentroCosto = .Rows(i).Item("IdCentroCosto")
                    objDistribucion.Valor = .Rows(i).Item("Valor")
                    objDistribucion.Tipo = .Rows(i).Item("Tipo")
                    objDistribucion.Cuenta = .Rows(i).Item("Cuenta")
                    objDistribucion.IdDetalle = IsNull(.Rows(i).Item("IdDetalle"), 0)

                    If DT_F.Rows(i).RowState = DataRowState.Added Then

                        dbDistribucion.Insertar(objDistribucion)

                        'GuardaDatos("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
                        '" VALUES(" & .Rows(i).Item("IdEmpresa") & "," & IIf(Comprobante = Nothing, .Rows(i).Item("NoComp"), Comprobante) & "," & Fecha.Month & "," &
                        'VB.SysContab.PeriodosDB.Activo(Fecha.Date) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")

                    ElseIf DT_F.Rows(i).RowState = DataRowState.Modified Then

                        dbDistribucion.Actualizar(objDistribucion)

                        'GuardaDatos("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & IIf(Comprobante = Nothing, .Rows(i).Item("NoComp"), Comprobante) & ",Mes=" & Fecha.Month & "," &
                        '"Per_Id = " & VB.SysContab.PeriodosDB.Activo(Fecha.Date) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," &
                        '"Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))

                    End If
                End With
            Next
        End If
    End Sub

    Public Sub GuardaDistribucionTrans(ByVal DT_Distribucion As DataTable,
                                       Comp_No As Integer,
                                       Per_Id As Integer,
                                       Mes As Integer)

        Dim dbDistribucion As New db_Distribucion,
            objDistribucion As New Distribucion

        objDistribucion.IdEmpresa = EmpresaActual
        objDistribucion.NoComp = Comp_No
        objDistribucion.Mes = Mes
        objDistribucion.Per_Id = Per_Id

        Dim DT_F As DataTable =
            DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified Or DataRowState.Unchanged)

        If Not DT_F Is Nothing Then
            For i As Integer = 0 To DT_F.Rows.Count - 1
                With DT_F
                    objDistribucion.IdRubroGasto = .Rows(i).Item("IdRubroGasto")
                    objDistribucion.IdCentroCosto = .Rows(i).Item("IdCentroCosto")
                    objDistribucion.Valor = .Rows(i).Item("Valor")
                    objDistribucion.Tipo = .Rows(i).Item("Tipo")
                    objDistribucion.Cuenta = .Rows(i).Item("Cuenta")

                    dbDistribucion.Insertar(
                            objDistribucion,
                            True,
                            DBConnFacturas,
                            transaccionFacturas)
                End With
            Next
        End If
    End Sub

    Public Sub GuardaDistribucionTrans(ByVal DT_Distribucion As DataTable,
                                       ByVal Fecha As Date,
                                       Optional ByVal Comprobante As String = vbNullString)

        Dim dbDistribucion As New db_Distribucion,
            objDistribucion As New Distribucion

        objDistribucion.IdEmpresa = EmpresaActual

        Dim DT_F As DataTable = DT_Distribucion.GetChanges(DataRowState.Deleted)
        If Not DT_F Is Nothing Then
            For i As Integer = 0 To DT_F.Rows.Count - 1
                With DT_F
                    If DT_F.Rows(i).RowState = DataRowState.Deleted Then
                        Dim Fila As DataRow = DT_F.Rows(i)

                        objDistribucion.IdDetalle = Fila("IdDetalle", DataRowVersion.Original)
                        dbDistribucion.Borrar(objDistribucion)

                        'GuardaDatosTrans("DELETE FROM Distribucion WHERE IdDetalle = " & Fila("IdDetalle", DataRowVersion.Original))
                    End If
                End With
            Next
        End If

        If Not DT_F Is Nothing Then DT_F.Clear()

        DT_F = DT_Distribucion.GetChanges(DataRowState.Added Or DataRowState.Modified)
        If Not DT_F Is Nothing Then
            For i As Integer = 0 To DT_F.Rows.Count - 1
                With DT_F
                    objDistribucion.NoComp = IIf(Comprobante = Nothing, .Rows(i).Item("NoComp"), Comprobante)
                    objDistribucion.Mes = Fecha.Month
                    objDistribucion.Per_Id = VB.SysContab.PeriodosDB.Activo(Fecha.Date)
                    objDistribucion.IdRubroGasto = .Rows(i).Item("IdRubroGasto")
                    objDistribucion.IdCentroCosto = .Rows(i).Item("IdCentroCosto")
                    objDistribucion.Valor = .Rows(i).Item("Valor")
                    objDistribucion.Tipo = .Rows(i).Item("Tipo")
                    objDistribucion.Cuenta = .Rows(i).Item("Cuenta")
                    objDistribucion.IdDetalle = .Rows(i).Item("IdDetalle")


                    If DT_F.Rows(i).RowState = DataRowState.Added Then

                        dbDistribucion.Insertar(
                            objDistribucion,
                            True,
                            DBConnFacturas,
                            transaccionFacturas)

                        'GuardaDatosTrans("INSERT INTO Distribucion(IdEmpresa,NoComp,Mes,Per_Id,IdRubroGasto,IdCentroCosto,Valor,Tipo,Cuenta) " &
                        '" VALUES(" & .Rows(i).Item("IdEmpresa") & "," & IIf(Comprobante = Nothing, .Rows(i).Item("NoComp"), Comprobante) & "," & Fecha.Month & "," &
                        'VB.SysContab.PeriodosDB.Activo(Fecha.Date) & "," & .Rows(i).Item("IdRubroGasto") & "," & .Rows(i).Item("IdCentroCosto") & "," & .Rows(i).Item("Valor") & ",'" & .Rows(i).Item("Tipo") & "','" & .Rows(i).Item("Cuenta") & "')")
                    ElseIf DT_F.Rows(i).RowState = DataRowState.Modified Then

                        dbDistribucion.Actualizar(
                            objDistribucion,
                            True,
                            DBConnFacturas,
                            transaccionFacturas)

                        'GuardaDatosTrans("UPDATE Distribucion SET IdEmpresa=" & .Rows(i).Item("IdEmpresa") & ",NoComp = " & IIf(Comprobante = Nothing, .Rows(i).Item("NoComp"), Comprobante) & ",Mes=" & Fecha.Month & "," &
                        '"Per_Id = " & VB.SysContab.PeriodosDB.Activo(Fecha.Date) & ",IdRubroGasto = " & .Rows(i).Item("IdRubroGasto") & ",IdCentroCosto =" & .Rows(i).Item("IdCentroCosto") & ",Valor = " & .Rows(i).Item("Valor") & "," &
                        '"Tipo='" & .Rows(i).Item("Tipo") & "',Cuenta='" & .Rows(i).Item("Cuenta") & "' WHERE IdDetalle = " & .Rows(i).Item("IdDetalle"))
                    End If
                End With
            Next
        End If
    End Sub

End Module
