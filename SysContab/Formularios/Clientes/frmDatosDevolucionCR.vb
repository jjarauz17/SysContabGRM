Imports ClasesBLL
Imports SysContab.VB.SysContab
Public Class frmDatosDevolucionCR

    Public Ok As String = "NO"
    Public NoFactura As String
    Dim dv As New DevolucionesClienteDB(),
        Cajas As New CajasDB(),
        cl As New ClientesDB()

    Dim EsProducto As Boolean = True,
        IdCaja As Integer = 0
    Private Sub frmDatosDevolucionCR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)
        'Verificar si la PC contiene configuración de Caja.
        Dim dsCajas As DataSet = Cajas.PcNombre(Environment.MachineName.ToString)

        If dsCajas.Tables("Cajas").Rows.Count > 0 Then
            IdCaja = dsCajas.Tables("Cajas").Rows(0).Item("cj_Codigo")
        End If

        Fecha.DateTime = VB.SysContab.Rutinas.Fecha()
        txtDevolucion.Text = DevolucionesClienteDB.Numero()
        'txtReferencia.Text = "NC" + IIf(NoFactura.Length < 6, NoFactura.PadLeft(6, "0"), NoFactura)
        GetTipoMovimientos(cbMovimientos, 1)
        cbMovimientos.ItemIndex = 0

        Combo(cbTipoNota, db_TipoNotasCD.Listar(0), "[Seleccione Tipo de Nota]")
        '
        txtTCambio.EditValue = GetTasaCambioDia(Fecha.DateTime.Date)

        If cl.FacturaDetalleDevolucion(NoFactura).Tables("Facturas_Ventas").Rows.Count = 0 Then
            EsProducto = False
            lyMovimiento.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' lyTipoNC.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
        '
        CargaSeries()
        '
        txtnota.Text = $"NC{IIf(NoFactura.Length < 6, NoFactura.PadLeft(6, "0"), NoFactura)}"
    End Sub

    Private Sub chkSerie_CheckedChanged(sender As Object, e As EventArgs) Handles chkSerie.CheckedChanged
        GetNumeroNotaSerie()
    End Sub

    Private Sub cmbserie_EditValueChanged(sender As Object, e As EventArgs) Handles cmbserie.EditValueChanged
        If cmbserie.EditValue Is Nothing Then Exit Sub
        '
        GetNumeroNotaSerie()
    End Sub
    '
    Function CargaSeries() As Boolean

        'Dim objFactura As New FACTURAS_VENTAS
        'objFactura = Facturas_VentasDB.Detalles(txtFactura.Text)

        Dim _dt As DataTable = ObtieneDatos("sp_sel_SeriesCajas",
                                            IdCaja,
                                            EmpresaActual,
                                            "NC")
        LookUp(cmbserie,
               _dt,
               "Serie",
               "IdDetalle",
               "",
               0, 3, 4)

        cmbserie.Properties.ShowHeader = True

        If _dt.Rows.Count = 0 Then Return False
        If _dt.Rows.Count > 0 Then Return True
    End Function

    Sub GetNumeroNotaSerie()

        If chkSerie.Checked Then
            If CargaSeries() Then
                txtnota.Properties.ReadOnly = True
                txtnota.Text = String.Empty
                cmbserie.Enabled = True
                cmbserie.ItemIndex = 0
                '
                txtnota.Text = Format(cmbserie.GetColumnValue("Factura"), "00000000")
            Else
                XtraMsg("No se han encontrados series configuradas.",
                        MessageBoxIcon.Error)
                chkSerie.Checked = False
            End If
        Else
            cmbserie.EditValue = Nothing
            txtnota.Properties.ReadOnly = False
            cmbserie.Enabled = False
            'txtnota.Text = db_MaestroNotasCD.GetNumero(1)
            txtnota.Text = $"NC{IIf(NoFactura.Length < 6, NoFactura.PadLeft(6, "0"), NoFactura)}"
            txtnota.Focus()
            txtnota.SelectAll()
        End If

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If Not DxValidationProvider1.Validate Then Exit Sub

        'Verificar Cierre del Día
        '*******************************************************************************************
        If Not VerificarCierre(Fecha.DateTime.Date) Then
            Ok = "NO"
            Exit Sub
        End If
        '
        If EsProducto Then
            ' Validar Cierre de Inventario
            If Not VerificarCierre_Inventario(Fecha.DateTime.Date) Then
                Ok = "NO"
                Exit Sub
            End If
        End If
        '*******************************************************************************************   
        '
        If cbTipoNota.EditValue Is Nothing Then
            XtraMsg("Seleccione el tipo de Nota de Crédito")
            cbTipoNota.Focus()
            Ok = "NO"
            Exit Sub
        End If
        '
        If EsProducto Then
            If cbMovimientos.ItemIndex = 0 Then
                XtraMsg("Seleccione el Tipo de Movimiento de Inventario")
                cbMovimientos.Focus()
                Ok = "NO"
                Exit Sub
            End If
        End If
        '
        '*******************************************************************************************
        'Verificar Cierre de Bolsa
        If Fecha.DateTime.Date <= db_FACTURAS_BOLSA.UltimoCierre().Date Then
            XtraMsg("La fecha: " & Fecha.DateTime.ToShortDateString & " con la que intenta grabar esta Devolución ya fue reportada en BOLSA AGROPECUARIA, " & vbCrLf &
                    "Ultima fecha reportada al: " & db_FACTURAS_BOLSA.UltimoCierre().Date.ToShortDateString, MessageBoxIcon.Error)
            Ok = "NO"
            Exit Sub
        End If
        '*******************************************************************************************

        If chkSerie.Checked Then
            If Not cmbserie.EditValue Is Nothing Then
                txtnota.Text = $"{cmbserie.Text}{txtnota.Text}"
            Else
                txtnota.Text = $"NC{txtnota.Text.PadLeft(6, "0"c)}"
            End If
        Else
            txtnota.Text = $"NC{IIf(NoFactura.Length < 6, NoFactura.PadLeft(6, "0"), NoFactura)}"
        End If
        '
        If db_MaestroNotasCD.Buscar(txtnota.Text) = "SI" Then
            txtnota.Text = $"{txtnota.Text}-2"
        End If

        Ok = "SI"
        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Ok = "NO"
        Close()
    End Sub

    Private Sub Fecha_EditValueChanged(sender As Object, e As EventArgs) Handles Fecha.EditValueChanged
        txtTCambio.EditValue = GetTasaCambioDia(IsNull(Fecha.DateTime.Date, Now.Date))
    End Sub
End Class