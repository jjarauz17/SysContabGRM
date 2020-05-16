Public Class Frm_Reporte_Kardex

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim dt As New DataTable

        'dt = DAL.Leer("sp_Kardex_Reporte '" & Fecha_Ini.EditValue & "', '" & Fecha_Fin.EditValue & "' , '" & Productos.EditValue & "'")

        'gridDatos.DataSource = dt

        'dt.TableName = "k"
        ''   dt.WriteXml("c:\nada\kardex.xml", XmlWriteMode.WriteSchema)


    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click

        Dim rpt As New rpt_Kardex
        Dim dt As New DataTable
        dt = DAL.Leer("SET DATEFORMAT DMY; EXEC sp_Kardex_Reporte '" & Fecha_Ini.EditValue & "', '" & Fecha_Fin.EditValue & "' , '" & Productos.EditValue & "', '" & txtCodigo.Text & "'")

        Dim S_Cantidad As Double = 0
        Dim S_Saldo As Double = 0


        Dim producto As String

        producto = dt.Rows(0).Item("Articulo_ID")

        For i As Integer = 0 To dt.Rows.Count - 1

            If producto <> dt.Rows(i).Item("Articulo_ID") Then
                S_Cantidad = 0
                S_Saldo = 0
                producto = dt.Rows(i).Item("Articulo_ID")
            End If




            S_Cantidad = dt.Rows(i).Item("SI_Cantidad") + dt.Rows(i).Item("E_Cantidad") - dt.Rows(i).Item("S_Cantidad") + S_Cantidad
            dt.Rows(i).Item("SF_Cantidad") = S_Cantidad

            S_Saldo = dt.Rows(i).Item("SI_Importe") + dt.Rows(i).Item("E_Importe") - dt.Rows(i).Item("S_Importe") + S_Saldo
            dt.Rows(i).Item("SF_Saldo") = S_Saldo

            If dt.Rows(i).Item("SF_Cantidad") = 0 Then
                dt.Rows(i).Item("costo") = 0
            Else
                dt.Rows(i).Item("costo") = dt.Rows(i).Item("SF_Saldo") / dt.Rows(i).Item("SF_Cantidad")
            End If



        Next

        rpt.DataSource = dt
        rpt.ShowPreview()


    End Sub

    Private Sub Frm_Reporte_Kardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Fecha_Ini.EditValue = Today.AddDays(-30)
        Fecha_Fin.EditValue = Today

        Productos.Properties.DataSource = DAL.Leer("SELECT '%' as Articulo_ID, '-- Todos los Articulos --' as Articulo_Descripcion UNION ALL SELECT ac.Articulo_ID, ac.Articulo_Descripcion FROM ArticulosCC ac")
        Productos.Properties.DisplayMember = "Articulo_Descripcion"
        Productos.Properties.ValueMember = "Articulo_ID"


    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rpt As New rtp_Inventario
        Dim dt As New DataTable

        dt = DAL.Leer("sp_Inventario_Consolidado '" & Fecha_Ini.EditValue & "', '" & Fecha_Fin.EditValue & "'")

        Dim ds As New DataSet
        ds.Tables.Add(dt)
        ds.WriteXml("c:\rtp_Inventario.xml", XmlWriteMode.WriteSchema)

        rpt.DataSource = dt
        rpt.ShowPreview()


    End Sub

    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Buscar()
    End Sub


    Private Sub Buscar()

        Dim f As New FrmBusquedas
        f.txtProducto.Focus()
        f.ShowDialog()

        If f.Regresa = True Then
            'Vista.SetRowCellValue(Vista.FocusedRowHandle, "Codigo", f.gvPorts.GetRowCellValue(f.gvPorts.FocusedRowHandle, "Codigo"))
            'dgArticulos.f

            txtCodigo.Text = f.Cadena

        Else

            txtCodigo.Text = ""

        End If

    End Sub



End Class