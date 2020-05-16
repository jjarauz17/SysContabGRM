Public Class frmGruposBalResAdd

    Public Editar As Boolean = False
    Public IdGrupo As Integer = 0
    Public Tipo As String

    Dim db As New db_GruposBalRes
    Dim obj As New GruposBalRes

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Regresar()
    End Sub

    Private Sub frmCustomerAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddValidation(Me, DxValidationProvider1)

        Combo(cbGruposPadres, db_GruposBalRes.GetGruposPadres(Tipo))
        ' Combo(cbCatalogo, db_Cuentas.Listar_Catalogo("%"))
        Combo(cbFormula, db_GruposBalRes.GetGruposPadres(Tipo))
        '
        If Tipo.Equals("R") Then
            rgGrupo.EditValue = 2
            lyGrupos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '
            lyUtilidadMes.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyUtilidadPeriodo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyVentas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lyAnexo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyFactor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lyColumna.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            Combo(cbFormula2, db_GruposBalRes.GetGruposPadres(Tipo))
        Else
            chkUtilidadPerdida.Checked = False
            lyUtilidadPerdida.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyVentas.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyAnexo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lyFactor.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            lyColumna.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lyVentasRubros.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

        If Editar = True Then

            obj = db_GruposBalRes.Detalles(IdGrupo, Tipo)

            txtCodigo.Text = obj.Codigo
            'txtCodigo.Text = ""
            txtNombre.Text = obj.Nombre
            sNivel.EditValue = obj.Nivel
            sFactor.EditValue = obj.Factor
            chkMovimientos.Checked = IIf(obj.Movimiento = 0, False, True)
            sColumna.EditValue = obj.Columna
            chkAnexo.Checked = IIf(obj.Anexo = 0, False, True)

            If obj.Titulo = 1 Then rgTitulos.EditValue = 0
            If obj.SubTitulo = 1 Then rgTitulos.EditValue = 1
            If obj.Negrita = 1 Then rgTitulos.EditValue = 2
            If obj.Titulo = 0 And obj.SubTitulo = 0 And obj.Negrita = 0 Then rgTitulos.EditValue = 3

            rgGrupo.EditValue = obj.Tipo_Grupo

            'chkTitulo.Checked = IIf(obj.Titulo = 0, False, True)
            Color.EditValue = obj.Color
            Fuente.EditValue = obj.Fuente
            'cbCatalogo.EditValue = obj.Cuenta
            txtCuenta.Text = obj.Cuenta
            ' cbFormula.EditValue = obj.Formula
            cbFormula.SetEditValue(obj.Formula)
            cbFormula2.SetEditValue(obj.VentaDeCosto)
            rOpciones.EditValue = obj.Operacion
            cbGruposPadres.EditValue = obj.IdPadre
            'sFactor.EditValue = obj.Factor
            'SFactor2.EditValue = obj.Factor2
            'SFactor3.EditValue = obj.Factor3
            chkUtilidadPerdida.Checked = IIf(obj.Utilidad = 0, False, True)
            chkUtilidadMes.Checked = IIf(obj.Utilidad_Mes = 0, False, True)
            chkUtilidadAcumulado.Checked = IIf(obj.Utilidad_Acumulado = 0, False, True)
            chkVentas.Checked = IIf(obj.VentasTotales = 0, False, True)
        End If
    End Sub


    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If Not DxValidationProvider1.Validate() Then Exit Sub

        Guardar()
        Regresar()
    End Sub


    Sub Guardar()
        With obj
            .IdGrupo = IdGrupo
            .Codigo = IIf(txtCodigo.Text Is Nothing, "", txtCodigo.Text)
            .Nombre = txtNombre.Text
            .Nivel = sNivel.EditValue
            .Tipo = Tipo
            .Factor = sFactor.EditValue
            .Orden = 0
            .Movimiento = IIf(chkMovimientos.Checked, 1, 0)
            .Columna = sColumna.EditValue
            .Anexo = IIf(chkAnexo.Checked, 1, 0)
            '.Titulo = IIf(chkTitulo.Checked, 1, 0)
            .Titulo = IIf(rgTitulos.EditValue = 0, 1, 0)
            .SubTitulo = IIf(rgTitulos.EditValue = 1, 1, 0)
            .Negrita = IIf(rgTitulos.EditValue = 2, 1, 0)
            .Color = IIf(Color.EditValue Is Nothing, "", Color.Text)
            .Fuente = IIf(Fuente.EditValue Is Nothing, "", Fuente.EditValue)
            '.Cuenta = IIf(cbCatalogo.EditValue Is Nothing, "", cbCatalogo.EditValue)
            .Cuenta = IIf(txtCuenta.Text.Trim.Length = 0, "", txtCuenta.Text)
            .Operacion = rOpciones.EditValue
            .Formula = IIf(cbFormula.EditValue Is Nothing, "", cbFormula.EditValue)
            .IdPadre = IIf(cbGruposPadres.EditValue Is Nothing, 0, cbGruposPadres.EditValue)
            .Usuario = Login
            .Registro = VB.SysContab.Rutinas.Fecha()
            .Tipo_Grupo = rgGrupo.EditValue
            '.Factor = sFactor.EditValue
            '.Factor2 = SFactor2.EditValue
            '.Factor3 = SFactor3.EditValue
            .Utilidad = IIf(chkUtilidadPerdida.Checked = True, 1, 0)
            .Utilidad_Mes = IIf(chkUtilidadMes.Checked = True, 1, 0)
            .Utilidad_Acumulado = IIf(chkUtilidadAcumulado.Checked = True, 1, 0)
            .VentasTotales = IIf(chkVentas.Checked = True, 1, 0)
            .Empresa = EmpresaActual
            .VentaDeCosto = IIf(cbFormula2.EditValue Is Nothing, "", cbFormula2.EditValue)
        End With

        If Editar Then
            db.Actualizar(obj)
        Else
            IdGrupo = db.Insertar(obj)
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If Not DxValidationProvider1.Validate() Then Exit Sub

        Guardar()
        Editar = True
    End Sub

    Sub Regresar()
        Close()
    End Sub

    Private Sub cbCatalogo_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cbCatalogo.ButtonClick
        If e.Button.Index = 1 Then
            With frmCuentasBuscar
                .ShowDialog()
                If .ok = "SI" Then
                    cbCatalogo.EditValue = .Cuenta
                End If
                .Dispose()
            End With
        End If
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        With frmCuentasBuscar
            .CuentasMarcar = txtCuenta.Text
            .ShowDialog()
            If .ok = "SI" Then
                txtCuenta.Text = .Cuenta
            End If
            .Dispose()
        End With
    End Sub
End Class