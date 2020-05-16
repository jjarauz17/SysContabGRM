Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmFacturasClientes_SaldoInicial

    Private Clientes As New VB.SysContab.ClientesDB

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        My.Forms.frmExportarImprimir.Mostrar(Me.gridDatos)
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim DT As New DataTable
        Me.OpenFileDialog1.DefaultExt = "*.xls"
        Me.OpenFileDialog1.Filter = "(*.xls)|*.xls"

        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                Dim DC As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Me.OpenFileDialog1.FileName & ";Extended Properties=""Excel 8.0;HDR=YES;IMEX=1""")
                Dim DA As New OleDbDataAdapter("SELECT * FROM [" & InputBox("Nombre de la Hoja : ", "Hoja de calculo") & "$]", DC)
                DA.Fill(DT)

                If DT.Columns.Count - 1 <> 6 Then
                    MsgBox("Deben ser Siete (7) columnas para Importar el Archivo")
                    Exit Sub
                End If

                'Crear Producto Saldo Inicial *****
                GuardaDatos("sp_VerificarProducto " & EmpresaActual)

                '' Verificar Si el Cliente Existe
                For i As Integer = 0 To DT.Rows.Count - 1
                    Dim Variables As New ArrayList
                    Dim Datos As New ArrayList

                    Variables.Add("Codigo")
                    Variables.Add("Nombre")
                    Variables.Add("Empresa")

                    Datos.Add(DT.Rows(i).Item(3))   'Codigo del Cliente
                    Datos.Add(DT.Rows(i).Item(4))   'Nombre del Cliente
                    Datos.Add(EmpresaActual)
                    ProcedureParameters(Datos, Variables, "sp_VerificarCliente")
                Next

                DBConnFacturas = New SqlConnection(VB.SysContab.Rutinas.AbrirConexion())
                DBConnFacturas.Open()
                transaccionFacturas = DBConnFacturas.BeginTransaction

                Try
                    For i As Integer = 0 To DT.Rows.Count - 1
                        '*** Encabezado de la Factura
                        Clientes.AddFactura(DT.Rows(i).Item(0), DT.Rows(i).Item(1), _
                        ObtieneDatos("SELECT c.CODIGO FROM CLIENTES c WHERE c.CodigoLetra = '" & DT.Rows(i).Item(3) & "' AND c.EMPRESA = " & EmpresaActual).Rows.Item(0)(0), _
                        "", DT.Rows(i).Item(5), DT.Rows(i).Item(5), 0, 0, "0", "0", _
                        DT.Rows(i).Item(5), DT.Rows(i).Item(5), 0, DT.Rows(i).Item(2), _
                        DT.Rows(i).Item(2), 0, 50, DT.Rows(i).Item(4), 0, Me.cmbmoneda.EditValue, "", 0, _
                        "0", "0", "0", "0", "0", "", 0, 0, DT.Rows(i).Item(6))

                        '*** Detalle de la Factura
                        Clientes.AddFacturaLineas(DT.Rows(i).Item(0), "999999", 1, DT.Rows(i).Item(5), 0, _
                         0, DT.Rows(i).Item(5), 0, "P", 0, "Saldo Inicial de Clientes")

                        GuardaDatosTrans("UPDATE FACTURAS_VENTAS SET SI = 1 WHERE FACTURA = '" & DT.Rows(i).Item(0) & "' AND EMPRESA = " & EmpresaActual)
                    Next

                    MsgBox("Se ha Importado " & DT.Rows.Count.ToString & " Facturas de Clientes Satisfactoriamente", MsgBoxStyle.Exclamation)
                    VB.SysContab.Rutinas.okTransaccion()

                    Cargar()
                Catch ex As Exception
                    MsgBox("ERROR en Datos : " & ex.Message, MsgBoxStyle.Critical)
                    VB.SysContab.Rutinas.ErrorTransaccion()
                End Try

            Catch ex As Exception
                XtraMsg(ex.Message, MessageBoxIcon.Error)
            End Try
            'ListaArticulos()
        End If
    End Sub

    Private Sub btnFormato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormato.Click
        My.Forms.frmFormato_SadoInicial.ShowDialog()
        My.Forms.frmFormato_SadoInicial.Dispose()
    End Sub

    Private Sub frmFacturasClientes_SaldoInicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
        GetMonedasList(cmbmoneda)
    End Sub

    Sub Cargar()
        Me.gridDatos.DataSource = ObtieneDatos("sp_FacturasClientes_SaldoInicial " & EmpresaActual)
        Me.vDatos.PopulateColumns()

        FormatoGrid(Me.vDatos)

        Me.vDatos.Columns("Forma Pago").Visible = False
        Me.vDatos.Columns("DIAS").Visible = False
        Me.vDatos.Columns("Descuento").Visible = False
        Me.vDatos.Columns("IVA").Visible = False

        Me.vDatos.Columns("F/Vencimiento").Width = 120
        Me.vDatos.Columns("Cliente").Width = 210

        Me.vDatos.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("Sub Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Sub Total").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Sub Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Sub Total").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Total").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Total").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("Abono").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Abono").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Abono").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Abono").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("Saldo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Saldo").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Saldo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Saldo").SummaryItem.DisplayFormat = "{0:n2}"

        Me.vDatos.Columns("Saldo U$").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.vDatos.Columns("Saldo U$").DisplayFormat.FormatString = "{0:n2}"
        Me.vDatos.Columns("Saldo U$").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.vDatos.Columns("Saldo U$").SummaryItem.DisplayFormat = "{0:n2}"
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If Me.vDatos.DataRowCount = 0 Then
            MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.vDatos.FocusedRowHandle < 0 Then
            MsgBox("Seleccione una Factura", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.vDatos.GetFocusedRowCellValue("Abono") > 0 Then
            MsgBox("La Factura Contiene Abonos, NO puede ser Borrada", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Esta Seguro que desea Borrar la Factura Señalada, " & vbCrLf & _
                        "Una vez realizado este proceso no podra deshacer los cambios " & vbCrLf & _
                        "¿Borrar Factura #: " & Me.vDatos.GetFocusedRowCellValue("No Factura") & " ?", _
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        If GuardaDatos("sp_BorrarFacturaV '" & Me.vDatos.GetFocusedRowCellValue("No Factura") & "'," & EmpresaActual) Then
            MsgBox("La Factura ha Sido Borrada de la Base de Datos", MsgBoxStyle.Information)
            Cargar()
        Else
            MsgBox("ERROR : La Operación no se pudo Completar, Consulte con el Administrador del Sistema", MsgBoxStyle.Critical)
        End If
    End Sub
End Class