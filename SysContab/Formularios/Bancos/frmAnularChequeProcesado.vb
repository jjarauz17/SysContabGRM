Imports System.Data
Imports System.Data.SqlClient

Public Class frmAnularChequeProcesado

    Public CodBanco As Integer = 0
    Public NoCheque As String = "0", Ok As String = "NO"
    Public NoCompr As Integer, Per_Id As Integer, Fecha As Date

    Private Sub frmAnularChequeProcesado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dFecha.DateTime = Now.Date
        ''
        Dim DT As DataTable = ObtieneDatos("SET DATEFORMAT dmy; EXEC SP_ComprobantesDetails " & NoCompr & "," & EmpresaActual & "," & Per_Id & ",'" & Fecha & "'")
        dgDatos.DataSource = DT
        vDatos.PopulateColumns()
        FormatoGrid(vDatos)

        For i As Integer = 0 To vDatos.Columns.Count - 1
            vDatos.Columns(i).Visible = False
        Next

        vDatos.Columns("Codigo").Visible = True
        vDatos.Columns("Nombre").Visible = True
        'vDatos.Columns("Observacion").Caption = "Concepto"
        vDatos.Columns("Debito").Visible = True
        vDatos.Columns("Credito").Visible = True

        vDatos.Columns("Debito").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vDatos.Columns("Debito").DisplayFormat.FormatString = "{0:n2}"
        vDatos.Columns("Debito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        vDatos.Columns("Debito").SummaryItem.DisplayFormat = "{0:n2}"
        '
        vDatos.Columns("Credito").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        vDatos.Columns("Credito").DisplayFormat.FormatString = "{0:n2}"
        vDatos.Columns("Credito").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        vDatos.Columns("Credito").SummaryItem.DisplayFormat = "{0:n2}"
        '
        vDatos.Columns("Codigo").VisibleIndex = 0
        vDatos.Columns("Nombre").VisibleIndex = 1
        vDatos.Columns("Debito").VisibleIndex = 2
        vDatos.Columns("Credito").VisibleIndex = 3
        '
        Dim DT2 As DataTable = ObtieneDatos("SP_GetDetalleCheque '" & NoCheque & "'," & CodBanco & "," & EmpresaActual)
        txtConcepto.Text = DT2.Rows.Item(0)("Concepto")
    End Sub

    Private Sub bAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAnular.Click
        If Not XtraMsg2("Esta Seguro de la Operación Solicitada?") Then
            Exit Sub
        End If
        '
        If GuardaDatos("SET DATEFORMAT dmy; EXEC JAR_CrearComprobanteReversion " & NoCompr & "," & Per_Id & "," & Fecha.Date.Month & "," & VB.SysContab.PeriodosDB.Activo(dFecha.DateTime.Date) & ",'" & dFecha.DateTime.Date & "'," & EmpresaActual) Then
            XtraMsg("Datos Guardados Correctamente!!!")
            Ok = "SI"
            Close()

            'Dim Comp As New VB.SysContab.ComprobanteDB()
            'Dim dt As DataTable = ObtieneDatos("SELECT * FROM PagosFacturas pf WHERE pf.Comp_No1 = " & NoCompr & " AND pf.PerID1 = " & Per_Id & " AND pf.Mes1 = " & Fecha.Date.Month & " AND Empresa_ID = " & EmpresaActual)

            'DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
            'DBConnFacturas.Open()
            'transaccionFacturas = DBConnFacturas.BeginTransaction

            'Try
            '    'Comp.ComprobanteAnular(NoCompr, Per_Id, Fecha)

            '    For i As Integer = 0 To dt.Rows.Count - 1
            '        Comp.CancelarFactura(dt.Rows.Item(i)("Factura"), dt.Rows.Item(i)("Proveedor"), 0)
            '    Next

            '    Comp.PagosFacturasBorrar(NoCompr, Fecha.Date.Month, Per_Id)
            '    ''EliminaDistribucion(compNo, Per_Id, Mes)

            '    VB.SysContab.Rutinas.okTransaccion()
            'Catch ex As Exception
            '    VB.SysContab.Rutinas.ErrorTransaccion()
            '    XtraMsg(ex.Message, MessageBoxIcon.Error)
            'End Try
        End If
    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        Ok = "NO"
        Close()
    End Sub
End Class
