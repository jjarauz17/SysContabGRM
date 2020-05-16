
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_Combos
    Inherits ClComun
    Dim vCombosTabla As New Combos
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property CombosTabla() As Combos
        Get
            Return vCombosTabla
        End Get
        Set(ByVal value As Combos)
            vCombosTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Insertar(ByVal Combos As Combos, Optional Tran As Boolean = False)
        Dim ObjParameter(6) As String
        ObjParameter(0) = EmpresaA
        ObjParameter(1) = Combos.Codigo_Combo
        ObjParameter(2) = Combos.Producto
        ObjParameter(3) = Combos.Unidad
        ObjParameter(4) = Combos.Cantidad
        ObjParameter(5) = Combos.Costo

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Combos", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, Windows.Forms.MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal Combos As Combos, Optional Tran As Boolean = False)
        Dim ObjParameter(7) As String
        ObjParameter(0) = Combos.IdDetalle
        ObjParameter(1) = EmpresaA
        ObjParameter(2) = Combos.Codigo_Combo
        ObjParameter(3) = Combos.Producto
        ObjParameter(4) = Combos.Unidad
        ObjParameter(5) = Combos.Cantidad
        ObjParameter(6) = Combos.Costo

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Combos", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, Windows.Forms.MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar(ByVal Id As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_Combos", Id, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function ListarProducir(Desde As Date, Hasta As Date) As Data.DataTable

        Return ObtieneDatos("sp_CombosPrcesar", Desde, Hasta, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

    Public Shared Function Producir(Codigo As String, Factura As String, IdMovE As Integer, IdMovS As Integer) As Boolean

        Return Guardar("sp_ins_CombosProducir", Codigo, Factura, IdMovE, IdMovS, EmpresaA)

    End Function

    Public Function Borrar(ByVal Combos As Combos, Optional Tran As Boolean = False) As String
        Dim ObjParameter(3) As String
        ObjParameter(0) = ""
        ObjParameter(1) = Combos.Codigo_Combo
        ObjParameter(2) = EmpresaA
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Combos", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If

            Return cmd.Parameters(1).Value
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return ex.Message
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function BorrarDetalle(ByVal Combos As Combos, Optional Tran As Boolean = False) As Boolean
        Dim ObjParameter(2) As String
        ObjParameter(0) = Combos.IdDetalle
        ObjParameter(1) = EmpresaA
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_CombosDetalle", ObjParameter)
            cmd.ExecuteNonQuery()

            If Tran = False Then
                Commit()
            End If

            Return True
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            Return False
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Id As String) As Combos
        Dim dt As DataTable = ObtieneDatos("sp_sel_Combos", Id, EmpresaA)
        Dim det As New Combos

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdDetalle = .Item("IdDetalle")
                det.Empresa = .Item("Empresa")
                det.Codigo_Combo = .Item("Codigo_Combo")
                det.Producto = .Item("Producto")
                det.Unidad = .Item("Unidad")
                det.Cantidad = .Item("Cantidad")
                det.Costo = .Item("Costo")
                det.Usuario = .Item("Usuario")
                det.Registro = .Item("Registro")
            End With
        End If
        Return det
    End Function
End Class
