Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class PresupuestoDB


        Public Function GetList_CuentasPresupuesto() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCuentasPresupuesto", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            Try
                DBCommand.Fill(dsFicha, "Presupuesto")
                DBConn.Close()

                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function GetList_CuentasPresupuesto_Combo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListCuentasPresupuesto_Combo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            Try
                DBCommand.Fill(dsFicha, "Presupuesto")
                DBConn.Close()

                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function GetPresupuestoDetalle(ByVal Codigo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetPresupuestoDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            DBCommand.SelectCommand.CommandTimeout = 0


            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Codigo", SqlDbType.NVarChar)

            pIdent2.Value = EmpresaActual
            pIdent3.Value = Codigo

            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            Try
                DBCommand.Fill(dsFicha, "PresupuestoDetalle")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Return dsFicha
        End Function

        Public Function GetPresupuesto_Activo() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetPresupuesto_Activo", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent2.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Presupuesto")
            DBConn.Close()

            Return dsFicha
        End Function


        Public Function GetPresupuesto_Nvo(ByVal Desde As String, ByVal Hasta As String, _
            ByRef Conexion As SqlConnection, ByRef Transaxion As SqlTransaction) As String
            '            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            '           DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Presupuesto_Nvo", Conexion)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pident0 As New SqlParameter("@Desde", SqlDbType.NVarChar)
            Dim pident1 As New SqlParameter("@Hasta", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Codigo", SqlDbType.NVarChar, 11)
            pIdent3.Direction = ParameterDirection.Output



            pident0.Value = Desde
            pident1.Value = Hasta
            pIdent2.Value = EmpresaActual
            pIdent3.Value = ""

            DBCommand.SelectCommand.Parameters.Add(pident0)
            DBCommand.SelectCommand.Parameters.Add(pident1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)

            DBCommand.SelectCommand.Transaction = Transaxion
            DBCommand.SelectCommand.ExecuteNonQuery()
            'DBConn.Close()

            Return pIdent3.Value


        End Function


        Public Shared Function GetListReporte(ByVal CodPresupuesto As String, ByVal Moneda As String, ByVal cuenta As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetReportePresupuesto", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Presupuesto", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@moneda", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@cuenta", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Value = CodPresupuesto
            pIdent3.Value = Moneda
            pIdent4.Value = cuenta
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            Try

                DBCommand.Fill(dsFicha, "RepPresupuesto")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

        Public Shared Function GetListReporte_Filtro(ByVal cuenta As String, _
            ByVal Nivel As String, ByVal Moneda As String, ByVal periodo As String, _
            ByVal Desde As Date, ByVal hasta As Date, _
            ByVal periodo2 As String, ByVal Desde2 As Date, ByVal hasta2 As Date) As DataSet

            'ByVal CodPresupuesto As String, _
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetReportePresupuesto_Filtro", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@PerId", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pIdent5 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@Nivel", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            Dim pIdent8 As New SqlParameter("@PerId2", SqlDbType.Int)
            Dim pIdent9 As New SqlParameter("@Desde2", SqlDbType.SmallDateTime)
            Dim pIdent10 As New SqlParameter("@Hasta2", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = periodo
            pIdent3.Value = Desde
            pIdent4.Value = hasta
            pIdent5.Value = cuenta
            pIdent6.Value = Nivel
            pIdent7.Value = Moneda
            pIdent8.Value = periodo2
            pIdent9.Value = Desde2
            pIdent10.Value = hasta2

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)
            DBCommand.SelectCommand.Parameters.Add(pIdent9)
            DBCommand.SelectCommand.Parameters.Add(pIdent10)
            Try
                DBCommand.Fill(dsFicha, "RepPresupuesto")
                DBConn.Close()
                Return dsFicha
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function
        Public Function GetDetails(ByVal Codigo As String) As MonedaDetails

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsMonedas As New DataSet()
            'Dim Details As New MonedaDetails()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_GetListMonedaDetails", DBConn)
            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'Dim pIdent As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            'pIdent.Value = Codigo
            'pIdent2.Value = EmpresaActual
            'DBCommand.SelectCommand.Parameters.Add(pIdent)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            'DBCommand.Fill(dsMonedas, "MonedaS")

            'If dsMonedas.Tables("MonedaS").Rows.Count = 1 Then

            '    Details.Codigo = dsMonedas.Tables("monedaS").Rows(0).Item("mon_codigo")
            '    Details.Descripcion = dsMonedas.Tables("monedaS").Rows(0).Item("mon_descripcion")

            'End If

            'Return Details

        End Function

        Public Function Delete(ByVal Codigo As String)

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_Presupuesto_Delete", DBConn)
            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'Dim pIdent As New SqlParameter("@pre_codigo", SqlDbType.NVarChar)
            'Dim pIdent2 As New SqlParameter("@empr_codigo", SqlDbType.Int)

            'pIdent.Value = Codigo
            'pIdent2.Value = EmpresaActual
            'DBCommand.SelectCommand.Parameters.Add(pIdent)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            'DBConn.Open()
            'DBCommand.SelectCommand.ExecuteNonQuery()
            'DBConn.Close()

        End Function

        Public Function AddItem_Encabezado(ByVal Codigo As String, _
            ByVal Descripcion As String, ByVal Desde As String, _
            ByVal Hasta As String, ByVal Periodo As Integer)

            Dim DBCommand As SqlDataAdapter


            DBCommand = New SqlDataAdapter("_Presupuesto_Add", DBConnFacturas)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empr_codigo", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@pre_Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@pre_Descripcion", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@pre_Desde", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@pre_hasta", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@pre_activo", SqlDbType.Bit)
            Dim pIdent7 As New SqlParameter("@Per_ID", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Descripcion
            pIdent4.Value = Desde
            pIdent5.Value = Hasta
            pIdent6.Value = True
            pIdent7.Value = Periodo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)


            'Se asigna conexion al comando y se abre conexion 
            DBCommand.SelectCommand.Transaction = transaccionFacturas
            DBCommand.SelectCommand.ExecuteNonQuery()

        End Function


        Public Function AddItem_Detalle(ByVal Codigo As String, ByVal Cuenta As String, _
                    ByVal mes As String, ByVal MontoInicial As Double, ByVal Monto As Double)

            Dim DBCommand As SqlDataAdapter

            DBCommand = New SqlDataAdapter("_PresupuestoDetalle_Add", DBConnFacturas)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empr_codigo", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@pre_Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@pre_cuenta", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@pre_mes", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@pre_montoInicial", SqlDbType.Money)
            Dim pIdent6 As New SqlParameter("@pre_monto", SqlDbType.Money)
            Dim pIdent7 As New SqlParameter("@pre_ejecutado", SqlDbType.Money)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Cuenta
            pIdent4.Value = mes
            pIdent5.Value = MontoInicial
            pIdent6.Value = Monto
            pIdent7.Value = 0.0

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)


            'Se asigna conexion al comando y se abre conexion 
            DBCommand.SelectCommand.Transaction = transaccionFacturas
            DBCommand.SelectCommand.ExecuteNonQuery()

        End Function

        Public Function UpdateItem_Detalle(ByVal Codigo As String, ByVal Cuenta As String, _
                            ByVal mes As String, ByVal Monto As Double)

            Dim DBCommand As SqlDataAdapter

            DBCommand = New SqlDataAdapter("_PresupuestoDetalle_Update", DBConnFacturas)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empr_codigo", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@pre_Codigo", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@pre_cuenta", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@pre_mes", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@pre_monto", SqlDbType.Money)



            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo
            pIdent3.Value = Cuenta
            pIdent4.Value = mes
            pIdent6.Value = Monto


            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)



            'Se asigna conexion al comando y se abre conexion 
            DBCommand.SelectCommand.Transaction = transaccionFacturas
            DBCommand.SelectCommand.ExecuteNonQuery()

        End Function

        Public Function Presupuesto_Desactivar(ByVal Codigo As String)

            Dim DBCommand As SqlDataAdapter

            DBCommand = New SqlDataAdapter("_Presupuesto_DesActivar", DBConnFacturas)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empr_codigo", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@pre_Codigo", SqlDbType.NVarChar)


            pIdent.Value = EmpresaActual
            pIdent2.Value = Codigo

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            'Se asigna conexion al comando y se abre conexion 
            DBCommand.SelectCommand.Transaction = transaccionFacturas
            DBCommand.SelectCommand.ExecuteNonQuery()

        End Function


        Public Function Update(ByVal Codigo As String, ByVal Descripcion As String) As Integer

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_MonedaUpdate", DBConn)
            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            'Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            'Dim pIdent3 As New SqlParameter("@Descripcion", SqlDbType.NVarChar)

            'pIdent.Value = EmpresaActual
            'pIdent2.Value = Codigo
            'pIdent3.Value = Descripcion

            'DBCommand.SelectCommand.Parameters.Add(pIdent)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)
            'DBCommand.SelectCommand.Parameters.Add(pIdent3)

            'Try
            '    'Se asigna conexion al comando y se abre conexion 
            '    DBConn.Open()
            '    DBCommand.SelectCommand.ExecuteNonQuery()
            '    DBConn.Close()

            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Return -1
            'End Try
            'Return 0
        End Function
    End Class
End Namespace



