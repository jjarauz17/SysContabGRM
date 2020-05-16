Imports ClasesBLL
Imports SysContab.VB.SysContab
Public Class frmDatosDevolucionCR

    Public Ok As String = "NO"
    Public NoFactura As String
    Dim dv As New DevolucionesClienteDB
    Dim cl As New ClientesDB()

    Dim EsProducto As Boolean = True
    Private Sub frmDatosDevolucionCR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        Fecha.DateTime = VB.SysContab.Rutinas.Fecha()
        txtDevolucion.Text = DevolucionesClienteDB.Numero()
        txtReferencia.Text = "NC" + IIf(NoFactura.Length < 6, NoFactura.PadLeft(6, "0"), NoFactura)
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