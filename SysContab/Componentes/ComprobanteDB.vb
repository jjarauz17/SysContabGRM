Imports System
Imports System.IO
Imports DbConnect
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports DevExpress.XtraReports.UI


Namespace VB.SysContab


    '*******************************************************
    ' ComprobanteDB
    ' Objetivo: Manejar todas la funciones de comprobantes
    ' Autor: Bernardo Robelo
    ' Fecha: 9/Nov/2005
    '*******************************************************

    Public Class ComprobantesDetails

        Public Numero As String
        Public Fecha As String
        Public Tipo As String
        Public Tipo1 As String
        Public TasaCambio As String
        Public Descripcion As String
        Public Concepto As String
        Public Cheque As String
        Public Moneda As String
        Public Factura As String
        Public Recibo As String
        Public ChequeNombre As String
        Public Pagara As String
        Public Ruc As String
        Public FormaPago As String
        Public Proveedor As String
        Public Factura1 As String
        Public FechaPago As String
        Public TipoX As String
        Public Comp As String
        Public Consecutivo As String
        Public Detalles As DataSet

    End Class

    Public Class Tipo_ComprobanteDetails
        Public Codigo As String
        Public Nombre As String
        Public Abreviatura As String
        Public Cierre As Boolean
        Public Cheque As Boolean
        Public Mantenimiento As Boolean
        Public Inicio As String
    End Class

    Public Class Tipo
        Public Const Mes As Integer = 1
        Public Const Trimestre As Integer = 2
        Public Const Ano As Integer = 3
    End Class

    Public Class ComprobanteDB


        Public Shared Function GetComprobante(ByVal Factura As String, ByVal Proveedor As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComprobantesxFactura", DBConn)

            ' Mark the Command as a SPROC
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pFactura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            pFactura.Value = Factura
            DBCommand.SelectCommand.Parameters.Add(pFactura)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            _Proveedor.Value = Proveedor
            DBCommand.SelectCommand.Parameters.Add(_Proveedor)

            Dim myDataSet As New DataSet

            DBCommand.Fill(myDataSet, "ComprobantesDetalles")

            DBConn.Close()

            Return myDataSet


        End Function

        Public Shared Function GetComprobante(ByVal Factura As String, ByVal Proveedor As String, ByVal Fecha As DateTime) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComprobantesAprobadoxFactura", DBConn)

            ' Mark the Command as a SPROC
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim ComprNO As New SqlParameter("@Factura", SqlDbType.NVarChar)
            ComprNO.Value = Factura
            DBCommand.SelectCommand.Parameters.Add(ComprNO)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _PerID As New SqlParameter("@Proveedor", SqlDbType.Int)
            _PerID.Value = Proveedor
            DBCommand.SelectCommand.Parameters.Add(_PerID)

            Dim _Fecha1 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha1.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)

            Dim myDataSet As New DataSet
            Try
                DBCommand.Fill(myDataSet, "ComprobantesDetalles")

            Catch e As Exception
                MsgBox(e.Message)
            End Try

            DBConn.Close()

            Return myDataSet

        End Function

        Public Shared Function GetComprobanteTrans(ByVal Factura As String, ByVal Proveedor As String, ByVal Fecha As DateTime) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComprobantesAprobadoxFactura", DBConn)

            ' Mark the Command as a SPROC
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim ComprNO As New SqlParameter("@Factura", SqlDbType.NVarChar)
            ComprNO.Value = Factura
            DBCommand.SelectCommand.Parameters.Add(ComprNO)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _PerID As New SqlParameter("@Proveedor", SqlDbType.Int)
            _PerID.Value = Proveedor
            DBCommand.SelectCommand.Parameters.Add(_PerID)

            Dim _Fecha1 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha1.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)

            Dim myDataSet As New DataSet
            Try
                DBCommand.Fill(myDataSet, "ComprobantesDetalles")

            Catch e As Exception
                MsgBox(e.Message)
            End Try

            DBConn.Close()

            Return myDataSet

        End Function


        'Public Shared Function GeneraComprobantePagoProductos(ByVal CuentaProv As String, ByVal DebeProv As String, ByVal HaberProv As String, _
        '                       ByVal ConceptoProv As String, ByVal NoCheque As String, _
        '                       ByVal CuentaBanco As String, ByVal DebeBanco As String, ByVal HaberBanco As String, _
        '                       ByVal ConceptoBanco As String, _
        '                       ByVal CuentaIR As String, ByVal DebeIR As String, ByVal HaberIR As String, _
        '                       ByVal ConceptoIR As String, _
        '                       ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
        '                       ByVal TipoComProbante As String, ByVal ComprFecha As String, ByVal FacturaNo As String, ByVal Proveedor As String, _
        '                       ByVal ChequeNombre As String, ByVal FechaFact As String, _
        '                       ByVal ComprFact As String, ByVal PerIDFact As String, ByVal FormaPago As String) As String

        '    ' Create Instance of Connection and Command Object
        '    Dim Catalogo As New CatalogoDB
        '    Dim Comp As New ComprobanteDB

        '    Dim FactComp As New Facturas_ComprasDB
        '    Dim CompNo As String = 0

        '    Dim s, c As String

        '    Dim a(100), b(100), Fech(100) As String

        '    Dim Facturas As String() = FacturaNo.Split(New Char() {"|"})
        '    Dim Comprobante As String() = ComprFact.Split(New Char() {"|"})

        '    Dim j As Integer = 0

        '    For Each s In Facturas
        '        Dim Ds As DataSet = Comp.GetComprobante(s.Trim, Proveedor)

        '        b(j) = Ds.Tables(0).Rows(0).Item("CDet_Importe")
        '        Fech(j) = Ds.Tables(0).Rows(0).Item("Factura_Fecha")
        '        j = j + 1
        '    Next

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        '    DBConnFacturas.Open()
        '    transaccionFacturas = DBConnFacturas.BeginTransaction()

        '    Try
        '        CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(ComprFecha), ComprFecha, 0, ChequeNombre, False, Proveedor, "", 2, FacturaNo, VB.SysContab.Rutinas.Fecha, FormaPago, False)

        '        ActualizarCheque(CuentaBanco, NoCheque)



        '        '' Para Proveedores
        '        AddComprobanteDetalles(CompNo, CuentaProv, ConceptoProv, DebeProv, NoCheque, TipoComProbante, "D", "", 0, ComprFecha, 1)
        '        'AddCatalogoTrans(CuentaProv, DebeProv, HaberProv, ConceptoProv)
        '        'Catalogo.ActualizarCuentas(CuentaProv, DebeProv, 2) ' Se va a Restar de la Cuenta


        '        ' Para Banco
        '        AddComprobanteDetalles(CompNo, CuentaBanco, ConceptoBanco, HaberBanco, NoCheque, TipoComProbante, "C", "", 0, ComprFecha, 0)
        '        'AddCatalogoTrans(CuentaBanco, DebeBanco, HaberBanco, ConceptoBanco)
        '        'Catalogo.ActualizarCuentas(CuentaBanco, HaberBanco, 2) ' Se va a restar al Banco


        '        If HaberIR > 0 Then

        '            ' ParaIR
        '            AddComprobanteDetalles(CompNo, CuentaIR, ConceptoIR, HaberIR, NoCheque, TipoComProbante, "C", "", 0, ComprFecha, 1)
        '            'AddCatalogoTrans(CuentaIR, DebeIR, HaberIR, ConceptoIR)
        '            'Catalogo.ActualizarCuentas(CuentaIR, HaberIR, 1) ' Se va a Sumar

        '        End If


        '        j = 0

        '        For Each c In Comprobante
        '            a(j) = c.Trim
        '            j = j + 1
        '        Next

        '        j = 0


        '        For Each s In Facturas
        '            If s.Trim() <> "" Then

        '                CancelarFactura(s.Trim, Proveedor, 1)

        '                PagosFactura(a(j), PerIDFact, Fech(j), b(j), CompNo, PeriodosDB.Activo(ComprFecha), ComprFecha, s.Trim, Proveedor, FormaPago)
        '                j = j + 1

        '            End If
        '        Next s





        '        VB.SysContab.Rutinas.okTransaccion()

        '    Catch Mensaje As Exception
        '        VB.SysContab.Rutinas.ErrorTransaccion()
        '        MsgBox(Mensaje.Message)

        '    End Try

        '    Return CompNo

        'End Function




        'Public Shared Function GetComprobante(ByVal Factura As String, ByVal Proveedor As String, ByVal Fecha As DateTime) As DataSet

        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_ComprobantesAprobadoxFactura", DBConn)

        '    ' Mark the Command as a SPROC
        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    ' Add Parameters to SPROC
        '    Dim ComprNO As New SqlParameter("@Factura", SqlDbType.NVarChar)
        '    ComprNO.Value = Factura
        '    DBCommand.SelectCommand.Parameters.Add(ComprNO)

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    DBCommand.SelectCommand.Parameters.Add(pEmpresa)

        '    Dim _PerID As New SqlParameter("@Proveedor", SqlDbType.Int)
        '    _PerID.Value = Proveedor
        '    DBCommand.SelectCommand.Parameters.Add(_PerID)

        '    Dim _Fecha1 As New SqlParameter("@Fecha", SqlDbType.DateTime)
        '    _Fecha1.Value = Fecha
        '    DBCommand.SelectCommand.Parameters.Add(_Fecha1)

        '    Dim myDataSet As New DataSet
        '    Try
        '        DBCommand.Fill(myDataSet, "ComprobantesDetalles")

        '    Catch e As Exception
        '        MsgBox(e.Message)
        '    End Try

        '    DBConn.Close()

        '    Return myDataSet


        'End Function

        Public Shared Function PagosFacturasBorrar(ByVal CompCheque As Integer, ByVal Mes As Integer, ByVal PerID As Integer)

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim cmd As New SqlCommand("_PagosFacturasBorrar", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure


            Dim _CompCheque As New SqlParameter("@CompCheque", SqlDbType.Int)
            _CompCheque.Value = CompCheque
            cmd.Parameters.Add(_CompCheque)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            cmd.Parameters.Add(_Mes)

            Dim _PerID As New SqlParameter("@PerID", SqlDbType.Int)
            _PerID.Value = PerID
            cmd.Parameters.Add(_PerID)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Shared Function GetComprobanteAprobado(ByVal CompNo As String, ByVal PerID As String, ByVal Fecha As DateTime) As Boolean


            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComprobantesAprobado", DBConn)

            ' Mark the Command as a SPROC
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim ComprNO As New SqlParameter("@ComprNO", SqlDbType.Int)
            ComprNO.Value = CompNo
            DBCommand.SelectCommand.Parameters.Add(ComprNO)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _PerID As New SqlParameter("@PerID", SqlDbType.Int)
            _PerID.Value = PerID
            DBCommand.SelectCommand.Parameters.Add(_PerID)

            Dim _Fecha1 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha1.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)

            Dim myDataSet As New DataSet
            Try
                DBCommand.Fill(myDataSet, "ComprobantesDetalles")

            Catch e As Exception
                MsgBox(e.Message)
            End Try

            DBConn.Close()

            Return CBool(myDataSet.Tables(0).Rows(0).Item("Aprobado"))

        End Function

        Public Shared Function Aprobar(ByVal CompNo As String, ByVal Mes As String, _
                                 ByVal Periodo As String, ByVal Aprobado As Boolean) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_FacturasAprobar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCompNo As New SqlParameter("@Comp_No", SqlDbType.Int)
            pCompNo.Value = CompNo
            DBCommand.SelectCommand.Parameters.Add(pCompNo)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _pMes As New SqlParameter("@Mes", SqlDbType.Int)
            _pMes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_pMes)

            Dim pPeriodo As New SqlParameter("@Periodo", SqlDbType.Int)
            pPeriodo.Value = Periodo
            DBCommand.SelectCommand.Parameters.Add(pPeriodo)

            Dim pAprobado As New SqlParameter("@Aprobado", SqlDbType.Bit)
            pAprobado.Value = Aprobado
            DBCommand.SelectCommand.Parameters.Add(pAprobado)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function
        Public Shared Function DeleteComprobanteDetalles(ByVal CdetID As Integer) As String

            ' Create Instance of Connection and Command Object
            'Dim conexion As New VB.SysContab.Rutinas()
            Dim cmd As New SqlCommand("_ComprobantesDetallesDeletexCdetID", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim pCdetID As New SqlParameter("@CdetID", SqlDbType.Int)
            pCdetID.Value = CdetID
            cmd.Parameters.Add(pCdetID)


            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()


        End Function

        Public Shared Function BorrarDetalleComprobante(Comp_No As Integer, Per_Id As Integer, Mes As Integer)

            Return Guardar_Con_Transaccion("_ComprobantesDetallesDeleteAll", Comp_No, Per_Id, Mes, EmpresaActual)

        End Function

        'Public Shared Function GetComprobanteAprobadoxFact(ByVal Factura As String, ByVal Proveedor As String, ByVal Fecha As DateTime) As Boolean


        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_ComprobantesAprobadoxFactura", DBConn)

        '    ' Mark the Command as a SPROC
        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    ' Add Parameters to SPROC
        '    Dim ComprNO As New SqlParameter("@Factura", SqlDbType.NVarChar)
        '    ComprNO.Value = Factura
        '    DBCommand.SelectCommand.Parameters.Add(ComprNO)

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    DBCommand.SelectCommand.Parameters.Add(pEmpresa)

        '    Dim _PerID As New SqlParameter("@Proveedor", SqlDbType.Int)
        '    _PerID.Value = Proveedor
        '    DBCommand.SelectCommand.Parameters.Add(_PerID)

        '    Dim _Fecha1 As New SqlParameter("@Fecha", SqlDbType.DateTime)
        '    _Fecha1.Value = Fecha
        '    DBCommand.SelectCommand.Parameters.Add(_Fecha1)

        '    Dim myDataSet As New DataSet
        '    Try
        '        DBCommand.Fill(myDataSet, "ComprobantesDetalles")

        '    Catch e As Exception
        '        MsgBox(e.Message)
        '    End Try

        '    DBConn.Close()

        '    Return CBool(myDataSet.Tables(0).Rows(0).Item("Aprobado"))

        'End Function

        'Public Shared Function GetComprobanteAprobado(ByVal CompNo As String, ByVal PerID As String, ByVal Fecha As DateTime) As Boolean


        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_ComprobantesAprobado", DBConn)

        '    ' Mark the Command as a SPROC
        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    ' Add Parameters to SPROC
        '    Dim ComprNO As New SqlParameter("@ComprNO", SqlDbType.Int)
        '    ComprNO.Value = CompNo
        '    DBCommand.SelectCommand.Parameters.Add(ComprNO)

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    DBCommand.SelectCommand.Parameters.Add(pEmpresa)

        '    Dim _PerID As New SqlParameter("@PerID", SqlDbType.Int)
        '    _PerID.Value = PerID
        '    DBCommand.SelectCommand.Parameters.Add(_PerID)

        '    Dim _Fecha1 As New SqlParameter("@Fecha", SqlDbType.DateTime)
        '    _Fecha1.Value = Fecha
        '    DBCommand.SelectCommand.Parameters.Add(_Fecha1)

        '    Dim myDataSet As New DataSet
        '    Try
        '        DBCommand.Fill(myDataSet, "ComprobantesDetalles")

        '    Catch e As Exception
        '        MsgBox(e.Message)
        '    End Try

        '    DBConn.Close()

        '    Return CBool(myDataSet.Tables(0).Rows(0).Item("Aprobado"))

        'End Function
        Public Shared Sub AddFacturaFecha(ByVal Proveedor As String,
                                             ByVal Factura As String, ByVal FechaRecepcion As DateTime)

            ' Create Instance of Connection and Command Object
            'Dim conexion As New VB.SysContab.Rutinas()
            Dim cmd As New SqlCommand("_FacturaFechaAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar, 50)
            _Proveedor.Value = Proveedor
            cmd.Parameters.Add(_Proveedor)

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            _Factura.Value = Factura
            cmd.Parameters.Add(_Factura)

            Dim _FechaRecepcion As New SqlParameter("@FechaRecepcion", SqlDbType.DateTime)
            _FechaRecepcion.Value = FechaRecepcion
            cmd.Parameters.Add(_FechaRecepcion)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Sub


        Public Shared Function ComprobanteDetallesUpdate(ByVal CompDetID As Integer, ByVal cuenta As String,
                              ByVal Importe As Double, ByVal concepto As String, ByVal DC As String,
                             IdProyecto As Integer, IdOrdenCompra As Integer, Factura As String,
                                                         Optional Retencion As String = "")

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim cmd As New SqlCommand("_ComprobantesDetallesUpdate", DBConnFacturas)

            'Dim NoComp As Double = GetNoComprobante()

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim Param As New SqlParameter("@CompDetID", SqlDbType.Int)
            Param.Value = CompDetID
            cmd.Parameters.Add(Param)

            Dim _cuenta As New SqlParameter("@cuenta", SqlDbType.NVarChar)
            _cuenta.Value = cuenta
            cmd.Parameters.Add(_cuenta)

            Dim _Importe As New SqlParameter("@Importe", SqlDbType.Float)
            _Importe.Value = Importe
            cmd.Parameters.Add(_Importe)

            Dim _concepto As New SqlParameter("@concepto", SqlDbType.NVarChar)
            _concepto.Value = concepto
            cmd.Parameters.Add(_concepto)

            Dim _DC As New SqlParameter("@DC", SqlDbType.NVarChar)
            _DC.Value = DC
            cmd.Parameters.Add(_DC)

            cmd.Parameters.AddWithValue("@IdProyecto", IdProyecto)
            cmd.Parameters.AddWithValue("@IdOrdenCompra", IdOrdenCompra)
            cmd.Parameters.AddWithValue("@Factura", Factura)
            cmd.Parameters.AddWithValue("@Retencion", Retencion)


            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()


        End Function


        Public Shared Function ListResumen(ByVal Memoria As Boolean, ByVal NEmpresa As String, ByVal Periodo As String, ByVal Fecha1 As String, ByVal Fecha2 As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("[_ComprobantesList_Resumen]", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Periodo As New SqlParameter("@PerID", SqlDbType.NVarChar)
            _Periodo.Value = Periodo
            DBCommand.SelectCommand.Parameters.Add(_Periodo)

            Dim _Fecha1 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            _Fecha1.Value = Fecha1
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)

            Dim _Fecha2 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            _Fecha2.Value = Fecha2
            DBCommand.SelectCommand.Parameters.Add(_Fecha2)

            Dim _Memoria As New SqlParameter("@Memoria", SqlDbType.Bit)
            _Memoria.Value = Memoria
            DBCommand.SelectCommand.Parameters.Add(_Memoria)

            Dim _NEmpresa As New SqlParameter("@NEmpresa", SqlDbType.NVarChar)
            _NEmpresa.Value = NEmpresa
            DBCommand.SelectCommand.Parameters.Add(_NEmpresa)


            DBCommand.Fill(dsFicha, "Comprobantes")

            DBConn.Close()

            Return dsFicha

        End Function


        'Public Shared Function GeneraComprobanteFacturaDirecto(ByVal CuentaCaja As String, ByVal DebeCaja As String, _
        '                     ByVal ConceptoCaja As String, _
        '                     ByVal CuentaIngr As String, ByVal HaberIngr As String, _
        '                     ByVal ConceptoIngr As String, _
        '                     ByVal CuentaIVA As String, ByVal HaberIVa As String, _
        '                     ByVal ConceptoIVA As String, _
        '                     ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
        '                     ByVal TipoComProbante As String, ByVal Fecha As String, ByVal FacturaNo As String, _
        '                     ByVal CuentaIR As String, ByVal MontoIR As String, ByVal ConceptoIR As String, ByVal Tipo As String)

        '    Dim Catalogo As New CatalogoDB
        '    Dim CompNo As String

        '    'Dim conexion As New VB.SysContab.Rutinas()
        '    'DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        '    'DBConnFacturas.Open()
        '    'transaccionFacturas = DBConnFacturas.BeginTransaction()

        '    'Try
        '    CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(Fecha), Fecha, 0, "", False, 0, "", 0, FacturaNo, VB.SysContab.Rutinas.Fecha, 0, False)

        '    AddComprobanteDetalles(CompNo, CuentaCaja, ConceptoCaja, DebeCaja, 0, TipoComProbante, "D", FacturaNo, 0, Fecha, 1)

        '    If Tipo = 1 Then 'Si es de contado
        '        If CDbl(MontoIR) > 0 Then
        '            AddComprobanteDetalles(CompNo, CuentaIR, ConceptoIR, MontoIR, 0, TipoComProbante, "D", FacturaNo, 0, Fecha, 1)
        '        End If
        '    End If

        '    '' Para Ingresos
        '    AddComprobanteDetalles(CompNo, CuentaIngr, ConceptoIngr, HaberIngr, 0, TipoComProbante, "C", FacturaNo, 0, Fecha, 1)
        '    '' Para IVA
        '    If CDbl(HaberIVa) > 0 Then
        '        AddComprobanteDetalles(CompNo, CuentaIVA, ConceptoIVA, HaberIVa, 0, TipoComProbante, "C", FacturaNo, 0, Fecha, 1)
        '    End If
        '    ContabilizarFactura(FacturaNo)



        '    'transaccionFacturas.Commit()

        '    'Return True

        '    'Catch Mensaje As Exception
        '    'MsgBox(Mensaje.Message)
        '    'transaccionFacturas.Rollback()

        '    'Return False

        '    'End Try

        '    'DBConnFacturas.Close()

        'End Function
        'Public Shared Function GeneraComprobanteFacturaDirecto(ByVal CuentaCaja As String, ByVal DebeCaja As String, _
        '                          ByVal ConceptoCaja As String, _
        '                          ByVal CuentaIngr As String, ByVal HaberIngr As String, _
        '                          ByVal ConceptoIngr As String, _
        '                          ByVal CuentaIVA As String, ByVal HaberIVa As String, _
        '                          ByVal ConceptoIVA As String, _
        '                          ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
        '                          ByVal TipoComProbante As String, ByVal Fecha As String, ByVal FacturaNo As String, _
        '                          ByVal CuentaIR As String, ByVal MontoIR As String, ByVal ConceptoIR As String, _
        '                          ByVal Tipo As String, ByVal ServCont As Boolean, _
        '                          ByVal CuentaIR_Alcaldia As String, ByVal MontoIR_Alcaldia As String, _
        '                          ByVal ConceptoIR_Alcaldia As String, _
        '                    Optional ByRef VDebitos As Double = 0, Optional ByRef VCreditos As Double = 0) As String

        '    Dim Catalogo As New CatalogoDB
        '    Dim CompNo As String

        '    CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(Fecha), Fecha, 0, "", False, 0, "", 0, FacturaNo, VB.SysContab.Rutinas.Fecha, 0, False)

        '    AddComprobanteDetalles(CompNo, CuentaCaja, ConceptoCaja, DebeCaja, 0, TipoComProbante, "D", FacturaNo, 0, Fecha, 1)
        '    VDebitos += DebeCaja

        '    If Tipo = 1 Then 'Si es de contado
        '        If CDbl(MontoIR) > 0 Then
        '            AddComprobanteDetalles(CompNo, CuentaIR, ConceptoIR, MontoIR, 0, TipoComProbante, "D", FacturaNo, 0, Fecha, 1)
        '            VDebitos += MontoIR
        '        End If

        '        If CDbl(MontoIR_Alcaldia) > 0 Then
        '            AddComprobanteDetalles(CompNo, CuentaIR_Alcaldia, ConceptoIR_Alcaldia, MontoIR_Alcaldia, 0, TipoComProbante, "D", FacturaNo, 0, Fecha, 1)
        '            VDebitos += MontoIR_Alcaldia
        '        End If
        '    End If


        '    If ServCont = False Then
        '        '' Para Ingresos
        '        AddComprobanteDetalles(CompNo, CuentaIngr, ConceptoIngr, HaberIngr, 0, TipoComProbante, "C", FacturaNo, 0, Fecha, 1)
        '        VCreditos += HaberIngr
        '    End If


        '    '' Para IVA
        '    If CDbl(HaberIVa) > 0 Then
        '        AddComprobanteDetalles(CompNo, CuentaIVA, ConceptoIVA, HaberIVa, 0, TipoComProbante, "C", FacturaNo, 0, Fecha, 1)
        '        VCreditos += HaberIVa
        '    End If
        '    ContabilizarFactura(FacturaNo)


        '    Return CompNo


        'End Function
        Public Function CajaChicaPagosList(ByVal Cuenta As String, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Pagara As String, ByVal Factura As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_CajaChicaPagosList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Cuenta
            DBCommand.SelectCommand.Parameters.Add(_Cuenta)

            Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            _Fecha1.Value = Fecha1
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)

            Dim _Fecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            _Fecha2.Value = Fecha2
            DBCommand.SelectCommand.Parameters.Add(_Fecha2)

            Dim _Pagara As New SqlParameter("@Pagara", SqlDbType.NVarChar)
            _Pagara.Value = Pagara
            DBCommand.SelectCommand.Parameters.Add(_Pagara)

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            _Factura.Value = Factura
            DBCommand.SelectCommand.Parameters.Add(_Factura)

            DBCommand.Fill(dsFicha, "Comprobantes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function OtrosIngresosList(ByVal Cuenta As String, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Pagara As String, ByVal Factura As String, ByVal Cheque As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_OtrosIngresosList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Cuenta
            DBCommand.SelectCommand.Parameters.Add(_Cuenta)

            Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            _Fecha1.Value = Fecha1
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)

            Dim _Fecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            _Fecha2.Value = Fecha2
            DBCommand.SelectCommand.Parameters.Add(_Fecha2)

            Dim _Pagara As New SqlParameter("@Pagara", SqlDbType.NVarChar)
            _Pagara.Value = Pagara
            DBCommand.SelectCommand.Parameters.Add(_Pagara)

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            _Factura.Value = Factura
            DBCommand.SelectCommand.Parameters.Add(_Factura)

            Dim _Cheque As New SqlParameter("@Cheque", SqlDbType.NVarChar)
            _Cheque.Value = Cheque
            DBCommand.SelectCommand.Parameters.Add(_Cheque)

            DBCommand.Fill(dsFicha, "Comprobantes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function FacturaComprasTransaccionesAdd(ByVal TipoTransaccion As Integer, ByVal Comp_No As String, ByVal PerID As String, ByVal Fecha As String, ByVal Mes As Integer, ByVal Year As Integer)
            Dim cmd As New SqlCommand("_FacturasComprasTransaccionesAdd", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            cmd.Parameters.Add(_Empresa)

            Dim _TipoTransaccion As New SqlParameter("@TipoTransaccion", SqlDbType.Int)
            _TipoTransaccion.Value = TipoTransaccion '@TipoTransaccion
            cmd.Parameters.Add(_TipoTransaccion)

            Dim _Comp_No As New SqlParameter("@Comp_No", SqlDbType.Decimal)
            _Comp_No.Value = Comp_No
            cmd.Parameters.Add(_Comp_No)

            Dim _PerID As New SqlParameter("@Per_ID", SqlDbType.Int)
            _PerID.Value = PerID
            cmd.Parameters.Add(_PerID)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            cmd.Parameters.Add(_Mes)

            Dim _Year As New SqlParameter("@Year", SqlDbType.Int)
            _Year.Value = Year
            cmd.Parameters.Add(_Year)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Shared Function FacturaVentasTransaccionesAdd(ByVal TipoTransaccion As Integer, ByVal Comp_No As String, ByVal PerID As String, ByVal Fecha As String, ByVal Mes As Integer, ByVal Year As Integer)
            Dim cmd As New SqlCommand("_FacturasVentasTransaccionesAdd", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            _Empresa.Value = EmpresaActual
            cmd.Parameters.Add(_Empresa)

            Dim _TipoTransaccion As New SqlParameter("@TipoTransaccion", SqlDbType.Int)
            _TipoTransaccion.Value = TipoTransaccion '@TipoTransaccion
            cmd.Parameters.Add(_TipoTransaccion)

            Dim _Comp_No As New SqlParameter("@Comp_No", SqlDbType.Decimal)
            _Comp_No.Value = Comp_No
            cmd.Parameters.Add(_Comp_No)

            Dim _PerID As New SqlParameter("@Per_ID", SqlDbType.Int)
            _PerID.Value = PerID
            cmd.Parameters.Add(_PerID)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            cmd.Parameters.Add(_Mes)

            Dim _Year As New SqlParameter("@Year", SqlDbType.Int)
            _Year.Value = Year
            cmd.Parameters.Add(_Year)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function ComprobanteBuscarXFecha(ByVal Fecha As String) As DataSet
            'Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBCommand = New SqlDataAdapter("_ComprobanteBuscarXFecha", DBConnFacturas)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pFecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)

            pFecha.Value = Fecha
            pEmpresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(pFecha)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            'cmd.Connection = DBConnFacturas
            'cmd.Transaction = transaccionFacturas
            'cmd.ExecuteNonQuery()

            DBCommand.SelectCommand.Connection = DBConnFacturas
            DBCommand.SelectCommand.Transaction = transaccionFacturas
            DBCommand.Fill(dsFicha, "Comp")

            'DBConn.Close()


            Return dsFicha

        End Function

        Public Function GetCriteriosDebitoCredito(ByVal Tipo As Integer) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComprobanteDebitoCreditoGetCriterios", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pTipo As New SqlParameter("@Tipo", SqlDbType.Int)
            pTipo.Value = Tipo
            DBCommand.SelectCommand.Parameters.Add(pTipo)

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Shared Function PagosFactura(ByVal Comprobante As String, ByVal Periodo As String, _
            ByVal Fecha As String, ByVal Monto As String, ByVal Comprobante1 As String, _
            ByVal Periodo1 As String, ByVal Fecha1 As String, ByVal Factura As String, _
            ByVal Proveedor As String, ByVal Codigo As String) As String

            Dim conexion As New VB.SysContab.Rutinas
            Dim cmd As New SqlCommand("_PagosFactura", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Comprobante As New SqlParameter("@ComprNO", SqlDbType.NVarChar, 50)
            _Comprobante.Value = Comprobante
            cmd.Parameters.Add(_Comprobante)

            Dim _Periodo As New SqlParameter("@PerID", SqlDbType.Float)
            _Periodo.Value = Periodo
            cmd.Parameters.Add(_Periodo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim _Monto As New SqlParameter("@Monto", SqlDbType.Float)
            _Monto.Value = Monto
            cmd.Parameters.Add(_Monto)

            Dim _Comprobante1 As New SqlParameter("@ComprNO1", SqlDbType.NVarChar, 50)
            _Comprobante1.Value = Comprobante1
            cmd.Parameters.Add(_Comprobante1)

            Dim _Periodo1 As New SqlParameter("@PerID1", SqlDbType.Float)
            _Periodo1.Value = Periodo1
            cmd.Parameters.Add(_Periodo1)

            Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
            _Fecha1.Value = Fecha1
            cmd.Parameters.Add(_Fecha1)

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            _Factura.Value = Factura
            cmd.Parameters.Add(_Factura)

            Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            _Proveedor.Value = Proveedor
            cmd.Parameters.Add(_Proveedor)

            Dim _Codigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            _Codigo.Value = Codigo
            cmd.Parameters.Add(_Codigo)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            'Return NoComp

        End Function

        Public Function ProveedorUltimoComp(ByVal Proveedor As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ProveedorUltimoComp", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.Float)
            _Proveedor.Value = Proveedor
            DBCommand.SelectCommand.Parameters.Add(_Proveedor)

            DBCommand.Fill(dsFicha, "Comprobantes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ComprobantesOrdenar(ByVal Periodo As String, ByVal Fecha As String)
            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim cmd As New SqlCommand("_ComprobantesOrdenar", DBConnFacturas)

            'Dim NoComp As Double = GetNoComprobante()

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Periodo As New SqlParameter("@Periodo", SqlDbType.Int)
            _Periodo.Value = Periodo
            cmd.Parameters.Add(_Periodo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        Public Function ComprobantesOrdenarUpdate(ByVal CompNo As String, ByVal Periodo As String, ByVal Fecha As String, ByVal i As Integer)
            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim cmd As New SqlCommand("_ComprobantesOrdenarUpdate", DBConnFacturas)

            'Dim NoComp As Double = GetNoComprobante()

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _CompNo As New SqlParameter("@CompNo", SqlDbType.Int)
            _CompNo.Value = CompNo
            cmd.Parameters.Add(_CompNo)

            Dim _Periodo As New SqlParameter("@Periodo", SqlDbType.Int)
            _Periodo.Value = Periodo
            cmd.Parameters.Add(_Periodo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim _i As New SqlParameter("@i", SqlDbType.Int)
            _i.Value = i
            cmd.Parameters.Add(_i)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas

            cmd.ExecuteNonQuery()

        End Function


        Public Function ComprobantesOrdenarXFecha(ByVal Periodo As String, ByVal Fecha As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComprobantesOrdenarXFecha", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Periodo As New SqlParameter("@Periodo", SqlDbType.Int)
            _Periodo.Value = Periodo
            DBCommand.SelectCommand.Parameters.Add(_Periodo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha

            DBCommand.SelectCommand.Parameters.Add(_Fecha)
            DBCommand.Fill(dsFicha, "Comprobantes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function TiposComprobantesCheques(ByVal cheque As Boolean) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("[_TipoComprobantesChequeSN]", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pcheque As New SqlParameter("@cheque", SqlDbType.Bit)
            pcheque.Value = cheque
            DBCommand.SelectCommand.Parameters.Add(pcheque)

            DBCommand.Fill(dsFicha, "TipoComprobantes")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Function TiposComprobantesCheques() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoComprobantesCheque", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.Fill(dsFicha, "TipoComprobantes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function ChequesList(ByVal Cuenta As String, ByVal Fecha1 As String, ByVal Fecha2 As String, ByVal Pagara As String, ByVal Cheque As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ChequesList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Cuenta
            DBCommand.SelectCommand.Parameters.Add(_Cuenta)

            Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            _Fecha1.Value = Fecha1
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)

            Dim _Fecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            _Fecha2.Value = Fecha2
            DBCommand.SelectCommand.Parameters.Add(_Fecha2)

            Dim _Pagara As New SqlParameter("@Pagara", SqlDbType.NVarChar)
            _Pagara.Value = Pagara
            DBCommand.SelectCommand.Parameters.Add(_Pagara)

            Dim _Cheque As New SqlParameter("@Cheque", SqlDbType.NVarChar)
            _Cheque.Value = Cheque
            DBCommand.SelectCommand.Parameters.Add(_Cheque)

            'Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            '_Tipo.Value = Tipo
            'DBCommand.SelectCommand.Parameters.Add(_Tipo)

            'Dim _Numero As New SqlParameter("@Numero", SqlDbType.NVarChar)
            '_Numero.Value = Numero
            'DBCommand.SelectCommand.Parameters.Add(_Numero)

            'Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            '_Cuenta.Value = Cuenta
            'DBCommand.SelectCommand.Parameters.Add(_Cuenta)

            'Dim _Meses As New SqlParameter("@Meses", SqlDbType.NVarChar)
            '_Meses.Value = Meses
            'DBCommand.SelectCommand.Parameters.Add(_Meses)

            'Dim _Anno As New SqlParameter("@Anno", SqlDbType.NVarChar)
            '_Anno.Value = Anno
            'DBCommand.SelectCommand.Parameters.Add(_Anno)

            'Dim _Inicial As New SqlParameter("@Inicial", SqlDbType.NVarChar)
            '_Inicial.Value = Inicial
            'DBCommand.SelectCommand.Parameters.Add(_Inicial)

            'Dim _Final As New SqlParameter("@Final", SqlDbType.NVarChar)
            '_Final.Value = Final
            'DBCommand.SelectCommand.Parameters.Add(_Final)

            'Dim _PerID As New SqlParameter("@PerID", SqlDbType.NVarChar)
            '_PerID.Value = PerID
            'DBCommand.SelectCommand.Parameters.Add(_PerID)

            DBCommand.Fill(dsFicha, "Comprobantes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Function ChequesCuentaBanco(ByVal Comprobante As String, ByVal Periodo As String, ByVal Fecha As String) As String

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim DBConn As SqlConnection
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            DBConn.Open()

            Dim cmd As New SqlCommand("_ChequesCuentaBanco", DBConn)

            '            Dim NoComp As String = GetNoComprobante()

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Comprobante As New SqlParameter("@ComprNO", SqlDbType.NVarChar, 50)
            _Comprobante.Value = Comprobante
            cmd.Parameters.Add(_Comprobante)

            Dim _Periodo As New SqlParameter("@PerID", SqlDbType.Float)
            _Periodo.Value = Periodo
            cmd.Parameters.Add(_Periodo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar, 64)
            _Cuenta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(_Cuenta)

            cmd.Connection = DBConn
            'cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
            DBConn.Close()

            Return _Cuenta.Value

        End Function

        'Public Shared Function AddComprobanteCierre(ByVal TipoComp As Integer, _
        '                     ByVal TasaCambio As Double, ByVal concepto As String, _
        '                     ByVal TMoneda As String, ByVal PerID As String, _
        '                     ByVal compFecha As String, ByVal Deposito As String, _
        '                      ByVal ChequeNombre As String, _
        '                     ByVal Transferencia As Boolean, ByVal Comp As String) As String

        '    ' Create Instance of Connection and Command Object
        '    Dim conexion As New VB.SysContab.Rutinas
        '    Dim cmd As New SqlCommand("_ComprobantesAdd", DBConnFacturas)

        '    Dim NoComp As Double = GetNoComprobante(compFecha, PerID)

        '    ' Mark the Command as a SPROC
        '    cmd.CommandType = CommandType.StoredProcedure

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    cmd.Parameters.Add(pEmpresa)

        '    Dim _TipoComp As New SqlParameter("@TipoComp", SqlDbType.Int)
        '    _TipoComp.Value = TipoComp
        '    cmd.Parameters.Add(_TipoComp)

        '    Dim _TasaCambio As New SqlParameter("@TasaCambio", SqlDbType.Decimal)
        '    _TasaCambio.Value = 1.0  'TasaCambio
        '    cmd.Parameters.Add(_TasaCambio)

        '    Dim _CompNo As New SqlParameter("@CompNo", SqlDbType.Int)
        '    _CompNo.Value = NoComp
        '    cmd.Parameters.Add(_CompNo)

        '    Dim _Moneda As New SqlParameter("@Moneda", SqlDbType.NVarChar, 20)
        '    _Moneda.Value = TMoneda
        '    cmd.Parameters.Add(_Moneda)

        '    Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
        '    _Fecha.Value = compFecha
        '    cmd.Parameters.Add(_Fecha)

        '    Dim _PerID As New SqlParameter("@PerID", SqlDbType.NVarChar, 20)
        '    _PerID.Value = PerID
        '    cmd.Parameters.Add(_PerID)

        '    Dim _Deposito As New SqlParameter("@Deposito", SqlDbType.NVarChar, 50)
        '    _Deposito.Value = Deposito
        '    cmd.Parameters.Add(_Deposito)

        '    Dim _CompConcepto As New SqlParameter("@CompConcepto", SqlDbType.NVarChar, 1500)
        '    _CompConcepto.Value = concepto
        '    cmd.Parameters.Add(_CompConcepto)

        '    Dim _ChequeNombre As New SqlParameter("@ChequeNombre", SqlDbType.NVarChar, 50)
        '    _ChequeNombre.Value = ChequeNombre
        '    cmd.Parameters.Add(_ChequeNombre)

        '    Dim _comp As New SqlParameter("@comp", SqlDbType.Int, 4)
        '    _comp.Value = Comp
        '    cmd.Parameters.Add(_comp)

        '    Dim _Transferencia As New SqlParameter("@Transferencia", SqlDbType.Bit)
        '    _Transferencia.Value = Transferencia
        '    cmd.Parameters.Add(_Transferencia)

        '    cmd.Connection = DBConnFacturas
        '    cmd.Transaction = transaccionFacturas
        '    cmd.ExecuteNonQuery()

        '    Return NoComp

        'End Function

        Public Shared Function GetNoComprobante(ByVal Fecha As String, ByVal Periodo As Integer) As Double

            ' Create Instance of Connection and Command Object
            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            Dim cmd As SqlCommand = New SqlCommand("_ComprobanteGetNo", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Periodo As New SqlParameter("@Periodo", SqlDbType.Int)
            _Periodo.Value = Periodo
            cmd.Parameters.Add(_Periodo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim parameterTotalCost As SqlParameter = New SqlParameter("@Comprobante", SqlDbType.Float, 8)
            parameterTotalCost.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterTotalCost)

            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()


            ' Return the Total
            If parameterTotalCost.Value.ToString() <> "" Then
                Return CType(parameterTotalCost.Value, Double)
            Else
                Return 1
            End If

        End Function

        'Public Function GetComprobanteAnuladoDetails(ByVal CompNo As String, ByVal PerID As String, ByVal Fecha1 As String) As ComprobantesDetails

        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_ComprobantesAnuladosDetails", DBConn)

        '    ' Mark the Command as a SPROC
        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    ' Add Parameters to SPROC
        '    Dim ComprNO As New SqlParameter("@ComprNO", SqlDbType.Int, 4)
        '    ComprNO.Value = CompNo
        '    DBCommand.SelectCommand.Parameters.Add(ComprNO)

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    DBCommand.SelectCommand.Parameters.Add(pEmpresa)

        '    Dim _PerID As New SqlParameter("@PerID", SqlDbType.Int)
        '    _PerID.Value = PerID
        '    DBCommand.SelectCommand.Parameters.Add(_PerID)

        '    Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
        '    _Fecha1.Value = Fecha1
        '    DBCommand.SelectCommand.Parameters.Add(_Fecha1)

        '    Dim Fecha As New SqlParameter("@Fecha", SqlDbType.NVarChar, 60)
        '    Fecha.Direction = ParameterDirection.Output
        '    DBCommand.SelectCommand.Parameters.Add(Fecha)

        '    Dim Numero As New SqlParameter("@Numero", SqlDbType.NVarChar, 60)
        '    Numero.Direction = ParameterDirection.Output
        '    DBCommand.SelectCommand.Parameters.Add(Numero)

        '    Dim Tipo As New SqlParameter("@Tipo", SqlDbType.NVarChar, 60)
        '    Tipo.Direction = ParameterDirection.Output
        '    DBCommand.SelectCommand.Parameters.Add(Tipo)

        '    Dim Tipo1 As New SqlParameter("@Tipo1", SqlDbType.NVarChar, 60)
        '    Tipo1.Direction = ParameterDirection.Output
        '    DBCommand.SelectCommand.Parameters.Add(Tipo1)

        '    Dim Descripcion As New SqlParameter("@Descripcion", SqlDbType.NVarChar, 60)
        '    Descripcion.Direction = ParameterDirection.Output
        '    DBCommand.SelectCommand.Parameters.Add(Descripcion)

        '    Dim TasaCambio As New SqlParameter("@TasaCambio", SqlDbType.NVarChar, 50)
        '    TasaCambio.Direction = ParameterDirection.Output
        '    DBCommand.SelectCommand.Parameters.Add(TasaCambio)

        '    Dim Concepto As New SqlParameter("@Concepto", SqlDbType.NVarChar, 1500)
        '    Concepto.Direction = ParameterDirection.Output
        '    DBCommand.SelectCommand.Parameters.Add(Concepto)

        '    Dim Cheque As New SqlParameter("@Cheque", SqlDbType.NVarChar, 1500)
        '    Cheque.Direction = ParameterDirection.Output
        '    DBCommand.SelectCommand.Parameters.Add(Cheque)

        '    Dim Moneda As New SqlParameter("@Moneda", SqlDbType.NVarChar, 1500)
        '    Moneda.Direction = ParameterDirection.Output
        '    DBCommand.SelectCommand.Parameters.Add(Moneda)

        '    Dim Factura As New SqlParameter("@Factura", SqlDbType.NVarChar, 1500)
        '    Factura.Direction = ParameterDirection.Output
        '    DBCommand.SelectCommand.Parameters.Add(Factura)

        '    Dim Recibo As New SqlParameter("@Recibo", SqlDbType.NVarChar, 1500)
        '    Recibo.Direction = ParameterDirection.Output
        '    DBCommand.SelectCommand.Parameters.Add(Recibo)

        '    Dim ChequeNombre As New SqlParameter("@ChequeNombre", SqlDbType.NVarChar, 1500)
        '    ChequeNombre.Direction = ParameterDirection.Output
        '    DBCommand.SelectCommand.Parameters.Add(ChequeNombre)

        '    ' Create and Fill the DataSet
        '    Dim myDataSet As New DataSet
        '    Try
        '        DBCommand.Fill(myDataSet, "ComprobantesDetalles")

        '    Catch e As Exception
        '        MsgBox(e.Message)

        '    End Try

        '    DBConn.Close()

        '    ' ship date is null if order doesn't exist, or belongs to a different user
        '    'If Not Fecha.Value Is DBNull.Value Then

        '    Dim myOrderDetails As New ComprobantesDetails

        '    myOrderDetails.Fecha = Fecha.Value.ToString
        '    myOrderDetails.Numero = Numero.Value.ToString
        '    myOrderDetails.Concepto = Concepto.Value.ToString
        '    myOrderDetails.Cheque = Cheque.Value.ToString
        '    myOrderDetails.Descripcion = Descripcion.Value.ToString
        '    myOrderDetails.TasaCambio = TasaCambio.Value.ToString
        '    myOrderDetails.Tipo = Tipo.Value.ToString
        '    myOrderDetails.Tipo1 = Tipo1.Value.ToString
        '    myOrderDetails.Moneda = Moneda.Value.ToString
        '    myOrderDetails.Factura = Factura.Value.ToString
        '    myOrderDetails.Recibo = Recibo.Value.ToString
        '    myOrderDetails.ChequeNombre = ChequeNombre.Value.ToString
        '    myOrderDetails.Detalles = myDataSet

        '    ' Return the DataSet
        '    Return myOrderDetails
        '    'Else
        '    '                Return Nothing
        '    'End If
        'End Function

        Public Shared Function ComprobanteAnularBuscar(ByVal Comprobante As String, ByVal Periodo As String, ByVal Fecha As String) As Integer

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim DBConn As SqlConnection
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            DBConn.Open()

            Dim cmd As New SqlCommand("_ComprobantesAnularBuscar", DBConn)

            '            Dim NoComp As String = GetNoComprobante()

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Comprobante As New SqlParameter("@ComprNO", SqlDbType.NVarChar, 50)
            _Comprobante.Value = Comprobante
            cmd.Parameters.Add(_Comprobante)

            Dim _Periodo As New SqlParameter("@PerID", SqlDbType.Float)
            _Periodo.Value = Periodo
            cmd.Parameters.Add(_Periodo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim _Reg As SqlParameter = New SqlParameter("@Reg", SqlDbType.Int)
            _Reg.Direction = ParameterDirection.Output
            cmd.Parameters.Add(_Reg)

            cmd.Connection = DBConn
            'cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
            DBConn.Close()

            Return _Reg.Value

        End Function

        Public Shared Function ComprobanteAnularBuscar(ComprobanteID As Integer) As Integer
            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

            Try
                Conn.AddParameter("ComprobanteID", SqlDbType.Int, 5, ParameterDirection.Input, ComprobanteID)
                Conn.AddParameter("Anular", SqlDbType.Int, 5, ParameterDirection.Output, 0)

                Conn.EjecutarComando("JAR_ComprobantesAnularBuscar")

                Return Conn.GetParameter("Anular").Valor
            Catch ex As Exception
                Return 0
            End Try

        End Function

        Public Shared Function ComprobanteAnular(ByVal Comprobante As String, ByVal Periodo As String, ByVal Fecha As String, _
                                                 Optional ByVal Ck As Integer = 0) As String

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas

            Dim cmd As New SqlCommand("_ComprobantesAnular", DBConnFacturas)

            '            Dim NoComp As String = GetNoComprobante()

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Comprobante As New SqlParameter("@ComprNO", SqlDbType.NVarChar, 50)
            _Comprobante.Value = Comprobante
            cmd.Parameters.Add(_Comprobante)

            Dim _Periodo As New SqlParameter("@PerID", SqlDbType.Float)
            _Periodo.Value = Periodo
            cmd.Parameters.Add(_Periodo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim _Ck As New SqlParameter("@Ck", SqlDbType.Int)
            _Ck.Value = Ck
            cmd.Parameters.Add(_Ck)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
            'Return NoComp
        End Function

        Public Shared Function ComprobanteBorrar(ByVal Comprobante As String, ByVal Periodo As String, ByVal Fecha As String) As String

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas

            Dim cmd As New SqlCommand("_ComprobantesBorrar", DBConnFacturas)

            '            Dim NoComp As String = GetNoComprobante()

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Comprobante As New SqlParameter("@ComprNO", SqlDbType.NVarChar, 50)
            _Comprobante.Value = Comprobante
            cmd.Parameters.Add(_Comprobante)

            Dim _Periodo As New SqlParameter("@PerID", SqlDbType.Float)
            _Periodo.Value = Periodo
            cmd.Parameters.Add(_Periodo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            'Return NoComp

        End Function

        Public Shared Function ComprobanteDetalleDelete(ByVal Numero As String, ByVal PerID As String, ByVal Fecha As String)

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim cmd As New SqlCommand("_ComprobantesDetallesDelete", DBConnFacturas)

            'Dim NoComp As Double = GetNoComprobante()

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            'Dim _TipoComp As New SqlParameter("@TipoComp", SqlDbType.Int)
            '_TipoComp.Value = TipoComp
            'cmd.Parameters.Add(_TipoComp)

            Dim _CompNo As New SqlParameter("@CompNo", SqlDbType.Int)
            _CompNo.Value = Numero
            cmd.Parameters.Add(_CompNo)

            Dim _PerID As New SqlParameter("@PerID", SqlDbType.NVarChar, 20)
            _PerID.Value = PerID
            cmd.Parameters.Add(_PerID)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
            'Return NoComp
        End Function

        Public Shared Function ComprobanteUpdate(ByVal Numero As String, ByVal TipoComp As Integer, _
                             ByVal TasaCambio As Double, ByVal concepto As String, _
                             ByVal TMoneda As String, ByVal PerID As String, _
                             ByVal compFecha As String, ByVal Deposito As String, _
                             ByVal Transferencia As Boolean, ByVal Fecha1 As String, ByVal Ruc As String, _
                             ByVal ChequeNombre As String, ByVal Pagara As String, ByVal Factura As String, _
                             ByVal FechaPago As String, ByVal FormaPago As Integer, ByVal Tipo As String, _
                             Optional ByVal Consecutivo As String = "0") As String

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim cmd As New SqlCommand("_ComprobantesUpdate", DBConnFacturas)

            'Dim NoComp As Double = GetNoComprobante()

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _TipoComp As New SqlParameter("@TipoComp", SqlDbType.Int)
            _TipoComp.Value = TipoComp
            cmd.Parameters.Add(_TipoComp)

            Dim _TasaCambio As New SqlParameter("@TasaCambio", SqlDbType.Float)
            _TasaCambio.Value = TasaCambio
            cmd.Parameters.Add(_TasaCambio)

            Dim _CompNo As New SqlParameter("@CompNo", SqlDbType.Int)
            _CompNo.Value = Numero
            cmd.Parameters.Add(_CompNo)

            Dim _Moneda As New SqlParameter("@Moneda", SqlDbType.NVarChar, 20)
            _Moneda.Value = TMoneda
            cmd.Parameters.Add(_Moneda)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = compFecha
            cmd.Parameters.Add(_Fecha)

            Dim _PerID As New SqlParameter("@PerID", SqlDbType.NVarChar, 20)
            _PerID.Value = PerID
            cmd.Parameters.Add(_PerID)

            Dim _Deposito As New SqlParameter("@Deposito", SqlDbType.NVarChar, 50)
            _Deposito.Value = Deposito
            cmd.Parameters.Add(_Deposito)

            Dim _CompConcepto As New SqlParameter("@CompConcepto", SqlDbType.NVarChar, 1500)
            _CompConcepto.Value = concepto
            cmd.Parameters.Add(_CompConcepto)

            Dim _Transferencia As New SqlParameter("@Transferencia", SqlDbType.Bit)
            _Transferencia.Value = Transferencia
            cmd.Parameters.Add(_Transferencia)

            Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
            _Fecha1.Value = Fecha1
            cmd.Parameters.Add(_Fecha1)

            Dim _Ruc As New SqlParameter("@Ruc", SqlDbType.NVarChar)
            _Ruc.Value = Ruc
            cmd.Parameters.Add(_Ruc)

            Dim _ChequeNombre As New SqlParameter("@ChequeNombre", SqlDbType.NVarChar, 100)
            _ChequeNombre.Value = ChequeNombre
            cmd.Parameters.Add(_ChequeNombre)

            Dim _Pagara As New SqlParameter("@Pagara", SqlDbType.NVarChar)
            _Pagara.Value = Pagara
            cmd.Parameters.Add(_Pagara)

            Dim _Comprobante As SqlParameter = New SqlParameter("@Comprobante", SqlDbType.Float, 8)
            _Comprobante.Direction = ParameterDirection.Output
            cmd.Parameters.Add(_Comprobante)


            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            _Factura.Value = Factura
            cmd.Parameters.Add(_Factura)

            Dim _FechaPago As New SqlParameter("@FechaPago", SqlDbType.DateTime)
            _FechaPago.Value = FechaPago
            cmd.Parameters.Add(_FechaPago)

            Dim _FormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)
            _FormaPago.Value = FormaPago
            cmd.Parameters.Add(_FormaPago)

            Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.Int)
            _Tipo.Value = Tipo
            cmd.Parameters.Add(_Tipo)

            Dim _Consecutivo As New SqlParameter("@Consecutivo", SqlDbType.NVarChar)
            _Consecutivo.Value = Consecutivo
            cmd.Parameters.Add(_Consecutivo)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            Return _Comprobante.Value

        End Function

        Public Shared Function ImprimirCombrobante(ByVal CompNo As String, ByVal PerID As String, ByVal Valorletras As String, ByVal Fecha As String, ByVal Monto As Double) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim DBCommand2 As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComprobantesImpreso", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim ComprNO As New SqlParameter("@ComprNO", SqlDbType.Int, 4)
            ComprNO.Value = CompNo
            DBCommand.SelectCommand.Parameters.Add(ComprNO)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _PerID As New SqlParameter("@PerID", SqlDbType.Int)
            _PerID.Value = PerID
            DBCommand.SelectCommand.Parameters.Add(_PerID)

            Dim _Valorletras As New SqlParameter("@Valorletras", SqlDbType.NVarChar, 250)
            _Valorletras.Value = Valorletras
            DBCommand.SelectCommand.Parameters.Add(_Valorletras)

            Dim _Fecha1 As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha1.Value = Fecha
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)

            Dim _Monto As New SqlParameter("@Monto", SqlDbType.Float)
            _Monto.Value = Monto
            DBCommand.SelectCommand.Parameters.Add(_Monto)

            DBCommand.Fill(dsFicha, "_ComprobantesImpreso")
            DBConn.Close()

            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand2 = New SqlDataAdapter("_ComprobantesImpresoDetalle", DBConn)

            DBCommand2.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim ComprNO2 As New SqlParameter("@ComprNO", SqlDbType.Int, 4)
            ComprNO2.Value = CompNo
            DBCommand2.SelectCommand.Parameters.Add(ComprNO2)

            Dim pEmpresa2 As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa2.Value = EmpresaActual
            DBCommand2.SelectCommand.Parameters.Add(pEmpresa2)

            Dim _PerID2 As New SqlParameter("@PerID", SqlDbType.Int)
            _PerID2.Value = PerID
            DBCommand2.SelectCommand.Parameters.Add(_PerID2)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            DBCommand2.SelectCommand.Parameters.Add(_Fecha)


            DBCommand2.Fill(dsFicha, "_ComprobantesImpresoDetalle")
            DBConn.Close()


            Return dsFicha

        End Function

        Public Shared Function IRBuscar(ByVal Factura As String, ByVal Cuenta As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_IrBuscarComprobante", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            _Factura.Value = Factura
            _Cuenta.Value = Cuenta
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Factura)
            DBCommand.SelectCommand.Parameters.Add(_Cuenta)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()

            Return dsFicha

        End Function

        'Public Shared Function GeneraComprobanteReciboTran(ByVal CuentaCaja As String, ByVal MontoCaja As String, ByVal ConceptoCaja As String, _
        '                                                ByVal CuentaIR As String, ByVal MontoIR As String, ByVal ConceptoIR As String, _
        '                                                ByVal CuentaCliente As String, ByVal MontoCliente As String, ByVal ConceptoCliente As String, _
        '                                                ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal Concepto As String, _
        '                                                ByVal TipoComProbante As String, ByVal Fecha As String, ByVal Factura As String, ByVal Recibo As String)


        '    ' Create Instance of Connection and Command Object
        '    Dim Catalogo As New CatalogoDB
        '    Dim CompNo As String


        '    CompNo = AddComprobante(TipoComp, TasaCambio, Concepto, tMoneda, PeriodosDB.Activo(Fecha), Fecha, 0, "", False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, False)

        '    ' Para Caja
        '    'If MontoCaja > 0 Then
        '    AddComprobanteDetalles(CompNo, CuentaCaja, ConceptoCaja, MontoCaja, 0, TipoComProbante, "D", Factura, Recibo, Fecha, 1)
        '    'AddCatalogoTrans(CuentaCaja, MontoCaja, 0, ConceptoCaja)
        '    'Catalogo.ActualizarCuentas(CuentaCaja, MontoCaja, 1)

        '    If MontoIR > 0 Then
        '        'IR
        '        AddComprobanteDetalles(CompNo, CuentaIR, ConceptoIR, MontoIR, 0, TipoComProbante, "D", Factura, Recibo, Fecha, 1)
        '        'AddCatalogoTrans(CuentaIR, MontoIR, 0, ConceptoIR)
        '        'Catalogo.ActualizarCuentas(CuentaIR, MontoIR, 1)
        '    End If

        '    'End If
        '    ''''' Banco
        '    ''''If MontoBanco > 0 Then
        '    ''''    AddComprobanteDetalles(CompNo, CuentaBanco, ConceptoBanco, MontoBanco, 0, TipoComProbante, "D", ReciboNo)
        '    ''''    AddCatalogoTrans(CuentaBanco, MontoBanco, 0, ConceptoBanco)
        '    ''''    Catalogo.ActualizarCuentas(CuentaBanco, MontoBanco, 1)
        '    ''''End If
        '    ' Para Clientes
        '    AddComprobanteDetalles(CompNo, CuentaCliente, ConceptoCliente, MontoCliente, 0, TipoComProbante, "C", Factura, Recibo, Fecha, 1)
        '    'AddCatalogoTrans(CuentaCliente, 0, MontoCliente, ConceptoCliente)
        '    'Catalogo.ActualizarCuentas(CuentaCliente, MontoCliente, 1)
        '    '' Para IVA
        '    'AddComprobanteDetalles(CompNo, CuentaIVA, ConceptoIVA, HaberIVa, 0, TipoComProbante, "C", FacturaNo)
        '    'AddCatalogoTrans(CuentaIVA, 0, HaberIVa, ConceptoIVA)
        '    'Catalogo.ActualizarCuentas(CuentaIVA, HaberIVa, 1)
        '    'ContabilizarFactura(FacturaNo)
        'End Function

        Public Shared Function GeneraComprobanteRecibo(ByVal CuentaCaja As String, ByVal MontoCaja As String, ByVal ConceptoCaja As String,
                        ByVal CuentaIR As String, ByVal MontoIR As String, ByVal ConceptoIR As String,
                        ByVal CuentaCliente As String, ByVal MontoCliente As String, ByVal ConceptoCliente As String,
                        ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal Concepto As String,
                        ByVal TipoComProbante As String, ByVal Fecha As String, ByVal Factura As String,
                        ByVal CuentaMtto As String, ByVal MontoMtto As Double, ByVal DCMtto As String, ByVal Recibo As String,
                        ByVal Monto_IR_Alcaldia As Double, ByVal CuentaIR_Alcaldia As String,
                                                       ByVal ConceptoIR_Alcaldia As String, Serie As String) As Boolean


            Dim CompNo As Integer = 0
            Dim Per_Id As Integer = PeriodosDB.Activo(Fecha)

            'Dim Catalogo As New CatalogoDB
            'Dim conexion As New VB.SysContab.Rutinas

            Try
                CompNo = AddComprobante(TipoComp, TasaCambio, Concepto, tMoneda, Per_Id, Fecha, 0, "",
                                        False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.RECIBO)
                '
                AddComprobanteDetalles(CompNo, CuentaCaja, ConceptoCaja, MontoCaja + MontoMtto, 0, TipoComProbante, "D", Factura, Recibo, Fecha, 1)

                If MontoMtto <> 0 Then
                    AddComprobanteDetalles(CompNo, CuentaMtto, "Mantenimiento de Valor", Math.Abs(MontoMtto), 0, TipoComProbante, DCMtto, Factura, Recibo, Fecha, 1)
                End If
                '
                If MontoIR > 0 Then     '** IR  **
                    AddComprobanteDetalles(CompNo, CuentaIR, ConceptoIR, MontoIR, 0, TipoComProbante, "D", Factura, Recibo, Fecha, 1)
                End If
                '
                If Monto_IR_Alcaldia > 0 Then   '** IR alcaldia **
                    AddComprobanteDetalles(CompNo, CuentaIR_Alcaldia, ConceptoIR_Alcaldia, Monto_IR_Alcaldia, 0, TipoComProbante, "D", Factura, Recibo, Fecha, 1)
                End If
                '
                AddComprobanteDetalles(CompNo, CuentaCliente, ConceptoCliente, MontoCliente, 0, TipoComProbante, "C", Factura, Recibo, Fecha, 1)
                '
                'GuardaDatosTrans("UPDATE COBROS SET Contabilizado = 1 WHERE RECIBO = '" & Recibo & "' AND EMPRESA = " & EmpresaActual)
                Guardar_Con_Transaccion("sp_upd_COBROS_Contabilizar",
                                        Recibo,
                                        CompNo,
                                        Per_Id,
                                        CDate(Fecha).Month,
                                        EmpresaActual,
                                        Serie)

                Return True
            Catch Mensaje As Exception

                XtraMsg(Mensaje.Message, MessageBoxIcon.Error)
                Return False
            End Try


        End Function


        Public Shared Function SaldoCuentaAdd(ByVal Cuenta As String, ByVal Saldo As String, ByVal Tipo As String, ByVal Fecha As String)

            Dim cmd As SqlCommand = New SqlCommand("_SaldoCuentaAdd", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure

            Dim _Periodo As SqlParameter = New SqlParameter("@PerID", SqlDbType.Int)
            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim _Saldo As SqlParameter = New SqlParameter("@Saldo", SqlDbType.NVarChar)
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.Int)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Periodo.Value = VB.SysContab.PeriodosDB.Activo(Fecha)
            _Cuenta.Value = Cuenta
            _Saldo.Value = Saldo
            _Tipo.Value = Tipo
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Periodo)
            cmd.Parameters.Add(_Cuenta)
            cmd.Parameters.Add(_Saldo)
            cmd.Parameters.Add(_Tipo)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function

        Public Shared Function SaldoCuenta(ByVal Cuenta As String, ByVal fecha As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_SaldoCuenta", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            Dim _PerID As New SqlParameter("@PerID", SqlDbType.Int)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            _Cuenta.Value = Cuenta
            _PerID.Value = VB.SysContab.PeriodosDB.Activo(fecha)
            _Empresa.Value = EmpresaActual

            DBCommand.SelectCommand.Parameters.Add(_Cuenta)
            DBCommand.SelectCommand.Parameters.Add(_PerID)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Tabla")

            DBConn.Close()

            Return dsFicha

        End Function

        'Public Shared Function SaldoCuenta(ByVal Cuenta As String) As DataSet

        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
        '    Dim cmd As SqlCommand = New SqlCommand("_SaldoCuenta", DBConnFacturas)

        '    ' Mark the Command as a SPROC
        '    cmd.CommandType = CommandType.StoredProcedure

        '    ' Add Parameters to SPROC
        '    Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
        '    _Cuenta.Value = Cuenta
        '    cmd.Parameters.Add(_Cuenta)

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    cmd.Parameters.Add(pEmpresa)

        '    Dim PerID As New SqlParameter("@PerID", SqlDbType.Int)
        '    PerID.Value = VB.SysContab.PeriodosDB.Activo
        '    cmd.Parameters.Add(PerID)

        '    'Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.Float, 50)
        '    '_Nombre.Direction = ParameterDirection.Output
        '    'cmd.Parameters.Add(_Nombre)

        '    DBConnFacturas.Open()
        '    cmd.ExecuteNonQuery()
        '    DBConnFacturas.Close()

        '    'Dim Name As String

        '    ' Populate Struct using Output Params from SPROC
        '    'If _Nombre.Value Is DBNull.Value Then
        '    '    Name = ""
        '    'Else
        '    '    Name = CDbl(_Nombre.Value)
        '    'End If

        '    'Return Name

        'End Function

        Public Shared Function UpdateFacturaCompraIva(ByVal Mes As String, ByVal Anio As String, ByVal Estado As String)

            Dim cmd As SqlCommand = New SqlCommand("_FacturasComprasUpdateIva", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure

            Dim _Mes As SqlParameter = New SqlParameter("@Mes", SqlDbType.Int)
            Dim _Anio As SqlParameter = New SqlParameter("@Anio", SqlDbType.Int)
            Dim _Estado As SqlParameter = New SqlParameter("@Estado", SqlDbType.Int)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Int)

            _Mes.Value = Mes
            _Anio.Value = Anio
            _Estado.Value = Estado
            _Empresa.Value = EmpresaActual

            cmd.Parameters.Add(_Mes)
            cmd.Parameters.Add(_Anio)
            cmd.Parameters.Add(_Estado)
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function

        '*******************************************************
        ' Objetivo: Actualiza comprobante
        ' Autor: Rosa Maria Porras Rojas
        ' Fecha: 11/May/2006
        '*******************************************************
        Public Function ComprobanteDetalle_Conciliado(ByVal cDet_ID As String, ByVal Undo As Integer)
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComprobanteDetalle_Conciliado", DBConnFacturas)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual

            Dim pDetID As New SqlParameter("@cDetID", SqlDbType.Decimal)
            pDetID.Value = cDet_ID

            Dim pUndo As New SqlParameter("@Undo", SqlDbType.Bit, 1)
            pUndo.Value = Undo


            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pDetID)
            DBCommand.SelectCommand.Parameters.Add(pUndo)

            'Try
            '    DBConn.Open()
            '    DBCommand.SelectCommand.ExecuteNonQuery()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
            'DBConn.Close()
            Try
                DBConn.Open()
                DBCommand.SelectCommand.Connection = DBConn
                DBCommand.SelectCommand.Transaction = transaccionFacturas
                DBCommand.SelectCommand.ExecuteNonQuery()
            Catch ex As Exception

            Finally
                DBConn.Close()
            End Try
        End Function

        Public Shared Function SaldoxCuenta(ByVal Cuenta As String, ByVal Periodo As String) As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            Dim cmd As SqlCommand = New SqlCommand("_SaldoxCuenta", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Cuenta
            cmd.Parameters.Add(_Cuenta)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim PerID As New SqlParameter("@PerID", SqlDbType.Int)
            PerID.Value = Periodo 'VB.SysContab.PeriodosDB.Activo
            cmd.Parameters.Add(PerID)

            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.Float, 50)
            _Nombre.Direction = ParameterDirection.Output
            cmd.Parameters.Add(_Nombre)

            DBConnFacturas.Open()
            cmd.ExecuteNonQuery()
            DBConnFacturas.Close()
            DBConnFacturas = Nothing

            Dim Name As String

            ' Populate Struct using Output Params from SPROC
            If _Nombre.Value Is DBNull.Value Then
                Name = ""
            Else
                Name = CDbl(_Nombre.Value)
            End If

            Return Name

        End Function




        'Public Function ValidarPresupuesto(ByVal Cuenta As String, ByVal Fecha As String, _
        '                                          ByVal Monto As String) As DataSet

        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_PresupuestoValidar", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
        '    _Cuenta.Value = Cuenta
        '    DBCommand.SelectCommand.Parameters.Add(_Cuenta)


        '    Dim PerID As New SqlParameter("@PerID", SqlDbType.Int)
        '    PerID.Value = PeriodosDB.Activo(Fecha)
        '    DBCommand.SelectCommand.Parameters.Add(PerID)

        '    DBCommand.Fill(dsFicha, "Conceptos")

        '    DBConn.Close()

        '    Return dsFicha
        'End Function




        '*******************************************************
        ' Objetivo: Contabilizar IR  o IVA
        ' Autor: Bernardo Robelo
        ' Fecha: 13/03/2006
        '*******************************************************

        Public Shared Function Transferencia(ByVal CuentaBanco1 As String, ByVal CuentaBanco2 As String, ByVal MontoBanco As String, _
                                     ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
                                     ByVal TipoComProbante As String, ByVal Fecha As String, ByVal NoCheque As String) As Boolean

            ' Create Instance of Connection and Command Object
            Dim Catalogo As New CatalogoDB
            Dim CompNo As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()


            Try

                CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(Fecha), Fecha, 0, "", True, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, False)


                ' BANCO ORIGEN
                AddComprobanteDetalles(CompNo, CuentaBanco1, "Emision Transferencia Bancaria", MontoBanco, NoCheque, TipoComProbante, "C", "", 0, Fecha, 1)
                'AddCatalogoTrans(CuentaBanco1, 0, MontoBanco, concepto)
                'Catalogo.ActualizarCuentas(CuentaBanco1, MontoBanco, 2)


                ' BANCO DESTINO
                AddComprobanteDetalles(CompNo, CuentaBanco2, "Recepcion Transferencia Bancaria", MontoBanco, NoCheque, TipoComProbante, "D", "", 0, Fecha, 1)
                'AddCatalogoTrans(CuentaBanco2, MontoBanco, 0, concepto)
                'Catalogo.ActualizarCuentas(CuentaBanco2, MontoBanco, 1)


                VB.SysContab.Rutinas.okTransaccion()
                Return True

            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)
                Return False

            End Try


        End Function



        '*******************************************************
        ' Objetivo: Contabilizar IR  o IVA
        ' Autor: Bernardo Robelo
        ' Fecha: 13/03/2006
        '*******************************************************

        Public Shared Function Contabilizar(ByVal CuentaBanco As String, ByVal MontoBanco As String, _
                                     ByVal ConceptoBanco As String, _
                                     ByVal CuentaIRVenta As String, ByVal MontoIRVenta As String, _
                                     ByVal ConceptoIRVenta As String, _
                                     ByVal CuentaIRAdelantado As String, ByVal MontoIRAdelantado As String, _
                                     ByVal ConceptoIRAdelantado As String, _
                                     ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
                                     ByVal TipoComProbante As String, ByVal Fecha As String) As Boolean

            ' Create Instance of Connection and Command Object
            Dim Catalogo As New CatalogoDB
            Dim CompNo As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()


            Try

                CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(Fecha), Fecha, 0, _
                                        "", False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, OrigenComprobantes.DEFECTO)

                '' Para Banco
                If CuentaBanco <> "0" Then
                    AddComprobanteDetalles(CompNo, CuentaBanco, ConceptoBanco, MontoBanco, 0, TipoComProbante, "C", "", 0, Fecha, 1)
                    'AddCatalogoTrans(CuentaBanco, 0, MontoBanco, ConceptoBanco)
                    'Catalogo.ActualizarCuentas(CuentaBanco, MontoBanco, 2)
                End If

                ' Para IR Venta
                AddComprobanteDetalles(CompNo, CuentaIRVenta, ConceptoIRVenta, MontoIRVenta, 0, TipoComProbante, "C", "", 0, Fecha, 1)
                'AddCatalogoTrans(CuentaIRVenta, 0, MontoIRVenta, ConceptoIRVenta)
                'Catalogo.ActualizarCuentas(CuentaIRVenta, MontoIRVenta, 1)


                ' Para IR Adelantado
                AddComprobanteDetalles(CompNo, CuentaIRAdelantado, ConceptoIRAdelantado, MontoIRAdelantado, 0, TipoComProbante, "D", "", 0, Fecha, 1)
                'AddCatalogoTrans(CuentaIRAdelantado, MontoIRAdelantado, 0, ConceptoIRAdelantado)
                'Catalogo.ActualizarCuentas(CuentaIRAdelantado, MontoIRAdelantado, 1)


                VB.SysContab.Rutinas.okTransaccion()

                Return True

            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)

                Return False

            End Try



        End Function




        '*******************************************************
        ' Objetivo: Comprobante IR 
        ' Autor: Bernardo Robelo
        ' Fecha: 08/03/2006
        '*******************************************************

        Public Shared Function GeneraComprobanteIR(ByVal CuentaBanco As String, ByVal MontoBanco As String, _
                                     ByVal ConceptoBanco As String, _
                                     ByVal CuentaIRVenta As String, ByVal MontoIRVenta As String, _
                                     ByVal ConceptoIRVenta As String, _
                                     ByVal CuentaIRAdelantado As String, ByVal MontoIRAdelantado As String, _
                                     ByVal ConceptoIRAdelantado As String, _
                                     ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
                                     ByVal TipoComProbante As String, ByVal Fecha As String) As Boolean

            ' Create Instance of Connection and Command Object
            Dim Catalogo As New CatalogoDB
            Dim CompNo As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()


            Try
                CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(Fecha), Fecha, 0, "", False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, False)

                '' Para Banco
                If CuentaBanco <> "0" Then

                    AddComprobanteDetalles(CompNo, CuentaBanco, ConceptoBanco, MontoBanco, 0, TipoComProbante, "C", "", 0, Fecha, 1)
                    'AddCatalogoTrans(CuentaBanco, 0, MontoBanco, ConceptoBanco)
                    'Catalogo.ActualizarCuentas(CuentaBanco, MontoBanco, 2)

                End If

                ' Para IR Venta
                AddComprobanteDetalles(CompNo, CuentaIRVenta, ConceptoIRVenta, MontoIRVenta, 0, TipoComProbante, "D", "", 0, Fecha, 1)
                'AddCatalogoTrans(CuentaIRVenta, MontoIRVenta, 0, ConceptoIRVenta)
                'Catalogo.ActualizarCuentas(CuentaIRVenta, MontoIRVenta, 2)



                ' Para IR Adelantado
                AddComprobanteDetalles(CompNo, CuentaIRAdelantado, ConceptoIRAdelantado, MontoIRAdelantado, 0, TipoComProbante, "C", "", 0, Fecha, 1)
                'AddCatalogoTrans(CuentaIRAdelantado, 0, MontoIRAdelantado, ConceptoIRAdelantado)
                'Catalogo.ActualizarCuentas(CuentaIRAdelantado, MontoIRAdelantado, 2)


                VB.SysContab.Rutinas.okTransaccion()
                Return True

            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)
                Return False

            End Try


        End Function



        '*******************************************************
        ' Objetivo: Comprobante IVA 
        ' Autor: Bernardo Robelo
        ' Fecha: 06/03/2006
        '*******************************************************

        Public Shared Function GeneraComprobanteIVA(ByVal CuentaBanco As String, ByVal MontoBanco As String, _
                                     ByVal ConceptoBanco As String, _
                                     ByVal CuentaIVASoport As String, ByVal MontoIVASoport As String, _
                                     ByVal ConceptoIVASoport As String, _
                                     ByVal CuentaIVARepert As String, ByVal MontoIVaRepert As String, _
                                     ByVal ConceptoIVARepert As String, _
                                     ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
                                     ByVal TipoComProbante As String, ByVal Fecha As String, ByVal Mes As String, _
                                     ByVal Anio As String, ByVal Saldo As String) As Boolean

            ' Create Instance of Connection and Command Object
            Dim Catalogo As New CatalogoDB
            Dim CompNo As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()


            Try
                CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(Fecha), Fecha, 0, "", False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, False)

                '' Para Banco
                If CuentaBanco <> "0" Then
                    AddComprobanteDetalles(CompNo, CuentaBanco, ConceptoBanco, MontoBanco, 0, TipoComProbante, "C", "", 0, Fecha, 1)
                    'AddCatalogoTrans(CuentaBanco, 0, MontoBanco, ConceptoBanco)
                    'Catalogo.ActualizarCuentas(CuentaBanco, MontoBanco, 2)
                End If

                ' Para IVA Soportado
                AddComprobanteDetalles(CompNo, CuentaIVASoport, ConceptoIVASoport, MontoIVASoport, 0, TipoComProbante, "C", "", 0, Fecha, 1)
                'AddCatalogoTrans(CuentaIVASoport, 0, MontoIVASoport, ConceptoIVASoport)
                'Catalogo.ActualizarCuentas(CuentaIVASoport, MontoIVASoport, 2)

                ' Para IVA Repercutido
                AddComprobanteDetalles(CompNo, CuentaIVARepert, ConceptoIVARepert, MontoIVaRepert, 0, TipoComProbante, "D", "", 0, Fecha, 1)
                'AddCatalogoTrans(CuentaIVARepert, MontoIVaRepert, 0, ConceptoIVARepert)
                'Catalogo.ActualizarCuentas(CuentaIVASoport, MontoIVaRepert, 2)

                UpdateFacturaCompraIva(Mes, Anio, 1)

                If SaldoCuenta(CuentaIVASoport, Fecha).Tables("Tabla").Rows.Count = 0 Then
                    'Tipo = 1
                    SaldoCuentaAdd(CuentaIVASoport, Saldo, 1, Fecha)
                Else
                    'Tipo = 2
                    SaldoCuentaAdd(CuentaIVASoport, Saldo, 2, Fecha)
                End If

                VB.SysContab.Rutinas.okTransaccion()
                Return True

            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)

                Return False

            End Try


        End Function

        Public Shared Function ContabilizaFacturaCompra(ByVal CuentaCaja As String, ByVal DebeCaja As String, _
                             ByVal ConceptoCaja As String, _
                             ByVal CuentaIngr As String, ByVal HaberIngr As String, _
                             ByVal ConceptoIngr As String, _
                             ByVal CuentaIVA As String, ByVal HaberIVa As String, _
                             ByVal ConceptoIVA As String, _
                             ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
                             ByVal TipoComProbante As String, ByVal Fecha As String, ByVal FacturaNo As String, _
                             ByVal CuentaIR As String, ByVal MontoIR As String, ByVal ConceptoIR As String, _
                             ByVal Tipo As String) As Boolean

            ' Create Instance of Connection and Command Object
            Dim Catalogo As New CatalogoDB
            Dim CompNo As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(Fecha), Fecha, 0, "", False, 0, "", 0, FacturaNo, VB.SysContab.Rutinas.Fecha, 0, False)

                '' Para Caja
                AddComprobanteDetalles(CompNo, CuentaCaja, ConceptoCaja, DebeCaja, 0, TipoComProbante, "D", FacturaNo, 0, Fecha, 1)
                'AddCatalogoTrans(CuentaCaja, DebeCaja, 0, ConceptoCaja)
                'Catalogo.ActualizarCuentas(CuentaCaja, DebeCaja, 1)

                If Tipo = 1 Then 'Si es de contado
                    '' Para IR
                    AddComprobanteDetalles(CompNo, CuentaIR, ConceptoIR, MontoIR, 0, TipoComProbante, "D", FacturaNo, 0, Fecha, 1)
                    'AddCatalogoTrans(CuentaIR, MontoIR, 0, ConceptoIR)
                    'Catalogo.ActualizarCuentas(CuentaIR, MontoIR, 1)
                End If

                '' Para Ingresos
                AddComprobanteDetalles(CompNo, CuentaIngr, ConceptoIngr, HaberIngr, 0, TipoComProbante, "C", FacturaNo, 0, Fecha, 1)
                'AddCatalogoTrans(CuentaIngr, 0, HaberIngr, ConceptoIngr)
                'Catalogo.ActualizarCuentas(CuentaIngr, HaberIngr, 1)

                '' Para IVA
                AddComprobanteDetalles(CompNo, CuentaIVA, ConceptoIVA, HaberIVa, 0, TipoComProbante, "C", FacturaNo, 0, Fecha, 1)
                'AddCatalogoTrans(CuentaIVA, 0, HaberIVa, ConceptoIVA)
                'Catalogo.ActualizarCuentas(CuentaIVA, HaberIVa, 1)

                Dim f As frmFacturasComprasContadoContabilizar = f.Instance
                CancelarFactura(FacturaNo, f.dgProveedores.Item(f.dgProveedores.CurrentRowIndex, 10), 1)
                ContabilizarFactura(FacturaNo)

                VB.SysContab.Rutinas.okTransaccion()
                Return True

            Catch Mensaje As Exception
                MsgBox(Mensaje.Message)
                VB.SysContab.Rutinas.ErrorTransaccion()
                Return False
            End Try
        End Function

        '*******************************************************
        ' Objetivo: Comprobante Factura de Contado
        ' Autor: Bernardo Robelo
        ' Fecha: 28/Feb/2005
        '*******************************************************

        Public Shared Function GeneraComprobanteFactura(ByVal CuentaCaja As String, ByVal DebeCaja As String, _
                                     ByVal ConceptoCaja As String, _
                                     ByVal CuentaIngr As String, ByVal HaberIngr As String, _
                                     ByVal ConceptoIngr As String, _
                                     ByVal CuentaIVA As String, ByVal HaberIVa As String, _
                                     ByVal ConceptoIVA As String, _
                                     ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
                                     ByVal TipoComProbante As String, ByVal Fecha As String, ByVal FacturaNo As String, _
                                     ByVal CuentaIR As String, ByVal MontoIR As String, ByVal ConceptoIR As String, ByVal Tipo As String) As Boolean

            ' Create Instance of Connection and Command Object
            Dim Catalogo As New CatalogoDB
            Dim CompNo As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(Fecha), Fecha, 0, "", False, 0, "", 0, FacturaNo, VB.SysContab.Rutinas.Fecha, 0, False)

                '' Para Caja
                AddComprobanteDetalles(CompNo, CuentaCaja, ConceptoCaja, DebeCaja, 0, TipoComProbante, "D", FacturaNo, 0, Fecha, 1)
                'AddCatalogoTrans(CuentaCaja, DebeCaja, 0, ConceptoCaja)
                'Catalogo.ActualizarCuentas(CuentaCaja, DebeCaja, 1)

                If Tipo = 1 Then 'Si es de contado
                    '' Para IR
                    AddComprobanteDetalles(CompNo, CuentaIR, ConceptoIR, MontoIR, 0, TipoComProbante, "D", FacturaNo, 0, Fecha, 1)
                    'AddCatalogoTrans(CuentaIR, MontoIR, 0, ConceptoIR)
                    'Catalogo.ActualizarCuentas(CuentaIR, MontoIR, 1)
                End If

                '' Para Ingresos
                AddComprobanteDetalles(CompNo, CuentaIngr, ConceptoIngr, HaberIngr, 0, TipoComProbante, "C", FacturaNo, 0, Fecha, 1)
                'AddCatalogoTrans(CuentaIngr, 0, HaberIngr, ConceptoIngr)
                'Catalogo.ActualizarCuentas(CuentaIngr, HaberIngr, 1)

                '' Para IVA
                AddComprobanteDetalles(CompNo, CuentaIVA, ConceptoIVA, HaberIVa, 0, TipoComProbante, "C", FacturaNo, 0, Fecha, 1)
                'AddCatalogoTrans(CuentaIVA, 0, HaberIVa, ConceptoIVA)
                'Catalogo.ActualizarCuentas(CuentaIVA, HaberIVa, 1)


                ContabilizarFactura(FacturaNo)
                transaccionFacturas.Commit()
                Return True
            Catch Mensaje As Exception
                MsgBox(Mensaje.Message)
                VB.SysContab.Rutinas.ErrorTransaccion()
                Return False            
            End Try
        End Function

        Public Shared Function DesContabilizarFactura(ByVal Factura As String)
            ' Create Instance of Connection and Command Object
            'Dim conexion As New VB.SysContab.Rutinas()
            Dim cmd As New SqlCommand("_FacturasVentasDesContabilizar", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            _Factura.Value = Factura
            cmd.Parameters.Add(_Factura)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function


        '*******************************************************
        ' Objetivo: Cambia el Estado de la Factura Fact_contabilizado = 0 a 1
        ' Autor: Bernardo Robelo
        ' Fecha: 28/Feb/2005
        '*******************************************************


        Public Shared Function ContabilizarFactura(ByVal Factura As String)

            ' Create Instance of Connection and Command Object
            'Dim conexion As New VB.SysContab.Rutinas()
            Dim cmd As New SqlCommand("_FacturasVentasContabilizar", DBConnFacturas)


            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            _Factura.Value = Factura
            cmd.Parameters.Add(_Factura)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function

        '*******************************************************
        ' Objetivo: Cambia el Estado de la Factura de Ventas Fact_Cancelado = 0 a 1
        ' Autor: Rosa Porras
        ' Fecha: 09/04/2007
        '*******************************************************


        Public Shared Function CancelarFactura(ByVal Factura As String)

            ' Create Instance of Connection and Command Object
            'Dim conexion As New VB.SysContab.Rutinas()
            Dim cmd As New SqlCommand("_FacturasVentasCancelar", DBConnFacturas)


            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            _Factura.Value = Factura
            cmd.Parameters.Add(_Factura)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function


        Public Shared Function CancelarFactura(ByVal Factura As String, ByVal Proveedor As String, _
                                               ByVal Estado As Integer)

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim cmd As New SqlCommand("_FacturasComprasCancelar", DBConnFacturas)


            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            _Factura.Value = Factura
            cmd.Parameters.Add(_Factura)

            Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar, 50)
            _Proveedor.Value = Proveedor
            cmd.Parameters.Add(_Proveedor)

            Dim _Estado As New SqlParameter("@Estado", SqlDbType.Int)
            _Estado.Value = Estado
            cmd.Parameters.Add(_Estado)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function


        Public Shared Function ActualizarCheque(ByVal CuentaContable As String, ByVal Cheque As String)

            Dim conexion As New VB.SysContab.Rutinas
            Dim cmd As New SqlCommand("_BancosUpdateCheque", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _CuentaContable As New SqlParameter("@CuentaContable", SqlDbType.NVarChar, 50)
            _CuentaContable.Value = CuentaContable
            cmd.Parameters.Add(_CuentaContable)

            Dim _Cheque As New SqlParameter("@Cheque", SqlDbType.Int)
            _Cheque.Value = Cheque
            cmd.Parameters.Add(_Cheque)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

        End Function



        Public Function GetDetails(ByVal Codigo As String) As Tipo_ComprobanteDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsZonas As New DataSet
            Dim Details As New Tipo_ComprobanteDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM TipoComprobantes WHERE TipComp_Id = " & Codigo & " AND Empresa = '" & EmpresaActual & "'", DBConn)

            DBCommand.Fill(dsZonas, "TipoComprobantes")

            If dsZonas.Tables("TipoComprobantes").Rows.Count = 1 Then
                Details.Codigo = dsZonas.Tables("TipoComprobantes").Rows(0).Item("TipComp_ID").ToString
                Details.Nombre = dsZonas.Tables("TipoComprobantes").Rows(0).Item("TipComp_Nombre").ToString

            End If

            Return Details

        End Function



        '*******************************************************
        ' Objetivo: ComprobanteDeposito
        ' Autor: Bernardo Robelo
        ' Fecha: 10/Feb/2005
        '*******************************************************

        Public Shared Function GeneraComprobanteDeposito(ByVal CuentaCaja As String, ByVal DebeCaja As String, _
                    ByVal HaberCaja As String, ByVal ConceptoCaja As String, ByVal NoCheque As String, _
                    ByVal CuentaBanco As String, ByVal DebeBanco As String, ByVal HaberBanco As String, _
                    ByVal ConceptoBanco As String, ByVal TipoComp As Integer, ByVal TasaCambio As Double, _
                    ByVal tMoneda As String, ByVal concepto As String, ByVal TipoComProbante As String, _
                    ByVal Fecha As String, ByVal HojaDeposito As String)                                       'As Boolean

            ' Create Instance of Connection and Command Object
            Dim Catalogo As New CatalogoDB
            Dim CompNo As String

            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            'DBConnFacturas.Open()
            'transaccionFacturas = DBConnFacturas.BeginTransaction()


            'Try
            CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(Fecha), Fecha, HojaDeposito, "", _
                                    False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, False)

            '' Para Caja
            AddComprobanteDetalles(CompNo, CuentaCaja, ConceptoCaja, HaberCaja, NoCheque, TipoComProbante, "C", "", 0, Fecha, 1)
            'AddCatalogoTrans(CuentaCaja, DebeCaja, HaberCaja, ConceptoCaja)
            'Catalogo.ActualizarCuentas(CuentaCaja, HaberCaja, 2)  ' Se va a Restar de la Cuenta


            ' Para Banco
            AddComprobanteDetalles(CompNo, CuentaBanco, ConceptoBanco, DebeBanco, NoCheque, TipoComProbante, "D", "", 0, Fecha, 1)
            'AddCatalogoTrans(CuentaBanco, DebeBanco, HaberBanco, ConceptoBanco)
            'Catalogo.ActualizarCuentas(CuentaBanco, DebeBanco, 1)  ' Se va a Sumar al Banco


            'transaccionFacturas.Commit()
            'DBConnFacturas.Close()

            'Return True

            'Catch Mensaje As Exception
            '    'transaccionFacturas.Rollback()
            '    'MsgBox(Mensaje.Message)

            '    Return False

            'End Try

        End Function

        '*******************************************************
        ' Objetivo: Grabar un Comprobante de Esquema = 4 Plantilla = 1
        ' Autor: Bernardo Robelo
        ' Fecha: 16/Feb/2006
        ' Autor: Bernardo Robelo
        '*******************************************************

        Public Shared Function GeneraComprobanteDepositoServPublicos(ByVal CuentaProv As String, ByVal DebeProv As String, ByVal HaberProv As String, _
                                     ByVal ConceptoProv As String, ByVal NoCheque As String, _
                                     ByVal CuentaBanco As String, ByVal DebeBanco As String, ByVal HaberBanco As String, _
                                     ByVal ConceptoBanco As String, _
                                     ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
                                     ByVal TipoComProbante As String, ByVal Fecha As String, ByVal FacturaNo As String, ByVal Proveedor As String, _
                                     ByVal ChequeNombre As String) As Boolean

            ' Create Instance of Connection and Command Object
            Dim Catalogo As New CatalogoDB
            Dim CompNo As String

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(Fecha), Fecha, 0, ChequeNombre, False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, False)

                ActualizarCheque(CuentaBanco, NoCheque)

                CancelarFactura(FacturaNo, Proveedor, 1)

                '' Proveedor
                AddComprobanteDetalles(CompNo, CuentaProv, ConceptoProv, DebeProv, NoCheque, TipoComProbante, "D", FacturaNo, 0, Fecha, 1)
                'AddCatalogoTrans(CuentaProv, DebeProv, HaberProv, ConceptoProv)
                'Catalogo.ActualizarCuentas(CuentaProv, DebeProv, 2)  ' Se va a Restar de la Cuenta


                ' Para Banco
                AddComprobanteDetalles(CompNo, CuentaBanco, ConceptoBanco, HaberBanco, NoCheque, TipoComProbante, "C", FacturaNo, 0, Fecha, 1)
                'AddCatalogoTrans(CuentaBanco, DebeBanco, HaberBanco, ConceptoBanco)
                'Catalogo.ActualizarCuentas(CuentaBanco, HaberBanco, 2)   ' Se va a Sumar al Banco


                VB.SysContab.Rutinas.okTransaccion()

                Return True

            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)

                Return False

            End Try



        End Function



        '*******************************************************
        ' Objetivo: Grabar un Comprobante de Esquema = 3 Plantilla = 1
        ' Autor: Bernardo Robelo
        ' Fecha: 8/Feb/2006
        ' Autor: Bernardo Robelo
        '*******************************************************

        Public Shared Function GeneraComprobanteReconexion(ByVal CuentaProv As String, ByVal DebeProv As String, ByVal HaberProv As String, _
                                     ByVal ConceptoProv As String, ByVal NoCheque As String, _
                                     ByVal CuentaIVA As String, ByVal DebeIVa As String, ByVal HaberIVA As String, _
                                     ByVal ConceptoIVA As String, _
                                     ByVal CuentaBanco As String, ByVal DebeBanco As String, ByVal HaberBanco As String, _
                                     ByVal ConceptoBanco As String, _
                                     ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
                                     ByVal TipoComProbante As String, ByVal Fecha As String, ByVal FacturaNo As String, ByVal Proveedor As String, _
                                    ByVal ChequeNombre As String) As String

            ' Create Instance of Connection and Command Object
            Dim Catalogo As New CatalogoDB
            Dim CompNo As String = 0

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(Fecha), Fecha, 0, ChequeNombre, False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, False)

                ActualizarCheque(CuentaBanco, NoCheque)

                CancelarFactura(FacturaNo, Proveedor, 1)

                '' Para Proveedores
                AddComprobanteDetalles(CompNo, CuentaProv, ConceptoProv, DebeProv, NoCheque, TipoComProbante, "D", FacturaNo, 0, Fecha, 1)
                'AddCatalogoTrans(CuentaProv, DebeProv, HaberProv, ConceptoProv)
                'Catalogo.ActualizarCuentas(CuentaProv, DebeProv, 2) ' Se va a Restar de la Cuenta

                '' Para IVA
                AddComprobanteDetalles(CompNo, CuentaIVA, ConceptoIVA, DebeIVa, NoCheque, TipoComProbante, "D", FacturaNo, 0, Fecha, 1)
                'AddCatalogoTrans(CuentaIVA, DebeIVa, HaberIVA, ConceptoIVA)
                'Catalogo.ActualizarCuentas(CuentaIVA, DebeIVa, 1) ' Se va Sumar al IVA

                ' Para Banco
                AddComprobanteDetalles(CompNo, CuentaBanco, ConceptoBanco, HaberBanco, NoCheque, TipoComProbante, "C", FacturaNo, 0, Fecha, 1)
                'AddCatalogoTrans(CuentaBanco, DebeBanco, HaberBanco, ConceptoBanco)
                'Catalogo.ActualizarCuentas(CuentaBanco, HaberBanco, 2) ' Se va a restar al Banco

                VB.SysContab.Rutinas.okTransaccion()


            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)

            End Try

            Return CompNo


        End Function


        '*******************************************************
        ' Objetivo: Grabar un Comprobante de Esquema = 2 Plantilla = 1
        ' Autor: Bernardo Robelo
        ' Fecha: 8/Feb/2006
        '*******************************************************

        Public Shared Function GeneraComprobanteInstalacion(ByVal CuentaProv As String, ByVal DebeProv As String, ByVal HaberProv As String, _
                                     ByVal ConceptoProv As String, ByVal NoCheque As String, _
                                     ByVal CuentaBanco As String, ByVal DebeBanco As String, ByVal HaberBanco As String, _
                                     ByVal ConceptoBanco As String, _
                                     ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
                                     ByVal TipoComProbante As String, ByVal Fecha As String, ByVal FacturaNo As String, ByVal Proveedor As String, _
                                     ByVal ChequeNombre As String) As String

            ' Create Instance of Connection and Command Object
            Dim Catalogo As New CatalogoDB
            Dim CompNo As String = 0

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(Fecha), Fecha, 0, ChequeNombre, False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, False)

                ActualizarCheque(CuentaBanco, NoCheque)

                CancelarFactura(FacturaNo, Proveedor, 1)

                '' Para Proveedores
                AddComprobanteDetalles(CompNo, CuentaProv, ConceptoProv, DebeProv, NoCheque, TipoComProbante, "D", FacturaNo, 0, Fecha, 1) ' Esto se pone segun D/C de la cuenta T
                'AddCatalogoTrans(CuentaProv, DebeProv, HaberProv, ConceptoProv)
                'Catalogo.ActualizarCuentas(CuentaProv, DebeProv, 1) ' Se va a Restar de la Cuenta  ' Esto de Pone segun el moviento de la cuenta 1 - Suma 2 - Resta


                ' Para Banco
                AddComprobanteDetalles(CompNo, CuentaBanco, ConceptoBanco, HaberBanco, NoCheque, TipoComProbante, "C", FacturaNo, 0, Fecha, 1)
                'AddCatalogoTrans(CuentaBanco, DebeBanco, HaberBanco, ConceptoBanco)
                'Catalogo.ActualizarCuentas(CuentaBanco, HaberBanco, 2) ' Se va a restar al Banco

                VB.SysContab.Rutinas.okTransaccion()


            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)

            End Try

            Return CompNo

        End Function

        'Pago por caja Chicha
        Public Shared Function GeneraComprobantePPCC(ByVal CuentaProv As String, ByVal DebeProv As String, ByVal HaberProv As String, _
                             ByVal ConceptoProv As String, ByVal NoCheque As String, _
                             ByVal CuentaIVA As String, ByVal DebeIVa As String, ByVal HaberIVA As String, _
                             ByVal ConceptoIVA As String, _
                             ByVal CuentaCaja As String, ByVal DebeCaja As String, ByVal HaberCaja As String, _
                             ByVal ConceptoCaja As String, _
                             ByVal CuentaIR As String, ByVal DebeIR As String, ByVal HaberIR As String, _
                             ByVal ConceptoIR As String, _
                             ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
                             ByVal TipoComProbante As String, ByVal ComprFecha As String, ByVal FacturaNo As String, ByVal Proveedor As String) As String

            ' Create Instance of Connection and Command Object
            Dim Catalogo As New CatalogoDB
            Dim CompNo As String = 0

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(ComprFecha), ComprFecha, 0, "", False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, False)

                'ActualizarCheque(CuentaBanco)

                CancelarFactura(FacturaNo, Proveedor, 1)


                '' Para Proveedores
                AddComprobanteDetalles(CompNo, CuentaProv, ConceptoProv, DebeProv, NoCheque, TipoComProbante, "D", FacturaNo, 0, ComprFecha, 1)
                'AddCatalogoTrans(CuentaProv, DebeProv, HaberProv, ConceptoProv)
                'Catalogo.ActualizarCuentas(CuentaProv, DebeProv, 2) ' Se va a Restar de la Cuenta

                ''' Para IVA
                'AddComprobanteDetalles(CompNo, CuentaIVA, ConceptoIVA, DebeIVa, NoCheque, TipoComProbante, "D")
                'AddCatalogoTrans(CuentaIVA, DebeIVa, HaberIVA, ConceptoIVA)
                'Catalogo.ActualizarCuentas(CuentaIVA, DebeIVa, 1) ' Se va Sumar al IVA

                ' Para Caja
                AddComprobanteDetalles(CompNo, CuentaCaja, ConceptoCaja, HaberCaja, NoCheque, TipoComProbante, "C", FacturaNo, 0, ComprFecha, 1)
                'AddCatalogoTrans(CuentaCaja, DebeCaja, HaberCaja, ConceptoCaja)
                'Catalogo.ActualizarCuentas(CuentaCaja, HaberCaja, 2) ' Se va a restar al Banco

                If HaberIR > 0 Then
                    ' ParaIR
                    AddComprobanteDetalles(CompNo, CuentaIR, ConceptoIR, HaberIR, NoCheque, TipoComProbante, "C", FacturaNo, 0, ComprFecha, 1)
                    'AddCatalogoTrans(CuentaIR, DebeIR, HaberIR, ConceptoIR)
                    'Catalogo.ActualizarCuentas(CuentaIR, HaberIR, 1) ' Se va a Sumar

                End If

                VB.SysContab.Rutinas.okTransaccion()


            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)

            End Try

            Return CompNo

        End Function





        '*******************************************************
        ' Objetivo: Agrega una transaccion en el Catalogo de transacciones
        ' Autor: Bernardo Robelo
        ' Fecha: 16/Nov/2005
        '*******************************************************

        Public Shared Function GeneraComprobantePPC(ByVal CuentaProv As String, ByVal DebeProv As String, ByVal HaberProv As String, _
                                     ByVal ConceptoProv As String, ByVal NoCheque As String, _
                                     ByVal CuentaIVA As String, ByVal DebeIVa As String, ByVal HaberIVA As String, _
                                     ByVal ConceptoIVA As String, _
                                     ByVal CuentaBanco As String, ByVal DebeBanco As String, ByVal HaberBanco As String, _
                                     ByVal ConceptoBanco As String, _
                                     ByVal CuentaIR As String, ByVal DebeIR As String, ByVal HaberIR As String, _
                                     ByVal ConceptoIR As String, _
                                     ByVal TipoComp As Integer, ByVal TasaCambio As Double, ByVal tMoneda As String, ByVal concepto As String, _
                                     ByVal TipoComProbante As String, ByVal ComprFecha As String, ByVal FacturaNo As String, ByVal Proveedor As String, _
                                     ByVal ChequeNombre As String) As String

            ' Create Instance of Connection and Command Object
            Dim Catalogo As New CatalogoDB
            Dim CompNo As String = 0

            Dim conexion As New VB.SysContab.Rutinas
            DBConnFacturas = New SqlConnection(Rutinas.AbrirConexion())
            DBConnFacturas.Open()
            transaccionFacturas = DBConnFacturas.BeginTransaction()

            Try
                CompNo = AddComprobante(TipoComp, TasaCambio, concepto, tMoneda, PeriodosDB.Activo(ComprFecha), ComprFecha, 0, ChequeNombre, False, 0, "", 0, "", VB.SysContab.Rutinas.Fecha, 0, False)

                ActualizarCheque(CuentaBanco, NoCheque)

                CancelarFactura(FacturaNo, Proveedor, 1)

                '' Para Proveedores
                AddComprobanteDetalles(CompNo, CuentaProv, ConceptoProv, DebeProv, NoCheque, TipoComProbante, "D", FacturaNo, 0, ComprFecha, 1)
                'AddCatalogoTrans(CuentaProv, DebeProv, HaberProv, ConceptoProv)
                'Catalogo.ActualizarCuentas(CuentaProv, DebeProv, 2) ' Se va a Restar de la Cuenta

                '' Para IVA
                AddComprobanteDetalles(CompNo, CuentaIVA, ConceptoIVA, DebeIVa, NoCheque, TipoComProbante, "D", FacturaNo, 0, ComprFecha, 1)
                'AddCatalogoTrans(CuentaIVA, DebeIVa, HaberIVA, ConceptoIVA)
                'Catalogo.ActualizarCuentas(CuentaIVA, DebeIVa, 1) ' Se va Sumar al IVA

                ' Para Banco
                AddComprobanteDetalles(CompNo, CuentaBanco, ConceptoBanco, HaberBanco, NoCheque, TipoComProbante, "C", FacturaNo, 0, ComprFecha, 1)
                'AddCatalogoTrans(CuentaBanco, DebeBanco, HaberBanco, ConceptoBanco)
                'Catalogo.ActualizarCuentas(CuentaBanco, HaberBanco, 2) ' Se va a restar al Banco


                If HaberIR > 0 Then

                    ' ParaIR
                    AddComprobanteDetalles(CompNo, CuentaIR, ConceptoIR, HaberIR, NoCheque, TipoComProbante, "C", FacturaNo, 0, ComprFecha, 1)
                    'AddCatalogoTrans(CuentaIR, DebeIR, HaberIR, ConceptoIR)
                    'Catalogo.ActualizarCuentas(CuentaIR, HaberIR, 1) ' Se va a Sumar

                End If

                VB.SysContab.Rutinas.okTransaccion()

            Catch Mensaje As Exception
                VB.SysContab.Rutinas.ErrorTransaccion()
                MsgBox(Mensaje.Message)

            End Try

            Return CompNo

        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 15/Dic/2005
        'Objetivo: Regresa los Comprobantes
        '*******************************************************

        'Public Function GetComprobantesList(ByVal fecha As String, ByVal Tipo As String, _
        '                                    ByVal Numero As String, ByVal Cuenta As String, _
        '                                    ByVal Meses As String, ByVal Anno As String, _
        '                                    ByVal Inicial As String, ByVal Final As String, ByVal PerID As String) As DataSet
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_ComprobantesList", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    DBCommand.SelectCommand.Parameters.Add(pEmpresa)

        '    Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
        '    _Fecha.Value = fecha
        '    DBCommand.SelectCommand.Parameters.Add(_Fecha)

        '    Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
        '    _Tipo.Value = Tipo
        '    DBCommand.SelectCommand.Parameters.Add(_Tipo)

        '    Dim _Numero As New SqlParameter("@Numero", SqlDbType.NVarChar)
        '    _Numero.Value = Numero
        '    DBCommand.SelectCommand.Parameters.Add(_Numero)

        '    Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar)
        '    _Cuenta.Value = Cuenta
        '    DBCommand.SelectCommand.Parameters.Add(_Cuenta)

        '    Dim _Meses As New SqlParameter("@Meses", SqlDbType.NVarChar)
        '    _Meses.Value = Meses
        '    DBCommand.SelectCommand.Parameters.Add(_Meses)

        '    Dim _Anno As New SqlParameter("@Anno", SqlDbType.NVarChar)
        '    _Anno.Value = Anno
        '    DBCommand.SelectCommand.Parameters.Add(_Anno)

        '    Dim _Inicial As New SqlParameter("@Inicial", SqlDbType.NVarChar)
        '    _Inicial.Value = Inicial
        '    DBCommand.SelectCommand.Parameters.Add(_Inicial)

        '    Dim _Final As New SqlParameter("@Final", SqlDbType.NVarChar)
        '    _Final.Value = Final
        '    DBCommand.SelectCommand.Parameters.Add(_Final)

        '    Dim _PerID As New SqlParameter("@PerID", SqlDbType.NVarChar)
        '    _PerID.Value = PerID
        '    DBCommand.SelectCommand.Parameters.Add(_PerID)

        '    Try
        '        DBCommand.Fill(dsFicha, "Comprobantes")
        '    Catch e As Exception
        '        MsgBox(e.Message)
        '    End Try

        '    DBConn.Close()

        '    Return dsFicha

        'End Function

        Public Shared Function GetComprobantesList(ByVal Periodo As Integer, ByVal Mes As Integer, _
        ByVal TipoComprobante As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComprobantesList_V2", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Periodo As New SqlParameter("@Periodo", SqlDbType.Int)
            _Periodo.Value = Periodo
            DBCommand.SelectCommand.Parameters.Add(_Periodo)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.Int)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Dim _TipoComprobante As New SqlParameter("@TipoComprobante", SqlDbType.Int)
            _TipoComprobante.Value = TipoComprobante
            DBCommand.SelectCommand.Parameters.Add(_TipoComprobante)


            Try
                DBCommand.SelectCommand.CommandTimeout = 0
                DBCommand.Fill(dsFicha, "Comprobantes")
                DBConn.Close()

                Return dsFicha
            Catch e As Exception
                DBConn.Close()
                XtraMsg(e.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Function


        Public Function GetComprobanteDetails2(ByVal CompNo As String, ByVal PerID As String, ByVal Fecha1 As String) As ComprobantesDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_ComprobantesDetails2", DBConn)

            ' Mark the Command as a SPROC
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim ComprNO As New SqlParameter("@ComprNO", SqlDbType.Int, 4)
            ComprNO.Value = CompNo
            DBCommand.SelectCommand.Parameters.Add(ComprNO)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _PerID As New SqlParameter("@PerID", SqlDbType.Int)
            _PerID.Value = PerID
            DBCommand.SelectCommand.Parameters.Add(_PerID)

            Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
            _Fecha1.Value = Fecha1
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)

            Dim Fecha As New SqlParameter("@Fecha", SqlDbType.NVarChar, 60)
            Fecha.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Fecha)

            Dim Numero As New SqlParameter("@Numero", SqlDbType.NVarChar, 60)
            Numero.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Numero)

            Dim Tipo As New SqlParameter("@Tipo", SqlDbType.NVarChar, 60)
            Tipo.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Tipo)

            Dim Tipo1 As New SqlParameter("@Tipo1", SqlDbType.NVarChar, 60)
            Tipo1.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Tipo1)

            Dim Descripcion As New SqlParameter("@Descripcion", SqlDbType.NVarChar, 60)
            Descripcion.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Descripcion)

            Dim TasaCambio As New SqlParameter("@TasaCambio", SqlDbType.NVarChar, 50)
            TasaCambio.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(TasaCambio)

            Dim Concepto As New SqlParameter("@Concepto", SqlDbType.NVarChar, 1500)
            Concepto.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Concepto)

            Dim Cheque As New SqlParameter("@Cheque", SqlDbType.NVarChar, 1500)
            Cheque.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Cheque)

            Dim Moneda As New SqlParameter("@Moneda", SqlDbType.NVarChar, 1500)
            Moneda.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Moneda)

            Dim Factura As New SqlParameter("@Factura", SqlDbType.NVarChar, 1500)
            Factura.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Factura)

            Dim Recibo As New SqlParameter("@Recibo", SqlDbType.NVarChar, 1500)
            Recibo.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Recibo)

            Dim ChequeNombre As New SqlParameter("@ChequeNombre", SqlDbType.NVarChar, 1500)
            ChequeNombre.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(ChequeNombre)

            Dim Pagara As New SqlParameter("@Pagara", SqlDbType.NVarChar, 50)
            Pagara.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Pagara)

            Dim Ruc As New SqlParameter("@Ruc", SqlDbType.NVarChar, 50)
            Ruc.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Ruc)

            Dim FormaPago As New SqlParameter("@FormaPago", SqlDbType.Int, 4)
            FormaPago.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(FormaPago)

            Dim Proveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar, 50)
            Proveedor.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Proveedor)

            Dim Factura1 As New SqlParameter("@Factura1", SqlDbType.NVarChar, 50)
            Factura1.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Factura1)

            Dim FechaPago As New SqlParameter("@FechaPago", SqlDbType.DateTime, 8)
            FechaPago.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(FechaPago)

            ' Create and Fill the DataSet
            Dim myDataSet As New DataSet
            Try
                DBCommand.Fill(myDataSet, "ComprobantesDetalles")

            Catch e As Exception
                MsgBox(e.Message)

            End Try

            DBConn.Close()

            ' ship date is null if order doesn't exist, or belongs to a different user
            'If Not Fecha.Value Is DBNull.Value Then

            Dim myOrderDetails As New ComprobantesDetails

            myOrderDetails.Fecha = Fecha.Value.ToString
            myOrderDetails.Numero = Numero.Value.ToString
            myOrderDetails.Concepto = Concepto.Value.ToString
            myOrderDetails.Cheque = Cheque.Value.ToString
            myOrderDetails.Descripcion = Descripcion.Value.ToString
            myOrderDetails.TasaCambio = TasaCambio.Value.ToString
            myOrderDetails.Tipo = Tipo.Value.ToString
            myOrderDetails.Tipo1 = Tipo1.Value.ToString
            myOrderDetails.Moneda = Moneda.Value.ToString
            myOrderDetails.Factura = Factura.Value.ToString
            myOrderDetails.Recibo = Recibo.Value.ToString
            myOrderDetails.ChequeNombre = ChequeNombre.Value.ToString
            myOrderDetails.Pagara = Pagara.Value.ToString
            myOrderDetails.Ruc = Ruc.Value.ToString
            myOrderDetails.FormaPago = FormaPago.Value.ToString
            myOrderDetails.Proveedor = Proveedor.Value.ToString
            myOrderDetails.Factura1 = Factura1.Value.ToString
            myOrderDetails.FechaPago = FechaPago.Value.ToString
            myOrderDetails.Detalles = myDataSet

            ' Return the DataSet
            Return myOrderDetails
            'Else
            '                Return Nothing
            'End If
        End Function

        Public Function GetComprobanteDetails(ByVal CompNo As String, ByVal PerID As String, _
                     ByVal Fecha1 As Date) As ComprobantesDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            DBCommand = New SqlDataAdapter("_ComprobantesDetails", DBConn)

            ' Mark the Command as a SPROC
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim ComprNO As New SqlParameter("@ComprNO", SqlDbType.Int, 4)
            ComprNO.Value = CompNo
            DBCommand.SelectCommand.Parameters.Add(ComprNO)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _PerID As New SqlParameter("@PerID", SqlDbType.Int)
            _PerID.Value = PerID
            DBCommand.SelectCommand.Parameters.Add(_PerID)

            Dim _Fecha1 As New SqlParameter("@Fecha1", SqlDbType.DateTime)
            _Fecha1.Value = Fecha1
            DBCommand.SelectCommand.Parameters.Add(_Fecha1)

            Dim Fecha As New SqlParameter("@Fecha", SqlDbType.SmallDateTime, 60)
            Fecha.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Fecha)

            Dim Numero As New SqlParameter("@Numero", SqlDbType.NVarChar, 60)
            Numero.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Numero)

            Dim Tipo As New SqlParameter("@Tipo", SqlDbType.NVarChar, 60)
            Tipo.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Tipo)

            Dim Tipo1 As New SqlParameter("@Tipo1", SqlDbType.NVarChar, 60)
            Tipo1.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Tipo1)

            Dim Descripcion As New SqlParameter("@Descripcion", SqlDbType.NVarChar, 60)
            Descripcion.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Descripcion)

            Dim TasaCambio As New SqlParameter("@TasaCambio", SqlDbType.NVarChar, 50)
            TasaCambio.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(TasaCambio)

            Dim Concepto As New SqlParameter("@Concepto", SqlDbType.NVarChar, 1500)
            Concepto.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Concepto)

            Dim Cheque As New SqlParameter("@Cheque", SqlDbType.NVarChar, 1500)
            Cheque.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Cheque)

            Dim Moneda As New SqlParameter("@Moneda", SqlDbType.NVarChar, 1500)
            Moneda.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Moneda)

            Dim Factura As New SqlParameter("@Factura", SqlDbType.NVarChar, 1500)
            Factura.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Factura)

            Dim Recibo As New SqlParameter("@Recibo", SqlDbType.NVarChar, 1500)
            Recibo.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Recibo)

            Dim ChequeNombre As New SqlParameter("@ChequeNombre", SqlDbType.NVarChar, 1500)
            ChequeNombre.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(ChequeNombre)

            Dim Pagara As New SqlParameter("@Pagara", SqlDbType.NVarChar, 50)
            Pagara.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Pagara)

            Dim Ruc As New SqlParameter("@Ruc", SqlDbType.NVarChar, 50)
            Ruc.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Ruc)

            Dim TipoX As New SqlParameter("@TipoX", SqlDbType.Int, 4)
            TipoX.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(TipoX)

            Dim Factura1 As New SqlParameter("@Factura1", SqlDbType.NVarChar, 50)
            Factura1.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Factura1)

            Dim FechaPago As New SqlParameter("@FechaPago", SqlDbType.DateTime, 8)
            FechaPago.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(FechaPago)

            Dim FormaPago As New SqlParameter("@FormaPago", SqlDbType.Int, 4)
            FormaPago.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(FormaPago)

            Dim Proveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar, 50)
            Proveedor.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Proveedor)

            Dim Comp As New SqlParameter("@Comp", SqlDbType.NVarChar, 50)
            Comp.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Comp)

            Dim _Consecutivo As New SqlParameter("@Consecutivo", SqlDbType.NVarChar, 50)
            _Consecutivo.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(_Consecutivo)

            ' Create and Fill the DataSet
            Dim myDataSet As New DataSet
            Try
                DBCommand.Fill(myDataSet, "ComprobantesDetalles")
            Catch e As Exception
                MsgBox(e.Message)
            End Try

            DBConn.Close()

            ' ship date is null if order doesn't exist, or belongs to a different user
            'If Not Fecha.Value Is DBNull.Value Then

            Dim myOrderDetails As New ComprobantesDetails
            If Fecha.Value Is Nothing Then
                XtraMsg("Hubo un error al recuperar el detalle del comprobante",
                        MessageBoxIcon.Error)
                Return Nothing
            End If
            myOrderDetails.Fecha = Fecha.Value.ToString
            myOrderDetails.Numero = Numero.Value.ToString
            myOrderDetails.Concepto = Concepto.Value.ToString
            myOrderDetails.Cheque = Cheque.Value.ToString
            myOrderDetails.Descripcion = Descripcion.Value.ToString
            myOrderDetails.TasaCambio = TasaCambio.Value.ToString
            myOrderDetails.Tipo = Tipo.Value.ToString
            myOrderDetails.Tipo1 = Tipo1.Value.ToString
            myOrderDetails.Moneda = Moneda.Value.ToString
            myOrderDetails.Factura = Factura.Value.ToString
            myOrderDetails.Recibo = Recibo.Value.ToString
            myOrderDetails.ChequeNombre = ChequeNombre.Value.ToString
            myOrderDetails.Pagara = Pagara.Value.ToString
            myOrderDetails.Ruc = Ruc.Value.ToString
            myOrderDetails.Proveedor = Proveedor.Value.ToString

            myOrderDetails.TipoX = TipoX.Value.ToString
            myOrderDetails.Factura1 = Factura1.Value.ToString
            myOrderDetails.FechaPago = FechaPago.Value.ToString
            myOrderDetails.FormaPago = FormaPago.Value.ToString

            myOrderDetails.Comp = Comp.Value
            myOrderDetails.Consecutivo = _Consecutivo.Value

            myOrderDetails.Detalles = myDataSet
            ' Return the DataSet
            Return myOrderDetails
            'Else
            '                Return Nothing
            'End If
        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 15/Dic/2005
        'Objetivo: Regresa los Comprobantes
        '*******************************************************

        'Public Function GetComprobantesList(ByVal fecha As String, ByVal Tipo As String, _
        '                                    ByVal Numero As String) As DataSet
        '    Dim DBConn As SqlConnection
        '    Dim DBCommand As SqlDataAdapter
        '    Dim dsFicha As New DataSet

        '    Dim conexion As New VB.SysContab.Rutinas
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    DBCommand = New SqlDataAdapter("_ComprobantesList", DBConn)

        '    DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    DBCommand.SelectCommand.Parameters.Add(pEmpresa)

        '    Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.NVarChar)
        '    _Fecha.Value = fecha
        '    DBCommand.SelectCommand.Parameters.Add(_Fecha)

        '    Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.NVarChar)
        '    _Tipo.Value = Tipo
        '    DBCommand.SelectCommand.Parameters.Add(_Tipo)

        '    Dim _Numero As New SqlParameter("@Numero", SqlDbType.NVarChar)
        '    _Numero.Value = ""
        '    DBCommand.SelectCommand.Parameters.Add(_Numero)

        '    Try
        '        DBCommand.Fill(dsFicha, "Comprobantes")
        '    Catch e As Exception

        '        MsgBox(e.Message)

        '    End Try

        '    DBConn.Close()

        '    Return dsFicha

        'End Function

        '*******************************************************
        ' Objetivo: Agrega una transaccion en el Catalogo de transacciones
        ' Autor: Bernardo Robelo
        ' Fecha: 16/Nov/2005
        '*******************************************************

        Public Shared Function AddCatalogoTrans123(ByVal Cuenta As String, _
                                     ByVal Debe As String, ByVal Haber As String, _
                                     ByVal Descripcion As String) As String

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas

            Dim cmd As New SqlCommand("_CatalogoTransAddItem", DBConnFacturas)

            '            Dim NoComp As String = GetNoComprobante()

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar, 50)
            _Cuenta.Value = Cuenta
            cmd.Parameters.Add(_Cuenta)

            Dim _Debe As New SqlParameter("@Debe", SqlDbType.Float)
            _Debe.Value = Debe
            cmd.Parameters.Add(_Debe)

            Dim _Haber As New SqlParameter("@Haber", SqlDbType.Float)
            _Haber.Value = Haber
            cmd.Parameters.Add(_Haber)

            Dim _Descripcion As New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)
            _Descripcion.Value = Descripcion
            cmd.Parameters.Add(_Descripcion)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            'Return NoComp

        End Function



        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 9/Nov/2005
        'Objetivo: Obtiene el ultimo No. comprobante
        '*******************************************************
        Public Shared Function GetNoComprobante(ByVal Fecha As String) As Double

            ' Create Instance of Connection and Command Object
            'Dim DBConn As SqlConnection
            'Dim conexion As New VB.SysContab.Rutinas()
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_ComprobanteGetNo", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Periodo As New SqlParameter("@Periodo", SqlDbType.Int)
            _Periodo.Value = PeriodosDB.Activo(Fecha)
            cmd.Parameters.Add(_Periodo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim parameterTotalCost As SqlParameter = New SqlParameter("@Comprobante", SqlDbType.Float, 8)
            parameterTotalCost.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterTotalCost)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            'Open the connection And execute the Command
            ''DBConn.Open()
            ''cmd.ExecuteNonQuery()
            ''DBConn.Close()


            ' Return the Total
            If parameterTotalCost.Value.ToString() <> "" Then
                Return CType(parameterTotalCost.Value, Double)
            Else
                Return 1
            End If

        End Function

        Public Shared Function NuevoComprobante(ByVal Fecha As String) As Double

            'Create Instance of Connection and Command Object
            Dim DBConn As New SqlConnection(Rutinas.AbrirConexion())
            Dim Conn As New Rutinas()

            Dim cmd As SqlCommand = New SqlCommand("_ComprobanteGetNo", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Periodo As New SqlParameter("@Periodo", SqlDbType.Int)
            _Periodo.Value = PeriodosDB.Activo(Fecha)
            cmd.Parameters.Add(_Periodo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim parameterTotalCost As SqlParameter = New SqlParameter("@Comprobante", SqlDbType.Float, 8)
            parameterTotalCost.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterTotalCost)

            Try
                'Open the connection And execute the Command
                DBConn.Open()
                cmd.ExecuteNonQuery()
                DBConn.Close()

                ' Return the Total
                If parameterTotalCost.Value.ToString() <> "" Then
                    Return CType(parameterTotalCost.Value, Double)
                Else
                    Return 1
                End If
            Catch ex As Exception
                XtraMsg($"ERROR: {ex.Message}", MessageBoxIcon.Error)
                Return 1
            End Try

        End Function

        Public Shared Function AddComprobanteDetalles1(ByVal CompNo As String, _
                             ByVal Cuenta As String, ByVal Concepto As String, _
                             ByVal Importe As String, _
                             ByVal NoChk As String, ByVal Tipo As String, ByVal DC As String, ByVal Factura As String, ByVal Recibo As String, ByVal Periodo As String, ByVal Fecha As String, ByVal Detalle As Integer) As String

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim cmd As New SqlCommand("_ComprobantesDetallesAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _CompNo As New SqlParameter("@CompNo", SqlDbType.NVarChar, 50)
            _CompNo.Value = CompNo
            cmd.Parameters.Add(_CompNo)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar, 50)
            _Cuenta.Value = Cuenta
            cmd.Parameters.Add(_Cuenta)

            Dim _Concepto As New SqlParameter("@Concepto", SqlDbType.NVarChar, 50)
            _Concepto.Value = Concepto
            cmd.Parameters.Add(_Concepto)

            Dim _Importe As New SqlParameter("@Importe", SqlDbType.Decimal)
            _Importe.Value = Importe
            cmd.Parameters.Add(_Importe)

            Dim _NoChk As New SqlParameter("@NoChk", SqlDbType.NVarChar, 50)
            _NoChk.Value = NoChk
            cmd.Parameters.Add(_NoChk)

            Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.NVarChar, 50)
            _Tipo.Value = Tipo
            cmd.Parameters.Add(_Tipo)

            Dim _DC As New SqlParameter("@DC", SqlDbType.NVarChar, 50)
            _DC.Value = DC
            cmd.Parameters.Add(_DC)

            Dim _PerID As New SqlParameter("@PerID", SqlDbType.NVarChar, 50)
            _PerID.Value = Periodo
            cmd.Parameters.Add(_PerID)

            Dim _FacturaID As New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            _FacturaID.Value = Factura
            cmd.Parameters.Add(_FacturaID)

            Dim _Recibo As New SqlParameter("@Recibo", SqlDbType.NVarChar, 50)
            _Recibo.Value = Recibo
            cmd.Parameters.Add(_Recibo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim _Detalle As New SqlParameter("@Detalle", SqlDbType.Int)
            _Detalle.Value = Detalle
            cmd.Parameters.Add(_Detalle)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function


        '*******************************************************
        ' Objetivo: Agrega comprobante
        ' Autor: Bernardo Robelo
        ' Fecha: 3/Nov/2005
        '*******************************************************

        'Public Shared Function AddComprobanteDetalles(ByVal CompNo As String, _
        '                             ByVal Cuenta As String, ByVal Concepto As String, _
        '                             ByVal Importe As String, _
        '                             ByVal NoChk As String, ByVal Tipo As String, ByVal DC As String, ByVal Factura As String, ByVal Recibo As String, ByVal Fecha As String, ByVal Detalle As Integer) As String

        '    ' Create Instance of Connection and Command Object
        '    'Dim conexion As New VB.SysContab.Rutinas()
        '    Dim cmd As New SqlCommand("_ComprobantesDetallesAdd", DBConnFacturas)

        '    ' Mark the Command as a SPROC
        '    cmd.CommandType = CommandType.StoredProcedure

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    cmd.Parameters.Add(pEmpresa)

        '    Dim _CompNo As New SqlParameter("@CompNo", SqlDbType.NVarChar, 50)
        '    _CompNo.Value = CompNo
        '    cmd.Parameters.Add(_CompNo)

        '    Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar, 50)
        '    _Cuenta.Value = Cuenta
        '    cmd.Parameters.Add(_Cuenta)

        '    Dim _Concepto As New SqlParameter("@Concepto", SqlDbType.NVarChar, 50)
        '    _Concepto.Value = Concepto
        '    cmd.Parameters.Add(_Concepto)

        '    Dim _Importe As New SqlParameter("@Importe", SqlDbType.Decimal)
        '    _Importe.Value = Importe
        '    cmd.Parameters.Add(_Importe)

        '    Dim _NoChk As New SqlParameter("@NoChk", SqlDbType.NVarChar, 50)
        '    _NoChk.Value = NoChk
        '    cmd.Parameters.Add(_NoChk)

        '    Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.NVarChar, 50)
        '    _Tipo.Value = Tipo
        '    cmd.Parameters.Add(_Tipo)

        '    Dim _DC As New SqlParameter("@DC", SqlDbType.NVarChar, 50)
        '    _DC.Value = DC
        '    cmd.Parameters.Add(_DC)

        '    Dim _PerID As New SqlParameter("@PerID", SqlDbType.NVarChar, 50)
        '    _PerID.Value = PeriodosDB.Activo(Fecha)
        '    cmd.Parameters.Add(_PerID)

        '    Dim _FacturaID As New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
        '    _FacturaID.Value = Factura
        '    cmd.Parameters.Add(_FacturaID)

        '    Dim _Recibo As New SqlParameter("@Recibo", SqlDbType.NVarChar, 50)
        '    _Recibo.Value = Recibo
        '    cmd.Parameters.Add(_Recibo)

        '    Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
        '    _Fecha.Value = Fecha
        '    cmd.Parameters.Add(_Fecha)

        '    Dim _Detalle As New SqlParameter("@Detalle", SqlDbType.Int)
        '    _Detalle.Value = Detalle
        '    cmd.Parameters.Add(_Detalle)

        '    cmd.Connection = DBConnFacturas
        '    cmd.Transaction = transaccionFacturas
        '    cmd.ExecuteNonQuery()    
        'End Function

        '*******************************************
        'Cambio hacer cheque
        'Oscar Valdivia 13/05/2009
        '*******************************************
        Public Shared Function AddComprobanteDetalles(ByVal CompNo As String,
                                      ByVal Cuenta As String, ByVal Concepto As String,
                                      ByVal Importe As String,
                                      ByVal NoChk As String, ByVal Tipo As String, ByVal DC As String,
                                      ByVal Factura As String, ByVal Recibo As String, ByVal Fecha As String,
                                      ByVal Detalle As Integer, Optional ByVal TipoT As Integer = 0,
                                      Optional ByVal ret As String = "", Optional IdProyecto As Integer = 0,
                                      Optional IdOrdenCompra As Integer = 0) As String

            ' Create Instance of Connection and Command Object
            'Dim conexion As New VB.SysContab.Rutinas()
            Dim cmd As New SqlCommand("_ComprobantesDetallesAdd", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _CompNo As New SqlParameter("@CompNo", SqlDbType.NVarChar, 50)
            _CompNo.Value = CompNo
            cmd.Parameters.Add(_CompNo)

            Dim _Cuenta As New SqlParameter("@Cuenta", SqlDbType.NVarChar, 50)
            _Cuenta.Value = Cuenta
            cmd.Parameters.Add(_Cuenta)

            Dim _Concepto As New SqlParameter("@Concepto", SqlDbType.NVarChar, 1024)
            _Concepto.Value = Concepto
            cmd.Parameters.Add(_Concepto)

            Dim _Importe As New SqlParameter("@Importe", SqlDbType.Decimal)
            _Importe.Value = Importe
            cmd.Parameters.Add(_Importe)

            Dim _NoChk As New SqlParameter("@NoChk", SqlDbType.NVarChar, 50)
            _NoChk.Value = NoChk
            cmd.Parameters.Add(_NoChk)

            Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.NVarChar, 50)
            _Tipo.Value = Tipo
            cmd.Parameters.Add(_Tipo)

            Dim _DC As New SqlParameter("@DC", SqlDbType.NVarChar, 50)
            _DC.Value = DC
            cmd.Parameters.Add(_DC)

            Dim _PerID As New SqlParameter("@PerID", SqlDbType.NVarChar, 50)
            _PerID.Value = PeriodosDB.Activo(Fecha)
            cmd.Parameters.Add(_PerID)

            Dim _FacturaID As New SqlParameter("@Factura", SqlDbType.NVarChar, 50)
            _FacturaID.Value = Factura
            cmd.Parameters.Add(_FacturaID)

            Dim _Recibo As New SqlParameter("@Recibo", SqlDbType.NVarChar, 50)
            _Recibo.Value = Recibo
            cmd.Parameters.Add(_Recibo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim _Detalle As New SqlParameter("@Detalle", SqlDbType.Int)
            _Detalle.Value = Detalle
            cmd.Parameters.Add(_Detalle)

            Dim _TipoT As New SqlParameter("@TipoT", SqlDbType.Int)
            _TipoT.Value = TipoT
            cmd.Parameters.Add(_TipoT)

            Dim _ret As New SqlParameter("@ret", SqlDbType.NVarChar, 50)
            _ret.Value = ret
            cmd.Parameters.Add(_ret)

            cmd.Parameters.AddWithValue("@IdProyecto", IdProyecto)
            cmd.Parameters.AddWithValue("@IdOrdenCompra", IdOrdenCompra)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Function

        '*******************************************************
        ' Objetivo: Agrega comprobante
        ' Autor: Bernardo Robelo
        ' Fecha: 3/Nov/2005
        '*******************************************************

        'Public Shared Function AddComprobante(ByVal TipoComp As Integer, _
        '                             ByVal TasaCambio As Double, ByVal concepto As String, _
        '                             ByVal TMoneda As String, ByVal PerID As String, _
        '                             ByVal compFecha As String, ByVal Deposito As String, _
        '                             ByVal ChequeNombre As String, _
        '                             ByVal Transferencia As Boolean, ByVal Pagara As String, _
        '                             ByVal Ruc As String, ByVal Tipo As Integer, ByVal Factura As String, _
        '                             ByVal FechaPago As String, ByVal FormaPago As Integer, ByVal Comp As Integer) As String

        '    ' Create Instance of Connection and Command Object
        '    'Dim conexion As New VB.SysContab.Rutinas()
        '    Dim cmd As New SqlCommand("_ComprobantesAdd", DBConnFacturas)

        '    Dim NoComp As Double = GetNoComprobante(compFecha)

        '    ' Mark the Command as a SPROC
        '    cmd.CommandType = CommandType.StoredProcedure

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    cmd.Parameters.Add(pEmpresa)

        '    Dim _TipoComp As New SqlParameter("@TipoComp", SqlDbType.Int)
        '    _TipoComp.Value = TipoComp
        '    cmd.Parameters.Add(_TipoComp)

        '    Dim _TasaCambio As New SqlParameter("@TasaCambio", SqlDbType.Float)
        '    _TasaCambio.Value = 1.0 'TasaCambio
        '    cmd.Parameters.Add(_TasaCambio)

        '    Dim _CompNo As New SqlParameter("@CompNo", SqlDbType.Int)
        '    _CompNo.Value = NoComp
        '    cmd.Parameters.Add(_CompNo)

        '    Dim _Moneda As New SqlParameter("@Moneda", SqlDbType.NVarChar, 20)
        '    _Moneda.Value = TMoneda
        '    cmd.Parameters.Add(_Moneda)

        '    Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
        '    _Fecha.Value = compFecha
        '    cmd.Parameters.Add(_Fecha)

        '    Dim _PerID As New SqlParameter("@PerID", SqlDbType.NVarChar, 20)
        '    _PerID.Value = PerID
        '    cmd.Parameters.Add(_PerID)

        '    Dim _Deposito As New SqlParameter("@Deposito", SqlDbType.NVarChar, 50)
        '    _Deposito.Value = Deposito
        '    cmd.Parameters.Add(_Deposito)

        '    Dim _CompConcepto As New SqlParameter("@CompConcepto", SqlDbType.NVarChar, 1500)
        '    _CompConcepto.Value = concepto
        '    cmd.Parameters.Add(_CompConcepto)

        '    Dim _ChequeNombre As New SqlParameter("@ChequeNombre", SqlDbType.NVarChar, 100)
        '    _ChequeNombre.Value = ChequeNombre
        '    cmd.Parameters.Add(_ChequeNombre)

        '    Dim _Transferencia As New SqlParameter("@Transferencia", SqlDbType.Bit)
        '    _Transferencia.Value = Transferencia
        '    cmd.Parameters.Add(_Transferencia)

        '    Dim _Pagara As New SqlParameter("@Pagara", SqlDbType.NVarChar)
        '    _Pagara.Value = Pagara
        '    cmd.Parameters.Add(_Pagara)

        '    Dim _Ruc As New SqlParameter("@Ruc", SqlDbType.NVarChar)
        '    _Ruc.Value = Ruc
        '    cmd.Parameters.Add(_Ruc)

        '    Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.Int)
        '    _Tipo.Value = Tipo
        '    cmd.Parameters.Add(_Tipo)

        '    Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar)
        '    _Factura.Value = Factura
        '    cmd.Parameters.Add(_Factura)

        '    Dim _FechaPago As New SqlParameter("@FechaPago", SqlDbType.DateTime)
        '    _FechaPago.Value = FechaPago
        '    cmd.Parameters.Add(_FechaPago)

        '    Dim _FormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)
        '    _FormaPago.Value = FormaPago
        '    cmd.Parameters.Add(_FormaPago)

        '    Dim _Comp As New SqlParameter("@Comp", SqlDbType.Int)
        '    _Comp.Value = Comp
        '    cmd.Parameters.Add(_Comp)

        '    cmd.Connection = DBConnFacturas
        '    cmd.Transaction = transaccionFacturas
        '    cmd.ExecuteNonQuery()

        '    Return NoComp

        'End Function

        '*****************************************
        'Nuevo diseño hacer cheque
        'Oscar Valdivia 13/05/2009
        '*****************************************

        '-------------------------------------------------------------------------------------------

        Public Shared Function GetNoComprobante_NoTrans(ByVal Fecha As String) As Double

            ' Create Instance of Connection and Command Object
            Dim DBConn As SqlConnection
            'Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            Dim cmd As SqlCommand = New SqlCommand("_ComprobanteGetNo", DBConn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Periodo As New SqlParameter("@Periodo", SqlDbType.Int)
            _Periodo.Value = PeriodosDB.Activo(Fecha)
            cmd.Parameters.Add(_Periodo)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = Fecha
            cmd.Parameters.Add(_Fecha)

            Dim parameterTotalCost As SqlParameter = New SqlParameter("@Comprobante", SqlDbType.Float, 8)
            parameterTotalCost.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterTotalCost)

            'cmd.Connection = DBConnFacturas
            'cmd.Transaction = transaccionFacturas
            'cmd.ExecuteNonQuery()

            ' Open the connection and execute the Command
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

            ' Return the Total
            If parameterTotalCost.Value.ToString() <> "" Then
                Return CType(parameterTotalCost.Value, Double)
            Else
                Return 1
            End If

        End Function

        Public Shared Function AddComprobante(ByVal TipoComp As Integer, _
                                         ByVal TasaCambio As Double, ByVal concepto As String, _
                                         ByVal TMoneda As String, ByVal PerID As String, _
                                         ByVal compFecha As String, ByVal Deposito As String, _
                                         ByVal ChequeNombre As String, _
                                         ByVal Transferencia As Boolean, ByVal Pagara As String, _
                                         ByVal Ruc As String, ByRef Tipo As Integer, ByVal Factura As String, _
                                         ByVal FechaPago As String, ByVal FormaPago As Integer, ByVal Comp As Integer, _
                                         Optional ByVal Cedula As String = "", Optional ByVal CentroCosto As Integer = 0, _
                                         Optional ByVal Anticipo As Integer = 0, Optional ByVal Concecutivo As String = "0", _
                                         Optional ByVal TipoLiq As Integer = 0, _
                                         Optional ByVal CajaId As Integer = 0) As String

            ' Create Instance of Connection and Command Object
            'Dim conexion As New VB.SysContab.Rutinas()
            Dim cmd As New SqlCommand("_ComprobantesAdd", DBConnFacturas)

            Dim NoComp As Double = GetNoComprobante(compFecha)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _TipoComp As New SqlParameter("@TipoComp", SqlDbType.Int)
            _TipoComp.Value = TipoComp
            cmd.Parameters.Add(_TipoComp)

            Dim _TasaCambio As New SqlParameter("@TasaCambio", SqlDbType.Float)
            _TasaCambio.Value = TasaCambio
            cmd.Parameters.Add(_TasaCambio)

            Dim _CompNo As New SqlParameter("@CompNo", SqlDbType.Int)
            _CompNo.Value = NoComp
            cmd.Parameters.Add(_CompNo)

            Dim _Moneda As New SqlParameter("@Moneda", SqlDbType.NVarChar, 20)
            _Moneda.Value = TMoneda
            cmd.Parameters.Add(_Moneda)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = compFecha
            cmd.Parameters.Add(_Fecha)

            Dim _PerID As New SqlParameter("@PerID", SqlDbType.NVarChar, 20)
            _PerID.Value = PerID
            cmd.Parameters.Add(_PerID)

            Dim _Deposito As New SqlParameter("@Deposito", SqlDbType.NVarChar, 50)
            _Deposito.Value = Deposito
            cmd.Parameters.Add(_Deposito)

            Dim _CompConcepto As New SqlParameter("@CompConcepto", SqlDbType.NVarChar, 1500)
            _CompConcepto.Value = concepto
            cmd.Parameters.Add(_CompConcepto)

            Dim _ChequeNombre As New SqlParameter("@ChequeNombre", SqlDbType.NVarChar, 256)
            _ChequeNombre.Value = ChequeNombre
            cmd.Parameters.Add(_ChequeNombre)

            Dim _Transferencia As New SqlParameter("@Transferencia", SqlDbType.Bit)
            _Transferencia.Value = Transferencia
            cmd.Parameters.Add(_Transferencia)

            Dim _Pagara As New SqlParameter("@Pagara", SqlDbType.NVarChar)
            _Pagara.Value = Pagara
            cmd.Parameters.Add(_Pagara)

            Dim _Ruc As New SqlParameter("@Ruc", SqlDbType.NVarChar)
            _Ruc.Value = Ruc
            cmd.Parameters.Add(_Ruc)

            Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.Int)
            _Tipo.Value = Tipo
            _Tipo.Direction = ParameterDirection.InputOutput
            cmd.Parameters.Add(_Tipo)

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            _Factura.Value = Factura
            cmd.Parameters.Add(_Factura)

            Dim _FechaPago As New SqlParameter("@FechaPago", SqlDbType.DateTime)
            _FechaPago.Value = FechaPago
            cmd.Parameters.Add(_FechaPago)

            Dim _FormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)
            _FormaPago.Value = FormaPago
            cmd.Parameters.Add(_FormaPago)

            Dim _Comp As New SqlParameter("@Comp", SqlDbType.Int)
            _Comp.Value = Comp
            cmd.Parameters.Add(_Comp)

            Dim _Cedula As New SqlParameter("@Cedula", SqlDbType.NVarChar)
            _Cedula.Value = Cedula
            cmd.Parameters.Add(_Cedula)

            Dim _CentroCosto As New SqlParameter("@CentroCosto", SqlDbType.NVarChar)
            _CentroCosto.Value = CentroCosto
            cmd.Parameters.Add(_CentroCosto)

            Dim _Anticipo As New SqlParameter("@Anticipo", SqlDbType.Int)
            _Anticipo.Value = Anticipo
            cmd.Parameters.Add(_Anticipo)

            Dim _Concecutivo As New SqlParameter("@Concecutivo", SqlDbType.NVarChar)
            _Concecutivo.Value = Concecutivo
            cmd.Parameters.Add(_Concecutivo)

            Dim _TipoLiq As New SqlParameter("@TipoLiq", SqlDbType.Int)
            _TipoLiq.Value = TipoLiq
            cmd.Parameters.Add(_TipoLiq)

            Dim _Caja As New SqlParameter("@Caja", SqlDbType.Int)
            _Caja.Value = CajaId
            cmd.Parameters.Add(_Caja)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
            Tipo = _Tipo.Value

            Return NoComp
        End Function

        Public Shared Function AddComprobante_NoTrans(ByVal TipoComp As Integer, _
                                         ByVal TasaCambio As Double, ByVal concepto As String, _
                                         ByVal TMoneda As String, ByVal PerID As String, _
                                         ByVal compFecha As String, ByVal Deposito As String, _
                                         ByVal ChequeNombre As String, _
                                         ByVal Transferencia As Boolean, ByVal Pagara As String, _
                                         ByVal Ruc As String, ByRef Tipo As Integer, ByVal Factura As String, _
                                         ByVal FechaPago As String, ByVal FormaPago As Integer, ByVal Comp As Integer, _
                                         Optional ByVal Cedula As String = "", Optional ByVal CentroCosto As Integer = 0, _
                                         Optional ByVal Anticipo As Integer = 0, Optional ByVal Concecutivo As String = "0", _
                                         Optional ByVal TipoLiq As Integer = 0, _
                                         Optional ByVal CajaId As Integer = 0) As String


            'Dim conexion As New VB.SysContab.Rutinas

            Dim DBConn = New SqlConnection(Rutinas.AbrirConexion())
            Dim cmd As SqlCommand = New SqlCommand("_ComprobantesAdd", DBConn)

            'Dim DBConn As SqlConnection            
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())
            ' Create Instance of Connection and Command Object
            'Dim conexion As New VB.SysContab.Rutinas()
            'Dim cmd As New SqlCommand("_ComprobantesAdd", DBConn)


            Dim NoComp As Double = GetNoComprobante_NoTrans(compFecha)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _TipoComp As New SqlParameter("@TipoComp", SqlDbType.Int)
            _TipoComp.Value = TipoComp
            cmd.Parameters.Add(_TipoComp)

            Dim _TasaCambio As New SqlParameter("@TasaCambio", SqlDbType.Float)
            _TasaCambio.Value = TasaCambio
            cmd.Parameters.Add(_TasaCambio)

            Dim _CompNo As New SqlParameter("@CompNo", SqlDbType.Int)
            _CompNo.Value = NoComp
            cmd.Parameters.Add(_CompNo)

            Dim _Moneda As New SqlParameter("@Moneda", SqlDbType.NVarChar, 20)
            _Moneda.Value = TMoneda
            cmd.Parameters.Add(_Moneda)

            Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
            _Fecha.Value = compFecha
            cmd.Parameters.Add(_Fecha)

            Dim _PerID As New SqlParameter("@PerID", SqlDbType.NVarChar, 20)
            _PerID.Value = PerID
            cmd.Parameters.Add(_PerID)

            Dim _Deposito As New SqlParameter("@Deposito", SqlDbType.NVarChar, 50)
            _Deposito.Value = Deposito
            cmd.Parameters.Add(_Deposito)

            Dim _CompConcepto As New SqlParameter("@CompConcepto", SqlDbType.NVarChar, 1500)
            _CompConcepto.Value = concepto
            cmd.Parameters.Add(_CompConcepto)

            Dim _ChequeNombre As New SqlParameter("@ChequeNombre", SqlDbType.NVarChar, 100)
            _ChequeNombre.Value = ChequeNombre
            cmd.Parameters.Add(_ChequeNombre)

            Dim _Transferencia As New SqlParameter("@Transferencia", SqlDbType.Bit)
            _Transferencia.Value = Transferencia
            cmd.Parameters.Add(_Transferencia)

            Dim _Pagara As New SqlParameter("@Pagara", SqlDbType.NVarChar)
            _Pagara.Value = Pagara
            cmd.Parameters.Add(_Pagara)

            Dim _Ruc As New SqlParameter("@Ruc", SqlDbType.NVarChar)
            _Ruc.Value = Ruc
            cmd.Parameters.Add(_Ruc)

            Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.Int)
            _Tipo.Value = Tipo
            _Tipo.Direction = ParameterDirection.InputOutput
            cmd.Parameters.Add(_Tipo)

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            _Factura.Value = Factura
            cmd.Parameters.Add(_Factura)

            Dim _FechaPago As New SqlParameter("@FechaPago", SqlDbType.DateTime)
            _FechaPago.Value = FechaPago
            cmd.Parameters.Add(_FechaPago)

            Dim _FormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)
            _FormaPago.Value = FormaPago
            cmd.Parameters.Add(_FormaPago)

            Dim _Comp As New SqlParameter("@Comp", SqlDbType.Int)
            _Comp.Value = Comp
            cmd.Parameters.Add(_Comp)

            Dim _Cedula As New SqlParameter("@Cedula", SqlDbType.NVarChar)
            _Cedula.Value = Cedula
            cmd.Parameters.Add(_Cedula)

            Dim _CentroCosto As New SqlParameter("@CentroCosto", SqlDbType.NVarChar)
            _CentroCosto.Value = CentroCosto
            cmd.Parameters.Add(_CentroCosto)

            Dim _Anticipo As New SqlParameter("@Anticipo", SqlDbType.Int)
            _Anticipo.Value = Anticipo
            cmd.Parameters.Add(_Anticipo)

            Dim _Concecutivo As New SqlParameter("@Concecutivo", SqlDbType.NVarChar)
            _Concecutivo.Value = Concecutivo
            cmd.Parameters.Add(_Concecutivo)

            Dim _TipoLiq As New SqlParameter("@TipoLiq", SqlDbType.Int)
            _TipoLiq.Value = TipoLiq
            cmd.Parameters.Add(_TipoLiq)

            Dim _Caja As New SqlParameter("@Caja", SqlDbType.Int)
            _Caja.Value = CajaId
            cmd.Parameters.Add(_Caja)

            Try
                DBConn.Open()
                'cmd.Connection = DBConnFacturas
                'cmd.Transaction = transaccionFacturas
                cmd.ExecuteNonQuery()
                DBConn.Close()

                Tipo = _Tipo.Value
                Return NoComp
            Catch ex As Exception
                XtraMsg(ex.Message & vbCrLf & "SP: _ComprobantesAdd")
                DBConn.Close()
            End Try

        End Function

        '--------------------------------------------------------------
        'Public Shared Function AddComprobante(ByVal TipoComp As Integer, _
        '                                 ByVal TasaCambio As Double, ByVal concepto As String, _
        '                                 ByVal TMoneda As String, ByVal PerID As String, _
        '                                 ByVal compFecha As String, ByVal Deposito As String, _
        '                                 ByVal ChequeNombre As String, _
        '                                 ByVal Transferencia As Boolean, ByVal Pagara As String, _
        '                                 ByVal Ruc As String, ByVal Tipo As Integer, ByVal Factura As String, _
        '                                 ByVal FechaPago As String, ByVal FormaPago As Integer, ByVal Comp As Integer, _
        '                                 Optional ByVal Cedula As String = "", Optional ByVal CentroCosto As Integer = 0, _
        '                                 Optional ByVal Anticipo As Integer = 0, Optional ByVal Concecutivo As String = "0", _
        '                                 Optional ByVal TipoLiq As Integer = 0, _
        '                                 Optional ByVal CajaId As Integer = 0) As String

        '    ' Create Instance of Connection and Command Object
        '    'Dim conexion As New VB.SysContab.Rutinas()
        '    Dim cmd As New SqlCommand("_ComprobantesAdd", DBConnFacturas)

        '    Dim NoComp As Double = GetNoComprobante(compFecha)

        '    ' Mark the Command as a SPROC
        '    cmd.CommandType = CommandType.StoredProcedure

        '    Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
        '    pEmpresa.Value = EmpresaActual
        '    cmd.Parameters.Add(pEmpresa)

        '    Dim _TipoComp As New SqlParameter("@TipoComp", SqlDbType.Int)
        '    _TipoComp.Value = TipoComp
        '    cmd.Parameters.Add(_TipoComp)

        '    Dim _TasaCambio As New SqlParameter("@TasaCambio", SqlDbType.Float)
        '    _TasaCambio.Value = TasaCambio
        '    cmd.Parameters.Add(_TasaCambio)

        '    Dim _CompNo As New SqlParameter("@CompNo", SqlDbType.Int)
        '    _CompNo.Value = NoComp
        '    cmd.Parameters.Add(_CompNo)

        '    Dim _Moneda As New SqlParameter("@Moneda", SqlDbType.NVarChar, 20)
        '    _Moneda.Value = TMoneda
        '    cmd.Parameters.Add(_Moneda)

        '    Dim _Fecha As New SqlParameter("@Fecha", SqlDbType.DateTime)
        '    _Fecha.Value = compFecha
        '    cmd.Parameters.Add(_Fecha)

        '    Dim _PerID As New SqlParameter("@PerID", SqlDbType.NVarChar, 20)
        '    _PerID.Value = PerID
        '    cmd.Parameters.Add(_PerID)

        '    Dim _Deposito As New SqlParameter("@Deposito", SqlDbType.NVarChar, 50)
        '    _Deposito.Value = Deposito
        '    cmd.Parameters.Add(_Deposito)

        '    Dim _CompConcepto As New SqlParameter("@CompConcepto", SqlDbType.NVarChar, 1500)
        '    _CompConcepto.Value = concepto
        '    cmd.Parameters.Add(_CompConcepto)

        '    Dim _ChequeNombre As New SqlParameter("@ChequeNombre", SqlDbType.NVarChar, 100)
        '    _ChequeNombre.Value = ChequeNombre
        '    cmd.Parameters.Add(_ChequeNombre)

        '    Dim _Transferencia As New SqlParameter("@Transferencia", SqlDbType.Bit)
        '    _Transferencia.Value = Transferencia
        '    cmd.Parameters.Add(_Transferencia)

        '    Dim _Pagara As New SqlParameter("@Pagara", SqlDbType.NVarChar)
        '    _Pagara.Value = Pagara
        '    cmd.Parameters.Add(_Pagara)

        '    Dim _Ruc As New SqlParameter("@Ruc", SqlDbType.NVarChar)
        '    _Ruc.Value = Ruc
        '    cmd.Parameters.Add(_Ruc)

        '    Dim _Tipo As New SqlParameter("@Tipo", SqlDbType.Int)
        '    _Tipo.Value = Tipo
        '    _Tipo.Direction = ParameterDirection.InputOutput
        '    cmd.Parameters.Add(_Tipo)

        '    Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar)
        '    _Factura.Value = Factura
        '    cmd.Parameters.Add(_Factura)

        '    Dim _FechaPago As New SqlParameter("@FechaPago", SqlDbType.DateTime)
        '    _FechaPago.Value = FechaPago
        '    cmd.Parameters.Add(_FechaPago)

        '    Dim _FormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)
        '    _FormaPago.Value = FormaPago
        '    cmd.Parameters.Add(_FormaPago)

        '    Dim _Comp As New SqlParameter("@Comp", SqlDbType.Int)
        '    _Comp.Value = Comp
        '    cmd.Parameters.Add(_Comp)

        '    Dim _Cedula As New SqlParameter("@Cedula", SqlDbType.NVarChar)
        '    _Cedula.Value = Cedula
        '    cmd.Parameters.Add(_Cedula)

        '    Dim _CentroCosto As New SqlParameter("@CentroCosto", SqlDbType.NVarChar)
        '    _CentroCosto.Value = CentroCosto
        '    cmd.Parameters.Add(_CentroCosto)

        '    Dim _Anticipo As New SqlParameter("@Anticipo", SqlDbType.Int)
        '    _Anticipo.Value = Anticipo
        '    cmd.Parameters.Add(_Anticipo)

        '    Dim _Concecutivo As New SqlParameter("@Concecutivo", SqlDbType.NVarChar)
        '    _Concecutivo.Value = Concecutivo
        '    cmd.Parameters.Add(_Concecutivo)

        '    Dim _TipoLiq As New SqlParameter("@TipoLiq", SqlDbType.Int)
        '    _TipoLiq.Value = TipoLiq
        '    cmd.Parameters.Add(_TipoLiq)

        '    Dim _Caja As New SqlParameter("@Caja", SqlDbType.Int)
        '    _Caja.Value = CajaId
        '    cmd.Parameters.Add(_Caja)

        '    cmd.Connection = DBConnFacturas
        '    cmd.Transaction = transaccionFacturas
        '    cmd.ExecuteNonQuery()
        '    Tipo = _Tipo.Value

        '    Return NoComp
        'End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 10/Nov/2005
        'Objetivo: Regresa la lista de los Catalogos de Bancos
        '*******************************************************

        Public Function GetCatalogosBancos(ByVal TipoCompr As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoComprobantesList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            Dim pTipoCompr As New SqlParameter("@TipoCompr", SqlDbType.NVarChar)
            pTipoCompr.Value = TipoCompr
            DBCommand.SelectCommand.Parameters.Add(pTipoCompr)

            DBCommand.Fill(dsFicha, "TipoComprobantes")

            DBConn.Close()

            Return dsFicha

        End Function


        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 9/Nov/2005
        'Objetivo: Obtiene la tasa de Cambio dada una Fecha
        '*******************************************************

        Public Function GetTasaCambio(ByVal FechaHoy As String) As Decimal

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim conn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_WTasaCambio", conn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _FechaHoy As SqlParameter = New SqlParameter("@FechaHoy", SqlDbType.NVarChar)
            _FechaHoy.Value = FechaHoy
            cmd.Parameters.Add(_FechaHoy)

            Dim parameterTotalCost As SqlParameter = New SqlParameter("@TotalCost", SqlDbType.Money, 8)
            parameterTotalCost.Direction = ParameterDirection.Output
            cmd.Parameters.Add(parameterTotalCost)

            ' Open the connection and execute the Command
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            ' Return the Total
            If parameterTotalCost.Value.ToString() <> "" Then
                Return CType(parameterTotalCost.Value, Decimal)
            Else
                Return 0.0
            End If

        End Function


        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 16/Dic/2005
        'Objetivo: Tipos de Comprobantes
        '*******************************************************

        Public Shared Function GetTiposComprobantes() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoComprobantesListTodos", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            DBCommand.Fill(dsFicha, "TipoComprobantes")

            DBConn.Close()

            Return dsFicha

        End Function


        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 9/Nov/2005
        'Objetivo: Regresa los detalles de un Extra-Financiamiento dado un ExtraFin_ID
        '*******************************************************

        Public Shared Function GetTiposComprobantes(ByVal TipoCompr As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoComprobantesList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            Dim pTipoCompr As New SqlParameter("@TipoCompr", SqlDbType.NVarChar)
            pTipoCompr.Value = TipoCompr
            DBCommand.SelectCommand.Parameters.Add(pTipoCompr)

            DBCommand.Fill(dsFicha, "TipoComprobantes")

            DBConn.Close()

            Return dsFicha

        End Function
        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 9/Nov/2005
        'Objetivo: Regresa los detalles de un Extra-Financiamiento dado un ExtraFin_ID
        '*******************************************************

        Public Shared Function GetTComprobantes(ByVal TipoCompr As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TCompCkList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            Dim pTipoCompr As New SqlParameter("@Tipo", SqlDbType.NVarChar)
            pTipoCompr.Value = TipoCompr
            DBCommand.SelectCommand.Parameters.Add(pTipoCompr)

            DBCommand.Fill(dsFicha, "TipoComprobantes")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Shared Sub FacturasComprasSaldo(ByVal Factura As String, ByVal Proveedor As String, ByVal Abono As Double)

            ' Create Instance of Connection and Command Object

            Dim cmd As New SqlCommand("_FacturasComprasSaldo", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _Factura As New SqlParameter("@Factura", SqlDbType.NVarChar)
            _Factura.Value = Factura
            cmd.Parameters.Add(_Factura)

            Dim _Proveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            _Proveedor.Value = Proveedor
            cmd.Parameters.Add(_Proveedor)

            Dim _Abono As New SqlParameter("@Abono", SqlDbType.Float)
            _Abono.Value = Abono
            cmd.Parameters.Add(_Abono)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()
        End Sub

        Public Shared Function GetComprobantes_DescuadradosList(ByVal Periodo As Integer, ByVal Mes As String) As DataTable

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataTable

            DBConn = New SqlConnection(Rutinas.AbrirConexion())
            '
            DBCommand = New SqlDataAdapter("_ComprobantesDescuadradosList", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim _Periodo As New SqlParameter("@Periodo", SqlDbType.Int)
            _Periodo.Value = Periodo
            DBCommand.SelectCommand.Parameters.Add(_Periodo)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            _Mes.Value = Mes
            DBCommand.SelectCommand.Parameters.Add(_Mes)

            Try
                DBCommand.Fill(dsFicha)
            Catch e As Exception
                MsgBox(e.Message)
            End Try
            DBConn.Close()

            Return dsFicha
        End Function


        Public Shared Function ValidarConcecutivo(Concecutivo As String, Comp_Tipo As Integer, _
                                                  Mes As Integer, Per_Id As Integer) As DataTable

            Dim v As New Connect(VB.SysContab.Rutinas.AbrirConexion)
            v.AddParameter("Concecutivo", SqlDbType.NVarChar, 100, ParameterDirection.Input, Concecutivo)
            v.AddParameter("Comp_Tipo", SqlDbType.Int, 5, ParameterDirection.Input, Comp_Tipo)
            v.AddParameter("Mes", SqlDbType.Int, 5, ParameterDirection.Input, Mes)
            v.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            v.AddParameter("Per_Id", SqlDbType.Int, 5, ParameterDirection.Input, Per_Id)

            Try
                Return v.EjecutarComando("JAR_ValidarNumeroConcecutivo")
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                Return Nothing
            End Try

        End Function

        Public Shared Sub ImprimirComprobante(Comp_No As Double, Per_Id As Integer, Fecha As Date)

            'Dim Cadena As String
            'Dim Temp As Boolean = False
            'Dim Data() As Byte

            'Try
            '    Data = CType(ObtieneDatos("SELECT ChequeD FROM Formatos WHERE Tipo = 17 AND Empresa = " & EmpresaActual).Rows(0).Item(0), Byte())

            '    Temp = True
            '    Dim Tamano As Integer
            '    Tamano = Data.GetUpperBound(0)
            '    Cadena = Application.StartupPath & "\rptComprobante.repx"

            '    If File.Exists(Cadena) Then Kill(Cadena)
            '    Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            '    Archivo.Write(Data, 0, Tamano)
            '    Archivo.Close()
            'Catch ex As Exception
            '    Temp = False
            'End Try

            ShowSplash("Imprimiendo...")

            Dim Temp As Boolean = db_Formatos.FormatoImpreso(17, "rptComprobante")

            Dim DSComp As New DataSet

            Dim DA As New SqlDataAdapter("_ComprobantesImpresoALL", VB.SysContab.Rutinas.AbrirConexion)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure

            DA.SelectCommand.Parameters.Add("@ComprNO", SqlDbType.NChar)
            DA.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int)
            DA.SelectCommand.Parameters.Add("@PerID", SqlDbType.Int)
            DA.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime)

            DA.SelectCommand.Parameters("@Empresa").Value = EmpresaActual
            DA.SelectCommand.Parameters("@ComprNO").Value = Comp_No
            DA.SelectCommand.Parameters("@PerID").Value = Per_Id
            DA.SelectCommand.Parameters("@Fecha").Value = Fecha.Date

            DA.Fill(DSComp, "Comprobantes")

            Dim DTDistrubucion As DataTable = ObtieneDatos("JAR_GetComprobanteDistribucion " & Comp_No & "," & _
                                                          "" & Per_Id & "," & _
                                                          "" & Fecha.Date.Month & "," & EmpresaActual)
            Dim rptDistribucin As New rptComprobanteDistribucion
            rptDistribucin.DataSource = DTDistrubucion

            Dim rpt As rptComprobantesALL

            If Temp = True Then
                rpt = XtraReport.FromFile(Application.StartupPath & "\rptComprobante.repx", True)
            Else
                rpt = New rptComprobantesALL
            End If

            rpt.ver = True
            rpt.gfDistribucion.Visible = IIf(DTDistrubucion.Rows.Count = 0, False, True)
            rpt.XrSubreport1.ReportSource = rptDistribucin

            VistaPreviaDX(rpt, DSComp.Tables(0), "Comprobante No. " & Comp_No.ToString())

            HideSplash()
            'rpt.DataSource = DSComp.Tables(0)

            'rpt.ShowPrintMarginsWarning = False
            'rpt.BringToFront()
            'rpt.ShowRibbonPreview()
        End Sub


    End Class

End Namespace

