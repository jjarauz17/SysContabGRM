
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_Articulos_Fabricantes
    Inherits ClComun
    Dim vARTICULOS_FABRICANTESTabla As New Articulos_Fabricantes
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property ARTICULOS_FABRICANTESTabla() As Articulos_Fabricantes
        Get
            Return vARTICULOS_FABRICANTESTabla
        End Get
        Set(ByVal value As Articulos_Fabricantes)
            vARTICULOS_FABRICANTESTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal ARTICULOS_FABRICANTES As Articulos_Fabricantes, Optional Tran As Boolean = False)
        Dim ObjParameter(3) As String
        ObjParameter(0) = ARTICULOS_FABRICANTES.Nombre
        ObjParameter(1) = ARTICULOS_FABRICANTES.Descripcion
        ObjParameter(2) = EmpresaA

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_ARTICULOS_FABRICANTES", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal ARTICULOS_FABRICANTES As Articulos_Fabricantes, Optional Tran As Boolean = False)
        Dim ObjParameter(3) As String
        ObjParameter(0) = ARTICULOS_FABRICANTES.IdFabricante
        ObjParameter(1) = ARTICULOS_FABRICANTES.Nombre
        ObjParameter(2) = ARTICULOS_FABRICANTES.Descripcion

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_ARTICULOS_FABRICANTES", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_ARTICULOS_FABRICANTES", Id, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal ARTICULOS_FABRICANTES As Articulos_Fabricantes, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = ARTICULOS_FABRICANTES.IdFabricante
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_ARTICULOS_FABRICANTES", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Id As String) As Articulos_Fabricantes
        Dim dt As DataTable = ObtieneDatos("sp_sel_ARTICULOS_FABRICANTES", Id)
        Dim det As New Articulos_Fabricantes

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdFabricante = .Item("IdFabricante")
                det.Nombre = .Item("Nombre")
                det.Descripcion = .Item("Descripcion")
                det.Usuario = .Item("Usuario")
                det.Registro = .Item("Registro")
            End With
        End If
        Return det
    End Function
End Class
