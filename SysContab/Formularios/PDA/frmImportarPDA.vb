Imports OpenNETCF.Desktop.Communication
Imports System.DirectoryServices
Imports System.IO
Imports System.Text
Imports System.Collections
Imports System.Configuration
Public Class frmImportarPDA

    Public miRapi As New RAPI
    Dim DS_CABECERA As New DataSet, DS_DETALLE As New DataSet
    Private Sub frmImportarPDA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub bTest_Click(sender As Object, e As EventArgs) Handles bTest.Click
        If Test() Then XtraMsg("Prueba de Conexión Exitosa, La PDA se encuentra Conectada!")
    End Sub

    Function Test() As Boolean
        If miRapi.DevicePresent = True Then
            miRapi.Connect()            
            Return True
        Else
            XtraMsg("La PDA no esta conectada a este equivo, favor conectarla e intentar de Nuevo.", MessageBoxIcon.Warning)
            Return False
        End If
    End Function

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        If Not Test() Then
            Exit Sub
        End If

        Dim xmlRequisa As String = "REQUISAS.xml"
        Dim xmlRequisaDetalle As String = "REQUISAS_DETALLE.xml"

        Try
            'Validar que se encuentren los archivos en la PDA
            If Not miRapi.DeviceFileExists("\My Documents\xml\" & xmlRequisa) Then
                XtraMsg("No se encuenta ningún Archivo de Cabacera en PDA para ser Importado!")
                Exit Sub
            End If

            If Not miRapi.DeviceFileExists("\My Documents\xml\" & xmlRequisaDetalle) Then
                XtraMsg("No se encuenta ningún Archivo de Detalle en PDA para ser Importado!")
                Exit Sub
            End If

            'Borrar los XML de la ubicacion Local
            If File.Exists(Application.StartupPath & "\xml\" & xmlRequisa) Then
                File.Delete(Application.StartupPath & "\xml\" & xmlRequisa)
            End If
            '
            If File.Exists(Application.StartupPath & "\xml\" & xmlRequisaDetalle) Then
                File.Delete(Application.StartupPath & "\xml\" & xmlRequisaDetalle)
            End If
            '
            'Copiar archivos de la PDA
            miRapi.CopyFileFromDevice(Application.StartupPath & "\xml\" & xmlRequisa, "\My Documents\xml\" & xmlRequisa)
            miRapi.CopyFileFromDevice(Application.StartupPath & "\xml\" & xmlRequisaDetalle, "\My Documents\xml\" & xmlRequisaDetalle)

            DS_CABECERA = Nothing
            DS_DETALLE = Nothing

            DS_CABECERA = New DataSet
            DS_DETALLE = New DataSet

            DS_CABECERA.ReadXml(Application.StartupPath & "\xml\" & xmlRequisa, XmlReadMode.Auto)
            DS_DETALLE.ReadXml(Application.StartupPath & "\xml\" & xmlRequisaDetalle, XmlReadMode.Auto)

            If DS_CABECERA.Tables(0).Rows.Count > 0 Then
                'Agregar Registros a la Tabla
                GuardarRequisaTemp()
            End If
        Catch ex As Exception
            XtraMsg(ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub GuardarRequisaTemp()
        Dim Requisa As Integer = 0

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Conn.IniciarTransaccion()

        Try
            ShowSplash("Guardando Movimiento...")
            '
            For i As Integer = 0 To DS_CABECERA.Tables(0).Rows.Count - 1

                Conn.RemoveParameters()
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Codigo", SqlDbType.Int, 5, ParameterDirection.Output, 0)
                Conn.EjecutarComando("JAR_GetList_RequisaCodigoNuevo")
                Requisa = Conn.GetParameter("Codigo").Valor
                '
                Conn.RemoveParameters()
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                Conn.AddParameter("TRequisa", SqlDbType.NVarChar, 5, ParameterDirection.Input, DS_CABECERA.Tables(0).Rows.Item(i)("Req_Tipo"))
                Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, CDate(DS_CABECERA.Tables(0).Rows.Item(i)("Fecha")).Date)
                Conn.AddParameter("Bodega", SqlDbType.NVarChar, 15, ParameterDirection.Input, DS_CABECERA.Tables(0).Rows.Item(i)("IDBodega"))
                Conn.AddParameter("RealizadoPor", SqlDbType.NVarChar, 50, ParameterDirection.Input, Login)
                Conn.AddParameter("Registro", SqlDbType.Bit, 1, ParameterDirection.Input, False)
                Conn.AddParameter("Factura", SqlDbType.NVarChar, 15, ParameterDirection.Input, "")
                Conn.AddParameter("Movimiento", SqlDbType.Int, 4, ParameterDirection.Input, 0)
                Conn.AddParameter("Referencia", SqlDbType.NVarChar, 100, ParameterDirection.Input, DS_CABECERA.Tables(0).Rows.Item(i)("Referencia"))
                Conn.EjecutarComando("JAR_Requisas_Add")

                Dim DT As DataTable =
                    DS_DETALLE.Tables(0).Select("Req_Codigo = '" & DS_CABECERA.Tables(0).Rows.Item(i)("Req_Codigo") & "'").CopyToDataTable

                If Not DT Is Nothing Then
                    For j As Integer = 0 To DT.Rows.Count - 1
                        'Agregar el detalle de la requisa
                        If DT.Rows(j)("Cantidad") > 0 Then
                            Conn.RemoveParameters()
                            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
                            Conn.AddParameter("Requisa", SqlDbType.Int, 5, ParameterDirection.Input, Requisa)
                            Conn.AddParameter("Articulo", SqlDbType.NVarChar, 50, ParameterDirection.Input, DT.Rows(j)("IDArticulo"))
                            Conn.AddParameter("TArticulo", SqlDbType.NVarChar, 20, ParameterDirection.Input, "P")
                            Conn.AddParameter("Cantidad", SqlDbType.Decimal, 20, ParameterDirection.Input, DT.Rows(j)("Cantidad"))
                            Conn.AddParameter("Precio", SqlDbType.Decimal, 20, ParameterDirection.Input, DT.Rows.Item(j)("Precio"))
                            Conn.AddParameter("Cuenta", SqlDbType.NVarChar, 50, ParameterDirection.Input, "")
                            Conn.AddParameter("Ubicacion", SqlDbType.NVarChar, 50, ParameterDirection.Input, IsNull(DT.Rows.Item(j)("Ubicacion"), ""))
                            '
                            Conn.EjecutarComando("JAR_Requisas_Detalle_Add")
                        End If
                    Next
                End If
                '
            Next
            Conn.CompletarTransaccion()

            HideSplash()
            XtraMsg("Registros Importados Satisfactoriamente!", MessageBoxIcon.Information)
            GetData()
        Catch ex As Exception
            HideSplash()
            XtraMsg(ex.Message & "Leer de PDA", MessageBoxIcon.Error)
            Conn.AnularTransaccion()
        End Try
    End Sub

    Public Sub GetData()
        iGrid.DataSource = ObtieneDatos("JAR_GetList_RequisasImportar", EmpresaActual)
        iVista.PopulateColumns()
        FormatoGrid(iVista)
        '
        For i As Integer = 0 To iVista.Columns.Count - 1
            iVista.Columns(i).OptionsColumn.AllowEdit = False
        Next
        '
        iVista.Columns("IdRequisa").Visible = False
        'iVista.Columns("Seleccionar").OptionsColumn.AllowEdit = True
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro!")
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Procesado") Then
            XtraMsg("El Inventario que intenta Grabar ya se encuentra procesado.", MessageBoxIcon.Error)
            Exit Sub
        End If

        'Dim IdRequisa As String = ""

        'For i As Integer = 0 To iVista.DataRowCount - 1
        '    If iVista.GetRowCellValue(i, "Seleccionar") Then
        '        IdRequisa = iVista.GetRowCellValue(i, "IdRequisa").ToString + ", " + IdRequisa
        '    End If
        'Next

        With frmGuardarMovimiento
            ' IdRequisa = Mid(IdRequisa, 1, IdRequisa.Length - 2)
            .IdRequisa_Importar = iVista.GetFocusedRowCellValue("IdRequisa")
            .Tipo = 1
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If iVista.FocusedRowHandle < 0 Then
            XtraMsg("Seleccione un Registro!")
            Exit Sub
        End If
        '
        If iVista.GetFocusedRowCellValue("Procesado") Then
            XtraMsg("El Inventario que intenta borrar ya se encuentra procesado.", MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not XtraMsg2("Esta Seguro de Borrar el Inventario Seleccionado?") Then
            Exit Sub
        End If

        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())
        Try
            Conn.RemoveParameters()
            Conn.AddParameter("IdRequisa", SqlDbType.Int, 5, ParameterDirection.Input, iVista.GetFocusedRowCellValue("IdRequisa"))
            Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)
            Conn.EjecutarComando("JAR_DeleteRequisaMovil")

            GetData()
        Catch ex As Exception
            XtraMsg(ex.Message & ". Borrar", MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        frmExportarImprimir.Mostrar(iGrid, "Inventarios Importados")
    End Sub

    Private Sub iVista_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles iVista.RowCellStyle
        If e.Column.FieldName = "Procesado" Then
            If iVista.GetRowCellValue(e.RowHandle, "Procesado") Then
                e.Appearance.BackColor = Color.DarkGreen
            Else
                e.Appearance.BackColor = Color.Salmon
            End If
        End If
    End Sub
End Class