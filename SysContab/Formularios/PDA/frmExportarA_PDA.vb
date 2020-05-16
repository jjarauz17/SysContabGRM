Imports OpenNETCF.Desktop.Communication
Imports System.IO
Imports System.DirectoryServices
Imports System
Imports System.Text
Imports System.Collections
Imports System.Configuration
Public Class frmExportarA_PDA

    Public miRapi As New RAPI

    Private Sub frmExportarA_PDA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        '
        Combo(cbCatalogos, ObtieneDatos("PDA_CatalogosExportar"))
        ' GetBodegasList(cbBodegas)
        GetBodegasxUsuario(cbBodegas, 0)
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        If cbCatalogos.EditValue = 1 Then
            If cbBodegas.EditValue Is Nothing Then
                XtraMsg("Seleccione Bodega!")
                cbBodegas.Focus()
                Exit Sub
            End If
        End If
        '
        ShowSplash("Cargando Datos....")
        Cargar()
        HideSplash()
    End Sub

    Sub Cargar()
        iGrid.DataSource = ObtieneDatos("PDA_GetCatalgosExportar", cbCatalogos.EditValue, cbBodegas.EditValue, EmpresaActual)
        iVista.PopulateColumns()
        FormatoGrid(iVista, 4, 0, False, False, True)
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

    Private Sub bTest_Click(sender As Object, e As EventArgs) Handles bTest.Click
        If Test() Then XtraMsg("Prueba de Conexión Exitosa, La PDA se encuentra Conectada!")        
    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        If iVista.DataRowCount = 0 Then
            XtraMsg("No hay datos disponibles para Exportar a PDA!", MessageBoxIcon.Warning)
            Exit Sub
        End If
        '
        If Not Test() Then
            Exit Sub
        End If

        Dim DS As New DataSet
        Dim Exportado As Boolean = False

        Try
            ShowSplash("Exportando a PDA...")

            Dim DT As DataTable = ObtieneDatos("PDA_GetCatalgosExportar", cbCatalogos.EditValue, cbBodegas.EditValue, EmpresaActual)
            DS.Tables.Add(DT)

            Dim xmlNombre As String = ""
            If cbCatalogos.EditValue = 1 Then xmlNombre = "ITEM_MOVIL.xml"
            If cbCatalogos.EditValue = 2 Then xmlNombre = "BODEGAS.xml"
            If cbCatalogos.EditValue = 3 Then xmlNombre = "EMPRESAS.xml"

            DT.WriteXml(Application.StartupPath & "\xml\" & xmlNombre, XmlWriteMode.WriteSchema)
            '
            '/**************************************************************************
            '**********   RECREANDO DIRECTORIOS EN PDA  *******************************
            '**************************************************************************/
            Try
                'Creando carpeta XML
                If miRapi.DeviceFileExists("My Documents\xml\" & xmlNombre) Then
                    miRapi.RemoveDeviceDirectory("My Documents\xml", True)
                End If

                If Not miRapi.DeviceFileExists("\My Documents\xml\" & xmlNombre) Then
                    miRapi.CreateDeviceDirectory("\My Documents\xml\")
                End If

            Catch ex As Exception
                If StrComp(ex.Message.ToUpper.Trim, "could not create directory".ToUpper) = -1 Then
                    XtraMsg(String.Format("Error en Directorio de PDA: {0} Detalle: {1} Error:", ex.Message, ex.StackTrace), MessageBoxIcon.Error)
                End If
                '' Exit Sub
            End Try
            '
            Try
                miRapi.CopyFileToDevice(Application.StartupPath & "\Xml\" & xmlNombre, "\My Documents\xml\" & xmlNombre)

                Exportado = True

                miRapi.Disconnect()
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
                Exportado = False
            End Try


            If Exportado Then XtraMsg("La Exportación a PDA ha sido Exitosa...")
            HideSplash()
        Catch ex As Exception
            HideSplash()
        End Try
        
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub cbCatalogos_EditValueChanged(sender As Object, e As EventArgs) Handles cbCatalogos.EditValueChanged

    End Sub
End Class