Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Namespace VB.SysContab


Public Class ReportesCrossTabDB


        Public Shared Function FacturasComprasCrossTab(ByVal Tipo As String, ByVal Mes As String, _
                                    ByVal Fecha1 As String, ByVal Fecha2 As String, _
                                    ByVal Proveedor As String, ByVal CodArticulo As String, _
                                    ByVal Articulo As String, ByVal FacRango1 As String, _
                                    ByVal FacRango2 As String, ByVal TipoFac2 As String, _
                                    ByVal TipoArt As String, ByVal ArtMin As String, _
                                    ByVal ArtMax As String, ByVal FormaPago As String, _
                                    ByVal Orden As Integer, ByVal TipoProducto As String, ByVal EmpresaActual As String) As DataSet
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            DBCommand = New SqlDataAdapter("_FacturasComprasListCrossTab", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pTipo As New SqlParameter("@TipoFac", SqlDbType.NVarChar)
            Dim pMes As New SqlParameter("@Mes", SqlDbType.NVarChar)
            Dim pFecha1 As New SqlParameter("@Fecha1", SqlDbType.NVarChar)
            Dim pFecha2 As New SqlParameter("@Fecha2", SqlDbType.NVarChar)
            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.NVarChar)
            Dim pCodArticulo As New SqlParameter("@CodArticulo", SqlDbType.NVarChar)
            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            Dim pTipoArt As New SqlParameter("@TipoArt", SqlDbType.NVarChar)
            Dim pFacRango1 As New SqlParameter("@FacRango1", SqlDbType.Float)
            Dim pFacRango2 As New SqlParameter("@FacRango2", SqlDbType.Float)
            Dim pTipoFac2 As New SqlParameter("@TipoFac2", SqlDbType.NVarChar)
            Dim pArtMin As New SqlParameter("@ArtMin", SqlDbType.Float)
            Dim pArtMAx As New SqlParameter("@ArtMax", SqlDbType.Float)
            Dim pFormaPago As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            Dim pOrden As New SqlParameter("@Orden", SqlDbType.Int)
            Dim _TipoProducto As New SqlParameter("@Tipo", SqlDbType.Int)

            pEmpresa.Value = EmpresaActual
            pTipo.Value = Tipo
            pTipoFac2.Value = TipoFac2
            pMes.Value = Mes
            pFecha1.Value = Fecha1
            pFecha2.Value = Fecha2
            pProveedor.Value = Proveedor
            pCodArticulo.Value = CodArticulo
            pArticulo.Value = Articulo
            pTipoArt.Value = TipoArt
            pFacRango1.Value = FacRango1
            pFacRango2.Value = FacRango2
            pArtMin.Value = ArtMin
            pArtMAx.Value = ArtMax
            pFormaPago.Value = FormaPago
            pOrden.Value = Orden
            _TipoProducto.Value = TipoProducto

            DBCommand.SelectCommand.Parameters.Add(pTipo)
            DBCommand.SelectCommand.Parameters.Add(pTipoFac2)
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)
            DBCommand.SelectCommand.Parameters.Add(pMes)
            DBCommand.SelectCommand.Parameters.Add(pFecha1)
            DBCommand.SelectCommand.Parameters.Add(pFecha2)
            DBCommand.SelectCommand.Parameters.Add(pProveedor)
            DBCommand.SelectCommand.Parameters.Add(pCodArticulo)
            DBCommand.SelectCommand.Parameters.Add(pArticulo)
            DBCommand.SelectCommand.Parameters.Add(pTipoArt)
            DBCommand.SelectCommand.Parameters.Add(pFacRango1)
            DBCommand.SelectCommand.Parameters.Add(pFacRango2)
            DBCommand.SelectCommand.Parameters.Add(pArtMin)
            DBCommand.SelectCommand.Parameters.Add(pArtMAx)
            DBCommand.SelectCommand.Parameters.Add(pFormaPago)
            DBCommand.SelectCommand.Parameters.Add(pOrden)
            DBCommand.SelectCommand.Parameters.Add(_TipoProducto)


            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function



        Public Shared Function GetList(ByVal EmpresaActual As String, ByVal TipoFact As String, _
                                    ByVal Desde As Date, ByVal Hasta As Date, ByVal Codigo As String, _
                                    ByVal Articulo As String, ByVal Vendedor As String, ByVal clientes As String, _
                                    ByVal Moneda As String) As DataSet

            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            DBCommand = New SqlDataAdapter("_FacturasVentasCrossTab", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim pTipoFact As New SqlParameter("@TipoFact", SqlDbType.NVarChar)
            pTipoFact.Value = TipoFact
            DBCommand.SelectCommand.Parameters.Add(pTipoFact)

            Dim pDesde As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            pDesde.Value = Desde
            DBCommand.SelectCommand.Parameters.Add(pDesde)

            Dim pHasta As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            pHasta.Value = Hasta
            DBCommand.SelectCommand.Parameters.Add(pHasta)

            Dim pCodigo As New SqlParameter("@Codigo", SqlDbType.NVarChar)
            pCodigo.Value = Codigo
            DBCommand.SelectCommand.Parameters.Add(pCodigo)

            Dim pArticulo As New SqlParameter("@Articulo", SqlDbType.NVarChar)
            pArticulo.Value = Articulo
            DBCommand.SelectCommand.Parameters.Add(pArticulo)

            Dim pVendedor As New SqlParameter("@Vendedor", SqlDbType.NVarChar)
            pVendedor.Value = Vendedor
            DBCommand.SelectCommand.Parameters.Add(pVendedor)

            Dim pClientes As New SqlParameter("@Cliente", SqlDbType.NVarChar)
            pClientes.Value = clientes
            DBCommand.SelectCommand.Parameters.Add(pClientes)

            Dim pMoneda As New SqlParameter("@Moneda", SqlDbType.NVarChar)
            pMoneda.Value = Moneda
            DBCommand.SelectCommand.Parameters.Add(pMoneda)

            Dim pUsuario As New SqlParameter("@UsuarioID", SqlDbType.Int)
            pUsuario.Value = Usuario_ID
            DBCommand.SelectCommand.Parameters.Add(pUsuario)

            DBConn.Open()
            DBCommand.SelectCommand.CommandTimeout = 0
            DBCommand.Fill(dsFicha, "Tabla")
            DBConn.Close()

            Return dsFicha
        End Function

        Public Shared Function EstadoCuentaProveedorReporteCrossTab(ByVal ProveedorID As String, ByVal FormaPago As String, _
                                     ByVal FechaDesde As String, ByVal FechaHasta As String, ByVal EmpresaActual As String, ByVal EmpresaNombre As String) As DataSet

            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            DBCommand = New SqlDataAdapter("[_EstadoCuentaProveedorReporteCrossTab]", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pProveedor As New SqlParameter("@Proveedor", SqlDbType.Int)
            pProveedor.Value = ProveedorID
            DBCommand.SelectCommand.Parameters.Add(pProveedor)

            Dim _FormaPago As New SqlParameter("@FormaPago", SqlDbType.NVarChar)
            _FormaPago.Value = FormaPago
            DBCommand.SelectCommand.Parameters.Add(_FormaPago)


            If FechaDesde = "" Then
                Dim _Fechadesde As New SqlParameter("@Fechadesde", SqlDbType.NVarChar)
                _Fechadesde.Value = FechaDesde
                DBCommand.SelectCommand.Parameters.Add(_Fechadesde)
            Else
                Dim _Fechadesde As New SqlParameter("@Fechadesde", SqlDbType.DateTime)
                _Fechadesde.Value = FechaDesde
                DBCommand.SelectCommand.Parameters.Add(_Fechadesde)
            End If

            If FechaHasta = "" Then
                Dim _FechaHasta As New SqlParameter("@FechaHasta", SqlDbType.NVarChar)
                _FechaHasta.Value = FechaHasta
                DBCommand.SelectCommand.Parameters.Add(_FechaHasta)
            Else
                Dim _FechaHasta As New SqlParameter("@FechaHasta", SqlDbType.DateTime)
                _FechaHasta.Value = CDate(FechaHasta).AddDays(1)
                DBCommand.SelectCommand.Parameters.Add(_FechaHasta)
            End If

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            'Dim EmpresasDB As New VB.SysContab.EmpresasDB

            Dim _EmpresaName As New SqlParameter("@EmpresaName", SqlDbType.NVarChar)
            _EmpresaName.Value = EmpresaNombre
            DBCommand.SelectCommand.Parameters.Add(_EmpresaName)

            DBCommand.Fill(dsFicha, "Facturas_Compras")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Shared Function EstadoCuentaReporteCrossTab(ByVal Cliente As String, ByVal FormaPago As String, _
                                          ByVal FechaDesde As String, ByVal FechaHasta As String, _
                                          ByVal EmpresaActual As String) As DataSet


            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            DBCommand = New SqlDataAdapter("_EstadoCuentaReporteCrosstab", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pCliente As New SqlParameter("@Cliente", SqlDbType.Int)
            pCliente.Value = Cliente
            DBCommand.SelectCommand.Parameters.Add(pCliente)


            Dim _FormaPago As New SqlParameter("@FormaPago", SqlDbType.Int)
            _FormaPago.Value = FormaPago
            DBCommand.SelectCommand.Parameters.Add(_FormaPago)


            If FechaDesde = "" Then
                Dim _Fechadesde As New SqlParameter("@Fechadesde", SqlDbType.NVarChar)
                _Fechadesde.Value = FechaDesde
                DBCommand.SelectCommand.Parameters.Add(_Fechadesde)
            Else
                Dim _Fechadesde As New SqlParameter("@Fechadesde", SqlDbType.DateTime)
                _Fechadesde.Value = FechaDesde
                DBCommand.SelectCommand.Parameters.Add(_Fechadesde)
            End If

            If FechaHasta = "" Then
                Dim _FechaHasta As New SqlParameter("@FechaHasta", SqlDbType.NVarChar)
                _FechaHasta.Value = FechaHasta
                DBCommand.SelectCommand.Parameters.Add(_FechaHasta)
            Else
                Dim _FechaHasta As New SqlParameter("@FechaHasta", SqlDbType.DateTime)
                _FechaHasta.Value = CDate(FechaHasta).AddDays(1)
                DBCommand.SelectCommand.Parameters.Add(_FechaHasta)
            End If

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            Dim _EmpresaName As New SqlParameter("@EmpresaName", SqlDbType.NVarChar)
            _EmpresaName.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(_EmpresaName)

            DBCommand.Fill(dsFicha, "Facturas_Ventas")

            DBConn.Close()

            Return dsFicha

        End Function


        Public Shared Function Imprimir_FlujoCajaCrosstab(ByVal Desde As String, _
      ByVal Hasta As String, ByVal MonedaCambio As String, ByVal EmpresaActual As String) As DataSet

            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            DBCommand = New SqlDataAdapter("[_WGetFlujoCajaCrostab]", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent2 As New SqlParameter("@Desde", SqlDbType.DateTime)
            Dim pIdent3 As New SqlParameter("@Hasta", SqlDbType.DateTime)
            Dim pIdent5 As New SqlParameter("@Moneda", SqlDbType.NVarChar)

            pIdent1.Value = EmpresaActual
            pIdent2.Value = Desde
            pIdent3.Value = Hasta
            pIdent5.Value = MonedaCambio

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent2)
            DBCommand.SelectCommand.Parameters.Add(pIdent3)
            DBCommand.SelectCommand.Parameters.Add(pIdent5)

            DBCommand.Fill(dsFicha, "FlujoCaja")
            DBConn.Close()


            Return dsFicha
        End Function


        Public Shared Function Imprimir_LibroBalanzaCrossTab(ByVal Desde As Date, ByVal Hasta As Date, _
                                  ByVal MonedaBase As String, ByVal MonedaCambio As String, _
                                  ByVal Grupo As String, ByVal nGrupo As String, _
                                  ByVal BalRes As String, ByVal EmpresaActual As String, ByVal Cuenta As String, ByVal Nivel As String) As DataSet

            Dim DBCommand As SqlDataAdapter
            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            DBCommand = New SqlDataAdapter("_EstadoSituacionCrossTabDinamico", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)

            Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)

            Dim pIdent11 As New SqlParameter("@Cuenta", SqlDbType.NVarChar)

            Dim pIdent13 As New SqlParameter("@Nivel", SqlDbType.NVarChar)

            Dim pident15 As New SqlParameter("@MonedaBase", SqlDbType.NVarChar)
            Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)


            Dim pident19 As New SqlParameter("@Grupo", SqlDbType.NVarChar)
            Dim pident20 As New SqlParameter("@NGrupo", SqlDbType.NVarChar)



            Dim pident24 As New SqlParameter("@BalRes", SqlDbType.NVarChar)



            pIdent1.Value = EmpresaActual

            pIdent6.Value = Desde
            pIdent7.Value = Hasta




            pIdent11.Value = Cuenta

            pIdent13.Value = Nivel

            pident15.Value = MonedaBase
            pident16.Value = MonedaCambio

            pident19.Value = Grupo
            pident20.Value = nGrupo



            pident24.Value = BalRes





            DBCommand.SelectCommand.Parameters.Add(pIdent1)

            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)

            DBCommand.SelectCommand.Parameters.Add(pIdent11)

            DBCommand.SelectCommand.Parameters.Add(pIdent13)

            DBCommand.SelectCommand.Parameters.Add(pident15)
            DBCommand.SelectCommand.Parameters.Add(pident16)

            DBCommand.SelectCommand.Parameters.Add(pident19)
            DBCommand.SelectCommand.Parameters.Add(pident20)


            DBCommand.SelectCommand.Parameters.Add(pident24)

            Dim DsREt As New DataSet

            DBCommand.Fill(DsREt, "LibroBalanza")
            DBConn.Close()

            Return DsREt


        End Function


        Public Shared Function LibroBalanzaCrostab(ByVal Desde As Date, ByVal Hasta As Date, ByVal MonedaCambio As String, ByVal EmpresaActual As String, ByVal BalRes As String) As DataSet

            Dim DBCommand As SqlDataAdapter
            Dim DS As New DataSet

            Dim DBConn As SqlConnection
            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion)

            DBCommand = New SqlDataAdapter("_LibroBalanzaCrossTab", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure


            Dim pIdent1 As New SqlParameter("@Empresa", SqlDbType.Int)
            Dim pIdent6 As New SqlParameter("@Desde", SqlDbType.SmallDateTime)
            Dim pIdent7 As New SqlParameter("@Hasta", SqlDbType.SmallDateTime)
            Dim pident16 As New SqlParameter("@MonedaCambio", SqlDbType.NVarChar)
            Dim pident17 As New SqlParameter("@BalRes", SqlDbType.NVarChar)


            pIdent1.Value = EmpresaActual
            pIdent6.Value = Desde
            pIdent7.Value = Hasta
            pident16.Value = MonedaCambio
            pident17.Value = BalRes

            DBCommand.SelectCommand.Parameters.Add(pIdent1)
            DBCommand.SelectCommand.Parameters.Add(pIdent6)
            DBCommand.SelectCommand.Parameters.Add(pIdent7)
            DBCommand.SelectCommand.Parameters.Add(pident16)
            DBCommand.SelectCommand.Parameters.Add(pident17)

            DBCommand.Fill(DS, "LibroBalanza")
            DBConn.Close()

            Return DS

        End Function


End Class

End Namespace