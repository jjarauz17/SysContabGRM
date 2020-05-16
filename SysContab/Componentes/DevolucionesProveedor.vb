Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class DevolucionesProveedor

        Public Function GetListDevolucionesBodega(ByVal Factura As String, ByVal Proveedor As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DevolucionesProveedorBodegaList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Decimal)

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
            pProveedor.Value = Proveedor
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)

            DBCommand.Fill(dsFicha, "DevolucionesCliente")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function Numero() As String
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_DevolucionProveedorNumero", DBConn)

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

        Public Function AddItem(ByVal Devolucion As String, ByVal Factura As String, ByVal Proveedor As String)
            Dim cmd As SqlCommand = New SqlCommand("_DevolucionProveedorAdd", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Devolucion As SqlParameter = New SqlParameter("@Devolucion", SqlDbType.NVarChar)
            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.NVarChar, 50)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Devolucion.Value = Devolucion
            _Factura.Value = Factura
            _Proveedor.Value = Proveedor
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Devolucion)
            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Proveedor)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function AddItemDetalle(ByVal Devolucion As String, ByVal Item As String, ByVal Tipo As String, ByVal Cantidad As String, ByVal Iva As String)
            Dim cmd As SqlCommand = New SqlCommand("_DevolucionProveedorDetalleAdd", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Devolucion As SqlParameter = New SqlParameter("@Devolucion", SqlDbType.NVarChar, 50)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _Cantidad As SqlParameter = New SqlParameter("@Cantidad", SqlDbType.Float, 8)
            Dim _Iva As SqlParameter = New SqlParameter("@Iva", SqlDbType.Float, 8)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Devolucion.Value = Devolucion
            _Item.Value = Item
            _Tipo.Value = Tipo
            _Cantidad.Value = Cantidad
            _Iva.Value = Iva
            _Empresa.Value = EmpresaActual


            cmd.Parameters.Add(_Devolucion)
            cmd.Parameters.Add(_Item)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Cantidad)
            cmd.Parameters.Add(_Iva)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function UpdateItem(ByVal Factura As String, ByVal Proveedor As String, ByVal Item As String, ByVal Tipo As String, ByVal Devuelto As String)
            ' Create Instance of Connection and Command Object

            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'Dim conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnectionString"))
            Dim cmd As SqlCommand = New SqlCommand("_DevolucionProveedorUpdateItem", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC

            Dim _Factura As SqlParameter = New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            Dim _Proveedor As SqlParameter = New SqlParameter("@Proveedor", SqlDbType.NVarChar, 50)
            Dim _Item As SqlParameter = New SqlParameter("@Item", SqlDbType.NVarChar, 50)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar, 2)
            Dim _Devuelto As SqlParameter = New SqlParameter("@Devuelto", SqlDbType.Int, 4)
            Dim _Empresa As SqlParameter = New SqlParameter("@Empresa", SqlDbType.Int, 4)

            _Factura.Value = Factura
            _Proveedor.Value = Proveedor
            _Item.Value = Item
            _Tipo.Value = Tipo
            _Devuelto.Value = Devuelto
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Factura)
            cmd.Parameters.Add(_Proveedor)
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
            Dim cmd As SqlCommand = New SqlCommand("_DevolucionProveedorUpdateItemEstado", DBConnFacturas)

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

        Public Function GetList(ByVal Factura As String, ByVal Proveedor As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_DevolucionesProveedorList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Decimal)

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
            pProveedor.Value = Proveedor
            pEmpresa.Value = EmpresaActual
            'pIdent2.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pFactura)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
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

            DBCommand = New SqlDataAdapter("_DevolucionProveedorDetalle", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pDevolucion As New SqlParameter("@Devolucion", SqlDbType.NVarChar)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pDevolucion.Value = Devolucion
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pDevolucion)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function


    End Class

End Namespace

