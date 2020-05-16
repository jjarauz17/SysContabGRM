
Imports System.Data.SqlClient

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
    Public Sub Insertar(ByVal AnticiposClientes As AnticiposClientes, Optional Tran As Boolean = False)
        Dim ObjParameter(19) As String
        ObjParameter(0) = AnticiposClientes.Numero
        ObjParameter(1) = AnticiposClientes.Empresa
        ObjParameter(2) = AnticiposClientes.IdCliente
        ObjParameter(3) = AnticiposClientes.NoDocumento
        ObjParameter(4) = AnticiposClientes.Referencia
        ObjParameter(5) = AnticiposClientes.Fecha
        ObjParameter(6) = AnticiposClientes.TipoComprobante
        ObjParameter(7) = AnticiposClientes.Moneda
        ObjParameter(8) = AnticiposClientes.Monto
        ObjParameter(9) = AnticiposClientes.Concepto
        ObjParameter(10) = AnticiposClientes.Estado
        ObjParameter(11) = AnticiposClientes.Anulado
        ObjParameter(12) = AnticiposClientes.Comp_No
        ObjParameter(13) = AnticiposClientes.Per_Id
        ObjParameter(14) = AnticiposClientes.Mes
        ObjParameter(15) = AnticiposClientes.IdNota
        ObjParameter(16) = AnticiposClientes.Factura
        ObjParameter(17) = AnticiposClientes.Usuario
        ObjParameter(18) = AnticiposClientes.Registro

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_AnticiposClientes", ObjParameter)
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
    Public Sub Actualizar(ByVal AnticiposClientes As AnticiposClientes, Optional Tran As Boolean = False)
        Dim ObjParameter(20) As String
        ObjParameter(0) = AnticiposClientes.IdAnticipo
        ObjParameter(1) = AnticiposClientes.Numero
        ObjParameter(2) = EmpresaActual
        ObjParameter(3) = AnticiposClientes.IdCliente
        ObjParameter(4) = AnticiposClientes.NoDocumento
        ObjParameter(5) = AnticiposClientes.Referencia
        ObjParameter(6) = AnticiposClientes.Fecha
        ObjParameter(7) = AnticiposClientes.TipoComprobante
        ObjParameter(8) = AnticiposClientes.Moneda
        ObjParameter(9) = AnticiposClientes.Monto
        ObjParameter(10) = AnticiposClientes.Concepto
        ObjParameter(11) = AnticiposClientes.Estado
        ObjParameter(12) = AnticiposClientes.Anulado
        ObjParameter(13) = AnticiposClientes.Comp_No
        ObjParameter(14) = AnticiposClientes.Per_Id
        ObjParameter(15) = AnticiposClientes.Mes
        ObjParameter(16) = AnticiposClientes.IdNota
        ObjParameter(17) = AnticiposClientes.Factura
        ObjParameter(18) = AnticiposClientes.Usuario
        ObjParameter(19) = AnticiposClientes.Registro

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

        Return ObtieneDatos("sp_sel_AnticiposClientes", Id, Desde, Hasta, EmpresaActual)

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
        Dim dt As DataTable = ObtieneDatos("sp_sel_AnticiposClientes", Id)
        Dim det As New AnticiposClientes

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                det.IdAnticipo = .Item("IdAnticipo")
                det.Numero = .Item("Numero")
                det.Empresa = .Item("Empresa")
                det.IdCliente = .Item("IdCliente")
                det.NoDocumento = .Item("NoDocumento")
                det.Referencia = .Item("Referencia")
                det.Fecha = .Item("Fecha")
                det.TipoComprobante = .Item("TipoComprobante")
                det.Moneda = .Item("Moneda")
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
                det.Registro = .Item("Registro")
            End With
        End If
        Return det
    End Function
End Class
