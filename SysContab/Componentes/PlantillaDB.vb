Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace VB.SysContab

    '*******************************************************
    ' ComprobanteDB
    ' Objetivo: Regresar un Detalle de la Plantilla con sus cuentas
    ' Autor: Bernardo Robelo
    ' Fecha: 29/DIC/2005
    '*******************************************************

    Public Class PlantillaDetails

        Public TipoPlantilla As String
        Public NombrePlantilla As String
        Public TipoCompr As String
        Public PlaID As String
        Public EsquemaID As String
        Public Detalles As DataSet

    End Class

    '*******************************************************
    ' PlantillaDB
    ' Objetivo: Manejar todas la funciones de plantillas
    ' Autor: Bernardo Robelo
    ' Fecha: 16/Nov/2005
    '*******************************************************

    Public Class PlantillaDB

        Public Sub UpdateCuentaGastos(ByVal Plantilla_ID As String, ByVal Cuenta As String)

            Dim cmd As SqlCommand = New SqlCommand("[_PlantillaUpdateCuentaGastos]", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar)
            _Cuenta.Value = Cuenta
            cmd.Parameters.Add(_Cuenta)

            Dim _Plantilla_ID As SqlParameter = New SqlParameter("@Plantilla_ID", SqlDbType.NVarChar)
            _Plantilla_ID.Value = Plantilla_ID
            cmd.Parameters.Add(_Plantilla_ID)


            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()


        End Sub


        Public Function GetList2(ByVal EmpresaActual As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlantillasGetList2", DBConn)
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Plantillas")

            DBConn.Close()

            Return dsFicha

        End Function


        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 9/Feb/2005
        'Objetivo: Valida el Tipo de Plantilla y Esquema si hay uno creado
        '*******************************************************

        Public Function GetTipoPlantilla(ByVal EsqID As String, ByVal PlaID As String) As String

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim conn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_PlantillaGetTipo", conn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _EsqID As SqlParameter = New SqlParameter("@EsqID", SqlDbType.NVarChar)
            _EsqID.Value = EsqID
            cmd.Parameters.Add(_EsqID)

            Dim _PlaID As SqlParameter = New SqlParameter("@PlaID", SqlDbType.NVarChar)
            _PlaID.Value = PlaID
            cmd.Parameters.Add(_PlaID)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim Valor As SqlParameter = New SqlParameter("@Valor", SqlDbType.NVarChar, 50)
            Valor.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Valor)

            ' Open the connection and execute the Command
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            '' Return the Total
            Return Valor.Value.ToString

        End Function


        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 27/Enero/2006
        'Objetivo: Regresa la lista de Esquema de Prove
        '*******************************************************

        Public Function GetListEsquemaProv(ByVal PlaID As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_EsquemaProveedoresGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _PlaID As SqlParameter = New SqlParameter("@PlaID", SqlDbType.NVarChar)
            _PlaID.Value = PlaID
            DBCommand.SelectCommand.Parameters.Add(_PlaID)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function


        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 18/Enero/2006
        'Objetivo: Regresa la lista de TipoPlantillas dada una Plantillas Contables 
        '*******************************************************

        Public Function GetListTipoPlantillasxEsquema(ByVal PlaID As String, ByVal EsqID As String) As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_TipoPlantillasxEsquemaGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim _PlaID As SqlParameter = New SqlParameter("@PlaID", SqlDbType.NVarChar)
            _PlaID.Value = PlaID
            DBCommand.SelectCommand.Parameters.Add(_PlaID)

            Dim _EsqID As SqlParameter = New SqlParameter("@EsqID", SqlDbType.NVarChar)
            _EsqID.Value = EsqID
            DBCommand.SelectCommand.Parameters.Add(_EsqID)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function




        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 18/Enero/2006
        'Objetivo: Regresa la lista Plantillas Contables 
        '*******************************************************

        Public Function GetListPlantillasContables() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlantillasContablesGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 05/01/2006
        'Objetivo: Elimina un Plantilla
        '*******************************************************

        Public Shared Function Delete(ByVal Tipo As String) As String

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim conn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_PlantillaDelete", conn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)
            _Tipo.Value = Tipo
            cmd.Parameters.Add(_Tipo)


            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)


            ' Open the connection and execute the Command
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

        End Function


        Public Shared Function GetPlantillasDetails(ByVal PlaID As String, ByVal EsqID As String) As PlantillaDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlantillaDetailsPlaIDEsqID", DBConn)

            ' Mark the Command as a SPROC
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _PlaID As New SqlParameter("@PlaID", SqlDbType.NVarChar, 50)
            _PlaID.Value = PlaID
            DBCommand.SelectCommand.Parameters.Add(_PlaID)


            Dim _EsqID As New SqlParameter("@EsqID", SqlDbType.NVarChar, 50)
            _EsqID.Value = EsqID
            DBCommand.SelectCommand.Parameters.Add(_EsqID)


            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim Tipo As New SqlParameter("@Tipo", SqlDbType.NVarChar, 60)
            Tipo.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Tipo)

            Dim Nombre As New SqlParameter("@Nombre", SqlDbType.NVarChar, 60)
            Nombre.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Nombre)

            Dim TipoCompr As New SqlParameter("@TipoCompr", SqlDbType.NVarChar, 60)
            TipoCompr.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(TipoCompr)

            Dim Esquema As New SqlParameter("@Esquema", SqlDbType.NVarChar, 60)
            Esquema.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Esquema)

            Dim Pla_ID As New SqlParameter("@Pla_ID", SqlDbType.NVarChar, 60)
            Pla_ID.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Pla_ID)

            ' Create and Fill the DataSet
            Dim myDataSet As New DataSet

            Try
                DBCommand.Fill(myDataSet, "PlantillasDetalles")
            Catch e As Exception
                XtraMsg(e.Message,
                        MessageBoxIcon.Error)
            End Try

            DBConn.Close()

            Dim myOrderDetails As New PlantillaDetails

            myOrderDetails.NombrePlantilla = Nombre.Value.ToString
            myOrderDetails.TipoPlantilla = Tipo.Value.ToString
            myOrderDetails.TipoCompr = TipoCompr.Value.ToString
            myOrderDetails.EsquemaID = Esquema.Value.ToString
            myOrderDetails.PlaID = Pla_ID.Value.ToString
            myOrderDetails.Detalles = myDataSet

            Return myOrderDetails

        End Function




        Public Function GetPlantillasDetails(ByVal TipoID As String) As PlantillaDetails

            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlantillaDetails", DBConn)

            ' Mark the Command as a SPROC
            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Tipo As New SqlParameter("@TipoID", SqlDbType.NVarChar, 50)
            _Tipo.Value = TipoID
            DBCommand.SelectCommand.Parameters.Add(_Tipo)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)

            Dim Tipo As New SqlParameter("@Tipo", SqlDbType.NVarChar, 60)
            Tipo.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Tipo)

            Dim Nombre As New SqlParameter("@Nombre", SqlDbType.NVarChar, 60)
            Nombre.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Nombre)

            Dim TipoCompr As New SqlParameter("@TipoCompr", SqlDbType.NVarChar, 60)
            TipoCompr.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(TipoCompr)

            Dim Esquema As New SqlParameter("@Esquema", SqlDbType.NVarChar, 60)
            Esquema.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(Esquema)

            Dim PlaID As New SqlParameter("@PlaID", SqlDbType.NVarChar, 60)
            PlaID.Direction = ParameterDirection.Output
            DBCommand.SelectCommand.Parameters.Add(PlaID)

            ' Create and Fill the DataSet
            Dim myDataSet As New DataSet

            Try
                DBCommand.Fill(myDataSet, "PlantillasDetalles")
            Catch e As Exception
                MsgBox(e.Message)
            End Try

            DBConn.Close()

            Dim myOrderDetails As New PlantillaDetails

            myOrderDetails.NombrePlantilla = Nombre.Value.ToString
            myOrderDetails.TipoPlantilla = Tipo.Value.ToString
            myOrderDetails.TipoCompr = TipoCompr.Value.ToString
            myOrderDetails.EsquemaID = Esquema.Value.ToString
            myOrderDetails.PlaID = PlaID.Value.ToString
            myOrderDetails.Detalles = myDataSet

            Return myOrderDetails

        End Function



        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 14/Nov/2005
        'Objetivo: Regresa la lista de Plantillas
        '*******************************************************

        Public Shared Function GetList() As DataSet
            Dim DBConn As SqlConnection
            Dim DBCommand As SqlDataAdapter
            Dim dsFicha As New DataSet

            Dim conexion As New VB.SysContab.Rutinas
            DBConn = New SqlConnection(Rutinas.AbrirConexion())

            DBCommand = New SqlDataAdapter("_PlantillasGetList", DBConn)

            DBCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            DBCommand.SelectCommand.Parameters.Add(pEmpresa)


            DBCommand.Fill(dsFicha, "Tablas")

            DBConn.Close()

            Return dsFicha

        End Function

        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 9/Feb/2005
        'Objetivo: Valida el Tipo de Plantilla y Esquema si hay uno creado
        '*******************************************************

        Public Function ValidaPlantillaEsquema(ByVal EsqID As String, ByVal PlaID As String) As Boolean

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim conn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_PlantillaValidarEsquema", conn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _EsqID As SqlParameter = New SqlParameter("@EsqID", SqlDbType.NVarChar)
            _EsqID.Value = EsqID
            cmd.Parameters.Add(_EsqID)

            Dim _PlaID As SqlParameter = New SqlParameter("@PlaID", SqlDbType.NVarChar)
            _PlaID.Value = PlaID
            cmd.Parameters.Add(_PlaID)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim Valor As SqlParameter = New SqlParameter("@Valor", SqlDbType.Bit, 50)
            Valor.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Valor)

            ' Open the connection and execute the Command
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            '' Return the Total
            Return CType(Valor.Value, Boolean)

        End Function


        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 28/DIC/2005
        'Objetivo: Agregar un Tipo de Plantilla
        '*******************************************************

        Public Function ValidaTipo(ByVal Tipo As String) As String

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim conn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_PlantillaValidarTipo", conn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)
            _Tipo.Value = Tipo
            cmd.Parameters.Add(_Tipo)


            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim Valor As SqlParameter = New SqlParameter("@Valor", SqlDbType.NVarChar, 50)
            Valor.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Valor)

            ' Open the connection and execute the Command
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            '' Return the Total
            If Valor.Value.ToString() <> 0 Then
                Return CType(Valor.Value, String)
            Else
                Return 0
            End If

        End Function


        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 05/ENE/2006
        'Objetivo: Agrega Plantillas en el Update despues de ser borradas
        '*******************************************************

        Public Function UpDateAddTipoPlantilla(ByVal Tipo As String, ByVal Nombre As String, _
                                        ByVal Cuenta As String, ByVal Uso As String, ByVal DC As String, _
                                        ByVal Concepto As String, ByVal Variable As String, _
                                        ByVal Concepto2 As String, ByVal Variable2 As String, ByVal Concepto3 As String, _
                                        ByVal Variable3 As String, ByVal Concepto4 As String, ByVal Variable4 As String) As String

            Dim cmd As SqlCommand = New SqlCommand("_PlantillaUpdate", DBConnFacturas)

            cmd.CommandType = CommandType.StoredProcedure

            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)
            _Tipo.Value = Tipo
            cmd.Parameters.Add(_Tipo)

            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            _Nombre.Value = Nombre
            cmd.Parameters.Add(_Nombre)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim Valor As SqlParameter = New SqlParameter("@Valor", SqlDbType.NVarChar, 50)
            Valor.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Valor)

            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar, 64)
            _Cuenta.Value = Cuenta
            cmd.Parameters.Add(_Cuenta)

            Dim _Uso As SqlParameter = New SqlParameter("@Uso", SqlDbType.NVarChar)
            _Uso.Value = Uso
            cmd.Parameters.Add(_Uso)

            Dim _DC As SqlParameter = New SqlParameter("@DC", SqlDbType.NVarChar)
            _DC.Value = DC
            cmd.Parameters.Add(_DC)

            Dim _Concepto As SqlParameter = New SqlParameter("@Concepto", SqlDbType.NVarChar)
            _Concepto.Value = Concepto
            cmd.Parameters.Add(_Concepto)

            Dim _Variable As SqlParameter = New SqlParameter("@Variable", SqlDbType.NVarChar)
            _Variable.Value = Variable
            cmd.Parameters.Add(_Variable)

            Dim _Concepto2 As SqlParameter = New SqlParameter("@Concepto2", SqlDbType.NVarChar)
            _Concepto2.Value = Concepto2
            cmd.Parameters.Add(_Concepto2)

            Dim _Variable2 As SqlParameter = New SqlParameter("@Variable2", SqlDbType.NVarChar)
            _Variable2.Value = Variable2
            cmd.Parameters.Add(_Variable2)

            Dim _Concepto3 As SqlParameter = New SqlParameter("@Concepto3", SqlDbType.NVarChar)
            _Concepto3.Value = Concepto3
            cmd.Parameters.Add(_Concepto3)

            Dim _Variable3 As SqlParameter = New SqlParameter("@Variable3", SqlDbType.NVarChar)
            _Variable3.Value = Variable3
            cmd.Parameters.Add(_Variable3)

            Dim _Concepto4 As SqlParameter = New SqlParameter("@Concepto4", SqlDbType.NVarChar)
            _Concepto4.Value = Concepto4
            cmd.Parameters.Add(_Concepto4)

            Dim _Variable4 As SqlParameter = New SqlParameter("@Variable4", SqlDbType.NVarChar)
            _Variable4.Value = Variable4
            cmd.Parameters.Add(_Variable4)


            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()

            '' Return the Total
            'If Valor.Value.ToString() <> 0 Then
            '    Return CType(Valor.Value, String)
            'Else
            '    Return 0.0
            'End If

        End Function



        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 05/ENE/2006
        'Objetivo: Actualizar un Tipo de Plantilla
        '*******************************************************

        Public Function UpDateTipoPlantilla(ByVal Tipo As String, ByVal TipoNuevo As String, ByVal Nombre As String, _
                                            ByVal TipoCompr As String) As String


            Dim cmd As SqlCommand = New SqlCommand("_TipoPlantillaUpdate", DBConnFacturas)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)
            _Tipo.Value = Tipo
            cmd.Parameters.Add(_Tipo)

            Dim _TipoNuevo As SqlParameter = New SqlParameter("@TipoNuevo", SqlDbType.NVarChar)
            _TipoNuevo.Value = TipoNuevo
            cmd.Parameters.Add(_TipoNuevo)

            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            _Nombre.Value = Nombre
            cmd.Parameters.Add(_Nombre)

            Dim _TipoCompr As New SqlParameter("@TipoCompr", SqlDbType.NVarChar, 60)
            _TipoCompr.Value = TipoCompr
            cmd.Parameters.Add(_TipoCompr)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim Valor As SqlParameter = New SqlParameter("@Valor", SqlDbType.NVarChar, 50)
            Valor.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Valor)

            cmd.Connection = DBConnFacturas
            cmd.Transaction = transaccionFacturas
            cmd.ExecuteNonQuery()



            Return Valor.Value


        End Function



        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 28/DIC/2005
        'Objetivo: Agregar un Tipo de Plantilla
        '*******************************************************

        Public Function AddTipoPlantilla(ByVal Tipo As String, ByVal Nombre As String, _
                                        ByVal TipoComp As String, ByVal Esquema As String, _
                                        ByVal PlaID As String, _
                                        ByVal Cuenta As String, ByVal Uso As String, ByVal DC As String, _
                                        ByVal Concepto As String, ByVal Variable As String, _
                                        ByVal Concepto2 As String, ByVal Variable2 As String, ByVal Concepto3 As String, _
                                        ByVal Variable3 As String, ByVal Concepto4 As String, ByVal Variable4 As String) As String


            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim conn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_TipoPlantillaAddItem", conn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Tipo As SqlParameter = New SqlParameter("@Tipo", SqlDbType.NVarChar)
            _Tipo.Value = Tipo
            cmd.Parameters.Add(_Tipo)

            Dim _Nombre As SqlParameter = New SqlParameter("@Nombre", SqlDbType.NVarChar)
            _Nombre.Value = Nombre
            cmd.Parameters.Add(_Nombre)

            Dim _TipoComp As SqlParameter = New SqlParameter("@TipoComp", SqlDbType.NVarChar)
            _TipoComp.Value = TipoComp
            cmd.Parameters.Add(_TipoComp)

            Dim _Esquema As SqlParameter = New SqlParameter("@Esquema", SqlDbType.NVarChar)
            _Esquema.Value = Esquema
            cmd.Parameters.Add(_Esquema)

            Dim _PlaID As SqlParameter = New SqlParameter("@PlaID", SqlDbType.NVarChar)
            _PlaID.Value = PlaID
            cmd.Parameters.Add(_PlaID)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim Valor As SqlParameter = New SqlParameter("@Valor", SqlDbType.NVarChar, 50)
            Valor.Direction = ParameterDirection.Output
            cmd.Parameters.Add(Valor)

            Dim _Cuenta As SqlParameter = New SqlParameter("@Cuenta", SqlDbType.NVarChar, 64)
            _Cuenta.Value = Cuenta
            cmd.Parameters.Add(_Cuenta)

            Dim _Uso As SqlParameter = New SqlParameter("@Uso", SqlDbType.NVarChar)
            _Uso.Value = Uso
            cmd.Parameters.Add(_Uso)

            Dim _DC As SqlParameter = New SqlParameter("@DC", SqlDbType.NVarChar)
            _DC.Value = DC
            cmd.Parameters.Add(_DC)

            Dim _Concepto As SqlParameter = New SqlParameter("@Concepto", SqlDbType.NVarChar)
            _Concepto.Value = Concepto
            cmd.Parameters.Add(_Concepto)

            Dim _Variable As SqlParameter = New SqlParameter("@Variable", SqlDbType.NVarChar)
            _Variable.Value = Variable
            cmd.Parameters.Add(_Variable)

            Dim _Concepto2 As SqlParameter = New SqlParameter("@Concepto2", SqlDbType.NVarChar)
            _Concepto2.Value = Concepto2
            cmd.Parameters.Add(_Concepto2)

            Dim _Variable2 As SqlParameter = New SqlParameter("@Variable2", SqlDbType.NVarChar)
            _Variable2.Value = Variable2
            cmd.Parameters.Add(_Variable2)

            Dim _Concepto3 As SqlParameter = New SqlParameter("@Concepto3", SqlDbType.NVarChar)
            _Concepto3.Value = Concepto3
            cmd.Parameters.Add(_Concepto3)

            Dim _Variable3 As SqlParameter = New SqlParameter("@Variable3", SqlDbType.NVarChar)
            _Variable3.Value = Variable3
            cmd.Parameters.Add(_Variable3)

            Dim _Concepto4 As SqlParameter = New SqlParameter("@Concepto4", SqlDbType.NVarChar)
            _Concepto4.Value = Concepto4
            cmd.Parameters.Add(_Concepto4)

            Dim _Variable4 As SqlParameter = New SqlParameter("@Variable4", SqlDbType.NVarChar)
            _Variable4.Value = Variable4
            cmd.Parameters.Add(_Variable4)

            ' Open the connection and execute the Command
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            '' Return the Total
            'If Valor.Value.ToString() <> 0 Then
            '    Return CType(Valor.Value, String)
            'Else
            '    Return 0.0
            'End If

        End Function



        '*******************************************************
        'Elaborada por: Bernardo Robelo
        'Fecha: 9/Nov/2005
        'Objetivo: Obtiene la tasa de Cambio dada una Fecha
        '*******************************************************

        Public Function GetNoCuenta(ByVal Plantilla As String, ByVal Uso As String) As String

            ' Create Instance of Connection and Command Object
            Dim conexion As New VB.SysContab.Rutinas
            Dim conn = New SqlConnection(Rutinas.AbrirConexion())

            Dim cmd As SqlCommand = New SqlCommand("_PlantillaGetNoCuenta", conn)

            ' Mark the Command as a SPROC
            cmd.CommandType = CommandType.StoredProcedure

            ' Add Parameters to SPROC
            Dim _Plantilla As SqlParameter = New SqlParameter("@Plantilla", SqlDbType.NVarChar)
            _Plantilla.Value = Plantilla
            cmd.Parameters.Add(_Plantilla)

            Dim _Uso As SqlParameter = New SqlParameter("@Uso", SqlDbType.NVarChar)
            _Uso.Value = Uso
            cmd.Parameters.Add(_Uso)

            Dim pEmpresa As New SqlParameter("@Empresa", SqlDbType.Int)
            pEmpresa.Value = EmpresaActual
            cmd.Parameters.Add(pEmpresa)

            Dim _NoCuenta As SqlParameter = New SqlParameter("@NoCuenta", SqlDbType.NVarChar, 50)
            _NoCuenta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(_NoCuenta)

            ' Open the connection and execute the Command
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            ' Return the Total
            If _NoCuenta.Value.ToString() <> "" Then
                Return CType(_NoCuenta.Value, String)
            Else
                Return 0.0
            End If

        End Function

    End Class


End Namespace
