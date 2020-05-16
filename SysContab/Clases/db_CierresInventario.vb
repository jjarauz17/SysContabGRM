
Imports System.Data.SqlClient

Public Class db_CierresInventario
    Inherits ClComun
    Dim vCierresInventarioTabla As New CierresInventario
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property CierresInventarioTabla() As CierresInventario
        Get
            Return vCierresInventarioTabla
        End Get
        Set(ByVal value As CierresInventario)
            vCierresInventarioTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal CierresInventario As CierresInventario, Optional Tran As Boolean = False)

        Dim ObjParameter(14) As String
        ObjParameter(0) = CierresInventario.Numero
        ObjParameter(1) = CierresInventario.Fecha_Llave
        ObjParameter(2) = CierresInventario.Empresa
        ObjParameter(3) = CierresInventario.Registro
        ObjParameter(4) = CierresInventario.Bodega
        ObjParameter(5) = CierresInventario.Codigo
        ObjParameter(6) = CierresInventario.Inicial
        ObjParameter(7) = CierresInventario.Entradas
        ObjParameter(8) = CierresInventario.Salidas
        ObjParameter(9) = CierresInventario.Final
        ObjParameter(10) = CierresInventario.Promedio
        ObjParameter(11) = CierresInventario.Total
        ObjParameter(12) = CierresInventario.Estado
        ObjParameter(13) = CierresInventario.Usuario

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            vCierresInventarioTabla.IdDetalle = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_CierresInventario", ObjParameter).ExecuteNonQuery()
            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If

            MensajeError = ex.Message
            Me.SendEmail(ex.Message)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal CierresInventario As CierresInventario, Optional Tran As Boolean = False)
        Dim ObjParameter(15) As String
        ObjParameter(0) = CierresInventario.IdDetalle
        ObjParameter(1) = CierresInventario.Numero
        ObjParameter(2) = CierresInventario.Fecha_Llave
        ObjParameter(3) = CierresInventario.Empresa
        ObjParameter(4) = CierresInventario.Registro
        ObjParameter(5) = CierresInventario.Bodega
        ObjParameter(6) = CierresInventario.Codigo
        ObjParameter(7) = CierresInventario.Inicial
        ObjParameter(8) = CierresInventario.Entradas
        ObjParameter(9) = CierresInventario.Salidas
        ObjParameter(10) = CierresInventario.Final
        ObjParameter(11) = CierresInventario.Promedio
        ObjParameter(12) = CierresInventario.Total
        ObjParameter(13) = CierresInventario.Estado
        ObjParameter(14) = CierresInventario.Usuario

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            vCierresInventarioTabla.IdDetalle = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_CierresInventario", ObjParameter).ExecuteNonQuery()
            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            Me.MensajeError = ex.Message
            Me.SendEmail(ex.Message)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar(ByVal Id As String, Previa As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_CierresInventario",
                            Id,
                            EmpresaActual,
                            Previa)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    'Public Shared Function ListarPrevio(Fecha_Cierre) As Data.DataTable
    '    Return ObtieneDatos("sp_sel_CierresInventario '" & Fecha_Cierre & "'," & EmpresaActual)
    'End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function ListarPrevio(ByVal Desde As Date, Hasta As Date) As DataTable

        Try
            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
            Conn.AddParameter("Desde", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Desde)
            Conn.AddParameter("Hasta", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Hasta)
            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
            '
            Return Conn.EjecutarComando("sp_cierre_inventario_Previo")
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Verificar(ByVal Fecha As Date) As Boolean

        Try
            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
            Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Fecha)
            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
            '
            Dim DT As DataTable = Conn.EjecutarComando("sp_VerificarCierre")

            If DT.Rows.Count > 0 Then
                XtraMsg("El Mes ya se encuentra Cerrado para la Fecha Solicitada: " & Fecha.Date.ToShortDateString & vbCrLf & _
                        "Fecha de ultimo Cierre: " & CDate(DT.Rows.Item(0)(0)).ToShortDateString, MessageBoxIcon.Error)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Guardar(ByVal Desde As Date, Hasta As Date) As Boolean

        Try
            Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
            Conn.AddParameter("Desde", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Desde)
            Conn.AddParameter("Hasta", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, Hasta)
            Conn.AddParameter("Empresa", SqlDbType.Int, 4, ParameterDirection.Input, EmpresaActual)
            '
            Conn.EjecutarComando("sp_cierre_inventario")

            Return True
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal CierresInventario As CierresInventario, Optional Tran As Boolean = False)
        Dim ObjParameter(2) As String
        ObjParameter(0) = CierresInventario.Numero
        ObjParameter(1) = EmpresaActual

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_CierresInventario", ObjParameter).ExecuteNonQuery()
            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            Me.MensajeError = ex.Message
            Me.SendEmail(ex.Message)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


End Class
