Public Class frmLiqBankRates

    Private Shared ChildInstance As frmLiqBankRates = Nothing

    Dim NewData As Boolean

    Public Shared Function Instance() As frmLiqBankRates
        If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
            ChildInstance = New frmLiqBankRates
        End If
        ChildInstance.BringToFront()

        Return ChildInstance
    End Function

    Private Sub frmLiqBankRates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdNew.Focus()
        cbProveedor.Properties.DataSource = ObtieneDatos("SELECT CODIGO,NOMBRE FROM Proveedores WHERE Empresa=" & EmpresaActual)
        cbProveedor.Properties.DisplayMember = "NOMBRE" : cbProveedor.Properties.ValueMember = "CODIGO"

        cbCuenta.Properties.DataSource = ObtieneDatos("SELECT Cuenta FROM Catalogo WHERE EMPRESA = 1") 'VB.SysContab.CatalogoDB.GetList_SP("")
        cbCuenta.Properties.DisplayMember = "Cuenta" : cbCuenta.Properties.ValueMember = "Cuenta"

        LoadData()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If cmdExit.Text = "&Salir" Then
            Me.Close()
        Else
            EnableDisableFields(False)
            CleanFields()
            cmdNew.Text = "&Nuevo" : cmdExit.Text = "&Salir"
        End If
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        If cmdNew.Text = "&Nuevo" Then
            NewData = True
            cmdNew.Text = "&Guardar"
            cmdExit.Text = "&Cancelar"
            EnableDisableFields(True)
            tbName.Focus()
        Else

            ObtieneDatos("SPJLiqGastosAddEdit " & IIf(NewData = True, 0, GridView1.GetFocusedRowCellValue("LiqGastoID")) & _
                         ",'" & tbName.Text & "'," & cbProveedor.EditValue & ",'" & cbCuenta.EditValue & "'," & tbMonto.Text & _
                         "," & rbTipo.EditValue & "," & NewData)

            EnableDisableFields(False)
            cmdNew.Text = "&Nuevo" : cmdExit.Text = "&Salir"
            NewData = True
            LoadData()
            CleanFields()
        End If
    End Sub

    Private Sub LoadData()
        GridControl1.DataSource = ObtieneDatos("SELECT LiqGastoID,lg.GastoNombre,p.CODIGO as ProveedorID,p.NOMBRE,lg.Cuenta,lg.Monto," & _
                                               "CAST(CASE WHEN lg.Tipo = 0 THEN 1 ELSE 0 END as BIT) AS Liquidacion," & _
                                               "CAST(CASE WHEN lg.Tipo = 0 THEN 1 ELSE 0 END as BIT) AS Prestamos " & _
                                               "FROM LiquidacionesGastos lg LEFT JOIN PROVEEDORES p ON lg.ProveedorID = p.CODIGO " & _
                                                "WHERE p.EMPRESA = " & EmpresaActual)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        NewData = False
        tbName.Text = GridView1.GetFocusedRowCellValue("GastoNombre")
        cbProveedor.EditValue = GridView1.GetFocusedRowCellValue("ProveedorID")
        cbCuenta.EditValue = GridView1.GetFocusedRowCellValue("Cuenta")
        tbMonto.Text = GridView1.GetFocusedRowCellValue("Monto")
        If GridView1.GetFocusedRowCellValue("Liquidacion") = 1 Then
            rbTipo.EditValue = True
        Else
            rbTipo.EditValue = False
        End If
        EnableDisableFields(True)
        cmdExit.Text = "&Cancelar" : cmdNew.Text = "&Guardar"
    End Sub

    Private Sub EnableDisableFields(ByVal Accion As Boolean)
        tbName.Enabled = Accion : rbTipo.Enabled = Accion
        cbProveedor.Enabled = Accion : cbCuenta.Enabled = Accion : tbMonto.Enabled = Accion
        cmdEdit.Enabled = Not Accion ': cmdNew.Enabled = Not Accion
    End Sub

    Private Sub CleanFields()
        tbName.Text = "" : rbTipo.EditValue = True
        cbProveedor.ItemIndex = -1 : cbCuenta.ItemIndex = 0
        tbMonto.Text = 0
    End Sub
End Class