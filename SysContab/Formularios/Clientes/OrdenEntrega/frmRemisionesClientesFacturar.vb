Imports System.IO
Imports ClasesBLL
Imports DevExpress.XtraReports.UI

Public Class frmRemisionesClientesFacturar
    Public Ok As String = "NO"
    Public IdCliente As Integer = 0, IdRemision As String = 0, NoRemision As String, Referencia As String
    Public DT_ROL As DataTable
    Dim DT As New DataTable("Remisiones")


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro")
            Exit Sub
        End If

        Dim dr() As DataRow = DT.Select("Seleccionar = 1")

        If dr.Length = 0 Then
            'XtraMsg("Debe seleccionar al menos 1 Remisión", MessageBoxIcon.Warning)
            'Exit Sub

            Ok = "OK"
            IdCliente = iVista.GetFocusedRowCellValue("IdCliente")
            IdRemision = iVista.GetFocusedRowCellValue("IdRemision")
            NoRemision = iVista.GetFocusedRowCellValue("NoRemision")
            Referencia = iVista.GetFocusedRowCellValue("Documento")

            Close()
        Else
            Dim DT_SELECT = DT.Select("Seleccionar = 1").CopyToDataTable

            IdRemision = "" : NoRemision = "" : Referencia = ""

            For i As Integer = 0 To DT_SELECT.Rows.Count - 1
                IdRemision = DT_SELECT.Rows.Item(i)("IdRemision").ToString() + ", " + IdRemision
                NoRemision = DT_SELECT.Rows.Item(i)("NoRemision").ToString() + ", " + NoRemision
                Referencia = DT_SELECT.Rows.Item(i)("Documento").ToString() + ", " + Referencia
            Next

            IdRemision = Mid(IdRemision, 1, IdRemision.Length - 2)
            NoRemision = Mid(NoRemision, 1, NoRemision.Length - 2)
            Referencia = Mid(Referencia, 1, Referencia.Length - 2)

            Ok = "OK"
            Close()
        End If
    End Sub

    Private Sub frmRemisionesClientesFacturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
        '
        iVista.PopulateColumns()
        FormatoGrid(iVista)

        For i As Integer = 1 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
            iVista.Columns(i).OptionsColumn.AllowFocus = False
        Next

        iVista.Columns("IdRemision").Visible = False
        iVista.Columns("IdCliente").Visible = False
        iVista.Columns("Concepto").Visible = False
        iVista.Columns("Registro").Visible = False
        iVista.Columns("Monto").Visible = False
        iVista.Columns("TCambio").Visible = False
        iVista.Columns("Direccion").Visible = False
        iVista.Columns("Placa").Visible = False
        iVista.Columns("Conductor").Visible = False
        iVista.Columns("Activo").Visible = False
        iVista.Columns("TCambio").Visible = False
        iVista.Columns("Registro").Visible = False

        iVista.Columns("Seleccionar").OptionsColumn.AllowEdit = True
        iVista.Columns("Seleccionar").OptionsColumn.AllowFocus = True
    End Sub

    Public Sub Cargar()
        DT = db_Remisiones.ListarPendientes(IdCliente)
        iGrid.DataSource = DT
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        With frmRemisionesClienteAdd
            Inicio = False
            .DT_ROL = DT_ROL
            .IdRemision = iVista.GetFocusedRowCellValue("IdRemision")
            .Text = "Editar Remisión"
            .bGuardar.Enabled = False
            .iVista.OptionsBehavior.Editable = False
            .ShowDialog()
            .Dispose()
            Inicio = False
        End With
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un registro!")
            Exit Sub
        End If
        '
        Imprimir(iVista.GetFocusedRowCellValue("IdRemision"))
    End Sub

    Sub Imprimir(IdRemision As Integer)
        ShowSplash("Imprimiendo...")

        Dim Cadena As String
        Dim Temp As Boolean = False
        Dim Data() As Byte

        Try
            Data = CType(ObtieneDatos("sp_get_formato_imprimir", 10, EmpresaActual).Rows(0).Item(0), Byte())
            Temp = True
            '
            Dim Tamano As Integer
            Tamano = Data.GetUpperBound(0)
            Cadena = Application.StartupPath & "\rptOrdenEntrega.repx"
            If File.Exists(Cadena) Then Kill(Cadena)
            Dim Archivo As New FileStream(Cadena, FileMode.OpenOrCreate, FileAccess.Write)
            Archivo.Write(Data, 0, Tamano)
            Archivo.Close()

        Catch ex As Exception
            Temp = False
        End Try

        Dim rpt As rptRemisiones

        If Temp = True Then
            rpt = XtraReport.FromFile(Application.StartupPath & "\rptOrdenEntrega.repx", True)
        Else
            rpt = New rptRemisiones
        End If

        rpt.DT_ROL = DT_ROL
        rpt.IdSucursal = db_Remisiones.Detalles(IdRemision).Sucursal
        rpt.DataSource = ObtieneDatos("sp_sel_Remisiones_Imprimir", IdRemision, EmpresaActual)
        rpt.ShowPrintMarginsWarning = False
        rpt.BringToFront()
        '
        HideSplash()
        rpt.ShowRibbonPreview()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = "NO"
        Close()
    End Sub
End Class