Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmVencimientoFacturasV

    Dim DT As DataTable

    Private Sub bImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bImportar.Click
        Me.OpenFileDialog1.DefaultExt = "*.xls"
        Me.OpenFileDialog1.Filter = "(*.xls)|*.xls"

        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            DT = New DataTable
            Dim DC As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Me.OpenFileDialog1.FileName & ";Extended Properties=""Excel 8.0;HDR=YES;IMEX=1""")
            Dim DA As New OleDbDataAdapter("SELECT * FROM [" & InputBox("Nombre de la Hoja : ", "Hoja de calculo") & "$]", DC)

            Try
                DA.Fill(DT)
                '
                dgDatos.DataSource = DT
                vDatos.PopulateColumns()
                FormatoGrid(vDatos)
            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
            End Try            
        End If
    End Sub

    Private Sub bGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGuardar.Click
        If vDatos.DataRowCount = 0 Then
            XtraMsg("No Hay Datos en la Tabla")
            Exit Sub
        End If
        '

        Dim Cont As Integer = 0, Errores As Integer = 0
        Dim Conn As New DbConnect.Connect(VB.SysContab.Rutinas.AbrirConexion())

        For i As Integer = 0 To vDatos.DataRowCount - 1
            ShowSplash("Actualizando Datos...")
            Try
                Dim DR As DataRow = vDatos.GetDataRow(i)

                Conn.RemoveParameters()
                Conn.AddParameter("Factura", SqlDbType.NVarChar, 20, ParameterDirection.Input, DR.Item(0))
                Conn.AddParameter("Fecha", SqlDbType.SmallDateTime, 20, ParameterDirection.Input, DR.Item(1))
                Conn.AddParameter("Empresa", SqlDbType.Int, 5, ParameterDirection.Input, EmpresaActual)

                Conn.EjecutarComando("JAR_ActualizarVencimientoFV")

                Cont += 1
            Catch ex As Exception
                XtraMsg("ERROR en Factura #: " & IsNull(vDatos.GetRowCellValue(i, 0), "") & vbCrLf & _
                        ex.Message, MessageBoxIcon.Error)
                Errores += 1
            End Try
            HideSplash()
        Next

        XtraMsg("Facturas Actualizadas con Exito: " & Cont.ToString & vbCrLf & "Facturas sin Actualizar: " & Errores.ToString)
    End Sub

    Private Sub bExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExportar.Click
        frmExportarImprimir.Mostrar(dgDatos)
    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        Close()
    End Sub

    Private Sub frmVencimientoFacturasV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class