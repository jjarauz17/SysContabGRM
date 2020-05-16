Imports System.Data.SqlClient

Public Class db_Taller_Remisiones
    Inherits ClComun
    Dim vTaller_RemisionesTabla As New Taller_Remisiones
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Taller_RemisionesTabla() As Taller_Remisiones
        Get
            Return vTaller_RemisionesTabla
        End Get
        Set(ByVal value As Taller_Remisiones)
            vTaller_RemisionesTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Taller_Remisiones As Taller_Remisiones, Optional Tran As Boolean = False)
        Dim ObjParameter(16) As String
        ObjParameter(0) = EmpresaActual
        ObjParameter(1) = Taller_Remisiones.Codigo
        ObjParameter(2) = Taller_Remisiones.Tipo
        ObjParameter(3) = Taller_Remisiones.Fecha
        ObjParameter(4) = Taller_Remisiones.Cliente
        ObjParameter(5) = Taller_Remisiones.OrdenTrabajo
        ObjParameter(6) = Taller_Remisiones.Bodega
        ObjParameter(7) = Taller_Remisiones.Realizadopor
        ObjParameter(8) = Taller_Remisiones.Autorizadopor
        ObjParameter(9) = Taller_Remisiones.Contabilizada
        ObjParameter(10) = Taller_Remisiones.Comp_No
        ObjParameter(11) = Taller_Remisiones.Per_Id
        ObjParameter(12) = Taller_Remisiones.Mes
        ObjParameter(13) = Taller_Remisiones.Registro
        ObjParameter(14) = Taller_Remisiones.Referencia
        ObjParameter(15) = Taller_Remisiones.Procesado

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            vTaller_RemisionesTabla.IdRemision = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Taller_Remisiones", ObjParameter).ExecuteNonQuery()
            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            ''Me.MensajeError = ex.Message
            ''Me.SendEmail(ex.Message)
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal Taller_Remisiones As Taller_Remisiones, Optional Tran As Boolean = False)
        Dim ObjParameter(17) As String
        ObjParameter(1) = EmpresaActual
        ObjParameter(2) = Taller_Remisiones.Codigo
        ObjParameter(2) = Taller_Remisiones.IdRemision
        ObjParameter(3) = Taller_Remisiones.Tipo
        ObjParameter(4) = Taller_Remisiones.Fecha
        ObjParameter(5) = Taller_Remisiones.Cliente
        ObjParameter(6) = Taller_Remisiones.OrdenTrabajo
        ObjParameter(7) = Taller_Remisiones.Bodega
        ObjParameter(8) = Taller_Remisiones.Realizadopor
        ObjParameter(9) = Taller_Remisiones.Autorizadopor
        ObjParameter(10) = Taller_Remisiones.Contabilizada
        ObjParameter(11) = Taller_Remisiones.Comp_No
        ObjParameter(12) = Taller_Remisiones.Per_Id
        ObjParameter(13) = Taller_Remisiones.Mes
        ObjParameter(14) = Taller_Remisiones.Registro
        ObjParameter(15) = Taller_Remisiones.Referencia
        ObjParameter(16) = 0

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            vTaller_RemisionesTabla.IdRemision = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Taller_Remisiones", ObjParameter).ExecuteNonQuery()
            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            'Me.MensajeError = ex.Message
            'Me.SendEmail(ex.Message)
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_Taller_Remisiones '" & Id & "'," & EmpresaActual)
    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Borrar(ByVal Taller_Remisiones As Taller_Remisiones, Optional Tran As Boolean = False) As Boolean
        Dim ObjParameter(1) As String
        ObjParameter(0) = Taller_Remisiones.IdRemision
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Taller_Remisiones", ObjParameter).ExecuteNonQuery()
            If Tran = False Then
                Commit()
            End If

            Return True
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            'Me.MensajeError = ex.Message
            'Me.SendEmail(ex.Message)
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return False
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Id As String) As Taller_Remisiones
        Dim dt As DataTable = ObtieneDatos("sp_sel_Taller_Remisiones '" & Id & "'," & EmpresaActual)
        Dim det As New Taller_Remisiones

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.Empresa = .item("Empresa").tostring
                det.Codigo = .item("Codigo").tostring
                det.IdRemision = .item("IdRemision").tostring
                det.Tipo = .item("Tipo").tostring
                det.Fecha = .item("Fecha").tostring
                det.Cliente = .item("Cliente").tostring
                det.OrdenTrabajo = .item("OrdenTrabajo").tostring
                det.Bodega = .item("Bodega").tostring
                det.Realizadopor = .item("Realizadopor").tostring
                det.Autorizadopor = .item("Autorizadopor").tostring
                det.Contabilizada = .item("Contabilizada").tostring
                det.Comp_No = .item("Comp_No").tostring
                det.Per_Id = .item("Per_Id").tostring
                det.Mes = .item("Mes").tostring
                det.Registro = .item("Registro").tostring
                det.Referencia = .item("Referencia").tostring
                det.Procesado = .item("Procesado").tostring
            End With
        End If
        Return det
    End Function

    Public Shared Function GetCodigoNuevo() As Integer

        Dim DBConn As SqlConnection
        Dim DBCommand As SqlDataAdapter

        DBConn = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())

        DBCommand = New SqlDataAdapter("jar_GetRemisionesCodigoNuevo", DBConn)
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

            Return pIdent2.Value
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function
End Class
