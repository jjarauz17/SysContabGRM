Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    Public Class EmpresasDetails
        Public Codigo As String
        Public Nombre As String
        Public Ciudad As String
        Public Pais As String
        Public Telefono As String
        Public Contador As String
        Public Mes As String
        Public Anio As String
        Public Fecha_Cierre As String
        Public Fecha_InicioAF As Date
        Public Fecha_CierreAF As Date
        Public Decimales As String
        Public Mayor As String
        Public SC01 As String
        Public SC02 As String
        Public SC03 As String
        Public SC04 As String
        Public SC05 As String
        Public SC06 As String
        Public SC07 As String
        Public SC08 As String
        Public SC09 As String
        Public MonedaBase As String
        Public MonedaSalario As String
        Public Espacio As Boolean
        Public GMT As Integer
        Public Pais_ID As Integer
        Public Cot_Editable As Boolean

        Public UMESPAGOVAC As String
        Public UMESPAGOAGU As String
        Public MESPAGOAGUINALDO As String
        Public MESCALCULODEPRECIACION As String
        Public Representante As String
        Public CedulaRepresentante As String

        Public IdGMT As String
        Public Region As String
        Public Exento_OC As Boolean
        Public ValidarTCambio As Boolean
        Public ValidarFV As Boolean
        Public ValidarLimite As Boolean
        Public Ruc As String
        Public NombreComercial As String
        Public CobrosEditable As Boolean
        Public FacturasCuotas As Boolean
    End Class

    Public Class EmpresasDB

        Public Shared Function GetEmpresasAsignadas(ID As Integer) As DataTable
            Return ObtieneDatos("JAR_GetEmpresaAsignadas", ID)
        End Function


        Public Shared Function GetLogoEmpresa() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()
            Dim i As Integer

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetLogoEmpresa", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(Empresa)

            'Agregar la imagen
            Dim Archivo As String, oImagen As Image
            Dim ms As New MemoryStream()
            Dim arrImage() As Byte

            Try
                DBCommand.Fill(dsFicha, "_GetLogoEmpresa")
                dsFicha.Tables("_GetlogoEmpresa").Columns.Add("LogoPic", System.Type.GetType("System.Byte[]"))
                For i = 0 To dsFicha.Tables(0).Rows.Count - 1
                    Archivo = Application.StartupPath & "\" & dsFicha.Tables(0).Rows(i)("logo")
                    If Not File.Exists(Archivo) Then
                        GoTo seguir
                    End If
                    oImagen = New Bitmap(Archivo)
                    oImagen.Save(ms, oImagen.RawFormat)
                    arrImage = ms.GetBuffer
                    dsFicha.Tables(0).Rows(i)("logoPic") = arrImage
