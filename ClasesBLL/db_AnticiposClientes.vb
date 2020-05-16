
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class db_AnticiposClientes
    Inherits ClComun
    Dim vAnticiposClientesTabla As New AnticiposClientes
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property AnticiposClientesTabla() As AnticiposClientes
        Get
            Return vAnticiposClientesTabla
        End Get
        Set(ByVal value As AnticiposClientes)
            vAnticiposClientesTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal AnticiposClientes As AnticiposClientes, Optional Tran As Boolean = False) As Integer
        Dim ObjParameter(21) As String
        ObjParameter(0) = AnticiposClientes.IdAnticipo
        ObjParameter(1) = AnticiposClientes.Numero
        ObjParameter(2) = EmpresaA
        ObjParameter(3) = AnticiposClientes.IdCliente
        ObjParameter(4) = AnticiposClientes.NoRecibo
        ObjParameter(5) = AnticiposClientes.NoCheque
        ObjParameter(6) = AnticiposClientes.Referencia
        ObjParameter(7) = AnticiposClientes.Fecha
        ObjParameter(8) = AnticiposClientes.TipoComprobante
        ObjParameter(9) = AnticiposClientes.FormaPago
        ObjParameter(10) = AnticiposClientes.Banco
        ObjParameter(11) = AnticiposClientes.Moneda
        ObjParameter(12) = AnticiposClientes.TCambio
        ObjParameter(13) = AnticiposClientes.Monto
        ObjParameter(14) = AnticiposClientes.Concepto
        ObjParameter(15) = AnticiposClientes.Comp_No
        ObjParameter(16) = AnticiposClientes.Per_Id
        ObjParameter(17) = AnticiposClientes.Mes
        ObjParameter(18) = AnticiposClientes.IdNota
        ObjParameter(19) = AnticiposClientes.Caja
        ObjParameter(20) = AnticiposClientes.Vendedor

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_AnticiposClientes", ObjParameter)
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
    Public Sub Actualizar(ByVal AnticiposClientes As AnticiposClientes, Optional Tran As Boolean = False)
        Dim ObjParameter(21) As String

        ObjParameter(0) = AnticiposClientes.IdAnticipo
        ObjParameter(1) = AnticiposClientes.Numero
        ObjParameter(2) = EmpresaA
        ObjParameter(3) = AnticiposClientes.IdCliente
        ObjParameter(4) = AnticiposClientes.NoRecibo
        ObjParameter(5) = AnticiposClientes.NoCheque
        ObjParameter(6) = AnticiposClientes.Referencia
        ObjParameter(7) = AnticiposClientes.Fecha
        ObjParameter(8) = AnticiposClientes.TipoComprobante
        ObjParameter(9) = AnticiposClientes.FormaPago
        ObjParameter(10) = AnticiposClientes.Banco
        ObjParameter(11) = AnticiposClientes.Moneda
        ObjParameter(12) = AnticiposClientes.TCambio
        ObjParameter(13) = AnticiposClientes.Monto
        ObjParameter(14) = AnticiposClientes.Concepto
        ObjParameter(15) = AnticiposClientes.Comp_No
        ObjParameter(16) = AnticiposClientes.Per_Id
        ObjParameter(17) = AnticiposClientes.Mes
        ObjParameter(18) = AnticiposClientes.IdNota
        ObjParameter(19) = AnticiposClientes.Caja
        ObjParameter(20) = AnticiposClientes.Vendedor

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_AnticiposClientes", ObjParameter)
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
    Public Shared Function Listar(ByVal Id As String, Desde As Date, Hasta As Date) As Data.DataTable

        Return ObtieneDatos("sp_sel_AnticiposClientes",
                            Id,
                            Desde,
                            Hasta,
                            EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function ReporteAuxiliar(Desde As Date, Hasta As Date, Moneda As String) As Data.DataTable

        Return ObtieneDatos("sp_sel_AnticiposClientesReporte",
                            Desde,
                            Hasta,
                            Moneda,
                            EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

    Public Shared Function GetNumero() As String

        Return ObtieneDatos("sp_AnticiposClientes_Numero", EmpresaA).Rows.Item(0)("Numero")

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function UpdateEstado(IdAnticipo As Integer, Estado As String,
                                        IdNota As Integer, Monto As Double) As Boolean

        Return Guardar("sp_AnticiposClientes_NC", IdAnticipo, Estado, IdNota, Monto, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

    Public Shared Function BorrarDetalle(IdAnticipo As Integer) As Boolean

        Return Guardar("sp_AnticiposClientes_BorrarDetalle", IdAnticipo, EmpresaA)

    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --

    Public Sub Borrar(ByVal AnticiposClientes As AnticiposClientes, Optional Tran As Boolean = False)
        Dim ObjParameter(1) As String
        ObjParameter(0) = AnticiposClientes.IdAnticipo
        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_AnticiposClientes", ObjParameter)
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
    Public Shared Function Detalles(ByVal Id As String) As AnticiposClientes
        Dim dt As DataTable = ObtieneDatos("sp_sel_AnticiposClientes", Id, Now.Date, Now.Date, EmpresaA)
        Dim det As New AnticiposClientes

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdAnticipo = .Item("IdAnticipo")
                det.Numero = .Item("Numero")
                det.Empresa = .Item("Empresa")
                det.IdCliente = .Item("IdCliente")
                det.Caja = .Item("Caja")
                det.NoRecibo = .Item("NoRecibo")
                det.NoCheque = .Item("NoCheque")
                det.Referencia = .Item("Referencia")
                det.Fecha = .Item("Fecha")
                det.Banco = .Item("Banco")
                det.FormaPago = .Item("FormaPago")
                det.TipoComprobante = .Item("TipoComprobante")
                det.Moneda = .Item("Moneda")
                det.TCambio = .Item("TCambio")
                det.Monto = .Item("Monto")
                det.Concepto = .Item("Concepto")
                det.Estado = .Item("Estado")
                det.Anulado = .Item("Anulado")
                det.Comp_No = .Item("Comp_No")
                det.Per_Id = .Item("Per_Id")
                det.Mes = .Item("Mes")
                det.IdNota = .Item("IdNota")
                det.Factura = .Item("Factura")
                det.Usuario = .Item("Usuario")
                det.Vendedor = .Item("Vendedor")
                'det.Registro = .Item("Registro")
            End With
        End If
        Return det
    End Function
End Class
