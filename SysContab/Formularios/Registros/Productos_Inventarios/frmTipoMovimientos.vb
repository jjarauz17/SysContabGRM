Public Class frmTipoMovimientos 
    Public Nuevo As String, Ok As String
    Public ID As Integer

    Private Sub frmTipoMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetCatalogoCuenta(Me.cbCatalogo1, vCat1)
        GeMovimientos_Clases(Me.cbClases, 0)
        GetTipoComprobantesList(cbTipo)
        '
        If Nuevo = "NO" Then
            MostrarDatos()
        End If
    End Sub

    Sub MostrarDatos()
        Dim dt As DataTable = ObtieneDatos("SELECT * FROM TipoMovimientos WHERE ID = " & ID & " AND Empresa = " & EmpresaActual)

        Me.txtNombre.Text = dt.Rows.Item(0)("Nombre")
        Me.cbCatalogo1.EditValue = dt.Rows.Item(0)("Cuenta")
        Me.cbClases.EditValue = dt.Rows.Item(0)("IdClase")
        chkAjuste.Checked = dt.Rows.Item(0)("Ajuste")
        cbTipo.EditValue = dt.Rows.Item(0)("Comp_Tipo")
        chkProyecto.Checked = dt.Rows.Item(0)("Proyecto")
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Ok = "NO"
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If Me.txtNombre.Text.Trim.Length = 0 Then
            XtraMsg("Describa el Nombre del Movimiento")
            Me.txtNombre.Focus()
            Exit Sub
        End If
        '
        If Me.cbCatalogo1.EditValue Is Nothing Then
            XtraMsg("Seleccione cuenta contable asignada al tipo de movimiento")
            cbCatalogo1.Focus()
            Exit Sub
        End If
        '
        If cbTipo.EditValue Is Nothing Then
            XtraMsg("Seleccione el Tipo de Comprobante!")
            cbTipo.Focus()
            Exit Sub
        End If
        '
        Guardar()
    End Sub

    Sub Guardar()
        If Me.Nuevo = "SI" Then
            If GuardaDatos("INSERT INTO TipoMovimientos (Nombre, Cuenta, Empresa, IdClase, Ajuste,Comp_Tipo, Proyecto) VALUES ('" & Me.txtNombre.Text & "','" & Me.cbCatalogo1.EditValue & "'," & EmpresaActual & "," & Me.cbClases.EditValue & "," & IIf(chkAjuste.Checked, 1, 0) & "," & cbTipo.EditValue & ", " & IIf(chkProyecto.Checked, 1, 0) & ")") Then
                Ok = "SI"
                Me.Close()
            End If
        Else
            If GuardaDatos("UPDATE TipoMovimientos SET Nombre = '" & Me.txtNombre.Text & "',Cuenta = '" & Me.cbCatalogo1.EditValue & "', IdClase = " & Me.cbClases.EditValue & ", Ajuste = " & IIf(chkAjuste.Checked, 1, 0) & ", Comp_Tipo = " & cbTipo.EditValue & ", Proyecto = " & IIf(chkProyecto.Checked, 1, 0) & "" _
                        + " WHERE ID = " & ID & " AND Empresa = " & EmpresaActual) Then
                Ok = "SI"
                Me.Close()
            End If
        End If
    End Sub
End Class