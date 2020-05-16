Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_MaestroNotasCD

    Public Function Guardar(Note As String, IdCliente As Integer, Fecha As Date,
                                   TipoComprobante As Integer, Monto As Double,
                                   Concepto As String, Tipo As Integer, Moneda As String,
                                   Comp_No As Integer, Per_Id As Integer, Mes As Integer,
                                   Vencimiento As Date, Optional IdAnticipo As Integer = 0,
                                   Optional IdTipo As Integer = 0,
                                   Optional Consecutivo As String = "",
                                   Optional IdDevolucion As Integer = 0) As Integer

        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Clear()
        Variables.Add("NoNota")
        Variables.Add("IdCliente")
        Variables.Add("Empresa")
        Variables.Add("Fecha")
        Variables.Add("TipoComprobante")
        Variables.Add("Monto")
        Variables.Add("Comentario")
        Variables.Add("Tipo")
        Variables.Add("Anulado")
        Variables.Add("Moneda")
        Variables.Add("Comp_No")
        Variables.Add("Per_Id")
        Variables.Add("Mes")
        Variables.Add("Vencimiento")
        Variables.Add("IdAnticipo")
        Variables.Add("IdTipo")
        Variables.Add("Consecutivo")
        Variables.Add("IdDevolucion")
        '
        Datos.Clear()
        Datos.Add(Note)
        Datos.Add(IdCliente)
        Datos.Add(EmpresaA)
        Datos.Add(Fecha)
        Datos.Add(TipoComprobante)
        Datos.Add(Monto)
        Datos.Add(Concepto)
        Datos.Add(Tipo)
        Datos.Add(0)
        Datos.Add(Moneda)
        Datos.Add(Comp_No)
        Datos.Add(Per_Id)
        Datos.Add(Mes)
        Datos.Add(Vencimiento)
        Datos.Add(IdAnticipo)
        Datos.Add(IdTipo)
        Datos.Add(Consecutivo)
        Datos.Add(IdDevolucion)

        Return ProcedureParameters(
            Datos,
            Variables,
            "SP_GuardaMaestroNotasCD") _
            .Rows(0) _
            .Item(0)
    End Function

    Public Sub GuardarDetalle(IdNota As Integer, NoFactura As String, Cobro As Double, Fecha As Date, MttoValor As Double)
        Dim Datos As New ArrayList
        Dim Variables As New ArrayList

        Variables.Clear()
        Variables.Add("IdNota")
        Variables.Add("Factura")
        Variables.Add("Monto")
        Variables.Add("Fecha")
        Variables.Add("Empresa")
        Variables.Add("Mnto")

        Datos.Clear()
        Datos.Add(IdNota)
        Datos.Add(NoFactura)
        Datos.Add(Cobro)
        Datos.Add(Fecha)
        Datos.Add(EmpresaA)
        Datos.Add(MttoValor)

        ProcedureSave(Datos, Variables, "SP_GuardaDetalleNotasCD")
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function GetNumero(Tipo As Integer) As String

        Return ObtieneDatos("sp_MaestroNotasCD_GetNumero", Tipo, EmpresaA).Rows.Item(0)("Numero")

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Buscar(NoNota As String) As String

        Dim DT As DataTable = ObtieneDatos("sp_MaestroNotasCD_Buscar", NoNota, EmpresaA)

        Return IIf(DT.Rows.Count = 0, "NO", "SI")

    End Function

    Public Function ProcedureParameters(ByVal Parametros As ArrayList, ByVal Variables As ArrayList,
                                       ByVal Procedimiento As String) As DataTable

        Dim DC As New SqlConnection(Conexion())
        Dim Command As New SqlCommand(Procedimiento, DC)
        Dim DT As New DataTable
        Command.CommandType = CommandType.StoredProcedure

        If Not Parametros Is Nothing Then
            Dim Parametro(Parametros.Count) As SqlParameter
            For i As Integer = 0 To Parametros.Count - 1
                Parametro(i) = New SqlParameter("@" & Variables(i).ToString, TipoDatos(Parametros(i).GetType))
                Parametro(i).Value = Parametros(i)
                Command.Parameters.Add(Parametro(i))
            Next
        End If

        Try
            DC.Open()
            Dim DA As New SqlDataAdapter(Command)
            DA.SelectCommand.CommandTimeout = 0
            DA.Fill(DT)

        Catch ex As Exception
            XtraMsg("Error :" & ex.Message & vbCrLf &
                    Procedimiento, MessageBoxIcon.Error)
            Throw New Exception
        Finally
            DC.Close()
        End Try

        Return DT

    End Function

    Public Function ProcedureSave(ByVal Parametros As ArrayList, ByVal Variables As ArrayList, ByVal Procedimiento As String) As Boolean
        Dim DC As New SqlConnection(Conexion())
        Dim Command As New SqlCommand(Procedimiento, DC)
        Dim DT As New DataTable
        Command.CommandType = CommandType.StoredProcedure
        Dim Parametro(Parametros.Count) As SqlParameter
        For i As Integer = 0 To Parametros.Count - 1
            Parametro(i) = New SqlParameter("@" & Variables(i).ToString, TipoDatos(Parametros(i).GetType))
            Parametro(i).Value = Parametros(i)
            Command.Parameters.Add(Parametro(i))
        Next
        Try
            DC.Open()
            Command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            XtraMsg("Error :" & ex.Message, MessageBoxIcon.Error)
            Return False
        Finally
            DC.Close()
        End Try
    End Function

    Function TipoDatos(ByVal Value As Type) As SqlDbType
        Dim vSQL As SqlDbType = SqlDbType.NVarChar

        Select Case Value.Name
            Case "String" : vSQL = SqlDbType.NVarChar
            Case "Int32" : vSQL = SqlDbType.Int
            Case "Double" : vSQL = SqlDbType.Money
            Case "Decimal" : vSQL = SqlDbType.Money
            Case "DateTime" : vSQL = SqlDbType.SmallDateTime
        End Select
        '
        Return vSQL
    End Function



End Class
