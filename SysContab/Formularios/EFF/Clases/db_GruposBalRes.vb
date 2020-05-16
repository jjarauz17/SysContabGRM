Imports System.Data.SqlClient

Public Class db_GruposBalRes
    Inherits ClComun
    Dim vGruposBalResTabla As New GruposBalRes
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property GruposBalResTabla() As GruposBalRes
        Get
            Return vGruposBalResTabla
        End Get
        Set(ByVal value As GruposBalRes)
            vGruposBalResTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal GruposBalRes As GruposBalRes, Optional Tran As Boolean = False) As Integer

        Dim ObjParameter(28) As String
        ObjParameter(0) = GruposBalRes.IdGrupo
        ObjParameter(1) = GruposBalRes.Codigo
        ObjParameter(2) = GruposBalRes.Nombre
        ObjParameter(3) = GruposBalRes.Nivel
        ObjParameter(4) = GruposBalRes.Tipo
        ObjParameter(5) = GruposBalRes.Orden
        ObjParameter(6) = GruposBalRes.Cuenta
        ObjParameter(7) = GruposBalRes.Color
        ObjParameter(8) = GruposBalRes.Operacion
        ObjParameter(9) = GruposBalRes.Formula
        ObjParameter(10) = GruposBalRes.Fuente
        ObjParameter(11) = GruposBalRes.Movimiento
        ObjParameter(12) = GruposBalRes.IdPadre
        ObjParameter(13) = GruposBalRes.Usuario
        ObjParameter(14) = GruposBalRes.Registro
        ObjParameter(15) = GruposBalRes.Titulo
        ObjParameter(16) = GruposBalRes.SubTitulo
        ObjParameter(17) = GruposBalRes.Tipo_Grupo
        ObjParameter(18) = GruposBalRes.Factor
        ObjParameter(19) = GruposBalRes.Utilidad
        ObjParameter(20) = GruposBalRes.Utilidad_Mes
        ObjParameter(21) = GruposBalRes.Utilidad_Acumulado
        ObjParameter(22) = GruposBalRes.VentasTotales
        ObjParameter(23) = GruposBalRes.Empresa
        ObjParameter(24) = GruposBalRes.Columna
        ObjParameter(25) = GruposBalRes.Negrita
        ObjParameter(26) = GruposBalRes.Anexo
        ObjParameter(27) = GruposBalRes.VentaDeCosto

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As SqlCommand = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_GruposBalRes", ObjParameter)
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
            MensajeError = ex.Message
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal GruposBalRes As GruposBalRes, Optional Tran As Boolean = False)
        Dim ObjParameter(26) As String

        ObjParameter(0) = GruposBalRes.IdGrupo
        ObjParameter(1) = GruposBalRes.Codigo
        ObjParameter(2) = GruposBalRes.Nombre
        ObjParameter(3) = GruposBalRes.Nivel
        ObjParameter(4) = GruposBalRes.Tipo
        ObjParameter(5) = GruposBalRes.Orden
        ObjParameter(6) = GruposBalRes.Cuenta
        ObjParameter(7) = GruposBalRes.Color
        ObjParameter(8) = GruposBalRes.Operacion
        ObjParameter(9) = GruposBalRes.Formula
        ObjParameter(10) = GruposBalRes.Fuente
        ObjParameter(11) = GruposBalRes.Movimiento
        ObjParameter(12) = GruposBalRes.IdPadre
        ObjParameter(13) = GruposBalRes.Titulo
        ObjParameter(14) = GruposBalRes.SubTitulo
        ObjParameter(15) = GruposBalRes.Tipo_Grupo
        ObjParameter(16) = GruposBalRes.Factor
        ObjParameter(17) = GruposBalRes.Utilidad
        ObjParameter(18) = GruposBalRes.Utilidad_Mes
        ObjParameter(19) = GruposBalRes.Utilidad_Acumulado
        ObjParameter(20) = GruposBalRes.VentasTotales
        ObjParameter(21) = GruposBalRes.Empresa
        ObjParameter(22) = GruposBalRes.Columna
        ObjParameter(23) = GruposBalRes.Negrita
        ObjParameter(24) = GruposBalRes.Anexo
        ObjParameter(25) = GruposBalRes.VentaDeCosto


        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            vGruposBalResTabla.IdGrupo = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_GruposBalRes", ObjParameter).ExecuteNonQuery()
            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            MensajeError = ex.Message
            XtraMsg(ex.Message, MessageBoxIcon.Error)
            'Mensaje(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Listar(ByVal Id As String, Tipo As String) As Data.DataTable

        Return DAL.Cargar("sp_sel_GruposBalRes", Id, Tipo, EmpresaActual)
    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function GetGruposPadres(Tipo As String) As Data.DataTable

        Return DAL.Cargar("sp_GetGruposPadres", Tipo, EmpresaActual)
    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal GruposBalRes As GruposBalRes, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = GruposBalRes.IdGrupo

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()
            Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_GruposBalRes", ObjParameter).ExecuteNonQuery()
            If Tran = False Then
                Commit()
            End If
        Catch ex As Exception
            Me.CodigoError = -1
            If Tran = False Then
                Rollback()
            End If
            Me.MensajeError = ex.Message
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Sub

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Id As String, Tipo As String) As GruposBalRes
        Dim dt As DataTable = DAL.Cargar("sp_sel_GruposBalRes", Id, Tipo, EmpresaActual)
        Dim det As New GruposBalRes

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdGrupo = .Item("IdGrupo")
                det.Codigo = .Item("Codigo")
                det.Nombre = .Item("Nombre")
                det.Nivel = .Item("Nivel")
                det.Tipo = .Item("Tipo")
                det.Orden = .Item("Orden")
                det.Cuenta = IsNull(.Item("Cuenta"), "")
                det.Color = IsNull(.Item("Color"), "")
                det.Operacion = IsNull(.Item("Operacion"), 0)
                det.Formula = IsNull(.Item("Formula"), "")
                det.Fuente = IsNull(.Item("Fuente"), "")
                det.Movimiento = IIf(IsNull(.Item("Movimiento"), False), 1, 0)
                det.IdPadre = .Item("IdPadre")
                det.Usuario = .Item("Usuario")
                det.Registro = .Item("Registro")
                det.Titulo = IIf(.Item("Titulo"), 1, 0)
                det.SubTitulo = IIf(.Item("SubTitulo"), 1, 0)
                det.Tipo_Grupo = .Item("Tipo_Grupo")
                det.Factor = .Item("Factor")
                det.Utilidad = .Item("Utilidad")
                det.Utilidad_Mes = .Item("Utilidad_Mes")
                det.Utilidad_Acumulado = .Item("Utilidad_Acumulado")
                det.VentasTotales = .Item("VentasTotales")
                det.Empresa = EmpresaActual
                det.Columna = .Item("Columna")
                det.Negrita = IIf(.Item("Negrita"), 1, 0)
                det.Anexo = IIf(.Item("Anexo"), 1, 0)
                det.VentaDeCosto = IsNull(.Item("VentaDeCosto"), "")
            End With
        End If
        Return det
    End Function
End Class
