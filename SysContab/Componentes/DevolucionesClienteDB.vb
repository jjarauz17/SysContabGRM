Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class DevolucionesClienteDB

        Public Function GetListDevolucionesBodega(ByVal Factura As String, ByVal Cliente As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DevolucionesClienteBodegaList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Decimal)

            If Fecha1 = "" Then
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            Else
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.DateTime)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            End If


            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pCliente.Value = Cliente
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pCliente)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "DevolucionesCliente")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function Numero() As String
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_DevolucionClienteNumero", DBConn)

            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            cmd.Parameters.Add(pEmpresa)

            Dim pNumero As SqlParameter = New SqlParameter("@Numero", SqlDbType.NVarChar, 50)
            pNumero.Direction = ParameterDirection.Output
            cmd.Parameters.Add(pNumero)

            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            If pNumero.Value.ToString() <> "" Then
                Return CType(pNumero.Value, String)
            Else
                Return 1
            End If
        End Function

        Public Sub AddItem(ByVal Devolucion As String,
                           ByVal Factura As String,
                           ByVal Referencia As String,
                           Comp_No As Integer,
                           Per_Id As Integer,
                           Mes As Integer,
                           Parcial As Integer,
                           Optional Consecutivo As String = "",
                           Optional Concepto As String = "")

            Dim cmd As SqlCommand = New SqlCommand("_DevolucionClienteAdd",
                                                   DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure

            'Dim _Devolucion As SqlParameter = New SqlParameter("@Devolucion", SqlDbType.NVarChar)
            'Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            'Dim _Usuario As SqlParameter = New SqlParameter("@Usuario", SqlDbType.Int, 4)
            'Dim _Referencia As SqlParameter = New SqlParameter("@Referencia", SqlDbType.NVarChar)
            'Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)
            'Dim _Comp_No As SqlParameter = New SqlParameter("@Comp_No", SqlDbType.Int, 4)
            'Dim _Per_Id As SqlParameter = New SqlParameter("@Per_Id", SqlDbType.Int, 4)
            'Dim _Mes As SqlParameter = New SqlParameter("@Mes", SqlDbType.Int, 4)

            '_Devolucion.Value = Devolucion
            '_Factura.Value = Factura
            '_Usuario.Value = Usuario_ID
            '_Referencia.Value = Referencia
            '_Empresa.Value = EmpresaActual
            '_Comp_No.Value = Comp_No
            '_Per_Id.Value = Per_Id
            '_Mes.Value = Mes

            'cmd.Parameters.Add(_Devolucion)
            'cmd.Parameters.Add(_Factura)
            'cmd.Parameters.Add(_Usuario)
            'cmd.Parameters.Add(_Referencia)
            'cmd.Parameters.Add(_Empresa)
            'cmd.Parameters.Add(_Comp_No)
            'cmd.Parameters.Add(_Per_Id)
            'cmd.Parameters.Add(_Mes)
            Try
                cmd.Parameters.AddWithValue("@Devolucion", Devolucion)
                cmd.Parameters.AddWithValue("@Factura", Factura)
                cmd.Parameters.AddWithValue("@Usuario", Usuario_ID)
                cmd.Parameters.AddWithValue("@Referencia", Referencia)
                cmd.Parameters.AddWithValue("@Empresa", EmpresaActual)
                cmd.Parameters.AddWithValue("@Comp_No", Comp_No)
                cmd.Parameters.AddWithValue("@Per_Id", Per_Id)
                cmd.Parameters.AddWithValue("@Mes", Mes)
                cmd.Parameters.AddWithValue("@Consecutivo", Consecutivo)
                cmd.Parameters.AddWithValue("@Parcial", Parcial)
                cmd.Parameters.AddWithValue("@Concepto", Concepto)

                cmd.CommandTimeout = 0
                cmd.Connection = DBConnFacturas
                cmd.Transaction = transaccionFacturas
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                XtraMsg("Error al Guardar SP: _DevolucionClienteAdd" & vbCrLf &
                        ex.Message)
            End Try

        End Sub

        Public Function AddItemDetalle(ByVal Devolucion As String,
                                       ByVal Item As String,
                                       ByVal Tipo As String,
                                       ByVal Cantidad As Double,
                                       ByVal Iva As Double,
                                       ByVal Precio As Double,
                                       Mantenimiento As Double,
                                       Descuento As Double) As Boolean

            Dim cmd As SqlCommand = New SqlCommand("_DevolucionClienteDetalleAdd",
                                                   DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure

            'Dim _Devolucion As SqlParameter = New SqlParameter("@Devolucion", SqlDbType.NVarChar, 50)
            'Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            'Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            'Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Decimal, 18)
            'Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Decimal, 18)
            'Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            '_Devolucion.Value = Devolucion
            '_Item.Value = Item
            '_Tipo.Value = Tipo
            '_Cantidad.Value = Cantidad
            '_Iva.Value = Iva
            '_Empresa.Value = EmpresaActual

            'cmd.Parameters.Add(_Devolucion)
            'cmd.Parameters.Add(_Item)
            'cmd.Parameters.Add(_Tipo)
            'cmd.Parameters.Add(_Cantidad)
            'cmd.Parameters.Add(_Iva)
            'cmd.Parameters.Add(_Empresa)

            cmd.Parameters.AddWithValue("@Devolucion", Devolucion)
            cmd.Parameters.AddWithValue("@Item", Item)
            cmd.Parameters.AddWithValue("@Tipo", Tipo)
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad)
            cmd.Parameters.AddWithValue("@Iva", Iva)
            cmd.Parameters.AddWithValue("@Empresa", EmpresaActual)
            cmd.Parameters.AddWithValue("@Precio", Precio)
            cmd.Parameters.AddWithValue("@Mantenimiento", Mantenimiento)
            cmd.Parameters.AddWithValue("@Descuento", Descuento)

            Try

                cmd.CommandTimeout = 0
                cmd.Connection = DBConnFacturas
                cmd.Transaction = transaccionFacturas
                cmd.ExecuteNonQuery()

                Return True
            Catch ex As Exception
                XtraMsg("Error al Guardar SP: _DevolucionClienteDetalleAdd" & vbCrLf &
                        ex.Message)
                Return False
            End Try
        End Function

        Public Function UpdateItem(ByVal Factura As String, ByVal Item As String, ByVal Tipo As String, ByVal Devuelto As String)
            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_DevolucionUpdateItem", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _Devuelto As SqlParameter = New SqlParameter("@Devuelto", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Item.Value = Item
            _Tipo.Value = Tipo
            _Devuelto.Value = Devuelto
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Devuelto)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            'Try
            '    DBConn.Open()
            '    cmd.ExecuteNonQuery()
            '    DBConn.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message & " RestarExistencias")
            'End Try

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function UpdateItemEstado(ByVal Devolucion As String, ByVal Item As String, ByVal Tipo As String, ByVal Estado As String)
            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_DevolucionClienteUpdateItemEstado", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Devolucion As SqlParameter = New SqlParameter("@Devolucion", SqlDbType.NVarChar, 50)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Devolucion.Value = Devolucion
            _Item.Value = Item
            _Tipo.Value = Tipo
            _Estado.Value = Estado
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Devolucion)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Estado)
            cmd.Parameters.Add(_Empresa)

            ' Open the connection and execute the Command
            'Try
            '    DBConn.Open()
            '    cmd.ExecuteNonQuery()
            '    DBConn.Close()
            'Catch ex As Exception

            '    MsgBox(ex.Message & " RestarExistencias")
            'End Try

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function GetList(ByVal Factura As String, ByVal Cliente As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DevolucionesClienteList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Decimal)

            If Fecha1 = "" Then
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            Else
                Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
                Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.DateTime)
                pFecha1.Value = Fecha1
                pFecha2.Value = Fecha2
                DBCommand.SelectCommand.Parameters.Add(pFecha1)
                DBCommand.SelectCommand.Parameters.Add(pFecha2)
            End If


            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFactura.Value = Factura
            pCliente.Value = Cliente
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pCliente)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "DevolucionesCliente")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function DevolucionDetalle(ByVal Devolucion As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DevolucionClienteDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pDevolucion As New SqlParameter("@Devolucion", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pDevolucion.Value = Devolucion
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pDevolucion)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Sub EnviarAlertaCorreo(NoDevolucion As Integer)
            ObtieneDatos("JAR_EnviarAlertaDevolución", NoDevolucion, EmpresaActual)
        End Sub


    End Class

End Namespace