seguir:         Next
                DBConn.Close()
                dsFicha.Tables(0).Columns.Remove("logo")
                dsFicha.Tables(0).Columns.Item("logopic").ColumnName = "logo"
                Return dsFicha
                Exit Function
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                DBConn.Close()
                Return Nothing
            End Try
        End Function

        Public Shared Function GetLogoEmpresaPath() As String
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()


            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetLogoEmpresa", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim Empresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Empresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(Empresa)

            'Agregar la imagen
            Dim Archivo As String = String.Empty
            Try
                DBCommand.Fill(dsFicha, "_GetLogoEmpresa")
                If dsFicha.Tables(0).Rows.Count = 1 Then
                    Archivo = Application.StartupPath & "\" & dsFicha.Tables(0).Rows(0)("logo")
                End If
                DBConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                DBConn.Close()
            End Try
            Return Archivo
        End Function

        Public Function EmpresasXUsuariosBuscar(ByVal Usuario As String, ByVal Password As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpresasXUsuariosBuscar", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Usuario As New SqlParameter("@UsrLogin", SqlDbType.NVarChar)
            Dim _Password As New SqlParameter("@UsrPassword", SqlDbType.NVarChar)
            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.NVarChar)

            _Usuario.Value = Usuario
            _Password.Value = Password
            _Empresa.Value = Empresa

            DBCommand.SelectCommand.Parameters.Add(_Usuario)
            DBCommand.SelectCommand.Parameters.Add(_Password)
            DBCommand.SelectCommand.Parameters.Add(_Empresa)

            DBCommand.Fill(dsFicha, "Empresas")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function EmpresasXUsuarios(ByVal Usuario As String, ByVal Password As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpresasXUsuarios", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _Usuario As New SqlParameter("@UsrLogin", SqlDbType.NVarChar)
            Dim _Password As New SqlParameter("@UsrPassword", SqlDbType.NVarChar)

            _Usuario.Value = Usuario
            _Password.Value = Password

            DBCommand.SelectCommand.Parameters.Add(_Usuario)
            DBCommand.SelectCommand.Parameters.Add(_Password)

            DBCommand.Fill(dsFicha, "Empresas")

            DBConn.Close()

            Return dsFicha
        End Function


        Public Function List() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EmpresasList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Empresas")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function Inicio() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_Inicio", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            'Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            'Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            'pIdent.Value = Filtro
            'pIdent2.Value = Empresa
            'DBCommand.SelectCommand.Parameters.Add(pIdent)
            'DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Empresas")

            DBConn.Close()

            Return dsFicha
        End Function

        Public Function GetListReporte(ByVal Filtro As String, ByVal Empresa As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas()
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_GetListEmpresasReporte", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent As New SqlParameter("@Filtro", SqlDbType.NVarChar)
            Dim pIdent2 As New SqlParameter("@Empresa", SqlDbType.Int)

            pIdent.Value = Filtro
            pIdent2.Value = Empresa
            DBCommand.SelectCommand.Parameters.Add(pIdent)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)

            DBCommand.Fill(dsFicha, "Empresas")

            DBConn.Close()

            Return dsFicha
        End Function


        Public Shared Function GetEmpresa(ByVal Codigo As String) As DataSet

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsEmpresas As New DataSet
            ' Dim Details As New EmpresasDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Empresas WHERE Codigo = '" & Codigo & "'", DBConn)

            DBCommand.Fill(dsEmpresas, "Empresas")


            DBConn.Close()

            Return dsEmpresas

        End Function

        Public Shared Function GetDetails(ByVal Codigo As String) As EmpresasDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsEmpresas As New DataSet
            Dim Details As New EmpresasDetails

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT * FROM Empresas WHERE Codigo = '" & Codigo & "'", DBConn)

            DBCommand.Fill(dsEmpresas, "Empresas")

            If dsEmpresas.Tables("Empresas").Rows.Count = 1 Then
                Details.Codigo = dsEmpresas.Tables("Empresas").Rows(0).Item("Codigo").ToString
                Details.Nombre = dsEmpresas.Tables("Empresas").Rows(0).Item("Nombre").ToString
                Details.Ciudad = dsEmpresas.Tables("Empresas").Rows(0).Item("Ciudad").ToString
                Details.Pais = dsEmpresas.Tables("Empresas").Rows(0).Item("Pais").ToString
                Details.Telefono = dsEmpresas.Tables("Empresas").Rows(0).Item("Telefono").ToString
                Details.Contador = dsEmpresas.Tables("Empresas").Rows(0).Item("Contador").ToString
                Details.Mes = dsEmpresas.Tables("Empresas").Rows(0).Item("Mes").ToString
                Details.Anio = dsEmpresas.Tables("Empresas").Rows(0).Item("Anio").ToString
                Details.Fecha_Cierre = dsEmpresas.Tables("Empresas").Rows(0).Item("Fecha_CierreAF").ToString
                Details.Fecha_InicioAF = dsEmpresas.Tables("Empresas").Rows(0).Item("Fecha_InicioAF")
                Details.Fecha_CierreAF = dsEmpresas.Tables("Empresas").Rows(0).Item("Fecha_CierreAF")

                Details.Decimales = dsEmpresas.Tables("Empresas").Rows(0).Item("Decimales").ToString

                Details.Mayor = dsEmpresas.Tables("Empresas").Rows(0).Item("Mayor").ToString
                Details.SC01 = dsEmpresas.Tables("Empresas").Rows(0).Item("SC01").ToString
                Details.SC02 = dsEmpresas.Tables("Empresas").Rows(0).Item("SC02").ToString
                Details.SC03 = dsEmpresas.Tables("Empresas").Rows(0).Item("SC03").ToString
                Details.SC04 = dsEmpresas.Tables("Empresas").Rows(0).Item("SC04").ToString
                Details.SC05 = dsEmpresas.Tables("Empresas").Rows(0).Item("SC05").ToString
                Details.SC06 = dsEmpresas.Tables("Empresas").Rows(0).Item("SC06").ToString
                Details.SC07 = dsEmpresas.Tables("Empresas").Rows(0).Item("SC07").ToString
                Details.SC08 = dsEmpresas.Tables("Empresas").Rows(0).Item("SC08").ToString
                Details.SC09 = dsEmpresas.Tables("Empresas").Rows(0).Item("SC09").ToString
                Details.SC09 = dsEmpresas.Tables("Empresas").Rows(0).Item("SC09").ToString

                Details.MonedaBase = dsEmpresas.Tables("Empresas").Rows(0).Item("emp_monedabase")
                Details.MonedaSalario = dsEmpresas.Tables("Empresas").Rows(0).Item("emp_monedasalario")
                Details.Espacio = dsEmpresas.Tables("Empresas").Rows(0).Item("Espacio").ToString
                Details.GMT = dsEmpresas.Tables("Empresas").Rows(0).Item("EMPR_GMT")
                Details.Pais_ID = dsEmpresas.Tables("Empresas").Rows(0).Item("Pais_ID")

                Details.UMESPAGOVAC = dsEmpresas.Tables("Empresas").Rows(0).Item("empr_umpv")
                Details.UMESPAGOAGU = dsEmpresas.Tables("Empresas").Rows(0).Item("empr_umpa")
                Details.MESPAGOAGUINALDO = dsEmpresas.Tables("Empresas").Rows(0).Item("empr_mpa")
                Details.Representante = dsEmpresas.Tables("Empresas").Rows(0).Item("representante")
                Details.CedulaRepresentante = dsEmpresas.Tables("Empresas").Rows(0).Item("rep_cedula")

                Details.Cot_Editable = dsEmpresas.Tables("Empresas").Rows(0).Item("Cot_Editable")
                Details.IdGMT = dsEmpresas.Tables("Empresas").Rows(0).Item("IdGMT")
                Details.Region = dsEmpresas.Tables("Empresas").Rows(0).Item("Region")
                Details.Exento_OC = dsEmpresas.Tables("Empresas").Rows(0).Item("OC_Exento")
                Details.ValidarTCambio = dsEmpresas.Tables("Empresas").Rows(0).Item("ValidarTCambio")
                Details.ValidarFV = dsEmpresas.Tables("Empresas").Rows(0).Item("ValidarFacturasVencidas")
                Details.ValidarLimite = dsEmpresas.Tables("Empresas").Rows(0).Item("ValidarLimiteCredito")
                Details.Ruc = IsNull(dsEmpresas.Tables("Empresas").Rows(0).Item("Ruc"), "")
                Details.NombreComercial = IsNull(dsEmpresas.Tables("Empresas").Rows(0).Item("NombreComercial"), "")
                Details.CobrosEditable = dsEmpresas.Tables("Empresas").Rows(0).Item("CobrosEditable")
                Details.FacturasCuotas = dsEmpresas.Tables("Empresas").Rows(0).Item("FacturasCuotas")

            End If

            DBConn.Close()
            Return Details

        End Function

        Public Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre, Ciudad, Pais, Contador, Telefono, Pais_ID FROM EMPRESAS", DBConn)
            DBCommand.Fill(dsFicha, "EMPRESAS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListBuscar(ByVal Filtro As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter

            Dim dsFicha As New DataSet


            Dim conexion As New VB.SysContab.Rutinas

            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("SELECT Codigo, Nombre, Ciudad, Pais, Contador, Telefono , Pais_ID FROM EMPRESAS WHERE Nombre Like '%" & Filtro & "%'", DBConn)
            DBCommand.Fill(dsFicha, "EMPRESAS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Function GetListCodigo(ByVal Filtro As String, ByVal Tipo As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet


            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("Select CodGrup as [Código], Nombre, Nivel, Total From GRUPOS WHERE Tipo = '" & Tipo & "' AND CodGrup ='" & Filtro & "'", DBConn)
            DBCommand.Fill(dsFicha, "GRUPOS")

            DBConn.Close()

            Return dsFicha

        End Function

        Public Sub Delete(ByVal Codigo As String)

            ' Crea una instancia de conexion y un comando SQL
            Dim cmd As New SqlCommand
            Dim DBConn As SqlConnection

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            ' Se define el tipo de comando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM EMPRESAS WHERE Codigo = '" & Codigo & "'"

            'Se asigna conexion al comando y se abre conexion 
            cmd.Connection = DBConn
            DBConn.Open()
            cmd.ExecuteNonQuery()
            DBConn.Close()

        End Sub

        'Public Function AddItem(ByVal Nombre As String, ByVal Ciudad As String, ByVal Pais As String, ByVal Telefono As String, _
        '                        ByVal Contador As String, ByVal Mes As String, ByVal Anio As String, ByVal Fecha_Cierre As String, _
        '                        ByVal Mayor As String, ByVal SC01 As String, ByVal SC02 As String, ByVal SC03 As String, ByVal SC04 As String, _
        '                        ByVal SC05 As String, ByVal SC06 As String, ByVal SC07 As String, ByVal SC08 As String, ByVal SC09 As String)

        '    ' Crea una instancia de conexion y un comando SQL
        '    Dim cmd As New SqlCommand()
        '    Dim DBConn As SqlConnection

        '    Dim conexion As New VB.SysContab.Rutinas()
        '    DBConn = New SqlConnection(Rutinas.AbrirConexion())

        '    ' Se define el tipo de comando

        '    cmd.CommandType = CommandType.Text
        '    cmd.CommandText = "INSERT INTO EMPRESAS(Nombre, Ciudad, Pais, Telefono, Contador, Mes, Anio, Fecha_CierreAF, Mayor, SC01, SC02, SC03, SC04, SC05, SC06, SC07, SC08, SC09) " & _
        '                "Values(" & "'" & Nombre & "','" & Ciudad & "','" & Pais & "','" & Telefono & "','" & Contador & "','" & Mes & "','" & Anio & "','" & Fecha_Cierre & "','" & Mayor & "','" & SC01 & "','" & SC02 & "','" & SC03 & "','" & SC04 & "','" & SC05 & "','" & SC06 & "','" & SC07 & "','" & SC08 & "','" & SC09 & "')"
        '    'Try
        '    'Se asigna conexion al comando y se abre conexion 
        '    cmd.Connection = DBConn
        '    DBConn.Open()
        '    cmd.ExecuteNonQuery()
        '    DBConn.Close()
        '    'Catch ex As Exception
        '    'MsgBox(ex.Message)
        '    'End Try

        'End Function

        Public Shared Function AddItem(ByVal Nombre As String, ByVal Ciudad As String, ByVal Pais As String, ByVal Telefono As String, _
                        ByVal Contador As String, ByVal Mes As String, ByVal Anio As String, ByVal Fecha_Cierre As String, _
                        ByVal Mayor As String, ByVal SC01 As String, ByVal SC02 As String, ByVal SC03 As String, ByVal SC04 As String, _
                        ByVal SC05 As String, ByVal SC06 As String, ByVal SC07 As String, ByVal SC08 As String, ByVal SC09 As String, ByVal MonedaBase As String, ByVal MonedaSalario As String, _
                        ByVal Iva As String, ByVal IRProducto As String, ByVal IRServicio As String, _
                        ByVal IRVentas As String, ByVal IRMonto As String, ByVal Inatec As String, _
                        ByVal PresPorcMin As String, ByVal FacturaDigitos As String, _
                        ByVal FacturaNumero As String, ByVal SeriesMultiples As Boolean, ByVal ReciboDigitos As String, _
                        ByVal ReciboNumero As String, ByVal OrdenClienteNumero As String, _
                        ByVal CotizacionNumero As String, ByVal PedidoNumero As String, _
                        ByVal OrdenCompraNumero As String, ByVal DevolucionClienteNumero As String, _
                        ByVal DevolucionProveedorNumero As String, ByVal Espacio As Boolean, _
                        ByVal Bodega As String, ByVal GMT As Integer, ByVal Pais_ID As Integer, ByVal Decimales As Integer, ByVal Liquidacion As Boolean) As Integer
            'Optional ByVal Logo As String = "") As Integer


            'Dim DBConn As SqlConnection
            'Dim DBCommand As SqlDataAdapter
            'Dim dsFicha As New DataSet()

            Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())

            'DBCommand = New SqlDataAdapter("_EmpresaAddItem", DBConn)
            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim cmd As SqlCommand = New SqlCommand("_EmpresaAddItem", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure


            Dim _Nombre As New SqlParameter("@Nombre", SqlDbType.NVarChar)
            _Nombre.Value = Nombre
            cmd.Parameters.Add(_Nombre)

            Dim _Ciudad As New SqlParameter("@Ciudad", SqlDbType.NVarChar)
            _Ciudad.Value = Ciudad
            cmd.Parameters.Add(_Ciudad)

            Dim _Pais As New SqlParameter("@Pais", SqlDbType.NVarChar)
            _Pais.Value = Pais
            cmd.Parameters.Add(_Pais)

            Dim _Pais_ID As New SqlParameter("@Pais_ID", SqlDbType.NVarChar)
            _Pais_ID.Value = Pais_ID
            cmd.Parameters.Add(_Pais_ID)

            Dim _Telefono As New SqlParameter("@Telefono", SqlDbType.NVarChar)
            _Telefono.Value = Telefono
            cmd.Parameters.Add(_Telefono)

            Dim _Contador As New SqlParameter("@Contador", SqlDbType.NVarChar)
            _Contador.Value = Contador
            cmd.Parameters.Add(_Contador)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            _Mes.Value = Mes
            cmd.Parameters.Add(_Mes)

            Dim _Anio As New SqlParameter("@Anio", SqlDbType.NVarChar)
            _Anio.Value = Anio
            cmd.Parameters.Add(_Anio)

            Dim _Fecha_Cierre As New SqlParameter("@Fecha_Cierre", SqlDbType.DateTime)
            _Fecha_Cierre.Value = CDate(DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Year, 1, New Date(Anio, Mes, 1)))) 'conexion.FechaANSIComp(Fecha_Cierre)
            cmd.Parameters.Add(_Fecha_Cierre)

            Dim FECHA_INICIOAF As New SqlParameter("@FECHA_INICIOAF", SqlDbType.DateTime)
            FECHA_INICIOAF.Value = CDate(New Date(Anio, Mes, 1))
            cmd.Parameters.Add(FECHA_INICIOAF)

            Dim _Mayor As New SqlParameter("@Mayor", SqlDbType.NVarChar)
            _Mayor.Value = Mayor
            cmd.Parameters.Add(_Mayor)

            Dim _SC01 As New SqlParameter("@SC01", SqlDbType.NVarChar)
            _SC01.Value = SC01
            cmd.Parameters.Add(_SC01)

            Dim _SC02 As New SqlParameter("@SC02", SqlDbType.NVarChar)
            _SC02.Value = SC02
            cmd.Parameters.Add(_SC02)

            Dim _SC03 As New SqlParameter("@SC03", SqlDbType.NVarChar)
            _SC03.Value = SC03
            cmd.Parameters.Add(_SC03)

            Dim _SC04 As New SqlParameter("@SC04", SqlDbType.NVarChar)
            _SC04.Value = SC04
            cmd.Parameters.Add(_SC04)

            Dim _SC05 As New SqlParameter("@SC05", SqlDbType.NVarChar)
            _SC05.Value = SC05
            cmd.Parameters.Add(_SC05)

            Dim _SC06 As New SqlParameter("@SC06", SqlDbType.NVarChar)
            _SC06.Value = SC06
            cmd.Parameters.Add(_SC06)

            Dim _SC07 As New SqlParameter("@SC07", SqlDbType.NVarChar)
            _SC07.Value = SC07
            cmd.Parameters.Add(_SC07)

            Dim _SC08 As New SqlParameter("@SC08", SqlDbType.NVarChar)
            _SC08.Value = SC08
            cmd.Parameters.Add(_SC08)

            Dim _SC09 As New SqlParameter("@SC09", SqlDbType.NVarChar)
            _SC09.Value = SC09
            cmd.Parameters.Add(_SC09)

            'Dim _Logo As New SqlParameter("@Logo", SqlDbType.NVarChar)
            '_Logo.Value = Logo
            'cmd.Parameters.Add(_Logo)

            If MonedaBase = Nothing Then
                MonedaBase = 0
            End If

            Dim _MonedaBase As New SqlParameter("@MonedaBase", SqlDbType.Int)
            _MonedaBase.Value = MonedaBase
            cmd.Parameters.Add(_MonedaBase)

            If MonedaSalario = Nothing Then
                MonedaSalario = 0
            End If

            Dim _MonedaSalario As New SqlParameter("@MonedaSalario", SqlDbType.Int)
            _MonedaSalario.Value = MonedaSalario
            cmd.Parameters.Add(_MonedaSalario)

            Dim _Iva As New SqlParameter("@Iva", SqlDbType.Float)
            _Iva.Value = Iva
            cmd.Parameters.Add(_Iva)

            Dim _IRProducto As New SqlParameter("@IRProducto", SqlDbType.Float)
            _IRProducto.Value = IRProducto
            cmd.Parameters.Add(_IRProducto)

            Dim _IRServicio As New SqlParameter("@IRServicio", SqlDbType.Float)
            _IRServicio.Value = IRServicio
            cmd.Parameters.Add(_IRServicio)

            Dim _IRVentas As New SqlParameter("@IRVentas", SqlDbType.Float)
            _IRVentas.Value = IRVentas
            cmd.Parameters.Add(_IRVentas)

            Dim _IRMonto As New SqlParameter("@IRMonto", SqlDbType.Float)
            _IRMonto.Value = IRMonto
            cmd.Parameters.Add(_IRMonto)

            Dim _Inatec As New SqlParameter("@Inatec", SqlDbType.Float)
            _Inatec.Value = Inatec
            cmd.Parameters.Add(_Inatec)

            Dim _PresPorcMin As New SqlParameter("@PresPorcMin", SqlDbType.Float)
            _PresPorcMin.Value = PresPorcMin
            cmd.Parameters.Add(_PresPorcMin)

            Dim _FacturaDigitos As New SqlParameter("@FacturaDigitos", SqlDbType.Int)
            _FacturaDigitos.Value = FacturaDigitos
            cmd.Parameters.Add(_FacturaDigitos)

            Dim _FacturaNumero As New SqlParameter("@FacturaNumero", SqlDbType.Float)
            _FacturaNumero.Value = FacturaNumero
            cmd.Parameters.Add(_FacturaNumero)

            Dim _SeriesMultiples As New SqlParameter("@SeriesMultiples", SqlDbType.Bit)
            _SeriesMultiples.Value = SeriesMultiples
            cmd.Parameters.Add(_SeriesMultiples)

            Dim _ReciboDigitos As New SqlParameter("@ReciboDigitos", SqlDbType.Int)
            _ReciboDigitos.Value = ReciboDigitos
            cmd.Parameters.Add(_ReciboDigitos)

            Dim _ReciboNumero As New SqlParameter("@ReciboNumero", SqlDbType.Float)
            _ReciboNumero.Value = ReciboNumero
            cmd.Parameters.Add(_ReciboNumero)

            Dim _OrdenClienteNumero As New SqlParameter("@OrdenClienteNumero", SqlDbType.Float)
            _OrdenClienteNumero.Value = OrdenClienteNumero
            cmd.Parameters.Add(_OrdenClienteNumero)

            Dim _CotizacionNumero As New SqlParameter("@CotizacionNumero", SqlDbType.Float)
            _CotizacionNumero.Value = CotizacionNumero
            cmd.Parameters.Add(_CotizacionNumero)

            Dim _PedidoNumero As New SqlParameter("@PedidoNumero", SqlDbType.Float)
            _PedidoNumero.Value = PedidoNumero
            cmd.Parameters.Add(_PedidoNumero)

            Dim _OrdenCompraNumero As New SqlParameter("@OrdenCompraNumero", SqlDbType.Float)
            _OrdenCompraNumero.Value = OrdenCompraNumero
            cmd.Parameters.Add(_OrdenCompraNumero)

            Dim _DevolucionClienteNumero As New SqlParameter("@DevolucionClienteNumero", SqlDbType.Float)
            _DevolucionClienteNumero.Value = DevolucionClienteNumero
            cmd.Parameters.Add(_DevolucionClienteNumero)

            Dim _DevolucionProveedorNumero As New SqlParameter("@DevolucionProveedorNumero", SqlDbType.Float)
            _DevolucionProveedorNumero.Value = DevolucionProveedorNumero
            cmd.Parameters.Add(_DevolucionProveedorNumero)

            Dim _Espacio As New SqlParameter("@Espacio", SqlDbType.Bit)
            _Espacio.Value = Espacio
            cmd.Parameters.Add(_Espacio)

            Dim _Bodega As New SqlParameter("@Bodega", SqlDbType.NVarChar, 50)
            _Bodega.Value = "" 'Bodega
            cmd.Parameters.Add(_Bodega)

            Dim _GMT As New SqlParameter("@GMT", SqlDbType.Int)
            _GMT.Value = GMT
            cmd.Parameters.Add(_GMT)

            'Numero de Decimales en Productos/Inventario
            Dim _DecimalesProd As New SqlParameter("@Decimales", SqlDbType.Int)
            _DecimalesProd.Value = Decimales
            cmd.Parameters.Add(_DecimalesProd)

            Dim _Liquidacion As New SqlParameter("@Liquidacion", SqlDbType.Bit)
            _Liquidacion.Value = Liquidacion
            cmd.Parameters.Add(_Liquidacion)


            Dim _Empresa As New SqlParameter("@Empresa ", SqlDbType.Int)
            _Empresa.Direction = ParameterDirection.Output
            _Empresa.Value = 0
            cmd.Parameters.Add(_Empresa)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            Return _Empresa.Value

            'Try
            '    DBConn.Open()
            '    DBCommand.SelectCommand.ExecuteNonQuery()
            '    DBConn.Close()

            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Return -1
            'End Try

            ' Return 0

        End Function

        Public Shared Sub Update(ByVal Codigo As String, ByVal Nombre As String, ByVal Ciudad As String, ByVal Pais As String, ByVal Telefono As String,
                                ByVal Contador As String, ByVal Mes As String, ByVal Anio As String, ByVal Fecha_Cierre As String,
                                ByVal Mayor As String, ByVal SC01 As String, ByVal SC02 As String, ByVal SC03 As String, ByVal SC04 As String,
                                ByVal SC05 As String, ByVal SC06 As String, ByVal SC07 As String, ByVal SC08 As String, ByVal SC09 As String, ByVal MonedaBase As String, ByVal MonedaSalario As String,
                                ByVal Iva As String, ByVal IRProducto As String, ByVal IRServicio As String,
                                ByVal IRVentas As String, ByVal IRMonto As String, ByVal Inatec As String,
                                ByVal PresPorcMin As String, ByVal FacturaDigitos As String,
                                ByVal RequisaNumero As String, ByVal SeriesMultiples As Boolean, ByVal ReciboDigitos As String,
                                ByVal ReciboNumero As String, ByVal OrdenClienteNumero As String,
                                ByVal CotizacionNumero As String, ByVal PedidoNumero As String,
                                ByVal OrdenCompraNumero As String, ByVal DevolucionClienteNumero As String,
                                ByVal DevolucionProveedorNumero As String, ByVal Espacio As Boolean,
                                ByVal Bodega As String, ByVal GMT As Integer, ByVal Pais_ID As Integer, ByVal decimales As Integer,
                                ByVal Liquidacion As Boolean, ByVal LineasFactura As Integer, IdGMT As String, Region As String,
                                Exento_OC As Integer, ValidarTCambio As Integer, ValidarVencidas As Integer, ValidarLimite As Integer,
                                CobroEditable As Integer,
                                FacturasCuotas As Integer)

            Dim conexion As New VB.SysContab.Rutinas
            'DBConn = New SqlConnection(Rutinas.AbrirConexion())
            'DBCommand = New SqlDataAdapter("_EmpresaAddItem", DBConn)
            'DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim cmd As SqlCommand = New SqlCommand("_EmpresaUpdate", DBConnFacturas)
            cmd.CommandType = CommandType.StoredProcedure


            Dim _Nombre As New SqlParameter("@Nombre", SqlDbType.NVarChar)
            _Nombre.Value = Nombre
            cmd.Parameters.Add(_Nombre)

            Dim _Ciudad As New SqlParameter("@Ciudad", SqlDbType.NVarChar)
            _Ciudad.Value = Ciudad
            cmd.Parameters.Add(_Ciudad)

            Dim _Pais As New SqlParameter("@Pais", SqlDbType.NVarChar)
            _Pais.Value = Pais
            cmd.Parameters.Add(_Pais)

            Dim _Pais_ID As New SqlParameter("@Pais_ID", SqlDbType.NVarChar)
            _Pais_ID.Value = Pais_ID
            cmd.Parameters.Add(_Pais_ID)

            Dim _Telefono As New SqlParameter("@Telefono", SqlDbType.NVarChar)
            _Telefono.Value = Telefono
            cmd.Parameters.Add(_Telefono)

            Dim _Contador As New SqlParameter("@Contador", SqlDbType.NVarChar)
            _Contador.Value = Contador
            cmd.Parameters.Add(_Contador)

            Dim _Mes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            _Mes.Value = Mes
            cmd.Parameters.Add(_Mes)

            Dim _Anio As New SqlParameter("@Anio", SqlDbType.NVarChar)
            _Anio.Value = Anio
            cmd.Parameters.Add(_Anio)

            'Dim _Fecha_Cierre As New SqlParameter("@Fecha_Cierre", SqlDbType.NVarChar)
            '_Fecha_Cierre.Value = conexion.FechaANSIComp(Fecha_Cierre)
            'cmd.Parameters.Add(_Fecha_Cierre)

            'Dim FECHA_INICIOAF As New SqlParameter("@FECHA_INICIOAF", SqlDbType.NVarChar)
            'FECHA_INICIOAF.Value = DateAdd(DateInterval.Year, -1, Fecha_Cierre)  '"1/1/1900"
            'cmd.Parameters.Add(FECHA_INICIOAF)

            Dim _Mayor As New SqlParameter("@Mayor", SqlDbType.NVarChar)
            _Mayor.Value = Mayor
            cmd.Parameters.Add(_Mayor)

            Dim _SC01 As New SqlParameter("@SC01", SqlDbType.NVarChar)
            _SC01.Value = SC01
            cmd.Parameters.Add(_SC01)

            Dim _SC02 As New SqlParameter("@SC02", SqlDbType.NVarChar)
            _SC02.Value = SC02
            cmd.Parameters.Add(_SC02)

            Dim _SC03 As New SqlParameter("@SC03", SqlDbType.NVarChar)
            _SC03.Value = SC03
            cmd.Parameters.Add(_SC03)

            Dim _SC04 As New SqlParameter("@SC04", SqlDbType.NVarChar)
            _SC04.Value = SC04
            cmd.Parameters.Add(_SC04)

            Dim _SC05 As New SqlParameter("@SC05", SqlDbType.NVarChar)
            _SC05.Value = SC05
            cmd.Parameters.Add(_SC05)

            Dim _SC06 As New SqlParameter("@SC06", SqlDbType.NVarChar)
            _SC06.Value = SC06
            cmd.Parameters.Add(_SC06)

            Dim _SC07 As New SqlParameter("@SC07", SqlDbType.NVarChar)
            _SC07.Value = SC07
            cmd.Parameters.Add(_SC07)

            Dim _SC08 As New SqlParameter("@SC08", SqlDbType.NVarChar)
            _SC08.Value = SC08
            cmd.Parameters.Add(_SC08)

            Dim _SC09 As New SqlParameter("@SC09", SqlDbType.NVarChar)
            _SC09.Value = SC09
            cmd.Parameters.Add(_SC09)

            If MonedaBase = Nothing Then
                MonedaBase = 0
            End If

            Dim _MonedaBase As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            _MonedaBase.Value = MonedaBase
            cmd.Parameters.Add(_MonedaBase)

            If MonedaSalario = Nothing Then
                MonedaSalario = 0
            End If

            Dim _MonedaSalario As New SqlParameter("@MonedaSalario", SqlDbType.NVarChar)
            _MonedaSalario.Value = MonedaSalario
            cmd.Parameters.Add(_MonedaSalario)

            Dim _Iva As New SqlParameter("@Iva", SqlDbType.Float)
            _Iva.Value = Iva
            cmd.Parameters.Add(_Iva)

            Dim _IRProducto As New SqlParameter("@IRProducto", SqlDbType.Float)
            _IRProducto.Value = IRProducto
            cmd.Parameters.Add(_IRProducto)

            Dim _IRServicio As New SqlParameter("@IRServicio", SqlDbType.Float)
            _IRServicio.Value = IRServicio
            cmd.Parameters.Add(_IRServicio)

            Dim _IRVentas As New SqlParameter("@IRVentas", SqlDbType.Float)
            _IRVentas.Value = IRVentas
            cmd.Parameters.Add(_IRVentas)

            Dim _IRMonto As New SqlParameter("@IRMonto", SqlDbType.Float)
            _IRMonto.Value = IRMonto
            cmd.Parameters.Add(_IRMonto)

            Dim _Inatec As New SqlParameter("@Inatec", SqlDbType.Float)
            _Inatec.Value = Inatec
            cmd.Parameters.Add(_Inatec)

            Dim _PresPorcMin As New SqlParameter("@PresPorcMin", SqlDbType.Float)
            _PresPorcMin.Value = PresPorcMin
            cmd.Parameters.Add(_PresPorcMin)

            Dim _Empresa As New SqlParameter("@Empresa", SqlDbType.Float)
            _Empresa.Value = Codigo
            cmd.Parameters.Add(_Empresa)

            Dim _FacturaDigitos As New SqlParameter("@FacturaDigitos", SqlDbType.Int)
            _FacturaDigitos.Value = FacturaDigitos
            cmd.Parameters.Add(_FacturaDigitos)

            Dim _FacturaNumero As New SqlParameter("@FacturaNumero", SqlDbType.Float)
            _FacturaNumero.Value = RequisaNumero
            cmd.Parameters.Add(_FacturaNumero)

            Dim _SeriesMultiples As New SqlParameter("@SeriesMultiples", SqlDbType.Bit)
            _SeriesMultiples.Value = SeriesMultiples
            cmd.Parameters.Add(_SeriesMultiples)

            Dim _ReciboDigitos As New SqlParameter("@ReciboDigitos", SqlDbType.Int)
            _ReciboDigitos.Value = ReciboDigitos
            cmd.Parameters.Add(_ReciboDigitos)

            Dim _ReciboNumero As New SqlParameter("@ReciboNumero", SqlDbType.Float)
            _ReciboNumero.Value = ReciboNumero
            cmd.Parameters.Add(_ReciboNumero)

            Dim _OrdenClienteNumero As New SqlParameter("@OrdenClienteNumero", SqlDbType.Float)
            _OrdenClienteNumero.Value = OrdenClienteNumero
            cmd.Parameters.Add(_OrdenClienteNumero)

            Dim _CotizacionNumero As New SqlParameter("@CotizacionNumero", SqlDbType.Float)
            _CotizacionNumero.Value = CotizacionNumero
            cmd.Parameters.Add(_CotizacionNumero)

            Dim _PedidoNumero As New SqlParameter("@PedidoNumero", SqlDbType.Float)
            _PedidoNumero.Value = PedidoNumero
            cmd.Parameters.Add(_PedidoNumero)

            Dim _OrdenCompraNumero As New SqlParameter("@OrdenCompraNumero", SqlDbType.Float)
            _OrdenCompraNumero.Value = OrdenCompraNumero
            cmd.Parameters.Add(_OrdenCompraNumero)

            Dim _DevolucionClienteNumero As New SqlParameter("@DevolucionClienteNumero", SqlDbType.Float)
            _DevolucionClienteNumero.Value = DevolucionClienteNumero
            cmd.Parameters.Add(_DevolucionClienteNumero)

            Dim _DevolucionProveedorNumero As New SqlParameter("@DevolucionProveedorNumero", SqlDbType.Float)
            _DevolucionProveedorNumero.Value = DevolucionProveedorNumero
            cmd.Parameters.Add(_DevolucionProveedorNumero)

            Dim _Espacio As New SqlParameter("@Espacio", SqlDbType.Bit)
            _Espacio.Value = Espacio
            cmd.Parameters.Add(_Espacio)

            Dim _Bodega As New SqlParameter("@Bodega", SqlDbType.NVarChar, 50)
            _Bodega.Value = Bodega
            cmd.Parameters.Add(_Bodega)

            Dim _GMT As New SqlParameter("@GMT", SqlDbType.Int)
            _GMT.Value = GMT
            cmd.Parameters.Add(_GMT)

            'Numero de Decimales en Productos/Inventario
            Dim _DecimalesProd As New SqlParameter("@Decimales", SqlDbType.Int)
            _DecimalesProd.Value = decimales
            cmd.Parameters.Add(_DecimalesProd)

            Dim _Liquidacion As New SqlParameter("@Liquidacion", SqlDbType.Bit)
            _Liquidacion.Value = Liquidacion
            cmd.Parameters.Add(_Liquidacion)

            Dim _LineasFactura As New SqlParameter("@LineasFactura", SqlDbType.Int)
            _LineasFactura.Value = LineasFactura
            cmd.Parameters.Add(_LineasFactura)

            cmd.Parameters.AddWithValue("@IdGMT", IdGMT)
            cmd.Parameters.AddWithValue("@Region", Region)
            cmd.Parameters.AddWithValue("@Exento_OC", Exento_OC)
            cmd.Parameters.AddWithValue("@ValidarTCambio", ValidarTCambio)
            cmd.Parameters.AddWithValue("@ValidarVencidas", ValidarVencidas)
            cmd.Parameters.AddWithValue("@ValidarLimite", ValidarLimite)
            cmd.Parameters.AddWithValue("@CobrosEditable", CobroEditable)
            cmd.Parameters.AddWithValue("@FacturasCuotas", FacturasCuotas)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            'Try
            '    DBConn.Open()
            '    DBCommand.SelectCommand.ExecuteNonQuery()
            '    DBConn.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Return -1
            'End Try

        End Sub
    End Class
End Namespace
