
Imports System.Data.SqlClient

Public Class db_Prod_CatMaestroFormula
    Inherits ClComun
    Dim vProd_CatMaestroFormulaTabla As New Prod_CatMaestroFormula
    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 
    Public Property Prod_CatMaestroFormulaTabla() As Prod_CatMaestroFormula
        Get
            Return vProd_CatMaestroFormulaTabla
        End Get
        Set(ByVal value As Prod_CatMaestroFormula)
            vProd_CatMaestroFormulaTabla = value
        End Set
    End Property

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Insertar(ByVal Prod_CatMaestroFormula As Prod_CatMaestroFormula, Optional Tran As Boolean = False) As Integer
        Dim ObjParameter(6) As String
        ObjParameter(0) = Prod_CatMaestroFormula.IdSysFormula
        ObjParameter(1) = Prod_CatMaestroFormula.EMPRESA
        ObjParameter(2) = Prod_CatMaestroFormula.TIPO
        ObjParameter(3) = Prod_CatMaestroFormula.CODIGO_ARTICULO
        ObjParameter(4) = Prod_CatMaestroFormula.Numero
        ObjParameter(5) = Prod_CatMaestroFormula.Descripcion

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_ins_Prod_CatMaestroFormula", ObjParameter)
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
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function


    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Sub Actualizar(ByVal Prod_CatMaestroFormula As Prod_CatMaestroFormula, Optional Tran As Boolean = False)
        Dim ObjParameter(5) As String
        ObjParameter(0) = Prod_CatMaestroFormula.IdSysFormula
        ObjParameter(1) = Prod_CatMaestroFormula.EMPRESA
        ObjParameter(2) = Prod_CatMaestroFormula.TIPO
        ObjParameter(3) = Prod_CatMaestroFormula.CODIGO_ARTICULO
        ObjParameter(4) = Prod_CatMaestroFormula.Descripcion

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_upd_Prod_CatMaestroFormula", ObjParameter)
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

        Return ObtieneDatos("sp_sel_Prod_CatMaestroFormula", Id, EmpresaActual)

    End Function

    Public Shared Function GetNumero() As String

        Return ObtieneDatos("sp_GetNumero_Formula", EmpresaActual).Rows.Item(0)("Numero")

    End Function

  

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Function Borrar(ByVal Prod_CatMaestroFormula As Prod_CatMaestroFormula, Optional Tran As Boolean = False) As String
        Dim ObjParameter(2) As String
        ObjParameter(0) = Prod_CatMaestroFormula.msg
        ObjParameter(1) = Prod_CatMaestroFormula.IdSysFormula

        Try
            Me.InicializarMensajeError()
            Me.OpenSqlBD()

            Dim cmd As New SqlCommand
            cmd = Me.ConfigurarComando(TieneTransaccion.Si, "sp_del_Prod_CatMaestroFormula", ObjParameter)
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
        Finally
            If Tran = False Then
                CloseSqlBD()
            End If
        End Try
    End Function

    '-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --
    Public Shared Function Detalles(ByVal Id As String) As Prod_CatMaestroFormula
        Dim dt As DataTable = ObtieneDatos("sp_sel_Prod_CatMaestroFormula", Id, EmpresaActual)
        Dim det As New Prod_CatMaestroFormula

        If dt.Rows.Count > 0 Then
            With dt.rows(0)
                det.IdSysFormula = .Item("IdSysFormula")
                det.Numero = .Item("Numero")
                det.EMPRESA = .item("EMPRESA")
                det.TIPO = .item("TIPO")
                det.CODIGO_ARTICULO = .Item("CODIGO_ARTICULO")
                det.Descripcion = .Item("Descripcion")
            End With
        End If
        Return det
    End Function
End Class
