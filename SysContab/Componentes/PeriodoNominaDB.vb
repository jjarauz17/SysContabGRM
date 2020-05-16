Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class PeriodoNominaDetails
        Public Empresa As String
        Public Codigo As String
        Public Descripcion As String
        Public Procesado As String
        Public FProceso As String
        Public UProceso As String
        Public FInicio As String
        Public FFinal As String
        Public Tipo As String
    End Class

    Public Class PeriodoNominaDB

        Public Shared Function NominaxContabilizarList(ByVal Codigo As String) As DataSet
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("[_GetListPeriodoNominaPlanilla]", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            Dim _Codigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            _Codigo.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(_Codigo)

            DBCommand.Fill(dsFicha, "Tabla")
            DBConn.Close()
            Return dsFicha


        End Function


        Public Shared Function InatecXMes(ByVal Mes As Integer) As DataSet
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBCommand = New SqlDataAdapter("_InatecXMes", DBConnFacturas)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            DBCommand.SelectCommand.Connection = DBConnFacturas
            DBCommand.SelectCommand.Transaction = transaccionFacturas

            DBCommand.Fill(dsFicha, "Tabla")

            Return dsFicha
        End Function

        Public Shared Function IRXMes(ByVal Mes As Integer) As DataSet
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBCommand = New SqlDataAdapter("_IRXMes", DBConnFacturas)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            DBCommand.SelectCommand.Connection = DBConnFacturas
            DBCommand.SelectCommand.Transaction = transaccionFacturas

            DBCommand.Fill(dsFicha, "Tabla")

            Return dsFicha
        End Function

        Public Shared Function InssLaboralXMes(ByVal Mes As Integer) As DataSet
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBCommand = New SqlDataAdapter("_InssLaboralXMes", DBConnFacturas)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            DBCommand.SelectCommand.Connection = DBConnFacturas
            DBCommand.SelectCommand.Transaction = transaccionFacturas

            DBCommand.Fill(dsFicha, "Tabla")

            Return dsFicha
        End Function

        Public Shared Function InssPatronalXMes(ByVal Mes As Integer) As DataSet
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            DBCommand = New SqlDataAdapter("_InssPatronalXMes", DBConnFacturas)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            DBCommand.SelectCommand.Connection = DBConnFacturas
            DBCommand.SelectCommand.Transaction = transaccionFacturas

            DBCommand.Fill(dsFicha, "Tabla")

            Return dsFicha
        End Function

        Public Shared Function InssPatronal(ByVal Mes As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_InssPatronal", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            DBCommand.Fill(dsFicha, "Tabla")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function InssLaboral(ByVal Mes As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_InssLaboral", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            DBCommand.Fill(dsFicha, "Tabla")
            DBConn.Close()
            Return dsFicha

        End Function

        Public Shared Function InssPagar() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_InssPagar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")
            DBConn.Close()
            Return dsFicha

        End Function

        Public Shared Function IRPagar() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_IRPagar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")
            DBConn.Close()
            Return dsFicha

        End Function

        Public Shared Function InatecPagar() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_InatecPagar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")
            DBConn.Close()
            Return dsFicha

        End Function

        Public Shared Function PlanillasPagar() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlanillasPagar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function Contabilizar(ByVal Codigo As String, ByVal ComprobanteID As Integer)

            ' Create Instance of Connection and Command Object
            'Dim conexion As New VB.SysContab.Rutinas()
            Dim cmd As New SqlCommand("_PeriodoNominaContabilizar", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _TipoComp As New SqlParameter("@Codigo", SqlDbType.NVarChar, 9)
            _TipoComp.Value = Codigo
            cmd.Parameters.Add(_TipoComp)

            Dim _ComprobanteID As New SqlParameter("@Comprobante", SqlDbType.Int, 9)
            _ComprobanteID.Value = ComprobanteID
            cmd.Parameters.Add(_ComprobanteID)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()


        End Function

        Public Shared Function GetPlanilla(ByVal Codigo As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodoNominaPlanilla", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Codigo", SqlDbType.NVarChar, 50)
            pIdent1.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(pIdent1)

            Dim pIdent5 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent5.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            Try
                DBCommand.Fill(dsFicha, "Tabla")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Shared Function GetPlanilla_Distribucion(ByVal Codigo As String) As DataTable

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodoNominaPlanilla_Distribucion", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Codigo", SqlDbType.NVarChar, 50)
            pIdent1.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(pIdent1)

            Dim pIdent5 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent5.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            Try
                DBCommand.Fill(dsFicha, "Distribucion")
                DBConn.Close()
                Return dsFicha.Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Shared Function GetPlanilla(ByVal Codigo As String, ByVal Departamento As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodoNominaPlanilla_CCosto", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Codigo", SqlDbType.NVarChar, 50)
            pIdent1.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(pIdent1)

            Dim pIdent2 As New SqlParameter("@Departamento", SqlDbType.NVarChar, 10)
            pIdent2.Value = Departamento
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Dim pIdent5 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent5.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            Try
                DBCommand.Fill(dsFicha, "PDepartamentalizada")
                DBConn.Close()
                Return dsFicha

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
                Return Nothing
            End Try

        End Function

        Public Shared Function GetListContabilizado(ByVal Contabilizado As Boolean, ByVal Procesado As Boolean, _
                                                   ByVal Revisado As Boolean, ByVal Aprobado As Boolean) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodoNominaContabilizado", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Contabilizado", SqlDbType.Bit)
            pIdent1.Value = Contabilizado
            DBCommand.SelectCommand.Parameters.Add(pIdent1)

            Dim pIdent2 As New SqlParameter("@Procesado", SqlDbType.Bit)
            pIdent2.Value = Procesado
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Dim pIdent3 As New SqlParameter("@Revisado", SqlDbType.Bit)
            pIdent3.Value = Revisado
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Dim pIdent4 As New SqlParameter("@Aprobado", SqlDbType.Bit)
            pIdent4.Value = Aprobado
            DBCommand.SelectCommand.Parameters.Add(pIdent4)

            Dim pIdent5 As New SqlParameter("@Empresa", SqlDbType.Int)
            pIdent5.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            Try

            
                DBCommand.Fill(dsFicha, "Tabla")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try


        End Function

        Public Function GetDetails(ByVal Codigo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsHorario As New DataSet
            Dim Details As New PeriodoNominaDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodoNominaDetails", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Codigo
            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsHorario, "PeriodoNomina")

            If dsHorario.Tables("PeriodoNomina").Rows.Count = 1 Then

                Details.Empresa = dsHorario.Tables("PeriodoNomina").Rows(0).Item("empr_codigo")
                Details.Codigo = dsHorario.Tables("PeriodoNomina").Rows(0).Item("Per_Codigo")
                Details.Descripcion = dsHorario.Tables("PeriodoNomina").Rows(0).Item("Per_descripcion")
                Details.Procesado = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_procesado")
                Details.FProceso = IIf(IsDBNull(dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_fproceso")), "", dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_fproceso"))
                Details.UProceso = IIf(IsDBNull(dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_uproceso")), "", dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_uproceso"))
                Details.FInicio = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_finicio")
                Details.FFinal = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_ffinal")
                Details.Tipo = dsHorario.Tables("PeriodoNomina").Rows(0).Item("per_tipo")

            End If
            DBConn.Close()
            Return Details

        End Function

        Public Function GetList()

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodoNomina", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "PeriodoNomina")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Periodo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodoNominaBuscar", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Periodo", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Periodo
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "PeriodoNomina")
            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListNuevo(ByVal Tipo As String, ByRef Sufijo As String) As SelectionRange

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim PNomina As New VB.SysContab.PeriodoNominaDB
            Dim Inicio As DateTime
            Dim Final As DateTime

            Dim Rango As New SelectionRange

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListPeriodoNominaMaxTipo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Tipo
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "PeriodoNomina")

            If dsFicha.Tables("PeriodoNomina").Rows(0).Item("Fanterior") Is DBNull.Value Then
                Select Case Tipo
                    Case "S"
                        Inicio = IIf(Weekday(CDate("01/" + Format(Today, "MM") + _
                                                    "/" + Format(Today, "yyyy"))) = 1, _
                                    Today, DateAdd(DateInterval.Day, 2 + Weekday(CDate("01/" + _
                                                Format(Today, "MM") + "/" + Format(Today, "yyyy"))), _
                                                  CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))))
                        Final = DateAdd(DateInterval.Day, 6, Inicio)

                    Case "Q"
                        Inicio = CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))
                        Final = DateAdd(DateInterval.Day, 14, Inicio)

                    Case "M"
                        Inicio = CDate("01/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))
                        Final = CDate(Trim(Str(Meses(Month(Inicio) - 1))) & "/" + Format(Today, "MM") + "/" + Format(Today, "yyyy"))
                    Case "D"
                        'Averiguar como se haria para el Destajo
                End Select
                'PNomina.AddItem(Codigo, Descripcion, Inicio, Final, Tipo)
                Rango.Start = Inicio
                Rango.End = Final
                Sufijo = "01"

            Else
                Rango.Start = DateAdd(DateInterval.Day, 1, dsFicha.Tables("PeriodoNomina").Rows(0).Item("FAnterior"))
                Select Case Tipo
                    Case "S" 'Semanal
                        Rango.End = DateAdd(DateInterval.Day, 7, Rango.Start)
                        Select Case DatePart(DateInterval.Day, Rango.Start)
                            Case 1 To 7
                                Sufijo = "01"
                            Case 8 To 14
                                Sufijo = "02"
                            Case 15 To 21
                                Sufijo = "03"
                            Case Else
                                Sufijo = "04"
                        End Select

                    Case "Q" 'Quincenal
                        If DatePart(DateInterval.Day, Rango.Start) = 1 Then
                            Rango.End = DateAdd(DateInterval.Day, 14, Rango.Start)
                        Else
                            Rango.End = CDate(Trim(Str(Meses(Month(Rango.Start) - 1))) + "/" + Format(Rango.Start, "MM/yyyy"))
                        End If
                        If DatePart(DateInterval.Day, Rango.Start) = 1 Then
                            Sufijo = "01"
                        Else
                            Sufijo = "02"
                        End If
                    Case "M" 'Mensual
                        Rango.End = CDate(Trim(Str(Meses(Month(Rango.Start) - 1))) + "/" + Format(Rango.Start, "MM/yyyy"))
                        Sufijo = "01"
                    Case "D" 'Destajo
                        Rango.End = Rango.Start
                        Sufijo = "*"
                End Select

            End If
            DBConn.Close()
            Return Rango

        End Function

        Public Function AddItem(ByVal Codigo As String, ByVal Descripcion As String, _
            ByVal FInicio As DateTime, ByVal FFinal As DateTime, ByVal Tipo As String)

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PeriodoNominaAdd", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@FInicio", SqlDbType.DateTime)
            Dim pIdent5 As New SqlParameter("@FFinal", SqlDbType.DateTime)
            Dim pIdent6 As New SqlParameter("@Tipo", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Descripcion
            pIdent4.Value = FInicio
            pIdent5.Value = FFinal
            pIdent6.Value = Tipo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function
    End Class
End Namespace