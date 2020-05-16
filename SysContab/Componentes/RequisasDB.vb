Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Namespace VB.SysContab

    Public Class RequisasDetails
        Public Codigo As String
        Public Tipo As String
        Public Fecha As Date
        Public Bodega As String
        Public RealizadoPor As String
        Public AutorizadoPor As String
        Public Contabilizada As Boolean
        Public Distribuida As Boolean
        Public Comprobante As Integer
        Public Periodo As Integer
        Public Mes As Integer
        Public Registro As Boolean
        Public Factura As String

    End Class

    Public Class Requisas_DetalleDetails

    End Class


    Public Class RequisasDB

        Public Shared Function GetList_Requisas(Optional ByVal Bodega As String = "%", _
                                                Optional ByVal Fecha As String = "", _
                                                Optional ByVal Contabilizada As String = "%", _
                                                Optional ByVal Hasta As String = "") As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_Requisas", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            Dim pIdent3 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent4 As New SqlParameter("@Contabilizada", SqlDbType.NVarChar)
            Dim pHasta As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Bodega
            pIdent3.Value = Fecha
            pIdent4.Value = Contabilizada
            pHasta.Value = Hasta

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pHasta)

            Try
                DBCommand.Fill(dsFicha, "Requisas")
                DBConn.Close()

                Return dsFicha
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Function

        Public Shared Function GetList_RequisaReporte(ByVal Requisa As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_RequisaReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Requisa", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Requisa

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                DBCommand.Fill(dsFicha, "Requisa")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
                Return Nothing
            End Try
            Return dsFicha
        End Function

        Public Shared Function GetList_RequisaDetalle(ByVal Requisa As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_RequisaDetalleReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Requisa", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Requisa

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                DBCommand.Fill(dsFicha, "RequisaDetalle")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
                Return Nothing
            End Try
            Return dsFicha
        End Function

        Public Shared Function GetList_RequisaContabilizar(ByVal Requisa As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_RequisaDetalleContabilizar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Requisa", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Requisa

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                DBCommand.Fill(dsFicha, "RequisaContabilizar")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
                Return Nothing
            End Try
            Return dsFicha
        End Function

        Public Shared Function GetDetails(ByVal Requisa As String) As RequisasDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet
            Dim detalle As New VB.SysContab.RequisasDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_RequisaDetails", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Requisa", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Requisa

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                DBCommand.Fill(dsFicha, "RequisaDetails")
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "STS-Contab")
                Return Nothing
            End Try
            If dsFicha.Tables(0).Rows.Count = 1 Then
                detalle.Codigo = dsFicha.Tables(0).Rows(0)("req_codigo")
                detalle.Tipo = dsFicha.Tables(0).Rows(0)("req_tipo")
                detalle.Fecha = dsFicha.Tables(0).Rows(0)("req_fecha")
                detalle.Bodega = dsFicha.Tables(0).Rows(0)("codigo_bodega")
                detalle.RealizadoPor = dsFicha.Tables(0).Rows(0)("req_realizadopor")
                detalle.AutorizadoPor = dsFicha.Tables(0).Rows(0)("req_autorizadopor")
                detalle.Contabilizada = dsFicha.Tables(0).Rows(0)("req_contabilizada")
                detalle.Distribuida = dsFicha.Tables(0).Rows(0)("req_distribuida")
                detalle.Comprobante = IIf(dsFicha.Tables(0).Rows(0)("comp_no") Is DBNull.Value, 0, dsFicha.Tables(0).Rows(0)("comp_no"))
                detalle.Periodo = IIf(dsFicha.Tables(0).Rows(0)("per_id") Is DBNull.Value, 0, dsFicha.Tables(0).Rows(0)("per_id"))
                detalle.Mes = IIf(dsFicha.Tables(0).Rows(0)("Mes") Is DBNull.Value, 0, dsFicha.Tables(0).Rows(0)("Mes"))
                detalle.Registro = dsFicha.Tables(0).Rows(0)("registro")
                detalle.Factura = dsFicha.Tables(0).Rows(0)("Factura").ToString
            End If
            Return detalle
        End Function

        Public Shared Function AddItem(ByVal Requisa As Integer, ByVal TRequisa As String, _
            ByVal Fecha As Date, ByVal Bodega As String, ByVal RealizadoPor As String, _
            ByVal Registro As Boolean, ByVal Factura As String) As Integer

            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            DBCommand = New SqlDataAdapter("_Requisas_Add", DBConnFacturas)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Requisa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@TRequisa", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
            Dim pIdent5 As New SqlParameter("@Bodega", SqlDbType.NVarChar)
            Dim pIdent6 As New SqlParameter("@RealizadoPor", SqlDbType.NVarChar)
            Dim pIdent7 As New SqlParameter("@Registro", SqlDbType.Bit)
            Dim pIdent8 As New SqlParameter("@Factura", SqlDbType.NVarChar)

            pIdent.Value = EmpresaActual
            pIdent2.Direction = ParameterDirection.Output
            pIdent3.Value = TRequisa
            pIdent4.Value = Fecha
            pIdent5.Value = Bodega
            pIdent6.Value = RealizadoPor
            pIdent7.Value = Registro
            pIdent8.Value = Factura

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pIdent8)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.Connection = DBConnFacturas
                DBCommand.SelectCommand.Transaction = transaccionFacturas
                DBCommand.SelectCommand.ExecuteNonQuery()
                Return pIdent2.Value

            Catch ex As Exception
                MsgBox(ex.Message)
                Return -1
            End Try

        End Function

        Public Shared Function Detalle_AddItem(ByVal Requisa As Integer, ByVal Articulo As String, _
            ByVal TArticulo As String, ByVal Cantidad As Double, ByVal Precio As Double)

            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            DBCommand = New SqlDataAdapter("_Requisas_Detalle_Add", DBConnFacturas)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Requisa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim pIdent4 As New SqlParameter("@TArticulo", SqlDbType.NVarChar)
            Dim pIdent5 As New SqlParameter("@Cantidad", SqlDbType.Float)
            Dim pIdent6 As New SqlParameter("@Precio", SqlDbType.Float)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Requisa
            pIdent3.Value = Articulo
            pIdent4.Value = TArticulo
            pIdent5.Value = Cantidad
            pIdent6.Value = Precio

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.Connection = DBConnFacturas
                DBCommand.SelectCommand.Transaction = transaccionFacturas
                DBCommand.SelectCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function

        Public Function Update()


        End Function

        Public Shared Sub Delete(ByVal Requisa As Integer)

            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            DBCommand = New SqlDataAdapter("_Requisas_Delete", DBConnFacturas)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Requisa", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Requisa

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)


            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.Connection = DBConnFacturas
                DBCommand.SelectCommand.Transaction = transaccionFacturas
                DBCommand.SelectCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End Sub

        Public Shared Function GetCodigoNuevo() As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetList_RequisaCodigoNuevo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Direction = ParameterDirection.Output

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                Return -1
            End Try
            Return pIdent2.Value
        End Function

        Public Shared Function GetCodigoNuevoTemp() As Integer

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("JAR_GetList_RequisaCodigoNuevo", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Codigo", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Direction = ParameterDirection.Output

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBConn.Open()
                DBCommand.SelectCommand.ExecuteNonQuery()
                DBConn.Close()

            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                Return -1
            End Try
            Return pIdent2.Value
        End Function



        Public Shared Function Contabilizar(ByVal Requisa As Integer, _
            ByVal bContabilizar As Boolean, ByVal Distribuir As Boolean, _
        ByVal Comprobante As Integer, ByVal Periodo As Integer, ByVal Mes As Integer)

            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            DBCommand = New SqlDataAdapter("_Requisa_Contabilizar", DBConnFacturas)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Requisa", SqlDbType.Int)
            Dim pIdent3 As New SqlParameter("@Contabilizar", SqlDbType.Bit)
            Dim pIdent4 As New SqlParameter("@Distribuir", SqlDbType.Bit)
            Dim pIdent5 As New SqlParameter("@Comprobante", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Periodo", SqlDbType.Int)
            Dim pIdent7 As New SqlParameter("@Mes", SqlDbType.Int)

            pIdent.Value = EmpresaActual
            pIdent2.Value = Requisa
            pIdent3.Value = bContabilizar
            pIdent4.Value = Distribuir
            pIdent5.Value = Comprobante
            pIdent6.Value = Periodo
            pIdent7.Value = Mes

            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent4)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)

            Try
                'Se asigna conexion al comando y se abre conexion 
                DBCommand.SelectCommand.Connection = DBConnFacturas
                DBCommand.SelectCommand.Transaction = transaccionFacturas
                DBCommand.SelectCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Function
    End Class

End Namespace


