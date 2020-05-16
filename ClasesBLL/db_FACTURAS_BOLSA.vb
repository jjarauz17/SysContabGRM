
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_FACTURAS_BOLSA
    Inherits ClComun
    Dim vFACTURAS_BOLSATabla As New FACTURAS_BOLSA
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property FACTURAS_BOLSATabla() As FACTURAS_BOLSA
        Get
            Return vFACTURAS_BOLSATabla
        End Get
        Set(ByVal value As FACTURAS_BOLSA)
            vFACTURAS_BOLSATabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal FACTURAS_BOLSA As FACTURAS_BOLSA, Optional Tran As Boolean = False) As Integer
        Dim ObjParameter(5) As String
        ObjParameter(0) = FACTURAS_BOLSA.IdBolsa
        ObjParameter(1) = FACTURAS_BOLSA.Codigo
        ObjParameter(2) = EmpresaA
        ObjParameter(3) = FACTURAS_BOLSA.Fecha_Llave
        ObjParameter(4) = FACTURAS_BOLSA.Descripcion

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_FACTURAS_BOLSA", ObjParameter)
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
            Return 0
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function InsertarDetalle(ByVal FACTURAS_BOLSA As FACTURAS_BOLSA, Optional Tran As Boolean = False) As Boolean
        Dim ObjParameter(4) As String
        ObjParameter(0) = FACTURAS_BOLSA.Desde
        ObjParameter(1) = FACTURAS_BOLSA.Hasta
        ObjParameter(2) = FACTURAS_BOLSA.IdBolsa
        ObjParameter(3) = EmpresaA

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_FACTURAS_BOLSA_DETALLE", ObjParameter)
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
    Public Sub Actualizar(ByVal FACTURAS_BOLSA As FACTURAS_BOLSA, Optional Tran As Boolean = False)
        Dim ObjParameter(5) As String
        ObjParameter(0) = FACTURAS_BOLSA.IdBolsa
        ObjParameter(1) = FACTURAS_BOLSA.Codigo
        ObjParameter(2) = EmpresaA
        ObjParameter(3) = FACTURAS_BOLSA.Fecha_Llave
        ObjParameter(4) = FACTURAS_BOLSA.Descripcion

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_FACTURAS_BOLSA", ObjParameter)
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
    Public Shared Function Listar(ByVal Id As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_FACTURAS_BOLSA",
                            Id,
                            EmpresaA)

    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Reporte(ByVal Desde As Date,
                                   Hasta As Date,
                                   IdBolsa As Integer) As Data.DataTable

        Return ObtieneDatos("sp_sel_BolsaDetalleReporte",
                            Desde,
                            Hasta,
                            IdBolsa,
                            EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function UltimoCierre() As Date

        Return CDate(ObtieneDatos("sp_sel_FACTURAS_BOLSACierre",
                            EmpresaA) _
                            .Rows.Item(0)("UltimoCierre")).Date

    End Function

    Public Shared Function GetNumero() As String

        Return ObtieneDatos("sp_sel_FACTURAS_BOLSA_GetNumero",
                            EmpresaA) _
                            .Rows.Item(0)("Numero")

    End Function

    Public Shared Function MarcarFacturas(Desde As Date,
                                          Hasta As Date,
                                          IdBolsa As Integer) As Boolean

        Return Guardar("sp_FACTURAS_BOLSA_Marcar",
                                  Desde,
                                  Hasta,
                                  IdBolsa,
                                  EmpresaA)
    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Borrar(ByVal FACTURAS_BOLSA As FACTURAS_BOLSA, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = FACTURAS_BOLSA.IdBolsa
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_FACTURAS_BOLSA", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As Integer) As FACTURAS_BOLSA
        Dim dt As DataTable = ObtieneDatos("sp_sel_FACTURAS_BOLSA",
                                           Id,
                                           EmpresaA)
        Dim det As New FACTURAS_BOLSA

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdBolsa = .Item("IdBolsa")
                det.Codigo = .Item("Codigo")
                det.Empresa = .Item("Empresa")
                det.Fecha_Llave = .Item("Fecha_Llave")
                det.Descripcion = .Item("Descripcion")
                det.Aplicado = .Item("Aplicado")
                det.Anulado = .Item("Anulado")
                det.Fecha_Creacion = .Item("Fecha_Creacion")
                det.Usuario = .Item("Usuario")
            End With
        End If
        Return det
    End Function
End Class
