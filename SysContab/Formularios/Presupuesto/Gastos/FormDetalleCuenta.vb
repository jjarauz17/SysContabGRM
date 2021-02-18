Public Class FormDetalleCuenta
    Private Sub FormDetalleCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function cargargrid(mes As String, cuenta As String, empresa As Integer, perid As Integer, cencost As Integer)
        Dim m As Integer = 0
        If (mes = "Enero") Then
            m = 1
        End If
        If (mes = "Febrero") Then
            m = 2
        End If
        If (mes = "Marzo") Then
            m = 3
        End If
        If (mes = "Abril") Then
            m = 4
        End If
        If (mes = "Mayo") Then
            m = 5
        End If
        If (mes = "Junio") Then
            m = 6
        End If
        If (mes = "Julio") Then
            m = 7
        End If
        If (mes = "Agosto") Then
            m = 8
        End If
        If (mes = "Septiembre") Then
            m = 9
        End If
        If (mes = "Octubre") Then
            m = 10
        End If
        If (mes = "Noviembre") Then
            m = 11
        End If
        If (mes = "Diciembre") Then
            m = 12
        End If

        Me.Text = "Gastos de " + mes
        GridControl1.DataSource = ObtieneDatos("SP_Mostrar_Detalle_Cuenta", m, perid, empresa, cuenta, cencost)
        GridView1.PopulateColumns()
        Utils.FormatoGrid(GridView1, 2, 0)
        GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        GridView1.OptionsView.ColumnAutoWidth = True

        GridView1.Columns("Tipo").OptionsColumn.AllowEdit = False
        GridView1.Columns("Tipo").OptionsColumn.AllowFocus = False

        GridView1.Columns("No. de Comprobante").OptionsColumn.AllowEdit = False
        GridView1.Columns("No. de Comprobante").OptionsColumn.AllowFocus = False

        GridView1.Columns("Concepto de Comprobante").OptionsColumn.AllowEdit = False
        GridView1.Columns("Concepto de Comprobante").OptionsColumn.AllowFocus = False

        GridView1.Columns("Fecha de Pago").OptionsColumn.AllowEdit = False
        GridView1.Columns("Fecha de Pago").OptionsColumn.AllowFocus = False

        GridView1.Columns("Usuario").OptionsColumn.AllowEdit = False
        GridView1.Columns("Usuario").OptionsColumn.AllowFocus = False

        GridView1.Columns("Valor").OptionsColumn.AllowEdit = False
        GridView1.Columns("Valor").OptionsColumn.AllowFocus = False
    End Function
End Class